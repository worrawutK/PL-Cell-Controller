Imports XtraLibrary.SecsGem

Public Class S2F14
    Inherits SecsMessageBase
    Private m_List As SecsItemList

    Public Sub New()
        MyBase.New(2, 14, False)
        m_List = New SecsItemList("Ln")
        AddItem(m_List)
    End Sub


    Public Function GetECVs() As String()

        Dim ECVList As List(Of String) = New List(Of String)
        For Each item As SecsItem In m_List.Value
            ECVList.Add(DirectCast(item.Value, String))
        Next
        Return ECVList.ToArray()

    End Function
End Class
