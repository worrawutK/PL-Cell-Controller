Imports XtraLibrary.SecsGem
Public Class S2F15
    Inherits SecsMessageBase

    Private m_Ln As SecsItemList

    Public Sub New()
        MyBase.New(2, 15, True)
        m_Ln = New SecsItemList("Ln")
        AddItem(m_Ln)
    End Sub

    Public Sub AddListEcid(ByVal ecid As UInteger, ByVal ecv As String)
        Dim ecidItem As SecsItemU4 = New SecsItemU4("ECID" & m_Ln.Value.Count.ToString(), ecid)
        Dim ecvItem As SecsItemAscii = New SecsItemAscii("ECV" & m_Ln.Value.Count.ToString(), ecv)
        Dim l2 As SecsItemList = New SecsItemList("L2")
        l2.AddItem(ecidItem)
        l2.AddItem(ecvItem)
        m_Ln.AddItem(l2)
    End Sub
End Class
