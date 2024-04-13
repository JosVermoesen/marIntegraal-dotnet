Public Class frmBalansKlantLeverancier
    Private Sub frmBalansKlantLeverancier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Drukken_Click(sender As Object, e As EventArgs) Handles Drukken.Click

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class BalansKL
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Dim ReportText(5) As String

'	Dim RapportSelektie As String
'	Dim RapportTitel As String
'	Dim RapportDefinitie As String
'	Dim ListName As String
'	Dim FieldText(20) As String
'	Dim FlPartij As Short
'	Dim DocTeller As Short

'	Dim dttot As Double
'	Dim dtbtw As Double
'	Dim dvtot As Double
'	Dim dTrb As Double

'	Dim TotaalBTW As Double
'	Dim TotaalGOED As Double
'	Dim TotaalALBETAALD As Double
'	Dim TotaalNOGTEBETALEN As Double
'	Dim TotaalVOOR As Double
'	Dim TotaalNA As Double

'	Dim PeriodFromChosen As New VB6.FixedLengthString(8)
'	Dim PeriodToChosen As New VB6.FixedLengthString(8)

'	Dim BHDetailTekst(3) As String
'	Dim AantalBovenPeriode As Short
'	Dim AantalOnderPeriode As Short
'	Dim TotaalDokBovenPeriode As Double
'	Dim TotaalDokOnderPeriode As Double

'	Private Sub Annuleren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Annuleren.Click

'		Me.Close()

'	End Sub

'	'UPGRADE_WARNING: Event cbLijstPrinterHier.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub cbLijstPrinterHier_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbLijstPrinterHier.SelectedIndexChanged
'		Dim Printer As New Printer

'		LijstPrinterNr = cbLijstPrinterHier.SelectedIndex
'		Printer = Printers(LijstPrinterNr)

'	End Sub

'	Private Sub cbTogglePrinter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbTogglePrinter.Click

'		Me.cbLijstPrinterHier.Enabled = Not Me.cbLijstPrinterHier.Enabled

'	End Sub

'	'UPGRADE_WARNING: Event chkAfdrukLiggend.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub chkAfdrukLiggend_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAfdrukLiggend.CheckStateChanged
'		Dim Printer As New Printer

'		Printer = Printers(LijstPrinterNr)
'		On Error Resume Next
'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		Printer.PaperBin = LaadTekst(My.Application.Info.Title, "LIJSTPRINTER")
'		If chkAfdrukLiggend.CheckState = 1 Then
'			Printer.Orientation = PrinterObjectConstants.vbPRORLandscape
'		Else
'			Printer.Orientation = PrinterObjectConstants.vbPRORPortrait
'		End If

'	End Sub


'	'UPGRADE_WARNING: Event ChkFinancieelDetail.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub ChkFinancieelDetail_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ChkFinancieelDetail.CheckStateChanged

'		If ChkFinancieelDetail.CheckState = 0 Then
'			'Selektie(1).Enabled = False
'			Selektie(1).CheckState = False
'			Selektie(5).Enabled = False
'			Selektie(5).CheckState = False
'		Else
'			'Selektie(1).Enabled = True
'			Selektie(5).Enabled = True
'		End If

'	End Sub

'	Private Sub CmdBewaar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdBewaar.Click

'		BeWaarTekst("dokumentenBalans", "KontroleVervaldag", CStr(Selektie(0).CheckState))
'		BeWaarTekst("dokumentenBalans", "GeenBetalingHogerBoekjaar", CStr(Selektie(1).CheckState))
'		BeWaarTekst("dokumentenBalans", "PeriodeBegrenzen", CStr(Selektie(2).CheckState))
'		BeWaarTekst("dokumentenBalans", "EnkelNietBetaaldedokumenten", CStr(Selektie(3).CheckState))
'		BeWaarTekst("dokumentenBalans", "-dokumenten-1994Uitsluiten", CStr(Selektie(4).CheckState))
'		BeWaarTekst("dokumentenBalans", "BetalingsKontrole", CStr(Selektie(5).CheckState))
'		BeWaarTekst("dokumentenBalans", "FinancieelDetailViaJournaal", CStr(ChkFinancieelDetail.CheckState))
'		BeWaarTekst("dokumentenBalans", "AfdrukInRooster", CStr(chkAfdrukInVenster.CheckState))

'	End Sub


'	Private Sub cmdEuroCheck_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEuroCheck.Click

'		Dim dBTW As Decimal
'		Dim dTOT As Decimal

'		Dim Teller As Short

'		Dim TotaalAantalBEF As Integer
'		Dim TotaalAantalEUR As Integer
'		Dim TotaalGewijzigd As Integer

'		Exit Sub

