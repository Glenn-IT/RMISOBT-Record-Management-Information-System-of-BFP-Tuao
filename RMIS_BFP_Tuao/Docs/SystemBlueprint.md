# System Blueprint — VB.NET WinForms Desktop Application Foundation

A domain-agnostic foundation prompt. Hand this to Claude Code on any device to scaffold the same architecture, security, and UI design from scratch for any system.

---

## Master Prompt

> Build a **VB.NET WinForms desktop application** on **.NET 8** with **SQL Server** as the backend database. The system is a **[your system name]** for **[your organization]**. Follow every architectural, security, UI, and code pattern defined in this blueprint — do not deviate unless explicitly told to. Replace every `[placeholder]` with the actual domain name before building.

---

## 1. Stack & Prerequisites

| Item | Version |
|------|---------|
| Language | VB.NET |
| Framework | .NET 8 (`net8.0-windows`) |
| UI | WinForms |
| Database | SQL Server (any edition — Express is fine) |
| NuGet: BCrypt | `BCrypt.Net-Next` 4.x |
| NuGet: SQL Client | `Microsoft.Data.SqlClient` 5.x |
| IDE | Visual Studio 2022+ |
| Test Framework | MSTest v2 (separate `.Tests` project) |

---

## 2. Solution Structure

```
YourSolution.sln
├── YourProject/                          ← Main WinForms project
│   ├── Assets/                           ← Images, logos (.gitkeep placeholder)
│   ├── DataAccess/                       ← One repository file per DB table
│   │   ├── DatabaseInitializer.vb        ← Auto-creates tables + seeds data on startup
│   │   ├── [Domain]Repository.vb         ← CRUD for your main domain table
│   │   ├── UserRepository.vb             ← Auth: get by username, update username/password
│   │   ├── ActivityLogRepository.vb      ← Append-only audit log inserts
│   │   └── SettingsRepository.vb         ← Key/value get + upsert
│   ├── Docs/                             ← Markdown documentation
│   ├── Forms/
│   │   ├── LoginForm.vb + .Designer.vb + .resx
│   │   ├── MainForm.vb + .Designer.vb + .resx
│   │   ├── Edit[Domain]Form.vb + .Designer.vb + .resx
│   │   └── Pages/                        ← UserControls, one per sidebar nav item
│   │       ├── UcDashboard.vb + .Designer.vb + .resx
│   │       ├── UcAdd[Domain].vb + .Designer.vb + .resx
│   │       ├── UcView[Domain]s.vb + .Designer.vb + .resx
│   │       ├── UcReports.vb + .Designer.vb + .resx
│   │       ├── UcSettings.vb + .Designer.vb + .resx
│   │       └── UcDevelopers.vb + .Designer.vb + .resx
│   ├── Helpers/
│   │   ├── Constants.vb                  ← All shared string arrays and const strings
│   │   └── PasswordHelper.vb             ← BCrypt hash + verify wrappers
│   ├── Models/
│   │   └── [Domain]Model.vb              ← Plain data class, properties only, no logic
│   ├── Services/
│   │   ├── [Domain]Service.vb            ← Singleton; thin wrapper over repository
│   │   └── ReportPrinter.vb              ← Print preview + PDF logic
│   ├── ActivityLogger.vb                 ← Module; fire-and-forget audit DB write
│   ├── ApplicationEvents.vb              ← Startup hook: init DB, cancel app on error
│   ├── SessionManager.vb                 ← Module; holds logged-in user state globally
│   ├── dbconstring.vb                    ← Module; reads connection string from config.txt
│   └── config.txt.example               ← Committed template; real config.txt is gitignored
└── YourProject.Tests/                    ← Separate MSTest project
    ├── PasswordHelperTests.vb
    ├── SessionManagerTests.vb
    ├── [Domain]ModelTests.vb
    └── ConstantsTests.vb
```

---

## 3. Database Design

### 3.1 Fixed tables (always present in every system)

These four tables are infrastructure — they do not change between domains.

