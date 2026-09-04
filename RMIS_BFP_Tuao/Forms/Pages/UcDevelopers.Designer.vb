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
        lblStation = New Label()
        lblStationVal = New Label()
        pnlTeam = New Panel()
        lblTeamTitle = New Label()
        lblTeamDivider = New Panel()
        pnlDev1 = New Panel()
        pnlDev1Bar = New Panel()
        picDev1 = New PictureBox()
        btnDev1Photo = New Button()
        lblDev1Name = New Label()
        lblDev1Course = New Label()
        lblDev1Contact = New Label()
        lblDev1Email = New Label()
        lblDev1Hint = New Label()
        pnlDev2 = New Panel()
        pnlDev2Bar = New Panel()
        picDev2 = New PictureBox()
        btnDev2Photo = New Button()
        lblDev2Name = New Label()
        lblDev2Course = New Label()
        lblDev2Contact = New Label()
        lblDev2Email = New Label()
        lblDev2Hint = New Label()
        pnlHeader.SuspendLayout()
        pnlAbout.SuspendLayout()
        pnlTeam.SuspendLayout()
        pnlDev1.SuspendLayout()
        CType(picDev1, ComponentModel.ISupportInitialize).BeginInit()
        pnlDev2.SuspendLayout()
        CType(picDev2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
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
        lblPageSub.Text = "System information and development team behind RMIS - BFP Tuao."
        ' 
        ' pnlDivider
        ' 
        pnlDivider.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
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
        pnlAbout.Controls.Add(lblStation)
        pnlAbout.Controls.Add(lblStationVal)
        pnlAbout.Location = New Point(24, 120)
        pnlAbout.Name = "pnlAbout"
        pnlAbout.Size = New Size(395, 430)
        pnlAbout.TabIndex = 1
        ' 
        ' lblAboutTitle
        ' 
        lblAboutTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblAboutTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblAboutTitle.Location = New Point(16, 12)
        lblAboutTitle.Name = "lblAboutTitle"
        lblAboutTitle.Size = New Size(360, 30)
        lblAboutTitle.TabIndex = 0
        lblAboutTitle.Text = "Application Information"
        ' 
        ' lblAboutDivider
        ' 
        lblAboutDivider.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblAboutDivider.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        lblAboutDivider.Location = New Point(16, 44)
        lblAboutDivider.Name = "lblAboutDivider"
        lblAboutDivider.Size = New Size(363, 1)
        lblAboutDivider.TabIndex = 1
        ' 
        ' lblAppName
        ' 
        lblAppName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblAppName.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblAppName.ForeColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        lblAppName.Location = New Point(16, 54)
        lblAppName.Name = "lblAppName"
        lblAppName.Size = New Size(363, 30)
        lblAppName.TabIndex = 2
        lblAppName.Text = "RMIS - BFP Tuao"
        ' 
        ' lblAppDesc
        ' 
        lblAppDesc.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblAppDesc.Font = New Font("Segoe UI", 9F)
        lblAppDesc.ForeColor = Color.Gray
        lblAppDesc.Location = New Point(16, 86)
        lblAppDesc.Name = "lblAppDesc"
        lblAppDesc.Size = New Size(363, 44)
        lblAppDesc.TabIndex = 3
        lblAppDesc.Text = "Record Management Information System" & vbCrLf & "Bureau of Fire Protection - Tuao Fire Station"
        ' 
        ' lblVersion
        ' 
        lblVersion.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblVersion.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblVersion.Location = New Point(16, 150)
        lblVersion.Name = "lblVersion"
        lblVersion.Size = New Size(100, 22)
        lblVersion.TabIndex = 4
        lblVersion.Text = "Version:"
        ' 
        ' lblVersionVal
        ' 
        lblVersionVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblVersionVal.Font = New Font("Segoe UI", 9F)
        lblVersionVal.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        lblVersionVal.Location = New Point(120, 150)
        lblVersionVal.Name = "lblVersionVal"
        lblVersionVal.Size = New Size(259, 22)
        lblVersionVal.TabIndex = 5
        lblVersionVal.Text = "1.0.0 (Prototype)"
        ' 
        ' lblBuiltWith
        ' 
        lblBuiltWith.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblBuiltWith.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblBuiltWith.Location = New Point(16, 185)
        lblBuiltWith.Name = "lblBuiltWith"
        lblBuiltWith.Size = New Size(100, 22)
        lblBuiltWith.TabIndex = 6
        lblBuiltWith.Text = "Built With:"
        ' 
        ' lblBuiltVal
        ' 
        lblBuiltVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblBuiltVal.Font = New Font("Segoe UI", 9F)
        lblBuiltVal.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        lblBuiltVal.Location = New Point(120, 185)
        lblBuiltVal.Name = "lblBuiltVal"
        lblBuiltVal.Size = New Size(259, 22)
        lblBuiltVal.TabIndex = 7
        lblBuiltVal.Text = "VB.NET / WinForms / .NET 8 / SQL Server"
        ' 
        ' lblStation
        ' 
        lblStation.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblStation.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblStation.Location = New Point(16, 220)
        lblStation.Name = "lblStation"
        lblStation.Size = New Size(100, 22)
        lblStation.TabIndex = 8
        lblStation.Text = "Station:"
        ' 
        ' lblStationVal
        ' 
        lblStationVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblStationVal.Font = New Font("Segoe UI", 9F)
        lblStationVal.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        lblStationVal.Location = New Point(120, 220)
        lblStationVal.Name = "lblStationVal"
        lblStationVal.Size = New Size(259, 22)
        lblStationVal.TabIndex = 9
        lblStationVal.Text = "BFP Tuao Fire Station, Cagayan"
        ' 
        ' pnlTeam
        ' 
        pnlTeam.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlTeam.BackColor = Color.White
        pnlTeam.Controls.Add(lblTeamTitle)
        pnlTeam.Controls.Add(lblTeamDivider)
        pnlTeam.Controls.Add(pnlDev1)
        pnlTeam.Controls.Add(pnlDev2)
        pnlTeam.Location = New Point(440, 120)
        pnlTeam.Name = "pnlTeam"
        pnlTeam.Size = New Size(504, 430)
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
        lblTeamDivider.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTeamDivider.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        lblTeamDivider.Location = New Point(16, 44)
        lblTeamDivider.Name = "lblTeamDivider"
        lblTeamDivider.Size = New Size(472, 1)
        lblTeamDivider.TabIndex = 1
        ' 
        ' pnlDev1
        ' 
        pnlDev1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDev1.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        pnlDev1.Controls.Add(pnlDev1Bar)
        pnlDev1.Controls.Add(picDev1)
        pnlDev1.Controls.Add(btnDev1Photo)
        pnlDev1.Controls.Add(lblDev1Name)
        pnlDev1.Controls.Add(lblDev1Course)
        pnlDev1.Controls.Add(lblDev1Contact)
        pnlDev1.Controls.Add(lblDev1Email)
        pnlDev1.Controls.Add(lblDev1Hint)
        pnlDev1.Location = New Point(16, 54)
        pnlDev1.Name = "pnlDev1"
        pnlDev1.Size = New Size(472, 172)
        pnlDev1.TabIndex = 2
        ' 
        ' pnlDev1Bar
        ' 
        pnlDev1Bar.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        pnlDev1Bar.Dock = DockStyle.Left
        pnlDev1Bar.Location = New Point(0, 0)
        pnlDev1Bar.Name = "pnlDev1Bar"
        pnlDev1Bar.Size = New Size(5, 172)
        pnlDev1Bar.TabIndex = 4
        ' 
        ' picDev1
        ' 
        picDev1.BackColor = Color.FromArgb(CByte(235), CByte(238), CByte(242))
        picDev1.BorderStyle = BorderStyle.FixedSingle
        picDev1.Cursor = Cursors.Hand
        picDev1.Location = New Point(15, 12)
        picDev1.Name = "picDev1"
        picDev1.Size = New Size(100, 115)
        picDev1.SizeMode = PictureBoxSizeMode.Zoom
        picDev1.TabIndex = 5
        picDev1.TabStop = False
        ' 
        ' btnDev1Photo
        ' 
        btnDev1Photo.BackColor = Color.FromArgb(CByte(225), CByte(230), CByte(235))
        btnDev1Photo.Cursor = Cursors.Hand
        btnDev1Photo.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(205), CByte(210))
        btnDev1Photo.FlatStyle = FlatStyle.Flat
        btnDev1Photo.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        btnDev1Photo.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        btnDev1Photo.Location = New Point(15, 133)
        btnDev1Photo.Name = "btnDev1Photo"
        btnDev1Photo.Size = New Size(100, 26)
        btnDev1Photo.TabIndex = 6
        btnDev1Photo.Text = "📷 Photo"
        btnDev1Photo.UseVisualStyleBackColor = False
        ' 
        ' lblDev1Name
        ' 
        lblDev1Name.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDev1Name.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblDev1Name.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblDev1Name.Location = New Point(126, 12)
        lblDev1Name.Name = "lblDev1Name"
        lblDev1Name.Size = New Size(335, 24)
        lblDev1Name.TabIndex = 0
        lblDev1Name.Text = "Angelika Bangan"
        ' 
        ' lblDev1Course
        ' 
        lblDev1Course.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDev1Course.Font = New Font("Segoe UI", 9.5F)
        lblDev1Course.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblDev1Course.Location = New Point(126, 40)
        lblDev1Course.Name = "lblDev1Course"
        lblDev1Course.Size = New Size(335, 20)
        lblDev1Course.TabIndex = 1
        lblDev1Course.Text = "Course: BSIT"
        ' 
        ' lblDev1Contact
        ' 
        lblDev1Contact.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDev1Contact.Font = New Font("Segoe UI", 9.5F)
        lblDev1Contact.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblDev1Contact.Location = New Point(126, 65)
        lblDev1Contact.Name = "lblDev1Contact"
        lblDev1Contact.Size = New Size(335, 20)
        lblDev1Contact.TabIndex = 2
        lblDev1Contact.Text = "Contact Number: 09533416197"
        ' 
        ' lblDev1Email
        ' 
        lblDev1Email.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDev1Email.Font = New Font("Segoe UI", 9.5F)
        lblDev1Email.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblDev1Email.Location = New Point(126, 90)
        lblDev1Email.Name = "lblDev1Email"
        lblDev1Email.Size = New Size(335, 20)
        lblDev1Email.TabIndex = 3
        lblDev1Email.Text = "Gmail Address: angelikabangan19@gmail.com"
        ' 
        ' lblDev1Hint
        ' 
        lblDev1Hint.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDev1Hint.Font = New Font("Segoe UI", 8F)
        lblDev1Hint.ForeColor = Color.FromArgb(CByte(130), CByte(130), CByte(130))
        lblDev1Hint.Location = New Point(126, 116)
        lblDev1Hint.Name = "lblDev1Hint"
        lblDev1Hint.Size = New Size(335, 45)
        lblDev1Hint.TabIndex = 7
        lblDev1Hint.Text = "Click photo or 'Photo' button to set/change picture."
        ' 
        ' pnlDev2
        ' 
        pnlDev2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDev2.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        pnlDev2.Controls.Add(pnlDev2Bar)
        pnlDev2.Controls.Add(picDev2)
        pnlDev2.Controls.Add(btnDev2Photo)
        pnlDev2.Controls.Add(lblDev2Name)
        pnlDev2.Controls.Add(lblDev2Course)
        pnlDev2.Controls.Add(lblDev2Contact)
        pnlDev2.Controls.Add(lblDev2Email)
        pnlDev2.Controls.Add(lblDev2Hint)
        pnlDev2.Location = New Point(16, 238)
        pnlDev2.Name = "pnlDev2"
        pnlDev2.Size = New Size(472, 172)
        pnlDev2.TabIndex = 3
        ' 
        ' pnlDev2Bar
        ' 
        pnlDev2Bar.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        pnlDev2Bar.Dock = DockStyle.Left
        pnlDev2Bar.Location = New Point(0, 0)
        pnlDev2Bar.Name = "pnlDev2Bar"
        pnlDev2Bar.Size = New Size(5, 172)
        pnlDev2Bar.TabIndex = 4
        ' 
        ' picDev2
        ' 
        picDev2.BackColor = Color.FromArgb(CByte(235), CByte(238), CByte(242))
        picDev2.BorderStyle = BorderStyle.FixedSingle
        picDev2.Cursor = Cursors.Hand
        picDev2.Location = New Point(15, 12)
        picDev2.Name = "picDev2"
        picDev2.Size = New Size(100, 115)
        picDev2.SizeMode = PictureBoxSizeMode.Zoom
        picDev2.TabIndex = 5
        picDev2.TabStop = False
        ' 
        ' btnDev2Photo
        ' 
        btnDev2Photo.BackColor = Color.FromArgb(CByte(225), CByte(230), CByte(235))
        btnDev2Photo.Cursor = Cursors.Hand
        btnDev2Photo.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(205), CByte(210))
        btnDev2Photo.FlatStyle = FlatStyle.Flat
        btnDev2Photo.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        btnDev2Photo.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        btnDev2Photo.Location = New Point(15, 133)
        btnDev2Photo.Name = "btnDev2Photo"
        btnDev2Photo.Size = New Size(100, 26)
        btnDev2Photo.TabIndex = 6
        btnDev2Photo.Text = "📷 Photo"
        btnDev2Photo.UseVisualStyleBackColor = False
        ' 
        ' lblDev2Name
        ' 
        lblDev2Name.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDev2Name.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblDev2Name.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblDev2Name.Location = New Point(126, 12)
        lblDev2Name.Name = "lblDev2Name"
        lblDev2Name.Size = New Size(335, 24)
        lblDev2Name.TabIndex = 0
        lblDev2Name.Text = "Ricky Paat"
        ' 
        ' lblDev2Course
        ' 
        lblDev2Course.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDev2Course.Font = New Font("Segoe UI", 9.5F)
        lblDev2Course.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblDev2Course.Location = New Point(126, 40)
        lblDev2Course.Name = "lblDev2Course"
        lblDev2Course.Size = New Size(335, 20)
        lblDev2Course.TabIndex = 1
        lblDev2Course.Text = "Course: BSIT"
        ' 
        ' lblDev2Contact
        ' 
        lblDev2Contact.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDev2Contact.Font = New Font("Segoe UI", 9.5F)
        lblDev2Contact.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblDev2Contact.Location = New Point(126, 65)
        lblDev2Contact.Name = "lblDev2Contact"
        lblDev2Contact.Size = New Size(335, 20)
        lblDev2Contact.TabIndex = 2
        lblDev2Contact.Text = "Contact Number: 09615344796"
        ' 
        ' lblDev2Email
        ' 
        lblDev2Email.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDev2Email.Font = New Font("Segoe UI", 9.5F)
        lblDev2Email.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblDev2Email.Location = New Point(126, 90)
        lblDev2Email.Name = "lblDev2Email"
        lblDev2Email.Size = New Size(335, 20)
        lblDev2Email.TabIndex = 3
        lblDev2Email.Text = "Gmail Address: rickypaat6@gmail.com"
        ' 
        ' lblDev2Hint
        ' 
        lblDev2Hint.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDev2Hint.Font = New Font("Segoe UI", 8F)
        lblDev2Hint.ForeColor = Color.FromArgb(CByte(130), CByte(130), CByte(130))
        lblDev2Hint.Location = New Point(126, 116)
        lblDev2Hint.Name = "lblDev2Hint"
        lblDev2Hint.Size = New Size(335, 45)
        lblDev2Hint.TabIndex = 7
        lblDev2Hint.Text = "Click photo or 'Photo' button to set/change picture."
        ' 
        ' UcDevelopers
        ' 
        BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        Controls.Add(pnlHeader)
        Controls.Add(pnlAbout)
        Controls.Add(pnlTeam)
        Font = New Font("Segoe UI", 9F)
        AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        Name = "UcDevelopers"
        Size = New Size(970, 569)
        pnlHeader.ResumeLayout(False)
        pnlAbout.ResumeLayout(False)
        pnlTeam.ResumeLayout(False)
        pnlDev1.ResumeLayout(False)
        CType(picDev1, ComponentModel.ISupportInitialize).EndInit()
        pnlDev2.ResumeLayout(False)
        CType(picDev2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader       As Panel
    Friend WithEvents pnlDivider      As Panel
    Friend WithEvents lblPageTitle    As Label
    Friend WithEvents lblPageSub      As Label
    Friend WithEvents pnlAbout        As Panel
    Friend WithEvents lblAboutTitle   As Label
    Friend WithEvents lblAboutDivider As Panel
    Friend WithEvents lblAppName      As Label
    Friend WithEvents lblAppDesc      As Label
    Friend WithEvents lblVersion      As Label
    Friend WithEvents lblVersionVal   As Label
    Friend WithEvents lblBuiltWith    As Label
    Friend WithEvents lblBuiltVal     As Label
    Friend WithEvents lblStation      As Label
    Friend WithEvents lblStationVal   As Label
    Friend WithEvents pnlTeam         As Panel
    Friend WithEvents lblTeamTitle    As Label
    Friend WithEvents lblTeamDivider  As Panel
    Friend WithEvents pnlDev1         As Panel
    Friend WithEvents pnlDev1Bar      As Panel
    Friend WithEvents picDev1         As PictureBox
    Friend WithEvents btnDev1Photo    As Button
    Friend WithEvents lblDev1Name     As Label
    Friend WithEvents lblDev1Course   As Label
    Friend WithEvents lblDev1Contact  As Label
    Friend WithEvents lblDev1Email    As Label
    Friend WithEvents lblDev1Hint     As Label
    Friend WithEvents pnlDev2         As Panel
    Friend WithEvents pnlDev2Bar      As Panel
    Friend WithEvents picDev2         As PictureBox
    Friend WithEvents btnDev2Photo    As Button
    Friend WithEvents lblDev2Name     As Label
    Friend WithEvents lblDev2Course   As Label
    Friend WithEvents lblDev2Contact  As Label
    Friend WithEvents lblDev2Email    As Label
    Friend WithEvents lblDev2Hint     As Label
End Class

