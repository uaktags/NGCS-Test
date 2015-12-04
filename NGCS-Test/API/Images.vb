Imports System.Web.Script.Serialization
Namespace NGCS_Wrapper
    Namespace API
        Public Class Images
            Inherits ngcs
            Dim _command As String = "images/"
            Sub New(ByVal api As String)
                MyBase.New(api)
            End Sub
            Function getAll()
                Dim _command As String = "images"
                Try
                    Return New JavaScriptSerializer().Deserialize(Of List(Of Entity.serverImage))(MyBase._get(_command))

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Function

            Function getbyID(ByVal id As String)
                Try
                    _command += id
                    Return New JavaScriptSerializer().Deserialize(Of List(Of Entity.serverImage))(MyBase._get(_command))
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Function

            Function create(ByVal Optional data As Specialized.HybridDictionary = Nothing, ByVal Optional server_id As String = "", ByVal Optional name As String = "", ByVal Optional description As String = "", ByVal Optional frequency As String = "", ByVal Optional num_images As Integer = 1)
                If data Is Nothing Then
                    data = New Specialized.HybridDictionary()
                    If server_id = "" Then
                        MsgBox("Missing ServerID in API.Images.Create")
                        Exit Function
                    Else
                        data.Add("server_id", server_id)
                    End If
                    If name = "" Then
                        MsgBox("Missing Name in API.Images.Create")
                        Exit Function
                    Else
                        data.Add("name", name)
                    End If
                    If description = Nothing Then
                        MsgBox("Missing Description in API.Images.Create")
                        Exit Function
                    Else
                        data.Add("description", description)
                    End If
                    If frequency = Nothing Then
                        MsgBox("Missing Frequency in API.Images.Create")
                        Exit Function
                    Else
                        data.Add("frequency", frequency)
                    End If
                    If num_images = Nothing Then
                        MsgBox("Missing Num_Images in API.Images.Create")
                        Exit Function
                    Else
                        data.Add("num_images", num_images)
                    End If
                Else
                    If data("server_id") = Nothing Then
                        If server_id = Nothing Then
                            MsgBox("Missing ServerID in API.Images.Create")
                            Exit Function
                        Else
                            data.Add("server_id", server_id)
                        End If
                    End If
                    If data("name") = Nothing Then
                        If name = Nothing Then
                            MsgBox("Missing Name in API.Images.Create")
                            Exit Function
                        Else
                            data.Add("name", name)
                        End If
                    End If
                    If data("description") = Nothing Then
                        If description = Nothing Then
                            MsgBox("Missing Description in API.Images.Create")
                            Exit Function
                        Else
                            data.Add("description", description)
                        End If
                    End If
                    If data("frequency") = Nothing Then
                        If frequency = Nothing Then
                            MsgBox("Missing Frequency in API.Images.Create")
                            Exit Function
                        Else
                            data.Add("frequency", frequency)
                        End If
                    End If
                    If data("num_images") = Nothing Then
                        If num_images = Nothing Then
                            MsgBox("Missing Num_Images in API.Images.Create")
                            Exit Function
                        Else
                            data.Add("num_images", num_images)
                        End If
                    End If
                End If
                Try
                    Dim res = responseOK(MyBase._post("images", data))
                    If TypeOf (res) Is Boolean Then
                        Return res
                    Else
                        MsgBox(res.ToString)
                    End If

                Catch ex As Exception
                    MsgBox(ex.StackTrace.ToString + vbCrLf + ex.Message)

                End Try
            End Function

            Public Function deleteImage(imgid As String)
                Try

                Catch ex As Exception

                End Try
            End Function

            Public Function modify(imgid As String, data As Specialized.HybridDictionary)
                Try

                Catch ex As Exception

                End Try
            End Function
        End Class
    End Namespace
End Namespace