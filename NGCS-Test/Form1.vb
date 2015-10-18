Imports NGCS_Test
Imports System.Web.Script.Serialization

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ngcs As New NGCS_Test.ngcs(My.Settings.apikey)
        Console.WriteLine(ngcs._servers.getServers()) 'Get all Servers
        Dim dict = New JavaScriptSerializer().Deserialize(Of List(Of ServerEntity))(ngcs._servers.getServers())
        For Each i In dict
            Console.WriteLine(ngcs._servers.getServer(i.id)) 'Write each Server out.
        Next

    End Sub
End Class
