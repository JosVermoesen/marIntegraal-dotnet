Public Class frmBetalingsPInput
    Private Sub frmBetalingsPInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class BoekKwijtingEdit
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Private Sub Annuleren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Annuleren.Click

'		GRIDTEXT = "ESC"
'		Me.Close()

'	End Sub

'	Private Sub BoekKwijtingEdit_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
'		Dim astring As String

'		CType(KwijtingBoeken.Controls("PolisDetail"), Object).Col = 0
'		TekstInfo(0).Text = CType(KwijtingBoeken.Controls("PolisDetail"), Object).Text
'		CType(KwijtingBoeken.Controls("PolisDetail"), Object).Col = 1
'		If CType(KwijtingBoeken.Controls("PolisDetail"), Object).Text = "" Then
'			TekstInfo(2).Text = CType(KwijtingBoeken.Controls("TekstInfo"), Object)(0).Text
'		Else
'			TekstInfo(2).Text = CType(KwijtingBoeken.Controls("PolisDetail"), Object).Text
'		End If
'		CType(KwijtingBoeken.Controls("PolisDetail"), Object).Col = 2
'		TekstInfo(3).Text = CType(KwijtingBoeken.Controls("PolisDetail"), Object).Text
'		CType(KwijtingBoeken.Controls("PolisDetail"), Object).Col = 3
'		TekstInfo(4).Text = CType(KwijtingBoeken.Controls("PolisDetail"), Object).Text
'		CType(KwijtingBoeken.Controls("PolisDetail"), Object).Col = 4
'		TekstInfo(1).Text = CType(KwijtingBoeken.Controls("PolisDetail"), Object).Text
'		CType(KwijtingBoeken.Controls("PolisDetail"), Object).Col = 6
'		TekstInfo(5).Text = CType(KwijtingBoeken.Controls("PolisDetail"), Object).Text

'	End Sub

'	Private Sub Ok_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Ok.Click
'		Dim VeldPolis As New VB6.FixedLengthString(12)

'		Dim astring As String
'		If Val(TekstInfo(3).Text) + Val(TekstInfo(4).Text) = 0 Then
'			Beep()
'		Else

'			CType(KwijtingBoeken.Controls("PolisDetail"), Object).Col = 0
'			CType(KwijtingBoeken.Controls("PolisDetail"), Object).Text = TekstInfo(0).Text
'			CType(KwijtingBoeken.Controls("PolisDetail"), Object).Col = 1
'			CType(KwijtingBoeken.Controls("PolisDetail"), Object).Text = TekstInfo(2).Text
'			CType(KwijtingBoeken.Controls("PolisDetail"), Object).Col = 2
'			CType(KwijtingBoeken.Controls("PolisDetail"), Object).Text = TekstInfo(3).Text
'			CType(KwijtingBoeken.Controls("PolisDetail"), Object).Col = 3
'			CType(KwijtingBoeken.Controls("PolisDetail"), Object).Text = TekstInfo(4).Text
'			CType(KwijtingBoeken.Controls("PolisDetail"), Object).Col = 4
'			CType(KwijtingBoeken.Controls("PolisDetail"), Object).Text = TekstInfo(1).Text
'			CType(KwijtingBoeken.Controls("PolisDetail"), Object).Col = 5
'			If CType(KwijtingBoeken.Controls("PolisDetail"), Object).Text = "" Then
'				CType(KwijtingBoeken.Controls("PolisDetail"), Object).Text = "TODO: XML/TB2 retourblok importeren"
'			End If
'			CType(KwijtingBoeken.Controls("PolisDetail"), Object).Col = 6
'			CType(KwijtingBoeken.Controls("PolisDetail"), Object).Text = TekstInfo(5).Text

'			With CType(KwijtingBoeken.Controls("PolisDetail"), Object)
'				'.SelStartCol = 0
'				'.SelEndCol = 4
'				'.SelStartRow = .Row
'				'.SelEndRow = .Row
'			End With

'			GRIDTEXT = "OK"
'			Me.Close()
'		End If

'	End Sub

'	Private Sub TekstInfo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.Enter
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		TekstInfo(Index).SelectionLength = Len(TekstInfo(Index).Text)

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

