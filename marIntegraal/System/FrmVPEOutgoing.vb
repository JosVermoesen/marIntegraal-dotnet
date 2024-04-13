Option Strict Off
Option Explicit On
Imports System.ComponentModel
Public Class LayOutpdfDokument
    Dim KopVoet As Short
    Dim TaalKode As Short
    Dim DocuType As Short
    Private Sub Inladen(ByRef TypeEnTaal As String)
        Dim FlFree As Short
        Dim pdfCmd As String

VPETEST:
        With Mim.Report
            .OpenDoc()
            .Author = "Jos Vermoesen"
            .GUILanguage = 3 'Nederlands
            .Title = "marIntegraal Rapport"
            '.nBottomMargin = 1 'deze margin geeft problemen
            .nTopMargin = 1
            .nLeftMargin = 1
            .nRightMargin = 1
            '.nBottomMargin = 1
            .GridVisible = True
        End With

        If Dir(LocationCompanyData & "pdfDDEF" & TypeEnTaal & ".Txt") = "" Then
            Beep()
            Mim.Report.CloseDoc()
            MsgBox("pdfDDEF" & TypeEnTaal & ".Txt niet gevonden in de bedrijfsinhoudsopgave. Hierna wordt een voorbeelddocument vanuit de programmainhoudsopgave gecopiëerd", MsgBoxStyle.Information)

            If Not CopyFile(My.Application.Info.DirectoryPath & "\Def", LocationCompanyData, "pdfDDEF" & TypeEnTaal & ".Txt") Then
                MsgBox(My.Application.Info.DirectoryPath & "\Def\pdfDDEF" & TypeEnTaal & ".Txt kan als voorbeelddocument niet vanuit de programmainhoudsopgave gecopiëerd worden.  Probeer eventueel manueel", MsgBoxStyle.Information)
            Else
                GoTo VPETEST
            End If
            Exit Sub
        Else
            FlFree = FreeFile()
            FileOpen(FlFree, LocationCompanyData & "pdfDDEF" & TypeEnTaal & ".Txt", OpenMode.Input)

            Do While Not EOF(FlFree)
                pdfCmd = LineInput(FlFree)
                If Mid(pdfCmd, 1, 1) = "'" Then
                ElseIf Mid(pdfCmd, 1, 1) = " " Then
                Else
                    Select Case Trim(UCase(pdfCmd))
                        Case "CMD-VSOFTSPACE"
                            CMDVSOFTSPACE(FlFree)
                        Case "CMD-ADRESSPACE"
                            CMDADRESSPACE(FlFree)
                        Case "CMD-WRITE"
                            'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
                            CMDWRITE(FlFree)
                        Case "CMD-WRITEBOX"
                            CMDWRITEBOX(FlFree)
                        Case "CMD-PRINT"
                            CMDPRINT(FlFree)
                        Case "CMD-PICTURE"
                            CMDPICTURE(FlFree)
                        Case Else
                            MsgBox(pdfCmd & " nog niet voorzien", MsgBoxStyle.Critical)
                    End Select
                End If
            Loop
            FileClose(FlFree)
            Mim.Report.WriteDoc(ProgramLocation & "marrapport.pdf")
            Mim.Report.Preview()
        End If
    End Sub
    Sub CMDVSOFTSPACE(flfree As Short)
        Dim vsoftVAN As Double
        Dim VsoftTot As Double

        On Error GoTo errorCMDVSOFTSPACE
        Input(flfree, vsoftVAN)
        Input(flfree, VsoftTot)
        Mim.Report.SelectFont("Courier New", 7.2)
        'Mim.Report.Font = VB6.FontChangeName(Mim.Report.Font, "Courier New")
        'Mim.Report.Font = VB6.FontChangeSize(Mim.Report.Font, 7.2)
        Mim.Report.TextColor = ColorTranslator.FromOle(RGB(192, 0, 0)) '= red!
        Mim.Report.TextBold = 0
        Mim.Report.TextItalic = 0
        Mim.Report.TextUnderline = 0
        Ktrl = Mim.Report.Print(1, vsoftVAN, FullLine) 'was vpeprint
        Ktrl = Mim.Report.Print(1, VsoftTot, FullLine)
        Exit Sub

