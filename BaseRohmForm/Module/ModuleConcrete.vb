Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports CellController.iLibraryService
Module ModuleConcrete
    Private Const ConnectionStringStoredProcedureDB As String = "Data Source=172.16.0.102;Initial Catalog=StoredProcedureDB;Persist Security Info=True;User ID=system;Password=p@$$w0rd; Application Name=Cellcon_Meco"
    Private Const ConnectionStringDBx As String = "Data Source=172.16.0.102;Initial Catalog=DBx;Persist Security Info=True;User ID=system;Password=p@$$w0rd; Application Name=Cellcon_Meco"
    Public c_PathPLAlarmInfoes As String = Path.Combine(My.Application.Info.DirectoryPath, "PLAlarmInfos.xml")
#Region "PerFrame"
    Public Function GetPerFrame(pkg As String) As GetPerFrameResult
        Dim result As GetPerFrameResult = New GetPerFrameResult
        Try
            Using con As New SqlConnection(ConnectionStringStoredProcedureDB)
                Using cmd As New SqlCommand
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "[dbo].[sp_get_per_frame]"
                    cmd.Parameters.Add("@Package", SqlDbType.VarChar).Value = pkg
                    'Dim tb As DataTable = New DataTable()
                    'Dim ad As SqlDataReader = cmd.ExecuteReader
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        'tb.Load(dr)
                        'For Each row As DataRow In tb.Rows
                        '    If Not row("per_frame") Is DBNull.Value Then
                        '        result.IsPass = True
                        '        result.PerFrame = CType(row("per_frame"), Int16)
                        '        result.Package = CType(row("package"), String).Trim
                        '        Return result
                        '    End If
                        'Next
                        While dr.Read
                            If dr.HasRows Then
                                result.IsPass = True
                                result.PerFrame = CType(dr("per_frame"), Int16)
                                result.Package = CType(dr("package"), String)
                                Return result
                            End If
                        End While

                    End Using
                    con.Close()
                End Using

            End Using
            result.IsPass = False
            result.Reson = "ไม่พบข้อมูล PCS PER FRAME ในระบบ " + vbCrLf + "กรุณาติดต่อหัวหน้างาน " + vbCrLf + "EXEC [dbo].[sp_get_per_frame] " + vbCrLf + "@Package = " + pkg
        Catch ex As Exception
            result.IsPass = False
            result.Reson = "GetPerFrame:" + ex.Message.ToString
            SaveCatchLog("Exception:" + ex.Message.ToString, MethodBase.GetCurrentMethod().Name)
        End Try
        Return result
    End Function
#End Region
    Public Sub AutoRegisterCarrier(lotNo As String, mcNo As String, carrierNo As String)
        Try
            Using con As New SqlConnection(ConnectionStringStoredProcedureDB)
                Using cmd As New SqlCommand
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "[cellcon].[sp_set_register_carrier]"
                    cmd.Parameters.Add("@lot_no", SqlDbType.VarChar).Value = lotNo
                    cmd.Parameters.Add("@carrier_no", SqlDbType.VarChar).Value = carrierNo
                    cmd.Parameters.Add("@mcno", SqlDbType.VarChar).Value = mcNo
                    cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = 1
                    'Dim tb As DataTable = New DataTable()
                    Dim ad = cmd.ExecuteNonQuery()
                    'Using dr As SqlDataReader = cmd.ExecuteReader
                    '    'tb.Load(dr)
                    '    'For Each row As DataRow In tb.Rows
                    '    '    If Not row("per_frame") Is DBNull.Value Then
                    '    '        result.IsPass = True
                    '    '        result.PerFrame = CType(row("per_frame"), Int16)
                    '    '        result.Package = CType(row("package"), String).Trim
                    '    '        Return result
                    '    '    End If
                    '    'Next
                    '    While dr.Read
                    '        If dr.HasRows Then
                    '            'To do
                    '        End If
                    '    End While
                    'End Using
                    con.Close()
                End Using
            End Using
        Catch ex As Exception
            SaveCatchLog("Exception:" + ex.Message.ToString, MethodBase.GetCurrentMethod().Name)
        End Try
    End Sub
