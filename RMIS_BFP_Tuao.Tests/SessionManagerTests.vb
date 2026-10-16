Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass, DoNotParallelize>
Public Class SessionManagerTests

    Private Shared ReadOnly _syncLock As New Object()

    <TestInitialize>
    Public Sub Setup()
        SyncLock _syncLock
            SessionManager.Clear()
        End SyncLock
    End Sub

    <TestCleanup>
    Public Sub Cleanup()
        SyncLock _syncLock
            SessionManager.Clear()
        End SyncLock
    End Sub

    <TestMethod>
    Public Sub Clear_ResetsAllFields()
        SyncLock _syncLock
            SessionManager.Username = "admin"
            SessionManager.UserType = "Admin"
            SessionManager.UserCode = "USR-001"

            SessionManager.Clear()

            Assert.AreEqual("", SessionManager.Username)
            Assert.AreEqual("", SessionManager.UserType)
            Assert.AreEqual("", SessionManager.UserCode)
        End SyncLock
    End Sub

    <TestMethod>
    Public Sub Properties_CanBeSetAndRead()
        SyncLock _syncLock
            SessionManager.Username = "testuser"
            SessionManager.UserType = "Sub Admin"
            SessionManager.UserCode = "USR-002"

            Assert.AreEqual("testuser",  SessionManager.Username)
            Assert.AreEqual("Sub Admin", SessionManager.UserType)
            Assert.AreEqual("USR-002",   SessionManager.UserCode)
        End SyncLock
    End Sub

    <TestMethod>
    Public Sub DefaultState_IsEmpty()
        SyncLock _syncLock
            SessionManager.Clear()
            Assert.AreEqual("", SessionManager.Username)
            Assert.AreEqual("", SessionManager.UserType)
            Assert.AreEqual("", SessionManager.UserCode)
            Assert.IsFalse(SessionManager.IsSuperAdmin())
            Assert.IsFalse(SessionManager.IsSubAdmin())
        End SyncLock
    End Sub

    <TestMethod>
    Public Sub IsSuperAdmin_AdminAndSuperAdmin_ReturnsTrue()
        SyncLock _syncLock
            SessionManager.UserType = "Super Admin"
            Assert.IsTrue(SessionManager.IsSuperAdmin())
            Assert.IsFalse(SessionManager.IsSubAdmin())

            SessionManager.UserType = "Admin"
            Assert.IsTrue(SessionManager.IsSuperAdmin())
            Assert.IsFalse(SessionManager.IsSubAdmin())
        End SyncLock
    End Sub

    <TestMethod>
    Public Sub IsSubAdmin_SubAdmin_ReturnsTrue()
        SyncLock _syncLock
            SessionManager.UserType = "Sub Admin"
            Assert.IsTrue(SessionManager.IsSubAdmin())
            Assert.IsFalse(SessionManager.IsSuperAdmin())
        End SyncLock
    End Sub

End Class
