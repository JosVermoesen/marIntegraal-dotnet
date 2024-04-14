Public Class frmProductlijstRekenkundig
    Private Sub frmProductlijstRekenkundig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
'Friend Class FrmLijstProdukten
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Dim ReportText(5) As String
'	Dim FieldText(17) As String
'	Dim aa As String

'	Dim TotalLines As Integer

'	Dim rsLijstProducten As ADODB.Recordset

'	Dim IndexNR As Short
'	Dim tMaxField As Short

'	Private Sub Annuleren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Annuleren.Click

'		Me.Close()

'	End Sub


'	'UPGRADE_WARNING: Event chkAfdrukLiggend.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub chkAfdrukLiggend_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAfdrukLiggend.CheckStateChanged
'		Dim Printer As New Printer

'		Printer = Printers(LISTPRINTER_NUMBER)
'		On Error Resume Next
'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		Printer.PaperBin = LaadTekst(My.Application.Info.Title, "LIJSTPRINTER")
'		If chkAfdrukLiggend.CheckState = 1 Then
'			Printer.Orientation = PrinterObjectConstants.vbPRORLandscape
'		Else
'			Printer.Orientation = PrinterObjectConstants.vbPRORPortrait
'		End If

'	End Sub

'	'UPGRADE_WARNING: Event CmbLijstType.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub CmbLijstType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmbLijstType.SelectedIndexChanged

'		If CmbLijstType.SelectedIndex > 1 Then
'			MsgBox("Voorlopig " & Now & " enkel eerste lijst mogelijk !")
'			CmbLijstType.SelectedIndex = 0
'		End If

'	End Sub


'	Private Sub ButtonGenerateReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Drukken.Click
'		Dim Printer As New Printer
'		Dim BeginSleutel As String
'		Dim EindSleutel As String
'		Dim Line As Integer
'		Dim DCBedrag As Integer
'		Dim XX As Short
'		Dim Bedrag As Double

'		Dim TicketEUR2005 As Decimal
'		Dim ticketEUR As Decimal

'		Dim VeldTXT3 As String
'		Dim SQLstring As String

'		aa = ""
'		TotalLines = 0
'		Line = 0
'		BeginSleutel = TekstInfo(0).Text
'		EindSleutel = TekstInfo(1).Text

'		ReportText(2) = CmbLijstType.Text & " " & Mid(Mim.Text, InStr(Mim.Text, "["))
'		ReportText(0) = TekstLijn(1).Text
'		ReportText(3) = TekstLijn(0).Text

'		InitialiseFields()
'		JetTableClose(TABLE_PRODUCTS)
'		'Set rsLijstProducten = New ADODB.Recordset
'		'SQLstring = "SELECT * FROM Produkten WHERE "
'		'Stop

'		JetGetFirst(TABLE_PRODUCTS, IndexNR)
'		JetGetOrGreater(TABLE_PRODUCTS, IndexNR, BeginSleutel)
'		If KTRL Or UCase(KEY_BUF(TABLE_PRODUCTS)) > UCase(EindSleutel) Then
'			Beep()
'			Exit Sub
'		Else
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'			PAGE_COUNTER = 0
'			If chkAfdrukInVenster.CheckState = 0 Then
'				If Printer.Width > 12000 Then
'					Printer.FontSize = 10
'					Printer.FontName = "Courier New"
'					Printer.Print(" ")
'					Printer.FontSize = 10
'				Else
'					Printer.FontSize = 8
'					Printer.FontName = "Courier New"
'					Printer.Print(" ")
'					Printer.FontSize = 8
'				End If
'			End If
'			VpePrintHeader()
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub PrintInfo
'		End If

'		Do 
'			bNext(TABLE_PRODUCTS)
'			If KTRL Or UCase(Trim(KEY_BUF(TABLE_PRODUCTS))) > UCase(EindSleutel) Then
'				Exit Do
'			Else
'				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'				GoSub PrintInfo
'			End If
'		Loop 
'		PrintTotal()
'		If chkAfdrukInVenster.CheckState = 0 Then
'			Printer.EndDoc()
'		End If
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal
'		'Annuleren_Click
'		Exit Sub