'		If Index = 1 Then
'			If KeyCode = 17 Then
'				SHARED_FL = TABLE_CUSTOMERS
'				A_INDEX = 1
'				GRIDTEXT = TekstInfo(1).Text
'				SqlSearch.ShowDialog()
'				If KTRL Then
'					TekstInfo(1).Text = "-"
'					CType(KwijtingEdit.Controls("Ok"), Object).Enabled = False
'					Exit Sub
'				Else
'					RecordToField(TABLE_CUSTOMERS)
'					TekstInfo(1).Text = AdoGetField(TABLE_CUSTOMERS, "#A100 #")
'					JetGet(TABLE_CONTRACTS, 1, AdoGetField(TABLE_CUSTOMERS, "#A110 #"))
'					If KTRL Or SetSpacing(KEY_BUF(TABLE_CONTRACTS), 12) <> SetSpacing(AdoGetField(TABLE_CUSTOMERS, "#A110 #"), 12) Then
'						MsgBox("Geen polissen voor deze klant te vinden !!")
'						TekstInfo(1).Text = "-"
'						CType(KwijtingEdit.Controls("Ok"), Object).Enabled = False
'						Exit Sub
'					Else
'						Do 
'							RecordToField(TABLE_CONTRACTS)
'							If VB.Left(CType(KwijtingBoeken.Controls("KeuzeInfo"), Object)(0).Text, 4) = AdoGetField(TABLE_CONTRACTS, "#A010 #") Then
'								MSG = "Boeking voor polisnummer : " & AdoGetField(TABLE_CONTRACTS, "#A000 #") & vbCrLf & vbCrLf
'								MSG = MSG & AdoGetField(TABLE_CONTRACTS, "#vs99 #") & vbCrLf
'								MSG = MSG & AdoGetField(TABLE_CONTRACTS, "#vs98 #") & vbCrLf & vbCrLf
'								MSG = MSG & "Bent U zeker ?"
'								CTRL_BOX = MsgBox(MSG, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2)
'								If CTRL_BOX = MsgBoxResult.Yes Then
'									TekstInfo(0).Text = AdoGetField(TABLE_CONTRACTS, "#A000 #")
'									TekstInfo(0).Focus()
'									Exit Do
'								End If
'							End If
'							bNext(TABLE_CONTRACTS)
'							If KTRL Or SetSpacing(KEY_BUF(TABLE_CONTRACTS), 12) <> SetSpacing(AdoGetField(TABLE_CUSTOMERS, "#A110 #"), 12) Then
'								MsgBox("Geen polissen meer voor deze klant te vinden !!")
'								TekstInfo(1).Text = "-"
'								CType(KwijtingEdit.Controls("Ok"), Object).Enabled = False
'								Exit Do
'							End If
'						Loop 
'					End If
'				End If
'			End If
'		End If

'	End Sub

'	Private Sub TekstInfo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.Leave
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		Select Case Index
'			Case 0
'				JetGet(TABLE_CONTRACTS, 0, SetSpacing(TekstInfo(0).Text, 12))
'				If KTRL Then
'					CType(KwijtingEdit.Controls("Ok"), Object).Enabled = False
'					TekstInfo(1).Focus()
'					TekstInfo(0).Text = ""
'					Exit Sub
'				Else
'					RecordToField(TABLE_CONTRACTS)
'					If VB.Left(CType(KwijtingBoeken.Controls("KeuzeInfo"), Object)(0).Text, 4) = AdoGetField(TABLE_CONTRACTS, "#A010 #") Then
'						TekstInfo(0).Text = AdoGetField(TABLE_CONTRACTS, "#A000 #")
'						JetGet(TABLE_CUSTOMERS, 0, AdoGetField(TABLE_CONTRACTS, "#A110 #"))
'						If KTRL Then
'							TekstInfo(1).Text = "KlantLink onmogelijk !!! Kontroleer !!!"
'							CType(KwijtingEdit.Controls("Ok"), Object).Enabled = False
'						Else
'							RecordToField(TABLE_CUSTOMERS)
'							TekstInfo(1).Text = AdoGetField(TABLE_CUSTOMERS, "#A100 #")
'							If VB.Left(CType(KwijtingBoeken.Controls("KeuzeInfo"), Object)(1).Text, 1) = "1" Then
'								'TekstInfo(2).Text = Format(Val(AdoGetField(TABLE_CONTRACTS, "#v165 #")), "00") + "/" + Format(Val(AdoGetField(TABLE_CONTRACTS, "#v164 #")), "00") + "/" + Right(KwijtingBoeken!TekstInfo(0).Text, 4)
'								TekstInfo(2).Text = VB6.Format(Val(AdoGetField(TABLE_CONTRACTS, "#v165 #")), "00") & "/" & VB.Right(CType(KwijtingBoeken.Controls("TekstInfo"), Object)(0).Text, 7)
'							Else
'								TekstInfo(2).Text = CType(KwijtingBoeken.Controls("TekstInfo"), Object)(0).Text 'Format(Val(AdoGetField(TABLE_CONTRACTS, "#v165 #")), "00") + "/" + Format(Val(AdoGetField(TABLE_CONTRACTS, "#v164 #")), "00") + "/" + Right(KwijtingBoeken!TekstInfo(0).Text, 4)
'							End If
'							Ok.Enabled = True
'						End If
'					Else
'						MsgBox("Maatschappij : " & VB.Left(CType(KwijtingBoeken.Controls("KeuzeInfo"), Object)(0).Text, 4) & " <> " & AdoGetField(TABLE_CONTRACTS, "#A010 #"))
'						TekstInfo(Index).Text = ""
'					End If
'				End If

'			Case 2
'				If DateWrongFormat(TekstInfo(2).Text) Then
'					TekstInfo(2).Text = CType(KwijtingBoeken.Controls("TekstInfo"), Object)(0).Text
'					Beep()
'					TekstInfo(2).Focus()
'				End If
'			Case 3, 4
'				If BH_EURO Then
'					TekstInfo(Index).Text = Dec(Val(TekstInfo(Index).Text), MASK_EUR)
'				Else
'					TekstInfo(Index).Text = Dec(Val(TekstInfo(Index).Text), MASK_BEF)
'				End If
'		End Select

'	End Sub
'End Class