Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        lblTopDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")
        lblTopUser.Text = "[ " & SessionManager.Username & " ]"
        ApplyRoleRestrictions()
        LoadPage(New UcUnderConstruction()) ' GATE v1.01
        SetActiveButton(btnNavDashboard)
    End Sub

    Private Sub ApplyRoleRestrictions()
        ' Role restrictions restored at v1.04 when Settings is unlocked
    End Sub

    ' ?? Page Loader: clears container and loads a UserControl ?????
    Public Sub LoadPage(page As UserControl)
        pnlPageContainer.Controls.Clear()
        page.Dock = DockStyle.Fill
        pnlPageContainer.Controls.Add(page)
        page.BringToFront()
    End Sub

    ' ?? Sidebar Navigation ????????????????????????????????????????
    Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
        SetActiveButton(btnNavDashboard)
        LoadPage(New UcUnderConstruction()) ' GATE v1.01
    End Sub

    Private Sub btnNavAddRecord_Click(sender As Object, e As EventArgs) Handles btnNavAddRecord.Click
        SetActiveButton(btnNavAddRecord)
        LoadPage(New UcUnderConstruction()) ' GATE v1.01
    End Sub

    Private Sub btnNavViewRecords_Click(sender As Object, e As EventArgs) Handles btnNavViewRecords.Click
        SetActiveButton(btnNavViewRecords)
        LoadPage(New UcUnderConstruction()) ' GATE v1.02
    End Sub

    Private Sub btnNavReports_Click(sender As Object, e As EventArgs) Handles btnNavReports.Click
        SetActiveButton(btnNavReports)
        LoadPage(New UcUnderConstruction()) ' GATE v1.03
    End Sub

    Private Sub btnNavSettings_Click(sender As Object, e As EventArgs) Handles btnNavSettings.Click
        SetActiveButton(btnNavSettings)
        LoadPage(New UcUnderConstruction()) ' GATE v1.04
    End Sub

    Private Sub btnNavDevelopers_Click(sender As Object, e As EventArgs) Handles btnNavDevelopers.Click
        SetActiveButton(btnNavDevelopers)
        LoadPage(New UcUnderConstruction()) ' GATE v1.05
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Logout",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess, "User logged out.")
            SessionManager.Clear()
            Dim login As New LoginForm()
            login.Show()
            Me.Close()
        End If
    End Sub

    ' ?? Helper: highlight the active sidebar button ???????????????
    Public Sub SetActiveButton(activeBtn As Button)
        Dim navButtons As Button() = {
            btnNavDashboard, btnNavAddRecord, btnNavViewRecords,
            btnNavReports, btnNavSettings, btnNavDevelopers
        }
        For Each btn In navButtons
            btn.BackColor = Color.FromArgb(160, 18, 18)
            btn.ForeColor = Color.FromArgb(255, 220, 220)
            btn.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        Next
        activeBtn.BackColor = Color.FromArgb(220, 50, 50)
        activeBtn.ForeColor = Color.White
        activeBtn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
    End Sub

End Class
