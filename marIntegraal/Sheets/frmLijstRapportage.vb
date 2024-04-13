Public Class LijstRapportage
    Private Sub frmLijstRapportage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class SQLLijsten
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Dim TabLijn As Short
'	Dim FlKeuze As Short
'	Dim IndexKeuze As Short

'	Dim aa As String
'	Dim TotalLines As Short

'	Dim HoofdTitel As String
'	Dim OnderTitel As String

'	Dim rsLijst As ADODB.Recordset

'	Sub SQLRefresh()

'		On Error Resume Next

'		rsLijst = New ADODB.Recordset
'		On Error Resume Next
'		Err.Clear()
'		rsLijst.CursorLocation = ADODB.CursorLocationEnum.adUseClient
'		SnelHelpPrint(sqlSELECTLijst, blLogging)

'		rsLijst.Open(sqlSELECTLijst, adntDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
'		If Err.Number Then
'			MsgBox("Bron:" & vbCrLf & Err.Source & vbCrLf & vbCrLf & "Foutnummer: " & Err.Number & vbCrLf & vbCrLf & "Detail:" & vbCrLf & Err.Description)
'			Exit Sub
'		Else
'			lblAantalInSelektie.Text = VB6.Format(rsLijst.RecordCount, "#,##0")
'		End If

'	End Sub


'	Function sqlSELECTLijst() As String
'		Dim IndexeerVeld As String

'		IndexeerVeld = Trim(JetTableUseIndex(Val(Mid(Tabel.Text, 1, 1)), Val(Mid(Me.Sortering.Text, 1, 2))))

'		Msg = "SELECT"
'		For CountTo = 0 To Me.RapportVelden.Items.Count - 1
'			Msg = Msg & " " & Trim(Mid(VB6.GetItemString(Me.RapportVelden, CountTo), 5, 5))
'			Msg = Msg & " AS [" & Trim(Mid(VB6.GetItemString(RapportVelden, CountTo), 22)) & "]"
'			If CountTo < Me.RapportVelden.Items.Count - 1 Then
'				Msg = Msg & ","
'			End If
'		Next 
'		Msg = Msg & " FROM " & Mid(Me.Tabel.Text, 4)
'		Msg = Msg & " WHERE " & IndexeerVeld & " >= '" & Trim(Me.TekstInfo(0).Text) & "'"
'		Msg = Msg & " AND " & IndexeerVeld & " <= '" & Trim(Me.TekstInfo(1).Text) & "'"
'		Msg = Msg & " ORDER BY " & IndexeerVeld

'EindeSelect: 
'		sqlSELECTLijst = Msg

'	End Function

'	Private Sub Afdrukken_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Afdrukken.Click
'		Dim Printer As New Printer
'		Dim BeginSleutel As String
'		Dim EindSleutel As String
'		Dim bModDummy As Short
'		Dim Line As Short
'		Dim DCBedrag As Integer
'		Dim XX As Short

'		aa = ""
'		TotalLines = 0
'		Line = 0
'		BeginSleutel = TekstInfo(0).Text
'		EindSleutel = TekstInfo(1).Text

'		HoofdTitel = Mid(Mim.Text, InStr(Mim.Text, "["))
'		OnderTitel = TekstInfo(2).Text

'		SQLRefresh()
'		If rsLijst.RecordCount = 0 Then
'			Exit Sub
'		Else
'			rsLijst.MoveFirst()
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'			PageCounter = 0
'			If chkAfdrukInVenster.CheckState Then
'			Else
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
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub PrintInfo
'		End If
'		Do 
'			rsLijst.MoveNext()
'			If rsLijst.EOF Then
'				Exit Do
'			Else
'				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'				GoSub PrintInfo
'			End If
'		Loop 
'		PrintEinde()
'		Printer.EndDoc()
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal
'		Sluiten.Focus()
'		Exit Sub

'PrintInfo: 
'		Line = Line + 1
'		VpePrintLines()
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

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
'		'UPGRADE_ISSUE: DoEvents does not return a value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8D115264-E27F-4472-A684-865A00B5E826"'
'		XDoEvents = System.Windows.Forms.Application.DoEvents()

