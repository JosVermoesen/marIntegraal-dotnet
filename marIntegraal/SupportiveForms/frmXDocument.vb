Public Class XDocument
    Private Sub chkAfdrukInVenster_CheckedChanged(sender As Object, e As EventArgs) Handles chkAfdrukInVenster.CheckedChanged

    End Sub

    Private Sub XDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class xDokument
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Dim T As Short
'	'UPGRADE_ISSUE: Declaration type not supported: Array of fixed-length strings. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="934BD4FF-1FF9-47BD-888F-D411E47E78FA"'
'	Dim Voorkeurquick(10, 10) As String*5

'	Dim ReportText(5) As String
'	Dim FieldText(17) As String

'	Dim aa As String
'	Dim dTas As Double
'	Dim IndexNR As Short
'	Dim tMaxField As Short


'	Private Sub PrintEndTotal()
'		Dim Printer As New Printer
'		Dim T As Short

'		For T = 0 To tMaxField
'			FieldText(T) = ""
'		Next 
'		FieldText(1) = "Totaal :"
'		FieldText(10) = Dec(dTas, MASK_2002.Value)

'		If chkAfdrukInVenster.CheckState Then
'		Else
'			Printer.Print(vbCrLf & FULL_LINE.Value)
'		End If

'		T = 0
'		aa = ""
'		Do While REPORT_TAB(T) <> 0
'			If chkAfdrukInVenster.CheckState Then
'				aa = aa & FieldText(T) & vbTab
'			Else
'				Printer.Print(TAB(REPORT_TAB(T)))
'				Printer.Write(FieldText(T))
'			End If
'			If REPORT_TAB(T + 1) < REPORT_TAB(T) Then
'				If chkAfdrukInVenster.CheckState Then
'				Else
'					Printer.Write(vbCrLf)
'				End If
'			End If
'			T = T + 1
'		Loop 
'		If chkAfdrukInVenster.CheckState Then Xlog.X.AddItem(aa, Xlog.X.Rows - 1)

'		If chkAfdrukInVenster.CheckState Then
'			Xlog.X.Row = 1
'			Xlog.X.Col = 0
'			'Xlog.X.ColWidth(0) = 1335
'			'Xlog.X.ColWidth(1) = 2025
'			'Xlog.X.ColWidth(2) = 885
'			'Xlog.X.ColWidth(3) = 480
'			'Xlog.X.ColWidth(4) = 885
'			'Xlog.X.ColWidth(5) = 525
'			'Xlog.X.ColWidth(6) = 945
'			'Xlog.X.ColWidth(7) = 945
'			'Xlog.X.ColWidth(8) = 900
'			'Xlog.X.ColWidth(9) = 1425
'			Xlog.WindowState = System.Windows.Forms.FormWindowState.Maximized

'			Xlog.X.set_ColAlignment(2, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
'			Xlog.X.set_ColAlignment(4, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
'			Xlog.X.set_ColAlignment(6, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
'			Xlog.X.set_ColAlignment(7, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
'			Xlog.X.set_ColAlignment(8, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)

'			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'			'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = vbNormal
'			Xlog.WijzigenLijn.Visible = False
'			Xlog.Afsluiten.TabStop = False
'			'Xlog.cbAfbeelding.Visible = False
'			Xlog.cbAfbeelding.Visible = False
'			XLOG_KEY = ""
'			Xlog.SSTab1.TabPages.Item(1).Visible = False
'			Xlog.ShowDialog()
'			Xlog.Close()
'		End If

'	End Sub


'	Private Sub VpePrintLines()
'		Dim Printer As New Printer
'		Dim T As Short
'		Dim aa As String

'		T = 0
'		aa = ""
'		Do While REPORT_TAB(T) <> 0
'			If chkAfdrukInVenster.CheckState Then
'				aa = aa & FieldText(T) & vbTab
'			Else
'				Printer.Print(TAB(REPORT_TAB(T)))
'				Printer.Write(FieldText(T))
'			End If
'			If REPORT_TAB(T + 1) < REPORT_TAB(T) Then
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
'		If chkAfdrukInVenster.CheckState Then Xlog.X.AddItem(aa, Xlog.X.Rows - 1)

'	End Sub




'	Private Sub VpePrintHeader()
'		Dim Printer As New Printer
'		Dim T As Short

'		If chkAfdrukInVenster.CheckState Then Exit Sub

