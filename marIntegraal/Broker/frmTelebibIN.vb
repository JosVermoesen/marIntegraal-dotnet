Option Strict Off
Option Explicit On

Public Class TelebibIN
	
	Dim FlAsIn As Short
	Dim FlAsNet As Short
	Dim FlSchrijfWeg As Short
	Dim A As String
	Dim aa As String

	Dim KlantNaam1 As String
	Dim Klantnaam2 As String
	Dim KlantStraat As String
	Dim KlantPlaats As String
	Dim KlantTelefoon As String
	Dim KlantFax As String

	Dim DetailPolis1 As String
	Dim DetailPolis2 As String

	Dim TLBCode(100) As String
	Dim TLBTekst(100) As String
	Dim TLBType(100) As String
	Dim TLBLengte(100) As Short
	Dim TLBPos(100) As Short

	Dim rsTB2 As ADODB.Recordset
	Dim companiesRS As ADODB.Recordset

	Dim gboDIR As String
	Dim gboFILE As String
	Dim gboCPstr As String

	Dim aswebDIR As String
	Dim aswebFILE As String
	Dim aswebCPstr As String

	Dim strA000RB As String


	Private Sub frmTelebibIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		
		rsTB2 = New ADODB.Recordset
		rsTB2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		If rsTB2.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsTB2.Close()
		End If
		Msg = "SELECT TOP 1 * FROM TB2"
		rsTB2.Open(Msg, adntDB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)

		gboDIR = LaadTekst("TelebibIN", "gboLocatie")
		gboFILE = "PRENOT.GBO"
		If gboDIR = "" Then
			Me.cbGBO.Enabled = False
		Else
			Me.cbGBO.Enabled = True
			If ScrLeesBestandAlleTekst(gboCPstr, gboDIR & gboFILE) Then
				Me.RichTextBox2.Text = gboCPstr                    
			ElseIf Trim(gboCPstr) <> "" then
				RichTextBox2.Text = gboCPstr    
			Else
				Me.RichTextBox2.Text = ""
			End If
		End If
		lblGboFile.Text = gboDIR & gboFILE

		aswebDIR = Trim(LaadTekst("TelebibIN", "aswebLocatie"))
		aswebFILE = "AS1.EDI"
		If aswebDIR = "" Then
			Me.cbASWEB.Enabled = False
		Else
			Me.cbASWEB.Enabled = True
			If ScrLeesBestandAlleTekst(aswebCPstr, aswebDIR & aswebFILE) Then
				Me.RichTextBox3.Text = aswebCPstr                    
			ElseIf Trim(gboCPstr) <> "" then
				RichTextBox3.Text = aswebCPstr    
			Else
				Me.RichTextBox3.Text = ""
			End If
		End If
		lblAswebFile.Text = aswebDIR & aswebFILE

		GridTextPolis = ""
		
		cbAS2BerichtTypeHistoriek.Items.Add("E1: IPC Edifact Bericht (AS2)")
		cbAS2BerichtTypeHistoriek.Items.Add("P1: IPC positioneel Bericht (AS2)")
		cbAS2BerichtTypeHistoriek.Items.Add("IPM.NOTE.ASSURNET: IPM Vrij Bericht Assurnet")
		InstallMij()        		
		Activate()

	End Sub

	Private Sub InstallMij()

		cbListCompanies.items.Clear()
		cbListCompanies.Items.Add("Alle maatschappijen")

		Dim sSQL As String
		sSQL = "SELECT A110, A100, A400 FROM Leveranciers WHERE A110 Like 'CO%' ORDER BY A110"

		' Create a recordset using the provided collection
		companiesRS = New ADODB.Recordset
		companiesRS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		companiesRS.Open(sSQL, adntDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
		If companiesRS.RecordCount <= 0 Then
			'MsgBox("Geen diverse posten binnen deze selectie", vbInformation)
			Beep()
		Else
			companiesRS.MoveFirst()            
			Do While Not companiesRS.EOF
				cbListCompanies.Items.Add(Mid(companiesRS.Fields("A110").Value, 3, 4) & ": " & companiesRS.Fields("A100").Value & "/" & companiesRS.Fields("A400").Value)
				companiesRS.MoveNext()
			Loop
			cbListCompanies.SelectedIndex=0
		End If
		companiesRS.Close
			
	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Close

	End Sub

	Private Sub btnAswebFile_Click(sender As Object, e As EventArgs) Handles btnAswebFile.Click

		On Error Resume Next
		Mim.OpenFileDialog.InitialDirectory = aswebDIR
		Mim.OpenFileDialog.FileName = aswebDIR & aswebFILE
		Mim.OpenFileDialog.ShowDialog()
		If Err.Number Then
			Mim.OpenFileDialog.FileName = " "
		End If
		If Mim.OpenFileDialog.FileName = "" Then
			Exit Sub
		ElseIf Mim.OpenFileDialog.FileName <> aswebDIR Then
			aswebDIR = UCase(Mim.OpenFileDialog.FileName)
			aswebDIR = Mid(aswebDIR, 1, InStr(aswebDIR, aswebFILE)-1)
			BeWaarTekst("TelebibIN", "aswebLocatie", aswebDIR)

			lblAswebFile.Text = aswebDIR & aswebFILE
			Me.cbASWEB.Enabled = True
			'CURRAC= rekeninguittreksel
			'PRENOT= termijnborderel
			If ScrLeesBestandAlleTekst(aswebCPstr, aswebDIR & aswebFILE) Then
				Me.RichTextBox3.Text = aswebCPstr
			Else
				Me.RichTextBox3.Text = ""
			End If
		End If
				
	End Sub

	Private Sub btnGboFile_Click(sender As Object, e As EventArgs) Handles btnGboFile.Click

		On Error Resume Next
		Mim.OpenFileDialog.InitialDirectory = gboDIR
		Mim.OpenFileDialog.FileName = gboDIR & gboFILE
		Mim.OpenFileDialog.ShowDialog()
		If Err.Number Then
			Mim.OpenFileDialog.FileName = " "
		End If
		If Mim.OpenFileDialog.FileName = "" Then
			Exit Sub
		ElseIf Mim.OpenFileDialog.FileName <> gboDIR Then
			gboDIR = UCase(Mim.OpenFileDialog.FileName)
			gboDIR = Mid(gboDIR, 1, InStr(gboDIR, gboFILE) - 1)
			BeWaarTekst("TelebibIN", "gboLocatie", gboDIR)
			lblGboFile.Text = gboDIR & gboFILE
			Me.cbGBO.Enabled = True
			'CURRAC= rekeninguittreksel
			'PRENOT= termijnborderel
			If ScrLeesBestandAlleTekst(gboCPstr, gboDIR & gboFILE) Then
				Me.RichTextBox2.Text = gboCPstr
			Else
				Me.RichTextBox2.Text = ""
			End If
		End If

	End Sub

	Private Sub cbListCompanies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbListCompanies.SelectedIndexChanged

		cbAS2BerichtTypeHistoriek.SelectedIndex = 0
		
	End Sub

	Private Sub cbAS2BerichtTypeHistoriek_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAS2BerichtTypeHistoriek.SelectedIndexChanged

		If cbListCompanies.SelectedIndex = 0 Then
		Else
			cboxBerichtenHistoriek.Items.Clear 
			'load historiek in cbox
		End If        
	End Sub

	Private Sub rbBorderel_CheckedChanged(sender As Object, e As EventArgs) Handles rbBorderel.CheckedChanged

		If sender.Checked Then
			gboFILE = "PRENOT.GBO"
			lblGboFile.Text = gboDIR & gboFILE
			RichTextBox2.Text = ""
			If ScrLeesBestandAlleTekst(gboCPstr, gboDIR & gboFILE) Then
				RichTextBox2.Text = gboCPstr    
			ElseIf Trim(gboCPstr) <> "" then
				RichTextBox2.Text = gboCPstr    
			End If            
		End If

	End Sub

	Private Sub rbRekeningUittreksel_CheckedChanged(sender As Object, e As EventArgs) Handles rbRekeningUittreksel.CheckedChanged

		If sender.Checked Then
			gboFILE = "CURRAC.GBO"
			lblGboFile.Text = gboDIR & gboFILE
			RichTextBox2.Text = ""
			If ScrLeesBestandAlleTekst(gboCPstr, gboDIR & gboFILE) Then
				RichTextBox2.Text = gboCPstr                    
			ElseIf Trim(gboCPstr) <> "" then
				RichTextBox2.Text = gboCPstr    
			End If            
		End If

	End Sub

	Private Sub rbRuilkaart300_CheckedChanged(sender As Object, e As EventArgs) Handles rbRuilkaart300.CheckedChanged

		If sender.Checked Then
			gboFILE = "UNIFEP.300"
			lblGboFile.Text = gboDIR & gboFILE
			RichTextBox2.Text = ""
			If ScrLeesBestandAlleTekst(gboCPstr, gboDIR & gboFILE) Then
				RichTextBox2.Text = gboCPstr    
			ElseIf Trim(gboCPstr) <> "" then
				RichTextBox2.Text = gboCPstr                
			End If            
		End If

	End Sub
	
	Private Sub cbASWEB_Click(sender As Object, e As EventArgs) Handles cbASWEB.Click
				
		Dim pdfY As Short
		Dim tb2infoHier As String

		If Trim(Me.RichTextBox3.Text) = "" Then Exit Sub
		Dim atXGHarray() As String

		atXGHarray = Split(Me.RichTextBox3.Text, "XGT+1'")
		For CountTo = 0 To UBound(atXGHarray) - 1
			atXGHarray(CountTo) = atXGHarray(CountTo) & "XGT+1'"
		Next
		
		With Mim.Report
			.OpenDoc()
			.Author = "Jos Vermoesen"
			.GUILanguage = 3 'Nederlands
			.Title = "dnnInning4Brokers"
			.SelectFont("Courier New", 8)		
			.TextBold = True
			'.TextColor = System.Drawing.ColorTranslator.FromOle(0) 'zwart
			.nTopMargin = 1
			.nLeftMargin = 0.5
			.nRightMargin = 0.5
			.PenSize = 0.01
		End With

		For CountTo = 0 To UBound(atXGHarray) - 1
			RichTextBox1.Text = atXGHarray(CountTo)
			tb2infoHier = tb2Indent((Me.RichTextBox1.Text))
			pdfY = Mim.Report.Print(1, 1, tb2infoHier & vbCrLf)
			Mim.Report.PageBreak()
			KtrlBox = DoTheGBO()
		Next

		Mim.Report.WriteDoc(ProgramLocation & Format(Now, "YYYYMMDDHHMMSS") & "-ASWEB_EDI.pdf")
		Mim.Report.Preview()
		'!Mim.Report.CloseDoc

ASWEBeinde:
		KtrlBox = MsgBox("Hierna wordt het AS1.EDI bestand verwijderd (alle ontvangen berichten worden inmmers automatisch in het logboek opgenomen.)" & vbCrLf & vbCrLf & "Verwijderen GBO bestand, bent U zeker", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton3)
		If KtrlBox = MsgBoxResult.Yes Then
			Err.Clear()
			On Error Resume Next
			Kill(lblAswebFile.Text)
			If Err.Number Then
				MsgBox(ErrorToString())
			Else
				RichTextBox3.Text = ""
			End If
		ElseIf KtrlBox = MsgBoxResult.Cancel Then
			GoTo ASWEBeinde        
		End If

	End Sub

	Private Sub cbGBO_Click(sender As Object, e As EventArgs) Handles cbGBO.Click

		Dim pdfY As Short
		Dim tb2infoHier As String

		If Trim(Me.RichTextBox2.Text) = "" Then Exit Sub
		Dim atXGHarray() As String

		atXGHarray = Split(Me.RichTextBox2.Text, "XGT+1'")
		For CountTo = 0 To UBound(atXGHarray) - 1
			atXGHarray(CountTo) = atXGHarray(CountTo) & "XGT+1'"
		Next

		With Mim.Report
			.OpenDoc()
			.Author = "Jos Vermoesen"
			.GUILanguage = 3 'Nederlands
			.Title = "dnnInning4Brokers"
			.SelectFont("Courier New", 8)		
			.TextBold = True
			'.TextColor = System.Drawing.ColorTranslator.FromOle(0) 'zwart
			.nTopMargin = 1
			.nLeftMargin = 0.5
			.nRightMargin = 0.5
			.PenSize = 0.01
		End With


		For CountTo = 0 To UBound(atXGHarray) - 1
			RichTextBox1.Text = atXGHarray(CountTo)
			tb2infoHier = tb2Indent((Me.RichTextBox1.Text))
			pdfY = Mim.Report.Print(1, 1, tb2infoHier & vbCrLf)
			Mim.Report.PageBreak()
			KtrlBox = DoTheGBO()
		Next
		Mim.Report.WriteDoc(ProgramLocation & Format(Now, "YYYYMMDDHHMMSS") & "-GBO_EDI.pdf")
		Mim.Report.Preview()
		'!Mim.Report.CloseDoc

GBOeinde:
		KtrlBox = MsgBox("Hierna wordt het GBO bestand verwijderd (alle ontvangen berichten worden inmmers automatisch in het logboek opgenomen.)" & vbCrLf & vbCrLf & "Verwijderen GBO bestand, bent U zeker", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton3)
		If KtrlBox = MsgBoxResult.Yes Then
			Err.Clear()
			On Error Resume Next
			Kill(lblGboFile.Text)
			If Err.Number Then MsgBox(ErrorToString())
			rbRekeningUittreksel.Checked = Not rbRekeningUittreksel.Checked
		ElseIf KtrlBox = MsgBoxResult.Cancel Then
			GoTo GBOeinde
		Else
			'Stop
		End If

	End Sub

	Private Function DoTheGBO() As Boolean

		Dim MAPIString As String
		Dim MijNummer As String 

		Dim Xarray() As String
		Dim XGHarray() As String
		Dim XEHarray() As String
		Dim intCrLfOpkuis As Integer 


		MAPIString = RichTextBox1.Text

		'nazien of er geen CRLF's zijn ! AXA en GBO...
		intCrLfOpkuis = 0
		Do While InStr(MAPIString, vbCrLf)
			MAPIString = Replace(MAPIString, vbCrLf, "")
			intCrLfOpkuis = intCrLfOpkuis + 1
		Loop 
		If intCrLfOpkuis Then
			MsgBox(Str(intCrLfOpkuis) & " x crlf verwijderd", MsgBoxStyle.Information)
		End If

		Xarray = Split(MAPIString, "'")
		XGHarray = Split(Xarray(0) & "+", "+")
		XEHarray = Split(Xarray(1) & "+", "+")

		Dim XEHcode As String = XGHarray(2)
		Dim XEHcodeHier As String = ""

		XEHcode = XGHarray(2)
		MijNummer = XEHcode 'XGHarray(3)

		If InStr(MAPIString, "XEH+01") Then
			'XEH+01 = NIEUWE ZAAK OF WIJZIGING GEVOLGD EVENTUEEL DOOR XEH+03
			EdiFactTERMIJN (MAPIString)
			XEHcodeHier = XEHarray(1) '"01"
			strA000RB = XEHarray(4)
			If Trim(strA000RB) = "" Then
				Msg = Mid(MAPIString, InStr(MAPIString, "RFF+001:") + 8)
				If Trim(Msg) = "" Then
					Stop
				Else
					strA000RB = Mid(Msg, 1, InStr(Msg, ":") - 1)
				End If
				If Trim(strA000RB) = "" Then
					Stop
				End If
			End If
			ktrl = VerwijderENslaOP(MAPIString, XEHcodeHier, strA000RB, XEHcode)
		ElseIf InStr(MAPIString, "XEH+02") Then            
			MsgBox("Uitwisseling Schadedossier " & XGHarray(2), MsgBoxStyle.Information)
			XEHcodeHier = "02"
			If Trim(strA000RB) = "" Then
				Msg = Mid(MAPIString, InStr(MAPIString, "RFF+001:") + 8)
				If Trim(Msg) = "" Then
					Stop
				Else
					strA000RB = Mid(Msg, 1, InStr(Msg, "'") - 1)
				End If
				If Trim(strA000RB) = "" Then
					Stop
				End If
			End If
			ktrl = VerwijderENslaOP(MAPIString, XEHcodeHier, strA000RB, XEHcode)
		ElseIf InStr(MAPIString, "XEH+03") Then 
			'XEH+03 = KWIJTING KOMT BIJ BIJVOEGSELS ACHTERAAN DUS HIER ZIJN HET HERNIEUWINGEN
			MsgBox("Uitwisseling Termijn " & XGHarray(2), MsgBoxStyle.Information)
			XEHcodeHier = "03"
			If obVerwerking0.Checked = True Then
				EdiFactTERMIJN(MAPIString)
			End If
			ktrl = VerwijderENslaOP(MAPIString, XEHcodeHier, strA000RB, XEHcode)
		ElseIf InStr(MAPIString, "XEH+07") Then 
			'XEH+07 = REKENINGUITTREKSELS  ?
			MsgBox("Rekeninguittreksel " & XGHarray(2), MsgBoxStyle.Information)
			XEHcodeHier = "07"
			If obVerwerking0.Checked = True Then
				EdiFactREKENINGUITTREKSEL(MAPIString)
			End If			
			ktrl = VerwijderENslaOP(MAPIString, XEHcodeHier, strA000RB, XEHcode)
		Else
			MsgBox("Nog niets voorzien voor verzoek " & XEHarray(3) & " maatschappij " & XGHarray(2))
			ktrl = VerwijderENslaOP(MAPIString, XEHcodeHier, strA000RB, XEHcode)
		End If

	End Function

	Private Function VerwijderEnSlaOp(MAPISTRING As String, XEHCODEHIER As String, STRA000RB As String, XEHCODE As String ) As Boolean
		
		Dim posSTR As Integer 
		
		TLBRecord(TableOfVarious) = ""
		AdoInsertToRecord(TableOfVarious, SetSpacing("L" & "CO" & XEHCODE, 13), "v004")
		AdoInsertToRecord(TableOfVarious, XEHCODE, "A010")
		AdoInsertToRecord(TableOfVarious, "E1", "v400")
		AdoInsertToRecord(TableOfVarious, SetSpacing("30" & XEHCODE & "E1", 20), "v005")
		AdoInsertToRecord(TableOfVarious, (RichTextBox1.Text), "v132")
		'rsmar(flallerlei)("A000")= djfkddk
		'rsMAR(TableOfVarious).Update

		rsTB2.AddNew()
		rsTB2.Fields("Mij").Value = XEHCODE 
		rsTB2.Fields("memoTB2").Value = MAPISTRING 
		rsTB2.Fields("DocType").Value = XEHCODEHIER 
		rsTB2.Fields("Polis").Value = STRA000RB 
		'nu nog de datum op basis van doctype
		If XEHCODEHIER = "01" Then 'contract!
			posSTR = InStr(MAPISTRING, "DTM+008:")
			If posSTR = 0 Then
				'mogelijk nieuwe zaak dus ktrl op DTM+041:
				posSTR = InStr(MAPISTRING, "DTM+041:")
				If posSTR = 0 Then
					'verder zoeken!
					posSTR = InStr(MAPISTRING, "DTM+060:")
					If posSTR = 0 Then
						'nog verder zoeken!
						posSTR = InStr(MAPISTRING, "DTM+002:")
						If posSTR = 0 Then
							'nog verder zoeken!
							posSTR = InStr(MAPISTRING, "DTM+019:")
							If posSTR = 0 Then
								MsgBox("Stop" & vbCrLf & "datum bijvoegsel nog verder te zoeken")
							End If
						End If
					End If
				End If
			End If
			Msg = Mid(MAPISTRING, posSTR + 8)
			Msg = Mid(Msg, 1, 8)

			rsTB2.Fields("DatumAanvang").Value = CDate(Mid(Msg, 1, 2) & "/" & Mid(Msg, 3, 2) & "/" & Mid(Msg, 5, 4))
			'SnelHelpPrint Msg, False

		ElseIf XEHCODEHIER = "02" Then  'contract
			posSTR = InStr(MAPISTRING, "DTM+048:")
			If posSTR = 0 Then
				MsgBox("Stop")
			Else
				Msg = Mid(MAPISTRING, posSTR + 8)
				Msg = Mid(Msg, 1, 8)
			End If
			rsTB2.Fields("DatumAanvang").Value = CDate(Mid(Msg, 1, 2) & "/" & Mid(Msg, 3, 2) & "/" & Mid(Msg, 5, 4))
		ElseIf XEHCODEHIER = "07" Then  'rekeninguittreksel?
			rsTB2.Fields("Polis").Value = "" 'zeker geen polisnummer dan!
			posSTR = InStr(MAPISTRING, "DTM+069:")
			If posSTR = 0 Then
				MsgBox("Stop")
			Else
				Msg = Mid(MAPISTRING, posSTR + 8)
				Msg = Mid(Msg, 1, 8)
			End If
			rsTB2.Fields("DatumAanvang").Value = CDate(Mid(Msg, 1, 2) & "/" & Mid(Msg, 3, 2) & "/" & Mid(Msg, 5, 4))
		ElseIf XEHCODEHIER = "03" Then  'hernieuwingen ?
			rsTB2.Fields("Polis").Value = "" 'zeker geen polisnummer dan!
			posSTR = InStr(MAPISTRING, "DTM+005:")
			If posSTR = 0 Then
				MsgBox("Stop")
			Else
				Msg = Mid(MAPISTRING, posSTR + 8)
				Msg = Mid(Msg, 1, 6)
			End If
			rsTB2.Fields("DatumAanvang").Value = CDate("01" & "/" & Mid(Msg, 1, 2) & "/" & Mid(Msg, 3, 4))
		Else
			MsgBox("Stop")
		End If
		If obVerwerking0.Checked = True Then
			rsTB2.Fields("status").Value = "1"
		Else
			rsTB2.Fields("status").Value = "0"
		End If
		rsTB2.Update()
		JetInsert(TableOfVarious, 1)
		'MsgBox "Stop"
		If Ktrl Then
			MsgBox(ErrorToString())
		Else
			RichTextBox1.Text = ""
		End If
		VerwijderEnSlaOp = True 

	End Function
	
	Private Function EdiFactTERMIJN(MAPIString)

	End Function

	Private Function EdiFactREKENINGUITTREKSEL(MAPIString)

	End Function

End Class

