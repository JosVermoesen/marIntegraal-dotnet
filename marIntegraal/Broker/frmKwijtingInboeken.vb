Imports System.ComponentModel

Public Class KwijtingInboeken
    Private Sub Annuleren_Click(sender As Object, e As EventArgs) Handles Annuleren.Click
        Close
    End Sub

    Private Sub KwijtingInboeken_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Mim.BookingReceiptMenuItem.Enabled = True 
    End Sub

    Private Sub KwijtingInboeken_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class KwijtingBoeken
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Dim dokumentSleutel As New VB6.FixedLengthString(11)
'	Dim KlantenRekening As New VB6.FixedLengthString(7)

'	Dim RekBeheersKost As New VB6.FixedLengthString(7)

'	Dim rsTB2 As ADODB.Recordset

'	Sub VraagWijzigingBoeken()
'		Dim Tel As Short
'		Dim TempoString As String
'		Dim TempoString9 As String

'		Dim Maatschappij As New VB6.FixedLengthString(4)
'		Dim Operatie As Short
'		Dim KopijString As String

'		MsgBox(GRIDTEXT_POLICY)
'		MSG = "Wijzigingen in rekeninguittreksels invoegen" & vbCrLf
'		MSG = MSG & "Bent U zeker ?"
'		KTRL = MsgBox(MSG, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question)
'		If KTRL = MsgBoxResult.No Then
'			Exit Sub
'		Else
'			'UPGRADE_WARNING: Couldn't resolve default property of object GRIDTEXT_POLICY. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			TempoString = Mid(GRIDTEXT_POLICY, 1, InStr(GRIDTEXT_POLICY, vbCrLf) - 1)
'			Maatschappij.Value = Mid(TempoString, 1, InStr(TempoString, vbTab) - 1)
'			KeuzeInfo(0).SelectedIndex = -1
'			For Tel = 0 To KeuzeInfo(0).Items.Count - 1
'				If Maatschappij.Value = VB.Left(VB6.GetItemString(KeuzeInfo(0), Tel), 4) Then
'					KeuzeInfo(0).Enabled = False
'					KeuzeInfo(0).SelectedIndex = Tel
'					Exit For
'				End If
'			Next 
'			If KeuzeInfo(0).SelectedIndex = -1 Then MsgBox("Maatschappij " & Maatschappij.Value & " niet aanwezig !:exit sub")

'			Operatie = Val(VB.Right(TempoString, 1))
'			KeuzeInfo(1).SelectedIndex = Operatie
'			KeuzeInfo(1).Enabled = False
'			'Eerste erbijvoegen
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub VoegHetErBij

'			Do 
'				'UPGRADE_WARNING: Couldn't resolve default property of object GRIDTEXT_POLICY. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'				GRIDTEXT_POLICY = VB.Right(GRIDTEXT_POLICY, Len(GRIDTEXT_POLICY) - (Len(TempoString) + 2))
'				'UPGRADE_WARNING: Couldn't resolve default property of object GRIDTEXT_POLICY. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'				If GRIDTEXT_POLICY = "" Then
'					'UPGRADE_WARNING: Couldn't resolve default property of object GRIDTEXT_POLICY. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					GRIDTEXT_POLICY = KopijString
'					Exit Do
'				Else
'					'UPGRADE_WARNING: Couldn't resolve default property of object GRIDTEXT_POLICY. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					TempoString = Mid(GRIDTEXT_POLICY, 1, InStr(GRIDTEXT_POLICY, vbCrLf) - 1)
'					If VB.Left(TempoString, 4) = Maatschappij.Value And Operatie = Val(VB.Right(TempoString, 1)) Then
'						'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'						GoSub VoegHetErBij
'					Else
'						KopijString = KopijString & TempoString & vbCrLf
'					End If
'				End If

'			Loop 
'			PolisDetail.Enabled = True
'			TekstInfo(0).Text = VB.Left(BJPERDAT.PeriodeBoekjaar.Text, 10)
'			'TekstInfo(0).Enabled = False
'			'KeuzeInfo(0).ListIndex = 0
'			Afsluiten.Enabled = True
'			Schoonvegen.Enabled = False
'		End If
'		Exit Sub

'VoegHetErBij: 
'		TempoString9 = Mid(TempoString, InStr(TempoString, vbTab) + 1)
'		TempoString9 = VB.Left(TempoString9, Len(TempoString9) - 2)
'		PolisDetail.AddItem(TempoString9, PolisDetail.Rows - 1)
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'	End Sub

'	Private Sub Afsluiten_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Afsluiten.Click
'		Dim MSG As String
'		Dim aa As New VB6.FixedLengthString(30)
'		Dim TotaalPremie As Decimal
'		Dim TotaalLoon As Decimal
'		Dim T As Short
'		Dim DummySleutel As String

'		If dokumentSleutel.Value <> SleutelDok(121) Then
'			MSG = dokumentSleutel.Value & " <> " & SleutelDok(121) & vbCrLf & vbCrLf
'			MSG = MSG & "MOGELIJKHEID 1: Teller is identiek, boekjaar is hoger/lager." & vbCrLf
'			MSG = MSG & "U hebt dus het actief boekjaar of periode gewijzigd tijdens de aanmaak van dit dokument.  Probeer nogmaals NA KONTROLE." & vbCrLf & vbCrLf
'			MSG = MSG & "MOGELIJKHEID 2: Boekjaar is identiek, teller is hoger/lager." & vbCrLf
'			MSG = MSG & "Een andere gebruiker heeft ondertussen een dokument verwerkt." & vbCrLf & vbCrLf
'			MSG = MSG & "Kontroleer eerst eens vooraleer de boeking nogmaals uit te voeren a.u.b. !!!"
'			MsgBox(MSG)
'			dokumentSleutel.Value = SleutelDok(121)
'			Me.Text = "Kwijtschriften beginnende (" & dokumentSleutel.Value & ")"
'			Exit Sub
'		End If

'		If Not IsDateOk(TekstInfo(0).Text, PERIODAS_TEXT) Then
'			Beep()
'			BJPERDAT.WindowState = System.Windows.Forms.FormWindowState.Normal
'			BJPERDAT.PeriodeBoekjaar.Focus()
'			Exit Sub
'		End If

'		For T = 1 To PolisDetail.Rows - 2
'			PolisDetail.Row = T
'			PolisDetail.Col = 2
'			TotaalPremie = TotaalPremie + Val(PolisDetail.Text)
'			PolisDetail.Col = 3
'			TotaalLoon = TotaalLoon + Val(PolisDetail.Text)
'			PolisDetail.Col = 4
'			If InStr(PolisDetail.Text, "Kontroleer") Then
'				MsgBox("Line " & VB6.Format(PolisDetail.Row - 2) & " kontroleren a.u.b. !")
'				Exit Sub
'			End If
'		Next 

