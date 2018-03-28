Imports XtraLibrary.SecsGem

Public Class S2F33
    Inherits SecsMessageBase

    Private m_L2 As SecsItemList
    Private m_DataId As SecsItemU4
    Private m_La As SecsItemList

    'Comment: a=0 means delete all reports and event links, b=0 means delete the RPTID type and its event links

    Public Sub New(ByVal dataId As UInt32)
        MyBase.New(2, 33, True)

        m_L2 = New SecsItemList("L2")
        Me.AddItem(m_L2)

        m_DataId = New SecsItemU4("DATAID", dataId)
        m_L2.AddItem(m_DataId)

        m_La = New SecsItemList("La")
        m_L2.AddItem(m_La)

    End Sub

    Public Sub SetDeleteAllReport()
        m_La.Clear() 'a=0 means delete all reports and event links
    End Sub

    <Obsolete()> _
    Public Sub SetReportToDelete(ByVal ParamArray rptIdArray As UInt32())

        For Each rptId As UInt32 In rptIdArray
            Dim l2 As SecsItemList = New SecsItemList("L2")
            m_La.AddItem(l2)

            Dim rptIdItem As SecsItemU4 = New SecsItemU4("RPTID", rptId)
            l2.AddItem(rptIdItem)

            Dim lbItem As SecsItemList = New SecsItemList("Lb") 'b=0 means delete the RPTID type and its event links
            l2.AddItem(lbItem)

        Next

    End Sub

    Public Sub AddReport(ByVal rptId As UInt32, ByVal ParamArray vidArray As UInt32())

        Dim l2 As SecsItemList = New SecsItemList("L2")
        m_La.AddItem(l2)

        Dim rptIdItem As SecsItemU4 = New SecsItemU4("RPTID", rptId)
        l2.AddItem(rptIdItem)

        Dim lbItem As SecsItemList = New SecsItemList("Lb")
        l2.AddItem(lbItem)

        For Each vid As UInt32 In vidArray
            lbItem.AddItem(New SecsItemU4("VID", vid))
        Next

    End Sub

End Class
