Public Class frmJaarlistingBtw
    Private Sub frmJaarlistingBtw_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class JaarBtwBelgie
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Dim ReportText(5) As String 'Koptekstinfo
'	Dim aa As String

'	Dim RapportSelektie As String
'	Dim RapportTitel As String
'	Dim RapportDefinitie As String
'	Dim ListName As String
'	Dim FieldText(20) As String

'	Dim dTotaal As Decimal
'	Dim dBeTeWe As Decimal

'	Dim dTOT As Decimal
'	Dim dBTW As Decimal

'	Dim VsoftVanaf As String
'	Dim VsoftTot As String

'	Dim ktrlEur As Boolean
'	Private Sub Annuleren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Annuleren.Click

'		Me.Close()

'	End Sub

'	Private Sub CmdEmailNBB_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdEmailNBB.Click
'		Dim Printer As New Printer

'		Dim BeginSleutel As String
'		Dim EindSleutel As String
'		Dim KopBuf As String
'		Dim XX As Short
'		Dim Teller As Short
'		Dim FlTabBestand As Short

'		Dim pathString As New VB6.FixedLengthString(260)
'		Dim RetInteger As Short
'		Dim BureauBlad As String

'		Dim dTnt1 As Decimal
'		Dim dTnt2 As Decimal
'		Dim Line As Short
'		Dim BedragMinstens As Decimal

'		dTotaal = 0
'		dBeTeWe = 0
'		If obMunt(0).Checked Then
'			BedragMinstens = 5000
'		Else
'			BedragMinstens = 250
'		End If


'		BeginSleutel = SetSpacing("K0", 13)
'		EindSleutel = SetSpacing("K" & "zzzzzzzzzzzz", 13)

'		ReportText(2) = ListName & " " & Mid(Mim.Text, InStr(Mim.Text, "["))
'		ReportText(0) = VB6.Format(Datum._Value, "dd/mm/yyyy")
'		ReportText(3) = TekstLijn(0).Text
'		InitialiseFields()

'		ktrlEur = EurBefJaar()

'		JetGetOrGreater(TableOfInvoices, 1, BeginSleutel)
'		If Ktrl Or UCase(KeyBuf(TableOfInvoices)) > UCase(EindSleutel) Then
'			Beep()
'			Exit Sub
'		ElseIf VB.Left(KeyBuf(TableOfInvoices), 1) <> VB.Left(BeginSleutel, 1) Then 
'			Beep()
'			Exit Sub
'		Else
'			FieldText(0) = Chr(0)
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub OpenTabBestand
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'			PageCounter = 0
'			If chkAfdrukInVenster.CheckState = 0 Then
'				Printer = Printers(LijstPrinterNr)
'				On Error Resume Next
'				'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'				Printer.PaperBin = LaadTekst(My.Application.Info.Title, "LIJSTPRINTER")
'				'UPGRADE_ISSUE: DoEvents does not return a value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8D115264-E27F-4472-A684-865A00B5E826"'
'				XDoEvents = System.Windows.Forms.Application.DoEvents()
'				If Printer.Width > 12000 Then
'					Printer.FontSize = 10
'					Printer.FontName = "Courier New"
'					Printer.Print(" ")
'					Printer.FontSize = 10
'				Else
'					Printer.FontSize = 7.2
'					Printer.FontName = "Courier New"
'					Printer.Print(" ")
'					Printer.FontSize = 7.2
'				End If
'			End If
'			VpePrintHeader()
'			RecordToField(TableOfInvoices)
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub KontroleVoorwaarden
'		End If

'		Me.Refresh()

'		Do 
'			bNext(TableOfInvoices)
'			If Ktrl Or UCase(KeyBuf(TableOfInvoices)) > UCase(EindSleutel) Then
'				Exit Do
'			End If
'			RecordToField(TableOfInvoices)
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub KontroleVoorwaarden
'		Loop 

'		If obMunt(0).Checked Then
'			FieldText(7) = Dec(dTnt1, MaskBEF)
'			FieldText(8) = Dec(dTnt2, MaskBEF)
'		Else
'			FieldText(7) = Dec(dTnt1, MaskEUR)
'			FieldText(8) = Dec(dTnt2, MaskEUR)
'		End If
'		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'		GoSub PrintDeLijn
'		EindTotaal()
'		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'		GoSub Vs1Afsluiten
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal
'		If chkAfdrukInVenster.CheckState Then
'		Else
'			Printer.NewPage()
'			Printer.EndDoc()
'		End If
'		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'		GoSub BegeleidingsNota
'		Annuleren_Click(Annuleren, New System.EventArgs())
'		Exit Sub

