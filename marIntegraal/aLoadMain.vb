Option Strict Off
Option Explicit On
Module aLoadMain
    Public Sub StartUp()
        DECIMAL_CTRL = False
        BL_LOGGING = False
        For COUNT_TO = 0 To 9
            RS_MAR(COUNT_TO) = New ADODB.Recordset
        Next
        ChDir(My.Application.Info.DirectoryPath)
        FS = New Scripting.FileSystemObject
        Dim answer As String
        Dim dPip As Double
        Dim sPip As String
        Dim FlFree As Short
TryAgainPlease:
        If My.Application.Info.AssemblyName = "marntBrokersExpress" Then
            FlFree = FreeFile()
            FileOpen(FlFree, My.Application.Info.DirectoryPath & "\us1100.lic", OpenMode.Output)
            PrintLine(FlFree, Now)
            FileClose(FlFree)
            'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        ElseIf Dir(My.Application.Info.DirectoryPath & "\us1100.lic") = "" Then
            MSG = "Eerste opstart 11.x.xxx licentie op dit systeem. Trouwe 1985 contractanten genieten levenslang licentie"
            MSG = MSG & "Raadpleeg binnen het contract 2017 uw MAIL of FAX voor de juiste "
            MSG = MSG & "opstartcode.  Code kwijt?  Mail ons: info@rv.be of fax +32.53781922 voor nieuwe code" & vbCrLf & vbCrLf
            MSG = MSG & "STAP 1: Naam van deze computer :"
            'answer = InputBox(MSG, "Naam deze Computer", "Computer1")
            'If answer = "" Then GoTo TryAgainPlease
            MSG = "STAP 2: Opstartcode." & vbCrLf
            MSG = MSG & "Code kwijt?  Mail ons: info@rv.be of fax +32.53781922 voor nieuwe code" & vbCrLf & vbCrLf & "Om uit te proberen (max. 50 journaalLIJNEN) en voor beperkte functionaliteit geef het volgende woord in: DEMO"
            answer = "demo"
            'answer = InputBox(MSG, "Opstartkode?", "DEMO")
            'If answer = "" Then
            'MsgBox("Het programma wordt beëindigd.", MsgBoxStyle.Information)
            'End
            'End If
            If UCase(answer) = "DEMO" Then
                USER_LICENSEINFO = "DemoModus"
            ElseIf UCase(answer) = "THEQUICKBROWNFOXJUMPSOVERTHELAZYDOG" Then
                FlFree = FreeFile()
                FileOpen(FlFree, My.Application.Info.DirectoryPath & "\us1100.lic", OpenMode.Output)
                PrintLine(FlFree, Now)
                FileClose(FlFree)
            Else
                dPip = Val(Left(answer, 10))
                sPip = Format(dPip - Int(dPip / 97) * 97, "00") 'VB6.Format(dPip - Int(dPip / 97) * 97, "00")
                If sPip <> Right(answer, 2) Then
                    MsgBox("Ongeldige toegangskode.")
                    GoTo TryAgainPlease
                ElseIf Mid(answer, 9, 2) <> "10" Then
                    MsgBox("Ongeldige toegangskode.")
                    GoTo TryAgainPlease
                Else
                    FlFree = FreeFile()
                    FileOpen(FlFree, My.Application.Info.DirectoryPath & "\us1100.lic", OpenMode.Output)
                    PrintLine(FlFree, Now)
                    FileClose(FlFree)
                End If
            End If
        End If
    End Sub
End Module