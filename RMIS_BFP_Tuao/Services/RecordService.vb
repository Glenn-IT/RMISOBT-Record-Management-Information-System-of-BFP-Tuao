''' <summary>
''' In-memory data service for fire incident records (prototype).
''' </summary>
Public Class RecordService

    ' Singleton instance
    Private Shared _instance As RecordService
    Public Shared ReadOnly Property Instance As RecordService
        Get
            If _instance Is Nothing Then _instance = New RecordService()
            Return _instance
        End Get
    End Property

    ' In-memory store
    Private _records As New List(Of RecordModel)()

    Private Sub New()
        LoadSampleData()
    End Sub

    ' ?? Seed sample data ?????????????????????????????????????????
    Private Sub LoadSampleData()
        _records.Add(New RecordModel() With {
            .RecordID = "INC-2025-001", .IncidentType = "Structure Fire",
            .DateReported = New DateTime(2025, 1, 5), .Location = "Brgy. Centro, Tuao",
            .ReportedBy = "Admin", .Casualties = "0", .DamageEstimate = "500,000",
            .Remarks = "Fully extinguished.", .Status = "Resolved"})

        _records.Add(New RecordModel() With {
            .RecordID = "INC-2025-002", .IncidentType = "Vehicular Fire",
            .DateReported = New DateTime(2025, 1, 18), .Location = "Maharlika Highway, Tuao",
            .ReportedBy = "Admin", .Casualties = "0", .DamageEstimate = "120,000",
            .Remarks = "", .Status = "Resolved"})

        _records.Add(New RecordModel() With {
            .RecordID = "INC-2025-003", .IncidentType = "Grass Fire",
            .DateReported = New DateTime(2025, 2, 3), .Location = "Brgy. Malalatan, Tuao",
            .ReportedBy = "Admin", .Casualties = "0", .DamageEstimate = "20,000",
            .Remarks = "Ongoing monitoring.", .Status = "Active"})

        _records.Add(New RecordModel() With {
            .RecordID = "INC-2025-004", .IncidentType = "Electrical Fire",
            .DateReported = New DateTime(2025, 2, 14), .Location = "Brgy. Carilucud, Tuao",
            .ReportedBy = "Admin", .Casualties = "1", .DamageEstimate = "250,000",
            .Remarks = "Under probe.", .Status = "Under Investigation"})

        _records.Add(New RecordModel() With {
            .RecordID = "INC-2025-005", .IncidentType = "Structure Fire",
            .DateReported = New DateTime(2025, 3, 1), .Location = "Brgy. Batu, Tuao",
            .ReportedBy = "Admin", .Casualties = "0", .DamageEstimate = "180,000",
            .Remarks = "", .Status = "Active"})

        _records.Add(New RecordModel() With {
            .RecordID = "INC-2025-006", .IncidentType = "Industrial Fire",
            .DateReported = New DateTime(2025, 3, 22), .Location = "National Road, Tuao",
            .ReportedBy = "Admin", .Casualties = "0", .DamageEstimate = "900,000",
            .Remarks = "Case closed.", .Status = "Closed"})

        _records.Add(New RecordModel() With {
            .RecordID = "INC-2025-007", .IncidentType = "Grass Fire",
            .DateReported = New DateTime(2025, 4, 7), .Location = "Brgy. Fugu, Tuao",
            .ReportedBy = "Admin", .Casualties = "0", .DamageEstimate = "15,000",
            .Remarks = "", .Status = "Resolved"})

        _records.Add(New RecordModel() With {
            .RecordID = "INC-2025-008", .IncidentType = "Structure Fire",
            .DateReported = New DateTime(2025, 4, 19), .Location = "Brgy. Lallayug, Tuao",
            .ReportedBy = "Admin", .Casualties = "2", .DamageEstimate = "750,000",
            .Remarks = "", .Status = "Active"})
    End Sub

    ' ?? CRUD Methods ?????????????????????????????????????????????

    Public Function GetRecords() As List(Of RecordModel)
        Return New List(Of RecordModel)(_records)
    End Function

    Public Sub AddRecord(record As RecordModel)
        _records.Add(record)
    End Sub

    Public Sub UpdateRecord(updatedRecord As RecordModel)
        Dim index = _records.FindIndex(Function(r) r.RecordID = updatedRecord.RecordID)
        If index >= 0 Then
            _records(index) = updatedRecord
        End If
    End Sub

    Public Sub DeleteRecord(recordID As String)
        _records.RemoveAll(Function(r) r.RecordID = recordID)
    End Sub

    Public Function GetNextID() As String
        Dim year = DateTime.Now.Year
        Dim count = _records.Count + 1
        Return $"INC-{year}-{count:D3}"
    End Function

End Class
