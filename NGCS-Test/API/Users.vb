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

            End Function

            Function create(data As Specialized.HybridDictionary)

            End Function

            Function getByID(uid As String)

            End Function

            Function delete(uid As String)

            End Function

            Function modify(uid As String)

            End Function

            Function getAPIInfo(uid As String)

            End Function

            Function enableAPI(uid As String, enable As Boolean)

            End Function

            Function getAPIKey(uid As String)

            End Function

            Function regenerateAPIKey(uid As String)

            End Function

            Function getAllowedIPs(uid As String)

            End Function

            Function addIP(uid As String, data As Specialized.HybridDictionary)

            End Function

            Function removeIP(uid As String, ip As String)

            End Function
        End Class
    End Namespace
End Namespace

