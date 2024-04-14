Option Strict Off
Option Explicit On

Public Class FormFinancialBook

    Dim ReportText(5) As String
    Dim TotalDebit As Decimal
    Dim TotalCredit As Decimal

    Dim LFontSize(20) As Single
    Dim LNumberL(20) As Short
    Dim FontDefChanged As Short

    Dim FieldText(17) As String

    Dim RecNummer(9) As Short

    Dim RekeningNummer(9) As String

    Dim PeriodFromChosen As String
    Dim PeriodToChosen As String

    Dim ErrorMsg As String
    Dim JournaalManueelVlag As Boolean

    Private Sub FormFinancialBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Text = "Financieel Boeken " & Mid(Mim.Text, InStr(Mim.Text, "["))
        '		Dim Printer As New Printer

        '		If Not Toegankelijk(Me) Then
        '			Me.Close()
        '			Exit Sub
        '		End If

        '		Dim T As Short
        '		Dim A As String
        '		Dim TempbModus As Short

        '		JournaalManueelVlag = False
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

        '		TekstLijn(0).Text = FunctionDateText(VB.Left(BOOKYEAR_FROMTO.Value, 8)) & " - " & FunctionDateText(VB.Right(BOOKYEAR_FROMTO.Value, 8))
        '		TekstLijn(1).Text = MIM_GLOBAL_DATE.Value
        '		PeriodFromChosen.Value = VB.Left(BOOKYEAR_FROMTO.Value, 8)
        '		PeriodToChosen.Value = VB.Right(BOOKYEAR_FROMTO.Value, 8)

        '		RecNummer(0) = 31
        '		RekeningNummer(0) = String99(READING, 41)

        '		RecNummer(1) = 32
        '		RekeningNummer(1) = String99(READING, 42)

        '		RecNummer(2) = 33
        '		RekeningNummer(2) = String99(READING, 43)

        '		RecNummer(3) = 34
        '		RekeningNummer(3) = String99(READING, 44)

        '		RecNummer(4) = 35
        '		RekeningNummer(4) = String99(READING, 45)

        '		RecNummer(5) = 38
        '		RekeningNummer(5) = String99(READING, 39)

        '		RecNummer(6) = 215
        '		RekeningNummer(6) = String99(READING, 211)

        '		RecNummer(7) = 216
        '		RekeningNummer(7) = String99(READING, 212)

        '		RecNummer(8) = 217
        '		RekeningNummer(8) = String99(READING, 213)

        '		RecNummer(9) = 218
        '		RekeningNummer(9) = String99(READING, 214)

        '		JetTableClose(TABLE_JOURNAL)
        '		For T = 0 To 9
        '			JetGet(TABLE_LEDGERACCOUNTS, 0, RekeningNummer(T))
        '			If KTRL Then
        '				A = RekeningNummer(T) & Chr(124) & "Niet aanwezig. Setup Boekjaar!"
        '			Else
        '				RecordToField(TABLE_LEDGERACCOUNTS)
        '				A = RekeningNummer(T) & Chr(124) & RTrim(AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #"))
        '			End If
        '			JetGetFirst(TABLE_JOURNAL, 0)
        '			JetGetOrGreater(TABLE_JOURNAL, 0, RekeningNummer(T) & PeriodFromChosen.Value)
        '			If KTRL Then
        '			Else
        '				If KEY_BUF(TABLE_JOURNAL) > RekeningNummer(T) & PeriodToChosen.Value Then
        '				Else
        '					KeuzeInfo(0).Items.Add(A)
        '				End If
        '			End If
        '		Next 
        '		If KeuzeInfo(0).Items.Count Then KeuzeInfo(0).SelectedIndex = 0

    End Sub

    Sub DetailFinancieelStuk(ByRef DeString As String)
        Dim A As String

        '       InfoScherm.Close()
        '		'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
        '		Load(InfoScherm)
        '		InfoScherm.Text = InfoScherm.Text & ", Journaaldetail voor uittreksel : " & DeString
        '		InfoScherm.X.Rows = 2
        '		InfoScherm.X.Cols = 8
        '		InfoScherm.X.Col = 0
        '		InfoScherm.X.Row = 0
        '		InfoScherm.X.Text = "Datum (v066)"
        '		InfoScherm.X.set_ColAlignment(0, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
        '		InfoScherm.X.Col = 1
        '		InfoScherm.X.Text = "Rekening (v019)"
        '		InfoScherm.X.set_ColAlignment(1, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
        '		InfoScherm.X.Col = 2
        '		InfoScherm.X.Text = "Naam (v020)"
        '		InfoScherm.X.set_ColAlignment(2, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
        '		InfoScherm.X.Col = 3
        '		InfoScherm.X.Text = "Bedrag (dece068)"
        '		InfoScherm.X.set_ColAlignment(3, MSFlexGridLib.AlignmentSettings.flexAlignGeneral)
        '		InfoScherm.X.Col = 4
        '		InfoScherm.X.Text = "Boekingsomschrijving (v067)"
        '		InfoScherm.X.set_ColAlignment(4, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
        '		InfoScherm.X.Col = 5
        '		InfoScherm.X.Text = "AV Dokum. (v033)"
        '		InfoScherm.X.set_ColAlignment(5, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
        '		InfoScherm.X.Col = 6
        '		InfoScherm.X.Text = "TegenRek. (v069)"
        '		InfoScherm.X.set_ColAlignment(6, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
        '		InfoScherm.X.Col = 7
        '		InfoScherm.X.Text = "vsfRecord"

        '		JetGet(TABLE_JOURNAL, 2, SetSpacing(DeString, 8))
        '		If KTRL Then
        '			Beep()
        '			MsgBox("Geen journaallijnen voor " & DeString)
        '			Exit Sub
        '		Else
        '			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        '			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '			GoSub VolgendeLijn
        '			Do 
        '				bNext(TABLE_JOURNAL)
        '				If KTRL Or KEY_BUF(TABLE_JOURNAL) <> DeString Then
        '					Exit Do
        '				Else
        '					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '					GoSub VolgendeLijn
        '				End If
        '			Loop 
        '		End If
        '		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        '		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = vbNormal

        'OpHetScherm: 
        '		InfoScherm.X.Row = 1
        '		InfoScherm.X.Col = 0

        '		InfoScherm.X.set_ColWidth(0, 1005)
        '		InfoScherm.X.set_ColWidth(1, 765)
        '		InfoScherm.X.set_ColWidth(2, 2160)
        '		InfoScherm.X.set_ColWidth(3, 750)
        '		InfoScherm.X.set_ColWidth(4, 1950)
        '		InfoScherm.X.set_ColWidth(5, 1150)
        '		InfoScherm.X.set_ColWidth(6, 870)
        '		InfoScherm.X.set_ColWidth(7, 6000)
        '		InfoScherm.X.set_ColAlignment(0, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
        '		InfoScherm.X.set_ColAlignment(1, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
        '		InfoScherm.X.set_ColAlignment(2, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
        '		InfoScherm.X.set_ColAlignment(3, MSFlexGridLib.AlignmentSettings.flexAlignGeneral)
        '		InfoScherm.X.set_ColAlignment(4, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
        '		InfoScherm.X.set_ColAlignment(5, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
        '		InfoScherm.X.set_ColAlignment(6, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
        '		InfoScherm.X.set_ColAlignment(7, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)

        'XLogShow: 
        '		InfoScherm.ShowDialog()
        '		InfoScherm.Close()
        '		Exit Sub

        'VolgendeLijn: 
        '		RecordToField(TABLE_JOURNAL)
        '		If SetSpacing(AdoGetField(TABLE_JOURNAL, "#v019 #"), 7) = VB.Left(KeuzeInfo(0).Text, 7) Then
        '			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '			Return 
        '		ElseIf FunctionDateText(AdoGetField(TABLE_JOURNAL, "#v066 #")) <> Mid(UittrekselsLijst.Text, 12, 10) Then 
        '			If Not JournaalManueelVlag Then
        '				'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '				Return 
        '			End If
        '		ElseIf RTrim(AdoGetField(TABLE_JOURNAL, "#v019 #")) <> "" Then 
        '			If SetSpacing(AdoGetField(TABLE_JOURNAL, "#v069 #"), 7) <> VB.Left(KeuzeInfo(0).Text, 7) Then
        '				'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '				Return 
        '			End If
        '		End If
        '		A = FunctionDateText(AdoGetField(TABLE_JOURNAL, "#v066 #")) & vbTab
        '		A = A & AdoGetField(TABLE_JOURNAL, "#v019 #") & vbTab
        '		JetGet(TABLE_LEDGERACCOUNTS, 0, SetSpacing(AdoGetField(TABLE_JOURNAL, "#v019 #"), 7))
        '		If KTRL Then
        '			A = A & "//" & vbTab
        '		Else
        '			RecordToField(TABLE_LEDGERACCOUNTS)
        '			A = A & AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #") & vbTab
        '		End If
        '		A = A & RS_MAR(TABLE_JOURNAL).Fields("v068").Value & vbTab
        '		A = A & RS_MAR(TABLE_JOURNAL).Fields("v067").Value & vbTab
        '		A = A & RS_MAR(TABLE_JOURNAL).Fields("v033").Value & vbTab
        '		A = A & RS_MAR(TABLE_JOURNAL).Fields("v069").Value & vbTab
        '		A = A & TLB_RECORD(TABLE_JOURNAL)
        '		InfoScherm.X.AddItem(A, InfoScherm.X.Rows - 1)
        '		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		Return 

    End Sub

    Private Sub CumulPrint()
        '		Dim Printer As New Printer
        Dim RekeningNaam As String = Space(30)
        Dim Tabul As Short

        VpePrintHeader()
        PrintTotal()
        '		Printer.Print()
        '		Printer.Print(TAB(2), "** CENTRALISATIE **")
        '		Printer.Print("")

        JetTableClose(TABLE_DUMMY)
        JetGetFirst(TABLE_DUMMY, 0)
        RecordToField(TABLE_DUMMY)
        JetGet(TABLE_LEDGERACCOUNTS, 0, SetSpacing(FVT(TABLE_DUMMY, 0), 7))
        If KTRL Then
            RekeningNaam = "Rekening reeds vernietigd !!!"
        Else
            RecordToField(TABLE_LEDGERACCOUNTS)
            RekeningNaam = AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #")
        End If
        Tabul = 0
        '		Printer.Write(TAB(Tabul + 2), Dec(Val(AdoGetField(TABLE_DUMMY, "#v013 #")), "####") & " x " & SetSpacing(AdoGetField(TABLE_DUMMY, "#v089 #"), 7) & " " & RekeningNaam.Value & " " & Dec(Val(AdoGetField(TABLE_DUMMY, "#v068 #")), MASK_EURBH))

        '		Do 
        '			bNext(TABLE_DUMMY)
        '			If KTRL Then
        '				Exit Do
        '			End If
        '			RecordToField(TABLE_DUMMY)
        '			JetGet(TABLE_LEDGERACCOUNTS, 0, VB.Left(FVT(TABLE_DUMMY, 0), 7))
        '			If KTRL Then
        '				RekeningNaam.Value = "Rekening reeds vernietigd !!!"
        '			Else
        '				RecordToField(TABLE_LEDGERACCOUNTS)
        '				RekeningNaam.Value = AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #")
        '			End If
        '			If Tabul = 0 Then
        '				Tabul = 59
        '				Printer.Write(TAB(Tabul + 2), Dec(Val(AdoGetField(TABLE_DUMMY, "#v013 #")), "####") & " x " & SetSpacing(AdoGetField(TABLE_DUMMY, "#v089 #"), 7) & " " & RekeningNaam.Value & " " & Dec(Val(AdoGetField(TABLE_DUMMY, "#v068 #")), MASK_EURBH) & vbCrLf)
        '			Else
        '				Tabul = 0
        '				Printer.Write(TAB(Tabul + 2), Dec(Val(AdoGetField(TABLE_DUMMY, "#v013 #")), "####") & " x " & SetSpacing(AdoGetField(TABLE_DUMMY, "#v089 #"), 7) & " " & RekeningNaam.Value & " " & Dec(Val(AdoGetField(TABLE_DUMMY, "#v068 #")), MASK_EURBH))
        '			End If
        '		Loop 
        '		Exit Sub

        'PrtHandler: 
        '		MsgBox("Kontroleer de printer.")
        '		Resume 

    End Sub

    Private Sub CmdJournaalManueel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdJournaalManueel.Click
        '		Dim KtrlInput As String

        'InputVanFinancieelStuk: 
        '		KtrlInput = InputBox("Geef nummer van het financieel stuk (8 tekens !)", "Financieel journaal kontrole ")
        '		If KtrlInput = "" Then
        '			Exit Sub
        '		ElseIf Len(KtrlInput) <> 8 Then 
        '			MSG = "dokumentnummer bestaat uit 8 tekens !" & vbCrLf & vbCrLf
        '			MSG = MSG & "Voorbeeld:" & vbCrLf
        '			MSG = MSG & "Rekening 'GB', werkelijk jaar 19'98'," & vbCrLf
        '			MSG = MSG & "uittreksel 124, geeft als dokumentnummer:" & vbCrLf & vbCrLf
        '			MSG = MSG & "GB980124"
        '			MsgBox(MSG)
        '			Exit Sub
        '		End If
        '		JournaalManueelVlag = True
        '		DetailFinancieelStuk(KtrlInput)
        '		JournaalManueelVlag = False

    End Sub

    Private Sub InitialiseFields()

        REPORT_FIELD(0) = "Datum"
        REPORT_TAB(0) = 2

        REPORT_FIELD(1) = "Rek.Nm."
        REPORT_TAB(1) = 13

        REPORT_FIELD(2) = "Naam/Omschrijving"
        REPORT_TAB(2) = 21

        REPORT_FIELD(3) = "Betreft"
        REPORT_TAB(3) = 62

        REPORT_FIELD(4) = "       Debet"
        REPORT_TAB(4) = 93

        REPORT_FIELD(5) = "      Credit"
        REPORT_TAB(5) = 105

        REPORT_FIELD(6) = "Document"
        REPORT_TAB(6) = 118

        REPORT_TAB(7) = 0

    End Sub

    Private Sub VpePrintHeader()
        '		Dim Printer As New Printer
        '		Dim T As Short

        '		On Error GoTo PrtHandler3

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

    End Sub

    Private Sub PrintTotal()
        '		Dim Printer As New Printer
        '		Dim T As Short

        '		On Error GoTo PrtHandler4

        '		For T = 0 To 6
        '			FieldText(T) = ""
        '		Next 
        '		FieldText(3) = "Periodiek totaal :"
        '		FieldText(4) = Dec(System.Math.Abs(TotalDebit), MASK_EURBH)
        '		FieldText(5) = Dec(System.Math.Abs(TotalCredit), MASK_EURBH)

        '		Printer.Print(vbCrLf & FULL_LINE.Value)

        '		T = 0
        '		Do While T < 8
        '			Printer.Print(TAB(REPORT_TAB(T)))
        '			Printer.Write(FieldText(T))
        '			If REPORT_TAB(T + 1) < REPORT_TAB(T) Then
        '				Printer.Write(vbCrLf)
        '			End If
        '			T = T + 1
        '		Loop 
        '		Exit Sub

        'PrtHandler4: 
        '		MsgBox("Kontroleer de printer.")
        '		Resume 

    End Sub

    Private Sub VpePrintLines()
        '		Dim Printer As New Printer
        '		Dim T As Short

        '		On Error GoTo PrtHandler2

        '		T = 0
        '		Do While REPORT_TAB(T) <> 0
        '			Printer.Print(TAB(REPORT_TAB(T)))
        '			Printer.Write(FieldText(T))
        '			If REPORT_TAB(T + 1) < REPORT_TAB(T) Then
        '				Printer.Write(vbCrLf)
        '			End If
        '			T = T + 1
        '		Loop 
        '		If Printer.CurrentY >= Printer.Height - 1200 Then
        '			Printer.NewPage()
        '			Printer.FontSize = Printer.FontSize
        '			Printer.Print(" ")
        '			Printer.FontSize = Printer.FontSize
        '			VpePrintHeader()
        '		End If
        '		Exit Sub

        'PrtHandler2: 
        '		MsgBox("Kontroleer de printer.")
        '		Printer.KillDoc()
        '		Me.Close()
        '		Resume 

        '	End Sub

        '	Private Sub TekstLijn_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstLijn.Enter
        '		Dim Index As Short = TekstLijn.GetIndex(eventSender)

        '		TekstLijn(Index).SelectionLength = Len(TekstLijn(Index).Text)

    End Sub

    Private Sub UittrekselsLijst_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles LbUittrekselsLijst.DoubleClick

        '		DetailFinancieelStuk(Mid(UittrekselsLijst.Text, 1, 8))

    End Sub

    Private Sub UittrekselsLijst_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles LbUittrekselsLijst.Enter

        '		SnelHelpPrint("[Enter] of dubbelklikken voor detail.", BL_LOGGING)

    End Sub

    Private Sub CbFinancialChoosen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbFinancialChoosen.SelectedIndexChanged

        '		Dim Index As Short = KeuzeInfo.GetIndex(eventSender)
        '		Dim DummyText As String
        '		Dim DCBedrag As Double

        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        '		Select Case Index
        '			Case 0
        '				UittrekselsLijst.Visible = False
        '				UittrekselsLijst.Items.Clear()
        '				JetGetFirst(TABLE_JOURNAL, 0)
        '				JetGetOrGreater(TABLE_JOURNAL, 0, VB.Left(KeuzeInfo(0).Text, 7) & PeriodFromChosen.Value)
        '				If KTRL Or KEY_BUF(TABLE_JOURNAL) > VB.Left(KeuzeInfo(0).Text, 7) & PeriodToChosen.Value Then
        '					MsgBox("onlogische situatie")
        '					GoTo EindeClick
        '				Else
        '					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '					GoSub VoegErBij
        '				End If

        '				Do 
        '					bNext(TABLE_JOURNAL)
        '					If KTRL Or KEY_BUF(TABLE_JOURNAL) > VB.Left(KeuzeInfo(0).Text, 7) & PeriodToChosen.Value Then
        '						Exit Do
        '					Else
        '						'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '						GoSub VoegErBij
        '					End If
        '				Loop 
        '				If UittrekselsLijst.Items.Count Then UittrekselsLijst.SelectedIndex = 0
        '				UittrekselsLijst.Visible = True
        '			Case Else
        '		End Select

        'EindeClick: 
        '		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        '		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = vbNormal
        '		On Error Resume Next
        '		'UittrekselsLijst.SetFocus
        '		Exit Sub

        'VoegErBij: 
        '		RecordToField(TABLE_JOURNAL)
        '		If Len(AdoGetField(TABLE_JOURNAL, "#v038 #")) <> 8 Then
        '			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '			Return 
        '			'DummyText = AdoGetField(TABLE_JOURNAL, "#v033 #") + " " + Chr$(124) + " "
        '		Else
        '			DummyText = AdoGetField(TABLE_JOURNAL, "#v038 #") & " " & Chr(124) & " "
        '		End If
        '		DummyText = DummyText & FunctionDateText(AdoGetField(TABLE_JOURNAL, "#v066 #")) & " " & Chr(124) & " "
        '		DummyText = DummyText & SetSpacing(AdoGetField(TABLE_JOURNAL, "#v067 #"), 30) & Chr(124)
        '		DCBedrag = Val(AdoGetField(TABLE_JOURNAL, "#v068 #"))
        '		Select Case DCBedrag
        '			Case Is < 0
        '				DummyText = DummyText & Dec(0, MASK_EURBH) & Chr(124) & Dec(System.Math.Abs(DCBedrag), MASK_EURBH)
        '			Case Else
        '				DummyText = DummyText & Dec(System.Math.Abs(DCBedrag), MASK_EURBH) & Chr(124) & Dec(0, MASK_EURBH)
        '		End Select
        '		UittrekselsLijst.Items.Add(DummyText)
        '		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		Return 


    End Sub

    Private Sub LbUittrekselsLijst_KeyDown(sender As Object, e As KeyEventArgs) Handles LbUittrekselsLijst.KeyDown

        Dim KeyCode As Short = sender.KeyCode
        Dim Shift As Short = sender.KeyData \ &H10000

        If KeyCode = 13 Then DetailFinancieelStuk(Mid(LbUittrekselsLijst.Text, 1, 8))

    End Sub

    Private Sub TbTekstLijn_Leave(sender As Object, e As EventArgs) Handles TbTekstLijn.Leave

        '		Dim Index As Short = TekstLijn.GetIndex(eventSender)
        '		Dim T As Short
        '		Dim A As String

        '		Select Case Index
        '			Case 0
        '				If DateWrongFormat(VB.Right(TekstLijn(0).Text, 10)) Then
        '					MsgBox("Respecteer : " & vbCrLf & vbCrLf & "DD/MM/EEJJ - DD/MM/EEJJ a.u.b. !")
        '					TekstLijn(0).Text = BJPERDAT.PeriodeBoekjaar.Text
        '					TekstLijn(0).Focus()
        '					Exit Sub
        '				ElseIf Len(TekstLijn(0).Text) <> 23 Then 
        '					MsgBox("Respecteer : " & vbCrLf & vbCrLf & "DD/MM/EEJJ - DD/MM/EEJJ a.u.b. !")
        '					TekstLijn(0).Text = BJPERDAT.PeriodeBoekjaar.Text
        '					TekstLijn(0).Focus()
        '					Exit Sub
        '				Else
        '					PeriodFromChosen.Value = Mid(TekstLijn(0).Text, 7, 4) & Mid(TekstLijn(0).Text, 4, 2) & Mid(TekstLijn(0).Text, 1, 2)
        '					PeriodToChosen.Value = Mid(TekstLijn(0).Text, 20, 4) & Mid(TekstLijn(0).Text, 17, 2) & Mid(TekstLijn(0).Text, 14, 2)
        '					KeuzeInfo(0).Items.Clear()
        '					For T = 0 To 9
        '						JetGet(TABLE_LEDGERACCOUNTS, 0, RekeningNummer(T))
        '						If KTRL Then
        '							A = RekeningNummer(T) & Chr(124) & "Niet aanwezig. Setup Boekjaar!"
        '						Else
        '							RecordToField(TABLE_LEDGERACCOUNTS)
        '							A = RekeningNummer(T) & Chr(124) & RTrim(AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #"))
        '						End If
        '						JetGetFirst(TABLE_JOURNAL, 0)
        '						JetGetOrGreater(TABLE_JOURNAL, 0, RekeningNummer(T) & PeriodFromChosen.Value)
        '						If KTRL Then
        '						Else
        '							If KEY_BUF(TABLE_JOURNAL) > RekeningNummer(T) & PeriodToChosen.Value Then
        '							Else
        '								KeuzeInfo(0).Items.Add(A)
        '							End If
        '						End If
        '					Next 
        '					If KeuzeInfo(0).Items.Count Then KeuzeInfo(0).SelectedIndex = 0
        '				End If

        '			Case 1
        '				If DateWrongFormat(TekstLijn(1).Text) Then
        '					Beep()
        '					TekstLijn(1).Text = MIM_GLOBAL_DATE.Value
        '					TekstLijn(1).Focus()
        '				End If
        '			Case 3
        '				TekstLijn(3).Text = VB6.Format(Val(TekstLijn(3).Text), "00000")
        '		End Select

    End Sub

    Private Sub BtnGenerateReport_Click(sender As Object, e As EventArgs) Handles BtnGenerateReport.Click

        '		Dim Printer As New Printer
        '		Dim bModDummy As Short
        '		Dim TelUittreksel As Short
        '		Dim DCBedrag As Decimal
        '		Dim HetBedrag As Decimal
        '		Dim XX As Short

        '		Dim FinRekening As New VB6.FixedLengthString(7)
        '		Dim DeRekening As New VB6.FixedLengthString(7)

        '		On Error GoTo PrtHandler9

        '		ReportText(2) = "Financiëel Boek " & Mid(Mim.Text, InStr(Mim.Text, "["))
        '		ReportText(0) = TekstLijn(1).Text
        '		ReportText(3) = VB.Right(KeuzeInfo(0).Text, 40) & " " & TekstLijn(0).Text

        '		ErrorMsg = ""
        '		TotalDebit = 0
        '		TotalCredit = 0
        '		PAGE_COUNTER = 0

        '		If UittrekselsLijst.Items.Count = 0 Then
        '			Exit Sub
        '		Else
        '			InitialiseFields()
        '			JetTableClose(TABLE_DUMMY)
        '			ClearFlDummy()
        '			KTRL = JetTableOpen(TABLE_DUMMY)

        '			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        '			If chkAfdrukInVenster.CheckState = 0 Then
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
        '					Printer.FontBold = True
        '				End If
        '			End If
        '			VpePrintHeader()
        '		End If

        '		For TelUittreksel = 0 To UittrekselsLijst.Items.Count - 1
        '			UittrekselsLijst.SelectedIndex = TelUittreksel
        '			FieldText(0) = Mid(UittrekselsLijst.Text, 12, 10)
        '			FieldText(1) = VB.Left(KeuzeInfo(0).Text, 7)
        '			FinRekening.Value = FieldText(1)
        '			FieldText(2) = Mid(UittrekselsLijst.Text, 25, 30)
        '			FieldText(3) = "DS/CS Saldo van het uittreksel"

        '			FieldText(4) = Mid(UittrekselsLijst.Text, 56, 12)
        '			FieldText(5) = Mid(UittrekselsLijst.Text, 69, 12)
        '			FieldText(6) = VB.Left(UittrekselsLijst.Text, 8)
        '			DeRekening.Value = FieldText(1)
        '			HetBedrag = -Val(FieldText(5)) + Val(FieldText(4))
        '			Select Case HetBedrag
        '				Case Is < 0
        '					TotalCredit = TotalCredit + HetBedrag
        '				Case Else
        '					TotalDebit = TotalDebit + HetBedrag
        '			End Select
        '			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '			GoSub CumulUpdate
        '			VpePrintLines()
        '			If TelUittreksel = UittrekselsLijst.Items.Count - 1 Then
        '				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '				GoSub DetailPrintJournaal
        '			ElseIf VB.Left(VB6.GetItemString(UittrekselsLijst, TelUittreksel), 21) = VB.Left(VB6.GetItemString(UittrekselsLijst, TelUittreksel + 1), 21) Then 
        '				ErrorMsg = ErrorMsg & VB.Left(VB6.GetItemString(UittrekselsLijst, TelUittreksel), 21) & " / " & VB.Left(VB6.GetItemString(UittrekselsLijst, TelUittreksel + 1), 21) & " onlogica." & vbCrLf
        '			Else
        '				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '				GoSub DetailPrintJournaal
        '			End If
        '		Next 
        '		PrintTotal()
        '		CumulPrint()
        '		If FieldText(4) = FieldText(5) Then
        '			If ErrorMsg <> "" Then
        '				ErrorMsg = vbCrLf & vbCrLf & "Er zijn uittreksel onjuist ingebracht.  De boekhouding blijft gelukkig correct" & vbCrLf & vbCrLf & ErrorMsg
        '			End If
        '		Else
        '			ErrorMsg = ErrorMsg & "DEBET<>CREDIT : de boekhoudDATABASE instabiel ?  Dient geRESTORED te worden !!!" & vbCrLf & vbCrLf
        '		End If

        '		If ErrorMsg <> "" Then
        '			Printer.Write(vbCrLf & vbCrLf)
        '			Printer.Write(ErrorMsg & vbCrLf & vbCrLf)
        '			Printer.Write("De gebruiker doet er goed aan steeds te kontroleren :" & vbCrLf)
        '			Printer.Write("* Eén Bankuittreksels pér UITTREKSELDATUM !" & vbCrLf)
        '			Printer.Write("* Steeds datum kontroleren vooraleer weg te schrijven !!!" & vbCrLf & vbCrLf)
        '			Printer.Print("Indien DEBET=CREDIT is de boekhouding toch correct bijgewerkt en hoeft U voor huidige onregelmatigheden")
        '			Printer.Print("niets recht te zetten")
        '		End If
        '		Printer.EndDoc()
        '		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        '		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = vbNormal
        '		Annuleren_Click(Annuleren, New System.EventArgs())
        '		Exit Sub

        'DetailPrintJournaal: 
        '		JetGet(TABLE_JOURNAL, 2, VB.Left(UittrekselsLijst.Text, 8))
        '		If KTRL Or KEY_BUF(TABLE_JOURNAL) <> VB.Left(UittrekselsLijst.Text, 8) Then
        '			Beep()
        '			MsgBox("onlogische situatie")
        '			Exit Sub
        '		Else
        '			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '			GoSub PrintInfo
        '		End If
        '		Do 
        '			bNext(TABLE_JOURNAL)
        '			If KTRL Or KEY_BUF(TABLE_JOURNAL) <> VB.Left(UittrekselsLijst.Text, 8) Then
        '				Exit Do
        '			Else
        '				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '				GoSub PrintInfo
        '			End If
        '		Loop 
        '		Printer.Write(vbCrLf)
        '		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		Return 

        'PrintInfo: 
        '		RecordToField(TABLE_JOURNAL)
        '		If SetSpacing(AdoGetField(TABLE_JOURNAL, "#v019 #"), 7) = VB.Left(KeuzeInfo(0).Text, 7) Then
        '			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '			Return 
        '		ElseIf FunctionDateText(AdoGetField(TABLE_JOURNAL, "#v066 #")) <> Mid(UittrekselsLijst.Text, 12, 10) Then 
        '			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '			Return 
        '		ElseIf RTrim(AdoGetField(TABLE_JOURNAL, "#v019 #")) <> "" Then 
        '			If SetSpacing(AdoGetField(TABLE_JOURNAL, "#v069 #"), 7) <> VB.Left(KeuzeInfo(0).Text, 7) Then
        '				'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '				Return 
        '			End If
        '		End If

        '		FieldText(0) = ""
        '		FieldText(1) = AdoGetField(TABLE_JOURNAL, "#v019 #")
        '		JetGet(TABLE_LEDGERACCOUNTS, 0, SetSpacing(FieldText(1), 7))
        '		If KTRL Then
        '			FieldText(2) = "Reeds vernietigd..."
        '		Else
        '			RecordToField(TABLE_LEDGERACCOUNTS)
        '			FieldText(2) = AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #")
        '		End If
        '		FieldText(3) = AdoGetField(TABLE_JOURNAL, "#v067 #")
        '		DCBedrag = Val(AdoGetField(TABLE_JOURNAL, "#v068 #"))
        '		Select Case DCBedrag
        '			Case Is < 0
        '				TotalCredit = TotalCredit + DCBedrag
        '				FieldText(4) = ""
        '				FieldText(5) = Dec(System.Math.Abs(DCBedrag), MASK_EURBH)
        '			Case Else
        '				TotalDebit = TotalDebit + DCBedrag
        '				FieldText(4) = Dec(DCBedrag, MASK_EURBH)
        '				FieldText(5) = ""
        '		End Select
        '		FieldText(6) = AdoGetField(TABLE_JOURNAL, "#v033 #")
        '		DeRekening.Value = FieldText(1)
        '		HetBedrag = DCBedrag
        '		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '		GoSub CumulUpdate
        '		VpePrintLines()
        '		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		Return 

        'PrtHandler9: 
        '		MsgBox("Kontroleer de printer.")
        '		Printer.KillDoc()
        '		Me.Close()
        '		Exit Sub
        '		Resume 

        'CumulUpdate: 
        'StartPunt: 
        '		JetGet(TABLE_DUMMY, 0, SetSpacing(DeRekening.Value, 20))
        '		If KTRL Then
        '			TLB_RECORD(TABLE_DUMMY) = ""
        '			AdoInsertToRecord(TABLE_DUMMY, DeRekening.Value, "v089")
        '			AdoInsertToRecord(TABLE_DUMMY, "0", "v013")
        '			AdoInsertToRecord(TABLE_DUMMY, "0", "v068")
        '			JetInsert(TABLE_DUMMY, 0)
        '			GoTo StartPunt
        '		Else
        '			RecordToField(TABLE_DUMMY)
        '			AdoInsertToRecord(TABLE_DUMMY, Str(Val(AdoGetField(TABLE_DUMMY, "#v013 #")) + 1), "v013")
        '			AdoInsertToRecord(TABLE_DUMMY, Str(Val(AdoGetField(TABLE_DUMMY, "#v068 #")) + HetBedrag), "v068")
        '			bUpdate(TABLE_DUMMY, 0)
        '		End If
        '		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		Return 



    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click

        Me.Close()

    End Sub

End Class

