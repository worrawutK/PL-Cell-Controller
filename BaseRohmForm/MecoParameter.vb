Public Class MecoParameter

    Private _BarcodeIn As String
    Public Property BarcodeIn As String
        Get
            Return _BarcodeIn
        End Get
        Set(ByVal value As String)
            _BarcodeIn = value
        End Set
    End Property

    Private _BarcodeOut As String
    Public Property BarcodeOut As String
        Get
            Return _BarcodeOut
        End Get
        Set(ByVal value As String)
            _BarcodeOut = value
        End Set
    End Property

    Private _DeviceName As String
    Public Property DeviceName As String
        Get
            Return _DeviceName
        End Get
        Set(ByVal value As String)
            _DeviceName = value
        End Set
    End Property

    Private _LotInfo As String
    Public Property LotInfo As String
        Get
            Return _LotInfo
        End Get
        Set(ByVal value As String)
            _LotInfo = value
        End Set
    End Property

    Private _LotName As String
    Public Property LotName As String
        Get
            Return _LotInfo
        End Get
        Set(ByVal value As String)
            _LotInfo = value
        End Set
    End Property

    Private _Nmagazines As Integer
    Public Property Nmagazines As Integer
        Get
            Return _Nmagazines
        End Get
        Set(ByVal value As Integer)
            _Nmagazines = value
        End Set
    End Property

    Private _OperatorID As String
    Public Property OperatorID As String
        Get
            Return _OperatorID
        End Get
        Set(ByVal value As String)
            _OperatorID = value
        End Set
    End Property

    Private _ProductCountIn As Integer
    Public Property ProductCountIn As Integer
        Get
            Return _ProductCountIn
        End Get
        Set(ByVal value As Integer)
            _ProductCountIn = value
        End Set
    End Property

    Private _ProductCountOut As Integer
    Public Property ProductCountOut As Integer
        Get
            Return _ProductCountOut
        End Get
        Set(ByVal value As Integer)
            _ProductCountOut = value
        End Set
    End Property

    Private _ProductExpected As Integer
    Public Property ProductExpected As Integer
        Get
            Return _ProductExpected
        End Get
        Set(ByVal value As Integer)
            _ProductExpected = value
        End Set
    End Property

    Private _RecipeName As String
    Public Property RecipeName As String
        Get
            Return _RecipeName
        End Get
        Set(ByVal value As String)
            _RecipeName = value
        End Set
    End Property

    Private _TrayNumber As String
    Public Property TrayNumber As String
        Get
            Return _TrayNumber
        End Get
        Set(ByVal value As String)
            _TrayNumber = value
        End Set
    End Property

    Private _ProductCountTotalIn As Integer
    Public Property ProductCountTotalIn As Integer
        Get
            Return _ProductCountTotalIn
        End Get
        Set(ByVal value As Integer)
            _ProductCountTotalIn = value
        End Set
    End Property

    Private _ProductCountTotalOut As Integer
    Public Property ProductCountTotalOut As Integer
        Get
            Return _ProductCountTotalOut
        End Get
        Set(ByVal value As Integer)
            _ProductCountTotalOut = value
        End Set
    End Property

    Private _PreProcessState As Integer
    Public Property PreProcessState As Integer
        Get
            Return _PreProcessState
        End Get
        Set(ByVal value As Integer)
            _PreProcessState = value
        End Set
    End Property

    Private _ProcessState As Integer
    Public Property ProcessState As Integer
        Get
            Return _ProcessState
        End Get
        Set(ByVal value As Integer)
            _ProcessState = value
        End Set
    End Property
End Class
'37	MECO-PreviousProcessState
'38	MECO-ProcessState
'1665100	MECO-BarcodeIn
'1665200	MECO-BarcodeOut
'1665300	MECO-DeviceName
'1665400	MECO-LotInfo
'1665500	MECO-LotName
'1665800	MECO-Nmagazines
'1665900	MECO-OperatorID
'1666000	MECO-ProductCountIn
'1666100	MECO-ProductCountOut
'1666200	MECO-ProductExpected
'1666300	MECO-RecipeName
'1666400	MECO-TrayNumber
'1668600	MECO-ProductCountTotalIn
'1668700	MECO-ProductCountTotalOut
