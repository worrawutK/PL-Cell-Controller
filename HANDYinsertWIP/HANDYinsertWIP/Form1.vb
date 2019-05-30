'Imports System.IO
Imports System.Linq
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports Bt.CommLib
Imports Bt
Imports Bt.SysLib
Imports System
Imports System.Data.SqlClient
Public Class Form1

    Private Sub UpdateIp()
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim strIPAddress As String = System.Net.Dns.GetHostEntry(strHostName).AddressList(1).ToString()
        Label7.Text = "IP :" & strIPAddress
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbQRScan.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            UpdateIp()
            If tbQRScan.TextLength > 200 Then '252
                StatusDisplay = Display.Meco
                lbLotNo.Text = "Lot No.  : "
                lbPackage.Visible = True
                lbPKG.Visible = True
                lbOP.Visible = True
                lbOPNo.Visible = True
                Label1.Visible = True
                If OPNo = Nothing Then
                    Buzzer(1, 1)
                    Dim frmMsg As New ScanQR
                    Status = StatusQR.OPNo

                    If frmMsg.ShowDialog = Windows.Forms.DialogResult.OK Then
                        '      MsgBox("กรุณา Scan OP No.")
                        tbQRScan.Text = Nothing
                        Exit Sub
                    End If

                End If
                QRcode = tbQRScan.Text
                '   Dim Machine As String = "PL-HM-01"
                Package = Trim(QRcode.Substring(0, 10)).ToUpper
                LotNo = Trim(QRcode.Substring(30, 10)).ToUpper

                Dim Remark As String = "CANCEL"
                sql = "SELECT LotNo, Package, INPUTDate, OPNo, MCNo, Remark FROM PLIPMWip WHERE LotNo = '" & LotNo & "' and Remark is null"
                Dim data As SqlDataReader = cmd_ExecuteReader()
                Dim count As Integer = 0
                While data.Read
                    count += 1

                End While
                conn.Close()
                If count <> 0 Then
                    Buzzer(2, 1)
                    If MsgBox(("มีอยุ่ในระบบแล้ว" & vbCrLf & "ต้องการที่จะลบหรือไม่"), MsgBoxStyle.YesNoCancel, "CancelLot") = MsgBoxResult.Yes Then
                        tbQRScan.Text = Nothing
                        sql = "UPDATE PLIPMWip set Remark = '" & Remark & "' where Remark is null and LotNo = '" & LotNo & "' "
                        cmd_ExecuteNonQuery()
                        conn.Close()
                        lbLot.Text = "-"
                        lbPKG.Text = "-"
                        tbQRScan.Text = Nothing
                        QryWIP()
                        Exit Sub
                    Else
                        tbQRScan.Text = Nothing
                        Exit Sub
                    End If
                    '   MsgBox("มีอยุ่ในระบบแล้ว" & vbCrLf & "ต้องการที่จะลบหรือไม่")

                End If

                sql = "insert into PLIPMWip (LotNo, Package, INPUTDate,OPNo,MCNo) values('" & LotNo & "','" & Package & "','" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & OPNo & "','" & Machine & "')"
                cmd_ExecuteNonQuery()
                conn.Close()

                lbLot.Text = LotNo
                lbPKG.Text = Package
                '  TextBox1.Text = Nothing
                QryWIP()
            ElseIf tbQRScan.TextLength = 6 Then
                If OPNo = tbQRScan.Text Then
                    Buzzer(1, 1)
                    If MsgBox(("ต้องการออกจากระบบหรือไม่"), MsgBoxStyle.YesNoCancel, "CancelLot") = MsgBoxResult.Yes Then
                        ' execute command
                        OPNo = Nothing
                        tbQRScan.Text = Nothing
                        lbOP.Text = Nothing
                        Exit Sub
                    Else
                        tbQRScan.Text = Nothing
                        Exit Sub
                    End If
                    '  MsgBox("ต้องการออกจากระบบหรือไม่")

                End If
                OPNo = tbQRScan.Text
                lbOP.Text = OPNo
            ElseIf tbQRScan.TextLength = 8 Then
                If tbQRScan.Text = Format(Now, "yyyyMMdd") Then
                    Me.Close()
                    Exit Sub
                End If
            ElseIf tbQRScan.TextLength = 3 Then
                WIPTC()


            Else
                Buzzer(2, 1)
                Dim frmMsg As New ScanQR
                Status = StatusQR.Again

                If frmMsg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    '  MsgBox("กรุณา Scan อีกครั้ง")
                    tbQRScan.Text = Nothing
                    Exit Sub
                End If

            End If


            tbQRScan.Text = Nothing
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateIp()
    End Sub
    Private Sub CheckStatus()
        If OPNo = Nothing Then
            Status = StatusQR.OPNo
            Dim frm As New ScanQR
            If frm.ShowDialog() = DialogResult.OK Then
                OPNo = frm.Data
                lbOP.Text = "OPNo :" & OPNo
                tbQRScan.Focus()
            End If
        End If
    End Sub
    Private Sub QryWIP()
        sql = "SELECT count(*) as CountWIP FROM PLIPMWip WHERE (LotNo NOT IN (SELECT PLData.LotNo FROM PLData INNER JOIN TransactionData ON PLData.LotNo = TransactionData.LotNo WHERE  (TransactionData.Package ='" & Package & "') AND (PLData.LotEndTime > DATEADD(day, - 7, GETDATE())))) AND (Remark IS NULL) AND (INPUTDate > DATEADD(day, - 7, GETDATE()))"

        ' sql = " select * from plipmwip where LotNo not in  (SELECT  PLData.LotNo FROM PLData INNER JOIN TransactionData ON PLData.LotNo = TransactionData.LotNo WHERE (Package in (select DISTINCT Package from PLIPMWip) and PLData.LotEndTime > DATEADD(day, - 1, GETDATE())) ) and Remark is null"
        'Dim data As SqlDataReader = cmd_ExecuteReader()
        'Dim count As Integer = 0
        'While data.Read
        '    If data("Package") = Package Then
        '        count += 1
        '    End If
        'End While
        'conn.Close()
        Dim data As SqlDataReader = cmd_ExecuteReader()
        Dim count As String = "0"
        While data.Read

            count = data("CountWIP").ToString

        End While
        conn.Close()
        lbW.Text = count
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' Timer1.Enabled = False
        '   CheckStatus()
        If OPNo = Nothing Then
            Label1.Text = "Scan OP No."
        Else
            Label1.Text = "Scan QR Code"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tbQRScan.Focus()

    End Sub
    Private Sub Buzzer(ByVal count As Integer, ByVal Tone As Integer)
        Dim ret As Int32 = 0
        Dim disp As [String] = ""

        'Buzzer
        Dim stBuzzerSet As New LibDef.BT_BUZZER_PARAM()
        ' Buzzer control structure (Set)
        ' Set to repeat "500 ms on, 500 ms off" 3 times
        stBuzzerSet.dwOn = 500
        ' Rumble time [ms] (1 to 5000)
        stBuzzerSet.dwOff = 500
        ' Stop time [ms] (0 to 5000)
        stBuzzerSet.dwCount = CUInt(count)
        ' Rumble count [times] (0 to 100)
        stBuzzerSet.bTone = Tone
        ' Musical scale (1 to 16)
        stBuzzerSet.bVolume = 3
        ' Buzzer volume (1 to 3)

        ' Vibrator
        Dim stVibSet As New LibDef.BT_VIBRATOR_PARAM()
        stVibSet.dwOn = 500
        ' Rumble time [ms] (1 to 5000)
        stVibSet.dwOff = 500
        ' Stop time [ms] (0 to 5000)
        stVibSet.dwCount = CUInt(count)
        ' Rumble count [times] (0 to 100)
        Try
            ' btBuzzer Rumble
            ret = Device.btBuzzer(1, stBuzzerSet)
            ret = Device.btVibrator(1, stVibSet)
            If ret <> LibDef.BT_OK Then
                disp = "btBuzzer error ret[" & ret & "]"
                MessageBox.Show(disp, "Error")
                Return
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Private Sub WIPTC()
        StatusDisplay = Display.Reflow
        Dim CartNo As String = tbQRScan.Text
        sql = "SELECT  TCTransfer.* FROM TCTransfer where CartNo like '%" & CartNo & "%' and LotEndTime is null"
        Dim data As SqlDataReader = cmd_ExecuteReader()
        Dim count As Integer = 0
        Dim aaa As String = ""
        While data.Read
            count += 1
            aaa = aaa & "-" & data("LotNo").ToString
        End While
        conn.Close()
        lbLotNo.Text = "CartNo   :"
        lbW.Text = count.ToString
        lbLot.Text = CartNo

        lbPackage.Visible = False
        lbPKG.Visible = False
        lbOP.Visible = False
        lbOPNo.Visible = False
        Label1.Visible = False
        If count = 0 Then
            Buzzer(2, 1)
            Dim frmMsg As New ScanQR
            Status = StatusQR.NoLotCart
            If frmMsg.ShowDialog = Windows.Forms.DialogResult.OK Then
                '      MsgBox("กรุณา Scan OP No.")
                tbQRScan.Text = Nothing
                Exit Sub
            End If
            '  MsgBox("ไม่มีงานในรถนี้")
        End If
        sql = "UPDATE TCTransfer set LotEndTime = '" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "' where LotEndTime is null and CartNo like '%" & CartNo & "%' "
        cmd_ExecuteNonQuery()
        conn.Close()
    End Sub
End Class
