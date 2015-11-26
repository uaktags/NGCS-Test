Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Web.Script.Serialization
Imports NGCS_Test.NGCS_Wrapper.API
Namespace NGCS_Wrapper

    Public Class ngcs
        Protected Property _api As String
        Dim url As String = “https://cloudpanel-api.1and1.com/v1/”


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
    End Class
End Namespace