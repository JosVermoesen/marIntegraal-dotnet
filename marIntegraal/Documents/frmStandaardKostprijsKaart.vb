Public Class frmStandaardKostprijsKaart
    Private Sub frmStandaardKostprijsKaart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Imports VB = Microsoft.VisualBasic
'Friend Class StandaardKostPrijsKaart
'	Inherits System.Windows.Forms.Form

'	Dim GrdProduktIsGewijzigd As Boolean
'	Dim X As Boolean

'	Dim NietAanwezig As Short
'	Dim AantalDeelProdukten As Short
'	Dim Teller As Short

'	Dim rsKPK As ADODB.Recordset

'	Dim verbruikBedrag As Decimal
'	Dim productieBedrag As Decimal
'	Dim productiecumul As Decimal

'	Dim kpkProductOMS As String
'	Dim kpkProductNR As String

'	Dim TotaalAankoop As Decimal
'	Dim TotaalVerkoop As Decimal

'	Dim TotaalAankoopNieuw As Decimal
'	Dim TotaalVerkoopNieuw As Decimal

'	Sub KtrlKEYPRess(ByRef KeyCode As Short)
'		Dim aa As String
'		Dim Antwoord As String
'		Dim vkBedrag As Decimal
'		Dim akBedrag As Decimal

'		Select Case KeyCode
'			Case 45, 107 'Insert
'				If LblProduktInfo.Text = "" Then Exit Sub
'				aa = ""
'				A_INDEX = 0
'				SHARED_FL = TABLE_PRODUCTS
'				GRIDTEXT = ""
'				SqlSearch.ShowDialog()
'				If KTRL = 0 Then
'					If BH_EURO Then
'						vkBedrag = Val(AdoGetField(TABLE_PRODUCTS, "#e112 #"))
'						akBedrag = Val(AdoGetField(TABLE_PRODUCTS, "#e113 #"))
'					Else
'						vkBedrag = Val(AdoGetField(TABLE_PRODUCTS, "#v112 #"))
'						akBedrag = Val(AdoGetField(TABLE_PRODUCTS, "#v113 #"))
'					End If
'					If vkBedrag = 0 Then
'						MsgBox("Verkoopprijs staat nog op 0 van dit produkt.  Eerst de nodige wijzigingen aanbrengen a.u.b.",  , LTrim(AdoGetField(TABLE_PRODUCTS, "#v105 #")))
'						Exit Sub
'					ElseIf akBedrag = 0 Then 
'						MsgBox("Aankoopkoopprijs staat nog op 0 van dit produkt.  Eerst de nodige wijzigingen aanbrengen a.u.b.",  , LTrim(AdoGetField(TABLE_PRODUCTS, "#v105 #")))
'						Exit Sub
'					End If

'					aa = fmarBoxText("004", "2", AdoGetField(TABLE_PRODUCTS, "#v106 #"))
'					Antwoord = vsfInputBox("Verkoopprijs per eenheid in BEF : " & Dec(Val(AdoGetField(TABLE_PRODUCTS, "#v112 #")), MASK_SY(4)), "Geef het verbruik aan (in " & Mid(aa, 4) & ")", "", "")
'					If Antwoord = "" Then
'						Exit Sub
'					Else
'						aa = AdoGetField(TABLE_PRODUCTS, "#v102 #") & vbTab
'						aa = aa & AdoGetField(TABLE_PRODUCTS, "#v105 #") & vbTab
'						If BH_EURO Then
'							aa = aa & Dec(Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")), MASK_SY(2) & "0000") & vbTab
'							aa = aa & Dec(Val(AdoGetField(TABLE_PRODUCTS, "#e112 #")), MASK_SY(2) & "0000") & vbTab
'						Else
'							aa = aa & Dec(Val(AdoGetField(TABLE_PRODUCTS, "#v113 #")), MASK_SY(2) & "0000") & vbTab
'							aa = aa & Dec(Val(AdoGetField(TABLE_PRODUCTS, "#v112 #")), MASK_SY(2) & "0000") & vbTab
'						End If
'						aa = aa & Mid(fmarBoxText("004", "2", AdoGetField(TABLE_PRODUCTS, "#v106 #")), 4) & vbTab
'						aa = aa & Dec(Val(Antwoord), MASK_SY(4) & "0")
'						grdProduktDetail.AddItem(aa, grdProduktDetail.Rows - 1)
'						X = MaakTotaal
'						GrdProduktIsGewijzigd = True
'						CmdWegschrijven.Enabled = True
'						CmdProduktieFiche.Enabled = True
'					End If
'				Else
'					Exit Sub
'				End If

'			Case 46, 109 'Delete
'				grdProduktDetail.Col = 0
'				If grdProduktDetail.Text = "" Or grdProduktDetail.Rows < 3 Then
'				ElseIf grdProduktDetail.Row > 0 Then 
'					CTRL_BOX = MsgBox(grdProduktDetail.Text & "-lijn verwijderen.  Bent U zeker ?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2)
'					If CTRL_BOX = MsgBoxResult.Yes Then
'						grdProduktDetail.RemoveItem(grdProduktDetail.Row)
'						X = MaakTotaal
'					End If
'				End If
'				grdProduktDetail.Focus()

'			Case Else

'		End Select
'		SnelHelpPrint("Deelprodukten : [Insert]/[+] om toe te voegen, [Delete]/[-] om te verwijderen", BL_LOGGING)

'	End Sub

'	Function MaakTotaal() As Boolean

'		LblAankoopNieuw.Text = "0"
'		LblVerkoopNieuw.Text = "0"
'		For Teller = 1 To grdProduktDetail.Rows - 2
'			grdProduktDetail.Row = Teller
'			grdProduktDetail.Col = 0
'			JetGet(TABLE_PRODUCTS, 0, (grdProduktDetail.Text))
'			If KTRL Then
'				MsgBox("Onlogische situatie!")
'			Else
'				RecordToField(TABLE_PRODUCTS)
'				grdProduktDetail.Col = 5
'				LblAankoopNieuw.Text = VB6.Format(CDbl(LblAankoopNieuw.Text) + (Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")) * Val(grdProduktDetail.Text)), "#,##0.000000")
'				LblVerkoopNieuw.Text = VB6.Format(CDbl(LblVerkoopNieuw.Text) + (Val(AdoGetField(TABLE_PRODUCTS, "#e112 #")) * Val(grdProduktDetail.Text)), "#,##0.000000")
'			End If
'		Next 

'	End Function

'	Function MaakLijstTotaal() As Boolean

'		TotaalAankoopNieuw = 0
'		TotaalVerkoopNieuw = 0
'		For Teller = 1 To grdProduktDetail.Rows - 2
'			grdProduktDetail.Row = Teller
'			grdProduktDetail.Col = 0
'			JetGet(TABLE_PRODUCTS, 0, (grdProduktDetail.Text))
'			If KTRL Then
'				MsgBox("Onlogische situatie!")
'			Else
'				RecordToField(TABLE_PRODUCTS)
'				grdProduktDetail.Col = 5
'				TotaalAankoopNieuw = TotaalAankoopNieuw + (Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")) * Val(grdProduktDetail.Text))
'				TotaalVerkoopNieuw = TotaalVerkoopNieuw + (Val(AdoGetField(TABLE_PRODUCTS, "#e112 #")) * Val(grdProduktDetail.Text))
'			End If
'		Next 

'	End Function


'	Private Sub CmdAnnuleren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdAnnuleren.Click

'		If GrdProduktIsGewijzigd And grdProduktDetail.Rows <> 2 Then
'			CTRL_BOX = MsgBox("Wijzigingen negeren.  Bent U zeker ?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2)
'			If CTRL_BOX = MsgBoxResult.Yes Then
'				Me.Close()
'			End If
'		Else
'			Me.Close()
'		End If

'	End Sub


