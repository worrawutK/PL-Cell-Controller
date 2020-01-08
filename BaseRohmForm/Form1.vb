Public Class Form1


#Region "Commomn Define"


    Event MeCLose()

    Event ProdTableClick()
    Event SettingClick()
    Event SecsGemClick()
    Event TCPClientClick()
    Event OpenComForm()
#End Region





    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click, PictureBox4.Click
        Dim LoginFrm As New LoginForm1
        LoginFrm.ShowDialog()
        If Not OprData.UserLoginResult Then
            Exit Sub
        End If

        btnLogin.Text = OprData.UserLevel.ToString
        RaiseEvent OpenComForm()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        RaiseEvent MeCLose()
    End Sub

    
    Private Sub btnProdTable_Click(sender As System.Object, e As System.EventArgs) Handles btnProdTable.Click, pbxProdTable.Click

        RaiseEvent ProdTableClick()

    End Sub

   
    Private Sub Form1_Deactivate(sender As Object, e As System.EventArgs) Handles Me.Deactivate

        Timer1.Enabled = False
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Me.WindowState = FormWindowState.Minimized
        Timer1.Stop()
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams   'Disable Close(x) Button
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
#Region "FormMove"

    ''====== Form Move ==========================================================================
    'Private isMouseDown As Boolean = False
    'Private mouseOffset As Point
    'Private isMouseMove As Boolean = False
    '' Left mouse button pressed
    'Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
    '    If e.Button = Windows.Forms.MouseButtons.Left Then
    '        ' Get the new position
    '        mouseOffset = New Point(-e.X, -e.Y)
    '        ' Set that left button is pressed
    '        isMouseDown = True

    '    End If


    'End Sub


    '' MouseMove used to check if mouse cursor is moving
    'Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

    '    If isMouseDown Then
    '        Dim mousePos As Point = Control.MousePosition
    '        ' Get the new form position
    '        mousePos.Offset(mouseOffset.X, mouseOffset.Y)
    '        If Math.Abs(Me.Location.X - mousePos.X) > 5 Then
    '            isMouseMove = True
    '        End If
    '        Me.Location = mousePos
    '    End If
    'End Sub

    '' Left mouse button released, form should stop moving
    'Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp

    '    If e.Button = Windows.Forms.MouseButtons.Left Then
    '        isMouseDown = False
    '        isMouseMove = False
    '    End If

    'End Sub
    ''====== Form Move ==========================================================================

#End Region

    Private Sub btnSetting_Click(sender As System.Object, e As System.EventArgs) Handles btnSetting.Click, pbSetting.Click
        RaiseEvent SettingClick()

    End Sub

    
    Private Sub btnSecsGem_Click(sender As System.Object, e As System.EventArgs) Handles btnSecsGem.Click, pbSecsGem.Click
        RaiseEvent SecsGemClick()
    End Sub

    Private Sub pbxKeyBoard_Click(sender As System.Object, e As System.EventArgs) Handles pbxKeyBoard.Click, btnKeyboard.Click
        KeyBoardOpen()
    End Sub

    Private oskProcess As Process
    Private Sub KeyBoardOpen()
        Try
            If Me.oskProcess Is Nothing OrElse Me.oskProcess.HasExited Then
                If Me.oskProcess IsNot Nothing AndAlso Me.oskProcess.HasExited Then
                    Me.oskProcess.Close()
                End If
                Me.oskProcess = Process.Start("C:\Windows\System32\OSK.EXE")

            End If
        Catch ex As Exception

        End Try


    End Sub
  

    Private Sub pbxTCPClient_Click(sender As System.Object, e As System.EventArgs) Handles pbxTCPClient.Click, btnTCPClient.Click
        If Not My.Settings.CsProtocol_Enable Then
            Exit Sub
        End If
        RaiseEvent TCPClientClick()

    End Sub
End Class
