Public Class UcDashboard
    Inherits UserControl

    Private Sub UcDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcomeSub.Text = "Welcome, Admin  |  " & DateTime.Now.ToString("MMMM dd, yyyy")
    End Sub

End Class
