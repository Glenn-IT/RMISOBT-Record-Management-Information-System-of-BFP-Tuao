Public Class UcViewRecords
    Inherits UserControl

    Private Sub UcViewRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PopulateGrid(RecordService.Instance.GetRecords())
        Catch ex As Exception
            MessageBox.Show("Failed to load records: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulateGrid(data As List(Of RecordModel))
        dgvRecords.Rows.Clear()
        For Each r In data
            dgvRecords.Rows.Add(r.RecordID, r.IncidentType,
                            r.DateReported.ToString("MM/dd/yyyy"),
                            r.Location, r.Status)
        Next
        lblRecordCount.Text = "Total Records: " & data.Count
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim keyword = txtSearch.Text.Trim().ToLower()
            Dim all = RecordService.Instance.GetRecords()
            If keyword = "" Then
                PopulateGrid(all)
                Exit Sub
            End If
            Dim filtered = all.Where(Function(r)
                                         Return r.RecordID.ToLower().Contains(keyword) OrElse
                                            r.IncidentType.ToLower().Contains(keyword) OrElse
                                            r.Location.ToLower().Contains(keyword) OrElse
                                            r.Status.ToLower().Contains(keyword)
                                     End Function).ToList()
            PopulateGrid(filtered)
        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message,
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
                    PopulateGrid(RecordService.Instance.GetRecords())
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to open edit form: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
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
                PopulateGrid(RecordService.Instance.GetRecords())
            Catch ex As Exception
                MessageBox.Show("Failed to delete record: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            txtSearch.Clear()
            PopulateGrid(RecordService.Instance.GetRecords())
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
