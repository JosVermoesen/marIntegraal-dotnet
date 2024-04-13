Imports System.ComponentModel

Public Class Briefwisseling
    Private Sub frmBriefwisseling_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        If rtbTekst.Text <> "" Then
            Msg = "Huidige inhoud negeren." & vbCrLf & vbCrLf & "Bent U zeker ?"
            Ktrl = MsgBox(Msg, 292, "Voortijdig stoppen...")
            If Ktrl = 6 Then
            Else
                Exit Sub
            End If
        Else
            Close
        End If

    End Sub

    Private Sub frmBriefwisseling_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Mim.CorrespondenceMenuItem.Enabled=True 

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
'Friend Class VrijBericht
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Dim MaxLijn79 As Short
'	Dim KontaktPersoon As Short

'	Dim txtFaxIs As String
'	Dim txtMailIs As String

'	Dim VsoftVanaf As String
'	Dim VsoftTot As String
'	Dim BeginXbox As Short
'	Dim BeginYbox As Short

'	Dim FlPartij As Short
'	Dim PartijKode As New VB6.FixedLengthString(1)
'	Dim BriefType As New VB6.FixedLengthString(1)

'	Dim Tel As Short

'	Dim WProgramma As String
'	Dim PNaam As String
'	Dim Wdokument As String
'	Dim PrintSendKeys As String
'	Dim CloseSendKeys As String
'	Dim ReedsBestaand As Short
'	Dim TekstIsRich As Boolean

'	Dim rsBrief As ADODB.Recordset
'	Dim wApp As Microsoft.Office.Interop.Word.Application
'	Dim mailBijlage As String
'	Dim faxBijlage As String

'	'Public g_objFaxDocument As New FAXCOMEXLib.FaxDocument
'	'Public objFaxVerzender As FaxSender

'	Private Sub BerichtInOfUit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BerichtInOfUit.Click
'		Dim Index As Short = BerichtInOfUit.GetIndex(eventSender)
'		Dim T As Short
'		Dim XXX As String

'DodaNogess: 
'		On Error Resume Next
'		'UPGRADE_WARNING: Couldn't resolve default property of object rsBrief.ActiveConnection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		XXX = rsBrief.ActiveConnection
'		If Err.Number Or Index = 0 Then
'			rsBrief = New ADODB.Recordset
'			On Error Resume Next
'			Err.Clear()
'			rsBrief.CursorLocation = ADODB.CursorLocationEnum.adUseClient
'			Msg = "SELECT * FROM Briefwisseling WHERE A110 = " & "'" & AdoGetField(FlPartij, "#A110 #") & "'"

'			rsBrief.Open(Msg, adntDB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
'			If Err.Number Then
'				MsgBox("Bron:" & vbCrLf & Err.Source & vbCrLf & vbCrLf & "Foutnummer: " & Err.Number & vbCrLf & vbCrLf & "Detail:" & vbCrLf & Err.Description)
'				Exit Sub
'			Else
'				'kontrole van de nieuwe velden...
'				Err.Clear()
'				On Error Resume Next
'				If rsBrief.Fields("bstndNaam").Name = "bstndNaam" Then
'					'ok
'				ElseIf Err.Number = 3265 Then 
'					rsBrief.Close()
'					Msg = "ALTER TABLE Briefwisseling ADD COLUMN bstndNaam varchar;"
'					Err.Clear()
'					adntDB.Execute(Msg)
'					If Err.Number Then
'						MsgBox("Foutmelding bron: " & Err.Source & vbCrLf & "Foutkodenummer: " & Err.Number & vbCrLf & vbCrLf & "Foutmelding omschrijving:" & vbCrLf & Err.Description)
'					End If
'					Msg = "ALTER TABLE Briefwisseling ADD COLUMN typeZending TEXT(5);"
'					Err.Clear()
'					adntDB.Execute(Msg)
'					If Err.Number Then
'						MsgBox("Foutmelding bron: " & Err.Source & vbCrLf & "Foutkodenummer: " & Err.Number & vbCrLf & vbCrLf & "Foutmelding omschrijving:" & vbCrLf & Err.Description)
'					End If
'					Msg = "ALTER TABLE Briefwisseling ADD COLUMN bstndBLOB OLEobject;"
'					Err.Clear()
'					adntDB.Execute(Msg)
'					If Err.Number Then
'						MsgBox("Foutmelding bron: " & Err.Source & vbCrLf & "Foutkodenummer: " & Err.Number & vbCrLf & vbCrLf & "Foutmelding omschrijving:" & vbCrLf & Err.Description)
'					End If
'					GoTo DodaNogess
'				End If
'			End If
'		End If

'		Select Case Index
'			Case 0
'				T = 0
'				If rsBrief.RecordCount = 0 Then
'					MsgBox("Geen briefwisseling te vinden voor deze partij !")
'					Exit Sub
'				End If
'				Xlog.Close()
'				'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
'				Load(Xlog)
'				Xlog.Text = "Bericht inladen voor : " & AdoGetField(FlPartij, "#A100 #")
'				Xlog.X.Rows = 1
'				Xlog.X.Cols = 2
'				Xlog.X.Col = 0
'				Xlog.X.Row = 0
'				Xlog.X.Text = "Aanmaakdatum"
'				Xlog.X.Col = 1
'				Xlog.X.Text = "Betreft"

'				Do While Not rsBrief.EOF
'					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'					GoSub VolgendeLijn
'					rsBrief.MoveNext()
'				Loop 
'				Xlog.WijzigenLijn.Visible = False
'				Xlog.Afsluiten.TabStop = False
'				Xlog.cbAfbeelding.Visible = False
'				Xlog.X.Row = 1
'				Xlog.X.Col = 0

'				Xlog.X.set_ColWidth(0, 1680)
'				Xlog.X.set_ColWidth(1, 4785)
'				Xlog.X.set_ColAlignment(0, MSFlexGridLib.AlignmentSettings.flexAlignLeftTop)
'				Xlog.X.set_ColAlignment(1, MSFlexGridLib.AlignmentSettings.flexAlignLeftTop)
'				XLogKey = ""
'				Xlog.SSTab1.TabPages.Item(1).Visible = False
'				Xlog.ShowDialog()
'				If XLogKey <> "" Then
'					ReedsBestaand = True
'					rsBrief.MoveFirst()
'					rsBrief.Move(Xlog.X.Row - 1)

'					On Error Resume Next
'					VanTot(2).Text = rsBrief.Fields("A110").Value
'					VanTot(0).Text = rsBrief.Fields("v133").Value
'					VanTot(1).Text = rsBrief.Fields("v134").Value
'					lblOorsprong.Text = rsBrief.Fields("v128").Value
'					If rsBrief.Fields("v126").Value = "K" Then
'						Partij(0).Checked = True
'					Else
'						Partij(1).Checked = True
'					End If

'					If rsBrief.Fields("v127").Value = "B" Then
'						Briefwisseling(0).Checked = True
'					Else
'						Briefwisseling(1).Checked = True
'					End If

'					TxtTekst(1).Text = rsBrief.Fields("v129").Value
'					If Val(rsBrief.Fields("v131").Value) <= Sortering.Items.Count - 1 Then
'						Sortering.SelectedIndex = Val(rsBrief.Fields("v131").Value)
'					Else
'						Sortering.SelectedIndex = 0
'					End If
'					'UPGRADE_WARNING: TextRTF was upgraded to Text and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'					txtTekst0.Text = rsBrief.Fields("v132").Value
'					Wegschrijven.Enabled = True
'					txtTekst0.Enabled = True
'					txtTekst0.Focus()
'				End If
'				On Error GoTo 0
'				Xlog.Close()

