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
		Select Case aIndex
			Case TableOfSuppliers
				T = 0
			Case TableOfCustomers
				T = 10
			Case Else
				MsgBox("Stop")
		End Select

		NumberHere = 0
		Select Case RbInvoices.Checked
			Case True 'Factuur
				ListSubName = "Facturen"
				Fl99Record = String99(Reading, 1 + T)
				tbUntil.Text = Format(Val(Fl99Record), "00000")
				Fl99Record = String99(Reading, 2 + T)
				If Format(Val(Fl99Record), "00000") = tbUntil.Text Then
					BtnGenerateReport.Enabled = False
					lblFrom.Text = Format(Val(Fl99Record), "00000")
				Else
					BtnGenerateReport.Enabled = True
					lblFrom.Text = Format(Val(Fl99Record) + 1, "00000")
				End If
				If aIndex = TableOfSuppliers Then
					Ar = 1
					NumberHere = Val(AdoGetField(TableOfVarious, "#v092 #")) + Val(AdoGetField(TableOfVarious, "#v093 #"))
				Else
					Ar = 12
					NumberHere = Val(AdoGetField(TableOfVarious, "#v096 #")) + Val(AdoGetField(TableOfVarious, "#v097 #"))
				End If
			Case Else
				ListSubName = "Creditnota's"
				Fl99Record = String99(Reading, 3 + T)
				tbUntil.Text = Format(Val(Fl99Record), "00000")
				Fl99Record = String99(Reading, 4 + T)
				If Format(Val(Fl99Record), "00000") = tbUntil.Text Then
					BtnGenerateReport.Enabled = False
					lblFrom.Text = Format(Val(Fl99Record), "00000")
				Else
					BtnGenerateReport.Enabled = True
					lblFrom.Text = Format(Val(Fl99Record) + 1, "00000")
				End If
				If aIndex = TableOfSuppliers Then
					Ar = 3
					NumberHere = Val(AdoGetField(TableOfVarious, "#v094 #")) + Val(AdoGetField(TableOfVarious, "#v095 #"))
				Else
					Ar = 14
					NumberHere = Val(AdoGetField(TableOfVarious, "#v098 #")) + Val(AdoGetField(TableOfVarious, "#v099 #"))
				End If
		End Select
		If NumberHere Then
			MsgBox("Binnen deze periode, zijn er reeds" & vbCrLf & "dokumenten opgenomen !", 0, "BTW aangifte kontroleren a.u.b. !")
			BtnGenerateReport.Enabled = False
		Else
			'Drukken.Enabled = True
		End If
	End Sub

	Sub AgfControl()

		Dim PeriodeSleutel As String
		Dim T As Integer
		Dim PeriodeMax As Integer

		Ktrl = 0
		PeriodeMax = FormBYPERDAT.PeriodeBoekjaar.Items.Count + 1
		Do While PeriodeMax > FormBYPERDAT.PeriodeBoekjaar.SelectedIndex + 1
			PeriodeSleutel = "17" & FormBYPERDAT.Boekjaar.Text & Format(PeriodeMax, "00")
			JetGet(TableOfVarious, 1, PeriodeSleutel)
			If Ktrl Then
				TLBRecord(TableOfVarious) = ""
				AdoInsertToRecord(TableOfVarious, (FormBYPERDAT.Boekjaar.Text), "v090")
				AdoInsertToRecord(TableOfVarious, Format(PeriodeMax, "00"), "v091")
				AdoInsertToRecord(TableOfVarious, "17" & AdoGetField(TableOfVarious, "#v090 #") & AdoGetField(TableOfVarious, "#v091 #"), "v005")
				JetInsert(TableOfVarious, 1)
			Else
				RecordToField(TableOfVarious)
				NumberHere = 0
				For T = 92 To 99
					NumberHere += Val(AdoGetField(TableOfVarious, "#v" & Format(T, "000") & " #"))
				Next
				If NumberHere Then
					NumberHere = PeriodeMax
					'PeriodeMax = 0
					Exit Do
				End If
			End If
			PeriodeMax -= 1
		Loop
