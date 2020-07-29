﻿Public Class frmConfirm

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

        Dim result = ModuleConcrete.GetPerFrame(lbPackage.Text)
        If Not result.IsPass Then
            _FramePCS = 1
            Using frm As New DialogMessage(result.Reson, Nothing, "แจ้งเตือน")
                frm.ShowDialog()
            End Using
        Else
            _FramePCS = result.PerFrame
        End If
        lbTotalInput.Text = (_TotalInput * _FramePCS).ToString
        lbTotalGood.Text = (_TotalGood * _FramePCS).ToString
        'Select Case lbPackage.Text
        '    Case "HSDIP25" 'E Lot
        '        lbTotalInput.Text = (_TotalInput * 4).ToString
        '        lbTotalGood.Text = (_TotalGood * 4).ToString
        '        _FramePCS = 4
        '    Case Else
        '        lbTotalInput.Text = CalFrameTypeToPcs(_LotNo, _TotalInput).ToString
        '        lbTotalGood.Text = CalFrameTypeToPcs(_LotNo, _TotalGood).ToString
        'End Select
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
        Try
            If Not SerialPort1.IsOpen Then
                SerialPort1.PortName = My.Settings.PortName '"COM4"
                SerialPort1.Open()
            End If
        Catch ex As Exception

        End Try
        If m_DummyCheck = False Then
            GroupBox3.Enabled = True
        End If



    End Sub

    'Function CalFrameTypeToPcs(ByVal LotNo As String, ByVal FrameCount As Integer) As Integer
    '    Dim ret As Integer = FrameCount
    '    Dim PCSPerFrame As Integer
    '    Try

    '        PCSPerFrame = CInt(FrameTableTableAdapter.GetPcsPerFrame(LotNo))
    '        ret = FrameCount * PCSPerFrame

    '    Catch ex As Exception
    '        ret = FrameCount
    '    End Try
    '    _FramePCS = PCSPerFrame

    '    Return ret
    'End Function

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
                If GroupBox3.Enabled = False Then
                    MsgBox("กรุณาใส่เก็บ frame dummy ด้วยครับ")
                    tbOPJudge.Text = ""
                    tbOPJudge.Focus()
                    Exit Sub
                End If
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
        Dim dummyCount As Integer
        If tbDummy.Text <> "" And Integer.TryParse(tbDummy.Text, dummyCount) Then
            Dim DummyQty As Integer = CInt(dummyCount) * _FramePCS

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
    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        DataReceived()
    End Sub
    'Protected Overridable Sub SerialPortDataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles c_SerialPort.DataReceived
    '    DataReceived()
    'End Sub
    Private c_Buffer As String
    Private Delegate Sub SerialPortDataReceivedDelegate()

    Private Sub DataReceived()
        If Me.InvokeRequired Then
            Me.Invoke(New SerialPortDataReceivedDelegate(AddressOf DataReceived))
            Exit Sub
        End If
        Try

            c_Buffer = c_Buffer & SerialPort1.ReadExisting.ToString
            Dim iret As Integer

            iret = InStr(1, c_Buffer, vbCr)
            If iret <> 0 Then
                c_Buffer = c_Buffer.Replace(Chr(0), "")
                Commlog("Recieve :" & c_Buffer, My.Application.Info.DirectoryPath & "\LOG\Comm.log")
                'ReceiveCmdBase(c_Buffer)
                'ReceiveCommand(c_Buffer)
                InputDummy()
                c_Buffer = ""
            End If

        Catch ex As Exception
            c_Buffer = ""
            SaveCatchLog(ex.ToString, "SerialPortDataReceived()")
        End Try

    End Sub
    Private Sub InputDummy()
        If String.IsNullOrEmpty(tbDummy.Text) Then
            tbDummy.Text = "0"
        End If
        tbDummy.Text = (Integer.Parse(tbDummy.Text) + 1).ToString
        If GroupBox3.Enabled = False Then
            If Integer.Parse(tbDummy.Text) >= 2 Then
                GroupBox3.Enabled = True
            End If
        End If
    End Sub

    Private Sub FrmConfirm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
    End Sub
End Class