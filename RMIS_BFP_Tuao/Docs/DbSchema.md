# Database Schema — RMIS BFP Tuao

**Database:** `RMIS_BFP_Tuao`
**Engine:** SQL Server (Express or higher)

Tables are auto-created by `DatabaseInitializer.Initialize()` on first application startup.

---

## tbl_IncidentRecords

Stores all fire incident reports.

| Column | Type | Constraints | Notes |
|--------|------|-------------|-------|
| `RecordID` | `VARCHAR(20)` | PK, NOT NULL | Format: `INC-YYYY-NNN` (e.g. `INC-2026-001`) |
| `IncidentType` | `NVARCHAR(100)` | NOT NULL | Structure Fire, Vehicular Fire, Grass Fire, Industrial Fire, Electrical Fire, Other |
| `DateReported` | `DATE` | NOT NULL | Date the incident was reported |
| `Location` | `NVARCHAR(255)` | NOT NULL | Barangay / area description |
| `ReportedBy` | `NVARCHAR(100)` | NOT NULL | Name of reporting officer |
| `Casualties` | `NVARCHAR(50)` | NOT NULL, DEFAULT `'0'` | Number of casualties |
| `DamageEstimate` | `NVARCHAR(100)` | NOT NULL, DEFAULT `'0'` | Estimated damage in PHP |
| `Remarks` | `NVARCHAR(500)` | NOT NULL, DEFAULT `''` | Additional notes |
| `Status` | `NVARCHAR(50)` | NOT NULL, DEFAULT `'Active'` | Active, Resolved, Under Investigation, Closed |
| `CreatedAt` | `DATETIME` | NOT NULL, DEFAULT `GETDATE()` | Record creation timestamp |

**ID generation:** `INC-{YEAR}-{MAX+1:D3}` queried from `MAX(RecordID)` for the current year — collision-safe.

---

## tbl_Users

Login accounts. Passwords are stored as BCrypt hashes (never plain text).

| Column | Type | Constraints | Notes |
|--------|------|-------------|-------|
| `UserID` | `INT` | PK, IDENTITY(1,1) | Auto-increment |
| `Username` | `NVARCHAR(100)` | NOT NULL, UNIQUE | Login username |
| `PasswordHash` | `NVARCHAR(255)` | NOT NULL | BCrypt hash (BCrypt.Net-Next, work factor 11) |
| `UserType` | `NVARCHAR(50)` | NOT NULL, DEFAULT `'Staff'` | Admin, Staff |
| `CreatedAt` | `DATETIME` | NOT NULL, DEFAULT `GETDATE()` | Account creation timestamp |

**Seeded on first run:** username `admin`, password `admin123` (hashed).

---

## tbl_ActivityLogs

Audit trail. Every login, record change, and logout is written here. The logger swallows its own exceptions so a logging failure never crashes the app.

| Column | Type | Constraints | Notes |
|--------|------|-------------|-------|
| `LogID` | `INT` | PK, IDENTITY(1,1) | Auto-increment |
| `Username` | `NVARCHAR(100)` | NOT NULL | User who performed the action |
| `LogDate` | `DATETIME` | NOT NULL, DEFAULT `GETDATE()` | When the action occurred |
| `Result` | `NVARCHAR(50)` | NOT NULL | `Success` or `Failed` |
| `Description` | `NVARCHAR(500)` | NOT NULL | Human-readable description of the action |

---

## tbl_Settings

Key/value store for application-level settings.

| Column | Type | Constraints | Notes |
|--------|------|-------------|-------|
| `SettingKey` | `NVARCHAR(100)` | PK, NOT NULL | Setting name |
| `SettingValue` | `NVARCHAR(500)` | NOT NULL, DEFAULT `''` | Setting value |

**Seeded defaults:**

| Key | Default Value |
|-----|---------------|
| `StationName` | `BFP Tuao Fire Station` |
| `StationAddress` | `Tuao, Cagayan` |

---

## Entity Relationships

```
tbl_Users ──(Username)──► tbl_ActivityLogs
                               (soft reference — no FK constraint,
                                so log history survives username changes)

tbl_IncidentRecords          (standalone — no FK to Users;
                               ReportedBy is a free-text field)
```

---

## Layer Diagram

```
┌─────────────────────────────────────┐
│  Forms / UserControls               │  UI layer — zero SQL
│  (LoginForm, UcDashboard, etc.)     │
└──────────────┬──────────────────────┘
               │ calls
┌──────────────▼──────────────────────┐
│  RecordService (facade)             │  Thin wrapper — keeps form API stable
└──────────────┬──────────────────────┘
               │ delegates to
┌──────────────▼──────────────────────┐
│  DataAccess/ (repository modules)   │  All SQL lives here
│  IncidentRepository                 │
│  UserRepository                     │
│  ActivityLogRepository              │
│  SettingsRepository                 │
│  DatabaseInitializer                │
└──────────────┬──────────────────────┘
               │ uses
┌──────────────▼──────────────────────┐
│  dbconstring.vb                     │  Reads config.txt at runtime
└──────────────┬──────────────────────┘
               │ connects to
┌──────────────▼──────────────────────┐
│  SQL Server — RMIS_BFP_Tuao         │
│  tbl_IncidentRecords                │
│  tbl_Users                          │
│  tbl_ActivityLogs                   │
│  tbl_Settings                       │
└─────────────────────────────────────┘
```
