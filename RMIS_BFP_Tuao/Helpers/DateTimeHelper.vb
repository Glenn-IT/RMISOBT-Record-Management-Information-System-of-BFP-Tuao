Public Module DateTimeHelper

    Public Function FormatIncidentDateTime(dt As DateTime) As String
        Return $"{dt:MM/dd/yyyy hh:mm tt} ({dt:HH:mm}H)"
    End Function

    Public Function FormatResponseTime(time As TimeSpan) As String
        Dim dummyDate As New DateTime(2000, 1, 1, time.Hours, time.Minutes, time.Seconds)
        Return $"{dummyDate:hh:mm tt} ({time.Hours:D2}:{time.Minutes:D2}H)"
    End Function

    Public Function FormatResponseTime(time As TimeSpan?) As String
        If Not time.HasValue Then Return "Not recorded"
        Return FormatResponseTime(time.Value)
    End Function

    Public Function ToMilitaryTime(dt As DateTime) As String
        Return $"{dt:hh:mm tt} ({dt:HH:mm}H)"
    End Function

    Public Function ToMilitaryTime(time As TimeSpan) As String
        Dim dummyDate As New DateTime(2000, 1, 1, time.Hours, time.Minutes, time.Seconds)
        Return $"{dummyDate:hh:mm tt} ({time.Hours:D2}:{time.Minutes:D2}H)"
    End Function

End Module
