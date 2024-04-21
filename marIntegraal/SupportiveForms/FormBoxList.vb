Option Strict Off
Option Explicit On
Public Class FormBoxList

    Private Sub FormChooseList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim X As String
        Dim ZoekTekst As String
        Dim Aantallijnen As Short
        Dim Keuze As Short
        Dim OptieTxt As String
        OptieTxt = GRIDTEXT
        LbBoxList.Items.Clear()
        ZoekTekst = "NTKB2"
        If SHARED_INDEX >= 1000 Then
            ZoekTekst &= Format(SHARED_INDEX - 1000, "000")
        Else
            ZoekTekst = ZoekTekst & "9" & Format(SHARED_INDEX, "00")
        End If
        Keuze = -1
        X = ZoekEnPlaats((LbBoxList), ZoekTekst, Aantallijnen, Keuze, GRIDTEXT)
        If Keuze = -1 Then
        Else
            LbBoxList.SelectedIndex = Keuze
        End If

    End Sub

    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click

        GRIDTEXT = LbBoxList.Text
        Close()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        GRIDTEXT = ""
        Close()

    End Sub

    Private Sub LbBoxList_DoubleClick(sender As Object, e As EventArgs) Handles LbBoxList.DoubleClick

        BtnAccept.PerformClick()
    End Sub

    Private Sub LbBoxList_KeyDown(sender As Object, e As KeyEventArgs) Handles LbBoxList.KeyDown

        If e.KeyCode = 27 Then BtnCancel.PerformClick()

    End Sub
End Class