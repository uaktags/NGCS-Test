Namespace NGCS_Wrapper
    Namespace API
        Public Class MonitoringPolicy
            Inherits ngcs
            Dim url As String = “https://cloudpanel-api.1and1.com/v1/”
            Sub New(ByVal api As String)
                MyBase.New(api)
            End Sub
            Function getAll()

            End Function

            Function create(data As Specialized.HybridDictionary)

            End Function

            Function getByID(mpid As String)

            End Function

            Function delete(mpid As String)

            End Function

            Function modify(mpid As String)

            End Function

            Function getPorts(mpid As String)

            End Function

            Function addPort(mpid As String, data As Specialized.HybridDictionary)

            End Function

            Function getPort(mpid As String, port As String)

            End Function

            Function removePort(mpid As String, port As String)

            End Function

            Function ModifyPort(mpid As String, port As String, data As Specialized.HybridDictionary)

            End Function

            Function getProcesses(mpid As String)

            End Function

            Function addProcess(mpid As String, data As Specialized.HybridDictionary)

            End Function

            Function getProcessInfo(mpid As String, proc As String)

            End Function

            Function removeProcess(mpid As String, proc As String)

            End Function

            Function modifyProcess(mpid As String, proc As String, data As Specialized.HybridDictionary)

            End Function

            Function getServers(mpid As String)

            End Function

            Function addServer(mpid As String, serverID As String)

            End Function

            Function getServerInfo(mpid As String, serverID As String)

            End Function

            Function removeServer(mpid As String, serverID As String)

            End Function
        End Class
    End Namespace
End Namespace