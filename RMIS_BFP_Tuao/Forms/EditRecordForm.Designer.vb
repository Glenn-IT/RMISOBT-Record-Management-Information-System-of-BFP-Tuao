<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditRecordForm
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
        lblRecordID = New Label()
        txtRecordID = New TextBox()
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
        lblDamage = New Label()
        txtDamageEstimate = New TextBox()
        lblCauseOfFire = New Label()
        txtCauseOfFire = New TextBox()
        lblDocument = New Label()
        txtDocumentName = New TextBox()
        btnBrowseDocument = New Button()
        lblRemarks = New Label()
        txtRemarks = New TextBox()
        pnlFooter = New Panel()
        btnSave = New Button()
        btnCancel = New Button()
        pnlHeader.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlFooter.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(lblSub)
        pnlHeader.Controls.Add(pnlDivider)
        pnlHeader.Location = New Point(22, 18)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(981, 88)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblTitle.Location = New Point(18, 11)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(596, 33)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Edit Incident Record"
        ' 
        ' lblSub
        ' 
        lblSub.Font = New Font("Segoe UI", 9F)
        lblSub.ForeColor = Color.Gray
        lblSub.Location = New Point(18, 46)
        lblSub.Name = "lblSub"
        lblSub.Size = New Size(596, 22)
        lblSub.TabIndex = 1
        lblSub.Text = "Modify the fields below and click Save to update."
        ' 
        ' pnlDivider
        ' 
        pnlDivider.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        pnlDivider.Location = New Point(18, 77)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(605, 3)
        pnlDivider.TabIndex = 2
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Color.White
        pnlBody.Controls.Add(lblRecordID)
        pnlBody.Controls.Add(txtRecordID)
        pnlBody.Controls.Add(lblIncidentType)
        pnlBody.Controls.Add(cboIncidentType)
        pnlBody.Controls.Add(lblIncidentDateTime)
        pnlBody.Controls.Add(dtpIncidentDateTime)
        pnlBody.Controls.Add(lblAlarmLevel)
        pnlBody.Controls.Add(cboAlarmLevel)
        pnlBody.Controls.Add(lblResponseTime)
        pnlBody.Controls.Add(dtpResponseTime)
        pnlBody.Controls.Add(lblStatus)
        pnlBody.Controls.Add(cboStatus)
        pnlBody.Controls.Add(lblInvolvedProperty)
        pnlBody.Controls.Add(txtInvolvedProperty)
        pnlBody.Controls.Add(lblOwnerOccupant)
        pnlBody.Controls.Add(txtOwnerOccupant)
        pnlBody.Controls.Add(lblCallerInformation)
        pnlBody.Controls.Add(txtCallerInformation)
        pnlBody.Controls.Add(lblCasualties)
        pnlBody.Controls.Add(txtCasualties)
        pnlBody.Controls.Add(lblDamage)
        pnlBody.Controls.Add(txtDamageEstimate)
        pnlBody.Controls.Add(lblCauseOfFire)
        pnlBody.Controls.Add(txtCauseOfFire)
        pnlBody.Controls.Add(lblDocument)
        pnlBody.Controls.Add(txtDocumentName)
        pnlBody.Controls.Add(btnBrowseDocument)
        pnlBody.Controls.Add(lblRemarks)
        pnlBody.Controls.Add(txtRemarks)
        pnlBody.Location = New Point(22, 119)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(981, 556)
        pnlBody.TabIndex = 1
        ' 
        ' lblRecordID
        ' 
        lblRecordID.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblRecordID.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblRecordID.Location = New Point(18, 18)
        lblRecordID.Name = "lblRecordID"
        lblRecordID.Size = New Size(265, 24)
        lblRecordID.TabIndex = 0
        lblRecordID.Text = "Record ID *"
        ' 
        ' txtRecordID
        ' 
        txtRecordID.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        txtRecordID.BorderStyle = BorderStyle.FixedSingle
        txtRecordID.Font = New Font("Segoe UI", 10F)
        txtRecordID.Location = New Point(18, 42)
        txtRecordID.Name = "txtRecordID"
        txtRecordID.ReadOnly = True
        txtRecordID.Size = New Size(265, 27)
        txtRecordID.TabIndex = 1
        ' 
        ' lblIncidentType
        ' 
        lblIncidentType.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblIncidentType.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblIncidentType.Location = New Point(349, 18)
        lblIncidentType.Name = "lblIncidentType"
        lblIncidentType.Size = New Size(265, 24)
        lblIncidentType.TabIndex = 2
        lblIncidentType.Text = "Incident Type *"
        ' 
        ' cboIncidentType
        ' 
        cboIncidentType.DropDownStyle = ComboBoxStyle.DropDownList
        cboIncidentType.FlatStyle = FlatStyle.Flat
        cboIncidentType.Font = New Font("Segoe UI", 10F)
        cboIncidentType.Location = New Point(349, 42)
        cboIncidentType.Name = "cboIncidentType"
        cboIncidentType.Size = New Size(265, 28)
        cboIncidentType.TabIndex = 3
        ' 
        ' lblIncidentDateTime
        ' 
        lblIncidentDateTime.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblIncidentDateTime.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblIncidentDateTime.Location = New Point(18, 91)
        lblIncidentDateTime.Name = "lblIncidentDateTime"
        lblIncidentDateTime.Size = New Size(265, 24)
        lblIncidentDateTime.TabIndex = 4
        lblIncidentDateTime.Text = "Incident Date && Time *"
        ' 
        ' dtpIncidentDateTime
        ' 
        dtpIncidentDateTime.CustomFormat = "MM/dd/yyyy HHmm"
        dtpIncidentDateTime.Font = New Font("Segoe UI", 10F)
        dtpIncidentDateTime.Format = DateTimePickerFormat.Custom
        dtpIncidentDateTime.Location = New Point(18, 115)
        dtpIncidentDateTime.Name = "dtpIncidentDateTime"
        dtpIncidentDateTime.Size = New Size(265, 27)
        dtpIncidentDateTime.TabIndex = 5
        ' 
        ' lblAlarmLevel
        ' 
        lblAlarmLevel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblAlarmLevel.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblAlarmLevel.Location = New Point(349, 91)
        lblAlarmLevel.Name = "lblAlarmLevel"
        lblAlarmLevel.Size = New Size(265, 24)
        lblAlarmLevel.TabIndex = 6
        lblAlarmLevel.Text = "Alarm Level *"
        ' 
        ' cboAlarmLevel
        ' 
        cboAlarmLevel.DropDownStyle = ComboBoxStyle.DropDownList
        cboAlarmLevel.FlatStyle = FlatStyle.Flat
        cboAlarmLevel.Font = New Font("Segoe UI", 10F)
        cboAlarmLevel.Location = New Point(349, 115)
        cboAlarmLevel.Name = "cboAlarmLevel"
        cboAlarmLevel.Size = New Size(265, 28)
        cboAlarmLevel.TabIndex = 7
        ' 
        ' lblResponseTime
        ' 
        lblResponseTime.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblResponseTime.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblResponseTime.Location = New Point(18, 163)
        lblResponseTime.Name = "lblResponseTime"
        lblResponseTime.Size = New Size(265, 24)
        lblResponseTime.TabIndex = 8
        lblResponseTime.Text = "Response Time"
        ' 
        ' dtpResponseTime
        ' 
        dtpResponseTime.CustomFormat = "HHmm"
        dtpResponseTime.Font = New Font("Segoe UI", 10F)
        dtpResponseTime.Format = DateTimePickerFormat.Custom
        dtpResponseTime.Location = New Point(18, 188)
        dtpResponseTime.Name = "dtpResponseTime"
        dtpResponseTime.ShowCheckBox = True
        dtpResponseTime.ShowUpDown = True
        dtpResponseTime.Size = New Size(265, 27)
        dtpResponseTime.TabIndex = 9
        ' 
        ' lblStatus
        ' 
        lblStatus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblStatus.Location = New Point(349, 163)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(265, 24)
        lblStatus.TabIndex = 10
        lblStatus.Text = "Status *"
        ' 
        ' cboStatus
        ' 
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.FlatStyle = FlatStyle.Flat
        cboStatus.Font = New Font("Segoe UI", 10F)
        cboStatus.Location = New Point(349, 188)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(265, 28)
        cboStatus.TabIndex = 11
        ' 
        ' lblInvolvedProperty
        ' 
        lblInvolvedProperty.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblInvolvedProperty.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblInvolvedProperty.Location = New Point(627, 18)
        lblInvolvedProperty.Name = "lblInvolvedProperty"
        lblInvolvedProperty.Size = New Size(318, 24)
        lblInvolvedProperty.TabIndex = 12
        lblInvolvedProperty.Text = "Involved Building / Establishment / Vehicle *"
        ' 
        ' txtInvolvedProperty
        ' 
        txtInvolvedProperty.BorderStyle = BorderStyle.FixedSingle
        txtInvolvedProperty.Font = New Font("Segoe UI", 10F)
        txtInvolvedProperty.Location = New Point(627, 45)
        txtInvolvedProperty.Multiline = True
        txtInvolvedProperty.Name = "txtInvolvedProperty"
        txtInvolvedProperty.Size = New Size(340, 170)
        txtInvolvedProperty.TabIndex = 13
        ' 
        ' lblOwnerOccupant
        ' 
        lblOwnerOccupant.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblOwnerOccupant.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblOwnerOccupant.Location = New Point(18, 229)
        lblOwnerOccupant.Name = "lblOwnerOccupant"
        lblOwnerOccupant.Size = New Size(265, 24)
        lblOwnerOccupant.TabIndex = 14
        lblOwnerOccupant.Text = "Name of Owner / Occupant"
        ' 
        ' txtOwnerOccupant
        ' 
        txtOwnerOccupant.BorderStyle = BorderStyle.FixedSingle
        txtOwnerOccupant.Font = New Font("Segoe UI", 10F)
        txtOwnerOccupant.Location = New Point(18, 253)
        txtOwnerOccupant.Name = "txtOwnerOccupant"
        txtOwnerOccupant.Size = New Size(265, 27)
        txtOwnerOccupant.TabIndex = 15
        ' 
        ' lblCallerInformation
        ' 
        lblCallerInformation.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCallerInformation.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblCallerInformation.Location = New Point(349, 229)
        lblCallerInformation.Name = "lblCallerInformation"
        lblCallerInformation.Size = New Size(265, 24)
        lblCallerInformation.TabIndex = 16
        lblCallerInformation.Text = "Caller Information *"
        ' 
        ' txtCallerInformation
        ' 
        txtCallerInformation.BorderStyle = BorderStyle.FixedSingle
        txtCallerInformation.Font = New Font("Segoe UI", 10F)
        txtCallerInformation.Location = New Point(349, 253)
        txtCallerInformation.Name = "txtCallerInformation"
        txtCallerInformation.Size = New Size(265, 27)
        txtCallerInformation.TabIndex = 17
        ' 
        ' lblCasualties
        ' 
        lblCasualties.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCasualties.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblCasualties.Location = New Point(18, 302)
        lblCasualties.Name = "lblCasualties"
        lblCasualties.Size = New Size(265, 24)
        lblCasualties.TabIndex = 18
        lblCasualties.Text = "Casualties"
        ' 
        ' txtCasualties
        ' 
        txtCasualties.BorderStyle = BorderStyle.FixedSingle
        txtCasualties.Font = New Font("Segoe UI", 10F)
        txtCasualties.Location = New Point(18, 326)
        txtCasualties.Name = "txtCasualties"
        txtCasualties.Size = New Size(265, 27)
        txtCasualties.TabIndex = 19
        ' 
        ' lblDamage
        ' 
        lblDamage.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDamage.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblDamage.Location = New Point(349, 302)
        lblDamage.Name = "lblDamage"
        lblDamage.Size = New Size(265, 24)
        lblDamage.TabIndex = 20
        lblDamage.Text = "Damage Estimate (PHP)"
        ' 
        ' txtDamageEstimate
        ' 
        txtDamageEstimate.BorderStyle = BorderStyle.FixedSingle
        txtDamageEstimate.Font = New Font("Segoe UI", 10F)
        txtDamageEstimate.Location = New Point(349, 326)
        txtDamageEstimate.Name = "txtDamageEstimate"
        txtDamageEstimate.Size = New Size(265, 27)
        txtDamageEstimate.TabIndex = 21
        ' 
        ' lblCauseOfFire
        ' 
        lblCauseOfFire.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCauseOfFire.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblCauseOfFire.Location = New Point(627, 229)
        lblCauseOfFire.Name = "lblCauseOfFire"
        lblCauseOfFire.Size = New Size(132, 24)
        lblCauseOfFire.TabIndex = 22
        lblCauseOfFire.Text = "Cause of Fire"
        ' 
        ' txtCauseOfFire
        ' 
        txtCauseOfFire.BorderStyle = BorderStyle.FixedSingle
        txtCauseOfFire.Font = New Font("Segoe UI", 10F)
        txtCauseOfFire.Location = New Point(627, 256)
        txtCauseOfFire.Multiline = True
        txtCauseOfFire.Name = "txtCauseOfFire"
        txtCauseOfFire.Size = New Size(340, 97)
        txtCauseOfFire.TabIndex = 23
        ' 
        ' lblDocument
        ' 
        lblDocument.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDocument.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblDocument.Location = New Point(18, 370)
        lblDocument.Name = "lblDocument"
        lblDocument.Size = New Size(596, 24)
        lblDocument.TabIndex = 24
        lblDocument.Text = "Attached Document *"
        ' 
        ' txtDocumentName
        ' 
        txtDocumentName.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        txtDocumentName.BorderStyle = BorderStyle.FixedSingle
        txtDocumentName.Font = New Font("Segoe UI", 10F)
        txtDocumentName.Location = New Point(18, 394)
        txtDocumentName.Name = "txtDocumentName"
        txtDocumentName.PlaceholderText = "No document selected."
        txtDocumentName.ReadOnly = True
        txtDocumentName.Size = New Size(441, 27)
        txtDocumentName.TabIndex = 25
        ' 
        ' btnBrowseDocument
        ' 
        btnBrowseDocument.BackColor = Color.FromArgb(CByte(30), CByte(100), CByte(180))
        btnBrowseDocument.Cursor = Cursors.Hand
        btnBrowseDocument.FlatAppearance.BorderSize = 0
        btnBrowseDocument.FlatStyle = FlatStyle.Flat
        btnBrowseDocument.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnBrowseDocument.ForeColor = Color.White
        btnBrowseDocument.Location = New Point(468, 394)
        btnBrowseDocument.Name = "btnBrowseDocument"
        btnBrowseDocument.Size = New Size(155, 27)
        btnBrowseDocument.TabIndex = 26
        btnBrowseDocument.Text = "Browse..."
        btnBrowseDocument.UseVisualStyleBackColor = False
        ' 
        ' lblRemarks
        ' 
        lblRemarks.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblRemarks.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblRemarks.Location = New Point(18, 439)
        lblRemarks.Name = "lblRemarks"
        lblRemarks.Size = New Size(596, 24)
        lblRemarks.TabIndex = 27
        lblRemarks.Text = "Remarks"
        ' 
        ' txtRemarks
        ' 
        txtRemarks.BorderStyle = BorderStyle.FixedSingle
        txtRemarks.Font = New Font("Segoe UI", 10F)
        txtRemarks.Location = New Point(18, 463)
        txtRemarks.Multiline = True
        txtRemarks.Name = "txtRemarks"
        txtRemarks.ScrollBars = ScrollBars.Vertical
        txtRemarks.Size = New Size(596, 70)
        txtRemarks.TabIndex = 28
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.White
        pnlFooter.Controls.Add(btnSave)
        pnlFooter.Controls.Add(btnCancel)
        pnlFooter.Location = New Point(22, 681)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(981, 57)
        pnlFooter.TabIndex = 2
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSave.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(687, 9)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(155, 40)
        btnSave.TabIndex = 0
        btnSave.Text = "Save Changes"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCancel.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10F)
        btnCancel.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnCancel.Location = New Point(857, 9)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(110, 40)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' EditRecordForm
        ' 
        AutoScaleDimensions = New SizeF(106F, 106F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        ClientSize = New Size(1015, 753)
        Controls.Add(pnlHeader)
        Controls.Add(pnlBody)
        Controls.Add(pnlFooter)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "EditRecordForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Edit Incident Record"
        pnlHeader.ResumeLayout(False)
        pnlBody.ResumeLayout(False)
        pnlBody.PerformLayout()
        pnlFooter.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    ' ── Control Declarations ─────────────────────────────────────
    Friend WithEvents pnlHeader             As Panel
    Friend WithEvents pnlBody               As Panel
    Friend WithEvents pnlFooter             As Panel
    Friend WithEvents pnlDivider             As Panel
    Friend WithEvents lblTitle              As Label
    Friend WithEvents lblSub                As Label
    Friend WithEvents lblRecordID           As Label
    Friend WithEvents txtRecordID           As TextBox
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
    Friend WithEvents lblDamage             As Label
    Friend WithEvents txtDamageEstimate     As TextBox
    Friend WithEvents lblCauseOfFire        As Label
    Friend WithEvents txtCauseOfFire        As TextBox
    Friend WithEvents lblDocument           As Label
    Friend WithEvents txtDocumentName       As TextBox
    Friend WithEvents btnBrowseDocument     As Button
    Friend WithEvents lblRemarks            As Label
    Friend WithEvents txtRemarks            As TextBox
    Friend WithEvents btnSave               As Button
    Friend WithEvents btnCancel             As Button

End Class
