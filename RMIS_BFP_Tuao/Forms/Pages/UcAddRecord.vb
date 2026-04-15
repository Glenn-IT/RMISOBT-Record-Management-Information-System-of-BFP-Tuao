Public Class UcAddRecord
    Inherits UserControl

    Private Sub UcAddRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDateReported.Value = DateTime.Now
        cboIncidentType.Items.AddRange({"Structure Fire", "Vehicular Fire", "Grass Fire",
                                        "Industrial Fire", "Electrical Fire", "Other"})
        cboStatus.Items.AddRange({"Active", "Resolved", "Under Investigation", "Closed"})
        cboIncidentType.SelectedIndex = 0
        cboStatus.SelectedIndex = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtIncidentNo.Text.Trim() = "" OrElse
           txtLocation.Text.Trim() = "" OrElse
           txtReportedBy.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all required fields marked with *.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim record As New RecordModel() With {
            .RecordID = If(txtIncidentNo.Text.Trim() = "",
                           RecordService.Instance.GetNextID(),
                           txtIncidentNo.Text.Trim()),
            .IncidentType = cboIncidentType.SelectedItem?.ToString(),
            .DateReported = dtpDateReported.Value,
            .Location = txtLocation.Text.Trim(),
            .ReportedBy = txtReportedBy.Text.Trim(),
            .Casualties = txtCasualties.Text.Trim(),
            .DamageEstimate = txtDamageEstimate.Text.Trim(),
            .Remarks = txtRemarks.Text.Trim(),
            .Status = cboStatus.SelectedItem?.ToString()
        }

        RecordService.Instance.AddRecord(record)
        MessageBox.Show("Record saved successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnClear_Click(Nothing, Nothing)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtIncidentNo.Clear()
        txtLocation.Clear()
        txtReportedBy.Clear()
        txtCasualties.Clear()
        txtDamageEstimate.Clear()
        txtRemarks.Clear()
        cboIncidentType.SelectedIndex = 0
        cboStatus.SelectedIndex = 0
        dtpDateReported.Value = DateTime.Now
    End Sub

End Class
