Option Strict Off
Option Explicit On
Public Class FormCompanyOpen
    Dim flgVerwijderen As Boolean
    Dim strDataLocatie As String

    Private Sub frmBedrijfOpenen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flgVerwijderen = False

        Top = 0
        Left = 0

        LvCompanies.Columns.Add("Benaming", 400, HorizontalAlignment.Left)
        LvCompanies.Columns.Add("Map", -2, HorizontalAlignment.Right)
        LvCompanies.View = View.Details

        strDataLocatie = SettingLoading("BedrijfOpenen", "DataDefault")
        If Trim(strDataLocatie) = "" Then
            strDataLocatie = "lokaal"
        End If
        If strDataLocatie = "server" Then
            RbServerData.Checked = True
        Else
            RbLocalData.Checked = True
        End If

        VSF_PRO = False
        Err.Clear()
        On Error Resume Next
        'dlbFolder.path = LOCATION
        If Err.Number Then
            MsgBox("LOCATION bedrijven onvindbaar.  Kontroleer manueel a.u.b.", MsgBoxStyle.Critical)
        Else
            KeuzeLijstVullen()
        End If
    End Sub

    Private Sub sluitenButton_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Mim.CompanyOpenMenuItem.Enabled = True
        Mim.CompanyNewMenuItem.Enabled = True
        Close()
    End Sub
    Private Sub locatieButton_Click(sender As Object, e As EventArgs) Handles BtnToggle.Click
        TbDataLocation.Enabled = Not TbDataLocation.Enabled
        If TbDataLocation.Enabled = True Then
            TbDataLocation.Focus()
        Else
            If RbLocalData.Checked = True Then
                If TbDataLocation.Text <> SettingLoading(My.Application.Info.Title, "Bedrijfsinhoudsopgave") Then
                    CTRL_BOX = MsgBox(TbDataLocation.Text & vbCrLf & vbCrLf & "Wordt dit de nieuwe 'lokale' opstartinhoudsopgave ?", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo)
                    If CTRL_BOX = MsgBoxResult.Yes Then
                        SettingSaving(My.Application.Info.Title, "Bedrijfsinhoudsopgave", TbDataLocation.Text)
                        MsgBox("Hierna wordt er afgesloten.  Start het programma opnieuw op")
                        End
                    Else
                        TbDataLocation.Text = SettingLoading(My.Application.Info.Title, "Bedrijfsinhoudsopgave")
                    End If
                End If
            Else
                If TbDataLocation.Text <> SettingLoading(My.Application.Info.Title, "ServerBedrijfsinhoudsopgave") Then
                    CTRL_BOX = MsgBox(TbDataLocation.Text & vbCrLf & vbCrLf & "Wordt dit de nieuwe 'server' opstartinhoudsopgave ?", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo)
                    If CTRL_BOX = MsgBoxResult.Yes Then
                        SettingSaving(My.Application.Info.Title, "ServerBedrijfsinhoudsopgave", TbDataLocation.Text)
                        MsgBox("Hierna wordt er afgesloten.  Start het programma opnieuw op")
                        End
                    Else
                        TbDataLocation.Text = SettingLoading(My.Application.Info.Title, "ServerBedrijfsinhoudsopgave")
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub localdataRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RbLocalData.CheckedChanged

        If RbServerData.Checked = True Then
            TbDataLocation.Text = SettingLoading(My.Application.Info.Title, "ServerBedrijfsinhoudsopgave") 'Server anders
            SettingSaving("BedrijfOpenen", "DataDefault", "server")
            BtnCompactDatabase.Enabled = False
            BtnMakeDeletePossible.Enabled = False
            BtnOneDriveBackup.Enabled = False
        Else
            TbDataLocation.Text = SettingLoading(My.Application.Info.Title, "Bedrijfsinhoudsopgave") 'Lokaal is standaard
            SettingSaving("BedrijfOpenen", "DataDefault", "lokaal")
            BtnCompactDatabase.Enabled = True
            BtnMakeDeletePossible.Enabled = True
            BtnOneDriveBackup.Enabled = True
        End If
        ModLibs.LOCATION = TbDataLocation.Text & "\"
        'TODO: KeuzeLijstVullen()
    End Sub

    Private Sub serverdataRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RbServerData.CheckedChanged
        If RbServerData.Checked = True Then
            TbDataLocation.Text = SettingLoading(My.Application.Info.Title, "ServerBedrijfsinhoudsopgave") 'Server anders
            SettingSaving("BedrijfOpenen", "DataDefault", "server")
            BtnCompactDatabase.Enabled = False
            BtnMakeDeletePossible.Enabled = False
            BtnOneDriveBackup.Enabled = False
        Else
            TbDataLocation.Text = SettingLoading(My.Application.Info.Title, "Bedrijfsinhoudsopgave") 'Lokaal is standaard
            SettingSaving("BedrijfOpenen", "DataDefault", "lokaal")
            BtnCompactDatabase.Enabled = True
            BtnMakeDeletePossible.Enabled = True
            BtnOneDriveBackup.Enabled = True
        End If
        ModLibs.LOCATION = TbDataLocation.Text & "\"
        KeuzeLijstVullen()
    End Sub

    Sub KeuzeLijstVullen()
        Dim FlTemp As Short

        Dim A As String
        Dim NaamDetail As String

        Dim MyPath As String
        Dim MyName As String


        LvCompanies.Items.Clear()

        MyPath = TbDataLocation.Text & "\" 'LOCATION ' Set the path.

        Err.Clear()
        On Error Resume Next
        'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        MyName = Dir(MyPath, FileAttribute.Directory) ' Retrieve the first entry.
        If Err.Number Then Exit Sub
        Do While MyName <> "" ' Start the loop.
            ' Ignore the current directory and the encompassing directory.
            If MyName <> "." And MyName <> ".." Then
                ' Use bitwise comparison to make sure MyName is a directory.
                If (GetAttr(MyPath & MyName) And FileAttribute.Directory) = FileAttribute.Directory Then
                    On Error Resume Next
                    Err.Clear()
                    FlTemp = FreeFile()
                    FileOpen(FlTemp, MyPath & MyName & "\marnt.txt", OpenMode.Input)
                    If Err.Number Then
                    Else
                        A = LineInput(FlTemp)
                        FileClose(FlTemp)
                        NaamDetail = A
                        ' Add a ListItem object.
                        Dim itemHier As New ListViewItem(NaamDetail)
                        itemHier.SubItems.Add(MyName)
                        LvCompanies.Items.Add(itemHier)
                    End If
                End If ' it represents a directory.
            End If
            'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            MyName = Dir() ' Get next entry.
        Loop

    End Sub



    Private Sub bedrijvenListView_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LvCompanies.KeyPress

        If e.KeyChar = vbCr Then
            StartAutoLoad()
        End If

    End Sub

    Private Sub StartAutoLoad()

        LOCATION_COMPANYDATA = ModLibs.LOCATION & LvCompanies.FocusedItem.SubItems.Item(1).Text & "\"
        MAR_VERSION = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision
        Mim.Text = "marIntegraal.NET " & MAR_VERSION & " - [" & Trim(LvCompanies.FocusedItem.Text) & "]"

        AutoLoadCompany(BYPERDAT:=FormBYPERDAT)
        BtnCancel.PerformClick()

    End Sub

    Private Sub BtnCompactDatabase_Click(sender As Object, e As EventArgs) Handles BtnCompactDatabase.Click

    End Sub

    Private Sub BtnOneDriveBackup_Click(sender As Object, e As EventArgs) Handles BtnOneDriveBackup.Click

    End Sub

    Private Sub BtnMakeDeletePossible_Click(sender As Object, e As EventArgs) Handles BtnMakeDeletePossible.Click

    End Sub

    Private Sub LvCompanies_DoubleClick(sender As Object, e As EventArgs) Handles LvCompanies.DoubleClick

        StartAutoLoad()

    End Sub
End Class