Namespace NGCS_Wrapper
    Namespace Entity
        Public Class ServerStatus
            Public _state As String
            Public _percent As String

            Public Property state As String
                Get
                    Return _state
                End Get
                Set(value As String)
                    _state = value
                End Set
            End Property

            Public Property percent As String
                Get
                    Return _percent
                End Get
                Set(value As String)
                    _percent = value
                End Set
            End Property
        End Class
    End Namespace
End Namespace

