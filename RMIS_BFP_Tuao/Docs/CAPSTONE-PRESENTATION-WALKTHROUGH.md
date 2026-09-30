# RMIS-BFP Tuao — Capstone Defense Presentation Walkthrough & Panelist Demonstration Guide
<!-- System: Record Management Information System for Bureau of Fire Protection - Tuao Fire Station (RMIS-BFP Tuao) -->
<!-- Institution: Bureau of Fire Protection (BFP) - Region II, Tuao Fire Station, Cagayan / BSIT Capstone Defense -->
<!-- Developers: Angelika Bangan & Ricky Paat (Bachelor of Science in Information Technology) -->
<!-- Target Audience: Capstone Defense Panelists, Project Advisers, Deans, Evaluators, and BFP Station Stakeholders -->

---

## 🧭 Executive Summary & Timing Strategy

| Phase | Section | Recommended Duration | Primary Interface |
| :--- | :--- | :--- | :--- |
| **Phase 1** | Project Rationale, Municipal Fire Protection Context & Institutional Problem Statement | 1.5 mins | Title Slide / [MainForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/MainForm.vb) |
| **Phase 2** | Technical Architecture, 3-Tier Layering & Defensive Security Baseline | 1.0 min | [SystemBlueprint.md](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Docs/SystemBlueprint.md) / [dbconstring.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/dbconstring.vb) |
| **Phase 3** | Application Bootstrapping & Self-Healing Database Initialization | 0.5 min | [ApplicationEvents.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/ApplicationEvents.vb) & [DatabaseInitializer.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/DataAccess/DatabaseInitializer.vb) |
| **Phase 4** | Station Authentication, Brute-Force Throttling & Live Lockout Countdown | 1.5 mins | [LoginForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/LoginForm.vb) & [LoginAttemptTracker.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Helpers/LoginAttemptTracker.vb) |
| **Phase 5** | Autonomous Station Credential Recovery & Security Trapping | 1.0 min | [ForgotPasswordForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/ForgotPasswordForm.vb) |
| **Phase 6** | Incident Command Dashboard & Real-Time Operational Telemetry | 1.0 min | [UcDashboard.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcDashboard.vb) |
| **Phase 7** | Incident Encoding Wizard, Blotter Attachment & Military Time Logging | 2.0 mins | [UcAddRecord.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcAddRecord.vb) & [DocumentStorage.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Services/DocumentStorage.vb) |
| **Phase 8** | Interactive Fire Incident Catalog, Live Keyword Search & Multi-Tier Filtering | 1.0 min | [UcViewRecords.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcViewRecords.vb) |
| **Phase 9** | Comprehensive Incident Dossier Inspection & Digital Blotter Access | 1.0 min | [ViewRecordForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/ViewRecordForm.vb) |
| **Phase 10** | Administrative Incident Rectification & Investigation Status Transitions | 1.0 min | [EditRecordForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/EditRecordForm.vb) |
| **Phase 11** | Station Analytics, Incident Breakdown & Multi-Format Reporting | 1.0 min | [UcReports.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcReports.vb) |
| **Phase 12** | High-Fidelity Executive PDF Report Generation with PDFsharp & Browser Engine | 1.5 mins | [ReportPrinter.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Services/ReportPrinter.vb) |
| **Phase 13** | Standard CSV Data Export for BFP Higher Headquarters Submissions | 0.5 min | [UcReports.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcReports.vb) (`btnExport_Click`) |
| **Phase 14** | Station Identity Customization, Security Challenge Verification & Live Branding | 1.5 mins | [UcSettings.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcSettings.vb) & [BannerHelper.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Services/BannerHelper.vb) |
| **Phase 15** | Built-In Interactive Station User Manual & Visual Operator Guide | 1.0 min | [UcManual.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcManual.vb) |
| **Phase 16** | System Governance, Immutable Activity Logs & Station Accountability | 0.5 min | [ActivityLogger.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/ActivityLogger.vb) & [ActivityLogRepository.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/DataAccess/ActivityLogRepository.vb) |
| **Phase 17** | Development Team Attribution, Academic Credentials & Station Dedication | 0.5 min | [UcDevelopers.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcDevelopers.vb) |
| **Phase 18** | Automated Test Suite Execution, Technical Verification & Transition to Panel Q&A | 0.5 min | `dotnet test` / [RMIS_BFP_Tuao.Tests](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao.Tests/RMIS_BFP_Tuao.Tests.vbproj) |
| **Total** | **Full System Defense Presentation** | **~18.0 mins** | — |

---

## 🛠️ Pre-Defense Staging & Credentials Setup

Before commencing the capstone defense presentation, prepare your demonstration workstation:

1. **Host Environment & Runtime Readiness**:
   * **Operating System:** Windows 10 / 11 (64-bit).
   * **Framework Runtime:** .NET 8.0 Windows Desktop Runtime (`net8.0-windows`).
   * **Database Server:** Microsoft SQL Server (LocalDB, Express, or Developer Edition) running locally.
   * **Connection Configuration:** Ensure `config.txt` is present in the build output directory (`RMIS_BFP_Tuao\bin\Debug\net8.0-windows\config.txt`) containing the valid target connection string (e.g., `Server=.\SQLEXPRESS;Database=RMIS_BFP_Tuao;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;`).