errorCMDVSOFTSPACE:
        MsgBox("CMDVSOFTSPACE foutieve definitie")
    End Sub
    Sub CMDPICTURE(flfree As Short)
        Dim YPOS As Double
        Dim xPos As Double
        Dim YPOS2 As Double
        Dim xPos2 As Double
        Dim pdfBoxPen As Double
        Dim filename As String = ""

        On Error GoTo errorCMDPICTURE
        Input(flfree, xPos)
        Input(flfree, YPOS)
        Input(flfree, xPos2)
        Input(flfree, YPOS2)
        Input(flfree, pdfBoxPen)
        Input(flfree, filename)
        Mim.Report.PictureBestFit = True
        '2.5, 0.5, 19, 2.5
        If Mid(filename, 1, 4) = "[BL]" Then
            filename = LocationCompanyData & Mid(filename, 5)
        ElseIf Mid(filename, 1, 4) = "[PL]" Then
            filename = ProgramLocation & Mid(filename, 5)
        End If
        Ktrl = Mim.Report.Picture(xPos, YPOS, xPos2, YPOS2, filename)
        Exit Sub

errorCMDPICTURE:
        MsgBox("CMDPICTURE foutieve definitie")
    End Sub
    Sub CMDADRESSPACE(Flfree As Short)
        Dim adresYpos As Double
        Dim adresXpos As Double
        Dim adresYpos2 As Double
        Dim adresXpos2 As Double

        On Error GoTo errorCMDADRESSPACE
        Input(Flfree, adresXpos)
        Input(Flfree, adresYpos)
        Input(Flfree, adresXpos2)
        Input(Flfree, adresYpos2) ', adresBox
        Ktrl = Mim.Report.WriteBox(adresXpos, adresYpos, adresXpos2, adresYpos2, "")
        Exit Sub

errorCMDADRESSPACE:
        MsgBox("CMDADRESSPACE foutieve definitie")
    End Sub
    Sub CMDWRITE(FlFree As Short)
        Dim YPOS As Double
        Dim xPos As Double
        Dim YPOS2 As Double
        Dim xPos2 As Double
        Dim pdfFontSize As Double
        Dim pdfFontName As String = ""
        Dim pdfFontBold As Double
        Dim pdfFontItalic As Double
        Dim pdfFontUnderLine As Double
        Dim pdfColor As Double
        Dim pdfAlign As Double

        Dim textstring As String
        Dim texttmp As String

        On Error GoTo errorCMDWRITE
        Input(FlFree, xPos)
        Input(FlFree, YPOS)
        Input(FlFree, xPos2)
        Input(FlFree, YPOS2)
        Input(FlFree, pdfFontSize)
        Input(FlFree, pdfFontName)
        Input(FlFree, pdfColor)
        Input(FlFree, pdfAlign)
        Input(FlFree, pdfFontBold)
        Input(FlFree, pdfFontItalic)
        Input(FlFree, pdfFontUnderLine)
        textstring = LineInput(FlFree)
        Do
            texttmp = LineInput(FlFree)
            If texttmp = "CMD-ENDWRITE" Then
                Exit Do
            Else
                textstring = textstring & vbCrLf & texttmp
            End If
        Loop
        'Mim.Report.Font = VB6.FontChangeName(Mim.Report.Font, pdfFontName)
        'Mim.Report.Font = VB6.FontChangeSize(Mim.Report.Font, pdfFontSize)
        Mim.Report.SelectFont(pdfFontName, pdfFontSize)
        Mim.Report.TextColor = System.Drawing.ColorTranslator.FromOle(pdfColor)
        Mim.Report.TextBold = pdfFontBold
        Mim.Report.TextItalic = pdfFontItalic
        Mim.Report.TextUnderline = pdfFontUnderLine
        Mim.Report.TextAlignment = pdfAlign
        Ktrl = Mim.Report.Write(xPos, YPOS, xPos2, YPOS2, textstring)
        Exit Sub