'		If USER_LICENSEINFO <> "" Then
'			Printer.CurrentX = 50
'			Printer.CurrentY = 50
'			Printer.Write(USER_LICENSEINFO)
'		End If
'		PAGE_COUNTER = PAGE_COUNTER + 1
'		Printer.CurrentY = 400
'		Printer.Write(TAB(1), ReportText(2), TAB(108), "Pagina : " & Dec(PAGE_COUNTER, "##########"))

'		Printer.Write(TAB(108), "Datum  : " & ReportText(0) & vbCrLf & vbCrLf)
'		Printer.Write(TAB(1), UCase(ReportText(3)))

'		Printer.Print(vbCrLf & FULL_LINE.Value)

'		Do While REPORT_TAB(T) <> 0
'			Printer.Print(TAB(REPORT_TAB(T)))
'			Printer.Write(REPORT_FIELD(T))
'			If REPORT_TAB(T + 1) < REPORT_TAB(T) Then
'				Printer.Write(vbCrLf)
'			End If
'			T = T + 1
'		Loop 

'		Printer.Write(FULL_LINE.Value & vbCrLf & vbCrLf)

'		Exit Sub

'PrtHandler3: 
'		MsgBox("Kontroleer de printer.")
'		Resume 

'	End Sub


'	'UPGRADE_WARNING: Event cmbdokumentType.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub cmbdokumentType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbdokumentType.SelectedIndexChanged

'		TekstInfo(0).Text = ""
'		Knop(5).Enabled = False

'	End Sub

'	Private Sub FicheNaarRecord()

'		JetGet(TABLE_VARIOUS, 1, SetSpacing(AdoGetField(TABLE_VARIOUS, "#" & JETTABLEUSE_INDEX(TABLE_VARIOUS, 1) & "#"), FLINDEX_LEN(TABLE_VARIOUS, 1)))
'		If KTRL = 0 Then
'			MSG = "Gegevens bestaande fiche wijzigen.  Bent U zeker ?"
'			CTRL_BOX = MsgBox(MSG, 292)
'			If CTRL_BOX = 6 Then
'				Select Case VB.Left(cmbDokumentType.Text, 2)
'					Case "10"
'						AdoInsertToRecord(TABLE_VARIOUS, (TekstInfo(0).Text), "vs03")
'						AdoInsertToRecord(TABLE_VARIOUS, VB.Left(cmbDokumentType.Text, 2) & AdoGetField(TABLE_VARIOUS, "#vs03 #"), "v005")
'					Case "12"
'						AdoInsertToRecord(TABLE_VARIOUS, (TekstInfo(0).Text), "v152")
'						AdoInsertToRecord(TABLE_VARIOUS, VB.Left(cmbDokumentType.Text, 2) & AdoGetField(TABLE_VARIOUS, "#v152 #"), "v005")
'					Case "18"
'						AdoInsertToRecord(TABLE_VARIOUS, (TekstInfo(0).Text), "v087")
'						AdoInsertToRecord(TABLE_VARIOUS, VB.Left(cmbDokumentType.Text, 2) & AdoGetField(TABLE_VARIOUS, "#v087 #"), "v005")
'					Case "21"
'						AdoInsertToRecord(TABLE_VARIOUS, (TekstInfo(0).Text), "v216")
'						AdoInsertToRecord(TABLE_VARIOUS, VB.Left(cmbDokumentType.Text, 2) & AdoGetField(TABLE_VARIOUS, "#v216 #"), "v005")
'					Case "28"
'						AdoInsertToRecord(TABLE_VARIOUS, (TekstInfo(0).Text), "v231")
'						AdoInsertToRecord(TABLE_VARIOUS, VB.Left(cmbDokumentType.Text, 2) & AdoGetField(TABLE_VARIOUS, "#v231 #"), "v005")
'					Case Else
'						MsgBox("stop")
'				End Select
'				bUpdate(TABLE_VARIOUS, 1)
'			Else
'				Exit Sub
'			End If
'		Else
'			JetInsert(TABLE_VARIOUS, 1)
'		End If

'	End Sub

'	'UPGRADE_WARNING: Form event xDokument.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'	Private Sub xDokument_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated

'		TekstInfo(0).Text = "" 'Right(FVT(TABLE_VARIOUS, 1), 18)

'	End Sub

'	Private Sub xDokument_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

