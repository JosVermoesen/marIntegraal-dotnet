Option Strict Off
Option Explicit On

Public Class FormFinalReport

    Dim ReportText(5) As String 'Koptekstinfo

    Dim sFile(20) As String
    Dim sMin(10) As String
    Dim sMax(10) As String
    Dim sMg(10) As String
    Dim sText(10) As String

    Dim sMinSl As String = Space(7)
    Dim sMaxSl As String = Space(7)
    Dim aSort As Integer = 0
    Dim sCode As String = ""
    Dim aPos As Integer = 0
    Dim sbd As String = Space(1)
    Dim aLijn As Integer = 0

    Dim ichr(10) As Short

    Dim vLine As String = Chr(124)
    Dim hLine As String = Chr(45)

    Dim pdfY As Double

    Private Sub FormFinalReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Bedrijf As String
        Dim sInfo As String = ""
        Dim FlTemp As Short
        Dim i As Short

        TextBoxProcessingDate.Text = MIM_GLOBAL_DATE
        Text = Text & " " & FormBYPERDAT.Boekjaar.Text

        i = 0

        Bedrijf = Dir(PROGRAM_LOCATION & "Def\" & "99MAR*.SRN")
        If Bedrijf = Space(Len(Bedrijf)) Then
            ButtonGenerate.Enabled = False
        Else
            Do While Bedrijf <> ""
                FlTemp = FreeFile()
                FileOpen(FlTemp, PROGRAM_LOCATION & "Def\" & Bedrijf, OpenMode.Input)
                Input(FlTemp, sInfo)
                FileClose(FlTemp)
                sInfo = UCase(Mid(sInfo, 1, 1)) & LCase(Mid(sInfo, 2))
                sFile(i) = Bedrijf
                ComboBoxReportType.Items.Add(sInfo)
                i += 1
                Bedrijf = Dir()
            Loop
            If ComboBoxReportType.Items.Count Then
                ComboBoxReportType.SelectedIndex = i - 1
            End If
        End If

        For i = 0 To 10
            ichr(i) = 124
        Next

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
        pdfY = Mim.Report.Print(1, pdfY, UCase(ReportText(3)))
        pdfY = Mim.Report.Print(1, pdfY, FULL_LINE & vbCrLf & vbCrLf)

    End Sub

    Private Sub LabelRekening()

        '        'nieuw rekenkundige controle
        Dim rTotaal1 = 0
        Dim rTotaal2 = 0
        Dim dTOT As Double
        Dim dVTot As Double

        Dim sMinSl As String = Space(7)
        Dim sMaxSl As String = Space(7)
        Dim cflag As Integer

        For klt = 1 To asort
            cflag = 1
            dTOT = 0 : dVTot = 0
            sMinSl = Mid(sMin(klt), 2, 7)
            sMaxSl = Mid(sMin(klt), 10, 7)
            Label1000()

            If Mid(sMin(klt), 1, 1) = "+" Then
                rTotaal1 = rTotaal1 + dTOT
            Else
                'Stop
            End If
            dTOT = 0 : dVTot = 0
            sMinSl = Mid(sMax(klt), 2, 7)
            sMaxSl = Mid(sMax(klt), 10, 7)
            Label1000()

            If Mid(sMax(klt), 1, 1) = "+" Then
                rTotaal2 = rTotaal2 + dTOT
            Else
                'Stop
            End If
        Next klt
        Select Case Mid(scode, 1, 2)
            Case "? "
                If rTotaal1 = 0 Or rTotaal2 = 0 Then
                Else
                    'MSG = Mid(Mim.SnelHelp.SimpleText, 9) + vbCrLf + vbCrLf
                    MSG = MSG + Format(rTotaal1, MASK_EURBH) + " ? " + Format(rTotaal2, MASK_EURBH)
                    MsgBox(MSG, 0, "Kontroleer a.u.b. !")
                End If
            Case Else
                'Stop
        End Select

    End Sub

    Private Sub Label2000(stekst)

        Dim alt As Integer = 0

        'PrintTitel
        'Printer.Print String$(Len(stekst(0)) + 1, Chr$(ichr(4))); Chr$(ivbtab); String$(7, Chr$(ichr(4))); Chr$(ivbtab); String$(23, Chr$(ichr(4))); Chr$(ivbtab); String$(24, Chr$(ichr(4))); Chr$(ichr(1))
        'Printer.Print Space$(Len(stekst(0)) + 1); Chr$(ichr(5)); Space$(7); Chr$(ichr(5)); smg(2); Chr$(ichr(5)); smg(3); Chr$(ichr(5))
        'Printer.Print Space$(Len(stekst(0)) + 1); Chr$(ichr(5)); smg(4); Chr$(ichr(6)); String$(23, Chr$(ichr(4))); Chr$(ichr(8)); String$(24, Chr$(ichr(4))); Chr$(ichr(7))
        'Printer.Print Space$(Len(stekst(0)) + 1); Chr$(ichr(5)); Space$(7); Chr$(ichr(5)); smg(5); Chr$(ichr(5))
        'Printer.Print Space$(Len(stekst(0)) + 1); Chr$(ichr(6)); String$(7, Chr$(ichr(4))); Chr$(ichr(10)); String$(23, Chr$(ichr(4))); Chr$(ivbtab); String$(24, Chr$(ichr(4))); Chr$(ichr(7))

        While stekst(alt) <> ""
            '    Printer.Print TAB(1); stekst(alt); " "; Chr$(ichr(5)); Space$(7); Chr$(ichr(5)); Space$(23); Chr$(ichr(5)); Space$(24); Chr$(ichr(5))

            alt += 1
        End While

    End Sub

    Private Sub Label1000()

        Dim Tekst As String = ""


        Select Case sbd
            Case "m"
                For T = 0 To aLijn
                    Tekst$ = Tekst$ + sText(T) + vbCrLf
                Next
                LabelMemo.Text = Tekst$
                LabelMemo.Refresh()
                'GoTo Label1060

            Case "h"
                Label2000()
                'GoTo Label1060

            Case "e"
                'GoTo Label2200

            Case "t"
                'GoTo Label2300

            Case "l"
                'GoTo Label2400
            Case Else
        End Select

        'Vooraan:
        '        bFirst FlRekening, 0
        '    bGetOrGreater FlRekening, 0, sminsl
        '    If KTRL Then
        '            GoTo PrintAf
        '        Else
        '            If vSet(KeyBuf(FlRekening), 7) > smaxsl Then
        '                GoTo PrintAf
        '            Else
        '                RecordToVeld FlRekening
        '            GoSub TelOp
        '        End If
        '        End If

        '        Do
        '            bNext FlRekening
        '    If KTRL Then
        '                GoTo PrintAf
        '            Else
        '                If vSet(KeyBuf(FlRekening), 7) > smaxsl Then
        '                    GoTo PrintAf
        '                Else
        '                    RecordToVeld FlRekening
        '            GoSub TelOp
        '        End If
        '            End If
        '        Loop
        '        MsgBox "stop na DO-LOOP"

        'TelOp:
        '        If bhEuro Then
        '            dbdhbj = Val(vBibTekst(FlRekening, "#e" + Format(22 + BJPERDAT.Boekjaar.ListIndex, "000") + " #"))
        '            dbdvbj = Val(vBibTekst(FlRekening, "#e" + Format(22 + BJPERDAT.Boekjaar.ListIndex + 1, "000") + " #"))
        '        Else
        '            dbdhbj = Val(vBibTekst(FlRekening, "#v" + Format(22 + BJPERDAT.Boekjaar.ListIndex, "000") + " #"))
        '            dbdvbj = Val(vBibTekst(FlRekening, "#v" + Format(22 + BJPERDAT.Boekjaar.ListIndex + 1, "000") + " #"))
        '        End If
        '        dTOT = dTOT + dbdhbj
        '        dvtot = dvtot + dbdvbj
        '        Return

        'PrintAf:
        '        alt = 0
        '        While stekst(alt) <> ""
        '            Printer.Print TAB(1); stekst(alt); " "; Chr$(ichr(5));
        '    If stekst(alt + 1) <> "" Then
        '                Printer.Print Space$(7); Chr$(ichr(5)); Space$(23); Chr$(ichr(5)); Space$(24); Chr$(ichr(5))
        '    End If
        '            alt = alt + 1
        'Wend

        'If cflag = 1 Then
        '            GoTo Label1060
        '        ElseIf sbd = "C" Then
        '            dTOT = -dTOT
        '            dvtot = -dvtot
        '        End If

        '        If sbd = "X" Then
        '            If dvtot > 0 Then
        '                dvtot = 0
        '            Else
        '                dvtot = Abs(dvtot)
        '            End If
        '        End If

        '        If sbd = "Y" Then
        '            If dvtot < 0 Then
        '                dvtot = 0
        '            End If
        '        End If

        '        If sbd = "X" Then
        '            If dTOT > 0 Then
        '                dTOT = 0
        '            Else
        '                dTOT = Abs(dTOT)
        '            End If
        '        End If

        '        If sbd = "Y" Then
        '            If dTOT < 0 Then
        '                dTOT = 0
        '            End If
        '        End If

        '        Printer.Print Scode; Chr$(ichr(5)); Tab(72 + apos - 2); Dec$(dTOT / ideler, MaskerEURBH);
        'Printer.Print TAB(93); Chr$(ichr(5)); Tab(95 + apos); Dec$(dvtot / ideler, MaskerEURBH);
        'Printer.Print TAB(117); " "; Chr$(ichr(5))
        'dTOT = 0
        '        dvtot = 0

        'Label1060:
        '        For tlp = 0 To 5
        '            stekst(tlp) = ""
        '        Next tlp
        '        Return


        'Label2200:
        '        Printer.Print Space$(60); Chr$(ichr(2)); String$(7, Chr$(ichr(4))); Chr$(ichr(8)); String$(23, Chr$(ichr(4))); Chr$(ichr(8)); String$(24, Chr$(ichr(4))); Chr$(ichr(3));
        '    Printer.NewPage
        '        Return

        'Label2300:
        '        Printer.Print Space$(60); Chr$(ichr(6)); String$(7, Chr$(ichr(4))); Chr$(ichr(10)); String$(23, Chr$(ichr(4))); Chr$(ichr(10)); String$(24, Chr$(ichr(4))); Chr$(ichr(7))
        'Return

        'Label2400:
        '        Printer.Print Space$(60); Chr$(ichr(5)); Space$(7); Chr$(ichr(5)); Space$(23); Chr$(ichr(5)); Space$(24); Chr$(ichr(5))
        'Return

    End Sub

    Private Sub Label2000()

        Dim alt As Integer = 0

        'PrintTitel
        'Printer.Print String$(Len(stekst(0)) + 1, Chr$(ichr(4))); Chr$(ivbtab); String$(7, Chr$(ichr(4))); Chr$(ivbtab); String$(23, Chr$(ichr(4))); Chr$(ivbtab); String$(24, Chr$(ichr(4))); Chr$(ichr(1))
        'Printer.Print Space$(Len(stekst(0)) + 1); Chr$(ichr(5)); Space$(7); Chr$(ichr(5)); smg(2); Chr$(ichr(5)); smg(3); Chr$(ichr(5))
        'Printer.Print Space$(Len(stekst(0)) + 1); Chr$(ichr(5)); smg(4); Chr$(ichr(6)); String$(23, Chr$(ichr(4))); Chr$(ichr(8)); String$(24, Chr$(ichr(4))); Chr$(ichr(7))
        'Printer.Print Space$(Len(stekst(0)) + 1); Chr$(ichr(5)); Space$(7); Chr$(ichr(5)); smg(5); Chr$(ichr(5))
        'Printer.Print Space$(Len(stekst(0)) + 1); Chr$(ichr(6)); String$(7, Chr$(ichr(4))); Chr$(ichr(10)); String$(23, Chr$(ichr(4))); Chr$(ivbtab); String$(24, Chr$(ichr(4))); Chr$(ichr(7))

        While sText(alt) <> ""
            '    Printer.Print TAB(1); stekst(alt); " "; Chr$(ichr(5)); Space$(7); Chr$(ichr(5)); Space$(23); Chr$(ichr(5)); Space$(24); Chr$(ichr(5))
            alt += 1
        End While

    End Sub

    Private Sub ButtonGenerate_Click(sender As Object, e As EventArgs) Handles ButtonGenerate.Click

        Dim FlTemp As Integer
        Dim ideler As Integer
        Dim lijntel As Integer

        Dim dbdhBJ As Double
        Dim dbdvBJ As Double

        Dim cflag As Integer

        Dim sbd As String = Space(1)
        Dim alijn As Integer
        Dim apos As Integer

        LabelMemo.Text = ""

        Cursor.Current = Cursors.WaitCursor
        PAGE_COUNTER = 0

        With Mim.Report
            .CloseDoc()
            .OpenDoc()
            .Author = "marIntegraal"
            .GUILanguage = 3 'Nederlands
            .Title = "Diverse Postenboek"
        End With


        FlTemp = FreeFile()
        FileOpen(FlTemp, PROGRAM_LOCATION & "Def\" & sFile(ComboBoxReportType.SelectedIndex), OpenMode.Input)

        Input(FlTemp, sMg(9))
        Input(FlTemp, sMg(2))
        Input(FlTemp, sMg(3))
        Input(FlTemp, sMg(4))
        Input(FlTemp, sMg(5))
        Input(FlTemp, ideler)

        lijntel = 6

        If ideler = 1 Then
            ideler = 1000
        Else
            ideler = 1
        End If

        ReportText(2) = "Rapportage " & Mid(Mim.Text, InStr(Mim.Text, "["))
        ReportText(0) = TextBoxProcessingDate.Text
        ReportText(3) = sMg(9) + " Boekjaar " + FormBYPERDAT.Boekjaar.Text
        VpePrintHeader()

        While Not EOF(FlTemp)
            lijntel = lijntel + 1
            Input(FlTemp, sbd)
            Input(FlTemp, alijn)
            Input(FlTemp, Scode)
            Input(FlTemp, apos)

            If InStr("DCXYmheltr", sbd) = 0 Then
                'nieuw rekenkundige controle
                MsgBox("Rapportagedefinitiebestand defekt of beschadigd.")
                FileClose(FlTemp)
                'Printer.NewPage
                'Printer.EndDoc
                Exit Sub
            End If

            For T = 0 To alijn - 1
                lijntel = lijntel + 1
                Input(FlTemp, sText(T))
                'SnelHelpPrint "LN:" + Dec$((lijntel), "###") + "  " + stekst(T), blLogging
            Next T
            lijntel = lijntel + 1
            Input(FlTemp, asort)

            For T = 1 To asort
                lijntel = lijntel + 1
                Input(FlTemp, sMin(T))
                Input(FlTemp, sMax(T))
            Next T

            If InStr("mhelt", sbd) Then
                'GoSub Label1000
            ElseIf InStr("r", sbd) Then
                'nieuw rekenkundige controle
                LabelRekening()
            Else
                For klt = 1 To asort - 1
                    cflag = 1
                    sMinSl = sMin(klt)
                    sMaxSl = sMax(klt)
                    Label1000()
                Next klt
                sMinSl = sMin(asort)
                sMaxSl = sMax(asort)
                cflag = 0
                Label1000()
            End If
        End While
        FileClose(FlTemp)
        'Printer.EndDoc
        Cursor.Current = Cursors.Default
        Exit Sub

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Close()

    End Sub

    Private Sub TextBoxProcessingDate_Leave(sender As Object, e As EventArgs) Handles TextBoxProcessingDate.Leave

        If DateWrongFormat(TextBoxProcessingDate.Text) Then
            Beep()
            TextBoxProcessingDate.Text = MIM_GLOBAL_DATE
            TextBoxProcessingDate.Focus()
        End If

    End Sub

    Private Sub ComboBoxReportType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxReportType.SelectedIndexChanged

        LabelMemo.Text = ""

    End Sub

End Class

