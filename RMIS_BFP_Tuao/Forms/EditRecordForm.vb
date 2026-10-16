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
        txtCasualties.Text        = NumberHelper.FormatCasualties(_record.Casualties)
        txtDamageEstimate.Text    = NumberHelper.FormatDamageNumber(_record.DamageEstimate)
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
        Dim damage = txtDamageEstimate.Text.Replace(",", "").Trim()
        Dim casualtiesVal As Long = 0
        Dim damageVal As Long = 0

        If Not NumberHelper.IsValidInteger(casualties, casualtiesVal) Then
            MessageBox.Show("Casualties must be a whole integer number (e.g. 0, 3).", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCasualties.Focus()
            Exit Sub
        End If

        If Not NumberHelper.IsValidInteger(damage, damageVal) Then
            MessageBox.Show("Estimated Damage must be a whole integer amount in PHP (e.g. 500000). Decimals and special characters are not allowed.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDamageEstimate.Focus()
            Exit Sub
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
            _record.Casualties        = casualtiesVal.ToString()
            _record.DamageEstimate    = damageVal.ToString()
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

    Private Sub NumericOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCasualties.KeyPress, txtDamageEstimate.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class
