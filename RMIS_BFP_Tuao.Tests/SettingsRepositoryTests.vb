Imports Microsoft.VisualStudio.TestTools.UnitTesting

' Integration tests — require RMIS_TEST_CONNSTR environment variable.
' See IncidentRepositoryTests.vb for setup instructions.
<TestClass>
Public Class SettingsRepositoryTests

    Private Shared _connStr As String = ""

    <ClassInitialize>
    Public Shared Sub ClassInit(ctx As TestContext)
        _connStr = Environment.GetEnvironmentVariable("RMIS_TEST_CONNSTR")
        If String.IsNullOrWhiteSpace(_connStr) Then Return

        Dim tempConfig = System.IO.Path.Combine(Environment.CurrentDirectory, "config.txt")
        System.IO.File.WriteAllText(tempConfig, _connStr)
        DatabaseInitializer.Initialize()
    End Sub

    Private Function SkipIfNoDb() As Boolean
        Return String.IsNullOrWhiteSpace(_connStr)
    End Function

    ' ── GetValue ──────────────────────────────────────────────────────────

    <TestMethod>
    Public Sub GetValue_SeededKey_ReturnsValue()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        Dim name = SettingsRepository.GetValue("StationName", "")
        Assert.IsFalse(String.IsNullOrEmpty(name))
    End Sub

    <TestMethod>
    Public Sub GetValue_MissingKey_ReturnsDefault()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        Dim result = SettingsRepository.GetValue("NoSuchKey_XYZ", "fallback")
        Assert.AreEqual("fallback", result)
    End Sub

    ' ── SetValue (upsert) ─────────────────────────────────────────────────

    <TestMethod>
    Public Sub SetValue_NewKey_CanBeReadBack()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        Dim key = "TestKey_" & Guid.NewGuid().ToString("N").Substring(0, 8)
        SettingsRepository.SetValue(key, "hello")
        Assert.AreEqual("hello", SettingsRepository.GetValue(key, ""))
    End Sub

    <TestMethod>
    Public Sub SetValue_ExistingKey_OverwritesValue()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        SettingsRepository.SetValue("StationName", "Updated Station")
        Assert.AreEqual("Updated Station", SettingsRepository.GetValue("StationName", ""))

        ' Restore original value so it does not affect the seeded default
        SettingsRepository.SetValue("StationName", "BFP Tuao Fire Station")
    End Sub

End Class
