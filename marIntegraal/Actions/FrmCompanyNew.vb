Public Class FrmCompanyNew
    Private Sub Negeren_Click(sender As Object, e As EventArgs) Handles Negeren.Click
        Mim.CompanyOpenMenuItem.Enabled = True
        Mim.CompanyNewMenuItem.Enabled = True
        Close()
    End Sub

    Private Sub frmNieuwBedrijf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class NieuwBedrijf
'	Inherits System.Windows.Forms.Form
'	'UPGRADE_NOTE: DefInt A-Z statement was removed. Variables were explicitly declared as type Short. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'

'	Dim BedrijfsNummer As String
'	Dim Van As String

'	Dim FlN As Short

'	Private Sub Bedrijfsnaam_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Bedrijfsnaam.KeyPress
'		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

'		If KeyAscii = 13 Then System.Windows.Forms.SendKeys.Send("{TAB}")

'		eventArgs.KeyChar = Chr(KeyAscii)
'		If KeyAscii = 0 Then
'			eventArgs.Handled = True
'		End If
'	End Sub

'	Private Function InstallTellers() As Short

'		'Boekingen en algemene instellingen
'		SS99("EUR", 296)
'		SS99(VB.Left(CmbBedrijfsType.Text, 1), 20)
'		SS99("2", 299)
'		SS99("3", 183)
'		SS99("2", 200)
'		SS99("1", 201)
'		SS99("2", 290)
'		SS99("1", 21)

'		'Aankoopverrichtingen
'		SS99("00000", 1)
'		SS99("00000", 2)
'		SS99("00000", 3)
'		SS99("00000", 4)
'		SS99("00000", 15)
'		SS99("00000", 205)

'		'Verkoopverrichtingen
'		SS99("00000", 11)
'		SS99("00000", 12)
'		SS99("00000", 13)
'		SS99("00000", 14)
'		SS99("00000", 73)
'		SS99("00000", 59)
'		SS99("00000", 121)
'		SS99("2", 53)
'		SS99("0", 54)
'		SS99("1001", 181)
'		SS99("1", 182)
'		SS99("11", 185)
'		SS99("000", 186)
'		SS99("0", 187)
'		SS99("00000", 188)
'		SS99("1", 202)
'		SS99("1", 203)
'		SS99("2", 72)
'		SS99("1", 74)
'		SS99("1", 75)
'		SS99("1", 76)
'		SS99("0000.00", 300)

'		'BTW Default Rekeningen
'		SS99("498054", 16)
'		SS99("498055", 17)
'		SS99("498056", 18)
'		SS99("498057", 19)
'		SS99("498059", 22)
'		SS99("498063", 23)
'		SS99("498064", 24)
'		SS99("704000", 25)
'		SS99("604000", 77)
'		SS99("704100", 78)
'		SS99("340000", 79)

'		'Default Collectieve Rekeningen
'		SS99("400000", 9)
'		SS99("440000", 10)
'		SS99("4000", 297)
'		SS99("4400", 298)
'		SS99("756000", 27)
'		SS99("656000", 28)
'		SS99("489000", 145)
'		SS99("455", 146)
'		SS99("4899999", 147)
'		SS99("18", 148)
'		SS99("2999999", 149)
'		SS99("60", 150)
'		SS99("6089999", 151)
'		SS99("61", 152)
'		SS99("6559999", 153)

'		'Financieel en Rekeningen
'		SS99("571000", 41)
'		SS99(" 0", 31)
'		SS99("561000", 42)
'		SS99(" 0", 32)
'		SS99("551000", 43)
'		SS99(" 0", 33)
'		SS99("552000", 44)
'		SS99(" 0", 34)
'		SS99("553000", 45)
'		SS99(" 0", 35)
'		SS99("582000", 39)
'		SS99(" 0", 38)
'		SS99("5540000", 211)
'		SS99(" 0", 215)
'		SS99("5550000", 212)
'		SS99(" 0", 216)
'		SS99("5560000", 213)
'		SS99(" 0", 217)
'		SS99("5570000", 214)
'		SS99(" 0", 218)
'		SS99("551000", 101)

'		'Bedrijfsinformatie
'		SS99("Bvba MijnBedrijf", 46)
'		SS99("MijnStraatEnNummer", 47)
'		SS99("PCPC MijnWoonplaats", 48)
'		SS99("MijnHandelsRegister", 50)
'		SS99("000.000.000", 51)
'		SS99("000-0000000-00", 52)

