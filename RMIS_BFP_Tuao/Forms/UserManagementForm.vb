Public Class UserManagementForm

    Private _editingUsername As String = ""

    Private Sub UserManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvUsers.ApplyDpiScaling()
        cboNewRole.Items.Clear()
        For Each r In Constants.Roles
            cboNewRole.Items.Add(r)
        Next
        ResetToNewMode()
        LoadUsers()
    End Sub

    Private Sub LoadUsers()
        Try
            Dim dt = UserRepository.GetAllUsers()
            dgvUsers.Rows.Clear()
            For Each row As DataRow In dt.Rows
                Dim createdDate = If(IsDBNull(row("CreatedAt")), "", Convert.ToDateTime(row("CreatedAt")).ToString("MM/dd/yyyy"))
                dgvUsers.Rows.Add(row("UserID"), row("Username"), row("UserType"), createdDate)
            Next
        Catch ex As Exception
            MessageBox.Show("Failed to load user accounts: " & ex.Message, "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex < 0 OrElse e.RowIndex >= dgvUsers.Rows.Count Then Exit Sub
        LoadUserForEdit(dgvUsers.Rows(e.RowIndex))
    End Sub

    Private Sub LoadUserForEdit(row As DataGridViewRow)
        _editingUsername = row.Cells("colUsername").Value?.ToString()
        If String.IsNullOrEmpty(_editingUsername) Then Exit Sub

        txtNewUsername.Text = _editingUsername
        Dim role = row.Cells("colRole").Value?.ToString()
        If String.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase) Then
            role = Constants.UserTypeSuperAdmin
        End If
        cboNewRole.SelectedItem = role

        txtNewPassword.Clear()
        txtNewConfirm.Clear()

        grpNewUser.Text = $" Edit User: {_editingUsername} "
        lblNewPassword.Text = "New Password:"
        lblPassHelp.Text = "Leave blank to keep current password."
        btnCreateUser.Text = "Update Credentials"
        btnCreateUser.BackColor = Color.FromArgb(180, 20, 20)
        btnNewMode.Visible = True
    End Sub

    Private Sub ResetToNewMode()
        _editingUsername = ""
        txtNewUsername.Clear()
        txtNewPassword.Clear()
        txtNewConfirm.Clear()
        cboNewRole.SelectedIndex = If(cboNewRole.Items.Count > 1, 1, 0) ' Default to Sub Admin

        grpNewUser.Text = " Create New Account "
        lblNewPassword.Text = "Password:"
        lblPassHelp.Text = "Password must be at least 4 characters."
        btnCreateUser.Text = "+ Add User Account"
        btnCreateUser.BackColor = Color.FromArgb(180, 20, 20)
        btnNewMode.Visible = False

        If dgvUsers.Rows.Count > 0 Then
            dgvUsers.ClearSelection()
        End If
    End Sub

    Private Sub btnNewMode_Click(sender As Object, e As EventArgs) Handles btnNewMode.Click
        ResetToNewMode()
    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        Dim username = txtNewUsername.Text.Trim()
        Dim password = txtNewPassword.Text
        Dim confirmPw = txtNewConfirm.Text
        Dim role = cboNewRole.SelectedItem?.ToString()

        If String.IsNullOrWhiteSpace(username) Then
            MessageBox.Show("Please enter a username.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNewUsername.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(role) Then
            MessageBox.Show("Please select a role for the account.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboNewRole.Focus()
            Exit Sub
        End If

        If _editingUsername = "" Then
            ' ── Create New User Mode ─────────────────────────────────────────
            If String.IsNullOrEmpty(password) Then
                MessageBox.Show("Please enter a password.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtNewPassword.Focus()
                Exit Sub
            End If

            If password.Length < 4 Then
                MessageBox.Show("Password must be at least 4 characters long.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtNewPassword.Focus()
                Exit Sub
            End If

            If password <> confirmPw Then
                MessageBox.Show("Passwords do not match. Please verify and try again.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtNewConfirm.Focus()
                Exit Sub
            End If

            Try
                If UserRepository.Exists(username) Then
                    MessageBox.Show($"The username '{username}' already exists. Please choose a different username.",
                                    "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtNewUsername.SelectAll()
                    txtNewUsername.Focus()
                    Exit Sub
                End If

                Dim hash = PasswordHelper.HashPassword(password)
                UserRepository.Insert(username, hash, role)
                ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess,
                                   $"Created new {role} account: {username}")

                MessageBox.Show($"User account '{username}' ({role}) created successfully!",
                                "User Created", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ResetToNewMode()
                LoadUsers()

            Catch ex As Exception
                MessageBox.Show("Failed to create user account: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' ── Update Existing User Mode ────────────────────────────────────
            Try
                ' If username changed, check duplicate
                If Not String.Equals(username, _editingUsername, StringComparison.OrdinalIgnoreCase) Then
                    If UserRepository.Exists(username) Then
                        MessageBox.Show($"The username '{username}' is already taken. Please choose another.",
                                        "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtNewUsername.SelectAll()
                        txtNewUsername.Focus()
                        Exit Sub
                    End If
                End If

                ' Prevent demoting the only Super Admin
                If role <> Constants.UserTypeSuperAdmin Then
                    Dim existingRole = ""
                    For Each row As DataGridViewRow In dgvUsers.Rows
                        If String.Equals(row.Cells("colUsername").Value?.ToString(), _editingUsername, StringComparison.OrdinalIgnoreCase) Then
                            existingRole = row.Cells("colRole").Value?.ToString()
                            Exit For
                        End If
                    Next
                    If String.Equals(existingRole, Constants.UserTypeSuperAdmin, StringComparison.OrdinalIgnoreCase) OrElse
                       String.Equals(existingRole, "Admin", StringComparison.OrdinalIgnoreCase) Then
                        Dim superAdminCount = CountSuperAdmins()
                        If superAdminCount <= 1 Then
                            MessageBox.Show("Cannot demote the only remaining Super Admin account.",
                                            "Action Prohibited", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End If
                End If

                ' Password check
                Dim newHash = ""
                If Not String.IsNullOrEmpty(password) Then
                    If password.Length < 4 Then
                        MessageBox.Show("Password must be at least 4 characters long.", "Validation",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtNewPassword.Focus()
                        Exit Sub
                    End If

                    If password <> confirmPw Then
                        MessageBox.Show("Passwords do not match. Please verify and try again.", "Validation",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtNewConfirm.Focus()
                        Exit Sub
                    End If

                    newHash = PasswordHelper.HashPassword(password)
                End If

                UserRepository.UpdateUser(_editingUsername, username, role, newHash)

                ' If editing own account, update SessionManager
                If String.Equals(_editingUsername, SessionManager.Username, StringComparison.OrdinalIgnoreCase) Then
                    SessionManager.Username = username
                    SessionManager.UserType = role
                    Dim main = TryCast(Me.Owner, MainForm)
                    If main Is Nothing Then
                        main = Application.OpenForms().OfType(Of MainForm)().FirstOrDefault()
                    End If
                    If main IsNot Nothing Then
                        main.lblTopUser.Text = $"[ {username} ({role}) ]"
                    End If
                End If

                ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess,
                                   $"Updated credentials for user '{_editingUsername}' (New Name: '{username}', Role: {role})")

                MessageBox.Show($"Credentials for user '{username}' were updated successfully!",
                                "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ResetToNewMode()
                LoadUsers()

            Catch ex As Exception
                MessageBox.Show("Failed to update user account: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function CountSuperAdmins() As Integer
        Dim count = 0
        For Each row As DataGridViewRow In dgvUsers.Rows
            Dim r = row.Cells("colRole").Value?.ToString()
            If String.Equals(r, Constants.UserTypeSuperAdmin, StringComparison.OrdinalIgnoreCase) OrElse
               String.Equals(r, "Admin", StringComparison.OrdinalIgnoreCase) Then
                count += 1
            End If
        Next
        Return count
    End Function

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If dgvUsers.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user account to delete.", "No Selection",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedUsername = dgvUsers.SelectedRows(0).Cells("colUsername").Value?.ToString()
        Dim selectedRole = dgvUsers.SelectedRows(0).Cells("colRole").Value?.ToString()

        If String.Equals(selectedUsername, SessionManager.Username, StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("You cannot delete your own currently logged-in account.",
                            "Action Prohibited", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Prevent deleting the only Super Admin
        If String.Equals(selectedRole, Constants.UserTypeSuperAdmin, StringComparison.OrdinalIgnoreCase) OrElse
           String.Equals(selectedRole, "Admin", StringComparison.OrdinalIgnoreCase) Then
            If CountSuperAdmins() <= 1 Then
                MessageBox.Show("Cannot delete the only remaining Super Admin account.",
                                "Action Prohibited", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        Dim confirm = MessageBox.Show($"Are you sure you want to delete user '{selectedUsername}' ({selectedRole})? This action cannot be undone.",
                                      "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Try
                UserRepository.DeleteUser(selectedUsername)
                ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess,
                                   $"Deleted user account: {selectedUsername}")

                MessageBox.Show($"User account '{selectedUsername}' was deleted successfully.",
                                "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetToNewMode()
                LoadUsers()
            Catch ex As Exception
                MessageBox.Show("Failed to delete user: " & ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
