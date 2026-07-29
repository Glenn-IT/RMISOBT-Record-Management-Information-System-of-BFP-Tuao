# Version Control — RMIS BFP Tuao

## Rollout Schedule

| Version | Feature Unlocked | Forms / Pages Unlocked | Still Gated |
|---------|-----------------|------------------------|-------------|
| v1.00 | Login Only | `LoginForm`, `ForgotPasswordForm`, `MainForm` | Dashboard, Add Record, View Records, Reports, Settings, Developers |
| v1.01 | Dashboard + Add Record | `UcDashboard`, `UcAddRecord` | View Records, Reports, Settings, Developers |
| v1.02 | View Records + Edit Record | `UcViewRecords`, `EditRecordForm` | Reports, Settings, Developers |
| v1.03 | Reports | `UcReports` | Settings, Developers |
| v1.04 | Admin Settings | `UcSettings` | Developers |
| v1.05 | Developers (Full System) | `UcDevelopers` | — |
| v2.00 | Dashboard + Admin Settings only | `UcDashboard`, `UcSettings` | Add Record, View Records, Reports, Developers |
| v2.01 | Same as v2.00 + login field-clearing fix | `UcDashboard`, `UcSettings` | Add Record, View Records, Reports, Developers |
| v3.00 | v2.01 + Add Record | `UcDashboard`, `UcSettings`, `UcAddRecord` | View Records, Reports, Developers |
| v3.01 | v3.00 + DPI scaling fix | `UcDashboard`, `UcSettings`, `UcAddRecord` | View Records, Reports, Developers |
| v4.00 | Login + Dashboard + Add Record + View Records (w/ new incident fields: Owner/Occupant, Alarm Level, Response Time, Caller Information, Cause of Fire, and record-details view) | `LoginForm`, `ForgotPasswordForm`, `UcDashboard`, `UcAddRecord`, `UcViewRecords`, `ViewRecordForm` | Admin Settings, Reports, Developers |

---

## Under Construction Strategy

Gated pages load `UcUnderConstruction` directly inside `pnlPageContainer` in MainForm.
The constant `CURRENT_VERSION` in `UcUnderConstruction.vb` is updated each version so the
page always shows which version is currently being presented.

To gate a page: in `MainForm.vb`, the nav button handler calls `LoadPage(New UcUnderConstruction())`.
To unlock a page: replace that call with `LoadPage(New UcWhatever())` and restore any original logic.

---

## Git Commands Per Version

```bash
# Stage the unlocked form and the version constant file
git add Forms/Pages/UcUnderConstruction.vb Forms/MainForm.vb

# Commit
git commit -m "feat: implement vX.XX - unlock [Feature Name]"

# Tag and push
git tag vX.XX
git push origin master
git push origin vX.XX
```

---

## How Git Tags Work

Each `git tag vX.XX` creates a permanent, immutable pointer to that exact commit.
Even if later commits change the code, checking out `vX.XX` always restores that
exact presentation state. Tags are pushed separately with `git push origin vX.XX`.

---

## GitHub Release Tags

| Version | Tag Name | Commit Hash |
|---------|----------|-------------|
| v1.00 | v1.00 | f5dacf823fbfcb150bad9685735205bd88385376 |
| v1.01 | v1.01 | c0fe73cfd7350c8da6e561268a99f65aa1066371 |
| v1.02 | v1.02 | f5c2d674a1b3873ebcdaebdd2a0e7bfc788f486a |
| v1.03 | v1.03 | 1623d0ebc95060c97330c11f020e3c1e48dbd200 |
| v1.04 | v1.04 | a695c22d7eb4b26fe526b39c10445c18eaaa3fd0 |
| v1.05 | v1.05 | c04b538bb8451c5257861fbe31a3f0e827948b72 |
| v2.00 | v2.00 | e77ad7ceeb7c424b09a0d359a468885647512fb4 |
| v2.01 | v2.01 | cf85df9d392c94b6b318b3e8921c1bd3d3e05ad8 |
| v3.00 | v3.00 | 46c58a784fd0b7384695cf22f5f00434fc48b4c0 |
| v3.01 | v3.01 | ad471e337c70d8f33a5cd91cf5c6da0790831eee |
| v4.00 | v4.00 | 8394908c9ef814f0333e535e75eb78e80f35f0eb |

Run this after all versions are pushed to fill in hashes:
```bash
git tag | sort | xargs -I{} git log -1 --format="{} %H" {}
```

---

## When a Prof or Client Requests Changes After a Presentation

```bash
# Fix on master first
git checkout master
git add .
git commit -m "feat: update [form] per feedback"
git push origin master

# Re-point the tag to the new commit
git tag -d vX.XX
git push origin :refs/tags/vX.XX
git tag vX.XX
git push origin vX.XX
```
