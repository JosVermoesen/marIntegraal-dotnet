Option Strict Off
Option Explicit On
Imports System.ComponentModel
Imports System.Diagnostics.Eventing.Reader

Public Class SqlOperations
    Dim grdColWidth(20) As Short
    Dim allesGesloten As Boolean

    Dim datPrimaryRS As ADODB.Recordset
    Dim sqlDef As ADODB.Recordset

    Dim querySQL As String

    Private Function GetSqlDefRecordSet() As Boolean

        GetSqlDefRecordSet = False

        Dim sSQL As String

        sSQL = "SELECT * FROM Allerlei WHERE v005  Like '29%'"

        ' Create a recordset using the provided collection
        sqlDef = New ADODB.Recordset With {
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
        }
        sqlDef.Open(sSQL, adntDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        If sqlDef.RecordCount <= 0 Then
            'Message something
        Else
            GetSqlDefRecordSet = True
        End If
        msfSQL.DataSource = sqlDef

    End Function
    Private Sub SqlOperations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        datPrimaryRS = New ADODB.Recordset With {
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
        }

        allesGesloten = False
        Msg = "Moeten de tabellen gesloten worden (noodzakelijk om wijzigingen aan 'structuur' aan te brengen)"
        If MsgBox(Msg, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
            MsgBox("De bestanden worden gesloten.  U kan eveneens wijzigingen aan de structuur van tabellin in de database aanbrengen.  Het is aanbevolen straks het bedrijf opnieuw te openen", MsgBoxStyle.Information)
            allesGesloten = True
            JetTableClose(99)
        Else
            MsgBox("De bestanden worden niet gesloten.  U kan enkel de gegevens in de database bewerken.  U kan géén wijzigingen aan de structuur van tabellen in de database aanbrengen.", MsgBoxStyle.Information)
        End If

        Cursor.Current = Cursors.WaitCursor

        'With msfSQL
        '.Top = VB6.TwipsToPixelsY(5)
        '.Left = 0
        '.Height = VB6.TwipsToPixelsY(2175)
        '.Width = VB6.TwipsToPixelsX(6135)
        'End With
        AdoLoadDatabase()

        If GetSqlDefRecordSet() Then
        Else
            Msg = "SELECT TOP 6" & vbCrLf
            Msg = Msg & "    v019 AS RekNr," & vbCrLf
            Msg = Msg & "    v020 AS Omschrijving," & vbCrLf
            Msg = Msg & "    v022 AS [Boekjaar 0]," & vbCrLf
            Msg = Msg & "    v023 AS [Boekjaar -1]," & vbCrLf
            Msg = Msg & "    v024 AS [Boekjaar -2]," & vbCrLf
            Msg = Msg & "    v025 As [Boekjaar -3]" & vbCrLf
            Msg = Msg & "FROM" & vbCrLf
            Msg = Msg & "    Rekeningen" & vbCrLf
            Msg = Msg & "ORDER BY" & vbCrLf
            Msg = Msg & "    v020 DESC"
            TLBRecord(TableOfVarious) = ""
            AdoInsertToRecord(TableOfVarious, Msg, "v132")
            AdoInsertToRecord(TableOfVarious, "Query voorbeeld", "v250")
            AdoInsertToRecord(TableOfVarious, "29" & AdoGetField(TableOfVarious, "#v250 #"), "v005")
            JetInsert(TableOfVarious, 1)
            If Ktrl Then
                Stop
            Else
                GetSqlDefRecordSet()
            End If
        End If
        SelectComboVullen()
        CmdSQL_Click(cmdSQL, New System.EventArgs())

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub SqlOperations_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Mim.SQLOperationsMenuItem.Enabled = True

    End Sub

    Private Sub SqlOperations_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        '		On Error Resume Next
        '		datPrimaryRS.Close()
        '		'UPGRADE_NOTE: Object datPrimaryRS may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        '		datPrimaryRS = Nothing

        '		'hier nu eerst terug rsjournaal maken !!!!!
        '		If allesGesloten = True Then
        '			MsgBox("Bedrijfsdatabase wordt hierna automatisch afgesloten.", MsgBoxStyle.Information)
        '			AutoUnloadCompany()
        '			Exit Sub
        '		End If

    End Sub


    Private Sub cbOperatie_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbOperatie.SelectedIndexChanged
        '		queryPLUS()
        '		queryChange()
    End Sub

    Private Sub cbSQLBevel_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbSQLBevel.SelectedIndexChanged

        If cbSQLBevel.SelectedIndex <> 0 Then
            Msg = cbSQLBevel.Text & " opdracht." & vbCr & vbCr & "Het is ten zeerste aan te raden om dergelijke" & vbCr & "opdrachten BINNENIN een TRANSACTIE uit te voeren" & vbCr & vbCr & vbCr & "BEGIN WORK start een transactie" & vbCr & vbCr & "ROLLBACK WORK annuleert alle wijziging na 'BEGIN WORK'" & vbCr & "(m.a.w. zéér interessant om foutieve 'DELETE/UPDATES/INSERT'" & vbCr & "opdrachten teniet te doen...)" & vbCr & vbCr & "COMMIT WORK ten slotte laat alle 'DELETE/UPDATE/INSERT'" & vbCr & "opdrachten doorgaan." & vbCr & vbCr & "BEGIN WORK wordt hierna voorgesteld als instructie.  Druk Alt+E om te activeren"
            MsgBox(Msg, MsgBoxStyle.Exclamation)
            txtSQL.Text = "BEGIN WORK"
        Else
            '			queryPLUS()
            '			queryChange()
        End If

    End Sub

    Private Sub cbVelden_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbVelden.SelectedIndexChanged
        '		queryPLUS()
        '		queryChange()
    End Sub

    Private Sub cmbSelect_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSelect.SelectedIndexChanged

        '		JetGet(TableOfVarious, 1, "29" & cmbSelect.Text)
        '		If Ktrl Then
        '		Else
        '			RecordToField(TableOfVarious)
        '			If InStr(AdoGetField(TableOfVarious, "#v132 #"), "[Colwidth]") Then
        '				txtSQL.Text = VB.Left(AdoGetField(TableOfVarious, "#v132 #"), InStr(AdoGetField(TableOfVarious, "#v132 #"), "[Colwidth]") - 1)
        '			Else
        '				txtSQL.Text = AdoGetField(TableOfVarious, "#v132 #")
        '			End If

        '			On Error Resume Next
        '			Msg = Mid(AdoGetField(TableOfVarious, "#v132 #"), InStr(AdoGetField(TableOfVarious, "#v132 #"), "[Colwidth]") + 10)
        '			If Msg = "" Then
        '				grdColWidth(0) = 0
        '			Else
        '				CountTo = 0
        '				Do While Msg <> ""
        '					If InStr(Msg, vbTab) <> 0 Then
        '						grdColWidth(CountTo) = Val(VB.Left(Msg, InStr(Msg, vbTab) - 1))
        '						Msg = Mid(Msg, InStr(Msg, vbTab) + 1)
        '						CountTo = CountTo + 1
        '					Else
        '						Exit Do
        '					End If
        '				Loop 
        '				grdColWidth(CountTo) = 0
        '			End If

        '		End If

    End Sub

    Private Sub cmbSelect_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cmbSelect.KeyDown

        '		Dim KeyCode As Short = eventArgs.KeyCode
        '		Dim Shift As Short = eventArgs.KeyData \ &H10000

        '		If KeyCode = 46 Then
        '			JetGet(TableOfVarious, 1, "29" & cmbSelect.Text)
        '			If Ktrl Or VB.Left(KeyBuf(TableOfVarious), 2) <> "29" Then
        '			ElseIf MsgBox("Bestaande definitie '" & cmbSelect.Text & "' verwijderen ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then 
        '				RecordToField(TableOfVarious)
        '				Bdelete(TableOfVarious)
        '				SelectComboVullen()
        '			Else
        '				Exit Sub
        '			End If
        '		ElseIf KeyCode = 13 Then 
        '			cmdSelectWegschrijven_Click(cmdSelectWegschrijven, New System.EventArgs())
        '		End If

    End Sub

    Private Sub BtnVersie_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbVersie.Click

        Dim strVersionInfo As String

        On Error Resume Next
        strVersionInfo = "ADO Versie: " & adntDB.Version & vbCr & "DBMS Naam: " & adntDB.Properties("DBMS Name").Value & vbCr & "DBMS Versie: " & adntDB.Properties("DBMS Version").Value & vbCr & "OLE DB Versie: " & adntDB.Properties("OLE DB Version").Value & vbCr & "Provider Naam: " & adntDB.Properties("Provider Name").Value & vbCr & "Provider Versie: " & adntDB.Properties("Provider Version").Value & vbCr
        MsgBox(strVersionInfo)

    End Sub

    Private Sub cmdBackup_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBackup.Click

        '		Dim TQString As String
        '		Dim sTBLName As String
        '		Dim SQLstring As String

        '		Dim cnnSubHier As ADODB.Connection
        '		Dim rsSubHier As ADODB.Recordset
        '		Dim jetConnectSubHier As String
        '		Dim RecordTeller As Integer
        '		Dim msgStringHier As String

        '		jetConnectSubHier = adoJetProvider & "Data Source=" & LocationCompanyData & "\marnt.mdv;" & "Persist Security Info=False"

        '		cnnSubHier = New ADODB.Connection
        '		cnnSubHier.Open(jetConnectSubHier)
        '		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		If Dir(LocationCompanyData & "\marnt.mdb") <> "" Then
        '			Kill(LocationCompanyData & "\marnt.mdb")
        '		End If
        '		If Not CopyFile(ProgramLocation, LocationCompanyData, "marnt.mdb") Then
        '			MsgBox("Stop" & vbCr & ErrorToString())
        '		End If

        '		'UPGRADE_WARNING: Couldn't resolve default property of object OpenSchemaString(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		TQString = OpenSchemaString("TABLE")
        '		Do While TQString <> ""
        '			sTBLName = Mid(TQString, 1, InStr(TQString, vbCr) - 1)
        '			TQString = Mid(TQString, InStr(TQString, vbCr) + 1)
        '			SQLstring = "SELECT * INTO [" & LocationCompanyData & "marnt.mdb].[" & sTBLName & "] FROM " & sTBLName
        '			Err.Clear()
        '			On Error Resume Next
        '			SnelHelpPrint("Bezig aan tabel " & sTBLName, blLogging)
        '			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '			System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        '			cnnSubHier.Execute(SQLstring, RecordTeller)
        '			If Err.Number Then
        '				MsgBox(ErrorToString())
        '			Else
        '				msgStringHier = msgStringHier & RecordTeller & " records met succes overgedragen in tabel " & sTBLName & " / "
        '			End If
        '			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        '			'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        '			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '			System.Windows.Forms.Cursor.Current = vbNormal
        '		Loop 
        '		MsgBox("Einde backup database" & vbCr & vbCr & msgStringHier, MsgBoxStyle.Information)
        '		MsgBox("Backup nog op veilige plaats bewaren: " & LocationCompanyData & "marnt.mdb", MsgBoxStyle.Information)
        '		MsgBox("Hierna worden de belangrijkste indexen nog aangemaakt in de marnt.mdb database")
        '		MsgBox("Stop")


    End Sub

    Private Sub cmdExecute_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExecute.Click

        '		Dim recAantal As Integer

        '		On Error Resume Next
        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        '		Err.Clear()
        '		adntDB.Execute(txtSQL.Text, recAantal)
        '		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        '		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = vbNormal
        '		If Err.Number Then
        '			MsgBox("Foutmelding bron: " & Err.Source & vbCrLf & "Foutkodenummer: " & Err.Number & vbCrLf & vbCrLf & "Foutmelding omschrijving:" & vbCrLf & Err.Description)
        '		Else
        '			MsgBox(txtSQL.Text & vbCr & vbCr & "met succes uitgevoerd." & vbCr & vbCr & recAantal & " records met wijzigingen.", MsgBoxStyle.Information)
        '		End If
        '		'adoLoadDatabase

    End Sub

    Private Sub cmdKopij_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdKopij.Click

        '		Msg = "Kies 'Ja' voor kopij als XML bestand" & vbCr & "Kies 'Nee' voor kopij naar het klassieke plakbord"

        '		KtrlBox = MsgBox(Msg, MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton3)
        '		Dim BestandHier As String
        '		If KtrlBox = MsgBoxResult.Cancel Then
        '			Exit Sub
        '		ElseIf KtrlBox = MsgBoxResult.No Then 
        '			On Error Resume Next
        '			My.Computer.Clipboard.Clear()
        '			My.Computer.Clipboard.SetText(msfSQL.Clip)
        '			Exit Sub
        '		Else
        '			On Error GoTo CancelError
        '			Mim.TekenOpen.FileName = ""
        '			Mim.TekenSave.FileName = ""
        '			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        '			Mim.Teken.CancelError = True
        '			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '			Mim.TekenOpen.Filter = "Alle bestanden (*.xml)|*.xml"
        '			Mim.TekenSave.Filter = "Alle bestanden (*.xml)|*.xml"
        '			Mim.TekenSave.ShowDialog()
        '			Mim.TekenOpen.FileName = Mim.TekenSave.FileName
        '			BestandHier = Mim.TekenOpen.FileName
        '			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '			If Not Dir(BestandHier) = "" Then
        '				Kill(BestandHier)
        '			End If
        '			datPrimaryRS.Save(Mim.TekenOpen.FileName, ADODB.PersistFormatEnum.adPersistXML)
        '		End If

        'CancelError: 
        '		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        '		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = vbNormal

    End Sub

    Private Sub cmdNet1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNet1.Click

        '		Msg = "ALTER TABLE Journalen DROP COLUMN dece068"
        '		MsgBox("Alle rekening- en journaalvelden voor cijfers/bedragen dienen vanaf versie 6.5.301 bij voorkeur formaat DECIMAL te zijn (voorheen CURRENCY).  Wij zullen zolang als mogelijk een manuele hersamenstelling beschikbaar stellen d.m.v. de SQL instructie hierna EN VERVOLGENS opnieuw openen van het bedrijf.  Zeker tot aan versie 6.5.500 zal deze functie beschikbaar blijven." & vbCr & vbCr & "Aarzel NOOIT ons te contacteren voor bijkomende inlichtingen:" & vbCr & vbCr & Msg & vbCr & vbCr & "Uiteraard alléén indien U een verkeerde herrekening wenst te verbeteren..." & vbCr & vbCr & "NETWERKERS !  EERST AL UW ANDERE marINTEGRAAL GEBRUIKERSVERBINDINGEN STOPPEN !!!!", MsgBoxStyle.Information)

    End Sub

    Private Sub cmdOpenXML_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOpenXML.Click

        '		On Error GoTo CancelError
        '		Mim.TekenOpen.FileName = ""
        '		Mim.TekenSave.FileName = ""
        '		'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        '		Mim.Teken.CancelError = True
        '		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		Mim.TekenOpen.Filter = "Alle bestanden (*.xml)|*.xml"
        '		Mim.TekenSave.Filter = "Alle bestanden (*.xml)|*.xml"
        '		Mim.TekenOpen.ShowDialog()
        '		Mim.TekenSave.FileName = Mim.TekenOpen.FileName
        '		Dim BestandHier As String
        '		BestandHier = Mim.TekenOpen.FileName
        '		Err.Clear()
        '		On Error Resume Next
        '		datPrimaryRS.Close()
        '		On Error Resume Next
        '		Err.Clear()
        '		datPrimaryRS.Open(Mim.TekenOpen.FileName,  , ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, ADODB.CommandTypeEnum.adCmdFile)
        '		msfSQL.DataSource = datPrimaryRS
        '		If Err.Number Then
        '			MsgBox("Dit is geen ADO-compatibel XML bestand.", MsgBoxStyle.Information)
        '		Else
        '			txtSQL.Text = datPrimaryRS.Source
        '			lblRecordCount.Text = CStr(datPrimaryRS.RecordCount)
        '			'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        '			msfSQL.CtlRefresh()
        '		End If

        'CancelError: 
        '		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        '		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = vbNormal

    End Sub

    Private Sub cmdSelectWegschrijven_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSelectWegschrijven.Click

        '		JetGet(TableOfVarious, 1, "29" & cmbSelect.Text)
        '		If Ktrl Or VB.Left(KeyBuf(TableOfVarious), 2) <> "29" Then
        '			'Als nieuw bijvoegen
        '			TLBRecord(TableOfVarious) = ""
        '			Msg = ""
        '			For CountTo = 0 To msfSQL.get_Cols() - 1
        '				Msg = Msg & VB6.Format(msfSQL.get_ColWidth(CountTo)) & vbTab
        '			Next 
        '			Msg = "[Colwidth]" & Msg
        '			Msg = txtSQL.Text & Msg
        '			AdoInsertToRecord(TableOfVarious, Msg, "v132")
        '			AdoInsertToRecord(TableOfVarious, (cmbSelect.Text), "v250")
        '			AdoInsertToRecord(TableOfVarious, "29" & AdoGetField(TableOfVarious, "#v250 #"), "v005")
        '			JetInsert(TableOfVarious, 1)
        '		ElseIf MsgBox("Bestaande definitie '" & cmbSelect.Text & "' overschrijven ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then 
        '			RecordToField(TableOfVarious)
        '			Msg = ""
        '			For CountTo = 0 To msfSQL.get_Cols() - 1
        '				Msg = Msg & VB6.Format(msfSQL.get_ColWidth(CountTo)) & vbTab
        '			Next 
        '			Msg = "[Colwidth]" & Msg
        '			Msg = txtSQL.Text & Msg

        '			AdoInsertToRecord(TableOfVarious, Msg, "v132")
        '			AdoInsertToRecord(TableOfVarious, (cmbSelect.Text), "v250")
        '			AdoInsertToRecord(TableOfVarious, "29" & AdoGetField(TableOfVarious, "#v250 #"), "v005")
        '			bUpdate(TableOfVarious, 1)
        '		Else
        '			Exit Sub
        '		End If
        '		SelectComboVullen()

    End Sub

    Private Sub BtnSluiten_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSluiten.Click

        Close()

    End Sub

    Private Sub CmdSQL_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSQL.Click

        lblRecordCount.Text = ""
        Refresh()
        If AdoRECORDset() Then
            'For CountTo = 0 To msfSQL.get_Cols() - 1
            'If grdColWidth(CountTo) = 0 Then
            'Exit For
            'Else
            '   msfSQL.set_ColWidth(CountTo,  , grdColWidth(CountTo))
            'End If
            '   msfSQL.set_ColAlignment(CountTo, MSFlexGridLib.AlignmentSettings.flexAlignLeftTop)
            '  Next
        End If

    End Sub

    Sub SelectComboVullen()

        cmbSelect.Items.Clear()
        sqlDef.MoveFirst()
        Do While Not sqlDef.EOF
            TLBRecord(TableOfVarious) = sqlDef.Fields("MEMO").Value
            cmbSelect.Items.Add(AdoGetField(TableOfVarious, "#v250 #"))
            sqlDef.MoveNext()
        Loop
        If cmbSelect.Items.Count = 0 Then
        Else
            cmbSelect.SelectedIndex = 0
        End If

    End Sub

    Private Sub LBDatabase_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

        txtSQL.Text = "SELECT * FROM " & LBDatabase.Text

    End Sub

    'Private Sub msfSQL_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles msfSQL.DblClick

    '		If VB6.PixelsToTwipsY(msfSQL.Top) = 5 Then
    '			'vergroten
    '			Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    '			msfSQL.Top = 0
    '			msfSQL.Left = 0
    '			msfSQL.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Height) - 700)
    '			msfSQL.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Width) - 100)
    '		Else
    '			'terug normaal
    '			Me.WindowState = System.Windows.Forms.FormWindowState.Normal
    '			With msfSQL
    '				.Top = VB6.TwipsToPixelsY(5)
    '				.Left = 0
    '				.Height = VB6.TwipsToPixelsY(2175)
    '				.Width = VB6.TwipsToPixelsX(6135)
    '			End With
    '		End If

    'End Sub

    Public Sub AdoLoadDatabase()

        Dim TQString As String

        LBDatabase.Items.Clear()
        TQString = OpenSchemaString("Table")

        'add the Tables
        Dim anArray() As String = Split(TQString, vbCr)
        For T = 0 To anArray.Length - 1
            If Mid(anArray(T), 1, 2) = "jr" Or Mid(anArray(T), 1, 2) = "zj" Then
            Else
                LBDatabase.Items.Add(anArray(T))
            End If
        Next

    End Sub

    Function AdoRECORDset() As Boolean

        Cursor.Current = Cursors.WaitCursor
        On Error Resume Next

        msfSQL.DataSource = Nothing
        datPrimaryRS.Close()
        On Error Resume Next
        datPrimaryRS.Open(txtSQL.Text, adntDB)
        If Err.Number Then
            MsgBox("Bron:" & vbCrLf & Err.Source & vbCrLf & vbCrLf & "Foutnummer: " & Err.Number & vbCrLf & vbCrLf & "Detail:" & vbCrLf & Err.Description)
            msfSQL.Refresh()
        Else
            msfSQL.DataSource = datPrimaryRS
        End If
        lblRecordCount.Text = CStr(datPrimaryRS.RecordCount)
        msfSQL.DataSource = datPrimaryRS
        Cursor.Current = Cursors.Default

    End Function

    Private Sub TtxtPLUS_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPLUS.TextChanged

        QueryChange()

    End Sub

    Private Sub TxtWaarde_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWaarde.TextChanged

        QueryPLUS()
        QueryChange()

    End Sub

    Function QueryChange()

        QueryChange = True 'TO FIX LATER

        querySQL = cbSQLBevel.Text & " " & txtPLUS.Text & " " & cbVelden.Text & " " & cbOperatie.Text & " " & txtWaarde.Text
        txtSQL.Text = querySQL

    End Function

    Function QueryPLUS()

        QueryPLUS = True 'TO FIX LATER

        Select Case cbSQLBevel.SelectedIndex
            Case 0
                txtPLUS.Text = " * FROM " & LBDatabase.Text & " WHERE "
                txtPLUS.Enabled = False

            Case 1
                txtPLUS.Text = " FROM " & LBDatabase.Text & " WHERE "
                txtPLUS.Enabled = False

            Case 2
                txtPLUS.Text = " " & LBDatabase.Text & " SET " & cbVelden.Text & " = ??? WHERE "
                txtPLUS.Enabled = True

            Case Else
                MsgBox(cbSQLBevel.Text & " nog niet beschikbaar via snelinstructies", MsgBoxStyle.Information)
                txtSQL.Text = ""
        End Select

    End Function

    Private Sub LBDatabase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LBDatabase.KeyPress

        LBDatabase_DoubleClick(sender, e)

    End Sub

    Private Sub LBDatabase_DoubleClick(sender As Object, e As EventArgs) Handles LBDatabase.DoubleClick

        Dim CountTo As Short

        txtSQL.Text = "SELECT * FROM " & LBDatabase.Text
        CmdSQL_Click(cmdSQL, New EventArgs())
        cbSQLBevel.Enabled = True
        cbSQLBevel.SelectedIndex = 0

        cbVelden.Enabled = True
        cbVelden.Items.Clear()
        For CountTo = 0 To datPrimaryRS.Fields.Count - 1
            cbVelden.Items.Add(datPrimaryRS.Fields(CountTo).Name)
        Next
        If cbVelden.Items.Count Then
            cbVelden.SelectedIndex = 0
        End If
        cbOperatie.Enabled = True
        cbOperatie.SelectedIndex = 0
        txtWaarde.Enabled = True
        txtWaarde.Text = "'%'"
        txtWaarde.Focus()

    End Sub

End Class

