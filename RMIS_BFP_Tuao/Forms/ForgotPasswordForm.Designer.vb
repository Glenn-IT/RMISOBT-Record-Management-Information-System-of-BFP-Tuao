<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForgotPasswordForm
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
        pnlCard = New Panel()
        lblTitle = New Label()
        lblSub = New Label()
        pnlDivider = New Panel()
        lblUsername = New Label()
        pnlUsernameRow = New Panel()
        txtUsername = New TextBox()
        btnVerify = New Button()
        lblSecQuestion = New Label()
        cboSecQuestion = New ComboBox()
        lblAnswer = New Label()
        txtAnswer = New TextBox()
        lblNewPassword = New Label()
        txtNewPassword = New TextBox()
        lblConfirmPassword = New Label()
        txtConfirmPassword = New TextBox()
        lblStatus = New Label()
        btnReset = New Button()
        btnCancel = New Button()
        pnlCard.SuspendLayout()
        pnlUsernameRow.SuspendLayout()
        SuspendLayout()
        '
        ' pnlCard
        '
        pnlCard.BackColor = Color.White
        pnlCard.Controls.Add(lblTitle)
        pnlCard.Controls.Add(lblSub)
        pnlCard.Controls.Add(pnlDivider)
        pnlCard.Controls.Add(lblUsername)
        pnlCard.Controls.Add(pnlUsernameRow)
        pnlCard.Controls.Add(lblSecQuestion)
        pnlCard.Controls.Add(cboSecQuestion)
        pnlCard.Controls.Add(lblAnswer)
        pnlCard.Controls.Add(txtAnswer)
        pnlCard.Controls.Add(lblNewPassword)
        pnlCard.Controls.Add(txtNewPassword)
        pnlCard.Controls.Add(lblConfirmPassword)
        pnlCard.Controls.Add(txtConfirmPassword)
        pnlCard.Controls.Add(lblStatus)
        pnlCard.Controls.Add(btnReset)
        pnlCard.Controls.Add(btnCancel)
        pnlCard.Dock = DockStyle.Fill
        pnlCard.Location = New Point(0, 0)
        pnlCard.Name = "pnlCard"
        pnlCard.Padding = New Padding(36, 28, 36, 28)
        pnlCard.TabIndex = 0
        '
        ' lblTitle
        '
        lblTitle.Font = New Font("Segoe UI", 17F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblTitle.Location = New Point(36, 28)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(388, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Reset Password"
        '
        ' lblSub
        '
        lblSub.Font = New Font("Segoe UI", 9.5F)
        lblSub.ForeColor = Color.Gray
        lblSub.Location = New Point(36, 68)
        lblSub.Name = "lblSub"
        lblSub.Size = New Size(388, 22)
        lblSub.TabIndex = 1
        lblSub.Text = "Enter your username to get started."
        '
        ' pnlDivider
        '
        pnlDivider.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        pnlDivider.Location = New Point(36, 96)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(388, 3)
        pnlDivider.TabIndex = 2
        '
        ' lblUsername
        '
        lblUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblUsername.Location = New Point(36, 112)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(388, 20)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Username *"
        '
        ' pnlUsernameRow
        '
        pnlUsernameRow.Controls.Add(txtUsername)
        pnlUsernameRow.Controls.Add(btnVerify)
        pnlUsernameRow.Location = New Point(36, 134)
        pnlUsernameRow.Name = "pnlUsernameRow"
        pnlUsernameRow.Size = New Size(388, 32)
        pnlUsernameRow.TabIndex = 4
        '
        ' txtUsername
        '
        txtUsername.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10.5F)
        txtUsername.Location = New Point(0, 0)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter your username"
        txtUsername.Size = New Size(278, 28)
        txtUsername.TabIndex = 0
        '
        ' btnVerify
        '
        btnVerify.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        btnVerify.Cursor = Cursors.Hand
        btnVerify.FlatAppearance.BorderSize = 0
        btnVerify.FlatStyle = FlatStyle.Flat
        btnVerify.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnVerify.ForeColor = Color.White
        btnVerify.Location = New Point(284, 0)
        btnVerify.Name = "btnVerify"
        btnVerify.Size = New Size(104, 28)
        btnVerify.TabIndex = 1
        btnVerify.Text = "Verify"
        btnVerify.UseVisualStyleBackColor = False
        '
        ' lblSecQuestion
        '
        lblSecQuestion.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblSecQuestion.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblSecQuestion.Location = New Point(36, 182)
        lblSecQuestion.Name = "lblSecQuestion"
        lblSecQuestion.Size = New Size(388, 20)
        lblSecQuestion.TabIndex = 5
        lblSecQuestion.Text = "Select Your Security Question *"
        lblSecQuestion.Visible = False
        '
        ' cboSecQuestion
        '
        cboSecQuestion.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        cboSecQuestion.DropDownStyle = ComboBoxStyle.DropDownList
        cboSecQuestion.Font = New Font("Segoe UI", 10.5F)
        cboSecQuestion.Location = New Point(36, 204)
        cboSecQuestion.Name = "cboSecQuestion"
        cboSecQuestion.Size = New Size(388, 28)
        cboSecQuestion.TabIndex = 6
        cboSecQuestion.Visible = False
        '
        ' lblAnswer
        '
        lblAnswer.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblAnswer.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblAnswer.Location = New Point(36, 234)
        lblAnswer.Name = "lblAnswer"
        lblAnswer.Size = New Size(388, 20)
        lblAnswer.TabIndex = 7
        lblAnswer.Text = "Answer *"
        lblAnswer.Visible = False
        '
        ' txtAnswer
        '
        txtAnswer.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtAnswer.BorderStyle = BorderStyle.FixedSingle
        txtAnswer.Font = New Font("Segoe UI", 10.5F)
        txtAnswer.Location = New Point(36, 256)
        txtAnswer.Name = "txtAnswer"
        txtAnswer.PlaceholderText = "Enter your answer"
        txtAnswer.Size = New Size(388, 28)
        txtAnswer.TabIndex = 8
        txtAnswer.Visible = False
        '
        ' lblNewPassword
        '
        lblNewPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblNewPassword.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblNewPassword.Location = New Point(36, 302)
        lblNewPassword.Name = "lblNewPassword"
        lblNewPassword.Size = New Size(388, 20)
        lblNewPassword.TabIndex = 9
        lblNewPassword.Text = "New Password *"
        lblNewPassword.Visible = False
        '
        ' txtNewPassword
        '
        txtNewPassword.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtNewPassword.BorderStyle = BorderStyle.FixedSingle
        txtNewPassword.Font = New Font("Segoe UI", 10.5F)
        txtNewPassword.Location = New Point(36, 324)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.PlaceholderText = "Enter new password"
        txtNewPassword.Size = New Size(388, 28)
        txtNewPassword.TabIndex = 10
        txtNewPassword.UseSystemPasswordChar = True
        txtNewPassword.Visible = False
        '
        ' lblConfirmPassword
        '
        lblConfirmPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblConfirmPassword.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblConfirmPassword.Location = New Point(36, 368)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(388, 20)
        lblConfirmPassword.TabIndex = 11
        lblConfirmPassword.Text = "Confirm New Password *"
        lblConfirmPassword.Visible = False
        '
        ' txtConfirmPassword
        '
        txtConfirmPassword.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPassword.Font = New Font("Segoe UI", 10.5F)
        txtConfirmPassword.Location = New Point(36, 390)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PlaceholderText = "Re-enter new password"
        txtConfirmPassword.Size = New Size(388, 28)
        txtConfirmPassword.TabIndex = 12
        txtConfirmPassword.UseSystemPasswordChar = True
        txtConfirmPassword.Visible = False
        '
        ' lblStatus
        '
        lblStatus.Font = New Font("Segoe UI", 8.5F)
        lblStatus.ForeColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        lblStatus.Location = New Point(36, 428)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(388, 20)
        lblStatus.TabIndex = 13
        lblStatus.Text = ""
        lblStatus.Visible = False
        '
        ' btnReset
        '
        btnReset.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        btnReset.Cursor = Cursors.Hand
        btnReset.FlatAppearance.BorderSize = 0
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnReset.ForeColor = Color.White
        btnReset.Location = New Point(36, 456)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(388, 44)
        btnReset.TabIndex = 14
        btnReset.Text = "Reset Password"
        btnReset.UseVisualStyleBackColor = False
        btnReset.Visible = False
        '
        ' btnCancel
        '
        btnCancel.BackColor = Color.White
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 9.5F)
        btnCancel.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        btnCancel.Location = New Point(36, 508)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(388, 36)
        btnCancel.TabIndex = 15
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        '
        ' ForgotPasswordForm
        '
        BackColor = Color.White
        ClientSize = New Size(460, 564)
        Controls.Add(pnlCard)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "ForgotPasswordForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Forgot Password — RMIS BFP Tuao"
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        pnlUsernameRow.ResumeLayout(False)
        pnlUsernameRow.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlCard            As Panel
    Friend WithEvents lblTitle           As Label
    Friend WithEvents lblSub             As Label
    Friend WithEvents pnlDivider         As Panel
    Friend WithEvents lblUsername        As Label
    Friend WithEvents pnlUsernameRow     As Panel
    Friend WithEvents txtUsername        As TextBox
    Friend WithEvents btnVerify          As Button
    Friend WithEvents lblSecQuestion     As Label
    Friend WithEvents cboSecQuestion      As ComboBox
    Friend WithEvents lblAnswer          As Label
    Friend WithEvents txtAnswer          As TextBox
    Friend WithEvents lblNewPassword     As Label
    Friend WithEvents txtNewPassword     As TextBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblStatus          As Label
    Friend WithEvents btnReset           As Button
    Friend WithEvents btnCancel          As Button

End Class