'	Private Sub CmdProduktieFiche_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdProduktieFiche.Click
'		Dim Printer As New Printer
'		Dim KtrlInput As Object

'		Dim DatumAanmaak As New VB6.FixedLengthString(10)
'		Dim DatumKlaar As New VB6.FixedLengthString(10)
'		Dim dokumentSleutel As New VB6.FixedLengthString(11)

'		Dim Aantal As Single

'		Dim Aantalv119 As Double
'		Dim Aantalv120 As Double

'		Dim Bedragv121 As Decimal
'		Dim Bedragv122 As Decimal
'		Dim TotaalPrijs As Decimal
'		Dim BedragX As Decimal


'InputVanProduktie: 
'		'UPGRADE_WARNING: Couldn't resolve default property of object KtrlInput. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		KtrlInput = InputBox("Aantal eenheden", "ProduktieFiche " & CmdSProdukt.Text, txtVerbruik.Text)
'		'UPGRADE_WARNING: Couldn't resolve default property of object KtrlInput. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		If KtrlInput = "" Then
'			Exit Sub
'		Else
'			'UPGRADE_WARNING: Couldn't resolve default property of object KtrlInput. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Aantal = Val(KtrlInput)
'		End If

'		'UPGRADE_WARNING: Couldn't resolve default property of object KtrlInput. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		KtrlInput = InputBox("Aanmaakdatum", "ProduktieFiche " & CmdSProdukt.Text, MIM_GLOBAL_DATE.Value)
'		'UPGRADE_WARNING: Couldn't resolve default property of object KtrlInput. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		If KtrlInput = "" Or Len(KtrlInput) <> 10 Then
'			Exit Sub
'		Else
'			'UPGRADE_WARNING: Couldn't resolve default property of object KtrlInput. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			DatumAanmaak.Value = KtrlInput
'		End If

'		'UPGRADE_WARNING: Couldn't resolve default property of object KtrlInput. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		KtrlInput = InputBox("Klaar tegen", "ProduktieFiche " & CmdSProdukt.Text, MIM_GLOBAL_DATE.Value)
'		'UPGRADE_WARNING: Couldn't resolve default property of object KtrlInput. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		If KtrlInput = "" Or Len(KtrlInput) <> 10 Then
'			Exit Sub
'		Else
'			'UPGRADE_WARNING: Couldn't resolve default property of object KtrlInput. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			DatumKlaar.Value = KtrlInput
'		End If

'		MSG = "Aanmaak van " & VB6.Format(Aantal, "#,##0.00") & " eenheden" & vbCrLf & vbCrLf
'		MSG = MSG & LblProduktInfo.Text & vbCrLf & vbCrLf
'		MSG = MSG & "Aanmaakdatum : " & DatumAanmaak.Value & ", klaar tegen : " & DatumKlaar.Value & vbCrLf & vbCrLf
'		MSG = MSG & "Bent U zeker ?"

'		dokumentSleutel.Value = SleutelDok(188)

'DeAfdrukVraag: 
'		CTRL_BOX = MsgBox(MSG, MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton3, "Produktiefiche " & dokumentSleutel.Value & " afdrukken/aanmaken")
'		Select Case CTRL_BOX
'			Case MsgBoxResult.Yes
'			Case MsgBoxResult.No
'				Exit Sub
'			Case MsgBoxResult.Cancel
'				GoTo DeAfdrukVraag
'			Case Else
'				MsgBox("onlogische keuze")
'		End Select

'AfdrukProduktieFiche: 
'		Printer = Printers(LISTPRINTER_NUMBER)
'		On Error Resume Next
'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		Printer.PaperBin = LaadTekst(My.Application.Info.Title, "LIJSTPRINTER")
'		Printer.FontName = "Courier New"
'		Printer.FontSize = 7.2
'		Printer.Write(vbCrLf & vbCrLf & FULL_LINE.Value & vbCrLf)
'		Printer.Write(TAB(10), "PRODUKTIEFICHE : " & dokumentSleutel.Value, TAB(100), MIM_GLOBAL_DATE.Value & vbCrLf)
'		Printer.Write(vbCrLf, TAB(10), CmdSProdukt.Text & " : " & Mid(LblProduktInfo.Text, InStr(LblProduktInfo.Text, vbCrLf) + 2) & vbCrLf)
'		Printer.Write(vbCrLf & vbCrLf)
'		Printer.Write(TAB(20), "STANDAARD    WERKELIJK" & vbCrLf)
'		Printer.Write(TAB(10), "AANMAAK : " & DatumAanmaak.Value & "  ../../...." & vbCrLf)
'		Printer.Write(TAB(10), "KLAAR OP: " & DatumKlaar.Value & "  ../../...." & vbCrLf)
'		Printer.Write(TAB(10), "AANTAL  : " & Dec(Aantal, MASK_SY(2)) & "  .........." & vbCrLf)
'		Printer.Write(vbCrLf & vbCrLf)
'		Printer.Write("Anal. produkt Omschrijving                             Maat   Stand.hoev. Stand.prijs Werk.hoev. Werk.prijs" & vbCrLf)
'		Printer.Print(FULL_LINE.Value)

'		TotaalPrijs = 0
'		For Teller = 1 To grdProduktDetail.Rows - 2
'			grdProduktDetail.Row = Teller
'			grdProduktDetail.Col = 0
'			JetGet(TABLE_PRODUCTS, 0, (grdProduktDetail.Text))
'			If KTRL Then
'				MsgBox("Onlogische situatie!")
'			Else
'				RecordToField(TABLE_PRODUCTS)
'			End If
'			Printer.Write(SetSpacing((grdProduktDetail.Text), 13) & " ")
'			grdProduktDetail.Col = 1
'			Printer.Write(SetSpacing((grdProduktDetail.Text), 40) & " ")
'			grdProduktDetail.Col = 4
'			Printer.Write(SetSpacing((grdProduktDetail.Text), 5) & " ")
'			grdProduktDetail.Col = 5
'			Printer.Write(Dec(Val(grdProduktDetail.Text), MASK_SY(4) & "0") & " ")
'			BedragX = CDbl(VB6.Format(Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")) * Val(grdProduktDetail.Text), "#.##"))
'			TotaalPrijs = TotaalPrijs + BedragX
'			Printer.Write(Dec(BedragX, MASK_SY(4)))
'			Printer.Write(" ........   ........." & Dec(BedragX * Aantal, MASK_SY(4)) & vbCrLf)
'		Next 
'		Printer.Write(FULL_LINE.Value & vbCrLf)
'		Printer.Write(TAB(75), Dec(TotaalPrijs, MASK_SY(4)) & vbCrLf)
'		Printer.Write(TAB(20), "Totaal voor aantal", TAB(75), Dec(TotaalPrijs * Aantal, MASK_SY(4)))
'		Printer.EndDoc()

'DeWegschrijfVraag: 
'		CTRL_BOX = MsgBox(MSG, MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton3, "Produktiefiche verwerken")
'		Select Case CTRL_BOX
'			Case MsgBoxResult.Yes
'			Case MsgBoxResult.No
'				Exit Sub
'			Case MsgBoxResult.Cancel
'				GoTo DeWegschrijfVraag
'			Case Else
'				MsgBox("onlogische keuze")
'		End Select

'BijwerkenVanStock: 
'		DKTRL_CUMUL = 0 : DKTRL_BEF = 0 : DKTRL_EUR = 0
'		TransBegin()
'		For Teller = 1 To grdProduktDetail.Rows - 2
'			grdProduktDetail.Row = Teller
'			grdProduktDetail.Col = 0
'			JetGet(TABLE_PRODUCTS, 0, (grdProduktDetail.Text))
'			If KTRL Then
'				MsgBox("Onlogische situatie!")
'			Else
'				RecordToField(TABLE_PRODUCTS)
'				grdProduktDetail.Col = 5