2. **Demonstration Accounts**:
   * **Administrator Account:** `admin` | Password: `admin123` | Role: `Admin` (Full access: Add, View, Edit, Delete, Reports, Settings, Manual).
   * **Security Question for Admin:** *"What is the name of the city where you were born?"* | Answer: `Tuao` (or seeded answer).
   * **Staff Account:** `staff` | Password: `staff123` | Role: `Staff` (Operational access: Add, View records without Edit/Delete, Reports, Manual).
3. **Database Auto-Provisioning**:
   * The system automatically validates and creates all 4 tables (`tbl_IncidentRecords`, `tbl_Users`, `tbl_ActivityLogs`, `tbl_Settings`) upon startup via [DatabaseInitializer.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/DataAccess/DatabaseInitializer.vb). No manual SQL query execution is required.
4. **Automated Verification Validation**:
   * Confirm system integrity by running MSTest in terminal: `dotnet test` (46 unit and integration tests covering hashing, models, sessions, lockout tracking, and PDF printing).

---

### 👥 Seeded Demonstration Accounts

| # | Username | Password | Role | Security Question | Default Security Answer | Permitted Scope |
| :- | :--- | :--- | :--- | :--- | :--- | :--- |
| 1 | **admin** | `admin123` | **Admin** | *What is the name of the city where you were born?* | `Tuao` | Full System Governance, Record Editing, Record Deletion, Station Settings, Activity Logging |
| 2 | **staff** | `staff123` | **Staff** | *What is your mother's maiden name?* | `Bangan` | Incident Logging, Search & Filter, PDF/CSV Report Generation, User Manual Review (Edit/Delete buttons restricted) |

---

### 🚒 Seeded Fire Incident Records Inventory (Demonstration Dataset)

| Incident No | Date & Military Time | Incident Type | Involved Property | Address / Location | Alarm Level | Casualties | Est. Damage (₱) | Status | Attached Blotter |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| **INC-2026-001** | 01/14/2026 14:30 | Structure Fire | Residential House (2-Storey Wooden) | Centro 01, Tuao, Cagayan | 2nd Alarm | 0 | ₱350,000 | `Resolved` | `Blotter_INC-2026-001.pdf` |
| **INC-2026-002** | 02/03/2026 09:15 | Grass Fire | Open Agricultural Field | Brgy. Bagumbayan, Tuao | 1st Alarm | 0 | ₱15,000 | `Closed` | `Spot_Report_002.docx` |
| **INC-2026-003** | 03/18/2026 21:45 | Electrical Fire | Commercial Grocery Store | Brgy. Alabug, Tuao | 3rd Alarm | 1 | ₱1,200,000 | `Under Investigation` | `Investigation_003.pdf` |
| **INC-2026-004** | 04/05/2026 11:20 | Vehicular Fire | Commercial Delivery Truck | National Highway, Malalinta | 1st Alarm | 0 | ₱450,000 | `Resolved` | `Blotter_INC-2026-004.pdf` |
| **INC-2026-005** | 05/22/2026 03:10 | Structure Fire | Public Market Stall (Dry Goods) | Public Market, Centro 02 | 4th Alarm | 2 | ₱2,500,000 | `Active` | `Blotter_INC-2026-005.pdf` |

---

## 🎬 Step-by-Step Presentation Script (From First to Last)

---

### Step 1: Project Rationale, Municipal Fire Protection Context & Institutional Problem Statement
* **Screen Display:** Application Launch or Title Slide / [MainForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/MainForm.vb)
* **Estimated Time:** 1.5 minutes
* **Screen Action:** Present the opening screen showing the official branding of the **Bureau of Fire Protection — Tuao Fire Station**, highlighting the red-and-gold emergency service theme.
* **🗣️ Verbal Script:**
  > *"Good morning, honorable members of the panel, our respected capstone adviser, and guests. Today, we are honored to present **RMIS-BFP Tuao — the Record Management Information System for the Bureau of Fire Protection - Tuao Fire Station, Cagayan**.
  >
  > *The municipality of Tuao spans 32 barangays with vast agricultural land, residential communities, and commercial centers. As the frontline emergency agency, BFP Tuao responds to residential structure fires, grass fires, vehicular accidents, and commercial emergencies across the district.
  >
  > *Historically, BFP Tuao relied heavily on handwritten physical blotter logbooks, paper incident forms, and manual typewriter reports. This traditional paper-based process suffered from critical vulnerabilities: incident records were prone to physical degradation and flood or fire risks; searching through past blotters during legal inquiries or insurance verifications took hours; generating monthly statistical reports for BFP Provincial and Regional Headquarters was tedious; and response times, alarm levels, and casualty tallies were scattered across multiple folders.
  >
  > *RMIS-BFP Tuao was engineered specifically to solve these challenges by providing a centralized, secure, desktop-grade information system that modernizes fire incident archiving, automates high-fidelity PDF report generation, and guarantees complete audit traceability."*

---

