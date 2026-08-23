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
            txtUsername.Text    = SessionManager.Username
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
        Catch ex As Exception
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

End Class
