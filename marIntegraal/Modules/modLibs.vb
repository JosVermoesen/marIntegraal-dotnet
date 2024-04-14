Option Strict Off
Option Explicit On

Module ModLibs

    Public CUSTOMERS_SHEET As New FrmBasicSheetTemplate
    Public SUPPLIERS_SHEET As New FrmBasicSheetTemplate
    Public LEDGERACCOUNTS_SHEET As New FrmBasicSheetTemplate
    'Public BJPERDAT As New frmBYPERDAT

    Public Const FULL_LINE As String = "--------------------------------------------------------------------------------------------------------------------------------"

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

    Public Const ADOJET_PROVIDER As String = "Provider=Microsoft.Jet.OLEDB.4.0;"

    Public gnodDBNode As TreeNode 'current database node in treeview
    Public gnodDBNode2 As TreeNode 'backup of current database node i

    'marNT constanten
    Public Const NUMBER_TABLES As Short = 9
    Public Const TABLE_VARIOUS As Short = 0
    Public Const TABLE_CUSTOMERS As Short = 1
    Public Const TABLE_SUPPLIERS As Short = 2
    Public Const TABLE_LEDGERACCOUNTS As Short = 3
    Public Const TABLE_PRODUCTS As Short = 4
    Public Const TABLE_CONTRACTS As Short = 5
    Public Const TABLE_INVOICES As Short = 6
    Public Const TABLE_JOURNAL As Short = 7
    Public Const TABLE_DUMMY As Short = 8
    Public Const TABLE_COUNTERS As Short = 9
    Public Const TABLE_AS1LOG As Short = 10

    Public Const PERIODAS_TEXT As Short = 0
    Public Const BOOKYEARAS_TEXT As Short = 1
    Public Const PERIODAS_KEY As Short = 2
    Public Const BOOKYEARAS_KEY As Short = 3
    Public Const SISO As String = "001*002*002*003*004*005*006*007*008*009*010*011*030*032*038*046*053*054*055*060*061*063*064*091*600*"
    Public Const MAX_TELEBIB As Short = 150
    Public Const MAX_INDEX As Short = 5
    Public Const MAX_PLUS As Short = 6
    Public Const READING As Boolean = True
    Public Const READING_LOCK As Boolean = False

    Public Const MASK_EURX As String = "######0.0000"
    Public Const MASK_EURBH As String = "########0.00"

    Public Const MASK_BEF As String = "##########"
    Public Const MASK_EUR As String = "######0.00"

    Public Const EURO As Double = 40.3399
    Public Const BELGIAN_FRANC As Short = 1

    <VBFixedString(16)> Public A As String
    <VBFixedString(4)> Public aa As String
    <VBFixedString(30)> Public AAA As String

    Public MASK_SY(8) As String
    Public MASK_2002 As String 'VB6.FixedLengthString(10)
    Public VSF_PRO As Boolean

    Public APPLICATION_PRINTER As String
    Public SYS_VAR(6) As String
    Public FILE_NR(NUMBER_TABLES) As Short
    Public TLB_RECORD(NUMBER_TABLES) As String
    Public KEY_BUF(NUMBER_TABLES) As String
    Public TABLEDEF_ONT(NUMBER_TABLES) As String
    Public KEY_INDEX(NUMBER_TABLES) As Short
    Public INSERT_FLAG(NUMBER_TABLES) As Short
    Public FlAantalIndexen(10) As Short
    Public JETTABLEUSE_INDEX(NUMBER_TABLES, 10) As String
    Public FLINDEX_LEN(NUMBER_TABLES, 10) As Short
    Public FLINDEX_CAPTION(NUMBER_TABLES, 10) As String
    Public LIST_IDX(5, 10) As String
    Public FVT(NUMBER_TABLES, 10) As String
    Public A_INDEX As Integer
    Public DAYS_IN_MONTH(12) As Short
    Public MONTH_AS_TEXT(12) As String
    Public SETUP_RECNUM(25) As Short

    Public ESC_CODES_PRINTER(2) As Short
    Public PAPERLENGTH(2) As Short
    Public PRINTER_INI(2) As String

    Public REPORT_FIELD(23) As String
    Public REPORT_TAB(23) As Short
    Public REPORT_SECONDLINE_FIELD(23) As String
    Public REPORT_SECONDLINE_TAB(23) As Short


    Public TELEBIB_CODE(MAX_TELEBIB) As String
    Public TELEBIB_TEXT(MAX_TELEBIB) As String
    Public TELEBIB_TYPE(MAX_TELEBIB) As String
    Public TELEBIB_LENGHT(MAX_TELEBIB) As Short
    Public TELEBIB_POS(MAX_TELEBIB) As Short
    Public TELEBIB_LAST As Short

    Public FL99 As Short
    Public FL99_RECORD As String
    Public PRINTER_CURRENT_Y As Short
    Public PAGE_COUNTER As Short


    Public MAR_VERSION As String
    Public LOG_PRINT As String
    Public BL_LOGGING As Boolean

    Public DKTRL_CUMUL As Decimal
    Public DKTRL_BEF As Decimal
    Public DKTRL_EUR As Decimal

    Public B_MODUS As Short
    Public COUNT_TO As Short

    Public PERIOD_FROMTO As String ' New VB6.FixedLengthString(16)
    Public BOOKYEAR_FROMTO As String 'New VB6.FixedLengthString(16)
    Public ACTIVE_BOOKYEAR As Short
    Public MIM_GLOBAL_DATE As String 'New VB6.FixedLengthString(10)
    Public VAT_BOBTHEBUILDERS As Boolean
    Public DIRECTSELL_STRING As String

    Public LOCATION_COMPANYDATA As String
    Public LOCATION_NETDATA As String
    Public PROGRAM_LOCATION As String
    Public LOCATION As String
    Public LOCATION_ASWEB As String
    Public LOCATION_MYDOCUMENTS As String

    Public AGENT_NUMBER As String 'New VB6.FixedLengthString(8)
    Public OWNER As String 'New VB6.FixedLengthString(8)
    Public FL As Short
    Public SHARED_FL As Short
    Public SHAREDSCAN_FL As Short
    Public KTRL As Short
    Public KTRL_LONG As Integer
    Public SHARED_INDEX As Integer
    Public ACTIVE_SHEET As Short

    Public BL_ENVIRONMENT As Boolean
    Public ENVIRONMENT_GRIDTEXT As String
    Public GRIDTEXT As String
    Public GRIDTEXT_REMISSION As String
    Public GRIDTEXT_IS As String
    Public GRIDTEXT_POLICY As Object
    Public GRIDTEXT_9 As String
    Public GRID_ROWS As Short
    Public XLOG_KEY As String

    Public XLOG_CASHREGISTER As String

    Public DCTRL_CUMUL As Double
    Public SETUP_FIELDS As Short
    Public COMPANY_CHOISE As String
    Public D_CURRENCY As Double
    Public MSG As String
    Public CTRL_BOX As Short
    Public SQL_COMMAND As String
    Public DOEVENTS_STATUS As Short
    Public VSOFT_LOG As Short
    Public PROGRAM_VERSION As String
    Public LOCK_HOLD As Short

    'Public KBTable As DAO.Recordset
    Public NT_DB As DAO.Database
    Public NT_RS(9) As DAO.Recordset
    Public NT_SPACE As DAO.Workspace

    Public AD_KBDB As ADODB.Connection
    Public AD_KBTable As ADODB.Recordset

    Public AD_NTDB As ADODB.Connection
    Public AD_NTDB_SQLS As ADODB.Connection

    Public AD_TBIB As ADODB.Connection
    Public RS_VALUES As ADODB.Recordset
    Public RS_JOURNAL As ADODB.Recordset
    Public RS_MAR(9) As ADODB.Recordset
    Public SQL_MSG(9) As String
    Public JET_CONNECT As String
    Public SQL_CONNECT As String

    Public XDO_EVENTS As Short
    Public JET_TABLENAME(9) As String
    Public ADDNEW_STATUS(9) As Short

    Public VBC(9, 200) As String '*4
    Public BA_MODUS As Short

    Public TEST_EUROMODUS As Boolean
    Public BH_EURO As Boolean
    Public XisEUROWasBEF As Boolean

    Public TIMER_TIME As Date
    Public RETURN_VALUE As Object
    Public FIGURE1 As Object
    Public FIGURE2 As Object

    Public LISTPRINTER_NUMBER As Short
    Public DOCUMENTPRINTER_NUMBER As Short
    Public CASHPRINTER_NUMBER As Short

    Public FORM_REFERENCE As FrmBasicSheetTemplate
    Public BASIC(3) As FrmBasicSheetTemplate
    Public JUMP_FORM As Object

    Public FS As Scripting.FileSystemObject

    Public CashRegisterTicketTotal As Decimal
    Public CashRegisterTotal As Decimal
    Public CashRegisterPayingBEF As Decimal
    Public CashRegisterPayingEUR As Decimal
    Public CashRegisterBackEUR As Decimal

    Public CashRegisterTotalBEF As Decimal
    Public CashRegisterTotalEUR As Decimal

    Public DECIMAL_CTRL As Boolean

    'marIntegraal.NET
    'Public xpW As Word.dokument
    Public USER_LICENSEINFO As String
    Public JOURNAL_LOCKED As Boolean
    Public USER_MAILADDRESS As String
    Public USER_PASSWORD As String

    Public PDF_VSOFT_FROM As Double
    Public PDF_VSOFT_TO As Double
    Public PDF_ADDRESS_XPOS As Double
    Public PDF_ADDRESS_YPOS As Double
    Public PDF_ADDRESS_XPOS2 As Double
    Public PDF_ADDRESS_YPOS2 As Double

End Module