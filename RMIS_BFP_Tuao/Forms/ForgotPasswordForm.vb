Public Class ForgotPasswordForm

    Private _verifiedUsername As String = ""

    Private ReadOnly SecurityQuestions As String() = {
        "What is your mother's maiden name?",
        "What was the name of your first pet?",
        "What is the name of the city where you were born?",
        "What was the name of your elementary school?",
        "What is your favorite childhood nickname?"
    }

    Private Sub ForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSecQuestion.Items.AddRange(SecurityQuestions)
    End Sub

    ' ── Verify username only — do NOT reveal which question is stored ─────────

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        HidePasswordFields()
        HideStatus()

        Dim username = txtUsername.Text.Trim()
        If username = "" Then
            ShowStatus("Please enter your username.")
            Exit Sub
        End If

        Try
            Dim question = UserRepository.GetSecurityQuestion(username)

            If question = "" Then
                ShowStatus("Username not found, or no security question has been set for this account." &
                           " Please contact your administrator.")
                Exit Sub
            End If

            _verifiedUsername = username

            lblSecQuestion.Visible  = True
            cboSecQuestion.Visible  = True
            cboSecQuestion.SelectedIndex = -1
            lblAnswer.Visible       = True
            txtAnswer.Visible       = True
            txtAnswer.Clear()
            cboSecQuestion.Focus()

        Catch ex As Exception
            ShowStatus("Database error: " & ex.Message)
        End Try
    End Sub

    ' ── Reveal password fields after answer is typed ──────────────────────────

    Private Sub txtAnswer_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer.TextChanged
        If txtAnswer.Visible AndAlso txtAnswer.Text.Trim() <> "" Then
            lblNewPassword.Visible     = True
            txtNewPassword.Visible     = True
            lblConfirmPassword.Visible = True
            txtConfirmPassword.Visible = True
            btnReset.Visible           = True
        End If
    End Sub

    ' ── Reset password ────────────────────────────────────────────────────────

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        HideStatus()

        If cboSecQuestion.SelectedIndex = -1 Then
            ShowStatus("Please select your security question.")
            Exit Sub
        End If

        Dim selectedQuestion = cboSecQuestion.SelectedItem.ToString()
        Dim answer           = txtAnswer.Text.Trim()
        Dim newPassword      = txtNewPassword.Text
        Dim confirmPw        = txtConfirmPassword.Text

        If answer = "" Then
            ShowStatus("Please enter your security answer.")
            Exit Sub
        End If

        If newPassword = "" Then
            ShowStatus("New password cannot be empty.")
            Exit Sub
        End If

        If newPassword <> confirmPw Then
            ShowStatus("Passwords do not match. Please try again.")
            Exit Sub
        End If

        Try
            ' Verify selected question matches stored question AND answer is correct.
            ' Same error message either way — prevents probing which was wrong.
            Dim storedQuestion = UserRepository.GetSecurityQuestion(_verifiedUsername)
            Dim questionMatch  = (selectedQuestion = storedQuestion)
            Dim answerMatch    = UserRepository.VerifySecurityAnswer(_verifiedUsername, answer)

            If Not questionMatch OrElse Not answerMatch Then
                ShowStatus("Incorrect security question or answer. Please try again.")
                ActivityLogger.Log(_verifiedUsername, Constants.LogFailed,
                                   "Failed password reset — wrong security question or answer.")
                Exit Sub
            End If

            UserRepository.UpdatePassword(_verifiedUsername, PasswordHelper.HashPassword(newPassword))
            ActivityLogger.Log(_verifiedUsername, Constants.LogSuccess,
                               "Password reset via security question.")

            MessageBox.Show("Your password has been reset successfully. You may now log in with your new password.",
                            "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            ShowStatus("Failed to reset password: " & ex.Message)
        End Try
    End Sub

    ' ── Cancel ───────────────────────────────────────────────────────────────

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' ── Helpers ───────────────────────────────────────────────────────────────

    Private Sub ShowStatus(message As String)
        lblStatus.Text    = message
        lblStatus.Visible = True
    End Sub

    Private Sub HideStatus()
        lblStatus.Visible = False
    End Sub

    Private Sub HidePasswordFields()
        lblNewPassword.Visible     = False
        txtNewPassword.Visible     = False
        lblConfirmPassword.Visible = False
        txtConfirmPassword.Visible = False
        btnReset.Visible           = False
        lblSecQuestion.Visible     = False
        cboSecQuestion.Visible     = False
        lblAnswer.Visible          = False
        txtAnswer.Visible          = False
        _verifiedUsername          = ""
    End Sub

End Class
