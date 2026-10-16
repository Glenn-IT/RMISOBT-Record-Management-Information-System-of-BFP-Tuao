<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserManagementForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblTitle = New Label()
        lblSub = New Label()
        pnlDivider = New Panel()
        pnlBody = New Panel()
        dgvUsers = New DataGridView()
        colID = New DataGridViewTextBoxColumn()
        colUsername = New DataGridViewTextBoxColumn()
        colRole = New DataGridViewTextBoxColumn()
        colCreated = New DataGridViewTextBoxColumn()
        btnDeleteUser = New Button()
        grpNewUser = New GroupBox()
        lblNewUsername = New Label()
        txtNewUsername = New TextBox()
        lblNewPassword = New Label()
        txtNewPassword = New TextBox()
        lblNewConfirm = New Label()
        txtNewConfirm = New TextBox()
        lblNewRole = New Label()
        cboNewRole = New ComboBox()
        lblPassHelp = New Label()
        btnCreateUser = New Button()
        btnNewMode = New Button()
        pnlFooter = New Panel()
        btnClose = New Button()
        pnlHeader.SuspendLayout()
        pnlBody.SuspendLayout()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        grpNewUser.SuspendLayout()
        pnlFooter.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(lblSub)
        pnlHeader.Controls.Add(pnlDivider)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(740, 75)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblTitle.Location = New Point(20, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(700, 28)
        lblTitle.TabIndex = 0
        lblTitle.Text = "User Account Management"
        ' 
        ' lblSub
        ' 
        lblSub.Font = New Font("Segoe UI", 9F)
        lblSub.ForeColor = Color.Gray
        lblSub.Location = New Point(20, 40)
        lblSub.Name = "lblSub"
        lblSub.Size = New Size(700, 20)
        lblSub.TabIndex = 1
        lblSub.Text = "Super Admin portal to manage Super Admin and Sub Admin accounts."
        ' 
        ' pnlDivider
        ' 
        pnlDivider.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        pnlDivider.Dock = DockStyle.Bottom
        pnlDivider.Location = New Point(0, 72)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(740, 3)
        pnlDivider.TabIndex = 2
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        pnlBody.Controls.Add(dgvUsers)
        pnlBody.Controls.Add(btnDeleteUser)
        pnlBody.Controls.Add(grpNewUser)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 75)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New Padding(20, 15, 20, 15)
        pnlBody.Size = New Size(740, 435)
        pnlBody.TabIndex = 1
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AllowUserToAddRows = False
        dgvUsers.AllowUserToDeleteRows = False
        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUsers.BackgroundColor = Color.White
        dgvUsers.BorderStyle = BorderStyle.FixedSingle
        dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvUsers.ColumnHeadersHeight = 32
        dgvUsers.Columns.AddRange(New DataGridViewColumn() {colID, colUsername, colRole, colCreated})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(220), CByte(50), CByte(50))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvUsers.DefaultCellStyle = DataGridViewCellStyle2
        dgvUsers.EnableHeadersVisualStyles = False
        dgvUsers.Location = New Point(20, 15)
        dgvUsers.MultiSelect = False
        dgvUsers.Name = "dgvUsers"
        dgvUsers.ReadOnly = True
        dgvUsers.RowHeadersVisible = False
        dgvUsers.RowTemplate.Height = 30
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsers.Size = New Size(400, 360)
        dgvUsers.TabIndex = 0
        ' 
        ' colID
        ' 
        colID.FillWeight = 15F
        colID.HeaderText = "ID"
        colID.Name = "colID"
        colID.ReadOnly = True
        ' 
        ' colUsername
        ' 
        colUsername.FillWeight = 40F
        colUsername.HeaderText = "Username"
        colUsername.Name = "colUsername"
        colUsername.ReadOnly = True
        ' 
        ' colRole
        ' 
        colRole.FillWeight = 30F
        colRole.HeaderText = "Role"
        colRole.Name = "colRole"
        colRole.ReadOnly = True
        ' 
        ' colCreated
        ' 
        colCreated.FillWeight = 35F
        colCreated.HeaderText = "Created"
        colCreated.Name = "colCreated"
        colCreated.ReadOnly = True
        ' 
        ' btnDeleteUser
        ' 
        btnDeleteUser.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        btnDeleteUser.Cursor = Cursors.Hand
        btnDeleteUser.FlatAppearance.BorderSize = 0
        btnDeleteUser.FlatStyle = FlatStyle.Flat
        btnDeleteUser.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnDeleteUser.ForeColor = Color.White
        btnDeleteUser.Location = New Point(20, 385)
        btnDeleteUser.Name = "btnDeleteUser"
        btnDeleteUser.Size = New Size(160, 32)
        btnDeleteUser.TabIndex = 1
        btnDeleteUser.Text = "Delete Selected User"
        btnDeleteUser.UseVisualStyleBackColor = False
        ' 
        ' grpNewUser
        ' 
        grpNewUser.BackColor = Color.White
        grpNewUser.Controls.Add(lblNewUsername)
        grpNewUser.Controls.Add(txtNewUsername)
        grpNewUser.Controls.Add(lblNewRole)
        grpNewUser.Controls.Add(cboNewRole)
        grpNewUser.Controls.Add(lblNewPassword)
        grpNewUser.Controls.Add(txtNewPassword)
        grpNewUser.Controls.Add(lblNewConfirm)
        grpNewUser.Controls.Add(txtNewConfirm)
        grpNewUser.Controls.Add(lblPassHelp)
        grpNewUser.Controls.Add(btnCreateUser)
        grpNewUser.Controls.Add(btnNewMode)
        grpNewUser.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        grpNewUser.ForeColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        grpNewUser.Location = New Point(435, 15)
        grpNewUser.Name = "grpNewUser"
        grpNewUser.Padding = New Padding(15, 12, 15, 12)
        grpNewUser.Size = New Size(285, 402)
        grpNewUser.TabIndex = 2
        grpNewUser.TabStop = False
        grpNewUser.Text = " Create New Account "
        ' 
        ' lblNewUsername
        ' 
        lblNewUsername.Font = New Font("Segoe UI", 8.5F)
        lblNewUsername.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblNewUsername.Location = New Point(15, 24)
        lblNewUsername.Name = "lblNewUsername"
        lblNewUsername.Size = New Size(255, 18)
        lblNewUsername.TabIndex = 0
        lblNewUsername.Text = "Username:"
        ' 
        ' txtNewUsername
        ' 
        txtNewUsername.Font = New Font("Segoe UI", 9F)
        txtNewUsername.Location = New Point(15, 44)
        txtNewUsername.Name = "txtNewUsername"
        txtNewUsername.Size = New Size(255, 23)
        txtNewUsername.TabIndex = 1
        ' 
        ' lblNewRole
        ' 
        lblNewRole.Font = New Font("Segoe UI", 8.5F)
        lblNewRole.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblNewRole.Location = New Point(15, 74)
        lblNewRole.Name = "lblNewRole"
        lblNewRole.Size = New Size(255, 18)
        lblNewRole.TabIndex = 2
        lblNewRole.Text = "Role Assignment:"
        ' 
        ' cboNewRole
        ' 
        cboNewRole.DropDownStyle = ComboBoxStyle.DropDownList
        cboNewRole.Font = New Font("Segoe UI", 9F)
        cboNewRole.FormattingEnabled = True
        cboNewRole.Location = New Point(15, 94)
        cboNewRole.Name = "cboNewRole"
        cboNewRole.Size = New Size(255, 23)
        cboNewRole.TabIndex = 3
        ' 
        ' lblNewPassword
        ' 
        lblNewPassword.Font = New Font("Segoe UI", 8.5F)
        lblNewPassword.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblNewPassword.Location = New Point(15, 126)
        lblNewPassword.Name = "lblNewPassword"
        lblNewPassword.Size = New Size(255, 18)
        lblNewPassword.TabIndex = 4
        lblNewPassword.Text = "Password:"
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Font = New Font("Segoe UI", 9F)
        txtNewPassword.Location = New Point(15, 146)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.PasswordChar = "*"c
        txtNewPassword.Size = New Size(255, 23)
        txtNewPassword.TabIndex = 5
        ' 
        ' lblNewConfirm
        ' 
        lblNewConfirm.Font = New Font("Segoe UI", 8.5F)
        lblNewConfirm.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblNewConfirm.Location = New Point(15, 178)
        lblNewConfirm.Name = "lblNewConfirm"
        lblNewConfirm.Size = New Size(255, 18)
        lblNewConfirm.TabIndex = 6
        lblNewConfirm.Text = "Confirm Password:"
        ' 
        ' txtNewConfirm
        ' 
        txtNewConfirm.Font = New Font("Segoe UI", 9F)
        txtNewConfirm.Location = New Point(15, 198)
        txtNewConfirm.Name = "txtNewConfirm"
        txtNewConfirm.PasswordChar = "*"c
        txtNewConfirm.Size = New Size(255, 23)
        txtNewConfirm.TabIndex = 7
        ' 
        ' lblPassHelp
        ' 
        lblPassHelp.Font = New Font("Segoe UI", 8F)
        lblPassHelp.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        lblPassHelp.Location = New Point(15, 226)
        lblPassHelp.Name = "lblPassHelp"
        lblPassHelp.Size = New Size(255, 32)
        lblPassHelp.TabIndex = 8
        lblPassHelp.Text = "Password must be at least 4 characters."
        ' 
        ' btnCreateUser
        ' 
        btnCreateUser.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        btnCreateUser.Cursor = Cursors.Hand
        btnCreateUser.FlatAppearance.BorderSize = 0
        btnCreateUser.FlatStyle = FlatStyle.Flat
        btnCreateUser.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnCreateUser.ForeColor = Color.White
        btnCreateUser.Location = New Point(15, 265)
        btnCreateUser.Name = "btnCreateUser"
        btnCreateUser.Size = New Size(255, 36)
        btnCreateUser.TabIndex = 9
        btnCreateUser.Text = "+ Add User Account"
        btnCreateUser.UseVisualStyleBackColor = False
        ' 
        ' btnNewMode
        ' 
        btnNewMode.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        btnNewMode.Cursor = Cursors.Hand
        btnNewMode.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        btnNewMode.FlatStyle = FlatStyle.Flat
        btnNewMode.Font = New Font("Segoe UI", 9F)
        btnNewMode.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnNewMode.Location = New Point(15, 310)
        btnNewMode.Name = "btnNewMode"
        btnNewMode.Size = New Size(255, 30)
        btnNewMode.TabIndex = 10
        btnNewMode.Text = "+ Switch to Add New User"
        btnNewMode.UseVisualStyleBackColor = False
        btnNewMode.Visible = False
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.White
        pnlFooter.Controls.Add(btnClose)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 510)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(740, 50)
        pnlFooter.TabIndex = 2
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 9F)
        btnClose.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnClose.Location = New Point(635, 10)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(85, 30)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' UserManagementForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(740, 560)
        Controls.Add(pnlBody)
        Controls.Add(pnlFooter)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "UserManagementForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "User Account Management"
        pnlHeader.ResumeLayout(False)
        pnlBody.ResumeLayout(False)
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        grpNewUser.ResumeLayout(False)
        grpNewUser.PerformLayout()
        pnlFooter.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents pnlDivider As Panel
    Friend WithEvents pnlBody As Panel
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colUsername As DataGridViewTextBoxColumn
    Friend WithEvents colRole As DataGridViewTextBoxColumn
    Friend WithEvents colCreated As DataGridViewTextBoxColumn
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents grpNewUser As GroupBox
    Friend WithEvents lblNewUsername As Label
    Friend WithEvents txtNewUsername As TextBox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents lblNewConfirm As Label
    Friend WithEvents txtNewConfirm As TextBox
    Friend WithEvents lblNewRole As Label
    Friend WithEvents cboNewRole As ComboBox
    Friend WithEvents lblPassHelp As Label
    Friend WithEvents btnCreateUser As Button
    Friend WithEvents btnNewMode As Button
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnClose As Button

End Class
