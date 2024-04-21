Public Class FormBookingControl
    Private Sub BtnCancelTransaction_Click(sender As Object, e As EventArgs) Handles BtnCancelTransaction.Click

        DKTRL_CUMUL = 99
        Close()

    End Sub

    Private Sub BtnCommitTransaction_Click(sender As Object, e As EventArgs) Handles BtnCommitTransaction.Click

        Close()

    End Sub
End Class