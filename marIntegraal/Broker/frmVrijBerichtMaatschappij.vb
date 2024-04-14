Public Class frmVrijBerichtMaatschappij
    Private Sub frmVrijBerichtMaatschappij_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class AS1VrijBericht
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Dim A As New VB6.FixedLengthString(140)
'	Dim aa As String
'	Dim FlAsNet As Short
'	Dim MaxLijn79 As Short
'	Dim KontaktPersoon As Short

'	Dim VsoftVanaf As String
'	Dim VsoftTot As String
'	Dim BeginXbox As Short
'	Dim BeginYbox As Short

'	Function asDirectOK() As Boolean
'		Dim TelLijn As Integer
'		Dim positieCRLF As Integer
'		Dim SpatieLijn As Integer
'		Dim Tekst As String
'		Dim TekstLijn As String
'		Dim MSG As String
'		Dim MijKeuze As String

'		If Mid(KeuzeInfo(4).Text, 1, 1) = "P" Then
'			'enkel bewaren in ASx logboek indien POLIS
'		Else
'			Exit Function
'		End If

'		asDirectOK = False
'		If VrijeTekst.Text = "" Then
'			Exit Function
'		Else
'			VoorVoegsel()
'			TelLijn = 0
'			Tekst = VrijeTekst.Text
'			Do While Tekst <> ""
'				positieCRLF = InStr(Tekst, vbCrLf)
'				If positieCRLF Then
'					TekstLijn = VB.Left(Tekst, positieCRLF - 1)
'					Tekst = VB.Right(Tekst, Len(Tekst) - positieCRLF - 1)
'				Else
'					TekstLijn = Tekst
'					Tekst = ""
'				End If
'				TelLijn = TelLijn + 1
'				If Len(TekstLijn) > MaxLijn79 Then
'					MsgBox("Line " & Str(TelLijn) & " bestaat uit " & Str(Len(TekstLijn)) & " Tekens. (max." & Str(MaxLijn79) & " per lijn toegelaten)")
'					Exit Function
'				End If
'			Loop 
'		End If

'		If AlleMijen.CheckState Then
'			MijKeuze = "ALLE AS/2 maatschappijen !!!!"
'		Else
'			MijKeuze = KeuzeInfo(0).Text
'		End If

'		TelLijn = 0
'		aa = ""
'		Tekst = VrijeTekst.Text
'		Do While Tekst <> ""
'			If TelLijn = 14 Then
'				Mid(A.Value, 48, 2) = VB6.Format(Val(Mid(A.Value, 48, 2)) + 1, "00")
'				Mid(A.Value, 50, 1) = "S"
'				SchrijfWeg(A.Value & aa)
'				aa = ""
'				TelLijn = 0
'			End If
'			TelLijn = TelLijn + 1
'			positieCRLF = InStr(Tekst, vbCrLf)
'			If positieCRLF Then
'				aa = aa & SetSpacing(VB.Left(Tekst, positieCRLF - 1), 79)
'				Tekst = VB.Right(Tekst, Len(Tekst) - positieCRLF - 1)
'			Else
'				aa = aa & SetSpacing(Tekst, 79)
'				Tekst = ""
'			End If
'		Loop 
'		For SpatieLijn = TelLijn + 1 To 14
'			aa = aa & Space(79)
'		Next 
'		Mid(A.Value, 48, 2) = VB6.Format(Val(Mid(A.Value, 48, 2)) + 1, "00")
'		Mid(A.Value, 50, 1) = "X"
'		SchrijfWeg(A.Value & aa)
'		asDirectOK = True
'		SnelHelpPrint("Bewaard in asLogboek", BL_LOGGING)

'	End Function

'	'UPGRADE_WARNING: Event AfdrukBericht.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub AfdrukBericht_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AfdrukBericht.CheckStateChanged

'		MaxLijn79 = 79
'		If AfdrukBericht.CheckState = 0 Then
'		Else
'			Wegschrijven.Text = "Afdrukken"
'			AfdrukBericht.Enabled = False
'		End If

'	End Sub

'	'UPGRADE_WARNING: Event AlleMijen.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub AlleMijen_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AlleMijen.CheckStateChanged

'		Select Case AlleMijen.CheckState
'			Case 0
'				KeuzeInfo(0).Visible = True
'			Case 1
'				KeuzeInfo(4).SelectedIndex = 2
'				KeuzeInfo(0).Visible = False
'			Case Else
'				MsgBox("STOP")
'		End Select

'	End Sub

'	Private Sub DrukAf()
'		Dim positieCRLF As Short
'		Dim pfTl As Short
'		Dim TabBold As Short
'		Dim tSip As Short
'		Dim Pagina As Short
'		Dim Printer As New Printer
'		Dim rSip(5) As String
'		Dim Taal As Short
'		Dim FlTemp As Short
'		Dim T As Short
'		Dim Tekst As String
'		Dim TabIs As Short
'		Dim MSG As String

'		Printer = Printers(DOCUMENTPRINTER_NUMBER)
'		On Error Resume Next
'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		Printer.PaperBin = LaadTekst(My.Application.Info.Title, "dokumentPRINTER")
'		If Printer.Orientation = PrinterObjectConstants.vbPRORLandscape Then
'			Printer.Orientation = PrinterObjectConstants.vbPRORPortrait
'			System.Windows.Forms.Application.DoEvents()
'		End If

