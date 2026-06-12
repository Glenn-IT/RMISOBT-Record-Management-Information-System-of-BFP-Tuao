Imports Microsoft.Data.SqlClient

Public Class DatabaseInitializer

    Public Shared Sub Initialize()
        CreateTables()
        SeedSettings()
        SeedAdminUser()
    End Sub

    Private Shared Sub CreateTables()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()

            Dim sql As String =
                "IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'tbl_IncidentRecords')
                CREATE TABLE tbl_IncidentRecords (
                    RecordID        VARCHAR(20)     NOT NULL PRIMARY KEY,
                    IncidentType    NVARCHAR(100)   NOT NULL,
                    DateReported    DATE            NOT NULL,
                    Location        NVARCHAR(255)   NOT NULL,
                    ReportedBy      NVARCHAR(100)   NOT NULL,
                    Casualties      NVARCHAR(50)    NOT NULL DEFAULT '0',
                    DamageEstimate  NVARCHAR(100)   NOT NULL DEFAULT '0',
                    Remarks         NVARCHAR(500)   NOT NULL DEFAULT '',
                    Status          NVARCHAR(50)    NOT NULL DEFAULT 'Active',
                    CreatedAt       DATETIME        NOT NULL DEFAULT GETDATE()
                );

                IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'tbl_Users')
                CREATE TABLE tbl_Users (
                    UserID          INT             NOT NULL IDENTITY(1,1) PRIMARY KEY,
                    Username        NVARCHAR(100)   NOT NULL UNIQUE,
                    PasswordHash    NVARCHAR(255)   NOT NULL,
                    UserType        NVARCHAR(50)    NOT NULL DEFAULT 'Staff',
                    CreatedAt       DATETIME        NOT NULL DEFAULT GETDATE()
                );

                IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'tbl_ActivityLogs')
                CREATE TABLE tbl_ActivityLogs (
                    LogID           INT             NOT NULL IDENTITY(1,1) PRIMARY KEY,
                    Username        NVARCHAR(100)   NOT NULL,
                    LogDate         DATETIME        NOT NULL DEFAULT GETDATE(),
                    Result          NVARCHAR(50)    NOT NULL,
                    Description     NVARCHAR(500)   NOT NULL
                );

                IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'tbl_Settings')
                CREATE TABLE tbl_Settings (
                    SettingKey      NVARCHAR(100)   NOT NULL PRIMARY KEY,
                    SettingValue    NVARCHAR(500)   NOT NULL DEFAULT ''
                );"

            Using cmd As New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Shared Sub SeedSettings()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim sql As String =
                "IF NOT EXISTS (SELECT 1 FROM tbl_Settings WHERE SettingKey = 'StationName')
                    INSERT INTO tbl_Settings VALUES ('StationName', 'BFP Tuao Fire Station');
                 IF NOT EXISTS (SELECT 1 FROM tbl_Settings WHERE SettingKey = 'StationAddress')
                    INSERT INTO tbl_Settings VALUES ('StationAddress', 'Tuao, Cagayan');"
            Using cmd As New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Shared Sub SeedAdminUser()
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Dim checkCmd As New SqlCommand(
                "SELECT COUNT(1) FROM tbl_Users WHERE Username = 'admin'", con)
            Dim exists = CInt(checkCmd.ExecuteScalar()) > 0
            If exists Then Return

            Dim hash As String = PasswordHelper.HashPassword("admin123")
            Using cmd As New SqlCommand(
                "INSERT INTO tbl_Users (Username, PasswordHash, UserType) " &
                "VALUES ('admin', @hash, 'Admin')", con)
                cmd.Parameters.AddWithValue("@hash", hash)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class