'		Dim Basisbedrag As Decimal
'		Dim BasisAantal As Single

'PrintInfo: 
'		RecordToField(TABLE_PRODUCTS)
'		Select Case CmbLijstType.SelectedIndex
'			Case 0
'				FieldText(0) = AdoGetField(TABLE_PRODUCTS, "#v102 #")
'				FieldText(1) = AdoGetField(TABLE_PRODUCTS, "#v105 #")

'				Basisbedrag = Val(AdoGetField(TABLE_PRODUCTS, "#e112 #"))
'				FieldText(2) = Dec(Val(AdoGetField(TABLE_PRODUCTS, "#e112 #")), MASK_EUR & "00")

'				FieldText(3) = AdoGetField(TABLE_PRODUCTS, "#v111 #")
'				VeldTXT3 = Mid(fmarBoxText("002", "2", FieldText(3)), 4)

'				BasisAantal = Val(AdoGetField(TABLE_PRODUCTS, "#v107 #"))
'				FieldText(4) = VB.Right(Dec(Val(AdoGetField(TABLE_PRODUCTS, "#v107 #")), MASK_SY(7)), 6)

'				FieldText(5) = Mid(fmarBoxText("004", "2", AdoGetField(TABLE_PRODUCTS, "#v106 #")), 4)
'				TicketEUR2005 = ((Basisbedrag * BasisAantal) + ((Basisbedrag * BasisAantal * Val(VeldTXT3) / 100)))
'				FieldText(6) = VB.Right(Dec(TicketEUR2005, MASK_EUR), 8)
'				FieldText(7) = VB.Right(Dec(Val(AdoGetField(TABLE_PRODUCTS, "#v114 #")) + Val(AdoGetField(TABLE_PRODUCTS, "#v119 #")) - Val(AdoGetField(TABLE_PRODUCTS, "#v120 #")), MASK_SY(7)), 6)
'				FieldText(8) = AdoGetField(TABLE_PRODUCTS, "#v109 #")

'			Case 1
'				FieldText(0) = AdoGetField(TABLE_PRODUCTS, "#v102 #")
'				FieldText(1) = AdoGetField(TABLE_PRODUCTS, "#v105 #")

'				Basisbedrag = Val(AdoGetField(TABLE_PRODUCTS, "#e113 #"))
'				FieldText(2) = Dec(Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")), MASK_EUR & "00")

'				FieldText(3) = AdoGetField(TABLE_PRODUCTS, "#v111 #")
'				VeldTXT3 = Mid(fmarBoxText("002", "2", FieldText(3)), 4)

'				BasisAantal = Val(AdoGetField(TABLE_PRODUCTS, "#v107 #"))
'				FieldText(4) = VB.Right(Dec(Val(AdoGetField(TABLE_PRODUCTS, "#v107 #")), MASK_SY(7)), 6)
'				FieldText(5) = Mid(fmarBoxText("004", "2", AdoGetField(TABLE_PRODUCTS, "#v106 #")), 4)

'				'TicketEUR2005 = ((Basisbedrag * BasisAantal) + ((Basisbedrag * BasisAantal * Val(VeldTXT3) / 100)))
'				'FieldText(6) = Right(Dec((TicketEUR2005), MASK_EUR), 8)
'				FieldText(6) = VB.Right(Dec(Val(AdoGetField(TABLE_PRODUCTS, "#v115 #")), MASK_SY(7)), 6)
'				FieldText(7) = VB.Right(Dec(Val(AdoGetField(TABLE_PRODUCTS, "#v114 #")) + Val(AdoGetField(TABLE_PRODUCTS, "#v119 #")) - Val(AdoGetField(TABLE_PRODUCTS, "#v120 #")), MASK_SY(7)), 6)
'				FieldText(8) = Dec(Val(FieldText(6)) - Val(FieldText(7)), MASK_SY(7))
'		End Select
'		VpePrintLines()
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'	End Sub

'	Private Sub FrmLijstProdukten_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
'		Dim Printer As New Printer

'		If Not Toegankelijk(Me) Then
'			Me.Close()
'			Exit Sub
'		End If

