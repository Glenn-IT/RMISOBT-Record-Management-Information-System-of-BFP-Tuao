Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.IO

<TestClass>
Public Class ReportPrinterTests

    <TestMethod>
    Public Sub GeneratePdf_ValidRecords_CreatesNonEmptyPdfFile()
        Dim records As New List(Of RecordModel) From {
            New RecordModel With {
                .RecordID = "INC-2026-001",
                .IncidentType = "Structure Fire",
                .Status = "Active"
            },
            New RecordModel With {
                .RecordID = "INC-2026-002",
                .IncidentType = "Vehicular Fire",
                .Status = "Resolved"
            }
        }

        Dim pdfPath = ReportPrinter.GeneratePdf(records, "BFP Tuao Fire Station", "TestAdmin")

        Assert.IsNotNull(pdfPath, "PDF path should not be null.")
        Assert.IsTrue(File.Exists(pdfPath), $"PDF file should exist at {pdfPath}.")

        Dim fileInfo As New FileInfo(pdfPath)
        Assert.IsTrue(fileInfo.Length > 1000, "PDF file size should be greater than 1KB.")

        ' Cleanup test output
        Try
            File.Delete(pdfPath)
        Catch
        End Try
    End Sub

    <TestMethod>
    Public Sub GeneratePdf_EmptyRecords_CreatesValidPdfFile()
        Dim records As New List(Of RecordModel)()

        Dim pdfPath = ReportPrinter.GeneratePdf(records, "BFP Tuao Fire Station", "TestAdmin")

        Assert.IsNotNull(pdfPath)
        Assert.IsTrue(File.Exists(pdfPath))

        Dim fileInfo As New FileInfo(pdfPath)
        Assert.IsTrue(fileInfo.Length > 1000)

        Try
            File.Delete(pdfPath)
        Catch
        End Try
    End Sub

End Class