'		Msg = "Hierna kan U de totaalbedragen pér dokument terug"
'		Msg = Msg & vbCr & "hertotaliseren in BEF voor vorige boekjaren"
'		Msg = Msg & vbCr & "en vervolgens in EUR beschikbaar maken."
'		Msg = Msg & vbCr & vbCr
'		Msg = Msg & "Mag de herrekening gestart worden."
'		KtrlBox = MsgBox(Msg, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2)
'		If KtrlBox = MsgBoxResult.No Then
'			Exit Sub
'		End If
'		JetGetFirst(TableOfInvoices, 1)
'		If Ktrl Then
'			MsgBox("stop")
'			Exit Sub
'		Else
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'			Me.Enabled = False
'			Do 
'				'UPGRADE_ISSUE: DoEvents does not return a value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8D115264-E27F-4472-A684-865A00B5E826"'
'				XDoEvents = System.Windows.Forms.Application.DoEvents()
'				RecordToField(TableOfInvoices)
'				If DatumKtrl(AdoGetField(TableOfInvoices, "#v035 #"), BookyearAsKey) = False Then
'					TotaalAantalBEF = TotaalAantalBEF + 1
'					Select Case VB.Left(AdoGetField(TableOfInvoices, "#v034 #"), 1)
'						Case "K"
'							Select Case VB.Left(AdoGetField(TableOfInvoices, "#v033 #"), 1)
'								Case "V"
'									dBTW = Val(AdoGetField(TableOfInvoices, "#v064 #"))
'									dTOT = 0
'									For Teller = 55 To 63
'										dTOT = dTOT + Val(AdoGetField(TableOfInvoices, "#v" & VB6.Format(Teller, "000") & " #"))
'									Next 
'									dTOT = dTOT + Val(AdoGetField(TableOfInvoices, "#v089 #")) + dBTW
'								Case "Q"
'									dTOT = Val(AdoGetField(TableOfInvoices, "#B010 #")) - Val(AdoGetField(TableOfInvoices, "#B090 #")) - Val(AdoGetField(TableOfInvoices, "#v065 #"))
'									dBTW = 0
'							End Select
'						Case "L"
'							dBTW = Val(AdoGetField(TableOfInvoices, "#v045 #")) - Val(AdoGetField(TableOfInvoices, "#v044 #")) - Val(AdoGetField(TableOfInvoices, "#v043 #"))
'							If VB.Left(AdoGetField(TableOfInvoices, "#v035 #"), 4) > "1992" Then
'								dBTW = dBTW - Val(AdoGetField(TableOfInvoices, "#v042 #"))
'							End If
'							dTOT = 0
'							For Teller = 46 To 49
'								dTOT = dTOT + Val(AdoGetField(TableOfInvoices, "#v" & VB6.Format(Teller, "000") & " #"))
'							Next 
'							dTOT = dTOT + dBTW
'					End Select
'					If System.Math.Round(dTOT / Euro, 2) <> Val(AdoGetField(TableOfInvoices, "#v249 #")) Then
'						MsgBox(AdoGetField(TableOfInvoices, "#v034 #") & ": " & System.Math.Round(dTOT / Euro, 2) & " <> " & Val(AdoGetField(TableOfInvoices, "#v249 #")) & vbCr & " en zogezegd reeds betaald : " & Val(AdoGetField(TableOfInvoices, "#v037 #")) & vbCr & vbCr & "Wordt bijgewerkt...", MsgBoxStyle.Information, "Bijwerking voor:")
'						If Val(AdoGetField(TableOfInvoices, "#v249 #")) = Val(AdoGetField(TableOfInvoices, "#v037 #")) Then
'							AdoInsertToRecord(TableOfInvoices, Str(System.Math.Round(dTOT / Euro, 2)), "v249")
'							AdoInsertToRecord(TableOfInvoices, Str(System.Math.Round(dTOT / Euro, 2)), "v037")
'						Else
'							AdoInsertToRecord(TableOfInvoices, Str(System.Math.Round(dTOT / Euro, 2)), "v249")
'							If Val(AdoGetField(TableOfInvoices, "#v037 #")) = 0 Then
'							Else
'								MsgBox("Totaal betaald dient U manueel nog te verbeteren.  Staat nu op " & Val(AdoGetField(TableOfInvoices, "#v037 #")), MsgBoxStyle.Exclamation, AdoGetField(TableOfInvoices, "#v034 #"))
'							End If
'						End If
'						bUpdate(TableOfInvoices, 1)
'						TotaalGewijzigd = TotaalGewijzigd + 1
'					ElseIf dTOT = Val(AdoGetField(TableOfInvoices, "#v037 #")) Then 
'						'100 % zeker totaal BEF staat nog als betaald
'						SnelHelpPrint(AdoGetField(TableOfInvoices, "#v033 #") & " was al volledig betaald in BEF voor " & Val(AdoGetField(TableOfInvoices, "#v037 #")) & " Wordt nu als betaald geplaatst € " & System.Math.Round(dTOT / Euro, 2), blLogging)
'						AdoInsertToRecord(TableOfInvoices, Str(System.Math.Round(dTOT / Euro, 2)), "v037")
'						bUpdate(TableOfInvoices, 1)
'					ElseIf Val(AdoGetField(TableOfInvoices, "#v249 #")) = Val(AdoGetField(TableOfInvoices, "#v037 #")) Then 
'						'100 % zeker totaal en betaald in EUR reeds aangeduid
'					ElseIf Val(AdoGetField(TableOfInvoices, "#v037 #")) = 0 Then 
'						'nog geen betalingen, dus ok
'					ElseIf InStr(AdoGetField(TableOfInvoices, "#v037 #"), ".") = 0 Then 
'						'een totaal bedrag betaald zonder aanwezigheid van decimaal punt
'						Msg = AdoGetField(TableOfInvoices, "#v033 #") & " met totaal € " & Val(AdoGetField(TableOfInvoices, "#v249 #")) & vbCr
'						Msg = Msg & "heeft een bedrag als betaling : " & Val(AdoGetField(TableOfInvoices, "#v037 #")) & vbCr & vbCr
'						Msg = Msg & "mag omgewerkt worden als betaald € " & System.Math.Round(Val(AdoGetField(TableOfInvoices, "#v037 #")) / Euro, 2) & vbCr & vbCr & vbCr
'						Msg = Msg & "AANDACHT: ENKEL WIJZIGEN INDIEN U 100 % ZEKER BENT !!!" & vbCr & vbCr
'						Msg = Msg & "Ja om te wijzigen, Nee om over te slaan"
'						KtrlBox = MsgBoxResult.Cancel
'						Do While KtrlBox = MsgBoxResult.Cancel
'							KtrlBox = MsgBox(Msg, MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton3 + MsgBoxStyle.Question)
'						Loop 
'						If KtrlBox = MsgBoxResult.Yes Then
'							AdoInsertToRecord(TableOfInvoices, Str(System.Math.Round(Val(AdoGetField(TableOfInvoices, "#v037 #")) / Euro, 2)), "v037")
'							bUpdate(TableOfInvoices, 1)
'						End If
'					Else
'						SnelHelpPrint("Vermoedelijk alles ok voor " & AdoGetField(TableOfInvoices, "#v033 #"), blLogging)
'					End If
'				Else
'					TotaalAantalEUR = TotaalAantalEUR + 1
'				End If
'				bNext(TableOfInvoices)
'				If Ktrl Then
'					Exit Do
'				End If
'			Loop 
'			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'			'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = vbNormal
'			Me.Enabled = True
'			Msg = "Totaal dokumenten in BEF " & TotaalAantalBEF
'			Msg = Msg & vbCr
'			Msg = Msg & "Totaal dokumenten in EUR " & TotaalAantalEUR
'			Msg = Msg & vbCr
'			Msg = Msg & "Totaal aantal gewijzigd " & TotaalGewijzigd
'			MsgBox(Msg, MsgBoxStyle.Information)
'		End If

'	End Sub

'	Private Sub CmdStandaard_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdStandaard.Click

'		Selektie(0).CheckState = System.Windows.Forms.CheckState.Unchecked
'		PeriodFromChosen.Value = VB.Left(BookyearFromTo.Value, 8)
'		PeriodToChosen.Value = VB.Right(BookyearFromTo.Value, 8)
'		TekstLijn(4).Text = FunctionDateText(VB.Left(BookyearFromTo.Value, 8)) & " - " & FunctionDateText(VB.Right(BookyearFromTo.Value, 8))
'		Selektie(2).CheckState = System.Windows.Forms.CheckState.Checked

'		Selektie(1).CheckState = System.Windows.Forms.CheckState.Checked
'		Selektie(3).CheckState = System.Windows.Forms.CheckState.Checked
'		ChkFinancieelDetail.CheckState = System.Windows.Forms.CheckState.Checked
'		Selektie(5).CheckState = System.Windows.Forms.CheckState.Checked
'		TekstLijn(0).Text = "Boekhoudcontrole " & TekstLijn(4).Text

'	End Sub

'	Private Sub CmdStandaardBetaling_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdStandaardBetaling.Click

'		Selektie(0).CheckState = System.Windows.Forms.CheckState.Checked
'		Selektie(2).CheckState = System.Windows.Forms.CheckState.Unchecked

'		Selektie(1).CheckState = System.Windows.Forms.CheckState.Unchecked
'		Selektie(3).CheckState = System.Windows.Forms.CheckState.Checked
'		ChkFinancieelDetail.CheckState = System.Windows.Forms.CheckState.Unchecked
'		TekstLijn(1).Text = MimGlobalDate.Value
'		TekstLijn(0).Text = "Betalingscontrole"

'	End Sub

'	Private Sub ButtonGenerateReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Drukken.Click
'		Dim Printer As New Printer
'		Dim BeginSleutel As New VB6.FixedLengthString(13)
'		Dim EindSleutel As New VB6.FixedLengthString(13)
'		Dim rdtemp As New VB6.FixedLengthString(8)
'		Dim syMasker As String
'		Dim KopBuf As String
'		Dim XX As Short
'		Dim Tel As Short
'		Dim Teller As Short
'		Dim ReedsMetBetalingen As Boolean
'		Dim TDS As String

'		Dim BetaaldBedrag As Double
'		Dim dBTW As Double
'		Dim dTOT As Double
'		Dim dnt As Double
'		Dim dTnt As Double
'		Dim drb As Double
'		Dim drbet As Double

'		Dim LengteSleutel As Short
'		Dim sleutelIndex As Short
'		Dim xOmgeving As Short
'		Dim MerkOp As Boolean

'		TotaalBTW = 0
'		TotaalGOED = 0
'		TotaalALBETAALD = 0
'		TotaalNOGTEBETALEN = 0
'		TotaalVOOR = 0
'		TotaalNA = 0
'		DocTeller = 0

'		dttot = 0
'		dtbtw = 0
'		dvtot = 0
'		dTrb = 0
'		dTnt = 0

'		BetalingenVoorNa(2).Items.Clear()
'		BetalingenVoorNa(3).Items.Clear()

'		Select Case FlPartij
'			Case TableOfSuppliers
'				BeginSleutel.Value = "L" & TekstLijn(2).Text
'				EindSleutel.Value = "L" & TekstLijn(3).Text
'			Case TableOfCustomers
'				BeginSleutel.Value = "K" & TekstLijn(2).Text
'				EindSleutel.Value = "K" & TekstLijn(3).Text
'		End Select

'		rdtemp.Value = DatumKey(TekstLijn(1).Text)

'		ReportText(2) = Me.Text & " " & Mid(Mim.Text, InStr(Mim.Text, "["))
'		ReportText(0) = TekstLijn(1).Text
'		ReportText(3) = TekstLijn(0).Text
'		InitialiseFields()

