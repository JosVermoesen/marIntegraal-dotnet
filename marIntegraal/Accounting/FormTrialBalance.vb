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
        sSQL = "SELECT Journalen.v066, Journalen.dece068, Journalen.v019, Rekeningen.v020, Rekeningen." & BookYearAccountSolde & " FROM Journalen, Rekeningen WHERE Journalen.v019=Rekeningen.v019 AND Journalen.v066 >= '" & Mid(SelectionFromTo, 1, 8) & "' AND Journalen.v066 <= '" & Mid(SelectionFromTo, 9) & "' ORDER BY Journalen.v019, Journalen.v066"

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
        SecondPartReady = False
        FirstPartDone = False
        CheckForMonth = Mid(JournalEntriesRS.Fields("v066").Value, 5, 2)
        VpePrintHeader()
        Do While Not JournalEntriesRS.EOF
            VpePrintLine()
            JournalEntriesRS.MoveNext()
            If JournalEntriesRS.EOF Then
                Exit Do
            Else
                If LastLedgerAccount <> Trim(JournalEntriesRS.Fields("v019").Value) Then
                    Line = 0
                    SecondPartReady = True
                    VpePrintLine()
                    SecondPartReady = False
                    FirstPartDone = False
                    AccountCumulDC = 0
                    CheckForMonth = Mid(JournalEntriesRS.Fields("v066").Value, 5, 2)
                Else
                    If CheckForMonth <> Mid(JournalEntriesRS.Fields("v066").Value, 5, 2) Then
                        SecondPartReady = True
                        VpePrintLine()
                        SecondPartReady = False
                        CheckForMonth = Mid(JournalEntriesRS.Fields("v066").Value, 5, 2)
                    End If
                End If
            End If
        Loop
        SecondPartReady = True
        VpePrintLine()
        PrintTrialBalanceTotal()
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

    End Sub

    Private Sub VpePrintLine()

        Dim DCAmount As Double
        Dim DCNote As String

        Line += 1

        If FirstPartDone Then
            If Not SecondPartReady Then
                AddUpLedgerAccountTotals()
                Exit Sub
            Else
                ' Fit rest of the line
                Mid(PdfLine, REPORT_TAB(3)) = MONTH_AS_TEXT(Val(CheckForMonth))
                mid(PdfLine, REPORT_TAB(4)) = Dec(MonthTotalD, MASK_EUR)
                mid(PdfLine, REPORT_TAB(5)) = Dec(Math.Abs(MonthTotalC), MASK_EUR)
                Select Case MonthCumulDC
                    Case Is < 0
                        DCNote = "C:"
                        mid(PdfLine, REPORT_TAB(6)) = DCNote + Dec(Math.Abs(MonthCumulDC), MASK_EUR)
                    Case Else
                        DCNote = "D:"
                        mid(PdfLine, REPORT_TAB(6)) = DCNote + Dec(MonthCumulDC, MASK_EUR)
                End Select

                Select Case AccountCumulDC
                    Case Is < 0
                        DCNote = "C:"
                        mid(PdfLine, REPORT_TAB(7)) = DCNote + Dec(Math.Abs(AccountCumulDC), MASK_EUR)
                    Case Else
                        DCNote = "D:"
                        mid(PdfLine, REPORT_TAB(7)) = DCNote + Dec(AccountCumulDC, MASK_EUR)
                End Select

                pdfY = Mim.Report.Print(1, pdfY, PdfLine & vbCrLf)
                MonthTotalD = 0
                MonthTotalC = 0
                MonthCumulDC = 0

                PdfLine = Space(128)
                If pdfY > 27.5 Then
                    Mim.Report.PageBreak()
                    VpePrintHeader()
                End If
            End If
        Else
            LastLedgerAccount = Trim(JournalEntriesRS.Fields("v019").Value)

            PdfLine = Space(128)
            Mid(PdfLine, REPORT_TAB(0)) = JournalEntriesRS.Fields("v019").Value 'accountnumber
            Mid(PdfLine, REPORT_TAB(1)) = JournalEntriesRS.Fields("v020").Value 'accountname

            DCAmount = Val(ObjectValue((JournalEntriesRS.Fields(BookYearAccountSolde).Value)))
            Select Case DCAmount
                Case Is < 0
                    DCNote = "CS:"
                    Mid(PdfLine, REPORT_TAB(2)) = DCNote + Dec(Math.Abs(DCAmount), MASK_EUR) 'CS amount
                Case Else
                    DCNote = "DS:"
                    mid(PdfLine, REPORT_TAB(2)) = DCNote + Dec(DCAmount, MASK_EUR) 'DS amount
            End Select

            FirstPartDone = True
            SecondPartReady = False
            AddUpLedgerAccountTotals()
            Exit Sub
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

    Private Sub PrintTrialBalanceTotal()

        Dim PdfLine As String = Space(128)

        PdfLine = Space(128)
        pdfY = Mim.Report.Print(1, pdfY, FULL_LINE & vbCrLf)
        mid(PdfLine, REPORT_TAB(1)) = "Totalen:"
        mid(PdfLine, REPORT_TAB(4)) = Dec(EndTotalD, MASK_EUR)
        mid(PdfLine, REPORT_TAB(5)) = Dec(Math.Abs(EndTotalC), MASK_EUR)
        pdfY = Mim.Report.Print(1, pdfY, PdfLine & vbCrLf)

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

    Private Sub ButtonClose_Click_1(sender As Object, e As EventArgs)

        Close()

    End Sub
End Class