'		MSG = RTrim(KeuzeInfo(1).Text) & " van" & vbCrLf
'		MSG = MSG & RTrim(KeuzeInfo(0).Text) & vbCrLf & vbCrLf
'		MSG = MSG & "Totaal premie(s) : " & Dec(TotaalPremie, MASK_EURBH) & vbCrLf
'		MSG = MSG & "Totaal loon : " & Dec(TotaalLoon, MASK_EURBH) & vbCrLf
'		MSG = MSG & "Boekdatum : " & TekstInfo(0).Text
'		KTRL = MsgBox(MSG, 292, "Afboeken " & VB.Right(dokumentSleutel.Value, 5) & " tot " & VB6.Format(Val(VB.Right(dokumentSleutel.Value, 5)) + PolisDetail.Rows - 3, "00000") & " ?")
'		If KTRL = MsgBoxResult.No Then
'			Exit Sub
'		End If

'		KTRL = JetTableOpen(TABLE_LEDGERACCOUNTS)
'		KTRL = JetTableOpen(TABLE_JOURNAL)
'		KTRL = JetTableOpen(TABLE_INVOICES)
'		TransBegin()
'		If WegBoekFout() Then
'			TransAbort()
'			Exit Sub
'		Else
'			TransCommit()
'			SS99(VB.Right(dokumentSleutel.Value, 5), 121)
'			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			If Dir(LOCATION_ASWEB & "AS1.RCV") <> "" Then
'				RasterSchoon()
'				Annuleren_Click(Annuleren, New System.EventArgs())
'				Exit Sub
'			Else
'				dokumentSleutel.Value = SleutelDok(121)
'				Me.Text = "Kwijtschriften beginnende (" & dokumentSleutel.Value & ")"
'				SchoonVegen_Click(SchoonVegen, New System.EventArgs())
'			End If
'		End If
'		'UPGRADE_WARNING: Couldn't resolve default property of object GRIDTEXT_POLICY. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		If GRIDTEXT_POLICY <> "" Then
'			VraagWijzigingBoeken()
'		End If

'	End Sub

'	Private Sub Annuleren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Annuleren.Click

'		If PolisDetail.Rows > 2 Then
'			MSG = "Aangeduide verrichtingen negeren." & vbCrLf & vbCrLf & "Bent U zeker ?"
'			KTRL = MsgBox(MSG, 292, "Voortijdig stoppen...")
'			If KTRL = 6 Then
'			Else
'				Exit Sub
'			End If
'		End If
'		GRIDTEXT = ""
'		Me.Close()

'	End Sub

'	'UPGRADE_WARNING: Event cbPolisHistoriek.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub cbPolisHistoriek_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbPolisHistoriek.SelectedIndexChanged

'		Dim MAPIString As String

'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'		rsTB2.AbsolutePosition = Me.cbPolisHistoriek.SelectedIndex + 1
'		MAPIString = rsTB2.Fields("memoTB2").Value
'		If Me.cbHerboeking.CheckState = 1 Then
'			strTELEBIBIO = MAPIString
'			MsgBox(strTELEBIBIO)
'		Else
'			strTELEBIBIO = ""
'		End If
'		Me.rtbIndentTB2.Text = tb2Indent(MAPIString)
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal

'	End Sub


'	'UPGRADE_WARNING: Event cbTB2ktrl.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub cbTB2ktrl_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbTB2ktrl.CheckStateChanged

'		If Me.cbTB2ktrl.CheckState = System.Windows.Forms.CheckState.Checked Then
'			Me.cbBoekDatum.Visible = True
'			Me.mebBoekDatum.Visible = True
'			Me.mebBoekDatum.Enabled = True
'			'UPGRADE_WARNING: ClipText has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			If Me.mebBoekDatum.Text = "" Then
'				Me.mebBoekDatum.Text = VB6.Format(Now, "mm/yyyy")
'				Me.cbBoekDatum.CheckState = System.Windows.Forms.CheckState.Checked
'			End If
'		Else
'			Me.cbBoekDatum.Visible = False
'			Me.mebBoekDatum.Visible = False
'		End If

'		Me.cbPolisHistoriek.Items.Clear()
'		SSTab2.TabPages.Item(1).Text = "&TB2= (0)"
'		Me.rtbIndentTB2.Text = ""

'		Dim MsgNoZero As String


'		Select Case cbTB2ktrl.CheckState
'			Case System.Windows.Forms.CheckState.Unchecked
'				'niks

'			Case System.Windows.Forms.CheckState.Checked
'				'nu eerst nog TB2controle
'				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'				If rsTB2.State = ADODB.ObjectStateEnum.adStateOpen Then
'					rsTB2.Close()
'				End If
'				MSG = "SELECT * FROM TB2 WHERE memoTB2 Like '%PTY+006+" & VB.Left(KeuzeInfo(0).Text, 4) & "+%'"
'				MsgNoZero = "SELECT * FROM TB2 WHERE memoTB2 Like '%PTY+006+" & Trim(Str(Val(VB.Left(KeuzeInfo(0).Text, 4)))) & "+%'"
'				'PTY+006+0739+
'				If Me.cbBoekDatum.CheckState = System.Windows.Forms.CheckState.Checked Then
'					'UPGRADE_WARNING: ClipText has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'					MSG = MSG & " AND memoTB2 Like '%DTM+005:" & Me.mebBoekDatum.Text & ":005" & "%'"
'					'UPGRADE_WARNING: ClipText has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'					MsgNoZero = MsgNoZero & " AND memoTB2 Like '%DTM+005:" & Me.mebBoekDatum.Text & ":005" & "%'"
'				End If

'				Me.cbPolisHistoriek.Items.Clear()
'				rsTB2.Open(MSG, AD_NTDB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
'				If rsTB2.RecordCount > 0 Then
'					SSTab2.TabPages.Item(1).Text = "&TB2= (" & Trim(Str(rsTB2.RecordCount)) & ")"
'					Do While Not rsTB2.EOF
'						'strTB2 = rsTB2("memoTB2").Value
'						Me.cbPolisHistoriek.Items.Add("DocType=" & rsTB2.Fields("DocType").Value & " Aanvang=" & rsTB2.Fields("DatumAanvang").Value)
'						rsTB2.MoveNext()
'					Loop 
'				Else
'					If rsTB2.State = ADODB.ObjectStateEnum.adStateOpen Then
'						rsTB2.Close()
'					End If
'					rsTB2.Open(MsgNoZero, AD_NTDB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
'					If rsTB2.RecordCount > 0 Then
'						SSTab2.TabPages.Item(1).Text = "&TB2= (" & Trim(Str(rsTB2.RecordCount)) & ")"
'						Do While Not rsTB2.EOF
'							'strTB2 = rsTB2("memoTB2").Value
'							Me.cbPolisHistoriek.Items.Add("DocType=" & rsTB2.Fields("DocType").Value & " Aanvang=" & rsTB2.Fields("DatumAanvang").Value)
'							rsTB2.MoveNext()
'						Loop 
'					End If
'				End If
'				'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'				'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'				System.Windows.Forms.Cursor.Current = vbNormal
'		End Select

'	End Sub

'	Private Sub KwijtingBoeken_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
'		Dim beheersforfait As Short

