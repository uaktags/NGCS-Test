Imports NGCS_Test
Imports System.Web.Script.Serialization

Public Class Form1
    Dim _currentpanel As Integer
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count <> 0 Then
            hideallpanels()
            Select Case ListView1.SelectedItems.Item(0).Text
                Case "Servers"
                    Panel1.Show()
                Case 2
                    MsgBox("You clicked 2?")
                Case Else
                    ListView1.Items.Item(0).Selected = True
            End Select
        End If
    End Sub
    Private Function hideallpanels()
        Panel1.Hide()
        PublicIPPanel.Hide()
        FWPanel.Hide()
        SharedStoragePanel.Hide()
        LoadBalancerPanel.Hide()
        ImagesPanel.Hide()
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideallpanels()
        Panel1.Show()
    End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    'Dim ngcs As New NGCS_Test.ngcs(My.Settings.apikey)
    '   Console.WriteLine(ngcs._servers.getServers()) 'Get all Servers
    'Dim dict = New JavaScriptSerializer().Deserialize(Of List(Of ServerEntity))(ngcs._servers.getServers())
    'For Each i In dict
    '       Console.WriteLine(ngcs._servers.getServer(i.id)) 'Write each Server out.
    'Next

    'End Sub
End Class
