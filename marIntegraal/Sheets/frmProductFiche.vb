Imports System.ComponentModel

Public Class frmProductFiche
    Private Sub CmdSluiten_Click(sender As Object, e As EventArgs)
        Mim.ProductSheetMenuItem.Enabled = True
        Close()
    End Sub

    Private Sub frmProductFiche_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close

    End Sub

    Private Sub frmProductFiche_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Mim.ProductSheetMenuItem.Enabled=True 

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class frmProduktFiche
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Dim FicheIsNieuw As Boolean
'	Dim IsGewijzigd As Boolean
'	Dim iTabIndex As Short

'	Dim TempoMilieu As String

'	Dim rsGroepenHier As ADODB.Recordset
'	Dim rsSQLQuery As ADODB.Recordset

'	Dim rsJourQuery As ADODB.Recordset

'	Sub RecordVullen()
'		Dim TempoTel As Short
'		Dim vBibDef As String

'		Err.Clear()
'		TempoTel = 0
'		On Error Resume Next
'		Do 
'			If TxtInfo(TempoTel).Tag = "" Then
'			Else
'				If InStr(TxtInfo(TempoTel).Tag, "|") <> 0 Then
'					If InStr(cmdSwitch.Text, "BEF") Then
'						vBibDef = VB.Left(TxtInfo(TempoTel).Tag, 4)
'						AdoInsertToRecord(TableOfProductsAndServices, Dec(Val(TxtInfo(TempoTel).Text) / Euro, MaskEURX), vBibDef)
'						vBibDef = VB.Right(TxtInfo(TempoTel).Tag, 4)
'					Else
'						vBibDef = VB.Right(TxtInfo(TempoTel).Tag, 4)
'						AdoInsertToRecord(TableOfProductsAndServices, Dec(Val(TxtInfo(TempoTel).Text) * Euro, MaskEURX), vBibDef)
'						vBibDef = VB.Left(TxtInfo(TempoTel).Tag, 4)
'					End If
'				ElseIf InStr(TxtInfo(TempoTel).Tag, ";") <> 0 Then 
'					vBibDef = VB.Left(TxtInfo(TempoTel).Tag, InStr(TxtInfo(TempoTel).Tag, ";") - 1)
'				Else
'					vBibDef = TxtInfo(TempoTel).Tag
'				End If
'				AdoInsertToRecord(TableOfProductsAndServices, TxtInfo(TempoTel).Text, vBibDef)
'			End If
'			TempoTel = TempoTel + 1
'			SnelHelpPrint(TxtInfo(TempoTel).Tag, blLogging)
'			If Err.Number Then Exit Do
'		Loop 
'		AdoInsertToRecord(TableOfProductsAndServices, (Me.txtLink.Text), "v002")
'		AdoInsertToRecord(TableOfProductsAndServices, (Me.txtMilieu.Text), "v261")
'		AdoInsertToRecord(TableOfProductsAndServices, (Me.txtEindeReeks.Text), "v300")
'		If Me.cbCategorie.SelectedIndex >= 0 Then
'			AdoInsertToRecord(TableOfProductsAndServices, (Me.cbCategorie.Text), "v221")
'		Else
'			AdoInsertToRecord(TableOfProductsAndServices, " ", "v221")
'		End If
'		If Me.cbMerk.SelectedIndex >= 0 Then
'			AdoInsertToRecord(TableOfProductsAndServices, (Me.cbMerk.Text), "v001")
'		Else
'			AdoInsertToRecord(TableOfProductsAndServices, " ", "v001")
'		End If

'	End Sub

'	Sub Schoon()
'		Dim TempoTel As Short

'		TempoTel = 24
'		Do While TempoTel > -1
'			On Error Resume Next
'			TxtInfo(TempoTel).Text = ""
'			TempoTel = TempoTel - 1
'		Loop 
'		Me.txtLink.Text = ""
'		Me.txtMilieu.Text = ""
'		Me.Text = "ProduktFiche :"

'		'v106
'		TxtInfo(2).Text = fmarBoxText("004", "2", "0")
'		'v107
'		TxtInfo(3).Text = Dec(1, "#####.00")
'		'v108
'		TxtInfo(4).Text = fmarBoxText("022", "2", "N")
'		'v111
'		TxtInfo(7).Text = fmarBoxText("002", "2", String99(Reading, 183))
'		'v116
'		TxtInfo(11).Text = String99(Reading, 77)
'		'v117
'		TxtInfo(12).Text = String99(Reading, 78)
'		'v118
'		TxtInfo(13).Text = String99(Reading, 79)

'		VernieuwStockWaarde()
'		VernieuwTicketPrijs()

'		On Error Resume Next
'		'TxtInfo(0).SetFocus
'		Me.cbCategorie.SelectedIndex = -1
'		Me.cbMerk.SelectedIndex = -1

