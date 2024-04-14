Option Strict Off
Option Explicit On
Imports System.ComponentModel

Public Class frmAankoopVerrichtingen
    Private Sub frmAankoopVerrichtingen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = 0
        Left = 0
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        If lbAankoopDetail.Items.Count Then
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

    Private Sub frmAankoopVerrichtingen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Mim.PurchaseTransactionMenuItem.Enabled = True

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class DirekteAankoop
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Dim AankoopDetailTitel(8) As String
'	Dim lvLeverancier As String
'	Dim GeScanBestand As String


'	Dim dokumentSleutel As New VB6.FixedLengthString(11)
'	Dim PriveRekening As New VB6.FixedLengthString(7)
'	Dim LeverancierRekening As New VB6.FixedLengthString(7)
'	'UPGRADE_ISSUE: Declaration type not supported: Array of fixed-length strings. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="934BD4FF-1FF9-47BD-888F-D411E47E78FA"'
'	Dim GrensDetail(3) As String*14

'	Dim AankoopFlg As Short
'	'UPGRADE_ISSUE: Declaration type not supported: Array of fixed-length strings. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="934BD4FF-1FF9-47BD-888F-D411E47E78FA"'
'	Dim rbtwVAK(10) As String*7
'	Dim sMuntLever As New VB6.FixedLengthString(3)
'	Dim sIsIntraFlg As New VB6.FixedLengthString(1)

'	Dim StartBlad As Boolean

'	Dim Ar As Short

'	Dim VeldRekening As New VB6.FixedLengthString(7)
'	Dim VeldNaam As New VB6.FixedLengthString(40)
'	Dim VeldBedrag As New VB6.FixedLengthString(10)

'	Private Sub Aankoopdetail_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aankoopdetail.DoubleClick

'		If AankoopDetail.SelectedIndex = -1 Then
'			AankoopDetail_KeyPress(AankoopDetail, New System.Windows.Forms.KeyPressEventArgs(Chr(43)))
'		Else
'			AankoopDetail_KeyPress(AankoopDetail, New System.Windows.Forms.KeyPressEventArgs(Chr(13)))
'		End If

'	End Sub

'	Private Sub AankoopDetail_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AankoopDetail.Enter

'		SnelHelpPrint("[Insert] lijn bijvoegen, [Delete] lijn verwijderen, [spatie],[Enter] om te wijzigen", BL_LOGGING)
'		If AankoopDetail.Items.Count Then
'			AankoopDetail.SelectedIndex = AankoopDetail.Items.Count - 1
'		End If
'		VB6.SetDefault(Kontrole, False)

'	End Sub

'	Private Sub AankoopDetail_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles AankoopDetail.KeyDown
'		Dim KeyCode As Short = eventArgs.KeyCode
'		Dim Shift As Short = eventArgs.KeyData \ &H10000
'		Dim Positie As Short
'		Dim X As Short

'		Positie = AankoopDetail.SelectedIndex
'		Select Case KeyCode
'			Case 45, 107
'				GRIDTEXT = ""
'				Wijzigen.ShowDialog()
'				If GRIDTEXT = "" Then
'				Else
'					If RekeningOK(VB.Left(GRIDTEXT, 7)) Then
'						AankoopDetail.Items.Insert(Positie + 1, GRIDTEXT)
'						X = InvestKtrl()
'					End If
'				End If
'			Case 46
'				If Positie < 0 Then
'					MsgBox("Eerst een lijn selekteren !", 0, "Line wijzigen")
'					Exit Sub
'				End If
'				MSG = "Line verwijderen !  Bent U zeker ?"
'				KTRL = MsgBox(MSG, 292)
'				If KTRL = 6 Then
'					AankoopDetail.Items.RemoveAt(Positie)
'				End If
'		End Select
'		Me.AankoopDetail.Focus()

'	End Sub

'	Private Sub AankoopDetail_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles AankoopDetail.KeyPress
'		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
'		Dim Positie As Short
'		Dim X As Short

'		On Error Resume Next
'		Positie = AankoopDetail.SelectedIndex
'		Select Case KeyAscii
'			Case 13
'				If Positie < 0 Then
'					MsgBox("Eerst een lijn selekteren !", 0, "Line wijzigen")
'					GoTo EventExitSub
'				End If
'				GRIDTEXT = AankoopDetail.Text
'				Wijzigen.ShowDialog()
'				If GRIDTEXT = "" Then
'				Else
'					If RekeningOK(VB.Left(GRIDTEXT, 7)) Then
'						AankoopDetail.Items.RemoveAt(Positie)
'						AankoopDetail.Items.Insert(Positie, GRIDTEXT)
'						X = InvestKtrl()
'					End If
'				End If
'		End Select
'		Me.AankoopDetail.Focus()

'EventExitSub: 
'		eventArgs.KeyChar = Chr(KeyAscii)
'		If KeyAscii = 0 Then
'			eventArgs.Handled = True
'		End If
'	End Sub


'	'UPGRADE_WARNING: Event AankoopOptie.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub AankoopOptie_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AankoopOptie.CheckedChanged
'		If eventSender.Checked Then
'			Dim Index As Short = AankoopOptie.GetIndex(eventSender)

'Jumper: 
'			Select Case Index
'				Case 0
'					Ar = 1
'					dokumentSleutel.Value = SleutelDok(Ar)

'				Case 1
'					Ar = 3
'					dokumentSleutel.Value = SleutelDok(Ar)

'				Case 2
'					'MsgBox Now & " beschikbaar eerstvolgende versie(s) (ijdele hoop...  EURO gaat voor!)", vbInformation
'					AankoopOptie(0).Checked = True
'			End Select
'			Me.Text = "Ctrl+F1 Direkte aankoopverrichting (" & dokumentSleutel.Value & ")"
'			JetGet(TABLE_INVOICES, 0, dokumentSleutel.Value)
'			If KTRL = 0 Then
'				MsgBox("Document " & dokumentSleutel.Value & " is reeds aanwezig..." & vbCr & vbCr & "Controleer eventueel uw tellerbestand voor het active boekjaar.  Indien U zopas wisselde van boekjaar met het aankoopvenster open, mag U (na controle) deze melding negeren..." & vbCr & vbCr & "NIET BOEKJAAR GEWISSELD ZOPAS ?  EERST UW TELLEBESTAND + PROEF- SALDI BALANS CONTROLEREN !!!", MsgBoxStyle.Exclamation)
'			End If

'		End If
'	End Sub

'	Private Sub Afsluiten_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Afsluiten.Click
'		Dim A As String
'		Dim aa As New VB6.FixedLengthString(30)
'		Dim dTTwb As Double
'		Dim DummySleutel As String

'		If AankoopDetail.Items.Count = 0 Then Exit Sub
'		If BH_EURO And cmdSwitch.Text = "Ingave in EUR" Then
'			'ok VOOR EUR boekhouding
'		ElseIf Not BH_EURO And cmdSwitch.Text = "Ingave in BEF" Then 
'			'ok VOOR BEF boekhouding
'		Else
'			MsgBox("Uw boekjaar draait in de andere munt.  De Toggle is er enkel informatief.  Eerst de Toggle terugplaatsen op munt van de boekhouding a.u.b.", MsgBoxStyle.Information)
'			Exit Sub
'		End If

'		If Not DatumKtrl(TekstInfo(0).Text, PERIODAS_TEXT) Then
'			Beep()
'			On Error Resume Next
'			TekstInfo(0).Focus()
'			Exit Sub
'		End If

'		If dokumentSleutel.Value <> SleutelDok(Ar) Then
'			MSG = dokumentSleutel.Value & " <> " & SleutelDok(Ar) & vbCrLf & vbCrLf
'			MSG = MSG & "MOGELIJKHEID 1: Teller is identiek, boekjaar is hoger/lager." & vbCrLf
'			MSG = MSG & "U hebt dus het actief boekjaar of periode gewijzigd tijdens de aanmaak van dit dokument.  Probeer nogmaals NA KONTROLE." & vbCrLf & vbCrLf
'			MSG = MSG & "MOGELIJKHEID 2: Boekjaar is identiek, teller is hoger/lager." & vbCrLf
'			MSG = MSG & "Een andere gebruiker heeft ondertussen een dokument verwerkt." & vbCrLf & vbCrLf
'			MSG = MSG & "Kontroleer eerst eens vooraleer de boeking nogmaals uit te voeren a.u.b. !!!"
'			MsgBox(MSG)
'			dokumentSleutel.Value = SleutelDok(Ar)
'			Me.Text = "Ctrl+F1 Direkte aankoopverrichting (" & dokumentSleutel.Value & ")"
'			Exit Sub
'		End If

'		MSG = "Document wegschrijven, boekhouding bijwerken."
'		KTRL = MsgBox(MSG, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, dokumentSleutel.Value & " verwerken.")
'		Select Case KTRL
'			Case 7
'				Exit Sub
'		End Select

