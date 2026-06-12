Public Class UcSettings
    Inherits UserControl

    Private Sub UcSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtUsername.Text   = SessionManager.Username
            txtStationName.Text = SettingsRepository.GetValue("StationName", "BFP Tuao Fire Station")
            txtStationAddr.Text = SettingsRepository.GetValue("StationAddress", "Tuao, Cagayan")
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

End Class