'KontroleVoorwaarden: 
'		'Enkel het reële jaar
'		If VB.Left(AdoGetField(TableOfInvoices, "#v035 #"), 4) <> VB.Right(VB6.Format(Datum._Value, "dd/mm/yyyy"), 4) Then
'			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			Return 
'		End If

'		dTOT = 0
'		Select Case VB.Left(AdoGetField(TableOfInvoices, "#v033 #"), 1)
'			Case "V"
'				For Teller = 55 To 63
'					dTOT = dTOT + Val(AdoGetField(TableOfInvoices, "#v" & VB6.Format(Teller, "000") & " #"))
'				Next 
'				dTOT = dTOT + Val(AdoGetField(TableOfInvoices, "#v089 #"))
'				dBTW = Val(AdoGetField(TableOfInvoices, "#v064 #"))
'				If Mid(AdoGetField(TableOfInvoices, "#v033 #"), 2, 1) = "1" Then
'					dTOT = -dTOT
'					dBTW = -dBTW
'				End If
'				If ktrlEur = True Then
'					If AdoGetField(TableOfInvoices, "#v035 #") > VB.Left(BookyearFromTo.Value, 8) Then
'					Else
'						dTOT = System.Math.Round(dTOT / Euro, 2)
'						dBTW = System.Math.Round(dBTW / Euro, 2)
'					End If
'				End If

'			Case Else
'				'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'				Return 
'		End Select

'		If Trim(AdoGetField(TableOfInvoices, "#v034 #")) <> Trim(KopBuf) Then
'			If FieldText(0) = Chr(0) Then
'			Else
'				If obMunt(0).Checked Then
'					FieldText(7) = Dec(dTnt1, MaskBEF)
'					FieldText(8) = Dec(dTnt2, MaskBEF)
'				Else
'					FieldText(7) = Dec(dTnt1, MaskEUR)
'					FieldText(8) = Dec(dTnt2, MaskEUR)
'				End If
'				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'				GoSub PrintDeLijn
'			End If

'			dTnt1 = 0
'			dTnt2 = 0
'			JetGet(TableOfCustomers, 0, SetSpacing(Mid(AdoGetField(TableOfInvoices, "#v034 #"), 2, 12), 12))
'			KopBuf = AdoGetField(TableOfInvoices, "#v034 #")
'			FieldText(0) = Mid(AdoGetField(TableOfInvoices, "#v034 #"), 2, 12)
'			If Ktrl Then
'				FieldText(1) = "* niet meer aanwezig *"
'			Else
'				RecordToField(TableOfCustomers)
'				FieldText(1) = SetSpacing(AdoGetField(TableOfCustomers, "#A100 #"), 32)
'				SnelHelpPrint(FieldText(1), blLogging)
'				FieldText(2) = SetSpacing(RTrim(RTrim(AdoGetField(TableOfCustomers, "#A104 #")) & " " & RTrim(AdoGetField(aIndex, "#A105 #")) & " " & RTrim(AdoGetField(aIndex, "#A106 #"))), 24)
'				FieldText(3) = SetSpacing(AdoGetField(TableOfCustomers, "#A107 #"), 4)
'				FieldText(4) = SetSpacing(RTrim(AdoGetField(TableOfCustomers, "#A108 #")), 23)
'				FieldText(5) = "BE"
'				FieldText(6) = SetSpacing(Mid(AdoGetField(TableOfCustomers, "#A161 #"), 1, 3) & Mid(AdoGetField(TableOfCustomers, "#A161 #"), 5, 3) & Mid(AdoGetField(TableOfCustomers, "#A161 #"), 9, 3), 9)
'			End If
'		End If

