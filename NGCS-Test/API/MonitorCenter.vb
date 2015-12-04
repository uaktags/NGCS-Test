Imports System.Web.Script.Serialization
Namespace NGCS_Wrapper
    Namespace API
        Public Class MonitorCenter
            Inherits NGCS_Wrapper.ngcs
            Dim url As String = “https://cloudpanel-api.1and1.com/v1/”
            Sub New(ByVal api As String)
                MyBase.New(api)
            End Sub
            Function getAll()

            End Function
            Function getByServer(serverID As String)

            End Function
        End Class
    End Namespace
End Namespace

