﻿Option Strict Off
Option Explicit On
Imports System.ComponentModel

Public Class BetalingsVerzoek
	Private Const V As Integer = 0
	Dim companiesRS As ADODB.Recordset
	Dim policiesRS As ADODB.Recordset
	Dim invoicesRS As ADODB.Recordset

	Dim SDLijn(3) As String
	Dim SDTitel As String
	Dim KlantNummer As String = Space(12)
	Dim PolisNummer As String = Space(12)
	Dim TaalTekst As String = Space(2)
	Dim TotaalBEF As Decimal
	Dim TotaalEUR As Decimal
	Dim ReferteTxt As String = Space(20)
	Dim FlLogBestand As Integer

	Dim BeginXbox As Integer
	Dim BeginYbox As Integer
	Dim OVSStrooklijnen As Integer

	Dim KontaktPersoon As Integer
	Dim IndexBM As String = Space(6)
	Dim TaksEnKost As Decimal
	Dim BedragEUR As Decimal
	Dim BrutoPremie As Decimal
	Dim PaperLess As Decimal

	Dim TotaalTeBetalen As Decimal
	Dim datKwijting As String

	Dim pdfY As Double
	Dim pdfOVSStrook As Double

	Dim sharedPolis As String
	Dim sharedTotaal As Decimal

	Dim sharedvsfTB2 As String

	Dim isDOM As Boolean
	Dim dokumentType As String
	Dim rSip(6) As String
	Dim sSip(6) As String
	Dim rNTTxt As String
	Dim rNTTxt2 As String

	Dim T As Integer
	Dim TT As Integer
	Dim Taal As String
	Dim FlTemp As Integer
	Dim rft(10) As String
	Dim rnr As String
	Dim sy As String
	Dim sy2 As String

	Dim XVan As Single
	Dim XTot As Single
	Dim YVan As Single
	Dim YTot As Single
	Dim X As Integer
	Dim MeerLijn As Integer

	Dim Nog As Integer
	Dim NogString As String
	Dim ovsDefinitie As String
	Dim klFsma As String

	Dim isMailMode As Boolean = False
	Dim locPOSTVAKIN As String

	Private Sub BetalingsVerzoek_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		cbPaymentType.Items.Add("0: Kies bewerkingskode !")
		cbPaymentType.Items.Add("1: Bericht van vervaldag")
		cbPaymentType.Items.Add("2: Kontante Afrekening Premie")
		cbPaymentType.Items.Add("3: Memo Vervaldagbericht")
		cbPaymentType.Items.Add("4: Kwijting")
		cbPaymentType.Items.Add("5: Verzekeringsaanbod")
		cbPaymentType.SelectedIndex = 0

		cbLanguage.Items.Add("1: Frans")
		cbLanguage.Items.Add("2: Nederlands")
		cbLanguage.Items.Add("3: Engels")
		cbLanguage.Items.Add("4: Duits")
		cbLanguage.SelectedIndex = 1

		ListViewPostDetail.View = View.Details
		With ListViewPostDetail.Columns
			.Add("Polis", 79, HorizontalAlignment.Left)
			.Add("Vervaldag", 73, HorizontalAlignment.Left)
			.Add("Premie", 60, HorizontalAlignment.Right)
			.Add("Taksen", 60, HorizontalAlignment.Right)
			.Add("Klant (naam 1)", 177, HorizontalAlignment.Left)
			.Add("Comm.%", 64, HorizontalAlignment.Right)
			.Add("TB2", 95, HorizontalAlignment.Left)
		End With

		ListViewMailDetail.View = View.Details
		With ListViewMailDetail.Columns
			.Add("Polis", 79, HorizontalAlignment.Left)
			.Add("Vervaldag", 73, HorizontalAlignment.Left)
			.Add("Premie", 60, HorizontalAlignment.Right)
			.Add("Taksen", 60, HorizontalAlignment.Right)
			.Add("Klant (naam 1)", 177, HorizontalAlignment.Left)
			.Add("Comm.%", 64, HorizontalAlignment.Right)
			.Add("TB2", 95, HorizontalAlignment.Left)
		End With

		InstallMij()

		KontaktPersoon = Val(String99(READING, 201))
		locPOSTVAKIN = SettingLoading("marSettings", "MarioCloud")

		bClear.PerformClick()

	End Sub

	Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click

		If ListViewPostDetail.Items.Count Then
			MSG = "Aangeduide verrichtingen negeren." & vbCrLf & vbCrLf & "Bent U zeker ?"
			KTRL = MsgBox(MSG, 292, "Voortijdig stoppen...")
			If KTRL = 6 Then
			Else
				Exit Sub
			End If
		End If
		GRIDTEXT = ""
		Me.Close()

	End Sub

	Private Sub RasterSchoon()

		ListViewPostDetail.Items.Clear()
		ListViewMailDetail.Items.Clear()

	End Sub

	Private Sub Schoon()

		btPrintOut.Enabled = False
		Button1.Enabled = False
		btnAdd.Enabled = False

		cbPaymentType.SelectedIndex = 0
		DateTimePicker.Text = MIM_GLOBAL_DATE
		RasterSchoon()
		cbPaymentType.SelectedIndex = 0
		CRLFCaption.Text = Dec(0, "##0")

	End Sub

	Private Sub BetalingsVerzoek_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		Dim hierCancel As Boolean = e.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = CloseReason.ApplicationExitCall
		If Mim.Report.IsOpen = True Then
			MsgBox("Sluit eerst het VPE venster a.u.b.", MsgBoxStyle.Information)
			hierCancel = True
		Else
			'stop
			Mim.RequestForPaymentMenuItem.Enabled = True
		End If
		e.Cancel = hierCancel

	End Sub

	Private Sub InstallMij()

		cbListCompanies.Items.Clear()
		cbListCompanies.Items.Add("Alle maatschappijen")

		Dim sSQL As String
		sSQL = "SELECT A110, A100, A400 FROM Leveranciers WHERE A110 Like 'CO%' ORDER BY A110"

		' Create a recordset using the provided collection
		companiesRS = New ADODB.Recordset
		companiesRS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		companiesRS.Open(sSQL, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
		If companiesRS.RecordCount <= 0 Then
			'MsgBox("Geen diverse posten binnen deze selectie", vbInformation)
			Beep()
		Else
			companiesRS.MoveFirst()
			Do While Not companiesRS.EOF

				cbListCompanies.Items.Add(Mid(companiesRS.Fields("A110").Value, 3, 4) & ": " & companiesRS.Fields("A100").Value & "/" & companiesRS.Fields("A400").Value)
				companiesRS.MoveNext()
			Loop
			cbListCompanies.SelectedIndex = 0
		End If
		companiesRS.Close()

	End Sub

	Private Sub cbPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPaymentType.SelectedIndexChanged

		Dim tempoFL As Integer
		Dim CRLFTeller As Integer

		If cbPaymentType.SelectedIndex = 0 Then
			cbListCompanies.Visible = False
		Else
			cbListCompanies.Visible = True
		End If
		If cbPaymentType.SelectedIndex = 1 Then
			Post.Visible = True
		Else
			Post.Visible = False
		End If

		TaalTekst = Mid(cbLanguage.Text, 1, 1) & Mid(cbPaymentType.Text, 1, 1)
		If Dir(LOCATION_COMPANYDATA & "kwijt" & TaalTekst & ".DEF") = "" Then
			tbInfoTekst.Text = ""
		Else
			tempoFL = FreeFile()
			tbInfoTekst.Text = ""
			FileOpen(tempoFL, LOCATION_COMPANYDATA & "kwijt" & TaalTekst & ".DEF", OpenMode.Input)
			aa = ""
			CRLFTeller = 0
			Do While Not EOF(tempoFL)
				A = LineInput(tempoFL)
				aa = aa & A & vbCrLf
				CRLFTeller = CRLFTeller + 1
			Loop
			tbInfoTekst.Text = Mid(aa, 1, Len(aa) - 2)
			CRLFCaption.Text = Dec(CRLFTeller, "##0")
			FileClose(tempoFL)
		End If

	End Sub

	Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click

		Schoon()

	End Sub

	Private Sub DateTimePicker_Leave(sender As Object, e As EventArgs) Handles DateTimePicker.Leave

		If DateWrongFormat(Format(DateTimePicker.Value, "dd/MM/yyyy")) Then
			DateTimePicker.Text = MIM_GLOBAL_DATE
			Beep()
			DateTimePicker.Focus()
		End If

	End Sub

	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

		'GRIDTEXT_REMISSION = $"NCN300087751{vbTab}20/01/2018{vbTab}62.48{vbTab}0.00{vbTab}Bruyland{vbTab}0.00{vbTab}'XEH+03+1+0304'GIS+B004+3'IPD+A502+214'IPD+A532+N05:::PERSOONLIJKE VERKEER'DTM+005:01022018'DTM+004:0102:003'RFF+001:NCN300087751'RFF+027:0000083919113'ATT+B003+4'ATT+A660+EUR'ATT+A325+1'ATT+B001+1'MOA+013:5351:EUR:2'MOA+212:5351:EUR:2'MOA+016:897:EUR:2'MOA+012:6248:EUR:2'MOA+210:246:EUR:2'MOA+211:262:EUR:2'MOA+015:1338:EUR:2'FTX+018+Tariefwijziging. U kan uw contract aangetekend opzeggen:binnen de 3 maanden vanaf dit bericht.'XRH+1'CLS+003+AD947NE-01/98'XRT+1'XRH+1'PTY+002+11578+BCAB90135601+AQI'XRT+1'XRH+1'PTY+003'NME+001+BRUYLAND:Denis'ATT+A10C+2'XRT+1'XRH+1'PTY+006+0097++36'XRT+1'XRH+1'PER+003'DTM+041:01022018'DTM+022:31012019'XRH+2'ROD+030'XRH+3'ICD+210:::Overlijden'DTM+008:01022018'MOA+013:2344:EUR:2'MOA+212:2344:EUR:2'MOA+016:393:EUR:2'MOA+210:108:EUR:2'MOA+211:115:EUR:2'MOA+015:586:EUR:2'XRT+3'XRH+3'ICD+220:::Blijvende invaliditeit'DTM+008:01022018'MOA+013:2409:EUR:2'MOA+212:2409:EUR:2'MOA+016:404:EUR:2'MOA+210:111:EUR:2'MOA+211:118:EUR:2'MOA+015:602:EUR:2'XRT+3'XRH+3'ICD+230:::Tijdelijke ongeschiktheid'DTM+008:01022018'MOA+013:420:EUR:2'MOA+212:420:EUR:2'MOA+016:70:EUR:2'MOA+210:19:EUR:2'MOA+211:21:EUR:2'MOA+015:105:EUR:2'XRT+3'XRH+3'ICD+240:::Medische kosten'DTM+008:01022018'MOA+013:178:EUR:2'MOA+212:178:EUR:2'MOA+016:30:EUR:2'MOA+210:8:EUR:2'MOA+211:9:EUR:2'MOA+015:45:EUR:2'XRT+3'XRT+2'XRT+1'XET+03'"
		'GRIDTEXT_REMISSION = $"GB187415{vbTab}02/03/2018{vbTab}25.54{vbTab}6.10{vbTab}De Wolf{vbTab}0.00{vbTab}"
		'InsertContante("93035771")
		'GRIDTEXT_REMISSION = $"{vbTab}{vbTab}{vbTab}{vbTab}{vbTab}{vbTab}"
		GRIDTEXT_REMISSION = vbTab & vbTab & vbTab & vbTab & vbTab & vbTab


		KwijtingEdit.Hide()
		KwijtingEdit.ShowDialog()
		Me.Activate()
		If GRIDTEXT_REMISSION = "ESC" Then
		Else
			Dim kwijtingArray() As String = Split(GRIDTEXT_REMISSION, vbTab)
			Dim itemHier As New ListViewItem(kwijtingArray(0))
			With itemHier.SubItems
				.Add(kwijtingArray(1))
				.Add(Format(Val(kwijtingArray(2)), "#,##0.00"))
				.Add(Format(Val(kwijtingArray(3)), "#,##0.00"))
				.Add(kwijtingArray(4))
				.Add(Format(Val(kwijtingArray(5)), "0.00"))
				.Add(kwijtingArray(6))
			End With
			ListViewPostDetail.Items.Add(itemHier)
		End If

	End Sub

	Private Sub cbPaymentType_Leave(sender As Object, e As EventArgs) Handles cbPaymentType.Leave

		Dim Msg2 As String
		If Post.CheckState Then
			Msg2 = "(post)"
		Else
			Msg2 = "(bezoek)"
		End If '			

		If cbPaymentType.SelectedIndex = 1 Then
			If ListViewPostDetail.Items.Count = 0 Then
			Else
				Exit Sub
			End If
		Else
			Exit Sub
		End If

		MSG = "Kwijtingen " & Msg2 & " met vervaldag voor de" & vbCrLf & Mid(PERIOD_FROMTO, 5, 2) & "e maand inladen ?"
		KTRL = MsgBox(MSG, 292)
		If KTRL = MsgBoxResult.Yes Then
			InsertTermijn()
			ListViewPostDetail.Focus()
			If ListViewPostDetail.Items.Count Then btPrintOut.Enabled = True
			If ListViewMailDetail.Items.Count Then Button1.Enabled = True
		End If

	End Sub

	Function CommissieCheck(ByRef Maatschappij As String, ByRef PolisNummer As String) As Single

		Dim NettoPremie As Decimal
		Dim Commissie As Decimal

		JetGet(TABLE_VARIOUS, 1, "25" & SetSpacing(Maatschappij, 4) & PolisNummer)
		If KTRL Then
			CommissieCheck = 0
		Else
			RecordToField(TABLE_VARIOUS)
			NettoPremie = Val(AdoGetField(TABLE_VARIOUS, "#B013 #"))
			Commissie = Val(AdoGetField(TABLE_VARIOUS, "#B014 #"))
			If NettoPremie = 0 Then
				CommissieCheck = 0
			Else
				CommissieCheck = (Commissie / NettoPremie) * 100
			End If
		End If

	End Function

	Private Sub InsertTermijn()

		Dim Ktrl2 As Integer
		Dim ZoekMaand As String
		Dim Dummy As String
		Dim tb2Dummy As String = ""
		Dim PostOfBezoek As String
		Dim X As Integer
		Dim TaksEnKost As Decimal
		Dim comPercentage As Single

		Dim getClient As String
		Dim getPolice As String

		Dim dbBA010 As Double
		Dim dbBB010 As Double
		Dim strV035 As String
		Dim mailFlag As Boolean = False

		Select Case Post.CheckState
			Case 1
				PostOfBezoek = "1"
			Case Else
				PostOfBezoek = "2"
		End Select

		ZoekMaand = Mid(PERIOD_FROMTO, 5, 2)

		' Create a invoice recordset using the provided collection
		invoicesRS = New ADODB.Recordset With {
			.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		}

		' Create a polices recordset using the provided collection
		policiesRS = New ADODB.Recordset With {
			.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		}

		Dim sSQL As String
		sSQL = "SELECT * FROM Polissen WHERE v164 = '" & ZoekMaand & "' AND vs97 = '" & PostOfBezoek & "' ORDER BY A110"
		policiesRS.Open(sSQL, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
		If policiesRS.RecordCount <= 0 Then
			Beep()
			Exit Sub
		Else
			Cursor.Current = Cursors.WaitCursor
			Enabled = False
			ListViewPostDetail.Refresh()
			policiesRS.MoveFirst()
			Do While Not policiesRS.EOF
				'select beperken tot: A110, vs97, v164
				getClient = policiesRS.Fields("A110").Value

				JetGet(TABLE_CUSTOMERS, 0, getClient)
				If KTRL Then
					Dummy = "KlantLink onmogelijk !!! Kontroleer !!!"
				Else
					RecordToField(TABLE_CUSTOMERS)
					Dummy = Trim(AdoGetField(TABLE_CUSTOMERS, "#A100 #") & " " & AdoGetField(TABLE_CUSTOMERS, "#A101 #"))
					If Val(AdoGetField(TABLE_CUSTOMERS, "#g101 #")) > 0 Then
						mailFlag = True
					Else
						mailFlag = False
					End If
				End If

				getPolice = policiesRS.Fields("A000").Value
				sSQL = "SELECT * FROM Dokumenten WHERE A000 = '" & getPolice & "'"
				invoicesRS.Open(sSQL, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
				If invoicesRS.RecordCount <= 0 Then
					Dummy = "!" & Dummy
				Else
					Ktrl2 = -1
					invoicesRS.MoveFirst()
					Do While Not invoicesRS.EOF
						getClient = policiesRS.Fields("A110").Value

						If IsDBNull(invoicesRS.Fields("B010").Value) Then
							dbBA010 = 0
						Else
							dbBA010 = Val(invoicesRS.Fields("B010").Value)
						End If

						If IsDBNull(policiesRS.Fields("B010").Value) Then
							Stop
						Else
							dbBB010 = Val(policiesRS.Fields("B010").Value)
						End If
						strV035 = invoicesRS.Fields("v035").Value

						'If Val(AdoGetField(TABLE_INVOICES, "#B010 #")) = Val(AdoGetField(TABLE_CONTRACTS, "#B010 #")) And VB.Left(AdoGetField(TABLE_INVOICES, "#v035 #"), 6) = VB.Left(PERIOD_FROMTO.Value, 6) Then
						If dbBA010 = dbBB010 And Mid(strV035, 1, 6) = Mid(PERIOD_FROMTO, 1, 6) Then
							Ktrl2 = 0
							Exit Do
						End If
						invoicesRS.MoveNext()
					Loop
					'hier de invoiceRS sluiten?
					If Ktrl2 <> 0 Then
						Dummy = "!" & Dummy
						tb2Dummy = ""
					Else
						tb2Dummy = invoicesRS.Fields("rvxmltb2").Value
					End If
				End If
				invoicesRS.Close()
				Dim strA010 As String = policiesRS.Fields("A010").Value
				Dim strA000 As String = policiesRS.Fields("A000").Value
				Dim strB010 As String = policiesRS.Fields("B010").Value

				'JetGet(TABLE_VARIOUS, 1, "25" & SetSpacing(AdoGetField(TABLE_CONTRACTS, "#A010 #"), 4) & AdoGetField(TABLE_CONTRACTS, "#A000 #"))
				comPercentage = CommissieCheck(strA010, strA000)
				TaksEnKost = 0
				If KTRL Then
				Else
					RecordToField(TABLE_VARIOUS)
					If Val(strB010) = Val(AdoGetField(TABLE_VARIOUS, "#B010 #")) Then
						TaksEnKost = Val(AdoGetField(TABLE_VARIOUS, "#B011 #"))
					End If
				End If

				If cbListCompanies.SelectedIndex <> 0 Then
					If Mid(cbListCompanies.Text, 1, 4) = strA010 Then
						'hier bijvoegen enkel voor geselecteerde maatschappij
						Dim dataVeld As String = policiesRS.Fields("A000").Value
						Dim itemHier As New ListViewItem(dataVeld)
						Dim itemHierMail As New ListViewItem(dataVeld)
						Dim vervaldagHier As String = Mid(policiesRS.Fields("v165").Value, 1, 2) & "/" & Mid(policiesRS.Fields("v164").Value, 1, 2) & "/" & Mid(PERIOD_FROMTO, 1, 4)

						With itemHier.SubItems
							.Add(vervaldagHier)
							.Add(Format(Val(strB010), "#,##0.00"))
							.Add(Format(TaksEnKost, "#,##0.00"))
							.Add(Dummy)
							.Add(Format(comPercentage, "0.000"))
							.Add(tb2Dummy)
						End With
						ListViewPostDetail.Items.Add(itemHier)
						If mailFlag Then
							With itemHierMail.SubItems
								.Add(vervaldagHier)
								.Add(Format(Val(strB010), "#,##0.00"))
								.Add(Format(TaksEnKost, "#,##0.00"))
								.Add(Dummy)
								.Add(Format(comPercentage, "0.000"))
								.Add(tb2Dummy)
							End With
							ListViewMailDetail.Items.Add(itemHierMail)
						End If
					End If
				Else
					'hier bijvoegen voor alle maatschappijen
					Dim dataVeld As String = policiesRS.Fields("A000").Value
					Dim itemHier As New ListViewItem(dataVeld)
					Dim itemHierMail As New ListViewItem(dataVeld)
					Dim vervaldagHier As String = Mid(policiesRS.Fields("v165").Value, 1, 2) & "/" & Mid(policiesRS.Fields("v164").Value, 1, 2) & "/" & Mid(PERIOD_FROMTO, 1, 4)

					With itemHier.SubItems
						.Add(vervaldagHier)
						.Add(Format(Val(strB010), "#,##0.00"))
						.Add(Format(TaksEnKost, "#,##0.00"))
						.Add(Dummy)
						.Add(Format(comPercentage, "0.000"))
						.Add(tb2Dummy)
					End With
					ListViewPostDetail.Items.Add(itemHier)
					If mailFlag Then
						With itemHierMail.SubItems
							.Add(vervaldagHier)
							.Add(Format(Val(strB010), "#,##0.00"))
							.Add(Format(TaksEnKost, "#,##0.00"))
							.Add(Dummy)
							.Add(Format(comPercentage, "0.000"))
							.Add(tb2Dummy)
						End With
						ListViewMailDetail.Items.Add(itemHierMail)
					End If
				End If

				policiesRS.MoveNext() '
			Loop
			ListViewPostDetail.Refresh()
			If ListViewPostDetail.Items.Count Then btPrintOut.Enabled = True
			If ListViewMailDetail.Items.Count Then Button1.Enabled = True
			Cursor.Current = Cursors.Default
			Enabled = True '			 
			'			
		End If

	End Sub


	Private Sub lvPolicesDetail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewPostDetail.SelectedIndexChanged

		If btPrintOut.Enabled = True Then
		ElseIf ListViewPostDetail.Items.Count Then
			btPrintOut.Enabled = True
		End If

		'XLOG_KEY = X.FocusedItem.SubItems.Item(2).Text
		'lvPolicesDetail.GetItemAt(1, 1)

	End Sub

	Private Sub btPrintOut_Click(sender As Object, e As EventArgs) Handles btPrintOut.Click

		Dim teldetail As Integer
		Dim T As Integer
		Dim MaxGrens As Integer
		Dim TempoFL As Integer
		Dim PolisNummer As String
		Dim CrText As String
		Dim dPip As Double
		Dim XX As Integer
		Dim BedragBEF As Decimal
		Dim result As Boolean
		Dim ktrlBOOL As Boolean

		With Mim.Report
			.OpenDoc()
			.Author = "Jos Vermoesen"
			.GUILanguage = 3 'Nederlands
			.Title = "dnnInning4Brokers"
			.PenSize = 0.01
		End With
		MaxGrens = 10
		KlantNummer = ""

		Cursor.Current = Cursors.WaitCursor

		SDTitel = "Maatschappij" & Space(14)
		SDTitel = SDTitel & "Omschrijving" & Space(19)
		SDTitel = SDTitel & "BM / INDEX" & vbCrLf
		SDTitel = SDTitel & "Contract nr. " & Space(13)
		SDTitel = SDTitel & "Detail" & Space(25)
		SDTitel = SDTitel & "Val.dag"
		SDTitel = UCase(SDTitel)

		For T = 0 To ListViewPostDetail.Items.Count - 1
			PolisNummer = ListViewPostDetail.Items.Item(T).SubItems(0).Text
			sharedPolis = ListViewPostDetail.Items.Item(T).SubItems(0).Text
			sharedTotaal = Val(ListViewPostDetail.Items.Item(T).SubItems(2).Text)
			sharedvsfTB2 = ListViewPostDetail.Items.Item(T).SubItems(6).Text

			JetGet(TABLE_CONTRACTS, 0, PolisNummer)
			If KTRL Then
				MsgBox("Stop")
			Else
				RecordToField(TABLE_CONTRACTS) '				
			End If
			teldetail = 0
			'TotaalBEF = 0
			TotaalEUR = 0

			JetGet(TABLE_CUSTOMERS, 0, AdoGetField(TABLE_CONTRACTS, "#A110 #"))
			If KTRL Then
				MsgBox("stop")
			Else
				RecordToField(TABLE_CUSTOMERS)
			End If

			KlantNummer = AdoGetField(TABLE_CUSTOMERS, "#A110 #")
			JetGet(TABLE_SUPPLIERS, 0, "CO" & AdoGetField(TABLE_CONTRACTS, "#A010 #"))
			If KTRL Then
				Beep()
			Else
				RecordToField(TABLE_SUPPLIERS)
			End If

			JetGet(TABLE_VARIOUS, 1, "25" & SetSpacing(AdoGetField(TABLE_CONTRACTS, "#A010 #"), 4) & AdoGetField(TABLE_CONTRACTS, "#A000 #"))
			IndexBM = "  --  "
			TaksEnKost = 0
			If KTRL Then
			Else
				RecordToField(TABLE_VARIOUS)
				If Val(AdoGetField(TABLE_CONTRACTS, "#B010 #")) = Val(AdoGetField(TABLE_VARIOUS, "#B010 #")) Then
					TaksEnKost = Val(AdoGetField(TABLE_VARIOUS, "#B011 #"))
					BrutoPremie = Val(AdoGetField(TABLE_VARIOUS, "#B013 #"))
				End If
				If Mid(AdoGetField(TABLE_CONTRACTS, "#v223 #"), 1, 1) = "5" Then
					CrText = AdoGetField(TABLE_VARIOUS, "#5315 #")
					'BM voor huidige premie BA
					If Trim(CrText) = "" Then
					Else
						IndexBM = Format(Val(CrText), "00")
					End If
				Else
					'controle aanwezigheid index
					CrText = AdoGetField(TABLE_VARIOUS, "#AW.R #")
					'On Error Resume Next
					If CDbl(CrText) > 99 Then
						IndexBM = CrText
					Else
						IndexBM = Format(Val(CrText) / 100, "000.00")
					End If
				End If
			End If

			SDLijn(teldetail) = SetSpacing(AdoGetField(TABLE_SUPPLIERS, "#A100 #"), 25) & " "
			SDLijn(teldetail) = SDLijn(teldetail) & SetSpacing(AdoGetField(TABLE_CONTRACTS, "#vs99 #"), 30) & " "
			SDLijn(teldetail) = SDLijn(teldetail) & IndexBM & vbCrLf
			'SDLijn(teldetail) = SDLijn(teldetail) & SetSpacing(Mid(fmarBoxText("914", "2", AdoGetField(TABLE_CONTRACTS, "#A325 #")), 4), 14)
			If Val(AdoGetField(TABLE_CONTRACTS, "#A325 #")) > 7 Then
				isDOM = True
			Else
				isDOM = False
			End If

			If IsDBNull(RS_MAR(TABLE_CONTRACTS).Fields("e069").Value) Then
				BedragEUR = Val(RS_MAR(TABLE_CONTRACTS).Fields("B010").Value)
			Else
				BedragEUR = Val(RS_MAR(TABLE_CONTRACTS).Fields("B010").Value) + Val(RS_MAR(TABLE_CONTRACTS).Fields("e069").Value)
			End If
			'BedragBEF = System.Math.Round(BedragEUR * EURO)
			datKwijting = SetSpacing(Mid(AdoGetField(TABLE_CONTRACTS, "#AW_2 #"), 7, 2), 2) & "/" & SetSpacing(AdoGetField(TABLE_CONTRACTS, "#v164 #"), 2) & "/" & Mid(MIM_GLOBAL_DATE, 7, 4)

			'SDLijn(teldetail) = SDLijn(teldetail) & Dec(BedragBEF, MASK_SY(0)) & vbCrLf 'Premie in BEF
			SDLijn(teldetail) = SDLijn(teldetail) & SetSpacing(AdoGetField(TABLE_CONTRACTS, "#A000 #"), 12) & Space(14)
			SDLijn(teldetail) = SDLijn(teldetail) & SetSpacing(AdoGetField(TABLE_CONTRACTS, "#vs98 #"), 30) & " "
			SDLijn(teldetail) = SDLijn(teldetail) & datKwijting
			'SDLijn(teldetail) = SDLijn(teldetail) & "              " & Dec(BedragEUR, MASK_EUR) 'Premie in EUR

			'TotaalBEF = TotaalBEF + BedragBEF
			TotaalEUR = TotaalEUR + BedragEUR

			ReferteTxt = "+++" & Format(teldetail + 1) & Format(Val(AdoGetField(TABLE_CONTRACTS, "#v164 #")), "00") & "/" & Mid(KlantNummer, 1, 4) & "/0" & Mid(KlantNummer, 5, 2) & "xx+++"
			dPip = Val(Mid(ReferteTxt, 4, 3) & Mid(ReferteTxt, 8, 4) & Mid(ReferteTxt, 13, 3))
			Mid(ReferteTxt, 16, 2) = Format(dPip - Int(dPip / 97) * 97, "00")
			If Mid(ReferteTxt, 16, 2) = "00" Then
				Mid(ReferteTxt, 16, 2) = "97"
			End If

			XX = pdfDrukAf()
			If T = ListViewPostDetail.Items.Count - 1 Then
			Else
				ktrlBOOL = Mim.Report.PageBreak
			End If
		Next

		Cursor.Current = Cursors.Default
		Mim.Report.WriteDoc(LOCATION_COMPANYDATA & Format(Now, "YYYYMMDDHHMMSS") & "-dnnInning4Brokers.pdf")
		'Mim.Report.CloseDoc()
		Mim.Report.Preview()

		Schoon()
		cbPaymentType.Focus()

	End Sub

	Private Function pdfDrukAf() As Integer

		pdfOVSStrook = 8.2
		ovsDefinitie = "FORM-IBAN.TXT"
		Taal = "2"  'AdoGetField(TABLE_CUSTOMERS, "#A10C #")

		pdfKopBALK()
		pdfDetailLijnen()

		If MetOverschrijving.CheckState Then
			pdfOverschrijvingsstrook()
		End If

		If cbTB2Info.CheckState Then
			KTRL = Mim.Report.PageBreak
			Mim.Report.SelectFont("Courier New", 8)
			pdfY = Mim.Report.Print(1, 1, Tb2Indent(sharedvsfTB2))
		End If

		Return 0

	End Function

	Sub pdfKopBALK()

KopBalk:
		dokumentType = Mid(cbPaymentType.Text, 4)
		If Val(AdoGetField(TABLE_CUSTOMERS, "#A102 #")) = 0 Then
			rSip(0) = AdoGetField(TABLE_CUSTOMERS, "#A100 #") & " " & AdoGetField(TABLE_CUSTOMERS, "#A101 #")
		Else
			rSip(0) = Mid(fmarBoxText("003", Taal, AdoGetField(TABLE_CUSTOMERS, "#A102 #")), 4, 10) & " " & AdoGetField(TABLE_CUSTOMERS, "#A100 #") & " " & AdoGetField(TABLE_CUSTOMERS, "#A101 #")
		End If
		If KontaktPersoon = 1 Then
			If Val(AdoGetField(TABLE_CUSTOMERS, "#vs01 #")) = 0 Then
				rSip(1) = AdoGetField(TABLE_CUSTOMERS, "#A125 #") & " " & AdoGetField(TABLE_CUSTOMERS, "#A127 #")
			Else
				rSip(1) = Mid(fmarBoxText("003", Taal, AdoGetField(TABLE_CUSTOMERS, "#vs01 #")), 4, 10) & " " & AdoGetField(TABLE_CUSTOMERS, "#A125 #") & " " & AdoGetField(TABLE_CUSTOMERS, "#A127 #")
			End If
		Else
			rSip(1) = ""
		End If
		rSip(2) = AdoGetField(TABLE_CUSTOMERS, "#A104 #") & " " & AdoGetField(TABLE_CUSTOMERS, "#A105 #") & " " & AdoGetField(TABLE_CUSTOMERS, "#A106 #")
		rSip(4) = AdoGetField(TABLE_CUSTOMERS, "#A109 #") & " " & AdoGetField(TABLE_CUSTOMERS, "#A107 #") & " " & AdoGetField(TABLE_CUSTOMERS, "#A108 #")

		With Mim.Report
			.SelectFont("Courier New", 7.2)
			.TextBold = True
			.TextColor = System.Drawing.ColorTranslator.FromOle(0) 'zwart
		End With

		pdfPrintKopTekst()

		Mim.Report.PenSize = 0.01
		pdfY = Mim.Report.PrintBox(0.7, PDF_VSOFT_FROM, UCase(dokumentType))

		Mim.Report.TextBold = False
		pdfY = Mim.Report.Print(10, PDF_VSOFT_FROM, Format(Now, "dddd dd MMM yyyy") & vbCrLf & vbCrLf)
		'		
		Mim.Report.SelectFont("Courier New", 8)

	End Sub

	Sub pdfPrintKopTekst()

		Dim ktrlHier As Integer
		Dim tSip As Integer
		Dim adresString As String = ""

PrintKopTekst:
		pdfPrintUserDef("1" & Format("2") & "0", pdfOVSStrook)
		With Mim.Report
			.SelectFont("Courier New", 10)
			.TextBold = True
			.TextItalic = False
			.TextUnderline = False
			.TextAlignment = 0
			.TextColor = System.Drawing.ColorTranslator.FromOle(0) 'zwart
		End With

		For tSip = 0 To 4
			adresString = adresString & UCase(rSip(tSip)) & vbCrLf
		Next
		ktrlHier = Mim.Report.Write(PDF_ADDRESS_XPOS, PDF_ADDRESS_YPOS, PDF_ADDRESS_XPOS2, PDF_ADDRESS_YPOS2, adresString)

	End Sub

	Sub pdfPrintUserDef(ByRef TypeEnTaal As String, ByRef pdfOVSStrook As Double)
		Dim pfcmd As Short
		Dim FlFree As Short
		Dim pdfCmd As String
		If Dir(LOCATION_COMPANYDATA & "pdfDDEF" & TypeEnTaal & ".Txt") = "" Then
			Beep()
			Exit Sub
		Else
			With Mim.Report
				.nTopMargin = 1
				.nLeftMargin = 0.5
				.nRightMargin = 20.8
				.nBottomMargin = 29.8
			End With
			FlFree = FreeFile()
			FileOpen(FlFree, LOCATION_COMPANYDATA & "pdfDDEF" & TypeEnTaal & ".Txt", OpenMode.Input)
			Do While Not EOF(FlFree)
				pdfCmd = LineInput(FlFree)
				If Mid(pdfCmd, 1, 1) = "'" Then
				Else
					Select Case Trim(UCase(pdfCmd))
						Case "CMD-VSOFTSPACE"
							CMDVSOFTSPACE(FlFree)
						Case "CMD-ADRESSPACE"
							CMDADRESSPACE(FlFree)
						Case "CMD-WRITE"
							CMDWRITE(FlFree)
						Case "CMD-WRITEBOX"
							CMDWRITEBOX(FlFree)
						Case "CMD-PRINT"
							CMDPRINT(FlFree, pdfOVSStrook)
						Case "CMD-PICTURE"
							CMDPICTURE(FlFree)
						Case Else
							MsgBox(pfcmd & " nog niet voorzien", MsgBoxStyle.Critical)
					End Select
				End If
			Loop
			FileClose(FlFree)
		End If
	End Sub


	Sub pdfDetailLijnen()

		Dim tmpPdfY As Double
		Dim tmpMsg As String

DetailLijnen:
		Mim.Report.SelectFont("Courier New", 8)
		Mim.Report.TextBold = False
		Mim.Report.PenSize = 0.01
		tmpPdfY = pdfY

		pdfY = Mim.Report.PrintBox(0.7, pdfY, SDTitel)
		pdfY = Mim.Report.Print(0.7, pdfY, " ")

		tmpMsg = "FSMA Reglement Kosten & Lasten     in EUR" & vbCrLf
		tmpMsg = tmpMsg & "https://rv.be/Fsma.aspx"
		pdfY = Mim.Report.PrintBox(12.8, tmpPdfY, tmpMsg)
		pdfY = Mim.Report.Print(0.8, pdfY, " ")
		tmpPdfY = pdfY

		tmpMsg = "Handelspremie:                   " + Dec(Val(AdoGetField(TABLE_VARIOUS, "#B010 #")) - Val(AdoGetField(TABLE_VARIOUS, "#B011 #")), Mid(MASK_EUR, 3)) + vbCrLf
		If Val(AdoGetField(TABLE_VARIOUS, "#v401 #")) + Val(AdoGetField(TABLE_VARIOUS, "#v402 #")) = 0 Then
			tmpMsg = tmpMsg + " > acquisitiekost niet meegedeeld" + vbCrLf + " > administratiekost niet meegedeeld" + vbCrLf
			tmpMsg = tmpMsg + " > Splitsingskost" + Dec(Val(AdoGetField(TABLE_VARIOUS, "#v400 #")), Mid(MASK_EUR, 4)) + vbCrLf
		Else
			tmpMsg = tmpMsg + " > Acquisitiekost" + Dec(Val(AdoGetField(TABLE_VARIOUS, "#v401 #")), Mid(MASK_EUR, 4)) + vbCrLf
			tmpMsg = tmpMsg + " > Administratie " + Dec(Val(AdoGetField(TABLE_VARIOUS, "#v402 #")), Mid(MASK_EUR, 4)) + vbCrLf
			tmpMsg = tmpMsg + " > Splitsingskost" + Dec(Val(AdoGetField(TABLE_VARIOUS, "#v400 #")), Mid(MASK_EUR, 4)) + vbCrLf
		End If

		tmpMsg = tmpMsg + vbCrLf
		tmpMsg = tmpMsg + "Taksen:                          " + Dec(Val(AdoGetField(TABLE_VARIOUS, "#B011 #")), Mid(MASK_EUR, 3)) + vbCrLf
		tmpMsg = tmpMsg + vbCrLf
		tmpMsg = tmpMsg + "Premie Subtotaal:                " + Dec(Val(AdoGetField(TABLE_VARIOUS, "#B010 #")), Mid(MASK_EUR, 3)) + vbCrLf
		tmpMsg = tmpMsg + "Makelaarfee:                     " + Dec(TotaalEUR - Val(AdoGetField(TABLE_VARIOUS, "#B010 #")), Mid(MASK_EUR, 3)) + vbCrLf
		Mim.Report.TextBold = True
		pdfY = Mim.Report.PrintBox(12.8, pdfY, tmpMsg)

		tmpMsg = "Totaal factuur:                  " + Dec(TotaalEUR, Mid(MASK_EUR, 3)) + vbCrLf
		Mim.Report.TextBold = True
		pdfY = Mim.Report.PrintBox(12.8, pdfY, tmpMsg)


		pdfY = tmpPdfY
		pdfY = Mim.Report.Print(0.8, pdfY, SDLijn(0)) 'telt voor 2 lijnen!!
		pdfY = Mim.Report.Print(0.8, pdfY, " ")


		Mim.Report.SelectFont("Arial", 8)
		Mim.Report.TextBold = False

		'TB2QualifiersJSON()
		'TB2ValeursJSON()


		MSG = TB2info2017()
		If MSG = "" Then
			pdfY = Mim.Report.Print(0.9, pdfY, " ")
			pdfY = Mim.Report.Print(0.9, pdfY, " ")
			pdfY = Mim.Report.Print(0.9, pdfY, " ")
		Else
			pdfY = Mim.Report.Print(0.6, pdfY, MSG)
		End If

InfoTekst:
		Mim.Report.SelectFont("Arial", 8)
		pdfY = 15.57398
		pdfY = Mim.Report.Print(0.6, pdfY, tbInfoTekst.Text)

	End Sub

	Sub pdfOverschrijvingsstrook()

Overschrijvingsstrook:
		'On Error GoTo 0
		If Dir(LOCATION_COMPANYDATA & ovsDefinitie) = "" Then
			MsgBox(LOCATION_COMPANYDATA & ovsDefinitie & " niet te vinden !  Hierna wordt kladblok opgestart.  Breng uw eigen gegevens in a.u.b. !", 0, "Foutieve Installatie ?")
			'On Error Resume Next
			X = Shell("notepad.exe " & LOCATION_COMPANYDATA & ovsDefinitie, 1)
			Exit Sub
		Else
			FlTemp = FreeFile()
			FileOpen(FlTemp, LOCATION_COMPANYDATA & ovsDefinitie, OpenMode.Input)
			sSip(0) = LineInput(FlTemp)
			sSip(1) = LineInput(FlTemp)
			sSip(2) = LineInput(FlTemp)
			sSip(3) = LineInput(FlTemp)
			sSip(4) = LineInput(FlTemp)
			sSip(5) = LineInput(FlTemp)
			sSip(6) = LineInput(FlTemp)
			FileClose(FlTemp)
		End If
		Mim.Report.SelectFont("Courier New", 12)
		Mim.Report.TextBold = True

		If isDOM Then
			rNTTxt = "********.**"
		Else
			rNTTxt = Dec(TotaalEUR, "#######0.00")
		End If

		pdfSpatieren()

		Mid(rNTTxt2, 17, 1) = " "
		Dim tmppdfY As Double
		pdfY = Mim.Report.Print(15, 22, rNTTxt2) 'bedrag

		Mim.Report.TextBold = False
		rNTTxt = Mid(UCase(rSip(0)), 1, 26) 'Klant naam1
		pdfSpatieren()
		pdfY = Mim.Report.Print(3.6, 23.7, rNTTxt2 & vbCrLf)

		rNTTxt = Mid(UCase(rSip(1)), 1, 26) 'Klant naam2
		pdfSpatieren()
		pdfY = Mim.Report.Print(3.6, pdfY, rNTTxt2 & vbCrLf)

		rNTTxt = Mid(UCase(rSip(4)), 1, 26) 'Klant plaats
		pdfSpatieren()
		pdfY = Mim.Report.Print(3.6, pdfY, rNTTxt2 & vbCrLf)

		Mim.Report.TextBold = True
		If isDOM = True Then
			rNTTxt = "*domiciliëring: enkel ter info*"
		Else
			rNTTxt = sSip(0) 'IBANbedrijf
		End If
		pdfSpatieren()
		pdfY = Mim.Report.Print(3.6, 25.3, rNTTxt2 & vbCrLf & vbCrLf)

		rNTTxt = sSip(1) 'BICbedrijf
		pdfSpatieren()
		pdfY = Mim.Report.Print(3.6, pdfY, rNTTxt2 & vbCrLf & vbCrLf)

		Mim.Report.TextBold = False
		For T = 2 To 4
			rNTTxt = sSip(T) 'ADRESbedrijf
			pdfSpatieren()
			pdfY = Mim.Report.Print(3.6, pdfY, UCase(rNTTxt2))
		Next

		rNTTxt = ReferteTxt
		pdfSpatieren()
		Mim.Report.TextBold = True
		pdfY = Mim.Report.Print(3.6, pdfY, rNTTxt2)
		'End If

	End Sub

	Sub pdfSpatieren()

		Dim Teltxt As Integer
		Dim iRNTxt As Integer

Spatieren:
		iRNTxt = Len(rNTTxt)
		rNTTxt2 = ""
		For Teltxt = 1 To iRNTxt
			rNTTxt2 = rNTTxt2 & Mid(rNTTxt, Teltxt, 1) & " "
		Next

	End Sub

	Private Sub MetOverschrijving_CheckedChanged(sender As Object, e As EventArgs) Handles MetOverschrijving.CheckedChanged

		'TODO

	End Sub



	Function TB2info2017() As String

		Dim dummyHier As String
		Dim buildUp As String = ""

		If Trim(sharedvsfTB2) = "" Then
			TB2info2017 = ""
		Else
			dummyHier = RODCheck(sharedvsfTB2)
			If dummyHier <> "" Then
				buildUp = dummyHier
			End If

			dummyHier = ICDCheck(sharedvsfTB2)
			If dummyHier <> "" Then
				buildUp = buildUp & vbCrLf & dummyHier
			End If

			dummyHier = FTXCheck(sharedvsfTB2)
			If dummyHier <> "" Then
				buildUp = buildUp & vbCrLf & vbCrLf & dummyHier
			End If

			TB2info2017 = buildUp
		End If

	End Function

	Function TB2info2018() As String

		Dim dummyHier As String
		Dim buildUp As String = ""

		If Trim(sharedvsfTB2) = "" Then
			TB2info2018 = "Niet beschikbaar"
		Else
			dummyHier = RODCheck(sharedvsfTB2)
			If dummyHier <> "" Then
				buildUp = dummyHier
			End If

			dummyHier = ICDCheck(sharedvsfTB2)
			If dummyHier <> "" Then
				buildUp = buildUp & vbCrLf & dummyHier
			End If

			dummyHier = FTXCheck(sharedvsfTB2)
			If dummyHier <> "" Then
				buildUp = buildUp & vbCrLf & vbCrLf & dummyHier
			End If

			TB2info2018 = buildUp
		End If

	End Function


	Private Sub cbListCompanies_VisibleChanged(sender As Object, e As EventArgs) Handles cbListCompanies.VisibleChanged

		btnAdd.Enabled = cbListCompanies.Visible

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		Dim teldetail As Integer
		Dim T As Integer
		Dim MaxGrens As Integer
		Dim TempoFL As Integer

		Dim CrText As String
		Dim dPip As Double
		Dim XX As Integer
		Dim BedragBEF As Double
		Dim result As Boolean
		Dim ktrlBOOL As Boolean

		Dim mailAddressV224 As String = ""
		Dim nameAddressV224 As String = ""

		Dim mailAddressv002 As String = ""
		Dim nameAddressv002 As String = ""

		Dim voorkeurg101 As String
		Dim idClient As String
		Dim idDocument As String
		Dim datumVerval As String
		Dim idMailAddress As String
		Dim idPdf As String = ""

		Dim VMAIL_TO As Long

		VMAIL_TO = 1

		Cursor.Current = Cursors.WaitCursor
		SDTitel = "Maatschappij" & Space(14)
		SDTitel = SDTitel & "Omschrijving" & Space(19)
		SDTitel = SDTitel & "BM / INDEX" & vbCrLf
		SDTitel = SDTitel & "Contract nr. " & Space(13)
		SDTitel = SDTitel & "Detail" & Space(25)
		SDTitel = SDTitel & "Val.dag"
		SDTitel = UCase(SDTitel)
		KlantNummer = ""

		For T = 1 To ListViewMailDetail.Items.Count - 1
			PolisNummer = ListViewMailDetail.Items.Item(T).SubItems(0).Text
			sharedPolis = ListViewMailDetail.Items.Item(T).SubItems(0).Text
			sharedTotaal = Val(ListViewMailDetail.Items.Item(T).SubItems(2).Text)
			sharedvsfTB2 = ListViewMailDetail.Items.Item(T).SubItems(6).Text
			datumVerval = ListViewMailDetail.Items.Item(T).SubItems(1).Text

			JetGet(TABLE_CONTRACTS, 0, PolisNummer)
			If KTRL Then
				MsgBox("Stop")
			Else
				RecordToField(TABLE_CONTRACTS) '				
			End If
			teldetail = 0
			'TotaalBEF = 0
			TotaalEUR = 0

			JetGet(TABLE_CUSTOMERS, 0, AdoGetField(TABLE_CONTRACTS, "#A110 #"))
			If KTRL Then
				MsgBox("stop")
			Else
				RecordToField(TABLE_CUSTOMERS)
			End If

			KlantNummer = AdoGetField(TABLE_CUSTOMERS, "#A110 #")
			JetGet(TABLE_SUPPLIERS, 0, "CO" & AdoGetField(TABLE_CONTRACTS, "#A010 #"))
			If KTRL Then
				Beep()
			Else
				RecordToField(TABLE_SUPPLIERS)
			End If

			JetGet(TABLE_VARIOUS, 1, "25" & SetSpacing(AdoGetField(TABLE_CONTRACTS, "#A010 #"), 4) & AdoGetField(TABLE_CONTRACTS, "#A000 #"))
			IndexBM = "  --  "
			TaksEnKost = 0
			If KTRL Then
			Else
				RecordToField(TABLE_VARIOUS)
				If Val(AdoGetField(TABLE_CONTRACTS, "#B010 #")) = Val(AdoGetField(TABLE_VARIOUS, "#B010 #")) Then
					TaksEnKost = Val(AdoGetField(TABLE_VARIOUS, "#B011 #"))
					BrutoPremie = Val(AdoGetField(TABLE_VARIOUS, "#B013 #"))
				End If
				If Mid(AdoGetField(TABLE_CONTRACTS, "#v223 #"), 1, 1) = "5" Then
					CrText = AdoGetField(TABLE_VARIOUS, "#5315 #")
					'BM voor huidige premie BA
					If Trim(CrText) = "" Then
					Else
						IndexBM = Format(Val(CrText), "00")
					End If
				Else
					'controle aanwezigheid index
					CrText = AdoGetField(TABLE_VARIOUS, "#AW.R #")
					'On Error Resume Next
					If CDbl(CrText) > 99 Then
						IndexBM = CrText
					Else
						IndexBM = Format(Val(CrText) / 100, "000.00")
					End If
				End If
			End If

			SDLijn(teldetail) = SetSpacing(AdoGetField(TABLE_SUPPLIERS, "#A100 #"), 25) & " "
			SDLijn(teldetail) = SDLijn(teldetail) & SetSpacing(AdoGetField(TABLE_CONTRACTS, "#vs99 #"), 30) & " "
			SDLijn(teldetail) = SDLijn(teldetail) & IndexBM & vbCrLf
			'SDLijn(teldetail) = SDLijn(teldetail) & SetSpacing(Mid(fmarBoxText("914", "2", AdoGetField(TABLE_CONTRACTS, "#A325 #")), 4), 14)
			If Val(AdoGetField(TABLE_CONTRACTS, "#A325 #")) > 7 Then
				isDOM = True
			Else
				isDOM = False
			End If

			If IsDBNull(RS_MAR(TABLE_CONTRACTS).Fields("e069").Value) Then
				BedragEUR = Val(RS_MAR(TABLE_CONTRACTS).Fields("B010").Value)
			Else
				BedragEUR = Val(RS_MAR(TABLE_CONTRACTS).Fields("B010").Value) + Val(RS_MAR(TABLE_CONTRACTS).Fields("e069").Value)
			End If
			'BedragBEF = System.Math.Round(BedragEUR * EURO)
			datKwijting = SetSpacing(Mid(AdoGetField(TABLE_CONTRACTS, "#AW_2 #"), 7, 2), 2) & "/" & SetSpacing(AdoGetField(TABLE_CONTRACTS, "#v164 #"), 2) & "/" & Mid(MIM_GLOBAL_DATE, 7, 4)

			'SDLijn(teldetail) = SDLijn(teldetail) & Dec(BedragBEF, MASK_SY(0)) & vbCrLf 'Premie in BEF
			SDLijn(teldetail) = SDLijn(teldetail) & SetSpacing(AdoGetField(TABLE_CONTRACTS, "#A000 #"), 12) & Space(14)
			SDLijn(teldetail) = SDLijn(teldetail) & SetSpacing(AdoGetField(TABLE_CONTRACTS, "#vs98 #"), 30) & " "
			SDLijn(teldetail) = SDLijn(teldetail) & datKwijting
			'SDLijn(teldetail) = SDLijn(teldetail) & "              " & Dec(BedragEUR, MASK_EUR) 'Premie in EUR

			'TotaalBEF = TotaalBEF + BedragBEF
			TotaalEUR = TotaalEUR + BedragEUR

			ReferteTxt = "+++" & Format(teldetail + 1) & Format(Val(AdoGetField(TABLE_CONTRACTS, "#v164 #")), "00") & "/" & Mid(KlantNummer, 1, 4) & "/0" & Mid(KlantNummer, 5, 2) & "xx+++"
			dPip = Val(Mid(ReferteTxt, 4, 3) & Mid(ReferteTxt, 8, 4) & Mid(ReferteTxt, 13, 3))
			Mid(ReferteTxt, 16, 2) = Format(dPip - Int(dPip / 97) * 97, "00")
			If Mid(ReferteTxt, 16, 2) = "00" Then
				Mid(ReferteTxt, 16, 2) = "97"
			End If

			If Mim.Report.IsOpen = True Then
				Mim.Report.CloseDoc()
			End If

			With Mim.Report
				.OpenDoc()
				.Author = "Jos Vermoesen"
				.GUILanguage = 3 'Nederlands
				.Title = "VerkoopDocument"
			End With
			With Mim.Report
				.FontName = "Courier New"
				.FontSize = 10
				.TextBold = True
				.TextColor = ColorTranslator.FromOle(0) 'zwart
				.nTopMargin = 1
				.nLeftMargin = 0.5
				.nRightMargin = 0.5
				.PenSize = 0.01
			End With
			'pdfY = Mim.Report.Print(1, 1, "whatever")
			XX = pdfDrukAf()

			idClient = Trim(AdoGetField(TABLE_CUSTOMERS, "#A110 #"))
			If Not IsDBNull(AdoGetField(TABLE_CUSTOMERS, "#g101 #")) Then voorkeurg101 = Trim(AdoGetField(TABLE_CUSTOMERS, "#g101 #"))
			'idDocument = dokumentSleutel

			'TODO datum vervaldag toevoegen
			idDocument = Trim(PolisNummer)

			'always a copy in io map even when no mail selected
			If Not IsDBNull(AdoGetField(TABLE_CUSTOMERS, "#V224 #")) Then
				mailAddressV224 = Trim(AdoGetField(TABLE_CUSTOMERS, "#V224 #"))
				nameAddressV224 = Trim(Trim(AdoGetField(TABLE_CUSTOMERS, "#A100 #")) & " " & Trim(AdoGetField(TABLE_CUSTOMERS, "#A101 #")))
				idPdf = "{" + nameAddressV224 + "}-{D}-{" + idClient + "}-{" + idDocument + "}-{" + DateKey(datumVerval) + "}-{" + mailAddressV224 + "}.pdf"
				KTRL = Mim.Report.WriteDoc(locPOSTVAKIN & "\" & idPdf)
				'Mim.Report.WriteDoc("C:\Users\Jos\Documents\{De Wolf Noël}-{D}-{040795}-{93036771}-{9/20/001}-{ilse.putteman@hotmail.com}.pdf")
			End If

			If Not IsDBNull(AdoGetField(TABLE_CUSTOMERS, "#v002 #")) Then
				mailAddressv002 = Trim(AdoGetField(TABLE_CUSTOMERS, "#v002 #"))
				nameAddressv002 = Trim(Trim(AdoGetField(TABLE_CUSTOMERS, "#A125 #")) & " " & Trim(AdoGetField(TABLE_CUSTOMERS, "#A127 #")))
				If nameAddressv002 = "" Then
					nameAddressv002 = nameAddressV224
				End If

				If mailAddressv002 = "" Then
				Else
					idPdf = "{" + nameAddressv002 + "}-{D}-{" + idClient + "}-{" + idDocument + "}-{" + DateKey(datumVerval) + "}-{" + mailAddressv002 + "}.pdf"
				Mim.Report.WriteDoc(locPOSTVAKIN & "\" & idPdf)
			End If
			End If

			'Mim.Report.Preview()

			If Mim.Report.IsOpen = True Then
				Try
					'KTRL = Mim.Report.WriteDoc(locPOSTVAKIN & "\" & idPdf)
					Mim.Report.CloseDoc()
				Catch ex As Exception
					MsgBox(ex.Message)
				End Try
			End If
		Next
		Cursor.Current = Cursors.Default
		Schoon()
		Exit Sub

	End Sub

End Class


'	Function TB2infoblad() As Boolean

'		Dim rsTMP As New ADODB.Recordset
'		rsTMP = New ADODB.Recordset

'		Dim tb2infoHier As String


'		On Error Resume Next
'		Err.Clear()
'		rsTMP.CursorLocation = ADODB.CursorLocationEnum.adUseClient
'		MSG = "SELECT * FROM Dokumenten WHERE v033 Like 'Q%' AND A000 = '" & sharedPolis & "' AND Val(v249) = " & Str(sharedTotaal) & " ORDER BY v033 DESC"
'		SnelHelpPrint(MSG, BL_LOGGING)
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'		rsTMP.Open(MSG, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
'		If Err.Number Then
'			MsgBox(ErrorToString())
'		Else
'			'Debug.Print MSG
'			If rsTMP.RecordCount Then
'				Do While Not rsTMP.EOF
'					'Stop
'					'TODO: info op voorkant mogelijk?
'					'      boekdatum, hoofdvervaldag, mededeling (o.a. tariefaanpassing?), verzekeringsnemer, verzekerde periode, type risicoobject, waarborgen,
'					Mim.Report.PageBreak()
'					With Mim.Report
'						.Font = VB6.FontChangeName(.Font, "Courier New")
'						.Font = VB6.FontChangeSize(.Font, 8)
'						.TextBold = True
'						.TextColor = System.Drawing.ColorTranslator.FromOle(0) 'zwart
'					End With
'					tb2infoHier = tb2Indent(rsTMP.Fields("rvxmltb2").Value)
'					If InStr(tb2infoHier, "Commissie ") Then
'						tb2infoHier = Replace(tb2infoHier, "Commissie", "Commercialisatiekost")
'					End If
'					pdfY = Mim.Report.VpePrint(1, 1, tb2infoHier & vbCrLf)
'					If rsTMP.RecordCount > 1 Then 'best verfijnen!
'						SnelHelpPrint("Stop recordcount>1, nog te verfijnen voor " & sharedPolis & " :" & rsTMP.RecordCount, False)
'						Exit Do
'					End If
'					rsTMP.MoveNext()
'				Loop 
'			Else
'				'meer dan een record te controleren eerst
'				'nu gewoon blanco blad
'				Mim.Report.PageBreak()
'				With Mim.Report
'					.Font = VB6.FontChangeName(.Font, "Courier New")
'					.Font = VB6.FontChangeSize(.Font, 8)
'					.TextBold = False
'					.TextColor = System.Drawing.ColorTranslator.FromOle(0) 'zwart
'				End With
'			End If
'		End If
'		rsTMP.Close()
'		'UPGRADE_NOTE: Object rsTMP may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
'		rsTMP = Nothing
'	End Function

'	'UPGRADE_WARNING: Event KeuzeInfo.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub KeuzeInfo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles KeuzeInfo.SelectedIndexChanged
'		Dim Index As Integer = KeuzeInfo.GetIndex(eventSender)
'		Dim A As String
'		Dim TempoFL As Integer
'		Dim T As Integer
'		Dim aa As String
'		Dim CRLFTeller As Integer

'		Select Case Index
'			Case 0
'				If VB.Left(KeuzeInfo(0).Text, 1) = "1" Then
'					Detail.Visible = True
'					Detail.CheckState = System.Windows.Forms.CheckState.Unchecked
'					Post.Visible = True
'					KeuzeInfo(2).Visible = True
'				Else
'					Detail.Visible = False
'					Detail.CheckState = System.Windows.Forms.CheckState.Unchecked
'					Post.Visible = False
'					KeuzeInfo(2).Visible = False
'				End If
'				If VB.Left(KeuzeInfo(0).Text, 1) = "5" Then
'					LabelInfo(5).Visible = True
'					LabelInfo(6).Visible = True
'					TekstInfo(4).Visible = True
'					TekstInfo(5).Visible = True
'					DetailVeld.Visible = True
'				Else
'					LabelInfo(5).Visible = False
'					LabelInfo(6).Visible = False
'					TekstInfo(4).Visible = False
'					TekstInfo(5).Visible = False
'					DetailVeld.Visible = False
'				End If

'				If KeuzeInfo(0).SelectedIndex = 0 Then
'					PolisDetail.Enabled = False
'					Afsluiten.Enabled = False
'					TekstInfo(1).Text = ""
'					TaalTekst.Value = ""
'				Else
'					PolisDetail.Enabled = True
'					Afsluiten.Enabled = True
'					TaalTekst.Value = VB.Left(KeuzeInfo(1).Text, 1) & VB.Left(KeuzeInfo(0).Text, 1)
'					'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'					If Dir(LOCATION_COMPANYDATA & "kwijt" & TaalTekst.Value & ".DEF") = "" Then
'						TekstInfo(1).Text = ""
'					Else
'						TempoFL = FreeFile
'						TekstInfo(1).Text = ""
'						FileOpen(TempoFL, LOCATION_COMPANYDATA & "kwijt" & TaalTekst.Value & ".DEF", OpenMode.Input)
'						aa = ""
'						CRLFTeller = 0
'						Do While Not EOF(TempoFL)
'							A = LineInput(TempoFL)
'							aa = aa & A & vbCrLf
'							CRLFTeller = CRLFTeller + 1
'						Loop 
'						TekstInfo(1).Text = VB.Left(aa, Len(aa) - 2)
'						CRLFCaption.Text = Dec(CRLFTeller, "##0")
'						FileClose(TempoFL)
'					End If
'				End If
'			Case 1
'				If TaalTekst.Value = "  " Then
'					Exit Sub
'				End If
'				TaalTekst.Value = VB.Left(KeuzeInfo(1).Text, 1) & VB.Left(KeuzeInfo(0).Text, 1)

'				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'				If Dir(LOCATION_COMPANYDATA & "kwijt" & TaalTekst.Value & ".DEF") = "" Then
'					TekstInfo(1).Text = ""
'				Else
'					TempoFL = FreeFile
'					TekstInfo(1).Text = ""
'					FileOpen(TempoFL, LOCATION_COMPANYDATA & "kwijt" & TaalTekst.Value & ".DEF", OpenMode.Input)
'					aa = ""
'					CRLFTeller = 0
'					Do While Not EOF(TempoFL)
'						A = LineInput(TempoFL)
'						aa = aa & A & vbCrLf
'						CRLFTeller = CRLFTeller + 1
'					Loop 
'					TekstInfo(1).Text = VB.Left(aa, Len(aa) - 2)
'					CRLFCaption.Text = Dec(CRLFTeller, "##0")
'					FileClose(TempoFL)
'				End If
'		End Select

'	End Sub
'	

'	Private Sub PolisDetail_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PolisDetail.ClickEvent
'		On Error Resume Next
'		With PolisDetail
'			.Col = 0
'			'.SelStartCol = 0
'			'.SelEndCol = 4
'			'.SelStartRow = .Row
'			'.SelEndRow = .Row
'		End With


'	End Sub


'	Private Sub PolisDetail_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PolisDetail.Enter

'		SnelHelpPrint("[+] lijn bijvoegen, [-] verwijderen, [Enter] om te wijzigen", BL_LOGGING)

'	End Sub

'	Private Sub PolisDetail_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_KeyDownEvent) Handles PolisDetail.KeyDownEvent

'		PolisDetail_ClickEvent(PolisDetail, New System.EventArgs())

'	End Sub

'	Private Sub PolisDetail_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_KeyPressEvent) Handles PolisDetail.KeyPressEvent
'		Dim Positie As Integer
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
'				Load(KwijtingEdit)
'				KwijtingEdit.Text = VB.Left(KeuzeInfo(0).Text, 4) & ":" & KwijtingEdit.Text
'				KwijtingEdit.ShowDialog()
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
'				On Error Resume Next
'				PolisDetail.RemoveItem(Positie)
'				If PolisDetail.Rows - 1 > Positie + 1 Then
'					PolisDetail.Row = Positie - 1
'				End If
'				CType(Me.Controls("PolisDetail"), Object).Focus()
'				On Error GoTo 0
'			Case Else
'		End Select

'		If PolisDetail.Rows = 2 Then
'			Afsluiten.Enabled = False
'		Else
'			Afsluiten.Enabled = True
'		End If

'	End Sub

'	Private Sub PolisDetail_KeyUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_KeyUpEvent) Handles PolisDetail.KeyUpEvent

'		'Select Case KeyCode
'		'    Case 37 To 40
'		PolisDetail_ClickEvent(PolisDetail, New System.EventArgs())
'		'End Select

'	End Sub

'	Private Sub TekstBewaren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstBewaren.Click
'		Dim TempoFL As Integer

'		TempoFL = FreeFile
'		FileOpen(TempoFL, LOCATION_COMPANYDATA & "kwijt" & VB.Left(KeuzeInfo(1).Text, 1) & VB.Left(KeuzeInfo(0).Text, 1) & ".DEF", OpenMode.Output)
'		PrintLine(TempoFL, TekstInfo(1).Text)
'		FileClose(TempoFL)

'	End Sub

'	Private Sub TekstInfo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TekstInfo.KeyPress
'		Dim KeyAscii As Integer = Asc(eventArgs.KeyChar)
'		Dim Index As Integer = TekstInfo.GetIndex(eventSender)
'		Dim Search As String
'		Dim Start As Integer
'		Dim CRLFTeller As Integer

'		Select Case Index
'			Case 1
'				Select Case KeyAscii
'					Case 13
'						CRLFCaption.Text = Dec(Val(CRLFCaption.Text) + 1, "##0")
'					Case 8
'						Search = Chr(13)
'						CRLFTeller = 0
'						Start = 1
'						Do 
'							Start = InStr(Start, TekstInfo(1).Text, Search)
'							If Start = 0 Then
'								Exit Do
'							Else
'								CRLFTeller = CRLFTeller + 1
'								Start = Start + 1
'							End If
'						Loop 
'						CRLFCaption.Text = Dec(CRLFTeller + 1, "##0")
'				End Select
'		End Select

'	End Sub

'End Class