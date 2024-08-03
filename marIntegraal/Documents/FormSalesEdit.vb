Option Strict Off
Option Explicit On

Public Class FormSalesEdit

    Dim DefaultKode As String = Space(1)
    Dim LijnType As String = Space(1)
    Dim OpbrengstDefault As String = Space(7)

    Dim SubEx As Double
    Dim SubIn As Double
    Dim dHg As Double
    Dim nAnt As Single
    Dim nVol As Single

    Dim vkMaskAantal As String

    Private Sub FormSalesEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim T As Integer
        Dim X As Integer
        Dim Pipo As String
        Dim Taal = 2

        For T = 0 To 9
            CbKeuze0.Items.Add(fmarBoxText("004", Format(Taal), Format(T)))
        Next T
        T = 65
        Do While fmarBoxText("004", Format(Taal), Chr(T)) <> ""
            CbKeuze0.Items.Add(fmarBoxText("004", Format(Taal), Chr(T)))
            T += 1
        Loop
        CbKeuze0.SelectedItem = 0

        'For T = 0 To 9
        '    CbKeuze1.Items.Add(fmarBoxText("024", Format(Taal), Format(T)))
        'Next T
        'CbKeuze1.SelectedItem = 0

        'Pipo = SleutelDok(11)
        OpbrengstDefault = XLOG_KEY
        'OpbrengstDefault = String99(READING, 25)

        DefaultKode = AdoGetField(TABLE_CUSTOMERS, "#v111 #")
        If DefaultKode = " " Then
            DefaultKode = String99(READING, 183)
        End If

        Dim PuntPos As Integer

        vkMaskAantal = String99(READING, 300)
        PuntPos = InStr(vkMaskAantal, ".")
        If PuntPos Then
            vkMaskAantal = Format(PuntPos - 1, "#") & Mid(vkMaskAantal, PuntPos)
        End If
        For T = 1 To 6
            If Len(fmarBoxText("002", "2", Format(T))) <> 0 Then
                CbKeuze1.Items.Add(fmarBoxText("002", "2", Format(T)))
            End If
        Next T
        If VAT_BOBTHEBUILDERS = True Then
            CbKeuze1.Enabled = False
            CbKeuze1.SelectedIndex = 0
        ElseIf DefaultKode = "6" Then
            CbKeuze1.SelectedIndex = CbKeuze1.Items.Count - 1
        ElseIf Val(DefaultKode) > CbKeuze1.Items.Count - 1 Then
            MsgBox("Btw kode kan niet ! " + DefaultKode + vbCrLf + vbCrLf + "Kontroleer Setup boekjaar en parameters a.u.b. !")
            CbKeuze1.SelectedIndex = 2
        Else
            CbKeuze1.SelectedIndex = Val(DefaultKode) - 1
        End If

        If GRIDTEXT <> "" Then
            LijnType = GRIDTEXT.Substring(GRIDTEXT.Length - 1)

            Select Case LijnType
                Case "0", "1"
                    BtnOk.Enabled = True
                    TbInfo6.TabIndex = 0

                    TbInfo1.MaxLength = 40
                    TbInfo1.Text = RTrim$(Mid(GRIDTEXT, 1, 40))
                    GRIDTEXT = Mid(GRIDTEXT, 42)

                    TbInfo4.Text = Mid(GRIDTEXT, 1, 11)
                    GRIDTEXT = Mid(GRIDTEXT, 13)

                    TbInfo6.Text = Mid(GRIDTEXT, 1, 7)
                    GRIDTEXT = Mid(GRIDTEXT, 9)

                    TbInfo7.Text = Mid(GRIDTEXT, 1, 12)
                    GRIDTEXT = Mid(GRIDTEXT, 14)

                    TbInfo2.Text = Mid(GRIDTEXT, 1, 6)
                    GRIDTEXT = Mid(GRIDTEXT, 8)

                    For T = 0 To CbKeuze0.Items.Count - 1
                        If Mid(CbKeuze0.Items.Item(T), 1) = Mid(GRIDTEXT, 1, 1) Then
                            CbKeuze0.SelectedIndex = T
                            Exit For
                        End If
                    Next
                    GRIDTEXT = Mid(GRIDTEXT, 3)

                    TbInfo5.Text = Mid(GRIDTEXT, 1, 3)
                    GRIDTEXT = Mid(GRIDTEXT, 5)

                    If Val(Mid(GRIDTEXT, 1, 1)) = 6 Then
                        CbKeuze1.SelectedIndex = CbKeuze1.Items.Count - 1
                    Else
                        CbKeuze1.SelectedIndex = Val(Mid(GRIDTEXT, 1, 1)) - 1
                    End If
                    GRIDTEXT = Mid(GRIDTEXT, 3)

                    TbInfo3.Text = Mid(GRIDTEXT, 1, 7)
                    GRIDTEXT = Mid(GRIDTEXT, 9)

                    TbInfo0.Text = Mid(GRIDTEXT, 1, 13)
                    GRIDTEXT = Mid(GRIDTEXT, 15)
                    If Len(GRIDTEXT) <> 1 Then
                        MessageBox.Show("GRIDTEXT is niet leeg op het einde!")
                    End If

                Case "2"
                    BtnOk.Enabled = True
                    TbInfo1.MaxLength = 75
                    TbInfo1.Text = RTrim$(Mid(GRIDTEXT, 1, 75))

                    Text = "Vrije tekst"
                    Height = 124
                    LabelProduct0.Visible = False
                    TbInfo0.Visible = False
                    LabelSensitive.Visible = False
                    CbSortering.Visible = False

                Case Else
                    MsgBox("Stop")
            End Select
        Else
            TbInfo3.Text = OpbrengstDefault
            LijnType = "0" 'Format(SHARED_INDEX) ??
        End If

        Select Case LijnType
            Case "0"

                For T = 0 To FL_NUMBEROFINDEXEN(TABLE_PRODUCTS)
                    CbSortering.Items.Add(Format(T, "00") + ":" + FLINDEX_CAPTION(TABLE_PRODUCTS, T))
                Next
                On Error Resume Next

                CbSortering = SettingLoading(Name, "ProduktSortering")

                TbInfo1.Enabled = False
                TbInfo4.Enabled = False

                CalculateTotal()
            Case "1"
                TbInfo0.Text = "OMSCHRIJVING"
                TbInfo2.Text = Dec$(1, "###0.0")
                CbKeuze0.SelectedIndex = 9

                LabelProduct0.Visible = False
                LabelProduct1.Visible = False
                TbInfo0.Visible = False
                TbInfo2.Visible = False
                CbKeuze0.Visible = False
                CalculateTotal()
                TbInfo1.TabIndex = 0

            Case "2"
                TbInfo1.MaxLength = 75
                'TekstInfo(1).Text = vSet((TekstInfo(1).Text), 75)
                CbKeuze0.SelectedIndex = 0

                LabelProduct0.Visible = False
                LabelProduct1.Visible = False
                CbKeuze0.Visible = False
                CbKeuze1.Visible = False


                TbInfo0.Visible = False
                LabelVerkoop0.Visible = False
                TbInfo1.Visible = False
                LabelVerkoop1.Visible = False
                TbInfo2.Visible = False
                LabelVerkoop5.Visible = False
                TbInfo3.Visible = False
                LabelVerkoop6.Visible = False
                TbInfo4.Visible = False
                LabelVerkoop8.Visible = False
                TbInfo5.Visible = False
                TbInfo6.Visible = False
                TbInfo7.Visible = False
                TbInfo8.Visible = False

                TbInfo9.Visible = False
                '            BTWType.Visible = False
                TbInfo1.Visible = True
                BtnOk.Enabled = True

        End Select

        If Len(TbInfo6.Text) Then
        Else
            TbInfo6.Text = "1"
        End If

        If XLOG_CASHREGISTER = "" Then
            CbVatFilter.Checked = Val(String99(READING, 182))
        Else
            CbVatFilter.Checked = True 'BTWType.Value = 1
            TbInfo2.Enabled = False
            TbInfo3.Enabled = False
            TbInfo4.Enabled = False
            TbInfo5.Enabled = False
            TbInfo6.Enabled = False
            CbKeuze0.Enabled = False
            CbKeuze1.Enabled = False
            CbVatFilter.Enabled = False
        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        GRIDTEXT = ""
        Hide()

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        '    If TekstInfo(6) = "*" Then Exit Sub

        '    Select Case LijnType
        '        Case "0", "1"
        '            TekstInfo(0).Text = vSet((TekstInfo(0).Text), 13) 'ProduktNummer
        '            TekstInfo(1).Text = vSet((TekstInfo(1).Text), 40) 'Omschrijving
        '            TekstInfo(2).Text = Dec$(Val(TekstInfo(2).Text), "###0.0") 'Verpakking
        '            TekstInfo(3).Text = vSet((TekstInfo(3).Text), 7) 'Boekhoudingrekening
        '            TekstInfo(4).Text = Dec$(Val(TekstInfo(4).Text), "######0.000") 'Verkoopprijs
        '            TekstInfo(5).Text = Dec$(Val(TekstInfo(5).Text), "##0") 'Korting
        '            TekstInfo(6).Text = Dec$(Val(TekstInfo(6).Text), vkMaskAantal) 'Aantal
        '            CalculateTotal()

        '            'controle voor mileulijn!!
        '            If BL_ENVIRONMENT = True Then

        '                MilieuGridText = ""

        '                Dim strMilieu() As String
        '                Dim telmilieu As Integer

        '                strMilieu = Split(AdoGetField(TABLE_PRODUCTS, "#v261 #"), ";")
        '                If LijnType = "1" Then
        '                Else
        '                    For telmilieu = 0 To UBound(strMilieu)
        '                        bGet TABLE_PRODUCTS, 0, vSet(strMilieu(telmilieu), 13)
        '                    If KTRL Then
        '                            MsgBox "subcode " & strMilieu(telmilieu) & " niet te vinden"
        '                        BL_ENVIRONMENT = False
        '                        Else
        '                            RecordToVeld TABLE_PRODUCTS
        '                        MilieuGridText = MilieuGridText + vSet(AdoGetField(TABLE_PRODUCTS, "#v105 #"), 40) + Chr$(124) + Dec$(Val(AdoGetField(TABLE_PRODUCTS, "#e112 #")), "######0.000") + Chr$(124) + TekstInfo(6) + Chr$(124) + Dec$(Val(TekstInfo(6)) * Val(AdoGetField(TABLE_PRODUCTS, "#e112 #")), "#######0.000") + Chr$(124) + Dec$(1, "###0.0") + Chr$(124)
        '                            MilieuGridText = MilieuGridText + AdoGetField(TABLE_PRODUCTS, "#v106 #") + Chr$(124) + Dec$(0, "##0") + Chr$(124) + AdoGetField(TABLE_PRODUCTS, "#v111 #") + Chr$(124) + vSet(AdoGetField(TABLE_PRODUCTS, "#v117 #"), 7) + Chr$(124) + vSet(AdoGetField(TABLE_PRODUCTS, "#v102 #"), 13) + Chr$(124) + "0" + vbCrLf
        '                        End If
        '                    Next
        '                End If
        '            End If
        '            If TekstInfo(1).Text = Space$(Len(TekstInfo(1).Text)) Or TekstInfo(3).Text = Space$(Len(TekstInfo(3).Text)) Then
        '                TekstInfo(1).Text = ""
        '            Else
        '                GRIDTEXT = TekstInfo(1).Text + Chr$(124) + TekstInfo(4).Text + Chr$(124) + TekstInfo(6).Text + Chr$(124) + TekstInfo(7).Text + Chr$(124) + TekstInfo(2).Text + Chr$(124)
        '                GRIDTEXT = GRIDTEXT + Left(Keuze(0).Text, 1) + Chr$(124) + TekstInfo(5).Text + Chr$(124) + Left(Keuze(1).Text, 1) + Chr$(124) + TekstInfo(3).Text + Chr$(124) + TekstInfo(0).Text + Chr$(124) + LijnType
        '                WijzigenVerkoop.Hide
        '            End If

        '        Case "2"
        '            TekstInfo(1).Text = vSet((TekstInfo(1).Text), 75)
        '            GRIDTEXT = TekstInfo(1).Text + Chr$(124) + LijnType
        '            WijzigenVerkoop.Hide
        '    End Select


    End Sub

    Private Sub CbSortering_Click(sender As Object, e As EventArgs) Handles CbSortering.Click

        SettingSaving(Name, "ProduktSortering", CbSortering.Text)

    End Sub

    Private Sub CalculateTotal()

        nVol = Val(TbInfo2.Text)
        dHg = Val(TbInfo4.Text)
        nAnt = Val(TbInfo6.Text)

        SubEx = (dHg * nAnt) - ((dHg * nAnt) * Val(TbInfo5.Text) / 100)
        SubIn = SubEx + (SubEx * Val(Mid(CbKeuze1.Text, 4, 4)) / 100)
        TbInfo7.Text = Dec$((SubEx), "#######0.000")
        TbInfo8.Text = Dec$((SubIn), "#######0.000")
        TbInfo9.Text = TbInfo4.Text

    End Sub

    Private Sub CbKeuze1_Click(sender As Object, e As EventArgs) Handles CbKeuze1.Click

        CalculateTotal()

    End Sub

    Private Sub ProdukTekstInfo()

        Dim HuidigeStock As Single
        Dim MinimumStock As Single

        If Trim(AdoGetField(TABLE_PRODUCTS, "#v261 #")) = "" Then
            LabelSensitive.Visible = False
        Else
            LabelSensitive.Visible = True
        End If
        BL_ENVIRONMENT = LabelSensitive.Visible

        TbInfo0.Text = AdoGetField(TABLE_PRODUCTS, "#v102 #")
        TbInfo1.Text = AdoGetField(TABLE_PRODUCTS, "#v105 #")
        TbInfo5.Text = AdoGetField(TABLE_PRODUCTS, "#v300 #")

        For T = 0 To CbKeuze0.Items.Count - 1
            If Mid(CbKeuze0.Items.Item(T).ToString, 1, 1) = AdoGetField(TABLE_PRODUCTS, "#v106 #") Then
                CbKeuze0.SelectedIndex = T
                Exit For
            End If
        Next

        If VAT_BOBTHEBUILDERS = True Then
            CbKeuze1.SelectedIndex = 0
        ElseIf Val(AdoGetField(TABLE_PRODUCTS, "#v111 #")) = 6 Then
            CbKeuze1.SelectedIndex = 3
        Else
            CbKeuze1.SelectedIndex = Val(AdoGetField(TABLE_PRODUCTS, "#v111 #")) - 1
        End If

        nVol = Val(AdoGetField(TABLE_PRODUCTS, "#v107 #"))
        TbInfo2.Text = Dec$((nVol), "###0.0")
        If InStr(DIRECTSELL_STRING, "EUR") Then
            TbInfo4.Text = Dec$(Val(AdoGetField(TABLE_PRODUCTS, "#e112 #")) * nVol, "######0.000")
        Else
            TbInfo4.Text = Dec$(Val(AdoGetField(TABLE_PRODUCTS, "#v112 #")) * nVol, "######0.000")
        End If
        TbInfo9.Text = TbInfo4.Text

        dHg = Val(TbInfo4.Text)
        If Val(TbInfo5.Text) <> 0 Then
        Else
            TbInfo5.Text = Dec$(Val(AdoGetField(TABLE_CUSTOMERS, "#vs05 #")), "##0")
        End If
        TbInfo6.Text = Dec$(1, vkMaskAantal)
        nAnt = 1

        HuidigeStock = Val(AdoGetField(TABLE_PRODUCTS, "#v114 #")) + Val(AdoGetField(TABLE_PRODUCTS, "#v119 #")) - Val(AdoGetField(TABLE_PRODUCTS, "#v120 #"))
        MinimumStock = Val(AdoGetField(TABLE_PRODUCTS, "#v115 #"))
        If MinimumStock > HuidigeStock Then
            LabelMinStockInfo.Visible = True
        Else
            LabelMinStockInfo.Visible = False
        End If
        LabelMinStockInfo.Text = "Min.Stock: " + Format(MinimumStock) + " / Stock: " + Format(HuidigeStock) + " / Plaats: " + AdoGetField(TABLE_PRODUCTS, "#v109 #")

        '    'TaksKeuze(0).ListIndex = Val(AdoGetField(TABLE_PRODUCTS, "#v168 #"))
        '    'Select Case Val(AdoGetField(TABLE_PRODUCTS, "#v168 #"))
        '    '    Case 1 To 9
        '    '        TaksKeuze(0).Visible = True
        '    '    Case Else
        '    '        TaksKeuze(0).Visible = False
        '    'End Select
        '    CalculateTotal()
        '    'Ok.Enabled = True

    End Sub

    Private Sub TbInfo0_Leave(sender As Object, e As EventArgs) Handles TbInfo0.Leave

        BtnOk.Enabled = True
        If Trim(TbInfo0.Text) = "" Then
        Else
            JetGet(TABLE_PRODUCTS, 0, Trim(TbInfo0.Text))
            If KTRL Then
                TbInfo0.Text = ""
                TbInfo0.Focus() : Exit Sub
            Else
                RecordToField(TABLE_PRODUCTS)
                ProdukTekstInfo()
                JetGet(TABLE_LEDGERACCOUNTS, 0, SetSpacing(AdoGetField(TABLE_PRODUCTS, "#v117 #"), 7))
                If KTRL Then
                    MsgBox("Verkooprekening " & SetSpacing(AdoGetField(TABLE_PRODUCTS, "#v117 #"), 7) & " bestaat niet (meer).  Eerst verbeteren a.u.b. in productfiche", vbExclamation)
                    TbInfo0.Focus() : Exit Sub
                Else
                    RecordToField(TABLE_LEDGERACCOUNTS)
                    TbInfo3.Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
                    'SnelHelpPrint AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #"), blLogging
                    BtnOk.Enabled = True
                End If
                TbInfo6.Focus()
            End If
        End If

    End Sub

    Private Sub TbInfo2_Leave(sender As Object, e As EventArgs) Handles TbInfo2.Leave

        nVol = Val(TbInfo2.Text)
        TbInfo2.Text = Dec$((nVol), "###0.0")
        If InStr(DIRECTSELL_STRING, "EUR") Then
            TbInfo4.Text = Dec$(Val(AdoGetField(TABLE_PRODUCTS, "#e112 #")) * nVol, "######0.000")
        Else
            TbInfo4.Text = Dec$(Val(AdoGetField(TABLE_PRODUCTS, "#v112 #")) * nVol, "######0.000")
        End If
        TbInfo9.Text = TbInfo4.Text

    End Sub

    Private Sub TbInfo3_Leave(sender As Object, e As EventArgs) Handles TbInfo3.Leave

        JetGet(TABLE_LEDGERACCOUNTS, 0, SetSpacing((TbInfo3.Text), 7))
        If KTRL Then
            If FVT(TABLE_LEDGERACCOUNTS, 0) Then ' = String$(7, 0) Then
                Exit Sub
            Else
                TbInfo3.Text = OpbrengstDefault
                TbInfo3.Focus()
            End If
        Else
            RecordToField(TABLE_LEDGERACCOUNTS)
            TbInfo3.Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
            ' SnelHelpPrint AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #"), blLogging
        End If

    End Sub

    Private Sub TbInfo4_Leave(sender As Object, e As EventArgs) Handles TbInfo4.Leave

        Dim TempPCT As Single

        If TbInfo4.Text = TbInfo9.Text Then
        ElseIf CbVatFilter.Checked Then
            dHg = Val(TbInfo4.Text)
            TempPCT = Val(Mid(CbKeuze1.Text, 4, 4))
            dHg = dHg * 100 / (100 + TempPCT)
            TbInfo4.Text = Dec$((dHg), "######0.000")
            CalculateTotal()
            BtnOk.Enabled = True
        Else
            TbInfo4.Text = Dec$(Val(TbInfo4.Text), "######0.000")
            CalculateTotal()
            BtnOk.Enabled = True
        End If

    End Sub

    Private Sub TbInfo5_Leave(sender As Object, e As EventArgs) Handles TbInfo5.Leave

        If TbInfo0.Visible = True Then
            If (Val(TbInfo4.Text) / Val(TbInfo2.Text)) / (1 + (Val(TbInfo5.Text) / 100)) < Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")) Then
                MSG = "Uw verkoopprijs wordt kleiner dan uw aankoopprijs !  Is dit de bedoeling ?"
                CTRL_BOX = MsgBox(MSG, 292)
                If CTRL_BOX = 6 Then
                Else
                    TbInfo5.Text = "0"
                End If
            End If
        End If
        TbInfo5.Text = Dec$(Val(TbInfo5.Text), "##0")

    End Sub

    Private Sub TbInfo6_Leave(sender As Object, e As EventArgs) Handles TbInfo6.Leave

        If TbInfo6.Text = "*" Then
            If CbKeuze0.Visible = True Then
                If Mid(CbKeuze0.Text, 1, 1) = "5" Or Mid(CbKeuze0.Text, 1, 1) = "3" Then
                    ' frmVanGucht.Show 1
                Else
                    TbInfo6.Text = Dec$(1, vkMaskAantal)
                End If
            Else
                TbInfo6.Text = Dec$(1, vkMaskAantal)
            End If
        End If

        nAnt = Val(TbInfo6.Text)
        TbInfo6.Text = Dec$((nAnt), vkMaskAantal)
        If BtnOk.Enabled = True Then BtnOk.Focus()
        CalculateTotal()

    End Sub

    Private Sub TbInfo0_Enter(sender As Object, e As EventArgs) Handles TbInfo0.Enter

        TbInfo0.SelectionStart = 0
        TbInfo0.SelectionLength = Len(TbInfo0.Text)
        LabelQuickHelp.Text = "Dubbelklikken of [Ctrl] voor geïndexeerd zoeken"

        If TbInfo3.Text <> "" Then
            JetGet(TABLE_LEDGERACCOUNTS, 0, SetSpacing((TbInfo3.Text), 7))
            If KTRL Then
            Else
                RecordToField(TABLE_LEDGERACCOUNTS)
                LabelQuickHelp.Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #")
            End If
        End If

    End Sub

    Private Sub TbInfo3_Enter(sender As Object, e As EventArgs) Handles TbInfo3.Enter

        TbInfo3.SelectionStart = 0
        TbInfo3.SelectionLength = Len(TbInfo3.Text)
        LabelQuickHelp.Text = "Dubbelklikken of [Ctrl] voor geïndexeerd zoeken"

        If TbInfo3.Text <> "" Then
            JetGet(TABLE_LEDGERACCOUNTS, 0, SetSpacing((TbInfo3.Text), 7))
            If KTRL Then
            Else
                RecordToField(TABLE_LEDGERACCOUNTS)
                LabelQuickHelp.Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #")
            End If
        End If

    End Sub

    Private Sub TbInfo4_Enter(sender As Object, e As EventArgs) Handles TbInfo4.Enter

        ' Was in VB6 Ok.Default = True
        BtnOk.Enabled = True
        TbInfo4.SelectionStart = 0
        TbInfo4.SelectionLength = Len(TbInfo4.Text)

    End Sub

    Private Sub TbInfo6_Enter(sender As Object, e As EventArgs) Handles TbInfo6.Enter

        TbInfo6.SelectionStart = 0
        If Val(TbInfo6.Text) = 0 Then
            TbInfo6.Text = Dec$(1, "###.000")
        End If
        TbInfo6.SelectionLength = Len(TbInfo6.Text)

    End Sub

    Private Sub TbInfo4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbInfo4.KeyPress

        TbInfo9.Text = ""

    End Sub

    Private Sub TbInfo0_KeyDown(sender As Object, e As KeyEventArgs) Handles TbInfo0.KeyDown

        BtnOk.Enabled = False

    End Sub

