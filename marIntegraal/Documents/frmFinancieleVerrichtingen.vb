Imports System.ComponentModel

Public Class FinancieleVerrichtingen
	Private Sub frmFinancieleVerrichtingen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub FinancieleVerrichtingen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

		Mim.FinancialTransactionMenuItem.Enabled=True 

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		If lbFinancieelDetail.Items.Count Then
			MSG = "Aangeduide verrichtingen negeren." & vbCrLf & vbCrLf & "Bent U zeker ?"
			KTRL = MsgBox(MSG, 292, "Voortijdig stoppen...")
			If KTRL = 6 Then
			Else
				Exit Sub
			End If
		Else 
			Close 
		End If

	End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class InbrengFinancieel
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Dim BeginBalans As Short
'	Dim dokumentSleutel As New VB6.FixedLengthString(8)

'	Dim DefaultRekening As New VB6.FixedLengthString(7)
'	'UPGRADE_ISSUE: Declaration type not supported: Array of fixed-length strings. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="934BD4FF-1FF9-47BD-888F-D411E47E78FA"'
'	Dim RekeningNummer(9) As String*7
'	'UPGRADE_ISSUE: Declaration type not supported: Array of fixed-length strings. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="934BD4FF-1FF9-47BD-888F-D411E47E78FA"'
'	Dim Uittreksel(9) As String*6
'	Dim RecNummer(9) As Short

'	Dim BekomenKorting As New VB6.FixedLengthString(7)
'	Dim ToegestaneKorting As New VB6.FixedLengthString(7)


'	Dim bCtrl As Boolean
'	Dim COUNT_TO As Short
'	Dim iOptelControle As Short

'	'Begin
'	Dim sDatumAanmaak As String
'	Dim sToepassingsCode As String
'	Dim sNaamBestemmeling As String

'	'OudSaldo
'	Dim sRekeningNummer As String
'	Dim sUittreksel As String
'	Dim cOudSaldo As Decimal
'	Dim sDatumOudSaldo As String
'	Dim sNaamRekeninghouder As String
'	Dim sOmschrijvingRekening As String

'	'BewegingsArtikel1
'	Dim sRefFinInstelling As String
'	Dim sRefFinInstelling2 As String
'	Dim sDC As String
'	Dim cBedrag As Decimal
'	Dim sVerrichting As String
'	Dim sMededeling As String
'	Dim sMDDZone1 As String
'	Dim sMDDZone2 As String
'	Dim sBoekDatum As String
'	Dim sDagAfschriftVolgNummer As String
'	Dim sValutadatum As String

'	'BewegingsArtikel2
'	Dim sMededeling2 As String
'	Dim sRefKlant(1) As String
'	Dim sMuntVerrichting As String
'	Dim cBedragMunt As Decimal

'	'BewegingsArtikel3
'	Dim sRekeningTP As String
'	Dim sITcodesTP As String
'	Dim sRekeningTPextra As String
'	Dim sNaamEnAdres(2) As String

'	'NieuwSaldo
'	Dim sUittreksel2 As String
'	Dim sRekeningNummer2 As String
'	Dim cNieuwSaldo As Decimal
'	Dim sDatumNieuwSaldo As String

'	'EindOpname
'	Dim iOptelCtrlCheckUp As Short
'	Dim cDebetSaldo As Decimal
'	Dim cCreditSaldo As Decimal


'	Private Sub Afsluiten_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Afsluiten.Click
'		Dim T As Short
'		Dim TempoTekst As String
'		Dim DummySleutel As New VB6.FixedLengthString(5)

'		If Not DatumKtrl(VB6.Format(Datum.Value, "dd/mm/yyyy"), PERIODAS_TEXT) Then
'			Beep()
'			Datum.Focus()
'			Exit Sub
'		ElseIf FinancieelDetail.Items.Count = 0 Then 
'			Beep()
'			MsgBox("Verrichtingen inbrengen a.u.b. !!!")
'			Exit Sub
'		End If

'		JetGet(TABLE_LEDGERACCOUNTS, 0, VB.Left(KeuzeInfo(0).Text, 7))
'		If KTRL Then
'			MsgBox("onlogische situatie")
'			Exit Sub
'		Else
'			RecordToField(TABLE_LEDGERACCOUNTS)
'		End If
'		JetGet(TABLE_JOURNAL, 2, UCase(VB.Left(AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #"), 2)) & VB.Right(VB6.Format(Datum.Value, "dd/mm/yyyy"), 2) & VB6.Format(Val(LabelInfo(11).Text) - 1, "0000"))
'		If KTRL Then
'			MsgBox("Dit zou het eerste uittreksel binnen het WERKELIJK jaar moeten zijn...  Kontroleer eventueel")
'		Else
'			RecordToField(TABLE_JOURNAL)
'			If AdoGetField(TABLE_JOURNAL, "#v066 #") > VB6.Format(Datum.Value, "yyyymmdd") Then
'				MSG = "Er zijn reeds uittreksels met een hogere datum !" & vbCrLf & vbCrLf
'				MSG = MSG & "Laatste uittreksel nr. " & UCase(VB.Left(AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #"), 2)) & VB.Right(VB6.Format(Datum.Value, "dd/mm/yyyy"), 2) & VB6.Format(Val(LabelInfo(11).Text) - 1, "0000") & " dateert van : " & FunctionDateText(AdoGetField(TABLE_JOURNAL, "#v066 #")) & vbCrLf & vbCrLf
'				MSG = MSG & "Vervolg.  Bent U zeker ?"
'				KTRL = MsgBox(MSG, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Uittreksel afsluiten")
'				If KTRL = MsgBoxResult.No Then
'					Exit Sub
'				End If
'			End If
'		End If

