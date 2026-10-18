Imports System.IO
Imports System.Windows.Forms
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports RMIS_BFP_Tuao

<TestClass>
Public Class ManualScreenshotTest

    <TestMethod>
    Public Sub VerifyManualScreenshotsExist()
        For i As Integer = 1 To 6
            Dim p = ManualScreenshotGenerator.GetScreenshotPath(i)
            Assert.IsTrue(File.Exists(p), "Screenshot file for topic " & i & " must exist: " & p)
        Next
    End Sub

    <TestMethod>
    Public Sub VerifyDashboardLayout()
        Dim dash As New UcDashboard()
        dash.Size = New Drawing.Size(1920, 1080)
        
        Dim tlp = TryCast(dash.Controls("tlpCards"), TableLayoutPanel)
        Assert.IsNotNull(tlp, "tlpCards should exist")
        
        Dim pnlAct = TryCast(dash.Controls("pnlActivity"), Panel)
        Assert.IsNotNull(pnlAct, "pnlActivity should exist")
        
        Assert.AreEqual(tlp.Left, pnlAct.Left, "Left margin of cards and activity panel must match")
        Assert.AreEqual(dash.Width - tlp.Right, dash.Width - pnlAct.Right, "Right margin of cards and activity panel must match")
        Assert.AreEqual(pnlAct.Left, dash.Height - pnlAct.Bottom, "Bottom margin of activity panel must match its left margin")
        
        Dim dgv = TryCast(pnlAct.Controls("dgvRecent"), DataGridView)
        Assert.IsNotNull(dgv, "dgvRecent should exist")
        Assert.AreEqual(DockStyle.Fill, dgv.Dock)
        
        ' Ensure all 4 KPI cards are hosted in tlpCards with Dock = Fill
        Assert.AreEqual(4, tlp.ColumnCount)
        For i As Integer = 1 To 4
            Dim card = TryCast(tlp.Controls("pnlCard" & i), Panel)
            Assert.IsNotNull(card, "pnlCard" & i & " must exist inside tlpCards")
            Assert.AreEqual(DockStyle.Fill, card.Dock)
        Next
    End Sub

    <TestMethod>
    Public Sub VerifyStatusDropdownDoesNotContainClosed()
        ' Add Record
        Dim addPage As New UcAddRecord()
        Dim addMethod = GetType(UcAddRecord).GetMethod("UcAddRecord_Load", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
        addMethod.Invoke(addPage, New Object() {Nothing, EventArgs.Empty})
        Dim addCbo = TryCast(addPage.Controls.Find("cboStatus", True).FirstOrDefault(), ComboBox)
        Assert.IsNotNull(addCbo)
        Assert.IsFalse(addCbo.Items.Contains("Closed"), "Add Record cboStatus must not contain 'Closed'")

        ' View Records
        Dim viewPage As New UcViewRecords()
        Dim viewMethod = GetType(UcViewRecords).GetMethod("InitFilters", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance)
        viewMethod.Invoke(viewPage, Nothing)
        Dim viewCmb = TryCast(viewPage.Controls.Find("cmbStatus", True).FirstOrDefault(), ComboBox)
        Assert.IsNotNull(viewCmb)
        Assert.IsFalse(viewCmb.Items.Contains("Closed"), "View Records cmbStatus must not contain 'Closed'")
    End Sub

End Class