'		If Not Toegankelijk(Me) Then
'			Me.Close()
'			Exit Sub
'		End If

'		Top = 0
'		Left = 0

'		cmbDokumentType.Items.Add("18: Investeringsfiches")
'		cmbDokumentType.Items.Add("10: MuntKodes, dagkoersen")
'		cmbDokumentType.Items.Add("12: Logboek Artikels")
'		cmbDokumentType.Items.Add("21: Forfaitaire Btw cumulators")
'		cmbDokumentType.Items.Add("28: Financiële Instellingen")
'		cmbDokumentType.SelectedIndex = 0

'	End Sub


'	Private Sub Knop_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Knop.Click
'		Dim Index As Short = Knop.GetIndex(eventSender)

'		Select Case Index
'			Case 1 'Nieuw of Gewijzigd wegschrijven
'				FicheNaarRecord()
'				Knop_Click(Knop.Item(3), New System.EventArgs())

'			Case 2 'Alle fiches afdrukken
'				Select Case VB.Left(cmbDokumentType.Text, 2)
'					Case "18"
'						If AfschrijvingenLijstOk Then
'							XLOG_KEY = "SchrijfAF!"
'							DiversePosten.Close()
'							DiversePosten.Show()
'						End If
'					Case Else
'						MsgBox("Nog geen afdrukdefinitie beschikbaar voor " & Mid(cmbDokumentType.Text, 4))
'				End Select

'			Case 3 'Nieuwe Fiche
'				NieuweFiche()
'				TekstInfo(0).Focus()

'			Case 5 'Fiche EDITEREN
'				If TeleBibClick(Val(VB.Left(cmbDokumentType.Text, 2))) = False Then
'					Knop(1).Enabled = False
'				Else
'					Knop(1).Enabled = True
'					Knop(1).Focus()
'					Knop_Click(Knop.Item(1), New System.EventArgs())
'				End If

'			Case 6 'Fiche Lager
'				bPrev(TABLE_VARIOUS)
'				If KTRL = 9 Then
'					JetGetFirst(TABLE_VARIOUS, 1)
'					If KTRL Then
'						Beep()
'						Knop(5).Enabled = False
'					End If
'				ElseIf VB.Left(cmbDokumentType.Text, 2) = VB.Left(KEY_BUF(TABLE_VARIOUS), 2) Then 
'					INSERT_FLAG(TABLE_VARIOUS) = 0
'					RecordNaarFiche()
'					Knop(5).Enabled = True
'					Exit Sub
'				End If
'				If KTRL Then
'				Else
'					JetGetOrGreater(TABLE_VARIOUS, 1, SetSpacing(VB.Left(cmbDokumentType.Text, 2), 20))
'					If KTRL Or VB.Left(KEY_BUF(TABLE_VARIOUS), 2) <> VB.Left(cmbDokumentType.Text, 2) Then
'					Else
'						INSERT_FLAG(TABLE_VARIOUS) = 0
'						RecordNaarFiche()
'						Knop(5).Enabled = True
'					End If
'				End If

'			Case 7 'fiche hoger
'				bNext(TABLE_VARIOUS)
'				If KTRL = 9 Then
'					bLast(TABLE_VARIOUS, 1)
'					If KTRL Then
'						Beep()
'						Knop(5).Enabled = False
'					End If
'				Else
'					If VB.Left(KEY_BUF(TABLE_VARIOUS), 2) <> VB.Left(cmbDokumentType.Text, 2) Then
'					Else
'						INSERT_FLAG(TABLE_VARIOUS) = 0
'						RecordNaarFiche()
'						Knop(5).Enabled = True
'					End If
'				End If

'			Case 8 'verbergen
'				WindowState = System.Windows.Forms.FormWindowState.Minimized
'		End Select

'	End Sub

'	Private Sub Knop_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles Knop.KeyDown
'		Dim KeyCode As Short = eventArgs.KeyCode
'		Dim Shift As Short = eventArgs.KeyData \ &H10000
'		Dim Index As Short = Knop.GetIndex(eventSender)

'		If KeyCode = 46 Then
'			RecordToField(TABLE_VARIOUS)
'			If VB.Left(cmbDokumentType.Text, 2) = VB.Left(FVT(TABLE_VARIOUS, 1), 2) And RTrim(TekstInfo(0).Text) = RTrim(Mid(FVT(TABLE_VARIOUS, 1), 3)) Then
'				MSG = "Bestaande fiche verwijderen.  Bent U zeker ?"
'				CTRL_BOX = MsgBox(MSG, 292)
'				If CTRL_BOX = 6 Then
'					Bdelete(TABLE_VARIOUS)
'					Knop_Click(Knop.Item(3), New System.EventArgs())
'				End If
'			End If
'		End If

