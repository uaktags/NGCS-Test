﻿Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Web.Script.Serialization

Public Class ngcs
    Protected Property _api As String
    Public Sub New(ByVal apikey As String)
        _api = apikey
    End Sub
    Public Function _servers() As Object
        Return New Servers(_api)
    End Function
End Class
Public Class Servers
    Inherits ngcs
    Dim url As String = “https://cloudpanel-api.1and1.com/v1/”
    Sub New(ByVal api As String)
        MyBase.New(api)
    End Sub
    Function getServers()
        'Create the request
        Dim _command As String = url + "servers"
        Dim request As HttpWebRequest = WebRequest.Create(_command)
        request.Method = "GET"
        request.Headers.Add("X-TOKEN", MyBase._api)

        'Call API
        Try
            Dim response As HttpWebResponse
            response = DirectCast(request.GetResponse, HttpWebResponse)
            Dim reader As New StreamReader(response.GetResponseStream)
            Return (reader.ReadToEnd)
        Catch e As WebException
            Return ("Status code: " + Convert.ToString(CType(e.Response, HttpWebResponse).StatusCode) + vbCrLf + "Message: " + e.Message + vbCrLf + request.Headers.ToString)
        End Try

    End Function

    Function getServer(ByVal serverID As String)
        'Create the request
        Dim _command As String = url + "servers/" + serverID
        Dim request As HttpWebRequest = WebRequest.Create(_command)
        request.Method = "GET"
        request.Headers.Add("X-TOKEN", MyBase._api)

        'Call API
        Try
            Dim response As HttpWebResponse
            response = DirectCast(request.GetResponse, HttpWebResponse)
            Dim reader As New StreamReader(response.GetResponseStream)
            Return (reader.ReadToEnd)
        Catch e As WebException
            Return ("Status code: " + Convert.ToString(CType(e.Response, HttpWebResponse).StatusCode) + vbCrLf + "Message: " + e.Message + vbCrLf + request.Headers.ToString)
        End Try
    End Function

End Class

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

Public Class hardwareEntity
    Private _hdds As List(Of Object)
    Public Property hdds As Object
        Get
            Return _hdds
        End Get
        Set(value As Object)
            +
            _hdds.Add(value)
        End Set
    End Property
End Class

