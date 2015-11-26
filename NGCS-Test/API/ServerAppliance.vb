Public Class ServerAppliances
    Inherits NGCS_Wrapper.ngcs
    Dim url As String = “https://cloudpanel-api.1and1.com/v1/”
    Sub New(ByVal api As String)
        MyBase.New(api)
    End Sub
End Class