'		If BH_EURO Then
'			MSG = "Datum uittreksel " & Datum.Value & " en bekomen eindsaldo EUR " & lblInfo(1).Text & vbCrLf & vbCrLf & "Hierna wordt de boekhouding bijgewerkt.  Bent U zeker ?"
'		Else
'			MSG = "Datum uittreksel " & Datum.Value & " en bekomen eindsaldo BEF " & LabelInfo(13).Text & vbCrLf & vbCrLf & "Hierna wordt de boekhouding bijgewerkt.  Bent U zeker ?"
'		End If
'		KTRL = MsgBox(MSG, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Uittreksel : " & UCase(VB.Left(AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #"), 2)) & VB.Right(VB6.Format(Datum.Value, "dd/mm/yyyy"), 2) & VB6.Format(Val(LabelInfo(11).Text), "0000"))
'		If KTRL = MsgBoxResult.Yes Then
'			TransBegin()
'			If WegBoekFout() Then
'				TransAbort()
'				Exit Sub
'			Else
'				TransCommit()
'				DummySleutel.Value = "s" & VB6.Format(RecNummer(KeuzeInfo(0).SelectedIndex), "000")
'				JetGet(TABLE_COUNTERS, 0, DummySleutel.Value)
'				If KTRL Then
'					MsgBox("TellerStop " & DummySleutel.Value & ".  kontakteer R&&Vsoft")
'				Else
'					RecordToField(TABLE_COUNTERS)
'					FL99_RECORD = Str(Val(LabelInfo(11).Text))
'					If BA_MODUS = 1 Then
'						AdoInsertToRecord(TABLE_COUNTERS, FL99_RECORD, "v217 ")
'					Else
'						AdoInsertToRecord(TABLE_COUNTERS, FL99_RECORD, DummySleutel.Value)
'					End If
'					bUpdate(TABLE_COUNTERS, 0)
'					If KTRL Then
'						MsgBox("Update TellerStop " & DummySleutel.Value & ".  kontakteer R&&Vsoft")
'					End If
'				End If

'				DummySleutel.Value = "s101"
'				JetGet(TABLE_COUNTERS, 0, DummySleutel.Value)
'				If KTRL Then
'					MsgBox("TellerStop.  Versiekonflikt !  Kontakteer R&&Vsoft")
'				Else
'					RecordToField(TABLE_COUNTERS)
'					FL99_RECORD = VB.Left(KeuzeInfo(0).Text, 7)
'					If BA_MODUS = 1 Then
'						AdoInsertToRecord(TABLE_COUNTERS, FL99_RECORD, "v217 ")
'					Else
'						AdoInsertToRecord(TABLE_COUNTERS, FL99_RECORD, DummySleutel.Value)
'					End If
'					bUpdate(TABLE_COUNTERS, 0)
'					If KTRL Then
'						MsgBox("UpdateStop Teller. kontakteer R&&Vsoft")
'					End If
'				End If
'				JetTableClose(TABLE_COUNTERS)
'				Me.Close()
'				GRIDTEXT = ""
'			End If
'		End If

'	End Sub

'	Private Sub Annuleren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Annuleren.Click

'		If FinancieelDetail.Items.Count Then
'			MSG = "Aangeduide verrichtingen negeren." & vbCrLf & vbCrLf & "Bent U zeker ?"
'			KTRL = MsgBox(MSG, 292)
'			If KTRL = 6 Then
'			Else
'				Exit Sub
'			End If
'		End If
'		Me.Close()
'		GRIDTEXT = ""

'	End Sub

'	Private Sub cbCoda_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbCoda.Click

'		Dim FlFull As Short
'		Dim strFull As String
'		Dim Telhier As Short
'		Dim zoekPath As String
'		Dim PathNu As String
'		Dim LijstString As Object

'		Me.fnTestBetaalopdracht()

'		mfgLijst.Clear()
'		mfgLijst.set_Cols( , 7)
'		mfgLijst.Rows = 2

'		mfgLijst.set_TextMatrix(0, 0, "Rekening")
'		mfgLijst.set_TextMatrix(0, 1, "Transactie")
'		mfgLijst.set_TextMatrix(0, 2, "D/C")
'		mfgLijst.set_TextMatrix(0, 3, "Datum")
'		mfgLijst.set_TextMatrix(0, 4, "Bedrag/Saldo")
'		mfgLijst.set_TextMatrix(0, 5, "Referte")
'		mfgLijst.set_TextMatrix(0, 6, "Referte2")

'		mfgLijst.set_ColWidth(0,  , 1400)
'		mfgLijst.set_ColWidth(1,  , 1095)
'		mfgLijst.set_ColWidth(2,  , 540)
'		mfgLijst.set_ColWidth(3,  , 750)
'		mfgLijst.set_ColWidth(4,  , 1335)
'		mfgLijst.set_ColWidth(5,  , 690)
'		mfgLijst.set_ColWidth(6,  , 1155)

'		zoekPath = LOCATION_COMPANYDATA & "coda\record*.*"
'		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		PathNu = Dir(zoekPath)
'		Do While PathNu <> ""

