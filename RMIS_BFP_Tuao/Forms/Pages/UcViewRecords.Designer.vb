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

        ' ── Declare controls ─────────────────────────────────────
        pnlHeader = New Panel()
        pnlToolbar = New Panel()
        pnlGridCard = New Panel()
        lblPageTitle = New Label()
        lblPageSub = New Label()
        pnlDivider = New Panel()
        lblSearchLabel = New Label()
        txtSearch = New TextBox()
        btnRefresh = New Button()
        btnDelete = New Button()
        lblRecordCount = New Label()
        dgvRecords = New DataGridView()

        pnlHeader.SuspendLayout()
        pnlToolbar.SuspendLayout()
        pnlGridCard.SuspendLayout()
        Me.SuspendLayout()

        ' ════════════════════════════════════════════════════════
        ' pnlHeader — page title block
        ' ════════════════════════════════════════════════════════
        pnlHeader.BackColor = Color.White
        pnlHeader.Size = New Size(920, 88)
        pnlHeader.Location = New Point(24, 18)
        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Controls.Add(lblPageSub)
        pnlHeader.Controls.Add(pnlDivider)

        lblPageTitle.Text = "View Incident Records"
        lblPageTitle.Font = New Font("Segoe UI", 15, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.FromArgb(30, 30, 30)
        lblPageTitle.AutoSize = False
        lblPageTitle.Size = New Size(600, 34)
        lblPageTitle.Location = New Point(20, 12)

        lblPageSub.Text = "Browse, search, and manage all recorded fire incidents."
        lblPageSub.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblPageSub.ForeColor = Color.Gray
        lblPageSub.AutoSize = False
        lblPageSub.Size = New Size(600, 22)
        lblPageSub.Location = New Point(20, 46)

        pnlDivider.BackColor = Color.FromArgb(180, 20, 20)
        pnlDivider.Size = New Size(880, 3)
        pnlDivider.Location = New Point(20, 78)

        ' ════════════════════════════════════════════════════════
        ' pnlToolbar — search bar + action buttons
        ' ════════════════════════════════════════════════════════
        pnlToolbar.BackColor = Color.White
        pnlToolbar.Size = New Size(920, 56)
        pnlToolbar.Location = New Point(24, 118)
        pnlToolbar.Controls.Add(lblSearchLabel)
        pnlToolbar.Controls.Add(txtSearch)
        pnlToolbar.Controls.Add(btnRefresh)
        pnlToolbar.Controls.Add(btnDelete)
        pnlToolbar.Controls.Add(lblRecordCount)

        lblSearchLabel.Text = "Search:"
        lblSearchLabel.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblSearchLabel.ForeColor = Color.FromArgb(70, 70, 70)
        lblSearchLabel.AutoSize = False
        lblSearchLabel.Size = New Size(54, 30)
        lblSearchLabel.Location = New Point(16, 13)
        lblSearchLabel.TextAlign = ContentAlignment.MiddleLeft

        txtSearch.Font = New Font("Segoe UI", 10)
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.BackColor = Color.FromArgb(250, 250, 250)
        txtSearch.Size = New Size(300, 30)
        txtSearch.Location = New Point(72, 13)
        txtSearch.PlaceholderText = "Type to search records..."

        btnRefresh.Text = "Refresh"
        btnRefresh.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        btnRefresh.Size = New Size(90, 30)
        btnRefresh.Location = New Point(386, 13)
        btnRefresh.BackColor = Color.FromArgb(240, 242, 245)
        btnRefresh.ForeColor = Color.FromArgb(60, 60, 60)
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200)
        btnRefresh.Cursor = Cursors.Hand

        btnDelete.Text = "Delete Selected"
        btnDelete.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnDelete.Size = New Size(130, 30)
        btnDelete.Location = New Point(490, 13)
        btnDelete.BackColor = Color.FromArgb(180, 20, 20)
        btnDelete.ForeColor = Color.White
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.Cursor = Cursors.Hand

        lblRecordCount.Text = "Total Records: 0"
        lblRecordCount.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblRecordCount.ForeColor = Color.Gray
        lblRecordCount.AutoSize = False
        lblRecordCount.Size = New Size(160, 30)
        lblRecordCount.Location = New Point(740, 13)
        lblRecordCount.TextAlign = ContentAlignment.MiddleRight

        ' ════════════════════════════════════════════════════════
        ' pnlGridCard — white card containing the DataGridView
        ' ════════════════════════════════════════════════════════
        pnlGridCard.BackColor = Color.White
        pnlGridCard.Size = New Size(920, 390)
        pnlGridCard.Location = New Point(24, 186)
        pnlGridCard.Controls.Add(dgvRecords)

        ' DataGridView
        dgvRecords.Size = New Size(900, 370)
        dgvRecords.Location = New Point(10, 10)
        dgvRecords.BackgroundColor = Color.White
        dgvRecords.BorderStyle = BorderStyle.None
        dgvRecords.RowHeadersVisible = False
        dgvRecords.AllowUserToAddRows = False
        dgvRecords.ReadOnly = True
        dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecords.MultiSelect = False
        dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecords.Font = New Font("Segoe UI", 9.5)
        dgvRecords.GridColor = Color.FromArgb(225, 225, 225)
        dgvRecords.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRecords.RowTemplate.Height = 36
        ' Column header style
        dgvRecords.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 20, 20)
        dgvRecords.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvRecords.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9.5, FontStyle.Bold)
        dgvRecords.ColumnHeadersDefaultCellStyle.Padding = New Padding(8, 0, 0, 0)
        dgvRecords.ColumnHeadersHeight = 38
        dgvRecords.EnableHeadersVisualStyles = False
        ' Default row style
        dgvRecords.DefaultCellStyle.Padding = New Padding(6, 0, 0, 0)
        dgvRecords.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 50, 50)
        dgvRecords.DefaultCellStyle.SelectionForeColor = Color.White
        ' Columns
        Dim colID As New DataGridViewTextBoxColumn()
        Dim colType As New DataGridViewTextBoxColumn()
        Dim colDate As New DataGridViewTextBoxColumn()
        Dim colLocation As New DataGridViewTextBoxColumn()
        Dim colStatus As New DataGridViewTextBoxColumn()

        colID.Name = "colID"
        colID.HeaderText = "Record ID"
        colID.FillWeight = 12

        colType.Name = "colType"
        colType.HeaderText = "Incident Type"
        colType.FillWeight = 20

        colDate.Name = "colDate"
        colDate.HeaderText = "Date Reported"
        colDate.FillWeight = 15

        colLocation.Name = "colLocation"
        colLocation.HeaderText = "Location"
        colLocation.FillWeight = 35

        colStatus.Name = "colStatus"
        colStatus.HeaderText = "Status"
        colStatus.FillWeight = 18

        dgvRecords.Columns.AddRange(colID, colType, colDate, colLocation, colStatus)

        ' ── UserControl ──────────────────────────────────────────
        Me.BackColor = Color.FromArgb(240, 242, 245)
        Me.Controls.Add(pnlHeader)
        Me.Controls.Add(pnlToolbar)
        Me.Controls.Add(pnlGridCard)

        pnlGridCard.ResumeLayout(False)
        pnlToolbar.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents dgvRecords As DataGridView

End Class