End Class


'Private Sub TekstInfo_DblClick(Index As Integer)

'    TekstInfo_KeyDown Index, 17, 0

'End Sub


'Private Sub TekstInfo_KeyDown(Index As Integer, KeyCode As Integer, Shift As Integer)

'    Select Case KeyCode
'        Case 13 'Enter

'            On Error Resume Next
'            If Index = 4 Then Ok.Enabled = True : Ok.SetFocus : Exit Sub
'            If Index = 0 Then
'                SendKeys "{TAB}", True
'            Exit Sub
'            End If

'        Case 17 'Ctrl
'            Select Case Index
'                Case 0

'                    Ok.Enabled = False
'                    SharedFl = TABLE_PRODUCTS
'                    SHARED_INDEX = Val(Left(cmbSortering, 2))
'                    FVT(TABLE_PRODUCTS, 0) = String$(13, 0)
'                    GRIDTEXT = TekstInfo(0).Text
'                    SqlSearch.Show 1
'                If KTRL Then
'                        TekstInfo(0).Text = ""
'                        TekstInfo(0).SetFocus : Exit Sub
'                    Else
'                        RecordToVeld TABLE_PRODUCTS
'                    ProdukTekstInfo()
'                        bGet TABLE_LEDGERACCOUNTS, 0, vSet(AdoGetField(TABLE_PRODUCTS, "#v117 #"), 7)
'                    If KTRL Then
'                            TekstInfo(3).Text = ""
'                            TekstInfo(0).SetFocus : Exit Sub
'                        ElseIf Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")) <= 0 Then
'                            MsgBox "Aankoopprijs is onbekend.  Geef de inkoopprijs in van dit artikel a.u.b. via de produktfiche !"
'                        TekstInfo(0).Text = ""
'                            TekstInfo(0).SetFocus : Exit Sub
'                        Else
'                            RecordToVeld TABLE_LEDGERACCOUNTS
'                        TekstInfo(3).Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
'                            SnelHelpPrint AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #"), blLogging
'                        Ok.Enabled = True
'                        End If
'                    End If

'                Case 3
'                    SharedFl = TABLE_LEDGERACCOUNTS
'                    SHARED_INDEX = 0
'                    FVT(TABLE_LEDGERACCOUNTS, 0) = String$(7, 0)
'                    GRIDTEXT = TekstInfo(3).Text
'                    SqlSearch.Show 1
'                If KTRL Then
'                        TekstInfo(1).Text = ""
'                        FVT(TABLE_LEDGERACCOUNTS, 0) = ""
'                        Ok.Enabled = False
'                    Else
'                        RecordToVeld TABLE_LEDGERACCOUNTS
'                    TekstInfo(3).Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
'                        Ok.Enabled = True
'                    End If

'            End Select
'    End Select

'End Sub


