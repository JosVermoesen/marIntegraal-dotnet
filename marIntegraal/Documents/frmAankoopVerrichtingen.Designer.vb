<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAankoopVerrichtingen
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me._Label1_3 = New System.Windows.Forms.Label()
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
        Me.LeverancierInfo = New System.Windows.Forms.Label()
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.OMSLabel = New System.Windows.Forms.Label()
        Me.cbUpdateLeverancier = New System.Windows.Forms.Button()
        Me._Label1_15 = New System.Windows.Forms.Label()
        Me.cbBank = New System.Windows.Forms.CheckBox()
        Me._Label1_5 = New System.Windows.Forms.Label()
        Me.Schoonvegen = New System.Windows.Forms.Button()
        Me._Label1_7 = New System.Windows.Forms.Label()
        Me.Kontrole = New System.Windows.Forms.Button()
        Me._Label1_14 = New System.Windows.Forms.Label()
        Me.Afsluiten = New System.Windows.Forms.Button()
        Me._Label1_8 = New System.Windows.Forms.Label()
        Me.Medekontraktant = New System.Windows.Forms.CheckBox()
        Me._Label1_12 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me._Label1_13 = New System.Windows.Forms.Label()
        Me.StockBeheer = New System.Windows.Forms.CheckBox()
        Me._Label1_11 = New System.Windows.Forms.Label()
        Me.cmdSQLInfo = New System.Windows.Forms.Button()
        Me._TekstInfo_12 = New System.Windows.Forms.MaskedTextBox()
        Me._AankoopOptie_0 = New System.Windows.Forms.RadioButton()
        Me._TekstInfo_11 = New System.Windows.Forms.MaskedTextBox()
        Me._AankoopOptie_1 = New System.Windows.Forms.RadioButton()
        Me._TekstInfo_5 = New System.Windows.Forms.MaskedTextBox()
        Me._AankoopOptie_2 = New System.Windows.Forms.RadioButton()
        Me._TekstInfo_7 = New System.Windows.Forms.MaskedTextBox()
        Me.lbAankoopDetail = New System.Windows.Forms.ListBox()
        Me._TekstInfo_8 = New System.Windows.Forms.MaskedTextBox()
        Me.cmdSwitch = New System.Windows.Forms.Button()
        Me._TekstInfo_9 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstInfo_4 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstInfo_10 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstInfo_2 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstInfo_6 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstInfo_1 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstInfo_0 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstInfo_3 = New System.Windows.Forms.MaskedTextBox()
        Me.lblInOntwikkeling = New System.Windows.Forms.Label()
        Me.SSTab1.SuspendLayout
        Me._SSTab1_TabPage0.SuspendLayout
        Me._SSTab1_TabPage1.SuspendLayout
        Me.SuspendLayout
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "&Datum dok."
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(272, 432)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(35, 16)
        Me._Label1_3.TabIndex = 73
        Me._Label1_3.Text = "Koers"
        Me._Label1_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SSTab1
        '
        Me.SSTab1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 17)
        Me.SSTab1.Location = New System.Drawing.Point(8, 16)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 0
        Me.SSTab1.Size = New System.Drawing.Size(321, 101)
        Me.SSTab1.TabIndex = 47
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.LeverancierInfo)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 21)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(313, 76)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "&Leverancier"
        '
        'LeverancierInfo
        '
        Me.LeverancierInfo.BackColor = System.Drawing.SystemColors.Info
        Me.LeverancierInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LeverancierInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LeverancierInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LeverancierInfo.Location = New System.Drawing.Point(8, 24)
        Me.LeverancierInfo.Name = "LeverancierInfo"
        Me.LeverancierInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LeverancierInfo.Size = New System.Drawing.Size(305, 69)
        Me.LeverancierInfo.TabIndex = 27
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Controls.Add(Me.ListView1)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 21)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(313, 76)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Historiek"
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.BackColor = System.Drawing.SystemColors.Info
        Me.ListView1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ListView1.FullRowSelect = true
        Me.ListView1.HideSelection = false
        Me.ListView1.HotTracking = true
        Me.ListView1.HoverSelection = true
        Me.ListView1.Location = New System.Drawing.Point(4, 20)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(305, 77)
        Me.ListView1.TabIndex = 26
        Me.ListView1.UseCompatibleStateImageBehavior = false
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'OMSLabel
        '
        Me.OMSLabel.BackColor = System.Drawing.SystemColors.Control
        Me.OMSLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.OMSLabel.Font = New System.Drawing.Font("Courier New", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.OMSLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OMSLabel.Location = New System.Drawing.Point(20, 120)
        Me.OMSLabel.Name = "OMSLabel"
        Me.OMSLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OMSLabel.Size = New System.Drawing.Size(631, 13)
        Me.OMSLabel.TabIndex = 74
        Me.OMSLabel.Text = "&Alg.Rek Naam rekening                                Totaal    Artikelnr.    Oms"& _ 
    "chrijving"
        '
        'cbUpdateLeverancier
        '
        Me.cbUpdateLeverancier.BackColor = System.Drawing.SystemColors.Control
        Me.cbUpdateLeverancier.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbUpdateLeverancier.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbUpdateLeverancier.Location = New System.Drawing.Point(272, 464)
        Me.cbUpdateLeverancier.Name = "cbUpdateLeverancier"
        Me.cbUpdateLeverancier.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbUpdateLeverancier.Size = New System.Drawing.Size(139, 33)
        Me.cbUpdateLeverancier.TabIndex = 84
        Me.cbUpdateLeverancier.Text = "Update Leverancier"
        Me.cbUpdateLeverancier.UseVisualStyleBackColor = false
        Me.cbUpdateLeverancier.Visible = false
        '
        '_Label1_15
        '
        Me._Label1_15.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_15.Location = New System.Drawing.Point(16, 408)
        Me._Label1_15.Name = "_Label1_15"
        Me._Label1_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_15.Size = New System.Drawing.Size(69, 16)
        Me._Label1_15.TabIndex = 75
        Me._Label1_15.Text = "Boekdatum"
        '
        'cbBank
        '
        Me.cbBank.BackColor = System.Drawing.SystemColors.Control
        Me.cbBank.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbBank.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbBank.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbBank.Location = New System.Drawing.Point(12, 448)
        Me.cbBank.Name = "cbBank"
        Me.cbBank.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbBank.Size = New System.Drawing.Size(69, 37)
        Me.cbBank.TabIndex = 83
        Me.cbBank.Text = "BE-Bank"
        Me.cbBank.UseVisualStyleBackColor = false
        '
        '_Label1_5
        '
        Me._Label1_5.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_5.Location = New System.Drawing.Point(16, 384)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_5.Size = New System.Drawing.Size(69, 16)
        Me._Label1_5.TabIndex = 76
        Me._Label1_5.Text = "Vervaldag"
        '
        'Schoonvegen
        '
        Me.Schoonvegen.BackColor = System.Drawing.SystemColors.Control
        Me.Schoonvegen.Cursor = System.Windows.Forms.Cursors.Default
        Me.Schoonvegen.Enabled = false
        Me.Schoonvegen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Schoonvegen.Location = New System.Drawing.Point(344, 68)
        Me.Schoonvegen.Name = "Schoonvegen"
        Me.Schoonvegen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Schoonvegen.Size = New System.Drawing.Size(73, 21)
        Me.Schoonvegen.TabIndex = 68
        Me.Schoonvegen.TabStop = false
        Me.Schoonvegen.Text = "Sch&oon"
        Me.Schoonvegen.UseVisualStyleBackColor = false
        '
        '_Label1_7
        '
        Me._Label1_7.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_7.Location = New System.Drawing.Point(340, 20)
        Me._Label1_7.Name = "_Label1_7"
        Me._Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_7.Size = New System.Drawing.Size(189, 19)
        Me._Label1_7.TabIndex = 69
        Me._Label1_7.Text = "Default&Rek. (Leverancier en Btw)"
        '
        'Kontrole
        '
        Me.Kontrole.BackColor = System.Drawing.SystemColors.Control
        Me.Kontrole.Cursor = System.Windows.Forms.Cursors.Default
        Me.Kontrole.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Kontrole.Location = New System.Drawing.Point(440, 462)
        Me.Kontrole.Name = "Kontrole"
        Me.Kontrole.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Kontrole.Size = New System.Drawing.Size(101, 24)
        Me.Kontrole.TabIndex = 61
        Me.Kontrole.TabStop = false
        Me.Kontrole.Text = "Kontrole"
        Me.Kontrole.UseVisualStyleBackColor = false
        '
        '_Label1_14
        '
        Me._Label1_14.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_14.Location = New System.Drawing.Point(16, 432)
        Me._Label1_14.Name = "_Label1_14"
        Me._Label1_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_14.Size = New System.Drawing.Size(69, 16)
        Me._Label1_14.TabIndex = 77
        Me._Label1_14.Text = "Referte nr."
        '
        'Afsluiten
        '
        Me.Afsluiten.BackColor = System.Drawing.SystemColors.Control
        Me.Afsluiten.Cursor = System.Windows.Forms.Cursors.Default
        Me.Afsluiten.Enabled = false
        Me.Afsluiten.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Afsluiten.Location = New System.Drawing.Point(438, 434)
        Me.Afsluiten.Name = "Afsluiten"
        Me.Afsluiten.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Afsluiten.Size = New System.Drawing.Size(101, 24)
        Me.Afsluiten.TabIndex = 62
        Me.Afsluiten.Text = "&Boeken"
        Me.Afsluiten.UseVisualStyleBackColor = false
        Me.Afsluiten.Visible = false
        '
        '_Label1_8
        '
        Me._Label1_8.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_8.Location = New System.Drawing.Point(208, 360)
        Me._Label1_8.Name = "_Label1_8"
        Me._Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_8.Size = New System.Drawing.Size(105, 16)
        Me._Label1_8.TabIndex = 78
        Me._Label1_8.Text = "Btw Aftrekbaar"
        '
        'Medekontraktant
        '
        Me.Medekontraktant.BackColor = System.Drawing.SystemColors.Control
        Me.Medekontraktant.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Medekontraktant.Cursor = System.Windows.Forms.Cursors.Default
        Me.Medekontraktant.Enabled = false
        Me.Medekontraktant.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Medekontraktant.Location = New System.Drawing.Point(192, 120)
        Me.Medekontraktant.Name = "Medekontraktant"
        Me.Medekontraktant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Medekontraktant.Size = New System.Drawing.Size(105, 16)
        Me.Medekontraktant.TabIndex = 67
        Me.Medekontraktant.Text = "&Medekontraktant"
        Me.Medekontraktant.UseVisualStyleBackColor = false
        '
        '_Label1_12
        '
        Me._Label1_12.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_12.Location = New System.Drawing.Point(204, 384)
        Me._Label1_12.Name = "_Label1_12"
        Me._Label1_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_12.Size = New System.Drawing.Size(109, 16)
        Me._Label1_12.TabIndex = 79
        Me._Label1_12.Text = "BTW Verschuldigd"
        Me._Label1_12.Visible = false
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(344, 92)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClose.Size = New System.Drawing.Size(73, 21)
        Me.btnClose.TabIndex = 66
        Me.btnClose.TabStop = false
        Me.btnClose.Text = "Sluiten"
        Me.btnClose.UseVisualStyleBackColor = false
        '
        '_Label1_13
        '
        Me._Label1_13.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_13.Location = New System.Drawing.Point(204, 408)
        Me._Label1_13.Name = "_Label1_13"
        Me._Label1_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_13.Size = New System.Drawing.Size(109, 16)
        Me._Label1_13.TabIndex = 80
        Me._Label1_13.Text = "Deel Privé"
        Me._Label1_13.Visible = false
        '
        'StockBeheer
        '
        Me.StockBeheer.BackColor = System.Drawing.SystemColors.Control
        Me.StockBeheer.Cursor = System.Windows.Forms.Cursors.Default
        Me.StockBeheer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StockBeheer.Location = New System.Drawing.Point(304, 120)
        Me.StockBeheer.Name = "StockBeheer"
        Me.StockBeheer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StockBeheer.Size = New System.Drawing.Size(81, 16)
        Me.StockBeheer.TabIndex = 65
        Me.StockBeheer.Text = "&Stockbeheer"
        Me.StockBeheer.UseVisualStyleBackColor = false
        '
        '_Label1_11
        '
        Me._Label1_11.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_11.Location = New System.Drawing.Point(440, 392)
        Me._Label1_11.Name = "_Label1_11"
        Me._Label1_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_11.Size = New System.Drawing.Size(101, 15)
        Me._Label1_11.TabIndex = 81
        Me._Label1_11.Text = "Totaal Dokument"
        '
        'cmdSQLInfo
        '
        Me.cmdSQLInfo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSQLInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSQLInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSQLInfo.Location = New System.Drawing.Point(264, 16)
        Me.cmdSQLInfo.Name = "cmdSQLInfo"
        Me.cmdSQLInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSQLInfo.Size = New System.Drawing.Size(61, 21)
        Me.cmdSQLInfo.TabIndex = 64
        Me.cmdSQLInfo.TabStop = false
        Me.cmdSQLInfo.Text = "SQL &Info"
        Me.cmdSQLInfo.UseVisualStyleBackColor = false
        Me.cmdSQLInfo.Visible = false
        '
        '_TekstInfo_12
        '
        Me._TekstInfo_12.AllowPromptAsInput = false
        Me._TekstInfo_12.BackColor = System.Drawing.SystemColors.Info
        Me._TekstInfo_12.Enabled = false
        Me._TekstInfo_12.ForeColor = System.Drawing.Color.Black
        Me._TekstInfo_12.Location = New System.Drawing.Point(88, 480)
        Me._TekstInfo_12.Mask = "###-#######-##"
        Me._TekstInfo_12.Name = "_TekstInfo_12"
        Me._TekstInfo_12.Size = New System.Drawing.Size(179, 20)
        Me._TekstInfo_12.TabIndex = 85
        Me._TekstInfo_12.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        '_AankoopOptie_0
        '
        Me._AankoopOptie_0.BackColor = System.Drawing.SystemColors.Control
        Me._AankoopOptie_0.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._AankoopOptie_0.Checked = true
        Me._AankoopOptie_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._AankoopOptie_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._AankoopOptie_0.Location = New System.Drawing.Point(452, 64)
        Me._AankoopOptie_0.Name = "_AankoopOptie_0"
        Me._AankoopOptie_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._AankoopOptie_0.Size = New System.Drawing.Size(75, 16)
        Me._AankoopOptie_0.TabIndex = 48
        Me._AankoopOptie_0.TabStop = true
        Me._AankoopOptie_0.Text = "&Facturering"
        Me._AankoopOptie_0.UseVisualStyleBackColor = false
        '
        '_TekstInfo_11
        '
        Me._TekstInfo_11.AllowPromptAsInput = false
        Me._TekstInfo_11.BackColor = System.Drawing.SystemColors.Info
        Me._TekstInfo_11.Enabled = false
        Me._TekstInfo_11.ForeColor = System.Drawing.Color.Black
        Me._TekstInfo_11.Location = New System.Drawing.Point(88, 456)
        Me._TekstInfo_11.Mask = "###-#######-##"
        Me._TekstInfo_11.Name = "_TekstInfo_11"
        Me._TekstInfo_11.Size = New System.Drawing.Size(163, 20)
        Me._TekstInfo_11.TabIndex = 82
        Me._TekstInfo_11.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        '_AankoopOptie_1
        '
        Me._AankoopOptie_1.BackColor = System.Drawing.SystemColors.Control
        Me._AankoopOptie_1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._AankoopOptie_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._AankoopOptie_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._AankoopOptie_1.Location = New System.Drawing.Point(456, 80)
        Me._AankoopOptie_1.Name = "_AankoopOptie_1"
        Me._AankoopOptie_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._AankoopOptie_1.Size = New System.Drawing.Size(71, 16)
        Me._AankoopOptie_1.TabIndex = 49
        Me._AankoopOptie_1.Text = "CreditNota"
        Me._AankoopOptie_1.UseVisualStyleBackColor = false
        '
        '_TekstInfo_5
        '
        Me._TekstInfo_5.AllowPromptAsInput = false
        Me._TekstInfo_5.BackColor = System.Drawing.SystemColors.Info
        Me._TekstInfo_5.ForeColor = System.Drawing.Color.Black
        Me._TekstInfo_5.Location = New System.Drawing.Point(316, 360)
        Me._TekstInfo_5.Name = "_TekstInfo_5"
        Me._TekstInfo_5.Size = New System.Drawing.Size(95, 20)
        Me._TekstInfo_5.TabIndex = 57
        '
        '_AankoopOptie_2
        '
        Me._AankoopOptie_2.BackColor = System.Drawing.SystemColors.Control
        Me._AankoopOptie_2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._AankoopOptie_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._AankoopOptie_2.Enabled = false
        Me._AankoopOptie_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._AankoopOptie_2.Location = New System.Drawing.Point(440, 96)
        Me._AankoopOptie_2.Name = "_AankoopOptie_2"
        Me._AankoopOptie_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._AankoopOptie_2.Size = New System.Drawing.Size(87, 16)
        Me._AankoopOptie_2.TabIndex = 50
        Me._AankoopOptie_2.Text = "Leveringsbon"
        Me._AankoopOptie_2.UseVisualStyleBackColor = false
        Me._AankoopOptie_2.Visible = false
        '
        '_TekstInfo_7
        '
        Me._TekstInfo_7.AllowPromptAsInput = false
        Me._TekstInfo_7.BackColor = System.Drawing.SystemColors.Info
        Me._TekstInfo_7.ForeColor = System.Drawing.Color.Black
        Me._TekstInfo_7.Location = New System.Drawing.Point(316, 384)
        Me._TekstInfo_7.Name = "_TekstInfo_7"
        Me._TekstInfo_7.Size = New System.Drawing.Size(95, 20)
        Me._TekstInfo_7.TabIndex = 58
        Me._TekstInfo_7.Visible = false
        '
        'lbAankoopDetail
        '
        Me.lbAankoopDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.lbAankoopDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbAankoopDetail.Font = New System.Drawing.Font("Courier New", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbAankoopDetail.ForeColor = System.Drawing.Color.Black
        Me.lbAankoopDetail.ItemHeight = 15
        Me.lbAankoopDetail.Location = New System.Drawing.Point(16, 140)
        Me.lbAankoopDetail.Name = "lbAankoopDetail"
        Me.lbAankoopDetail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbAankoopDetail.Size = New System.Drawing.Size(523, 214)
        Me.lbAankoopDetail.TabIndex = 51
        '
        '_TekstInfo_8
        '
        Me._TekstInfo_8.AllowPromptAsInput = false
        Me._TekstInfo_8.BackColor = System.Drawing.SystemColors.Info
        Me._TekstInfo_8.ForeColor = System.Drawing.Color.Black
        Me._TekstInfo_8.Location = New System.Drawing.Point(316, 408)
        Me._TekstInfo_8.Name = "_TekstInfo_8"
        Me._TekstInfo_8.Size = New System.Drawing.Size(95, 20)
        Me._TekstInfo_8.TabIndex = 59
        Me._TekstInfo_8.Visible = false
        '
        'cmdSwitch
        '
        Me.cmdSwitch.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSwitch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSwitch.Enabled = false
        Me.cmdSwitch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSwitch.Location = New System.Drawing.Point(440, 360)
        Me.cmdSwitch.Name = "cmdSwitch"
        Me.cmdSwitch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSwitch.Size = New System.Drawing.Size(99, 23)
        Me.cmdSwitch.TabIndex = 63
        Me.cmdSwitch.TabStop = false
        Me.cmdSwitch.Text = "Ingave in EUR"
        Me.cmdSwitch.UseVisualStyleBackColor = false
        '
        '_TekstInfo_9
        '
        Me._TekstInfo_9.AllowPromptAsInput = false
        Me._TekstInfo_9.BackColor = System.Drawing.SystemColors.Info
        Me._TekstInfo_9.ForeColor = System.Drawing.Color.Black
        Me._TekstInfo_9.Location = New System.Drawing.Point(316, 432)
        Me._TekstInfo_9.Name = "_TekstInfo_9"
        Me._TekstInfo_9.Size = New System.Drawing.Size(95, 20)
        Me._TekstInfo_9.TabIndex = 72
        '
        '_TekstInfo_4
        '
        Me._TekstInfo_4.AllowPromptAsInput = false
        Me._TekstInfo_4.BackColor = System.Drawing.SystemColors.Info
        Me._TekstInfo_4.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me._TekstInfo_4.ForeColor = System.Drawing.Color.Black
        Me._TekstInfo_4.Location = New System.Drawing.Point(88, 432)
        Me._TekstInfo_4.Mask = "+++###/####/#####+++"
        Me._TekstInfo_4.Name = "_TekstInfo_4"
        Me._TekstInfo_4.Size = New System.Drawing.Size(163, 20)
        Me._TekstInfo_4.TabIndex = 56
        Me._TekstInfo_4.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        '_TekstInfo_10
        '
        Me._TekstInfo_10.AllowPromptAsInput = false
        Me._TekstInfo_10.BackColor = System.Drawing.SystemColors.Info
        Me._TekstInfo_10.ForeColor = System.Drawing.Color.Black
        Me._TekstInfo_10.Location = New System.Drawing.Point(456, 40)
        Me._TekstInfo_10.Name = "_TekstInfo_10"
        Me._TekstInfo_10.Size = New System.Drawing.Size(73, 20)
        Me._TekstInfo_10.TabIndex = 71
        '
        '_TekstInfo_2
        '
        Me._TekstInfo_2.AllowPromptAsInput = false
        Me._TekstInfo_2.BackColor = System.Drawing.SystemColors.Info
        Me._TekstInfo_2.ForeColor = System.Drawing.Color.Black
        Me._TekstInfo_2.Location = New System.Drawing.Point(88, 384)
        Me._TekstInfo_2.Mask = "##/##/####"
        Me._TekstInfo_2.Name = "_TekstInfo_2"
        Me._TekstInfo_2.Size = New System.Drawing.Size(77, 20)
        Me._TekstInfo_2.TabIndex = 54
        '
        '_TekstInfo_6
        '
        Me._TekstInfo_6.AllowPromptAsInput = false
        Me._TekstInfo_6.BackColor = System.Drawing.SystemColors.Info
        Me._TekstInfo_6.ForeColor = System.Drawing.Color.Black
        Me._TekstInfo_6.Location = New System.Drawing.Point(440, 408)
        Me._TekstInfo_6.Name = "_TekstInfo_6"
        Me._TekstInfo_6.Size = New System.Drawing.Size(95, 20)
        Me._TekstInfo_6.TabIndex = 60
        '
        '_TekstInfo_1
        '
        Me._TekstInfo_1.AllowPromptAsInput = false
        Me._TekstInfo_1.BackColor = System.Drawing.SystemColors.Info
        Me._TekstInfo_1.ForeColor = System.Drawing.Color.Black
        Me._TekstInfo_1.Location = New System.Drawing.Point(88, 360)
        Me._TekstInfo_1.Mask = "##/##/####"
        Me._TekstInfo_1.Name = "_TekstInfo_1"
        Me._TekstInfo_1.Size = New System.Drawing.Size(77, 20)
        Me._TekstInfo_1.TabIndex = 53
        '
        '_TekstInfo_0
        '
        Me._TekstInfo_0.AllowPromptAsInput = false
        Me._TekstInfo_0.BackColor = System.Drawing.SystemColors.Info
        Me._TekstInfo_0.ForeColor = System.Drawing.Color.Black
        Me._TekstInfo_0.Location = New System.Drawing.Point(88, 408)
        Me._TekstInfo_0.Mask = "##/##/####"
        Me._TekstInfo_0.Name = "_TekstInfo_0"
        Me._TekstInfo_0.Size = New System.Drawing.Size(77, 20)
        Me._TekstInfo_0.TabIndex = 55
        '
        '_TekstInfo_3
        '
        Me._TekstInfo_3.AllowPromptAsInput = false
        Me._TekstInfo_3.BackColor = System.Drawing.SystemColors.Info
        Me._TekstInfo_3.ForeColor = System.Drawing.Color.Black
        Me._TekstInfo_3.Location = New System.Drawing.Point(340, 40)
        Me._TekstInfo_3.Name = "_TekstInfo_3"
        Me._TekstInfo_3.Size = New System.Drawing.Size(73, 20)
        Me._TekstInfo_3.TabIndex = 70
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = true
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(143, 207)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(270, 42)
        Me.lblInOntwikkeling.TabIndex = 86
        Me.lblInOntwikkeling.Text = "In Ontwikkeling"
        '
        'frmAankoopVerrichtingen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(691, 539)
        Me.ControlBox = false
        Me.Controls.Add(Me.lblInOntwikkeling)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me.SSTab1)
        Me.Controls.Add(Me.OMSLabel)
        Me.Controls.Add(Me.cbUpdateLeverancier)
        Me.Controls.Add(Me._Label1_15)
        Me.Controls.Add(Me.cbBank)
        Me.Controls.Add(Me._Label1_5)
        Me.Controls.Add(Me.Schoonvegen)
        Me.Controls.Add(Me._Label1_7)
        Me.Controls.Add(Me.Kontrole)
        Me.Controls.Add(Me._Label1_14)
        Me.Controls.Add(Me.Afsluiten)
        Me.Controls.Add(Me._Label1_8)
        Me.Controls.Add(Me.Medekontraktant)
        Me.Controls.Add(Me._Label1_12)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me._Label1_13)
        Me.Controls.Add(Me.StockBeheer)
        Me.Controls.Add(Me._Label1_11)
        Me.Controls.Add(Me.cmdSQLInfo)
        Me.Controls.Add(Me._TekstInfo_12)
        Me.Controls.Add(Me._AankoopOptie_0)
        Me.Controls.Add(Me._TekstInfo_11)
        Me.Controls.Add(Me._AankoopOptie_1)
        Me.Controls.Add(Me._TekstInfo_5)
        Me.Controls.Add(Me._AankoopOptie_2)
        Me.Controls.Add(Me._TekstInfo_7)
        Me.Controls.Add(Me.lbAankoopDetail)
        Me.Controls.Add(Me._TekstInfo_8)
        Me.Controls.Add(Me.cmdSwitch)
        Me.Controls.Add(Me._TekstInfo_9)
        Me.Controls.Add(Me._TekstInfo_4)
        Me.Controls.Add(Me._TekstInfo_10)
        Me.Controls.Add(Me._TekstInfo_2)
        Me.Controls.Add(Me._TekstInfo_6)
        Me.Controls.Add(Me._TekstInfo_1)
        Me.Controls.Add(Me._TekstInfo_0)
        Me.Controls.Add(Me._TekstInfo_3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAankoopVerrichtingen"
        Me.Text = "Aankoopverrichtingen"
        Me.SSTab1.ResumeLayout(false)
        Me._SSTab1_TabPage0.ResumeLayout(false)
        Me._SSTab1_TabPage1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Public WithEvents Label2 As Label
    Public WithEvents _Label1_3 As Label
    Public WithEvents SSTab1 As TabControl
    Public WithEvents _SSTab1_TabPage0 As TabPage
    Public WithEvents LeverancierInfo As Label
    Public WithEvents _SSTab1_TabPage1 As TabPage
    Public WithEvents ListView1 As ListView
    Public WithEvents OMSLabel As Label
    Public WithEvents cbUpdateLeverancier As Button
    Public WithEvents _Label1_15 As Label
    Public WithEvents cbBank As CheckBox
    Public WithEvents _Label1_5 As Label
    Public WithEvents Schoonvegen As Button
    Public WithEvents _Label1_7 As Label
    Public WithEvents Kontrole As Button
    Public WithEvents _Label1_14 As Label
    Public WithEvents Afsluiten As Button
    Public WithEvents _Label1_8 As Label
    Public WithEvents Medekontraktant As CheckBox
    Public WithEvents _Label1_12 As Label
    Public WithEvents btnClose As Button
    Public WithEvents _Label1_13 As Label
    Public WithEvents StockBeheer As CheckBox
    Public WithEvents _Label1_11 As Label
    Public WithEvents cmdSQLInfo As Button
    Public WithEvents _TekstInfo_12 As MaskedTextBox
    Public WithEvents _AankoopOptie_0 As RadioButton
    Public WithEvents _TekstInfo_11 As MaskedTextBox
    Public WithEvents _AankoopOptie_1 As RadioButton
    Public WithEvents _TekstInfo_5 As MaskedTextBox
    Public WithEvents _AankoopOptie_2 As RadioButton
    Public WithEvents _TekstInfo_7 As MaskedTextBox
    Public WithEvents lbAankoopDetail As ListBox
    Public WithEvents _TekstInfo_8 As MaskedTextBox
    Public WithEvents cmdSwitch As Button
    Public WithEvents _TekstInfo_9 As MaskedTextBox
    Public WithEvents _TekstInfo_4 As MaskedTextBox
    Public WithEvents _TekstInfo_10 As MaskedTextBox
    Public WithEvents _TekstInfo_2 As MaskedTextBox
    Public WithEvents _TekstInfo_6 As MaskedTextBox
    Public WithEvents _TekstInfo_1 As MaskedTextBox
    Public WithEvents _TekstInfo_0 As MaskedTextBox
    Public WithEvents _TekstInfo_3 As MaskedTextBox
    Friend WithEvents lblInOntwikkeling As Label
End Class
