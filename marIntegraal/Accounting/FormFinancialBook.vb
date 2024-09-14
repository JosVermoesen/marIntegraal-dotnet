Option Strict Off
Option Explicit On

Public Class FormFinancialBook

    Dim pdfY As Double
    Dim ReportText(5) As String
    Dim TotalDebit As Decimal
    Dim TotalCredit As Decimal
    Dim PdfReportTitle As String

    Dim FieldText(17) As String

    Dim RecNummer(9) As Short
    Dim MaskHere As String

    Dim RekeningNummer(9) As String

    Dim PeriodFromToChosenInitial As String

    Dim PeriodFromChosen As String
    Dim PeriodToChosen As String

    Dim rsFinancial As ADODB.Recordset
    Dim rsFinancialDayDetail As ADODB.Recordset

    Private Sub FormFinancialBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Text = "Financieel Boeken " & Mid(Mim.Text, InStr(Mim.Text, "["))

        If BH_EURO Then
            MaskHere = "#####0.00"
        Else
            MaskHere = "########0"
        End If
        AD_NTDB.Execute("DELETE * FROM TmpBestand")

        PeriodFromChosen = Mid(BOOKYEAR_FROMTO, 1, 8)
        PeriodToChosen = Mid(BOOKYEAR_FROMTO, 9, 8)
        PeriodFromToChosenInitial = FunctionDateText(PeriodFromChosen) & " - " & FunctionDateText(PeriodToChosen)
        TbFromTo.Text = PeriodFromToChosenInitial

        RecNummer(0) = 31
        RekeningNummer(0) = String99(READING, 41)

        RecNummer(1) = 32
        RekeningNummer(1) = String99(READING, 42)

        RecNummer(2) = 33
        RekeningNummer(2) = String99(READING, 43)

        RecNummer(3) = 34
        RekeningNummer(3) = String99(READING, 44)

        RecNummer(4) = 35
        RekeningNummer(4) = String99(READING, 45)

        RecNummer(5) = 38
        RekeningNummer(5) = String99(READING, 39)

        RecNummer(6) = 215
        RekeningNummer(6) = String99(READING, 211)

        RecNummer(7) = 216
        RekeningNummer(7) = String99(READING, 212)

        RecNummer(8) = 217
        RekeningNummer(8) = String99(READING, 213)

        RecNummer(9) = 218
        RekeningNummer(9) = String99(READING, 214)

        InitialiseChooseList()

    End Sub

    Private Sub InitialiseChooseList()

        AD_NTDB.Execute("DELETE * FROM TmpBestand")

        CbBankList.Items.Clear()
        JetTableClose(TABLE_JOURNAL)
        For T = 0 To 9
            If RekeningNummer(T) = "" Then
            Else
                If GetRSFinancialBook(SetSpacing(RekeningNummer(T), 7), PeriodFromChosen, PeriodToChosen) Then
                    JetGet(TABLE_LEDGERACCOUNTS, 0, RekeningNummer(T))
                    If KTRL Then
                        A = RekeningNummer(T) & Chr(124) & "Niet aanwezig. Setup Boekjaar!"
                    Else
                        RecordToField(TABLE_LEDGERACCOUNTS)
                        A = RekeningNummer(T) & Chr(124) & RTrim(AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #"))
                    End If
                    CbBankList.Items.Add(A)
                End If
            End If

        Next
        If CbBankList.Items.Count Then CbBankList.SelectedIndex = 0

    End Sub

    Private Function GetRSFinancialBook(accountNumber As String, keyFrom As String, keyTo As String) As Boolean

        GetRSFinancialBook = False

        Dim sSQL As String
        sSQL = "SELECT * FROM Journalen WHERE v070 >='" & accountNumber & keyFrom & "' AND v070 <= '" & accountNumber & keyTo & "' ORDER BY v070"

        ' Create a recordset using the provided collection
        rsFinancial = New ADODB.Recordset With {
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
        }
        rsFinancial.Open(sSQL, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        If rsFinancial.RecordCount <= 0 Then
            'Message something
        Else
            GetRSFinancialBook = True
        End If

    End Function

    Private Function GetRSForDayDetailReport(accountStatement As String) As Boolean

        GetRSForDayDetailReport = False

        Dim sSQL As String = "SELECT Journalen.v066, Journalen.v019, Rekeningen.v020, Journalen.v068, Journalen.v067, Journalen.v033, Journalen.v069 FROM Journalen, Rekeningen WHERE Journalen.v038 ='" & accountStatement & "' AND Journalen.v019 = Rekeningen.v019 ORDER BY Journalen.rvID"

        ' Create a recordset using the provided collection
        rsFinancialDayDetail = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenForwardOnly,
            .LockType = ADODB.LockTypeEnum.adLockReadOnly,
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
        }
        rsFinancialDayDetail.Open(sSQL, AD_NTDB)
        If Err.Number Then
            MsgBox("SQLQuery: " & sSQL & vbCrLf & vbCrLf & "Bron:" & vbCrLf & Err.Source & vbCrLf & vbCrLf & "Foutnummer: " & Err.Number & vbCrLf & vbCrLf & "Detail:" & vbCrLf & Err.Description)
        End If

        If rsFinancialDayDetail.RecordCount > 0 Then
            GetRSForDayDetailReport = True
        End If

    End Function

    Private Function GetRSForInfoDayDetail(accountStatement As String) As Boolean

        GetRSForInfoDayDetail = False

        Dim sSQL As String = "SELECT Journalen.v066 AS [Datum], Journalen.v019 AS [Rekening], Rekeningen.v020 AS [Naam], Journalen.v068 AS [Bedrag], Journalen.v067 AS [Boekomschrijving], Journalen.v033 AS [AV-Document], Journalen.v069 AS [Tegenrekening] FROM Journalen, Rekeningen WHERE Journalen.v038 ='" & accountStatement & "' AND Journalen.v019 = Rekeningen.v019 ORDER BY Journalen.rvID"

        ' Create a recordset using the provided collection
        rsFinancialDayDetail = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenForwardOnly,
            .LockType = ADODB.LockTypeEnum.adLockReadOnly,
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
        }
        rsFinancialDayDetail.Open(sSQL, AD_NTDB)
        If Err.Number Then
            MsgBox("SQLQuery: " & sSQL & vbCrLf & vbCrLf & "Bron:" & vbCrLf & Err.Source & vbCrLf & vbCrLf & "Foutnummer: " & Err.Number & vbCrLf & vbCrLf & "Detail:" & vbCrLf & Err.Description)
        End If

        If rsFinancialDayDetail.RecordCount > 0 Then
            GetRSForInfoDayDetail = True
        End If

    End Function

    Sub DetailForInfoForm(statementString As String)

        Dim ktrl = GetRSForInfoDayDetail(statementString)
        If Not ktrl Then
            MsgBox("Geen data gevonden voor " & statementString)
            Exit Sub
        End If

        FormInfoDetail.Close()
        FormInfoDetail.Text = "Journaaldetail voor uittreksel: " + statementString

        Dim dt As DataTable = rsFinancialDayDetail.ADODBRSetToDataTable() ' Convert ADODB recordset to DataTable
        Dim view As New DataView(dt) ' Create a DataView from the DataTable
        ' Now we can work with the data using the 'view' variable.
        FormInfoDetail.DgvSQL.DataSource = view
        FormInfoDetail.Width = 694
        FormInfoDetail.ShowDialog()

    End Sub

    Private Sub InitialiseFields()

        Dim T As Integer
        REPORT_FIELD(0) = "Datum"
        REPORT_TAB(0) = 2
        REPORT_FIELD(1) = "Rek.Nm."
        REPORT_TAB(1) = 13
        REPORT_FIELD(2) = "Naam/Omschrijving"
        REPORT_TAB(2) = 21
        REPORT_FIELD(3) = "Betreft"
        REPORT_TAB(3) = 62
        REPORT_FIELD(4) = "       Debet"
        REPORT_TAB(4) = 93
        REPORT_FIELD(5) = "      Credit"
        REPORT_TAB(5) = 105
        REPORT_FIELD(6) = "Document"
        REPORT_TAB(6) = 118
        REPORT_TAB(7) = 0
        PdfReportTitle = Space(128)
        For T = 0 To 6

            Mid(PdfReportTitle, REPORT_TAB(T)) = REPORT_FIELD(T)
        Next

    End Sub

    Private Sub CumulUpdate(account As String, amount As Double)

