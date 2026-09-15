Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Windows.Forms

Public Class UcManual
    Inherits UserControl

    Private _currentTopicId As Integer = 1

    Private Sub UcManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowTopic(_currentTopicId)
    End Sub

    Private Sub SetActiveTopicButton(activeBtn As Button)
        Dim buttons = {btnTopicOverview, btnTopicDashboard, btnTopicAddRecord,
                       btnTopicViewRecords, btnTopicReports, btnTopicSettings, btnTopicDevelopers}

        For Each btn In buttons
            btn.BackColor = Color.FromArgb(248, 249, 250)
            btn.ForeColor = Color.FromArgb(60, 60, 60)
            btn.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
        Next

        activeBtn.BackColor = Color.FromArgb(180, 20, 20)
        activeBtn.ForeColor = Color.White
        activeBtn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
    End Sub

    Public Sub ShowTopic(topicId As Integer)
        _currentTopicId = topicId

        If topicId >= 1 AndAlso topicId <= 6 Then
            pnlScreenshotContainer.Visible = True
            pnlScreenshotDivider.Visible = True
            btnViewFullImage.Visible = True
            LoadTopicScreenshot(topicId)
        Else
            pnlScreenshotContainer.Visible = False
            pnlScreenshotDivider.Visible = False
            btnViewFullImage.Visible = False
            picScreenshot.Image = Nothing
        End If

        Select Case topicId
            Case 1
                SetActiveTopicButton(btnTopicOverview)
                lblContentTopic.Text = "1. System Overview & Authentication"
                rtbContent.Rtf = GetRtfOverview()

            Case 2
                SetActiveTopicButton(btnTopicDashboard)
                lblContentTopic.Text = "2. Dashboard & Quick Analytics"
                rtbContent.Rtf = GetRtfDashboard()

            Case 3
                SetActiveTopicButton(btnTopicAddRecord)
                lblContentTopic.Text = "3. Adding Fire Incident Records"
                rtbContent.Rtf = GetRtfAddRecord()

            Case 4
                SetActiveTopicButton(btnTopicViewRecords)
                lblContentTopic.Text = "4. Viewing, Searching, & Editing Records"
                rtbContent.Rtf = GetRtfViewRecords()

            Case 5
                SetActiveTopicButton(btnTopicReports)
                lblContentTopic.Text = "5. Reports, Incident Breakdown, & CSV Export"
                rtbContent.Rtf = GetRtfReports()

            Case 6
                SetActiveTopicButton(btnTopicSettings)
                lblContentTopic.Text = "6. Settings, Security Questions, & Banner Customization"
                rtbContent.Rtf = GetRtfSettings()

            Case 7
                SetActiveTopicButton(btnTopicDevelopers)
                lblContentTopic.Text = "7. Development Team & Technical Support"
                rtbContent.Rtf = GetRtfDevelopers()
        End Select

        ' Scroll back to top whenever topic changes
        rtbContent.SelectionStart = 0
        rtbContent.ScrollToCaret()
    End Sub

    Private Sub LoadTopicScreenshot(topicId As Integer)
        Try
            Dim imgPath = ManualScreenshotGenerator.GetScreenshotPath(topicId)
            If Not File.Exists(imgPath) Then
                Try
                    ManualScreenshotGenerator.GenerateAllScreenshots()
                Catch
                End Try
            End If

            If File.Exists(imgPath) Then
                Using fs As New FileStream(imgPath, FileMode.Open, FileAccess.Read, FileShare.Read)
                    Using tempBmp As New Bitmap(fs)
                        picScreenshot.Image?.Dispose()
                        picScreenshot.Image = New Bitmap(tempBmp)
                    End Using
                End Using
            Else
                picScreenshot.Image = Nothing
            End If
        Catch ex As Exception
            picScreenshot.Image = Nothing
        End Try
    End Sub

    ' --- RTF Content Generators ---

    Private Function GetRtfOverview() As String
        Dim sb As New StringBuilder()
        sb.AppendLine("{\rtf1\ansi\deff0")
        sb.AppendLine("{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}")
        sb.AppendLine("{\colortbl ;\red180\green20\blue20;\red60\green60\blue60;\red120\green120\blue120;\red0\green100\blue180;}")
        sb.AppendLine("\viewkind4\uc1\pard\lang1033\f0\fs22")
        sb.AppendLine("\b\cf1 User Authentication & Login Screen (Preview Above)\b0\cf2\par")
        sb.AppendLine("The upper preview shows the official BFP Tuao login screen. Authentication protects all station records and maintains data integrity.\par\par")
        sb.AppendLine("\b\cf1 System Purpose\b0\cf2\par")
        sb.AppendLine("The Record Management Information System (RMIS) is specifically designed for the Bureau of Fire Protection - Tuao Fire Station (Cagayan). It provides a secure, efficient, and centralized repository for recording, retrieving, and reporting fire incidents, emergency alarms, and station activities.\par\par")
        sb.AppendLine("\b\cf1 User Authentication & Login\b0\cf2\par")
        sb.AppendLine("\b 1. Logging In:\b0  Launch the application. On the login screen, enter your assigned Username and Password. Click \b Login\b0  to enter.\par")
        sb.AppendLine("\b 2. Security & Password Encryption:\b0  All passwords are cryptographically hashed using industry-standard BCrypt (work factor 11). Plaintext passwords are never stored.\par")
        sb.AppendLine("\b 3. Forgot Password / Account Recovery:\b0  If you forget your password, click the \cf4 'Forgot Password?'\cf2  link on the login form. Answer your configured security question correctly to reset your password safely.\par")
        sb.AppendLine("\b 4. Session & Audit Trail:\b0  Your username is displayed on the top right bar of the application. Every user action (logins, record additions, modifications, deletions, and logouts) is logged into the audit trail table (\b tbl_ActivityLogs\b0 ).\par\par")
        sb.AppendLine("\b\cf1 Navigation Bar (Sidebar)\b0\cf2\par")
        sb.AppendLine("The left navigation bar allows instant switching between system modules:\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Dashboard:\b0  Summary indicators, active counts, and recent records.\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Add Record:\b0  Create new fire incident records with automated ID sequencing.\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 View Records:\b0  Search, filter, edit, and delete incident records.\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Reports:\b0  Incident breakdown analytics, print previews, and CSV data export.\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Settings:\b0  Manage credentials, security questions, station information, and banners.\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Developers:\b0  System author information and contact profiles.\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Manual:\b0  User manual and system operations guide.\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Logout:\b0  Safely closes your session and returns to the login screen.\par")
        sb.AppendLine("}")
        Return sb.ToString()
    End Function

    Private Function GetRtfDashboard() As String
        Dim sb As New StringBuilder()
        sb.AppendLine("{\rtf1\ansi\deff0")
        sb.AppendLine("{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}")
        sb.AppendLine("{\colortbl ;\red180\green20\blue20;\red60\green60\blue60;\red0\green130\blue30;\red220\green120\blue0;}")
        sb.AppendLine("\viewkind4\uc1\pard\lang1033\f0\fs22")
        sb.AppendLine("\b\cf1 Dashboard Overview (Preview Above)\b0\cf2\par")
        sb.AppendLine("The Dashboard is the home screen of RMIS, providing duty officers with immediate real-time statistics and visibility into station incidents.\par\par")
        sb.AppendLine("\b\cf1 Key Performance Indicator (KPI) Cards\b0\cf2\par")
        sb.AppendLine("  \b\cf1 1. Total Incidents:\b0\cf2  Cumulative number of incident records registered in the system.\par")
        sb.AppendLine("  \b\cf4 2. Active Cases:\b0\cf2  Fire incidents that are ongoing or currently under active investigation.\par")
        sb.AppendLine("  \b\cf3 3. Resolved Incidents:\b0\cf2  Fire incidents successfully contained, declared fire out, or resolved.\par")
        sb.AppendLine("  \b\cf2 4. Closed Records:\b0\cf2  Completed incident investigations with finalized documentation.\par\par")
        sb.AppendLine("\b\cf1 Recent Incidents Feed\b0\cf2\par")
        sb.AppendLine("Below the KPI cards, the table displays the \b latest 5 recorded incidents\b0  sorted in reverse chronological order. Each row presents the Incident ID, Date, Barangay/Location, Incident Type, and current Status.\par\par")
        sb.AppendLine("\b\cf1 Quick Action Tips\b0\cf2\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 To view all records in detail or perform searches, click \b View Records\b0  in the sidebar.\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 To enter a new call or fire alarm, click \b Add Record\b0 .\par")
        sb.AppendLine("}")
        Return sb.ToString()
    End Function

    Private Function GetRtfAddRecord() As String
        Dim sb As New StringBuilder()
        sb.AppendLine("{\rtf1\ansi\deff0")
        sb.AppendLine("{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}")
        sb.AppendLine("{\colortbl ;\red180\green20\blue20;\red60\green60\blue60;\red120\green120\blue120;}")
        sb.AppendLine("\viewkind4\uc1\pard\lang1033\f0\fs22")
        sb.AppendLine("\b\cf1 Creating a New Incident Record (Preview Above)\b0\cf2\par")
        sb.AppendLine("The screenshot above illustrates the Add Record entry form with all required BFP incident fields.\par\par")
        sb.AppendLine("\b\cf1 Step-by-Step Instructions\b0\cf2\par")
        sb.AppendLine("\b Step 1:\b0  Navigate to \b Add Record\b0  from the left sidebar.\par")
        sb.AppendLine("\b Step 2:\b0  The \b Incident ID\b0  is automatically generated by the system using the official format (e.g., \b REC-2026-001\b0 ). This ID is unique and immutable.\par")
        sb.AppendLine("\b Step 3:\b0  Fill in the incident details:\par")
        sb.AppendLine("   \b\cf1 \bullet \cf2 Incident Date & Time:\b0  Select the exact date and time the alarm was received.\par")
        sb.AppendLine("   \b\cf1 \bullet \cf2 Location / Barangay:\b0  Specify the complete address or barangay in Tuao (e.g., Centro, Alabug, Malalinta, etc.).\par")
        sb.AppendLine("   \b\cf1 \bullet \cf2 Incident Type:\b0  Select the classification (Structural, Non-Structural, Vehicular, Forest/Grass Fire, Electrical, False Alarm, etc.).\par")
        sb.AppendLine("   \b\cf1 \bullet \cf2 Alarm Level:\b0  Select response alarm (1st Alarm, 2nd Alarm, 3rd Alarm, 4th Alarm, 5th Alarm, Task Force Alpha/Bravo, General Alarm).\par")
        sb.AppendLine("   \b\cf1 \bullet \cf2 Caller & Contact Info:\b0  Name and contact number of the person reporting the fire.\par")
        sb.AppendLine("   \b\cf1 \bullet \cf2 Responding Team & Officer In Charge (OIC):\b0  Duty fire engine team and ground commander.\par")
        sb.AppendLine("   \b\cf1 \bullet \cf2 Casualties & Damage:\b0  Indicate injured count, fatalities count, and estimated property damage in PHP.\par")
        sb.AppendLine("   \b\cf1 \bullet \cf2 Status:\b0  Initial status (Active, Under Investigation, Resolved, Closed).\par")
        sb.AppendLine("   \b\cf1 \bullet \cf2 Remarks / Narrative:\b0  Summary of operation, origin of fire, and responding units.\par\par")
        sb.AppendLine("\b Step 4:\b0  Click the \b Save Record\b0  button. A confirmation message will appear, and the record is immediately written to the database with activity logging.\par")
        sb.AppendLine("\b Step 5:\b0  To reset all input fields, click \b Clear Fields\b0 .\par")
        sb.AppendLine("}")
        Return sb.ToString()
    End Function

    Private Function GetRtfViewRecords() As String
        Dim sb As New StringBuilder()
        sb.AppendLine("{\rtf1\ansi\deff0")
        sb.AppendLine("{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}")
        sb.AppendLine("{\colortbl ;\red180\green20\blue20;\red60\green60\blue60;\red0\green100\blue180;}")
        sb.AppendLine("\viewkind4\uc1\pard\lang1033\f0\fs22")
        sb.AppendLine("\b\cf1 View Records Module (Preview Above)\b0\cf2\par")
        sb.AppendLine("The View Records page contains the complete database grid of all recorded incidents with search, filtering, editing, and deletion tools.\par\par")
        sb.AppendLine("\b\cf1 Live Search & Filtering\b0\cf2\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Search Box:\b0  Type any keyword (Incident ID, Location, Caller, Officer, or Remarks). The table dynamically filters results in real-time as you type.\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Status Filter:\b0  Filter records by specific status (All, Active, Under Investigation, Resolved, Closed).\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Type Filter:\b0  Filter records by incident classification.\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Refresh Button:\b0  Reload the latest records directly from SQL Server.\par\par")
        sb.AppendLine("\b\cf1 Editing an Incident Record\b0\cf2\par")
        sb.AppendLine("  \b 1.\b0  Select a record row in the DataGridView.\par")
        sb.AppendLine("  \b 2.\b0  Click the \b Edit Record\b0  button (or double-click the row).\par")
        sb.AppendLine("  \b 3.\b0  The \b Edit Record Modal Form\b0  opens with pre-populated fields. Update the required fields (e.g. update status to 'Resolved', adjust damage estimates, or add investigation findings).\par")
        sb.AppendLine("  \b 4.\b0  Click \b Update Record\b0 . Changes are saved instantly, and the grid refreshes.\par\par")
        sb.AppendLine("\b\cf1 Deleting a Record\b0\cf2\par")
        sb.AppendLine("  \b 1.\b0  Select the record you wish to remove.\par")
        sb.AppendLine("  \b 2.\b0  Click the \b Delete Record\b0  button.\par")
        sb.AppendLine("  \b 3.\b0  Confirm the prompt. (Note: Only authorized administrators should delete records. All deletions are audited).\par")
        sb.AppendLine("}")
        Return sb.ToString()
    End Function

    Private Function GetRtfReports() As String
        Dim sb As New StringBuilder()
        sb.AppendLine("{\rtf1\ansi\deff0")
        sb.AppendLine("{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}")
        sb.AppendLine("{\colortbl ;\red180\green20\blue20;\red60\green60\blue60;\red0\green100\blue180;}")
        sb.AppendLine("\viewkind4\uc1\pard\lang1033\f0\fs22")
        sb.AppendLine("\b\cf1 Incident Reports & Statistics (Preview Above)\b0\cf2\par")
        sb.AppendLine("The Reports module provides comprehensive analytics, summary breakdown matrices, and formal export capabilities for station documentation and regional submissions.\par\par")
        sb.AppendLine("\b\cf1 Breakdown Table\b0\cf2\par")
        sb.AppendLine("The breakdown matrix categorizes every incident type by:\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Total Count:\b0  Total number of incidents per classification.\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Active Incidents:\b0  Count currently active or under response.\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Resolved Incidents:\b0  Count successfully handled.\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Other / Closed:\b0  Count completed and archived.\par\par")
        sb.AppendLine("\b\cf1 Exporting to CSV (Spreadsheet Format)\b0\cf2\par")
        sb.AppendLine("  \b 1.\b0  Click the \b Export CSV\b0  button on the top right header.\par")
        sb.AppendLine("  \b 2.\b0  Choose your desired save destination in the File Dialog.\par")
        sb.AppendLine("  \b 3.\b0  Click \b Save\b0 . The resulting CSV file can be opened directly in Microsoft Excel, Google Sheets, or LibreOffice Calc for spreadsheet analysis.\par\par")
        sb.AppendLine("\b\cf1 Printing Official Reports\b0\cf2\par")
        sb.AppendLine("  \b 1.\b0  Click the \b Print Report\b0  button.\par")
        sb.AppendLine("  \b 2.\b0  A print preview window will display formatted report pages featuring the official BFP header, summary breakdown, and signature validation blocks.\par")
        sb.AppendLine("  \b 3.\b0  Send the document directly to a connected printer or save as PDF.\par")
        sb.AppendLine("}")
        Return sb.ToString()
    End Function

    Private Function GetRtfSettings() As String
        Dim sb As New StringBuilder()
        sb.AppendLine("{\rtf1\ansi\deff0")
        sb.AppendLine("{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}")
        sb.AppendLine("{\colortbl ;\red180\green20\blue20;\red60\green60\blue60;\red0\green100\blue180;}")
        sb.AppendLine("\viewkind4\uc1\pard\lang1033\f0\fs22")
        sb.AppendLine("\b\cf1 Settings & Account Management (Preview Above)\b0\cf2\par")
        sb.AppendLine("The Settings module allows users to configure account credentials, security recovery options, station information, and visual branding.\par\par")
        sb.AppendLine("\b\cf1 1. Account Settings\b0\cf2\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Change Username:\b0  Update the active login username.\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Change Password:\b0  Enter your current password, new password, and confirmation. Passwords are encrypted with BCrypt work factor 11.\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Security Questions:\b0  Select a security question (e.g. 'What is the name of your first fire station?') and provide your recovery answer. This is used on the Forgot Password screen to recover accounts.\par\par")
        sb.AppendLine("\b\cf1 2. System Settings (Station Info)\b0\cf2\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Station Name:\b0  Bureau of Fire Protection - Tuao Fire Station.\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Station Address:\b0  Official municipality address (Tuao, Cagayan, Philippines).\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Station Banner / Logo:\b0  Upload a custom station seal or banner image. The image is safely copied to the Assets directory and reflected across the sidebar and login screens.\par")
        sb.AppendLine("}")
        Return sb.ToString()
    End Function

    Private Function GetRtfDevelopers() As String
        Dim sb As New StringBuilder()
        sb.AppendLine("{\rtf1\ansi\deff0")
        sb.AppendLine("{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}")
        sb.AppendLine("{\colortbl ;\red180\green20\blue20;\red60\green60\blue60;\red0\green100\blue180;}")
        sb.AppendLine("\viewkind4\uc1\pard\lang1033\f0\fs22")
        sb.AppendLine("\b\cf1 System Development Team\b0\cf2\par")
        sb.AppendLine("The RMIS BFP Tuao system is developed and maintained by:\par\par")
        sb.AppendLine("\b\cf1 Developer 1:\b0\cf2  Angelika Bangan\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Course:\b0  BSIT (Bachelor of Science in Information Technology)\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Contact Number:\b0  09533416197\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Gmail Address:\b0  angelikabangan19@gmail.com\par\par")
        sb.AppendLine("\b\cf1 Developer 2:\b0\cf2  Ricky Paat\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Course:\b0  BSIT (Bachelor of Science in Information Technology)\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Contact Number:\b0  09615344796\par")
        sb.AppendLine("  \b\cf1 \bullet \cf2 Gmail Address:\b0  rickypaat6@gmail.com\par\par")
        sb.AppendLine("\b\cf1 Adding Developer Photos\b0\cf2\par")
        sb.AppendLine("To add or change photos for the developers:\par")
        sb.AppendLine("  \b 1.\b0  Go to the \b Developers\b0  tab in the sidebar.\par")
        sb.AppendLine("  \b 2.\b0  Click on the developer's photo placeholder or click the \b 'Photo'\b0  button.\par")
        sb.AppendLine("  \b 3.\b0  Select an image file (.jpg, .png, .jpeg). The photo will immediately update and be saved persistently.\par\par")
        sb.AppendLine("\b\cf1 Technical Inquiries & Bug Reports\b0\cf2\par")
        sb.AppendLine("For technical assistance, system updates, database maintenance, or feature requests, contact the development team through their contact numbers or Gmail addresses above.\par")
        sb.AppendLine("}")
        Return sb.ToString()
    End Function

    ' --- Topic Button Handlers ---

    Private Sub btnTopicOverview_Click(sender As Object, e As EventArgs) Handles btnTopicOverview.Click
        ShowTopic(1)
    End Sub

    Private Sub btnTopicDashboard_Click(sender As Object, e As EventArgs) Handles btnTopicDashboard.Click
        ShowTopic(2)
    End Sub

    Private Sub btnTopicAddRecord_Click(sender As Object, e As EventArgs) Handles btnTopicAddRecord.Click
        ShowTopic(3)
    End Sub

    Private Sub btnTopicViewRecords_Click(sender As Object, e As EventArgs) Handles btnTopicViewRecords.Click
        ShowTopic(4)
    End Sub

    Private Sub btnTopicReports_Click(sender As Object, e As EventArgs) Handles btnTopicReports.Click
        ShowTopic(5)
    End Sub

    Private Sub btnTopicSettings_Click(sender As Object, e As EventArgs) Handles btnTopicSettings.Click
        ShowTopic(6)
    End Sub

    Private Sub btnTopicDevelopers_Click(sender As Object, e As EventArgs) Handles btnTopicDevelopers.Click
        ShowTopic(7)
    End Sub

    Private Sub btnViewFullImage_Click(sender As Object, e As EventArgs) Handles btnViewFullImage.Click, picScreenshot.Click, lblScreenshotHint.Click
        Dim imgPath = ManualScreenshotGenerator.GetScreenshotPath(_currentTopicId)
        If File.Exists(imgPath) Then
            Using viewer As New Form()
                viewer.Text = "RMIS Manual Preview - " & lblContentTopic.Text
                viewer.Size = New Size(1020, 720)
                viewer.StartPosition = FormStartPosition.CenterParent
                viewer.BackColor = Color.FromArgb(30, 30, 30)

                Dim pnlTop As New Panel() With {
                    .Dock = DockStyle.Top,
                    .Height = 44,
                    .BackColor = Color.FromArgb(20, 20, 20)
                }
                Dim lblTitle As New Label() With {
                    .Dock = DockStyle.Left,
                    .Text = "  " & lblContentTopic.Text,
                    .Font = New Font("Segoe UI", 10.5F, FontStyle.Bold),
                    .ForeColor = Color.White,
                    .TextAlign = ContentAlignment.MiddleLeft,
                    .AutoSize = True
                }
                Dim btnClose As New Button() With {
                    .Dock = DockStyle.Right,
                    .Text = "Close",
                    .Width = 80,
                    .FlatStyle = FlatStyle.Flat,
                    .ForeColor = Color.White,
                    .BackColor = Color.FromArgb(180, 20, 20),
                    .Cursor = Cursors.Hand
                }
                AddHandler btnClose.Click, Sub() viewer.Close()
                pnlTop.Controls.Add(lblTitle)
                pnlTop.Controls.Add(btnClose)

                Dim pb As New PictureBox() With {
                    .Dock = DockStyle.Fill,
                    .SizeMode = PictureBoxSizeMode.Zoom,
                    .BackColor = Color.FromArgb(40, 40, 40)
                }
                Using fs As New FileStream(imgPath, FileMode.Open, FileAccess.Read, FileShare.Read)
                    Using tempBmp As New Bitmap(fs)
                        pb.Image = New Bitmap(tempBmp)
                    End Using
                End Using

                viewer.Controls.Add(pb)
                viewer.Controls.Add(pnlTop)
                viewer.ShowDialog(Me)
                pb.Image?.Dispose()
            End Using
        End If
    End Sub

End Class