Imports Rohm.Apcs.Tdc

Public Class TdcData
    Private c_LotNo As String
    Public Property LotNo() As String
        Get
            Return c_LotNo
        End Get
        Set(ByVal value As String)
            c_LotNo = value
        End Set
    End Property
    Private c_LotStartTime As Date
    Public Property LotStartTime() As Date
        Get
            Return c_LotStartTime
        End Get
        Set(ByVal value As Date)
            c_LotStartTime = value
        End Set
    End Property
    Private c_LotEndTime As Date
    Public Property LotEndTime() As Date
        Get
            Return c_LotEndTime
        End Get
        Set(ByVal value As Date)
            c_LotEndTime = value
        End Set
    End Property
    Private c_GoodPcs As Integer
    Public Property GoodPcs() As Integer
        Get
            Return c_GoodPcs
        End Get
        Set(ByVal value As Integer)
            c_GoodPcs = value
        End Set
    End Property
    Private c_NgPcs As Integer
    Public Property NgPcs() As Integer
        Get
            Return c_NgPcs
        End Get
        Set(ByVal value As Integer)
            c_NgPcs = value
        End Set
    End Property
    Private c_TdcStartMode As RunModeType
    Public Property TdcStartMode() As RunModeType
        Get
            Return c_TdcStartMode
        End Get
        Set(ByVal value As RunModeType)
            c_TdcStartMode = value
        End Set
    End Property
    Private c_TdcEndMode As EndModeType
    Public Property TdcEndMode() As EndModeType
        Get
            Return c_TdcEndMode
        End Get
        Set(ByVal value As EndModeType)
            c_TdcEndMode = value
        End Set
    End Property
    Private c_McNo As String
    Public Property McNo() As String
        Get
            Return c_McNo
        End Get
        Set(ByVal value As String)
            c_McNo = value
        End Set
    End Property
    Private c_OpNo As String
    Public Property OpNo() As String
        Get
            Return c_OpNo
        End Get
        Set(ByVal value As String)
            c_OpNo = value
        End Set
    End Property
    Private c_PLDataRow As DBxDataSet.PLDataRow
    Public Property PLDataRow() As DBxDataSet.PLDataRow
        Get
            Return c_PLDataRow
        End Get
        Set(ByVal value As DBxDataSet.PLDataRow)
            c_PLDataRow = value
        End Set
    End Property
End Class
