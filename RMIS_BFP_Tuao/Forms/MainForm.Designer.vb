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

        lblTopDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")
        lblTopDate.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblTopDate.ForeColor = Color.FromArgb(160, 160, 160)
        lblTopDate.AutoSize = False
        lblTopDate.Size = New Size(260, 60)
        lblTopDate.Location = New Point(730, 0)
        lblTopDate.TextAlign = ContentAlignment.MiddleRight

        lblTopUser.Text = "[ Admin ]"
        lblTopUser.Font = New Font("Segoe UI", 9.5, FontStyle.Regular)
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

        ' Nav button builder
        Dim NavBtn As Action(Of Button, String, Integer) =
            Sub(btn As Button, txt As String, yPos As Integer)
                btn.Text = txt
                btn.Font = New Font("Segoe UI", 10, FontStyle.Regular)
                btn.ForeColor = Color.FromArgb(255, 220, 220)
                btn.BackColor = Color.FromArgb(160, 18, 18)
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderSize = 0
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 50, 50)
                btn.Size = New Size(220, 46)
                btn.Location = New Point(0, yPos)
                btn.TextAlign = ContentAlignment.MiddleLeft
                btn.Padding = New Padding(20, 0, 0, 0)
                btn.Cursor = Cursors.Hand
            End Sub

        NavBtn(btnNavDashboard,    "  Dashboard",    100)
        NavBtn(btnNavAddRecord,    "  Add Record",   150)
        NavBtn(btnNavViewRecords,  "  View Records", 200)
        NavBtn(btnNavReports,      "  Reports",      250)
        NavBtn(btnNavSettings,     "  Settings",     300)
        NavBtn(btnNavDevelopers,   "  Developers",   350)

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