'		JetGet(TABLE_SUPPLIERS, 0, SetSpacing(VB.Left(KeuzeInfo(6).Text, 2) & VB.Left(KeuzeInfo(0).Text, 4), 12))
'		If KTRL Then
'			MsgBox("stop")
'		Else
'			RecordToField(TABLE_SUPPLIERS)
'		End If

'PrintSteedsOpnieuw: 
'		Tekst = VrijeTekst.Text
'		' If AfDrukBericht.Value = 1 Then
'		TabIs = 10
'		'Else
'		'    TabIs = 20
'		'End If

'		'On Local Error GoTo FileHandler

'		Taal = Val(AdoGetField(TABLE_SUPPLIERS, "#A10C #"))
'		If Val(AdoGetField(TABLE_SUPPLIERS, "#A102 #")) = 0 Then
'			rSip(0) = AdoGetField(TABLE_SUPPLIERS, "#A100 #")
'		Else
'			rSip(0) = Mid(fmarBoxText("003", VB6.Format(Taal), AdoGetField(TABLE_SUPPLIERS, "#A102 #")), 4, 10) & " " & AdoGetField(TABLE_SUPPLIERS, "#A100 #")
'		End If

'		If Val(AdoGetField(TABLE_SUPPLIERS, "#vs01 #")) = 0 Then
'			rSip(1) = AdoGetField(TABLE_SUPPLIERS, "#A125 #")
'		Else
'			rSip(1) = Mid(fmarBoxText("003", VB6.Format(Taal), AdoGetField(TABLE_SUPPLIERS, "#vs01 #")), 4, 10) & " " & AdoGetField(TABLE_SUPPLIERS, "#A125 #")
'		End If

'		rSip(2) = AdoGetField(TABLE_SUPPLIERS, "#A104 #") & " " & AdoGetField(TABLE_SUPPLIERS, "#A105 #") & " " & AdoGetField(TABLE_SUPPLIERS, "#A106 #")
'		rSip(4) = AdoGetField(TABLE_SUPPLIERS, "#A109 #") & " " & AdoGetField(TABLE_SUPPLIERS, "#A107 #") & " " & AdoGetField(TABLE_SUPPLIERS, "#A108 #")

'		On Error GoTo PrintHandler

'		Pagina = 0
'		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'		GoSub KopBalk
'		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'		GoSub DetailLijnen
'		Printer.EndDoc()
'		Me.Activate()
'		MSG = "Herdrukken van dit dokument ?" & vbCrLf
'		MSG = MSG & "Bent U zeker ?" & vbCrLf & vbCrLf
'		MSG = MSG & "Cancel of ESC om nog iets te wijzigen..."
'		KTRL = MsgBox(MSG, 3, "Afdruk via printer")
'		Select Case KTRL
'			Case 2, 7
'			Case Else
'				GoTo PrintSteedsOpnieuw
'		End Select
'		Exit Sub

'KopBalk: 
'		PrintUserDef("1" & VB6.Format(Taal) & "4")
'		Printer.CurrentX = BeginXbox + 350
'		Printer.CurrentY = BeginYbox + 350
'		Printer.FontSize = 10
'		Printer.FontBold = True
'		For tSip = 0 To 4
'			Printer.Write(UCase(rSip(tSip)) & vbCrLf)
'			Printer.CurrentX = BeginXbox + 350
'		Next 

'		Printer.CurrentY = Val(VsoftVanaf)
'		Printer.CurrentX = 0
'		Printer.FontSize = 10

'		Printer.Print(TAB(TabIs))
'		TabBold = Printer.CurrentX

'		Printer.Write(TAB(60), UCase(VB6.Format(Now, "DDDD dd/mm/yyyy hh:mm")) & vbCrLf & vbCrLf)
'		Printer.Write(vbCrLf)

'		pfTl = 0
'		Pagina = Pagina + 1
'		If VB.Left(KeuzeInfo(6).Text, 2) = "CO" Then
'			Printer.Write(TAB(10), "AGENT  : " & VB.Right(KeuzeInfo(0).Text, 8) & vbCrLf & vbCrLf)
'		End If

'		Printer.Write(TAB(10), "T.A.V. : ")
'		Printer.Write(TekstInfo(2).Text & " " & Trim(Me.lFax.Text))
'		Printer.Write(vbCrLf)

'		If VB.Left(KeuzeInfo(6).Text, 2) = "CO" Then
'			Printer.Write(TAB(10), "ZETEL  : ")
'			Printer.FontBold = True
'			Printer.Write(VB.Right(KeuzeInfo(5).Text, Len(KeuzeInfo(5).Text) - 3))
'			Printer.Write(vbCrLf)

'			Printer.Write(TAB(10), "DIENST : ")
'			Printer.Write(VB.Right(KeuzeInfo(1).Text, Len(KeuzeInfo(1).Text) - 3))
'			Printer.Write(vbCrLf)

'			Printer.Write(TAB(10), "TAK    : ")
'			Printer.Write(Mid(KeuzeInfo(2).Text, InStr(KeuzeInfo(2).Text, ":") + 2)) '" "; Right(KeuzeInfo(3).Text, Len(KeuzeInfo(3).Text) - 3);
'			Printer.Write(vbCrLf)
'		End If

