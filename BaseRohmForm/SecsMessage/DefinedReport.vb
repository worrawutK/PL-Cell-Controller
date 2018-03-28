Public Class DefinedReport

    Private m_RPTID As UInt32
    Public Property RPTID() As UInt32
        Get
            Return m_RPTID
        End Get
        Set(ByVal value As UInt32)
            m_RPTID = value
        End Set
    End Property

    Private m_SVIDList As List(Of UInt32)
    Public ReadOnly Property SVIDList() As List(Of UInt32)
        Get
            Return m_SVIDList
        End Get
    End Property

    Public Sub New()
        m_SVIDList = New List(Of UInt32)
    End Sub

End Class