'			iOptelControle = 0
'			FlFull = FreeFile
'			FileOpen(FlFull, LOCATION_COMPANYDATA & "coda\" & PathNu, OpenMode.Input)
'			Do While Not EOF(FlFull)
'				strFull = LineInput(FlFull)
'				Telhier = Telhier + 1
'				Select Case VB.Left(strFull, 1)
'					Case "0" 'Beginopname
'						bCtrl = fnBeginOpname(strFull)
'						If bCtrl = False Then
'							MsgBox("Onlogische situatie", MsgBoxStyle.Critical)
'							Exit Do
'						End If
'					Case "1" 'Oud Saldo
'						bCtrl = fnOudSaldo(strFull)
'						mfgLijst.set_TextMatrix(1, 0, sRekeningNummer)
'						mfgLijst.set_TextMatrix(1, 1, "BEGIN: " & sUittreksel)
'						mfgLijst.set_TextMatrix(1, 2, "")
'						mfgLijst.set_TextMatrix(1, 3, sDatumOudSaldo)
'						mfgLijst.set_TextMatrix(1, 4, cOudSaldo)
'						mfgLijst.set_TextMatrix(1, 5, "")
'						mfgLijst.set_TextMatrix(1, 6, "")

'					Case "2" 'Beweging
'						bCtrl = fnBeweging(strFull)
'						If bCtrl = False Then
'							'MsgBox "Stop: Doe nu eerst iets met de beweging"
'							'Doe iets met deze verrichting
'							'UPGRADE_WARNING: Couldn't resolve default property of object LijstString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'							LijstString = "" & vbTab & sVerrichting & vbTab & sDC & vbTab & "" & vbTab & cBedrag & vbTab & sMDDZone1 & vbTab & Trim(sMDDZone2)

'							'UPGRADE_WARNING: Couldn't resolve default property of object LijstString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'							mfgLijst.AddItem(LijstString)

'							'Daarna opkuisen
'							BewegingSchoon()
'						End If

'					Case "8" 'Nieuw Saldo
'						bCtrl = fnNieuwSaldo(strFull)

'					Case "9" 'Eindopname
'						bCtrl = fnEindOpname(strFull)
'						'UPGRADE_WARNING: Couldn't resolve default property of object LijstString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'						LijstString = sRekeningNummer & vbTab & "EINDE: " & sUittreksel & vbTab & "" & vbTab & sDatumNieuwSaldo & vbTab & cNieuwSaldo
'						'UPGRADE_WARNING: Couldn't resolve default property of object LijstString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'						mfgLijst.AddItem(LijstString)

'				End Select
'			Loop 
'			FileClose(FlFull)
'			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			PathNu = Dir()
'		Loop 

'	End Sub

'	Function fnTestBetaalopdracht() As Short

'		MsgBox("Stop in ontwikkeling")
'		Dim boString As New VB6.FixedLengthString(128)
'		Dim eoString As New VB6.FixedLengthString(128)
'		Dim gostring As New VB6.FixedLengthString(128)

'		Mid(boString.Value, 1, 1) = "0" 'beginopname
'		Mid(boString.Value, 4, 2) = "00" 'voorwerp van betaling
'		Mid(boString.Value, 6, 6) = VB6.Format(Now, "ddmmyy") 'datum opmaak
'		Mid(boString.Value, 12, 3) = "123" 'codenummer fin.instelling


'	End Function

'	Private Sub Datum_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Datum.Leave
'		Dim Index As Short

'		On Error GoTo LostFocusError

'		Select Case Index
'			Case 0
'				If DatumKtrl(VB6.Format(Datum.Value, "dd/mm/yyyy"), PERIODAS_TEXT) Then
'				Else
'					BJPERDAT.WindowState = System.Windows.Forms.FormWindowState.Normal
'					BJPERDAT.PeriodeBoekjaar.Focus()
'				End If
'		End Select

'LostFocusError: 
'		Exit Sub

'	End Sub

'	Private Sub FinancieelDetail_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FinancieelDetail.KeyDown
'		Dim KeyCode As Short = eventArgs.KeyCode
'		Dim Shift As Short = eventArgs.KeyData \ &H10000

'		If KeyCode = 45 Or KeyCode = 107 Then Volgende_Click(Volgende, New System.EventArgs())

'	End Sub


'	Private Sub InbrengFinancieel_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
'		Dim A As String

'		If Not Toegankelijk(Me) Then
'			Me.Close()
'			Exit Sub
'		End If

'		Dim T As Short
'		Dim TT As Short

'		Top = 0
'		Left = 0

'		LabelInfo(2).Text = " dokument    " & "TegenR. " & "      Bedrag " & "Omschrijving                    " & "Fin. Kort."

'		Datum.Value = MIM_GLOBAL_DATE.Value
'		BeginBalans = Val(String99(READING, 64))

'		ToegestaneKorting.Value = String99(READING, 28)
'		BekomenKorting.Value = String99(READING, 27)
'		DefaultRekening.Value = String99(READING, 101)

'		RecNummer(0) = 31
'		RekeningNummer(0) = String99(READING, 41)
'		Uittreksel(0) = LTrim(RTrim(String99(READING, 31)))

'		RecNummer(1) = 32
'		RekeningNummer(1) = String99(READING, 42)
'		Uittreksel(1) = LTrim(RTrim(String99(READING, 32)))

'		RecNummer(2) = 33
'		RekeningNummer(2) = String99(READING, 43)
'		Uittreksel(2) = LTrim(RTrim(String99(READING, 33)))

'		RecNummer(3) = 34
'		RekeningNummer(3) = String99(READING, 44)
'		Uittreksel(3) = LTrim(RTrim(String99(READING, 34)))

'		RecNummer(4) = 35
'		RekeningNummer(4) = String99(READING, 45)
'		Uittreksel(4) = LTrim(RTrim(String99(READING, 35)))

'		RecNummer(5) = 38
'		RekeningNummer(5) = String99(READING, 39)
'		Uittreksel(5) = LTrim(RTrim(String99(READING, 38)))

'		RecNummer(6) = 215
'		RekeningNummer(6) = String99(READING, 211)
'		Uittreksel(6) = LTrim(RTrim(String99(READING, 215)))

