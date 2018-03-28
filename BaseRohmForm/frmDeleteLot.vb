Public Class frmDeleteLot
    Private _frmMain As ProcessForm
    Public Sub New(ByVal frm As ProcessForm)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frmMain = frm

    End Sub

    Private Sub frmDeleteLot_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each strDataRow As DBxDataSet.PLDataRow In _frmMain.DBxDataSet.PLData.Rows
            cbbLotDetele.Items.Add(strDataRow.LotNo)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cbbLotDetele.Text = "" Then
            MsgBox("กรุณาเลือก Lot ที่ต้องการลบ")
            Exit Sub
        End If

        Dim removeList As List(Of DataRow) = New List(Of DataRow)
        For Each strData As DBxDataSet.PLDataRow In _frmMain.DBxDataSet.PLData.Rows
            If cbbLotDetele.Text = strData.LotNo Then
                removeList.Add(strData)
            End If
        Next

        For Each DataRowRemove As DataRow In removeList
            _frmMain.DBxDataSet.PLData.Rows.Remove(DataRowRemove)
        Next

        '_frmMain.SavePLDataTableBin()
        MsgBox("เรียบร้อย")

        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class