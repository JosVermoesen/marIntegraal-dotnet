Option Strict Off
Option Explicit On

Public Class KwijtingEdit

	Dim policiesRS As ADODB.Recordset
	Dim invoicesRS As ADODB.Recordset


	Private Sub KwijtingEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Dim kwijtingArray() as String 

		kwijtingArray = Split (GridTextKwijting, vbTab)
		tbPolisNummer.Text = kwijtingArray(0)
		tbVervaldag.Text = kwijtingArray(1)
		tbPremie.Text = kwijtingArray(2)
		tbCommissie.Text = kwijtingArray(3)
		tbKlant.Text = kwijtingArray(4)
		tbComPct.Text = kwijtingArray(5)
		tbTB2.Text = kwijtingArray(6)
		
	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		GridTextKwijting = "ESC"
		Me.Close()

	End Sub

	Private Sub tbPolisNummer_Leave(sender As Object, e As EventArgs) Handles tbPolisNummer.Leave

		If tbPolisNummer.Text="" Then Exit Sub 
		JetGet(TableOfContracts, 0, SetSpacing(tbPolisNummer.Text, 12))
		If Ktrl Then
			btnOK.Enabled= False
			btnRefresh.Enabled = False 
			tbKlant.Text="":tbPolisNummer.Text=""
			tbPolisNummer.Focus
			Exit Sub
		Else
			RecordToField(TableOfContracts)
			tbPolisNummer.Text = AdoGetField(TableOfContracts, "#A000 #")
			JetGet(TableOfCustomers, 0, AdoGetField(TableOfContracts, "#A110 #"))
			If Ktrl Then
				tbKlant.Text = "KlantLink onmogelijk !!! Kontroleer !!!"
				btnOK.Enabled= False
				btnRefresh.Enabled = False 
			Else
				RecordToField(TableOfCustomers)
				tbKlant.Text = AdoGetField(TableOfCustomers, "#A100 #")
				btnOk.Enabled = True
				btnRefresh.Enabled = True 
			End If
		End If
		
	End Sub

	Private Sub tbVervaldag_Leave(sender As Object, e As EventArgs) Handles tbVervaldag.Leave

		If DateWrongFormat(tbVervaldag.Text) Then
			tbVervaldag.Text = format(Now,"dd/MM/yyyy")
			Beep()
			tbVervaldag.Focus()
		End If

	End Sub

	Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

		GridTextKwijting =  tbPolisNummer.Text & vbTab & tbVervaldag.Text & vbTab & tbPremie.Text & vbTab & tbCommissie.Text & vbTab & tbKlant.Text & vbTab & tbComPct.Text & vbTab & tbTB2.Text 
		Close 

	End Sub

	Private Sub ctrlContante(sPolis As String)

		Dim Ktrl2 As Integer
		Dim Dummy As String
		Dim tb2Dummy As String
		Dim X As Integer
		Dim TaksEnKost As Decimal
		Dim comPercentage As Single

		Dim getClient As String
		Dim getPolice As String

		Dim dbBA010 As Double 'Premie
		Dim dbBA014 As Double 'Commissie

		Dim dbBB010 As Double 
		Dim strV035 As String 
		
		
		' Create a invoice recordset using the provided collection
		invoicesRS = New ADODB.Recordset With {
			.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		}

		' Create a polices recordset using the provided collection
		policiesRS = New ADODB.Recordset With {
			.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		}

		Dim sSQL As String
		sSQL = "SELECT * FROM Polissen WHERE A000 = '" & sPolis & "'"
		policiesRS.Open(sSQL, adntDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
		If policiesRS.RecordCount <> 1 Then
			MsgBox  ("Controleer")
			Exit Sub
		Else
			Cursor.Current = Cursors.WaitCursor
			Enabled = False
			policiesRS.MoveFirst()
			'select beperken tot: A110, vs97, v164
			getClient = policiesRS.Fields("A110").Value

			JetGet(TableOfCustomers, 0, getClient)
			If Ktrl Then
				Dummy = "KlantLink onmogelijk !!! Kontroleer !!!"
			Else
				RecordToField(TableOfCustomers)
				Dummy = Trim(AdoGetField(TableOfCustomers, "#A100 #") & " " & AdoGetField(TableOfCustomers, "#A101 #"))
			End If
			getPolice = policiesRS.Fields("A000").Value
			sSQL = "SELECT * FROM Dokumenten WHERE A000 = '" & getPolice & "' ORDER BY rvID DESC" 'topmost
			invoicesRS.Open(sSQL, adntDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
			If invoicesRS.RecordCount <= 0 Then
				Dummy = "!" & Dummy
			Else
				Ktrl2 = -1
				invoicesRS.MoveFirst()
				Do While Not invoicesRS.EOF
					getClient = policiesRS.Fields("A110").Value

					If IsDBNull(invoicesRS.Fields("B010").Value) Then
						dbBA010 = 0
					Else
						dbBA010 = val(invoicesRS.Fields("B010").Value)
					End If
					If dbBA010 = 0 Then
						MsgBox ("boeking zonder premiedeel")
					else
						If IsDBNull(invoicesRS.Fields("B014").Value) Then
							dbBA014 = 0
						Else
							dbBA014 = val(invoicesRS.Fields("B014").Value)
						End If
						strV035 =  invoicesRS.Fields("v035").Value
						tb2Dummy = invoicesRS.Fields("rvxmltb2").Value

						
						Dim strA010 As String = policiesRS.Fields("A010").Value
						Dim strA000 As String = policiesRS.Fields("A000").Value
						Dim strB010 As String = policiesRS.Fields("B010").Value

						'JetGet(TableOfVarious, 1, "25" & SetSpacing(AdoGetField(TableOfContracts, "#A010 #"), 4) & AdoGetField(TableOfContracts, "#A000 #"))
						comPercentage = 0 'CommissieCheck(strA010, strA000)
						TaksEnKost = 0
						If Ktrl Then
						Else
							RecordToField(TableOfVarious)
							If Val(strB010) = Val(AdoGetField(TableOfVarious, "#B010 #")) Then
								TaksEnKost = Val(AdoGetField(TableOfVarious, "#B011 #"))
							End If
						End If

				
						'hier bijvoegen voor alle maatschappijen
						Dim dataVeld As String = policiesRS.Fields("A000").Value
						Dim itemHier As New ListViewItem(dataVeld)
						Dim vervaldagHier As String = Mid(policiesRS.Fields("v165").Value, 1, 2) & "/" & Mid(policiesRS.Fields("v164").Value, 1, 2) & "/" & Mid(PeriodFromTo, 1, 4)
		
						tbVervaldag.Text = vervaldagHier
						tbPremie.Text = str(dbBA010 )
						tbCommissie.Text = str(dbBA014)
						tbKlant.Text =  dummy 'kwijtingArray(4)
						tbComPct.Text = "0" 'kwijtingArray(5)
						tbTB2.Text = tb2dummy 'kwijtingArray(6)
						Cursor.Current = Cursors.Default
						Enabled = True '			 
						Exit Do
					 End If
				 Loop
				invoicesRS.Close
			End If
		End If
		Cursor.Current = Cursors.Default
		Enabled = True '			 

	End Sub

	Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

	   ctrlContante(tbPolisNummer.Text)

	End Sub
End Class

'Friend Class KwijtingEdit
	
'	Private Sub cbTB2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cbTB2.Click
		
'		MsgBox(tb2Indent(TekstInfo(5).Text))
'		My.Computer.Clipboard.Clear()
'		My.Computer.Clipboard.SetText((TekstInfo(5).Text))
		
		
'	End Sub
	
'	Private Sub KwijtingEdit_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
'		Dim astring As String
		
'		CType(KwijtingDrukken.Controls("PolisDetail"), Object).Col = 0
'		TekstInfo(0).Text = CType(KwijtingDrukken.Controls("PolisDetail"), Object).Text
'		CType(KwijtingDrukken.Controls("PolisDetail"), Object).Col = 1
'		If CType(KwijtingDrukken.Controls("PolisDetail"), Object).Text = "" Then
'			TekstInfo(2).Text = CType(KwijtingDrukken.Controls("TekstInfo"), Object)(0).Text
'		Else
'			TekstInfo(2).Text = CType(KwijtingDrukken.Controls("PolisDetail"), Object).Text
'		End If
'		CType(KwijtingDrukken.Controls("PolisDetail"), Object).Col = 2
'		TekstInfo(3).Text = CType(KwijtingDrukken.Controls("PolisDetail"), Object).Text
'		CType(KwijtingDrukken.Controls("PolisDetail"), Object).Col = 3
'		TekstInfo(4).Text = CType(KwijtingDrukken.Controls("PolisDetail"), Object).Text
'		CType(KwijtingDrukken.Controls("PolisDetail"), Object).Col = 4
'		TekstInfo(1).Text = CType(KwijtingDrukken.Controls("PolisDetail"), Object).Text
'		CType(KwijtingDrukken.Controls("PolisDetail"), Object).Col = 6
'		TekstInfo(5).Text = CType(KwijtingDrukken.Controls("PolisDetail"), Object).Text
		
'	End Sub
	
'	Private Sub Ok_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Ok.Click
'		Dim VeldPolis As New VB6.FixedLengthString(12)
		
'		Dim astring As String
'		If Val(TekstInfo(3).Text) + Val(TekstInfo(4).Text) = 0 Then
'			Beep()
'		Else
			
'			CType(KwijtingDrukken.Controls("PolisDetail"), Object).Col = 0
'			CType(KwijtingDrukken.Controls("PolisDetail"), Object).Text = TekstInfo(0).Text
'			CType(KwijtingDrukken.Controls("PolisDetail"), Object).Col = 1
'			CType(KwijtingDrukken.Controls("PolisDetail"), Object).Text = TekstInfo(2).Text
'			CType(KwijtingDrukken.Controls("PolisDetail"), Object).Col = 2
'			CType(KwijtingDrukken.Controls("PolisDetail"), Object).Text = TekstInfo(3).Text
'			CType(KwijtingDrukken.Controls("PolisDetail"), Object).Col = 3
'			CType(KwijtingDrukken.Controls("PolisDetail"), Object).Text = TekstInfo(4).Text
'			CType(KwijtingDrukken.Controls("PolisDetail"), Object).Col = 4
'			CType(KwijtingDrukken.Controls("PolisDetail"), Object).Text = TekstInfo(1).Text
			
'			GridText = "OK"
'			Me.Close()
'		End If
		
'	End Sub
	
'	Private Sub TekstInfo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TekstInfo.Enter
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)
		
'		If Index = 1 Then SnelHelpPrint("Eén of meer tekens gevolgd door [Ctrl] om geïndexeerd te zoeken", blLogging)
'		TekstInfo(Index).SelectionLength = Len(TekstInfo(Index).Text)
		
'	End Sub
	
'	Private Sub TekstInfo_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles TekstInfo.KeyDown
'		Dim KeyCode As Short = eventArgs.KeyCode
'		Dim Shift As Short = eventArgs.KeyData \ &H10000
'		Dim Index As Short = TekstInfo.GetIndex(eventSender)
		
'		Dim msgTitel As String
		
'		If Index = 1 Then
'			If KeyCode = 17 Then
'				SharedFl = TableOfCustomers
'				aIndex = 1
'				GridText = TekstInfo(1).Text
'				SqlSearch.ShowDialog()
'				If Ktrl Then
'					TekstInfo(1).Text = "-"
'					CType(Me.Controls("Ok"), Object).Enabled = False
'					Exit Sub
'				Else
'					RecordToField(TableOfCustomers)
'					TekstInfo(1).Text = AdoGetField(TableOfCustomers, "#A100 #")
'					JetGet(TableOfContracts, 1, AdoGetField(TableOfCustomers, "#A110 #"))
'					If Ktrl Or SetSpacing(KeyBuf(TableOfContracts), 12) <> SetSpacing(AdoGetField(TableOfCustomers, "#A110 #"), 12) Then
'						MsgBox("Geen polissen voor deze klant te vinden !!")
'						TekstInfo(1).Text = "-"
'						CType(Me.Controls("Ok"), Object).Enabled = False
'						Exit Sub
'					Else
'						Do 
'							RecordToField(TableOfContracts)
'							msgTitel = AdoGetField(TableOfContracts, "#B010 #") & " " & AdoGetField(TableOfContracts, "#e069 #")
							
'							Msg = "Kwijting voor polisnummer : " & AdoGetField(TableOfContracts, "#A000 #") & vbCrLf & vbCrLf
'							Msg = Msg & AdoGetField(TableOfContracts, "#vs99 #") & vbCrLf
'							Msg = Msg & AdoGetField(TableOfContracts, "#vs98 #") & vbCrLf & vbCrLf
'							Msg = Msg & "Bent U zeker ?"
'							KtrlBox = MsgBox(Msg, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, msgTitel)
'							If KtrlBox = MsgBoxResult.Yes Then
'								TekstInfo(0).Text = AdoGetField(TableOfContracts, "#A000 #")
'								TekstInfo(0).Focus()
'								TekstInfo(3).Text = CStr(Val(AdoGetField(TableOfContracts, "#B010 #")))
'								TekstInfo(4).Text = CStr(Val(AdoGetField(TableOfContracts, "#B014 #")))
'								Exit Do
'							End If
'							bNext(TableOfContracts)
'							If Ktrl Or SetSpacing(KeyBuf(TableOfContracts), 12) <> SetSpacing(AdoGetField(TableOfCustomers, "#A110 #"), 12) Then
'								MsgBox("Geen polissen meer voor deze klant te vinden !!")
'								TekstInfo(1).Text = "-"
'								CType(Me.Controls("Ok"), Object).Enabled = False
'								Exit Do
'							End If
'						Loop 
'					End If
'				End If
'			End If
'		End If
		
'	End Sub
'End Class