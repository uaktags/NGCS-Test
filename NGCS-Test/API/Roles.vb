Imports System.Web.Script.Serialization
Namespace NGCS_Wrapper
    Namespace API
        Public Class Roles
            Inherits NGCS_Wrapper.ngcs
            Dim url As String = “https://cloudpanel-api.1and1.com/v1/”
            Sub New(ByVal api As String)
                MyBase.New(api)
            End Sub

            Sub getAll()

            End Sub

            Sub getByID(roleID As String)

            End Sub

            Sub getUsers(roleID As String)

            End Sub


        End Class
    End Namespace
End Namespace

