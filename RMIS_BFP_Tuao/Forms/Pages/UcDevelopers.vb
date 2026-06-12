Public Class UcDevelopers
    Inherits UserControl

    Private Sub UcDevelopers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Application info
        lblAppName.Text    = "RMIS — BFP Tuao"
        lblAppDesc.Text    = "Record Management Information System" & Environment.NewLine &
                             "Bureau of Fire Protection — Tuao Fire Station"
        lblVersionVal.Text = "1.0.0"
        lblBuiltVal.Text   = "VB.NET · WinForms · .NET 8 · SQL Server"

        ' Developer 1
        lblDev1Name.Text = "Developer 1"
        lblDev1Role.Text = "System Architecture & UI Design"

        ' Developer 2
        lblDev2Name.Text = "Developer 2"
        lblDev2Role.Text = "Database & Records Module"

        ' Developer 3
        lblDev3Name.Text = "Developer 3"
        lblDev3Role.Text = "Reports & Documentation"
    End Sub

End Class