'				If BH_EURO Then
'					DKTRL_CUMUL = DKTRL_CUMUL + CDbl(VB6.Format(Aantal * Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")) * Val(grdProduktDetail.Text), "0"))
'					Bedragv122 = Val(AdoGetField(TABLE_PRODUCTS, "#e122 #")) + CDbl(VB6.Format(Aantal * Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")) * Val(grdProduktDetail.Text), "0"))
'					Aantalv120 = Val(AdoGetField(TABLE_PRODUCTS, "#v120 #")) + (Aantal * Val(grdProduktDetail.Text))
'					AdoInsertToRecord(TABLE_PRODUCTS, Str(Bedragv122), "e122")
'					AdoInsertToRecord(TABLE_PRODUCTS, Dec(Aantalv120, MASK_EUR), "v120")
'				Else
'					DKTRL_CUMUL = DKTRL_CUMUL + CDbl(VB6.Format(Aantal * Val(AdoGetField(TABLE_PRODUCTS, "#v113 #")) * Val(grdProduktDetail.Text), "0"))
'					Bedragv122 = Val(AdoGetField(TABLE_PRODUCTS, "#v122 #")) + CDbl(VB6.Format(Aantal * Val(AdoGetField(TABLE_PRODUCTS, "#v113 #")) * Val(grdProduktDetail.Text), "0"))
'					Aantalv120 = Val(AdoGetField(TABLE_PRODUCTS, "#v120 #")) + (Aantal * Val(grdProduktDetail.Text))
'					AdoInsertToRecord(TABLE_PRODUCTS, Str(Bedragv122), "v122")
'					AdoInsertToRecord(TABLE_PRODUCTS, Dec(Aantalv120, MASK_EUR), "v120")
'				End If
'				bUpdate(TABLE_PRODUCTS, 0)
'			End If
'		Next 

'StelDEVraag: 
'		If DKTRL_CUMUL <> CDbl(VB6.Format(TotaalPrijs * Aantal, "0")) Then
'			MSG = "Vierkantskontrole..." & vbCrLf & Str(DKTRL_CUMUL) & "/" & Str(TotaalPrijs * Aantal) & vbCrLf & vbCrLf
'			MSG = MSG & "Rekenverschil : " & VB6.Format(DKTRL_CUMUL - CDbl(VB6.Format(TotaalPrijs * Aantal))) & vbCrLf
'			MSG = MSG & "mag genegeerd worden ?"
'			CTRL_BOX = MsgBox(MSG, MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton3 + MsgBoxStyle.Critical)
'			If CTRL_BOX = MsgBoxResult.Yes Then
'				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'				GoSub SKPKUpdate
'			ElseIf CTRL_BOX = MsgBoxResult.No Then 
'				TransAbort()
'			ElseIf CTRL_BOX = MsgBoxResult.Cancel Then 
'				GoTo StelDEVraag
'			Else
'				MsgBox("ongeldige keuzemogelijkheid")
'			End If
'			Exit Sub
'		Else
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			GoSub SKPKUpdate
'		End If
'		Schoon()
'		Exit Sub

'SKPKUpdate: 
'		JetGet(TABLE_PRODUCTS, 0, (CmdSProdukt.Text))
'		If KTRL Then
'			MsgBox("Onlogische situatie!")
'		Else
'			RecordToField(TABLE_PRODUCTS)
'		End If
'		If BH_EURO Then
'			Bedragv121 = Val(AdoGetField(TABLE_PRODUCTS, "#e121 #")) + (Aantal * TotaalPrijs)
'			Aantalv119 = Val(AdoGetField(TABLE_PRODUCTS, "#v119 #")) + Aantal
'			AdoInsertToRecord(TABLE_PRODUCTS, Str(Bedragv121), "e121")
'		Else
'			Bedragv121 = Val(AdoGetField(TABLE_PRODUCTS, "#v121 #")) + (Aantal * TotaalPrijs)
'			Aantalv119 = Val(AdoGetField(TABLE_PRODUCTS, "#v119 #")) + Aantal
'			AdoInsertToRecord(TABLE_PRODUCTS, Str(Bedragv121), "v121")
'		End If
'		AdoInsertToRecord(TABLE_PRODUCTS, Dec(Aantalv119, MASK_EUR), "v119")
'		bUpdate(TABLE_PRODUCTS, 0)
'		TransCommit()
'		SS99(VB.Right(dokumentSleutel.Value, 5), 188)
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'		'BON ZELF EVENEENS BEWAREN !!!
'		'FOR t.dl=1 TO tl
'		'LSET r.nra7=rnr(1)
'		'LSET r.om7=som(1)
'		'LSET r.bnr7=sleut
'		'LSET r.vkpr7=MKD$(dkp(1))
'		'LSET r.ant7=MKS$(nant(1))
'		'LSET r.btk7=Right(STR$(ibtk(1)),1)
'		'LSET r.vol7=MKS$(nvol(1))
'		'LSET r.ktr7=MKI$(ikrt(1))
'		'LSET r.msf7=Right(STR$(imsf(1)),1)
'		'LSET r.oprek7=roprek(1)

'		'sltl=sleut:fl=7:idx=0:GOSUB 11200
'		'prec=FETCHREC(fl)
'		'idx=1:sltl=rnr(1)+SPACE$(13-LEN(rnr(1)))
'		'GOSUB 11170
'		'Next

'		'3540 rdat1=Right(rdat1,2)+Mid(rdat1,4,2)+Left(rdat1,2)
'		'3550 rdat2=Right(rdat2,2)+Mid(rdat2,4,2)+Left(rdat2,2)
'		'3560 LSET r.nrk6=snrk:LSET r.dat16=rdat1:LSET r.dat26=rdat2:LSET r.bnr6=sleut
'		'3570 LSET r.goed6=MKD$(dttb+dnttb+dnnttb):LSET r.tbtw6=MKD$(dtbtw):snrm8=r.nrm8:LSET r.nrm6=snrm8:LSET r.munt6=MKD$(dmunt)
'		'3580 sltl=snrk:fl=6:idx=0:GOSUB 11200:prec=FETCHREC(fl):sltl=rdat2:idx=1:GOSUB 11170:sltl=sleut:idx=2:GOSUB 11170
'		'3590 '

'	End Sub


'	Private Sub cmdLijst_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLijst.Click
'		Dim aa As String
'		Dim AAA As Object
'		Dim Antwoord As String

'		Dim PrijsAantepassen As Boolean

'		If cbPrijswijziging.CheckState = 1 Then
'			PrijsAantepassen = True
'		Else
'			PrijsAantepassen = False
'		End If

'		'on error resume next
'		Err.Clear()
'		rsKPK.CursorLocation = ADODB.CursorLocationEnum.adUseClient
'		MSG = "SELECT * FROM Allerlei WHERE v005 Like '11%'"
'		SnelHelpPrint(MSG, BL_LOGGING)
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'		rsKPK.Open(MSG, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
'		If Err.Number Then
'			MsgBox("Bron:" & vbCrLf & Err.Source & vbCrLf & vbCrLf & "Foutnummer: " & Err.Number & vbCrLf & vbCrLf & "Detail:" & vbCrLf & Err.Description)
'			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'			'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = vbNormal
'			Exit Sub
'		ElseIf rsKPK.RecordCount = 0 Then 
'			MsgBox("Geen standaardkostprijskaarten te vinden.", MsgBoxStyle.Information)
'			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'			'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = vbNormal
'			rsKPK.Close()
'			Exit Sub
'		End If
'		SnelHelpPrint("Lijst samenstellen voor " & rsKPK.RecordCount & " lijnen", BL_LOGGING)
'		frmADOXlog.Close()
'		frmADOXlog.Hide()