'		RecNummer(7) = 216
'		RekeningNummer(7) = String99(READING, 212)
'		Uittreksel(7) = LTrim(RTrim(String99(READING, 216)))

'		RecNummer(8) = 217
'		RekeningNummer(8) = String99(READING, 213)
'		Uittreksel(8) = LTrim(RTrim(String99(READING, 217)))

'		RecNummer(9) = 218
'		RekeningNummer(9) = String99(READING, 214)
'		Uittreksel(9) = LTrim(RTrim(String99(READING, 218)))

'		For T = 0 To 9
'			JetGet(TABLE_LEDGERACCOUNTS, 0, RekeningNummer(T))
'			If KTRL Then
'				A = "Niet aanwezig. Installeer via Setup Boekjaar."
'			Else
'				RecordToField(TABLE_LEDGERACCOUNTS)
'				A = RekeningNummer(T) & Chr(124) & RTrim(AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #"))
'			End If
'			KeuzeInfo(0).Items.Add(A)
'			If DefaultRekening.Value = RekeningNummer(T) Then
'				TT = T
'			End If
'		Next 
'		KeuzeInfo(0).SelectedIndex = TT

'	End Sub


'	'UPGRADE_WARNING: Event KeuzeInfo.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub KeuzeInfo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles KeuzeInfo.SelectedIndexChanged
'		Dim Index As Short = KeuzeInfo.GetIndex(eventSender)

'		Select Case Index
'			Case 0
'				Select Case UCase(Uittreksel(KeuzeInfo(0).SelectedIndex))
'					Case "A" To "Z"
'						LabelInfo(11).Text = Str(Val(VB.Right(Uittreksel(KeuzeInfo(0).SelectedIndex), 4)) + 1)
'					Case Else
'						LabelInfo(11).Text = Str(Val(Uittreksel(KeuzeInfo(0).SelectedIndex)) + 1)
'				End Select
'				JetGet(TABLE_LEDGERACCOUNTS, 0, SetSpacing(KeuzeInfo(0).Text, 7))
'				If KTRL Then
'				Else
'					RecordToField(TABLE_LEDGERACCOUNTS)
'					If BeginBalans = 1 Then
'						If BH_EURO Then
'							lblInfo(0).Text = VB6.Format(Val(AdoGetField(TABLE_LEDGERACCOUNTS, "#e" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex, "000") & " #")), "#,##0.00")
'							LabelInfo(12).Text = VB6.Format(CDbl(lblInfo(0).Text) * EURO, "#,##0.00")
'						Else
'							LabelInfo(12).Text = VB6.Format(Val(AdoGetField(TABLE_LEDGERACCOUNTS, "#v" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex, "000") & " #")), "#,##0.00")
'							lblInfo(0).Text = VB6.Format(CDbl(LabelInfo(12).Text) / EURO, "#,##0.00")
'						End If
'					Else
'						If BH_EURO Then
'							lblInfo(0).Text = VB6.Format(Val(AdoGetField(TABLE_LEDGERACCOUNTS, "#e" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex, "000") & " #")) + Val(AdoGetField(TABLE_LEDGERACCOUNTS, "#e" & VB6.Format(23 + BJPERDAT.Boekjaar.SelectedIndex, "000") & " #")), "#,##0.00")
'							LabelInfo(12).Text = VB6.Format(System.Math.Round(CDbl(lblInfo(0).Text) * EURO), "#,##0.00")
'						Else
'							LabelInfo(12).Text = VB6.Format(Val(AdoGetField(TABLE_LEDGERACCOUNTS, "#v" & VB6.Format(22 + BJPERDAT.Boekjaar.SelectedIndex, "000") & " #")) + Val(AdoGetField(TABLE_LEDGERACCOUNTS, "#v" & VB6.Format(23 + BJPERDAT.Boekjaar.SelectedIndex, "000") & " #")), "#,##0.00")
'							lblInfo(0).Text = VB6.Format(CDbl(LabelInfo(12).Text) / EURO, "#,##0.00")
'						End If
'					End If
'					LabelInfo(13).Text = LabelInfo(12).Text
'					lblInfo(1).Text = lblInfo(0).Text
'				End If
'		End Select

'	End Sub

'	Private Sub KeuzeInfo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles KeuzeInfo.Leave
'		Dim Index As Short = KeuzeInfo.GetIndex(eventSender)

'		Select Case Index
'			Case 0
'				If KeuzeInfo(0).Text = "" Then
'					Beep()
'					KeuzeInfo(0).Focus()
'				End If
'		End Select

'	End Sub

'	'UPGRADE_ISSUE: Label event LabelInfo.Change was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
'	Private Sub LabelInfo_Change(ByRef Index As Short)

'		Select Case Index
'			Case 12, 13
'				Select Case CDbl(LabelInfo(Index).Text)
'					Case 0
'						LabelInfo(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
'						lblInfo(Index - 12).BackColor = System.Drawing.ColorTranslator.FromOle(&HC0C0C0)
'					Case Is > 0
'						LabelInfo(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&H80FF80)
'						lblInfo(Index - 12).BackColor = System.Drawing.ColorTranslator.FromOle(&H80FF80)
'					Case Is < 0
'						LabelInfo(Index).BackColor = System.Drawing.ColorTranslator.FromOle(&H80FFFF)
'						lblInfo(Index - 12).BackColor = System.Drawing.ColorTranslator.FromOle(&H80FFFF)
'				End Select
'		End Select

'	End Sub

'	Private Sub Schoon()
'		Dim TT As Short
'		Dim T As Short

