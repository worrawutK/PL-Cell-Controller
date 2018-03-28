<Serializable()> _
Public Class ChemicalDeflash

    Private _MCNo As String
    Public Property MCNo() As String
        Get
            Return _MCNo
        End Get
        Set(ByVal value As String)
            _MCNo = value
        End Set
    End Property

    Private _SubMCNo As String
    Public Property SubMCNo() As String
        Get
            Return _SubMCNo
        End Get
        Set(ByVal value As String)

            _SubMCNo = value
        End Set
    End Property

    Private _QRData As String
    Public Property QRData() As String
        Get
            Return _QRData
        End Get
        Set(ByVal value As String)
            _QRData = value
        End Set
    End Property

    Private _LotID As String
    Public Property LotID() As String
        Get
            Return _LotID
        End Get
        Set(ByVal value As String)
            _LotID = value
        End Set
    End Property


    Private _Package As String
    Public Property Package() As String
        Get
            Return _Package
        End Get
        Set(ByVal value As String)
            _Package = value
        End Set
    End Property

    Private _DeviceName As String
    Public Property DeviceName() As String
        Get
            Return _DeviceName
        End Get
        Set(ByVal value As String)
            _DeviceName = value
        End Set
    End Property


    Private _RecipeName As String
    Public Property RecipeName() As String
        Get
            Return _RecipeName
        End Get
        Set(ByVal value As String)

            _RecipeName = value
        End Set
    End Property

    Private _OPID As String
    Public Property OPID() As String
        Get
            Return _OPID
        End Get
        Set(ByVal value As String)
            _OPID = value
        End Set
    End Property
    Private _INPUTQty As String
    Public Property INPUTQty() As String
        Get
            Return _INPUTQty
        End Get
        Set(ByVal value As String)
            _INPUTQty = value
        End Set
    End Property

    Private _GoodPcs As String
    Public Property GoodPcs() As String
        Get
            Return _GoodPcs
        End Get
        Set(ByVal value As String)
            _GoodPcs = value
        End Set
    End Property

    Private _NGPcs As String
    Public Property NGPcs() As String
        Get
            Return _NGPcs
        End Get
        Set(ByVal value As String)
            _NGPcs = value
        End Set
    End Property

    Private _MagazineNo As String
    Public Property MagazineNo() As String
        Get
            Return _MagazineNo
        End Get
        Set(ByVal value As String)
            _MagazineNo = value
        End Set
    End Property

    Private _LotStartTime As String
    Public Property LotStartTime() As String
        Get
            Return _LotStartTime
        End Get
        Set(ByVal value As String)
            _LotStartTime = value
        End Set
    End Property

    Private _LotEndTime As String
    Public Property LotEndTime() As String
        Get
            Return _LotEndTime
        End Get
        Set(ByVal value As String)
            _LotEndTime = value
        End Set
    End Property

    Private _LRStatus As String
    Public Property LRStatus() As String
        Get
            Return _LRStatus
        End Get
        Set(ByVal value As String)
            _LRStatus = value
        End Set
    End Property

    Private _LSStatus As String
    Public Property LSStatus() As String
        Get
            Return _LSStatus
        End Get
        Set(ByVal value As String)
            _LSStatus = value
        End Set
    End Property

    Private _LEStatus As String
    Public Property LEStatus() As String
        Get
            Return _LEStatus
        End Get
        Set(ByVal value As String)
            _LEStatus = value
        End Set
    End Property

End Class
