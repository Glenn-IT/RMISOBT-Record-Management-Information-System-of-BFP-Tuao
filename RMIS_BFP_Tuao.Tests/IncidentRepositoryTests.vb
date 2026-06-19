Imports Microsoft.VisualStudio.TestTools.UnitTesting

' Integration tests — require a real SQL Server database.
' Before running: set environment variable RMIS_TEST_CONNSTR to a valid connection string
' pointing to a dedicated test database (NOT the production DB).
' Example:
'   $env:RMIS_TEST_CONNSTR = "Server=.\SQLEXPRESS;Database=RMIS_Test;Trusted_Connection=True;TrustServerCertificate=True;"
' These tests are skipped automatically when the environment variable is not set.
<TestClass>
Public Class IncidentRepositoryTests

    Private Shared _connStr As String = ""

    <ClassInitialize>
    Public Shared Sub ClassInit(ctx As TestContext)
        _connStr = Environment.GetEnvironmentVariable("RMIS_TEST_CONNSTR")
        If String.IsNullOrWhiteSpace(_connStr) Then Return

        ' Point dbconstring at the test DB by writing a temp config.txt
        Dim tempConfig = System.IO.Path.Combine(Environment.CurrentDirectory, "config.txt")
        System.IO.File.WriteAllText(tempConfig, _connStr)

        DatabaseInitializer.Initialize()

        ' Wipe incident table so each run starts clean
        Using con As New Microsoft.Data.SqlClient.SqlConnection(_connStr)
            con.Open()
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(
                "DELETE FROM tbl_IncidentRecords", con)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function SkipIfNoDb() As Boolean
        Return String.IsNullOrWhiteSpace(_connStr)
    End Function

    Private Function MakeRecord(Optional suffix As String = "001") As RecordModel
        Return New RecordModel() With {
            .RecordID       = $"INC-2026-{suffix}",
            .IncidentType   = "Structure Fire",
            .DateReported   = New DateTime(2026, 1, 15),
            .Location       = "Brgy. Centro, Tuao",
            .ReportedBy     = "Test Officer",
            .Casualties     = "0",
            .DamageEstimate = "10000",
            .Remarks        = "Test record",
            .Status         = "Active"
        }
    End Function

    ' ── GetAll ────────────────────────────────────────────────────────────────

    <TestMethod>
    Public Sub GetAll_EmptyTable_ReturnsEmptyList()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        Dim result = IncidentRepository.GetAll()
        Assert.AreEqual(0, result.Count)
    End Sub

    ' ── Insert ────────────────────────────────────────────────────────────────

    <TestMethod>
    Public Sub Insert_ValidRecord_IncreasesCount()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        Dim before = IncidentRepository.GetAll().Count
        IncidentRepository.Insert(MakeRecord("T01"))
        Dim after = IncidentRepository.GetAll().Count
        Assert.AreEqual(before + 1, after)
    End Sub

    <TestMethod>
    Public Sub Insert_Record_CanBeRetrievedByID()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        Dim rec = MakeRecord("T02")
        IncidentRepository.Insert(rec)
        Dim found = IncidentRepository.GetAll().FirstOrDefault(Function(r) r.RecordID = "INC-2026-T02")
        Assert.IsNotNull(found)
        Assert.AreEqual("Structure Fire", found.IncidentType)
        Assert.AreEqual("Brgy. Centro, Tuao", found.Location)
        Assert.AreEqual("Active", found.Status)
    End Sub

    ' ── Update ────────────────────────────────────────────────────────────────

    <TestMethod>
    Public Sub Update_ExistingRecord_ChangesArePersisted()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        Dim rec = MakeRecord("T03")
        IncidentRepository.Insert(rec)

        rec.Status   = "Resolved"
        rec.Remarks  = "Updated remark"
        IncidentRepository.Update(rec)

        Dim updated = IncidentRepository.GetAll().FirstOrDefault(Function(r) r.RecordID = "INC-2026-T03")
        Assert.IsNotNull(updated)
        Assert.AreEqual("Resolved", updated.Status)
        Assert.AreEqual("Updated remark", updated.Remarks)
    End Sub

    ' ── Delete ────────────────────────────────────────────────────────────────

    <TestMethod>
    Public Sub Delete_ExistingRecord_RemovesFromTable()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        Dim rec = MakeRecord("T04")
        IncidentRepository.Insert(rec)
        Assert.IsTrue(IncidentRepository.GetAll().Any(Function(r) r.RecordID = "INC-2026-T04"))

        IncidentRepository.Delete("INC-2026-T04")
        Assert.IsFalse(IncidentRepository.GetAll().Any(Function(r) r.RecordID = "INC-2026-T04"))
    End Sub

    <TestMethod>
    Public Sub Delete_NonExistentRecord_DoesNotThrow()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        IncidentRepository.Delete("INC-9999-999")
    End Sub

    ' ── GetNextID ─────────────────────────────────────────────────────────────

    <TestMethod>
    Public Sub GetNextID_EmptyTable_ReturnsYear001()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        Dim expected = $"INC-{DateTime.Now.Year}-001"
        Assert.AreEqual(expected, IncidentRepository.GetNextID())
    End Sub

    <TestMethod>
    Public Sub GetNextID_AfterInsert_IncrementsSequence()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        Dim first = IncidentRepository.GetNextID()
        IncidentRepository.Insert(MakeRecord(first.Split("-")(2)))
        Dim second = IncidentRepository.GetNextID()
        Assert.AreNotEqual(first, second)
    End Sub

    <TestMethod>
    Public Sub GetNextID_AfterDelete_DoesNotReuseSequence()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        Dim id1 = IncidentRepository.GetNextID()
        IncidentRepository.Insert(MakeRecord(id1.Split("-")(2)))
        Dim id2 = IncidentRepository.GetNextID()
        IncidentRepository.Insert(MakeRecord(id2.Split("-")(2)))

        IncidentRepository.Delete(id2)

        Dim id3 = IncidentRepository.GetNextID()
        Assert.AreNotEqual(id1, id3)
        Assert.AreNotEqual(id2, id3)
    End Sub

End Class
