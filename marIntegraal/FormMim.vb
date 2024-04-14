Option Strict Off
Option Explicit On
Imports System.ComponentModel

Public Class Mim
    Inherits Form

    Sub InitFirst()

        TableDefOnt(TableOfVarious) = "0000000.ONT" '00
        TableDefOnt(TableOfCustomers) = "0010000.ONT" '01
        TableDefOnt(TableOfSuppliers) = "0020000.ONT" '02
        TableDefOnt(TableOfLedgerAccounts) = "0030000.ONT" '03
        TableDefOnt(TableOfProductsAndServices) = "0040000.ONT" '04
        TableDefOnt(FlJournaal) = "0600000.ONT" '05
        TableDefOnt(TableOfInvoices) = "0200000.ONT" '06
        TableDefOnt(TableOfContracts) = "0700000.ONT" '07
        TableDefOnt(TableDummy) = "90DUMMY.ONT" '08
        TableDefOnt(TableOfCounters) = "00.ONT" '09

        JetTableName(TableOfVarious) = "Allerlei" '00
        JetTableName(TableOfCustomers) = "Klanten" '01
        JetTableName(TableOfSuppliers) = "Leveranciers" '02
        JetTableName(TableOfLedgerAccounts) = "Rekeningen" '03
        JetTableName(TableOfProductsAndServices) = "Produkten" '04
        JetTableName(FlJournaal) = "Journalen" '05
        JetTableName(TableOfInvoices) = "dokumenten" '06
        JetTableName(TableOfContracts) = "Polissen" '07
        JetTableName(TableDummy) = "TmpBestand" '08
        JetTableName(TableOfCounters) = "Tell" '09

        DaysInAMonth(1) = 31
        DaysInAMonth(2) = 29
        DaysInAMonth(3) = 31
        DaysInAMonth(4) = 30
        DaysInAMonth(5) = 31
        DaysInAMonth(6) = 30
        DaysInAMonth(7) = 31
        DaysInAMonth(8) = 31
        DaysInAMonth(9) = 30
        DaysInAMonth(10) = 31
        DaysInAMonth(11) = 30
        DaysInAMonth(12) = 31

        MonthText(1) = "Januari  "
        MonthText(2) = "Februari "
        MonthText(3) = "Maart    "
        MonthText(4) = "April    "
        MonthText(5) = "Mei      "
        MonthText(6) = "Juni     "
        MonthText(7) = "Juli     "
        MonthText(8) = "Augustus "
        MonthText(9) = "September"
        MonthText(10) = "October  "
        MonthText(11) = "November "
        MonthText(12) = "December "
        InitTables()

    End Sub

    Private Sub TotalClose()

        marVersion = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision
        AutoUnloadCompany(BJPERDAT:=FormBYPERDAT)
        For CountTo = 0 To 9
            rsMAR(CountTo) = Nothing
        Next
        'TODO: adKBDB.Close()
        adKBDB = Nothing

        On Error Resume Next
        adntDB.Close()
        If Err.Number Then Exit Sub
        ntDB.Close()

        adntDB = Nothing
        ntDB = Nothing

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
        MimGlobalDate = Format(Now, "dd/MM/yyyy")
        ProgramLocation = My.Application.Info.DirectoryPath & "\"

        marVersion = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision
        Text = "marIntegraal.NET " & marVersion
        StartUp()
        SettingsLoading(Me)

        On Error GoTo 0

        adKBDB = New ADODB.Connection
        adTBIB = New ADODB.Connection

        'adKBDB.ConnectionString = marIntegraal.My.Settings.defaultConnectionString
        adKBDB.ConnectionString = adoJetProvider & "Data Source=" & ProgramLocation & "Def\default.def;" & "Persist Security Info=False"
        adKBDB.Open()

        adTBIB.ConnectionString = adoJetProvider & "Data Source=" & ProgramLocation & "\Def\Telebib2.def;" & "Persist Security Info=False"
        adTBIB.Open()

        adKBTable = New ADODB.Recordset With {
            .CursorLocation = ADODB.CursorLocationEnum.adUseServer
        }
        adKBTable.Open("KeuzeBoxData", adKBDB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTableDirect) '  adLockReadOnly, adCmdTableDirect
        adKBTable.Index = "BestandsNaam"
        With CustomerSheet
            .MdiParent = Me
            .Text = "Klanten"
            .BackColor = ColorTranslator.FromOle(QBColor(9))
            .Tag = "1"
            .WindowState = FormWindowState.Minimized
            .Enabled = False
            .Show()
        End With

        With SupplierSheet
            .MdiParent = Me
            .Text = "Leveranciers"
            .BackColor = ColorTranslator.FromOle(QBColor(12))
            .Tag = "2"
            .WindowState = FormWindowState.Minimized
            .Enabled = False
            .Show()
        End With

        With LedgerAccountSheet
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
            If CustomerSheet.Enabled = True Then
            Else
                GaVerder = True
                Exit Function
            End If
        End If
        KtrlBox = MsgBox(Bericht & vbCrLf & vbCrLf & "Bent U zeker ?", 292, Titel)
        If KtrlBox = 6 Then
            GaVerder = True
        Else
            GaVerder = False
        End If
    End Function

    ' Actions
    Private Sub CompanyOpenMenuItem_Click(sender As Object, e As EventArgs)
        MSG = "Hierna worden eerst alle bestanden en openstaande vensters van een actief bedrijf gesloten."
        If GaVerder(MSG, 1, "Bedrijf Openen") Then
            Ktrl = 100
            AutoUnloadCompany(BJPERDAT:=FormBYPERDAT)
            On Error Resume Next
            ntDB.Close()
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
            Ktrl = 100
            AutoUnloadCompany(BJPERDAT:=FormBYPERDAT)
            On Error Resume Next
            ntDB.Close()
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
        Ktrl = 100
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
        CustomerSheet.WindowState = FormWindowState.Normal
    End Sub
    Private Sub SupplierSheetMenuItem_Click(sender As Object, e As EventArgs)
        SupplierSheet.WindowState = FormWindowState.Normal
    End Sub
    Private Sub LedgerAccountSheetMenuItem_Click(sender As Object, e As EventArgs)
        LedgerAccountSheet.WindowState = FormWindowState.Normal
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
        aIndex = TableOfSuppliers
        With BSBook
            .WindowState = FormWindowState.Normal
            .Enabled = True
            .ShowDialog()
            .Dispose()
        End With
    End Sub
    Private Sub SalesDiaryMenuItem_Click(sender As Object, e As EventArgs)
        aIndex = TableOfCustomers
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
        Dim StatusVatDeclaration As New FormVatDeclaration
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
    End Sub
    Private Sub CommandToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim myDocumentsFolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim myDocProcess As New Process

        myDocProcess.StartInfo.FileName = "cmd.exe"
        myDocProcess.StartInfo.WorkingDirectory = myDocumentsFolderPath
        myDocProcess.StartInfo.UseShellExecute = True
        myDocProcess.StartInfo.CreateNoWindow = True
        myDocProcess.Start()

        If LocationCompanyData IsNot "" Then
            Dim myCompanyProcess As New Process
            myCompanyProcess.StartInfo.FileName = "cmd.exe"
            myCompanyProcess.StartInfo.WorkingDirectory = LocationCompanyData
            myCompanyProcess.StartInfo.UseShellExecute = True
            myCompanyProcess.StartInfo.CreateNoWindow = True
            myCompanyProcess.Start()
        End If

    End Sub

End Class
