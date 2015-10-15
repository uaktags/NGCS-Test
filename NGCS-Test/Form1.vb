Imports NGCS_Test
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ngcs As New NGCS_Test.ngcs("YOUR TOKEN")
        Console.WriteLine(ngcs._servers.getServers()) 'Get all Servers
        Console.WriteLine(ngcs._servers.getServer("217780B2E8BB1112BC39F6109E1D02C0")) 'Get Server By ID
    End Sub
End Class
