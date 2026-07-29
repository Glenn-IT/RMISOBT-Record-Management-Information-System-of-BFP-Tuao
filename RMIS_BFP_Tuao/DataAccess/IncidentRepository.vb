Imports Microsoft.Data.SqlClient

Public Module IncidentRepository

    Public Function GetAll() As List(Of RecordModel)
        Dim result As New List(Of RecordModel)()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "SELECT RecordID, IncidentType, IncidentDateTime, InvolvedProperty, OwnerOccupant, " &
                "CallerInformation, AlarmLevel, ResponseTime, CauseOfFire, " &
                "Casualties, DamageEstimate, Remarks, Status, AttachmentPath " &
                "FROM tbl_IncidentRecords ORDER BY IncidentDateTime DESC", con)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        result.Add(New RecordModel() With {
                            .RecordID           = reader.GetString(0),
                            .IncidentType       = reader.GetString(1),
                            .IncidentDateTime   = reader.GetDateTime(2),
                            .InvolvedProperty   = reader.GetString(3),
                            .OwnerOccupant      = If(reader.IsDBNull(4), "", reader.GetString(4)),
                            .CallerInformation  = reader.GetString(5),
                            .AlarmLevel         = If(reader.IsDBNull(6), "", reader.GetString(6)),
                            .ResponseTime       = If(reader.IsDBNull(7), CType(Nothing, TimeSpan?), reader.GetTimeSpan(7)),
                            .CauseOfFire        = If(reader.IsDBNull(8), "", reader.GetString(8)),
                            .Casualties         = reader.GetString(9),
                            .DamageEstimate     = reader.GetString(10),
                            .Remarks            = reader.GetString(11),
                            .Status             = reader.GetString(12),
                            .DocumentPath       = If(reader.IsDBNull(13), "", reader.GetString(13))
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
                "(RecordID, IncidentType, IncidentDateTime, InvolvedProperty, OwnerOccupant, " &
                " CallerInformation, AlarmLevel, ResponseTime, CauseOfFire, " &
                " Casualties, DamageEstimate, Remarks, Status, AttachmentPath) " &
                "VALUES (@id, @type, @date, @prop, @owner, @caller, @alarm, @resp, @cause, @cas, @dmg, @rem, @status, @doc)", con)
                cmd.Parameters.AddWithValue("@id",     record.RecordID)
                cmd.Parameters.AddWithValue("@type",   record.IncidentType)
                cmd.Parameters.AddWithValue("@date",   record.IncidentDateTime)
                cmd.Parameters.AddWithValue("@prop",   record.InvolvedProperty)
                cmd.Parameters.AddWithValue("@owner",  If(record.OwnerOccupant, CType(DBNull.Value, Object)))
                cmd.Parameters.AddWithValue("@caller", record.CallerInformation)
                cmd.Parameters.AddWithValue("@alarm",  If(record.AlarmLevel, CType(DBNull.Value, Object)))
                cmd.Parameters.AddWithValue("@resp",   If(record.ResponseTime.HasValue, CType(record.ResponseTime.Value, Object), CType(DBNull.Value, Object)))
                cmd.Parameters.AddWithValue("@cause",  If(record.CauseOfFire, CType(DBNull.Value, Object)))
                cmd.Parameters.AddWithValue("@cas",    record.Casualties)
                cmd.Parameters.AddWithValue("@dmg",    record.DamageEstimate)
                cmd.Parameters.AddWithValue("@rem",    record.Remarks)
                cmd.Parameters.AddWithValue("@status", record.Status)
                cmd.Parameters.AddWithValue("@doc",    If(record.DocumentPath, CType(DBNull.Value, Object)))
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Update(record As RecordModel)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "UPDATE tbl_IncidentRecords SET " &
                "IncidentType = @type, IncidentDateTime = @date, InvolvedProperty = @prop, OwnerOccupant = @owner, " &
                "CallerInformation = @caller, AlarmLevel = @alarm, ResponseTime = @resp, CauseOfFire = @cause, " &
                "Casualties = @cas, DamageEstimate = @dmg, " &
                "Remarks = @rem, Status = @status, AttachmentPath = @doc " &
                "WHERE RecordID = @id", con)
                cmd.Parameters.AddWithValue("@id",     record.RecordID)
                cmd.Parameters.AddWithValue("@type",   record.IncidentType)
                cmd.Parameters.AddWithValue("@date",   record.IncidentDateTime)
                cmd.Parameters.AddWithValue("@prop",   record.InvolvedProperty)
                cmd.Parameters.AddWithValue("@owner",  If(record.OwnerOccupant, CType(DBNull.Value, Object)))
                cmd.Parameters.AddWithValue("@caller", record.CallerInformation)
                cmd.Parameters.AddWithValue("@alarm",  If(record.AlarmLevel, CType(DBNull.Value, Object)))
                cmd.Parameters.AddWithValue("@resp",   If(record.ResponseTime.HasValue, CType(record.ResponseTime.Value, Object), CType(DBNull.Value, Object)))
                cmd.Parameters.AddWithValue("@cause",  If(record.CauseOfFire, CType(DBNull.Value, Object)))
                cmd.Parameters.AddWithValue("@cas",    record.Casualties)
                cmd.Parameters.AddWithValue("@dmg",    record.DamageEstimate)
                cmd.Parameters.AddWithValue("@rem",    record.Remarks)
                cmd.Parameters.AddWithValue("@status", record.Status)
                cmd.Parameters.AddWithValue("@doc",    If(record.DocumentPath, CType(DBNull.Value, Object)))
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
