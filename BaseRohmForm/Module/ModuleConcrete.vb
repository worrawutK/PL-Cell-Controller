Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports CellController.iLibraryService
Module ModuleConcrete
    Public Function GetPerFrame(pkg As String) As GetPerFrameResult
        Dim result As GetPerFrameResult = New GetPerFrameResult
        Try
            Using con As New SqlConnection("Data Source=172.16.0.102;Initial Catalog=StoredProcedureDB;Persist Security Info=True;User ID=system;Password=p@$$w0rd; Application Name=Cellcon_Meco")
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
    Public Function GetAlarmInfo(mcno As String) As List(Of AlarmInfo)
        Dim alarmInfos As List(Of AlarmInfo) = New List(Of AlarmInfo)
        Try
            Using con As New SqlConnection("Data Source=172.16.0.102;Initial Catalog=StoredProcedureDB;Persist Security Info=True;User ID=system;Password=p@$$w0rd; Application Name=Cellcon_Meco")
                Using cmd As New SqlCommand
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "dbo.[sp_get_alarm_table]"
                    cmd.Parameters.Add("@mcno", SqlDbType.VarChar).Value = mcno
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
                                Dim alarmInfo As AlarmInfo = New AlarmInfo()
                                alarmInfo.Id = CType(dr("ID"), Integer)
                                alarmInfo.AlarmNo = CType(dr("AlarmNo"), Integer)
                                alarmInfo.MachineType = CType(dr("MachineType"), String)
                                alarmInfo.AlarmType = CType(dr("AlarmType"), String)
                                alarmInfo.AlarmMessage = CType(dr("AlarmMessage"), String)
                                alarmInfos.Add(alarmInfo)
                            End If
                        End While

                    End Using
                    con.Close()
                End Using

            End Using
            Return alarmInfos

        Catch ex As Exception
            SaveCatchLog("Exception:" + ex.Message.ToString, MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        SaveCatchLog("data alarmInfo not found dbo.[sp_get_alarm_table] @mcno=" + mcno, MethodBase.GetCurrentMethod().Name)
        Return Nothing
    End Function
    Public Function SaveTransacionData(ByVal lotNo As String, ByVal device As String, ByVal package As String) As SaveTransacion
        Try
            Dim ConnectionString As String = "Data Source=172.16.0.102;Initial Catalog=DBx;Persist Security Info=True;User ID=system;Password=p@$$w0rd; Application Name=Cellcon_Meco"
            Using cmd As New SqlCommand()
                cmd.Connection = New SqlConnection(ConnectionString)
                cmd.Connection.Open()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT   LotNo, Package, Device, FrameNo, FASetDirection, CodeNo, WaferLotNo, TapingDirection, MarkType, MarkTextLine3, MarkTextLine2, MarkTextLine1,NumberOfStampStep, OSFT, OSProgram, MoldType, NewFormName, FTForm, MarkNo, PDFree, ULMark, ReelCount, CleamCounterMeasure, SubRank,Mask, ETC1, ETC2 FROM  TransactionData where LotNo = @lotNo"
                cmd.Parameters.Add("@lotNo", SqlDbType.VarChar).Value = lotNo
                Dim result = cmd.ExecuteReader()


                If result.HasRows Then
                    Return SaveTransacion.NotUpdate
                Else
                    Using cmd2 As New SqlCommand()
                        cmd2.Connection = New SqlConnection(ConnectionString)
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
            MessageDialog("Exception :" & ex.Message.ToString & "[lotNo:" & lotNo & "]", MessageType.Alarm)
            Return SaveTransacion.UpdateError
        End Try

    End Function
    Public Sub MessageDialog(message As String, messageType As MessageType)
        Dim header As String
        If messageType = MessageType.Success Then
            header = "สำเจ็จ"
        ElseIf messageType = MessageType.Warning Then
            header = "แจ้งเตือน!"
        Else
            header = "ข้อมูลผิดพลาด"
        End If
        Using frm As New DialogMessage(message, Nothing, header)
            frm.ShowDialog()
        End Using
    End Sub
    Public Enum MessageType
        Success
        Alarm
        Warning
    End Enum
    Public Enum SaveTransacion
        UpdateError
        UpdateSuccess
        NotUpdate
    End Enum
#Region "iLibraryService"
    Public c_IlibraryService As CellController.iLibraryService.IServiceiLibrary
    Public c_PLDataList As BindingList(Of PLData)
    Private c_PathPLDataList As String = Path.Combine(My.Application.Info.DirectoryPath, "PLDataList.xml")
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

            WriteDataToXmlFile(c_PLDataList, c_PathPLDataList)
        Catch ex As Exception
            SaveCatchLog("Exception:" + ex.Message.ToString, "APCS Pro LotAdd")
            MessageBox.Show("Exception:" + ex.Message.ToString)
        End Try
    End Sub
    Public Function IReportCheck(mcNo As String) As String
        Dim result As iReportResponse = c_IlibraryService.IRePortCheck(mcNo)
        If result.HasError Then
            Return "iReport error:" & result.ErrorMessage
        Else
            Return ""
        End If
    End Function
#End Region

End Module