'		If Not Toegankelijk(Me) Then
'			Me.Close()
'			Exit Sub
'		End If

'		rsTB2 = New ADODB.Recordset
'		rsTB2.CursorLocation = ADODB.CursorLocationEnum.adUseClient


'		KTRL = ktrlRVmemo


'		Dim LijnPos As Short
'		Dim TotaalPremie As Decimal
'		Dim TotaalLoon As Decimal

'		Dim LijnErBij As String
'		Dim BeheerForfait As Decimal
'		Dim BedragFee As Decimal
'		Dim tbBeheerForfait As Decimal

'		PolisDetail.Cols = 7
'		With PolisDetail
'			.Col = 0
'			.Row = 0
'			.Text = "Polisnummer"
'			.set_ColWidth(0, 1215)

'			.Col = 1
'			.Text = "Datum"
'			.set_ColWidth(1, 1005)

'			.Col = 2
'			.Text = "Totale premie"
'			.set_ColWidth(2, 1035)
'			.set_ColAlignment(2, 1)

'			.Col = 3
'			.Text = "Loon"
'			.set_ColWidth(3, 795)
'			.set_ColAlignment(3, 1)

'			.Col = 4
'			.Text = "Klant (Naam 1)"
'			.set_ColWidth(4, 1600)

'			.Col = 5
'			.Text = "XML/TLB2 Snippet"
'			.set_ColWidth(5, 1095)

'			.Col = 6
'			.Text = "Fee"
'			.set_ColWidth(6, 1035)

'		End With

'		'UPGRADE_ISSUE: DoEvents does not return a value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8D115264-E27F-4472-A684-865A00B5E826"'
'		XDO_EVENTS = System.Windows.Forms.Application.DoEvents()
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'		InstallMij()

'		On Error Resume Next
'		RekBeheersKost.Value = String99(READING, 289)
'		On Error Resume Next
'		tbBeheerForfait = CDec(String99(READING, 288))

'		KeuzeInfo(0).SelectedIndex = 0
'		KeuzeInfo(1).Items.Add("0: Kies eerst bewerkingskode !")
'		KeuzeInfo(1).Items.Add("1: Termijn")
'		KeuzeInfo(1).Items.Add("2: Kontant")
'		KeuzeInfo(1).Items.Add("3: Terugbetaling van de premies")
'		KeuzeInfo(1).Items.Add("4: Vernietiging van verrichting")
'		KeuzeInfo(1).Items.Add("5: Terugzending van kwitanties")
'		KeuzeInfo(1).Items.Add("6: Commissielonen")
'		KeuzeInfo(1).Items.Add("7: Schadegevallen")
'		KeuzeInfo(0).SelectedIndex = 0
'		KeuzeInfo(1).SelectedIndex = 0
'		dokumentSleutel.Value = SleutelDok(121)
'		Me.Text = "Kwijtschriften beginnende (" & dokumentSleutel.Value & ")"

'		KlantenRekening.Value = LTrim(RTrim(String99(READING, 9)))

'		Dim arrayGTI() As String
'		Dim arrayGridLines() As String
'		Dim arrayGridCols() As String
'		Dim TelTotLines As Short
'		Dim TelTotCols As Short

'		If GRIDTEXT <> "" Then
'			arrayGTI = Split(GRIDTEXT_IS, vbTab)
'			Select Case arrayGTI(0)
'				Case "001"
'					KeuzeInfo(1).SelectedIndex = 1
'				Case "002"
'					KeuzeInfo(1).SelectedIndex = 2
'				Case "003"
'					KeuzeInfo(1).SelectedIndex = 3
'				Case "006"
'					KeuzeInfo(1).SelectedIndex = 6
'				Case Else
'					MsgBox("Typeboeking logica nog te voorzien voor " & arrayGTI(0))
'			End Select
'			arrayGridLines = Split(GRIDTEXT, Chr(13))
'			For TelTotLines = 0 To UBound(arrayGridLines) - 1
'				arrayGridCols = Split(arrayGridLines(TelTotLines), vbTab)
'				TotaalPremie = TotaalPremie + Val(arrayGridCols(2))
'				TotaalLoon = TotaalLoon + Val(arrayGridCols(3))
'				If KeuzeInfo(1).SelectedIndex = 1 Then
'					BeheerForfait = tbBeheerForfait
'				Else
'					beheersforfait = 0
'				End If
'				JetGet(TABLE_CONTRACTS, 0, Trim(arrayGridCols(0)))
'				If KTRL Then
'					MsgBox("logicafout", MsgBoxStyle.Critical)
'				Else
'					RecordToField(TABLE_CONTRACTS)
'				End If

'				'KTRL = BeheersKost(Trim(Mid(GRIDTEXT, 1, 12)), BeheerForfait)
'				LijnErBij = arrayGridCols(0) & vbTab & arrayGridCols(1) & vbTab & arrayGridCols(2) & vbTab & arrayGridCols(3) & vbTab & arrayGridCols(4) & vbTab & arrayGridCols(5)

'				If KeuzeInfo(1).SelectedIndex = 6 Then
'					LijnErBij = LijnErBij & vbTab & "0"
'				Else
'					If RS_MAR(TABLE_CONTRACTS).Fields("e070").Value = "1" Then
'						BedragFee = Val(arrayGridCols(6)) * Val(RS_MAR(TABLE_CONTRACTS).Fields("e071").Value) / 100
'						LijnErBij = LijnErBij & vbTab & Str(BedragFee)
'						'dit is een met FEE berekening!
'					Else
'						If Trim(RS_MAR(TABLE_CONTRACTS).Fields("e069").Value) = "" Then
'							LijnErBij = LijnErBij & vbTab & BeheerForfait
'						Else
'							LijnErBij = LijnErBij & vbTab & Val(RS_MAR(TABLE_CONTRACTS).Fields("e069").Value)
'						End If
'					End If
'				End If

'				PolisDetail.AddItem(LijnErBij, PolisDetail.Rows - 1)
'				'GRIDTEXT = Right(GRIDTEXT, Len(GRIDTEXT) - LijnPos)
'			Next 
'			'LabelInfo(0).Caption = Dec$((TotaalPremie), "#########0")
'			'LabelInfo(1).Caption = Dec$((TotaalLoon), "#########0")
'			PolisDetail.Enabled = True
'			If arrayGTI(2) = "Termijn" Then
'				TekstInfo(0).Text = VB.Left(BJPERDAT.PeriodeBoekjaar.Text, 10)
'			ElseIf arrayGTI(2) = "Commissies" Then 
'				TekstInfo(0).Text = VB.Right(BJPERDAT.PeriodeBoekjaar.Text, 10)
'			Else
'				TekstInfo(0).Text = arrayGTI(3)
'			End If
'			TekstInfo(0).Enabled = False
'			KeuzeInfo(1).Enabled = False
'			KeuzeInfo(0).SelectedIndex = 0
'			Do While VB.Left(KeuzeInfo(0).Text, 4) <> "9000"
'				If Mid(GRIDTEXT_IS, 5, 4) = VB.Left(KeuzeInfo(0).Text, 4) Then
'					KeuzeInfo(0).Enabled = False
'					Exit Do
'				Else
'					KeuzeInfo(0).SelectedIndex = KeuzeInfo(0).SelectedIndex + 1
'				End If
'			Loop 
'			Afsluiten.Enabled = True
'			Schoonvegen.Enabled = False
'			'UPGRADE_WARNING: Couldn't resolve default property of object GRIDTEXT_POLICY. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		ElseIf GRIDTEXT_POLICY <> "" Then 
'			VraagWijzigingBoeken()
'		Else
'			Schoon()
'		End If
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal

