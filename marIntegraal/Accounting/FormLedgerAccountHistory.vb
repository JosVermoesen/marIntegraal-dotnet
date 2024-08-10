Option Strict Off
Option Explicit On

Imports IDEALSoftware.VpeStandard

Public Class FormLedgerAccountHistory

    Dim Line As Integer
    Dim JournalEntriesRS As ADODB.Recordset
    Dim pdfY As Double
    Dim ReportText(5) As String
    Dim FieldText(20) As String
    Dim SelectionFromTo As String = Space(8)

    Dim LNumberL(20) As Short

    Dim SubTotalD As Double
    Dim SubTotalC As Double
    Dim TotalDebit As Double
    Dim TotalCredit As Double
    Dim EndTotalD As Double
    Dim EndTotalC As Double

    Dim PdfReportTitle As String

    Private Sub FormLedgerAccountHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SubTotalD = 0
        SubTotalC = 0
        TotalDebit = 0
        TotalCredit = 0
        EndTotalD = 0
        EndTotalC = 0

        SelectionFromTo = BOOKYEAR_FROMTO
        TextBoxProcessingDate.Text = MIM_GLOBAL_DATE

        TextBoxLedgerAccountFrom.Text = CStr(1)
        bNext(TABLE_LEDGERACCOUNTS, 0, SetSpacing(TextBoxLedgerAccountFrom.Text, 7))
        If KTRL Then
        Else
            RecordToField(TABLE_LEDGERACCOUNTS)
            TextBoxLedgerAccountFrom.Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
        End If

        TextBoxLedgerAccountTo.Text = "7999999"
        bPrev(TABLE_LEDGERACCOUNTS, 0, SetSpacing(TextBoxLedgerAccountTo.Text, 7))
        If KTRL Then
        Else
            RecordToField(TABLE_LEDGERACCOUNTS)
            TextBoxLedgerAccountTo.Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
        End If

        TextBoxPeriodFromTo.Text = FunctionDateText(Mid(SelectionFromTo, 1, 8)) & " - " & FunctionDateText(Mid(SelectionFromTo, 9))
        CheckRecordSet()

    End Sub

    Private Sub CheckRecordSet()

        Dim sSQL As String
        sSQL = "SELECT Journalen.v066, Journalen.v019, Journalen.v067, Journalen.v033, Journalen.dece068, Journalen.v069 FROM Journalen WHERE  Journalen.v066 >= '" & Mid(SelectionFromTo, 1, 8) & "' AND Journalen.v066 <= '" & Mid(SelectionFromTo, 9) & "' ORDER BY Journalen.v066" 'Journalen.v066"

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

    Private Sub TextBoxRecordLines_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRecordLines.TextChanged

        If TextBoxRecordLines.Text = "0" Then
            ButtonGenerateReport.Enabled = False
        Else
            ButtonGenerateReport.Enabled = True
        End If

    End Sub

    Private Sub InitializeFields()

        REPORT_FIELD(0) = "Line"
        REPORT_TAB(0) = 2
        REPORT_FIELD(1) = "Datum"
        REPORT_TAB(1) = 9
        REPORT_FIELD(2) = "Omschrijving"
        REPORT_TAB(2) = 22
        REPORT_FIELD(3) = "Document"
        REPORT_TAB(3) = 53
        REPORT_FIELD(4) = "Fin.Dok."
        REPORT_TAB(4) = 67
        REPORT_FIELD(5) = "       Debet"
        REPORT_TAB(5) = 76
        REPORT_FIELD(6) = "      Credit"
        REPORT_TAB(6) = 89
        REPORT_FIELD(7) = "T.Reken"
        REPORT_TAB(7) = 103
        REPORT_FIELD(8) = "VSF.Kode"
        REPORT_TAB(8) = 111
        REPORT_TAB(9) = 0

        PdfReportTitle = Space(128)
        For T = 0 To 8
            Mid(PdfReportTitle, REPORT_TAB(T)) = REPORT_FIELD(T)
        Next

    End Sub

    Private Sub VpePrintLine()

        '	Private Sub VpePrintLines()
        '		Dim Printer As New Printer
        '		Dim T As Short
        '		Dim VeldTekst As String

        '		Do While REPORT_TAB(T) <> 0
        '			Printer.Print(TAB(REPORT_TAB(T)))
        '			Printer.Write(FieldText(T))
        '			If REPORT_TAB(T + 1) < REPORT_TAB(T) Then
        '				Printer.Write(vbCrLf)
        '			End If
        '			T = T + 1
        '		Loop 
        '		If Printer.CurrentY >= Printer.Height - 1250 Then
        '			Printer.NewPage()
        '			Printer.FontSize = Printer.FontSize
        '			Printer.Print(" ")
        '			Printer.FontSize = Printer.FontSize
        '			VolgendePagina()
        '			VpePrintHeader()
        '		End If
        '		Exit Sub

        '	End Sub

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
        pdfY = Mim.Report.Print(1, 1, ReportText(3) & vbCrLf)

        '		Printer.Write(TAB(1), ReportText(3) & vbCrLf)
        '		Printer.Write(FULL_LINE.Value & vbCrLf)

        '		Do While REPORT_TAB(T) <> 0
        '			Printer.Print(TAB(REPORT_TAB(T)))
        '			Printer.Write(REPORT_FIELD(T))
        '			If REPORT_TAB(T + 1) < REPORT_TAB(T) Then
        '				Printer.Write(vbCrLf)
        '			End If
        '			T = T + 1
        '		Loop 

        '		Printer.Write(FULL_LINE.Value & vbCrLf)
        '		If Printer.CurrentY >= Printer.Height - 1250 Then
        '			Printer.NewPage()
        '			Printer.FontSize = Printer.FontSize
        '			Printer.Print(" ")
        '			Printer.FontSize = Printer.FontSize
        '			VolgendePagina()
        '			VpePrintHeader()
        '		End If
        '		Exit Sub

        'PrtHandler1: 
        '		MsgBox("Kontroleer de printer.")
        '		Resume 

        '	End Sub

    End Sub

    Private Sub VpeNextPage()

        PAGE_COUNTER += 1
        pdfY = Mim.Report.Print(1, 1, ReportText(2))
        pdfY = Mim.Report.Print(17, 1, "Pagina : " & Dec(PAGE_COUNTER, "##########") & vbCrLf)
        pdfY = Mim.Report.Print(17, pdfY, "Datum  : " & ReportText(0) & vbCrLf & vbCrLf)

    End Sub

    Private Sub PrintPeriodicTotal()

        '	Private Sub PeriodiekTotaal()
        '		Dim Printer As New Printer
        '		Dim T As Short

        '		On Error GoTo PrtHandler5

        '		For T = 0 To 8
        '			FieldText(T) = ""
        '		Next 

        '		FieldText(2) = "Periodiek totaal :"
        '		FieldText(5) = Dec(SubTotaalD, MASK_EURBH)
        '		FieldText(6) = Dec(System.Math.Abs(SubTotaalC), MASK_EURBH)

        '		AlgTotaalD = AlgTotaalD + SubTotaalD
        '		AlgTotaalC = AlgTotaalC + SubTotaalC
        '		If cbPeriodiekeTotalen.CheckState <> 0 Then
        '		Else
        '			SubTotaalD = 0
        '			SubTotaalC = 0
        '			Exit Sub
        '		End If

        '		T = 0
        '		Printer.Write(vbCrLf)
        '		Do While REPORT_TAB(T) <> 0
        '			Printer.Print(TAB(REPORT_TAB(T)))
        '			Printer.Write(FieldText(T))
        '			If REPORT_TAB(T + 1) < REPORT_TAB(T) Then
        '				Printer.Write(vbCrLf)
        '			End If
        '			T = T + 1
        '		Loop 

        '		'Printer.Print vbCrLf;
        '		SubTotaalD = 0
        '		SubTotaalC = 0
        '		If Printer.CurrentY >= Printer.Height - 1250 Then
        '			Printer.NewPage()
        '			Printer.FontSize = Printer.FontSize
        '			Printer.Print(" ")
        '			Printer.FontSize = Printer.FontSize
        '			VolgendePagina()
        '			VpePrintHeader()
        '		End If
        '		Exit Sub

        'PrtHandler5: 
        '		MsgBox("Kontroleer de printer.")
        '		Resume 

        '	End Sub


    End Sub

    Private Sub PrintEndTotal()

        '	Private Sub EindTotaal()
        '		Dim Printer As New Printer
        '		Dim T As Short

        '		For T = 0 To 8
        '			FieldText(T) = ""
        '		Next 

        '		FieldText(2) = "Boekjaartotalen :"
        '		FieldText(5) = Dec(TotalDebit, MASK_EURBH)
        '		FieldText(6) = Dec(System.Math.Abs(TotalCredit), MASK_EURBH)

        '		T = 0
        '		Do While REPORT_TAB(T) <> 0
        '			Printer.Print(TAB(REPORT_TAB(T)))
        '			Printer.Write(FieldText(T))
        '			If REPORT_TAB(T + 1) < REPORT_TAB(T) Then
        '				Printer.Write(vbCrLf)
        '			End If
        '			T = T + 1
        '		Loop 
        '		Printer.Write(vbCrLf)
        '		If Printer.CurrentY >= Printer.Height - 1250 Then
        '			Printer.NewPage()
        '			Printer.FontSize = Printer.FontSize
        '			Printer.Print(" ")
        '			Printer.FontSize = Printer.FontSize
        '			VolgendePagina()
        '			VpePrintHeader()
        '		End If

        '		Line = 0
        '		SubTotaalD = 0
        '		SubTotaalC = 0
        '		TotalDebit = 0
        '		TotalCredit = 0

        '	End Sub

    End Sub

    Private Sub ButtonGenerateReport_Click(sender As Object, e As EventArgs) Handles ButtonGenerateReport.Click

        '	Private Sub ButtonGenerateReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Drukken.Click
        '		Dim Printer As New Printer
        '		Dim BeginSleutel As New VB6.FixedLengthString(15)
        '		Dim EindSleutel As New VB6.FixedLengthString(15)
        '		Dim SubTitelTekst As String
        '		Dim VorigeSleutel As New VB6.FixedLengthString(15)
        '		Dim DCBedrag As Decimal
        '		Dim XX As Short

        '		Line = 0
        '		VorigeSleutel.Value = ""
        '		BeginSleutel.Value = SetSpacing(TekstLijn(2).Text, 7) & VB.Left(SelectieVanTot, 8)
        '		EindSleutel.Value = SetSpacing(TekstLijn(3).Text, 7) & VB.Right(SelectieVanTot, 8)

        '		ReportText(2) = "Historieken " & Mid(Mim.Text, InStr(Mim.Text, "["))
        '		ReportText(0) = TekstLijn(1).Text

        '		InitialiseFields()
        '		JetGetFirst(TABLE_JOURNAL, 0)
        '		JetGetOrGreater(TABLE_JOURNAL, 0, BeginSleutel.Value)
        '		If KTRL Then
        '			Beep()
        '			Exit Sub
        '		End If

        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        '		PAGE_COUNTER = 0
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
        '				Printer.FontBold = True
        '			End If
        '		End If
        '		VolgendePagina()

        '		If IsDateOk(VB.Right(KEY_BUF(TABLE_JOURNAL), 8), BOOKYEARAS_KEY) Then
        '			If VB.Left(KEY_BUF(TABLE_JOURNAL), 7) >= VB.Left(BeginSleutel.Value, 7) Then
        '				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '				GoSub InstalSubTitel
        '				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '				GoSub PrintInfo
        '			End If
        '		End If

        '		Do 
        '			bNext(TABLE_JOURNAL)
        '			If KTRL Or SetSpacing(KEY_BUF(TABLE_JOURNAL), 15) > EindSleutel.Value Then
        '				Exit Do
        '			End If
        '			If VB.Left(VorigeSleutel.Value, 7) = VB.Left(KEY_BUF(TABLE_JOURNAL), 7) Then
        '				If Not IsDateOk(VB.Right(KEY_BUF(TABLE_JOURNAL), 8), BOOKYEARAS_KEY) Then
        '				ElseIf Mid(VorigeSleutel.Value, 12, 2) = Mid(KEY_BUF(TABLE_JOURNAL), 12, 2) Then 
        '					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '					GoSub PrintInfo
        '				Else
        '					PeriodiekTotaal()
        '					If chkAfdrukInVenster.CheckState Then
        '					Else
        '						Printer.Write(vbCrLf)
        '					End If
        '					VorigeSleutel.Value = SetSpacing(KEY_BUF(TABLE_JOURNAL), 15)
        '					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '					GoSub PrintInfo
        '				End If
        '			Else
        '				If IsDateOk(VB.Right(KEY_BUF(TABLE_JOURNAL), 8), BOOKYEARAS_KEY) Then
        '					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '					GoSub InstalSubTitel
        '					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '					GoSub PrintInfo
        '				End If
        '			End If
        '		Loop 
        '		PeriodiekTotaal()
        '		EindTotaal()
        '		AlgemeenEindTotaal()
        '		Printer.NewPage()
        '		Printer.EndDoc()
        '		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        '		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = vbNormal
        '		Annuleren_Click(Annuleren, New System.EventArgs())
        '		Exit Sub

        'InstalSubTitel: 
        '		If Line <> 0 Then
        '			PeriodiekTotaal()
        '			EindTotaal()
        '		End If
        '		Line = 0
        '		RecordToField(TABLE_JOURNAL)
        '		JetGet(TABLE_LEDGERACCOUNTS, 0, SetSpacing(AdoGetField(TABLE_JOURNAL, "#v019 #"), 7))
        '		If KTRL Then
        '			SubTitelTekst = SetSpacing(AdoGetField(TABLE_JOURNAL, "#v019 #"), 7) & " rekening reeds vernietigd..."
        '		Else
        '			RecordToField(TABLE_LEDGERACCOUNTS)
        '			SubTitelTekst = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #") & " " & AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #")
        '			SnelHelpPrint(SubTitelTekst, BL_LOGGING)
        '			ReportText(3) = SubTitelTekst
        '		End If
        '		VorigeSleutel.Value = SetSpacing(KEY_BUF(TABLE_JOURNAL), 15)
        '		VpePrintHeader()
        '		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		Return 

        'PrintInfo: 
        '		RecordToField(TABLE_JOURNAL)
        '		Line = Line + 1
        '		FieldText(0) = VB6.Format(Line, "00000")
        '		FieldText(1) = FunctionDateText(AdoGetField(TABLE_JOURNAL, "#v066 #"))
        '		FieldText(2) = AdoGetField(TABLE_JOURNAL, "#v067 #")
        '		FieldText(3) = AdoGetField(TABLE_JOURNAL, "#v033 #")
        '		FieldText(4) = AdoGetField(TABLE_JOURNAL, "#v038 #")
        '		FieldText(7) = AdoGetField(TABLE_JOURNAL, "#v069 #")
        '		If RTrim(FieldText(3)) <> "" Then
        '			JetGet(TABLE_INVOICES, 0, FieldText(3))
        '			If KTRL Then
        '				FieldText(8) = FieldText(3)
        '			Else
        '				FieldText(8) = ""
        '			End If
        '		Else
        '			FieldText(8) = ""
        '		End If

        '		DCBedrag = Val(AdoGetField(TABLE_JOURNAL, "#v068 #"))

        '		Select Case DCBedrag
        '			Case Is < 0
        '				SubTotaalC = SubTotaalC + DCBedrag
        '				TotalCredit = TotalCredit + DCBedrag
        '				FieldText(5) = ""
        '				FieldText(6) = Dec(System.Math.Abs(DCBedrag), MASK_EURBH)
        '			Case Else
        '				SubTotaalD = SubTotaalD + DCBedrag
        '				TotalDebit = TotalDebit + DCBedrag
        '				FieldText(5) = Dec(DCBedrag, MASK_EURBH)
        '				FieldText(6) = ""
        '		End Select

        '		VpePrintLines()
        '		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		Return 

        '	End Sub

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Me.Close()

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
            CheckRecordSet()
        End If

    End Sub

    Private Sub TextBoxLedgerAccountFrom_Leave(sender As Object, e As EventArgs) Handles TextBoxLedgerAccountFrom.Leave

        bNext(TABLE_LEDGERACCOUNTS, 0, SetSpacing(TextBoxLedgerAccountFrom.Text, 7))
        If KTRL Then
        Else
            RecordToField(TABLE_LEDGERACCOUNTS)
            TextBoxLedgerAccountFrom.Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
        End If

    End Sub

    Private Sub TextBoxLedgerAccountTo_Leave(sender As Object, e As EventArgs) Handles TextBoxLedgerAccountTo.Leave

        bPrev(TABLE_LEDGERACCOUNTS, 0, SetSpacing(TextBoxLedgerAccountTo.Text, 7))
        If KTRL Then
        Else
            RecordToField(TABLE_LEDGERACCOUNTS)
            TextBoxLedgerAccountTo.Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
        End If

    End Sub

    Private Sub ButtonGenerateReport_Leave(sender As Object, e As EventArgs)

        TextBoxRecordLines.Text = "0"

    End Sub
