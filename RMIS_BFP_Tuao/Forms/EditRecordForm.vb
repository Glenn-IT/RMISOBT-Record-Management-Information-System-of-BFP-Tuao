Public Class EditRecordForm

    Private _record As RecordModel

    Public Sub New(record As RecordModel)
        InitializeComponent()
        _record = record
    End Sub

    Private Sub EditRecordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboIncidentType.Items.AddRange(Constants.IncidentTypes)
        cboStatus.Items.AddRange(Constants.Statuses)

        txtRecordID.Text       = _record.RecordID
        cboIncidentType.Text   = _record.IncidentType
        dtpDateReported.Value  = _record.DateReported
        txtLocation.Text       = _record.Location
        txtReportedBy.Text     = _record.ReportedBy
        txtCasualties.Text     = _record.Casualties
        txtDamageEstimate.Text = _record.DamageEstimate
        txtRemarks.Text        = _record.Remarks
        cboStatus.Text         = _record.Status
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtLocation.Text.Trim() = "" OrElse txtReportedBy.Text.Trim() = "" Then
            MessageBox.Show("Location and Reported By are required.", "Validation",
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
            _record.IncidentType   = cboIncidentType.SelectedItem?.ToString()
            _record.DateReported   = dtpDateReported.Value
            _record.Location       = txtLocation.Text.Trim()
            _record.ReportedBy     = txtReportedBy.Text.Trim()
            _record.Casualties     = txtCasualties.Text.Trim()
            _record.DamageEstimate = txtDamageEstimate.Text.Trim()
            _record.Remarks        = txtRemarks.Text.Trim()
            _record.Status         = cboStatus.SelectedItem?.ToString()

            RecordService.Instance.UpdateRecord(_record)
            ActivityLogger.Log(SessionManager.Username, Constants.LogSuccess,
                               "Updated incident record: " & _record.RecordID)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Failed to save changes: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
