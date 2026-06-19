# Bugs & Feature Requests

---

## Login

- [x] **Forgot Password** — proper form with security question flow
  - "Forgot Password?" link on the login card opens `ForgotPasswordForm`
  - **Step 1 — Verify username**: user enters their username and clicks Verify
    - If found and has a security question set → the question is revealed below
    - If not found or no question set → error message shown
  - **Step 2 — Answer security question**: user types their answer; password fields appear automatically
  - **Step 3 — Set new password**: user enters and confirms new password, clicks Reset Password
    - Answer is case-insensitive (compared in lowercase)
    - Both failed and successful resets are logged to `tbl_ActivityLogs`
  - Security questions are set up per-user in **Settings → Security Question**
  - Default admin security question: *"What is the name of this fire station?"* / Answer: `bfp tuao`
  - **Files**: `Forms/ForgotPasswordForm.vb`, `Forms/ForgotPasswordForm.Designer.vb`,
    `Forms/LoginForm.vb`, `Forms/Pages/UcSettings.vb`, `Forms/Pages/UcSettings.Designer.vb`,
    `DataAccess/UserRepository.vb`, `DataAccess/DatabaseInitializer.vb` ✅

- [x] **Account Lockout**
  - After 3 consecutive failed login attempts for the same username, the account is locked for 15 seconds
  - Error label counts down remaining attempts: *"2 attempt(s) remaining before lockout"*
  - While locked, error label shows remaining seconds: *"Account locked. Try again in 12 second(s)."*
  - Lockout clears automatically after 15 seconds — no admin action needed
  - Successful login resets the counter for that username
  - Lockout state is in-memory (clears if the app is restarted)
  - **File**: `Forms/LoginForm.vb` ✅
