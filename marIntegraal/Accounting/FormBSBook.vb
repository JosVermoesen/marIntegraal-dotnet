Option Strict Off
Option Explicit On

Public Class BSBook
	'Dim psText(5) As String
	'Dim LFontSize(20) As Single
	'Dim LAantalL(20) As Short
	'Dim FontDefChanged As Short
	'Dim rFlag As String
	'Dim r(10) As String
	'Dim FlBtw As Short
	'Dim DBVT(23) As Double
	'Dim DDVT(23) As Double
	'Dim BtwForfait(100) As Single
	'Dim KortingForfait(100) As Single
	'Dim VakForfait(3) As Double
	'Dim BtwTotaalForfait As Double
	'Dim ForfaitBtw As Double
	'Dim VeldTXT(17) As String

	Dim NumberHere As Integer
	Dim ReportFieldNr(23) As Short
	Dim ReportWay(23) As Short
	Dim ColumnTotal(17) As Decimal
	Dim T As Short
	Dim Line
	Dim ReportText(5) As String
	Dim ListName As String
	Dim ListSubName As String
	Dim pdfReportTitle As String
	Dim pdfReportTitle2 As String
	Dim pdfY As Double
	Dim FixedAmount(100) As Double
	Dim FixedPercentage(100) As Double
	Dim Fixed As Short
	Dim Ar As Short
	Dim tMaxField As Short
	Dim MaskHere As String
	Dim rsSellersOrBuyersHere As ADODB.Recordset
	Dim rsSorBJournalHere As ADODB.Recordset
	Dim rsDummy As ADODB.Recordset

	Sub InvoiceCreditNoteCheck()

		InitialiseFields()
		Select Case A_INDEX
			Case TABLE_SUPPLIERS
				T = 0
			Case TABLE_CUSTOMERS
				T = 10
			Case Else
				MsgBox("Stop")
		End Select

		NumberHere = 0
		Select Case RbInvoices.Checked
			Case True 'Factuur
				ListSubName = "Facturen"
				FL99_RECORD = String99(READING, 1 + T)
				tbUntil.Text = Format(Val(FL99_RECORD), "00000")
				FL99_RECORD = String99(READING, 2 + T)
				If Format(Val(FL99_RECORD), "00000") = tbUntil.Text Then
					BtnGenerateReport.Enabled = False
					lblFrom.Text = Format(Val(FL99_RECORD), "00000")
				Else
					BtnGenerateReport.Enabled = True
					lblFrom.Text = Format(Val(FL99_RECORD) + 1, "00000")
				End If
				If A_INDEX = TABLE_SUPPLIERS Then
					Ar = 1
					NumberHere = Val(AdoGetField(TABLE_VARIOUS, "#v092 #")) + Val(AdoGetField(TABLE_VARIOUS, "#v093 #"))
				Else
					Ar = 12
					NumberHere = Val(AdoGetField(TABLE_VARIOUS, "#v096 #")) + Val(AdoGetField(TABLE_VARIOUS, "#v097 #"))
				End If
			Case Else
				ListSubName = "Creditnota's"
				FL99_RECORD = String99(READING, 3 + T)
				tbUntil.Text = Format(Val(FL99_RECORD), "00000")
				FL99_RECORD = String99(READING, 4 + T)
				If Format(Val(FL99_RECORD), "00000") = tbUntil.Text Then
					BtnGenerateReport.Enabled = False
					lblFrom.Text = Format(Val(FL99_RECORD), "00000")
				Else
					BtnGenerateReport.Enabled = True
					lblFrom.Text = Format(Val(FL99_RECORD) + 1, "00000")
				End If
				If A_INDEX = TABLE_SUPPLIERS Then
					Ar = 3
					NumberHere = Val(AdoGetField(TABLE_VARIOUS, "#v094 #")) + Val(AdoGetField(TABLE_VARIOUS, "#v095 #"))
				Else
					Ar = 14
					NumberHere = Val(AdoGetField(TABLE_VARIOUS, "#v098 #")) + Val(AdoGetField(TABLE_VARIOUS, "#v099 #"))
				End If
		End Select
		If NumberHere Then
			MsgBox("Binnen deze periode, zijn er reeds" & vbCrLf & "dokumenten opgenomen !", 0, "BTW aangifte kontroleren a.u.b. !")
			BtnGenerateReport.Enabled = False
		End If

	End Sub

	Sub AgfControl()

		Dim PeriodeSleutel As String
		Dim T As Integer
		Dim PeriodeMax As Integer

		KTRL = 0
		PeriodeMax = FormBYPERDAT.PeriodeBoekjaar.Items.Count + 1
		Do While PeriodeMax > FormBYPERDAT.PeriodeBoekjaar.SelectedIndex + 1
			PeriodeSleutel = "17" & FormBYPERDAT.Boekjaar.Text & Format(PeriodeMax, "00")
			JetGet(TABLE_VARIOUS, 1, PeriodeSleutel)
			If KTRL Then
				TLB_RECORD(TABLE_VARIOUS) = ""
				AdoInsertToRecord(TABLE_VARIOUS, (FormBYPERDAT.Boekjaar.Text), "v090")
				AdoInsertToRecord(TABLE_VARIOUS, Format(PeriodeMax, "00"), "v091")
				AdoInsertToRecord(TABLE_VARIOUS, "17" & AdoGetField(TABLE_VARIOUS, "#v090 #") & AdoGetField(TABLE_VARIOUS, "#v091 #"), "v005")
				JetInsert(TABLE_VARIOUS, 1)
			Else
				RecordToField(TABLE_VARIOUS)
				NumberHere = 0
				For T = 92 To 99
					NumberHere += Val(AdoGetField(TABLE_VARIOUS, "#v" & Format(T, "000") & " #"))
				Next
				If NumberHere Then
					NumberHere = PeriodeMax
					'PeriodeMax = 0
					Exit Do
				End If
			End If
			PeriodeMax -= 1
		Loop
