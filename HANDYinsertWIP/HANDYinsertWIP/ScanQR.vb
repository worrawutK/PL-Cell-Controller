Public Class ScanQR
    Public Data As String


    Private Sub ScanQR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case Status
            Case StatusQR.OPNo
                Label1.Text = "SCAN OP No."
            Case StatusQR.Delete
                Label1.Text = "Delete Lot " & vbCrLf & " SCAN QR Code"
            Case StatusQR.Again
                Label1.Text = "กรุณา Scan อีกครั้ง"
            Case StatusQR.NoLotCart
                Label1.Text = "ไม่มีงานในรถคันนี้"
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class