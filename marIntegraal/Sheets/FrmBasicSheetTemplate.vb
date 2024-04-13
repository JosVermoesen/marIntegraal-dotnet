Option Strict Off
Option Explicit On
Public Class FrmBasicSheetTemplate
    Dim lastKey As String
    Dim hierFl As Integer
    Private Sub NieuweFiche()
        Dim xTMP As Integer

        xTMP = AdoNewRecord(hierFl)

        'codeTextBox.Text = ""
        InsertFlag(hierFl) = 1
        'Knop(5).Enabled = False
        'VB6.SetDefault(Knop(5), True)
        'codeTextBox.Enabled = True

    End Sub
    Private Sub RecordNaarFiche()

        On Error Resume Next
        TLBRecord(hierFl) = ""
        If Ktrl Then
            MsgBox("stop")
        Else
            RecordToField(hierFl)
        End If
        lastKey = AdoGetField(hierFl, "#" & JetTableUseIndex(hierFl, 0) & "#")
        codeTextBox.Text = lastKey
        InsertFlag(Fl) = 0

    End Sub
    Private Sub FicheNaarRecord()

        JetGet(hierFl, 0, SetSpacing(codeTextBox.Text, FlIndexLen(hierFl, 0)))
        If Ktrl = 0 Then
            bUpdate(hierFl, 0)
        Else
            JetInsert(hierFl, 0)
        End If

    End Sub
    Private Sub frmBasisFiche_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        hierFl = Val(Tag)

        If sorteringComboBox.Items.Count Then
        Else
            For T = 0 To FlAantalIndexen(hierFl)
                Dim sortOmsString As String = Format(T, "00") & ":" & FLIndexCaption(hierFl, T)
                Dim sortveldString As String = Trim(JetTableUseIndex(hierFl, T))
                sorteringComboBox.Items.Add(sortOmsString & " (" & sortveldString & ")")
            Next
            If sorteringComboBox.Items.Count > 0 Then
                sorteringComboBox.SelectedIndex = 1
            End If
        End If

    End Sub
    Private Sub minimaliseerButton_Click(sender As Object, e As EventArgs) Handles minimaliseerButton.Click

        WindowState = FormWindowState.Minimized

    End Sub
    Private Sub topButton_Click(sender As Object, e As EventArgs) Handles topButton.Click

        JetGetFirst(hierFl, 0)
        If Ktrl Then
            Beep()
            bewerkenButton.Enabled = False
        Else
            RecordNaarFiche()
            bewerkenButton.Enabled = True
            lagerButton.Visible = False
            hogerButton.Visible = True
        End If

    End Sub
    Private Sub bodemButton_Click(sender As Object, e As EventArgs) Handles bodemButton.Click

        bLast(hierFl, 0)
        If Ktrl Then
            Beep()
            bewerkenButton.Enabled = False
        Else
            RecordNaarFiche()
            bewerkenButton.Enabled = True
            lagerButton.Visible = True
            hogerButton.Visible = False
        End If

    End Sub
    Private Sub lagerButton_Click(sender As Object, e As EventArgs) Handles lagerButton.Click

        bPrev(hierFl, 0, lastKey)
        If Ktrl Then
            Beep()
            bewerkenButton.Enabled = False
            lagerButton.Visible = False
        Else
            RecordNaarFiche()
            bewerkenButton.Enabled = True
            hogerButton.Visible = True
        End If

    End Sub
    Private Sub hogerButton_Click(sender As Object, e As EventArgs) Handles hogerButton.Click

        bNext(hierFl, 0, lastKey)
        If Ktrl Then
            Beep()
            bewerkenButton.Enabled = False
            hogerButton.Visible = False
        Else
            RecordNaarFiche()
            bewerkenButton.Enabled = True
            lagerButton.Visible = True
        End If

    End Sub
    Private Sub zoekenOpButton_Click(sender As Object, e As EventArgs) Handles zoekenOpButton.Click

        SharedFl = hierFl
        If codeTextBox.Text <> "" Then
            SharedIndex = 0
        ElseIf codeTextBox.Text = lastKey Then
            SharedIndex = Val(Mid(sorteringComboBox.Text, 2))
        End If

        GridText = codeTextBox.Text
        XLogKey = ""
        SqlSearch.ShowDialog()
        SqlSearch.Dispose()

        If Ktrl = 0 Then
            lastKey = XLogKey
            codeTextBox.Text = lastKey
            RecordNaarFiche()
            bewerkenButton.Enabled = True
            AcceptButton = bewerkenButton
        Else
            AcceptButton = zoekenOpButton
            bewerkenButton.Enabled = False
            lastKey = ""
            codeTextBox.Text = lastKey
            InsertFlag(hierFl) = 1
        End If

    End Sub

    Private Sub codeTextBox_TextChanged(sender As Object, e As EventArgs) Handles codeTextBox.TextChanged

        If codeTextBox.Text = "" Then
            AcceptButton = zoekenOpButton
        Else
            AcceptButton = bewerkenButton
        End If


    End Sub

    Private Sub bewerkenButton_Click(sender As Object, e As EventArgs) Handles bewerkenButton.Click
        Dim teZoeken As String

        teZoeken = Trim(codeTextBox.Text)
        If TeZoeken = "" Then Beep() : Exit Sub
        JetGet(hierFl, 0, teZoeken)
        If Ktrl = 0 Then
            RecordNaarFiche()
        Else
            NieuweFiche()
            codeTextBox.Text = teZoeken
        End If
        'If Fl = TableOfLedgerAccounts Then DbKontrole((TekstInfo(0).Text), TableOfLedgerAccounts)

        If InsertFlag(hierFl) = 1 Then 'nieuwe fiche
            Select Case hierFl
                Case TableOfCustomers, TableOfSuppliers
                    AdoInsertToRecord(hierFl, codeTextBox.Text, "A110") 'Klant/Levnummer
                Case TableOfLedgerAccounts
                    AdoInsertToRecord(hierFl, codeTextBox.Text, "v019") 'Rekeningnummer
                Case Else
                    MsgBox("Stop")
            End Select
        End If

        If TeleBibClick(hierFl) = False Then
            'Knop(1).Enabled = False
        Else
            'Knop(1).Enabled = True
            'Knop(1).SetFocus
            FicheNaarRecord()
        End If
        'Knop_Click 3
        'Knop(5).Enabled = True
    End Sub

    Private Sub codeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles codeTextBox.KeyPress

        InsertFlag(hierFl) = 1 : bewerkenButton.Enabled = True : AcceptButton = bewerkenButton

    End Sub

    Private Sub codeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles codeTextBox.KeyDown

        InsertFlag(hierFl) = 1 : bewerkenButton.Enabled = True : AcceptButton = bewerkenButton

    End Sub
End Class