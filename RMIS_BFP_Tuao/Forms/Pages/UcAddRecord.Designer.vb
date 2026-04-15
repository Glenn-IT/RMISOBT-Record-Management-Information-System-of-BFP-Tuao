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

        ' Field label helper
        Dim MkLbl As Action(Of Label, String, Integer, Integer) =
            Sub(l As Label, t As String, x As Integer, y As Integer)
                l.Text = t
                l.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                l.ForeColor = Color.FromArgb(70, 70, 70)
                l.AutoSize = False
                l.Size = New Size(390, 20)
                l.Location = New Point(x, y)
            End Sub

        Dim MkTxt As Action(Of TextBox, Integer, Integer, Integer) =
            Sub(t As TextBox, x As Integer, y As Integer, w As Integer)
                t.Font = New Font("Segoe UI", 10)
                t.BorderStyle = BorderStyle.FixedSingle
                t.BackColor = Color.FromArgb(250, 250, 250)
                t.Size = New Size(w, 30)
                t.Location = New Point(x, y)
            End Sub

        Dim MkCbo As Action(Of ComboBox, Integer, Integer, Integer) =
            Sub(c As ComboBox, x As Integer, y As Integer, w As Integer)
                c.Font = New Font("Segoe UI", 10)
                c.FlatStyle = FlatStyle.Flat
                c.BackColor = Color.FromArgb(250, 250, 250)
                c.DropDownStyle = ComboBoxStyle.DropDownList
                c.Size = New Size(w, 30)
                c.Location = New Point(x, y)
            End Sub

        ' Row 1
        MkLbl(lblIncidentNo,   "Incident No. *",  24,  100)
        MkTxt(txtIncidentNo,   24,  122, 390)
        txtIncidentNo.PlaceholderText = "e.g. INC-2025-001"

        MkLbl(lblIncidentType, "Incident Type *", 442, 100)
        MkCbo(cboIncidentType, 442, 122, 390)

        ' Row 2
        MkLbl(lblDateReported, "Date Reported *", 24,  170)
        dtpDateReported.Font = New Font("Segoe UI", 10)
        dtpDateReported.Size = New Size(390, 30)
        dtpDateReported.Location = New Point(24, 192)
        dtpDateReported.Format = DateTimePickerFormat.Short

        MkLbl(lblStatus,       "Status *",        442, 170)
        MkCbo(cboStatus,       442, 192, 390)

        ' Row 3
        MkLbl(lblLocation,     "Location / Address *", 24, 240)
        MkTxt(txtLocation,     24,  262, 808)
        txtLocation.PlaceholderText = "e.g. Brgy. Centro, Tuao, Cagayan"

        ' Row 4
        MkLbl(lblReportedBy,   "Reported By *",   24,  310)
        MkTxt(txtReportedBy,   24,  332, 390)
        txtReportedBy.PlaceholderText = "Full name of reporting officer"

        MkLbl(lblCasualties,   "No. of Casualties", 442, 310)
        MkTxt(txtCasualties,   442, 332, 390)
        txtCasualties.PlaceholderText = "0"

        ' Row 5
        MkLbl(lblDamageEstimate, "Estimated Damage (PHP)", 24, 380)
        MkTxt(txtDamageEstimate, 24,  402, 390)
        txtDamageEstimate.PlaceholderText = "e.g. 500000"

        MkLbl(lblRemarks, "Remarks / Notes", 442, 380)
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