TryAgain:
		If NumberHere Then
			MsgBox("Periode " & Format(NumberHere, "00") & " reeds afgesloten...")
			BtnGenerateReport.Visible = False
			Exit Sub
		Else
			PeriodeSleutel = "17" & FormBYPERDAT.Boekjaar.Text & Format(FormBYPERDAT.PeriodeBoekjaar.SelectedIndex + 1, "00")
			JetGet(TABLE_VARIOUS, 1, PeriodeSleutel)
			If KTRL Then
				TLB_RECORD(TABLE_VARIOUS) = ""
				AdoInsertToRecord(TABLE_VARIOUS, (FormBYPERDAT.Boekjaar.Text), "v090")
				AdoInsertToRecord(TABLE_VARIOUS, Format(FormBYPERDAT.PeriodeBoekjaar.SelectedIndex + 1, "00"), "v091")
				AdoInsertToRecord(TABLE_VARIOUS, "17" & AdoGetField(TABLE_VARIOUS, "#v090 #") & AdoGetField(TABLE_VARIOUS, "#v091 #"), "v005")
				JetInsert(TABLE_VARIOUS, 1)
				GoTo TryAgain
			Else
				RecordToField(TABLE_VARIOUS)
			End If
		End If

		If Mid(String99(READING, 20), 1, 1) = "4" Then
			Fixed = 1
		Else
			Fixed = 0
		End If

	End Sub

	Private Sub InitialiseFields()
		Dim T As Short

		ReportFieldNr(0) = 33
		ReportWay(0) = 0 'niks omwerken gewoon afdrukken
		REPORT_FIELD(0) = "Document"
		REPORT_TAB(0) = 2

		ReportFieldNr(1) = 35
		ReportWay(1) = 5 'datum omwerken
		REPORT_FIELD(1) = "Datum doc."
		REPORT_TAB(1) = 14

		Select Case A_INDEX
			Case TABLE_SUPPLIERS
				ReportFieldNr(2) = 39
				ReportWay(2) = 0
				REPORT_FIELD(2) = "Referte"
				REPORT_TAB(2) = 25

				ReportFieldNr(3) = 46
				ReportWay(3) = 9 'geheel NumberHere geformateerd
				REPORT_FIELD(3) = "   VAK 81"
				REPORT_TAB(3) = 46

				ReportFieldNr(4) = 47
				ReportWay(4) = 9
				REPORT_FIELD(4) = "   VAK 82"
				REPORT_TAB(4) = 56

				ReportFieldNr(5) = 48
				ReportWay(5) = 9
				REPORT_FIELD(5) = "   VAK 83"
				REPORT_TAB(5) = 66

				ReportFieldNr(6) = 49
				ReportWay(6) = 9
				REPORT_FIELD(6) = "   DERDEN"
				REPORT_TAB(6) = 76

				ReportFieldNr(7) = 50
				ReportWay(7) = 9
				REPORT_FIELD(7) = "   VAK 84"
				REPORT_TAB(7) = 86

				ReportFieldNr(8) = 51
				ReportWay(8) = 9
				REPORT_FIELD(8) = "   VAK 85"
				REPORT_TAB(8) = 96

				ReportFieldNr(9) = 52
				ReportWay(9) = 9
				REPORT_FIELD(9) = "   VAK 86"
				REPORT_TAB(9) = 106

				ReportFieldNr(10) = 99
				ReportWay(10) = 1 'zoek flpartij kode+naam1
				REPORT_FIELD(10) = "ID.Code/Naam"
				REPORT_TAB(10) = 2

				ReportFieldNr(11) = 53
				ReportWay(11) = 9
				REPORT_FIELD(11) = "   VAK 87"
				REPORT_TAB(11) = 56

				ReportFieldNr(12) = 54
				ReportWay(12) = 9
				REPORT_FIELD(12) = "   VAK 88"
				REPORT_TAB(12) = 66

				ReportFieldNr(13) = 42
				ReportWay(13) = 9
				REPORT_FIELD(13) = "   VAK 55"
				REPORT_TAB(13) = 76

				ReportFieldNr(14) = 43
				ReportWay(14) = 9
				REPORT_FIELD(14) = "   VAK 56"
				REPORT_TAB(14) = 86

				ReportFieldNr(15) = 44
				ReportWay(15) = 9
				REPORT_FIELD(15) = "   VAK 57"
				REPORT_TAB(15) = 96

				ReportFieldNr(16) = 45
				ReportWay(16) = 9
				REPORT_TAB(16) = 106

				Select Case Ar
					Case 1
						REPORT_FIELD(16) = "   VAK 59"
					Case Else
						REPORT_FIELD(16) = "   VAK 63"
				End Select
				REPORT_TAB(17) = 0
				tMaxField = 16

			Case TABLE_CUSTOMERS
				ReportFieldNr(2) = 55
				ReportWay(2) = 9 'geheel NumberHere geformateerd
				REPORT_FIELD(2) = "VAK 00"
				REPORT_TAB(2) = 44

				ReportFieldNr(3) = 56
				ReportWay(3) = 9
				REPORT_FIELD(3) = "VAK 01"
				REPORT_TAB(3) = 55

				ReportFieldNr(4) = 57
				ReportWay(4) = 9
				REPORT_FIELD(4) = "VAK 02"
				REPORT_TAB(4) = 66

				ReportFieldNr(5) = 58
				ReportWay(5) = 9
				REPORT_FIELD(5) = "VAK 03"
				REPORT_TAB(5) = 77

				ReportFieldNr(6) = 59
				ReportWay(6) = 9
				REPORT_FIELD(6) = "VAK 45"
				REPORT_TAB(6) = 88

				ReportFieldNr(7) = 60
				ReportWay(7) = 9
				REPORT_FIELD(7) = "VAK 46"
				REPORT_TAB(7) = 99

				ReportFieldNr(8) = 61
				ReportWay(8) = 9
				REPORT_FIELD(8) = "VAK 47"
				REPORT_TAB(8) = 110

				ReportFieldNr(9) = 99
				ReportWay(9) = 1
				REPORT_FIELD(9) = "ID.Kode/Naam"
				REPORT_TAB(9) = 2

				ReportFieldNr(10) = 62
				ReportWay(10) = 9
				REPORT_FIELD(10) = "VAK 48"
				REPORT_TAB(10) = 77


				ReportFieldNr(11) = 63
				ReportWay(11) = 9
				REPORT_FIELD(11) = "VAK 49"
				REPORT_TAB(11) = 88

				ReportFieldNr(12) = 64
				ReportWay(12) = 9
				REPORT_TAB(12) = 99

				Select Case Ar
					Case 12
						REPORT_FIELD(12) = "VAK 54"
					Case Else
						REPORT_FIELD(12) = "VAK 64"
				End Select
				tMaxField = 12
				REPORT_TAB(13) = 0
		End Select

		For T = 0 To 17
			ColumnTotal(T) = 0
		Next

		Dim SecondLine = False
		pdfReportTitle = Space(128)
		pdfReportTitle2 = Space(128)
		For T = 0 To tMaxField
			Select Case SecondLine
				Case False
					Mid(pdfReportTitle, REPORT_TAB(T)) = REPORT_FIELD(T)
					If REPORT_TAB(T + 1) < REPORT_TAB(T) Then SecondLine = True
				Case True
					Mid(pdfReportTitle2, REPORT_TAB(T)) = REPORT_FIELD(T)
			End Select
		Next

	End Sub

	Private Sub VpePrintHeader()

		With Mim.Report
			.SelectFont("Courier", 7)
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
		pdfY = Mim.Report.Print(1, pdfY, FULL_LINE & vbCrLf)
		pdfY = Mim.Report.Print(1, pdfY, pdfReportTitle & vbCrLf)
		pdfY = Mim.Report.Print(1, pdfY, pdfReportTitle2 & vbCrLf)
		pdfY = Mim.Report.Print(1, pdfY, FULL_LINE & vbCrLf & vbCrLf)

	End Sub

	Private Sub VpePrintLines()
		Dim SecondLine = False
		Dim PdfLine As String = Space(128)
		Dim PdfLine2 As String = Space(128)
		Dim T = 0
		Dim VeldTekst = ""

		Do While REPORT_TAB(T) <> 0
			Select Case ReportWay(T)
				Case 1
					JetGet(A_INDEX, 0, SetSpacing(Mid(RV(rsSellersOrBuyersHere, "v034"), 2), FLINDEX_LEN(A_INDEX, 0)))
					If KTRL = 0 Then
						'RecordToField(A_INDEX)
						VeldTekst = Trim(RV(RS_MAR(A_INDEX), "A110")) & " " & Trim(RV(RS_MAR(A_INDEX), "A100"))
					Else
						VeldTekst = Mid(RV(rsSellersOrBuyersHere, "v034"), 2) & " is niet meer aanwezig"
						MsgBox(VeldTekst)
					End If

				Case 5
					VeldTekst = FunctionDateText(RV(rsSellersOrBuyersHere, "v" & Dec(ReportFieldNr(T), "000")))

				Case 9
					VeldTekst = Dec(Val(RV(rsSellersOrBuyersHere, "v" & Dec(ReportFieldNr(T), "000"))), MaskHere)
					ColumnTotal(T) = ColumnTotal(T) + Val(VeldTekst)
				Case Else
					VeldTekst = RV(rsSellersOrBuyersHere, "v" & Dec(ReportFieldNr(T), "000"))
			End Select
			Select Case SecondLine
				Case False
					Mid(PdfLine, REPORT_TAB(T)) = VeldTekst
					If REPORT_TAB(T + 1) < REPORT_TAB(T) Then SecondLine = True
				Case True
					Mid(PdfLine2, REPORT_TAB(T)) = VeldTekst
			End Select
			aa = aa & VeldTekst & vbTab
			T += 1
		Loop
		pdfY = Mim.Report.Print(1, pdfY, PdfLine & vbCrLf)
		pdfY = Mim.Report.Print(1, pdfY, PdfLine2 & vbCrLf & vbCrLf)
		If pdfY > 27.5 Then
			Mim.Report.PageBreak()
			VpePrintHeader()
		End If

	End Sub

	Private Sub PrintTotal()
		Dim SecondLine = False
		Dim PdfLine As String = Space(128)
		Dim PdfLine2 As String = Space(128)
		Dim T = 0
		Dim VeldTekst As String

		Do While REPORT_TAB(T) <> 0
			VeldTekst = ""
			Select Case ReportWay(T)
				Case 9
					VeldTekst = Dec(ColumnTotal(T), MaskHere)
			End Select
			Select Case SecondLine
				Case True
					Mid(PdfLine2, REPORT_TAB(T)) = VeldTekst
				Case False
					Mid(PdfLine, REPORT_TAB(T)) = VeldTekst
					If REPORT_TAB(T + 1) < REPORT_TAB(T) Then SecondLine = True
			End Select
			T += 1
		Loop
		pdfY = Mim.Report.Print(1, pdfY, FULL_LINE & vbCrLf)
		pdfY = Mim.Report.Print(1, pdfY, PdfLine & vbCrLf)
		pdfY = Mim.Report.Print(1, pdfY, PdfLine2 & vbCrLf & vbCrLf)

	End Sub

	Private Sub LedgerAccountsDetail(key33 As String)

		Dim RekeningNaam As String = Space(30)
		Dim PdfDetailLine As String = Space(128)
		Dim Tabul As Integer = 56
		Dim ForfaitNr As Short
		Dim VeldTekst As String
		Dim Ktrl44 As Boolean = False

		KTRL = GetJourRecordSet(key33)
		If Not KTRL Then
			MsgBox("Geen journaalgegevens gevonden voor dit document")
			Exit Sub
		End If

		rsSorBJournalHere.MoveFirst()
		Do While Not rsSorBJournalHere.EOF
			If rsSorBJournalHere("v019").Value.ToString.Substring(0, 2) = "40" Or rsSorBJournalHere("v019").Value.ToString.Substring(0, 2) = "44" Then
				If rsSorBJournalHere("v038").Value.ToString = "" Then
					If Ktrl44 = False Then
						RekeningNaam = SetSpacing(rsSorBJournalHere("v067").Value.ToString, 30)
						VeldTekst = Dec(Val(rsSorBJournalHere("v068").Value.ToString), MaskHere)
						Mid(PdfDetailLine, 2) = rsSorBJournalHere("v019").Value.ToString & " " & RekeningNaam & " " & VeldTekst
						Ktrl44 = True
						Tabul = 0
						CumulUpdate(rsSorBJournalHere("v019").Value.ToString, Val(VeldTekst))
					End If
				End If
			Else
				JetGet(TABLE_LEDGERACCOUNTS, 0, rsSorBJournalHere("v019").Value.ToString)
				If KTRL = 0 Then
					RekeningNaam = SetSpacing(Trim(RV(RS_MAR(TABLE_LEDGERACCOUNTS), "v020")), 30)
				Else
					RekeningNaam = SetSpacing("Rekening reeds vernietigd!", 30)
					MsgBox(RekeningNaam)
				End If
				VeldTekst = Dec(Val(rsSorBJournalHere("dece068").Value), MaskHere)
				If Tabul = 0 Then
					Tabul = 56
					' add second part of the line
					Mid(PdfDetailLine, Tabul + 2) = rsSorBJournalHere("v019").Value.ToString & " " & RekeningNaam & " " & VeldTekst
					pdfY = Mim.Report.Print(1, pdfY, PdfDetailLine & vbCrLf)
					If pdfY > 27.5 Then
						Mim.Report.PageBreak()
						VpePrintHeader()
					End If
					PdfDetailLine = Space(128)
				Else
					' add first part of the line
					Mid(PdfDetailLine, 2) = rsSorBJournalHere("v019").Value.ToString & " " & RekeningNaam & " " & VeldTekst
					Tabul = 0
				End If
				CumulUpdate(rsSorBJournalHere("v019").Value.ToString, rsSorBJournalHere("dece068").Value)
				'TODO: implement ForFaitBerekening
				'If Fixed Then
				' GoSub ForFaitBerekening
				'End If
			End If
			rsSorBJournalHere.MoveNext()
		Loop

		If Tabul = 0 Then
			pdfY = Mim.Report.Print(1, pdfY, PdfDetailLine & vbCrLf & vbCrLf)
		Else
			pdfY = Mim.Report.Print(1, pdfY, vbCrLf)
		End If
		If pdfY > 27.5 Then
			Mim.Report.PageBreak()
			VpePrintHeader()
		End If

		'ForFaitBerekening: 
		'		'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'		If RTrim(RV(RS_MAR(TABLE_LEDGERACCOUNTS), "v216")) <> "" Then
		'			'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'			ForfaitNr = Val(RV(RS_MAR(TABLE_LEDGERACCOUNTS), "v216"))
		'			'UPGRADE_WARNING: Couldn't resolve default property of object RV(rsSorBJournalHere, dece068). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'			FixedAmount(ForfaitNr) = FixedAmount(ForfaitNr) + RV(rsSorBJournalHere, "dece068")
		'			If FixedPercentage(ForfaitNr) = 0 Then
		'				'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'				JetGet(TABLE_VARIOUS, 1, SetSpacing("21" + RV(RS_MAR(TABLE_LEDGERACCOUNTS), "v216"), 20))
		'				If KTRL Then
		'					'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'					MsgBox("Forfaitaire Kode : " + RV(RS_MAR(TABLE_LEDGERACCOUNTS), "v216") + " en waarde nog niet aanwezig.  Eerst inbrengen via diverse gebruikersfiches pér bedrijf a.u.b. !")
		'				Else
		'					RecordToVeld(TABLE_VARIOUS)
		'					FixedPercentage(ForfaitNr) = Val(AdoGetField(TABLE_VARIOUS, "#v218 #"))
		'					BtwForfait(ForfaitNr) = Val(Mid(fmarBoxText("002", "2", AdoGetField(TABLE_VARIOUS, "#v111 #")), 4, 4))
		'					KortingForfait(ForfaitNr) = Val(AdoGetField(TABLE_VARIOUS, "#v230 #"))
		'				End If
		'			End If
		'		End If
		'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'		Return 

	End Sub

	Private Sub CumulUpdate(account As String, amount As Double)