'		Printer.Write(TAB(10), "INZAKE : ")
'		Printer.Write(TekstInfo(0).Text)
'		Printer.Write(vbCrLf)

'		If VB.Left(KeuzeInfo(6).Text, 2) = "CO" Then
'			Printer.Write(TAB(10), VB.Right(KeuzeInfo(4).Text, Len(KeuzeInfo(4).Text) - 3) & " : ")
'			Printer.Write(TekstInfo(1).Text)
'			Printer.Write(vbCrLf)
'		End If

'		Printer.FontName = "Courier New"
'		'If Printer.DeviceName = "Fax" Then
'		Printer.FontBold = True
'		'Else
'		'    Printer.FontBold = False
'		'End If
'		Printer.FontSize = 10
'		Printer.Write(vbCrLf & vbCrLf)
'		pfTl = 0
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'DetailLijnen: 
'		Do While Tekst <> ""
'			positieCRLF = InStr(Tekst, vbCrLf)
'			If positieCRLF Then
'				Printer.Write(TAB(TabIs), VB.Left(Tekst, positieCRLF - 1) & vbCrLf)
'				Tekst = VB.Right(Tekst, Len(Tekst) - positieCRLF - 1)
'			Else
'				Printer.Write(TAB(TabIs), Tekst & vbCrLf)
'				Tekst = ""
'			End If
'			pfTl = pfTl + 1
'			If Printer.CurrentY >= Printer.Height - 1200 Then
'				Printer.NewPage()
'				Printer.CurrentY = 400
'				If AfdrukBericht.CheckState = 0 Then
'					Printer.Write(vbCrLf & vbCrLf, TAB(TabIs), "** Kontroleblad Bericht via ASSURNET.  Tijdstip opmaak : " & VB6.Format(Now, "hh:mm:ss") & " **" & vbCrLf)
'				End If
'			End If
'		Loop 
'		If AfdrukBericht.CheckState = 0 Then
'			Printer.Write(vbCrLf & vbCrLf, TAB(TabIs), "** Kontroleblad Bericht via ASSURNET.  Tijdstip opmaak : " & VB6.Format(Now, "hh:mm:ss") & " **" & vbCrLf)
'		End If
'		Printer.NewPage()
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'PrintHandler: 
'		MsgBox("Stopkode extern toestel." & vbCrLf & vbCrLf & "Kontroleer, of rapporteer aan R&&Vsoft.", 0, "Onverwachte situatie")
'		Resume 

'	End Sub

'	'UPGRADE_WARNING: Event cbDocumentPrinterHier.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub cbDocumentPrinterHier_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbDocumentPrinterHier.SelectedIndexChanged

'		DOCUMENTPRINTER_NUMBER = cbDocumentPrinterHier.SelectedIndex

'	End Sub

'	Private Sub cbTogglePrinter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbTogglePrinter.Click

'		Me.cbDocumentPrinterHier.Enabled = Not Me.cbDocumentPrinterHier.Enabled

'	End Sub

'	Private Sub AS1VrijBericht_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
'		Top = 0
'		Left = 0

'		cbDocumentPrinterHier.Items.Clear()
'		If Printers.Count = 0 Then MsgBox("Installeer eerst een printerdriver a.u.b. (ook al beschikt U nog over geen printer.  Bij blijvende problemen in netwerk gelieve op te starten met het command '/P=FALSE' en uw netwerkbeheerder te informeren)", MsgBoxStyle.Exclamation) : End
'		For COUNT_TO = 0 To Printers.Count - 1
'			'UPGRADE_ISSUE: Printer property Printers.Port was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
'			Me.cbDocumentPrinterHier.Items.Add(Printers(COUNT_TO).Port & " " & Printers(COUNT_TO).DeviceName)
'		Next 
'		cbDocumentPrinterHier.SelectedIndex = DOCUMENTPRINTER_NUMBER

'		PAGE_COUNTER = 0
'		KeuzeInfo(1).Items.Add("A: Produktie/uitgifte")
'		KeuzeInfo(1).Items.Add("B: Boekhouding")
'		KeuzeInfo(1).Items.Add("C: Schade")
'		KeuzeInfo(1).Items.Add("D: Commercieel")
'		KeuzeInfo(1).Items.Add("E: Informatica en Organisatie")
'		KeuzeInfo(1).Items.Add("H: Herverzekering")
'		KeuzeInfo(1).SelectedIndex = 0

'		'KeuzeInfo(2).AddItem "1: Leven"
'		'KeuzeInfo(2).AddItem "2: Ziekte en individuele"
'		'KeuzeInfo(2).AddItem "3: Brand - gewone risiko's"
'		'KeuzeInfo(2).AddItem "4: Burgerlijke aansprakelijkheid"
'		'KeuzeInfo(2).AddItem "5: Auto"
'		'KeuzeInfo(2).AddItem "6: Arbeidsongevallen"
'		'KeuzeInfo(2).AddItem "7: Brand - industriele risiko's"
'		'KeuzeInfo(2).AddItem "8: Transport"
'		'KeuzeInfo(2).AddItem "9: Diverse (Rechtsbijstand e.a.)"
'		'KeuzeInfo(2).AddItem "0: Leningen"
'		'KeuzeInfo(2).ListIndex = 8
'		InstallTak()

