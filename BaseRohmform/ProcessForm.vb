Imports System.Threading
Imports System.ComponentModel
Imports System.IO
Imports Rohm.Apcs.Tdc
Imports System.Runtime.Serialization.Formatters.Binary
Imports XtraLibrary.SecsGem
'Imports iLibrary
Imports Rohm.Common.Logging
Imports System.Xml.Serialization
Imports System.Reflection
Imports CellController.iLibraryService
Public Class ProcessForm
#Region "Commomn Define"
    Event E_MakeAlarmCellCon(ByVal AlarmMessage As String, ByVal Location As String, ByVal Status As String, ByVal AlarmID As String)
    Event E_Update_dgvProductionInfo1(ByVal _CarrierID As String, ByVal LotID As String, ByVal Package As String, ByVal Device As String, ByVal REMARK As String, ByVal StartTime As String)
    Event E_Update_dgvProductionInfoEnd(ByVal _UnloadCarrierID As String, ByVal LotNo As String, ByVal Count As String, ByVal Remark As String)
    Event E_Update_dgvProductionDetail(ByVal itemID As String, ByVal type As String, ByVal action As String, ByVal location As String)
    Event E_AlarmTable(ByVal AlarmALCD As Boolean, ByVal AlarmALID As String, ByVal AlarmALTX As String, ByVal AlarmType As String)

    Event E_FormFill()
    Event E_ProductionTableCall()
    Event E_ConsoleShow()
    Event E_UserLogin()
    Event E_CD_SendMsg(ByVal msg As String)
    Event E_QRReadSuccess()
    Event E_SlInfo(ByVal msg As String)
    Event E_EqConnect()
    Event E_QRReadOPIDSuccess()
    Event E_LRCheck(ByVal EqNo As String, ByVal LotNo As String)
    Event E_LSCheck(ByVal EQNo As String, ByVal LotNo As String, ByVal StartTime As Date, ByVal OPID As String)
    Event E_LECheck(ByVal EQNo As String, ByVal LotNo As String, ByVal EndTime As Date, ByVal GoodPcs As Integer, ByVal NgPcs As Integer, ByVal OPID As String, ByVal EndMode As EndModeType)
    'Meco Event 

    Public Event E_Event_LotInfo_Rohm(ByVal LotNo As String, ByVal OPNo As String, ByVal Mgz As String)


    Dim PathXmlObj As String = "D:\RohmSystem\rCellcon\" & My.Settings.MCType
    Dim BackUpObj As String = "D:\RohmSystem\rCellcon\" & My.Settings.MCType & "\BackUpObj"
    Dim BackUpObjOld As String = "D:\RohmSystem\rCellcon\" & My.Settings.MCType & "\BackUpObjOld"   'Hard drive is full.
    'Public CstEquipment As New List(Of ChemicalDeflash)

    Private Delegate Sub SxFxxDelegate(ByVal e As SecondarySecsMessageEventArgs)


    Dim m_Locker As Object = New Object
    Private m_TdcService As TdcService
    Private c_TdcQueue As Queue(Of TdcData) = New Queue(Of TdcData)








#End Region

#Region "Form"

    Private c_IlibraryService As CellController.iLibraryService.IServiceiLibrary
    Private Sub ProcessForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        OprData.FRMProductAlive = False
        SavePLDataTableBin()
        Try
            c_IlibraryService.MachineOnlineState("PL-" & My.Settings.EquipmentNo, MachineOnline.Offline)
        Catch ex As Exception

        End Try

    End Sub


    Private Sub ProcessForm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim myPen As Pen
        myPen = New Pen(Color.RoyalBlue, 17)
        e.Graphics.DrawLine(myPen, 0, 10, Me.Width, 10)
        myPen = New Pen(Color.MidnightBlue, 1)
        e.Graphics.DrawLine(myPen, 0, 19, Me.Width, 19)
        myPen = New Pen(Color.PowderBlue, 25)
        e.Graphics.DrawLine(myPen, 0, 110, Me.Width, 110)
        myPen = New Pen(Color.CadetBlue, 1)
        e.Graphics.DrawLine(myPen, 1, 122, Me.Width, 122)

    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams   'Disable Close(x) Button
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Private Sub AlarmTable(ByVal AlarmALCD As Boolean, ByVal AlarmALID As String, ByVal AlarmALTX As String, Optional ByVal AlarmType As String = "0")
        RaiseEvent E_AlarmTable(AlarmALCD, AlarmALID, AlarmALTX, AlarmType)
    End Sub
    Private Sub MakeAlarmCellCon(ByVal AlarmMessage As String, Optional ByVal Location As String = "", Optional ByVal Status As String = "", Optional ByVal AlarmID As String = "")
        RaiseEvent E_MakeAlarmCellCon(AlarmMessage, Location, Status, AlarmID)
    End Sub
    Private Sub Update_dgvProductionInfo1(ByVal _CarrierID As String, ByVal LotID As String, ByVal Package As String, ByVal Device As String, Optional ByVal Remark As String = "", Optional ByVal StartTime As String = "")
        RaiseEvent E_Update_dgvProductionInfo1(_CarrierID, LotID, Package, Device, Remark, StartTime)
    End Sub
    Private Sub Update_dgvProductionDetail(ByVal itemID As String, ByVal type As String, ByVal action As String, Optional ByVal location As String = "")
        RaiseEvent E_Update_dgvProductionDetail(itemID, type, action, location)
    End Sub
    Private Sub Update_dgvProductionInfoEnd(ByVal _UnloadCarrierID As String, ByVal LotNo As String, Optional ByVal Count As String = "", Optional ByVal Remark As String = "")

        RaiseEvent E_Update_dgvProductionInfoEnd(_UnloadCarrierID, LotNo, Count, Remark)
    End Sub
    Private Sub EqConnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EqConnectToolStripMenuItem.Click

        If Not (My.Settings.CsProtocol_Enable Or My.Settings.SECS_Enable) Then
            Exit Sub
        End If
        If Not (OprData.CSConnect = "Disconnect" Or CommuniationState Like "NOT COMMUNICATING") Then
            Exit Sub
        End If

        RaiseEvent E_EqConnect()

    End Sub

    Private Sub pbxLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxLogo.Click, MaximizeToolStripMenuItem.Click
        RaiseEvent E_FormFill()
    End Sub
    Private Sub ProcessForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        lbProcess.Text = My.Settings.ProcessName & " " & My.Settings.MCType
        OprData.FRMProductAlive = True
        If Not My.Settings.TDC_Enable Then
            lbSpMode.Text = "!!! TDC DISABLE !!!"
        End If

        Dim permission As New AuthenticationUser.AuthenUser
        If OprData.CSConnect = "Disconnect" And My.Settings.CsProtocol_Enable Then
            Me.BackColor = Color.Red
        End If
        If Not CommuniationState Like "COMMUNICATING*" And My.Settings.SECS_Enable Then
            Me.BackColor = Color.Red
        End If


        lbMcNo.Text = My.Settings.EquipmentNo

        ' Folder Build ---------------------------------------------------------------------------------
        If (Not System.IO.Directory.Exists(PathXmlObj)) Then
            System.IO.Directory.CreateDirectory(PathXmlObj)
        End If
        If (Not System.IO.Directory.Exists(BackUpObj)) Then
            System.IO.Directory.CreateDirectory(BackUpObj)
        End If
        If (Not System.IO.Directory.Exists(BackUpObjOld)) Then
            System.IO.Directory.CreateDirectory(BackUpObjOld)
        End If
        '-----------------------------------------------------------------------------------------------
        If My.Settings.SECS_Enable Then
            If m_DefinedReportDic.Count = 0 Then
                MsgBox("Process Deny : Define Report 'm_DefinedReportDic' is empty' Please Download Report")
                Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))   'Close form in the form load event
            End If

        End If

        If Not CommuniationState Like "COMMUNICATING*" And My.Settings.SECS_Enable Then
            Me.BackColor = Color.Red

        End If
        Try
            If My.Settings.UserAuthenOP = "NOUSE" Then
                Exit Sub
            Else
                If permission.CheckMachineAutomotive(My.Settings.ProcessName, My.Settings.EquipmentNo) Then
                    pbxAutoM.Visible = True
                End If
            End If

        Catch ex As Exception    'Net Work Error

        End Try

        'Init TCD Library
        m_TdcService = TdcService.GetInstance()
        m_TdcService.LogFolder = "Log"

        LoadPLDataTableBin()
        LoadPLAlarmInfoTable()
        ' XmlLoad(c_ApcsPro2, c_ApcsPro2.GetType())

        Try
            c_IlibraryService = New ServiceiLibraryClient
            Dim result = c_IlibraryService.MachineOnlineState("PL-" & My.Settings.EquipmentNo, MachineOnline.Online)
            ' MessageBox.Show(result.IsPass.ToString())
        Catch ex As Exception

        End Try
    End Sub


    Private Sub ProductTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductTableToolStripMenuItem.Click
        RaiseEvent E_ProductionTableCall()
    End Sub


    Private Sub SecsConsoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecsConsoleToolStripMenuItem.Click
        RaiseEvent E_ConsoleShow()
    End Sub

    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Private Sub BMRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMRequestToolStripMenuItem.Click
        Dim tmpStr As String

        tmpStr = "MCNo=PL-" & My.Settings.EquipmentNo
        If DBxDataSet.PLData.Rows.Count = 0 Then
            tmpStr = tmpStr & "&LotNo="
            tmpStr = tmpStr & "&MCStatus=Stop"
        Else
            For Each strDataRow As DBxDataSet.PLDataRow In DBxDataSet.PLData.Rows
                tmpStr = tmpStr & "&LotNo=" & strDataRow.LotNo
                Exit For
            Next
            tmpStr = tmpStr & "&MCStatus=Running"
        End If

        tmpStr = tmpStr & "&AlarmNo="
        tmpStr = tmpStr & "&AlarmName="

        Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv.thematrix.net/LsiPETE/LSI_Prog/Maintenance/MainloginPD.asp?" & tmpStr, vbNormalFocus)
        ' System.Diagnostics.Process.Start("osk.exe")
        'Process.Start("C:\WINDOWS\system32\osk.exe")
        CallKeyboardVisual()
    End Sub

    Private Sub CallKeyboardVisual()
        Dim osk As String = "C:\WINDOWS\system32\osk.exe"
        Dim old As Long
        If Environment.Is64BitOperatingSystem Then
            If Wow64DisableWow64FsRedirection(old) Then
                Process.Start(osk)
                Wow64EnableWow64FsRedirection(old)
            End If
        Else
            Process.Start(osk)
        End If
    End Sub
    Private Sub PMRepairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PMRepairToolStripMenuItem.Click
        Dim MCNo As String = My.Settings.EquipmentNo
        Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv.thematrix.net/LsiPETE/LSI_Prog/Maintenance/MainPMlogin.asp?" & "MCNo=PL-" & MCNo, vbNormalFocus)
        CallKeyboardVisual()
    End Sub

    Private Sub AndonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AndonToolStripMenuItem.Click
        Try
            Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv/andontmn", AppWinStyle.NormalFocus) 'Web andon for manual M/C
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub APCSStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APCSStaffToolStripMenuItem.Click
        Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv.thematrix.net/ApcsStaff", AppWinStyle.NormalFocus)
    End Sub
