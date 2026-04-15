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

        pnlFormCard       = New Panel()
        pnlDivider        = New Panel()
        lblPageTitle      = New Label()
        lblPageSub        = New Label()
        lblIncidentNo     = New Label()
        txtIncidentNo     = New TextBox()
        lblIncidentType   = New Label()
        cboIncidentType   = New ComboBox()
        lblDateReported   = New Label()
        dtpDateReported   = New DateTimePicker()
        lblStatus         = New Label()
        cboStatus         = New ComboBox()
        lblLocation       = New Label()
        txtLocation       = New TextBox()
        lblReportedBy     = New Label()
        txtReportedBy     = New TextBox()
        lblCasualties     = New Label()
        txtCasualties     = New TextBox()
        lblDamageEstimate = New Label()
        txtDamageEstimate = New TextBox()
        lblRemarks        = New Label()
        txtRemarks        = New TextBox()
        btnSave           = New Button()
        btnClear          = New Button()

        pnlFormCard.SuspendLayout()
        Me.SuspendLayout()

        ' ?? Form card (white container) ???????????????????????????
        pnlFormCard.BackColor = Color.White
        pnlFormCard.Size = New Size(880, 555)
        pnlFormCard.Location = New Point(24, 18)
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

        ' Header
        lblPageTitle.Text = "Add New Incident Record"
        lblPageTitle.Font = New Font("Segoe UI", 15, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.FromArgb(30, 30, 30)
        lblPageTitle.AutoSize = False
        lblPageTitle.Size = New Size(600, 34)
        lblPageTitle.Location = New Point(24, 18)

        lblPageSub.Text = "Fill in all required fields (*) to add a new record."
        lblPageSub.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblPageSub.ForeColor = Color.Gray
        lblPageSub.AutoSize = False
        lblPageSub.Size = New Size(600, 22)
        lblPageSub.Location = New Point(24, 52)

        pnlDivider.BackColor = Color.FromArgb(180, 20, 20)
        pnlDivider.Size = New Size(832, 3)
        pnlDivider.Location = New Point(24, 80)

        ' Row 1
        lblIncidentNo.Text = "Incident No. *"
        lblIncidentNo.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblIncidentNo.ForeColor = Color.FromArgb(70, 70, 70)
        lblIncidentNo.AutoSize = False
        lblIncidentNo.Size = New Size(390, 20)
        lblIncidentNo.Location = New Point(24, 100)

        txtIncidentNo.Font = New Font("Segoe UI", 10)
        txtIncidentNo.BorderStyle = BorderStyle.FixedSingle
        txtIncidentNo.BackColor = Color.FromArgb(250, 250, 250)
        txtIncidentNo.Size = New Size(390, 30)
        txtIncidentNo.Location = New Point(24, 122)
        txtIncidentNo.PlaceholderText = "e.g. INC-2025-001"

        lblIncidentType.Text = "Incident Type *"
        lblIncidentType.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblIncidentType.ForeColor = Color.FromArgb(70, 70, 70)
        lblIncidentType.AutoSize = False
        lblIncidentType.Size = New Size(390, 20)
        lblIncidentType.Location = New Point(442, 100)

        cboIncidentType.Font = New Font("Segoe UI", 10)
        cboIncidentType.FlatStyle = FlatStyle.Flat
        cboIncidentType.BackColor = Color.FromArgb(250, 250, 250)
        cboIncidentType.DropDownStyle = ComboBoxStyle.DropDownList
        cboIncidentType.Size = New Size(390, 30)
        cboIncidentType.Location = New Point(442, 122)

        ' Row 2
        lblDateReported.Text = "Date Reported *"
        lblDateReported.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblDateReported.ForeColor = Color.FromArgb(70, 70, 70)
        lblDateReported.AutoSize = False
        lblDateReported.Size = New Size(390, 20)
        lblDateReported.Location = New Point(24, 170)

        dtpDateReported.Font = New Font("Segoe UI", 10)
        dtpDateReported.Size = New Size(390, 30)
        dtpDateReported.Location = New Point(24, 192)
        dtpDateReported.Format = DateTimePickerFormat.Short

        lblStatus.Text = "Status *"
        lblStatus.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(70, 70, 70)
        lblStatus.AutoSize = False
        lblStatus.Size = New Size(390, 20)
        lblStatus.Location = New Point(442, 170)

        cboStatus.Font = New Font("Segoe UI", 10)
        cboStatus.FlatStyle = FlatStyle.Flat
        cboStatus.BackColor = Color.FromArgb(250, 250, 250)
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatus.Size = New Size(390, 30)
        cboStatus.Location = New Point(442, 192)

        ' Row 3
        lblLocation.Text = "Location / Address *"
        lblLocation.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblLocation.ForeColor = Color.FromArgb(70, 70, 70)
        lblLocation.AutoSize = False
        lblLocation.Size = New Size(390, 20)
        lblLocation.Location = New Point(24, 240)

        txtLocation.Font = New Font("Segoe UI", 10)
        txtLocation.BorderStyle = BorderStyle.FixedSingle
        txtLocation.BackColor = Color.FromArgb(250, 250, 250)
        txtLocation.Size = New Size(808, 30)
        txtLocation.Location = New Point(24, 262)
        txtLocation.PlaceholderText = "e.g. Brgy. Centro, Tuao, Cagayan"

        ' Row 4
        lblReportedBy.Text = "Reported By *"
        lblReportedBy.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblReportedBy.ForeColor = Color.FromArgb(70, 70, 70)
        lblReportedBy.AutoSize = False
        lblReportedBy.Size = New Size(390, 20)
        lblReportedBy.Location = New Point(24, 310)

        txtReportedBy.Font = New Font("Segoe UI", 10)
        txtReportedBy.BorderStyle = BorderStyle.FixedSingle
        txtReportedBy.BackColor = Color.FromArgb(250, 250, 250)
        txtReportedBy.Size = New Size(390, 30)
        txtReportedBy.Location = New Point(24, 332)
        txtReportedBy.PlaceholderText = "Full name of reporting officer"

        lblCasualties.Text = "No. of Casualties"
        lblCasualties.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblCasualties.ForeColor = Color.FromArgb(70, 70, 70)
        lblCasualties.AutoSize = False
        lblCasualties.Size = New Size(390, 20)
        lblCasualties.Location = New Point(442, 310)

        txtCasualties.Font = New Font("Segoe UI", 10)
        txtCasualties.BorderStyle = BorderStyle.FixedSingle
        txtCasualties.BackColor = Color.FromArgb(250, 250, 250)
        txtCasualties.Size = New Size(390, 30)
        txtCasualties.Location = New Point(442, 332)
        txtCasualties.PlaceholderText = "0"

        ' Row 5
        lblDamageEstimate.Text = "Estimated Damage (PHP)"
        lblDamageEstimate.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblDamageEstimate.ForeColor = Color.FromArgb(70, 70, 70)
        lblDamageEstimate.AutoSize = False
        lblDamageEstimate.Size = New Size(390, 20)
        lblDamageEstimate.Location = New Point(24, 380)

        txtDamageEstimate.Font = New Font("Segoe UI", 10)
        txtDamageEstimate.BorderStyle = BorderStyle.FixedSingle
        txtDamageEstimate.BackColor = Color.FromArgb(250, 250, 250)
        txtDamageEstimate.Size = New Size(390, 30)
        txtDamageEstimate.Location = New Point(24, 402)
        txtDamageEstimate.PlaceholderText = "e.g. 500000"

        lblRemarks.Text = "Remarks / Notes"
        lblRemarks.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblRemarks.ForeColor = Color.FromArgb(70, 70, 70)
        lblRemarks.AutoSize = False
        lblRemarks.Size = New Size(390, 20)
        lblRemarks.Location = New Point(442, 380)

        txtRemarks.Font = New Font("Segoe UI", 10)
        txtRemarks.BorderStyle = BorderStyle.FixedSingle
        txtRemarks.BackColor = Color.FromArgb(250, 250, 250)
        txtRemarks.Multiline = True
        txtRemarks.ScrollBars = ScrollBars.Vertical
        txtRemarks.Size = New Size(390, 62)
        txtRemarks.Location = New Point(442, 402)

        ' Buttons
        btnSave.Text = "SAVE RECORD"
        btnSave.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnSave.Size = New Size(180, 40)
        btnSave.Location = New Point(24, 486)
        btnSave.BackColor = Color.FromArgb(180, 20, 20)
        btnSave.ForeColor = Color.White
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.Cursor = Cursors.Hand

        btnClear.Text = "CLEAR FORM"
        btnClear.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        btnClear.Size = New Size(160, 40)
        btnClear.Location = New Point(216, 486)
        btnClear.BackColor = Color.White
        btnClear.ForeColor = Color.FromArgb(100, 100, 100)
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200)
        btnClear.Cursor = Cursors.Hand

        Me.BackColor = Color.FromArgb(240, 242, 245)
        Me.Controls.Add(pnlFormCard)

        pnlFormCard.ResumeLayout(False)
        Me.ResumeLayout(False)

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
