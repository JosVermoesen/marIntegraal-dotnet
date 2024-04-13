Option Strict Off
Option Explicit On
Module aLoadMain
    Public Sub StartUp()
        DecimalKTRL = False
        blLogging = False
        For CountTo = 0 To 9
            rsMAR(CountTo) = New ADODB.Recordset
        Next
        ChDir(My.Application.Info.DirectoryPath)
        fs = New Scripting.FileSystemObject
        Dim Antwoord As String
        Dim dPip As Double
        Dim sPip As String
        Dim FlFree As Short
ProbeerNogEens:
        If My.Application.Info.AssemblyName = "marntBrokersExpress" Then
            FlFree = FreeFile()
            FileOpen(FlFree, My.Application.Info.DirectoryPath & "\us1100.lic", OpenMode.Output)
            PrintLine(FlFree, Now)
            FileClose(FlFree)
            'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        ElseIf Dir(My.Application.Info.DirectoryPath & "\us1100.lic") = "" Then
            Msg = "Eerste opstart 11.x.xxx licentie op dit systeem. Trouwe 1985 contractanten genieten levenslang licentie"
            Msg = Msg & "Raadpleeg binnen het contract 2017 uw MAIL of FAX voor de juiste "
            Msg = Msg & "opstartcode.  Code kwijt?  Mail ons: info@rv.be of fax +32.53781922 voor nieuwe code" & vbCrLf & vbCrLf
            Msg = Msg & "STAP 1: Naam van deze computer :"
            Antwoord = InputBox(Msg, "Naam deze Computer", "Computer1")
            If Antwoord = "" Then GoTo ProbeerNogEens
            Msg = "STAP 2: Opstartcode." & vbCrLf
            Msg = Msg & "Code kwijt?  Mail ons: info@rv.be of fax +32.53781922 voor nieuwe code" & vbCrLf & vbCrLf & "Om uit te proberen (max. 50 journaalLIJNEN) en voor beperkte functionaliteit geef het volgende woord in: DEMO"
            Antwoord = InputBox(Msg, "Opstartkode?","DEMO")
            If Antwoord = "" Then
                MsgBox("Het programma wordt beëindigd.", MsgBoxStyle.Information)
                End
            End If
            If UCase(Antwoord) = "DEMO" Then
                usrLicentieInfo = "DemoModus"
            ElseIf UCase(Antwoord) = "THEQUICKBROWNFOXJUMPSOVERTHELAZYDOG" Then
                FlFree = FreeFile()
                FileOpen(FlFree, My.Application.Info.DirectoryPath & "\us1100.lic", OpenMode.Output)
                PrintLine(FlFree, Now)
                FileClose(FlFree)
            Else
                dPip = Val(Left(Antwoord, 10))
                sPip = Format(dPip - Int(dPip / 97) * 97, "00") 'VB6.Format(dPip - Int(dPip / 97) * 97, "00")
                If sPip <> Right(Antwoord, 2) Then
                    MsgBox("Ongeldige toegangskode.")
                    GoTo ProbeerNogEens
                ElseIf Mid(Antwoord, 9, 2) <> "10" Then
                    MsgBox("Ongeldige toegangskode.")
                    GoTo ProbeerNogEens
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