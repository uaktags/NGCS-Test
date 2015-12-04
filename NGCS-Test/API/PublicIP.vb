Imports System.Web.Script.Serialization
Namespace NGCS_Wrapper
    Namespace API
        Public Class PublicIP
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

            Function create()
                Try

                Catch ex As Exception

                End Try
            End Function

            Function getByID(ipid As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function delete(ipid As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Function modify(ipid As String, data As Specialized.HybridDictionary)
                Try

                Catch ex As Exception

                End Try
            End Function
        End Class
    End Namespace
End Namespace
