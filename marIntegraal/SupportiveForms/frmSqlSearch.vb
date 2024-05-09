Option Strict Off
Option Explicit On
Public Class SqlSearch
    Private datPrimaryRS As ADODB.Recordset

    Function SQLVernieuwTekst(comboTekst As String) As Integer
        Dim SorteerIndex As String = ""
        Dim SorteerOrde As String = ""
        Dim Sleuteltje As String
        Dim TelOrde As Short


        'eerst kontrole voorkeurSQL
        comboTekst = sorteringComboBox.Text
        Sleuteltje = "marSQL" & Format(SHARED_FL, "00") & Mid(comboTekst, 1, InStr(comboTekst, ";") - 1)
        TelOrde = 0
        Do
            COUNT_TO = InStr(TelOrde + 1, comboTekst, ";") - 1
            If COUNT_TO < 0 Then
                Exit Do
            Else
                If TelOrde = 0 Then
                    SorteerIndex = Mid(comboTekst, COUNT_TO - 3, 4)
                    SorteerOrde = Mid(comboTekst, COUNT_TO - 3, 4)
                    If Mid(comboTekst, COUNT_TO - 4, 1) = "+" Then
                        SorteerOrde &= " ASC"
                    Else
                        SorteerOrde &= " DESC"
                    End If
                Else
                    SorteerIndex = SorteerIndex & "+" & Mid(comboTekst, COUNT_TO - 3, 4)
                    SorteerOrde = SorteerOrde & ", " & Mid(comboTekst, COUNT_TO - 3, 4)
                    If Mid(comboTekst, COUNT_TO - 4, 1) = "+" Then
                        SorteerOrde &= " ASC"
                    Else
                        SorteerOrde &= " DESC"
                    End If
                End If

            End If
            TelOrde = COUNT_TO + 1
        Loop

        JetGet(TABLE_VARIOUS, 1, "29" & Sleuteltje)
        If KTRL Then
            MsgBox("InitSQL")
        Else
            RecordToField(TABLE_VARIOUS)
            MSG = AdoGetField(TABLE_VARIOUS, "#v132 #")
            If InStr(UCase(MSG), "WHERE") Then
                MSG = Mid(MSG, 1, InStr(UCase(MSG), " WHERE ") - 1)
                MSG = MSG & " WHERE " & SorteerIndex & " Like " & Chr(34) & txtTeZoeken.Text & Chr(34)
                MSG = MSG & " ORDER BY " & SorteerOrde
                rtbSQLTekst.Text = MSG
                MSG = Mid(AdoGetField(TABLE_VARIOUS, "#v132 #"), InStr(AdoGetField(TABLE_VARIOUS, "#v132 #"), "[Colwidth]") + 10)
                If MSG = "" Then
                    Stop
                    'grdColWidth(0) = 0
                Else

                    COUNT_TO = 0
                    Do While MSG <> ""
                        If InStr(MSG, vbTab) <> 0 Then
                            'grdColWidth(COUNT_TO) = Val(VB.Left(MSG, InStr(MSG, vbTab) - 1))
                            MSG = Mid(MSG, InStr(MSG, vbTab) + 1)
                            COUNT_TO = COUNT_TO + 1
                        Else
                            Exit Do
                        End If
                    Loop
                    'grdColWidth(COUNT_TO) = 0
                End If
            Else
                MsgBox("InitSQL")
            End If
        End If
        Exit Function

