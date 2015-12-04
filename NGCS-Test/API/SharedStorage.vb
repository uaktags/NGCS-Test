Imports System.Web.Script.Serialization
Namespace NGCS_Wrapper
    Namespace API
        Public Class SharedStorage
            Inherits NGCS_Wrapper.ngcs
            Dim url As String = “https://cloudpanel-api.1and1.com/v1/”
            Sub New(ByVal api As String)
                MyBase.New(api)
            End Sub

            Function getall()

            End Function

            Function create()

            End Function

            Function getbyID(ssid As String)

            End Function

            Function delete(ssid As String)

            End Function

            Function modify(ssid As String, data As Specialized.HybridDictionary)

            End Function

            Function getAssignedServer(ssid As String)

            End Function

            Function assignServer(ssid As String, serverid As String)

            End Function

            Function getServerInfo(ssid As String, serverid As String)

            End Function

            Function removeServer(ssid As String, serverid As String)

            End Function

            Function getAccessRights(ssid As String)

            End Function

            Function modifyRights(ssid As String, data As Specialized.HybridDictionary)

            End Function
        End Class
    End Namespace
End Namespace