'		KeuzeInfo(3).Items.Add("O: Ondernemingen")
'		KeuzeInfo(3).Items.Add("P: Partikulieren")
'		KeuzeInfo(3).Items.Add(" : Onbepaald")
'		KeuzeInfo(3).SelectedIndex = 1

'		KeuzeInfo(4).Items.Add("P: Polis")
'		KeuzeInfo(4).Items.Add("S: Schadegeval")
'		KeuzeInfo(4).Items.Add(" : Andere")
'		KeuzeInfo(4).SelectedIndex = 0
'		KeuzeInfo(4).Enabled = False

'		KeuzeInfo(5).Items.Add("10: Brussel")
'		KeuzeInfo(5).Items.Add("20: Antwerpen")
'		KeuzeInfo(5).Items.Add("23: Turnhout")
'		KeuzeInfo(5).Items.Add("27: Sint-Niklaas")
'		KeuzeInfo(5).Items.Add("28: Mechelen")
'		KeuzeInfo(5).Items.Add("30: Leuven")
'		KeuzeInfo(5).Items.Add("35: Hasselt")
'		KeuzeInfo(5).Items.Add("40: Liege")
'		KeuzeInfo(5).Items.Add("48: Verviers")
'		KeuzeInfo(5).Items.Add("49: Eupen")
'		KeuzeInfo(5).Items.Add("50: Namur")
'		KeuzeInfo(5).Items.Add("60: Charleroi")
'		KeuzeInfo(5).Items.Add("67: Arlon")
'		KeuzeInfo(5).Items.Add("70: Mons")
'		KeuzeInfo(5).Items.Add("75: Tournai")
'		KeuzeInfo(5).Items.Add("80: Brugge")
'		KeuzeInfo(5).Items.Add("84: Oostende")
'		KeuzeInfo(5).Items.Add("85: Kortrijk")
'		KeuzeInfo(5).Items.Add("90: Gent")
'		KeuzeInfo(5).Items.Add("93: Aalst")
'		KeuzeInfo(5).SelectedIndex = 0

'		KeuzeInfo(6).Items.Add("CO: Verzekeringsmaatschappijen")
'		KeuzeInfo(6).Items.Add("EX: Experten")
'		KeuzeInfo(6).Items.Add("IN: Inspecteurs")
'		KeuzeInfo(6).Items.Add("AD: Advokaten")
'		KeuzeInfo(6).SelectedIndex = 0

'		InstallMij(VB.Left(KeuzeInfo(6).Text, 2))
'		MaxLijn79 = 79
'		On Error Resume Next
'		Me.Activate()

'	End Sub

'	Sub InstallTak()

'		Dim Pipo As String
'		Dim Keuze As Short
'		Dim Aantallijnen As Short

'		Pipo = ZoekEnPlaats(KeuzeInfo(2), "NTKB2897", 0, Keuze, AdoGetField(TABLE_CONTRACTS, "#v223 #"))
'		'KeuzeInfo(1).ListIndex = Keuze

'	End Sub


'	Private Sub AS1VrijBericht_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

'		JetTableClose(TABLE_VARIOUS)

'	End Sub

'	Private Sub InstallMij(ByRef VoorLetter As String)
'		Dim T As Short

'		KeuzeInfo(0).Items.Clear()
'		T = -1
'		JetGetOrGreater(TABLE_SUPPLIERS, 0, SetSpacing(VoorLetter, 12))
'		If KTRL Then
'			Beep()
'			Exit Sub
'		Else
'			RecordToField(TABLE_SUPPLIERS)
'		End If
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'		If VB.Left(KEY_BUF(TABLE_SUPPLIERS), 2) <> VoorLetter Then
'			Beep()
'		Else
'			T = T + 1
'			KeuzeInfo(0).Items.Add(Mid(AdoGetField(TABLE_SUPPLIERS, "#A110 #"), 3, 4) & ": " & AdoGetField(TABLE_SUPPLIERS, "#A100 #") & "/" & SetSpacing(AdoGetField(TABLE_SUPPLIERS, "#A400 #"), 8))
'			Do 
'				bNext(TABLE_SUPPLIERS)
'				If KTRL Or VB.Left(KEY_BUF(TABLE_SUPPLIERS), 2) <> VoorLetter Then
'					Exit Do
'				Else
'					RecordToField(TABLE_SUPPLIERS)
'					T = T + 1
'					KeuzeInfo(0).Items.Add(Mid(AdoGetField(TABLE_SUPPLIERS, "#A110 #"), 3, 4) & ": " & AdoGetField(TABLE_SUPPLIERS, "#A100 #") & "/" & SetSpacing(AdoGetField(TABLE_SUPPLIERS, "#A400 #"), 8))
'				End If
'			Loop 
'		End If
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal
'		If KeuzeInfo(0).Items.Count Then
'			KeuzeInfo(0).SelectedIndex = 0
'		End If

'	End Sub

'	'UPGRADE_WARNING: Event KeuzeInfo.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub KeuzeInfo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles KeuzeInfo.SelectedIndexChanged
'		Dim Index As Short = KeuzeInfo.GetIndex(eventSender)
'		Dim T As Short

