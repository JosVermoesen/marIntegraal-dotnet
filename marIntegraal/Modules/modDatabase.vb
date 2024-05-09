Option Strict Off
Option Explicit On
Imports System.Data.OleDb

Module modDatabase

    Dim X As Short

    <Runtime.CompilerServices.Extension()>
    Public Function ADODBRSetToDataTable(ByVal adodbRecordSet As ADODB.Recordset) As DataTable
        Dim dataAdapter As New OleDbDataAdapter()
        Dim dt As New DataTable()
        dataAdapter.Fill(dt, adodbRecordSet)
        Return dt
    End Function

    Public Function OpenSchemaString(objectType As String) As String

        Dim cnn As New OleDb.OleDbConnection With {
            .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; data source =" + LOCATION_COMPANYDATA + "\marnt.mdv"
        }

        ' We only want user tables, not system tables
        Dim restrictions() As String = New String(3) {}
        restrictions(3) = objectType

        cnn.Open()
        ' Get list of user tables
        Dim userTables As DataTable = cnn.GetSchema("Tables", restrictions)
        cnn.Close()
        Dim returnString As String = ""

        ' Add list of table names to ListBox
        Dim i As Integer
        For i = 0 To userTables.Rows.Count - 1
            returnString = returnString + userTables.Rows(i)(2).ToString() + vbCr
        Next
        Return returnString

    End Function

    Sub TransBegin()

        On Error Resume Next
        Err.Clear()
        'NT_SPACE.BeginTrans
        AD_NTDB.BeginTrans()
        KTRL = Err.Number
        If Err.Number Then
            MsgBox(ErrorToString())
        End If

    End Sub

    Sub TransCommit()

        On Error Resume Next
        AD_NTDB.CommitTrans()
        KTRL = Err.Number
        If Err.Number Then
            MsgBox(ErrorToString())
        End If

    End Sub

    Sub TransAbort()

        On Error Resume Next
        Err.Clear()
        'NT_SPACE.Rollback
        AD_NTDB.RollbackTrans()
        KTRL = Err.Number
        If Err.Number Then
            MsgBox(ErrorToString())
        End If

    End Sub

    Function AdoNewRecord(ByRef Fl As Integer) As Boolean

        TLB_RECORD(Fl) = ""
        Select Case Fl
            Case TABLE_CUSTOMERS, TABLE_SUPPLIERS
                AdoInsertToRecord(Fl, "2", "A10C") 'Taalkode
                AdoInsertToRecord(Fl, "002", "v149") 'Landnummer  ISO kode
                AdoInsertToRecord(Fl, "B  ", "A109") 'Landkode Postkantoor
                AdoInsertToRecord(Fl, "BE", "v150") 'Landkode    ISO kode
                'If BH_EURO Then
                AdoInsertToRecord(Fl, "EUR", "vs03") 'Munteenheid ISO kode
                'Else
                'AdoInsertToRecord(FL, "BEF", "vs03") 'Munteenheid ISO kode
                'End If
                AdoInsertToRecord(Fl, "1", "vs07") 'exemplaren dokumenten
            Case TABLE_LEDGERACCOUNTS
                AdoInsertToRecord(Fl, "O", "v032") 'Budgetcode
        End Select
        Return True

    End Function

    Function SetSpacing(ByRef fTekst As String, ByRef fLengte As Short) As String
        Dim b As String

        b = Left(fTekst, fLengte)
        SetSpacing = b & Space(fLengte - Len(b))

    End Function

    Sub AdoInsertToRecord(ByRef Fl As Short, ByRef FieldString1 As String, ByRef FieldString2 As String)
        Dim TBLen As Short
        Dim TBStart As Short
        Dim TBStop As Short
        Dim TBCode As String

        TBCode = "#     #"
        Mid(TBCode, 2, 5) = FieldString2

        If FieldString1 = "" Then
            FieldString1 = " "
        End If

jump:
        If InStr(TLB_RECORD(Fl), TBCode) = 0 Then
            TLB_RECORD(Fl) = TLB_RECORD(Fl) & TBCode & FieldString1 & "#"
        Else
            If RTrim(AdoGetField(Fl, TBCode)) = FieldString1 Then
                Exit Sub
            Else
                TBLen = Len(TLB_RECORD(Fl))
                TBStart = InStr(TLB_RECORD(Fl), TBCode)
                TBStop = InStr(TBStart + 7, TLB_RECORD(Fl), "#")
                TLB_RECORD(Fl) = Left(TLB_RECORD(Fl), TBStart - 1) & Right(TLB_RECORD(Fl), TBLen - TBStop)
                GoTo jump
            End If
        End If

    End Sub

    Function AdoGetField(ByRef Fl As Short, ByRef TBS As String) As String

        Dim tbsHere As String = ""
        If Mid(TBS, 1, 1) = "#" And Len(TBS) = 7 Then
            tbsHere = TBS
        ElseIf Len(TBS) = 6 Then
            tbsHere = "#     #"
            Mid(tbsHere, 2) = Mid(TBS, 2, 4)
        Else
            Stop
        End If
        Err.Clear()
        On Error Resume Next
        If TLB_RECORD(Fl) = "" Then
            AdoGetField = ""
        Else
            AdoGetField = Mid(TLB_RECORD(Fl), InStr(TLB_RECORD(Fl), tbsHere) + 7, InStr(InStr(TLB_RECORD(Fl), tbsHere) + 7, TLB_RECORD(Fl), "#") - (InStr(TLB_RECORD(Fl), tbsHere) + 7))
        End If
        If Err.Number Then AdoGetField = ""

    End Function

    Function XrsMar(ByRef Fl As Short, ByRef TBS As String) As Object

        'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If IsDBNull(RS_MAR(Fl).Fields(TBS).Value) Or IsNothing(RS_MAR(Fl).Fields(TBS).Value) Then
            'UPGRADE_WARNING: Couldn't resolve default property of object XrsMar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            XrsMar = ""
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object XrsMar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            XrsMar = RS_MAR(Fl).Fields(TBS).Value
        End If

    End Function

    Function ObjectValue(ByRef dbWaarde As Object) As Object

        'On Error Resume Next
        'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        If IsDBNull(dbWaarde) Or IsNothing(dbWaarde) Then
            'UPGRADE_WARNING: Couldn't resolve default property of object ObjectValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ObjectValue = ""
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object dbWaarde. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ObjectValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ObjectValue = dbWaarde
        End If

    End Function

    Sub ClearFlDummy()

        'JetTableClose(TABLE_DUMMY)
        KTRL = JetTableOpen(TABLE_DUMMY)
        JetGetFirst(TABLE_DUMMY, 0)
        Do While RS_MAR(TABLE_DUMMY).EOF
            RS_MAR(TABLE_DUMMY).Delete()
            RS_MAR(TABLE_DUMMY).MoveNext()
        Loop
        JetTableClose(TABLE_DUMMY)

    End Sub

    Public Function EditIsPossible(ByRef Fl As Short) As Short
        Dim TTT As Short

        EditIsPossible = True
        Exit Function

