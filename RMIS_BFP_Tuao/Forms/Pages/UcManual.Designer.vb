<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcManual
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
        pnlTopics = New Panel()
        lblTopicsTitle = New Label()
        lblTopicsDivider = New Panel()
        btnTopicOverview = New Button()
        btnTopicDashboard = New Button()
        btnTopicAddRecord = New Button()
        btnTopicViewRecords = New Button()
        btnTopicReports = New Button()
        btnTopicSettings = New Button()
        btnTopicDevelopers = New Button()
        pnlContent = New Panel()
        lblContentTopic = New Label()
        lblContentDivider = New Panel()
        rtbContent = New RichTextBox()
        pnlHeader.SuspendLayout()
        pnlTopics.SuspendLayout()
        pnlContent.SuspendLayout()
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
        lblPageTitle.Text = "System User Manual & Guide"
        ' 
        ' lblPageSub
        ' 
        lblPageSub.Font = New Font("Segoe UI", 9F)
        lblPageSub.ForeColor = Color.Gray
        lblPageSub.Location = New Point(20, 46)
        lblPageSub.Name = "lblPageSub"
        lblPageSub.Size = New Size(700, 22)
        lblPageSub.TabIndex = 1
        lblPageSub.Text = "Step-by-step instructions and guidelines for operating RMIS - BFP Tuao."
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
        ' pnlTopics
        ' 
        pnlTopics.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnlTopics.BackColor = Color.White
        pnlTopics.Controls.Add(btnTopicDevelopers)
        pnlTopics.Controls.Add(btnTopicSettings)
        pnlTopics.Controls.Add(btnTopicReports)
        pnlTopics.Controls.Add(btnTopicViewRecords)
        pnlTopics.Controls.Add(btnTopicAddRecord)
        pnlTopics.Controls.Add(btnTopicDashboard)
        pnlTopics.Controls.Add(btnTopicOverview)
        pnlTopics.Controls.Add(lblTopicsDivider)
        pnlTopics.Controls.Add(lblTopicsTitle)
        pnlTopics.Location = New Point(24, 120)
        pnlTopics.Name = "pnlTopics"
        pnlTopics.Size = New Size(250, 430)
        pnlTopics.TabIndex = 1
        ' 
        ' lblTopicsTitle
        ' 
        lblTopicsTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblTopicsTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblTopicsTitle.Location = New Point(16, 12)
        lblTopicsTitle.Name = "lblTopicsTitle"
        lblTopicsTitle.Size = New Size(220, 30)
        lblTopicsTitle.TabIndex = 0
        lblTopicsTitle.Text = "Guide Modules"
        ' 
        ' lblTopicsDivider
        ' 
        lblTopicsDivider.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTopicsDivider.BackColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        lblTopicsDivider.Location = New Point(16, 44)
        lblTopicsDivider.Name = "lblTopicsDivider"
        lblTopicsDivider.Size = New Size(218, 1)
        lblTopicsDivider.TabIndex = 1
        ' 
        ' btnTopicOverview
        ' 
        btnTopicOverview.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnTopicOverview.Cursor = Cursors.Hand
        btnTopicOverview.FlatAppearance.BorderSize = 0
        btnTopicOverview.FlatStyle = FlatStyle.Flat
        btnTopicOverview.Font = New Font("Segoe UI", 9.5F)
        btnTopicOverview.ImageAlign = ContentAlignment.MiddleLeft
        btnTopicOverview.Location = New Point(12, 54)
        btnTopicOverview.Name = "btnTopicOverview"
        btnTopicOverview.Padding = New Padding(8, 0, 0, 0)
        btnTopicOverview.Size = New Size(226, 42)
        btnTopicOverview.TabIndex = 2
        btnTopicOverview.Text = "📖  1. System Overview"
        btnTopicOverview.TextAlign = ContentAlignment.MiddleLeft
        btnTopicOverview.UseVisualStyleBackColor = True
        ' 
        ' btnTopicDashboard
        ' 
        btnTopicDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnTopicDashboard.Cursor = Cursors.Hand
        btnTopicDashboard.FlatAppearance.BorderSize = 0
        btnTopicDashboard.FlatStyle = FlatStyle.Flat
        btnTopicDashboard.Font = New Font("Segoe UI", 9.5F)
        btnTopicDashboard.Location = New Point(12, 102)
        btnTopicDashboard.Name = "btnTopicDashboard"
        btnTopicDashboard.Padding = New Padding(8, 0, 0, 0)
        btnTopicDashboard.Size = New Size(226, 42)
        btnTopicDashboard.TabIndex = 3
        btnTopicDashboard.Text = "📊  2. Dashboard"
        btnTopicDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnTopicDashboard.UseVisualStyleBackColor = True
        ' 
        ' btnTopicAddRecord
        ' 
        btnTopicAddRecord.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnTopicAddRecord.Cursor = Cursors.Hand
        btnTopicAddRecord.FlatAppearance.BorderSize = 0
        btnTopicAddRecord.FlatStyle = FlatStyle.Flat
        btnTopicAddRecord.Font = New Font("Segoe UI", 9.5F)
        btnTopicAddRecord.Location = New Point(12, 150)
        btnTopicAddRecord.Name = "btnTopicAddRecord"
        btnTopicAddRecord.Padding = New Padding(8, 0, 0, 0)
        btnTopicAddRecord.Size = New Size(226, 42)
        btnTopicAddRecord.TabIndex = 4
        btnTopicAddRecord.Text = "➕  3. Add Record"
        btnTopicAddRecord.TextAlign = ContentAlignment.MiddleLeft
        btnTopicAddRecord.UseVisualStyleBackColor = True
        ' 
        ' btnTopicViewRecords
        ' 
        btnTopicViewRecords.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnTopicViewRecords.Cursor = Cursors.Hand
        btnTopicViewRecords.FlatAppearance.BorderSize = 0
        btnTopicViewRecords.FlatStyle = FlatStyle.Flat
        btnTopicViewRecords.Font = New Font("Segoe UI", 9.5F)
        btnTopicViewRecords.Location = New Point(12, 198)
        btnTopicViewRecords.Name = "btnTopicViewRecords"
        btnTopicViewRecords.Padding = New Padding(8, 0, 0, 0)
        btnTopicViewRecords.Size = New Size(226, 42)
        btnTopicViewRecords.TabIndex = 5
        btnTopicViewRecords.Text = "📋  4. View & Edit Records"
        btnTopicViewRecords.TextAlign = ContentAlignment.MiddleLeft
        btnTopicViewRecords.UseVisualStyleBackColor = True
        ' 
        ' btnTopicReports
        ' 
        btnTopicReports.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnTopicReports.Cursor = Cursors.Hand
        btnTopicReports.FlatAppearance.BorderSize = 0
        btnTopicReports.FlatStyle = FlatStyle.Flat
        btnTopicReports.Font = New Font("Segoe UI", 9.5F)
        btnTopicReports.Location = New Point(12, 246)
        btnTopicReports.Name = "btnTopicReports"
        btnTopicReports.Padding = New Padding(8, 0, 0, 0)
        btnTopicReports.Size = New Size(226, 42)
        btnTopicReports.TabIndex = 6
        btnTopicReports.Text = "📈  5. Reports & Export"
        btnTopicReports.TextAlign = ContentAlignment.MiddleLeft
        btnTopicReports.UseVisualStyleBackColor = True
        ' 
        ' btnTopicSettings
        ' 
        btnTopicSettings.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnTopicSettings.Cursor = Cursors.Hand
        btnTopicSettings.FlatAppearance.BorderSize = 0
        btnTopicSettings.FlatStyle = FlatStyle.Flat
        btnTopicSettings.Font = New Font("Segoe UI", 9.5F)
        btnTopicSettings.Location = New Point(12, 294)
        btnTopicSettings.Name = "btnTopicSettings"
        btnTopicSettings.Padding = New Padding(8, 0, 0, 0)
        btnTopicSettings.Size = New Size(226, 42)
        btnTopicSettings.TabIndex = 7
        btnTopicSettings.Text = "⚙️  6. Settings & Security"
        btnTopicSettings.TextAlign = ContentAlignment.MiddleLeft
        btnTopicSettings.UseVisualStyleBackColor = True
        ' 
        ' btnTopicDevelopers
        ' 
        btnTopicDevelopers.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnTopicDevelopers.Cursor = Cursors.Hand
        btnTopicDevelopers.FlatAppearance.BorderSize = 0
        btnTopicDevelopers.FlatStyle = FlatStyle.Flat
        btnTopicDevelopers.Font = New Font("Segoe UI", 9.5F)
        btnTopicDevelopers.Location = New Point(12, 342)
        btnTopicDevelopers.Name = "btnTopicDevelopers"
        btnTopicDevelopers.Padding = New Padding(8, 0, 0, 0)
        btnTopicDevelopers.Size = New Size(226, 42)
        btnTopicDevelopers.TabIndex = 8
        btnTopicDevelopers.Text = "👥  7. Developers & Help"
        btnTopicDevelopers.TextAlign = ContentAlignment.MiddleLeft
        btnTopicDevelopers.UseVisualStyleBackColor = True
        ' 
        ' pnlContent
        ' 
        pnlContent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnViewFullImage = New Button()
        pnlBody = New Panel()
        pnlScreenshotContainer = New Panel()
        picScreenshot = New PictureBox()
        lblScreenshotHint = New Label()
        pnlScreenshotDivider = New Panel()
        rtbContent = New RichTextBox()

        pnlContent.Controls.Add(btnViewFullImage)
        pnlContent.Controls.Add(pnlBody)
        pnlContent.Controls.Add(lblContentDivider)
        pnlContent.Controls.Add(lblContentTopic)
        pnlContent.Location = New Point(290, 120)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(654, 430)
        pnlContent.TabIndex = 2
        ' 
        ' lblContentTopic
        ' 
        lblContentTopic.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblContentTopic.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblContentTopic.ForeColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        lblContentTopic.Location = New Point(20, 12)
        lblContentTopic.Name = "lblContentTopic"
        lblContentTopic.Size = New Size(420, 30)
        lblContentTopic.TabIndex = 0
        lblContentTopic.Text = "Topic Header"
        ' 
        ' btnViewFullImage
        ' 
        btnViewFullImage.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnViewFullImage.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        btnViewFullImage.Cursor = Cursors.Hand
        btnViewFullImage.FlatAppearance.BorderColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        btnViewFullImage.FlatStyle = FlatStyle.Flat
        btnViewFullImage.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnViewFullImage.ForeColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        btnViewFullImage.Location = New Point(450, 9)
        btnViewFullImage.Name = "btnViewFullImage"
        btnViewFullImage.Size = New Size(184, 30)
        btnViewFullImage.TabIndex = 3
        btnViewFullImage.Text = "🔍 View Full Screenshot"
        btnViewFullImage.UseVisualStyleBackColor = True
        ' 
        ' lblContentDivider
        ' 
        lblContentDivider.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblContentDivider.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        lblContentDivider.Location = New Point(20, 44)
        lblContentDivider.Name = "lblContentDivider"
        lblContentDivider.Size = New Size(614, 1)
        lblContentDivider.TabIndex = 1
        ' 
        ' pnlBody
        ' 
        pnlBody.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlBody.Controls.Add(rtbContent)
        pnlBody.Controls.Add(pnlScreenshotDivider)
        pnlBody.Controls.Add(pnlScreenshotContainer)
        pnlBody.Location = New Point(20, 52)
        pnlBody.Name = "pnlBody"
        pnlBody.Size = New Size(614, 365)
        pnlBody.TabIndex = 4
        ' 
        ' pnlScreenshotContainer
        ' 
        pnlScreenshotContainer.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        pnlScreenshotContainer.BorderStyle = BorderStyle.FixedSingle
        pnlScreenshotContainer.Controls.Add(picScreenshot)
        pnlScreenshotContainer.Controls.Add(lblScreenshotHint)
        pnlScreenshotContainer.Dock = DockStyle.Top
        pnlScreenshotContainer.Location = New Point(0, 0)
        pnlScreenshotContainer.Name = "pnlScreenshotContainer"
        pnlScreenshotContainer.Size = New Size(614, 185)
        pnlScreenshotContainer.TabIndex = 0
        ' 
        ' picScreenshot
        ' 
        picScreenshot.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        picScreenshot.Cursor = Cursors.Hand
        picScreenshot.Dock = DockStyle.Fill
        picScreenshot.Location = New Point(0, 0)
        picScreenshot.Name = "picScreenshot"
        picScreenshot.Size = New Size(612, 165)
        picScreenshot.SizeMode = PictureBoxSizeMode.Zoom
        picScreenshot.TabIndex = 0
        picScreenshot.TabStop = False
        ' 
        ' lblScreenshotHint
        ' 
        lblScreenshotHint.BackColor = Color.FromArgb(CByte(240), CByte(243), CByte(246))
        lblScreenshotHint.Cursor = Cursors.Hand
        lblScreenshotHint.Dock = DockStyle.Bottom
        lblScreenshotHint.Font = New Font("Segoe UI", 8.0F)
        lblScreenshotHint.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        lblScreenshotHint.Location = New Point(0, 165)
        lblScreenshotHint.Name = "lblScreenshotHint"
        lblScreenshotHint.Size = New Size(612, 18)
        lblScreenshotHint.TabIndex = 1
        lblScreenshotHint.Text = "🔍 Click image to enlarge full screen"
        lblScreenshotHint.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlScreenshotDivider
        ' 
        pnlScreenshotDivider.Dock = DockStyle.Top
        pnlScreenshotDivider.Location = New Point(0, 185)
        pnlScreenshotDivider.Name = "pnlScreenshotDivider"
        pnlScreenshotDivider.Size = New Size(614, 8)
        pnlScreenshotDivider.TabIndex = 1
        ' 
        ' rtbContent
        ' 
        rtbContent.BackColor = Color.White
        rtbContent.BorderStyle = BorderStyle.None
        rtbContent.Dock = DockStyle.Fill
        rtbContent.Font = New Font("Segoe UI", 9.75F)
        rtbContent.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        rtbContent.Location = New Point(0, 193)
        rtbContent.Name = "rtbContent"
        rtbContent.ReadOnly = True
        rtbContent.ScrollBars = RichTextBoxScrollBars.Vertical
        rtbContent.Size = New Size(614, 172)
        rtbContent.TabIndex = 2
        rtbContent.Text = ""
        ' 
        ' UcManual
        ' 
        BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        Controls.Add(pnlHeader)
        Controls.Add(pnlTopics)
        Controls.Add(pnlContent)
        Font = New Font("Segoe UI", 9F)
        AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        Name = "UcManual"
        Size = New Size(970, 569)
        pnlHeader.ResumeLayout(False)
        pnlTopics.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader          As Panel
    Friend WithEvents pnlDivider         As Panel
    Friend WithEvents lblPageTitle       As Label
    Friend WithEvents lblPageSub         As Label
    Friend WithEvents pnlTopics          As Panel
    Friend WithEvents lblTopicsTitle     As Label
    Friend WithEvents lblTopicsDivider   As Panel
    Friend WithEvents btnTopicOverview   As Button
    Friend WithEvents btnTopicDashboard  As Button
    Friend WithEvents btnTopicAddRecord  As Button
    Friend WithEvents btnTopicViewRecords As Button
    Friend WithEvents btnTopicReports    As Button
    Friend WithEvents btnTopicSettings   As Button
    Friend WithEvents btnTopicDevelopers As Button
    Friend WithEvents pnlContent         As Panel
    Friend WithEvents lblContentTopic    As Label
    Friend WithEvents lblContentDivider  As Panel
    Friend WithEvents rtbContent               As RichTextBox
    Friend WithEvents btnViewFullImage         As Button
    Friend WithEvents pnlBody                  As Panel
    Friend WithEvents pnlScreenshotContainer   As Panel
    Friend WithEvents picScreenshot            As PictureBox
    Friend WithEvents lblScreenshotHint        As Label
    Friend WithEvents pnlScreenshotDivider     As Panel

End Class