Public Class FrmSettingsFinancialYear
    Private Sub Afsluiten_Click(sender As Object, e As EventArgs) Handles Afsluiten.Click
        Close()
    End Sub

    Private Sub frmSetupBoekjaar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class SetupEnParameters
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'


'	Private Sub Afsluiten_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Afsluiten.Click

'		Me.Close()

'	End Sub

'	Private Sub SetupEnParameters_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

'		If Not Toegankelijk(Me) Then
'			Me.Close()
'			Exit Sub
'		End If

'		Top = 0
'		Left = 0

'	End Sub


'	Private Function TeleBibDEF(ByRef TeZoeken As String) As Short
'		Dim FlInput As Short
'		Dim T As Short
'		Dim LokatieString As String

'		TeleBibDEF = False

'		On Error GoTo TeleBibError

'		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		If Dir(ProgramLocation & "Def\" & "099.Def") = "" Then
'			MsgBox("Geen TeleBib definitie 099.Def")
'			Exit Function
'		End If

'		FlInput = FreeFile
'		FileOpen(FlInput, ProgramLocation & "Def\" & "099.Def", OpenMode.Input)
'		Do While Not EOF(FlInput)
'			LokatieString = LineInput(FlInput)
'			If LokatieString = TeZoeken Then
'				Exit Do
'			End If
'		Loop 
'		If LokatieString <> TeZoeken Then
'			Exit Function
'		End If

'		T = 0
'		Do While Not EOF(FlInput)
'			Input(FlInput, TeleBibCode(T))
'			Input(FlInput, TeleBibTekst(T))
'			Input(FlInput, TeleBibType(T))
'			Input(FlInput, TeleBibLengte(T))
'			If VB.Left(TeleBibCode(T), 1) = ";" Then
'				Exit Do
'			Else
'				T = T + 1
'			End If
'		Loop 
'		FileClose(FlInput)
'		TeleBibCode(T) = ""
'		TeleBibDEF = True
'		Exit Function

'TeleBibError: 
'		MsgBox("VSBibinlaadfout" & Str(T) & " error:" & ErrorToString())
'		FileClose(FlInput)
'		TeleBibDEF = False
'		Exit Function
'		Resume 

'	End Function

'	'UPGRADE_ISSUE: OptionButton event SetupOption.DblClick was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
'	Private Sub SetupOption_DblClick(ByRef Index As Short)

'		Wijzigen_Click(Me, New System.EventArgs())

'	End Sub

'	Private Sub Wijzigen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Wijzigen.Click
'		Dim T As Short
'		Dim aa As String
'		Dim CrText As String
'		Dim CrText2 As String
'		Dim BoxMask As String
'		Dim BoxType As Short

'		For CountTo = 0 To 8
'			If SetupOption(CountTo).Checked = True Then
'				Exit For
'			End If
'		Next 

'		If TeleBibDEF(";" & SetupOption(CountTo).Text) Then
'		Else
'			Beep()
'			MsgBox("Definitiebestand 099.DEF defekt ?")
'			Exit Sub
'		End If

'		Xlog.Close()
'		'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
'		Load(Xlog)
'		Xlog.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Xlog.Height) + 3)
'		Xlog.X.Rows = 1
'		Xlog.X.Cols = 3

'		aa = ""
'		T = 0
'		Do While TeleBibCode(T) <> Space(10)
'			JetGet(TableOfCounters, 0, Mid(TeleBibCode(T), 5, 5))
'			If Ktrl Then
'				CrText = ""
'			Else
'				RecordToField(TableOfCounters)
'				'CrText = ntRS(TableOfCounters).Fields("v217")
'				CrText = rsMAR(TableOfCounters).Fields("v217").Value
'				Select Case Mid(TeleBibCode(T), 2, 2)
'					Case "  ", "K ", "L ", "LC", "R ", "R3", "R4", "R6", "R7"
'						'niks
'					Case Else
'						Select Case Mid(TeleBibCode(T), 1, 1)
'							Case " "
'								BoxMask = "00"
'								BoxType = 0
'							Case "0" To "9"
'								BoxMask = "000"
'								BoxType = 1
'						End Select
'						If VB.Left(TeleBibCode(T), 1) = "@" Or CrText = "" Then
'						Else
'							CrText = fmarBoxText(VB6.Format(Val(Mid(TeleBibCode(T), 1, 3)), BoxMask), "2", CrText) 'hier eventueel taaloptie
'						End If
'				End Select
'			End If
'			aa = TeleBibCode(T) & vbTab & TeleBibTekst(T) & vbTab & CrText
'			T = T + 1
'			Xlog.X.AddItem(aa)
'		Loop 

'		Xlog.X.Col = 0
'		Xlog.X.Row = 0
'		Xlog.X.Text = "vsfKode"
'		Xlog.X.Col = 1
'		Xlog.X.Text = "Veldomschrijving"
'		Xlog.X.Col = 2
'		Xlog.X.Text = "Veldgegevens"

'		Xlog.X.Row = 1
'		Xlog.X.Col = 0

'		Xlog.X.set_ColWidth(0, 960)
'		Xlog.X.set_ColWidth(1, 3405)
'		Xlog.X.set_ColWidth(2, 4395)

'		Xlog.X.set_ColAlignment(0, MSFlexGridLib.AlignmentSettings.flexAlignLeftTop)
'		Xlog.X.set_ColAlignment(1, MSFlexGridLib.AlignmentSettings.flexAlignLeftTop)
'		Xlog.X.set_ColAlignment(2, MSFlexGridLib.AlignmentSettings.flexAlignLeftTop)

'XLogShow: 
'		VB6.SetDefault(Xlog.WijzigenLijn, True)
'		Xlog.Afsluiten.TabStop = True
'		XLogKey = ""
'		Xlog.SSTab1.TabPages.Item(1).Visible = False
'		Xlog.ShowDialog()
'		If XLogKey <> "" Then
'			Msg = "Boekjaarparameters overschrijven.  Bent U zeker ?"
'			KtrlBox = MsgBox(Msg, 292)
'			If KtrlBox = 6 Then
'				T = 0
'				Xlog.X.Col = 2
'				Do While TeleBibCode(T) <> Space(10)
'					Xlog.X.Row = T + 1
'					CrText2 = Xlog.X.Text
'					JetGet(TableOfCounters, 0, Mid(TeleBibCode(T), 5, 5))
'					If Ktrl Then
'						TLBRecord(TableOfCounters) = ""
'						AdoInsertToRecord(TableOfCounters, Mid(TeleBibCode(T), 5, 5), "v071")
'					Else
'						RecordToField(TableOfCounters)
'					End If

'					Select Case Mid(TeleBibCode(T), 2, 2)
'						Case "  "
'						Case Else
'							If VB.Left(TeleBibCode(T), 1) = "@" Then
'							Else
'								On Error Resume Next
'								CrText2 = VB.Left(CrText2, InStr(CrText2, ":") - 1)
'								On Error GoTo 0
'							End If
'					End Select
'					AdoInsertToRecord(TableOfCounters, CrText2, "v217")
'					If Ktrl Then
'						JetInsert(TableOfCounters, 0)
'					Else
'						bUpdate(TableOfCounters, 0)
'					End If
'					T = T + 1
'				Loop 
'				Afsluiten.Focus()
'			End If
'		End If

'	End Sub
'End Class