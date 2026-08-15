<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcReports
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
        pnlHeader = New Panel()
        lblPageTitle = New Label()
        lblPageSub = New Label()
        pnlDivider = New Panel()
        btnExport = New Button()
        btnPrint = New Button()
        pnlToolbar = New Panel()
        lblSearchLabel = New Label()
        txtSearch = New TextBox()
        lblTypeLabel = New Label()
        cmbType = New ComboBox()
        lblStatusLabel = New Label()
        cmbStatus = New ComboBox()
        btnRefresh = New Button()
        lblRecordCount = New Label()
        pnlSummary = New Panel()
        lblSumTitle = New Label()
        pnlCardTotal = New Panel()
        lblCardTotalTitle = New Label()
        lblCardTotalValue = New Label()
        pnlCardActive = New Panel()
        lblCardActiveTitle = New Label()
        lblCardActiveValue = New Label()
        pnlCardResolved = New Panel()
        lblCardResolvedTitle = New Label()
        lblCardResolvedValue = New Label()
        pnlCardClosed = New Panel()
        lblCardClosedTitle = New Label()
        lblCardClosedValue = New Label()
        pnlBreakdown = New Panel()
        lblBreakTitle = New Label()
        dgvBreakdown = New DataGridView()
        colType = New DataGridViewTextBoxColumn()
        colCount = New DataGridViewTextBoxColumn()
        colActive = New DataGridViewTextBoxColumn()
        colResolved = New DataGridViewTextBoxColumn()
        colOther = New DataGridViewTextBoxColumn()
        pnlHeader.SuspendLayout()
        pnlToolbar.SuspendLayout()
        pnlSummary.SuspendLayout()
        pnlCardTotal.SuspendLayout()
        pnlCardActive.SuspendLayout()
        pnlCardResolved.SuspendLayout()
        pnlCardClosed.SuspendLayout()
        pnlBreakdown.SuspendLayout()
        CType(dgvBreakdown, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Controls.Add(lblPageSub)
        pnlHeader.Controls.Add(pnlDivider)
        pnlHeader.Controls.Add(btnExport)
        pnlHeader.Controls.Add(btnPrint)
        pnlHeader.Location = New Point(24, 18)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1066, 88)
        pnlHeader.TabIndex = 0
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblPageTitle.Location = New Point(20, 12)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(600, 34)
        lblPageTitle.TabIndex = 0
        lblPageTitle.Text = "Incident Reports"
        ' 
        ' lblPageSub
        ' 
        lblPageSub.Font = New Font("Segoe UI", 9F)
        lblPageSub.ForeColor = Color.Gray
        lblPageSub.Location = New Point(20, 46)
        lblPageSub.Name = "lblPageSub"
        lblPageSub.Size = New Size(600, 22)
        lblPageSub.TabIndex = 1
        lblPageSub.Text = "Summary and breakdown of all fire incident records."
        ' 
        ' pnlDivider
        ' 
        pnlDivider.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDivider.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        pnlDivider.Location = New Point(20, 78)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(1026, 3)
        pnlDivider.TabIndex = 2
        ' 
        ' btnExport
        ' 
        btnExport.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExport.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        btnExport.Cursor = Cursors.Hand
        btnExport.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Font = New Font("Segoe UI", 9F)
        btnExport.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnExport.Location = New Point(836, 20)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(100, 30)
        btnExport.TabIndex = 3
        btnExport.Text = "Export CSV"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPrint.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        btnPrint.Cursor = Cursors.Hand
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(946, 20)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(110, 30)
        btnPrint.TabIndex = 4
        btnPrint.Text = "Print Report"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' pnlToolbar
        ' 
        pnlToolbar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlToolbar.BackColor = Color.White
        pnlToolbar.Controls.Add(lblSearchLabel)
        pnlToolbar.Controls.Add(txtSearch)
        pnlToolbar.Controls.Add(lblTypeLabel)
        pnlToolbar.Controls.Add(cmbType)
        pnlToolbar.Controls.Add(lblStatusLabel)
        pnlToolbar.Controls.Add(cmbStatus)
        pnlToolbar.Controls.Add(btnRefresh)
        pnlToolbar.Controls.Add(lblRecordCount)
        pnlToolbar.Location = New Point(24, 114)
        pnlToolbar.Name = "pnlToolbar"
        pnlToolbar.Size = New Size(1066, 48)
        pnlToolbar.TabIndex = 1
        ' 
        ' lblSearchLabel
        ' 
        lblSearchLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblSearchLabel.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblSearchLabel.Location = New Point(15, 12)
        lblSearchLabel.Name = "lblSearchLabel"
        lblSearchLabel.Size = New Size(55, 23)
        lblSearchLabel.TabIndex = 0
        lblSearchLabel.Text = "Search:"
        lblSearchLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.Location = New Point(73, 10)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Type to search records..."
        txtSearch.Size = New Size(180, 27)
        txtSearch.TabIndex = 1
        ' 
        ' lblTypeLabel
        ' 
        lblTypeLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTypeLabel.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblTypeLabel.Location = New Point(268, 12)
        lblTypeLabel.Name = "lblTypeLabel"
        lblTypeLabel.Size = New Size(42, 23)
        lblTypeLabel.TabIndex = 2
        lblTypeLabel.Text = "Type:"
        lblTypeLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmbType
        ' 
        cmbType.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        cmbType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbType.Font = New Font("Segoe UI", 9.5F)
        cmbType.FormattingEnabled = True
        cmbType.Location = New Point(312, 10)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(160, 27)
        cmbType.TabIndex = 3
        ' 
        ' lblStatusLabel
        ' 
        lblStatusLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblStatusLabel.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblStatusLabel.Location = New Point(487, 12)
        lblStatusLabel.Name = "lblStatusLabel"
        lblStatusLabel.Size = New Size(52, 23)
        lblStatusLabel.TabIndex = 4
        lblStatusLabel.Text = "Status:"
        lblStatusLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmbStatus
        ' 
        cmbStatus.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.Font = New Font("Segoe UI", 9.5F)
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(541, 10)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(160, 27)
        cmbStatus.TabIndex = 5
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9F)
        btnRefresh.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnRefresh.Location = New Point(716, 9)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(85, 30)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' lblRecordCount
        ' 
        lblRecordCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblRecordCount.Font = New Font("Segoe UI", 9F)
        lblRecordCount.ForeColor = Color.Gray
        lblRecordCount.Location = New Point(880, 9)
        lblRecordCount.Name = "lblRecordCount"
        lblRecordCount.Size = New Size(170, 30)
        lblRecordCount.TabIndex = 7
        lblRecordCount.Text = "Total Records: 0"
        lblRecordCount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pnlSummary
        ' 
        pnlSummary.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSummary.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        pnlSummary.Controls.Add(lblSumTitle)
        pnlSummary.Controls.Add(pnlCardTotal)
        pnlSummary.Controls.Add(pnlCardActive)
        pnlSummary.Controls.Add(pnlCardResolved)
        pnlSummary.Controls.Add(pnlCardClosed)
        pnlSummary.Location = New Point(24, 168)
        pnlSummary.Name = "pnlSummary"
        pnlSummary.Size = New Size(1066, 110)
        pnlSummary.TabIndex = 2
        ' 
        ' lblSumTitle
        ' 
        lblSumTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblSumTitle.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblSumTitle.Location = New Point(0, 0)
        lblSumTitle.Name = "lblSumTitle"
        lblSumTitle.Size = New Size(200, 24)
        lblSumTitle.TabIndex = 0
        lblSumTitle.Text = "Summary"
        ' 
        ' pnlCardTotal
        ' 
        pnlCardTotal.BackColor = Color.White
        pnlCardTotal.Controls.Add(lblCardTotalTitle)
        pnlCardTotal.Controls.Add(lblCardTotalValue)
        pnlCardTotal.Location = New Point(0, 28)
        pnlCardTotal.Name = "pnlCardTotal"
        pnlCardTotal.Size = New Size(206, 80)
        pnlCardTotal.TabIndex = 1
        ' 
        ' lblCardTotalTitle
        ' 
        lblCardTotalTitle.Font = New Font("Segoe UI", 8.5F)
        lblCardTotalTitle.ForeColor = Color.Gray
        lblCardTotalTitle.Location = New Point(14, 10)
        lblCardTotalTitle.Name = "lblCardTotalTitle"
        lblCardTotalTitle.Size = New Size(180, 20)
        lblCardTotalTitle.TabIndex = 0
        lblCardTotalTitle.Text = "Total Records"
        ' 
        ' lblCardTotalValue
        ' 
        lblCardTotalValue.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblCardTotalValue.ForeColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        lblCardTotalValue.Location = New Point(12, 30)
        lblCardTotalValue.Name = "lblCardTotalValue"
        lblCardTotalValue.Size = New Size(180, 46)
        lblCardTotalValue.TabIndex = 1
        lblCardTotalValue.Text = "0"
        ' 
        ' pnlCardActive
        ' 
        pnlCardActive.BackColor = Color.White
        pnlCardActive.Controls.Add(lblCardActiveTitle)
        pnlCardActive.Controls.Add(lblCardActiveValue)
        pnlCardActive.Location = New Point(214, 28)
        pnlCardActive.Name = "pnlCardActive"
        pnlCardActive.Size = New Size(206, 80)
        pnlCardActive.TabIndex = 2
        ' 
        ' lblCardActiveTitle
        ' 
        lblCardActiveTitle.Font = New Font("Segoe UI", 8.5F)
        lblCardActiveTitle.ForeColor = Color.Gray
        lblCardActiveTitle.Location = New Point(14, 10)
        lblCardActiveTitle.Name = "lblCardActiveTitle"
        lblCardActiveTitle.Size = New Size(180, 20)
        lblCardActiveTitle.TabIndex = 0
        lblCardActiveTitle.Text = "Active Cases"
        ' 
        ' lblCardActiveValue
        ' 
        lblCardActiveValue.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblCardActiveValue.ForeColor = Color.FromArgb(CByte(220), CByte(120), CByte(0))
        lblCardActiveValue.Location = New Point(12, 30)
        lblCardActiveValue.Name = "lblCardActiveValue"
        lblCardActiveValue.Size = New Size(180, 46)
        lblCardActiveValue.TabIndex = 1
        lblCardActiveValue.Text = "0"
        ' 
        ' pnlCardResolved
        ' 
        pnlCardResolved.BackColor = Color.White
        pnlCardResolved.Controls.Add(lblCardResolvedTitle)
        pnlCardResolved.Controls.Add(lblCardResolvedValue)
        pnlCardResolved.Location = New Point(428, 28)
        pnlCardResolved.Name = "pnlCardResolved"
        pnlCardResolved.Size = New Size(206, 80)
        pnlCardResolved.TabIndex = 3
        ' 
        ' lblCardResolvedTitle
        ' 
        lblCardResolvedTitle.Font = New Font("Segoe UI", 8.5F)
        lblCardResolvedTitle.ForeColor = Color.Gray
        lblCardResolvedTitle.Location = New Point(14, 10)
        lblCardResolvedTitle.Name = "lblCardResolvedTitle"
        lblCardResolvedTitle.Size = New Size(180, 20)
        lblCardResolvedTitle.TabIndex = 0
        lblCardResolvedTitle.Text = "Resolved"
        ' 
        ' lblCardResolvedValue
        ' 
        lblCardResolvedValue.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblCardResolvedValue.ForeColor = Color.FromArgb(CByte(30), CByte(130), CByte(30))
        lblCardResolvedValue.Location = New Point(12, 30)
        lblCardResolvedValue.Name = "lblCardResolvedValue"
        lblCardResolvedValue.Size = New Size(180, 46)
        lblCardResolvedValue.TabIndex = 1
        lblCardResolvedValue.Text = "0"
        ' 
        ' pnlCardClosed
        ' 
        pnlCardClosed.BackColor = Color.White
        pnlCardClosed.Controls.Add(lblCardClosedTitle)
        pnlCardClosed.Controls.Add(lblCardClosedValue)
        pnlCardClosed.Location = New Point(642, 28)
        pnlCardClosed.Name = "pnlCardClosed"
        pnlCardClosed.Size = New Size(206, 80)
        pnlCardClosed.TabIndex = 4
        ' 
        ' lblCardClosedTitle
        ' 
        lblCardClosedTitle.Font = New Font("Segoe UI", 8.5F)
        lblCardClosedTitle.ForeColor = Color.Gray
        lblCardClosedTitle.Location = New Point(14, 10)
        lblCardClosedTitle.Name = "lblCardClosedTitle"
        lblCardClosedTitle.Size = New Size(180, 20)
        lblCardClosedTitle.TabIndex = 0
        lblCardClosedTitle.Text = "Closed"
        ' 
        ' lblCardClosedValue
        ' 
        lblCardClosedValue.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblCardClosedValue.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        lblCardClosedValue.Location = New Point(12, 30)
        lblCardClosedValue.Name = "lblCardClosedValue"
        lblCardClosedValue.Size = New Size(180, 46)
        lblCardClosedValue.TabIndex = 1
        lblCardClosedValue.Text = "0"
        ' 
        ' pnlBreakdown
        ' 
        pnlBreakdown.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlBreakdown.BackColor = Color.White
        pnlBreakdown.Controls.Add(lblBreakTitle)
        pnlBreakdown.Controls.Add(dgvBreakdown)
        pnlBreakdown.Location = New Point(24, 290)
        pnlBreakdown.Name = "pnlBreakdown"
        pnlBreakdown.Size = New Size(1066, 404)
        pnlBreakdown.TabIndex = 3
        ' 
        ' lblBreakTitle
        ' 
        lblBreakTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblBreakTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblBreakTitle.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        lblBreakTitle.Location = New Point(16, 10)
        lblBreakTitle.Name = "lblBreakTitle"
        lblBreakTitle.Size = New Size(1026, 34)
        lblBreakTitle.TabIndex = 0
        lblBreakTitle.Text = "Breakdown by Incident Type"
        ' 
        ' dgvBreakdown
        ' 
        dgvBreakdown.AllowUserToAddRows = False
        dgvBreakdown.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvBreakdown.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBreakdown.BackgroundColor = Color.White
        dgvBreakdown.BorderStyle = BorderStyle.None
        dgvBreakdown.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.Padding = New Padding(8, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvBreakdown.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvBreakdown.ColumnHeadersHeight = 38
        dgvBreakdown.Columns.AddRange(New DataGridViewColumn() {colType, colCount, colActive, colResolved, colOther})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New Padding(6, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(220), CByte(50), CByte(50))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvBreakdown.DefaultCellStyle = DataGridViewCellStyle2
        dgvBreakdown.EnableHeadersVisualStyles = False
        dgvBreakdown.Font = New Font("Segoe UI", 9.5F)
        dgvBreakdown.GridColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        dgvBreakdown.Location = New Point(16, 46)
        dgvBreakdown.Name = "dgvBreakdown"
        dgvBreakdown.ReadOnly = True
        dgvBreakdown.RowHeadersVisible = False
        dgvBreakdown.RowHeadersWidth = 45
        dgvBreakdown.RowTemplate.Height = 36
        dgvBreakdown.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBreakdown.Size = New Size(1034, 348)
        dgvBreakdown.TabIndex = 1
        ' 
        ' colType
        ' 
        colType.MinimumWidth = 6
        colType.Name = "colType"
        colType.ReadOnly = True
        ' 
        ' colCount
        ' 
        colCount.MinimumWidth = 6
        colCount.Name = "colCount"
        colCount.ReadOnly = True
        ' 
        ' colActive
        ' 
        colActive.MinimumWidth = 6
        colActive.Name = "colActive"
        colActive.ReadOnly = True
        ' 
        ' colResolved
        ' 
        colResolved.MinimumWidth = 6
        colResolved.Name = "colResolved"
        colResolved.ReadOnly = True
        ' 
        ' colOther
        ' 
        colOther.MinimumWidth = 6
        colOther.Name = "colOther"
        colOther.ReadOnly = True
        ' 
        ' UcReports
        ' 
        BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        Controls.Add(pnlHeader)
        Controls.Add(pnlToolbar)
        Controls.Add(pnlSummary)
        Controls.Add(pnlBreakdown)
        Font = New Font("Segoe UI", 9F)
        AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        Name = "UcReports"
        Size = New Size(1110, 713)
        pnlHeader.ResumeLayout(False)
        pnlToolbar.ResumeLayout(False)
        pnlToolbar.PerformLayout()
        pnlSummary.ResumeLayout(False)
        pnlCardTotal.ResumeLayout(False)
        pnlCardActive.ResumeLayout(False)
        pnlCardResolved.ResumeLayout(False)
        pnlCardClosed.ResumeLayout(False)
        pnlBreakdown.ResumeLayout(False)
        CType(dgvBreakdown, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader            As Panel
    Friend WithEvents pnlDivider           As Panel
    Friend WithEvents lblPageTitle         As Label
    Friend WithEvents lblPageSub           As Label
    Friend WithEvents btnExport            As Button
    Friend WithEvents btnPrint             As Button
    Friend WithEvents pnlToolbar           As Panel
    Friend WithEvents lblSearchLabel       As Label
    Friend WithEvents txtSearch            As TextBox
    Friend WithEvents lblTypeLabel         As Label
    Friend WithEvents cmbType              As ComboBox
    Friend WithEvents lblStatusLabel       As Label
    Friend WithEvents cmbStatus            As ComboBox
    Friend WithEvents btnRefresh           As Button
    Friend WithEvents lblRecordCount       As Label
    Friend WithEvents pnlSummary           As Panel
    Friend WithEvents lblSumTitle          As Label
    Friend WithEvents pnlCardTotal         As Panel
    Friend WithEvents lblCardTotalTitle    As Label
    Friend WithEvents lblCardTotalValue    As Label
    Friend WithEvents pnlCardActive        As Panel
    Friend WithEvents lblCardActiveTitle   As Label
    Friend WithEvents lblCardActiveValue   As Label
    Friend WithEvents pnlCardResolved      As Panel
    Friend WithEvents lblCardResolvedTitle As Label
    Friend WithEvents lblCardResolvedValue As Label
    Friend WithEvents pnlCardClosed        As Panel
    Friend WithEvents lblCardClosedTitle   As Label
    Friend WithEvents lblCardClosedValue   As Label
    Friend WithEvents pnlBreakdown         As Panel
    Friend WithEvents lblBreakTitle        As Label
    Friend WithEvents dgvBreakdown         As DataGridView
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colCount As DataGridViewTextBoxColumn
    Friend WithEvents colActive As DataGridViewTextBoxColumn
    Friend WithEvents colResolved As DataGridViewTextBoxColumn
    Friend WithEvents colOther As DataGridViewTextBoxColumn

End Class
