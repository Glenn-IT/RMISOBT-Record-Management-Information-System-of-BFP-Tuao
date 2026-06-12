<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcViewRecords
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
        pnlToolbar = New Panel()
        lblSearchLabel = New Label()
        txtSearch = New TextBox()
        btnRefresh = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        lblRecordCount = New Label()
        pnlGridCard = New Panel()
        dgvRecords = New DataGridView()
        colID = New DataGridViewTextBoxColumn()
        colType = New DataGridViewTextBoxColumn()
        colDate = New DataGridViewTextBoxColumn()
        colLocation = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        pnlHeader.SuspendLayout()
        pnlToolbar.SuspendLayout()
        pnlGridCard.SuspendLayout()
        CType(dgvRecords, ComponentModel.ISupportInitialize).BeginInit()
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
        pnlHeader.Size = New Size(930, 88)
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
        lblPageTitle.Text = "View Incident Records"
        ' 
        ' lblPageSub
        ' 
        lblPageSub.Font = New Font("Segoe UI", 9F)
        lblPageSub.ForeColor = Color.Gray
        lblPageSub.Location = New Point(20, 46)
        lblPageSub.Name = "lblPageSub"
        lblPageSub.Size = New Size(600, 22)
        lblPageSub.TabIndex = 1
        lblPageSub.Text = "Browse, search, and manage all recorded fire incidents."
        ' 
        ' pnlDivider
        ' 
        pnlDivider.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDivider.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        pnlDivider.Location = New Point(20, 78)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(890, 3)
        pnlDivider.TabIndex = 2
        ' 
        ' pnlToolbar
        ' 
        pnlToolbar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlToolbar.BackColor = Color.White
        pnlToolbar.Controls.Add(lblSearchLabel)
        pnlToolbar.Controls.Add(txtSearch)
        pnlToolbar.Controls.Add(btnRefresh)
        pnlToolbar.Controls.Add(btnEdit)
        pnlToolbar.Controls.Add(btnDelete)
        pnlToolbar.Controls.Add(lblRecordCount)
        pnlToolbar.Location = New Point(24, 118)
        pnlToolbar.Name = "pnlToolbar"
        pnlToolbar.Size = New Size(930, 56)
        pnlToolbar.TabIndex = 1
        ' 
        ' lblSearchLabel
        ' 
        lblSearchLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblSearchLabel.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblSearchLabel.Location = New Point(16, 13)
        lblSearchLabel.Name = "lblSearchLabel"
        lblSearchLabel.Size = New Size(54, 30)
        lblSearchLabel.TabIndex = 0
        lblSearchLabel.Text = "Search:"
        lblSearchLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.Location = New Point(72, 13)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Type to search records..."
        txtSearch.Size = New Size(300, 27)
        txtSearch.TabIndex = 1
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9F)
        btnRefresh.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnRefresh.Location = New Point(386, 13)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(90, 30)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(30), CByte(100), CByte(180))
        btnEdit.Cursor = Cursors.Hand
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(490, 13)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(120, 30)
        btnEdit.TabIndex = 3
        btnEdit.Text = "Edit Selected"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(624, 13)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(130, 30)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete Selected"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' lblRecordCount
        ' 
        lblRecordCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblRecordCount.Font = New Font("Segoe UI", 9F)
        lblRecordCount.ForeColor = Color.Gray
        lblRecordCount.Location = New Point(766, 13)
        lblRecordCount.Name = "lblRecordCount"
        lblRecordCount.Size = New Size(160, 30)
        lblRecordCount.TabIndex = 5
        lblRecordCount.Text = "Total Records: 0"
        lblRecordCount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pnlGridCard
        ' 
        pnlGridCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlGridCard.BackColor = Color.White
        pnlGridCard.Controls.Add(dgvRecords)
        pnlGridCard.Location = New Point(24, 186)
        pnlGridCard.Name = "pnlGridCard"
        pnlGridCard.Size = New Size(930, 467)
        pnlGridCard.TabIndex = 2
        ' 
        ' dgvRecords
        ' 
        dgvRecords.AllowUserToAddRows = False
        dgvRecords.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecords.BackgroundColor = Color.White
        dgvRecords.BorderStyle = BorderStyle.None
        dgvRecords.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(180), CByte(20), CByte(20))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.Padding = New Padding(8, 0, 0, 0)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvRecords.ColumnHeadersHeight = 38
        dgvRecords.Columns.AddRange(New DataGridViewColumn() {colID, colType, colDate, colLocation, colStatus})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New Padding(6, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(220), CByte(50), CByte(50))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvRecords.DefaultCellStyle = DataGridViewCellStyle2
        dgvRecords.EnableHeadersVisualStyles = False
        dgvRecords.Font = New Font("Segoe UI", 9.5F)
        dgvRecords.GridColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        dgvRecords.Location = New Point(10, 10)
        dgvRecords.MultiSelect = False
        dgvRecords.Name = "dgvRecords"
        dgvRecords.ReadOnly = True
        dgvRecords.RowHeadersVisible = False
        dgvRecords.RowHeadersWidth = 45
        dgvRecords.RowTemplate.Height = 36
        dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecords.Size = New Size(910, 447)
        dgvRecords.TabIndex = 0
        ' 
        ' colID
        ' 
        colID.FillWeight = 12F
        colID.HeaderText = "Record ID"
        colID.MinimumWidth = 6
        colID.Name = "colID"
        colID.ReadOnly = True
        ' 
        ' colType
        ' 
        colType.FillWeight = 20F
        colType.HeaderText = "Incident Type"
        colType.MinimumWidth = 6
        colType.Name = "colType"
        colType.ReadOnly = True
        ' 
        ' colDate
        ' 
        colDate.FillWeight = 15F
        colDate.HeaderText = "Date Reported"
        colDate.MinimumWidth = 6
        colDate.Name = "colDate"
        colDate.ReadOnly = True
        ' 
        ' colLocation
        ' 
        colLocation.FillWeight = 35F
        colLocation.HeaderText = "Location"
        colLocation.MinimumWidth = 6
        colLocation.Name = "colLocation"
        colLocation.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.FillWeight = 18F
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' UcViewRecords
        ' 
        BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        Controls.Add(pnlHeader)
        Controls.Add(pnlToolbar)
        Controls.Add(pnlGridCard)
        Name = "UcViewRecords"
        Size = New Size(969, 676)
        pnlHeader.ResumeLayout(False)
        pnlToolbar.ResumeLayout(False)
        pnlToolbar.PerformLayout()
        pnlGridCard.ResumeLayout(False)
        CType(dgvRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    ' ── Control Declarations ─────────────────────────────────────
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlToolbar As Panel
    Friend WithEvents pnlGridCard As Panel
    Friend WithEvents pnlDivider As Panel
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents lblPageSub As Label
    Friend WithEvents lblSearchLabel As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents dgvRecords As DataGridView
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colLocation As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn

End Class
