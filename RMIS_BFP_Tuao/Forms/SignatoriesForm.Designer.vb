<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignatoriesForm
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
        pnlHeader = New Panel()
        lblTitle = New Label()
        lblSub = New Label()
        pnlDivider = New Panel()
        pnlBody = New Panel()
        grpSig1 = New GroupBox()
        lblSig1Label = New Label()
        txtSig1Label = New TextBox()
        lblSig1Name = New Label()
        txtSig1Name = New TextBox()
        lblSig1Title = New Label()
        txtSig1Title = New TextBox()
        grpSig2 = New GroupBox()
        lblSig2Label = New Label()
        txtSig2Label = New TextBox()
        lblSig2Name = New Label()
        txtSig2Name = New TextBox()
        lblSig2Title = New Label()
        txtSig2Title = New TextBox()
        grpSig3 = New GroupBox()
        chkSig3Enabled = New CheckBox()
        lblSig3Label = New Label()
        txtSig3Label = New TextBox()
        lblSig3Name = New Label()
        txtSig3Name = New TextBox()
        lblSig3Title = New Label()
        txtSig3Title = New TextBox()
        pnlFooter = New Panel()
        btnSave = New Button()
        btnCancel = New Button()
        pnlHeader.SuspendLayout()
        pnlBody.SuspendLayout()
        grpSig1.SuspendLayout()
        grpSig2.SuspendLayout()
        grpSig3.SuspendLayout()
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
        pnlHeader.Size = New Size(584, 75)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblTitle.Location = New Point(20, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(544, 28)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Report Signatories"
        ' 
        ' lblSub
        ' 
        lblSub.Font = New Font("Segoe UI", 9F)
        lblSub.ForeColor = Color.Gray
        lblSub.Location = New Point(20, 40)
        lblSub.Name = "lblSub"
        lblSub.Size = New Size(544, 20)
        lblSub.TabIndex = 1
        lblSub.Text = "Customize the official names, roles, and ranks printed on incident report forms."
        ' 
        ' pnlDivider
        ' 
        pnlDivider.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        pnlDivider.Dock = DockStyle.Bottom
        pnlDivider.Location = New Point(0, 72)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(584, 3)
        pnlDivider.TabIndex = 2
        ' 
        ' pnlBody
        ' 
        pnlBody.AutoScroll = True
        pnlBody.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        pnlBody.Controls.Add(grpSig1)
        pnlBody.Controls.Add(grpSig2)
        pnlBody.Controls.Add(grpSig3)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 75)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New Padding(20, 15, 20, 15)
        pnlBody.Size = New Size(584, 465)
        pnlBody.TabIndex = 1
        ' 
        ' grpSig1
        ' 
        grpSig1.BackColor = Color.White
        grpSig1.Controls.Add(lblSig1Label)
        grpSig1.Controls.Add(txtSig1Label)
        grpSig1.Controls.Add(lblSig1Name)
        grpSig1.Controls.Add(txtSig1Name)
        grpSig1.Controls.Add(lblSig1Title)
        grpSig1.Controls.Add(txtSig1Title)
        grpSig1.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        grpSig1.ForeColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        grpSig1.Location = New Point(20, 15)
        grpSig1.Name = "grpSig1"
        grpSig1.Size = New Size(544, 130)
        grpSig1.TabIndex = 0
        grpSig1.TabStop = False
        grpSig1.Text = " Signatory 1 (e.g. Prepared By) "
        ' 
        ' lblSig1Label
        ' 
        lblSig1Label.Font = New Font("Segoe UI", 8.5F)
        lblSig1Label.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblSig1Label.Location = New Point(15, 26)
        lblSig1Label.Name = "lblSig1Label"
        lblSig1Label.Size = New Size(140, 18)
        lblSig1Label.TabIndex = 0
        lblSig1Label.Text = "Header Label:"
        ' 
        ' txtSig1Label
        ' 
        txtSig1Label.Font = New Font("Segoe UI", 9F)
        txtSig1Label.Location = New Point(15, 46)
        txtSig1Label.Name = "txtSig1Label"
        txtSig1Label.Size = New Size(140, 23)
        txtSig1Label.TabIndex = 1
        ' 
        ' lblSig1Name
        ' 
        lblSig1Name.Font = New Font("Segoe UI", 8.5F)
        lblSig1Name.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblSig1Name.Location = New Point(170, 26)
        lblSig1Name.Name = "lblSig1Name"
        lblSig1Name.Size = New Size(355, 18)
        lblSig1Name.TabIndex = 2
        lblSig1Name.Text = "Full Name && Rank:"
        ' 
        ' txtSig1Name
        ' 
        txtSig1Name.Font = New Font("Segoe UI", 9F)
        txtSig1Name.Location = New Point(170, 46)
        txtSig1Name.Name = "txtSig1Name"
        txtSig1Name.Size = New Size(355, 23)
        txtSig1Name.TabIndex = 3
        ' 
        ' lblSig1Title
        ' 
        lblSig1Title.Font = New Font("Segoe UI", 8.5F)
        lblSig1Title.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblSig1Title.Location = New Point(15, 76)
        lblSig1Title.Name = "lblSig1Title"
        lblSig1Title.Size = New Size(510, 18)
        lblSig1Title.TabIndex = 4
        lblSig1Title.Text = "Official Designation / Title:"
        ' 
        ' txtSig1Title
        ' 
        txtSig1Title.Font = New Font("Segoe UI", 9F)
        txtSig1Title.Location = New Point(15, 96)
        txtSig1Title.Name = "txtSig1Title"
        txtSig1Title.Size = New Size(510, 23)
        txtSig1Title.TabIndex = 5
        ' 
        ' grpSig2
        ' 
        grpSig2.BackColor = Color.White
        grpSig2.Controls.Add(lblSig2Label)
        grpSig2.Controls.Add(txtSig2Label)
        grpSig2.Controls.Add(lblSig2Name)
        grpSig2.Controls.Add(txtSig2Name)
        grpSig2.Controls.Add(lblSig2Title)
        grpSig2.Controls.Add(txtSig2Title)
        grpSig2.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        grpSig2.ForeColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        grpSig2.Location = New Point(20, 155)
        grpSig2.Name = "grpSig2"
        grpSig2.Size = New Size(544, 130)
        grpSig2.TabIndex = 1
        grpSig2.TabStop = False
        grpSig2.Text = " Signatory 2 (e.g. Noted By / Station Commander) "
        ' 
        ' lblSig2Label
        ' 
        lblSig2Label.Font = New Font("Segoe UI", 8.5F)
        lblSig2Label.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblSig2Label.Location = New Point(15, 26)
        lblSig2Label.Name = "lblSig2Label"
        lblSig2Label.Size = New Size(140, 18)
        lblSig2Label.TabIndex = 0
        lblSig2Label.Text = "Header Label:"
        ' 
        ' txtSig2Label
        ' 
        txtSig2Label.Font = New Font("Segoe UI", 9F)
        txtSig2Label.Location = New Point(15, 46)
        txtSig2Label.Name = "txtSig2Label"
        txtSig2Label.Size = New Size(140, 23)
        txtSig2Label.TabIndex = 1
        ' 
        ' lblSig2Name
        ' 
        lblSig2Name.Font = New Font("Segoe UI", 8.5F)
        lblSig2Name.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblSig2Name.Location = New Point(170, 26)
        lblSig2Name.Name = "lblSig2Name"
        lblSig2Name.Size = New Size(355, 18)
        lblSig2Name.TabIndex = 2
        lblSig2Name.Text = "Full Name && Rank:"
        ' 
        ' txtSig2Name
        ' 
        txtSig2Name.Font = New Font("Segoe UI", 9F)
        txtSig2Name.Location = New Point(170, 46)
        txtSig2Name.Name = "txtSig2Name"
        txtSig2Name.Size = New Size(355, 23)
        txtSig2Name.TabIndex = 3
        ' 
        ' lblSig2Title
        ' 
        lblSig2Title.Font = New Font("Segoe UI", 8.5F)
        lblSig2Title.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblSig2Title.Location = New Point(15, 76)
        lblSig2Title.Name = "lblSig2Title"
        lblSig2Title.Size = New Size(510, 18)
        lblSig2Title.TabIndex = 4
        lblSig2Title.Text = "Official Designation / Title:"
        ' 
        ' txtSig2Title
        ' 
        txtSig2Title.Font = New Font("Segoe UI", 9F)
        txtSig2Title.Location = New Point(15, 96)
        txtSig2Title.Name = "txtSig2Title"
        txtSig2Title.Size = New Size(510, 23)
        txtSig2Title.TabIndex = 5
        ' 
        ' grpSig3
        ' 
        grpSig3.BackColor = Color.White
        grpSig3.Controls.Add(chkSig3Enabled)
        grpSig3.Controls.Add(lblSig3Label)
        grpSig3.Controls.Add(txtSig3Label)
        grpSig3.Controls.Add(lblSig3Name)
        grpSig3.Controls.Add(txtSig3Name)
        grpSig3.Controls.Add(lblSig3Title)
        grpSig3.Controls.Add(txtSig3Title)
        grpSig3.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        grpSig3.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        grpSig3.Location = New Point(20, 295)
        grpSig3.Name = "grpSig3"
        grpSig3.Size = New Size(544, 155)
        grpSig3.TabIndex = 2
        grpSig3.TabStop = False
        grpSig3.Text = " Signatory 3 (Optional / Additional) "
        ' 
        ' chkSig3Enabled
        ' 
        chkSig3Enabled.AutoSize = True
        chkSig3Enabled.Font = New Font("Segoe UI", 9F, FontStyle.Regular)
        chkSig3Enabled.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        chkSig3Enabled.Location = New Point(15, 25)
        chkSig3Enabled.Name = "chkSig3Enabled"
        chkSig3Enabled.Size = New Size(245, 19)
        chkSig3Enabled.TabIndex = 0
        chkSig3Enabled.Text = "Enable 3rd Signatory on Official Reports"
        chkSig3Enabled.UseVisualStyleBackColor = True
        ' 
        ' lblSig3Label
        ' 
        lblSig3Label.Font = New Font("Segoe UI", 8.5F)
        lblSig3Label.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblSig3Label.Location = New Point(15, 52)
        lblSig3Label.Name = "lblSig3Label"
        lblSig3Label.Size = New Size(140, 18)
        lblSig3Label.TabIndex = 1
        lblSig3Label.Text = "Header Label:"
        ' 
        ' txtSig3Label
        ' 
        txtSig3Label.Font = New Font("Segoe UI", 9F)
        txtSig3Label.Location = New Point(15, 72)
        txtSig3Label.Name = "txtSig3Label"
        txtSig3Label.Size = New Size(140, 23)
        txtSig3Label.TabIndex = 2
        ' 
        ' lblSig3Name
        ' 
        lblSig3Name.Font = New Font("Segoe UI", 8.5F)
        lblSig3Name.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblSig3Name.Location = New Point(170, 52)
        lblSig3Name.Name = "lblSig3Name"
        lblSig3Name.Size = New Size(355, 18)
        lblSig3Name.TabIndex = 3
        lblSig3Name.Text = "Full Name && Rank:"
        ' 
        ' txtSig3Name
        ' 
        txtSig3Name.Font = New Font("Segoe UI", 9F)
        txtSig3Name.Location = New Point(170, 72)
        txtSig3Name.Name = "txtSig3Name"
        txtSig3Name.Size = New Size(355, 23)
        txtSig3Name.TabIndex = 4
        ' 
        ' lblSig3Title
        ' 
        lblSig3Title.Font = New Font("Segoe UI", 8.5F)
        lblSig3Title.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblSig3Title.Location = New Point(15, 102)
        lblSig3Title.Name = "lblSig3Title"
        lblSig3Title.Size = New Size(510, 18)
        lblSig3Title.TabIndex = 5
        lblSig3Title.Text = "Official Designation / Title:"
        ' 
        ' txtSig3Title
        ' 
        txtSig3Title.Font = New Font("Segoe UI", 9F)
        txtSig3Title.Location = New Point(15, 122)
        txtSig3Title.Name = "txtSig3Title"
        txtSig3Title.Size = New Size(510, 23)
        txtSig3Title.TabIndex = 6
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.White
        pnlFooter.Controls.Add(btnSave)
        pnlFooter.Controls.Add(btnCancel)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 540)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(584, 55)
        pnlFooter.TabIndex = 2
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSave.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(434, 10)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(135, 34)
        btnSave.TabIndex = 0
        btnSave.Text = "Save Signatories"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCancel.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 9F)
        btnCancel.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnCancel.Location = New Point(334, 10)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(90, 34)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' SignatoriesForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(584, 595)
        Controls.Add(pnlBody)
        Controls.Add(pnlFooter)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "SignatoriesForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Configure Report Signatories"
        pnlHeader.ResumeLayout(False)
        pnlBody.ResumeLayout(False)
        grpSig1.ResumeLayout(False)
        grpSig1.PerformLayout()
        grpSig2.ResumeLayout(False)
        grpSig2.PerformLayout()
        grpSig3.ResumeLayout(False)
        grpSig3.PerformLayout()
        pnlFooter.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents pnlDivider As Panel
    Friend WithEvents pnlBody As Panel
    Friend WithEvents grpSig1 As GroupBox
    Friend WithEvents lblSig1Label As Label
    Friend WithEvents txtSig1Label As TextBox
    Friend WithEvents lblSig1Name As Label
    Friend WithEvents txtSig1Name As TextBox
    Friend WithEvents lblSig1Title As Label
    Friend WithEvents txtSig1Title As TextBox
    Friend WithEvents grpSig2 As GroupBox
    Friend WithEvents lblSig2Label As Label
    Friend WithEvents txtSig2Label As TextBox
    Friend WithEvents lblSig2Name As Label
    Friend WithEvents txtSig2Name As TextBox
    Friend WithEvents lblSig2Title As Label
    Friend WithEvents txtSig2Title As TextBox
    Friend WithEvents grpSig3 As GroupBox
    Friend WithEvents chkSig3Enabled As CheckBox
    Friend WithEvents lblSig3Label As Label
    Friend WithEvents txtSig3Label As TextBox
    Friend WithEvents lblSig3Name As Label
    Friend WithEvents txtSig3Name As TextBox
    Friend WithEvents lblSig3Title As Label
    Friend WithEvents txtSig3Title As TextBox
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button

End Class
