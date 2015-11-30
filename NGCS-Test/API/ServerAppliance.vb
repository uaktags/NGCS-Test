Imports System.Web.Script.Serialization
Namespace NGCS_Wrapper
    Namespace API
        Public Class ServerAppliances
            Inherits ngcs
            Dim _command As String = "server_appliances/"
            Sub New(ByVal api As String)
                MyBase.New(api)
            End Sub
            Function getAll()
                Dim _command As String = "server_appliances"
                Try
                    Return New JavaScriptSerializer().Deserialize(Of List(Of Entity.ServerAppliance))(MyBase._get(_command))

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Function

            Function getbyID(ByVal id As String)
                Try
                    _command += id
                    Return New JavaScriptSerializer().Deserialize(Of List(Of Entity.ServerAppliance))(MyBase._get(_command))
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Function
        End Class
    End Namespace
End Namespace
