Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).
    Dim timeout As Integer = 10

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timeout > 0 Then
            ProgressBar1.Increment(10)
            timeout = timeout - 1
        End If
        Dim api As String
        If timeout <= 0 Then
            Timer1.Enabled = False
            If My.Settings.apikey <> "" Then
                api = My.Settings.apikey
                GoTo cont
            Else

Back:
                api = InputBox("What is your API Token?", "API")

                If api = "" Then
                    Me.Dispose()
                ElseIf api = " " Then
                    MsgBox("You must enter an API to continue, otherwise Exit.")
                    GoTo Back
                Else
                    GoTo cont
                End If
                Exit Sub
TryAgain:
                api = InputBox("Invalid API, please try again! What is your API Token?", "Invalid API")

                If api = "" Then
                    Me.Dispose()
                ElseIf api = " " Then
                    MsgBox("You must enter an API to continue, otherwise Exit.")
                    GoTo Back
                End If

            End If
            Exit Sub
cont:
            Dim ngcs As New NGCS_Wrapper.ngcs(api)
            Dim ping = ngcs.ping_auth()
            Dim res = ping.pingit()
            If res = True Then
                My.Settings.apikey = api
                My.Settings.Save()
                Form1.Show()
                Me.Hide()
                Exit Sub
            Else
                GoTo TryAgain
            End If
        End If
    End Sub
End Class
