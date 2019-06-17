Public Class frmConfirm

    Dim _LotNo As String
    Dim _TotalInput As Integer
    Dim _TotalGood As Integer
    Dim _LotStartTime As String
    Dim _LotEndTime As String
    Dim _Magazine As String
    Public _FramePCS As Integer

    Dim TragetTextbox As TextBox
    Private Sub frmConfirm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbLotNo.Text = _LotNo
        lbStartTime.Text = _LotStartTime
        lbEndTime.Text = _LotEndTime

        lbPackage.Text = GetPackageFromLotNo(_LotNo)
        lbDevice.Text = GetDeviceFromLotNo(_LotNo)

        lbFrameIn.Text = CStr(_TotalInput)
        lbFrameOut.Text = CStr(_TotalGood)

        lbMagazine.Text = _Magazine


        Select Case lbPackage.Text
            Case "HSDIP25" 'E Lot
                lbTotalInput.Text = (_TotalInput * 4).ToString
                lbTotalGood.Text = (_TotalGood * 4).ToString
                _FramePCS = 4
            Case Else
                lbTotalInput.Text = CalFrameTypeToPcs(_LotNo, _TotalInput).ToString
                lbTotalGood.Text = CalFrameTypeToPcs(_LotNo, _TotalGood).ToString
        End Select
        lbTotalNG.Text = CStr((CDbl(lbTotalInput.Text) - CDbl(lbTotalGood.Text)))

        tbTotalInput.Text = lbTotalInput.Text
        tbTotalGood.Text = lbTotalGood.Text
        tbTotalNG.Text = lbTotalNG.Text

        lbMessageDevice.Text = GetDeviceAlertMessage(lbDevice.Text)
        If lbMessageDevice.Text <> "" Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
        tbOPJudge.Focus()
    End Sub

    Function CalFrameTypeToPcs(ByVal LotNo As String, ByVal FrameCount As Integer) As Integer
        Dim ret As Integer = FrameCount
        Dim PCSPerFrame As Integer
        Try

            PCSPerFrame = CInt(FrameTableTableAdapter.GetPcsPerFrame(LotNo))
            ret = FrameCount * PCSPerFrame

        Catch ex As Exception
            ret = FrameCount
        End Try
        _FramePCS = PCSPerFrame

        Return ret
    End Function

    Function GetPackageFromLotNo(ByVal LotNo As String) As String
        Dim ret As String = ""

        Try
            ret = QueriesTableAdapter1.GetPackage(LotNo)
        Catch ex As Exception
            ret = ""
        End Try

        Return ret

    End Function

    Function GetDeviceAlertMessage(ByVal Device As String) As String
        Dim ret As String = ""

        Try
            ret = QueriesTableAdapter1.DeviceGetAlartMessage(Device)
        Catch ex As Exception
            ret = ""
        End Try
        If ret Is Nothing Then
            ret = ""
        End If
        Return ret

    End Function


    Function GetDeviceFromLotNo(ByVal LotNo As String) As String
        Dim ret As String = ""

        Try
            ret = QueriesTableAdapter1.GetDevice(LotNo)
        Catch ex As Exception
            ret = ""
        End Try

        Return ret

    End Function



    Public Sub New(ByVal LotNo As String, ByVal TotalInput As Integer, ByVal TotalGood As Integer, ByVal LotStartTime As String, ByVal LotEndTime As String, ByVal Magazine As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _LotNo = LotNo
        _TotalInput = TotalInput
        _TotalGood = TotalGood
        _LotStartTime = LotStartTime
        _LotEndTime = LotEndTime
        _Magazine = Magazine

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button12.Click, Button11.Click, Button10.Click

        If TragetTextbox Is Nothing Then
            Exit Sub
        End If

        Dim bt As Button = CType(sender, Button)
        TragetTextbox.Focus()
        If IsNumeric(bt.Text) = True Then 'Number
            SendKeys.Send(bt.Text)
        ElseIf bt.Text = "BS" Then 'Delete
            SendKeys.Send("{BS}")
        Else 'Clear
            TragetTextbox.Clear()
        End If

    End Sub

    Private Sub tbTotalInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTotalInput.Click, tbTotalNG.Click, tbTotalGood.Click, tbDummy.Click
        TragetTextbox = CType(sender, TextBox)
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click
        Dim bt As Button = CType(sender, Button)
        tbDummy.Text = bt.Text
        tbOPJudge.Focus()
    End Sub

    Private Sub tbOPJudge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbOPJudge.KeyPress
        If e.KeyChar = Chr(13) Then
            If tbOPJudge.Text.Length = 6 Then

                If tbTotalInput.Text = "" OrElse tbTotalGood.Text = "" OrElse tbTotalNG.Text = "" OrElse tbDummy.Text = "" Then
                    MsgBox("กรุณากรอกจำนวนการผลิตให้ครบด้วยครับ")
                    tbOPJudge.Text = ""
                    tbOPJudge.Focus()
                    Exit Sub
                ElseIf CInt(tbTotalInput.Text) - CInt(tbTotalGood.Text) - CInt(tbTotalNG.Text) <> 0 Then
                    MsgBox("Zero Control ไม่เท่ากับ 0 กรุณาตรวจสอบ")
                    tbOPJudge.Text = ""
                    tbOPJudge.Focus()
                    Exit Sub
                End If

                Dim permission As New AuthenticationUser.AuthenUser
                If permission.AuthenUser(tbOPJudge.Text, My.Settings.UserAuthenOP) = False AndAlso permission.AuthenUser(tbOPJudge.Text, My.Settings.UserAuthenGL) = False Then 'เชคสิทธิ์ OP/GL
                    MsgBox("OP No นี้ไม่มีสิทธิ์ Confirm Work Record กรุณาติดต่อ ETG")
                    tbOPJudge.Text = ""
                    tbOPJudge.Focus()
                    Exit Sub
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Else
                MsgBox("OP No ไม่ถูกต้องกรุณาตรวจสอบ")
                tbOPJudge.Text = ""
                tbOPJudge.Focus()
            End If
        End If
    End Sub

    Private Sub tbDummy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDummy.TextChanged
        If tbDummy.Text <> "" Then
            Dim DummyQty As Integer = CInt(tbDummy.Text) * _FramePCS

            tbTotalInput.Text = CStr(CInt(lbTotalInput.Text) - DummyQty)
            tbTotalGood.Text = (CStr(CInt(lbTotalGood.Text) - DummyQty))

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If gbMessage.BackColor = Color.Wheat Then
            gbMessage.BackColor = Color.Yellow
        Else
            gbMessage.BackColor = Color.Wheat
        End If
    End Sub
End Class