Public Class AlarmData
    Private c_Id As Integer
    Public Property Id() As Integer
        Get
            Return c_Id
        End Get
        Set(ByVal value As Integer)
            c_Id = value
        End Set
    End Property
    Private c_RecordTime As DateTime?
    Public Property RecordTime() As DateTime?
        Get
            Return c_RecordTime
        End Get
        Set(ByVal value As DateTime?)
            c_RecordTime = value
        End Set
    End Property
    Private c_AlarmID As Integer
    Public Property AlarmID() As Integer
        Get
            Return c_AlarmID
        End Get
        Set(ByVal value As Integer)
            c_AlarmID = value
        End Set
    End Property
    Private c_LotNo As String
    Public Property LotNo() As String
        Get
            Return c_LotNo
        End Get
        Set(ByVal value As String)
            c_LotNo = value
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
    Private c_ClearTime As DateTime?
    Public Property ClearTime() As DateTime?
        Get
            Return c_ClearTime
        End Get
        Set(ByVal value As DateTime?)
            c_ClearTime = value
        End Set
    End Property
End Class
