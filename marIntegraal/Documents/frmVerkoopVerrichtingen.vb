Option Strict Off
Option Explicit On
Public Class frmVerkoopVerrichtingen
    Dim dokumentType As String = "  "
    Dim pdfDOKUMENTTYPE As String
    Dim dokumentHistoriek As String = "           "
    Dim VerkoopDetailTitel(8) As String
    Dim dokumentSleutel As String = "           "
    Dim KlantRekening As String = "       "
    Dim VerkoopFLG As Short
    Dim AfdrukFlag As Short
    Dim AantalEx As String = "  "
    Dim DefaultVerkoop As String = "       "
    Dim KontaktPersoon As Short
    Dim rbtwVAK(10) As String
    Dim Vr As Short
    Dim sMuntKlant As String = "   "
    Dim BTWEuroBasis(3) As Decimal
    Dim BTWEuroBedrag(3) As Decimal
    Dim BTWBasis(3) As Decimal
    Dim BTWBedrag(3) As Decimal
    Dim TotaalBTW As Decimal
    Dim TotaalUitvoer As Decimal
    Dim dMuntK As Double
    Dim sMunt As String = "   "
    Dim VsoftVanaf As String
    Dim VsoftTot As String
    Dim BeginXbox As Short
    Dim BeginYbox As Short
    Dim OVSStrooklijnen As Integer
    Dim ForFait As Short
    Dim SteedsDrukken As Boolean
    Dim vkMaskAantal As String
    Dim rsDetail As New ADODB.Recordset
    Dim rsKlant As New ADODB.Recordset
    Dim pdfX As Double
    Dim pdfY As Double
    Dim pdfOVSStrook As Double



    Dim tabV As Short
    Dim hTAB As Short
    Dim rSip(6) As String
    Dim sSip(6) As String
    Dim VeldInfo(9) As String
    Dim rBTWstr As String
    Dim A As String

    Dim dVeldInfo(7) As Double
    Dim TotaalBedrag As Double
    Dim BtwTekst As String = "    "

    Dim OMSTab As Short
    Dim tPagina As Short
    Dim Pagina As Short
    Dim tSip As Short
    Dim iRNTxt As Short
    Dim Teltxt As Short
    Dim strMeerLijn As String

    Dim BedragTxt As String
    Dim rNTTxt As String
    Dim rNTTxt2 As String
    Dim ReferteTxt As String

    Dim T As Short
    Dim TT As Short
    Dim Taal As String
    Dim FlTemp As Short
    Dim rft(10) As String
    Dim rnr As String = "             "
    Dim sy As String
    Dim sy2 As String

    Dim XVan As Single
    Dim XTot As Single
    Dim YVan As Single
    Dim YTot As Single
    Dim X As Short
    Dim MeerLijn As Short

    Dim Nog As Short
    Dim NogString As String

    Dim ktrlHier As Double
    Dim adresString As String
    Dim ovsDefinitie As String
    Dim aantalPaginas As Short

    Private Sub frmVerkoopVerrichtingen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = 0
        Left = 0

        'uitsluitend Euro vanaf 2011
        cmdSwitch.Text = "Ingave in EUR"
        If bhEuro Then
            cmdSwitch.Text = "Ingave in EUR"
        Else
            bhEuro = True
        End If
        Dim Tel As Short


        dMuntK = 1
        sMunt = "BEF"

        For Tel = 16 To 19
            rbtwVAK(Tel - 16) = String99(Reading, Tel)
            rbtwVAK(Tel - 12) = String99(Reading, Tel + 6)
        Next