'		Do While FinancieelDetail.Items.Count
'			FinancieelDetail.Items.RemoveAt(0)
'		Loop 

'		KeuzeInfo(0).Enabled = True
'		TT = KeuzeInfo(0).SelectedIndex
'		If TT = 9 Then
'			KeuzeInfo(0).SelectedIndex = 0
'		Else
'			KeuzeInfo(0).SelectedIndex = TT + 1
'		End If
'		KeuzeInfo(0).SelectedIndex = TT

'	End Sub

'	Private Sub Struktuur_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Struktuur.Click
'		Dim ReferteTxt As String
'		Dim DummyText As String
'		Dim dPip As Double

'		Dim dTotaal As Decimal
'		Dim dBedragTekst As Decimal
'		Dim dBedragKtrl As Decimal

'		Dim sPip As New VB6.FixedLengthString(2)
'		Dim DefaultKlanten As New VB6.FixedLengthString(7)

'		SnelHelpPrint(" ", BL_LOGGING)
'		DefaultKlanten.Value = String99(READING, 9)

'		MSG = "Breng mededeling in" & vbCrLf
'		MSG = MSG & "met masker nnnnnnnnnnnn" & vbCrLf & vbCrLf
'		MSG = MSG & "Waarbij n staat voor elk" & vbCrLf
'		MSG = MSG & "van de 12 verplichte cijfers" & vbCrLf & vbCrLf

'		ReferteTxt = InputBox(MSG, "Gestruktureerde betaling")
'		If ReferteTxt = "" Then
'			Exit Sub
'		Else
'			dPip = Val(VB.Left(ReferteTxt, 10))
'			sPip.Value = VB6.Format(dPip - Int(dPip / 97) * 97, "00")
'			If sPip.Value = "00" Then sPip.Value = "97"
'			If sPip.Value <> VB.Right(ReferteTxt, 2) Then
'				MsgBox("Ongeldige invoer" & vbCrLf & vbCrLf & sPip.Value & " <> " & VB.Right(ReferteTxt, 2) & vbCrLf & vbCrLf & "Een gestructureerde referte heeft een kontrolesysteem.  Uw invoer is ongeldig!", 0, "Gebruikersfout")
'				Exit Sub
'			End If
'		End If

'		'ReferteTxt bestaat uit 12 posities
'		'123-4567890-12
'		'positie 8 moet altijd '0' zijn voor klanten

'		Select Case Mid(ReferteTxt, 8, 1)
'			Case "0"
'				JetGet(TABLE_CUSTOMERS, 0, Mid(ReferteTxt, 4, 4) & Mid(ReferteTxt, 9, 2))
'				If KTRL Then
'					'het is geen klant, probeer als leveranciersreferte...
'				Else
'					RecordToField(TABLE_CUSTOMERS)
'					MSG = "Breng bedrag in voor" & vbCr
'					MSG = MSG & "totaal van " & VB.Left(ReferteTxt, 1) & " kwijtingen" & vbCr & vbCr
'					MSG = MSG & "klant :" & vbCr & vbCr & RTrim(AdoGetField(TABLE_CUSTOMERS, "#A100 #") & " " & AdoGetField(TABLE_CUSTOMERS, "#A101 #")) & " " & RTrim(AdoGetField(TABLE_CUSTOMERS, "#A125 #") & " " & AdoGetField(TABLE_CUSTOMERS, "#A127 #")) & vbCr
'					MSG = MSG & "Rekeningen:" & AdoGetField(TABLE_CUSTOMERS, "#A170 #") & " " & AdoGetField(TABLE_CUSTOMERS, "#v251 #")
'					dBedragTekst = Val(InputBox(MSG, "Totaal betaling"))
'					If dBedragTekst = 0 Then
'						Exit Sub
'					Else
'						'    MsgBox "Nog in ontwerp voor fakturen.  Enkel voorlopig mogelijk voor polisbeheer"
'						'    Exit Sub
'					End If
'				End If
'			Case Else
'				MsgBox("Geen R&V Gestruktureerde mededeling.", MsgBoxStyle.Exclamation)
'				Exit Sub
'		End Select
'		JetGetOrGreater(TABLE_INVOICES, 1, "K" & AdoGetField(TABLE_CUSTOMERS, "#A110 #"))
'		If KTRL Then
'			Exit Sub
'		Else
'			RecordToField(TABLE_INVOICES)
'		End If

'		dBedragKtrl = 0
'		DummyText = ""
'		If SetSpacing(KEY_BUF(TABLE_INVOICES), 13) <> SetSpacing("K" & AdoGetField(TABLE_CUSTOMERS, "#A110 #"), 13) Then
'			Exit Sub
'		Else
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub LijnErBij
'			Do 
'				bNext(TABLE_INVOICES)
'				If KTRL Or SetSpacing(KEY_BUF(TABLE_INVOICES), 13) <> SetSpacing("K" & AdoGetField(TABLE_CUSTOMERS, "#A110 #"), 13) Then
'					Exit Do
'				Else
'					RecordToField(TABLE_INVOICES)
'					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'					GoSub LijnErBij
'				End If
'			Loop 
'			If dBedragKtrl = dBedragTekst Then
'				Do While DummyText <> ""
'					If Mid(DummyText, 13, 12) = Space(12) Then
'					Else
'						GRIDTEXT = "+" & VB.Left(DummyText, 11) & Chr(124) & DefaultKlanten.Value & Chr(124) & Mid(DummyText, 13, 12) & Chr(124) & SetSpacing(AdoGetField(TABLE_CUSTOMERS, "#A100 #"), 29) & Chr(124) & Space(12)
'						FinancieelDetail.Items.Insert(FinancieelDetail.Items.Count, GRIDTEXT)
'						If BH_EURO Then
'							lblInfo(1).Text = VB6.Format(CDbl(lblInfo(1).Text) + Val(Mid(GRIDTEXT, 22, 12)), "#,##0.00")
'							LabelInfo(13).Text = VB6.Format(System.Math.Round(CDbl(lblInfo(1).Text) * EURO), "#,##0.00")
'						Else
'							LabelInfo(13).Text = VB6.Format(CDbl(LabelInfo(13).Text) + Val(Mid(GRIDTEXT, 22, 12)), "#,##0.00")
'							lblInfo(1).Text = VB6.Format(CDbl(LabelInfo(13).Text) / EURO, "#,##0.00")
'						End If
'					End If
'					DummyText = VB.Right(DummyText, Len(DummyText) - 26)
'				Loop 
'				SnelHelpPrint(GRIDTEXT & " met succes bijgevoegd !", BL_LOGGING)
'				Exit Sub
'			Else
'				MsgBox("Opzoeking zonder succes, dokumentenstand : " & vbCrLf & vbCrLf & DummyText)
'				Exit Sub
'			End If
'		End If
'		Exit Sub