'		'indien gekozen EUR voor een BEF boekhouding...
'		If ktrlEur = True Then
'			dTnt1 = dTnt1 + dTOT
'			dTnt2 = dTnt2 + dBTW
'		ElseIf obMunt(0).Enabled = True And obMunt(1).Checked = True Then 
'			dTnt1 = dTnt1 + System.Math.Round(dTOT / Euro, 2)
'			dTnt2 = dTnt2 + System.Math.Round(dBTW / Euro, 2)
'		Else
'			dTnt1 = dTnt1 + dTOT
'			dTnt2 = dTnt2 + dBTW
'		End If
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'PrintDeLijn: 
'		If dTnt1 < BedragMinstens Then
'			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			Return 
'		ElseIf AdoGetField(TableOfCustomers, "#v150 #") <> "BE" Then 
'			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			Return 
'		ElseIf RTrim(AdoGetField(TableOfCustomers, "#A161 #")) = "" Then 
'			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			Return 
'		Else
'			If RTrim(AdoGetField(TableOfCustomers, "#A161 #")) = BtwKontrole(RTrim(AdoGetField(TableOfCustomers, "#A161 #")), False) Then
'			Else
'				Msg = "Het BTW nummer : " & RTrim(AdoGetField(TableOfCustomers, "#A161 #")) & " is foutief !" & vbCrLf
'				Msg = Msg & "Klant : " & AdoGetField(TableOfCustomers, "#A110 #") & " " & AdoGetField(TableOfCustomers, "#A100 #") & vbCrLf & vbCrLf
'				Msg = Msg & "Een 000-000-000 nummer wordt ingevoegd.  Gelieve de kontrolelijst" & vbCrLf
'				Msg = Msg & "na te kijken én te verbeteren a.u.b. vooraleer door te sturen..."
'				MsgBox(Msg)
'				AdoInsertToRecord(TableOfCustomers, "000-000-000", "A161 ")
'				FieldText(6) = SetSpacing(Mid(AdoGetField(TableOfCustomers, "#A161 #"), 1, 3) & Mid(AdoGetField(TableOfCustomers, "#A161 #"), 5, 3) & Mid(AdoGetField(TableOfCustomers, "#A161 #"), 9, 3), 9)
'				bUpdate(TableOfCustomers, 0)
'			End If
'			'kontrole btw nummer
'			If chkAfdrukInVenster.CheckState Then
'			Else
'				Printer.Write(vbCrLf)
'			End If

'			dTotaal = dTotaal + dTnt1
'			dBeTeWe = dBeTeWe + dTnt2
'			Line = Line + 1
'			FieldText(0) = Dec(Line, "000000")
'			VpePrintLines()
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub BtwLijn
'			FieldText(0) = ""
'		End If
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'OpenTabBestand: 
'		FlTabBestand = FreeFile
'		FileOpen(FlTabBestand, LocationCompanyData & VB.Right(VB6.Format(Datum._Value, "dd/mm/yyyy"), 4) & ".BTW", OpenMode.Output)

'		FieldText(0) = "000000"
'		FieldText(1) = SetSpacing(String99(Reading, 46), 32) 'Naam aangever
'		FieldText(2) = SetSpacing(String99(Reading, 47), 24) 'Straat en nr.
'		FieldText(3) = SetSpacing(String99(Reading, 48), 4) 'Postcode
'		FieldText(4) = SetSpacing(Mid(String99(Reading, 48), 6), 23) 'Plaats
'		FieldText(5) = "BE"
'		FieldText(6) = Mid(String99(Reading, 51), 1, 3) & Mid(String99(Reading, 51), 5, 3) & Mid(String99(Reading, 51), 9, 3)
'		FieldText(7) = Space(10)
'		FieldText(8) = Space(10)
'		FieldText(9) = Space(8)
'		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'		GoSub BtwLijn
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'BtwLijn: 
'		For Teller = 0 To 6
'			Print(FlTabBestand, FieldText(Teller))
'		Next 
'		If obMunt(0).Checked Then
'			Print(FlTabBestand, Dec(Val(FieldText(7)), "0000000000"))
'			Print(FlTabBestand, Dec(Val(FieldText(8)), "0000000000"))
'		Else
'			Print(FlTabBestand, Dec(Val(FieldText(7)) * 100, "0000000000"))
'			Print(FlTabBestand, Dec(Val(FieldText(8)) * 100, "0000000000"))
'		End If

