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
        lblWelcomeSub.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        lblWelcomeSub.ForeColor = Color.Gray
        lblWelcomeSub.AutoSize = False
        lblWelcomeSub.Size = New Size(500, 24)
        lblWelcomeSub.Location = New Point(24, 56)

        ' Card 1 — Total Records
        pnlCard1.Size = New Size(188, 100)
        pnlCard1.Location = New Point(24, 90)
        pnlCard1.BackColor = Color.White
        lblCard1Icon.Text = "REC"
        lblCard1Icon.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblCard1Icon.ForeColor = Color.FromArgb(180, 20, 20)
        lblCard1Icon.AutoSize = False
        lblCard1Icon.Size = New Size(56, 70)
        lblCard1Icon.Location = New Point(12, 15)
        lblCard1Icon.TextAlign = ContentAlignment.MiddleCenter
        lblCard1Title.Text = "Total Records"
        lblCard1Title.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular)
        lblCard1Title.ForeColor = Color.Gray
        lblCard1Title.AutoSize = False
        lblCard1Title.Size = New Size(110, 22)
        lblCard1Title.Location = New Point(72, 22)
        lblCard1Value.Text = "0"
        lblCard1Value.Font = New Font("Segoe UI", 22, FontStyle.Bold)
        lblCard1Value.ForeColor = Color.FromArgb(180, 20, 20)
        lblCard1Value.AutoSize = False
        lblCard1Value.Size = New Size(110, 40)
        lblCard1Value.Location = New Point(70, 44)
        pnlCard1.Controls.Add(lblCard1Icon)
        pnlCard1.Controls.Add(lblCard1Title)
        pnlCard1.Controls.Add(lblCard1Value)

        ' Card 2 — Active Cases
        pnlCard2.Size = New Size(188, 100)
        pnlCard2.Location = New Point(224, 90)
        pnlCard2.BackColor = Color.White
        lblCard2Icon.Text = "ACT"
        lblCard2Icon.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblCard2Icon.ForeColor = Color.FromArgb(220, 120, 0)
        lblCard2Icon.AutoSize = False
        lblCard2Icon.Size = New Size(56, 70)
        lblCard2Icon.Location = New Point(12, 15)
        lblCard2Icon.TextAlign = ContentAlignment.MiddleCenter
        lblCard2Title.Text = "Active Cases"
        lblCard2Title.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular)
        lblCard2Title.ForeColor = Color.Gray
        lblCard2Title.AutoSize = False
        lblCard2Title.Size = New Size(110, 22)
        lblCard2Title.Location = New Point(72, 22)
        lblCard2Value.Text = "0"
        lblCard2Value.Font = New Font("Segoe UI", 22, FontStyle.Bold)
        lblCard2Value.ForeColor = Color.FromArgb(220, 120, 0)
        lblCard2Value.AutoSize = False
        lblCard2Value.Size = New Size(110, 40)
        lblCard2Value.Location = New Point(70, 44)
        pnlCard2.Controls.Add(lblCard2Icon)
        pnlCard2.Controls.Add(lblCard2Title)
        pnlCard2.Controls.Add(lblCard2Value)

        ' Card 3 — Resolved
        pnlCard3.Size = New Size(188, 100)
        pnlCard3.Location = New Point(424, 90)
        pnlCard3.BackColor = Color.White
        lblCard3Icon.Text = "OK"
        lblCard3Icon.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblCard3Icon.ForeColor = Color.FromArgb(30, 130, 30)
        lblCard3Icon.AutoSize = False
        lblCard3Icon.Size = New Size(56, 70)
        lblCard3Icon.Location = New Point(12, 15)
        lblCard3Icon.TextAlign = ContentAlignment.MiddleCenter
        lblCard3Title.Text = "Resolved"
        lblCard3Title.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular)
        lblCard3Title.ForeColor = Color.Gray
        lblCard3Title.AutoSize = False
        lblCard3Title.Size = New Size(110, 22)
        lblCard3Title.Location = New Point(72, 22)
        lblCard3Value.Text = "0"
        lblCard3Value.Font = New Font("Segoe UI", 22, FontStyle.Bold)
        lblCard3Value.ForeColor = Color.FromArgb(30, 130, 30)
        lblCard3Value.AutoSize = False
        lblCard3Value.Size = New Size(110, 40)
        lblCard3Value.Location = New Point(70, 44)
        pnlCard3.Controls.Add(lblCard3Icon)
        pnlCard3.Controls.Add(lblCard3Title)
        pnlCard3.Controls.Add(lblCard3Value)

        ' Card 4 — Personnel
        pnlCard4.Size = New Size(188, 100)
        pnlCard4.Location = New Point(624, 90)
        pnlCard4.BackColor = Color.White
        lblCard4Icon.Text = "PRS"
        lblCard4Icon.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblCard4Icon.ForeColor = Color.FromArgb(20, 80, 180)
        lblCard4Icon.AutoSize = False
        lblCard4Icon.Size = New Size(56, 70)
        lblCard4Icon.Location = New Point(12, 15)
        lblCard4Icon.TextAlign = ContentAlignment.MiddleCenter
        lblCard4Title.Text = "Personnel"
        lblCard4Title.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular)
        lblCard4Title.ForeColor = Color.Gray
        lblCard4Title.AutoSize = False
        lblCard4Title.Size = New Size(110, 22)
        lblCard4Title.Location = New Point(72, 22)
        lblCard4Value.Text = "0"
        lblCard4Value.Font = New Font("Segoe UI", 22, FontStyle.Bold)
        lblCard4Value.ForeColor = Color.FromArgb(20, 80, 180)
        lblCard4Value.AutoSize = False
        lblCard4Value.Size = New Size(110, 40)
        lblCard4Value.Location = New Point(70, 44)
        pnlCard4.Controls.Add(lblCard4Icon)
        pnlCard4.Controls.Add(lblCard4Title)
        pnlCard4.Controls.Add(lblCard4Value)

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