'		Select Case Index
'			Case 0
'				'MsgBox "nog in te voegen"
'				'If KTRLVerzoek("020", Left(KeuzeInfo(0).Text, 4)) Then
'				'    Wegschrijven.Caption = "AS1.SND bijwerken"
'				'    AfdrukBericht.Enabled = True
'				'    AfdrukBericht.Value = 0
'				'Else
'				Wegschrijven.Text = "Afdrukken"
'				AfdrukBericht.Enabled = False
'				AfdrukBericht.CheckState = System.Windows.Forms.CheckState.Checked
'				'End If
'			Case 4
'				Select Case VB.Left(KeuzeInfo(4).Text, 1)
'					Case "P"
'						CmdZoekPolis.Enabled = True
'						'cmdzoekschade.enabled = False
'					Case "S"
'						CmdZoekPolis.Enabled = False
'						'cmdzoekschade.enabled = true
'					Case Else
'						CmdZoekPolis.Enabled = False
'						'cmdzoekschade.enabled = False
'				End Select

'			Case 6
'				InstallMij(VB.Left(KeuzeInfo(6).Text, 2))
'				Do While KeuzeInfo(1).Items.Count
'					KeuzeInfo(1).Items.RemoveAt(0)
'				Loop 
'				Select Case VB.Left(KeuzeInfo(6).Text, 2)
'					Case "CO"
'						KeuzeInfo(1).Items.Add("A: Produktie/uitgifte")
'						KeuzeInfo(1).Items.Add("B: Boekhouding")
'						KeuzeInfo(1).Items.Add("C: Schade")
'						KeuzeInfo(1).Items.Add("D: Commercieel")
'						KeuzeInfo(1).Items.Add("E: Informatica en Organisatie")
'						KeuzeInfo(1).Items.Add("H: Herverzekering")
'						KeuzeInfo(1).SelectedIndex = 0
'						For T = 2 To 5
'							KeuzeInfo(T).Visible = True
'						Next 
'						Label1(7).Visible = True
'						Label1(11).Visible = True
'						Label1(13).Visible = True
'						AlleMijen.Visible = True
'					Case Else
'						KeuzeInfo(1).Items.Add("D: Diverse")
'						KeuzeInfo(1).Items.Add("A: Aankoopdienst")
'						KeuzeInfo(1).Items.Add("B: Boekhouding")
'						KeuzeInfo(1).Items.Add("C: Commercieel")
'						KeuzeInfo(1).Items.Add("I: Informatica en Organisatie")
'						KeuzeInfo(1).Items.Add("T: Technische dienst")
'						KeuzeInfo(1).Items.Add("V: Verkoopdienst")
'						KeuzeInfo(1).SelectedIndex = 0
'						For T = 2 To 5
'							KeuzeInfo(T).Visible = False
'						Next 
'						Label1(7).Visible = False
'						Label1(11).Visible = False
'						Label1(13).Visible = False
'						AlleMijen.Visible = False
'				End Select
'		End Select

'		Dim OpzoekSleutel As String
'		'check voor faxnummer & email
'		OpzoekSleutel = "27" & VB.Left(KeuzeInfo(2).Text, 3) & VB.Left(KeuzeInfo(0).Text, 4)
'		If Len(OpzoekSleutel) = 9 Then
'			JetGet(TABLE_VARIOUS, 1, OpzoekSleutel)
'			If KTRL Then
'				Me.lFax.Text = ""
'				Me.lMail.Text = ""
'			Else
'				RecordToField(TABLE_VARIOUS)
'				Select Case VB.Left(Me.KeuzeInfo(1).Text, 1)
'					Case "C"
'						Me.lFax.Text = AdoGetField(TABLE_VARIOUS, "ss02") 'Fax Schade
'						Me.lMail.Text = AdoGetField(TABLE_VARIOUS, "s224") 'email Schade
'					Case "P"
'						Me.lFax.Text = AdoGetField(TABLE_VARIOUS, "vs02") 'Fax Productie
'						Me.lMail.Text = AdoGetField(TABLE_VARIOUS, "v224") 'email Productie
'					Case Else
'						Me.lFax.Text = AdoGetField(TABLE_VARIOUS, "vs02") 'Fax Productie
'						Me.lMail.Text = AdoGetField(TABLE_VARIOUS, "v224") 'email Productie
'				End Select
'			End If
'		End If

'	End Sub

'	Private Sub PrintUserDef(ByRef TypeEnTaal As String)
'		Dim B As Short
'		Dim Printer As New Printer
'		Dim Dummy As Short
'		Dim T As Short
'		Dim Tabulatie As Short
'		Dim FlFree As Short
'		Dim Teller As Short

