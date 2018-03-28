


Public Class SecsGeemFrmEdit
    Private SEC_Hex As SECSGEM
    Private strHexResult As String
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        strHexResult = txtResult.Text
        Me.Hide()
    End Sub

    Public Function DisplaySecMessage(ByVal strHex As String) As String
        clearControl()
        txtHexFormat.Text = strHex
        ShowSML(strHex)
        Me.ShowDialog()

        If strHexResult <> "" Then
            Return strHexResult
        Else
            Return Nothing
        End If

    End Function
    Private Sub ShowSML(ByVal mHex As String)

        SEC_Hex = New SECSGEM(ConvertStringToByte(mHex), CType(TypeOfSECSMSG.HSMS, SECSMSG_Header.TypeOfSECSMSG))
        SEC_Hex.SMLConvert()
        rtxtSecMsg.Text = (SEC_Hex.SMLOutput)

        txtStream.Text = CStr(SEC_Hex.Sec_Stream)
        txtFunction.Text = CStr(SEC_Hex.Sec_Function)
        cbxWBit.Checked = SEC_Hex.Sec_wBit

    End Sub

    Private Sub clearControl()
        Me.txtHexFormat.Text = ""
        Me.txtResult.Text = ""
        Me.rtxtSecMsg.Text = ""
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        strHexResult = ""
        Me.Hide()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            'Mid(txtHexFormat.Text, 13, 30) &
            Dim ret As Byte() = SEC_Hex.SMLRevert(rtxtSecMsg.Text)
            Dim sLenByte As String
            sLenByte = Convert.ToString((ret.Length + 10), 16).ToUpper
            sLenByte = sLenByte.PadLeft(8, "0"c)
            Dim sLen As String = ""
            For i As Integer = 0 To 7 Step 2
                sLen += sLenByte.Substring(i, 2) + " "
            Next

            If SEC_Hex.Header Is Nothing Then
                SEC_Hex.Header = New Byte() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            End If

            If cbxWBit.Checked = True Then
                SEC_Hex.Header(2) = CByte(128 + CInt(txtStream.Text))
            Else
                SEC_Hex.Header(2) = CByte(txtStream.Text)
            End If
            SEC_Hex.Header(3) = CByte(txtFunction.Text)

            txtResult.Text = sLen + ConvToString(SEC_Hex.Header) + ConvToString(ret)
        Catch ex As Exception

        End Try

    End Sub
End Class