Public Class SignatoriesForm

    Private Sub SignatoriesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSignatories()
        UpdateSig3State()
    End Sub

    Private Sub LoadSignatories()
        Dim sigs = SignatoryHelper.GetSignatories()
        Dim s1 = sigs.FirstOrDefault(Function(s) s.KeyPrefix = "Signatory1")
        Dim s2 = sigs.FirstOrDefault(Function(s) s.KeyPrefix = "Signatory2")
        Dim s3 = sigs.FirstOrDefault(Function(s) s.KeyPrefix = "Signatory3")

        If s1 IsNot Nothing Then
            txtSig1Label.Text = s1.Label
            txtSig1Name.Text = s1.Name
            txtSig1Title.Text = s1.Title
        End If

        If s2 IsNot Nothing Then
            txtSig2Label.Text = s2.Label
            txtSig2Name.Text = s2.Name
            txtSig2Title.Text = s2.Title
        End If

        If s3 IsNot Nothing Then
            chkSig3Enabled.Checked = s3.Enabled
            txtSig3Label.Text = s3.Label
            txtSig3Name.Text = s3.Name
            txtSig3Title.Text = s3.Title
        End If
    End Sub

    Private Sub chkSig3Enabled_CheckedChanged(sender As Object, e As EventArgs) Handles chkSig3Enabled.CheckedChanged
        UpdateSig3State()
    End Sub

    Private Sub UpdateSig3State()
        Dim isEnabled = chkSig3Enabled.Checked
        txtSig3Label.Enabled = isEnabled
        txtSig3Name.Enabled = isEnabled
        txtSig3Title.Enabled = isEnabled
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtSig1Name.Text) Then
            MessageBox.Show("Please enter the name for Signatory 1.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSig1Name.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtSig2Name.Text) Then
            MessageBox.Show("Please enter the name for Signatory 2.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSig2Name.Focus()
            Exit Sub
        End If

        If chkSig3Enabled.Checked AndAlso String.IsNullOrWhiteSpace(txtSig3Name.Text) Then
            MessageBox.Show("Signatory 3 is enabled. Please enter the name or uncheck the box.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSig3Name.Focus()
            Exit Sub
        End If

        Try
            Dim sigs As New List(Of SignatoryItem)()
            sigs.Add(New SignatoryItem() With {
                .KeyPrefix = "Signatory1",
                .Label = txtSig1Label.Text.Trim(),
                .Name = txtSig1Name.Text.Trim(),
                .Title = txtSig1Title.Text.Trim(),
                .Enabled = True
            })

            sigs.Add(New SignatoryItem() With {
                .KeyPrefix = "Signatory2",
                .Label = txtSig2Label.Text.Trim(),
                .Name = txtSig2Name.Text.Trim(),
                .Title = txtSig2Title.Text.Trim(),
                .Enabled = True
            })

            sigs.Add(New SignatoryItem() With {
                .KeyPrefix = "Signatory3",
                .Label = txtSig3Label.Text.Trim(),
                .Name = txtSig3Name.Text.Trim(),
                .Title = txtSig3Title.Text.Trim(),
                .Enabled = chkSig3Enabled.Checked
            })

            SignatoryHelper.SaveSignatories(sigs)
            ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess,
                               "Updated report signatories.")

            MessageBox.Show("Signatories saved successfully! They will now appear on all printed reports.",
                            "Signatories Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to save signatories: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
