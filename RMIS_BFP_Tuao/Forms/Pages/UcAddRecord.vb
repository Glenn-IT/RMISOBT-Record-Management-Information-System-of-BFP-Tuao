Public Class UcAddRecord
    Inherits UserControl

    Private Sub UcAddRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDateReported.Value = DateTime.Now
        cboIncidentType.Items.AddRange(Constants.IncidentTypes)
        cboStatus.Items.AddRange(Constants.Statuses)
        cboIncidentType.SelectedIndex = 0
        cboStatus.SelectedIndex = 0
        Try
            txtIncidentNo.Text = RecordService.Instance.GetNextID()
        Catch
            ' Leave blank if DB not yet available; user can type manually
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtLocation.Text.Trim() = "" OrElse
           txtReportedBy.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all required fields marked with *.", "Validation",
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
                .RecordID       = txtIncidentNo.Text.Trim(),
                .IncidentType   = cboIncidentType.SelectedItem?.ToString(),
                .DateReported   = dtpDateReported.Value,
                .Location       = txtLocation.Text.Trim(),
                .ReportedBy     = txtReportedBy.Text.Trim(),
                .Casualties     = txtCasualties.Text.Trim(),
                .DamageEstimate = txtDamageEstimate.Text.Trim(),
                .Remarks        = txtRemarks.Text.Trim(),
                .Status         = cboStatus.SelectedItem?.ToString()
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
        txtLocation.Clear()
        txtReportedBy.Clear()
        txtCasualties.Clear()
        txtDamageEstimate.Clear()
        txtRemarks.Clear()
        cboIncidentType.SelectedIndex = 0
        cboStatus.SelectedIndex = 0
        dtpDateReported.Value = DateTime.Now
        Try
            txtIncidentNo.Text = RecordService.Instance.GetNextID()
        Catch
            txtIncidentNo.Clear()
        End Try
    End Sub

End Class