'			Case 1
'				If Not ReedsBestaand Then
'					rsBrief.AddNew()
'				Else
'					Msg = "Wijzigingen aan bestaand bericht bewaren" & vbCrLf
'					Msg = Msg & "Bent U zeker ?"
'					KtrlBox = MsgBox(Msg, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1)
'					If KtrlBox = MsgBoxResult.Yes Then
'					Else
'						Exit Sub
'					End If
'				End If
'				rsBrief.Fields("v172").Value = "16"
'				rsBrief.Fields("v133").Value = VB.Left(VanTot(0).Text, 13)
'				rsBrief.Fields("v134").Value = VB.Left(VanTot(1).Text, 13)
'				rsBrief.Fields("A110").Value = VanTot(2).Text
'				rsBrief.Fields("v126").Value = PartijKode.Value
'				rsBrief.Fields("v127").Value = BriefType.Value
'				rsBrief.Fields("v129").Value = TxtTekst(1).Text
'				rsBrief.Fields("v130").Value = Now
'				rsBrief.Fields("v131").Value = Sortering.SelectedIndex
'				rsBrief.Fields("v132").Value = txtTekst0.RTF
'				If ReedsBestaand Then
'				Else
'					rsBrief.Fields("v128").Value = Now
'					If faxBijlage <> "" Then
'						FileToBlob(rsBrief.Fields("bstndBLOB"), faxBijlage)
'						If Len(faxBijlage) > 255 Then
'							rsBrief.Fields("bstndNaam").Value = VB.Right(faxBijlage, 255)
'						Else
'							rsBrief.Fields("bstndNaam").Value = faxBijlage
'						End If
'						rsBrief.Fields("typeZending").Value = "FAX"
'					ElseIf mailBijlage <> "" Then 
'						FileToBlob(rsBrief.Fields("bstndBLOB"), mailBijlage)
'						If Len(mailBijlage) > 255 Then
'							rsBrief.Fields("bstndNaam").Value = VB.Right(mailBijlage, 255)
'						Else
'							rsBrief.Fields("bstndNaam").Value = mailBijlage
'						End If
'						rsBrief.Fields("typeZending").Value = "EMAIL"
'					Else
'						rsBrief.Fields("bstndNaam").Value = ""
'					End If
'					'Stop
'				End If
'				rsBrief.Update()
'				Schoon()
'				Zoeken.Focus()

'		End Select
'		Exit Sub

'VolgendeLijn: 
'		T = T + 1
'		Select Case FlPartij
'			Case TableOfCustomers, TableOfSuppliers
'				Xlog.X.AddItem(rsBrief.Fields("v128").Value & vbTab & rsBrief.Fields("v129").Value)
'		End Select
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'	End Sub
'	'UPGRADE_WARNING: Event Briefwisseling.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub Briefwisseling_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Briefwisseling.CheckedChanged
'		If eventSender.Checked Then
'			Dim Index As Short = Briefwisseling.GetIndex(eventSender)

'			Select Case Briefwisseling(0).Checked
'				Case True
'					BriefType.Value = "B"
'				Case False
'					BriefType.Value = "M"
'			End Select

'		End If
'	End Sub


'	Private Sub cbBijlage_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbBijlage.Click

'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(dnnInstellingen, PostvakIO). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		If LaadTekst("dnnInstellingen", "PostvakIO") = "" Then
'			MsgBox("Nieuwe PC of nog geen instellingen voor PDF Postvak In.  Aanbevolen in te te stellen a.u.b. via submenu DotNetNuke.", MsgBoxStyle.Information)
'			Mim.TekenOpen.InitialDirectory = LocationCompanyData
'		Else
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(dnnInstellingen, PostvakIO). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Mim.TekenOpen.InitialDirectory = LaadTekst("dnnInstellingen", "PostvakIO")
'		End If
'		'Mim.Teken.Filter = "Acrobat bestanden (*.pdf)|*.pdf"
'		Mim.TekenOpen.ShowDialog()
'		If Mim.TekenOpen.FileName = "" Then Exit Sub
'		mailBijlage = Mim.TekenOpen.FileName

'	End Sub

'	'UPGRADE_WARNING: Event cbDocumentPrinterHier.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub cbDocumentPrinterHier_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbDocumentPrinterHier.SelectedIndexChanged

'		dokumentPrinterNr = cbDocumentPrinterHier.SelectedIndex

'	End Sub

'	Private Sub cbFaxBijlage_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbFaxBijlage.Click

'		Mim.TekenOpen.FileName = mailBijlage
'		'Mim.Teken.InitDir = LocationCompanyData
'		Mim.TekenOpen.ShowDialog()
'		If Mim.TekenOpen.FileName = "" Then Exit Sub
'		faxBijlage = Mim.TekenOpen.FileName

'	End Sub

'	Private Sub cbLayOudPDF_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbLayOudPDF.Click

'		LayOutpdfDokument.Show()

'	End Sub

'	'UPGRADE_WARNING: Event cbPDF.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub cbPDF_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbPDF.CheckStateChanged

'		If cbPDF.CheckState = System.Windows.Forms.CheckState.Checked Then
'			Me.cbTogglePrinter.Visible = False
'			Me.cbDocumentPrinterHier.Visible = False
'		Else
'			Me.cbTogglePrinter.Visible = True
'			Me.cbDocumentPrinterHier.Visible = True
'		End If

'	End Sub

'	Private Sub cbTogglePrinter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbTogglePrinter.Click

'		Me.cbDocumentPrinterHier.Enabled = Not Me.cbDocumentPrinterHier.Enabled

'	End Sub

'	'UPGRADE_WARNING: Event CmbAfdrukModus.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub CmbAfdrukModus_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmbAfdrukModus.SelectedIndexChanged

'		Select Case VB.Left(CmbAfdrukModus.Text, 1)
'			Case "0", "1", "3"
'				If Me.MPISessie.SessionID <> 0 Then
'				Else
'					On Error Resume Next
'					Me.MPISessie.SignOn()
'					If Err.Number Then
'						'Msg = "U kiest om het mailsysteem niet aan te wenden." & vbCr
'						'Msg = Msg & "Probeer eventueel later opnieuw E-mail aan te duiden" & vbCr & vbCr
'						'Msg = Msg & "Foutmelding van het systeem: " & Err.Description
'						'MsgBox Msg, vbExclamation
'						SnelHelpPrint(Err.Description, blLogging)
'						CmbAfdrukModus.SelectedIndex = 2
'					Else
'						On Error GoTo 0
'						Me.MPIBericht.SessionID = Me.MPISessie.SessionID
'						SnelHelpPrint("E-mail sessie met succes opgestart. IDkode :" & VB6.Format(Me.MPISessie.SessionID), blLogging)
'					End If
'				End If
'			Case "2"
'				If Me.MPISessie.SessionID = 0 Then
'				Else
'					On Error Resume Next
'					Me.MPISessie.SignOff()
'					If Err.Number Then
'						MsgBox("Fout tijdens afsluiten van een sessie...  Postvak In (InBox) werd voortijdig gesloten.")
'					Else
'						SnelHelpPrint("E-mail sessie werd met succes beëindigd...", blLogging)
'					End If
'				End If
'			Case Else
'				MsgBox("stop")
'		End Select

'	End Sub


'	Private Sub cmdFax_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFax.Click

'		If cmdFax.Enabled = False Then
'			Exit Sub
'		Else
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'		End If

'		'As default, create the sender object, and load the default sender information
'		Err.Clear()
'		On Error Resume Next
'		'Set objFaxVerzender = g_objFaxDocument.Sender
'		If Err.Number Then
'			MsgBox("Enkel beschikbaar voor Windows XP en hoger", MsgBoxStyle.Information)
'			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'			'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = vbNormal
'			Exit Sub
'		End If
'		'objFaxVerzender.LoadDefaultSender

'		'Error handling
'		'On Error GoTo Error_Handler

'		'Check if the Aanhangsel checkbox was selected, but no Aanhangsel provided
'		'If chkAanhangsel.Value = 1 And txtAanhangselPath.Text = "" Then
'		'    MsgBox "Duidt het path voor de bijlage aan en probeer opnieuw.", vbExclamation
'		'    Exit Sub
'		'End If

'		'Remove the previous recipient, if there is one. Otherwise, the fax would be sent to
'		'recipients that accumulate in the FaxRecipients collection from each previous use of the form.
'		'If g_objFaxDocument.Recipients.Count = 1 Then g_objFaxDocument.Recipients.Remove (1)

'		'Set no cover page as default
'		'g_objFaxDocument.CoverPageType = fcptNONE