'		KTRL = JetTableOpen(TABLE_LEDGERACCOUNTS)
'		KTRL = JetTableOpen(TABLE_JOURNAL)
'		KTRL = JetTableOpen(TABLE_INVOICES)
'		TransBegin()
'		If WegBoekFout() Then
'			TransAbort()
'			Me.Activate()
'			Exit Sub
'		Else
'			TransCommit()
'			If KTRL Then
'				TransAbort()
'				Exit Sub
'			End If
'			If AankoopFlg = 1 And sIsIntraFlg.Value = "1" Then
'				FL = TABLE_SUPPLIERS
'				A_INDEX = 19
'				dTTwb = Val(AdoGetField(TABLE_INVOICES, "#v048 #")) + Val(AdoGetField(TABLE_INVOICES, "#v047 #")) + Val(AdoGetField(TABLE_INVOICES, "#v046 #")) + Val(AdoGetField(TABLE_INVOICES, "#v049 #"))
'				GRIDTEXT = Dec(dTTwb, MASK_SY(0)) & vbTab
'				Intrastat.ShowDialog()
'			End If
'			SS99(VB.Right(dokumentSleutel.Value, 5), Ar) 's001 of s003
'			dokumentSleutel.Value = SleutelDok(Ar)
'			Me.Text = "Ctrl+F1 Direkte aankoopverrichting (" & dokumentSleutel.Value & ")"
'			SchoonVegen_Click(SchoonVegen, New System.EventArgs())
'			SSTab1.Focus()
'		End If

'	End Sub

'	Private Sub Afsluiten_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Afsluiten.Leave

'		Kontrole.Visible = True
'		Afsluiten.Visible = False

'	End Sub

'	Private Sub Annuleren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Annuleren.Click

'		If AankoopDetail.Items.Count = 0 Then
'		Else
'			MSG = "Aanwezige bewerkingen negeren !  Bent U zeker ?"
'			KTRL = MsgBox(MSG, 292, "Aankoopverrichtingen sluiten")
'			If KTRL <> 6 Then
'				Exit Sub
'			End If
'		End If
'		Me.Close()

'	End Sub


'	Private Sub cbAfbeelding_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbAfbeelding.Click

'		Dim FlHier As Short
'		Dim BestandHier As String

'		'Dim miDoc As MODIctl.Document
'		'Set miDoc = New MODIctl.Document

'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(dnnInstellingen, PostvakIO). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		If LaadTekst("dnnInstellingen", "PostvakIO") = "" Then
'			MsgBox("Nieuwe PC of nog geen instellingen voor PDF Postvak In.  Aanbevolen in te te stellen a.u.b. via submenu DotNetNuke.", MsgBoxStyle.Information)
'			Mim.TekenOpen.InitialDirectory = LOCATION_COMPANYDATA
'		Else
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(dnnInstellingen, PostvakIO). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Mim.TekenOpen.InitialDirectory = LaadTekst("dnnInstellingen", "PostvakIO")
'		End If
'		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Mim.TekenOpen.Filter = "Acrobat bestanden (*.pdf)|*.pdf"
'		Mim.TekenOpen.FileName = ""
'		Mim.TekenOpen.ShowDialog()
'		BestandHier = LCase(Mim.TekenOpen.FileName)
'		If BestandHier = "" Then
'			Exit Sub
'		Else
'			If VB.Right(BestandHier, 3) <> "pdf" Then
'				MsgBox("Enkel *.pdf bestanden zijn toegelaten", MsgBoxStyle.Exclamation)
'				Exit Sub
'			End If
'		End If
'		GeScanBestand = Mim.TekenOpen.FileName
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'		On Error Resume Next
'		'UPGRADE_ISSUE: Ole method OLE1.CreateEmbed was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
'		OLE1.CreateEmbed(GeScanBestand)
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal

'	End Sub


'	'UPGRADE_WARNING: Event cbBank.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub cbBank_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbBank.CheckStateChanged

'		Select Case cbBank.CheckState
'			Case System.Windows.Forms.CheckState.Checked
'				TekstInfo(11).Enabled = True
'				TekstInfo(11).Focus()

'			Case Else
'				TekstInfo(11).Enabled = False

'		End Select

'	End Sub

'	Private Sub cbUpdateLeverancier_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbUpdateLeverancier.Click

'		If Len(TekstInfo(11).Text) <> 14 Then
'			MsgBox("LogicaStop lengte rekeningnummer")
'		Else
'			'controle of de leverancier (nog) actief is en daarna wegschrijven
'			JetGet(TABLE_SUPPLIERS, 0, VB.Left(LeverancierInfo.Text, 12))
'			If KTRL Then
'				MsgBox("LogicaStop zoeken leveranciersfiche")
'			Else
'				RecordToField(TABLE_SUPPLIERS)
'				AdoInsertToRecord(TABLE_SUPPLIERS, TekstInfo(11).Text, "A170")
'				bUpdate(TABLE_SUPPLIERS, 0)
'				If KTRL Then
'					MsgBox("Onverwacht situatie")
'				Else
'					Me.cbBank.CheckState = System.Windows.Forms.CheckState.Unchecked
'					Me.cbUpdateLeverancier.Visible = False
'				End If
'			End If
'		End If

'	End Sub

'	Private Sub cmdSQLInfo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSQLInfo.Click

'		JetGet(TABLE_SUPPLIERS, 0, VB.Left(LeverancierInfo.Text, 12))
'		If KTRL Then
'			MsgBox("Onlogica.")
'			cmdSQLInfo.Visible = False
'		Else
'			RecordToField(TABLE_SUPPLIERS)
'			If AdoGetField(TABLE_SUPPLIERS, "#v254 #") <> "" Then
'				CTRL_BOX = SQLPopUp(AdoGetField(TABLE_SUPPLIERS, "#v254 #"), JET_TABLENAME(TABLE_SUPPLIERS), "A110", AdoGetField(TABLE_SUPPLIERS, "#A110 #"))
'			Else
'				cmdSQLInfo.Visible = False
'			End If
'		End If

'	End Sub


'	Private Sub cmdSwitch_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSwitch.Click
'		Dim TempoTel As Short
'		Dim TempoVar As Object

'		If sMuntLever.Value = "BEF" Or sMuntLever.Value = "EUR" Then
'		Else
'			MsgBox("Switch niet mogelijk voor leveranciers buiten de E.U.  en enkel mogelijk indien leverancier met BEF of EUR code", MsgBoxStyle.Information)
'			Exit Sub
'		End If

'		'Stap 1: overschakeling cijfers van BEF naar EUR
'		TekstInfo(5).Text = ""
'		TekstInfo(7).Text = ""
'		TekstInfo(8).Text = ""
'		If cmdSwitch.Text = "Ingave in EUR" Then
'			TekstInfo(6).Text = Dec(Val(TekstInfo(6).Text) * EURO, MASK_SY(0))
'			cmdSwitch.Text = "Ingave in BEF"
'			'Stap 2: de nodige schermopmaak voor BEF
'			If BH_EURO Then
'				'EUR boekhouding
'				D_CURRENCY = 1 / EURO
'				For COUNT_TO = 0 To AankoopDetail.Items.Count - 1
'					'UPGRADE_WARNING: Couldn't resolve default property of object TempoVar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					TempoVar = VB6.GetItemString(AankoopDetail, COUNT_TO)
'					'UPGRADE_WARNING: Couldn't resolve default property of object TempoVar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					Mid(TempoVar, 50, 12) = Dec(System.Math.Round(Val(Mid(TempoVar, 50, 12)) * EURO, 0), MASK_EURBH)
'					'UPGRADE_WARNING: Couldn't resolve default property of object TempoVar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					VB6.SetItemString(AankoopDetail, COUNT_TO, TempoVar)
'				Next 
'			Else
'				'BEF boekhouding
'				D_CURRENCY = 1
'				For COUNT_TO = 0 To AankoopDetail.Items.Count - 1
'					'UPGRADE_WARNING: Couldn't resolve default property of object TempoVar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					TempoVar = VB6.GetItemString(AankoopDetail, COUNT_TO)
'					'UPGRADE_WARNING: Couldn't resolve default property of object TempoVar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					Mid(TempoVar, 50, 12) = Dec(System.Math.Round(Val(Mid(TempoVar, 50, 12)) * EURO, 0), MASK_EURBH)
'					'UPGRADE_WARNING: Couldn't resolve default property of object TempoVar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					VB6.SetItemString(AankoopDetail, COUNT_TO, TempoVar)
'				Next 
'			End If
'		Else
'			TekstInfo(6).Text = Dec(Val(TekstInfo(6).Text) / EURO, MASK_EURBH)
'			cmdSwitch.Text = "Ingave in EUR"
'			'Stap 2: de nodige schermopmaak voor EUR
'			If BH_EURO Then
'				'EUR boekhouding
'				D_CURRENCY = 1
'				For COUNT_TO = 0 To AankoopDetail.Items.Count - 1
'					'UPGRADE_WARNING: Couldn't resolve default property of object TempoVar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					TempoVar = VB6.GetItemString(AankoopDetail, COUNT_TO)
'					'UPGRADE_WARNING: Couldn't resolve default property of object TempoVar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					Mid(TempoVar, 50, 12) = Dec(System.Math.Round(Val(Mid(TempoVar, 50, 12)) / EURO, 2), MASK_EURBH)
'					'UPGRADE_WARNING: Couldn't resolve default property of object TempoVar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					VB6.SetItemString(AankoopDetail, COUNT_TO, TempoVar)
'				Next 
'			Else
'				'BEF boekhouding
'				D_CURRENCY = 1 / EURO
'				For COUNT_TO = 0 To AankoopDetail.Items.Count - 1
'					'UPGRADE_WARNING: Couldn't resolve default property of object TempoVar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					TempoVar = VB6.GetItemString(AankoopDetail, COUNT_TO)
'					'UPGRADE_WARNING: Couldn't resolve default property of object TempoVar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					Mid(TempoVar, 50, 12) = Dec(System.Math.Round(Val(Mid(TempoVar, 50, 12)) / EURO, 2), MASK_EURBH)
'					'UPGRADE_WARNING: Couldn't resolve default property of object TempoVar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					VB6.SetItemString(AankoopDetail, COUNT_TO, TempoVar)
'				Next 
'			End If
'		End If
'		TekstInfo(9).Text = Dec(D_CURRENCY, "##0.########")
'		VernieuwDirecteAankoopEUR()
'		TekstInfo(6).Focus()

