Public Class UcReports
    Inherits UserControl

    Private Sub UcReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReportData()
    End Sub

    Private Sub LoadReportData()
        Dim records = RecordService.Instance.GetRecords()

        ' Stat cards
        Dim total    = records.Count
        Dim active   = records.Where(Function(r) r.Status = "Active").Count()
        Dim resolved = records.Where(Function(r) r.Status = "Resolved").Count()
        Dim closed   = records.Where(Function(r) r.Status = "Closed").Count()

        lblCardTotalValue.Text    = total.ToString()
        lblCardActiveValue.Text   = active.ToString()
        lblCardResolvedValue.Text = resolved.ToString()
        lblCardClosedValue.Text   = closed.ToString()

        ' Breakdown by incident type
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
        MessageBox.Show("Print functionality will be available in the full release.",
                        "Print Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim dlg As New SaveFileDialog()
        dlg.Filter = "CSV Files (*.csv)|*.csv"
        dlg.FileName = "RMIS_Report_" & DateTime.Now.ToString("yyyyMMdd")
        If dlg.ShowDialog() = DialogResult.OK Then
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
        End If
    End Sub

End Class