'	End Sub

'	Sub VernieuwStockWaarde()
'		Dim TotaalBeweging As Double
'		Dim TotaalAantal As Single

'		'Dim Stock As cmGemiddelde
'		'Set Stock = New cmGemiddelde
'		'Stock.aantalElementen = 2
'		'Stock.AddItem 2366
'		'Stock.AddItem 7889
'		'If Stock.Volledig Then
'		'    MsgBox Stock.GeMiddelde
'		'End If
'		'Set Stock = Nothing

'		TotaalAantal = Val(TxtInfo(14).Text) + Val(TxtInfo(15).Text) + Val(TxtInfo(16).Text)
'		TotaalBeweging = Val(TxtInfo(17).Text) + Val(TxtInfo(18).Text) + Val(TxtInfo(19).Text)

'		LblCijfers(0).Text = VB6.Format(Val(TxtInfo(14).Text) + Val(TxtInfo(16).Text) - Val(TxtInfo(15).Text), "0.000")
'		If TotaalAantal = 0 Then
'			LblCijfers(1).Text = ""
'		Else
'			LblCijfers(1).Text = VB6.Format((TotaalBeweging / TotaalAantal) * CDbl(LblCijfers(0).Text), "#,##0.00")
'		End If
'		LblCijfers(6).Text = VB6.Format(Val(TxtInfo(9).Text) * CDbl(LblCijfers(0).Text), "#,##0.00")

'	End Sub

'	Sub VernieuwTicketPrijs()

'		Dim BedragBefExcl As Decimal
'		Dim BedragBefIncl As Decimal
'		Dim BedragBefBtw As Decimal

'		Dim BedragEurExcl As Decimal
'		Dim BedragEurIncl As Decimal
'		Dim bedragEurBtw As Decimal

'		'maskerEur
'		If InStr(cmdSwitch.Text, "EUR") Then
'			BedragEurExcl = Val(TxtInfo(3).Text) * Val(TxtInfo(8).Text)
'			BedragBefExcl = BedragEurExcl * Euro

'			bedragEurBtw = BedragEurExcl * Val(Mid(TxtInfo(7).Text, InStr(TxtInfo(7).Text, ":") + 1)) / 100
'			BedragBefBtw = BedragBefExcl * Val(Mid(TxtInfo(7).Text, InStr(TxtInfo(7).Text, ":") + 1)) / 100

'			LblCijfers(5).Text = VB6.Format(BedragEurExcl, "#,##0.00")
'			LblCijfers(3).Text = VB6.Format(BedragBefExcl, "#,##0.00")
'			LblCijfers(4).Text = VB6.Format(BedragEurExcl + bedragEurBtw, "#,##0.00")
'			LblCijfers(2).Text = VB6.Format(BedragBefExcl + BedragBefBtw, "#,##0")
'		Else
'			BedragBefExcl = Val(TxtInfo(3).Text) * Val(TxtInfo(8).Text)
'			BedragEurExcl = BedragBefExcl / Euro

'			BedragBefBtw = CDbl(BedragBefExcl * Val(Mid(TxtInfo(7).Text, InStr(TxtInfo(7).Text, ":") + 1)) / 100)
'			bedragEurBtw = CDbl(BedragEurExcl * Val(Mid(TxtInfo(7).Text, InStr(TxtInfo(7).Text, ":") + 1)) / 100)

'			LblCijfers(3).Text = VB6.Format(BedragBefExcl, "#,##0.00")
'			LblCijfers(5).Text = VB6.Format(BedragEurExcl, "#,##0.00")
'			LblCijfers(2).Text = VB6.Format(BedragBefExcl + BedragBefBtw, "#,##0")
'			LblCijfers(4).Text = VB6.Format(BedragEurExcl + bedragEurBtw, "#,##0.00")
'		End If

'	End Sub

'	Private Sub Alfa_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Alfa.Click

'		SharedFl = TableOfProductsAndServices

'		aIndex = 1
'		GridText = TxtInfo(1).Text
'		SqlSearch.ShowDialog()
'		If Ktrl Then
'		Else
'			VensterVullen()
'		End If

'	End Sub

'	'UPGRADE_WARNING: Event chkFilter.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub chkFilter_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkFilter.CheckStateChanged
'		Dim Index As Short = chkFilter.GetIndex(eventSender)

'		If Index = 1 Then
'			If chkFilter(1).CheckState = 1 Then
'				TxtInfo(8).Enabled = False
'			Else
'				TxtInfo(8).Enabled = True
'			End If
'		End If

'	End Sub

'	Private Sub CmdDommeKey_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdDommeKey.Click
'		Dim CheckBool As Boolean

