Imports System.ComponentModel

Public Class TcpIpClientTest
    Dim WithEvents Client1 As New TcpIpClient

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If My.Settings.EquipmentIP = txtIP.Text And CDbl(txtPortNo.Text) = My.Settings.SECS_PortNumber Then
            MsgBox("This ip and port already use")
            Exit Sub
        End If

        Client1.ReadContinue = True
        Client1.Listener_Click(txtPortNo.Text, txtIP.Text)

    End Sub


    Dim statusx As String
    Private Sub ifemConect(ByVal status As String) Handles Client1.TcpStatusConnect
        Try
            statusx = status
            ifemConectx()
        Catch ex As Exception

        End Try
      
    End Sub
    Private Sub ifemConectx()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ifemConectx))
        Else
            txtStatus.Text = statusx
            If statusx = "Disconnect" Then
                txtRecv.BackColor = Color.DarkGray
            ElseIf statusx = "Connected" Then
                txtRecv.BackColor = Color.White

            End If

        End If
    End Sub


    Private Sub CmdXmlData(ByVal data As String) Handles Client1.RcvData
        RcvManage(data)
        Commlog("ClientTestRecv : " & data, My.Application.Info.DirectoryPath & "\LOG\CleintTestComm.log")
        AccessControl("1", data)
        data = ""
    End Sub

    Delegate Sub AccessControlDelg(ByVal Ctl As String, ByVal data As String)
    Private Sub AccessControl(ByVal Ctl As String, ByVal data As String)
        If Me.InvokeRequired Then
            Me.Invoke(New AccessControlDelg(AddressOf AccessControl), Ctl, data)
        Else
            Select Case Ctl
                Case "1"
                    txtRecv.Text += Format(Now, "HH:mm:ss  ") & "Recv" & " [" & data.Length & "] : " & data & vbCrLf
                Case "2"
                    txtRecv.Text += Format(Now, "HH:mm:ss  ") & "Send" & " [" & data.Length & "] : " & data & vbCrLf
            End Select
        End If

    End Sub


    'Delegate Sub AccessControlDelg(ByVal Ctl As String, ByVal data As String)
    'Private m_Slb As AccessControlDelg = New AccessControlDelg(AddressOf AccessControl)

    'Dim obj As Object
    'Private Sub AccessControl(ByVal Ctl As String, ByVal data As String)

    '    If Me.InvokeRequired Then
    '        'http://kristofverbiest.blogspot.com/2007/02/avoid-invoke-prefer-begininvoke.html
    '        Me.BeginInvoke(m_Slb, Ctl, data)
    '        Exit Sub
    '    End If
    '    SyncLock obj
    '        Select Case Ctl
    '            Case "1"
    '                txtRecv.Text += Format(Now, "HH:mm:ss  " & "Recv :" & data & vbCrLf)
    '            Case "2"
    '                txtRecv.Text += Format(Now, "HH:mm:ss  " & "Send :" & data & vbCrLf)
    '        End Select
    '    End SyncLock



    'End Sub


    Private Sub RcvManage(ByVal data As String)
        Dim Parameter As String
        Parameter = data
        Dim RcvManage_Task As New BackgroundWorker
        AddHandler RcvManage_Task.DoWork, AddressOf RcvManage_Dowork
        AddHandler RcvManage_Task.RunWorkerCompleted, AddressOf RcvManage_RunComplete
        RcvManage_Task.RunWorkerAsync(Parameter)




    End Sub


    Private Sub RcvManage_Dowork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Try
            Dim Agr As String
            Agr = CType(e.Argument, String)

            e.Result = Agr


        Catch ex As Exception
aaa:

        End Try

    End Sub
    Private Sub RcvManage_RunComplete(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        Dim Agr As String
        Agr = CType(e.Result, String)
        Dim CmdHeader As String
        Dim Cmddata() As String = Agr.Split(CChar(" ,"))
        CmdHeader = Cmddata(0)

        Select Case CmdHeader
            Case "LR"
                If CheckBox1.Checked Then
                    Send("LR,00")
                Else
                    Send("LR,01")
                End If



            Case "LS"
                If CheckBox2.Checked Then
                    Send("LS,00")
                Else
                    Send("LS,01")
                End If



            Case "LE"
                If CheckBox3.Checked Then
                    Send("LE,00")
                Else
                    Send("LE,01")
                End If



        End Select






    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtSnd.Text = "" Then
            Exit Sub
        End If
        Send(txtSnd.Text)
    End Sub

    Private Sub Send(ByVal str As String)
        If str.Length > 15 Then
            MsgBox("message too long")
            Exit Sub
        End If
        If str.Length < 15 Then
            For i = 1 To 15 - str.Length
                str += " "
            Next
        End If
        Commlog("ClientTestSend : " & str, My.Application.Info.DirectoryPath & "\LOG\ClientTestComm.log")
        AccessControl("2", str)

        Client1.btnSend_Click(str & vbCr)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtRecv.Text = ""
    End Sub

   

    Private Sub TcpIpClientTest_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Client1.Disconnent()
    End Sub

   
    Private Sub TcpIpClientTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtIP.Text = Client1.GetLocalIP
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Client1.Disconnent()
    End Sub

    Private Sub rbnAscii_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbnAscii.CheckedChanged
        Client1.DataType = True
    End Sub

    Private Sub rbnBinary_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbnBinary.CheckedChanged
        Client1.DataType = False
    End Sub

  
   
End Class