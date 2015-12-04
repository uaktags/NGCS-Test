Namespace NGCS_Wrapper
    Namespace API
        Public Class MonitoringPolicy
            Inherits ngcs
            Dim url As String = “https://cloudpanel-api.1and1.com/v1/”
            Sub New(ByVal api As String)
                MyBase.New(api)
            End Sub
            Function getAll()
                Try

                Catch ex As Exception

                End Try
            End Function

            Function create(data As Specialized.HybridDictionary)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function getByID(mpid As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function delete(mpid As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function modify(mpid As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function getPorts(mpid As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function addPort(mpid As String, data As Specialized.HybridDictionary)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function getPort(mpid As String, port As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function removePort(mpid As String, port As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function ModifyPort(mpid As String, port As String, data As Specialized.HybridDictionary)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function getProcesses(mpid As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function addProcess(mpid As String, data As Specialized.HybridDictionary)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function getProcessInfo(mpid As String, proc As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function removeProcess(mpid As String, proc As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function modifyProcess(mpid As String, proc As String, data As Specialized.HybridDictionary)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function getServers(mpid As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function addServer(mpid As String, serverID As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function getServerInfo(mpid As String, serverID As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function removeServer(mpid As String, serverID As String)
                Try

                Catch ex As Exception

                End Try
            End Function
        End Class
    End Namespace
End Namespace