'	End Sub

'	Private Sub Knop_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Knop.KeyPress
'		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
'		Dim Index As Short = Knop.GetIndex(eventSender)

'		If InStr("W?AAE<>PPP", UCase(Chr(KeyAscii))) = 0 Then
'			Beep()
'			GoTo EventExitSub
'		ElseIf Knop(InStr("W?AAE<>PPP", UCase(Chr(KeyAscii)))).Enabled = False Then 
'			Beep()
'		Else
'			Knop_Click(Knop.Item(InStr("W?AAE<>PPP", UCase(Chr(KeyAscii)))), New System.EventArgs())
'		End If

'EventExitSub: 
'		eventArgs.KeyChar = Chr(KeyAscii)
'		If KeyAscii = 0 Then
'			eventArgs.Handled = True
'		End If
'	End Sub

'	Private Sub NieuweFiche()

'		TekstInfo(0).Text = ""
'		TLB_RECORD(TABLE_VARIOUS) = ""

'		INSERT_FLAG(TABLE_VARIOUS) = 1
'		Knop(1).Enabled = False 'wegschrijven uitschakelen
'		Knop(5).Enabled = False 'editeren uitschakelen
'		TekstInfo(0).Enabled = True

'	End Sub

'	Private Sub RecordNaarFiche()

'		TLB_RECORD(TABLE_VARIOUS) = ""
'		If KTRL Then
'			MsgBox("stop")
'		Else
'			RecordToField(TABLE_VARIOUS)
'		End If
'		TekstInfo(0).Text = Mid(AdoGetField(TABLE_VARIOUS, "#v005 #"), 3)
'		INSERT_FLAG(TABLE_VARIOUS) = 0

'	End Sub

'	Private Sub TekstInfo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TekstInfo.KeyPress
'		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		If KeyAscii = 13 Then Knop(3).Focus() 'SendKeys "{TAB}", True

'		eventArgs.KeyChar = Chr(KeyAscii)
'		If KeyAscii = 0 Then
'			eventArgs.Handled = True
'		End If
'	End Sub

'	Private Sub TekstInfo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.Leave
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		On Error GoTo LostFocusError

'		Select Case Index
'			Case 0
'				If TekstInfo(0).Text = Space(Len(TekstInfo(0).Text)) Then Exit Sub
'				JetGet(TABLE_VARIOUS, 1, VB.Left(cmbDokumentType.Text, 2) & SetSpacing(TekstInfo(0).Text, 18))
'				If KTRL = 0 Then
'					RecordNaarFiche()
'					INSERT_FLAG(TABLE_VARIOUS) = 0
'					Knop(1).Enabled = True
'					VB6.SetDefault(Knop(1), True)
'				Else
'					Knop(1).Enabled = False
'				End If
'				If INSERT_FLAG(TABLE_VARIOUS) = 1 Then
'					Select Case VB.Left(cmbDokumentType.Text, 2)
'						Case "10"
'							AdoInsertToRecord(TABLE_VARIOUS, (TekstInfo(0).Text), "vs03")
'							AdoInsertToRecord(TABLE_VARIOUS, VB.Left(cmbDokumentType.Text, 2) & AdoGetField(TABLE_VARIOUS, "#vs03 #"), "v005")
'						Case "12"
'							AdoInsertToRecord(TABLE_VARIOUS, (TekstInfo(0).Text), "v152")
'							AdoInsertToRecord(TABLE_VARIOUS, VB.Left(cmbDokumentType.Text, 2) & AdoGetField(TABLE_VARIOUS, "#v152 #"), "v005")
'						Case "18"
'							AdoInsertToRecord(TABLE_VARIOUS, (TekstInfo(0).Text), "v087")
'							AdoInsertToRecord(TABLE_VARIOUS, VB.Left(cmbDokumentType.Text, 2) & AdoGetField(TABLE_VARIOUS, "#v087 #"), "v005")
'						Case "21"
'							AdoInsertToRecord(TABLE_VARIOUS, (TekstInfo(0).Text), "v216")
'							AdoInsertToRecord(TABLE_VARIOUS, VB.Left(cmbDokumentType.Text, 2) & AdoGetField(TABLE_VARIOUS, "#v216 #"), "v005")
'						Case "28"
'							AdoInsertToRecord(TABLE_VARIOUS, (TekstInfo(0).Text), "v231")
'							AdoInsertToRecord(TABLE_VARIOUS, VB.Left(cmbDokumentType.Text, 2) & AdoGetField(TABLE_VARIOUS, "#v231 #"), "v005")