'		TDS = "Geen journalen voor : " & vbCrLf
'		JetGetOrGreater(TableOfInvoices, 1, BeginSleutel.Value)
'		If Ktrl Or UCase(SetSpacing(KeyBuf(TableOfInvoices), 13)) > UCase(EindSleutel.Value) Then
'			Beep()
'			Exit Sub
'		ElseIf VB.Left(KeyBuf(TableOfInvoices), 1) <> VB.Left(BeginSleutel.Value, 1) Then 
'			Beep()
'			Exit Sub
'		Else
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'			Me.Enabled = False
'			PageCounter = 0
'			If chkAfdrukInVenster.CheckState = 0 Then
'				If Printer.Width > 12000 Then
'					Printer.FontSize = 10
'					Printer.FontName = "Courier New"
'					Printer.Print(" ")
'					Printer.FontSize = 10
'				Else
'					On Error Resume Next
'					Printer.FontSize = 7.2
'					Printer.FontName = "Courier New"
'					Printer.Print(" ")
'					Printer.FontSize = 7.2
'					Printer.FontBold = True
'				End If
'			End If
'			VpePrintHeader()
'		End If

'		MerkOp = False
'		If PeriodFromChosen.Value = VB.Left(BookyearFromTo.Value, 8) And PeriodToChosen.Value = VB.Right(BookyearFromTo.Value, 8) Then
'			If VB.Left(PeriodFromChosen.Value, 4) = VB.Left(PeriodToChosen.Value, 4) Then
'				MerkOp = True
'			End If
'		End If


'		Do 
'			'UPGRADE_ISSUE: DoEvents does not return a value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8D115264-E27F-4472-A684-865A00B5E826"'
'			XDoEvents = System.Windows.Forms.Application.DoEvents()
'			RecordToField(TableOfInvoices)
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub KontroleVoorwaarden
'			bNext(TableOfInvoices)
'			If Ktrl Or UCase(SetSpacing(KeyBuf(TableOfInvoices), 13)) > UCase(EindSleutel.Value) Then
'				Exit Do
'			End If
'		Loop 
'		TotaalNOGTEBETALEN = TotaalGOED - TotaalALBETAALD
'		EindTotaal()
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal
'		Me.Enabled = True
'		If chkAfdrukInVenster.CheckState Then
'		Else
'			Printer.NewPage()
'			Printer.EndDoc()
'		End If
'		If Len(TDS) = 24 Then
'		Else
'			TDS = TDS & vbCrLf
'			TDS = TDS & "De betalingen voor bovenvermelde dokumenten kunnen dus niet" & vbCrLf
'			TDS = TDS & "in detail weergegeven worden.  Enkel het algemeen totaal" & vbCrLf
'			TDS = TDS & "van het dokument en laatste financieel uittreksel..."
'			MsgBox(TDS)
'			Msg = "Mededeling eveneens op papier ?"
'			KtrlBox = MsgBox(Msg, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2)
'			If KtrlBox = MsgBoxResult.Yes Then
'				Printer.Print(TDS)
'				Printer.NewPage()
'				Printer.EndDoc()
'			End If
'		End If
'		Me.Activate()
'		If BetalingenVoorNa(0).Items.Count + BetalingenVoorNa(1).Items.Count + BetalingenVoorNa(2).Items.Count + BetalingenVoorNa(3).Items.Count <> 0 Then
'			Msg = "Betalingsdetail dokumenten lagere/hogere boekjaren..." & vbCrLf
'			Msg = Msg & "Op papier ?"
'			KtrlBox = MsgBox(Msg, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1)
'			If KtrlBox = MsgBoxResult.Yes Then
'				BHDetailTekst(0) = "Detail betalingen dokumenten van lagere boekjaren in dit boekjaar" & vbCrLf & vbCrLf
'				BHDetailTekst(1) = "Detail betalingen dokumenten van hogere boekjaren in dit boekjaar" & vbCrLf & vbCrLf
'				BHDetailTekst(2) = "Detail betalingen dokumenten van dit boekjaar in lagere boekjaren" & vbCrLf & vbCrLf
'				BHDetailTekst(3) = "Detail betalingen dokumenten van dit boekjaar in hogere boekjaren" & vbCrLf & vbCrLf
'				For Tel = 0 To 3
'					If BetalingenVoorNa(Tel).Items.Count <> 0 Then
'						Printer.Print(BHDetailTekst(Tel))
'						For Teller = 0 To BetalingenVoorNa(Tel).Items.Count - 1
'							Printer.Write(VB6.GetItemString(BetalingenVoorNa(Tel), Teller) & vbCrLf)
'						Next 
'						Printer.Write(vbCrLf & vbCrLf)
'						If Tel = 0 Then
'							Printer.Print("Totaal financiële bewegingen: " & VB6.Format(TotaalDokOnderPeriode, Mask2002.Value))
'						ElseIf Tel = 1 Then 
'							Printer.Print("Totaal financiële bewegingen: " & VB6.Format(TotaalDokBovenPeriode, Mask2002.Value))
'						ElseIf Tel = 2 Then 
'							Printer.Print("Totaal financiële bewegingen: " & VB6.Format(TotaalVOOR, Mask2002.Value))
'						ElseIf Tel = 3 Then 
'							Printer.Print("Totaal financiële bewegingen: " & VB6.Format(TotaalNA, Mask2002.Value))
'						End If
'						Printer.NewPage()
'					End If
'				Next 
'				Printer.EndDoc()
'			End If
'		End If
'		SnelHelpPrint("Klaar", blLogging)
'		Me.Close()
'		Exit Sub

'KontroleVoorwaarden: 
'		If Selektie(0).CheckState = 1 Then
'			'vervaldag
'			If AdoGetField(TableOfInvoices, "#v036 #") > rdtemp.Value Then
'				'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'				Return 
'			End If
'		End If

'		If Selektie(4).CheckState = 1 Then
'			'-1994 dokumenten uitsluiten
'			If VB.Left(AdoGetField(TableOfInvoices, "#v035 #"), 4) < "1994" Then
'				'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'				Return 
'			End If
'		End If

'		If Selektie(2).CheckState = 1 Then
'			'dokumenten enkel van deze periode
'			If MerkOp = True Then
'				If VB.Left(AdoGetField(TableOfInvoices, "#v035 #"), 4) <> Mid(AdoGetField(TableOfInvoices, "#v033 #"), 3, 4) Then
'					MsgBox("Opgelet, noteer/controleer a.u.b.:" & vbCrLf & "Datum document: " & AdoGetField(TableOfInvoices, "#v035 #") & " onlogisch voor document nummer " & AdoGetField(TableOfInvoices, "#v033 #"), MsgBoxStyle.Exclamation)
'				End If
'			End If
'			If AdoGetField(TableOfInvoices, "#v035 #") < PeriodFromChosen.Value Or AdoGetField(TableOfInvoices, "#v035 #") > PeriodToChosen.Value Then
'				'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'				Return 
'			End If
'		End If

'		If Selektie(5).CheckState = 1 And FlPartij = TableOfSuppliers Then
'			JetGet(FlJournaal, 1, AdoGetField(TableOfInvoices, "#v033 #"))
'			If Ktrl Then
'				'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'				Return 
'			Else
'				RecordToField(FlJournaal)
'				If AdoGetField(FlJournaal, "#v035 #") < PeriodFromChosen.Value Or AdoGetField(TableOfInvoices, "#v035 #") > PeriodToChosen.Value Then
'					MsgBox("dokumentdatum (" & AdoGetField(TableOfInvoices, "#v035 #") & ") <> boekdatum journaal (" & AdoGetField(FlJournaal, "#v035 #") & ")" & vbCr & vbCr & "Wordt uit boekhoudcontrole geweerd.  Kontroleer eventueel manueel", MsgBoxStyle.Information, AdoGetField(TableOfInvoices, "#v033 #"))
'					'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'					Return 
'				End If
'			End If
'		End If

'		dTOT = Val(AdoGetField(TableOfInvoices, "#v249 #"))
'		If XisEuroWasBEF = True Then
'			dTOT = System.Math.Round(dTOT * Euro)
'		End If

'		syMasker = MaskEUR
'		If Mid(AdoGetField(TableOfInvoices, "#v033 #"), 2, 1) = "1" Then
'			dTOT = -dTOT
'			drb = -Val(AdoGetField(TableOfInvoices, "#v037 #"))
'			If XisEuroWasBEF = True Then
'				drb = System.Math.Round(-Val(AdoGetField(TableOfInvoices, "#v037 #")) * Euro)
'			Else
'				drb = -Val(AdoGetField(TableOfInvoices, "#v037 #"))
'			End If
'		Else
'			If XisEuroWasBEF = True Then
'				drb = System.Math.Round(Val(AdoGetField(TableOfInvoices, "#v037 #")) * Euro)
'			Else
'				drb = Val(AdoGetField(TableOfInvoices, "#v037 #"))
'			End If
'		End If