InitSQL:
        'MSG = "SELECT"
        'Dim Delaatste As Boolean

        'Delaatste = False
        'eerst eerste index verzekeren !
        'Stop
        'For COUNT_TO = 0 To Sortering.Items.Count - 1
        'If Trim(JETTABLEUSE_INDEX(SHARED_FL, 0)) = Mid(VB6.GetItemString(Sortering, COUNT_TO), 2, InStr(VB6.GetItemString(Sortering, COUNT_TO), ";") - 2) Then
        'MSG = MSG & " " & Mid(VB6.GetItemString(Sortering, COUNT_TO), 2, InStr(VB6.GetItemString(Sortering, COUNT_TO), ";") - 2)
        'MSG = MSG & " AS [" & Mid(VB6.GetItemString(Sortering, COUNT_TO), InStr(VB6.GetItemString(Sortering, COUNT_TO), ";") + 2) & "]"
        'MSG = MSG & ","
        'If COUNT_TO = Sortering.Items.Count - 1 Then
        'Delaatste = True
        'End If
        'Exit For
        'End If
        'Next
        'If MSG = "SELECT" Then
        'MsgBox("Hoofdindex " & Mid(VB6.GetItemString(Sortering, COUNT_TO), 2, InStr(VB6.GetItemString(Sortering, COUNT_TO), ";") - 2) & " bestaat niet (meer)", MsgBoxStyle.Critical)
        'End If

        'dan de rest bijvoegen
        'For COUNT_TO = 0 To Sortering.Items.Count - 1
        'If Trim(JETTABLEUSE_INDEX(SHARED_FL, 0)) = Mid(VB6.GetItemString(Sortering, COUNT_TO), 2, InStr(VB6.GetItemString(Sortering, COUNT_TO), ";") - 2) Then
        'Else
        'MSG = MSG & " " & Mid(VB6.GetItemString(Sortering, COUNT_TO), 2, InStr(VB6.GetItemString(Sortering, COUNT_TO), ";") - 2)
        'MSG = MSG & " AS [" & Mid(VB6.GetItemString(Sortering, COUNT_TO), InStr(VB6.GetItemString(Sortering, COUNT_TO), ";") + 2) & "]"
        'If Delaatste = True And Sortering.Items.Count = 1 Then
        'ElseIf Delaatste = True And COUNT_TO = Sortering.Items.Count - 2 Then
        'ElseIf COUNT_TO < Sortering.Items.Count - 1 Then
        'MSG = MSG & ","
        'End If
        'End If
        'Next
        'MSG = MSG & " FROM " & JET_TABLENAME(SHARED_FL)
        'MSG = MSG & " WHERE " & SorteerIndex & " Like " & Chr(34) & txtTeZoeken.Text & Chr(34)
        'MSG = MSG & " ORDER BY " & SorteerOrde
        'UPGRADE_WARNING: TextRTF was upgraded to Text and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'rtbSQLTekst.Text = MSG
        'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'Return


    End Function
    Private Sub SqlSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SorteringTel As Short
        sqlresultListView.Clear()
        SorteringTel = 0
        Text = Text & ": " & JET_TABLENAME(SHARED_FL)
        VulcmbSortering()
        XLOG_KEY = ""

        If InStr(GRIDTEXT, "@Beperk@") Then
            txtTeZoeken.Text = Mid(GRIDTEXT, 2) & "%"
            refreshView()

        ElseIf GRIDTEXT <> "" Then
            txtTeZoeken.Text = Trim(GRIDTEXT) & "%"
            refreshView()

        Else
            txtTeZoeken.Text = "%"
            txtTeZoeken.Focus()
        End If

    End Sub
    Private Sub VulcmbSortering()
        Dim T As Short
        sorteringComboBox.Items.Clear()
        For T = 0 To FL_NUMBEROFINDEXEN(SHARED_FL)
            Dim sortveldString As String = Trim(JETTABLEUSE_INDEX(SHARED_FL, T))
            sorteringComboBox.Items.Add("+" & sortveldString & "; " & FLINDEX_CAPTION(SHARED_FL, T))
        Next
        If SHARED_INDEX Then
            sorteringComboBox.SelectedIndex = SHARED_INDEX
        Else
            sorteringComboBox.SelectedIndex = 0
        End If
    End Sub
    Sub Schoon()

        'MsgBox("de view leegmaken")
        'mfgLijst.Clear()
        'mfgLijst.set_Cols(, 2)
        'mfgLijst.Rows = 2

    End Sub

    Private Sub sluitenButton_Click(sender As Object, e As EventArgs) Handles sluitenButton.Click

        KTRL = 9

    End Sub

    Private Sub zoekenButton_Click(sender As Object, e As EventArgs) Handles zoekenButton.Click

        On Error Resume Next
        If zoekenButton.Text = "Ok" Then
            If XLOG_KEY = "" Then
                'MsgBox("er is iets mis")
                'poging om de eerste record door te geven van recordset...
                If datPrimaryRS.RecordCount Then
                    datPrimaryRS.MoveFirst()
                    XLOG_KEY = datPrimaryRS.Fields(datPrimaryRS.Fields.Item(0).Name).Value
                End If
                datPrimaryRS.Close()
            End If

            JetGet(SHARED_FL, 0, XLOG_KEY)
            If KTRL Then
                Beep()
                txtTeZoeken.Focus()
                Exit Sub
            Else
                RecordToField(SHARED_FL)
            End If
            Close()

        Else
            On Error Resume Next
            datPrimaryRS.Close()
            refreshView()

        End If

    End Sub

    Sub refreshView()

        Dim sSQL As String
        SQLVernieuwTekst(sorteringComboBox.Text)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        sSQL = rtbSQLTekst.Text

        Try
            datPrimaryRS.Close()
        Catch ex As Exception

        End Try
        ' Create a recordset using the provided collection
        datPrimaryRS = New ADODB.Recordset
        datPrimaryRS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        datPrimaryRS.Open(sSQL, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        If Err.Number Then
            Stop
            'UPGRADE_NOTE: Object mfgLijst.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            'mfgLijst.DataSource = Nothing
            ' ElseIf Err.Number Then
            Stop
            'MsgBox("Bron:" & vbCrLf & Err.Source & vbCrLf & vbCrLf & "Foutnummer: " & Err.Number & vbCrLf & vbCrLf & "Detail:" & vbCrLf & Err.Description)
            'UPGRADE_NOTE: Object mfgLijst.DataSource may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            'mfgLijst.DataSource = Nothing
        Else
            Try
                sqlresultListView.Clear()
                For COUNT_TO = 0 To datPrimaryRS.Fields.Count - 1
                    sqlresultListView.Columns.Add(datPrimaryRS.Fields.Item(COUNT_TO).Name, 100)
                Next
                sqlresultListView.View = View.Details
                Dim dataVeld As String
                If datPrimaryRS.RecordCount > 0 Then
                    datPrimaryRS.MoveFirst()
                    Do While Not datPrimaryRS.EOF
                        dataVeld = datPrimaryRS.Fields(datPrimaryRS.Fields.Item(0).Name).Value
                        Dim itemHier As New ListViewItem(dataVeld)
                        For COUNT_TO = 1 To datPrimaryRS.Fields.Count - 1
                            If IsDBNull(datPrimaryRS.Fields(datPrimaryRS.Fields.Item(COUNT_TO).Name).Value) Then
                                dataVeld = " "
                            Else
                                dataVeld = datPrimaryRS.Fields(datPrimaryRS.Fields.Item(COUNT_TO).Name).Value
                            End If
                            itemHier.SubItems.Add(dataVeld)
                        Next
                        sqlresultListView.Items.Add(itemHier)
                        datPrimaryRS.MoveNext()
                    Loop
                End If

            Catch ex As Exception
                Stop
            End Try
            If datPrimaryRS.RecordCount Then
                recordsLabel.Text = CStr(datPrimaryRS.RecordCount)
                zoekenButton.Text = "Ok"
                sqlresultListView.FullRowSelect = True
                Dim itemX As ListViewItem
                itemX = sqlresultListView.Items.Item(0)
                XLOG_KEY = itemX.SubItems.Item(0).Text
                txtTeZoeken.Text = XLOG_KEY
                sqlresultListView.Enabled = True
                sqlresultListView.Focus()
            Else
                Beep()
                zoekenButton.Text = "Zoeken"
                txtTeZoeken.Focus()
            End If
            'dataGridViewRS.Close()
        End If

        'For COUNT_TO = 0 To mfgLijst.get_Cols() - 1
        'If grdColWidth(COUNT_TO) = 0 Then
        'Exit For
        'Else
        'mfgLijst.set_ColWidth(COUNT_TO,  , grdColWidth(COUNT_TO))
        'End If
        '   Next

        'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
        'UPGRADE_ISSUE: Form property SqlSearch.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        Me.Cursor = System.Windows.Forms.Cursors.Default
        'If mfgLijst.Rows > 1 Then
        'mfgLijst.Row = 1
        'mfgLijst.Col = 0
        'On Error Resume Next
        'mfgLijst.Focus()
        'End If

    End Sub

    Private Sub sorteringComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sorteringComboBox.SelectedIndexChanged

        Dim teksthier As String = sorteringComboBox.Text
        txtTeZoeken.Text = ""
        sqlresultListView.Clear()
        sqlresultListView.Enabled = False
        SQLVernieuwTekst(teksthier)
        Schoon()

    End Sub

    Private Sub txtTeZoeken_TextChanged(sender As Object, e As EventArgs) Handles txtTeZoeken.TextChanged

        If Len(txtTeZoeken.Text) <= 1 And InStr(txtTeZoeken.Text, "%") = 0 Then
            txtTeZoeken.Text = txtTeZoeken.Text & "%"
            txtTeZoeken.SelectionStart = Len(txtTeZoeken.Text) - 1
        End If

    End Sub

    Private Sub sqlresultListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sqlresultListView.SelectedIndexChanged

        XLOG_KEY = sqlresultListView.FocusedItem.SubItems.Item(0).Text
        txtTeZoeken.Text = XLOG_KEY

    End Sub

    Private Sub sqlresultListView_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles sqlresultListView.MouseDoubleClick

        zoekenButton.PerformClick()

    End Sub

    Private Sub txtTeZoeken_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTeZoeken.KeyPress

        zoekenButton.Text = "Zoeken"

    End Sub

    Private Sub txtTeZoeken_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTeZoeken.KeyDown

        If e.KeyCode = 46 Then
            zoekenButton.Text = "Zoeken"
        End If
    End Sub
End Class