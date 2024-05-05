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
                Case Else
                    MsgBox("Stop")
            End Select
        Else
            TbInfo3.Text = OpbrengstDefault
            LijnType = "0" 'Format(aIndex) ??
        End If

        Select Case LijnType
            '        Case "0"
            '            For T = 0 To FlAantalIndexen(FlProdukt)
            '                cmbSortering.AddItem Format(T, "00") + ":" + FLIndexCaption(FlProdukt, T)
            '        Next
            '            On Error Resume Next
            '            cmbSortering = LaadTekst(Me.Name, "ProduktSortering")

            '            TekstInfo(1).Enabled = False
            '            'TekstInfo(4).Enabled = False

            '            MaakTotaal()
            '        Case "1"
            '            TekstInfo(0).Text = "OMSCHRIJVING"
            '            TekstInfo(2).Text = Dec$(1, "###0.0")
            '            Keuze(0).ListIndex = 9

            '            ProduktLabel(0).Visible = False
            '            ProduktLabel(1).Visible = False
            '            TekstInfo(0).Visible = False
            '            TekstInfo(2).Visible = False
            '            Keuze(0).Visible = False
            '            MaakTotaal()
            '            TekstInfo(1).TabIndex = 0

            '        Case "2"
            '            TekstInfo(1).MaxLength = 75
            '            'TekstInfo(1).Text = vSet((TekstInfo(1).Text), 75)
            '            Keuze(0).ListIndex = 0

            '            ProduktLabel(0).Visible = False
            '            ProduktLabel(1).Visible = False
            '            Keuze(0).Visible = False
            '            Keuze(1).Visible = False

            '            For T = 0 To 8
            '                TekstInfo(T).Visible = False
            '                VerkoopLabel(T).Visible = False
            '            Next
            '            TekstInfo(9).Visible = False
            '            BTWType.Visible = False
            '            TekstInfo(1).Visible = True
            '            Ok.Enabled = True
        End Select

        If Len(TbInfo6.Text) Then
        Else
            TbInfo6.Text = "1"
        End If

        ' If XLogKassa = "" Then
        '    BTWType.Value = Val(String99(Lees, 182))
        ' Else
        '    BTWType.Value = 1
        '    TekstInfo(2).Enabled = False
        '    TekstInfo(3).Enabled = False
        '    TekstInfo(4).Enabled = False
        '    TekstInfo(5).Enabled = False
        '    TekstInfo(6).Enabled = False
        '    Keuze(0).Enabled = False
        '    Keuze(1).Enabled = False
        '    BTWType.Enabled = False
        ' End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        GRIDTEXT = ""
        Hide()

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

    End Sub

    Private Sub CbSortering_Click(sender As Object, e As EventArgs) Handles CbSortering.Click

        SettingSaving(Name, "ProduktSortering", CbSortering.Text)

    End Sub

End Class


'Private Sub Keuze_Click(Index As Integer)

'    Select Case Index
'        Case 1
'            MaakTotaal()
'    End Select

'End Sub

'Private Sub MaakTotaal()

'    nVol = Val(TekstInfo(2).Text)
'    dHg = Val(TekstInfo(4).Text)
'    nAnt = Val(TekstInfo(6).Text)

'    SubEx = (dHg * nAnt) - ((dHg * nAnt) * Val(TekstInfo(5).Text) / 100)
'    SubIn = SubEx + (SubEx * Val(Mid(Keuze(1).Text, 4, 4)) / 100)
'    TekstInfo(7).Text = Dec$((SubEx), "#######0.000")
'    TekstInfo(8).Text = Dec$((SubIn), "#######0.000")
'    TekstInfo(9).Text = TekstInfo(4).Text

'End Sub

'Private Sub Ok_Click()

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
'            MaakTotaal()

'            'controle voor mileulijn!!
'            If blMilieu = True Then

'                MilieuGridText = ""

'                Dim strMilieu() As String
'                Dim telmilieu As Integer

