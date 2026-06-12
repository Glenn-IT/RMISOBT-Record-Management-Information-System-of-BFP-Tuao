Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class RecordModelTests

    <TestMethod>
    Public Sub Properties_SetAndGet_ReturnExpectedValues()
        Dim reportDate = New DateTime(2026, 1, 15)
        Dim r As New RecordModel() With {
            .RecordID       = "INC-2026-001",
            .IncidentType   = "Structure Fire",
            .DateReported   = reportDate,
            .Location       = "Brgy. Centro, Tuao",
            .ReportedBy     = "Juan Dela Cruz",
            .Casualties     = "2",
            .DamageEstimate = "500000",
            .Remarks        = "Fully extinguished.",
            .Status         = "Resolved"
        }

        Assert.AreEqual("INC-2026-001",         r.RecordID)
        Assert.AreEqual("Structure Fire",        r.IncidentType)
        Assert.AreEqual(reportDate,              r.DateReported)
        Assert.AreEqual("Brgy. Centro, Tuao",   r.Location)
        Assert.AreEqual("Juan Dela Cruz",        r.ReportedBy)
        Assert.AreEqual("2",                     r.Casualties)
        Assert.AreEqual("500000",                r.DamageEstimate)
        Assert.AreEqual("Fully extinguished.",   r.Remarks)
        Assert.AreEqual("Resolved",              r.Status)
    End Sub

    <TestMethod>
    Public Sub Properties_DefaultValues_AreNull()
        Dim r As New RecordModel()
        Assert.IsNull(r.RecordID)
        Assert.IsNull(r.IncidentType)
        Assert.IsNull(r.Location)
        Assert.IsNull(r.Status)
    End Sub

    <TestMethod>
    Public Sub RecordID_CanBeUpdated()
        Dim r As New RecordModel() With {.RecordID = "INC-2026-001"}
        r.RecordID = "INC-2026-002"
        Assert.AreEqual("INC-2026-002", r.RecordID)
    End Sub

End Class