'						Case Else
'							MsgBox("stop")
'					End Select
'				End If
'				Knop(5).Enabled = True
'				Knop(5).Focus()
'		End Select

'LostFocusError: 
'		Exit Sub
'		Resume 

'	End Sub

'	Function AfschrijvingenLijstOk() As Boolean
'		Dim Printer As New Printer

'		Dim DeLijst As String
'		Dim Kontroleer As String
'		Dim omsLijn As String
'		Dim DatumJaarInvest As String

'		Dim dRest As Double
'		Dim ipct As Short
'		Dim dbdrg As Double
'		Dim dRa As Double
'		Dim Das As Double

'		Dim bhKontrole As Boolean

'		Dim BedragBegin As Decimal
'		Dim BedragRest As Decimal
'		Dim RekKontrole As New VB6.FixedLengthString(7)
'		Dim DummyDatum As New VB6.FixedLengthString(8)

'		bhKontrole = False
'		If String99(READING, 63) = "1" Then
'			MSG = "Afschrijvingsposten reeds gegenereerd voor dit boekjaar !" & vbCrLf & vbCrLf
'			MSG = MSG & "Bijkomende posten kunnen uitsluitend via 'Diverse post'-optie" & vbCrLf
'			MSG = MSG & "ingebracht worden !" & vbCrLf & vbCrLf
'			MSG = MSG & "Wenst U boekhoudkundige kontrolelijst ?"
'			CTRL_BOX = MsgBox(MSG, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2)
'			If CTRL_BOX = MsgBoxResult.Yes Then
'				bhKontrole = True
'			Else
'				AfschrijvingenLijstOk = False
'				Exit Function
'			End If
'		ElseIf String99(READING, 63) <> "0" Then 
'			MsgBox("Setup boekjaar en parameters bevat niet de juiste vlag geboekt of niet geboekt.  Kontroleer")
'			AfschrijvingenLijstOk = False
'			Exit Function
'		ElseIf String99(READING, 64) <> "1" Then 
'			MsgBox("Onlogische situatie.  Dit boekjaar bevat nog geen beginbalans ?  De beginbalans dient aanwezig te zijn.  Mogelijk bevindt U zich in het verkeerde boekjaar ?")
'			AfschrijvingenLijstOk = False
'			Exit Function
'		End If

'		dTas = 0
'		JetGetOrGreater(TABLE_VARIOUS, 1, SetSpacing("18", 20))
'		If KTRL Or VB.Left(KEY_BUF(TABLE_VARIOUS), 2) <> "18" Then
'			MsgBox("Er zijn geen investeringsfiches !")
'			AfschrijvingenLijstOk = False
'			Exit Function
'		Else
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'			Me.Enabled = False
'			PAGE_COUNTER = 0
'			If chkAfdrukInVenster.CheckState = 0 Then
'				Printer = Printers(LISTPRINTER_NUMBER)
'				On Error Resume Next
'				'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'				Printer.PaperBin = LaadTekst(My.Application.Info.Title, "LIJSTPRINTER")

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
'			ReportText(0) = MIM_GLOBAL_DATE.Value
'			ReportText(2) = Mid(cmbDokumentType.Text, 4) & " " & Mid(Mim.Text, InStr(Mim.Text, "["))
'			InitialiseFields()
'			VpePrintHeader()
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub AfschrijvingsLijnErBij
'			Do 
'				bNext(TABLE_VARIOUS)
'				If KTRL Or VB.Left(KEY_BUF(TABLE_VARIOUS), 2) <> "18" Then
'					Exit Do
'				Else
'					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'					GoSub AfschrijvingsLijnErBij
'				End If
'			Loop 
'		End If
'		PrintEndTotal()
'		Printer.EndDoc()
'		If bhKontrole = True Then
'			AfschrijvingenLijstOk = False
'		Else
'			AfschrijvingenLijstOk = True
'		End If
'		Me.Enabled = True
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal
'		Exit Function

