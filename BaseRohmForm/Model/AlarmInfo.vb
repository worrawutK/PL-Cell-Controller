Public Class AlarmInfo

    Private c_Id As Integer
    Public Property Id() As Integer
        Get
            Return c_Id
        End Get
        Set(ByVal value As Integer)
            c_Id = value
        End Set
    End Property

    Private c_AlarmNo As Integer
    Public Property AlarmNo() As Integer
        Get
            Return c_AlarmNo
        End Get
        Set(ByVal value As Integer)
            c_AlarmNo = value
        End Set
    End Property

    Private c_AlarmMessage As String
    Public Property AlarmMessage() As String
        Get
            Return c_AlarmMessage
        End Get
        Set(ByVal value As String)
            c_AlarmMessage = value
        End Set
    End Property

    Private c_MachineType As String
    Public Property MachineType() As String
        Get
            Return c_MachineType
        End Get
        Set(ByVal value As String)
            c_MachineType = value
        End Set
    End Property
    Private c_AlarmType As String
    Public Property AlarmType() As String
        Get
            Return c_AlarmType
        End Get
        Set(ByVal value As String)
            c_AlarmType = value
        End Set
    End Property
End Class
