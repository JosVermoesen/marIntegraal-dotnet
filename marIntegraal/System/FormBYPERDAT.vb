Option Strict Off
Option Explicit On
Public Class FormBYPERDAT
    Private Sub Verkleinen_Click(sender As Object, e As EventArgs) Handles Verkleinen.Click

        WindowState = FormWindowState.Minimized

    End Sub
    Private Sub DatumVerwerking_ValueChanged(sender As Object, e As EventArgs) Handles DatumVerwerking.ValueChanged

        MIM_GLOBAL_DATE = Format(DatumVerwerking.Value, "dd/MM/yyyy")

    End Sub
    Private Sub Boekjaar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Boekjaar.SelectedIndexChanged

        Dim A As String
        Dim XX As String
        Dim FlTemp As Short
        Dim AktievePeriode As Short
        Dim T As Short
        Dim PeriodeMeestLogisch As Short
        Dim periodesBJ() As String
        Dim c As String

        PeriodeMeestLogisch = -1
        If ACTIVE_BOOKYEAR <> Boekjaar.SelectedIndex Then
            JetTableClose(99)
            TABLEDEF_ONT(TABLE_COUNTERS) = Format(Boekjaar.SelectedIndex, "00") & ".ONT"
            JET_TABLENAME(TABLE_COUNTERS) = "jr" & Boekjaar.Text
            CloseOpenWindows()
            ACTIVE_BOOKYEAR = Boekjaar.SelectedIndex
            AktievePeriode = 1
            PeriodeBoekjaar.Items.Clear()

            FlTemp = FreeFile()
            FileOpen(FlTemp, LOCATION_COMPANYDATA & "DEF" & Format(ACTIVE_BOOKYEAR, "00") & ".OXT", OpenMode.Input)
            c = LineInput(FlTemp)
            periodesBJ = Split(c, ",")
            FileClose(FlTemp)

            For T = 0 To UBound(periodesBJ)
                A = periodesBJ(T)
                If T = 0 Then
                    BOOKYEAR_FROMTO = Mid(A, 1, 8)
                ElseIf T = UBound(periodesBJ) then
                    BOOKYEAR_FROMTO = BOOKYEAR_FROMTO + Mid (A, 9, 8)
                End If
                
                XX = Mid(A, 7, 2) & "/" & Mid(A, 5, 2) & "/" & Mid(A, 1, 4) & " - " & Mid(A, 15, 2) & "/" & Mid(A, 13, 2) & "/" & Mid(A, 9, 4)
                PeriodeBoekjaar.Items.Add(XX)
            Next
            If Boekjaar.SelectedIndex > 0 Then
                PeriodeBoekjaar.SelectedIndex = PeriodeBoekjaar.Items.Count - 1
            End If

            XisEUROWasBEF = False
            If Len(String99(READING, 296)) = 0 Then
                MsgBox("Gelieve Setup Boekingen en algemene instellingen : munt van de Boekhouding in te stellen a.u.b.  Pér bedrijf, pér boekjaar.  Hierna wordt voorlopig verder gewerkt in BEF.")
                BH_EURO = False
            ElseIf String99(READING, 296) = "BEF" Then
                BH_EURO = False
            ElseIf String99(READING, 296) = "EUR" Then
                BH_EURO = True
            Else
                BH_EURO = False
            End If
            If BH_EURO Then
                XisEUROWasBEF = False
            Else
                If XisEUROWasBEF = True And Boekjaar.SelectedIndex = 1 Then
                Else
                    XisEUROWasBEF = False
                End If
            End If
            If Boekjaar.SelectedIndex = 1 And BH_EURO = False Then
                MSG = "Dit bedrijf heeft een boekjaar -1 met verwerking in BEF.  Indien U nog boekingen in BEF wenst uit te voeren voor het zopas aangeduide boekjaar, gelieve een vorige versie (6.5.300 of lager) opnieuw te installeren a.u.b."
                MsgBox(MSG, MsgBoxStyle.Exclamation)
            End If
        End If

    End Sub
    Private Sub PeriodeBoekjaar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PeriodeBoekjaar.SelectedIndexChanged

        Dim A As String
        Dim aA As String = ""

        Dim fullPath = LOCATION_COMPANYDATA & "9999.OXT"
        Dim FlFree As Integer
        FlFree = FreeFile()
        FileOpen(FlFree, fullPath, OpenMode.Output)
        A = PeriodeBoekjaar.Text
        PERIOD_FROMTO = Mid(A, 7, 4) & Mid(A, 4, 2) & Mid(A, 1, 2) & Mid(A, 20, 4) & Mid(A, 17, 2) & Mid(A, 14, 2)
        aA = Trim(Str(ACTIVE_BOOKYEAR)) & ","
        aA = aA & Boekjaar.Text & ","
        aA = aA & Trim(Str(PeriodeBoekjaar.SelectedIndex + 1))
        PrintLine(FlFree, aA)
        FileClose(FlFree)
        Text = "(" & Boekjaar.Text & ") (" & Mid(PeriodeBoekjaar.Text, 1, 10) & ") BoekPeriode"

    End Sub
End Class