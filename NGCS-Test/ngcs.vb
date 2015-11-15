Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Web.Script.Serialization

Public Class ngcs
    Protected Property _api As String
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

End Class



Public Class hardwareEntity
    Private _hdds As List(Of Harddrives)
    Public Property hdds As List(Of harddrives)
        Get
            Return _hdds
        End Get
        Set(value As List(Of harddrives))
            _hdds = value
        End Set
    End Property
End Class

Public Class harddrives
    Private _id As String
    Private _size As String
    Private _main As Boolean

    Public Property id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property size As String
        Get
            Return _size
        End Get
        Set(value As String)
            _size = value
        End Set
    End Property

    Public Property is_main As String
        Get
            Return _main
        End Get
        Set(value As String)
            _main = CBool(value)
        End Set
    End Property
End Class