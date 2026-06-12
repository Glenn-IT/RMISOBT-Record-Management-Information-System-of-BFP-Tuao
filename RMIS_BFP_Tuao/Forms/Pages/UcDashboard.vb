Public Class UcDashboard
    Inherits UserControl

    Private Sub UcDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcomeSub.Text = "Welcome, " & SessionManager.Username &
                             "  |  " & DateTime.Now.ToString("MMMM dd, yyyy")
        LoadDashboardData()
    End Sub

    Private Sub LoadDashboardData()
        Try
            Dim records = RecordService.Instance.GetRecords()

            lblCard1Value.Text = records.Count.ToString()
            lblCard2Value.Text = records.Where(Function(r) r.Status = "Active").Count().ToString()
            lblCard3Value.Text = records.Where(Function(r) r.Status = "Resolved").Count().ToString()
            lblCard4Value.Text = "0"

            dgvRecent.Rows.Clear()
            For Each r In records.OrderByDescending(Function(x) x.DateReported).Take(5)
                dgvRecent.Rows.Add(r.RecordID, r.IncidentType,
                                   r.DateReported.ToString("MM/dd/yyyy"),
                                   r.Location, r.Status)
            Next
        Catch ex As Exception
            MessageBox.Show("Failed to load dashboard data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
