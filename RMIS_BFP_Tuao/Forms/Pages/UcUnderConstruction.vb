Public Class UcUnderConstruction
    Inherits UserControl

    Public Const CURRENT_VERSION As String = "v1.05"

    Private _pnlCenter As Panel
    Private _lblEmoji   As Label
    Private _lblTitle   As Label
    Private _lblVersion As Label
    Private _lblDesc    As Label

    Public Sub New()
        Me.BackColor = Color.FromArgb(26, 35, 126)
        Me.Dock = DockStyle.Fill

        _pnlCenter = New Panel() With {
            .Size      = New Size(580, 270),
            .BackColor = Color.Transparent
        }

        _lblEmoji = New Label() With {
            .Text      = "🚧",
            .Font      = New Font("Segoe UI Emoji", 52F, FontStyle.Regular),
            .ForeColor = Color.White,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Location  = New Point(0, 0),
            .Size      = New Size(580, 90)
        }

        _lblTitle = New Label() With {
            .Text      = "Under Construction",
            .Font      = New Font("Segoe UI", 26F, FontStyle.Bold),
            .ForeColor = Color.White,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Location  = New Point(0, 96),
            .Size      = New Size(580, 52)
        }

        _lblVersion = New Label() With {
            .Text      = "Current Version: " & CURRENT_VERSION,
            .Font      = New Font("Segoe UI", 12F, FontStyle.Regular),
            .ForeColor = Color.FromArgb(255, 160, 0),
            .TextAlign = ContentAlignment.MiddleCenter,
            .Location  = New Point(0, 154),
            .Size      = New Size(580, 34)
        }

        _lblDesc = New Label() With {
            .Text      = "This feature is not yet available in the current presentation version.",
            .Font      = New Font("Segoe UI", 9.5F, FontStyle.Regular),
            .ForeColor = Color.FromArgb(180, 190, 220),
            .TextAlign = ContentAlignment.MiddleCenter,
            .Location  = New Point(0, 194),
            .Size      = New Size(580, 28)
        }

        _pnlCenter.Controls.AddRange({_lblEmoji, _lblTitle, _lblVersion, _lblDesc})
        Me.Controls.Add(_pnlCenter)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        If _pnlCenter IsNot Nothing Then
            _pnlCenter.Location = New Point(
                Math.Max(0, (Me.Width  - _pnlCenter.Width)  \ 2),
                Math.Max(0, (Me.Height - _pnlCenter.Height) \ 2)
            )
        End If
    End Sub

End Class
