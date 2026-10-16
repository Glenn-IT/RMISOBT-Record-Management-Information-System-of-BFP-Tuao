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
                    RecordID          VARCHAR(20)     NOT NULL PRIMARY KEY,
                    IncidentType      NVARCHAR(100)   NOT NULL,
                    IncidentDateTime  DATETIME2(0)    NOT NULL,
                    InvolvedProperty  NVARCHAR(255)   NOT NULL,
                    Address           NVARCHAR(255)   NULL,
                    OwnerOccupant     NVARCHAR(150)   NULL,
                    CallerInformation NVARCHAR(100)   NOT NULL,
                    AlarmLevel        NVARCHAR(50)    NULL,
                    ResponseTime      TIME(0)         NULL,
                    CauseOfFire       NVARCHAR(255)   NULL,
                    Casualties        NVARCHAR(50)    NOT NULL DEFAULT '0',
                    DamageEstimate    NVARCHAR(100)   NOT NULL DEFAULT '0',
                    Remarks           NVARCHAR(500)   NOT NULL DEFAULT '',
                    Status            NVARCHAR(50)    NOT NULL DEFAULT 'Active',
                    AttachmentPath    NVARCHAR(255)   NULL,
                    CreatedAt         DATETIME        NOT NULL DEFAULT GETDATE()
                );

                IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'tbl_Users')
                CREATE TABLE tbl_Users (
                    UserID              INT             NOT NULL IDENTITY(1,1) PRIMARY KEY,
                    Username            NVARCHAR(100)   NOT NULL UNIQUE,
                    PasswordHash        NVARCHAR(255)   NOT NULL,
                    UserType            NVARCHAR(50)    NOT NULL DEFAULT 'Sub Admin',
                    SecurityQuestion    NVARCHAR(255)   NOT NULL DEFAULT '',
                    SecurityAnswerHash  NVARCHAR(255)   NOT NULL DEFAULT '',
                    CreatedAt           DATETIME        NOT NULL DEFAULT GETDATE()
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

            ' Migration: add security question columns if they were added after initial deploy
            Dim migrate As String =
                "IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('tbl_Users') AND name = 'SecurityQuestion')
                    ALTER TABLE tbl_Users ADD SecurityQuestion NVARCHAR(255) NOT NULL DEFAULT '';
                 IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('tbl_Users') AND name = 'SecurityAnswerHash')
                    ALTER TABLE tbl_Users ADD SecurityAnswerHash NVARCHAR(255) NOT NULL DEFAULT '';
                 IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('tbl_IncidentRecords') AND name = 'AttachmentPath')
                    ALTER TABLE tbl_IncidentRecords ADD AttachmentPath NVARCHAR(255) NULL;

                 IF EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('tbl_IncidentRecords') AND name = 'Location')
                    ALTER TABLE tbl_IncidentRecords DROP COLUMN Location;
                 IF EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('tbl_IncidentRecords') AND name = 'ReportedBy')
                    ALTER TABLE tbl_IncidentRecords DROP COLUMN ReportedBy;
                 IF EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('tbl_IncidentRecords') AND name = 'DateReported')
                    ALTER TABLE tbl_IncidentRecords DROP COLUMN DateReported;

                 IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('tbl_IncidentRecords') AND name = 'InvolvedProperty')
                    ALTER TABLE tbl_IncidentRecords ADD InvolvedProperty NVARCHAR(255) NOT NULL DEFAULT '';
                 IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('tbl_IncidentRecords') AND name = 'OwnerOccupant')
                    ALTER TABLE tbl_IncidentRecords ADD OwnerOccupant NVARCHAR(150) NULL;
                 IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('tbl_IncidentRecords') AND name = 'CallerInformation')
                    ALTER TABLE tbl_IncidentRecords ADD CallerInformation NVARCHAR(100) NOT NULL DEFAULT '';
                 IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('tbl_IncidentRecords') AND name = 'AlarmLevel')
                    ALTER TABLE tbl_IncidentRecords ADD AlarmLevel NVARCHAR(50) NULL;
                 IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('tbl_IncidentRecords') AND name = 'ResponseTime')
                    ALTER TABLE tbl_IncidentRecords ADD ResponseTime TIME(0) NULL;
                 IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('tbl_IncidentRecords') AND name = 'IncidentDateTime')
                    ALTER TABLE tbl_IncidentRecords ADD IncidentDateTime DATETIME2(0) NOT NULL DEFAULT GETDATE();
                 IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('tbl_IncidentRecords') AND name = 'Address')
                    ALTER TABLE tbl_IncidentRecords ADD Address NVARCHAR(255) NULL;
                 IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID('tbl_IncidentRecords') AND name = 'CauseOfFire')
                    ALTER TABLE tbl_IncidentRecords ADD CauseOfFire NVARCHAR(255) NULL;

                 UPDATE tbl_Users SET UserType = 'Super Admin' WHERE UserType = 'Admin';
                 UPDATE tbl_Users SET UserType = 'Sub Admin' WHERE UserType = 'Staff';"
            Using cmd As New SqlCommand(migrate, con)
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
                    INSERT INTO tbl_Settings VALUES ('StationAddress', 'Tuao, Cagayan');
                 IF NOT EXISTS (SELECT 1 FROM tbl_Settings WHERE SettingKey = 'Signatory1_Label')
                    INSERT INTO tbl_Settings VALUES ('Signatory1_Label', 'Prepared by:');
                 IF NOT EXISTS (SELECT 1 FROM tbl_Settings WHERE SettingKey = 'Signatory1_Name')
                    INSERT INTO tbl_Settings VALUES ('Signatory1_Name', 'FO3 Juan Dela Cruz, BFP');
                 IF NOT EXISTS (SELECT 1 FROM tbl_Settings WHERE SettingKey = 'Signatory1_Title')
                    INSERT INTO tbl_Settings VALUES ('Signatory1_Title', 'Duty Desk Officer / Fire Investigator');
                 IF NOT EXISTS (SELECT 1 FROM tbl_Settings WHERE SettingKey = 'Signatory2_Label')
                    INSERT INTO tbl_Settings VALUES ('Signatory2_Label', 'Noted by:');
                 IF NOT EXISTS (SELECT 1 FROM tbl_Settings WHERE SettingKey = 'Signatory2_Name')
                    INSERT INTO tbl_Settings VALUES ('Signatory2_Name', 'CINSP Pedro Penduko, BFP');
                 IF NOT EXISTS (SELECT 1 FROM tbl_Settings WHERE SettingKey = 'Signatory2_Title')
                    INSERT INTO tbl_Settings VALUES ('Signatory2_Title', 'Municipal Fire Marshal');
                 IF NOT EXISTS (SELECT 1 FROM tbl_Settings WHERE SettingKey = 'Signatory3_Enabled')
                    INSERT INTO tbl_Settings VALUES ('Signatory3_Enabled', 'False');
                 IF NOT EXISTS (SELECT 1 FROM tbl_Settings WHERE SettingKey = 'Signatory3_Label')
                    INSERT INTO tbl_Settings VALUES ('Signatory3_Label', 'Approved by:');
                 IF NOT EXISTS (SELECT 1 FROM tbl_Settings WHERE SettingKey = 'Signatory3_Name')
                    INSERT INTO tbl_Settings VALUES ('Signatory3_Name', '');
                 IF NOT EXISTS (SELECT 1 FROM tbl_Settings WHERE SettingKey = 'Signatory3_Title')
                    INSERT INTO tbl_Settings VALUES ('Signatory3_Title', '');"
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
            Dim answerHash As String = PasswordHelper.HashPassword("admin")
            Using cmd As New SqlCommand(
                "INSERT INTO tbl_Users (Username, PasswordHash, UserType, SecurityQuestion, SecurityAnswerHash) " &
                "VALUES ('admin', @hash, 'Super Admin', @question, @answer)", con)
                cmd.Parameters.AddWithValue("@hash",     hash)
                cmd.Parameters.AddWithValue("@question", "What is your mother's maiden name?")
                cmd.Parameters.AddWithValue("@answer",   answerHash)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class
