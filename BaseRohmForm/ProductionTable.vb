Imports System.ComponentModel

Public Class ProductionTable
#Region "Commomn Define"
    Event E_SlInfo(ByVal info As String)
    Event E_QRReadSuccess()
    Event E_QRReadOPIDSuccess()
    Event E_WorkSlipClick()
    Event E_AlarmCellconReset()
#End Region

    Private Sub tbOther_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles tbOther.Paint
        Dim myPen As Pen
        myPen = New Pen(Color.CadetBlue, 1)
        e.Graphics.DrawLine(myPen, 4, 28, Me.Width - 12, 28)
    End Sub
    Public Delegate Sub MakeAlarmCellConDelegate(ByVal AlarmMessage As String, ByVal Location As String, ByVal Status As String, ByVal AlarmID As String)
    Public Sub MakeAlarmCellCon(ByVal AlarmMessage As String, Optional ByVal Location As String = "", Optional ByVal Status As String = "", Optional ByVal AlarmID As String = "")
        If Me.InvokeRequired Then
            Me.Invoke(New MakeAlarmCellConDelegate(AddressOf MakeAlarmCellCon), AlarmMessage, Location, Status, AlarmID)
        Else
            Try
                If AlarmMessage = "AlarmClear" Then   '160712 \783 PrdTable Clear
                    dgvAlarmCellCon.Rows.Clear()
                    Exit Sub
                End If
                lblAlarm.Text = AlarmMessage
                If dgvAlarmCellCon.RowCount > 100 Then dgvAlarmCellCon.Rows.Clear()
                dgvAlarmCellCon.Rows.Add()
                Dim r As Integer = dgvAlarmCellCon.RowCount - 2
                dgvAlarmCellCon.Item(0, r).Value = Format(Now, "yyyy/MM/dd HH:mm:ss.fff")
                dgvAlarmCellCon.Item(1, r).Value = Location
                dgvAlarmCellCon.Item(2, r).Value = Status
                dgvAlarmCellCon.Item(3, r).Value = AlarmID
                dgvAlarmCellCon.Item(4, r).Value = AlarmMessage
                dgvAlarmCellCon.Sort(dgvAlarmCellCon.Columns.Item(0), ListSortDirection.Descending)
                tbPageMain.SelectTab("tbAlarmCellCon")
            Catch ex As Exception
                SaveCatchLog(ex.Message, "MakeAlarmCellCon()")
            End Try

        End If


    End Sub
    Public Delegate Sub AlarmTableDelegate(ByVal AlarmALCD As Boolean, ByVal AlarmALID As String, ByVal AlarmALTX As String, ByVal AlarmType As String)
    Public Sub AlarmTable(ByVal AlarmALCD As Boolean, ByVal AlarmALID As String, ByVal AlarmALTX As String, Optional ByVal AlarmType As String = "0")

        If dgvAlarm.IsDisposed = True Then
            Exit Sub
        End If

        If Me.InvokeRequired Then
            Me.Invoke(New AlarmTableDelegate(AddressOf AlarmTable), AlarmALCD, AlarmALID, AlarmALTX, AlarmType)
        Else
            Try
                If dgvAlarm.RowCount > 50 Then dgvAlarm.Rows.Clear()
                dgvAlarm.Rows.Add()
                Dim r As Integer = dgvAlarm.RowCount - 2
                dgvAlarm.Item(0, r).Value = Format(Now, "yyyy/MM/dd HH:mm:ss.fff")
                dgvAlarm.Item(3, r).Value = AlarmType
                If AlarmALCD = True Then
                    dgvAlarm.Item(1, r).Value = "Set"
                Else
                    dgvAlarm.Item(1, r).Value = "Clear"
                End If
                dgvAlarm.Item(2, r).Value = AlarmALID
                dgvAlarm.Item(4, r).Value = AlarmALTX
                dgvAlarm.Sort(dgvAlarm.Columns.Item(0), ListSortDirection.Descending)
                'Update_dgvLogs("Received", "S5F1[" & Alarm.ALTX & "]")
            Catch ex As Exception
                SaveCatchLog(ex.Message, "AlarmTable()")
            End Try

        End If


    End Sub


    Private Delegate Sub Update_dgvProductionDetailDelegate(ByVal itemID As String, ByVal type As String, ByVal action As String, ByVal location As String)
    Public Sub Update_dgvProductionDetail(ByVal itemID As String, ByVal type As String, ByVal action As String, ByVal location As String)

        If dgvProductionDetail.IsDisposed = True Then
            Exit Sub
        End If

        If Me.InvokeRequired Then
            Me.Invoke(New Update_dgvProductionDetailDelegate(AddressOf Update_dgvProductionDetail), itemID, type, action, location)
        Else
            If dgvProductionDetail.RowCount > 300 Then dgvProductionDetail.Rows.Clear()
            dgvProductionDetail.Rows.Add()
            Dim r As Integer = dgvProductionDetail.RowCount - 2
            dgvProductionDetail.Item("Time", r).Value = Format(Now, "yyyy/MM/dd HH:mm:ss.fff")
            dgvProductionDetail.Item("ItemID", r).Value = itemID
            dgvProductionDetail.Item("Type", r).Value = type
            dgvProductionDetail.Item("Action", r).Value = action
            dgvProductionDetail.Sort(dgvProductionDetail.Columns.Item(0), ListSortDirection.Descending)
            'tbPageMain.SelectTab("tbDetail")
        End If

    End Sub

    
    Protected Overrides ReadOnly Property CreateParams() As CreateParams   'Disable Close(x) Button
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property


    Private Sub CloseToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem2.Click
        Me.Close()
    End Sub

   
    Private Sub ProductionTable_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        tbPageMain.SelectTab(1)
    End Sub

    Private Sub SizableToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SizableToolStripMenuItem.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
    End Sub

    Private Sub FixedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FixedToolStripMenuItem.Click
        Me.Height = 211
        Me.Dock = DockStyle.Bottom
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub


    Private Sub MinimizeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MinimizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbxQR_Click(sender As System.Object, e As System.EventArgs) Handles pbxQR.Click, btnWorkSlip.Click
        If My.Settings.SECS_Enable Or My.Settings.CsProtocol_Enable Then   'if Protocol enable Disable manual input
            Exit Sub
        End If
        If Not IsNumeric(btnOPID.Text) Then
            MsgBox("Please input OPID")
            Exit Sub
        End If
        tbxKey.Text = ""
        tbxKey.Focus()
        btnWorkSlip.ForeColor = Color.Green
        RaiseEvent E_WorkSlipClick()
        RaiseEvent E_SlInfo("Please Read Work Slip QR Data")
    End Sub

    Private Sub tbxKey_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbxKey.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If tbxKey.Text.Length = 252 Then
                OprData.QrData = tbxKey.Text.ToUpper
                tbxKey.Text = ""
                RaiseEvent E_QRReadSuccess()
                pbxQR.Focus()
            Else
                tbxKey.Text = ""
                RaiseEvent E_SlInfo("QR Slip Read False")
            End If
        End If
        btnWorkSlip.ForeColor = Color.Black
    End Sub

    Private Sub pbxOPID_Click(sender As System.Object, e As System.EventArgs) Handles pbxOPID.Click, btnOPID.Click
        If My.Settings.SECS_Enable Or My.Settings.CsProtocol_Enable Then    'if Protocol enable Disable manual input
            Exit Sub
        End If
        tbxQR_OPID.Text = ""
        tbxQR_OPID.Focus()
        btnOPID.ForeColor = Color.Green
        RaiseEvent E_SlInfo("Please Read OPID QR Data")

    End Sub

    Private Sub tbxQR_OPID_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbxQR_OPID.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
           
            If tbxQR_OPID.Text.Length = 6 Then                   'OPID Qr length is 6
                If Not IsNumeric(tbxQR_OPID.Text) Then
                    Exit Sub
                End If
                OprData.OPID = tbxQR_OPID.Text
                tbxQR_OPID.Text = ""
                RaiseEvent E_QRReadOPIDSuccess()
                pbxOPID.Focus()
            Else
                tbxQR_OPID.Text = ""
                RaiseEvent E_SlInfo("QR Slip Read False")
            End If
        End If
        btnOPID.ForeColor = Color.Black

    End Sub

    Private Sub btnCellConAlmRst_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCellConAlmRst_Click_1(sender As Object, e As EventArgs) Handles btnCellConAlmRst.Click
        MakeAlarmCellCon("AlarmClear")
        tbPageMain.SelectTab("tbDetail")
    End Sub
End Class