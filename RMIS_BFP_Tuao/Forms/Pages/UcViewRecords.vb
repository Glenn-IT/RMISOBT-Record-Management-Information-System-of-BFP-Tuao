Public Class UcViewRecords
    Inherits UserControl

    Private Sub UcViewRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateGrid(RecordService.Instance.GetRecords())
    End Sub

    ' Fill the DataGridView from RecordModel list
    Private Sub PopulateGrid(data As List(Of RecordModel))
        dgvRecords.Rows.Clear()
        For Each r In data
            dgvRecords.Rows.Add(r.RecordID, r.IncidentType,
                            r.DateReported.ToString("MM/dd/yyyy"),
                            r.Location, r.Status)
        Next
        lblRecordCount.Text = "Total Records: " & data.Count
    End Sub

    ' Live search filter
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
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
    End Sub

    ' Delete selected row
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvRecords.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to delete.", "No Selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim result = MessageBox.Show("Are you sure you want to delete this record?",
                                 "Confirm Delete",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim selectedID = dgvRecords.SelectedRows(0).Cells("colID").Value?.ToString()
            RecordService.Instance.DeleteRecord(selectedID)
            PopulateGrid(RecordService.Instance.GetRecords())
        End If
    End Sub

    ' Refresh grid
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        PopulateGrid(RecordService.Instance.GetRecords())
    End Sub

    ' Row color based on Status column
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
