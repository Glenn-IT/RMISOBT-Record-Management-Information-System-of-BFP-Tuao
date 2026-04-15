Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Center the form on screen
        Me.CenterToScreen()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Temporary login validation (no database)
        If txtUsername.Text.Trim() = "admin" AndAlso txtPassword.Text.Trim() = "admin123" Then
            Dim main As New MainForm()
            main.Show()
            Me.Hide()
        Else
            lblError.Visible = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        ' Allow pressing Enter to login
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

End Class