jump:
		If NumberHere Then
			MsgBox("Periode " & Format(NumberHere, "00") & " reeds afgesloten...")
			BtnGenerateReport.Visible = False
			Exit Sub
		Else
			PeriodeSleutel = "17" & FormBYPERDAT.Boekjaar.Text & Format(FormBYPERDAT.PeriodeBoekjaar.SelectedIndex + 1, "00")
			JetGet(TableOfVarious, 1, PeriodeSleutel)
			If Ktrl Then
				TLBRecord(TableOfVarious) = ""
				AdoInsertToRecord(TableOfVarious, (FormBYPERDAT.Boekjaar.Text), "v090")
				AdoInsertToRecord(TableOfVarious, Format(FormBYPERDAT.PeriodeBoekjaar.SelectedIndex + 1, "00"), "v091")
				AdoInsertToRecord(TableOfVarious, "17" & AdoGetField(TableOfVarious, "#v090 #") & AdoGetField(TableOfVarious, "#v091 #"), "v005")
				JetInsert(TableOfVarious, 1)
				GoTo jump
			Else
				RecordToField(TableOfVarious)
			End If
		End If

		If Mid(String99(Reading, 20), 1, 1) = "4" Then
			Fixed = 1
		Else
			Fixed = 0
		End If

	End Sub

	Private Sub InitialiseFields()
		Dim T As Short

		ReportFieldNr(0) = 33
		ReportWay(0) = 0 'niks omwerken gewoon afdrukken
		ReportField(0) = "Document"
		ReportTab(0) = 2

		ReportFieldNr(1) = 35
		ReportWay(1) = 5 'datum omwerken
		ReportField(1) = "Datum doc."
		ReportTab(1) = 14

		Select Case aIndex
			Case TableOfSuppliers
				ReportFieldNr(2) = 39
				ReportWay(2) = 0
				ReportField(2) = "Referte"
				ReportTab(2) = 25

				ReportFieldNr(3) = 46
				ReportWay(3) = 9 'geheel NumberHere geformateerd
				ReportField(3) = "   VAK 81"
				ReportTab(3) = 46

				ReportFieldNr(4) = 47
				ReportWay(4) = 9
				ReportField(4) = "   VAK 82"
				ReportTab(4) = 56

				ReportFieldNr(5) = 48
				ReportWay(5) = 9
				ReportField(5) = "   VAK 83"
				ReportTab(5) = 66

				ReportFieldNr(6) = 49
				ReportWay(6) = 9
				ReportField(6) = "   DERDEN"
				ReportTab(6) = 76

				ReportFieldNr(7) = 50
				ReportWay(7) = 9
				ReportField(7) = "   VAK 84"
				ReportTab(7) = 86

				ReportFieldNr(8) = 51
				ReportWay(8) = 9
				ReportField(8) = "   VAK 85"
				ReportTab(8) = 96

				ReportFieldNr(9) = 52
				ReportWay(9) = 9
				ReportField(9) = "   VAK 86"
				ReportTab(9) = 106

				ReportFieldNr(10) = 99
				ReportWay(10) = 1 'zoek flpartij kode+naam1
				ReportField(10) = "ID.Kode/Naam"
				ReportTab(10) = 2

				ReportFieldNr(11) = 53
				ReportWay(11) = 9
				ReportField(11) = "   VAK 87"
				ReportTab(11) = 56

				ReportFieldNr(12) = 54
				ReportWay(12) = 9
				ReportField(12) = "   VAK 88"
				ReportTab(12) = 66

				ReportFieldNr(13) = 42
				ReportWay(13) = 9
				ReportField(13) = "   VAK 55"
				ReportTab(13) = 76

				ReportFieldNr(14) = 43
				ReportWay(14) = 9
				ReportField(14) = "   VAK 56"
				ReportTab(14) = 86

				ReportFieldNr(15) = 44
				ReportWay(15) = 9
				ReportField(15) = "   VAK 57"
				ReportTab(15) = 96

				ReportFieldNr(16) = 45
				ReportWay(16) = 9
				ReportTab(16) = 106

				Select Case Ar
					Case 1
						ReportField(16) = "   VAK 59"
					Case Else
						ReportField(16) = "   VAK 63"
				End Select
				ReportTab(17) = 0
				tMaxField = 16

			Case TableOfCustomers
				ReportFieldNr(2) = 55
				ReportWay(2) = 9 'geheel NumberHere geformateerd
				ReportField(2) = "VAK 00"
				ReportTab(2) = 44

				ReportFieldNr(3) = 56
				ReportWay(3) = 9
				ReportField(3) = "VAK 01"
				ReportTab(3) = 55

				ReportFieldNr(4) = 57
				ReportWay(4) = 9
				ReportField(4) = "VAK 02"
				ReportTab(4) = 66

				ReportFieldNr(5) = 58
				ReportWay(5) = 9
				ReportField(5) = "VAK 03"
				ReportTab(5) = 77

				ReportFieldNr(6) = 59
				ReportWay(6) = 9
				ReportField(6) = "VAK 45"
				ReportTab(6) = 88

				ReportFieldNr(7) = 60
				ReportWay(7) = 9
				ReportField(7) = "VAK 46"
				ReportTab(7) = 99

				ReportFieldNr(8) = 61
				ReportWay(8) = 9
				ReportField(8) = "VAK 47"
				ReportTab(8) = 110

				ReportFieldNr(9) = 99
				ReportWay(9) = 1
				ReportField(9) = "ID.Kode/Naam"
				ReportTab(9) = 2

				ReportFieldNr(10) = 62
				ReportWay(10) = 9
				ReportField(10) = "VAK 48"
				ReportTab(10) = 77


				ReportFieldNr(11) = 63
				ReportWay(11) = 9
				ReportField(11) = "VAK 49"
				ReportTab(11) = 88

				ReportFieldNr(12) = 64
				ReportWay(12) = 9
				ReportTab(12) = 99

				Select Case Ar
					Case 12
						ReportField(12) = "VAK 54"
					Case Else
						ReportField(12) = "VAK 64"
				End Select
				tMaxField = 12
				ReportTab(13) = 0
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
					Mid(pdfReportTitle, ReportTab(T)) = ReportField(T)
					If ReportTab(T + 1) < ReportTab(T) Then SecondLine = True
				Case True
					Mid(pdfReportTitle2, ReportTab(T)) = ReportField(T)
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

		PageCounter += 1
		pdfY = Mim.Report.Print(1, 1, ReportText(2))
		pdfY = Mim.Report.Print(17, 1, "Pagina : " & Dec(PageCounter, "##########") & vbCrLf)
		pdfY = Mim.Report.Print(17, pdfY, "Datum  : " & ReportText(0) & vbCrLf & vbCrLf)
		pdfY = Mim.Report.Print(1, pdfY, FullLine & vbCrLf)
		pdfY = Mim.Report.Print(1, pdfY, pdfReportTitle & vbCrLf)
		pdfY = Mim.Report.Print(1, pdfY, pdfReportTitle2 & vbCrLf)
		pdfY = Mim.Report.Print(1, pdfY, FullLine & vbCrLf & vbCrLf)

	End Sub

	Private Sub VpePrintLines()
		Dim SecondLine = False
		Dim PdfLine As String = Space(128)
		Dim PdfLine2 As String = Space(128)
		Dim T = 0
		Dim VeldTekst = ""

		Do While ReportTab(T) <> 0
			Select Case ReportWay(T)
				Case 1
					JetGet(aIndex, 0, SetSpacing(Mid(RV(rsSellersOrBuyersHere, "v034"), 2), FlIndexLen(aIndex, 0)))
					If Ktrl = 0 Then
						'RecordToField(aIndex)
						VeldTekst = Trim(RV(rsMAR(aIndex), "A110")) & " " & Trim(RV(rsMAR(aIndex), "A100"))
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
					Mid(PdfLine, ReportTab(T)) = VeldTekst
					If ReportTab(T + 1) < ReportTab(T) Then SecondLine = True
				Case True
					Mid(PdfLine2, ReportTab(T)) = VeldTekst
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

		Do While ReportTab(T) <> 0
			VeldTekst = ""
			Select Case ReportWay(T)
				Case 9
					VeldTekst = Dec(ColumnTotal(T), MaskHere)
			End Select
			Select Case SecondLine
				Case True
					Mid(PdfLine2, ReportTab(T)) = VeldTekst
				Case False
					Mid(PdfLine, ReportTab(T)) = VeldTekst
					If ReportTab(T + 1) < ReportTab(T) Then SecondLine = True
			End Select
			T += 1
		Loop
		pdfY = Mim.Report.Print(1, pdfY, FullLine & vbCrLf)
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

		Ktrl = GetJourRecordSet(key33)
		If Not Ktrl Then
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
				JetGet(TableOfLedgerAccounts, 0, rsSorBJournalHere("v019").Value.ToString)
				If Ktrl = 0 Then
					RekeningNaam = SetSpacing(Trim(RV(rsMAR(TableOfLedgerAccounts), "v020")), 30)
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
		'		If RTrim(RV(rsMAR(TableOfLedgerAccounts), "v216")) <> "" Then
		'			'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'			ForfaitNr = Val(RV(rsMAR(TableOfLedgerAccounts), "v216"))
		'			'UPGRADE_WARNING: Couldn't resolve default property of object RV(rsSorBJournalHere, dece068). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'			FixedAmount(ForfaitNr) = FixedAmount(ForfaitNr) + RV(rsSorBJournalHere, "dece068")
		'			If FixedPercentage(ForfaitNr) = 0 Then
		'				'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'				JetGet(TableOfVarious, 1, SetSpacing("21" + RV(rsMAR(TableOfLedgerAccounts), "v216"), 20))
		'				If Ktrl Then
		'					'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'					MsgBox("Forfaitaire Kode : " + RV(rsMAR(TableOfLedgerAccounts), "v216") + " en waarde nog niet aanwezig.  Eerst inbrengen via diverse gebruikersfiches pér bedrijf a.u.b. !")
		'				Else
		'					RecordToVeld(TableOfVarious)
		'					FixedPercentage(ForfaitNr) = Val(AdoGetField(TableOfVarious, "#v218 #"))
		'					BtwForfait(ForfaitNr) = Val(Mid(fmarBoxText("002", "2", AdoGetField(TableOfVarious, "#v111 #")), 4, 4))
		'					KortingForfait(ForfaitNr) = Val(AdoGetField(TableOfVarious, "#v230 #"))
		'				End If
		'			End If
		'		End If
		'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'		Return 

	End Sub

	Private Sub CumulUpdate(account As String, amount As Double)

