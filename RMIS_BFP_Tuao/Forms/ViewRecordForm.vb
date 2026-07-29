Imports System.Diagnostics

Public Class ViewRecordForm

    Private _record As RecordModel

    Public Sub New(record As RecordModel)
        InitializeComponent()
        _record = record
    End Sub

    Private Sub ViewRecordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRecordID.Text          = _record.RecordID
        txtIncidentType.Text      = _record.IncidentType
        txtIncidentDateTime.Text  = _record.IncidentDateTime.ToString("MM/dd/yyyy") & " " & DateTimeHelper.ToMilitaryTime(_record.IncidentDateTime)
        txtAlarmLevel.Text        = _record.AlarmLevel
        txtResponseTime.Text      = If(_record.ResponseTime.HasValue, DateTimeHelper.ToMilitaryTime(_record.ResponseTime.Value), "Not recorded")
        txtStatus.Text            = _record.Status
        txtInvolvedProperty.Text  = _record.InvolvedProperty
        txtOwnerOccupant.Text     = _record.OwnerOccupant
        txtCallerInformation.Text = _record.CallerInformation
        txtCasualties.Text        = _record.Casualties
        txtDamageEstimate.Text    = _record.DamageEstimate
        txtCauseOfFire.Text       = _record.CauseOfFire
        txtRemarks.Text           = _record.Remarks
        txtDocumentName.Text      = If(String.IsNullOrEmpty(_record.DocumentPath), "No document attached.", IO.Path.GetFileName(_record.DocumentPath))
        btnOpenDocument.Enabled   = Not String.IsNullOrEmpty(_record.DocumentPath)
    End Sub

    Private Sub btnOpenDocument_Click(sender As Object, e As EventArgs) Handles btnOpenDocument.Click
        If String.IsNullOrEmpty(_record.DocumentPath) OrElse Not IO.File.Exists(_record.DocumentPath) Then
            MessageBox.Show("The attached document could not be found.", "Document Unavailable",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            Process.Start(New ProcessStartInfo(_record.DocumentPath) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Failed to open document: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
