Public Class SignatoryItem
    Public Property KeyPrefix As String = ""
    Public Property Label As String = ""
    Public Property Name As String = ""
    Public Property Title As String = ""
    Public Property Enabled As Boolean = True
End Class

Public Module SignatoryHelper

    Public Function GetSignatories() As List(Of SignatoryItem)
        Dim list As New List(Of SignatoryItem)()

        ' Signatory 1: Prepared by
        Dim s1 As New SignatoryItem() With {
            .KeyPrefix = "Signatory1",
            .Label = GetSettingSafe("Signatory1_Label", "Prepared by:"),
            .Name = GetSettingSafe("Signatory1_Name", "FO3 Juan Dela Cruz, BFP"),
            .Title = GetSettingSafe("Signatory1_Title", "Duty Desk Officer / Fire Investigator"),
            .Enabled = True
        }
        list.Add(s1)

        ' Signatory 2: Noted by
        Dim s2 As New SignatoryItem() With {
            .KeyPrefix = "Signatory2",
            .Label = GetSettingSafe("Signatory2_Label", "Noted by:"),
            .Name = GetSettingSafe("Signatory2_Name", "CINSP Pedro Penduko, BFP"),
            .Title = GetSettingSafe("Signatory2_Title", "Municipal Fire Marshal"),
            .Enabled = True
        }
        list.Add(s2)

        ' Signatory 3: Optional Approved by / Additional
        Dim s3EnabledStr = GetSettingSafe("Signatory3_Enabled", "False")
        Dim s3 As New SignatoryItem() With {
            .KeyPrefix = "Signatory3",
            .Label = GetSettingSafe("Signatory3_Label", "Approved by:"),
            .Name = GetSettingSafe("Signatory3_Name", ""),
            .Title = GetSettingSafe("Signatory3_Title", ""),
            .Enabled = s3EnabledStr.Equals("True", StringComparison.OrdinalIgnoreCase)
        }
        list.Add(s3)

        Return list
    End Function

    Private Function GetSettingSafe(key As String, defaultVal As String) As String
        Try
            Return SettingsRepository.GetValue(key, defaultVal)
        Catch
            Return defaultVal
        End Try
    End Function

    Public Sub SaveSignatories(sigs As List(Of SignatoryItem))
        If sigs Is Nothing Then Return
        For Each s In sigs
            If Not String.IsNullOrEmpty(s.KeyPrefix) Then
                SettingsRepository.SetValue(s.KeyPrefix & "_Label", s.Label)
                SettingsRepository.SetValue(s.KeyPrefix & "_Name", s.Name)
                SettingsRepository.SetValue(s.KeyPrefix & "_Title", s.Title)
                SettingsRepository.SetValue(s.KeyPrefix & "_Enabled", If(s.Enabled, "True", "False"))
            End If
        Next
    End Sub

End Module
