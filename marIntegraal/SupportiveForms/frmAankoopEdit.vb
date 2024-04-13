Public Class frmAankoopEdit
    Private Sub frmAankoopEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class Wijzigen
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Dim CTRLFlag As Boolean

'	Dim VeldRekening As New VB6.FixedLengthString(7)
'	Dim VeldNaam As New VB6.FixedLengthString(40)
'	Dim VeldBedrag As New VB6.FixedLengthString(12)
'	Dim VeldAantal As New VB6.FixedLengthString(10)
'	Dim VeldProdukt As New VB6.FixedLengthString(13)
'	Dim ProduktNaam As New VB6.FixedLengthString(40)
'	Dim iTabIndex As Short

'	Dim pctFilter As String

'	Private Sub Annuleren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Annuleren.Click

'		GridText = ""
'		Me.Close()

'	End Sub

'	Private Sub CmdDommeKey_Click()

'		On Error Resume Next

'		'    If iTabIndex = 2 Then
'		'        Ok.SetFocus
'		'        Exit Sub
'		'    End If
'		'    Err = 0
'		'    On Local Error Resume Next
'		'    TekstInfo(iTabIndex + 1).SetFocus
'		'    If Err Then
'		'        iTabIndex = iTabIndex + 1
'		'        Err = 0
'		'        On Local Error Resume Next
'		'        TekstInfo(iTabIndex + 1).SetFocus
'		'        If Err Then
'		'            Ok.SetFocus
'		'        End If
'		'    End If

'	End Sub


'	'UPGRADE_WARNING: Event cbEenheidsType.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub cbEenheidsType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbEenheidsType.SelectedIndexChanged

'		On Error Resume Next
'		TekstInfo(5).Focus()

'	End Sub

'	Private Sub cbFiche_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbFiche.Click

'		Dim dummykey As String

'		dummykey = TekstInfo(3).Text
'		JetGet(TableOfProductsAndServices, 0, SetSpacing(TekstInfo(3).Text, 13))
'		frmProduktFiche.Close()
'		'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
'		Load(frmProduktFiche)
'		'UPGRADE_NOTE: The Following line was commented to give the same effect as VB6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="1C44C272-DA6E-4A2A-BDC5-9A27F0D03D31"'
'		'frmProduktFiche.FormBorderStyle = 0
'		frmProduktFiche.TxtInfo(0).Text = TekstInfo(3).Text
'		frmProduktFiche.ShowDialog()
'		TekstInfo(3).Text = Trim(dummykey)
'		TekstInfo(3).Focus()

'	End Sub

'	Public Sub Filter_Renamed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Filter_Renamed.Click
'		Dim Index As Short = Filter_Renamed.GetIndex(eventSender)

'		Me.Filter_Renamed(0).Checked = Not Me.Filter_Renamed(0).Checked
'		If Me.Filter_Renamed(0).Checked = True Then
'			Me.TekstInfo(6).Visible = True
'			Me.TekstInfo(6).TabIndex = 9
'			Me.TekstInfo(2).Enabled = False
'			pctFilter = InputBox("Commissie Filter (vb. 25.75)", "Filter aan", "0")
'		Else
'			Me.TekstInfo(6).Visible = False
'			Me.TekstInfo(2).Enabled = True
'			Me.TekstInfo(6).TabIndex = 9
'			pctFilter = ""
'		End If
'		BeWaarTekst("Aankoopverrichting", "FilterToggle", Str(Me.Filter_Renamed(0).Checked))
'		BeWaarTekst("Aankoopverrichting", "FilterPCT", pctFilter)
'		Me.lPctFilter.Text = pctFilter

'	End Sub

'	Private Sub Wijzigen_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
'		Dim T As Short
'		Dim X As Short

'		On Error Resume Next
'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(Aankoopverrichting, FilterToggle). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		Me.Filter_Renamed(0).Checked = LaadTekst("Aankoopverrichting", "FilterToggle")
'		On Error Resume Next
'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		pctFilter = LaadTekst("Aankoopverrichting", "FilterPCT")
'		If Me.Filter_Renamed(0).Checked = True Then
'			Me.TekstInfo(6).Visible = True
'			Me.TekstInfo(6).TabIndex = 9
'			Me.TekstInfo(2).Enabled = False
'		Else
'			Me.TekstInfo(6).Visible = False
'			Me.TekstInfo(2).Enabled = True
'			Me.TekstInfo(6).TabIndex = 9
'		End If
'		Me.lPctFilter.Text = pctFilter

