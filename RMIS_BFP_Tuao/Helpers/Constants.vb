Public Module Constants

    Public ReadOnly IncidentTypes As String() = {
        "Structure Fire", "Vehicular Fire", "Grass Fire",
        "Industrial Fire", "Electrical Fire", "Other"}

    Public ReadOnly Statuses As String() = {
        "Active", "Resolved", "Under Investigation", "Closed"}

    Public ReadOnly AlarmLevels As String() = {
        "1st Alarm", "2nd Alarm", "3rd Alarm", "4th Alarm", "5th Alarm", "General Alarm"}

    Public Const UserTypeSuperAdmin As String = "Super Admin"
    Public Const UserTypeSubAdmin As String = "Sub Admin"

    ' Backward compatibility aliases
    Public Const UserTypeAdmin As String = "Admin"
    Public Const UserTypeStaff As String = "Staff"

    ' System roles: Staff removed, only Super Admin and Sub Admin
    Public ReadOnly Roles As String() = {UserTypeSuperAdmin, UserTypeSubAdmin}

    Public Const LogSuccess As String = "Success"
    Public Const LogFailed As String = "Failed"

End Module
