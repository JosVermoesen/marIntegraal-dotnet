Option Strict Off
Option Explicit On

Imports IDEALSoftware.VpeStandard

Public Class FormLedgerAccountHistory

    Dim Line As Integer
    Dim JournalEntriesRS As ADODB.Recordset
    Dim pdfY As Double
    Dim ReportText(5) As String
    Dim FieldText(20) As String
    Dim SelectionFromTo As String = Space(8)

    Dim LNumberL(20) As Short

    Dim SubTotalD As Double
    Dim SubTotalC As Double
    Dim MonthTotalD As Double
    Dim MonthTotalC As Double
    Dim EndTotalD As Double
    Dim EndTotalC As Double

    Dim PdfReportTitle As String
    Dim LastLedgerAccount As String
    Dim CheckForMonth As String

    Private Sub FormLedgerAccountHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MonthTotalD = 0
        MonthTotalC = 0

        SubTotalD = 0
        SubTotalC = 0

        EndTotalD = 0
        EndTotalC = 0

        SelectionFromTo = BOOKYEAR_FROMTO
        TextBoxProcessingDate.Text = MIM_GLOBAL_DATE

        TextBoxLedgerAccountFrom.Text = CStr(1)
        bNext(TABLE_LEDGERACCOUNTS, 0, SetSpacing(TextBoxLedgerAccountFrom.Text, 7))
        If KTRL Then
        Else
            RecordToField(TABLE_LEDGERACCOUNTS)
            TextBoxLedgerAccountFrom.Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
        End If

        TextBoxLedgerAccountTo.Text = "7999999"
        bPrev(TABLE_LEDGERACCOUNTS, 0, SetSpacing(TextBoxLedgerAccountTo.Text, 7))
        If KTRL Then
        Else
            RecordToField(TABLE_LEDGERACCOUNTS)
            TextBoxLedgerAccountTo.Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
        End If

        TextBoxPeriodFromTo.Text = FunctionDateText(Mid(SelectionFromTo, 1, 8)) & " - " & FunctionDateText(Mid(SelectionFromTo, 9))
        CheckRecordSet()

    End Sub

    Private Sub CheckRecordSet()

        Dim sSQL As String
        sSQL = "SELECT Journalen.v066, Journalen.v019, Rekeningen.v020, Journalen.v067, Journalen.v033, Journalen.dece068, Journalen.v069, Journalen.v038 FROM Journalen, Rekeningen WHERE Journalen.v019=Rekeningen.v019 AND Journalen.v066 >= '" & Mid(SelectionFromTo, 1, 8) & "' AND Journalen.v066 <= '" & Mid(SelectionFromTo, 9) & "' ORDER BY Journalen.v019, Journalen.v066"

        ' Create a recordset using the provided collection
        JournalEntriesRS = New ADODB.Recordset With {
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
        }
        JournalEntriesRS.Open(sSQL, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        If JournalEntriesRS.RecordCount <= 0 Then
            TextBoxRecordLines.Text = "0"
            Exit Sub
        Else
            TextBoxRecordLines.Text = JournalEntriesRS.RecordCount
            ButtonGenerateReport.Focus()
        End If

    End Sub

    Private Sub TextBoxRecordLines_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRecordLines.TextChanged

        If TextBoxRecordLines.Text = "0" Then
            ButtonGenerateReport.Enabled = False
        Else
            ButtonGenerateReport.Enabled = True
        End If

    End Sub

    Private Sub InitializeFields()

        REPORT_FIELD(0) = "Line"
        REPORT_TAB(0) = 2
        REPORT_FIELD(1) = "Datum"
        REPORT_TAB(1) = 9
        REPORT_FIELD(2) = "Omschrijving"
        REPORT_TAB(2) = 22
        REPORT_FIELD(3) = "Document"
        REPORT_TAB(3) = 53
        REPORT_FIELD(4) = "Fin.Dok."
        REPORT_TAB(4) = 67
        REPORT_FIELD(5) = "       Debet"
        REPORT_TAB(5) = 76
        REPORT_FIELD(6) = "      Credit"
        REPORT_TAB(6) = 89
        REPORT_FIELD(7) = "T.Reken"
        REPORT_TAB(7) = 103
        REPORT_FIELD(8) = "VSF.Kode"
        REPORT_TAB(8) = 111
        REPORT_TAB(9) = 0

        PdfReportTitle = Space(128)
        For T = 0 To 8
            Mid(PdfReportTitle, REPORT_TAB(T)) = REPORT_FIELD(T)
        Next

    End Sub

    Private Sub VpePrintLine()

        Dim PdfLine As String = Space(128)
        Dim DCAmount As Double
        Line += 1

        LastLedgerAccount = Trim(JournalEntriesRS.Fields("v019").Value)
        CheckForMonth = Mid(JournalEntriesRS.Fields("v066").Value, 5, 2)

        Mid(PdfLine, REPORT_TAB(0)) = Format(Line, "0000") 'lijn
        Mid(PdfLine, REPORT_TAB(1)) = FunctionDateText(ObjectValue((JournalEntriesRS.Fields("v066").Value))) 'datum
        Mid(PdfLine, REPORT_TAB(2)) = JournalEntriesRS.Fields("v067").Value 'betreft

        If IsDBNull(JournalEntriesRS.Fields("v033").Value) Then
        Else
            Mid(PdfLine, REPORT_TAB(3)) = JournalEntriesRS.Fields("v033").Value  'document
        End If
        If IsDBNull(JournalEntriesRS.Fields("v038").Value) Then
        Else
            Mid(PdfLine, REPORT_TAB(4)) = JournalEntriesRS.Fields("v038").Value  'fin. doc.
        End If

        DCAmount = ObjectValue((JournalEntriesRS.Fields("dece068").Value))
        Select Case DCAmount
            Case Is < 0
                MonthTotalC += DCAmount
                SubTotalC += DCAmount
                EndTotalC += DCAmount
                Mid(PdfLine, REPORT_TAB(6)) = Dec(Math.Abs(DCAmount), MASK_EURBH) 'bedrag credit
            Case Else
                MonthTotalD += DCAmount
                SubTotalD += DCAmount
                EndTotalD += DCAmount
                mid(PdfLine, REPORT_TAB(5)) = Dec(DCAmount, MASK_EURBH) 'bedrag debet
        End Select
        If IsDBNull(JournalEntriesRS.Fields("v069").Value) Then
        Else
            Mid(PdfLine, REPORT_TAB(7)) = JournalEntriesRS.Fields("v069").Value  'fin. doc.
        End If
        'Mid(PdfLine, REPORT_TAB(8)) = FieldText(8) 'vsf.kode

        pdfY = Mim.Report.Print(1, pdfY, PdfLine & vbCrLf)
        If pdfY > 27.5 Then
            Mim.Report.PageBreak()
            VpePrintHeader()
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
        Mim.Report.Print(1, pdfY, ReportText(3))
        pdfY = Mim.Report.Print(17, pdfY, "Datum  : " & ReportText(0) & vbCrLf & vbCrLf)
        VpePrintSubHeader()

    End Sub

    Private Sub VpePrintSubHeader()

        pdfY = Mim.Report.Print(1, pdfY, Trim(JournalEntriesRS.Fields("v019").Value) & " " & JournalEntriesRS.Fields("v020").Value)
        pdfY = Mim.Report.Print(1, pdfY, FULL_LINE & vbCrLf)
        pdfY = Mim.Report.Print(1, pdfY, PdfReportTitle & vbCrLf)
        pdfY = Mim.Report.Print(1, pdfY, FULL_LINE & vbCrLf)

    End Sub

    Private Sub PrintMonthTotal()

        If CheckBoxPeriodTotals.Checked = False Then
            Exit Sub
        End If

        Dim PdfLine As String = Space(128)

        mid(PdfLine, REPORT_TAB(2)) = "Maandtotaal:"
        mid(PdfLine, REPORT_TAB(5)) = Dec(MonthTotalD, MASK_EURBH)
        mid(PdfLine, REPORT_TAB(6)) = Dec(Math.Abs(MonthTotalC), MASK_EURBH)
        pdfY = Mim.Report.Print(1, pdfY, vbCrLf & PdfLine & vbCrLf)
        MonthTotalC = 0
        MonthTotalD = 0

    End Sub

    Private Sub PrintPeriodicTotal()

        PrintMonthTotal()

        Dim PdfLine As String = Space(128)

        PdfLine = Space(128)
        mid(PdfLine, REPORT_TAB(2)) = "Boekjaar totalen:"
        mid(PdfLine, REPORT_TAB(5)) = Dec(SubTotalD, MASK_EURBH)
        mid(PdfLine, REPORT_TAB(6)) = Dec(Math.Abs(SubTotalC), MASK_EURBH)
        pdfY = Mim.Report.Print(1, pdfY, PdfLine & vbCrLf & vbCrLf)

        If pdfY > 27.5 Then
            Mim.Report.PageBreak()
            VpePrintHeader()
        End If
        SubTotalC = 0
        SubTotalD = 0
        If JournalEntriesRS.EOF Then
        Else
            VpePrintSubHeader()
        End If

    End Sub

    Private Sub PrintEndTotal()

        Dim PdfLine As String = Space(128)

        mid(PdfLine, REPORT_TAB(2)) = "Proef- en Salditotalen :"
        mid(PdfLine, REPORT_TAB(5)) = Dec(EndTotalD, MASK_EURBH)
        mid(PdfLine, REPORT_TAB(6)) = Dec(Math.Abs(EndTotalC), MASK_EURBH)
        pdfY = Mim.Report.Print(1, pdfY, vbCrLf & PdfLine)
        EndTotalD = 0
        EndTotalC = 0

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Me.Close()

    End Sub

    Private Sub TextBoxPeriodFromTo_Leave(sender As Object, e As EventArgs) Handles TextBoxPeriodFromTo.Leave

        SelectionFromTo = BOOKYEAR_FROMTO
        If DateWrongFormat(Mid(TextBoxPeriodFromTo.Text, 14, 10)) Then
            MsgBox("Respecteer : " & vbCrLf & vbCrLf & "DD/MM/EEJJ - DD/MM/EEJJ a.u.b. !")

            TextBoxPeriodFromTo.Text = FunctionDateText(Mid(SelectionFromTo, 1, 8)) & " - " & FunctionDateText(Mid(SelectionFromTo, 9))
            TextBoxPeriodFromTo.Focus()
            Exit Sub

        ElseIf Len(TextBoxPeriodFromTo.Text) <> 23 Then
            MsgBox("Respecteer : " & vbCrLf & vbCrLf & "DD/MM/EEJJ - DD/MM/EEJJ a.u.b. !")

            TextBoxPeriodFromTo.Text = FunctionDateText(Mid(SelectionFromTo, 1, 8)) & " - " & FunctionDateText(Mid(SelectionFromTo, 9))
            TextBoxPeriodFromTo.Focus()
            Exit Sub
        Else
            SelectionFromTo = Mid(TextBoxPeriodFromTo.Text, 7, 4) & Mid(TextBoxPeriodFromTo.Text, 4, 2) & Mid(TextBoxPeriodFromTo.Text, 1, 2) & Mid(TextBoxPeriodFromTo.Text, 20, 4) & Mid(TextBoxPeriodFromTo.Text, 17, 2) & Mid(TextBoxPeriodFromTo.Text, 14, 2)
            CheckRecordSet()
        End If

    End Sub

    Private Sub TextBoxLedgerAccountFrom_Leave(sender As Object, e As EventArgs) Handles TextBoxLedgerAccountFrom.Leave

        bNext(TABLE_LEDGERACCOUNTS, 0, SetSpacing(TextBoxLedgerAccountFrom.Text, 7))
        If KTRL Then
        Else
            RecordToField(TABLE_LEDGERACCOUNTS)
            TextBoxLedgerAccountFrom.Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
        End If

    End Sub

    Private Sub TextBoxLedgerAccountTo_Leave(sender As Object, e As EventArgs) Handles TextBoxLedgerAccountTo.Leave

        bPrev(TABLE_LEDGERACCOUNTS, 0, SetSpacing(TextBoxLedgerAccountTo.Text, 7))
        If KTRL Then
        Else
            RecordToField(TABLE_LEDGERACCOUNTS)
            TextBoxLedgerAccountTo.Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
        End If

    End Sub

    Private Sub ButtonGenerateReport_Leave(sender As Object, e As EventArgs) Handles ButtonGenerateReport.Leave

        TextBoxRecordLines.Text = "0"

    End Sub

    Private Sub ButtonGenerateReport_Click(sender As Object, e As EventArgs) Handles ButtonGenerateReport.Click

        With Mim.Report
            .CloseDoc()
            .OpenDoc()
            .Author = "marIntegraal"
            .GUILanguage = 3 'Nederlands
            .Title = "Historieken"
        End With
        ReportText(2) = "Historieken " & Mid(Mim.Text, InStr(Mim.Text, "["))
        ReportText(0) = TextBoxProcessingDate.Text
        ReportText(3) = TextBoxPeriodFromTo.Text
        InitializeFields()
        Line = 0
        JournalEntriesRS.MoveFirst()
        VpePrintHeader()
        Do While Not JournalEntriesRS.EOF
            VpePrintLine()
            JournalEntriesRS.MoveNext()
            If JournalEntriesRS.EOF Then
                Exit Do
            Else
                If LastLedgerAccount <> Trim(JournalEntriesRS.Fields("v019").Value) Then
                    Line = 0
                    PrintPeriodicTotal()
                Else
                    If CheckForMonth <> Mid(JournalEntriesRS.Fields("v066").Value, 5, 2) Then
                        PrintMonthTotal()
                    End If
                End If
            End If
        Loop
        PrintPeriodicTotal()
        PrintEndTotal()
        With Mim.Report
            .WriteDoc(LOCATION_COMPANYDATA & Format(Now, "YYYYMMDDHHMMSS") & "-historieken.pdf")
            .MailSubject = "Historieken bedrijfx"
            .MailText = "Historieken bedrijf ix in bijlage."
        End With

        'Mim.Report.AddMailReceiver(TextBoxMailToOption.Text, RecipientClass.To)
        Mim.Report.Preview()
        'Mim.Report.CloseDoc()
        Focus()
        ButtonClose.PerformClick()

    End Sub

    Private Sub CheckBoxPeriodTotals_Leave(sender As Object, e As EventArgs) Handles CheckBoxPeriodTotals.Leave

        CheckRecordSet()

    End Sub
End Class

'	Private Sub TekstLijn_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstLijn.Enter
'		Dim Index As Short = TekstLijn.GetIndex(eventSender)

'		TekstLijn(Index).SelectionStart = 0
'		TekstLijn(Index).SelectionLength = Len(TekstLijn(Index).Text)

'		Select Case Index
'			Case 2, 3
'				SnelHelpPrint("[Ctrl] voor geïndexeerd zoeken", BL_LOGGING)
'		End Select

'	End Sub

'	Private Sub TekstLijn_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles TekstLijn.KeyDown
'		Dim KeyCode As Short = eventArgs.KeyCode
'		Dim Shift As Short = eventArgs.KeyData \ &H10000
'		Dim Index As Short = TekstLijn.GetIndex(eventSender)

'		On Error Resume Next
'		If KeyCode = 13 Then System.Windows.Forms.SendKeys.SendWait("{TAB}") : Exit Sub
'		Select Case Index
'			Case 2, 3
'				Select Case KeyCode
'					Case 17
'						A_INDEX = 0
'						SHARED_FL = TABLE_LEDGERACCOUNTS
'						GRIDTEXT = TekstLijn(Index).Text
'						SqlSearch.ShowDialog()
'						If KTRL = 0 Then
'							TekstLijn(Index).Text = AdoGetField(TABLE_LEDGERACCOUNTS, "#v019 #")
'							SnelHelpPrint(AdoGetField(TABLE_LEDGERACCOUNTS, "#v020 #"), BL_LOGGING)
'						End If
'				End Select
'		End Select

'	End Sub
