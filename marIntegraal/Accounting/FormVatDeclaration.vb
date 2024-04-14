Public Class FormVatDeclaration
    Private Sub frmBtwAangifte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class frmBTWAangifte
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Private mNode As System.Windows.Forms.TreeNode
'	Dim btwVakken As String

'	Dim rFlag As String
'	Private Sub Afdrukken_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Afdrukken.Click

'		On Error Resume Next
'		PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.CompatibleModeClientAreaOnly)
'		If Err.Number Then MsgBox(ErrorToString())

'		Annuleren.Focus()

'	End Sub

'	Private Sub Annuleren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Annuleren.Click

'		Me.Close()

'	End Sub

'	'UPGRADE_WARNING: Event cbAanvraagBetaalformulieren.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub cbAanvraagBetaalformulieren_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbAanvraagBetaalformulieren.CheckStateChanged

'		Dim tmpXMLHier As String
'		Dim tmpVakOud As String
'		Dim tmpVakNieuw As String
'		Dim ATOld As String
'		Dim ATNew As String
'		Dim ABOld As String
'		Dim ABNew As String

'		tmpXMLHier = RichTextBox1.Text
'		If Me.cbAanvraagTerugbetaling.CheckState = System.Windows.Forms.CheckState.Checked Then
'			ATOld = "YES"
'		Else
'			ATOld = "NO"
'		End If
'		ATNew = ATOld

'		If Me.cbAanvraagBetaalformulieren.CheckState = System.Windows.Forms.CheckState.Checked Then
'			'nu wordt het YES, logisch zou vorige status NO zijn
'			ABOld = "NO"
'			ABNew = "YES"
'		Else
'			'en omgekeerd..
'			ABOld = "YES"
'			ABNew = "NO"
'		End If

'		tmpVakOud = "<ASK PAYMENT=" & Chr(34) & ABOld & Chr(34) & " RESTITUTION=" & Chr(34) & ATOld & Chr(34) & "/>"
'		tmpVakNieuw = "<ASK PAYMENT=" & Chr(34) & ABNew & Chr(34) & " RESTITUTION=" & Chr(34) & ATNew & Chr(34) & "/>"
'		tmpXMLHier = Replace(tmpXMLHier, tmpVakOud, tmpVakNieuw)

'		RichTextBox1.Text = tmpXMLHier

'	End Sub

'	'UPGRADE_WARNING: Event cbAanvraagTerugbetaling.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub cbAanvraagTerugbetaling_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbAanvraagTerugbetaling.CheckStateChanged

'		Dim tmpXMLHier As String
'		Dim tmpVakOud As String
'		Dim tmpVakNieuw As String
'		Dim ATOld As String
'		Dim ATNew As String
'		Dim ABOld As String
'		Dim ABNew As String

'		tmpXMLHier = RichTextBox1.Text
'		If Me.cbAanvraagBetaalformulieren.CheckState = System.Windows.Forms.CheckState.Checked Then
'			ABOld = "YES"
'		Else
'			ABOld = "NO"
'		End If
'		ABNew = ABOld

'		If Me.cbAanvraagTerugbetaling.CheckState = System.Windows.Forms.CheckState.Checked Then
'			'nu wordt het YES, logisch zou vorige status NO zijn
'			ATOld = "NO"
'			ATNew = "YES"
'		Else
'			'en omgekeerd..
'			ATOld = "YES"
'			ATNew = "NO"
'		End If

'		tmpVakOud = "<ASK PAYMENT=" & Chr(34) & ABOld & Chr(34) & " RESTITUTION=" & Chr(34) & ATOld & Chr(34) & "/>"
'		tmpVakNieuw = "<ASK PAYMENT=" & Chr(34) & ABNew & Chr(34) & " RESTITUTION=" & Chr(34) & ATNew & Chr(34) & "/>"
'		tmpXMLHier = Replace(tmpXMLHier, tmpVakOud, tmpVakNieuw)

'		RichTextBox1.Text = tmpXMLHier

'	End Sub


'	'UPGRADE_WARNING: Event Check1.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub Check1_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check1.CheckStateChanged

'		Me.RichTextBox1.ReadOnly = Me.Check1.CheckState

'	End Sub

'	Private Sub CmdEmailNBB_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdEmailNBB.Click

'		Dim vatOut As String
'		Dim vatTmp As String
'		Dim BTWNummer As String
'		Dim btwDatum As String
'		Dim btwDatumFull As String
'		Dim btwPeriode As String
'		Dim btwWatIsDit As String
'		Dim btwContactPersoon As String
'		Dim btwContactTelefoon As String
'		Dim btwContactMailAdres As String

'		Select Case String99(Reading, 301)
'			Case "1", "2"
'			Case Else
'				MsgBox("Eerst Setup BTW instellen a.u.b.", MsgBoxStyle.Information)
'				Exit Sub
'		End Select

'		If btwVakken = "" Then
'			MsgBox("Eerst aankoop- en verkoopboeken afsluiten a.u.b. of selecteer eerst een bestaande aangifte", MsgBoxStyle.Information)
'			Exit Sub
'		End If

