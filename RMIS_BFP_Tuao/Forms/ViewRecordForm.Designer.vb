<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewRecordForm
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
        txtIncidentType = New TextBox()
        lblIncidentDateTime = New Label()
        txtIncidentDateTime = New TextBox()
        lblAlarmLevel = New Label()
        txtAlarmLevel = New TextBox()
        lblResponseTime = New Label()
        txtResponseTime = New TextBox()
        lblStatus = New Label()
        txtStatus = New TextBox()
        lblInvolvedProperty = New Label()
        txtInvolvedProperty = New TextBox()
        lblAddress = New Label()
        txtAddress = New TextBox()
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
        btnOpenDocument = New Button()
        lblRemarks = New Label()
        txtRemarks = New TextBox()
        pnlFooter = New Panel()
        btnClose = New Button()
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
        lblTitle.Text = "Incident Record Details"
        ' 
        ' lblSub
        ' 
        lblSub.Font = New Font("Segoe UI", 9F)
        lblSub.ForeColor = Color.Gray
        lblSub.Location = New Point(18, 46)
        lblSub.Name = "lblSub"
        lblSub.Size = New Size(596, 22)
        lblSub.TabIndex = 1
        lblSub.Text = "Read-only view of the selected incident record."
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
        pnlBody.Controls.Add(txtIncidentType)
        pnlBody.Controls.Add(lblIncidentDateTime)
        pnlBody.Controls.Add(txtIncidentDateTime)
        pnlBody.Controls.Add(lblAlarmLevel)
        pnlBody.Controls.Add(txtAlarmLevel)
        pnlBody.Controls.Add(lblResponseTime)
        pnlBody.Controls.Add(txtResponseTime)
        pnlBody.Controls.Add(lblStatus)
        pnlBody.Controls.Add(txtStatus)
        pnlBody.Controls.Add(lblInvolvedProperty)
        pnlBody.Controls.Add(txtInvolvedProperty)
        pnlBody.Controls.Add(lblAddress)
        pnlBody.Controls.Add(txtAddress)
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
        pnlBody.Controls.Add(btnOpenDocument)
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
        lblRecordID.Text = "Record ID"
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
        lblIncidentType.Text = "Incident Type"
        ' 
        ' txtIncidentType
        ' 
        txtIncidentType.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        txtIncidentType.BorderStyle = BorderStyle.FixedSingle
        txtIncidentType.Font = New Font("Segoe UI", 10F)
        txtIncidentType.Location = New Point(349, 42)
        txtIncidentType.Name = "txtIncidentType"
        txtIncidentType.ReadOnly = True
        txtIncidentType.Size = New Size(265, 27)
        txtIncidentType.TabIndex = 3
        ' 
        ' lblIncidentDateTime
        ' 
        lblIncidentDateTime.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblIncidentDateTime.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblIncidentDateTime.Location = New Point(18, 91)
        lblIncidentDateTime.Name = "lblIncidentDateTime"
        lblIncidentDateTime.Size = New Size(265, 24)
        lblIncidentDateTime.TabIndex = 4
        lblIncidentDateTime.Text = "Incident Date && Time"
        ' 
        ' txtIncidentDateTime
        ' 
        txtIncidentDateTime.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        txtIncidentDateTime.BorderStyle = BorderStyle.FixedSingle
        txtIncidentDateTime.Font = New Font("Segoe UI", 10F)
        txtIncidentDateTime.Location = New Point(18, 115)
        txtIncidentDateTime.Name = "txtIncidentDateTime"
        txtIncidentDateTime.ReadOnly = True
        txtIncidentDateTime.Size = New Size(265, 27)
        txtIncidentDateTime.TabIndex = 5
        ' 
        ' lblAlarmLevel
        ' 
        lblAlarmLevel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblAlarmLevel.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblAlarmLevel.Location = New Point(349, 91)
        lblAlarmLevel.Name = "lblAlarmLevel"
        lblAlarmLevel.Size = New Size(265, 24)
        lblAlarmLevel.TabIndex = 6
        lblAlarmLevel.Text = "Alarm Level"
        ' 
        ' txtAlarmLevel
        ' 
        txtAlarmLevel.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        txtAlarmLevel.BorderStyle = BorderStyle.FixedSingle
        txtAlarmLevel.Font = New Font("Segoe UI", 10F)
        txtAlarmLevel.Location = New Point(349, 115)
        txtAlarmLevel.Name = "txtAlarmLevel"
        txtAlarmLevel.ReadOnly = True
        txtAlarmLevel.Size = New Size(265, 27)
        txtAlarmLevel.TabIndex = 7
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
        ' txtResponseTime
        ' 
        txtResponseTime.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        txtResponseTime.BorderStyle = BorderStyle.FixedSingle
        txtResponseTime.Font = New Font("Segoe UI", 10F)
        txtResponseTime.Location = New Point(18, 188)
        txtResponseTime.Name = "txtResponseTime"
        txtResponseTime.ReadOnly = True
        txtResponseTime.Size = New Size(265, 27)
        txtResponseTime.TabIndex = 9
        ' 
        ' lblStatus
        ' 
        lblStatus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblStatus.Location = New Point(349, 163)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(265, 24)
        lblStatus.TabIndex = 10
        lblStatus.Text = "Status"
        ' 
        ' txtStatus
        ' 
        txtStatus.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        txtStatus.BorderStyle = BorderStyle.FixedSingle
        txtStatus.Font = New Font("Segoe UI", 10F)
        txtStatus.Location = New Point(349, 188)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(265, 27)
        txtStatus.TabIndex = 11
        ' 
        ' lblInvolvedProperty
        ' 
        lblInvolvedProperty.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblInvolvedProperty.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblInvolvedProperty.Location = New Point(620, 18)
        lblInvolvedProperty.Name = "lblInvolvedProperty"
        lblInvolvedProperty.Size = New Size(340, 22)
        lblInvolvedProperty.TabIndex = 12
        lblInvolvedProperty.Text = "Involved Building / Establishment / Vehicle"
        ' 
        ' txtInvolvedProperty
        ' 
        txtInvolvedProperty.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        txtInvolvedProperty.BorderStyle = BorderStyle.FixedSingle
        txtInvolvedProperty.Font = New Font("Segoe UI", 10F)
        txtInvolvedProperty.Location = New Point(620, 42)
        txtInvolvedProperty.Multiline = True
        txtInvolvedProperty.Name = "txtInvolvedProperty"
        txtInvolvedProperty.ReadOnly = True
        txtInvolvedProperty.Size = New Size(340, 65)
        txtInvolvedProperty.TabIndex = 13
        ' 
        ' lblAddress
        ' 
        lblAddress.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblAddress.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblAddress.Location = New Point(620, 115)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(340, 22)
        lblAddress.TabIndex = 14
        lblAddress.Text = "Incident Address / Location"
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        txtAddress.BorderStyle = BorderStyle.FixedSingle
        txtAddress.Font = New Font("Segoe UI", 10F)
        txtAddress.Location = New Point(620, 139)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.ReadOnly = True
        txtAddress.Size = New Size(340, 65)
        txtAddress.TabIndex = 15
        ' 
        ' lblOwnerOccupant
        ' 
        lblOwnerOccupant.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblOwnerOccupant.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblOwnerOccupant.Location = New Point(18, 229)
        lblOwnerOccupant.Name = "lblOwnerOccupant"
        lblOwnerOccupant.Size = New Size(265, 24)
        lblOwnerOccupant.TabIndex = 16
        lblOwnerOccupant.Text = "Name of Owner / Occupant"
        ' 
        ' txtOwnerOccupant
        ' 
        txtOwnerOccupant.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        txtOwnerOccupant.BorderStyle = BorderStyle.FixedSingle
        txtOwnerOccupant.Font = New Font("Segoe UI", 10F)
        txtOwnerOccupant.Location = New Point(18, 253)
        txtOwnerOccupant.Name = "txtOwnerOccupant"
        txtOwnerOccupant.ReadOnly = True
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
        lblCallerInformation.Text = "Caller Information"
        ' 
        ' txtCallerInformation
        ' 
        txtCallerInformation.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        txtCallerInformation.BorderStyle = BorderStyle.FixedSingle
        txtCallerInformation.Font = New Font("Segoe UI", 10F)
        txtCallerInformation.Location = New Point(349, 253)
        txtCallerInformation.Name = "txtCallerInformation"
        txtCallerInformation.ReadOnly = True
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
        txtCasualties.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        txtCasualties.BorderStyle = BorderStyle.FixedSingle
        txtCasualties.Font = New Font("Segoe UI", 10F)
        txtCasualties.Location = New Point(18, 326)
        txtCasualties.Name = "txtCasualties"
        txtCasualties.ReadOnly = True
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
        txtDamageEstimate.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        txtDamageEstimate.BorderStyle = BorderStyle.FixedSingle
        txtDamageEstimate.Font = New Font("Segoe UI", 10F)
        txtDamageEstimate.Location = New Point(349, 326)
        txtDamageEstimate.Name = "txtDamageEstimate"
        txtDamageEstimate.ReadOnly = True
        txtDamageEstimate.Size = New Size(265, 27)
        txtDamageEstimate.TabIndex = 21
        ' 
        ' lblCauseOfFire
        ' 
        lblCauseOfFire.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCauseOfFire.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblCauseOfFire.Location = New Point(620, 229)
        lblCauseOfFire.Name = "lblCauseOfFire"
        lblCauseOfFire.Size = New Size(132, 24)
        lblCauseOfFire.TabIndex = 22
        lblCauseOfFire.Text = "Cause of Fire"
        ' 
        ' txtCauseOfFire
        ' 
        txtCauseOfFire.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        txtCauseOfFire.BorderStyle = BorderStyle.FixedSingle
        txtCauseOfFire.Font = New Font("Segoe UI", 10F)
        txtCauseOfFire.Location = New Point(620, 256)
        txtCauseOfFire.Multiline = True
        txtCauseOfFire.Name = "txtCauseOfFire"
        txtCauseOfFire.ReadOnly = True
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
        lblDocument.Text = "Attached Document"
        ' 
        ' txtDocumentName
        ' 
        txtDocumentName.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        txtDocumentName.BorderStyle = BorderStyle.FixedSingle
        txtDocumentName.Font = New Font("Segoe UI", 10F)
        txtDocumentName.Location = New Point(18, 394)
        txtDocumentName.Name = "txtDocumentName"
        txtDocumentName.ReadOnly = True
        txtDocumentName.Size = New Size(441, 27)
        txtDocumentName.TabIndex = 25
        ' 
        ' btnOpenDocument
        ' 
        btnOpenDocument.BackColor = Color.FromArgb(CByte(30), CByte(100), CByte(180))
        btnOpenDocument.Cursor = Cursors.Hand
        btnOpenDocument.FlatAppearance.BorderSize = 0
        btnOpenDocument.FlatStyle = FlatStyle.Flat
        btnOpenDocument.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnOpenDocument.ForeColor = Color.White
        btnOpenDocument.Location = New Point(468, 394)
        btnOpenDocument.Name = "btnOpenDocument"
        btnOpenDocument.Size = New Size(155, 27)
        btnOpenDocument.TabIndex = 26
        btnOpenDocument.Text = "Open"
        btnOpenDocument.UseVisualStyleBackColor = False
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
        txtRemarks.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        txtRemarks.BorderStyle = BorderStyle.FixedSingle
        txtRemarks.Font = New Font("Segoe UI", 10F)
        txtRemarks.Location = New Point(18, 463)
        txtRemarks.Multiline = True
        txtRemarks.Name = "txtRemarks"
        txtRemarks.ReadOnly = True
        txtRemarks.ScrollBars = ScrollBars.Vertical
        txtRemarks.Size = New Size(596, 70)
        txtRemarks.TabIndex = 28
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.White
        pnlFooter.Controls.Add(btnClose)
        pnlFooter.Location = New Point(22, 681)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(981, 57)
        pnlFooter.TabIndex = 2
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(857, 9)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(110, 40)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' ViewRecordForm
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
        Name = "ViewRecordForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Incident Record Details"
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
    Friend WithEvents pnlDivider            As Panel
    Friend WithEvents lblTitle              As Label
    Friend WithEvents lblSub                As Label
    Friend WithEvents lblRecordID           As Label
    Friend WithEvents txtRecordID           As TextBox
    Friend WithEvents lblIncidentType       As Label
    Friend WithEvents txtIncidentType       As TextBox
    Friend WithEvents lblIncidentDateTime   As Label
    Friend WithEvents txtIncidentDateTime   As TextBox
    Friend WithEvents lblAlarmLevel         As Label
    Friend WithEvents txtAlarmLevel         As TextBox
    Friend WithEvents lblResponseTime       As Label
    Friend WithEvents txtResponseTime       As TextBox
    Friend WithEvents lblStatus             As Label
    Friend WithEvents txtStatus             As TextBox
    Friend WithEvents lblInvolvedProperty   As Label
    Friend WithEvents txtInvolvedProperty   As TextBox
    Friend WithEvents lblAddress            As Label
    Friend WithEvents txtAddress            As TextBox
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
    Friend WithEvents btnOpenDocument       As Button
    Friend WithEvents lblRemarks            As Label
    Friend WithEvents txtRemarks            As TextBox
    Friend WithEvents btnClose              As Button

End Class
