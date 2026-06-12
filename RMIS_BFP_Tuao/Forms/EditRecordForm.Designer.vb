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

        pnlHeader      = New Panel()
        pnlBody        = New Panel()
        pnlFooter      = New Panel()
        lblTitle       = New Label()
        lblSub         = New Label()
        pnlDivider     = New Panel()

        lblRecordID    = New Label()
        txtRecordID    = New TextBox()
        lblIncidentType = New Label()
        cboIncidentType = New ComboBox()
        lblDateReported = New Label()
        dtpDateReported = New DateTimePicker()
        lblLocation    = New Label()
        txtLocation    = New TextBox()
        lblReportedBy  = New Label()
        txtReportedBy  = New TextBox()
        lblCasualties  = New Label()
        txtCasualties  = New TextBox()
        lblDamage      = New Label()
        txtDamageEstimate = New TextBox()
        lblStatus      = New Label()
        cboStatus      = New ComboBox()
        lblRemarks     = New Label()
        txtRemarks     = New TextBox()

        btnSave        = New Button()
        btnCancel      = New Button()

        pnlHeader.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlFooter.SuspendLayout()
        SuspendLayout()

        ' ════════════════════════════════════════════════════════
        ' Form
        ' ════════════════════════════════════════════════════════
        Me.Text = "Edit Incident Record"
        Me.ClientSize = New Size(620, 590)
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterParent
        Me.BackColor = Color.FromArgb(240, 242, 245)
        Me.Font = New Font("Segoe UI", 9F)

        ' ════════════════════════════════════════════════════════
        ' pnlHeader
        ' ════════════════════════════════════════════════════════
        pnlHeader.BackColor = Color.White
        pnlHeader.Size = New Size(580, 80)
        pnlHeader.Location = New Point(20, 16)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(lblSub)
        pnlHeader.Controls.Add(pnlDivider)

        lblTitle.Text = "Edit Incident Record"
        lblTitle.Font = New Font("Segoe UI", 13, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(30, 30, 30)
        lblTitle.AutoSize = False
        lblTitle.Size = New Size(540, 30)
        lblTitle.Location = New Point(16, 10)

        lblSub.Text = "Modify the fields below and click Save to update."
        lblSub.Font = New Font("Segoe UI", 9)
        lblSub.ForeColor = Color.Gray
        lblSub.AutoSize = False
        lblSub.Size = New Size(540, 20)
        lblSub.Location = New Point(16, 42)

        pnlDivider.BackColor = Color.FromArgb(180, 20, 20)
        pnlDivider.Size = New Size(548, 3)
        pnlDivider.Location = New Point(16, 70)

        ' ════════════════════════════════════════════════════════
        ' pnlBody — form fields
        ' ════════════════════════════════════════════════════════
        pnlBody.BackColor = Color.White
        pnlBody.Size = New Size(580, 430)
        pnlBody.Location = New Point(20, 108)
        pnlBody.Controls.AddRange({
            lblRecordID, txtRecordID,
            lblIncidentType, cboIncidentType,
            lblDateReported, dtpDateReported,
            lblLocation, txtLocation,
            lblReportedBy, txtReportedBy,
            lblCasualties, txtCasualties,
            lblDamage, txtDamageEstimate,
            lblStatus, cboStatus,
            lblRemarks, txtRemarks})

        ' helper: label + control row layout (left col x=16, right col x=300)
        ' Row heights: 28px label + 30px control + 10px gap = 68px per row

        ' --- Record ID (read-only) ---
        lblRecordID.Text = "Record ID *"
        lblRecordID.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblRecordID.ForeColor = Color.FromArgb(60, 60, 60)
        lblRecordID.AutoSize = False
        lblRecordID.Size = New Size(240, 22)
        lblRecordID.Location = New Point(16, 16)

        txtRecordID.Font = New Font("Segoe UI", 10)
        txtRecordID.BackColor = Color.FromArgb(230, 230, 230)
        txtRecordID.BorderStyle = BorderStyle.FixedSingle
        txtRecordID.Size = New Size(240, 28)
        txtRecordID.Location = New Point(16, 38)
        txtRecordID.ReadOnly = True

        ' --- Incident Type ---
        lblIncidentType.Text = "Incident Type *"
        lblIncidentType.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblIncidentType.ForeColor = Color.FromArgb(60, 60, 60)
        lblIncidentType.AutoSize = False
        lblIncidentType.Size = New Size(240, 22)
        lblIncidentType.Location = New Point(316, 16)

        cboIncidentType.Font = New Font("Segoe UI", 10)
        cboIncidentType.Size = New Size(240, 28)
        cboIncidentType.Location = New Point(316, 38)
        cboIncidentType.DropDownStyle = ComboBoxStyle.DropDownList
        cboIncidentType.FlatStyle = FlatStyle.Flat

        ' --- Date Reported ---
        lblDateReported.Text = "Date Reported *"
        lblDateReported.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblDateReported.ForeColor = Color.FromArgb(60, 60, 60)
        lblDateReported.AutoSize = False
        lblDateReported.Size = New Size(240, 22)
        lblDateReported.Location = New Point(16, 82)

        dtpDateReported.Font = New Font("Segoe UI", 10)
        dtpDateReported.Size = New Size(240, 28)
        dtpDateReported.Location = New Point(16, 104)
        dtpDateReported.Format = DateTimePickerFormat.Short

        ' --- Status ---
        lblStatus.Text = "Status *"
        lblStatus.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(60, 60, 60)
        lblStatus.AutoSize = False
        lblStatus.Size = New Size(240, 22)
        lblStatus.Location = New Point(316, 82)

        cboStatus.Font = New Font("Segoe UI", 10)
        cboStatus.Size = New Size(240, 28)
        cboStatus.Location = New Point(316, 104)
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.FlatStyle = FlatStyle.Flat

        ' --- Location ---
        lblLocation.Text = "Location *"
        lblLocation.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblLocation.ForeColor = Color.FromArgb(60, 60, 60)
        lblLocation.AutoSize = False
        lblLocation.Size = New Size(540, 22)
        lblLocation.Location = New Point(16, 148)

        txtLocation.Font = New Font("Segoe UI", 10)
        txtLocation.BorderStyle = BorderStyle.FixedSingle
        txtLocation.Size = New Size(540, 28)
        txtLocation.Location = New Point(16, 170)

        ' --- Reported By ---
        lblReportedBy.Text = "Reported By *"
        lblReportedBy.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblReportedBy.ForeColor = Color.FromArgb(60, 60, 60)
        lblReportedBy.AutoSize = False
        lblReportedBy.Size = New Size(240, 22)
        lblReportedBy.Location = New Point(16, 214)

        txtReportedBy.Font = New Font("Segoe UI", 10)
        txtReportedBy.BorderStyle = BorderStyle.FixedSingle
        txtReportedBy.Size = New Size(240, 28)
        txtReportedBy.Location = New Point(16, 236)

        ' --- Casualties ---
        lblCasualties.Text = "Casualties"
        lblCasualties.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblCasualties.ForeColor = Color.FromArgb(60, 60, 60)
        lblCasualties.AutoSize = False
        lblCasualties.Size = New Size(240, 22)
        lblCasualties.Location = New Point(316, 214)

        txtCasualties.Font = New Font("Segoe UI", 10)
        txtCasualties.BorderStyle = BorderStyle.FixedSingle
        txtCasualties.Size = New Size(240, 28)
        txtCasualties.Location = New Point(316, 236)

        ' --- Damage Estimate ---
        lblDamage.Text = "Damage Estimate (PHP)"
        lblDamage.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblDamage.ForeColor = Color.FromArgb(60, 60, 60)
        lblDamage.AutoSize = False
        lblDamage.Size = New Size(540, 22)
        lblDamage.Location = New Point(16, 280)

        txtDamageEstimate.Font = New Font("Segoe UI", 10)
        txtDamageEstimate.BorderStyle = BorderStyle.FixedSingle
        txtDamageEstimate.Size = New Size(540, 28)
        txtDamageEstimate.Location = New Point(16, 302)

        ' --- Remarks ---
        lblRemarks.Text = "Remarks"
        lblRemarks.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblRemarks.ForeColor = Color.FromArgb(60, 60, 60)
        lblRemarks.AutoSize = False
        lblRemarks.Size = New Size(540, 22)
        lblRemarks.Location = New Point(16, 346)

        txtRemarks.Font = New Font("Segoe UI", 10)
        txtRemarks.BorderStyle = BorderStyle.FixedSingle
        txtRemarks.Size = New Size(540, 64)
        txtRemarks.Location = New Point(16, 368)
        txtRemarks.Multiline = True
        txtRemarks.ScrollBars = ScrollBars.Vertical

        ' ════════════════════════════════════════════════════════
        ' pnlFooter — Save / Cancel buttons
        ' ════════════════════════════════════════════════════════
        pnlFooter.BackColor = Color.White
        pnlFooter.Size = New Size(580, 52)
        pnlFooter.Location = New Point(20, 548)
        pnlFooter.Controls.Add(btnSave)
        pnlFooter.Controls.Add(btnCancel)

        btnSave.Text = "Save Changes"
        btnSave.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnSave.Size = New Size(140, 36)
        btnSave.Location = New Point(298, 8)
        btnSave.BackColor = Color.FromArgb(180, 20, 20)
        btnSave.ForeColor = Color.White
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.Cursor = Cursors.Hand

        btnCancel.Text = "Cancel"
        btnCancel.Font = New Font("Segoe UI", 10)
        btnCancel.Size = New Size(100, 36)
        btnCancel.Location = New Point(452, 8)
        btnCancel.BackColor = Color.FromArgb(240, 242, 245)
        btnCancel.ForeColor = Color.FromArgb(60, 60, 60)
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200)
        btnCancel.Cursor = Cursors.Hand

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
    Friend WithEvents pnlHeader        As Panel
    Friend WithEvents pnlBody          As Panel
    Friend WithEvents pnlFooter        As Panel
    Friend WithEvents pnlDivider       As Panel
    Friend WithEvents lblTitle         As Label
    Friend WithEvents lblSub           As Label
    Friend WithEvents lblRecordID      As Label
    Friend WithEvents txtRecordID      As TextBox
    Friend WithEvents lblIncidentType  As Label
    Friend WithEvents cboIncidentType  As ComboBox
    Friend WithEvents lblDateReported  As Label
    Friend WithEvents dtpDateReported  As DateTimePicker
    Friend WithEvents lblLocation      As Label
    Friend WithEvents txtLocation      As TextBox
    Friend WithEvents lblReportedBy    As Label
    Friend WithEvents txtReportedBy    As TextBox
    Friend WithEvents lblCasualties    As Label
    Friend WithEvents txtCasualties    As TextBox
    Friend WithEvents lblDamage        As Label
    Friend WithEvents txtDamageEstimate As TextBox
    Friend WithEvents lblStatus        As Label
    Friend WithEvents cboStatus        As ComboBox
    Friend WithEvents lblRemarks       As Label
    Friend WithEvents txtRemarks       As TextBox
    Friend WithEvents btnSave          As Button
    Friend WithEvents btnCancel        As Button

End Class