EditTry:
        'On Local Error GoTo EditAgain
        Err.Clear()
        'If NT_RS(FL).EditMode = dbEditNone Then
        If RS_MAR(Fl).EditMode = ADODB.EditModeEnum.adEditNone Then
            MsgBox("stop")
            EditIsPossible = False
        Else
            EditIsPossible = True
        End If
        'If IsNull(NT_RS(FL).Fields(0)) Then
        '    NT_RS(FL).AddNew
        'Else
        '    NT_RS(FL).Edit
        'End If
        Exit Function

EditAgain:
        If Err.Number = 91 Then
            JetTableOpen(Fl)
            GoTo EditTry
        ElseIf Err.Number = 3021 Then
            'MsgBox "addnew niet uitgevoerd voor bestand " + NT_RS(FL).Name + " !  Verwittig ons."
            MsgBox("addnew niet uitgevoerd voor tabel " & JET_TABLENAME(Fl) & " !  Verwittig ons.")
            Err.Clear()
            'NT_RS(FL).AddNew
            RS_MAR(Fl).AddNew()
            'msgBox "Addnew 2e poging met succes " + NT_RS(FL).Name + " !  Vergeet ons niet te verwittigen a.u.b. !"
            MsgBox("Addnew 2e poging met succes " & JET_TABLENAME(Fl) & " !  Vergeet ons niet te verwittigen a.u.b. !")
            EditIsPossible = True
            Exit Function
        End If
        MsgBox(ErrorToString())
        MSG = "De recordgegevens zelf zijn op dit ogenblik in bewerking bij een andere gebruiker !" & vbCrLf
        MSG = MSG & "Steeds opnieuw proberen ?" & vbCrLf & vbCrLf
        KTRL = MsgBox(MSG, 5 + 16, "Schrijfbeveiliging andere gebruiker")
        Select Case KTRL
            Case 4
                Resume
            Case Else
                Exit Function
        End Select

    End Function

    Sub JetTableClose(ByRef Fl As Short)
        Dim T As Short

        If Fl = 99 Then
            For Fl = 0 To NUMBER_TABLES
                TLB_RECORD(Fl) = ""
                If RS_MAR(Fl).State = ADODB.ObjectStateEnum.adStateClosed Then
                Else
                    Err.Clear()
                    On Error Resume Next
                    If RS_MAR(Fl).EditMode Then
                        RS_MAR(Fl).CancelUpdate()
                    End If
                    RS_MAR(Fl).Close()
                    KTRL = Err.Number
                    If Err.Number = 3420 Then MsgBox(ErrorToString())
                End If
            Next
        Else
            If RS_MAR(Fl).State = ADODB.ObjectStateEnum.adStateClosed Then
            Else
                Err.Clear()
                On Error Resume Next
                If RS_MAR(Fl).EditMode Then
                    RS_MAR(Fl).CancelUpdate()
                End If
                RS_MAR(Fl).Close()
                KTRL = Err.Number
                If Err.Number = 3420 Then MsgBox(ErrorToString())
            End If
        End If

    End Sub
    Sub Bdelete(ByRef Fl As Short)

        KTRL = 0
        If VSOFT_LOG Then
            WriteLog("DELETE", Fl, 0, "")
        End If

        On Error Resume Next
        Err.Clear()
        'NT_RS(FL).Delete
        RS_MAR(Fl).Delete()
        KTRL = Err.Number
        If Err.Number Then
            MsgBox(ErrorToString())
        End If

    End Sub

    Sub JetGetFirst(ByRef Fl As Short, ByRef fIndex As Short)

        On Error Resume Next

        JetTableClose(Fl)
        If VSOFT_LOG Then
            WriteLog("FIRST ", Fl, fIndex, "")
        End If

        Err.Clear()
        'SELECT  TOP 1 * FROM Klanten ORDER BY A110 ASC
        SQL_MSG(Fl) = "SELECT TOP 1 * FROM " & JET_TABLENAME(Fl) & " ORDER BY " & JETTABLEUSE_INDEX(Fl, fIndex) & " ASC"
        KTRL = 0 : JetTableOpen(Fl)

        If RS_MAR(Fl).EOF Then
            MsgBox("Stop")
        ElseIf RS_MAR(Fl).RecordCount = -1 Then
            MsgBox("Stop")
        ElseIf RS_MAR(Fl).RecordCount = 1 Then
            'fKey = SetSpacing(fKey, FLINDEX_LEN(FL, fIndex))
            KEY_INDEX(Fl) = fIndex
        ElseIf RS_MAR(Fl).RecordCount > 1 Then
            MsgBox("Stop")
        End If

    End Sub

    Sub JetGet(ByRef Fl As Short, ByRef fIndex As Short, ByRef fSleutel As String)

        On Error Resume Next
        JetTableClose(Fl)
        If VSOFT_LOG Then
            WriteLog("GET   ", Fl, fIndex, fSleutel)
        End If

        Err.Clear()
        fSleutel = SetSpacing(fSleutel, FLINDEX_LEN(Fl, fIndex))
        SQL_MSG(Fl) = "SELECT * FROM " & JET_TABLENAME(Fl) & " WHERE " & JETTABLEUSE_INDEX(Fl, fIndex) & "='" & fSleutel & "'"
        KTRL = 0 : JetTableOpen(Fl)

        If RS_MAR(Fl).EOF Then
            KTRL = 9
        ElseIf RS_MAR(Fl).RecordCount = -1 Then
            MsgBox("Stop")
        ElseIf RS_MAR(Fl).RecordCount = 1 Then
            KEY_BUF(Fl) = SetSpacing(fSleutel, FLINDEX_LEN(Fl, fIndex))
            KEY_INDEX(Fl) = fIndex
        ElseIf RS_MAR(Fl).RecordCount > 1 Then
            MsgBox("Stop")
        End If

    End Sub

    Sub JetGetOrGreater(ByRef Fl As Short, ByRef fIndex As Short, ByRef fKey As String)

        On Error Resume Next

