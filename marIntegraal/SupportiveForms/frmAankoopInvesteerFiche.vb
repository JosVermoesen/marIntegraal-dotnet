Public Class frmAankoopInvesteerFiche
    Private Sub FrmAankoopInvesteerFiche_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class InvesteringsFiche
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Dim NietAanwezig As Short

'	Private Sub Annuleren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Annuleren.Click

'		Msg = "InvesteringFiche negeren !  Bent U zeker ?"
'		Ktrl = MsgBox(Msg, 292, "Investeringsfiche overslaan")
'		If Ktrl = 6 Then
'			Me.Close()
'		End If

'	End Sub

'	Private Sub InvesteringsFiche_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
'		Dim T As Short
'		Dim Teller As Short
'		Dim RekeningTest As New VB6.FixedLengthString(7)
'		Dim RekeningNaam As New VB6.FixedLengthString(40)
'		Dim RekeningTest2 As String

'		TekstInfo(3).Text = AdoGetField(TableOfLedgerAccounts, "#v019 #")
'		RekeningTest2 = RTrim(AdoGetField(TableOfLedgerAccounts, "#v019 #"))
'		TekstInfo(0).Text = Mid(GridText, 1, 10)
'		TekstInfo(1).Text = Dec(Val(Mid(GridText, 11, 12)), MaskEURBH)
'		TLBRecord(TableOfVarious) = ""

'		Teller = Len(RekeningTest2)
'		Do While Teller >= 0
'			If Mid(RekeningTest2, Teller, 1) = "0" Then
'				Mid(RekeningTest2, Teller, 1) = "9"
'				Exit Do
'			Else
'				Teller = Teller - 1
'			End If
'		Loop 
'		If Teller = 0 Then
'			MsgBox("Onlogika in investeringsrekening !")
'			Ok.Enabled = False
'		Else
'			RekeningTest.Value = RekeningTest2
'			TekstInfo(4).Text = RekeningTest.Value
'			JetGet(TableOfLedgerAccounts, 0, RekeningTest.Value)
'			If Ktrl Then
'				RekeningNaam.Value = AdoGetField(TableOfLedgerAccounts, "#v020 #")
'				Msg = "Afschrijving op " & RTrim(RekeningNaam.Value) & vbCrLf
'				Msg = Msg & "Rekeningnr. : " & RekeningTest.Value & " bestaat nog niet." & vbCrLf & vbCrLf
'				Msg = Msg & "Wordt hierna automatisch aangemaakt..."
'				MsgBox(Msg, 0, "Aanmaak afschrijfrekening")

'				TLBRecord(TableOfLedgerAccounts) = ""
'				AdoInsertToRecord(TableOfLedgerAccounts, RekeningTest.Value, "v019")
'				AdoInsertToRecord(TableOfLedgerAccounts, "Afschrijving op " & RTrim(RekeningNaam.Value), "v020")
'				AdoInsertToRecord(TableOfLedgerAccounts, "O", "v032")
'				JetInsert(TableOfLedgerAccounts, 0)
'			End If
'		End If

