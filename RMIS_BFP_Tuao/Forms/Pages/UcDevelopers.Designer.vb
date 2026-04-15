<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcDevelopers
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
        pnlHeader = New Panel()
        lblPageTitle = New Label()
        lblPageSub = New Label()
        pnlDivider = New Panel()
        pnlAbout = New Panel()
        lblAboutTitle = New Label()
        lblAboutDivider = New Panel()
        lblAppName = New Label()
        lblAppDesc = New Label()
        lblVersion = New Label()
        lblVersionVal = New Label()
        lblBuiltWith = New Label()
        lblBuiltVal = New Label()
        pnlTeam = New Panel()
        lblTeamTitle = New Label()
        lblTeamDivider = New Panel()
        pnlDev1 = New Panel()
        lblDev1Name = New Label()
        lblDev1Role = New Label()
        pnlDev2 = New Panel()
        lblDev2Name = New Label()
        lblDev2Role = New Label()
        pnlDev3 = New Panel()
        lblDev3Name = New Label()
        lblDev3Role = New Label()
        pnlHeader.SuspendLayout()
        pnlAbout.SuspendLayout()
        pnlTeam.SuspendLayout()
        pnlDev1.SuspendLayout()
        pnlDev2.SuspendLayout()
        pnlDev3.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Controls.Add(lblPageSub)
        pnlHeader.Controls.Add(pnlDivider)
        pnlHeader.Location = New Point(24, 18)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(920, 88)
        pnlHeader.TabIndex = 0
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblPageTitle.Location = New Point(20, 12)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(700, 34)
        lblPageTitle.TabIndex = 0
        lblPageTitle.Text = "About the Developers"
        ' 
        ' lblPageSub
        ' 
        lblPageSub.Font = New Font("Segoe UI", 9F)
        lblPageSub.ForeColor = Color.Gray
        lblPageSub.Location = New Point(20, 46)
        lblPageSub.Name = "lblPageSub"
        lblPageSub.Size = New Size(700, 22)
        lblPageSub.TabIndex = 1
        lblPageSub.Text = "System information and development team behind RMIS — BFP Tuao."
        ' 
        ' pnlDivider
        ' 
        pnlDivider.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        pnlDivider.Location = New Point(20, 78)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(880, 3)
        pnlDivider.TabIndex = 2
        ' 
        ' pnlAbout
        ' 
        pnlAbout.BackColor = Color.White
        pnlAbout.Controls.Add(lblAboutTitle)
        pnlAbout.Controls.Add(lblAboutDivider)
        pnlAbout.Controls.Add(lblAppName)
        pnlAbout.Controls.Add(lblAppDesc)
        pnlAbout.Controls.Add(lblVersion)
        pnlAbout.Controls.Add(lblVersionVal)
        pnlAbout.Controls.Add(lblBuiltWith)
        pnlAbout.Controls.Add(lblBuiltVal)
        pnlAbout.Location = New Point(24, 120)
        pnlAbout.Name = "pnlAbout"
        pnlAbout.Size = New Size(430, 230)
        pnlAbout.TabIndex = 1
        ' 
        ' lblAboutTitle
        ' 
        lblAboutTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblAboutTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblAboutTitle.Location = New Point(16, 12)
        lblAboutTitle.Name = "lblAboutTitle"
        lblAboutTitle.Size = New Size(400, 30)
        lblAboutTitle.TabIndex = 0
        lblAboutTitle.Text = "Application Information"
        ' 
        ' lblAboutDivider
        ' 
        lblAboutDivider.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        lblAboutDivider.Location = New Point(16, 44)
        lblAboutDivider.Name = "lblAboutDivider"
        lblAboutDivider.Size = New Size(398, 1)
        lblAboutDivider.TabIndex = 1
        ' 
        ' lblAppName
        ' 
        lblAppName.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblAppName.ForeColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        lblAppName.Location = New Point(16, 54)
        lblAppName.Name = "lblAppName"
        lblAppName.Size = New Size(398, 30)
        lblAppName.TabIndex = 2
        lblAppName.Text = "RMIS — BFP Tuao"
        ' 
        ' lblAppDesc
        ' 
        lblAppDesc.Font = New Font("Segoe UI", 9F)
        lblAppDesc.ForeColor = Color.Gray
        lblAppDesc.Location = New Point(16, 86)
        lblAppDesc.Name = "lblAppDesc"
        lblAppDesc.Size = New Size(398, 44)
        lblAppDesc.TabIndex = 3
        lblAppDesc.Text = "Record Management Information System" & vbCrLf & "Bureau of Fire Protection — Tuao Fire Station"
        ' 
        ' lblVersion
        ' 
        lblVersion.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblVersion.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblVersion.Location = New Point(16, 142)
        lblVersion.Name = "lblVersion"
        lblVersion.Size = New Size(100, 22)
        lblVersion.TabIndex = 4
        lblVersion.Text = "Version:"
        ' 
        ' lblVersionVal
        ' 
        lblVersionVal.Font = New Font("Segoe UI", 9F)
        lblVersionVal.ForeColor = Color.Gray
        lblVersionVal.Location = New Point(120, 142)
        lblVersionVal.Name = "lblVersionVal"
        lblVersionVal.Size = New Size(280, 22)
        lblVersionVal.TabIndex = 5
        lblVersionVal.Text = "1.0.0 (Prototype)"
        ' 
        ' lblBuiltWith
        ' 
        lblBuiltWith.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblBuiltWith.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblBuiltWith.Location = New Point(16, 172)
        lblBuiltWith.Name = "lblBuiltWith"
        lblBuiltWith.Size = New Size(100, 22)
        lblBuiltWith.TabIndex = 6
        lblBuiltWith.Text = "Built With:"
        ' 
        ' lblBuiltVal
        ' 
        lblBuiltVal.Font = New Font("Segoe UI", 9F)
        lblBuiltVal.ForeColor = Color.Gray
        lblBuiltVal.Location = New Point(120, 172)
        lblBuiltVal.Name = "lblBuiltVal"
        lblBuiltVal.Size = New Size(280, 22)
        lblBuiltVal.TabIndex = 7
        lblBuiltVal.Text = "VB.NET / WinForms / .NET 8"
        ' 
        ' pnlTeam
        ' 
        pnlTeam.BackColor = Color.White
        pnlTeam.Controls.Add(lblTeamTitle)
        pnlTeam.Controls.Add(lblTeamDivider)
        pnlTeam.Controls.Add(pnlDev1)
        pnlTeam.Controls.Add(pnlDev2)
        pnlTeam.Controls.Add(pnlDev3)
        pnlTeam.Location = New Point(470, 120)
        pnlTeam.Name = "pnlTeam"
        pnlTeam.Size = New Size(430, 230)
        pnlTeam.TabIndex = 2
        ' 
        ' lblTeamTitle
        ' 
        lblTeamTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblTeamTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblTeamTitle.Location = New Point(16, 12)
        lblTeamTitle.Name = "lblTeamTitle"
        lblTeamTitle.Size = New Size(400, 30)
        lblTeamTitle.TabIndex = 0
        lblTeamTitle.Text = "Development Team"
        ' 
        ' lblTeamDivider
        ' 
        lblTeamDivider.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        lblTeamDivider.Location = New Point(16, 44)
        lblTeamDivider.Name = "lblTeamDivider"
        lblTeamDivider.Size = New Size(398, 1)
        lblTeamDivider.TabIndex = 1
        ' 
        ' pnlDev1
        ' 
        pnlDev1.BackColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        pnlDev1.Controls.Add(lblDev1Name)
        pnlDev1.Controls.Add(lblDev1Role)
        pnlDev1.Location = New Point(16, 54)
        pnlDev1.Name = "pnlDev1"
        pnlDev1.Size = New Size(398, 44)
        pnlDev1.TabIndex = 2
        ' 
        ' lblDev1Name
        ' 
        lblDev1Name.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblDev1Name.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblDev1Name.Location = New Point(12, 4)
        lblDev1Name.Name = "lblDev1Name"
        lblDev1Name.Size = New Size(280, 20)
        lblDev1Name.TabIndex = 0
        lblDev1Name.Text = "Developer 1"
        ' 
        ' lblDev1Role
        ' 
        lblDev1Role.Font = New Font("Segoe UI", 8.5F)
        lblDev1Role.ForeColor = Color.Gray
        lblDev1Role.Location = New Point(12, 24)
        lblDev1Role.Name = "lblDev1Role"
        lblDev1Role.Size = New Size(280, 18)
        lblDev1Role.TabIndex = 1
        lblDev1Role.Text = "System Architecture & UI Design"
        ' 
        ' pnlDev2
        ' 
        pnlDev2.BackColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        pnlDev2.Controls.Add(lblDev2Name)
        pnlDev2.Controls.Add(lblDev2Role)
        pnlDev2.Location = New Point(16, 106)
        pnlDev2.Name = "pnlDev2"
        pnlDev2.Size = New Size(398, 44)
        pnlDev2.TabIndex = 3
        ' 
        ' lblDev2Name
        ' 
        lblDev2Name.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblDev2Name.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblDev2Name.Location = New Point(12, 4)
        lblDev2Name.Name = "lblDev2Name"
        lblDev2Name.Size = New Size(280, 20)
        lblDev2Name.TabIndex = 0
        lblDev2Name.Text = "Developer 2"
        ' 
        ' lblDev2Role
        ' 
        lblDev2Role.Font = New Font("Segoe UI", 8.5F)
        lblDev2Role.ForeColor = Color.Gray
        lblDev2Role.Location = New Point(12, 24)
        lblDev2Role.Name = "lblDev2Role"
        lblDev2Role.Size = New Size(280, 18)
        lblDev2Role.TabIndex = 1
        lblDev2Role.Text = "Database & Records Module"
        ' 
        ' pnlDev3
        ' 
        pnlDev3.BackColor = Color.FromArgb(CByte(248), CByte(248), CByte(248))
        pnlDev3.Controls.Add(lblDev3Name)
        pnlDev3.Controls.Add(lblDev3Role)
        pnlDev3.Location = New Point(16, 158)
        pnlDev3.Name = "pnlDev3"
        pnlDev3.Size = New Size(398, 44)
        pnlDev3.TabIndex = 4
        ' 
        ' lblDev3Name
        ' 
        lblDev3Name.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblDev3Name.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblDev3Name.Location = New Point(12, 4)
        lblDev3Name.Name = "lblDev3Name"
        lblDev3Name.Size = New Size(280, 20)
        lblDev3Name.TabIndex = 0
        lblDev3Name.Text = "Developer 3"
        ' 
        ' lblDev3Role
        ' 
        lblDev3Role.Font = New Font("Segoe UI", 8.5F)
        lblDev3Role.ForeColor = Color.Gray
        lblDev3Role.Location = New Point(12, 24)
        lblDev3Role.Name = "lblDev3Role"
        lblDev3Role.Size = New Size(280, 18)
        lblDev3Role.TabIndex = 1
        lblDev3Role.Text = "Reports & Documentation"
        ' 
        ' UcDevelopers
        ' 
        BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        Controls.Add(pnlHeader)
        Controls.Add(pnlAbout)
        Controls.Add(pnlTeam)
        Name = "UcDevelopers"
        Size = New Size(970, 569)
        pnlHeader.ResumeLayout(False)
        pnlAbout.ResumeLayout(False)
        pnlTeam.ResumeLayout(False)
        pnlDev1.ResumeLayout(False)
        pnlDev2.ResumeLayout(False)
        pnlDev3.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader      As Panel
    Friend WithEvents pnlDivider     As Panel
    Friend WithEvents lblPageTitle   As Label
    Friend WithEvents lblPageSub     As Label
    Friend WithEvents pnlAbout       As Panel
    Friend WithEvents lblAboutTitle  As Label
    Friend WithEvents lblAboutDivider As Panel
    Friend WithEvents lblAppName     As Label
    Friend WithEvents lblAppDesc     As Label
    Friend WithEvents lblVersion     As Label
    Friend WithEvents lblVersionVal  As Label
    Friend WithEvents lblBuiltWith   As Label
    Friend WithEvents lblBuiltVal    As Label
    Friend WithEvents pnlTeam        As Panel
    Friend WithEvents lblTeamTitle   As Label
    Friend WithEvents lblTeamDivider As Panel
    Friend WithEvents pnlDev1        As Panel
    Friend WithEvents lblDev1Name    As Label
    Friend WithEvents lblDev1Role    As Label
    Friend WithEvents pnlDev2        As Panel
    Friend WithEvents lblDev2Name    As Label
    Friend WithEvents lblDev2Role    As Label
    Friend WithEvents pnlDev3        As Panel
    Friend WithEvents lblDev3Name    As Label
    Friend WithEvents lblDev3Role    As Label

End Class