'		Dim ReportText(50) As String
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
'		If Dir(LOCATION_COMPANYDATA & "DDEF" & TypeEnTaal & ".Txt") = "" Then
'			Beep()
'			Exit Sub
'		Else
'			FlFree = FreeFile
'			FileOpen(FlFree, LOCATION_COMPANYDATA & "DDEF" & TypeEnTaal & ".Txt", OpenMode.Input)
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
'				Input(FlFree, ReportText(Teller))
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
'			If ReportText(PsLokatie) <> "" Then
'				Printer.FontName = psFontName(PsLokatie)
'				Printer.FontItalic = psFontItalic(PsLokatie)
'				Printer.FontSize = psFontSize(PsLokatie)
'				Printer.FontBold = psFontBold(PsLokatie)
'				Printer.FontUnderline = psFontUnderLine(PsLokatie)
'				Printer.ForeColor = psColor(PsLokatie)
'			End If
'			Printer.CurrentX = psX(PsLokatie)
'			Printer.CurrentY = psY(PsLokatie)
'			Printer.Write(ReportText(PsLokatie))
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
'		If Dir(LOCATION_COMPANYDATA & "DDEF" & TypeEnTaal & "G.Txt") = "" Then
'		Else
'			FlFree = FreeFile
'			FileOpen(FlFree, LOCATION_COMPANYDATA & "DDEF" & TypeEnTaal & "G.Txt", OpenMode.Input)
'			While Not EOF(FlFree)
'				Input(FlFree, FiguurX)
'				Input(FlFree, FiguurY)
'				Input(FlFree, FiguurName)
'				If ScrLeesTekstBestand(MSG, LOCATION_COMPANYDATA & FiguurName & ".mfd") Then
'					FigBestandsnaam = VB.Left(MSG, InStr(MSG, vbTab) - 1)
'					Mim.imgFiguur.Image = System.Drawing.Image.FromFile(FigBestandsnaam)
'					MSG = Mid(MSG, InStr(MSG, vbTab) + 1)
'					'UPGRADE_WARNING: Couldn't resolve default property of object Hoogte. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					Hoogte = VB.Left(MSG, InStr(MSG, vbTab) - 1)
'					MSG = Mid(MSG, InStr(MSG, vbTab) + 1)
'					'UPGRADE_WARNING: Couldn't resolve default property of object Breedte. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					Breedte = MSG
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

'	Private Sub Schoon()
'		Dim T As Short

'		KeuzeInfo(1).SelectedIndex = 0
'		KeuzeInfo(2).SelectedIndex = 4
'		KeuzeInfo(3).SelectedIndex = 1
'		KeuzeInfo(4).SelectedIndex = 0
'		VrijeTekst.Text = ""
'		For T = 0 To 2
'			TekstInfo(T).Text = ""
'		Next 
'		Me.lFax.Text = "FaxNummer"

'	End Sub

'	Private Sub SchrijfWeg(ByRef RecordLijn As String)

'		On Error GoTo SchrijfWegError

'		PrintLine(FlAsNet, RecordLijn)
'		If Mid(RecordLijn, 50, 1) = "X" Then
'			FileClose(FlAsNet)
'			LogBoekUpdate()
'		End If
'		Exit Sub

'SchrijfWegError: 
'		FlAsNet = FreeFile
'		FileOpen(FlAsNet, LOCATION_ASWEB & "AS1.SND", OpenMode.Append, , OpenShare.LockWrite)
'		Resume 

'	End Sub

'	Private Sub sluiten_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles sluiten.Click

'		If VrijeTekst.Text <> "" Then
'			CTRL_BOX = MsgBox("Aanwezige tekst negeren en venster sluiten.  Bent U zeker ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2)
'			If CTRL_BOX = MsgBoxResult.No Then
'				Exit Sub
'			End If
'		End If
'		Me.Close()

'	End Sub

'	Private Sub VoorVoegsel()

'		A.Value = ""
'		AGENT_NUMBER.Value = "60423"
'		Mid(A.Value, 1, 3) = "AS1" 'constante
'		Mid(A.Value, 16, 1) = "0" 'constante

'		'maar tijdelijk ? op "1" gezet voor onmiddellijke verwerking !!!
'		Mid(A.Value, 16, 1) = "1"
'		'net zoals de IDA ingevuld voor onmiddellijke verwerking !!
'		Mid(A.Value, 4, 12) = VB6.Format(Now, "YYMMDDHHMMSS")

'		Mid(A.Value, 17, 3) = "020" 'vrij bericht
'		Mid(A.Value, 20, 1) = "0" 'vrije inhoud
'		Mid(A.Value, 21, 1) = "1" 'producent
'		Mid(A.Value, 22, 8) = SetSpacing(AGENT_NUMBER.Value, 8) 'ASNET prod.nr.
'		Mid(A.Value, 30, 12) = VB6.Format(Now, "yymmddhhmmss") 'datum
'		Mid(A.Value, 42, 1) = "1" 'gewoon niet vertrouwelijk
'		If VB.Left(KeuzeInfo(0).Text, 4) = "9000" Then
'			Mid(A.Value, 43, 1) = "4" 'bestemmeling=assurnet
'		Else
'			Mid(A.Value, 43, 1) = "2" 'bestemmeling=mij.
'		End If
'		Mid(A.Value, 44, 4) = VB.Left(KeuzeInfo(0).Text, 4) 'BVVO kode
'		Mid(A.Value, 48, 2) = "00" 'volgnummer
'		Mid(A.Value, 50, 1) = "X" 'vervolg tekst
'		Mid(A.Value, 51, 40) = SetSpacing(TekstInfo(0).Text, 40) 'titel
'		Mid(A.Value, 91, 1) = VB.Left(KeuzeInfo(4).Text, 1) 'Referentietype
'		Mid(A.Value, 92, 12) = SetSpacing(TekstInfo(1).Text, 12) 'Referentie nr
'		Mid(A.Value, 104, 1) = VB.Left(KeuzeInfo(1).Text, 1) 'dienstkode
'		Mid(A.Value, 105, 1) = VB.Left(KeuzeInfo(2).Text, 1) 'takkode
'		Mid(A.Value, 106, 1) = VB.Left(KeuzeInfo(3).Text, 1) 'klientkode
'		Mid(A.Value, 107, 10) = SetSpacing(TekstInfo(2).Text, 10) 'bijkomende identificatie mij.
'		Mid(A.Value, 117, 2) = VB.Left(KeuzeInfo(5).Text, 2) 'kode regionale zetel