'	End Sub

'	Sub VernieuwDirecteAankoopEUR()

'		'    MsgBox "Stop"

'	End Sub





'	Private Sub DirekteAankoop_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

'		If Not Toegankelijk(Me) Then
'			Me.Close()
'			Exit Sub
'		End If

'		'RS_MAR(TABLE_INVOICES).Close
'		KTRL = ktrlBLOBRecord
'		If KTRL = False Then
'			AutoUnloadCompany()
'			Exit Sub
'		End If

'		If BH_EURO Then
'			cmdSwitch.Text = "Ingave in EUR"
'		Else
'			cmdSwitch.Text = "Ingave in BEF"
'		End If

'		Dim Tel As Short

'		' Add ColumnHeaders. The width of the columns is
'		' the width of the control divided by the number of
'		' ColumnHeader objects.
'		ListView1.Columns.Add("", "Naam", CInt(VB6.TwipsToPixelsX(3270)))
'		ListView1.Columns.Add("", "IdCode", CInt(VB6.TwipsToPixelsX(930)))

'		' Set View property to Report.
'		ListView1.View = System.Windows.Forms.View.Details

'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'		Top = 0
'		Left = 0

'		For Tel = 16 To 19
'			rbtwVAK(Tel - 16) = String99(READING, Tel)
'			rbtwVAK(Tel - 12) = String99(READING, Tel + 6)
'		Next 

'		LeverancierRekening.Value = String99(READING, 10)
'		sIsIntraFlg.Value = String99(READING, 200)


'		PriveRekening.Value = String99(READING, 145)

'		GrensDetail(0) = ""
'		FL99_RECORD = String99(READING, 148)
'		Mid(GrensDetail(0), 1, 7) = VB.Left(FL99_RECORD, 7)
'		FL99_RECORD = String99(READING, 149)
'		Mid(GrensDetail(0), 8, 7) = VB.Left(FL99_RECORD, 7)

'		GrensDetail(1) = ""
'		FL99_RECORD = String99(READING, 146)
'		Mid(GrensDetail(1), 1, 7) = VB.Left(FL99_RECORD, 7)
'		FL99_RECORD = String99(READING, 147)
'		Mid(GrensDetail(1), 8, 7) = VB.Left(FL99_RECORD, 7)

'		GrensDetail(2) = ""
'		FL99_RECORD = String99(READING, 150)
'		Mid(GrensDetail(2), 1, 7) = VB.Left(FL99_RECORD, 7)
'		FL99_RECORD = String99(READING, 151)
'		Mid(GrensDetail(2), 8, 7) = VB.Left(FL99_RECORD, 7)

'		GrensDetail(3) = ""
'		FL99_RECORD = String99(READING, 152)
'		Mid(GrensDetail(3), 1, 7) = VB.Left(FL99_RECORD, 7)
'		FL99_RECORD = String99(READING, 153)
'		Mid(GrensDetail(3), 8, 7) = VB.Left(FL99_RECORD, 7)

'		'InstalleerRecenteCrediteuren
'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		MSG = LaadTekst("DirekteAankoop", "startBlad")
'		If MSG = "" Then MSG = "True"
'		StartBlad = CBool(MSG)
'		Schoon()
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal

'	End Sub

'	'UPGRADE_WARNING: Event DirekteAankoop.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub DirekteAankoop_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize

'		AankoopDetail.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Width) - 250)

'	End Sub


'	Private Sub InstalLeverancier()
'		Dim Lever As String
'		Dim T As Short
'		Dim X As Short

'		AankoopDetail.Enabled = True
'		'InvoerLijn.Enabled = True

'		Lever = vbCrLf & AdoGetField(TABLE_SUPPLIERS, "#A100 #") & vbCrLf & AdoGetField(TABLE_SUPPLIERS, "#A125 #") & vbCrLf & AdoGetField(TABLE_SUPPLIERS, "#A104 #") & vbCrLf & AdoGetField(TABLE_SUPPLIERS, "#A109 #") & " " & AdoGetField(TABLE_SUPPLIERS, "#A107 #") & " " & AdoGetField(TABLE_SUPPLIERS, "#A108 #")
'		Schoonvegen.Enabled = True
'		'ReturnRooster.Enabled = True

'		If AdoGetField(TABLE_SUPPLIERS, "#v149 #") = "" Then
'			MsgBox("Landnummer is verplicht !")
'			Exit Sub
'		ElseIf AdoGetField(TABLE_SUPPLIERS, "#v149 #") = "002" Then 
'			LeverancierInfo.Text = SetSpacing(AdoGetField(TABLE_SUPPLIERS, "#A110 #"), 12) & "* Binnenland * " & Lever
'			AankoopFlg = 0
'			Medekontraktant.Enabled = True
'			TekstInfo(7).Visible = False
'			TekstInfo(8).Visible = False
'			TekstInfo(7).Text = TekstInfo(5).Text
'			TekstInfo(8).Text = "0"
'			Label1(12).Visible = False
'			Label1(13).Visible = False
'		ElseIf InStr(SISO, AdoGetField(TABLE_SUPPLIERS, "#v149 #")) Then 
'			LeverancierInfo.Text = SetSpacing(AdoGetField(TABLE_SUPPLIERS, "#A110 #"), 12) & "* E.U. Verschuldigde BTW * " & Lever
'			AankoopFlg = 1
'			Medekontraktant.Enabled = False
'			TekstInfo(7).Visible = True
'			TekstInfo(8).Visible = True
'			TekstInfo(7).Text = "0"
'			TekstInfo(8).Text = "0"
'			Label1(12).Visible = True
'			Label1(13).Visible = True
'		Else
'			LeverancierInfo.Text = SetSpacing(AdoGetField(TABLE_SUPPLIERS, "#A110 #"), 12) & "* Niet E.U. + BTW ! *" & Lever
'			AankoopFlg = 2
'			Medekontraktant.Enabled = False
'			TekstInfo(7).Visible = True
'			TekstInfo(8).Visible = True
'			TekstInfo(7).Text = "0"
'			TekstInfo(8).Text = "0"
'			Label1(12).Visible = True
'			Label1(13).Visible = True
'		End If

'		For T = 0 To 7
'			TekstInfo(T).Enabled = True
'		Next 

'		sMuntLever.Value = UCase(AdoGetField(TABLE_SUPPLIERS, "#vs03 #"))
'		JetGet(TABLE_VARIOUS, 1, SetSpacing("10" & sMuntLever.Value, 20))
'		If KTRL Then
'			MsgBox("Dagkoers voor muntkode " & sMuntLever.Value & " niet te vinden !  Eerst aanmaken via gebruikersfiches a.u.b.")
'			If BH_EURO Then
'				sMuntLever.Value = "EUR"
'			Else
'				sMuntLever.Value = "BEF"
'			End If
'			TekstInfo(9).Text = Dec(1, "###.########")
'		Else
'			RecordToField(TABLE_VARIOUS)
'			TekstInfo(9).Text = Dec(Val(AdoGetField(TABLE_VARIOUS, "#v040 #")), "###.########")
'		End If