#Region "Alarm"
    Public c_PLAlarmInfos As List(Of PLAlarmInfo)
    Public c_PLAlarmTable As List(Of PLAlarmTable)
    Public Sub GetAlarmInfo(mcno As String)
        Dim strMC As String
        Select Case mcno
            Case "PL-M-01"
                strMC = "MECO1"
            Case "PL-M-02"
                strMC = "MECO2"
            Case "PL-M-03"
                strMC = "MECO3"
            Case "PL-M-04"
                strMC = "MECO4"
            Case Else
                strMC = "MECO1"
        End Select
        c_PLAlarmTable = New List(Of PLAlarmTable)
        Try
            Using con As New SqlConnection(ConnectionStringStoredProcedureDB)
                Using cmd As New SqlCommand
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "dbo.[sp_get_pl_alarm_table]"
                    cmd.Parameters.Add("@mctype", SqlDbType.VarChar).Value = strMC
                    'Dim tb As DataTable = New DataTable()
                    'Dim ad As SqlDataReader = cmd.ExecuteReader
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        'tb.Load(dr)
                        'For Each row As DataRow In tb.Rows
                        '    If Not row("per_frame") Is DBNull.Value Then
                        '        result.IsPass = True
                        '        result.PerFrame = CType(row("per_frame"), Int16)
                        '        result.Package = CType(row("package"), String).Trim
                        '        Return result
                        '    End If
                        'Next
                        While dr.Read
                            If dr.HasRows Then

                                'Dim alarmInfo As AlarmInfo = New AlarmInfo()
                                Dim alarmTable As PLAlarmTable = New PLAlarmTable()
                                alarmTable.ID = CType(dr("ID"), Integer)
                                alarmTable.AlarmNo = CType(dr("AlarmNo"), Integer)
                                alarmTable.MachineType = CType(dr("MachineType"), String)
                                alarmTable.AlarmType = CType(dr("AlarmType"), String)
                                alarmTable.AlarmMessage = CType(dr("AlarmMessage"), String)
                                c_PLAlarmTable.Add(alarmTable)
                            End If
                        End While

                    End Using
                    con.Close()
                End Using

            End Using
            If c_PLAlarmTable.Count = 0 Then
                SaveCatchLog("data alarmInfo not found dbo.[sp_get_pl_alarm_table] @mctype=" + strMC, MethodBase.GetCurrentMethod().Name)
                MessageDialog("data alarmInfo not found dbo.[sp_get_pl_alarm_table] @mctype=" + strMC, MessageBoxType.Alarm)
            End If
        Catch ex As Exception
            SaveCatchLog("Exception:" + ex.Message.ToString, MethodBase.GetCurrentMethod().Name)
        End Try


    End Sub
    Public Function SearchAlarmTable(alarmNo As String) As PLAlarmTable
        Return c_PLAlarmTable.Where(Function(x) x.AlarmNo.Value = CInt(alarmNo)).FirstOrDefault
    End Function
    Public Sub RemoveAlarmData(lotNo As String)
        Try
            For Each data As PLAlarmInfo In c_PLAlarmInfos.Where(Function(x) x.LotNo = lotNo).ToArray
                c_PLAlarmInfos.Remove(data)
            Next
            WriteDataToXmlFile(c_PLAlarmInfos, c_PathPLAlarmInfoes)
        Catch ex As Exception
            SaveCatchLog("Exception:" & ex.Message.ToString, MethodBase.GetCurrentMethod().Name)
        End Try

    End Sub

    Public Sub SetAlarmData(plAlarmTable As PLAlarmTable)
        If plAlarmTable Is Nothing Then
            SaveCatchLog("plAlarmTable is Nothing", MethodBase.GetCurrentMethod().Name)
            Return
        End If
        Dim recordTime As DateTime = Now
        For Each plData As PLData In c_PLDataList
            Dim plAlarmInfo As PLAlarmInfo = New PLAlarmInfo
            plAlarmInfo.RecordTime = recordTime
            plAlarmInfo.LotNo = plData.LotNo
            plAlarmInfo.MCNo = plData.MCNo
            plAlarmInfo.AlarmID = plAlarmTable.ID

            Using cmd As New SqlCommand
                cmd.Connection = New SqlConnection(ConnectionStringDBx)
                cmd.Connection.Open()
                cmd.CommandType = CommandType.Text
                cmd.Parameters.Clear()
                cmd.CommandText = "INSERT INTO [DBx].[dbo].[PLAlarmInfo] ([RecordTime],[AlarmID],[LotNo],[MCNo]) Values (@RecordTime,@AlarmID,@LotNo,@MCNo)"
                cmd.Parameters.Add("@RecordTime", SqlDbType.DateTime).Value = plAlarmInfo.RecordTime
                cmd.Parameters.Add("@AlarmID", SqlDbType.Int).Value = plAlarmInfo.AlarmID
                cmd.Parameters.Add("@LotNo", SqlDbType.VarChar).Value = plAlarmInfo.LotNo
                cmd.Parameters.Add("@MCNo", SqlDbType.VarChar).Value = plAlarmInfo.MCNo
                cmd.ExecuteNonQuery()
                cmd.Connection.Close()
            End Using
            c_PLAlarmInfos.Add(plAlarmInfo)

        Next

        WriteDataToXmlFile(c_PLAlarmInfos, c_PathPLAlarmInfoes)
    End Sub
    Public Sub ClearAlarmData(plAlarmTable As PLAlarmTable)
        Try
            If plAlarmTable Is Nothing Then
                SaveCatchLog("plAlarmTable is Nothing", MethodBase.GetCurrentMethod().Name)
                Return
            End If
            Dim clearTime As DateTime = Now
            For Each plAlarmInfo As PLAlarmInfo In c_PLAlarmInfos.Where(Function(x) x.AlarmID.Value = plAlarmTable.ID.Value AndAlso x.ClearTime Is Nothing).ToList
                plAlarmInfo.ClearTime = clearTime
            Next

            Using cmd As New SqlCommand
                cmd.Connection = New SqlConnection(ConnectionStringDBx)
                cmd.Connection.Open()
                cmd.CommandType = CommandType.Text

                For Each data As PLAlarmInfo In c_PLAlarmInfos.Where(Function(x) x.AlarmID.Value = plAlarmTable.ID.Value).ToArray
                    cmd.Parameters.Clear()
                    cmd.CommandText = "UPDATE [DBx].[dbo].[PLAlarmInfo] SET [ClearTime] = @ClearTime " &
                        "where RecordTime = @RecordTime and AlarmID = @AlarmID and LotNo = @LotNo and MCNo = @MCNo and ClearTime is null"
                    cmd.Parameters.Add("@RecordTime", SqlDbType.DateTime).Value = data.RecordTime
                    cmd.Parameters.Add("@AlarmID", SqlDbType.Int).Value = data.AlarmID
                    cmd.Parameters.Add("@LotNo", SqlDbType.VarChar).Value = data.LotNo
                    cmd.Parameters.Add("@MCNo", SqlDbType.VarChar).Value = data.MCNo
                    cmd.Parameters.Add("@ClearTime", SqlDbType.DateTime).Value = data.ClearTime
                    cmd.ExecuteNonQuery()
                    c_PLAlarmInfos.Remove(data)
                Next
                cmd.Connection.Close()
            End Using
            WriteDataToXmlFile(c_PLAlarmInfos, c_PathPLAlarmInfoes)
        Catch ex As Exception
            SaveCatchLog("Exception:" & ex.Message.ToString, MethodBase.GetCurrentMethod().Name)
        End Try

    End Sub