TryAgain:
		JetGet(TABLE_DUMMY, 0, account)
		If KTRL Then
			TLB_RECORD(TABLE_DUMMY) = ""
			AdoInsertToRecord(TABLE_DUMMY, account, "v089")
			AdoInsertToRecord(TABLE_DUMMY, "0", "v013")
			AdoInsertToRecord(TABLE_DUMMY, "0", "v068")
			JetInsert(TABLE_DUMMY, 0)
			GoTo TryAgain
		Else
			RecordToField(TABLE_DUMMY)
			AdoInsertToRecord(TABLE_DUMMY, Str(Val(AdoGetField(TABLE_DUMMY, "#v013 #")) + 1), "v013")
			AdoInsertToRecord(TABLE_DUMMY, Str(Val(AdoGetField(TABLE_DUMMY, "#v068 #")) + amount), "v068")
			bUpdate(TABLE_DUMMY, 0)
		End If

	End Sub

	Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click

		Close()

	End Sub

	Private Function GetBSBookRecordSet(keyFrom As String, keyTo As String) As Boolean

		GetBSBookRecordSet = False

		Dim sSQL As String

		sSQL = "SELECT * FROM dokumenten WHERE v033 >='" & keyFrom & "' AND v033 <= '" & keyTo & "' ORDER BY v033"

		' Create a recordset using the provided collection
		rsSellersOrBuyersHere = New ADODB.Recordset With {
			.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		}
		rsSellersOrBuyersHere.Open(sSQL, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
		If rsSellersOrBuyersHere.RecordCount <= 0 Then
			'Message something
		Else
			GetBSBookRecordSet = True
		End If

	End Function

	Private Function GetDummyRecordSet() As Boolean

		GetDummyRecordSet = False

		Dim sSQL As String
		sSQL = "SELECT * FROM TmpBestand"

		rsDummy = New ADODB.Recordset With {
			.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		}
		rsDummy.Open(sSQL, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
		If rsDummy.RecordCount <= 0 Then
			'Message something
		Else
			GetDummyRecordSet = True
		End If

	End Function

	Private Function GetJourRecordSet(key33 As String) As Boolean

		GetJourRecordSet = False

		Dim sSQL As String
		sSQL = "SELECT * FROM Journalen WHERE v033 ='" & key33 & "' ORDER BY v019"

		rsSorBJournalHere = New ADODB.Recordset With {
			.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		}
		rsSorBJournalHere.Open(sSQL, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
		If rsSorBJournalHere.RecordCount <= 0 Then
			'Message something
		Else
			GetJourRecordSet = True
		End If

	End Function

	Private Sub CumulPrint()

		Mim.Report.PageBreak()
		VpePrintHeader()
		PrintTotal()

		Dim Tabul As Integer = 56
		Dim Tel As Integer
		Dim PdfDetailLine As String = Space(128)

		pdfY = Mim.Report.Print(1, pdfY, vbCrLf)
		pdfY = Mim.Report.Print(2, pdfY, "** CENTRALISATIE **" & vbCrLf)


		Dim aantalKeer As Integer = 0
		Dim rekeningNummer As String = ""
		Dim rekeningNaam As String = ""
		Dim bedrag As Double = 0
		Dim Ktrl44 As Boolean = False

		JetTableClose(TABLE_DUMMY)
		JetGetFirst(TABLE_DUMMY, 0)
		RecordToField(TABLE_DUMMY)
		rekeningNummer = SetSpacing(AdoGetField(TABLE_DUMMY, "#v089 #"), 7)
		JetGet(TABLE_LEDGERACCOUNTS, 0, rekeningNummer)
		If KTRL Then
			rekeningNaam = SetSpacing("Rekening reeds vernietigd !!!", 30)
		Else
			RecordToField(TABLE_LEDGERACCOUNTS)
			rekeningNummer = SetSpacing(RS_MAR(TABLE_LEDGERACCOUNTS).Fields("v019").Value, 7)
			rekeningNaam = SetSpacing(RS_MAR(TABLE_LEDGERACCOUNTS).Fields("v020").Value, 30)
		End If
		aantalKeer = Val(AdoGetField(TABLE_DUMMY, "#v013 #"))
		bedrag = Val(AdoGetField(TABLE_DUMMY, "#v068 #"))

		Tabul = 0
		Mid(PdfDetailLine, Tabul + 2) = Dec(aantalKeer, "####") & " x " & rekeningNummer & " " & rekeningNaam & " " & Dec(bedrag, MaskHere)

		Do
			bNext(TABLE_DUMMY, 0, rekeningNummer)
			If KTRL Then
				Exit Do
			End If
			RecordToField(TABLE_DUMMY)
			rekeningNummer = SetSpacing(AdoGetField(TABLE_DUMMY, "#v089 #"), 7)
			JetGet(TABLE_LEDGERACCOUNTS, 0, rekeningNummer)
			If KTRL Then
				rekeningNaam = SetSpacing("Rekening reeds vernietigd !!!", 30)
			Else
				RecordToField(TABLE_LEDGERACCOUNTS)
				rekeningNummer = SetSpacing(RS_MAR(TABLE_LEDGERACCOUNTS).Fields("v019").Value, 7)
				rekeningNaam = SetSpacing(RS_MAR(TABLE_LEDGERACCOUNTS).Fields("v020").Value, 30)
			End If
			aantalKeer = Val(AdoGetField(TABLE_DUMMY, "#v013 #"))
			bedrag = Val(AdoGetField(TABLE_DUMMY, "#v068 #"))

			If Tabul = 0 Then
				Tabul = 56
				Mid(PdfDetailLine, Tabul + 2) = Dec(aantalKeer, "####") & " x " & rekeningNummer & " " & rekeningNaam & " " & Dec(bedrag, MaskHere)
				pdfY = Mim.Report.Print(1, pdfY, PdfDetailLine & vbCrLf)
				If pdfY > 27.5 Then
					Mim.Report.PageBreak()
					VpePrintHeader()
				End If
				PdfDetailLine = Space(128)
			Else
				Tabul = 0
				Mid(PdfDetailLine, Tabul + 2) = Dec(aantalKeer, "####") & " x " & rekeningNummer & " " & rekeningNaam & " " & Dec(bedrag, MaskHere)
			End If
		Loop

		If Tabul = 0 Then
			pdfY = Mim.Report.Print(1, pdfY, PdfDetailLine & vbCrLf & vbCrLf)
		Else
			pdfY = Mim.Report.Print(1, pdfY, vbCrLf)
		End If

		'		Dim BedragVK2 As Double
		'		Dim BedragVK As Double

		'		BtwTotaalForfait = 0
		'		VakForfait(0) = 0
		'		VakForfait(1) = 0
		'		VakForfait(2) = 0
		'		VakForfait(3) = 0
		'		If Fixed Then
		'			Printer.Write(vbCrLf & vbCrLf & vbCrLf & vbCrLf)
		'			Printer.Print(TAB(2), "** FORFAITAIR STELSEL **")
		'			Printer.Write(vbCrLf & vbCrLf)
		'			Printer.Write(TAB(2), "FORFAITCODE", "AANKOOPBEDRAG", "FAKTOR", "VERKOOP 1", "KORTING", "VERKOOP NETTO", "BTW %", "BTW BEDRAG" & vbCrLf & vbCrLf)
		'			For Tel = 0 To 39
		'				If FixedAmount(Tel) <> 0 Then
		'					BedragVK2 = CDbl(VB6.Format(FixedAmount(Tel) * FixedPercentage(Tel), "0.00"))
		'					BedragVK = CDbl(VB6.Format(BedragVK2 - (BedragVK2 * KortingForfait(Tel) / 100), "0.00"))
		'					Printer.Write(TAB(2), Dec(Tel, "00"), Dec(FixedAmount(Tel), "########.00"), Dec(FixedPercentage(Tel), "####.0000"), Dec(BedragVK2, "########.00"), Dec(BedragVK - BedragVK2, "########.00"), Dec(BedragVK, "#######.00"), Dec(BtwForfait(Tel), "###.0"))
		'					ForfaitBtw = CDbl(VB6.Format(BedragVK * BtwForfait(Tel) / 100, "0.00"))
		'					Printer.Write(Dec(ForfaitBtw, "########.00") & vbCrLf)
		'					VakForfait(Int(Tel / 10)) = VakForfait(Int(Tel / 10)) + BedragVK
		'					BtwTotaalForfait = BtwTotaalForfait + ForfaitBtw
		'				End If
		'			Next 
		'			For Tel = 40 To 99
		'				If FixedAmount(Tel) <> 0 Then
		'					MsgBox("BTW aangifte Vak " & VB6.Format(System.Math.Abs(Tel / 10)) & " bestaat toch niet ?")
		'				End If
		'			Next 
		'			Printer.Write(vbCrLf & vbCrLf & vbCrLf & vbCrLf)
		'			Printer.Print(TAB(2), "** BTW VAKKEN **")
		'			For Tel = 0 To 3
		'				Printer.Write(TAB(2), "VAK " & Dec(Tel, "00") & " : " & Dec(VakForfait(Tel), "########.00") & vbCrLf)
		'			Next 
		'			Printer.Write(vbCrLf & vbCrLf)
		'			Printer.Print(TAB(2), "VAK 54 : " & Dec(BtwTotaalForfait, "########.00"))
		'End If

	End Sub

	Private Sub BSBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If BH_EURO Then
			MaskHere = "#####0.00"
		Else
			MaskHere = "########0"
		End If

		DateTimePickerProcessingDate.Text = MIM_GLOBAL_DATE

		Select Case A_INDEX
			Case TABLE_SUPPLIERS
				ListName = "Aankoopboek"
				A_INDEX = TABLE_SUPPLIERS
			Case TABLE_CUSTOMERS
				ListName = "Verkoopboek"
				A_INDEX = TABLE_CUSTOMERS
			Case Else
				MsgBox("Stop")
		End Select
		Text = ListName

		AgfControl()
		RbInvoices.Checked = True

		AD_NTDB.Execute("DELETE * FROM TmpBestand")
		'ClearFlDummy()

	End Sub

	Private Sub DateTimePickerProcessingDate_Leave(sender As Object, e As EventArgs) Handles DateTimePickerProcessingDate.Leave

		If Not IsDateOk(Format(DateTimePickerProcessingDate.Value, "ddMMyyyy"), PERIODAS_TEXT) Then
			MessageBox.Show("Datum verwerking buiten periode" & vbCrLf & vbCrLf & FormBYPERDAT.PeriodeBoekjaar.Text & "!", "Datum controle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			DateTimePickerProcessingDate.Focus()
		End If

	End Sub

	Private Sub BtnGenerateReport_Click(sender As Object, e As EventArgs) Handles BtnGenerateReport.Click

		Dim BeginSleutel As String
		Dim EindSleutel As String
		Dim BeginAV As String = ""
		Dim EindAV As String = ""

		Dim DummySleutel As String
		Dim Tekst As String

		Dim XX As Short
		Dim LengteSleutel As Short
		Dim sleutelIndex As Short
		Dim Tel As Short

		For T = 0 To 17
			ColumnTotal(T) = 0
		Next
		For T = 0 To 99
			FixedAmount(T) = 0
			FixedPercentage(T) = 0
		Next

		Select Case A_INDEX
			Case TABLE_SUPPLIERS
				BeginAV = "A"
				EindAV = "A"
			Case TABLE_CUSTOMERS
				BeginAV = "V"
				EindAV = "V"
			Case Else
				MsgBox("Stop")
		End Select
		Select Case RbInvoices.Checked
			Case -1
				BeginSleutel = BeginAV & "0" & Mid(PERIOD_FROMTO, 1, 4) & Dec(Val(lblFrom.Text), "00000")
				EindSleutel = EindAV & "0" & Mid(PERIOD_FROMTO, 1, 4) & Dec(Val(tbUntil.Text), "00000")
				Tekst = RbInvoices.Text
			Case Else
				BeginSleutel = BeginAV & "1" & Mid(PERIOD_FROMTO, 1, 4) & Dec(Val(lblFrom.Text), "00000")
				EindSleutel = EindAV & "1" & Mid(PERIOD_FROMTO, 1, 4) & Dec(Val(tbUntil.Text), "00000")
				Tekst = RbCreditNotes.Text
		End Select

		Cursor.Current = Cursors.WaitCursor
		Dim Result As Boolean = GetBSBookRecordSet(BeginSleutel, EindSleutel)

		If Not Result Then
			MsgBox("Geen documenten gevonden")
			Cursor.Current = Cursors.Default
			Exit Sub
		End If

		With Mim.Report
			.CloseDoc()
			.OpenDoc()
			.Author = "marIntegraal"
			.GUILanguage = 3 'Nederlands
			.Title = "Aankoop- en Verkoopboek"
		End With

		ReportText(2) = ListName & " " & ListSubName & " " & Mid(Mim.Text, InStr(Mim.Text, "["))
		ReportText(0) = Format(DateTimePickerProcessingDate.Value, "dd/MM/yyyy")
		VpePrintHeader()
		Line = 0

		rsSellersOrBuyersHere.MoveFirst()
		Do While Not rsSellersOrBuyersHere.EOF
			VpePrintLines()
			If cbJournalDetail.Checked Then
				LedgerAccountsDetail(rsSellersOrBuyersHere.Fields("v033").Value)
			End If
			rsSellersOrBuyersHere.MoveNext()
		Loop
		PrintTotal()
		If cbJournalDetail.Checked Then
			CumulPrint()
		End If

		Cursor.Current = Cursors.Default
		Mim.Report.Preview()
		Focus()

		MSG = "Totaliseren voor BTW AANGIFTE.  Bent U zeker?"
		If RbInvoices.Checked Then
			MSG = MSG & vbCrLf & vbCrLf & "Opgelet !  Creditnota's niet vergeten straks..."
		End If
		KTRL = MsgBox(MSG, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "BTW Aangifte")
		If KTRL = MsgBoxResult.Yes Then
			'GoSub BTWAangifte
		End If
		Refresh()
		Activate()
		rsSellersOrBuyersHere.Close()
		rsSellersOrBuyersHere = Nothing
		rsSorBJournalHere = Nothing
		If RbInvoices.Checked = True Then
			RbCreditNotes.Checked = True
		Else
			Close()
		End If
		Exit Sub

		' BTWAangifte: 
		'		JetGet(TABLE_VARIOUS, 1, SetSpacing("17" & BJPERDAT.Boekjaar.Text & VB6.Format(BJPERDAT.PeriodeBoekjaar.SelectedIndex + 1, "00"), 20))
		'		If KTRL Then
		'			MsgBox("Stop")
		'		Else
		'			RecordToVeld(TABLE_VARIOUS)
		'		End If

		'		'btwperiode bijvoegen vanaf 07/2008 voor Intervat
		'		If Mid(PERIOD_FROMTO.Value, 5, 2) = Mid(PERIOD_FROMTO.Value, 13, 2) Then
		'			'ok de periode marIntegraal staan op maandelijks
		'			AdoInsertToRecord(TABLE_VARIOUS, Mid(PERIOD_FROMTO.Value, 5, 2), "i001") 'werkelijke maand
		'			AdoInsertToRecord(TABLE_VARIOUS, Mid(PERIOD_FROMTO.Value, 1, 4), "i002") 'werkelijk jaar
		'		Else
		'			MsgBox("marIntegraal boekhoudperiodes staan nog altijd op 3-maandelijks.  Geen Intervat aangifte mogelijk met deze werkwijze die dateert van 1985-1994 en vermoedelijk overgenomen werd uit marIntegraal DOS periode. Contacteer ons 0475/292255 voor manuele tussenkomst!!)", MsgBoxStyle.Critical)
		'		End If

		'		Select Case A_INDEX
		'			Case TABLE_SUPPLIERS
		'				Select Case Ar
		'					Case 1
		'						'Record Kontroleren, zou MOETEN op nul staan...
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(16)), "v045") 'vak 59
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(9)), "v052") 'vak 86
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(11)), "v053") 'vak 87
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(12)), "v054") 'vak 88

		'						AdoInsertToRecord(TABLE_VARIOUS, VB6.Format(Val(TekstVan.Text), "00000"), "v092")
		'						AdoInsertToRecord(TABLE_VARIOUS, VB6.Format(Val(TekstLijn(3).Text), "00000"), "v093")

		'					Case 3
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(16)), "v100") 'vak 63
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(7)), "v050") 'vak 84
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(8)), "v051") 'vak 85

		'						AdoInsertToRecord(TABLE_VARIOUS, VB6.Format(Val(TekstVan.Text), "00000"), "v094")
		'						AdoInsertToRecord(TABLE_VARIOUS, VB6.Format(Val(TekstLijn(3).Text), "00000"), "v095")
		'						For Tel = 3 To 16
		'							ColumnTotal(Tel) = -ColumnTotal(Tel)
		'						Next 
		'					Case Else
		'						MsgBox("Stop")
		'				End Select

		'				AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(13) + Val(AdoGetField(TABLE_VARIOUS, "#v042 #"))), "v042") 'vak 55
		'				AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(14) + Val(AdoGetField(TABLE_VARIOUS, "#v043 #"))), "v043") 'vak 56
		'				AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(15) + Val(AdoGetField(TABLE_VARIOUS, "#v044 #"))), "v044") 'vak 57
		'				AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(3) + Val(AdoGetField(TABLE_VARIOUS, "#v046 #"))), "v046") 'vak 81
		'				AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(4) + Val(AdoGetField(TABLE_VARIOUS, "#v047 #"))), "v047") 'vak 82
		'				AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(5) + Val(AdoGetField(TABLE_VARIOUS, "#v048 #"))), "v048") 'vak 83

		'				If Fixed Then
		'					AdoInsertToRecord(TABLE_VARIOUS, Str(VakForfait(0)), "v055") 'vak 00
		'					AdoInsertToRecord(TABLE_VARIOUS, Str(VakForfait(1)), "v056") 'vak 01
		'					AdoInsertToRecord(TABLE_VARIOUS, Str(VakForfait(2)), "v057") 'vak 02
		'					AdoInsertToRecord(TABLE_VARIOUS, Str(VakForfait(3)), "v058") 'vak 03
		'					AdoInsertToRecord(TABLE_VARIOUS, Str(BtwTotaalForfait), "v064") 'vak 54
		'				End If

		'			Case TABLE_CUSTOMERS
		'				Select Case Ar
		'					Case 12
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(12)), "v064") 'vak 54
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(2) + Val(AdoGetField(TABLE_VARIOUS, "#v055 #"))), "v055") 'vak 00 bijtellen ?

		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(3)), "v056") 'vak 01
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(4)), "v057") 'vak 02
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(5)), "v058") 'vak 03
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(6)), "v059") 'vak 45
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(7)), "v060") 'vak 46
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(8)), "v061") 'vak 47

		'						AdoInsertToRecord(TABLE_VARIOUS, VB6.Format(Val(TekstVan.Text), "00000"), "v096")
		'						AdoInsertToRecord(TABLE_VARIOUS, VB6.Format(Val(TekstLijn(3).Text), "00000"), "v097")

		'					Case 14
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(12)), "v101") 'vak 64
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(Val(AdoGetField(TABLE_VARIOUS, "#v055 #")) - ColumnTotal(2)), "v055") 'vak 00 aftrekken ?

		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(10)), "v062") 'vak 48
		'						AdoInsertToRecord(TABLE_VARIOUS, Str(ColumnTotal(11)), "v063") 'vak 49

		'						AdoInsertToRecord(TABLE_VARIOUS, VB6.Format(Val(TekstVan.Text), "00000"), "v098")
		'						AdoInsertToRecord(TABLE_VARIOUS, VB6.Format(Val(TekstLijn(3).Text), "00000"), "v099")

		'					Case Else
		'						MsgBox("Stop")
		'				End Select
		'			Case Else
		'				MsgBox("Stop")
		'		End Select

		'		If BH_EURO Then
		'			AdoInsertToRecord(TABLE_VARIOUS, "EUR", "vEUR")
		'		End If

		'		bUpdate(TABLE_VARIOUS, 1)
		'		Select Case FaktuurCreditnota(0).Checked
		'			Case True 'Faktuur
		'				If A_INDEX = TABLE_SUPPLIERS Then
		'					SS99(TekstLijn(3).Text, 2)
		'				Else
		'					SS99(TekstLijn(3).Text, 12)
		'				End If

		'			Case False
		'				If A_INDEX = TABLE_SUPPLIERS Then
		'					SS99(TekstLijn(3).Text, 4)
		'				Else
		'					SS99(TekstLijn(3).Text, 14)
		'				End If
		'		End Select
		'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'		Return 

	End Sub

	Private Sub RbInvoices_CheckedChanged(sender As Object, e As EventArgs) Handles RbInvoices.CheckedChanged
		InvoiceCreditNoteCheck()
	End Sub

	Private Sub RbCreditNotes_CheckedChanged(sender As Object, e As EventArgs) Handles RbCreditNotes.CheckedChanged
		InvoiceCreditNoteCheck()
	End Sub

	Private Sub BSBook_FormClosing(sender As Object, e As FormClosingEventArgs)

		Dim CancelHere As Boolean = e.Cancel
		If Mim.Report.IsOpen = True Then
			MsgBox("Sluit eerst het PDF venster a.u.b.", MsgBoxStyle.Information)
			CancelHere = True
		Else
			Select Case A_INDEX
				Case TABLE_SUPPLIERS
					Mim.PurchaseDiaryMenuItem.Enabled = True
				Case TABLE_CUSTOMERS
					Mim.SalesDiaryMenuItem.Enabled = True
				Case Else
					MsgBox("Stop")
			End Select
		End If
		e.Cancel = CancelHere

	End Sub

End Class