'		FieldText(1) = AdoGetField(TableOfInvoices, "#v033 #")
'		FieldText(2) = FunctionDateText(AdoGetField(TableOfInvoices, "#v035 #"))
'		FieldText(3) = AdoGetField(TableOfInvoices, "#vs03 #")
'		FieldText(4) = Dec(dTOT / Val(AdoGetField(TableOfInvoices, "#v040 #")), syMasker)
'		FieldText(5) = "" 'Dec$((dBtw), Mask2002)
'		FieldText(9) = FunctionDateText(AdoGetField(TableOfInvoices, "#v036 #"))

'		If Trim(AdoGetField(TableOfInvoices, "#v034 #")) <> KopBuf Then
'			dTnt = 0
'			JetGet(aIndex, 0, SetSpacing(Mid(AdoGetField(TableOfInvoices, "#v034 #"), 2, 12), 12))
'			KopBuf = Trim(AdoGetField(TableOfInvoices, "#v034 #"))
'			FieldText(0) = RTrim(Mid(AdoGetField(TableOfInvoices, "#v034 #"), 2, 12))
'			If Ktrl Then
'				FieldText(0) = FieldText(0) & " * niet meer aanwezig *"
'			Else
'				RecordToField(aIndex)
'				FieldText(0) = VB.Left(FieldText(0) & " " & RTrim(AdoGetField(aIndex, "#A100 #")) & " " & RTrim(AdoGetField(aIndex, "#A101 #")), 27)
'			End If
'			SnelHelpPrint(FieldText(0), blLogging)
'		End If

'		JetGet(FlJournaal, 1, AdoGetField(TableOfInvoices, "#v033 #"))
'		If Ktrl Or ChkFinancieelDetail.CheckState = 0 Then
'			'Er zijn geen journalen voor dit dokument !
'			'Verwittigen via afdruk laatste blz.
'			If ChkFinancieelDetail.CheckState Then
'				TDS = TDS & AdoGetField(TableOfInvoices, "#v033 #") & "  ...  " & AdoGetField(FlPartij, "#A110 #") & " " & AdoGetField(FlPartij, "#A100 #") & vbCrLf
'			End If
'			If dTOT = drb And Selektie(3).CheckState = 1 Then
'			Else
'				If InStr(FieldText(0), Mid(AdoGetField(TableOfInvoices, "#v034 #"), 2)) = 1 Then
'					If chkAfdrukInVenster.CheckState = 0 Then
'						Printer.Write(vbCrLf)
'						If Printer.CurrentY >= Printer.Height - 1200 Then
'							On Error Resume Next
'							Printer.NewPage()
'							Printer.FontSize = Printer.FontSize
'							Printer.Print(" ")
'							Printer.FontSize = Printer.FontSize
'							VpePrintHeader()
'						End If
'					End If
'				End If

'				dTnt = dTnt + dTOT - drb 'Algemeen Totaal Cumul te betalen
'				FieldText(6) = Dec(drb, Mask2002.Value)
'				FieldText(7) = AdoGetField(TableOfInvoices, "#v038 #")
'				FieldText(8) = "" 'Dec$((dTot - drb), Mask2002)
'				FieldText(10) = Dec(dTnt, Mask2002.Value)

'				'TotaalBTW = TotaalBTW + dBtw
'				TotaalGOED = TotaalGOED + dTOT '- dBtw
'				TotaalALBETAALD = TotaalALBETAALD + drb
'				VpePrintLines()
'				FieldText(0) = ""
'			End If
'		Else
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub AfdrukDetailReedsBetaald
'		End If
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'AfdrukDetailReedsBetaald: 
'		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'		GoSub TotaalBETAALD
'		If System.Math.Round(dTOT, 2) = System.Math.Round(drb, 2) And Selektie(3).CheckState = 1 Then
'			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			Return 
'		Else
'			JetGet(FlJournaal, 1, AdoGetField(TableOfInvoices, "#v033 #"))
'		End If
'		dTnt = dTnt + dTOT
'		ReedsMetBetalingen = False

'		drb = 0
'		Do 
'			RecordToField(FlJournaal)
'			If Trim(AdoGetField(FlJournaal, "#v038 #")) <> "" Then
'				If VB.Left(AdoGetField(FlJournaal, "#v019 #"), 1) <> "4" Then
'				Else
'					ReedsMetBetalingen = True
'					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'					GoSub BetalingErBij
'				End If
'			End If
'			bNext(FlJournaal)
'			If Ktrl Or Trim(KeyBuf(FlJournaal)) <> Trim(AdoGetField(TableOfInvoices, "#v033 #")) Then
'				Exit Do
'			End If
'		Loop 
'		If Not ReedsMetBetalingen Then
'			drb = 0
'			AdoInsertToRecord(FlJournaal, "0", "v068")
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub BetalingErBij
'		End If
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'BetalingErBij: 
'		BetaaldBedrag = Val(AdoGetField(FlJournaal, "#v068 #"))
'		If FlPartij = TableOfCustomers Then
'			BetaaldBedrag = -BetaaldBedrag
'		End If
'		If Selektie(1).CheckState = 1 Then
'			'Betalingen buiten periode uitsluiten
'			If AdoGetField(FlJournaal, "#v066 #") < PeriodFromChosen.Value Then
'				TotaalVOOR = TotaalVOOR + BetaaldBedrag
'				Msg = SetSpacing(Mid(AdoGetField(TableOfInvoices, "#v034 #"), 2), 12) & " "
'				Msg = Msg & SetSpacing(AdoGetField(FlJournaal, "#v067 #"), 20) & " "
'				Msg = Msg & FunctionDateText(AdoGetField(TableOfInvoices, "#v035 #")) & " "
'				Msg = Msg & AdoGetField(TableOfInvoices, "#v033 #") & " "
'				Msg = Msg & Dec(BetaaldBedrag, Mask2002.Value) & " "
'				Msg = Msg & SetSpacing(AdoGetField(FlJournaal, "#v019 #"), 7) & " "
'				Msg = Msg & FunctionDateText(AdoGetField(FlJournaal, "#v066 #")) & " "
'				Msg = Msg & AdoGetField(FlJournaal, "#v038 #") & " "
'				Msg = Msg & AdoGetField(FlJournaal, "#v069 #")
'				BetalingenVoorNa(2).Items.Add(Msg)
'				BetaaldBedrag = 0
'			ElseIf AdoGetField(FlJournaal, "#v066 #") > PeriodToChosen.Value Then 
'				TotaalNA = TotaalNA + BetaaldBedrag
'				Msg = SetSpacing(Mid(AdoGetField(TableOfInvoices, "#v034 #"), 2), 12) & " "
'				Msg = Msg & SetSpacing(AdoGetField(FlJournaal, "#v067 #"), 20) & " "
'				Msg = Msg & FunctionDateText(AdoGetField(TableOfInvoices, "#v035 #")) & " "
'				Msg = Msg & AdoGetField(TableOfInvoices, "#v033 #") & " "
'				Msg = Msg & Dec(BetaaldBedrag, Mask2002.Value) & " "
'				Msg = Msg & SetSpacing(AdoGetField(FlJournaal, "#v019 #"), 7) & " "
'				Msg = Msg & FunctionDateText(AdoGetField(FlJournaal, "#v066 #")) & " "
'				Msg = Msg & AdoGetField(FlJournaal, "#v038 #") & " "
'				Msg = Msg & AdoGetField(FlJournaal, "#v069 #")
'				BetalingenVoorNa(3).Items.Add(Msg)
'				BetaaldBedrag = 0
'			End If
'		End If

'		If InStr(FieldText(0), Mid(AdoGetField(TableOfInvoices, "#v034 #"), 2)) = 1 Then
'			dTnt = dTOT : drb = 0
'			If chkAfdrukInVenster.CheckState = 0 Then
'				Printer.Write(vbCrLf)
'				If Printer.CurrentY >= Printer.Height - 1200 Then
'					On Error Resume Next
'					Printer.NewPage()
'					Printer.FontSize = Printer.FontSize
'					Printer.Print(" ")
'					Printer.FontSize = Printer.FontSize
'					VpePrintHeader()
'				End If
'			End If
'		End If

