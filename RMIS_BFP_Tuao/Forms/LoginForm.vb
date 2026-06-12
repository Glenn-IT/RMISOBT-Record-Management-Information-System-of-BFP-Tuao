Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text.Trim()
        Dim password = txtPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            lblError.Text = "Please enter your username and password."
            lblError.Visible = True
            Exit Sub
        End If

        Try
            Dim dt = UserRepository.GetByUsername(username)

            If dt.Rows.Count = 0 OrElse
               Not PasswordHelper.VerifyPassword(password, dt.Rows(0)("PasswordHash").ToString()) Then
                lblError.Text = "Invalid username or password."
                lblError.Visible = True
                ActivityLogger.Log(username, Constants.LogFailed, "Login failed — wrong credentials.")
                Exit Sub
            End If

            SessionManager.Username = dt.Rows(0)("Username").ToString()
            SessionManager.UserType = dt.Rows(0)("UserType").ToString()

            ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess, "User logged in.")

            Dim main As New MainForm()
            main.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message,
                            "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then btnLogin.PerformClick()
    End Sub

End Class
