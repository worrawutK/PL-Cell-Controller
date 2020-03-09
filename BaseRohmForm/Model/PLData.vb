Imports System.ComponentModel

Public Class PLData
    Implements INotifyPropertyChanged

    Private c_MCNo As String

    Public Property MCNo As String
        Get
            Return c_MCNo
        End Get
        Set(ByVal value As String)
            c_MCNo = value
            ReportPeropertyChanged("MCNo")
        End Set
    End Property

    Private c_LotNo As String

    Public Property LotNo As String
        Get
            Return c_LotNo
        End Get
        Set(ByVal value As String)
            c_LotNo = value
            ReportPeropertyChanged("LotNo")
        End Set
    End Property

    Private c_LotStartTime As DateTime?

    Public Property LotStartTime As DateTime?
        Get
            Return c_LotStartTime
        End Get
        Set(ByVal value As DateTime?)
            c_LotStartTime = value
            ReportPeropertyChanged("LotStartTime")
        End Set
    End Property

    Private c_LotEndTime As DateTime?

    Public Property LotEndTime As DateTime?
        Get
            Return c_LotEndTime
        End Get
        Set(ByVal value As DateTime?)
            c_LotEndTime = value
            ReportPeropertyChanged("LotEndTime")
        End Set
    End Property

    Private c_Material As String

    Public Property Material As String
        Get
            Return c_Material
        End Get
        Set(ByVal value As String)
            c_Material = value
            ReportPeropertyChanged("Material")
        End Set
    End Property

    Private c_ABNormal As String

    Public Property ABNormal As String
        Get
            Return c_ABNormal
        End Get
        Set(ByVal value As String)
            c_ABNormal = value
            ReportPeropertyChanged("ABNormal")
        End Set
    End Property

    Private c_LoadCount As Int32?

    Public Property LoadCount As Int32?
        Get
            Return c_LoadCount
        End Get
        Set(ByVal value As Int32?)
            c_LoadCount = value
            ReportPeropertyChanged("LoadCount")
        End Set
    End Property

    Private c_UnloadCount As Int32?

    Public Property UnloadCount As Int32?
        Get
            Return c_UnloadCount
        End Get
        Set(ByVal value As Int32?)
            c_UnloadCount = value
            ReportPeropertyChanged("UnloadCount")
        End Set
    End Property

    Private c_OPNo As String

    Public Property OPNo As String
        Get
            Return c_OPNo
        End Get
        Set(ByVal value As String)
            c_OPNo = value
            ReportPeropertyChanged("OPNo")
        End Set
    End Property

    Private c_MagazineNo As String

    Public Property MagazineNo As String
        Get
            Return c_MagazineNo
        End Get
        Set(ByVal value As String)
            c_MagazineNo = value
            ReportPeropertyChanged("MagazineNo")
        End Set
    End Property

    Private c_SelfConVersion As String

    Public Property SelfConVersion As String
        Get
            Return c_SelfConVersion
        End Get
        Set(ByVal value As String)
            c_SelfConVersion = value
            ReportPeropertyChanged("SelfConVersion")
        End Set
    End Property

    Private c_NetVersion As String

    Public Property NetVersion As String
        Get
            Return c_NetVersion
        End Get
        Set(ByVal value As String)
            c_NetVersion = value
            ReportPeropertyChanged("NetVersion")
        End Set
    End Property

    Private c_InputQtyAdjust As Int32?

    Public Property InputQtyAdjust As Int32?
        Get
            Return c_InputQtyAdjust
        End Get
        Set(ByVal value As Int32?)
            c_InputQtyAdjust = value
            ReportPeropertyChanged("InputQtyAdjust")
        End Set
    End Property

    Private c_TotalGoodAdjust As Int32?

    Public Property TotalGoodAdjust As Int32?
        Get
            Return c_TotalGoodAdjust
        End Get
        Set(ByVal value As Int32?)
            c_TotalGoodAdjust = value
            ReportPeropertyChanged("TotalGoodAdjust")
        End Set
    End Property

    Private c_TotalNGAdjust As Int32?

    Public Property TotalNGAdjust As Int32?
        Get
            Return c_TotalNGAdjust
        End Get
        Set(ByVal value As Int32?)
            c_TotalNGAdjust = value
            ReportPeropertyChanged("TotalNGAdjust")
        End Set
    End Property

    Private c_DummyQty As Int32?

    Public Property DummyQty As Int32?
        Get
            Return c_DummyQty
        End Get
        Set(ByVal value As Int32?)
            c_DummyQty = value
            ReportPeropertyChanged("DummyQty")
        End Set
    End Property

    Private c_OPJudgement As String

    Public Property OPJudgement As String
        Get
            Return c_OPJudgement
        End Get
        Set(ByVal value As String)
            c_OPJudgement = value
            ReportPeropertyChanged("OPJudgement")
        End Set
    End Property

    Private c_Remark As String

    Public Property Remark As String
        Get
            Return c_Remark
        End Get
        Set(ByVal value As String)
            c_Remark = value
            ReportPeropertyChanged("Remark")
        End Set
    End Property

    Private c_InputQtyFrameAdjust As Int32?

    Public Property InputQtyFrameAdjust As Int32?
        Get
            Return c_InputQtyFrameAdjust
        End Get
        Set(ByVal value As Int32?)
            c_InputQtyFrameAdjust = value
            ReportPeropertyChanged("InputQtyFrameAdjust")
        End Set
    End Property

    Private c_TotalGoodFrameAdjust As Int32?

    Public Property TotalGoodFrameAdjust As Int32?
        Get
            Return c_TotalGoodFrameAdjust
        End Get
        Set(ByVal value As Int32?)
            c_TotalGoodFrameAdjust = value
            ReportPeropertyChanged("TotalGoodFrameAdjust")
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Public Sub ReportPeropertyChanged(propName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propName))
    End Sub
End Class