'		'If the checkbox is selected, set cover page type to "local"
'		'and set the path and file name to the textbox text
'		'If chkVoorBlad.Value = 1 Then
'		'    g_objFaxDocument.CoverPageType = fcptLOCAL
'		'    g_objFaxDocument.CoverPage = txtCPPath.Text
'		'End If

'		'Set the rest of the fax document properties
'		'Noties voorblad
'		'g_objFaxDocument.Note = "" 'txtNotities.Text
'		'g_objFaxDocument.Subject = "" 'txtOnderwerp.Text
'		'g_objFaxDocument.Recipients.Add TxtTekst(13).Text, TxtTekst(3).Text   'txtFaxNummerGeadresseerde.Text, txtNaamGeadresseerde.Text
'		'g_objFaxDocument.Sender.Name = objFaxVerzender.Name
'		'g_objFaxDocument.Sender.FaxNumber = objFaxVerzender.FaxNumber
'		'g_objFaxDocument.Sender.OfficePhone = objFaxVerzender.OfficePhone
'		'Include the Aanhangsel if the Aanhangsel checkbox is selected

'		Dim BestandHier As String

'		If faxBijlage <> "" Then
'			'g_objFaxDocument.Body = faxBijlage

'			'Submit the document to the server
'			'Call g_objFaxDocument.Submit("") '(ServerNameText.Text)
'		Else
'			'g_objFaxDocument.Body = BestandHier 'txtAanhangselPath.Text
'			'g_objFaxDocument.Body = "D:\Mijn Documenten\MODI\test.xls"

'			'Submit the document to the server
'			'Call g_objFaxDocument.Submit("") '(ServerNameText.Text)
'			'Kill BestandHier
'		End If
'		If TxtTekst(13).Text <> txtFaxIs Then
'			MsgBox("gewijzigd nummer.  Hier nog routine vraagstelling om al dan niet de partijFiche bij te werken", MsgBoxStyle.Information)
'		End If
'		BerichtInOfUit_Click(BerichtInOfUit.Item(1), New System.EventArgs())
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal

'	End Sub

'	Private Sub cmdMail_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMail.Click

'		If cmdMail.Enabled = False Then
'			Exit Sub
'		Else
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'		End If

'		Dim BestandHier As String
'		If Me.MPISessie.SessionID <> 0 Then
'			On Error GoTo MPIError
'			'Compose new message
'			Me.MPIBericht.Compose()

'			'Address message
'			If CmbAfdrukModus.SelectedIndex = 0 Then
'				Me.MPIBericht.RecipDisplayName = rsMAR(FlPartij).Fields("A100").Value
'				Me.MPIBericht.RecipAddress = "SMTP:" & TxtTekst(14).Text
'			Else
'				Me.MPIBericht.RecipDisplayName = rsMAR(FlPartij).Fields("A100").Value
'				Me.MPIBericht.RecipAddress = "SMTP:" & TxtTekst(14).Text
'			End If
'			'Resolve recipient name
'			Me.MPIBericht.AddressResolveUI = True '=dialogbox, false = error genereren
'			'MpiBericht.ResolveName

'			'Create the message
'			Me.MPIBericht.MsgSubject = TxtTekst(1).Text
'			If CmbAfdrukModus.SelectedIndex = 0 Then
'				Me.MPIBericht.MsgNoteText = txtTekst0.Text
'			Else
'				Me.MPIBericht.MsgSubject = TxtTekst(1).Text
'				Me.MPIBericht.MsgNoteText = "Briefwisseling in bijlage als MS Word Document" 'txtTekst0.Text
'				'KtrlBox = MsgBox("Verstuurde E-mail aan " & AdoGetField(FlPartij, "#v224 #") & vbCr & vbCr & "Afdruk maken ?", vbQuestion + vbYesNo + vbDefaultButton2)
'				Me.MPIBericht.AttachmentPathName = BestandHier
'			End If
'			If mailBijlage <> "" Then
'				Me.MPIBericht.AttachmentPathName = mailBijlage
'			End If
'			'Send the message
'			On Error Resume Next
'			Me.MPIBericht.Send(True)
'			If Err.Number = 32001 Then
'				'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'				'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'				'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'				System.Windows.Forms.Cursor.Current = vbNormal : Exit Sub
'			End If
'			If Err.Number Then MsgBox(ErrorToString())
'			If CmbAfdrukModus.SelectedIndex = 0 Then
'			Else
'				Kill(BestandHier)
'			End If
'			BerichtInOfUit_Click(BerichtInOfUit.Item(1), New System.EventArgs())
'		Else
'			MsgBox("Uw E-mail systeem is niet geactiveerd.  Contacteer uw systeembeheerder voor bijkomende inlichtingen.", MsgBoxStyle.Exclamation)
'		End If
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal
'		Exit Sub

'MPIError: 
'		MsgBox(ErrorToString())
'		Resume Next

'	End Sub



'	Private Sub CmdRtfPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdRtfPrint.Click

'		'Dim cat As New ADOX.Catalog
'		'cat.Create adojetprovider & "Data Source=c:\new.mdb"

'		'UPGRADE_ISSUE: Constant cdlPDReturnDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
'		'UPGRADE_ISSUE: MSComDlg.CommonDialog property Teken.FLAGS was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
'		Mim.Teken.Flags = MSComDlg.PrinterConstants.cdlPDReturnDC
'		'UPGRADE_ISSUE: Constant cdlPDNoPageNums was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
'		'UPGRADE_ISSUE: MSComDlg.CommonDialog property Teken.FLAGS was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
'		Mim.Teken.Flags = MSComDlg.PrinterConstants.cdlPDNoPageNums
'		If txtTekst0.SelectionLength = 0 Then
'			'UPGRADE_ISSUE: Constant cdlPDAllPages was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
'			'UPGRADE_ISSUE: MSComDlg.CommonDialog property Teken.FLAGS was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
'			Mim.Teken.Flags = MSComDlg.PrinterConstants.cdlPDAllPages
'		Else
'			'UPGRADE_ISSUE: Constant cdlPDSelection was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
'			'UPGRADE_ISSUE: MSComDlg.CommonDialog property Teken.FLAGS was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
'			Mim.Teken.Flags = MSComDlg.PrinterConstants.cdlPDSelection
'		End If
'		Mim.TekenPrint.ShowDialog()
'		On Error Resume Next
'		'UPGRADE_ISSUE: MSComDlg.CommonDialog property Teken.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
'		'UPGRADE_ISSUE: RichTextLib.RichTextBox method txtTekst0.SelPrint was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
'		txtTekst0.SelPrint(Mim.Teken.hDC)

'	End Sub

'	Private Sub VrijBericht_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
'		Top = 0
'		Left = 0

'		cbDocumentPrinterHier.Items.Clear()
'		If Printers.Count = 0 Then MsgBox("Installeer eerst een printerdriver a.u.b. (ook al beschikt U nog over geen printer.  Bij blijvende problemen in netwerk gelieve op te starten met het command '/P=FALSE' en uw netwerkbeheerder te informeren)", MsgBoxStyle.Exclamation) : End
'		For CountTo = 0 To Printers.Count - 1
'			'UPGRADE_ISSUE: Printer property Printers.Port was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
'			Me.cbDocumentPrinterHier.Items.Add(Printers(CountTo).Port & " " & Printers(CountTo).DeviceName)
'		Next 
'		cbDocumentPrinterHier.SelectedIndex = dokumentPrinterNr
'		If String99(Reading, 299) = "2" Then
'			Me.cbPDF.CheckState = System.Windows.Forms.CheckState.Unchecked
'		Else
'			Me.cbPDF.CheckState = System.Windows.Forms.CheckState.Checked
'		End If

'		PageCounter = 0
'		Partij(0).Checked = True
'		txtTekst0.Font = VB6.FontChangeName(txtTekst0.Font, "Courier New")
'		MaxLijn79 = 90
'		Briefwisseling(1).Enabled = True
'		Briefwisseling(0).Checked = True

'		KontaktPersoon = Val(String99(Reading, 201))

'		CmbAfdrukModus.Items.Clear()
'		CmbAfdrukModus.Items.Add("0: E-mail via normale tekst")
'		CmbAfdrukModus.Items.Add("1: E-mail via insluiting van Word Sjabloon")
'		CmbAfdrukModus.Items.Add("2: E-mail wordt niet gebruikt op dit ogenblik")
'		CmbAfdrukModus.SelectedIndex = 0
'		CmbAfdrukModus.Enabled = False
'		Schoon()

