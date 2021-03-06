﻿Imports NGCS_Test

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
                    Dim servers = _ngcs.Servers.getServers()
                    Console.WriteLine(servers)
                    DataGridView1.Rows.Clear()
                    Parallel.ForEach(servers.cast(Of Object), Function(i As NGCS_Wrapper.Entity.Server)
                                                     Me.Invoke(Sub()
                                                                   Dim srv As DataGridViewRow = DataGridView1.Rows(0).Clone
                                                                   srv.Cells.Item(0).Value = i.name
                                                                   Dim ipcount, cur As Integer
                                                                   cur = 0
                                                                   ipcount = i.ips.Count
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
                                                                   srv.Tag = _ngcs.Servers.getServer(i.id)
                                                                   DataGridView1.Rows.Add(srv)
                                                               End Sub)
                                                     Return Nothing
                                                 End Function)

                'For Each i In servers
                '       Dim srv As DataGridViewRow = DataGridView1.Rows(0).Clone
                'srv.Cells.Item(0).Value = i.name
                'Dim ipcount, cur As Integer
                'cur = 0
                'ipcount = i.ips.Count
                'For Each ip As NGCS_Wrapper.Entity.serverIP In i.ips
                'If cur = (ipcount - 1) Then
                'srv.Cells.Item(1).Value = srv.Cells.Item(1).Value + ip.ip
                'Else
                'srv.Cells.Item(1).Value = srv.Cells.Item(1).Value + ip.ip + ", "
                'cur = cur + 1
                'End If
                '           Next
                '
                'srv.Cells.Item(2).Value = appfunctions.getFriendlyOS(i.image.name)
                'srv.Cells.Item(3).Value = i.status.state
                'srv.Tag = _ngcs.Servers.getServer(i.id)
                'DataGridView1.Rows.Add(srv)
                'Next
                Case 2

                                                  Case Else

            End Select
        End If
    End Function

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
        Dim srv As NGCS_Wrapper.Entity.Server = DataGridView1.CurrentRow.Tag
        serverNameLabel.Text = srv.name
        serverDesc.Text = srv.description
        If srv.status.state = "POWERED_ON" Then
            StartToolStripMenuItem.Enabled = False
            serverStatus.Text = "Running"
        ElseIf srv.status.state = "POWERED_OFF" Then
            StopToolStripMenuItem.Enabled = False
            serverStatus.Text = "Off"
        Else
            serverStatus.Text = srv.status.state
        End If

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
        serverIPs.Items.Clear()

        For Each ips In srv.ips
            serverIPs.Items.Add(ips)
        Next
        serverIPs.DisplayMember = "ip"
        serverCores.Text = srv.vcores
        serverRam.Text = srv.ram
        Button5.Enabled = True
        Button5.Tag = srv.id
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ActionsMenuStrip.Show(Button5, 0, Button5.Height)
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        _ngcs.Servers.restartServer(Button5.Tag.ToString)
    End Sub

    Private Sub CreateImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateImageToolStripMenuItem.Click
        Dim srv = Button5.Tag
        If _ngcs.Image.create(Nothing, srv.id, "FirstImage", "some IMAGE i made", "WEEKLY", 1) = True Then
            changestatus("Image Created")
        Else
            changestatus("Image failed to create")
        End If
    End Sub

    Private Sub HardwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HardwareToolStripMenuItem.Click
        _ngcs.Servers.stopServer(Button5.Tag.ToString)
    End Sub

    Private Sub SoftwareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoftwareToolStripMenuItem.Click
        _ngcs.Servers.stopServer(Button5.Tag.ToString, False)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Show a new window for the Server Creation wizard.")
    End Sub
End Class
