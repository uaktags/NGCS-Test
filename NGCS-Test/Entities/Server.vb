Public Class ServerEntity
    Private _ID As String
    Private _name As String
    Private _harddrives As List(Of Object)
    Private _hardware As hardwareEntity
    Public Property id() As String
        Get
            Return _ID
        End Get
        Set(value As String)
            _ID = value
        End Set
    End Property
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property hdds() As List(Of Object)
        Get
            Return _harddrives
        End Get
        Set(value As List(Of Object))
            _harddrives = value
        End Set
    End Property

    Public Property hardware As hardwareEntity
        Get
            Return _hardware
        End Get
        Set(value As hardwareEntity)
            _hardware = value
        End Set
    End Property
End Class