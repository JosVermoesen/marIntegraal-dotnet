Public Class ntInputbox

    Public rsInputBoxData As ADODB.Recordset
    Dim sqlHere As String
    Dim sqlLabelHere As String

    Private Sub frmntInputbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tempo = LabelToolStrip.Text
        If SQL_COMMAND = "" Then
        Else
            sqlHere = Mid(SQL_COMMAND, 1, InStr(SQL_COMMAND, "LIKE") - 1)
            sqlLabelHere = Mid(tempo, 1, InStr(tempo, "LIKE") - 1)
            GetRSInputBoxData()
        End If

    End Sub

    Sub RefreshRecordPosition()

        Select Case Mid(LabelToolStrip.Text, 2, 2)
            Case "00"
                lblInfo.Text = rsInputBoxData.Fields("ISOLandNummer").Value + ", " + rsInputBoxData.Fields("ISOLandkode").Value + ", " + rsInputBoxData.Fields("ISOMuntKode").Value + ", " + rsInputBoxData.Fields("LandNaam").Value
                TekstInfo.Text = rsInputBoxData.Fields("ISOLandNummer").Value

            Case "01"
                lblInfo.Text = rsInputBoxData.Fields("PostKode").Value + ", " + rsInputBoxData.Fields("Plaatsnaam").Value
                TekstInfo.Text = rsInputBoxData.Fields("PostKode").Value

            Case "02"
                lblInfo.Text = rsInputBoxData.Fields("PostKode").Value + ", " + rsInputBoxData.Fields("Plaatsnaam").Value
                TekstInfo.Text = rsInputBoxData.Fields("PlaatsNaam").Value
        End Select

    End Sub

    Private Function GetRSInputBoxData() As Boolean

        GetRSInputBoxData = False

        Dim sqlQuery As String
        Dim sqlLabel As String
        sqlQuery = sqlHere + "LIKE '" & Trim(TekstInfo.Text) & "%'"
        sqlLabel = sqlLabelHere + "LIKE '" & Trim(TekstInfo.Text) & "%'"

        rsInputBoxData = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic,
            .LockType = ADODB.LockTypeEnum.adLockOptimistic,
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
        }
        Try
            rsInputBoxData.Open(sqlQuery, AD_KBDB)
        Catch ex As Exception
            MsgBox("SQLQuery: " & sqlQuery & vbCrLf & vbCrLf & "Bron:" & vbCrLf & ex.Source & vbCrLf & vbCrLf & "Foutnummer: " & ex.HResult & vbCrLf & vbCrLf & "Detail:" & vbCrLf & ex.Message)
        End Try

        If rsInputBoxData.RecordCount > 0 Then
            LabelToolStrip.Text = sqlLabel
            rsInputBoxData.MoveFirst()
            RefreshRecordPosition()
            GetRSInputBoxData = True
        End If

    End Function

    Private Sub Sluiten_Click(sender As Object, e As EventArgs) Handles Sluiten.Click

        KTRL = 9
        TekstInfo.Text = Chr(255)
        TekstInfo.Focus()
        Hide()

    End Sub

    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles Ok.Click

        On Error Resume Next

        TekstInfo.Focus()
        KTRL = 0
        Hide()

    End Sub

    Private Sub Hernieuw_Click(sender As Object, e As EventArgs) Handles Hernieuw.Click

        Dim result = GetRSInputBoxData()

        If result Then
            RefreshRecordPosition()
        End If
        AcceptButton = Ok

    End Sub

    Private Sub cmdVooruit_Click(sender As Object, e As EventArgs) Handles cmdVooruit.Click

        If rsInputBoxData.EOF Then
            rsInputBoxData.MoveLast()
            RefreshRecordPosition()
        Else
            rsInputBoxData.MoveNext()
            If Not rsInputBoxData.EOF Then
                RefreshRecordPosition()
            End If
        End If

    End Sub

    Private Sub cmdAchteruit_Click(sender As Object, e As EventArgs) Handles cmdAchteruit.Click

        If rsInputBoxData.BOF Then
            rsInputBoxData.MoveFirst()
            RefreshRecordPosition()
        Else
            rsInputBoxData.MovePrevious()
            If Not rsInputBoxData.BOF Then
                RefreshRecordPosition()
            End If
        End If

    End Sub

    Private Sub TekstInfo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TekstInfo.KeyPress

        If Hernieuw.Visible Then
            AcceptButton = Hernieuw
        End If

    End Sub
End Class