'		If BH_EURO Then
'			If sMuntLever.Value = "BEF" Then
'				cmdSwitch.Text = "Ingave in BEF"
'				cmdSwitch.Enabled = True
'				TekstInfo(9).Text = Dec(1 / EURO, "##0.########")
'			ElseIf sMuntLever.Value = "EUR" Then 
'				cmdSwitch.Text = "Ingave in EUR"
'				cmdSwitch.Enabled = True
'				TekstInfo(9).Text = Dec(1, "##0.########")
'			Else
'				cmdSwitch.Text = "Ingave in EUR"
'				cmdSwitch.Enabled = False
'				TekstInfo(9).Text = Dec(1, "##0.########")
'			End If
'		Else
'			If sMuntLever.Value = "EUR" Then
'				cmdSwitch.Text = "Ingave in EUR"
'				cmdSwitch.Enabled = True
'				TekstInfo(9).Text = Dec(1 / EURO, "##0.########")
'			ElseIf sMuntLever.Value = "BEF" Then 
'				cmdSwitch.Text = "Ingave in BEF"
'				cmdSwitch.Enabled = True
'				TekstInfo(9).Text = Dec(1, "##0.########")
'			Else
'				cmdSwitch.Text = "Ingave in BEF"
'				cmdSwitch.Enabled = False
'				'TekstInfo(9).Text = Dec$(1, "##0.########")
'			End If
'		End If
'		D_CURRENCY = Val(TekstInfo(9).Text)

'		If AdoGetField(TABLE_SUPPLIERS, "#v151 #") = "1" Then
'			Medekontraktant.CheckState = System.Windows.Forms.CheckState.Checked
'		Else
'			Medekontraktant.CheckState = System.Windows.Forms.CheckState.Unchecked
'		End If
'		If AdoGetField(TABLE_SUPPLIERS, "#v163 #") = "1" Then
'			StockBeheer.CheckState = System.Windows.Forms.CheckState.Checked
'		Else
'			StockBeheer.CheckState = System.Windows.Forms.CheckState.Unchecked
'		End If

'		Err.Clear()
'		On Error Resume Next
'		TekstInfo(11).Text = AdoGetField(TABLE_SUPPLIERS, "#A170 #")

'		If SetSpacing(AdoGetField(TABLE_SUPPLIERS, "#v016 #"), 7) <> Space(7) Then
'			If AankoopDetail.Items.Count = 0 Then
'				RasterSchoon()
'				VeldRekening.Value = AdoGetField(TABLE_SUPPLIERS, "#v016 #")
'				VeldNaam.Value = ""
'				VeldBedrag.Value = ""
'				GRIDTEXT = VeldRekening.Value & Chr(124) & VeldNaam.Value & Chr(124) & VeldBedrag.Value & Chr(124)
'				Wijzigen.ShowDialog()
'				If GRIDTEXT = "" Then
'				Else
'					If RekeningOK(VB.Left(GRIDTEXT, 7)) Then
'						AankoopDetail.Items.Add(GRIDTEXT)
'						X = InvestKtrl()
'					End If
'				End If
'			End If
'		End If

'		If VB.Left(AdoGetField(TABLE_SUPPLIERS, "#v162 #"), 3) = "440" Then
'			TekstInfo(3).Text = AdoGetField(TABLE_SUPPLIERS, "#v162 #")
'			JetGet(TABLE_LEDGERACCOUNTS, 0, SetSpacing(AdoGetField(TABLE_SUPPLIERS, "#v162 #"), 7))
'			If KTRL Then
'				Beep()
'				TekstInfo(3).Text = LeverancierRekening.Value
'			End If
'		Else
'			TekstInfo(3).Text = LeverancierRekening.Value
'		End If
'		TekstInfo(10).Enabled = True

'		TekstInfo(2).Text = VValdag(TekstInfo(0).Text, AdoGetField(TABLE_SUPPLIERS, "#vs04 #"))
'		If AdoGetField(TABLE_SUPPLIERS, "#v017 #") = "1" Then
'			'UPGRADE_ISSUE: MSMask.MaskEdBox property TekstInfo.AutoTab was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
'			TekstInfo(4).AutoTab = True
'			'UPGRADE_WARNING: MSMask.MaskEdBox property TekstInfo.ClipMode has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			TekstInfo(4).CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals
'			TekstInfo(4).TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
'			TekstInfo(4).Mask = "+++###/####/#####+++"
'		Else
'			'UPGRADE_ISSUE: MSMask.MaskEdBox property TekstInfo.AutoTab was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
'			TekstInfo(4).AutoTab = False
'			'UPGRADE_WARNING: MSMask.MaskEdBox property TekstInfo.ClipMode has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			TekstInfo(4).CutCopyMaskFormat = MaskFormat.IncludeLiterals
'			TekstInfo(4).TextMaskFormat = MaskFormat.IncludePrompt
'			TekstInfo(4).Mask = ""
'			TekstInfo(4).Text = ""
'		End If
'		If AdoGetField(TABLE_SUPPLIERS, "#v254 #") <> "" Then
'			cmdSQLInfo.Visible = True
'		End If
'		Me.AankoopDetail.Focus()

'	End Sub

'	Private Function InvestKtrl() As Short
'		Dim fRekNum As New VB6.FixedLengthString(7)

'		fRekNum.Value = VB.Left(GRIDTEXT, 7)
'		If fRekNum.Value < VB.Left(GrensDetail(0), 7) Or fRekNum.Value > VB.Right(GrensDetail(0), 7) Then
'		Else
'			GRIDTEXT = TekstInfo(0).Text & Dec(Val(Mid(GRIDTEXT, 50, 12)), MASK_EURBH)
'			InvesteringsFiche.ShowDialog()
'		End If

'	End Function

'	Private Sub DirekteAankoop_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

'		'Me.MiDocView1.filename = ""

'	End Sub

'	Private Sub Kontrole_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Kontrole.Click
'		Dim T As Short
'		Dim BedragTotaal As Decimal
'		Dim BedragBtwAftrekbaas As Decimal

'		Dim BedragTot As Decimal
'		Dim BedragBtw5 As Decimal
'		Dim BedragBtw6 As Decimal
'		Dim BedragBtw7 As Decimal
'		Dim BedragBtw8 As Decimal

'		If DatumKey(TekstInfo(1).Text) < VB.Left(BOOKYEAR_FROMTO.Value, 8) Or DatumKey(TekstInfo(1).Text) > VB.Right(BOOKYEAR_FROMTO.Value, 8) Then
'			MSG = "Datum aankoopdocument valt BUITEN het actieve boekjaar." & vbCr
'			MSG = MSG & "De optie 'boekhoudcontrole' in balans leveranciers zal" & vbCr
'			MSG = MSG & "mogelijk niet goed functioneren." & vbCr & vbCr
'			MSG = MSG & "Controleer eventueel."
'			MsgBox(MSG, MsgBoxStyle.Exclamation)
'		End If

'		VB6.SetDefault(Kontrole, True)
'		For T = 0 To AankoopDetail.Items.Count - 1
'			BedragTot = Val(Mid(VB6.GetItemString(AankoopDetail, T), 50, 12))
'			If BH_EURO Then
'				BedragTotaal = BedragTotaal + BedragTot
'			Else
'				BedragTotaal = BedragTotaal + BedragTot
'			End If
'		Next 
'		BedragBtw5 = Val(TekstInfo(5).Text)
'		BedragBtw6 = Val(TekstInfo(6).Text)
'		BedragBtw7 = Val(TekstInfo(7).Text)
'		BedragBtw8 = Val(TekstInfo(8).Text)
'		BedragTotaal = BedragTotaal + BedragBtw5 - BedragBtw7 + BedragBtw8
'		If BedragTotaal <> BedragBtw6 Then
'			MsgBox("U geeft totaal dokument " & BedragBtw6 & vbCr & "en volgens berekening is het " & BedragTotaal & vbCr & vbCr & "  Kontroleer a.u.b.!", 0, "Totaalkontrole")
'			TekstInfo(6).Focus()
'			Exit Sub
'		Else
'			Afsluiten.Visible = True
'			Afsluiten.Enabled = True
'			Kontrole.Visible = False
'			Afsluiten.Focus()
'		End If

'	End Sub



'	Private Sub ListView1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ListView1.Click

'		If ListView1.Items.Count Then
'			'UPGRADE_WARNING: Lower bound of collection ListView1.SelectedItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'			lvLeverancier = ListView1.FocusedItem.SubItems(1).Text
'			SSTab1.SelectedIndex = 0
'			JetGet(TABLE_SUPPLIERS, 0, lvLeverancier)
'			If KTRL Then
'				MsgBox("stop")
'			Else
'				RecordToField(TABLE_SUPPLIERS)
'				InstalLeverancier()
'			End If
'		Else
'			CTRL_BOX = MsgBox("Historiek van reeds bestaande leveranciers tonen", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2)
'			If CTRL_BOX = MsgBoxResult.Yes Then
'				InstalleerRecenteCrediteuren()
'			End If
'		End If

