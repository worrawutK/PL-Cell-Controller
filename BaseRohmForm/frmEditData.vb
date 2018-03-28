Public Class frmEditData

    Private Sub frmEditData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Process.Start("C:\WINDOWS\system32\osk.exe")
        For Each RowData As DBxDataSet.PLDataRow In _frmMain.DBxDataSet.PLData.Rows
            cbLotNo.Items.Add(RowData.LotNo)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start("C:\WINDOWS\system32\osk.exe")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If tbMag.Text = "" Then
            MsgBox("กรุณากรอก Magazine")
            Exit Sub
        End If

        For Each RowData As DBxDataSet.PLDataRow In _frmMain.DBxDataSet.PLData.Rows
            If RowData.LotNo = cbLotNo.Text Then
                RowData.MagazineNo = tbMag.Text
            End If
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Dim _frmMain As ProcessForm
    Public Sub New(ByVal frmMain As ProcessForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _frmMain = frmMain

    End Sub

    Private Sub cbLotNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLotNo.SelectedIndexChanged
        For Each RowData As DBxDataSet.PLDataRow In _frmMain.DBxDataSet.PLData.Rows
            tbMag.Text = RowData.MagazineNo
        Next
    End Sub

End Class