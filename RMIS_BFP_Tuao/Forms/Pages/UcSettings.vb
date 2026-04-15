Public Class UcSettings
    Inherits UserControl

    ' Prototype credentials (would come from a DB in production)
    Private _currentUsername As String = "admin"
    Private _currentPassword As String = "admin123"

    Private Sub UcSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = _currentUsername
    End Sub

    Private Sub btnSaveAccount_Click(sender As Object, e As EventArgs) Handles btnSaveAccount.Click
        If txtUsername.Text.Trim() = "" Then
            MessageBox.Show("Username cannot be empty.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtPassword.Text <> "" Then
            If txtPassword.Text <> txtConfirmPw.Text Then
                MessageBox.Show("Passwords do not match. Please try again.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            _currentPassword = txtPassword.Text
        End If
        _currentUsername = txtUsername.Text.Trim()
        txtPassword.Clear()
        txtConfirmPw.Clear()
        MessageBox.Show("Account settings saved successfully.", "Settings",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSaveSystem_Click(sender As Object, e As EventArgs) Handles btnSaveSystem.Click
        If txtStationName.Text.Trim() = "" Then
            MessageBox.Show("Station name cannot be empty.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        MessageBox.Show("System information saved successfully.", "Settings",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