'		BTWNummer = BtwKontrole(String99(Reading, 51), True)
'		btwDatum = VB6.Format(TekstInfo(29).Text, "yymmdd")
'		btwDatumFull = VB6.Format(TekstInfo(29).Text, "yyyymmdd")
'		btwWatIsDit = "777"
'		btwPeriode = ""
'		btwContactPersoon = String99(Reading, 52)
'		btwContactTelefoon = String99(Reading, 49)
'		btwContactMailAdres = String99(Reading, 50) '= mail!

'		Dim btwOnderwerp As String

'		btwOnderwerp = "$marNT$BTWAGF$" & BTWNummer & "$" & btwPeriode
'		vatTmp = "UNB*UNOA:3*" & BTWNummer & "*VAT-ADMIN*" & btwDatum & ":1246*" & BTWNummer & "00001*" & btwWatIsDit & "*VATDEC-EUR***1.0" & "'UNH*1*RDRMES:D:96A:UN:VAT001" & "'BGM*937*124980407*2" & "'DTM*137:" & btwDatumFull & ":102" & "'DTM*320:" & btwPeriode & ":608" & "'NAD*DT*" & BTWNummer & ":52:129" & "'CTA*IC*:" & btwContactPersoon & "'COM*" & btwContactTelefoon & ":TE" & "'COM*" & btwContactMailAdres & ":ML" & "'IDE*1*VATDEC" & "'NAD*DT*" & BTWNummer & ":52:129" & "'FTX*AAI***0000:EUR" & btwVakken & "'UNT*32*1" & "'UNZ*1*" & BTWNummer & "00001'" & "'RVS:" & String99(Reading, 301) & "*" & String99(Reading, 302) & "*" & String99(Reading, 303) & "'"

'		MsgBox("Dit venster wordt hierna gesloten en de gestructureerde aangifte verzonden via de ingebouwde Internet Explorer.  Wacht in de 'Explorer' op bevestiging van verzending a.u.b !", MsgBoxStyle.Exclamation)

'		Dim frmB As frmBrowser

'		Err.Clear()
'		On Error Resume Next

'		frmB = New frmBrowser

'		If Err.Number Then MsgBox(ErrorToString()) : Exit Sub
'		'If usrMailAdres = "demo@rv.be" Then
'		'    MsgBox "Programma gebruikt default 'demo@rv.be' met paswoord '9999'.  Gelieve zo spoedig mogelijk uw eigen aanmelding en paswoord op te slaan in uw programma a.u.b." & vbCrLf & vbCrLf & "Hierna wordt vervolgd met aanmelding via de beperkte functionaliteit van demo@rv.be als demonstratie...", vbExclamation
'		'End If
'		frmB.StartingAddress = "http://www.rv.be/Services/mar/BtwIO/BtwIO.aspx?rvA100=" & btwContactMailAdres & "&rvBTW=" & vatTmp
'		frmB.WindowState = System.Windows.Forms.FormWindowState.Maximized
'		If Err.Number Then MsgBox(ErrorToString()) : Exit Sub
'		Me.Close()

'	End Sub


'	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click

'		Mim.TekenSave.InitialDirectory = ""
'		Mim.TekenSave.FileName = "btw.xml"
'		Mim.TekenSave.ShowDialog()
'		If Mim.TekenSave.FileName = "" Then Exit Sub
'		Dim tmpXMLHier As String
'		tmpXMLHier = Me.RichTextBox1.Text
'		Ktrl = ScrMaakTekstBestand(tmpXMLHier, (Mim.TekenSave.FileName))

'	End Sub

'	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click


'XMLvraag: 
'		MSG = "Btwaangifte doormailen voor afhandeling" & vbCrLf & vbCrLf & "Kies 'ja' voor doormailen (aanbevolen, ontvangstbewijs volgt), 'nee' indien U zelf het XML bestand afhandelt"
'		Ktrl = MsgBox(MSG, MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton3 + MsgBoxStyle.Question)
'		Dim tmpXMLHier As String
'		Select Case Ktrl
'			Case 2
'				MSG = "Taak verlaten zonder enige verwerking.  Bent U zeker"
'				Ktrl = MsgBox(MSG, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question)
'				If Ktrl = 7 Then
'					GoTo XMLvraag
'				Else
'					Exit Sub
'				End If

'			Case 6

'				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'				System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'				If Me.MPISessie.SessionID <> 0 Then
'					MsgBox("Te controleren: MAPI sessie zou nog bezig zijn met iets anders..")
'				Else
'					On Error Resume Next
'					Me.MPISessie.SignOn()
'					If Err.Number Then
'						SnelHelpPrint(Err.Description, blLogging)
'					Else
'						On Error GoTo 0
'						Me.MPIBericht.SessionID = Me.MPISessie.SessionID
'						SnelHelpPrint("E-mail sessie met succes opgestart. IDkode :" & VB6.Format(Me.MPISessie.SessionID), blLogging)
'					End If
'				End If
'				On Error GoTo MPIErrorXML
'				'Compose new message
'				Me.MPIBericht.Compose()

