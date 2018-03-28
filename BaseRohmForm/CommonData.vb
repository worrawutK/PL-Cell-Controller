Public Class CommonData
    Public Enum Level
        OP
        ADMIN
    End Enum
    Private _OPID As String
    Public Property OPID() As String
        Get
            Return _OPID
        End Get
        Set(ByVal value As String)
            _OPID = value

        End Set
    End Property

    Private _UserID As String
    Public Property UserID() As String
        Get
            Return _UserID
        End Get
        Set(ByVal value As String)
            _UserID = value

        End Set
    End Property
    Private _UserLoginResult As Boolean
    Public Property UserLoginResult() As Boolean
        Get
            Return _UserLoginResult
        End Get
        Set(ByVal value As Boolean)
            _UserLoginResult = value

        End Set
    End Property

    Private _UserLevel As Level
    Public Property UserLevel() As Level
        Get
            Return _UserLevel
        End Get
        Set(ByVal value As Level)
            _UserLevel = value

        End Set
    End Property
    Private _QrData As String
    Public Property QrData() As String
        Get
            Return _QrData
        End Get
        Set(ByVal value As String)
            _QrData = value

        End Set
    End Property

    Private _AutoMotiveLot As Boolean
    Public Property AutoMotiveLot() As Boolean
        Get
            Return _AutoMotiveLot
        End Get
        Set(ByVal value As Boolean)
            _AutoMotiveLot = value

        End Set
    End Property

    Private _CSConnect As String
    Public Property CSConnect() As String
        Get
            Return _CSConnect
        End Get
        Set(ByVal value As String)
            _CSConnect = value

        End Set
    End Property
    Private _FRMProductAlive As Boolean
    Public Property FRMProductAlive() As Boolean
        Get
            Return _FRMProductAlive
        End Get
        Set(ByVal value As Boolean)
            _FRMProductAlive = value

        End Set
    End Property
    Private _AlrmtimerCount As Integer
    Public Property AlrmtimerCount() As Integer
        Get
            Return _AlrmtimerCount
        End Get
        Set(ByVal value As Integer)
            _AlrmtimerCount = value

        End Set
    End Property

End Class