```sql
-- Authentication
CREATE TABLE tbl_Users (
    UserID       INT           NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Username     NVARCHAR(100) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    UserType     NVARCHAR(50)  NOT NULL DEFAULT 'Staff',
    CreatedAt    DATETIME      NOT NULL DEFAULT GETDATE()
);

-- Audit trail
CREATE TABLE tbl_ActivityLogs (
    LogID       INT           NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Username    NVARCHAR(100) NOT NULL,
    LogDate     DATETIME      NOT NULL DEFAULT GETDATE(),
    Result      NVARCHAR(50)  NOT NULL,
    Description NVARCHAR(500) NOT NULL
);

-- Key/value app settings
CREATE TABLE tbl_Settings (
    SettingKey   NVARCHAR(100) NOT NULL PRIMARY KEY,
    SettingValue NVARCHAR(500) NOT NULL DEFAULT ''
);
```

### 3.2 Domain table (you define this per project)

```sql
-- Replace every [placeholder] with your actual column names and types
CREATE TABLE tbl_[YourDomain] (
    [Domain]ID   VARCHAR(20)   NOT NULL PRIMARY KEY,   -- e.g. "REC-2025-001"
    [Field1]     NVARCHAR(100) NOT NULL,
    [Field2]     NVARCHAR(255) NOT NULL,
    [Field3]     DATE          NOT NULL,
    -- ... add your columns
    Status       NVARCHAR(50)  NOT NULL DEFAULT '[YourDefaultStatus]',
    CreatedAt    DATETIME      NOT NULL DEFAULT GETDATE()
);
```

### 3.3 Naming conventions
- All tables: `tbl_PascalCase`
- Auto-ID format: `"[PREFIX]-{year}-{seq:D3}"` — sequence derived from `MAX()` in the repository, collision-safe after deletes
- Passwords: BCrypt hashed at work factor 11, never stored plaintext

### 3.4 Seed data (auto-inserted by `DatabaseInitializer` if not exists)
- Admin user: username `admin`, password `admin123` (BCrypt hashed — must be changed after first login)
- Settings: `OrganizationName`, `OrganizationAddress` (or whatever your settings are)

---

## 4. Connection String Pattern

**Rule: the connection string is NEVER committed to git.**

| File | Purpose |
|------|---------|
| `config.txt` | Lives next to the `.exe`; listed in `.gitignore` |
| `config.txt.example` | Safe template committed to git |
| `dbconstring.vb` | Module that reads the file at runtime |

```vb
' dbconstring.vb
Public Module dbconstring
    Public ReadOnly Property Connection As String
        Get
            Dim path = IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt")
            If Not IO.File.Exists(path) Then
                Throw New IO.FileNotFoundException(
                    "config.txt not found. Copy config.txt.example, rename it, and fill in your connection string.")
            End If
            Return IO.File.ReadAllText(path).Trim()
        End Get
    End Property
End Module
```

`config.txt.example`:
```
Server=.\SQLEXPRESS;Database=YourDatabaseName;Trusted_Connection=True;TrustServerCertificate=True;
```

`.gitignore` entry:
```
config.txt
```

---

## 5. Startup Initialization

`ApplicationEvents.vb` — runs before any form opens. If the DB fails, the app cancels cleanly.

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

`DatabaseInitializer.Initialize()` must call:
1. `CreateTables()` — `IF NOT EXISTS` DDL for all tables
2. `SeedSettings()` — insert default settings rows if missing
3. `SeedAdminUser()` — insert `admin` user if no users exist

---

## 6. Session Management

```vb
' SessionManager.vb
Public Module SessionManager
    Public Property Username As String = ""
    Public Property UserType As String = ""

    Public Sub Clear()
        Username = ""
        UserType = ""
    End Sub
End Module
```

- Read anywhere with `SessionManager.Username`
- Set on successful login; call `SessionManager.Clear()` on logout

---

## 7. Security Patterns

### Password hashing
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

### Parameterized queries — always, no exceptions
```vb
Using cmd As New SqlCommand("SELECT * FROM tbl_Users WHERE Username = @u", con)
    cmd.Parameters.AddWithValue("@u", username)
End Using
```

Never build SQL strings with `& username &` or string interpolation.

---

## 8. Repository Pattern

One `Module` per table. No form or service ever creates a `SqlConnection` directly.

