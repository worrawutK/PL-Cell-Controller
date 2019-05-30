Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Friend conn As New SqlConnection("Data Source=172.16.0.102;User ID=dbxuser;Initial Catalog=DBx;")
    Friend cmd As New SqlCommand
    Friend sql As String
    Friend OPNo As String
    Friend QRcode As String
    Friend Status As String
    Friend StatusDisplay As String

    Friend Machine As String = "PL-HM-01"
    Friend Package As String
    Friend LotNo As String
    Public Enum StatusQR
        OPNo
        QRcode
        Delete
        Again
        NoLotCart
    End Enum
    Public Enum Display
        Meco
        Reflow
    End Enum
    Friend Sub connect_open()
        'conn.Close()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Friend Function cmd_ExecuteReader() As SqlDataReader
        connect_open()
        cmd = New SqlCommand(sql, conn)
        Return cmd.ExecuteReader
    End Function
    Friend Function cmd_ExecuteNonQuery() As Integer
        connect_open()
        cmd = New SqlCommand(sql, conn)
        Return cmd.ExecuteNonQuery
    End Function
End Module
