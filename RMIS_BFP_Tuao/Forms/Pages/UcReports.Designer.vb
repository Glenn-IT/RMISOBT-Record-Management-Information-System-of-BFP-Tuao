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

        pnlHeader      = New Panel()
        pnlDivider     = New Panel()
        lblPageTitle   = New Label()
        lblPageSub     = New Label()
        pnlSummary     = New Panel()
        lblSumTitle    = New Label()
        pnlCardTotal   = New Panel()
        lblCardTotalTitle = New Label()
        lblCardTotalValue = New Label()
        pnlCardActive  = New Panel()
        lblCardActiveTitle = New Label()
        lblCardActiveValue = New Label()
        pnlCardResolved = New Panel()
        lblCardResolvedTitle = New Label()
        lblCardResolvedValue = New Label()
        pnlCardClosed  = New Panel()
        lblCardClosedTitle = New Label()
        lblCardClosedValue = New Label()
        pnlBreakdown   = New Panel()
        lblBreakTitle  = New Label()
        dgvBreakdown   = New DataGridView()
        btnExport      = New Button()
        btnPrint       = New Button()

        pnlHeader.SuspendLayout()
        pnlSummary.SuspendLayout()
        pnlCardTotal.SuspendLayout()
        pnlCardActive.SuspendLayout()
        pnlCardResolved.SuspendLayout()
        pnlCardClosed.SuspendLayout()
        pnlBreakdown.SuspendLayout()
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
        pnlHeader.Controls.Add(btnExport)
        pnlHeader.Controls.Add(btnPrint)

        lblPageTitle.Text = "Incident Reports"
        lblPageTitle.Font = New Font("Segoe UI", 15, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.FromArgb(30, 30, 30)
        lblPageTitle.AutoSize = False
        lblPageTitle.Size = New Size(600, 34)
        lblPageTitle.Location = New Point(20, 12)

        lblPageSub.Text = "Summary and breakdown of all fire incident records."
        lblPageSub.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblPageSub.ForeColor = Color.Gray
        lblPageSub.AutoSize = False
        lblPageSub.Size = New Size(600, 22)
        lblPageSub.Location = New Point(20, 46)

        pnlDivider.BackColor = Color.FromArgb(180, 20, 20)
        pnlDivider.Size = New Size(880, 3)
        pnlDivider.Location = New Point(20, 78)

        btnExport.Text = "Export CSV"
        btnExport.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        btnExport.Size = New Size(100, 30)
        btnExport.Location = New Point(690, 20)
        btnExport.BackColor = Color.FromArgb(240, 242, 245)
        btnExport.ForeColor = Color.FromArgb(60, 60, 60)
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200)
        btnExport.Cursor = Cursors.Hand

        btnPrint.Text = "Print Report"
        btnPrint.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnPrint.Size = New Size(110, 30)
        btnPrint.Location = New Point(800, 20)
        btnPrint.BackColor = Color.FromArgb(180, 20, 20)
        btnPrint.ForeColor = Color.White
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.Cursor = Cursors.Hand

        ' ????????????????????????????????????????????????????????
        ' Summary stat cards
        ' ????????????????????????????????????????????????????????
        pnlSummary.BackColor = Color.FromArgb(240, 242, 245)
        pnlSummary.Size = New Size(920, 110)
        pnlSummary.Location = New Point(24, 118)
        pnlSummary.Controls.Add(lblSumTitle)
        pnlSummary.Controls.Add(pnlCardTotal)
        pnlSummary.Controls.Add(pnlCardActive)
        pnlSummary.Controls.Add(pnlCardResolved)
        pnlSummary.Controls.Add(pnlCardClosed)

        lblSumTitle.Text = "Summary"
        lblSumTitle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblSumTitle.ForeColor = Color.FromArgb(60, 60, 60)
        lblSumTitle.AutoSize = False
        lblSumTitle.Size = New Size(200, 24)
        lblSumTitle.Location = New Point(0, 0)

        Dim MakeCard As Action(Of Panel, Label, Label, Integer, Color, String, String) =
            Sub(pnl As Panel, ttl As Label, val As Label,
                x As Integer, accent As Color,
                titleTxt As String, valueTxt As String)
                pnl.Size = New Size(206, 72)
                pnl.Location = New Point(x, 28)
                pnl.BackColor = Color.White
                ttl.Text = titleTxt
                ttl.Font = New Font("Segoe UI", 8.5, FontStyle.Regular)
                ttl.ForeColor = Color.Gray
                ttl.AutoSize = False
                ttl.Size = New Size(180, 20)
                ttl.Location = New Point(14, 10)
                val.Text = valueTxt
                val.Font = New Font("Segoe UI", 22, FontStyle.Bold)
                val.ForeColor = accent
                val.AutoSize = False
                val.Size = New Size(180, 38)
                val.Location = New Point(12, 30)
                pnl.Controls.Add(ttl)
                pnl.Controls.Add(val)
            End Sub

        MakeCard(pnlCardTotal,    lblCardTotalTitle,    lblCardTotalValue,    0,   Color.FromArgb(180, 20, 20),   "Total Records",    "0")
        MakeCard(pnlCardActive,   lblCardActiveTitle,   lblCardActiveValue,   214, Color.FromArgb(220, 120, 0),   "Active Cases",     "0")
        MakeCard(pnlCardResolved, lblCardResolvedTitle, lblCardResolvedValue, 428, Color.FromArgb(30, 130, 30),   "Resolved",         "0")
        MakeCard(pnlCardClosed,   lblCardClosedTitle,   lblCardClosedValue,   642, Color.FromArgb(100, 100, 100), "Closed",           "0")

        ' ????????????????????????????????????????????????????????
        ' Breakdown table
        ' ????????????????????????????????????????????????????????
        pnlBreakdown.BackColor = Color.White
        pnlBreakdown.Size = New Size(920, 320)
        pnlBreakdown.Location = New Point(24, 240)
        pnlBreakdown.Controls.Add(lblBreakTitle)
        pnlBreakdown.Controls.Add(dgvBreakdown)

        lblBreakTitle.Text = "Breakdown by Incident Type"
        lblBreakTitle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        lblBreakTitle.ForeColor = Color.FromArgb(30, 30, 30)
        lblBreakTitle.AutoSize = False
        lblBreakTitle.Size = New Size(880, 34)
        lblBreakTitle.Location = New Point(16, 10)

        dgvBreakdown.Size = New Size(888, 264)
        dgvBreakdown.Location = New Point(16, 46)
        dgvBreakdown.BackgroundColor = Color.White
        dgvBreakdown.BorderStyle = BorderStyle.None
        dgvBreakdown.RowHeadersVisible = False
        dgvBreakdown.AllowUserToAddRows = False
        dgvBreakdown.ReadOnly = True
        dgvBreakdown.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBreakdown.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBreakdown.Font = New Font("Segoe UI", 9.5)
        dgvBreakdown.GridColor = Color.FromArgb(225, 225, 225)
        dgvBreakdown.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvBreakdown.RowTemplate.Height = 36
        dgvBreakdown.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 20, 20)
        dgvBreakdown.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvBreakdown.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9.5, FontStyle.Bold)
        dgvBreakdown.ColumnHeadersDefaultCellStyle.Padding = New Padding(8, 0, 0, 0)
        dgvBreakdown.ColumnHeadersHeight = 38
        dgvBreakdown.EnableHeadersVisualStyles = False
        dgvBreakdown.DefaultCellStyle.Padding = New Padding(6, 0, 0, 0)
        dgvBreakdown.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 50, 50)
        dgvBreakdown.DefaultCellStyle.SelectionForeColor = Color.White

        Dim colType As New DataGridViewTextBoxColumn() With {.Name = "colType", .HeaderText = "Incident Type", .FillWeight = 40}
        Dim colCount As New DataGridViewTextBoxColumn() With {.Name = "colCount", .HeaderText = "Total Count", .FillWeight = 20}
        Dim colActive As New DataGridViewTextBoxColumn() With {.Name = "colActive", .HeaderText = "Active", .FillWeight = 15}
        Dim colResolved As New DataGridViewTextBoxColumn() With {.Name = "colResolved", .HeaderText = "Resolved", .FillWeight = 15}
        Dim colOther As New DataGridViewTextBoxColumn() With {.Name = "colOther", .HeaderText = "Other", .FillWeight = 10}
        dgvBreakdown.Columns.AddRange(colType, colCount, colActive, colResolved, colOther)

        Me.BackColor = Color.FromArgb(240, 242, 245)
        Me.Controls.Add(pnlHeader)
        Me.Controls.Add(pnlSummary)
        Me.Controls.Add(pnlBreakdown)

        pnlBreakdown.ResumeLayout(False)
        pnlCardClosed.ResumeLayout(False)
        pnlCardResolved.ResumeLayout(False)
        pnlCardActive.ResumeLayout(False)
        pnlCardTotal.ResumeLayout(False)
        pnlSummary.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader            As Panel
    Friend WithEvents pnlDivider           As Panel
    Friend WithEvents lblPageTitle         As Label
    Friend WithEvents lblPageSub           As Label
    Friend WithEvents btnExport            As Button
    Friend WithEvents btnPrint             As Button
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

End Class
