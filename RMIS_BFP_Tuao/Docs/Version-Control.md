# Version Control — RMIS BFP Tuao

## Rollout Schedule

| Version | Feature Unlocked | Forms / Pages Unlocked | Still Gated |
|---------|-----------------|------------------------|-------------|
| v1.00 | Login + Dashboard | `LoginForm`, `ForgotPasswordForm`, `MainForm`, `UcDashboard` | Add Record, View Records, Reports, Settings, Developers |
| v1.01 | Add Record | `UcAddRecord` | View Records, Reports, Settings, Developers |
| v1.02 | View Records + Edit Record | `UcViewRecords`, `EditRecordForm` | Reports, Settings, Developers |
| v1.03 | Reports | `UcReports` | Settings, Developers |
| v1.04 | Admin Settings | `UcSettings` | Developers |
| v1.05 | Developers (Full System) | `UcDevelopers` | — |

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
| v1.00 | v1.00 | *(fill after push)* |
| v1.01 | v1.01 | *(fill after push)* |
| v1.02 | v1.02 | *(fill after push)* |
| v1.03 | v1.03 | *(fill after push)* |
| v1.04 | v1.04 | *(fill after push)* |
| v1.05 | v1.05 | *(fill after push)* |

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
