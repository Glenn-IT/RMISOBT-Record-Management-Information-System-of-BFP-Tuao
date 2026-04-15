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

        lblPageTitle     = New Label()
        lblWelcomeSub    = New Label()
        pnlCard1         = New Panel()
        pnlCard2         = New Panel()
        pnlCard3         = New Panel()
        pnlCard4         = New Panel()
        lblCard1Icon     = New Label()
        lblCard1Title    = New Label()
        lblCard1Value    = New Label()
        lblCard2Icon     = New Label()
        lblCard2Title    = New Label()
        lblCard2Value    = New Label()
        lblCard3Icon     = New Label()
        lblCard3Title    = New Label()
        lblCard3Value    = New Label()
        lblCard4Icon     = New Label()
        lblCard4Title    = New Label()
        lblCard4Value    = New Label()
        pnlActivity      = New Panel()
        lblActivityTitle = New Label()
        dgvRecent        = New DataGridView()

        pnlCard1.SuspendLayout()
        pnlCard2.SuspendLayout()
        pnlCard3.SuspendLayout()
        pnlCard4.SuspendLayout()
        pnlActivity.SuspendLayout()
        Me.SuspendLayout()

        ' Page title
        lblPageTitle.Text = "Dashboard Overview"
        lblPageTitle.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.FromArgb(30, 30, 30)
        lblPageTitle.AutoSize = False
        lblPageTitle.Size = New Size(500, 36)
        lblPageTitle.Location = New Point(24, 20)

        lblWelcomeSub.Text = "Welcome, Admin"
        lblWelcomeSub.Font = New Font("Segoe UI", 9.5, FontStyle.Regular)
        lblWelcomeSub.ForeColor = Color.Gray
        lblWelcomeSub.AutoSize = False
        lblWelcomeSub.Size = New Size(500, 24)
        lblWelcomeSub.Location = New Point(24, 56)

        ' Summary card builder
        Dim MakeCard As Action(Of Panel, Label, Label, Label, Integer, Color, String, String, String) =
            Sub(pnl As Panel, ico As Label, ttl As Label, val As Label,
                x As Integer, accent As Color,
                iconTxt As String, titleTxt As String, valueTxt As String)

                pnl.Size = New Size(188, 100)
                pnl.Location = New Point(x, 90)
                pnl.BackColor = Color.White

                ico.Text = iconTxt
                ico.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                ico.ForeColor = accent
                ico.AutoSize = False
                ico.Size = New Size(56, 70)
                ico.Location = New Point(12, 15)
                ico.TextAlign = ContentAlignment.MiddleCenter

                ttl.Text = titleTxt
                ttl.Font = New Font("Segoe UI", 8.5, FontStyle.Regular)
                ttl.ForeColor = Color.Gray
                ttl.AutoSize = False
                ttl.Size = New Size(110, 22)
                ttl.Location = New Point(72, 22)

                val.Text = valueTxt
                val.Font = New Font("Segoe UI", 22, FontStyle.Bold)
                val.ForeColor = accent
                val.AutoSize = False
                val.Size = New Size(110, 40)
                val.Location = New Point(70, 44)

                pnl.Controls.Add(ico)
                pnl.Controls.Add(ttl)
                pnl.Controls.Add(val)
            End Sub

        MakeCard(pnlCard1, lblCard1Icon, lblCard1Title, lblCard1Value,
                 24, Color.FromArgb(180, 20, 20), "REC", "Total Records", "0")
        MakeCard(pnlCard2, lblCard2Icon, lblCard2Title, lblCard2Value,
                 224, Color.FromArgb(220, 120, 0), "ACT", "Active Cases", "0")
        MakeCard(pnlCard3, lblCard3Icon, lblCard3Title, lblCard3Value,
                 424, Color.FromArgb(30, 130, 30), "OK", "Resolved", "0")
        MakeCard(pnlCard4, lblCard4Icon, lblCard4Title, lblCard4Value,
                 624, Color.FromArgb(20, 80, 180), "PRS", "Personnel", "0")

        ' Recent activity panel
        pnlActivity.Size = New Size(820, 310)
        pnlActivity.Location = New Point(24, 210)
        pnlActivity.BackColor = Color.White
        pnlActivity.Controls.Add(lblActivityTitle)
        pnlActivity.Controls.Add(dgvRecent)

        lblActivityTitle.Text = "Recent Records"
        lblActivityTitle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        lblActivityTitle.ForeColor = Color.FromArgb(30, 30, 30)
        lblActivityTitle.AutoSize = False
        lblActivityTitle.Size = New Size(780, 36)
        lblActivityTitle.Location = New Point(16, 10)

        dgvRecent.Size = New Size(788, 254)
        dgvRecent.Location = New Point(16, 46)
        dgvRecent.BackgroundColor = Color.White
        dgvRecent.BorderStyle = BorderStyle.None
        dgvRecent.RowHeadersVisible = False
        dgvRecent.AllowUserToAddRows = False
        dgvRecent.ReadOnly = True
        dgvRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecent.Font = New Font("Segoe UI", 9)
        dgvRecent.GridColor = Color.FromArgb(230, 230, 230)
        dgvRecent.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 20, 20)
        dgvRecent.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvRecent.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgvRecent.ColumnHeadersHeight = 34
        dgvRecent.EnableHeadersVisualStyles = False
        dgvRecent.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 245, 245)
        dgvRecent.Columns.Add("colID", "Record ID")
        dgvRecent.Columns.Add("colType", "Incident Type")
        dgvRecent.Columns.Add("colDate", "Date Reported")
        dgvRecent.Columns.Add("colLocation", "Location")
        dgvRecent.Columns.Add("colStatus", "Status")

        ' UserControl properties
        Me.BackColor = Color.FromArgb(240, 242, 245)
        Me.Controls.Add(lblPageTitle)
        Me.Controls.Add(lblWelcomeSub)
        Me.Controls.Add(pnlCard1)
        Me.Controls.Add(pnlCard2)
        Me.Controls.Add(pnlCard3)
        Me.Controls.Add(pnlCard4)
        Me.Controls.Add(pnlActivity)

        pnlCard4.ResumeLayout(False)
        pnlCard3.ResumeLayout(False)
        pnlCard2.ResumeLayout(False)
        pnlCard1.ResumeLayout(False)
        pnlActivity.ResumeLayout(False)
        Me.ResumeLayout(False)

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

End Class
