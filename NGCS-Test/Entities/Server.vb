Public Class ServerEntity
    Private _ID As String
    Private _name As String
    Private _description As String
    Private _status As serverStatusEntity
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


    Public Property hardware As hardwareEntity
        Get
            Return _hardware
        End Get
        Set(value As hardwareEntity)
            _hardware = value
        End Set
    End Property

    Public Property status As serverStatusEntity
        Get
            Return _status
        End Get
        Set(value As serverStatusEntity)
            _status = value
        End Set
    End Property

    Public Property description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property
End Class