'	End Sub

'	Private Sub KwijtingBoeken_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

'		BJPERDAT.Boekjaar.Enabled = True
'		GRIDTEXT = ""

'	End Sub

'	Private Sub InstallMij()
'		Dim T As Short

'		KeuzeInfo(0).Items.Clear()
'		T = -1
'		JetGetOrGreater(TABLE_SUPPLIERS, 0, SetSpacing("CO", 12))
'		If KTRL Then
'			Beep()
'			Exit Sub
'		Else
'			RecordToField(TABLE_SUPPLIERS)
'		End If
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'		If VB.Left(KEY_BUF(TABLE_SUPPLIERS), 2) <> "CO" Then
'			Beep()
'		Else
'			T = T + 1
'			KeuzeInfo(0).Items.Add(Mid(AdoGetField(TABLE_SUPPLIERS, "#A110 #"), 3, 4) & ": " & AdoGetField(TABLE_SUPPLIERS, "#A100 #") & "/" & SetSpacing(AdoGetField(TABLE_SUPPLIERS, "#A400 #"), 8))
'			Do 
'				bNext(TABLE_SUPPLIERS)
'				If KTRL Or VB.Left(KEY_BUF(TABLE_SUPPLIERS), 2) <> "CO" Then
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

'	End Sub

'	Private Sub InstallPolissen()
'		Dim Zoekstring As New VB6.FixedLengthString(24)
'		Dim Maatschappij As New VB6.FixedLengthString(4)
'		Dim Dummy As New VB6.FixedLengthString(30)

'		Zoekstring.Value = Mid(TekstInfo(0).Text, 4, 2)
'		Maatschappij.Value = VB.Left(KeuzeInfo(0).Text, 4)
'		JetGetOrGreater(TABLE_CONTRACTS, 3, Zoekstring.Value)
'		If KTRL Or VB.Left(KEY_BUF(TABLE_CONTRACTS), 2) <> VB.Left(Zoekstring.Value, 2) Then
'			Beep()
'			Exit Sub
'		ElseIf Maatschappij.Value = Mid(KEY_BUF(TABLE_CONTRACTS), 15, 4) Then 
'			RecordToField(TABLE_CONTRACTS)
'			Select Case VB.Left(AdoGetField(TABLE_CONTRACTS, "#vs97 #"), 1)
'				Case "0", "7", "9"
'				Case Else
'					JetGet(TABLE_CUSTOMERS, 0, AdoGetField(TABLE_CONTRACTS, "#A110 #"))
'					If KTRL Then
'						Dummy.Value = "KlantLink onmogelijk !!! Kontroleer !!!"
'					Else
'						RecordToField(TABLE_CUSTOMERS)
'						Dummy.Value = AdoGetField(TABLE_CUSTOMERS, "#A100 #")
'					End If
'					PolisDetail.AddItem(AdoGetField(TABLE_CONTRACTS, "#A000 #") & vbTab & Mid(AdoGetField(TABLE_CONTRACTS, "#AW_2 #"), 7, 2) & "/" & Mid(AdoGetField(TABLE_CONTRACTS, "#AW_2 #"), 5, 2) & "/" & Mid(PERIOD_FROMTO.Value, 1, 4) & vbTab & vbTab & vbTab & Dummy.Value & vbTab & 0, PolisDetail.Rows - 1)
'			End Select
'		End If
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

'		Do 
'			bNext(TABLE_CONTRACTS)
'			If KTRL Or VB.Left(KEY_BUF(TABLE_CONTRACTS), 2) <> VB.Left(Zoekstring.Value, 2) Then
'				'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'				'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'				System.Windows.Forms.Cursor.Current = vbNormal
'				Exit Do
'			ElseIf Maatschappij.Value = Mid(KEY_BUF(TABLE_CONTRACTS), 15, 4) Then 
'				RecordToField(TABLE_CONTRACTS)
'				Select Case VB.Left(AdoGetField(TABLE_CONTRACTS, "#vs97 #"), 1)
'					Case "0", "7", "9"
'					Case Else
'						JetGet(TABLE_CUSTOMERS, 0, AdoGetField(TABLE_CONTRACTS, "#A110 #"))
'						If KTRL Then
'							Dummy.Value = "KlantLink onmogelijk !!! Kontroleer !!!"
'						Else
'							RecordToField(TABLE_CUSTOMERS)
'							Dummy.Value = AdoGetField(TABLE_CUSTOMERS, "#A100 #")
'						End If
'						PolisDetail.AddItem(AdoGetField(TABLE_CONTRACTS, "#A000 #") & vbTab & Mid(AdoGetField(TABLE_CONTRACTS, "#AW_2 #"), 7, 2) & "/" & Mid(AdoGetField(TABLE_CONTRACTS, "#AW_2 #"), 5, 2) & "/" & Mid(PERIOD_FROMTO.Value, 1, 4) & vbTab & vbTab & vbTab & Dummy.Value & vbTab & 0, PolisDetail.Rows - 1)
'				End Select
'			End If
'		Loop 

'	End Sub

'	'UPGRADE_WARNING: Event KeuzeInfo.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub KeuzeInfo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles KeuzeInfo.SelectedIndexChanged
'		Dim Index As Short = KeuzeInfo.GetIndex(eventSender)
'		Dim T As Short

