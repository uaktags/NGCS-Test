Imports NGCS_Test

Public Class Form1
    Dim _currentpanel As Integer
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count <> 0 Then
            hideallpanels()
            Select Case ListView1.SelectedItems.Item(0).Text
                Case "Servers"
                    serverPanel.Show()
                    refreshAPI("servers")
                Case 2
                    MsgBox("You clicked 2?")
                Case Else
                    MsgBox(ListView1.SelectedItems.Item(0).Text)
            End Select
        End If
    End Sub
    Private Function hideallpanels()
        serverPanel.Hide()
        PublicIPPanel.Hide()
        FirewallPanel.Hide()
        SharedStoragePanel.Hide()
        LoadBalancerPanel.Hide()
        ImagesPanel.Hide()
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideallpanels()
        ListView1.Items(0).Selected = 1
    End Sub

    Private Function refreshAPI(ByVal Optional all As String = "")
        Dim ngcs As New NGCS_Test.ngcs(My.Settings.apikey)
        If all <> "" Then
            Select Case all
                Case "servers"
                    Dim servers = ngcs._servers.getServers()
                    Console.WriteLine(servers)
                    For Each i In servers
                        'Console.WriteLine(i) 'Get all Servers
                        Dim serv As New ListViewItem
                        serv.Text = i.name
                        serv.Tag = i
                        serversView.Items.Add(serv)
                    Next
                Case 2

                Case Else

            End Select
        End If
    End Function

    Private Sub serversView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles serversView.SelectedIndexChanged
        If serversView.SelectedItems.Count > 0 Then
            specsPanels.Visible = True
            Dim srv = serversView.SelectedItems.Item(0).Tag
            serverNameLabel.Text = srv.name
            serverDesc.Text = srv.description
            serverStatus.Text = srv.status.state
            For Each i In srv.hardware.hdds
                Dim size As String
                If i.is_main = True Then
                    size = "Main: " + i.size + "GB"
                Else
                    size = "Additional: " + i.size + "GB"
                End If
                harddriveList.Items.Add(size)
            Next

        Else
            harddriveList.Items.Clear()
            serverNameLabel.Text = ""
            serverDesc.Text = ""
            serverStatus.Text = ""
            specsPanels.Visible = False
        End If

    End Sub
End Class