'		drb = drb + BetaaldBedrag
'		dTnt = dTnt - BetaaldBedrag
'		dTrb = dTrb + drb 'Totaal al betaald
'		dttot = dttot + dTOT - dBTW 'Totaal excl. btw
'		dtbtw = dtbtw + dBTW 'Totaal btw aftrekbaar

'		FieldText(6) = Dec(BetaaldBedrag, Mask2002.Value)
'		FieldText(7) = AdoGetField(FlJournaal, "#v038 #")
'		FieldText(8) = Dec(dTOT - drb, Mask2002.Value)
'		FieldText(10) = Dec(dTnt, Mask2002.Value)

'		If Val(FieldText(4)) + Val(FieldText(5)) <> 0 Then
'			'TotaalBTW = TotaalBTW + dBtw
'			TotaalGOED = TotaalGOED + dTOT '- dBtw
'			TotaalNOGTEBETALEN = TotaalNOGTEBETALEN + dTOT
'		End If
'		TotaalALBETAALD = TotaalALBETAALD + BetaaldBedrag
'		VpePrintLines()

'		FieldText(0) = ""
'		FieldText(1) = ""
'		FieldText(2) = ""
'		FieldText(3) = ""
'		FieldText(4) = ""
'		FieldText(5) = ""
'		FieldText(9) = ""
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'TotaalBETAALD: 
'		drb = 0
'		JetGet(FlJournaal, 1, AdoGetField(TableOfInvoices, "#v033 #"))
'		If Ktrl Then
'			MsgBox("onlogische situatie")
'		Else
'			Do 
'				RecordToField(FlJournaal)
'				If Trim(AdoGetField(FlJournaal, "#v038 #")) <> "" Then
'					If VB.Left(AdoGetField(FlJournaal, "#v019 #"), 1) <> "4" Then
'					Else
'						BetaaldBedrag = Val(AdoGetField(FlJournaal, "#v068 #"))
'						If FlPartij = TableOfCustomers Then
'							BetaaldBedrag = -BetaaldBedrag
'						End If
'						If XisEuroWasBEF = True Then
'							If AdoGetField(FlJournaal, "#v066 #") > VB.Right(BookyearFromTo.Value, 8) Then
'								BetaaldBedrag = System.Math.Round(BetaaldBedrag * Euro)
'							End If
'						End If
'						If Selektie(1).CheckState = 1 Then
'							'Betalingen buiten periode uitsluiten
'							If AdoGetField(FlJournaal, "#v066 #") < PeriodFromChosen.Value Or AdoGetField(FlJournaal, "#v066 #") > PeriodToChosen.Value Then
'							Else
'								drb = drb + BetaaldBedrag
'							End If
'						Else
'							drb = drb + BetaaldBedrag
'						End If
'					End If
'					'ElseIf FlPartij = TableOfCustomers Then
'					'    If AdoGetField(FlJournaal, "#v033 #") = "Q0800286" Then
'					'        Stop
'					'    End If
'				End If
'				bNext(FlJournaal)
'				If Ktrl Or Trim(KeyBuf(FlJournaal)) <> Trim(AdoGetField(TableOfInvoices, "#v033 #")) Then
'					Exit Do
'				End If
'			Loop 
'		End If
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'PrtHandler: 
'		MsgBox("Kontroleer de printer.")
'		Resume 

'	End Sub

'	Private Sub EindTotaal()
'		Dim Printer As New Printer
'		Dim T As Short
'		Dim aa As String

'JumpEindTotaal: 
'		For T = 0 To 10
'			FieldText(T) = ""
'		Next 
'		FieldText(0) = "Totalen :"
'		FieldText(4) = Dec(TotaalGOED, Mask2002.Value)
'		FieldText(5) = "" 'Dec$((TotaalBTW), Mask2002)
'		FieldText(6) = Dec(TotaalALBETAALD, Mask2002.Value)
'		FieldText(10) = Dec(TotaalNOGTEBETALEN, Mask2002.Value)
'		If chkAfdrukInVenster.CheckState = 0 Then Printer.Write(vbCrLf & FullLine.Value & vbCrLf)

'		T = 0
'		aa = ""
'		Do While T < 12
'			If chkAfdrukInVenster.CheckState Then
'				aa = aa & FieldText(T) & vbTab
'			Else
'				Printer.Print(TAB(ReportTab(T)))
'				Printer.Write(FieldText(T))
'			End If
'			If ReportTab(T + 1) < ReportTab(T) Then
'				If chkAfdrukInVenster.CheckState Then
'				Else
'					Printer.Write(vbCrLf)
'				End If
'			End If
'			T = T + 1
'		Loop 
'		If chkAfdrukInVenster.CheckState Then mdiXlog.X.AddItem(aa, mdiXlog.X.Rows - 1)

'		Dim GroepSelektie As String
'		Dim TotaalBedragGroep As Double
'		Dim AantalInGroep As Short
'		Dim BedragZonderdokument As Double
'		Dim AantalZonderdokument As Short
'		Dim BetaaldBedragBB As Double
'		Dim GroepRekening4 As String

'		If Selektie(5).CheckState = 1 Then
'			If chkAfdrukInVenster.CheckState Then
'			Else
'				If Printer.CurrentY >= Printer.Height - 1500 Then
'					On Error Resume Next
'					Printer.NewPage()
'					Printer.FontSize = Printer.FontSize
'					Printer.Print(" ")
'					Printer.FontSize = Printer.FontSize
'					VpePrintHeader()
'					GoTo JumpEindTotaal
'				End If
'			End If

'			If TotaalVOOR <> 0 Then
'				For T = 0 To 10
'					FieldText(T) = ""
'				Next 
'				FieldText(0) = "Dok. reeds betaald voor :"
'				FieldText(2) = VB.Left(TekstLijn(4).Text, 10)
'				FieldText(6) = Dec(TotaalVOOR, Mask2002.Value)
'				T = 0
'				aa = ""
'				Do While T < 12
'					If chkAfdrukInVenster.CheckState Then
'						aa = aa & FieldText(T) & vbTab
'					Else
'						Printer.Print(TAB(ReportTab(T)))
'						Printer.Write(FieldText(T))
'					End If
'					If ReportTab(T + 1) < ReportTab(T) Then
'						If chkAfdrukInVenster.CheckState Then
'						Else
'							Printer.Write(vbCrLf)
'						End If
'					End If
'					T = T + 1
'				Loop 
'				If chkAfdrukInVenster.CheckState Then mdiXlog.X.AddItem(aa, mdiXlog.X.Rows - 1)
'			End If
'			If TotaalNA <> 0 Then
'				For T = 0 To 10
'					FieldText(T) = ""
'				Next 
'				FieldText(0) = "Dok. reeds betaald na :"
'				FieldText(2) = VB.Right(TekstLijn(4).Text, 10)
'				FieldText(6) = Dec(TotaalNA, Mask2002.Value)
'				T = 0
'				aa = ""
'				Do While T < 12
'					If chkAfdrukInVenster.CheckState Then
'						aa = aa & FieldText(T) & vbTab
'					Else
'						Printer.Print(TAB(ReportTab(T)))
'						Printer.Write(FieldText(T))
'					End If
'					If ReportTab(T + 1) < ReportTab(T) Then
'						If chkAfdrukInVenster.CheckState Then
'						Else
'							Printer.Write(vbCrLf)
'						End If
'					End If
'					T = T + 1
'				Loop 
'				If chkAfdrukInVenster.CheckState Then mdiXlog.X.AddItem(aa, mdiXlog.X.Rows - 1)
'			End If

'			If chkAfdrukInVenster.CheckState = 0 Then Printer.Write(vbCrLf & FullLine.Value & vbCrLf)
'			TotaalBedragGroep = 0
'			AantalInGroep = 0
'			BedragZonderdokument = 0
'			AantalZonderdokument = 0
'			AantalBovenPeriode = 0
'			AantalOnderPeriode = 0
'			TotaalDokBovenPeriode = 0
'			TotaalDokOnderPeriode = 0

