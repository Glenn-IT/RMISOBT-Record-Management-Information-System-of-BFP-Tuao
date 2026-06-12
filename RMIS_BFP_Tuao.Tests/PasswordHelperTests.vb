Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class PasswordHelperTests

    <TestMethod>
    Public Sub HashPassword_ReturnsNonEmptyString()
        Dim hash = PasswordHelper.HashPassword("admin123")
        Assert.IsFalse(String.IsNullOrEmpty(hash))
    End Sub

    <TestMethod>
    Public Sub HashPassword_ProducesDifferentHashEachCall()
        ' BCrypt uses a random salt so two hashes of the same password differ
        Dim hash1 = PasswordHelper.HashPassword("admin123")
        Dim hash2 = PasswordHelper.HashPassword("admin123")
        Assert.AreNotEqual(hash1, hash2)
    End Sub

    <TestMethod>
    Public Sub VerifyPassword_CorrectPassword_ReturnsTrue()
        Dim hash = PasswordHelper.HashPassword("secret")
        Assert.IsTrue(PasswordHelper.VerifyPassword("secret", hash))
    End Sub

    <TestMethod>
    Public Sub VerifyPassword_WrongPassword_ReturnsFalse()
        Dim hash = PasswordHelper.HashPassword("secret")
        Assert.IsFalse(PasswordHelper.VerifyPassword("wrong", hash))
    End Sub

    <TestMethod>
    Public Sub VerifyPassword_EmptyPassword_ReturnsFalse()
        Dim hash = PasswordHelper.HashPassword("secret")
        Assert.IsFalse(PasswordHelper.VerifyPassword("", hash))
    End Sub

    <TestMethod>
    Public Sub HashPassword_LongPassword_Succeeds()
        Dim long_pw = New String("x"c, 72) ' BCrypt max effective length
        Dim hash = PasswordHelper.HashPassword(long_pw)
        Assert.IsTrue(PasswordHelper.VerifyPassword(long_pw, hash))
    End Sub

End Class