'	End Sub

'	Private Sub cmdSQLOvername_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSQLOvername.Click

'		frmADOSQLOpzoeker.Hide()
'		frmADOSQLOpzoeker.txtSQL.Text = rsLijst.Source
'		frmADOSQLOpzoeker.Show()
'		frmADOSQLOpzoeker.txtSQL.Focus()
'		System.Windows.Forms.SendKeys.Send("{ENTER}")

'	End Sub

'	Private Sub cmdToonSQL_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdToonSQL.Click

'		MsgBox(sqlSELECTLijst)

'	End Sub

'	Private Sub DefEdit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DefEdit.Click
'		Dim Index As Short = DefEdit.GetIndex(eventSender)
'		Dim T As Short
'		Dim TempoString As String
'		Dim i As Short

'		Select Case Index
'			Case 0
'				For i = 0 To TabelVelden.Items.Count - 1
'					If TabelVelden.GetSelected(i) Then
'						TempoString = VB6.GetItemString(TabelVelden, i)
'						If TabLijn + Val(Mid(TempoString, 16, 3)) > 128 Then
'							TabLijn = 1
'						Else
'							TabLijn = TabLijn + 1
'						End If
'						Mid(TempoString, 12, 3) = VB6.Format(TabLijn, "000")
'						RapportVelden.Items.Add(TempoString)
'						TabLijn = TabLijn + Val(Mid(TempoString, 16, 3))
'					End If
'				Next i
'			Case 1
'				If RapportVelden.SelectedIndex < 0 Then Beep() : Exit Sub
'				TekstInfo(3).Text = Mid(RapportVelden.Text, 22)
'				TekstInfo(3).Visible = True
'				TekstInfo(3).Focus()

'			Case 2
'				If RapportVelden.SelectedIndex < 0 Then Beep() : Exit Sub
'				For T = 0 To Formattering.Items.Count - 1
'					Formattering.SelectedIndex = T
'					If Mid(RapportVelden.Text, 20, 1) = VB.Left(Formattering.Text, 1) Then
'						Exit For
'					End If
'				Next 
'				Formattering.Visible = True
'				Formattering.Focus()

'			Case 3
'				If RapportVelden.SelectedIndex < 0 Then Beep() : Exit Sub
'				TekstInfo(4).Text = Mid(RapportVelden.Text, 12, 3)
'				TekstInfo(4).Visible = True
'				TekstInfo(4).Focus()

'		End Select

'	End Sub

'	Private Sub Definitie_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Definitie.Click
'		Dim VolgNummer As Short
'		Dim T As Short

'		Dim FlTemp As Short
'		If Afdrukken.Enabled = True Then
'			If TLBPag2(VB6.Format(Val(VB.Left(Tabel.Text, 1)), "000")) Then
'				T = 0
'				TabelVelden.Items.Clear()
'				Do While TeleBibCode(T) <> Space(10)
'					TabelVelden.Items.Add(TeleBibCode(T) & " " & "000 " & VB6.Format(TeleBibLengte(T), "000") & " T " & RTrim(TeleBibTekst(T)))
'					T = T + 1
'				Loop 
'			Else
'				Beep()
'				Exit Sub
'			End If
'			Afdrukken.Enabled = False
'			TabelVelden.Enabled = True
'			RapportVelden.Enabled = True
'			TekstInfo(2).Enabled = True
'			Tabel.Enabled = False
'			Sortering.Enabled = False
'			RapportDefinitie.Enabled = False
'			DefEdit(0).Enabled = True
'			WindowState = System.Windows.Forms.FormWindowState.Maximized
'			TekstInfo(2).Focus()
'		Else
'			Afdrukken.Enabled = True
'			TabelVelden.Enabled = False
'			RapportVelden.Enabled = False
'			TekstInfo(2).Enabled = False
'			Tabel.Enabled = True
'			Sortering.Enabled = True
'			RapportDefinitie.Enabled = True
'			For T = 0 To 3
'				DefEdit(T).Enabled = False
'			Next 
'			WindowState = System.Windows.Forms.FormWindowState.Normal
'			FlTemp = FreeFile
'			VolgNummer = RapportDefinitie.Items.Count
'			FileOpen(FlTemp, ProgramLocation & "Def\" & VB6.Format(Val(VB.Left(Tabel.Text, 1)), "000") & VB6.Format(VolgNummer, "00") & ".PRD", OpenMode.Output)
'			PrintLine(FlTemp, TekstInfo(2).Text)
'			For T = 0 To RapportVelden.Items.Count - 1
'				PrintLine(FlTemp, VB6.GetItemString(RapportVelden, T))
'			Next 
'			FileClose(FlTemp)
'			RapportDefinitie.Items.Add(VB6.Format(VolgNummer, "00") & ": " & TekstInfo(2).Text)
'			RapportDefinitie.SelectedIndex = RapportDefinitie.Items.Count - 1
'		End If

