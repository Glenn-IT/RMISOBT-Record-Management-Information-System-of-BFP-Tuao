Imports Microsoft.Data.SqlClient

Public Module IncidentRepository

    Public Function GetAll() As List(Of RecordModel)
        Dim result As New List(Of RecordModel)()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "SELECT RecordID, IncidentType, DateReported, Location, ReportedBy, " &
                "Casualties, DamageEstimate, Remarks, Status " &
                "FROM tbl_IncidentRecords ORDER BY DateReported DESC", con)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        result.Add(New RecordModel() With {
                            .RecordID      = reader.GetString(0),
                            .IncidentType  = reader.GetString(1),
                            .DateReported  = reader.GetDateTime(2),
                            .Location      = reader.GetString(3),
                            .ReportedBy    = reader.GetString(4),
                            .Casualties    = reader.GetString(5),
                            .DamageEstimate = reader.GetString(6),
                            .Remarks       = reader.GetString(7),
                            .Status        = reader.GetString(8)
                        })
                    End While
                End Using
            End Using
        End Using
        Return result
    End Function

    Public Sub Insert(record As RecordModel)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "INSERT INTO tbl_IncidentRecords " &
                "(RecordID, IncidentType, DateReported, Location, ReportedBy, " &
                " Casualties, DamageEstimate, Remarks, Status) " &
                "VALUES (@id, @type, @date, @loc, @by, @cas, @dmg, @rem, @status)", con)
                cmd.Parameters.AddWithValue("@id",     record.RecordID)
                cmd.Parameters.AddWithValue("@type",   record.IncidentType)
                cmd.Parameters.AddWithValue("@date",   record.DateReported)
                cmd.Parameters.AddWithValue("@loc",    record.Location)
                cmd.Parameters.AddWithValue("@by",     record.ReportedBy)
                cmd.Parameters.AddWithValue("@cas",    record.Casualties)
                cmd.Parameters.AddWithValue("@dmg",    record.DamageEstimate)
                cmd.Parameters.AddWithValue("@rem",    record.Remarks)
                cmd.Parameters.AddWithValue("@status", record.Status)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Update(record As RecordModel)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "UPDATE tbl_IncidentRecords SET " &
                "IncidentType = @type, DateReported = @date, Location = @loc, " &
                "ReportedBy = @by, Casualties = @cas, DamageEstimate = @dmg, " &
                "Remarks = @rem, Status = @status " &
                "WHERE RecordID = @id", con)
                cmd.Parameters.AddWithValue("@id",     record.RecordID)
                cmd.Parameters.AddWithValue("@type",   record.IncidentType)
                cmd.Parameters.AddWithValue("@date",   record.DateReported)
                cmd.Parameters.AddWithValue("@loc",    record.Location)
                cmd.Parameters.AddWithValue("@by",     record.ReportedBy)
                cmd.Parameters.AddWithValue("@cas",    record.Casualties)
                cmd.Parameters.AddWithValue("@dmg",    record.DamageEstimate)
                cmd.Parameters.AddWithValue("@rem",    record.Remarks)
                cmd.Parameters.AddWithValue("@status", record.Status)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Delete(recordID As String)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "DELETE FROM tbl_IncidentRecords WHERE RecordID = @id", con)
                cmd.Parameters.AddWithValue("@id", recordID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function GetNextID() As String
        Dim year = DateTime.Now.Year
        Dim prefix = $"INC-{year}-%"
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "SELECT ISNULL(MAX(CAST(SUBSTRING(RecordID, 10, LEN(RecordID)-9) AS INT)), 0) " &
                "FROM tbl_IncidentRecords WHERE RecordID LIKE @prefix", con)
                cmd.Parameters.AddWithValue("@prefix", prefix)
                Dim maxNum = CInt(cmd.ExecuteScalar())
                Return $"INC-{year}-{(maxNum + 1):D3}"
            End Using
        End Using
    End Function

End Module