```vb
' DataAccess/[Domain]Repository.vb  — generic template
Imports Microsoft.Data.SqlClient

Public Module [Domain]Repository

    Public Function GetAll() As List(Of [Domain]Model)
        Dim list As New List(Of [Domain]Model)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "SELECT * FROM tbl_[YourDomain] ORDER BY CreatedAt DESC", con)
                Using dr = cmd.ExecuteReader()
                    While dr.Read()
                        list.Add(New [Domain]Model() With {
                            .[Domain]ID = dr("[Domain]ID").ToString(),
                            .[Field1]   = dr("[Field1]").ToString(),
                            .[Field2]   = dr("[Field2]").ToString(),
                            .Status     = dr("Status").ToString()
                            ' ... map remaining columns
                        })
                    End While
                End Using
            End Using
        End Using
        Return list
    End Function

    Public Sub Insert(item As [Domain]Model)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "INSERT INTO tbl_[YourDomain] ([Domain]ID, [Field1], [Field2], Status)
                 VALUES (@id, @f1, @f2, @status)", con)
                cmd.Parameters.AddWithValue("@id",     item.[Domain]ID)
                cmd.Parameters.AddWithValue("@f1",     item.[Field1])
                cmd.Parameters.AddWithValue("@f2",     item.[Field2])
                cmd.Parameters.AddWithValue("@status", item.Status)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Update(item As [Domain]Model)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "UPDATE tbl_[YourDomain] SET [Field1]=@f1, [Field2]=@f2, Status=@status
                 WHERE [Domain]ID=@id", con)
                cmd.Parameters.AddWithValue("@id",     item.[Domain]ID)
                cmd.Parameters.AddWithValue("@f1",     item.[Field1])
                cmd.Parameters.AddWithValue("@f2",     item.[Field2])
                cmd.Parameters.AddWithValue("@status", item.Status)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Delete(id As String)
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "DELETE FROM tbl_[YourDomain] WHERE [Domain]ID = @id", con)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function GetNextID() As String
        Dim year = DateTime.Now.Year
        Dim prefix = $"[PREFIX]-{year}-"
        Using con As New SqlConnection(dbconstring.Connection)
            con.Open()
            Using cmd As New SqlCommand(
                "SELECT ISNULL(MAX(CAST(SUBSTRING([Domain]ID, LEN(@p)+1, 10) AS INT)), 0)
                 FROM tbl_[YourDomain] WHERE [Domain]ID LIKE @like", con)
                cmd.Parameters.AddWithValue("@p",    prefix)
                cmd.Parameters.AddWithValue("@like", prefix & "%")
                Dim seq = CInt(cmd.ExecuteScalar())
                Return prefix & (seq + 1).ToString("D3")
            End Using
        End Using
    End Function

End Module
```

---

## 9. Service Layer (Singleton)

```vb
' Services/[Domain]Service.vb
Public Class [Domain]Service

    Private Shared _instance As [Domain]Service
    Public Shared ReadOnly Property Instance As [Domain]Service
        Get
            If _instance Is Nothing Then _instance = New [Domain]Service()
            Return _instance
        End Get
    End Property
    Private Sub New() : End Sub

    Public Function GetAll() As List(Of [Domain]Model)  : Return [Domain]Repository.GetAll()    : End Function
    Public Sub Add(item As [Domain]Model)               : [Domain]Repository.Insert(item)        : End Sub
    Public Sub Update(item As [Domain]Model)            : [Domain]Repository.Update(item)        : End Sub
    Public Sub Delete(id As String)                     : [Domain]Repository.Delete(id)          : End Sub
    Public Function GetNextID() As String               : Return [Domain]Repository.GetNextID()  : End Function

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
            ' Logging must never crash the app
        End Try
    End Sub
End Module
```

Usage: `ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess, "Added: " & id)`

---

## 11. Constants Module

```vb
' Helpers/Constants.vb
Public Module Constants

    ' Replace with your domain's categories
    Public ReadOnly Categories As String() = {
        "Category A", "Category B", "Category C", "Other"}

    ' Replace with your domain's statuses
    Public ReadOnly Statuses As String() = {
        "Active", "Resolved", "Closed", "Pending"}

    Public Const UserTypeAdmin As String = "Admin"
    Public Const UserTypeStaff As String = "Staff"
    Public Const LogSuccess    As String = "Success"
    Public Const LogFailed     As String = "Failed"

End Module
```

**Rule:** No form ever has a hardcoded status or category string literal. Always use `Constants.*`.

---

## 12. UI Design System

### Color palette