'VolgendVeld: 
'		Err.Clear()
'		On Error Resume Next
'		CheckBool = TxtInfo(iTabIndex + 1).TabStop
'		If Err.Number Then
'			cmdBewaren.Focus()
'		Else
'			If CheckBool = True Then
'				TxtInfo(iTabIndex + 1).Focus()
'			Else
'				GoTo VolgendVeld
'			End If
'		End If

'	End Sub

'	Private Sub CmdHoger_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdHoger.Click

'		bNext(TableOfProductsAndServices)
'		If Ktrl Then
'			bLast(TableOfProductsAndServices, 0)
'			If Ktrl Then
'				Beep()
'				MsgBox("Er zijn nog geen gegevens...")
'				Exit Sub
'			End If
'		End If
'		VensterVullen()

'	End Sub

'	Private Sub cmdKopij_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdKopij.Click

'		Msg = "Kies 'Ja' voor kopij als XML bestand" & vbCr & "Kies 'Nee' voor kopij naar het klassieke plakbord"

'		KtrlBox = MsgBox(Msg, MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton3)
'		Dim BestandHier As String
'		If KtrlBox = MsgBoxResult.Cancel Then
'			Exit Sub
'		ElseIf KtrlBox = MsgBoxResult.No Then 
'			On Error Resume Next
'			My.Computer.Clipboard.Clear()
'			My.Computer.Clipboard.SetText(msfSQL.Clip)
'			Exit Sub
'		Else
'			On Error GoTo CancelError
'			Mim.TekenSave.FileName = ""
'			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
'			Mim.Teken.CancelError = True
'			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			Mim.TekenSave.Filter = "Alle bestanden (*.xml)|*.xml"
'			Mim.TekenSave.ShowDialog()
'			BestandHier = Mim.TekenSave.FileName
'			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			If Not Dir(BestandHier) = "" Then
'				Kill(BestandHier)
'			End If
'			rsSQLQuery.Save(Mim.TekenSave.FileName, ADODB.PersistFormatEnum.adPersistXML)
'		End If

'CancelError: 
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal

'	End Sub

'	Private Sub CmdLager_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdLager.Click

'		bPrev(TableOfProductsAndServices)
'		If Ktrl Then
'			JetGetFirst(TableOfProductsAndServices, 0)
'			If Ktrl Then
'				Beep()
'				MsgBox("Er zijn nog geen gegevens...")
'				Exit Sub
'			End If
'		End If
'		VensterVullen()

'	End Sub


'	Private Sub cmdRBAcontrole_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRBAcontrole.Click

'		Dim tempo() As String
'		Dim CountTo As Short
'		Dim TelOK As Short

'		TempoMilieu = txtMilieu.Text
'		TelOK = -1

'		tempo = Split(txtMilieu.Text, ";")
'		For CountTo = 0 To UBound(tempo)
'			JetGet(TableOfProductsAndServices, 0, tempo(CountTo))
'			If Ktrl = 0 Then
'				MsgBox(Trim(tempo(CountTo)) & " aanwezig", MsgBoxStyle.Information)
'				TelOK = TelOK + 1
'			Else
'				MsgBox(Trim(tempo(CountTo)) & " NIET aanwezig", MsgBoxStyle.Exclamation)
'			End If
'		Next 
'		If TelOK = UBound(tempo) Then

'		Else
'			TempoMilieu = ""
'			MsgBox("Probeer opnieuw")

'		End If

'	End Sub

'	Private Sub cmdSluiten_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSluiten.Click

'		Me.Close()

'	End Sub


'	Private Sub cmdBewaren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBewaren.Click
'		Dim TempoFL As Short
'		Dim TeSwitchen As Boolean

'		TeSwitchen = False
'		If bhEuro Then
'			If InStr(cmdSwitch.Text, "BEF") Then
'				SnelHelpPrint("BEF switch voor EURO boekhouding.  Cijfers werden omgewerkt vooraleer weg te schrijven", blLogging)
'				cmdSwitch_Click(cmdSwitch, New System.EventArgs())
'				TeSwitchen = True
'			End If
'		ElseIf InStr(cmdSwitch.Text, "EUR") Then 
'			SnelHelpPrint("EUR switch voor BEF boekhouding.  Cijfers worden omgewerkt vooraleer weg te schrijven", blLogging)
'			cmdSwitch_Click(cmdSwitch, New System.EventArgs())
'			TeSwitchen = True
'		End If

'		If TempoMilieu = "" Then
'		Else
'			txtMilieu.Text = TempoMilieu
'			TempoMilieu = ""
'		End If
'		Msg = "Gegevens bestaande '" & JetTableName(TableOfProductsAndServices) & "'-fiche wijzigen.  Bent U zeker ?"
'		KtrlBox = MsgBox(Msg, 292)
'		If KtrlBox = MsgBoxResult.Yes Then
'			RecordVullen()
'			If TeSwitchen = True Then
'				cmdSwitch_Click(cmdSwitch, New System.EventArgs())
'			End If