'	End Sub

'	Private Sub ListView1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles ListView1.KeyDown
'		Dim KeyCode As Short = eventArgs.KeyCode
'		Dim Shift As Short = eventArgs.KeyData \ &H10000

'		If KeyCode = 13 Then ListView1_Click(ListView1, New System.EventArgs())

'	End Sub


'	'UPGRADE_WARNING: Event Medekontraktant.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub Medekontraktant_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Medekontraktant.CheckStateChanged

'		If Medekontraktant.CheckState = 1 Then
'			TekstInfo(7).Visible = True
'			TekstInfo(8).Visible = True
'			TekstInfo(5).Text = "0"
'			TekstInfo(6).Text = "0"
'			TekstInfo(7).Text = "0" 'TekstInfo(5).Text
'			TekstInfo(8).Text = "0"
'			Label1(12).Visible = True
'			Label1(13).Visible = True
'		Else
'			TekstInfo(7).Visible = False
'			TekstInfo(8).Visible = False
'			TekstInfo(5).Text = "0"
'			TekstInfo(6).Text = "0"
'			TekstInfo(7).Text = "0"
'			TekstInfo(8).Text = "0"
'			Label1(12).Visible = False
'			Label1(13).Visible = False
'		End If


'	End Sub

'	Private Sub RasterSchoon()

'		AankoopDetail.Items.Clear()

'	End Sub

'	Private Function RekeningOK(ByRef fRekeningNummer As String) As Short
'		Dim T As Short
'		Dim TFlag As Short

'		TFlag = False
'		For T = 0 To 3
'			If fRekeningNummer >= VB.Left(GrensDetail(T), 7) And fRekeningNummer <= VB.Right(GrensDetail(T), 7) Then
'				TFlag = True
'				Exit For
'			End If
'		Next 
'		If TFlag = False Then
'			MSG = "Uw rekening : " & fRekeningNummer & " past niet in de begrenzing." & vbCrLf & vbCrLf
'			MSG = MSG & "Investeringen  : vanaf " & VB.Left(GrensDetail(0), 7) & " tot " & VB.Right(GrensDetail(0), 7) & vbCrLf
'			MSG = MSG & "Schulden/privé : vanaf " & VB.Left(GrensDetail(1), 7) & " tot " & VB.Right(GrensDetail(1), 7) & vbCrLf
'			MSG = MSG & "Handelsgoed    : vanaf " & VB.Left(GrensDetail(2), 7) & " tot " & VB.Right(GrensDetail(2), 7) & vbCrLf
'			MSG = MSG & "Diverse kosten : vanaf " & VB.Left(GrensDetail(3), 7) & " tot " & VB.Right(GrensDetail(3), 7)
'			MsgBox(MSG)
'			RekeningOK = False
'			Exit Function
'		Else
'			RekeningOK = True
'		End If

'	End Function

'	Private Sub Schoon()
'		Dim T As Short

'		GeScanBestand = ""
'		If StartBlad = True Then
'			SSTab2.SelectedIndex = 0
'			Me.obTAB(0).Checked = True
'		Else
'			SSTab2.SelectedIndex = 1
'			Me.obTAB(1).Checked = True
'		End If

'		'Me.MiDocView1.filename = ""

'		lvLeverancier = ""
'		VB6.SetDefault(Kontrole, False)
'		Kontrole.Visible = True
'		AankoopDetail.Enabled = False
'		'InvoerLijn.Enabled = False
'		LeverancierInfo.Text = ""
'		Afsluiten.Visible = False
'		Schoonvegen.Enabled = False
'		cmdSwitch.Enabled = False
'		'ReturnRooster.Enabled = False
'		'UPGRADE_ISSUE: MSMask.MaskEdBox property TekstInfo.AutoTab was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
'		TekstInfo(4).AutoTab = False
'		'UPGRADE_WARNING: MSMask.MaskEdBox property TekstInfo.ClipMode has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		TekstInfo(4).CutCopyMaskFormat = MaskFormat.IncludeLiterals
'		TekstInfo(4).TextMaskFormat = MaskFormat.IncludePrompt
'		TekstInfo(4).Mask = ""

'		TekstInfo(11).Mask = ""
'		TekstInfo(11).Text = ""
'		TekstInfo(11).Mask = "###-#######-##"
'		'UPGRADE_ISSUE: MSMask.MaskEdBox property TekstInfo.AutoTab was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
'		TekstInfo(11).AutoTab = True
'		'UPGRADE_WARNING: MSMask.MaskEdBox property TekstInfo.ClipMode has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		TekstInfo(11).CutCopyMaskFormat = MaskFormat.IncludeLiterals
'		TekstInfo(11).TextMaskFormat = MaskFormat.IncludePrompt

'		Err.Clear()
'		On Error Resume Next
'		For T = 0 To 2
'			TekstInfo(T).Enabled = False
'			TekstInfo(T).Mask = ""
'			TekstInfo(T).Mask = "##/##/####"
'			TekstInfo(T).Text = MIM_GLOBAL_DATE.Value
'			If Err.Number Then MsgBox("Landinstellingen voor België voorzien a.u.b.  Het programma wordt hierna beëindigd.", MsgBoxStyle.Critical) : End
'		Next 
'		On Error GoTo 0
'		For T = 3 To 10
'			TekstInfo(T).Enabled = False
'			TekstInfo(T).Text = ""
'		Next 
'		TekstInfo(3).Text = LeverancierRekening.Value
'		TekstInfo(10).Text = rbtwVAK(4)
'		RasterSchoon()
'		If Me.Visible Then
'			SSTab1.SelectedIndex = 0
'		End If
'		If Me.obTAB(0).Checked = True Then
'			SSTab2.SelectedIndex = 0
'		Else
'			SSTab2.SelectedIndex = 1
'		End If
'		Me.AankoopOptie(0).Checked = True

'	End Sub

'	'UPGRADE_WARNING: Event obTAB.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub obTAB_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles obTAB.CheckedChanged
'		If eventSender.Checked Then
'			Dim Index As Short = obTAB.GetIndex(eventSender)

'			BeWaarTekst("DirekteAankoop", "startBlad", Str(obTAB(0).Checked))

'		End If
'	End Sub


'	Private Sub SchoonVegen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SchoonVegen.Click

'		RasterSchoon()
'		Schoon()
'		SSTab1.Focus()

'	End Sub

'	Function SQLZoekLeverancier() As Short

'		If LeverancierInfo.Text <> "" Then
'			CTRL_BOX = MsgBox("Andere leverancier aanduiden.  Bent U zeker", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2)
'			If CTRL_BOX = MsgBoxResult.No Then
'				AankoopDetail.Focus()
'				Exit Function
'			End If
'		End If
'		A_INDEX = 1
'		SHARED_FL = TABLE_SUPPLIERS
'		GRIDTEXT = ""
'		SqlSearch.ShowDialog()
'		If KTRL = 0 Then
'			InstalLeverancier()
'		Else
'			Schoon()
'		End If

'	End Function

'	Private Sub SSTab1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles SSTab1.KeyDown
'		Dim KeyCode As Short = eventArgs.KeyCode
'		Dim Shift As Short = eventArgs.KeyData \ &H10000

'		If SSTab1.SelectedIndex = 1 Then
'			If ListView1.Items.Count Then
'			ElseIf KeyCode = 13 Then 
'				CTRL_BOX = MsgBox("Historiek van reeds bestaande leveranciers tonen", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2)
'				If CTRL_BOX = MsgBoxResult.Yes Then
'					InstalleerRecenteCrediteuren()
'				End If
'			End If
'		ElseIf KeyCode = 18 Or KeyCode = 13 Then 
'			SQLZoekLeverancier()
'		End If

'	End Sub


'	'UPGRADE_WARNING: Event StockBeheer.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub StockBeheer_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles StockBeheer.CheckStateChanged

'		On Error Resume Next
'		AankoopDetail.Focus()

'	End Sub

'	Private Sub TekstInfo_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.TextChanged
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		Select Case Index
'			Case 5
'				TekstInfo(8).Text = ""
'				If Medekontraktant.CheckState Then
'					TekstInfo(7).Text = TekstInfo(5).Text
'				End If
'			Case 7
'				If TekstInfo(8).Visible = False Then
'				Else
'					TekstInfo(8).Text = Str(Val(TekstInfo(7).Text) - Val(TekstInfo(5).Text))
'				End If
'		End Select

'	End Sub


'	Private Sub TekstInfo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.Enter
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		TekstInfo(Index).SelectionStart = 0
'		TekstInfo(Index).SelectionLength = Len(TekstInfo(Index).Text)
'		Select Case Index
'			Case 0, 1, 2
'				TekstInfo(Index).SelectionLength = 5
'			Case 6
'				VB6.SetDefault(Kontrole, True)
'		End Select