StartPunt:
		JetGet(TableDummy, 0, account)
		If Ktrl Then
			TLBRecord(TableDummy) = ""
			AdoInsertToRecord(TableDummy, account, "v089")
			AdoInsertToRecord(TableDummy, "0", "v013")
			AdoInsertToRecord(TableDummy, "0", "v068")
			JetInsert(TableDummy, 0)
			GoTo StartPunt
		Else
			RecordToField(TableDummy)
			AdoInsertToRecord(TableDummy, Str(Val(AdoGetField(TableDummy, "#v013 #")) + 1), "v013")
			AdoInsertToRecord(TableDummy, Str(Val(AdoGetField(TableDummy, "#v068 #")) + amount), "v068")
			bUpdate(TableDummy, 0)
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
		rsSellersOrBuyersHere.Open(sSQL, adntDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
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
		rsDummy.Open(sSQL, adntDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
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
		rsSorBJournalHere.Open(sSQL, adntDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
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

		JetTableClose(TableDummy)
		JetGetFirst(TableDummy, 0)
		RecordToField(TableDummy)
		rekeningNummer = SetSpacing(AdoGetField(TableDummy, "#v089 #"), 7)
		JetGet(TableOfLedgerAccounts, 0, rekeningNummer)
		If Ktrl Then
			rekeningNaam = SetSpacing("Rekening reeds vernietigd !!!", 30)
		Else
			RecordToField(TableOfLedgerAccounts)
			rekeningNummer = SetSpacing(rsMAR(TableOfLedgerAccounts).Fields("v019").Value, 7)
			rekeningNaam = SetSpacing(rsMAR(TableOfLedgerAccounts).Fields("v020").Value, 30)
		End If
		aantalKeer = Val(AdoGetField(TableDummy, "#v013 #"))
		bedrag = Val(AdoGetField(TableDummy, "#v068 #"))

		Tabul = 0
		Mid(PdfDetailLine, Tabul + 2) = Dec(aantalKeer, "####") & " x " & rekeningNummer & " " & rekeningNaam & " " & Dec(bedrag, MaskHere)

		Do
			bNext(TableDummy, 0, rekeningNummer)
			If Ktrl Then
				Exit Do
			End If
			RecordToField(TableDummy)
			rekeningNummer = SetSpacing(AdoGetField(TableDummy, "#v089 #"), 7)
			JetGet(TableOfLedgerAccounts, 0, rekeningNummer)
			If Ktrl Then
				rekeningNaam = SetSpacing("Rekening reeds vernietigd !!!", 30)
			Else
				RecordToField(TableOfLedgerAccounts)
				rekeningNummer = SetSpacing(rsMAR(TableOfLedgerAccounts).Fields("v019").Value, 7)
				rekeningNaam = SetSpacing(rsMAR(TableOfLedgerAccounts).Fields("v020").Value, 30)
			End If
			aantalKeer = Val(AdoGetField(TableDummy, "#v013 #"))
			bedrag = Val(AdoGetField(TableDummy, "#v068 #"))

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

		If bhEuro Then
			MaskHere = "#####0.00"
		Else
			MaskHere = "########0"
		End If

		DateTimePickerProcessingDate.Text = MimGlobalDate

		Select Case aIndex
			Case TableOfSuppliers
				ListName = "Aankoopboek"
				aIndex = TableOfSuppliers
			Case TableOfCustomers
				ListName = "Verkoopboek"
				aIndex = TableOfCustomers
			Case Else
				MsgBox("Stop")
		End Select
		Text = ListName

		AgfControl()
		RbInvoices.Checked = True

		adntDB.Execute("DELETE * FROM TmpBestand")
		'ClearFlDummy()

	End Sub

	Private Sub DateTimePickerProcessingDate_Leave(sender As Object, e As EventArgs) Handles DateTimePickerProcessingDate.Leave

		If Not DatumKtrl(Format(DateTimePickerProcessingDate.Value, "ddMMyyyy"), PeriodAsText) Then
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

		Select Case aIndex
			Case TableOfSuppliers
				BeginAV = "A"
				EindAV = "A"
			Case TableOfCustomers
				BeginAV = "V"
				EindAV = "V"
			Case Else
				MsgBox("Stop")
		End Select
		Select Case RbInvoices.Checked
			Case -1
				BeginSleutel = BeginAV & "0" & Mid(PeriodFromTo, 1, 4) & Dec(Val(lblFrom.Text), "00000")
				EindSleutel = EindAV & "0" & Mid(PeriodFromTo, 1, 4) & Dec(Val(tbUntil.Text), "00000")
				Tekst = RbInvoices.Text
			Case Else
				BeginSleutel = BeginAV & "1" & Mid(PeriodFromTo, 1, 4) & Dec(Val(lblFrom.Text), "00000")
				EindSleutel = EindAV & "1" & Mid(PeriodFromTo, 1, 4) & Dec(Val(tbUntil.Text), "00000")
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

		Msg = "Totaliseren voor BTW AANGIFTE.  Bent U zeker?"
		If RbInvoices.Checked Then
			Msg = Msg & vbCrLf & vbCrLf & "Opgelet !  Creditnota's niet vergeten straks..."
		End If
		Ktrl = MsgBox(Msg, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "BTW Aangifte")
		If Ktrl = MsgBoxResult.Yes Then
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
		'		JetGet(TableOfVarious, 1, SetSpacing("17" & BJPERDAT.Boekjaar.Text & VB6.Format(BJPERDAT.PeriodeBoekjaar.SelectedIndex + 1, "00"), 20))
		'		If Ktrl Then
		'			MsgBox("Stop")
		'		Else
		'			RecordToVeld(TableOfVarious)
		'		End If

		'		'btwperiode bijvoegen vanaf 07/2008 voor Intervat
		'		If Mid(PeriodFromTo.Value, 5, 2) = Mid(PeriodFromTo.Value, 13, 2) Then
		'			'ok de periode marIntegraal staan op maandelijks
		'			AdoInsertToRecord(TableOfVarious, Mid(PeriodFromTo.Value, 5, 2), "i001") 'werkelijke maand
		'			AdoInsertToRecord(TableOfVarious, Mid(PeriodFromTo.Value, 1, 4), "i002") 'werkelijk jaar
		'		Else
		'			MsgBox("marIntegraal boekhoudperiodes staan nog altijd op 3-maandelijks.  Geen Intervat aangifte mogelijk met deze werkwijze die dateert van 1985-1994 en vermoedelijk overgenomen werd uit marIntegraal DOS periode. Contacteer ons 0475/292255 voor manuele tussenkomst!!)", MsgBoxStyle.Critical)
		'		End If

		'		Select Case aIndex
		'			Case TableOfSuppliers
		'				Select Case Ar
		'					Case 1
		'						'Record Kontroleren, zou MOETEN op nul staan...
		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(16)), "v045") 'vak 59
		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(9)), "v052") 'vak 86
		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(11)), "v053") 'vak 87
		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(12)), "v054") 'vak 88

		'						AdoInsertToRecord(TableOfVarious, VB6.Format(Val(TekstVan.Text), "00000"), "v092")
		'						AdoInsertToRecord(TableOfVarious, VB6.Format(Val(TekstLijn(3).Text), "00000"), "v093")

		'					Case 3
		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(16)), "v100") 'vak 63
		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(7)), "v050") 'vak 84
		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(8)), "v051") 'vak 85

		'						AdoInsertToRecord(TableOfVarious, VB6.Format(Val(TekstVan.Text), "00000"), "v094")
		'						AdoInsertToRecord(TableOfVarious, VB6.Format(Val(TekstLijn(3).Text), "00000"), "v095")
		'						For Tel = 3 To 16
		'							ColumnTotal(Tel) = -ColumnTotal(Tel)
		'						Next 
		'					Case Else
		'						MsgBox("Stop")
		'				End Select

		'				AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(13) + Val(AdoGetField(TableOfVarious, "#v042 #"))), "v042") 'vak 55
		'				AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(14) + Val(AdoGetField(TableOfVarious, "#v043 #"))), "v043") 'vak 56
		'				AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(15) + Val(AdoGetField(TableOfVarious, "#v044 #"))), "v044") 'vak 57
		'				AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(3) + Val(AdoGetField(TableOfVarious, "#v046 #"))), "v046") 'vak 81
		'				AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(4) + Val(AdoGetField(TableOfVarious, "#v047 #"))), "v047") 'vak 82
		'				AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(5) + Val(AdoGetField(TableOfVarious, "#v048 #"))), "v048") 'vak 83

		'				If Fixed Then
		'					AdoInsertToRecord(TableOfVarious, Str(VakForfait(0)), "v055") 'vak 00
		'					AdoInsertToRecord(TableOfVarious, Str(VakForfait(1)), "v056") 'vak 01
		'					AdoInsertToRecord(TableOfVarious, Str(VakForfait(2)), "v057") 'vak 02
		'					AdoInsertToRecord(TableOfVarious, Str(VakForfait(3)), "v058") 'vak 03
		'					AdoInsertToRecord(TableOfVarious, Str(BtwTotaalForfait), "v064") 'vak 54
		'				End If

		'			Case TableOfCustomers
		'				Select Case Ar
		'					Case 12
		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(12)), "v064") 'vak 54
		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(2) + Val(AdoGetField(TableOfVarious, "#v055 #"))), "v055") 'vak 00 bijtellen ?

		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(3)), "v056") 'vak 01
		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(4)), "v057") 'vak 02
		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(5)), "v058") 'vak 03
		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(6)), "v059") 'vak 45
		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(7)), "v060") 'vak 46
		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(8)), "v061") 'vak 47

		'						AdoInsertToRecord(TableOfVarious, VB6.Format(Val(TekstVan.Text), "00000"), "v096")
		'						AdoInsertToRecord(TableOfVarious, VB6.Format(Val(TekstLijn(3).Text), "00000"), "v097")

		'					Case 14
		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(12)), "v101") 'vak 64
		'						AdoInsertToRecord(TableOfVarious, Str(Val(AdoGetField(TableOfVarious, "#v055 #")) - ColumnTotal(2)), "v055") 'vak 00 aftrekken ?

		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(10)), "v062") 'vak 48
		'						AdoInsertToRecord(TableOfVarious, Str(ColumnTotal(11)), "v063") 'vak 49

		'						AdoInsertToRecord(TableOfVarious, VB6.Format(Val(TekstVan.Text), "00000"), "v098")
		'						AdoInsertToRecord(TableOfVarious, VB6.Format(Val(TekstLijn(3).Text), "00000"), "v099")

		'					Case Else
		'						MsgBox("Stop")
		'				End Select
		'			Case Else
		'				MsgBox("Stop")
		'		End Select

		'		If bhEuro Then
		'			AdoInsertToRecord(TableOfVarious, "EUR", "vEUR")
		'		End If

		'		bUpdate(TableOfVarious, 1)
		'		Select Case FaktuurCreditnota(0).Checked
		'			Case True 'Faktuur
		'				If aIndex = TableOfSuppliers Then
		'					SS99(TekstLijn(3).Text, 2)
		'				Else
		'					SS99(TekstLijn(3).Text, 12)
		'				End If

		'			Case False
		'				If aIndex = TableOfSuppliers Then
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

End Class

