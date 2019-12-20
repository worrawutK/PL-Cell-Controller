Imports System.Data.SqlClient

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
        End Try
        Return result
    End Function
End Module