#End Region

#Region "SecsComm"
    Friend Sub OnS6F11(ByVal request As S6F11)
        Select Case request.CEID ''Control Status

            '    ''Case 1001 'Control Status
            '    ''    OnControlStatus()
            '    ''Case 1002 'EQ Status           
            '    ''    OnEQStatusChanged()
            '    ''Case 1003 'Lot Start(End)
            '    ''    OnLotStartEnd()
            '    ''Case 1102 'Loader End             
            '    ''    OnLoaderEnd()
            '    ''    'USELESS EVENTS
            '    ''    'Case 1004 'ppid change
            '    ''    'Case 1100 'Door Locked
            '    ''    'Case 1101 'Tube Status
        End Select

    End Sub
    Private m_SxFxx As SxFxxDelegate = New SxFxxDelegate(AddressOf m_Host_ReceivedSecondaryMessage)

    Friend Sub m_Host_ReceivedSecondaryMessage(ByVal e As SecondarySecsMessageEventArgs)
        If Me.InvokeRequired Then
            'http://kristofverbiest.blogspot.com/2007/02/avoid-invoke-prefer-begininvoke.html
            Me.BeginInvoke(m_SxFxx, e)
            Exit Sub
        End If

        Dim priMsg As SecsMessageBase = e.Primary
        Dim sndMsg As SecsMessageBase = e.Secondary








    End Sub


#End Region

#Region "===AuthenticationUser"


    'Dim ETC2 As String                          'From QR Code ,Check ETC2 = BDXX-M/BJ/C is auto motive
    'Dim strNextOperatorNo As String              'OP No.
    'Dim GetUserAuthenGroupByMCType As String       'M/C Type ( Refer with DBx.Group)
    'Dim GL_Group As String                         'GL Gruop ( Refer with DBx.Group)
    'Dim Process As String                        'Process Ex. "FL"
    'Dim MCNo As String                           'MC No Ex "FL-V-01"
    Friend ErrMesETG As String
    Friend Function PermiisionCheck(ByVal ETC2 As String, ByVal strNextOperatorNo As String, ByVal GetUserAuthenGroupByMCType As String, ByVal GL_Group As String, ByVal Procees As String, ByVal MCNo As String) As Boolean
        Dim permission As New AuthenticationUser.AuthenUser
        Dim AuthenPass As Boolean
        ErrMesETG = ""
        Try


            If permission.CheckAutomotiveLot(ETC2) Then
                OprData.AutoMotiveLot = True
                'This lot is Automotive
                If Not permission.CheckMachineAutomotive(Procees, MCNo) Then
                    ErrMesETG = "MC No.นี้ไม่สามารถรัน Lot Automotive ได้ "
                    '_OperatorAlarm = "Machine cannot run the automotive lot,Please contact ETG"
                    'MsgBox("MC No.นี้ไม่สามารถรัน Lot Automotive ได้  กรุณาติดต่อ ETG/SYSTEM")
                    Return False
                End If

                AuthenPass = permission.AuthenUser(strNextOperatorNo, GetUserAuthenGroupByMCType) And permission.AuthenUser(strNextOperatorNo, "AUTOMOTIVE")
                If AuthenPass = False Then AuthenPass = permission.AuthenUser(strNextOperatorNo, GL_Group) 'GL Can run every condition
                If AuthenPass = False Then
                    ErrMesETG = "OP No.นี้ไม่สามารถรัน Lot Automotive ได้" 'MsgBox("OP No.นี้ไม่สามารถรัน Lot Automotive ได้  กรุณาติดต่อ ETG/SYSTEM")
                    '_OperatorAlarm = "OP No cannot run the automotive lot ,Please contact ETG"
                End If

            Else
                OprData.AutoMotiveLot = False
                'This lot isn't Automotive
                AuthenPass = permission.AuthenUser(strNextOperatorNo, GetUserAuthenGroupByMCType)
                If AuthenPass = False Then AuthenPass = permission.AuthenUser(strNextOperatorNo, GL_Group)
                If AuthenPass = False Then
                    ErrMesETG = "OP No.นี้ไม่สามารถรันได้ license หมดอายุ หรือ ไม่มี license " 'MsgBox("OP No.นี้ไม่สามารถรันได้  กรุณาติดต่อ ETG/SYSTEM")
                    '_OperatorAlarm = "OP No cannot run ,Please contact ETG"
                End If

            End If

            Return AuthenPass
        Catch ex As Exception 'Network Error
            ErrMesETG = "Connection Error"
            Return False
        End Try
    End Function


    Public Function UserAuthen(ByVal strNextOperatorNo As String, ByVal GetUserAuthenGroupByMCType As String, ByVal GL_Group As String) As Boolean
        Dim permission As New AuthenticationUser.AuthenUser
        Dim AuthenPass As Boolean

        AuthenPass = permission.AuthenUser(strNextOperatorNo, GetUserAuthenGroupByMCType)
        If AuthenPass = False Then AuthenPass = permission.AuthenUser(strNextOperatorNo, GL_Group)
        If AuthenPass = False Then
            ErrMesETG = "OP No.นี้ไม่สามารถรันได้  " 'MsgBox("OP No.นี้ไม่สามารถรันได้  กรุณาติดต่อ ETG/SYSTEM")
            '_OperatorAlarm = "OP No cannot run ,Please contact ETG"
        End If

        Return AuthenPass
    End Function


