Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports RMIS_BFP_Tuao

<TestClass>
Public Class DateTimeHelperTests

    <TestMethod>
    Public Sub FormatResponseTime_ValidTimeSpan_Returns12HourAnd24Hour()
        Dim ts As New TimeSpan(14, 30, 0)
        Dim result = DateTimeHelper.FormatResponseTime(ts)
        Assert.AreEqual("02:30 PM (14:30H)", result)
    End Sub

    <TestMethod>
    Public Sub FormatResponseTime_MorningTime_ReturnsAM()
        Dim ts As New TimeSpan(9, 15, 0)
        Dim result = DateTimeHelper.FormatResponseTime(ts)
        Assert.AreEqual("09:15 AM (09:15H)", result)
    End Sub

    <TestMethod>
    Public Sub FormatResponseTime_NullableNull_ReturnsNotRecorded()
        Dim ts As TimeSpan? = Nothing
        Dim result = DateTimeHelper.FormatResponseTime(ts)
        Assert.AreEqual("Not recorded", result)
    End Sub

    <TestMethod>
    Public Sub FormatIncidentDateTime_ValidDateTime_ReturnsFormattedString()
        Dim dt As New DateTime(2026, 5, 12, 16, 45, 0)
        Dim result = DateTimeHelper.FormatIncidentDateTime(dt)
        Assert.AreEqual("05/12/2026 04:45 PM (16:45H)", result)
    End Sub

End Class
