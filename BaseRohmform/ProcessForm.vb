Imports System.Threading
Imports System.ComponentModel
Imports System.IO
Imports Rohm.Apcs.Tdc
Imports System.Runtime.Serialization.Formatters.Binary
Imports XtraLibrary.SecsGem
'Imports iLibrary
Imports Rohm.Common.Logging
Imports System.Xml.Serialization
Imports System.Reflection
Imports CellController.iLibraryService
Imports System.Data.SqlClient

Public Class ProcessForm

    Private c_MDIParent1 As MDIParent1
    Public Sub New(frm As MDIParent1)

        ' This call is required by the designer.
        InitializeComponent()
        c_IlibraryService = New ServiceiLibraryClient
        c_PLDataList = New BindingList(Of PLData)
        ' Add any initialization after the InitializeComponent() call.
        c_MDIParent1 = frm
    End Sub


    Private Sub ProcessForm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim myPen As Pen
        myPen = New Pen(Color.RoyalBlue, 17)
        e.Graphics.DrawLine(myPen, 0, 10, Me.Width, 10)
        myPen = New Pen(Color.MidnightBlue, 1)
        e.Graphics.DrawLine(myPen, 0, 19, Me.Width, 19)
        myPen = New Pen(Color.PowderBlue, 25)
        e.Graphics.DrawLine(myPen, 0, 110, Me.Width, 110)
        myPen = New Pen(Color.CadetBlue, 1)
        e.Graphics.DrawLine(myPen, 1, 122, Me.Width, 122)

    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams   'Disable Close(x) Button
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property


    Public Sub Event_LotInfo_Rohm(ByVal LotNo As String, ByVal OPNo As String, ByVal Mgz As String)
        Dim plData As PLData = New PLData()
        Try
            If LotNo.Length > 10 Then
                plData.LotNo = LotNo.Substring(0, 10).Trim
            Else
                plData.LotNo = LotNo.Trim
            End If
            If c_PLDataList.Where(Function(x) x.LotNo = plData.LotNo).Any Then
                Return
            End If
        Catch ex As Exception
            SaveCatchLog(ex.Message & "  " & CStr(LotNo), "LotNo.Substring")
        End Try

        Try
            SaveTransacionData(m_SelfData.LotName, m_SelfData.DeviceName, m_SelfData.RecipeName)
        Catch ex As Exception
            SaveCatchLog(ex.Message & "  " & CStr(LotNo), "TransactionCheck")
        End Try
        Try
            plData.McNo = My.Settings.ProcessName & "-" & My.Settings.EquipmentNo
            plData.OpNo = OPNo
            plData.MagazineNo = Mgz
            plData.LotStartTime = Now
            plData.NetVersion = m_strNetVersion
            c_PLDataList.Add(plData)
        Catch ex As Exception
            SaveCatchLog(ex.Message.ToString, "Add Data Row")
        End Try



        'SavePLDataTableBin()
        Try
            Dim syncContext As SynchronizationContext = WindowsFormsSynchronizationContext.Current
            ' syncContext.Post(New Threading.SendOrPostCallback(Sub() UpdateData(c_PLDataList)), Nothing)

            syncContext.Post(New Threading.SendOrPostCallback(Sub() IReportCheck("PL-" & My.Settings.EquipmentNo)), Nothing)
        Catch ex As Exception

        End Try

        SetupAndStart(LotNo, OPNo)
        ' RaiseEvent E_Update_dgvProductionDetail("1666700", LotNo, "MECO-LotInfo_Rohm", "")
        c_MDIParent1.MDIUpdate_dgvProductionDetail("1666700", LotNo, "MECO-LotInfo_Rohm", "")
    End Sub

    Private Sub ProcessForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbMcNo.Text = My.Settings.EquipmentNo
        'PLDataBindingSource1.DataSource = c_PLDataList
        PLDataDataGridView.DataSource = c_PLDataList
        PLDataDataGridView.ClearSelection()
    End Sub
    'Private Delegate Sub UpdateDataDelegate(plDataList As List(Of PLData))
    'Private Sub UpdateData(plDataList As List(Of PLData))
    '    If Me.InvokeRequired Then
    '        Me.Invoke(New UpdateDataDelegate(AddressOf UpdateData), plDataList)
    '    Else
    '        'PLDataDataGridView.DataSource = GetType(List(Of PLData))
    '        'PLDataDataGridView.DataSource = plDataList.OrderBy(Function(x) x.LotStartTime).ToList

    '        'Dim binding As BindingList(Of PLData) = New BindingList(Of PLData)
    '        For Each data As PLData In plDataList.OrderBy(Function(x) x.LotStartTime).ToList
    '            c_binding.Add(data)
    '        Next
    '        PLDataDataGridView.DataSource = c_binding
    '        PLDataDataGridView.ClearSelection()

    '    End If


    'End Sub
    Private countTest As Integer
    Private Sub BtDeleteLot_Click(sender As Object, e As EventArgs) Handles btDeleteLot.Click
        Dim plData As PLData = New PLData()
        plData.LotNo = "Test" & countTest
        plData.LotStartTime = Now
        plData.GoodQty = 1000
        c_PLDataList.Add(plData)
        countTest += 1
        'UpdateData(c_PLDataList)
        'Me.Refresh()
    End Sub
    Private countClick As Integer


    Private Sub PLDataDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PLDataDataGridView.CellClick
        Dim dataGridview As DataGridView = CType(sender, DataGridView)
        Dim lotNo = dataGridview.Item(1, e.RowIndex).Value
        Debug.Print(countClick.ToString)
        Debug.Print("RowIndex:" & e.RowIndex & " ColumnIndex:" & e.ColumnIndex)
        countClick += 1
        If Not lotNo Is Nothing Then
            LabelIReportMessage.Text = lotNo.ToString
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim plData As PLData = New PLData()
        plData.LotNo = "Test" & countTest
        PLData.LotStartTime = Now
        PLData.GoodQty = 1000
        c_PLDataList.Add(PLData)
        countTest += 1

        For Each data As PLData In c_PLDataList
            data.GoodQty += 1
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Timer1.Start()
    End Sub

    Private Sub BtEndManual_Click(sender As Object, e As EventArgs) Handles btEndManual.Click
        Timer1.Stop()
    End Sub



End Class