#End Region


#Region "ChemicalDeflash Protolcol"

    Public Sub Event_LotStart(ByVal LotNo As String)
        RaiseEvent E_Update_dgvProductionDetail("1665500", LotNo, "MECO-LotStart", "")
    End Sub
    Public Sub Event_MachineStatus(ByVal LotNo As String)

        Dim runstate As MachineProcessingState
        If m_SelfData.ProcessState = 5 Then
            runstate = MachineProcessingState.Idle
        ElseIf m_SelfData.ProcessState = 7 Then
            runstate = MachineProcessingState.Execute
        End If
        If runstate <> 0 Then
            Try
                c_IlibraryService.UpdateMachineState("PL-" & My.Settings.EquipmentNo, runstate)
            Catch ex As Exception

            End Try

            'UpdateMachineState(MachineInfo, runstate, c_Log)
        End If

        RaiseEvent E_Update_dgvProductionDetail("1668300", "", "MECO-MachineStatus", "")
    End Sub
    Public Sub Event_LotInfo_Rohm(ByVal LotNo As String, ByVal OPNo As String, ByVal Mgz As String)
        Dim newMecoRow As DBxDataSet.PLDataRow = DBxDataSet.PLData.NewPLDataRow
        Try
            If LotNo.Length > 10 Then
                newMecoRow.LotNo = LotNo.Substring(0, 10).Trim
            Else
                newMecoRow.LotNo = LotNo.Trim
            End If

        Catch ex As Exception
            SaveCatchLog(ex.Message & "  " & CStr(LotNo), "LotNo.Substring")
        End Try

        Try
            TransactionCheck(m_SelfData.LotName, m_SelfData.DeviceName, m_SelfData.RecipeName)
        Catch ex As Exception
            SaveCatchLog(ex.Message & "  " & CStr(LotNo), "TransactionCheck")
        End Try

        newMecoRow.MCNo = My.Settings.ProcessName & "-" & My.Settings.EquipmentNo
        newMecoRow.OPNo = OPNo
        newMecoRow.MagazineNo = Mgz
        newMecoRow.LotStartTime = Now
        newMecoRow.NetVersion = m_strNetVersion
        DBxDataSet.PLData.Rows.Add(newMecoRow)


        SavePLDataTableBin()
        'APCS Pro
        Try
            Dim result As SetupLotResult = c_IlibraryService.SetupLotNoCheckLicenser(LotNo, "PL-" & My.Settings.EquipmentNo, OPNo, "PL", "0501")
            c_IlibraryService.StartLot(LotNo, "PL-" & My.Settings.EquipmentNo, OPNo, result.Recipe)
        Catch ex As Exception

        End Try
        RaiseEvent E_Update_dgvProductionDetail("1666700", LotNo, "MECO-LotInfo_Rohm", "")
    End Sub


    Public Sub Event_MgzStartLoading(ByVal LotNo As String)

        Dim strLotNo As String
        If LotNo.Length > 10 Then
            strLotNo = LotNo.Substring(0, 10).Trim
        Else
            strLotNo = LotNo.Trim
        End If

        For Each strDataRow As DBxDataSet.PLDataRow In DBxDataSet.PLData.Rows
            If strDataRow.LotNo.Trim = strLotNo AndAlso strDataRow.IsLotEndTimeNull = True Then
                strDataRow.LotStartTime = Now
                Exit For
            End If
        Next

        'For i = 0 To PLDataDataGridView.Rows.Count - 1
        '    If PLDataDataGridView.Rows(i).Cells(0).Value.ToString = LotNo Then
        '        PLDataDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Lime
        '    End If
        'Next

        SavePLDataStartTimeToDbx(strLotNo)
        SavePLDataTableBin()

        RaiseEvent E_Update_dgvProductionDetail("1667100", LotNo, "MECO-MgzStartLoading", "")

    End Sub

    Public Sub Event_LotEnd(ByVal LotNo As String, ByVal UnloadGood As Integer, ByVal LoadCountInput As Integer)

        Dim strLotNo As String
        If LotNo.Length > 10 Then
            strLotNo = LotNo.Substring(0, 10).Trim
        Else
            strLotNo = LotNo.Trim
        End If

        For Each strDataRow As DBxDataSet.PLDataRow In DBxDataSet.PLData.Rows
            If strDataRow.LotNo.Trim = strLotNo AndAlso strDataRow.IsLotEndTimeNull = True Then
                strDataRow.LotEndTime = Now
                strDataRow.UnloadCount = UnloadGood
                strDataRow.LoadCount = LoadCountInput
                Exit For
            End If
        Next

        For i = 0 To PLDataDataGridView.Rows.Count - 1
            If PLDataDataGridView.Rows(i).Cells(0).Value.ToString = strLotNo Then
                PLDataDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If
        Next

        SavePLDataTableBin()

        RaiseEvent E_Update_dgvProductionDetail("1666500", strLotNo, "MECO-LotEnd UnloadGood :" & UnloadGood & " LoadCountInput :" & LoadCountInput, "")

    End Sub

    Public Sub Event_MgzDoneLoading(ByVal LotNo As String, ByVal InputQty As Integer)

        Dim strLotNo As String
        If LotNo.Length > 10 Then
            strLotNo = LotNo.Substring(0, 10).Trim
        Else
            strLotNo = LotNo.Trim
        End If

        For Each strDataRow As DBxDataSet.PLDataRow In DBxDataSet.PLData.Rows
            If strDataRow.LotNo.Trim = strLotNo AndAlso strDataRow.IsLotEndTimeNull = True Then
                strDataRow.LoadCount = InputQty
                Exit For
            End If
        Next
        SavePLDataTableBin()
        RaiseEvent E_Update_dgvProductionDetail("1666900", strLotNo, "MECO-MgzDoneLoading Input :" & InputQty, "")
    End Sub


    Public Sub Event_CountData(ByVal LotNo As String, ByVal UnloadGood As Integer, ByVal LoadInputQty As Integer, ByVal EventName As String)

        Dim strLotNo As String
        If LotNo.Length > 10 Then
            strLotNo = LotNo.Substring(0, 10).Trim
        Else
            strLotNo = LotNo.Trim
        End If

        For Each strDataRow As DBxDataSet.PLDataRow In DBxDataSet.PLData.Rows
            If strDataRow.LotNo.Trim = strLotNo AndAlso strDataRow.IsLotEndTimeNull = True Then
                strDataRow.UnloadCount = UnloadGood
                strDataRow.LoadCount = LoadInputQty
                Exit For
            End If
        Next
        SavePLDataTableBin()
        RaiseEvent E_Update_dgvProductionDetail("1665600", strLotNo, "MECO-" & EventName & " Unload :" & UnloadGood & " LoadInput :" & LoadInputQty, "")
    End Sub


    Sub SavePLDataTableBin()
        Dim PathData As String = My.Application.Info.DirectoryPath & "\PLdata.bin"
        Using sw As StreamWriter = New StreamWriter(PathData)
            Dim b As BinaryFormatter = New BinaryFormatter()
            b.Serialize(sw.BaseStream, DBxDataSet.PLData)
        End Using
    End Sub
    Private Sub LoadPLDataTableBin()
        Dim PathData As String = My.Application.Info.DirectoryPath & "\PLdata.bin"
        If File.Exists(PathData) = False Then
            Exit Sub
        End If
        Try


            Using sw As StreamReader = New StreamReader(PathData)
                Dim b As BinaryFormatter = New BinaryFormatter()
                Dim tempTable As DBxDataSet.PLDataDataTable = CType(b.Deserialize(sw.BaseStream), DBxDataSet.PLDataDataTable)
                For Each tempRow As DBxDataSet.PLDataRow In tempTable.Rows
                    DBxDataSet.PLData.ImportRow(tempRow)
                Next
            End Using

            For i = 0 To PLDataDataGridView.Rows.Count - 1
                If PLDataDataGridView.Rows(i).Cells(5).Value.ToString <> "" Then
                    PLDataDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    'Else
                    '    PLDataDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Lime
                End If
            Next
        Catch ex As Exception
            SaveCatchLog(ex.ToString, "LoadPLDataTableBin()")
        End Try
    End Sub
    Dim removeList As List(Of DataRow)
    Private Sub PLDataDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PLDataDataGridView.CellClick

        DBxDataSet.PLData.DefaultView.Sort() = "LotStartTime ASC"

        removeList = New List(Of DataRow)
        For Each strDataRow As DBxDataSet.PLDataRow In DBxDataSet.PLData.Rows
            If e.RowIndex <> -1 Then

                If strDataRow.LotNo = PLDataDataGridView.Rows(e.RowIndex).Cells(0).Value.ToString AndAlso strDataRow.IsLotEndTimeNull = False Then

                    Dim _LotNo As String
                    Dim _TotalInput As Integer
                    Dim _TotalGood As Integer
                    Dim _LotStartTime As String
                    Dim _LotEndTime As String
                    Dim _Magazine As String

                    If strDataRow.IsLoadCountNull = True OrElse strDataRow.IsUnloadCountNull = True OrElse strDataRow.IsLotEndTimeNull = True Then
                        Exit Sub
                    Else
                        _LotNo = strDataRow.LotNo
                        _TotalInput = strDataRow.LoadCount
                        _TotalGood = strDataRow.UnloadCount
                        _LotStartTime = Format(strDataRow.LotStartTime, "yyyy/MM/dd HH:mm:ss")
                        _LotEndTime = Format(strDataRow.LotEndTime, "yyyy/MM/dd HH:mm:ss")
                        If strDataRow.IsMagazineNoNull = False Then
                            _Magazine = strDataRow.MagazineNo
                        Else
                            _Magazine = ""
                        End If

                    End If

                    Dim frmCon As New frmConfirm(_LotNo, _TotalInput, _TotalGood, _LotStartTime, _LotEndTime, _Magazine)
                    If frmCon.ShowDialog = Windows.Forms.DialogResult.OK Then

                        strDataRow.InputQtyAdjust = CInt(frmCon.tbTotalInput.Text)
                        strDataRow.TotalGoodAdjust = CInt(frmCon.tbTotalGood.Text)
                        strDataRow.TotalNGAdjust = CInt(frmCon.tbTotalNG.Text)

                        strDataRow.LoadCount = CInt(frmCon.tbTotalInput.Text)
                        strDataRow.UnloadCount = CInt(frmCon.tbTotalGood.Text)

                        strDataRow.DummyQty = CInt(frmCon.tbDummy.Text)
                        strDataRow.OPJudgement = frmCon.tbOPJudge.Text

                        If strDataRow.LotNo.Contains("DUM") = True OrElse strDataRow.LotNo.Contains("dum") = True Then
                            GoTo Dummy
                        Else
                            If PLDataTableAdapter.Update(strDataRow) <> 1 Then 'เซฟไม่ติด
                                'backup and update 
                                Dim Tabledata As New DBxDataSet.PLDataDataTable
                                Tabledata.ImportRow(strDataRow)
                                Dim pathData As String = My.Application.Info.DirectoryPath & "\DataError\" & strDataRow.LotNo & ".xml"
                                Using sw As New StreamWriter(pathData, True)
                                    Tabledata.WriteXml(sw)
                                End Using
                            End If
                        End If
