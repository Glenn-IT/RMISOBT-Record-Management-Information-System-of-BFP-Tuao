Public Class RecordService

    Private Shared _instance As RecordService
    Public Shared ReadOnly Property Instance As RecordService
        Get
            If _instance Is Nothing Then _instance = New RecordService()
            Return _instance
        End Get
    End Property

    Private Sub New()
    End Sub

    Public Function GetRecords() As List(Of RecordModel)
        Return IncidentRepository.GetAll()
    End Function

    Public Sub AddRecord(record As RecordModel)
        IncidentRepository.Insert(record)
    End Sub

    Public Sub UpdateRecord(updatedRecord As RecordModel)
        IncidentRepository.Update(updatedRecord)
    End Sub

    Public Sub DeleteRecord(recordID As String)
        IncidentRepository.Delete(recordID)
    End Sub

    Public Function GetNextID() As String
        Return IncidentRepository.GetNextID()
    End Function

End Class
