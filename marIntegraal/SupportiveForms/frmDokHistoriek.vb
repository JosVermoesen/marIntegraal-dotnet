Public Class frmDokHistoriek
    Private Sub frmDokHistoriek_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dim X As Boolean
        X = SettingsSaving(Me)
    End Sub
    Private Sub frmDokHistoriek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SettingsLoading(Me)
    End Sub
End Class