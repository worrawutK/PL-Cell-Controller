﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1022
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("PL")>  _
        Public Property ProcessName() As String
            Get
                Return CType(Me("ProcessName"),String)
            End Get
            Set
                Me("ProcessName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("MECO")>  _
        Public Property MCType() As String
            Get
                Return CType(Me("MCType"),String)
            End Get
            Set
                Me("MCType") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10.28.41.32")>  _
        Public Property EquipmentIP() As String
            Get
                Return CType(Me("EquipmentIP"),String)
            End Get
            Set
                Me("EquipmentIP") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("M-00")>  _
        Public Property EquipmentNo() As String
            Get
                Return CType(Me("EquipmentNo"),String)
            End Get
            Set
                Me("EquipmentNo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=172.16.0.102;Initial Catalog=DBx;Persist Security Info=True;User ID=d"& _ 
            "bxuser")>  _
        Public Property DBConnSTR() As String
            Get
                Return CType(Me("DBConnSTR"),String)
            End Get
            Set
                Me("DBConnSTR") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SECS_nouse1() As Boolean
            Get
                Return CType(Me("SECS_nouse1"),Boolean)
            End Get
            Set
                Me("SECS_nouse1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5040")>  _
        Public Property SECS_PortNumber() As Integer
            Get
                Return CType(Me("SECS_PortNumber"),Integer)
            End Get
            Set
                Me("SECS_PortNumber") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SECS_Enable() As Boolean
            Get
                Return CType(Me("SECS_Enable"),Boolean)
            End Get
            Set
                Me("SECS_Enable") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SECS_Nouse2() As Boolean
            Get
                Return CType(Me("SECS_Nouse2"),Boolean)
            End Get
            Set
                Me("SECS_Nouse2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property GEM_DeviceID() As UShort
            Get
                Return CType(Me("GEM_DeviceID"),UShort)
            End Get
            Set
                Me("GEM_DeviceID") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("45")>  _
        Public Property GEM_T3_Interval() As Integer
            Get
                Return CType(Me("GEM_T3_Interval"),Integer)
            End Get
            Set
                Me("GEM_T3_Interval") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public Property GEM_T5_Interval() As Integer
            Get
                Return CType(Me("GEM_T5_Interval"),Integer)
            End Get
            Set
                Me("GEM_T5_Interval") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("20")>  _
        Public Property GEM_T6_Interval() As Integer
            Get
                Return CType(Me("GEM_T6_Interval"),Integer)
            End Get
            Set
                Me("GEM_T6_Interval") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public Property GEM_T7_Interval() As Integer
            Get
                Return CType(Me("GEM_T7_Interval"),Integer)
            End Get
            Set
                Me("GEM_T7_Interval") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("20")>  _
        Public Property GEM_LinkTest_Interval() As Integer
            Get
                Return CType(Me("GEM_LinkTest_Interval"),Integer)
            End Get
            Set
                Me("GEM_LinkTest_Interval") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property GEM_LinkTest_Enabled() As Boolean
            Get
                Return CType(Me("GEM_LinkTest_Enabled"),Boolean)
            End Get
            Set
                Me("GEM_LinkTest_Enabled") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property TDC_Enable() As Boolean
            Get
                Return CType(Me("TDC_Enable"),Boolean)
            End Get
            Set
                Me("TDC_Enable") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property CsProtocol_Enable() As Boolean
            Get
                Return CType(Me("CsProtocol_Enable"),Boolean)
            End Get
            Set
                Me("CsProtocol_Enable") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5040")>  _
        Public Property CsProtocolPort() As Integer
            Get
                Return CType(Me("CsProtocolPort"),Integer)
            End Get
            Set
                Me("CsProtocolPort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("PL-OP")>  _
        Public Property UserAuthenOP() As String
            Get
                Return CType(Me("UserAuthenOP"),String)
            End Get
            Set
                Me("UserAuthenOP") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("PL-GL")>  _
        Public Property UserAuthenGL() As String
            Get
                Return CType(Me("UserAuthenGL"),String)
            End Get
            Set
                Me("UserAuthenGL") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("admin")>  _
        Public Property UserAdminPass() As String
            Get
                Return CType(Me("UserAdminPass"),String)
            End Get
            Set
                Me("UserAdminPass") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=172.16.0.102;Initial Catalog=DBx;User ID=dbxuser")>  _
        Public ReadOnly Property DBxConnectionString() As String
            Get
                Return CType(Me("DBxConnectionString"),String)
            End Get
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.CellController.My.MySettings
            Get
                Return Global.CellController.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