'		If PrijsAantepassen Then
'			frmADOXlog.Text = "SKPK's voor Prijsaanpassing"
'		Else
'			frmADOXlog.Text = "SKPK's Totaallijst"
'		End If
'		With frmADOXlog.lvDetail
'			' Add ColumnHeaders. The width of the columns is
'			' the width of the control divided by the number of
'			' ColumnHeader objects.
'			.Columns.Add("", "Omschrijving", CInt(VB6.TwipsToPixelsX(2625)))
'			.Columns.Add("", "Nummer SKPK", CInt(VB6.TwipsToPixelsX(1620)))
'			.Columns.Add("AK Huidig", CInt(VB6.TwipsToPixelsX(1215)), System.Windows.Forms.HorizontalAlignment.Right)
'			.Columns.Add("AK Nieuw", CInt(VB6.TwipsToPixelsX(1215)), System.Windows.Forms.HorizontalAlignment.Right)
'			.Columns.Add("VK Huidig", CInt(VB6.TwipsToPixelsX(1215)), System.Windows.Forms.HorizontalAlignment.Right)
'			.Columns.Add("VK Nieuw", CInt(VB6.TwipsToPixelsX(1215)), System.Windows.Forms.HorizontalAlignment.Right)

'			' Set View property to Report.
'			.View = System.Windows.Forms.View.Details
'		End With

'		Dim itmX As System.Windows.Forms.ListViewItem
'		Do While Not rsKPK.EOF
'			cmdSchoon_Click(cmdSchoon, New System.EventArgs())
'			JetGet(TABLE_PRODUCTS, 0, Mid(rsKPK.Fields("v005").Value, 3))
'			If KTRL Then
'			Else
'				RecordToField(TABLE_PRODUCTS)

'				LblProduktInfo.Text = AdoGetField(TABLE_PRODUCTS, "#v102 #") & vbCr & AdoGetField(TABLE_PRODUCTS, "#v105 #")
'				CmdSProdukt.Text = AdoGetField(TABLE_PRODUCTS, "#v102 #")
'				LblAankoop.Text = VB6.Format(Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")), "#,##0.000000")
'				LblVerkoop.Text = VB6.Format(Val(AdoGetField(TABLE_PRODUCTS, "#e112 #")), "#,##0.000000")
'				GRIDTEXT = adoBibTekst(rsKPK.Fields("MEMO"), "#v214 #")
'				Do While GRIDTEXT <> ""
'					'UPGRADE_WARNING: Couldn't resolve default property of object AAA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					AAA = Mid(GRIDTEXT, 1, InStr(GRIDTEXT, vbTab) - 1)
'					JetGet(TABLE_PRODUCTS, 0, (AAA))
'					If KTRL Then
'					Else
'						RecordToField(TABLE_PRODUCTS)
'						aa = AdoGetField(TABLE_PRODUCTS, "#v102 #") & vbTab
'						aa = aa & AdoGetField(TABLE_PRODUCTS, "#v105 #") & vbTab
'						aa = aa & Dec(Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")), MASK_SY(2) & "00") & vbTab
'						aa = aa & Dec(Val(AdoGetField(TABLE_PRODUCTS, "#e112 #")), MASK_SY(2) & "00") & vbTab
'						aa = aa & Mid(fmarBoxText("004", "2", AdoGetField(TABLE_PRODUCTS, "#v106 #")), 4) & vbTab
'					End If
'					Antwoord = Mid(GRIDTEXT, InStr(GRIDTEXT, vbTab) + 1, InStr(GRIDTEXT, vbCrLf) - InStr(GRIDTEXT, vbTab) - 1)
'					aa = aa & Dec(Val(Antwoord), MASK_SY(4) & "0")
'					grdProduktDetail.AddItem(aa, grdProduktDetail.Rows - 1)
'					GRIDTEXT = Mid(GRIDTEXT, InStr(GRIDTEXT, vbCrLf) + 2)
'				Loop 
'				X = MaakTotaal
'				If Not PrijsAantepassen Then
'					' Add a ListItem object.
'					itmX = frmADOXlog.lvDetail.Items.Add(Mid(LblProduktInfo.Text, InStr(LblProduktInfo.Text, vbCr) + 1))
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 1 Then
'						itmX.SubItems(1).Text = VB.Left(LblProduktInfo.Text, InStr(LblProduktInfo.Text, vbCr) - 1)
'					Else
'						itmX.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB.Left(LblProduktInfo.Text, InStr(LblProduktInfo.Text, vbCr) - 1)))
'					End If
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 2 Then
'						itmX.SubItems(2).Text = VB6.Format(CDbl(LblAankoop.Text), "#,##0.00")
'					Else
'						itmX.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB6.Format(CDbl(LblAankoop.Text), "#,##0.00")))
'					End If
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 3 Then
'						itmX.SubItems(3).Text = VB6.Format(CDbl(LblAankoopNieuw.Text), "#,##0.00")
'					Else
'						itmX.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB6.Format(CDbl(LblAankoopNieuw.Text), "#,##0.00")))
'					End If
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 4 Then
'						itmX.SubItems(4).Text = VB6.Format(CDbl(LblVerkoop.Text), "#,##0.00")
'					Else
'						itmX.SubItems.Insert(4, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB6.Format(CDbl(LblVerkoop.Text), "#,##0.00")))
'					End If
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 5 Then
'						itmX.SubItems(5).Text = VB6.Format(CDbl(LblVerkoopNieuw.Text), "#,##0.00")
'					Else
'						itmX.SubItems.Insert(5, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB6.Format(CDbl(LblVerkoopNieuw.Text), "#,##0.00")))
'					End If
'				ElseIf LblAankoop.Text = LblAankoopNieuw.Text And LblVerkoop.Text = LblVerkoopNieuw.Text Then 
'				Else
'					' Add a ListItem object.
'					itmX = frmADOXlog.lvDetail.Items.Add(Mid(LblProduktInfo.Text, InStr(LblProduktInfo.Text, vbCr) + 1))
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 1 Then
'						itmX.SubItems(1).Text = VB.Left(LblProduktInfo.Text, InStr(LblProduktInfo.Text, vbCr) - 1)
'					Else
'						itmX.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB.Left(LblProduktInfo.Text, InStr(LblProduktInfo.Text, vbCr) - 1)))
'					End If
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 2 Then
'						itmX.SubItems(2).Text = VB6.Format(CDbl(LblAankoop.Text), "#,##0.00")
'					Else
'						itmX.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB6.Format(CDbl(LblAankoop.Text), "#,##0.00")))
'					End If
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 3 Then
'						itmX.SubItems(3).Text = VB6.Format(CDbl(LblAankoopNieuw.Text), "#,##0.00")
'					Else
'						itmX.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB6.Format(CDbl(LblAankoopNieuw.Text), "#,##0.00")))
'					End If
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 4 Then
'						itmX.SubItems(4).Text = VB6.Format(CDbl(LblVerkoop.Text), "#,##0.00")
'					Else
'						itmX.SubItems.Insert(4, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB6.Format(CDbl(LblVerkoop.Text), "#,##0.00")))
'					End If
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 5 Then
'						itmX.SubItems(5).Text = VB6.Format(CDbl(LblVerkoopNieuw.Text), "#,##0.00")
'					Else
'						itmX.SubItems.Insert(5, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB6.Format(CDbl(LblVerkoopNieuw.Text), "#,##0.00")))
'					End If
'				End If
'			End If
'			rsKPK.MoveNext()
'		Loop 
'		rsKPK.Close()
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal
'		If frmADOXlog.lvDetail.Items.Count = 0 Then
'			MsgBox("Geen SKPK's in selectie", MsgBoxStyle.Information)
'			cmdSchoon_Click(cmdSchoon, New System.EventArgs())
'			Me.Activate()
'			Exit Sub
'		Else
'			frmADOXlog.lblAantal(0).Text = CStr(frmADOXlog.lvDetail.Items.Count)
'		End If
'		frmADOXlog.cmdOptie.Text = "Prijs Wijzigen"
'		frmADOXlog.ShowDialog()

