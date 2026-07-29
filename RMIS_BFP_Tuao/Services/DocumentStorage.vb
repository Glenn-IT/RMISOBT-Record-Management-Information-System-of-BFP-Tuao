Imports System.IO

Public Module DocumentStorage

    Private ReadOnly DocumentsFolder As String =
        Path.Combine(Environment.CurrentDirectory, "Documents")

    ''' Copies the source file into a persistent app folder named after the
    ''' record, so the stored path stays valid even if the user's original
    ''' file is later moved or deleted. Returns the stored path.
    Public Function SaveDocument(sourceFilePath As String, recordID As String) As String
        Directory.CreateDirectory(DocumentsFolder)

        Dim fileName = recordID & "_" & Path.GetFileName(sourceFilePath)
        Dim destPath = Path.Combine(DocumentsFolder, fileName)

        File.Copy(sourceFilePath, destPath, overwrite:=True)
        Return destPath
    End Function

End Module
