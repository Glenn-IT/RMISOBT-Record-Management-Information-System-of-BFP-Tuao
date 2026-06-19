<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

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
        pnlLeft = New Panel()
        picLogo = New PictureBox()
        lblSystemTitle = New Label()
        lblSystemSubtitle = New Label()
        lblAgency = New Label()
        pnlRight = New Panel()
        pnlLoginCard = New Panel()
        lblLoginHeader = New Label()
        lblLoginSub = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        lnkForgotPassword = New LinkLabel()
        lblError = New Label()
        btnLogin = New Button()
        btnExit = New Button()
        lblFooter = New Label()
        pnlLeft.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlRight.SuspendLayout()
        pnlLoginCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        pnlLeft.Controls.Add(picLogo)
        pnlLeft.Controls.Add(lblSystemTitle)
        pnlLeft.Controls.Add(lblSystemSubtitle)
        pnlLeft.Controls.Add(lblAgency)
        pnlLeft.Dock = DockStyle.Left
        pnlLeft.Location = New Point(0, 0)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(420, 609)
        pnlLeft.TabIndex = 1
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.Location = New Point(155, 160)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(110, 110)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' lblSystemTitle
        ' 
        lblSystemTitle.Font = New Font("Segoe UI", 26.0F, FontStyle.Bold)
        lblSystemTitle.ForeColor = Color.White
        lblSystemTitle.Location = New Point(20, 295)
        lblSystemTitle.Name = "lblSystemTitle"
        lblSystemTitle.Size = New Size(380, 45)
        lblSystemTitle.TabIndex = 1
        lblSystemTitle.Text = "BFP TUAO"
        lblSystemTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSystemSubtitle
        ' 
        lblSystemSubtitle.Font = New Font("Segoe UI", 14.0F)
        lblSystemSubtitle.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(200))
        lblSystemSubtitle.Location = New Point(20, 345)
        lblSystemSubtitle.Name = "lblSystemSubtitle"
        lblSystemSubtitle.Size = New Size(380, 60)
        lblSystemSubtitle.TabIndex = 2
        lblSystemSubtitle.Text = "Record Management" & vbCrLf & "Information System"
        lblSystemSubtitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAgency
        ' 
        lblAgency.Font = New Font("Segoe UI", 10.0F, FontStyle.Italic)
        lblAgency.ForeColor = Color.FromArgb(CByte(255), CByte(230), CByte(230))
        lblAgency.Location = New Point(20, 430)
        lblAgency.Name = "lblAgency"
        lblAgency.Size = New Size(380, 50)
        lblAgency.TabIndex = 3
        lblAgency.Text = "Bureau of Fire Protection" & vbCrLf & "Tuao, Cagayan"
        lblAgency.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        pnlRight.Controls.Add(pnlLoginCard)
        pnlRight.Controls.Add(lblFooter)
        pnlRight.Dock = DockStyle.Fill
        pnlRight.Location = New Point(420, 0)
        pnlRight.Name = "pnlRight"
        pnlRight.Size = New Size(464, 609)
        pnlRight.TabIndex = 0
        ' 
        ' pnlLoginCard
        ' 
        pnlLoginCard.BackColor = Color.White
        pnlLoginCard.Controls.Add(lblLoginHeader)
        pnlLoginCard.Controls.Add(lblLoginSub)
        pnlLoginCard.Controls.Add(lblUsername)
        pnlLoginCard.Controls.Add(txtUsername)
        pnlLoginCard.Controls.Add(lblPassword)
        pnlLoginCard.Controls.Add(txtPassword)
        pnlLoginCard.Controls.Add(lnkForgotPassword)
        pnlLoginCard.Controls.Add(lblError)
        pnlLoginCard.Controls.Add(btnLogin)
        pnlLoginCard.Controls.Add(btnExit)
        pnlLoginCard.Location = New Point(70, 90)
        pnlLoginCard.Name = "pnlLoginCard"
        pnlLoginCard.Size = New Size(340, 445)
        pnlLoginCard.TabIndex = 0
        ' 
        ' lblLoginHeader
        ' 
        lblLoginHeader.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblLoginHeader.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblLoginHeader.Location = New Point(20, 30)
        lblLoginHeader.Name = "lblLoginHeader"
        lblLoginHeader.Size = New Size(300, 38)
        lblLoginHeader.TabIndex = 0
        lblLoginHeader.Text = "Welcome Back"
        lblLoginHeader.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblLoginSub
        ' 
        lblLoginSub.Font = New Font("Segoe UI", 9.5F)
        lblLoginSub.ForeColor = Color.Gray
        lblLoginSub.Location = New Point(20, 68)
        lblLoginSub.Name = "lblLoginSub"
        lblLoginSub.Size = New Size(300, 24)
        lblLoginSub.TabIndex = 1
        lblLoginSub.Text = "Sign in to your account"
        lblLoginSub.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblUsername
        ' 
        lblUsername.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblUsername.Location = New Point(20, 115)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(300, 22)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10.5F)
        txtUsername.Location = New Point(20, 138)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter your username"
        txtUsername.Size = New Size(300, 28)
        txtUsername.TabIndex = 3
        ' 
        ' lblPassword
        ' 
        lblPassword.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblPassword.Location = New Point(20, 192)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(300, 22)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10.5F)
        txtPassword.Location = New Point(20, 215)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Enter your password"
        txtPassword.Size = New Size(300, 28)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        '
        ' lnkForgotPassword
        '
        lnkForgotPassword.Font = New Font("Segoe UI", 8.5F)
        lnkForgotPassword.LinkColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        lnkForgotPassword.ActiveLinkColor = Color.FromArgb(CByte(140), CByte(10), CByte(10))
        lnkForgotPassword.Location = New Point(20, 250)
        lnkForgotPassword.Name = "lnkForgotPassword"
        lnkForgotPassword.Size = New Size(300, 18)
        lnkForgotPassword.TabIndex = 6
        lnkForgotPassword.TabStop = True
        lnkForgotPassword.Text = "Forgot Password?"
        lnkForgotPassword.TextAlign = ContentAlignment.MiddleRight
        '
        ' lblError
        '
        lblError.Font = New Font("Segoe UI", 8.5F)
        lblError.ForeColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        lblError.Location = New Point(20, 274)
        lblError.Name = "lblError"
        lblError.Size = New Size(300, 22)
        lblError.TabIndex = 7
        lblError.Text = "Invalid username or password."
        lblError.Visible = False
        '
        ' btnLogin
        '
        btnLogin.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(20, 304)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(300, 44)
        btnLogin.TabIndex = 8
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        '
        ' btnExit
        '
        btnExit.BackColor = Color.White
        btnExit.Cursor = Cursors.Hand
        btnExit.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 9.5F)
        btnExit.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        btnExit.Location = New Point(20, 362)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(300, 36)
        btnExit.TabIndex = 9
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblFooter
        ' 
        lblFooter.Font = New Font("Segoe UI", 8.0F)
        lblFooter.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        lblFooter.Location = New Point(20, 600)
        lblFooter.Name = "lblFooter"
        lblFooter.Size = New Size(480, 24)
        lblFooter.TabIndex = 1
        lblFooter.Text = "© 2025 Bureau of Fire Protection — Tuao, Cagayan  |  Prototype v1.0"
        lblFooter.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LoginForm
        ' 
        BackColor = Color.White
        ClientSize = New Size(884, 609)
        Controls.Add(pnlRight)
        Controls.Add(pnlLeft)
        Font = New Font("Segoe UI", 9.0F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MaximumSize = New Size(900, 650)
        MinimumSize = New Size(900, 650)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BFP Tuao — RMIS Login"
        pnlLeft.ResumeLayout(False)
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlRight.ResumeLayout(False)
        pnlLoginCard.ResumeLayout(False)
        pnlLoginCard.PerformLayout()
        ResumeLayout(False)
    End Sub

    ' ── Control Declarations ──────────────────────────────────────
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlRight As Panel
    Friend WithEvents pnlLoginCard As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblSystemTitle As Label
    Friend WithEvents lblSystemSubtitle As Label
    Friend WithEvents lblAgency As Label
    Friend WithEvents lblLoginHeader As Label
    Friend WithEvents lblLoginSub As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lnkForgotPassword As LinkLabel
    Friend WithEvents lblError As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFooter As Label

End Class
