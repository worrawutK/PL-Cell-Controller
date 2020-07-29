Imports System.IO
Imports System.Reflection
Imports System.Runtime.Serialization.Formatters.Soap

Module ModuleAppGeneral

#Region "Commomn Define"

    Public Const PathPicObj As String = "D:\RohmSystem\rCellcon" & "\Picture"
    Public m_SelfData As New MecoParameter
    Public DIR_LOG As String = My.Application.Info.DirectoryPath & "\LOG"
    Public DIR_STDF_BACKUP As String = My.Application.Info.DirectoryPath & "\STDF_BACKUP"
    Public DIR_STATUS As String = My.Application.Info.DirectoryPath & "\STATUS"
    Public OprData As New CommonData
    Public UserTable As New DataTable
    Public m_strNetVersion As String  '"1.9.06.13 APCS Pro." '"Ver.170622"
    Public m_DummyCheck As Boolean = True
    Public Sub MakeDirectories()
        Try
            If Not (Directory.Exists(DIR_LOG)) Then
                Directory.CreateDirectory(DIR_LOG)
            End If
            If Not (Directory.Exists(DIR_STDF_BACKUP)) Then
                Directory.CreateDirectory(DIR_STDF_BACKUP)
            End If
            If Not (Directory.Exists(DIR_STATUS)) Then
                Directory.CreateDirectory(DIR_STATUS)
            End If
        Catch ex As Exception
            SaveCatchLog(ex.Message, "MakeDirectories()")
        End Try
    End Sub

    Public Sub SaveCatchLog(ByVal message As String, ByVal fnName As String)
        Using sw As StreamWriter = New StreamWriter(Path.Combine(DIR_LOG, "Catch_" & Now.ToString("yyyyMMdd") & ".log"), True)
            sw.WriteLine(Now.ToString("yyyy/MM/dd HH:mm:ss.fff") & " " & fnName & ">" & message)
        End Using
    End Sub

#End Region

    Dim SynSave As New Object       'Temp for SML Edit Code
    Public Sub SaveData(ByVal fileName As String, ByVal strSaveData As String, Optional ByVal bAppend As Boolean = True)
        Try
            SyncLock (SynSave)
                Dim filePath As String = My.Application.Info.DirectoryPath & "\LOG\"
                If File.Exists(filePath & fileName) Then
                    Dim info2 As New FileInfo(filePath & fileName)
                    Dim fileSize As Double = info2.Length / 1048576
                    If fileSize > 2 Then ' if file size greater than 2 MB
                        Dim dFilePath As String
                        dFilePath = filePath + fileName.Replace("\", "\_backup\")
                        dFilePath = dFilePath.Replace(".log", "-" + Format(Now, "yyyyMMdd") + ".log")

                        Dim di As New IO.DirectoryInfo(New FileInfo(dFilePath).DirectoryName)
                        Dim aryFi As IO.FileInfo() = di.GetFiles(New FileInfo(dFilePath).Name.Replace("."c, "*."))

                        dFilePath = dFilePath.Replace(".log", "-" + CStr(aryFi.Length + 1) + ".log")
                        File.Copy(filePath & fileName, dFilePath, True)

                        'info2 = New FileInfo(dFilePath)
                        'DeleteOldLogFile(New IO.DirectoryInfo(info2.DirectoryName))
                        Kill(filePath & fileName)
                        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\LOG\" & fileName, strSaveData + vbCrLf, bAppend)
                    Else
                        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\LOG\" & fileName, strSaveData + vbCrLf, bAppend)
                    End If
                Else
                    My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\LOG\" & fileName, strSaveData + vbCrLf, bAppend)
                End If
            End SyncLock
        Catch ex As Exception
            SaveCatchLog(ex.Message, "SaveData")
        End Try

    End Sub

    Public Sub WrXml(ByVal pathfile As String, ByVal TarObj As Object)
        'Dim xfile As String = SelPath & "Config.xml"
        Dim fs As New IO.FileStream(pathfile, IO.FileMode.Create)
        Dim bs As New SoapFormatter
        bs.Serialize(fs, TarObj)
        fs.Close()
    End Sub
    Public Function RdXml(ByVal pathfile As String) As Object
        'Dim xfile As String = SelPath & "Config.xml"
        Dim TarObj As New Object
        If Dir(pathfile) <> "" Then
            Dim fs As New IO.FileStream(pathfile, IO.FileMode.Open)
            Dim bs As New SoapFormatter
            TarObj = bs.Deserialize(fs)
            fs.Close()
        End If
        Return TarObj
    End Function

    Public Sub Commlog(ByVal Massage As String, ByVal Path As String) 'Comm log
        Dim logpath As clsErrorLog = clsErrorLog.GetInstance
        logpath.ErrLogFileName = Path   ' My.Application.Info.DirectoryPath & "\LOG\Comm.log"
        clsErrorLog.addlog(Format(Now, "yyyy-MM-ddTHH:mm:ss | ") & Massage)
    End Sub





    Public Function CommentFilter(ByVal str As String) As String
        Try
            Dim pos As Integer

            pos = InStr(str, ";")       'Allow use ";" Character to Comment
            If pos > 0 Then str = Mid(str, 1, pos - 1)
            Return Trim(str)
        Catch ex As Exception
            Return CStr(str.Length)
            SaveCatchLog(ex.Message, "CommentFilter")
        End Try

    End Function


End Module
