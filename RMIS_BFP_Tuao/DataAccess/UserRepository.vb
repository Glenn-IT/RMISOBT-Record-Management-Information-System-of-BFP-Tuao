Imports Microsoft.Data.SqlClient

Public Module UserRepository

    Public Function GetByUsername(username As String) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "SELECT Username, PasswordHash, UserType, SecurityQuestion, SecurityAnswerHash FROM tbl_Users " &
                "WHERE Username = @username COLLATE Latin1_General_CS_AS", con)
                cmd.Parameters.AddWithValue("@username", username)
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Sub Insert(username As String, passwordHash As String, userType As String)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "INSERT INTO tbl_Users (Username, PasswordHash, UserType) " &
                "VALUES (@username, @hash, @type)", con)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@hash",     passwordHash)
                cmd.Parameters.AddWithValue("@type",     userType)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateUsername(oldUsername As String, newUsername As String)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "UPDATE tbl_Users SET Username = @new WHERE Username = @old", con)
                cmd.Parameters.AddWithValue("@new", newUsername)
                cmd.Parameters.AddWithValue("@old", oldUsername)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdatePassword(username As String, newPasswordHash As String)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "UPDATE tbl_Users SET PasswordHash = @hash WHERE Username = @username", con)
                cmd.Parameters.AddWithValue("@hash",     newPasswordHash)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function GetSecurityQuestion(username As String) As String
        Dim dt = GetByUsername(username)
        If dt.Rows.Count = 0 Then Return ""
        Return dt.Rows(0)("SecurityQuestion").ToString()
    End Function

    Public Function VerifySecurityAnswer(username As String, answer As String) As Boolean
        Dim dt = GetByUsername(username)
        If dt.Rows.Count = 0 Then Return False
        Dim storedHash = dt.Rows(0)("SecurityAnswerHash").ToString()
        If storedHash = "" Then Return False
        Return PasswordHelper.VerifyPassword(answer.Trim().ToLower(), storedHash)
    End Function

    Public Sub UpdateSecurityQuestion(username As String, question As String, answerHash As String)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "UPDATE tbl_Users SET SecurityQuestion = @q, SecurityAnswerHash = @a WHERE Username = @u", con)
                cmd.Parameters.AddWithValue("@q", question)
                cmd.Parameters.AddWithValue("@a", answerHash)
                cmd.Parameters.AddWithValue("@u", username)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function GetAllUsers() As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "SELECT UserID, Username, UserType, CreatedAt FROM tbl_Users ORDER BY UserID ASC", con)
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Sub DeleteUser(username As String)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "DELETE FROM tbl_Users WHERE Username = @username", con)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateUser(oldUsername As String, newUsername As String, newUserType As String, Optional newPasswordHash As String = "")
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim sql As String
            If Not String.IsNullOrEmpty(newPasswordHash) Then
                sql = "UPDATE tbl_Users SET Username = @newUsername, UserType = @newRole, PasswordHash = @newPasswordHash WHERE Username = @oldUsername"
            Else
                sql = "UPDATE tbl_Users SET Username = @newUsername, UserType = @newRole WHERE Username = @oldUsername"
            End If
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@newUsername", newUsername)
                cmd.Parameters.AddWithValue("@newRole", newUserType)
                If Not String.IsNullOrEmpty(newPasswordHash) Then
                    cmd.Parameters.AddWithValue("@newPasswordHash", newPasswordHash)
                End If
                cmd.Parameters.AddWithValue("@oldUsername", oldUsername)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function Exists(username As String) As Boolean
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "SELECT COUNT(1) FROM tbl_Users WHERE Username = @username COLLATE Latin1_General_CS_AS", con)
                cmd.Parameters.AddWithValue("@username", username)
                Dim count = CInt(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

End Module