'	End Sub

'	Private Sub TekstInfo_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles TekstInfo.KeyDown
'		Dim KeyCode As Short = eventArgs.KeyCode
'		Dim Shift As Short = eventArgs.KeyData \ &H10000
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		On Error Resume Next
'		If KeyCode = 13 Then
'			System.Windows.Forms.SendKeys.SendWait("{TAB}")
'			Exit Sub
'		End If

'		Select Case Index
'			Case 3, 10
'				If KeyCode = 17 Then
'					A_INDEX = 0
'					SHARED_FL = TABLE_LEDGERACCOUNTS
'					GRIDTEXT = Trim(TekstInfo(Index).Text)
'					SqlSearch.ShowDialog()
'					If KTRL = 0 Then
'						TekstInfo(Index).Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
'					End If
'				End If
'		End Select

'	End Sub

'	Private Sub TekstInfo_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TekstInfo.KeyPress
'		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		If Index = 3 Or Index = 10 Then KeyAscii = 0


'		eventArgs.KeyChar = Chr(KeyAscii)
'		If KeyAscii = 0 Then
'			eventArgs.Handled = True
'		End If
'	End Sub

'	Private Sub TekstInfo_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles TekstInfo.KeyUp
'		Dim KeyCode As Short = eventArgs.KeyCode
'		Dim Shift As Short = eventArgs.KeyData \ &H10000
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)
'		Dim RekenHier As Object

'		If Index = 5 Then
'			Select Case KeyCode
'				Case 106, 107, 109, 111
'					If Len(TekstInfo(Index).Text) = 1 Then
'						Exit Sub
'					End If
'					'UPGRADE_WARNING: Couldn't resolve default property of object EenLijnRekenen(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					'UPGRADE_WARNING: Couldn't resolve default property of object RekenHier. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					RekenHier = EenLijnRekenen(TekstInfo(5).Text)
'					'UPGRADE_WARNING: Couldn't resolve default property of object RekenHier. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					If RekenHier Then
'						'UPGRADE_WARNING: Couldn't resolve default property of object RekenHier. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'						TekstInfo(5).Text = Str(System.Math.Round(RekenHier, 2))
'					End If
'			End Select
'		End If

'	End Sub

'	Private Sub TekstInfo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.Leave
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		Select Case Index
'			Case 0
'				If DateWrongFormat(TekstInfo(0).Text) Then
'					TekstInfo(0).Text = MIM_GLOBAL_DATE.Value
'					TekstInfo(0).Focus()
'				ElseIf Not DatumKtrl(TekstInfo(0).Text, PERIODAS_TEXT) Then 
'					BJPERDAT.WindowState = System.Windows.Forms.FormWindowState.Normal
'					BJPERDAT.PeriodeBoekjaar.Focus()
'				End If

'			Case 1
'				If DateWrongFormat(TekstInfo(1).Text) Then
'					TekstInfo(1).Text = MIM_GLOBAL_DATE.Value
'					TekstInfo(1).Focus()
'				Else
'					TekstInfo(2).Text = VValdag(TekstInfo(1).Text, AdoGetField(TABLE_SUPPLIERS, "#vs04 #"))
'					TekstInfo(0).Text = MIM_GLOBAL_DATE.Value
'				End If
'				If DatumKey(TekstInfo(1).Text) < VB.Left(BOOKYEAR_FROMTO.Value, 8) Or DatumKey(TekstInfo(1).Text) > VB.Right(BOOKYEAR_FROMTO.Value, 8) Then
'					MSG = "Datum aankoopdocument valt BUITEN het actieve boekjaar." & vbCr
'					MSG = MSG & "De optie 'boekhoudcontrole' in balans leveranciers zal" & vbCr
'					MSG = MSG & "mogelijk niet goed functioneren." & vbCr & vbCr
'					MSG = MSG & "Controleer eventueel."
'					MsgBox(MSG, MsgBoxStyle.Exclamation)
'				End If

'			Case 2
'				If DateWrongFormat(TekstInfo(2).Text) Then
'					TekstInfo(2).Text = VValdag(TekstInfo(1).Text, AdoGetField(TABLE_SUPPLIERS, "#vs04 #"))
'					TekstInfo(2).Focus()
'				End If

'			Case 3
'				If VB.Left(TekstInfo(Index).Text, 3) <> "440" Then
'					TekstInfo(Index).Text = LeverancierRekening.Value
'					Beep()
'					TekstInfo(Index).Focus()
'					Exit Sub
'				End If
'				JetGet(TABLE_LEDGERACCOUNTS, 0, SetSpacing(TekstInfo(Index).Text, 7))
'				If KTRL Then
'					Beep()
'					TekstInfo(Index).Text = LeverancierRekening.Value
'					TekstInfo(Index).Focus()
'				End If

'			Case 10
'				If VB.Left(TekstInfo(Index).Text, 6) <> VB.Left(rbtwVAK(4), 6) Then
'					TekstInfo(Index).Text = rbtwVAK(4)
'					Beep()
'					TekstInfo(Index).Focus()
'					Exit Sub
'				End If
'				JetGet(TABLE_LEDGERACCOUNTS, 0, SetSpacing(TekstInfo(Index).Text, 7))
'				If KTRL Then
'					Beep()
'					TekstInfo(Index).Text = rbtwVAK(4)
'					TekstInfo(Index).Focus()
'				End If

'			Case 4
'				If AdoGetField(TABLE_SUPPLIERS, "#v017 #") = "1" Then
'					If BankOk(TekstInfo(4).Text) Then
'					Else
'						Beep()
'						On Error Resume Next
'						SnelHelpPrint("Gestructureerde betaalreferte onjuist !", BL_LOGGING)
'						TekstInfo(4).Text = "OGM onjuist"
'						On Error GoTo 0
'						Exit Sub
'					End If
'				End If
'			Case 5
'				If AankoopFlg = 1 And AankoopOptie(1).Checked = True Then
'					If Val(TekstInfo(5).Text) <> 0 Then
'						CTRL_BOX = MsgBox("De aanbeveling door meeste BTW-diensten om bij creditnota E.U. géén B.T.W op te nemen negeren", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1)
'						If CTRL_BOX = MsgBoxResult.Yes Then
'							TekstInfo(5).Text = "0"
'						End If
'					End If
'				ElseIf AankoopFlg = 1 And AankoopOptie(1).Checked = False Then 
'					If Val(TekstInfo(5).Text) = 0 Then
'						MsgBox("Respecteer de aanbeveling door de BTW-diensten om bij factuur E.U. de B.T.W. zelf uit te rekenen en zowel AFTREKBAAR als VERSCHULDIGD (0-operatie dus...) het toepasbaar B.T.W. bedrag mee te delen !", MsgBoxStyle.Exclamation)
'						TekstInfo(5).Focus()
'						Exit Sub
'					Else
'						TekstInfo(7).Text = TekstInfo(5).Text
'					End If
'				End If

'			Case 11
'				Me.cbUpdateLeverancier.Visible = False
'				If TekstInfo(11).Text = "" Then
'					Stop
'				End If
'				If Not BankOk(TekstInfo(11).Text) Then
'					TekstInfo(11).Mask = ""
'					TekstInfo(11).Text = ""
'					TekstInfo(11).Mask = "###-#######-##"
'				Else
'					Me.cbUpdateLeverancier.Visible = True
'				End If

'		End Select

'	End Sub

'	Private Function WegBoekFout() As Short

'		Dim TotaalBedrag As Decimal
'		Dim Bedrag As Decimal
'		Dim dInvest As Decimal
'		Dim dPrive As Decimal
'		Dim dAlKost As Decimal
'		Dim dHandel As Decimal

'		Dim AantalStuks As Single
'		Dim T As Short

'		Dim DVT99 As String
'		Dim LokRekening As New VB6.FixedLengthString(7)

'		JetGet(TABLE_SUPPLIERS, 0, VB.Left(LeverancierInfo.Text, 12))
'		If KTRL Then
'			WegBoekFout = True
'			Exit Function
'		Else
'			RecordToField(TABLE_SUPPLIERS)
'			D_CURRENCY = Val(TekstInfo(9).Text)
'		End If

'		'gewijzigd voor scanning
'		WegBoekFout = False
'		DKTRL_CUMUL = 0 : DKTRL_BEF = 0 : DKTRL_EUR = 0
'		frmBoeking.Close()
'		frmBoeking.Hide()
'		TLB_RECORD(TABLE_JOURNAL) = ""
'		TLB_RECORD(TABLE_INVOICES) = ""
'		'bijgevoegd voor scanning
'		If RS_MAR(TABLE_INVOICES).State = ADODB.ObjectStateEnum.adStateClosed Then
'			KTRL = JetTableOpen(TABLE_INVOICES)
'		End If
'		RS_MAR(TABLE_INVOICES).AddNew()

