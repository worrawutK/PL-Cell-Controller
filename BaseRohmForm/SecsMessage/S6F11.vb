Imports XtraLibrary.SecsGem

Public Class S6F11
    Inherits SecsMessageBase

    Private m_L3 As SecsItemList
    Private m_DATAID As SecsItemU4
    Private m_CEID As SecsItemU4
    Private m_La As SecsItemList

    Public Sub New()
        MyBase.New(6, 11, True)

        m_L3 = New SecsItemList("L3")
        Me.AddItem(m_L3)

        m_DATAID = New SecsItemU4("DATAID")
        m_L3.AddItem(m_DATAID)

        m_CEID = New SecsItemU4("CEID")
        m_L3.AddItem(m_CEID)

        'La contains L2 and L2 contain "Report "
        'and "List of SV value mapped to Defined report"
        m_La = New SecsItemList("La")
        m_L3.AddItem(m_La)

    End Sub

    Public ReadOnly Property CEID() As UInt32
        Get
            Return m_CEID.Value(0)
        End Get
    End Property


    Public Sub ApplyStatusVariableValue(ByVal eq As Equipment, ByVal reportDic As Dictionary(Of UInt32, DefinedReport))

        Dim secsItem_Lb As SecsItemList

        Dim reportID As UInt32
        Dim definedReport As DefinedReport

        Dim secsItem_V As SecsItem
        Try

       
        For Each l2 As SecsItemList In m_La.Value

            reportID = CType(l2.Value(0), SecsItemU4).Value(0)

            If reportDic.ContainsKey(reportID) Then
                'get DefinedReport object from dictionary
                definedReport = reportDic(reportID)

                secsItem_Lb = CType(l2.Value(1), SecsItemList)
                For i As Integer = 0 To secsItem_Lb.Value.Count - 1

                    secsItem_V = secsItem_Lb.Value(i)
                        Select Case definedReport.SVIDList(i)
                            Case 37 'MECO-PreviousProcessState
                                m_SelfData.PreProcessState = CInt(CType(secsItem_V, SecsItemU1).Value(0))
                            Case 38 'MECO-ProcessState
                                m_SelfData.ProcessState = CInt(CType(secsItem_V, SecsItemU1).Value(0))
                            Case 1665100 'MECO-BarcodeIn
                                m_SelfData.BarcodeIn = CType(secsItem_V.Value, String)
                            Case 1665200 'MECO-BarcodeOut
                                m_SelfData.BarcodeOut = CType(secsItem_V.Value, String)
                            Case 1665300 'MECO-DeviceName
                                m_SelfData.DeviceName = CType(secsItem_V.Value, String)
                            Case 1665400 'MECO-LotInfo
                                m_SelfData.LotInfo = CType(secsItem_V.Value, String)
                            Case 1665500 'MECO-LotName
                                Try
                                    m_SelfData.LotName = CType(secsItem_V.Value, String)
                                Catch ex As Exception
                                    SaveCatchLog(ex.ToString & " " & CType(secsItem_V.Value, String), "MECO-LotName")
                                End Try
                                'Dim strLotNo As String = CType(secsItem_V.Value, String).Substring(0, 10)
                                'If strLotNo.Length > 10 Then
                                '    m_SelfData.LotName = CType(secsItem_V.Value, String).Substring(0, 10)
                                'Else
                                '    m_SelfData.LotName = CType(secsItem_V.Value, String)
                                'End If
                            Case 1665800 'MECO-Nmagazine
                                m_SelfData.Nmagazines = CInt(CType(secsItem_V, SecsItemI4).Value(0))
                            Case 1665900 'MECO-OPNo
                                m_SelfData.OperatorID = CType(secsItem_V.Value, String)
                            Case 1666000 'MECO-ProductCountIn
                                m_SelfData.ProductCountIn = CInt(CType(secsItem_V, SecsItemI4).Value(0))
                            Case 1666100 'MECO-ProductCountOut
                                m_SelfData.ProductCountOut = CInt(CType(secsItem_V, SecsItemI4).Value(0))
                            Case 1666200 'MECO-ProductExpected
                                m_SelfData.ProductExpected = CInt(CType(secsItem_V, SecsItemI4).Value(0))
                            Case 1666300 'MECO-RecipeName
                                m_SelfData.RecipeName = CType(secsItem_V.Value, String)
                            Case 1666400 'MECO-TrayNumber 
                                m_SelfData.TrayNumber = CType(secsItem_V.Value, String)
                            Case 1668600 'MECO-ProductCountTotalIn
                                m_SelfData.ProductCountTotalIn = CInt(CType(secsItem_V, SecsItemI4).Value(0))
                            Case 1668700 'MECO-ProductCountTotalOut
                                m_SelfData.ProductCountTotalOut = CInt(CType(secsItem_V, SecsItemI4).Value(0))
                        End Select
                Next
            End If
        Next
        Catch ex As Exception
            SaveCatchLog(ex.ToString, "ApplyStatusVariableValue()")
        End Try
    End Sub

End Class
