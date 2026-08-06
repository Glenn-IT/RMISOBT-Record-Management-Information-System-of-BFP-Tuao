Public Class EditRecordForm

    Private _record As RecordModel
    Private _newDocumentPath As String = ""

    Public Sub New(record As RecordModel)
        InitializeComponent()
        _record = record
    End Sub

    Private Sub EditRecordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboIncidentType.Items.AddRange(Constants.IncidentTypes)
        cboStatus.Items.AddRange(Constants.Statuses)
        cboAlarmLevel.Items.AddRange(Constants.AlarmLevels)

        txtRecordID.Text          = _record.RecordID
        cboIncidentType.Text      = _record.IncidentType
        dtpIncidentDateTime.Value = _record.IncidentDateTime
        txtInvolvedProperty.Text  = _record.InvolvedProperty
        txtAddress.Text           = _record.Address
        txtOwnerOccupant.Text     = _record.OwnerOccupant
        txtCallerInformation.Text = _record.CallerInformation
        cboAlarmLevel.Text        = _record.AlarmLevel
        txtCasualties.Text        = _record.Casualties
        txtDamageEstimate.Text    = _record.DamageEstimate
        txtCauseOfFire.Text       = _record.CauseOfFire
        txtRemarks.Text           = _record.Remarks
        cboStatus.Text            = _record.Status

        dtpResponseTime.Checked = _record.ResponseTime.HasValue
        If _record.ResponseTime.HasValue Then
            dtpResponseTime.Value = DateTime.Today.Add(_record.ResponseTime.Value)
        End If

        If Not String.IsNullOrEmpty(_record.DocumentPath) Then
            txtDocumentName.Text = IO.Path.GetFileName(_record.DocumentPath)
        End If
    End Sub

    Private Sub btnBrowseDocument_Click(sender As Object, e As EventArgs) Handles btnBrowseDocument.Click
        Using dlg As New OpenFileDialog()
            dlg.Filter = "Documents|*.pdf;*.doc;*.docx;*.jpg;*.jpeg;*.png"
            If dlg.ShowDialog() = DialogResult.OK Then
                _newDocumentPath = dlg.FileName
                txtDocumentName.Text = IO.Path.GetFileName(_newDocumentPath)
            End If
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtInvolvedProperty.Text.Trim() = "" OrElse txtAddress.Text.Trim() = "" OrElse txtCallerInformation.Text.Trim() = "" Then
            MessageBox.Show("Involved Property, Address, and Caller Information are required.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If _newDocumentPath = "" AndAlso String.IsNullOrEmpty(_record.DocumentPath) Then
            MessageBox.Show("You must upload a document.", "Validation",
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
            _record.IncidentType      = cboIncidentType.SelectedItem?.ToString()
            _record.IncidentDateTime  = dtpIncidentDateTime.Value
            _record.InvolvedProperty  = txtInvolvedProperty.Text.Trim()
            _record.Address           = txtAddress.Text.Trim()
            _record.OwnerOccupant     = txtOwnerOccupant.Text.Trim()
            _record.CallerInformation = txtCallerInformation.Text.Trim()
            _record.AlarmLevel        = cboAlarmLevel.SelectedItem?.ToString()
            _record.ResponseTime      = If(dtpResponseTime.Checked, dtpResponseTime.Value.TimeOfDay, CType(Nothing, TimeSpan?))
            _record.CauseOfFire       = txtCauseOfFire.Text.Trim()
            _record.Casualties        = txtCasualties.Text.Trim()
            _record.DamageEstimate    = txtDamageEstimate.Text.Trim()
            _record.Remarks           = txtRemarks.Text.Trim()
            _record.Status            = cboStatus.SelectedItem?.ToString()

            If _newDocumentPath <> "" Then
                _record.DocumentPath = DocumentStorage.SaveDocument(_newDocumentPath, _record.RecordID)
            End If

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
