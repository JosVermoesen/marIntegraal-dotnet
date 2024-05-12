Option Strict Off
Option Explicit On

Public Class FomSalesTransactions

    Dim EditDetailModus As Boolean = False

    Dim dokumentType As String = Space(2)
    Dim pdfDOKUMENTTYPE As String
    Dim dokumentHistoriek As String = Space(11)
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

        'uitsluitend EURO vanaf 2011
        BtnSwitchMoney.Text = "Ingave in EUR"
        If BH_EURO Then
            BtnSwitchMoney.Text = "Ingave in EUR"
        Else
            BH_EURO = True
        End If
        Dim Tel As Short


        dMuntK = 1
        sMunt = "BEF"

        For Tel = 16 To 19
            rbtwVAK(Tel - 16) = String99(READING, Tel)
            rbtwVAK(Tel - 12) = String99(READING, Tel + 6)
        Next

MaskAantal:
        vkMaskAantal = String99(READING, 300)
        If Len(Trim(vkMaskAantal)) <> 7 Then
            SS99("0000.00", 300)
            MsgBox("Masker voor aantal is ingesteld als '0000.00'  Wijzig via setup indien nodig.", MsgBoxStyle.Information)
            GoTo MaskAantal
        End If
        Mid(vkMaskAantal, 1, InStr(vkMaskAantal, ".") - 2) = New String("#", InStr(vkMaskAantal, ".") - 2)

        'AantalEx.Value = String99(READING, 185)

        KontaktPersoon = Val(String99(READING, 201))
        If Val(String99(READING, 202)) = 1 Then
            Overschrijvingsstrook.Checked = True
        Else
            Overschrijvingsstrook.Checked = False
        End If
        If Val(String99(READING, 203)) = 1 Then
            SteedsDrukken = True
        Else
            SteedsDrukken = False
        End If
        Vr = 11
        Dim X As Short
        Schoon()

        If Mid(String99(READING, 20), 1, 1) = "4" Then
            ForFait = 1
            MsgBox("Verkoopfakturatie voor forfaitair BTW SYSTEEM.")
            'TODO: TekstInfo(3).Visible = True
        Else
            ForFait = 0
        End If
        KlantRekening = String99(READING, 9)
        mgrklantenrekMTextBox.Text = KlantRekening
        'If String99(READING, 299) = "2" Then
        'Me.cbPDF.CheckState = System.Windows.Forms.CheckState.Unchecked
        'Else
        cbPDF.Checked = True
        'End If

        Dim TempoKLS As String
        Dim TempoDOK As String

        If InStr(GRIDTEXT_9, vbTab) <> 0 Then
            TempoKLS = Mid(GRIDTEXT_9, 1, InStr(GRIDTEXT_9, vbTab) - 1)
            GRIDTEXT_9 = Mid(GRIDTEXT_9, InStr(GRIDTEXT_9, vbTab) + 1)
            XLOG_KEY = TempoKLS
            InstalKlant()
            Select Case Mid(GRIDTEXT_9, 1, 2)
                Case "13", "14", "15"
                    dokumentType = Mid(GRIDTEXT_9, 1, 2)
                    TempoDOK = Mid(GRIDTEXT_9, InStr(GRIDTEXT_9, vbTab) + 1)
                    If Len(TempoDOK) <> 8 Then
                        'VerkoopOptie_CheckedChanged(VerkoopOptie.Item(0), New System.EventArgs())
                        GetSellNumber()

                    Else
                        XLOG_KEY = TempoDOK
                        Stop
                        'TODO: LaadHetdokument()
                    End If
            End Select
        End If
        On Error Resume Next
        'GetSellNumber()
        RbDirekteVerkoop.Checked = True
        Activate()

    End Sub

    Private Sub KlantAktiveren_Click(sender As Object, e As EventArgs) Handles BtnGetClient.Click
        If VerkoopDetail.Items.Count Then
            MSG = "Huidige inbreng en klant negeren." & vbCrLf & vbCrLf
            MSG = MSG & "Bent U zeker."
            CTRL_BOX = MsgBox(MSG, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Andere klant kiezen")
            If CTRL_BOX = MsgBoxResult.Yes Then
            Else
                Exit Sub
            End If
        End If
        SHARED_INDEX = 1
        SHARED_FL = TABLE_CUSTOMERS
        GRIDTEXT = ""
        SqlSearch.ShowDialog()
        If KTRL = 0 Then
            InstalKlant()
        Else
            Schoon()
        End If
        SqlSearch.Dispose()
    End Sub

    Private Sub CreditNota_CheckedChanged(sender As Object, e As EventArgs) Handles CbCreditNota.CheckedChanged
        If CbCreditNota.Checked = True Then
            RbDirekteVerkoop.Checked = True
            RbDirekteVerkoop.Enabled = False
            RbBestelbon.Enabled = False
            RbOfferte.Enabled = False
            CbCreditNota.Enabled = False
            GetSellNumber()
        End If
    End Sub

    Private Sub DirekteVerkoop_CheckedChanged(sender As Object, e As EventArgs) Handles RbDirekteVerkoop.CheckedChanged
        If RbDirekteVerkoop.Checked = True Then
            GetSellNumber()
        End If
    End Sub

    Private Sub Bestelbon_CheckedChanged(sender As Object, e As EventArgs) Handles RbBestelbon.CheckedChanged
        If RbBestelbon.Checked = True Then
            GetSellNumber()
        End If
    End Sub

    Private Sub Offerte_CheckedChanged(sender As Object, e As EventArgs) Handles RbOfferte.CheckedChanged
        If RbOfferte.Checked = True Then
            GetSellNumber()
        End If
    End Sub

    Private Sub Klassement_Click(sender As Object, e As EventArgs) Handles BtnDocumentHistory.Click
        Dim T As Short
        Dim LaatsteWAS As String
        Dim TotaalEX As Decimal
        Dim dataVeld As String
        If KlantInfo.Text = "" Then Exit Sub
        T = 0
        Dim xlogHier As New FormXlog
        xlogHier.Hide()
        xlogHier.Text = "Document inladen voor : " + RV(rsKlant, "A100")
        xlogHier.X.Columns.Add("Document", 100)
        xlogHier.X.Columns.Add("Datum", 100)
        xlogHier.X.Columns.Add("Bedrag EUR", 100)
        xlogHier.X.Columns.Add("Bedrag BEF", 100)
        xlogHier.X.Columns.Add("Zie ook document", 100)
        xlogHier.BtnEditLine.Visible = False
        xlogHier.BtnHideAndGoBack.Visible = False
        xlogHier.BtnSelectOnly.Visible = True
        xlogHier.AcceptButton = xlogHier.BtnSelectOnly
        XLOG_KEY = ""
        rsDetail = New ADODB.Recordset
        On Error Resume Next
        Err.Clear()
        rsDetail.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        MSG = "SELECT * FROM Allerlei WHERE v004 = 'K" + RV(rsKlant, "A110") + "' AND v005 Like '" + dokumentType + "%' ORDER BY v004, v005 DESC"
        Cursor.Current = Cursors.WaitCursor
        rsDetail.Open(MSG, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
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
                    dataVeld = adoBibTekst(rsDetail.Fields("Memo"), "#v033 #")
                    Dim itemHier As New ListViewItem(dataVeld)
                    dataVeld = FunctionDateText(adoBibTekst(rsDetail.Fields("Memo"), "#v035 #"))
                    itemHier.SubItems.Add(dataVeld)
                    If adoBibTekst(rsDetail.Fields("Memo"), "#vEUR #") = "EUR" Then
                        dataVeld = Format(CDbl(adoBibTekst(rsDetail.Fields("Memo"), "#v137 #")), "#,##0.00")
                        itemHier.SubItems.Add(dataVeld)
                        dataVeld = Format(CDbl(adoBibTekst(rsDetail.Fields("Memo"), "#v137 #")) * EURO, "#,##0.00")
                        itemHier.SubItems.Add(dataVeld)
                    Else
                        dataVeld = Format(CDbl(adoBibTekst(rsDetail.Fields("Memo"), "#v137 #")) / EURO, "#,##0.00")
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
        If XLOG_KEY <> "" Then
            LaadHetdokument()
        End If
        Exit Sub
    End Sub

    Private Sub Schoonvegen_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Schoon()
    End Sub

    Private Sub cbLayOudPDF_Click(sender As Object, e As EventArgs) Handles cbLayOudPDF.Click
        LayOutpdfDokument.Show()
    End Sub

    Private Sub CmbAfdruk_Click(sender As Object, e As EventArgs) Handles BtnGenerateCopy.Click
        Dim A As String
        Dim refString As String
        Dim refID As String
        Dim aa As String = "                              "
        Dim dTTwb As Double
        Dim DummySleutel As String
        Dim BestondReeds As Short
        Dim T As Short
        If dokumentType = "15" And BtnCancel.Enabled = True Then
            If Not IsDateOk(datumdocMTextbox.Text, PERIODAS_TEXT) Then
                FormBYPERDAT.WindowState = FormWindowState.Normal
                FormBYPERDAT.Focus()
                datumdocMTextbox.Focus()
                Beep()
                Exit Sub
            End If
        End If
        If dokumentType = "15" Then
            If frmDokHistoriek.lstDokHistoriek.Items.Count <> 0 Then
                MSG = ""
                refID = "RF:"
                For T = 0 To frmDokHistoriek.lstDokHistoriek.Items.Count - 1
                    frmDokHistoriek.lstDokHistoriek.SelectedIndex = T
                    MSG = MSG & frmDokHistoriek.lstDokHistoriek.Text & " "
                Next
                CTRL_BOX = MsgBox("Bons als referte opnemen." & vbCr & vbCr & refID & MSG, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1)
                If CTRL_BOX = MsgBoxResult.Yes Then
                    refString = New String(" ", 75) & "|2"
                    VerkoopDetail.Items.Add(refString)
                    Do While MSG <> ""
                        refString = New String(" ", 75) & "|2"
                        Mid(refString, 1) = refID & Mid(MSG, 1, 72)
                        If Len(MSG) > 72 Then
                            MSG = Mid(MSG, 73)
                        Else
                            MSG = ""
                        End If
                        VerkoopDetail.Items.Add(refString)
                    Loop
                End If
            End If
        End If
        TotaalBTW = 0
        If CbMedekontraktant.CheckState Or VerkoopFLG Then
            BTWBedrag(1) = 0 : BTWEuroBedrag(1) = 0
            BTWBedrag(2) = 0 : BTWEuroBedrag(2) = 0
            BTWBedrag(3) = 0 : BTWEuroBedrag(3) = 0
        Else
            For T = 0 To 3
                If InStr(BtnSwitchMoney.Text, "EUR") Then
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
            Mim.Report.WriteDoc(LOCATION_COMPANYDATA & Format(Now, "YYYYMMDDHHMMSS") & "-dnnVerkoopDocumenten.pdf")
            Mim.Report.MailSubject = pdfDOKUMENTTYPE & " " & dokumentSleutel
            Mim.Report.MailText = pdfDOKUMENTTYPE & " " & dokumentSleutel & " in bijlage."
            If Not IsDBNull(RS_MAR(TABLE_CUSTOMERS).Fields("e072").Value) Then
                If RS_MAR(TABLE_CUSTOMERS).Fields("e072").Value = "1" Then
                    'automatisch mail proberen
                    Call Mim.Report.AddMailReceiver(RS_MAR(TABLE_CUSTOMERS).Fields("v224").Value, VMAIL_TO)
                    KTRL = Mim.Report.MailDoc
                    'Call Mim.Report.AddMailReceiver("[FAX: +32 53 781922]", VMAIL_TO)
                    'X = Mim.Report.AddMailAttachment("c:\data\report.vpe", "")
                    If KTRL = 1 Then 'success
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

    Private Sub VerkoopDetail_DoubleClick(sender As Object, e As EventArgs) Handles VerkoopDetail.DoubleClick

        If VerkoopDetail.SelectedIndex Then
            EditDetailModus = True
            SendKeys.Send("{ENTER}")
        End If

    End Sub

    Private Sub VerkoopDetail_Leave(sender As Object, e As EventArgs) Handles VerkoopDetail.Leave

        VerkoopDetail.SelectedIndex = -1

    End Sub

    Private Sub VerkoopDetail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VerkoopDetail.KeyPress

        'If e.KeyChar <> Chr(13) Then
        'Exit Sub
        'End If
        'MessageBox.Show("Enter pressed")

        Dim Positie As Integer
        Dim TempoBedrag As Double
        Dim TempoBTW As Integer

        MessageBox.Show("Pressed key: " + e.KeyChar)
        Dim ascii As Byte() = System.Text.Encoding.ASCII.GetBytes(e.KeyChar)

Jumper:
        If EditDetailModus Then


        End If

        Select Case UCase(e.KeyChar)
            Case "S"
                SHARED_INDEX = 0
            Case "O"
                SHARED_INDEX = 1
            Case "T"
                SHARED_INDEX = 2
        End Select
        Positie = VerkoopDetail.SelectedIndex
        'MessageBox.Show(Len(VerkoopDetail.SelectedItem.ToString))

        Select Case e.KeyChar
            Case Chr(13)         'Enter
                If Positie < 0 Then
                    MessageBox.Show("Eerst een lijn selecteren!")
                    Exit Sub
                End If
                ' If dokumentType <> "15" And Annuleren.Enabled = False Then
                '     Annuleren.Enabled = True
                ' End If
                GRIDTEXT = VerkoopDetail.Text
                Dim lastChar As Char = GRIDTEXT.Substring(GRIDTEXT.Length - 1)
                If lastChar = "2" Then
                Else
                    RefreshBTW()
                End If
                'XLogKassa = ""
                FormSalesEdit.Close()
                FormSalesEdit.ShowDialog()
                'FormSalesEdit.Hide()
                Focus()

                If GRIDTEXT = "" Then
                    RefreshBTW()
                Else
                    If lastChar = "2" Then
                    Else
                        TempoBedrag = Val(Mid(GRIDTEXT, 62, 12))
                        TempoBTW = Val(Mid(GRIDTEXT, 88, 1))
                        If TempoBTW = 6 Then
                            If BH_EURO Then
                                If BtnSwitchMoney.Text = "Ingave in EUR" Then
                                    BTWBasis(0) = BTWBasis(0) + TempoBedrag
                                Else
                                    BTWBasis(0) = BTWBasis(0) + Math.Round(TempoBedrag / EURO, 2)
                                End If
                            Else
                                If BtnSwitchMoney.Text = "Ingave in BEF" Then
                                    BTWBasis(0) = BTWBasis(0) + TempoBedrag
                                Else
                                    BTWBasis(0) = BTWBasis(0) + Math.Round(TempoBedrag * EURO, 2)
                                End If
                            End If
                        Else
                            If BH_EURO Then
                                If BtnSwitchMoney.Text = "Ingave in EUR" Then
                                    BTWBasis(TempoBTW) = BTWBasis(TempoBTW) + TempoBedrag
                                Else
                                    BTWBasis(TempoBTW) = BTWBasis(TempoBTW) + Math.Round(TempoBedrag / EURO, 2)
                                End If
                            Else
                                If BtnSwitchMoney.Text = "Ingave in BEF" Then
                                    BTWBasis(TempoBTW) = BTWBasis(TempoBTW) + TempoBedrag
                                Else
                                    BTWBasis(TempoBTW) = BTWBasis(TempoBTW) + Math.Round(TempoBedrag * EURO, 2)
                                End If
                            End If
                        End If
                    End If
                    ' VerkoopDetail.RemoveItem Positie
                    ' VerkoopDetail.AddItem GRIDTEXT, Positie
                End If
                ' VerkoopDetail.ListIndex = Positie
                CalculateTotal()

            Case Chr(43)
                GRIDTEXT = ""
                XLOG_CASHREGISTER = ""
                FormSalesEdit.ShowDialog()
                Focus()
                If GRIDTEXT = "" Then
                Else
                    If GRIDTEXT.Substring(GRIDTEXT.Length - 1) = "2" Then
                    Else
                        TempoBedrag = Val(Mid(GRIDTEXT, 62, 12))
                        TempoBTW = Val(Mid(GRIDTEXT, 88, 1))
                        If TempoBTW = 6 Then
                            If BH_EURO Then
                                If BtnSwitchMoney.Text = "Ingave in EUR" Then
                                    BTWBasis(0) = BTWBasis(0) + TempoBedrag
                                Else
                                    BTWBasis(0) = BTWBasis(0) + Math.Round(TempoBedrag / EURO, 2)
                                End If
                            Else
                                If BtnSwitchMoney.Text = "Ingave in BEF" Then
                                    BTWBasis(0) = BTWBasis(0) + TempoBedrag
                                Else
                                    BTWBasis(0) = BTWBasis(0) + Math.Round(TempoBedrag * EURO, 2)
                                End If
                            End If
                        Else
                            If BH_EURO Then
                                If BtnSwitchMoney.Text = "Ingave in EUR" Then
                                    BTWBasis(TempoBTW) = BTWBasis(TempoBTW) + TempoBedrag
                                Else
                                    BTWBasis(TempoBTW) = BTWBasis(TempoBTW) + Math.Round(TempoBedrag / EURO, 2)
                                End If
                            Else
                                If BtnSwitchMoney.Text = "Ingave in BEF" Then
                                    BTWBasis(TempoBTW) = BTWBasis(TempoBTW) + TempoBedrag
                                Else
                                    BTWBasis(TempoBTW) = BTWBasis(TempoBTW) + Math.Round(TempoBedrag * EURO, 2)
                                End If
                            End If
                        End If
                        CalculateTotal()
                    End If

                    Dim splitmilieu() As String
                    Dim telmilieu As Integer

                    ' If Positie < 0 Then
                    ' VerkoopDetail.AddItem GRIDTEXT, VerkoopDetail.ListCount
                    '        If BL_ENVIRONMENT = True Then
                    '                    splitmilieu = Split(MilieuGridText, vbCrLf)
                    '                    For telmilieu = 0 To UBound(splitmilieu) - 1
                    '                        VerkoopDetail.AddItem splitmilieu(telmilieu), VerkoopDetail.ListCount
                    '            Next
                    '                    BL_ENVIRONMENT = False
                    '                End If
                    '            Else
                    '                VerkoopDetail.AddItem GRIDTEXT, Positie
                    '        If BL_ENVIRONMENT = True Then
                    '                    splitmilieu = Split(MilieuGridText, vbCrLf)
                    '                    MsgBox "stop, waarom?"
                    '            For telmilieu = 0 To UBound(splitmilieu) - 1
                    '                        VerkoopDetail.AddItem splitmilieu(telmilieu), VerkoopDetail.ListCount
                    '            Next
                    '                    BL_ENVIRONMENT = False
                    '                End If
                    '            End If
                    '        End If
                    '        If Mid(XLogKey, 39, 2) = vbCrLf Then
                    Do While Len(XLOG_KEY) <> 0
                        MSG = Mid(XLOG_KEY, 1, 38) + Space(37) + "|2"
                        VerkoopDetail.Items.Add(MSG)
                        XLOG_KEY = Mid(XLOG_KEY, 41)
                    Loop
                End If

                    Case Chr(79), Chr(83), Chr(84), Chr(111), Chr(115), Chr(116)
                '        If dokumentType <> "15" And Annuleren.Enabled = False Then
                '            Annuleren.Enabled = True
                '        End If
                '        'LijnType(InStr$("SOT", UCase$(Chr$(KeyAscii))) - 1).Value = 1
                ' KeyAscii = 43
                '        GoTo Jumper
            Case Else
                ' VensterKeyPress KeyAscii IS NEVER USED BEFORE
        End Select
        If VerkoopDetail.Items.Count Then
            BtnGenerateAndSave.Enabled = True
            BtnGenerateCopy.Enabled = True
        Else
            BtnGenerateAndSave.Enabled = False
            BtnGenerateCopy.Enabled = False
        End If
        RefreshBTW()
        If e.KeyChar = "S" Then BtnFromStock.Focus()
        If e.KeyChar = "O" Then BtnFromDescription.Focus()
        If e.KeyChar = "T" Then BtnPutTextLine.Focus()

    End Sub

    Private Sub VerkoopDetail_Enter(sender As Object, e As EventArgs) Handles VerkoopDetail.Enter

        'MessageBox.Show("VerkoopDetail entered")

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        If VerkoopDetail.Items.Count Then
            MSG = "Huidige inbreng negeren en venster sluiten." & vbCrLf & vbCrLf
            MSG = MSG & "Bent U zeker ?"
            KTRL = MsgBox(MSG, 292, "Verkoopverrichtingen verlaten")
            If KTRL = 6 Then
            Else
                Exit Sub
            End If
        End If
        Mim.SalesTransactionMenuItem.Enabled = True
        Close()

    End Sub

    Private Sub InstalKlant()
        Dim Klantje As String
        Dim T As Short

        rsKlant = New ADODB.Recordset
        On Error Resume Next
        Err.Clear()
        rsKlant.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        MSG = "SELECT TOP 1 * FROM Klanten WHERE A110 = '" & XLOG_KEY & "'"
        rsKlant.Open(MSG, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        If Err.Number Or rsKlant.RecordCount <> 1 Then
            MsgBox("Onverwachte situatie")
            Exit Sub
        End If

        VerkoopDetail.Enabled = True
        Klantje = vbCrLf & RV(rsKlant, "A100") & vbCrLf & RV(rsKlant, "A125") & vbCrLf & RV(rsKlant, "A104") & vbCrLf & RV(rsKlant, "A109") & " " & RV(rsKlant, "A107") & " " & RV(rsKlant, "A108")
        BtnClear.Enabled = True
        Sjabloon.Enabled = True
        DagKoers.Text = "Dagkoers " & RV(rsKlant, "vs03")
        sMuntKlant = RV(rsKlant, "vs03")
        rsDetail = New ADODB.Recordset
        On Error Resume Next
        Err.Clear()
        rsDetail.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        MSG = "SELECT TOP 1 * FROM Allerlei WHERE v005 = '10" & sMuntKlant & "'"
        rsDetail.Open(MSG, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        'cmdSwitch.Enabled = True
        If rsDetail.RecordCount <> 1 Then
            MsgBox("Muntkode eerst inbrengen via diverse gebruikersfiches a.u.b.  Nu wordt automatisch verdergewerkt met BEF", MsgBoxStyle.Information, "Muntkode is " & sMunt)
            If BH_EURO Then
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

        If BH_EURO Then
            If sMuntKlant = "BEF" Then
                BtnSwitchMoney.Text = "Ingave in BEF"
                'cmdSwitch.Enabled = True
                dMuntK = 1
                'TekstInfo(5).Text = Dec$(1 / EURO, "##0.########")
            ElseIf sMuntKlant = "EUR" Then
                BtnSwitchMoney.Text = "Ingave in EUR"
                'cmdSwitch.Enabled = True
                dMuntK = 1
            Else
                BtnSwitchMoney.Text = "Ingave in EUR"
                'cmdSwitch.Enabled = False
            End If
        Else
            If sMuntKlant = "EUR" Then
                BtnSwitchMoney.Text = "Ingave in EUR"
                'cmdSwitch.Enabled = True
                dMuntK = 1
            ElseIf sMuntKlant = "BEF" Then
                BtnSwitchMoney.Text = "Ingave in BEF"
                'cmdSwitch.Enabled = True
                dMuntK = 1
            Else
                BtnSwitchMoney.Text = "Ingave in BEF"
                'cmdSwitch.Enabled = False
            End If
        End If
        If sMuntKlant = "BEF" Or sMuntKlant = "EUR" Then
            muntMTextBox.Text = Dec(dMuntK, "##0.########")
        Else
            Stop
            dMuntK = Val(muntMTextBox.Text)
        End If
        DIRECTSELL_STRING = BtnSwitchMoney.Text
        rsDetail.Close()
        rsDetail = Nothing
        If RV(rsKlant, "v149") = "" Then
            MsgBox("Landnummer is verplicht !")
            Exit Sub
        ElseIf RV(rsKlant, "v149") = "002" Then
            KlantInfo.Text = SetSpacing(RV(rsKlant, "A110"), 12) & "* Binnenland * " & Klantje
            VerkoopFLG = 0
            CbMedekontraktant.Enabled = True
        ElseIf InStr(SISO, RV(rsKlant, "v149")) Then
            KlantInfo.Text = SetSpacing(RV(rsKlant, "A110"), 12) & "* E.U. mét Btw-nummer * " & Klantje
            VerkoopFLG = 1
            CbMedekontraktant.Enabled = False
            If SetSpacing(RV(rsKlant, "A161"), 12) = Space(12) Then
                KlantInfo.Text = SetSpacing(RV(rsKlant, "A110"), 12) & "* E.U. geen Btw-nummer * " & Klantje
                VerkoopFLG = 0
            End If
        Else
            KlantInfo.Text = SetSpacing(RV(rsKlant, "A110"), 12) & "* Uitvoer buiten E.U. *" & Klantje
            VerkoopFLG = 2
            CbMedekontraktant.Enabled = False
        End If

        datumdocMTextbox.Enabled = True
        vervaldagMTextBox.Enabled = True
        mgrklantenrekMTextBox.Enabled = True


        If RV(rsKlant, "v151") = "1" Then
            CbMedekontraktant.CheckState = System.Windows.Forms.CheckState.Checked
        End If

        If Mid(RV(rsKlant, "v161"), 1, 3) = "400" Then
            Stop
            KlantRekening = RV(rsKlant, "v161")
            If Not adoGet(TABLE_LEDGERACCOUNTS, 0, "=", KlantRekening) Then
                Beep()
                KlantRekening = String99(READING, 9)
            End If
        Else
            KlantRekening = String99(READING, 9)
        End If
        mgrklantenrekMTextBox.Text = KlantRekening
        If Mid(RV(rsKlant, "v225"), 1, 2) = "70" Then
            DefaultVerkoop = RV(rsKlant, "v225")
            If Not adoGet(TABLE_LEDGERACCOUNTS, 0, "=", DefaultVerkoop) Then
                Beep()
                DefaultVerkoop = String99(READING, 25)
            End If
        Else
            DefaultVerkoop = String99(READING, 25)
        End If
        vervaldagMTextBox.Text = VValdag(datumdocMTextbox.Text, RV(rsKlant, "vs04"))
        IsErKlassement()
        If RV(rsKlant, "v253") <> "" Then
            cmdSQLInfo.Visible = True
        End If
    End Sub

    Private Function Schoon() As Short

        Dim T As Short

        TLB_RECORD(TABLE_VARIOUS) = ""
        dokumentHistoriek = Space(11)
        VerkoopDetail.Enabled = False
        BtnGenerateAndSave.Enabled = False
        BtnGenerateCopy.Enabled = False
        BtnSwitchMoney.Enabled = False
        CbMedekontraktant.Enabled = True
        Sjabloon.Enabled = False
        BtnDocumentHistory.Enabled = False
        'Klassement.Font = VB6.FontChangeBold(Klassement.Font, False)
        CbBTWBouw.CheckState = System.Windows.Forms.CheckState.Unchecked
        VAT_BOBTHEBUILDERS = False
        KlantInfo.Text = ""
        BtnCancel.Enabled = True
        CbMedekontraktant.CheckState = System.Windows.Forms.CheckState.Unchecked

        If RbDirekteVerkoop.Enabled Then
            CbCreditNota.Checked = False
        End If

        Err.Clear()
        On Error Resume Next

        datumdocMTextbox.Text = MIM_GLOBAL_DATE
        If Err.Number Then MsgBox("Landinstellingen voor België voorzien a.u.b.  Het programma wordt hierna beëindigd.", MsgBoxStyle.Critical) : End
        vervaldagMTextBox.Text = MIM_GLOBAL_DATE
        mgrklantenrekMTextBox.Text = KlantRekening
        LblExBtw.Text = ""
        LblInBtw.Text = ""
        LblEx2Btw.Text = ""
        LblIn2Btw.Text = ""
        If lstKopiePlak.Items.Count Then
            MSG = "Gekopiëerde lijnen behouden ?"
            KTRL = MsgBox(MSG, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1)
            Select Case KTRL
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
        MSG = "SELECT TOP 1 * FROM Allerlei WHERE v004 = 'K" + RV(rsKlant, "A110") + "' AND v005 Like '" + dokumentType + "%'"
        rsDetail.Open(MSG, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        If Err.Number Or rsDetail.RecordCount = 0 Then
            BtnDocumentHistory.Enabled = False
            'Klassement.Font = VB6.FontChangeBold(Klassement.Font, False)
        Else
            BtnDocumentHistory.Enabled = True
            'Klassement.Font = VB6.FontChangeBold(Klassement.Font, True)
        End If
        rsDetail.Close()
        'UPGRADE_NOTE: Object rsDetail may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        rsDetail = Nothing

    End Sub

    Private Sub RasterSchoon()
        Dim T As Short

        VerkoopDetail.Items.Clear()
        GRIDTEXT = ""
        For T = 0 To 3
            BTWBasis(T) = 0
            BTWBedrag(T) = 0

            BTWEuroBasis(T) = 0
            BTWEuroBedrag(T) = 0
        Next
        TotaalBTW = 0
        TotaalUitvoer = 0
        CalculateTotal()

    End Sub

    Sub GetSellNumber()

        If dokumentHistoriek <> Space(11) Then
            MsgBox("Opgelet, data van o.a. " & dokumentHistoriek & " is nog aktief.  Vermijd dubbele bewerkingen.", 64)
        End If

        If VerkoopDetail.Items.Count Then
            If BtnCancel.Enabled = False Then
                MsgBox("U gaat naar een hogere modus met ingeladen dokument(en)." & vbCrLf & vbCrLf & "Indien dit niet de bedoeling was, onmiddellijk verkoopvenster sluiten en herbeginnen a.u.b.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
                dokumentHistoriek = dokumentSleutel
                TLB_RECORD(TABLE_VARIOUS) = ""
                BtnCancel.Enabled = True
            End If
        End If

        If RbDirekteVerkoop.Checked Then
            dokumentType = "15" 'Faktuur of creditnota
            If CbCreditNota.Enabled = True Then
                Vr = 11
                CbCreditNota.Checked = False
            Else
                Vr = 13
                CbCreditNota.Checked = True
            End If
            dokumentSleutel = SleutelDok(Vr)
            datumdocMTextbox.Text = MIM_GLOBAL_DATE
            vervaldagMTextBox.Text = MIM_GLOBAL_DATE
            Text = SetSpacing("Ctrl+F2 Verkoopverrichting", 28) & "(" & dokumentSleutel & ")"
            chkZonderRelatie.Visible = False
        ElseIf RbBestelbon.Checked Then
            dokumentType = "14" 'Bestelbon, Leveringsbon
            Vr = 73
            dokumentSleutel = SleutelDok(Vr)
            Text = SetSpacing("Ctrl+F2 Bestelling/levering", 28) & "(" & dokumentSleutel & ")"
            chkZonderRelatie.Visible = True
        ElseIf RbOfferte.Checked Then
            dokumentType = "13" 'Offerte
            Vr = 59
            dokumentSleutel = SleutelDok(Vr)
            Text = SetSpacing("Ctrl+F2 Offerte", 28) & "(" & dokumentSleutel & ")"
            chkZonderRelatie.Visible = True
        End If
        TekstInfo3.Text = dokumentSleutel

        IsErKlassement()

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
        MSG = "SELECT * FROM Allerlei WHERE v005 Like '" & dokumentType & Mid(XLOG_KEY, 1, 11) & "%'"
        Cursor.Current = Cursors.WaitCursor
        rsDetail.Open(MSG, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
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
            MSG = "Document: " & Mid(XLOG_KEY, 1, 11)
            MSG = MSG & " reeds in relatie tot " & vbCrLf
            MSG = MSG & "verkoopdocument(en): " & adoBibTekst(rsDetail.Fields("Memo"), "#v147 #") & vbCrLf & vbCrLf
            MSG = MSG & "Toch ophalen ?"
            CTRL_BOX = MsgBox(MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Opletten !")
            If CTRL_BOX = MsgBoxResult.No Then
                Cursor.Current = Cursors.Default
                Exit Sub
            End If
        End If
        dokumentSleutel = adoBibTekst(rsDetail.Fields("Memo"), "#v033 #")
        If Mid(dokumentSleutel, 2, 1) = "1" Then
            CbCreditNota.CheckState = System.Windows.Forms.CheckState.Checked
        End If
        Dim docInEur As String
        TekstInfo3.Text = dokumentSleutel
        CbMedekontraktant.CheckState = Val(adoBibTekst(rsDetail.Fields("Memo"), "#v135 #"))
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
        BtnCancel.Enabled = False
        BtnGenerateAndSave.Enabled = True
        BtnGenerateCopy.Enabled = True
        On Error Resume Next
        If docInEur = "EUR" Then
            BtnSwitchMoney.Text = "Ingave in EUR"
        Else
            BtnSwitchMoney.Text = "Ingave in BEF"
        End If
        BtnGenerateAndSave.Focus()
        Select Case dokumentType
            Case "15"
                RbDirekteVerkoop.Enabled = False
                RbBestelbon.Enabled = False
                RbOfferte.Enabled = False
                datumdocMTextbox.Enabled = False
                vervaldagMTextBox.Enabled = False
                mgrklantenrekMTextBox.Enabled = False
                CbMedekontraktant.Enabled = False
                CbCreditNota.Enabled = False
                VerkoopDetail.Enabled = False
                BtnGenerateAndSave.Enabled = False
            Case "14"
                RbBestelbon.Enabled = False
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
        maskerMULTI = MASK_EURBH
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
                        If BtnSwitchMoney.Text = "Ingave in EUR" Then
                            BTWBasis(0) = BTWBasis(0) + Val(Dec(Val(Mid(aa, 62, 12)) * EURO, MASK_EURBH))
                            BTWEuroBasis(0) = BTWEuroBasis(0) + Val(Dec(Val(Mid(aa, 62, 12)), MASK_EURBH))
                        Else
                            BTWBasis(0) = BTWBasis(0) + Val(Dec(Val(Mid(aa, 62, 12)), MASK_EURBH))
                            BTWEuroBasis(0) = BTWEuroBasis(0) + Val(Dec(Val(Mid(aa, 62, 12)) / EURO, MASK_EURBH))
                        End If
                    Else
                        If BtnSwitchMoney.Text = "Ingave in EUR" Then
                            If BTWBasis(bVak) <> 0 Then
                                BTWBasis(bVak) = System.Math.Round(BTWBasis(bVak))
                                maskerMULTI = "############"
                            End If
                            BTWBasis(bVak) = BTWBasis(bVak) + Val(Dec(Val(Mid(aa, 62, 12)) * EURO, maskerMULTI))
                            BTWEuroBasis(bVak) = BTWEuroBasis(bVak) + Val(Dec(Val(Mid(aa, 62, 12)), MASK_EURBH))
                        Else
                            If BTWBasis(bVak) <> 0 Then
                                maskerMULTI = "############"
                                BTWBasis(bVak) = Val(Dec(BTWBasis(bVak), maskerMULTI))
                            End If
                            BTWBasis(bVak) = BTWBasis(Val(Mid(aa, 88, 1))) + Val(Dec(Val(Mid(aa, 62, 12)), maskerMULTI))
                            BTWEuroBasis(bVak) = BTWEuroBasis(Val(Mid(aa, 88, 1))) + Val(Dec(Val(Mid(aa, 62, 12)) / EURO, MASK_EURBH))
                        End If
                    End If
            End Select
        Next
        CalculateTotal()
    End Sub

    Private Sub CalculateTotal()
        Dim BTWIn As Double
        Dim BTWEx As Double
        Dim BtwEuroIn As Double
        Dim BtwEuroEx As Double
        Dim Teller As Short
        On Error Resume Next
        For Teller = 1 To 3
            BTWBedrag(Teller) = Val(Dec((BTWBasis(Teller)) * Val(Mid(fmarBoxText("002", "2", Format(Teller)), 4, 4)) / 100, MASK_EURBH))
            BTWIn = BTWIn + BTWBasis(Teller) + BTWBedrag(Teller)
            BTWEx = BTWEx + BTWBasis(Teller)

            BTWEuroBedrag(Teller) = Val(Dec(BTWEuroBasis(Teller) * Val(Mid(fmarBoxText("002", "2", Format(Teller)), 4, 4)) / 100, MASK_EURBH))
            BtwEuroIn = BtwEuroIn + BTWEuroBasis(Teller) + BTWEuroBedrag(Teller)
            BtwEuroEx = BtwEuroEx + BTWEuroBasis(Teller)
            If BtnSwitchMoney.Text = "Ingave in BEF" Then
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

    Private Sub pdfDrukAf()
        If Overschrijvingsstrook.CheckState Then
            pdfOVSStrook = 8.2
            ovsDefinitie = "FORM-IBAN.TXT"
        Else
            pdfOVSStrook = 0
        End If
        MeerLijn = Val(String99(READING, 72))
        Taal = RV(rsKlant, "A10C")
        FlTemp = FreeFile()
        FileOpen(FlTemp, PROGRAM_LOCATION & "Def\f0" & Taal & ".def", OpenMode.Input)
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
                KTRL = Mim.Report.PageBreak
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
        pdfY = Mim.Report.PrintBox(1.5, PDF_VSOFT_FROM, UCase(pdfDOKUMENTTYPE))
        pdfY = Mim.Report.Print(8.5, PDF_VSOFT_FROM, dokumentSleutel & " / " & Str(Pagina))
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
        If Mid(String99(READING, 74), 1, 1) = "2" Then
            If MeerLijn = 1 Then
                strMeerLijn = Space(Len(rft(2))) & " "
                'OMSTab = Len(rft(2)) + 1
            End If
        ElseIf Mid(String99(READING, 75), 1, 1) = "2" Then
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
        If Mid(String99(READING, 76), 1, 1) = "2" Then
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
        If USER_LICENSEINFO <> "" Then
            pdfY = Mim.Report.Print(0.6, 0.6, USER_LICENSEINFO)
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
        ktrlHier = Mim.Report.Write(PDF_ADDRESS_XPOS, PDF_ADDRESS_YPOS, PDF_ADDRESS_XPOS2, PDF_ADDRESS_YPOS2, adresString)
    End Sub

    Sub pdfPrintUserDef(ByRef TypeEnTaal As String, ByRef pdfOVSStrook As Double)
        Dim pfcmd As Short
        Dim FlFree As Short
        Dim pdfCmd As String
        If Dir(LOCATION_COMPANYDATA & "pdfDDEF" & TypeEnTaal & ".Txt") = "" Then
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
            FileOpen(FlFree, LOCATION_COMPANYDATA & "pdfDDEF" & TypeEnTaal & ".Txt", OpenMode.Input)
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
            GRIDTEXT = VerkoopDetail.Text
            If Mid(GRIDTEXT, Len(GRIDTEXT)) = "2" Then
                pdfY = Mim.Report.Print(1.7, pdfY, Mid(GRIDTEXT, 1, 75))
                GoTo pdfKontroleLijn
            Else
                pdfFilterVelden()
            End If
            'TODO controle gridtext RIGHT!!!achteraan
            If Mid(GRIDTEXT, Len(GRIDTEXT)) = "0" Then
                If Mid(String99(READING, 74), 1, 1) = "2" Then
                    If MeerLijn = 1 Then
                        strMeerLijn = Space(Len(rft(2))) & " "
                    End If
                ElseIf Mid(String99(READING, 75), 1, 1) = "2" Then
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
            If Mid(String99(READING, 76), 1, 1) = "2" Then
                strMeerLijn = strMeerLijn & "    "
            Else
                strMeerLijn = strMeerLijn & Dec(dVeldInfo(5), "##0") & " "
            End If
            BtwTekst = "    "
            Mid(BtwTekst, 1, 1) = Mid(fmarBoxText("002", "2", VeldInfo(9)), 4, 4)
            If InStr(BtnSwitchMoney.Text, "EUR") Then
                strMeerLijn = strMeerLijn & BtwTekst & " " & Dec(dVeldInfo(7) / dMuntK, "########0.00") & vbCrLf
            ElseIf dMuntK <> 1 Then
                strMeerLijn = strMeerLijn & BtwTekst & " " & Dec(dVeldInfo(7) / dMuntK, "########0.00") & vbCrLf
            Else
                strMeerLijn = strMeerLijn & BtwTekst & " " & Dec(Val(Format(dVeldInfo(7) / dMuntK, "#")), "########0.00") & vbCrLf
            End If
            pdfY = Mim.Report.Print(1.7, pdfY, strMeerLijn)

pdfKontroleLijn:
            If pdfY >= PDF_VSOFT_TO - 2.3 - pdfOVSStrook Then
                pdfOnderKant()
                pdfVoetTekst()
                MsgBox("stop voor nieuwe pdf pagina nog te verbeteren")
                pdfKopBALK()
            End If
        Next
    End Sub

    Sub pdfOnderKant()
        pdfY = Mim.Report.Print(1.5, PDF_VSOFT_TO - 2.3 - pdfOVSStrook, vbCrLf)
        Mim.Report.SelectFont("Courier New", 10)
        sy = "####0.00"
        sy2 = MASK_EUR
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
        If CbMedekontraktant.CheckState Then
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
        VeldInfo(1) = Mid(GRIDTEXT, 1, 40)
        GRIDTEXT = Mid(GRIDTEXT, 42)
        dVeldInfo(4) = Val(Mid(GRIDTEXT, 1, 11))
        GRIDTEXT = Mid(GRIDTEXT, 13)
        dVeldInfo(6) = Val(Mid(GRIDTEXT, 1, 7))
        GRIDTEXT = Mid(GRIDTEXT, 9)
        dVeldInfo(7) = Val(Mid(GRIDTEXT, 1, 12))
        GRIDTEXT = Mid(GRIDTEXT, 14)
        dVeldInfo(2) = Val(Mid(GRIDTEXT, 1, 6))
        GRIDTEXT = Mid(GRIDTEXT, 8)
        VeldInfo(8) = Mid(GRIDTEXT, 1, 1)
        GRIDTEXT = Mid(GRIDTEXT, 3)
        dVeldInfo(5) = Val(Mid(GRIDTEXT, 1, 3))
        GRIDTEXT = Mid(GRIDTEXT, 5)
        VeldInfo(9) = Mid(GRIDTEXT, 1, 1)
        GRIDTEXT = Mid(GRIDTEXT, 3)
        If VeldInfo(9) = "6" Then
            VeldInfo(9) = "0"
        End If
        dVeldInfo(3) = Val(Mid(GRIDTEXT, 1, 7))
        GRIDTEXT = Mid(GRIDTEXT, 9)
        VeldInfo(0) = Mid(GRIDTEXT, 1, 13)
    End Sub

    Sub pdfOverschrijvingsstrook()
        On Error GoTo 0
        If Dir(LOCATION_COMPANYDATA & ovsDefinitie) = "" Then
            MsgBox(LOCATION_COMPANYDATA & ovsDefinitie & " niet te vinden !  Hierna wordt kladblok opgestart.  Breng uw eigen gegevens in a.u.b. !", 0, "Foutieve Installatie ?")
            On Error Resume Next
            X = Shell("notepad.exe " & LOCATION_COMPANYDATA & ovsDefinitie, 1)
            Exit Sub
        Else
            FlTemp = FreeFile()
            FileOpen(FlTemp, LOCATION_COMPANYDATA & ovsDefinitie, OpenMode.Input)
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

    Private Sub BtnFromStock_Click(sender As Object, e As EventArgs) Handles BtnFromStock.Click

        If VerkoopDetail.Enabled Then
            EditDetailModus = False
            VerkoopDetail.Focus()
            SendKeys.Send("{S}")
        Else
            MessageBox.Show("Eerst klant kiezen a.u.b !!!")
        End If

    End Sub

    Private Sub BtnFromDescription_Click(sender As Object, e As EventArgs) Handles BtnFromDescription.Click

        If VerkoopDetail.Enabled Then
            EditDetailModus = False
            VerkoopDetail.Focus()
            SendKeys.Send("{O}")
        Else
            MessageBox.Show("Eerst klant kiezen a.u.b !!!")
        End If

    End Sub

    Private Sub BtnPutTextLine_Click(sender As Object, e As EventArgs) Handles BtnPutTextLine.Click

        If VerkoopDetail.Enabled Then
            EditDetailModus = False
            VerkoopDetail.Focus()
            SendKeys.Send("{T}")
        Else
            MessageBox.Show("Eerst klant kiezen a.u.b !!!")
        End If

    End Sub

    Private Sub BtnSwitchMoney_Click(sender As Object, e As EventArgs) Handles BtnSwitchMoney.Click

        '    Dim TempoTel As Integer
        '    Dim TempoVar As Variant
        '    Dim MaskerEURBHmini As String

        '    DirecteVerkoopString = cmdSwitch.Caption
        '    MaskerEURBHmini = Mid(MaskerEURBH, 2)
        '    If sMuntKlant = "BEF" Or sMuntKlant = "EUR" Then
        '        '    If VerkoopDetail.ListCount Then
        '        '        If cmdSwitch.Caption = "Ingave in BEF" Then
        '        '            Msg = "Switch van BEF naar EUR.  Bij het later terugzetten naar BEF, bestaat de mogelijkheid van afrondingsverschillen indien meerdere lijnen in   nzelfde dokument aanwezig met oorspronkelijke cijfers in BEF na de komma.  De terugrekening vanuit de EURO naar BEF geeft in dat geval kans op afrondingsverschillen." & vbCr & vbCr & "Omrekening laten doorgaan ?"
        '        '            KtrlBox = MsgBox(Msg, vbExclamation + vbYesNo + vbDefaultButton2)
        '        '            If KtrlBox = vbNo Then Exit Sub
        '        '        End If
        '        '    End If
        '    Else
        '        MsgBox "Switch niet mogelijk voor klanten buiten de E.U.   n enkel mogelijk indien klant met BEF of EUR code", vbInformation
        'Exit Sub
        '    End If

        '    If cmdSwitch.Caption = "Ingave in EUR" Then
        '        'Stap 1: overschakeling cijfers van EUR naar BEF
        '        On Local Error Resume Next
        '        For TelTot = 1 To 3
        '            lblBTWBedrag(TelTot).Caption = Format(Round(CDbl(lblBTWBedrag(TelTot).Caption) * EURO, 0), "#,##0.00")
        '        Next
        '        cmdSwitch.Caption = "Ingave in BEF"
        '        sMuntKlant = "BEF"
        '        For TelTot = 0 To VerkoopDetail.ListCount - 1
        '            TempoVar = VerkoopDetail.List(TelTot)
        '            If Right(TempoVar, 1) = "2" Then
        '            Else
        '                Mid(TempoVar, 42, 11) = Dec(Val(Mid(TempoVar, 42, 11)) * EURO, MaskerEURBHmini)
        '                Mid(TempoVar, 62, 12) = Dec(Val(Mid(TempoVar, 62, 12)) * EURO, MaskerEURBH)
        '                VerkoopDetail.List(TelTot) = TempoVar
        '            End If
        '        Next
        '    Else
        '        'overschakeling cijfers van BEF naar EUR
        '        For TelTot = 1 To 3
        '            lblBTWBedrag(TelTot).Caption = Format(Round(CDbl(lblBTWBedrag(TelTot).Caption) / EURO, 2), "#,##0.00")
        '        Next
        '        cmdSwitch.Caption = "Ingave in EUR"
        '        sMuntKlant = "EUR"
        '        For TelTot = 0 To VerkoopDetail.ListCount - 1
        '            TempoVar = VerkoopDetail.List(TelTot)
        '            If Right(TempoVar, 1) = "2" Then
        '            Else
        '                Mid(TempoVar, 42, 11) = Dec(Val(Mid(TempoVar, 42, 11)) / EURO, MaskerEURBHmini)
        '                Mid(TempoVar, 62, 12) = Dec(Val(Mid(TempoVar, 62, 12)) / EURO, MaskerEURBH)
        '                VerkoopDetail.List(TelTot) = TempoVar
        '            End If
        '        Next
        '    End If
        '    TekstInfo(5).Text = Dec$(dMuntK, "##0.########")
        '    DirecteVerkoopString = cmdSwitch.Caption
        '    RefreshBTW()

    End Sub
End Class