'		If FieldText(0) = "000000" Then
'			If obMunt(0).Checked = True Then
'				Print(FlTabBestand, "B" & VB.Right(VB6.Format(Datum._Value, "dd/mm/yyyy"), 4) & New String(" ", 3) & vbCrLf)
'			Else
'				Print(FlTabBestand, "E" & VB.Right(VB6.Format(Datum._Value, "dd/mm/yyyy"), 4) & New String(" ", 3) & vbCrLf)
'			End If
'		Else
'			Print(FlTabBestand, New String(" ", 8) & vbCrLf)
'		End If
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'Vs1Afsluiten: 
'		FieldText(0) = "999999"
'		If obMunt(0).Checked Then
'			FieldText(1) = Dec(dTotaal, "0000000000000000")
'			FieldText(1) = FieldText(1) & Dec(dBeTeWe, "0000000000000000")
'		Else
'			FieldText(1) = Dec(dTotaal * 100, "0000000000000000")
'			FieldText(1) = FieldText(1) & Dec(dBeTeWe * 100, "0000000000000000")
'		End If
'		FieldText(2) = Space(24)
'		FieldText(3) = Space(4)
'		FieldText(4) = Space(23)
'		FieldText(5) = "BE"
'		FieldText(6) = Mid(String99(Reading, 51), 1, 3) & Mid(String99(Reading, 51), 5, 3) & Mid(String99(Reading, 51), 9, 3)
'		FieldText(7) = Space(10)
'		FieldText(8) = Space(10)
'		FieldText(9) = Space(8)
'		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'		GoSub BtwLijn
'		FileClose(FlTabBestand)
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 


'BegeleidingsNota: 
'		RetInteger = SHGetFolderPath(0, rvDesktop2, 0, 0, pathString.Value)
'		BureauBlad = VB.Left(pathString.Value, InStr(pathString.Value, Chr(0)) - 1)
'		If Not CopyFile(LocationCompanyData, BureauBlad, VB.Right(VB6.Format(Datum._Value, "dd/mm/yyyy"), 4) & ".BTW") Then
'			MsgBox("Fout tijdens het copiëren.  Probeer opnieuw !")
'			GoTo BegeleidingsNota
'		End If

'BNvraag: 
'		Msg = "Positionele jaarlisting op uw Bureaublad doormailen naar Vsoft voor afhandeling" & vbCrLf & vbCrLf & "Kies 'ja' voor doormailen (aanbevolen), 'nee' indien U zelf afhandelt (afleveringnota's worden afgedrukt)"
'		Ktrl = MsgBox(Msg, MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton3 + MsgBoxStyle.Question)
'		Select Case Ktrl
'			Case 2
'				Msg = "Taak verlaten zonder enige verwerking.  Bent U zeker"
'				Ktrl = MsgBox(Msg, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question)
'				If Ktrl = 7 Then
'					GoTo BNvraag
'				Else
'					Exit Sub
'				End If

'			Case 6

'				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'				If Me.MPISessie.SessionID <> 0 Then
'				Else
'					On Error Resume Next
'					Me.MPISessie.SignOn()
'					If Err.Number Then
'						SnelHelpPrint(Err.Description, blLogging)
'					Else
'						On Error GoTo 0
'						Me.MPIBericht.SessionID = Me.MPISessie.SessionID
'						SnelHelpPrint("E-mail sessie met succes opgestart. IDkode :" & VB6.Format(Me.MPISessie.SessionID), blLogging)
'					End If
'				End If
'				On Error GoTo MPIError
'				'Compose New Message
'				Me.MPIBericht.Compose()

'				'Address message
'				Me.MPIBericht.RecipDisplayName = "vsoftINTERVAT"
'				Me.MPIBericht.RecipAddress = "SMTP:info@rv.be"

'				'Resolve recipient name
'				Me.MPIBericht.AddressResolveUI = True '=dialogbox, false = error genereren

'				'Create the message
'				Me.MPIBericht.MsgSubject = "Btwjaarlisting"
'				Me.MPIBericht.MsgNoteText = "Formaat:Positioneel Bericht.  Aangemaakt met marIntegraal versie " & marVersion
'				Me.MPIBericht.AttachmentPathName = BureauBlad & "\" & VB.Right(VB6.Format(Datum._Value, "dd/mm/yyyy"), 4) & ".BTW"

