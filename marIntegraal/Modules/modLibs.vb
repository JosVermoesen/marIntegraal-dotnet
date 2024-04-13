Option Strict Off
Option Explicit On

Module ModLibs

    Public CustomerSheet As New FrmBasicSheetTemplate
    Public SupplierSheet As New FrmBasicSheetTemplate
    Public LedgerAccountSheet As New FrmBasicSheetTemplate
    'Public BJPERDAT As New frmBYPERDAT

    Public Const FullLine As String = "--------------------------------------------------------------------------------------------------------------------------------"

    'Mijn dokumenten, ApplicatieData
    Public Const CSIDL_PERSONAL As Integer = &H5
    Public Const CSIDL_APPDATA As Integer = &H1A
    Public Const CSIDL_PROGRAM_FILES As Integer = &H26

    Public Const TABLE_STR As String = "Tabel"
    Public Const ATTACHED_STR As String = "Verbonden"
    Public Const QUERY_STR As String = "Opzoeking"
    Public Const FIELD_STR As String = "Kolom"
    Public Const FIELDS_STR As String = "Kolommen"
    Public Const INDEX_STR As String = "Index"
    Public Const INDEXES_STR As String = "Indexen"
    Public Const PROPERTY_STR As String = "Eigenschap"
    Public Const PROPERTIES_STR As String = "Eigenschappen"

    Public Const adoJetProvider As String = "Provider=Microsoft.Jet.OLEDB.4.0;"

    Public gnodDBNode As System.Windows.Forms.TreeNode 'current database node in treeview
    Public gnodDBNode2 As System.Windows.Forms.TreeNode 'backup of current database node i

    'marNT constanten
    Public Const NumberOfTables As Short = 9
    Public Const TableOfVarious As Short = 0
    Public Const TableOfCustomers As Short = 1
    Public Const TableOfSuppliers As Short = 2
    Public Const TableOfLedgerAccounts As Short = 3
    Public Const TableOfProductsAndServices As Short = 4
    Public Const TableOfContracts As Short = 5
    Public Const TableOfInvoices As Short = 6
    Public Const FlJournaal As Short = 7
    Public Const TableDummy As Short = 8
    Public Const TableOfCounters As Short = 9
    Public Const TableOfAsLog As Short = 10

    Public Const PeriodAsText As Short = 0
    Public Const BookyearAsText As Short = 1
    Public Const PeriodeAsKey As Short = 2
    Public Const BookyearAsKey As Short = 3
    Public Const SISO As String = "001*002*002*003*004*005*006*007*008*009*010*011*030*032*038*046*053*054*055*060*061*063*064*091*600*"
    Public Const maxTeleBib As Short = 150
    Public Const maxIndex As Short = 5
    Public Const maxPLUS As Short = 6
    Public Const Reading As Boolean = True
    Public Const ReadingLock As Boolean = False

    Public Const MaskEURX As String = "######0.0000"
    Public Const MaskEURBH As String = "########0.00"

    Public Const MaskBEF As String = "##########"
    Public Const MaskEUR As String = "######0.00"

    Public Const Euro As Double = 40.3399
    Public Const BelgianFrank As Short = 1

    <VBFixedString(16)> Public A As String
    <VBFixedString(4)> Public aa As String
    <VBFixedString(30)> Public AAA As String

    Public MaskSy(8) As String
    Public Mask2002 As String 'VB6.FixedLengthString(10)
    Public vsfPro As Boolean

    Public ApplicationPrinter As String
    Public SysVar(6) As String
    Public FileNr(NumberOfTables) As Short
    Public TLBRecord(NumberOfTables) As String
    Public KeyBuf(NumberOfTables) As String
    Public TableDefOnt(NumberOfTables) As String
    Public KeyIndex(NumberOfTables) As Short
    Public InsertFlag(NumberOfTables) As Short
    Public FlAantalIndexen(10) As Short
    Public JetTableUseIndex(NumberOfTables, 10) As String
    Public FlIndexLen(NumberOfTables, 10) As Short
    Public FLIndexCaption(NumberOfTables, 10) As String
    Public ListIDX(5, 10) As String
    Public FVT(NumberOfTables, 10) As String
    Public aIndex As Integer
    Public DaysInAMonth(12) As Short
    'UPGRADE_ISSUE: Declaration type not supported: Array of fixed-length strings. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="934BD4FF-1FF9-47BD-888F-D411E47E78FA"'
    Public MonthText(12) As String '*9
    Public SetUpRecNum(25) As Short

    Public EscCodesPrinter(2) As Short
    Public PaperLength(2) As Short
    Public PrinterINI(2) As String

    Public ReportField(23) As String
    Public ReportTab(23) As Short
    Public ReportSecondLineField(23) As String
    Public ReportSecondLineTab(23) As Short

    'UPGRADE_ISSUE: Declaration type not supported: Array of fixed-length strings. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="934BD4FF-1FF9-47BD-888F-D411E47E78FA"'
    Public TeleBibCode(maxTeleBib) As String '*10
    'UPGRADE_ISSUE: Declaration type not supported: Array of fixed-length strings. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="934BD4FF-1FF9-47BD-888F-D411E47E78FA"'
    Public TeleBibTekst(maxTeleBib) As String '*35
    'UPGRADE_ISSUE: Declaration type not supported: Array of fixed-length strings. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="934BD4FF-1FF9-47BD-888F-D411E47E78FA"'
    Public TeleBibType(maxTeleBib) As String '*1
    Public TeleBibLengte(maxTeleBib) As Short
    Public TeleBibPos(maxTeleBib) As Short
    Public TeleBibLast As Short

    Public FL99 As Short
    Public Fl99Record As String
    Public PrinterCurrentY As Short
    Public PageCounter As Short


    Public marVersion As String
    Public LogPrint As String
    Public blLogging As Boolean

    Public dKtrlCumul As Decimal
    Public dKtrlBEF As Decimal
    Public dKtrlEUR As Decimal

    Public bModus As Short
    Public CountTo As Short

    Public PeriodFromTo As String ' New VB6.FixedLengthString(16)
    Public BookyearFromTo As String 'New VB6.FixedLengthString(16)
    Public ActiveBookyear As Short
    Public MimGlobalDate As String 'New VB6.FixedLengthString(10)
    Public VatBobTheBuilders As Boolean
    Public DirecteVerkoopString As String

    Public LocationCompanyData As String
    Public LocationNetData As String
    Public ProgramLocation As String
    Public Location As String
    Public LocationAsWeb As String
    Public LocationMyDocuments As String

    Public ProducentNummer As String 'New VB6.FixedLengthString(8)
    Public Eigenaar As String 'New VB6.FixedLengthString(8)
    Public Fl As Short
    Public SharedFl As Short
    Public SharedScanFl As Short
    Public Ktrl As Short
    Public KtrlLong As Integer
    Public SharedIndex As Integer
    Public AktieveFiche As Short

    Public blMilieu As Boolean
    Public MilieuGridText As String
    Public GridText As String
    Public GridTextKwijting As String
    Public GridTextIs As String
    Public GridTextPolis As Object
    Public GridText9 As String
    Public GridRows As Short
    Public XLogKey As String

    Public XLogKassa As String

    Public dKtrCumul As Double
    Public SetupVelden As Short
    Public BedrijfKeuze As String
    Public dMuntL As Double
    Public Msg As String
    Public KtrlBox As Short
    Public SQLBevel As String
    Public DoEventsStatus As Short
    Public VsoftLog As Short
    Public ProgrammaVersie As String
    Public LockHold As Short

    'Public KBTable As DAO.Recordset
    Public ntDB As DAO.Database
    Public ntRS(9) As DAO.Recordset
    Public NTRuimte As DAO.Workspace


    Public adKBDB As ADODB.Connection
    Public adKBTable As ADODB.Recordset

    Public adntDB As ADODB.Connection
    Public adntDBSQLS As ADODB.Connection

    Public adTBIB As ADODB.Connection
    Public rsWaarden As ADODB.Recordset
    Public rsJournaal As ADODB.Recordset
    Public rsMAR(9) As ADODB.Recordset
    Public sqlMsg(9) As String
    Public jetConnect As String
    Public SQLConnect As String

    Public XDoEvents As Short
    Public JetTableName(9) As String
    Public AddNewStatus(9) As Short
    'UPGRADE_ISSUE: Declaration type not supported: Array of fixed-length strings. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="934BD4FF-1FF9-47BD-888F-D411E47E78FA"'
    Public vBC(9, 200) As String '*4
    Public BAModus As Short

    Public TestEuroModus As Boolean
    Public bhEuro As Boolean
    Public XisEuroWasBEF As Boolean

    Public TimerTijd As Date
    Public RetVal As Object
    Public Figuur1 As Object
    Public Figuur2 As Object

    Public LijstPrinterNr As Short
    Public dokumentPrinterNr As Short
    Public KassaPrinterNr As Short

    Public FormReference As FrmBasicSheetTemplate
    'UPGRADE_WARNING: Lower bound of array BasisB was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
    'UPGRADE_WARNING: Arrays can't be declared with New. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC9D3AE5-6B95-4B43-91C7-28276302A5E8"'
    Public BasisB(3) As FrmBasicSheetTemplate
    Public JumpForm As Object

    Public fs As Scripting.FileSystemObject

    Public CashRegisterTicketTotal As Decimal
    Public CashRegisterTotal As Decimal
    Public CashRegisterPayingBEF As Decimal
    Public CashRegisterPayingEUR As Decimal
    Public CashRegisterBackEUR As Decimal

    Public CashRegisterTotalBEF As Decimal
    Public CashRegisterTotalEUR As Decimal

    Public DecimalKTRL As Boolean

    'marIntegraal.NET
    'Public xpW As Word.dokument
    Public usrLicentieInfo As String
    Public JournaalLocked As Boolean
    Public usrMailAdres As String
    Public usrPW As String

    Public pdfVsoftFrom As Double
    Public pdfVsoftTo As Double
    Public pdfAddressXpos As Double
    Public pdfAddressYpos As Double
    Public pdfAddressXpos2 As Double
    Public pdfAddressYpos2 As Double
End Module