'			If FicheIsNieuw Then
'				JetInsert(TableOfProductsAndServices, 0)
'				If Me.FormBorderStyle Then
'					cmdSchoon_Click(cmdSchoon, New System.EventArgs())
'				Else
'					Me.Close()
'				End If
'			Else
'				bUpdate(TableOfProductsAndServices, 0)
'			End If
'		Else
'			If TeSwitchen = True Then
'				cmdSwitch_Click(cmdSwitch, New System.EventArgs())
'			End If
'		End If


'	End Sub


'	Private Sub VensterVullen()
'		Dim TempoTel As Short
'		Dim vBibDef As String

'		FicheIsNieuw = False
'		RecordToField(TableOfProductsAndServices)
'		Me.Text = "ProduktFiche : " & RTrim(AdoGetField(TableOfProductsAndServices, "#v105 #"))

'		'If rsPFStat.State = adStateOpen Then
'		'        rsPFStat.Close
'		'    End If
'		'    Msg = "SELECT * FROM ProductenTB2 WHERE Polis = '" & TxtInfo(0).Text & "'"
'		'    rsTB2.Open Msg, adntDB, adOpenDynamic, adLockOptimistic, adCmdText
'		'    Me.cbPolisHistoriek.Clear
'		'    If rsTB2.RecordCount = 0 Then
'		'        SSTab2.TabCaption(1) = "&TB2= (0)"
'		'        Me.rtbIndentTB2.Text = ""
'		'    Else
'		'        SSTab2.TabCaption(1) = "&TB2= (" & Trim$(Str$(rsTB2.RecordCount)) & ")"
'		'        Do While Not rsTB2.EOF
'		'            strTB2 = rsTB2("memoTB2").Value
'		'            Me.cbPolisHistoriek.AddItem "Aanvangsdatum " & rsTB2("DatumAanvang").Value
'		'           rsTB2.MoveNext
'		'        Loop
'		'    End If
'		'    'rsAllerlei.Close
'		'End If

'		TempoTel = 0
'		On Error Resume Next
'		For TempoTel = 0 To TxtInfo.UBound
'			If TxtInfo(TempoTel).Tag = "" Then
'			Else
'				If InStr(TxtInfo(TempoTel).Tag, "|") <> 0 Then
'					If bhEuro Then
'						'boekhoudcijfers in EUR
'						vBibDef = VB.Left(TxtInfo(TempoTel).Tag, 4)
'						If InStr(cmdSwitch.Text, "EUR") Then
'							TxtInfo(TempoTel).Text = Dec(Val(AdoGetField(TableOfProductsAndServices, "#" & vBibDef & " #")), "#######0.0000")
'						Else
'							TxtInfo(TempoTel).Text = Dec(Val(AdoGetField(TableOfProductsAndServices, "#" & vBibDef & " #")) * Euro, "#######0.0000")
'						End If
'					Else
'						'boekhoudcijfers in BEF
'						vBibDef = VB.Right(TxtInfo(TempoTel).Tag, 4)
'						If InStr(cmdSwitch.Text, "BEF") Then
'							TxtInfo(TempoTel).Text = Dec(Val(AdoGetField(TableOfProductsAndServices, "#" & vBibDef & " #")), "#######0.0000")
'						Else
'							TxtInfo(TempoTel).Text = Dec(Val(AdoGetField(TableOfProductsAndServices, "#" & vBibDef & " #")) / Euro, "#######0.0000")
'						End If
'					End If
'				ElseIf InStr(TxtInfo(TempoTel).Tag, ";") <> 0 Then 
'					vBibDef = VB.Left(TxtInfo(TempoTel).Tag, InStr(TxtInfo(TempoTel).Tag, ";") - 1)
'					If InStr(TxtInfo(TempoTel).Tag, "&") Then
'						TxtInfo(TempoTel).Text = AdoGetField(TableOfProductsAndServices, "#" & vBibDef & " #")
'					Else
'						TxtInfo(TempoTel).Text = fmarBoxText(Mid(TxtInfo(TempoTel).Tag, InStr(TxtInfo(TempoTel).Tag, ";") + 1), "2", AdoGetField(TableOfProductsAndServices, "#" & vBibDef & " #"))
'					End If
'				Else
'					vBibDef = TxtInfo(TempoTel).Tag
'					TxtInfo(TempoTel).Text = AdoGetField(TableOfProductsAndServices, "#" & vBibDef & " #")
'				End If
'			End If
'			'If TempoTel = 16 Then Stop
'		Next 
'		Me.txtLink.Text = AdoGetField(TableOfProductsAndServices, "#v002 #")
'		Me.txtEindeReeks.Text = Str(Val(AdoGetField(TableOfProductsAndServices, "#v300 #")))
'		Me.txtMilieu.Text = AdoGetField(TableOfProductsAndServices, "#v261 #")
'		Dim tmpCategorie As String
'		Dim tmpMerk As String
'		Dim TelTotHier As Short

