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

        pnlHeader       = New Panel()
        pnlDivider      = New Panel()
        lblPageTitle    = New Label()
        lblPageSub      = New Label()
        pnlAccount      = New Panel()
        lblAccTitle     = New Label()
        lblAccDivider   = New Panel()
        lblUsername     = New Label()
        txtUsername     = New TextBox()
        lblPassword     = New Label()
        txtPassword     = New TextBox()
        lblConfirmPw    = New Label()
        txtConfirmPw    = New TextBox()
        btnSaveAccount  = New Button()
        pnlSystem       = New Panel()
        lblSysTitle     = New Label()
        lblSysDivider   = New Panel()
        lblStationName  = New Label()
        txtStationName  = New TextBox()
        lblStationAddr  = New Label()
        txtStationAddr  = New TextBox()
        btnSaveSystem   = New Button()

        pnlHeader.SuspendLayout()
        pnlAccount.SuspendLayout()
        pnlSystem.SuspendLayout()
        Me.SuspendLayout()

        ' ????????????????????????????????????????????????????????
        ' pnlHeader
        ' ????????????????????????????????????????????????????????
        pnlHeader.BackColor = Color.White
        pnlHeader.Size = New Size(920, 88)
        pnlHeader.Location = New Point(24, 18)
        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Controls.Add(lblPageSub)
        pnlHeader.Controls.Add(pnlDivider)

        lblPageTitle.Text = "Settings"
        lblPageTitle.Font = New Font("Segoe UI", 15, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.FromArgb(30, 30, 30)
        lblPageTitle.AutoSize = False
        lblPageTitle.Size = New Size(600, 34)
        lblPageTitle.Location = New Point(20, 12)

        lblPageSub.Text = "Manage account credentials and system information."
        lblPageSub.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblPageSub.ForeColor = Color.Gray
        lblPageSub.AutoSize = False
        lblPageSub.Size = New Size(600, 22)
        lblPageSub.Location = New Point(20, 46)

        pnlDivider.BackColor = Color.FromArgb(180, 20, 20)
        pnlDivider.Size = New Size(880, 3)
        pnlDivider.Location = New Point(20, 78)

        ' ????????????????????????????????????????????????????????
        ' pnlAccount — change credentials
        ' ????????????????????????????????????????????????????????
        pnlAccount.BackColor = Color.White
        pnlAccount.Size = New Size(440, 290)
        pnlAccount.Location = New Point(24, 120)
        pnlAccount.Controls.Add(lblAccTitle)
        pnlAccount.Controls.Add(lblAccDivider)
        pnlAccount.Controls.Add(lblUsername)
        pnlAccount.Controls.Add(txtUsername)
        pnlAccount.Controls.Add(lblPassword)
        pnlAccount.Controls.Add(txtPassword)
        pnlAccount.Controls.Add(lblConfirmPw)
        pnlAccount.Controls.Add(txtConfirmPw)
        pnlAccount.Controls.Add(btnSaveAccount)

        lblAccTitle.Text = "Account Settings"
        lblAccTitle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        lblAccTitle.ForeColor = Color.FromArgb(30, 30, 30)
        lblAccTitle.AutoSize = False
        lblAccTitle.Size = New Size(400, 30)
        lblAccTitle.Location = New Point(16, 12)

        lblAccDivider.BackColor = Color.FromArgb(220, 220, 220)
        lblAccDivider.Size = New Size(408, 1)
        lblAccDivider.Location = New Point(16, 44)

        lblUsername.Text = "Username"
        lblUsername.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(70, 70, 70)
        lblUsername.AutoSize = False
        lblUsername.Size = New Size(380, 20)
        lblUsername.Location = New Point(16, 56)

        txtUsername.Font = New Font("Segoe UI", 10)
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.BackColor = Color.FromArgb(250, 250, 250)
        txtUsername.Size = New Size(408, 30)
        txtUsername.Location = New Point(16, 78)

        lblPassword.Text = "New Password"
        lblPassword.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(70, 70, 70)
        lblPassword.AutoSize = False
        lblPassword.Size = New Size(380, 20)
        lblPassword.Location = New Point(16, 120)

        txtPassword.Font = New Font("Segoe UI", 10)
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.BackColor = Color.FromArgb(250, 250, 250)
        txtPassword.Size = New Size(408, 30)
        txtPassword.Location = New Point(16, 142)
        txtPassword.PasswordChar = "?"c

        lblConfirmPw.Text = "Confirm Password"
        lblConfirmPw.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblConfirmPw.ForeColor = Color.FromArgb(70, 70, 70)
        lblConfirmPw.AutoSize = False
        lblConfirmPw.Size = New Size(380, 20)
        lblConfirmPw.Location = New Point(16, 184)

        txtConfirmPw.Font = New Font("Segoe UI", 10)
        txtConfirmPw.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPw.BackColor = Color.FromArgb(250, 250, 250)
        txtConfirmPw.Size = New Size(408, 30)
        txtConfirmPw.Location = New Point(16, 206)
        txtConfirmPw.PasswordChar = "?"c

        btnSaveAccount.Text = "Save Changes"
        btnSaveAccount.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSaveAccount.Size = New Size(150, 36)
        btnSaveAccount.Location = New Point(16, 242)
        btnSaveAccount.BackColor = Color.FromArgb(180, 20, 20)
        btnSaveAccount.ForeColor = Color.White
        btnSaveAccount.FlatStyle = FlatStyle.Flat
        btnSaveAccount.FlatAppearance.BorderSize = 0
        btnSaveAccount.Cursor = Cursors.Hand

        ' ????????????????????????????????????????????????????????
        ' pnlSystem — station info
        ' ????????????????????????????????????????????????????????
        pnlSystem.BackColor = Color.White
        pnlSystem.Size = New Size(440, 290)
        pnlSystem.Location = New Point(480, 120)
        pnlSystem.Controls.Add(lblSysTitle)
        pnlSystem.Controls.Add(lblSysDivider)
        pnlSystem.Controls.Add(lblStationName)
        pnlSystem.Controls.Add(txtStationName)
        pnlSystem.Controls.Add(lblStationAddr)
        pnlSystem.Controls.Add(txtStationAddr)
        pnlSystem.Controls.Add(btnSaveSystem)

        lblSysTitle.Text = "System Information"
        lblSysTitle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        lblSysTitle.ForeColor = Color.FromArgb(30, 30, 30)
        lblSysTitle.AutoSize = False
        lblSysTitle.Size = New Size(400, 30)
        lblSysTitle.Location = New Point(16, 12)

        lblSysDivider.BackColor = Color.FromArgb(220, 220, 220)
        lblSysDivider.Size = New Size(408, 1)
        lblSysDivider.Location = New Point(16, 44)

        lblStationName.Text = "Station Name"
        lblStationName.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblStationName.ForeColor = Color.FromArgb(70, 70, 70)
        lblStationName.AutoSize = False
        lblStationName.Size = New Size(380, 20)
        lblStationName.Location = New Point(16, 56)

        txtStationName.Font = New Font("Segoe UI", 10)
        txtStationName.BorderStyle = BorderStyle.FixedSingle
        txtStationName.BackColor = Color.FromArgb(250, 250, 250)
        txtStationName.Size = New Size(408, 30)
        txtStationName.Location = New Point(16, 78)
        txtStationName.Text = "BFP Tuao Fire Station"

        lblStationAddr.Text = "Station Address"
        lblStationAddr.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblStationAddr.ForeColor = Color.FromArgb(70, 70, 70)
        lblStationAddr.AutoSize = False
        lblStationAddr.Size = New Size(380, 20)
        lblStationAddr.Location = New Point(16, 120)
        txtStationAddr.Font = New Font("Segoe UI", 10)
        txtStationAddr.BorderStyle = BorderStyle.FixedSingle
        txtStationAddr.BackColor = Color.FromArgb(250, 250, 250)
        txtStationAddr.Multiline = True
        txtStationAddr.Size = New Size(408, 72)
        txtStationAddr.Location = New Point(16, 142)
        txtStationAddr.Text = "Tuao, Cagayan"

        btnSaveSystem.Text = "Save Changes"
        btnSaveSystem.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSaveSystem.Size = New Size(150, 36)
        btnSaveSystem.Location = New Point(16, 242)
        btnSaveSystem.BackColor = Color.FromArgb(180, 20, 20)
        btnSaveSystem.ForeColor = Color.White
        btnSaveSystem.FlatStyle = FlatStyle.Flat
        btnSaveSystem.FlatAppearance.BorderSize = 0
        btnSaveSystem.Cursor = Cursors.Hand

        Me.BackColor = Color.FromArgb(240, 242, 245)
        Me.Controls.Add(pnlHeader)
        Me.Controls.Add(pnlAccount)
        Me.Controls.Add(pnlSystem)

        pnlSystem.ResumeLayout(False)
        pnlAccount.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents btnSaveAccount As Button
    Friend WithEvents pnlSystem      As Panel
    Friend WithEvents lblSysTitle    As Label
    Friend WithEvents lblSysDivider  As Panel
    Friend WithEvents lblStationName As Label
    Friend WithEvents txtStationName As TextBox
    Friend WithEvents lblStationAddr As Label
    Friend WithEvents txtStationAddr As TextBox
    Friend WithEvents btnSaveSystem  As Button

End Class
