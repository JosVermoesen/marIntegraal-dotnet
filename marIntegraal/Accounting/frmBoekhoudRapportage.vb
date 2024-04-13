Public Class frmBoekhoudRapportage
    Private Sub frmBoekhoudRapportage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
'Friend Class Rapportage
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Dim ReportText(5) As String 'Koptekstinfo

'	Dim sFile(20) As String
'	Dim smin(10) As String
'	Dim smax(10) As String
'	Dim smg(10) As String
'	Dim stekst(10) As String

'	Dim ichr(10) As Short
'	Dim LFontSize(20) As Single
'	Dim LNumberL(20) As Short
'	Dim FontDefChanged As Short

'	Private Sub Annuleren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Annuleren.Click

'		Me.Close()

'	End Sub

'	Private Sub ButtonGenerateReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Drukken.Click
'		Dim ivbtab As Short
'		Dim tlp As Short
'		Dim alt As Short
'		Dim Tekst As String
'		Dim cflag As Short
'		Dim klt As Short
'		Dim asort As Short
'		Dim T As Short
'		Dim Printer As New Printer
'		Dim FlTemp As Short
'		Dim ideler As Short
'		Dim lijntel As Short

'		Dim dbdhbj As Decimal
'		Dim dbdvbj As Decimal
'		Dim dTOT As Decimal
'		Dim dvtot As Decimal

'		'nieuw rekenkundige controle
'		Dim rTotaal1 As Decimal
'		Dim rTotaal2 As Decimal
'		'einde

'		Dim sminsl As New VB6.FixedLengthString(7)
'		Dim smaxsl As New VB6.FixedLengthString(7)

'		Dim sbd As String
'		Dim alijn As Short
'		Dim Scode As String
'		Dim apos As Short

'		LabelMemo.Text = ""
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

'		On Error GoTo PrtHandler2

'		PageCounter = 0
'		Printer = Printers(LijstPrinterNr)
'		On Error Resume Next
'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		Printer.PaperBin = LaadTekst(My.Application.Info.Title, "LIJSTPRINTER")
'		If Printer.Width > 12000 Then
'			Printer.FontSize = 10
'			Printer.FontName = "Courier New"
'			Printer.Print(" ")
'			Printer.FontSize = 10
'		Else
'			Printer.FontSize = 7.2
'			Printer.FontName = "Courier New"
'			Printer.Print(" ")
'			Printer.FontSize = 7.2
'			Printer.FontBold = True
'		End If

'		FlTemp = FreeFile
'		FileOpen(FlTemp, ProgramLocation & "Def\" & sFile(Keuzelijst.SelectedIndex), OpenMode.Input)
'		Input(FlTemp, smg(9))
'		Input(FlTemp, smg(2))
'		Input(FlTemp, smg(3))
'		Input(FlTemp, smg(4))
'		Input(FlTemp, smg(5))
'		Input(FlTemp, ideler)

'		lijntel = 6
'		If ideler = 1 Then
'			ideler = 1000
'		Else
'			ideler = 1
'		End If

'		ReportText(2) = "Rapportage " & UCase(Mid(Mim.Text, InStr(Mim.Text, "[")))
'		ReportText(0) = TekstLijn(1).Text
'		ReportText(3) = smg(9) & " Boekjaar " & BJPERDAT.Boekjaar.Text

'		While Not EOF(FlTemp)
'			lijntel = lijntel + 1
'			Input(FlTemp, sbd)
'			Input(FlTemp, alijn)
'			Input(FlTemp, Scode)
'			Input(FlTemp, apos)
'			If InStr("DCXYmheltr", sbd) = 0 Then
'				'nieuw rekenkundige controle
'				MsgBox("Rapportagedefinitiebestand defekt of beschadigd.")
'				FileClose(FlTemp)
'				Printer.NewPage()
'				Printer.EndDoc()
'				Exit Sub
'			End If

'			For T = 0 To alijn - 1
'				lijntel = lijntel + 1
'				Input(FlTemp, stekst(T))
'				SnelHelpPrint("LN:" & Dec(lijntel, "###") & "  " & stekst(T), blLogging)
'			Next T

