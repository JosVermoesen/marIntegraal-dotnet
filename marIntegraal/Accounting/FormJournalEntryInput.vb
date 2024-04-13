Option Strict Off
Option Explicit On
Public Class FormJournalEntryInput
    Dim TotalDCAmount As Double

    Private Sub FrmJournalEntryInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Top = 0
        Left = 0
        ComboBoxBookType.Items.Add("0: Diverse post")
        ComboBoxBookType.Items.Add("1: Afschrijvingspost Eindejaar")
        ComboBoxBookType.Items.Add("2: Beginbalans")

        DateTimePickerBookingDate.Value = FormBYPERDAT.DatumVerwerking.Value
        ButtonEraseAll.PerformClick()
        If XLogKey = "SchrijfAF!" Then
            ComboBoxBookType.SelectedIndex = 1
        End If
    End Sub

    'Fuctions
    Private Function BookingError() As Boolean
        Dim T As Short

        BookingError = False
        dKtrlCumul = 0 : dKtrlBEF = 0 : dKtrlEUR = 0

        Boeking.Close()
        Boeking.Hide()

        For T = 0 To ListBoxJournalEntries.Items.Count - 1
            Msg = ListBoxJournalEntries.Items.Item(T)
            rsJournaal.AddNew()
            rsJournaal.Fields("v041").Value = "0"
            rsJournaal.Fields("v066").Value = Format(DateTimePickerBookingDate.Value, "yyyyMMdd") 'Boekdatum
            rsJournaal.Fields("v033").Value = "D0" & Format(DateTimePickerBookingDate.Value, "yyyyMMdd") 'dokument
            rsJournaal.Fields("v035").Value = Format(DateTimePickerBookingDate.Value, "yyyyMMdd") 'dokumentdatum
            rsJournaal.Fields("v067").Value = Mid(TextBoxDescription.Text, 1, 35) 'Omschrijving
            rsJournaal.Fields("v019").Value = Mid(Msg, 1, 7) 'Rekening
            rsJournaal.Fields("v068").Value = Mid(Msg, 50, 12) 'Bedrag
            rsJournaal.Fields("dece068").Value = Val(Mid(Msg, 50, 12)) 'Bedrag
            rsJournaal.Fields("v069").Value = Mid(Msg, 63, 7) 'TegenRekening
            If Not adoJournaalOK() Then
                BookingError = True
                dKtrlCumul = 999
            ElseIf Mid(Msg, 63, 7) <> "       " Then
                rsJournaal.AddNew()
                rsJournaal.Fields("v041").Value = "0"
                rsJournaal.Fields("v066").Value = Format(DateTimePickerBookingDate.Value, "yyyyMMdd") 'Boekdatum
                rsJournaal.Fields("v033").Value = "D0" & Format(DateTimePickerBookingDate.Value, "yyyyMMdd") 'dokument
                rsJournaal.Fields("v035").Value = Format(DateTimePickerBookingDate.Value, "yyyyMMdd") 'dokumentdatum
                rsJournaal.Fields("v067").Value = Mid(TextBoxDescription.Text, 1, 35) 'Omschrijving

                rsJournaal.Fields("v019").Value = Mid(Msg, 63, 7) 'Rekening
                rsJournaal.Fields("v068").Value = Str(-Val(Mid(Msg, 50, 12))) 'Bedrag
                rsJournaal.Fields("dece068").Value = -Val(Mid(Msg, 50, 12)) 'Bedrag
                rsJournaal.Fields("v069").Value = Mid(Msg, 1, 7) 'TegenRekening
                If Not adoJournaalOK() Then
                    BookingError = True
                    dKtrlCumul = 999
                End If
            End If
        Next

        If dKtrlCumul Then
            MsgBox("Fout bij vierkantskontrole journaal." & vbCrLf & vbCrLf & "Deze verrichting wordt genegeerd.")
            Boeking.cmdBoeken.Enabled = False
            Boeking.ShowDialog()
            BookingError = True
        ElseIf JournaalLocked = True Then
            Boeking.cmdBoeken.Enabled = False
            Boeking.ShowDialog()
            BookingError = True
        Else
            Boeking.ShowDialog()
            If dKtrlCumul Then BookingError = True
        End If

    End Function

    Private Sub CleanUpNextLine()
        CheckBoxDCFlag.Checked = False
        ToggleOffsetAccount()
        TextBoxLedgerAccount.Text = ""
        LabelLedgerAccountName.Text = ""
        TextBoxAmount.Text = ""
        TextBoxOffsetAccount.Text = ""
        LabelOffsetAccountName.Text = ""
        DebitChoosen.Checked = True
        ButtonAddLine.Enabled = False
    End Sub

    Private Sub ToggleOffsetAccount()
        If CheckBoxDCFlag.Checked Then
            TextBoxOffsetAccount.Visible = True
            LabelOffsetAccountName.Visible = True
        Else
            TextBoxOffsetAccount.Visible = False
            LabelOffsetAccountName.Visible = False
        End If
    End Sub

    Sub DCChoiceCheck(KeyString As String)
        Select Case KeyString
            Case "D", "+"
                DebitChoosen.Checked = True
                TextBoxLedgerAccount.Focus()
            Case "C", "-"
                CreditChoosen.Checked = True
                TextBoxLedgerAccount.Focus()
            Case "T", "/"
                CheckBoxDCFlag.Checked = Not CheckBoxDCFlag.Checked
                ToggleOffsetAccount()
                TextBoxLedgerAccount.Focus()
        End Select
    End Sub

    Function LedgerAccountOk(rekTextBox As TextBox, rekLabel As Label) As Boolean
        LedgerAccountOk = False
        SharedFl = TableOfLedgerAccounts
        SharedIndex = 0
        GridText = rekTextBox.Text
        SqlSearch.ShowDialog()
        If Ktrl Then
            rekLabel.Text = ""
        Else
            rekTextBox.Text = AdoGetField(TableOfLedgerAccounts, "#v019 #")
            rekLabel.Text = AdoGetField(TableOfLedgerAccounts, "#v020 #")
            LedgerAccountOk = True
        End If
    End Function

    Sub CheckDCStatus()
        TotalDCAmount = 0
        For t = 0 To ListBoxJournalEntries.Items.Count - 1
            Msg = ListBoxJournalEntries.Items.Item(t)
            If Trim(Mid(Msg, 63)) <> "" Then
            Else
                TotalDCAmount += Val(Mid(Msg, 50, 12))
            End If
        Next
        LabelSoldeAmount.Text = Dec(TotalDCAmount, MaskEURBH)
        If Val(LabelSoldeAmount.Text) = 0 Then
            ButtonBookEntries.Enabled = True
            AcceptButton = ButtonBookEntries
        Else
            ButtonBookEntries.Enabled = False
        End If
    End Sub

    Private Function BoekBeginBalans() As Boolean

        Return False

        'Dim pHier As String
        'Dim Verwittigen As Boolean

        'Verwittigen = False
        'If String99(Reading, 64) = "1" Then
        '    MsgBox("Beginbalans reeds gegenereerd voor dit boekjaar.  Bijkomende posten kunnen uitsluitend via 'Diverse post'-optie ingebracht worden !")
        '    'UPGRADE_WARNING: Couldn't resolve default property of object BoekBeginBalans. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    BoekBeginBalans = False
        '    Exit Function
        'ElseIf String99(Reading, 64) <> "0" Then
        '    MsgBox("Setup beginbalans bevat niet de juiste vlag geboekt of niet geboekt.  Kontroleer")
        '    'UPGRADE_WARNING: Couldn't resolve default property of object BoekBeginBalans. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    BoekBeginBalans = False
        '    Exit Function
        'End If

        'Dim TotaalBalans As Decimal
        'Dim TotaalResultaat As Decimal

        ''kontrole vanaf eerst 1 tot laatste 5
        'TotaalBalans = 0

        ''If Not adoGet(TableOfLedgerAccounts, 0, "=", XLogKey) Then
        ''Else
        ''    RekeningNummer = RV(rsMAR(TableOfLedgerAccounts), "v019")
        ''    NaamRekening = RV(rsMAR(TableOfLedgerAccounts), "v020")

        'If Not adoGet(TableOfLedgerAccounts, 0, ">=", SetSpacing("1", 7)) Then
        '    MsgBox("Geen rekeningen ???")
        '    'UPGRADE_WARNING: Couldn't resolve default property of object BoekBeginBalans. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    BoekBeginBalans = False
        '    Exit Function
        '    'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'ElseIf VB.Left(RV(rsMAR(TableOfLedgerAccounts), "v019"), 1) < "6" Then
        '    If bhEuro Then
        '        'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        TotaalBalans = TotaalBalans + Val(RV(rsMAR(TableOfLedgerAccounts), "e" & VB6.Format(ActiveBookyear + 23, "000")))
        '    Else
        '        'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        TotaalBalans = TotaalBalans + Val(RV(rsMAR(TableOfLedgerAccounts), "v" & VB6.Format(ActiveBookyear + 23, "000")))
        '    End If
        '    Do While Not rsMAR(TableOfLedgerAccounts).EOF
        '        rsMAR(TableOfLedgerAccounts).MoveNext()
        '        'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        If VB.Left(RV(rsMAR(TableOfLedgerAccounts), "v019"), 1) >= "6" Then
        '            Exit Do
        '        Else
        '            If bhEuro Then
        '                'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '                TotaalBalans = TotaalBalans + Val(RV(rsMAR(TableOfLedgerAccounts), "e" & VB6.Format(ActiveBookyear + 23, "000")))
        '            Else
        '                'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '                TotaalBalans = TotaalBalans + Val(RV(rsMAR(TableOfLedgerAccounts), "v" & VB6.Format(ActiveBookyear + 23, "000")))
        '            End If
        '        End If
        '    Loop
        'End If

        ''+ eerste 6 tot laatste 7
        'TotaalResultaat = 0
        'JetGetOrGreater(TableOfLedgerAccounts, 0, SetSpacing("6", 7))
        'If Ktrl Then
        '    MsgBox("Geen rekeningen ???")
        '    'UPGRADE_WARNING: Couldn't resolve default property of object BoekBeginBalans. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    BoekBeginBalans = False
        '    Exit Function
        'ElseIf VB.Left(KeyBuf(TableOfLedgerAccounts), 1) < "8" Then
        '    RecordToField(TableOfLedgerAccounts)
        '    If bhEuro Then
        '        TotaalResultaat = TotaalResultaat + Val(AdoGetField(TableOfLedgerAccounts, "#e" & VB6.Format(ActiveBookyear + 23, "000") & " #"))
        '    Else
        '        TotaalResultaat = TotaalResultaat + Val(AdoGetField(TableOfLedgerAccounts, "#v" & VB6.Format(ActiveBookyear + 23, "000") & " #"))
        '    End If
        '    Do
        '        bNext(TableOfLedgerAccounts)
        '        If Ktrl Or VB.Left(KeyBuf(TableOfLedgerAccounts), 1) > "7" Then
        '            Exit Do
        '        Else
        '            RecordToField(TableOfLedgerAccounts)
        '            If bhEuro Then
        '                TotaalResultaat = TotaalResultaat + Val(AdoGetField(TableOfLedgerAccounts, "#e" & VB6.Format(ActiveBookyear + 23, "000") & " #"))
        '            Else
        '                TotaalResultaat = TotaalResultaat + Val(AdoGetField(TableOfLedgerAccounts, "#v" & VB6.Format(ActiveBookyear + 23, "000") & " #"))
        '            End If
        '        End If
        '    Loop
        'End If

        'Msg = ""
        'If TotaalResultaat <> 0 Then
        '    Msg = Msg & "Resultatenbalans verschil  : " & Dec(TotaalResultaat, MaskEURBH) & vbCrLf
        'End If
        'If TotaalBalans <> 0 Then
        '    If Msg = "" Then
        '        Verwittigen = True
        '        Msg = "Blijkbaar is het resultaat verleden jaar GOED geboekt maar actief/passief is verschillend.  Straks wordt U de mogelijkheid geboden om de verschillen bij te werken OP EIGEN VERANTWOORDELIJKHEID" & vbCrLf & vbCrLf
        '    End If
        '    Msg = Msg & "ACTIVE/PASSIVA verschil   : " & Dec(TotaalBalans, MaskEURBH) & vbCrLf
        'End If
        'If Msg = "" Then
        'Else
        '    Msg = Msg & vbCrLf & "Balansrekeningen Actief <> Passief, Resultaatrekeningen Debet <> Credit" & vbCrLf & vbCrLf & "Eerst resultaatsverwerking vorig jaar boeken a.u.b."
        '    MsgBox(Msg)
        '    'If Verwittigen Then
        '    'Else
        '    'BoekBeginBalans = False
        '    'Exit Function
        '    'End If
        'End If

        'Dim dTotaalKtrl As Decimal
        'Dim dBedrag As Decimal
        'Dim TextLine As String
        'JetGetOrGreater(TableOfLedgerAccounts, 0, SetSpacing("1", 7))
        'If Ktrl Then
        '    MsgBox("Geen rekeningen ???")
        '    'UPGRADE_WARNING: Couldn't resolve default property of object BoekBeginBalans. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    BoekBeginBalans = False
        '    Exit Function
        'ElseIf VB.Left(KeyBuf(TableOfLedgerAccounts), 1) < "6" Then
        '    RecordToField(TableOfLedgerAccounts)
        '    If bhEuro Then
        '        dBedrag = Val(AdoGetField(TableOfLedgerAccounts, "#e" & VB6.Format(ActiveBookyear + 23, "000") & " #"))
        '    Else
        '        dBedrag = Val(AdoGetField(TableOfLedgerAccounts, "#v" & VB6.Format(ActiveBookyear + 23, "000") & " #"))
        '    End If
        '    dTotaalKtrl = dTotaalKtrl + dBedrag
        '    If dBedrag <> 0 Then
        '        TextLine = SetSpacing(AdoGetField(TableOfLedgerAccounts, "#v019 #"), 7) & " " & SetSpacing(AdoGetField(TableOfLedgerAccounts, "#v020 #"), 40) & " " & Dec(dBedrag, MaskEURBH) & " " & SetSpacing("", 7)
        '        JournaalPost.Items.Add(TextLine)
        '    End If
        '    Do
        '        bNext(TableOfLedgerAccounts)
        '        If Ktrl Or VB.Left(KeyBuf(TableOfLedgerAccounts), 1) >= "6" Then
        '            Exit Do
        '        Else
        '            RecordToField(TableOfLedgerAccounts)
        '            If bhEuro Then
        '                dBedrag = Val(AdoGetField(TableOfLedgerAccounts, "#e" & VB6.Format(ActiveBookyear + 23, "000") & " #"))
        '            Else
        '                dBedrag = Val(AdoGetField(TableOfLedgerAccounts, "#v" & VB6.Format(ActiveBookyear + 23, "000") & " #"))
        '            End If
        '            dTotaalKtrl = dTotaalKtrl + dBedrag
        '            If dBedrag <> 0 Then
        '                TextLine = SetSpacing(AdoGetField(TableOfLedgerAccounts, "#v019 #"), 7) & " " & SetSpacing(AdoGetField(TableOfLedgerAccounts, "#v020 #"), 40) & " " & Dec(dBedrag, MaskEURBH) & " " & SetSpacing("", 7)
        '                JournaalPost.Items.Add(TextLine)
        '            End If
        '        End If
        '    Loop
        'End If
        'Afsluiten.Enabled = True
        'Omschrijving.Text = SoortBoeking.Text
        'Afsluiten.Focus()
        ''
        ''If Verwittigen Then
        'JournaalSaldoKTRL()
        ''Else
        ''    DCkeuze(0).Enabled = False
        ''    DCkeuze(1).Enabled = False
        ''    Bedrag.Visible = False
        ''    RekeningNummer.Visible = False
        ''    TRvlag.Enabled = False
        ''End If
        ''UPGRADE_WARNING: Couldn't resolve default property of object BoekBeginBalans. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'BoekBeginBalans = True
        'BJPERDAT.PeriodeBoekjaar.SelectedIndex = 0
        'End Function

        'Private Function AfschrijfBoeking() As Short
        'Dim OmschrijvingsLijn As New VB6.FixedLengthString(40)
        'Dim TextLine As String
        'Dim Succes As Short
        'On Error Resume Next
        'Succes = True
        'If String99(Reading, 63) = "1" Then
        'MsgBox("Afschrijvingsposten reeds gegenereerd voor dit boekjaar.  Bijkomende posten kunnen uitsluitend via 'Diverse post'-optie ingebracht worden !")
        '        AfschrijfBoeking = False
        '            Exit Function
        '        ElseIf String99(Reading, 63) <> "0" Then
        '            MsgBox("Setup boekjaar en parameters bevat niet de juiste vlag geboekt of niet geboekt.  Kontroleer")
        '            AfschrijfBoeking = False
        '            Exit Function
        '        ElseIf String99(Reading, 64) <> "1" Then
        '            MsgBox("Onlogische situatie.  Dit boekjaar bevat nog geen beginbalans ?  De beginbalans dient aanwezig te zijn.  Mogelijk bevindt U zich in het verkeerde boekjaar ?")
        '            AfschrijfBoeking = False
        '            Exit Function
        '        End If

        '        JetGetOrGreater(TableOfVarious, 1, SetSpacing("18", 20))
        '        If Ktrl Or VB.Left(KeyBuf(TableOfVarious), 2) <> "18" Then
        '            MsgBox("Er zijn geen investeringsfiches !")
        '            AfschrijfBoeking = False
        '            Exit Function
        '        Else
        '			'FIXIT: Keyword 'GoSub' not supported in Visual Basic .NET                                 FixIT90210ae-R6614-H1984
        '			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '			GoSub AfschrijvingsLijnErBij
        '			Do
        '                bNext(TableOfVarious)
        '                If Ktrl Or VB.Left(KeyBuf(TableOfVarious), 2) <> "18" Then
        '                    Exit Do
        '                Else
        '					'FIXIT: Keyword 'GoSub' not supported in Visual Basic .NET                                 FixIT90210ae-R6614-H1984
        '					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
        '					GoSub AfschrijvingsLijnErBij
        '				End If
        '            Loop
        '            If Succes Then
        '                Afsluiten.Enabled = True
        '                Omschrijving.Text = SoortBoeking.Text
        '                SoortBoeking.Enabled = False
        '                Afsluiten.Focus()
        '            End If
        '            DCkeuze(0).Enabled = False
        '            DCkeuze(1).Enabled = False
        '            Bedrag.Visible = False
        '            RekeningNummer.Visible = False
        '            TRvlag.Enabled = False
        '            AfschrijfBoeking = True
        '        End If
        '        Exit Function

        'AfschrijvingsLijnErBij:
        '        OmschrijvingsLijn.Value = ""
        '        RecordToField(TableOfVarious)
        '        If Len(AdoGetField(TableOfVarious, "#v083 #")) <> 8 Then
        '            OmschrijvingsLijn.Value = "Datumformaat onjuist voor " & AdoGetField(TableOfVarious, "#v087 #")
        '            MsgBox("dokumentendatum niet in formaat DDMMJJEE" & vbCrLf & vbCrLf & OmschrijvingsLijn.Value & vbCrLf & vbCrLf & AdoGetField(TableOfVarious, "#v083 #"))
        '            AfschrijfBoeking = False
        '            Exit Function
        '        End If

        '        Dim dRest As Double
        '        Dim ipct As Short
        '        Dim dTas As Double
        '        Dim dbdrg As Double
        '        Dim dRa As Double
        '        Dim Das As Double
        '        Dim restKtrl As Double
        '        Dim MaskerHier As String
        '        If Mid(AdoGetField(TableOfVarious, "#v083 #"), 5, 4) > Mid(BookyearFromTo.Value, 9, 4) Then
        '            'FIXIT: Return has new meaning in Visual Basic .NET                                        FixIT90210ae-R9642-H1984
        '            'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '            Return
        '        ElseIf Val(AdoGetField(TableOfVarious, "#v084 #")) = Val(AdoGetField(TableOfVarious, "#v085 #")) Then
        '            Msg = "Alles is afgeschreven voor " & AdoGetField(TableOfVarious, "#v087 #") & vbCrLf & vbCrLf & "Totaal : " & VB6.Format(Val(AdoGetField(TableOfVarious, "#v084 #")), MaskSy(0)) & vbCrLf & vbCrLf
        '            If Not adoGet(TableOfLedgerAccounts, 0, "=", AdoGetField(TableOfVarious, "#v087 #")) Then
        '                Msg = Msg & "Rekening bestaat zelfs niet eens..."
        '            Else
        '                'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '                Msg = Msg + RV(rsMAR(TableOfLedgerAccounts), "v020")
        '            End If
        '            MsgBox(Msg)
        '            'FIXIT: Return has new meaning in Visual Basic .NET                                        FixIT90210ae-R9642-H1984
        '            'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '            Return
        '        Else

        '            ipct = Val(AdoGetField(TableOfVarious, "#v082 #"))
        '            dbdrg = Val(AdoGetField(TableOfVarious, "#v084 #"))
        '            dRa = Val(AdoGetField(TableOfVarious, "#v085 #"))

        '            If bhEuro = True Then
        '                restKtrl = 0.5
        '                MaskerHier = MaskEURBH
        '            Else
        '                restKtrl = 20
        '                MaskerHier = MaskSy(0)
        '            End If

        '            dRest = dbdrg - (dRa + Val(Dec(dbdrg / ipct, MaskerHier)))

        '            If dRest < restKtrl Then
        '                Das = Val(Dec(dbdrg / ipct, MaskerHier)) + dRest
        '                dTas = dTas + Das
        '            Else
        '                Das = Val(Dec(dbdrg / ipct, MaskerHier))
        '                dTas = dTas + Das
        '            End If
        '        End If

        '        If Not adoGet(TableOfLedgerAccounts, 0, "=", AdoGetField(TableOfVarious, "#v087 #")) Then
        '            OmschrijvingsLijn.Value = RTrim(OmschrijvingsLijn.Value) & " Afschr. op!!!"
        '        End If
        '        If Not adoGet(TableOfLedgerAccounts, 0, "=", AdoGetField(TableOfVarious, "#v088 #")) Then
        '            OmschrijvingsLijn.Value = RTrim(OmschrijvingsLijn.Value) & " Kostrekening !!"
        '        Else
        '            If OmschrijvingsLijn.Value = Space(40) Then
        '                'UPGRADE_WARNING: Couldn't resolve default property of object RV(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '                OmschrijvingsLijn.Value = "Ok, " + RV(rsMAR(TableOfLedgerAccounts), "v020")
        '            End If
        '        End If

        '        If VB.Left(OmschrijvingsLijn.Value, 3) = "Ok," Then
        '        Else
        '            Succes = False
        '        End If
        '        TextLine = SetSpacing(AdoGetField(TableOfVarious, "#v088 #"), 7) & " " & OmschrijvingsLijn.Value & " " & Dec(Das, MaskEURBH) & " " & SetSpacing(AdoGetField(TableOfVarious, "#v087 #"), 7)
        '        JournaalPost.Items.Add(TextLine)
        '        'FIXIT: Return has new meaning in Visual Basic .NET                                        FixIT90210ae-R9642-H1984
        '        'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '        Return
        'End Function

        'Private Sub EindeAfschrijving()
        'Dim dRa As Double
        'Dim DummySleutel As String
        'Dim T As Short

        'If XisEuroWasBEF = True Then
        'Msg = "Laatste afschrijving in BEF is geboekt." & vbCr & vbCr
        'Msg = Msg & "Uw hoogste boekjaar is in EUR" & vbCr & vbCr
        'Msg = Msg & "Hierna worden alle nog openstaande afschrijvingslijnen eveneens omgerekend naar EUR voor toekomstige bewerkingen"
        'MsgBox(Msg, MsgBoxStyle.Information)
        'End If

        'For T = 0 To JournaalPost.Items.Count - 1
        'JetGetOrGreater(TableOfVarious, 1, SetSpacing("18" & VB.Right(VB6.GetItemString(JournaalPost, T), 7), 20))
        'If Ktrl Then
        'MsgBox("Stop")
        'Else
        'RecordToField(TableOfVarious)
        'dRa = Val(AdoGetField(TableOfVarious, "#v085 #")) + Val(Mid(VB6.GetItemString(JournaalPost, T), 50, 12))
        'AdoInsertToRecord(TableOfVarious, Str(dRa), "v085")
        'If XisEuroWasBEF = True Then
        'AdoInsertToRecord(TableOfVarious, Str(Val(Dec(dRa / Euro, "########0.00"))), "v085")
        'dRa = Val(AdoGetField(TableOfVarious, "#v084 #"))
        'AdoInsertToRecord(TableOfVarious, Str(Val(Dec(dRa / Euro, "########0.00"))), "v084")
        'End If
        'bUpdate(TableOfVarious, 1)
        'If Ktrl Then MsgBox("stop tijdens update investeringsfiche")
        'End If
        'Next
        'SS99("1", 63)

        'End Sub

    End Function


    'Toolbox Subs
    Private Sub ComboBoxBookType_SelectedIndexChanged(sender As Object, e As EventArgs)

        Select Case Mid(ComboBoxBookType.Text, 1, 1)
            Case "0"
            Case Else
                Msg = ComboBoxBookType.Text & " aktiveren !" & vbCrLf & vbCrLf
                Msg &= "Bent U zeker ?"
                Ktrl = MsgBox(Msg, 292)
                If Ktrl = 6 Then
                    Select Case Mid(ComboBoxBookType.Text, 1, 1)
                        Case "1"
                            'If AfschrijfBoeking() Then
                            'Else
                            ButtonEraseAll.PerformClick()
                            'End If
                        Case "2"
                            'If BoekBeginBalans() Then
                            'Else
                            ButtonEraseAll.PerformClick()
                            'End If
                        Case "9"
                            'BoekUserDef()
                        Case Else
                            MsgBox("stop")
                    End Select
                Else
                    ButtonEraseAll.PerformClick()
                    Exit Sub
                End If
        End Select

    End Sub

    Private Sub ButtonBookEntries_Click(sender As Object, e As EventArgs) Handles ButtonBookEntries.Click

        If Trim(TextBoxDescription.Text) = "" Then
            MsgBox("Omschrijving mag niet leeg zijn, ook géén spaties...", MsgBoxStyle.Information)
            TextBoxDescription.Focus()
            Exit Sub
        End If
        If Not DatumKtrl(Format(DateTimePickerBookingDate.Value, "dd/MM/yyyy"), PeriodAsText) Then
            Beep()
            FormBYPERDAT.WindowState = FormWindowState.Normal
            FormBYPERDAT.Focus()
            DateTimePickerBookingDate.Focus()
            Exit Sub
        ElseIf ListBoxJournalEntries.Items.Count = 0 Then
            Beep()
            Exit Sub
        End If

        Ktrl = MsgBox("Journaalpost bestaande uit" & Str(ListBoxJournalEntries.Items.Count) & " Lijnen wegboeken.  Bent U zeker ?", 292)
        If Ktrl = 6 Then
            TransBegin()
            Cursor.Current = Cursors.WaitCursor
            If BookingError() Then
                TransAbort()
                Activate()
            Else
                Select Case Mid(ComboBoxBookType.Text, 1, 1)
                    Case "1"
                        'EindeAfschrijving()
                    Case "2"
                        SS99("1", 64)
                    Case "0"
                    Case Else
                        MsgBox("Stop")
                End Select
                TransCommit()
                ButtonEraseAll.PerformClick()
            End If
        End If

    End Sub

    Private Sub ButtonAddLine_Click(sender As Object, e As EventArgs) Handles ButtonAddLine.Click

        Dim TextLine As String
        If RTrim(TextBoxLedgerAccount.Text) = "" Then
            Beep()
            TextBoxLedgerAccount.Focus()
            Exit Sub
        ElseIf Val(TextBoxAmount.Text) = 0 Then
            Beep()
            TextBoxAmount.Focus()
            Exit Sub
        ElseIf CheckBoxDCFlag.CheckState Then
            If RTrim(TextBoxOffsetAccount.Text) = "" Then
                Beep()
                TextBoxOffsetAccount.Focus()
                Exit Sub
            End If
        End If
        TotalDCAmount = Val(TextBoxAmount.Text)
        If DebitChoosen.Checked Then
        ElseIf CheckBoxDCFlag.Checked Then
        Else
            TotalDCAmount = -TotalDCAmount
        End If
        TextLine = SetSpacing((TextBoxLedgerAccount.Text), 7) & " " & SetSpacing((LabelLedgerAccountName.Text), 40) & " " & Dec(TotalDCAmount, MaskEURBH) & " "
        If CheckBoxDCFlag.CheckState Then
            TextLine &= SetSpacing((TextBoxOffsetAccount.Text), 7)
        Else
            TextLine &= Space(7)
        End If
        ListBoxJournalEntries.Items.Add(TextLine)
        CheckDCStatus()
        CleanUpNextLine()
        DebitChoosen.Focus()

    End Sub

    Private Sub ButtonEraseAll_Click(sender As Object, e As EventArgs) Handles ButtonEraseAll.Click

        CleanUpNextLine()
        ButtonBookEntries.Enabled = False
        TextBoxDescription.Text = ""
        LabelSoldeAmount.Text = "0"
        ListBoxJournalEntries.Items.Clear()
        ComboBoxBookType.Enabled = True
        ComboBoxBookType.SelectedIndex = 0
        ButtonClose.Enabled = True
        DebitChoosen.Enabled = True
        CreditChoosen.Enabled = True
        TextBoxAmount.Visible = True
        TextBoxLedgerAccount.Visible = True
        CheckBoxDCFlag.Enabled = True
        ComboBoxBookType.Focus()

    End Sub

    Private Sub CheckBoxDCFlag_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxDCFlag.CheckStateChanged
        ToggleOffsetAccount()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        If ListBoxJournalEntries.Items.Count Then
            Msg = Format(ListBoxJournalEntries.Items.Count) & " Journaallijnen negeren.  Bent U zeker ?"
            Ktrl = MsgBox(Msg, 292, "Inbreng Journaalpost")
            If Ktrl <> 6 Then
                Exit Sub
            End If
        End If
        Mim.JournalEntryInputMenuItem.Enabled = True
        Close()
    End Sub

    Private Sub ComboBoxBookType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxBookType.KeyPress
        If e.KeyChar = vbCr Then TextBoxDescription.Focus()
    End Sub

    Private Sub ComboBoxBookType_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBoxBookType.SelectedIndexChanged

    End Sub

    Private Sub DebitChoosen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DebitChoosen.KeyPress
        Dim keyString As String = UCase(e.KeyChar)
        DCChoiceCheck(e.KeyChar)
    End Sub

    Private Sub CreditChoosen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CreditChoosen.KeyPress
        Dim keyString As String = UCase(e.KeyChar)
        DCChoiceCheck(e.KeyChar)
    End Sub

    Private Sub TextBoxDescription_Enter(sender As Object, e As EventArgs) Handles TextBoxDescription.Enter
        ComboBoxBookType.Enabled = False
    End Sub

    Private Sub TextBoxDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxDescription.KeyPress
        If e.KeyChar = vbCr Then SendKeys.Send("{TAB}")
    End Sub

    Private Sub TextBoxAmount_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAmount.TextChanged
        If TextBoxAmount.Text <> "" Then
            ButtonAddLine.Enabled = True
            AcceptButton = ButtonAddLine
        Else
            ButtonAddLine.Enabled = False
        End If
    End Sub

    Private Sub TextBoxAmount_Enter(sender As Object, e As EventArgs) Handles TextBoxAmount.Enter
        If Val(LabelSoldeAmount.Text) = 0 Then
            ButtonBookEntries.Enabled = True
        Else
            ButtonBookEntries.Enabled = False
        End If
    End Sub

    Private Sub TextBoxLedgerAccount_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxLedgerAccount.KeyDown
        If e.KeyCode = 17 Then
            If LedgerAccountOk(TextBoxLedgerAccount, LabelLedgerAccountName) Then
                SendKeys.Send("{TAB}")
            Else
                TextBoxLedgerAccount.Focus()
            End If
        End If
    End Sub

    Private Sub TextBoxLedgerAccount_Leave(sender As Object, e As EventArgs) Handles TextBoxLedgerAccount.Leave
        If Trim(TextBoxLedgerAccount.Text) = "" Then
        Else
            JetGet(TableOfLedgerAccounts, 0, TextBoxLedgerAccount.Text)
            If Ktrl Then
                TextBoxLedgerAccount.Focus()
                Beep()
            Else
                RecordToField(TableOfLedgerAccounts)
                TextBoxLedgerAccount.Text = AdoGetField(TableOfLedgerAccounts, "#v019 #")
                LabelLedgerAccountName.Text = AdoGetField(TableOfLedgerAccounts, "#v020 #")
            End If
        End If
    End Sub

    Private Sub TextBoxOffsetAccount_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxOffsetAccount.KeyDown
        If e.KeyCode = 17 Then
            If LedgerAccountOk(TextBoxOffsetAccount, LabelOffsetAccountName) Then
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Else
                TextBoxOffsetAccount.Focus()
            End If
        End If
    End Sub

    Private Sub TextBoxOffsetAccount_Leave(sender As Object, e As EventArgs) Handles TextBoxOffsetAccount.Leave
        If Trim(TextBoxOffsetAccount.Text) = "" Then
        Else
            JetGet(TableOfLedgerAccounts, 0, TextBoxOffsetAccount.Text)
            If Ktrl Then
                TextBoxOffsetAccount.Focus()
                Beep()
            Else
                RecordToField(TableOfLedgerAccounts)
                TextBoxOffsetAccount.Text = AdoGetField(TableOfLedgerAccounts, "#v019 #")
                LabelOffsetAccountName.Text = AdoGetField(TableOfLedgerAccounts, "#v020 #")
            End If
        End If
    End Sub
End Class