'	End Sub

'	Private Sub VrijBericht_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

'		If Me.MPISessie.SessionID = 0 Then
'		Else
'			On Error Resume Next
'			Me.MPISessie.SignOff()
'			If Err.Number Then
'				MsgBox("Fout tijdens afsluiten van een sessie...  Postvak In (InBox) werd voortijdig gesloten.")
'			End If
'		End If

'	End Sub

'	'UPGRADE_WARNING: Event Partij.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub Partij_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Partij.CheckedChanged
'		If eventSender.Checked Then
'			Dim Index As Short = Partij.GetIndex(eventSender)
'			Dim T As Short

'			Select Case Partij(0).Checked
'				Case True
'					PartijKode.Value = "K"
'					FlPartij = TableOfCustomers
'				Case False
'					PartijKode.Value = "L"
'					FlPartij = TableOfSuppliers
'			End Select
'			BriefType.Value = "B"
'			Briefwisseling(0).Checked = 1

'			Sortering.Items.Clear()
'			For T = 0 To FlAantalIndexen(FlPartij)
'				Sortering.Items.Add(VB6.Format(T, "00") & ":" & FLIndexCaption(FlPartij, T))
'			Next 
'			Sortering.SelectedIndex = 1

'		End If
'	End Sub


'	Private Sub PrintUserDef(ByRef TypeEnTaal As String)
'		Dim B As Short
'		Dim Printer As New Printer
'		Dim Dummy As Short
'		Dim T As Short
'		Dim Tabulatie As Short
'		Dim FlFree As Short
'		Dim Teller As Short

'		Dim ReportText(50) As String
'		Dim psX(50) As Single
'		Dim psY(50) As Single
'		Dim psFontSize(50) As Single
'		Dim psFontName(50) As String
'		Dim psFontBold(50) As Short
'		Dim psFontItalic(50) As Short
'		Dim psFontUnderLine(50) As Short
'		Dim psColor(50) As Integer
'		Dim MaxPslokatie As Short

'		Dim BoxTeller As Short
'		Dim Box(10) As Short
'		Dim BeginX(10) As Short
'		Dim BeginY(10) As Short
'		Dim TotX(10) As Short
'		Dim TotY(10) As Short
'		Dim PsLokatie As Short

'		On Error GoTo ErrorLoad

'		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		If Dir(LocationCompanyData & "DDEF" & TypeEnTaal & ".Txt") = "" Then
'			Beep()
'			Exit Sub
'		Else
'			FlFree = FreeFile
'			FileOpen(FlFree, LocationCompanyData & "DDEF" & TypeEnTaal & ".Txt", OpenMode.Input)
'			Input(FlFree, Dummy)
'			Input(FlFree, VsoftVanaf)
'			Input(FlFree, VsoftTot)
'			For Teller = 0 To 10
'				Input(FlFree, BeginX(Teller))
'				Input(FlFree, BeginY(Teller))
'				Input(FlFree, TotX(Teller))
'				Input(FlFree, TotY(Teller))
'				Input(FlFree, Box(Teller))
'			Next 
'			Teller = 0
'			While Not EOF(FlFree)
'				Input(FlFree, ReportText(Teller))
'				Input(FlFree, psX(Teller))
'				Input(FlFree, psY(Teller))
'				Input(FlFree, psFontSize(Teller))
'				Input(FlFree, psFontName(Teller))
'				Input(FlFree, psFontBold(Teller))
'				Input(FlFree, psFontItalic(Teller))
'				Input(FlFree, psFontUnderLine(Teller))
'				Input(FlFree, psColor(Teller))
'				Teller = Teller + 1
'			End While
'			MaxPslokatie = Teller
'			FileClose(FlFree)
'		End If

'		BeginXbox = BeginX(0)
'		BeginYbox = BeginY(0)

'		PsLokatie = 0
'		Do While PsLokatie <= MaxPslokatie
'			If ReportText(PsLokatie) <> "" Then
'				Printer.FontName = psFontName(PsLokatie)
'				Printer.FontItalic = psFontItalic(PsLokatie)
'				Printer.FontSize = psFontSize(PsLokatie)
'				Printer.FontBold = psFontBold(PsLokatie)
'				Printer.FontUnderline = psFontUnderLine(PsLokatie)
'				Printer.ForeColor = psColor(PsLokatie)
'			End If
'			Printer.CurrentX = psX(PsLokatie)
'			Printer.CurrentY = psY(PsLokatie)
'			Printer.Write(ReportText(PsLokatie))
'			PsLokatie = PsLokatie + 1
'		Loop 
'		For T = 0 To 10
'			If BeginX(T) = 0 Then
'			ElseIf Box(T) Then 
'				Printer.Line(False, BeginX(T), BeginY(T), False, TotX(T), TotY(T), B)
'			Else
'				'printer.Line (BeginX(T), BeginY(T))-(TotX(T), TotY(T))
'			End If
'		Next 

'		Dim FiguurX As Short
'		Dim FiguurY As Short
'		Dim FiguurName As String
'		Dim FigBestandsnaam As String
'		Dim Hoogte As Object
'		Dim Breedte As Object

'		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		If Dir(LocationCompanyData & "DDEF" & TypeEnTaal & "G.Txt") = "" Then
'		Else
'			FlFree = FreeFile
'			FileOpen(FlFree, LocationCompanyData & "DDEF" & TypeEnTaal & "G.Txt", OpenMode.Input)
'			While Not EOF(FlFree)
'				Input(FlFree, FiguurX)
'				Input(FlFree, FiguurY)
'				Input(FlFree, FiguurName)
'				If ScrLeesTekstBestand(Msg, LocationCompanyData & FiguurName & ".mfd") Then
'					FigBestandsnaam = VB.Left(Msg, InStr(Msg, vbTab) - 1)
'					Mim.imgFiguur.Image = System.Drawing.Image.FromFile(FigBestandsnaam)
'					Msg = Mid(Msg, InStr(Msg, vbTab) + 1)
'					'UPGRADE_WARNING: Couldn't resolve default property of object Hoogte. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					Hoogte = VB.Left(Msg, InStr(Msg, vbTab) - 1)
'					Msg = Mid(Msg, InStr(Msg, vbTab) + 1)
'					'UPGRADE_WARNING: Couldn't resolve default property of object Breedte. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					Breedte = Msg
'					Printer.PaintPicture(Mim.imgFiguur.Image, FiguurX, FiguurY, Breedte, Hoogte)
'				Else
'					MsgBox("afdrukprobleemke figuurobject: " & FiguurName)
'				End If
'			End While
'			FileClose(FlFree)
'		End If
'		Exit Sub

'ErrorLoad: 
'		MsgBox("Stop tijdens inladen dokumentdefinitie" & vbCrLf & vbCrLf & ErrorToString())
'		Exit Sub
'		Resume 

'	End Sub

'	Private Sub Schoon()

'		VanTot(0).Text = ""
'		VanTot(1).Text = ""
'		lblOorsprong.Text = ""
'		'UPGRADE_WARNING: TextRTF was upgraded to Text and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		txtTekst0.Text = ""
'		TxtTekst(1).Text = ""
'		TxtTekst(13).Text = ""
'		TxtTekst(14).Text = ""
'		mailBijlage = ""
'		faxBijlage = ""

'		Me.cbBijlage.Enabled = False
'		Wegschrijven.Enabled = False
'		txtTekst0.Enabled = False
'		BerichtInofUit(1).Enabled = False
'		BerichtInofUit(0).Enabled = True
'		Zoeken.Enabled = True
'		TLBRecord(TableOfVarious) = ""

'		Partij_CheckedChanged(Partij.Item(0), New System.EventArgs())

'	End Sub

'	Private Sub SchoonVegen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SchoonVegen.Click

'		Schoon()

'	End Sub

'	Private Sub sluiten_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles sluiten.Click

