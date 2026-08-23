<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcSettings
    Inherits System.Windows.Forms.UserControl

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        lblPageTitle = New Label()
        lblPageSub = New Label()
        pnlDivider = New Panel()
        btnLockSettings = New Button()
        pnlVerification = New Panel()
        lblVerifyTitle = New Label()
        lblVerifySub = New Label()
        pnlVerifyDivider = New Panel()
        lblVerifyQuestionHeader = New Label()
        lblVerifyQuestionText = New Label()
        lblVerifyAnswerPrompt = New Label()
        txtVerifyAnswer = New TextBox()
        chkShowVerifyAnswer = New CheckBox()
        lblVerifyStatus = New Label()
        btnVerifySecurity = New Button()
        pnlSettingsContent = New Panel()
        pnlAccount = New Panel()
        lblAccTitle = New Label()
        lblAccDivider = New Panel()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        lblConfirmPw = New Label()
        txtConfirmPw = New TextBox()
        btnSaveAccount = New Button()
        pnlSecQuestion = New Panel()
        lblSecTitle = New Label()
        lblSecDivider = New Panel()
        lblSecQuestion = New Label()
        cboSecQuestion = New ComboBox()
        lblSecAnswer = New Label()
        txtSecAnswer = New TextBox()
        btnSaveSecQuestion = New Button()
        pnlBanner = New Panel()
        lblBannerTitle = New Label()
        lblBannerDivider = New Panel()
        picBanner = New PictureBox()
        btnBrowseBanner = New Button()
        btnSaveBanner = New Button()
        lblBannerHint = New Label()
        pnlSystem = New Panel()
        lblSysTitle = New Label()
        lblSysDivider = New Panel()
        lblStationName = New Label()
        txtStationName = New TextBox()
        lblStationAddr = New Label()
        txtStationAddr = New TextBox()
        btnSaveSystem = New Button()
        pnlHeader.SuspendLayout()
        pnlVerification.SuspendLayout()
        pnlSettingsContent.SuspendLayout()
        pnlAccount.SuspendLayout()
        pnlSecQuestion.SuspendLayout()
        pnlBanner.SuspendLayout()
        CType(picBanner, ComponentModel.ISupportInitialize).BeginInit()
        pnlSystem.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Controls.Add(lblPageSub)
        pnlHeader.Controls.Add(pnlDivider)
        pnlHeader.Controls.Add(btnLockSettings)
        pnlHeader.Location = New Point(26, 20)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1214, 97)
        pnlHeader.TabIndex = 0
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblPageTitle.Location = New Point(22, 13)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(662, 38)
        lblPageTitle.TabIndex = 0
        lblPageTitle.Text = "Settings"
        ' 
        ' lblPageSub
        ' 
        lblPageSub.Font = New Font("Segoe UI", 9F)
        lblPageSub.ForeColor = Color.Gray
        lblPageSub.Location = New Point(22, 51)
        lblPageSub.Name = "lblPageSub"
        lblPageSub.Size = New Size(662, 24)
        lblPageSub.TabIndex = 1
        lblPageSub.Text = "Manage account credentials, banner, and system settings."
        ' 
        ' pnlDivider
        ' 
        pnlDivider.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDivider.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        pnlDivider.Location = New Point(22, 86)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(1170, 3)
        pnlDivider.TabIndex = 2
        ' 
        ' btnLockSettings
        ' 
        btnLockSettings.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLockSettings.BackColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        btnLockSettings.Cursor = Cursors.Hand
        btnLockSettings.FlatAppearance.BorderSize = 0
        btnLockSettings.FlatStyle = FlatStyle.Flat
        btnLockSettings.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnLockSettings.ForeColor = Color.White
        btnLockSettings.Location = New Point(1052, 25)
        btnLockSettings.Name = "btnLockSettings"
        btnLockSettings.Size = New Size(140, 36)
        btnLockSettings.TabIndex = 3
        btnLockSettings.Text = "Lock Settings"
        btnLockSettings.UseVisualStyleBackColor = False
        btnLockSettings.Visible = False
        ' 
        ' pnlVerification
        ' 
        pnlVerification.BackColor = Color.White
        pnlVerification.Controls.Add(lblVerifyTitle)
        pnlVerification.Controls.Add(lblVerifySub)
        pnlVerification.Controls.Add(pnlVerifyDivider)
        pnlVerification.Controls.Add(lblVerifyQuestionHeader)
        pnlVerification.Controls.Add(lblVerifyQuestionText)
        pnlVerification.Controls.Add(lblVerifyAnswerPrompt)
        pnlVerification.Controls.Add(txtVerifyAnswer)
        pnlVerification.Controls.Add(chkShowVerifyAnswer)
        pnlVerification.Controls.Add(lblVerifyStatus)
        pnlVerification.Controls.Add(btnVerifySecurity)
        pnlVerification.Location = New Point(26, 132)
        pnlVerification.Name = "pnlVerification"
        pnlVerification.Size = New Size(620, 380)
        pnlVerification.TabIndex = 1
        ' 
        ' lblVerifyTitle
        ' 
        lblVerifyTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblVerifyTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblVerifyTitle.Location = New Point(24, 18)
        lblVerifyTitle.Name = "lblVerifyTitle"
        lblVerifyTitle.Size = New Size(570, 30)
        lblVerifyTitle.TabIndex = 0
        lblVerifyTitle.Text = "Security Verification Required"
        ' 
        ' lblVerifySub
        ' 
        lblVerifySub.Font = New Font("Segoe UI", 9F)
        lblVerifySub.ForeColor = Color.Gray
        lblVerifySub.Location = New Point(24, 50)
        lblVerifySub.Name = "lblVerifySub"
        lblVerifySub.Size = New Size(570, 38)
        lblVerifySub.TabIndex = 1
        lblVerifySub.Text = "Please answer your registered security question to access Account Settings, Banner Image, and Security configuration."
        ' 
        ' pnlVerifyDivider
        ' 
        pnlVerifyDivider.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        pnlVerifyDivider.Location = New Point(24, 95)
        pnlVerifyDivider.Name = "pnlVerifyDivider"
        pnlVerifyDivider.Size = New Size(570, 1)
        pnlVerifyDivider.TabIndex = 2
        ' 
        ' lblVerifyQuestionHeader
        ' 
        lblVerifyQuestionHeader.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblVerifyQuestionHeader.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblVerifyQuestionHeader.Location = New Point(24, 110)
        lblVerifyQuestionHeader.Name = "lblVerifyQuestionHeader"
        lblVerifyQuestionHeader.Size = New Size(570, 22)
        lblVerifyQuestionHeader.TabIndex = 3
        lblVerifyQuestionHeader.Text = "Security Question:"
        ' 
        ' lblVerifyQuestionText
        ' 
        lblVerifyQuestionText.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblVerifyQuestionText.ForeColor = Color.FromArgb(CByte(30), CByte(100), CByte(180))
        lblVerifyQuestionText.Location = New Point(24, 134)
        lblVerifyQuestionText.Name = "lblVerifyQuestionText"
        lblVerifyQuestionText.Size = New Size(570, 26)
        lblVerifyQuestionText.TabIndex = 4
        lblVerifyQuestionText.Text = "Loading security question..."
        ' 
        ' lblVerifyAnswerPrompt
        ' 
        lblVerifyAnswerPrompt.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblVerifyAnswerPrompt.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblVerifyAnswerPrompt.Location = New Point(24, 172)
        lblVerifyAnswerPrompt.Name = "lblVerifyAnswerPrompt"
        lblVerifyAnswerPrompt.Size = New Size(570, 22)
        lblVerifyAnswerPrompt.TabIndex = 5
        lblVerifyAnswerPrompt.Text = "Your Security Answer:"
        ' 
        ' txtVerifyAnswer
        ' 
        txtVerifyAnswer.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtVerifyAnswer.BorderStyle = BorderStyle.FixedSingle
        txtVerifyAnswer.Font = New Font("Segoe UI", 10F)
        txtVerifyAnswer.Location = New Point(24, 196)
        txtVerifyAnswer.Name = "txtVerifyAnswer"
        txtVerifyAnswer.PasswordChar = "*"c
        txtVerifyAnswer.Size = New Size(570, 27)
        txtVerifyAnswer.TabIndex = 6
        ' 
        ' chkShowVerifyAnswer
        ' 
        chkShowVerifyAnswer.AutoSize = True
        chkShowVerifyAnswer.Font = New Font("Segoe UI", 8.5F)
        chkShowVerifyAnswer.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        chkShowVerifyAnswer.Location = New Point(24, 230)
        chkShowVerifyAnswer.Name = "chkShowVerifyAnswer"
        chkShowVerifyAnswer.Size = New Size(106, 21)
        chkShowVerifyAnswer.TabIndex = 7
        chkShowVerifyAnswer.Text = "Show Answer"
        chkShowVerifyAnswer.UseVisualStyleBackColor = True
        ' 
        ' lblVerifyStatus
        ' 
        lblVerifyStatus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblVerifyStatus.ForeColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        lblVerifyStatus.Location = New Point(24, 258)
        lblVerifyStatus.Name = "lblVerifyStatus"
        lblVerifyStatus.Size = New Size(570, 22)
        lblVerifyStatus.TabIndex = 8
        lblVerifyStatus.Text = "Incorrect security answer. Please try again."
        lblVerifyStatus.Visible = False
        ' 
        ' btnVerifySecurity
        ' 
        btnVerifySecurity.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        btnVerifySecurity.Cursor = Cursors.Hand
        btnVerifySecurity.FlatAppearance.BorderSize = 0
        btnVerifySecurity.FlatStyle = FlatStyle.Flat
        btnVerifySecurity.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnVerifySecurity.ForeColor = Color.White
        btnVerifySecurity.Location = New Point(24, 290)
        btnVerifySecurity.Name = "btnVerifySecurity"
        btnVerifySecurity.Size = New Size(190, 42)
        btnVerifySecurity.TabIndex = 9
        btnVerifySecurity.Text = "Verify && Unlock"
        btnVerifySecurity.UseVisualStyleBackColor = False
        ' 
        ' pnlSettingsContent
        ' 
        pnlSettingsContent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSettingsContent.AutoScroll = True
        pnlSettingsContent.Controls.Add(pnlAccount)
        pnlSettingsContent.Controls.Add(pnlSecQuestion)
        pnlSettingsContent.Controls.Add(pnlBanner)
        pnlSettingsContent.Controls.Add(pnlSystem)
        pnlSettingsContent.Location = New Point(26, 132)
        pnlSettingsContent.Name = "pnlSettingsContent"
        pnlSettingsContent.Size = New Size(1214, 622)
        pnlSettingsContent.TabIndex = 2
        pnlSettingsContent.Visible = False
        ' 
        ' pnlAccount
        ' 
        pnlAccount.BackColor = Color.White
        pnlAccount.Controls.Add(lblAccTitle)
        pnlAccount.Controls.Add(lblAccDivider)
        pnlAccount.Controls.Add(lblUsername)
        pnlAccount.Controls.Add(txtUsername)
        pnlAccount.Controls.Add(lblPassword)
        pnlAccount.Controls.Add(txtPassword)
        pnlAccount.Controls.Add(lblConfirmPw)
        pnlAccount.Controls.Add(txtConfirmPw)
        pnlAccount.Controls.Add(btnSaveAccount)
        pnlAccount.Location = New Point(0, 0)
        pnlAccount.Name = "pnlAccount"
        pnlAccount.Size = New Size(540, 310)
        pnlAccount.TabIndex = 0
        ' 
        ' lblAccTitle
        ' 
        lblAccTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblAccTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblAccTitle.Location = New Point(20, 15)
        lblAccTitle.Name = "lblAccTitle"
        lblAccTitle.Size = New Size(500, 26)
        lblAccTitle.TabIndex = 0
        lblAccTitle.Text = "Account Credentials"
        ' 
        ' lblAccDivider
        ' 
        lblAccDivider.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        lblAccDivider.Location = New Point(20, 45)
        lblAccDivider.Name = "lblAccDivider"
        lblAccDivider.Size = New Size(500, 1)
        lblAccDivider.TabIndex = 1
        ' 
        ' lblUsername
        ' 
        lblUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblUsername.Location = New Point(20, 58)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(500, 20)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10F)
        txtUsername.Location = New Point(20, 80)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(500, 27)
        txtUsername.TabIndex = 3
        ' 
        ' lblPassword
        ' 
        lblPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblPassword.Location = New Point(20, 115)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(500, 20)
        lblPassword.TabIndex = 4
        lblPassword.Text = "New Password (leave blank to keep current)"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10F)
        txtPassword.Location = New Point(20, 137)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "?"c
        txtPassword.Size = New Size(500, 27)
        txtPassword.TabIndex = 5
        ' 
        ' lblConfirmPw
        ' 
        lblConfirmPw.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblConfirmPw.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblConfirmPw.Location = New Point(20, 172)
        lblConfirmPw.Name = "lblConfirmPw"
        lblConfirmPw.Size = New Size(500, 20)
        lblConfirmPw.TabIndex = 6
        lblConfirmPw.Text = "Confirm Password"
        ' 
        ' txtConfirmPw
        ' 
        txtConfirmPw.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtConfirmPw.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPw.Font = New Font("Segoe UI", 10F)
        txtConfirmPw.Location = New Point(20, 194)
        txtConfirmPw.Name = "txtConfirmPw"
        txtConfirmPw.PasswordChar = "?"c
        txtConfirmPw.Size = New Size(500, 27)
        txtConfirmPw.TabIndex = 7
        ' 
        ' btnSaveAccount
        ' 
        btnSaveAccount.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        btnSaveAccount.Cursor = Cursors.Hand
        btnSaveAccount.FlatAppearance.BorderSize = 0
        btnSaveAccount.FlatStyle = FlatStyle.Flat
        btnSaveAccount.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSaveAccount.ForeColor = Color.White
        btnSaveAccount.Location = New Point(20, 240)
        btnSaveAccount.Name = "btnSaveAccount"
        btnSaveAccount.Size = New Size(180, 40)
        btnSaveAccount.TabIndex = 8
        btnSaveAccount.Text = "Save Account"
        btnSaveAccount.UseVisualStyleBackColor = False
        ' 
        ' pnlSecQuestion
        ' 
        pnlSecQuestion.BackColor = Color.White
        pnlSecQuestion.Controls.Add(lblSecTitle)
        pnlSecQuestion.Controls.Add(lblSecDivider)
        pnlSecQuestion.Controls.Add(lblSecQuestion)
        pnlSecQuestion.Controls.Add(cboSecQuestion)
        pnlSecQuestion.Controls.Add(lblSecAnswer)
        pnlSecQuestion.Controls.Add(txtSecAnswer)
        pnlSecQuestion.Controls.Add(btnSaveSecQuestion)
        pnlSecQuestion.Location = New Point(0, 325)
        pnlSecQuestion.Name = "pnlSecQuestion"
        pnlSecQuestion.Size = New Size(540, 260)
        pnlSecQuestion.TabIndex = 1
        ' 
        ' lblSecTitle
        ' 
        lblSecTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblSecTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblSecTitle.Location = New Point(20, 15)
        lblSecTitle.Name = "lblSecTitle"
        lblSecTitle.Size = New Size(500, 26)
        lblSecTitle.TabIndex = 0
        lblSecTitle.Text = "Security Question (Password Recovery)"
        ' 
        ' lblSecDivider
        ' 
        lblSecDivider.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        lblSecDivider.Location = New Point(20, 45)
        lblSecDivider.Name = "lblSecDivider"
        lblSecDivider.Size = New Size(500, 1)
        lblSecDivider.TabIndex = 1
        ' 
        ' lblSecQuestion
        ' 
        lblSecQuestion.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblSecQuestion.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblSecQuestion.Location = New Point(20, 58)
        lblSecQuestion.Name = "lblSecQuestion"
        lblSecQuestion.Size = New Size(500, 20)
        lblSecQuestion.TabIndex = 2
        lblSecQuestion.Text = "Select Security Question"
        ' 
        ' cboSecQuestion
        ' 
        cboSecQuestion.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        cboSecQuestion.DropDownStyle = ComboBoxStyle.DropDownList
        cboSecQuestion.FlatStyle = FlatStyle.Flat
        cboSecQuestion.Font = New Font("Segoe UI", 10F)
        cboSecQuestion.Location = New Point(20, 80)
        cboSecQuestion.Name = "cboSecQuestion"
        cboSecQuestion.Size = New Size(500, 28)
        cboSecQuestion.TabIndex = 3
        ' 
        ' lblSecAnswer
        ' 
        lblSecAnswer.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblSecAnswer.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblSecAnswer.Location = New Point(20, 118)
        lblSecAnswer.Name = "lblSecAnswer"
        lblSecAnswer.Size = New Size(500, 20)
        lblSecAnswer.TabIndex = 4
        lblSecAnswer.Text = "New Security Answer"
        ' 
        ' txtSecAnswer
        ' 
        txtSecAnswer.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtSecAnswer.BorderStyle = BorderStyle.FixedSingle
        txtSecAnswer.Font = New Font("Segoe UI", 10F)
        txtSecAnswer.Location = New Point(20, 140)
        txtSecAnswer.Name = "txtSecAnswer"
        txtSecAnswer.Size = New Size(500, 27)
        txtSecAnswer.TabIndex = 5
        ' 
        ' btnSaveSecQuestion
        ' 
        btnSaveSecQuestion.BackColor = Color.FromArgb(CByte(30), CByte(100), CByte(180))
        btnSaveSecQuestion.Cursor = Cursors.Hand
        btnSaveSecQuestion.FlatAppearance.BorderSize = 0
        btnSaveSecQuestion.FlatStyle = FlatStyle.Flat
        btnSaveSecQuestion.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSaveSecQuestion.ForeColor = Color.White
        btnSaveSecQuestion.Location = New Point(20, 185)
        btnSaveSecQuestion.Name = "btnSaveSecQuestion"
        btnSaveSecQuestion.Size = New Size(210, 40)
        btnSaveSecQuestion.TabIndex = 6
        btnSaveSecQuestion.Text = "Save Security Question"
        btnSaveSecQuestion.UseVisualStyleBackColor = False
        ' 
        ' pnlBanner
        ' 
        pnlBanner.BackColor = Color.White
        pnlBanner.Controls.Add(lblBannerTitle)
        pnlBanner.Controls.Add(lblBannerDivider)
        pnlBanner.Controls.Add(picBanner)
        pnlBanner.Controls.Add(btnBrowseBanner)
        pnlBanner.Controls.Add(btnSaveBanner)
        pnlBanner.Controls.Add(lblBannerHint)
        pnlBanner.Location = New Point(560, 0)
        pnlBanner.Name = "pnlBanner"
        pnlBanner.Size = New Size(540, 250)
        pnlBanner.TabIndex = 2
        ' 
        ' lblBannerTitle
        ' 
        lblBannerTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblBannerTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblBannerTitle.Location = New Point(20, 15)
        lblBannerTitle.Name = "lblBannerTitle"
        lblBannerTitle.Size = New Size(500, 26)
        lblBannerTitle.TabIndex = 0
        lblBannerTitle.Text = "Banner Image"
        ' 
        ' lblBannerDivider
        ' 
        lblBannerDivider.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        lblBannerDivider.Location = New Point(20, 45)
        lblBannerDivider.Name = "lblBannerDivider"
        lblBannerDivider.Size = New Size(500, 1)
        lblBannerDivider.TabIndex = 1
        ' 
        ' picBanner
        ' 
        picBanner.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        picBanner.BorderStyle = BorderStyle.FixedSingle
        picBanner.Location = New Point(20, 58)
        picBanner.Name = "picBanner"
        picBanner.Size = New Size(150, 150)
        picBanner.SizeMode = PictureBoxSizeMode.Zoom
        picBanner.TabIndex = 2
        picBanner.TabStop = False
        ' 
        ' btnBrowseBanner
        ' 
        btnBrowseBanner.BackColor = Color.FromArgb(CByte(30), CByte(100), CByte(180))
        btnBrowseBanner.Cursor = Cursors.Hand
        btnBrowseBanner.FlatAppearance.BorderSize = 0
        btnBrowseBanner.FlatStyle = FlatStyle.Flat
        btnBrowseBanner.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnBrowseBanner.ForeColor = Color.White
        btnBrowseBanner.Location = New Point(185, 58)
        btnBrowseBanner.Name = "btnBrowseBanner"
        btnBrowseBanner.Size = New Size(160, 38)
        btnBrowseBanner.TabIndex = 3
        btnBrowseBanner.Text = "Browse..."
        btnBrowseBanner.UseVisualStyleBackColor = False
        ' 
        ' btnSaveBanner
        ' 
        btnSaveBanner.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        btnSaveBanner.Cursor = Cursors.Hand
        btnSaveBanner.FlatAppearance.BorderSize = 0
        btnSaveBanner.FlatStyle = FlatStyle.Flat
        btnSaveBanner.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSaveBanner.ForeColor = Color.White
        btnSaveBanner.Location = New Point(185, 106)
        btnSaveBanner.Name = "btnSaveBanner"
        btnSaveBanner.Size = New Size(160, 38)
        btnSaveBanner.TabIndex = 4
        btnSaveBanner.Text = "Save Banner"
        btnSaveBanner.UseVisualStyleBackColor = False
        ' 
        ' lblBannerHint
        ' 
        lblBannerHint.Font = New Font("Segoe UI", 8.5F)
        lblBannerHint.ForeColor = Color.Gray
        lblBannerHint.Location = New Point(185, 155)
        lblBannerHint.Name = "lblBannerHint"
        lblBannerHint.Size = New Size(335, 53)
        lblBannerHint.TabIndex = 5
        lblBannerHint.Text = "PNG or JPG recommended. Appears on the login screen and sidebar navigation."
        ' 
        ' pnlSystem
        ' 
        pnlSystem.BackColor = Color.White
        pnlSystem.Controls.Add(lblSysTitle)
        pnlSystem.Controls.Add(lblSysDivider)
        pnlSystem.Controls.Add(lblStationName)
        pnlSystem.Controls.Add(txtStationName)
        pnlSystem.Controls.Add(lblStationAddr)
        pnlSystem.Controls.Add(txtStationAddr)
        pnlSystem.Controls.Add(btnSaveSystem)
        pnlSystem.Location = New Point(560, 265)
        pnlSystem.Name = "pnlSystem"
        pnlSystem.Size = New Size(540, 320)
        pnlSystem.TabIndex = 3
        ' 
        ' lblSysTitle
        ' 
        lblSysTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblSysTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblSysTitle.Location = New Point(20, 15)
        lblSysTitle.Name = "lblSysTitle"
        lblSysTitle.Size = New Size(500, 26)
        lblSysTitle.TabIndex = 0
        lblSysTitle.Text = "System Information"
        ' 
        ' lblSysDivider
        ' 
        lblSysDivider.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        lblSysDivider.Location = New Point(20, 45)
        lblSysDivider.Name = "lblSysDivider"
        lblSysDivider.Size = New Size(500, 1)
        lblSysDivider.TabIndex = 1
        ' 
        ' lblStationName
        ' 
        lblStationName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblStationName.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblStationName.Location = New Point(20, 58)
        lblStationName.Name = "lblStationName"
        lblStationName.Size = New Size(500, 20)
        lblStationName.TabIndex = 2
        lblStationName.Text = "Station Name"
        ' 
        ' txtStationName
        ' 
        txtStationName.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtStationName.BorderStyle = BorderStyle.FixedSingle
        txtStationName.Font = New Font("Segoe UI", 10F)
        txtStationName.Location = New Point(20, 80)
        txtStationName.Name = "txtStationName"
        txtStationName.Size = New Size(500, 27)
        txtStationName.TabIndex = 3
        txtStationName.Text = "BFP Tuao Fire Station"
        ' 
        ' lblStationAddr
        ' 
        lblStationAddr.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblStationAddr.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblStationAddr.Location = New Point(20, 118)
        lblStationAddr.Name = "lblStationAddr"
        lblStationAddr.Size = New Size(500, 20)
        lblStationAddr.TabIndex = 4
        lblStationAddr.Text = "Station Address"
        ' 
        ' txtStationAddr
        ' 
        txtStationAddr.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtStationAddr.BorderStyle = BorderStyle.FixedSingle
        txtStationAddr.Font = New Font("Segoe UI", 10F)
        txtStationAddr.Location = New Point(20, 140)
        txtStationAddr.Multiline = True
        txtStationAddr.Name = "txtStationAddr"
        txtStationAddr.Size = New Size(500, 75)
        txtStationAddr.TabIndex = 5
        txtStationAddr.Text = "Tuao, Cagayan"
        ' 
        ' btnSaveSystem
        ' 
        btnSaveSystem.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        btnSaveSystem.Cursor = Cursors.Hand
        btnSaveSystem.FlatAppearance.BorderSize = 0
        btnSaveSystem.FlatStyle = FlatStyle.Flat
        btnSaveSystem.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSaveSystem.ForeColor = Color.White
        btnSaveSystem.Location = New Point(20, 235)
        btnSaveSystem.Name = "btnSaveSystem"
        btnSaveSystem.Size = New Size(180, 40)
        btnSaveSystem.TabIndex = 6
        btnSaveSystem.Text = "Save Changes"
        btnSaveSystem.UseVisualStyleBackColor = False
        ' 
        ' UcSettings
        ' 
        AutoScaleDimensions = New SizeF(106F, 106F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        Controls.Add(pnlHeader)
        Controls.Add(pnlVerification)
        Controls.Add(pnlSettingsContent)
        Font = New Font("Segoe UI", 9F)
        Name = "UcSettings"
        Size = New Size(1266, 774)
        pnlHeader.ResumeLayout(False)
        pnlVerification.ResumeLayout(False)
        pnlVerification.PerformLayout()
        pnlSettingsContent.ResumeLayout(False)
        pnlAccount.ResumeLayout(False)
        pnlAccount.PerformLayout()
        pnlSecQuestion.ResumeLayout(False)
        pnlSecQuestion.PerformLayout()
        pnlBanner.ResumeLayout(False)
        CType(picBanner, ComponentModel.ISupportInitialize).EndInit()
        pnlSystem.ResumeLayout(False)
        pnlSystem.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents lblPageSub As Label
    Friend WithEvents pnlDivider As Panel
    Friend WithEvents btnLockSettings As Button

    Friend WithEvents pnlVerification As Panel
    Friend WithEvents lblVerifyTitle As Label
    Friend WithEvents lblVerifySub As Label
    Friend WithEvents pnlVerifyDivider As Panel
    Friend WithEvents lblVerifyQuestionHeader As Label
    Friend WithEvents lblVerifyQuestionText As Label
    Friend WithEvents lblVerifyAnswerPrompt As Label
    Friend WithEvents txtVerifyAnswer As TextBox
    Friend WithEvents chkShowVerifyAnswer As CheckBox
    Friend WithEvents lblVerifyStatus As Label
    Friend WithEvents btnVerifySecurity As Button

    Friend WithEvents pnlSettingsContent As Panel
    Friend WithEvents pnlAccount As Panel
    Friend WithEvents lblAccTitle As Label
    Friend WithEvents lblAccDivider As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblConfirmPw As Label
    Friend WithEvents txtConfirmPw As TextBox
    Friend WithEvents btnSaveAccount As Button

    Friend WithEvents pnlSecQuestion As Panel
    Friend WithEvents lblSecTitle As Label
    Friend WithEvents lblSecDivider As Panel
    Friend WithEvents lblSecQuestion As Label
    Friend WithEvents cboSecQuestion As ComboBox
    Friend WithEvents lblSecAnswer As Label
    Friend WithEvents txtSecAnswer As TextBox
    Friend WithEvents btnSaveSecQuestion As Button

    Friend WithEvents pnlBanner As Panel
    Friend WithEvents lblBannerTitle As Label
    Friend WithEvents lblBannerDivider As Panel
    Friend WithEvents picBanner As PictureBox
    Friend WithEvents btnBrowseBanner As Button
    Friend WithEvents btnSaveBanner As Button
    Friend WithEvents lblBannerHint As Label

    Friend WithEvents pnlSystem As Panel
    Friend WithEvents lblSysTitle As Label
    Friend WithEvents lblSysDivider As Panel
    Friend WithEvents lblStationName As Label
    Friend WithEvents txtStationName As TextBox
    Friend WithEvents lblStationAddr As Label
    Friend WithEvents txtStationAddr As TextBox
    Friend WithEvents btnSaveSystem As Button

End Class
