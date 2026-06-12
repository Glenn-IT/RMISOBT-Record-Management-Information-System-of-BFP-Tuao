# System Blueprint — VB.NET WinForms Record Management System

Use this document as the master prompt when rebuilding this system architecture on another device or for a different domain. Hand it to Claude Code and it will reproduce the same structure, patterns, and design philosophy.

---

## Master Prompt

> Build a **VB.NET WinForms desktop application** on **.NET 8** with **SQL Server** as the backend database. The system is a **Record Management Information System** for [your organization]. Follow every architectural, security, UI, and code pattern defined below — do not deviate unless explicitly told to.

---

## 1. Stack & Prerequisites

| Item | Version |
|------|---------|
| Language | VB.NET |
| Framework | .NET 8 (target: `net8.0-windows`) |
| UI | WinForms |
| Database | SQL Server (any edition — Express is fine) |
| NuGet: BCrypt | `BCrypt.Net-Next` 4.x |
| NuGet: SQL Client | `Microsoft.Data.SqlClient` 5.x |
| IDE | Visual Studio 2022+ |
| Test Framework | MSTest v2 (separate `.Tests` project) |

---

## 2. Solution Structure

```
SolutionName.sln
├── ProjectName/                        ← Main WinForms project
│   ├── Assets/                         ← Images, logos (.gitkeep)
│   ├── DataAccess/                     ← Repository layer (one file per table)
│   │   ├── DatabaseInitializer.vb
│   │   ├── IncidentRepository.vb       ← (rename per domain)
│   │   ├── UserRepository.vb
│   │   ├── ActivityLogRepository.vb
│   │   └── SettingsRepository.vb
│   ├── Docs/                           ← Markdown documentation
│   ├── Forms/
│   │   ├── LoginForm.vb + .Designer.vb + .resx
│   │   ├── MainForm.vb + .Designer.vb + .resx
│   │   ├── EditRecordForm.vb + .Designer.vb + .resx
│   │   └── Pages/                      ← UserControls, one per nav page
│   │       ├── UcDashboard.vb + .Designer.vb + .resx
│   │       ├── UcAddRecord.vb + .Designer.vb + .resx
│   │       ├── UcViewRecords.vb + .Designer.vb + .resx
│   │       ├── UcReports.vb + .Designer.vb + .resx
│   │       ├── UcSettings.vb + .Designer.vb + .resx
│   │       └── UcDevelopers.vb + .Designer.vb + .resx
│   ├── Helpers/
│   │   ├── Constants.vb                ← All enum-like string arrays and const strings
│   │   └── PasswordHelper.vb           ← BCrypt wrappers
│   ├── Models/
│   │   └── RecordModel.vb              ← Plain data class, no logic
│   ├── Services/
│   │   ├── RecordService.vb            ← Singleton; delegates to repository
│   │   └── ReportPrinter.vb            ← Print preview logic
│   ├── ActivityLogger.vb               ← Module; fire-and-forget DB write
│   ├── ApplicationEvents.vb            ← Startup hook: DB init, cancel on error
│   ├── SessionManager.vb               ← Module; holds logged-in user state
│   ├── dbconstring.vb                  ← Module; reads config.txt at runtime
│   └── config.txt.example              ← Committed template (real file gitignored)
└── ProjectName.Tests/                  ← MSTest project
    ├── PasswordHelperTests.vb
    ├── SessionManagerTests.vb
    ├── RecordModelTests.vb
    └── ConstantsTests.vb
```

---

## 3. Database Design

### 3.1 Tables (auto-created by `DatabaseInitializer` on first run)

