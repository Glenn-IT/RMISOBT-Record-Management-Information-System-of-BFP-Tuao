Public Class UcViewRecords
    Inherits UserControl

    ' Sample in-memory data for prototype
    Private _sampleData As New List(Of String())()

    Private Sub UcViewRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSampleData()
        PopulateGrid(_sampleData)
    End Sub

    ' Load sample records into the list
    Private Sub LoadSampleData()
        _sampleData.Clear()
        _sampleData.Add({"INC-2025-001", "Structure Fire",  "01/05/2025", "Brgy. Centro, Tuao",      "Resolved"})
        _sampleData.Add({"INC-2025-002", "Vehicular Fire",  "01/18/2025", "Maharlika Highway, Tuao",  "Resolved"})
        _sampleData.Add({"INC-2025-003", "Grass Fire",      "02/03/2025", "Brgy. Malalatan, Tuao",    "Active"})
        _sampleData.Add({"INC-2025-004", "Electrical Fire", "02/14/2025", "Brgy. Carilucud, Tuao",    "Under Investigation"})
        _sampleData.Add({"INC-2025-005", "Structure Fire",  "03/01/2025", "Brgy. Batu, Tuao",         "Active"})
        _sampleData.Add({"INC-2025-006", "Industrial Fire", "03/22/2025", "National Road, Tuao",      "Closed"})
        _sampleData.Add({"INC-2025-007", "Grass Fire",      "04/07/2025", "Brgy. Fugu, Tuao",         "Resolved"})
        _sampleData.Add({"INC-2025-008", "Structure Fire",  "04/19/2025", "Brgy. Lallayug, Tuao",     "Active"})
    End Sub

    ' Fill the DataGridView
    Private Sub PopulateGrid(data As List(Of String()))
        dgvRecords.Rows.Clear()
        For Each row In data
            dgvRecords.Rows.Add(row(0), row(1), row(2), row(3), row(4))
        Next
        lblRecordCount.Text = "Total Records: " & data.Count
    End Sub

    ' Live search filter
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim keyword = txtSearch.Text.Trim().ToLower()
        If keyword = "" Then
            PopulateGrid(_sampleData)
            Exit Sub
        End If
        Dim filtered = _sampleData.Where(
            Function(r) r.Any(Function(col) col.ToLower().Contains(keyword))
        ).ToList()
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
            _sampleData.RemoveAll(Function(r) r(0) = selectedID)
            PopulateGrid(_sampleData)
        End If
    End Sub

    ' Refresh grid
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        LoadSampleData()
        PopulateGrid(_sampleData)
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
