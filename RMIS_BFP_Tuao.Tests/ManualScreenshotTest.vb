Imports System.IO
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports RMIS_BFP_Tuao

<TestClass>
Public Class ManualScreenshotTest

    <TestMethod>
    Public Sub VerifyManualScreenshotsExist()
        For i As Integer = 1 To 6
            Dim p = ManualScreenshotGenerator.GetScreenshotPath(i)
            Assert.IsTrue(File.Exists(p), "Screenshot file for topic " & i & " must exist: " & p)
        Next
    End Sub

End Class
