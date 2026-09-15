Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms

Public Class ManualScreenshotGenerator

    Public Shared Property IsCapturingManual As Boolean = False

    Public Shared Function GetManualDirectories() As List(Of String)
        Dim dirs As New List(Of String)()

        ' Runtime directory
        Dim binDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "Manual")
        If Not Directory.Exists(binDir) Then Directory.CreateDirectory(binDir)
        dirs.Add(binDir)

        ' Project source directory
        Try
            Dim srcDir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Assets", "Manual"))
            If Directory.Exists(Path.GetDirectoryName(srcDir)) Then
                If Not Directory.Exists(srcDir) Then Directory.CreateDirectory(srcDir)
                dirs.Add(srcDir)
            End If
        Catch
        End Try

        Return dirs
    End Function

    Public Shared Function GetScreenshotPath(topicId As Integer) As String
        Dim fileName = ""
        Select Case topicId
            Case 1 : fileName = "manual_1_login.png"
            Case 2 : fileName = "manual_2_dashboard.png"
            Case 3 : fileName = "manual_3_add_record.png"
            Case 4 : fileName = "manual_4_view_records.png"
            Case 5 : fileName = "manual_5_reports.png"
            Case 6 : fileName = "manual_6_settings.png"
            Case Else : Return ""
        End Select

        ' Check bin directory first
        Dim binPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "Manual", fileName)
        If File.Exists(binPath) Then Return binPath

        ' Check project source directory
        Try
            Dim srcPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Assets", "Manual", fileName))
            If File.Exists(srcPath) Then Return srcPath

            Dim srcSibling = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "RMIS_BFP_Tuao", "Assets", "Manual", fileName))
            If File.Exists(srcSibling) Then Return srcSibling
        Catch
        End Try

        Return binPath
    End Function

    Private Shared Sub SaveBitmapToDirs(bmp As Bitmap, fileName As String)
        For Each folder In GetManualDirectories()
            Try
                Dim dest = Path.Combine(folder, fileName)
                bmp.Save(dest, ImageFormat.Png)
            Catch
            End Try
        Next
    End Sub

    Private Shared Sub CaptureControl(ctrl As Control, width As Integer, height As Integer, fileName As String)
        Using form As New Form()
            form.FormBorderStyle = FormBorderStyle.None
            form.StartPosition = FormStartPosition.Manual
            form.Location = New Point(50, 50)
            form.ClientSize = New Size(width, height)
            form.ShowInTaskbar = False

            ctrl.Dock = DockStyle.Fill
            form.Controls.Add(ctrl)

            form.Show()
            Application.DoEvents()
            Thread.Sleep(100)
            Application.DoEvents()

            Using bmp As New Bitmap(width, height)
                form.DrawToBitmap(bmp, New Rectangle(0, 0, width, height))
                SaveBitmapToDirs(bmp, fileName)
            End Using

            form.Close()
        End Using
    End Sub

    Public Shared Sub GenerateAllScreenshots()
        IsCapturingManual = True
        Try
            Dim logFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "generator_log.txt")
            File.WriteAllText(logFile, "Started at " & DateTime.Now.ToString() & Environment.NewLine)

            ' 1. Login Form (Authentication)
            Try
                File.AppendAllText(logFile, "Starting Login..." & Environment.NewLine)
                Using login As New LoginForm()
                    login.StartPosition = FormStartPosition.Manual
                    login.Location = New Point(50, 50)
                    login.Show()
                    Application.DoEvents()
                    Thread.Sleep(100)
                    Application.DoEvents()

                    Using bmp As New Bitmap(login.ClientSize.Width, login.ClientSize.Height)
                        login.DrawToBitmap(bmp, New Rectangle(0, 0, login.ClientSize.Width, login.ClientSize.Height))
                        SaveBitmapToDirs(bmp, "manual_1_login.png")
                    End Using
                    login.Close()
                End Using
                File.AppendAllText(logFile, "Login done!" & Environment.NewLine)
            Catch ex As Exception
                File.AppendAllText(logFile, "Login error: " & ex.ToString() & Environment.NewLine)
            End Try

            ' 2. Dashboard
            Try
                File.AppendAllText(logFile, "Starting Dashboard..." & Environment.NewLine)
                Dim dash As New UcDashboard()
                dash.Size = New Size(960, 620)
                SessionManager.Username = "Admin"
                CaptureControl(dash, 960, 620, "manual_2_dashboard.png")
                File.AppendAllText(logFile, "Dashboard done!" & Environment.NewLine)
            Catch ex As Exception
                File.AppendAllText(logFile, "Dashboard error: " & ex.ToString() & Environment.NewLine)
            End Try

            ' 3. Add Record
            Try
                File.AppendAllText(logFile, "Starting AddRecord..." & Environment.NewLine)
                Dim addRec As New UcAddRecord()
                addRec.Size = New Size(960, 680)
                addRec.txtIncidentNo.Text = "REC-2026-002"
                If addRec.cboIncidentType.Items.Count = 0 Then
                    addRec.cboIncidentType.Items.AddRange(Constants.IncidentTypes)
                End If
                addRec.cboIncidentType.SelectedIndex = 0
                If addRec.cboAlarmLevel.Items.Count = 0 Then
                    addRec.cboAlarmLevel.Items.AddRange(Constants.AlarmLevels)
                End If
                addRec.cboAlarmLevel.SelectedIndex = 0
                If addRec.cboStatus.Items.Count = 0 Then
                    addRec.cboStatus.Items.AddRange(Constants.Statuses)
                End If
                addRec.cboStatus.SelectedIndex = 0
                addRec.txtInvolvedProperty.Text = "Residential Building - Two-Storey Concrete"
                addRec.txtAddress.Text = "Zone 2, Centro, Tuao, Cagayan"
                addRec.txtOwnerOccupant.Text = "Juan Dela Cruz"
                addRec.txtCallerInformation.Text = "Maria Santos (0917-123-4567)"
                addRec.txtCasualties.Text = "0"
                addRec.txtDamageEstimate.Text = "250000"
                addRec.txtCauseOfFire.Text = "Electrical short circuit on second floor"
                addRec.txtRemarks.Text = "Responded by Engine 1 & Engine 2. Fire declared out at 15:45."
                addRec.txtDocumentName.Text = "Incident_Report_REC-2026-002.pdf"

                CaptureControl(addRec, 960, 680, "manual_3_add_record.png")
                File.AppendAllText(logFile, "AddRecord done!" & Environment.NewLine)
            Catch ex As Exception
                File.AppendAllText(logFile, "AddRecord error: " & ex.ToString() & Environment.NewLine)
            End Try

            ' 4. View Records
            Try
                File.AppendAllText(logFile, "Starting ViewRecords..." & Environment.NewLine)
                Dim viewRec As New UcViewRecords()
                viewRec.Size = New Size(960, 600)
                SessionManager.UserType = Constants.UserTypeAdmin
                viewRec.btnEdit.Visible = True
                viewRec.btnDelete.Visible = True

                CaptureControl(viewRec, 960, 600, "manual_4_view_records.png")
                File.AppendAllText(logFile, "ViewRecords done!" & Environment.NewLine)
            Catch ex As Exception
                File.AppendAllText(logFile, "ViewRecords error: " & ex.ToString() & Environment.NewLine)
            End Try

            ' 5. Reports
            Try
                File.AppendAllText(logFile, "Starting Reports..." & Environment.NewLine)
                Dim rep As New UcReports()
                rep.Size = New Size(960, 600)

                CaptureControl(rep, 960, 600, "manual_5_reports.png")
                File.AppendAllText(logFile, "Reports done!" & Environment.NewLine)
            Catch ex As Exception
                File.AppendAllText(logFile, "Reports error: " & ex.ToString() & Environment.NewLine)
            End Try

            ' 6. Settings
            Try
                File.AppendAllText(logFile, "Starting Settings..." & Environment.NewLine)
                Dim setForm As New UcSettings()
                setForm.Size = New Size(960, 680)
                setForm.pnlVerification.Visible = False
                setForm.pnlSettingsContent.Visible = True
                setForm.txtUsername.Text = "admin"
                setForm.txtStationName.Text = "Bureau of Fire Protection - Tuao Fire Station"
                setForm.txtStationAddr.Text = "Tuao, Cagayan, Philippines"
                setForm.txtSecAnswer.Text = "••••••••"

                CaptureControl(setForm, 960, 680, "manual_6_settings.png")
                File.AppendAllText(logFile, "Settings done!" & Environment.NewLine)
            Catch ex As Exception
                File.AppendAllText(logFile, "Settings error: " & ex.ToString() & Environment.NewLine)
            End Try

            ' 7. UcManual Previews
            Try
                Dim ucMan1 As New UcManual()
                ucMan1.Size = New Size(970, 570)
                ucMan1.ShowTopic(1)
                File.AppendAllText(logFile, "Topic 1 RTF length: " & ucMan1.rtbContent.Rtf.Length & ", contains pict: " & ucMan1.rtbContent.Rtf.Contains("pict") & Environment.NewLine)
                CaptureControl(ucMan1, 970, 570, "preview_manual_topic1.png")

                Dim ucMan3 As New UcManual()
                ucMan3.Size = New Size(970, 570)
                ucMan3.ShowTopic(3)
                CaptureControl(ucMan3, 970, 570, "preview_manual_topic3.png")
                File.AppendAllText(logFile, "UcManual previews done!" & Environment.NewLine)
            Catch ex As Exception
                File.AppendAllText(logFile, "UcManual preview error: " & ex.ToString() & Environment.NewLine)
            End Try
        Finally
            IsCapturingManual = False
        End Try
    End Sub

End Class
