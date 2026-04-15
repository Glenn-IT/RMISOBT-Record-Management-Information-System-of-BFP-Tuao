<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcDevelopers
    Inherits System.Windows.Forms.UserControl
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Private components As System.ComponentModel.IContainer
    Private Sub InitializeComponent()
        Dim lblPlaceholder As New Label()
        lblPlaceholder.Text = "Developers — Coming Soon"
        lblPlaceholder.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblPlaceholder.ForeColor = Color.Gray
        lblPlaceholder.AutoSize = False
        lblPlaceholder.Size = New Size(400, 50)
        lblPlaceholder.Location = New Point(24, 24)
        Me.BackColor = Color.FromArgb(240, 242, 245)
        Me.Controls.Add(lblPlaceholder)
        Me.ResumeLayout(False)
    End Sub
End Class