'				'Address message
'				Me.MPIBericht.RecipDisplayName = "INTERVATBEHEER"
'				Me.MPIBericht.RecipAddress = "SMTP:" & Me.tbmailbtw.Text

'				'Resolve recipient name
'				Me.MPIBericht.AddressResolveUI = True '=dialogbox, false = error genereren

'				'Create the message
'				Me.MPIBericht.MsgSubject = "Verzoek tot BTW controle en aangifte"

'				If Me.tbmailbtw.Text = "info@rv.be" Then
'					Me.MPIBericht.MsgNoteText = "Formaat:XML bestand" & vbCrLf & "In bijlage onze aangifte aangemaakt met marIntegraal versie " & marVersion & " voor controle en verzending.  Graag ontvangstbewijs binnen de 24 uur via mail of onze DNN postbus" & vbCrLf & vbCrLf & Now
'				Else
'					Me.MPIBericht.MsgNoteText = "Formaat:XML bestand" & vbCrLf & "In bijlage XML btw aangifte gegenereerd door ons boekhoudpakket.  Graag de aangifte door uw diensten na de gebruikelijke controles a.u.b." & vbCrLf & "Bezorgt U ons tevens nog ontvangstbevestiging ?" & vbCrLf & vbCrLf & "Dank bij voorbaat!" & vbCrLf & vbCrLf & Now
'				End If

'				tmpXMLHier = Me.RichTextBox1.Text
'				Ktrl = ScrMaakTekstBestand(tmpXMLHier, "btwaangifte.xml")
'				'

'				Me.MPIBericht.AttachmentPathName = "btwaangifte.xml"

'				'Send the message
'				On Error Resume Next
'				Me.MPIBericht.Send(True)
'				'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'				'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'				System.Windows.Forms.Cursor.Current = vbNormal
'				If Err.Number = 32001 Then
'					MsgBox("U koos om de mail af te breken.", MsgBoxStyle.Information)
'					GoTo XMLvraag
'				Else
'					MsgBox("Zorg ervoor dat uw mailtoepassing effectief kan verzenden nu of straks.  U ontvangt later nog ontvangstbevestiging vanwege onze diensten", MsgBoxStyle.Information)
'					Me.Close()
'					Exit Sub
'				End If

