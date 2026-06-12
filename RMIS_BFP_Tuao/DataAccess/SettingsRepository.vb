Imports Microsoft.Data.SqlClient

Public Module SettingsRepository

    Public Function GetValue(key As String, Optional defaultValue As String = "") As String
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "SELECT SettingValue FROM tbl_Settings WHERE SettingKey = @key", con)
                cmd.Parameters.AddWithValue("@key", key)
                Dim result = cmd.ExecuteScalar()
                If result Is Nothing OrElse IsDBNull(result) Then Return defaultValue
                Return result.ToString()
            End Using
        End Using
    End Function

    Public Sub SetValue(key As String, value As String)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim sql As String =
                "IF EXISTS (SELECT 1 FROM tbl_Settings WHERE SettingKey = @key)
                     UPDATE tbl_Settings SET SettingValue = @value WHERE SettingKey = @key
                 ELSE
                     INSERT INTO tbl_Settings (SettingKey, SettingValue) VALUES (@key, @value)"
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@key",   key)
                cmd.Parameters.AddWithValue("@value", value)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Module
