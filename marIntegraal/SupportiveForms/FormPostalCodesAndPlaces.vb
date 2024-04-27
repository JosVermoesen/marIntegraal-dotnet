Public Class FormPostalCodesAndPlaces

    Dim rsPostal As ADODB.Recordset
    Dim orderBy As String = "Postkode"

    Private Sub FormPostalCodesAndPlaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CbOrderBy.Items.Add("Postkode")
        CbOrderBy.Items.Add("Plaatsnaam")
        CbOrderBy.SelectedIndex = 0

    End Sub

    Private Function GetRSPostalCodesAndPlaces() As Boolean

        GetRSPostalCodesAndPlaces = False

        Dim searchHere = MtbSearch.Text

        Dim sSQL As String = "SELECT Postkode, Plaatsnaam FROM PostKodesWoonPlaatsen WHERE " + orderBy + " Like '" + searchHere + "%' ORDER BY " + orderBy

        ' Create a recordset using the provided collection
        rsPostal = New ADODB.Recordset With {
            .CursorType = ADODB.CursorTypeEnum.adOpenDynamic,
            .LockType = ADODB.LockTypeEnum.adLockOptimistic,
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
        }
        Try
            rsPostal.Open(sSQL, AD_KBDB)
        Catch ex As Exception
            MsgBox("SQLQuery: " & sSQL & vbCrLf & vbCrLf & "Bron:" & vbCrLf & ex.Source & vbCrLf & vbCrLf & "Foutnummer: " & ex.HResult & vbCrLf & vbCrLf & "Detail:" & vbCrLf & ex.Message)
        End Try

        If rsPostal.RecordCount > 0 Then
            GetRSPostalCodesAndPlaces = True
        End If

    End Function

    Sub FillPostalDataGrid()

        'Dim ktrl = GetRSPostalCodesAndPlaces("Plaatsnaam")
        Dim ktrl = GetRSPostalCodesAndPlaces()
        If Not ktrl Then
            MsgBox("Geen data gevonden")
            Exit Sub
        End If

        'Dim dt As DataTable = rsPostal.ADODBRSetToDataTable() ' Convert ADODB recordset to DataTable
        'Dim view As New DataView(dt) ' Create a DataView from the DataTable
        ' Now we can work with the data using the 'view' variable.
        'DataGridView.DataSource = view
        'DataGridView.Width = 694

    End Sub

    Private Sub CbOrderBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbOrderBy.SelectedIndexChanged

        orderBy = CbOrderBy.SelectedItem
        MtbSearch.Text = ""
        FillPostalDataGrid()
        rsPostal.MoveFirst()
        RefreshLabelInfo()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        Close()

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        If rsPostal.BOF Then
            rsPostal.MoveFirst()
            RefreshLabelInfo()
        Else
            rsPostal.MovePrevious()
            If Not rsPostal.BOF Then
                RefreshLabelInfo()
            End If
        End If

    End Sub

    Sub RefreshLabelInfo()

        LabelInfo.Text = rsPostal.Fields("Postkode").Value & "," & rsPostal.Fields("Plaatsnaam").Value

    End Sub

    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click



    End Sub

    Private Sub BtnForward_Click(sender As Object, e As EventArgs) Handles BtnForward.Click

        If rsPostal.EOF Then
            rsPostal.MoveLast()
            RefreshLabelInfo()
        Else
            rsPostal.MoveNext()
            If Not rsPostal.EOF Then
                RefreshLabelInfo()
            End If
        End If

    End Sub

    Private Sub BtnRenew_Click(sender As Object, e As EventArgs) Handles BtnRenew.Click

        FillPostalDataGrid()
        If rsPostal.RecordCount Then
            rsPostal.MoveFirst()
            RefreshLabelInfo()
        End If

    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click

        rsPostal.MoveFirst()
        RefreshLabelInfo()

    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click

        rsPostal.MoveLast()
        RefreshLabelInfo()

    End Sub
End Class