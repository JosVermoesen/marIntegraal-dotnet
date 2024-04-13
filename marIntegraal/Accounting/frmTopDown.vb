Public Class frmTopDown
    Private Sub frmTopDown_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
'Friend Class TopDown
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Dim ReportText(5) As String 'Koptekstinfo
'	Dim aa As String

'	Dim RapportSelektie As String
'	Dim RapportTitel As String
'	Dim RapportDefinitie As String
'	Dim ListName As String
'	Dim FieldText(20) As String
'	Dim ktrlBoekjaar As String

'	Dim dttot As Double
'	Dim dtbtw As Double
'	Dim dvtot As Double

'	Private Sub Annuleren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Annuleren.Click

'		Me.Close()

'	End Sub

'	'UPGRADE_WARNING: Event chkAfdrukLiggend.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub chkAfdrukLiggend_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAfdrukLiggend.CheckStateChanged
'		Dim Printer As New Printer

'		If chkAfdrukLiggend.CheckState = 1 Then
'			Printer.Orientation = PrinterObjectConstants.vbPRORLandscape
'		Else
'			Printer.Orientation = PrinterObjectConstants.vbPRORPortrait
'		End If
'		'UPGRADE_ISSUE: DoEvents does not return a value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8D115264-E27F-4472-A684-865A00B5E826"'
'		XDoEvents = System.Windows.Forms.Application.DoEvents()

'	End Sub

'	'UPGRADE_WARNING: Event ChkAfpunten.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub ChkAfpunten_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ChkAfpunten.CheckStateChanged

'		If ChkAfpunten.CheckState = 1 Then
'			chkAfdrukInVenster.CheckState = System.Windows.Forms.CheckState.Checked
'		End If

'	End Sub





'	Private Sub ButtonGenerateReport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Drukken.Click
'		Dim Printer As New Printer
'		Dim BeginSleutel As New VB6.FixedLengthString(13)
'		Dim EindSleutel As New VB6.FixedLengthString(13)
'		Dim KopBuf As String
'		Dim XX As Short
'		Dim Teller As Short
'		Dim FlTabBestand As Short

'		Dim DatumString As String

'		Dim dTOT As Decimal
'		Dim dTnt As Decimal
'		Dim Taal As String

'		ktrlBoekjaar = BookyearFromTo.Value
'		If obBoekjaar(2).Checked = True Then
'			Mid(ktrlBoekjaar, 1, 4) = VB6.Format(Val(Mid(ktrlBoekjaar, 1, 4)) - 1, "0000")
'		End If

'		Select Case aIndex
'			Case 2
'				BeginSleutel.Value = "L" & TekstLijn(2).Text
'				EindSleutel.Value = "L" & TekstLijn(3).Text
'			Case 1
'				BeginSleutel.Value = "K" & TekstLijn(2).Text
'				EindSleutel.Value = "K" & TekstLijn(3).Text
'		End Select

'		ReportText(2) = ListName & " " & Mid(Mim.Text, InStr(Mim.Text, "["))
'		ReportText(0) = TekstLijn(1).Text
'		ReportText(3) = TekstLijn(0).Text
'		InitialiseFields()

'		JetGetOrGreater(TableOfInvoices, 1, BeginSleutel.Value)
'		If Ktrl Or UCase(SetSpacing(KeyBuf(TableOfInvoices), 13)) > UCase(EindSleutel.Value) Then
'			Beep()
'			Exit Sub
'		ElseIf VB.Left(KeyBuf(TableOfInvoices), 1) <> VB.Left(BeginSleutel.Value, 1) Then 
'			Beep()
'			Exit Sub
'		Else
'			KopBuf = Chr(0)
'			If chkSelektie(0).CheckState = 1 Then
'				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'				GoSub OpenTabBestand
'			End If
'			Me.Enabled = False
'			Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
'			'UPGRADE_ISSUE: DoEvents does not return a value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8D115264-E27F-4472-A684-865A00B5E826"'
'			XDoEvents = System.Windows.Forms.Application.DoEvents()

'			JetTableClose(TableDummy)
'			ClearFlDummy()
'			Ktrl = JetTableOpen(TableDummy)

'			PageCounter = 0
'			If chkAfdrukInVenster.CheckState = 0 Then
'				Printer = Printers(LijstPrinterNr)
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
'			VpePrintHeader()
'			RecordToField(TableOfInvoices)
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub KontroleVoorwaarden
'		End If

