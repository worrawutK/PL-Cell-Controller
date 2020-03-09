Imports System.ComponentModel

Public Class frmLotEndManual
    Dim _StartTime As Date
    Dim _EndTime As Date
    Dim _TragetTextbox As TextBox
    '  Dim _frmProcessForm As ProcessForm
    Private c_PLDataList As BindingList(Of PLData)
    Public Sub New(plDataList As BindingList(Of PLData))
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        ' _frmProcessForm = frm
        c_PLDataList = plDataList
    End Sub

    Private Sub frmLotEndManual_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'For Each strDataRow As DBxDataSet.PLDataRow In _frmProcessForm.DBxDataSet.PLData.Rows
        '    'If strDataRow.IsLotEndTimeNull = True Then
        '    cbbLotNo.Items.Add(strDataRow.LotNo)
        '    'End If
        'Next
        For Each data As PLData In c_PLDataList
            cbbLotNo.Items.Add(data.LotNo)
        Next
    End Sub

    Private Sub cbbLotNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbLotNo.SelectedIndexChanged
        If cbbLotNo.Text <> "" Then
            For Each data As PLData In c_PLDataList
                If data.LoadCount.HasValue Then
                    tbInput.Text = CStr(data.LoadCount.Value)
                Else
                    tbInput.Text = "0"
                End If

                If data.UnloadCount.HasValue Then
                    tbGood.Text = CStr(data.UnloadCount.Value)
                Else
                    tbGood.Text = "0"
                End If

                _StartTime = CDate(data.LotStartTime)
                cbbStartHR.Text = CStr(_StartTime.Hour)
                cbbStartMin.Text = CStr(_StartTime.Minute)
                DateStartTime.Value = _StartTime

                If data.LotEndTime.HasValue Then
                    _EndTime = CDate(data.LotEndTime)
                    cbbEndHR.Text = CStr(_EndTime.Hour)
                    cbbEndMin.Text = CStr(_EndTime.Minute)
                    DateEndTime.Value = _EndTime
                Else
                    DateEndTime.Value = Now
                    _EndTime = Nothing
                End If
            Next
            'For Each strDataRow As DBxDataSet.PLDataRow In _frmProcessForm.DBxDataSet.PLData.Rows
            '    If strDataRow.IsLoadCountNull = False Then
            '        tbInput.Text = CStr(strDataRow.LoadCount)
            '    Else
            '        tbInput.Text = "0"
            '    End If

            '    If strDataRow.IsUnloadCountNull = False Then
            '        tbGood.Text = CStr(strDataRow.UnloadCount)
            '    Else
            '        tbGood.Text = "0"
            '    End If

            '    _StartTime = CDate(strDataRow.LotStartTime)
            '    cbbStartHR.Text = CStr(_StartTime.Hour)
            '    cbbStartMin.Text = CStr(_StartTime.Minute)
            '    DateStartTime.Value = _StartTime

            '    If strDataRow.IsLotEndTimeNull = False Then
            '        _EndTime = CDate(strDataRow.LotEndTime)
            '        cbbEndHR.Text = CStr(_EndTime.Hour)
            '        cbbEndMin.Text = CStr(_EndTime.Minute)
            '        DateEndTime.Value = _EndTime
            '    Else
            '        DateEndTime.Value = Now
            '        _EndTime = Nothing
            '    End If

            'Next
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button12.Click, Button11.Click, Button10.Click

        If _TragetTextbox Is Nothing Then
            Exit Sub
        End If

        Dim bt As Button = CType(sender, Button)
        _TragetTextbox.Focus()
        If bt.Text = "Clear" Then
            _TragetTextbox.Text = ""
        ElseIf bt.Text = "BS" Then 'BackSpace
            SendKeys.Send("{BS}")
        Else
            SendKeys.Send(bt.Text)
        End If
    End Sub

    Private Sub tbInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbInput.Click
        _TragetTextbox = tbInput
        tbInput.BackColor = Color.Yellow
        tbGood.BackColor = Color.White
    End Sub

    Private Sub tbGood_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbGood.Click
        _TragetTextbox = tbGood
        tbGood.BackColor = Color.Yellow
        tbInput.BackColor = Color.White
    End Sub

    Private Sub btOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click

        If cbbLotNo.Text = "" Then
            MsgBox("กรุณาเลือก LotNo")
            Exit Sub
        ElseIf tbGood.Text = "" OrElse IsNumeric(tbGood.Text) = False Then
            MsgBox("กรุณากรอก Good Qty")
            Exit Sub
        ElseIf tbInput.Text = "" OrElse IsNumeric(tbInput.Text) = False Then
            MsgBox("กรุณากรอก Input Qty")
            Exit Sub
        ElseIf cbbStartHR.Text = "" OrElse cbbStartMin.Text = "" Then
            MsgBox("กรุณากรอก StartTime")
            Exit Sub
        ElseIf cbbEndHR.Text = "" OrElse cbbEndMin.Text = "" Then
            MsgBox("กรุณากรอก EndTime")
            Exit Sub
        End If


        _StartTime = DateStartTime.Value
        _StartTime.AddHours(CDbl(cbbStartHR.Text))
        _StartTime.AddMinutes(CDbl(cbbStartMin.Text))

        _EndTime = DateEndTime.Value
        _EndTime.AddHours(CDbl(cbbEndHR.Text))
        _EndTime.AddMinutes(CDbl(cbbEndMin.Text))

        If MessageBox.Show("ยืนยันข้อมูล ถูกต้องหรือไม่ ", "ยืนยันข้อมูล", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            For Each data As PLData In c_PLDataList
                If cbbLotNo.Text = data.LotNo Then
                    data.LotStartTime = _StartTime
                    data.LotEndTime = _EndTime
                    data.LoadCount = CInt(tbInput.Text)
                    data.UnloadCount = CInt(tbGood.Text)
                End If
            Next
            'For Each strDataRow As DBxDataSet.PLDataRow In _frmProcessForm.DBxDataSet.PLData.Rows
            '    If cbbLotNo.Text = strDataRow.LotNo Then
            '        strDataRow.LotStartTime = _StartTime
            '        strDataRow.LotEndTime = _EndTime
            '        strDataRow.LoadCount = CInt(tbInput.Text)
            '        strDataRow.UnloadCount = CInt(tbGood.Text)
            '    End If
            'Next

            'For i = 0 To _frmProcessForm.PLDataDataGridView.Rows.Count - 1
            '    If _frmProcessForm.PLDataDataGridView.Rows(i).Cells(5).Value.ToString <> "" Then
            '        _frmProcessForm.PLDataDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Red
            '        'Else
            '        '    _frmProcessForm.PLDataDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Lime
            '    End If
            'Next

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub
End Class