'			Case 7
'				'niks
'				'Zelf afhandelen (enkel nog afdruk afleveringnota's hierna
'				MSG = "Klik het INTERVAT tabblad en bewaar het XML bestand (bvb. op uw bureaublad).  Start de INTERVAT webapplicatie en bezorg het XML bestand of breng uw cijfers manueel in in dezelfde toepassing" & vbCrLf & vbCrLf & "Voor hulp rond INTERVAT gelieve de website FOD te raadplegen."
'				MsgBox(MSG, MsgBoxStyle.Information, "XML Btwaangifte zelf afhandelen via INTERVAT")
'		End Select
'		Exit Sub

'MPIErrorXML: 
'		MsgBox("error in mail")

'	End Sub

'	Private Sub frmBTWAangifte_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
'		Dim lblInfoTekst As Short

'		If Not Toegankelijk(Me) Then
'			Me.Close()
'			Exit Sub
'		End If

'		lblInfoTekst = CShort("Vak 54 t.e.m. Vak 72 geeft de som weer resulterende uit afdruk van aankoop- en verkoopboeken (werkwijze 1985 - 2003)." & "rVak 54 t.e.m. rVak 72 geeft som van de cijfers teruggevonden op de boekhoudrekeningen voor Vak54 tot Vak72 !" & vbCrLf & vbCrLf & "AANDACHT:" & vbCrLf & "De cijfers in rVak54 tot rVak72 worden aangewend voor GESTRUCTUREERDE AANGIFTE !!")

'		mNode = tvwBtwAangiftes.Nodes.Add("") ' Create the first node.
'		mNode.Text = "Btw aangiftes"

'		Dim dokumentTot As Integer

'		JetGetOrGreater(TableOfVarious, 1, SetSpacing("17", 20))
'		If Ktrl Then
'		Else
'			Do 
'				RecordToField(TableOfVarious)
'				dokumentTot = 0
'				For CountTo = 92 To 98 Step 2
'					dokumentTot = dokumentTot + Val(AdoGetField(TableOfVarious, "#v" & VB6.Format(CountTo, "000") & " #"))
'				Next 
'				If dokumentTot Then
'					'UPGRADE_WARNING: Cannot determine Node location Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="196D987F-2118-46D0-80D2-92FB2909C206"'
'					mNode = tvwBtwAangiftes.Nodes.Insert(1, "")
'					mNode.Text = AdoGetField(TableOfVarious, "#v090 #") & " " & AdoGetField(TableOfVarious, "#v091 #")
'				End If
'				bNext(TableOfVarious)
'				If Ktrl Or VB.Left(KeyBuf(TableOfVarious), 2) <> "17" Then
'					Exit Do
'				End If
'			Loop 
'		End If
'		SnelHelpPrint(Now & ":In verdere ontwikkeling voor BEF/EUR/E-mail", blLogging)
'		VulDeVelden((BJPERDAT.Boekjaar.Text), VB6.Format(BJPERDAT.PeriodeBoekjaar.SelectedIndex + 1, "00"))
'		'BJPERDAT.Boekjaar.Text + Format(BJPERDAT.PeriodeBoekjaar.ListIndex + 1, "00")
'	End Sub

'	Private Sub frmBTWAangifte_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

'		JetTableClose(TableOfVarious)

'	End Sub

'	Private Sub Initialiseren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Initialiseren.Click
'		Dim T As Short
'		Dim PeriodeMax As Short
'		Dim pTrec(7) As Short
'		Dim Nrr As Integer
'		Dim PeriodeSleutel As New VB6.FixedLengthString(20)
'		Dim DummySleutel As New VB6.FixedLengthString(5)
'		Dim number As Integer

'		MSG = "BTW Aangifte periode initializeren." & vbCrLf & "Bent U zeker ?"
'		Ktrl = MsgBox(MSG, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Alle boeken opnieuw uitdrukken !?!")
'		If Ktrl = MsgBoxResult.Yes Then
'		Else
'			Exit Sub
'		End If

'		Ktrl = 0
'		SnelHelpPrint("Kontrole hogere periodes...", blLogging)
'		PeriodeMax = BJPERDAT.PeriodeBoekjaar.Items.Count + 1
'		Do While PeriodeMax > BJPERDAT.PeriodeBoekjaar.SelectedIndex + 1
'			PeriodeSleutel.Value = "17" & BJPERDAT.Boekjaar.Text & VB6.Format(PeriodeMax, "00")
'			JetGet(TableOfVarious, 1, PeriodeSleutel.Value)
'			If Ktrl Then
'				TLBRecord(TableOfVarious) = ""
'				AdoInsertToRecord(TableOfVarious, (BJPERDAT.Boekjaar.Text), "v090")
'				AdoInsertToRecord(TableOfVarious, VB6.Format(PeriodeMax, "00"), "v091")
'				AdoInsertToRecord(TableOfVarious, "17" & AdoGetField(TableOfVarious, "#v090 #") & AdoGetField(TableOfVarious, "#v091 #"), "v005")
'				JetInsert(TableOfVarious, 1)
'			Else
'				RecordToField(TableOfVarious)
'				number = 0

'				For T = 92 To 99
'					number = number + Val(AdoGetField(TableOfVarious, "#v" & VB6.Format(T, "000") & " #"))
'				Next 
'				If number Then
'					number = PeriodeMax
'					PeriodeMax = 0
'					Exit Do
'				End If
'			End If
'			PeriodeMax = PeriodeMax - 1
'		Loop 

'jump: 
'		If number Then
'			MsgBox("Periode " & VB6.Format(number, "00") & " reeds afgesloten...")
'			Initialiseren.Enabled = False
'			CmdEmailNBB.Enabled = False
'			Exit Sub
'		Else
'			PeriodeSleutel.Value = "17" & BJPERDAT.Boekjaar.Text & VB6.Format(BJPERDAT.PeriodeBoekjaar.SelectedIndex + 1, "00")
'			JetGet(TableOfVarious, 1, PeriodeSleutel.Value)
'			If Ktrl Then
'				TLBRecord(TableOfVarious) = ""
'				AdoInsertToRecord(TableOfVarious, (BJPERDAT.Boekjaar.Text), "v090")
'				AdoInsertToRecord(TableOfVarious, VB6.Format(BJPERDAT.PeriodeBoekjaar.SelectedIndex + 1, "00"), "v091")
'				AdoInsertToRecord(TableOfVarious, "17" & AdoGetField(TableOfVarious, "#v090 #") & AdoGetField(TableOfVarious, "#v091 #"), "v005")
'				JetInsert(TableOfVarious, 1)
'				GoTo jump
'			Else
'				RecordToField(TableOfVarious)
'			End If
'		End If

'		pTrec(1) = 2
'		pTrec(3) = 4
'		pTrec(5) = 12
'		pTrec(7) = 14
'		For T = 1 To 8 Step 2
'			If Val(AdoGetField(TableOfVarious, "#v" & VB6.Format(T + 91, "000") & " #")) = 0 Then
'			Else
'				Nrr = Val(AdoGetField(TableOfVarious, "#v" & VB6.Format(T + 91, "000") & " #")) - 1
'				SS99(VB6.Format(Nrr, "00000"), pTrec(T))
'			End If
'		Next 
'		TLBRecord(TableOfVarious) = ""
'		AdoInsertToRecord(TableOfVarious, (BJPERDAT.Boekjaar.Text), "v090")
'		AdoInsertToRecord(TableOfVarious, VB6.Format(BJPERDAT.PeriodeBoekjaar.SelectedIndex + 1, "00"), "v091")
'		AdoInsertToRecord(TableOfVarious, "17" & AdoGetField(TableOfVarious, "#v090 #") & AdoGetField(TableOfVarious, "#v091 #"), "v005")
'		bUpdate(TableOfVarious, 1)
'		Initialiseren.Enabled = False
'		CmdEmailNBB.Enabled = False
'		VulDeVelden((BJPERDAT.Boekjaar.Text), VB6.Format(BJPERDAT.PeriodeBoekjaar.SelectedIndex + 1, "00"))
'		Annuleren.Focus()

'	End Sub

'	Private Sub VulDeVelden(ByRef strJaar As String, ByRef strPeriode As String)
'		Dim T As Short
'		Dim lblEURVak As Short
'		Dim lblBEFVak As Short

'		btwVakken = ""
'		JetGet(TableOfVarious, 1, SetSpacing("17" & strJaar & strPeriode, 20))
'		If Ktrl Then
'			Beep()
'			'UPGRADE_WARNING: Couldn't resolve default property of object Me.SSTab1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Me.SSTab1.TabEnabled(2) = False
'			Exit Sub
'		Else
'			RecordToField(TableOfVarious)
'		End If

'		TekstInfo(28).Text = VB6.Format(BJPERDAT.PeriodeBoekjaar.SelectedIndex + 1, "00")
'		TekstInfo(29).Text = VB.Right(BJPERDAT.PeriodeBoekjaar.Text, 10)

'		Label2(0).Text = VB6.Format(Val(AdoGetField(TableOfVarious, "#v092 #")), "00000") & " - " & VB6.Format(Val(AdoGetField(TableOfVarious, "#v093 #")), "00000")
'		Label2(2).Text = VB6.Format(Val(AdoGetField(TableOfVarious, "#v096 #")), "00000") & " - " & VB6.Format(Val(AdoGetField(TableOfVarious, "#v097 #")), "00000")
'		Label2(1).Text = VB6.Format(Val(AdoGetField(TableOfVarious, "#v094 #")), "00000") & " - " & VB6.Format(Val(AdoGetField(TableOfVarious, "#v095 #")), "00000")
'		Label2(3).Text = VB6.Format(Val(AdoGetField(TableOfVarious, "#v098 #")), "00000") & " - " & VB6.Format(Val(AdoGetField(TableOfVarious, "#v099 #")), "00000")

'		If AdoGetField(TableOfVarious, "i001") = "" Then
'			MsgBox("Aan- en verkoopboeken voor Intervat nog af te drukken.  Intervat tabblad blijft uitgeschakeld.  Intervat enkel mogelijk met boeken uitgedrukt via versie 6.6.900 of hoger.  TIP: initialiseer fiche en druk de boeken opnieuw uit met versie 900 of hoger", MsgBoxStyle.Information)
'			'UPGRADE_WARNING: Couldn't resolve default property of object Me.SSTab1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Me.SSTab1.TabVisible(2) = False
'			Me.Command2.Enabled = False
'		Else
'			'UPGRADE_WARNING: Couldn't resolve default property of object Me.SSTab1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Me.SSTab1.TabVisible(2) = True
'			Me.Command2.Enabled = True
'		End If

'		Dim tmpXMLHier As String
'		Dim tmpVak As String
'		Dim tmpVakHier As String

'		Me.RichTextBox1.LoadFile(My.Application.Info.DirectoryPath & "\XMLbtwAangifte.rtf")
'		tmpXMLHier = RichTextBox1.Text

'		tmpVak = "<VATNUMBER>9999999999</VATNUMBER>"
'		tmpVakHier = String99(Reading, 51)
'		If Len(tmpVakHier) <> 11 Then
'			MsgBox("btw notatie in setup behouden zoals in de jaren voorheen a.u.b. xxx.xxx.xxx  Verbeter setup vooraleer verder te gaan", MsgBoxStyle.Exclamation)
'			'UPGRADE_WARNING: Couldn't resolve default property of object Me.SSTab1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Me.SSTab1.TabVisible(2) = False
'			Me.Command2.Enabled = False
'			Exit Sub
'		Else
'			tmpVakHier = "0" & Mid(tmpVakHier, 1, 3) & Mid(tmpVakHier, 5, 3) & Mid(tmpVakHier, 9, 3)
'			tmpXMLHier = Replace(tmpXMLHier, tmpVak, "<VATNUMBER>" & tmpVakHier & "</VATNUMBER>")
'			'UPGRADE_WARNING: Couldn't resolve default property of object Me.SSTab1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Me.SSTab1.TabVisible(2) = True
'			Me.Command2.Enabled = True
'		End If

'		tmpVak = "<NAME>Contactpersoon</NAME>"
'		tmpVakHier = String99(Reading, 52)
'		If InStr(tmpVakHier, "&") Then 'verbeteren voor XML bestand!!!
'			tmpVakHier = Replace(tmpVakHier, "&", "&amp;")
'		End If
'		tmpXMLHier = Replace(tmpXMLHier, tmpVak, "<NAME>" & tmpVakHier & "</NAME>")

'		tmpVak = "<ADDRESS>StraatContact</ADDRESS>"
'		tmpVakHier = String99(Reading, 47)
'		If InStr(tmpVakHier, "&") Then 'verbeteren voor XML bestand!!!
'			tmpVakHier = Replace(tmpVakHier, "&", "&amp;")
'		End If
'		tmpXMLHier = Replace(tmpXMLHier, tmpVak, "<ADDRESS>" & tmpVakHier & "</ADDRESS>")

'		tmpVak = "<POSTCODE>0000</POSTCODE>"
'		tmpVakHier = VB.Left(String99(Reading, 48), 4)
'		tmpXMLHier = Replace(tmpXMLHier, tmpVak, "<POSTCODE>" & tmpVakHier & "</POSTCODE>")

'		tmpVak = "<CITY>Plaatscontact</CITY>"
'		tmpVakHier = Trim(Mid(String99(Reading, 48), 5))
'		tmpXMLHier = Replace(tmpXMLHier, tmpVak, "<CITY>" & tmpVakHier & "</CITY>")

'		tmpVak = "<SENDINGREFERENCE>99999999900000</SENDINGREFERENCE>"
'		tmpVakHier = String99(Reading, 51)
'		If Len(tmpVakHier) <> 11 Then
'			MsgBox("btw notatie in setup behouden zoals in de jaren voorheen a.u.b. xxx.xxx.xxx  Verbeter setup vooraleer verder te gaan", MsgBoxStyle.Exclamation)
'			'UPGRADE_WARNING: Couldn't resolve default property of object Me.SSTab1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Me.SSTab1.TabVisible(2) = False
'			Me.Command2.Enabled = False
'			Exit Sub
'		Else
'			tmpVakHier = Mid(tmpVakHier, 1, 3) & Mid(tmpVakHier, 5, 3) & Mid(tmpVakHier, 9, 3) & "00000"
'			tmpXMLHier = Replace(tmpXMLHier, tmpVak, "<SENDINGREFERENCE>" & tmpVakHier & "</SENDINGREFERENCE>")
'			'UPGRADE_WARNING: Couldn't resolve default property of object Me.SSTab1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Me.SSTab1.TabVisible(2) = True
'			Me.Command2.Enabled = True
'		End If

'		tmpVak = "<VATNUMBER>0000000000</VATNUMBER>"
'		tmpVakHier = String99(Reading, 51)
'		If Len(tmpVakHier) <> 11 Then
'			MsgBox("btw notatie in setup behouden zoals in de jaren voorheen a.u.b. xxx.xxx.xxx  Verbeter setup vooraleer verder te gaan", MsgBoxStyle.Exclamation)
'			'UPGRADE_WARNING: Couldn't resolve default property of object Me.SSTab1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Me.SSTab1.TabVisible(2) = False
'			Me.Command2.Enabled = False
'			Exit Sub
'		Else
'			tmpVakHier = "0" & Mid(tmpVakHier, 1, 3) & Mid(tmpVakHier, 5, 3) & Mid(tmpVakHier, 9, 3)
'			tmpXMLHier = Replace(tmpXMLHier, tmpVak, "<VATNUMBER>" & tmpVakHier & "</VATNUMBER>")
'			'UPGRADE_WARNING: Couldn't resolve default property of object Me.SSTab1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Me.SSTab1.TabVisible(2) = True
'			Me.Command2.Enabled = True
'		End If

'		tmpVak = "<NAME>NaamBedrijf</NAME>"
'		tmpVakHier = String99(Reading, 46)
'		If InStr(tmpVakHier, "&") Then 'verbeteren voor XML bestand!!!
'			tmpVakHier = Replace(tmpVakHier, "&", "&amp;")
'		End If
'		tmpXMLHier = Replace(tmpXMLHier, tmpVak, "<NAME>" & tmpVakHier & "</NAME>")

'		tmpVak = "<ADDRESS>StraatBedrijf</ADDRESS>"
'		tmpVakHier = String99(Reading, 47)
'		If InStr(tmpVakHier, "&") Then 'verbeteren voor XML bestand!!!
'			tmpVakHier = Replace(tmpVakHier, "&", "&amp;")
'		End If
'		tmpXMLHier = Replace(tmpXMLHier, tmpVak, "<ADDRESS>" & tmpVakHier & "</ADDRESS>")

'		tmpVak = "<POSTCODE>9999</POSTCODE>"
'		tmpVakHier = VB.Left(String99(Reading, 48), 4)
'		tmpXMLHier = Replace(tmpXMLHier, tmpVak, "<POSTCODE>" & tmpVakHier & "</POSTCODE>")

'		tmpVak = "<CITY>PlaatsBedrijf</CITY>"
'		tmpVakHier = Trim(Mid(String99(Reading, 48), 5))
'		tmpXMLHier = Replace(tmpXMLHier, tmpVak, "<CITY>" & tmpVakHier & "</CITY>")

'		Select Case String99(Reading, 301)
'			Case "2"
'				tmpXMLHier = Replace(tmpXMLHier, "<QUARTERORMONTH>0</QUARTERORMONTH>", "<QUARTER>" & Trim(Str(Int(Val(AdoGetField(TableOfVarious, "i001")) / 3))) & "</QUARTER>")

'			Case "1"
'				tmpXMLHier = Replace(tmpXMLHier, "<QUARTERORMONTH>0</QUARTERORMONTH>", "<MONTH>" & Trim(Str(Val(AdoGetField(TableOfVarious, "i001")))) & "</MONTH>")
'			Case Else
'				MsgBox("Setup BTW instellen a.u.b.", MsgBoxStyle.Critical)
'				'UPGRADE_WARNING: Couldn't resolve default property of object Me.SSTab1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'				Me.SSTab1.TabVisible(2) = False
'				Me.Command2.Enabled = False
'		End Select
'		tmpXMLHier = Replace(tmpXMLHier, "<YEAR>1985</YEAR>", "<YEAR>" & Trim(Str(Val(AdoGetField(TableOfVarious, "i002")))) & "</YEAR>")


'		On Error Resume Next

'		'UPGRADE_WARNING: Couldn't resolve default property of object lblBEFVak(61).Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		lblBEFVak(61).Caption = VB6.Format(0, "#,##0")
'		'UPGRADE_WARNING: Couldn't resolve default property of object lblBEFVak(62).Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		lblBEFVak(62).Caption = VB6.Format(0, "#,##0")
'		'UPGRADE_WARNING: Couldn't resolve default property of object lblEURVak(61).Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		lblEURVak(61).Caption = VB6.Format(0, "#,##0.00")
'		lblEvak(61).Text = VB6.Format(0, "#,##0.00")
'		'UPGRADE_WARNING: Couldn't resolve default property of object lblEURVak(62).Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		lblEURVak(62).Caption = VB6.Format(0, "#,##0.00")
'		lblEvak(62).Text = VB6.Format(0, "#,##0.00")

'		If AdoGetField(TableOfVarious, "#vEUR #") = "EUR" Then
'			'UPGRADE_WARNING: Couldn't resolve default property of object lblBEFVak.UBound. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			For T = 0 To lblBEFVak.UBound
'				'UPGRADE_WARNING: Couldn't resolve default property of object lblBEFVak(T).Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'				If lblBEFVak(T).Tag <> "" Then
'					'UPGRADE_WARNING: Couldn't resolve default property of object lblBEFVak(T).Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					Debug.Print(lblBEFVak(T).Tag)
'					'UPGRADE_WARNING: Couldn't resolve default property of object lblBEFVak(T).Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					'UPGRADE_WARNING: Couldn't resolve default property of object lblBEFVak().Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					lblBEFVak(T).Caption = VB6.Format(Val(AdoGetField(TableOfVarious, CStr(CDbl("#") + lblBEFVak(T).Tag + CDbl(" #")))) * Euro, "#,##0")
'					'UPGRADE_WARNING: Couldn't resolve default property of object lblEURVak(T).Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					'UPGRADE_WARNING: Couldn't resolve default property of object lblBEFVak().Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					lblEURVak(T).Caption = VB6.Format(Val(AdoGetField(TableOfVarious, CStr(CDbl("#") + lblBEFVak(T).Tag + CDbl(" #")))), "#,##0.00")
'					'UPGRADE_WARNING: Couldn't resolve default property of object lblEURVak(T).Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					lblEvak(T).Text = lblEURVak(T).Caption
'					If CDec(lblEvak(T).Text) = 0 Then
'						'Debug.Print lblEvak(T).Caption, CCur(lblEvak(T).Caption)
'					Else
'						'UPGRADE_WARNING: Couldn't resolve default property of object lblBEFVak().Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'						btwVakken = btwVakken & "'SCD*3*" & VB6.Format(T, "00") & "'ARR**" & Trim(Str(Val(AdoGetField(TableOfVarious, CStr(CDbl("#") + lblBEFVak(T).Tag + CDbl(" #")))) * 100))
'						tmpVak = "<D" & Trim(Str(T)) & ">0</D" & Trim(Str(T)) & ">"
'						'UPGRADE_WARNING: Couldn't resolve default property of object lblBEFVak().Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'						tmpVakHier = "<D" & Trim(Str(T)) & ">" & Trim(Str(Val(AdoGetField(TableOfVarious, CStr(CDbl("#") + lblBEFVak(T).Tag + CDbl(" #")))) * 100)) & "</D" & Trim(Str(T)) & ">"
'						tmpXMLHier = Replace(tmpXMLHier, tmpVak, tmpVakHier)
'					End If
'				End If
'			Next 

'		Else
'			'UPGRADE_WARNING: Couldn't resolve default property of object lblBEFVak.UBound. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			For T = 0 To lblBEFVak.UBound
'				'UPGRADE_WARNING: Couldn't resolve default property of object lblBEFVak(T).Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'				If lblBEFVak(T).Tag <> "" Then
'					'UPGRADE_WARNING: Couldn't resolve default property of object lblBEFVak(T).Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					'UPGRADE_WARNING: Couldn't resolve default property of object lblBEFVak().Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					lblBEFVak(T).Caption = VB6.Format(Val(AdoGetField(TableOfVarious, CStr(CDbl("#") + lblBEFVak(T).Tag + CDbl(" #")))), "#,##0")
'					'UPGRADE_WARNING: Couldn't resolve default property of object lblEURVak(T).Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					'UPGRADE_WARNING: Couldn't resolve default property of object lblBEFVak().Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					lblEURVak(T).Caption = VB6.Format(Val(AdoGetField(TableOfVarious, CStr(CDbl("#") + lblBEFVak(T).Tag + CDbl(" #")))) / Euro, "#,##0.00")
'					'UPGRADE_WARNING: Couldn't resolve default property of object lblEURVak(T).Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					lblEvak(T).Text = lblEURVak(T).Caption
'				End If
'			Next 
'		End If

'		On Error GoTo 0
'		'UPGRADE_WARNING: Couldn't resolve default property of object Me.lblEURVak. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		Me.lblEURVakXX(0).Text = VB6.Format(CDec(Me.lblEURVak(54)) + CDec(Me.lblEURVak(55)) + CDec(Me.lblEURVak(56)) + CDec(Me.lblEURVak(57)) + CDec(Me.lblEURVak(61)) + CDec(Me.lblEURVak(63)), "#,##0.00")
'		Me.lblEURVakXX(1).Text = Me.lblEURVakXX(0).Text
'		'UPGRADE_WARNING: Couldn't resolve default property of object Me.lblEURVak. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		Me.lblEURVakYY(0).Text = VB6.Format(CDec(Me.lblEURVak(59)) + CDec(Me.lblEURVak(62)) + CDec(Me.lblEURVak(64)), "#,##0.00")
'		Me.lblEURVakYY(1).Text = Me.lblEURVakYY(0).Text

'		'nu bepalen 71 of 72
'		If CDec(lblEURVakXX(1).Text) - CDec(lblEURVakYY(1).Text) < 0 Then
'			lblEvak(71).Text = VB6.Format(0, "#,##0.00")
'			lblEvak(72).Text = VB6.Format(System.Math.Abs(CDec(lblEURVakXX(1).Text) - CDec(lblEURVakYY(1).Text)), "#,##0.00")
'			tmpVak = "<D71>0</D71>"
'			tmpVakHier = "<D72>" & Trim(Str(CDec(lblEvak(72).Text) * 100)) & "</D72>"
'			tmpXMLHier = Replace(tmpXMLHier, tmpVak, tmpVakHier)
'		Else
'			lblEvak(72).Text = VB6.Format(0, "#,##0.00")
'			lblEvak(71).Text = VB6.Format(System.Math.Abs(CDec(lblEURVakXX(1).Text) - CDec(lblEURVakYY(1).Text)), "#,##0.00")

'			tmpVak = "<D71>0</D71>"
'			tmpVakHier = "<D71>" & Trim(Str(CDec(lblEvak(71).Text) * 100)) & "</D71>"
'			tmpXMLHier = Replace(tmpXMLHier, tmpVak, tmpVakHier)
'		End If
'		RichTextBox1.Text = tmpXMLHier
'		If VB.Left(tmpVakHier, 5) = "<D72>" Then
'			'72 is teruggave dus aanvraag teruggave automatisch aanklikken
'			Me.cbAanvraagTerugbetaling.CheckState = System.Windows.Forms.CheckState.Checked
'		End If

'	End Sub



'	Private Sub SSTab1_Click(ByRef PreviousTab As Short)

'		'Select Case SSTab1.Tab
'		'    Case 2
'		'        Select Case String99(Reading, 301)
'		'            Case "2"
'		'                Me.RichTextBox1.LoadFile App.path & "\QbtwAangifte.rtf"
'		'
'		'            Case "1"
'		'                Me.RichTextBox1.LoadFile App.path & "\MbtwAangifte.rtf"
'		'            Case Else
'		'                MsgBox "Setup BTW instellen a.u.b.", vbCritical
'		'        End Select
'		'        RichTextBox1.Text = Replace(RichTextBox1.Text, "<D3>0.00</D3>", "<D3>1.11</D3>")
'		'End Select

'	End Sub


'	Private Sub tvwBtwAangiftes_NodeClick(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvwBtwAangiftes.NodeMouseClick
'		Dim Node As System.Windows.Forms.TreeNode = eventArgs.Node

'		If Node.Index > 1 Then
'			'MsgBox "Index = " & Node.Index & " Text:" & Node.Text
'			Initialiseren.Enabled = False
'			CmdEmailNBB.Enabled = False
'			VulDeVelden(VB.Left(Node.Text, 4), VB.Right(Node.Text, 2))
'		End If

'	End Sub

'    Private Sub frmBTWAangifte_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

'    End Sub
'End Class