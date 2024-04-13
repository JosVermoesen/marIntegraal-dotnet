Option Strict Off
Option Explicit On

Imports System.ComponentModel

Public Class HistoriekRekeningScherm
    Dim RekeningNummer As String
    Dim PositieStelsel As Integer 

    Dim Van As String
    Dim Tot As String

    Dim dTotaalSaldo As Decimal

    Dim rsJourHier As ADODB.Recordset

    Private Sub HistoriekRekeningScherm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Top=0
        Left=0

        lvJournaalDetail.View = View.Details
        With lvJournaalDetail.Columns
            .Add("Document", 75, HorizontalAlignment.Left)
            .Add("Datum Doc.", 70, HorizontalAlignment.Left)
            .Add("Fin.Stuk", 63, HorizontalAlignment.Left)
            .Add("Omschrijving", 162, HorizontalAlignment.Left)
            .Add("EUR", 64, HorizontalAlignment.Right)
            .Add("BEF", 57, HorizontalAlignment.Right)
            .Add("T.Rek", 63, HorizontalAlignment.Left)            
        End With

        TxtLijnen.Text = "300" 'LaadTekst("HistoriekInScherm", "MaxLijnen")
        tbVanTot.Text = FunctionDateText(mid(BookyearFromTo, 1, 8)) & " - " & FunctionDateText(Mid(BookyearFromTo, 9, 8))

        ' Set up the delays for the ToolTip.
        ' Force the ToolTip text to be displayed whether or not the form is active.
        Dim toolTip As New ToolTip With {
            .AutoPopDelay = 5000,
            .InitialDelay = 1000,
            .ReshowDelay = 500,
            .ShowAlways = True
        }

        ' Set up the ToolTip text for the Button and Checkbox.
        toolTip.SetToolTip(control:=tbRekening, caption:="[CTRL] om te zoeken")
        
        tbRekening.Text = ""
        Try
            tbRekening.Text = trim(BasisB(TableOfLedgerAccounts).codeTextBox.Text )
        Catch ex As Exception
            
        End Try

        If tbRekening.Text= "" Then
        Else
            Me.Text = "Historiek (" & RTrim(AdoGetField(TableOfLedgerAccounts, "#v020 #")) & ")"
            btnSearch.PerformClick 
        End If		

    End Sub
    
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close

    End Sub

    Private Sub HistoriekRekeningScherm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Mim.LedgerHistoryOnScreenMenuItem.Enabled = True 

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim aa As String
        Dim T As Integer 
        Dim maxLijn As Integer 
        Dim Zoekverder As Boolean

        Zoekverder = False
        lvJournaalDetail.Items.Clear 

        LblSaldo.Text = ""

        T = 0
        dTotaalSaldo = 0

        maxLijn = CDbl(TxtLijnen.Text) + 2
        RekeningNummer = SetSpacing(tbRekening.Text, 7)
        Van = RekeningNummer & Mid(tbVanTot.Text, 7, 4) & Mid(tbVanTot.Text, 4, 2) & Mid(tbVanTot.Text, 1, 2)
        Tot = RekeningNummer & Mid(tbVanTot.Text, 20, 4) & Mid(tbVanTot.Text, 17, 2) & Mid(tbVanTot.Text, 14, 2)