'		tmpCategorie = Trim(AdoGetField(TableOfProductsAndServices, "#v221 #"))
'		tmpMerk = Trim(AdoGetField(TableOfProductsAndServices, "#v001 #"))
'		Me.cbMerk.SelectedIndex = -1
'		Me.cbCategorie.SelectedIndex = -1

'		If tmpCategorie = "" Then
'			'niks
'		Else
'			For TelTotHier = 0 To Me.cbCategorie.Items.Count - 1
'				If tmpCategorie = VB6.GetItemString(Me.cbCategorie, TelTotHier) Then
'					Me.cbCategorie.SelectedIndex = TelTotHier
'				End If
'			Next 
'		End If

'		If tmpMerk = "" Then
'			'niks
'		Else
'			For TelTotHier = 0 To Me.cbMerk.Items.Count - 1
'				If tmpMerk = VB6.GetItemString(Me.cbMerk, TelTotHier) Then
'					Me.cbMerk.SelectedIndex = TelTotHier
'				End If
'			Next 
'		End If

'		VernieuwTicketPrijs()
'		VernieuwStockWaarde()

'	End Sub


'	Private Sub cmdSQL_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSQL.Click

'		Dim retCode As Boolean

'		retCode = adoRECORDset

'	End Sub

'	Function adoRECORDset() As Boolean

'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

'		On Error Resume Next
'		'UPGRADE_NOTE: Object msfSQL.Recordset may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
'		msfSQL.Recordset = Nothing

'		rsSQLQuery.Close()
'		On Error Resume Next
'		rsSQLQuery.Open(txtSQL.Text, adntDB)
'		If Err.Number Then
'			MsgBox("Bron:" & vbCrLf & Err.Source & vbCrLf & vbCrLf & "Foutnummer: " & Err.Number & vbCrLf & vbCrLf & "Detail:" & vbCrLf & Err.Description)
'			'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
'			msfSQL.CtlRefresh()
'		Else
'			msfSQL.DataSource = rsSQLQuery
'		End If
'		lblRecordCount.Text = CStr(rsSQLQuery.RecordCount)
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal

'	End Function


'	Private Sub cmdSwitch_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSwitch.Click
'		Dim TempoTel As Short

'		If cmdSwitch.Text = "Ingave in EUR" Then
'			cmdSwitch.Text = "Ingave in BEF"
'			'de nodige schermopmaak voor BEF
'			On Error Resume Next
'			For TempoTel = 0 To TxtInfo.UBound
'				If InStr(TxtInfo(TempoTel).Tag, "|") <> 0 Then
'					TxtInfo(TempoTel).Text = Dec(Val(TxtInfo(TempoTel).Text) * Euro, "#######0.0000")
'				End If
'			Next 
'		Else
'			cmdSwitch.Text = "Ingave in EUR"
'			'de nodige schermopmaak voor EUR
'			On Error Resume Next
'			For TempoTel = 0 To TxtInfo.UBound
'				If InStr(TxtInfo(TempoTel).Tag, "|") <> 0 Then
'					TxtInfo(TempoTel).Text = Dec(Val(TxtInfo(TempoTel).Text) / Euro, "#######0.0000")
'				End If
'			Next 
'		End If
'		VernieuwTicketPrijs()
'		VernieuwStockWaarde()

'	End Sub

'	Private Sub cmdTonen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTonen.Click

'		If Trim(txtLink.Text) = "" Then
'			Exit Sub
'		End If

'		Dim frmB As New frmMiniBrowser
'		If Err.Number Then MsgBox(ErrorToString()) : Exit Sub
'		frmB.StartingAddress = txtLink.Text
'		frmB.WindowState = System.Windows.Forms.FormWindowState.Normal
'		If Err.Number Then MsgBox(ErrorToString()) : Exit Sub
'		frmB.Show()
'		If Err.Number Then MsgBox(ErrorToString()) : Exit Sub

'	End Sub

'	Private Sub CmdVerwijderFiche_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdVerwijderFiche.Click