'		If txtTekst0.Text <> "" Then
'			Msg = "Huidige inbreng - al dan niet - reeds weggeschreven.  Venster sluiten." & vbCrLf & vbCrLf
'			Msg = Msg & "Bent U zeker ?"
'			Ktrl = MsgBox(Msg, 292, "Vrije berichtgeving verlaten")
'			If Ktrl = 6 Then
'			Else
'				Exit Sub
'			End If
'		End If
'		Me.Close()

'	End Sub



'	'UPGRADE_WARNING: Event TxtTekst.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub TxtTekst_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtTekst.TextChanged
'		Dim Index As Short = TxtTekst.GetIndex(eventSender)

'		'If Index <> 0 Then Exit Sub
'		'If Not WegSchrijven.Enabled Then
'		'    WegSchrijven.Enabled = True
'		'    BerichtInOfUit(1).Enabled = True
'		'End If
'		Select Case Index
'			Case 13
'				If TxtTekst(13).Text = "" Then
'					cmdFax.Enabled = False
'				Else
'					cmdFax.Enabled = True
'				End If

'			Case 14
'				If TxtTekst(14).Text = "" Then
'					cmdMail.Enabled = False
'					Me.cbBijlage.Enabled = False
'				Else
'					cmdMail.Enabled = True
'					Me.cbBijlage.Enabled = True
'				End If
'		End Select


'	End Sub

'	Private Sub TxtTekst_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtTekst.Enter
'		Dim Index As Short = TxtTekst.GetIndex(eventSender)

'		'If Index <> 0 Then Exit Sub
'		'Zoeken.Default = False
'		'TxtTekst(0).FontName = "Courier New"

'	End Sub

'	Private Sub TxtTekst_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtTekst.Leave
'		Dim Index As Short = TxtTekst.GetIndex(eventSender)

'		'If Index <> 0 Then Exit Sub
'		VB6.SetDefault(Zoeken, True)

'	End Sub

'	Private Sub TxtTekst0_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtTekst0.TextChanged

'		If Not Wegschrijven.Enabled Then
'			Wegschrijven.Enabled = True
'			BerichtInofUit(1).Enabled = True
'		End If
'		CmdRtfPrint.Enabled = True

'	End Sub

'	Private Sub TxtTekst0_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtTekst0.Enter

'		VB6.SetDefault(Zoeken, False)
'		txtTekst0.Font = VB6.FontChangeName(txtTekst0.Font, "Courier New")

'	End Sub

'	Private Sub TxtTekst0_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtTekst0.Leave

'		VB6.SetDefault(Zoeken, True)

'	End Sub

'	Private Sub TxtTekst0_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles TxtTekst0.MouseDown
'		Dim Button As Short = eventArgs.Button \ &H100000
'		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
'		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
'		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)

'		If Button = 2 Then
'			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			Mim.TekenOpen.Filter = "Rich Text Format bestanden|*.rtf"
'			Mim.TekenOpen.ShowDialog()
'			On Error Resume Next
'			txtTekst0.LoadFile(Mim.TekenOpen.FileName, Windows.Forms.RichTextBoxStreamType.RichText)
'			If Err.Number Then MsgBox(ErrorToString())
'		End If


'	End Sub

'	Private Sub Wegschrijven_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Wegschrijven.Click
'		Dim TelLijn As Integer
'		Dim positieCRLF As Integer
'		Dim SpatieLijn As Integer

'		Dim Tekst As String
'		Dim TekstLijn As String
'		Dim MijKeuze As String

'		If txtTekst0.Text = "" Then
'			Exit Sub
'		ElseIf Me.cbPDF.CheckState = System.Windows.Forms.CheckState.Checked Then 
'			MsgBox("Stop nog in ontwikkeling")
'			Exit Sub
'		Else
'			TelLijn = 0
'			Tekst = txtTekst0.Text
'			Do While Tekst <> ""
'				positieCRLF = InStr(Tekst, vbCrLf)
'				If positieCRLF Then
'					TekstLijn = VB.Left(Tekst, positieCRLF - 1)
'					Tekst = VB.Right(Tekst, Len(Tekst) - positieCRLF - 1)
'				Else
'					TekstLijn = Tekst
'					Tekst = ""
'				End If
'				TelLijn = TelLijn + 1
'				If Len(TekstLijn) > MaxLijn79 Then
'					MsgBox("Line " & Str(TelLijn) & " bestaat uit " & Str(Len(TekstLijn)) & " Tekens. (max." & Str(MaxLijn79) & " per lijn toegelaten)")
'					Exit Sub
'				End If
'			Loop 
'		End If
'		If Me.cbPDF.CheckState = System.Windows.Forms.CheckState.Checked Then
'			With Mim.Report
'				.OpenDoc()
'				.Author = "Jos Vermoesen"
'				.GUILanguage = 3 'Nederlands
'				.Title = "dnnBriefwisseling"
'			End With
'			pdfDrukAf()
'			Mim.Report.WriteDoc(ProgramLocation & VB6.Format(Now, "YYYYMMDDHHMMSS") & "-dnnBriefwisseling.pdf")
'			'If Me.cbPdfExport.Value = vbChecked Then
'			'    MsgBox "exporteren naar DNN folder of andere nog te definiëren"
'			'    Mim.Report.CloseDoc
'			'Else
'			Mim.Report.Preview()
'			'Endif
'		Else
'			DrukAf()
'		End If




'		On Error Resume Next
'		Me.Activate()

'	End Sub


'	Private Sub Zoeken_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Zoeken.Click

'		Dim JumpTeller As Short
'		Dim Taal As String

'		JumpTeller = -1

'Jumper: 
'		JumpTeller = JumpTeller + 1
'		aIndex = Sortering.SelectedIndex
'		SharedFl = FlPartij
'		GridText = ""
'		SqlSearch.ShowDialog()
'		Me.Activate()
'		On Error Resume Next
'		If Trim(rsMAR(FlPartij).Fields("v224").Value) <> "" Then 'email
'			txtMailIs = rsMAR(FlPartij).Fields("v224").Value
'			TxtTekst(14).Text = txtMailIs
'		Else
'			txtMailIs = ""
'			TxtTekst(14).Text = ""
'		End If
'		If Trim(rsMAR(FlPartij).Fields("vs02").Value) <> "" Then 'fax
'			txtFaxIs = rsMAR(FlPartij).Fields("vs02").Value
'			TxtTekst(13).Text = txtFaxIs
'		Else
'			txtFaxIs = ""
'			TxtTekst(13).Text = ""
'		End If

'		If Ktrl Then
'			BerichtInofUit(1).Enabled = False
'			Exit Sub
'		Else
'			Msg = AdoGetField(FlPartij, "#A100 #") & vbCrLf
'			Msg = Msg & AdoGetField(FlPartij, "#A125 #") & vbCrLf
'			Msg = Msg & AdoGetField(FlPartij, "#A104 #") & AdoGetField(FlPartij, "#A105 #") & AdoGetField(FlPartij, "#A106 #") & vbCrLf
'			Msg = Msg & AdoGetField(FlPartij, "#A109 #") & " " & AdoGetField(FlPartij, "#A107 #") & " " & AdoGetField(FlPartij, "#A108 #")

'			txtTekst0.Enabled = True
'			VanTot(JumpTeller).Text = FVT(FlPartij, Sortering.SelectedIndex)
'			VanTot(2).Text = AdoGetField(FlPartij, "#A110 #")
'			If Briefwisseling(0).Checked Then
'				VanTot(1).Text = VanTot(0).Text
'			Else
'				If JumpTeller Then
'				Else
'					GoTo Jumper
'				End If
'			End If
'			Taal = AdoGetField(FlPartij, "#A10C #")
'			TxtTekst(2).Text = Mid(fmarBoxText("003", Taal, AdoGetField(FlPartij, "#A102 #")), 4, 10)
'			TxtTekst(3).Text = AdoGetField(FlPartij, "#A100 #")
'			TxtTekst(0).Text = AdoGetField(FlPartij, "#A101 #")
'			If Val(AdoGetField(FlPartij, "#A102 #")) = 0 Then
'				TxtTekst(2).Text = ""
'			End If
'			TxtTekst(4).Text = Mid(fmarBoxText("003", Taal, AdoGetField(FlPartij, "#vs01 #")), 4, 10)
'			TxtTekst(5).Text = AdoGetField(FlPartij, "#A125 #")
'			TxtTekst(12).Text = AdoGetField(FlPartij, "#A127 #")
'			If KontaktPersoon = 1 Then
'				If Val(AdoGetField(FlPartij, "#vs01 #")) = 0 Then
'					TxtTekst(4).Text = ""
'				End If
'			Else
'				TxtTekst(4).Text = ""
'				TxtTekst(12).Text = ""
'			End If
'			TxtTekst(6).Text = AdoGetField(FlPartij, "#A104 #")
'			TxtTekst(7).Text = AdoGetField(FlPartij, "#A105 #")
'			TxtTekst(8).Text = AdoGetField(FlPartij, "#A106 #")
'			TxtTekst(9).Text = AdoGetField(FlPartij, "#A109 #")
'			TxtTekst(10).Text = AdoGetField(FlPartij, "#A107 #")
'			TxtTekst(11).Text = AdoGetField(FlPartij, "#A108 #")
'			TxtTekst(1).Focus()
'			ReedsBestaand = False
'		End If