'		JetGet(TableOfVarious, 1, SetSpacing("18" & RekeningTest.Value, 20))
'		NietAanwezig = Ktrl
'		If Ktrl Then
'			TekstInfo(6).Text = ""
'			For T = 7 To 8
'				TekstInfo(T).Text = Dec(0, MaskEURBH)
'			Next 
'			TekstInfo(2).Text = Dec(5, "###")
'			TekstInfo(5).Text = "6300000"
'			Versneld.CheckState = System.Windows.Forms.CheckState.Checked
'		Else
'			RecordToField(TableOfVarious)
'			TekstInfo(2).Text = Dec(Val(AdoGetField(TableOfVarious, "#v082 #")), "###") 'lineair over aantal jaar
'			TekstInfo(6).Text = (AdoGetField(TableOfVarious, "#v083 #")) 'datum vorige bewerking
'			TekstInfo(7).Text = Dec(Val(AdoGetField(TableOfVarious, "#v084 #")), MaskEURBH) 'totaal vorige bewerkingen
'			TekstInfo(8).Text = Dec(Val(AdoGetField(TableOfVarious, "#v085 #")), MaskEURBH) 'reeds afgeschreven
'			Versneld.CheckState = Val(AdoGetField(TableOfVarious, "#v086 #")) 'versnelde afschrijving
'			TekstInfo(4).Text = AdoGetField(TableOfVarious, "#v087 #")
'			TekstInfo(5).Text = AdoGetField(TableOfVarious, "#v088 #")
'			If TekstInfo(6).Text = TekstInfo(0).Text Then
'				Msg = "Opgelet, laatste bijwerking op dezelfde dag" & vbCrLf
'				Msg = Msg & "reeds aanwezig.  Vermijdt dubbele optellingen !" & vbCrLf & vbCrLf
'				Msg = Msg & "Kies Sluiten indien U zopas de fiche reeds bijgewerkt hebt."
'				MsgBox(Msg, 48, "Investeringsfiche éénzelfde datum")
'			ElseIf Not DatumKtrl(TekstInfo(6).Text, BookyearAsText) Then 
'				Msg = "Opgelet, U probeert een investeringsfiche" & vbCrLf
'				Msg = Msg & "van een ander boekjaar bij te werken !" & vbCrLf & vbCrLf
'				Msg = Msg & "Kies Sluiten en neem de juiste rekening."
'				MsgBox(Msg, 16, "Gebruikersfout !")
'				Ok.Enabled = False
'			End If
'		End If

'	End Sub

'	Private Sub InvesteringsFiche_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

'		JetTableClose(TableOfVarious)

'	End Sub

'	Private Sub Ok_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Ok.Click
'		Dim TempoTel As Short
'		Dim Ktrl2 As Short

'		AdoInsertToRecord(TableOfVarious, (TekstInfo(3).Text), "v019")
'		AdoInsertToRecord(TableOfVarious, (TekstInfo(2).Text), "v082")
'		AdoInsertToRecord(TableOfVarious, (TekstInfo(0).Text), "v083")
'		AdoInsertToRecord(TableOfVarious, Dec(Val(TekstInfo(1).Text) + Val(TekstInfo(7).Text), MaskEURBH), "v084")
'		'v085 TekstInfo(8).Text reeds afgeschreven mag niet gewijzigd worden
'		AdoInsertToRecord(TableOfVarious, VB6.Format(Versneld.CheckState, "0"), "v086")
'		AdoInsertToRecord(TableOfVarious, (TekstInfo(4).Text), "v087")
'		AdoInsertToRecord(TableOfVarious, (TekstInfo(5).Text), "v088")
'		AdoInsertToRecord(TableOfVarious, "18" & AdoGetField(TableOfVarious, "#v087 #"), "v005")
'		Msg = "Informatielijn opslaan..." & vbCrLf
'		Msg = Msg & "Bent U zeker ?"
'		Ktrl2 = MsgBox(Msg, 292, "Fiche bijwerken/wegschrijven")
'		If Ktrl2 = 6 Then
'			If NietAanwezig Then
'				JetInsert(TableOfVarious, 1)
'			Else
'				bUpdate(TableOfVarious, 1)
'			End If
'			Me.Close()
'		End If

'	End Sub

'	Private Sub TekstInfo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.Enter
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		TekstInfo(Index).SelectionLength = Len(TekstInfo(Index).Text)

'	End Sub

'	Private Sub TekstInfo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.Leave
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)
'		Dim TempoBdrg As Integer

'		Select Case Index
'			Case 0
'				If DateWrongFormat(TekstInfo(Index).Text) Then
'					TekstInfo(Index).Text = Mid(GridText, 1, 10)
'					Beep()
'				End If
'			Case 1, 8
'				TekstInfo(Index).Text = Dec(Val(TekstInfo(Index).Text), MaskEURBH)
'			Case 2
'				TempoBdrg = Val(TekstInfo(Index).Text)
'				If TempoBdrg < 1 Or TempoBdrg > 50 Then
'					Beep()
'					TempoBdrg = 5
'				End If
'				TekstInfo(Index).Text = Dec(TempoBdrg, "##0")
'			Case 5
'				If VB.Left(TekstInfo(Index).Text, 3) <> "630" Then
'					Beep()
'					TekstInfo(Index).Text = "6300000"
'					TekstInfo(Index).Focus()
'					Exit Sub
'				End If
'		End Select

'	End Sub
'End Class