'		Dim T As Short
'		Dim TempbModus As Short
'		Dim SorteringTel As Short

'		TekstLijn(0).Text = ""
'		TekstLijn(1).Text = MIM_GLOBAL_DATE.Value

'		Printer = Printers(LISTPRINTER_NUMBER)
'		On Error Resume Next
'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		Printer.PaperBin = LaadTekst(My.Application.Info.Title, "LIJSTPRINTER")
'		If Printer.Orientation = PrinterObjectConstants.vbPRORLandscape Then
'			chkAfdrukLiggend.CheckState = System.Windows.Forms.CheckState.Checked
'		Else
'			chkAfdrukLiggend.CheckState = System.Windows.Forms.CheckState.Unchecked
'		End If
'		chkAfdrukLiggend_CheckStateChanged(chkAfdrukLiggend, New System.EventArgs())

'		CmbLijstType.Items.Add("Lijst Verkoopstock")
'		CmbLijstType.Items.Add("Lijst Te Bestellen")
'		CmbLijstType.Items.Add("Lijst Aankoop stockwaarde")
'		CmbLijstType.SelectedIndex = 0

'		SorteringTel = -1
'		ToonIndexen(JET_TABLENAME(TABLE_PRODUCTS), Sortering)
'		For T = 0 To Sortering.Items.Count - 1
'			If InStr(VB6.GetItemString(Sortering, T), FLINDEX_CAPTION(TABLE_PRODUCTS, 0)) Then
'				Sortering.SelectedIndex = T
'				Exit For
'			End If
'		Next 

'	End Sub

'	Private Sub InitialiseFields()
'		Dim T As Short

'		Select Case CmbLijstType.SelectedIndex
'			Case 0
'				REPORT_FIELD(0) = "Nummer"
'				REPORT_TAB(0) = 5

'				REPORT_FIELD(1) = "Omschrijving"
'				REPORT_TAB(1) = 19

'				REPORT_FIELD(2) = "VK EUR Ex."
'				REPORT_TAB(2) = 60

'				REPORT_FIELD(3) = "B"
'				REPORT_TAB(3) = 73

'				REPORT_FIELD(4) = "Verpak"
'				REPORT_TAB(4) = 75

'				REPORT_FIELD(5) = "Maat"
'				REPORT_TAB(5) = 83

'				REPORT_FIELD(6) = "EUR incl"
'				REPORT_TAB(6) = 89

'				REPORT_FIELD(7) = " Stock"
'				REPORT_TAB(7) = 98

'				REPORT_FIELD(8) = "Plaats"
'				REPORT_TAB(8) = 107
'				tMaxField = 8

'			Case 1
'				REPORT_FIELD(0) = "Nummer"
'				REPORT_TAB(0) = 5

'				REPORT_FIELD(1) = "Omschrijving"
'				REPORT_TAB(1) = 19

'				REPORT_FIELD(2) = "AK EUR Ex."
'				REPORT_TAB(2) = 60

'				REPORT_FIELD(3) = "B"
'				REPORT_TAB(3) = 73

'				REPORT_FIELD(4) = "Verpak"
'				REPORT_TAB(4) = 75

'				REPORT_FIELD(5) = "Maat"
'				REPORT_TAB(5) = 83

'				REPORT_FIELD(6) = "Min.Stock"
'				REPORT_TAB(6) = 89

'				REPORT_FIELD(7) = " Stock"
'				REPORT_TAB(7) = 98

'				REPORT_FIELD(8) = "Bestellen"
'				REPORT_TAB(8) = 107
'				tMaxField = 8

'			Case Else
'				MsgBox("Stop")
'		End Select

'		If chkAfdrukInVenster.CheckState Then
'			Me.Hide()
'			Xlog.Close()
'			Xlog.Hide()
'			Xlog.Text = CmbLijstType.Text
'			Xlog.X.Cols = tMaxField + 1
'			Xlog.X.Row = 0
'			For T = 0 To tMaxField
'				Xlog.X.Col = T
'				Xlog.X.Text = REPORT_FIELD(T)
'			Next 
'			Me.Show()
'		End If

