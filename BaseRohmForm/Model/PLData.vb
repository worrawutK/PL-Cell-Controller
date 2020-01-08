Imports System.ComponentModel

Public Class PLData
    Implements INotifyPropertyChanged
    Private c_McNo As String
    Public Property McNo() As String
        Get
            Return c_McNo
        End Get
        Set(ByVal value As String)
            c_McNo = value
            ReportPeropertyChanged("McNo")
        End Set
    End Property
    Private c_LotNo As String
    Public Property LotNo() As String
        Get
            Return c_LotNo
        End Get
        Set(ByVal value As String)
            c_LotNo = value
            ReportPeropertyChanged("LotNo")
        End Set
    End Property
    Private c_LotStartTime As DateTime?
    Public Property LotStartTime() As DateTime?
        Get
            Return c_LotStartTime
        End Get
        Set(ByVal value As DateTime?)
            c_LotStartTime = value
            ReportPeropertyChanged("LotStartTime")
        End Set
    End Property

    Private c_OpNo As String
    Public Property OpNo() As String
        Get
            Return c_OpNo
        End Get
        Set(ByVal value As String)
            c_OpNo = value
            ReportPeropertyChanged("OpNo")
        End Set
    End Property
    Private c_InputQty As Integer
    Public Property InputQty() As Integer
        Get
            Return c_InputQty
        End Get
        Set(ByVal value As Integer)
            c_InputQty = value
            ReportPeropertyChanged("InputQty")
        End Set
    End Property
    Private c_GoodQty As Integer
    Public Property GoodQty() As Integer
        Get
            Return c_GoodQty
        End Get
        Set(ByVal value As Integer)
            c_GoodQty = value
            ReportPeropertyChanged("GoodQty")
        End Set
    End Property
    Private c_LotEndTime As DateTime?
    Public Property LotEndTime() As DateTime?
        Get
            Return c_LotEndTime
        End Get
        Set(ByVal value As DateTime?)
            c_LotEndTime = value
            ReportPeropertyChanged("LotEndTime")
        End Set
    End Property
    Private c_MagazineNo As String
    Public Property MagazineNo() As String
        Get
            Return c_MagazineNo
        End Get
        Set(ByVal value As String)
            c_MagazineNo = value
            ReportPeropertyChanged("MagazineNo")
        End Set
    End Property
    Private c_Package As String
    Public Property Package() As String
        Get
            Return c_Package
        End Get
        Set(ByVal value As String)
            c_Package = value
            ReportPeropertyChanged("Package")
        End Set
    End Property
    Private c_Device As String
    Public Property Device() As String
        Get
            Return c_Device
        End Get
        Set(ByVal value As String)
            c_Device = value
            ReportPeropertyChanged("Device")
        End Set
    End Property
    Private c_FrameInput As Integer
    Public Property FrameInput() As Integer
        Get
            Return c_FrameInput
        End Get
        Set(ByVal value As Integer)
            c_FrameInput = value
            ReportPeropertyChanged("FrameInput")
        End Set
    End Property
    Private c_FrameOutput As Integer
    Public Property FrameOutput() As Integer
        Get
            Return c_FrameOutput
        End Get
        Set(ByVal value As Integer)
            c_FrameOutput = value
            ReportPeropertyChanged("FrameOutput")
        End Set
    End Property
    Private c_DummyFrame As Integer
    Public Property DummyFrame() As Integer
        Get
            Return c_DummyFrame
        End Get
        Set(ByVal value As Integer)
            c_DummyFrame = value
            ReportPeropertyChanged("DummyFrame")
        End Set
    End Property
    Private c_OpNoJudgement As String
    Public Property OpNoJudgement() As String
        Get
            Return c_OpNoJudgement
        End Get
        Set(ByVal value As String)
            c_OpNoJudgement = value
            ReportPeropertyChanged("OpNoJudgement")
        End Set
    End Property

    Private c_Recipe As String
    Public Property Recipe() As String
        Get
            Return c_Recipe
        End Get
        Set(ByVal value As String)
            c_Recipe = value
            ReportPeropertyChanged("Recipe")
        End Set
    End Property
    Private c_NetVersion As String
    Public Property NetVersion() As String
        Get
            Return c_NetVersion
        End Get
        Set(ByVal value As String)
            c_NetVersion = value
            ReportPeropertyChanged("NetVersion")
        End Set
    End Property
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Public Sub ReportPeropertyChanged(propName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propName))
    End Sub
End Class
