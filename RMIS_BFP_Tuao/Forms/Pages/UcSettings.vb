Public Class UcSettings
    Inherits UserControl

    Private ReadOnly SecurityQuestions As String() = {
        "What is your mother's maiden name?",
        "What was the name of your first pet?",
        "What is the name of the city where you were born?",
        "What was the name of your elementary school?",
        "What is your favorite childhood nickname?"
    }

    Private Sub UcSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtUsername.Text    = SessionManager.Username
            txtStationName.Text = SettingsRepository.GetValue("StationName", "BFP Tuao Fire Station")
            txtStationAddr.Text = SettingsRepository.GetValue("StationAddress", "Tuao, Cagayan")

            cboSecQuestion.Items.AddRange(SecurityQuestions)
            Dim currentQuestion = UserRepository.GetSecurityQuestion(SessionManager.Username)
            If currentQuestion <> "" Then
                cboSecQuestion.SelectedItem = currentQuestion
            Else
                cboSecQuestion.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to load settings: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSaveAccount_Click(sender As Object, e As EventArgs) Handles btnSaveAccount.Click
        Dim newUsername = txtUsername.Text.Trim()
        If newUsername = "" Then
            MessageBox.Show("Username cannot be empty.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim newPassword = txtPassword.Text
        Dim confirmPw   = txtConfirmPw.Text

        If newPassword <> "" AndAlso newPassword <> confirmPw Then
            MessageBox.Show("Passwords do not match. Please try again.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim oldUsername = SessionManager.Username

            If newPassword <> "" Then
                Dim hash = PasswordHelper.HashPassword(newPassword)
                UserRepository.UpdatePassword(oldUsername, hash)
            End If

            If newUsername <> oldUsername Then
                UserRepository.UpdateUsername(oldUsername, newUsername)
                SessionManager.Username = newUsername

                Dim main = TryCast(Me.ParentForm, MainForm)
                If main IsNot Nothing Then
                    main.lblTopUser.Text = "[ " & newUsername & " ]"
                End If
            End If

            txtPassword.Clear()
            txtConfirmPw.Clear()

            ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess,
                               "Account settings updated.")
            MessageBox.Show("Account settings saved successfully.", "Settings",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Failed to save account settings: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSaveSystem_Click(sender As Object, e As EventArgs) Handles btnSaveSystem.Click
        If txtStationName.Text.Trim() = "" Then
            MessageBox.Show("Station name cannot be empty.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            SettingsRepository.SetValue("StationName",    txtStationName.Text.Trim())
            SettingsRepository.SetValue("StationAddress", txtStationAddr.Text.Trim())

            ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess,
                               "System settings updated.")
            MessageBox.Show("System information saved successfully.", "Settings",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Failed to save system settings: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSaveSecQuestion_Click(sender As Object, e As EventArgs) Handles btnSaveSecQuestion.Click
        If cboSecQuestion.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a security question.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtSecAnswer.Text.Trim() = "" Then
            MessageBox.Show("Please enter an answer for your security question.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim question   = cboSecQuestion.SelectedItem.ToString()
            Dim answerHash = PasswordHelper.HashPassword(txtSecAnswer.Text.Trim().ToLower())
            UserRepository.UpdateSecurityQuestion(SessionManager.Username, question, answerHash)

            txtSecAnswer.Clear()
            ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess, "Security question updated.")
            MessageBox.Show("Security question saved successfully.", "Settings",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Failed to save security question: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
