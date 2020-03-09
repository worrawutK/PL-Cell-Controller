Imports System.ComponentModel

Public Class frmDeleteLot

    Private c_PLdata As BindingList(Of PLData)
    Public Sub New(plDataList As BindingList(Of PLData))

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        c_PLdata = plDataList

    End Sub

    Private Sub frmDeleteLot_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'For Each strDataRow As DBxDataSet.PLDataRow In _frmMain.DBxDataSet.PLData.Rows
        '    cbbLotDetele.Items.Add(strDataRow.LotNo)
        'Next
        For Each pldata As PLData In c_PLdata
            cbbLotDetele.Items.Add(pldata.LotNo)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If cbbLotDetele.Text = "" Then
                MsgBox("กรุณาเลือก Lot ที่ต้องการลบ")
                Exit Sub
            End If
            Dim data As PLData = c_PLdata.Where(Function(x) x.LotNo = cbbLotDetele.Text.Trim).FirstOrDefault
            c_PLdata.Remove(data)
            '_frmMain.SavePLDataTableBin()
            MsgBox("เรียบร้อย")

            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            MsgBox("Exception:" & ex.Message.ToString)
        End Try

    End Sub

    Private Sub button2_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class