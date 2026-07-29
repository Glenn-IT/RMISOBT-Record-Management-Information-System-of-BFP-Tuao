Imports System.IO

Public Module BannerHelper

    Private ReadOnly BannerFolder As String =
        Path.Combine(Environment.CurrentDirectory, "Assets", "Banner")

    ''' Reads an image file into memory before decoding it, so the PictureBox
    ''' never keeps a lock on the source file (Image.FromFile does, which is
    ''' why replacing/reloading a banner from the same path can silently fail
    ''' or keep showing the old image). The decoded Image is cloned into a new
    ''' Bitmap before the MemoryStream is disposed — Image.FromStream decodes
    ''' lazily and keeps a reference to the stream, so returning it directly
    ''' from inside the Using block left the image backed by a disposed
    ''' stream, which is why the preview never rendered.
    Public Function LoadImage(path As String) As Image
        Dim bytes = File.ReadAllBytes(path)
        Using ms As New MemoryStream(bytes)
            Using temp = Image.FromStream(ms)
                Return New Bitmap(temp)
            End Using
        End Using
    End Function

    Public Function GetCurrentBannerPath() As String
        Dim path = SettingsRepository.GetValue("BannerImagePath", "")
        If path = "" OrElse Not File.Exists(path) Then Return ""
        Return path
    End Function

    Public Function GetCurrentBanner() As Image
        Dim path = GetCurrentBannerPath()
        If path = "" Then Return Nothing
        Return LoadImage(path)
    End Function

    ''' Copies the source file into a persistent app folder and records it as
    ''' the current banner, so the setting survives even if the original file
    ''' the user picked is later moved or deleted.
    Public Function SaveBanner(sourceFilePath As String) As String
        Directory.CreateDirectory(BannerFolder)

        For Each oldFile In Directory.GetFiles(BannerFolder, "banner_current.*")
            File.Delete(oldFile)
        Next

        Dim ext = Path.GetExtension(sourceFilePath)
        Dim destPath = Path.Combine(BannerFolder, "banner_current" & ext)

        File.Copy(sourceFilePath, destPath, overwrite:=True)
        SettingsRepository.SetValue("BannerImagePath", destPath)
        Return destPath
    End Function

End Module
