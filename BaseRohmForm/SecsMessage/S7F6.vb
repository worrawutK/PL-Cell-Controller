Imports XtraLibrary.SecsGem

Public Class S7F6
    Inherits SecsMessageBase

    Private m_L15 As New SecsItemList("L15")

    Private m_PPID As New SecsItemAscii("PPID")
    Private m_PPBODY As New SecsItemBinary("PPBODY")

    Public Sub New()
        MyBase.New(7, 6, True)
        Me.AddItem(m_L15)
        m_L15.AddItem(m_PPID)
        m_L15.AddItem(m_PPBODY)

    End Sub

    Public ReadOnly Property PPID() As String
        Get
            Return m_PPID.Value
        End Get
    End Property

    Public ReadOnly Property PPBody() As Byte()
        Get
            Return m_PPBODY.Value
        End Get
    End Property

End Class
