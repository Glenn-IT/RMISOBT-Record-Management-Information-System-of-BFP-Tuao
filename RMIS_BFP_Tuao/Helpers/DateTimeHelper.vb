Public Module DateTimeHelper

    Public Function ToMilitaryTime(dt As DateTime) As String
        Return dt.ToString("HHmm") & "H"
    End Function

    Public Function ToMilitaryTime(time As TimeSpan) As String
        Return $"{time.Hours:D2}{time.Minutes:D2}H"
    End Function

End Module
