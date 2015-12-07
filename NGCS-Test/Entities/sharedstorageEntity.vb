Namespace NGCS_Wrapper
    Namespace Entity
        Public Class SharedStorage
            Private _ID As String
            Private _name As String
            Private _description As String
            Private _state As String
            Private _creation_date As String
            Private _default As Boolean
            Private _rules As List(Of sharedStorageRules)
            Private _serverIPs As List(Of serverIP)
            Private _cloudpanel_id As String
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

            Public Property description() As String
                Get
                    Return _description
                End Get
                Set(value As String)
                    _description = value
                End Set
            End Property
            Public Property state() As String
                Get
                    Return _state
                End Get
                Set(value As String)
                    _state = value
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
            Public Property defaults() As Boolean
                Get
                    Return _default
                End Get
                Set(value As Boolean)
                    _default = value
                End Set
            End Property
            Public Property rules() As List(Of sharedStorageRules)
                Get
                    Return _rules
                End Get
                Set(value As List(Of sharedStorageRules))
                    _rules = value
                End Set
            End Property

            Public Property server_ips() As List(Of serverIP)
                Get
                    Return _serverIPs
                End Get
                Set(value As List(Of serverIP))
                    _serverIPs = value
                End Set
            End Property

            Public Property cloudpanel_id() As String
                Get
                    Return _cloudpanel_id
                End Get
                Set(value As String)
                    _cloudpanel_id = value
                End Set
            End Property
            '{
            '  "id" "83522FC7DA9172F229E5352C587075BA",
            '  "name": "My firewall policy test",
            '  "description": "My firewall policy description",
            '  "state": "CONFIGURING",
            '  "creation_date": "2015-04-29T10:43:11+00:00",
            '  "default": 0,
            '  "rules": [
            '  {
            '    "id": "DA5CC179ED00079AE7DE595F0073D86E",
            '    "protocol": "TCP",
            '    "port_from": 80,
            '    "port_to": 80,
            '    "source": "0.0.0.0"
            '  },
            '],
            '  "server_ips" [],
            '  "cloudpanel_id": "FW99AA4_7"
        End Class

        Public Class sharedStorageRules
            Private _id As String
            Private _protocol As String
            Private _port_from As Integer
            Private _port_to As Integer
            Private _source As String

            Public Property id() As String
                Get
                    Return _id
                End Get
                Set(value As String)
                    _id = value
                End Set
            End Property

            Public Property protocol() As String
                Get
                    Return _protocol
                End Get
                Set(value As String)
                    _protocol = value
                End Set
            End Property
            Public Property port_from As Integer
                Get
                    Return _port_from
                End Get
                Set(value As Integer)
                    _port_from = value
                End Set
            End Property
            Public Property port_to As Integer
                Get
                    Return _port_to
                End Get
                Set(value As Integer)
                    _port_to = value
                End Set
            End Property
            Public Property source() As String
                Get
                    Return _source
                End Get
                Set(value As String)
                    _source = value
                End Set
            End Property

            '  {
            '    "id": "DA5CC179ED00079AE7DE595F0073D86E",
            '    "protocol": "TCP",
            '    "port_from": 80,
            '    "port_to": 80,
            '    "source": "0.0.0.0"
            '  },
        End Class

        Namespace sharedStorageNS
            Public Class servers
                Private _id As String
                Private _name As String
                Private _rights As String
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
                Public Property rights() As String
                    Get
                        Return _rights
                    End Get
                    Set(value As String)
                        _rights = value
                    End Set
                End Property
                '{
                '  "id" "638ED28205B1AFD7ADEF569C725DD85F",
                '  "name": "Mi servidor 1",
                '  "rights": "RW"
                '}
            End Class

            Public Class AccessRights
                Private _state As String
                Private _kerbose_content_file As String
                Private _user_domain As String

                Public Property state As String
                    Get
                        Return _state
                    End Get
                    Set(value As String)
                        _state = value
                    End Set
                End Property
                Public Property kerbose_content_file As String
                    Get
                        Return _kerbose_content_file
                    End Get
                    Set(value As String)
                        _kerbose_content_file = value
                    End Set
                End Property
                Public Property user_domain As String
                    Get
                        Return _user_domain
                    End Get
                    Set(value As String)
                        _user_domain = value
                    End Set
                End Property

                '{
                '    "state" "CONFIGURING",
                '    "kerberos_content_file": "BQIAAABSAAIACERFVjEuTEFOAANuZnMAEnVpZDYyNDQ2OC5kZXYxLmxhbgAAAAEAAAAAAwASACDoMmqCQE8L1/Kcur6pzBRM+DDT+lELrKHRIPSM966n5w==",
                '    "user_domain": "dev1\\uid624468"
                '}
            End Class
        End Namespace
    End Namespace
End Namespace