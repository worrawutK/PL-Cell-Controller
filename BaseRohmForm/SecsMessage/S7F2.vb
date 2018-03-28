Imports XtraLibrary.SecsGem

Public Class S7F2
    Inherits SecsMessageBase

    Private m_IDTYP As New SecsItemBinary("IDTYP")

    Public Sub New()
        MyBase.New(7, 2, False)
        Me.AddItem(m_IDTYP)
    End Sub

    Public ReadOnly Property IDTYP() As Byte
        Get
            Return m_IDTYP.Value(0)
        End Get
    End Property

End Class