'		If Trim(TLBRecord(TableOfProductsAndServices)) = "" Or Trim(TxtInfo(0).Text) = "" Then
'			Msg = "Nummer met blanco verwijderen.  Bent u zeker"
'			KtrlBox = MsgBox(Msg, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2)
'			If KtrlBox = MsgBoxResult.Yes Then
'				Bdelete(TableOfProductsAndServices)
'				CmdHoger_Click(CmdHoger, New System.EventArgs())
'				Exit Sub
'			End If
'		Else
'			Msg = "Gegevens bestaande '" & JetTableName(TableOfProductsAndServices) & "'-fiche :" & Trim(TxtInfo(0).Text) & " verwijderen.  Bent U zeker ?"
'			KtrlBox = MsgBox(Msg, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2)
'			If KtrlBox = MsgBoxResult.Yes Then
'				Bdelete(TableOfProductsAndServices)
'				CmdHoger_Click(CmdHoger, New System.EventArgs())
'				Exit Sub
'			End If
'		End If

'	End Sub

'	Private Sub cmdSchoon_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSchoon.Click

'		On Error Resume Next
'		Schoon()
'		TxtInfo(0).Focus()

'	End Sub

'	Private Sub frmProduktFiche_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

'		rsSQLQuery = New ADODB.Recordset
'		rsSQLQuery.CursorLocation = ADODB.CursorLocationEnum.adUseClient
'		rsJourQuery = New ADODB.Recordset
'		rsJourQuery.CursorLocation = ADODB.CursorLocationEnum.adUseClient

'		If Not Toegankelijk(Me) Then
'			Me.Close()
'			Exit Sub
'		End If

'		Dim RekenOpties As String
'		cmdSwitch.Text = "Ingave in EUR"

'		Schoon()
'		RekenOpties = String99(Reading, 181)
'		For CountTo = 1 To Len(RekenOpties)
'			If CDbl(Mid(RekenOpties, CountTo, 1)) = 1 Then
'				chkFilter(CountTo - 1).CheckState = System.Windows.Forms.CheckState.Checked
'			Else
'				chkFilter(CountTo - 1).CheckState = System.Windows.Forms.CheckState.Unchecked
'			End If
'		Next 
'		groepenVullen()

'	End Sub

'	Private Sub frmProduktFiche_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

'		On Error Resume Next
'		rsSQLQuery.Close()
'		'UPGRADE_NOTE: Object rsSQLQuery may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
'		rsSQLQuery = Nothing

'	End Sub

'	Public Sub Groepen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Groepen.Click

'		ProductGroepen.ShowDialog()
'		groepenVullen()

'	End Sub

'	Public Sub LijstRap_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles LijstRap.Click

'		FrmLijstProdukten.Show()

'	End Sub


'	Private Sub TxtInfo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtInfo.Enter
'		Dim Index As Short = TxtInfo.GetIndex(eventSender)

'		IsGewijzigd = False
'		TxtInfo(Index).SelectionStart = 0
'		TxtInfo(Index).SelectionLength = Len(TxtInfo(Index).Text)
'		iTabIndex = Index

'		TxtInfo(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFF80)
'		If InStr(TxtInfo(Index).Tag, ";") Then
'			If RTrim(TxtInfo(Index).Text) = "" Then
'				SnelHelpPrint("Druk [Ctrl] om te kiezen", blLogging)
'			ElseIf InStr(TxtInfo(Index).Tag, "&") Then 
'				Select Case Mid(TxtInfo(Index).Tag, InStr(TxtInfo(Index).Tag, "&") + 1, 1)
'					Case "K"
'						SharedFl = TableOfCustomers
'					Case "L"
'						SharedFl = TableOfSuppliers
'					Case "R"
'						SharedFl = TableOfLedgerAccounts
'					Case Else
'						MsgBox("nog niks")
'				End Select
'				JetGet(SharedFl, 0, TxtInfo(Index).Text)
'				If Ktrl Then
'					MsgBox(TxtInfo(Index).Text & " bestaat niet (meer) !")
'				Else
'					RecordToField(SharedFl)
'					SnelHelpPrint(FVT(SharedFl, 1) & " Druk [Ctrl] om te wijzigen", blLogging)
'				End If
'			Else
'				SnelHelpPrint("Druk [Ctrl] om te wijzigen", blLogging)
'			End If
'		End If

'	End Sub

'	Private Sub TxtInfo_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles TxtInfo.KeyDown
'		Dim KeyCode As Short = eventArgs.KeyCode
'		Dim Shift As Short = eventArgs.KeyData \ &H10000
'		Dim Index As Short = TxtInfo.GetIndex(eventSender)
'		Dim DummyText As String

'		If KeyCode <> 17 Then Exit Sub