'			lijntel = lijntel + 1
'			Input(FlTemp, asort)
'			For T = 1 To asort
'				lijntel = lijntel + 1
'				Input(FlTemp, smin(T))
'				Input(FlTemp, smax(T))
'			Next T

'			If InStr("mhelt", sbd) Then
'				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'				GoSub Label1000
'			ElseIf InStr("r", sbd) Then 
'				'nieuw rekenkundige controle
'				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'				GoSub LabelRekening
'			Else
'				For klt = 1 To asort - 1
'					cflag = 1
'					sminsl.Value = smin(klt)
'					smaxsl.Value = smax(klt)
'					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'					GoSub Label1000
'				Next klt
'				sminsl.Value = smin(asort)
'				smaxsl.Value = smax(asort)
'				cflag = 0
'				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'				GoSub Label1000
'			End If
'		End While
'		FileClose(FlTemp)
'		Printer.EndDoc()
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal
'		Exit Sub

'		'nieuw rekenkundige controle
'LabelRekening: 
'		rTotaal1 = 0
'		rTotaal2 = 0
'		For klt = 1 To asort
'			cflag = 1
'			dTOT = 0 : dvtot = 0
'			sminsl.Value = Mid(smin(klt), 2, 7)
'			smaxsl.Value = Mid(smin(klt), 10, 7)
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub Label1000
'			If VB.Left(smin(klt), 1) = "+" Then
'				rTotaal1 = rTotaal1 + dTOT
'			Else
'				'Stop
'			End If
'			dTOT = 0 : dvtot = 0
'			sminsl.Value = Mid(smax(klt), 2, 7)
'			smaxsl.Value = Mid(smax(klt), 10, 7)
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub Label1000
'			If VB.Left(smax(klt), 1) = "+" Then
'				rTotaal2 = rTotaal2 + dTOT
'			Else
'				'Stop
'			End If
'		Next klt
'		Select Case VB.Left(Scode, 2)
'			Case "? "
'				If rTotaal1 = 0 Or rTotaal2 = 0 Then
'				Else
'					Msg = Mid(Mim.SnelHelp.Text, 9) & vbCrLf & vbCrLf
'					Msg = Msg & VB6.Format(rTotaal1, MaskEURBH) & " ? " & VB6.Format(rTotaal2, MaskEURBH)
'					MsgBox(Msg, 0, "Kontroleer a.u.b. !")
'				End If
'			Case Else
'				'Stop
'		End Select
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'Label1000: 
'		Select Case sbd
'			Case "m"
'				Tekst = ""
'				For T = 0 To alijn
'					Tekst = Tekst & stekst(T) & vbCrLf
'				Next 
'				LabelMemo.Text = Tekst
'				LabelMemo.Refresh()
'				GoTo Label1060

'			Case "h"
'				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'				GoSub Label2000
'				GoTo Label1060

'			Case "e"
'				GoTo Label2200

'			Case "t"
'				GoTo Label2300

'			Case "l"
'				GoTo Label2400
'			Case Else
'		End Select

'Vooraan: 
'		JetGetFirst(TableOfLedgerAccounts, 0)
'		JetGetOrGreater(TableOfLedgerAccounts, 0, sminsl.Value)
'		If Ktrl Then
'			GoTo PrintAf
'		Else
'			If SetSpacing(KeyBuf(TableOfLedgerAccounts), 7) > smaxsl.Value Then
'				GoTo PrintAf
'			Else
'				RecordToField(TableOfLedgerAccounts)
'				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'				GoSub TelOp
'			End If
'		End If

'		Do 
'			bNext(TableOfLedgerAccounts)
'			If Ktrl Then
'				GoTo PrintAf
'			Else
'				If SetSpacing(KeyBuf(TableOfLedgerAccounts), 7) > smaxsl.Value Then
'					GoTo PrintAf
'				Else
'					RecordToField(TableOfLedgerAccounts)
'					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'					GoSub TelOp
'				End If
'			End If
'		Loop 
'		MsgBox("stop na DO-LOOP")

