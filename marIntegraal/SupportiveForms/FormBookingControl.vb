Public Class FormBookingControl
    Private Sub cmdBoeken_Click(sender As Object, e As EventArgs) Handles BtnBookIt.Click
        Close()
    End Sub

    Private Sub cmdNegeren_Click(sender As Object, e As EventArgs) Handles BtnIgnoreBooking.Click
        DKTRL_CUMUL = 99
        Close()
    End Sub
End Class