'		If InStr(TxtInfo(Index).Tag, "&") Then
'			aIndex = 0
'			Select Case Mid(TxtInfo(Index).Tag, InStr(TxtInfo(Index).Tag, "&") + 1, 1)
'				Case "K"
'					SharedFl = TableOfCustomers
'				Case "L"
'					SharedFl = TableOfSuppliers
'				Case "R"
'					SharedFl = TableOfLedgerAccounts
'				Case Else
'					MsgBox("nog niks")
'			End Select
'			GridText = TxtInfo(Index).Text
'			SqlSearch.ShowDialog()
'			If Ktrl = 0 Then
'				TxtInfo(Index).Text = FVT(SharedFl, 0)
'			End If
'		ElseIf InStr(TxtInfo(Index).Tag, ";") Then 
'			aIndex = Val(Mid(TxtInfo(Index).Tag, InStr(TxtInfo(Index).Tag, ";") + 1))
'			aIndex = aIndex + 1000
'			DummyText = TxtInfo(Index).Text
'			GridText = DummyText
'			KeuzeVSF.ShowDialog()
'			If GridText <> DummyText Then
'				DummyText = GridText
'				TxtInfo(Index).Text = DummyText
'				VernieuwTicketPrijs()
'			End If
'		End If

'	End Sub

'	Private Sub TxtInfo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtInfo.KeyPress
'		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
'		Dim Index As Short = TxtInfo.GetIndex(eventSender)

'		If InStr(TxtInfo(Index).Tag, ";") Then
'			KeyAscii = 0
'		End If
'		IsGewijzigd = True

'		eventArgs.KeyChar = Chr(KeyAscii)
'		If KeyAscii = 0 Then
'			eventArgs.Handled = True
'		End If
'	End Sub


'	Private Sub TxtInfo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtInfo.Leave
'		Dim Index As Short = TxtInfo.GetIndex(eventSender)
'		Dim BedragZonder As Double
'		Dim Sleuteltje As String

'		TxtInfo(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
'		Select Case Index
'			Case 0
'				JetGet(TableOfProductsAndServices, 0, TxtInfo(0).Text)
'				If Ktrl Then
'					Sleuteltje = TxtInfo(0).Text
'					Schoon()
'					FicheIsNieuw = True
'					TxtInfo(0).Text = Sleuteltje
'				Else
'					VensterVullen()
'				End If

'			Case 1
'				If Not IsGewijzigd Then
'					Exit Sub
'				Else
'					Me.Text = "ProduktFiche : " & TxtInfo(1).Text
'				End If

'			Case 3, 6 'Rekenwaarden zijn gewijzigd

'				Select Case Index
'					Case 3
'						If Val(TxtInfo(3).Text) = 0 Then TxtInfo(3).Text = "1"
'						TxtInfo(3).Text = Dec(Val(TxtInfo(3).Text), "#####.00")
'					Case 6
'						TxtInfo(6).Text = Dec(Val(TxtInfo(6).Text), "###")
'						If chkFilter(1).CheckState = 1 Then
'							If chkFilter(0).CheckState = 1 Then
'								BedragZonder = Val(TxtInfo(9).Text)
'							Else
'								BedragZonder = Val(TxtInfo(9).Text) * Val(TxtInfo(3).Text)
'							End If
'							TxtInfo(8).Text = Dec(BedragZonder + (BedragZonder * Val(TxtInfo(6).Text) / 100), "########0.00000")
'							'TxtInfo(8) = (BedragZonder + (BedragZonder * Val(TxtInfo(6)) / 100))
'						End If
'				End Select
'				VernieuwTicketPrijs()

'			Case 8 'bedragen eerst kontroleren op
'				'verkoop  IN/EX + GLOBAAL
'				If Not IsGewijzigd Then Exit Sub
'				If chkFilter(3).CheckState = 1 Then
'					TxtInfo(8).Text = Dec(Val(TxtInfo(8).Text) * 100 / (100 + Val(Mid(TxtInfo(7).Text, InStr(TxtInfo(7).Text, ":") + 1))), "########0.00000")
'				End If
'				If chkFilter(0).CheckState = 1 Then
'					TxtInfo(8).Text = Dec(Val(TxtInfo(8).Text) / Val(TxtInfo(3).Text), "########0.00000")
'				End If
'				TxtInfo(8).Text = Dec(Val(TxtInfo(8).Text), "########0.00000")
'				VernieuwTicketPrijs()

