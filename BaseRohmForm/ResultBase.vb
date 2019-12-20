Public Class GetPerFrameResult
    Private c_IsPass As Boolean
    Public Property IsPass() As Boolean
        Get
            Return c_IsPass
        End Get
        Set(ByVal value As Boolean)
            c_IsPass = value
        End Set
    End Property
    Private c_Reson As String
    Public Property Reson() As String
        Get
            Return c_Reson
        End Get
        Set(ByVal value As String)
            c_Reson = value
        End Set
    End Property
    Private c_PerFrame As Integer
    Public Property PerFrame() As Integer
        Get
            Return c_PerFrame
        End Get
        Set(ByVal value As Integer)
            c_PerFrame = value
        End Set
    End Property
    Private c_Package As String
    Public Property Package() As String
        Get
            Return c_Package
        End Get
        Set(ByVal value As String)
            c_Package = value
        End Set
    End Property
End Class
