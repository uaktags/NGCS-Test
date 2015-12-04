Imports System.Web.Script.Serialization
Namespace NGCS_Wrapper
    Namespace API
        Public Class PrivateNetwork
            Inherits NGCS_Wrapper.ngcs
            Dim url As String = “https://cloudpanel-api.1and1.com/v1/”
            Sub New(ByVal api As String)
                MyBase.New(api)
            End Sub

            Function getAll()

            End Function

            Function create(data As Specialized.HybridDictionary)

            End Function

            Function getByID(pnid As String)

            End Function

            Function delete(pnid As String)

            End Function

            Function modify(pnid As String)

            End Function

            Function getAssignedServers(pnid As String)

            End Function

            Function addServer(pnid As String, serverID As String)

            End Function

            Function getServerInfo(pnid As String, serverID As String)

            End Function

            Function removeServer(pnid As String, serverID As String)

            End Function
        End Class
    End Namespace
End Namespace