'AfschrijvingsLijnErBij: 
'		omsLijn = ""
'		RecordToField(TABLE_VARIOUS)
'		If Len(AdoGetField(TABLE_VARIOUS, "#v083 #")) <> 8 Then
'			omsLijn = "Datumformaat '" & AdoGetField(TABLE_VARIOUS, "#v083 #") & "' onjuist voor " & AdoGetField(TABLE_VARIOUS, "#v087 #")
'			MsgBox(omsLijn)
'			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			Return 
'		End If

'		DatumJaarInvest = AdoGetField(TABLE_VARIOUS, "#v083 #")
'		DatumJaarInvest = Mid(DatumJaarInvest, 1, 2) & "/" & Mid(DatumJaarInvest, 3)
'		DatumJaarInvest = Mid(DatumJaarInvest, 1, 5) & "/" & Mid(DatumJaarInvest, 6)

'		If DatumKey(DatumJaarInvest) > Mid(BOOKYEAR_FROMTO.Value, 9) Then
'			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			Return 
'		Else
'			ipct = Val(AdoGetField(TABLE_VARIOUS, "#v082 #"))
'			dbdrg = Val(AdoGetField(TABLE_VARIOUS, "#v084 #"))
'			FieldText(4) = DatumJaarInvest
'			FieldText(5) = Dec(dbdrg, MASK_2002.Value)
'			FieldText(7) = Dec(ipct, "#####")
'			'investeringsrekening
'			FieldText(3) = Trim(AdoGetField(TABLE_VARIOUS, "#v019 #"))
'			JetGet(TABLE_LEDGERACCOUNTS, 0, FieldText(3))
'			If KTRL Then
'				FieldText(0) = "Niet (meer) aanwezig..."
'			Else
'				RecordToField(TABLE_LEDGERACCOUNTS)
'				FieldText(0) = AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #")
'			End If
'			'afschrijvingsrekening
'			FieldText(6) = Trim(AdoGetField(TABLE_VARIOUS, "#v087 #"))
'			JetGet(TABLE_LEDGERACCOUNTS, 0, FieldText(6))
'			If KTRL Then
'				FieldText(1) = "Niet (meer) aanwezig..."
'			Else
'				RecordToField(TABLE_LEDGERACCOUNTS)
'				FieldText(1) = AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #")
'			End If
'			'afschrijvingsKOSTrekening
'			FieldText(9) = Trim(AdoGetField(TABLE_VARIOUS, "#v088 #"))
'			JetGet(TABLE_LEDGERACCOUNTS, 0, FieldText(9))
'			If KTRL Then
'				FieldText(2) = "Niet (meer) aanwezig..."
'			Else
'				RecordToField(TABLE_LEDGERACCOUNTS)
'				FieldText(2) = AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #")
'			End If
'			If bhKontrole Then
'				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'				GoSub bhSPECIAAL
'			Else
'				dRa = Val(AdoGetField(TABLE_VARIOUS, "#v085 #"))
'				If Val(AdoGetField(TABLE_VARIOUS, "#v084 #")) = Val(AdoGetField(TABLE_VARIOUS, "#v085 #")) Then
'					Das = 0
'				Else
'					'Bereken nieuwe afschrijving
'					dRest = dbdrg - (dRa + Val(VB6.Format(dbdrg / ipct, "000000000")))

'					If System.Math.Abs(dRest) < 20 Then
'						Das = Val(VB6.Format(dbdrg / ipct, "000000000")) + dRest
'					Else
'						Das = Val(VB6.Format(dbdrg / ipct, "000000000"))
'					End If
'				End If
'				FieldText(8) = Dec(dRa, MASK_2002.Value)
'				FieldText(10) = Dec(Das, MASK_2002.Value)
'			End If
'			dTas = dTas + Das
'			VpePrintLines()
'			Printer.Write(vbCrLf)
'		End If
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'bhSPECIAAL: 
'		'Investeringsrekening
'		FieldText(3) = Trim(AdoGetField(TABLE_VARIOUS, "#v019 #"))
'		'Afschrijvingsrekening
'		FieldText(6) = Trim(AdoGetField(TABLE_VARIOUS, "#v087 #"))
'		'AfschrijvingsKOSTrekening
'		FieldText(9) = Trim(AdoGetField(TABLE_VARIOUS, "#v088 #"))