#End Region

    Public Function SaveTransacionData(ByVal lotNo As String, ByVal device As String, ByVal package As String) As SaveTransacion
        Try
            ' Dim ConnectionString As String = "Data Source=172.16.0.102;Initial Catalog=DBx;Persist Security Info=True;User ID=system;Password=p@$$w0rd; Application Name=Cellcon_Meco"
            Using cmd As New SqlCommand()
                cmd.Connection = New SqlConnection(ConnectionStringDBx)
                cmd.Connection.Open()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT  LotNo, Package, Device, FrameNo, FASetDirection, CodeNo, WaferLotNo, TapingDirection, MarkType, MarkTextLine3, MarkTextLine2, MarkTextLine1,NumberOfStampStep, OSFT, OSProgram, MoldType, NewFormName, FTForm, MarkNo, PDFree, ULMark, ReelCount, CleamCounterMeasure, SubRank,Mask, ETC1, ETC2 FROM  TransactionData where LotNo = @lotNo"
                cmd.Parameters.Add("@lotNo", SqlDbType.VarChar).Value = lotNo
                Dim result = cmd.ExecuteReader()


                If result.HasRows Then
                    Return SaveTransacion.NotUpdate
                Else
                    Using cmd2 As New SqlCommand()
                        cmd2.Connection = New SqlConnection(ConnectionStringDBx)
                        cmd2.Connection.Open()
                        cmd2.CommandType = CommandType.Text
                        cmd2.CommandText = "INSERT INTO TransactionData (LotNo,Package,Device) VALUES (@lotNo,@package,@device)"
                        cmd2.Parameters.Add("@lotNo", SqlDbType.VarChar).Value = lotNo
                        cmd2.Parameters.Add("@package", SqlDbType.VarChar).Value = package
                        cmd2.Parameters.Add("@device", SqlDbType.VarChar).Value = device
                        cmd2.ExecuteNonQuery()
                        cmd2.Connection.Close()
                        Return SaveTransacion.UpdateSuccess
                    End Using

                End If
                cmd.Connection.Close()
            End Using
        Catch ex As Exception
            SaveCatchLog("Exception :" & ex.Message.ToString & "[lotNo:" & lotNo & "]", MethodBase.GetCurrentMethod().Name)
            MessageDialog("Exception :" & ex.Message.ToString & "[lotNo:" & lotNo & "]", MessageBoxType.Alarm)
            Return SaveTransacion.UpdateError
        End Try

    End Function
    Public Sub MessageDialog(message As String, messageType As MessageBoxType)
        Dim header As String
        If messageType = MessageBoxType.Success Then
            header = "สำเจ็จ"
        ElseIf messageType = MessageBoxType.Warning Then
            header = "แจ้งเตือน!"
        Else
            header = "ข้อมูลผิดพลาด"
        End If
        Using frm As New DialogMessage(message, Nothing, header)
            frm.ShowDialog()
        End Using
    End Sub
    Public Enum MessageBoxType
        Success
        Alarm
        Warning
        ApcsPro
    End Enum
    Public Enum SaveTransacion
        UpdateError
        UpdateSuccess
        NotUpdate
    End Enum
