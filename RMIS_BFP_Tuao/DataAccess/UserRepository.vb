Imports Microsoft.Data.SqlClient

Public Module UserRepository

    Public Function GetByUsername(username As String) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "SELECT Username, PasswordHash, UserType FROM tbl_Users " &
                "WHERE Username = @username", con)
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

End Module
