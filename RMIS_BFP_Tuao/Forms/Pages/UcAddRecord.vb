Public Class UcAddRecord
    Inherits UserControl

    Private _documentPath As String = ""

    Private Sub UcAddRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpIncidentDateTime.Value = DateTime.Now
        dtpResponseTime.Checked = False
        cboIncidentType.Items.AddRange(Constants.IncidentTypes)
        cboStatus.Items.AddRange(Constants.Statuses)
        cboAlarmLevel.Items.AddRange(Constants.AlarmLevels)
        cboIncidentType.SelectedIndex = 0
        cboStatus.SelectedIndex = 0
        cboAlarmLevel.SelectedIndex = 0
        Try
            txtIncidentNo.Text = RecordService.Instance.GetNextID()
        Catch
            ' Leave blank if DB not yet available; user can type manually
        End Try
    End Sub

    Private Sub btnBrowseDocument_Click(sender As Object, e As EventArgs) Handles btnBrowseDocument.Click
        Using dlg As New OpenFileDialog()
            dlg.Filter = "Documents|*.pdf;*.doc;*.docx;*.jpg;*.jpeg;*.png"
            If dlg.ShowDialog() = DialogResult.OK Then
                _documentPath = dlg.FileName
                txtDocumentName.Text = IO.Path.GetFileName(_documentPath)
            End If
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtInvolvedProperty.Text.Trim() = "" OrElse
           txtAddress.Text.Trim() = "" OrElse
           txtCallerInformation.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all required fields marked with *.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If _documentPath = "" Then
            MessageBox.Show("You must upload a document.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtIncidentNo.Text.Trim() = "" Then
            MessageBox.Show("Incident No could not be generated. Please enter it manually.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim casualties = txtCasualties.Text.Trim()
        Dim damage = txtDamageEstimate.Text.Trim()

        If casualties <> "" Then
            Dim dummy As Integer
            If Not Integer.TryParse(casualties, dummy) OrElse dummy < 0 Then
                MessageBox.Show("Casualties must be a whole number (e.g. 0, 3).", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        If damage <> "" Then
            Dim dummy As Decimal
            If Not Decimal.TryParse(damage, dummy) OrElse dummy < 0 Then
                MessageBox.Show("Damage Estimate must be a number (e.g. 50000).", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        Try
            Dim record As New RecordModel() With {
                .RecordID          = txtIncidentNo.Text.Trim(),
                .IncidentType      = cboIncidentType.SelectedItem?.ToString(),
                .IncidentDateTime  = dtpIncidentDateTime.Value,
                .InvolvedProperty  = txtInvolvedProperty.Text.Trim(),
                .Address           = txtAddress.Text.Trim(),
                .OwnerOccupant     = txtOwnerOccupant.Text.Trim(),
                .CallerInformation = txtCallerInformation.Text.Trim(),
                .AlarmLevel        = cboAlarmLevel.SelectedItem?.ToString(),
                .ResponseTime      = If(dtpResponseTime.Checked, dtpResponseTime.Value.TimeOfDay, CType(Nothing, TimeSpan?)),
                .CauseOfFire       = txtCauseOfFire.Text.Trim(),
                .Casualties        = txtCasualties.Text.Trim(),
                .DamageEstimate    = txtDamageEstimate.Text.Trim(),
                .Remarks           = txtRemarks.Text.Trim(),
                .Status            = cboStatus.SelectedItem?.ToString(),
                .DocumentPath      = DocumentStorage.SaveDocument(_documentPath, txtIncidentNo.Text.Trim())
            }

            RecordService.Instance.AddRecord(record)
            ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess,
                               "Added incident record: " & record.RecordID)

            MessageBox.Show("Record saved successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnClear_Click(Nothing, Nothing)

        Catch ex As Exception
            MessageBox.Show("Failed to save record: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInvolvedProperty.Clear()
        txtAddress.Clear()
        txtOwnerOccupant.Clear()
        txtCallerInformation.Clear()
        txtCauseOfFire.Clear()
        txtCasualties.Clear()
        txtDamageEstimate.Clear()
        txtRemarks.Clear()
        txtDocumentName.Clear()
        _documentPath = ""
        cboIncidentType.SelectedIndex = 0
        cboStatus.SelectedIndex = 0
        cboAlarmLevel.SelectedIndex = 0
        dtpIncidentDateTime.Value = DateTime.Now
        dtpResponseTime.Checked = False
        Try
            txtIncidentNo.Text = RecordService.Instance.GetNextID()
        Catch
            txtIncidentNo.Clear()
        End Try
    End Sub

End Class