'		If DirekteAankoop.StockBeheer.CheckState Then
'			Labelstock(0).Visible = True
'			cbEenheidsType.SelectedIndex = 0
'			cbEenheidsType.Visible = True
'			'Labelstock(1).Visible = True
'			For T = 3 To 5
'				TekstInfo(T).Visible = True
'			Next 
'		End If
'		T = 0
'		If GridText <> "" Then
'			Do While GridText <> ""
'				TekstInfo(T).Text = VB.Left(GridText, InStr(GridText, Chr(124)) - 1)
'				GridText = VB.Right(GridText, Len(GridText) - (Len(TekstInfo(T).Text) + 1))
'				T = T + 1
'			Loop 


'			If InStr(DirekteAankoop.cmdSwitch.Text, "EUR") Then
'				'OvergangsToggle is EUR
'				If bhEuro Then
'					'Toggle EUR en boekhouding EUR, geen probleem
'					TekstInfo(2).Text = Dec(Val(TekstInfo(2).Text), MaskEURBH)
'				Else
'					'Boekhouding nog in BEF mét overgangstoggle !!
'					'kan dus niet anders dan 1/ Euro zijn...
'					TekstInfo(2).Text = Dec(Val(TekstInfo(2).Text), MaskEURBH)
'				End If
'			Else
'				'Toggle is BEF
'				If bhEuro Then
'					'Boekhouding in EUR
'					'Boekhouding in BEF, toggle in BEF, alles zoals vroeger
'					If dMuntL = System.Math.Round(1 / Euro, 8) Then
'						'boekhouding in EUR, en fiche in BEF
'						'niets wijzigen
'					ElseIf dMuntL <> 1 Then 
'						'Boekhouding in EUR, factuur in munt buiten BEF of EUR
'						'MsgBox "andere munt stop"
'					Else
'						TekstInfo(2).Text = Dec(Val(TekstInfo(2).Text) / dMuntL, MaskEURBH)
'					End If
'				Else
'					'Boekhouding in BEF, toggle in BEF, alles zoals vroeger
'					If dMuntL <> 1 Then
'						TekstInfo(2).Text = Dec(Val(TekstInfo(2).Text) / dMuntL, MaskEURBH)
'					Else
'						'Boekhouding in BEF, factuur in BEF, toggle in BEF
'						'Niets te wijzigen dus
'					End If
'				End If
'			End If

'			TekstInfo(5).Text = Dec(Val(TekstInfo(5).Text), "#####0.000")
'			If TekstInfo(0).Text = Space(Len(TekstInfo(0).Text)) Then
'			Else
'				JetGet(TableOfLedgerAccounts, 0, SetSpacing(TekstInfo(0).Text, 7))
'				If Ktrl Then
'					MsgBox("OnlogicaStop")
'				Else
'					RecordToField(TableOfLedgerAccounts)
'					TekstInfo(0).Text = AdoGetField(TableOfLedgerAccounts, "#v019 #")
'					TekstInfo(1).Text = AdoGetField(TableOfLedgerAccounts, "#v020 #")
'					TekstInfo(2).TabIndex = 0
'				End If
'			End If
'		Else
'			Exit Sub
'		End If

'	End Sub

'	Private Sub Ok_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Ok.Click
'		Dim HetBedrag As Decimal

'		HetBedrag = Val(TekstInfo(2).Text)

'		If Val(TekstInfo(2).Text) = 0 Then
'			Beep()
'		ElseIf TekstInfo(1).Text = "" Then 
'			Beep()
'		Else
'			VeldRekening.Value = TekstInfo(0).Text
'			VeldNaam.Value = TekstInfo(1).Text

'			If InStr(DirekteAankoop.cmdSwitch.Text, "EUR") Then
'				'ingave in EUR
'				If bhEuro Then
'					VeldBedrag.Value = Dec(HetBedrag, MaskEURBH)
'				Else
'					'Boekhouding nog in BEF mét overgangstoggle !!
'					'kan dus niet anders dan 1/ Euro zijn...
'					'moet dus afgebleven worden
'					VeldBedrag.Value = Dec(HetBedrag, MaskEURBH)
'				End If
'			Else
'				'ingave in BEF
'				If bhEuro Then
'					'Boekhouding in EUR
'					If System.Math.Round(dMuntL, 8) = System.Math.Round(1 / Euro, 8) Then
'						'toggle in BEF dus van BEF afblijven
'						VeldBedrag.Value = Dec(System.Math.Round(HetBedrag), MaskEURBH)
'					ElseIf dMuntL <> 1 Then 
'						'een echte andere munt dan BEF of EUR
'						VeldBedrag.Value = Dec(System.Math.Round(HetBedrag * dMuntL), MaskEURBH)
'						MsgBox("Stop")
'					Else
'						MsgBox("onlogica stop")
'					End If
'				Else
'					'Boekhouding in BEF, toggle in BEF of andere MUNT zoals vroeger
'					VeldBedrag.Value = Dec(System.Math.Round(HetBedrag * dMuntL), MaskEURBH)
'				End If
'			End If


