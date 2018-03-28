<Serializable()> _
Public Class Equipment
    Private m_DeviceId As UShort
    Public Property DeviceId() As UShort
        Get
            Return m_DeviceId
        End Get
        Set(ByVal value As UShort)
            m_DeviceId = value
        End Set
    End Property

    Private m_CurrentPPID As String
    Public Property CurrentPPID() As String
        Get
            Return m_CurrentPPID
        End Get
        Set(ByVal value As String)
            m_CurrentPPID = value
        End Set
    End Property

    Private m_ControlState As ControlStateType
    Public Property ControlState() As ControlStateType
        Get
            Return m_ControlState
        End Get
        Set(ByVal value As ControlStateType)
            m_ControlState = value

        End Set
    End Property
    Private m_EQStatus As EquipmentState
    Public Property EQStatus() As EquipmentState
        Get
            Return m_EQStatus
        End Get
        Set(ByVal value As EquipmentState)
            m_EQStatus = value
        End Set
    End Property

End Class