'		Do 
'			bNext(TableOfInvoices)
'			System.Windows.Forms.Application.DoEvents()
'			If Ktrl Or UCase(SetSpacing(KeyBuf(TableOfInvoices), 13)) > UCase(EindSleutel.Value) Then
'				Exit Do
'			End If
'			RecordToField(TableOfInvoices)
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub KontroleVoorwaarden
'		Loop 
'		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'		GoSub VoegErBij
'		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'		GoSub PrintDeLijst
'		EindTotaal()
'		If chkSelektie(0).CheckState = 1 Then
'			FileClose(FlTabBestand)
'		End If
'		Me.Enabled = True
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Form property TopDown.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		Me.Cursor = vbNormal
'		If chkAfdrukInVenster.CheckState Then
'		Else
'			Printer.NewPage()
'			Printer.EndDoc()
'		End If
'		Annuleren_Click(Annuleren, New System.EventArgs())
'		Exit Sub

'PrintDeLijst: 
'		JetGetFirst(TableDummy, 0)
'		If Ktrl Then
'			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			Return 
'		Else
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub StelSamen
'			Do 
'				bNext(TableDummy)
'				If Ktrl Then
'					Exit Do
'				Else
'					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'					GoSub StelSamen
'				End If
'			Loop 
'		End If
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'StelSamen: 
'		RecordToField(TableDummy)
'		JetGet(aIndex, 0, AdoGetField(TableDummy, "#v034 #"))
'		If Ktrl Then
'			FieldText(0) = "--"
'		Else
'			RecordToField(aIndex)
'			FieldText(0) = AdoGetField(aIndex, "#A10A #")
'		End If

'		Taal = AdoGetField(aIndex, "#A10C #")
'		If Val(AdoGetField(aIndex, "#A102 #")) = 0 Then
'			FieldText(1) = Trim(Trim(AdoGetField(aIndex, "#A100 #")) & " " & AdoGetField(aIndex, "#A101 #"))
'		Else
'			FieldText(1) = Trim(Mid(fmarBoxText("003", Taal, AdoGetField(aIndex, "#A102 #")), 4, 10)) & " " & Trim(Trim(AdoGetField(aIndex, "#A100 #")) & " " & AdoGetField(aIndex, "#A101 #"))
'		End If
'		If Val(AdoGetField(aIndex, "#vs01 #")) = 0 Then
'			FieldText(2) = Trim(Trim(AdoGetField(aIndex, "#A125 #")) & " " & AdoGetField(aIndex, "#A127 #"))
'		Else
'			FieldText(2) = Trim(Mid(fmarBoxText("003", Taal, AdoGetField(aIndex, "#vs01 #")), 4, 10)) & " " & Trim(Trim(AdoGetField(aIndex, "#A125 #")) & " " & AdoGetField(aIndex, "#A127 #"))
'		End If
'		FieldText(3) = Trim(AdoGetField(aIndex, "#A104 #") & " " & AdoGetField(aIndex, "#A105 #") & " " & AdoGetField(aIndex, "#A106 #"))
'		FieldText(4) = Trim(AdoGetField(aIndex, "#A109 #")) & "-" & Trim(AdoGetField(aIndex, "#A107 #")) & " " & Trim(AdoGetField(aIndex, "#A108 #"))
'		FieldText(5) = AdoGetField(TableDummy, "#v037 #")
'		VpePrintLines()
'		If chkAfdrukInVenster.CheckState Then
'		Else
'			Printer.Write(vbCrLf)
'		End If

'		If chkSelektie(0).CheckState = 1 Then
'			For Teller = 0 To 4
'				Print(FlTabBestand, FieldText(Teller) & ";")
'			Next 
'			Print(FlTabBestand, FieldText(5) & vbCrLf)
'		End If
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'KontroleVoorwaarden: 
'		If obBoekjaar(1).Checked = True Then
'			'Enkel dit JAAR
'			If VB.Left(AdoGetField(TableOfInvoices, "#v035 #"), 4) < VB.Left(BookyearFromTo.Value, 4) Then
'				'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'				Return 
'			End If
'		ElseIf obBoekjaar(2).Checked = True Then 
'			'Laatste 2 jaren
'			If VB.Left(AdoGetField(TableOfInvoices, "#v035 #"), 4) < VB.Left(ktrlBoekjaar, 4) Then
'				'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'				Return 
'			End If
'		ElseIf obBoekjaar(3).Checked = True Then 
'			'een bepaalde maand in hoogste boekjaar!
'			If Mid(AdoGetField(TableOfInvoices, "#v035 #"), 1, 6) >= Mid(PeriodFromTo.Value, 1, 6) And Mid(AdoGetField(TableOfInvoices, "#v035 #"), 1, 6) <= Mid(PeriodFromTo.Value, 9, 6) Then
'				'Stop
'			Else
'				'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'				Return 
'			End If
'		End If