'		Dim TempoTekst As String
'		TempoTekst = GRIDTEXT
'		Do While TempoTekst <> ""
'			cmdSchoon_Click(cmdSchoon, New System.EventArgs())
'			MSG = "11" & VB.Left(TempoTekst, InStr(TempoTekst, vbCr) - 1)
'			X = adoGet(TABLE_VARIOUS, 1, "=", MSG)
'			If Not X Then MsgBox("Onlogische situatie", MsgBoxStyle.Critical)
'			JetGet(TABLE_PRODUCTS, 0, VB.Left(TempoTekst, InStr(TempoTekst, vbCr) - 1))
'			If KTRL Then
'				MsgBox("Onlogische situatie", MsgBoxStyle.Critical)
'			Else
'				RecordToField(TABLE_PRODUCTS)
'				LblProduktInfo.Text = AdoGetField(TABLE_PRODUCTS, "#v102 #") & vbCr & AdoGetField(TABLE_PRODUCTS, "#v105 #")
'				CmdSProdukt.Text = AdoGetField(TABLE_PRODUCTS, "#v102 #")
'				If BH_EURO Then
'					LblAankoop.Text = VB6.Format(Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")), "#,##0.000000")
'					LblVerkoop.Text = VB6.Format(Val(AdoGetField(TABLE_PRODUCTS, "#e112 #")), "#,##0.000000")
'				Else
'					LblAankoop.Text = VB6.Format(Val(AdoGetField(TABLE_PRODUCTS, "#v113 #")), "#,##0.000000")
'					LblVerkoop.Text = VB6.Format(Val(AdoGetField(TABLE_PRODUCTS, "#v112 #")), "#,##0.000000")
'				End If
'				GRIDTEXT = adoBibTekst(RS_MAR(TABLE_VARIOUS).Fields("MEMO"), "#v214 #")
'				Do While GRIDTEXT <> ""
'					'UPGRADE_WARNING: Couldn't resolve default property of object AAA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'					AAA = Mid(GRIDTEXT, 1, InStr(GRIDTEXT, vbTab) - 1)
'					JetGet(TABLE_PRODUCTS, 0, (AAA))
'					If KTRL Then
'					Else
'						RecordToField(TABLE_PRODUCTS)
'						aa = AdoGetField(TABLE_PRODUCTS, "#v102 #") & vbTab
'						aa = aa & AdoGetField(TABLE_PRODUCTS, "#v105 #") & vbTab
'						If BH_EURO Then
'							aa = aa & Dec(Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")), MASK_SY(2) & "0000") & vbTab
'							aa = aa & Dec(Val(AdoGetField(TABLE_PRODUCTS, "#e112 #")), MASK_SY(2) & "0000") & vbTab
'						Else
'							aa = aa & Dec(Val(AdoGetField(TABLE_PRODUCTS, "#v113 #")), MASK_SY(2) & "0000") & vbTab
'							aa = aa & Dec(Val(AdoGetField(TABLE_PRODUCTS, "#v112 #")), MASK_SY(2) & "0000") & vbTab
'						End If
'						aa = aa & Mid(fmarBoxText("004", "2", AdoGetField(TABLE_PRODUCTS, "#v106 #")), 4) & vbTab
'					End If
'					Antwoord = Mid(GRIDTEXT, InStr(GRIDTEXT, vbTab) + 1, InStr(GRIDTEXT, vbCrLf) - InStr(GRIDTEXT, vbTab) - 1)
'					aa = aa & Dec(Val(Antwoord), MASK_SY(4) & "0")
'					grdProduktDetail.AddItem(aa, grdProduktDetail.Rows - 1)
'					GRIDTEXT = Mid(GRIDTEXT, InStr(GRIDTEXT, vbCrLf) + 2)
'				Loop 
'				X = MaakTotaal
'				JetGet(TABLE_PRODUCTS, 0, VB.Left(TempoTekst, InStr(TempoTekst, vbCr) - 1))
'				If KTRL Then
'					MsgBox("Onlogische situatie", MsgBoxStyle.Critical)
'				Else
'					RecordToField(TABLE_PRODUCTS)
'					If BH_EURO Then
'						AdoInsertToRecord(TABLE_PRODUCTS, Dec(CDbl(LblVerkoopNieuw.Text), "#######.000000"), "e112")
'						AdoInsertToRecord(TABLE_PRODUCTS, Dec(CDbl(LblAankoopNieuw.Text), "#######.000000"), "e113")
'					Else
'						AdoInsertToRecord(TABLE_PRODUCTS, Dec(CDbl(LblVerkoopNieuw.Text), "#######.000000"), "v112")
'						AdoInsertToRecord(TABLE_PRODUCTS, Dec(CDbl(LblAankoopNieuw.Text), "#######.000000"), "v113")
'					End If
'					bUpdate(TABLE_PRODUCTS, 0)
'				End If
'			End If
'			TempoTekst = Mid(TempoTekst, InStr(TempoTekst, vbCr) + 1)
'		Loop 
'		cmdSchoon_Click(cmdSchoon, New System.EventArgs())
'		Me.Activate()

'	End Sub


'	Private Sub cmdSchoon_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSchoon.Click

'		Schoon()

'	End Sub

'	Private Sub CmdSprodukt_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdSprodukt.Click

'		If GrdProduktIsGewijzigd Then
'			MSG = "Huidige wijzigingen negeren." & vbCrLf & vbCrLf
'			MSG = MSG & "Bent U zeker ?"
'			CTRL_BOX = MsgBox(MSG, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Wijziging wegschrijven")
'			If CTRL_BOX = MsgBoxResult.Yes Then
'			Else
'				Exit Sub
'			End If
'		End If

'		A_INDEX = 0
'		SHARED_FL = TABLE_PRODUCTS
'		SqlSearch.ShowDialog()
'		If KTRL = 0 Then
'			If AdoGetField(TABLE_PRODUCTS, "#v108 #") <> "S" Then
'				MsgBox("Dit is geen produkt van het type 'standaardkostprijs' !")
'				Exit Sub
'			Else
'				X = Instal
'				grdProduktDetail.Focus()
'				CmdSProdukt.Enabled = False
'			End If
'		Else
'			Schoon()
'		End If
'	End Sub


'	Private Sub cmdVerbruik_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdVerbruik.Click

'		JetGet(TABLE_PRODUCTS, 0, (LblProduktInfo.Text))
'		If KTRL Then
'			MsgBox("onlogica")
'		Else
'			Schoon()
'			Stop
'			X = Instal
'		End If


'	End Sub

'	Private Sub CmdWegschrijven_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdWegschrijven.Click
'		Dim aa As String
'		Dim Teller As Short

'		MSG = "Huidige definitie wegschrijven." & vbCrLf & vbCrLf
'		MSG = MSG & "Bent U zeker ?"
'		CTRL_BOX = MsgBox(MSG, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, "Wegschrijven")
'		If CTRL_BOX = MsgBoxResult.Yes Then
'			JetGet(TABLE_VARIOUS, 1, SetSpacing("11" & CmdSProdukt.Text, 20))
'			If KTRL Then
'			Else
'				Do 
'					Bdelete(TABLE_VARIOUS)
'					bNext(TABLE_VARIOUS)
'					If KTRL Or SetSpacing(KEY_BUF(TABLE_VARIOUS), 20) <> SetSpacing("11" & CmdSProdukt.Text, 20) Then
'						Exit Do
'					End If
'				Loop 
'			End If
'			aa = ""
'			For Teller = 1 To grdProduktDetail.Rows - 2
'				grdProduktDetail.Row = Teller
'				grdProduktDetail.Col = 0
'				aa = aa & Trim(grdProduktDetail.Text) & vbTab
'				grdProduktDetail.Col = 5
'				aa = aa & Trim(grdProduktDetail.Text) & vbCrLf
'				If Len(aa) > 32000 Then
'					'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'					GoSub SchrijfEensWeg
'				End If
'			Next 
'			'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'			If Len(aa) > 0 Then GoSub SchrijfEensWeg

