Imports NGCS_Test

Public Class Form1
    Dim _currentpanel As Integer
    Dim _ngcs As New NGCS_Wrapper.ngcs("")
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count <> 0 Then
            hideallpanels()
            Select Case ListView1.SelectedItems.Item(0).Text
                Case "Servers"
                    hideallpanels()
                    serverPanel.Show()
                    refreshAPI("servers")
                Case 2
                    MsgBox("You clicked 2?")
                Case "Images"
                    hideallpanels()
                    imagesPanel.Show()
                    refreshAPI("images")
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
        _ngcs = New NGCS_Wrapper.ngcs(My.Settings.apikey)
        If all <> "" Then
            Select Case all
                Case "servers"
                    Dim servers = _ngcs._servers.getServers()
                    Console.WriteLine(servers)
                    '   serversView.Clear()
                    DataGridView1.Rows.Clear()

                    For Each i In servers
                        '  Dim serv As New ListViewItem
                        ' serv.Text = i.name
                        'serv.Tag = i
                        'serversView.Items.Add(serv)
                        Dim srv As DataGridViewRow = DataGridView1.Rows(0).Clone
                        srv.Cells.Item(0).Value = i.name
                        Dim ipcount, cur As Integer
                        cur = 0
                        ipcount = i.ips.count
                        For Each ip As NGCS_Wrapper.Entity.serverIP In i.ips
                            If cur = (ipcount - 1) Then
                                srv.Cells.Item(1).Value = srv.Cells.Item(1).Value + ip.ip
                            Else
                                srv.Cells.Item(1).Value = srv.Cells.Item(1).Value + ip.ip + ", "
                                cur = cur + 1
                            End If
                        Next

                        srv.Cells.Item(2).Value = appfunctions.getFriendlyOS(i.image.name)
                        srv.Cells.Item(3).Value = i.status.state
                        srv.Tag = i
                            DataGridView1.Rows.Add(srv)
                        Next
                        Case 2

                Case Else

            End Select
        End If
    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '    Dim srv = serversView.SelectedItems.Item(0).Tag
        ' '   If _ngcs._Image.create(Nothing, srv.id, "FirstImage", "some IMAGE i made", "WEEKLY", 1) = True Then
        '    changestatus("Image Created")
        '    Else
        '    changestatus("Image failed to create")
    '    End If
    End Sub

    Private Sub statustimer_Tick(sender As Object, e As EventArgs) Handles statustimer.Tick
        currentstatus.Text = ""
        statustimer.Enabled = False
    End Sub
    Private Function changestatus(ByVal status As String)
        statustimer.Enabled = False
        currentstatus.Text = status
        statustimer.Enabled = True
    End Function


    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        specsPanels.Visible = True
        Dim srv = DataGridView1.CurrentRow.Tag
        serverNameLabel.Text = srv.name
        'serverDesc.Text = srv.description
        serverStatus.Text = srv.status.state
        harddriveList.Items.Clear()
        For Each i In srv.hardware.hdds
            Dim size As String
            If i.is_main = True Then
                size = "Main: " + i.size + "GB"
            Else
                size = "Additional: " + i.size + "GB"
            End If
            harddriveList.Items.Add(size)
        Next
        Button5.Enabled = True
        Button5.Tag = srv.id
        If srv.status.state = "POWERED_ON" Then
            StartToolStripMenuItem.Enabled = False
        ElseIf srv.status.state = "POWERED_OFF" Then
            StopToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ActionsMenuStrip.Show(Button5, 0, Button5.Height)
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        _ngcs._servers.restartServer(Button5.Tag.ToString)
    End Sub

    Private Sub CreateImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateImageToolStripMenuItem.Click
        Dim srv = Button5.Tag
        If _ngcs._Image.create(Nothing, srv.id, "FirstImage", "some IMAGE i made", "WEEKLY", 1) = True Then
            changestatus("Image Created")
        Else
            changestatus("Image failed to create")
        End If
    End Sub

    Private Sub HardwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HardwareToolStripMenuItem.Click
        _ngcs._servers.stopServer(Button5.Tag.ToString)
    End Sub

    Private Sub SoftwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoftwareToolStripMenuItem.Click
        _ngcs._servers.stopServer(Button5.Tag.ToString, False)
    End Sub
End Class