'		If AlleMijen.CheckState = 1 Then
'			Mid(A.Value, 43, 1) = "3"
'			Mid(A.Value, 44, 4) = "3LR "
'		End If

'	End Sub

'	Private Sub VrijeTekst_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VrijeTekst.Enter

'		Select Case VB.Left(KeuzeInfo(4).Text, 1)
'			Case "P"
'				VB6.SetDefault(CmdZoekPolis, False)
'			Case "S"
'				'cmdzoekschade.Default = False
'		End Select

'	End Sub

'	Private Sub VrijeTekst_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VrijeTekst.Leave

'		Select Case VB.Left(KeuzeInfo(4).Text, 1)
'			Case "P"
'				VB6.SetDefault(CmdZoekPolis, True)
'			Case "S"
'				'cmdzoekschade.Default = true
'		End Select


'	End Sub

'	Private Sub Wegschrijven_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Wegschrijven.Click
'		Dim result As Short
'		Dim TelLijn As Integer
'		Dim positieCRLF As Integer
'		Dim SpatieLijn As Integer
'		Dim Tekst As String
'		Dim TekstLijn As String
'		Dim MSG As String
'		Dim MijKeuze As String

'		If VrijeTekst.Text = "" Then
'			Exit Sub
'		Else
'			VoorVoegsel()
'			TelLijn = 0
'			Tekst = VrijeTekst.Text
'			Do While Tekst <> ""
'				positieCRLF = InStr(Tekst, vbCrLf)
'				If positieCRLF Then
'					TekstLijn = VB.Left(Tekst, positieCRLF - 1)
'					Tekst = VB.Right(Tekst, Len(Tekst) - positieCRLF - 1)
'				Else
'					TekstLijn = Tekst
'					Tekst = ""
'				End If
'				TelLijn = TelLijn + 1
'				If Len(TekstLijn) > MaxLijn79 Then
'					MsgBox("Line " & Str(TelLijn) & " bestaat uit " & Str(Len(TekstLijn)) & " Tekens. (max." & Str(MaxLijn79) & " per lijn toegelaten)")
'					Exit Sub
'				End If
'			Loop 
'		End If

'		If AlleMijen.CheckState Then
'			MijKeuze = "ALLE AS/2 maatschappijen !!!!"
'		Else
'			MijKeuze = KeuzeInfo(0).Text
'		End If

'		If AfdrukBericht.CheckState = 0 Then
'			MSG = "Afdruk controleblad én versturen via AS/2 van " & vbCrLf
'			MSG = MSG & VB6.Format(TelLijn) & " tekstlijnen voor " & MijKeuze & vbCrLf & vbCrLf
'			MSG = MSG & "Bent U zeker ?" & vbCrLf & vbCrLf
'			MSG = MSG & "Kies No om enkel te versturen via ASSURNET !" & vbCrLf
'			MSG = MSG & "Cancel of ESC om terug te keren..."
'			KTRL = MsgBox(MSG, 3, "Vrij bericht versturen en/of afdrukken")
'			Select Case KTRL
'				Case 2
'					Exit Sub
'				Case 7
'				Case Else
'					DrukAf()
'					If KTRL = 2 Then
'						Exit Sub
'					End If
'			End Select

'			TelLijn = 0
'			aa = ""
'			Tekst = VrijeTekst.Text
'			Do While Tekst <> ""
'				If TelLijn = 14 Then
'					Mid(A.Value, 48, 2) = VB6.Format(Val(Mid(A.Value, 48, 2)) + 1, "00")
'					Mid(A.Value, 50, 1) = "S"
'					SchrijfWeg(A.Value & aa)
'					aa = ""
'					TelLijn = 0
'				End If
'				TelLijn = TelLijn + 1
'				positieCRLF = InStr(Tekst, vbCrLf)
'				If positieCRLF Then
'					aa = aa & SetSpacing(VB.Left(Tekst, positieCRLF - 1), 79)
'					Tekst = VB.Right(Tekst, Len(Tekst) - positieCRLF - 1)
'				Else
'					aa = aa & SetSpacing(Tekst, 79)
'					Tekst = ""
'				End If
'			Loop 
'			For SpatieLijn = TelLijn + 1 To 14
'				aa = aa & Space(79)
'			Next 
'			Mid(A.Value, 48, 2) = VB6.Format(Val(Mid(A.Value, 48, 2)) + 1, "00")
'			Mid(A.Value, 50, 1) = "X"
'			SchrijfWeg(A.Value & aa)
'			Schoon()
'		Else
'			MSG = "Afdrukken van " & Str(TelLijn) & " tekstlijnen" & vbCrLf
'			MSG = MSG & "voor " & MijKeuze & vbCrLf & vbCrLf
'			MSG = MSG & "Bent U zeker ?"
'			KTRL = MsgBox(MSG, 292, "Afdruk via PRINTER")
'			If KTRL = MsgBoxResult.Yes Then
'				DrukAf()
'				'MsgBox "asDirectOK hier..."
'				'result = asDirectOK
'				If KTRL = MsgBoxResult.Cancel Then
'					Exit Sub
'				Else
'					result = asDirectOK
'					Schoon()
'				End If
'			End If
'		End If

