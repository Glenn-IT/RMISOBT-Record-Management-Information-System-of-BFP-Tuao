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
        lblIncidentDateTime = New Label()
        dtpIncidentDateTime = New DateTimePicker()
        lblAlarmLevel = New Label()
        cboAlarmLevel = New ComboBox()
        lblResponseTime = New Label()
        dtpResponseTime = New DateTimePicker()
        lblStatus = New Label()
        cboStatus = New ComboBox()
        lblInvolvedProperty = New Label()
        txtInvolvedProperty = New TextBox()
        lblOwnerOccupant = New Label()
        txtOwnerOccupant = New TextBox()
        lblCallerInformation = New Label()
        txtCallerInformation = New TextBox()
        lblCasualties = New Label()
        txtCasualties = New TextBox()
        lblDamageEstimate = New Label()
        txtDamageEstimate = New TextBox()
        lblCauseOfFire = New Label()
        txtCauseOfFire = New TextBox()
        lblRemarks = New Label()
        txtRemarks = New TextBox()
        lblDocument = New Label()
        txtDocumentName = New TextBox()
        btnBrowseDocument = New Button()
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
        pnlFormCard.Controls.Add(lblIncidentDateTime)
        pnlFormCard.Controls.Add(dtpIncidentDateTime)
        pnlFormCard.Controls.Add(lblAlarmLevel)
        pnlFormCard.Controls.Add(cboAlarmLevel)
        pnlFormCard.Controls.Add(lblResponseTime)
        pnlFormCard.Controls.Add(dtpResponseTime)
        pnlFormCard.Controls.Add(lblStatus)
        pnlFormCard.Controls.Add(cboStatus)
        pnlFormCard.Controls.Add(lblInvolvedProperty)
        pnlFormCard.Controls.Add(txtInvolvedProperty)
        pnlFormCard.Controls.Add(lblOwnerOccupant)
        pnlFormCard.Controls.Add(txtOwnerOccupant)
        pnlFormCard.Controls.Add(lblCallerInformation)
        pnlFormCard.Controls.Add(txtCallerInformation)
        pnlFormCard.Controls.Add(lblCasualties)
        pnlFormCard.Controls.Add(txtCasualties)
        pnlFormCard.Controls.Add(lblDamageEstimate)
        pnlFormCard.Controls.Add(txtDamageEstimate)
        pnlFormCard.Controls.Add(lblCauseOfFire)
        pnlFormCard.Controls.Add(txtCauseOfFire)
        pnlFormCard.Controls.Add(lblRemarks)
        pnlFormCard.Controls.Add(txtRemarks)
        pnlFormCard.Controls.Add(lblDocument)
        pnlFormCard.Controls.Add(txtDocumentName)
        pnlFormCard.Controls.Add(btnBrowseDocument)
        pnlFormCard.Controls.Add(btnSave)
        pnlFormCard.Controls.Add(btnClear)
        pnlFormCard.Location = New Point(24, 18)
        pnlFormCard.Name = "pnlFormCard"
        pnlFormCard.Size = New Size(1072, 832)
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
        ' lblIncidentDateTime
        '
        lblIncidentDateTime.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblIncidentDateTime.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblIncidentDateTime.Location = New Point(24, 170)
        lblIncidentDateTime.Name = "lblIncidentDateTime"
        lblIncidentDateTime.Size = New Size(390, 20)
        lblIncidentDateTime.TabIndex = 7
        lblIncidentDateTime.Text = "Incident Date && Time *"
        '
        ' dtpIncidentDateTime
        '
        dtpIncidentDateTime.CustomFormat = "MM/dd/yyyy HHmm"
        dtpIncidentDateTime.Font = New Font("Segoe UI", 10F)
        dtpIncidentDateTime.Format = DateTimePickerFormat.Custom
        dtpIncidentDateTime.Location = New Point(24, 192)
        dtpIncidentDateTime.Name = "dtpIncidentDateTime"
        dtpIncidentDateTime.Size = New Size(390, 27)
        dtpIncidentDateTime.TabIndex = 8
        '
        ' lblAlarmLevel
        '
        lblAlarmLevel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblAlarmLevel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblAlarmLevel.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblAlarmLevel.Location = New Point(634, 170)
        lblAlarmLevel.Name = "lblAlarmLevel"
        lblAlarmLevel.Size = New Size(390, 20)
        lblAlarmLevel.TabIndex = 9
        lblAlarmLevel.Text = "Alarm Level *"
        '
        ' cboAlarmLevel
        '
        cboAlarmLevel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cboAlarmLevel.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        cboAlarmLevel.DropDownStyle = ComboBoxStyle.DropDownList
        cboAlarmLevel.FlatStyle = FlatStyle.Flat
        cboAlarmLevel.Font = New Font("Segoe UI", 10F)
        cboAlarmLevel.Location = New Point(634, 192)
        cboAlarmLevel.Name = "cboAlarmLevel"
        cboAlarmLevel.Size = New Size(390, 28)
        cboAlarmLevel.TabIndex = 10
        '
        ' lblResponseTime
        '
        lblResponseTime.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblResponseTime.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblResponseTime.Location = New Point(24, 240)
        lblResponseTime.Name = "lblResponseTime"
        lblResponseTime.Size = New Size(390, 20)
        lblResponseTime.TabIndex = 11
        lblResponseTime.Text = "Response Time"
        '
        ' dtpResponseTime
        '
        dtpResponseTime.CustomFormat = "HHmm"
        dtpResponseTime.Font = New Font("Segoe UI", 10F)
        dtpResponseTime.Format = DateTimePickerFormat.Custom
        dtpResponseTime.Location = New Point(24, 262)
        dtpResponseTime.Name = "dtpResponseTime"
        dtpResponseTime.ShowCheckBox = True
        dtpResponseTime.ShowUpDown = True
        dtpResponseTime.Size = New Size(390, 27)
        dtpResponseTime.TabIndex = 12
        '
        ' lblStatus
        '
        lblStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblStatus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblStatus.Location = New Point(634, 240)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(390, 20)
        lblStatus.TabIndex = 13
        lblStatus.Text = "Status *"
        '
        ' cboStatus
        '
        cboStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cboStatus.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.FlatStyle = FlatStyle.Flat
        cboStatus.Font = New Font("Segoe UI", 10F)
        cboStatus.Location = New Point(634, 262)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(390, 28)
        cboStatus.TabIndex = 14
        '
        ' lblInvolvedProperty
        '
        lblInvolvedProperty.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblInvolvedProperty.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblInvolvedProperty.Location = New Point(24, 310)
        lblInvolvedProperty.Name = "lblInvolvedProperty"
        lblInvolvedProperty.Size = New Size(600, 20)
        lblInvolvedProperty.TabIndex = 15
        lblInvolvedProperty.Text = "Involved Building / Establishment / Vehicle *"
        '
        ' txtInvolvedProperty
        '
        txtInvolvedProperty.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtInvolvedProperty.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtInvolvedProperty.BorderStyle = BorderStyle.FixedSingle
        txtInvolvedProperty.Font = New Font("Segoe UI", 10F)
        txtInvolvedProperty.Location = New Point(24, 332)
        txtInvolvedProperty.Name = "txtInvolvedProperty"
        txtInvolvedProperty.PlaceholderText = "e.g. Dela Cruz Residence, Brgy. Centro, Tuao, Cagayan"
        txtInvolvedProperty.Size = New Size(1000, 27)
        txtInvolvedProperty.TabIndex = 16
        '
        ' lblOwnerOccupant
        '
        lblOwnerOccupant.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblOwnerOccupant.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblOwnerOccupant.Location = New Point(24, 380)
        lblOwnerOccupant.Name = "lblOwnerOccupant"
        lblOwnerOccupant.Size = New Size(390, 20)
        lblOwnerOccupant.TabIndex = 17
        lblOwnerOccupant.Text = "Name of Owner / Occupant"
        '
        ' txtOwnerOccupant
        '
        txtOwnerOccupant.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtOwnerOccupant.BorderStyle = BorderStyle.FixedSingle
        txtOwnerOccupant.Font = New Font("Segoe UI", 10F)
        txtOwnerOccupant.Location = New Point(24, 402)
        txtOwnerOccupant.Name = "txtOwnerOccupant"
        txtOwnerOccupant.PlaceholderText = "Full name of owner or occupant"
        txtOwnerOccupant.Size = New Size(390, 27)
        txtOwnerOccupant.TabIndex = 18
        '
        ' lblCallerInformation
        '
        lblCallerInformation.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblCallerInformation.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCallerInformation.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblCallerInformation.Location = New Point(634, 380)
        lblCallerInformation.Name = "lblCallerInformation"
        lblCallerInformation.Size = New Size(390, 20)
        lblCallerInformation.TabIndex = 19
        lblCallerInformation.Text = "Caller Information *"
        '
        ' txtCallerInformation
        '
        txtCallerInformation.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtCallerInformation.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtCallerInformation.BorderStyle = BorderStyle.FixedSingle
        txtCallerInformation.Font = New Font("Segoe UI", 10F)
        txtCallerInformation.Location = New Point(634, 402)
        txtCallerInformation.Name = "txtCallerInformation"
        txtCallerInformation.PlaceholderText = "Name / contact of person who called it in"
        txtCallerInformation.Size = New Size(390, 27)
        txtCallerInformation.TabIndex = 20
        '
        ' lblCasualties
        '
        lblCasualties.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCasualties.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblCasualties.Location = New Point(24, 450)
        lblCasualties.Name = "lblCasualties"
        lblCasualties.Size = New Size(390, 20)
        lblCasualties.TabIndex = 21
        lblCasualties.Text = "No. of Casualties"
        '
        ' txtCasualties
        '
        txtCasualties.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtCasualties.BorderStyle = BorderStyle.FixedSingle
        txtCasualties.Font = New Font("Segoe UI", 10F)
        txtCasualties.Location = New Point(24, 472)
        txtCasualties.Name = "txtCasualties"
        txtCasualties.PlaceholderText = "0"
        txtCasualties.Size = New Size(390, 27)
        txtCasualties.TabIndex = 22
        '
        ' lblDamageEstimate
        '
        lblDamageEstimate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDamageEstimate.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDamageEstimate.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblDamageEstimate.Location = New Point(634, 450)
        lblDamageEstimate.Name = "lblDamageEstimate"
        lblDamageEstimate.Size = New Size(390, 20)
        lblDamageEstimate.TabIndex = 23
        lblDamageEstimate.Text = "Estimated Damage (PHP)"
        '
        ' txtDamageEstimate
        '
        txtDamageEstimate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtDamageEstimate.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtDamageEstimate.BorderStyle = BorderStyle.FixedSingle
        txtDamageEstimate.Font = New Font("Segoe UI", 10F)
        txtDamageEstimate.Location = New Point(634, 472)
        txtDamageEstimate.Name = "txtDamageEstimate"
        txtDamageEstimate.PlaceholderText = "e.g. 500000"
        txtDamageEstimate.Size = New Size(390, 27)
        txtDamageEstimate.TabIndex = 24
        '
        ' lblCauseOfFire
        '
        lblCauseOfFire.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCauseOfFire.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblCauseOfFire.Location = New Point(24, 520)
        lblCauseOfFire.Name = "lblCauseOfFire"
        lblCauseOfFire.Size = New Size(390, 20)
        lblCauseOfFire.TabIndex = 25
        lblCauseOfFire.Text = "Cause of Fire"
        '
        ' txtCauseOfFire
        '
        txtCauseOfFire.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtCauseOfFire.BorderStyle = BorderStyle.FixedSingle
        txtCauseOfFire.Font = New Font("Segoe UI", 10F)
        txtCauseOfFire.Location = New Point(24, 542)
        txtCauseOfFire.Name = "txtCauseOfFire"
        txtCauseOfFire.PlaceholderText = "e.g. Electrical short circuit"
        txtCauseOfFire.Size = New Size(390, 27)
        txtCauseOfFire.TabIndex = 26
        '
        ' lblRemarks
        '
        lblRemarks.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblRemarks.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblRemarks.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblRemarks.Location = New Point(634, 520)
        lblRemarks.Name = "lblRemarks"
        lblRemarks.Size = New Size(390, 20)
        lblRemarks.TabIndex = 27
        lblRemarks.Text = "Remarks / Notes"
        '
        ' txtRemarks
        '
        txtRemarks.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtRemarks.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtRemarks.BorderStyle = BorderStyle.FixedSingle
        txtRemarks.Font = New Font("Segoe UI", 10F)
        txtRemarks.Location = New Point(634, 542)
        txtRemarks.Multiline = True
        txtRemarks.Name = "txtRemarks"
        txtRemarks.ScrollBars = ScrollBars.Vertical
        txtRemarks.Size = New Size(390, 62)
        txtRemarks.TabIndex = 28
        '
        ' lblDocument
        '
        lblDocument.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDocument.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblDocument.Location = New Point(24, 620)
        lblDocument.Name = "lblDocument"
        lblDocument.Size = New Size(390, 20)
        lblDocument.TabIndex = 29
        lblDocument.Text = "Attached Document *"
        '
        ' txtDocumentName
        '
        txtDocumentName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDocumentName.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        txtDocumentName.BorderStyle = BorderStyle.FixedSingle
        txtDocumentName.Font = New Font("Segoe UI", 10F)
        txtDocumentName.Location = New Point(24, 642)
        txtDocumentName.Name = "txtDocumentName"
        txtDocumentName.PlaceholderText = "No document selected."
        txtDocumentName.ReadOnly = True
        txtDocumentName.Size = New Size(860, 27)
        txtDocumentName.TabIndex = 30
        '
        ' btnBrowseDocument
        '
        btnBrowseDocument.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBrowseDocument.BackColor = Color.FromArgb(CByte(30), CByte(100), CByte(180))
        btnBrowseDocument.Cursor = Cursors.Hand
        btnBrowseDocument.FlatAppearance.BorderSize = 0
        btnBrowseDocument.FlatStyle = FlatStyle.Flat
        btnBrowseDocument.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnBrowseDocument.ForeColor = Color.White
        btnBrowseDocument.Location = New Point(894, 641)
        btnBrowseDocument.Name = "btnBrowseDocument"
        btnBrowseDocument.Size = New Size(130, 29)
        btnBrowseDocument.TabIndex = 31
        btnBrowseDocument.Text = "Browse..."
        btnBrowseDocument.UseVisualStyleBackColor = False
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
        btnSave.Location = New Point(24, 763)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(180, 40)
        btnSave.TabIndex = 32
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
        btnClear.Location = New Point(216, 763)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(160, 40)
        btnClear.TabIndex = 33
        btnClear.Text = "CLEAR FORM"
        btnClear.UseVisualStyleBackColor = False
        '
        ' UcAddRecord
        '
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        Controls.Add(pnlFormCard)
        Font = New Font("Segoe UI", 9F)
        AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        Name = "UcAddRecord"
        Size = New Size(1119, 871)
        pnlFormCard.ResumeLayout(False)
        pnlFormCard.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFormCard           As Panel
    Friend WithEvents pnlDivider            As Panel
    Friend WithEvents lblPageTitle          As Label
    Friend WithEvents lblPageSub            As Label
    Friend WithEvents lblIncidentNo         As Label
    Friend WithEvents txtIncidentNo         As TextBox
    Friend WithEvents lblIncidentType       As Label
    Friend WithEvents cboIncidentType       As ComboBox
    Friend WithEvents lblIncidentDateTime   As Label
    Friend WithEvents dtpIncidentDateTime   As DateTimePicker
    Friend WithEvents lblAlarmLevel         As Label
    Friend WithEvents cboAlarmLevel         As ComboBox
    Friend WithEvents lblResponseTime       As Label
    Friend WithEvents dtpResponseTime       As DateTimePicker
    Friend WithEvents lblStatus             As Label
    Friend WithEvents cboStatus             As ComboBox
    Friend WithEvents lblInvolvedProperty   As Label
    Friend WithEvents txtInvolvedProperty   As TextBox
    Friend WithEvents lblOwnerOccupant      As Label
    Friend WithEvents txtOwnerOccupant      As TextBox
    Friend WithEvents lblCallerInformation  As Label
    Friend WithEvents txtCallerInformation  As TextBox
    Friend WithEvents lblCasualties         As Label
    Friend WithEvents txtCasualties         As TextBox
    Friend WithEvents lblDamageEstimate     As Label
    Friend WithEvents txtDamageEstimate     As TextBox
    Friend WithEvents lblCauseOfFire        As Label
    Friend WithEvents txtCauseOfFire        As TextBox
    Friend WithEvents lblRemarks            As Label
    Friend WithEvents txtRemarks            As TextBox
    Friend WithEvents lblDocument           As Label
    Friend WithEvents txtDocumentName       As TextBox
    Friend WithEvents btnBrowseDocument     As Button
    Friend WithEvents btnSave               As Button
    Friend WithEvents btnClear              As Button

End Class