'		dTOT = 0
'		Select Case aIndex
'			Case TableOfCustomers
'				Select Case VB.Left(AdoGetField(TableOfInvoices, "#v033 #"), 1)
'					Case "V"
'						'For Teller = 55 To 63
'						'dTot = dTot + Val(AdoGetField(TableOfInvoices, "#v" + Format(Teller, "000") + " #"))
'						'Next
'						'dTot = dTot + Val(AdoGetField(TableOfInvoices, "#v089 #"))
'						dTOT = dTOT + Val(AdoGetField(TableOfInvoices, "#v249 #"))
'					Case "Q"
'						dTOT = dTOT + Val(AdoGetField(TableOfInvoices, "#v249 #"))
'						'If chkSelektie(2).Value = 0 Then
'						'    dTot = Val(AdoGetField(TableOfInvoices, "#B010 #")) - Val(AdoGetField(TableOfInvoices, "#B090 #"))
'						'Else
'						'    dTot = Val(AdoGetField(TableOfInvoices, "#B014 #")) - Val(AdoGetField(TableOfInvoices, "#B094 #"))
'						'End If
'				End Select
'			Case TableOfSuppliers
'				dTOT = dTOT + Val(AdoGetField(TableOfInvoices, "#v249 #"))
'				'dTot = 0
'				'For Teller = 46 To 49
'				'    dTot = dTot + Val(AdoGetField(TableOfInvoices, "#v" + Format(Teller, "000") + " #"))
'				'Next
'		End Select

'		If Mid(AdoGetField(TableOfInvoices, "#v033 #"), 2, 1) = "1" Then
'			dTOT = -dTOT
'		End If

'		If Trim(AdoGetField(TableOfInvoices, "#v034 #")) <> Trim(KopBuf) Then
'			If KopBuf = Chr(0) Then
'			Else
'				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'				GoSub VoegErBij
'			End If
'			dTnt = 0
'			JetGet(aIndex, 0, SetSpacing(Mid(AdoGetField(TableOfInvoices, "#v034 #"), 2, 12), 12))
'			KopBuf = AdoGetField(TableOfInvoices, "#v034 #")
'			TLBRecord(TableDummy) = ""
'			'0
'			AdoInsertToRecord(TableDummy, Mid(AdoGetField(TableOfInvoices, "#v034 #"), 2, 12), "v034")
'			If Ktrl Then
'				AdoInsertToRecord(TableDummy, "* niet meer aanwezig *", "A100")
'			Else
'				RecordToField(aIndex)
'				'1
'				AdoInsertToRecord(TableDummy, VB.Left(AdoGetField(aIndex, "#A100 #"), 35), "A100")
'				'2
'				AdoInsertToRecord(TableDummy, VB.Left(RTrim(RTrim(AdoGetField(aIndex, "#A104 #")) & " " & RTrim(AdoGetField(aIndex, "#A105 #")) & " " & RTrim(AdoGetField(aIndex, "#A106 #"))), 30), "A104")
'				'3
'				AdoInsertToRecord(TableDummy, RTrim(AdoGetField(aIndex, "#A109 #")) & "-" & RTrim(AdoGetField(aIndex, "#A107 #")), "A109")
'				'4
'				AdoInsertToRecord(TableDummy, VB.Left(RTrim(AdoGetField(aIndex, "#A108 #")), 30), "A108")
'			End If
'		End If
'		dTnt = dTnt + dTOT
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'VoegErBij: 
'		If dTnt = 0 Then
'			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			Return 
'		Else
'			AdoInsertToRecord(TableDummy, Dec(dTnt, MaskEURBH), "v037")
'			If chkSelektie(1).CheckState = False Then
'				'v089 = sorteren op kodenummer
'				AdoInsertToRecord(TableDummy, AdoGetField(TableDummy, "#v034 #"), "v089")
'			Else
'				'v089 = sorteren op jaaromzet
'				AdoInsertToRecord(TableDummy, Dec(999999999 - dTnt, "000000000000"), "v089")
'			End If
'			SnelHelpPrint(FVT(TableOfInvoices, 1), blLogging)
'			JetInsert(TableDummy, 0)
'			dttot = dttot + dTnt
'		End If
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'OpenTabBestand: 
'		FlTabBestand = FreeFile
'		FileOpen(FlTabBestand, ProgramLocation & "NTExport.TXT", OpenMode.Output)
'		Msg = "TableDefOnt met scheidingstekens wordt aangemaakt als" & vbCr & vbCr
'		Msg = Msg & ProgramLocation & "NTExport.TXT"
'		MsgBox(Msg, MsgBoxStyle.Information)
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'	End Sub

