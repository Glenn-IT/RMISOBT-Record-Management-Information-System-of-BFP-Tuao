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

        pnlHeader     = New Panel()
        pnlDivider    = New Panel()
        lblPageTitle  = New Label()
        lblPageSub    = New Label()
        pnlAbout      = New Panel()
        lblAboutTitle = New Label()
        lblAboutDivider = New Panel()
        lblAppName    = New Label()
        lblAppDesc    = New Label()
        lblVersion    = New Label()
        lblVersionVal = New Label()
        lblBuiltWith  = New Label()
        lblBuiltVal   = New Label()
        pnlTeam       = New Panel()
        lblTeamTitle  = New Label()
        lblTeamDivider = New Panel()
        pnlDev1       = New Panel()
        lblDev1Name   = New Label()
        lblDev1Role   = New Label()
        pnlDev2       = New Panel()
        lblDev2Name   = New Label()
        lblDev2Role   = New Label()
        pnlDev3       = New Panel()
        lblDev3Name   = New Label()
        lblDev3Role   = New Label()

        pnlHeader.SuspendLayout()
        pnlAbout.SuspendLayout()
        pnlTeam.SuspendLayout()
        pnlDev1.SuspendLayout()
        pnlDev2.SuspendLayout()
        pnlDev3.SuspendLayout()
        Me.SuspendLayout()

        ' ????????????????????????????????????????????????????????
        ' pnlHeader
        ' ????????????????????????????????????????????????????????
        pnlHeader.BackColor = Color.White
        pnlHeader.Size = New Size(920, 88)
        pnlHeader.Location = New Point(24, 18)
        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Controls.Add(lblPageSub)
        pnlHeader.Controls.Add(pnlDivider)

        lblPageTitle.Text = "About the Developers"
        lblPageTitle.Font = New Font("Segoe UI", 15, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.FromArgb(30, 30, 30)
        lblPageTitle.AutoSize = False
        lblPageTitle.Size = New Size(700, 34)
        lblPageTitle.Location = New Point(20, 12)

        lblPageSub.Text = "System information and development team behind RMIS — BFP Tuao."
        lblPageSub.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblPageSub.ForeColor = Color.Gray
        lblPageSub.AutoSize = False
        lblPageSub.Size = New Size(700, 22)
        lblPageSub.Location = New Point(20, 46)

        pnlDivider.BackColor = Color.FromArgb(180, 20, 20)
        pnlDivider.Size = New Size(880, 3)
        pnlDivider.Location = New Point(20, 78)

        ' ????????????????????????????????????????????????????????
        ' pnlAbout — application info
        ' ????????????????????????????????????????????????????????
        pnlAbout.BackColor = Color.White
        pnlAbout.Size = New Size(430, 230)
        pnlAbout.Location = New Point(24, 120)
        pnlAbout.Controls.Add(lblAboutTitle)
        pnlAbout.Controls.Add(lblAboutDivider)
        pnlAbout.Controls.Add(lblAppName)
        pnlAbout.Controls.Add(lblAppDesc)
        pnlAbout.Controls.Add(lblVersion)
        pnlAbout.Controls.Add(lblVersionVal)
        pnlAbout.Controls.Add(lblBuiltWith)
        pnlAbout.Controls.Add(lblBuiltVal)

        lblAboutTitle.Text = "Application Information"
        lblAboutTitle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        lblAboutTitle.ForeColor = Color.FromArgb(30, 30, 30)
        lblAboutTitle.AutoSize = False
        lblAboutTitle.Size = New Size(400, 30)
        lblAboutTitle.Location = New Point(16, 12)

        lblAboutDivider.BackColor = Color.FromArgb(220, 220, 220)
        lblAboutDivider.Size = New Size(398, 1)
        lblAboutDivider.Location = New Point(16, 44)

        lblAppName.Text = "RMIS — BFP Tuao"
        lblAppName.Font = New Font("Segoe UI", 13, FontStyle.Bold)
        lblAppName.ForeColor = Color.FromArgb(180, 20, 20)
        lblAppName.AutoSize = False
        lblAppName.Size = New Size(398, 30)
        lblAppName.Location = New Point(16, 54)

        lblAppDesc.Text = "Record Management Information System" & Environment.NewLine &
                          "Bureau of Fire Protection — Tuao Fire Station"
        lblAppDesc.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblAppDesc.ForeColor = Color.Gray
        lblAppDesc.AutoSize = False
        lblAppDesc.Size = New Size(398, 44)
        lblAppDesc.Location = New Point(16, 86)

        lblVersion.Text = "Version:"
        lblVersion.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblVersion.ForeColor = Color.FromArgb(70, 70, 70)
        lblVersion.AutoSize = False
        lblVersion.Size = New Size(100, 22)
        lblVersion.Location = New Point(16, 142)

        lblVersionVal.Text = "1.0.0 (Prototype)"
        lblVersionVal.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblVersionVal.ForeColor = Color.Gray
        lblVersionVal.AutoSize = False
        lblVersionVal.Size = New Size(280, 22)
        lblVersionVal.Location = New Point(120, 142)

        lblBuiltWith.Text = "Built With:"
        lblBuiltWith.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblBuiltWith.ForeColor = Color.FromArgb(70, 70, 70)
        lblBuiltWith.AutoSize = False
        lblBuiltWith.Size = New Size(100, 22)
        lblBuiltWith.Location = New Point(16, 172)

        lblBuiltVal.Text = "VB.NET / WinForms / .NET 8"
        lblBuiltVal.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblBuiltVal.ForeColor = Color.Gray
        lblBuiltVal.AutoSize = False
        lblBuiltVal.Size = New Size(280, 22)
        lblBuiltVal.Location = New Point(120, 172)

        ' ????????????????????????????????????????????????????????
        ' pnlTeam — developer cards
        ' ????????????????????????????????????????????????????????
        pnlTeam.BackColor = Color.White
        pnlTeam.Size = New Size(430, 230)
        pnlTeam.Location = New Point(470, 120)
        pnlTeam.Controls.Add(lblTeamTitle)
        pnlTeam.Controls.Add(lblTeamDivider)
        pnlTeam.Controls.Add(pnlDev1)
        pnlTeam.Controls.Add(pnlDev2)
        pnlTeam.Controls.Add(pnlDev3)

        lblTeamTitle.Text = "Development Team"
        lblTeamTitle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        lblTeamTitle.ForeColor = Color.FromArgb(30, 30, 30)
        lblTeamTitle.AutoSize = False
        lblTeamTitle.Size = New Size(400, 30)
        lblTeamTitle.Location = New Point(16, 12)

        lblTeamDivider.BackColor = Color.FromArgb(220, 220, 220)
        lblTeamDivider.Size = New Size(398, 1)
        lblTeamDivider.Location = New Point(16, 44)

        Dim MakeDev As Action(Of Panel, Label, Label, Integer, String, String) =
            Sub(pnl As Panel, nm As Label, rl As Label,
                y As Integer, nameText As String, roleText As String)
                pnl.BackColor = Color.FromArgb(248, 248, 248)
                pnl.Size = New Size(398, 44)
                pnl.Location = New Point(16, y)
                nm.Text = nameText
                nm.Font = New Font("Segoe UI", 9.5, FontStyle.Bold)
                nm.ForeColor = Color.FromArgb(30, 30, 30)
                nm.AutoSize = False
                nm.Size = New Size(280, 20)
                nm.Location = New Point(12, 4)
                rl.Text = roleText
                rl.Font = New Font("Segoe UI", 8.5, FontStyle.Regular)
                rl.ForeColor = Color.Gray
                rl.AutoSize = False
                rl.Size = New Size(280, 18)
                rl.Location = New Point(12, 24)
                pnl.Controls.Add(nm)
                pnl.Controls.Add(rl)
            End Sub

        MakeDev(pnlDev1, lblDev1Name, lblDev1Role, 54,  "Glenn — Lead Developer",    "System Architecture & UI Design")
        MakeDev(pnlDev2, lblDev2Name, lblDev2Role, 106, "Developer 2",               "Database & Records Module")
        MakeDev(pnlDev3, lblDev3Name, lblDev3Role, 158, "Developer 3",               "Reports & Documentation")

        Me.BackColor = Color.FromArgb(240, 242, 245)
        Me.Controls.Add(pnlHeader)
        Me.Controls.Add(pnlAbout)
        Me.Controls.Add(pnlTeam)

        pnlDev3.ResumeLayout(False)
        pnlDev2.ResumeLayout(False)
        pnlDev1.ResumeLayout(False)
        pnlTeam.ResumeLayout(False)
        pnlAbout.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

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
