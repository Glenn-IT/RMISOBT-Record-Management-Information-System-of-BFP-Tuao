<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcAddRecord
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
        pnlFormCard = New Panel()
        lblPageTitle = New Label()
        lblPageSub = New Label()
        pnlDivider = New Panel()
        lblIncidentNo = New Label()
        txtIncidentNo = New TextBox()
        lblIncidentType = New Label()
        cboIncidentType = New ComboBox()
        lblDateReported = New Label()
        dtpDateReported = New DateTimePicker()
        lblStatus = New Label()
        cboStatus = New ComboBox()
        lblLocation = New Label()
        txtLocation = New TextBox()
        lblReportedBy = New Label()
        txtReportedBy = New TextBox()
        lblCasualties = New Label()
        txtCasualties = New TextBox()
        lblDamageEstimate = New Label()
        txtDamageEstimate = New TextBox()
        lblRemarks = New Label()
        txtRemarks = New TextBox()
        btnSave = New Button()
        btnClear = New Button()
        pnlFormCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlFormCard
        ' 
        pnlFormCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlFormCard.BackColor = Color.White
        pnlFormCard.Controls.Add(lblPageTitle)
        pnlFormCard.Controls.Add(lblPageSub)
        pnlFormCard.Controls.Add(pnlDivider)
        pnlFormCard.Controls.Add(lblIncidentNo)
        pnlFormCard.Controls.Add(txtIncidentNo)
        pnlFormCard.Controls.Add(lblIncidentType)
        pnlFormCard.Controls.Add(cboIncidentType)
        pnlFormCard.Controls.Add(lblDateReported)
        pnlFormCard.Controls.Add(dtpDateReported)
        pnlFormCard.Controls.Add(lblStatus)
        pnlFormCard.Controls.Add(cboStatus)
        pnlFormCard.Controls.Add(lblLocation)
        pnlFormCard.Controls.Add(txtLocation)
        pnlFormCard.Controls.Add(lblReportedBy)
        pnlFormCard.Controls.Add(txtReportedBy)
        pnlFormCard.Controls.Add(lblCasualties)
        pnlFormCard.Controls.Add(txtCasualties)
        pnlFormCard.Controls.Add(lblDamageEstimate)
        pnlFormCard.Controls.Add(txtDamageEstimate)
        pnlFormCard.Controls.Add(lblRemarks)
        pnlFormCard.Controls.Add(txtRemarks)
        pnlFormCard.Controls.Add(btnSave)
        pnlFormCard.Controls.Add(btnClear)
        pnlFormCard.Location = New Point(24, 18)
        pnlFormCard.Name = "pnlFormCard"
        pnlFormCard.Size = New Size(1072, 692)
        pnlFormCard.TabIndex = 0
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblPageTitle.Location = New Point(24, 18)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(600, 34)
        lblPageTitle.TabIndex = 0
        lblPageTitle.Text = "Add New Incident Record"
        ' 
        ' lblPageSub
        ' 
        lblPageSub.Font = New Font("Segoe UI", 9F)
        lblPageSub.ForeColor = Color.Gray
        lblPageSub.Location = New Point(24, 52)
        lblPageSub.Name = "lblPageSub"
        lblPageSub.Size = New Size(600, 22)
        lblPageSub.TabIndex = 1
        lblPageSub.Text = "Fill in all required fields (*) to add a new record."
        ' 
        ' pnlDivider
        ' 
        pnlDivider.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDivider.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        pnlDivider.Location = New Point(24, 80)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(1024, 3)
        pnlDivider.TabIndex = 2
        ' 
        ' lblIncidentNo
        ' 
        lblIncidentNo.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblIncidentNo.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblIncidentNo.Location = New Point(24, 100)
        lblIncidentNo.Name = "lblIncidentNo"
        lblIncidentNo.Size = New Size(390, 20)
        lblIncidentNo.TabIndex = 3
        lblIncidentNo.Text = "Incident No. *"
        ' 
        ' txtIncidentNo
        ' 
        txtIncidentNo.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtIncidentNo.BorderStyle = BorderStyle.FixedSingle
        txtIncidentNo.Font = New Font("Segoe UI", 10F)
        txtIncidentNo.Location = New Point(24, 122)
        txtIncidentNo.Name = "txtIncidentNo"
        txtIncidentNo.PlaceholderText = "e.g. INC-2025-001"
        txtIncidentNo.Size = New Size(390, 27)
        txtIncidentNo.TabIndex = 4
        ' 
        ' lblIncidentType
        ' 
        lblIncidentType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblIncidentType.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblIncidentType.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblIncidentType.Location = New Point(634, 100)
        lblIncidentType.Name = "lblIncidentType"
        lblIncidentType.Size = New Size(390, 20)
        lblIncidentType.TabIndex = 5
        lblIncidentType.Text = "Incident Type *"
        ' 
        ' cboIncidentType
        ' 
        cboIncidentType.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cboIncidentType.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        cboIncidentType.DropDownStyle = ComboBoxStyle.DropDownList
        cboIncidentType.FlatStyle = FlatStyle.Flat
        cboIncidentType.Font = New Font("Segoe UI", 10F)
        cboIncidentType.Location = New Point(634, 122)
        cboIncidentType.Name = "cboIncidentType"
        cboIncidentType.Size = New Size(390, 28)
        cboIncidentType.TabIndex = 6
        ' 
        ' lblDateReported
        ' 
        lblDateReported.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDateReported.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblDateReported.Location = New Point(24, 170)
        lblDateReported.Name = "lblDateReported"
        lblDateReported.Size = New Size(390, 20)
        lblDateReported.TabIndex = 7
        lblDateReported.Text = "Date Reported *"
        ' 
        ' dtpDateReported
        ' 
        dtpDateReported.Font = New Font("Segoe UI", 10F)
        dtpDateReported.Format = DateTimePickerFormat.Short
        dtpDateReported.Location = New Point(24, 192)
        dtpDateReported.Name = "dtpDateReported"
        dtpDateReported.Size = New Size(390, 27)
        dtpDateReported.TabIndex = 8
        ' 
        ' lblStatus
        ' 
        lblStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblStatus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblStatus.Location = New Point(634, 170)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(390, 20)
        lblStatus.TabIndex = 9
        lblStatus.Text = "Status *"
        ' 
        ' cboStatus
        ' 
        cboStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cboStatus.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.FlatStyle = FlatStyle.Flat
        cboStatus.Font = New Font("Segoe UI", 10F)
        cboStatus.Location = New Point(634, 192)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(390, 28)
        cboStatus.TabIndex = 10
        ' 
        ' lblLocation
        ' 
        lblLocation.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblLocation.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblLocation.Location = New Point(24, 240)
        lblLocation.Name = "lblLocation"
        lblLocation.Size = New Size(390, 20)
        lblLocation.TabIndex = 11
        lblLocation.Text = "Location / Address *"
        ' 
        ' txtLocation
        ' 
        txtLocation.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtLocation.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtLocation.BorderStyle = BorderStyle.FixedSingle
        txtLocation.Font = New Font("Segoe UI", 10F)
        txtLocation.Location = New Point(24, 262)
        txtLocation.Name = "txtLocation"
        txtLocation.PlaceholderText = "e.g. Brgy. Centro, Tuao, Cagayan"
        txtLocation.Size = New Size(1000, 27)
        txtLocation.TabIndex = 12
        ' 
        ' lblReportedBy
        ' 
        lblReportedBy.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblReportedBy.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblReportedBy.Location = New Point(24, 310)
        lblReportedBy.Name = "lblReportedBy"
        lblReportedBy.Size = New Size(390, 20)
        lblReportedBy.TabIndex = 13
        lblReportedBy.Text = "Reported By *"
        ' 
        ' txtReportedBy
        ' 
        txtReportedBy.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtReportedBy.BorderStyle = BorderStyle.FixedSingle
        txtReportedBy.Font = New Font("Segoe UI", 10F)
        txtReportedBy.Location = New Point(24, 332)
        txtReportedBy.Name = "txtReportedBy"
        txtReportedBy.PlaceholderText = "Full name of reporting officer"
        txtReportedBy.Size = New Size(390, 27)
        txtReportedBy.TabIndex = 14
        ' 
        ' lblCasualties
        ' 
        lblCasualties.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblCasualties.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCasualties.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblCasualties.Location = New Point(634, 310)
        lblCasualties.Name = "lblCasualties"
        lblCasualties.Size = New Size(390, 20)
        lblCasualties.TabIndex = 15
        lblCasualties.Text = "No. of Casualties"
        ' 
        ' txtCasualties
        ' 
        txtCasualties.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCasualties.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtCasualties.BorderStyle = BorderStyle.FixedSingle
        txtCasualties.Font = New Font("Segoe UI", 10F)
        txtCasualties.Location = New Point(634, 332)
        txtCasualties.Name = "txtCasualties"
        txtCasualties.PlaceholderText = "0"
        txtCasualties.Size = New Size(390, 27)
        txtCasualties.TabIndex = 16
        ' 
        ' lblDamageEstimate
        ' 
        lblDamageEstimate.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDamageEstimate.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblDamageEstimate.Location = New Point(24, 380)
        lblDamageEstimate.Name = "lblDamageEstimate"
        lblDamageEstimate.Size = New Size(390, 20)
        lblDamageEstimate.TabIndex = 17
        lblDamageEstimate.Text = "Estimated Damage (PHP)"
        ' 
        ' txtDamageEstimate
        ' 
        txtDamageEstimate.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtDamageEstimate.BorderStyle = BorderStyle.FixedSingle
        txtDamageEstimate.Font = New Font("Segoe UI", 10F)
        txtDamageEstimate.Location = New Point(24, 402)
        txtDamageEstimate.Name = "txtDamageEstimate"
        txtDamageEstimate.PlaceholderText = "e.g. 500000"
        txtDamageEstimate.Size = New Size(390, 27)
        txtDamageEstimate.TabIndex = 18
        ' 
        ' lblRemarks
        ' 
        lblRemarks.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblRemarks.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblRemarks.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblRemarks.Location = New Point(634, 380)
        lblRemarks.Name = "lblRemarks"
        lblRemarks.Size = New Size(390, 20)
        lblRemarks.TabIndex = 19
        lblRemarks.Text = "Remarks / Notes"
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtRemarks.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtRemarks.BorderStyle = BorderStyle.FixedSingle
        txtRemarks.Font = New Font("Segoe UI", 10F)
        txtRemarks.Location = New Point(634, 402)
        txtRemarks.Multiline = True
        txtRemarks.Name = "txtRemarks"
        txtRemarks.ScrollBars = ScrollBars.Vertical
        txtRemarks.Size = New Size(390, 62)
        txtRemarks.TabIndex = 20
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSave.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(24, 623)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(180, 40)
        btnSave.TabIndex = 21
        btnSave.Text = "SAVE RECORD"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnClear.BackColor = Color.White
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 10F)
        btnClear.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        btnClear.Location = New Point(216, 623)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(160, 40)
        btnClear.TabIndex = 22
        btnClear.Text = "CLEAR FORM"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' UcAddRecord
        ' 
        BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        Controls.Add(pnlFormCard)
        Name = "UcAddRecord"
        Size = New Size(1119, 731)
        pnlFormCard.ResumeLayout(False)
        pnlFormCard.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFormCard       As Panel
    Friend WithEvents pnlDivider        As Panel
    Friend WithEvents lblPageTitle      As Label
    Friend WithEvents lblPageSub        As Label
    Friend WithEvents lblIncidentNo     As Label
    Friend WithEvents txtIncidentNo     As TextBox
    Friend WithEvents lblIncidentType   As Label
    Friend WithEvents cboIncidentType   As ComboBox
    Friend WithEvents lblDateReported   As Label
    Friend WithEvents dtpDateReported   As DateTimePicker
    Friend WithEvents lblStatus         As Label
    Friend WithEvents cboStatus         As ComboBox
    Friend WithEvents lblLocation       As Label
    Friend WithEvents txtLocation       As TextBox
    Friend WithEvents lblReportedBy     As Label
    Friend WithEvents txtReportedBy     As TextBox
    Friend WithEvents lblCasualties     As Label
    Friend WithEvents txtCasualties     As TextBox
    Friend WithEvents lblDamageEstimate As Label
    Friend WithEvents txtDamageEstimate As TextBox
    Friend WithEvents lblRemarks        As Label
    Friend WithEvents txtRemarks        As TextBox
    Friend WithEvents btnSave           As Button
    Friend WithEvents btnClear          As Button

End Class