'LijnErBij: 
'		If dBedragKtrl = dBedragTekst Then 'totaal al betaald
'			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			Return 
'		ElseIf Val(AdoGetField(TABLE_INVOICES, "#v037 #")) = Val(AdoGetField(TABLE_INVOICES, "#v249")) Then  'reeds VOLLEDIG betaald
'			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			Return 
'		ElseIf VB.Left(AdoGetField(TABLE_INVOICES, "#v033 #"), 1) <> "Q" Then  'voorlopig enkel kwitanties
'			'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			Return 
'		ElseIf dBedragTekst = Val(RS_MAR(TABLE_INVOICES).Fields("v249").Value) Then 
'			DummyText = DummyText & AdoGetField(TABLE_INVOICES, "#v033 #") & Chr(124)
'			dTotaal = Val(AdoGetField(TABLE_INVOICES, "#v249")) - Val(AdoGetField(TABLE_INVOICES, "#v037 #"))
'			DummyText = DummyText & Dec(dTotaal, MASK_EURBH) & vbCrLf
'			dBedragKtrl = dBedragKtrl + dTotaal
'		Else
'			'MsgBox "Situatie buiten controle", vbInformation
'		End If
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'	End Sub


'	Private Sub Volgende_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Volgende.Click
'		Dim Bedrag As Double

'		DetailInfo.Close()
'		DetailInfo.ShowDialog()
'		If GRIDTEXT <> "" Then
'			KeuzeInfo(0).Enabled = False
'			FinancieelDetail.Items.Insert(FinancieelDetail.Items.Count, GRIDTEXT)
'			Bedrag = Val(Mid(GRIDTEXT, 22, 12))
'			If VB.Left(GRIDTEXT, 1) = "+" Then
'				If BH_EURO Then
'					lblInfo(1).Text = VB6.Format(CDbl(lblInfo(1).Text) + Bedrag, "#,##0.00")
'					LabelInfo(13).Text = VB6.Format(System.Math.Round(CDbl(lblInfo(1).Text) * EURO), "#,##0.00")
'				Else
'					LabelInfo(13).Text = VB6.Format(CDbl(LabelInfo(13).Text) + Bedrag, "#,##0.00")
'					lblInfo(1).Text = VB6.Format(CDbl(LabelInfo(13).Text) / EURO, "#,##0.00")
'				End If
'			Else
'				If BH_EURO Then
'					lblInfo(1).Text = VB6.Format(CDbl(lblInfo(1).Text) - Bedrag, "#,##0.00")
'					LabelInfo(13).Text = VB6.Format(System.Math.Round(CDbl(lblInfo(1).Text) * EURO), "#,##0.00")
'				Else
'					LabelInfo(13).Text = VB6.Format(CDbl(LabelInfo(13).Text) - Bedrag, "#,##0.00")
'					lblInfo(1).Text = VB6.Format(CDbl(LabelInfo(13).Text) / EURO, "#,##0.00")
'				End If
'			End If
'		End If

'	End Sub

'	Private Function WegBoekFout() As Short
'		Dim Ontvangst As Short
'		Dim T As Short
'		Dim TotaalBedrag As Double
'		Dim FinKort As Double

'		Dim BeginSaldo As Decimal
'		Dim EindSaldo As Decimal
'		Dim VerschilSaldo As Decimal

'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'		WegBoekFout = True
'		DKTRL_CUMUL = 0 : DKTRL_BEF = 0 : DKTRL_EUR = 0
'		frmBoeking.Close()
'		frmBoeking.Hide()

'		TLB_RECORD(TABLE_JOURNAL) = ""
'		AdoInsertToRecord(TABLE_JOURNAL, VB.Left(KeuzeInfo(0).Text, 7), "v019")
'		AdoInsertToRecord(TABLE_JOURNAL, VB6.Format(Datum.Value, "yyyymmdd"), "v066")
'		AdoInsertToRecord(TABLE_JOURNAL, VB6.Format(Datum.Value, "yyyymmdd"), "v035")