'			MSG = "Gewijzigde aankoop- en/of verkoopprijs wegschrijven." & vbCrLf & vbCrLf
'			MSG = MSG & "Bent U zeker ?"
'			CTRL_BOX = MsgBox(MSG, MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1, "Prijzen bijwerken")
'			If CTRL_BOX = MsgBoxResult.Yes Then
'				JetGet(TABLE_PRODUCTS, 0, (CmdSProdukt.Text))
'				If KTRL Then
'					MsgBox("onlogische situatie")
'				Else
'					RecordToField(TABLE_PRODUCTS)
'					If BH_EURO Then
'						AdoInsertToRecord(TABLE_PRODUCTS, Dec(CDbl(LblVerkoopNieuw.Text), "#######.000000"), "e112")
'						AdoInsertToRecord(TABLE_PRODUCTS, Dec(CDbl(LblAankoopNieuw.Text), "#######.000000"), "e113")
'					Else
'						AdoInsertToRecord(TABLE_PRODUCTS, Dec(CDbl(LblVerkoopNieuw.Text), "#######.000000"), "v112")
'						AdoInsertToRecord(TABLE_PRODUCTS, Dec(CDbl(LblAankoopNieuw.Text), "#######.000000"), "v113")
'					End If
'					bUpdate(TABLE_PRODUCTS, 0)
'				End If
'			End If
'			Schoon()
'		End If
'		Exit Sub

'SchrijfEensWeg: 
'		TLB_RECORD(TABLE_VARIOUS) = ""
'		AdoInsertToRecord(TABLE_VARIOUS, (CmdSProdukt.Text), "v102")
'		AdoInsertToRecord(TABLE_VARIOUS, "11" & CmdSProdukt.Text, "v005")
'		AdoInsertToRecord(TABLE_VARIOUS, aa, "v214")
'		JetInsert(TABLE_VARIOUS, 1)
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'	End Sub


'	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
'		Dim aa As String
'		Dim AAA As Object
'		Dim Antwoord As String

'		Dim PrijsAantepassen As Boolean

'		If cbPrijswijziging.CheckState = 1 Then
'			PrijsAantepassen = True
'		Else
'			PrijsAantepassen = False
'		End If

'		'on error resume next
'		Err.Clear()
'		rsKPK.CursorLocation = ADODB.CursorLocationEnum.adUseClient
'		MSG = "SELECT * FROM Allerlei WHERE v005 Like '11%'"
'		SnelHelpPrint(MSG, BL_LOGGING)
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
'		rsKPK.Open(MSG, AD_NTDB, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
'		If Err.Number Then
'			MsgBox("Bron:" & vbCrLf & Err.Source & vbCrLf & vbCrLf & "Foutnummer: " & Err.Number & vbCrLf & vbCrLf & "Detail:" & vbCrLf & Err.Description)
'			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'			'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = vbNormal
'			Exit Sub
'		ElseIf rsKPK.RecordCount = 0 Then 
'			MsgBox("Geen standaardkostprijskaarten te vinden.", MsgBoxStyle.Information)
'			'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'			'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'			'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'			System.Windows.Forms.Cursor.Current = vbNormal
'			rsKPK.Close()
'			Exit Sub
'		End If
'		SnelHelpPrint("Lijst samenstellen voor " & rsKPK.RecordCount & " lijnen", BL_LOGGING)
'		frmADOXlog.Close()
'		frmADOXlog.Hide()

'		If PrijsAantepassen Then
'			frmADOXlog.Text = "SKPK's voor Prijsaanpassing"
'		Else
'			frmADOXlog.Text = "SKPK's Totaallijst"
'		End If
'		With frmADOXlog.lvDetail
'			' Add ColumnHeaders. The width of the columns is
'			' the width of the control divided by the number of
'			' ColumnHeader objects.
'			.Columns.Add("", "Omschrijving", CInt(VB6.TwipsToPixelsX(2625)))
'			.Columns.Add("", "Nummer SKPK", CInt(VB6.TwipsToPixelsX(1620)))
'			.Columns.Add("AK Huidig", CInt(VB6.TwipsToPixelsX(1215)), System.Windows.Forms.HorizontalAlignment.Right)
'			.Columns.Add("AK Nieuw", CInt(VB6.TwipsToPixelsX(1215)), System.Windows.Forms.HorizontalAlignment.Right)
'			.Columns.Add("VK Huidig", CInt(VB6.TwipsToPixelsX(1215)), System.Windows.Forms.HorizontalAlignment.Right)
'			.Columns.Add("VK Nieuw", CInt(VB6.TwipsToPixelsX(1215)), System.Windows.Forms.HorizontalAlignment.Right)

'			' Set View property to Report.
'			.View = System.Windows.Forms.View.Details
'		End With

'		Dim itmX As System.Windows.Forms.ListViewItem

'		Do While Not rsKPK.EOF
'			TotaalAankoop = 0
'			TotaalVerkoop = 0
'			TotaalAankoopNieuw = 0
'			TotaalVerkoopNieuw = 0

'			JetGet(TABLE_PRODUCTS, 0, Mid(rsKPK.Fields("v005").Value, 3))
'			If KTRL Then
'			Else
'				RecordToField(TABLE_PRODUCTS)
'				X = LijstInstal
'				If Not PrijsAantepassen Then
'					' Add a ListItem object.
'					itmX = frmADOXlog.lvDetail.Items.Add(kpkProductOMS)
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 1 Then
'						itmX.SubItems(1).Text = kpkProductNR
'					Else
'						itmX.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, kpkProductNR))
'					End If
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 2 Then
'						itmX.SubItems(2).Text = VB6.Format(TotaalAankoop, "#,##0.00")
'					Else
'						itmX.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB6.Format(TotaalAankoop, "#,##0.00")))
'					End If
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 3 Then
'						itmX.SubItems(3).Text = VB6.Format(TotaalAankoopNieuw, "#,##0.00")
'					Else
'						itmX.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB6.Format(TotaalAankoopNieuw, "#,##0.00")))
'					End If
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 4 Then
'						itmX.SubItems(4).Text = VB6.Format(TotaalVerkoop, "#,##0.00")
'					Else
'						itmX.SubItems.Insert(4, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB6.Format(TotaalVerkoop, "#,##0.00")))
'					End If
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 5 Then
'						itmX.SubItems(5).Text = VB6.Format(TotaalVerkoopNieuw, "#,##0.00")
'					Else
'						itmX.SubItems.Insert(5, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB6.Format(TotaalVerkoopNieuw, "#,##0.00")))
'					End If
'				ElseIf TotaalAankoop = TotaalAankoopNieuw And TotaalVerkoop = TotaalVerkoopNieuw Then 
'				Else
'					' Add a ListItem object.
'					itmX = frmADOXlog.lvDetail.Items.Add(kpkProductOMS)
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 1 Then
'						itmX.SubItems(1).Text = kpkProductNR
'					Else
'						itmX.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, kpkProductNR))
'					End If
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 2 Then
'						itmX.SubItems(2).Text = VB6.Format(TotaalAankoop, "#,##0.00")
'					Else
'						itmX.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB6.Format(TotaalAankoop, "#,##0.00")))
'					End If
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 3 Then
'						itmX.SubItems(3).Text = VB6.Format(TotaalAankoopNieuw, "#,##0.00")
'					Else
'						itmX.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB6.Format(TotaalAankoopNieuw, "#,##0.00")))
'					End If
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 4 Then
'						itmX.SubItems(4).Text = VB6.Format(TotaalVerkoop, "#,##0.00")
'					Else
'						itmX.SubItems.Insert(4, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB6.Format(TotaalVerkoop, "#,##0.00")))
'					End If
'					'UPGRADE_WARNING: Lower bound of collection itmX has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
'					If itmX.SubItems.Count > 5 Then
'						itmX.SubItems(5).Text = VB6.Format(TotaalVerkoopNieuw, "#,##0.00")
'					Else
'						itmX.SubItems.Insert(5, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, VB6.Format(TotaalVerkoopNieuw, "#,##0.00")))
'					End If
'				End If
'			End If
'			rsKPK.MoveNext()
'		Loop 
'		rsKPK.Close()
'		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
'		'UPGRADE_ISSUE: Screen property Screen.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
'		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
'		System.Windows.Forms.Cursor.Current = vbNormal
'		If frmADOXlog.lvDetail.Items.Count = 0 Then
'			MsgBox("Geen SKPK's in selectie", MsgBoxStyle.Information)
'			cmdSchoon_Click(cmdSchoon, New System.EventArgs())
'			Me.Activate()
'			Exit Sub
'		Else
'			frmADOXlog.lblAantal(0).Text = CStr(frmADOXlog.lvDetail.Items.Count)
'		End If
'		frmADOXlog.cmdOptie.Text = "Prijs Wijzigen"
'		frmADOXlog.ShowDialog()

