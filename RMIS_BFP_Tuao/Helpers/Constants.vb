Public Module Constants

    Public ReadOnly IncidentTypes As String() = {
        "Structure Fire", "Vehicular Fire", "Grass Fire",
        "Industrial Fire", "Electrical Fire", "Other"}

    Public ReadOnly Statuses As String() = {
        "Active", "Resolved", "Under Investigation", "Closed"}

    Public Const UserTypeAdmin As String = "Admin"
    Public Const UserTypeStaff As String = "Staff"

    Public Const LogSuccess As String = "Success"
    Public Const LogFailed As String = "Failed"

End Module
