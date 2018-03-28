Imports System.Data.SqlClient

Public Class SECSGEMDB

    Private m_ConnectionString As String

    Public Sub New(ByVal conStr As String)
        m_ConnectionString = conStr
    End Sub

    Public Function OpenConnection() As SqlConnection
        Dim con As SqlConnection = New SqlConnection()
        con.ConnectionString = m_ConnectionString
        con.Open()
        Return con
    End Function

    Public Sub FillDefinedReport(ByVal drDic As Dictionary(Of UInt32, DefinedReport), ByVal con As SqlConnection, ByVal machineType As String)
        Using table As DataTable = New DataTable()
            Using cmd As SqlCommand = con.CreateCommand()
                'have to user "ORDER BY" as mr.Witoon old library
                cmd.CommandText = "SELECT ID, RPTID, VID, MachineType, Description FROM [SECSGEM].SECS.ReportAndElement WHERE MachineType = @MachineType ORDER BY RPTID, VID ASC"
                cmd.Parameters.AddWithValue("@MachineType", machineType)
                table.Load(cmd.ExecuteReader())
                drDic.Clear()
                Dim definedReport As DefinedReport
                Dim vid As UInt32
                Dim rptId As UInt32
                For Each row As DataRow In table.Rows
                    rptId = CUInt(row("RPTID"))
                    vid = CUInt(row("VID"))
                    If drDic.ContainsKey(rptId) Then
                        definedReport = drDic(rptId)
                    Else
                        definedReport = New DefinedReport()
                        drDic.Add(rptId, definedReport)
                    End If
                    definedReport.SVIDList.Add(vid)
                    definedReport.RPTID = rptId
                Next

                If drDic.Count > 0 Then
                    DefReport.Clear()
                    DefReport = table
                End If


            End Using
        End Using
    End Sub

    Public Sub FillLinkedReport(ByVal drDic As Dictionary(Of UInt32, LinkedReport), ByVal con As SqlConnection, ByVal machineType As String)
        Using table As DataTable = New DataTable()
            Using cmd As SqlCommand = con.CreateCommand()
                cmd.CommandText = "SELECT ID, CEID, RPTID, MachineType, Description FROM [SECSGEM].SECS.CEIDAndReport WHERE MachineType = @MachineType ORDER BY CEID, RPTID ASC"
                cmd.Parameters.AddWithValue("@MachineType", machineType)
                table.Load(cmd.ExecuteReader())
                drDic.Clear()
                Dim linkedReport As LinkedReport
                Dim ceid As UInt32
                Dim rptId As UInt32

                For Each row As DataRow In table.Rows
                    ceid = CUInt(row("CEID"))
                    rptId = CUInt(row("RPTID"))
                    If drDic.ContainsKey(ceid) Then
                        linkedReport = drDic(ceid)
                    Else
                        linkedReport = New LinkedReport()
                        drDic.Add(ceid, linkedReport)
                    End If
                    linkedReport.RPTIDList.Add(rptId)
                    linkedReport.CEID = ceid
                Next

                If drDic.Count > 0 Then
                    LinkTable.Clear()
                    LinkTable = table
                End If
            End Using
        End Using
    End Sub

End Class