'		Dim TempoTekst As String
'		TempoTekst = GRIDTEXT
'		Do While TempoTekst <> ""
'			TotaalAankoop = 0
'			TotaalVerkoop = 0
'			TotaalAankoopNieuw = 0
'			TotaalVerkoopNieuw = 0
'			MSG = "11" & VB.Left(TempoTekst, InStr(TempoTekst, vbCr) - 1)
'			X = adoGet(TABLE_VARIOUS, 1, "=", MSG)
'			If Not X Then MsgBox("Onlogische situatie", MsgBoxStyle.Critical)
'			JetGet(TABLE_PRODUCTS, 0, VB.Left(TempoTekst, InStr(TempoTekst, vbCr) - 1))
'			If KTRL Then
'				MsgBox("Onlogische situatie", MsgBoxStyle.Critical)
'			Else
'				RecordToField(TABLE_PRODUCTS)
'				X = LijstInstal
'				JetGet(TABLE_PRODUCTS, 0, VB.Left(TempoTekst, InStr(TempoTekst, vbCr) - 1))
'				RecordToField(TABLE_PRODUCTS)
'				AdoInsertToRecord(TABLE_PRODUCTS, Dec(TotaalVerkoopNieuw, "#######.000000"), "e112")
'				AdoInsertToRecord(TABLE_PRODUCTS, Dec(TotaalAankoopNieuw, "#######.000000"), "e113")
'				bUpdate(TABLE_PRODUCTS, 0)
'			End If
'			TempoTekst = Mid(TempoTekst, InStr(TempoTekst, vbCr) + 1)
'		Loop 
'		cmdSchoon_Click(cmdSchoon, New System.EventArgs())
'		Me.Activate()

'	End Sub

'	Private Sub StandaardKostPrijsKaart_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

'		If Not Toegankelijk(Me) Then
'			Me.Close()
'			Exit Sub
'		End If

'		Top = 0
'		Left = 0

'		rsKPK = New ADODB.Recordset

'		AantalDeelProdukten = 0
'		With grdProduktDetail
'			.Rows = AantalDeelProdukten + 2
'			.Cols = 8

'			.Col = 0
'			.Row = 0
'			.set_ColWidth(0, 1290)
'			.set_ColAlignment(0, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
'			.Text = "Artikelnr."

'			.Col = 1
'			.set_ColWidth(1, 3015)
'			.set_ColAlignment(1, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
'			.Text = "Omschrijving"

'			.Col = 2
'			.set_ColWidth(2, 1095)
'			.set_ColAlignment(2, 1)
'			.set_ColAlignment(2, MSFlexGridLib.AlignmentSettings.flexAlignRightCenter)
'			.Text = "AKprijs/"

'			.Col = 3
'			.set_ColWidth(3, 1095)
'			.set_ColAlignment(3, MSFlexGridLib.AlignmentSettings.flexAlignRightCenter)
'			.Text = "VKprijs/"

'			.Col = 4
'			.set_ColWidth(4, 795)
'			.set_ColAlignment(4, MSFlexGridLib.AlignmentSettings.flexAlignLeftCenter)
'			.Text = "maatstaf"

'			.Col = 5
'			.set_ColWidth(5, 945)
'			.set_ColAlignment(5, MSFlexGridLib.AlignmentSettings.flexAlignRightCenter)
'			.Text = "Verbruik"

'			.Col = 6
'			.set_ColWidth(6, 1045)
'			.set_ColAlignment(6, MSFlexGridLib.AlignmentSettings.flexAlignRightCenter)
'			.Text = "€ Verbruik"

'			.Col = 7
'			.set_ColWidth(7, 1045)
'			.set_ColAlignment(7, MSFlexGridLib.AlignmentSettings.flexAlignRightCenter)
'			.Text = "€ Productie"

'		End With

'		GrdProduktIsGewijzigd = False
'		cmdSchoon_Click(cmdSchoon, New System.EventArgs())

'	End Sub

'	Private Sub StandaardKostPrijsKaart_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

'		On Error Resume Next
'		rsKPK.Close()
'		On Error Resume Next
'		'UPGRADE_NOTE: Object rsKPK may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
'		rsKPK = Nothing

'	End Sub


'	Private Sub GrdProduktDetail_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles GrdProduktDetail.Enter

'		SnelHelpPrint("Deelprodukten : [Insert]/[+] om toe te voegen, [Delete]/[-] om te verwijderen", BL_LOGGING)

'	End Sub

'	Private Sub GrdProduktDetail_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_KeyDownEvent) Handles GrdProduktDetail.KeyDownEvent

'		KtrlKEYPRess(eventArgs.KeyCode)

'	End Sub


'	Private Function Instal() As Boolean

'		Dim aa As String
'		Dim Antwoord As String
'		Dim verbruikBedrag As Decimal
'		Dim productieBedrag As Decimal
'		Dim productiecumul As Decimal

'		LblProduktInfo.Text = AdoGetField(TABLE_PRODUCTS, "#v102 #") & vbCrLf & AdoGetField(TABLE_PRODUCTS, "#v105 #")
'		CmdSProdukt.Text = AdoGetField(TABLE_PRODUCTS, "#v102 #")

'		JetGet(TABLE_VARIOUS, 1, SetSpacing("11" & CmdSProdukt.Text, 20))
'		NietAanwezig = KTRL
'		GrdProduktIsGewijzigd = False

'		If BH_EURO Then
'			LblAankoop.Text = VB6.Format(Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")), "#,##0.000000")
'			LblVerkoop.Text = VB6.Format(Val(AdoGetField(TABLE_PRODUCTS, "#e112 #")), "#,##0.000000")
'		Else
'			LblAankoop.Text = VB6.Format(Val(AdoGetField(TABLE_PRODUCTS, "#v113 #")), "#,##0.000000")
'			LblVerkoop.Text = VB6.Format(Val(AdoGetField(TABLE_PRODUCTS, "#v112 #")), "#,##0.000000")
'		End If
'		If NietAanwezig Then
'			CmdWegschrijven.Enabled = False
'			CmdProduktieFiche.Enabled = False
'			AantalDeelProdukten = 0
'			LblAankoopNieuw.Text = VB6.Format(0, "#,##0.000000")
'			LblVerkoopNieuw.Text = VB6.Format(0, "#,##0.000000")
'		Else
'			Do 
'				RecordToField(TABLE_VARIOUS)
'				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'				GoSub VoegLijnERBij
'				bNext(TABLE_VARIOUS)
'				If KTRL Or SetSpacing(KEY_BUF(TABLE_VARIOUS), 20) <> SetSpacing("11" & CmdSProdukt.Text, 20) Then
'					Exit Do
'				End If
'			Loop 
'			CmdWegschrijven.Enabled = True
'			CmdProduktieFiche.Enabled = True
'			X = MaakTotaal
'		End If
'		Exit Function