| Role | RGB |
|------|-----|
| Primary accent (sidebar, buttons, dividers, header rows) | `(180, 20, 20)` — adapt to your brand |
| Sidebar logo bar | `(140, 10, 10)` |
| Sidebar background | `(30, 30, 30)` |
| Top bar background | `(44, 44, 44)` |
| Page background | `(240, 242, 245)` |
| Card / panel background | `(255, 255, 255)` |
| Page title text | `(30, 30, 30)` |
| Field label text | `(70, 70, 70)` |
| Muted / sub text | `Color.Gray` |
| Input field background | `(250, 250, 250)` |
| Grid selection highlight | `(220, 50, 50)` |
| Grid alternating rows | `(252, 245, 245)` |
| Edit/secondary button | `(30, 100, 180)` |

To change the theme color, find-replace `(180, 20, 20)` with your brand RGB.

### Typography

| Element | Font | Size | Style |
|---------|------|------|-------|
| Page title | Segoe UI | 15–16pt | Bold |
| Section title | Segoe UI | 11pt | Bold |
| Field labels | Segoe UI | 9pt | Bold |
| Input text | Segoe UI | 10pt | Regular |
| Button text | Segoe UI | 9.5–10pt | Bold |
| Body / table | Segoe UI | 9–9.5pt | Regular |

### Layout rules
- Every UserControl: `BackColor = (240, 242, 245)`
- All content in white `Panel` cards, inner padding ~24px
- Red divider panel (`height = 3`) between page header and body
- Use `Anchor` on all panels and grids — never rely on fixed pixel sizes for resizable forms
- `MainForm`: `FormBorderStyle = Sizable`, `WindowState = Maximized`

---

## 13. MainForm Shell Layout

```
┌──────────────────────────────────────────────────────────────┐
│  pnlTopBar  (height 60, dark)                                │
│    lblTopTitle [left]         lblTopDate [right] lblTopUser  │
├────────────┬─────────────────────────────────────────────────┤
│ pnlSidebar │                                                 │
│  (220 px)  │  pnlContent                                     │
│            │    ↑ UserControl pages load here (Dock=Fill)    │
│  [Logo /   │                                                 │
│   Title]   │                                                 │
│            │                                                 │
│  btnNav1   │                                                 │
│  btnNav2   │                                                 │
│  btnNav3   │                                                 │
│  ...       │                                                 │
│            │                                                 │
│  btnLogout │                                                 │
│  (bottom)  │                                                 │
└────────────┴─────────────────────────────────────────────────┘
```

**Sidebar nav buttons:**
- `FlatStyle = Flat`, `FlatAppearance.BorderSize = 0`
- `BackColor = (30, 30, 30)` by default
- `BackColor = (180, 20, 20)` when active — set by `SetActiveButton(btn)`
- `TextAlign = MiddleLeft`, text padded with leading spaces

**Page switching pattern:**
```vb
Private Sub LoadPage(page As UserControl)
    pnlContent.Controls.Clear()
    page.Dock = DockStyle.Fill
    pnlContent.Controls.Add(page)
End Sub
```

**Top bar user label:** `"[ " & SessionManager.Username & " ]"`

---

## 14. Page (UserControl) Structure

Every page uses this exact skeleton:

```
UcPageName (UserControl)
  BackColor = (240, 242, 245)
  └── pnlCard (Panel, white, Anchor = Top+Bottom+Left+Right)
        ├── lblPageTitle    — 15pt Bold, (30,30,30)
        ├── lblPageSub      — 9pt, Gray
        ├── pnlDivider      — height 3, (180,20,20), Anchor Top+Left+Right
        └── [your controls]
```

### Dashboard
- 4 summary stat cards in a row (188×100 white panels)
- Card layout: icon label (left, 56px wide) | title + large value label (right)
- Recent items DataGridView below — red column headers, 5 rows, `AutoSizeColumnsMode = Fill`

### Add / Edit Form
- Two-column field layout (left 4 fields, right 4 fields)
- Full-width text fields span both columns
- Save + Clear buttons anchored `Bottom+Left`
- All save logic inside `Try/Catch`

### View Records
- Toolbar: search box + Refresh + Edit + Delete + record count label
- DataGridView anchored to fill remaining space
- Row color-coding by Status column (define colors in `dgvRecords_RowPrePaint`)
- Live search filters client-side on `TextChanged`
- Edit → open modal `Edit[Domain]Form`; on `DialogResult.OK` refresh grid