End Class

'	Private Sub TekstLijn_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstLijn.Enter
'		Dim Index As Short = TekstLijn.GetIndex(eventSender)

'		TekstLijn(Index).SelectionStart = 0
'		TekstLijn(Index).SelectionLength = Len(TekstLijn(Index).Text)

'		Select Case Index
'			Case 2, 3
'				SnelHelpPrint("[Ctrl] voor geïndexeerd zoeken", BL_LOGGING)
'		End Select

'	End Sub

'	Private Sub TekstLijn_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles TekstLijn.KeyDown
'		Dim KeyCode As Short = eventArgs.KeyCode
'		Dim Shift As Short = eventArgs.KeyData \ &H10000
'		Dim Index As Short = TekstLijn.GetIndex(eventSender)

'		On Error Resume Next
'		If KeyCode = 13 Then System.Windows.Forms.SendKeys.SendWait("{TAB}") : Exit Sub
'		Select Case Index
'			Case 2, 3
'				Select Case KeyCode
'					Case 17
'						A_INDEX = 0
'						SHARED_FL = TABLE_LEDGERACCOUNTS
'						GRIDTEXT = TekstLijn(Index).Text
'						SqlSearch.ShowDialog()
'						If KTRL = 0 Then
'							TekstLijn(Index).Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
'							SnelHelpPrint(AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #"), BL_LOGGING)
'						End If
'				End Select
'		End Select

'	End Sub