```sql
-- Core domain records
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

-- Authentication
CREATE TABLE tbl_Users (
    UserID          INT             NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Username        NVARCHAR(100)   NOT NULL UNIQUE,
    PasswordHash    NVARCHAR(255)   NOT NULL,
    UserType        NVARCHAR(50)    NOT NULL DEFAULT 'Staff',
    CreatedAt       DATETIME        NOT NULL DEFAULT GETDATE()
);

-- Audit trail
CREATE TABLE tbl_ActivityLogs (
    LogID           INT             NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Username        NVARCHAR(100)   NOT NULL,
    LogDate         DATETIME        NOT NULL DEFAULT GETDATE(),
    Result          NVARCHAR(50)    NOT NULL,
    Description     NVARCHAR(500)   NOT NULL
);

-- Key/value app settings
CREATE TABLE tbl_Settings (
    SettingKey      NVARCHAR(100)   NOT NULL PRIMARY KEY,
    SettingValue    NVARCHAR(500)   NOT NULL DEFAULT ''
);
```

### 3.2 Naming convention
- Tables: `tbl_PascalCase`
- Stored procedure / ID pattern: `RecordID` = `"INC-{year}-{seq:D3}"` built from `MAX()` in the repository
- Passwords: BCrypt hash with work factor 11, never stored plaintext

### 3.3 Seed data (inserted by `DatabaseInitializer` if not exists)
- Admin user: username `admin`, password `admin123` (BCrypt hashed)
- Settings: `StationName`, `StationAddress`

---

## 4. Connection String Pattern

**Rule: the connection string is NEVER committed to git.**

- `config.txt` — lives next to the `.exe`; gitignored
- `config.txt.example` — committed template with placeholder values
- `dbconstring.vb` — module that reads the file at runtime

```vb
' dbconstring.vb
Public Module dbconstring
    Public ReadOnly Property Connection As String
        Get
            Dim exeDir = AppDomain.CurrentDomain.BaseDirectory
            Dim path = IO.Path.Combine(exeDir, "config.txt")
            If Not IO.File.Exists(path) Then
                Throw New IO.FileNotFoundException(
                    "config.txt not found. Copy config.txt.example, rename it, and fill in your connection string.")
            End If
            Return IO.File.ReadAllText(path).Trim()
        End Get
    End Property
End Module
```

`config.txt.example` content:
```
Server=.\SQLEXPRESS;Database=YourDatabaseName;Trusted_Connection=True;TrustServerCertificate=True;
```

---

## 5. Startup Initialization

`ApplicationEvents.vb` runs before any form opens:

```vb
Namespace My
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Try
                DatabaseInitializer.Initialize()
            Catch ex As Exception
                MessageBox.Show(
                    "Could not connect to the database." & Environment.NewLine &
                    ex.Message & Environment.NewLine & Environment.NewLine &
                    "Make sure config.txt exists next to the .exe with a valid connection string.",
                    "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Cancel = True
            End Try
        End Sub
    End Class
End Namespace
```

---

## 6. Session Management

```vb
' SessionManager.vb — module-level, accessible everywhere
Public Module SessionManager
    Public Property Username As String = ""
    Public Property UserType As String = ""
    Public Property UserCode As String = ""

    Public Sub Clear()
        Username = ""
        UserType = ""
        UserCode = ""
    End Sub
End Module
```

Read with `SessionManager.Username` from any form. Call `SessionManager.Clear()` on logout.

---

## 7. Security Patterns

### BCrypt passwords
```vb
' Helpers/PasswordHelper.vb
Public Module PasswordHelper
    Public Function HashPassword(plainText As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(plainText, workFactor:=11)
    End Function
    Public Function VerifyPassword(plainText As String, hash As String) As Boolean
        Return BCrypt.Net.BCrypt.Verify(plainText, hash)
    End Function
End Module
```

### Parameterized queries (always — no string concatenation)
```vb
' Every SQL command uses parameters:
Using cmd As New SqlCommand(
    "SELECT * FROM tbl_Users WHERE Username = @u", con)
    cmd.Parameters.AddWithValue("@u", username)
    ' ...
End Using
```

---

## 8. Repository Pattern

One module per table. All DB access goes through repositories — no form ever opens a `SqlConnection` directly.