'	End Sub

'	Private Sub SQLLijsten_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
'		Dim Printer As New Printer

'		If Not Toegankelijk(Me) Then
'			Me.Close()
'			Exit Sub
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
'		chkAfdrukLiggend_CheckStateChanged(chkAfdrukLiggend, New System.EventArgs())

'		Tabel.Items.Add("1: Klanten")
'		Tabel.Items.Add("2: Leveranciers")
'		Tabel.Items.Add("3: Rekeningen")
'		Tabel.Items.Add("4: Produkten")
'		Tabel.Items.Add("5: Polissen")

'		Formattering.Items.Add("T: Tekst zonder enige bewerking")
'		Formattering.Items.Add("D: Van SorteerDatum naar DD/MM/EEJJ")
'		Formattering.Items.Add("0: Bedrag met masker ########0")
'		Formattering.Items.Add("1: Bedrag met masker ###0")
'		Formattering.Items.Add("2: Bedrag met masker ######0.00")
'		Formattering.Items.Add("3: Bedrag met masker ##0.00000000")
'		Formattering.Items.Add("4: Bedrag met masker #######0.00")
'		Formattering.Items.Add("5: Bedrag met masker ##0")
'		Formattering.Items.Add("6: Bedrag met masker #0")
'		Formattering.Items.Add("7: Bedrag met masker #####0.0")
'		Formattering.Items.Add("Z: Rekenformule */+-() via Titel!")
'		Tabel.SelectedIndex = 0

'		'ADO TEST
'		'Dim cnn As adodb.Connection
'		'Dim rs As adodb.Recordset

'		'Set cnn = New adodb.Connection
'		'Set rs = New adodb.Recordset

'		'cnn.Open adojetprovider & "Data Source=C:\marnt\data\001\marnt.mdv;"
'		'rs.Open "SELECT * FROM Klanten", cnn, adOpenStatic, adLockOptimistic

'	End Sub

'	Private Sub Formattering_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Formattering.Leave
'		Dim TempoString As String
'		Dim Positie As Short

'		Positie = RapportVelden.SelectedIndex
'		TempoString = RapportVelden.Text
'		Mid(TempoString, 20, 1) = VB.Left(Formattering.Text, 1)
'		RapportVelden.Items.RemoveAt(Positie)
'		RapportVelden.Items.Insert(Positie, TempoString)
'		RapportVelden.Focus()
'		RapportVelden.SelectedIndex = Positie
'		Formattering.Visible = False

'	End Sub

'	Private Sub PrintEinde()

'		On Error Resume Next

'		If chkAfdrukInVenster.CheckState Then
'			Xlog.Text = TekstInfo(2).Text
'			CType(Xlog.Controls("Kopie"), Object)(1).Checked = True
'			Xlog.X.Row = 1
'			Xlog.X.Col = 0
'			Xlog.WindowState = System.Windows.Forms.FormWindowState.Maximized
'			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'			'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = vbNormal
'			Xlog.WijzigenLijn.Visible = False
'			Xlog.Afsluiten.Enabled = False
'			Xlog.Afsluiten.TabStop = False
'			Xlog.cbAfbeelding.Visible = False
'			XLogKey = ""
'			Xlog.SSTab1.TabPages.Item(1).Visible = False
'			Xlog.ShowDialog()
'			Xlog.WindowState = System.Windows.Forms.FormWindowState.Normal
'			Xlog.Close()
'		End If

