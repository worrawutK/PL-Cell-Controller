Public Class PLAlarmInfo
    Private c_ID As Int32?

    Public Property ID As Int32?
        Get
            Return c_ID
        End Get
        Set(ByVal value As Int32?)
            c_ID = value
        End Set
    End Property

    Private c_RecordTime As DateTime?

    Public Property RecordTime As DateTime?
        Get
            Return c_RecordTime
        End Get
        Set(ByVal value As DateTime?)
            c_RecordTime = value
        End Set
    End Property

    Private c_AlarmID As Int32?

    Public Property AlarmID As Int32?
        Get
            Return c_AlarmID
        End Get
        Set(ByVal value As Int32?)
            c_AlarmID = value
        End Set
    End Property

    Private c_LotNo As String

    Public Property LotNo As String
        Get
            Return c_LotNo
        End Get
        Set(ByVal value As String)
            c_LotNo = value
        End Set
    End Property

    Private c_MCNo As String

    Public Property MCNo As String
        Get
            Return c_MCNo
        End Get
        Set(ByVal value As String)
            c_MCNo = value
        End Set
    End Property

    Private c_ClearTime As DateTime?

    Public Property ClearTime As DateTime?
        Get
            Return c_ClearTime
        End Get
        Set(ByVal value As DateTime?)
            c_ClearTime = value
        End Set
    End Property

    Private Sub Populate(ByVal row As DataRow)
        Me.ID = CType(row("ID"), Int32)
        Me.RecordTime = CType(row("RecordTime"), DateTime)
        Me.AlarmID = CType(row("AlarmID"), Int32)
        Me.LotNo = row("LotNo").ToString()
        Me.MCNo = row("MCNo").ToString()

        If Not Convert.IsDBNull(row("ClearTime")) Then
            Me.ClearTime = CType(row("ClearTime"), DateTime)
        End If
    End Sub

    Public Sub New(ByVal row As DataRow)
        Populate(row)
    End Sub

    Public Sub New()
    End Sub
End Class
