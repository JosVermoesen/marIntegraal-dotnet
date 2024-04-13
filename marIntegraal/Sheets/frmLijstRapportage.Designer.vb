<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LijstRapportage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdSQLOvername = New System.Windows.Forms.Button()
        Me.cmdToonSQL = New System.Windows.Forms.Button()
        Me.chkAfdrukLiggend = New System.Windows.Forms.CheckBox()
        Me.chkAfdrukInVenster = New System.Windows.Forms.CheckBox()
        Me._TekstInfo_5 = New System.Windows.Forms.TextBox()
        Me._DefEdit_3 = New System.Windows.Forms.Button()
        Me._TekstInfo_4 = New System.Windows.Forms.TextBox()
        Me._TekstInfo_3 = New System.Windows.Forms.TextBox()
        Me.Formattering = New System.Windows.Forms.ComboBox()
        Me._DefEdit_2 = New System.Windows.Forms.Button()
        Me._DefEdit_1 = New System.Windows.Forms.Button()
        Me.RapportVelden = New System.Windows.Forms.ListBox()
        Me._DefEdit_0 = New System.Windows.Forms.Button()
        Me.TabelVelden = New System.Windows.Forms.ListBox()
        Me._TekstInfo_2 = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Afdrukken = New System.Windows.Forms.Button()
        Me._TekstInfo_1 = New System.Windows.Forms.TextBox()
        Me._TekstInfo_0 = New System.Windows.Forms.TextBox()
        Me.Sortering = New System.Windows.Forms.ComboBox()
        Me.Definitie = New System.Windows.Forms.Button()
        Me.RapportDefinitie = New System.Windows.Forms.ComboBox()
        Me.Tabel = New System.Windows.Forms.ComboBox()
        Me.lblAantalInSelektie = New System.Windows.Forms.Label()
        Me._Label1_8 = New System.Windows.Forms.Label()
        Me._Label1_7 = New System.Windows.Forms.Label()
        Me._Label1_6 = New System.Windows.Forms.Label()
        Me._Label1_5 = New System.Windows.Forms.Label()
        Me._Label1_4 = New System.Windows.Forms.Label()
        Me._Label1_3 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me.lblInOntwikkeling = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'cmdSQLOvername
        '
        Me.cmdSQLOvername.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSQLOvername.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSQLOvername.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSQLOvername.Location = New System.Drawing.Point(324, 32)
        Me.cmdSQLOvername.Name = "cmdSQLOvername"
        Me.cmdSQLOvername.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSQLOvername.Size = New System.Drawing.Size(165, 20)
        Me.cmdSQLOvername.TabIndex = 65
        Me.cmdSQLOvername.Text = "SQL Resultaat via Generator"
        Me.cmdSQLOvername.UseVisualStyleBackColor = false
        '
        'cmdToonSQL
        '
        Me.cmdToonSQL.BackColor = System.Drawing.SystemColors.Control
        Me.cmdToonSQL.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdToonSQL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdToonSQL.Location = New System.Drawing.Point(324, 10)
        Me.cmdToonSQL.Name = "cmdToonSQL"
        Me.cmdToonSQL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdToonSQL.Size = New System.Drawing.Size(165, 20)
        Me.cmdToonSQL.TabIndex = 63
        Me.cmdToonSQL.TabStop = false
        Me.cmdToonSQL.Text = "&Toon SQL SELECT Definitie"
        Me.cmdToonSQL.UseVisualStyleBackColor = false
        '
        'chkAfdrukLiggend
        '
        Me.chkAfdrukLiggend.BackColor = System.Drawing.SystemColors.Control
        Me.chkAfdrukLiggend.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAfdrukLiggend.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAfdrukLiggend.Location = New System.Drawing.Point(2, 78)
        Me.chkAfdrukLiggend.Name = "chkAfdrukLiggend"
        Me.chkAfdrukLiggend.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAfdrukLiggend.Size = New System.Drawing.Size(154, 17)
        Me.chkAfdrukLiggend.TabIndex = 62
        Me.chkAfdrukLiggend.Text = "Liggende Printerafdruk"
        Me.chkAfdrukLiggend.UseVisualStyleBackColor = false
        '
        'chkAfdrukInVenster
        '
        Me.chkAfdrukInVenster.BackColor = System.Drawing.SystemColors.Control
        Me.chkAfdrukInVenster.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAfdrukInVenster.Checked = true
        Me.chkAfdrukInVenster.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAfdrukInVenster.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAfdrukInVenster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAfdrukInVenster.Location = New System.Drawing.Point(366, 82)
        Me.chkAfdrukInVenster.Name = "chkAfdrukInVenster"
        Me.chkAfdrukInVenster.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAfdrukInVenster.Size = New System.Drawing.Size(122, 17)
        Me.chkAfdrukInVenster.TabIndex = 61
        Me.chkAfdrukInVenster.Text = "Afdruk in venster"
        Me.chkAfdrukInVenster.UseVisualStyleBackColor = false
        '
        '_TekstInfo_5
        '
        Me._TekstInfo_5.AcceptsReturn = true
        Me._TekstInfo_5.BackColor = System.Drawing.SystemColors.Window
        Me._TekstInfo_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstInfo_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TekstInfo_5.Location = New System.Drawing.Point(134, 54)
        Me._TekstInfo_5.MaxLength = 0
        Me._TekstInfo_5.Name = "_TekstInfo_5"
        Me._TekstInfo_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstInfo_5.Size = New System.Drawing.Size(29, 20)
        Me._TekstInfo_5.TabIndex = 46
        '
        '_DefEdit_3
        '
        Me._DefEdit_3.BackColor = System.Drawing.SystemColors.Control
        Me._DefEdit_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._DefEdit_3.Enabled = false
        Me._DefEdit_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._DefEdit_3.Location = New System.Drawing.Point(272, 268)
        Me._DefEdit_3.Name = "_DefEdit_3"
        Me._DefEdit_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._DefEdit_3.Size = New System.Drawing.Size(83, 27)
        Me._DefEdit_3.TabIndex = 60
        Me._DefEdit_3.Text = "TabPositie"
        Me._DefEdit_3.UseVisualStyleBackColor = false
        '
        '_TekstInfo_4
        '
        Me._TekstInfo_4.AcceptsReturn = true
        Me._TekstInfo_4.BackColor = System.Drawing.SystemColors.Window
        Me._TekstInfo_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._TekstInfo_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstInfo_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TekstInfo_4.Location = New System.Drawing.Point(358, 322)
        Me._TekstInfo_4.MaxLength = 0
        Me._TekstInfo_4.Name = "_TekstInfo_4"
        Me._TekstInfo_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstInfo_4.Size = New System.Drawing.Size(75, 20)
        Me._TekstInfo_4.TabIndex = 59
        Me._TekstInfo_4.Visible = false
        '
        '_TekstInfo_3
        '
        Me._TekstInfo_3.AcceptsReturn = true
        Me._TekstInfo_3.BackColor = System.Drawing.SystemColors.Window
        Me._TekstInfo_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._TekstInfo_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstInfo_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TekstInfo_3.Location = New System.Drawing.Point(358, 322)
        Me._TekstInfo_3.MaxLength = 0
        Me._TekstInfo_3.Name = "_TekstInfo_3"
        Me._TekstInfo_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstInfo_3.Size = New System.Drawing.Size(269, 20)
        Me._TekstInfo_3.TabIndex = 58
        Me._TekstInfo_3.Visible = false
        '
        'Formattering
        '
        Me.Formattering.BackColor = System.Drawing.SystemColors.Window
        Me.Formattering.Cursor = System.Windows.Forms.Cursors.Default
        Me.Formattering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Formattering.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Formattering.Location = New System.Drawing.Point(358, 322)
        Me.Formattering.Name = "Formattering"
        Me.Formattering.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Formattering.Size = New System.Drawing.Size(269, 21)
        Me.Formattering.TabIndex = 57
        Me.Formattering.Visible = false
        '
        '_DefEdit_2
        '
        Me._DefEdit_2.BackColor = System.Drawing.SystemColors.Control
        Me._DefEdit_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._DefEdit_2.Enabled = false
        Me._DefEdit_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._DefEdit_2.Location = New System.Drawing.Point(272, 238)
        Me._DefEdit_2.Name = "_DefEdit_2"
        Me._DefEdit_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._DefEdit_2.Size = New System.Drawing.Size(83, 27)
        Me._DefEdit_2.TabIndex = 55
        Me._DefEdit_2.Text = "Formattering"
        Me._DefEdit_2.UseVisualStyleBackColor = false
        '
        '_DefEdit_1
        '
        Me._DefEdit_1.BackColor = System.Drawing.SystemColors.Control
        Me._DefEdit_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._DefEdit_1.Enabled = false
        Me._DefEdit_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._DefEdit_1.Location = New System.Drawing.Point(272, 208)
        Me._DefEdit_1.Name = "_DefEdit_1"
        Me._DefEdit_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._DefEdit_1.Size = New System.Drawing.Size(83, 27)
        Me._DefEdit_1.TabIndex = 54
        Me._DefEdit_1.Text = "Titel"
        Me._DefEdit_1.UseVisualStyleBackColor = false
        '
        'RapportVelden
        '
        Me.RapportVelden.BackColor = System.Drawing.SystemColors.Window
        Me.RapportVelden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RapportVelden.Cursor = System.Windows.Forms.Cursors.Default
        Me.RapportVelden.Enabled = false
        Me.RapportVelden.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RapportVelden.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RapportVelden.ItemHeight = 14
        Me.RapportVelden.Location = New System.Drawing.Point(358, 178)
        Me.RapportVelden.Name = "RapportVelden"
        Me.RapportVelden.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RapportVelden.Size = New System.Drawing.Size(269, 142)
        Me.RapportVelden.TabIndex = 53
        '
        '_DefEdit_0
        '
        Me._DefEdit_0.BackColor = System.Drawing.SystemColors.Control
        Me._DefEdit_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._DefEdit_0.Enabled = false
        Me._DefEdit_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._DefEdit_0.Location = New System.Drawing.Point(272, 178)
        Me._DefEdit_0.Name = "_DefEdit_0"
        Me._DefEdit_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._DefEdit_0.Size = New System.Drawing.Size(83, 27)
        Me._DefEdit_0.TabIndex = 52
        Me._DefEdit_0.Text = "Toevoegen"
        Me._DefEdit_0.UseVisualStyleBackColor = false
        '
        'TabelVelden
        '
        Me.TabelVelden.BackColor = System.Drawing.SystemColors.Window
        Me.TabelVelden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabelVelden.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabelVelden.Enabled = false
        Me.TabelVelden.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TabelVelden.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TabelVelden.ItemHeight = 14
        Me.TabelVelden.Location = New System.Drawing.Point(4, 178)
        Me.TabelVelden.Name = "TabelVelden"
        Me.TabelVelden.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabelVelden.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.TabelVelden.Size = New System.Drawing.Size(265, 142)
        Me.TabelVelden.TabIndex = 50
        '
        '_TekstInfo_2
        '
        Me._TekstInfo_2.AcceptsReturn = true
        Me._TekstInfo_2.BackColor = System.Drawing.SystemColors.Window
        Me._TekstInfo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._TekstInfo_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstInfo_2.Enabled = false
        Me._TekstInfo_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TekstInfo_2.Location = New System.Drawing.Point(100, 134)
        Me._TekstInfo_2.MaxLength = 0
        Me._TekstInfo_2.Name = "_TekstInfo_2"
        Me._TekstInfo_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstInfo_2.Size = New System.Drawing.Size(395, 20)
        Me._TekstInfo_2.TabIndex = 48
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(408, 58)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClose.Size = New System.Drawing.Size(81, 20)
        Me.btnClose.TabIndex = 44
        Me.btnClose.Text = "Sluiten"
        Me.btnClose.UseVisualStyleBackColor = false
        '
        'Afdrukken
        '
        Me.Afdrukken.BackColor = System.Drawing.SystemColors.Control
        Me.Afdrukken.Cursor = System.Windows.Forms.Cursors.Default
        Me.Afdrukken.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Afdrukken.Location = New System.Drawing.Point(408, -14)
        Me.Afdrukken.Name = "Afdrukken"
        Me.Afdrukken.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Afdrukken.Size = New System.Drawing.Size(81, 20)
        Me.Afdrukken.TabIndex = 43
        Me.Afdrukken.Text = "Af&drukken"
        Me.Afdrukken.UseVisualStyleBackColor = false
        '
        '_TekstInfo_1
        '
        Me._TekstInfo_1.AcceptsReturn = true
        Me._TekstInfo_1.BackColor = System.Drawing.SystemColors.Window
        Me._TekstInfo_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstInfo_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TekstInfo_1.Location = New System.Drawing.Point(212, 32)
        Me._TekstInfo_1.MaxLength = 0
        Me._TekstInfo_1.Name = "_TekstInfo_1"
        Me._TekstInfo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstInfo_1.Size = New System.Drawing.Size(109, 20)
        Me._TekstInfo_1.TabIndex = 42
        '
        '_TekstInfo_0
        '
        Me._TekstInfo_0.AcceptsReturn = true
        Me._TekstInfo_0.BackColor = System.Drawing.SystemColors.Window
        Me._TekstInfo_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstInfo_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TekstInfo_0.Location = New System.Drawing.Point(212, 10)
        Me._TekstInfo_0.MaxLength = 0
        Me._TekstInfo_0.Name = "_TekstInfo_0"
        Me._TekstInfo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstInfo_0.Size = New System.Drawing.Size(109, 20)
        Me._TekstInfo_0.TabIndex = 40
        '
        'Sortering
        '
        Me.Sortering.BackColor = System.Drawing.SystemColors.Window
        Me.Sortering.Cursor = System.Windows.Forms.Cursors.Default
        Me.Sortering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sortering.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Sortering.Location = New System.Drawing.Point(2, 30)
        Me.Sortering.Name = "Sortering"
        Me.Sortering.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Sortering.Size = New System.Drawing.Size(161, 21)
        Me.Sortering.TabIndex = 38
        '
        'Definitie
        '
        Me.Definitie.BackColor = System.Drawing.SystemColors.Control
        Me.Definitie.Cursor = System.Windows.Forms.Cursors.Default
        Me.Definitie.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Definitie.Location = New System.Drawing.Point(198, 80)
        Me.Definitie.Name = "Definitie"
        Me.Definitie.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Definitie.Size = New System.Drawing.Size(125, 20)
        Me.Definitie.TabIndex = 47
        Me.Definitie.TabStop = false
        Me.Definitie.Text = "&Nieuwe Definitie maken "
        Me.Definitie.UseVisualStyleBackColor = false
        '
        'RapportDefinitie
        '
        Me.RapportDefinitie.BackColor = System.Drawing.SystemColors.Window
        Me.RapportDefinitie.Cursor = System.Windows.Forms.Cursors.Default
        Me.RapportDefinitie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RapportDefinitie.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RapportDefinitie.Location = New System.Drawing.Point(166, -14)
        Me.RapportDefinitie.Name = "RapportDefinitie"
        Me.RapportDefinitie.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RapportDefinitie.Size = New System.Drawing.Size(239, 21)
        Me.RapportDefinitie.Sorted = true
        Me.RapportDefinitie.TabIndex = 36
        '
        'Tabel
        '
        Me.Tabel.BackColor = System.Drawing.SystemColors.Window
        Me.Tabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Tabel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Tabel.Location = New System.Drawing.Point(2, -14)
        Me.Tabel.Name = "Tabel"
        Me.Tabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tabel.Size = New System.Drawing.Size(161, 21)
        Me.Tabel.TabIndex = 34
        '
        'lblAantalInSelektie
        '
        Me.lblAantalInSelektie.BackColor = System.Drawing.SystemColors.Control
        Me.lblAantalInSelektie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAantalInSelektie.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAantalInSelektie.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAantalInSelektie.Location = New System.Drawing.Point(246, 54)
        Me.lblAantalInSelektie.Name = "lblAantalInSelektie"
        Me.lblAantalInSelektie.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAantalInSelektie.Size = New System.Drawing.Size(75, 19)
        Me.lblAantalInSelektie.TabIndex = 64
        Me.lblAantalInSelektie.Text = " "
        Me.lblAantalInSelektie.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_8
        '
        Me._Label1_8.AutoSize = true
        Me._Label1_8.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_8.Location = New System.Drawing.Point(4, 60)
        Me._Label1_8.Name = "_Label1_8"
        Me._Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_8.Size = New System.Drawing.Size(107, 13)
        Me._Label1_8.TabIndex = 45
        Me._Label1_8.Text = "&Lengte Sorteersleutel"
        '
        '_Label1_7
        '
        Me._Label1_7.BackColor = System.Drawing.SystemColors.Window
        Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Label1_7.Location = New System.Drawing.Point(360, 162)
        Me._Label1_7.Name = "_Label1_7"
        Me._Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_7.Size = New System.Drawing.Size(85, 13)
        Me._Label1_7.TabIndex = 56
        Me._Label1_7.Text = "Rapportvelden"
        '
        '_Label1_6
        '
        Me._Label1_6.BackColor = System.Drawing.SystemColors.Window
        Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Label1_6.Location = New System.Drawing.Point(6, 164)
        Me._Label1_6.Name = "_Label1_6"
        Me._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_6.Size = New System.Drawing.Size(79, 13)
        Me._Label1_6.TabIndex = 51
        Me._Label1_6.Text = "Tabelvelden"
        '
        '_Label1_5
        '
        Me._Label1_5.BackColor = System.Drawing.SystemColors.Window
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._Label1_5.Location = New System.Drawing.Point(8, 140)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_5.Size = New System.Drawing.Size(85, 13)
        Me._Label1_5.TabIndex = 49
        Me._Label1_5.Text = "Rapportnaam"
        '
        '_Label1_4
        '
        Me._Label1_4.AutoSize = true
        Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_4.Location = New System.Drawing.Point(190, 36)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_4.Size = New System.Drawing.Size(23, 13)
        Me._Label1_4.TabIndex = 41
        Me._Label1_4.Text = "&Tot"
        '
        '_Label1_3
        '
        Me._Label1_3.AutoSize = true
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(186, 14)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(26, 13)
        Me._Label1_3.TabIndex = 39
        Me._Label1_3.Text = "&Van"
        '
        '_Label1_2
        '
        Me._Label1_2.AutoSize = true
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(6, 16)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(49, 13)
        Me._Label1_2.TabIndex = 37
        Me._Label1_2.Text = "&Sortering"
        '
        '_Label1_1
        '
        Me._Label1_1.AutoSize = true
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(168, -28)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(115, 13)
        Me._Label1_1.TabIndex = 35
        Me._Label1_1.Text = "Aktieve &rapportdefinitie"
        '
        '_Label1_0
        '
        Me._Label1_0.AutoSize = true
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(8, -28)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(34, 13)
        Me._Label1_0.TabIndex = 33
        Me._Label1_0.Text = "&Tabel"
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = true
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(114, 34)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(270, 42)
        Me.lblInOntwikkeling.TabIndex = 88
        Me.lblInOntwikkeling.Text = "In Ontwikkeling"
        '
        'LijstRapportage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(499, 114)
        Me.ControlBox = false
        Me.Controls.Add(Me.lblInOntwikkeling)
        Me.Controls.Add(Me.cmdSQLOvername)
        Me.Controls.Add(Me.cmdToonSQL)
        Me.Controls.Add(Me.chkAfdrukLiggend)
        Me.Controls.Add(Me.chkAfdrukInVenster)
        Me.Controls.Add(Me._TekstInfo_5)
        Me.Controls.Add(Me._DefEdit_3)
        Me.Controls.Add(Me._TekstInfo_4)
        Me.Controls.Add(Me._TekstInfo_3)
        Me.Controls.Add(Me.Formattering)
        Me.Controls.Add(Me._DefEdit_2)
        Me.Controls.Add(Me._DefEdit_1)
        Me.Controls.Add(Me.RapportVelden)
        Me.Controls.Add(Me._DefEdit_0)
        Me.Controls.Add(Me.TabelVelden)
        Me.Controls.Add(Me._TekstInfo_2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Afdrukken)
        Me.Controls.Add(Me._TekstInfo_1)
        Me.Controls.Add(Me._TekstInfo_0)
        Me.Controls.Add(Me.Sortering)
        Me.Controls.Add(Me.Definitie)
        Me.Controls.Add(Me.RapportDefinitie)
        Me.Controls.Add(Me.Tabel)
        Me.Controls.Add(Me.lblAantalInSelektie)
        Me.Controls.Add(Me._Label1_8)
        Me.Controls.Add(Me._Label1_7)
        Me.Controls.Add(Me._Label1_6)
        Me.Controls.Add(Me._Label1_5)
        Me.Controls.Add(Me._Label1_4)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me._Label1_0)
        Me.Name = "LijstRapportage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LijstRapportage"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Public WithEvents cmdSQLOvername As Button
    Public WithEvents cmdToonSQL As Button
    Public WithEvents chkAfdrukLiggend As CheckBox
    Public WithEvents chkAfdrukInVenster As CheckBox
    Public WithEvents _TekstInfo_5 As TextBox
    Public WithEvents _DefEdit_3 As Button
    Public WithEvents _TekstInfo_4 As TextBox
    Public WithEvents _TekstInfo_3 As TextBox
    Public WithEvents Formattering As ComboBox
    Public WithEvents _DefEdit_2 As Button
    Public WithEvents _DefEdit_1 As Button
    Public WithEvents RapportVelden As ListBox
    Public WithEvents _DefEdit_0 As Button
    Public WithEvents TabelVelden As ListBox
    Public WithEvents _TekstInfo_2 As TextBox
    Public WithEvents btnClose As Button
    Public WithEvents Afdrukken As Button
    Public WithEvents _TekstInfo_1 As TextBox
    Public WithEvents _TekstInfo_0 As TextBox
    Public WithEvents Sortering As ComboBox
    Public WithEvents Definitie As Button
    Public WithEvents RapportDefinitie As ComboBox
    Public WithEvents Tabel As ComboBox
    Public WithEvents lblAantalInSelektie As Label
    Public WithEvents _Label1_8 As Label
    Public WithEvents _Label1_7 As Label
    Public WithEvents _Label1_6 As Label
    Public WithEvents _Label1_5 As Label
    Public WithEvents _Label1_4 As Label
    Public WithEvents _Label1_3 As Label
    Public WithEvents _Label1_2 As Label
    Public WithEvents _Label1_1 As Label
    Public WithEvents _Label1_0 As Label
    Friend WithEvents lblInOntwikkeling As Label
End Class
