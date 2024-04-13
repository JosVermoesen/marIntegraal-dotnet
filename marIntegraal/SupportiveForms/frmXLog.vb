Option Strict Off
Option Explicit On
Public Class xLog
    Dim MaxPlijn As Short
    Dim ATLijn As Short
    Dim flHier As Integer
    Dim OptieTxt As String
    Dim TempoTxt As String
    Dim CrText As String
    Dim CrText2 As String
    Private Sub xLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        flHier = Val(Tag)
        SettingsLoading(Me)
        If selectonlyButton.Visible Then
        Else
            ArrangeDeckChairs(flHier)
            AcceptButton = WijzigenLijn
        End If
    End Sub
    Private Sub Annuleren_Click(sender As Object, e As EventArgs) Handles Annuleren.Click
        XLogKey = ""
        GridText = ""
        WindowState = System.Windows.Forms.FormWindowState.Normal
        Hide()
    End Sub
    Private Sub xLog_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dim X As Boolean
        X = SettingsSaving(Me)
    End Sub
    Private Sub xLog_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        On Error Resume Next
        TabControl.Width = Width - 20
        TabControl.Height = Height - 80
        Afsluiten.Top = Height - 70
        selectonlyButton.Top = Height - 70
        Annuleren.Top = Height - 70
        WijzigenLijn.Top = Height - 70
    End Sub
    Private Sub X_SelectedIndexChanged(sender As Object, e As EventArgs) Handles X.SelectedIndexChanged
        XLogKey = X.FocusedItem.SubItems.Item(2).Text
    End Sub
    Private Sub X_DoubleClick(sender As Object, e As EventArgs) Handles X.DoubleClick
        If selectonlyButton.Visible Then
            selectonlyButton.PerformClick()
        Else
            WijzigenLijn.PerformClick()
        End If
    End Sub
    Private Sub WijzigenLijn_Click(sender As Object, e As EventArgs) Handles WijzigenLijn.Click
        On Error Resume Next
        Dim codeString As String
        Dim inputString As String
        Dim omsString As String
        Dim tijdelijk As String
        Dim itemX As ListViewItem
        itemX = X.FocusedItem
        codeString = itemX.SubItems.Item(0).Text
        omsString = itemX.SubItems.Item(1).Text
        inputString = itemX.SubItems.Item(2).Text
        'MsgBox(codeString & " / " & omsString & " / " & inputString)
        If Mid(codeString, 2, 2) <> "  " And Mid(codeString, 1, 1) <> "@" Then
            XKeyDown(codeString, inputString)
            If GridText = "" Then
            Else
                tijdelijk = Mid(GridText, 1, InStr(GridText, ":") - 1)
                AdoInsertToRecord(flHier, tijdelijk, Mid(codeString, 5, 5))
                ArrangeDeckChairs(flHier)
            End If
            ' X_KeyDownEvent(X, New AxMSFlexGridLib.DMSFlexGridEvents_KeyDownEvent(17, 0))
            'If X.Row < X.Rows - 1 Then
            'X.Row = X.Row + 1
            'If X.Row > 6 Then
            'X.TopRow = X.Row - 5
            'End If
            'End If
            'X.Focus()
        Else
            'Msg = ""
            If Mid(codeString, 10, 1) = "-" Then
                Msg = "Deze informatie kan niet gewijzigd worden..."
                GridText = "Edit No"
            Else
                GridText = "Edit Yes"
            End If
            If Mid(codeString, 1, 1) = "@" Then
                Msg = Mid(codeString, 1, 3)
            Else
                Msg = Msg & QuickHelp(Mid(codeString, 1, 3))
            End If
            'X.Col = 2
            'ATLijn = Val(Mid(TeleBibCode(X.Row - 1), 10, 1))
            tijdelijk = vsfInputBox(Msg, omsString, inputString, "")
            If inputString = tijdelijk Then
            Else
                AdoInsertToRecord(flHier, tijdelijk, Mid(codeString, 5, 5))
                ArrangeDeckChairs(flHier)
            End If
            'If X.Row < X.Rows - 1 Then
            'X.Row = X.Row + 1
            'If X.Row > 6 Then
            'X.TopRow = X.Row - 5
            'End If
            'End If
            'X.Focus()
            'End If
        End If
    End Sub
    Private Sub Afsluiten_Click(sender As Object, e As EventArgs) Handles Afsluiten.Click
        Dim codeString As String
        Dim inputString As String
        Dim omsString As String
        Dim itemX As ListViewItem
        itemX = X.Items.Item(0)
        codeString = itemX.SubItems.Item(0).Text
        omsString = itemX.SubItems.Item(1).Text
        inputString = itemX.SubItems.Item(2).Text
        If codeString = "" Then
            If Mid(Text, 1, 6) = "Schade" Then
                XLogKey = "Nieuw"
            End If
        Else
            XLogKey = codeString & vbCrLf
            XLogKey = XLogKey & omsString '???? of inputstring ???
        End If
        Hide()
    End Sub
    Private Sub XKeyDown(xCode As String, xText As String)
        Dim DummyText As String
        Dim resultString As String
        Dim BoxType As Short
        DummyText = xText
        If Mid(xText, 1, 3) = "Log" Then
            Select Case Mid(xCode, 2, 2)
                Case "K ", "L ", "LC", "R ", "R3", "R4", "R6", "R7"
                    'If EventArgs.KeyCode <> 17 Then Exit Sub
                    SharedIndex = 0
                    Select Case Mid(xCode, 2, 1)
                        Case "K"
                            SharedFl = TableOfCustomers
                        Case "L"
                            SharedFl = TableOfSuppliers
                        Case "R"
                            SharedFl = TableOfLedgerAccounts
                        Case Else
                            MsgBox("nog niks")
                    End Select
                    GridText = ""
                    If Mid(xCode, 3, 2) <> "  " Then
                        If DummyText <> "" Then
                            If SharedFl = TableOfSuppliers And Mid(xCode, 3, 2) = "CO" Then
                                GridText = "CO" & DummyText
                            Else
                                GridText = DummyText
                            End If
                        Else
                            GridText = Mid(xCode, 3, 2) & "@Beperk@"
                        End If
                    Else
                        GridText = DummyText
                    End If
                    SqlSearch.ShowDialog()
                    If Ktrl = 0 Then
                        If SharedFl = TableOfSuppliers And Mid(xCode, 3, 2) = "CO" Then
                            resultString = Trim(Mid(FVT(SharedFl, 0), 3)) 'X.Text = RTrim(Mid(FVT(SharedFl, 0), 3))
                        Else
                            resultString = FVT(SharedFl, 0) 'X.Text = FVT(SharedFl, 0)
                        End If
                    End If
                Case "  "
                    Stop
                Case Else
                    Stop
                    Select Case Mid(xCode, 1, 1)
                        Case " "
                            BoxType = 0
                        Case "0" To "9"
                            BoxType = 1
                    End Select
                    'Select Case EventArgs.KeyCode
                    'Case 17
                    'aIndex = Val(Mid(TeleBibCode(X.Row - 1), 1, 3))
                    'If BoxType = 1 Then
                    'aIndex = aIndex + 1000
                    'End If
                    'X.Col = 2
                    'DummyText = X.Text
                    'GridText = DummyText
                    'KeuzeVSF.ShowDialog()
                    'If GridText <> DummyText Then
                    'DummyText = GridText
                    'X.Text = DummyText
                    'End If
            End Select
        Else
            Select Case Mid(xCode, 1, 1)
                Case " "
                    BoxType = 0
                Case "0" To "9"
                    BoxType = 1
            End Select
            SharedIndex = Val(Mid(xCode, 1, 3))
            If BoxType = 1 Then
                SharedIndex = SharedIndex + 1000
            End If
            DummyText = xText
            GridText = DummyText
            KeuzeVSF.ShowDialog()
            If GridText <> DummyText Then
                DummyText = GridText
                xText = DummyText
            End If
        End If
    End Sub
    Private Function QuickHelp(ByRef InfoString As String) As String
        QuickHelp = ""
        Select Case Mid(InfoString, 1, 1)
            Case "1"
                QuickHelp = "Naam of adres"
            Case "2"
                QuickHelp = "Beschrijving, tekst of omschrijving"
            Case "3"
                QuickHelp = "Een Bedrag in + of -"
            Case "4"
                QuickHelp = "Een hoeveelheid (+)"
            Case "5"
                QuickHelp = "Kode (1 of meer tekens)"
            Case "6"
                QuickHelp = "Index (000.00)"
            Case "7"
                QuickHelp = "Referentie"
            Case "8"
                QuickHelp = "Percentage (max. 999)"
            Case "9"
                QuickHelp = "Datum (DDMMEEJJ)"
            Case "A"
                QuickHelp = "Communicatiekanalen (telefoon, fax...)"
            Case "B"
                QuickHelp = "Financiële rekening (xxx-xxxxxxx-xx)"
            Case "b"
                QuickHelp = "Btw Nummer of Nationaal nummer (xxx.xxx.xxx)"
            Case "c", "d"
                QuickHelp = "Geldige bestandsnaam a.u.b"
            Case "z"
                QuickHelp = "Volledige datum als sleutel"
        End Select
    End Function
    Private Sub selectonlyButton_Click(sender As Object, e As EventArgs) Handles selectonlyButton.Click
        Dim codeString As String
        Dim itemX As ListViewItem
        itemX = X.FocusedItem
        codeString = itemX.SubItems.Item(0).Text
        XLogKey = codeString & vbCrLf
        Hide()
    End Sub
End Class