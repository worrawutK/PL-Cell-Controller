Imports XtraLibrary.SecsGem

Public Class S1F4
    Inherits SecsMessageBase

    Private m_Ln As SecsItemList

    Public Sub New()
        MyBase.New(1, 4, False)
        m_Ln = New SecsItemList("Ln")
        AddItem(m_Ln)

    End Sub
    Private SVList As New List(Of String)
    Public ReadOnly Property SV As List(Of String)
        Get
            For Each item As SecsItem In m_Ln.Value
                If item.Format = FormatCode.U4 Then
                    Dim U4() As Integer = CType(item.Value, Integer())
                    SVList.Add(CType(U4(0), String))
                ElseIf item.Format = FormatCode.ASCII Then
                    SVList.Add(DirectCast(item.Value, String))
                Else
                    SVList.Add("'" & item.Format.ToString & "' Not include Convert Code")
                End If

            Next
            Return SVList
        End Get
    End Property

End Class