TryAgain:
        JetGet(TABLE_DUMMY, 0, account)
        If KTRL Then
            TLB_RECORD(TABLE_DUMMY) = ""
            AdoInsertToRecord(TABLE_DUMMY, account, "v089")
            AdoInsertToRecord(TABLE_DUMMY, "0", "v013")
            AdoInsertToRecord(TABLE_DUMMY, "0", "v068")
            JetInsert(TABLE_DUMMY, 0)
            GoTo TryAgain
        Else
            RecordToField(TABLE_DUMMY)
            AdoInsertToRecord(TABLE_DUMMY, Str(Val(AdoGetField(TABLE_DUMMY, "#v013 #")) + 1), "v013")
            AdoInsertToRecord(TABLE_DUMMY, Str(Val(AdoGetField(TABLE_DUMMY, "#v068 #")) + amount), "v068")
            JetUpdate(TABLE_DUMMY, 0)
        End If

    End Sub

    Private Sub VpePrintHeader()

        With Mim.Report
            .SelectFont("Courier New", 7.2)
            .TextBold = True
            .TextColor = ColorTranslator.FromOle(0) 'zwart

            .nTopMargin = 1
            .nBottomMargin = 29
            .nLeftMargin = 0.5
            .nRightMargin = 0.5
            .PenSize = 0.01
        End With

        PAGE_COUNTER += 1
        pdfY = Mim.Report.Print(1, 1, ReportText(2))
        pdfY = Mim.Report.Print(17, 1, "Pagina : " & Dec(PAGE_COUNTER, "##########") & vbCrLf)
        pdfY = Mim.Report.Print(17, pdfY, "Datum  : " & ReportText(0) & vbCrLf & vbCrLf)
        pdfY = Mim.Report.Print(1, pdfY, ReportText(3) & vbCrLf)
        pdfY = Mim.Report.Print(1, pdfY, FULL_LINE & vbCrLf)
        pdfY = Mim.Report.Print(1, pdfY, PdfReportTitle & vbCrLf)
        pdfY = Mim.Report.Print(1, pdfY, FULL_LINE & vbCrLf & vbCrLf)

    End Sub

    Private Sub CumulPrint()

        Mim.Report.PageBreak()
        VpePrintHeader()
        PrintEndTotal()

        Dim Tabul As Integer = 56
        Dim PdfDetailLine As String = Space(128)

        pdfY = Mim.Report.Print(1, pdfY, vbCrLf)
        pdfY = Mim.Report.Print(2, pdfY, "** CENTRALISATIE **" & vbCrLf)


        Dim aantalKeer As Integer = 0
        Dim rekeningNummer As String = ""
        Dim rekeningNaam As String = ""
        Dim bedrag As Double = 0
        Dim Ktrl44 As Boolean = False

        JetTableClose(TABLE_DUMMY)
        JetGetFirst(TABLE_DUMMY, 0)
        RecordToField(TABLE_DUMMY)
        rekeningNummer = SetSpacing(AdoGetField(TABLE_DUMMY, "#v089 #"), 7)
        JetGet(TABLE_LEDGERACCOUNTS, 0, rekeningNummer)
        If KTRL Then
            rekeningNaam = SetSpacing("Rekening reeds vernietigd !!!", 30)
        Else
            RecordToField(TABLE_LEDGERACCOUNTS)
            rekeningNummer = SetSpacing(RS_MAR(TABLE_LEDGERACCOUNTS).Fields("v019").Value, 7)
            rekeningNaam = SetSpacing(RS_MAR(TABLE_LEDGERACCOUNTS).Fields("v020").Value, 30)
        End If
        aantalKeer = Val(AdoGetField(TABLE_DUMMY, "#v013 #"))
        bedrag = Val(AdoGetField(TABLE_DUMMY, "#v068 #"))

        Tabul = 0
        Mid(PdfDetailLine, Tabul + 2) = Dec(aantalKeer, "####") & " x " & rekeningNummer & " " & rekeningNaam & " " & Dec(bedrag, MaskHere)

        Do
            JetNext(TABLE_DUMMY, 0, rekeningNummer)
            If KTRL Then
                Exit Do
            End If
            RecordToField(TABLE_DUMMY)
            rekeningNummer = SetSpacing(AdoGetField(TABLE_DUMMY, "#v089 #"), 7)
            JetGet(TABLE_LEDGERACCOUNTS, 0, rekeningNummer)
            If KTRL Then
                rekeningNaam = SetSpacing("Rekening reeds vernietigd !!!", 30)
            Else
                RecordToField(TABLE_LEDGERACCOUNTS)
                rekeningNummer = SetSpacing(RS_MAR(TABLE_LEDGERACCOUNTS).Fields("v019").Value, 7)
                rekeningNaam = SetSpacing(RS_MAR(TABLE_LEDGERACCOUNTS).Fields("v020").Value, 30)
            End If
            aantalKeer = Val(AdoGetField(TABLE_DUMMY, "#v013 #"))
            bedrag = Val(AdoGetField(TABLE_DUMMY, "#v068 #"))

            If Tabul = 0 Then
                Tabul = 56
                Mid(PdfDetailLine, Tabul + 2) = Dec(aantalKeer, "####") & " x " & rekeningNummer & " " & rekeningNaam & " " & Dec(bedrag, MaskHere)
                pdfY = Mim.Report.Print(1, pdfY, PdfDetailLine & vbCrLf)
                If pdfY > 27.5 Then
                    Mim.Report.PageBreak()
                    VpePrintHeader()
                End If
                PdfDetailLine = Space(128)
            Else
                Tabul = 0
                Mid(PdfDetailLine, Tabul + 2) = Dec(aantalKeer, "####") & " x " & rekeningNummer & " " & rekeningNaam & " " & Dec(bedrag, MaskHere)
            End If
        Loop

        If Tabul = 0 Then
            pdfY = Mim.Report.Print(1, pdfY, PdfDetailLine & vbCrLf & vbCrLf)
        Else
            pdfY = Mim.Report.Print(1, pdfY, vbCrLf)
        End If

    End Sub

    Private Sub PrintEndTotal()
        Dim PdfLine As String = Space(128)
        Dim T = 0

        For T = 0 To 6
            FieldText(T) = ""
        Next
        FieldText(3) = "Periodiek totaal :"
        FieldText(4) = Dec(Math.Abs(TotalDebit), MASK_EURBH)
        FieldText(5) = Dec(Math.Abs(TotalCredit), MASK_EURBH)
        Mid(PdfLine, REPORT_TAB(3)) = FieldText(3)
        Mid(PdfLine, REPORT_TAB(4)) = FieldText(4)
        Mid(PdfLine, REPORT_TAB(5)) = FieldText(5)
        pdfY = Mim.Report.Print(1, pdfY, PdfLine & vbCrLf)

    End Sub

    Private Sub VpePrintLine()

        Dim PdfLine As String = Space(128)
        Dim T = 0

        For T = 0 To 6
            Mid(PdfLine, REPORT_TAB(T)) = FieldText(T)
        Next

        pdfY = Mim.Report.Print(1, pdfY, PdfLine & vbCrLf)
        If pdfY > 27.5 Then
            Mim.Report.PageBreak()
            VpePrintHeader()
        End If

    End Sub

    Private Sub UittrekselsLijst_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles LbStatementsList.DoubleClick

        DetailForInfoForm(Mid(LbStatementsList.Text, 1, 8))

    End Sub

    Private Sub CbFinancialChoosen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbBankList.SelectedIndexChanged

        Dim DummyText As String
        Dim DCBedrag As Double

        If GetRSFinancialBook(Mid(CbBankList.Text, 1, 7), PeriodFromChosen, PeriodToChosen) Then
            Cursor.Current = Cursors.WaitCursor
            LbStatementsList.Visible = False
            LbStatementsList.Items.Clear()

            rsFinancial.MoveFirst()
            Do While Not rsFinancial.EOF

                DummyText = rsFinancial.Fields("v038").Value + " " + Chr(124) + " "
                DummyText = DummyText & FunctionDateText(rsFinancial.Fields("v066").Value.ToString) & " " & Chr(124) & " "
                DummyText = DummyText & SetSpacing(rsFinancial.Fields("v067").Value.ToString, 30) & " " & Chr(124) & " "

                DCBedrag = Val(rsFinancial.Fields("v068").Value)
                Select Case DCBedrag
                    Case Is < 0
                        DummyText = DummyText & Dec(0, MASK_EURBH) & Chr(124) & Dec(Math.Abs(DCBedrag), MASK_EURBH)
                    Case Else
                        DummyText = DummyText & Dec(System.Math.Abs(DCBedrag), MASK_EURBH) & Chr(124) & Dec(0, MASK_EURBH)
                End Select
                LbStatementsList.Items.Add(DummyText)
                rsFinancial.MoveNext()
            Loop
            If LbStatementsList.Items.Count Then LbStatementsList.SelectedIndex = 0
            LbStatementsList.Visible = True

            Cursor.Current = Cursors.Default
            On Error Resume Next
            LbStatementsList.Select()
        End If

    End Sub

    Private Sub LbUittrekselsLijst_KeyDown(sender As Object, e As KeyEventArgs) Handles LbStatementsList.KeyDown

        Dim KeyCode = e.KeyCode
        If KeyCode = 13 Then DetailForInfoForm(Mid(LbStatementsList.Text, 1, 8))

    End Sub

    Private Sub TbTekstLijn_Leave(sender As Object, e As EventArgs) Handles TbFromTo.Leave

        '		Dim Index As Short = TekstLijn.GetIndex(eventSender)
        '		Dim T As Short
        '		Dim A As String

        If Len(TbFromTo.Text) <> 23 Then
            MsgBox("Respecteer : " & vbCrLf & vbCrLf & "DD/MM/EEJJ - DD/MM/EEJJ a.u.b. !")
            TbFromTo.Text = PeriodFromToChosenInitial
            TbFromTo.Focus()
        Else
            PeriodFromChosen = Mid(TbFromTo.Text, 7, 4) & Mid(TbFromTo.Text, 4, 2) & Mid(TbFromTo.Text, 1, 2)
            PeriodToChosen = Mid(TbFromTo.Text, 20, 4) & Mid(TbFromTo.Text, 17, 2) & Mid(TbFromTo.Text, 14, 2)
            InitialiseChooseList()
        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)

        Close()

    End Sub

    Private Sub FormFinancialBook_FormClosing(sender As Object, e As FormClosingEventArgs)

        Dim CancelHere As Boolean = e.Cancel
        If Mim.Report.IsOpen = True Then
            MsgBox("Sluit eerst het VPE venster a.u.b.", MsgBoxStyle.Information)
            CancelHere = True
        Else
            Mim.FinancialJournalMenuItem.Enabled = True
        End If
        e.Cancel = CancelHere

    End Sub

    Private Sub BtnGenerateReport_Click(sender As Object, e As EventArgs)

        Dim DCBedrag As Decimal
        Dim HetBedrag As Decimal

        Dim FinRekening As String = SetSpacing("", 7)
        Dim DeRekening As String = SetSpacing("", 7)

        ReportText(2) = "Financiëel Boek " & Mid(Mim.Text, InStr(Mim.Text, "["))
        ReportText(0) = Format(DateTimePickerProcessingDate.Value, "dd/MM/yyyy")
        ReportText(3) = CbBankList.Text & " " & TbFromTo.Text

        With Mim.Report
            .CloseDoc()
            .OpenDoc()
            .Author = "marIntegraal"
            .GUILanguage = 3 'Nederlands
            .Title = "Financiëel boek" + ReportText(3)
        End With

        TotalDebit = 0
        TotalCredit = 0
        PAGE_COUNTER = 0

        If LbStatementsList.Items.Count = 0 Then
            Exit Sub
        Else
            Cursor.Current = Cursors.WaitCursor
            InitialiseFields()
            VpePrintHeader()

            Dim AA As String = ""

            For T = 0 To LbStatementsList.Items.Count - 1

                'skip first record dayTotal
                AA = LbStatementsList.Items(T).ToString

                GetRSForDayDetailReport(Mid(AA, 1, 8))
                rsFinancialDayDetail.MoveFirst()
                FieldText(0) = Mid(AA, 12, 10)
                FieldText(1) = Mid(CbBankList.Text, 1, 7)
                FieldText(2) = Mid(AA, 25, 30)
                FieldText(3) = "DS/CS Saldo van het uittreksel"
                FieldText(4) = Mid(AA, 58, 12)
                FieldText(5) = Mid(AA, 71, 12)
                FieldText(6) = Mid(AA, 1, 8)
                DeRekening = FieldText(1)
                HetBedrag = -Val(FieldText(5)) + Val(FieldText(4))
                Select Case HetBedrag
                    Case Is < 0
                        TotalCredit += HetBedrag
                    Case Else
                        TotalDebit += HetBedrag
                End Select
                CumulUpdate(DeRekening, HetBedrag)
                VpePrintLine()

                rsFinancialDayDetail.MoveNext()
                Do While Not rsFinancialDayDetail.EOF
                    FieldText(0) = FunctionDateText(rsFinancialDayDetail.Fields("v066").Value.ToString)
                    FieldText(1) = rsFinancialDayDetail.Fields("v019").Value

                    FieldText(2) = rsFinancialDayDetail.Fields("v020").Value
                    FieldText(3) = rsFinancialDayDetail.Fields("v067").Value
                    DCBedrag = Val(rsFinancialDayDetail.Fields("v068").Value)
                    Select Case DCBedrag
                        Case Is < 0
                            TotalCredit += DCBedrag
                            FieldText(4) = ""
                            FieldText(5) = Dec(Math.Abs(DCBedrag), MASK_EURBH)
                        Case Else
                            TotalDebit += DCBedrag
                            FieldText(4) = Dec(DCBedrag, MASK_EURBH)
                            FieldText(5) = ""
                    End Select
                    FieldText(6) = rsFinancialDayDetail.Fields("v033").Value.ToString
                    DeRekening = FieldText(1)
                    HetBedrag = DCBedrag
                    CumulUpdate(DeRekening, HetBedrag)
                    VpePrintLine()
                    rsFinancialDayDetail.MoveNext()
                Loop
                pdfY = Mim.Report.Print(1, pdfY, vbCrLf)
            Next
            PrintEndTotal()
            CumulPrint()

            Cursor.Current = Cursors.Default
            Mim.Report.Preview()
        End If
        Focus()

    End Sub

    Private Sub BtnManualSearch_Click(sender As Object, e As EventArgs)

        Dim KtrlInput As String

        KtrlInput = InputBox("Geef nummer van het financieel stuk (8 tekens !)", "Financieel journaal kontrole ")
        If KtrlInput = "" Then
            Exit Sub
        ElseIf Len(KtrlInput) <> 8 Then
            MSG = "Documentnummer moet uit 8 tekens bestaan!" & vbCrLf & vbCrLf
            MSG = MSG & "Voorbeeld:" & vbCrLf
            MSG = MSG & "Rekening 'GB', werkelijk jaar 19'98'," & vbCrLf
            MSG = MSG & "uittreksel 124, geeft als dokumentnummer:" & vbCrLf & vbCrLf
            MSG &= "GB980124"
            MsgBox(MSG, MsgBoxStyle.Critical)
            Exit Sub
        End If
        DetailForInfoForm(KtrlInput)

    End Sub

End Class

