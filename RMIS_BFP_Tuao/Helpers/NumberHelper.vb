Public Module NumberHelper

    ''' <summary>
    ''' Formats a casualties count as a whole integer string (e.g. "0", "3").
    ''' </summary>
    Public Function FormatCasualties(val As String) As String
        If String.IsNullOrWhiteSpace(val) Then Return "0"
        Dim clean = val.Replace(",", "").Trim()
        Dim num As Long
        If Long.TryParse(clean, num) Then
            Return num.ToString("N0")
        End If
        Return val
    End Function

    ''' <summary>
    ''' Formats estimated damage as a Philippine Peso integer string with comma separators (e.g. "₱ 500,000").
    ''' </summary>
    Public Function FormatDamage(val As String) As String
        If String.IsNullOrWhiteSpace(val) Then Return "₱ 0"
        Dim clean = val.Replace(",", "").Replace("₱", "").Replace("PHP", "").Trim()
        Dim num As Long
        If Long.TryParse(clean, num) Then
            Return $"₱ {num:N0}"
        End If
        Return $"₱ {val}"
    End Function

    ''' <summary>
    ''' Formats estimated damage as a plain integer string with thousand separators (e.g. "500,000").
    ''' </summary>
    Public Function FormatDamageNumber(val As String) As String
        If String.IsNullOrWhiteSpace(val) Then Return "0"
        Dim clean = val.Replace(",", "").Replace("₱", "").Replace("PHP", "").Trim()
        Dim num As Long
        If Long.TryParse(clean, num) Then
            Return num.ToString("N0")
        End If
        Return val
    End Function

    ''' <summary>
    ''' Validates that the input text is strictly a non-negative whole integer (no decimals, no negatives, no letters).
    ''' </summary>
    Public Function IsValidInteger(text As String, ByRef outVal As Long) As Boolean
        If String.IsNullOrWhiteSpace(text) Then
            outVal = 0
            Return True
        End If
        Dim clean = text.Replace(",", "").Trim()
        If clean.Contains("."c) OrElse clean.Contains("-"c) Then
            outVal = 0
            Return False
        End If
        Return Long.TryParse(clean, outVal) AndAlso outVal >= 0
    End Function

End Module
