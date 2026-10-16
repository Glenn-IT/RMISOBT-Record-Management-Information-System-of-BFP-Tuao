Imports System.IO
Imports System.Diagnostics
Imports Microsoft.Win32
Imports PdfSharp
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing

Public Module ReportPrinter

    ''' <summary>
    ''' Generates a PDF fire incident report and opens it directly in the web browser.
    ''' </summary>
    Public Sub PrintToPdfAndOpen(records As List(Of RecordModel), stationName As String, printedBy As String)
        Dim pdfPath = GeneratePdf(records, stationName, printedBy)
        OpenInWebBrowser(pdfPath)
    End Sub

    ''' <summary>
    ''' Backward-compatible preview method that opens the generated PDF report in the web browser.
    ''' </summary>
    Public Sub Preview(records As List(Of RecordModel), stationName As String, printedBy As String)
        PrintToPdfAndOpen(records, stationName, printedBy)
    End Sub

    ''' <summary>
    ''' Generates the PDF document and returns the path to the saved file.
    ''' </summary>
    Public Function GeneratePdf(records As List(Of RecordModel), stationName As String, printedBy As String) As String
        WindowsFontResolver.EnsureRegistered()

        Dim doc As New PdfDocument()
        doc.Info.Title = "RMIS Fire Incident Report"
        doc.Info.Author = If(String.IsNullOrWhiteSpace(printedBy), "RMIS System", printedBy)
        doc.Info.Subject = "Fire Incident Summary and Breakdown Report"

        Dim page = doc.AddPage()
        page.Size = PageSize.Letter
        page.Orientation = PageOrientation.Portrait

        Using gfx = XGraphics.FromPdfPage(page)
            DrawReportPage(gfx, page, records, stationName, printedBy)
        End Using

        Dim outputFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "RMIS_Reports")
        Try
            If Not Directory.Exists(outputFolder) Then
                Directory.CreateDirectory(outputFolder)
            End If
        Catch
            outputFolder = Path.GetTempPath()
        End Try

        Dim safeFileName = $"RMIS_Fire_Report_{DateTime.Now:yyyyMMdd_HHmmss}_{Guid.NewGuid().ToString("N").Substring(0, 6)}.pdf"
        Dim fullPath = Path.Combine(outputFolder, safeFileName)
        doc.Save(fullPath)
        Return fullPath
    End Function

    Private Sub DrawReportPage(gfx As XGraphics, page As PdfPage, records As List(Of RecordModel), stationName As String, printedBy As String)
        ' ── Margins & Bounds (Letter = 612 x 792 pt) ─────────────
        Dim leftMargin   = 40.0
        Dim rightMargin  = 572.0
        Dim contentWidth = rightMargin - leftMargin ' 532 pt
        Dim topMargin    = 40.0
        Dim footerY      = 746.0

        ' ── Fonts ────────────────────────────────────────────────
        Dim fStation    = New XFont("Segoe UI", 10, XFontStyleEx.Bold)
        Dim fTitle      = New XFont("Segoe UI", 18, XFontStyleEx.Bold)
        Dim fSub        = New XFont("Segoe UI", 8.5, XFontStyleEx.Regular)
        Dim fMeta       = New XFont("Segoe UI", 8, XFontStyleEx.Regular)
        Dim fSection    = New XFont("Segoe UI", 10, XFontStyleEx.Bold)
        Dim fColHdr     = New XFont("Segoe UI", 9, XFontStyleEx.Bold)
        Dim fCell       = New XFont("Segoe UI", 9, XFontStyleEx.Regular)
        Dim fTotals     = New XFont("Segoe UI", 9.5, XFontStyleEx.Bold)
        Dim fFooter     = New XFont("Segoe UI", 7.5, XFontStyleEx.Regular)
        Dim fFooterBold = New XFont("Segoe UI", 8, XFontStyleEx.Bold)
        Dim fCardNum    = New XFont("Segoe UI", 18, XFontStyleEx.Bold)
        Dim fCardLbl    = New XFont("Segoe UI", 8, XFontStyleEx.Regular)

        ' ── Brushes & Colors ─────────────────────────────────────
        Dim colRed     = XColor.FromArgb(180, 20, 20)
        Dim brRed      = New XSolidBrush(colRed)
        Dim brBlack    = New XSolidBrush(XColor.FromArgb(30, 30, 30))
        Dim brDarkGray = New XSolidBrush(XColor.FromArgb(80, 80, 80))
        Dim brGray     = New XSolidBrush(XColor.FromArgb(120, 120, 120))
        Dim brWhite    = XBrushes.White
        Dim brOrange   = New XSolidBrush(XColor.FromArgb(210, 100, 0))
        Dim brGreen    = New XSolidBrush(XColor.FromArgb(30, 130, 30))
        Dim brCardBg   = New XSolidBrush(XColor.FromArgb(248, 249, 250))
        Dim brAltRow   = New XSolidBrush(XColor.FromArgb(250, 251, 252))
        Dim brTotalBg  = New XSolidBrush(XColor.FromArgb(240, 242, 245))

        ' ── Pens ─────────────────────────────────────────────────
        Dim penRed        = New XPen(colRed, 1.5)
        Dim penLight      = New XPen(XColor.FromArgb(220, 220, 220), 0.75)
        Dim penCardBorder = New XPen(XColor.FromArgb(215, 215, 215), 0.75)

        ' ── String Formats ───────────────────────────────────────
        Dim sfLeft As New XStringFormat() With {
            .Alignment = XStringAlignment.Near,
            .LineAlignment = XLineAlignment.Center
        }
        Dim sfCenter As New XStringFormat() With {
            .Alignment = XStringAlignment.Center,
            .LineAlignment = XLineAlignment.Center
        }
        Dim sfRight As New XStringFormat() With {
            .Alignment = XStringAlignment.Far,
            .LineAlignment = XLineAlignment.Center
        }

        ' ════════════════════════════════════════════════════════
        ' HEADER (LOGO + TITLE + METADATA)
        ' ════════════════════════════════════════════════════════
        Dim logoPath = GetLogoPath()
        Dim logoW = 52.0
        Dim logoH = 52.0
        Dim logoX = leftMargin
        Dim logoY = topMargin
        Dim textX = leftMargin

        If Not String.IsNullOrEmpty(logoPath) AndAlso File.Exists(logoPath) Then
            Try
                Using img = XImage.FromFile(logoPath)
                    gfx.DrawImage(img, logoX, logoY, logoW, logoH)
                    textX = logoX + logoW + 14.0
                End Using
            Catch
                textX = leftMargin
            End Try
        End If

        Dim textWidth = rightMargin - textX
        Dim curY = topMargin

        Dim stName = If(String.IsNullOrWhiteSpace(stationName), "BFP TUAO FIRE STATION", stationName.Trim().ToUpper())
        gfx.DrawString(stName, fStation, brRed, New XRect(textX, curY, textWidth, 14), sfLeft)
        curY += 15.0

        gfx.DrawString("Fire Incident Report", fTitle, brBlack, New XRect(textX, curY, textWidth, 22), sfLeft)
        curY += 22.0

        gfx.DrawString("Bureau of Fire Protection • Tuao Fire Station", fSub, brDarkGray, New XRect(textX, curY, textWidth, 13), sfLeft)
        curY += 14.0

        Dim userDisplay = If(String.IsNullOrWhiteSpace(printedBy), "System", printedBy)
        Dim metaText = $"Date Generated: {DateTime.Now:MMMM dd, yyyy  hh:mm tt}    |    Generated by: {userDisplay}"
        gfx.DrawString(metaText, fMeta, brGray, New XRect(textX, curY, textWidth, 12), sfLeft)
        curY += 18.0

        If curY < (logoY + logoH + 10.0) Then
            curY = logoY + logoH + 10.0
        End If

        ' Red divider bar below header
        gfx.DrawLine(penRed, leftMargin, curY, rightMargin, curY)
        curY += 14.0

        ' ════════════════════════════════════════════════════════
        ' SUMMARY CARDS
        ' ════════════════════════════════════════════════════════
        Dim total    = If(records IsNot Nothing, records.Count, 0)
        Dim active   = If(records IsNot Nothing, records.Where(Function(r) r.Status = "Active").Count(), 0)
        Dim resolved = If(records IsNot Nothing, records.Where(Function(r) r.Status = "Resolved").Count(), 0)
        Dim closed   = If(records IsNot Nothing, records.Where(Function(r) r.Status = "Closed").Count(), 0)

        gfx.DrawString("SUMMARY", fSection, brBlack, New XRect(leftMargin, curY, contentWidth, 14), sfLeft)
        curY += 18.0

        Dim gap = 10.0
        Dim cardW = (contentWidth - (gap * 3.0)) / 4.0
        Dim cardH = 50.0

        Dim cards = {
            ("Total Incidents", total.ToString(), brBlack),
            ("Active",          active.ToString(), brOrange),
            ("Resolved",        resolved.ToString(), brGreen),
            ("Closed",          closed.ToString(), brDarkGray)
        }

        For i = 0 To 3
            Dim cx = leftMargin + i * (cardW + gap)
            Dim cardRect As New XRect(cx, curY, cardW, cardH)

            gfx.DrawRectangle(penCardBorder, brCardBg, cardRect)
            gfx.DrawString(cards(i).Item1, fCardLbl, brGray,
                           New XRect(cx + 8, curY + 6, cardW - 16, 12), sfLeft)
            gfx.DrawString(cards(i).Item2, fCardNum, cards(i).Item3,
                           New XRect(cx + 8, curY + 20, cardW - 16, 24), sfLeft)
        Next

        curY += cardH + 20.0

        ' ════════════════════════════════════════════════════════
        ' BREAKDOWN TABLE
        ' ════════════════════════════════════════════════════════
        gfx.DrawLine(penLight, leftMargin, curY, rightMargin, curY)
        curY += 12.0

        gfx.DrawString("BREAKDOWN BY INCIDENT TYPE", fSection, brBlack, New XRect(leftMargin, curY, contentWidth, 14), sfLeft)
        curY += 18.0

        Dim colTypeW = 212.0
        Dim colNumW  = 80.0 ' 4 columns * 80 = 320 -> Total = 532

        Dim x0 = leftMargin
        Dim x1 = x0 + colTypeW
        Dim x2 = x1 + colNumW
        Dim x3 = x2 + colNumW
        Dim x4 = x3 + colNumW

        Dim rowH = 22.0

        ' Header Row
        Dim headerRect As New XRect(leftMargin, curY, contentWidth, rowH)
        gfx.DrawRectangle(brRed, headerRect)

        gfx.DrawString("Incident Type", fColHdr, brWhite, New XRect(x0 + 8, curY, colTypeW - 8, rowH), sfLeft)
        gfx.DrawString("Total Count",   fColHdr, brWhite, New XRect(x1, curY, colNumW, rowH), sfCenter)
        gfx.DrawString("Active",        fColHdr, brWhite, New XRect(x2, curY, colNumW, rowH), sfCenter)
        gfx.DrawString("Resolved",      fColHdr, brWhite, New XRect(x3, curY, colNumW, rowH), sfCenter)
        gfx.DrawString("Other",         fColHdr, brWhite, New XRect(x4, curY, colNumW, rowH), sfCenter)

        curY += rowH

        ' Data Rows
        Dim types = If(records IsNot Nothing,
                       records.Select(Function(r) r.IncidentType).Distinct().OrderBy(Function(t) t).ToList(),
                       New List(Of String)())

        Dim alt = False
        For Each incType In types
            Dim grp       = records.Where(Function(r) r.IncidentType = incType).ToList()
            Dim gActive   = grp.Where(Function(r) r.Status = "Active").Count()
            Dim gResolved = grp.Where(Function(r) r.Status = "Resolved").Count()
            Dim gOther    = grp.Count - gActive - gResolved

            Dim rowRect As New XRect(leftMargin, curY, contentWidth, rowH)
            If alt Then
                gfx.DrawRectangle(brAltRow, rowRect)
            End If

            gfx.DrawLine(penLight, leftMargin, curY + rowH, rightMargin, curY + rowH)

            gfx.DrawString(incType,            fCell, brBlack, New XRect(x0 + 8, curY, colTypeW - 8, rowH), sfLeft)
            gfx.DrawString(grp.Count.ToString(), fCell, brBlack, New XRect(x1, curY, colNumW, rowH), sfCenter)
            gfx.DrawString(gActive.ToString(), fCell, brBlack, New XRect(x2, curY, colNumW, rowH), sfCenter)
            gfx.DrawString(gResolved.ToString(), fCell, brBlack, New XRect(x3, curY, colNumW, rowH), sfCenter)
            gfx.DrawString(gOther.ToString(),  fCell, brBlack, New XRect(x4, curY, colNumW, rowH), sfCenter)

            curY += rowH
            alt = Not alt
        Next

        If types.Count = 0 Then
            Dim noDataRect As New XRect(leftMargin, curY, contentWidth, rowH)
            gfx.DrawString("No incident records found matching the current criteria.", fCell, brGray, noDataRect, sfCenter)
            gfx.DrawLine(penLight, leftMargin, curY + rowH, rightMargin, curY + rowH)
            curY += rowH
        End If

        ' Totals Row
        Dim totalRect As New XRect(leftMargin, curY, contentWidth, rowH)
        gfx.DrawRectangle(brTotalBg, totalRect)
        gfx.DrawLine(penRed, leftMargin, curY, rightMargin, curY)
        gfx.DrawLine(penLight, leftMargin, curY + rowH, rightMargin, curY + rowH)

        Dim otherTotal = total - active - resolved

        gfx.DrawString("TOTAL",                fTotals, brBlack, New XRect(x0 + 8, curY, colTypeW - 8, rowH), sfLeft)
        gfx.DrawString(total.ToString(),       fTotals, brBlack, New XRect(x1, curY, colNumW, rowH), sfCenter)
        gfx.DrawString(active.ToString(),      fTotals, brBlack, New XRect(x2, curY, colNumW, rowH), sfCenter)
        gfx.DrawString(resolved.ToString(),    fTotals, brBlack, New XRect(x3, curY, colNumW, rowH), sfCenter)
        gfx.DrawString(otherTotal.ToString(),  fTotals, brBlack, New XRect(x4, curY, colNumW, rowH), sfCenter)

        ' ════════════════════════════════════════════════════════
        ' SIGNATORIES SECTION
        ' ════════════════════════════════════════════════════════
        Dim sigY = Math.Max(curY + 40.0, 625.0)
        If sigY + 85.0 > footerY Then sigY = footerY - 90.0

        Dim fSigHdr   = New XFont("Segoe UI", 8.5, XFontStyleEx.Regular)
        Dim fSigName  = New XFont("Segoe UI", 9.5, XFontStyleEx.Bold)
        Dim fSigTitle = New XFont("Segoe UI", 8.0, XFontStyleEx.Regular)
        Dim penSig    = New XPen(XColor.FromArgb(50, 50, 50), 0.75)

        Dim sigs = SignatoryHelper.GetSignatories()
        Dim activeSigs = sigs.Where(Function(s) s.Enabled AndAlso Not String.IsNullOrWhiteSpace(s.Name)).ToList()

        If activeSigs.Count = 3 Then
            Dim colW = 160.0
            Dim totalColsW = colW * 3.0
            Dim sigGap = (contentWidth - totalColsW) / 2.0
            For i = 0 To 2
                Dim s = activeSigs(i)
                Dim sigX = leftMargin + (i * (colW + sigGap))
                gfx.DrawString(s.Label, fSigHdr, brDarkGray, New XRect(sigX, sigY, colW, 14), sfLeft)
                gfx.DrawLine(penSig, sigX, sigY + 45.0, sigX + colW - 5, sigY + 45.0)
                gfx.DrawString(s.Name.ToUpper(), fSigName, brBlack, New XRect(sigX, sigY + 49.0, colW - 5, 14), sfCenter)
                gfx.DrawString(s.Title, fSigTitle, brDarkGray, New XRect(sigX, sigY + 63.0, colW - 5, 12), sfCenter)
            Next
        Else
            ' Default 2 Signatories (Left & Right)
            Dim s1 = If(activeSigs.Count > 0, activeSigs(0), New SignatoryItem With {.Label = "Prepared by:", .Name = "FO3 Juan Dela Cruz, BFP", .Title = "Duty Desk Officer / Fire Investigator"})
            Dim s2 = If(activeSigs.Count > 1, activeSigs(1), New SignatoryItem With {.Label = "Noted by:", .Name = "CINSP Pedro Penduko, BFP", .Title = "Municipal Fire Marshal"})

            Dim colW = 210.0
            Dim sig1X = leftMargin
            Dim sig2X = rightMargin - colW

            ' Signatory 1
            gfx.DrawString(s1.Label, fSigHdr, brDarkGray, New XRect(sig1X, sigY, colW, 14), sfLeft)
            gfx.DrawLine(penSig, sig1X, sigY + 45.0, sig1X + colW - 10, sigY + 45.0)
            gfx.DrawString(s1.Name.ToUpper(), fSigName, brBlack, New XRect(sig1X, sigY + 49.0, colW - 10, 14), sfCenter)
            gfx.DrawString(s1.Title, fSigTitle, brDarkGray, New XRect(sig1X, sigY + 63.0, colW - 10, 12), sfCenter)

            ' Signatory 2
            gfx.DrawString(s2.Label, fSigHdr, brDarkGray, New XRect(sig2X, sigY, colW, 14), sfLeft)
            gfx.DrawLine(penSig, sig2X, sigY + 45.0, sig2X + colW - 10, sigY + 45.0)
            gfx.DrawString(s2.Name.ToUpper(), fSigName, brBlack, New XRect(sig2X, sigY + 49.0, colW - 10, 14), sfCenter)
            gfx.DrawString(s2.Title, fSigTitle, brDarkGray, New XRect(sig2X, sigY + 63.0, colW - 10, 12), sfCenter)
        End If

        ' ════════════════════════════════════════════════════════
        ' FOOTER
        ' ════════════════════════════════════════════════════════
        gfx.DrawLine(penLight, leftMargin, footerY, rightMargin, footerY)

        Dim fNotice1 = "Bureau of Fire Protection • Tuao Fire Station  |  Republic of the Philippines"
        Dim fNotice2 = "RMIS (Records Management Information System) — Official System Generated Report"

        gfx.DrawString(fNotice1, fFooter, brDarkGray, New XRect(leftMargin, footerY + 5, 380, 11), sfLeft)
        gfx.DrawString(fNotice2, fFooter, brGray, New XRect(leftMargin, footerY + 17, 380, 11), sfLeft)
        gfx.DrawString("Page 1 of 1", fFooterBold, brBlack, New XRect(rightMargin - 120, footerY + 8, 120, 14), sfRight)
    End Sub

    ''' <summary>
    ''' Attempts to open the specified PDF file in the user's web browser.
    ''' </summary>
    Public Sub OpenInWebBrowser(pdfPath As String)
        If String.IsNullOrWhiteSpace(pdfPath) OrElse Not File.Exists(pdfPath) Then Return

        ' 1. Try reading the default browser path from the Windows registry
        Dim browserExe = GetDefaultBrowserPath()
        If Not String.IsNullOrEmpty(browserExe) AndAlso File.Exists(browserExe) Then
            Try
                Dim psi As New ProcessStartInfo() With {
                    .FileName = browserExe,
                    .Arguments = $"""{pdfPath}""",
                    .UseShellExecute = False
                }
                Process.Start(psi)
                Return
            Catch
            End Try
        End If

        ' 2. Try known browsers
        Dim commonBrowsers = {
            "C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe",
            "C:\Program Files\Microsoft\Edge\Application\msedge.exe",
            "C:\Program Files\Google\Chrome\Application\chrome.exe",
            "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe",
            "C:\Program Files\Mozilla Firefox\firefox.exe"
        }

        For Each b In commonBrowsers
            If File.Exists(b) Then
                Try
                    Dim psi As New ProcessStartInfo() With {
                        .FileName = b,
                        .Arguments = $"""{pdfPath}""",
                        .UseShellExecute = False
                    }
                    Process.Start(psi)
                    Return
                Catch
                End Try
            End If
        Next

        ' 3. Fallback: Shell Execute
        Dim shellPsi As New ProcessStartInfo(pdfPath) With {
            .UseShellExecute = True
        }
        Process.Start(shellPsi)
    End Sub

    Private Function GetDefaultBrowserPath() As String
        Try
            Using key = Registry.ClassesRoot.OpenSubKey("http\shell\open\command")
                If key IsNot Nothing Then
                    Dim val = TryCast(key.GetValue(""), String)
                    If Not String.IsNullOrWhiteSpace(val) Then
                        val = val.Trim()
                        If val.StartsWith(""""c) Then
                            Dim secondQuote = val.IndexOf(""""c, 1)
                            If secondQuote > 1 Then
                                Return val.Substring(1, secondQuote - 1)
                            End If
                        Else
                            Dim firstSpace = val.IndexOf(" "c)
                            If firstSpace > 0 Then
                                Return val.Substring(0, firstSpace)
                            Else
                                Return val
                            End If
                        End If
                    End If
                End If
            End Using
        Catch
        End Try
        Return ""
    End Function

    Private Function GetLogoPath() As String
        Try
            Dim path = BannerHelper.GetCurrentBannerPath()
            If Not String.IsNullOrEmpty(path) AndAlso File.Exists(path) Then
                Return path
            End If
        Catch
            ' Ignore database/settings connection errors and fall back to local file
        End Try

        Dim baseDir = AppDomain.CurrentDomain.BaseDirectory
        Dim defaultBanner = System.IO.Path.Combine(baseDir, "Assets", "Banner", "banner_current.png")
        If File.Exists(defaultBanner) Then Return defaultBanner

        Dim curBanner = System.IO.Path.Combine(Environment.CurrentDirectory, "Assets", "Banner", "banner_current.png")
        If File.Exists(curBanner) Then Return curBanner

        Return ""
    End Function

End Module
