Public Class ntInputbox
    Private Sub frmNTInputbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Sluiten_Click(sender As Object, e As EventArgs) Handles Sluiten.Click

        Ktrl = 9
        TekstInfo.Text = Chr(255)

    End Sub

    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles Ok.Click

        On Error Resume Next

        TekstInfo.Focus()
        Ktrl = 0
        Hide()

    End Sub
End Class