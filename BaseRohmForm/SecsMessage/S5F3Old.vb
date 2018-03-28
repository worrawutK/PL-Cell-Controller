Imports XtraLibrary.SecsGem

Public Class S5F3Old
    Inherits SecsMessageBase

    Private m_L2 As SecsItemList
    Private m_ALED As SecsItemBinary
    Private m_ALID As SecsItemU2

    'Public Sub New(ByVal Enable As Boolean, ByVal ALID As UInteger)
    '    MyBase.New(5, 3, True)
    '    Dim m_ALID As New SecsItemU4("ALID")
    '    If Not ALID = Nothing Then
    '        m_ALID.Value(0) = ALID
    '    End If
    '    Dim m_ALED As New SecsItemBinary("ALED", &H80)
    '    If Not Enable Then
    '        m_ALED.Value(0) = &H0
    '    End If
    '    Dim M_LIST As New SecsItemList("L2")
    '    AddItem(M_LIST)
    '    M_LIST.AddItem(m_ALED)
    '    M_LIST.AddItem(m_ALID)

    'End Sub

    Public Sub New()
        MyBase.New(5, 3, True)
        m_L2 = New SecsItemList("L2")
        AddItem(m_L2)
    End Sub

    Public Sub AlarmEnableAll()
        m_ALED = New SecsItemBinary("B1", New Byte() {&HFF})
        m_L2.AddItem(m_ALED)
        m_ALID = New SecsItemU2("ALID")
        m_ALID.Value = Nothing  'เหมือนกัน
        m_L2.AddItem(m_ALID)
    End Sub

    Public Sub AlarmDisableAll()
        m_ALED = New SecsItemBinary("B1", New Byte() {&H0})
        m_L2.AddItem(m_ALED)
        m_ALID = New SecsItemU2("ALID", Nothing) 'เหมือนกัน
        m_L2.AddItem(m_ALID)
    End Sub

End Class