TryAgain:
        If RS_MAR(Fl).State = ADODB.ObjectStateEnum.adStateClosed Then
            KTRL = JetTableOpen(Fl)
        End If
        If VSOFT_LOG Then
            WriteLog("GETOG ", Fl, fIndex, fKey)
        End If

        Err.Clear()
        fKey = SetSpacing(fKey, FLINDEX_LEN(Fl, fIndex))
        If RS_MAR(Fl).Index = FLINDEX_CAPTION(Fl, fIndex) Then
        Else
            RS_MAR(Fl).Index = FLINDEX_CAPTION(Fl, fIndex)
            If Err.Number = -2147217883 Then
                JetTableClose(Fl)
                Application.DoEvents()
                GoTo TryAgain
            End If
        End If

        RS_MAR(Fl).Seek(fKey, ADODB.SeekEnum.adSeekAfterEQ)

        If RS_MAR(Fl).EOF Then
            KTRL = 4
        Else
            KTRL = 0
        End If
        KEY_BUF(Fl) = RS_MAR(Fl).Fields(RTrim(JETTABLEUSE_INDEX(Fl, fIndex))).Value
        KEY_INDEX(Fl) = fIndex

    End Sub

    Sub JetInsert(ByRef Fl As Short, ByRef fIndex As Short) ', fKey As String)
        Dim XXXXX As Short

        If Fl = TABLE_INVOICES Then
        Else
            If RS_MAR(Fl).State = ADODB.ObjectStateEnum.adStateClosed Then
                KTRL = JetTableOpen(Fl)
            End If
            RS_MAR(Fl).AddNew()
        End If
        XXXXX = FieldToRecord(Fl)
        If KTRL = 32000 Then Exit Sub
        KEY_INDEX(Fl) = fIndex
        KEY_BUF(Fl) = FVT(Fl, fIndex)
        If VSOFT_LOG Then
            WriteLog("INSERT", Fl, fIndex, "")
        End If

        Dim JustTry As Object
        If Fl = TABLE_JOURNAL Then
            DKTRL_CUMUL += Val(RS_MAR(TABLE_JOURNAL).Fields("v068").Value)
            If BH_EURO Then
                DKTRL_BEF += Math.Round(Val(RS_MAR(TABLE_JOURNAL).Fields("v068").Value) * EURO, 0)
                DKTRL_EUR += Math.Round(Val(RS_MAR(TABLE_JOURNAL).Fields("v068").Value), 2)
                On Error Resume Next
                RS_MAR(TABLE_JOURNAL).Fields("dece068").Value = Val(RS_MAR(TABLE_JOURNAL).Fields("v068").Value)
                Err.Clear()
                On Error Resume Next
            Else
                DKTRL_BEF = DKTRL_BEF + System.Math.Round(Val(RS_MAR(TABLE_JOURNAL).Fields("v068").Value), 0)
                DKTRL_EUR = DKTRL_EUR + System.Math.Round(Val(RS_MAR(TABLE_JOURNAL).Fields("v068").Value) / EURO, 2)
            End If

            'UPGRADE_WARNING: Couldn't resolve default property of object JustTry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            JustTry = RS_MAR(Fl).Fields("v019").Value & vbTab & RS_MAR(Fl).Fields("v067").Value & vbTab
            If BH_EURO Then
                If Val(RS_MAR(Fl).Fields("v068").Value) < 0 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object JustTry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    JustTry = JustTry & "" & vbTab & Format(-Val(RS_MAR(Fl).Fields("v068").Value), "#,##0.00")
                    'UPGRADE_WARNING: Couldn't resolve default property of object JustTry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    JustTry = JustTry & vbTab & "" & vbTab & Format(System.Math.Round(-Val(RS_MAR(Fl).Fields("v068").Value) * EURO, 0), "#,##0.00")
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object JustTry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    JustTry = JustTry & Format(Val(RS_MAR(Fl).Fields("v068").Value), "#,##0.00") & vbTab & ""
                    'UPGRADE_WARNING: Couldn't resolve default property of object JustTry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    JustTry = JustTry & vbTab & Format(System.Math.Round(Val(RS_MAR(Fl).Fields("v068").Value) * EURO, 0), "#,##0.00") & vbTab & ""
                End If
            Else
                If Val(RS_MAR(Fl).Fields("v068").Value) < 0 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object JustTry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    JustTry = JustTry & "" & vbTab & Format(-Val(RS_MAR(Fl).Fields("v068").Value) / EURO, "#,##0.00")
                    'UPGRADE_WARNING: Couldn't resolve default property of object JustTry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    JustTry = JustTry & vbTab & "" & vbTab & Format(-Val(RS_MAR(Fl).Fields("v068").Value), "#,##0.00")
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object JustTry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    JustTry = JustTry & Format(Val(RS_MAR(Fl).Fields("v068").Value) / EURO, "#,##0.00") & vbTab & ""
                    'UPGRADE_WARNING: Couldn't resolve default property of object JustTry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    JustTry = JustTry & vbTab & Format(Val(RS_MAR(Fl).Fields("v068").Value), "#,##0.00") & vbTab & ""
                End If
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object JustTry. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Stop
            'TO DO:frmBoeking.mshfBoekLijst.AddItem(JustTry, frmBoeking.mshfBoekLijst.Rows - 1)
        End If

        On Error GoTo JetErrorInsert
        KTRL = 0
        RS_MAR(Fl).Update()
        If Fl = TABLE_JOURNAL Then
            If KTRL Then
                MsgBox("JetInsert journaal stopkode " & Str(KTRL))
            Else
                JetGet(TABLE_LEDGERACCOUNTS, 0, Left(FVT(TABLE_JOURNAL, 0), 7))
                If KTRL Then
                    MsgBox("Rekening " & Left(FVT(TABLE_JOURNAL, 0), 7) & " niet te vinden." & vbCrLf & "Eerst SETUPrekening inbrengen a.u.b. !")
                    DKTRL_CUMUL = DKTRL_CUMUL + 99
                    Exit Sub
                ElseIf ACTIVE_BOOKYEAR Then
                    RecordToField(TABLE_LEDGERACCOUNTS)
                    AdoInsertToRecord(TABLE_LEDGERACCOUNTS, Str(Val(AdoGetField(TABLE_LEDGERACCOUNTS, "#e023 #")) + Val(AdoGetField(TABLE_JOURNAL, "#v068 #"))), "e023")
                    RS_MAR(TABLE_LEDGERACCOUNTS).Fields("dece023").Value = RS_MAR(TABLE_LEDGERACCOUNTS).Fields("dece023").Value + RS_MAR(TABLE_JOURNAL).Fields("dece068").Value
                Else
                    RecordToField(TABLE_LEDGERACCOUNTS)
                    AdoInsertToRecord(TABLE_LEDGERACCOUNTS, Str(Val(AdoGetField(TABLE_LEDGERACCOUNTS, "#e022 #")) + Val(AdoGetField(TABLE_JOURNAL, "#v068 #"))), "e022")
                    RS_MAR(TABLE_LEDGERACCOUNTS).Fields("dece022").Value = RS_MAR(TABLE_LEDGERACCOUNTS).Fields("dece022").Value + RS_MAR(TABLE_JOURNAL).Fields("dece068").Value
                End If
                bUpdate(TABLE_LEDGERACCOUNTS, 0)
            End If
        End If
        Select Case KTRL
            Case 0
            Case 5
                MSG = "Dergelijke ID.Kode Bestaat reeds : " & KEY_BUF(Fl) & " : " & Str(Fl)
                MsgBox(MSG)
            Case 46
                MSG = "TABLEDEF_ONT werd geopend in LEES-modus." & vbCrLf & "Schrijven is niet mogelijk..."
                MsgBox(MSG, 0, "Database beveiliging")

            Case Else
                MSG = "Stopkode " & Str(KTRL) & " tijdens invoegen nieuwe record."
                MsgBox(MSG)
        End Select
        Exit Sub

