Module modMIM
    Sub AutoLoadCompany(BYPERDAT)
        Dim destpath As String
        Dim X As Short
        Dim ptel As Short
        Dim ktrlfl As Short
        Dim T As Short
        Dim FlTemp As Integer
        Dim FlTemp2 As Integer
        Dim AktievePeriode As Short
        Dim XX As String = ""
        Dim YY As String
        Dim Titel As String
        Dim AT As String

        XisEUROWasBEF = False
        Static ProducentKopij As String

        Err.Clear()
        On Error Resume Next

        'Menuopties toegang geven
        Mim.SystemToolStrip.Enabled = True
        Mim.SheetsToolStrip.Enabled = True
        Mim.DocumentToolStrip.Enabled = True
        Mim.AccountingToolStrip.Enabled = True
        If Trim(AGENT_NUMBER) = "" Then
        Else
            Mim.InsuranceBrokerToolStrip.Enabled = True
        End If

        'For COUNT_TO = 1 To 5
        ' Mim.MenuTitel(COUNT_TO).Enabled = True
        ' Next
        ' For T = 1 To 4
        ' BASIC(T).Enabled = True
        ' Next
        ' Mim.Basis(11).Enabled = True

        BYPERDAT.Hide()
        BYPERDAT.DatumVerwerking.Value = MIM_GLOBAL_DATE
        BYPERDAT.PeriodeBoekjaar.Items.Clear()

        Dim c As String = ""
        Dim actiefBJ() As String
        Dim periodesBJ() As String


        Err.Clear()
        On Error GoTo 0

        FlTemp = FreeFile()

        Dim fullPath = LOCATION_COMPANYDATA & "9999.OXT"
        Dim FlFree As Integer

ProbeerNogEens:
        If Dir(fullPath) = "" Then
            MsgBox("9999.OXT niet te vinden in " & LOCATION_COMPANYDATA)
            FlFree = FreeFile()
            FileOpen(FlFree, fullPath, OpenMode.Output)
            PrintLine(FlFree, "0,2016,6")
            FileClose(FlFree)
            GoTo ProbeerNogEens
        Else
            FileOpen(FlTemp, fullPath, OpenMode.Input)
            If Err.Number Then
                MsgBox(Err.Description & vbCrLf & fullPath)
            Else
                c = LineInput(FlTemp)
                FileClose(FlTemp)
            End If
            actiefBJ = Split(c, ",")
        End If

        ACTIVE_BOOKYEAR = Val(actiefBJ(0))
        For COUNT_TO = 9 To 0 Step -1
            If Dir(LOCATION_COMPANYDATA & "DEF" & Format(COUNT_TO, "00") & ".OXT") <> "" Then
                FlTemp2 = FreeFile()
                FileOpen(FlTemp2, LOCATION_COMPANYDATA & "DEF" & Format(COUNT_TO, "00") & ".OXT", OpenMode.Input)
                c = LineInput(FlTemp2)
                'periodesBJ = Split(c, ",")
                XX = Left(c, 4)
                FileClose(FlTemp2)
                BYPERDAT.Boekjaar.Items.Insert(0, XX)
            End If
        Next

        AktievePeriode = Val(actiefBJ(2))
        BYPERDAT.Boekjaar.SelectedIndex = ACTIVE_BOOKYEAR
        JET_TABLENAME(TABLE_COUNTERS) = "jr" & BYPERDAT.Boekjaar.Text

        FlTemp = FreeFile()
        FileOpen(FlTemp, LOCATION_COMPANYDATA & "DEF" & Format(ACTIVE_BOOKYEAR, "00") & ".OXT", OpenMode.Input)
        c = LineInput(FlTemp)
        periodesBJ = Split(c, ",")
        FileClose(FlTemp)

        For T = 0 To UBound(periodesBJ)
            A = periodesBJ(T)
            If T = 0 Then
                BOOKYEAR_FROMTO = Left(A, 8)
            End If
            If T = UBound(periodesBJ) Then
                BOOKYEAR_FROMTO = BOOKYEAR_FROMTO + Right(A, 8)
            End If

            If A = Space(16) Then
                BYPERDAT.PeriodeBoekjaar.SelectedIndex = 0
                YY = BYPERDAT.PeriodeBoekjaar.Text
                BOOKYEAR_FROMTO = Mid(YY, 7, 4) & Mid(YY, 4, 2) & Mid(YY, 1, 2) & Mid(XX, 20, 4) & Mid(XX, 17, 2) & Mid(XX, 14, 2)
                Exit For
            Else
                XX = Mid(A, 7, 2) & "/" & Mid(A, 5, 2) & "/" & Left(A, 4) & " - " & Right(A, 2) & "/" & Mid(A, 13, 2) & "/" & Mid(A, 9, 4)
                BYPERDAT.PeriodeBoekjaar.Items.Add(XX)
            End If
        Next


        If AktievePeriode - 1 > BYPERDAT.PeriodeBoekjaar.Items.Count Then
            MsgBox("Het hoogste boekjaar wordt automatisch ingeladen.  Laatste bewerking gebeurde in een boekjaar met meer periodes dan nu mogelijk.  De eerste periode van het hoogste boekjaar wordt hierna automatisch geaktiveerd")
            AktievePeriode = 1
        End If
        BYPERDAT.PeriodeBoekjaar.SelectedIndex = AktievePeriode - 1
        AT = BYPERDAT.PeriodeBoekjaar.Text
        PERIOD_FROMTO = Mid(AT, 7, 4) & Mid(AT, 4, 2) & Left(AT, 2) & Right(AT, 4) & Mid(AT, 17, 2) & Mid(AT, 14, 2)
        FileClose(FlTemp)

        AD_NTDB = New ADODB.Connection

        On Error Resume Next
        Err.Clear()
        ' voor JET
        'NT_DB = NT_SPACE.OpenDatabase(LOCATION_COMPANYDATA & LOCATION_NETDATA & "marnt.MDV", False, False)
        BA_MODUS = 1
        JET_CONNECT = ADOJET_PROVIDER & "Data Source=" & LOCATION_COMPANYDATA & LOCATION_NETDATA & "\marnt.mdv;" & "Persist Security Info=False"
        AD_NTDB.Open(JET_CONNECT)

        If String99(READING, 20) = "5" Then
            Mim.InsuranceBrokerToolStrip.Enabled = True
            AGENT_NUMBER = "60423"
        Else
            AGENT_NUMBER = ""
        End If

        If Len(Trim(String99(READING, 296))) = 0 Then
            MsgBox("Gelieve Setup Boekingen en algemene instellingen : munt van de Boekhouding in te stellen a.u.b.  Pér bedrijf, pér boekjaar.  Hierna wordt voorlopig verder gewerkt in EUR.")
            BH_EURO = True
            SS99("EUR", 296)

        ElseIf String99(READING, 296) = "BEF" Then
            BH_EURO = False
        ElseIf String99(READING, 296) = "EUR" Then
            BH_EURO = True
            'MsgBox(String99(READING, 296))
        Else
            BH_EURO = False
        End If
        If BH_EURO = False Then
            MsgBox("Hoogste boekjaar enkel nog in EUR vanaf versie 6.5.301 of hoger.  Indien U nog BEF verrichtingen wenst uit te voeren, gelieve een eerdere versie opnieuw te installeren a.u.b.", MsgBoxStyle.Information)
            End
        End If
        BYPERDAT.MdiParent = Mim
        BYPERDAT.Enabled = True
        BYPERDAT.Visible = True
        BYPERDAT.WindowState = FormWindowState.Minimized
        BYPERDAT.Show()

        CUSTOMERS_SHEET.Enabled = True
        SUPPLIERS_SHEET.Enabled = True
        LEDGERACCOUNTS_SHEET.Enabled = True

        RS_JOURNAL = New ADODB.Recordset
        If NT_DB.Connect <> "" Then
            RS_JOURNAL.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Else
            RS_JOURNAL.CursorLocation = ADODB.CursorLocationEnum.adUseServer
        End If
        RS_JOURNAL.Open("SELECT TOP 1 * FROM Journalen", AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)

        Exit Sub


