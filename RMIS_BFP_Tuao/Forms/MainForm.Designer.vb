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
        pnlTopBar = New Panel()
        lblTopTitle = New Label()
        lblTopDate = New Label()
        lblTopUser = New Label()
        pnlSidebar = New Panel()
        pnlLogo = New Panel()
        lblSideTitle = New Label()
        lblSideSub = New Label()
        btnNavDashboard = New Button()
        btnNavAddRecord = New Button()
        btnNavViewRecords = New Button()
        btnNavReports = New Button()
        btnNavSettings = New Button()
        btnNavDevelopers = New Button()
        btnLogout = New Button()
        pnlPageContainer = New Panel()
        pnlTopBar.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlLogo.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTopBar
        ' 
        pnlTopBar.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        pnlTopBar.Controls.Add(lblTopTitle)
        pnlTopBar.Controls.Add(lblTopDate)
        pnlTopBar.Controls.Add(lblTopUser)
        pnlTopBar.Dock = DockStyle.Top
        pnlTopBar.Location = New Point(0, 0)
        pnlTopBar.Name = "pnlTopBar"
        pnlTopBar.Size = New Size(1198, 60)
        pnlTopBar.TabIndex = 2
        ' 
        ' lblTopTitle
        ' 
        lblTopTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTopTitle.ForeColor = Color.White
        lblTopTitle.Location = New Point(20, 0)
        lblTopTitle.Name = "lblTopTitle"
        lblTopTitle.Size = New Size(680, 60)
        lblTopTitle.TabIndex = 0
        lblTopTitle.Text = "  Record Management Information System  |  BFP Tuao"
        lblTopTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTopDate
        ' 
        lblTopDate.Font = New Font("Segoe UI", 9F)
        lblTopDate.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(160))
        lblTopDate.Location = New Point(730, 0)
        lblTopDate.Name = "lblTopDate"
        lblTopDate.Size = New Size(260, 60)
        lblTopDate.TabIndex = 1
        lblTopDate.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblTopUser
        ' 
        lblTopUser.Font = New Font("Segoe UI", 9.5F)
        lblTopUser.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        lblTopUser.Location = New Point(1040, 0)
        lblTopUser.Name = "lblTopUser"
        lblTopUser.Size = New Size(120, 60)
        lblTopUser.TabIndex = 2
        lblTopUser.Text = "[ Admin ]"
        lblTopUser.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        pnlSidebar.Controls.Add(pnlLogo)
        pnlSidebar.Controls.Add(btnNavDashboard)
        pnlSidebar.Controls.Add(btnNavAddRecord)
        pnlSidebar.Controls.Add(btnNavViewRecords)
        pnlSidebar.Controls.Add(btnNavReports)
        pnlSidebar.Controls.Add(btnNavSettings)
        pnlSidebar.Controls.Add(btnNavDevelopers)
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 60)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(220, 638)
        pnlSidebar.TabIndex = 1
        ' 
        ' pnlLogo
        ' 
        pnlLogo.BackColor = Color.FromArgb(CByte(140), CByte(10), CByte(10))
        pnlLogo.Controls.Add(lblSideTitle)
        pnlLogo.Controls.Add(lblSideSub)
        pnlLogo.Location = New Point(0, 0)
        pnlLogo.Name = "pnlLogo"
        pnlLogo.Size = New Size(220, 90)
        pnlLogo.TabIndex = 0
        ' 
        ' lblSideTitle
        ' 
        lblSideTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblSideTitle.ForeColor = Color.White
        lblSideTitle.Location = New Point(10, 16)
        lblSideTitle.Name = "lblSideTitle"
        lblSideTitle.Size = New Size(200, 32)
        lblSideTitle.TabIndex = 0
        lblSideTitle.Text = "BFP TUAO"
        lblSideTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSideSub
        ' 
        lblSideSub.Font = New Font("Segoe UI", 8F)
        lblSideSub.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(200))
        lblSideSub.Location = New Point(10, 52)
        lblSideSub.Name = "lblSideSub"
        lblSideSub.Size = New Size(200, 20)
        lblSideSub.TabIndex = 1
        lblSideSub.Text = "Fire Protection"
        lblSideSub.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnNavDashboard
        ' 
        btnNavDashboard.BackColor = Color.FromArgb(CByte(160), CByte(18), CByte(18))
        btnNavDashboard.Cursor = Cursors.Hand
        btnNavDashboard.FlatAppearance.BorderSize = 0
        btnNavDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(220), CByte(50), CByte(50))
        btnNavDashboard.FlatStyle = FlatStyle.Flat
        btnNavDashboard.Font = New Font("Segoe UI", 10F)
        btnNavDashboard.ForeColor = Color.FromArgb(CByte(255), CByte(220), CByte(220))
        btnNavDashboard.Location = New Point(0, 100)
        btnNavDashboard.Name = "btnNavDashboard"
        btnNavDashboard.Padding = New Padding(20, 0, 0, 0)
        btnNavDashboard.Size = New Size(220, 46)
        btnNavDashboard.TabIndex = 1
        btnNavDashboard.Text = "  Dashboard"
        btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnNavDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnNavAddRecord
        ' 
        btnNavAddRecord.BackColor = Color.FromArgb(CByte(160), CByte(18), CByte(18))
        btnNavAddRecord.Cursor = Cursors.Hand
        btnNavAddRecord.FlatAppearance.BorderSize = 0
        btnNavAddRecord.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(220), CByte(50), CByte(50))
        btnNavAddRecord.FlatStyle = FlatStyle.Flat
        btnNavAddRecord.Font = New Font("Segoe UI", 10F)
        btnNavAddRecord.ForeColor = Color.FromArgb(CByte(255), CByte(220), CByte(220))
        btnNavAddRecord.Location = New Point(0, 150)
        btnNavAddRecord.Name = "btnNavAddRecord"
        btnNavAddRecord.Padding = New Padding(20, 0, 0, 0)
        btnNavAddRecord.Size = New Size(220, 46)
        btnNavAddRecord.TabIndex = 2
        btnNavAddRecord.Text = "  Add Record"
        btnNavAddRecord.TextAlign = ContentAlignment.MiddleLeft
        btnNavAddRecord.UseVisualStyleBackColor = False
        ' 
        ' btnNavViewRecords
        ' 
        btnNavViewRecords.BackColor = Color.FromArgb(CByte(160), CByte(18), CByte(18))
        btnNavViewRecords.Cursor = Cursors.Hand
        btnNavViewRecords.FlatAppearance.BorderSize = 0
        btnNavViewRecords.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(220), CByte(50), CByte(50))
        btnNavViewRecords.FlatStyle = FlatStyle.Flat
        btnNavViewRecords.Font = New Font("Segoe UI", 10F)
        btnNavViewRecords.ForeColor = Color.FromArgb(CByte(255), CByte(220), CByte(220))
        btnNavViewRecords.Location = New Point(0, 200)
        btnNavViewRecords.Name = "btnNavViewRecords"
        btnNavViewRecords.Padding = New Padding(20, 0, 0, 0)
        btnNavViewRecords.Size = New Size(220, 46)
        btnNavViewRecords.TabIndex = 3
        btnNavViewRecords.Text = "  View Records"
        btnNavViewRecords.TextAlign = ContentAlignment.MiddleLeft
        btnNavViewRecords.UseVisualStyleBackColor = False
        ' 
        ' btnNavReports
        ' 
        btnNavReports.BackColor = Color.FromArgb(CByte(160), CByte(18), CByte(18))
        btnNavReports.Cursor = Cursors.Hand
        btnNavReports.FlatAppearance.BorderSize = 0
        btnNavReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(220), CByte(50), CByte(50))
        btnNavReports.FlatStyle = FlatStyle.Flat
        btnNavReports.Font = New Font("Segoe UI", 10F)
        btnNavReports.ForeColor = Color.FromArgb(CByte(255), CByte(220), CByte(220))
        btnNavReports.Location = New Point(0, 250)
        btnNavReports.Name = "btnNavReports"
        btnNavReports.Padding = New Padding(20, 0, 0, 0)
        btnNavReports.Size = New Size(220, 46)
        btnNavReports.TabIndex = 4
        btnNavReports.Text = "  Reports"
        btnNavReports.TextAlign = ContentAlignment.MiddleLeft
        btnNavReports.UseVisualStyleBackColor = False
        ' 
        ' btnNavSettings
        ' 
        btnNavSettings.BackColor = Color.FromArgb(CByte(160), CByte(18), CByte(18))
        btnNavSettings.Cursor = Cursors.Hand
        btnNavSettings.FlatAppearance.BorderSize = 0
        btnNavSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(220), CByte(50), CByte(50))
        btnNavSettings.FlatStyle = FlatStyle.Flat
        btnNavSettings.Font = New Font("Segoe UI", 10F)
        btnNavSettings.ForeColor = Color.FromArgb(CByte(255), CByte(220), CByte(220))
        btnNavSettings.Location = New Point(0, 300)
        btnNavSettings.Name = "btnNavSettings"
        btnNavSettings.Padding = New Padding(20, 0, 0, 0)
        btnNavSettings.Size = New Size(220, 46)
        btnNavSettings.TabIndex = 5
        btnNavSettings.Text = "  Settings"
        btnNavSettings.TextAlign = ContentAlignment.MiddleLeft
        btnNavSettings.UseVisualStyleBackColor = False
        ' 
        ' btnNavDevelopers
        ' 
        btnNavDevelopers.BackColor = Color.FromArgb(CByte(160), CByte(18), CByte(18))
        btnNavDevelopers.Cursor = Cursors.Hand
        btnNavDevelopers.FlatAppearance.BorderSize = 0
        btnNavDevelopers.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(220), CByte(50), CByte(50))
        btnNavDevelopers.FlatStyle = FlatStyle.Flat
        btnNavDevelopers.Font = New Font("Segoe UI", 10F)
        btnNavDevelopers.ForeColor = Color.FromArgb(CByte(255), CByte(220), CByte(220))
        btnNavDevelopers.Location = New Point(0, 350)
        btnNavDevelopers.Name = "btnNavDevelopers"
        btnNavDevelopers.Padding = New Padding(20, 0, 0, 0)
        btnNavDevelopers.Size = New Size(220, 46)
        btnNavDevelopers.TabIndex = 6
        btnNavDevelopers.Text = "  Developers"
        btnNavDevelopers.TextAlign = ContentAlignment.MiddleLeft
        btnNavDevelopers.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(120), CByte(10), CByte(10))
        btnLogout.Cursor = Cursors.Hand
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(30), CByte(30))
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 10F)
        btnLogout.ForeColor = Color.FromArgb(CByte(255), CByte(180), CByte(180))
        btnLogout.Location = New Point(0, 592)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(20, 0, 0, 0)
        btnLogout.Size = New Size(220, 46)
        btnLogout.TabIndex = 7
        btnLogout.Text = "  Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlPageContainer
        ' 
        pnlPageContainer.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        pnlPageContainer.Dock = DockStyle.Fill
        pnlPageContainer.Location = New Point(220, 60)
        pnlPageContainer.Name = "pnlPageContainer"
        pnlPageContainer.Size = New Size(978, 638)
        pnlPageContainer.TabIndex = 0
        ' 
        ' MainForm
        ' 
        BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        ClientSize = New Size(1198, 698)
        ControlBox = False
        Controls.Add(pnlPageContainer)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlTopBar)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MinimumSize = New Size(1200, 700)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BFP Tuao — Record Management Information System"
        pnlTopBar.ResumeLayout(False)
        pnlSidebar.ResumeLayout(False)
        pnlLogo.ResumeLayout(False)
        ResumeLayout(False)

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