#Region "iLibraryService"
    Public c_IlibraryService As CellController.iLibraryService.IServiceiLibrary
    Public c_PLDataList As BindingList(Of PLData)
    Public c_PathPLDataList As String = Path.Combine(My.Application.Info.DirectoryPath, "PLDataList.xml")
    Public Sub SetupAndStart(lotNo As String, opNo As String)
        Try
            'Dim apcsProData As ApcsPro = New ApcsPro
            Dim carrierInfo As CarrierInfo = c_IlibraryService.GetCarrierInfo("PL-" & My.Settings.EquipmentNo, lotNo, opNo)
            If carrierInfo.LoadCarrier = CarrierInfo.CarrierStatus.Use Then
                carrierInfo.LoadCarrierNo = carrierInfo.CurrentCarrierNo
            End If
            If carrierInfo.RegisterCarrier = CarrierInfo.CarrierStatus.Use Then
                carrierInfo.RegisterCarrierNo = ""
            End If
            If carrierInfo.TransferCarrier = CarrierInfo.CarrierStatus.Use Then
                carrierInfo.TransferCarrierNo = carrierInfo.NextCarrierNo
            End If

            Dim setupSpecialParameter As SetupLotSpecialParametersEventArgs = New SetupLotSpecialParametersEventArgs With {
                .LayerNoApcs = "0501"
            }
            Dim result As SetupLotResult = c_IlibraryService.SetupLotPhase2(lotNo, "PL-" & My.Settings.EquipmentNo, opNo, "PL", Licenser.NoCheck, carrierInfo, setupSpecialParameter)
            c_IlibraryService.StartLotPhase2(lotNo, "PL-" & My.Settings.EquipmentNo, opNo, result.Recipe, carrierInfo, Nothing)

            ' WriteDataToXmlFile(c_PLDataList, c_PathPLDataList)
        Catch ex As Exception
            SaveCatchLog("Exception:" + ex.Message.ToString, "APCS Pro LotAdd")
            MessageBox.Show("Exception:" + ex.Message.ToString)
        End Try
    End Sub
    Public Function EndLot(pldata As PLData, carrierInfo As CarrierInfo) As String
        ' SavePLAlarmInfoToDbx()
        Dim url As String = ""
        Try

            Dim result As EndLotResult = c_IlibraryService.EndLotPhase2(pldata.LotNo, pldata.MCNo, pldata.OPNo, pldata.TotalGoodAdjust.Value, pldata.TotalNGAdjust.Value, Licenser.NoCheck, carrierInfo, Nothing)

            If Not result.IsPass Then
                Dim type As String = result.Type.ToString

                Select Case result.Type
                    Case MessageType.ApcsPro
                        url = "http://webserv.thematrix.net/atom"
                    Case MessageType.Apcs
                        url = "http://webserv.thematrix.net/ApcsStaff/Default.aspx"
                    Case MessageType.Unknown
                        url = "http://webserv.thematrix.net/atom"
                End Select


            End If
            c_PLDataList.Remove(pldata)
            WriteDataToXmlFile(c_PLDataList, c_PathPLDataList)
        Catch ex As Exception
            SaveCatchLog("Exception:" & ex.Message.ToString, MethodBase.GetCurrentMethod().Name)
        End Try
        Return url
    End Function
    Public Function IReportCheck(mcNo As String) As String
        Dim result As iReportResponse = c_IlibraryService.IRePortCheck("PL-" & mcNo)
        If result.HasError Then
            Return "iReport error:" & result.ErrorMessage
        Else
            Return ""
        End If
    End Function

