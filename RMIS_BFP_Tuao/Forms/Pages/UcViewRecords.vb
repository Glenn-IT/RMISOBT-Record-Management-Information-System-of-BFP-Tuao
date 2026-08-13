Public Class UcViewRecords
    Inherits UserControl

    Private Sub UcViewRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvRecords.ApplyDpiScaling()
        If SessionManager.UserType <> Constants.UserTypeAdmin Then
            btnEdit.Visible = False
            btnDelete.Visible = False
        End If
        Try
            InitFilters()
            ApplyFilters()
        Catch ex As Exception
            MessageBox.Show("Failed to load records: " & ex.Message,
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

    Private Sub PopulateGrid(data As List(Of RecordModel))
        dgvRecords.Rows.Clear()
        For Each r In data
            dgvRecords.Rows.Add(r.RecordID, r.IncidentType,
                            r.IncidentDateTime.ToString("MM/dd/yyyy") & " " & DateTimeHelper.ToMilitaryTime(r.IncidentDateTime),
                            r.InvolvedProperty, r.Status)
        Next
        lblRecordCount.Text = "Total Records: " & data.Count
    End Sub

    Private Sub ApplyFilters()
        Try
            Dim all = RecordService.Instance.GetRecords()
            Dim keyword = txtSearch.Text.Trim().ToLower()
            Dim selectedType = If(cmbType.SelectedIndex > 0, cmbType.SelectedItem.ToString(), "All Types")
            Dim selectedStatus = If(cmbStatus.SelectedIndex > 0, cmbStatus.SelectedItem.ToString(), "All Statuses")

            Dim filtered = all.Where(Function(r)
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

            PopulateGrid(filtered)
        Catch ex As Exception
            MessageBox.Show("Filtering error: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Filter_Changed(sender As Object, e As EventArgs) Handles txtSearch.TextChanged, cmbType.SelectedIndexChanged, cmbStatus.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If dgvRecords.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to view.", "No Selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedID = dgvRecords.SelectedRows(0).Cells("colID").Value?.ToString()
        Try
            Dim all = RecordService.Instance.GetRecords()
            Dim record = all.FirstOrDefault(Function(r) r.RecordID = selectedID)
            If record Is Nothing Then
                MessageBox.Show("Record not found.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Using dlg As New ViewRecordForm(record)
                dlg.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to open record details: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvRecords.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to edit.", "No Selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedID = dgvRecords.SelectedRows(0).Cells("colID").Value?.ToString()
        Try
            Dim all = RecordService.Instance.GetRecords()
            Dim record = all.FirstOrDefault(Function(r) r.RecordID = selectedID)
            If record Is Nothing Then
                MessageBox.Show("Record not found.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Using dlg As New EditRecordForm(record)
                If dlg.ShowDialog() = DialogResult.OK Then
                    ApplyFilters()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to open edit form: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If SessionManager.UserType <> Constants.UserTypeAdmin Then
            MessageBox.Show("Access denied. Only Admins can delete records.",
                            "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If dgvRecords.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to delete.", "No Selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim confirm = MessageBox.Show("Are you sure you want to delete this record?",
                                 "Confirm Delete",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Dim selectedID = dgvRecords.SelectedRows(0).Cells("colID").Value?.ToString()
            Try
                RecordService.Instance.DeleteRecord(selectedID)
                ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess,
                                   "Deleted incident record: " & selectedID)
                ApplyFilters()
            Catch ex As Exception
                MessageBox.Show("Failed to delete record: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            txtSearch.Clear()
            If cmbType.Items.Count > 0 Then cmbType.SelectedIndex = 0
            If cmbStatus.Items.Count > 0 Then cmbStatus.SelectedIndex = 0
            ApplyFilters()
        Catch ex As Exception
            MessageBox.Show("Failed to refresh records: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvRecords_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvRecords.RowPrePaint
        If e.RowIndex < 0 OrElse e.RowIndex >= dgvRecords.Rows.Count Then Exit Sub
        Dim statusCell = dgvRecords.Rows(e.RowIndex).Cells("colStatus")
        If statusCell.Value Is Nothing Then Exit Sub
        Select Case statusCell.Value.ToString()
            Case "Active"
                dgvRecords.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.FromArgb(180, 20, 20)
                dgvRecords.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 245, 245)
            Case "Resolved"
                dgvRecords.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.FromArgb(30, 130, 30)
                dgvRecords.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(245, 255, 245)
            Case "Closed"
                dgvRecords.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Gray
                dgvRecords.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248)
            Case "Under Investigation"
                dgvRecords.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.FromArgb(180, 100, 0)
                dgvRecords.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 250, 235)
        End Select
    End Sub

End Class