'	End Sub

'	Private Sub VpePrintHeader()
'		Dim Printer As New Printer
'		Dim T As Short
'		Dim TabNu As Short
'		Dim TabNext As Short

'		If chkAfdrukInVenster.CheckState = 1 And PageCounter = 0 Then
'			Me.Hide()
'			Xlog.Close()
'			Xlog.Hide()
'			Xlog.Text = HoofdTitel
'			Xlog.X.Cols = RapportVelden.Items.Count
'			Xlog.X.Row = 0
'			For T = 0 To RapportVelden.Items.Count - 1
'				RapportVelden.SelectedIndex = T
'				ReportTab(T) = Val(Mid(RapportVelden.Text, 12, 3))
'				Xlog.X.Col = T
'				Xlog.X.Text = RTrim(Mid(RapportVelden.Text, 22))
'				Xlog.X.set_ColWidth(T, 1860)
'			Next 
'			Me.Show()
'			Exit Sub
'		End If

'		If usrLicentieInfo <> "" Then
'			Printer.CurrentX = 50
'			Printer.CurrentY = 50
'			Printer.Write(usrLicentieInfo)
'		End If
'		PageCounter = PageCounter + 1
'		Printer.CurrentY = 400
'		Printer.Write(TAB(1), HoofdTitel, TAB(108), "Pagina : " & Dec(PageCounter, "##########"))

'		Printer.Write(TAB(108), "Datum  : " & MimGlobalDate.Value & vbCrLf & vbCrLf)
'		Printer.Write(TAB(1), OnderTitel)

'		Printer.Print(vbCrLf & FullLine.Value)

'		For T = 0 To RapportVelden.Items.Count - 1
'			RapportVelden.SelectedIndex = T
'			TabNu = Val(Mid(RapportVelden.Text, 12, 3))
'			Printer.Write(TAB(TabNu), Mid(RapportVelden.Text, 22))
'		Next 

'		Printer.Write(vbCrLf & FullLine.Value & vbCrLf & vbCrLf)

'	End Sub

'	Private Sub VpePrintLines()
'		Dim Printer As New Printer
'		Dim TabNu As Short
'		Dim T As Short
'		Dim VeldInfo As String
'		Dim VeldInfoSh As String

'		aa = ""
'		For T = 0 To RapportVelden.Items.Count - 1
'			On Error Resume Next
'			VeldInfo = rsLijst.Fields(Mid(VB6.GetItemString(RapportVelden, T), 22)).Value
'			If Err.Number Then VeldInfo = ""
'			VeldInfoSh = Mid(VB6.GetItemString(RapportVelden, T), 20, 1)
'			Select Case VeldInfoSh
'				Case "T"
'					VeldInfo = RTrim(VB.Left(VeldInfo, Val(Mid(VB6.GetItemString(RapportVelden, T), 16, 3))))
'				Case "D"
'					VeldInfo = FunctionDateText(VeldInfo)
'				Case "0" To "6"
'					VeldInfo = Dec(Val(VeldInfo), MaskSy(Val(VeldInfoSh)))
'				Case Else
'					MsgBox(Mid(VB6.GetItemString(RapportVelden, T), 20, 1) & " werd nog niet voorzien...")
'			End Select
'			If T = 0 Then
'				SnelHelpPrint(VeldInfo, blLogging)
'			End If
'			If chkAfdrukInVenster.CheckState Then
'				aa = aa & VeldInfo
'				If T <> RapportVelden.Items.Count - 1 Then
'					aa = aa & vbTab
'				End If
'			Else
'				TabNu = Val(Mid(VB6.GetItemString(RapportVelden, T), 12, 3))
'				Printer.Write(TAB(TabNu), VeldInfo)
'				If T = RapportVelden.Items.Count - 1 Then
'					Printer.Write(vbCrLf)
'				End If
'			End If
'		Next 
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


