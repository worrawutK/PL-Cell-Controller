Imports XtraLibrary.SecsGem

Public Class S2F35
    Inherits SecsMessageBase

    Private m_L2 As SecsItemList
    Private m_DataId As SecsItemU4
    Private m_La As SecsItemList

    Public Sub New(ByVal dataId As UInt32)
        MyBase.New(2, 35, True)

        m_L2 = New SecsItemList("L2")
        Me.AddItem(m_L2)

        m_DataId = New SecsItemU4("DATAID", dataId)
        m_L2.AddItem(m_DataId)

        m_La = New SecsItemList("La")
        m_L2.AddItem(m_La)
    End Sub

    Public Sub AddLink(ByVal ceid As UInt32, ByVal ParamArray rptidArray As UInt32())
        Dim l2Item As SecsItemList = New SecsItemList("L2")
        m_La.AddItem(l2Item)

        Dim ceidItem As SecsItemU4 = New SecsItemU4("CEID", ceid)
        l2Item.AddItem(ceidItem)

        Dim lbItem As SecsItemList = New SecsItemList("Lb")
        l2Item.AddItem(lbItem)

        Dim rptidItem As SecsItemU4
        For Each rptid As UInt32 In rptidArray
            rptidItem = New SecsItemU4("RPTID", rptid)
            lbItem.AddItem(rptidItem)
        Next
    End Sub

    Public Sub DisassosiateLink(ByVal ceid As UInt32)

        Dim l2Item As SecsItemList = New SecsItemList("L2")
        m_La.AddItem(l2Item)

        Dim ceidItem As SecsItemU4 = New SecsItemU4("CEID")
        l2Item.AddItem(ceidItem)

        Dim lbItem As SecsItemList = New SecsItemList("Lb")
        l2Item.AddItem(lbItem)

    End Sub

End Class