'VoegLijnERBij: 
'		GRIDTEXT = AdoGetField(TABLE_VARIOUS, "#v214 #")
'		Do While GRIDTEXT <> ""
'			JetGet(TABLE_PRODUCTS, 0, Mid(GRIDTEXT, 1, InStr(GRIDTEXT, vbTab) - 1))
'			If KTRL Then
'				aa = Mid(GRIDTEXT, 1, InStr(GRIDTEXT, vbTab) - 1) & vbTab
'				aa = aa & "Niet meer aanwezig !!" & vbTab
'				aa = aa & "0" & vbTab
'				aa = aa & "--" & vbTab
'			Else
'				RecordToField(TABLE_PRODUCTS)
'				aa = AdoGetField(TABLE_PRODUCTS, "#v102 #") & vbTab
'				aa = aa & AdoGetField(TABLE_PRODUCTS, "#v105 #") & vbTab
'				aa = aa & Dec(Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")), MASK_SY(2) & "00") & vbTab
'				aa = aa & Dec(Val(AdoGetField(TABLE_PRODUCTS, "#e112 #")), MASK_SY(2) & "00") & vbTab
'				aa = aa & Mid(fmarBoxText("004", "2", AdoGetField(TABLE_PRODUCTS, "#v106 #")), 4) & vbTab
'			End If
'			Antwoord = Mid(GRIDTEXT, InStr(GRIDTEXT, vbTab) + 1, InStr(GRIDTEXT, vbCrLf) - InStr(GRIDTEXT, vbTab) - 1)
'			aa = aa & Dec(Val(Antwoord), MASK_SY(4) & "0") & vbTab

'			verbruikBedrag = Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")) * Val(Antwoord)
'			aa = aa & VB6.Format(verbruikBedrag, "#,##0.00") & vbTab
'			productieBedrag = verbruikBedrag * Val(txtVerbruik.Text)
'			productiecumul = productiecumul + productieBedrag
'			aa = aa & VB6.Format(productieBedrag, "#,##0.00")
'			grdProduktDetail.AddItem(aa, grdProduktDetail.Rows - 1)
'			GRIDTEXT = Mid(GRIDTEXT, InStr(GRIDTEXT, vbCrLf) + 2)
'		Loop 
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'	End Function


'	Private Sub Schoon()

'		LblProduktInfo.Text = ""
'		CmdWegschrijven.Enabled = False
'		CmdProduktieFiche.Enabled = False
'		GrdProduktIsGewijzigd = False
'		CmdSProdukt.Text = "Samengesteld produkt &Zoeken"
'		CmdSProdukt.Enabled = True

'		LblAankoop.Text = VB6.Format(0, "#,##0.00")
'		LblVerkoop.Text = VB6.Format(0, "#,##0.00")
'		LblAankoopNieuw.Text = VB6.Format(0, "#,##0.00")
'		LblVerkoopNieuw.Text = VB6.Format(0, "#,##0.00")

'		With grdProduktDetail
'			.Rows = 2
'			.Col = 0
'			.Row = 1
'			.Text = ""

'			.Col = 1
'			.Text = ""

'			.Col = 2
'			.Text = ""

'			.Col = 3
'			.Text = ""

'			.Col = 4
'			.Text = ""

'			.Col = 5
'			.Text = ""

'			.Col = 6
'			.Text = ""

'			.Col = 7
'			.Text = ""
'		End With

'	End Sub

'	Private Function LijstInstal() As Boolean

'		Dim aa As String
'		Dim Antwoord As String

'		LijstInstal = False
'		kpkProductOMS = AdoGetField(TABLE_PRODUCTS, "#v105 #")
'		kpkProductNR = AdoGetField(TABLE_PRODUCTS, "#v102 #")

'		JetGet(TABLE_VARIOUS, 1, SetSpacing("11" & kpkProductNR, 20))
'		NietAanwezig = KTRL
'		GrdProduktIsGewijzigd = False

'		TotaalAankoop = Val(AdoGetField(TABLE_PRODUCTS, "#e113 #"))
'		TotaalVerkoop = Val(AdoGetField(TABLE_PRODUCTS, "#e112 #"))
'		TotaalAankoopNieuw = 0
'		TotaalVerkoopNieuw = 0

'		If NietAanwezig Then
'			AantalDeelProdukten = 0
'		Else
'			Do 
'				RecordToField(TABLE_VARIOUS)
'				'UPGRADE_ISSUE: GoSub statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C5A1A479-AB8B-4D40-AAF4-DB19A2E5E77F"'
'				GoSub VoegLijnERBij2
'				bNext(TABLE_VARIOUS)
'				If KTRL Or SetSpacing(KEY_BUF(TABLE_VARIOUS), 20) <> SetSpacing("11" & kpkProductNR, 20) Then
'					Exit Do
'				End If
'			Loop 
'		End If

'		Exit Function

'VoegLijnERBij2: 
'		GRIDTEXT = AdoGetField(TABLE_VARIOUS, "#v214 #")
'		Do While GRIDTEXT <> ""
'			JetGet(TABLE_PRODUCTS, 0, Mid(GRIDTEXT, 1, InStr(GRIDTEXT, vbTab) - 1))
'			If KTRL Then
'				aa = Mid(GRIDTEXT, 1, InStr(GRIDTEXT, vbTab) - 1) & vbTab
'				aa = aa & "Niet meer aanwezig !!" & vbTab
'				aa = aa & "0" & vbTab
'				aa = aa & "--" & vbTab
'			Else
'				RecordToField(TABLE_PRODUCTS)
'				aa = AdoGetField(TABLE_PRODUCTS, "#v102 #") & vbTab
'				aa = aa & AdoGetField(TABLE_PRODUCTS, "#v105 #") & vbTab
'				aa = aa & Dec(Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")), MASK_SY(2) & "00") & vbTab
'				aa = aa & Dec(Val(AdoGetField(TABLE_PRODUCTS, "#e112 #")), MASK_SY(2) & "00") & vbTab
'				aa = aa & Mid(fmarBoxText("004", "2", AdoGetField(TABLE_PRODUCTS, "#v106 #")), 4) & vbTab
'			End If

'			Antwoord = Mid(GRIDTEXT, InStr(GRIDTEXT, vbTab) + 1, InStr(GRIDTEXT, vbCrLf) - InStr(GRIDTEXT, vbTab) - 1)
'			aa = aa & Dec(Val(Antwoord), MASK_SY(4) & "0") & vbTab

'			verbruikBedrag = Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")) * Val(Antwoord)
'			aa = aa & VB6.Format(verbruikBedrag, "#,##0.00") & vbTab
'			productieBedrag = verbruikBedrag * Val(txtVerbruik.Text)
'			productiecumul = productiecumul + productieBedrag
'			aa = aa & VB6.Format(productieBedrag, "#,##0.00")
'			GRIDTEXT = Mid(GRIDTEXT, InStr(GRIDTEXT, vbCrLf) + 2)
'			TotaalAankoopNieuw = TotaalAankoopNieuw + (Val(AdoGetField(TABLE_PRODUCTS, "#e113 #")) * Val(Antwoord))
'			TotaalVerkoopNieuw = TotaalVerkoopNieuw + (Val(AdoGetField(TABLE_PRODUCTS, "#e112 #")) * Val(Antwoord))
'		Loop 
'		'UPGRADE_WARNING: Return has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
'		Return 

'	End Function
'End Class