'		JetGet(TABLE_LEDGERACCOUNTS, 0, VB.Left(KeuzeInfo(0).Text, 7))
'		If KTRL Then
'			Exit Function
'		Else
'			RecordToField(TABLE_LEDGERACCOUNTS)
'			dokumentSleutel.Value = UCase(VB.Left(AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #"), 2)) & VB.Right(VB6.Format(Datum.Value, "dd/mm/yyyy"), 2) & VB6.Format(Val(LabelInfo(11).Text), "0000")
'		End If
'		AdoInsertToRecord(TABLE_JOURNAL, dokumentSleutel.Value, "v038")
'		If BH_EURO Then
'			BeginSaldo = CDbl(lblInfo(0).Text)
'			EindSaldo = CDbl(lblInfo(1).Text)
'			VerschilSaldo = EindSaldo - BeginSaldo
'			AdoInsertToRecord(TABLE_JOURNAL, "Sld:" & Dec(CDbl(lblInfo(0).Text), MASK_EURBH) & "/" & Dec(CDbl(lblInfo(1).Text), MASK_EURBH), "v067")
'			AdoInsertToRecord(TABLE_JOURNAL, Dec(VerschilSaldo, MASK_SY(2)), "v068")
'		Else
'			AdoInsertToRecord(TABLE_JOURNAL, "Sld : " & Dec(CDbl(LabelInfo(12).Text), MASK_SY(0)) & " - " & Dec(CDbl(LabelInfo(13).Text), MASK_SY(0)), "v067")
'			AdoInsertToRecord(TABLE_JOURNAL, Dec(CDbl(LabelInfo(13).Text) - CDbl(LabelInfo(12).Text), MASK_SY(0)), "v068")
'		End If
'		JetInsert(TABLE_JOURNAL, 2)
'		If KTRL Then Exit Function

'		AdoInsertToRecord(TABLE_JOURNAL, VB.Left(KeuzeInfo(0).Text, 7), "v069")
'		For T = 1 To FinancieelDetail.Items.Count
'			FinancieelDetail.SelectedIndex = T - 1
'			If VB.Left(FinancieelDetail.Text, 1) = "+" Then
'				Ontvangst = True
'			Else
'				Ontvangst = False
'			End If
'			If Mid(FinancieelDetail.Text, 2, 11) = Space(11) Then
'				AdoInsertToRecord(TABLE_JOURNAL, " ", "v033")
'				AdoInsertToRecord(TABLE_JOURNAL, " ", "v034")
'			Else
'				JetGet(TABLE_INVOICES, 0, Mid(FinancieelDetail.Text, 2, 11))
'				If KTRL Then
'					Exit Function
'				Else
'					RecordToField(TABLE_INVOICES)
'					AdoInsertToRecord(TABLE_JOURNAL, AdoGetField(TABLE_INVOICES, "#v033 #"), "v033")
'					AdoInsertToRecord(TABLE_JOURNAL, AdoGetField(TABLE_INVOICES, "#v034 #"), "v034")
'				End If
'			End If

'			TotaalBedrag = Val(Mid(FinancieelDetail.Text, 22, 12))
'			AdoInsertToRecord(TABLE_JOURNAL, Trim(Mid(FinancieelDetail.Text, 35, 29)), "v067")
'			If Val(Mid(FinancieelDetail.Text, 65, 12)) <> 0 Then
'				FinKort = Val(Mid(FinancieelDetail.Text, 65, 12))
'				TotaalBedrag = TotaalBedrag + FinKort
'				Select Case Ontvangst
'					Case True
'						AdoInsertToRecord(TABLE_JOURNAL, Str(FinKort), "v068")
'						AdoInsertToRecord(TABLE_JOURNAL, ToegestaneKorting.Value, "v019")
'					Case False
'						AdoInsertToRecord(TABLE_JOURNAL, Str(-FinKort), "v068")
'						AdoInsertToRecord(TABLE_JOURNAL, BekomenKorting.Value, "v019")
'					Case Else
'						MsgBox("Stop")
'						Exit Function
'				End Select
'				JetInsert(TABLE_JOURNAL, 2)
'				If KTRL Then Exit Function
'			End If

'			AdoInsertToRecord(TABLE_JOURNAL, Mid(FinancieelDetail.Text, 14, 7), "v019")
'			Select Case Ontvangst
'				Case True
'					AdoInsertToRecord(TABLE_JOURNAL, Str(-TotaalBedrag), "v068")
'				Case False
'					AdoInsertToRecord(TABLE_JOURNAL, Str(TotaalBedrag), "v068")
'				Case Else
'					MsgBox("Stop")
'					Exit Function
'			End Select
'			JetInsert(TABLE_JOURNAL, 2)
'			If KTRL Then Exit Function
'			If LTrim(AdoGetField(TABLE_JOURNAL, "#v033 #")) = "" Then
'			Else
'				If XisEUROWasBEF = False Then
'					AdoInsertToRecord(TABLE_INVOICES, Str(Val(AdoGetField(TABLE_INVOICES, "#v037 #")) + TotaalBedrag), "v037")
'				Else
'					AdoInsertToRecord(TABLE_INVOICES, Str(Val(AdoGetField(TABLE_INVOICES, "#v037 #")) + System.Math.Round(TotaalBedrag / EURO, 2)), "v037")
'				End If
'				AdoInsertToRecord(TABLE_INVOICES, AdoGetField(TABLE_JOURNAL, "#v038 #"), "v038")
'				bUpdate(TABLE_INVOICES, 0)
'				If KTRL Then Exit Function
'			End If
'		Next 

'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal
'		If DKTRL_CUMUL <> 0 Then
'			frmBoeking.cmdBoeken.Enabled = False
'			MsgBox("LogikaFout bij vierkantskontrole journaal." & vbCrLf & vbCrLf & "Deze verrichting wordt geannuleerd.  Controleer zelf eerst en/of raadpleeg ons.")
'			frmBoeking.ShowDialog()
'			WegBoekFout = True
'		ElseIf JOURNAL_LOCKED = True Then 
'			frmBoeking.cmdBoeken.Enabled = False
'			frmBoeking.ShowDialog()
'			WegBoekFout = True
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
'			If DKTRL_CUMUL = 0 Then WegBoekFout = False
'		End If

