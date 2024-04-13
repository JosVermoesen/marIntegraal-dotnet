Public Class Boeking
    Private Sub cmdBoeken_Click(sender As Object, e As EventArgs) Handles cmdBoeken.Click
        Close()
    End Sub

    Private Sub cmdNegeren_Click(sender As Object, e As EventArgs) Handles cmdNegeren.Click
        dKtrlCumul = 99
        Close()
    End Sub
End Class