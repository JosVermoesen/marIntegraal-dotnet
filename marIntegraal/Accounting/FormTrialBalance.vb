Option Strict Off
Option Explicit On

Public Class FormTrialBalance

    Dim Line As Integer
    Dim JournalEntriesRS As ADODB.Recordset
    Dim pdfY As Double
    Dim ReportText(5) As String 'Koptekstinfo
    Dim FieldText(20) As String
    Dim ErrorTekst As String

    Dim SubTotalD As Decimal
    Dim SubTotalC As Decimal

    Dim CumulTotalD As Decimal
    Dim CumulTotalC As Decimal

    Dim TotalDebit As Decimal
    Dim TotalCredit As Decimal

    Dim SelectionFromTo As String = Space(16)
    Dim PdfReportTitle As String
    Dim PdfLine As String = Space(128)

    Dim BookYearAccountSolde As String

    Dim FirstPartDone As Boolean
    Dim SecondPartReady As Boolean
    Dim LastLedgerAccount As String
    Dim CheckForMonth As String

    Dim MonthTotalD As Decimal
    Dim MonthTotalC As Decimal
    Dim MonthCumulDC As Decimal
    Dim AccountCumulDC As Decimal
    Dim EndTotalD As Decimal
    Dim EndTotalC As Decimal

    Private Sub FormTrialBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SubTotalD = 0
        SubTotalC = 0
        TotalDebit = 0
        TotalCredit = 0

        SelectionFromTo = BOOKYEAR_FROMTO
        TextBoxProcessingDate.Text = MIM_GLOBAL_DATE
        BookYearAccountSolde = "e" & Format(22 + FormBYPERDAT.Boekjaar.SelectedIndex, "000")

        TextBoxLedgerAccountFrom.Text = CStr(1)
        JetNext(TABLE_LEDGERACCOUNTS, 0, SetSpacing(TextBoxLedgerAccountFrom.Text, 7))
        If KTRL Then
        Else
            RecordToField(TABLE_LEDGERACCOUNTS)
            TextBoxLedgerAccountFrom.Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
        End If

        TextBoxLedgerAccountTo.Text = "7999999"
        JetPrev(TABLE_LEDGERACCOUNTS, 0, SetSpacing(TextBoxLedgerAccountTo.Text, 7))
        If KTRL Then
        Else
            RecordToField(TABLE_LEDGERACCOUNTS)
            TextBoxLedgerAccountTo.Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
        End If

        TextBoxPeriodFromTo.Text = FunctionDateText(Mid(SelectionFromTo, 1, 8)) & " - " & FunctionDateText(Mid(SelectionFromTo, 9))
        CheckRecordSet()

    End Sub

    Private Sub InitializeFields()

        If CheckBoxDetailLedger.CheckState Then
            'REPORT_FIELD(0) = "Nr.Ln"
            'REPORT_TAB(0) = 2

            'REPORT_FIELD(1) = "Datum"
            'REPORT_TAB(1) = 8

            'REPORT_FIELD(2) = "RNummer"
            'REPORT_TAB(2) = 19

            'REPORT_FIELD(3) = "Naam Rekening"
            'REPORT_TAB(3) = 27

            'REPORT_FIELD(4) = "Boekingsomschrijving"
            'REPORT_TAB(4) = 68

            'REPORT_FIELD(5) = "    Debet"
            'REPORT_TAB(5) = 104

            'REPORT_FIELD(6) = "   Credit"
            'REPORT_TAB(6) = 115

            'REPORT_FIELD(7) = "Document"
            'REPORT_TAB(7) = 126
        Else
            REPORT_FIELD(0) = "Nummer"
            REPORT_TAB(0) = 2

            REPORT_FIELD(1) = "Omschrijving Rekening"
            REPORT_TAB(1) = 10

            REPORT_FIELD(2) = "Saldo"
            REPORT_TAB(2) = 51

            REPORT_FIELD(3) = "Maand"
            REPORT_TAB(3) = 65

            REPORT_FIELD(4) = "     Debet"
            REPORT_TAB(4) = 76

            REPORT_FIELD(5) = "    Credit"
            REPORT_TAB(5) = 87

            REPORT_FIELD(6) = "Mnd Saldo"
            REPORT_TAB(6) = 98

            REPORT_FIELD(7) = "D/C Cumul"
            REPORT_TAB(7) = 111
        End If

        PdfReportTitle = Space(128)
        For T = 0 To 7
            Mid(PdfReportTitle, REPORT_TAB(T)) = REPORT_FIELD(T)
        Next

    End Sub

    Private Sub VpePrintHeader()

        With Mim.Report
            .SelectFont("Courier New", 7.2)
            .TextBold = True
            .TextColor = ColorTranslator.FromOle(0) 'zwart

            .nTopMargin = 1
            .nBottomMargin = 29
            .nLeftMargin = 0.5
            .nRightMargin = 0.5
            .PenSize = 0.01
        End With

        PAGE_COUNTER += 1
        pdfY = Mim.Report.Print(1, 1, ReportText(2))
        pdfY = Mim.Report.Print(17, 1, "Pagina : " & Dec(PAGE_COUNTER, "##########") & vbCrLf)
        pdfY = Mim.Report.Print(17, pdfY, "Datum  : " & ReportText(0) & vbCrLf & vbCrLf)
        pdfY = Mim.Report.Print(1, pdfY, UCase(ReportText(3)) & vbCrLf)
        pdfY = Mim.Report.Print(1, pdfY, FULL_LINE & vbCrLf)
        pdfY = Mim.Report.Print(1, pdfY, PdfReportTitle & vbCrLf)
        pdfY = Mim.Report.Print(1, pdfY, FULL_LINE & vbCrLf & vbCrLf)

    End Sub

    Private Sub CheckRecordSet()

        Dim sSQL As String
        sSQL = "SELECT Journalen.v066, Journalen.v019, Rekeningen.v020, Rekeningen." & BookYearAccountSolde & ", Journalen.v067, Journalen.v033, Journalen.dece068, Journalen.v069, Journalen.v038 FROM Journalen, Rekeningen WHERE Journalen.v019=Rekeningen.v019 AND Journalen.v066 >= '" & Mid(SelectionFromTo, 1, 8) & "' AND Journalen.v066 <= '" & Mid(SelectionFromTo, 9) & "' ORDER BY Journalen.v019, Journalen.v066"

        ' Create a recordset using the provided collection
        JournalEntriesRS = New ADODB.Recordset With {
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
        }
        JournalEntriesRS.Open(sSQL, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        If JournalEntriesRS.RecordCount <= 0 Then
            TextBoxRecordLines.Text = "0"
            Exit Sub
        Else
            TextBoxRecordLines.Text = JournalEntriesRS.RecordCount
            ButtonGenerateReport.Focus()
        End If

    End Sub

    Private Sub PrintDetailLedger()

        '		Dim Printer As New Printer
        '		Dim SubTitelTekst As String
        '		Dim BeginSleutel As New VB6.FixedLengthString(8)
        '		Dim EindSleutel As New VB6.FixedLengthString(8)
        '		Dim DCBedrag As Integer

        '		Dim DCKontrole As Decimal
        '		Dim DCDatum As New VB6.FixedLengthString(8)

        '		'On Local Error GoTo PrtHandler2

        '		ErrorTekst = ""
        '		Line = 0
        '		KontroleLijst = ""
        '		BeginSleutel.Value = PeriodFromChosen.Value
        '		EindSleutel.Value = PeriodToChosen.Value

        '		ReportText(2) = "Algemeen Journaal (Systeem OT) " & Mid(Mim.Text, InStr(Mim.Text, "["))
        '		ReportText(0) = txtTekstLijn(1).Text
        '		ReportText(3) = "Boekjaar aanvang : " & VB.Left(BOOKYEAR_FROMTO.Value, 4) & ", " & txtTekstLijn(0).Text
        '		InitialiseFields()

        '		JetGetFirst(TABLE_JOURNAL, 4)
        '		JetGetOrGreater(TABLE_JOURNAL, 4, BeginSleutel.Value)
        '		If KTRL Then
        '			Beep()
        '			Exit Sub
        '		End If
        '		Me.Enabled = False
        '		PAGE_COUNTER = Val(TxtVolgNummer.Text)
        '		If chkAfdrukInVenster.CheckState = 0 Then
        '			If Printer.Width > 12000 Then
        '				Printer.FontSize = 10
        '				Printer.FontName = "Courier New"
        '				Printer.Print(" ")
        '				Printer.FontSize = 10
        '			Else
        '				Printer.FontSize = 7.2
        '				Printer.FontName = "Courier New"
        '				Printer.Print(" ")
        '				Printer.FontSize = 7.2
        '			End If
        '		End If
        '		VpePrintHeader()
        '		TotalDebit = 0
        '		TotalCredit = 0

        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        '		Do 
        '			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '			GoSub PrintInfo
        '			bNext(TABLE_JOURNAL)
        '			'UPGRADE_ISSUE: DoEvents does not return a value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8D115264-E27F-4472-A684-865A00B5E826"'
        '			XDO_EVENTS = System.Windows.Forms.Application.DoEvents()
        '			If KTRL Or KEY_BUF(TABLE_JOURNAL) > EindSleutel.Value Then
        '				Exit Do
        '			End If
        '		Loop 
        '		EindTotaal()
        '		If chkAfdrukInVenster.CheckState Then
        '		Else
        '			Printer.NewPage()
        '			Printer.FontSize = Printer.FontSize
        '			Printer.Print(" ")
        '			Printer.FontSize = Printer.FontSize
        '		End If
        '		If chkAfdrukInVenster.CheckState Then
        '		Else
        '			Printer.EndDoc()
        '		End If
        '		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        '		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = vbNormal
        '		Me.Enabled = True
        '		cmdSluiten_Click(cmdSluiten, New System.EventArgs())
        '		Exit Sub

        'PrintInfo: 
        '		RecordToField(TABLE_JOURNAL)
        '		If AdoGetField(TABLE_JOURNAL, "#v066 #") >= PeriodFromChosen.Value And AdoGetField(TABLE_JOURNAL, "#v066 #") <= PeriodToChosen.Value Then
        '			Line = Line + 1
        '			If DCDatum.Value <> AdoGetField(TABLE_JOURNAL, "#v066 #") Then
        '				DCDatum.Value = AdoGetField(TABLE_JOURNAL, "#v066 #")
        '				If ErrorTekst = "j" Then
        '				Else
        '					If TotalDebit - TotalCredit <> 0 Then
        '						ErrorTekst = "j"
        '						MSG = "DC ongelijkheid vanaf laatste dag vóór : " & ErrorTekst & AdoGetField(TABLE_JOURNAL, "#v066 #")
        '						MsgBox(MSG)
        '					End If
        '				End If
        '			End If

        '			JetGet(TABLE_LEDGERACCOUNTS, 0, SetSpacing(AdoGetField(TABLE_JOURNAL, "#v019 #"), 7))
        '			If KTRL Then
        '				FieldText(3) = "-"
        '			Else
        '				RecordToField(TABLE_LEDGERACCOUNTS)
        '				FieldText(3) = AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #")
        '				SnelHelpPrint(AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #") & " " & AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #") & " " & FieldText(3), BL_LOGGING)
        '			End If
        '			FieldText(0) = VB6.Format(Line, "00000")
        '			FieldText(1) = FunctionDateText(AdoGetField(TABLE_JOURNAL, "#v066 #"))
        '			FieldText(2) = AdoGetField(TABLE_JOURNAL, "#v019 #")
        '			FieldText(4) = AdoGetField(TABLE_JOURNAL, "#v067 #")

        '			Select Case RS_MAR(TABLE_JOURNAL).Fields("dece068").Value
        '				Case Is < 0
        '					FieldText(5) = ""
        '					FieldText(6) = Dec(System.Math.Abs(RS_MAR(TABLE_JOURNAL).Fields("dece068").Value), MASK_2002.Value)
        '					TotalCredit = TotalCredit + Val(FieldText(6))
        '				Case Else
        '					FieldText(5) = Dec((RS_MAR(TABLE_JOURNAL).Fields("dece068").Value), MASK_2002.Value)
        '					FieldText(6) = ""
        '					TotalDebit = TotalDebit + Val(FieldText(5))
        '			End Select

        '			FieldText(7) = AdoGetField(TABLE_JOURNAL, "#v033 #")
        '			VpePrintLines()
        '		End If
        '		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		Return 

    End Sub

    Private Sub PrintTrialBalance()

        With Mim.Report
            .CloseDoc()
            .OpenDoc()
            .Author = "marIntegraal"
            .GUILanguage = 3 'Nederlands
            .Title = "Proef- en Saldibalans"
        End With
        ReportText(2) = "Proef- en Saldibalans " & Mid(Mim.Text, InStr(Mim.Text, "["))
        ReportText(0) = TextBoxProcessingDate.Text
        ReportText(3) = TextBoxPeriodFromTo.Text
        InitializeFields()
        Line = 0
        JournalEntriesRS.MoveFirst()
        VpePrintHeader()
        Do While Not JournalEntriesRS.EOF
            VpePrintLine()
            JournalEntriesRS.MoveNext()
            If JournalEntriesRS.EOF Then
                Exit Do
            Else
                If LastLedgerAccount <> Trim(JournalEntriesRS.Fields("v019").Value) Then
                    Line = 0
                    'PrintLedgerAccountTotal()
                Else
                    If CheckForMonth <> Mid(JournalEntriesRS.Fields("v066").Value, 5, 2) Then
                        'PrintMonthTotal()
                    End If
                End If
            End If
        Loop
        'PrintLedgerAccountTotal()
        PrintEndTotal()
        With Mim.Report
            .WriteDoc(LOCATION_COMPANYDATA & Format(Now, "YYYYMMDDHHMMSS") & "-historieken.pdf")
            .MailSubject = "Historieken bedrijfx"
            .MailText = "Historieken bedrijf ix in bijlage."
        End With

        'Mim.Report.AddMailReceiver(TextBoxMailToOption.Text, RecipientClass.To)
        Mim.Report.Preview()
        'Mim.Report.CloseDoc()
        Focus()
        ButtonClose.PerformClick()
        '		Dim Printer As New Printer
        '		Dim SubTitelTekst As String
        '		Dim BeginSleutel As New VB6.FixedLengthString(15)
        '		Dim EindSleutel As New VB6.FixedLengthString(15)
        '		Dim VorigeSleutel As New VB6.FixedLengthString(15)
        '		Dim DCBedrag As Decimal
        '		Dim recVeldje As String
        '		Dim rkVeldje As String

        '		'On Local Error GoTo PrtHandler2

        '		Line = 0
        '		VorigeSleutel.Value = ""
        '		KontroleLijst = ""
        '		BeginSleutel.Value = SetSpacing(txtTekstLijn(2).Text, 7) & PeriodFromChosen.Value
        '		EindSleutel.Value = SetSpacing(txtTekstLijn(3).Text, 7) & PeriodToChosen.Value

        '		ReportText(2) = "Proef- en Saldibalans " & Mid(Mim.Text, InStr(Mim.Text, "["))
        '		ReportText(0) = txtTekstLijn(1).Text
        '		ReportText(3) = "Boekjaar aanvang : " & VB.Left(BOOKYEAR_FROMTO.Value, 4) & ", " & txtTekstLijn(0).Text
        '		InitialiseFields()

        '		JetGetFirst(TABLE_JOURNAL, 0)
        '		JetGetOrGreater(TABLE_JOURNAL, 0, BeginSleutel.Value)
        '		If KTRL Then
        '			Beep()
        '			Exit Sub
        '		End If
        '		Me.Enabled = False
        '		PAGE_COUNTER = 0
        '		If chkAfdrukInVenster.CheckState = 0 Then
        '			Printer = Printers(LISTPRINTER_NUMBER)
        '			On Error Resume Next
        '			'UPGRADE_WARNING: Couldn't resolve default property of object SettingLoading(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '			Printer.PaperBin = SettingLoading(My.Application.Info.Title, "LIJSTPRINTER")
        '			If Printer.Width > 12000 Then
        '				Printer.FontSize = 10
        '				Printer.FontName = "Courier New"
        '				Printer.Print(" ")
        '				Printer.FontSize = 10
        '			Else
        '				Printer.FontSize = 7.2
        '				Printer.FontName = "Courier New"
        '				Printer.Print(" ")
        '				Printer.FontSize = 7.2
        '				Printer.FontBold = True
        '			End If
        '		End If
        '		VpePrintHeader()

        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        '		If VB.Right(KEY_BUF(TABLE_JOURNAL), 8) >= PeriodFromChosen.Value And VB.Right(KEY_BUF(TABLE_JOURNAL), 8) <= PeriodToChosen.Value Then
        '			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '			GoSub PrintInfo
        '		End If

        '		Do 
        '			bNext(TABLE_JOURNAL)
        '			'UPGRADE_ISSUE: DoEvents does not return a value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8D115264-E27F-4472-A684-865A00B5E826"'
        '			XDO_EVENTS = System.Windows.Forms.Application.DoEvents()
        '			If KTRL Then
        '				Exit Do
        '			ElseIf VB.Right(KEY_BUF(TABLE_JOURNAL), 8) >= PeriodFromChosen.Value And VB.Right(KEY_BUF(TABLE_JOURNAL), 8) <= PeriodToChosen.Value Then 
        '				If VorigeSleutel.Value = Space(15) Then
        '					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '					GoSub PrintInfo
        '				ElseIf VB.Left(VorigeSleutel.Value, 7) = VB.Left(KEY_BUF(TABLE_JOURNAL), 7) Then 
        '					If Mid(VorigeSleutel.Value, 12, 2) <> Mid(KEY_BUF(TABLE_JOURNAL), 12, 2) Then
        '						RekeningTotaal()
        '						'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '						GoSub PrintInfo
        '					Else
        '						'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '						GoSub PrintInfo
        '					End If
        '				Else
        '					RekeningTotaal()
        '					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '					GoSub PrintInfo
        '				End If
        '			End If
        '		Loop 
        '		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '		GoSub RekSaldoKTRL
        '		RekeningTotaal()
        '		EindTotaal()
        '		If chkAfdrukInVenster.CheckState Then
        '		Else
        '			Printer.NewPage()
        '			Printer.FontSize = Printer.FontSize
        '			Printer.Print(" ")
        '			Printer.FontSize = Printer.FontSize
        '		End If
        '		If KontroleLijst <> "" Then
        '			Printer.CurrentY = 400
        '			Printer.Print(KontroleLijst)
        '			Printer.EndDoc()
        '		ElseIf chkAfdrukInVenster.CheckState Then 
        '		Else
        '			Printer.EndDoc()
        '		End If
        '		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        '		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = vbNormal
        '		Me.Enabled = True
        '		cmdSluiten_Click(cmdSluiten, New System.EventArgs())
        '		Exit Sub

        'PrintInfo: 
        '		RecordToField(TABLE_JOURNAL)
        '		If VB.Left(VorigeSleutel.Value, 7) <> VB.Left(KEY_BUF(TABLE_JOURNAL), 7) Then
        '			If VorigeSleutel.Value = Space(15) Then
        '			ElseIf SaldiKontrole = True Then 
        '				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '				GoSub RekSaldoKTRL
        '			End If

        '			CumTotaalD = 0
        '			CumTotaalC = 0
        '			JetGet(TABLE_LEDGERACCOUNTS, 0, SetSpacing(AdoGetField(TABLE_JOURNAL, "#v019 #"), 7))
        '			FieldText(0) = AdoGetField(TABLE_JOURNAL, "#v019 #")
        '			If KTRL Then
        '				FieldText(1) = "Rekening reeds vernietigd..."
        '				FieldText(2) = ""
        '			Else
        '				RecordToField(TABLE_LEDGERACCOUNTS)
        '				FieldText(1) = AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #")

        '				If BH_EURO Then
        '					rkVeldje = "#e" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex, "000") & " #"
        '				Else
        '					rkVeldje = "#v" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex, "000") & " #"
        '				End If

        '				FieldText(2) = Str(Val(AdoGetField(TABLE_LEDGERACCOUNTS, rkVeldje)))
        '				Select Case Val(FieldText(2))
        '					Case Is < 0
        '						FieldText(2) = "CS:" & Dec(System.Math.Abs(Val(FieldText(2))), MASK_2002.Value)
        '					Case Else
        '						FieldText(2) = "DS:" & Dec(Val(FieldText(2)), MASK_2002.Value)
        '				End Select
        '			End If
        '		End If
        '		VorigeSleutel.Value = KEY_BUF(TABLE_JOURNAL)
        '		FieldText(3) = MONTH_AS_TEXT(Val(Mid(KEY_BUF(TABLE_JOURNAL), 12, 2)))
        '		SnelHelpPrint(AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #") & " " & AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #") & " " & Trim(FieldText(3)) & " " & Mid(KEY_BUF(TABLE_JOURNAL), 8, 4), BL_LOGGING)

        '		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        '		If IsDbNull(RS_MAR(TABLE_JOURNAL).Fields("dece068").Value) Then
        '			DCBedrag = 0
        '		Else
        '			DCBedrag = RS_MAR(TABLE_JOURNAL).Fields("dece068").Value
        '		End If
        '		Select Case DCBedrag
        '			Case Is < 0
        '				SubTotaalC = SubTotaalC + DCBedrag
        '				CumTotaalC = CumTotaalC + DCBedrag
        '				TotalCredit = TotalCredit + DCBedrag
        '			Case Else
        '				SubTotaalD = SubTotaalD + DCBedrag
        '				CumTotaalD = CumTotaalD + DCBedrag
        '				TotalDebit = TotalDebit + DCBedrag
        '		End Select
        '		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		Return 

        'RekSaldoKTRL: 
        '		If BH_EURO Then
        '			rkVeldje = "#e" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex, "000") & " #"
        '		Else
        '			rkVeldje = "#v" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex, "000") & " #"
        '		End If
        '		If System.Math.Abs(CumTotaalD + CumTotaalC) - System.Math.Abs(Val(AdoGetField(TABLE_LEDGERACCOUNTS, rkVeldje))) = 0 Then
        '		Else
        '			MSG = "KontroleStop bijwerking rekeningsaldo !!" & vbCrLf & vbCrLf
        '			MSG = MSG & "Rekening : " & KEY_BUF(TABLE_LEDGERACCOUNTS) & vbCrLf
        '			If BH_EURO Then
        '				MSG = MSG & Str(CumTotaalD + CumTotaalC) & " <> " & Str(Val(AdoGetField(TABLE_LEDGERACCOUNTS, "#e" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex, "000") & " #")))
        '			Else
        '				MSG = MSG & Str(CumTotaalD + CumTotaalC) & " <> " & Str(Val(AdoGetField(TABLE_LEDGERACCOUNTS, "#v" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex, "000") & " #")))
        '			End If
        '			MsgBox(MSG & vbCrLf & vbCrLf & "Na deze P&S, nogmaals opnieuw P&S a.u.b. samenstellen", MsgBoxStyle.Exclamation)

        '			KontroleLijst = KontroleLijst & AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #") & " " & Dec(CumTotaalD + CumTotaalC, "#########.00") & " " & Dec(Val(AdoGetField(TABLE_LEDGERACCOUNTS, "#v" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex, "000") & " #")), "#########.00") & vbCrLf
        '			If BH_EURO Then
        '				AdoInsertToRecord(TABLE_LEDGERACCOUNTS, Str(CumTotaalD + CumTotaalC), "e" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex, "000"))
        '				RS_MAR(TABLE_LEDGERACCOUNTS).Fields("dece" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex, "000")).Value = CumTotaalD + CumTotaalC
        '			Else
        '				AdoInsertToRecord(TABLE_LEDGERACCOUNTS, Str(CumTotaalD + CumTotaalC), "v" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex, "000"))
        '			End If
        '			bUpdate(TABLE_LEDGERACCOUNTS, 0)
        '		End If
        '		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		Return 

        'PrtHandler2: 
        '		MsgBox("Kontroleer de printer.")
        '		Resume 

    End Sub

    Private Sub VpePrintLine()

        Dim DCAmount As Double
        Dim DCNote As String

        Line += 1

        LastLedgerAccount = Trim(JournalEntriesRS.Fields("v019").Value)
        CheckForMonth = Mid(JournalEntriesRS.Fields("v066").Value, 5, 2)

        If FirstPartDone Then
            If SecondPartReady Then


            Else
                AddUpLedgerAccountTotals()
                Exit Sub
            End If
        Else
            PdfLine = Space(128)
            Mid(PdfLine, REPORT_TAB(0)) = JournalEntriesRS.Fields("v019").Value 'accountnumber
            Mid(PdfLine, REPORT_TAB(1)) = JournalEntriesRS.Fields("v020").Value 'accountname

            DCAmount = ObjectValue((JournalEntriesRS.Fields(BookYearAccountSolde).Value))
            Select Case DCAmount
                Case Is < 0
                    DCNote = "CS:"
                    Mid(PdfLine, REPORT_TAB(2)) = DCNote + Dec(Math.Abs(DCAmount), MASK_EURBH) 'CS amount
                Case Else
                    DCNote = "DS:"
                    mid(PdfLine, REPORT_TAB(2)) = DCNote + Dec(DCAmount, MASK_EURBH) 'DS amount
            End Select
            FirstPartDone = True
            AddUpLedgerAccountTotals()
            Exit Sub
        End If

        pdfY = Mim.Report.Print(1, pdfY, PdfLine & vbCrLf)
        If pdfY > 27.5 Then
            Mim.Report.PageBreak()
            VpePrintHeader()
        End If

    End Sub

    Private Sub AddUpLedgerAccountTotals()

        Dim DCAmount As Double

        DCAmount = ObjectValue((JournalEntriesRS.Fields("dece068").Value))
        Select Case DCAmount
            Case Is < 0
                MonthTotalC += DCAmount
                MonthCumulDC += DCAmount
                AccountCumulDC += DCAmount
                EndTotalC += DCAmount

            Case Else
                MonthTotalD += DCAmount
                MonthCumulDC += DCAmount
                AccountCumulDC += DCAmount
                EndTotalD += DCAmount
        End Select

    End Sub

    Private Sub PrintEndTotal()

        '	Private Sub EindTotaal()
        '		Dim Printer As New Printer
        '		Dim T As Short

        '		'On Local Error GoTo PrtHandler3

        '		For T = 0 To 7
        '			FieldText(T) = ""
        '		Next 
        '		FieldText(1) = "Totalen :"
        '		If chkDetailJournaal.CheckState Then
        '			FieldText(5) = Dec(TotalDebit, MASK_2002.Value)
        '			FieldText(6) = Dec(System.Math.Abs(TotalCredit), MASK_2002.Value)
        '		Else
        '			FieldText(4) = Dec(TotalDebit, MASK_2002.Value)
        '			FieldText(5) = Dec(System.Math.Abs(TotalCredit), MASK_2002.Value)
        '		End If
        '		T = 0
        '		If chkAfdrukInVenster.CheckState Then
        '		Else
        '			Printer.Print(vbCrLf & FULL_LINE.Value)
        '		End If

        '		aa = ""
        '		Do While REPORT_TAB(T) <> 0
        '			If chkAfdrukInVenster.CheckState Then
        '				aa = aa & FieldText(T) & vbTab
        '			Else
        '				Printer.Print(TAB(REPORT_TAB(T)))
        '				Printer.Write(FieldText(T))
        '			End If
        '			If REPORT_TAB(T + 1) < REPORT_TAB(T) Then
        '				If chkAfdrukInVenster.CheckState = 0 Then
        '					Printer.Write(vbCrLf)
        '				End If
        '			End If
        '			T = T + 1
        '		Loop 
        '		If chkAfdrukInVenster.CheckState Then
        '			Xlog.X.AddItem(aa, Xlog.X.Rows - 1)
        '		End If

        '		If System.Math.Round(TotalDebit, 2) + System.Math.Round(TotalCredit, 2) Then
        '			KontroleLijst = KontroleLijst & vbCrLf & vbCrLf & "Katastrofale fout : Algemene cumul Debet <> cumul credit.  Kontakteer ons 053/21.59.25 !" & vbCrLf & "Indien U niet beschikt over veiligheidskopij dient recuperatie van bestanden door ons te gebeuren."
        '		End If

        '		Line = 0
        '		SubTotaalD = 0
        '		SubTotaalC = 0
        '		TotalDebit = 0
        '		TotalCredit = 0

        '		If chkAfdrukInVenster.CheckState Then
        '			Xlog.X.Row = 1
        '			Xlog.X.Col = 0
        '			If chkDetailJournaal.CheckState Then
        '				With Xlog.X
        '					.set_ColWidth(0, 705)
        '					.set_ColWidth(1, 990)
        '					.set_ColWidth(2, 750)
        '					.set_ColWidth(3, 2865)
        '					.set_ColWidth(4, 1830)
        '					.set_ColWidth(5, 915)
        '					.set_ColWidth(6, 915)
        '					.set_ColWidth(7, 1140)
        '				End With
        '				Xlog.WindowState = System.Windows.Forms.FormWindowState.Maximized
        '			Else
        '				With Xlog.X
        '					.set_ColWidth(0, 700)
        '					.set_ColWidth(1, 2955)
        '					.set_ColWidth(2, 1250)
        '					.set_ColAlignment(2, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
        '					.set_ColWidth(3, 855)
        '					.set_ColWidth(4, 1200)
        '					.set_ColAlignment(4, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
        '					.set_ColWidth(5, 1200)
        '					.set_ColAlignment(5, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
        '					.set_ColWidth(6, 1200)
        '					.set_ColAlignment(6, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
        '					.set_ColWidth(7, 1200)
        '					.set_ColAlignment(7, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
        '				End With
        '				Xlog.WindowState = System.Windows.Forms.FormWindowState.Maximized
        '			End If
        '			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        '			'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        '			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '			System.Windows.Forms.Cursor.Current = vbNormal

        '			Xlog.WijzigenLijn.Visible = False
        '			Xlog.Afsluiten.Enabled = False
        '			Xlog.Afsluiten.TabStop = False
        '			Xlog.cbAfbeelding.Visible = False
        '			XLOG_KEY = ""
        '			Xlog.SSTab1.TabPages.Item(1).Visible = False
        '			Xlog.ShowDialog()
        '			Xlog.Close()
        '		End If
        '		Exit Sub

        'PrtHandler3: 
        '		MsgBox("Kontroleer de printer.")
        '		Resume 

        '	End Sub

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Close()

    End Sub

    Private Sub TextBoxPeriodFromTo_Leave(sender As Object, e As EventArgs) Handles TextBoxPeriodFromTo.Leave

        SelectionFromTo = BOOKYEAR_FROMTO
        If DateWrongFormat(Mid(TextBoxPeriodFromTo.Text, 14, 10)) Then
            MsgBox("Respecteer : " & vbCrLf & vbCrLf & "DD/MM/EEJJ - DD/MM/EEJJ a.u.b. !")

            TextBoxPeriodFromTo.Text = FunctionDateText(Mid(SelectionFromTo, 1, 8)) & " - " & FunctionDateText(Mid(SelectionFromTo, 9))
            TextBoxPeriodFromTo.Focus()
            Exit Sub
        ElseIf Len(TextBoxPeriodFromTo.Text) <> 23 Then
            MsgBox("Respecteer : " & vbCrLf & vbCrLf & "DD/MM/EEJJ - DD/MM/EEJJ a.u.b. !")

            TextBoxPeriodFromTo.Text = FunctionDateText(Mid(SelectionFromTo, 1, 8)) & " - " & FunctionDateText(Mid(SelectionFromTo, 9))
            TextBoxPeriodFromTo.Focus()
            Exit Sub
        Else
            SelectionFromTo = Mid(TextBoxPeriodFromTo.Text, 7, 4) & Mid(TextBoxPeriodFromTo.Text, 4, 2) & Mid(TextBoxPeriodFromTo.Text, 1, 2) & Mid(TextBoxPeriodFromTo.Text, 20, 4) & Mid(TextBoxPeriodFromTo.Text, 17, 2) & Mid(TextBoxPeriodFromTo.Text, 14, 2)
            'CheckRecordSet()
        End If

    End Sub

    Private Sub TextBoxProcessingDate_Leave(sender As Object, e As EventArgs) Handles TextBoxProcessingDate.Leave


        If DateWrongFormat(TextBoxProcessingDate.Text) Then
            Beep()
            TextBoxProcessingDate.Text = MIM_GLOBAL_DATE
        End If

    End Sub

    Private Sub ButtonGenerateReport_Click(sender As Object, e As EventArgs) Handles ButtonGenerateReport.Click

        '		If PeriodFromChosen.Value = VB.Left(BOOKYEAR_FROMTO.Value, 8) And PeriodToChosen.Value = VB.Right(BOOKYEAR_FROMTO.Value, 8) Then
        '			SaldiKontrole = True
        '		Else
        '			SaldiKontrole = False
        '		End If

        If CheckBoxDetailLedger.CheckState Then
            PrintDetailLedger()
        Else
            PrintTrialBalance()
        End If

    End Sub

    Private Sub CheckBoxDetailLedger_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDetailLedger.CheckedChanged

        If CheckBoxDetailLedger.CheckState Then
            MSG = "Sinds 1993 zijn er aanbevelingen om na elk boek "
            MSG = MSG & "een centralisatieblad af te drukken en te bewaren "
            MSG = MSG & "in een grootboek.  Dit heeft de voorkeur boven het "
            MSG = MSG & "omslachtig en papierverslindend systeem van algemeen "
            MSG = MSG & "journaal afdrukken welke U zopas hebt gekozen..." & vbCr & vbCr
            MSG = MSG & "Wenst U alsnog detailjournaal af te drukken,"
            MSG = MSG & "gebruik de VB6 of DOS of CP/M versie van marIntegraal."
            MsgBox(MSG)
            CheckBoxDetailLedger.Checked = False
        End If

    End Sub

End Class
