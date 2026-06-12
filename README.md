# RMIS — BFP Tuao

**Record Management Information System**
Bureau of Fire Protection — Tuao Fire Station

A Windows desktop application for managing fire incident records at BFP Tuao Station.

---

## Tech Stack

| Layer | Technology |
|-------|-----------|
| Language | VB.NET |
| Framework | .NET 8.0 (Windows) |
| UI | Windows Forms (WinForms) |
| Database | SQL Server (via `Microsoft.Data.SqlClient`) |
| Password hashing | BCrypt.Net-Next |

---

## Features

- **Login** — BCrypt-hashed credentials stored in SQL Server
- **Dashboard** — Summary cards + recent 5 records at a glance
- **Add Record** — Create fire incident records with full validation
- **View Records** — DataGridView with live search, Edit, and Delete
- **Reports** — Breakdown by incident type; Print preview + CSV export
- **Settings** — Change username/password; update station info (persisted to DB)
- **Activity Log** — Every login, record change, and logout is logged to `tbl_ActivityLogs`
- **Developers** — About page with app info and development team

---

## Prerequisites

- Windows 10 / 11
- .NET 8.0 Desktop Runtime ([download](https://dotnet.microsoft.com/download/dotnet/8.0))
- SQL Server (Express or higher) — any instance accessible from the machine

---

## Setup

### 1. Clone the repository

```
git clone <repo-url>
cd RMIS_BFP_Tuao
```

### 2. Create the database

Open SQL Server Management Studio and create a new empty database:

```sql
CREATE DATABASE RMIS_BFP_Tuao;
```

Tables are created automatically on first run — no SQL scripts needed.

### 3. Configure the connection string

Copy the template and fill in your SQL Server instance:

```
copy RMIS_BFP_Tuao\config.txt.example RMIS_BFP_Tuao\bin\Debug\net8.0-windows\config.txt
```

Edit `config.txt` with your actual server details:

```
Data Source=YOUR_SERVER\SQLEXPRESS;Initial Catalog=RMIS_BFP_Tuao;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;
```

> `config.txt` is in `.gitignore` — never commit it.

### 4. Build and run

```
dotnet run --project RMIS_BFP_Tuao
```

Or open `RMIS_BFP_Tuao.sln` in Visual Studio and press **F5**.

### 5. Default credentials

| Field | Value |
|-------|-------|
| Username | `admin` |
| Password | `admin123` |

Change these immediately via **Settings → Account Settings** after first login.

---

## Project Structure

```
RMIS_BFP_Tuao/
├── DataAccess/               # Repository modules (all SQL lives here)
│   ├── DatabaseInitializer.vb
│   ├── IncidentRepository.vb
│   ├── UserRepository.vb
│   ├── ActivityLogRepository.vb
│   └── SettingsRepository.vb
├── Forms/
│   ├── LoginForm.vb
│   ├── MainForm.vb
│   ├── EditRecordForm.vb
│   └── Pages/
│       ├── UcDashboard.vb
│       ├── UcAddRecord.vb
│       ├── UcViewRecords.vb
│       ├── UcReports.vb
│       ├── UcSettings.vb
│       └── UcDevelopers.vb
├── Helpers/
│   ├── Constants.vb          # Incident types, statuses, log results
│   └── PasswordHelper.vb     # BCrypt wrappers
├── Models/
│   ├── RecordModel.vb
│   └── PersonnelModel.vb
├── Services/
│   ├── RecordService.vb      # Thin facade over IncidentRepository
│   └── ReportPrinter.vb      # PrintDocument-based report renderer
├── ActivityLogger.vb         # Safe log wrapper (swallows own exceptions)
├── SessionManager.vb         # Logged-in user state
├── dbconstring.vb            # Reads connection string from config.txt
├── config.txt.example        # Connection string template (committed)
└── Docs/
    ├── audit.md
    ├── TaskChecklist.md
    ├── Db_Connection_Patern.md
    └── DbSchema.md
```

---

## Database Tables

| Table | Purpose |
|-------|---------|
| `tbl_IncidentRecords` | Fire incident records |
| `tbl_Users` | Login accounts with BCrypt-hashed passwords |
| `tbl_ActivityLogs` | Audit trail of user actions |
| `tbl_Settings` | Key/value store for app settings (station name, address) |

See `Docs/DbSchema.md` for full column definitions.

---

## Security Notes

- Passwords are hashed with BCrypt (work factor 11) — never stored in plain text
- All SQL uses parameterized queries — no string concatenation
- `config.txt` (connection string) is gitignored
- Activity logging captures every login, record mutation, and logout

---

## License

Internal use — Bureau of Fire Protection, Tuao Station.
