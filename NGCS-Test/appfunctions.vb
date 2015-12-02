
Module appfunctions
        Public Function getFriendlyOS(ByVal imagename As String) As String
            With imagename
                If .Contains("w2008") Then
                    Return "Windows 2008"
                ElseIf .Contains("w2012")
                    Return "Windows 2012"
                ElseIf .Contains("centos6")
                    If .Contains("-64") Then
                        Return "CentOS 6 64bit"
                    Else
                        Return "CentOS 6 32bit"
                    End If
                ElseIf .Contains("centos7")
                    Return "CentOS 7"
                ElseIf .Contains("debian7")
                    If .Contains("-64") Then
                        Return "Debian 7 64bit"
                    Else
                        Return "Debian 7 32bit"
                    End If

                ElseIf .Contains("debian8")
                    Return "Debian 8"

                ElseIf .Contains("ubuntu1204")
                    If .Contains("-64") Then
                        Return "Ubuntu 12.04 64bit"
                    Else
                        Return "Ubuntu 12.04 32bit"
                    End If

                Else
                    Return imagename
                End If
            End With
        End Function


End Module