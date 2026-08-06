Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class RecordModelTests

    <TestMethod>
    Public Sub Properties_SetAndGet_ReturnExpectedValues()
        Dim incidentDate = New DateTime(2026, 1, 15, 16, 37, 0)
        Dim r As New RecordModel() With {
            .RecordID           = "INC-2026-001",
            .IncidentType       = "Structure Fire",
            .IncidentDateTime   = incidentDate,
            .InvolvedProperty   = "Commercial Building",
            .Address            = "Brgy. Centro, Tuao",
            .OwnerOccupant      = "Maria Santos",
            .CallerInformation  = "Juan Dela Cruz",
            .AlarmLevel         = "1st Alarm",
            .ResponseTime       = New TimeSpan(16, 45, 0),
            .CauseOfFire        = "Electrical short circuit",
            .Casualties         = "2",
            .DamageEstimate     = "500000",
            .Remarks            = "Fully extinguished.",
            .Status             = "Resolved"
        }

        Assert.AreEqual("INC-2026-001",              r.RecordID)
        Assert.AreEqual("Structure Fire",             r.IncidentType)
        Assert.AreEqual(incidentDate,                 r.IncidentDateTime)
        Assert.AreEqual("Commercial Building",        r.InvolvedProperty)
        Assert.AreEqual("Brgy. Centro, Tuao",        r.Address)
        Assert.AreEqual("Maria Santos",               r.OwnerOccupant)
        Assert.AreEqual("Juan Dela Cruz",             r.CallerInformation)
        Assert.AreEqual("1st Alarm",                  r.AlarmLevel)
        Assert.AreEqual(New TimeSpan(16, 45, 0),      r.ResponseTime)
        Assert.AreEqual("Electrical short circuit",   r.CauseOfFire)
        Assert.AreEqual("2",                          r.Casualties)
        Assert.AreEqual("500000",                     r.DamageEstimate)
        Assert.AreEqual("Fully extinguished.",        r.Remarks)
        Assert.AreEqual("Resolved",                   r.Status)
    End Sub

    <TestMethod>
    Public Sub Properties_DefaultValues_AreNull()
        Dim r As New RecordModel()
        Assert.IsNull(r.RecordID)
        Assert.IsNull(r.IncidentType)
        Assert.IsNull(r.InvolvedProperty)
        Assert.IsNull(r.Address)
        Assert.IsNull(r.Status)
        Assert.IsFalse(r.ResponseTime.HasValue)
    End Sub

    <TestMethod>
    Public Sub RecordID_CanBeUpdated()
        Dim r As New RecordModel() With {.RecordID = "INC-2026-001"}
        r.RecordID = "INC-2026-002"
        Assert.AreEqual("INC-2026-002", r.RecordID)
    End Sub

End Class
