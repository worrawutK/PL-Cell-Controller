Imports XtraLibrary.SecsGem
Public Class S2F13
    Inherits SecsMessageBase

    Private m_Ln As SecsItemList

    Public Sub New()
        MyBase.New(2, 13, True)
        m_Ln = New SecsItemList("Ln")
        AddItem(m_Ln)
    End Sub

    Public Sub AddEcid(ByVal ecid As UInteger)
        Dim ecidItem As SecsItemU4 = New SecsItemU4("ECID" & m_Ln.Value.Count.ToString(), ecid)
        m_Ln.AddItem(ecidItem)
    End Sub


End Class