errorCMDWRITE:
        MsgBox("CMDWRITE foutieve definitie")
    End Sub
    Sub CMDWRITEBOX(FlFree As Short)
        Dim YPOS As Double
        Dim xPos As Double
        Dim YPOS2 As Double
        Dim xPos2 As Double
        Dim pdfFontSize As Double
        Dim pdfFontName As String = ""
        Dim pdfFontBold As Double
        Dim pdfFontItalic As Double
        Dim pdfFontUnderLine As Double
        Dim pdfColor As Double
        Dim pdfAlign As Double

        Dim textstring As String
        Dim texttmp As String

        On Error GoTo errorCMDWRITEBOX
        Input(FlFree, xPos)
        Input(FlFree, YPOS)
        Input(FlFree, xPos2)
        Input(FlFree, YPOS2)
        Input(FlFree, pdfFontSize)
        Input(FlFree, pdfFontName)
        Input(FlFree, pdfColor)
        Input(FlFree, pdfAlign)
        Input(FlFree, pdfFontBold)
        Input(FlFree, pdfFontItalic)
        Input(FlFree, pdfFontUnderLine)
        textstring = LineInput(FlFree)
        Do
            texttmp = LineInput(FlFree)
            If texttmp = "CMD-ENDWRITE" Then
                Exit Do
            Else
                textstring = textstring & vbCrLf & texttmp
            End If
        Loop
        Mim.Report.SelectFont(pdfFontName, pdfFontSize)
        'Mim.Report.Font = VB6.FontChangeName(Mim.Report.Font, pdfFontName)
        'Mim.Report.Font = VB6.FontChangeSize(Mim.Report.Font, pdfFontSize)
        Mim.Report.TextColor = System.Drawing.ColorTranslator.FromOle(pdfColor)
        Mim.Report.TextBold = pdfFontBold
        Mim.Report.TextItalic = pdfFontItalic
        Mim.Report.TextUnderline = pdfFontUnderLine

        Mim.Report.TextAlignment = pdfAlign
        Ktrl = Mim.Report.WriteBox(xPos, YPOS, xPos2, YPOS2, textstring)
        Exit Sub

errorCMDWRITEBOX:
        MsgBox("CMDWRITEBOX foutieve definitie")
    End Sub
    Sub CMDPRINT(FLFree As Short)
        Dim YPOS As Double
        Dim xPos As Double
        Dim pdfFontSize As Double
        Dim pdfFontName As String = ""
        Dim pdfFontBold As Double
        Dim pdfFontItalic As Double
        Dim pdfFontUnderLine As Double
        Dim pdfColor As Double
        Dim textstring As String

        On Error GoTo errorCMDPRINT
        Input(FLFree, xPos)
        Input(FLFree, YPOS)
        Input(FLFree, pdfFontSize)
        Input(FLFree, pdfFontName)
        Input(FLFree, pdfColor)
        Input(FLFree, pdfFontBold)
        Input(FLFree, pdfFontItalic)
        Input(FLFree, pdfFontUnderLine)
        textstring = LineInput(FLFree)
        Mim.Report.SelectFont(pdfFontName, pdfFontSize)
        'Mim.Report.Font = VB6.FontChangeName(Mim.Report.Font, pdfFontName)
        'Mim.Report.Font = VB6.FontChangeSize(Mim.Report.Font, pdfFontSize)
        Mim.Report.TextColor = System.Drawing.ColorTranslator.FromOle(pdfColor)
        Mim.Report.TextBold = pdfFontBold
        Mim.Report.TextItalic = pdfFontItalic
        Mim.Report.TextUnderline = pdfFontUnderLine
        Ktrl = Mim.Report.Print(xPos, YPOS, textstring) 'vpeprint vb6
        Exit Sub

