
Imports System.IO

Module SECSGEMModule
#Region "Commomn Define"
    Enum TypeOfSECSMSG
        HSMS
        SEC1
    End Enum

    Public m_LinkedReportDic As New Dictionary(Of UInt32, LinkedReport)
    Public m_DefinedReportDic As New Dictionary(Of UInt32, DefinedReport)
    Private m_SECSGEMDB As New SECSGEMDB(My.Settings.DBConnSTR)
    Enum AutoDefineReportFlow                      '160630 \783 'AutoLoad revise
        Idle
        GoOnline
        Spooling_Purge
        DeleteAllReport
        DefineReport
        LinkReport
        EnableAllReport
        EnableAllAlarm
    End Enum
    Public CurDefFlow As AutoDefineReportFlow = AutoDefineReportFlow.Idle
    Public DefReport As New DataTable
    Public LinkTable As New DataTable()
    Public CommuniationState As String = "NOT_CONNECTED"      '160629 \783 Eq comm revise
    Public ControlState As String = "  "
#End Region
    Public Function ConvToString(ByVal comBuffer As Byte()) As String
        Dim builder As New System.Text.StringBuilder(comBuffer.Length * 3)
        'loop through each byte in the array
        For Each data As Byte In comBuffer
            builder.Append(System.Convert.ToString(data, 16).PadLeft(2, "0"c).PadRight(3, " "c))
            'convert the byte to a string and add to the stringbuilder
        Next
        'return the converted value
        Return builder.ToString().ToUpper()

    End Function

    Public Function ConvertStringToByte(ByVal str As String) As Byte()
        Dim ret(0) As Byte
        Try
            str = Trim(str.Replace(" ", ""))
            Array.Resize(ret, CInt(str.Length / 2))
            For i As Integer = 0 To str.Length - 2 Step 2
                ret(CInt(i / 2)) = Convert.ToByte(str.Substring(i, 2), 16)
            Next
            Return ret
        Catch ex As Exception
            Return ret
            MsgBox(ex.Message)
        End Try

    End Function
    Public Function ConvertByteToSML(ByVal sender As Object, ByVal _byte() As Byte) As String
        Dim ret As String = ""
        Try
            Dim _SECSMSG As SECSGEM
            If _byte.Length >= 13 Then

                _SECSMSG = New SECSGEM(_byte, SECSMSG_Header.TypeOfSECSMSG.HSMS)


                _SECSMSG.SMLConvert()
                ret = "S" + _SECSMSG.Sec_Stream.ToString + "F" + _SECSMSG.Sec_Function.ToString + vbCrLf + _SECSMSG.SMLOutput
            End If
        Catch ex As Exception
            SaveCatchLog(ex.Message, "ConvertByteToSML()")
        End Try

        Return ret
    End Function


    Public Function DownloadReportSetting() As String
        Try
            Using con As System.Data.SqlClient.SqlConnection = m_SECSGEMDB.OpenConnection()
                m_SECSGEMDB.FillLinkedReport(m_LinkedReportDic, con, My.Settings.MCType)
                m_SECSGEMDB.FillDefinedReport(m_DefinedReportDic, con, My.Settings.MCType)
            End Using
            If m_LinkedReportDic.Count = 0 Or m_DefinedReportDic.Count = 0 Then
                Return "False : Report not found"
            End If

            Return "True :"
        Catch ex As Exception
            SaveCatchLog(ex.Message, "DownloadReportSetting")
            Return "False : " & ex.ToString
        End Try
    End Function

End Module
