Option Strict Off
Option Explicit On
Public Class KeuzeVSF
    Private Sub KeuzeVSF_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim X As String
        Dim ZoekTekst As String
        Dim Aantallijnen As Short
        Dim Keuze As Short
        Dim OptieTxt As String
        OptieTxt = GridText
        NTBoxLijst.Items.Clear()
        ZoekTekst = "NTKB2"
        If SharedIndex >= 1000 Then
            ZoekTekst = ZoekTekst & Format(SharedIndex - 1000, "000")
        Else
            ZoekTekst = ZoekTekst & "9" & Format(SharedIndex, "00")
        End If
        Keuze = -1
        X = ZoekEnPlaats((NTBoxLijst), ZoekTekst, Aantallijnen, Keuze, GridText)
        If Keuze = -1 Then
        Else
            NTBoxLijst.SelectedIndex = Keuze
        End If
    End Sub
    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        GridText = NTBoxLijst.Text
        Close()
    End Sub
    Private Sub negerenButton_Click(sender As Object, e As EventArgs) Handles negerenButton.Click
        GridText = ""
        Close()
    End Sub
    Private Sub NTBoxLijst_DoubleClick(sender As Object, e As EventArgs) Handles NTBoxLijst.DoubleClick
        okButton.PerformClick()
    End Sub
    Private Sub NTBoxLijst_KeyDown(sender As Object, e As KeyEventArgs) Handles NTBoxLijst.KeyDown
        If e.KeyCode = 27 Then negerenButton.PerformClick()
    End Sub
End Class