'                strMilieu = Split(vBibTekst(FlProdukt, "#v261 #"), ";")
'                If LijnType = "1" Then
'                Else
'                    For telmilieu = 0 To UBound(strMilieu)
'                        bGet FlProdukt, 0, vSet(strMilieu(telmilieu), 13)
'                    If KTRL Then
'                            MsgBox "subcode " & strMilieu(telmilieu) & " niet te vinden"
'                        blMilieu = False
'                        Else
'                            RecordToVeld FlProdukt
'                        MilieuGridText = MilieuGridText + vSet(vBibTekst(FlProdukt, "#v105 #"), 40) + Chr$(124) + Dec$(Val(vBibTekst(FlProdukt, "#e112 #")), "######0.000") + Chr$(124) + TekstInfo(6) + Chr$(124) + Dec$(Val(TekstInfo(6)) * Val(vBibTekst(FlProdukt, "#e112 #")), "#######0.000") + Chr$(124) + Dec$(1, "###0.0") + Chr$(124)
'                            MilieuGridText = MilieuGridText + vBibTekst(FlProdukt, "#v106 #") + Chr$(124) + Dec$(0, "##0") + Chr$(124) + vBibTekst(FlProdukt, "#v111 #") + Chr$(124) + vSet(vBibTekst(FlProdukt, "#v117 #"), 7) + Chr$(124) + vSet(vBibTekst(FlProdukt, "#v102 #"), 13) + Chr$(124) + "0" + vbCrLf
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

'End Sub

'Private Function ProdukTekstInfo()
'    Dim HuidigeStock As Single
'    Dim MinimumStock As Single

'    If Trim(vBibTekst(FlProdukt, "#v261 #")) = "" Then
'        Me.lbMilieu.Visible = False
'    Else
'        Me.lbMilieu.Visible = True
'    End If
'    blMilieu = Me.lbMilieu.Visible

'    TekstInfo(0).Text = vBibTekst(FlProdukt, "#v102 #")
'    TekstInfo(1).Text = vBibTekst(FlProdukt, "#v105 #")
'    TekstInfo(5).Text = vBibTekst(FlProdukt, "#v300 #")

'    For T = 0 To Keuze(0).ListCount - 1
'        If Left(Keuze(0).List(T), 1) = vBibTekst(FlProdukt, "#v106 #") Then
'            Keuze(0).ListIndex = T
'            Exit For
'        End If
'    Next

'    If BtwBouw = True Then
'        Keuze(1).ListIndex = 0
'    ElseIf Val(vBibTekst(FlProdukt, "#v111 #")) = 6 Then
'        Keuze(1).ListIndex = 3
'    Else
'        Keuze(1).ListIndex = Val(vBibTekst(FlProdukt, "#v111 #")) - 1
'    End If

'    nVol = Val(vBibTekst(FlProdukt, "#v107 #"))
'    TekstInfo(2).Text = Dec$((nVol), "###0.0")
'    If InStr(DirecteVerkoopString, "EUR") Then
'        TekstInfo(4).Text = Dec$(Val(vBibTekst(FlProdukt, "#e112 #")) * nVol, "######0.000")
'    Else
'        TekstInfo(4).Text = Dec$(Val(vBibTekst(FlProdukt, "#v112 #")) * nVol, "######0.000")
'    End If
'    TekstInfo(9).Text = TekstInfo(4).Text

'    dHg = Val(TekstInfo(4).Text)
'    If Val(TekstInfo(5).Text) <> 0 Then
'    Else
'        TekstInfo(5).Text = Dec$(Val(vBibTekst(FlKlant, "#vs05 #")), "##0")
'    End If
'    TekstInfo(6).Text = Dec$(1, vkMaskAantal)
'    nAnt = 1

'    HuidigeStock = Val(vBibTekst(FlProdukt, "#v114 #")) + Val(vBibTekst(FlProdukt, "#v119 #")) - Val(vBibTekst(FlProdukt, "#v120 #"))
'    MinimumStock = Val(vBibTekst(FlProdukt, "#v115 #"))
'    If MinimumStock > HuidigeStock Then
'        Me.lbMinStockInfo.Visible = True
'    Else
'        Me.lbMinStockInfo.Visible = False
'    End If
'    LocalInfo.SimpleText = "Min.Stock: " + Format(MinimumStock) + " / Stock: " + Format(HuidigeStock) + " / Plaats: " + vBibTekst(FlProdukt, "#v109 #")


'    'TaksKeuze(0).ListIndex = Val(vBibTekst(FlProdukt, "#v168 #"))
'    'Select Case Val(vBibTekst(FlProdukt, "#v168 #"))
'    '    Case 1 To 9
'    '        TaksKeuze(0).Visible = True
'    '    Case Else
'    '        TaksKeuze(0).Visible = False
'    'End Select
'    MaakTotaal()
'    'Ok.Enabled = True

'End Function


