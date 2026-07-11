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
            pnlAnswerRow.Visible    = True
            txtAnswer.Clear()
            cboSecQuestion.Focus()

        Catch ex As Exception
            ShowStatus("Database error: " & ex.Message)
        End Try
    End Sub

    ' ── Verify security question + answer before revealing new-password fields ─

    Private Sub btnVerifyAnswer_Click(sender As Object, e As EventArgs) Handles btnVerifyAnswer.Click
        HideStatus()
        If Not IsSecurityAnswerCorrect() Then Exit Sub

        lblNewPassword.Visible     = True
        txtNewPassword.Visible     = True
        lblConfirmPassword.Visible = True
        txtConfirmPassword.Visible = True
        chkShowNewPassword.Visible = True
        btnReset.Visible           = True
        txtNewPassword.Focus()
    End Sub

    ' Checks the selected question matches the stored one AND the answer is correct.
    ' Same error message either way — prevents probing which part was wrong.
    Private Function IsSecurityAnswerCorrect() As Boolean
        If cboSecQuestion.SelectedIndex = -1 Then
            ShowStatus("Please select your security question.")
            Return False
        End If

        Dim answer = txtAnswer.Text.Trim()
        If answer = "" Then
            ShowStatus("Please enter your security answer.")
            Return False
        End If

        Try
            Dim selectedQuestion = cboSecQuestion.SelectedItem.ToString()
            Dim storedQuestion   = UserRepository.GetSecurityQuestion(_verifiedUsername)
            Dim questionMatch    = (selectedQuestion = storedQuestion)
            Dim answerMatch      = UserRepository.VerifySecurityAnswer(_verifiedUsername, answer)

            If Not questionMatch OrElse Not answerMatch Then
                ShowStatus("Incorrect security question or answer. Please try again.")
                ActivityLogger.Log(_verifiedUsername, Constants.LogFailed,
                                   "Failed password reset — wrong security question or answer.")
                Return False
            End If

            Return True

        Catch ex As Exception
            ShowStatus("Database error: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub chkShowNewPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowNewPassword.CheckedChanged
        txtNewPassword.UseSystemPasswordChar     = Not chkShowNewPassword.Checked
        txtConfirmPassword.UseSystemPasswordChar = Not chkShowNewPassword.Checked
    End Sub

    ' ── Reset password ────────────────────────────────────────────────────────

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        HideStatus()

        Dim newPassword = txtNewPassword.Text
        Dim confirmPw    = txtConfirmPassword.Text

        If newPassword = "" Then
            ShowStatus("New password cannot be empty.")
            Exit Sub
        End If

        If newPassword <> confirmPw Then
            ShowStatus("Passwords do not match. Please try again.")
            Exit Sub
        End If

        ' Re-verify in case the question/answer selection changed after the initial check
        If Not IsSecurityAnswerCorrect() Then Exit Sub

        Try
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
        chkShowNewPassword.Visible = False
        chkShowNewPassword.Checked = False
        btnReset.Visible           = False
        lblSecQuestion.Visible     = False
        cboSecQuestion.Visible     = False
        lblAnswer.Visible          = False
        pnlAnswerRow.Visible       = False
        _verifiedUsername          = ""
    End Sub

End Class