'	Private Sub EindTotaal()
'		Dim Printer As New Printer
'		Dim T As Short

'		For T = 0 To 5
'			FieldText(T) = ""
'		Next 
'		FieldText(0) = "Totaal"
'		FieldText(5) = Dec(dttot, MaskSy(0))

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
'			Xlog.X.set_ColWidth(0, 1080)
'			Xlog.X.set_ColWidth(1, 1950)
'			Xlog.X.set_ColWidth(2, 1860)
'			Xlog.X.set_ColWidth(3, 1890)
'			Xlog.X.set_ColWidth(4, 1755)
'			Xlog.X.set_ColWidth(5, 900)
'			Xlog.X.set_ColWidth(6, 555)
'			Xlog.WindowState = System.Windows.Forms.FormWindowState.Maximized

'			Xlog.X.set_ColAlignment(5, MSFlexGridLib.AlignmentSettings.flexAlignRightTop)

'			'XLog.X.GridLines = False
'			Xlog.Afsluiten.Enabled = False
'			Xlog.WijzigenLijn.Visible = False
'			Xlog.Afsluiten.TabStop = False
'			Xlog.cbAfbeelding.Visible = False
'			XLogKey = ""
'			Xlog.SSTab1.TabPages.Item(1).Visible = False
'			Xlog.ShowDialog()
'			Xlog.WindowState = System.Windows.Forms.FormWindowState.Normal
'			Xlog.Close()
'		End If
'		Exit Sub

'PrtHandler4: 
'		MsgBox("Kontroleer de printer.")
'		Resume 

'	End Sub

'	Private Sub TopDown_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
'		Dim Printer As New Printer

'		If Not Toegankelijk(Me) Then
'			Me.Close()
'			Exit Sub
'		End If

'		Dim TempbModus As Short

'		dttot = 0
'		dtbtw = 0
'		dvtot = 0
'		TekstLijn(1).Text = MimGlobalDate.Value

'		Select Case aIndex
'			Case TableOfCustomers
'				ListName = "TopDown Klanten"
'			Case TableOfSuppliers
'				ListName = "TopDown Leveranciers"
'		End Select

'		Me.Text = ListName
'		TekstLijn(2).Text = "0"
'		TekstLijn(3).Text = New String("z", 12)
'		If Mim.AV(2).Enabled Then
'			chkSelektie(2).Visible = True
'		End If

'		Printer = Printers(LijstPrinterNr)
'		On Error Resume Next
'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		Printer.PaperBin = LaadTekst(My.Application.Info.Title, "LIJSTPRINTER")
'		If Printer.Orientation = PrinterObjectConstants.vbPRORLandscape Then
'			chkAfdrukLiggend.CheckState = System.Windows.Forms.CheckState.Checked
'		Else
'			chkAfdrukLiggend.CheckState = System.Windows.Forms.CheckState.Unchecked
'		End If
'		Me.TekstLijn(4).Text = BJPERDAT.PeriodeBoekjaar.Text

'	End Sub

'	Private Sub InitialiseFields()
'		Dim T As Short
'		Dim VolgTab As Short

'		ReportField(0) = "Telefoon"
'		ReportTab(0) = 1

'		ReportField(1) = "Naam1"
'		ReportTab(1) = 14

'		ReportField(2) = "Naam2"
'		ReportTab(2) = 50

'		ReportField(3) = "Straat en Nr"
'		ReportTab(3) = 81

'		ReportField(4) = "Plaats"
'		ReportTab(4) = 93

'		If chkSelektie(2).CheckState = 0 Then
'			ReportField(5) = "Omzet incl"
'		Else
'			ReportField(5) = "Commissie"
'		End If
'		ReportTab(5) = 118

'		ReportTab(6) = 0

'		If chkAfdrukInVenster.CheckState Then
'			Me.Hide()
'			Xlog.Close()
'			Xlog.Hide()
'			Xlog.Text = "Jaaromzet"
'			Xlog.X.Cols = 7
'			Xlog.X.Row = 0
'			For T = 0 To 5
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

'	Private Sub TekstLijn_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstLijn.Leave
'		Dim Index As Short = TekstLijn.GetIndex(eventSender)

'		Select Case Index
'			Case 1
'				If DateWrongFormat(TekstLijn(1).Text) Then
'					Beep()
'					TekstLijn(1).Text = MimGlobalDate.Value
'				End If
'		End Select

'	End Sub
'End Class