'		'Reeds boekhoudkundig afgeschreven kontroleren
'		BedragBegin = 0
'		Das = 0
'		RekKontrole.Value = FieldText(6)
'		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'		GoSub OverLOOPJournaal
'		If Das <> 0 Then
'			dRa = Val(AdoGetField(TABLE_VARIOUS, "#v085 #")) - Das
'		Else
'			dRa = Val(AdoGetField(TABLE_VARIOUS, "#v085 #"))
'		End If
'		FieldText(8) = Dec(dRa, MASK_2002.Value)
'		FieldText(10) = Dec(Das, MASK_2002.Value)
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'OverLOOPJournaal: 
'		DummyDatum.Value = ""
'		JetGetOrGreater(TABLE_JOURNAL, 0, RekKontrole.Value & VB.Left(BOOKYEAR_FROMTO.Value, 8))
'		If KTRL Or KEY_BUF(TABLE_JOURNAL) > RekKontrole.Value & VB.Right(BOOKYEAR_FROMTO.Value, 8) Then
'			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			Return 
'		Else
'			Do 
'				RecordToField(TABLE_JOURNAL)
'				If Trim(DummyDatum.Value) = "" Then
'					DummyDatum.Value = AdoGetField(TABLE_JOURNAL, "#v066 #")
'					BedragBegin = Val(AdoGetField(TABLE_JOURNAL, "#v068 #"))
'				ElseIf DummyDatum.Value = AdoGetField(TABLE_JOURNAL, "#v066 #") Then 
'					BedragBegin = BedragBegin + Val(AdoGetField(TABLE_JOURNAL, "#v068 #"))
'				Else
'					Das = Das + Val(AdoGetField(TABLE_JOURNAL, "#v068 #"))
'				End If
'				bNext(TABLE_JOURNAL)
'				If KTRL Or KEY_BUF(TABLE_JOURNAL) > RekKontrole.Value & VB.Right(BOOKYEAR_FROMTO.Value, 8) Then
'					Exit Do
'				End If
'			Loop 
'			If Das = 0 Then
'				If Val(AdoGetField(TABLE_VARIOUS, "#v084 #")) = Val(AdoGetField(TABLE_VARIOUS, "#v085 #")) Then
'					Das = 0
'				Else
'					Das = System.Math.Abs(BedragBegin)
'					BedragBegin = 0
'				End If
'			Else
'				Das = System.Math.Abs(Das)
'			End If
'		End If
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'	End Function
'	Private Sub InitialiseFields()
'		Dim T As Short

'		Select Case VB.Left(cmbDokumentType.Text, 2)
'			Case "18"
'				REPORT_FIELD(0) = "Investeringsrekening"
'				REPORT_TAB(0) = 2

'				REPORT_FIELD(1) = "Rekening Afschrijvingen"
'				REPORT_TAB(1) = 43

'				REPORT_FIELD(2) = "Afschrijvingskosten Rekening"
'				REPORT_TAB(2) = 84

'				REPORT_FIELD(3) = "Nummer"
'				REPORT_TAB(3) = 2

'				REPORT_FIELD(4) = "AankpDatum"
'				REPORT_TAB(4) = 10

'				REPORT_FIELD(5) = "Tot.Bedrag"
'				REPORT_TAB(5) = 21

'				REPORT_FIELD(6) = "Nummer"
'				REPORT_TAB(6) = 43

'				REPORT_FIELD(7) = "Jaren"
'				REPORT_TAB(7) = 51

'				REPORT_FIELD(8) = "Reeds afg."
'				REPORT_TAB(8) = 57

'				REPORT_FIELD(9) = "Nummer"
'				REPORT_TAB(9) = 84

'				REPORT_FIELD(10) = " Bedrag Af"
'				REPORT_TAB(10) = 92
'				tMaxField = 10
'			Case Else
'				MsgBox("Stop, nog niets voorzien.")
'		End Select

'		If chkAfdrukInVenster.CheckState Then
'			Me.Hide()
'			Xlog.Close()
'			Xlog.Hide()
'			Xlog.Text = cmbDokumentType.Text
'			Xlog.X.Cols = tMaxField + 1
'			Xlog.X.Row = 0
'			For T = 0 To tMaxField
'				Xlog.X.Col = T
'				Xlog.X.Text = REPORT_FIELD(T)
'			Next 
'			Me.Show()
'		End If

'	End Sub
'End Class