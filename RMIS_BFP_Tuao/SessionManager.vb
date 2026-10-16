Public Module SessionManager

    Public Username As String = ""
    Public UserType As String = ""
    Public UserCode As String = ""

    Public Function IsSuperAdmin() As Boolean
        Return String.Equals(UserType, Constants.UserTypeSuperAdmin, StringComparison.OrdinalIgnoreCase) OrElse
               String.Equals(UserType, "Admin", StringComparison.OrdinalIgnoreCase)
    End Function

    Public Function IsSubAdmin() As Boolean
        Return String.Equals(UserType, Constants.UserTypeSubAdmin, StringComparison.OrdinalIgnoreCase)
    End Function

    Public Sub Clear()
        Username = ""
        UserType = ""
        UserCode = ""
    End Sub

End Module
