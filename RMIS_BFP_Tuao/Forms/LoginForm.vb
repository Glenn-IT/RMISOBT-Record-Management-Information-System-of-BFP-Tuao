Public Class LoginForm

    ' Tracks failed attempts and lockout per username for this app session
    Private Shared _failedAttempts As New Dictionary(Of String, Integer)()
    Private Shared _lockedUntil As New Dictionary(Of String, DateTime)()

    Private Const MaxAttempts As Integer = 3
    Private Const LockoutSeconds As Integer = 15

    ' Username currently under an active lockout countdown (drives tmrLockout / btnLogin text)
    Private _countdownUsername As String = Nothing

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
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
        If IsLockedOut(username) Then Exit Sub

        Try
            Dim dt = UserRepository.GetByUsername(username)

            ' Username and password must both match exactly, including case
            If dt.Rows.Count = 0 OrElse
               Not String.Equals(dt.Rows(0)("Username").ToString(), username, StringComparison.Ordinal) OrElse
               Not PasswordHelper.VerifyPassword(password, dt.Rows(0)("PasswordHash").ToString()) Then
                RecordFailedAttempt(username)
                ActivityLogger.Log(username, Constants.LogFailed, "Login failed — wrong credentials.")
                Exit Sub
            End If

            ' Success — clear lockout state for this user
            _failedAttempts.Remove(username)
            _lockedUntil.Remove(username)

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

    ' ── Lockout helpers ───────────────────────────────────────────────────────

    Private Function IsLockedOut(username As String) As Boolean
        If Not _lockedUntil.ContainsKey(username) Then Return False

        Dim remaining = (_lockedUntil(username) - DateTime.Now).TotalSeconds
        If remaining > 0 Then
            StartLockoutCountdown(username)
            Return True
        End If

        ' Lockout expired — clean up
        _lockedUntil.Remove(username)
        _failedAttempts.Remove(username)
        Return False
    End Function

    Private Sub RecordFailedAttempt(username As String)
        If Not _failedAttempts.ContainsKey(username) Then _failedAttempts(username) = 0
        _failedAttempts(username) += 1

        If _failedAttempts(username) >= MaxAttempts Then
            _lockedUntil(username) = DateTime.Now.AddSeconds(LockoutSeconds)
            _failedAttempts.Remove(username)
            StartLockoutCountdown(username)
        Else
            Dim remaining = MaxAttempts - _failedAttempts(username)
            ShowError($"Invalid username or password. {remaining} attempt(s) remaining before lockout.")
        End If
    End Sub

    ' ── Countdown on the Login button ────────────────────────────────────────

    Private Sub StartLockoutCountdown(username As String)
        _countdownUsername = username
        btnLogin.Enabled = False
        lblError.Visible = False
        UpdateCountdownDisplay()
        tmrLockout.Start()
    End Sub

    Private Sub UpdateCountdownDisplay()
        Dim remaining = CInt(Math.Ceiling((_lockedUntil(_countdownUsername) - DateTime.Now).TotalSeconds))
        If remaining > 0 Then
            btnLogin.Text = $"LOCKED ({remaining}s)"
        Else
            EndLockoutCountdown()
        End If
    End Sub

    Private Sub EndLockoutCountdown()
        tmrLockout.Stop()
        _countdownUsername = Nothing
        btnLogin.Text = "LOGIN"
        btnLogin.Enabled = True
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

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then btnLogin.PerformClick()
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
