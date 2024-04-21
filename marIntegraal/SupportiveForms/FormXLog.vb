Option Strict Off
Option Explicit On
Public Class FormXlog
    Dim MaxPlijn As Short
    Dim ATLijn As Short
    Dim flHier As Integer
    Dim OptieTxt As String
    Dim TempoTxt As String
    Dim CrText As String
    Dim CrText2 As String
    Dim lineIndex As Short

    Private Sub FormXlog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        flHier = Val(Tag)
        SettingsLoading(Me)
        If BtnSelectOnly.Visible Then
        Else
            ArrangeDeckChairs(flHier)
            AcceptButton = BtnEditLine
            X.Items.Item(0).Selected = True
        End If

    End Sub

    Private Sub FormXlog_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Dim X As Boolean
        X = SettingsSaving(Me)

    End Sub

    Private Sub FormXlog_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        On Error Resume Next
        TabControl.Width = Width - 20
        TabControl.Height = Height - 80
        BtnHideAndGoBack.Top = Height - 70
        BtnSelectOnly.Top = Height - 70
        BtnCancel.Top = Height - 70
        BtnEditLine.Top = Height - 70

    End Sub

    Private Sub X_SelectedIndexChanged(sender As Object, e As EventArgs) Handles X.SelectedIndexChanged
        On Error Resume Next
        XLOG_KEY = X.FocusedItem.SubItems.Item(2).Text
    End Sub
    Private Sub X_DoubleClick(sender As Object, e As EventArgs) Handles X.DoubleClick
        If BtnSelectOnly.Visible Then
            BtnSelectOnly.PerformClick()
        Else
            BtnEditLine.PerformClick()
        End If
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
                    SHARED_INDEX = 0
                    Select Case Mid(xCode, 2, 1)
                        Case "K"
                            SHARED_FL = TABLE_CUSTOMERS
                        Case "L"
                            SHARED_FL = TABLE_SUPPLIERS
                        Case "R"
                            SHARED_FL = TABLE_LEDGERACCOUNTS
                        Case Else
                            MsgBox("nog niks")
                    End Select
                    GRIDTEXT = ""
                    If Mid(xCode, 3, 2) <> "  " Then
                        If DummyText <> "" Then
                            If SHARED_FL = TABLE_SUPPLIERS And Mid(xCode, 3, 2) = "CO" Then
                                GRIDTEXT = "CO" & DummyText
                            Else
                                GRIDTEXT = DummyText
                            End If
                        Else
                            GRIDTEXT = Mid(xCode, 3, 2) & "@Beperk@"
                        End If
                    Else
                        GRIDTEXT = DummyText
                    End If
                    SqlSearch.ShowDialog()
                    If KTRL = 0 Then
                        If SHARED_FL = TABLE_SUPPLIERS And Mid(xCode, 3, 2) = "CO" Then
                            resultString = Trim(Mid(FVT(SHARED_FL, 0), 3)) 'X.Text = RTrim(Mid(FVT(SHARED_FL, 0), 3))
                        Else
                            resultString = FVT(SHARED_FL, 0) 'X.Text = FVT(SHARED_FL, 0)
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
                    'A_INDEX = Val(Mid(TELEBIB_CODE(X.Row - 1), 1, 3))
                    'If BoxType = 1 Then
                    'A_INDEX = A_INDEX + 1000
                    'End If
                    'X.Col = 2
                    'DummyText = X.Text
                    'GRIDTEXT = DummyText
                    'KeuzeVSF.ShowDialog()
                    'If GRIDTEXT <> DummyText Then
                    'DummyText = GRIDTEXT
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
            SHARED_INDEX = Val(Mid(xCode, 1, 3))
            If BoxType = 1 Then
                SHARED_INDEX = SHARED_INDEX + 1000
            End If
            DummyText = xText
            GRIDTEXT = DummyText
            FormBoxList.Text = X.FocusedItem.SubItems.Item(1).Text
            FormBoxList.ShowDialog()
            If GRIDTEXT <> DummyText Then
                DummyText = GRIDTEXT
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

    Private Sub BtnSelectOnly_Click(sender As Object, e As EventArgs) Handles BtnSelectOnly.Click

        Dim codeString As String
        Dim itemX As ListViewItem
        itemX = X.FocusedItem
        codeString = itemX.SubItems.Item(0).Text
        XLOG_KEY = codeString & vbCrLf
        Hide()

    End Sub

    Private Sub BtnHideAndGoBack_Click(sender As Object, e As EventArgs) Handles BtnHideAndGoBack.Click

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
                XLOG_KEY = "Nieuw"
            End If
        Else
            XLOG_KEY = codeString & vbCrLf
            XLOG_KEY &= omsString '???? of inputstring ???
        End If
        Hide()

    End Sub

    Private Sub BtnEditLine_Click(sender As Object, e As EventArgs) Handles BtnEditLine.Click

        On Error Resume Next
        Dim codeString As String
        Dim inputString As String
        Dim omsString As String
        Dim tijdelijk As String
        Dim itemX As ListViewItem

        itemX = X.FocusedItem
        lineIndex = X.FocusedItem.Index
        codeString = itemX.SubItems.Item(0).Text
        omsString = itemX.SubItems.Item(1).Text
        inputString = itemX.SubItems.Item(2).Text
        'MsgBox(codeString & " / " & omsString & " / " & inputString)
        If Mid(codeString, 2, 2) <> "  " And Mid(codeString, 1, 1) <> "@" Then
            XKeyDown(codeString, inputString)
            If GRIDTEXT = "" Then
            Else
                tijdelijk = Mid(GRIDTEXT, 1, InStr(GRIDTEXT, ":") - 1)
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
            'MSG = ""
            If Mid(codeString, 10, 1) = "-" Then
                MSG = "Deze informatie kan niet gewijzigd worden..."
                GRIDTEXT = "Edit No"
            Else
                GRIDTEXT = "Edit Yes"
            End If
            If Mid(codeString, 1, 1) = "@" Then
                MSG = Mid(codeString, 1, 3)
            Else
                MSG = MSG & QuickHelp(Mid(codeString, 1, 3))
            End If
            'X.Col = 2
            'ATLijn = Val(Mid(TELEBIB_CODE(X.Row - 1), 10, 1))
            tijdelijk = vsfInputBox(MSG, omsString, inputString, "")
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
        lineIndex += 1
        X.Items.Item(lineIndex).Selected = True
        X.Items.Item(lineIndex).Focused = True

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        XLOG_KEY = ""
        GRIDTEXT = ""
        WindowState = System.Windows.Forms.FormWindowState.Normal
        Hide()

    End Sub

End Class