'	End Sub

'	Private Sub pdfDrukAf()
'		Dim positieCRLF As Short
'		Dim tSip As Short
'		Dim DDEFlag As Short
'		Dim Printer As New Printer
'		Dim X As Short
'		Dim T As Short
'		Dim BetreftTXT As String
'		Dim AanspreekTitel As String
'		Dim Tekst As String
'		Dim TabIs As Short
'		Dim Pagina As Short
'		Dim rSip(5) As String
'		Dim Taal As String
'		Dim TabBold As Single
'		Dim XX As Short

'		Cursor = System.Windows.Forms.Cursors.WaitCursor
'		Mim.Enabled = False
'		'UPGRADE_ISSUE: DoEvents does not return a value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8D115264-E27F-4472-A684-865A00B5E826"'
'		XDoEvents = System.Windows.Forms.Application.DoEvents()
'		Select Case Briefwisseling(0).Checked
'			Case True
'				JetGet(FlPartij, 0, SetSpacing(VanTot(2).Text, 12))
'				If Ktrl Then
'					MsgBox("Partij '" & Trim(VanTot(2).Text) & "' niet gevonden.  Gelieve klant of leveranciers nogmaals te SELECTeren en opnieuw proberen afdrukken a.u.b.")
'				Else
'					RecordToField(FlPartij)
'					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'					GoSub PrintHetPDFdokument
'				End If
'			Case False
'				JetGetOrGreater(FlPartij, (Sortering.SelectedIndex), SetSpacing(VanTot(0).Text, FlIndexLen(FlPartij, Sortering.SelectedIndex)))
'				If Ktrl Or KeyBuf(FlPartij) > SetSpacing(VanTot(1).Text, FlIndexLen(FlPartij, Sortering.SelectedIndex)) Then
'				Else
'					RecordToField(FlPartij)
'					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'					GoSub PrintHetPDFdokument
'					Do 
'						bNext(FlPartij)
'						If Ktrl Or KeyBuf(FlPartij) > SetSpacing(VanTot(1).Text, FlIndexLen(FlPartij, Sortering.SelectedIndex)) Then
'							Exit Do
'						Else
'							RecordToField(FlPartij)
'							'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'							GoSub PrintHetPDFdokument
'						End If
'					Loop 
'				End If
'			Case Else
'				MsgBox("Partij '" & Trim(VanTot(2).Text) & "' niet gevonden.  Gelieve klant of leveranciers nogmaals te SELECTeren en opnieuw proberen afdrukken a.u.b.")
'		End Select

'		Printer.EndDoc()
'		Mim.Enabled = True
'		Cursor = System.Windows.Forms.Cursors.Default
'		Exit Sub

'PrintHetPDFdokument: 
'		Tekst = txtTekst0.Text
'		TabIs = 10
'		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'		GoSub KopBalk
'		If DDEFlag <> 1 Then
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub DetailLijnen
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub OnderKant
'			Printer.NewPage()
'		End If
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'KopBalk: 
'		Pagina = Pagina + 1
'		Taal = AdoGetField(FlPartij, "#A10C #")
'		TxtTekst(2).Text = Mid(fmarBoxText("003", Taal, AdoGetField(FlPartij, "#A102 #")), 4, 10)
'		TxtTekst(3).Text = AdoGetField(FlPartij, "#A100 #")
'		TxtTekst(0).Text = AdoGetField(FlPartij, "#A101 #")
'		If Val(AdoGetField(FlPartij, "#A102 #")) = 0 Then
'			rSip(0) = TxtTekst(3).Text
'			TxtTekst(2).Text = ""
'		Else
'			rSip(0) = Trim(TxtTekst(2).Text) & " " & Trim(TxtTekst(3).Text) & " " & Trim(TxtTekst(0).Text)
'		End If
'		TxtTekst(4).Text = Mid(fmarBoxText("003", Taal, AdoGetField(FlPartij, "#vs01 #")), 4, 10)
'		TxtTekst(5).Text = AdoGetField(FlPartij, "#A125 #")
'		TxtTekst(12).Text = AdoGetField(FlPartij, "#A127 #")
'		If KontaktPersoon = 1 Then
'			If Val(AdoGetField(FlPartij, "#vs01 #")) = 0 Then
'				rSip(1) = TxtTekst(5).Text
'				TxtTekst(4).Text = ""
'			Else
'				rSip(1) = Trim(TxtTekst(4).Text) & " " & Trim(TxtTekst(5).Text) & " " & Trim(TxtTekst(12).Text)
'			End If
'		Else
'			rSip(1) = ""
'			TxtTekst(4).Text = ""
'			TxtTekst(5).Text = ""
'		End If
'		TxtTekst(6).Text = AdoGetField(FlPartij, "#A104 #")
'		TxtTekst(7).Text = AdoGetField(FlPartij, "#A105 #")
'		TxtTekst(8).Text = AdoGetField(FlPartij, "#A106 #")
'		rSip(2) = Trim(TxtTekst(6).Text) & " " & Trim(TxtTekst(7).Text) & " " & Trim(TxtTekst(8).Text)

'		TxtTekst(9).Text = AdoGetField(FlPartij, "#A109 #")
'		TxtTekst(10).Text = AdoGetField(FlPartij, "#A107 #")
'		TxtTekst(11).Text = AdoGetField(FlPartij, "#A108 #")
'		rSip(4) = TxtTekst(9).Text & " " & TxtTekst(10).Text & " " & TxtTekst(11).Text

'		PrintUserDef("1" & Taal & "4")
'		Printer.CurrentX = BeginXbox + 350
'		Printer.CurrentY = BeginYbox + 350
'		Printer.FontSize = 10
'		Printer.FontBold = True
'		For tSip = 0 To 4
'			Printer.Write(UCase(rSip(tSip)) & vbCrLf)
'			Printer.CurrentX = BeginXbox + 350
'		Next 

'		Printer.CurrentY = Val(VsoftVanaf)
'		Printer.CurrentX = 0
'		Printer.FontSize = 10
'		Printer.FontBold = False

'		Printer.Print(TAB(TabIs))
'		TabBold = Printer.CurrentX

'		If lblOorsprong.Text = "" Then
'			Printer.Write(TAB(60), VB6.Format(Now, "DDDD dd mmmm yyyy hh:mm") & vbCrLf & vbCrLf)
'		Else
'			Printer.Write(TAB(60), VB6.Format(Now, "DDDD dd mmmm yyyy hh:mm") & vbCrLf)
'			Printer.Write(TAB(60), "(kopij van " & lblOorsprong.Text & ")" & vbCrLf)
'		End If
'		Printer.Write(vbCrLf)

'		On Error Resume Next
'		Printer.FontName = txtTekst0.Font.Name

'		On Error GoTo 0

'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		If AutoBetreft.CheckState = False Then Return 

