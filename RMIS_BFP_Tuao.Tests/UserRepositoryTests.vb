Imports Microsoft.VisualStudio.TestTools.UnitTesting

' Integration tests — require RMIS_TEST_CONNSTR environment variable.
' See IncidentRepositoryTests.vb for setup instructions.
<TestClass>
Public Class UserRepositoryTests

    Private Shared _connStr As String = ""
    Private Shared _testUser As String = "test_user_" & Guid.NewGuid().ToString("N").Substring(0, 8)

    <ClassInitialize>
    Public Shared Sub ClassInit(ctx As TestContext)
        _connStr = Environment.GetEnvironmentVariable("RMIS_TEST_CONNSTR")
        If String.IsNullOrWhiteSpace(_connStr) Then Return

        Dim tempConfig = System.IO.Path.Combine(Environment.CurrentDirectory, "config.txt")
        System.IO.File.WriteAllText(tempConfig, _connStr)
        DatabaseInitializer.Initialize()

        ' Clean up any leftover test user from a previous run
        Using con As New Microsoft.Data.SqlClient.SqlConnection(_connStr)
            con.Open()
            Using cmd As New Microsoft.Data.SqlClient.SqlCommand(
                "DELETE FROM tbl_Users WHERE Username LIKE 'test_user_%'", con)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function SkipIfNoDb() As Boolean
        Return String.IsNullOrWhiteSpace(_connStr)
    End Function

    ' ── Insert + GetByUsername ─────────────────────────────────────────────

    <TestMethod>
    Public Sub Insert_ThenGetByUsername_ReturnsRow()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        Dim hash = PasswordHelper.HashPassword("testpass")
        UserRepository.Insert(_testUser, hash, Constants.UserTypeStaff)

        Dim dt = UserRepository.GetByUsername(_testUser)
        Assert.AreEqual(1, dt.Rows.Count)
        Assert.AreEqual(_testUser, dt.Rows(0)("Username").ToString())
        Assert.AreEqual(Constants.UserTypeStaff, dt.Rows(0)("UserType").ToString())
    End Sub

    <TestMethod>
    Public Sub GetByUsername_NonExistent_ReturnsEmptyTable()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        Dim dt = UserRepository.GetByUsername("nobody_xyz_999")
        Assert.AreEqual(0, dt.Rows.Count)
    End Sub

    ' ── UpdateUsername ─────────────────────────────────────────────────────

    <TestMethod>
    Public Sub UpdateUsername_ChangesUsernameInDB()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        Dim oldName = "test_user_rename_" & Guid.NewGuid().ToString("N").Substring(0, 6)
        Dim newName = oldName & "_new"
        UserRepository.Insert(oldName, PasswordHelper.HashPassword("pw"), Constants.UserTypeStaff)

        UserRepository.UpdateUsername(oldName, newName)

        Assert.AreEqual(0, UserRepository.GetByUsername(oldName).Rows.Count)
        Assert.AreEqual(1, UserRepository.GetByUsername(newName).Rows.Count)
    End Sub

    ' ── UpdatePassword ─────────────────────────────────────────────────────

    <TestMethod>
    Public Sub UpdatePassword_NewHashVerifiesCorrectly()
        If SkipIfNoDb() Then Assert.Inconclusive("RMIS_TEST_CONNSTR not set — skipping DB test.") : Return
        Dim uname = "test_user_pw_" & Guid.NewGuid().ToString("N").Substring(0, 6)
        UserRepository.Insert(uname, PasswordHelper.HashPassword("oldpass"), Constants.UserTypeStaff)

        Dim newHash = PasswordHelper.HashPassword("newpass")
        UserRepository.UpdatePassword(uname, newHash)

        Dim dt = UserRepository.GetByUsername(uname)
        Dim storedHash = dt.Rows(0)("PasswordHash").ToString()
        Assert.IsTrue(PasswordHelper.VerifyPassword("newpass", storedHash))
        Assert.IsFalse(PasswordHelper.VerifyPassword("oldpass", storedHash))
    End Sub

End Class
