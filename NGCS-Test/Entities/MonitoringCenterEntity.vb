Namespace NGCS_Wrapper
    Namespace Entity
        Namespace MonitoringCenter
            Class MonitoringCenterBrief
                Private _id As String
                Private _name As String
                Private _status As status
                Private _alerts As alerts
                Private _agent As List(Of agents)

                Public Property id As String
                    Get
                        Return _id
                    End Get
                    Set(value As String)
                        _id = value
                    End Set
                End Property
                Public Property name As String
                    Get
                        Return _name
                    End Get
                    Set(value As String)
                        _name = value
                    End Set
                End Property
                Public Property status As status
                    Get
                        Return _status
                    End Get
                    Set(value As status)
                        _status = value
                    End Set
                End Property
                Public Property alerts As alerts
                    Get
                        Return _alerts
                    End Get
                    Set(value As alerts)
                        _alerts = value
                    End Set
                End Property
                Public Property agent As List(Of agents)
                    Get
                        Return _agent
                    End Get
                    Set(value As List(Of agents))
                        _agent = value
                    End Set
                End Property
                '{
                '  "id" "ABA6F4C16FE9893B09B354A4CF6321DF",
                '  "name": "My Server remame",
                '  "status:{},
                '   "alerts": {
                '  },
                '  "agent": {

                '  }
                '},
            End Class
            Public Class status
                Private _state As String
                Private _cpu As state
                Private _ram As state
                Private _disk As state
                Private _transfer As state
                Private _internal_ping As state
                Public Property state As String
                    Get
                        Return _state
                    End Get
                    Set(value As String)
                        _state = value
                    End Set
                End Property

                Public Property cpu As state
                    Get
                        Return _cpu
                    End Get
                    Set(value As state)
                        _cpu = value
                    End Set
                End Property
                Public Property ram As state
                    Get
                        Return _ram
                    End Get
                    Set(value As state)
                        _ram = value
                    End Set
                End Property
                Public Property disk As state
                    Get
                        Return _disk
                    End Get
                    Set(value As state)
                        _disk = value
                    End Set
                End Property
                Public Property transfer As state
                    Get
                        Return _transfer
                    End Get
                    Set(value As state)
                        _transfer = value
                    End Set
                End Property
                Public Property internal_ping As state
                    Get
                        Return _internal_ping
                    End Get
                    Set(value As state)
                        _internal_ping = value
                    End Set
                End Property
                '"status": {
                '    "state": "POWERED_ON",
                '    "cpu": {
                '       "state": "CPU usage: OK - CPU_Total 0% used: CPU0 0% used"
                '     },
                '     "ram": {
                '       "state": "RAM usage: OK 789MB (39%) used"
                '     },
                '     "disk": {
                '       "state": "Disk usage: OK C: 12.04GB (30%) used"
                '     },
                '     "transfer": {
                '        "state": "Network traffic: OK - 0 Kbps received: 0 Kbps transmitted:"
                '      },
                '      "internal_ping": {
                '        "state": "OK - 10.4.141.242: rta 0.671ms, lost 0%"
                '      }
                '   },
            End Class

            Public Class state
                Private _state As String
                Public Property state As String
                    Get
                        Return _state
                    End Get
                    Set(value As String)
                        _state = value
                    End Set
                End Property

            End Class

            Public Class alerts
                Private _resources As alert
                Private _port As alert
                Private _process As alert
                Public Property resources As alert
                    Get
                        Return _resources
                    End Get
                    Set(value As alert)
                        _resources = value
                    End Set
                End Property
                Public Property ports As alert
                    Get
                        Return _port
                    End Get
                    Set(value As alert)
                        _port = value
                    End Set
                End Property
                Public Property process As alert
                    Get
                        Return _process
                    End Get
                    Set(value As alert)
                        _process = value
                    End Set
                End Property
                '    "resources": {
                '      "critical": 1,
                '      "warning": 0,
                '      "ok": 3
                '    },
                '    "ports": {
                '      "critical": 0,
                '      "warning": 0,
                '      "ok": 0
                '    },
                '    "process": {
                '      "critical": 0,
                '      "warning": 0,
                '      "ok": 0
                '    }
            End Class

            Public Class alert
                Private _critical As Integer
                Private _warning As Integer
                Private _okay As Integer
                Public Property critical As Integer
                    Get
                        Return _critical
                    End Get
                    Set(value As Integer)
                        _critical = value
                    End Set
                End Property
                Public Property warning As Integer
                    Get
                        Return _warning
                    End Get
                    Set(value As Integer)
                        _warning = value
                    End Set
                End Property
                Public Property okay As Integer
                    Get
                        Return _okay
                    End Get
                    Set(value As Integer)
                        _okay = value
                    End Set
                End Property

            End Class

            Public Class agents
                Private _agent_installed As Boolean
                Private _monitoring_needs_agent As Boolean
                Private _missing_agent_alert As Boolean
                Public Property agent_installed As Boolean
                    Get
                        Return _agent_installed
                    End Get
                    Set(value As Boolean)
                        _agent_installed = value
                    End Set
                End Property

                Public Property monitoring_needs_agent As Boolean
                    Get
                        Return _monitoring_needs_agent
                    End Get
                    Set(value As Boolean)
                        _monitoring_needs_agent = value
                    End Set
                End Property

                Public Property missing_agent_alert As Boolean
                    Get
                        Return _missing_agent_alert
                    End Get
                    Set(value As Boolean)
                        _missing_agent_alert = value
                    End Set
                End Property
                '    "agent_installed": false,
                '    "monitoring_needs_agent": false,
                '    "missing_agent_alert": false
            End Class

            Public Class monitoringCenterExtended
                '               {
                ' "id": "BDAF0EC6A36E9E554B80B7E7365821F5",
                ' "name": "My Server 1",
                ' "status": {
                '   "state": "POWERED_ON"
                ' },
                ' "alerts_count": {
                '   "resources": {
                '     "critical": 0,
                '     "warning": 0,
                '     "ok": 4
                '   },
                '   "ports": {
                '     "critical": 0,
                '     "warning": 0,
                '     "ok": 0
                '   },
                '   "process": {
                '     "critical": 0,
                '     "warning": 0,
                '     "ok": 0
                '   }
                ' },
                ' "agent": {
                '   "agent_installed": false,
                '   "monitoring_needs_agent": false,
                '   "missing_agent_alert": false
                ' },
                ' "cpu": {
                '   "warning": 90,
                '   "critical": 95,
                '   "data": [
                '   {
                '     "date": "2015-19-05T00:05:00Z",
                '     "used_percent": 0.4011
                '   }
                '   ],
                '   "unit": {
                '     "used_percent": "%"
                '   },
                '   "status": "CPU usage: OK - CPU_Total 0% used: CPU0 0% used"
                ' },
                ' "ram": {
                '   "warning": 90,
                '   "critical": 95,
                '   "data": [
                '   {
                '     "date": "2015-19-05T00:05:00Z",
                '     "used_percent": 1.99
                '   },
                '   ],
                '   "unit": {
                '     "used_percent": "%"
                '   },
                '   "status": "RAM usage: OK 789MB (39%) used"
                ' },
                ' "transfer": {
                '   "warning": 1000,
                '   "critical": 2000,
                '   "data": [
                '   {
                '     "date": "2015-19-05T00:05:00Z",
                '     "downstream": 0,
                '     "upstream": 0
                '   }
                '   ],
                '   "unit": {
                '     "downstream": "bps",
                '     "upstream": "bps"
                '   },
                '   "status": "Network traffic: OK - 0 Kbps received: 0 Kbps transmitted:"
                '  },
                '  "internal_ping": {
                '    "warning": 50,
                '    "critical": 100,
                '    "data": [
                '    {
                '      "date": "2015-19-05T00:05:00Z",
                '      "pl": 100,
                '      "rta": 0
                '    }
                '    ],
                '    "unit": {
                '      "pl": "%",
                '      "rta": "ms"
                '    },
                '    "status": "OK - 10.4.141.242: rta 0.657ms, lost 0%"
                '  }
                '}
            End Class
            Public Class alertExtended

            End Class
        End Namespace
    End Namespace
End Namespace