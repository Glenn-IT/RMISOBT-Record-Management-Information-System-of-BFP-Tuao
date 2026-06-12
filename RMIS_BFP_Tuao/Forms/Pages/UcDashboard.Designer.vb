<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcDashboard
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblPageTitle = New Label()
        lblWelcomeSub = New Label()
        pnlCard1 = New Panel()
        lblCard1Icon = New Label()
        lblCard1Title = New Label()
        lblCard1Value = New Label()
        pnlCard2 = New Panel()
        lblCard2Icon = New Label()
        lblCard2Title = New Label()
        lblCard2Value = New Label()
        pnlCard3 = New Panel()
        lblCard3Icon = New Label()
        lblCard3Title = New Label()
        lblCard3Value = New Label()
        pnlCard4 = New Panel()
        lblCard4Icon = New Label()
        lblCard4Title = New Label()
        lblCard4Value = New Label()
        pnlActivity = New Panel()
        lblActivityTitle = New Label()
        dgvRecent = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        pnlCard1.SuspendLayout()
        pnlCard2.SuspendLayout()
        pnlCard3.SuspendLayout()
        pnlCard4.SuspendLayout()
        pnlActivity.SuspendLayout()
        CType(dgvRecent, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblPageTitle.Location = New Point(24, 20)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(500, 36)
        lblPageTitle.TabIndex = 0
        lblPageTitle.Text = "Dashboard Overview"
        ' 
        ' lblWelcomeSub
        ' 
        lblWelcomeSub.Font = New Font("Segoe UI", 9.5F)
        lblWelcomeSub.ForeColor = Color.Gray
        lblWelcomeSub.Location = New Point(24, 56)
        lblWelcomeSub.Name = "lblWelcomeSub"
        lblWelcomeSub.Size = New Size(500, 24)
        lblWelcomeSub.TabIndex = 1
        lblWelcomeSub.Text = "Welcome, Admin"
        ' 
        ' pnlCard1
        ' 
        pnlCard1.BackColor = Color.White
        pnlCard1.Controls.Add(lblCard1Icon)
        pnlCard1.Controls.Add(lblCard1Title)
        pnlCard1.Controls.Add(lblCard1Value)
        pnlCard1.Location = New Point(24, 90)
        pnlCard1.Name = "pnlCard1"
        pnlCard1.Size = New Size(188, 100)
        pnlCard1.TabIndex = 2
        ' 
        ' lblCard1Icon
        ' 
        lblCard1Icon.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblCard1Icon.ForeColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        lblCard1Icon.Location = New Point(12, 15)
        lblCard1Icon.Name = "lblCard1Icon"
        lblCard1Icon.Size = New Size(56, 70)
        lblCard1Icon.TabIndex = 0
        lblCard1Icon.Text = "REC"
        lblCard1Icon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCard1Title
        ' 
        lblCard1Title.Font = New Font("Segoe UI", 8.5F)
        lblCard1Title.ForeColor = Color.Gray
        lblCard1Title.Location = New Point(72, 22)
        lblCard1Title.Name = "lblCard1Title"
        lblCard1Title.Size = New Size(110, 22)
        lblCard1Title.TabIndex = 1
        lblCard1Title.Text = "Total Records"
        ' 
        ' lblCard1Value
        ' 
        lblCard1Value.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblCard1Value.ForeColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        lblCard1Value.Location = New Point(70, 44)
        lblCard1Value.Name = "lblCard1Value"
        lblCard1Value.Size = New Size(110, 40)
        lblCard1Value.TabIndex = 2
        lblCard1Value.Text = "0"
        ' 
        ' pnlCard2
        ' 
        pnlCard2.BackColor = Color.White
        pnlCard2.Controls.Add(lblCard2Icon)
        pnlCard2.Controls.Add(lblCard2Title)
        pnlCard2.Controls.Add(lblCard2Value)
        pnlCard2.Location = New Point(224, 90)
        pnlCard2.Name = "pnlCard2"
        pnlCard2.Size = New Size(188, 100)
        pnlCard2.TabIndex = 3
        ' 
        ' lblCard2Icon
        ' 
        lblCard2Icon.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblCard2Icon.ForeColor = Color.FromArgb(CByte(220), CByte(120), CByte(0))
        lblCard2Icon.Location = New Point(12, 15)
        lblCard2Icon.Name = "lblCard2Icon"
        lblCard2Icon.Size = New Size(56, 70)
        lblCard2Icon.TabIndex = 0
        lblCard2Icon.Text = "ACT"
        lblCard2Icon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCard2Title
        ' 
        lblCard2Title.Font = New Font("Segoe UI", 8.5F)
        lblCard2Title.ForeColor = Color.Gray
        lblCard2Title.Location = New Point(72, 22)
        lblCard2Title.Name = "lblCard2Title"
        lblCard2Title.Size = New Size(110, 22)
        lblCard2Title.TabIndex = 1
        lblCard2Title.Text = "Active Cases"
        ' 
        ' lblCard2Value
        ' 
        lblCard2Value.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblCard2Value.ForeColor = Color.FromArgb(CByte(220), CByte(120), CByte(0))
        lblCard2Value.Location = New Point(70, 44)
        lblCard2Value.Name = "lblCard2Value"
        lblCard2Value.Size = New Size(110, 40)
        lblCard2Value.TabIndex = 2
        lblCard2Value.Text = "0"
        ' 
        ' pnlCard3
        ' 
        pnlCard3.BackColor = Color.White
        pnlCard3.Controls.Add(lblCard3Icon)
        pnlCard3.Controls.Add(lblCard3Title)
        pnlCard3.Controls.Add(lblCard3Value)
        pnlCard3.Location = New Point(424, 90)
        pnlCard3.Name = "pnlCard3"
        pnlCard3.Size = New Size(188, 100)
        pnlCard3.TabIndex = 4
        ' 
        ' lblCard3Icon
        ' 
        lblCard3Icon.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblCard3Icon.ForeColor = Color.FromArgb(CByte(30), CByte(130), CByte(30))
        lblCard3Icon.Location = New Point(12, 15)
        lblCard3Icon.Name = "lblCard3Icon"
        lblCard3Icon.Size = New Size(56, 70)
        lblCard3Icon.TabIndex = 0
        lblCard3Icon.Text = "OK"
        lblCard3Icon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCard3Title
        ' 
        lblCard3Title.Font = New Font("Segoe UI", 8.5F)
        lblCard3Title.ForeColor = Color.Gray
        lblCard3Title.Location = New Point(72, 22)
        lblCard3Title.Name = "lblCard3Title"
        lblCard3Title.Size = New Size(110, 22)
        lblCard3Title.TabIndex = 1
        lblCard3Title.Text = "Resolved"
        ' 
        ' lblCard3Value
        ' 
        lblCard3Value.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblCard3Value.ForeColor = Color.FromArgb(CByte(30), CByte(130), CByte(30))
        lblCard3Value.Location = New Point(70, 44)
        lblCard3Value.Name = "lblCard3Value"
        lblCard3Value.Size = New Size(110, 40)
        lblCard3Value.TabIndex = 2
        lblCard3Value.Text = "0"
        ' 
        ' pnlCard4
        ' 
        pnlCard4.BackColor = Color.White
        pnlCard4.Controls.Add(lblCard4Icon)
        pnlCard4.Controls.Add(lblCard4Title)
        pnlCard4.Controls.Add(lblCard4Value)
        pnlCard4.Location = New Point(624, 90)
        pnlCard4.Name = "pnlCard4"
        pnlCard4.Size = New Size(188, 100)
        pnlCard4.TabIndex = 5
        ' 
        ' lblCard4Icon
        ' 
        lblCard4Icon.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblCard4Icon.ForeColor = Color.FromArgb(CByte(20), CByte(80), CByte(180))
        lblCard4Icon.Location = New Point(12, 15)
        lblCard4Icon.Name = "lblCard4Icon"
        lblCard4Icon.Size = New Size(56, 70)
        lblCard4Icon.TabIndex = 0
        lblCard4Icon.Text = "PRS"
        lblCard4Icon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCard4Title
        ' 
        lblCard4Title.Font = New Font("Segoe UI", 8.5F)
        lblCard4Title.ForeColor = Color.Gray
        lblCard4Title.Location = New Point(72, 22)
        lblCard4Title.Name = "lblCard4Title"
        lblCard4Title.Size = New Size(110, 22)
        lblCard4Title.TabIndex = 1
        lblCard4Title.Text = "Personnel"
        ' 
        ' lblCard4Value
        ' 
        lblCard4Value.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblCard4Value.ForeColor = Color.FromArgb(CByte(20), CByte(80), CByte(180))
        lblCard4Value.Location = New Point(70, 44)
        lblCard4Value.Name = "lblCard4Value"
        lblCard4Value.Size = New Size(110, 40)
        lblCard4Value.TabIndex = 2
        lblCard4Value.Text = "0"
        ' 
        ' pnlActivity
        ' 
        pnlActivity.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlActivity.BackColor = Color.White
        pnlActivity.Controls.Add(lblActivityTitle)
        pnlActivity.Controls.Add(dgvRecent)
        pnlActivity.Location = New Point(24, 210)
        pnlActivity.Name = "pnlActivity"
        pnlActivity.Size = New Size(1065, 300)
        pnlActivity.TabIndex = 6
        ' 
        ' lblActivityTitle
        ' 
        lblActivityTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblActivityTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblActivityTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblActivityTitle.Location = New Point(16, 10)
        lblActivityTitle.Name = "lblActivityTitle"
        lblActivityTitle.Size = New Size(1025, 36)
        lblActivityTitle.TabIndex = 0
        lblActivityTitle.Text = "Recent Records"
        ' 
        ' dgvRecent
        ' 
        dgvRecent.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(252), CByte(245), CByte(245))
        dgvRecent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvRecent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecent.BackgroundColor = Color.White
        dgvRecent.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvRecent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvRecent.ColumnHeadersHeight = 34
        dgvRecent.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5})
        dgvRecent.EnableHeadersVisualStyles = False
        dgvRecent.Font = New Font("Segoe UI", 9F)
        dgvRecent.GridColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        dgvRecent.Location = New Point(16, 46)
        dgvRecent.Name = "dgvRecent"
        dgvRecent.ReadOnly = True
        dgvRecent.RowHeadersVisible = False
        dgvRecent.RowHeadersWidth = 45
        dgvRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecent.Size = New Size(1033, 244)
        dgvRecent.TabIndex = 1
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "Record ID"
        DataGridViewTextBoxColumn1.MinimumWidth = 6
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Incident Type"
        DataGridViewTextBoxColumn2.MinimumWidth = 6
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "Date Reported"
        DataGridViewTextBoxColumn3.MinimumWidth = 6
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.HeaderText = "Location"
        DataGridViewTextBoxColumn4.MinimumWidth = 6
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.HeaderText = "Status"
        DataGridViewTextBoxColumn5.MinimumWidth = 6
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        DataGridViewTextBoxColumn5.ReadOnly = True
        ' 
        ' UcDashboard
        ' 
        BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        Controls.Add(lblPageTitle)
        Controls.Add(lblWelcomeSub)
        Controls.Add(pnlCard1)
        Controls.Add(pnlCard2)
        Controls.Add(pnlCard3)
        Controls.Add(pnlCard4)
        Controls.Add(pnlActivity)
        Name = "UcDashboard"
        Size = New Size(1111, 750)
        pnlCard1.ResumeLayout(False)
        pnlCard2.ResumeLayout(False)
        pnlCard3.ResumeLayout(False)
        pnlCard4.ResumeLayout(False)
        pnlActivity.ResumeLayout(False)
        CType(dgvRecent, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents lblPageTitle     As Label
    Friend WithEvents lblWelcomeSub    As Label
    Friend WithEvents pnlCard1         As Panel
    Friend WithEvents pnlCard2         As Panel
    Friend WithEvents pnlCard3         As Panel
    Friend WithEvents pnlCard4         As Panel
    Friend WithEvents lblCard1Icon     As Label
    Friend WithEvents lblCard1Title    As Label
    Friend WithEvents lblCard1Value    As Label
    Friend WithEvents lblCard2Icon     As Label
    Friend WithEvents lblCard2Title    As Label
    Friend WithEvents lblCard2Value    As Label
    Friend WithEvents lblCard3Icon     As Label
    Friend WithEvents lblCard3Title    As Label
    Friend WithEvents lblCard3Value    As Label
    Friend WithEvents lblCard4Icon     As Label
    Friend WithEvents lblCard4Title    As Label
    Friend WithEvents lblCard4Value    As Label
    Friend WithEvents pnlActivity      As Panel
    Friend WithEvents lblActivityTitle As Label
    Friend WithEvents dgvRecent        As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn

End Class