'		'Status Boekjaar
'		SS99("0", 62)
'		SS99("0", 63)
'		SS99("0", 64)

'		'Kassaverkoop
'		SS99("OFF", 130)
'		SS99("1", 131)
'		SS99("0", 132)

'	End Function

'	Private Sub Boekjaar_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Boekjaar.Leave

'		If Val(Boekjaar.Text) < 2020 And Val(Boekjaar.Text) > 2016 Then
'			'ok
'		Else
'			Boekjaar.Text = VB.Right(MimGlobalDate.Value, 4)
'			Boekjaar.Focus()
'			Beep()
'		End If

'	End Sub


'	Private Sub Drive1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Drive1.SelectedIndexChanged
'		Dim A As String

'		Err.Clear()
'		On Error Resume Next
'		'ChDrive Left(Drive1.Drive, 1)
'		If Err.Number Then MsgBox(ErrorToString() & vbCrLf & vbCrLf & "Kontroleer eerst a.u.b. !") : Exit Sub
'		Mid(Location, 1, 2) = Mid(Drive1.Drive, 1, 2)
'		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		A = Dir(Location & "*.*")
'		If Err.Number Then MsgBox(ErrorToString() & vbCrLf & vbCrLf & "Kontroleer eerst a.u.b. !") : Exit Sub
'		If A = "" Then MsgBox("Kontroleer eerst het opslagmedium a.u.b. via bedrijf openen !") : Exit Sub

'		BedrijfsNummer = VolgendBedrijf()
'		Me.Text = "Nieuw Bedrijf (" & BedrijfsNummer & ")"
'		'ChDrive Left(SysVar(0), 2)
'		'ChDir SysVar(0)
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal

'	End Sub

'	Private Sub NieuwBedrijf_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
'		Dim StatusPosition As Short

'		If Not Toegankelijk(Me) Then
'			Me.Close()
'			Exit Sub
'		End If

'		Top = 0
'		Left = 0

'		BedrijfOpenen.Close()
'		Boekjaar.Text = CStr(CDbl(VB.Right(MimGlobalDate.Value, 4)) + 1)
'		StatusPosition = 0

'		BedrijfsNummer = VolgendBedrijf()
'		Me.Text = "Nieuw Bedrijf (" & BedrijfsNummer & ")"

'		CmbBedrijfsType.Items.Add("0: Standaard KMO")
'		CmbBedrijfsType.Items.Add("1: marIntegraal NT Light")
'		CmbBedrijfsType.Items.Add("2: Garage met Margeverkoop")
'		CmbBedrijfsType.Items.Add("3: Auteursrechtadministratie")
'		CmbBedrijfsType.Items.Add("4: Forfaitaire BTW")
'		CmbBedrijfsType.Items.Add("5: Verzekeringsbemiddelaar")
'		CmbBedrijfsType.Items.Add("6: Syndicus administratie")
'		CmbBedrijfsType.Items.Add("9: Gezinshuishouding")
'		CmbBedrijfsType.SelectedIndex = 0

'		TableDefOnt(TableOfCounters) = "00.ONT" '09
'		JetTableName(TableOfCounters) = "jr" & Me.Boekjaar.Text

'	End Sub

'	Private Sub Installeren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Installeren.Click
'		Dim dialogCaption As String
'		Dim destpath As String
'		Dim T As Short
'		Dim X As Short
'		Dim TotalNeeded As Integer
'		Dim A As String

'		BAModus = 1
'		Van = Me.txtStartMaand.Text & "/" & Boekjaar.Text
'		A = "Installatie Bedrijf " & BedrijfsNummer & " voor :" & vbCrLf & vbCrLf & BedrijfsNaam.Text & vbCrLf & vbCrLf & VB6.Format(Val(Maanden.Text), "00") & " maanden vanaf : " & Van
'		If Makelaar.CheckState Then
'			A = A & vbCrLf & vbCrLf & "Met programmakeuze voor makelaars !"
'		End If
'		Ktrl = MsgBox(A, 292)

'		If Not Ktrl = 6 Then
'			Exit Sub
'		End If

'		TotalNeeded = 38024
'		destpath = Location & BedrijfsNummer
'		If Not CreatePath(destpath) Then
'			MsgBox("foutmelding bij aanmaak " & destpath)
'		End If

