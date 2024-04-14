Public Class frmVerkoopSjabloon
    Private Sub frmVerkoopSjabloon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class SjabloonIO
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Private Sub Annuleren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Annuleren.Click

'		GRIDTEXT = ""
'		Me.Close()

'	End Sub

'	Private Sub SjabloonIO_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

'		SoortSjabloon(1).Checked = True

'	End Sub

'	Private Sub Invoegen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Invoegen.Click
'		Dim FlX As Short
'		Dim MSG As String
'		Dim BsType As New VB6.FixedLengthString(7)
'		Dim BsTekst As String
'		Dim GridIO As String

'		If VB.Right(SjabloonLijst.Text, 40) = Space(40) Then
'			Beep()
'			Exit Sub
'		End If
'		MSG = "'" & VB.Right(SjabloonLijst.Text, 40) & "'" & vbCrLf & vbCrLf
'		MSG = MSG & "Kies Ja  om enkel bij te voegen." & vbCrLf
'		MSG = MSG & "Kies Nee om bestaande invoer te overschrijven !" & vbCrLf
'		MSG = MSG & "Cancel of ESC voor nieuwe selectie..."
'		KTRL = MsgBox(MSG, 3, "Sjabloon invoegen")
'		Select Case KTRL
'			Case 2
'				Exit Sub
'			Case 7
'				GRIDTEXT = ""
'		End Select

'		Select Case SoortSjabloon(0).Checked
'			Case True
'				BsType.Value = "A999999"
'			Case Else
'				BsType.Value = "K" & VB.Left(FVT(TABLE_CUSTOMERS, 0), 6)
'		End Select

'		FlX = FreeFile
'		FileOpen(FlX, LOCATION_COMPANYDATA & BsType.Value & VB.Left(SjabloonLijst.Text, 1) & ".SJB", OpenMode.Input)
'		BsTekst = LineInput(FlX)
'		Do While Not EOF(FlX)
'			BsTekst = LineInput(FlX)
'			GRIDTEXT = GRIDTEXT & BsTekst & Chr(13)
'		Loop 
'		FileClose(FlX)
'		Me.Close()

'	End Sub

'	'UPGRADE_WARNING: Event SjabloonLijst.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub SjabloonLijst_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SjabloonLijst.SelectedIndexChanged

'		TekstInfo(0).Text = VB.Right(SjabloonLijst.Text, 40)
'		Invoegen.Enabled = True

'	End Sub

'	Private Sub SjabloonLijst_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SjabloonLijst.DoubleClick

'		Invoegen_Click(Invoegen, New System.EventArgs())

'	End Sub

'	'UPGRADE_WARNING: Event SoortSjabloon.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub SoortSjabloon_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SoortSjabloon.CheckedChanged
'		If eventSender.Checked Then
'			Dim Index As Short = SoortSjabloon.GetIndex(eventSender)
'			Dim BsType As New VB6.FixedLengthString(7)
'			Dim BsTekst As New VB6.FixedLengthString(40)
'			Dim T As Short
'			Dim FlX As Short

'			Do While SjabloonLijst.Items.Count > 0
'				SjabloonLijst.Items.RemoveAt(0)
'			Loop 

'			Select Case Index
'				Case 0
'					BsType.Value = "A999999"
'				Case Else
'					BsType.Value = "K" & VB.Left(FVT(TABLE_CUSTOMERS, 0), 6)
'			End Select

'			For T = 0 To 9
'				'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'				If Dir(LOCATION_COMPANYDATA & BsType.Value & VB6.Format(T, "0") & ".SJB") = "" Then
'					SjabloonLijst.Items.Add(VB6.Format(T, "0") & ": " & Space(40))
'				Else
'					FlX = FreeFile
'					FileOpen(FlX, LOCATION_COMPANYDATA & BsType.Value & VB6.Format(T, "0") & ".SJB", OpenMode.Input)
'					Input(FlX, BsTekst.Value)
'					FileClose(FlX)
'					SjabloonLijst.Items.Add(VB6.Format(T, "0") & ": " & BsTekst.Value)
'				End If
'			Next 
'			SjabloonLijst.SelectedIndex = 0

'		End If
'	End Sub

'	'UPGRADE_WARNING: Event TekstInfo.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub TekstInfo_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.TextChanged
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)

'		Invoegen.Enabled = False

'	End Sub

'	Private Sub Wegschrijven_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Wegschrijven.Click
'		Dim LeftPos As Short
'		Dim FlX As Short
'		Dim MSG As String
'		Dim BsType As New VB6.FixedLengthString(7)
'		Dim BsTekst As New VB6.FixedLengthString(40)
'		Dim GridIO As String

'		BsTekst.Value = TekstInfo(0).Text

'		MSG = "'" & BsTekst.Value & "'" & vbCrLf & vbCrLf
'		MSG = MSG & "Wegschrijven, bent U zeker ?"
'		KTRL = MsgBox(MSG, 292)
'		If KTRL = 6 Then
'		Else
'			Exit Sub
'		End If

'		Select Case SoortSjabloon(0).Checked
'			Case True
'				BsType.Value = "A999999"
'			Case Else
'				BsType.Value = "K" & VB.Left(FVT(TABLE_CUSTOMERS, 0), 6)
'		End Select

'		FlX = FreeFile
'		FileOpen(FlX, LOCATION_COMPANYDATA & BsType.Value & VB.Left(SjabloonLijst.Text, 1) & ".SJB", OpenMode.Output)
'		PrintLine(FlX, BsTekst.Value)
'		Do While GRIDTEXT <> ""
'			LeftPos = InStr(GRIDTEXT, Chr(13))
'			If LeftPos <= 1 Then
'				GRIDTEXT = ""
'				Exit Do
'			End If
'			Print(FlX, VB.Left(GRIDTEXT, InStr(GRIDTEXT, Chr(13)) - 1) & vbCrLf)
'			GRIDTEXT = VB.Right(GRIDTEXT, Len(GRIDTEXT) - LeftPos)
'		Loop 
'		FileClose(FlX)
'		GRIDTEXT = ""
'		Me.Close()

'	End Sub
'End Class