'	'UPGRADE_WARNING: Event RapportDefinitie.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub RapportDefinitie_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RapportDefinitie.SelectedIndexChanged
'		Dim RapportTekst As String

'		On Error Resume Next

'		Dim FlTemp As Short
'		FlTemp = FreeFile

'		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		If Dir(ProgramLocation & "Def\" & VB6.Format(Val(VB.Left(Tabel.Text, 1)), "000") & VB.Left(RapportDefinitie.Text, 2) & ".PRD") = "" Then
'			MsgBox(VB6.Format(Val(VB.Left(Tabel.Text, 1)), "000") & VB.Left(RapportDefinitie.Text, 2) & ".PRD" & " bestaat niet meer...")
'			Exit Sub
'		End If

'		FileOpen(FlTemp, ProgramLocation & "Def\" & VB6.Format(Val(VB.Left(Tabel.Text, 1)), "000") & VB.Left(RapportDefinitie.Text, 2) & ".PRD", OpenMode.Input)
'		RapportTekst = LineInput(FlTemp)
'		TekstInfo(2).Text = RapportTekst
'		RapportVelden.Items.Clear()
'		Do While Not EOF(FlTemp)
'			RapportTekst = LineInput(FlTemp)
'			RapportVelden.Items.Add(RapportTekst)
'		Loop 
'		FileClose(FlTemp)

'		SQLRefresh()

'	End Sub

'	Private Sub RapportDefinitie_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles RapportDefinitie.KeyDown
'		Dim KeyCode As Short = eventArgs.KeyCode
'		Dim Shift As Short = eventArgs.KeyData \ &H10000

'		Select Case KeyCode
'			Case 46
'				Msg = "Rapportdefinitie " & vbCrLf & vbCrLf & RapportDefinitie.Text & vbCrLf & vbCrLf & "verwijderen.  Bent U zeker ?"
'				KtrlBox = MsgBox(Msg, 292)
'				If KtrlBox = 6 Then
'					Kill(ProgramLocation & "Def\" & VB6.Format(Val(VB.Left(Tabel.Text, 1)), "000") & VB.Left(RapportDefinitie.Text, 2) & ".PRD")
'					RapportDefinitie.Items.RemoveAt(RapportDefinitie.SelectedIndex)

'				End If
'		End Select

'	End Sub

'	Private Sub RapportVelden_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RapportVelden.Enter

'		DefEdit(0).Enabled = False
'		If RapportVelden.Items.Count = 0 Then
'			TabLijn = 0
'		Else
'			DefEdit(1).Enabled = True
'			DefEdit(2).Enabled = True
'			DefEdit(3).Enabled = True
'		End If

'	End Sub

'	Private Sub RapportVelden_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles RapportVelden.KeyDown
'		Dim KeyCode As Short = eventArgs.KeyCode
'		Dim Shift As Short = eventArgs.KeyData \ &H10000
'		Dim Positie As Short

'		If RapportVelden.Items.Count = 0 Then TabLijn = 0 : Exit Sub

'		Select Case KeyCode
'			Case 46
'				Positie = RapportVelden.SelectedIndex
'				If Positie >= 0 Then
'					RapportVelden.Items.RemoveAt(Positie)
'				End If
'		End Select

'	End Sub

'	Private Sub sluiten_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles sluiten.Click

'		WindowState = System.Windows.Forms.FormWindowState.Normal
'		Me.Close()

'	End Sub

'	'UPGRADE_WARNING: Event SorTering.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub SorTering_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SorTering.SelectedIndexChanged

'		IndexKeuze = Val(VB.Left(Sortering.Text, 2))
'		TekstInfo(5).Text = Str(FlIndexLen(FlKeuze, IndexKeuze))
'		TekstInfo(0).Text = "0"
'		TekstInfo(1).Text = New String("z", Val(TekstInfo(5).Text))