'Private Sub TekstInfo_DblClick(Index As Integer)

'    TekstInfo_KeyDown Index, 17, 0

'End Sub

'Private Sub TekstInfo_GotFocus(Index As Integer)

'    TekstInfo(Index).SelStart = 0
'    TekstInfo(Index).SelLength = Len(TekstInfo(Index).Text)
'    Select Case Index
'        Case 0, 3
'            SnelHelpPrint "Dubbelklikken of [Ctrl] voor ge ndexeerd zoeken", blLogging
'        If TekstInfo(3).Text <> "" Then
'                bGet FlRekening, 0, vSet((TekstInfo(3).Text), 7)
'            If KTRL Then
'                Else
'                    RecordToVeld FlRekening
'                SnelHelpPrint vBibTekst(FlRekening, "#v020 #"), blLogging
'            End If
'            End If
'        Case 4
'            Ok.Default = True

'        Case 6
'            If Val(TekstInfo(Index).Text) = 0 Then
'                TekstInfo(Index).Text = Dec$(1, "###.000")
'            End If
'    End Select

'    Select Case Index
'        Case 1
'            TekstInfo(1).SelLength = 0
'        Case Else
'            TekstInfo(Index).SelLength = Len(TekstInfo(Index).Text)
'    End Select

'End Sub

'Private Sub TekstInfo_KeyDown(Index As Integer, KeyCode As Integer, Shift As Integer)

'    If Index = 0 Then Ok.Enabled = False
'    Select Case KeyCode
'        Case 13
'            On Error Resume Next
'            If Index = 4 Then Ok.Enabled = True : Ok.SetFocus : Exit Sub
'            If Index = 0 Then
'                SendKeys "{TAB}", True
'            Exit Sub
'            End If
'        Case 17
'            Select Case Index
'                Case 0
'                    Ok.Enabled = False
'                    SharedFl = FlProdukt
'                    aIndex = Val(Left(cmbSortering, 2))
'                    FVT(FlProdukt, 0) = String$(13, 0)
'                    GRIDTEXT = TekstInfo(0).Text
'                    SqlSearch.Show 1
'                If KTRL Then
'                        TekstInfo(0).Text = ""
'                        TekstInfo(0).SetFocus : Exit Sub
'                    Else
'                        RecordToVeld FlProdukt
'                    ProdukTekstInfo()
'                        bGet FlRekening, 0, vSet(vBibTekst(FlProdukt, "#v117 #"), 7)
'                    If KTRL Then
'                            TekstInfo(3).Text = ""
'                            TekstInfo(0).SetFocus : Exit Sub
'                        ElseIf Val(vBibTekst(FlProdukt, "#e113 #")) <= 0 Then
'                            MsgBox "Aankoopprijs is onbekend.  Geef de inkoopprijs in van dit artikel a.u.b. via de produktfiche !"
'                        TekstInfo(0).Text = ""
'                            TekstInfo(0).SetFocus : Exit Sub
'                        Else
'                            RecordToVeld FlRekening
'                        TekstInfo(3).Text = vBibTekst(FlRekening, "#v019 #")
'                            SnelHelpPrint vBibTekst(FlRekening, "#v020 #"), blLogging
'                        Ok.Enabled = True
'                        End If
'                    End If
'                Case 3
'                    SharedFl = FlRekening
'                    aIndex = 0
'                    FVT(FlRekening, 0) = String$(7, 0)
'                    GRIDTEXT = TekstInfo(3).Text
'                    SqlSearch.Show 1
'                If KTRL Then
'                        TekstInfo(1).Text = ""
'                        FVT(FlRekening, 0) = ""
'                        Ok.Enabled = False
'                    Else
'                        RecordToVeld FlRekening
'                    TekstInfo(3).Text = vBibTekst(FlRekening, "#v019 #")
'                        Ok.Enabled = True
'                    End If
'            End Select
'    End Select

'End Sub

'Private Sub TekstInfo_KeyPress(Index As Integer, KeyAscii As Integer)

'    Select Case Index
'        Case 4
'            TekstInfo(9).Text = ""
'    End Select

'End Sub

'Private Sub TekstInfo_LostFocus(Index As Integer)
'    Dim TempPCT As Single

'    On Local Error Resume Next