'				'Send the message
'				On Error Resume Next
'				Me.MPIBericht.Send(True)
'				'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'				'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'				System.Windows.Forms.Cursor.Current = vbNormal
'				If Err.Number = 32001 Then
'					MsgBox("U koos om de mail af te breken.", MsgBoxStyle.Information)
'					GoTo BNvraag
'				Else
'					MsgBox("Zorg ervoor dat uw mailtoepassing effectief kan verzenden nu of straks.  U ontvangt later nog ontvangstbevestiging vanwege onze diensten", MsgBoxStyle.Information)
'					Exit Sub
'				End If

'			Case 7
'				'niks
'				'Zelf afhandelen (enkel nog afdruk afleveringnota's hierna
'				Msg = "Het bestand " & VB.Right(VB6.Format(Datum._Value, "dd/mm/yyyy"), 4) & ".BTW" & " staat op het bureaublad ter beschikking.  Volg bvb. de instructies in uw software voor DVD- of CDschrijver om het bestand op dergelijk medium te bewaren." & vbCrLf & vbCrLf & "Bij voorkeur AANGETEKEND of via afgifte op het plaatselijk kantoor met AFSTEMPELING van één exemplaar van de BEGELEIDINGSNOTA welke hierna wordt afgedrukt."
'				MsgBox(Msg, MsgBoxStyle.Information)
'		End Select

'		Dim PrintEx1 As Short
'		Dim AntEx As Short
'		Dim X As Short

'		On Error Resume Next

'		For AntEx = 1 To CShort(3 / Val(VB.Left(String99(Reading, 185), 1)))
'			PrintUserDef("124")
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub TekstBlok
'		Next AntEx
'		Printer.EndDoc()
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'TekstBlok: 
'		Printer.CurrentY = Val(VsoftVanaf)
'		Printer.CurrentX = 0
'		Printer.FontName = "Courier New"
'		Printer.FontSize = 12
'		Printer.FontBold = True
'		Printer.Write("                                BEGELEIDINGSNOTA" & vbCrLf & vbCrLf)
'		Printer.FontBold = False
'		Printer.Write("             Jaarlijkse opgave van de afnemers-belastingplichtigen" & vbCrLf)
'		Printer.Write("                               op CD-Rom of Diskette" & vbCrLf & vbCrLf & vbCrLf)
'		Printer.Write(TAB(5), "Naam van de belastingplichtige : ")
'		Printer.FontBold = True
'		Printer.Write(String99(Reading, 46) & vbCrLf & vbCrLf)
'		Printer.FontBold = False
'		Printer.Write(TAB(5), "Adres :" & vbCrLf)
'		Printer.FontBold = True
'		Printer.Write(TAB(20), String99(Reading, 47) & vbCrLf)
'		Printer.Write(TAB(20), String99(Reading, 48) & vbCrLf & vbCrLf & vbCrLf & vbCrLf)
'		Printer.FontBold = False
'		Printer.Write(TAB(5), "BTW-registratienummer : " & "BE-0")
'		Printer.FontBold = True
'		Printer.Write(String99(Reading, 51) & vbCrLf & vbCrLf)
'		Printer.FontBold = False
'		Printer.Write(TAB(5), "Telefoonnummer bevoegd persoon en binnenpost : ")
'		Printer.FontBold = True
'		Printer.Write(String99(Reading, 49) & vbCrLf & vbCrLf)
'		Printer.FontBold = False
'		Printer.Write(TAB(5), "Jaar van de handelingen, opgenomen in de opgave : ")
'		Printer.FontBold = True
'		Printer.Write(VB.Right(TekstLijn(1).Text, 4) & vbCrLf & vbCrLf)
'		Printer.FontBold = False
'		Printer.Write(TAB(5), "Aantal in de opgave opgenomen afnemers : ")
'		Printer.FontBold = True
'		Printer.Write(Dec(Line, MaskSy(0)) & vbCrLf & vbCrLf)
'		Printer.FontBold = False
'		Printer.Write(TAB(5), "Totaal omzetcijfers (belastingen niet inbegrepen) : EUR ")
'		Printer.FontBold = True
'		Printer.Write(Dec(dTotaal, MaskEUR) & vbCrLf & vbCrLf)
'		Printer.FontBold = False
'		Printer.Write(TAB(5), "Totaal bedrag van de belastingen : EUR ")
'		Printer.FontBold = True
'		Printer.Write(Dec(dBeTeWe, MaskEUR) & vbCrLf & vbCrLf & vbCrLf)
'		Printer.FontBold = False
'		Printer.Write(TAB(50), "Oprecht en waar verklaard" & vbCrLf & vbCrLf & vbCrLf)
'		Printer.Write(TAB(10), "datum" & vbCrLf)
'		Printer.Write(TAB(10), "(Handtekening)" & vbCrLf)
'		Printer.Write(TAB(10), "(Hoedanigheid)" & vbCrLf)
'		Printer.NewPage()
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'MPIError: 
'		MsgBox(ErrorToString())
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal
'		Resume Next

'	End Sub

'	Private Sub Datum_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Datum.Change

'		Me.Text = "Jaarlisting B.T.W. België " & VB.Right(VB6.Format(Datum._Value, "dd/mm/yyyy"), 4) & " !!!"
'		ListName = Me.Text

'	End Sub


'	Private Sub EindTotaal()
'		Dim Printer As New Printer
'		Dim T As Short

'		For T = 0 To 8
'			FieldText(T) = ""
'		Next 
'		FieldText(0) = "Totaal"
'		If obMunt(0).Checked Then
'			FieldText(7) = Dec(dTotaal, MaskBEF)
'			FieldText(8) = Dec(dBeTeWe, MaskBEF)
'		Else
'			FieldText(7) = Dec(dTotaal, MaskEUR)
'			FieldText(8) = Dec(dBeTeWe, MaskEUR)
'		End If

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

'		If chkAfdrukInVenster.CheckState Then
'			Xlog.X.AddItem(aa, Xlog.X.Rows - 1)
'			Xlog.X.set_ColWidth(0, 705)
'			Xlog.X.set_ColWidth(1, 2055)
'			Xlog.X.set_ColWidth(2, 2130)
'			Xlog.X.set_ColWidth(3, 495)
'			Xlog.X.set_ColWidth(4, 1545)
'			Xlog.X.set_ColWidth(5, 285)
'			Xlog.X.set_ColWidth(6, 1065)
'			Xlog.X.set_ColWidth(7, 900)
'			Xlog.X.set_ColWidth(8, 900)
'			Xlog.WindowState = System.Windows.Forms.FormWindowState.Maximized

'			Xlog.X.set_ColAlignment(7, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
'			Xlog.X.set_ColAlignment(8, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)

'			'XLog.X.GridLines = False
'			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'			'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = vbNormal
'			Xlog.Afsluiten.Enabled = False
'			Xlog.WijzigenLijn.Visible = False
'			Xlog.Afsluiten.TabStop = False
'			Xlog.cbAfbeelding.Visible = False
'			XLogKey = ""
'			Xlog.SSTab1.TabPages.Item(1).Visible = False
'			Xlog.ShowDialog()
'			Xlog.Close()
'		End If
'		Exit Sub

'PrtHandler4: 
'		MsgBox("Kontroleer de printer.")
'		Resume 

'	End Sub

'	Private Sub JaarBtwBelgie_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

'		If Not Toegankelijk(Me) Then
'			Me.Close()
'			Exit Sub
'		End If

'		Dim TempbModus As Short

'		For CountTo = 0 To BJPERDAT.PeriodeBoekjaar.Items.Count
'			If Mid(VB6.GetItemString(BJPERDAT.PeriodeBoekjaar, CountTo), 14, 5) = "31/12" Then
'				Datum.Value = Mid(VB6.GetItemString(BJPERDAT.PeriodeBoekjaar, CountTo), 14)
'				Datum.Enabled = False
'				Exit For
'			End If
'		Next 

'		Me.Text = "Jaarlisting B.T.W. België " & VB.Right(VB6.Format(Datum._Value, "dd/mm/yyyy"), 4) & " !!!"
'		ListName = Me.Text
'		TopDown.Text = ListName
'		If bhEuro Then
'			Me.obMunt(1).Checked = True
'			Me.obMunt(0).Enabled = False
'			'MsgBox "Huidig boekjaar reeds in EURO.  Enkel uitdruk in EURO mogelijk voor jaar " + Right(Format(Datum, "dd/mm/yyyy"), 4), vbInformation
'		Else
'			Me.obMunt(0).Checked = True
'		End If

'	End Sub


'	Private Sub InitialiseFields()
'		Dim T As Short

'		ReportField(0) = "Line"
'		ReportTab(0) = 2

'		ReportField(1) = "Naam"
'		ReportTab(1) = 9

'		ReportField(2) = "Straat en Nummer"
'		ReportTab(2) = 42

'		ReportField(3) = "P/C"
'		ReportTab(3) = 67

'		ReportField(4) = "Stad"
'		ReportTab(4) = 72

'		ReportField(5) = "LN"
'		ReportTab(5) = 96

'		ReportField(6) = "BTW Nr."
'		ReportTab(6) = 99

'		ReportField(7) = "Goederen"
'		ReportTab(7) = 109

'		ReportField(8) = "BTW"
'		ReportTab(8) = 119

'		ReportTab(9) = 0

'		If chkAfdrukInVenster.CheckState Then
'			Me.Hide()
'			Xlog.Close()
'			Xlog.Hide()
'			Xlog.Text = "Jaarlisting BTW België"
'			Xlog.X.Cols = 9
'			Xlog.X.Row = 0
'			For T = 0 To 8
'				Xlog.X.Col = T
'				Xlog.X.Text = ReportField(T)
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

'	Private Sub PrintUserDef(ByRef TypeEnTaal As String)
'		Dim B As Short
'		Dim Printer As New Printer
'		Dim Dummy As String
'		Dim BeginXbox As Short
'		Dim BeginYbox As Short
'		Dim T As Short
'		Dim Tabulatie As Short
'		Dim FlFree As Short
'		Dim Teller As Short

'		Dim PPsTekst(50) As String
'		Dim psX(50) As Single
'		Dim psY(50) As Single
'		Dim psFontSize(50) As Single
'		Dim psFontName(50) As String
'		Dim psFontBold(50) As Short
'		Dim psFontItalic(50) As Short
'		Dim psFontUnderLine(50) As Short
'		Dim psColor(50) As Integer
'		Dim MaxPslokatie As Short

'		Dim BoxTeller As Short
'		Dim Box(10) As Short
'		Dim BeginX(10) As Short
'		Dim BeginY(10) As Short
'		Dim TotX(10) As Short
'		Dim TotY(10) As Short
'		Dim PsLokatie As Short

'		On Error GoTo ErrorLoad

'		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		If Dir(LocationCompanyData & "DDEF" & TypeEnTaal & ".Txt") = "" Then
'			Beep()
'			Exit Sub
'		Else
'			FlFree = FreeFile
'			FileOpen(FlFree, LocationCompanyData & "DDEF" & TypeEnTaal & ".Txt", OpenMode.Input)
'			Input(FlFree, Dummy)
'			Input(FlFree, VsoftVanaf)
'			Input(FlFree, VsoftTot)
'			For Teller = 0 To 10
'				Input(FlFree, BeginX(Teller))
'				Input(FlFree, BeginY(Teller))
'				Input(FlFree, TotX(Teller))
'				Input(FlFree, TotY(Teller))
'				Input(FlFree, Box(Teller))
'			Next 
'			Teller = 0
'			While Not EOF(FlFree)
'				Input(FlFree, PPsTekst(Teller))
'				Input(FlFree, psX(Teller))
'				Input(FlFree, psY(Teller))
'				Input(FlFree, psFontSize(Teller))
'				Input(FlFree, psFontName(Teller))
'				Input(FlFree, psFontBold(Teller))
'				Input(FlFree, psFontItalic(Teller))
'				Input(FlFree, psFontUnderLine(Teller))
'				Input(FlFree, psColor(Teller))
'				Teller = Teller + 1
'			End While
'			MaxPslokatie = Teller
'			FileClose(FlFree)
'		End If

'		BeginXbox = BeginX(0)
'		BeginYbox = BeginY(0)

'		PsLokatie = 0
'		Do While PsLokatie <= MaxPslokatie
'			If PPsTekst(PsLokatie) <> "" Then
'				Printer.FontName = psFontName(PsLokatie)
'				Printer.FontItalic = psFontItalic(PsLokatie)
'				Printer.FontSize = psFontSize(PsLokatie)
'				Printer.FontBold = psFontBold(PsLokatie)
'				Printer.FontUnderline = psFontUnderLine(PsLokatie)
'				Printer.ForeColor = psColor(PsLokatie)
'			End If
'			Printer.CurrentX = psX(PsLokatie)
'			Printer.CurrentY = psY(PsLokatie)
'			Printer.Write(PPsTekst(PsLokatie))
'			PsLokatie = PsLokatie + 1
'		Loop 
'		For T = 0 To 10
'			If BeginX(T) = 0 Then
'			ElseIf Box(T) Then 
'				Printer.Line(False, BeginX(T), BeginY(T), False, TotX(T), TotY(T), B)
'			Else
'				'printer.Line (BeginX(T), BeginY(T))-(TotX(T), TotY(T))
'			End If
'		Next 

'		Dim FiguurX As Short
'		Dim FiguurY As Short
'		Dim FiguurName As String
'		Dim FigBestandsnaam As String
'		Dim Hoogte As Object
'		Dim Breedte As Object

'		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		If Dir(LocationCompanyData & "DDEF" & TypeEnTaal & "G.Txt") = "" Then
'		Else
'			FlFree = FreeFile
'			FileOpen(FlFree, LocationCompanyData & "DDEF" & TypeEnTaal & "G.Txt", OpenMode.Input)
'			While Not EOF(FlFree)
'				Input(FlFree, FiguurX)
'				Input(FlFree, FiguurY)
'				Input(FlFree, FiguurName)
'				If ScrLeesTekstBestand(Msg, LocationCompanyData & FiguurName & ".mfd") Then
'					FigBestandsnaam = VB.Left(Msg, InStr(Msg, vbTab) - 1)
'					Mim.imgFiguur.Image = System.Drawing.Image.FromFile(FigBestandsnaam)
'					Msg = Mid(Msg, InStr(Msg, vbTab) + 1)
'					'UPGRADE_WARNING: Couldn't resolve default property of object Hoogte. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					Hoogte = VB.Left(Msg, InStr(Msg, vbTab) - 1)
'					Msg = Mid(Msg, InStr(Msg, vbTab) + 1)
'					'UPGRADE_WARNING: Couldn't resolve default property of object Breedte. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					Breedte = Msg
'					Printer.PaintPicture(Mim.imgFiguur.Image, FiguurX, FiguurY, Breedte, Hoogte)
'				Else
'					MsgBox("afdrukprobleemke figuurobject: " & FiguurName)
'				End If
'			End While
'			FileClose(FlFree)
'		End If
'		Exit Sub

'ErrorLoad: 
'		MsgBox("Stop tijdens inladen dokumentdefinitie" & vbCrLf & vbCrLf & ErrorToString())
'		Exit Sub
'		Resume 

'	End Sub

'	Private Sub VpePrintLines()
'		Dim Printer As New Printer
'		Dim T As Short
'		Dim VeldTekst As String

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
'		If chkAfdrukInVenster.CheckState Then
'			Xlog.X.AddItem(aa, Xlog.X.Rows - 1)
'		ElseIf Printer.CurrentY >= Printer.Height - 1200 Then 
'			Printer.NewPage()
'			Printer.FontSize = Printer.FontSize
'			Printer.Print(" ")
'			Printer.FontSize = Printer.FontSize
'			VpePrintHeader()
'		End If

'	End Sub

'	Private Sub TekstLijn_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstLijn.Enter
'		Dim Index As Short = TekstLijn.GetIndex(eventSender)

'		TekstLijn(Index).SelectionLength = Len(TekstLijn(Index).Text)

'	End Sub

'	Function EurBefJaar() As Boolean

'		Dim tempoBoekjaar As String

'		EurBefJaar = False
'		If VB.Right(BookyearFromTo.Value, 4) <> "1231" Then
'			If bhEuro Then
'				'eventjes kijken naar vorig jaar
'				JetTableClose(TableOfCounters)
'				tempoBoekjaar = JetTableName(TableOfCounters)
'				JetTableName(TableOfCounters) = "jr" & CDbl(BJPERDAT.Boekjaar.Text) - 1
'				If String99(Reading, 296) <> "EUR" Then
'					'extra controle nodig...
'					EurBefJaar = True
'					MsgBox("Werkelijke jaar met documenten in EUR en BEF.", MsgBoxStyle.Information)
'				End If
'				JetTableClose(TableOfCounters)
'				JetTableName(TableOfCounters) = tempoBoekjaar
'			End If
'		End If

'	End Function
'End Class