'		AdoInsertToRecord(TABLE_JOURNAL, "L" & AdoGetField(TABLE_SUPPLIERS, "#A110 #"), "v034")
'		'19
'		AdoInsertToRecord(TABLE_JOURNAL, DatumKey(TekstInfo(0).Text), "v066")
'		AdoInsertToRecord(TABLE_JOURNAL, dokumentSleutel.Value, "v033")
'		AdoInsertToRecord(TABLE_JOURNAL, DatumKey(TekstInfo(1).Text), "v035")
'		AdoInsertToRecord(TABLE_JOURNAL, (TekstInfo(3).Text), "v069")

'		AdoInsertToRecord(TABLE_INVOICES, dokumentSleutel.Value, "v033")
'		AdoInsertToRecord(TABLE_INVOICES, "L" & AdoGetField(TABLE_SUPPLIERS, "#A110 #"), "v034")
'		AdoInsertToRecord(TABLE_INVOICES, DatumKey(TekstInfo(1).Text), "v035")
'		AdoInsertToRecord(TABLE_INVOICES, DatumKey(TekstInfo(2).Text), "v036")
'		AdoInsertToRecord(TABLE_INVOICES, (TekstInfo(4).Text), "v039")
'		AdoInsertToRecord(TABLE_INVOICES, Dec(D_CURRENCY, "###.##########"), "v040")
'		AdoInsertToRecord(TABLE_INVOICES, AdoGetField(TABLE_SUPPLIERS, "#vs03 #"), "vs03")
'		AdoInsertToRecord(TABLE_JOURNAL, AdoGetField(TABLE_SUPPLIERS, "#A100 #"), "v067")
'		For T = 0 To AankoopDetail.Items.Count - 1
'			AankoopDetail.SelectedIndex = T
'			LokRekening.Value = VB.Left(AankoopDetail.Text, 7)
'			AdoInsertToRecord(TABLE_JOURNAL, LokRekening.Value, "v019")
'			JetGet(TABLE_LEDGERACCOUNTS, 0, LokRekening.Value)
'			If KTRL Then
'				WegBoekFout = True
'				Exit Function
'			End If
'			Bedrag = Val(Mid(AankoopDetail.Text, 50, 12))
'			TotaalBedrag = TotaalBedrag + Bedrag
'			If AankoopOptie(0).Checked = True Then
'				'factuur
'				AdoInsertToRecord(TABLE_JOURNAL, Dec(Bedrag, MASK_EURBH), "v068")
'			ElseIf AankoopOptie(1).Checked = True Then 
'				'creditnota
'				AdoInsertToRecord(TABLE_JOURNAL, Dec(-Bedrag, MASK_EURBH), "v068")
'			Else
'				MsgBox("logicafout")
'			End If

'			AdoInsertToRecord(TABLE_JOURNAL, "", "v102")
'			If Len(AankoopDetail.Text) > 62 Then

'				JetGet(TABLE_PRODUCTS, 0, Mid(AankoopDetail.Text, 63, 13))
'				If KTRL Then
'					MsgBox("Onverwacht situatie")
'					WegBoekFout = True
'					Exit Function
'				Else
'					RecordToField(TABLE_PRODUCTS)
'					AdoInsertToRecord(TABLE_JOURNAL, Mid(AankoopDetail.Text, 77, 30), "v067")
'					AdoInsertToRecord(TABLE_JOURNAL, Mid(AankoopDetail.Text, 63, 13), "v102")
'					AantalStuks = Val(Mid(AankoopDetail.Text, 77 + 41, 10))
'					If AankoopOptie(0).Checked = True Then
'						'IseenFactuur
'						'AankoopPrijs
'						AdoInsertToRecord(TABLE_PRODUCTS, Str(Bedrag / AantalStuks), "e113")
'						'Leveranciernummer
'						AdoInsertToRecord(TABLE_PRODUCTS, FVT(TABLE_SUPPLIERS, 0), "v124")
'						'Aantal stuks aankoop bijvoegen
'						AdoInsertToRecord(TABLE_PRODUCTS, Str(AantalStuks + Val(AdoGetField(TABLE_PRODUCTS, "#v119 #"))), "v119")
'						'Totaal bedrag bijtellen
'						AdoInsertToRecord(TABLE_PRODUCTS, Str(Bedrag + Val(AdoGetField(TABLE_PRODUCTS, "#e121 #"))), "e121")
'						'Laatste kostenrekening onthouden
'						AdoInsertToRecord(TABLE_PRODUCTS, LokRekening.Value, "v116")
'					ElseIf AankoopOptie(1).Checked = True Then 
'						'IsCreditnota
'						'Aantal stuks aankoop aftrekken
'						AdoInsertToRecord(TABLE_PRODUCTS, Str(-AantalStuks + Val(AdoGetField(TABLE_PRODUCTS, "#v119 #"))), "v119")
'						'Totaal bedrag aftrekken
'						AdoInsertToRecord(TABLE_PRODUCTS, Str(-Bedrag + Val(AdoGetField(TABLE_PRODUCTS, "#e121 #"))), "e121")
'					Else
'						MsgBox("logicafout")
'					End If
'					bUpdate(TABLE_PRODUCTS, 0)
'					If KTRL Then
'						MsgBox("Onverwacht situatie")
'						WegBoekFout = True
'						Exit Function
'					End If
'				End If
'			End If

'			'grens 0
'			If LokRekening.Value >= VB.Left(GrensDetail(0), 7) And LokRekening.Value <= VB.Right(GrensDetail(0), 7) Then
'				dInvest = dInvest + Bedrag

'				'grens 1
'			ElseIf LokRekening.Value >= VB.Left(GrensDetail(1), 7) And LokRekening.Value <= VB.Right(GrensDetail(1), 7) Then 
'				dPrive = dPrive + Bedrag

'				'grens 2
'			ElseIf LokRekening.Value >= VB.Left(GrensDetail(2), 7) And LokRekening.Value <= VB.Right(GrensDetail(2), 7) Then 
'				dHandel = dHandel + Bedrag

'				'grens 3
'			ElseIf LokRekening.Value >= VB.Left(GrensDetail(3), 7) And LokRekening.Value <= VB.Right(GrensDetail(3), 7) Then 
'				dAlKost = dAlKost + Bedrag
'			Else
'				MsgBox("Stop in begrenzing")
'			End If
'			'1310 IF Left(svkf(1),2)="ON"THEN 1525
'			JetInsert(TABLE_JOURNAL, 0)
'			If KTRL Then
'				WegBoekFout = True
'				Exit Function
'			End If
'		Next 
'		AdoInsertToRecord(TABLE_JOURNAL, AdoGetField(TABLE_SUPPLIERS, "#A100 #"), "v067")

'		AdoInsertToRecord(TABLE_INVOICES, (TekstInfo(5).Text), "v045")
'		'If Ar = 3 Then
'		'    AdoInsertToRecord TABLE_INVOICES, "0", "v048"
'		'    AdoInsertToRecord TABLE_INVOICES, "0", "v049"
'		'    AdoInsertToRecord TABLE_INVOICES, "0", "v046"
'		'    AdoInsertToRecord TABLE_INVOICES, "0", "v047"
'		'Else
'		AdoInsertToRecord(TABLE_INVOICES, Str(dInvest), "v048")
'		AdoInsertToRecord(TABLE_INVOICES, Str(dPrive + Val(TekstInfo(8).Text)), "v049")
'		AdoInsertToRecord(TABLE_INVOICES, Str(dHandel), "v046")
'		AdoInsertToRecord(TABLE_INVOICES, Str(dAlKost), "v047")
'		'End If
'		DVT99 = Str(dInvest + dAlKost + dHandel + dPrive)

'		If Medekontraktant.CheckState Then
'			AdoInsertToRecord(TABLE_INVOICES, (TekstInfo(7).Text), "v043")
'			If Ar = 1 Then
'				AdoInsertToRecord(TABLE_INVOICES, DVT99, "v053")
'			Else
'				AdoInsertToRecord(TABLE_INVOICES, DVT99, "v051")
'			End If
'		Else
'			If Medekontraktant.CheckState = 0 And AankoopFlg = 0 Then
'				If Ar = 3 Then
'					AdoInsertToRecord(TABLE_INVOICES, DVT99, "v051")
'				End If
'			End If
'		End If
'		If AankoopFlg = 1 Then
'			AdoInsertToRecord(TABLE_INVOICES, (TekstInfo(7).Text), "v042")
'			If Ar = 1 Then
'				AdoInsertToRecord(TABLE_INVOICES, DVT99, "v052")
'			Else
'				AdoInsertToRecord(TABLE_INVOICES, DVT99, "v050")
'			End If
'		End If
'		If AankoopFlg = 2 Then
'			AdoInsertToRecord(TABLE_INVOICES, (TekstInfo(7).Text), "v044")
'			If Ar = 1 Then
'				MsgBox("in pseudo vak 88 wordt " & DVT99 & " bijgevoegd.  Bij de eigenlijke BTW aangifte dient U de cijfers van kolom '88!'  bij te tellen bij vak 87", MsgBoxStyle.Information)
'				AdoInsertToRecord(TABLE_INVOICES, DVT99, "v054")
'			Else
'				AdoInsertToRecord(TABLE_INVOICES, DVT99, "v051")
'			End If
'		End If

