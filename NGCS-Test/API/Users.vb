Imports System.Web.Script.Serialization
Namespace NGCS_Wrapper
    Namespace API
        Public Class Users
            Inherits NGCS_Wrapper.ngcs
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

            Function getByID(uid As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function delete(uid As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function modify(uid As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function getAPIInfo(uid As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function enableAPI(uid As String, enable As Boolean)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function getAPIKey(uid As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function regenerateAPIKey(uid As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function getAllowedIPs(uid As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function addIP(uid As String, data As Specialized.HybridDictionary)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function removeIP(uid As String, ip As String)
                Try

                Catch ex As Exception

                End Try
            End Function
        End Class
    End Namespace
End Namespace

