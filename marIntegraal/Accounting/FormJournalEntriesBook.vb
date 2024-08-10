Option Strict Off
Option Explicit On
Imports IDEALSoftware.VpeStandard

Public Class FormJournalEntriesBook
    Dim Line
    Dim JournalEntriesRS As ADODB.Recordset
    Dim pdfY As Double
    Dim ReportText(5) As String
    Dim TotalDebit As Double
    Dim TotalCredit As Double
    Dim FieldText(17) As String
    Dim TotalLines As Short
    Dim aa As String
    Dim PeriodFromChosen As String = Space(8)
    Dim PeriodToChosen As String = Space(8)
    Dim PdfReportTitle As String

    Private Sub FormJournalEntriesBook_Load()

        TotalDebit = 0
        TotalCredit = 0
        TextBoxPeriodFromTo.Text = FormBYPERDAT.PeriodeBoekjaar.Text
        DateTimePickerProcessingDate.Text = MIM_GLOBAL_DATE
        PeriodFromChosen = Mid(PERIOD_FROMTO, 1, 8)
        PeriodToChosen = Mid(PERIOD_FROMTO, 9)
        CheckRecordSet()

    End Sub

    Private Sub FormJournalEntriesBook_FormClosing(sender As Object, e As FormClosingEventArgs)

        Dim CancelHere As Boolean = e.Cancel
        If Mim.Report.IsOpen = True Then
            MsgBox("Sluit eerst het PDF venster a.u.b.", MsgBoxStyle.Information)
            CancelHere = True
        Else
            Mim.JournalEntriesBookMenuItem.Enabled = True
        End If
        e.Cancel = CancelHere

    End Sub

    Private Sub CheckRecordSet()
        Dim sSQL As String
        sSQL = "SELECT Journalen.v066, Journalen.v019, Rekeningen.v020, Journalen.v067, Journalen.v033, Journalen.dece068, Journalen.v069 FROM Journalen, Rekeningen WHERE  Journalen.v019=Rekeningen.v019 AND Journalen.v033 Like 'D0%' AND Journalen.v066 >= '" & PeriodFromChosen & "' AND Journalen.v066 <= '" & PeriodToChosen & "' ORDER BY Journalen.rvID" 'Journalen.v066"

        ' Create a recordset using the provided collection
        JournalEntriesRS = New ADODB.Recordset With {
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
        }
        JournalEntriesRS.Open(sSQL, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        If JournalEntriesRS.RecordCount <= 0 Then
            ButtonGenerateReport.Enabled = False
            TextBoxRecordLines.Text = "0"
            Exit Sub
        Else
            ButtonGenerateReport.Enabled = True
            TextBoxRecordLines.Text = JournalEntriesRS.RecordCount
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
        pdfY = Mim.Report.Print(1, pdfY, UCase(ReportText(3)) & vbCrLf)
        pdfY = Mim.Report.Print(1, pdfY, FULL_LINE & vbCrLf)
        pdfY = Mim.Report.Print(1, pdfY, PdfReportTitle & vbCrLf)
        pdfY = Mim.Report.Print(1, pdfY, FULL_LINE & vbCrLf & vbCrLf)
    End Sub

    Private Sub InitialiseFields()

        Dim T As Integer
        REPORT_FIELD(0) = "Line"
        REPORT_TAB(0) = 1 'was 2
        REPORT_FIELD(1) = "Datum"
        REPORT_TAB(1) = 6 'was 7
        REPORT_FIELD(2) = "Nummer"
        REPORT_TAB(2) = 17 'was 18
        REPORT_FIELD(3) = "Naam Rekening"
        REPORT_TAB(3) = 25 ' was 26
        REPORT_FIELD(4) = "Betreft"
        REPORT_TAB(4) = 62 'was 63
        REPORT_FIELD(5) = "       Debet"
        REPORT_TAB(5) = 93 ' was 94
        REPORT_FIELD(6) = "      Credit"
        REPORT_TAB(6) = 105 'was 106
        REPORT_FIELD(7) = "T.Rekening"
        REPORT_TAB(7) = 118 ' was 119

        PdfReportTitle = Space(128)
        For T = 0 To 7
            Mid(PdfReportTitle, REPORT_TAB(T)) = REPORT_FIELD(T)
        Next

    End Sub

    Private Sub VpePrintLine()

        Dim PdfLine As String = Space(128)
        Dim DCAmount As Double

        Line += 1
        mid(PdfLine, REPORT_TAB(0)) = Format(Line, "0000") 'lijn
        Mid(PdfLine, REPORT_TAB(1)) = FunctionDateText(ObjectValue((JournalEntriesRS.Fields("v066").Value))) 'datum
        Mid(PdfLine, REPORT_TAB(2)) = JournalEntriesRS.Fields("v019").Value 'nummer
        Mid(PdfLine, REPORT_TAB(3)) = Mid(JournalEntriesRS.Fields("v020").Value, 1, 36) 'naam rekening
        Mid(PdfLine, REPORT_TAB(4)) = JournalEntriesRS.Fields("v067").Value 'betreft

        DCAmount = ObjectValue((JournalEntriesRS.Fields("dece068").Value))
        Select Case DCAmount
            Case Is < 0
                TotalCredit += DCAmount
                Mid(PdfLine, REPORT_TAB(6)) = Dec(System.Math.Abs(DCAmount), MASK_EURBH) 'bedrag credit
            Case Else
                TotalDebit += DCAmount
                mid(PdfLine, REPORT_TAB(5)) = Dec(DCAmount, MASK_EURBH) 'bedrag debet
        End Select
        Mid(PdfLine, REPORT_TAB(7)) = JournalEntriesRS.Fields("v069").Value 'tegenrekening
        pdfY = Mim.Report.Print(1, pdfY, PdfLine & vbCrLf)
        If pdfY > 27.5 Then
            Mim.Report.PageBreak()
            VpePrintHeader()
        End If

    End Sub

    Private Sub PrintTotal()
        Dim PdfLine As String = Space(128)
        mid(PdfLine, REPORT_TAB(4)) = "Periodiek totaal :"
        mid(PdfLine, REPORT_TAB(5)) = Dec(Math.Abs(TotalDebit), MASK_EURBH)
        mid(PdfLine, REPORT_TAB(6)) = Dec(Math.Abs(TotalCredit), MASK_EURBH)
        pdfY = Mim.Report.Print(1, pdfY, vbCrLf & FULL_LINE & vbCrLf & PdfLine)
    End Sub

    Private Sub TextBoxPeriodFromTo_Leave()
        If DateWrongFormat(Mid(TextBoxPeriodFromTo.Text, 14, 10)) Then
            MsgBox("Respecteer : " & vbCrLf & vbCrLf & "DD/MM/EEJJ - DD/MM/EEJJ a.u.b. !", MsgBoxStyle.Information)
            TextBoxPeriodFromTo.Text = FormBYPERDAT.PeriodeBoekjaar.Text
            ButtonGenerateReport.Enabled = False
            TextBoxRecordLines.Text = "0"
            Exit Sub
        ElseIf Len(TextBoxPeriodFromTo.Text) <> 23 Then
            MsgBox("Respecteer : " & vbCrLf & vbCrLf & "DD/MM/EEJJ - DD/MM/EEJJ a.u.b. !", MsgBoxStyle.Information)
            TextBoxPeriodFromTo.Text = FormBYPERDAT.PeriodeBoekjaar.Text
            ButtonGenerateReport.Enabled = False
            TextBoxRecordLines.Text = "0"
            Exit Sub
        Else
            PeriodFromChosen = Mid(TextBoxPeriodFromTo.Text, 7, 4) & Mid(TextBoxPeriodFromTo.Text, 4, 2) & Mid(TextBoxPeriodFromTo.Text, 1, 2)
            PeriodToChosen = Mid(TextBoxPeriodFromTo.Text, 20, 4) & Mid(TextBoxPeriodFromTo.Text, 17, 2) & Mid(TextBoxPeriodFromTo.Text, 14, 2)
            CheckRecordSet()
        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub ButtonGenerateReport_Click()

        With Mim.Report
            .CloseDoc()
            .OpenDoc()
            .Author = "marIntegraal"
            .GUILanguage = 3 'Nederlands
            .Title = "Diverse Postenboek"
        End With
        ReportText(2) = "Diverse Postenboek " & Mid(Mim.Text, InStr(Mim.Text, "["))
        ReportText(0) = Format(DateTimePickerProcessingDate.Value, "dd/MM/yyyy")
        ReportText(3) = TextBoxPeriodFromTo.Text
        InitialiseFields()
        VpePrintHeader()
        Line = 0
        JournalEntriesRS.MoveFirst()
        Do While Not JournalEntriesRS.EOF
            VpePrintLine()
            JournalEntriesRS.MoveNext()
        Loop
        PrintTotal()
        With Mim.Report
            .WriteDoc(LOCATION_COMPANYDATA & Format(Now, "YYYYMMDDHHMMSS") & "-diverseposten.pdf")
            .MailSubject = "Diverse Posten bedrijfx"
            .MailText = "diverseposten bedrijf ix in bijlage."
        End With

        Mim.Report.AddMailReceiver(TextBoxMailToOption.Text, RecipientClass.To)
        Mim.Report.Preview()
        'Mim.Report.CloseDoc()
        Focus()

    End Sub

End Class