'    Select Case Index
'        Case 0
'            Ok.Enabled = True
'            If Trim$(TekstInfo(0)) = "" Then
'            Else
'                bGet FlProdukt, 0, Trim$(TekstInfo(0).Text)
'            If KTRL Then
'                    TekstInfo(0).Text = ""
'                    TekstInfo(0).SetFocus : Exit Sub
'                Else
'                    RecordToVeld FlProdukt
'                ProdukTekstInfo()
'                    bGet FlRekening, 0, vSet(vBibTekst(FlProdukt, "#v117 #"), 7)
'                If KTRL Then
'                        MsgBox "Verkooprekening " & vSet(vBibTekst(FlProdukt, "#v117 #"), 7) & " bestaat niet (meer).  Eerst verbeteren a.u.b. in productfiche", vbExclamation
'                    TekstInfo(0).SetFocus : Exit Sub
'                    Else
'                        RecordToVeld FlRekening
'                    TekstInfo(3).Text = vBibTekst(FlRekening, "#v019 #")
'                        SnelHelpPrint vBibTekst(FlRekening, "#v020 #"), blLogging
'                    Ok.Enabled = True
'                    End If
'                    TekstInfo(6).SetFocus
'                End If
'            End If

'        Case 2
'            nVol = Val(TekstInfo(2).Text)
'            TekstInfo(2).Text = Dec$((nVol), "###0.0")
'            If InStr(DirecteVerkoopString, "EUR") Then
'                TekstInfo(4).Text = Dec$(Val(vBibTekst(FlProdukt, "#e112 #")) * nVol, "######0.000")
'            Else
'                TekstInfo(4).Text = Dec$(Val(vBibTekst(FlProdukt, "#v112 #")) * nVol, "######0.000")
'            End If
'            TekstInfo(9).Text = TekstInfo(4).Text

'        Case 3
'            bGet FlRekening, 0, vSet((TekstInfo(3).Text), 7)
'        If KTRL Then
'                If FVT(FlRekening, 0) = String$(7, 0) Then
'                    Exit Sub
'                Else
'                    TekstInfo(3).Text = OpbrengstDefault
'                    TekstInfo(3).SetFocus
'                End If
'            Else
'                RecordToVeld FlRekening
'            TekstInfo(3).Text = vBibTekst(FlRekening, "#v019 #")
'                SnelHelpPrint vBibTekst(FlRekening, "#v020 #"), blLogging
'        End If

'        Case 4
'            If TekstInfo(4).Text = TekstInfo(9).Text Then
'            ElseIf BTWType.Value Then
'                dHg = Val(TekstInfo(4).Text)
'                TempPCT = Val(Mid(Keuze(1).Text, 4, 4))
'                dHg = dHg * 100 / (100 + TempPCT)
'                TekstInfo(4).Text = Dec$((dHg), "######0.000")
'                MaakTotaal()
'                Ok.Enabled = True
'            Else
'                TekstInfo(4).Text = Dec$(Val(TekstInfo(4).Text), "######0.000")
'                MaakTotaal()
'                Ok.Enabled = True
'            End If

'        Case 5
'            If TekstInfo(0).Visible = True Then
'                If (Val(TekstInfo(4).Text) / Val(TekstInfo(2).Text)) / (1 + (Val(TekstInfo(5).Text) / 100)) < Val(vBibTekst(FlProdukt, "#e113 #")) Then
'                    MSG = "Uw verkoopprijs wordt kleiner dan uw aankoopprijs !  Is dit de bedoeling ?"
'                    KtrlBox = MsgBox(MSG, 292)
'                    If KtrlBox = 6 Then
'                    Else
'                        TekstInfo(5).Text = "0"
'                    End If
'                End If
'            End If
'            TekstInfo(5).Text = Dec$(Val(TekstInfo(5).Text), "##0")

'        Case 6
'            If TekstInfo(6).Text = "*" Then
'                If Keuze(0).Visible = True Then
'                    If Mid(WijzigenVerkoop.Keuze(0), 1, 1) = "5" Or Mid(WijzigenVerkoop.Keuze(0), 1, 1) = "3" Then
'                        frmVanGucht.Show 1
'                Else
'                        TekstInfo(6).Text = Dec$(1, vkMaskAantal)
'                    End If
'                Else
'                    TekstInfo(6).Text = Dec$(1, vkMaskAantal)
'                End If
'            End If
'            nAnt = Val(TekstInfo(6).Text)
'            TekstInfo(6).Text = Dec$((nAnt), vkMaskAantal)
'            'If Ok.Enabled = True Then Ok.SetFocus
'    End Select
'    MaakTotaal()

'End Sub