ErrorOpvang:
        MsgBox(VBC(ktrlfl, ptel) & " " & ErrorToString())
        Resume Next

    End Sub

    Sub AutoUnloadCompany(BJPERDAT)
        Dim T As Short
        Dim LastUsed As String

        KTRL = 100
        BJPERDAT.Close()
        'TODO:CloseOpenWindows()

        '2. Tabellen sluiten
        JetTableClose(99)

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        On Error Resume Next
        RS_JOURNAL.Close()
        RS_JOURNAL = Nothing

        For COUNT_TO = TABLE_VARIOUS To TABLE_CONTRACTS
            RS_MAR(COUNT_TO).Close()
        Next

        'Menuopties beperken
        Mim.SystemToolStrip.Enabled = False
        Mim.SheetsToolStrip.Enabled = False
        Mim.DocumentToolStrip.Enabled = False
        Mim.AccountingToolStrip.Enabled = False
        Mim.InsuranceBrokerToolStrip.Enabled = False

        'For COUNT_TO = 1 To 6
        'TODO
        'Mim.MenuTitel(COUNT_TO).Enabled = False
        'Next

        With CUSTOMERS_SHEET
            .Enabled = False
            .WindowState = System.Windows.Forms.FormWindowState.Minimized
        End With
        With SUPPLIERS_SHEET
            .Enabled = False
            .WindowState = System.Windows.Forms.FormWindowState.Minimized
        End With
        With LEDGERACCOUNTS_SHEET
            .Enabled = False
            .WindowState = System.Windows.Forms.FormWindowState.Minimized
        End With
        With BJPERDAT
            .Close()
        End With
        'TODO: Mim.AV(11).Enabled = False
        'TODO: Mim.Basis(11).Enabled = False

        LOCATION_COMPANYDATA = LOCATION
        Mim.Text = My.Application.Info.Title
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        FileClose()
        LOCATION_COMPANYDATA = ""

    End Sub

    Function InitTables() As Boolean
        Dim T As Integer

        InitTables = True
        FL_NUMBEROFINDEXEN(TABLE_VARIOUS) = 1
        JETTABLEUSE_INDEX(TABLE_VARIOUS, 0) = "v004 " : FLINDEX_LEN(TABLE_VARIOUS, 0) = 13 : FLINDEX_CAPTION(TABLE_VARIOUS, 0) = "Partij"
        JETTABLEUSE_INDEX(TABLE_VARIOUS, 1) = "v005 " : FLINDEX_LEN(TABLE_VARIOUS, 1) = 20 : FLINDEX_CAPTION(TABLE_VARIOUS, 1) = "SPtype"

        FL_NUMBEROFINDEXEN(TABLE_CUSTOMERS) = 1
        JETTABLEUSE_INDEX(TABLE_CUSTOMERS, 0) = "A110 " : FLINDEX_LEN(TABLE_CUSTOMERS, 0) = 12 : FLINDEX_CAPTION(TABLE_CUSTOMERS, 0) = "Nummer"
        JETTABLEUSE_INDEX(TABLE_CUSTOMERS, 1) = "A100 " : FLINDEX_LEN(TABLE_CUSTOMERS, 1) = 10 : FLINDEX_CAPTION(TABLE_CUSTOMERS, 1) = "Bedrijfsnaam"

        FL_NUMBEROFINDEXEN(TABLE_SUPPLIERS) = 1
        JETTABLEUSE_INDEX(TABLE_SUPPLIERS, 0) = "A110 " : FLINDEX_LEN(TABLE_SUPPLIERS, 0) = 12 : FLINDEX_CAPTION(TABLE_SUPPLIERS, 0) = "Nummer"
        JETTABLEUSE_INDEX(TABLE_SUPPLIERS, 1) = "A100 " : FLINDEX_LEN(TABLE_SUPPLIERS, 1) = 10 : FLINDEX_CAPTION(TABLE_SUPPLIERS, 1) = "Bedrijfsnaam"

        FL_NUMBEROFINDEXEN(TABLE_LEDGERACCOUNTS) = 1
        JETTABLEUSE_INDEX(TABLE_LEDGERACCOUNTS, 0) = "v019 " : FLINDEX_LEN(TABLE_LEDGERACCOUNTS, 0) = 7 : FLINDEX_CAPTION(TABLE_LEDGERACCOUNTS, 0) = "RekeningNummer"
        JETTABLEUSE_INDEX(TABLE_LEDGERACCOUNTS, 1) = "v020 " : FLINDEX_LEN(TABLE_LEDGERACCOUNTS, 1) = 10 : FLINDEX_CAPTION(TABLE_LEDGERACCOUNTS, 1) = "Omschrijving"

        FL_NUMBEROFINDEXEN(TABLE_PRODUCTS) = 1
        JETTABLEUSE_INDEX(TABLE_PRODUCTS, 0) = "v102 " : FLINDEX_LEN(TABLE_PRODUCTS, 0) = 13 : FLINDEX_CAPTION(TABLE_PRODUCTS, 0) = "Artikelkode EAN"
        JETTABLEUSE_INDEX(TABLE_PRODUCTS, 1) = "v105 " : FLINDEX_LEN(TABLE_PRODUCTS, 1) = 10 : FLINDEX_CAPTION(TABLE_PRODUCTS, 1) = "Omschrijving"

        FL_NUMBEROFINDEXEN(TABLE_JOURNAL) = 4
        JETTABLEUSE_INDEX(TABLE_JOURNAL, 0) = "v070 " : FLINDEX_LEN(TABLE_JOURNAL, 0) = 15 : FLINDEX_CAPTION(TABLE_JOURNAL, 0) = "Rekening Boekdatum"
        JETTABLEUSE_INDEX(TABLE_JOURNAL, 1) = "v033 " : FLINDEX_LEN(TABLE_JOURNAL, 1) = 11 : FLINDEX_CAPTION(TABLE_JOURNAL, 1) = "Dokumentnummer"
        JETTABLEUSE_INDEX(TABLE_JOURNAL, 2) = "v038 " : FLINDEX_LEN(TABLE_JOURNAL, 2) = 8 : FLINDEX_CAPTION(TABLE_JOURNAL, 2) = "Betalingsstuk"
        JETTABLEUSE_INDEX(TABLE_JOURNAL, 3) = "v041 " : FLINDEX_LEN(TABLE_JOURNAL, 3) = 1 : FLINDEX_CAPTION(TABLE_JOURNAL, 3) = "Bewerkingsvlag"
        JETTABLEUSE_INDEX(TABLE_JOURNAL, 4) = "v066 " : FLINDEX_LEN(TABLE_JOURNAL, 4) = 7 : FLINDEX_CAPTION(TABLE_JOURNAL, 4) = "Boekdatum"

        FL_NUMBEROFINDEXEN(TABLE_INVOICES) = 2
        JETTABLEUSE_INDEX(TABLE_INVOICES, 0) = "v033 " : FLINDEX_LEN(TABLE_INVOICES, 0) = 11 : FLINDEX_CAPTION(TABLE_INVOICES, 0) = "DokumentNummer"
        JETTABLEUSE_INDEX(TABLE_INVOICES, 1) = "v034 " : FLINDEX_LEN(TABLE_INVOICES, 1) = 13 : FLINDEX_CAPTION(TABLE_INVOICES, 1) = "Partij"
        JETTABLEUSE_INDEX(TABLE_INVOICES, 2) = "A000 " : FLINDEX_LEN(TABLE_INVOICES, 2) = 12 : FLINDEX_CAPTION(TABLE_INVOICES, 2) = "KontraktNummer"

        FL_NUMBEROFINDEXEN(TABLE_CONTRACTS) = 3
        JETTABLEUSE_INDEX(TABLE_CONTRACTS, 0) = "A000 " : FLINDEX_LEN(TABLE_CONTRACTS, 0) = 12 : FLINDEX_CAPTION(TABLE_CONTRACTS, 0) = "Polisnummer"
        JETTABLEUSE_INDEX(TABLE_CONTRACTS, 1) = "A110 " : FLINDEX_LEN(TABLE_CONTRACTS, 1) = 12 : FLINDEX_CAPTION(TABLE_CONTRACTS, 1) = "Klantkode"
        JETTABLEUSE_INDEX(TABLE_CONTRACTS, 2) = "A010 " : FLINDEX_LEN(TABLE_CONTRACTS, 2) = 4 : FLINDEX_CAPTION(TABLE_CONTRACTS, 2) = "Maatschappij"
        JETTABLEUSE_INDEX(TABLE_CONTRACTS, 3) = "v167 " : FLINDEX_LEN(TABLE_CONTRACTS, 3) = 30 : FLINDEX_CAPTION(TABLE_CONTRACTS, 3) = "MaandKlantMijPolis"

        FL_NUMBEROFINDEXEN(TABLE_COUNTERS) = 0
        JETTABLEUSE_INDEX(TABLE_COUNTERS, 0) = "v071 " : FLINDEX_LEN(TABLE_COUNTERS, 0) = 5 : FLINDEX_CAPTION(TABLE_COUNTERS, 0) = "Setup Parameter"

        FL_NUMBEROFINDEXEN(TABLE_DUMMY) = 0
        JETTABLEUSE_INDEX(TABLE_DUMMY, 0) = "v089 " : FLINDEX_LEN(TABLE_DUMMY, 0) = 20 : FLINDEX_CAPTION(TABLE_DUMMY, 0) = "Plaatselijk sorteren"

        For T = TABLE_VARIOUS To TABLE_COUNTERS
            If TeleBibPage(T) Then
            Else
                MsgBox("Fout tijdens inladen bestandsdefinities.  Herinstalleer het programma en/of kontakteer Vsoft")
                InitTables = False
            End If
        Next
    End Function

    Function SettingsSaving(ByRef frmVenster As System.Windows.Forms.Form) As Boolean

        Err.Clear() : SettingsSaving = True
        SaveSetting(My.Application.Info.ProductName, frmVenster.Name, "Top", frmVenster.Top.ToString)
        SaveSetting(My.Application.Info.ProductName, frmVenster.Name, "Left", frmVenster.Left.ToString)
        SaveSetting(My.Application.Info.ProductName, frmVenster.Name, "Width", frmVenster.Width.ToString)
        SaveSetting(My.Application.Info.ProductName, frmVenster.Name, "Height", frmVenster.Height.ToString)
        If Err.Number Then SettingsSaving = False

    End Function

    Sub SettingsLoading(ByRef frmVenster As System.Windows.Forms.Form)
        Dim valTop As Integer = Val(GetSetting(My.Application.Info.ProductName, frmVenster.Name, "Top"))
        Dim valLeft As Integer = Val(GetSetting(My.Application.Info.ProductName, frmVenster.Name, "Left"))
        Dim valWidth As Integer = Val(GetSetting(My.Application.Info.ProductName, frmVenster.Name, "Width"))
        Dim valHeight As Integer = Val(GetSetting(My.Application.Info.ProductName, frmVenster.Name, "Height"))

        If valTop + valLeft + valWidth + valHeight = 0 Then
        Else
            frmVenster.Top = valTop
            frmVenster.Left = valLeft
            frmVenster.Width = valWidth
            frmVenster.Height = valHeight
        End If
    End Sub

    Function SettingLoading(ByRef Onderdeel As String, ByRef SubDeel As String) As Object

        On Error Resume Next
        If InStr(Onderdeel, ";") Then
            SettingLoading = GetSetting(Left(Onderdeel, InStr(Onderdeel, ";") - 1), Mid(Onderdeel, InStr(Onderdeel, ";") + 1), SubDeel)
        Else
            SettingLoading = GetSetting(My.Application.Info.ProductName, Onderdeel, SubDeel)
        End If

