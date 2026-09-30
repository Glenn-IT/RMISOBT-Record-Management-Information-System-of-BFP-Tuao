Imports System.IO
Imports PdfSharp.Fonts

Public Class WindowsFontResolver
    Implements IFontResolver

    Private Shared _isRegistered As Boolean = False
    Private Shared ReadOnly _syncLock As New Object()
    Private Shared ReadOnly FontsDir As String = Environment.GetFolderPath(Environment.SpecialFolder.Fonts)

    Public Shared Sub EnsureRegistered()
        If Not _isRegistered Then
            SyncLock _syncLock
                If Not _isRegistered Then
                    GlobalFontSettings.FontResolver = New WindowsFontResolver()
                    _isRegistered = True
                End If
            End SyncLock
        End If
    End Sub

    Public Function ResolveTypeface(familyName As String, isBold As Boolean, isItalic As Boolean) As FontResolverInfo Implements IFontResolver.ResolveTypeface
        Dim styleSuffix = ""
        If isBold AndAlso isItalic Then
            styleSuffix = "#bi"
        ElseIf isBold Then
            styleSuffix = "#b"
        ElseIf isItalic Then
            styleSuffix = "#i"
        End If

        Dim cleanFamily = If(String.IsNullOrWhiteSpace(familyName), "Arial", familyName.Trim())

        Select Case cleanFamily.ToLowerInvariant()
            Case "segoe ui", "segoe"
                Return New FontResolverInfo("SegoeUI" & styleSuffix)
            Case "times new roman", "times"
                Return New FontResolverInfo("Times" & styleSuffix)
            Case "calibri"
                Return New FontResolverInfo("Calibri" & styleSuffix)
            Case Else
                Return New FontResolverInfo("Arial" & styleSuffix)
        End Select
    End Function

    Public Function GetFont(faceName As String) As Byte() Implements IFontResolver.GetFont
        Dim isBold = faceName.Contains("#b") OrElse faceName.Contains("#bi")
        Dim isItalic = faceName.Contains("#i") OrElse faceName.Contains("#bi")
        Dim baseFace = faceName.Split("#"c)(0)

        Dim candidates As New List(Of String)()

        Select Case baseFace.ToLowerInvariant()
            Case "segoeui"
                If isBold AndAlso isItalic Then candidates.Add("segoeuiz.ttf")
                If isBold Then candidates.Add("segoeuib.ttf")
                If isItalic Then candidates.Add("segoeuii.ttf")
                candidates.Add("segoeui.ttf")

            Case "times"
                If isBold AndAlso isItalic Then candidates.Add("timesbi.ttf")
                If isBold Then candidates.Add("timesbd.ttf")
                If isItalic Then candidates.Add("timesi.ttf")
                candidates.Add("times.ttf")

            Case "calibri"
                If isBold AndAlso isItalic Then candidates.Add("calibriz.ttf")
                If isBold Then candidates.Add("calibrib.ttf")
                If isItalic Then candidates.Add("calibrii.ttf")
                candidates.Add("calibri.ttf")

            Case Else
                If isBold AndAlso isItalic Then candidates.Add("arialbi.ttf")
                If isBold Then candidates.Add("arialbd.ttf")
                If isItalic Then candidates.Add("ariali.ttf")
                candidates.Add("arial.ttf")
        End Select

        candidates.Add("arial.ttf")

        For Each fileName In candidates
            Dim fullPath = Path.Combine(FontsDir, fileName)
            If File.Exists(fullPath) Then
                Return File.ReadAllBytes(fullPath)
            End If
        Next

        Throw New FileNotFoundException("Could not find font data for " & faceName)
    End Function

End Class
