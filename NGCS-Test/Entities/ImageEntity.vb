Namespace NGCS_Wrapper
    Namespace Entity
        Public Class Image
            Private _id As String
            Private _name As String
            Private _osfamily As String
            Private _os As String
            Private _osversion As String
            Private _architecture As Integer
            Private _osimagetype As String
            Private _type As String
            Private _minhddsize As Integer
            Private _licenses As List(Of String)
            Private _cloudpanelid As String
            Private _state As String
            Private _description As String
            Private _hdds As harddrives
            Private _serverid As String
            Private _frequency As String
            Private _numimages As Integer
            Private _creationdate As String

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

            Public Property os_family() As String
                Get
                    Return _osfamily
                End Get
                Set(value As String)
                    _osfamily = value
                End Set
            End Property

            Public Property os() As String
                Get
                    Return _os
                End Get
                Set(value As String)
                    _os = value
                End Set
            End Property

            Public Property os_version() As String
                Get
                    Return _osversion
                End Get
                Set(value As String)
                    _osversion = value
                End Set
            End Property

            Public Property architecture() As Integer
                Get
                    Return _architecture
                End Get
                Set(value As Integer)
                    _architecture = value
                End Set
            End Property

            Public Property os_image_type() As String
                Get
                    Return _osimagetype
                End Get
                Set(value As String)
                    _osimagetype = value
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

            Public Property min_hdd_size() As Integer
                Get
                    Return _minhddsize
                End Get
                Set(value As Integer)
                    _minhddsize = value
                End Set
            End Property

            Public Property licenses() As List(Of String)
                Get
                    Return _licenses
                End Get
                Set(value As List(Of String))
                    _licenses = value
                End Set
            End Property

            Public Property cloudpanel_id() As String
                Get
                    Return _cloudpanelid
                End Get
                Set(value As String)
                    _cloudpanelid = value
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

            Public Property description() As String
                Get
                    Return _description
                End Get
                Set(value As String)
                    _description = value
                End Set
            End Property

            Public Property hdds() As harddrives
                Get
                    Return _hdds
                End Get
                Set(value As harddrives)
                    _hdds = value
                End Set
            End Property

            Public Property server_id() As String
                Get
                    Return _serverid
                End Get
                Set(value As String)
                    _serverid = value
                End Set
            End Property

            Public Property frequency() As String
                Get
                    Return _frequency
                End Get
                Set(value As String)
                    _frequency = value
                End Set
            End Property

            Public Property num_images() As Integer
                Get
                    Return _numimages
                End Get
                Set(value As Integer)
                    _numimages = value
                End Set
            End Property

            Public Property creation_date() As String
                Get
                    Return _creationdate
                End Get
                Set(value As String)
                    _creationdate = value
                End Set
            End Property
            Public Property status() As String
                Get
                    MsgBox("here")
                End Get
                Set(value As String)
                    MsgBox("there")
                End Set
            End Property
        End Class
    End Namespace
End Namespace