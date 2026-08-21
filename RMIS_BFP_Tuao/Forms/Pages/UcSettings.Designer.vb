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
        lblSecTitle = New Label()
        lblSecDivider = New Panel()
        lblSecQuestion = New Label()
        cboSecQuestion = New ComboBox()
        lblSecAnswer = New Label()
        txtSecAnswer = New TextBox()
        btnSaveSecQuestion = New Button()
        pnlSystem = New Panel()
        lblSysTitle = New Label()
        lblSysDivider = New Panel()
        lblStationName = New Label()
        txtStationName = New TextBox()
        lblStationAddr = New Label()
        txtStationAddr = New TextBox()
        btnSaveSystem = New Button()
        pnlBanner = New Panel()
        lblBannerTitle = New Label()
        lblBannerDivider = New Panel()
        picBanner = New PictureBox()
        btnBrowseBanner = New Button()
        btnSaveBanner = New Button()
        lblBannerHint = New Label()
        pnlHeader.SuspendLayout()
        pnlAccount.SuspendLayout()
        pnlSystem.SuspendLayout()
        pnlBanner.SuspendLayout()
        CType(picBanner, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Controls.Add(lblPageSub)
        pnlHeader.Controls.Add(pnlDivider)
        pnlHeader.Location = New Point(26, 20)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1222, 97)
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
        lblPageSub.Text = "Manage account credentials and system information."
        ' 
        ' pnlDivider
        ' 
        pnlDivider.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDivider.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        pnlDivider.Location = New Point(22, 86)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(1178, 3)
        pnlDivider.TabIndex = 2
        ' 
        ' pnlAccount
        ' 
        pnlAccount.BackColor = Color.White
        pnlAccount.Controls.Add(lblAccTitle)
        pnlAccount.Controls.Add(lblAccDivider)
        pnlAccount.Controls.Add(lblSecTitle)
        pnlAccount.Controls.Add(lblSecDivider)
        pnlAccount.Controls.Add(lblUsername)
        pnlAccount.Controls.Add(lblSecQuestion)
        pnlAccount.Controls.Add(cboSecQuestion)
        pnlAccount.Controls.Add(txtUsername)
        pnlAccount.Controls.Add(lblSecAnswer)
        pnlAccount.Controls.Add(txtSecAnswer)
        pnlAccount.Controls.Add(lblPassword)
        pnlAccount.Controls.Add(btnSaveSecQuestion)
        pnlAccount.Controls.Add(txtConfirmPw)
        pnlAccount.Controls.Add(txtPassword)
        pnlAccount.Controls.Add(lblConfirmPw)
        pnlAccount.Controls.Add(btnSaveAccount)
        pnlAccount.Location = New Point(26, 132)
        pnlAccount.Name = "pnlAccount"
        pnlAccount.Size = New Size(506, 585)
        pnlAccount.TabIndex = 1
        ' 
        ' lblAccTitle
        ' 
        lblAccTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblAccTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblAccTitle.Location = New Point(22, 267)
        lblAccTitle.Name = "lblAccTitle"
        lblAccTitle.Size = New Size(442, 33)
        lblAccTitle.TabIndex = 0
        lblAccTitle.Text = "Account Settings"
        ' 
        ' lblAccDivider
        ' 
        lblAccDivider.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        lblAccDivider.Location = New Point(22, 303)
        lblAccDivider.Name = "lblAccDivider"
        lblAccDivider.Size = New Size(450, 1)
        lblAccDivider.TabIndex = 1
        ' 
        ' lblUsername
        ' 
        lblUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblUsername.Location = New Point(22, 316)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(420, 22)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10F)
        txtUsername.Location = New Point(22, 340)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(450, 27)
        txtUsername.TabIndex = 3
        ' 
        ' lblPassword
        ' 
        lblPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblPassword.Location = New Point(22, 386)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(420, 22)
        lblPassword.TabIndex = 4
        lblPassword.Text = "New Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10F)
        txtPassword.Location = New Point(22, 411)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "?"c
        txtPassword.Size = New Size(450, 27)
        txtPassword.TabIndex = 5
        ' 
        ' lblConfirmPw
        ' 
        lblConfirmPw.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblConfirmPw.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblConfirmPw.Location = New Point(22, 457)
        lblConfirmPw.Name = "lblConfirmPw"
        lblConfirmPw.Size = New Size(420, 22)
        lblConfirmPw.TabIndex = 6
        lblConfirmPw.Text = "Confirm Password"
        ' 
        ' txtConfirmPw
        ' 
        txtConfirmPw.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtConfirmPw.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPw.Font = New Font("Segoe UI", 10F)
        txtConfirmPw.Location = New Point(22, 481)
        txtConfirmPw.Name = "txtConfirmPw"
        txtConfirmPw.PasswordChar = "?"c
        txtConfirmPw.Size = New Size(450, 27)
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
        btnSaveAccount.Location = New Point(22, 521)
        btnSaveAccount.Name = "btnSaveAccount"
        btnSaveAccount.Size = New Size(166, 40)
        btnSaveAccount.TabIndex = 8
        btnSaveAccount.Text = "Save Changes"
        btnSaveAccount.UseVisualStyleBackColor = False
        ' 
        ' lblSecTitle
        ' 
        lblSecTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblSecTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblSecTitle.Location = New Point(22, 13)
        lblSecTitle.Name = "lblSecTitle"
        lblSecTitle.Size = New Size(442, 33)
        lblSecTitle.TabIndex = 9
        lblSecTitle.Text = "Security Question"
        ' 
        ' lblSecDivider
        ' 
        lblSecDivider.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        lblSecDivider.Location = New Point(22, 49)
        lblSecDivider.Name = "lblSecDivider"
        lblSecDivider.Size = New Size(450, 1)
        lblSecDivider.TabIndex = 10
        ' 
        ' lblSecQuestion
        ' 
        lblSecQuestion.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblSecQuestion.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblSecQuestion.Location = New Point(22, 62)
        lblSecQuestion.Name = "lblSecQuestion"
        lblSecQuestion.Size = New Size(420, 22)
        lblSecQuestion.TabIndex = 11
        lblSecQuestion.Text = "Security Question"
        ' 
        ' cboSecQuestion
        ' 
        cboSecQuestion.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        cboSecQuestion.DropDownStyle = ComboBoxStyle.DropDownList
        cboSecQuestion.FlatStyle = FlatStyle.Flat
        cboSecQuestion.Font = New Font("Segoe UI", 10F)
        cboSecQuestion.Location = New Point(22, 86)
        cboSecQuestion.Name = "cboSecQuestion"
        cboSecQuestion.Size = New Size(450, 28)
        cboSecQuestion.TabIndex = 12
        ' 
        ' lblSecAnswer
        ' 
        lblSecAnswer.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblSecAnswer.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblSecAnswer.Location = New Point(22, 132)
        lblSecAnswer.Name = "lblSecAnswer"
        lblSecAnswer.Size = New Size(420, 22)
        lblSecAnswer.TabIndex = 13
        lblSecAnswer.Text = "Answer"
        ' 
        ' txtSecAnswer
        ' 
        txtSecAnswer.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtSecAnswer.BorderStyle = BorderStyle.FixedSingle
        txtSecAnswer.Font = New Font("Segoe UI", 10F)
        txtSecAnswer.Location = New Point(22, 157)
        txtSecAnswer.Name = "txtSecAnswer"
        txtSecAnswer.Size = New Size(450, 27)
        txtSecAnswer.TabIndex = 14
        ' 
        ' btnSaveSecQuestion
        ' 
        btnSaveSecQuestion.BackColor = Color.FromArgb(CByte(30), CByte(100), CByte(180))
        btnSaveSecQuestion.Cursor = Cursors.Hand
        btnSaveSecQuestion.FlatAppearance.BorderSize = 0
        btnSaveSecQuestion.FlatStyle = FlatStyle.Flat
        btnSaveSecQuestion.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSaveSecQuestion.ForeColor = Color.White
        btnSaveSecQuestion.Location = New Point(22, 203)
        btnSaveSecQuestion.Name = "btnSaveSecQuestion"
        btnSaveSecQuestion.Size = New Size(199, 40)
        btnSaveSecQuestion.TabIndex = 15
        btnSaveSecQuestion.Text = "Save Security Question"
        btnSaveSecQuestion.UseVisualStyleBackColor = False
        ' 
        ' pnlSystem
        ' 
        pnlSystem.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlSystem.BackColor = Color.White
        pnlSystem.Controls.Add(lblSysTitle)
        pnlSystem.Controls.Add(lblSysDivider)
        pnlSystem.Controls.Add(lblStationName)
        pnlSystem.Controls.Add(txtStationName)
        pnlSystem.Controls.Add(lblStationAddr)
        pnlSystem.Controls.Add(txtStationAddr)
        pnlSystem.Controls.Add(btnSaveSystem)
        pnlSystem.Location = New Point(1631, 132)
        pnlSystem.Name = "pnlSystem"
        pnlSystem.Size = New Size(486, 320)
        pnlSystem.TabIndex = 2
        ' 
        ' lblSysTitle
        ' 
        lblSysTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblSysTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblSysTitle.Location = New Point(18, 13)
        lblSysTitle.Name = "lblSysTitle"
        lblSysTitle.Size = New Size(442, 33)
        lblSysTitle.TabIndex = 0
        lblSysTitle.Text = "System Information"
        ' 
        ' lblSysDivider
        ' 
        lblSysDivider.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        lblSysDivider.Location = New Point(18, 49)
        lblSysDivider.Name = "lblSysDivider"
        lblSysDivider.Size = New Size(450, 1)
        lblSysDivider.TabIndex = 1
        ' 
        ' lblStationName
        ' 
        lblStationName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblStationName.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblStationName.Location = New Point(18, 62)
        lblStationName.Name = "lblStationName"
        lblStationName.Size = New Size(420, 22)
        lblStationName.TabIndex = 2
        lblStationName.Text = "Station Name"
        ' 
        ' txtStationName
        ' 
        txtStationName.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtStationName.BorderStyle = BorderStyle.FixedSingle
        txtStationName.Font = New Font("Segoe UI", 10F)
        txtStationName.Location = New Point(18, 86)
        txtStationName.Name = "txtStationName"
        txtStationName.Size = New Size(450, 27)
        txtStationName.TabIndex = 3
        txtStationName.Text = "BFP Tuao Fire Station"
        ' 
        ' lblStationAddr
        ' 
        lblStationAddr.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblStationAddr.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblStationAddr.Location = New Point(18, 132)
        lblStationAddr.Name = "lblStationAddr"
        lblStationAddr.Size = New Size(420, 22)
        lblStationAddr.TabIndex = 4
        lblStationAddr.Text = "Station Address"
        ' 
        ' txtStationAddr
        ' 
        txtStationAddr.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtStationAddr.BorderStyle = BorderStyle.FixedSingle
        txtStationAddr.Font = New Font("Segoe UI", 10F)
        txtStationAddr.Location = New Point(18, 157)
        txtStationAddr.Multiline = True
        txtStationAddr.Name = "txtStationAddr"
        txtStationAddr.Size = New Size(450, 79)
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
        btnSaveSystem.Location = New Point(18, 267)
        btnSaveSystem.Name = "btnSaveSystem"
        btnSaveSystem.Size = New Size(166, 40)
        btnSaveSystem.TabIndex = 6
        btnSaveSystem.Text = "Save Changes"
        btnSaveSystem.UseVisualStyleBackColor = False
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
        pnlBanner.Location = New Point(552, 132)
        pnlBanner.Name = "pnlBanner"
        pnlBanner.Size = New Size(486, 254)
        pnlBanner.TabIndex = 3
        ' 
        ' lblBannerTitle
        ' 
        lblBannerTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblBannerTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblBannerTitle.Location = New Point(18, 13)
        lblBannerTitle.Name = "lblBannerTitle"
        lblBannerTitle.Size = New Size(442, 33)
        lblBannerTitle.TabIndex = 0
        lblBannerTitle.Text = "Banner Image"
        ' 
        ' lblBannerDivider
        ' 
        lblBannerDivider.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        lblBannerDivider.Location = New Point(18, 49)
        lblBannerDivider.Name = "lblBannerDivider"
        lblBannerDivider.Size = New Size(450, 1)
        lblBannerDivider.TabIndex = 1
        ' 
        ' picBanner
        ' 
        picBanner.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        picBanner.BorderStyle = BorderStyle.FixedSingle
        picBanner.Location = New Point(18, 62)
        picBanner.Name = "picBanner"
        picBanner.Size = New Size(154, 154)
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
        btnBrowseBanner.Location = New Point(190, 62)
        btnBrowseBanner.Name = "btnBrowseBanner"
        btnBrowseBanner.Size = New Size(166, 40)
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
        btnSaveBanner.Location = New Point(190, 110)
        btnSaveBanner.Name = "btnSaveBanner"
        btnSaveBanner.Size = New Size(166, 40)
        btnSaveBanner.TabIndex = 4
        btnSaveBanner.Text = "Save Banner"
        btnSaveBanner.UseVisualStyleBackColor = False
        ' 
        ' lblBannerHint
        ' 
        lblBannerHint.Font = New Font("Segoe UI", 8F)
        lblBannerHint.ForeColor = Color.Gray
        lblBannerHint.Location = New Point(190, 159)
        lblBannerHint.Name = "lblBannerHint"
        lblBannerHint.Size = New Size(278, 57)
        lblBannerHint.TabIndex = 5
        lblBannerHint.Text = "PNG or JPG recommended. Appears on the login screen and sidebar."
        ' 
        ' UcSettings
        ' 
        AutoScaleDimensions = New SizeF(106F, 106F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        Controls.Add(pnlHeader)
        Controls.Add(pnlAccount)
        Controls.Add(pnlSystem)
        Controls.Add(pnlBanner)
        Font = New Font("Segoe UI", 9F)
        Name = "UcSettings"
        Size = New Size(1266, 774)
        pnlHeader.ResumeLayout(False)
        pnlAccount.ResumeLayout(False)
        pnlAccount.PerformLayout()
        pnlSystem.ResumeLayout(False)
        pnlSystem.PerformLayout()
        pnlBanner.ResumeLayout(False)
        CType(picBanner, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader      As Panel
    Friend WithEvents pnlDivider     As Panel
    Friend WithEvents lblPageTitle   As Label
    Friend WithEvents lblPageSub     As Label
    Friend WithEvents pnlAccount     As Panel
    Friend WithEvents lblAccTitle    As Label
    Friend WithEvents lblAccDivider  As Panel
    Friend WithEvents lblUsername    As Label
    Friend WithEvents txtUsername    As TextBox
    Friend WithEvents lblPassword    As Label
    Friend WithEvents txtPassword    As TextBox
    Friend WithEvents lblConfirmPw   As Label
    Friend WithEvents txtConfirmPw   As TextBox
    Friend WithEvents btnSaveAccount    As Button
    Friend WithEvents lblSecTitle       As Label
    Friend WithEvents lblSecDivider     As Panel
    Friend WithEvents lblSecQuestion    As Label
    Friend WithEvents cboSecQuestion    As ComboBox
    Friend WithEvents lblSecAnswer      As Label
    Friend WithEvents txtSecAnswer      As TextBox
    Friend WithEvents btnSaveSecQuestion As Button
    Friend WithEvents pnlSystem         As Panel
    Friend WithEvents lblSysTitle    As Label
    Friend WithEvents lblSysDivider  As Panel
    Friend WithEvents lblStationName As Label
    Friend WithEvents txtStationName As TextBox
    Friend WithEvents lblStationAddr As Label
    Friend WithEvents txtStationAddr As TextBox
    Friend WithEvents btnSaveSystem  As Button
    Friend WithEvents pnlBanner         As Panel
    Friend WithEvents lblBannerTitle    As Label
    Friend WithEvents lblBannerDivider  As Panel
    Friend WithEvents picBanner         As PictureBox
    Friend WithEvents btnBrowseBanner   As Button
    Friend WithEvents btnSaveBanner     As Button
    Friend WithEvents lblBannerHint     As Label

End Class
