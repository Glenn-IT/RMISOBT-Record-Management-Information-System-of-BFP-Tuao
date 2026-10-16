Public Class UcSettings
    Inherits UserControl

    Private _selectedBannerPath As String = ""

    Private ReadOnly SecurityQuestions As String() = {
        "What is your mother's maiden name?",
        "What was the name of your first pet?",
        "What is the name of the city where you were born?",
        "What was the name of your elementary school?",
        "What is your favorite childhood nickname?"
    }

    Private Sub UcSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadAccountSection()
            txtStationName.Text = SettingsRepository.GetValue("StationName", "BFP Tuao Fire Station")
            txtStationAddr.Text = SettingsRepository.GetValue("StationAddress", "Tuao, Cagayan")

            cboSecQuestion.Items.Clear()
            cboSecQuestion.Items.AddRange(SecurityQuestions)

            Dim currentQuestion = UserRepository.GetSecurityQuestion(SessionManager.Username)
            If currentQuestion <> "" Then
                cboSecQuestion.SelectedItem = currentQuestion
                lblVerifyQuestionText.Text  = currentQuestion

                ' Require security verification before showing settings
                pnlVerification.Visible    = True
                pnlSettingsContent.Visible = False
                btnLockSettings.Visible    = False
                txtVerifyAnswer.Clear()
                lblVerifyStatus.Visible    = False
                txtVerifyAnswer.Focus()
            Else
                ' No question set yet: directly unlock settings so user can set one up
                cboSecQuestion.SelectedIndex = 0
                lblVerifyQuestionText.Text   = "No security question set yet."
                pnlVerification.Visible      = False
                pnlSettingsContent.Visible   = True
                btnLockSettings.Visible      = False
            End If

            LoadBannerPreview()
            btnManageUsers.Visible = SessionManager.IsSuperAdmin()
        Catch ex As Exception
            If ManualScreenshotGenerator.IsCapturingManual Then Return
            MessageBox.Show("Failed to load settings: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ── Security Question Verification ──────────────────────────────────────

    Private Sub btnVerifySecurity_Click(sender As Object, e As EventArgs) Handles btnVerifySecurity.Click
        Dim answer = txtVerifyAnswer.Text.Trim()
        If answer = "" Then
            lblVerifyStatus.Text    = "Please enter your security answer."
            lblVerifyStatus.Visible = True
            txtVerifyAnswer.Focus()
            Exit Sub
        End If

        Try
            Dim isCorrect = UserRepository.VerifySecurityAnswer(SessionManager.Username, answer)
            If Not isCorrect Then
                lblVerifyStatus.Text    = "Incorrect security answer. Please try again."
                lblVerifyStatus.Visible = True
                ActivityLogger.Log(SessionManager.Username, Constants.LogFailed,
                                   "Failed security question verification in Settings.")
                txtVerifyAnswer.SelectAll()
                txtVerifyAnswer.Focus()
                Exit Sub
            End If

            ' Verification passed — unlock settings
            lblVerifyStatus.Visible    = False
            txtVerifyAnswer.Clear()
            pnlVerification.Visible    = False
            pnlSettingsContent.Visible = True
            btnLockSettings.Visible    = True

            ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess,
                               "Security question verified. Settings unlocked.")
        Catch ex As Exception
            lblVerifyStatus.Text    = "Database error: " & ex.Message
            lblVerifyStatus.Visible = True
        End Try
    End Sub

    Private Sub txtVerifyAnswer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVerifyAnswer.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnVerifySecurity_Click(btnVerifySecurity, EventArgs.Empty)
        End If
    End Sub

    Private Sub chkShowVerifyAnswer_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowVerifyAnswer.CheckedChanged
        txtVerifyAnswer.PasswordChar = If(chkShowVerifyAnswer.Checked, ChrW(0), "*"c)
    End Sub

    Private Sub btnLockSettings_Click(sender As Object, e As EventArgs) Handles btnLockSettings.Click
        Dim currentQuestion = UserRepository.GetSecurityQuestion(SessionManager.Username)
        If currentQuestion <> "" Then
            lblVerifyQuestionText.Text = currentQuestion
            pnlSettingsContent.Visible = False
            pnlVerification.Visible    = True
            btnLockSettings.Visible    = False
            txtVerifyAnswer.Clear()
            lblVerifyStatus.Visible    = False
            txtVerifyAnswer.Focus()
        End If
    End Sub

    ' ── Banner Image Management ─────────────────────────────────────────────

    Private Sub LoadBannerPreview()
        picBanner.Image?.Dispose()
        picBanner.Image = BannerHelper.GetCurrentBanner()
    End Sub

    Private Sub btnBrowseBanner_Click(sender As Object, e As EventArgs) Handles btnBrowseBanner.Click
        Using dlg As New OpenFileDialog()
            dlg.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp"
            If dlg.ShowDialog() = DialogResult.OK Then
                _selectedBannerPath = dlg.FileName
                picBanner.Image?.Dispose()
                picBanner.Image = BannerHelper.LoadImage(_selectedBannerPath)
            End If
        End Using
    End Sub

    Private Sub btnSaveBanner_Click(sender As Object, e As EventArgs) Handles btnSaveBanner.Click
        If _selectedBannerPath = "" Then
            MessageBox.Show("Please browse for an image first.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            BannerHelper.SaveBanner(_selectedBannerPath)
            _selectedBannerPath = ""
            LoadBannerPreview()

            Dim main = TryCast(Me.ParentForm, MainForm)
            If main IsNot Nothing Then main.RefreshBanner()

            ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess,
                               "Banner image updated.")
            MessageBox.Show("Banner image saved successfully.", "Settings",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Failed to save banner image: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ── Account Settings ────────────────────────────────────────────────────

    Private Sub LoadAccountSection()
        cboRole.Items.Clear()
        For Each r In Constants.Roles
            cboRole.Items.Add(r)
        Next

        If Not SessionManager.IsSuperAdmin() Then
            lblTargetUser.Visible = False
            cboTargetUser.Visible = False
            lblRole.Visible = False
            cboRole.Visible = False
            btnManageUsers.Visible = False
            txtUsername.Text = SessionManager.Username
            txtUsername.Enabled = True
            lblPassword.Text = "New Password (leave blank to keep current)"
            btnSaveAccount.Text = "Save Account"
            Return
        End If

        lblTargetUser.Visible = True
        cboTargetUser.Visible = True
        lblRole.Visible = True
        cboRole.Visible = True
        btnManageUsers.Visible = True

        ' Populate user accounts
        cboTargetUser.Items.Clear()
        Dim dt = UserRepository.GetAllUsers()
        For Each row As DataRow In dt.Rows
            Dim uName = row("Username").ToString()
            Dim uRole = row("UserType").ToString()
            cboTargetUser.Items.Add($"{uName} ({uRole})")
        Next
        cboTargetUser.Items.Add("+ Add New User Account...")

        ' Select current user if in list
        Dim targetIdx = -1
        For i As Integer = 0 To cboTargetUser.Items.Count - 2
            If cboTargetUser.Items(i).ToString().StartsWith(SessionManager.Username & " (", StringComparison.OrdinalIgnoreCase) Then
                targetIdx = i
                Exit For
            End If
        Next
        If targetIdx >= 0 Then
            cboTargetUser.SelectedIndex = targetIdx
        ElseIf cboTargetUser.Items.Count > 0 Then
            cboTargetUser.SelectedIndex = 0
        End If
    End Sub

    Private Sub cboTargetUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTargetUser.SelectedIndexChanged
        If cboTargetUser.SelectedItem Is Nothing Then Exit Sub
        Dim itemText = cboTargetUser.SelectedItem.ToString()

        If itemText = "+ Add New User Account..." Then
            txtUsername.Clear()
            txtUsername.Focus()
            cboRole.SelectedIndex = If(cboRole.Items.Count > 1, 1, 0) ' Default to Sub Admin
            txtPassword.Clear()
            txtConfirmPw.Clear()
            lblPassword.Text = "Password:"
            btnSaveAccount.Text = "+ Add User"
        Else
            ' Parse "username (role)"
            Dim openParen = itemText.LastIndexOf("("c)
            Dim closeParen = itemText.LastIndexOf(")"c)
            If openParen > 0 AndAlso closeParen > openParen Then
                Dim uName = itemText.Substring(0, openParen).Trim()
                Dim uRole = itemText.Substring(openParen + 1, closeParen - openParen - 1).Trim()
                If String.Equals(uRole, "Admin", StringComparison.OrdinalIgnoreCase) Then
                    uRole = Constants.UserTypeSuperAdmin
                End If

                txtUsername.Text = uName
                cboRole.SelectedItem = uRole
                txtPassword.Clear()
                txtConfirmPw.Clear()
                lblPassword.Text = "New Password (leave blank to keep current)"
                btnSaveAccount.Text = "Save / Update Account"
            End If
        End If
    End Sub

    Private Sub btnSaveAccount_Click(sender As Object, e As EventArgs) Handles btnSaveAccount.Click
        Dim newUsername = txtUsername.Text.Trim()
        If newUsername = "" Then
            MessageBox.Show("Username cannot be empty.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Exit Sub
        End If

        Dim newPassword = txtPassword.Text
        Dim confirmPw   = txtConfirmPw.Text

        If SessionManager.IsSuperAdmin() AndAlso cboTargetUser.Visible Then
            Dim selectedItem = cboTargetUser.SelectedItem?.ToString()
            Dim selectedRole = cboRole.SelectedItem?.ToString()

            If String.IsNullOrWhiteSpace(selectedRole) Then
                MessageBox.Show("Please select a role.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cboRole.Focus()
                Exit Sub
            End If

            If selectedItem = "+ Add New User Account..." Then
                ' ── Add New User ─────────────────────────────────────────────
                If String.IsNullOrEmpty(newPassword) Then
                    MessageBox.Show("Please enter a password for the new user.", "Validation",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPassword.Focus()
                    Exit Sub
                End If

                If newPassword.Length < 4 Then
                    MessageBox.Show("Password must be at least 4 characters long.", "Validation",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPassword.Focus()
                    Exit Sub
                End If

                If newPassword <> confirmPw Then
                    MessageBox.Show("Passwords do not match. Please try again.", "Validation",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtConfirmPw.Focus()
                    Exit Sub
                End If

                Try
                    If UserRepository.Exists(newUsername) Then
                        MessageBox.Show($"The username '{newUsername}' already exists. Please choose a different username.",
                                        "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtUsername.SelectAll()
                        txtUsername.Focus()
                        Exit Sub
                    End If

                    Dim hash = PasswordHelper.HashPassword(newPassword)
                    UserRepository.Insert(newUsername, hash, selectedRole)
                    ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess,
                                       $"Created new {selectedRole} account: {newUsername}")

                    MessageBox.Show($"User account '{newUsername}' ({selectedRole}) created successfully!",
                                    "User Created", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    LoadAccountSection()

                Catch ex As Exception
                    MessageBox.Show("Failed to create user account: " & ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                ' ── Update Existing User Credentials ─────────────────────────
                Dim openParen = selectedItem.LastIndexOf("("c)
                Dim targetOriginalUsername = If(openParen > 0, selectedItem.Substring(0, openParen).Trim(), selectedItem)

                If Not String.Equals(newUsername, targetOriginalUsername, StringComparison.OrdinalIgnoreCase) Then
                    If UserRepository.Exists(newUsername) Then
                        MessageBox.Show($"The username '{newUsername}' is already taken. Please choose another.",
                                        "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtUsername.SelectAll()
                        txtUsername.Focus()
                        Exit Sub
                    End If
                End If

                Dim newHash = ""
                If Not String.IsNullOrEmpty(newPassword) Then
                    If newPassword.Length < 4 Then
                        MessageBox.Show("Password must be at least 4 characters long.", "Validation",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtPassword.Focus()
                        Exit Sub
                    End If

                    If newPassword <> confirmPw Then
                        MessageBox.Show("Passwords do not match. Please try again.", "Validation",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtConfirmPw.Focus()
                        Exit Sub
                    End If

                    newHash = PasswordHelper.HashPassword(newPassword)
                End If

                Try
                    UserRepository.UpdateUser(targetOriginalUsername, newUsername, selectedRole, newHash)

                    If String.Equals(targetOriginalUsername, SessionManager.Username, StringComparison.OrdinalIgnoreCase) Then
                        SessionManager.Username = newUsername
                        SessionManager.UserType = selectedRole
                        Dim main = TryCast(Me.ParentForm, MainForm)
                        If main IsNot Nothing Then
                            main.lblTopUser.Text = $"[ {newUsername} ({selectedRole}) ]"
                        End If
                    End If

                    txtPassword.Clear()
                    txtConfirmPw.Clear()

                    ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess,
                                       $"Updated credentials for user '{targetOriginalUsername}' (New Name: '{newUsername}', Role: {selectedRole}).")

                    MessageBox.Show($"Credentials for user '{newUsername}' updated successfully.", "Settings",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)

                    LoadAccountSection()

                Catch ex As Exception
                    MessageBox.Show("Failed to update user account: " & ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            ' Standard user updating own account
            If newPassword <> "" AndAlso newPassword <> confirmPw Then
                MessageBox.Show("Passwords do not match. Please try again.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Try
                Dim oldUsername = SessionManager.Username

                If newPassword <> "" Then
                    If newPassword.Length < 4 Then
                        MessageBox.Show("Password must be at least 4 characters long.", "Validation",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    Dim hash = PasswordHelper.HashPassword(newPassword)
                    UserRepository.UpdatePassword(oldUsername, hash)
                End If

                If newUsername <> oldUsername Then
                    If UserRepository.Exists(newUsername) Then
                        MessageBox.Show($"The username '{newUsername}' already exists.", "Validation",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    UserRepository.UpdateUsername(oldUsername, newUsername)
                    SessionManager.Username = newUsername

                    Dim main = TryCast(Me.ParentForm, MainForm)
                    If main IsNot Nothing Then
                        main.lblTopUser.Text = $"[ {newUsername} ({SessionManager.UserType}) ]"
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
        End If
    End Sub

    ' ── Security Question Management ─────────────────────────────────────────

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

            lblVerifyQuestionText.Text = question
            txtSecAnswer.Clear()
            ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess,
                               "Security question updated.")
            MessageBox.Show("Security question saved successfully. This will be used for password recovery and settings verification.",
                            "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Failed to save security question: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ── System Information ──────────────────────────────────────────────────

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

    Private Sub btnManageSignatories_Click(sender As Object, e As EventArgs) Handles btnManageSignatories.Click
        Using dlg As New SignatoriesForm()
            dlg.ShowDialog(Me)
        End Using
    End Sub

    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        Using dlg As New UserManagementForm()
            dlg.ShowDialog(Me)
        End Using
        LoadAccountSection()
    End Sub

End Class
