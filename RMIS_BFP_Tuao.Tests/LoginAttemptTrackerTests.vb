Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports RMIS_BFP_Tuao.Helpers

<TestClass>
<DoNotParallelize>
Public Class LoginAttemptTrackerTests

    <TestInitialize>
    Public Sub Setup()
        LoginAttemptTracker.ClearAll()
    End Sub

    <TestMethod>
    Public Sub FirstFailedAttempt_ReturnsTwoRemainingAttempts_AndNotLockedOut()
        Dim uname = "testuser_first_" & Guid.NewGuid().ToString("N")
        Dim result = LoginAttemptTracker.RecordFailedAttempt(uname)
        Assert.IsFalse(result.IsLockedOut)
        Assert.AreEqual(2, result.RemainingAttempts)
        Assert.AreEqual(0, result.LockoutSeconds)

        Dim lockout = LoginAttemptTracker.CheckLockout(uname)
        Assert.IsFalse(lockout.IsLockedOut)
        Assert.AreEqual(0, lockout.RemainingSeconds)
    End Sub

    <TestMethod>
    Public Sub SecondFailedAttempt_ReturnsOneRemainingAttempt_AndNotLockedOut()
        Dim uname = "testuser_second_" & Guid.NewGuid().ToString("N")
        LoginAttemptTracker.RecordFailedAttempt(uname)
        Dim result = LoginAttemptTracker.RecordFailedAttempt(uname)
        Assert.IsFalse(result.IsLockedOut)
        Assert.AreEqual(1, result.RemainingAttempts)
        Assert.AreEqual(0, result.LockoutSeconds)
    End Sub

    <TestMethod>
    Public Sub ThirdFailedAttempt_TriggersLockout()
        Dim uname = "testuser_third_" & Guid.NewGuid().ToString("N")
        LoginAttemptTracker.RecordFailedAttempt(uname)
        LoginAttemptTracker.RecordFailedAttempt(uname)
        Dim result = LoginAttemptTracker.RecordFailedAttempt(uname)

        Assert.IsTrue(result.IsLockedOut)
        Assert.AreEqual(0, result.RemainingAttempts)
        Assert.AreEqual(LoginAttemptTracker.LockoutDurationSeconds, result.LockoutSeconds)

        Dim lockout = LoginAttemptTracker.CheckLockout(uname)
        Assert.IsTrue(lockout.IsLockedOut)
        Assert.IsTrue(lockout.RemainingSeconds > 0)
    End Sub

    <TestMethod>
    Public Sub Attempts_AreCaseInsensitive()
        Dim prefix = "Admin_" & Guid.NewGuid().ToString("N")
        LoginAttemptTracker.RecordFailedAttempt(prefix)
        Dim result = LoginAttemptTracker.RecordFailedAttempt(prefix.ToLowerInvariant())
        Assert.IsFalse(result.IsLockedOut)
        Assert.AreEqual(1, result.RemainingAttempts)

        Dim third = LoginAttemptTracker.RecordFailedAttempt(prefix.ToUpperInvariant())
        Assert.IsTrue(third.IsLockedOut)
    End Sub

    <TestMethod>
    Public Sub Reset_ClearsFailedAttemptsAndLockout()
        Dim uname = "testuser_reset_" & Guid.NewGuid().ToString("N")
        LoginAttemptTracker.RecordFailedAttempt(uname)
        LoginAttemptTracker.RecordFailedAttempt(uname)
        LoginAttemptTracker.Reset(uname)

        Dim result = LoginAttemptTracker.RecordFailedAttempt(uname)
        Assert.IsFalse(result.IsLockedOut)
        Assert.AreEqual(2, result.RemainingAttempts)
    End Sub

    <TestMethod>
    Public Sub BlankOrNullUsername_HandledSafely()
        Dim result = LoginAttemptTracker.RecordFailedAttempt("")
        Assert.IsFalse(result.IsLockedOut)

        Dim lockout = LoginAttemptTracker.CheckLockout(Nothing)
        Assert.IsFalse(lockout.IsLockedOut)
    End Sub

End Class