'		Select Case Index
'			Case 0
'				JetGet(TABLE_SUPPLIERS, 0, SetSpacing("CO" & VB.Left(KeuzeInfo(0).Text, 4), 12))
'				If KTRL Then
'					'MsgBox "stop"
'				Else
'					RecordToField(TABLE_SUPPLIERS)
'				End If
'				JetGet(TABLE_LEDGERACCOUNTS, 0, SetSpacing(AdoGetField(TABLE_SUPPLIERS, "#v016 #"), 7))
'				If KTRL Then
'					MsgBox("stop voor rekening aan te maken!")
'					TLB_RECORD(TABLE_LEDGERACCOUNTS) = ""
'					AdoInsertToRecord(TABLE_LEDGERACCOUNTS, "700" & VB.Left(KeuzeInfo(0).Text, 4), "v019")
'					AdoInsertToRecord(TABLE_LEDGERACCOUNTS, AdoGetField(TABLE_SUPPLIERS, "#A100 #"), "v020")
'					JetInsert(TABLE_LEDGERACCOUNTS, 0)
'					TLB_RECORD(TABLE_LEDGERACCOUNTS) = ""
'					AdoInsertToRecord(TABLE_LEDGERACCOUNTS, "440" & VB.Left(KeuzeInfo(0).Text, 4), "v019")
'					AdoInsertToRecord(TABLE_LEDGERACCOUNTS, AdoGetField(TABLE_SUPPLIERS, "#A100 #"), "v020")
'					'FVT(TABLE_LEDGERACCOUNTS, 0) = "440" + Left(KeuzeInfo(0).Text, 4)
'					'FVT(TABLE_LEDGERACCOUNTS, 1) = FVT(TABLE_SUPPLIERS, 1)
'					JetInsert(TABLE_LEDGERACCOUNTS, 0)
'					AdoInsertToRecord(TABLE_SUPPLIERS, AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #"), "v016")
'					'FVT(TABLE_SUPPLIERS, 16) = FVT(TABLE_LEDGERACCOUNTS, 0)
'					bUpdate(TABLE_SUPPLIERS, 0)
'					LabelInfo(2).Text = AdoGetField(TABLE_SUPPLIERS, "#v016 #")
'				Else
'					LabelInfo(2).Text = AdoGetField(TABLE_SUPPLIERS, "#v016 #")
'				End If
'				If Me.cbTB2ktrl.CheckState = System.Windows.Forms.CheckState.Checked Then
'					cbTB2ktrl_CheckStateChanged(cbTB2ktrl, New System.EventArgs())
'				End If

'			Case 1
'				If KeuzeInfo(1).SelectedIndex = 0 Then
'					PolisDetail.Enabled = False
'				Else
'					PolisDetail.Enabled = True
'				End If
'		End Select

'	End Sub

'	Private Sub KeuzeInfo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles KeuzeInfo.Leave
'		Dim Index As Short = KeuzeInfo.GetIndex(eventSender)

'		Select Case Index
'			Case 1
'				If KeuzeInfo(1).SelectedIndex = 1 And PolisDetail.Rows = 2 Then
'					MSG = "Bestaande kontrakten met vervaldag voor de" & vbCrLf & Mid(TekstInfo(0).Text, 4, 2) & "e maand inladen ?"
'					KTRL = MsgBox(MSG, 292, "Polissen Termijn inladen")
'					If KTRL = 6 Then
'						InstallPolissen()
'					End If
'				End If
'		End Select
'	End Sub

'	Private Sub PolisDetail_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PolisDetail.ClickEvent

'		On Error Resume Next
'		With PolisDetail
'			.ColSel = .Cols - 1
'			'    .SelEndCol = 4
'			'    .SelStartRow = .Row
'			'    .SelEndRow = .Row
'		End With

'	End Sub

'	Private Sub PolisDetail_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PolisDetail.Enter

'		SnelHelpPrint("[+] lijn bijvoegen, [-] verwijderen, [Enter] om te wijzigen", BL_LOGGING)

'	End Sub

'	Private Sub PolisDetail_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_KeyPressEvent) Handles PolisDetail.KeyPressEvent
'		Dim Positie As Short
'		Dim TempoPremie As Integer
'		Dim TempoLoon As Integer

'		Positie = PolisDetail.Row
'		Select Case eventArgs.KeyAscii
'			Case 13, 43
'				If eventArgs.KeyAscii = 43 Then
'					PolisDetail.AddItem(vbTab & vbTab & vbTab & vbTab & vbTab, PolisDetail.Rows - 1)
'					PolisDetail.Row = PolisDetail.Rows - 2
'				ElseIf eventArgs.KeyAscii = 13 Then 
'					If Positie = PolisDetail.Rows - 1 Then
'						MsgBox("Druk [+] toets om bij te voegen !")
'						Exit Sub
'					End If
'				End If
'				'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
'				Load(BoekKwijtingEdit)
'				BoekKwijtingEdit.Text = VB.Left(KeuzeInfo(0).Text, 4) & ":" & KwijtingEdit.Text
'				BoekKwijtingEdit.ShowDialog()
'				Me.Activate()
'				If eventArgs.KeyAscii = 43 And GRIDTEXT = "ESC" Then
'					PolisDetail.RemoveItem(PolisDetail.Rows - 1)
'				End If

'			Case 43

'			Case 45, 127
'				If PolisDetail.Rows = 2 Then
'					Exit Sub
'				ElseIf Positie < 0 Then 
'					MsgBox("Eerst een lijn selekteren !", 0, "Line wijzigen")
'					Exit Sub
'				End If
'				PolisDetail.RemoveItem(Positie)
'				If PolisDetail.Rows - 1 > Positie + 1 Then
'					PolisDetail.Row = Positie - 1
'				End If
'				CType(Me.Controls("PolisDetail"), Object).Focus()
'			Case Else
'		End Select

'		If PolisDetail.Rows = 2 Then
'			Afsluiten.Enabled = False
'		Else
'			Afsluiten.Enabled = True
'		End If

'	End Sub

'	Private Sub RasterSchoon()

'		With PolisDetail
'			.Rows = 2
'			.Row = 1
'			.Col = 0
'			.Text = ""

'			.Col = 1
'			.Text = ""

'			.Col = 2
'			.Text = ""

'			.Col = 3
'			.Text = ""

'			.Col = 4
'			.Text = ""

'			.Col = 5
'			.Text = ""

'			.Col = 6
'			.Text = ""

'		End With

'	End Sub

'	Private Sub Schoon()
'		Dim T As Short

'		Afsluiten.Enabled = False
'		TekstInfo(0).Text = MIM_GLOBAL_DATE.Value
'		RasterSchoon()

'	End Sub

'	Private Sub PolisDetail_KeyUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_KeyUpEvent) Handles PolisDetail.KeyUpEvent

'		Select Case eventArgs.KeyCode
'			Case 37 To 40
'				PolisDetail_ClickEvent(PolisDetail, New System.EventArgs())
'		End Select

'	End Sub


'	Private Sub SchoonVegen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SchoonVegen.Click

'		Schoon()

'	End Sub



'	Private Sub TekstInfo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.Enter
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		TekstInfo(Index).SelectionStart = 0
'		TekstInfo(Index).SelectionLength = Len(TekstInfo(Index).Text)

'	End Sub

'	Private Sub TekstInfo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.Leave
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		Select Case Index
'			Case 0
'				If DateWrongFormat(TekstInfo(0).Text) Then
'					TekstInfo(0).Text = MIM_GLOBAL_DATE.Value
'					Beep()
'					TekstInfo(0).Focus()
'				ElseIf Not IsDateOk(TekstInfo(0).Text, PERIODAS_TEXT) Then 
'					Beep()
'					BJPERDAT.WindowState = System.Windows.Forms.FormWindowState.Normal
'					BJPERDAT.PeriodeBoekjaar.Focus()
'				End If
'		End Select

'	End Sub

'	Private Function WegBoekFout() As Short
'		Dim T As Short
'		Dim BakdokumentSleutel As New VB6.FixedLengthString(11)
'		Dim TempoDokSleutel As String
'		Dim dTotaalMij As Double
'		Dim dTotaalLoon As Double
'		Dim dTotaalBKost As Decimal
'		Dim BedragTotaal As Decimal

