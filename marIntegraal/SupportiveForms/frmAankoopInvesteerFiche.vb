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

'		MSG = "InvesteringFiche negeren !  Bent U zeker ?"
'		KTRL = MsgBox(MSG, 292, "Investeringsfiche overslaan")
'		If KTRL = 6 Then
'			Me.Close()
'		End If

'	End Sub

'	Private Sub InvesteringsFiche_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
'		Dim T As Short
'		Dim Teller As Short
'		Dim RekeningTest As New VB6.FixedLengthString(7)
'		Dim RekeningNaam As New VB6.FixedLengthString(40)
'		Dim RekeningTest2 As String

'		TekstInfo(3).Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
'		RekeningTest2 = RTrim(AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #"))
'		TekstInfo(0).Text = Mid(GRIDTEXT, 1, 10)
'		TekstInfo(1).Text = Dec(Val(Mid(GRIDTEXT, 11, 12)), MASK_EURBH)
'		TLB_RECORD(TABLE_VARIOUS) = ""

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
'			JetGet(TABLE_LEDGERACCOUNTS, 0, RekeningTest.Value)
'			If KTRL Then
'				RekeningNaam.Value = AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #")
'				MSG = "Afschrijving op " & RTrim(RekeningNaam.Value) & vbCrLf
'				MSG = MSG & "Rekeningnr. : " & RekeningTest.Value & " bestaat nog niet." & vbCrLf & vbCrLf
'				MSG = MSG & "Wordt hierna automatisch aangemaakt..."
'				MsgBox(MSG, 0, "Aanmaak afschrijfrekening")

'				TLB_RECORD(TABLE_LEDGERACCOUNTS) = ""
'				AdoInsertToRecord(TABLE_LEDGERACCOUNTS, RekeningTest.Value, "v019")
'				AdoInsertToRecord(TABLE_LEDGERACCOUNTS, "Afschrijving op " & RTrim(RekeningNaam.Value), "v020")
'				AdoInsertToRecord(TABLE_LEDGERACCOUNTS, "O", "v032")
'				JetInsert(TABLE_LEDGERACCOUNTS, 0)
'			End If
'		End If

'		JetGet(TABLE_VARIOUS, 1, SetSpacing("18" & RekeningTest.Value, 20))
'		NietAanwezig = KTRL
'		If KTRL Then
'			TekstInfo(6).Text = ""
'			For T = 7 To 8
'				TekstInfo(T).Text = Dec(0, MASK_EURBH)
'			Next 
'			TekstInfo(2).Text = Dec(5, "###")
'			TekstInfo(5).Text = "6300000"
'			Versneld.CheckState = System.Windows.Forms.CheckState.Checked
'		Else
'			RecordToField(TABLE_VARIOUS)
'			TekstInfo(2).Text = Dec(Val(AdoGetField(TABLE_VARIOUS, "#v082 #")), "###") 'lineair over aantal jaar
'			TekstInfo(6).Text = (AdoGetField(TABLE_VARIOUS, "#v083 #")) 'datum vorige bewerking
'			TekstInfo(7).Text = Dec(Val(AdoGetField(TABLE_VARIOUS, "#v084 #")), MASK_EURBH) 'totaal vorige bewerkingen
'			TekstInfo(8).Text = Dec(Val(AdoGetField(TABLE_VARIOUS, "#v085 #")), MASK_EURBH) 'reeds afgeschreven
'			Versneld.CheckState = Val(AdoGetField(TABLE_VARIOUS, "#v086 #")) 'versnelde afschrijving
'			TekstInfo(4).Text = AdoGetField(TABLE_VARIOUS, "#v087 #")
'			TekstInfo(5).Text = AdoGetField(TABLE_VARIOUS, "#v088 #")
'			If TekstInfo(6).Text = TekstInfo(0).Text Then
'				MSG = "Opgelet, laatste bijwerking op dezelfde dag" & vbCrLf
'				MSG = MSG & "reeds aanwezig.  Vermijdt dubbele optellingen !" & vbCrLf & vbCrLf
'				MSG = MSG & "Kies Sluiten indien U zopas de fiche reeds bijgewerkt hebt."
'				MsgBox(MSG, 48, "Investeringsfiche éénzelfde datum")
'			ElseIf Not IsDateOk(TekstInfo(6).Text, BOOKYEARAS_TEXT) Then 
'				MSG = "Opgelet, U probeert een investeringsfiche" & vbCrLf
'				MSG = MSG & "van een ander boekjaar bij te werken !" & vbCrLf & vbCrLf
'				MSG = MSG & "Kies Sluiten en neem de juiste rekening."
'				MsgBox(MSG, 16, "Gebruikersfout !")
'				Ok.Enabled = False
'			End If
'		End If

'	End Sub

'	Private Sub InvesteringsFiche_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

'		JetTableClose(TABLE_VARIOUS)

'	End Sub

'	Private Sub Ok_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Ok.Click
'		Dim TempoTel As Short
'		Dim Ktrl2 As Short

'		AdoInsertToRecord(TABLE_VARIOUS, (TekstInfo(3).Text), "v019")
'		AdoInsertToRecord(TABLE_VARIOUS, (TekstInfo(2).Text), "v082")
'		AdoInsertToRecord(TABLE_VARIOUS, (TekstInfo(0).Text), "v083")
'		AdoInsertToRecord(TABLE_VARIOUS, Dec(Val(TekstInfo(1).Text) + Val(TekstInfo(7).Text), MASK_EURBH), "v084")
'		'v085 TekstInfo(8).Text reeds afgeschreven mag niet gewijzigd worden
'		AdoInsertToRecord(TABLE_VARIOUS, VB6.Format(Versneld.CheckState, "0"), "v086")
'		AdoInsertToRecord(TABLE_VARIOUS, (TekstInfo(4).Text), "v087")
'		AdoInsertToRecord(TABLE_VARIOUS, (TekstInfo(5).Text), "v088")
'		AdoInsertToRecord(TABLE_VARIOUS, "18" & AdoGetField(TABLE_VARIOUS, "#v087 #"), "v005")
'		MSG = "Informatielijn opslaan..." & vbCrLf
'		MSG = MSG & "Bent U zeker ?"
'		Ktrl2 = MsgBox(MSG, 292, "Fiche bijwerken/wegschrijven")
'		If Ktrl2 = 6 Then
'			If NietAanwezig Then
'				JetInsert(TABLE_VARIOUS, 1)
'			Else
'				bUpdate(TABLE_VARIOUS, 1)
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
'					TekstInfo(Index).Text = Mid(GRIDTEXT, 1, 10)
'					Beep()
'				End If
'			Case 1, 8
'				TekstInfo(Index).Text = Dec(Val(TekstInfo(Index).Text), MASK_EURBH)
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