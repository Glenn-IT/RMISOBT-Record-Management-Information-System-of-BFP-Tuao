Imports System.Windows.Forms

Namespace My

    ''' <summary>
    ''' Sets the process DPI awareness mode.
    '''
    ''' This project uses the VB Application Framework (Application.myapp,
    ''' MySubMain=False), so startup goes through WindowsFormsApplicationBase
    ''' rather than ApplicationConfiguration.Initialize(). Two consequences:
    '''
    '''  * The &lt;ApplicationHighDpiMode&gt; MSBuild property does nothing here. It is
    '''    only read by a Roslyn source generator, and the net8.0 WinForms ref pack
    '''    ships a C#-only generator (analyzers/dotnet has a cs/ folder but no vb/).
    '''  * Declaring dpiAwareness in app.manifest does not work either — the
    '''    framework calls Application.SetHighDpiMode() itself during OnInitialize,
    '''    defaulting to SystemAware, and the analyzer flags the conflict (WFAC010).
    '''
    ''' So the supported hook is the framework's own HighDpiMode property, set here
    ''' before MyBase.OnInitialize consumes it. PerMonitorV2 lets the UI re-lay out
    ''' correctly when the window moves to a display with different scaling — e.g.
    ''' a projector — instead of being bitmap-stretched and going blurry.
    '''
    ''' This is a separate partial class because Application.Designer.vb is
    ''' auto-generated and would lose any edit made there.
    ''' </summary>
    Partial Friend Class MyApplication

        Protected Overrides Function OnInitialize(
            commandLineArgs As Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean

            Me.HighDpiMode = HighDpiMode.PerMonitorV2
            Return MyBase.OnInitialize(commandLineArgs)
        End Function

    End Class

End Namespace
