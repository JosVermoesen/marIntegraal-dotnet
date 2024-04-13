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
        Sleuteltje = "marSQL" & Format(SharedFl, "00") & Mid(comboTekst, 1, InStr(comboTekst, ";") - 1)
        TelOrde = 0
        Do
            CountTo = InStr(TelOrde + 1, comboTekst, ";") - 1
            If CountTo < 0 Then
                Exit Do
            Else
                If TelOrde = 0 Then
                    SorteerIndex = Mid(comboTekst, CountTo - 3, 4)
                    SorteerOrde = Mid(comboTekst, CountTo - 3, 4)
                    If Mid(comboTekst, CountTo - 4, 1) = "+" Then
                        SorteerOrde &= " ASC"
                    Else
                        SorteerOrde &= " DESC"
                    End If
                Else
                    SorteerIndex = SorteerIndex & "+" & Mid(comboTekst, CountTo - 3, 4)
                    SorteerOrde = SorteerOrde & ", " & Mid(comboTekst, CountTo - 3, 4)
                    If Mid(comboTekst, CountTo - 4, 1) = "+" Then
                        SorteerOrde &= " ASC"
                    Else
                        SorteerOrde &= " DESC"
                    End If
                End If

            End If
            TelOrde = CountTo + 1
        Loop

        JetGet(TableOfVarious, 1, "29" & Sleuteltje)
        If Ktrl Then
            MsgBox("InitSQL")
        Else
            RecordToField(TableOfVarious)
            Msg = AdoGetField(TableOfVarious, "#v132 #")
            If InStr(UCase(Msg), "WHERE") Then
                Msg = Mid(Msg, 1, InStr(UCase(Msg), " WHERE ") - 1)
                Msg = Msg & " WHERE " & SorteerIndex & " Like " & Chr(34) & txtTeZoeken.Text & Chr(34)
                Msg = Msg & " ORDER BY " & SorteerOrde
                rtbSQLTekst.Text = Msg
                Msg = Mid(AdoGetField(TableOfVarious, "#v132 #"), InStr(AdoGetField(TableOfVarious, "#v132 #"), "[Colwidth]") + 10)
                If Msg = "" Then
                    Stop
                    'grdColWidth(0) = 0
                Else

                    CountTo = 0
                    Do While Msg <> ""
                        If InStr(Msg, vbTab) <> 0 Then
                            'grdColWidth(CountTo) = Val(VB.Left(Msg, InStr(Msg, vbTab) - 1))
                            Msg = Mid(Msg, InStr(Msg, vbTab) + 1)
                            CountTo = CountTo + 1
                        Else
                            Exit Do
                        End If
                    Loop
                    'grdColWidth(CountTo) = 0
                End If
            Else
                MsgBox("InitSQL")
            End If
        End If
        Exit Function

