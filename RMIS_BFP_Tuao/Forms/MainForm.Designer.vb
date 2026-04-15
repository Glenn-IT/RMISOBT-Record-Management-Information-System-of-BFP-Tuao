<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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

        ' ?? Declare controls ?????????????????????????????????????
        pnlTopBar         = New Panel()
        pnlSidebar        = New Panel()
        pnlPageContainer  = New Panel()
        pnlLogo           = New Panel()
        lblSideTitle      = New Label()
        lblSideSub        = New Label()
        lblTopTitle       = New Label()
        lblTopDate        = New Label()
        lblTopUser        = New Label()
        btnNavDashboard   = New Button()
        btnNavAddRecord   = New Button()
        btnNavViewRecords = New Button()
        btnNavReports     = New Button()
        btnNavSettings    = New Button()
        btnNavDevelopers  = New Button()
        btnLogout         = New Button()

        pnlTopBar.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlLogo.SuspendLayout()
        Me.SuspendLayout()

        ' ????????????????????????????????????????????????????????
        ' pnlTopBar — fixed top header
        ' ????????????????????????????????????????????????????????
        pnlTopBar.Dock = DockStyle.Top
        pnlTopBar.Height = 60
        pnlTopBar.BackColor = Color.FromArgb(30, 30, 30)
        pnlTopBar.Controls.Add(lblTopTitle)
        pnlTopBar.Controls.Add(lblTopDate)
        pnlTopBar.Controls.Add(lblTopUser)

        lblTopTitle.Text = "  Record Management Information System  |  BFP Tuao"
        lblTopTitle.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblTopTitle.ForeColor = Color.White
        lblTopTitle.AutoSize = False
        lblTopTitle.Size = New Size(680, 60)
        lblTopTitle.Location = New Point(20, 0)
        lblTopTitle.TextAlign = ContentAlignment.MiddleLeft

        lblTopDate.Text = ""
        lblTopDate.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblTopDate.ForeColor = Color.FromArgb(160, 160, 160)
        lblTopDate.AutoSize = False
        lblTopDate.Size = New Size(260, 60)
        lblTopDate.Location = New Point(730, 0)
        lblTopDate.TextAlign = ContentAlignment.MiddleRight

        lblTopUser.Text = "[ Admin ]"
        lblTopUser.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        lblTopUser.ForeColor = Color.FromArgb(200, 200, 200)
        lblTopUser.AutoSize = False
        lblTopUser.Size = New Size(120, 60)
        lblTopUser.Location = New Point(1040, 0)
        lblTopUser.TextAlign = ContentAlignment.MiddleRight

        ' ????????????????????????????????????????????????????????
        ' pnlSidebar — fixed left sidebar
        ' ????????????????????????????????????????????????????????
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Width = 220
        pnlSidebar.BackColor = Color.FromArgb(180, 20, 20)
        pnlSidebar.Controls.Add(pnlLogo)
        pnlSidebar.Controls.Add(btnNavDashboard)
        pnlSidebar.Controls.Add(btnNavAddRecord)
        pnlSidebar.Controls.Add(btnNavViewRecords)
        pnlSidebar.Controls.Add(btnNavReports)
        pnlSidebar.Controls.Add(btnNavSettings)
        pnlSidebar.Controls.Add(btnNavDevelopers)
        pnlSidebar.Controls.Add(btnLogout)

        ' Logo panel at top of sidebar
        pnlLogo.BackColor = Color.FromArgb(140, 10, 10)
        pnlLogo.Size = New Size(220, 90)
        pnlLogo.Location = New Point(0, 0)
        pnlLogo.Controls.Add(lblSideTitle)
        pnlLogo.Controls.Add(lblSideSub)

        lblSideTitle.Text = "BFP TUAO"
        lblSideTitle.Font = New Font("Segoe UI", 13, FontStyle.Bold)
        lblSideTitle.ForeColor = Color.White
        lblSideTitle.AutoSize = False
        lblSideTitle.Size = New Size(200, 32)
        lblSideTitle.Location = New Point(10, 16)
        lblSideTitle.TextAlign = ContentAlignment.MiddleCenter

        lblSideSub.Text = "Fire Protection"
        lblSideSub.Font = New Font("Segoe UI", 8, FontStyle.Regular)
        lblSideSub.ForeColor = Color.FromArgb(255, 200, 200)
        lblSideSub.AutoSize = False
        lblSideSub.Size = New Size(200, 20)
        lblSideSub.Location = New Point(10, 52)
        lblSideSub.TextAlign = ContentAlignment.MiddleCenter

        btnNavDashboard.Text = "  Dashboard"
        btnNavDashboard.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        btnNavDashboard.ForeColor = Color.FromArgb(255, 220, 220)
        btnNavDashboard.BackColor = Color.FromArgb(160, 18, 18)
        btnNavDashboard.FlatStyle = FlatStyle.Flat
        btnNavDashboard.FlatAppearance.BorderSize = 0
        btnNavDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 50, 50)
        btnNavDashboard.Size = New Size(220, 46)
        btnNavDashboard.Location = New Point(0, 100)
        btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnNavDashboard.Padding = New Padding(20, 0, 0, 0)
        btnNavDashboard.Cursor = Cursors.Hand

        btnNavAddRecord.Text = "  Add Record"
        btnNavAddRecord.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        btnNavAddRecord.ForeColor = Color.FromArgb(255, 220, 220)
        btnNavAddRecord.BackColor = Color.FromArgb(160, 18, 18)
        btnNavAddRecord.FlatStyle = FlatStyle.Flat
        btnNavAddRecord.FlatAppearance.BorderSize = 0
        btnNavAddRecord.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 50, 50)
        btnNavAddRecord.Size = New Size(220, 46)
        btnNavAddRecord.Location = New Point(0, 150)
        btnNavAddRecord.TextAlign = ContentAlignment.MiddleLeft
        btnNavAddRecord.Padding = New Padding(20, 0, 0, 0)
        btnNavAddRecord.Cursor = Cursors.Hand

        btnNavViewRecords.Text = "  View Records"
        btnNavViewRecords.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        btnNavViewRecords.ForeColor = Color.FromArgb(255, 220, 220)
        btnNavViewRecords.BackColor = Color.FromArgb(160, 18, 18)
        btnNavViewRecords.FlatStyle = FlatStyle.Flat
        btnNavViewRecords.FlatAppearance.BorderSize = 0
        btnNavViewRecords.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 50, 50)
        btnNavViewRecords.Size = New Size(220, 46)
        btnNavViewRecords.Location = New Point(0, 200)
        btnNavViewRecords.TextAlign = ContentAlignment.MiddleLeft
        btnNavViewRecords.Padding = New Padding(20, 0, 0, 0)
        btnNavViewRecords.Cursor = Cursors.Hand

        btnNavReports.Text = "  Reports"
        btnNavReports.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        btnNavReports.ForeColor = Color.FromArgb(255, 220, 220)
        btnNavReports.BackColor = Color.FromArgb(160, 18, 18)
        btnNavReports.FlatStyle = FlatStyle.Flat
        btnNavReports.FlatAppearance.BorderSize = 0
        btnNavReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 50, 50)
        btnNavReports.Size = New Size(220, 46)
        btnNavReports.Location = New Point(0, 250)
        btnNavReports.TextAlign = ContentAlignment.MiddleLeft
        btnNavReports.Padding = New Padding(20, 0, 0, 0)
        btnNavReports.Cursor = Cursors.Hand

        btnNavSettings.Text = "  Settings"
        btnNavSettings.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        btnNavSettings.ForeColor = Color.FromArgb(255, 220, 220)
        btnNavSettings.BackColor = Color.FromArgb(160, 18, 18)
        btnNavSettings.FlatStyle = FlatStyle.Flat
        btnNavSettings.FlatAppearance.BorderSize = 0
        btnNavSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 50, 50)
        btnNavSettings.Size = New Size(220, 46)
        btnNavSettings.Location = New Point(0, 300)
        btnNavSettings.TextAlign = ContentAlignment.MiddleLeft
        btnNavSettings.Padding = New Padding(20, 0, 0, 0)
        btnNavSettings.Cursor = Cursors.Hand

        btnNavDevelopers.Text = "  Developers"
        btnNavDevelopers.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        btnNavDevelopers.ForeColor = Color.FromArgb(255, 220, 220)
        btnNavDevelopers.BackColor = Color.FromArgb(160, 18, 18)
        btnNavDevelopers.FlatStyle = FlatStyle.Flat
        btnNavDevelopers.FlatAppearance.BorderSize = 0
        btnNavDevelopers.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 50, 50)
        btnNavDevelopers.Size = New Size(220, 46)
        btnNavDevelopers.Location = New Point(0, 350)
        btnNavDevelopers.TextAlign = ContentAlignment.MiddleLeft
        btnNavDevelopers.Padding = New Padding(20, 0, 0, 0)
        btnNavDevelopers.Cursor = Cursors.Hand

        btnLogout.Text = "  Logout"
        btnLogout.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        btnLogout.ForeColor = Color.FromArgb(255, 180, 180)
        btnLogout.BackColor = Color.FromArgb(120, 10, 10)
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 30, 30)
        btnLogout.Size = New Size(220, 46)
        btnLogout.Location = New Point(0, 560)
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.Padding = New Padding(20, 0, 0, 0)
        btnLogout.Cursor = Cursors.Hand

        ' ????????????????????????????????????????????????????????
        ' pnlPageContainer — fills remaining space, hosts UserControls
        ' ????????????????????????????????????????????????????????
        pnlPageContainer.Dock = DockStyle.Fill
        pnlPageContainer.BackColor = Color.FromArgb(240, 242, 245)

        ' ????????????????????????????????????????????????????????
        ' MainForm properties
        ' ????????????????????????????????????????????????????????
        Me.Text = "BFP Tuao — Record Management Information System"
        Me.Size = New Size(1200, 700)
        Me.MinimumSize = New Size(1200, 700)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(240, 242, 245)
        Me.Font = New Font("Segoe UI", 9)

        ' Add in correct z-order: Fill first, then Left, then Top
        Me.Controls.Add(pnlPageContainer)
        Me.Controls.Add(pnlSidebar)
        Me.Controls.Add(pnlTopBar)

        pnlLogo.ResumeLayout(False)
        pnlSidebar.ResumeLayout(False)
        pnlTopBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    ' ?? Control Declarations ?????????????????????????????????????
    Friend WithEvents pnlTopBar         As Panel
    Friend WithEvents pnlSidebar        As Panel
    Friend WithEvents pnlPageContainer  As Panel
    Friend WithEvents pnlLogo           As Panel
    Friend WithEvents lblTopTitle       As Label
    Friend WithEvents lblTopDate        As Label
    Friend WithEvents lblTopUser        As Label
    Friend WithEvents lblSideTitle      As Label
    Friend WithEvents lblSideSub        As Label
    Friend WithEvents btnNavDashboard   As Button
    Friend WithEvents btnNavAddRecord   As Button
    Friend WithEvents btnNavViewRecords As Button
    Friend WithEvents btnNavReports     As Button
    Friend WithEvents btnNavSettings    As Button
    Friend WithEvents btnNavDevelopers  As Button
    Friend WithEvents btnLogout         As Button

End Class
