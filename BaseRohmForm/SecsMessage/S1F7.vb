Imports XtraLibrary.SecsGem

Public Class S1F17
    Inherits SecsMessageBase

    Private m_Ln As SecsItemList

    Public Sub New()
        MyBase.New(1, 17, True)

        'm_Ln = New SecsItemList("Ln")
        'AddItem(m_Ln)

    End Sub


End Class