EenFoutBijINLaden:
    End Function

    Sub SettingSaving(ByRef Onderdeel As String, ByRef SubDeel As String, ByRef Element As String)

        SaveSetting(My.Application.Info.ProductName, Onderdeel, SubDeel, Element)

    End Sub

    Sub SS99(ByRef StringInhoud As String, ByRef NummerRec As Short)

        FL99_RECORD = StringInhoud
        SetString99(NummerRec)

    End Sub

    Sub SetString99(ByRef NummerSleutel As Short)
        Dim DummySleutel As String

        DummySleutel = "s" & Format(NummerSleutel, "000") & " "
        JetGet(TABLE_COUNTERS, 0, DummySleutel)
        If KTRL Then
            If BA_MODUS = 1 Then

                TLB_RECORD(TABLE_COUNTERS) = ""
                AdoInsertToRecord(TABLE_COUNTERS, DummySleutel, "v071")
                AdoInsertToRecord(TABLE_COUNTERS, FL99_RECORD, "v217")
                JetInsert(TABLE_COUNTERS, 0)
            Else
                MsgBox("Onlogika btrieve versie !")
            End If
        Else
            RecordToField(TABLE_COUNTERS)
            If BA_MODUS = 1 Then
                AdoInsertToRecord(TABLE_COUNTERS, FL99_RECORD, "v217 ")
                JetUpdate(TABLE_COUNTERS, 0)
                If KTRL Then
                    MsgBox("UpdateStop Teller. kontakteer vsoft")
                End If
            Else
                MsgBox("Onlogika btrieve versie !")
            End If
        End If
        JetTableClose(TABLE_COUNTERS)

    End Sub

    Public Function FieldIsOk(ByRef FlHier As Short, ByRef VeldNaam As String, Optional ByRef VeldDef As String = "") As Integer
        Dim AantalRC As Short

        If RS_MAR(FlHier).State = ADODB.ObjectStateEnum.adStateClosed Then
            KTRL = JetTableOpen(FlHier)
        End If
        On Error Resume Next
        Err.Clear()
        MSG = RS_MAR(FlHier).Fields(VeldNaam).Name
        If Err.Number = 0 Then
            FieldIsOk = Err.Number
            Exit Function
        ElseIf VeldDef = "" Then
            FieldIsOk = Err.Number
            Exit Function
        Else
            JetTableClose(FlHier)
            MSG = "ALTER TABLE " & JET_TABLENAME(FlHier) & " ADD COLUMN " & VeldNaam & " " & VeldDef & ";"
            If MsgBox(MSG & vbCr & vbCr & "SQL-instructie uitvoeren", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Err.Clear()
                AD_NTDB.Execute(MSG, AantalRC)
                If Err.Number Then
                    MsgBox("Foutmelding bron: " & Err.Source & vbCrLf & "Foutkodenummer: " & Err.Number & vbCrLf & vbCrLf & "Foutmelding omschrijving:" & vbCrLf & Err.Description)
                Else
                    MsgBox(MSG & " met succes uitgevoerd", MsgBoxStyle.Information)

                End If
                FieldIsOk = Err.Number
            Else
                FieldIsOk = 99
            End If
        End If

    End Function

    Sub CloseOpenWindows()

        On Error Resume Next

        'SqlSearch.Close()
        'UPGRADE_ISSUE: DoEvents does not return a value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8D115264-E27F-4472-A684-865A00B5E826"'
        'XDO_EVENTS = System.Windows.Forms.Application.DoEvents()
        'Xlog.Close()
        ''UPGRADE_ISSUE: DoEvents does not return a value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8D115264-E27F-4472-A684-865A00B5E826"'
        'XDO_EVENTS = System.Windows.Forms.Application.DoEvents()
        'SetupEnParameters.Close()
        'Afbeeldingen.Close()
        'xDokument.Close()
        'VrijBericht.Close()
        'Unload VoorkeurDefinities
        'Unload ProgrammaStruktuur
        'HistoriekSQL.Close()
        'Unload Importeren
        'SQLLijsten.Close()
        'LayOutDokument.Close()
        'Unload StandaardKostPrijsKaart
        'Venster.Close()
        'DirekteAankoop.Close()
        'Unload DirekteVerkoop
        'DiversePosten.Close()
        'InbrengFinancieel.Close()

    End Sub

    Function TeleBibClick(ByRef Fl As Integer) As Boolean
        Dim PositieX As Integer
        Dim aa As String
        Dim LogTekst As String
        Dim BoxType As Integer
        Dim BoxMask As String = ""
        Dim t As Integer
        Dim CrText As String

        TeleBibClick = False
        Select Case Fl
            Case TABLE_CUSTOMERS To TABLE_CONTRACTS 'Hoofdfiches
                If TeleBibPage(Fl) = False Then
                    Beep()
                    Exit Function
                End If
            Case TABLE_INVOICES 'Aankoop verkoopdokumenten
                If TLBPag2("020" & Left(FVT(TABLE_INVOICES, 0), 1)) = False Then
                    Beep()
                    Exit Function
                End If
            Case 10, 12, 18, 21, 28 'Diverse gebruikersfiches
                If TLBPag2(Format(Fl, "000")) = False Then
                    Beep()
                    Exit Function
                End If
            Case 1000 To 1999 'As1 verzoekdokument
                If TLBPag3("AS1" & Format(Fl - 1000, "000")) = False Then
                    Beep()
                    Exit Function
                End If
            Case 2000 To 2099 'Diverse groepen eigen aan ROELANDT systeem
                If TLBPag2("GROEP" & Format(Fl - 2000, "00")) = False Then
                    Beep()
                    Exit Function
                End If
            Case 3000 To 3099 'Schadedossiers e.a.
                If TLBPag2("SCHADE" & Format(Fl - 3000, "00")) = False Then
                    Beep()
                    Exit Function
                End If
            Case 4000 To 4999 'takkodes
                If TLBPag3("TAK" & Format(Fl - 4000)) = False Then
                    Beep()
                    Exit Function
                End If
            Case Else
                MsgBox("stop in telebibclick, fl=" & Format(Fl))
        End Select

        Select Case Fl
            Case TABLE_CUSTOMERS
                LogTekst = "BIB voor Klanten"
            Case TABLE_SUPPLIERS
                LogTekst = "BIB voor Leveranciers"
            Case TABLE_LEDGERACCOUNTS
                LogTekst = "BIB voor Algemene Rekeningen"
            Case TABLE_PRODUCTS
                LogTekst = "BIB voor Artikels/Diensten"
            Case TABLE_CONTRACTS
                LogTekst = "BIB voor contracten"
            Case TABLE_INVOICES
                LogTekst = "BIB voor Aan- en Verkoopdokumenten"
            Case 1000 To 1999
                Fl = TABLE_VARIOUS
                LogTekst = "BIB AS1/verzoeken"
            Case 2000 To 2099
                Fl = TABLE_VARIOUS
                LogTekst = "BIB Polis " & AdoGetField(TABLE_CONTRACTS, "#A000 #")
            Case 3000 To 3099
                Fl = TABLE_VARIOUS
                LogTekst = "Bib Schade " & AdoGetField(TABLE_VARIOUS, "#C000 #")
            Case 4000 To 4099
                Fl = TABLE_VARIOUS
                LogTekst = "BIB DetailPolis " & AdoGetField(TABLE_CONTRACTS, "#A000 #")
            Case Else
                Fl = TABLE_VARIOUS
                LogTekst = " BIB Allerlei"
        End Select

        FormXlog.Close()
        FormXlog.Dispose()
        FormXlog.Hide()
        FormXlog.Text = FormXlog.Text & LogTekst
        FormXlog.Tag = Str(Fl)
        If Fl = TABLE_INVOICES Then
            If VSF_PRO Then
                FormXlog.BtnEditLine.Enabled = True
                FormXlog.BtnHideAndGoBack.Text = "Speciaal"
            Else
                FormXlog.BtnEditLine.Enabled = False
                FormXlog.BtnHideAndGoBack.Text = "Vernietig!"
            End If
        End If

        'xLog.X.set_ColWidth(0, 45)
        'xLog.X.set_ColWidth(1, 2805)
        'xLog.X.set_ColWidth(2, 6165)
        'xLog.X.set_ColAlignment(0, MSFlexGridLib.AlignmentSettings.flexAlignLeftTop)
        'xLog.X.set_ColAlignment(1, MSFlexGridLib.AlignmentSettings.flexAlignLeftTop)
        'xLog.X.set_ColAlignment(2, MSFlexGridLib.AlignmentSettings.flexAlignLeftTop)
        'xLog.X.Row = 1
        'xLog.X.Col = 2

        Dim codeString As String
        Dim inputString As String
        Dim omsString As String
        Dim tijdelijk As String
        Dim crText2 As String


XLogShow:
        'SetDefault(xLog.WijzigenLijn, True)
        FormXlog.BtnHideAndGoBack.TabStop = True
        XLOG_KEY = ""
        'xLog.SSTab1.TabPages.Item(1).Visible = False

        FormXlog.ShowDialog()
        If XLOG_KEY <> "" Then
            t = 0
            'xLog.X.Col = 2
            Do While Trim(TELEBIB_CODE(t)) <> ""
                Dim itemX As ListViewItem
                itemX = FormXlog.X.Items.Item(t)
                codeString = itemX.SubItems.Item(0).Text
                omsString = itemX.SubItems.Item(1).Text
                inputString = itemX.SubItems.Item(2).Text
                crText2 = inputString
                If Mid(codeString, 10, 1) = "*" And crText2 = "" Then
                    MsgBox("Invoer voor '" & RTrim(omsString) & "'" & vbCrLf & vbCrLf & "is verplicht !", 0, "Vervolledig a.u.b.")
                    GoTo XLogShow
                End If
                t = t + 1
            Loop
            If FormXlog.BtnHideAndGoBack.Text = "Speciaal" Then
                MSG = "Gegevens bestaande fiche wijzigen.  Bent U zeker ?"
                KTRL = MsgBox(MSG, 292)
                If KTRL = 6 Then
                    JetUpdate(Fl, 0)
                End If
            End If
            TeleBibClick = True
        End If

    End Function

    Sub ArrangeDeckChairs(Fl As Integer)

        Dim T As Integer
        Dim CrText As String
        Dim BoxMask As String = ""
        Dim BoxType As Integer

        With FormXlog.X
            .Clear()
            .Columns.Add("vsfKode", 5)
            .Columns.Add("Veldomschrijving", 220)
            .Columns.Add("Veldgegevens", 250)
        End With
        aa = ""
        T = 0
        Do While Trim(TELEBIB_CODE(T)) <> ""
            CrText = AdoGetField(Fl, "#" & Mid(TELEBIB_CODE(T), 5, 5) & "#")
            Select Case Mid(TELEBIB_CODE(T), 2, 2)
                Case "  ", "K ", "L ", "LC", "R ", "R3", "R4", "R6", "R7"
                    'niks
                Case Else
                    Select Case Mid(TELEBIB_CODE(T), 1, 1)
                        Case " "
                            BoxMask = "00"
                            BoxType = 0
                        Case "0" To "9"
                            BoxMask = "000"
                            BoxType = 1
                    End Select
                    If Left(TELEBIB_CODE(T), 1) = "@" Or CrText = "" Then
                    Else
                        CrText = fmarBoxText(Format(Val(Mid(TELEBIB_CODE(T), 1, 3)), BoxMask), "2", CrText) 'hier eventueel taaloptie
                    End If
            End Select
            aa = TELEBIB_CODE(T) & vbTab & TELEBIB_TEXT(T) & vbTab & CrText
            Dim itemHier As New ListViewItem(TELEBIB_CODE(T))
            itemHier.SubItems.Add(TELEBIB_TEXT(T))
            itemHier.SubItems.Add(CrText)
            FormXlog.X.Items.Add(itemHier)
            T = T + 1
        Loop

    End Sub

    Function InOutBox(InfoString As String, TitleString As String, ValueString As String, PasswordString As String) As String
        Dim T As Short
        Dim TT As Short

        On Error GoTo 0

        Dim ToolDef(3) As String
        'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
        FormNtInputBox.Dispose()
        FormNtInputBox.Hide()
        FormNtInputBox.Text = TitleString
        SQL_COMMAND = ""
        If Mid(InfoString, 1, 1) = "@" Then
            FormNtInputBox.BtnReNew.Visible = True
            FormNtInputBox.BtnForward.Visible = True
            FormNtInputBox.BtnBack.Visible = True
            FormNtInputBox.LabelInfo.Visible = True
            Select Case Mid(InfoString, 2, 2)
                Case "00"
                    SQL_COMMAND = "SELECT * FROM ISOLandKodes WHERE ISOLandNummer LIKE '" & Trim(ValueString) & "%';"

                    ReDim ToolDef(3)
                    ToolDef(0) = "00=v149 " 'Landnummer  ISO kode
                    ToolDef(1) = "01=vs03 " 'Munteenheid ISO kode
                    ToolDef(2) = "02=v150 " 'Landkode    ISO kode
                Case "01"
                    SQL_COMMAND = "SELECT * FROM PostKodesWoonplaatsen WHERE PostKode LIKE '" & Trim(ValueString) & "%';"

                    ReDim ToolDef(3)
                    ToolDef(0) = "01=A107 " 'PostKode volgens Postkantoor
                    ToolDef(1) = "02=A108 " 'Plaatsnaam

                Case "02"
                    SQL_COMMAND = "SELECT * FROM PostKodesWoonplaatsen WHERE PlaatsNaam LIKE '" & Trim(ValueString) & "%';"

                    ReDim ToolDef(3)
                    ToolDef(0) = "02=A108 " 'Plaatsnaam
                    ToolDef(1) = "01=A107 " 'PostKode volgens Postkantoor
                Case Else
                    SQL_COMMAND = ""
            End Select
        Else
            FormNtInputBox.BtnReNew.Visible = False
            FormNtInputBox.BtnForward.Visible = False
            FormNtInputBox.BtnBack.Visible = False
            FormNtInputBox.LabelInfo.Visible = False
        End If
        FormNtInputBox.Tag = GRIDTEXT
        If GRIDTEXT = "Edit No" Then
            FormNtInputBox.BtnAccept.Visible = False
            FormNtInputBox.TbTextLine.Enabled = False
            FormNtInputBox.AcceptButton = FormNtInputBox.BtnCancel
        Else
            FormNtInputBox.BtnAccept.Visible = True
            FormNtInputBox.TbTextLine.Enabled = True
            FormNtInputBox.AcceptButton = FormNtInputBox.BtnAccept
        End If
        GRIDTEXT = InfoString
        If Mid(InfoString, 1, 1) = "@" Then
            FormNtInputBox.LabelToolStrip.Text = GRIDTEXT & SQL_COMMAND 'ntInputbox.DefaultData.RecordSource
        Else
            FormNtInputBox.LabelToolStrip.Text = GRIDTEXT
        End If
        FormNtInputBox.TbTextLine.Text = ValueString
        'ntInputbox.TekstInfo.PasswordChar = PasswordString

        FormNtInputBox.ShowDialog()

        Dim AantalRijen As Short
        Dim xLogLines As Integer
        Dim xLogBibHere As String
        Dim toolDefCheck As String
        Dim newInputBoxVariable As String

        If FormNtInputBox.TbTextLine.Text = Chr(255) Then
            InOutBox = ValueString
        Else
            If SQL_COMMAND = "" Then
                InOutBox = FormNtInputBox.TbTextLine.Text
            ElseIf Mid(InfoString, 1, 1) = "@" And FormNtInputBox.TbTextLine.Text = FormNtInputBox.rsInputBoxData.Fields(Val(Mid(ToolDef(0), 1, 2))).Value Then
                Select Case Mid(InfoString, 2, 2)
                    Case "00"
                        AantalRijen = 2
                    Case "01", "02"
                        AantalRijen = 1
                    Case Else
                        MsgBox("Stop")
                End Select

                xLogLines = FormXlog.X.Items.Count
                For T = AantalRijen To 0 Step -1
                    toolDefCheck = Mid(ToolDef(T), 4)

                    For TT = 0 To xLogLines - 1

                        xLogBibHere = Mid(FormXlog.X.Items(TT).SubItems(0).Text, 5, 5)
                        If Trim(xLogBibHere) = Trim(toolDefCheck) Then
                            newInputBoxVariable = Trim(FormNtInputBox.rsInputBoxData.Fields(Val(Mid(ToolDef(T), 1, 2))).Value)
                            FormXlog.X.Items(TT).SubItems(2).Text = newInputBoxVariable
                            Exit For
                        End If
                    Next
                Next
                InOutBox = FormNtInputBox.TbTextLine.Text
                'Else
                'InOutBox = ntInputbox.TekstInfo.Text
                'End If
            End If
        End If
        'TODO: ntInputbox.DefaultData.RecordSource = ""
        Exit Function

ErrInput:
        Beep()
        InOutBox = ValueString
        Exit Function

    End Function

    Function Dec(ByRef fGetal As Double, ByRef fMasker As String) As String

        Dim MaskerLengte As Short
        Dim TempoString As String

        MaskerLengte = Len(fMasker)
        TempoString = Format(fGetal, fMasker)
        If (MaskerLengte - Len(TempoString)) > 0 Then
            TempoString = Space(MaskerLengte - Len(TempoString)) & TempoString
        End If
        If InStr(TempoString, ",") Then
            Mid(TempoString, InStr(TempoString, ","), 1) = "."
        End If
        Dec = TempoString

    End Function

    Function IsDateOk(ByRef fDatum As String, ByRef fVlag As Short) As Boolean

        Dim Dag As String = "  "
        Dim Maand As String = "  "
        Dim Jaar As String = "    "
        Dim gDatum As String
        Dim gPos As Short

        IsDateOk = False
        gDatum = fDatum
        Do While InStr(gDatum, "/")
            gPos = InStr(gDatum, "/")
            gDatum = Left(gDatum, gPos - 1) & Mid(gDatum, gPos + 1)
        Loop

        Select Case fVlag
            Case PERIODAS_TEXT, BOOKYEARAS_TEXT
                Dag = Mid(gDatum, 1, 2)
                Maand = Mid(gDatum, 3, 2)
                Jaar = Mid(gDatum, 5, 4)
            Case PERIODAS_KEY, BOOKYEARAS_KEY
                Jaar = Mid(gDatum, 1, 4)
                Maand = Mid(gDatum, 5, 2)
                Dag = Mid(gDatum, 7, 2)
            Case Else
                MsgBox("Datum onjuist !")
        End Select

        Select Case fVlag
            Case PERIODAS_TEXT, PERIODAS_KEY
                If Jaar & Maand & Dag < Left(PERIOD_FROMTO, 8) Or Jaar & Maand & Dag > Right(PERIOD_FROMTO, 8) Then
                Else
                    IsDateOk = True
                End If
            Case BOOKYEARAS_TEXT, BOOKYEARAS_KEY
                If Jaar & Maand & Dag < Left(BOOKYEAR_FROMTO, 8) Or Jaar & Maand & Dag > Right(BOOKYEAR_FROMTO, 8) Then
                Else
                    IsDateOk = True
                End If
        End Select

    End Function

    Function VValdag(ByRef rDat1 As String, ByRef rvv As String) As String
        Dim adm1 As Short
        Dim irjr43, irdg43, irmd43, avd43 As Short
        On Error GoTo handlerVVDag

        irdg43 = Val(Left(rDat1, 2))
        irmd43 = Val(Mid(rDat1, 4, 2))
        irjr43 = Val(Right(rDat1, 4)) - 1990
        avd43 = Val(rvv)

        If avd43 Then
        Else
            VValdag = rDat1
            Exit Function
        End If

        adm1 = DAYS_IN_MONTH(irmd43)
        While irdg43 + avd43 > adm1
            avd43 = avd43 - (adm1 - irdg43)
            irdg43 = 0
            If irmd43 = 12 Then
                irmd43 = 1
                irjr43 = irjr43 + 1
            Else
                irmd43 = irmd43 + 1
            End If
            adm1 = DAYS_IN_MONTH(irmd43)
        End While

        irdg43 = irdg43 + avd43
        If InStr(UCase(rvv), "E") Then
            irdg43 = adm1
        End If
        VValdag = Format(irdg43, "00") & "/" & Format(irmd43, "00") & "/" & Format(irjr43 + 1990, "0000")
        Exit Function

handlerVVDag:
        VValdag = ""
        Exit Function

    End Function

    Function SleutelDok(ByRef fRecordNr As Short) As String
        Dim VoorLetter As String = "  "

        FL99_RECORD = String99(READING_LOCK, fRecordNr)
        Select Case fRecordNr
            Case 1
                VoorLetter = "A0"
            Case 3
                VoorLetter = "A1"
            Case 11
                VoorLetter = "V0"
            Case 13
                VoorLetter = "V1"
            Case 73
                VoorLetter = "B0"
            Case 59
                VoorLetter = "F0"
            Case 121
                VoorLetter = "Q0"
            Case 188
                VoorLetter = "PF"
            Case Else
                MsgBox("Ongeldige record : " & Str(fRecordNr))
        End Select
        SleutelDok = VoorLetter & Mid(PERIOD_FROMTO, 1, 4) & Format(Val(FL99_RECORD) + 1, "00000")
    End Function

    Function FunctionDateText(ByRef fDatumSleutel As String) As String
        Dim Dag As String = "  "
        Dim Maand As String = "  "
        Dim Jaar As String = "    "

        Dag = Mid(fDatumSleutel, 7, 2)
        Maand = Mid(fDatumSleutel, 5, 2)
        Jaar = Mid(fDatumSleutel, 1, 4)
        FunctionDateText = Dag & "/" & Maand & "/" & Jaar
    End Function

    Function CopyFile(ByRef SourcePath As String, ByRef TargetPath As String, ByRef FileToCopy As String) As Short
        Dim FlCopy1 As Short
        Dim FlCopy2 As Short
        Dim BigChunks As Short
        Dim LeftOver As Short
        Dim inD As Short
        Dim Aantal As Short
        Dim BufferVar As String
        Dim BestandReeks(512) As String

        On Error GoTo CopyError
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        If InStr(FileToCopy, "?") Or InStr(FileToCopy, "*") Then
            Aantal = 1
            'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            BestandReeks(1) = Dir(SourcePath & "\" & FileToCopy)
            If BestandReeks(1) = "" Then
                MsgBox("Stop tijdens het kopieren.  TABLEDEF_ONT niet te vinden: """ & FileToCopy & """", 64, "SETUP")
                GoTo CopyError
            Else
                Do
                    Aantal = Aantal + 1
                    'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
                    BestandReeks(Aantal) = Dir()
                    If BestandReeks(Aantal) = "" Then
                        Aantal = Aantal - 1
                        Exit Do
                    End If
                Loop
            End If
        Else
            BestandReeks(1) = FileToCopy
            Aantal = 1
            If Not FileExists(SourcePath & "\" & FileToCopy) Then
                MsgBox("TABLEDEF_ONT niet te vinden: """ & FileToCopy & """", 64, "SETUP")
                GoTo CopyError
            End If
        End If

        For COUNT_TO = 1 To Aantal

            'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If Dir(TargetPath & "\" & BestandReeks(COUNT_TO)) <> "" Then
                Kill(TargetPath & "\" & BestandReeks(COUNT_TO))
            End If

            FlCopy1 = FreeFile()
            FileOpen(FlCopy1, SourcePath & "\" & BestandReeks(COUNT_TO), OpenMode.Binary)

            FlCopy2 = FreeFile()
            FileOpen(FlCopy2, TargetPath & "\" & BestandReeks(COUNT_TO), OpenMode.Binary)

            BufferVar = New String(" ", 3000)

            BigChunks = LOF(FlCopy1) \ Len(BufferVar)
            LeftOver = LOF(FlCopy1) Mod Len(BufferVar)

            For inD = 1 To BigChunks
                'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
                FileGet(FlCopy1, BufferVar)
                'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
                FilePut(FlCopy2, BufferVar)
            Next

            If LeftOver Then
                BufferVar = ""
                BufferVar = New String(" ", LeftOver)
                'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
                FileGet(FlCopy1, BufferVar)
                'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
                FilePut(FlCopy2, BufferVar)
            End If

            If LOF(FlCopy1) = LOF(FlCopy2) Then
                FileClose(FlCopy1)
                FileClose(FlCopy2)
            Else
                GoTo CopyError
            End If

        Next
        CopyFile = -1
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'

        Exit Function

CopyError:
        MsgBox("Stop tijdens het kopieren van " & FileToCopy & """", 64, "SETUP")
        MsgBox(ErrorToString())
        FileClose(FlCopy1)
        FileClose(FlCopy2)
        CopyFile = False
        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'



    End Function
    '----------------------------------------------------------
    ' Check for the existence of a file by attempting an OPEN.
    '----------------------------------------------------------
    Function FileExists(ByRef path As String) As Short
        Dim X As Short

        X = FreeFile()

        On Error Resume Next
        FileOpen(X, path, OpenMode.Input)
        If Err.Number = 0 Then
            FileExists = True
        Else
            FileExists = False
        End If
        FileClose(X)

    End Function
    Sub CMDVSOFTSPACE(flfree As Short)
        On Error GoTo errorCMDVSOFTSPACE
        Input(flfree, PDF_VSOFT_FROM)
        Input(flfree, PDF_VSOFT_TO)
        Exit Sub

errorCMDVSOFTSPACE:
        MsgBox("CMDVSOFTSPACE foutieve definitie")
    End Sub
    Sub CMDPICTURE(flfree As Short)
        Dim YPOS As Double
        Dim xPos As Double
        Dim YPOS2 As Double
        Dim xPos2 As Double
        Dim pdfBoxPen As Double
        Dim filename As String = ""

        On Error GoTo errorCMDPICTURE
        Input(flfree, xPos)
        Input(flfree, YPOS)
        Input(flfree, xPos2)
        Input(flfree, YPOS2)
        Input(flfree, pdfBoxPen)
        Input(flfree, filename)
        Mim.Report.PictureBestFit = True
        '2.5, 0.5, 19, 2.5
        If Mid(filename, 1, 4) = "[BL]" Then
            filename = LOCATION_COMPANYDATA & Mid(filename, 5)
        ElseIf Mid(filename, 1, 4) = "[PL]" Then
            filename = PROGRAM_LOCATION & Mid(filename, 5)
        End If
        KTRL = Mim.Report.Picture(xPos, YPOS, xPos2, YPOS2, filename)
        Exit Sub

errorCMDPICTURE:
        MsgBox("CMDPICTURE foutieve definitie")
    End Sub
    Sub CMDADRESSPACE(Flfree As Short)
        On Error GoTo errorCMDADRESSPACE
        Input(Flfree, PDF_ADDRESS_XPOS)
        Input(Flfree, PDF_ADDRESS_YPOS)
        Input(Flfree, PDF_ADDRESS_XPOS2)
        Input(Flfree, PDF_ADDRESS_YPOS2) ', adresBox
        'KTRL = Mim.Report.WriteBox(PDF_ADDRESS_XPOS, PDF_ADDRESS_YPOS, PDF_ADDRESS_XPOS2, PDF_ADDRESS_YPOS2, "")
        Exit Sub

errorCMDADRESSPACE:
        MsgBox("CMDADRESSPACE foutieve definitie")
    End Sub
    Sub CMDWRITE(FlFree As Short)
        Dim YPOS As Double
        Dim xPos As Double
        Dim YPOS2 As Double
        Dim xPos2 As Double
        Dim pdfFontSize As Double
        Dim pdfFontName As String = ""
        Dim pdfFontBold As Double
        Dim pdfFontItalic As Double
        Dim pdfFontUnderLine As Double
        Dim pdfColor As Double
        Dim pdfAlign As Double

        Dim textstring As String
        Dim texttmp As String

        On Error GoTo errorCMDWRITE
        Input(FlFree, xPos)
        Input(FlFree, YPOS)
        Input(FlFree, xPos2)
        Input(FlFree, YPOS2)
        Input(FlFree, pdfFontSize)
        Input(FlFree, pdfFontName)
        Input(FlFree, pdfColor)
        Input(FlFree, pdfAlign)
        Input(FlFree, pdfFontBold)
        Input(FlFree, pdfFontItalic)
        Input(FlFree, pdfFontUnderLine)
        textstring = LineInput(FlFree)
        Do
            texttmp = LineInput(FlFree)
            If texttmp = "CMD-ENDWRITE" Then
                Exit Do
            Else
                textstring = textstring & vbCrLf & texttmp
            End If
        Loop
        'Mim.Report.Font = VB6.FontChangeName(Mim.Report.Font, pdfFontName)
        'Mim.Report.Font = VB6.FontChangeSize(Mim.Report.Font, pdfFontSize)
        Mim.Report.SelectFont(pdfFontName, pdfFontSize)
        Mim.Report.TextColor = System.Drawing.ColorTranslator.FromOle(pdfColor)
        Mim.Report.TextBold = pdfFontBold
        Mim.Report.TextItalic = pdfFontItalic
        Mim.Report.TextUnderline = pdfFontUnderLine
        Mim.Report.TextAlignment = pdfAlign
        KTRL = Mim.Report.Write(xPos, YPOS, xPos2, YPOS2, textstring)
        Exit Sub

errorCMDWRITE:
        MsgBox("CMDWRITE foutieve definitie")
    End Sub
    Sub CMDWRITEBOX(FlFree As Short)
        Dim YPOS As Double
        Dim xPos As Double
        Dim YPOS2 As Double
        Dim xPos2 As Double
        Dim pdfFontSize As Double
        Dim pdfFontName As String = ""
        Dim pdfFontBold As Double
        Dim pdfFontItalic As Double
        Dim pdfFontUnderLine As Double
        Dim pdfColor As Double
        Dim pdfAlign As Double

        Dim textstring As String
        Dim texttmp As String

        On Error GoTo errorCMDWRITEBOX
        Input(FlFree, xPos)
        Input(FlFree, YPOS)
        Input(FlFree, xPos2)
        Input(FlFree, YPOS2)
        Input(FlFree, pdfFontSize)
        Input(FlFree, pdfFontName)
        Input(FlFree, pdfColor)
        Input(FlFree, pdfAlign)
        Input(FlFree, pdfFontBold)
        Input(FlFree, pdfFontItalic)
        Input(FlFree, pdfFontUnderLine)
        textstring = LineInput(FlFree)
        Do
            texttmp = LineInput(FlFree)
            If texttmp = "CMD-ENDWRITE" Then
                Exit Do
            Else
                textstring = textstring & vbCrLf & texttmp
            End If
        Loop
        Mim.Report.SelectFont(pdfFontName, pdfFontSize)
        'Mim.Report.Font = VB6.FontChangeName(Mim.Report.Font, pdfFontName)
        'Mim.Report.Font = VB6.FontChangeSize(Mim.Report.Font, pdfFontSize)
        Mim.Report.TextColor = System.Drawing.ColorTranslator.FromOle(pdfColor)
        Mim.Report.TextBold = pdfFontBold
        Mim.Report.TextItalic = pdfFontItalic
        Mim.Report.TextUnderline = pdfFontUnderLine

        Mim.Report.TextAlignment = pdfAlign
        KTRL = Mim.Report.WriteBox(xPos, YPOS, xPos2, YPOS2, textstring)
        Exit Sub

errorCMDWRITEBOX:
        MsgBox("CMDWRITEBOX foutieve definitie")
    End Sub
    Sub CMDPRINT(FLFree As Short, pdfOVSStrook As Double)
        Dim YPOS As Double
        Dim xPos As Double
        Dim pdfFontSize As Double
        Dim pdfFontName As String = ""
        Dim pdfFontBold As Double
        Dim pdfFontItalic As Double
        Dim pdfFontUnderLine As Double
        Dim pdfColor As Double
        Dim textstring As String

        On Error GoTo errorCMDPRINT
        Input(FLFree, xPos)
        Input(FLFree, YPOS)
        Input(FLFree, pdfFontSize)
        Input(FLFree, pdfFontName)
        Input(FLFree, pdfColor)
        Input(FLFree, pdfFontBold)
        Input(FLFree, pdfFontItalic)
        Input(FLFree, pdfFontUnderLine)
        textstring = LineInput(FLFree)
        Mim.Report.SelectFont(pdfFontName, pdfFontSize)
        'Mim.Report.Font = VB6.FontChangeName(Mim.Report.Font, pdfFontName)
        'Mim.Report.Font = VB6.FontChangeSize(Mim.Report.Font, pdfFontSize)
        Mim.Report.TextColor = System.Drawing.ColorTranslator.FromOle(pdfColor)
        Mim.Report.TextBold = pdfFontBold
        Mim.Report.TextItalic = pdfFontItalic
        Mim.Report.TextUnderline = pdfFontUnderLine
        If YPOS > PDF_VSOFT_TO Then
            KTRL = Mim.Report.Print(xPos, YPOS - pdfOVSStrook, textstring)
        Else
            KTRL = Mim.Report.Print(xPos, YPOS, textstring)
        End If
        Exit Sub

errorCMDPRINT:
        MsgBox("CMDPRINT foutieve definitie")
    End Sub

    Function DateWrongFormat(ByRef fDatum As String) As Short
        Dim Dag As Short
        Dim Maand As Short
        Dim Jaar As Short
        If Len(fDatum) <> 10 Then
            DateWrongFormat = True
        Else
            Dag = Val(Mid(fDatum, 1, 2))
            Maand = Val(Mid(fDatum, 4, 2))
            Jaar = Val(Mid(fDatum, 7, 4))
            If Dag < 32 And Dag > 0 And Maand < 13 And Maand > 0 And Jaar > 1985 And Jaar < 2062 Then
                DateWrongFormat = False
            Else
                DateWrongFormat = True
                Beep()
            End If
        End If
    End Function
End Module