errorCMDPRINT:
        MsgBox("CMDPRINT foutieve definitie")
    End Sub
    Private Sub LayOutpdfDokument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DocuType = 0
        KopVoet = 1
        TaalKode = 2
        Mim.WindowState = System.Windows.Forms.FormWindowState.Minimized
        txtKleur.Text = CStr(System.Drawing.ColorTranslator.ToOle(Me.Label1.BackColor))
    End Sub
    Private Sub LayOutpdfDokument_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim hierCancel As Boolean = e.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = CloseReason.ApplicationExitCall
        If Mim.Report.IsOpen = True Then
            MsgBox("Sluit eerst het PDF venster a.u.b.", MsgBoxStyle.Information)
            hierCancel = True
        Else
            Mim.VpeLayOutOutgoingMenuItem.Enabled=True
        End If
        e.Cancel = hierCancel
    End Sub
    Private Sub LayOutpdfDokument_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FileClose()
        Mim.WindowState = System.Windows.Forms.FormWindowState.Normal
    End Sub
    Private Sub taalNederlands_Click(sender As Object, e As EventArgs) Handles taalNederlands.Click
        uncheckLanguages()
        taalNederlands.Checked = True : TaalKode = 2
    End Sub
    Private Sub taalFrans_Click(sender As Object, e As EventArgs) Handles taalFrans.Click
        uncheckLanguages()
        taalFrans.Checked = True : TaalKode = 1
    End Sub
    Private Sub taalEngels_Click(sender As Object, e As EventArgs) Handles taalEngels.Click
        uncheckLanguages()
        taalEngels.Checked = True : TaalKode = 3
    End Sub
    Private Sub taalDuits_Click(sender As Object, e As EventArgs) Handles taalDuits.Click
        uncheckLanguages()
        taalDuits.Checked = True : TaalKode = 4
    End Sub
    Sub uncheckLanguages()
        taalFrans.Checked = False
        taalNederlands.Checked = False
        taalDuits.Checked = False
        taalEngels.Checked = False
    End Sub
    Private Sub Factuur_Click(sender As Object, e As EventArgs) Handles Factuur.Click
        unCheckDocs()
        Factuur.Checked = True : DocuType = 0
    End Sub
    Private Sub Leveringsbon_Click(sender As Object, e As EventArgs) Handles Leveringsbon.Click
        unCheckDocs()
        Leveringsbon.Checked = True : DocuType = 1
    End Sub
    Private Sub Bestelbon_Click(sender As Object, e As EventArgs) Handles Bestelbon.Click
        unCheckDocs()
        Bestelbon.Checked = True : DocuType = 2
    End Sub
    Private Sub Offerte_Click(sender As Object, e As EventArgs) Handles Offerte.Click
        unCheckDocs()
        Offerte.Checked = True : DocuType = 3
    End Sub
    Private Sub Briefwisseling_Click(sender As Object, e As EventArgs) Handles Briefwisseling.Click
        unCheckDocs()
        Briefwisseling.Checked = True : DocuType = 4
    End Sub
    Private Sub Rekeninguittreksel_Click(sender As Object, e As EventArgs) Handles Rekeninguittreksel.Click
        unCheckDocs()
        Rekeninguittreksel.Checked = True : DocuType = 5
    End Sub
    Sub unCheckDocs()
        Factuur.Checked = False
        Leveringsbon.Checked = False
        Bestelbon.Checked = False
        Offerte.Checked = False
        Briefwisseling.Checked = False
        Rekeninguittreksel.Checked = False
    End Sub
    Private Sub Afsluiten_Click(sender As Object, e As EventArgs) Handles Afsluiten.Click
        Close()
    End Sub
    Private Sub Openen_Click(sender As Object, e As EventArgs) Handles Openen.Click
        Inladen(Format(KopVoet) & Format(TaalKode) & Format(DocuType))
    End Sub
    Private Sub viakladblok_Click(sender As Object, e As EventArgs) Handles viakladblok.Click
        Dim HetBESTAND As String
        HetBESTAND = LocationCompanyData & "pdfDDEF" & Format(KopVoet) & Format(TaalKode) & Format(DocuType) & ".Txt"
        If Dir(HetBESTAND) = "" Then
            MsgBox(HetBESTAND & " is niet aanwezig", MsgBoxStyle.Information)
        Else
            Shell("notepad.exe " & HetBESTAND, AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub cbKleurKiezen_Click(sender As Object, e As EventArgs) Handles cbKleurKiezen.Click
        Dim MyDialog As New ColorDialog()
        MyDialog.AllowFullOpen = False
        MyDialog.ShowHelp = True
        MyDialog.Color = Label1.ForeColor
        ' Update the text box color if the user clicks OK 
        If (MyDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Label1.ForeColor = MyDialog.Color
        End If
        txtKleur.Text = ColorTranslator.ToOle(MyDialog.Color).ToString
    End Sub
    Private Sub cbFont_Click(sender As Object, e As EventArgs) Handles cbFont.Click
        Dim MyDialog As New FontDialog
        MyDialog.ShowColor = True
        MyDialog.Font = Label1.Font
        MyDialog.Color = Label1.ForeColor

        If MyDialog.ShowDialog() <> DialogResult.Cancel Then
            Label1.Font = MyDialog.Font
            Label1.ForeColor = MyDialog.Color
        End If
        txtFont.Text = MyDialog.Font.SizeInPoints & "," & """" & MyDialog.Font.Name & """" & "," & System.Drawing.ColorTranslator.ToOle(MyDialog.Color) & ","
        If MyDialog.Font.Bold = True Then
            txtFont.Text = txtFont.Text & "1,"
        Else
            txtFont.Text = txtFont.Text & "0,"
        End If
        If MyDialog.Font.Italic = True Then
            txtFont.Text = txtFont.Text & "1,"
        Else
            txtFont.Text = txtFont.Text & "0,"
        End If
        If MyDialog.Font.Underline = True Then
            txtFont.Text = txtFont.Text & "1"
        Else
            txtFont.Text = txtFont.Text & "0"
        End If
    End Sub
End Class