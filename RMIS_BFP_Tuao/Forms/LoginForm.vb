Imports RMIS_BFP_Tuao.Helpers

Public Class LoginForm

    ' Username currently under an active lockout countdown (drives tmrLockout / btnLogin text)
    Private _countdownUsername As String = Nothing

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            picLogo.Image = BannerHelper.GetCurrentBanner()
        Catch
            ' Leave picLogo blank if the saved banner can't be loaded
        End Try
    End Sub

    ' ── Login ─────────────────────────────────────────────────────────────────

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text.Trim()
        Dim password = txtPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            ShowError("Please enter your username and password.")
            Exit Sub
        End If

        ' Check lockout before hitting the database
        Dim lockout = LoginAttemptTracker.CheckLockout(username)
        If lockout.IsLockedOut Then
            StartLockoutCountdown(username)
            Exit Sub
        End If

        Try
            Dim dt = UserRepository.GetByUsername(username)

            ' Username and password must both match exactly, including case
            If dt.Rows.Count = 0 OrElse
               Not String.Equals(dt.Rows(0)("Username").ToString(), username, StringComparison.Ordinal) OrElse
               Not PasswordHelper.VerifyPassword(password, dt.Rows(0)("PasswordHash").ToString()) Then
                
                Dim result = LoginAttemptTracker.RecordFailedAttempt(username)
                ActivityLogger.Log(username, Constants.LogFailed, "Login failed — wrong credentials.")
                ClearCredentialFields()

                If result.IsLockedOut Then
                    StartLockoutCountdown(username)
                Else
                    ShowError($"Invalid username or password. {result.RemainingAttempts} attempt(s) remaining before lockout.")
                End If
                Exit Sub
            End If

            ' Success — clear lockout state for this user
            LoginAttemptTracker.Reset(username)

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

    ' ── Countdown on the Login button ────────────────────────────────────────

    Private Sub StartLockoutCountdown(username As String)
        _countdownUsername = username
        btnLogin.Enabled = False
        UpdateCountdownDisplay()
        tmrLockout.Start()
    End Sub

    Private Sub UpdateCountdownDisplay()
        If String.IsNullOrEmpty(_countdownUsername) Then
            EndLockoutCountdown()
            Return
        End If

        Dim lockout = LoginAttemptTracker.CheckLockout(_countdownUsername)
        If lockout.IsLockedOut Then
            btnLogin.Text = $"LOCKED ({lockout.RemainingSeconds}s)"
            ShowError($"Too many failed attempts. Account locked for {lockout.RemainingSeconds} second(s).")
        Else
            EndLockoutCountdown()
        End If
    End Sub

    Private Sub EndLockoutCountdown()
        tmrLockout.Stop()
        If Not String.IsNullOrEmpty(_countdownUsername) Then
            LoginAttemptTracker.Reset(_countdownUsername)
        End If
        _countdownUsername = Nothing
        btnLogin.Text = "LOGIN"
        btnLogin.Enabled = True
        lblError.Visible = False
        txtPassword.Focus()
    End Sub

    Private Sub tmrLockout_Tick(sender As Object, e As EventArgs) Handles tmrLockout.Tick
        UpdateCountdownDisplay()
    End Sub

    ' ── Forgot Password ───────────────────────────────────────────────────────

    Private Sub lnkForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgotPassword.LinkClicked
        Using frm As New ForgotPasswordForm()
            frm.ShowDialog(Me)
        End Using
    End Sub

    ' ── Shared helpers ────────────────────────────────────────────────────────

    Private Sub ShowError(message As String)
        lblError.Text = message
        lblError.Visible = True
    End Sub

    Private Sub ClearCredentialFields()
        txtPassword.Clear()
        txtPassword.Focus()
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtPassword.Text.Trim() = "" Then
                txtPassword.Focus()
            ElseIf btnLogin.Enabled Then
                btnLogin.PerformClick()
            End If
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If btnLogin.Enabled Then
                btnLogin.PerformClick()
            End If
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?",
                                      "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