GetIt: 
        JetGet(TableOfLedgerAccounts, 0, RekeningNummer)
        If Ktrl Then
            Me.Text = "Historiek"
        Else
            RecordToField(TableOfLedgerAccounts)
            Me.Text = "Historiek (" & Trim(rsMAR(TableOfLedgerAccounts).Fields("v020").Value) & ")"
            lvJournaalDetail.Visible = False
            Me.Refresh()
        End If

        'recordset maken
        Dim sSQL As String
        sSQL = "SELECT * FROM Journalen WHERE v070 >='" & Van & "' AND v070 <= '" & Tot & "'"

        ' Create a recordset using the provided collection
        rsJourHier = New ADODB.Recordset With {
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
        }
        rsJourHier.Open(sSQL, adntDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        If rsJourHier.RecordCount < 1 Then
            lvJournaalDetail.Items.Clear 
            GoTo JournaalJump
        Else
            'RecordToField FlJournaal
            tbRekening.Text = rsJourHier.Fields("v019").Value
            Mid(Van, 1, 7) = Mid(rsJourHier.Fields("v070").Value, 1, 7)
            Mid(Tot, 1, 7) = Mid(rsJourHier.Fields("v070").Value, 1, 7)
            JetGet(TableOfLedgerAccounts, 0, rsJourHier.Fields("v019").Value.ToString)
            If Ktrl Then
                Me.Text = "Historiek"
            Else
                RecordToField(TableOfLedgerAccounts)
                Me.Text = "Historiek (" & Trim(rsMAR(TableOfLedgerAccounts).Fields("v020").Value) & ")"
            End If
            rsJourHier.MoveFirst 
            Do While Not rsJourHier.EOF
                'Lijst opmaken
                Dim dataVeld As String = rsJourHier.Fields("v033").Value.ToString 
                Dim itemHier As New ListViewItem(dataVeld)
                With itemHier.SubItems
                    .Add (FunctionDateText(rsJourHier.Fields("v035").Value.ToString))
                    .Add (rsJourHier.Fields("v038").Value.ToString)
                    .Add (rsJourHier.Fields("v067").Value.ToString)
                    .Add (Format(rsJourHier.Fields("dece068").Value, "#,##0.00"))
                    .Add (Format(Euro * rsJourHier.Fields("dece068").Value, "#,##0"))
                    .Add (rsJourHier.Fields("v069").Value.ToString)
                End With
                lvJournaalDetail.Items.Add(itemHier)	
                dTotaalSaldo = dTotaalSaldo + rsJourHier.Fields("dece068").Value
                
                If lvJournaalDetail.Items.Count >= maxLijn Then
                    If Zoekverder Then
                    Else
                        Msg = "Meer dan " & Format(maxLijn - 2) & " journaallijnen.  Enkel de eerste " & Format(maxLijn - 2) & " tonen ?"
                        KtrlBox = MsgBox(Msg, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1)
                        If KtrlBox = MsgBoxResult.Yes Then
                            GoTo JournaalJump 
                        Else
                            Zoekverder = True
                        End If
                    End If
                End If
                rsJourHier.MoveNext()
            Loop
        End If
        rsJourHier.Close()

JournaalJump: 
        LblSaldo.Text = Format(dTotaalSaldo, "#,##0.00")
        lvJournaalDetail.Visible = True
        On Error Resume Next
        lvJournaalDetail.Focus
    End Sub

    Private Sub HistoriekRekeningScherm_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        'BeWaarTekst("HistoriekInScherm", "MaxLijnen", TxtLijnen.Text)
        'Bewaar ook de kolomgrootte van de listview

    End Sub

    Private Sub tbRekening_KeyDown(sender As Object, e As KeyEventArgs) Handles tbRekening.KeyDown
        
        If e.KeyCode = 17 Then
            SharedFl = TableOfLedgerAccounts 
            SharedIndex = 0
            GridText = tbRekening.Text
            XLogKey = ""
            SqlSearch.ShowDialog()
            SqlSearch.Dispose()
            If Ktrl = 0 Then
                tbRekening.Text = XLogKey 
                btnSearch.PerformClick 			
            End If
        End If

    End Sub

    Private Sub tbVanTot_Leave(sender As Object, e As EventArgs) Handles tbVanTot.Leave

        
        If DateWrongFormat(Mid(tbVanTot.Text, 14, 10)) Then
            MsgBox("Respecteer : " & vbCrLf & vbCrLf & "DD/MM/EEJJ - DD/MM/EEJJ a.u.b. !")
            If GansePeriode.CheckState Then
                tbVanTot.Text = FunctionDateText(Mid(BookyearFromTo, 1, 8)) & " - " & FunctionDateText(Mid(BookyearFromTo, 9, 8))
            Else
                tbVanTot.Text = FunctionDateText(Mid(PeriodFromTo, 1, 8)) & " - " & FunctionDateText(Mid(PeriodFromTo, 9, 8))
            End If
            tbVanTot.Focus()
            Exit Sub
        ElseIf Len(tbVanTot.Text) <> 23 Then 
            MsgBox("Respecteer : " & vbCrLf & vbCrLf & "DD/MM/EEJJ - DD/MM/EEJJ a.u.b. !")
            If GansePeriode.CheckState Then
                tbVanTot.Text = FunctionDateText(Mid(BookyearFromTo, 1, 8)) & " - " & FunctionDateText(Mid(BookyearFromTo, 9, 8))
            Else
                tbVanTot.Text = FunctionDateText(Mid(PeriodFromTo, 1, 8)) & " - " & FunctionDateText(Mid(PeriodFromTo, 9, 8))
            End If
            tbVanTot.Focus()
        Else
            btnSearch.PerformClick
        End If

    End Sub

    Private Sub tbRekening_TextChanged(sender As Object, e As EventArgs) Handles tbRekening.TextChanged

    End Sub
End Class
