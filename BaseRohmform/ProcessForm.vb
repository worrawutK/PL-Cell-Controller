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
Imports System.Data.SqlClient

Public Class ProcessForm

    Private c_MDIParent1 As MDIParent1
    Public Sub New(frm As MDIParent1)

        ' This call is required by the designer.
        InitializeComponent()
        c_IlibraryService = New ServiceiLibraryClient


        ' Add any initialization after the InitializeComponent() call.
        c_MDIParent1 = frm

        c_PLDataList = LoadDataFromXmlFile(Of BindingList(Of PLData))(c_PathPLDataList)
        If c_PLDataList Is Nothing Then
            c_PLDataList = New BindingList(Of PLData)
        End If
        c_PLAlarmInfos = LoadDataFromXmlFile(Of List(Of PLAlarmInfo))(c_PathPLAlarmInfoes)
        If c_PLAlarmInfos Is Nothing Then
            c_PLAlarmInfos = New List(Of PLAlarmInfo)
        End If
    End Sub
    Private WithEvents bgWorkerLoad As New BackgroundWorker
    Private Sub bgWorkerLoad_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorkerLoad.DoWork
        bgWorkerLoad.ReportProgress(1, LoadingFrom.ShowFrom)

        'PLDataBindingSource1.DataSource = c_PLDataList
        Try
            c_IlibraryService.MachineOnlineState("PL-" & My.Settings.EquipmentNo, MachineOnline.Online)
        Catch ex As Exception
            SaveCatchLog("Exception:" & ex.Message.ToString, "MachineOnlineState")
        End Try


        GetAlarmInfo(My.Settings.EquipmentNo)
        'Thread.Sleep(3000)

        e.Result = IReportCheck(lbMcNo.Text)
        bgWorkerLoad.ReportProgress(1, LoadingFrom.CloseFrom)
    End Sub
    'Private Sub bgWorkerLoad_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgWorkerLoad.ProgressChanged
    '    'Debug.Print("ProgressChanged :" + (e.ProgressPercentage.ToString() + "% >>" + e.UserState.ToString))
    '    'If frmLoading Is Nothing Then
    '    '    frmLoading = New FormLoading()
    '    'End If
    '    'If CType(e.UserState, LoadingFrom) = LoadingFrom.ShowFrom Then
    '    '    frmLoading.TopMost = True
    '    '    frmLoading.ShowDialog()
    '    'Else
    '    '    frmLoading.Close()
    '    'End If
    '    FromLoading(CType(e.UserState, LoadingFrom))

    'End Sub
    Private Sub FromLoading(loadState As LoadingFrom)
        ' Debug.Print("ProgressChanged :" + (e.ProgressPercentage.ToString() + "% >>" + e.UserState.ToString))
        If frmLoading Is Nothing Then
            frmLoading = New FormLoading()
        End If
        If loadState = LoadingFrom.ShowFrom Then
            frmLoading.TopMost = True
            frmLoading.ShowDialog()
        Else
            frmLoading.Visible = False
        End If
    End Sub
    Private Sub bgWorkerLoad_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorkerLoad.RunWorkerCompleted
        Try

            LabelIReportMessage.Text = CType(e.Result, String)
        Catch ex As Exception
            MessageBox.Show("Exception:" & ex.Message.ToString)
        End Try

    End Sub
    Private Sub ProcessForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bgWorkerLoad.WorkerReportsProgress = True
        bgWorkerLoad.RunWorkerAsync()

        c_MDIParent1.FrmProcessFill()
        lbMcNo.Text = My.Settings.EquipmentNo
        PLDataDataGridView.DataSource = c_PLDataList
        PLDataDataGridView.ClearSelection()

        For i = 0 To PLDataDataGridView.Rows.Count - 1
            If Not PLDataDataGridView.Rows(i).Cells(5).Value Is Nothing Then
                PLDataDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If
        Next
        'c_MDIParent1.FrmProcessFill()
        'lbMcNo.Text = My.Settings.EquipmentNo
        ''PLDataBindingSource1.DataSource = c_PLDataList
        'Try
        '    c_IlibraryService.MachineOnlineState("PL-" & lbMcNo.Text, MachineOnline.Online)
        'Catch ex As Exception
        '    SaveCatchLog("Exception:" & ex.Message.ToString, "MachineOnlineState")
        'End Try

        'PLDataDataGridView.DataSource = c_PLDataList
        'PLDataDataGridView.ClearSelection()
        'GetAlarmInfo(My.Settings.EquipmentNo)

        'For i = 0 To PLDataDataGridView.Rows.Count - 1
        '    If Not PLDataDataGridView.Rows(i).Cells(5).Value Is Nothing Then
        '        PLDataDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Red
        '    End If
        'Next
        'LabelIReportMessage.Text = IReportCheck(lbMcNo.Text)
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


    Public Sub Event_LotInfo_Rohm(ByVal LotNo As String, ByVal OPNo As String, ByVal Mgz As String, itemID As String)
        Dim plData As PLData = New PLData()
        Try
            If String.IsNullOrEmpty(LotNo.Trim) Then
                SaveCatchLog("LotNo is null '" + LotNo + "'", "Event_LotInfo_Rohm")
                Return
            End If
        Catch ex As Exception
            SaveCatchLog(ex.Message & "  " & CStr(LotNo), "Event_LotInfo_Rohm")
        End Try
        Try
            If LotNo.Length > 10 Then
                plData.LotNo = LotNo.Substring(0, 10).Trim
            Else
                plData.LotNo = LotNo.Trim
            End If
            If c_PLDataList.Where(Function(x) x.LotNo = plData.LotNo).Any Then
                Return
            End If
        Catch ex As Exception
            SaveCatchLog(ex.Message & "  " & CStr(LotNo), "LotNo.Substring")
        End Try

        Try
            SaveTransacionData(m_SelfData.LotName, m_SelfData.DeviceName, m_SelfData.RecipeName)
        Catch ex As Exception
            SaveCatchLog(ex.Message & "  " & CStr(LotNo), "TransactionCheck")
        End Try
        Try
            plData.MCNo = My.Settings.ProcessName & "-" & My.Settings.EquipmentNo
            plData.OPNo = OPNo
            plData.MagazineNo = Mgz
            plData.LotStartTime = Now
            plData.NetVersion = m_strNetVersion
            c_PLDataList.Add(plData)
        Catch ex As Exception
            SaveCatchLog(ex.Message.ToString, "Add Data Row")
        End Try

        'iReport
        LabelIReportMessage.Text = IReportCheck(lbMcNo.Text)

        'SavePLDataTableBin()
        Try
            Dim syncContext As SynchronizationContext = WindowsFormsSynchronizationContext.Current
            ' syncContext.Post(New Threading.SendOrPostCallback(Sub() UpdateData(c_PLDataList)), Nothing)

            syncContext.Post(New Threading.SendOrPostCallback(Sub() IReportCheck(My.Settings.EquipmentNo)), Nothing)
        Catch ex As Exception

        End Try
        SaveCatchLog("LotNo:" & LotNo & "|OPNo:" & OPNo, "SetupAndStart")

        SetupAndStart(LotNo, OPNo)
        SaveDBx(plData)
        WriteDataToXmlFile(c_PLDataList, c_PathPLDataList)
        PLDataDataGridView.ClearSelection()
        ' RaiseEvent E_Update_dgvProductionDetail("1666700", LotNo, "MECO-LotInfo_Rohm", "")
        c_MDIParent1.MDIUpdate_dgvProductionDetail(itemID, LotNo, "MECO-LotInfo_Rohm", "")
    End Sub
    Public Sub Event_CountData(ByVal LotNo As String, ByVal UnloadGood As Integer, ByVal LoadInputQty As Integer, ByVal EventName As String, itemID As String)

        Dim strLotNo As String
        If LotNo.Length > 10 Then
            strLotNo = LotNo.Substring(0, 10).Trim
        Else
            strLotNo = LotNo.Trim
        End If

        For Each data As PLData In c_PLDataList.Where(Function(x) x.LotNo = strLotNo And x.LotEndTime Is Nothing).ToList
            data.UnloadCount = UnloadGood
            data.LoadCount = LoadInputQty
        Next
        WriteDataToXmlFile(c_PLDataList, c_PathPLDataList)
        c_MDIParent1.MDIUpdate_dgvProductionDetail(itemID, strLotNo, "MECO-" & EventName & " Unload :" & UnloadGood & " LoadInput :" & LoadInputQty, "")
    End Sub
    Public Sub Event_LotEnd(ByVal LotNo As String, ByVal UnloadGood As Integer, ByVal LoadCountInput As Integer, itemID As String)

        Dim strLotNo As String
        If LotNo.Length > 10 Then
            strLotNo = LotNo.Substring(0, 10).Trim
        Else
            strLotNo = LotNo.Trim
        End If

        For Each data As PLData In c_PLDataList.Where(Function(x) x.LotNo = strLotNo And x.LotEndTime Is Nothing).ToList
            data.UnloadCount = UnloadGood
            data.LoadCount = LoadCountInput
            data.LotEndTime = Now
            RemoveAlarmData(data.LotNo)
        Next


        For i = 0 To PLDataDataGridView.Rows.Count - 1
            If PLDataDataGridView.Rows(i).Cells(0).Value.ToString = strLotNo Then
                PLDataDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If
        Next

        WriteDataToXmlFile(c_PLDataList, c_PathPLDataList)
        c_MDIParent1.MDIUpdate_dgvProductionDetail(itemID, strLotNo, "MECO-LotEnd UnloadGood :" & UnloadGood & " LoadCountInput :" & LoadCountInput, "")

    End Sub

    Public Sub Event_LotStart(ByVal LotNo As String, itemID As String)
        c_MDIParent1.MDIUpdate_dgvProductionDetail(itemID, LotNo, "MECO-LotStart", "")
    End Sub

    Public Sub Event_MgzDoneLoading(ByVal LotNo As String, ByVal InputQty As Integer, itemID As String)

        Dim strLotNo As String
        If LotNo.Length > 10 Then
            strLotNo = LotNo.Substring(0, 10).Trim
        Else
            strLotNo = LotNo.Trim
        End If

        For Each data As PLData In c_PLDataList.Where(Function(x) x.LotNo = strLotNo And x.LotEndTime Is Nothing).ToList
            data.LoadCount = InputQty
        Next
        WriteDataToXmlFile(c_PLDataList, c_PathPLDataList)
        c_MDIParent1.MDIUpdate_dgvProductionDetail(itemID, strLotNo, "MECO-MgzDoneLoading Input :" & InputQty, "")
    End Sub

    Public Sub Event_MgzStartLoading(ByVal LotNo As String, itemID As String)

        Dim strLotNo As String
        If LotNo.Length > 10 Then
            strLotNo = LotNo.Substring(0, 10).Trim
        Else
            strLotNo = LotNo.Trim
        End If

        Dim plData As PLData = GetPLData(strLotNo)
        If plData Is Nothing Then
            MessageDialog("PLData is nothing lotNo:" & LotNo, MessageBoxType.Alarm)
            c_MDIParent1.MDIUpdate_dgvProductionDetail(itemID, LotNo, "MECO-MgzStartLoading PLData is nothing lotNo:" & LotNo, "")
            Return
        End If
        'SaveDBx(plData)
        'For i = 0 To PLDataDataGridView.Rows.Count - 1
        '    If PLDataDataGridView.Rows(i).Cells(0).Value.ToString = LotNo Then
        '        PLDataDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Lime
        '    End If
        'Next
        WriteDataToXmlFile(c_PLDataList, c_PathPLDataList)
        c_MDIParent1.MDIUpdate_dgvProductionDetail(itemID, LotNo, "MECO-MgzStartLoading", "")

    End Sub
    Public Sub Event_MachineStatus(ByVal LotNo As String, itemID As String)

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
                SaveCatchLog("Exception:" & ex.Message.ToString, "UpdateMachineState")
            End Try

        End If

        c_MDIParent1.MDIUpdate_dgvProductionDetail(itemID, "", "MECO-MachineStatus", "")
    End Sub

    Public Sub m_AlarmRecord(ByVal AlarmNo As String, ByVal StatusAld As Integer, ByVal strAlarmText As String)
        Try
            Dim alarmTable As PLAlarmTable = SearchAlarmTable(AlarmNo)
            If alarmTable Is Nothing Then
                Return
            End If
            If StatusAld = 0 Then 'AlarmClear
                ClearAlarmData(alarmTable)
            Else 'AlarmSet
                SetAlarmData(alarmTable)
            End If
        Catch ex As Exception
            SaveCatchLog("Exception:" & ex.Message.ToString, "m_AlarmRecord")
            MessageDialog("Exception:" & ex.Message.ToString, MessageBoxType.Alarm)
        End Try

    End Sub



    Private Sub OpenDialogMessage(message As String, title As String)
        Dim frm As DialogMessage = New DialogMessage(message, "http://webserv.thematrix.net/atom", title)
        frm.ShowDialog()
    End Sub

    Private Sub PLDataDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PLDataDataGridView.CellClick
        'Dim dataGridview As DataGridView = CType(sender, DataGridView)
        'Dim lotNo = dataGridview.Item(1, e.RowIndex).Value
        'Dim xxxx = PLDataDataGridView.SelectedRows
        'Dim pl = CType(xxxx(0).DataBoundItem, PLData)
        'Debug.Print(countClick.ToString)
        'Debug.Print("RowIndex:" & e.RowIndex & " ColumnIndex:" & e.ColumnIndex)
        'countClick += 1
        'If Not lotNo Is Nothing Then
        '    LabelIReportMessage.Text = lotNo.ToString
        'End If
        Dim pldata As PLData = CType(PLDataDataGridView.SelectedRows(0).DataBoundItem, PLData)
        Try

            If Not pldata.LotEndTime.HasValue Then
                Return
            End If
            bgWorker.WorkerReportsProgress = True
            bgWorker.RunWorkerAsync(pldata)
            'Dim carrierInfo As CarrierInfo = c_IlibraryService.GetCarrierInfo(pldata.MCNo, pldata.LotNo, pldata.OPNo)
            ''Dim apcsProData As ApcsPro = New ApcsPro
            ''apcsProData.LotNo = pldata.LotNo
            ''apcsProData.MachineNo = "PL-" & My.Settings.EquipmentNo
            ''apcsProData.UserCode = pldata.OPNo
            ''apcsProData.Recipe = ""
            ''apcsProData.CarrierInfo = carrierInfo
            ''c_ApcsProDatas.Add(apcsProData)
            'If carrierInfo.EnabledControlCarrier = CarrierInfo.CarrierStatus.Use AndAlso carrierInfo.InControlCarrier = CarrierInfo.CarrierStatus.Use AndAlso carrierInfo.LoadCarrier = CarrierInfo.CarrierStatus.Use Then

            '    Dim dialogQrLotSlipInput As InputQrCarrierNo = New InputQrCarrierNo(252, "AssySlip 252 Character" & vbCrLf & "[" & pldata.LotNo.Trim.ToUpper & "]", Color.GreenYellow)
            '    If dialogQrLotSlipInput.ShowDialog() = DialogResult.OK Then
            '        If pldata.LotNo.Trim.ToUpper <> dialogQrLotSlipInput.QrCarrierNo.Trim.ToUpper.Substring(30, 10) Then
            '            OpenDialogMessage("LotNo. ไม่ตรงกัน [" & pldata.LotNo.Trim.ToUpper & "] [" & dialogQrLotSlipInput.QrCarrierNo.Trim.ToUpper.Substring(30, 10) & "]", "LotNo not match")
            '            Return
            '        End If
            '    Else
            '        Return
            '    End If

            '    Dim dialogQrCarrierInput As InputQrCarrierNo = New InputQrCarrierNo(11, "Carrier No." & vbCrLf & "[" & carrierInfo.CurrentCarrierNo.Trim.ToUpper & "]", Color.Orange)
            '    If dialogQrCarrierInput.ShowDialog() = DialogResult.OK Then
            '        If carrierInfo.CurrentCarrierNo.Trim.ToUpper <> dialogQrCarrierInput.QrCarrierNo.Trim.ToUpper Then
            '            OpenDialogMessage("Carrier No. [" & dialogQrCarrierInput.QrCarrierNo.Trim.ToUpper & "] นี้ไม่ตรงกับในระบบ [" & carrierInfo.CurrentCarrierNo.Trim.ToUpper & "]", "Carrier Error")
            '            Return
            '        End If
            '        carrierInfo.LoadCarrierNo = dialogQrCarrierInput.QrCarrierNo
            '        pldata.MagazineNo = carrierInfo.LoadCarrierNo

            '    Else
            '        Return
            '    End If
            'End If


            '    Dim frmCon As frmConfirm = New frmConfirm(pldata.LotNo, pldata.LoadCount, pldata.UnloadCount, pldata.LotStartTime, pldata.LotEndTime, pldata.MagazineNo)
            '    If frmCon.ShowDialog() <> DialogResult.OK Then
            '        Return
            '    Else
            '        pldata.InputQtyAdjust = CInt(frmCon.tbTotalInput.Text)
            '        pldata.TotalGoodAdjust = CInt(frmCon.tbTotalGood.Text)
            '        pldata.TotalNGAdjust = CInt(frmCon.tbTotalNG.Text)

            '        'Request By P'ตี๋
            '        Try
            '            pldata.InputQtyFrameAdjust = pldata.InputQtyAdjust \ frmCon._FramePCS
            '            pldata.TotalGoodFrameAdjust = pldata.TotalGoodAdjust \ frmCon._FramePCS
            '        Catch ex As Exception
            '            SaveCatchLog("Exception:" & ex.Message.ToString, "frmConfirm")
            '        End Try

            '        pldata.LoadCount = CInt(frmCon.tbTotalInput.Text)
            '        pldata.UnloadCount = CInt(frmCon.tbTotalGood.Text)

            '        pldata.DummyQty = CInt(frmCon.tbDummy.Text)
            '        pldata.OPJudgement = frmCon.tbOPJudge.Text
            '    End If

            '    'Dim result As EndLotResult = c_IlibraryService.EndLotNoCheckLicenser(tdc.LotNo, tdc.McNo, tdc.OpNo, tdc.GoodPcs, tdc.NgPcs)
            '    If pldata.LotNo.Contains("DUM") = True OrElse pldata.LotNo.Contains("dum") = True Then
            '        'Dummy จะไม่เซฟ
            '    Else
            '        SaveDBx(pldata)
            '    End If
            '    Dim url As String = EndLot(pldata, carrierInfo)
            '    Try
            '        If Not String.IsNullOrEmpty(url) Then
            '            Dim syncContext As SynchronizationContext = WindowsFormsSynchronizationContext.Current
            '            syncContext.Post(New Threading.SendOrPostCallback(Sub() OpenDialog(pldata.LotNo, url)), Nothing)
            '        End If
            '    Catch ex As Exception
            '        MessageDialog("Exception:" & ex.Message.ToString & "|LotNo:" & pldata.LotNo & "|OPNo:" & pldata.OPNo, MessageBoxType.Alarm)
            '    End Try

        Catch ex As Exception
            SaveCatchLog("Exception:" & ex.Message.ToString & "|LotNo:" & pldata.LotNo & "|OPNo:" & pldata.OPNo, "EndLot")
            MessageDialog("Exception:" & ex.Message.ToString & "|LotNo:" & pldata.LotNo & "|OPNo:" & pldata.OPNo, MessageBoxType.Alarm)
        Finally
            PLDataDataGridView.ClearSelection()
        End Try
    End Sub
    Private Sub OpenDialog(lotNo As String, url As String)
        Dim frm As DialogMessage = New DialogMessage("LotNo " & lotNo & " จบ lot ไม่สมบูรณ์ " & vbCrLf & "กรุณาทำการ End process ในระบบด้วยครับ", url, "แจ้งเตือน")
        frm.ShowDialog()
    End Sub


    Private countTest As Integer
    Private Sub BtDeleteLot_Click(sender As Object, e As EventArgs) Handles btDeleteLot.Click

        Dim frmDelete As New frmDeleteLot(c_PLDataList)
        If frmDelete.ShowDialog() = DialogResult.OK Then
            WriteDataToXmlFile(c_PLDataList, c_PathPLDataList)
        End If
         PLDataDataGridView.ClearSelection()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerTest.Tick
        Dim plData As PLData = New PLData()
        plData.LotNo = "Test" & countTest
        plData.LotStartTime = Now
        plData.UnloadCount = 1000
        c_PLDataList.Add(plData)
        countTest += 1

        For Each data As PLData In c_PLDataList
            data.UnloadCount += 1
        Next
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim frmMag As New frmEditData(Me)
        'If frmMag.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    SavePLDataTableBin()
        'End If
        'TimerTest.Start()
    End Sub

    Private Sub BtEndManual_Click(sender As Object, e As EventArgs) Handles btEndManual.Click
        If c_PLDataList.Count > 0 Then
            Dim frmEnd As New frmLotEndManual(c_PLDataList)
            If frmEnd.ShowDialog() = DialogResult.OK Then
                WriteDataToXmlFile(c_PLDataList, c_PathPLDataList)
                For i = 0 To PLDataDataGridView.Rows.Count - 1
                    If Not PLDataDataGridView.Rows(i).Cells(5).Value Is Nothing Then
                        PLDataDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    End If
                Next
            End If

        End If
        'TimerTest.Stop()
    End Sub

    Private Sub ProcessForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        WriteDataToXmlFile(c_PLAlarmInfos, c_PathPLAlarmInfoes)
        WriteDataToXmlFile(c_PLDataList, c_PathPLDataList)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MDIParent1.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbTime.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MDIParent1.Send_S6F23_PurgeSpool()
    End Sub

    Private Sub WorkRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorkRecordToolStripMenuItem.Click
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

    Private Sub EqConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EqConnectToolStripMenuItem.Click
        If Not (My.Settings.CsProtocol_Enable Or My.Settings.SECS_Enable) Then
            Exit Sub
        End If
        If Not (OprData.CSConnect = "Disconnect" Or CommuniationState Like "NOT COMMUNICATING") Then
            Exit Sub
        End If
        c_MDIParent1.EqConnect()
    End Sub

    Private Sub APCSStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles APCSStaffToolStripMenuItem.Click
        Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv.thematrix.net/ApcsStaff", AppWinStyle.NormalFocus)
    End Sub

    Private Sub PMRepairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PMRepairToolStripMenuItem.Click
        Dim MCNo As String = My.Settings.EquipmentNo
        Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv.thematrix.net/LsiPETE/LSI_Prog/Maintenance/MainPMlogin.asp?" & "MCNo=PL-" & MCNo, vbNormalFocus)
        CallKeyboardVisual()
    End Sub
    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Private Sub CallKeyboardVisual()
        Try
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
        Catch ex As Exception
            MessageBox.Show("Exception:" & ex.Message.ToString)
        End Try

    End Sub
    Private Sub BMRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BMRequestToolStripMenuItem.Click
        Dim tmpStr As String

        tmpStr = "MCNo=PL-" & My.Settings.EquipmentNo
        If c_PLDataList.Count = 0 Then
            tmpStr = tmpStr & "&LotNo="
            tmpStr = tmpStr & "&MCStatus=Stop"
        Else
            For Each strDataRow As PLData In c_PLDataList
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

    Private Sub AndonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AndonToolStripMenuItem.Click
        Try
            Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv/andontmn", AppWinStyle.NormalFocus) 'Web andon for manual M/C
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private WithEvents bgWorker As New BackgroundWorker
    'Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
    '    bgWorker.RunWorkerAsync()
    'End Sub

    'Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
    '    bgWorker.CancelAsync()
    'End Sub
    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        ' Do Work

        Debug.Print("DoWork")
        bgWorker.ReportProgress(20, LoadingFrom.ShowFrom)
        'Thread.Sleep(5000)
        'Debug.Print("DoWork2")
        ' e.Result = "xxx"

        'Debug.Print("DoWork3")

        Dim pldata As PLData = CType(e.Argument, PLData)
        'Debug.Print("start:" + pldata.LotStartTime.ToString + "|LotNo:" + pldata.LotNo)
        'pldata.LotEndTime = Now
        'e.Result = pldata
        Dim carrierInfo As CarrierInfo = c_IlibraryService.GetCarrierInfo(pldata.MCNo, pldata.LotNo, pldata.OPNo)
        'Dim apcsProData As ApcsPro = New ApcsPro
        'apcsProData.LotNo = pldata.LotNo
        'apcsProData.MachineNo = "PL-" & My.Settings.EquipmentNo
        'apcsProData.UserCode = pldata.OPNo
        'apcsProData.Recipe = ""
        'apcsProData.CarrierInfo = carrierInfo
        'c_ApcsProDatas.Add(apcsProData)
        bgWorker.ReportProgress(90, LoadingFrom.CloseFrom)
        'pldata.LotEndTime = Now
        Dim arr(1) As Object
        arr(0) = pldata
        arr(1) = carrierInfo
        e.Result = arr
    End Sub
    Enum LoadingFrom
        ShowFrom
        CloseFrom
        InputAssySlip
        InputCarrier
    End Enum
    Dim frmLoading As FormLoading
    Private Sub bgWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgWorker.ProgressChanged, bgWorkerLoad.ProgressChanged
        ' Update Progress Status to UI
        'Me.Button4.Text = (e.ProgressPercentage.ToString() + "% >>" + e.UserState.ToString)
        'Debug.Print("ProgressChanged :" + (e.ProgressPercentage.ToString() + "% >>" + e.UserState.ToString))
        'If frmLoading Is Nothing Then
        '    frmLoading = New FormLoading()
        'End If
        'If CType(e.UserState, LoadingFrom) = LoadingFrom.ShowFrom Then
        '    frmLoading.TopMost = True
        '    frmLoading.ShowDialog()
        'Else
        '    frmLoading.Close()
        'End If
        FromLoading(CType(e.UserState, LoadingFrom))
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        ' Finish
        Debug.Print("RunWorkerCompleted")
        Dim array() As Object = CType(e.Result, Object())
        Dim pldata As PLData = CType(array(0), PLData)
        ' Debug.Print("start:" + PLData.LotStartTime.ToString + "|lotNo:" + PLData.LotNo + "|Endtime:" + PLData.LotEndTime.ToString)
        Dim carrierInfo As CarrierInfo = CType(array(1), CarrierInfo)

        If carrierInfo.EnabledControlCarrier = CarrierInfo.CarrierStatus.Use AndAlso carrierInfo.InControlCarrier = CarrierInfo.CarrierStatus.Use AndAlso carrierInfo.LoadCarrier = CarrierInfo.CarrierStatus.Use Then

            Dim dialogQrLotSlipInput As InputQrCarrierNo = New InputQrCarrierNo(252, "AssySlip 252 Character" & vbCrLf & "[" & pldata.LotNo.Trim.ToUpper & "]", Color.GreenYellow)
            If dialogQrLotSlipInput.ShowDialog() = DialogResult.OK Then
                If pldata.LotNo.Trim.ToUpper <> dialogQrLotSlipInput.QrCarrierNo.Trim.ToUpper.Substring(30, 10) Then
                    OpenDialogMessage("LotNo. ไม่ตรงกัน [" & pldata.LotNo.Trim.ToUpper & "] [" & dialogQrLotSlipInput.QrCarrierNo.Trim.ToUpper.Substring(30, 10) & "]", "LotNo not match")
                    Return
                End If
            Else
                Return
            End If

            Dim dialogQrCarrierInput As InputQrCarrierNo = New InputQrCarrierNo(11, "Carrier No." & vbCrLf & "[" & carrierInfo.CurrentCarrierNo.Trim.ToUpper & "]", Color.Orange)
            If dialogQrCarrierInput.ShowDialog() = DialogResult.OK Then
                If String.IsNullOrEmpty(carrierInfo.CurrentCarrierNo) Then
                    AutoRegisterCarrier(pldata.LotNo, pldata.MCNo, dialogQrCarrierInput.QrCarrierNo.Trim.ToUpper)
                    carrierInfo = c_IlibraryService.GetCarrierInfo(pldata.MCNo, pldata.LotNo, pldata.OPNo)
                End If
                If carrierInfo.CurrentCarrierNo.Trim.ToUpper <> dialogQrCarrierInput.QrCarrierNo.Trim.ToUpper Then
                    OpenDialogMessage("Carrier No. [" & dialogQrCarrierInput.QrCarrierNo.Trim.ToUpper & "] นี้ไม่ตรงกับในระบบ [" & carrierInfo.CurrentCarrierNo.Trim.ToUpper & "]", "Carrier Error")
                    Return
                End If
                carrierInfo.LoadCarrierNo = dialogQrCarrierInput.QrCarrierNo
                pldata.MagazineNo = carrierInfo.LoadCarrierNo

            Else
                Return
            End If
        End If
        Dim frmCon As frmConfirm = New frmConfirm(PLData.LotNo, PLData.LoadCount, PLData.UnloadCount, PLData.LotStartTime, PLData.LotEndTime, PLData.MagazineNo)
        If frmCon.ShowDialog() <> DialogResult.OK Then
            Return
        Else
            PLData.InputQtyAdjust = CInt(frmCon.tbTotalInput.Text)
            PLData.TotalGoodAdjust = CInt(frmCon.tbTotalGood.Text)
            PLData.TotalNGAdjust = CInt(frmCon.tbTotalNG.Text)

            'Request By P'ตี๋
            Try
                PLData.InputQtyFrameAdjust = PLData.InputQtyAdjust \ frmCon._FramePCS
                PLData.TotalGoodFrameAdjust = PLData.TotalGoodAdjust \ frmCon._FramePCS
            Catch ex As Exception
                SaveCatchLog("Exception:" & ex.Message.ToString, "frmConfirm")
            End Try

            PLData.LoadCount = CInt(frmCon.tbTotalInput.Text)
            PLData.UnloadCount = CInt(frmCon.tbTotalGood.Text)

            PLData.DummyQty = CInt(frmCon.tbDummy.Text)
            PLData.OPJudgement = frmCon.tbOPJudge.Text
        End If

        'Dim result As EndLotResult = c_IlibraryService.EndLotNoCheckLicenser(tdc.LotNo, tdc.McNo, tdc.OpNo, tdc.GoodPcs, tdc.NgPcs)
        If PLData.LotNo.Contains("DUM") = True OrElse PLData.LotNo.Contains("dum") = True Then
            'Dummy จะไม่เซฟ
        Else
            SaveDBx(PLData)
        End If
        Dim url As String = EndLot(PLData, carrierInfo)
        Try
            If Not String.IsNullOrEmpty(url) Then
                Dim syncContext As SynchronizationContext = WindowsFormsSynchronizationContext.Current
                syncContext.Post(New Threading.SendOrPostCallback(Sub() OpenDialog(PLData.LotNo, url)), Nothing)
            End If
            PLDataDataGridView.ClearSelection()
        Catch ex As Exception
            MessageDialog("Exception:" & ex.Message.ToString & "|LotNo:" & PLData.LotNo & "|OPNo:" & PLData.OPNo, MessageBoxType.Alarm)
        End Try

    End Sub
    'Private Sub Button4_Click(sender As Object, e As EventArgs)
    '    Dim pldata As PLData = New PLData
    '    pldata.LotNo = "2003A7090V"
    '    pldata.OPNo = "007567"
    '    pldata.MCNo = "PL-M-00"
    '    pldata.LotStartTime = Now
    '    bgWorker.WorkerReportsProgress = True
    '    bgWorker.RunWorkerAsync(pldata)

    'End Sub


    Private Sub MaximizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizeToolStripMenuItem.Click
        c_MDIParent1.FrmProcessFill()
    End Sub

    Private Sub ProductTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductTableToolStripMenuItem.Click
        c_MDIParent1.ProductTableFrm()
    End Sub

    Private Sub SecsConsoleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SecsConsoleToolStripMenuItem.Click
        c_MDIParent1.ConsoleFrm()
    End Sub
End Class