Dummy:
                        removeList.Add(strDataRow)
                        SavePLDataTableBin()
                        SavePLAlarmInfoToDbx()

                        'Send LotSet TDC
                        SyncLock m_Locker
                            Dim tdc As New TdcData
                            tdc.McNo = "PL-" & My.Settings.EquipmentNo
                            tdc.LotNo = strDataRow.LotNo
                            tdc.LotStartTime = strDataRow.LotStartTime
                            tdc.LotEndTime = strDataRow.LotEndTime
                            tdc.TdcStartMode = RunModeType.Normal
                            tdc.TdcEndMode = EndModeType.Normal
                            tdc.GoodPcs = strDataRow.TotalGoodAdjust
                            tdc.NgPcs = strDataRow.TotalNGAdjust
                            tdc.OpNo = strDataRow.OPNo
                            c_TdcQueue.Enqueue(tdc)

                        End SyncLock

                    End If
                End If

            End If
        Next

        If bgTDC.IsBusy = False Then
            bgTDC.RunWorkerAsync()
        End If

        'For Each removeDataRow As DataRow In removeList
        '    DBxDataSet.PLData.Rows.Remove(removeDataRow)
        'Next
    End Sub

#End Region

    '--------------------- Cleanning File

    Private WithEvents BackUp As New BackgroundWorker

    Friend Sub BackUpLotClean()
        BackUp.RunWorkerAsync()

    End Sub
    Private Sub DoBackup(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackUp.DoWork
        Try

            Dim Dirs = Directory.GetDirectories(BackUpObj)
            If Dirs.Count > 100 Then   'Store 100 Files over then move to BackUpOld 100 files
                For Each DirSo In Dirs
                    Dim DirInfo As New System.IO.DirectoryInfo(DirSo)
                    Directory.Move(DirSo, Path.Combine(BackUpObjOld, DirInfo.Name))
                Next
            End If
            Dim OldDirs = Directory.GetDirectories(BackUpObjOld)
            If OldDirs.Count > 100 Then           'if over 100 Files del 10 Files of BackUpOld
                Dim DirDes = From l In OldDirs Order By Directory.GetCreationTime(l) Ascending    'SortFile by Modify time
                For i = 0 To 10
                    Directory.Delete(DirDes(i), True)             'Del 10 Files
                Next

            End If
            e.Result = ""
        Catch ex As Exception
            e.Result = ex.ToString
        End Try

    End Sub
    Private Sub Backup_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackUp.RunWorkerCompleted
        Dim result As String = CStr(e.Result)
        'If result = "" Then
        '    RaiseEvent E_SlInfo("DoBackUp Success")
        'End If

        SaveCatchLog(result, "DoBackUp()")

    End Sub


#Region "Debug"

    Public Sub ax()
        MsgBox("text")
    End Sub

    'Debug------Area===================================
    Dim ID As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



        'AlarmTable(True, CStr(ID), "TEXT")
        'Update_dgvProductionInfo1(CStr(A), "555", "22", "33")
        'ID += 1
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim AX As New Thread(AddressOf A1)
        Dim BX As New Thread(AddressOf B1)
        AX.Start()
        BX.Start()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CX As New Thread(AddressOf c1)
        CX.Start()
    End Sub


    Dim OBJA As New Object
    Dim A As Integer
    Private Sub A1()

        'SyncLock OBJA
        '    Thread.Sleep(2000)

        'End SyncLock

        Update_dgvProductionDetail(CStr(A), "AA", "")
        A += 1
    End Sub
    Private Sub B1()

        SaveCatchLog("TestCatchlog", "B")

        'Thread.Sleep(100)

        'SyncLock OBJA
        '    Thread.Sleep(2000)

        'End SyncLock
        'Update_dgvProductionInfo1("Carr", CStr(A), "B", "BB")


    End Sub
    Private Sub c1()

        Update_dgvProductionInfoEnd(CStr(A), "555", "C")
        A += 1
    End Sub



    '=====================================================

#End Region



    Function m_LotEndTime() As String
        Throw New NotImplementedException
    End Function

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDeleteLot.Click
        'Dim LotNo
        'Dim c_ApcsProService As IApcsProService
        'Dim lotInfo As iLibrary.LotInfo
        'Dim machineInfo As MachineInfo
        'Dim userInfo As UserInfo
        'Dim currentServerTime As DateTimeInfo
        'Dim strHostName As String
        'Dim strIPAddress As String
        'strHostName = System.Net.Dns.GetHostName()
        'strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        'Dim machineInfoArray As MachineInfo() = c_ApcsProService.GetMachineInfoArrayByCellConIp(My.Settings.EquipmentIP)

        'For Each mc As MachineInfo In machineInfoArray
        '    machineInfo = mc
        'Next

        'Dim log As New Logger

        'Dim setupResult As LotUpdateInfo = Nothing
        'lotInfo = c_ApcsProService.GetLotInfo(LotNo)
        'machineInfo = c_ApcsProService.GetMachineInfo(machineInfo.Id)
        'userInfo = c_ApcsProService.GetUserInfo(OPNo)
        'currentServerTime = c_ApcsProService.Get_DateTimeInfo(log)
        'setupResult = c_ApcsProService.LotSetup(lotInfo.Id, machineInfo.Id, userInfo.Id, "", "", 1, currentServerTime.Datetime, log)

        'setupResult = c_ApcsProService.LotStart(lotInfo.Id, machineInfo.Id, userInfo.Id, "", "", 1, currentServerTime.Datetime, log)
        Dim frmDelete As New frmDeleteLot(Me)
        frmDelete.ShowDialog()
        SavePLDataTableBin()
    End Sub

    Public Sub m_AlarmRecord(ByVal AlarmNo As String, ByVal StatusAld As Integer, ByVal strAlarmText As String)
        If DBxDataSet.PLData.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim strAlarmID As String = GetAlarmID(AlarmNo)
        If strAlarmID = "" Then
            Exit Sub
        End If

        For Each strDataRow As DBxDataSet.PLDataRow In DBxDataSet.PLData.Rows
            If StatusAld = 0 Then 'AlarmClear
                AlarmIsClearToTable(strAlarmID, strDataRow.LotNo)
                RaiseEvent E_AlarmTable(False, AlarmNo, strAlarmText, "")
            Else 'AlarmSet
                AlarmIsSetToTable(strAlarmID, strDataRow.LotNo)
                RaiseEvent E_AlarmTable(True, AlarmNo, strAlarmText, "")
            End If
        Next
    End Sub


    Function GetAlarmID(ByVal AlarmNo As String) As String
        Dim strMC As String = ""
        Dim MCNo As String = "PL-" & My.Settings.EquipmentNo
        Select Case MCNo
            Case "PL-M-01"
                strMC = "MECO1"
            Case "PL-M-02"
                strMC = "MECO2"
            Case "PL-M-03"
                strMC = "MECO3"
            Case "PL-M-04"
                strMC = "MECO4"
            Case Else
                Return ""
        End Select
        Dim ALIDFromTable As String = Nothing
        Try
            ALIDFromTable = CStr(PLAlarmTableTableAdapter.GetAlarmID(strMC, CInt(AlarmNo)))
        Catch ex As Exception
            Return ""
        End Try

        Return ALIDFromTable

    End Function


    Sub AlarmIsSetToTable(ByVal ALID As String, ByVal LotNo As String)
        For Each strDataRow As DBxDataSet.PLDataRow In DBxDataSet.PLData.Rows
            Dim PLAlarmInfoRow As DBxDataSet.PLAlarmInfoRow = DBxDataSet.PLAlarmInfo.NewPLAlarmInfoRow
            PLAlarmInfoRow.AlarmID = CInt(ALID)
            PLAlarmInfoRow.RecordTime = Now
            PLAlarmInfoRow.MCNo = "PL-" & My.Settings.EquipmentNo
            PLAlarmInfoRow.LotNo = strDataRow.LotNo
            DBxDataSet.PLAlarmInfo.Rows.Add(PLAlarmInfoRow)
        Next
        SavePLAlarmInfoTable()
    End Sub

    Sub AlarmIsClearToTable(ByVal ALID As String, ByVal LotNo As String)
        Dim CheckAlarmIsClear As Boolean = False
        For Each DataRow As DBxDataSet.PLAlarmInfoRow In DBxDataSet.PLAlarmInfo
            If DataRow.AlarmID = CDbl(ALID) AndAlso DataRow.IsClearTimeNull = True AndAlso DataRow.LotNo = LotNo Then
                DataRow.ClearTime = Now
                CheckAlarmIsClear = True
                Exit For
            End If
        Next
        If CheckAlarmIsClear = True Then
            SavePLAlarmInfoTable()
        End If
    End Sub

    Sub SavePLAlarmInfoTable()
        Dim PathPLAlarm As String = Path.Combine(My.Application.Info.DirectoryPath, "PLAlarmInfo.xml")
        Using sw As StreamWriter = New StreamWriter(PathPLAlarm)
            DBxDataSet.PLAlarmInfo.WriteXml(sw)
        End Using
    End Sub

    Sub LoadPLAlarmInfoTable()
        Dim PathPLAlarm As String = Path.Combine(My.Application.Info.DirectoryPath, "PLAlarmInfo.xml")
        If File.Exists(PathPLAlarm) = False Then
            Exit Sub
        End If
        Using sr As StreamReader = New StreamReader(PathPLAlarm)
            DBxDataSet.PLAlarmInfo.ReadXml(sr)
        End Using
    End Sub

    Sub SavePLAlarmInfoToDbx()
        Dim removelist As List(Of DataRow) = New List(Of DataRow)
        For Each DbxRowData As DBxDataSet.PLAlarmInfoRow In DBxDataSet.PLAlarmInfo.Rows
            If DbxRowData.IsClearTimeNull = False Then
                Try
                    Dim AfterUpdate As Integer = PLAlarmInfoTableAdapter.Update(DbxRowData)
                    removelist.Add(DbxRowData)
                Catch ex As Exception
                    removelist.Add(DbxRowData)
                    DataErrPLAlarmInfo(DbxRowData)
                End Try
            End If
        Next
        For Each row As DataRow In removelist
            DBxDataSet.PLAlarmInfo.Rows.Remove(row)
        Next
        SavePLAlarmInfoTable()
    End Sub

    Sub DataErrPLAlarmInfo(ByVal _Datarow As DBxDataSet.PLAlarmInfoRow)
        Dim RandomFileName As String = Guid.NewGuid.ToString & ".xml"
        Dim folder As String = Path.Combine(My.Application.Info.DirectoryPath, "DataError\AlarmData")
        If Not Directory.Exists(folder) Then
            Directory.CreateDirectory(folder)
        End If
        Using table As DBxDataSet.PLAlarmInfoDataTable = New DBxDataSet.PLAlarmInfoDataTable
            table.ImportRow(_Datarow)
            Using sw As StreamWriter = New StreamWriter(Path.Combine(folder, RandomFileName))
                table.WriteXml(sw.BaseStream)
            End Using
        End Using
    End Sub


    Private Sub bgTDC_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgTDC.DoWork

RepeatSendTdc:
        Dim tdc As TdcData = c_TdcQueue.Dequeue()


        'MoveLot(tdc)

        'Dim resSet As TdcResponse = m_TdcService.LotSet(tdc.McNo, tdc.LotNo, tdc.LotStartTime, tdc.OpNo, tdc.TdcStartMode)

        'Dim resEnd As TdcResponse = m_TdcService.LotEnd(tdc.McNo, tdc.LotNo, tdc.LotEndTime, tdc.GoodPcs, tdc.NgPcs, tdc.TdcEndMode, tdc.OpNo)
        ''APCS Pro
        'Try
        '    Dim result As SetupLotResult = c_IlibraryService.SetupLotNoCheckLicenser(tdc.LotNo, "PL-" & My.Settings.EquipmentNo, tdc.OpNo, "PL", "0501")
        '    c_IlibraryService.StartLot(tdc.LotNo, "PL-" & My.Settings.EquipmentNo, tdc.OpNo, result.Recipe)
        'Catch ex As Exception

        'End Try
        Try
            c_IlibraryService.EndLotNoCheckLicenser(tdc.LotNo, tdc.McNo, tdc.OpNo, tdc.GoodPcs, tdc.NgPcs)
        Catch ex As Exception

        End Try
        'LotEndPro(tdc.LotNo, tdc.GoodPcs, tdc.NgPcs, tdc.OpNo)

        If c_TdcQueue.Count() <> 0 Then
            GoTo RepeatSendTdc
        End If
    End Sub

    Public Sub addErrLogfile(ByVal m As String)
        Dim logfile As String = My.Application.Info.DirectoryPath & "\LOG\ErrLog.txt"
        Try
            Dim outfile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(logfile, True)
            outfile.WriteLine(Date.Now & " : " & m)
            outfile.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim sr As StreamReader = File.OpenText(logfile)
        If sr.BaseStream.Length > 2000000 Then
            sr.Close()
            If File.Exists(My.Application.Info.DirectoryPath & "\LOG\LOGDATA1.txt") Then
                File.Delete(My.Application.Info.DirectoryPath & "\LOG\LOGDATA1.txt")
            End If
            File.Copy(logfile, My.Application.Info.DirectoryPath & "\LOG\LOGDATA1.txt")
            File.Delete(logfile)
        End If
        sr.Close()

    End Sub

    Private Sub SavePLDataStartTimeToDbx(ByVal _LotNo As String)
        For Each strDataRow As DBxDataSet.PLDataRow In DBxDataSet.PLData.Rows
            If _LotNo = strDataRow.LotNo Then
                PLDataTableAdapter.Update(strDataRow)
                Exit Sub
            End If
        Next
    End Sub


    Private Sub btEndManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEndManual.Click
        If DBxDataSet.PLData.Rows.Count <> 0 Then
            Dim frmEnd As New frmLotEndManual(Me)
            frmEnd.ShowDialog()
        End If
    End Sub

    Private Sub WorkRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkRecordToolStripMenuItem.Click
        Dim WebERecord As String = "http://webserv.thematrix.net/erecord/WebForm1.aspx?"
        Dim dDate As DateTime = Now
        If Now.Hour < 8 Then
            dDate = dDate.AddDays(-1)
        End If
        Dim sb As String = ""
        sb += "qsTime1=" + Format(dDate, "yyyy/MM/dd") + " 08:00:00"
        sb += "&qsTime2=" + Format(dDate.AddDays(1), "yyyy/MM/dd") + " 08:00:00"
        sb += "&qsMCNo=PL-" + My.Settings.EquipmentNo
        Call Shell("C:\Program Files\Internet Explorer\iexplore.exe " + WebERecord + sb, AppWinStyle.NormalFocus)

    End Sub


    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MDIParent1.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbTime.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frmMag As New frmEditData(Me)
        If frmMag.ShowDialog = Windows.Forms.DialogResult.OK Then
            SavePLDataTableBin()
        End If
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MDIParent1.Send_S6F23_PurgeSpool()
        MDIParent1.Send_S6F23_PurgeSpool()
    End Sub



    Public Sub TransactionCheck(ByVal _LotNo As String, ByVal _Device As String, ByVal _Package As String)
        Dim strLotData As String
        strLotData = CStr(QueriesTableAdapter1.SearchLotNoInTrans(_LotNo))
        If strLotData = Nothing Then
            Dim Pack As String
            Dim Device As String

            If _Device.Length > 20 Then
                Device = _Device.Substring(0, 20)
            Else
                Device = _Device
            End If
            If _Package.Length > 10 Then
                Pack = _Package.Substring(0, 10)
            Else
                Pack = _Package
            End If

            Dim table As DBxDataSet.TransactionDataRow = DBxDataSet.TransactionData.NewTransactionDataRow
            table.LotNo = _LotNo
            table.Device = Device
            table.Package = Pack

            DBxDataSet.TransactionData.Rows.Add(table)

            If TransactionDataTableAdapter1.Update(DBxDataSet.TransactionData) <> 0 Then
                DBxDataSet.TransactionData.Rows.Clear()
            End If

        End If
    End Sub


    '#Region "Apcs_Pro Valiable"
    '    Private c_ApcsProService As IApcsProService = New ApcsProService()
    '    Private lotInfo As iLibrary.LotInfo
    '    Private machineInfo As MachineInfo
    '    Private userInfo As UserInfo
    '    Private currentServerTime As DateTimeInfo
    '    Private c_Log As New Logger("1.00", "PL-" + My.Settings.EquipmentNo)
    '    Private ResultApcsProService As LotUpdateInfo = Nothing
    '    ' Private c_ApcsPro2 As New ApcsPro
    '#End Region
    '    'Private Sub GetInfoApcsPro(LotNo As String, MCNo As String, OPNo As String)
    '    '    Try
    '    '        log.OperationLogger.Write(0, "GetInfoApcsPro", "OUT", "CellCon", "iLibrary", 0, "GetLotInfo,GetMachineInfo,GetUserInfo", "MCNo :" & MCNo & ",OPNo :" & OPNo & ",LotNo :" & LotNo, "")

    '    '        lotInfo = c_ApcsProService.GetLotInfo(LotNo)
    '    '        machineInfo = c_ApcsProService.GetMachineInfo(MCNo)
    '    '        userInfo = c_ApcsProService.GetUserInfo(OPNo)
    '    '    Catch ex As Exception
    '    '        log.ConnectionLogger.Write(0, "GetInfoApcsPro", "OUT", "CellCon", "iLibrary", 0, "GetLotInfo,GetMachineInfo,GetUserInfo", ex.Message.ToString(), "LotNo:" & LotNo & ",MCNo:" & MCNo & ",OPNo:" & OPNo)
    '    '    End Try

    '    'End Sub
    '    Private Function GetLotInfo(LotNo As String) As iLibrary.LotInfo
    '        Try
    '            c_Log.OperationLogger.Write(0, "GetLotInfo", "OUT", "CellCon", "iLibrary", 0, "GetLotInfo", "LotNo :" & LotNo, "")

    '            Return c_ApcsProService.GetLotInfo(LotNo, c_Log, Date.Now)
    '        Catch ex As Exception
    '            c_Log.ConnectionLogger.Write(0, "GetLotInfo", "OUT", "CellCon", "iLibrary", 0, "GetLotInfo", ex.Message.ToString(), "LotNo :" & LotNo)
    '            Return Nothing
    '        End Try
    '    End Function
    '    Private Function GetMachineInfo(MCNo As String) As MachineInfo
    '        Try
    '            c_Log.OperationLogger.Write(0, "GetMachineInfo", "OUT", "CellCon", "iLibrary", 0, "GetMachineInfo", "MCNo :" & MCNo, "")
    '            Return c_ApcsProService.GetMachineInfo(MCNo, c_Log, Date.Now)
    '        Catch ex As Exception
    '            c_Log.ConnectionLogger.Write(0, "GetMachineInfo", "OUT", "CellCon", "iLibrary", 0, "GetMachineInfo", ex.Message.ToString(), "MCNo :" & MCNo)
    '            Return Nothing
    '        End Try
    '    End Function
    '    Private Function GetUserInfo(OpNo As String) As UserInfo
    '        Try
    '            c_Log.OperationLogger.Write(0, "GetUserInfo", "OUT", "CellCon", "iLibrary", 0, "GetUserInfo", "OpNo :" & OpNo, "")
    '            Return c_ApcsProService.GetUserInfo(OpNo, c_Log, Date.Now)
    '        Catch ex As Exception
    '            c_Log.ConnectionLogger.Write(0, "GetUserInfo", "OUT", "CellCon", "iLibrary", 0, "GetUserInfo", ex.Message.ToString(), "OpNo :" & OpNo)
    '            Return Nothing
    '        End Try
    '    End Function
    '#Region "Apcs_Pro LotSetUp and LotStart"
    '    Private Function ToXml(source As Object) As String
    '        Try
    '            Dim xs As XmlSerializer = New XmlSerializer(source.GetType())
    '            Dim writer As StringWriter = New StringWriter()
    '            xs.Serialize(writer, source)
    '            Return writer.ToString()
    '        Catch ex As Exception
    '            Return ""
    '        End Try

    '    End Function
    '    Private Function CreateTableToXml(LotNo As String) As String
    '        Try
    '            Dim table As New DBxDataSet.PLDataDataTable
    '            Dim newRow As DBxDataSet.PLDataRow = table.NewPLDataRow

    '            For Each row As DBxDataSet.PLDataRow In DBxDataSet.PLData
    '                If row.LotNo = LotNo Then
    '                    newRow.LotNo = row.LotNo
    '                    newRow.LotStartTime = row.LotStartTime
    '                    newRow.MCNo = row.MCNo
    '                    If Not row.IsABNormalNull Then
    '                        newRow.ABNormal = row.ABNormal
    '                    End If
    '                    If Not row.IsDummyQtyNull Then
    '                        newRow.DummyQty = row.DummyQty
    '                    End If
    '                    If Not row.IsInputQtyAdjustNull Then
    '                        newRow.InputQtyAdjust = row.InputQtyAdjust
    '                    End If
    '                    If Not row.IsLoadCountNull Then
    '                        newRow.LoadCount = row.LoadCount
    '                    End If
    '                    If Not row.IsLotEndTimeNull Then
    '                        newRow.LotEndTime = row.LotEndTime
    '                    End If
    '                    If Not row.IsMagazineNoNull Then
    '                        newRow.MagazineNo = row.MagazineNo
    '                    End If
    '                    If Not row.IsMaterialNull Then
    '                        newRow.Material = row.Material
    '                    End If
    '                    If Not row.IsNetVersionNull Then
    '                        newRow.NetVersion = row.NetVersion
    '                    End If
    '                    If Not row.IsOPJudgementNull Then
    '                        newRow.OPJudgement = row.OPJudgement
    '                    End If
    '                    If Not row.IsOPNoNull Then
    '                        newRow.OPNo = row.OPNo
    '                    End If
    '                    If Not row.IsRemarkNull Then
    '                        newRow.Remark = row.Remark
    '                    End If
    '                    If Not row.IsSelfConVersionNull Then
    '                        newRow.SelfConVersion = row.SelfConVersion
    '                    End If
    '                    If Not row.IsTotalGoodAdjustNull Then
    '                        newRow.TotalGoodAdjust = row.TotalGoodAdjust
    '                    End If
    '                    If Not row.IsTotalNGAdjustNull Then
    '                        newRow.TotalNGAdjust = row.TotalNGAdjust
    '                    End If
    '                    If Not row.IsUnloadCountNull Then
    '                        newRow.UnloadCount = row.UnloadCount
    '                    End If
    '                    Exit For
    '                End If
    '            Next
    '            table.Rows.Add(newRow)
    '            Return ToXml(table)

    '        Catch ex As Exception
    '            Return ""
    '        End Try

    '    End Function
    '    Private Sub LotSetUpAndLotStartPro(MCNo As String, LotNo As String, OPNo As String)
    '        Try
    '            'log = New Logger("1.0", MCNo)
    '            'log.OperationLogger.Write(0, "LotSetUpAndLotStartPro", "OUT", "CellCon", "iLibrary", 0, "LotSetup", "MCNo :" & MCNo & ",OPNo :" & OPNo & ",LotNo :" & LotNo, "")

    '            Dim recipe As String = ""
    '            Dim ap As New DBxDataSetTableAdapters.QueriesTableAdapter
    '            If c_ApcsProService.CheckPackageEnable(ap.GetPackage(LotNo), c_Log) Then
    '                If c_ApcsProService.CheckLotisExist(LotNo, c_Log) Then
    '                    'GetInfoApcsPro(LotNo, MCNo, OPNo)
    '                    currentServerTime = c_ApcsProService.Get_DateTimeInfo(c_Log)

    '                    c_Log.OperationLogger.Write(0, "LotSetUpAndLotStartPro", "OUT", "CellCon", "iLibrary", 0, "LotSetup", "MCNo :" & MCNo & ",OPNo :" & OPNo & ",LotNo :" & LotNo, "")
    '                    Dim userId As Integer = GetUserInfo(OPNo).Id
    '                    Dim lotId As Integer = GetLotInfo(LotNo).Id
    '                    ResultApcsProService = c_ApcsProService.LotSetup(lotId, machineInfo.Id, userId, 0, "", 1, currentServerTime.Datetime, c_Log)
    '                    If Not ResultApcsProService.IsOk Then
    '                        c_Log.ConnectionLogger.Write(0, "LotSetUpAndLotStartPro", "OUT", "CellCon", "iLibrary", 0, "LotSetup", ResultApcsProService.ErrorNo & ":" & ResultApcsProService.ErrorMessage, LotNo)
    '                    End If
    '                    recipe = ResultApcsProService.Recipe1
    '                    c_Log.OperationLogger.Write(0, "LotSetUpAndLotStartPro", "OUT", "CellCon", "iLibrary", 0, "OnlineStart", "MCNo :" & MCNo & ",OPNo :" & OPNo & ",LotNo :" & LotNo & ",Recipe1 :" & ResultApcsProService.Recipe1, "")
    '                    ResultApcsProService = c_ApcsProService.OnlineStart(lotId, machineInfo.Id, userId, 0, CreateTableToXml(LotNo), 1, currentServerTime.Datetime, c_Log)
    '                    If Not ResultApcsProService.IsOk Then
    '                        c_Log.ConnectionLogger.Write(0, "LotSetUpAndLotStartPro", "OUT", "CellCon", "iLibrary", 0, "LotStart", ResultApcsProService.ErrorNo & ":" & ResultApcsProService.ErrorMessage, LotNo)
    '                    End If
    '                    c_Log.OperationLogger.Write(0, "LotSetUpAndLotStartPro", "OUT", "CellCon", "iLibrary", 0, "OnlineStart", "MCNo :" & MCNo & ",OPNo :" & OPNo & ",LotNo :" & LotNo & ",Recipe1 :" & recipe, "")
    '                    ResultApcsProService = c_ApcsProService.LotStart(lotId, machineInfo.Id, userId, 0, CreateTableToXml(LotNo), 1, recipe, currentServerTime.Datetime, c_Log)
    '                    If Not ResultApcsProService.IsOk Then
    '                        c_Log.ConnectionLogger.Write(0, "LotSetUpAndLotStartPro", "OUT", "CellCon", "iLibrary", 0, "LotStart", ResultApcsProService.ErrorNo & ":" & ResultApcsProService.ErrorMessage, LotNo)
    '                    End If
    '                End If
    '            End If


    '        Catch ex As Exception
    '            'addErrLogfile("c_ApcsProService.LotSetup,LotStart:" & ex.ToString())
    '            c_Log.ConnectionLogger.Write(0, "bgTDC_DoWork", "OUT", "CellCon", "iLibrary", 0, "LotSetup,LotStart", ex.Message.ToString(), LotNo)

    '        End Try

    '    End Sub
    '#End Region
    '#Region "APCS Pro LotEnd"
    '    Private Sub LotEndPro(LotNo As String, GoodQty As Integer, NGQTy As Integer, OpNo As String)
    '        Try
    '            Dim ap As New DBxDataSetTableAdapters.QueriesTableAdapter
    '            If c_ApcsProService.CheckPackageEnable(ap.GetPackage(LotNo), c_Log) Then
    '                If c_ApcsProService.CheckLotisExist(LotNo, c_Log) Then
    '                    currentServerTime = c_ApcsProService.Get_DateTimeInfo(c_Log)

    '                    c_Log.OperationLogger.Write(0, "LotEndPro", "OUT", "CellCon", "iLibrary", 0, "OnlineEnd", "Good :" & GoodQty & ",Ng :" & NGQTy & ",LotNo :" & LotNo, "")
    '                    ResultApcsProService = c_ApcsProService.OnlineEnd(GetLotInfo(LotNo).Id, machineInfo.Id, GetUserInfo(OpNo).Id, False, GoodQty, NGQTy, 0, CreateTableToXml(LotNo), 1, currentServerTime.Datetime, c_Log)

    '                    c_Log.OperationLogger.Write(0, "LotEndPro", "OUT", "CellCon", "iLibrary", 0, "LotEnd", "Good :" & GoodQty & ",Ng :" & NGQTy & ",LotNo :" & LotNo, "")
    '                    ResultApcsProService = c_ApcsProService.LotEnd(GetLotInfo(LotNo).Id, machineInfo.Id, GetUserInfo(OpNo).Id, False, GoodQty, NGQTy, 0, CreateTableToXml(LotNo), 1, currentServerTime.Datetime, c_Log)
    '                    If Not ResultApcsProService.IsOk Then
    '                        c_Log.ConnectionLogger.Write(0, "LotEndPro", "OUT", "CellCon", "iLibrary", 0, "LotEnd", ResultApcsProService.ErrorNo & ":" & ResultApcsProService.ErrorMessage, LotNo)
    '                    End If
    '                End If
    '            End If
    '        Catch ex As Exception
    '            c_Log.ConnectionLogger.Write(0, "LotEndPro", "OUT", "CellCon", "iLibrary", 0, "LotEnd", ex.Message, LotNo)
    '        End Try
    '    End Sub

    '#End Region
    '#Region "APCS Pro TDC Move Lot"
    '    Private Sub MoveLot(tdc_data As TdcData)
    '        Try
    '            Dim ap As New DBxDataSetTableAdapters.QueriesTableAdapter
    '            If c_ApcsProService.CheckPackageEnable(ap.GetPackage(tdc_data.LotNo), c_Log) Then
    '                If c_ApcsProService.CheckLotisExist(tdc_data.LotNo, c_Log) Then
    '                    Dim Res As TdcLotRequestResponse = m_TdcService.LotRequest(tdc_data.McNo, tdc_data.LotNo, RunModeType.Normal)
    '                    If (Res.HasError) Then
    '                        If Res.ErrorCode = "06" Or Res.ErrorCode = "02" Then
    '                            m_TdcService.MoveLot(tdc_data.LotNo, tdc_data.McNo, tdc_data.OpNo, "0501")
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        Catch ex As Exception
    '            c_Log.ConnectionLogger.Write(0, "ApcsProMoveLot", "OUT", "CellCon", "iLibrary", 0, "MoveLot", ex.Message, tdc_data.LotNo)
    '        End Try
    '    End Sub
    '#End Region
    '    Private XmlPathDataApcsPro As String = My.Application.Info.DirectoryPath & "\ApcsPro.xml"

    '    Enum MachineProcessingState
    '        Idle = 1
    '        Ready = 3
    '        Execute = 4
    '        Pause = 5
    '        LotSetUp = 6
    '    End Enum
    '    Private Sub UpdateMachineState(machineID As MachineInfo, runState As Integer, log As Logger, Optional userID As Integer = -1)
    '        Try
    '            log.OperationLogger.Write(0, "UpdateMachineOnlineState", "OUT", "CellCon", "iLibrary", 0, "Update_MachineOnlineState", "machineID:" & machineID.Id.ToString & ",runState:" & runState & ",userID:" & userID, "")
    '            c_ApcsProService.Update_MachineState(machineID.Id, runState, userID, log)
    '        Catch ex As Exception
    '            log.ConnectionLogger.Write(0, "UpdateMachineState", "OUT", "CellCon", "iLibrary", 0, "Update_MachineState", ex.Message, "")
    '        End Try

    '    End Sub
    '    Private Sub UpdateMachineOnlineState(onlineState As Integer, log As Logger, Optional userID As Integer = -1)

    '        Try

    '            'log = New Logger("1.0", "PL-" & My.Settings.EquipmentNo)
    '            log.OperationLogger.Write(0, "UpdateMachineOnlineState", "OUT", "CellCon", "iLibrary", 0, "GetMachineInfo", "PL-" & My.Settings.EquipmentNo, "")
    '            machineInfo = GetMachineInfo("PL-" & My.Settings.EquipmentNo)
    '            log.OperationLogger.Write(0, "UpdateMachineOnlineState", "OUT", "CellCon", "iLibrary", 0, "Update_MachineOnlineState", "PL-" & My.Settings.EquipmentNo, "")
    '            c_ApcsProService.Update_MachineOnlineState(machineInfo.Id, onlineState, userID, log)
    '        Catch ex As Exception
    '            log.ConnectionLogger.Write(0, "UpdateMachineOnlineState", "OUT", "CellCon", "iLibrary", 0, "Update_MachineOnlineState", ex.Message, "")
    '        End Try

    '    End Sub

    Private Sub bgTDC_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgTDC.RunWorkerCompleted
        For Each removeDataRow As DataRow In removeList
            DBxDataSet.PLData.Rows.Remove(removeDataRow)
        Next
    End Sub

End Class