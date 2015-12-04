Imports System.Web.Script.Serialization
Namespace NGCS_Wrapper
    Namespace API
        Public Class LoadBalancers
            Inherits NGCS_Wrapper.ngcs
            Dim url As String = “https://cloudpanel-api.1and1.com/v1/”
            Sub New(ByVal api As String)
                MyBase.New(api)
            End Sub

            Function getAll()

            End Function

            Function create()

            End Function

            Function getByID(lbid As String)

            End Function

            Function delete(lbid As String)

            End Function

            Function modify(lbid As String, data As Specialized.HybridDictionary)

            End Function

            Function getAssignedIPs(lbid As String)

            End Function

            Function addIP(lbid As String, ipid As String)

            End Function

            Function getIPInfo(lbid As String, ipid As String)

            End Function

            Function removeIP(lbid As String, ipid As String)

            End Function

            Function getRules(lbid As String)

            End Function

            Function addRule(lbid As String, data As Specialized.HybridDictionary)

            End Function

            Function getRule(lbid As String, ruleid As String)

            End Function

            Function deleteRule(lbid As String, ruleid As String)

            End Function
        End Class
    End Namespace
End Namespace