'			GridText = VeldRekening.Value & Chr(124) & VeldNaam.Value & Chr(124) & VeldBedrag.Value & Chr(124)
'			If TekstInfo(3).Visible Then
'				If TekstInfo(4).Text = "" Then
'					Beep()
'				ElseIf Val(TekstInfo(5).Text) = 0 Then 
'					Beep()
'				Else
'					VeldProdukt.Value = TekstInfo(3).Text
'					VeldAantal.Value = Dec(Val(TekstInfo(5).Text), "#####0.000")
'					ProduktNaam.Value = TekstInfo(4).Text
'					GridText = GridText & VeldProdukt.Value & Chr(124) & ProduktNaam.Value & Chr(124) & VeldAantal.Value & Chr(124)
'					Me.Close()
'				End If
'			Else
'				Me.Close()
'			End If
'		End If

'	End Sub

'	'UPGRADE_WARNING: Event TekstInfo.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub TekstInfo_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.TextChanged
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		Dim bedragA As Double
'		Dim bedragB As Double

'		Select Case Index
'			Case 4
'				Me.cbFiche.Visible = True
'			Case 6
'				bedragA = Val(TekstInfo(6).Text)
'				bedragB = bedragA - (bedragA * CDbl(pctFilter) / 100)
'				TekstInfo(2).Text = Str(bedragB)

'		End Select

'	End Sub

'	Private Sub TekstInfo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.Enter
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		TekstInfo(Index).SelectionLength = Len(TekstInfo(Index).Text)
'		iTabIndex = Index
'		If Index = 0 Then VB6.SetDefault(Ok, False) : SnelHelpPrint("[Ctrl] voor geïndexeerd zoeken", blLogging)
'		CTRLFlag = False

'	End Sub


'	Private Sub TekstInfo_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles TekstInfo.KeyDown
'		Dim KeyCode As Short = eventArgs.KeyCode
'		Dim Shift As Short = eventArgs.KeyData \ &H10000
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		If KeyCode = 17 Then CTRLFlag = True
'		Select Case KeyCode
'			Case 9, 13

'				If Index = 0 Or Index = 5 Then
'					If TekstInfo(2).Enabled = True Then
'						TekstInfo(2).Focus()
'					Else
'						TekstInfo(6).Focus()
'					End If
'				End If
'				If Index = 2 Or Index = 6 Then Ok_Click(Ok, New System.EventArgs())
'				If Index = 3 Then TekstInfo(5).Focus()


'			Case 17
'				Select Case Index
'					Case 0
'						SharedFl = TableOfLedgerAccounts
'						aIndex = 0
'						GridText = TekstInfo(0).Text
'						SqlSearch.ShowDialog()
'						If Ktrl Then
'							TekstInfo(1).Text = ""
'							Ok.Enabled = False
'						Else
'							RecordToField(TableOfLedgerAccounts)
'							TekstInfo(0).Text = AdoGetField(TableOfLedgerAccounts, "#v019 #")
'							TekstInfo(1).Text = AdoGetField(TableOfLedgerAccounts, "#v020 #")
'							Ok.Enabled = True
'							TekstInfo(2).Focus()
'						End If
'					Case 3
'						SharedFl = TableOfProductsAndServices
'						aIndex = 0
'						GridText = TekstInfo(3).Text
'						SqlSearch.ShowDialog()
'						If Ktrl Then
'							TekstInfo(4).Text = ""
'							Ok.Enabled = False
'						Else
'							RecordToField(TableOfProductsAndServices)
'							TekstInfo(3).Text = AdoGetField(TableOfProductsAndServices, "#v102 #")
'							TekstInfo(4).Text = AdoGetField(TableOfProductsAndServices, "#v105 #")
'							JetGet(TableOfLedgerAccounts, 0, SetSpacing(AdoGetField(TableOfProductsAndServices, "#v116 #"), 7))
'							If Ktrl Then
'								TekstInfo(1).Text = ""
'								Ok.Enabled = False
'							Else
'								RecordToField(TableOfLedgerAccounts)
'								TekstInfo(0).Text = AdoGetField(TableOfLedgerAccounts, "#v019 #")
'								TekstInfo(1).Text = AdoGetField(TableOfLedgerAccounts, "#v020 #")
'								Ok.Enabled = True
'							End If
'						End If
'				End Select
'		End Select

'	End Sub

'	Private Sub TekstInfo_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles TekstInfo.KeyUp
'		Dim KeyCode As Short = eventArgs.KeyCode
'		Dim Shift As Short = eventArgs.KeyData \ &H10000
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		Dim RekenHier As Object

