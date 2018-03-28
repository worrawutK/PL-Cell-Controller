﻿Imports XtraLibrary.SecsGem

Public Class S1F3
    Inherits SecsMessageBase

    Private m_Ln As SecsItemList

    Public Sub New()
        MyBase.New(1, 3, True)
        m_Ln = New SecsItemList("Ln")
        AddItem(m_Ln)
    End Sub

    Public Sub AddSvid(ByVal svid As UInteger)
        Dim svidItem As SecsItemU4 = New SecsItemU4("SVID" & m_Ln.Value.Count.ToString(), svid)
        m_Ln.AddItem(svidItem)
    End Sub


End Class