'	End Sub


'	'UPGRADE_WARNING: Event Tabel.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub Tabel_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Tabel.SelectedIndexChanged
'		Dim TekstLijn As String
'		Dim X As String
'		Dim T As Short
'		Dim FlL As Short

'		Sortering.Items.Clear()
'		FlKeuze = Val(VB.Left(Tabel.Text, 1))
'		For T = 0 To FlAantalIndexen(FlKeuze)
'			Sortering.Items.Add(VB6.Format(T, "00") & ":" & FLIndexCaption(FlKeuze, T))
'		Next 
'		Sortering.SelectedIndex = 0
'		RapportDefinitie.Items.Clear()
'		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		X = Dir(ProgramLocation & "Def\" & VB6.Format(Val(VB.Left(Tabel.Text, 1)), "000") & "??.PRD")
'		If X = "" Then
'			Exit Sub
'		Else
'			FlL = FreeFile
'			Do While X <> ""
'				FileOpen(FlL, ProgramLocation & "Def\" & X, OpenMode.Input)
'				TekstLijn = LineInput(FlL)
'				FileClose(FlL)
'				RapportDefinitie.Items.Add(Mid(X, 4, 2) & ": " & TekstLijn)
'				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'				X = Dir()
'			Loop 
'		End If
'		If RapportDefinitie.Items.Count <> 0 Then
'			RapportDefinitie.SelectedIndex = 0
'		End If

'	End Sub

'	'UPGRADE_WARNING: Event TabelVelden.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub TabelVelden_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TabelVelden.SelectedIndexChanged

'		SnelHelpPrint((TabelVelden.Text), blLogging)

'	End Sub

'	Private Sub TabelVelden_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TabelVelden.Enter

'		DefEdit(0).Enabled = True
'		DefEdit(1).Enabled = False
'		DefEdit(2).Enabled = False
'		DefEdit(3).Enabled = False

'	End Sub

'	Private Sub TekstInfo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.Enter
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		TekstInfo(Index).SelectionLength = Len(TekstInfo(Index).Text)

'	End Sub

'	Private Sub TekstInfo_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles TekstInfo.KeyDown
'		Dim KeyCode As Short = eventArgs.KeyCode
'		Dim Shift As Short = eventArgs.KeyData \ &H10000
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)
'		Dim TempoString As String
'		Dim Positie As Short

'		Select Case Index
'			Case 3
'				Select Case KeyCode
'					Case 13
'						Positie = RapportVelden.SelectedIndex
'						TempoString = VB.Left(RapportVelden.Text, 21) & TekstInfo(3).Text
'						RapportVelden.Items.RemoveAt(Positie)
'						RapportVelden.Items.Insert(Positie, TempoString)
'						RapportVelden.Focus()
'						RapportVelden.SelectedIndex = Positie
'				End Select
'			Case 4
'				Select Case KeyCode
'					Case 13
'						Positie = RapportVelden.SelectedIndex
'						TempoString = RapportVelden.Text
'						Mid(TempoString, 12, 3) = VB6.Format(Val(TekstInfo(4).Text), "000")
'						RapportVelden.Items.RemoveAt(Positie)
'						RapportVelden.Items.Insert(Positie, TempoString)
'						RapportVelden.Focus()
'						RapportVelden.SelectedIndex = Positie
'				End Select
'		End Select

'	End Sub

'	Private Sub TekstInfo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.Leave
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		Select Case Index
'			Case 3, 4
'				TekstInfo(Index).Visible = False
'			Case 5
'				If Val(TekstInfo(5).Text) < 1 Or Val(TekstInfo(5).Text) > FlIndexLen(FlKeuze, IndexKeuze) Then
'					Beep()
'					TekstInfo(Index).Text = Str(FlIndexLen(FlKeuze, IndexKeuze))
'					TekstInfo(Index).Focus()
'				End If
'		End Select
'		SQLRefresh()

'	End Sub
'End Class