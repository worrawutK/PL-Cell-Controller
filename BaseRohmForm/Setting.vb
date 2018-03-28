Public Class Setting
#Region "Commomn Define"
    Event E_FormClosing(ByVal Flag As Integer)
    Dim MySettingsEquipmentIP As String
    Dim MySettingsProcessName As String
    Dim MySettingsMCType As String
    Dim MySettingsDBConnSTR As String
    Dim MySettingsEquipmentNo As String
    Dim MySettingsUserAuthenOP As String
    Dim MySettingsUserAuthenGL As String


    Friend Enum SecsSettingCloseFlag
        Normal
        Warning
        ForceOFF
    End Enum
    Dim RestartRequestFlag As New SecsSettingCloseFlag
#End Region
    Private Sub Setting_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If rbSecsEna.Checked Then
            If Not My.Settings.SECS_Enable Then     'Set RestartRequestFlag mis check
                My.Settings.SECS_Enable = True
                RestartRequestFlag = SecsSettingCloseFlag.ForceOFF
            End If
        End If

        If rbSecsDis.Checked Then
            If My.Settings.SECS_Enable Then     'Set RestartRequestFlag mis check
                My.Settings.SECS_Enable = False
                RestartRequestFlag = SecsSettingCloseFlag.Warning
            End If
        End If

        If rbTDCDisa.Checked Then
            If My.Settings.TDC_Enable Then     'Set RestartRequestFlag mis check
                My.Settings.TDC_Enable = False
                RestartRequestFlag = SecsSettingCloseFlag.Warning
            End If
        End If

        If rbTDCEna.Checked Then
            If Not My.Settings.TDC_Enable Then     'Set RestartRequestFlag mis check
                My.Settings.TDC_Enable = True
                RestartRequestFlag = SecsSettingCloseFlag.ForceOFF
            End If
        End If

        If rbProEna.Checked Then
            If rbSecsEna.Checked Then                          'Auto Disable if secs enable
                My.Settings.CsProtocol_Enable = False

            Else
                If Not My.Settings.CsProtocol_Enable Then     'Set RestartRequestFlag mis check
                    My.Settings.CsProtocol_Enable = True
                    RestartRequestFlag = SecsSettingCloseFlag.ForceOFF
                End If
            End If
           

        End If

        If rbProDis.Checked Then
            If My.Settings.CsProtocol_Enable Then     'Set RestartRequestFlag mis check
                My.Settings.CsProtocol_Enable = False
                RestartRequestFlag = SecsSettingCloseFlag.Warning
            End If
        End If


        RaiseEvent E_FormClosing(RestartRequestFlag)
    End Sub

    Private Sub Setting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgvSetting.Rows.Add(6)
        dgvSetting.Item("ColName", 0).Value = "ProcessName"
        dgvSetting.Item("ColName", 1).Value = "MCType"
        'dgvSetting.Item("ColName", 2).Value = "EquipmentIP"
        dgvSetting.Item("ColName", 2).Value = "EquipmentNo"
        dgvSetting.Item("ColName", 3).Value = "DBConnSTR"
        dgvSetting.Item("ColName", 4).Value = "UserAuthenOP"
        dgvSetting.Item("ColName", 5).Value = "UserAuthenGL"


        dgvTimer.Rows.Add(5)
        dgvTimer.Item("ParaName", 0).Value = "T3 Reply Timeout"
        dgvTimer.Item("ParaName", 1).Value = "T5 Connect Separation Timeout     "
        dgvTimer.Item("ParaName", 2).Value = "T6 ControlTransaction Timeout     "
        dgvTimer.Item("ParaName", 3).Value = "T7 NOT Connected Timeout"
        dgvTimer.Item("ParaName", 4).Value = "LinkTest_Interval"


        dgvSetting.Item("Value", 0).Value = My.Settings.ProcessName
        dgvSetting.Item("Value", 1).Value = My.Settings.MCType
        'dgvSetting.Item("Value", 2).Value = My.Settings.EquipmentIP
        dgvSetting.Item("Value", 2).Value = My.Settings.EquipmentNo
        dgvSetting.Item("Value", 3).Value = My.Settings.DBConnSTR
        dgvSetting.Item("Value", 4).Value = My.Settings.UserAuthenOP
        dgvSetting.Item("Value", 5).Value = My.Settings.UserAuthenGL



        If My.Settings.SECS_Enable Then
            rbSecsEna.Checked = True
        Else
            rbSecsDis.Checked = True
        End If
        If My.Settings.TDC_Enable Then
            rbTDCEna.Checked = True
        Else
            rbTDCDisa.Checked = True
        End If


        If My.Settings.CsProtocol_Enable Then
            rbProEna.Checked = True
        Else
            rbProDis.Checked = True
        End If

    End Sub


    Private Function ConnStrTest(ByVal ConnStr As String) As String
        'Data Source=172.16.0.102;Initial Catalog=DBx;Persist Security Info=True;User ID=dbxuser
        If ConnStr = My.Settings.EquipmentNo Then
            Return "True"
            Exit Function
        End If

        Try
            Dim sqlconnection As New System.Data.SqlClient.SqlConnection(ConnStr)

            Try
                sqlconnection.Open()
                sqlconnection.Close()

            Catch ex As Exception
                Return "False :" & ex.ToString

            Finally

                sqlconnection.Dispose()

            End Try
        Catch ex As Exception
            Return "False :" & ex.ToString
        End Try
        Return "True :"
    End Function


    Private Sub tbComSetting_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles tbComSetting.Paint
        Dim myPen As Pen
        myPen = New Pen(Color.CadetBlue, 1)
        e.Graphics.DrawLine(myPen, 4, 28, Me.Width - 29, 28)
    End Sub


    Private Sub dgvSetting_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSetting.CellEndEdit
        If Not e.ColumnIndex = 1 Then
            Exit Sub
        End If
        Dim value As String = dgvSetting.Item("Value", e.RowIndex).Value.ToString
        Select Case dgvSetting.Item(0, e.RowIndex).Value.ToString
            Case "ProcessName"
                If value = "" Then
                    dgvSetting.Item("Value", e.RowIndex).Value = My.Settings.ProcessName
                    Exit Sub
                End If

                dgvSetting.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.YellowGreen
                MySettingsProcessName = value

            Case ("MCType")
                If value = "" Then
                    dgvSetting.Item("Value", e.RowIndex).Value = My.Settings.MCType
                    Exit Sub
                End If
                dgvSetting.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.YellowGreen
                MySettingsMCType = value

            Case "EquipmentIP"
                If value = "" Then
                    dgvSetting.Item("Value", e.RowIndex).Value = My.Settings.EquipmentIP

                    Exit Sub
                End If
                dgvSetting.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.YellowGreen
                MySettingsEquipmentIP = value

            Case "DBConnSTR"

                Dim Ans = ConnStrTest(value)


                If Ans Like "False*" Then
                    MsgBox("----------------------------------------" & vbCrLf & _
                            " Connection string check false PLease check your setting" & vbCrLf & _
                            "----------------------------------------" & vbCrLf & _
                            Ans)
                    dgvSetting.Item("Value", e.RowIndex).Value = My.Settings.DBConnSTR

                    Exit Sub
                End If
                If value = My.Settings.EquipmentNo Then
                    Exit Sub
                End If
                dgvSetting.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.YellowGreen
                MySettingsDBConnSTR = value


            Case "EquipmentNo"

                If value = "" Then
                    dgvSetting.Item("Value", e.RowIndex).Value = My.Settings.EquipmentNo
                    Exit Sub
                End If
                dgvSetting.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.YellowGreen
                MySettingsEquipmentNo = value

            Case "UserAuthenGL"
                If value = "" Then
                    dgvSetting.Item("Value", e.RowIndex).Value = My.Settings.UserAuthenGL
                    Exit Sub
                End If
                dgvSetting.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.YellowGreen
                MySettingsUserAuthenGL = value



            Case "UserAuthenOP"

                If value = "" Then
                    dgvSetting.Item("Value", e.RowIndex).Value = My.Settings.UserAuthenOP
                    Exit Sub
                End If
                dgvSetting.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.YellowGreen
                MySettingsUserAuthenOP = value


        End Select


    End Sub


    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim SaveFlag As Boolean

        If MySettingsEquipmentIP <> "" And Not (My.Settings.EquipmentIP = MySettingsEquipmentIP) Then
            My.Settings.EquipmentIP = MySettingsEquipmentIP
            RestartRequestFlag = SecsSettingCloseFlag.Warning                      'Restart Msg Display
            SaveFlag = True
        End If

        If MySettingsMCType <> "" And Not (My.Settings.MCType = MySettingsMCType) Then
            My.Settings.MCType = MySettingsMCType
            RestartRequestFlag = SecsSettingCloseFlag.Warning                     'Restart Msg Display
            SaveFlag = True
        End If
        If MySettingsProcessName <> "" Then
            My.Settings.ProcessName = MySettingsProcessName
            RestartRequestFlag = SecsSettingCloseFlag.Warning                     'Restart Msg Display
            SaveFlag = True
        End If
        If MySettingsEquipmentNo <> "" And Not (My.Settings.EquipmentNo = MySettingsEquipmentNo) Then
            My.Settings.EquipmentNo = MySettingsEquipmentNo
            RestartRequestFlag = SecsSettingCloseFlag.Warning                     'Restart Msg Display
            SaveFlag = True
        End If

        If MySettingsDBConnSTR <> "" Then
            My.Settings.DBConnSTR = MySettingsDBConnSTR
            RestartRequestFlag = SecsSettingCloseFlag.Warning                     'Restart Msg Display
            SaveFlag = True
        End If

        If MySettingsUserAuthenOP <> "" And Not (My.Settings.UserAuthenOP = MySettingsUserAuthenOP) Then
            My.Settings.UserAuthenOP = MySettingsUserAuthenOP
            RestartRequestFlag = SecsSettingCloseFlag.Warning                     'Restart Msg Display
            SaveFlag = True
        End If
        If MySettingsUserAuthenGL <> "" And Not (My.Settings.UserAuthenGL = MySettingsUserAuthenGL) Then
            My.Settings.UserAuthenGL = MySettingsUserAuthenGL
            RestartRequestFlag = SecsSettingCloseFlag.Warning                     'Restart Msg Display
            SaveFlag = True
        End If


        MySettingsEquipmentIP = ""
        MySettingsMCType = ""
        MySettingsProcessName = ""
        MySettingsDBConnSTR = ""
        MySettingsEquipmentNo = ""
        MySettingsUserAuthenGL = ""
        MySettingsUserAuthenOP = ""

        If SaveFlag Then
            MsgBox("Save Success")
        Else
            MsgBox("Save is not process")
        End If
        For i As Integer = 0 To dgvSetting.Rows.Count - 1
            dgvSetting.Rows(i).Cells(1).Style.ForeColor = Color.Black
        Next


    End Sub


    Private Sub tbSetting_Selected(sender As Object, e As System.Windows.Forms.TabControlEventArgs) Handles tbSetting.Selected

        Select Case e.TabPage.Name

            Case "tbComSetting"
                dgvSetting.Item("Value", 0).Value = My.Settings.ProcessName
                dgvSetting.Item("Value", 1).Value = My.Settings.MCType
                dgvSetting.Item("Value", 2).Value = My.Settings.EquipmentNo
                dgvSetting.Item("Value", 3).Value = My.Settings.DBConnSTR
                dgvSetting.Item("Value", 4).Value = My.Settings.UserAuthenOP
                dgvSetting.Item("Value", 5).Value = My.Settings.UserAuthenGL


            Case "tbSecsGem"
                tbxEqiupIP.Text = My.Settings.EquipmentIP
                tbxEqiupPort.Text = CStr(My.Settings.SECS_PortNumber)



                dgvTimer.Item("ParaValue", 0).Value = My.Settings.GEM_T3_Interval
                dgvTimer.Item("ParaValue", 1).Value = My.Settings.GEM_T5_Interval
                dgvTimer.Item("ParaValue", 2).Value = My.Settings.GEM_T6_Interval
                dgvTimer.Item("ParaValue", 3).Value = My.Settings.GEM_T7_Interval
                dgvTimer.Item("ParaValue", 4).Value = My.Settings.GEM_LinkTest_Interval

            Case "tbTDC"
            Case "tbCsPro"
                tbxCsIP.Text = My.Settings.EquipmentIP
                tbxCsPort.Text = CStr(My.Settings.CsProtocolPort)
        End Select

    End Sub

    Private Sub btnEquipIPChg_Click(sender As System.Object, e As System.EventArgs) Handles btnEquipIPChg.Click
        Dim IPFormat As Integer = tbxEqiupIP.Text.Split(CChar(".")).Length
        If tbxEqiupIP.Text = "" Or IPFormat <> 4 Then
            tbxEqiupIP.Text = My.Settings.EquipmentIP
            Exit Sub
        End If
        If tbxEqiupIP.Text = My.Settings.EquipmentIP Then
            tbxEqiupIP.Text = My.Settings.EquipmentIP
            Exit Sub
        End If
        RestartRequestFlag = SecsSettingCloseFlag.Warning
        My.Settings.EquipmentIP = tbxEqiupIP.Text
    End Sub
    Private Sub btnCsIPChg_Click(sender As System.Object, e As System.EventArgs) Handles btnCsIPChg.Click
        Dim IPFormat As Integer = tbxCsIP.Text.Split(CChar(".")).Length
        If tbxCsIP.Text = "" Or IPFormat <> 4 Then
            tbxCsIP.Text = My.Settings.EquipmentIP
            Exit Sub
            End If
            If tbxCsIP.Text = My.Settings.EquipmentIP Then
            tbxCsIP.Text = My.Settings.EquipmentIP
            Exit Sub
            End If
            RestartRequestFlag = SecsSettingCloseFlag.Warning
            My.Settings.EquipmentIP = tbxCsIP.Text
    End Sub



    Private Sub btnEquipPortChg_Click(sender As System.Object, e As System.EventArgs) Handles btnEquipPortChg.Click
        If CInt(tbxEqiupPort.Text) = My.Settings.SECS_PortNumber Then
            Exit Sub
        End If
        If IsNumeric(tbxEqiupPort.Text) Then
            RestartRequestFlag = SecsSettingCloseFlag.Warning
            My.Settings.SECS_PortNumber = CInt(tbxEqiupPort.Text)
        End If
    End Sub

    Private Sub btnCsPortChg_Click(sender As System.Object, e As System.EventArgs) Handles btnCsPortChg.Click
        If CInt(tbxCsPort.Text) = My.Settings.CsProtocolPort Then
            Exit Sub
        End If
        If IsNumeric(tbxCsPort.Text) Then
            RestartRequestFlag = SecsSettingCloseFlag.Warning
            My.Settings.CsProtocolPort = CInt(tbxCsPort.Text)
        End If
    End Sub

    Private Sub btnTimeoutChg_Click(sender As System.Object, e As System.EventArgs) Handles btnTimeoutChg.Click
        Try


            If dgvTimer.Item("ParaValue", 0).Value IsNot Nothing And Not CInt(dgvTimer.Item("ParaValue", 0).Value) = My.Settings.GEM_T3_Interval Then
                My.Settings.GEM_T3_Interval = CInt(dgvTimer.Item("ParaValue", 0).Value)
                RestartRequestFlag = SecsSettingCloseFlag.Warning

            End If

            If dgvTimer.Item("ParaValue", 1).Value IsNot Nothing And Not (CInt(dgvTimer.Item("ParaValue", 1).Value) = My.Settings.GEM_T5_Interval) Then

                My.Settings.GEM_T5_Interval = CInt(dgvTimer.Item("ParaValue", 1).Value)
                RestartRequestFlag = SecsSettingCloseFlag.Warning
            End If

            If dgvTimer.Item("ParaValue", 2).Value IsNot Nothing And Not CInt(dgvTimer.Item("ParaValue", 2).Value) = My.Settings.GEM_T6_Interval Then
                My.Settings.GEM_T6_Interval = CInt(dgvTimer.Item("ParaValue", 2).Value)
                RestartRequestFlag = SecsSettingCloseFlag.Warning
            End If

            If dgvTimer.Item("ParaValue", 3).Value IsNot Nothing And Not CInt(dgvTimer.Item("ParaValue", 3).Value) = My.Settings.GEM_T7_Interval Then
                My.Settings.GEM_T7_Interval = CInt(dgvTimer.Item("ParaValue", 3).Value)
                RestartRequestFlag = SecsSettingCloseFlag.Warning
            End If

            If dgvTimer.Item("ParaValue", 4).Value IsNot Nothing And Not CInt(dgvTimer.Item("ParaValue", 4).Value) = My.Settings.GEM_LinkTest_Interval Then
                My.Settings.GEM_LinkTest_Interval = CInt(dgvTimer.Item("ParaValue", 4).Value)
                RestartRequestFlag = SecsSettingCloseFlag.Warning
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub tbSecsGem_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles tbSecsGem.Paint
        Dim myPen As Pen
       
        myPen = New Pen(Color.Gray, 1)
        e.Graphics.DrawLine(myPen, CInt(tbSetting.Width / 2), 0, CInt(tbSetting.Width / 2), tbSetting.Height)
    End Sub

    
    Private Sub AddUserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddUserToolStripMenuItem.Click
        If Not OprData.UserLevel = CommonData.Level.ADMIN Then
            MsgBox("The only admin level is allowed.")
            Exit Sub
        End If
        Dim AddUser As New LoginUser
        AddUser.ShowDialog()
    End Sub

 
  
    
  
    Private Sub rbProEna_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbProEna.CheckedChanged
        If rbSecsEna.Checked Then
            MsgBox("Please Disable Secs before setting")
            rbProDis.Checked = True
            Exit Sub
        End If
    End Sub
End Class