'	End Function



'	Function fnBeginOpname(ByRef DeString As String) As Boolean

'		sDatumAanmaak = Mid(DeString, 6, 6)
'		sToepassingsCode = Mid(DeString, 15, 2)
'		sNaamBestemmeling = Mid(DeString, 35, 26)
'		If sToepassingsCode = "05" Then
'			fnBeginOpname = True
'		Else
'			fnBeginOpname = False
'		End If

'	End Function


'	Function fnOudSaldo(ByRef DeString As String) As Boolean

'		sRekeningNummer = Mid(DeString, 6, 12)
'		sUittreksel = Mid(DeString, 3, 3) '?
'		cOudSaldo = Val(Mid(DeString, 44, 15)) / 1000
'		sDatumOudSaldo = Mid(DeString, 59, 6)
'		sNaamRekeninghouder = Mid(DeString, 65, 26)
'		sOmschrijvingRekening = Mid(DeString, 91, 35)
'		fnOudSaldo = True
'		iOptelControle = iOptelControle + 1

'	End Function


'	Function fnNieuwSaldo(ByRef DeString As String) As Boolean

'		sRekeningNummer2 = Mid(DeString, 5, 12)
'		sUittreksel2 = Mid(DeString, 2, 3) '?
'		cNieuwSaldo = Val(Mid(DeString, 43, 15)) / 1000
'		sDatumNieuwSaldo = Mid(DeString, 58, 6)
'		fnNieuwSaldo = True
'		iOptelControle = iOptelControle + 1

'	End Function


'	Function fnEindOpname(ByRef DeString As String) As Boolean

'		iOptelCtrlCheckUp = Val(Mid(DeString, 17, 6))
'		If iOptelCtrlCheckUp <> iOptelControle Then
'			SnelHelpPrint("Onlogische situatie", False)
'		End If
'		cDebetSaldo = Val(Mid(DeString, 23, 15)) / 1000
'		cCreditSaldo = Val(Mid(DeString, 38, 15)) / 1000
'		If Mid(DeString, 128, 1) = "1" Then
'			fnEindOpname = False
'		Else
'			fnEindOpname = True
'		End If

'	End Function

'	Function fnBeweging(ByRef DeString As String) As Boolean

'		iOptelControle = iOptelControle + 1
'		Select Case Mid(DeString, 2, 1)
'			Case "1" 'Deel 1
'				sRefFinInstelling = Mid(DeString, 11, 13)
'				sRefFinInstelling2 = Mid(DeString, 24, 8)
'				sDC = Mid(DeString, 32, 1) '"0" = credit "1" = debet
'				cBedrag = Val(Mid(DeString, 33, 15)) / 1000
'				sValutadatum = Mid(DeString, 48, 6)
'				sVerrichting = Mid(DeString, 55, 4) '01xx OVERSCHRIJVINGEN (C)
'				'0301 CHEQUE UW BETALING (D)
'				'03xx CHEQUE ONTVANGEN (C)
'				'0503 ONBETAALDE INVORDERING (D)
'				'0556 ONUITVOERBARE TERUGBETALING (C)
'				'09xx STORTINGEN (C)
'				sMededeling = Mid(DeString, 62, 1) '"1" = gestructureerd
'				If sMededeling <> "1" Then
'					'verwittiging nog geven voor manuele verwerking
'				End If
'				sMDDZone1 = Mid(DeString, 63, 3) '
'				sMDDZone2 = Mid(DeString, 66, 50)
'				sBoekDatum = Mid(DeString, 116, 6)
'				sDagAfschriftVolgNummer = Mid(DeString, 122, 3)

'			Case "2" 'Deel 2
'				sMededeling2 = Mid(DeString, 11, 53)
'				For COUNT_TO = 0 To 1
'					sRefKlant(COUNT_TO) = Mid(DeString, 64 + (COUNT_TO * 13), 13)
'				Next 
'				sMuntVerrichting = Mid(DeString, 90, 3)
'				cBedragMunt = Val(Mid(DeString, 93, 15)) / 1000

'			Case "3" 'Deel 3
'				sRekeningTP = Mid(DeString, 11, 12)
'				sITcodesTP = Mid(DeString, 23, 10)
'				sRekeningTPextra = Mid(DeString, 33, 15)
'				For COUNT_TO = 0 To 2
'					sNaamEnAdres(COUNT_TO) = Mid(DeString, 48 + (COUNT_TO * 26), 26)
'				Next 

'			Case Else
'				MsgBox("Onlogische situatie", MsgBoxStyle.Critical)

'		End Select
'		If Mid(DeString, 126, 1) = "0" Then 'er is géén vervolg !
'			fnBeweging = False
'		Else
'			fnBeweging = True
'		End If

'	End Function

'	Function BewegingSchoon() As Short

'		sRefFinInstelling = ""
'		sRefFinInstelling2 = ""
'		sDC = ""
'		cBedrag = 0
'		sVerrichting = ""
'		sMededeling = ""
'		sMDDZone1 = ""
'		sMDDZone2 = ""
'		sBoekDatum = ""
'		sDagAfschriftVolgNummer = ""
'		sValutadatum = ""
'		sMededeling2 = ""
'		sRefKlant(0) = ""
'		sRefKlant(1) = ""
'		sMuntVerrichting = ""
'		cBedragMunt = 0
'		sRekeningTP = ""
'		sITcodesTP = ""
'		sRekeningTPextra = ""
'		sNaamEnAdres(0) = ""
'		sNaamEnAdres(1) = ""
'		sNaamEnAdres(2) = ""

'	End Function
'End Class