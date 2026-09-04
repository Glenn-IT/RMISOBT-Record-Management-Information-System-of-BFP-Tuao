Imports System.IO

Public Class UcDevelopers
    Inherits UserControl

    Private ReadOnly DevFolder As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "Developers")

    Private Sub UcDevelopers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Application info
        lblAppName.Text    = "RMIS - BFP Tuao"
        lblAppDesc.Text    = "Record Management Information System" & Environment.NewLine &
                             "Bureau of Fire Protection - Tuao Fire Station"
        lblVersionVal.Text = "1.0.0 (Prototype)"
        lblBuiltVal.Text   = "VB.NET / WinForms / .NET 8 / SQL Server"
        lblStationVal.Text = "BFP Tuao Fire Station, Cagayan"

        ' Developer 1 - Angelika Bangan
        lblDev1Name.Text    = "Angelika Bangan"
        lblDev1Course.Text  = "Course: BSIT"
        lblDev1Contact.Text = "Contact Number: 09533416197"
        lblDev1Email.Text   = "Gmail Address: angelikabangan19@gmail.com"

        ' Developer 2 - Ricky Paat
        lblDev2Name.Text    = "Ricky Paat"
        lblDev2Course.Text  = "Course: BSIT"
        lblDev2Contact.Text = "Contact Number: 09615344796"
        lblDev2Email.Text   = "Gmail Address: rickypaat6@gmail.com"

        LoadDeveloperPhotos()
    End Sub

    Public Sub LoadDeveloperPhotos()
        LoadDevPhoto(1, picDev1, "AB")
        LoadDevPhoto(2, picDev2, "RP")
    End Sub

    Private Sub LoadDevPhoto(devNum As Integer, pic As PictureBox, initials As String)
        Try
            Dim photoPath = SettingsRepository.GetValue($"Dev{devNum}_PhotoPath", "")
            If photoPath <> "" AndAlso File.Exists(photoPath) Then
                pic.Image?.Dispose()
                pic.Image = BannerHelper.LoadImage(photoPath)
                Return
            End If

            If Directory.Exists(DevFolder) Then
                Dim files = Directory.GetFiles(DevFolder, $"dev{devNum}.*")
                If files.Length > 0 AndAlso File.Exists(files(0)) Then
                    pic.Image?.Dispose()
                    pic.Image = BannerHelper.LoadImage(files(0))
                    Return
                End If

                Dim namePattern = If(devNum = 1, "angelika*", "ricky*")
                Dim nameFiles = Directory.GetFiles(DevFolder, namePattern)
                If nameFiles.Length > 0 AndAlso File.Exists(nameFiles(0)) Then
                    pic.Image?.Dispose()
                    pic.Image = BannerHelper.LoadImage(nameFiles(0))
                    Return
                End If
            End If

            pic.Image?.Dispose()
            pic.Image = GenerateAvatarPlaceholder(initials, pic.Width, pic.Height)
        Catch
            pic.Image = GenerateAvatarPlaceholder(initials, pic.Width, pic.Height)
        End Try
    End Sub

    Private Function GenerateAvatarPlaceholder(initials As String, width As Integer, height As Integer) As Image
        Dim targetW = Math.Max(width, 100)
        Dim targetH = Math.Max(height, 115)
        Dim bmp As New Bitmap(targetW, targetH)
        Using g = Graphics.FromImage(bmp)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.Clear(Color.FromArgb(235, 238, 242))

            ' Draw circle avatar background
            Using bCircle As New SolidBrush(Color.FromArgb(205, 215, 225))
                g.FillEllipse(bCircle, CInt((targetW - 68) / 2), 12, 68, 68)
            End Using

            ' Draw initials
            Using f As New Font("Segoe UI", 16.0F, FontStyle.Bold)
                Using sf As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
                    Using bText As New SolidBrush(Color.FromArgb(70, 80, 95))
                        g.DrawString(initials, f, bText, New RectangleF(0, 12, targetW, 68), sf)
                    End Using
                End Using
            End Using

            ' Draw subtle caption at bottom
            Using fSub As New Font("Segoe UI", 7.5F, FontStyle.Regular)
                Using sf As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
                    Using bSub As New SolidBrush(Color.FromArgb(120, 125, 135))
                        g.DrawString("No Image", fSub, bSub, New RectangleF(0, targetH - 24, targetW, 18), sf)
                    End Using
                End Using
            End Using
        End Using
        Return bmp
    End Function

    Private Sub SelectDeveloperPhoto(devNum As Integer, pic As PictureBox, initials As String)
        Using ofd As New OpenFileDialog()
            ofd.Title = $"Select Photo for Developer {devNum}"
            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files (*.*)|*.*"
            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    Directory.CreateDirectory(DevFolder)
                    For Each oldFile In Directory.GetFiles(DevFolder, $"dev{devNum}.*")
                        Try : File.Delete(oldFile) : Catch : End Try
                    Next
                    Dim ext = Path.GetExtension(ofd.FileName)
                    Dim destPath = Path.Combine(DevFolder, $"dev{devNum}{ext}")
                    File.Copy(ofd.FileName, destPath, overwrite:=True)
                    SettingsRepository.SetValue($"Dev{devNum}_PhotoPath", destPath)

                    pic.Image?.Dispose()
                    pic.Image = BannerHelper.LoadImage(destPath)
                    MessageBox.Show("Developer photo updated successfully!", "Photo Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Failed to save photo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub picDev1_Click(sender As Object, e As EventArgs) Handles picDev1.Click
        SelectDeveloperPhoto(1, picDev1, "AB")
    End Sub

    Private Sub btnDev1Photo_Click(sender As Object, e As EventArgs) Handles btnDev1Photo.Click
        SelectDeveloperPhoto(1, picDev1, "AB")
    End Sub

    Private Sub picDev2_Click(sender As Object, e As EventArgs) Handles picDev2.Click
        SelectDeveloperPhoto(2, picDev2, "RP")
    End Sub

    Private Sub btnDev2Photo_Click(sender As Object, e As EventArgs) Handles btnDev2Photo.Click
        SelectDeveloperPhoto(2, picDev2, "RP")
    End Sub

End Class