'		LocationCompanyData = Location & BedrijfsNummer & "\"

'		PeriodesMaken()
'		LabelMaken()
'		If Not CopyFile(My.Application.Info.DirectoryPath & "\Def", destpath, "LICMARNT.###") Then GoTo ErrorSetup
'		If Not CopyFile(My.Application.Info.DirectoryPath & "\Def", destpath, "DOK11.TXT") Then GoTo ErrorSetup
'		If Not CopyFile(My.Application.Info.DirectoryPath & "\Def", destpath, "DOK12.TXT") Then GoTo ErrorSetup
'		If Not CopyFile(My.Application.Info.DirectoryPath & "\Def", destpath, "DOK13.TXT") Then GoTo ErrorSetup
'		If Not CopyFile(My.Application.Info.DirectoryPath & "\Def", destpath, "DOK14.TXT") Then GoTo ErrorSetup
'		If Not CopyFile(My.Application.Info.DirectoryPath & "\Def", destpath, "DOK21.TXT") Then GoTo ErrorSetup
'		If Not CopyFile(My.Application.Info.DirectoryPath & "\Def", destpath, "DOK22.TXT") Then GoTo ErrorSetup
'		If Not CopyFile(My.Application.Info.DirectoryPath & "\Def", destpath, "DOK23.TXT") Then GoTo ErrorSetup
'		If Not CopyFile(My.Application.Info.DirectoryPath & "\Def", destpath, "DOK24.TXT") Then GoTo ErrorSetup
'		If Not CopyFile(My.Application.Info.DirectoryPath, destpath, "MARNT.MDV") Then GoTo ErrorSetup



'		jetConnect = adoJetProvider & "Data Source=" & LocationCompanyData & "\marnt.mdv;" & "Persist Security Info=False"

'		On Error Resume Next
'		JetTableClose(99)

'		Dim cat As New ADOX.Catalog
'		Dim tbl As New ADOX.Table
'		Dim Idx As New ADOX.Index

'		'Open the catalog.
'		cat.let_ActiveConnection(jetConnect)
'		JetTableName(TableOfCounters) = "jr" & Me.Boekjaar.Text

'		tbl.Name = JetTableName(TableOfCounters)
'		tbl.Columns.Append("v071", ADOX.DataTypeEnum.adVarWChar, 5)
'		tbl.Columns.Append("v217", ADOX.DataTypeEnum.adVarWChar, 30)

'		' Define an index
'		With Idx
'			.Name = "Setup Parameter"
'			.Columns.Append("v071")
'			.PrimaryKey = False
'			.Unique = True
'		End With
'		' Append the index to the table
'		tbl.Indexes.Append(Idx)

'		cat.Tables.Append(tbl)
'		cat.Tables.Refresh()
'		'UPGRADE_NOTE: Object cat may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
'		cat = Nothing
'		'UPGRADE_NOTE: Object tbl may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
'		tbl = Nothing
'		'UPGRADE_NOTE: Object Idx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
'		Idx = Nothing

'		On Error GoTo 0
'		adntDB = New ADODB.Connection

'		adntDB.Open(jetConnect)
'		ntDB = NTRuimte.OpenDatabase(LocationCompanyData & "marnt.MDV", False, False)
'		X = InitTables
'		X = InstallTellers
'		JetTableClose(99)
'		adntDB.Close()
'		'UPGRADE_NOTE: Object adntDB may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
'		adntDB = Nothing
'		Negeren_Click(Negeren, New System.EventArgs())

'ExitSetup: 
'		Me.Close()
'		Exit Sub

'ErrorSetup: 
'		MsgBox("Installatie nieuw bedrijf zonder succes.  Raadpleeg R&&VSOFT.", 48, dialogCaption)
'		Me.Close()
'		Exit Sub

'	End Sub

'	Private Sub LabelMaken()

'		FlN = FreeFile
'		FileOpen(FlN, Location & BedrijfsNummer & "/marnt.txt", OpenMode.Output)
'		PrintLine(FlN, BedrijfsNaam.Text)
'		FileClose(FlN)

'	End Sub

'	Private Sub Negeren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Negeren.Click

'		Me.Close()

'	End Sub



'	Private Sub PeriodesMaken()
'		Dim t2 As Short
'		Dim VanafJaar As Short
'		Dim VanafMaand As Short
'		Dim aantalmaanden As Short
'		Dim b As New VB6.FixedLengthString(16)
'		Dim A As New VB6.FixedLengthString(4)
'		Dim T As Short