'			GroepSelektie = String99(Reading, FlPartij + 296)
'			If Trim(GroepSelektie) = "" Then
'				GroepSelektie = VB.Left(String99(Reading, FlPartij + 8), 4) & "999"
'			End If
'			If Len(GroepSelektie) > 7 Then
'				MsgBox("Groep bestaat uit meer dan 7 tekens: " & GroepSelektie, MsgBoxStyle.Exclamation)
'				GroepSelektie = VB.Left(GroepSelektie, 7)
'			ElseIf Len(GroepSelektie) <> 7 Then 
'				GroepSelektie = GroepSelektie & New String("9", 7 - Len(GroepSelektie))
'			End If
'			BetalingenVoorNa(0).Items.Clear()
'			BetalingenVoorNa(1).Items.Clear()
'			JetGetOrGreater(TableOfLedgerAccounts, 0, SetSpacing(String99(Reading, FlPartij + 8), 7))
'			If Ktrl Then
'				MsgBox("onlogika")
'			Else
'				RecordToField(TableOfLedgerAccounts)
'				Do While KeyBuf(TableOfLedgerAccounts) <= GroepSelektie
'					GroepRekening4 = KeyBuf(TableOfLedgerAccounts)
'					SnelHelpPrint("Journalen boekjaar voor rek. " & KeyBuf(TableOfLedgerAccounts) & " worden gekontroleerd.  Ogenblik a.u.b.", blLogging)
'					AantalInGroep = AantalInGroep + 1
'					If bhEuro Then
'						TotaalBedragGroep = TotaalBedragGroep + Val(AdoGetField(TableOfLedgerAccounts, "#e" & VB6.Format(22 + ActiveBookyear, "000") & " #"))
'					Else
'						TotaalBedragGroep = TotaalBedragGroep + Val(AdoGetField(TableOfLedgerAccounts, "#v" & VB6.Format(22 + ActiveBookyear, "000") & " #"))
'					End If
'					JetGetOrGreater(FlJournaal, 0, SetSpacing(KeyBuf(TableOfLedgerAccounts), 7) & PeriodFromChosen.Value)
'					If Ktrl Then
'						MsgBox("Geen journalen voor deze periode...")
'					Else
'						RecordToField(FlJournaal)
'						If VB.Left(KeyBuf(FlJournaal), 7) <= GroepSelektie Then
'						Else
'							Exit Do
'						End If
'						Do While VB.Right(KeyBuf(FlJournaal), 8) <= PeriodToChosen.Value
'							SnelHelpPrint("Alle journalen voor rekening " & KeyBuf(TableOfLedgerAccounts) & " worden gekontroleerd.  Bezig aan :" & VB.Right(KeyBuf(FlJournaal), 8), blLogging)
'							'UPGRADE_ISSUE: DoEvents does not return a value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8D115264-E27F-4472-A684-865A00B5E826"'
'							XDoEvents = System.Windows.Forms.Application.DoEvents()
'							If Trim(AdoGetField(FlJournaal, "#v033 #")) = "" Or VB.Left(AdoGetField(FlJournaal, "#v033 #"), 1) = "D" Then
'								Debug.Print(VB6.TabLayout(rsMAR(FlJournaal).Fields("v033").Value, Val(rsMAR(FlJournaal).Fields("v068").Value), rsMAR(FlJournaal).Fields("v067").Value, rsMAR(FlJournaal).Fields("v019").Value))
'								AantalZonderdokument = AantalZonderdokument + 1

'								BedragZonderdokument = BedragZonderdokument + Val(AdoGetField(FlJournaal, "#v068 #"))
'							ElseIf RTrim(AdoGetField(FlJournaal, "#v038 #")) <> "" Then 
'								JetGet(TableOfInvoices, 0, AdoGetField(FlJournaal, "#v033 #"))
'								If Ktrl Then
'								Else
'									RecordToField(TableOfInvoices)
'									If AdoGetField(TableOfInvoices, "#v035 #") < PeriodFromChosen.Value Then
'										BetaaldBedragBB = Val(AdoGetField(FlJournaal, "#v068 #"))
'										If FlPartij = TableOfCustomers Then
'											BetaaldBedragBB = -BetaaldBedragBB
'										End If
'										If XisEuroWasBEF = True Then
'											If AdoGetField(FlJournaal, "#v066 #") > VB.Right(BookyearFromTo.Value, 8) Then
'												BetaaldBedragBB = System.Math.Round(BetaaldBedragBB * Euro)
'											End If
'										End If

'										TotaalDokOnderPeriode = TotaalDokOnderPeriode + BetaaldBedragBB
'										AantalOnderPeriode = AantalOnderPeriode + 1
'										Msg = SetSpacing(Mid(AdoGetField(TableOfInvoices, "#v034 #"), 2), 12) & " "
'										Msg = Msg & SetSpacing(AdoGetField(FlJournaal, "#v067 #"), 20) & " "
'										Msg = Msg & FunctionDateText(AdoGetField(TableOfInvoices, "#v035 #")) & " "
'										Msg = Msg & AdoGetField(TableOfInvoices, "#v033 #") & " "
'										Msg = Msg & Dec(BetaaldBedragBB, Mask2002.Value) & " "
'										Msg = Msg & SetSpacing(AdoGetField(FlJournaal, "#v019 #"), 7) & " "
'										Msg = Msg & FunctionDateText(AdoGetField(FlJournaal, "#v066 #")) & " "
'										Msg = Msg & AdoGetField(FlJournaal, "#v038 #") & " "
'										Msg = Msg & AdoGetField(FlJournaal, "#v069 #")
'										BetalingenVoorNa(0).Items.Add(Msg)
'									ElseIf AdoGetField(TableOfInvoices, "#v035 #") > PeriodToChosen.Value Then 
'										BetaaldBedragBB = Val(AdoGetField(FlJournaal, "#v068 #"))
'										If FlPartij = TableOfCustomers Then
'											BetaaldBedragBB = -BetaaldBedragBB
'										End If
'										If XisEuroWasBEF = True Then
'											If AdoGetField(FlJournaal, "#v066 #") > VB.Right(BookyearFromTo.Value, 8) Then
'												BetaaldBedragBB = System.Math.Round(BetaaldBedragBB * Euro)
'											End If
'										End If

'										TotaalDokBovenPeriode = TotaalDokBovenPeriode + BetaaldBedragBB
'										AantalBovenPeriode = AantalBovenPeriode + 1
'										Msg = SetSpacing(Mid(AdoGetField(TableOfInvoices, "#v034 #"), 2), 12) & " "
'										Msg = Msg & SetSpacing(AdoGetField(FlJournaal, "#v067 #"), 20) & " "
'										Msg = Msg & FunctionDateText(AdoGetField(TableOfInvoices, "#v035 #")) & " "
'										Msg = Msg & AdoGetField(TableOfInvoices, "#v033 #") & " "
'										Msg = Msg & Dec(BetaaldBedragBB, Mask2002.Value) & " "
'										Msg = Msg & SetSpacing(AdoGetField(FlJournaal, "#v019 #"), 7) & " "
'										Msg = Msg & FunctionDateText(AdoGetField(FlJournaal, "#v066 #")) & " "
'										Msg = Msg & AdoGetField(FlJournaal, "#v038 #") & " "
'										Msg = Msg & AdoGetField(FlJournaal, "#v069 #")
'										BetalingenVoorNa(1).Items.Add(Msg)
'									End If
'								End If
'							End If
'							bNext(FlJournaal)
'							If Ktrl Or KeyBuf(FlJournaal) > GroepRekening4 & PeriodToChosen.Value Then
'								Exit Do
'							Else
'								RecordToField(FlJournaal)
'							End If
'						Loop 
'					End If
'					bNext(TableOfLedgerAccounts)
'					If Ktrl Or KeyBuf(TableOfLedgerAccounts) > GroepSelektie Then
'						Exit Do
'					Else
'						RecordToField(TableOfLedgerAccounts)
'					End If
'				Loop 
'			End If

'			For T = 0 To 10
'				FieldText(T) = ""
'			Next 
'			FieldText(0) = "Stand " & VB6.Format(AantalInGroep, "00") & " " & GroepSelektie & "-rekeningen"
'			FieldText(6) = Dec(TotaalBedragGroep, Mask2002.Value)
'			T = 0
'			aa = ""
'			Do While T < 12
'				If chkAfdrukInVenster.CheckState Then
'					aa = aa & FieldText(T) & vbTab
'				Else
'					Printer.Print(TAB(ReportTab(T)))
'					Printer.Write(FieldText(T))
'				End If
'				If ReportTab(T + 1) < ReportTab(T) Then
'					If chkAfdrukInVenster.CheckState Then
'					Else
'						Printer.Write(vbCrLf)
'					End If
'				End If
'				T = T + 1
'			Loop 
'			If chkAfdrukInVenster.CheckState Then mdiXlog.X.AddItem(aa, mdiXlog.X.Rows - 1)