'			Case 9 'bedragen eerst kontroleren op
'				'aankoop IN/EX + GLOBAAL
'				If Not IsGewijzigd Then Exit Sub
'				If chkFilter(2).CheckState = 1 Then
'					TxtInfo(9).Text = Dec(Val(TxtInfo(9).Text) * 100 / (100 + Val(Mid(TxtInfo(7).Text, InStr(TxtInfo(7).Text, ":") + 1))), "########0.00000")
'				End If
'				If chkFilter(0).CheckState = 1 Then
'					TxtInfo(9).Text = Dec(Val(TxtInfo(9).Text) / Val(TxtInfo(3).Text), "########0.00000")
'				End If
'				If chkFilter(1).CheckState = 1 Then
'					If chkFilter(0).CheckState = 1 Then
'						BedragZonder = Val(TxtInfo(9).Text)
'					Else
'						BedragZonder = Val(TxtInfo(9).Text) * Val(TxtInfo(3).Text)
'					End If
'					TxtInfo(8).Text = Dec(BedragZonder + (BedragZonder * Val(TxtInfo(6).Text) / 100), "########0.00000")
'				End If
'				TxtInfo(9).Text = Dec(Val(TxtInfo(9).Text), "########0.00000")
'				VernieuwTicketPrijs()
'				VernieuwStockWaarde()

'			Case 14 To 16
'				TxtInfo(Index).Text = Dec(Val(TxtInfo(Index).Text), "#####0.000")
'				VernieuwStockWaarde()

'			Case 17 To 19 'stockcijfers zijn gewijzigd
'				VernieuwStockWaarde()

'		End Select

'	End Sub




'	Private Sub v_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles v.SelectedIndexChanged
'		Static PreviousTab As Short = v.SelectedIndex()

'		Dim msgQuery As String
'		If v.Text = "Journaal" Then
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor


'			msgQuery = "SELECT * FROM Journalen WHERE v102 ='" & AdoGetField(TableOfProductsAndServices, "v102") & "' and v019 >'5'"
'			On Error Resume Next
'			'UPGRADE_NOTE: Object msfJournaal.Recordset may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
'			msfJournaal.Recordset = Nothing
'			rsJourQuery.Close()
'			On Error Resume Next
'			rsJourQuery.Open(msgQuery, adntDB)
'			If Err.Number Then
'				MsgBox("Bron:" & vbCrLf & Err.Source & vbCrLf & vbCrLf & "Foutnummer: " & Err.Number & vbCrLf & vbCrLf & "Detail:" & vbCrLf & Err.Description)
'				'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
'				msfSQL.CtlRefresh()
'			Else
'				msfJournaal.DataSource = rsJourQuery
'			End If
'			lbJournaal.Text = CStr(rsJourQuery.RecordCount)
'			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'			'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = vbNormal
'		End If

'		PreviousTab = v.SelectedIndex()
'	End Sub

'	Public Sub VerwijderenMogelijk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VerwijderenMogelijk.Click

'		VerwijderenMogelijk.Checked = Not VerwijderenMogelijk.Checked
'		If VerwijderenMogelijk.Checked Then
'			CmdVerwijderFiche.Enabled = True
'		Else
'			CmdVerwijderFiche.Enabled = False
'		End If

'	End Sub


'	Private Sub groepenVullen()

'		Dim splitstring() As String
'		Dim TelTotHier As Short

'		rsGroepenHier = New ADODB.Recordset
'		rsGroepenHier.CursorLocation = ADODB.CursorLocationEnum.adUseServer

'		On Error Resume Next
'		Err.Clear()
'		rsGroepenHier.Open("p_Groepen", adntDB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect) '  adLockReadOnly, adCmdTableDirect
'		If Err.Number Then
'			MsgBox("productgroepen worden hierna geïnitialiseerd")
'			Groepen_Click(Groepen, New System.EventArgs())
'			Exit Sub
'		End If
'		rsGroepenHier.Index = "GroepsNaam"

'		On Error Resume Next
'		Me.cbCategorie.Items.Clear()
'		Err.Clear()
'		rsGroepenHier.Seek("Categorie", ADODB.SeekEnum.adSeekFirstEQ)
'		If Err.Number Then
'			MsgBox("Gelieve de groepen te initialiseren a.u.b.")
'		Else
'			'lijstje samenstellen
'			splitstring = Split(rsGroepenHier.Fields("GroepItems").Value, ";")
'			For TelTotHier = 0 To UBound(splitstring)
'				Me.cbCategorie.Items.Add(splitstring(TelTotHier))
'			Next 
'		End If
'		Me.cbMerk.Items.Clear()
'		Err.Clear()
'		rsGroepenHier.Seek("Merk", ADODB.SeekEnum.adSeekFirstEQ)
'		If Err.Number Then
'			MsgBox("Gelieve de groepen te initialiseren a.u.b.")
'		Else
'			'lijstje samenstellen
'			splitstring = Split(rsGroepenHier.Fields("GroepItems").Value, ";")
'			For TelTotHier = 0 To UBound(splitstring)
'				Me.cbMerk.Items.Add(splitstring(TelTotHier))
'			Next 
'		End If
'		rsGroepenHier.Close()
'		'UPGRADE_NOTE: Object rsGroepenHier may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
'		rsGroepenHier = Nothing

'	End Sub
'End Class