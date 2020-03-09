Public Class PLAlarmTable
    Private c_ID As Int32?

    Public Property ID As Int32?
        Get
            Return c_ID
        End Get
        Set(ByVal value As Int32?)
            c_ID = value
        End Set
    End Property

    Private c_AlarmNo As Int32?

    Public Property AlarmNo As Int32?
        Get
            Return c_AlarmNo
        End Get
        Set(ByVal value As Int32?)
            c_AlarmNo = value
        End Set
    End Property

    Private c_MachineType As String

    Public Property MachineType As String
        Get
            Return c_MachineType
        End Get
        Set(ByVal value As String)
            c_MachineType = value
        End Set
    End Property

    Private c_AlarmType As String

    Public Property AlarmType As String
        Get
            Return c_AlarmType
        End Get
        Set(ByVal value As String)
            c_AlarmType = value
        End Set
    End Property

    Private c_AlarmMessage As String

    Public Property AlarmMessage As String
        Get
            Return c_AlarmMessage
        End Get
        Set(ByVal value As String)
            c_AlarmMessage = value
        End Set
    End Property

    Private Sub Populate(ByVal row As DataRow)
        Me.ID = CType(row("ID"), Int32)
        Me.AlarmNo = CType(row("AlarmNo"), Int32)
        Me.MachineType = row("MachineType").ToString()
        Me.AlarmType = row("AlarmType").ToString()
        Me.AlarmMessage = row("AlarmMessage").ToString()
    End Sub

    Public Sub New(ByVal row As DataRow)
        Populate(row)
    End Sub

    Public Sub New()
    End Sub
End Class
