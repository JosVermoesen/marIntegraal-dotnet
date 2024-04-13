Option Strict Off
Option Explicit On
Module modTB2

    Function tb2Indent(ByRef MAPIString As String) As String

        Dim Xarray() As String
        Dim strComment As String

        Xarray = Split(MAPIString, "'")

        Dim strIndent As String
        Dim telIndent As Short
        Dim tabIndent As Short
        Dim telTabIndent As Short

        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        strIndent = ""
        telTabIndent = 0
        For telIndent = 0 To UBound(Xarray) - 1
            'Maak eerst het aantal tabs klaar voor de volgende stringreeks
            For telTabIndent = 1 To tabIndent
                strIndent &= vbTab
            Next

            'TELEBIB2 extra info eventueel toe te voegen...
            If Len(Xarray(telIndent)) = 0 Then
                'Stop
            Else
                strComment = TB2commentaar(Xarray(telIndent))
                strIndent = strIndent & Xarray(telIndent) & strComment & vbCrLf
                'Aanpassen van de tabIndent voor de volgende tekenreeks
                Select Case Left(Xarray(telIndent), 3)
                    Case "XGH", "XEH", "XRH"
                        'Teller verhogen
                        tabIndent = tabIndent + 1

                    Case "XGT", "XET", "XRT"
                        'niks doen, zie hieronder !

                End Select

                'Aanpassen van de tabIndent voor afsluiting tekenreeks
                Select Case Left(Xarray(telIndent + 1), 3)
                    Case "XGT", "XET", "XRT"
                        tabIndent = tabIndent - 1
                End Select

            End If
        Next
        tb2Indent = strIndent

    End Function

    Function TB2QualifiersJSON() As String
        Dim rsTB2Qualifiers As ADODB.Recordset

        rsTB2Qualifiers = New ADODB.Recordset
        rsTB2Qualifiers.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Msg = "SELECT * From A_DE_QUALIFIANT"
        rsTB2Qualifiers.Open(Msg, adTBIB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)

        If rsTB2Qualifiers.RecordCount <= 0 Then
            TB2QualifiersJSON = "null"
        Else
            Dim outp As New System.Text.StringBuilder
            Dim c As String = Chr(34)
            Dim strValue As String

            Do While Not rsTB2Qualifiers.EOF
                If outp.Length = 0 Then
                    outp.Append("{" & c & "qualifiers" & c & ":{" & c & "qualifier" & c & ":[")
                Else
                    outp.Append(",")
                End If
                strValue = cleanMdbField(rsTB2Qualifiers.Fields("DE").Value.ToString)
                outp.Append("{" & c & "DE" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Qualifiers.Fields("Version").Value.ToString)
                outp.Append(c & "Version" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Qualifiers.Fields("Qualifiant").Value.ToString)
                outp.Append(c & "Qualifiant" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Qualifiers.Fields("Lbc-1").Value.ToString)
                outp.Append(c & "Lbc-1" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Qualifiers.Fields("Lbc-2").Value.ToString)
                outp.Append(c & "Lbc-2" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Qualifiers.Fields("Lbc-3").Value.ToString)
                outp.Append(c & "Lbc-3" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Qualifiers.Fields("Lbc-4").Value.ToString)
                outp.Append(c & "Lbc-4" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Qualifiers.Fields("Datcre").Value.ToString)
                outp.Append(c & "Datcre" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Qualifiers.Fields("Datmod").Value.ToString)
                outp.Append(c & "Datmod" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Qualifiers.Fields("Datdel").Value.ToString)
                outp.Append(c & "Datdel" & c & ":" & c & strValue & c & "}")
                rsTB2Qualifiers.MoveNext()
            Loop
            outp.Append("]}}")
            TB2QualifiersJSON = outp.ToString
        End If

    End Function

    Function TB2ValeursJSON() As String

        Dim rsTB2Lists As ADODB.Recordset
        rsTB2Lists = New ADODB.Recordset

        rsTB2Lists.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Msg = "SELECT * From VALEUR"
        rsTB2Lists.Open(Msg, adTBIB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
        If rsTB2Lists.RecordCount <= 0 Then
            TB2ValeursJSON = "null"
        Else
            Dim outp As New System.Text.StringBuilder
            Dim c As String = Chr(34)
            Dim strValue As String

            Do While Not rsTB2Lists.EOF
                If outp.Length = 0 Then
                    outp.Append("{" & c & "valeurs" & c & ":{" & c & "valeur" & c & ":[")
                Else
                    outp.Append(",")
                End If
                strValue = cleanMdbField(rsTB2Lists.Fields("Code").Value.ToString)
                outp.Append("{" & c & "Code" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Lists.Fields("Valeur").Value.ToString)
                outp.Append(c & "Valeur" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Lists.Fields("Lbc-1").Value.ToString)
                outp.Append(c & "Lbc-1" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Lists.Fields("Lbc-2").Value.ToString)
                outp.Append(c & "Lbc-2" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Lists.Fields("Lbl-1").Value.ToString)
                outp.Append(c & "Lbl-1" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Lists.Fields("Lbl-2").Value.ToString)
                outp.Append(c & "Lbl-2" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Lists.Fields("Lbl-3").Value.ToString)
                outp.Append(c & "Lbl-3" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Lists.Fields("Lbl-4").Value.ToString)
                outp.Append(c & "Lbl-4" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Lists.Fields("Datcre").Value.ToString)
                outp.Append(c & "Datcre" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Lists.Fields("Datmod").Value.ToString)
                outp.Append(c & "Datmod" & c & ":" & c & strValue & c & ",")
                strValue = cleanMdbField(rsTB2Lists.Fields("Datdel").Value.ToString)
                outp.Append(c & "Datdel" & c & ":" & c & strValue & c & "}")
                rsTB2Lists.MoveNext()
            Loop
            rsTB2Lists.Close()
            outp.Append("]}}")
            TB2ValeursJSON = outp.ToString
        End If

    End Function

    Function cleanMdbField(strToCheck As String) As String

        Dim c As String = Chr(34)

        'Static Dim teller As Integer = 0
        'teller = teller + 1

        'Eerst zoeken op " en wijzigen naar '
        Do While InStr(strToCheck, c)
            strToCheck = Replace(strToCheck, c, "'")
        Loop

        'TODO:Dan stap voor stap zien wat er nog verkeerd loopt
        'If InStr(strToCheck, "Tweede v") Then
        ''résidence","Lbc-2":"Tweede v
        'Stop
        'End If
        Return strToCheck

    End Function


    Function headComLists(ByRef strDE As String, ByRef strQualifiant As String, ByRef strOOD As String) As String

        Dim rsTB2Qualifiers As ADODB.Recordset

        rsTB2Qualifiers = New ADODB.Recordset
        rsTB2Qualifiers.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Msg = "SELECT * From A_DE_QUALIFIANT WHERE DE = '" & strDE & "' AND Qualifiant = '" & strQualifiant & "'"
        rsTB2Qualifiers.Open(Msg, adTBIB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
        If rsTB2Qualifiers.RecordCount <> 1 Then
            headComLists = " - "
            Exit Function
        Else
            headComLists = rsTB2Qualifiers.Fields("Lbc-2").Value
        End If
        'Tot slot nog controleren of gebruiksdatum niet overschreden (meestal indien problemen)..
        If rsTB2Qualifiers.Fields("Datdel").Value.ToString <> "" Then
            'ok blijkbaar niet meer in gebruik !
            strOOD = rsTB2Qualifiers.Fields("Datdel").Value
        End If
        rsTB2Qualifiers.Close()

    End Function


    Function subComLists(ByRef strCode As String, ByRef strValeur As String) As String

        Dim rsTB2Lists As ADODB.Recordset

        rsTB2Lists = New ADODB.Recordset
        rsTB2Lists.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Msg = "SELECT * From VALEUR WHERE Code = '" & strCode & "' AND Valeur = '" & strValeur & "'"
        rsTB2Lists.Open(Msg, adTBIB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
        If rsTB2Lists.RecordCount <> 1 Then
            subComLists = ""
        Else
            subComLists = rsTB2Lists.Fields("Lbl-2").Value
        End If
        rsTB2Lists.Close()

    End Function


    Function TB2commentaar(ByRef TB2code As String) As String

        TB2commentaar = ""

        Dim Yarray() As String
        Dim Zarray() As String
        Yarray = Split(TB2code, "+")

        Dim headCommentaar As String
        Dim subCommentaar As String
        Dim outOfDateSince As String = ""

        headCommentaar = ""
        subCommentaar = ""

        Select Case Yarray(0)
            Case "GIS"
                If UBound(Yarray) > 1 Then
                    subCommentaar = subComLists(Yarray(1), Yarray(2))
                End If
                'GIS= Process indicator= X021
                headCommentaar = headComLists("X021", Yarray(1), outOfDateSince)

            Case "IPD"
                If UBound(Yarray) > 1 Then
                    Zarray = Split(Yarray(2), ":")
                    subCommentaar = subComLists(Yarray(1), Zarray(0)) ' Yarray(2))
                End If
                'IPD: Segment Product=X060, dus...
                headCommentaar = headComLists("X060", Yarray(1), outOfDateSince)

            Case "ATT"
                If UBound(Yarray) > 1 Then
                    subCommentaar = subComLists(Yarray(1), Yarray(2))
                End If
                'ATT: Attribute=X010, dus...
                headCommentaar = headComLists("X010", Yarray(1), outOfDateSince)

            Case "RFF"
                'RFF: Reference qualifier=X050 én subReference Details=X032, dus...
                Zarray = Split(Yarray(1), ":")
                If UBound(Zarray) > 1 Then
                    subCommentaar = headComLists("X032", Zarray(2), outOfDateSince)
                End If
                headCommentaar = headComLists("X050", Zarray(0), outOfDateSince)

            Case "DTM"
                'DTM: Date/Time qualifier=X016 én format qualifier X018, dus...
                Zarray = Split(Yarray(1), ":")
                If UBound(Zarray) = 2 Then
                    subCommentaar = "=" & headComLists("X018", Zarray(2), outOfDateSince)
                End If
                headCommentaar = headComLists("X016", Zarray(0), outOfDateSince)

            Case "QRS"
                'QRS: Declaration qualifier=X045 én eventuele response code, dus...
                Zarray = Split(Yarray(1), ":")
                If UBound(Yarray) = 2 Then
                    subCommentaar = "=" & headComLists("X046", Yarray(2), outOfDateSince)
                End If
                headCommentaar = headComLists("X045", Zarray(0), outOfDateSince)

            Case "BIN"
                'BIN: Boolean indicator=X069 én eventueel boolean indicator value X070, dus...
                If UBound(Yarray) = 2 Then
                    subCommentaar = headComLists("X070", Yarray(2), outOfDateSince)
                End If
                headCommentaar = headComLists("X069", Yarray(1), outOfDateSince)

            Case "QTY"
                'QTY: Quantity qualifier=X047, cijfer zelf,
                '     aantaldecimalen en gecodeerde maateenheid X049 dus...
                Zarray = Split(Yarray(1), ":")
                If UBound(Zarray) > 2 Then
                    subCommentaar = headComLists("X049", Zarray(3), outOfDateSince)
                End If
                headCommentaar = headComLists("X047", Zarray(0), outOfDateSince)

            Case "COM"
                'COM:
                Zarray = Split(Yarray(1), ":")
                headCommentaar = headComLists("X013", Zarray(0), outOfDateSince)

            Case "ICD"
                'ICD: Waarborgen=X058
                Zarray = Split(Yarray(1), ":")
                headCommentaar = headComLists("X058", Zarray(0), outOfDateSince)

            Case "MOA"
                'MOA: Monetairy Amount=X028, dus...
                Zarray = Split(Yarray(1), ":")
                If UBound(Zarray) > 1 Then
                    subCommentaar = headComLists("X031", Zarray(2), outOfDateSince)
                End If
                headCommentaar = headComLists("X028", Zarray(0), outOfDateSince)

            Case "PCD"
                'Percentaga qualifier= X038, cijfer zelf, aantal decimalen
                Zarray = Split(Yarray(1), ":")
                headCommentaar = headComLists("X038", Zarray(0), outOfDateSince)

            Case "PTY"
                'PTY: Party Identification, party qualifier=X043, dus...
                headCommentaar = headComLists("X043", Yarray(1), outOfDateSince)

            Case "NME"
                'NME: Name qualifier=X033, dus...
                headCommentaar = headComLists("X033", Yarray(1), outOfDateSince)

            Case "ADR"
                'ADR: Adres qualifier=X001, dus...
                headCommentaar = headComLists("X001", Yarray(1), outOfDateSince)

            Case "DOC"
                'DOC: Document=X015, dus...
                headCommentaar = headComLists("X015", Yarray(1), outOfDateSince)

            Case "PFN"
                'PFN: Beroep
                headCommentaar = headComLists("X040", Yarray(1), outOfDateSince)

            Case "PER"
                'PER: Period Qualifier=X072, dus...
                headCommentaar = headComLists("X072", Yarray(1), outOfDateSince)

            Case "ROD"
                'ROD: Risico Object=X052
                headCommentaar = headComLists("X052", Yarray(1), outOfDateSince)

            Case Else
                Exit Function
        End Select
        TB2commentaar = vbTab & "(" & headCommentaar & " " & subCommentaar & Trim(" " & outOfDateSince) & ")"

    End Function
    Function TLBPag2(ByRef BsDef As String) As Integer
        Dim FlInput As Integer
        Dim FFDefinitie As String
        Dim T As Integer

        'On Local Error GoTo 0

        'code= 1 - 1 : Poliskontrole 1 = ON
        '      2 - 3 : Selektiekeuze waarde (ListIDX)
        '      4 - 4 :
        '      5 - 8 : TeleBib
        '      9 - 9 : Volgnummer eventueel 1 tot 9
        '      10    : * voor verplichte invulling
        'Inlaadvolgorde 1 : 000     'hoofddefinitie (VSOFT)
        '               2 : xxxG    'uitbreiding gebruiker
        '               2 : xxxM    'uitbreiding makelaar


        If Dir(ProgramLocation & "Def\" & BsDef & ".Def") = "" Then
            MsgBox("Geen VsoftBib definitie " & BsDef & ".Def")
            Exit Function
        End If

        If Dir(ProgramLocation & "Def\" & BsDef & "U.Def") = "" Then
            GoTo GeenUserDef
        Else
            FlInput = FreeFile()
            T = 0
            FileOpen(FlInput, ProgramLocation & "Def\" & BsDef & "U.Def", OpenMode.Input)
            Do While Not EOF(FlInput)
                Input(FlInput, TeleBibCode(T))
                Input(FlInput, TeleBibTekst(T))
                Input(FlInput, TeleBibType(T))
                Input(FlInput, TeleBibLengte(T))
                T = T + 1
            Loop
            FileClose(FlInput)
            TeleBibCode(T) = ""
            TeleBibLast = T - 1
            TLBPag2 = True
            Exit Function
        End If

GeenUserDef:
        FlInput = FreeFile()
        FileOpen(FlInput, ProgramLocation & "Def\" & BsDef & ".Def", OpenMode.Input)
        T = 0
        Do While Not EOF(FlInput)
            Input(FlInput, TeleBibCode(T))
            Input(FlInput, TeleBibTekst(T))
            Input(FlInput, TeleBibType(T))
            Input(FlInput, TeleBibLengte(T))
            T = T + 1
        Loop
        FileClose(FlInput)
        TeleBibCode(T) = ""

        If Trim(ProducentNummer) = "" Then
        ElseIf Dir(ProgramLocation & "Def\" & BsDef & "M.Def") = "" Then
        Else
            FlInput = FreeFile()
            FileOpen(FlInput, ProgramLocation & "Def\" & BsDef & "M.Def", OpenMode.Input)
            Do While Not EOF(FlInput)
                Input(FlInput, TeleBibCode(T))
                Input(FlInput, TeleBibTekst(T))
                Input(FlInput, TeleBibType(T))
                Input(FlInput, TeleBibLengte(T))
                T = T + 1
            Loop
            FileClose(FlInput)
            TeleBibCode(T) = ""
        End If
        TLBPag2 = True
        Exit Function

TLBError:
        MsgBox("Telebibinlaadfout" & Str(T) & " error:" & ErrorToString())
        FileClose(FlInput)
        TLBPag2 = False
        Exit Function
        Resume

    End Function
    Function TLBPag3(ByRef BsDef As String) As Boolean

        TLBPag3 = False

        Dim FlTemp As Integer
        Dim T As Integer
        'code= 1 - 1 : Poliskontrole 1 = ON
        '      2 - 3 : Selektiekeuze waarde (ListIDX)
        '      4 - 4 :
        '      5 - 8 : TeleBib
        '      9 - 9 : * voor verplichte invulling


        If Dir(ProgramLocation & "Def\" & BsDef & ".Def") = "" Then
            MsgBox("Geen VsoftBib definitie " & BsDef & ".Def")
            Exit Function
        End If

        FlTemp = FreeFile()
        FileOpen(FlTemp, ProgramLocation & "Def\" & BsDef & ".DEF", OpenMode.Input)
        T = 0
        Do While Not EOF(FlTemp)
            Input(FlTemp, TeleBibCode(T))
            Input(FlTemp, TeleBibTekst(T))
            Input(FlTemp, TeleBibType(T))
            Input(FlTemp, TeleBibLengte(T))
            Input(FlTemp, TeleBibPos(T))
            T = T + 1
        Loop
        FileClose(FlTemp)
        TeleBibCode(T) = ""
        TLBPag3 = True

    End Function

    Function rodCheck(ByRef MAPIString As String) As String

        Dim rodArray() As String
        Dim telRod As Short
        Dim rodTmp As String = ""
        Dim rodHier As String

        rodArray = Split(MAPIString, "ROD+")

        For telRod = 1 To UBound(rodArray)
            rodHier = headComLists("X052", Left(rodArray(telRod), 3), "")
            If InStr(rodTmp, rodHier) Then
            Else
                If telRod = UBound(rodArray) Then
                    rodTmp = rodTmp & rodHier
                Else
                    rodTmp = rodTmp & rodHier & "; "
                End If
            End If
        Next
        If rodTmp <> "" Then
            rodCheck = "Verzekerd risico: " & rodTmp
        Else
            rodCheck = ""
        End If

    End Function

    Function icdCheck(ByRef MAPIString As String) As String

        Dim icdArray() As String
        Dim telIcd As Integer
        Dim icdTmp As String = ""
        Dim icdHier As String

        icdArray = Split(MAPIString, "ICD+")

        For telIcd = 1 To UBound(icdArray)
            icdHier = headComLists("X058", Left(icdArray(telIcd), 3), "")
            If InStr(icdTmp, icdHier) Then
            Else
                If telIcd = UBound(icdArray) Then
                    icdTmp = icdTmp & icdHier
                Else
                    icdTmp = icdTmp & icdHier & "; "
                End If
            End If
        Next
        If icdTmp <> "" Then
            icdCheck = "Waarborgen: " & icdTmp
        Else
            icdCheck = ""
        End If

    End Function

    Function ftxCheck(ByRef MAPIString As String) As String

        Dim ftxArray() As String
        Dim telFtx As Short
        Dim ftxTmp As String = ""

        ftxArray = Split(MAPIString, "FTX+018+")

        For telFtx = 1 To UBound(ftxArray)
            ftxTmp = ftxTmp & " " & Left(ftxArray(telFtx), InStr(ftxArray(telFtx), "'") - 1)
        Next

        'checken voor :
        Do While InStr(ftxTmp, ":")
            ftxTmp = Replace(ftxTmp, ":", "")
        Loop

        If ftxTmp <> "" Then
            ftxCheck = "Bericht van de verzekeraar:" & vbCrLf & ftxTmp
        Else
            ftxCheck = ""
        End If

    End Function

    Function ScrLeesBestandAlleTekst(ByRef TekstZelf As String, ByRef Bestandsnaam As String) As Boolean

        On Error Resume Next
        Const ForReading As Integer = 1
        Dim A As Scripting.TextStream

        A = fs.OpenTextFile(Bestandsnaam, ForReading, False, Scripting.Tristate.TristateFalse)
        If Err.Number Then
            TekstZelf = Err.Description
            ScrLeesBestandAlleTekst = False
        Else
            TekstZelf = A.ReadAll
            ScrLeesBestandAlleTekst = True
        End If

    End Function

    Sub EdiFactREKENINGUITTREKSEL(ByRef UserArea As String)
        Dim ddag As String
        Dim Bedrag0 As Short
        Dim Tel As Short

        Dim VBestand, Infolijn, Bestand, iolijn As String
        Dim PolisNummer As String
        Dim FlBestand, Operatie As Short
        Dim HuidigeBM As String
        Dim Dummy As String
        Dim fKtrl As Short
        Dim InfoTekst As String
        Dim DCBedrag As Decimal
        Dim MaandVerwerkingTermijn As Short
        Dim BoekjaarKontroleTermijn As String
        Dim BorderelTxt As String
        Dim Datum2000 As String

        Dim Bedrag9 As Decimal
        Dim BedragPremie As String

        Dim MaskerHier As String
        Dim Xarray() As String
        Dim XGHarray() As String
        Dim MOAarray() As String
        Dim PTYarray() As String

        Dim boekLijn As String

        Dim Telhier As Short
        Dim Teljaar As Short
        Dim LijnTeller As Short
        Dim Maatschappij As String
        Dim MaandVerwerking As String
        Dim BoekjaarKontrole As String
        Dim TempoNaamKlant As String
        Dim HuidigeIndex As String
        Dim DatumKwijting As String
        Dim DagKwijting As String
        Dim MaandKwijting As String

        Dim PolisTeWijzigen As Boolean
        Dim DagKtrl1 As String
        Dim DagKtrl2 As String

        'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        'GoSub ruInitialiseren
        Xarray = Split(UserArea, "'")
        '		XGHarray = Split(Xarray(0), "+")
        '		Maatschappij = VB6.Format(Val(XGHarray(2)), "0000")

        '		blLogging = True
        '		boekLijn = ""
        '		If bhEuro Then
        '			MaskerHier = "######0.00"
        '		Else
        '			MaskerHier = "#########0"
        '		End If

        '		BorderelTxt = ""
        '		GridText = ""
        '		MaandVerwerkingTermijn = 0

        '		LijnTeller = 0
        '		For Telhier = 0 To UBound(Xarray) - 1
        '			Select Case Left(Xarray(Telhier), 3)
        '				Case "LIN" 'Volgende verrichting
        '					'eerst kijken of men niet reeds bezig is met een boekingslijn !
        '					If boekLijn <> "" Then
        '						'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '						GoSub ruWegschrijven
        '					End If
        '					LijnTeller = LijnTeller + 1
        '					boekLijn = Mid(Xarray(Telhier), 5, 3) & vbTab
        '					Select Case Mid(Xarray(Telhier), 5, 3)
        '						Case "001" 'Termijnhernieuwingen
        '						Case "009" 'Betaling

        '							'Voorlopig enkel de commissies boeken !
        '						Case "006" 'Commissie inning maatschappij
        '							boekLijn = boekLijn & DatumKwijting & vbTab

        '						Case Else
        '							SnelHelpPrint("Nog geen controle voor " & Mid(Xarray(Telhier), 5, 3), blLogging)
        '					End Select

        '				Case "DTM"
        '					'Alleen datum uittreksel interesseert ons
        '					If Left(Xarray(Telhier), 8) = "DTM+069:" Then
        '						'datum documentlijn
        '						DatumKwijting = Mid(Xarray(Telhier), 9)
        '						MaandKwijting.Value = Mid(DatumKwijting, 3, 2)
        '						MaandVerwerking.Value = MaandKwijting.Value
        '						BoekjaarKontrole.Value = Mid(DatumKwijting, 5, 4)
        '						DatumKwijting = Mid(DatumKwijting, 1, 2) & "/" & Mid(DatumKwijting, 3, 2) & "/" & Mid(DatumKwijting, 5, 4)
        '					End If

        '				Case "RFF"
        '					'Voorlopig alleen nodig voor de commissies
        '					If Left(Xarray(Telhier), 8) = "RFF+001:" Then
        '						PolisNummer.Value = Mid(Xarray(Telhier), 9)
        '					End If

        '				Case "MOA"
        '					MOAarray = Split(Xarray(Telhier), ":")
        '					Select Case Mid(MOAarray(0), 5, 3)
        '						Case "083"
        '							'beginsaldo Debet ?

        '						Case "084"
        '							'beginsaldo Credit ?

        '						Case "087"
        '							'Totaal bedrag premies (+) ?
        '							'Totaal bedrag betaling (-) ?

        '						Case "088"
        '							'Commissiebedrag (+) = Credit ?
        '							If MOAarray(2) = "EUR" Then
        '								If CDbl(MOAarray(3)) = 2 Then
        '									Bedrag9 = Val(MOAarray(1)) / 100
        '								ElseIf CDbl(MOAarray(3)) = 4 Then 
        '									Bedrag9 = Val(MOAarray(1)) / 10000
        '								ElseIf CDbl(MOAarray(3)) = 0 Then 
        '									MsgBox("stop")
        '									Bedrag9 = Val(MOAarray(1))
        '								Else
        '									MsgBox("Stop")
        '								End If
        '							ElseIf MOAarray(2) = "BEF" Then 
        '								Bedrag9 = Val(MOAarray(1))
        '							Else
        '								MsgBox("Stop")
        '							End If

        '						Case "MOA+012" 'Totale premie

        '						Case Else
        '							SnelHelpPrint("MOA-stop voor " & MOAarray(0), blLogging)
        '					End Select

        '				Case "NME"
        '					TempoNaamKlant = Mid(Xarray(Telhier), 9)

        '				Case "PTY"
        '					PTYarray = Split(Xarray(Telhier), "+")
        '					If PTYarray(1) = "006" Then
        '						SnelHelpPrint("maatschappij info" & Xarray(Telhier), blLogging)
        '						Maatschappij = VB6.Format(Val(PTYarray(2)), "0000")
        '					End If


        '				Case "ATT", "XRH", "XRT", "XEH", "XET", "XGH", "XGT", "GIS"
        '					'voorlopig over te slaan...

        '				Case Else
        '					SnelHelpPrint("nog niets voorzien voor " & Left(Xarray(Telhier), 3), blLogging)
        '			End Select
        '		Next 

        '		'vervolgen met afsluiting rekeninguittreksel

        '		Dim PeriodeVoor As String
        '		Dim KtrlFlag As Short

        '		If Len(boekLijn) > 5 Then
        '			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '			GoSub ruWegschrijven
        '		End If

        '		If GridText = "" Then
        '			SnelHelpPrint("Er zijn geen commissielonen te boeken", blLogging)
        '		Else
        '			'BJPERDAT!Boekjaar.ListIndex = 0
        '			PeriodeVoor = BoekjaarKontrole.Value & MaandVerwerking.Value
        '			'If PeriodeVoor < Left(BookyearFromTo, 6) Then
        '			'    If BJPERDAT!Boekjaar.ListCount > 1 Then
        '			'        BJPERDAT!Boekjaar.ListIndex = 1
        '			'    End If
        '			'End If
        '			KtrlFlag = False
        '			For Teljaar = 0 To 1
        '				CType(BJPERDAT.Controls("Boekjaar"), Object).SelectedIndex = Teljaar
        '				For Tel = 0 To CType(BJPERDAT.Controls("PeriodeBoekjaar"), Object).Items.Count - 1
        '					CType(BJPERDAT.Controls("PeriodeBoekjaar"), Object).SelectedIndex = Tel
        '					If PeriodeVoor >= Left(PeriodFromTo.Value, 6) And PeriodeVoor <= Mid(PeriodFromTo.Value, 9, 6) Then
        '						'JetTableClose 99
        '						KwijtingBoeken.Close()
        '						GridTextIs = "006" & vbTab & Maatschappij & vbTab & "Commissies"
        '						blLogging = False
        '						KwijtingBoeken.ShowDialog()
        '						GridText = ""
        '						KtrlFlag = True
        '						Exit For
        '					End If
        '				Next 
        '				If KtrlFlag = True Then
        '					Exit For
        '				End If
        '			Next 
        '			If KtrlFlag = False Then
        '				MsgBox("Gebruikersfout.  Vermoedelijk is een Nieuw boekjaar nog niet beschikbaar !" & vbCrLf & "Manuele inbreng is noodzakelijk... of kies negeren en maak eerst het nieuwe boekjaar aan", MsgBoxStyle.Exclamation)
        '			End If
        '		End If
        '		Exit Sub

        'ruInitialiseren: 
        '		Bedrag9 = 0
        '		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		Return 

        'ruWegschrijven: 
        '		If Left(boekLijn, 3) <> "006" Then
        '			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '			Return 
        '		End If

        '		If bhEuro = True And MOAarray(2) = "EUR" Then
        '			'boekhouding en bericht in EURO, niets te doen
        '		ElseIf bhEuro = False And MOAarray(2) = "BEF" Then 
        '			'boekhouding en bericht in BEF, niets te doen
        '		ElseIf MOAarray(2) = "BEF" Then 
        '			'boekhouding in EURO en bericht in BEF !
        '			Bedrag0 = System.Math.Round(Bedrag9 / Euro, 2)
        '		ElseIf MOAarray(2) = "EUR" Then 
        '			'boekhouding in EURO en bericht in BEF !
        '			Bedrag9 = System.Math.Round(Bedrag9 * Euro)
        '		Else
        '			MsgBox("ONMOGELIJKE SITUATIE")
        '		End If

        '		JetGet(TableOfContracts, 0, PolisNummer.Value)
        '		If Ktrl Then
        '			MsgBox("polis niet aanwezig. EDIFACT nieuw nog in te brengen !!!", MsgBoxStyle.Critical)
        '			TLBRecord(TableOfContracts) = ""
        '			MsgBox("Stop.  Polis bestaat nog niet :" & PolisNummer.Value)
        '			AdoInsertToRecord(TableOfContracts, Mid(iolijn, 23, 2), "v164")
        '			AdoInsertToRecord(TableOfContracts, "NONAME", "A110")
        '			AdoInsertToRecord(TableOfContracts, Maatschappij, "A010")
        '			AdoInsertToRecord(TableOfContracts, PolisNummer.Value, "A000")
        '			AdoInsertToRecord(TableOfContracts, Mid(iolijn, 30, 10), "vs99")
        '			JetInsert(TableOfContracts, 0)
        '			If Ktrl Then
        '				MsgBox("onbekende soldaat ! STOP!!!")
        '			End If
        '			Infolijn = Infolijn & " " & TempoNaamKlant & " aanvullen a.u.b."
        '			Dummy.Value = "Kontroleer !!! " & TempoNaamKlant
        '			As2TelebibIn.UserInfo(3).Text = Str(Val(As2TelebibIn.UserInfo(3).Text) + 1)
        '			ddag = "01"
        '		Else
        '			RecordToField(TableOfContracts)
        '			PolisTeWijzigen = False
        '			DagKtrl1.Value = AdoGetField(TableOfContracts, "#v165 #")
        '			DagKtrl2.Value = Mid(AdoGetField(TableOfContracts, "#AW_2 #"), 7, 2)
        '			If MaandKwijting.Value = AdoGetField(TableOfContracts, "#v164 #") Then
        '			Else
        '				AdoInsertToRecord(TableOfContracts, MaandKwijting.Value, "v164")
        '				PolisTeWijzigen = True
        '			End If
        '			If DagKtrl1.Value = DagKtrl2.Value Then
        '				'alles ok
        '			Else
        '				KtrlBox = MsgBox(DagKtrl2.Value & " correctie vervalDAG", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1)
        '				If KtrlBox = MsgBoxResult.Yes Then
        '					AdoInsertToRecord(TableOfContracts, DagKtrl2.Value, "v165")
        '					PolisTeWijzigen = True
        '				End If
        '			End If
        '			DagKwijting.Value = DagKtrl2.Value
        '			If Maatschappij <> AdoGetField(TableOfContracts, "#A010 #") Then
        '				As2TelebibIn.UserInfo(1).Text = "Maatschappij conflict!  Polis " & PolisNummer.Value & "bestaat reeds bij maatschappij !" & AdoGetField(TableOfContracts, "#A010 #")
        '				AdoInsertToRecord(TableOfContracts, Maatschappij, "A010")
        '				PolisTeWijzigen = True
        '			End If
        '			If PolisTeWijzigen = True Then
        '				bUpdate(TableOfContracts, 0)
        '			End If
        '			As2TelebibIn.UserInfo(2).Text = Str(Val(As2TelebibIn.UserInfo(2).Text) + 1)
        '			JetGet(TableOfCustomers, 0, SetSpacing(AdoGetField(TableOfContracts, "#A110 #"), 12))
        '			If Ktrl Then
        '				Dummy.Value = "Verbeter !!! " & TempoNaamKlant
        '			Else
        '				RecordToField(TableOfCustomers)
        '				Dummy.Value = AdoGetField(TableOfCustomers, "#A100 #")
        '			End If
        '		End If
        '		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '		GoSub ruTeleBibKTRL

        '		GridText = GridText & PolisNummer.Value & vbTab
        '		GridText = GridText & DatumKwijting & vbTab
        '		GridText = GridText & Dec(0, MaskerHier) & vbTab
        '		GridText = GridText & Dec(Bedrag9, MaskerHier) & vbTab
        '		GridText = GridText & Dummy.Value & vbTab
        '		GridText = GridText & SnippetXEH(UserArea, Trim(PolisNummer.Value), False) & vbCr
        '		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '		GoSub ruInitialiseren
        '		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		Return 

        'ruTeleBibKTRL: 
        '		JetGet(TableOfVarious, 1, "25" & Maatschappij & PolisNummer.Value)
        '		If Ktrl Then
        '			TLBRecord(TableOfVarious) = ""
        '		Else
        '			RecordToField(TableOfVarious)
        '		End If

        '		Select Case Mid(iolijn, 42, 1)
        '			Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
        '				'AUTO ?
        '				'If Maatschappij = "0145" And Mid(iolijn, 42, 6) = "000000" Then
        '				'Else
        '				'    AdoInsertToRecord TableOfVarious, "P11", "AW00"
        '				'    AdoInsertToRecord TableOfVarious, "4", "AW06"
        '				'    AdoInsertToRecord TableOfVarious, Str$(Bedrag1 + Bedrag2 + Bedrag3), "AW04"
        '				'    AdoInsertToRecord TableOfVarious, Mid(iolijn, 40, 2), "5315"
        '				'End If
        '		End Select

        '		AdoInsertToRecord(TableOfVarious, Str(Bedrag9), "B014") 'commissieloon
        '		AdoInsertToRecord(TableOfVarious, SetSpacing("K" & AdoGetField(TableOfContracts, "#A110 #"), 13), "v004")
        '		AdoInsertToRecord(TableOfVarious, SetSpacing(AdoGetField(TableOfContracts, "#A110 #"), 12), "A110")
        '		AdoInsertToRecord(TableOfVarious, Maatschappij, "A010")
        '		AdoInsertToRecord(TableOfVarious, PolisNummer.Value, "A000")
        '		AdoInsertToRecord(TableOfVarious, SetSpacing("25" & Maatschappij & PolisNummer.Value, 20), "v005")

        '		If Ktrl Then
        '			JetInsert(TableOfVarious, 1)
        '		Else
        '			bUpdate(TableOfVarious, 1)
        '		End If
        '		If Ktrl Then
        '			MsgBox("Stopkode " & Str(Ktrl))
        '		End If
        '		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		Return 

    End Sub

    Sub EdiFactTERMIJN(ByRef UserArea As String)
        Dim Tel As Short
        Dim ddag As String

        Dim VBestand, Infolijn, Bestand, iolijn As String
        Dim PolisNummer As String
        Dim FlBestand, Operatie As Short
        Dim HuidigeBM As String
        Dim Dummy As String
        Dim fKtrl As Short
        Dim InfoTekst As String
        Dim DCBedrag As Decimal
        Dim MaandVerwerkingTermijn As Short
        Dim BoekjaarKontroleTermijn As String
        Dim BorderelTxt As String
        Dim Datum2000 As String

        Dim Bedrag0 As Decimal
        Dim Bedrag1 As Decimal
        Dim Bedrag2 As Decimal
        Dim Bedrag3 As Decimal
        Dim Bedrag4 As Decimal
        Dim Bedrag5 As Decimal
        Dim Bedrag6 As Decimal
        Dim Bedrag7 As Decimal
        Dim Bedrag8 As Decimal
        Dim Bedrag9 As Decimal
        Dim TotaalNettoPremie As Decimal
        Dim TotaalLasten As Decimal
        Dim BedragPremie As String

        Dim MaskerHier As String
        Dim Xarray() As String
        Dim ATTarray() As String
        Dim XEHarray() As String
        Dim XGHarray() As String
        Dim MOAarray() As String
        Dim DTMarray() As String
        Dim PTYarray() As String
        Dim ftxArray() As String
        Dim FTXTXTarray() As String
        Dim XRHniveau As Short

        Dim Telhier As Short
        Dim LijnTeller As Short
        Dim Maatschappij As String
        Dim MaandVerwerking As String
        Dim BoekjaarKontrole As String
        Dim TempoNaamKlant As String
        Dim HuidigeIndex As String
        Dim DatumKwijting As String
        Dim DagKwijting As String
        Dim MaandKwijting As String

        Dim PolisTeWijzigen As Boolean
        Dim DagKtrl1 As String
        Dim DagKtrl2 As String
        Dim mijWijzigen As Boolean

        mijWijzigen = False
        'Bedrag0 = 0
        'Bedrag1 = 0
        'Bedrag2 = 0
        'Bedrag3 = 0
        'Bedrag4 = 0
        'Bedrag5 = 0
        'Bedrag7 = 0
        'Bedrag8 = 0
        'Bedrag9 = 0
        'HuidigeIndex = ""
        'HuidigeBM.Value = ""
        'Xarray = Split(UserArea, "'")
        'XGHarray = Split(Xarray(0), "+")
        'Maatschappij = VB6.Format(Val(XGHarray(2)), "0000")

        'MaskerHier = "######0.00"
        'BorderelTxt = ""
        'GridText = ""
        'MaandVerwerkingTermijn = 0
        'XRHniveau = 0
        'LijnTeller = 0
        'Dim ftxTeller As Short
        'Dim txtMSG As String
        'txtMSG = ""
        'Dim txtQTY As String
        'txtQTY = ""

        'For Telhier = 0 To UBound(Xarray) - 1
        '	blLogging = True
        '	'Bedrag1 = 0
        '	'Bedrag2 = 0
        '	'Bedrag3 = 0
        '	'Bedrag4 = 0
        '	'Bedrag5 = 0
        '	'Bedrag7 = 0
        '	'Bedrag8 = 0
        '	'Bedrag9 = 0

        '	Select Case Left(Xarray(Telhier), 3)
        '		Case "XEH" 'Volgend dokumentlijntje (codering nog controleren!)
        '			'vb. : XEH+01 = CONTRACT
        '			'vb. : XEH+03 = KWIJTING

        '			LijnTeller = LijnTeller + 1

        '		Case "DTM"
        '			DTMarray = Split(Xarray(Telhier), ":")
        '			If Left(Xarray(Telhier), 8) = "DTM+005:" Then
        '				If Len(DTMarray(1)) = 8 Then
        '					MaandVerwerking.Value = Mid(DTMarray(1), 3, 2)
        '					BoekjaarKontrole.Value = Mid(DTMarray(1), 5, 4)
        '				ElseIf DTMarray(UBound(DTMarray)) = "001" Then 
        '					MaandVerwerking.Value = Mid(Xarray(Telhier), 11, 2) 'boekMAAND
        '					BoekjaarKontrole.Value = Mid(Xarray(Telhier), 13, 4) 'boekJAAR
        '				ElseIf DTMarray(UBound(DTMarray)) = "005" Then 
        '					MaandVerwerking.Value = Mid(Xarray(Telhier), 9, 2) 'boekMAAND
        '					BoekjaarKontrole.Value = Mid(Xarray(Telhier), 11, 4) 'boekJAAR
        '				Else
        '					MsgBox("stoppen en controleren a.u.b")
        '				End If
        '			Else
        '				If Left(Xarray(Telhier), 8) = "DTM+004:" Then
        '					DagKwijting.Value = Mid(DTMarray(1), 1, 2)
        '					MaandKwijting.Value = Mid(DTMarray(1), 3, 2)
        '					DatumKwijting = DagKwijting.Value & "/" & MaandKwijting.Value & "/" & BoekjaarKontrole.Value 'Mid$(DTMarray(1), 5, 4)
        '				ElseIf Left(Xarray(Telhier), 8) = "DTM+041:" Then 
        '					DagKwijting.Value = Mid(DTMarray(1), 1, 2)
        '					MaandKwijting.Value = Mid(DTMarray(1), 3, 2)
        '					DatumKwijting = DagKwijting.Value & "/" & MaandKwijting.Value & "/" & BoekjaarKontrole.Value 'Mid$(DTMarray(1), 5, 4)
        '				End If
        '			End If



        '		Case "RFF"
        '			If Left(Xarray(Telhier), 8) = "RFF+001:" Then
        '				PolisNummer.Value = Mid(Xarray(Telhier), 9)
        '			End If

        '		Case "IND" 'huidige index
        '			If Mid(Xarray(Telhier), 1, 10) = "IND+002+1:" Then
        '				HuidigeIndex = VB6.Format(Val(Mid(Xarray(Telhier), 11, 5)) / 100, "000.00")
        '			Else
        '				HuidigeIndex = VB6.Format(Val(Mid(Xarray(Telhier), 10, 5)) / 100, "000.00")

        '			End If
        '			'MsgBox "index= " & HuidigeIndex, vbInformation

        '		Case "MOA"
        '			MOAarray = Split(Xarray(Telhier), ":")
        '			'WAT MET AUTO ?
        '			'Bedrag1 = Val(kt(Mid$(iolijn, 42, 6))) 'premie B.A. auto
        '			'Bedrag2 = Val(kt(Mid$(iolijn, 48, 5))) 'taksen B.A. auto
        '			'Bedrag3 = Val(kt(Mid$(iolijn, 53, 4))) 'kosten B.A. auto

        '			'Bedrag4 = Val(kt(Mid$(iolijn, 57, 8))) 'andere premie
        '			'Bedrag5 = Val(kt(Mid$(iolijn, 65, 7))) 'taksen+kosten andere
        '			'Bedrag9 = Val(kt(Mid$(iolijn, 72, 7))) 'commissie

        '			'Bedrag7 = Bedrag1 + Bedrag4
        '			'Bedrag8 = Bedrag2 + Bedrag3 + Bedrag5

        '			'WAT MET ANDERE?
        '			'Bedrag7 = Val(kt(Mid$(iolijn, 57, 8))) 'premie
        '			'Bedrag8 = Val(kt(Mid$(iolijn, 65, 7))) 'taksen&kosten
        '			'Bedrag9 = Val(kt(Mid$(iolijn, 72, 7))) 'commissie

        '			Select Case MOAarray(0)
        '				Case "MOA+012" 'Totale premie
        '					If MOAarray(2) = "EUR" Then
        '						If CDbl(Left(MOAarray(3), 1)) = 2 Then
        '							Bedrag0 = Val(MOAarray(1)) / 100
        '						ElseIf CDbl(MOAarray(3)) = 4 Then 
        '							Bedrag0 = Val(MOAarray(1)) / 10000
        '						ElseIf CDbl(MOAarray(3)) = 0 Then 
        '							MsgBox("stop")
        '							Bedrag0 = Val(MOAarray(1))
        '						Else
        '							MsgBox("Stop")
        '						End If
        '					ElseIf MOAarray(2) = "BEF" Then 
        '						Bedrag0 = Val(MOAarray(1))
        '					Else
        '						MsgBox("Stop")
        '					End If

        '				Case "MOA+013" 'netto premie BA auto
        '					If MOAarray(2) = "EUR" Then
        '						If CDbl(Left(MOAarray(3), 1)) = 2 Then
        '							Bedrag1 = Val(MOAarray(1)) / 100
        '						ElseIf CDbl(MOAarray(3)) = 4 Then 
        '							Bedrag1 = Val(MOAarray(1)) / 10000
        '						ElseIf CDbl(MOAarray(3)) = 0 Then 
        '							MsgBox("stop")
        '							Bedrag1 = Val(MOAarray(1))
        '						Else
        '							MsgBox("Stop")
        '						End If
        '					ElseIf MOAarray(2) = "BEF" Then 
        '						Bedrag1 = Val(MOAarray(1))
        '					Else
        '						MsgBox("Stop")
        '					End If
        '					TotaalNettoPremie = Bedrag1

        '				Case "MOA+015" 'commissie
        '					If XRHniveau > 0 Then
        '						SnelHelpPrint("XRHniveau is : " & XRHniveau, blLogging)
        '					Else
        '						If MOAarray(2) = "EUR" Then
        '							If CDbl(Left(MOAarray(3), 1)) = 2 Then
        '								Bedrag9 = Val(MOAarray(1)) / 100
        '							ElseIf CDbl(MOAarray(3)) = 4 Then 
        '								Bedrag9 = Val(MOAarray(1)) / 10000
        '							ElseIf CDbl(MOAarray(3)) = 0 Then 
        '								MsgBox("stop")
        '								Bedrag9 = Val(MOAarray(1))
        '							Else
        '								MsgBox("Stop")
        '							End If
        '						ElseIf MOAarray(2) = "BEF" Then 
        '							Bedrag9 = Val(MOAarray(1))
        '						Else
        '							MsgBox("Stop")
        '						End If
        '					End If


        '				Case "MOA+016" 'Lastenbedrag BA auto
        '					If MOAarray(2) = "EUR" Then
        '						If CDbl(MOAarray(3)) = 2 Then
        '							Bedrag2 = Val(MOAarray(1)) / 100
        '						ElseIf CDbl(MOAarray(3)) = 4 Then 
        '							Bedrag2 = Val(MOAarray(1)) / 10000
        '						ElseIf CDbl(MOAarray(3)) = 0 Then 
        '							MsgBox("stop")
        '							Bedrag2 = Val(MOAarray(1))
        '						Else
        '							MsgBox("Stop")
        '						End If
        '					ElseIf MOAarray(2) = "BEF" Then 
        '						Bedrag2 = Val(MOAarray(1))
        '					Else
        '						MsgBox("Stop")
        '					End If
        '					TotaalLasten = Bedrag2 + Bedrag5

        '				Case "MOA+017" 'Splitsingskosten? + enkel BA auto ?
        '					'MsgBox "nog manueel te controleren, voor AG reeds in orde", vbExclamation
        '					If MOAarray(2) = "EUR" Then
        '						If CDbl(MOAarray(3)) = 2 Then
        '							Bedrag2 = Bedrag2 + Val(MOAarray(1)) / 100
        '						ElseIf CDbl(MOAarray(3)) = 4 Then 
        '							Bedrag2 = Bedrag2 + Val(MOAarray(1)) / 10000
        '						ElseIf CDbl(MOAarray(3)) = 0 Then 
        '							MsgBox("stop")
        '							Bedrag2 = Bedrag2 + Val(MOAarray(1))
        '						Else
        '							MsgBox("Stop")
        '						End If
        '					ElseIf MOAarray(2) = "BEF" Then 
        '						Bedrag2 = Bedrag2 + Val(MOAarray(1))
        '					Else
        '						MsgBox("Stop")
        '					End If
        '					TotaalLasten = Bedrag2 + Bedrag5

        '					'ANDERE DAN AUTO !
        '				Case "MOA+097" 'premie andere waarborgen dan BA auto
        '					If MOAarray(2) = "EUR" Then
        '						If CDbl(MOAarray(3)) = 2 Then
        '							Bedrag4 = Val(MOAarray(1)) / 100
        '						ElseIf CDbl(MOAarray(3)) = 4 Then 
        '							Bedrag4 = Val(MOAarray(1)) / 10000
        '						ElseIf CDbl(MOAarray(3)) = 0 Then 
        '							MsgBox("stop")
        '							Bedrag4 = Val(MOAarray(1))
        '						Else
        '							MsgBox("Stop")
        '						End If
        '					ElseIf MOAarray(2) = "BEF" Then 
        '						Bedrag4 = Val(MOAarray(1))
        '					Else
        '						MsgBox("Stop")
        '					End If

        '				Case "MOA+098" 'taksen en kosten andere dan BA auto
        '					If MOAarray(2) = "EUR" Then
        '						If CDbl(MOAarray(3)) = 2 Then
        '							Bedrag5 = Val(MOAarray(1)) / 100
        '						ElseIf CDbl(MOAarray(3)) = 4 Then 
        '							Bedrag5 = Val(MOAarray(1)) / 10000
        '						ElseIf CDbl(MOAarray(3)) = 0 Then 
        '							MsgBox("stop")
        '							Bedrag5 = Val(MOAarray(1))
        '						Else
        '							MsgBox("Stop")
        '						End If
        '					ElseIf MOAarray(2) = "BEF" Then 
        '						Bedrag5 = Val(MOAarray(1))
        '					Else
        '						MsgBox("Stop")
        '					End If
        '					TotaalLasten = Bedrag2 + Bedrag5

        '				Case "MOA+100" 'Kwitantiekosten
        '					'MsgBox "nog manueel te controleren, voor MAURETUS reeds in orde", vbExclamation
        '					If MOAarray(2) = "EUR" Then
        '						If CDbl(MOAarray(3)) = 2 Then
        '							Bedrag2 = Bedrag2 + Val(MOAarray(1)) / 100
        '						ElseIf CDbl(MOAarray(3)) = 4 Then 
        '							Bedrag2 = Bedrag2 + Val(MOAarray(1)) / 10000
        '						ElseIf CDbl(MOAarray(3)) = 0 Then 
        '							MsgBox("stop")
        '							Bedrag2 = Bedrag2 + Val(MOAarray(1))
        '						Else
        '							MsgBox("Stop")
        '						End If
        '					ElseIf MOAarray(2) = "BEF" Then 
        '						Bedrag2 = Bedrag2 + Val(MOAarray(1))
        '					Else
        '						MsgBox("Stop")
        '					End If
        '					TotaalLasten = Bedrag2 + Bedrag5

        '				Case "MOA+105" 'Andere aan netto premie toe te voegen kosten


        '				Case Else
        '					SnelHelpPrint("MOA-stop voor " & MOAarray(0), blLogging)
        '			End Select

        '		Case "NME"
        '			TempoNaamKlant = Mid(Xarray(Telhier), 9)

        '		Case "ATT"
        '			ATTarray = Split(Xarray(Telhier), "+")
        '			Select Case ATTarray(1)
        '				Case "5300" 'bonus malus
        '					HuidigeBM.Value = ATTarray(2)

        '				Case "B003", "A600"
        '					'ATT+B003+3  =  inning maatschappij vanaf 2008
        '					'ATT+A600+3  =  inning maatschappij tot 2008
        '					If ATTarray(2) = "3" Then 'Inning Maatschappij
        '						SnelHelpPrint("Kwitantie voor polis " & Trim(PolisNummer.Value) & " staat inning Maatschappij", blLogging)
        '						Bedrag0 = 0
        '						Bedrag1 = 0
        '						Bedrag2 = 0
        '						Bedrag3 = 0
        '						Bedrag4 = 0
        '						Bedrag5 = 0
        '						Bedrag7 = 0
        '						Bedrag8 = 0
        '						Bedrag9 = 0
        '						HuidigeIndex = ""
        '						HuidigeBM.Value = ""

        '						Do While Xarray(Telhier) <> "XET+03"
        '							Telhier = Telhier + 1
        '							If Maatschappij = "0097" And Telhier > 250 Then
        '								Exit Do
        '							End If
        '						Loop 
        '					End If
        '			End Select


        '		Case "XET" 'Afsluiten/lijn bewaren
        '			If txtQTY <> "" Then
        '				'totalen termijnen eventueel later gebruiken, nu overslaan
        '				'niks doen dus
        '				txtQTY = ""
        '			Else
        '				Bedrag7 = Bedrag1 + Bedrag4
        '				Bedrag8 = Bedrag2 + Bedrag3 + Bedrag5

        '				'GoSub Wegschrijven
        '				If bhEuro = True And MOAarray(2) = "EUR" Then
        '					'boekhouding en bericht in EURO, niets te doen
        '				ElseIf bhEuro = False And MOAarray(2) = "BEF" Then 
        '					'boekhouding en bericht in BEF, niets te doen
        '				ElseIf MOAarray(2) = "BEF" Then 
        '					'boekhouding in EURO en bericht in BEF !
        '					Bedrag7 = System.Math.Round(Bedrag7 / Euro, 2)
        '					Bedrag8 = System.Math.Round(Bedrag8 / Euro, 2)
        '					Bedrag9 = System.Math.Round(Bedrag9 / Euro, 2)
        '					Bedrag0 = System.Math.Round(Bedrag0 / Euro, 2)

        '				ElseIf MOAarray(2) = "EUR" Then 
        '					'boekhouding in EURO en bericht in BEF !
        '					Bedrag7 = System.Math.Round(Bedrag7 * Euro)
        '					Bedrag8 = System.Math.Round(Bedrag8 * Euro)
        '					Bedrag9 = System.Math.Round(Bedrag9 * Euro)
        '					Bedrag0 = System.Math.Round(Bedrag0 * Euro)
        '				Else
        '					MsgBox("ONMOGELIJKE SITUATIE")
        '				End If

        '				If Bedrag0 = 0 Then
        '					BedragPremie = Dec(Bedrag7 + Bedrag8, MaskerHier)
        '				Else
        '					BedragPremie = Dec(Bedrag0, MaskerHier)
        '					'MsgBox "Totaal premie werd meegegeven: " & BedragPremie
        '				End If
        '				JetGet(TableOfContracts, 0, PolisNummer.Value)
        '				If Ktrl Then
        '					MsgBox("polis niet aanwezig. EDIFACT nieuw nog in te brengen !!!", MsgBoxStyle.Critical)
        '					TLBRecord(TableOfContracts) = ""
        '					MsgBox("Stop.  Polis bestaat nog niet :" & PolisNummer.Value)
        '					AdoInsertToRecord(TableOfContracts, MaandKwijting.Value, "v164")
        '					AdoInsertToRecord(TableOfContracts, "NONAME", "A110")
        '					AdoInsertToRecord(TableOfContracts, Maatschappij, "A010")
        '					AdoInsertToRecord(TableOfContracts, PolisNummer.Value, "A000")
        '					AdoInsertToRecord(TableOfContracts, TempoNaamKlant, "vs99")
        '					JetInsert(TableOfContracts, 0)
        '					If Ktrl Then
        '						MsgBox("onbekende soldaat ! STOP!!!")
        '					End If
        '					Infolijn = Infolijn & " " & TempoNaamKlant & " aanvullen a.u.b."
        '					Dummy.Value = "Kontroleer !!! " & TempoNaamKlant
        '					'As2TelebibIn.UserInfo(3).Caption = Str$(Val(As2TelebibIn.UserInfo(3).Caption) + 1)
        '					ddag = "01"
        '				Else
        '					RecordToField(TableOfContracts)
        '					PolisTeWijzigen = False
        '					DagKtrl1.Value = AdoGetField(TableOfContracts, "#v165 #")
        '					DagKtrl2.Value = Mid(AdoGetField(TableOfContracts, "#AW_2 #"), 7, 2)
        '					If rsMAR(TableOfContracts).Fields("vs97").Value > "2" Then
        '						MsgBox("Polis " & PolisNummer.Value & vbCrLf & "Aktiecode staat op: " & rsMAR(TableOfContracts).Fields("vs97").Value & vbCr & vbCr & "Wordt automatisch op 1 (Post) geplaatst", MsgBoxStyle.Information)
        '						AdoInsertToRecord(TableOfContracts, "1", "vs97")
        '						PolisTeWijzigen = True
        '					End If
        '					If MaandKwijting.Value = AdoGetField(TableOfContracts, "#v164 #") Then
        '					Else
        '						AdoInsertToRecord(TableOfContracts, MaandKwijting.Value, "v164")
        '						PolisTeWijzigen = True
        '					End If
        '					If DagKtrl1.Value = DagKtrl2.Value Then
        '						'alles ok
        '					Else
        '						KtrlBox = MsgBox(DagKtrl2.Value & " correctie vervalDAG", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1)
        '						If KtrlBox = MsgBoxResult.Yes Then
        '							AdoInsertToRecord(TableOfContracts, DagKtrl2.Value, "v165")
        '							PolisTeWijzigen = True
        '						End If
        '					End If
        '					DagKwijting.Value = DagKtrl2.Value
        '					If Maatschappij <> AdoGetField(TableOfContracts, "#A010 #") Then
        '						'As2TelebibIn.UserInfo(1).Caption = "Maatschappij conflict!  Polis " + PolisNummer + "bestaat reeds bij maatschappij !" + AdoGetField(TableOfContracts, "#A010 #")
        '						AdoInsertToRecord(TableOfContracts, Maatschappij, "A010")
        '						PolisTeWijzigen = True
        '					End If
        '					If PolisTeWijzigen = True Then
        '						bUpdate(TableOfContracts, 0)
        '					End If
        '					'As2TelebibIn.UserInfo(2).Caption = Str$(Val(As2TelebibIn.UserInfo(2).Caption) + 1)
        '					JetGet(TableOfCustomers, 0, SetSpacing(AdoGetField(TableOfContracts, "#A110 #"), 12))
        '					If Ktrl Then
        '						Dummy.Value = "Verbeter !!! " & TempoNaamKlant
        '					Else
        '						RecordToField(TableOfCustomers)
        '						Dummy.Value = AdoGetField(TableOfCustomers, "#A100 #")
        '					End If
        '				End If

        '				'GoSub TeleBibKTRL
        '				JetGet(TableOfVarious, 1, "25" & Maatschappij & PolisNummer.Value)
        '				If Ktrl Then
        '					TLBRecord(TableOfVarious) = ""
        '				Else
        '					RecordToField(TableOfVarious)
        '				End If

        '				Select Case Mid(iolijn, 42, 1)
        '					Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
        '						'AUTO ?
        '						'If Maatschappij = "0145" And Mid$(iolijn, 42, 6) = "000000" Then
        '						'Else
        '						'    AdoInsertToRecord TableOfVarious, "P11", "AW00"
        '						'    AdoInsertToRecord TableOfVarious, "4", "AW06"
        '						'    AdoInsertToRecord TableOfVarious, Str$(Bedrag1 + Bedrag2 + Bedrag3), "AW04"
        '						'    AdoInsertToRecord TableOfVarious, Mid$(iolijn, 40, 2), "5315"
        '						'End If
        '				End Select

        '				If Trim(HuidigeIndex) <> "" Then
        '					AdoInsertToRecord(TableOfVarious, HuidigeIndex, "AW.R") 'index
        '				End If
        '				If Trim(HuidigeBM.Value) <> "" Then
        '					'Debug.Assert False
        '					AdoInsertToRecord(TableOfVarious, HuidigeBM.Value, "5315")
        '					AdoInsertToRecord(TableOfVarious, HuidigeBM.Value, "5300")
        '				End If
        '				AdoInsertToRecord(TableOfVarious, Str(Bedrag7 + Bedrag8), "B010") 'premie taksen en kosten inbegrepen
        '				AdoInsertToRecord(TableOfVarious, Str(Bedrag8), "B011") 'taksen en kosten
        '				AdoInsertToRecord(TableOfVarious, Str(Bedrag7), "B013") 'premie zonder taksen en kosten
        '				AdoInsertToRecord(TableOfVarious, Str(Bedrag9), "B014") 'commissieloon
        '				AdoInsertToRecord(TableOfVarious, SetSpacing("K" & AdoGetField(TableOfContracts, "#A110 #"), 13), "v004")
        '				AdoInsertToRecord(TableOfVarious, SetSpacing(AdoGetField(TableOfContracts, "#A110 #"), 12), "A110")
        '				AdoInsertToRecord(TableOfVarious, Maatschappij, "A010")
        '				AdoInsertToRecord(TableOfVarious, PolisNummer.Value, "A000")
        '				AdoInsertToRecord(TableOfVarious, SetSpacing("25" & Maatschappij & PolisNummer.Value, 20), "v005")

        '				If Ktrl Then
        '					JetInsert(TableOfVarious, 1)
        '				Else
        '					bUpdate(TableOfVarious, 1)
        '				End If
        '				If Ktrl Then
        '					MsgBox("Stopkode " & Str(Ktrl))
        '				End If

        '				On Error Resume Next
        '				Mid(DatumKwijting, 1, 2) = DagKwijting.Value
        '				GridText = GridText & PolisNummer.Value & vbTab
        '				GridText = GridText & DatumKwijting & vbTab
        '				GridText = GridText & BedragPremie & vbTab
        '				GridText = GridText & Dec(Bedrag9, MaskerHier) & vbTab
        '				GridText = GridText & Dummy.Value & vbTab & SnippetXEH(UserArea, Trim(PolisNummer.Value), False) & vbTab & Str(TotaalNettoPremie) & vbTab & Str(TotaalLasten) & vbCr
        '				Bedrag0 = 0
        '				Bedrag1 = 0
        '				Bedrag2 = 0
        '				Bedrag3 = 0
        '				Bedrag4 = 0
        '				Bedrag5 = 0
        '				Bedrag7 = 0
        '				Bedrag8 = 0
        '				Bedrag9 = 0
        '				HuidigeIndex = ""
        '				HuidigeBM.Value = ""
        '			End If
        '		Case "XRH"
        '			XRHniveau = XRHniveau + 1

        '		Case "XRT"
        '			XRHniveau = XRHniveau - 1

        '		Case "PTY"
        '			'Maatschappij = Format(Val(XGHarray(2)), "0000")
        '			PTYarray = Split(Xarray(Telhier), "+")
        '			If PTYarray(1) = "006" Then
        '				If LijnTeller = 1 Then
        '					If VB6.Format(Val(PTYarray(2)), "0000") <> Maatschappij Then
        '						If MsgBox("Maatschappijcode wijzigen" & vbCr & vbCr & VB6.Format(Val(PTYarray(2)), "0000") & " <> " & Maatschappij, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1) = MsgBoxResult.Yes Then
        '							Maatschappij = VB6.Format(Val(PTYarray(2)), "0000")
        '							mijWijzigen = True
        '						Else
        '							mijWijzigen = False
        '						End If
        '					End If
        '				ElseIf mijWijzigen = True Then 
        '					If VB6.Format(Val(PTYarray(2)), "0000") <> Maatschappij Then
        '						Maatschappij = VB6.Format(Val(PTYarray(2)), "0000")
        '					End If
        '				End If
        '			End If

        '		Case "IPD"
        '			'voorlopig over te slaan...

        '		Case "FTX"
        '			'ftxArray = Split(Xarray(Telhier), "+")
        '			'If ftxArray(1) = "018" Then 'infobericht?
        '			'    FTXTXTarray = Split(ftxArray(2), ":")
        '			'    txtMSG = ""
        '			'    For ftxTeller = 0 To UBound(FTXTXTarray) - 1
        '			'        txtMSG = txtMSG & FTXTXTarray(ftxTeller) & vbCrLf
        '			'    Next
        '			'    'MsgBox txtMSG, , "FTX 018"
        '			'ElseIf ftxArray(1) = "019" Then
        '			'    txtMSG = ftxArray(2)
        '			'    MsgBox txtMSG, , "FTX 019"
        '			'Else
        '			'    MsgBox "FTX type anders dan 019: " & ftxArray(1)
        '			'End If

        '		Case "QTY"
        '			txtQTY = Xarray(Telhier)
        '			MsgBox(txtQTY)
        '	End Select
        '	'Stop

        'Next 

        'Dim PeriodeVoor As String
        'Dim KtrlFlag As Short

        'If GridText = "" Then
        'Else
        '	CType(BJPERDAT.Controls("Boekjaar"), Object).SelectedIndex = 0
        '	PeriodeVoor = BoekjaarKontrole.Value & MaandVerwerking.Value
        '	If PeriodeVoor < Left(BookyearFromTo.Value, 6) Then
        '		If CType(BJPERDAT.Controls("Boekjaar"), Object).Items.Count > 1 Then
        '			CType(BJPERDAT.Controls("Boekjaar"), Object).SelectedIndex = 1
        '		End If
        '	End If
        '	KtrlFlag = False
        '	For Tel = 0 To CType(BJPERDAT.Controls("PeriodeBoekjaar"), Object).Items.Count - 1
        '		CType(BJPERDAT.Controls("PeriodeBoekjaar"), Object).SelectedIndex = Tel
        '		If PeriodeVoor >= Left(PeriodFromTo.Value, 6) And PeriodeVoor <= Mid(PeriodFromTo.Value, 9, 6) Then
        '			'JetTableClose 99
        '			KwijtingBoeken.Close()
        '			GridTextIs = "001" & vbTab & Maatschappij & vbTab & "Termijn"
        '			blLogging = False
        '			KwijtingBoeken.ShowDialog()
        '			GridText = ""
        '			KtrlFlag = True
        '			Exit For
        '		End If
        '	Next 
        '	If KtrlFlag = False Then
        '		MsgBox("Grote gebruikersfout.  Nieuw boekjaar nog niet beschikbaar !" & vbCrLf & "Manuele inbreng is noodzakelijk...")
        '	End If
        'End If

    End Sub

End Module