### Step 2: Technical Architecture, 3-Tier Layering & Defensive Security Baseline
* **Screen Display:** Architecture Diagram / [SystemBlueprint.md](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Docs/SystemBlueprint.md) / [dbconstring.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/dbconstring.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:** Walk through the clean separation of layers in Visual Studio Solution Explorer: UI Forms & UserControls -> Service Facade -> DataAccess Repositories -> Microsoft SQL Server.
* **🗣️ Verbal Script:**
  > *"Architecturally, RMIS-BFP Tuao is engineered as a robust Windows desktop application built on modern **.NET 8 (`net8.0-windows`)** using **Visual Basic .NET** and **Microsoft SQL Server**.
  >
  > *We strictly adhered to a **3-tier separation of concerns**:
  > 1. **Presentation Layer:** WinForms UserControls hosted dynamically inside a single parent frame ([MainForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/MainForm.vb)), enhanced with DPI awareness ([DpiHelper.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Helpers/DpiHelper.vb)) to guarantee crystal-clear layout scaling on modern high-resolution station monitors.
  > 2. **Business & Service Layer:** The singleton [RecordService.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Services/RecordService.vb) coordinates business rules, document storage ([DocumentStorage.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Services/DocumentStorage.vb)), and reporting pipelines without exposing raw SQL to the UI.
  > 3. **Data Access Layer:** Dedicated repositories ([IncidentRepository.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/DataAccess/IncidentRepository.vb), [UserRepository.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/DataAccess/UserRepository.vb), [SettingsRepository.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/DataAccess/SettingsRepository.vb)). Every SQL command executes via strictly **parameterized queries using `SqlCommand.Parameters.AddWithValue`**, making SQL injection mathematically impossible.
  > 4. **Defensive Cryptography:** Passwords are never stored in plaintext. We utilize **BCrypt hashing (`BCrypt.Net-Next`) at work factor 11**, protecting credentials even if the raw database is extracted.
  > 5. **Credential Isolation:** The database connection string is externalized to `config.txt` and excluded from version control, adhering to professional software release standards."*

---

### Step 3: Application Bootstrapping & Self-Healing Database Initialization
* **Screen Display:** [ApplicationEvents.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/ApplicationEvents.vb) & [DatabaseInitializer.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/DataAccess/DatabaseInitializer.vb)
* **Estimated Time:** 0.5 minute
* **Screen Action:** Explain how the application initializes before showing any form.
* **🗣️ Verbal Script:**
  > *"Reliability is paramount in an emergency services environment. Through [ApplicationEvents.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/ApplicationEvents.vb), the application intercepts the startup pipeline prior to rendering the login form.
  >
  > *The engine invokes [DatabaseInitializer.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/DataAccess/DatabaseInitializer.vb), which performs idempotent DDL execution: it automatically verifies that `tbl_IncidentRecords`, `tbl_Users`, `tbl_ActivityLogs`, and `tbl_Settings` exist. If a table or column is missing, it auto-creates them on the fly and seeds the default administrator account and default station settings.
  >
  > *If the database server is completely unreachable, the application traps the exception gracefully with an informative diagnostic message rather than crashing abruptly."*

---

### Step 4: Station Authentication, Brute-Force Throttling & Live Lockout Countdown
* **Screen Display:** [LoginForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/LoginForm.vb)
* **Estimated Time:** 1.5 minutes
* **Screen Action:**
  1. Showcase the Login dialog with the dynamic station logo.
  2. Enter an incorrect password intentionally twice to demonstrate remaining attempt warning messages: *"Invalid username or password. 2 attempt(s) remaining before lockout."*
  3. Enter an incorrect password a third time to trigger the **Account Lockout Policy**:
     * Observe the Login button dynamically changing to: `LOCKED (15s)` with a red warning banner.
     * Show that the login button is completely disabled, and the countdown timer decrements every second in real time.
  4. Wait for the countdown to expire, then input valid credentials (`admin` / `admin123`) to demonstrate successful authentication, session initialization, and seamless navigation to the main dashboard.
* **🗣️ Verbal Script:**
  > *"Station security begins at authentication. In [LoginForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/LoginForm.vb), we implemented an intelligent anti-brute-force defense powered by [LoginAttemptTracker.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Helpers/LoginAttemptTracker.vb).
  >
  > *If an unauthorized actor repeatedly attempts to guess credentials, the system enforces a strict 3-attempt ceiling. Upon the 3rd failed attempt, the account is immediately locked out for 15 seconds. The login button is disabled, visually displaying the remaining lockout seconds in real time.
  >
  > *Furthermore, every successful and failed attempt is instantaneously recorded in the audit trail with exact timestamps. Upon entering valid credentials, the lockout state resets, the user's role is stored in [SessionManager.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/SessionManager.vb), and the main command portal opens."*

---

### Step 5: Autonomous Station Credential Recovery & Security Trapping
* **Screen Display:** [ForgotPasswordForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/ForgotPasswordForm.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:**
  1. Click **"Forgot Password?"** on the login form.
  2. Input username `admin` and click **"Verify"**.
  3. Point out how the system validates that the username exists and that a security question has been configured without revealing confidential data upfront.
  4. Select the security question: *"What is the name of the city where you were born?"* and type the answer `Tuao`.
  5. Click **"Verify Answer"** to unlock the new password fields.
  6. Highlight the real-time show/hide password checkbox, enter a new password, and demonstrate the BCrypt update confirmation.
* **🗣️ Verbal Script:**
  > *"In government fire stations, emergency personnel rotate on shifts 24/7. If an officer forgets their password during an off-hour emergency, waiting for an external technician is unacceptable.
  >
  > *Our self-service [ForgotPasswordForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/ForgotPasswordForm.vb) implements zero-knowledge identity trapping. The system never displays the stored security question to prevent social-engineering reconnaissance; the user must actively select their enrolled question and submit the exact answer.
  >
  > *Once verified against our hashed database repository, the officer securely updates their password, with every step logged to the station activity trail."*

---

### Step 6: Incident Command Dashboard & Real-Time Operational Telemetry
* **Screen Display:** [UcDashboard.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcDashboard.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:**
  1. Highlight the header greeting showing the logged-in officer name, current system date, and active session status.
  2. Present the 4 operational KPI summary cards:
     * **Total Incident Records**
     * **Active Incident Calls**
     * **Resolved Incidents**
     * **Closed Cases**
  3. Showcase the **Recent 5 Fire Incidents** live DataGridView table showing Incident No, Incident Type, Date, Involved Property, and Status badge.
* **🗣️ Verbal Script:**
  > *"Upon logging in, the station duty officer is greeted by the **Incident Command Dashboard**.
  >
  > *At a single glance, station commanders and shift duty officers can monitor key operational metrics: Total Incidents recorded, currently Active emergency calls, Resolved operations, and officially Closed investigations.
  >
  > *Below the metric cards is the Recent Incidents stream, which loads the 5 most recent dispatches in descending chronological order. This ensures seamless shift handovers between incoming and outgoing fire crews."*

---

### Step 7: Incident Encoding Wizard, Blotter Attachment & Military Time Logging
* **Screen Display:** [UcAddRecord.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcAddRecord.vb)
* **Estimated Time:** 2.0 minutes
* **Screen Action:**
  1. Navigate to **"Add Record"** from the left sidebar navigation.
  2. Point out the auto-generated Incident Number (e.g., `INC-2026-006`):
     * Explain that this is calculated dynamically from `MAX(RecordID)` for the current year, making it collision-safe and compliant with BFP standard indexing.
  3. Select Incident Type: `Structure Fire` (options: Structure Fire, Vehicular Fire, Grass Fire, Industrial Fire, Electrical Fire, Other).
  4. Select Incident Date & Time and check the **Response Time** picker (demonstrating military time format: `HH:mm`).
  5. Fill in the incident fields:
     * Involved Property: `2-Storey Commercial Building`
     * Address: `Barangay Centro 02, Tuao, Cagayan`
     * Owner/Occupant: `Mr. Eduardo Santos`
     * Caller Information: `Brgy. Tanod Desk - 09175551234`
     * Alarm Level: `2nd Alarm` (1st to 5th Alarm, or General Alarm)
     * Casualties: `0` (validated as whole integer)
     * Damage Estimate (₱): `750000` (validated as decimal currency)
     * Cause of Fire: `Faulty electrical wiring in attic`
     * Remarks: `Quick response prevented fire spread to adjacent commercial stalls.`
     * Status: `Active`
  6. Click **"Browse Document"** to attach an official scanned spot report or blotter PDF (`DocumentStorage.SaveDocument`). Show how the filename is displayed.
  7. Click **"Save Record"**:
     * Show success message: *"Record saved successfully!"*
     * Point out that the form automatically resets and increments the next Incident Number.
* **🗣️ Verbal Script:**
  > *"The primary operational module is the **Incident Encoding Wizard** ([UcAddRecord.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcAddRecord.vb)):
  >
  > *First, the system automatically assigns an official, collision-safe Incident ID following the BFP standard format `INC-YYYY-NNN`.
  >
  > *Second, we enforce strict data integrity: numeric validation on casualties and estimated monetary damage, and military-time recording for emergency response time.
  >
  > *Third, physical blotters and spot investigation reports are digitized directly into the system through our [DocumentStorage.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Services/DocumentStorage.vb) pipeline. Files are copied into a managed station archive folder tied directly to the incident record, ensuring that physical paper records can never be lost or separated from their digital entry."*

---

### Step 8: Interactive Fire Incident Catalog, Live Keyword Search & Multi-Tier Filtering
* **Screen Display:** [UcViewRecords.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcViewRecords.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:**
  1. Navigate to **"View Records"**.
  2. Showcase the comprehensive records DataGridView: Incident No, Type, Date & Military Time, Involved Property, and Status.
  3. Demonstrate **Instant Live Search**:
     * Type `Centro` into the search box: the grid immediately filters to records situated in Centro.
     * Type `INC-2026-001`: instantly isolates the exact incident.
  4. Demonstrate **Dropdown Filters**:
     * Filter by Incident Type: select `Structure Fire` or `Grass Fire`.
     * Filter by Status: select `Active`, `Resolved`, `Under Investigation`, or `Closed`.
  5. Highlight the total record counter badge updating in real time at the bottom of the table.
* **🗣️ Verbal Script:**
  > *"In [UcViewRecords.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcViewRecords.vb), station personnel can search and filter thousands of historical incidents within milliseconds.
  >
  > *Our multi-tier filter combines instant debounced text searching across Record IDs, involved properties, and barangay addresses, synchronized with incident type and operational status dropdowns.
  >
  > *Notice that for standard Staff users, destructive actions are locked down; only authenticated Administrators have access to Edit and Delete buttons, preserving data integrity."*

---

### Step 9: Comprehensive Incident Dossier Inspection & Digital Blotter Access
* **Screen Display:** [ViewRecordForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/ViewRecordForm.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:**
  1. Select an incident record in the grid (e.g., `INC-2026-001`) and click **"View Details"**.
  2. Showcase the comprehensive, read-only incident dossier dialog:
     * Full date and military time breakdown.
     * Response time in military format (`14:38`).
     * Alarm Level (`2nd Alarm`), Owner/Occupant, and Caller Information.
     * Casualties, Estimated Damage in Philippine Pesos, and Official Remarks.
  3. Click **"Open Document"**:
     * Show how the attached scanned blotter / spot investigation document opens instantly in the default Windows system viewer via `Process.Start`.
* **🗣️ Verbal Script:**
  > *"When investigating officers or insurance evaluators visit the station, clicking 'View Details' opens the **Comprehensive Incident Dossier** ([ViewRecordForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/ViewRecordForm.vb)).
  >
  > *This presents all operational data in a clean, read-only format. Furthermore, with one click on 'Open Document', the system directly summons the archived digital blotter or photo evidence into Windows, eliminating the need to physically rummage through archive cabinets."*

---

### Step 10: Administrative Incident Rectification & Investigation Status Transitions
* **Screen Display:** [EditRecordForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/EditRecordForm.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:**
  1. Select a record with status `Active` or `Under Investigation` (e.g., `INC-2026-003`).
  2. Click **"Edit Record"** (enabled for Admin role).
  3. Modify fields:
     * Update Cause of Fire: `Arson investigation cleared; concluded as overloaded electrical extension cord.`
     * Transition Status: from `Under Investigation` to `Resolved`.
     * Update Damage Estimate or attach updated final investigation documents if available.
  4. Click **"Save Changes"**:
     * Observe the immediate refresh of the grid and the confirmation dialog.
     * Explain that this modification is logged into `tbl_ActivityLogs` with the Admin's username.
* **🗣️ Verbal Script:**
  > *"Fire investigations are dynamic: initial spot reports often change as arson investigators conclude their findings.
  >
  > *Through [EditRecordForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/EditRecordForm.vb), station administrators can update alarm levels, record newly determined causes of fire, and transition cases from 'Active' to 'Resolved' or 'Closed'.
  >
  > *Every single edit is tracked in the audit trail, ensuring complete administrative accountability for legal and insurance compliance."*

---

### Step 11: Station Analytics, Incident Breakdown & Multi-Format Reporting
* **Screen Display:** [UcReports.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcReports.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:**
  1. Navigate to **"Reports"** in the sidebar.
  2. Point out the dynamic KPI cards: *Total Filtered Records, Active Incidents, Resolved Incidents, and Closed Cases*.
  3. Inspect the **Incident Breakdown Grid**:
     * Rows categorized by fire incident types: *Structure Fire, Vehicular Fire, Grass Fire, Industrial Fire, Electrical Fire, Other*.
     * Columns displaying: *Total Count, Active Cases, Resolved Cases, Other/Under Investigation*.
  4. Test the live filters (Search keyword, Incident Type, and Status) and show how the breakdown matrix recalculates dynamically.
* **🗣️ Verbal Script:**
  > *"Every month, the Tuao Fire Station must prepare operational reports for the BFP Cagayan Provincial Office and BFP Region II.
  >
  > *In [UcReports.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcReports.vb), our analytics engine automatically groups and tallies records by incident type and resolution status.
  >
  > *Station officers no longer spend days cross-referencing paper logs; the analytics matrix calculates total fire incidents, active emergencies, and resolved cases instantaneously."*

---

### Step 12: High-Fidelity Executive PDF Report Generation with PDFsharp & Browser Engine
* **Screen Display:** Click **"Print Report"** on [UcReports.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcReports.vb) -> Generated PDF in Browser
* **Estimated Time:** 1.5 minutes
* **Screen Action:**
  1. Click the red **"Print Report"** button in [UcReports.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcReports.vb).
  2. Watch the system generate an executive-ready PDF report using [ReportPrinter.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Services/ReportPrinter.vb) and automatically open it in the default web browser (Edge/Chrome).
  3. Walk through the anatomy of the generated PDF document:
     * **Official BFP Letterhead:** Republic of the Philippines, Department of the Interior and Local Government, Bureau of Fire Protection - Tuao Fire Station.
     * **Executive Summary KPI Boxes:** Total Incidents, Active, Resolved, and Closed metrics.
     * **Tabular Breakdown Table:** Clean bordered matrix of incident types, active cases, resolved cases, and total percentages.
     * **Detailed Records Ledger:** ID, Type, Date/Time, Location, Alarm Level, Casualties, and Damage.
     * **Official Certified Signatories:** Formally structured signature lines:
       * *Prepared By:* Logged-in Station Officer (Username).
       * *Verified By:* Chief of Operations / Investigation Officer.
       * *Approved By:* Municipal Fire Marshal / Station Commander.
* **🗣️ Verbal Script:**
  > *"The jewel of our reporting module is the **Executive PDF Generation Engine** ([ReportPrinter.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Services/ReportPrinter.vb)).
  >
  > *Instead of relying on fragile third-party Office installations, we engineered a native PDF generator using **PDFsharp** and a custom [WindowsFontResolver.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Services/WindowsFontResolver.vb).
  >
  > *With one click, the system renders an audit-compliant, Letter-sized document containing the official BFP Republic letterhead, executive summary KPI boxes, an incident categorization matrix, and formal signatory blocks for the Station Commander and Duty Officer. It automatically opens directly inside the browser for instant printing or digital dispatch to BFP Headquarters."*

---

### Step 13: Standard CSV Data Export for BFP Higher Headquarters Submissions
* **Screen Display:** Click **"Export CSV"** in [UcReports.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcReports.vb)
* **Estimated Time:** 0.5 minute
* **Screen Action:**
  1. Click **"Export CSV"**.
  2. Demonstrate the native Windows `SaveFileDialog` automatically generating a date-stamped file name (e.g., `RMIS_Report_20260930.csv`).
  3. Save the file and briefly open it to showcase the structured comma-separated data ready for Microsoft Excel or regional database ingestion.
* **🗣️ Verbal Script:**
  > *"In addition to formatted PDF reports, regional data consolidation often requires structured raw data.
  >
  > *Our 'Export CSV' utility extracts the filtered incident breakdown into standardized comma-separated values, allowing BFP administrators to import station data into Excel or national BFP analytics systems with zero transcription errors."*

---

### Step 14: Station Identity Customization, Security Challenge Verification & Live Branding
* **Screen Display:** [UcSettings.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcSettings.vb)
* **Estimated Time:** 1.5 minutes
* **Screen Action:**
  1. Navigate to **"Settings"** in the sidebar.
  2. Point out the **Security Question Verification Challenge**:
     * Show that the sensitive settings panels are completely hidden behind a security gate.
     * Explain that if a terminal is left unlocked, an unauthorized person cannot modify station configurations or passwords without answering the security question.
  3. Enter the security answer `Tuao` and click **"Verify Answer"**:
     * Show the panels unlocking with an activity log entry.
  4. Showcase the configurable sections:
     * **Station Configuration:** Station Name (`BFP Tuao Fire Station`) and Station Address (`Tuao, Cagayan`).
     * **Banner & Logo Customization:** Click Browse to upload a custom station banner, then click Save Banner. Demonstrate how [BannerHelper.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Services/BannerHelper.vb) updates the sidebar logo in real time across the entire application without needing to restart.
     * **Account Settings:** Username and BCrypt password change fields.
     * **Security Question Setup:** Ability to update enrolled recovery questions and answers.
  5. Click **"Lock Settings"** to demonstrate re-engaging the security challenge.
* **🗣️ Verbal Script:**
  > *"Under [UcSettings.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcSettings.vb), we implemented an innovative **Security Challenge Barrier**.
  >
  > *In a busy fire station, duty officers often leave their desks during emergency dispatches. To prevent unauthorized personnel or visitors from tampering with station settings, access is protected by an in-app security verification gate.
  >
  > *Once unlocked, administrators can update the station name, station address, and customize the station banner logo in real time via [BannerHelper.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Services/BannerHelper.vb). The new logo immediately reflects on the sidebar and login forms across the system."*

---

### Step 15: Built-In Interactive Station User Manual & Visual Operator Guide
* **Screen Display:** [UcManual.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcManual.vb)
* **Estimated Time:** 1.0 minute
* **Screen Action:**
  1. Navigate to **"User Manual"** in the sidebar.
  2. Show the left topic selector featuring 7 distinct instructional modules:
     * *1. System Overview & Authentication*
     * *2. Dashboard & Quick Analytics*
     * *3. Adding Fire Incident Records*
     * *4. Viewing, Searching & Managing Records*
     * *5. Generating Reports & PDF Printing*
     * *6. Settings & Station Customization*
     * *7. Development Team & Technical Credits*
  3. Click through topics (e.g., Topic 3: Adding Fire Incident Records and Topic 5: Generating Reports).
  4. Showcase the rich RTF formatted instructions alongside the embedded high-resolution screenshot preview.
  5. Click **"View Full Size Image"** to demonstrate the modal screenshot zoom viewer.
* **🗣️ Verbal Script:**
  > *"To ensure seamless onboarding for newly assigned BFP personnel, RMIS incorporates a built-in **Interactive User Manual** ([UcManual.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcManual.vb)).
  >
  > *Divided into 7 comprehensive topics, the manual features formatted step-by-step procedures accompanied by high-resolution visual screenshots with full-size zoom inspection.
  >
  > *This guarantees that every fire officer can operate the system proficiently with zero external training overhead."*

---

### Step 16: System Governance, Immutable Activity Logs & Station Accountability
* **Screen Display:** Code Review of [ActivityLogger.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/ActivityLogger.vb) & Database table `tbl_ActivityLogs`
* **Estimated Time:** 0.5 minute
* **Screen Action:**
  1. Briefly highlight the `tbl_ActivityLogs` database architecture.
  2. Show how every action — user logins, failed attempts, record insertions, record updates, record deletions, and settings changes — is committed with a timestamp, username, outcome (`Success`/`Failed`), and a descriptive explanation.
  3. Emphasize that [ActivityLogger.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/ActivityLogger.vb) is designed as a safe fire-and-forget mechanism that swallows its own exceptions, ensuring a logging hiccup never interrupts life-critical fire operations.
* **🗣️ Verbal Script:**
  > *"Because fire incident records are legal documents frequently subpoenaed in court proceedings, forensic accountability is non-negotiable.
  >
  > *Our append-only [ActivityLogger.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/ActivityLogger.vb) automatically logs every critical transaction. Furthermore, it is engineered with fault tolerance: logging operations swallow internal errors so that no logging failure can ever interrupt emergency station encoding."*

---

### Step 17: Development Team Attribution, Academic Credentials & Station Dedication
* **Screen Display:** [UcDevelopers.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcDevelopers.vb)
* **Estimated Time:** 0.5 minute
* **Screen Action:**
  1. Navigate to the **"Developers"** tab.
  2. Present the application specification: *RMIS - BFP Tuao v1.0.0 (Prototype), Built on VB.NET, WinForms, .NET 8, SQL Server*.
  3. Showcase the profiles of the capstone developers:
     * **Angelika Bangan** — BSIT, Contact: `09533416197`, Email: `angelikabangan19@gmail.com`
     * **Ricky Paat** — BSIT, Contact: `09615344796`, Email: `rickypaat6@gmail.com`
  4. Highlight the developer photo rendering engine and formal dedication to the personnel of BFP Tuao Fire Station.
* **🗣️ Verbal Script:**
  > *"Under the Developers portal ([UcDevelopers.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcDevelopers.vb)), we proudly present our system versioning, technical specifications, and development team credentials.
  >
  > *This system represents the collaborative capstone work of Angelika Bangan and Ricky Paat, developed with direct operational input from the firefighters and staff of BFP Tuao."*

---

### Step 18: Automated Test Suite Execution, Technical Verification & Transition to Panel Q&A
* **Screen Display:** Visual Studio Test Explorer or Terminal running `dotnet test` / [RMIS_BFP_Tuao.Tests](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao.Tests/RMIS_BFP_Tuao.Tests.vbproj)
* **Estimated Time:** 0.5 minute
* **Screen Action:**
  1. Switch to terminal and execute: `dotnet test`.
  2. Display the passing test execution: **46 total MSTest unit and integration tests** verifying PasswordHelper BCrypt hashing, LoginAttemptTracker concurrency and expiration, SessionManager, RecordModel, and ReportPrinter font resolution with 0 failures.
  3. Conclude the formal presentation and invite panel scrutiny.
* **🗣️ Verbal Script:**
  > *"To ensure rock-solid stability and prevent software regressions, we constructed a dedicated MSTest verification suite in [RMIS_BFP_Tuao.Tests](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao.Tests/RMIS_BFP_Tuao.Tests.vbproj). Across 46 unit and integration test assertions, all cryptography, session handling, lockout counters, and PDF generation tests pass cleanly with zero errors.
  >
  > *In conclusion, RMIS-BFP Tuao elevates the Bureau of Fire Protection - Tuao Fire Station from vulnerable paper blotters to an automated, secure, and modern digital standard.
  >
  > *Thank you very much, honorable members of the panel. We are now open and eager to entertain your questions."*

---

## 🛡️ Capstone Defense Panelist Q&A Cheat Sheet

| Question | Recommended Technical & Institutional Answer |
| :--- | :--- |
| **Q1: Why build a Windows desktop application (WinForms) rather than a cloud-based web application for a fire station?** | *"Fire stations are **critical emergency response facilities**. In rural municipalities like Tuao, severe typhoons, floods, and natural disasters frequently sever internet connectivity and damage cellular towers. A web application dependent on cloud servers becomes completely inaccessible during the exact emergencies when firefighters need it most. Our .NET 8 WinForms desktop architecture guarantees **100% offline operability, zero network latency, instant local file attachment access, and immunity to public internet outages**, while maintaining local area network scalability via Microsoft SQL Server."* |
| **Q2: How does the system prevent SQL injection attacks across all search and data-entry fields?** | *"We enforce a strict zero-concatenation policy across the entire codebase. In [IncidentRepository.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/DataAccess/IncidentRepository.vb) and [UserRepository.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/DataAccess/UserRepository.vb), every database transaction uses **parameterized queries with `SqlCommand.Parameters.AddWithValue`** (or explicit typed `SqlParameter` objects). User input from textboxes is treated purely as data literals rather than executable SQL syntax, completely neutralizing SQL injection vulnerabilities."* |
| **Q3: How is the Incident ID (`INC-YYYY-NNN`) generated, and what prevents ID collisions or reuse after record deletions?** | *"In [IncidentRepository.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/DataAccess/IncidentRepository.vb), the `GetNextID` function executes `SELECT MAX(RecordID) FROM tbl_IncidentRecords WHERE RecordID LIKE 'INC-' + @Year + '-%'`. It parses the numeric suffix of the highest existing record and increments it by one (`MAX + 1`). Because it queries the mathematical maximum rather than a simple table row count, deleting a previous record never causes the sequence to backtrack, ensuring **collision-safe, monotonic, and audit-compliant record numbering**."* |
| **Q4: How does the system prevent brute-force credential attacks on the login interface?** | *"In [LoginAttemptTracker.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Helpers/LoginAttemptTracker.vb) and [LoginForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/LoginForm.vb), we implemented an in-memory thread-safe attempt tracker. Each failed attempt decrements the remaining allowance. Upon reaching 3 consecutive failures, the account is locked for 15 seconds. The login button is disabled and displays a real-time countdown timer (`LOCKED (15s)`), stopping automated dictionary attacks dead in their tracks."* |
| **Q5: Why is there a security question verification challenge before opening the Settings page?** | *"In a municipal fire station, personnel frequently step away from computer consoles to board fire trucks during sudden alarm bells. If an unattended workstation is logged in as an Administrator, any passerby or unauthorized person could tamper with station details or change passwords. In [UcSettings.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcSettings.vb), the security challenge acts as an **in-app re-authentication gate**, requiring the officer to answer their enrolled personal security question before sensitive configuration panels are unveiled."* |
| **Q6: How are physical fire blotters and spot reports attached and stored?** | *"In [DocumentStorage.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Services/DocumentStorage.vb), when an officer attaches a PDF, DOCX, or scanned image, the system validates the file, copies it into an application-managed `Documents\` archive directory, and prefixes the filename with the unique Incident ID (`INC-YYYY-NNN_filename.ext`). The relative path is stored in `tbl_IncidentRecords.AttachmentPath`. This decouples the file from the user's desktop or USB drive, ensuring the document remains permanently accessible to station personnel."* |
| **Q7: How does the system generate PDF reports without requiring Microsoft Office or Adobe Acrobat installed on the PC?** | *"In [ReportPrinter.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Services/ReportPrinter.vb), we utilized **PDFsharp** with our custom [WindowsFontResolver.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Services/WindowsFontResolver.vb). It programmatically constructs a native vector PDF in memory by drawing page geometry, typography, tables, and borders. The generated document is saved to the local station archive and launched directly in the operating system's default web browser (Edge/Chrome) for instant viewing and printing."* |
| **Q8: Why are audit logs stored in `tbl_ActivityLogs` without a strict foreign key to `tbl_Users`?** | *"In database design ([DbSchema.md](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Docs/DbSchema.md)), `tbl_ActivityLogs` maintains a soft reference to the username rather than a rigid foreign key constraint. This ensures **historical immutability**: if a fire officer's account is updated, renamed, or retired in the future, their historical audit trail remains intact and undeleted, fulfilling strict government compliance and legal audit standards."* |
| **Q9: How does the application ensure UI crispness and legibility on different monitor resolutions?** | *"We integrated [DpiHelper.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Helpers/DpiHelper.vb) alongside `app.manifest` configuring `PerMonitorV2` High DPI awareness. The helper dynamically calculates the monitor's DPI scaling factor relative to 96 DPI and resizes DataGridView row heights, column widths, and typography proportionally, ensuring the user interface remains sharp on 1080p, 2K, and 4K command center displays."* |
| **Q10: What is the difference in privileges between the Admin and Staff roles?** | *"Role-based access control is managed via [SessionManager.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/SessionManager.vb). Both Admin and Staff can view dashboards, encode new fire incidents, search records, generate reports, and consult the manual. However, **destructive and corrective actions — specifically the 'Edit' and 'Delete' buttons on the View Records grid — are strictly hidden and disabled for Staff accounts**, ensuring that official records cannot be altered or removed without administrative authorization."* |
| **Q11: How does the system protect passwords against database breach or theft?** | *"We use **BCrypt.Net-Next with a work factor of 11** ([PasswordHelper.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Helpers/PasswordHelper.vb)). BCrypt incorporates an automatic random 128-bit salt and an computationally intensive key-derivation algorithm that is deliberately slow to compute. This makes pre-computed rainbow table attacks and GPU-accelerated brute-force cracking mathematically infeasible."* |
| **Q12: If BFP Tuao upgrades or relocates their station server, how easy is it to migrate the system?** | *"Migration is effortless: (1) Back up the `RMIS_BFP_Tuao` SQL Server database or generate a `.bacpac` copy; (2) Restore it onto the new SQL Server instance; (3) Copy the application folder containing the `Documents\` and `Assets\` directories; and (4) Update the server name in `config.txt`. Zero source code recompilation is required."* |

---

## 💡 Pro-Tips for Defense Day

1. **Conduct a Live Brute-Force Demonstration**:
   * Intentionally type a wrong password three times on [LoginForm.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/LoginForm.vb) to show the panel the dynamic button lockout and 15-second countdown timer. Panelists consistently praise live demonstrations of proactive cybersecurity controls!
2. **Demonstrate Instant PDF Generation & Certified Signatories**:
   * Open [UcReports.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcReports.vb) and click **"Print Report"**. Show the panel the clean, Letter-sized PDF with the official Republic of the Philippines / BFP letterhead, categorized fire statistics, and formal signatory blocks for the Station Commander and Duty Officer.
3. **Showcase the Security Challenge Barrier**:
   * Navigate to [UcSettings.vb](file:///C:/Users/GLENN/source/repos/RMIS_BFP_Tuao/RMIS_BFP_Tuao/Forms/Pages/UcSettings.vb) and point out that sensitive settings are shielded by a personal security question gate. Enter the answer, unlock the controls, change the banner logo, and show how the new logo immediately updates across the system.
4. **Highlight Local Tuao Context**:
   * Ground your presentation in real Tuao geography: reference barangays like Centro 01, Centro 02, Bagumbayan, Alabug, Malalinta, Dagupan, Mambacag, and Naruangan. Emphasize how local firefighters benefit from digitizing blotters and tracking response times across these specific jurisdictions.
5. **Run the Automated Test Suite in Front of Technical Panelists**:
   * If a panelist questions the stability or code quality of the system, open your terminal or Visual Studio Test Explorer and run `dotnet test`. Demonstrating 46 unit and integration tests passing with 0 failures provides indisputable proof of software engineering excellence.
6. **Ensure Standalone Offline Readiness**:
   * Ensure your local SQL Server instance is running and populated with sample data. Because RMIS-BFP Tuao is a self-contained .NET 8 application with local database connectivity, your defense demonstration will proceed flawlessly even if the university auditorium loses internet connectivity.
