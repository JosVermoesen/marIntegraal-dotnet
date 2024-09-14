Option Strict Off
Option Explicit On

Public Class FormExternalSettings
    Private Sub FormExternalSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxUrlCompany.Text = SettingLoading("marSettings", "UrlCompany")
        TextBoxMarntCloud.Text = SettingLoading("marSettings", "MarntCloud")
        TextBoxMarioCloud.Text = SettingLoading("marSettings", "MarioCloud")
        TextBoxArchiveCloud.Text = SettingLoading("marSettings", "ArchiveCloud")

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs)

        Close()

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs)

        SettingSaving("marSettings", "UrlCompany", TextBoxUrlCompany.Text)
        SettingSaving("marSettings", "MarntCloud", TextBoxMarntCloud.Text)
        SettingSaving("marSettings", "MarioCloud", TextBoxMarioCloud.Text)
        SettingSaving("marSettings", "ArchiveCloud", TextBoxArchiveCloud.Text)
        Me.Close()

    End Sub
End Class
