Namespace NGCS_Wrapper
    Namespace Entity
        Public Class Server
            Private _ID As String
            Private _CloudPanelID As String
            Private _name As String
            Private _description As String
            Private _creation_date As String
            Private _password As String
            Private _status As ServerStatus
            Private _image As serverImage
            Private _dvd As DVD
            Private _snapshot As Snapshots
            Private _ips As List(Of serverIP)
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


            Public Property hardware() As hardwareEntity
                Get
                    Return _hardware
                End Get
                Set(value As hardwareEntity)
                    _hardware = value
                End Set
            End Property

            Public Property status() As ServerStatus
                Get
                    Return _status
                End Get
                Set(value As ServerStatus)
                    _status = value
                End Set
            End Property

            Public Property description() As String
                Get
                    Return _description
                End Get
                Set(value As String)
                    If value = "" Then
                        _description = CStr(value)
                    Else
                        _description = value
                    End If

                End Set
            End Property

            Public Property image() As serverImage
                Get
                    Return _image
                End Get
                Set(value As serverImage)
                    _image = value
                End Set
            End Property
            Public Property ips() As List(Of serverIP)
                Get
                    Return _ips
                End Get
                Set(value As List(Of serverIP))
                    _ips = value
                End Set
            End Property

            Public Property initial_password() As String
                Get
                    Return _password
                End Get
                Set(value As String)
                    _password = value
                End Set
            End Property

            Public ReadOnly Property ram() As String
                Get
                    Return _hardware.ram
                End Get
            End Property

            Public ReadOnly Property vcores() As String
                Get
                    Return _hardware.vcore
                End Get
            End Property
        End Class

        Public Class hardwareEntity
            Private _vcore As Integer
            Private _cores_per_processor As Integer
            Private _ram As String
            Private _hdds As List(Of harddrives)
            Public Property vcore As Integer
                Get
                    Return _vcore
                End Get
                Set(value As Integer)
                    _vcore = value
                End Set
            End Property

            Public Property hdds As List(Of harddrives)
                Get
                    Return _hdds
                End Get
                Set(value As List(Of harddrives))
                    _hdds = value
                End Set
            End Property

            Public Property ram As String
                Get
                    Return _ram
                End Get
                Set(value As String)
                    _ram = value
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

        Public Class DVD

        End Class

        Public Class Snapshots
            Private _id As String
            Private _creation_date As String
            Private _deletion_date As String
            Public Property id() As String
                Get
                    Return _id
                End Get
                Set(value As String)
                    _id = value
                End Set
            End Property

            Public Property creation_date() As String
                Get
                    Return _creation_date
                End Get
                Set(value As String)
                    _creation_date = value
                End Set
            End Property

            Public Property deletion_date() As String
                Get
                    Return _deletion_date
                End Get
                Set(value As String)
                    _deletion_date = value
                End Set
            End Property
        End Class

        Public Class Size
            Private _name As String
            Private _id As String
            Private _hardware As hardwareEntity
            Public Property name() As String
                Get
                    Return _name
                End Get
                Set(value As String)
                    _name = value
                End Set
            End Property

            Public Property id() As String
                Get
                    Return _id
                End Get
                Set(value As String)
                    _id = value
                End Set
            End Property

            Public Property hardware() As hardwareEntity
                Get
                    Return _hardware
                End Get
                Set(value As hardwareEntity)
                    _hardware = value
                End Set
            End Property
        End Class

        Public Class Status
            Private _state As String
            Private _percent As Integer
            Public Property state As String
                Get
                    Return _state
                End Get
                Set(value As String)
                    _state = value
                End Set
            End Property

            Public Property percent As Integer
                Get
                    Return _percent
                End Get
                Set(value As Integer)
                    _percent = value
                End Set
            End Property
        End Class

        Public Class Servers
            Private _ID As String
            Private _name As String
            Private _status As ServerStatus
            Private _image As serverImage
            Private _hardware As hardwareEntity
            Private _ips As List(Of serverIP)

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


            Public Property hardware() As hardwareEntity
                Get
                    Return _hardware
                End Get
                Set(value As hardwareEntity)
                    _hardware = value
                End Set
            End Property

            Public Property status() As ServerStatus
                Get
                    Return _status
                End Get
                Set(value As ServerStatus)
                    _status = value
                End Set
            End Property

            Public Property image() As serverImage
                Get
                    Return _image
                End Get
                Set(value As serverImage)
                    _image = value
                End Set
            End Property
            Public Property ips() As List(Of serverIP)
                Get
                    Return _ips
                End Get
                Set(value As List(Of serverIP))
                    _ips = value
                End Set
            End Property
        End Class

        Public Class serverImage
            Private _id As String
            Private _name As String
            Public Property id() As String
                Get
                    Return _id
                End Get
                Set(value As String)
                    _id = value
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
        End Class

        Public Class serverIP
            Private _firewallpolicy As FirewallPolicy
            Private _id As String
            Private _ip As String
            Private _loadbalancer As List(Of LoadBalancer)
            Private _reversedns As String
            Private _type As String
            Public Property firewall_policy() As FirewallPolicy
                Get
                    Return _firewallpolicy
                End Get
                Set(value As FirewallPolicy)
                    _firewallpolicy = value
                End Set
            End Property

            Public Property id() As String
                Get
                    Return _id
                End Get
                Set(value As String)
                    _id = value
                End Set
            End Property

            Public Property ip() As String
                Get
                    Return _ip
                End Get
                Set(value As String)
                    _ip = value
                End Set
            End Property

            Public Property load_balancers() As List(Of LoadBalancer)
                Get
                    Return _loadbalancer
                End Get
                Set(value As List(Of LoadBalancer))
                    _loadbalancer = value
                End Set
            End Property

            Public Property reverse_dns() As String
                Get
                    Return _reversedns
                End Get
                Set(value As String)
                    _reversedns = value
                End Set
            End Property

            Public Property type() As String
                Get
                    Return _type
                End Get
                Set(value As String)
                    _type = value
                End Set
            End Property
        End Class
    End Namespace
End Namespace