```vb
' DataAccess/IncidentRepository.vb (template)
Imports Microsoft.Data.SqlClient

Public Module IncidentRepository

    Public Function GetAll() As List(Of RecordModel)
        Dim list As New List(Of RecordModel)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand("SELECT * FROM tbl_IncidentRecords ORDER BY DateReported DESC", con)
                Using dr = cmd.ExecuteReader()
                    While dr.Read()
                        list.Add(New RecordModel() With {
                            .RecordID      = dr("RecordID").ToString(),
                            .IncidentType  = dr("IncidentType").ToString(),
                            .DateReported  = CDate(dr("DateReported")),
                            .Location      = dr("Location").ToString(),
                            .ReportedBy    = dr("ReportedBy").ToString(),
                            .Casualties    = dr("Casualties").ToString(),
                            .DamageEstimate = dr("DamageEstimate").ToString(),
                            .Remarks       = dr("Remarks").ToString(),
                            .Status        = dr("Status").ToString()
                        })
                    End While
                End Using
            End Using
        End Using
        Return list
    End Function

    Public Sub Insert(record As RecordModel)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "INSERT INTO tbl_IncidentRecords
                 (RecordID,IncidentType,DateReported,Location,ReportedBy,Casualties,DamageEstimate,Remarks,Status)
                 VALUES (@id,@type,@date,@loc,@by,@cas,@dmg,@rem,@status)", con)
                cmd.Parameters.AddWithValue("@id",     record.RecordID)
                cmd.Parameters.AddWithValue("@type",   record.IncidentType)
                cmd.Parameters.AddWithValue("@date",   record.DateReported.Date)
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
                "UPDATE tbl_IncidentRecords SET
                 IncidentType=@type, DateReported=@date, Location=@loc,
                 ReportedBy=@by, Casualties=@cas, DamageEstimate=@dmg,
                 Remarks=@rem, Status=@status
                 WHERE RecordID=@id", con)
                cmd.Parameters.AddWithValue("@id",     record.RecordID)
                cmd.Parameters.AddWithValue("@type",   record.IncidentType)
                cmd.Parameters.AddWithValue("@date",   record.DateReported.Date)
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
        Dim prefix = $"INC-{year}-"
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "SELECT ISNULL(MAX(CAST(SUBSTRING(RecordID, LEN(@prefix)+1, 10) AS INT)), 0)
                 FROM tbl_IncidentRecords WHERE RecordID LIKE @like", con)
                cmd.Parameters.AddWithValue("@prefix", prefix)
                cmd.Parameters.AddWithValue("@like",   prefix & "%")
                Dim maxSeq = CInt(cmd.ExecuteScalar())
                Return prefix & (maxSeq + 1).ToString("D3")
            End Using
        End Using
    End Function

End Module
```

---

## 9. Service Layer (Singleton)

```vb
' Services/RecordService.vb
Public Class RecordService
    Private Shared _instance As RecordService
    Public Shared ReadOnly Property Instance As RecordService
        Get
            If _instance Is Nothing Then _instance = New RecordService()
            Return _instance
        End Get
    End Property
    Private Sub New() : End Sub

    Public Function GetRecords() As List(Of RecordModel) : Return IncidentRepository.GetAll() : End Function
    Public Sub AddRecord(r As RecordModel)         : IncidentRepository.Insert(r)  : End Sub
    Public Sub UpdateRecord(r As RecordModel)      : IncidentRepository.Update(r)  : End Sub
    Public Sub DeleteRecord(id As String)          : IncidentRepository.Delete(id) : End Sub
    Public Function GetNextID() As String          : Return IncidentRepository.GetNextID() : End Function
End Class
```

---

## 10. Activity Logger

```vb
' ActivityLogger.vb
Public Module ActivityLogger
    Public Sub Log(username As String, result As String, description As String)
        Try
            ActivityLogRepository.Insert(username, result, description)
        Catch
            ' Logging failure must never crash the app
        End Try
    End Sub
End Module
```

Usage: `ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess, "Added record: " & id)`

---

## 11. Constants Module

```vb
' Helpers/Constants.vb
Public Module Constants
    ' Adapt these arrays to your domain
    Public ReadOnly IncidentTypes As String() = {
        "Structure Fire", "Vehicular Fire", "Grass Fire",
        "Industrial Fire", "Electrical Fire", "Other"}

    Public ReadOnly Statuses As String() = {
        "Active", "Resolved", "Under Investigation", "Closed"}

    Public Const UserTypeAdmin As String = "Admin"
    Public Const UserTypeStaff As String = "Staff"
    Public Const LogSuccess    As String = "Success"
    Public Const LogFailed     As String = "Failed"
End Module
```

