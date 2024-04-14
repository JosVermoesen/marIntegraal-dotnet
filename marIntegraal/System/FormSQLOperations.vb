Option Strict Off
Option Explicit On

Public Class SqlOperations

    Dim querySQL As String
    Dim allClosed As Boolean
    Dim dataGridViewRS As ADODB.Recordset
    Dim availableSqlDefRS As ADODB.Recordset

    Private Sub SqlOperations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Text = "SQL Bewerkingen"
        dataGridViewRS = New ADODB.Recordset With {
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
        }

        allClosed = False
        MSG = "Moeten de tabellen gesloten worden (noodzakelijk om wijzigingen aan 'structuur' aan te brengen)"
        If MsgBox(MSG, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
            MsgBox("De bestanden worden gesloten.  U kan eveneens wijzigingen aan de structuur van tabellin in de database aanbrengen.  Het is aanbevolen straks het bedrijf opnieuw te openen", MsgBoxStyle.Information)
            allClosed = True
            JetTableClose(99)
        Else
            MsgBox("De bestanden worden niet gesloten.  U kan enkel de gegevens in de database bewerken.  U kan géén wijzigingen aan de structuur van tabellen in de database aanbrengen.", MsgBoxStyle.Information)
        End If

        Cursor.Current = Cursors.WaitCursor

        AdoLoadDatabase()
        If GetStartUpRecordSet() Then
        Else
            MSG = "SELECT TOP 6" & vbCrLf
            MSG &= "    v019 AS RekNr," & vbCrLf
            MSG &= "    v020 AS Omschrijving," & vbCrLf
            MSG &= "    v022 AS [Boekjaar 0]," & vbCrLf
            MSG &= "    v023 AS [Boekjaar -1]," & vbCrLf
            MSG &= "    v024 AS [Boekjaar -2]," & vbCrLf
            MSG &= "    v025 As [Boekjaar -3]" & vbCrLf
            MSG &= "FROM" & vbCrLf
            MSG &= "    Rekeningen" & vbCrLf
            MSG &= "ORDER BY" & vbCrLf
            MSG &= "    v020 DESC"
            TLB_RECORD(TABLE_VARIOUS) = ""
            AdoInsertToRecord(TABLE_VARIOUS, MSG, "v132")
            AdoInsertToRecord(TABLE_VARIOUS, "Query voorbeeld", "v250")
            AdoInsertToRecord(TABLE_VARIOUS, "29" & AdoGetField(TABLE_VARIOUS, "#v250 #"), "v005")
            JetInsert(TABLE_VARIOUS, 1)
            If KTRL = 0 Then
                GetStartUpRecordSet()
            End If
        End If
        SelectComboVullen()
        CmdSQL_Click(BtnSelect, New System.EventArgs())

        Cursor.Current = Cursors.Default

    End Sub

    Private Function GetStartUpRecordSet() As Boolean

        GetStartUpRecordSet = False
        Dim sSQL As String = "SELECT * FROM Allerlei WHERE v005  Like '29%'"
        availableSqlDefRS = New ADODB.Recordset With {
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
        }
        availableSqlDefRS.Open(sSQL, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        If availableSqlDefRS.RecordCount > 0 Then
            GetStartUpRecordSet = True
        End If

    End Function

    Private Sub SqlOperations_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Mim.SQLOperationsMenuItem.Enabled = True

    End Sub

    Private Sub SqlOperations_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        On Error Resume Next
        dataGridViewRS.Close()
        dataGridViewRS = Nothing

        If allClosed = True Then
            MsgBox("Bedrijfsdatabase wordt hierna automatisch afgesloten.", MsgBoxStyle.Information)
            AutoUnloadCompany(FormBYPERDAT)
            Exit Sub
        End If

    End Sub

    Private Sub BtnSluiten_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnClose.Click

        Close()

    End Sub

    Private Sub CmdSQL_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnSelect.Click

        lblRecordCount.Text = ""
        Refresh()
        AdoRECORDset()

    End Sub

    Sub SelectComboVullen()

        CbAvailableSqlDef.Items.Clear()
        availableSqlDefRS.MoveFirst()
        Do While Not availableSqlDefRS.EOF
            TLB_RECORD(TABLE_VARIOUS) = availableSqlDefRS.Fields("MEMO").Value
            CbAvailableSqlDef.Items.Add(AdoGetField(TABLE_VARIOUS, "#v250 #"))
            availableSqlDefRS.MoveNext()
        Loop
        If CbAvailableSqlDef.Items.Count = 0 Then
        Else
            CbAvailableSqlDef.SelectedIndex = 0
        End If

    End Sub

    Private Sub LBDatabase_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

        TbSql.Text = "SELECT * FROM " & LbDatabase.Text

    End Sub

    Public Sub AdoLoadDatabase()

        Dim TQString As String

        LbDatabase.Items.Clear()
        TQString = OpenSchemaString("Table")

        'add the Tables
        Dim anArray() As String = Split(TQString, vbCr)
        For T = 0 To anArray.Length - 1
            'ignore system tables
            If Mid(anArray(T), 1, 2) = "jr" Or Mid(anArray(T), 1, 2) = "zj" Then
            Else
                LbDatabase.Items.Add(anArray(T))
            End If
        Next

    End Sub

    Function AdoRECORDset() As Boolean

        Cursor.Current = Cursors.WaitCursor
        On Error Resume Next

        DgvSQL.DataSource = Nothing
        dataGridViewRS.Close()
        On Error Resume Next
        dataGridViewRS.Open(TbSql.Text, AD_NTDB)
        If Err.Number Then
            MsgBox("SQLQuery: " & TbSql.Text & vbCrLf & vbCrLf & "Bron:" & vbCrLf & Err.Source & vbCrLf & vbCrLf & "Foutnummer: " & Err.Number & vbCrLf & vbCrLf & "Detail:" & vbCrLf & Err.Description)
            DgvSQL.Refresh()
        End If
        Dim dt As DataTable = dataGridViewRS.ADODBRSetToDataTable() ' Convert ADODB recordset to DataTable
        Dim view As New DataView(dt) ' Create a DataView from the DataTable
        ' Now we can work with the data using the 'view' variable.
        DgvSQL.DataSource = view
        lblRecordCount.Text = CStr(dataGridViewRS.RecordCount)
        Cursor.Current = Cursors.Default

    End Function

    Private Sub TxtWaarde_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TbValue.TextChanged

        QueryPLUS()
        QueryChange()

    End Sub

    Function QueryChange()

        QueryChange = True 'TO FIX LATER

        querySQL = CbSQLCommand.Text & " " & TbPlus.Text & " " & CbFields.Text & " " & CbOperator.Text & " " & TbValue.Text
        TbSql.Text = querySQL

    End Function

    Function QueryPLUS()

        QueryPLUS = True 'TO FIX LATER

        Select Case CbSQLCommand.SelectedIndex
            Case 0
                TbPlus.Text = " * FROM " & LbDatabase.Text & " WHERE "
                TbPlus.Enabled = False

            Case 1
                TbPlus.Text = " FROM " & LbDatabase.Text & " WHERE "
                TbPlus.Enabled = False

            Case 2
                TbPlus.Text = " " & LbDatabase.Text & " SET " & CbFields.Text & " = ??? WHERE "
                TbPlus.Enabled = True

            Case Else
                MsgBox(CbSQLCommand.Text & " nog niet beschikbaar via snelinstructies", MsgBoxStyle.Information)
                TbSql.Text = ""
        End Select

    End Function

    Private Sub LBDatabase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LbDatabase.KeyPress

        LBDatabase_DoubleClick(sender, e)

    End Sub

    Private Sub LBDatabase_DoubleClick(sender As Object, e As EventArgs) Handles LbDatabase.DoubleClick

        Dim CountTo As Short

        TbSql.Text = "SELECT * FROM " & LbDatabase.Text
        CmdSQL_Click(BtnSelect, New EventArgs())
        CbSQLCommand.Enabled = True
        CbSQLCommand.SelectedIndex = 0

        CbFields.Enabled = True
        CbFields.Items.Clear()
        For CountTo = 0 To dataGridViewRS.Fields.Count - 1
            CbFields.Items.Add(dataGridViewRS.Fields(CountTo).Name)
        Next
        If CbFields.Items.Count Then
            CbFields.SelectedIndex = 0
        End If
        CbOperator.Enabled = True
        CbOperator.SelectedIndex = 0
        TbValue.Enabled = True
        TbValue.Text = "'%'"
        TbValue.Focus()

    End Sub

    Private Sub CbOperatie_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CbOperator.SelectedIndexChanged

        QueryPLUS()
        QueryChange()

    End Sub

    Private Sub CbSQLBevel_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CbSQLCommand.SelectedIndexChanged

        If CbSQLCommand.SelectedIndex <> 0 Then
            MSG = CbSQLCommand.Text & " opdracht." & vbCr & vbCr & "Het is ten zeerste aan te raden om dergelijke" & vbCr & "opdrachten BINNENIN een TRANSACTIE uit te voeren" & vbCr & vbCr & vbCr & "BEGIN WORK start een transactie" & vbCr & vbCr & "ROLLBACK WORK annuleert alle wijziging na 'BEGIN WORK'" & vbCr & "(m.a.w. zéér interessant om foutieve 'DELETE/UPDATES/INSERT'" & vbCr & "opdrachten teniet te doen...)" & vbCr & vbCr & "COMMIT WORK ten slotte laat alle 'DELETE/UPDATE/INSERT'" & vbCr & "opdrachten doorgaan." & vbCr & vbCr & "BEGIN WORK wordt hierna voorgesteld als instructie.  Druk Alt+E om te activeren"
            MsgBox(MSG, MsgBoxStyle.Exclamation)
            TbSql.Text = "BEGIN WORK"
        Else
            QueryPLUS()
            QueryChange()
        End If

    End Sub

    Private Sub CbVelden_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CbFields.SelectedIndexChanged

        QueryPLUS()
        QueryChange()

    End Sub

    Private Sub CmbSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbAvailableSqlDef.SelectedIndexChanged

        JetGet(TABLE_VARIOUS, 1, "29" & CbAvailableSqlDef.Text)
        If KTRL Then
        Else
            RecordToField(TABLE_VARIOUS)
            If InStr(AdoGetField(TABLE_VARIOUS, "#v132 #"), "[Colwidth]") Then
                TbSql.Text = Mid(AdoGetField(TABLE_VARIOUS, "#v132 #"), 1, InStr(AdoGetField(TABLE_VARIOUS, "#v132 #"), "[Colwidth]") - 1)
            Else
                TbSql.Text = AdoGetField(TABLE_VARIOUS, "#v132 #")
            End If

            On Error Resume Next
            'Ignore old code from vb6
            MSG = Mid(AdoGetField(TABLE_VARIOUS, "#v132 #"), InStr(AdoGetField(TABLE_VARIOUS, "#v132 #"), "[Colwidth]") + 10)
        End If

    End Sub

    Private Sub CmbSelect_KeyDown(sender As Object, e As KeyEventArgs) Handles CbAvailableSqlDef.KeyDown

        Dim KeyCode As Short = e.KeyCode
        Dim Shift As Short = e.KeyData \ &H10000

        If KeyCode = 46 Then
            JetGet(TABLE_VARIOUS, 1, "29" & CbAvailableSqlDef.Text)
            If KTRL Or Mid(KEY_BUF(TABLE_VARIOUS), 1, 2) <> "29" Then
            ElseIf MsgBox("Bestaande definitie '" & CbAvailableSqlDef.Text & "' verwijderen ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
                RecordToField(TABLE_VARIOUS)
                Bdelete(TABLE_VARIOUS)
                SelectComboVullen()
            Else
                Exit Sub
            End If
        ElseIf KeyCode = 13 Then
            BtnSaveDefinition_Click(BtnSaveDefinition, New System.EventArgs())
        End If

    End Sub

    Private Sub DgvSQL_DoubleClick(sender As Object, e As EventArgs) Handles DgvSQL.DoubleClick

        If DgvSQL.Top = 4 Then
            'vergroten
            WindowState = FormWindowState.Maximized
            DgvSQL.Top = 0
            DgvSQL.Left = 0
            DgvSQL.Height = Height - 50
            DgvSQL.Width = Width
        Else
            'terug normaal
            WindowState = FormWindowState.Normal
            With DgvSQL
                .Top = 4
                .Left = 1
                .Height = 276
                .Width = 518
            End With
        End If
    End Sub

    Private Sub TbPlus_TextChanged(sender As Object, e As EventArgs) Handles TbPlus.TextChanged

        QueryChange()

    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click

        '		MSG = "Kies 'Ja' voor kopij als XML bestand" & vbCr & "Kies 'Nee' voor kopij naar het klassieke plakbord"

        '		CTRL_BOX = MsgBox(MSG, MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton3)
        '		Dim BestandHier As String
        '		If CTRL_BOX = MsgBoxResult.Cancel Then
        '			Exit Sub
        '		ElseIf CTRL_BOX = MsgBoxResult.No Then 
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
        '			dataGridViewRS.Save(Mim.TekenOpen.FileName, ADODB.PersistFormatEnum.adPersistXML)
        '		End If

        'CancelError: 
        '		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        '		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = vbNormal

    End Sub

    Private Sub BtnOpenXML_Click(sender As Object, e As EventArgs) Handles BtnOpenXML.Click

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
        '		dataGridViewRS.Close()
        '		On Error Resume Next
        '		Err.Clear()
        '		dataGridViewRS.Open(Mim.TekenOpen.FileName,  , ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly, ADODB.CommandTypeEnum.adCmdFile)
        '		msfSQL.DataSource = dataGridViewRS
        '		If Err.Number Then
        '			MsgBox("Dit is geen ADO-compatibel XML bestand.", MsgBoxStyle.Information)
        '		Else
        '			txtSQL.Text = dataGridViewRS.Source
        '			lblRecordCount.Text = CStr(dataGridViewRS.RecordCount)
        '			'UPGRADE_NOTE: Refresh was upgraded to CtlRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        '			msfSQL.CtlRefresh()
        '		End If

        'CancelError: 
        '		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        '		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = vbNormal

    End Sub

    Private Sub BtnNet_Click(sender As Object, e As EventArgs) Handles BtnNet.Click

        'MSG = "ALTER TABLE Journalen DROP COLUMN dece068"
        'MsgBox("Alle rekening- en journaalvelden voor cijfers/bedragen dienen vanaf versie 6.5.301 bij voorkeur formaat DECIMAL te zijn (voorheen CURRENCY).  Wij zullen zolang als mogelijk een manuele hersamenstelling beschikbaar stellen d.m.v. de SQL instructie hierna EN VERVOLGENS opnieuw openen van het bedrijf.  Zeker tot aan versie 6.5.500 zal deze functie beschikbaar blijven." & vbCr & vbCr & "Aarzel NOOIT ons te contacteren voor bijkomende inlichtingen:" & vbCr & vbCr & MSG & vbCr & vbCr & "Uiteraard alléén indien U een verkeerde herrekening wenst te verbeteren..." & vbCr & vbCr & "NETWERKERS !  EERST AL UW ANDERE marINTEGRAAL GEBRUIKERSVERBINDINGEN STOPPEN !!!!", MsgBoxStyle.Information)

    End Sub

    Private Sub BtnBackup_Click(sender As Object, e As EventArgs) Handles BtnBackup.Click

        '		Dim TQString As String
        '		Dim sTBLName As String
        '		Dim SQLstring As String

        '		Dim cnnSubHier As ADODB.Connection
        '		Dim rsSubHier As ADODB.Recordset
        '		Dim jetConnectSubHier As String
        '		Dim RecordTeller As Integer
        '		Dim msgStringHier As String

        '		jetConnectSubHier = ADOJET_PROVIDER & "Data Source=" & LOCATION_COMPANYDATA & "\marnt.mdv;" & "Persist Security Info=False"

        '		cnnSubHier = New ADODB.Connection
        '		cnnSubHier.Open(jetConnectSubHier)
        '		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		If Dir(LOCATION_COMPANYDATA & "\marnt.mdb") <> "" Then
        '			Kill(LOCATION_COMPANYDATA & "\marnt.mdb")
        '		End If
        '		If Not CopyFile(PROGRAM_LOCATION, LOCATION_COMPANYDATA, "marnt.mdb") Then
        '			MsgBox("Stop" & vbCr & ErrorToString())
        '		End If

        '		'UPGRADE_WARNING: Couldn't resolve default property of object OpenSchemaString(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		TQString = OpenSchemaString("TABLE")
        '		Do While TQString <> ""
        '			sTBLName = Mid(TQString, 1, InStr(TQString, vbCr) - 1)
        '			TQString = Mid(TQString, InStr(TQString, vbCr) + 1)
        '			SQLstring = "SELECT * INTO [" & LOCATION_COMPANYDATA & "marnt.mdb].[" & sTBLName & "] FROM " & sTBLName
        '			Err.Clear()
        '			On Error Resume Next
        '			SnelHelpPrint("Bezig aan tabel " & sTBLName, BL_LOGGING)
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
        '		MsgBox("Backup nog op veilige plaats bewaren: " & LOCATION_COMPANYDATA & "marnt.mdb", MsgBoxStyle.Information)
        '		MsgBox("Hierna worden de belangrijkste indexen nog aangemaakt in de marnt.mdb database")

    End Sub

    Private Sub BtnVersion_Click(sender As Object, e As EventArgs) Handles BtnVersion.Click

        Dim strVersionInfo As String

        On Error Resume Next
        strVersionInfo = "ADO Versie: " & AD_NTDB.Version & vbCr & "DBMS Naam: " & AD_NTDB.Properties("DBMS Name").Value & vbCr & "DBMS Versie: " & AD_NTDB.Properties("DBMS Version").Value & vbCr & "OLE DB Versie: " & AD_NTDB.Properties("OLE DB Version").Value & vbCr & "Provider Naam: " & AD_NTDB.Properties("Provider Name").Value & vbCr & "Provider Versie: " & AD_NTDB.Properties("Provider Version").Value & vbCr
        MsgBox(strVersionInfo)

    End Sub

    Private Sub BtnExecute_Click(sender As Object, e As EventArgs) Handles BtnExecute.Click

        '		Dim recAantal As Integer

        '		On Error Resume Next
        '		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        '		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        '		Err.Clear()
        '		AD_NTDB.Execute(txtSQL.Text, recAantal)
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

    Private Sub BtnSaveDefinition_Click(sender As Object, e As EventArgs) Handles BtnSaveDefinition.Click

        '		JetGet(TABLE_VARIOUS, 1, "29" & cmbSelect.Text)
        '		If KTRL Or VB.Left(KEY_BUF(TABLE_VARIOUS), 2) <> "29" Then
        '			'Als nieuw bijvoegen
        '			TLB_RECORD(TABLE_VARIOUS) = ""
        '			MSG = ""
        '			For COUNT_TO = 0 To msfSQL.get_Cols() - 1
        '				MSG = MSG & VB6.Format(msfSQL.get_ColWidth(COUNT_TO)) & vbTab
        '			Next 
        '			MSG = "[Colwidth]" & MSG
        '			MSG = txtSQL.Text & MSG
        '			AdoInsertToRecord(TABLE_VARIOUS, MSG, "v132")
        '			AdoInsertToRecord(TABLE_VARIOUS, (cmbSelect.Text), "v250")
        '			AdoInsertToRecord(TABLE_VARIOUS, "29" & AdoGetField(TABLE_VARIOUS, "#v250 #"), "v005")
        '			JetInsert(TABLE_VARIOUS, 1)
        '		ElseIf MsgBox("Bestaande definitie '" & cmbSelect.Text & "' overschrijven ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then 
        '			RecordToField(TABLE_VARIOUS)
        '			MSG = ""
        '			For COUNT_TO = 0 To msfSQL.get_Cols() - 1
        '				MSG = MSG & VB6.Format(msfSQL.get_ColWidth(COUNT_TO)) & vbTab
        '			Next 
        '			MSG = "[Colwidth]" & MSG
        '			MSG = txtSQL.Text & MSG

        '			AdoInsertToRecord(TABLE_VARIOUS, MSG, "v132")
        '			AdoInsertToRecord(TABLE_VARIOUS, (cmbSelect.Text), "v250")
        '			AdoInsertToRecord(TABLE_VARIOUS, "29" & AdoGetField(TABLE_VARIOUS, "#v250 #"), "v005")
        '			bUpdate(TABLE_VARIOUS, 1)
        '		Else
        '			Exit Sub
        '		End If
        '		SelectComboVullen()

    End Sub
End Class