'			For T = 0 To 10
'				FieldText(T) = ""
'			Next 
'			FieldText(0) = VB6.Format(AantalZonderdokument, "00") & " verr. zonder dokument"
'			FieldText(6) = Dec(BedragZonderdokument, Mask2002.Value)
'			T = 0
'			aa = ""
'			Do While T < 12
'				If chkAfdrukInVenster.CheckState Then
'					aa = aa & FieldText(T) & vbTab
'				Else
'					Printer.Print(TAB(ReportTab(T)))
'					Printer.Write(FieldText(T))
'				End If
'				If ReportTab(T + 1) < ReportTab(T) Then
'					If chkAfdrukInVenster.CheckState Then
'					Else
'						Printer.Write(vbCrLf)
'					End If
'				End If
'				T = T + 1
'			Loop 
'			If chkAfdrukInVenster.CheckState Then mdiXlog.X.AddItem(aa, mdiXlog.X.Rows - 1)

'			For T = 0 To 10
'				FieldText(T) = ""
'			Next 
'			FieldText(0) = VB6.Format(AantalOnderPeriode, "#") & " betalingen dok. < boekjaar"
'			FieldText(6) = Dec(TotaalDokOnderPeriode, Mask2002.Value)
'			T = 0
'			aa = ""
'			Do While T < 12
'				If chkAfdrukInVenster.CheckState Then
'					aa = aa & FieldText(T) & vbTab
'				Else
'					Printer.Print(TAB(ReportTab(T)))
'					Printer.Write(FieldText(T))
'				End If
'				If ReportTab(T + 1) < ReportTab(T) Then
'					If chkAfdrukInVenster.CheckState Then
'					Else
'						Printer.Write(vbCrLf)
'					End If
'				End If
'				T = T + 1
'			Loop 
'			If chkAfdrukInVenster.CheckState Then mdiXlog.X.AddItem(aa, mdiXlog.X.Rows - 1)

'			For T = 0 To 10
'				FieldText(T) = ""
'			Next 
'			FieldText(0) = VB6.Format(AantalBovenPeriode, "#") & " betalingen dok. > boekjaar"
'			FieldText(6) = Dec(TotaalDokBovenPeriode, Mask2002.Value)
'			T = 0
'			aa = ""
'			Do While T < 12
'				If chkAfdrukInVenster.CheckState Then
'					aa = aa & FieldText(T) & vbTab
'				Else
'					Printer.Print(TAB(ReportTab(T)))
'					Printer.Write(FieldText(T))
'				End If
'				If ReportTab(T + 1) < ReportTab(T) Then
'					If chkAfdrukInVenster.CheckState Then
'					Else
'						Printer.Write(vbCrLf)
'					End If
'				End If
'				T = T + 1
'			Loop 
'			If chkAfdrukInVenster.CheckState Then mdiXlog.X.AddItem(aa, mdiXlog.X.Rows - 1)
'		End If

'		If chkAfdrukInVenster.CheckState Then
'			'mdiXlog!Kopie(1).Checked = True
'			mdiXlog.X.Row = 1
'			mdiXlog.X.Col = 0
'			mdiXlog.X.set_ColWidth(0, 2385)
'			mdiXlog.X.set_ColWidth(1, 1185)
'			mdiXlog.X.set_ColWidth(2, 990)
'			mdiXlog.X.set_ColWidth(3, 390)
'			mdiXlog.X.set_ColWidth(4, 945)
'			mdiXlog.X.set_ColWidth(5, 855)
'			mdiXlog.X.set_ColWidth(6, 855)
'			mdiXlog.X.set_ColWidth(7, 855)
'			mdiXlog.X.set_ColWidth(8, 915)
'			mdiXlog.X.set_ColWidth(9, 975)
'			mdiXlog.X.set_ColWidth(10, 960)
'			'mdiXlog.WindowState = 2

'			mdiXlog.X.set_ColAlignment(4, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
'			mdiXlog.X.set_ColAlignment(5, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
'			mdiXlog.X.set_ColAlignment(6, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
'			mdiXlog.X.set_ColAlignment(8, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
'			mdiXlog.X.set_ColAlignment(10, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)

'			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'			'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = vbNormal
'			mdiXlog.Show() '1
'			'mdiXlog.WindowState = 0
'			'Unload mdiXlog
'		End If

'	End Sub
'	Private Sub BalansKL_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
'		Dim Printer As New Printer

'		If Not Toegankelijk(Me) Then
'			Me.Close()
'			Exit Sub
'		End If

'		If bhEuro Then
'			cmdEuroCheck.Visible = True
'		Else
'			cmdEuroCheck.Visible = False
'		End If

'		Dim TempbModus As Short

'		PeriodFromChosen.Value = VB.Left(BookyearFromTo.Value, 8)
'		PeriodToChosen.Value = VB.Right(BookyearFromTo.Value, 8)

'		cbLijstPrinterHier.Items.Clear()
'		If Printers.Count = 0 Then MsgBox("Installeer eerst minstens één printerdriver a.u.b. (bvb. cutePDF)", MsgBoxStyle.Exclamation) : End
'		For CountTo = 0 To Printers.Count - 1
'			'UPGRADE_ISSUE: Printer property Printers.Port was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
'			Me.cbLijstPrinterHier.Items.Add(Printers(CountTo).Port & " " & Printers(CountTo).DeviceName)
'		Next 
'		cbLijstPrinterHier.SelectedIndex = LijstPrinterNr
'		Printer = Printers(LijstPrinterNr)

'		On Error Resume Next
'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		Printer.PaperBin = LaadTekst(My.Application.Info.Title, "LIJSTPRINTER")
'		If Printer.Orientation = PrinterObjectConstants.vbPRORLandscape Then
'			chkAfdrukLiggend.CheckState = System.Windows.Forms.CheckState.Checked
'		Else
'			chkAfdrukLiggend.CheckState = System.Windows.Forms.CheckState.Unchecked
'		End If
'		chkAfdrukLiggend_CheckStateChanged(chkAfdrukLiggend, New System.EventArgs())

'		On Error Resume Next
'		Err.Clear()
'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(dokumentenBalans, BetalingsKontrole). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		Selektie(5).CheckState = LaadTekst("dokumentenBalans", "BetalingsKontrole")
'		If Err.Number Then
'		Else
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(dokumentenBalans, KontroleVervaldag). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Selektie(0).CheckState = LaadTekst("dokumentenBalans", "KontroleVervaldag")
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(dokumentenBalans, GeenBetalingHogerBoekjaar). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Selektie(1).CheckState = LaadTekst("dokumentenBalans", "GeenBetalingHogerBoekjaar")
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(dokumentenBalans, PeriodeBegrenzen). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Selektie(2).CheckState = LaadTekst("dokumentenBalans", "PeriodeBegrenzen")
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(dokumentenBalans, EnkelNietBetaaldedokumenten). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Selektie(3).CheckState = LaadTekst("dokumentenBalans", "EnkelNietBetaaldedokumenten")
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(dokumentenBalans, -dokumenten-1994Uitsluiten). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Selektie(4).CheckState = LaadTekst("dokumentenBalans", "-dokumenten-1994Uitsluiten")
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			ChkFinancieelDetail.CheckState = LaadTekst("dokumentenBalans", "FinancieelDetailViaJournaal")
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			chkAfdrukInVenster.CheckState = LaadTekst("dokumentenBalans", "AfdrukInRooster")
'		End If
'		TekstLijn(1).Text = MimGlobalDate.Value
'		TekstLijn(4).Text = FunctionDateText(VB.Left(BookyearFromTo.Value, 8)) & " - " & FunctionDateText(VB.Right(BookyearFromTo.Value, 8))

'		Select Case aIndex
'			Case TableOfSuppliers
'				ListName = "Balans Leveranciers"
'				FlPartij = TableOfSuppliers
'			Case TableOfCustomers
'				ListName = "Balans Klanten"
'				FlPartij = TableOfCustomers
'			Case Else
'				MsgBox("stop balans partijen!")
'		End Select

'		If XisEuroWasBEF = True Then
'			ListName = ListName & " (Speciale modus: Alle cijfers in BEF !)"
'		End If
'		Me.Text = ListName