**Rule:** No form ever has a hardcoded `"Active"` or `"Structure Fire"` string literal. Always reference `Constants.*`.

---

## 12. UI Design System

### Color palette
| Role | Color | RGB |
|------|-------|-----|
| Primary / sidebar / buttons | Dark red | `(180, 20, 20)` |
| Sidebar logo bar | Darker red | `(140, 10, 10)` |
| Page background | Light gray | `(240, 242, 245)` |
| Cards / panels | White | `(255, 255, 255)` |
| Body text | Near-black | `(30, 30, 30)` |
| Muted text / labels | Gray | `Color.Gray` |
| Field labels | Dark gray | `(70, 70, 70)` |
| Input background | Near-white | `(250, 250, 250)` |
| Active row selection | Medium red | `(220, 50, 50)` |
| Edit button | Blue | `(30, 100, 180)` |
| Alternating rows | Very light red | `(252, 245, 245)` |

### Typography
- All controls: `Segoe UI`
- Page titles: 15–16pt Bold
- Section titles: 11pt Bold
- Field labels: 9pt Bold
- Body / inputs: 9–10pt Regular
- Button text: 9.5–10pt Bold

### Layout rules
- Page background: `Color.FromArgb(240, 242, 245)` on every UserControl
- Content lives in white `Panel` cards with padding ~24px
- A `(180,20,20)` divider panel (height=3) separates page header from body
- All panels and grids use `Anchor` for responsiveness (no fixed pixel sizes on resizable forms)
- `FormBorderStyle = Sizable`, `WindowState = Maximized` on MainForm

---

## 13. MainForm Layout

```
┌─────────────────────────────────────────────────────────┐
│ pnlTopBar (height 60, dark gray #2c2c2c)                │
│   lblTopTitle (left)    lblTopDate (right)  lblTopUser  │
├──────────┬──────────────────────────────────────────────┤
│ pnlSide  │                                              │
│ bar      │  pnlContent  ← UserControl pages load here  │
│ (220px)  │              ← Dock = Fill                  │
│          │                                              │
│ [nav     │                                              │
│  buttons]│                                              │
│          │                                              │
│ [Logout] │                                              │
└──────────┴──────────────────────────────────────────────┘
```

- Sidebar: `BackColor = (30, 30, 30)`, width 220
- Nav buttons: flat, full-width, `TextAlign = MiddleLeft`, left-padded text
- Active nav button: `BackColor = (180, 20, 20)` (set in `SetActiveButton()`)
- Top bar user label: shows `"[ " & SessionManager.Username & " ]"`
- Page loading pattern: clear `pnlContent.Controls`, add new UserControl, `Dock = Fill`

---

## 14. Page (UserControl) Patterns

Every page follows the same structure:

```
UcPageName
  └── pnlFormCard (white, Anchor = all four sides)
        ├── lblPageTitle   (15pt Bold, dark)
        ├── lblPageSub     (9pt, gray)
        ├── pnlDivider     (height 3, red, Anchor Top+Left+Right)
        └── [page-specific controls]
```

### Dashboard page
- 4 summary stat cards in a row (each 188×100, white panel)
- Each card: icon label (left) + title label + large value label (right)
- Recent records panel below: DataGridView with red header, 5 rows, auto-fill columns

### Add Record / Edit Record pages
- Two-column form layout (left column: fields 1–4, right column: fields 5–8)
- Full-width field for Location (spans both columns)
- SAVE and CLEAR buttons anchored Bottom+Left
- Always wrap save logic in `Try/Catch`

### View Records page
- Toolbar panel (white): search box + Refresh + Edit + Delete buttons + record count label
- Grid card panel below: DataGridView fills remaining space
- Row color-coding based on Status (Active = light yellow, Resolved = light green, etc.)
- Live search on `TextChanged` — filters all columns client-side
- Edit opens a modal `EditRecordForm`; refresh grid on `DialogResult.OK`