'	End Sub

'	Private Sub VpePrintHeader()
'		Dim Printer As New Printer
'		Dim T As Short

'		'On Local Error GoTo PrtHandler3

'		If chkAfdrukInVenster.CheckState Then Exit Sub

'		If USER_LICENSEINFO <> "" Then
'			Printer.CurrentX = 50
'			Printer.CurrentY = 50
'			Printer.Write(USER_LICENSEINFO)
'		End If
'		PAGE_COUNTER = PAGE_COUNTER + 1
'		Printer.CurrentY = 400
'		Printer.Write(TAB(1), ReportText(2), TAB(107), Dec(PAGE_COUNTER, "##########"))

'		Printer.Write(TAB(107), ReportText(0) & vbCrLf & vbCrLf)
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

'	Private Sub PrintTotal()
'		Dim Printer As New Printer
'		Dim T As Short

'		For T = 0 To tMaxField
'			FieldText(T) = ""
'		Next 
'		FieldText(1) = "Totaal aantal lijnen : " & VB6.Format(TotalLines)

'		If chkAfdrukInVenster.CheckState Then
'		Else
'			Printer.Print(vbCrLf & FULL_LINE.Value)
'		End If

'		T = 0
'		aa = ""
'		Do While T < tMaxField
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
'			Select Case CmbLijstType.SelectedIndex
'				Case 0
'					Xlog.X.Row = 1
'					Xlog.X.Col = 0
'					Xlog.X.set_ColWidth(0, 1335)
'					Xlog.X.set_ColWidth(1, 3360)
'					Xlog.X.set_ColWidth(2, 810)
'					Xlog.X.set_ColWidth(3, 210)
'					Xlog.X.set_ColWidth(4, 615)
'					Xlog.X.set_ColWidth(5, 525)
'					Xlog.X.set_ColWidth(6, 945)
'					Xlog.X.set_ColWidth(7, 900)
'					Xlog.X.set_ColWidth(8, 1425)
'					Xlog.WindowState = System.Windows.Forms.FormWindowState.Maximized

'					Xlog.X.set_ColAlignment(2, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
'					Xlog.X.set_ColAlignment(4, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
'					Xlog.X.set_ColAlignment(6, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
'					Xlog.X.set_ColAlignment(7, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
'					Xlog.X.set_ColAlignment(8, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)
'			End Select

'			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'			'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = vbNormal
'			Xlog.WijzigenLijn.Visible = False
'			Xlog.Afsluiten.TabStop = False
'			Xlog.Afsluiten.Enabled = False
'			Xlog.cbAfbeelding.Visible = False
'			XLOG_KEY = ""
'			Xlog.SSTab1.TabPages.Item(1).Visible = False
'			Xlog.ShowDialog()
'			'Unload Xlog
'		End If

'	End Sub

'	Private Sub VpePrintLines()
'		Dim Printer As New Printer
'		Dim T As Short
'		Dim aa As String

'		T = 0
'		aa = ""
'		Dim bstAantal As Single

'		If CmbLijstType.SelectedIndex = 1 Then
'			'Bestellijst geselecteerd.  Enkel afdrukken indien nodig
'			If Val(FieldText(8)) > 0 Then
'			Else
'				Exit Sub
'			End If
'		End If
'		TotalLines = TotalLines + 1

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



'	'UPGRADE_WARNING: Event SorTering.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub SorTering_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SorTering.SelectedIndexChanged
'		Dim T As Short

'		IndexNR = -1
'		For T = 0 To Sortering.Items.Count - 1
'			If InStr(Sortering.Text, FLINDEX_CAPTION(TABLE_PRODUCTS, T)) Then
'				IndexNR = T
'				Exit For
'			End If
'		Next 
'		If IndexNR < 0 Then
'			MsgBox("Indexen zijn ondertussen vernieuwd ?" & vbCrLf & vbCrLf & "Om van de nieuwe indexen gebruik te kunnen maken dient U het bedrijf te heropenen !")
'		End If

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
'					TekstLijn(1).Text = MIM_GLOBAL_DATE.Value
'				End If
'		End Select

'	End Sub
'End Class