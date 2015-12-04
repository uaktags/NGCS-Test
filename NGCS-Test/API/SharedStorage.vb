Imports System.Web.Script.Serialization
Namespace NGCS_Wrapper
    Namespace API
        Public Class SharedStorage
            Inherits NGCS_Wrapper.ngcs
            Dim _command As String = “shared_storages/”
            Sub New(ByVal api As String)
                MyBase.New(api)
            End Sub

            Function getall()
                Try
                    _command = "shared_storages"
                    Return New JavaScriptSerializer().Deserialize(Of List(Of NGCS_Wrapper.Entity.sharedstorages))(MyBase._get(_command))
                Catch ex As Exception

                End Try
            End Function

            Function create(data As Specialized.HybridDictionary)
                Try
                    _command = "shared_storages"
                    MyBase._post(_command)
                Catch ex As Exception

                End Try
            End Function

            Function getbyID(ssid As String)
                Try
                    _command += ssid
                    Return New JavaScriptSerializer().Deserialize(Of NGCS_Wrapper.Entity.sharedstorages)(MyBase._get(_command))
                Catch ex As Exception

                End Try
            End Function

            Function delete(ssid As String)
                Try
                    _command += ssid
                    MyBase._delete(_command)

                Catch ex As Exception

                End Try
            End Function

            Function modify(ssid As String, data As Specialized.HybridDictionary)
                Try
                    _command += ssid
                   MyBase._put(_command)
                Catch ex As Exception

                End Try
            End Function

            Function getAssignedServer(ssid As String)
                Try
                    _command += ssid + "/servers"
                    ' Return New JavaScriptSerializer().Deserialize(Of NGCS_Wrapper.Entity.sharedstorages)(MyBase._get(_command))
                    '''
                    '{
                    '"id" "C72CF0A681B0CCE7EC624DD194D585C6",
                    '"name": "My Server",
                    ' "rights": "RW"
                    '},
                    '''
                Catch ex As Exception

                End Try
            End Function

            Function assignServer(ssid As String, data As Specialized.HybridDictionary)
                Try
                    MyBase._post(_command + ssid + "/servers", data)
                Catch ex As Exception

                End Try
            End Function

            Function getServerInfo(ssid As String, serverid As String)
                Try
                    _command += ssid + "/servers/" + serverid
                    ' Return New JavaScriptSerializer().Deserialize(Of NGCS_Wrapper.Entity.sharedstorages)(MyBase._get(_command))
                    '{
                    '  "id" "638ED28205B1AFD7ADEF569C725DD85F",
                    '  "name": "Mi servidor 1",
                    '  "rights": "RW"
                    '}
                Catch ex As Exception

                End Try
            End Function

            Function removeServer(ssid As String, serverid As String)
                Try
                    MyBase._delete(_command + ssid + "/servers/" + serverid)
                Catch ex As Exception

                End Try
            End Function

            Function getAccessRights(ssid As String)
                Try
                    _command += ssid + "/access"
                    ' Return New JavaScriptSerializer().Deserialize(Of NGCS_Wrapper.Entity.sharedstorages)(MyBase._get(_command))
                    '{
                    '    "state" "CONFIGURING",
                    '    "kerberos_content_file": "BQIAAABSAAIACERFVjEuTEFOAANuZnMAEnVpZDYyNDQ2OC5kZXYxLmxhbgAAAAEAAAAAAwASACDoMmqCQE8L1/Kcur6pzBRM+DDT+lELrKHRIPSM966n5w==",
                    '    "user_domain": "dev1\\uid624468"
                    '}
                Catch ex As Exception

                End Try
            End Function

            Function modifyRights(ssid As String, data As Specialized.HybridDictionary)
                Try
                    _command += ssid + "/access"
                    MyBase._PUT(_command, data)
                Catch ex As Exception

                End Try
            End Function
        End Class
    End Namespace
End Namespace