'		Select Case Partij(0).Checked
'			Case True
'				Select Case Taal
'					Case "1"
'						BetreftTXT = "Concerne : "
'						If AdoGetField(FlPartij, "#A125 #") = "" Then
'							AanspreekTitel = "Cher Cliènt,"
'						Else
'							AanspreekTitel = "Cher Cliènts,"
'						End If
'					Case Else
'						BetreftTXT = "Betreft  : "
'						If AdoGetField(FlPartij, "#A125 #") = "" Then
'							AanspreekTitel = "Beste Klant,"
'						Else
'							AanspreekTitel = "Beste Klanten,"
'						End If
'				End Select
'				Printer.Write(TAB(TabIs), AanspreekTitel & vbCrLf & vbCrLf)
'			Case Else
'				Printer.Write(vbCrLf & vbCrLf)
'		End Select

'		Printer.FontBold = True
'		'Printer.CurrentX = TabBold
'		Printer.Write(TAB(TabIs), BetreftTXT & TxtTekst(1).Text & vbCrLf & vbCrLf)
'		'If Printer.DeviceName = "Fax" Then
'		Printer.FontBold = True
'		'Else
'		'    Printer.FontBold = False
'		'End If
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'DetailLijnen: 
'		Do While Tekst <> ""
'			positieCRLF = InStr(Tekst, vbCrLf)
'			If positieCRLF Then
'				Printer.Write(TAB(TabIs), VB.Left(Tekst, positieCRLF - 1) & vbCrLf)
'				Tekst = VB.Right(Tekst, Len(Tekst) - positieCRLF - 1)
'			Else
'				Printer.Write(TAB(TabIs), Tekst & vbCrLf)
'				Tekst = ""
'			End If
'			If Printer.CurrentY >= Val(VsoftTot) - 100 Then
'				Printer.CurrentY = Val(VsoftTot)
'				Printer.Write(vbCrLf, TAB(TabIs + 60), ".../..." & vbCrLf)
'				Printer.NewPage()
'				Printer.CurrentY = 600
'				'goSub KopBalk
'			End If
'		Loop 
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'OnderKant: 
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'PrintHandler: 
'		MsgBox("Stopkode extern toestel." & vbCrLf & vbCrLf & "Kontroleer, of rapporteer aan R&&Vsoft.", 0, "Onverwachte situatie")
'		Resume 

'FileHandler: 
'		MsgBox("Onverwachte fout bij openen briefhoofdbestand." & vbCrLf & vbCrLf & "Stopkode : " & VB6.Format(Err.Number) & vbCrLf & vbCrLf & "Rapporteer aan R&&Vsoft en/of kontroleer uw setup.")
'		Ktrl = 100
'		Exit Sub

'	End Sub


'	Private Sub DrukAf()
'		Dim positieCRLF As Short
'		Dim tSip As Short
'		Dim DDEFlag As Short
'		Dim Printer As New Printer
'		Dim X As Short
'		Dim T As Short
'		Dim BetreftTXT As String
'		Dim AanspreekTitel As String
'		Dim Tekst As String
'		Dim TabIs As Short
'		Dim Pagina As Short
'		Dim rSip(5) As String
'		Dim Taal As String
'		Dim TabBold As Single
'		Dim XX As Short

'		If DDEFlag <> 1 Then
'			Printer = Printers(dokumentPrinterNr)
'			On Error Resume Next
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Printer.PaperBin = LaadTekst(My.Application.Info.Title, "dokumentPRINTER")
'			If Printer.Orientation = PrinterObjectConstants.vbPRORLandscape Then
'				Printer.Orientation = PrinterObjectConstants.vbPRORPortrait
'				System.Windows.Forms.Application.DoEvents()
'			End If
'		End If

'		Cursor = System.Windows.Forms.Cursors.WaitCursor
'		Mim.Enabled = False
'		'UPGRADE_ISSUE: DoEvents does not return a value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8D115264-E27F-4472-A684-865A00B5E826"'
'		XDoEvents = System.Windows.Forms.Application.DoEvents()
'		Select Case Briefwisseling(0).Checked
'			Case True
'				JetGet(FlPartij, 0, SetSpacing(VanTot(2).Text, 12))
'				If Ktrl Then
'					MsgBox("Partij '" & Trim(VanTot(2).Text) & "' niet gevonden.  Gelieve klant of leveranciers nogmaals te SELECTeren en opnieuw proberen afdrukken a.u.b.")
'				Else
'					RecordToField(FlPartij)
'					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'					GoSub PrintHetdokument
'				End If
'			Case False
'				JetGetOrGreater(FlPartij, (Sortering.SelectedIndex), SetSpacing(VanTot(0).Text, FlIndexLen(FlPartij, Sortering.SelectedIndex)))
'				If Ktrl Or KeyBuf(FlPartij) > SetSpacing(VanTot(1).Text, FlIndexLen(FlPartij, Sortering.SelectedIndex)) Then
'				Else
'					RecordToField(FlPartij)
'					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'					GoSub PrintHetdokument
'					Do 
'						bNext(FlPartij)
'						If Ktrl Or KeyBuf(FlPartij) > SetSpacing(VanTot(1).Text, FlIndexLen(FlPartij, Sortering.SelectedIndex)) Then
'							Exit Do
'						Else
'							RecordToField(FlPartij)
'							'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'							GoSub PrintHetdokument
'						End If
'					Loop 
'				End If
'			Case Else
'				MsgBox("Partij '" & Trim(VanTot(2).Text) & "' niet gevonden.  Gelieve klant of leveranciers nogmaals te SELECTeren en opnieuw proberen afdrukken a.u.b.")
'		End Select
'		Printer.EndDoc()
'		Mim.Enabled = True
'		Cursor = System.Windows.Forms.Cursors.Default
'		Exit Sub

'PrintHetdokument: 
'		Tekst = txtTekst0.Text
'		TabIs = 10
'		'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'		GoSub KopBalk
'		If DDEFlag <> 1 Then
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub DetailLijnen
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub OnderKant
'			Printer.NewPage()
'		End If
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'KopBalk: 
'		Pagina = Pagina + 1
'		Taal = AdoGetField(FlPartij, "#A10C #")
'		TxtTekst(2).Text = Mid(fmarBoxText("003", Taal, AdoGetField(FlPartij, "#A102 #")), 4, 10)
'		TxtTekst(3).Text = AdoGetField(FlPartij, "#A100 #")
'		TxtTekst(0).Text = AdoGetField(FlPartij, "#A101 #")
'		If Val(AdoGetField(FlPartij, "#A102 #")) = 0 Then
'			rSip(0) = TxtTekst(3).Text
'			TxtTekst(2).Text = ""
'		Else
'			rSip(0) = Trim(TxtTekst(2).Text) & " " & Trim(TxtTekst(3).Text) & " " & Trim(TxtTekst(0).Text)
'		End If
'		TxtTekst(4).Text = Mid(fmarBoxText("003", Taal, AdoGetField(FlPartij, "#vs01 #")), 4, 10)
'		TxtTekst(5).Text = AdoGetField(FlPartij, "#A125 #")
'		TxtTekst(12).Text = AdoGetField(FlPartij, "#A127 #")
'		If KontaktPersoon = 1 Then
'			If Val(AdoGetField(FlPartij, "#vs01 #")) = 0 Then
'				rSip(1) = TxtTekst(5).Text
'				TxtTekst(4).Text = ""
'			Else
'				rSip(1) = Trim(TxtTekst(4).Text) & " " & Trim(TxtTekst(5).Text) & " " & Trim(TxtTekst(12).Text)
'			End If
'		Else
'			rSip(1) = ""
'			TxtTekst(4).Text = ""
'			TxtTekst(5).Text = ""
'		End If
'		TxtTekst(6).Text = AdoGetField(FlPartij, "#A104 #")
'		TxtTekst(7).Text = AdoGetField(FlPartij, "#A105 #")
'		TxtTekst(8).Text = AdoGetField(FlPartij, "#A106 #")
'		rSip(2) = Trim(TxtTekst(6).Text) & " " & Trim(TxtTekst(7).Text) & " " & Trim(TxtTekst(8).Text)

'		TxtTekst(9).Text = AdoGetField(FlPartij, "#A109 #")
'		TxtTekst(10).Text = AdoGetField(FlPartij, "#A107 #")
'		TxtTekst(11).Text = AdoGetField(FlPartij, "#A108 #")
'		rSip(4) = TxtTekst(9).Text & " " & TxtTekst(10).Text & " " & TxtTekst(11).Text