'TelOp: 
'		If bhEuro Then
'			dbdhbj = Val(AdoGetField(TableOfLedgerAccounts, "#e" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex, "000") & " #"))
'			dbdvbj = Val(AdoGetField(TableOfLedgerAccounts, "#e" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex + 1, "000") & " #"))
'		Else
'			dbdhbj = Val(AdoGetField(TableOfLedgerAccounts, "#v" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex, "000") & " #"))
'			dbdvbj = Val(AdoGetField(TableOfLedgerAccounts, "#v" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex + 1, "000") & " #"))
'		End If
'		dTOT = dTOT + dbdhbj
'		dvtot = dvtot + dbdvbj
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'PrintAf: 
'		alt = 0
'		While stekst(alt) <> ""
'			Printer.Write(TAB(1), stekst(alt) & " " & Chr(ichr(5)))
'			If stekst(alt + 1) <> "" Then
'				Printer.Print(Space(7) & Chr(ichr(5)) & Space(23) & Chr(ichr(5)) & Space(24) & Chr(ichr(5)))
'			End If
'			alt = alt + 1
'		End While

'		If cflag = 1 Then
'			GoTo Label1060
'		ElseIf sbd = "C" Then 
'			dTOT = -dTOT
'			dvtot = -dvtot
'		End If

'		If sbd = "X" Then
'			If dvtot > 0 Then
'				dvtot = 0
'			Else
'				dvtot = System.Math.Abs(dvtot)
'			End If
'		End If

'		If sbd = "Y" Then
'			If dvtot < 0 Then
'				dvtot = 0
'			End If
'		End If

'		If sbd = "X" Then
'			If dTOT > 0 Then
'				dTOT = 0
'			Else
'				dTOT = System.Math.Abs(dTOT)
'			End If
'		End If

'		If sbd = "Y" Then
'			If dTOT < 0 Then
'				dTOT = 0
'			End If
'		End If

'		Printer.Write(Scode & Chr(ichr(5)), TAB(72 + apos - 2), Dec(dTOT / ideler, MaskEURBH))
'		Printer.Write(TAB(93), Chr(ichr(5)), TAB(95 + apos), Dec(dvtot / ideler, MaskEURBH))
'		Printer.Print(TAB(117), " " & Chr(ichr(5)))
'		dTOT = 0
'		dvtot = 0

'Label1060: 
'		For tlp = 0 To 5
'			stekst(tlp) = ""
'		Next tlp
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'Label2000: 
'		VpePrintHeader()
'		Printer.Print(New String(Chr(ichr(4)), Len(stekst(0)) + 1) & Chr(ivbtab) & New String(Chr(ichr(4)), 7) & Chr(ivbtab) & New String(Chr(ichr(4)), 23) & Chr(ivbtab) & New String(Chr(ichr(4)), 24) & Chr(ichr(1)))
'		Printer.Print(Space(Len(stekst(0)) + 1) & Chr(ichr(5)) & Space(7) & Chr(ichr(5)) & smg(2) & Chr(ichr(5)) & smg(3) & Chr(ichr(5)))
'		Printer.Print(Space(Len(stekst(0)) + 1) & Chr(ichr(5)) & smg(4) & Chr(ichr(6)) & New String(Chr(ichr(4)), 23) & Chr(ichr(8)) & New String(Chr(ichr(4)), 24) & Chr(ichr(7)))
'		Printer.Print(Space(Len(stekst(0)) + 1) & Chr(ichr(5)) & Space(7) & Chr(ichr(5)) & smg(5) & Chr(ichr(5)))
'		Printer.Print(Space(Len(stekst(0)) + 1) & Chr(ichr(6)) & New String(Chr(ichr(4)), 7) & Chr(ichr(10)) & New String(Chr(ichr(4)), 23) & Chr(ivbtab) & New String(Chr(ichr(4)), 24) & Chr(ichr(7)))
'		alt = 0
'		While stekst(alt) <> ""
'			Printer.Print(TAB(1), stekst(alt) & " " & Chr(ichr(5)) & Space(7) & Chr(ichr(5)) & Space(23) & Chr(ichr(5)) & Space(24) & Chr(ichr(5)))
'			alt = alt + 1
'		End While
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'Label2200: 
'		Printer.Write(Space(60) & Chr(ichr(2)) & New String(Chr(ichr(4)), 7) & Chr(ichr(8)) & New String(Chr(ichr(4)), 23) & Chr(ichr(8)) & New String(Chr(ichr(4)), 24) & Chr(ichr(3)))
'		Printer.NewPage()
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'Label2300: 
'		Printer.Print(Space(60) & Chr(ichr(6)) & New String(Chr(ichr(4)), 7) & Chr(ichr(10)) & New String(Chr(ichr(4)), 23) & Chr(ichr(10)) & New String(Chr(ichr(4)), 24) & Chr(ichr(7)))
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'Label2400: 
'		Printer.Print(Space(60) & Chr(ichr(5)) & Space(7) & Chr(ichr(5)) & Space(23) & Chr(ichr(5)) & Space(24) & Chr(ichr(5)))
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'PrtHandler2: 
'		MsgBox("Kontroleer de printer.")
'		Resume 

