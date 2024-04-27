Option Strict Off
Option Explicit On
Imports System.ComponentModel

Public Class Mim
    Inherits Form

    Sub InitFirst()

        TABLEDEF_ONT(TABLE_VARIOUS) = "0000000.ONT" '00
        TABLEDEF_ONT(TABLE_CUSTOMERS) = "0010000.ONT" '01
        TABLEDEF_ONT(TABLE_SUPPLIERS) = "0020000.ONT" '02
        TABLEDEF_ONT(TABLE_LEDGERACCOUNTS) = "0030000.ONT" '03
        TABLEDEF_ONT(TABLE_PRODUCTS) = "0040000.ONT" '04
        TABLEDEF_ONT(TABLE_JOURNAL) = "0600000.ONT" '05
        TABLEDEF_ONT(TABLE_INVOICES) = "0200000.ONT" '06
        TABLEDEF_ONT(TABLE_CONTRACTS) = "0700000.ONT" '07
        TABLEDEF_ONT(TABLE_DUMMY) = "90DUMMY.ONT" '08
        TABLEDEF_ONT(TABLE_COUNTERS) = "00.ONT" '09

        JET_TABLENAME(TABLE_VARIOUS) = "Allerlei" '00
        JET_TABLENAME(TABLE_CUSTOMERS) = "Klanten" '01
        JET_TABLENAME(TABLE_SUPPLIERS) = "Leveranciers" '02
        JET_TABLENAME(TABLE_LEDGERACCOUNTS) = "Rekeningen" '03
        JET_TABLENAME(TABLE_PRODUCTS) = "Produkten" '04
        JET_TABLENAME(TABLE_JOURNAL) = "Journalen" '05
        JET_TABLENAME(TABLE_INVOICES) = "dokumenten" '06
        JET_TABLENAME(TABLE_CONTRACTS) = "Polissen" '07
        JET_TABLENAME(TABLE_DUMMY) = "TmpBestand" '08
        JET_TABLENAME(TABLE_COUNTERS) = "Tell" '09

        DAYS_IN_MONTH(1) = 31
        DAYS_IN_MONTH(2) = 29
        DAYS_IN_MONTH(3) = 31
        DAYS_IN_MONTH(4) = 30
        DAYS_IN_MONTH(5) = 31
        DAYS_IN_MONTH(6) = 30
        DAYS_IN_MONTH(7) = 31
        DAYS_IN_MONTH(8) = 31
        DAYS_IN_MONTH(9) = 30
        DAYS_IN_MONTH(10) = 31
        DAYS_IN_MONTH(11) = 30
        DAYS_IN_MONTH(12) = 31

        MONTH_AS_TEXT(1) = "Januari  "
        MONTH_AS_TEXT(2) = "Februari "
        MONTH_AS_TEXT(3) = "Maart    "
        MONTH_AS_TEXT(4) = "April    "
        MONTH_AS_TEXT(5) = "Mei      "
        MONTH_AS_TEXT(6) = "Juni     "
        MONTH_AS_TEXT(7) = "Juli     "
        MONTH_AS_TEXT(8) = "Augustus "
        MONTH_AS_TEXT(9) = "September"
        MONTH_AS_TEXT(10) = "October  "
        MONTH_AS_TEXT(11) = "November "
        MONTH_AS_TEXT(12) = "December "
        InitTables()

    End Sub

    Private Sub TotalClose()

        MAR_VERSION = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision
        AutoUnloadCompany(BJPERDAT:=FormBYPERDAT)
        For COUNT_TO = 0 To 9
            RS_MAR(COUNT_TO) = Nothing
        Next
        'TODO: AD_KBDB.Close()
        AD_KBDB = Nothing

        On Error Resume Next
        AD_NTDB.Close()
        If Err.Number Then Exit Sub
        NT_DB.Close()

        AD_NTDB = Nothing
        NT_DB = Nothing

    End Sub

    Private Sub Mim_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim hierCancel As Boolean = e.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = CloseReason.ApplicationExitCall
        If Me.Report.IsOpen = True Then
            MsgBox("Sluit eerst het PDF venster a.u.b.", MsgBoxStyle.Information)
            hierCancel = True
        End If
        e.Cancel = hierCancel
    End Sub

    Private Sub Mim_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Dim X As Boolean
        TotalClose()
        If WindowState = FormWindowState.Minimized Then
            WindowState = FormWindowState.Normal
        End If
        X = SettingsSaving(Me)
        On Error Resume Next

    End Sub

    Private Sub Mim_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitFirst()
        MIM_GLOBAL_DATE = Format(Now, "dd/MM/yyyy")
        PROGRAM_LOCATION = My.Application.Info.DirectoryPath & "\"

        MAR_VERSION = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision
        Text = "marIntegraal.NET " & MAR_VERSION
        StartUp()
        SettingsLoading(Me)

        On Error GoTo 0

        AD_KBDB = New ADODB.Connection
        AD_TBIB = New ADODB.Connection

        'AD_KBDB.ConnectionString = marIntegraal.My.Settings.defaultConnectionString
        AD_KBDB.ConnectionString = ADOJET_PROVIDER & "Data Source=" & PROGRAM_LOCATION & "Def\DEFAULT.DEF;" & "Persist Security Info=False"
        AD_KBDB.Open()

        AD_TBIB.ConnectionString = ADOJET_PROVIDER & "Data Source=" & PROGRAM_LOCATION & "\Def\TELEBIB2.DEF;" & "Persist Security Info=False"
        AD_TBIB.Open()

        AD_KBTable = New ADODB.Recordset With {
            .CursorLocation = ADODB.CursorLocationEnum.adUseServer
        }
        AD_KBTable.Open("KeuzeBoxData", AD_KBDB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect) '  adLockReadOnly, adCmdTableDirect
        AD_KBTable.Index = "BestandsNaam"

        With CUSTOMERS_SHEET
            .MdiParent = Me
            .Text = "Klanten"
            .BackColor = ColorTranslator.FromOle(QBColor(9))
            .Tag = "1"
            .WindowState = FormWindowState.Minimized
            .Enabled = False
            .Show()
        End With

        With SUPPLIERS_SHEET
            .MdiParent = Me
            .Text = "Leveranciers"
            .BackColor = ColorTranslator.FromOle(QBColor(12))
            .Tag = "2"
            .WindowState = FormWindowState.Minimized
            .Enabled = False
            .Show()
        End With

        With LEDGERACCOUNTS_SHEET
            .MdiParent = Me
            .Text = "Rekeningen"
            .BackColor = ColorTranslator.FromOle(QBColor(15))
            .Tag = "3"
            .WindowState = FormWindowState.Minimized
            .Enabled = False
            .Show()
        End With
        CompanyOpenMenuItem_Click(sender, e)

    End Sub

    Private Function GaVerder(ByRef Bericht As String, ByRef BedrijfOpenKontrole As Short, ByRef Titel As String) As Short
        If BedrijfOpenKontrole Then
            If CUSTOMERS_SHEET.Enabled = True Then
            Else
                GaVerder = True
                Exit Function
            End If
        End If
        CTRL_BOX = MsgBox(Bericht & vbCrLf & vbCrLf & "Bent U zeker ?", 292, Titel)
        If CTRL_BOX = 6 Then
            GaVerder = True
        Else
            GaVerder = False
        End If
    End Function

    ' Actions
    Private Sub CompanyOpenMenuItem_Click(sender As Object, e As EventArgs)
        MSG = "Hierna worden eerst alle bestanden en openstaande vensters van een actief bedrijf gesloten."
        If GaVerder(MSG, 1, "Bedrijf Openen") Then
            KTRL = 100
            AutoUnloadCompany(BJPERDAT:=FormBYPERDAT)
            On Error Resume Next
            NT_DB.Close()
            On Error GoTo 0
            CompanyOpenMenuItem.Enabled = False
            CompanyNewMenuItem.Enabled = False
            Dim BedrijfOpenen As New FrmCompanyOpen With {
                .MdiParent = Me
            }
            BedrijfOpenen.Show()
        End If
    End Sub
    Private Sub CompanyNewMenuItem_Click(sender As Object, e As EventArgs)
        MSG = "Hierna worden eerst alle bestanden en openstaande vensters van een actief bedrijf gesloten."
        If GaVerder(MSG, 1, "Nieuw Bedrijf") Then
            KTRL = 100
            AutoUnloadCompany(BJPERDAT:=FormBYPERDAT)
            On Error Resume Next
            NT_DB.Close()
            On Error GoTo 0
            CompanyOpenMenuItem.Enabled = False
            CompanyNewMenuItem.Enabled = False
            Dim NieuwBedrijf As New FrmCompanyNew With {
                .MdiParent = Me
            }
            NieuwBedrijf.Show()
        End If
    End Sub
    Private Sub CloseAppMenuItem_Click(sender As Object, e As EventArgs)
        KTRL = 100
        'TotalClose()
        Close()
    End Sub

    ' System
    Private Sub SettingsFinancialYearMenuItem_Click(sender As Object, e As EventArgs)
        FrmSettingsFinancialYear.ShowDialog()
    End Sub
    Private Sub BookyearPeriodDateMenuItem_Click(sender As Object, e As EventArgs)
        FormBYPERDAT.WindowState = FormWindowState.Normal
    End Sub
    Private Sub VpeLayOutOutgoingMenuItem_Click(sender As Object, e As EventArgs)
        Dim LayOutDocument As New LayOutpdfDokument
        VpeLayOutOutgoingMenuItem.Enabled = False
        LayOutpdfDokument.Show()
    End Sub
    Private Sub SQLOperationsMenuItem_Click(sender As Object, e As EventArgs)
        Dim SqlBewerkingen As New SqlOperations
        SQLOperationsMenuItem.Enabled = False
        SqlBewerkingen.Show()
    End Sub

    ' Windows
    Private Sub CascadeMenuItem_Click(sender As Object, e As EventArgs)
        LayoutMdi(MdiLayout.Cascade)
    End Sub
    Private Sub TileHorizontalMenuItem_Click(sender As Object, e As EventArgs)
        LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    Private Sub TileVerticalMenuItem_Click(sender As Object, e As EventArgs)
        LayoutMdi(MdiLayout.TileVertical)
    End Sub
    Private Sub ArrangeIconsMenuItem_Click(sender As Object, e As EventArgs)
        LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub
    Private Sub AccessTestMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("AccessTestMenuItem_Click")
    End Sub

    ' Sheets
    Private Sub CustomerSheetMenuItem_Click(sender As Object, e As EventArgs)
        CUSTOMERS_SHEET.WindowState = FormWindowState.Normal
    End Sub
    Private Sub SupplierSheetMenuItem_Click(sender As Object, e As EventArgs)
        SUPPLIERS_SHEET.WindowState = FormWindowState.Normal
    End Sub
    Private Sub LedgerAccountSheetMenuItem_Click(sender As Object, e As EventArgs)
        LEDGERACCOUNTS_SHEET.WindowState = FormWindowState.Normal
    End Sub
    Private Sub ProductSheetMenuItem_Click(sender As Object, e As EventArgs)
        Dim ProductFiche As New frmProductFiche With {
            .MdiParent = Me
        }
        ProductSheetMenuItem.Enabled = False
        ProductFiche.Show()
    End Sub
    Private Sub VariousSheetsMenuItem_Click(sender As Object, e As EventArgs)
        With XDocument
            .WindowState = FormWindowState.Normal
            .Enabled = True
            .ShowDialog()
            .Dispose()
        End With
    End Sub
    Private Sub ReportingTableDataMenuItem_Click(sender As Object, e As EventArgs)
        With LijstRapportage
            .WindowState = FormWindowState.Normal
            .Enabled = True
            .ShowDialog()
            .Dispose()
        End With
    End Sub
    Private Sub LedgerHistoryOnScreenMenuItem_Click(sender As Object, e As EventArgs)
        LedgerHistoryOnScreenMenuItem.Enabled = False
        With HistoriekRekeningScherm
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Enabled = True
            .Show()
        End With
    End Sub

    ' Documents
    Private Sub PurchaseTransactionMenuItem_Click(sender As Object, e As EventArgs)
        Dim AankoopVerrichtingen As New frmAankoopVerrichtingen With {
            .MdiParent = Me
        }
        PurchaseTransactionMenuItem.Enabled = False
        AankoopVerrichtingen.Show()
    End Sub
    Private Sub SalesTransactionMenuItem_Click(sender As Object, e As EventArgs)
        Dim VerkoopVerrichtingen As New frmVerkoopVerrichtingen With {
            .MdiParent = Me
        }
        SalesTransactionMenuItem.Enabled = False
        VerkoopVerrichtingen.Show()
    End Sub
    Private Sub FinancialTransactionMenuItem_Click(sender As Object, e As EventArgs)
        FinancialTransactionMenuItem.Enabled = False
        With FinancieleVerrichtingen
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Enabled = True
            .Show()
        End With
    End Sub
    Private Sub CashRegisterSalesMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("CashRegisterSalesMenuItem_Click")
    End Sub
    Private Sub BillingFollowUpMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("BillingFollowUpMenuItem_Click")
    End Sub
    Private Sub ElectronicPaymentMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("ElectronicPaymentMenuItem_Click")
    End Sub
    Private Sub StandardCostCardMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("StandardCostCardMenuItem_Click")
    End Sub
    Private Sub CorrespondenceMenuItem_Click(sender As Object, e As EventArgs)
        CorrespondenceMenuItem.Enabled = False
        With Briefwisseling
            .MdiParent = Me
            .WindowState = FormWindowState.Normal
            .Enabled = True
            .Show()
        End With
    End Sub

    ' Accounting
    Private Sub JournalEntryInputMenuItem_Click(sender As Object, e As EventArgs)
        Dim VariousJournalEntries As New FormJournalEntryInput With {
            .MdiParent = Me
        }
        JournalEntryInputMenuItem.Enabled = False
        VariousJournalEntries.Show()
    End Sub
    Private Sub JournalEntriesBookMenuItem_Click(sender As Object, e As EventArgs)
        Dim JournalEntriesBook As New FormJournalEntriesBook
        'JournalEntriesBook.MdiParent = Me
        JournalEntriesBook.ShowDialog()
    End Sub
    Private Sub PurchaseDiaryMenuItem_Click(sender As Object, e As EventArgs)
        A_INDEX = TABLE_SUPPLIERS
        With BSBook
            .WindowState = FormWindowState.Normal
            .Enabled = True
            .ShowDialog()
            .Dispose()
        End With
    End Sub
    Private Sub SalesDiaryMenuItem_Click(sender As Object, e As EventArgs)
        A_INDEX = TABLE_CUSTOMERS
        With BSBook
            .WindowState = FormWindowState.Normal
            .Enabled = True
            .ShowDialog()
            .Dispose()
        End With
    End Sub
    Private Sub FinancialJournalMenuItem_Click(sender As Object, e As EventArgs)
        Dim FinancialBook As New FormFinancialBook
        FinancialBook.ShowDialog()
    End Sub
    Private Sub VATDomesticAnnualListingMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("VATDomesticAnnualListingMenuItem_Click")
    End Sub
    Private Sub VATReturnStatusMenuItem_Click(sender As Object, e As EventArgs)
        Dim StatusVatDeclaration As New FormVatDeclarations
        StatusVatDeclaration.ShowDialog()
    End Sub
    Private Sub InventoryControlMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("InventoryControlMenuItem_Click")
    End Sub
    Private Sub TrialBalanceMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("TrialBalanceMenuItem_Click")
    End Sub
    Private Sub JournalHistoryMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("JournalHistoryMenuItem_Click")
    End Sub
    Private Sub FinalReportingMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("FinalReportingMenuItem_Click")
    End Sub
    Private Sub CustomersBalanceMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("CustomersBalanceMenuItem_Click")
    End Sub
    Private Sub TopdownCustomersMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("TopdownCustomersMenuItem_Click")
    End Sub
    Private Sub SuppliersBalansMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("SuppliersBalansMenuItem_Click")
    End Sub
    Private Sub TopdownSuppliersMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("TopdownSuppliersMenuItem_Click")
    End Sub
    Private Sub SetupNewFinancialYearMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("SetupNewFinancialYearMenuItem_Click")
    End Sub
    Private Sub CleanUpTablesMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("CleanUpTablesMenuItem_Click")
    End Sub

    ' Contracts
    Private Sub RequestForPaymentMenuItem_Click(sender As Object, e As EventArgs)
        Dim BetalingsVerzoeken As New BetalingsVerzoek
        RequestForPaymentMenuItem.Enabled = False
        BetalingsVerzoek.Show()
    End Sub
    Private Sub BookingReceiptMenuItem_Click(sender As Object, e As EventArgs)
        Dim InboekenKwijtingen As New KwijtingInboeken
        BookingReceiptMenuItem.Enabled = False
        KwijtingInboeken.Show()
    End Sub
    Private Sub FreeMessageToInsurerMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("FreeMessageToInsurerMenuItem_Click")
    End Sub
    Private Sub AswebGboExchangeMenuItem_Click(sender As Object, e As EventArgs)
        With TelebibIN
            .WindowState = FormWindowState.Normal
            .Enabled = True
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    ' Cloud Services
    ' TODO

    ' Info
    Private Sub VsoftToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start(New ProcessStartInfo("https://vsoft.be/#/marintegraal"))
    End Sub
    Private Sub HostingToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Process.Start(New ProcessStartInfo("https://web20.foxxl.com:8443"))
    End Sub
    Private Sub PleskMailToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start(New ProcessStartInfo("https://webmail.rv.be"))
    End Sub
    Private Sub LicentieToolStripMenuItem_Click(sender As Object, e As EventArgs)

        MessageBox.Show("Licentie")
        FormPostalCodesAndPlaces.Show()

    End Sub
    Private Sub CommandToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim myDocumentsFolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim myDocProcess As New Process

        myDocProcess.StartInfo.FileName = "cmd.exe"
        myDocProcess.StartInfo.WorkingDirectory = myDocumentsFolderPath
        myDocProcess.StartInfo.UseShellExecute = True
        myDocProcess.StartInfo.CreateNoWindow = True
        myDocProcess.Start()

        If LOCATION_COMPANYDATA IsNot "" Then
            Dim myCompanyProcess As New Process
            myCompanyProcess.StartInfo.FileName = "cmd.exe"
            myCompanyProcess.StartInfo.WorkingDirectory = LOCATION_COMPANYDATA
            myCompanyProcess.StartInfo.UseShellExecute = True
            myCompanyProcess.StartInfo.CreateNoWindow = True
            myCompanyProcess.Start()
        End If

    End Sub

End Class