'		PrintUserDef("1" & Taal & "4")
'		Printer.CurrentX = BeginXbox + 350
'		Printer.CurrentY = BeginYbox + 350
'		Printer.FontSize = 10
'		Printer.FontBold = True
'		For tSip = 0 To 4
'			Printer.Write(UCase(rSip(tSip)) & vbCrLf)
'			Printer.CurrentX = BeginXbox + 350
'		Next 

'		Printer.CurrentY = Val(VsoftVanaf)
'		Printer.CurrentX = 0
'		Printer.FontSize = 10
'		Printer.FontBold = False

'		Printer.Print(TAB(TabIs))
'		TabBold = Printer.CurrentX

'		If lblOorsprong.Text = "" Then
'			Printer.Write(TAB(60), VB6.Format(Now, "DDDD dd mmmm yyyy hh:mm") & vbCrLf & vbCrLf)
'		Else
'			Printer.Write(TAB(60), VB6.Format(Now, "DDDD dd mmmm yyyy hh:mm") & vbCrLf)
'			Printer.Write(TAB(60), "(kopij van " & lblOorsprong.Text & ")" & vbCrLf)
'		End If
'		Printer.Write(vbCrLf)

'		On Error Resume Next
'		Printer.FontName = txtTekst0.Font.Name

'		On Error GoTo 0

'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		If AutoBetreft.CheckState = False Then Return 

'		Select Case Partij(0).Checked
'			Case True
'				Select Case Taal
'					Case "1"
'						BetreftTXT = "Concerne : "
'						If AdoGetField(FlPartij, "#A125 #") = "" Then
'							AanspreekTitel = "Cher Cliènt,"
'						Else
'							AanspreekTitel = "Cher Cliènts,"
'						End If
'					Case Else
'						BetreftTXT = "Betreft  : "
'						If AdoGetField(FlPartij, "#A125 #") = "" Then
'							AanspreekTitel = "Beste Klant,"
'						Else
'							AanspreekTitel = "Beste Klanten,"
'						End If
'				End Select
'				Printer.Write(TAB(TabIs), AanspreekTitel & vbCrLf & vbCrLf)
'			Case Else
'				On Error Resume Next
'				Printer.Write(vbCrLf & vbCrLf)
'		End Select

'		Printer.FontBold = True
'		'Printer.CurrentX = TabBold
'		Printer.Write(TAB(TabIs), BetreftTXT & TxtTekst(1).Text & vbCrLf & vbCrLf)
'		'If Printer.DeviceName = "Fax" Then
'		Printer.FontBold = True
'		'Else
'		'    Printer.FontBold = False
'		'End If
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'DetailLijnen: 
'		If InStr(Tekst, "@<") Then
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub InsertVars
'		End If

'		Do While Tekst <> ""
'			positieCRLF = InStr(Tekst, vbCrLf)
'			If positieCRLF Then
'				Printer.Write(TAB(TabIs), VB.Left(Tekst, positieCRLF - 1) & vbCrLf)
'				Tekst = VB.Right(Tekst, Len(Tekst) - positieCRLF - 1)
'			Else
'				Printer.Write(TAB(TabIs), Tekst & vbCrLf)
'				Tekst = ""
'			End If
'			If Printer.CurrentY >= Val(VsoftTot) - 100 Then
'				Printer.CurrentY = Val(VsoftTot)
'				Printer.Write(vbCrLf, TAB(TabIs + 60), ".../..." & vbCrLf)
'				Printer.NewPage()
'				Printer.CurrentY = 600
'				'goSub KopBalk
'			End If
'		Loop 
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'InsertVars: 
'		Dim pVARbegin As Short
'		Dim pVARend As Short
'		Dim pVARcode As String
'		Dim pVARhier As String

'		Do While InStr(Tekst, "@<")
'			pVARbegin = InStr(Tekst, "@<")
'			pVARend = InStr(Tekst, ">@")
'			'checken of het ongeveer klopt
'			If pVARend - pVARbegin <> 7 Then
'				MsgBox("Onlogische variabelpositie ter hoogte: " & Mid(Tekst, pVARbegin))
'				Exit Do
'			Else
'				'ok
'				pVARcode = Mid(Tekst, pVARbegin, 9)
'				On Error Resume Next
'				Err.Clear()
'				'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
'				If IsDbNull(rsMAR(FlPartij).Fields(Trim(Mid(pVARcode, 3, 5))).Value) Then
'					pVARhier = ""
'					If Err.Number Then
'						MsgBox(Err.Description & vbCrLf & vbCrLf & Mid(pVARcode, 3, 5))
'					End If
'				Else
'					pVARhier = rsMAR(FlPartij).Fields(Trim(Mid(pVARcode, 3, 5))).Value
'				End If
'				Tekst = Replace(Tekst, pVARcode, pVARhier)
'			End If
'		Loop 
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 


'OnderKant: 
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'PrintHandler: 
'		MsgBox("Stopkode extern toestel." & vbCrLf & vbCrLf & "Kontroleer, of rapporteer aan R&&Vsoft.", 0, "Onverwachte situatie")
'		Resume 

'FileHandler: 
'		MsgBox("Onverwachte fout bij openen briefhoofdbestand." & vbCrLf & vbCrLf & "Stopkode : " & VB6.Format(Err.Number) & vbCrLf & vbCrLf & "Rapporteer aan R&&Vsoft en/of kontroleer uw setup.")
'		Ktrl = 100
'		Exit Sub

'	End Sub



'	' Copy a BLOB field's contents to a binary file.
'	Function BlobToFile(ByRef fld As ADODB.Field, ByRef filename As String, Optional ByRef ChunkSize As Integer = 8192) As Short
'		Dim fnum As Short
'		Dim bytesLeft, bytes As Integer
'		Dim tmp() As Byte

'		' Raise an error if the field doesn't support GetChunk.
'		If (fld.Attributes And ADODB.FieldAttributeEnum.adFldLong) = 0 Then
'			Err.Raise(1001,  , "Field doesn't support the GetChunk method.")
'		End If
'		' Open the file;, delete it firstoverwrite it if necessary.' Delete the
'		' file if it exists already, then create a new one.
'		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		If Dir(filename) <> "" Then Kill(filename)

'		fnum = FreeFile
'		FileOpen(fnum, filename, OpenMode.Binary)
'		' Read the field's contents, and write it the data to the file.
'		bytesLeft = fld.ActualSize

'		Do While bytesLeft
'			bytes = bytesLeft
'			If bytes > ChunkSize Then bytes = ChunkSize
'			'UPGRADE_WARNING: Couldn't resolve default property of object fld.GetChunk(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			tmp = fld.GetChunk(bytes)
'			'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			FilePut(fnum, tmp)
'			bytesLeft = bytesLeft - bytes
'		Loop 
'		FileClose(fnum)

'	End Function


'	' Copy a file's contents into a BLOB field.
'	Function FileToBlob(ByRef fld As ADODB.Field, ByRef filename As String, Optional ByRef ChunkSize As Integer = 8192) As Short
'		Dim fnum As Short
'		Dim bytesLeft, bytes As Integer
'		Dim tmp() As Byte

'		' Raise an error if the field doesn't support GetChunk.
'		If (fld.Attributes And ADODB.FieldAttributeEnum.adFldLong) = 0 Then
'			Err.Raise(1001,  , "Field doesn't support the GetChunk method.")
'		End If
'		' Open the file; raise an error if the file doesn't exist.
'		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		If Dir(filename) = "" Then Err.Raise(53,  , "File not found")

'		fnum = FreeFile
'		FileOpen(fnum, filename, OpenMode.Binary)
'		' Read the file in chunks, and append data to the field.
'		bytesLeft = LOF(fnum)
'		Do While bytesLeft
'			bytes = bytesLeft
'			If bytes > ChunkSize Then bytes = ChunkSize
'			'UPGRADE_WARNING: Lower bound of array tmp was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
'			ReDim tmp(bytes)
'			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			FileGet(1, tmp)
'			fld.AppendChunk(tmp)
'			bytesLeft = bytesLeft - bytes
'		Loop 

'		FileClose(fnum)

'	End Function
'End Class