### Reports
- 4 summary stat cards (same as Dashboard)
- Breakdown DataGridView: one row per category, count column
- Print button → `ReportPrinter.ShowPreview(data)`
- Export button → `SaveFileDialog` → write CSV from grid

### Settings
- Two white panel cards side by side: **Account Settings** | **System Settings**
- Account: username + new password + confirm password + Save
- System: organization name + address + Save
- On save: call repository, update `SessionManager`, refresh top bar label

### Developers / About
- Left panel: app name, version, stack info
- Right panel: team member cards (name + role)
- Populate all labels in `UcDevelopers_Load` — nothing hardcoded in Designer

---

## 15. Authentication Flow

```
LoginForm
  ├── Empty check → lblError.Visible = True, exit
  ├── UserRepository.GetByUsername(username) → DataTable
  ├── If 0 rows OR PasswordHelper.VerifyPassword fails:
  │     lblError.Text = "Invalid username or password."
  │     ActivityLogger.Log(username, Constants.LogFailed, "Login failed.")
  │     exit
  └── Else:
        SessionManager.Username = dt.Rows(0)("Username")
        SessionManager.UserType = dt.Rows(0)("UserType")
        ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess, "Login.")
        New MainForm().Show()
        Me.Close()
```

---

## 16. Edit Modal Pattern

```vb
' Edit[Domain]Form.vb
Private _item As [Domain]Model

Public Sub New(item As [Domain]Model)
    InitializeComponent()
    _item = item
End Sub

Private Sub Form_Load(...)
    txt[Field1].Text     = _item.[Field1]
    cbo[Category].SelectedItem = _item.[Category]
    txtID.ReadOnly       = True   ' ID is always immutable
    ' ... pre-fill all fields
End Sub

Private Sub btnSave_Click(...)
    ' Validate → build updated model → call [Domain]Service.Instance.Update(model)
    ' ActivityLogger.Log(...)
    DialogResult = DialogResult.OK
    Me.Close()
End Sub
```

Caller in `UcView[Domain]s.vb`:
```vb
Using dlg As New Edit[Domain]Form(item)
    If dlg.ShowDialog() = DialogResult.OK Then
        PopulateGrid([Domain]Service.Instance.GetAll())
    End If
End Using
```

---

## 17. Error Handling Rules

- Every method that calls a repository is wrapped in `Try/Catch`
- Catch: `MessageBox.Show("Failed to [action]: " & ex.Message, "Error", OK, Error icon)`
- `ActivityLogger` swallows its own exceptions — logging never propagates
- `DatabaseInitializer` failure → `e.Cancel = True` in `ApplicationEvents.vb` → app does not open

---

## 18. Unit Test Project

- Separate VB.NET class library targeting `.NET 8`
- NuGet: `MSTest.TestFramework`, `MSTest.TestAdapter`, `Microsoft.NET.Test.Sdk`
- Add project reference to main project
- One test class per module under test
- Test targets: `PasswordHelper` (hash/verify), `SessionManager` (set/clear), model property defaults, `Constants` array values
- Do not mock the database — DB-touching tests either use a real test DB or are not included in the unit test project

---

## 19. Git Conventions

- One file per commit
- Conventional Commits: `feat:`, `fix:`, `style:`, `refactor:`, `docs:`, `chore:`, `test:`
- `config.txt` — gitignored
- `config.txt.example` — committed
- `bin/` and `obj/` — gitignored

---

## 20. Checklist — Minimum Viable Foundation

Before writing any domain logic, these pieces must exist and work:

- [ ] `config.txt.example` committed, `config.txt` gitignored
- [ ] `dbconstring.vb` reads file at runtime
- [ ] `DatabaseInitializer` creates all tables on first run
- [ ] `SessionManager` module in place
- [ ] `ActivityLogger` module in place
- [ ] `PasswordHelper` with BCrypt
- [ ] `Constants` module with status/category arrays
- [ ] `ApplicationEvents.vb` calls `DatabaseInitializer.Initialize()`, cancels on error
- [ ] `LoginForm` authenticates via `UserRepository` + BCrypt
- [ ] `MainForm` shell: top bar, sidebar with nav buttons, `pnlContent`
- [ ] Page switching via `LoadPage()` method
- [ ] At least one `UserControl` page loading correctly
- [ ] `.Tests` project with at least one passing test

---

*Generic foundation blueprint — VB.NET WinForms · .NET 8 · SQL Server.*
