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

        pnlHeader      = New Panel()
        pnlBody        = New Panel()
        pnlFooter      = New Panel()
        lblTitle       = New Label()
        lblSub         = New Label()
        pnlDivider     = New Panel()

        lblRecordID    = New Label()
        txtRecordID    = New TextBox()
        lblIncidentType = New Label()
        txtIncidentType = New TextBox()
        lblIncidentDateTime = New Label()
        txtIncidentDateTime = New TextBox()
        lblAlarmLevel  = New Label()
        txtAlarmLevel  = New TextBox()
        lblResponseTime = New Label()
        txtResponseTime = New TextBox()
        lblStatus      = New Label()
        txtStatus      = New TextBox()
        lblInvolvedProperty = New Label()
        txtInvolvedProperty = New TextBox()
        lblOwnerOccupant = New Label()
        txtOwnerOccupant = New TextBox()
        lblCallerInformation = New Label()
        txtCallerInformation = New TextBox()
        lblCasualties  = New Label()
        txtCasualties  = New TextBox()
        lblDamage      = New Label()
        txtDamageEstimate = New TextBox()
        lblCauseOfFire = New Label()
        txtCauseOfFire = New TextBox()
        lblDocument    = New Label()
        txtDocumentName = New TextBox()
        btnOpenDocument = New Button()
        lblRemarks     = New Label()
        txtRemarks     = New TextBox()

        btnClose       = New Button()

        pnlHeader.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlFooter.SuspendLayout()
        SuspendLayout()

        ' ════════════════════════════════════════════════════════
        ' Form
        ' ════════════════════════════════════════════════════════
        Me.Text = "Incident Record Details"
        Me.ClientSize = New Size(620, 836)
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterParent
        Me.BackColor = Color.FromArgb(240, 242, 245)
        Me.Font = New Font("Segoe UI", 9F)
        Me.AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        Me.AutoScaleMode = AutoScaleMode.Dpi

        ' ════════════════════════════════════════════════════════
        ' pnlHeader
        ' ════════════════════════════════════════════════════════
        pnlHeader.BackColor = Color.White
        pnlHeader.Size = New Size(580, 80)
        pnlHeader.Location = New Point(20, 16)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(lblSub)
        pnlHeader.Controls.Add(pnlDivider)

        lblTitle.Text = "Incident Record Details"
        lblTitle.Font = New Font("Segoe UI", 13, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(30, 30, 30)
        lblTitle.AutoSize = False
        lblTitle.Size = New Size(540, 30)
        lblTitle.Location = New Point(16, 10)

        lblSub.Text = "Read-only view of the selected incident record."
        lblSub.Font = New Font("Segoe UI", 9)
        lblSub.ForeColor = Color.Gray
        lblSub.AutoSize = False
        lblSub.Size = New Size(540, 20)
        lblSub.Location = New Point(16, 42)

        pnlDivider.BackColor = Color.FromArgb(180, 20, 20)
        pnlDivider.Size = New Size(548, 3)
        pnlDivider.Location = New Point(16, 70)

        ' ════════════════════════════════════════════════════════
        ' pnlBody — read-only field display
        ' ════════════════════════════════════════════════════════
        pnlBody.BackColor = Color.White
        pnlBody.Size = New Size(580, 650)
        pnlBody.Location = New Point(20, 108)
        pnlBody.Controls.AddRange({
            lblRecordID, txtRecordID,
            lblIncidentType, txtIncidentType,
            lblIncidentDateTime, txtIncidentDateTime,
            lblAlarmLevel, txtAlarmLevel,
            lblResponseTime, txtResponseTime,
            lblStatus, txtStatus,
            lblInvolvedProperty, txtInvolvedProperty,
            lblOwnerOccupant, txtOwnerOccupant,
            lblCallerInformation, txtCallerInformation,
            lblCasualties, txtCasualties,
            lblDamage, txtDamageEstimate,
            lblCauseOfFire, txtCauseOfFire,
            lblDocument, txtDocumentName, btnOpenDocument,
            lblRemarks, txtRemarks})

        ' helper: label + value row layout (left col x=16, right col x=316)
        ' Row heights: 22px label + 28px value + 16px gap = 66px per row

        ' --- Record ID ---
        lblRecordID.Text = "Record ID"
        lblRecordID.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblRecordID.ForeColor = Color.FromArgb(60, 60, 60)
        lblRecordID.AutoSize = False
        lblRecordID.Size = New Size(240, 22)
        lblRecordID.Location = New Point(16, 16)

        txtRecordID.Font = New Font("Segoe UI", 10)
        txtRecordID.BackColor = Color.FromArgb(230, 230, 230)
        txtRecordID.BorderStyle = BorderStyle.FixedSingle
        txtRecordID.ReadOnly = True
        txtRecordID.Size = New Size(240, 28)
        txtRecordID.Location = New Point(16, 38)

        ' --- Incident Type ---
        lblIncidentType.Text = "Incident Type"
        lblIncidentType.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblIncidentType.ForeColor = Color.FromArgb(60, 60, 60)
        lblIncidentType.AutoSize = False
        lblIncidentType.Size = New Size(240, 22)
        lblIncidentType.Location = New Point(316, 16)

        txtIncidentType.Font = New Font("Segoe UI", 10)
        txtIncidentType.BackColor = Color.FromArgb(230, 230, 230)
        txtIncidentType.BorderStyle = BorderStyle.FixedSingle
        txtIncidentType.ReadOnly = True
        txtIncidentType.Size = New Size(240, 28)
        txtIncidentType.Location = New Point(316, 38)

        ' --- Incident Date & Time ---
        lblIncidentDateTime.Text = "Incident Date && Time"
        lblIncidentDateTime.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblIncidentDateTime.ForeColor = Color.FromArgb(60, 60, 60)
        lblIncidentDateTime.AutoSize = False
        lblIncidentDateTime.Size = New Size(240, 22)
        lblIncidentDateTime.Location = New Point(16, 82)

        txtIncidentDateTime.Font = New Font("Segoe UI", 10)
        txtIncidentDateTime.BackColor = Color.FromArgb(230, 230, 230)
        txtIncidentDateTime.BorderStyle = BorderStyle.FixedSingle
        txtIncidentDateTime.ReadOnly = True
        txtIncidentDateTime.Size = New Size(240, 28)
        txtIncidentDateTime.Location = New Point(16, 104)

        ' --- Alarm Level ---
        lblAlarmLevel.Text = "Alarm Level"
        lblAlarmLevel.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblAlarmLevel.ForeColor = Color.FromArgb(60, 60, 60)
        lblAlarmLevel.AutoSize = False
        lblAlarmLevel.Size = New Size(240, 22)
        lblAlarmLevel.Location = New Point(316, 82)

        txtAlarmLevel.Font = New Font("Segoe UI", 10)
        txtAlarmLevel.BackColor = Color.FromArgb(230, 230, 230)
        txtAlarmLevel.BorderStyle = BorderStyle.FixedSingle
        txtAlarmLevel.ReadOnly = True
        txtAlarmLevel.Size = New Size(240, 28)
        txtAlarmLevel.Location = New Point(316, 104)

        ' --- Response Time ---
        lblResponseTime.Text = "Response Time"
        lblResponseTime.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblResponseTime.ForeColor = Color.FromArgb(60, 60, 60)
        lblResponseTime.AutoSize = False
        lblResponseTime.Size = New Size(240, 22)
        lblResponseTime.Location = New Point(16, 148)

        txtResponseTime.Font = New Font("Segoe UI", 10)
        txtResponseTime.BackColor = Color.FromArgb(230, 230, 230)
        txtResponseTime.BorderStyle = BorderStyle.FixedSingle
        txtResponseTime.ReadOnly = True
        txtResponseTime.Size = New Size(240, 28)
        txtResponseTime.Location = New Point(16, 170)

        ' --- Status ---
        lblStatus.Text = "Status"
        lblStatus.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(60, 60, 60)
        lblStatus.AutoSize = False
        lblStatus.Size = New Size(240, 22)
        lblStatus.Location = New Point(316, 148)

        txtStatus.Font = New Font("Segoe UI", 10)
        txtStatus.BackColor = Color.FromArgb(230, 230, 230)
        txtStatus.BorderStyle = BorderStyle.FixedSingle
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(240, 28)
        txtStatus.Location = New Point(316, 170)

        ' --- Involved Property ---
        lblInvolvedProperty.Text = "Involved Building / Establishment / Vehicle"
        lblInvolvedProperty.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblInvolvedProperty.ForeColor = Color.FromArgb(60, 60, 60)
        lblInvolvedProperty.AutoSize = False
        lblInvolvedProperty.Size = New Size(540, 22)
        lblInvolvedProperty.Location = New Point(16, 214)

        txtInvolvedProperty.Font = New Font("Segoe UI", 10)
        txtInvolvedProperty.BackColor = Color.FromArgb(230, 230, 230)
        txtInvolvedProperty.BorderStyle = BorderStyle.FixedSingle
        txtInvolvedProperty.ReadOnly = True
        txtInvolvedProperty.Size = New Size(540, 28)
        txtInvolvedProperty.Location = New Point(16, 236)

        ' --- Owner / Occupant ---
        lblOwnerOccupant.Text = "Name of Owner / Occupant"
        lblOwnerOccupant.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblOwnerOccupant.ForeColor = Color.FromArgb(60, 60, 60)
        lblOwnerOccupant.AutoSize = False
        lblOwnerOccupant.Size = New Size(240, 22)
        lblOwnerOccupant.Location = New Point(16, 280)

        txtOwnerOccupant.Font = New Font("Segoe UI", 10)
        txtOwnerOccupant.BackColor = Color.FromArgb(230, 230, 230)
        txtOwnerOccupant.BorderStyle = BorderStyle.FixedSingle
        txtOwnerOccupant.ReadOnly = True
        txtOwnerOccupant.Size = New Size(240, 28)
        txtOwnerOccupant.Location = New Point(16, 302)

        ' --- Caller Information ---
        lblCallerInformation.Text = "Caller Information"
        lblCallerInformation.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblCallerInformation.ForeColor = Color.FromArgb(60, 60, 60)
        lblCallerInformation.AutoSize = False
        lblCallerInformation.Size = New Size(240, 22)
        lblCallerInformation.Location = New Point(316, 280)

        txtCallerInformation.Font = New Font("Segoe UI", 10)
        txtCallerInformation.BackColor = Color.FromArgb(230, 230, 230)
        txtCallerInformation.BorderStyle = BorderStyle.FixedSingle
        txtCallerInformation.ReadOnly = True
        txtCallerInformation.Size = New Size(240, 28)
        txtCallerInformation.Location = New Point(316, 302)

        ' --- Casualties ---
        lblCasualties.Text = "Casualties"
        lblCasualties.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblCasualties.ForeColor = Color.FromArgb(60, 60, 60)
        lblCasualties.AutoSize = False
        lblCasualties.Size = New Size(240, 22)
        lblCasualties.Location = New Point(16, 346)

        txtCasualties.Font = New Font("Segoe UI", 10)
        txtCasualties.BackColor = Color.FromArgb(230, 230, 230)
        txtCasualties.BorderStyle = BorderStyle.FixedSingle
        txtCasualties.ReadOnly = True
        txtCasualties.Size = New Size(240, 28)
        txtCasualties.Location = New Point(16, 368)

        ' --- Damage Estimate ---
        lblDamage.Text = "Damage Estimate (PHP)"
        lblDamage.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblDamage.ForeColor = Color.FromArgb(60, 60, 60)
        lblDamage.AutoSize = False
        lblDamage.Size = New Size(240, 22)
        lblDamage.Location = New Point(316, 346)

        txtDamageEstimate.Font = New Font("Segoe UI", 10)
        txtDamageEstimate.BackColor = Color.FromArgb(230, 230, 230)
        txtDamageEstimate.BorderStyle = BorderStyle.FixedSingle
        txtDamageEstimate.ReadOnly = True
        txtDamageEstimate.Size = New Size(240, 28)
        txtDamageEstimate.Location = New Point(316, 368)

        ' --- Cause of Fire ---
        lblCauseOfFire.Text = "Cause of Fire"
        lblCauseOfFire.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblCauseOfFire.ForeColor = Color.FromArgb(60, 60, 60)
        lblCauseOfFire.AutoSize = False
        lblCauseOfFire.Size = New Size(540, 22)
        lblCauseOfFire.Location = New Point(16, 412)

        txtCauseOfFire.Font = New Font("Segoe UI", 10)
        txtCauseOfFire.BackColor = Color.FromArgb(230, 230, 230)
        txtCauseOfFire.BorderStyle = BorderStyle.FixedSingle
        txtCauseOfFire.ReadOnly = True
        txtCauseOfFire.Size = New Size(540, 28)
        txtCauseOfFire.Location = New Point(16, 434)

        ' --- Attached Document ---
        lblDocument.Text = "Attached Document"
        lblDocument.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblDocument.ForeColor = Color.FromArgb(60, 60, 60)
        lblDocument.AutoSize = False
        lblDocument.Size = New Size(540, 22)
        lblDocument.Location = New Point(16, 478)

        txtDocumentName.Font = New Font("Segoe UI", 10)
        txtDocumentName.BackColor = Color.FromArgb(230, 230, 230)
        txtDocumentName.BorderStyle = BorderStyle.FixedSingle
        txtDocumentName.ReadOnly = True
        txtDocumentName.Size = New Size(400, 28)
        txtDocumentName.Location = New Point(16, 500)

        btnOpenDocument.Text = "Open"
        btnOpenDocument.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnOpenDocument.Size = New Size(140, 28)
        btnOpenDocument.Location = New Point(416, 500)
        btnOpenDocument.BackColor = Color.FromArgb(30, 100, 180)
        btnOpenDocument.ForeColor = Color.White
        btnOpenDocument.FlatStyle = FlatStyle.Flat
        btnOpenDocument.FlatAppearance.BorderSize = 0
        btnOpenDocument.Cursor = Cursors.Hand

        ' --- Remarks ---
        lblRemarks.Text = "Remarks"
        lblRemarks.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblRemarks.ForeColor = Color.FromArgb(60, 60, 60)
        lblRemarks.AutoSize = False
        lblRemarks.Size = New Size(540, 22)
        lblRemarks.Location = New Point(16, 544)

        txtRemarks.Font = New Font("Segoe UI", 10)
        txtRemarks.BackColor = Color.FromArgb(230, 230, 230)
        txtRemarks.BorderStyle = BorderStyle.FixedSingle
        txtRemarks.ReadOnly = True
        txtRemarks.Size = New Size(540, 64)
        txtRemarks.Location = New Point(16, 566)
        txtRemarks.Multiline = True
        txtRemarks.ScrollBars = ScrollBars.Vertical

        ' ════════════════════════════════════════════════════════
        ' pnlFooter — Close button
        ' ════════════════════════════════════════════════════════
        pnlFooter.BackColor = Color.White
        pnlFooter.Size = New Size(580, 52)
        pnlFooter.Location = New Point(20, 768)
        pnlFooter.Controls.Add(btnClose)

        btnClose.Text = "Close"
        btnClose.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnClose.Size = New Size(140, 36)
        btnClose.Location = New Point(220, 8)
        btnClose.BackColor = Color.FromArgb(180, 20, 20)
        btnClose.ForeColor = Color.White
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.Cursor = Cursors.Hand

        ' ── Add to Form ──────────────────────────────────────────
        Me.Controls.Add(pnlHeader)
        Me.Controls.Add(pnlBody)
        Me.Controls.Add(pnlFooter)

        pnlFooter.ResumeLayout(False)
        pnlBody.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
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