### Reports page
- 4 summary stat cards (same style as Dashboard)
- Breakdown DataGridView: one row per incident type, with count
- Print button → `ReportPrinter.ShowPreview(records)`
- Export button → write CSV with `SaveFileDialog`

### Settings page
- Two side-by-side white panel cards: Account Settings | System Information
- Account card: username field + new password + confirm password + Save
- System card: station name + address (multiline) + Save
- On save: call repository, update `SessionManager`, update top bar label

---

## 15. Authentication Flow

```
LoginForm
  ├── Empty check → show lblError
  ├── UserRepository.GetByUsername(username) → DataTable
  ├── If 0 rows OR BCrypt.Verify fails → show error, log failure
  └── Else:
        SessionManager.Username = dt.Rows(0)("Username")
        SessionManager.UserType = dt.Rows(0)("UserType")
        ActivityLogger.Log(...)
        Show MainForm → Close LoginForm
```

---

## 16. Edit Record Modal Pattern

```vb
' EditRecordForm accepts a RecordModel in constructor
Public Sub New(record As RecordModel)
    InitializeComponent()
    _record = record
End Sub

Private Sub Form_Load(...)
    ' Pre-fill all fields from _record
    txtIncidentNo.Text = _record.RecordID
    txtIncidentNo.ReadOnly = True   ' ID is immutable
    cboIncidentType.SelectedItem = _record.IncidentType
    ' ... etc
End Sub

Private Sub btnSave_Click(...)
    ' Validate → build updated RecordModel → call RecordService.Instance.UpdateRecord()
    ' ActivityLogger.Log(...)
    DialogResult = DialogResult.OK
    Me.Close()
End Sub
```

Caller pattern in UcViewRecords:
```vb
Using dlg As New EditRecordForm(record)
    If dlg.ShowDialog() = DialogResult.OK Then
        PopulateGrid(RecordService.Instance.GetRecords())
    End If
End Using
```

---

## 17. Error Handling Rules

- Every form method that touches the DB is wrapped in `Try/Catch`
- Catch block: `MessageBox.Show("Failed to [action]: " & ex.Message, "Error", OK, Error)`
- `ActivityLogger.Log` has its own internal `Try/Catch` — logging never crashes the app
- `DatabaseInitializer` failure cancels app startup via `e.Cancel = True`

---

## 18. Unit Test Project

- Separate VB.NET project targeting `.NET 8`
- References: `MSTest.TestFramework`, `MSTest.TestAdapter`, `Microsoft.NET.Test.Sdk`
- Project reference: main project
- Test classes: one per module being tested
- What to test: `PasswordHelper` hash/verify, `SessionManager` set/clear, `RecordModel` property defaults, `Constants` array contents
- **Do not** mock the database — integration tests hit a real test DB or are skipped

---

## 19. Git Conventions

- One file per commit
- Conventional Commits: `feat:`, `fix:`, `style:`, `refactor:`, `docs:`, `chore:`, `test:`
- `config.txt` is gitignored; `config.txt.example` is committed
- `bin/` and `obj/` are gitignored

---

## 20. Adapting to a New Domain

When using this blueprint for a different system, change:

| This | To |
|------|----|
| `tbl_IncidentRecords` | Your domain table (e.g., `tbl_StudentRecords`) |
| `RecordModel` properties | Your domain fields |
| `Constants.IncidentTypes` | Your domain categories |
| `Constants.Statuses` | Your domain statuses |
| `IncidentRepository` | Your domain repository |
| `RecordService` | Your domain service |
| Station name / address | Your organization info |
| `INC-{year}-{seq}` ID format | Your ID format |
| Nav pages | Pages relevant to your system |

**Keep unchanged:** the connection string pattern, BCrypt auth, repository pattern, SessionManager, ActivityLogger, `DatabaseInitializer` auto-create approach, and all UI design rules.

---

*Blueprint generated from RMIS BFP Tuao — VB.NET WinForms · .NET 8 · SQL Server.*