'		aantalmaanden = Val(Maanden.Text)
'		VanafMaand = Val(Mid(Van, 4, 2))
'		VanafJaar = Val(VB.Right(Van, 4))

'		Fl = FreeFile
'		FileOpen(Fl, ProgramLocation & "9999.oct", OpenMode.Random, , , 4)
'		A.Value = "0"
'		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		FilePut(Fl, A.Value, 1)
'		A.Value = VB.Right(Van, 4)
'		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		FilePut(Fl, A.Value, 2)
'		A.Value = "1"
'		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		FilePut(Fl, A.Value, 3)
'		FileClose(Fl)

'		Fl = FreeFile
'		FileOpen(Fl, Location & BedrijfsNummer & "/def00.oct", OpenMode.Random, , , 16)
'		For T = 1 To aantalmaanden
'			b.Value = VB6.Format(VanafJaar, "0000") & VB6.Format(VanafMaand, "00") & "01" & VB6.Format(VanafJaar, "0000") & VB6.Format(VanafMaand, "00") & VB6.Format(DaysInAMonth(VanafMaand), "00")
'			If VanafMaand = 12 And T < aantalmaanden Then
'				VanafMaand = 1
'				VanafJaar = VanafJaar + 1
'			Else
'				VanafMaand = VanafMaand + 1
'			End If
'			'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			FilePut(Fl, b.Value, T)
'		Next T
'		b.Value = ""

'		For t2 = T To 99
'			'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			FilePut(Fl, b.Value, t2)
'		Next 
'		b.Value = VB6.Format(VanafJaar, "0000") & VB6.Format(VanafMaand - 1, "00") & VB6.Format(DaysInAMonth(VanafMaand - 1), "00") & VB6.Format(VanafJaar, "0000") & VB6.Format(VanafMaand - 1, "00") & VB6.Format(DaysInAMonth(VanafMaand - 1), "00")
'		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		FilePut(Fl, b.Value, 99)
'		FileClose(Fl)

'	End Sub

'	Private Function VolgendBedrijf() As String
'		Dim Aanwezig(99) As String
'		Dim T As Short
'		Dim t2 As Short
'		Dim EerstVolgendIs As String

'		On Error GoTo 0

'		For T = 1 To 999
'			On Error Resume Next
'			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'			EerstVolgendIs = Dir(Location & VB6.Format(T, "000") & "\")
'			If Err.Number = 76 Or EerstVolgendIs = "" Then
'				VolgendBedrijf = VB6.Format(T, "000")
'				Exit Function
'			End If
'		Next 
'		MsgBox("Stop")
'		VolgendBedrijf = "000"

'	End Function

'	Private Sub txtStartMaand_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtStartMaand.Leave

'		If Len(txtStartMaand.Text) <> 5 Then MsgBox("Enkel formaat dd/mm gebruiken a.u.b.") : Me.txtStartMaand.Text = "01/04" : Me.txtStartMaand.Focus() : Exit Sub
'		If Mid(txtStartMaand.Text, 3, 1) = "/" Then
'		Else
'			MsgBox("Enkel formaat dd/mm gebruiken a.u.b.") : Me.txtStartMaand.Text = "01/04" : Me.txtStartMaand.Focus() : Exit Sub
'		End If

'	End Sub

'	'UPGRADE_WARNING: Event TypeBoekjaar.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
'	Private Sub TypeBoekjaar_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TypeBoekjaar.CheckedChanged
'		If eventSender.Checked Then
'			Dim Index As Short = TypeBoekjaar.GetIndex(eventSender)

'			Select Case Index
'				Case 0
'					Me.txtStartMaand.Text = "01/01"
'					Me.txtStartMaand.Enabled = False
'				Case 1
'					Me.txtStartMaand.Text = "01/07"
'					Me.txtStartMaand.Enabled = False
'				Case 2
'					Me.txtStartMaand.Text = "01/10"
'					Me.txtStartMaand.Enabled = False
'				Case 3
'					Van = "01/04/" & Boekjaar.Text
'					Me.txtStartMaand.Text = "01/04"
'					Me.txtStartMaand.Enabled = True
'					Me.txtStartMaand.Focus()
'			End Select

'		End If
'	End Sub
'End Class