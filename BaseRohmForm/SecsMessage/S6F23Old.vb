Imports XtraLibrary.SecsGem
'Purge Spooling
Public Class S6F23Old
    Inherits SecsMessageBase

    Private m_ACKC6 As SecsItemU1

    Public Sub New()
        MyBase.New(6, 23, True)

        m_ACKC6 = New SecsItemU1("ACK6", 1) 'OK only
        AddItem(m_ACKC6)

    End Sub

End Class
