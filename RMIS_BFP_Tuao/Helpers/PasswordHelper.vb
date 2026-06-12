Public Module PasswordHelper

    Public Function HashPassword(plain As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(plain)
    End Function

    Public Function VerifyPassword(plain As String, hash As String) As Boolean
        Return BCrypt.Net.BCrypt.Verify(plain, hash)
    End Function

End Module
