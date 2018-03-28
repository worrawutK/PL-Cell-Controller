#Region "Status variables"

Public Enum ControlStateType As Byte
    OFFLINE = 0
    ONLINE_LOCAL = 1
    ONLINE_REMOTE = 2
    EQUIPMENT_OFFLINE = 3
    HOST_OFFLINE = 4
End Enum

Public Enum EquipmentState As Byte
    [None] = 0 ' i added this by myself 2015-07-02
    AutoStart = 1
    AutoStop = 2
    ManualStart = 3
    ManualStop = 4
    AlarmStop = 5
    WaitingHostAnswer = 6
    PreventiveMaintenance = 7
    ScheduledDown = 8
    UnscheduledDown = 9
    Engineering = 10
    Productive = 11
    Standby = 12
End Enum

#End Region


Public Enum DoorState As Byte
    [None] = 0
    [Locked] = 1
    [Unlocked] = 2
End Enum


Public Enum HCACK As Byte
    '''0 - ok, completed
    OK = 0

    '''1 - invalid command
    InvalidCommand = 1

    '''2 - cannot do now
    CannotDoNow = 2

    '''3 - parameter error
    ParameterError = 3

    '''4 - initiated for asynchronous completion
    InitiatedForAsynCompletion = 4

    '''5 - rejected, already in desired condition
    RejectedAlreadyInDesired = 5

    '''6 - invalid object
    InvalidObject = 6

End Enum

Public Enum DRACK As Byte

    ''' <summary>
    ''' 0 - ok
    ''' </summary>
    ''' <remarks></remarks>
    OK = 0

    ''' <summary>
    ''' 1 - out of space
    ''' </summary>
    ''' <remarks></remarks>
    OutOfSpace = 1

    ''' <summary>
    ''' 2 - invalid format
    ''' </summary>
    ''' <remarks></remarks>
    InvalidFormat = 2

    ''' <summary>
    ''' 3 - 1 or more RPTID already defined
    ''' </summary>
    ''' <remarks></remarks>
    OneOrMoreRptidAlreadyDefined = 3

    ''' <summary>
    ''' '4 - 1 or more invalid VID
    ''' </summary>
    ''' <remarks></remarks>
    OneOrMoreInvalidVid = 4

End Enum




Public Enum LRACK As Byte

    ''' <summary>
    ''' 0 - ok
    ''' </summary>
    ''' <remarks></remarks>
    OK = 0

    ''' <summary>
    ''' 1 - out of space
    ''' </summary>
    ''' <remarks></remarks>
    OutOfSpace = 1

    ''' <summary>
    ''' 2 - invalid format
    ''' </summary>
    ''' <remarks></remarks>
    InvalidFormat = 2

    ''' <summary>
    ''' 3 - 1 or more CEID links already defined
    ''' </summary>
    ''' <remarks></remarks>
    OneOrMoreCeidLinksAlreadyDefined = 3

    ''' <summary>
    ''' 4 - 1 or more CEID invalid
    ''' </summary>
    ''' <remarks></remarks>
    OneOrMoreCeidInvalid = 4

    ''' <summary>
    ''' 5 - 1 or more RPTID invalid
    ''' </summary>
    ''' <remarks></remarks>
    OneOrMoreRptidInvalid = 5
End Enum

Public Enum ERACK As Byte

    ''' <summary>
    ''' '0 - ok
    ''' </summary>
    ''' <remarks></remarks>
    OK = 0

    ''' <summary>
    ''' 1 - denied
    ''' </summary>
    ''' <remarks></remarks>
    Denied = 1

End Enum

Public Enum TimeFormat
    A12 = 0
    A16 = 1
    An = 2
End Enum

Public Enum COMMACK As Byte
    OK = 0
    DENIED = 1
End Enum
Public Enum EAC As Byte
    OK = 0
    OneOrMoreConstantsDoesNotExist = 1
    BUSY = 2
    OneOrMoreValuesOutOfRange = 3
End Enum
Public Enum ACKC10 As Byte
    Accepted = 0
    MessageWillNotBeDisplayed = 1
    TerminalNotAvailable = 2

End Enum
Public Enum ACKC5 As Byte
   OK = 0
    DENIED = 1

End Enum

Public Enum SpoolCode As Byte
    Transmit
    Purge
End Enum
Public Enum RSDA As Byte
    ok
    RetryableBusy
    NoSpoolData

End Enum
Public Enum ONLACK As Byte
    Ok
    Refused
    AlreadyOnline

End Enum