JetErrorInsert:
        Select Case Err.Number
            Case 3022
                MsgBox("Unieke sleutel reeds aanwezig in bestand : " & JET_TABLENAME(Fl) & vbCrLf & vbCrLf & "Mogelijke sleutel : " & FVT(Fl, fIndex))
                KTRL = Err.Number
            Case Else
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If IsDBNull(RS_MAR(Fl).Fields(fIndex).Value) Then
                    MsgBox(ErrorToString() & vbCrLf & vbCrLf & "TABLEDEF_ONT : " & JET_TABLENAME(Fl) & vbCrLf & vbCrLf & "De sleutel heeft 'null' waarde", MsgBoxStyle.Exclamation)
                Else
                    MsgBox(ErrorToString() & vbCrLf & vbCrLf & "TABLEDEF_ONT : " & JET_TABLENAME(Fl) & vbCrLf & vbCrLf & "Mogelijke sleutel : " & FVT(Fl, fIndex), MsgBoxStyle.Exclamation)
                End If
                KTRL = Err.Number
        End Select
        Resume Next

    End Sub

    Sub bLast(ByRef Fl As Short, ByRef fIndex As Short)

        On Error Resume Next

        JetTableClose(Fl)
        If VSOFT_LOG Then
            WriteLog("LAST  ", Fl, fIndex, "")
        End If

        Err.Clear()
        'SELECT  TOP 1 * FROM Klanten ORDER BY A110 DESC
        SQL_MSG(Fl) = "SELECT TOP 1 * FROM " & JET_TABLENAME(Fl) & " ORDER BY " & JETTABLEUSE_INDEX(Fl, fIndex) & " DESC"
        KTRL = 0 : JetTableOpen(Fl)

        If RS_MAR(Fl).EOF Then
            Stop
        ElseIf RS_MAR(Fl).RecordCount = -1 Then
            Stop
        ElseIf RS_MAR(Fl).RecordCount = 1 Then
            'fKey = SetSpacing(fKey, FLINDEX_LEN(FL, fIndex))
            KEY_INDEX(Fl) = fIndex
        ElseIf RS_MAR(Fl).RecordCount > 1 Then
            Stop
        End If

    End Sub

    Sub bNext(ByRef Fl As Short, ByRef fIndex As Short, ByRef SleutelBefore As String)

        On Error Resume Next
        JetTableClose(Fl)
        If VSOFT_LOG Then
            WriteLog("NEXT  ", Fl, 0, "")
        End If

        Err.Clear()

        SQL_MSG(Fl) = "SELECT TOP 1 * FROM " & JET_TABLENAME(Fl) & " WHERE " & JETTABLEUSE_INDEX(Fl, fIndex) & " > '" & SleutelBefore & "' " & " ORDER BY " & JETTABLEUSE_INDEX(Fl, fIndex) & " ASC"
        KTRL = 0 : JetTableOpen(Fl)

        If RS_MAR(Fl).EOF Then
            KTRL = 9
        ElseIf RS_MAR(Fl).RecordCount = -1 Then
            KTRL = 9
        ElseIf RS_MAR(Fl).RecordCount = 1 Then
            'KEY_BUF(FL) = SetSpacing(fKey, FLINDEX_LEN(FL, fIndex))
            KEY_BUF(Fl) = ""
            KEY_INDEX(Fl) = fIndex
        ElseIf RS_MAR(Fl).RecordCount > 1 Then
            MsgBox("Stop meer dan een record!")
        End If

    End Sub

    Function JetTableOpen(ByRef Fl As Short) As Short
        Dim DataLijn As String
        Dim FlNr As Short
        Dim Dlen As Short

        If RS_MAR(Fl).State = ADODB.ObjectStateEnum.adStateClosed Then
        Else
            JetTableOpen = 0
            Exit Function
        End If

        Err.Clear()
        On Error Resume Next
        RS_MAR(Fl).CursorLocation = ADODB.CursorLocationEnum.adUseClient 'ADODB.CursorLocationEnum.adUseServer
        If Fl = TABLE_COUNTERS Then
            RS_MAR(Fl).Open(SQL_MSG(Fl), AD_NTDB) ', ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
        Else
            RS_MAR(Fl).Open(SQL_MSG(Fl), AD_NTDB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect)
        End If

        'NT_RS(FL).LockEdits = False
        If Err.Number Then
            MsgBox(ErrorToString())
            KTRL = Err.Number
        Else
            JetTableOpen = 0
        End If

    End Function

    Sub bPrev(ByRef Fl As Short, ByRef fIndex As Short, ByRef SleutelBefore As String)

        On Error Resume Next
        JetTableClose(Fl)
        If VSOFT_LOG Then
            WriteLog("PREV  ", Fl, 0, "")
        End If


        Err.Clear()
        SQL_MSG(Fl) = "SELECT TOP 1 * FROM " & JET_TABLENAME(Fl) & " WHERE " & JETTABLEUSE_INDEX(Fl, fIndex) & " < '" & SleutelBefore & "' " & " ORDER BY " & JETTABLEUSE_INDEX(Fl, fIndex) & " DESC"
        KTRL = 0 : JetTableOpen(Fl)

        If RS_MAR(Fl).EOF Then
            KTRL = 9
        ElseIf RS_MAR(Fl).RecordCount = -1 Then
            KTRL = 9
        ElseIf RS_MAR(Fl).RecordCount = 1 Then
            'KEY_BUF(FL) = SetSpacing(fKey, FLINDEX_LEN(FL, fIndex))
            KEY_BUF(Fl) = ""
            KEY_INDEX(Fl) = fIndex
        ElseIf RS_MAR(Fl).RecordCount > 1 Then
            MsgBox("Stop meer dan een record!")
        End If


    End Sub

    Sub bUpdate(ByRef Fl As Short, ByRef fIndex As Short)
        Dim XXXXX As Short
        Err.Clear()
        XXXXX = FieldToRecord(Fl)
        If KTRL = 32000 Then Exit Sub
        KEY_BUF(Fl) = FVT(Fl, fIndex)
        KEY_INDEX(Fl) = fIndex
        RS_MAR(Fl).Fields("dnnsync").Value = False
        If VSOFT_LOG Then
            WriteLog("UPDATE", Fl, fIndex, "")
        End If
        Try
            RS_MAR(Fl).Update()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function RTV(ByRef Fl As Short) As Short
        Dim T As Short

        RTV = False
        TLB_RECORD(Fl) = ""
        On Error Resume Next
        T = 0
        Do While Asc(VBC(Fl, T)) <> 0
            'AdoInsertToRecord FL, RTrim$(NT_RS(FL).Fields(VBC(FL, T))), VBC(FL, T)
            AdoInsertToRecord(Fl, RTrim(RS_MAR(Fl).Fields(VBC(Fl, T)).Value), VBC(Fl, T))
            T = T + 1
        Loop
        For T = 0 To FL_NUMBEROFINDEXEN(Fl)
            FVT(Fl, T) = AdoGetField(Fl, "#" & JETTABLEUSE_INDEX(Fl, T) & "#")
        Next
        RTV = True

    End Function

    Sub RecordToField(ByRef Fl As Short)
        Dim T As Short
        Dim b As String

        TLB_RECORD(Fl) = ""
        On Error Resume Next
        T = 0
        If Fl = TABLE_VARIOUS Then
            'TLB_RECORD(FL) = NT_RS(FL).Fields("MEMO")
            TLB_RECORD(Fl) = RS_MAR(Fl).Fields("MEMO").Value
        ElseIf Fl = TABLE_DUMMY Then
            'TLB_RECORD(FL) = NT_RS(FL).Fields("MEMO")
            TLB_RECORD(Fl) = RS_MAR(Fl).Fields("MEMO").Value
        Else
            Do While VBC(Fl, T) <> ""
                'AdoInsertToRecord FL, Trim$(NT_RS(FL).Fields(VBC(FL, T))), VBC(FL, T)
                AdoInsertToRecord(Fl, RS_MAR(Fl).Fields(VBC(Fl, T)).Value, VBC(Fl, T))
                T += 1
            Loop
        End If

    End Sub

    Sub WriteLog(ByRef BtrieveAktie As String, ByRef FlNummer As Short, ByRef IndexNummer As Short, ByRef IndexSleutel As String)
        Dim FlLog As Short
        Dim RecordLijn As String

        RecordLijn = BtrieveAktie & Format(IndexNummer)
        Select Case FlNummer
            Case TABLE_VARIOUS
                RecordLijn = RecordLijn & "ALLERLEI"
            Case TABLE_CUSTOMERS
                RecordLijn = RecordLijn & "KLANTEN "
            Case TABLE_SUPPLIERS
                RecordLijn = RecordLijn & "LEVERANC"
            Case TABLE_LEDGERACCOUNTS
                RecordLijn = RecordLijn & "REKENING"
            Case TABLE_PRODUCTS
                RecordLijn = RecordLijn & "PRODUKT "
            Case TABLE_INVOICES
                RecordLijn = RecordLijn & "dokument"
            Case TABLE_JOURNAL
                RecordLijn = RecordLijn & "JOURNAAL"
            Case TABLE_CONTRACTS
                RecordLijn = RecordLijn & "POLISSEN"
            Case TABLE_COUNTERS
                RecordLijn = RecordLijn & "TELLERS "
        End Select

        Select Case BtrieveAktie
            Case "INSERT", "UPDATE"
                RecordLijn = RecordLijn & TLB_RECORD(FlNummer)
            Case Else
                RecordLijn = RecordLijn & IndexSleutel
        End Select

        FlLog = FreeFile()
        FileOpen(FlLog, PROGRAM_LOCATION & "NTIMPORT.LOG", OpenMode.Append, , OpenShare.LockWrite)
        Print(FlLog, RecordLijn & vbCrLf)
        FileClose(FlLog)

    End Sub

    Sub SetFields(ByRef Fl As Short, ByRef vBibCode As String, ByRef StringData As String)
        Dim vBCode As String
        If StringData = "" Then
            StringData = " "
        End If
        vBCode = RTrim(vBibCode)
        Debug.Print(vBCode)
        If RTrim(vBCode) = "MEMO" Then
            Try
                RS_MAR(Fl).Fields(vBCode).Value = TLB_RECORD(Fl)
            Catch ex As Exception
                MsgBox(ex.Message)
                Stop
            End Try

        Else
            Try
                RS_MAR(Fl).Fields(vBCode).Value = Mid(StringData, 1, RS_MAR(Fl).Fields(vBCode).DefinedSize)
            Catch ex As Exception
                MsgBox(ex.Message)
                Stop
            End Try
        End If
    End Sub

    Function FieldToRecord(ByRef Fl As Short) As Short
        Dim T As Short

        On Error GoTo 0
        If RS_MAR(Fl).State = ADODB.ObjectStateEnum.adStateClosed Then
            KTRL = JetTableOpen(Fl)
            'ElseIf EditIsPossible(FL) = False Then
            '    KTRL = 32000
            '    Exit Function
        End If

        If Fl = TABLE_CONTRACTS Then
            AdoInsertToRecord(Fl, SetSpacing(AdoGetField(Fl, "#v164 #"), 2) & SetSpacing(AdoGetField(Fl, "#A110 #"), 12) & SetSpacing(AdoGetField(Fl, "#A010 #"), 4) & SetSpacing(AdoGetField(Fl, "#A000 #"), 12), "v167") 'MaandKlantMaatschappijPolis
        ElseIf Fl = TABLE_JOURNAL Then
            AdoInsertToRecord(Fl, SetSpacing(AdoGetField(Fl, "#v019 #"), 7) & AdoGetField(Fl, "#v066 #"), "v070")
        End If
        For T = 0 To FL_NUMBEROFINDEXEN(Fl)
            FVT(Fl, T) = SetSpacing(AdoGetField(Fl, "#" & JETTABLEUSE_INDEX(Fl, T) & "#"), FLINDEX_LEN(Fl, T))
        Next
        AdoInsertToRecord(Fl, FVT(Fl, 0), JETTABLEUSE_INDEX(Fl, 0))
        T = 0
        Do While VBC(Fl, T) <> ""
            SetFields(Fl, VBC(Fl, T), AdoGetField(Fl, "#" & VBC(Fl, T) & " #"))
            T = T + 1
        Loop
        On Error Resume Next
        If Fl = TABLE_VARIOUS Then
            RS_MAR(TABLE_VARIOUS).Fields("A000").Value = AdoGetField(TABLE_VARIOUS, "#A000 #")
        End If

    End Function

    Function String99(ByRef LockModus As Short, ByRef SZNummer As Short) As String
        Dim TlString As String

        TlString = "s" & Format(SZNummer, "000")
        If LockModus = READING Then
            LOCK_HOLD = False
        Else
            LOCK_HOLD = True
        End If
        JetGet(TABLE_COUNTERS, 0, TlString)

        If KTRL = 99 Then
        ElseIf KTRL Then
            MsgBox("Tellers Stopkode " & Format(KTRL) & ", voor setup-tellersleutel " & TlString & vbCrLf & vbCrLf & "Overloop ALLE setup instellingen vooraleer énig boekjaar op te starten !" & vbCrLf & "Wij staan tot uw beschikking om U hierbij te helpen.")
        Else
            RecordToField(TABLE_COUNTERS)
            'String99 = NT_RS(TABLE_COUNTERS).Fields("v217")
            On Error Resume Next
            Err.Clear()
            String99 = RS_MAR(TABLE_COUNTERS).Fields("v217").Value
            If Err.Number Then MsgBox(ErrorToString())
        End If
        JetTableClose(TABLE_COUNTERS)

    End Function

    Function TeleBibPagina(ByRef Fl As Short) As Short
        Dim FlInput As Short
        Dim FFDefinitie As String
        Dim DummyString As String
        Dim DummYtje As String
        Dim KtrlAantal As Integer

        Dim CurBedrag As Decimal
        Dim T As Short

        TeleBibPagina = False



        On Error GoTo TeleBibError

        'code= 1 - 1 : Poliskontrole 1 = ON
        '      2 - 3 : Selektiekeuze waarde (LIST_IDX)
        '      4 - 4 :
        '      5 - 8 : TeleBib
        '      9 - 9 : Volgnummer eventueel 1 tot 9
        '      10    : * voor verplichte invulling
        'Inlaadvolgorde 1 : 000     'hoofddefinitie (VSOFT)
        '               2 : xxxG    'uitbreiding gebruiker
        '               2 : xxxM    'uitbreiding makelaar

        Dim LokaalBestand As String

        If Fl <> TABLE_COUNTERS Then
            LokaalBestand = Left(TABLEDEF_ONT(Fl), 3)
        Else
            LokaalBestand = "00"
        End If

        Dim ProgrammaLokatieHier As String = Application.StartupPath & "\"

        'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        If Dir(ProgrammaLokatieHier & "Def\" & LokaalBestand & ".Def") = "" Then
            MsgBox("Geen VsoftBib definitie " & ProgrammaLokatieHier & "Def\" & LokaalBestand & ".Def")
            Exit Function
        End If

EerstEnVooral:
        'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        If Dir(ProgrammaLokatieHier & "Def\" & LokaalBestand & "U.Def") = "" Then
            GoTo GeenUserVoorkeur
        Else
            T = 0
            FlInput = FreeFile()
            FileOpen(FlInput, ProgrammaLokatieHier & "Def\" & LokaalBestand & "U.Def", OpenMode.Input)
            Do While Not EOF(FlInput)
                Input(FlInput, TELEBIB_CODE(T))
                Input(FlInput, TELEBIB_TEXT(T))
                Input(FlInput, TELEBIB_TYPE(T))
                Input(FlInput, TELEBIB_LENGHT(T))
                VBC(Fl, T) = Mid(TELEBIB_CODE(T), 5, 4)
                T = T + 1
            Loop
            VBC(Fl, T) = ""
            FileClose(FlInput)
            TELEBIB_CODE(T) = ""
            TELEBIB_LAST = T - 1
            TeleBibPagina = True
            Exit Function
        End If

GeenUserVoorkeur:
        FlInput = FreeFile()
        FileOpen(FlInput, ProgrammaLokatieHier & "Def\" & LokaalBestand & ".Def", OpenMode.Input)
        T = 0
        Do While Not EOF(FlInput)
            Input(FlInput, TELEBIB_CODE(T))
            Input(FlInput, TELEBIB_TEXT(T))
            Input(FlInput, TELEBIB_TYPE(T))
            Input(FlInput, TELEBIB_LENGHT(T))
            VBC(Fl, T) = Mid(TELEBIB_CODE(T), 5, 4)
            T = T + 1
        Loop
        VBC(Fl, T) = ""
        FileClose(FlInput)
        TELEBIB_LAST = T - 1
        TELEBIB_CODE(T) = ""
        TeleBibPagina = True

MakelaarIn:
        If Trim(AGENT_NUMBER) = "" Then
            'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        ElseIf Dir(ProgrammaLokatieHier & "Def\" & LokaalBestand & "M.Def") = "" Then
        Else
            FlInput = FreeFile()
            FileOpen(FlInput, ProgrammaLokatieHier & "Def\" & LokaalBestand & "M.Def", OpenMode.Input)
            Do While Not EOF(FlInput)
                Input(FlInput, TELEBIB_CODE(T))
                Input(FlInput, TELEBIB_TEXT(T))
                Input(FlInput, TELEBIB_TYPE(T))
                Input(FlInput, TELEBIB_LENGHT(T))
                VBC(Fl, T) = Mid(TELEBIB_CODE(T), 5, 4)
                T = T + 1
            Loop
            VBC(Fl, T) = ""
            FileClose(FlInput)
            TELEBIB_LAST = T - 1
            TELEBIB_CODE(T) = ""
        End If
        Exit Function

TeleBibError:
        MsgBox("Telebibinlaadfout" & Str(T) & " error:" & ErrorToString())
        FileClose(FlInput)
        TeleBibPagina = False
        Exit Function
        Resume

    End Function

    Function fmarBoxText(ByRef marBoxNumber As String, ByRef Taal As String, ByRef marBoxOption As String) As String
        Dim ZoekTekst As String
        fmarBoxText = ""

        If Len(marBoxNumber) = 2 Then
            ZoekTekst = "NTKB" & Taal & "9"
        ElseIf Len(marBoxNumber) = 3 Then
            ZoekTekst = "NTKB" & Taal
        ElseIf Len(marBoxNumber) = 4 Then
            MsgBox("Stop")
            ZoekTekst = "NT"
        Else
            MsgBox("fmarBoxText fout")
            Exit Function
        End If
        ZoekTekst = ZoekTekst & marBoxNumber
        fmarBoxText = ZoekEnPlaats(FormBoxList.LbBoxList, ZoekTekst, 0, 0, marBoxOption)

    End Function

    Function ZoekEnPlaats(ByRef DeKontrol As ListBox, ByRef ZoekTekst As String, ByRef ALijnen As Short, ByRef OptieNr As Short, ByRef OptieTxt As String) As String
        Dim OptieLen As Short
        'Dim CRLFLokatie As Integer
        Dim PuntKommaLokatie As Short

        Dim DeString As String
        Dim joinStringHier As String


        ZoekEnPlaats = ""
        AD_KBTable.Seek(ZoekTekst, ADODB.SeekEnum.adSeekFirstEQ)
        If AD_KBTable.EOF Then
            MsgBox("Stop !  Keuzebox " & ZoekTekst & " niet te vinden...")
            Exit Function
        Else
            'AD_KBTable.Fields("BestandsNaam")
            joinStringHier = AD_KBTable.Fields("splitDefinitie").Value
        End If

        PuntKommaLokatie = 1
        ALijnen = 0
        OptieNr = 0
        OptieLen = Len(OptieTxt)
        'UPGRADE_WARNING: Couldn't resolve default property of object DeKontrol.Clear. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        DeKontrol.Items.Clear()
        Do While InStr(PuntKommaLokatie, joinStringHier, ";")
            ALijnen = ALijnen + 1
            DeString = Mid(joinStringHier, PuntKommaLokatie, InStr(PuntKommaLokatie, joinStringHier, ";") - PuntKommaLokatie)
            'KeuzeVSF.NTBoxLijst.AddItem DeString
            'UPGRADE_WARNING: Couldn't resolve default property of object DeKontrol.AddItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            DeKontrol.Items.Add(DeString)
            If Mid(joinStringHier, PuntKommaLokatie, OptieLen) = OptieTxt Then
                OptieNr = ALijnen - 1
                ZoekEnPlaats = DeString
            End If
            PuntKommaLokatie = InStr(PuntKommaLokatie, joinStringHier, ";") + 1
        Loop
        If Len(OptieTxt) = 0 Then OptieNr = 0

    End Function

    Function RV(ByRef adoRecord As ADODB.Recordset, ByRef TBS As String) As Object
        If IsDBNull(adoRecord.Fields(TBS).Value) Or IsNothing(adoRecord.Fields(TBS).Value) Then
            RV = ""
        Else
            RV = adoRecord.Fields(TBS).Value
        End If
    End Function

    Function adoJournaalOK() As Boolean

        adoJournaalOK = False
        'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Dim Pipo As String
        Dim nieuwePipo As String

        nieuwePipo = RS_JOURNAL.Fields("v019").Value

        Dim itemHier As New ListViewItem(nieuwePipo)
        itemHier.SubItems.Add(RS_JOURNAL.Fields("v067").Value)
        If Val(RV(RS_JOURNAL, "v068")) = 0 Then
            MsgBox("BoekBedrag is 0")
            Stop
        Else
            DKTRL_CUMUL = DKTRL_CUMUL + Val(RV(RS_JOURNAL, "v068"))
            DKTRL_BEF = DKTRL_BEF + Math.Round(Val(RV(RS_JOURNAL, "v068")) * EURO, 0)
            DKTRL_EUR = DKTRL_EUR + Math.Round(Val(RV(RS_JOURNAL, "v068")), 2)
            RS_JOURNAL.Fields("dece068").Value = Val(RV(RS_JOURNAL, "v068"))
            Pipo = RS_JOURNAL.Fields("v019").Value & vbTab & RS_JOURNAL.Fields("v067").Value & vbTab
            If Val(RS_JOURNAL.Fields("v068").Value) < 0 Then
                Pipo = Pipo & "" & vbTab & Format(-Val(RS_JOURNAL.Fields("v068").Value), "#,##0.00")
                Pipo = Pipo & vbTab & "" & vbTab & Format(Math.Round(-Val(RS_JOURNAL.Fields("v068").Value) * EURO), "#,##0.00")
                itemHier.SubItems.Add(" ")
                itemHier.SubItems.Add(Format(-Val(RS_JOURNAL.Fields("v068").Value), "#,##0.00"))
                itemHier.SubItems.Add(" ")
                itemHier.SubItems.Add(Format(Math.Round(-Val(RS_JOURNAL.Fields("v068").Value) * EURO), "#,##0.00"))
            Else
                Pipo = Pipo & Format(Val(RS_JOURNAL.Fields("v068").Value), "#,##0.00") & vbTab & ""
                Pipo = Pipo & vbTab & Format(Math.Round(Val(RS_JOURNAL.Fields("v068").Value) * EURO), "#,##0.00") & vbTab & ""
                itemHier.SubItems.Add(Format(Val(RS_JOURNAL.Fields("v068").Value), "#,##0.00"))
                itemHier.SubItems.Add(" ")
                itemHier.SubItems.Add(Format(Math.Round(Val(RS_JOURNAL.Fields("v068").Value) * EURO), "#,##0.00"))
                itemHier.SubItems.Add(" ")
            End If
            'TODOBoeking. Boeking.mshfBoekLijst.AddItem(JustTry, frmBoeking.mshfBoekLijst.Rows - 1)
        End If
        FormBookingControl.LvReadyToBook.Items.Add(itemHier)

        RS_JOURNAL.Fields("v070").Value = SetSpacing(RS_JOURNAL.Fields("v019").Value, 7) + RS_JOURNAL.Fields("v066").Value

        JetGet(TABLE_LEDGERACCOUNTS, 0, RS_JOURNAL.Fields("v019").Value)
        If KTRL Then
            MsgBox("Rekening " + RS_JOURNAL.Fields("v019").Value + " niet te vinden." + vbCrLf + "Eerst SETUPrekening inbrengen a.u.b. !")
            DKTRL_CUMUL = DKTRL_CUMUL + 99
            Exit Function
        ElseIf ACTIVE_BOOKYEAR Then
            RecordToField(TABLE_LEDGERACCOUNTS)
            'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            AdoInsertToRecord(TABLE_LEDGERACCOUNTS, Str(Val(AdoGetField(TABLE_LEDGERACCOUNTS, "#e023 #")) + Val(RV(RS_JOURNAL, "v068"))), "e023")
            'UPGRADE_WARNING: Couldn't resolve default property of object RV(RS_JOURNAL, dece068). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            RS_MAR(TABLE_LEDGERACCOUNTS).Fields("dece023").Value = RS_MAR(TABLE_LEDGERACCOUNTS).Fields("dece023").Value + RV(RS_JOURNAL, "dece068")
        Else
            RecordToField(TABLE_LEDGERACCOUNTS)
            'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            AdoInsertToRecord(TABLE_LEDGERACCOUNTS, Str(Val(AdoGetField(TABLE_LEDGERACCOUNTS, "#e022 #")) + Val(RV(RS_JOURNAL, "v068"))), "e022")
            'UPGRADE_WARNING: Couldn't resolve default property of object RV(RS_JOURNAL, dece068). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            RS_MAR(TABLE_LEDGERACCOUNTS).Fields("dece022").Value = RS_MAR(TABLE_LEDGERACCOUNTS).Fields("dece022").Value + RV(RS_JOURNAL, "dece068")
        End If
        RS_MAR(TABLE_LEDGERACCOUNTS).Fields("dnnsync").Value = False
        bUpdate(TABLE_LEDGERACCOUNTS, 0)
        Err.Clear()
        On Error Resume Next
        RS_JOURNAL.Update()
        If Err.Number Then
            MsgBox(ErrorToString())
        Else
            adoJournaalOK = True
        End If

    End Function

    Function adoGet(ByRef iTabel As Short, ByRef iIndex As Short, ByRef sZoals As String, ByRef sZoek As Object) As Boolean

        Dim MsgHier As String

        On Error Resume Next
        If RS_MAR(iTabel).State = ADODB.ObjectStateEnum.adStateClosed Then
            KTRL = JetTableOpen(iTabel)
        End If
        adoGet = False
        Err.Clear()
        If InStr(SQL_CONNECT, "SQLOLEDB") Then
            RS_MAR(iTabel).Close()
            If iTabel = TABLE_COUNTERS Then
                'UPGRADE_WARNING: Couldn't resolve default property of object sZoek. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                MsgHier = "SELECT * FROM " & "jr" & JET_TABLENAME(iTabel) & " WHERE " & JETTABLEUSE_INDEX(iTabel, iIndex) & " " & sZoals & " " & " '" & sZoek & "'"
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object sZoek. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                MsgHier = "SELECT * FROM " & JET_TABLENAME(iTabel) & " WHERE " & JETTABLEUSE_INDEX(iTabel, iIndex) & " " & sZoals & " " & " '" & sZoek & "'"
            End If
            'SnelHelpPrint MsgHier, BL_LOGGING
            RS_MAR(iTabel).Open(MsgHier, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
            If Err.Number Then
                MsgBox("Bron:" & vbCrLf & Err.Source & vbCrLf & vbCrLf & "Foutnummer: " & Err.Number & vbCrLf & vbCrLf & "Detail:" & vbCrLf & Err.Description)
                Exit Function
            ElseIf RS_MAR(iTabel).RecordCount Then
                adoGet = True
            End If
        Else
            RS_MAR(iTabel).Index = FLINDEX_CAPTION(iTabel, iIndex)
            If sZoals = "=" Then
                RS_MAR(iTabel).Seek(sZoek)
            ElseIf sZoals = ">=" Then
                RS_MAR(iTabel).Seek(sZoek, ADODB.SeekEnum.adSeekAfterEQ)
            Else
                MsgBox(sZoals & " nog niet beschikbaar")
            End If
            If RS_MAR(iTabel).EOF Then
            Else
                adoGet = True
            End If
        End If

    End Function

    Function adoBibTekst(ByRef adoField As ADODB.Field, ByRef TBS As String) As String

        Err.Clear()
        On Error Resume Next
        If adoField.Value = "" Then
            adoBibTekst = ""
        Else
            adoBibTekst = Mid(adoField.Value, InStr(adoField.Value, TBS) + 7, InStr(InStr(adoField.Value, TBS) + 7, adoField.Value, "#") - (InStr(adoField.Value, TBS) + 7))
        End If
        If Err.Number Then adoBibTekst = ""

    End Function
End Module