'	End Sub

'	Private Sub CmdZoekPolis_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdZoekPolis.Click

'		KeuzeInfo(4).SelectedIndex = 0
'		Venster.Hide()
'		Venster.ShowDialog()
'		Me.Activate()
'		TekstInfo(0).Text = RS_MAR(TABLE_CUSTOMERS).Fields("A100").Value & " - " & RS_MAR(TABLE_CUSTOMERS).Fields("A125").Value
'		TekstInfo(1).Text = AdoGetField(TABLE_CONTRACTS, "#A000 #")
'		KeuzeInfo(0).SelectedIndex = 0
'		Do While VB.Left(KeuzeInfo(0).Text, 4) < "9999"
'			If VB.Left(KeuzeInfo(0).Text, 4) = AdoGetField(TABLE_CONTRACTS, "#A010 #") Then
'				Exit Do
'			Else
'				KeuzeInfo(0).SelectedIndex = KeuzeInfo(0).SelectedIndex + 1
'			End If
'		Loop 
'		KeuzeInfo(1).SelectedIndex = 0
'		KeuzeInfo(2).SelectedIndex = 0
'		On Error Resume Next
'		Do While KeuzeInfo(2).SelectedIndex <> KeuzeInfo(2).Items.Count
'			If VB.Left(KeuzeInfo(2).Text, 3) = VB.Left(AdoGetField(TABLE_CONTRACTS, "#v223 #"), 3) Then
'				Exit Do
'			Else
'				KeuzeInfo(2).SelectedIndex = KeuzeInfo(2).SelectedIndex + 1
'				If Err.Number Then Exit Do
'			End If
'		Loop 
'		If VB.Left(KeuzeInfo(2).Text, 3) <> VB.Left(AdoGetField(TABLE_CONTRACTS, "#v223 #"), 3) Then
'			MsgBox("Takkode van deze polis onbekend.  Verbeter a.u.b. !")
'		End If
'		JetGet(TABLE_VARIOUS, 1, SetSpacing("25" & AdoGetField(TABLE_CONTRACTS, "#A010 #") & AdoGetField(TABLE_CONTRACTS, "#A000 #"), 20))
'		If KTRL Then
'			'niks
'		Else
'			RecordToField(TABLE_VARIOUS)
'			Select Case VB.Left(AdoGetField(TABLE_VARIOUS, "#A500 #"), 1)
'				Case "5" 'Voertuigen
'					GRIDTEXT = "Klient vervangt zijn voertuig door een ander met volgende kenmerken :" & vbCrLf & vbCrLf
'					GRIDTEXT = GRIDTEXT & "VOERTUIG Aard : " & fmarBoxText("21", "2", AdoGetField(TABLE_VARIOUS, "#5003 #")) & vbCrLf
'					GRIDTEXT = GRIDTEXT & "Merk : " & AdoGetField(TABLE_VARIOUS, "#500A #") & vbCrLf
'					GRIDTEXT = GRIDTEXT & "Type : " & AdoGetField(TABLE_VARIOUS, "#500B #") & vbCrLf
'					GRIDTEXT = GRIDTEXT & "P.V.G. nummer : " & AdoGetField(TABLE_VARIOUS, "#5004 #") & vbCrLf
'					GRIDTEXT = GRIDTEXT & "Bouwjaar : " & AdoGetField(TABLE_VARIOUS, "#5002 #") & vbCrLf
'					GRIDTEXT = GRIDTEXT & "Plaatnummer : " & AdoGetField(TABLE_VARIOUS, "#5020 #") & vbCrLf
'					GRIDTEXT = GRIDTEXT & "Onderstelnummer : " & AdoGetField(TABLE_VARIOUS, "#5021 #") & vbCrLf
'					GRIDTEXT = GRIDTEXT & "Datum 1e omloop : " & AdoGetField(TABLE_VARIOUS, "#5060 #") & vbCrLf
'					GRIDTEXT = GRIDTEXT & "Vermogen of cylinderinhoud : " & AdoGetField(TABLE_VARIOUS, "#5011 #") & vbCrLf
'					GRIDTEXT = GRIDTEXT & "Eenheid vermogen : " & fmarBoxText("22", "2", AdoGetField(TABLE_VARIOUS, "#5010 #")) & vbCrLf
'					GRIDTEXT = GRIDTEXT & "Brandstof : " & fmarBoxText("23", "2", AdoGetField(TABLE_VARIOUS, "#5015 #")) & vbCrLf & vbCrLf
'					GRIDTEXT = GRIDTEXT & "De aanvraag tot inschrijving is rechtstreeks overgemaakt aan D.I.V."
'					CTRL_BOX = MsgBox(GRIDTEXT, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "In te voegen.  Bent U zeker ?")
'					If CTRL_BOX = MsgBoxResult.Yes Then
'						VrijeTekst.Text = GRIDTEXT
'					End If
'			End Select
'		End If

'	End Sub
'End Class