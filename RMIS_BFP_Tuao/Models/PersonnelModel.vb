Public Class PersonnelModel

    Public Property PersonnelID As String
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Rank As String
    Public Property Position As String
    Public Property ContactNumber As String
    Public Property Email As String
    Public Property IsActive As Boolean

    Public ReadOnly Property FullName As String
        Get
            Return FirstName & " " & LastName
        End Get
    End Property

End Class