'		Dim BedragBeheer As Decimal
'		Dim TotaalBedragBeheer As Decimal

'		Dim Temporek As New VB6.FixedLengthString(7)

'		'On Local Error GoTo IetsGingFout

'		WegBoekFout = False
'		DKTRL_CUMUL = 0 : DKTRL_BEF = 0 : DKTRL_EUR = 0
'		BakdokumentSleutel.Value = dokumentSleutel.Value
'		frmBoeking.Close()
'		'frmBoeking.Hide
'		TLB_RECORD(TABLE_INVOICES) = ""
'		TLB_RECORD(TABLE_JOURNAL) = ""
'		'bijgevoegd voor scanning
'		If RS_MAR(TABLE_INVOICES).State = ADODB.ObjectStateEnum.adStateClosed Then
'			KTRL = JetTableOpen(TABLE_INVOICES)
'		End If

'		dTotaalMij = 0
'		dTotaalLoon = 0

'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'		For T = 1 To PolisDetail.Rows - 2
'			RS_MAR(TABLE_INVOICES).AddNew()
'			If BH_EURO Then
'				AdoInsertToRecord(TABLE_INVOICES, "EUR", "vs03")
'			Else
'				AdoInsertToRecord(TABLE_INVOICES, "BEF", "vs03")
'			End If
'			AdoInsertToRecord(TABLE_INVOICES, "1", "v040")
'			AdoInsertToRecord(TABLE_INVOICES, VB.Left(KeuzeInfo(1).Text, 1), "v041")

'			PolisDetail.Row = T
'			PolisDetail.Col = 0
'			JetGet(TABLE_CONTRACTS, 0, SetSpacing((PolisDetail.Text), 12))
'			If KTRL Then
'				MsgBox("Polisnummer " & PolisDetail.Text & vbCrLf & vbCrLf & "niet te vinden !")
'				WegBoekFout = True
'				dokumentSleutel.Value = BakdokumentSleutel.Value
'				Exit Function
'			Else
'				RecordToField(TABLE_CONTRACTS)
'				JetGet(TABLE_CUSTOMERS, 0, SetSpacing(AdoGetField(TABLE_CONTRACTS, "#A110 #"), 12))
'				If KTRL Then
'					MsgBox("Klantnummer " & AdoGetField(TABLE_CONTRACTS, "#A110 #") & " in lijn " & Str(PolisDetail.Row) & vbCrLf & vbCrLf & "niet te vinden !")
'					WegBoekFout = True
'					dokumentSleutel.Value = BakdokumentSleutel.Value
'					Exit Function
'				Else
'					AdoInsertToRecord(TABLE_JOURNAL, "K" & AdoGetField(TABLE_CONTRACTS, "#A110 #"), "v034")
'					AdoInsertToRecord(TABLE_INVOICES, "K" & AdoGetField(TABLE_CONTRACTS, "#A110 #"), "v034")
'					AdoInsertToRecord(TABLE_INVOICES, (PolisDetail.Text), "A000")
'					AdoInsertToRecord(TABLE_JOURNAL, KlantenRekening.Value, "v019")
'					AdoInsertToRecord(TABLE_JOURNAL, DatumKey(TekstInfo(0).Text), "v066")
'					AdoInsertToRecord(TABLE_JOURNAL, dokumentSleutel.Value, "v033")
'					AdoInsertToRecord(TABLE_INVOICES, dokumentSleutel.Value, "v033")
'					PolisDetail.Col = 1

'					AdoInsertToRecord(TABLE_JOURNAL, DatumKey((PolisDetail.Text)), "v035")
'					AdoInsertToRecord(TABLE_INVOICES, DatumKey((PolisDetail.Text)), "v035")
'					AdoInsertToRecord(TABLE_INVOICES, DatumKey((PolisDetail.Text)), "v036")
'					Select Case VB.Left(KeuzeInfo(1).Text, 1)
'						Case "1", "2", "6"
'							If VB.Left(KeuzeInfo(1).Text, 1) = "1" Then
'								AdoInsertToRecord(TABLE_CONTRACTS, Mid(DatumKey((PolisDetail.Text)), 5, 2), "v164")
'								AdoInsertToRecord(TABLE_CONTRACTS, Mid(DatumKey((PolisDetail.Text)), 7, 2), "v165")
'							End If
'							PolisDetail.Col = 4
'							AdoInsertToRecord(TABLE_JOURNAL, (PolisDetail.Text), "v067")

'							'nieuw voor beheer...
'							PolisDetail.Col = 6
'							If Trim(PolisDetail.Text) = "" Then
'								BedragBeheer = 0
'							Else
'								BedragBeheer = System.Math.Round(Val(PolisDetail.Text), 2)
'							End If
'							dTotaalBKost = dTotaalBKost + BedragBeheer

'							AdoInsertToRecord(TABLE_INVOICES, Str(BedragBeheer), "e069")
'							AdoInsertToRecord(TABLE_CONTRACTS, Str(BedragBeheer), "e069")

'							PolisDetail.Col = 5
'							'MsgBox "TODO: snipped document: " & PolisDetail.Text
'							If PolisDetail.Text = "" Then
'								RS_MAR(TABLE_INVOICES).Fields("rvXMLTB2").Value = ""
'							Else
'								RS_MAR(TABLE_INVOICES).Fields("rvXMLTB2").Value = PolisDetail.Text
'							End If

'							PolisDetail.Col = 2
'							BedragTotaal = BedragBeheer + Val(PolisDetail.Text)
'							AdoInsertToRecord(TABLE_JOURNAL, Str(BedragTotaal), "v068")
'							AdoInsertToRecord(TABLE_CONTRACTS, (PolisDetail.Text), "B010")
'							AdoInsertToRecord(TABLE_INVOICES, (PolisDetail.Text), "B010")
'							AdoInsertToRecord(TABLE_INVOICES, Str(BedragTotaal), "v249")

'							AdoInsertToRecord(TABLE_JOURNAL, LabelInfo(2).Text, "v069")
'							If BedragTotaal <> 0 Then
'								JetInsert(TABLE_JOURNAL, 0)
'							End If

'							Temporek.Value = LabelInfo(2).Text
'							Mid(Temporek.Value, 1, 2) = "70"
'							AdoInsertToRecord(TABLE_JOURNAL, Temporek.Value, "v019")

'							PolisDetail.Col = 3
'							AdoInsertToRecord(TABLE_JOURNAL, Str(-Val(PolisDetail.Text)), "v068")
'							AdoInsertToRecord(TABLE_CONTRACTS, (PolisDetail.Text), "B014")
'							AdoInsertToRecord(TABLE_INVOICES, (PolisDetail.Text), "B014")
'							If Val(PolisDetail.Text) <> 0 Then
'								If VB.Left(KeuzeInfo(1).Text, 1) = "1" Then
'									dTotaalLoon = dTotaalLoon - Val(PolisDetail.Text)
'								Else
'									JetInsert(TABLE_JOURNAL, 0)
'								End If
'							End If
'							AdoInsertToRecord(TABLE_JOURNAL, AdoGetField(TABLE_JOURNAL, "#v069 #"), "v019")
'							AdoInsertToRecord(TABLE_JOURNAL, " ", "v069")
'							AdoInsertToRecord(TABLE_JOURNAL, VB.Left(KeuzeInfo(1).Text, 1), "v041")

