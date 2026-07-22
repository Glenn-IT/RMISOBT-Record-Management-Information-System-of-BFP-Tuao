Imports System.Runtime.CompilerServices

''' <summary>
''' DPI helpers for metrics that WinForms' own auto-scaling does not touch.
'''
''' Forms and user controls in this project declare
''' <c>AutoScaleMode = AutoScaleMode.Font</c>, which scales every child control's
''' Location, Size, Padding and Margin to match the current DPI. DataGridView is
''' the exception: its ColumnHeadersHeight, RowTemplate.Height and RowHeadersWidth
''' are plain pixel properties that Control.Scale leaves untouched, so at 150%
''' scaling the grids would keep 96 DPI row heights while everything around them
''' grew by half again.
''' </summary>
Public Module DpiHelper

    ' Design-time (96 DPI) baselines, captured the first time a grid is seen so
    ' that repeated calls recompute from the original values instead of
    ' compounding. Weak keys let disposed grids be collected normally.
    Private ReadOnly Baselines As New ConditionalWeakTable(Of DataGridView, GridMetrics)

    Private Class GridMetrics
        Public ColumnHeadersHeight As Integer
        Public RowHeight As Integer
        Public RowHeadersWidth As Integer
    End Class

    ''' <summary>
    ''' Scales a grid's header/row metrics to the DPI it is currently displayed at.
    ''' Safe to call more than once (e.g. again after the window moves to a monitor
    ''' with different scaling) — it always recomputes from the design-time values.
    ''' Call from the hosting control's Load handler, once the grid has a handle and
    ''' DeviceDpi reports the real DPI.
    ''' </summary>
    <Extension>
    Public Sub ApplyDpiScaling(dgv As DataGridView)
        If dgv Is Nothing Then Return

        Dim baseline As GridMetrics = Baselines.GetValue(
            dgv,
            Function(g) New GridMetrics With {
                .ColumnHeadersHeight = g.ColumnHeadersHeight,
                .RowHeight = g.RowTemplate.Height,
                .RowHeadersWidth = g.RowHeadersWidth
            })

        Dim factor As Single = dgv.DeviceDpi / 96.0F
        If factor <= 0 Then Return

        dgv.ColumnHeadersHeight = CInt(Math.Round(baseline.ColumnHeadersHeight * factor))
        dgv.RowTemplate.Height = CInt(Math.Round(baseline.RowHeight * factor))
        dgv.RowHeadersWidth = CInt(Math.Round(baseline.RowHeadersWidth * factor))

        ' RowTemplate only applies to rows created from here on, so bring any rows
        ' that already exist up to the same height.
        For Each row As DataGridViewRow In dgv.Rows
            row.Height = dgv.RowTemplate.Height
        Next
    End Sub

End Module