#End Region
#Region "SaveToDBx"

    Public Sub SaveDBx(plData As PLData)

        Dim LotEndTime As Object
        Dim Material As Object
        Dim LoadCount As Object
        Dim ABNormal As Object
        Dim UnloadCount As Object
        Dim OPNo As Object
        Dim MagazineNo As Object
        Dim SelfConVersion As Object
        Dim NetVersion As Object
        Dim InputQtyAdjust As Object
        Dim TotalGoodAdjust As Object
        Dim TotalNGAdjust As Object
        Dim DummyQty As Object
        Dim OPJudgement As Object
        Dim Remark As Object
        Dim InputQtyFrameAdjust As Object
        Dim TotalGoodFrameAdjust As Object

        If plData.LotEndTime.HasValue Then
            LotEndTime = plData.LotEndTime
        Else
            LotEndTime = DBNull.Value
        End If
        If Not String.IsNullOrEmpty(plData.Material) Then
            Material = plData.Material
        Else
            Material = DBNull.Value
        End If
        If Not String.IsNullOrEmpty(plData.ABNormal) Then
            ABNormal = plData.ABNormal
        Else
            ABNormal = DBNull.Value
        End If
        If plData.LoadCount.HasValue Then
            LoadCount = plData.LoadCount
        Else
            LoadCount = DBNull.Value
        End If
        If plData.UnloadCount.HasValue Then
            UnloadCount = plData.UnloadCount
        Else
            UnloadCount = DBNull.Value
        End If
        If Not String.IsNullOrEmpty(plData.OPNo) Then
            OPNo = plData.OPNo
        Else
            OPNo = DBNull.Value
        End If
        If Not String.IsNullOrEmpty(plData.MagazineNo) Then
            MagazineNo = plData.MagazineNo
        Else
            MagazineNo = DBNull.Value
        End If
        If Not String.IsNullOrEmpty(plData.SelfConVersion) Then
            SelfConVersion = plData.SelfConVersion
        Else
            SelfConVersion = DBNull.Value
        End If
        If Not String.IsNullOrEmpty(plData.NetVersion) Then
            NetVersion = plData.NetVersion
        Else
            NetVersion = DBNull.Value
        End If
        If plData.InputQtyAdjust.HasValue Then
            InputQtyAdjust = plData.InputQtyAdjust
        Else
            InputQtyAdjust = DBNull.Value
        End If
        If plData.TotalGoodAdjust.HasValue Then
            TotalGoodAdjust = plData.TotalGoodAdjust
        Else
            TotalGoodAdjust = DBNull.Value
        End If
        If plData.TotalNGAdjust.HasValue Then
            TotalNGAdjust = plData.TotalNGAdjust
        Else
            TotalNGAdjust = DBNull.Value
        End If
        If plData.DummyQty.HasValue Then
            DummyQty = plData.DummyQty
        Else
            DummyQty = DBNull.Value
        End If
        If Not String.IsNullOrEmpty(plData.OPJudgement) Then
            OPJudgement = plData.OPJudgement
        Else
            OPJudgement = DBNull.Value
        End If
        If Not String.IsNullOrEmpty(plData.Remark) Then
            Remark = plData.Remark
        Else
            Remark = DBNull.Value
        End If
        If plData.InputQtyFrameAdjust.HasValue Then
            InputQtyFrameAdjust = plData.InputQtyFrameAdjust
        Else
            InputQtyFrameAdjust = DBNull.Value
        End If
        If plData.TotalGoodFrameAdjust.HasValue Then
            TotalGoodFrameAdjust = plData.TotalGoodFrameAdjust
        Else
            TotalGoodFrameAdjust = DBNull.Value
        End If
        Using cmd As New SqlCommand
            cmd.Connection = New SqlConnection(ConnectionStringDBx)
            cmd.Connection.Open()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select MCNo,LotNo,LotStartTime from PLData where MCNo = @MCNo and LotNo = @LotNo and LotStartTime = @LotStartTime"
            cmd.Parameters.Add("@MCNo", SqlDbType.VarChar).Value = plData.MCNo
            cmd.Parameters.Add("@LotNo", SqlDbType.VarChar).Value = plData.LotNo
            cmd.Parameters.Add("@LotStartTime", SqlDbType.VarChar).Value = plData.LotStartTime

            Dim rexult = cmd.ExecuteReader().HasRows
            cmd.Connection.Close()

            Using cmdUpdate As New SqlCommand
                cmdUpdate.Connection = New SqlConnection(ConnectionStringDBx)
                cmdUpdate.Connection.Open()
                cmdUpdate.CommandType = CommandType.Text
                If Not rexult Then 'Insert data
                    cmdUpdate.CommandText = "insert into PLdata (MCNo,LotNo,LotStartTime,LotEndTime,Material,ABNormal,LoadCount,UnloadCount,OPNo,MagazineNo," &
                            "SelfConVersion,NetVersion,InputQtyAdjust,TotalGoodAdjust,TotalNGAdjust,DummyQty,OPJudgement,Remark,InputQtyFrameAdjust,TotalGoodFrameAdjust)" &
                            " values (@MCNo,@LotNo,@LotStartTime,@LotEndTime,@Material,@ABNormal,@LoadCount,@UnloadCount,@OPNo,@MagazineNo," &
                            "@SelfConVersion,@NetVersion,@InputQtyAdjust,@TotalGoodAdjust,@TotalNGAdjust,@DummyQty,@OPJudgement,@Remark,@InputQtyFrameAdjust,@TotalGoodFrameAdjust)"

                Else 'Update data
                    cmdUpdate.CommandText = "update PLdata set LotEndTime = @LotEndTime,Material = @Material,ABNormal = @ABNormal,LoadCount = @LoadCount,UnloadCount = @UnloadCount," &
                            "OPNo = @OPNo,MagazineNo = @MagazineNo,SelfConVersion= @SelfConVersion,NetVersion = @NetVersion,InputQtyAdjust = @InputQtyAdjust," &
                            "TotalGoodAdjust = @TotalGoodAdjust,TotalNGAdjust = @TotalNGAdjust,DummyQty = @DummyQty,OPJudgement = @OPJudgement,Remark = @Remark," &
                            "InputQtyFrameAdjust = @InputQtyFrameAdjust,TotalGoodFrameAdjust = @TotalGoodFrameAdjust " &
                            "where MCNo = @MCNo and LotNo = @LotNo and LotStartTime = @LotStartTime and LotEndTime is null"
                End If
                cmdUpdate.Parameters.Add("@MCNo", SqlDbType.VarChar).Value = plData.MCNo
                cmdUpdate.Parameters.Add("@LotNo", SqlDbType.VarChar).Value = plData.LotNo
                cmdUpdate.Parameters.Add("@LotStartTime", SqlDbType.VarChar).Value = plData.LotStartTime
                cmdUpdate.Parameters.Add("@LotEndTime", SqlDbType.DateTime).Value = LotEndTime
                cmdUpdate.Parameters.Add("@Material", SqlDbType.VarChar).Value = Material
                cmdUpdate.Parameters.Add("@ABNormal", SqlDbType.VarChar).Value = ABNormal
                cmdUpdate.Parameters.Add("@LoadCount", SqlDbType.Int).Value = LoadCount
                cmdUpdate.Parameters.Add("@UnloadCount", SqlDbType.Int).Value = UnloadCount
                cmdUpdate.Parameters.Add("@OPNo", SqlDbType.VarChar).Value = OPNo
                cmdUpdate.Parameters.Add("@MagazineNo", SqlDbType.VarChar).Value = MagazineNo
                cmdUpdate.Parameters.Add("@SelfConVersion", SqlDbType.VarChar).Value = SelfConVersion
                cmdUpdate.Parameters.Add("@NetVersion", SqlDbType.VarChar).Value = NetVersion
                cmdUpdate.Parameters.Add("@InputQtyAdjust", SqlDbType.Int).Value = InputQtyAdjust
                cmdUpdate.Parameters.Add("@TotalGoodAdjust", SqlDbType.Int).Value = TotalGoodAdjust
                cmdUpdate.Parameters.Add("@TotalNGAdjust", SqlDbType.Int).Value = TotalNGAdjust
                cmdUpdate.Parameters.Add("@DummyQty", SqlDbType.Int).Value = DummyQty
                cmdUpdate.Parameters.Add("@OPJudgement", SqlDbType.VarChar).Value = OPJudgement
                cmdUpdate.Parameters.Add("@Remark", SqlDbType.VarChar).Value = Remark
                cmdUpdate.Parameters.Add("@InputQtyFrameAdjust", SqlDbType.Int).Value = InputQtyFrameAdjust
                cmdUpdate.Parameters.Add("@TotalGoodFrameAdjust", SqlDbType.Int).Value = TotalGoodFrameAdjust
                cmdUpdate.ExecuteNonQuery()
                cmdUpdate.Connection.Close()
            End Using

        End Using
    End Sub
#End Region
    Public Function GetPLData(lotNo As String) As PLData

        For Each data As PLData In c_PLDataList.Where(Function(x) x.LotNo = lotNo).ToList
            'data.LotStartTime = Now
            Return data
        Next
        Return Nothing
    End Function
End Module