'							AdoInsertToRecord(TABLE_JOURNAL, Str(-(Val(AdoGetField(TABLE_INVOICES, "#B010 #")) - Val(AdoGetField(TABLE_INVOICES, "#B014 #")))), "v068")
'							If Val(AdoGetField(TABLE_JOURNAL, "#v068 #")) <> 0 Then
'								If VB.Left(KeuzeInfo(1).Text, 1) = "1" Then
'									dTotaalMij = dTotaalMij + Val(AdoGetField(TABLE_JOURNAL, "#v068 #"))
'								Else
'									JetInsert(TABLE_JOURNAL, 0)
'								End If
'							End If

'							If VB.Left(KeuzeInfo(1).Text, 1) = "1" Then
'								TotaalBedragBeheer = TotaalBedragBeheer + BedragBeheer
'								'MsgBox "stop"
'							Else
'								AdoInsertToRecord(TABLE_JOURNAL, AdoGetField(TABLE_JOURNAL, "#v019 #"), "v069")
'								AdoInsertToRecord(TABLE_JOURNAL, RekBeheersKost.Value, "v019")
'								AdoInsertToRecord(TABLE_JOURNAL, VB.Left(KeuzeInfo(1).Text, 1), "v041")
'								AdoInsertToRecord(TABLE_JOURNAL, Str(-BedragBeheer), "v068")
'								If Val(AdoGetField(TABLE_JOURNAL, "#v068 #")) <> 0 Then
'									JetInsert(TABLE_JOURNAL, 0)
'								End If
'							End If

'							AdoInsertToRecord(TABLE_JOURNAL, " ", "v041")
'							Select Case VB.Left(AdoGetField(TABLE_CONTRACTS, "#vs97 #"), 1)
'								Case "2", "0"

'								Case Else
'									AdoInsertToRecord(TABLE_CONTRACTS, "1", "v041")
'							End Select

'							bUpdate(TABLE_CONTRACTS, 0)
'							JetInsert(TABLE_INVOICES, 0)
'							If KTRL Then
'								WegBoekFout = True
'								dokumentSleutel.Value = BakdokumentSleutel.Value
'								Exit Function
'							End If
'							Mid(dokumentSleutel.Value, 7, 5) = VB6.Format(Val(VB.Right(dokumentSleutel.Value, 5)) + 1, "00000")

'						Case "3", "4", "5"
'							PolisDetail.Col = 4
'							AdoInsertToRecord(TABLE_JOURNAL, (PolisDetail.Text), "v067")

'							PolisDetail.Col = 6
'							If Trim(PolisDetail.Text) = "" Then
'								BedragBeheer = 0
'							Else
'								BedragBeheer = CDec(PolisDetail.Text)
'							End If
'							AdoInsertToRecord(TABLE_INVOICES, Str(BedragBeheer), "e069")
'							AdoInsertToRecord(TABLE_CONTRACTS, Str(BedragBeheer), "e069")
'							dTotaalBKost = dTotaalBKost - BedragBeheer

'							PolisDetail.Col = 5
'							'MsgBox "TODO: snipped document: " & PolisDetail.Text
'							If PolisDetail.Text = "" Then
'								RS_MAR(TABLE_INVOICES).Fields("rvXMLTB2").Value = ""
'							Else
'								RS_MAR(TABLE_INVOICES).Fields("rvXMLTB2").Value = PolisDetail.Text
'							End If

'							PolisDetail.Col = 2
'							BedragTotaal = BedragBeheer + Val(PolisDetail.Text)
'							AdoInsertToRecord(TABLE_JOURNAL, Str(-BedragTotaal), "v068")
'							AdoInsertToRecord(TABLE_INVOICES, Str(-BedragTotaal), "v249")
'							AdoInsertToRecord(TABLE_CONTRACTS, (PolisDetail.Text), "B090")
'							AdoInsertToRecord(TABLE_INVOICES, (PolisDetail.Text), "B090")

'							AdoInsertToRecord(TABLE_JOURNAL, LabelInfo(2).Text, "v069")
'							If BedragTotaal <> 0 Then
'								JetInsert(TABLE_JOURNAL, 0)
'							End If

'							Temporek.Value = LabelInfo(2).Text
'							Mid(Temporek.Value, 1, 2) = "70"
'							AdoInsertToRecord(TABLE_JOURNAL, Temporek.Value, "v019")

'							PolisDetail.Col = 3
'							AdoInsertToRecord(TABLE_JOURNAL, (PolisDetail.Text), "v068")
'							AdoInsertToRecord(TABLE_CONTRACTS, (PolisDetail.Text), "B094")
'							AdoInsertToRecord(TABLE_INVOICES, (PolisDetail.Text), "B094")
'							If Val(PolisDetail.Text) <> 0 Then
'								JetInsert(TABLE_JOURNAL, 0)
'							End If

'							AdoInsertToRecord(TABLE_JOURNAL, AdoGetField(TABLE_JOURNAL, "#v069 #"), "v019")
'							AdoInsertToRecord(TABLE_JOURNAL, " ", "v069")
'							AdoInsertToRecord(TABLE_JOURNAL, Str(Val(AdoGetField(TABLE_INVOICES, "#B090 #")) - Val(AdoGetField(TABLE_INVOICES, "#B094 #"))), "v068")
'							If Val(AdoGetField(TABLE_JOURNAL, "#v068 #")) <> 0 Then
'								JetInsert(TABLE_JOURNAL, 0)
'							End If

'							AdoInsertToRecord(TABLE_JOURNAL, AdoGetField(TABLE_JOURNAL, "#v019 #"), "v069")
'							AdoInsertToRecord(TABLE_JOURNAL, RekBeheersKost.Value, "v019")
'							AdoInsertToRecord(TABLE_JOURNAL, VB.Left(KeuzeInfo(1).Text, 1), "v041")
'							AdoInsertToRecord(TABLE_JOURNAL, Str(BedragBeheer), "v068")
'							If Val(AdoGetField(TABLE_JOURNAL, "#v068 #")) <> 0 Then
'								JetInsert(TABLE_JOURNAL, 0)
'							End If




'							JetInsert(TABLE_INVOICES, 0)
'							If KTRL Then
'								WegBoekFout = True
'								dokumentSleutel.Value = BakdokumentSleutel.Value
'								Exit Function
'							End If
'							Mid(dokumentSleutel.Value, 7, 5) = VB6.Format(Val(VB.Right(dokumentSleutel.Value, 5)) + 1, "00000")

'						Case Else
'							MsgBox("Nog niet beschikbaar")
'							Beep()
'							WegBoekFout = True
'							dokumentSleutel.Value = BakdokumentSleutel.Value
'							Exit Function
'					End Select
'				End If
'			End If
'NextLijn: 
'		Next 

