# RMIS BFP Tuao — Known Issues

**Last Updated**: 2026-06-19
**Status**: All critical and medium-priority issues resolved. Remaining items are deferred to a future update.

---

## Deferred (Future Work)

Items below are known but intentionally postponed. Pick them up when ready.

| # | Severity | Issue | Location | Notes |
|---|----------|-------|----------|-------|
| 4 | 🟡 MEDIUM | `PersonnelModel.vb` is dead code — no table, no repository, no service, no UI | `Models/PersonnelModel.vb` | Decide: build full Personnel module or delete the file |
| 6 | 🔵 LOW | `Assets/` folder is empty — no BFP logo or icons | `Assets/` | Needs PNG logo file; wire into LoginForm left panel and MainForm sidebar header |
| 7 | 🔵 LOW | Developer names are placeholders (`"Developer 1"`, `"Developer 2"`, `"Developer 3"`) | `Forms/Pages/UcDevelopers.vb:13,17,21` | Replace with real names and roles |
| 8 | 🔵 LOW | No installer — publish profile exists but no setup wizard for end-users | `Properties/PublishProfiles/` | Use ClickOnce (built-in) or Inno Setup |

---

## Implementation Notes (Not Bugs)

Deliberate deviations from the blueprint that are functionally equivalent.

| # | Note | Location |
|---|------|----------|
| A | `ActivityLogger` is a `Class` with `Shared` methods (blueprint says `Module`) — no behavior difference | `ActivityLogger.vb` |
| B | `dbconstring` is a `Class` with a `Shared ReadOnly Property` — uses `Environment.CurrentDirectory` instead of `AppDomain.CurrentDomain.BaseDirectory` | `dbconstring.vb` |
| C | `SessionManager` uses plain public fields instead of `Property` declarations — functionally equivalent | `SessionManager.vb` |
| D | Default credentials `admin` / `admin123` are seeded on first run — **must be changed immediately after first login** via Settings → Account Settings | `DataAccess/DatabaseInitializer.vb` |

---

## Resolved Issues

| # | Issue | Fixed |
|---|-------|-------|
| R1 | Hardcoded credentials in `LoginForm.vb` | Replaced with BCrypt DB auth via `UserRepository` (2026-06-12) |
| R2 | In-memory record list — no persistence | Migrated to SQL via `IncidentRepository` (2026-06-12) |
| R3 | `GetNextID()` collision after record deletion | Fixed: uses `MAX(CAST(...))` per year (2026-06-12) |
| R4 | `UcDevelopers.vb` blank screen on load | Populated dynamically in `_Load` event (2026-06-12) |
| R5 | Sample data seeded from code on every run | Removed: DB starts empty; only admin + settings are seeded (2026-06-12) |
| R6 | No audit trail | Implemented: `ActivityLogger` + `tbl_ActivityLogs` log all user actions (2026-06-12) |
| R7 | Dashboard Card 4 hardcoded `"0"` — never showed real Closed count | Fixed: `UcDashboard.vb` reads live count from records (2026-06-19) |
| R8 | IncidentNo auto-generation was dead code — `GetNextID()` unreachable from Add Record form | Fixed: `UcAddRecord_Load` pre-fills field; `btnClear_Click` regenerates it (2026-06-19) |
| R9 | No numeric validation on Casualties and DamageEstimate | Fixed: `Integer.TryParse` + `Decimal.TryParse` guards in `UcAddRecord.vb` and `EditRecordForm.vb` (2026-06-19) |
| R10 | No RBAC — Staff had same access as Admin | Fixed: Staff cannot see Settings nav, Edit button, or Delete button; both handlers have secondary guards (2026-06-19) |
| R11 | No integration tests — DB layer completely untested | Fixed: `IncidentRepositoryTests`, `UserRepositoryTests`, `SettingsRepositoryTests` added; skip gracefully when `RMIS_TEST_CONNSTR` is not set (2026-06-19) |