'	End Sub

'	Private Sub Rapportage_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

'		If Not Toegankelijk(Me) Then
'			Me.Close()
'			Exit Sub
'		End If

'		Dim Bedrijf As String
'		Dim sInfo As String
'		Dim FlTemp As Short
'		Dim i As Short
'		Dim T As Short
'		Dim TempbModus As Short

'		SetBounds(VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Width)) \ 2), VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Height)) \ 2), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)

'		TekstLijn(1).Text = MimGlobalDate.Value
'		Text = Text & " " & BJPERDAT.Boekjaar.Text

'		i = 0
'		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Bedrijf = Dir(ProgramLocation & "Def\" & "99MAR*.SRN")
'		If Bedrijf = Space(Len(Bedrijf)) Then
'			Drukken.Enabled = False
'		Else
'			Do While Bedrijf <> ""
'				FlTemp = FreeFile
'				FileOpen(FlTemp, ProgramLocation & "Def\" & Bedrijf, OpenMode.Input)
'				Input(FlTemp, sInfo)
'				FileClose(FlTemp)
'				sInfo = UCase(VB.Left(sInfo, 1)) & LCase(VB.Right(sInfo, Len(sInfo) - 1))
'				sFile(i) = Bedrijf
'				Keuzelijst.Items.Add(sInfo)
'				i = i + 1
'				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'				Bedrijf = Dir()
'			Loop 
'			If Keuzelijst.Items.Count Then
'				Keuzelijst.SelectedIndex = i - 1
'			End If
'		End If

'		For i = 0 To 10
'			ichr(i) = 124
'		Next 

'	End Sub

'	'UPGRADE_WARNING: Event Keuzelijst.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub Keuzelijst_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Keuzelijst.SelectedIndexChanged

'		LabelMemo.Text = ""

'	End Sub

'	Private Sub VpePrintHeader()
'		Dim Printer As New Printer
'		Dim T As Short

'		On Error GoTo PrtHandler1

'		If usrLicentieInfo <> "" Then
'			Printer.CurrentX = 50
'			Printer.CurrentY = 50
'			Printer.Write(usrLicentieInfo)
'		End If
'		PageCounter = PageCounter + 1
'		Printer.CurrentY = 400
'		Printer.Write(TAB(1), ReportText(2), TAB(108), "Pagina : " & Dec(PageCounter, "##########"))
'		Printer.Write(TAB(108), "Datum  : " & ReportText(0) & vbCrLf & vbCrLf)
'		Printer.Write(TAB(1), UCase(ReportText(3)))

'		Printer.Write(vbCrLf & FullLine.Value & vbCrLf & vbCrLf)
'		Exit Sub

'PrtHandler1: 
'		MsgBox("Kontroleer de printer.")
'		Resume 

'	End Sub

'	Private Sub TekstLijn_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstLijn.Leave
'		Dim Index As Short = TekstLijn.GetIndex(eventSender)

'		Select Case Index
'			Case 1
'				If DateWrongFormat(TekstLijn(1).Text) Then
'					Beep()
'					TekstLijn(1).Text = MimGlobalDate.Value
'					TekstLijn(1).Focus()
'				End If
'		End Select

'	End Sub
'End Class