'		If VB.Left(KeuzeInfo(1).Text, 1) = "1" Then
'			AdoInsertToRecord(TABLE_JOURNAL, LabelInfo(2).Text, "v019")
'			TempoDokSleutel = dokumentSleutel.Value
'			Mid(TempoDokSleutel, 7, 5) = VB6.Format(Val(VB.Right(dokumentSleutel.Value, 5)) - 1, "00000")

'			AdoInsertToRecord(TABLE_JOURNAL, TempoDokSleutel, "v033")
'			AdoInsertToRecord(TABLE_JOURNAL, LabelInfo(2).Text, "v069")

'			Temporek.Value = AdoGetField(TABLE_JOURNAL, "#v019 #")
'			Mid(Temporek.Value, 1, 2) = "70"
'			AdoInsertToRecord(TABLE_JOURNAL, Temporek.Value, "v019")
'			AdoInsertToRecord(TABLE_JOURNAL, "Termijn", "v067")
'			AdoInsertToRecord(TABLE_JOURNAL, Str(dTotaalLoon), "v068")
'			If Val(AdoGetField(TABLE_JOURNAL, "#v068 #")) <> 0 Then
'				JetInsert(TABLE_JOURNAL, 0)
'			End If

'			If TotaalBedragBeheer <> 0 Then
'				AdoInsertToRecord(TABLE_JOURNAL, AdoGetField(TABLE_JOURNAL, "#v019 #"), "v069")
'				AdoInsertToRecord(TABLE_JOURNAL, RekBeheersKost.Value, "v019")
'				AdoInsertToRecord(TABLE_JOURNAL, VB.Left(KeuzeInfo(1).Text, 1), "v041")
'				AdoInsertToRecord(TABLE_JOURNAL, Str(-TotaalBedragBeheer), "v068")
'				If Val(AdoGetField(TABLE_JOURNAL, "#v068 #")) <> 0 Then
'					JetInsert(TABLE_JOURNAL, 0)
'				End If
'				TotaalBedragBeheer = 0
'			End If

'			AdoInsertToRecord(TABLE_JOURNAL, AdoGetField(TABLE_JOURNAL, "#v019 #"), "v069")
'			AdoInsertToRecord(TABLE_JOURNAL, LabelInfo(2).Text, "v019")
'			AdoInsertToRecord(TABLE_JOURNAL, VB.Left(KeuzeInfo(1).Text, 1), "v041")
'			AdoInsertToRecord(TABLE_JOURNAL, Str(dTotaalMij), "v068")
'			If Val(AdoGetField(TABLE_JOURNAL, "#v068 #")) <> 0 Then
'				JetInsert(TABLE_JOURNAL, 0)
'			End If
'		End If

'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal
'		If DKTRL_CUMUL <> 0 Then
'			frmBoeking.cmdBoeken.Enabled = False
'			MsgBox("LogikaFout bij vierkantskontrole journaal." & vbCrLf & vbCrLf & "Deze verrichting wordt geannuleerd.  Controleer zelf eerst en/of raadpleeg ons.")
'			frmBoeking.ShowDialog()
'			GoTo IetsGingFout
'		Else
'			Select Case VB.Left(Mim.cmdWegBoekModus.Text, 1)
'				Case "0"
'				Case "1"
'					If DKTRL_BEF Or DKTRL_EUR Then
'						frmBoeking.ShowDialog()
'					End If
'				Case "2"
'					frmBoeking.ShowDialog()
'				Case Else
'					MsgBox("situatie...")
'			End Select
'			If DKTRL_CUMUL Then GoTo IetsGingFout
'		End If
'		Mid(dokumentSleutel.Value, 7, 5) = VB6.Format(Val(VB.Right(dokumentSleutel.Value, 5)) - 1, "00000")
'		WegBoekFout = False
'		Exit Function

'IetsGingFout: 
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal
'		WegBoekFout = True
'		dokumentSleutel.Value = BakdokumentSleutel.Value
'		Exit Function

'	End Function

'	Function BeheersKost(ByRef PolisNummer As String, ByRef Bedrag As Decimal) As Boolean

'		Dim BetalingStr As String

'		BeheersKost = True
'		JetGet(TABLE_INVOICES, 2, PolisNummer)
'		On Error Resume Next
'		BetalingStr = Trim(RS_MAR(TABLE_INVOICES).Fields("v038").Value)
'		If VB.Left(RS_MAR(TABLE_CONTRACTS).Fields("vs97").Value, 1) = "2" Then
'			BeheersKost = False
'		ElseIf VB.Left(BetalingStr, 2) = "KA" Then 
'			BeheersKost = False
'		End If

'	End Function

'	Function ktrlRVmemo() As Boolean

'		Dim ktrlString As String

'		Err.Clear()
'		On Error Resume Next

'		'nieuwe poging 08/2009

'		ktrlRVmemo = True
'		ktrlString = RS_MAR(TABLE_INVOICES).Fields("rvXMLTB2").Name

'		If Err.Number = 3265 Then
'			RS_MAR(TABLE_INVOICES).Close()
'			MSG = "ALTER TABLE Dokumenten ADD COLUMN rvXMLTB2 MEMO;"
'			Err.Clear()
'			AD_NTDB.Execute(MSG)
'			If Err.Number Then
'				MsgBox("Foutmelding bron: " & Err.Source & vbCrLf & "Foutkodenummer: " & Err.Number & vbCrLf & vbCrLf & "Foutmelding omschrijving:" & vbCrLf & Err.Description)
'			Else
'				MsgBox(MSG, MsgBoxStyle.Information, "Met succes")
'			End If
'			MsgBox("Belangrijk veld werd toegevoegd. Gelieve het bedrijf opnieuw te openen a.u.b.")
'			ktrlRVmemo = False
'		End If

'	End Function

'    Private Sub _Label1_15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Label1_15.Click

'    End Sub

'    Private Sub _Label1_16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Label1_16.Click

'    End Sub

'    Private Sub _LabelInfo_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _LabelInfo_2.Click

'    End Sub

'    Private Sub _TekstInfo_0_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles _TekstInfo_0.MaskInputRejected

'    End Sub

'    Private Sub mebBoekDatum_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mebBoekDatum.MaskInputRejected

'    End Sub

'    Private Sub SSTab2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSTab2.SelectedIndexChanged

'    End Sub

'    Private Sub cbTB2ktrl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTB2ktrl.CheckedChanged

'    End Sub

'    Private Sub cbHerboeking_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbHerboeking.CheckedChanged

'    End Sub

'    Private Sub _KeuzeInfo_1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _KeuzeInfo_1.SelectedIndexChanged

'    End Sub

'    Private Sub cbBoekDatum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBoekDatum.CheckedChanged

'    End Sub

'    Private Sub _KeuzeInfo_0_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _KeuzeInfo_0.SelectedIndexChanged

'    End Sub

'    Private Sub rtbIndentTB2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtbIndentTB2.TextChanged

'    End Sub

'    Private Sub Schoonvegen_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Schoonvegen.Click

'    End Sub
'End Class