'		If Index = 2 Then
'			Select Case KeyCode
'				Case 106, 107, 109, 111
'					If Len(TekstInfo(Index).Text) = 1 Then
'						Exit Sub
'					End If
'					'UPGRADE_WARNING: Couldn't resolve default property of object EenLijnRekenen(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					'UPGRADE_WARNING: Couldn't resolve default property of object RekenHier. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					RekenHier = EenLijnRekenen(TekstInfo(2).Text)
'					'UPGRADE_WARNING: Couldn't resolve default property of object RekenHier. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					If RekenHier Then
'						'UPGRADE_WARNING: Couldn't resolve default property of object RekenHier. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'						TekstInfo(2).Text = Str(System.Math.Round(RekenHier, 2))
'					End If
'			End Select
'		End If

'	End Sub

'	Private Sub TekstInfo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.Leave
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		Dim tmpAantal As Single
'		Select Case Index
'			Case 0
'				If CTRLFlag = True Then Exit Sub
'				JetGet(TableOfLedgerAccounts, 0, SetSpacing(TekstInfo(0).Text, 7))
'				If Ktrl Then
'					TekstInfo(0).Text = ""
'					TekstInfo(1).Text = ""
'				Else
'					RecordToField(TableOfLedgerAccounts)
'					TekstInfo(0).Text = AdoGetField(TableOfLedgerAccounts, "#v019 #")
'					TekstInfo(1).Text = AdoGetField(TableOfLedgerAccounts, "#v020 #")
'				End If
'			Case 3
'				If CTRLFlag = True Then Exit Sub
'				JetGet(TableOfProductsAndServices, 0, SetSpacing(TekstInfo(3).Text, 13))
'				If Ktrl Then
'					KtrlBox = MsgBox("Code " & TekstInfo(3).Text & " bestaat niet." & vbCr & "Nieuw produkt aanmaken", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2)
'					If KtrlBox = MsgBoxResult.No Then
'						Annuleren_Click(Annuleren, New System.EventArgs())
'						Exit Sub
'					Else
'						frmProduktFiche.Close()
'						'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
'						Load(frmProduktFiche)
'						'UPGRADE_NOTE: The Following line was commented to give the same effect as VB6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="1C44C272-DA6E-4A2A-BDC5-9A27F0D03D31"'
'						'frmProduktFiche.FormBorderStyle = 0
'						frmProduktFiche.TxtInfo(0).Text = TekstInfo(3).Text
'						frmProduktFiche.ShowDialog()
'						TekstInfo(3).Focus()
'					End If
'				Else
'					RecordToField(TableOfProductsAndServices)
'					TekstInfo(3).Text = AdoGetField(TableOfProductsAndServices, "#v102 #")
'					TekstInfo(4).Text = AdoGetField(TableOfProductsAndServices, "#v105 #")
'					JetGet(TableOfLedgerAccounts, 0, SetSpacing(AdoGetField(TableOfProductsAndServices, "#v116 #"), 7))
'					If Ktrl Then
'						TekstInfo(1).Text = ""
'						Ok.Enabled = False
'					Else
'						RecordToField(TableOfLedgerAccounts)
'						TekstInfo(0).Text = AdoGetField(TableOfLedgerAccounts, "#v019 #")
'						TekstInfo(1).Text = AdoGetField(TableOfLedgerAccounts, "#v020 #")
'						Ok.Enabled = True
'					End If
'				End If
'			Case 5

'				On Error Resume Next
'				If VB.Left(cbEenheidsType.Text, 1) = "1" Then
'					tmpAantal = CSng(TekstInfo(5).Text)
'				ElseIf VB.Left(cbEenheidsType.Text, 1) = "2" Then 
'					tmpAantal = Val(TekstInfo(5).Text) * Val(AdoGetField(TableOfProductsAndServices, "#v107 #"))
'					TekstInfo(5).Text = Trim(Dec(tmpAantal, "####.000"))
'					cbEenheidsType.SelectedIndex = 0
'				Else
'					MsgBox("stop")
'				End If

'				If InStr(DirekteAankoop.cmdSwitch.Text, "EUR") Then
'					TekstInfo(2).Text = Dec(System.Math.Round(Val(TekstInfo(5).Text) * Val(AdoGetField(TableOfProductsAndServices, "#e113 #")), 2), MaskEURBH)
'				Else
'					TekstInfo(2).Text = Dec(System.Math.Round(Val(TekstInfo(5).Text) * Val(AdoGetField(TableOfProductsAndServices, "#v113 #")), 2), MaskEURBH)
'				End If
'				'UPGRADE_ISSUE: DoEvents does not return a value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8D115264-E27F-4472-A684-865A00B5E826"'
'				XDoEvents = System.Windows.Forms.Application.DoEvents()
'				TekstInfo(2).Focus()
'		End Select
'		CTRLFlag = False

'	End Sub
'End Class