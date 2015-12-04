Imports System.Web.Script.Serialization
Namespace NGCS_Wrapper
    Namespace API
        Public Class FirewallPolicy
            Inherits NGCS_Wrapper.ngcs
            Dim _command As String = "firewall_policies/"
            Sub New(ByVal api As String)
                MyBase.New(api)
            End Sub

            ''' <summary>
            ''' /firewall_policies
            ''' GET
            ''' </summary>
            ''' <returns></returns>
            Public Function getall()
                Dim _command As String = "firewall_policies"
            End Function

            ''' <summary>
            ''' /firewall_policies
            ''' POST
            ''' </summary>
            ''' <returns></returns>
            Public Function create()
            End Function

            ''' <summary>
            ''' firewall_policies/{firewall_id}
            ''' GET
            ''' </summary>
            ''' <param name="fwid"></param>
            ''' <returns></returns>
            Public Function getbyID(fwid As String)

            End Function

            ''' <summary>
            ''' firewall_policies/{firewall_id}
            ''' DELETE
            ''' </summary>
            ''' <param name="fwid"></param>
            ''' <returns></returns>
            Public Function delete(fwid As String)

            End Function

            ''' <summary>
            ''' firewall_policies/{firewall_id}
            ''' PUT
            ''' </summary>
            ''' <param name="fwid"></param>
            ''' <param name="data"></param>
            ''' <returns></returns>
            Public Function modify(fwid As String, data As Specialized.HybridDictionary)

            End Function

            ''' <summary>
            ''' /firewall_policies/{firewall_id}/server_ips
            ''' GET
            ''' </summary>
            ''' <param name="fwid"></param>
            ''' <returns></returns>
            Public Function getIPs(fwid As String)

            End Function

            ''' <summary>
            ''' /firewall_policies/{firewall_id}/server_ips
            ''' POST
            ''' </summary>
            ''' <param name="fwid"></param>
            ''' <param name="ipid"></param>
            ''' <returns></returns>
            Public Function assignIP(fwid As String, ipid As String)

            End Function

            ''' <summary>
            ''' /firewall_policies/{firewall_id}/server_ips/{server_ip}
            ''' GET
            ''' </summary>
            ''' <param name="fwid"></param>
            ''' <param name="ipid"></param>
            ''' <returns></returns>
            Public Function getAssignedIP(fwid As String, ipid As String)

            End Function

            ''' <summary>
            ''' /firewall_policies/{firewall_id}/server_ips/{server_ip}
            ''' DELETE
            ''' </summary>
            ''' <param name="fwid"></param>
            ''' <param name="ipid"></param>
            ''' <returns></returns>
            Public Function removeIP(fwid As String, ipid As String)

            End Function

            ''' <summary>
            ''' /firewall_policies/{firewall_id}/rules
            ''' GET
            ''' </summary>
            ''' <param name="fwid"></param>
            ''' <returns></returns>
            Public Function getRules(fwid As String)

            End Function

            ''' <summary>
            ''' /firewall_policies/{firewall_id}/rules
            ''' POST
            ''' </summary>
            ''' <param name="fwid"></param>
            ''' <param name="data"></param>
            ''' <returns></returns>
            Public Function addRule(fwid As String, data As Specialized.HybridDictionary)

            End Function

            ''' <summary>
            ''' /firewall_policies/{firewall_id}/rules/{rule_id}
            ''' GET
            ''' </summary>
            ''' <param name="fwid"></param>
            ''' <param name="ruleid"></param>
            ''' <returns></returns>
            Public Function getRule(fwid As String, ruleid As String)

            End Function

            ''' <summary>
            ''' /firewall_policies/{firewall_id}/rules/{rule_id}
            ''' DELETE
            ''' </summary>
            ''' <param name="fwid"></param>
            ''' <param name="ruleid"></param>
            ''' <returns></returns>
            Public Function removeRule(fwid As String, ruleid As String)

            End Function
        End Class
    End Namespace
End Namespace