'		TekstLijn(2).Text = "0"
'		TekstLijn(3).Text = New String("z", 12)

'	End Sub


'	Private Sub InitialiseFields()
'		Dim T As Short
'		Dim VolgTab As Short

'		ReportField(0) = "Identiteit"
'		ReportTab(0) = 1

'		ReportField(1) = "Document"
'		ReportTab(1) = 29

'		ReportField(2) = "Datum"
'		ReportTab(2) = 41

'		ReportField(3) = "Mdoc"
'		ReportTab(3) = 52

'		If XisEuroWasBEF = True Then
'			ReportField(4) = " Goed(BEF)"
'		Else
'			If bhEuro Then
'				ReportField(4) = " Goed(EUR)"
'			Else
'				ReportField(4) = " Goed(BEF)"
'			End If
'		End If
'		ReportTab(4) = 56

'		If XisEuroWasBEF = True Then
'			ReportField(5) = "  BTW(BEF)"
'		Else
'			If bhEuro Then
'				ReportField(5) = "  BTW(EUR)"
'			Else
'				ReportField(5) = "  BTW(BEF)"
'			End If
'		End If
'		ReportTab(5) = 67

'		ReportField(6) = "   Betaald"
'		ReportTab(6) = 78

'		ReportField(7) = "Fin.stuk"
'		ReportTab(7) = 89

'		ReportField(8) = "      Rest"
'		ReportTab(8) = 98

'		ReportField(9) = "Vervaldag"
'		ReportTab(9) = 109

'		If XisEuroWasBEF = True Then
'			ReportField(10) = " Cum.(BEF)"
'		Else
'			If bhEuro Then
'				ReportField(10) = " Cum.(EUR)"
'			Else
'				ReportField(10) = " Cum.(BEF)"
'			End If
'		End If
'		ReportTab(10) = 119

'		ReportTab(11) = 0

'		If chkAfdrukInVenster.CheckState Then
'			Me.Hide()
'			mdiXlog.Close()
'			mdiXlog.Hide()
'			mdiXlog.Text = "dokumentenBalans"
'			mdiXlog.X.Cols = 11
'			mdiXlog.X.Row = 0
'			For T = 0 To 10
'				mdiXlog.X.Col = T
'				mdiXlog.X.Text = ReportField(T)
'			Next 
'			Me.Show()
'		End If

'	End Sub

'	Private Sub VpePrintHeader()
'		Dim Printer As New Printer
'		Dim T As Short

'		If chkAfdrukInVenster.CheckState Then Exit Sub

'		If usrLicentieInfo <> "" Then
'			Printer.CurrentX = 50
'			Printer.CurrentY = 50
'			Printer.Write(usrLicentieInfo)
'		End If
'		PageCounter = PageCounter + 1
'		Printer.CurrentY = 400
'		Printer.Write(TAB(1), ReportText(2))
'		Printer.Write(TAB(108), "Pagina : " & Dec(PageCounter, "##########") & vbCrLf)
'		Printer.Write(TAB(108), "Datum  : " & ReportText(0) & vbCrLf & vbCrLf)
'		Printer.Write(TAB(1), UCase(ReportText(3)) & vbCrLf)

'		Printer.Write(TAB(1), FullLine.Value & vbCrLf)

'		Do While ReportTab(T) <> 0
'			Printer.Write(TAB(ReportTab(T)), ReportField(T))
'			If ReportTab(T + 1) < ReportTab(T) Then
'				Printer.Write(vbCrLf)
'			End If
'			T = T + 1
'		Loop 

'		Printer.Write(TAB(1), FullLine.Value & vbCrLf & vbCrLf)

'	End Sub

'	Private Sub VpePrintLines()
'		Dim Printer As New Printer
'		Dim T As Short
'		Dim VeldTekst As String
'		Dim aa As String

'		T = 0
'		aa = ""
'		Do While ReportTab(T) <> 0
'			If chkAfdrukInVenster.CheckState Then
'				aa = aa & FieldText(T) & vbTab
'			Else
'				Printer.Print(TAB(ReportTab(T)))
'				Printer.Write(FieldText(T))
'			End If
'			If ReportTab(T + 1) < ReportTab(T) Then
'				If chkAfdrukInVenster.CheckState Then
'				Else
'					Printer.Write(vbCrLf)
'				End If
'			End If
'			T = T + 1
'		Loop 
'		If Printer.CurrentY >= Printer.Height - 1200 Then
'			On Error Resume Next
'			Printer.NewPage()
'			Printer.FontSize = Printer.FontSize
'			Printer.Print(" ")
'			Printer.FontSize = Printer.FontSize
'			VpePrintHeader()
'		End If

'		If chkAfdrukInVenster.CheckState Then mdiXlog.X.AddItem(aa, mdiXlog.X.Rows - 1)

'	End Sub

'	'UPGRADE_WARNING: Event Selektie.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub Selektie_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Selektie.CheckStateChanged
'		Dim Index As Short = Selektie.GetIndex(eventSender)

'		Select Case Index
'			Case 0
'				If Selektie(Index).CheckState = 1 Then
'					TekstLijn(1).Text = FunctionDateText(VB.Right(BookyearFromTo.Value, 8))
'				Else
'					TekstLijn(1).Text = MimGlobalDate.Value
'				End If
'			Case 4
'				If Selektie(4).CheckState = 1 Then
'					BeginPlaySound(9)
'					MsgBox("Schakel uitsluitend aan indien U problemen ondervindt met sommige geimporteerde DOS-dokumenten van voor 1994 (o.a. BTW 33 %, 8 % luxetaks)." & vbCrLf & vbCrLf & "Indien U alle mogelijkheden van marIntegraal Windows versie met uw oude data wenst te benutten, gelieve ons pér bedrijf een veiligheidskopij te bezorgen." & vbCrLf & vbCrLf & "Binnen uw servicekontrakt werken wij deze kosteloos om in onze lokalen.")
'				End If
'		End Select

'	End Sub

'	Private Sub TekstLijn_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstLijn.Enter
'		Dim Index As Short = TekstLijn.GetIndex(eventSender)

'		TekstLijn(Index).SelectionLength = Len(TekstLijn(Index).Text)

'	End Sub

'	Private Sub TekstLijn_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstLijn.Leave
'		Dim Index As Short = TekstLijn.GetIndex(eventSender)

'		Select Case Index
'			Case 1
'				If DateWrongFormat(TekstLijn(1).Text) Then
'					Beep()
'					TekstLijn(1).Text = MimGlobalDate.Value
'				End If
'			Case 4
'				If DateWrongFormat(VB.Right(TekstLijn(4).Text, 10)) Then
'					MsgBox("Respecteer : " & vbCrLf & vbCrLf & "DD/MM/EEJJ - DD/MM/EEJJ a.u.b. !")
'					TekstLijn(4).Text = FunctionDateText(VB.Left(BookyearFromTo.Value, 8)) & " - " & FunctionDateText(VB.Right(BookyearFromTo.Value, 8))
'					TekstLijn(4).Focus()
'					Exit Sub
'				ElseIf Len(TekstLijn(4).Text) <> 23 Then 
'					MsgBox("Respecteer : " & vbCrLf & vbCrLf & "DD/MM/EEJJ - DD/MM/EEJJ a.u.b. !")
'					TekstLijn(4).Text = FunctionDateText(VB.Left(BookyearFromTo.Value, 8)) & " - " & FunctionDateText(VB.Right(BookyearFromTo.Value, 8))
'					TekstLijn(4).Focus()
'					Exit Sub
'				Else
'					PeriodFromChosen.Value = Mid(TekstLijn(4).Text, 7, 4) & Mid(TekstLijn(4).Text, 4, 2) & Mid(TekstLijn(4).Text, 1, 2)
'					PeriodToChosen.Value = Mid(TekstLijn(4).Text, 20, 4) & Mid(TekstLijn(4).Text, 17, 2) & Mid(TekstLijn(4).Text, 14, 2)
'					If BookyearFromTo.Value = PeriodFromChosen.Value & PeriodToChosen.Value Then
'						Selektie(5).CheckState = System.Windows.Forms.CheckState.Checked
'						Selektie(5).Visible = True
'					Else
'						Selektie(5).CheckState = System.Windows.Forms.CheckState.Unchecked
'						Selektie(5).Visible = False
'					End If
'				End If
'		End Select

'	End Sub
'End Class