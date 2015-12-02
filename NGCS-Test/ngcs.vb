Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Web.Script.Serialization
Imports NGCS_Test.NGCS_Wrapper.API
Namespace NGCS_Wrapper

    Public Class ngcs
        Protected Property _api As String
        Public url As String = “https://cloudpanel-api.1and1.com/v1/”


        Public Sub New(ByVal apikey As String)
            _api = apikey
        End Sub
        Public Function _servers() As Object
            Return New Servers(_api)
        End Function

        Public Function _Dvd()
            Return New DVD(_api)
        End Function
        Public Function _FirewallPolicy()
            Return New FirewallPolicy(_api)
        End Function
        Public Function _Image()
            Return New Images(_api)
        End Function
        Public Function _LoadBalancers()
            Return New LoadBalancers(_api)
        End Function
        Public Function _Logs()
            Return New Logs(_api)
        End Function
        Public Function _MonitorCenter()
            Return New MonitorCenter(_api)
        End Function
        Public Function _MonitoringPolicy()
            Return New MonitoringPolicy(_api)
        End Function
        Public Function _PrivateNetwork()
            Return New PrivateNetwork(_api)
        End Function
        Public Function _PublicIP()
            Return New PublicIP(_api)
        End Function
        Public Function _ServerAppliances()
            Return New ServerAppliances(_api)
        End Function
        Public Function _SharedStorages()
            Return New SharedStorage(_api)
        End Function
        Public Function _Usage()
            Return New Usage(_api)
        End Function
        Public Function _Users()
            Return New Users(_api)
        End Function

        Public Function _Roles()
            Return New Roles(_api)
        End Function

        Public Function _ping_auth()
            Return New pingtest(_api)
        End Function

        Public Function _get(ByVal _command As String)
            Dim request As HttpWebRequest = WebRequest.Create(url + _command)
            request.Method = "GET"
            request.Headers.Add("X-TOKEN", _api)

            'Call API
            Try
                Dim response As HttpWebResponse
                response = DirectCast(request.GetResponse, HttpWebResponse)
                Dim reader As New StreamReader(response.GetResponseStream)
                Return (reader.ReadToEnd)
            Catch e As WebException
                Return ("Status code: " + Convert.ToString(CType(e.Response, HttpWebResponse).StatusCode) + vbCrLf + "Message: " + e.Message + vbCrLf + request.Headers.ToString)
            End Try
        End Function
        Public Function _post(ByVal _command As String, ByVal data As Specialized.HybridDictionary)
            Dim responseFromServer As Byte() = Nothing
            Dim dataStream As Stream = Nothing
            Dim statuscode As New HttpStatusCode
            Dim response As WebResponse
            Try
                Dim request As WebRequest = WebRequest.Create(url + _command)

                request.Timeout = 120000
                request.Headers.Add("X-TOKEN", _api)
                request.Method = "POST"

                Dim content As String = New JavaScriptSerializer().Serialize(data).ToString
                Dim byteArray As Byte() = System.Text.Encoding.UTF8.GetBytes(content)

                request.ContentType = "application/json"

                request.ContentLength = byteArray.Length

                dataStream = request.GetRequestStream()

                dataStream.Write(byteArray, 0, byteArray.Length)

                dataStream.Close()



                response = request.GetResponse()

                'If response.Headers.Get("StatusCode") = HttpStatusCode.Accepted Then

                statuscode = response.Headers.Get("StatusCode")

                'End If

                dataStream.Close()

                response.Close()

                'statuscode = HttpStatusCode.OK

            Catch ex As WebException
                Return ("Status code: " + Convert.ToString(CType(ex.Response, HttpWebResponse).StatusCode) + vbCrLf + "Message: " + ex.Message + vbCrLf + response.Headers.ToString)


            Catch ex As Exception
                statuscode = HttpStatusCode.ExpectationFailed
            End Try
            Return statuscode
        End Function
        Public Function _delete(ByVal _command As String)
            Dim request As HttpWebRequest = WebRequest.Create(url + _command)
            request.Method = "DELETE"
            request.Headers.Add("X-TOKEN", _api)

            'Call API
            Try
                Dim response As HttpWebResponse
                response = DirectCast(request.GetResponse, HttpWebResponse)
                Dim reader As New StreamReader(response.GetResponseStream)
                Return (reader.ReadToEnd)
            Catch e As WebException
                Return ("Status code: " + Convert.ToString(CType(e.Response, HttpWebResponse).StatusCode) + vbCrLf + "Message: " + e.Message + vbCrLf + request.Headers.ToString)
            End Try
        End Function
        Public Function _PUT(ByVal _command As String, ByVal data As Specialized.HybridDictionary)
            Dim responseFromServer As Byte() = Nothing
            Dim dataStream As Stream = Nothing
            Dim statuscode As New HttpStatusCode
            Dim response As WebResponse
            Try
                Dim request As WebRequest = WebRequest.Create(url + _command)

                request.Timeout = 120000
                request.Headers.Add("X-TOKEN", _api)
                request.Method = "PUT"

                Dim content As String = New JavaScriptSerializer().Serialize(data).ToString
                Dim byteArray As Byte() = System.Text.Encoding.UTF8.GetBytes(content)

                request.ContentType = "application/json"

                request.ContentLength = byteArray.Length

                dataStream = request.GetRequestStream()

                dataStream.Write(byteArray, 0, byteArray.Length)

                dataStream.Close()



                response = request.GetResponse()

                'If response.Headers.Get("StatusCode") = HttpStatusCode.Accepted Then

                statuscode = response.Headers.Get("StatusCode")

                'End If

                dataStream.Close()

                response.Close()

                'statuscode = HttpStatusCode.OK

            Catch ex As WebException
                Return ("Status code: " + Convert.ToString(CType(ex.Response, HttpWebResponse).StatusCode) + vbCrLf + "Message: " + ex.Message + vbCrLf + response.Headers.ToString)
            Catch ex As Exception
                statuscode = HttpStatusCode.ExpectationFailed
            End Try
            Return statuscode
        End Function

        Public Function responseOK(ByVal status As HttpStatusCode)
            With status
                Select Case status
                    Case .Accepted
                        Return True
                    Case .Created
                        Return True
                    Case .OK
                        Return True
                    Case .MethodNotAllowed
                        Return "Method not allowed or Object not found!"
                    Case .InternalServerError
                        Return "There's been a server malfunction"
                End Select
            End With
        End Function
    End Class
    Public Class pingtest
        Inherits ngcs
        Public _pong As String
        Sub New(ByVal api As String)
            MyBase.New(api)
        End Sub
        Public Function pingit()
            Dim _command As String = "ping_auth"
            Dim request As HttpWebRequest = WebRequest.Create(MyBase.url + _command)
            request.Method = "GET"
            request.Headers.Add("X-TOKEN", _api)

            'Call API
            Try
                Dim response As HttpWebResponse
                response = DirectCast(request.GetResponse, HttpWebResponse)
                Dim reader As New StreamReader(response.GetResponseStream)
                Dim res = reader.ReadToEnd
                If res = "[""PONG""]" Then
                    Return True
                Else
                    Return False
                End If
            Catch e As WebException
                Return False
            End Try
        End Function

    End Class

End Namespace