InitSQL:
        'Msg = "SELECT"
        'Dim Delaatste As Boolean

        'Delaatste = False
        'eerst eerste index verzekeren !
        'Stop
        'For CountTo = 0 To Sortering.Items.Count - 1
        'If Trim(JetTableUseIndex(SharedFl, 0)) = Mid(VB6.GetItemString(Sortering, CountTo), 2, InStr(VB6.GetItemString(Sortering, CountTo), ";") - 2) Then
        'Msg = Msg & " " & Mid(VB6.GetItemString(Sortering, CountTo), 2, InStr(VB6.GetItemString(Sortering, CountTo), ";") - 2)
        'Msg = Msg & " AS [" & Mid(VB6.GetItemString(Sortering, CountTo), InStr(VB6.GetItemString(Sortering, CountTo), ";") + 2) & "]"
        'Msg = Msg & ","
        'If CountTo = Sortering.Items.Count - 1 Then
        'Delaatste = True
        'End If
        'Exit For
        'End If
        'Next
        'If Msg = "SELECT" Then
        'MsgBox("Hoofdindex " & Mid(VB6.GetItemString(Sortering, CountTo), 2, InStr(VB6.GetItemString(Sortering, CountTo), ";") - 2) & " bestaat niet (meer)", MsgBoxStyle.Critical)
        'End If

        'dan de rest bijvoegen
        'For CountTo = 0 To Sortering.Items.Count - 1
        'If Trim(JetTableUseIndex(SharedFl, 0)) = Mid(VB6.GetItemString(Sortering, CountTo), 2, InStr(VB6.GetItemString(Sortering, CountTo), ";") - 2) Then
        'Else
        'Msg = Msg & " " & Mid(VB6.GetItemString(Sortering, CountTo), 2, InStr(VB6.GetItemString(Sortering, CountTo), ";") - 2)
        'Msg = Msg & " AS [" & Mid(VB6.GetItemString(Sortering, CountTo), InStr(VB6.GetItemString(Sortering, CountTo), ";") + 2) & "]"
        'If Delaatste = True And Sortering.Items.Count = 1 Then
        'ElseIf Delaatste = True And CountTo = Sortering.Items.Count - 2 Then
        'ElseIf CountTo < Sortering.Items.Count - 1 Then
        'Msg = Msg & ","
        'End If
        'End If
        'Next
        'Msg = Msg & " FROM " & JetTableName(SharedFl)
        'Msg = Msg & " WHERE " & SorteerIndex & " Like " & Chr(34) & txtTeZoeken.Text & Chr(34)
        'Msg = Msg & " ORDER BY " & SorteerOrde
        'UPGRADE_WARNING: TextRTF was upgraded to Text and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'rtbSQLTekst.Text = Msg
        'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        'Return


    End Function
    Private Sub SqlSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SorteringTel As Short
        sqlresultListView.Clear()
        SorteringTel = 0
        Text = Text & ": " & JetTableName(SharedFl)
        VulcmbSortering()
        XLogKey = ""

        If InStr(GridText, "@Beperk@") Then
            txtTeZoeken.Text = Mid(GridText, 2) & "%"
            refreshView()

        ElseIf GridText <> "" Then
            txtTeZoeken.Text = Trim(GridText) & "%"
            refreshView()

        Else
            txtTeZoeken.Text = "%"
            txtTeZoeken.Focus()
        End If

    End Sub
    Private Sub VulcmbSortering()
        Dim T As Short
        sorteringComboBox.Items.Clear()
        For T = 0 To FlAantalIndexen(SharedFl)
            Dim sortveldString As String = Trim(JetTableUseIndex(SharedFl, T))
            sorteringComboBox.Items.Add("+" & sortveldString & "; " & FLIndexCaption(SharedFl, T))
        Next
        If SharedIndex Then
            sorteringComboBox.SelectedIndex = SharedIndex
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

        Ktrl = 9

    End Sub

    Private Sub zoekenButton_Click(sender As Object, e As EventArgs) Handles zoekenButton.Click

        On Error Resume Next
        If zoekenButton.Text = "Ok" Then
            If XLogKey = "" Then
                'MsgBox("er is iets mis")
                'poging om de eerste record door te geven van recordset...
                If datPrimaryRS.RecordCount Then
                    datPrimaryRS.MoveFirst()
                    XLogKey = datPrimaryRS.Fields(datPrimaryRS.Fields.Item(0).Name).Value
                End If
                datPrimaryRS.Close()
            End If

            JetGet(SharedFl, 0, XLogKey)
            If Ktrl Then
                Beep()
                txtTeZoeken.Focus()
                Exit Sub
            Else
                RecordToField(SharedFl)
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
        datPrimaryRS.Open(sSQL, adntDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
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
                For CountTo = 0 To datPrimaryRS.Fields.Count - 1
                    sqlresultListView.Columns.Add(datPrimaryRS.Fields.Item(CountTo).Name, 100)
                Next
                sqlresultListView.View = View.Details
                Dim dataVeld As String
                If datPrimaryRS.RecordCount > 0 Then
                    datPrimaryRS.MoveFirst()
                    Do While Not datPrimaryRS.EOF
                        dataVeld = datPrimaryRS.Fields(datPrimaryRS.Fields.Item(0).Name).Value
                        Dim itemHier As New ListViewItem(dataVeld)
                        For CountTo = 1 To datPrimaryRS.Fields.Count - 1
                            If IsDBNull(datPrimaryRS.Fields(datPrimaryRS.Fields.Item(CountTo).Name).Value) Then
                                dataVeld = " "
                            Else
                                dataVeld = datPrimaryRS.Fields(datPrimaryRS.Fields.Item(CountTo).Name).Value
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
                XLogKey = itemX.SubItems.Item(0).Text
                txtTeZoeken.Text = XLogKey
                sqlresultListView.Enabled = True
                sqlresultListView.Focus()
            Else
                Beep()
                zoekenButton.Text = "Zoeken"
                txtTeZoeken.Focus()
            End If
            'datPrimaryRS.Close()
        End If

        'For CountTo = 0 To mfgLijst.get_Cols() - 1
        'If grdColWidth(CountTo) = 0 Then
        'Exit For
        'Else
        'mfgLijst.set_ColWidth(CountTo,  , grdColWidth(CountTo))
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

        XLogKey = sqlresultListView.FocusedItem.SubItems.Item(0).Text
        txtTeZoeken.Text = XLogKey

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