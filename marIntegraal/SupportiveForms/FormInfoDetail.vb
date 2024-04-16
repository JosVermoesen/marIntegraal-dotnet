Public Class FormInfoDetail

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click

        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Width = Val(TextBox1.Text)

    End Sub

    Private Sub FormInfoDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = Width

    End Sub
End Class