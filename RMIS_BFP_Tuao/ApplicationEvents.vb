Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Try
                DatabaseInitializer.Initialize()
            Catch ex As Exception
                MessageBox.Show(
                    "Could not connect to the database." & Environment.NewLine &
                    ex.Message & Environment.NewLine & Environment.NewLine &
                    "Make sure config.txt exists next to the .exe with a valid connection string.",
                    "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Cancel = True
            End Try
        End Sub

    End Class
End Namespace
