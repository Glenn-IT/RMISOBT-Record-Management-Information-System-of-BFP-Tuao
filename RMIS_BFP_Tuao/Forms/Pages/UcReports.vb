Public Class UcReports
    Inherits UserControl

    Private _filteredRecords As New List(Of RecordModel)()

    Private Sub UcReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBreakdown.ApplyDpiScaling()
        Try
            InitFilters()
            ApplyFilters()
        Catch ex As Exception
            MessageBox.Show("Failed to load report data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InitFilters()
        cmbType.Items.Clear()
        cmbType.Items.Add("All Types")
        For Each t In Constants.IncidentTypes
            cmbType.Items.Add(t)
        Next
        cmbType.SelectedIndex = 0

        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("All Statuses")
        For Each s In Constants.Statuses
            cmbStatus.Items.Add(s)
        Next
        cmbStatus.SelectedIndex = 0
    End Sub

    Private Sub ApplyFilters()
        Try
            Dim all = RecordService.Instance.GetRecords()
            Dim keyword = txtSearch.Text.Trim().ToLower()
            Dim selectedType = If(cmbType.SelectedIndex > 0, cmbType.SelectedItem.ToString(), "All Types")
            Dim selectedStatus = If(cmbStatus.SelectedIndex > 0, cmbStatus.SelectedItem.ToString(), "All Statuses")

            _filteredRecords = all.Where(Function(r)
                ' Keyword matching
                Dim matchesKeyword = (keyword = "") OrElse
                    r.RecordID.ToLower().Contains(keyword) OrElse
                    r.IncidentType.ToLower().Contains(keyword) OrElse
                    r.InvolvedProperty.ToLower().Contains(keyword) OrElse
                    (r.Address IsNot Nothing AndAlso r.Address.ToLower().Contains(keyword)) OrElse
                    r.Status.ToLower().Contains(keyword)

                ' Type matching
                Dim matchesType = (selectedType = "All Types") OrElse
                    r.IncidentType.Equals(selectedType, StringComparison.OrdinalIgnoreCase)

                ' Status matching (Active, Resolved, Closed, Under Investigation)
                Dim matchesStatus = (selectedStatus = "All Statuses") OrElse
                    r.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase)

                Return matchesKeyword AndAlso matchesType AndAlso matchesStatus
            End Function).ToList()

            UpdateReportViews(_filteredRecords)
        Catch ex As Exception
            MessageBox.Show("Filtering error: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Filter_Changed(sender As Object, e As EventArgs) Handles txtSearch.TextChanged, cmbType.SelectedIndexChanged, cmbStatus.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            txtSearch.Clear()
            If cmbType.Items.Count > 0 Then cmbType.SelectedIndex = 0
            If cmbStatus.Items.Count > 0 Then cmbStatus.SelectedIndex = 0
            ApplyFilters()
        Catch ex As Exception
            MessageBox.Show("Failed to refresh report data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateReportViews(records As List(Of RecordModel))
        Dim total    = records.Count
        Dim active   = records.Where(Function(r) r.Status = "Active").Count()
        Dim resolved = records.Where(Function(r) r.Status = "Resolved").Count()
        Dim closed   = records.Where(Function(r) r.Status = "Closed").Count()

        lblCardTotalValue.Text    = total.ToString()
        lblCardActiveValue.Text   = active.ToString()
        lblCardResolvedValue.Text = resolved.ToString()
        lblCardClosedValue.Text   = closed.ToString()
        lblRecordCount.Text       = "Total Records: " & total

        dgvBreakdown.Rows.Clear()
        Dim types = records.Select(Function(r) r.IncidentType).Distinct().OrderBy(Function(t) t)
        For Each incType In types
            Dim group     = records.Where(Function(r) r.IncidentType = incType).ToList()
            Dim gActive   = group.Where(Function(r) r.Status = "Active").Count()
            Dim gResolved = group.Where(Function(r) r.Status = "Resolved").Count()
            Dim gOther    = group.Count - gActive - gResolved
            dgvBreakdown.Rows.Add(incType, group.Count, gActive, gResolved, gOther)
        Next
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim stationName = SettingsRepository.GetValue("StationName", "BFP Tuao Fire Station")
            ReportPrinter.Preview(_filteredRecords, stationName, SessionManager.Username)
        Catch ex As Exception
            MessageBox.Show("Failed to generate print preview: " & ex.Message,
                            "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim dlg As New SaveFileDialog()
        dlg.Filter = "CSV Files (*.csv)|*.csv"
        dlg.FileName = "RMIS_Report_" & DateTime.Now.ToString("yyyyMMdd")
        If dlg.ShowDialog() = DialogResult.OK Then
            Try
                Dim lines As New System.Text.StringBuilder()
                lines.AppendLine("Incident Type,Total Count,Active,Resolved,Other")
                For Each row As DataGridViewRow In dgvBreakdown.Rows
                    lines.AppendLine(String.Join(",",
                        row.Cells("colType").Value,
                        row.Cells("colCount").Value,
                        row.Cells("colActive").Value,
                        row.Cells("colResolved").Value,
                        row.Cells("colOther").Value))
                Next
                System.IO.File.WriteAllText(dlg.FileName, lines.ToString())
                MessageBox.Show("Report exported successfully.", "Export CSV",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Export failed: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class
