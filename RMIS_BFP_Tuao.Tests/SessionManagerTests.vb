Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class SessionManagerTests

    <TestInitialize>
    Public Sub Setup()
        SessionManager.Clear()
    End Sub

    <TestMethod>
    Public Sub Clear_ResetsAllFields()
        SessionManager.Username = "admin"
        SessionManager.UserType = "Admin"
        SessionManager.UserCode = "USR-001"

        SessionManager.Clear()

        Assert.AreEqual("", SessionManager.Username)
        Assert.AreEqual("", SessionManager.UserType)
        Assert.AreEqual("", SessionManager.UserCode)
    End Sub

    <TestMethod>
    Public Sub Properties_CanBeSetAndRead()
        SessionManager.Username = "testuser"
        SessionManager.UserType = "Staff"
        SessionManager.UserCode = "USR-002"

        Assert.AreEqual("testuser", SessionManager.Username)
        Assert.AreEqual("Staff",    SessionManager.UserType)
        Assert.AreEqual("USR-002",  SessionManager.UserCode)
    End Sub

    <TestMethod>
    Public Sub DefaultState_IsEmpty()
        Assert.AreEqual("", SessionManager.Username)
        Assert.AreEqual("", SessionManager.UserType)
        Assert.AreEqual("", SessionManager.UserCode)
    End Sub

End Class