MaskAantal:
        vkMaskAantal = String99(Reading, 300)
        If Len(Trim(vkMaskAantal)) <> 7 Then
            SS99("0000.00", 300)
            MsgBox("Masker voor aantal is ingesteld als '0000.00'  Wijzig via setup indien nodig.", MsgBoxStyle.Information)
            GoTo MaskAantal
        End If
        Mid(vkMaskAantal, 1, InStr(vkMaskAantal, ".") - 2) = New String("#", InStr(vkMaskAantal, ".") - 2)

        'AantalEx.Value = String99(Reading, 185)

        KontaktPersoon = Val(String99(Reading, 201))
        If Val(String99(Reading, 202)) = 1 Then
            Overschrijvingsstrook.Checked = True
        Else
            Overschrijvingsstrook.Checked = False
        End If
        If Val(String99(Reading, 203)) = 1 Then
            SteedsDrukken = True
        Else
            SteedsDrukken = False
        End If
        Vr = 11
        Dim X As Short
        Schoon()

        If Mid(String99(Reading, 20), 1, 1) = "4" Then
            ForFait = 1
            MsgBox("Verkoopfakturatie voor forfaitair BTW SYSTEEM.")
            'TODO: TekstInfo(3).Visible = True
        Else
            ForFait = 0
        End If
        KlantRekening = String99(Reading, 9)
        mgrklantenrekMTextBox.Text = KlantRekening
        'If String99(Reading, 299) = "2" Then
        'Me.cbPDF.CheckState = System.Windows.Forms.CheckState.Unchecked
        'Else
        cbPDF.Checked = True
        'End If

        Dim TempoKLS As String
        Dim TempoDOK As String

        If InStr(GridText9, vbTab) <> 0 Then
            TempoKLS = Mid(GridText9, 1, InStr(GridText9, vbTab) - 1)
            GridText9 = Mid(GridText9, InStr(GridText9, vbTab) + 1)
            XLogKey = TempoKLS
            InstalKlant()
            Select Case Mid(GridText9, 1, 2)
                Case "13", "14", "15"
                    dokumentType = Mid(GridText9, 1, 2)
                    TempoDOK = Mid(GridText9, InStr(GridText9, vbTab) + 1)
                    If Len(TempoDOK) <> 8 Then
                        'VerkoopOptie_CheckedChanged(VerkoopOptie.Item(0), New System.EventArgs())
                        VerkoopKTRL

                    Else
                        XLogKey = TempoDOK
                        Stop
                        'TODO: LaadHetdokument()
                    End If
            End Select
        End If
        On Error Resume Next
        'verkoopKTRL()
        DirekteVerkoop.Checked = True
        Activate()

    End Sub
    Private Sub KlantAktiveren_Click(sender As Object, e As EventArgs) Handles KlantAktiveren.Click
        If VerkoopDetail.Items.Count Then
            Msg = "Huidige inbreng en klant negeren." & vbCrLf & vbCrLf
            Msg = Msg & "Bent U zeker."
            KtrlBox = MsgBox(Msg, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Andere klant kiezen")
            If KtrlBox = MsgBoxResult.Yes Then
            Else
                Exit Sub
            End If
        End If
        SharedIndex = 1
        SharedFl = TableOfCustomers
        GridText = ""
        SqlSearch.ShowDialog()
        If Ktrl = 0 Then
            InstalKlant()
        Else
            Schoon()
        End If
        SqlSearch.Dispose()
    End Sub
    Private Sub InstalKlant()
        Dim Klantje As String
        Dim T As Short

        rsKlant = New ADODB.Recordset
        On Error Resume Next
        Err.Clear()
        rsKlant.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Msg = "SELECT TOP 1 * FROM Klanten WHERE A110 = '" & XLogKey & "'"
        rsKlant.Open(Msg, adntDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        If Err.Number Or rsKlant.RecordCount <> 1 Then
            MsgBox("Onverwachte situatie")
            Exit Sub
        End If

        VerkoopDetail.Enabled = True
        Klantje = vbCrLf & RV(rsKlant, "A100") & vbCrLf & RV(rsKlant, "A125") & vbCrLf & RV(rsKlant, "A104") & vbCrLf & RV(rsKlant, "A109") & " " & RV(rsKlant, "A107") & " " & RV(rsKlant, "A108")
        Schoonvegen.Enabled = True
        Sjabloon.Enabled = True
        DagKoers.Text = "Dagkoers " & RV(rsKlant, "vs03")
        sMuntKlant = RV(rsKlant, "vs03")
        rsDetail = New ADODB.Recordset
        On Error Resume Next
        Err.Clear()
        rsDetail.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Msg = "SELECT TOP 1 * FROM Allerlei WHERE v005 = '10" & sMuntKlant & "'"
        rsDetail.Open(Msg, adntDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        'cmdSwitch.Enabled = True
        If rsDetail.RecordCount <> 1 Then
            MsgBox("Muntkode eerst inbrengen via diverse gebruikersfiches a.u.b.  Nu wordt automatisch verdergewerkt met BEF", MsgBoxStyle.Information, "Muntkode is " & sMunt)
            If bhEuro Then
                DagKoers.Text = "Munt in EUR"
                sMuntKlant = "EUR"
                dMuntK = 1
            Else
                DagKoers.Text = "Munt in BEF"
                sMuntKlant = "BEF"
                dMuntK = 1
            End If
        Else


            muntMTextBox.Text = Dec(Val(adoBibTekst(rsDetail.Fields("Memo"), "#v040 #")), "###.########")
            dMuntK = Val(adoBibTekst(rsDetail.Fields("Memo"), "#v040 #"))
        End If

        If bhEuro Then
            If sMuntKlant = "BEF" Then
                cmdSwitch.Text = "Ingave in BEF"
                'cmdSwitch.Enabled = True
                dMuntK = 1
                'TekstInfo(5).Text = Dec$(1 / Euro, "##0.########")
            ElseIf sMuntKlant = "EUR" Then
                cmdSwitch.Text = "Ingave in EUR"
                'cmdSwitch.Enabled = True
                dMuntK = 1
            Else
                cmdSwitch.Text = "Ingave in EUR"
                'cmdSwitch.Enabled = False
            End If
        Else
            If sMuntKlant = "EUR" Then
                cmdSwitch.Text = "Ingave in EUR"
                'cmdSwitch.Enabled = True
                dMuntK = 1
            ElseIf sMuntKlant = "BEF" Then
                cmdSwitch.Text = "Ingave in BEF"
                'cmdSwitch.Enabled = True
                dMuntK = 1
            Else
                cmdSwitch.Text = "Ingave in BEF"
                'cmdSwitch.Enabled = False
            End If
        End If
        If sMuntKlant = "BEF" Or sMuntKlant = "EUR" Then
            muntMTextBox.Text = Dec(dMuntK, "##0.########")
        Else
            Stop
            dMuntK = Val(muntMTextBox.Text)
        End If
        DirecteVerkoopString = cmdSwitch.Text
        rsDetail.Close()
        rsDetail = Nothing
        If RV(rsKlant, "v149") = "" Then
            MsgBox("Landnummer is verplicht !")
            Exit Sub
        ElseIf RV(rsKlant, "v149") = "002" Then
            KlantInfo.Text = SetSpacing(RV(rsKlant, "A110"), 12) & "* Binnenland * " & Klantje
            VerkoopFLG = 0
            Medekontraktant.Enabled = True
        ElseIf InStr(SISO, RV(rsKlant, "v149")) Then
            KlantInfo.Text = SetSpacing(RV(rsKlant, "A110"), 12) & "* E.U. mét Btw-nummer * " & Klantje
            VerkoopFLG = 1
            Medekontraktant.Enabled = False
            If SetSpacing(RV(rsKlant, "A161"), 12) = Space(12) Then
                KlantInfo.Text = SetSpacing(RV(rsKlant, "A110"), 12) & "* E.U. geen Btw-nummer * " & Klantje
                VerkoopFLG = 0
            End If
        Else
            KlantInfo.Text = SetSpacing(RV(rsKlant, "A110"), 12) & "* Uitvoer buiten E.U. *" & Klantje
            VerkoopFLG = 2
            Medekontraktant.Enabled = False
        End If

        datumdocMTextbox.Enabled = True
        vervaldagMTextBox.Enabled = True
        mgrklantenrekMTextBox.Enabled = True


        If RV(rsKlant, "v151") = "1" Then
            Medekontraktant.CheckState = System.Windows.Forms.CheckState.Checked
        End If

        If Mid(RV(rsKlant, "v161"), 1, 3) = "400" Then
            Stop
            KlantRekening = RV(rsKlant, "v161")
            If Not adoGet(TableOfLedgerAccounts, 0, "=", KlantRekening) Then
                Beep()
                KlantRekening = String99(Reading, 9)
            End If
        Else
            KlantRekening = String99(Reading, 9)
        End If
        mgrklantenrekMTextBox.Text = KlantRekening
        If Mid(RV(rsKlant, "v225"), 1, 2) = "70" Then
            DefaultVerkoop = RV(rsKlant, "v225")
            If Not adoGet(TableOfLedgerAccounts, 0, "=", DefaultVerkoop) Then
                Beep()
                DefaultVerkoop = String99(Reading, 25)
            End If
        Else
            DefaultVerkoop = String99(Reading, 25)
        End If
        vervaldagMTextBox.Text = VValdag(datumdocMTextbox.Text, RV(rsKlant, "vs04"))
        IsErKlassement()
        If RV(rsKlant, "v253") <> "" Then
            cmdSQLInfo.Visible = True
        End If
    End Sub
    Private Function Schoon() As Short

        Dim T As Short

        TLBRecord(TableOfVarious) = ""
        dokumentHistoriek = ""
        VerkoopDetail.Enabled = False
        Afsluiten.Enabled = False
        CmbAfdruk.Enabled = False
        cmdSwitch.Enabled = False
        Medekontraktant.Enabled = True
        Sjabloon.Enabled = False
        Klassement.Enabled = False
        'Klassement.Font = VB6.FontChangeBold(Klassement.Font, False)
        chkBTWBouw.CheckState = System.Windows.Forms.CheckState.Unchecked
        VatBobTheBuilders = False
        KlantInfo.Text = ""
        Annuleren.Enabled = True
        Medekontraktant.CheckState = System.Windows.Forms.CheckState.Unchecked

        If DirekteVerkoop.Enabled Then
            CreditNota.Checked = False
        End If

        Err.Clear()
        On Error Resume Next

        datumdocMTextbox.Text = MimGlobalDate
        If Err.Number Then MsgBox("Landinstellingen voor België voorzien a.u.b.  Het programma wordt hierna beëindigd.", MsgBoxStyle.Critical) : End
        vervaldagMTextBox.Text = MimGlobalDate
        mgrklantenrekMTextBox.Text = KlantRekening
        LblExBtw.Text = ""
        LblInBtw.Text = ""
        LblEx2Btw.Text = ""
        LblIn2Btw.Text = ""
        If lstKopiePlak.Items.Count Then
            Msg = "Gekopiëerde lijnen behouden ?"
            Ktrl = MsgBox(Msg, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1)
            Select Case Ktrl
                Case MsgBoxResult.No
                    lstKopiePlak.Items.Clear()
            End Select
        End If
        frmDokHistoriek.lstDokHistoriek.Items.Clear()
        frmDokHistoriek.Hide()

        RasterSchoon()
        'VerkoopOptie(0).Value = 1
        'Select Case Vr
        'Case 11
        'DirekteVerkoop.Checked = True
        'VerkoopOptie_CheckedChanged(VerkoopOptie.Item(0), New System.EventArgs())
        'Case 13
        'CreditNota.Checked = True
        'CreditNota_CheckStateChanged(CreditNota, New System.EventArgs())
        'Case 73
        'Bestelbon.Checked = True
        'VerkoopOptie_CheckedChanged(VerkoopOptie.Item(1), New System.EventArgs())
        'Case 59
        'Offerte.Checked = True
        'VerkoopOptie_CheckedChanged(VerkoopOptie.Item(2), New System.EventArgs())
        'Case Else
        'MsgBox("Stop")
        'End Select
        cmdSQLInfo.Visible = False

        On Error Resume Next
        Activate()

    End Function
    Private Sub IsErKlassement()

        If KlantInfo.Text = "" Then Exit Sub
        On Error Resume Next
        rsDetail = New ADODB.Recordset
        Err.Clear()
        rsDetail.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Msg = "SELECT TOP 1 * FROM Allerlei WHERE v004 = 'K" + RV(rsKlant, "A110") + "' AND v005 Like '" + dokumentType + "%'"
        rsDetail.Open(Msg, adntDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        If Err.Number Or rsDetail.RecordCount = 0 Then
            Klassement.Enabled = False
            'Klassement.Font = VB6.FontChangeBold(Klassement.Font, False)
        Else
            Klassement.Enabled = True
            'Klassement.Font = VB6.FontChangeBold(Klassement.Font, True)
        End If
        rsDetail.Close()
        'UPGRADE_NOTE: Object rsDetail may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsDetail = Nothing

    End Sub
    Private Sub RasterSchoon()
        Dim T As Short

        VerkoopDetail.Items.Clear()
        GridText = ""
        For T = 0 To 3
            BTWBasis(T) = 0
            BTWBedrag(T) = 0

            BTWEuroBasis(T) = 0
            BTWEuroBedrag(T) = 0
        Next
        TotaalBTW = 0
        TotaalUitvoer = 0
        MaakTotaal()

    End Sub
    Sub verkoopKTRL()

        'If dokumentHistoriek <> Space(11) Then
        'MsgBox("Opgelet, data van o.a. " & dokumentHistoriek & " is nog aktief.  Vermijd dubbele bewerkingen.", 64)
        'End If

        If VerkoopDetail.Items.Count Then
            If Annuleren.Enabled = False Then
                MsgBox("U gaat naar een hogere modus met ingeladen dokument(en)." & vbCrLf & vbCrLf & "Indien dit niet de bedoeling was, onmiddellijk verkoopvenster sluiten en herbeginnen a.u.b.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
                dokumentHistoriek = dokumentSleutel
                TLBRecord(TableOfVarious) = ""
                Annuleren.Enabled = True
            End If
        End If

        MsgBox("TODO: Stop voor Creditnota enabled bij verkoopKTRL")
        'If Index > 0 Then
        'CreditNota.Enabled = False
        'Else
        'CreditNota.Enabled = True
        'End If

        If DirekteVerkoop.Checked Then
            dokumentType = "15" 'Faktuur of creditnota
            CreditNota.Checked = False
            Vr = 11
            dokumentSleutel = SleutelDok(Vr)
            datumdocMTextbox.Text = MimGlobalDate
            vervaldagMTextBox.Text = MimGlobalDate
            Text = SetSpacing("Ctrl+F2 Verkoopverrichting", 28) & "(" & dokumentSleutel & ")"
            chkZonderRelatie.Visible = False
        ElseIf Bestelbon.Checked Then
            dokumentType = "14" 'Bestelbon, Leveringsbon
            Vr = 73
            dokumentSleutel = SleutelDok(Vr)
            Text = SetSpacing("Ctrl+F2 Bestelling/levering", 28) & "(" & dokumentSleutel & ")"
            chkZonderRelatie.Visible = True
        ElseIf Offerte.Checked Then
            dokumentType = "13" 'Offerte
            Vr = 59
            dokumentSleutel = SleutelDok(Vr)
            Text = SetSpacing("Ctrl+F2 Offerte", 28) & "(" & dokumentSleutel & ")"
            chkZonderRelatie.Visible = True
        End If
        TekstInfo3.Text = dokumentSleutel

        'If Ktrl = 99 Then
        'Msg = VerkoopOptie(Index).Text & " aktief bij andere gebruiker." & vbCrLf & vbCrLf
        'Msg = Msg & "Verkoopverrichting afsluiten of andere optie selecteren a.u.b. !"
        'Ktrl = MsgBox(Msg, 16)
        'If Index = 0 Then VerkoopOptie(1).Checked = 1
        'If Index = 1 Then VerkoopOptie(0).Checked = 1
        'If Index = 2 Then VerkoopOptie(1).Checked = 1
        'VerkoopOptie(Index).Enabled = False
        'Exit Sub
        'End If
        IsErKlassement()

        'End If
    End Sub
    Private Sub CreditNota_CheckedChanged(sender As Object, e As EventArgs) Handles CreditNota.CheckedChanged
        If CreditNota.Checked = True Then
            DirekteVerkoop.Checked = True
            DirekteVerkoop.Enabled = False
            Bestelbon.Enabled = False
            Offerte.Enabled = False
            CreditNota.Enabled = False
            verkoopKTRL()
        End If
    End Sub
    Private Sub DirekteVerkoop_CheckedChanged(sender As Object, e As EventArgs) Handles DirekteVerkoop.CheckedChanged
        If DirekteVerkoop.Checked = True Then
            verkoopKTRL()
        End If
    End Sub
    Private Sub Bestelbon_CheckedChanged(sender As Object, e As EventArgs) Handles Bestelbon.CheckedChanged
        If Bestelbon.Checked = True Then
            verkoopKTRL()
        End If
    End Sub
    Private Sub Offerte_CheckedChanged(sender As Object, e As EventArgs) Handles Offerte.CheckedChanged
        If Offerte.Checked = True Then
            verkoopKTRL()
        End If
    End Sub
    Private Sub Klassement_Click(sender As Object, e As EventArgs) Handles Klassement.Click
        Dim T As Short
        Dim LaatsteWAS As String
        Dim TotaalEX As Decimal
        Dim dataVeld As String
        If KlantInfo.Text = "" Then Exit Sub
        T = 0
        Dim xlogHier As New xLog
        xlogHier.Hide()
        xlogHier.Text = "Document inladen voor : " + RV(rsKlant, "A100")
        xlogHier.X.Columns.Add("Document", 100)
        xlogHier.X.Columns.Add("Datum", 100)
        xlogHier.X.Columns.Add("Bedrag EUR", 100)
        xlogHier.X.Columns.Add("Bedrag BEF", 100)
        xlogHier.X.Columns.Add("Zie ook document", 100)
        xlogHier.WijzigenLijn.Visible = False
        xlogHier.Afsluiten.Visible = False
        xlogHier.selectonlyButton.Visible = True
        xlogHier.AcceptButton = xlogHier.selectonlyButton
        XLogKey = ""
        rsDetail = New ADODB.Recordset
        On Error Resume Next
        Err.Clear()
        rsDetail.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Msg = "SELECT * FROM Allerlei WHERE v004 = 'K" + RV(rsKlant, "A110") + "' AND v005 Like '" + dokumentType + "%' ORDER BY v004, v005 DESC"
        Cursor.Current = Cursors.WaitCursor
        rsDetail.Open(Msg, adntDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        If Err.Number Then
            MsgBox("Bron:" & vbCrLf & Err.Source & vbCrLf & vbCrLf & "Foutnummer: " & Err.Number & vbCrLf & vbCrLf & "Detail:" & vbCrLf & Err.Description)
            Exit Sub
        ElseIf rsDetail.RecordCount = 0 Then
            MsgBox("Geen dokumenten (meer) te vinden.", MsgBoxStyle.Information)
            Exit Sub
        Else
            LaatsteWAS = ""
            'rsDetail.MoveFirst()
            Do While Not rsDetail.EOF
                'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
                If LaatsteWAS = adoBibTekst(rsDetail.Fields("Memo"), "#v033 #") Then
                Else
                    LaatsteWAS = adoBibTekst(rsDetail.Fields("Memo"), "#v033 #")
                    dataveld = adoBibTekst(rsDetail.Fields("Memo"), "#v033 #")
                    Dim itemHier As New ListViewItem(dataVeld)
                    dataVeld = FunctionDateText(adoBibTekst(rsDetail.Fields("Memo"), "#v035 #"))
                    itemHier.SubItems.Add(dataVeld)
                    If adoBibTekst(rsDetail.Fields("Memo"), "#vEUR #") = "EUR" Then
                        dataVeld = Format(CDbl(adoBibTekst(rsDetail.Fields("Memo"), "#v137 #")), "#,##0.00")
                        itemHier.SubItems.Add(dataVeld)
                        dataVeld = Format(CDbl(adoBibTekst(rsDetail.Fields("Memo"), "#v137 #")) * Euro, "#,##0.00")
                        itemHier.SubItems.Add(dataVeld)
                    Else
                        dataVeld = Format(CDbl(adoBibTekst(rsDetail.Fields("Memo"), "#v137 #")) / Euro, "#,##0.00")
                        itemHier.SubItems.Add(dataVeld)
                        dataVeld = Format(CDbl(adoBibTekst(rsDetail.Fields("Memo"), "#v137 #")), "#,##0.00")
                        itemHier.SubItems.Add(dataVeld)
                    End If
                    dataVeld = adoBibTekst(rsDetail.Fields("Memo"), "#v147 #") & " " & adoBibTekst(rsDetail.Fields("Memo"), "#v148 #")
                    itemHier.SubItems.Add(dataVeld)
                    xlogHier.X.Items.Add(itemHier)
                End If
                rsDetail.MoveNext()
            Loop
        End If
        rsDetail.Close()
        rsDetail = Nothing
        'xLog.SSTab1.TabPages.Item(1).Visible = False
        xlogHier.ShowDialog()
        xlogHier.Close()
        If XLogKey <> "" Then
            LaadHetdokument()
        End If
        Exit Sub
    End Sub
    Sub LaadHetdokument()
        Dim aa As String
        Dim T As Short
        If dokumentType = "15" Then
            RasterSchoon()
        End If
        rsDetail = New ADODB.Recordset
        On Error Resume Next
        Err.Clear()
        rsDetail.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Msg = "SELECT * FROM Allerlei WHERE v005 Like '" & dokumentType & Mid(XLogKey, 1, 11) & "%'"
        Cursor.Current = Cursors.WaitCursor
        rsDetail.Open(Msg, adntDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        If Err.Number Then
            MsgBox("Bron:" & vbCrLf & Err.Source & vbCrLf & vbCrLf & "Foutnummer: " & Err.Number & vbCrLf & vbCrLf & "Detail:" & vbCrLf & Err.Description)
            Cursor.Current = Cursors.Default
            Exit Sub
        ElseIf rsDetail.RecordCount = 0 Then
            MsgBox("Geen dokumenten (meer) te vinden.", MsgBoxStyle.Information)
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If
        If InStr(adoBibTekst(rsDetail.Fields("Memo"), "#v147 #"), "V") Then
            Msg = "Document: " & Mid(XLogKey, 1, 11)
            Msg = Msg & " reeds in relatie tot " & vbCrLf
            Msg = Msg & "verkoopdocument(en): " & adoBibTekst(rsDetail.Fields("Memo"), "#v147 #") & vbCrLf & vbCrLf
            Msg = Msg & "Toch ophalen ?"
            KtrlBox = MsgBox(Msg, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Opletten !")
            If KtrlBox = MsgBoxResult.No Then
                Cursor.Current = Cursors.Default
                Exit Sub
            End If
        End If
        dokumentSleutel = adoBibTekst(rsDetail.Fields("Memo"), "#v033 #")
        If Mid(dokumentSleutel, 2, 1) = "1" Then
            CreditNota.CheckState = System.Windows.Forms.CheckState.Checked
        End If
        Dim docInEur As String
        TekstInfo3.Text = dokumentSleutel
        Medekontraktant.CheckState = Val(adoBibTekst(rsDetail.Fields("Memo"), "#v135 #"))
        datumdocMTextbox.Text = FunctionDateText(adoBibTekst(rsDetail.Fields("Memo"), "#v035 #"))
        vervaldagMTextBox.Text = FunctionDateText(adoBibTekst(rsDetail.Fields("Memo"), "#v036 #"))
        mgrklantenrekMTextBox.Text = adoBibTekst(rsDetail.Fields("Memo"), "#v136 #")
        Text = Mid(Text, 1, 28) & "(" & dokumentSleutel & ")"
        docInEur = adoBibTekst(rsDetail.Fields("Memo"), "#vEUR #")
        Do While Not rsDetail.EOF
            For T = 0 To 7
                aa = adoBibTekst(rsDetail.Fields("Memo"), "#v" & Format(139 + T, "000") & " #")
                If aa <> "" Then
                    VerkoopDetail.Items.Add(aa)
                End If
            Next
            rsDetail.MoveNext()
        Loop
        rsDetail.Close()
        rsDetail = Nothing
        Annuleren.Enabled = False
        Afsluiten.Enabled = True
        CmbAfdruk.Enabled = True
        On Error Resume Next
        If docInEur = "EUR" Then
            cmdSwitch.Text = "Ingave in EUR"
        Else
            cmdSwitch.Text = "Ingave in BEF"
        End If
        Afsluiten.Focus()
        Select Case dokumentType
            Case "15"
                DirekteVerkoop.Enabled = False
                Bestelbon.Enabled = False
                Offerte.Enabled = False
                datumdocMTextbox.Enabled = False
                vervaldagMTextBox.Enabled = False
                mgrklantenrekMTextBox.Enabled = False
                Medekontraktant.Enabled = False
                CreditNota.Enabled = False
                VerkoopDetail.Enabled = False
                Afsluiten.Enabled = False
            Case "14"
                Bestelbon.Enabled = False
                frmDokHistoriek.lstDokHistoriek.Items.Add(dokumentSleutel)
                If frmDokHistoriek.Visible = False Then
                    frmDokHistoriek.Show()
                End If
                Activate()
            Case "13"
                frmDokHistoriek.lstDokHistoriek.Items.Add(dokumentSleutel)
                If frmDokHistoriek.Visible = False Then
                    frmDokHistoriek.Show()
                End If
                Activate()
        End Select
        RefreshBTW()
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub RefreshBTW()
        Dim aa As String
        Dim T As Short
        Dim bVak As Short
        Dim maskerMULTI As String
        maskerMULTI = MaskEURBH
        For T = 0 To 3
            BTWBasis(T) = 0
            BTWBedrag(T) = 0
            BTWEuroBasis(T) = 0
            BTWEuroBedrag(T) = 0
        Next
        TotaalBTW = 0
        TotaalUitvoer = 0
        For T = 0 To VerkoopDetail.Items.Count - 1
            VerkoopDetail.SelectedIndex = T
            aa = VerkoopDetail.Text '  VerkoopDetail ' GetItemString(VerkoopDetail, T)
            Select Case Mid(aa, Len(aa), 1)
                Case "0", "1"
                    bVak = Val(Mid(aa, 88, 1))
                    If bVak = 6 Then
                        If cmdSwitch.Text = "Ingave in EUR" Then
                            BTWBasis(0) = BTWBasis(0) + Val(Dec(Val(Mid(aa, 62, 12)) * Euro, MaskEURBH))
                            BTWEuroBasis(0) = BTWEuroBasis(0) + Val(Dec(Val(Mid(aa, 62, 12)), MaskEURBH))
                        Else
                            BTWBasis(0) = BTWBasis(0) + Val(Dec(Val(Mid(aa, 62, 12)), MaskEURBH))
                            BTWEuroBasis(0) = BTWEuroBasis(0) + Val(Dec(Val(Mid(aa, 62, 12)) / Euro, MaskEURBH))
                        End If
                    Else
                        If cmdSwitch.Text = "Ingave in EUR" Then
                            If BTWBasis(bVak) <> 0 Then
                                BTWBasis(bVak) = System.Math.Round(BTWBasis(bVak))
                                maskerMULTI = "############"
                            End If
                            BTWBasis(bVak) = BTWBasis(bVak) + Val(Dec(Val(Mid(aa, 62, 12)) * Euro, maskerMULTI))
                            BTWEuroBasis(bVak) = BTWEuroBasis(bVak) + Val(Dec(Val(Mid(aa, 62, 12)), MaskEURBH))
                        Else
                            If BTWBasis(bVak) <> 0 Then
                                maskerMULTI = "############"
                                BTWBasis(bVak) = Val(Dec(BTWBasis(bVak), maskerMULTI))
                            End If
                            BTWBasis(bVak) = BTWBasis(Val(Mid(aa, 88, 1))) + Val(Dec(Val(Mid(aa, 62, 12)), maskerMULTI))
                            BTWEuroBasis(bVak) = BTWEuroBasis(Val(Mid(aa, 88, 1))) + Val(Dec(Val(Mid(aa, 62, 12)) / Euro, MaskEURBH))
                        End If
                    End If
            End Select
        Next
        MaakTotaal()
    End Sub
    Private Sub MaakTotaal()
        Dim BTWIn As Double
        Dim BTWEx As Double
        Dim BtwEuroIn As Double
        Dim BtwEuroEx As Double
        Dim Teller As Short
        On Error Resume Next
        For Teller = 1 To 3
            BTWBedrag(Teller) = Val(Dec((BTWBasis(Teller)) * Val(Mid(fmarBoxText("002", "2", Format(Teller)), 4, 4)) / 100, MaskEURBH))
            BTWIn = BTWIn + BTWBasis(Teller) + BTWBedrag(Teller)
            BTWEx = BTWEx + BTWBasis(Teller)

            BTWEuroBedrag(Teller) = Val(Dec(BTWEuroBasis(Teller) * Val(Mid(fmarBoxText("002", "2", Format(Teller)), 4, 4)) / 100, MaskEURBH))
            BtwEuroIn = BtwEuroIn + BTWEuroBasis(Teller) + BTWEuroBedrag(Teller)
            BtwEuroEx = BtwEuroEx + BTWEuroBasis(Teller)
            If cmdSwitch.Text = "Ingave in BEF" Then
                Select Case Teller
                    Case 1
                        btwBedrag1.Text = Format(Math.Round(BTWBasis(Teller)), "#,##0.00")
                    Case 2
                        btwBedrag2.Text = Format(Math.Round(BTWBasis(Teller)), "#,##0.00")
                    Case 3
                        btwBedrag3.Text = Format(Math.Round(BTWBasis(Teller)), "#,##0.00")
                End Select
                'lblBTWBedrag(Teller).Text = Format(Math.Round(BTWBasis(Teller)), "#,##0.00")
            Else
                Select Case Teller
                    Case 1
                        btwBedrag1.Text = Format(BTWEuroBasis(Teller), "#,##0.00")
                    Case 2
                        btwBedrag2.Text = Format(BTWEuroBasis(Teller), "#,##0.00")
                    Case 3
                        btwBedrag3.Text = Format(BTWEuroBasis(Teller), "#,##0.00")
                End Select
                'lblBTWBedrag(Teller).Text = Format(BTWEuroBasis(Teller), "#,##0.00")
            End If
        Next
        BTWEx = BTWEx + BTWBasis(0)
        BTWIn = BTWIn + BTWBasis(0)
        BtwEuroEx = BtwEuroEx + BTWEuroBasis(0)
        BtwEuroIn = BtwEuroIn + BTWEuroBasis(0)
        LblExBtw.Text = Format(Math.Round(BTWEx, 2), "#,##0.00") 'in BEF
        LblInBtw.Text = Format(Math.Round(BTWIn), "#,##0.00") 'in BEF
        LblEx2Btw.Text = Format(BtwEuroEx, "#,##0.00") 'masker voor EURO
        LblIn2Btw.Text = Format(BtwEuroIn, "#,##0.00") 'masker voor EURO
    End Sub
    Private Sub Schoonvegen_Click(sender As Object, e As EventArgs) Handles Schoonvegen.Click
        Schoon()
    End Sub
    Private Sub cbLayOudPDF_Click(sender As Object, e As EventArgs) Handles cbLayOudPDF.Click
        LayOutpdfDokument.Show()
    End Sub
    Private Sub CmbAfdruk_Click(sender As Object, e As EventArgs) Handles CmbAfdruk.Click
        Dim A As String
        Dim refString As String
        Dim refID As String
        Dim aa As String = "                              "
        Dim dTTwb As Double
        Dim DummySleutel As String
        Dim BestondReeds As Short
        Dim T As Short
        If dokumentType = "15" And Annuleren.Enabled = True Then
            If Not DatumKtrl(datumdocMTextbox.Text, PeriodAsText) Then
                FormBYPERDAT.WindowState = FormWindowState.Normal
                FormBYPERDAT.Focus()
                datumdocMTextbox.Focus()
                Beep()
                Exit Sub
            End If
        End If
        If dokumentType = "15" Then
            If frmDokHistoriek.lstDokHistoriek.Items.Count <> 0 Then
                Msg = ""
                refID = "RF:"
                For T = 0 To frmDokHistoriek.lstDokHistoriek.Items.Count - 1
                    frmDokHistoriek.lstDokHistoriek.SelectedIndex = T
                    Msg = Msg & frmDokHistoriek.lstDokHistoriek.Text & " "
                Next
                KtrlBox = MsgBox("Bons als referte opnemen." & vbCr & vbCr & refID & Msg, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1)
                If KtrlBox = MsgBoxResult.Yes Then
                    refString = New String(" ", 75) & "|2"
                    VerkoopDetail.Items.Add(refString)
                    Do While Msg <> ""
                        refString = New String(" ", 75) & "|2"
                        Mid(refString, 1) = refID & Mid(Msg, 1, 72)
                        If Len(Msg) > 72 Then
                            Msg = Mid(Msg, 73)
                        Else
                            Msg = ""
                        End If
                        VerkoopDetail.Items.Add(refString)
                    Loop
                End If
            End If
        End If
        TotaalBTW = 0
        If Medekontraktant.CheckState Or VerkoopFLG Then
            BTWBedrag(1) = 0 : BTWEuroBedrag(1) = 0
            BTWBedrag(2) = 0 : BTWEuroBedrag(2) = 0
            BTWBedrag(3) = 0 : BTWEuroBedrag(3) = 0
        Else
            For T = 0 To 3
                If InStr(cmdSwitch.Text, "EUR") Then
                    TotaalBTW = TotaalBTW + BTWEuroBedrag(T)
                Else
                    TotaalBTW = TotaalBTW + BTWBedrag(T)
                End If
            Next
        End If
        If VerkoopFLG Then
            If sMuntKlant = "EUR" Then
                TotaalUitvoer = CDbl(LblEx2Btw.Text)
            Else
                TotaalUitvoer = CDbl(LblExBtw.Text)
            End If
            For T = 0 To 3
                BTWBasis(T) = 0
                BTWEuroBasis(T) = 0
            Next
        Else
            TotaalUitvoer = 0
        End If
        Dim VMAIL_TO As Integer
        VMAIL_TO = 1
        If cbPDF.CheckState = System.Windows.Forms.CheckState.Checked Then
            If Mim.Report.IsOpen = True Then
                Mim.Report.CloseDoc()
            End If

            With Mim.Report
                .OpenDoc()
                .Author = "Jos Vermoesen"
                .GUILanguage = 3 'Nederlands
                .Title = "dnnVerkoopDocument"
            End With
            pdfDrukAf()
            Mim.Report.WriteDoc(LocationCompanyData & Format(Now, "YYYYMMDDHHMMSS") & "-dnnVerkoopDocumenten.pdf")
            Mim.Report.MailSubject = pdfDOKUMENTTYPE & " " & dokumentSleutel
            Mim.Report.MailText = pdfDOKUMENTTYPE & " " & dokumentSleutel & " in bijlage."
            If Not IsDBNull(rsMAR(TableOfCustomers).Fields("e072").Value) Then
                If rsMAR(TableOfCustomers).Fields("e072").Value = "1" Then
                    'automatisch mail proberen
                    Call Mim.Report.AddMailReceiver(rsMAR(TableOfCustomers).Fields("v224").Value, VMAIL_TO)
                    Ktrl = Mim.Report.MailDoc
                    'Call Mim.Report.AddMailReceiver("[FAX: +32 53 781922]", VMAIL_TO)
                    'X = Mim.Report.AddMailAttachment("c:\data\report.vpe", "")
                    If Ktrl = 1 Then 'success
                        'nu nog report sluiten !!
                        Mim.Report.CloseDoc()
                        Exit Sub
                    Else
                        Mim.Report.Preview()
                    End If
                End If
            Else
                'If Me.cbPdfExport.Value = vbChecked Then
                '    MsgBox "exporteren naar DNN folder of andere nog te definiëren"
                '    Mim.Report.CloseDoc
                Mim.Report.Preview()
            End If
        Else
            'TODO: DrukAf()
        End If
    End Sub
    Private Sub pdfDrukAf()
        If Overschrijvingsstrook.CheckState Then
            pdfOVSStrook = 8.2
            ovsDefinitie = "FORM-IBAN.TXT"
        Else
            pdfOVSStrook = 0
        End If
        MeerLijn = Val(String99(Reading, 72))
        Taal = RV(rsKlant, "A10C")
        FlTemp = FreeFile()
        FileOpen(FlTemp, ProgramLocation & "Def\f0" & Taal & ".def", OpenMode.Input)
        T = 0
        While Not EOF(FlTemp)
            Input(FlTemp, rft(T))
            T = T + 1
        End While
        FileClose(FlTemp)
        aantalPaginas = 1
        For tPagina = 1 To aantalPaginas
            Pagina = 0
            pdfKopBALK()
            pdfDetailLijnen()
            pdfOnderKant()
            pdfVoetTekst()
            If Overschrijvingsstrook.CheckState Then
                pdfOverschrijvingsstrook()
            End If
            If tPagina = aantalPaginas Then
            Else
                Ktrl = Mim.Report.PageBreak
            End If
        Next tPagina
    End Sub

    Sub pdfKopBALK()

pdfKopBalk:
        Pagina = Pagina + 1
        If Vr = 11 Then
            pdfDOKUMENTTYPE = Mid(rft(0), 1, 14)
        ElseIf Vr = 13 Then
            pdfDOKUMENTTYPE = Mid(rft(0), 15, 14)
        ElseIf Vr = 73 Then
            pdfDOKUMENTTYPE = "Bestelbon/Leveringsbon"
        Else
            pdfDOKUMENTTYPE = "Offerte"
        End If
        If Val(RV(rsKlant, "A102")) = 0 Then
            rSip(0) = RV(rsKlant, "A100") + " " + RV(rsKlant, "A101")
        Else
            rSip(0) = Mid(fmarBoxText("003", Taal, RV(rsKlant, "A102")), 4, 10) & " " + RV(rsKlant, "A100") + " " + RV(rsKlant, "A101")
        End If
        If KontaktPersoon = 1 Then
            If Val(RV(rsKlant, "vs01")) = 0 Then
                rSip(1) = RV(rsKlant, "A125") + " " + RV(rsKlant, "A127")
            Else
                rSip(1) = Mid(fmarBoxText("003", Taal, RV(rsKlant, "vs01")), 4, 10) & " " + RV(rsKlant, "A125") + " " + RV(rsKlant, "A127")
            End If
        Else
            rSip(1) = ""
        End If
        rSip(2) = RV(rsKlant, "A104") & " " & RV(rsKlant, "A105") & " " & RV(rsKlant, "A106")
        rSip(4) = RV(rsKlant, "A109") & " " & RV(rsKlant, "A107") & " " & RV(rsKlant, "A108")
        With Mim.Report
            .SelectFont("Courier New", 10)
            .TextBold = True
            .TextColor = System.Drawing.ColorTranslator.FromOle(0) 'zwart
            .nTopMargin = 1
            .nLeftMargin = 0.5
            .nRightMargin = 0.5
            .PenSize = 0.01
        End With

        pdfPrintKopTekst()
        With Mim.Report
            .SelectFont("Courier New", 10)
            .TextBold = True
        End With
        Mim.Report.PenSize = 0.01
        pdfY = Mim.Report.PrintBox(1.5, pdfVsoftFrom, UCase(pdfDOKUMENTTYPE))
        pdfY = Mim.Report.Print(8.5, pdfVsoftFrom, dokumentSleutel & " / " & Str(Pagina))
        pdfY = Mim.Report.Print(1.5, pdfY, vbCrLf)
        If Trim(RV(rsKlant, "A161")) = "" Then
            rBTWstr = ""
        ElseIf RV(rsKlant, "v150") = "BE" Then
            rBTWstr = RV(rsKlant, "v150") + "0" + RV(rsKlant, "A161")
        Else
            rBTWstr = RV(rsKlant, "v150") + RV(rsKlant, "A161")
        End If
        pdfY = Mim.Report.PrintBox(1.5, pdfY, rft(1) & vbCrLf & SetSpacing(RV(rsKlant, "A110"), 12) & " " & SetSpacing(rBTWstr, 14) & " " & datumdocMTextbox.Text & " " & vervaldagMTextBox.Text)
        pdfY = Mim.Report.Print(1.5, pdfY, vbCrLf)
        If MeerLijn = 1 Then
            Mim.Report.SelectFont("Courier New", 7.2)
        Else
            Mim.Report.SelectFont("Courier New", 10)
        End If
        If Mid(String99(Reading, 74), 1, 1) = "2" Then
            If MeerLijn = 1 Then
                strMeerLijn = Space(Len(rft(2))) & " "
                'OMSTab = Len(rft(2)) + 1
            End If
        ElseIf Mid(String99(Reading, 75), 1, 1) = "2" Then
            strMeerLijn = Mid(rft(2), 1, 13) & Space(13) & " "
            If MeerLijn = 1 Then
                'OMSTab = 14
            Else
                strMeerLijn = strMeerLijn & vbCrLf
                'OMSTab = 1
            End If
        Else
            strMeerLijn = rft(2) & " "
            If MeerLijn = 1 Then
            Else
                strMeerLijn = strMeerLijn & vbCrLf
            End If
        End If
        If Mid(String99(Reading, 76), 1, 1) = "2" Then
            Mid(rft(10), 63, 2) = "  "
        End If
        strMeerLijn = strMeerLijn & rft(10)
        pdfY = Mim.Report.PrintBox(1.5, pdfY, strMeerLijn)
        pdfY = Mim.Report.Print(1.5, pdfY, vbCrLf)
    End Sub
    Sub pdfPrintKopTekst()
        If Vr = 11 Then
            'Faktuur
            pdfPrintUserDef("1" & Taal & "0", pdfOVSStrook)
        ElseIf Vr = 13 Then
            'Creditnota
            pdfPrintUserDef("1" & Taal & "0", pdfOVSStrook)
        ElseIf Vr = 73 Then
            'Bestelbon/Leveringsbon
            pdfPrintUserDef("1" & Taal & "1", pdfOVSStrook)
        Else
            'Offerte
            pdfPrintUserDef("1" & Taal & "3", pdfOVSStrook)
        End If
        If usrLicentieInfo <> "" Then
            pdfY = Mim.Report.Print(0.6, 0.6, usrLicentieInfo)
        End If
        With Mim.Report
            Mim.Report.SelectFont("Courier New", 10)
            .TextBold = True
            .TextItalic = False
            .TextUnderline = False
            .TextAlignment = 0
            .TextColor = System.Drawing.ColorTranslator.FromOle(0) 'zwart
        End With
        adresString = ""
        For tSip = 0 To 4
            adresString = adresString & UCase(rSip(tSip)) & vbCrLf
        Next
        ktrlHier = Mim.Report.Write(pdfAddressXpos, pdfAddressYpos, pdfAddressXpos2, pdfAddressYpos2, adresString)
    End Sub
    Sub pdfPrintUserDef(ByRef TypeEnTaal As String, ByRef pdfOVSStrook As Double)
        Dim pfcmd As Short
        Dim FlFree As Short
        Dim pdfCmd As String
        If Dir(LocationCompanyData & "pdfDDEF" & TypeEnTaal & ".Txt") = "" Then
            Beep()
            Exit Sub
        Else
            With Mim.Report
                .nTopMargin = 1
                .nLeftMargin = 0.5
                .nRightMargin = 20.8
                .nBottomMargin = 29.8
            End With
            FlFree = FreeFile()
            FileOpen(FlFree, LocationCompanyData & "pdfDDEF" & TypeEnTaal & ".Txt", OpenMode.Input)
            Do While Not EOF(FlFree)
                pdfCmd = LineInput(FlFree)
                If Mid(pdfCmd, 1, 1) = "'" Then
                Else
                    Select Case Trim(UCase(pdfCmd))
                        Case "CMD-VSOFTSPACE"
                            CMDVSOFTSPACE(FlFree)
                        Case "CMD-ADRESSPACE"
                            CMDADRESSPACE(FlFree)
                        Case "CMD-WRITE"
                            CMDWRITE(FlFree)
                        Case "CMD-WRITEBOX"
                            CMDWRITEBOX(FlFree)
                        Case "CMD-PRINT"
                            CMDPRINT(FlFree, pdfOVSStrook)
                        Case "CMD-PICTURE"
                            CMDPICTURE(FlFree)
                        Case Else
                            MsgBox(pfcmd & " nog niet voorzien", MsgBoxStyle.Critical)
                    End Select
                End If
            Loop
            FileClose(FlFree)
        End If
    End Sub

    Sub pdfDetailLijnen()
        Mim.Report.TextBold = False
        For TT = 0 To VerkoopDetail.Items.Count - 1
            VerkoopDetail.SelectedIndex = TT
            GridText = VerkoopDetail.Text
            If Mid(GridText, Len(GridText)) = "2" Then
                pdfY = Mim.Report.Print(1.7, pdfY, Mid(GridText, 1, 75))
                GoTo pdfKontroleLijn
            Else
                pdfFilterVelden()
            End If
            'TODO controle gridtext RIGHT!!!achteraan
            If Mid(GridText, Len(GridText)) = "0" Then
                If Mid(String99(Reading, 74), 1, 1) = "2" Then
                    If MeerLijn = 1 Then
                        strMeerLijn = Space(Len(rft(2))) & " "
                    End If
                ElseIf Mid(String99(Reading, 75), 1, 1) = "2" Then
                    strMeerLijn = SetSpacing(VeldInfo(0), 13)
                    If MeerLijn = 1 Then
                        strMeerLijn = strMeerLijn & Space(13) & " "
                        pdfY = Mim.Report.Print(1.7, pdfY, strMeerLijn)
                    Else
                        pdfY = Mim.Report.Print(1.7, pdfY, strMeerLijn)
                        pdfY = Mim.Report.Print(1.7, pdfY, vbCrLf)
                    End If
                Else
                    If MeerLijn = 1 Then
                    Else
                        pdfY = Mim.Report.Print(1.7, pdfY, SetSpacing(VeldInfo(0), 13) & " " & Dec(dVeldInfo(2), "###0.0") & " " & SetSpacing(Mid(fmarBoxText("004", Taal, VeldInfo(8)), 4, 5), 5) & " ")
                    End If
                End If
            End If
            If MeerLijn = 1 Then
                strMeerLijn = SetSpacing(VeldInfo(0), 13) & " " & Dec(dVeldInfo(2), "###0.0") & " " & SetSpacing(Mid(fmarBoxText("004", Taal, VeldInfo(8)), 4, 5), 5) & " "
            Else
                strMeerLijn = ""
            End If
            strMeerLijn = strMeerLijn & SetSpacing(VeldInfo(1), 40) & " " & Dec(dVeldInfo(4) / dMuntK, "######0.000") & " " & Dec(dVeldInfo(6), vkMaskAantal) & " "
            If Mid(String99(Reading, 76), 1, 1) = "2" Then
                strMeerLijn = strMeerLijn & "    "
            Else
                strMeerLijn = strMeerLijn & Dec(dVeldInfo(5), "##0") & " "
            End If
            BtwTekst = "    "
            Mid(BtwTekst, 1, 1) = Mid(fmarBoxText("002", "2", VeldInfo(9)), 4, 4)
            If InStr(cmdSwitch.Text, "EUR") Then
                strMeerLijn = strMeerLijn & BtwTekst & " " & Dec(dVeldInfo(7) / dMuntK, "########0.00") & vbCrLf
            ElseIf dMuntK <> 1 Then
                strMeerLijn = strMeerLijn & BtwTekst & " " & Dec(dVeldInfo(7) / dMuntK, "########0.00") & vbCrLf
            Else
                strMeerLijn = strMeerLijn & BtwTekst & " " & Dec(Val(Format(dVeldInfo(7) / dMuntK, "#")), "########0.00") & vbCrLf
            End If
            pdfY = Mim.Report.Print(1.7, pdfY, strMeerLijn)

pdfKontroleLijn:
            If pdfY >= pdfVsoftTo - 2.3 - pdfOVSStrook Then
                pdfOnderKant
                pdfVoetTekst
                MsgBox("stop voor nieuwe pdf pagina nog te verbeteren")
                pdfKopBALK()
            End If
        Next
    End Sub
    Sub pdfOnderKant()
        pdfY = Mim.Report.Print(1.5, pdfVsoftTo - 2.3 - pdfOVSStrook, vbCrLf)
        Mim.Report.SelectFont("Courier New", 10)
        sy = "####0.00"
        sy2 = MaskEUR
        Mid(rft(5), 25, 4) = Mid(fmarBoxText("002", "2", "1"), 4, 4)
        Mid(rft(5), 35, 4) = Mid(fmarBoxText("002", "2", "2"), 4, 4)
        Mid(rft(5), 45, 4) = Mid(fmarBoxText("002", "2", "3"), 4, 4)
        Mim.Report.TextBold = False
        strMeerLijn = rft(5) & "  " & rft(6) & Dec(CDbl(LblEx2Btw.Text) / dMuntK, sy2) & vbCrLf
        strMeerLijn = strMeerLijn & " " & Dec(0, sy) & "  " & Dec(0, sy) & "  " & Dec(BTWEuroBedrag(1) / dMuntK, sy)
        strMeerLijn = strMeerLijn & "  " & Dec(BTWEuroBedrag(2) / dMuntK, sy) & "  " & Dec(BTWEuroBedrag(3) / dMuntK, sy) & "  " & rft(7)
        strMeerLijn = strMeerLijn & Dec((TotaalBTW) / dMuntK, sy2) & vbCrLf
        strMeerLijn = strMeerLijn & " " & Dec(TotaalUitvoer / dMuntK, sy) & "  " & Dec(BTWEuroBasis(0) / dMuntK, sy) & "  " & Dec(BTWEuroBasis(1) / dMuntK, sy)
        strMeerLijn = strMeerLijn & "  " & Dec(BTWEuroBasis(2) / dMuntK, sy) & "  " & Dec(BTWEuroBasis(3) / dMuntK, sy) & "  " & rft(8) & sMuntKlant & ":"
        TotaalBedrag = TotaalBTW + CDbl(LblEx2Btw.Text)
        strMeerLijn = strMeerLijn & Dec(TotaalBedrag / dMuntK, sy2)
        If Medekontraktant.CheckState Then
            strMeerLijn = strMeerLijn & vbCrLf & "  " & rft(4)
        End If
        pdfY = Mim.Report.PrintBox(3, pdfY, strMeerLijn)
    End Sub
    Sub pdfVoetTekst()
        If OVSStrooklijnen Then
            pdfOverschrijvingsstrook()
        End If
    End Sub
    Sub pdfFilterVelden()
        VeldInfo(1) = Mid(GridText, 1, 40)
        GridText = Mid(GridText, 42)
        dVeldInfo(4) = Val(Mid(GridText, 1, 11))
        GridText = Mid(GridText, 13)
        dVeldInfo(6) = Val(Mid(GridText, 1, 7))
        GridText = Mid(GridText, 9)
        dVeldInfo(7) = Val(Mid(GridText, 1, 12))
        GridText = Mid(GridText, 14)
        dVeldInfo(2) = Val(Mid(GridText, 1, 6))
        GridText = Mid(GridText, 8)
        VeldInfo(8) = Mid(GridText, 1, 1)
        GridText = Mid(GridText, 3)
        dVeldInfo(5) = Val(Mid(GridText, 1, 3))
        GridText = Mid(GridText, 5)
        VeldInfo(9) = Mid(GridText, 1, 1)
        GridText = Mid(GridText, 3)
        If VeldInfo(9) = "6" Then
            VeldInfo(9) = "0"
        End If
        dVeldInfo(3) = Val(Mid(GridText, 1, 7))
        GridText = Mid(GridText, 9)
        VeldInfo(0) = Mid(GridText, 1, 13)
    End Sub
    Sub pdfOverschrijvingsstrook()
        On Error GoTo 0
        If Dir(LocationCompanyData & ovsDefinitie) = "" Then
            MsgBox(LocationCompanyData & ovsDefinitie & " niet te vinden !  Hierna wordt kladblok opgestart.  Breng uw eigen gegevens in a.u.b. !", 0, "Foutieve Installatie ?")
            On Error Resume Next
            X = Shell("notepad.exe " & LocationCompanyData & ovsDefinitie, 1)
            Exit Sub
        Else
            FlTemp = FreeFile()
            FileOpen(FlTemp, LocationCompanyData & ovsDefinitie, OpenMode.Input)
            sSip(0) = LineInput(FlTemp)
            sSip(1) = LineInput(FlTemp)
            sSip(2) = LineInput(FlTemp)
            sSip(3) = LineInput(FlTemp)
            sSip(4) = LineInput(FlTemp)
            sSip(5) = LineInput(FlTemp)
            sSip(6) = LineInput(FlTemp)
            FileClose(FlTemp)
        End If
        Mim.Report.SelectFont("Courier New", 12)
        Mim.Report.TextBold = True
        rNTTxt = Dec(TotaalBedrag, "#######0.00")
        'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        pdfSpatieren(rNTTxt)
        Mid(rNTTxt2, 17, 1) = " "
        Dim tmppdfY As Double
        pdfY = Mim.Report.Print(15, 22, rNTTxt2) 'bedrag
        Mim.Report.TextBold = False
        rNTTxt = Mid(UCase(rSip(0)), 1, 26) 'Klant naam1
        pdfSpatieren(rNTTxt)
        pdfY = Mim.Report.Print(3.6, 23.7, rNTTxt2 & vbCrLf)
        rNTTxt = Mid(UCase(rSip(2)), 1, 26) 'Klant straat
        pdfSpatieren(rNTTxt)
        pdfY = Mim.Report.Print(3.6, pdfY, rNTTxt2 & vbCrLf)
        rNTTxt = Mid(UCase(rSip(4)), 1, 26) 'Klant plaats
        pdfSpatieren(rNTTxt)
        pdfY = Mim.Report.Print(3.6, pdfY, rNTTxt2 & vbCrLf)
        Mim.Report.TextBold = True
        rNTTxt = sSip(0) 'IBANbedrijf
        pdfSpatieren(rNTTxt)
        pdfY = Mim.Report.Print(3.6, 25.3, rNTTxt2 & vbCrLf & vbCrLf)
        rNTTxt = sSip(1) 'BICbedrijf
        pdfSpatieren(rNTTxt)
        pdfY = Mim.Report.Print(3.6, pdfY, rNTTxt2 & vbCrLf & vbCrLf)
        Mim.Report.TextBold = False
        For T = 2 To 4
            rNTTxt = sSip(T) 'ADRESbedrijf
            pdfSpatieren(rNTTxt)
            pdfY = Mim.Report.Print(3.6, pdfY, UCase(rNTTxt2))
        Next
        rNTTxt = dokumentSleutel
        pdfSpatieren(rNTTxt)
        Mim.Report.TextBold = True
        pdfY = Mim.Report.Print(3.6, pdfY, rNTTxt2)
    End Sub
    Sub pdfSpatieren(rNTTXT As String)
        iRNTxt = Len(rNTTXT)
        rNTTxt2 = ""
        For Teltxt = 1 To iRNTxt
            rNTTxt2 = rNTTxt2 & Mid(rNTTXT, Teltxt, 1) & " "
        Next
    End Sub
    Private Sub Annuleren_Click(sender As Object, e As EventArgs) Handles Annuleren.Click

        If VerkoopDetail.Items.Count Then
            Msg = "Huidige inbreng negeren en venster sluiten." & vbCrLf & vbCrLf
            Msg = Msg & "Bent U zeker ?"
            Ktrl = MsgBox(Msg, 292, "Verkoopverrichtingen verlaten")
            If Ktrl = 6 Then
            Else
                Exit Sub
            End If
        End If
        Mim.SalesTransactionMenuItem.Enabled = True
        Close()
    End Sub

End Class