'		If Val(TekstInfo(5).Text) <> 0 Then
'			If Ar = 3 Then
'				AdoInsertToRecord(TABLE_JOURNAL, Dec(-Val(TekstInfo(5).Text), MASK_EURBH), "v068")
'				AdoInsertToRecord(TABLE_JOURNAL, rbtwVAK(5), "v019")
'			Else
'				AdoInsertToRecord(TABLE_JOURNAL, Dec(Val(TekstInfo(5).Text), MASK_EURBH), "v068")
'				AdoInsertToRecord(TABLE_JOURNAL, SetSpacing(TekstInfo(10).Text, 7), "v019")
'			End If
'			JetInsert(TABLE_JOURNAL, 0)
'		End If

'		If AankoopFlg = 0 Then
'			If Medekontraktant.CheckState Then
'				If Ar = 1 Then
'					AdoInsertToRecord(TABLE_JOURNAL, Dec(-Val(TekstInfo(7).Text), MASK_EURBH), "v068")
'				Else
'					AdoInsertToRecord(TABLE_JOURNAL, Dec(Val(TekstInfo(7).Text), MASK_EURBH), "v068")
'				End If
'				FVT(TABLE_JOURNAL, 1) = rbtwVAK(2)
'				AdoInsertToRecord(TABLE_JOURNAL, rbtwVAK(2), "v019")
'				JetInsert(TABLE_JOURNAL, 0)
'			End If
'			GoTo Label1440
'		End If

'		If AankoopFlg = 2 Then
'			If Ar = 1 Then
'				AdoInsertToRecord(TABLE_JOURNAL, Dec(-Val(TekstInfo(7).Text), MASK_EURBH), "v068")
'			Else
'				AdoInsertToRecord(TABLE_JOURNAL, Dec(Val(TekstInfo(7).Text), MASK_EURBH), "v068")
'			End If
'			AdoInsertToRecord(TABLE_JOURNAL, rbtwVAK(3), "v019")
'		Else
'			If Ar = 1 Then
'				AdoInsertToRecord(TABLE_JOURNAL, Dec(-Val(TekstInfo(7).Text), MASK_EURBH), "v068")
'			Else
'				AdoInsertToRecord(TABLE_JOURNAL, Dec(Val(TekstInfo(7).Text), MASK_EURBH), "v068")
'			End If
'			AdoInsertToRecord(TABLE_JOURNAL, rbtwVAK(1), "v019")
'		End If
'		JetInsert(TABLE_JOURNAL, 0)

'Label1440: 
'		If Val(TekstInfo(8).Text) <> 0 Then
'			If Ar = 3 Then
'				AdoInsertToRecord(TABLE_JOURNAL, Dec(-Val(TekstInfo(8).Text), MASK_EURBH), "v068")
'			Else
'				AdoInsertToRecord(TABLE_JOURNAL, Dec(Val(TekstInfo(8).Text), MASK_EURBH), "v068")
'			End If
'			AdoInsertToRecord(TABLE_JOURNAL, PriveRekening.Value, "v019")
'			JetInsert(TABLE_JOURNAL, 0)
'		End If

'		DVT99 = Str(Val(DVT99) + Val(TekstInfo(5).Text) + Val(TekstInfo(8).Text) - Val(TekstInfo(7).Text))
'		If Ar = 1 Then
'			AdoInsertToRecord(TABLE_JOURNAL, Dec(-Val(DVT99), MASK_EURBH), "v068")
'		Else
'			AdoInsertToRecord(TABLE_JOURNAL, Dec(Val(DVT99), MASK_EURBH), "v068")
'		End If
'		AdoInsertToRecord(TABLE_JOURNAL, SetSpacing(TekstInfo(3).Text, 7), "v019")
'		JetInsert(TABLE_JOURNAL, 0)

'		If XisEUROWasBEF = False Then
'			AdoInsertToRecord(TABLE_INVOICES, DVT99, "v249")
'		Else
'			AdoInsertToRecord(TABLE_INVOICES, Str(System.Math.Round(CDbl(DVT99) / EURO, 2)), "v249")
'		End If

'		If GeScanBestand <> "" Then
'			FileToBlob(RS_MAR(TABLE_INVOICES).Fields("bstBLOB37"), GeScanBestand)
'			RS_MAR(TABLE_INVOICES).Fields("bstndNaam37").Value = GeScanBestand
'			RS_MAR(TABLE_INVOICES).Fields("typeZending37").Value = Mid(GeScanBestand, InStr(GeScanBestand, ".") + 1)
'		End If
'		JetInsert(TABLE_INVOICES, 0)

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
'			If DKTRL_CUMUL Then WegBoekFout = True
'		End If

'	End Function
'	Function InstalleerRecenteCrediteuren() As Short

'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'		Dim rsRecent As ADODB.Recordset
'		rsRecent = New ADODB.Recordset
'		rsRecent.CursorLocation = ADODB.CursorLocationEnum.adUseClient
'		rsRecent.Open("SELECT DISTINCT v067 AS Naam, Mid(v034,2) AS IdCode FROM Journalen WHERE Mid(v066,1,4)>=2002 AND v033 Like 'A%'", AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
'		MsgBox(rsRecent.RecordCount & " leveranciers aangewend laatste 2 jaren", MsgBoxStyle.Information)
'		Dim itmX As System.Windows.Forms.ListViewItem
'		ListView1.Items.Clear()

'		Do While Not rsRecent.EOF
'			' Add a ListItem object.
'			itmX = ListView1.Items.Add(rsRecent.Fields("Naam").Value)
'			'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'			If itmX.SubItems.Count > 1 Then
'				itmX.SubItems(1).Text = rsRecent.Fields("idCode").Value
'			Else
'				itmX.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, rsRecent.Fields("idCode").Value))
'			End If
'			rsRecent.MoveNext()
'		Loop 
'		rsRecent.Close()
'		'UPGRADE_NOTE: Object rsRecent may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
'		rsRecent = Nothing
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal
'		ListView1.Focus()

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


'	Function ktrlBLOBRecord() As Boolean

'		Dim ktrlString As String

'		Err.Clear()
'		On Error Resume Next

'		'nieuwe poging 03/2007

'		ktrlBLOBRecord = True
'		ktrlString = RS_MAR(TABLE_INVOICES).Fields("bstndNaam37").Name

'		'bstndNaam
'		'typeZending 'TIF, PDF, enz...
'		'bstBLOB inhoud bestand
'		If Err.Number = 3265 Then
'			RS_MAR(TABLE_INVOICES).Close()
'			MSG = "ALTER TABLE Dokumenten ADD COLUMN bstndNaam37 varchar;"
'			Err.Clear()
'			AD_NTDB.Execute(MSG)
'			If Err.Number Then
'				MsgBox("Foutmelding bron: " & Err.Source & vbCrLf & "Foutkodenummer: " & Err.Number & vbCrLf & vbCrLf & "Foutmelding omschrijving:" & vbCrLf & Err.Description)
'			Else
'				MsgBox(MSG, MsgBoxStyle.Information, "Met succes")
'			End If
'			MSG = "ALTER TABLE Dokumenten ADD COLUMN typeZending37 TEXT(5);"
'			Err.Clear()
'			AD_NTDB.Execute(MSG)
'			If Err.Number Then
'				MsgBox("Foutmelding bron: " & Err.Source & vbCrLf & "Foutkodenummer: " & Err.Number & vbCrLf & vbCrLf & "Foutmelding omschrijving:" & vbCrLf & Err.Description)
'			Else
'				MsgBox(MSG, MsgBoxStyle.Information, "Met succes")
'			End If
'			MSG = "ALTER TABLE Dokumenten ADD COLUMN bstBLOB37 OLEobject;"
'			Err.Clear()
'			AD_NTDB.Execute(MSG)
'			If Err.Number Then
'				MsgBox("Foutmelding bron: " & Err.Source & vbCrLf & "Foutkodenummer: " & Err.Number & vbCrLf & vbCrLf & "Foutmelding omschrijving:" & vbCrLf & Err.Description)
'			Else
'				MsgBox(MSG, MsgBoxStyle.Information, "Met succes")
'			End If
'			MsgBox("Belangrijke velden werden toegevoegd. Gelieve het bedrijf opnieuw te openen a.u.b.")
'			ktrlBLOBRecord = False
'		End If

'	End Function
'End Class