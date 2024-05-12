<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FomSalesTransactions
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
        Me.cbPDF = New System.Windows.Forms.CheckBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.cbLayOudPDF = New System.Windows.Forms.Button()
        Me._Label1_9 = New System.Windows.Forms.Label()
        Me._Label1_8 = New System.Windows.Forms.Label()
        Me._Label1_6 = New System.Windows.Forms.Label()
        Me.btwBedrag1 = New System.Windows.Forms.Label()
        Me.btwBedrag2 = New System.Windows.Forms.Label()
        Me.btwBedrag3 = New System.Windows.Forms.Label()
        Me._Label1_3 = New System.Windows.Forms.Label()
        Me._Label1_20 = New System.Windows.Forms.Label()
        Me._Label1_12 = New System.Windows.Forms.Label()
        Me.LblInBtw = New System.Windows.Forms.Label()
        Me.LblExBtw = New System.Windows.Forms.Label()
        Me.LblIn2Btw = New System.Windows.Forms.Label()
        Me.LblEx2Btw = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me._Label1_5 = New System.Windows.Forms.Label()
        Me._Label1_7 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._Label1_4 = New System.Windows.Forms.Label()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me.KlantInfo = New System.Windows.Forms.Label()
        Me.DagKoers = New System.Windows.Forms.Label()
        Me.TekstInfo3 = New System.Windows.Forms.MaskedTextBox()
        Me.datumdocMTextbox = New System.Windows.Forms.MaskedTextBox()
        Me.mgrklantenrekMTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.vervaldagMTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.muntMTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BtnSwitchMoney = New System.Windows.Forms.Button()
        Me.ckEURINFO = New System.Windows.Forms.CheckBox()
        Me.CbBTWBouw = New System.Windows.Forms.CheckBox()
        Me.chkZonderRelatie = New System.Windows.Forms.CheckBox()
        Me.cmdLijst = New System.Windows.Forms.Button()
        Me.cmdSQLInfo = New System.Windows.Forms.Button()
        Me.BtnGenerateCopy = New System.Windows.Forms.Button()
        Me.BtnPutTextLine = New System.Windows.Forms.Button()
        Me.BtnFromDescription = New System.Windows.Forms.Button()
        Me.BtnFromStock = New System.Windows.Forms.Button()
        Me.Optimaliseer = New System.Windows.Forms.Button()
        Me.Overschrijvingsstrook = New System.Windows.Forms.CheckBox()
        Me.BtnDocumentHistory = New System.Windows.Forms.Button()
        Me.BtnGenerateAndSave = New System.Windows.Forms.Button()
        Me.CbMedekontraktant = New System.Windows.Forms.CheckBox()
        Me.CbCreditNota = New System.Windows.Forms.CheckBox()
        Me.BtnGetClient = New System.Windows.Forms.Button()
        Me.VerkoopDetail = New System.Windows.Forms.ListBox()
        Me.Sjabloon = New System.Windows.Forms.Button()
        Me.RbDirekteVerkoop = New System.Windows.Forms.RadioButton()
        Me.RbBestelbon = New System.Windows.Forms.RadioButton()
        Me.RbOfferte = New System.Windows.Forms.RadioButton()
        Me.lstKopiePlak = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblInOntwikkeling = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'cbPDF
        '
        Me.cbPDF.BackColor = System.Drawing.SystemColors.Control
        Me.cbPDF.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbPDF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbPDF.Location = New System.Drawing.Point(8, 475)
        Me.cbPDF.Name = "cbPDF"
        Me.cbPDF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbPDF.Size = New System.Drawing.Size(73, 21)
        Me.cbPDF.TabIndex = 67
        Me.cbPDF.Text = "Vpe-Pdf"
        Me.cbPDF.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCancel.Location = New System.Drawing.Point(480, 475)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCancel.Size = New System.Drawing.Size(59, 21)
        Me.BtnCancel.TabIndex = 65
        Me.BtnCancel.TabStop = False
        Me.BtnCancel.Text = "Sluiten"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnClear.Enabled = False
        Me.BtnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnClear.Location = New System.Drawing.Point(544, 475)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnClear.Size = New System.Drawing.Size(59, 19)
        Me.BtnClear.TabIndex = 64
        Me.BtnClear.TabStop = False
        Me.BtnClear.Text = "Schoo&n"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'cbLayOudPDF
        '
        Me.cbLayOudPDF.BackColor = System.Drawing.SystemColors.Control
        Me.cbLayOudPDF.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbLayOudPDF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbLayOudPDF.Location = New System.Drawing.Point(87, 475)
        Me.cbLayOudPDF.Name = "cbLayOudPDF"
        Me.cbLayOudPDF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbLayOudPDF.Size = New System.Drawing.Size(193, 21)
        Me.cbLayOudPDF.TabIndex = 66
        Me.cbLayOudPDF.TabStop = False
        Me.cbLayOudPDF.Text = "Beheer van VPE PFD Lay-Out"
        Me.cbLayOudPDF.UseVisualStyleBackColor = False
        '
        '_Label1_9
        '
        Me._Label1_9.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_9.Location = New System.Drawing.Point(177, 429)
        Me._Label1_9.Name = "_Label1_9"
        Me._Label1_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_9.Size = New System.Drawing.Size(83, 19)
        Me._Label1_9.TabIndex = 27
        Me._Label1_9.Text = "Btw Basis 3"
        Me._Label1_9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_8
        '
        Me._Label1_8.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_8.Location = New System.Drawing.Point(93, 429)
        Me._Label1_8.Name = "_Label1_8"
        Me._Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_8.Size = New System.Drawing.Size(83, 19)
        Me._Label1_8.TabIndex = 28
        Me._Label1_8.Text = "Btw Basis 2"
        Me._Label1_8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_6
        '
        Me._Label1_6.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_6.Location = New System.Drawing.Point(9, 429)
        Me._Label1_6.Name = "_Label1_6"
        Me._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_6.Size = New System.Drawing.Size(83, 19)
        Me._Label1_6.TabIndex = 29
        Me._Label1_6.Text = "Btw Basis 1"
        Me._Label1_6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btwBedrag1
        '
        Me.btwBedrag1.BackColor = System.Drawing.SystemColors.Info
        Me.btwBedrag1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btwBedrag1.Cursor = System.Windows.Forms.Cursors.Default
        Me.btwBedrag1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btwBedrag1.Location = New System.Drawing.Point(9, 449)
        Me.btwBedrag1.Name = "btwBedrag1"
        Me.btwBedrag1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btwBedrag1.Size = New System.Drawing.Size(83, 19)
        Me.btwBedrag1.TabIndex = 30
        Me.btwBedrag1.Text = " "
        Me.btwBedrag1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btwBedrag2
        '
        Me.btwBedrag2.BackColor = System.Drawing.SystemColors.Info
        Me.btwBedrag2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btwBedrag2.Cursor = System.Windows.Forms.Cursors.Default
        Me.btwBedrag2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btwBedrag2.Location = New System.Drawing.Point(93, 449)
        Me.btwBedrag2.Name = "btwBedrag2"
        Me.btwBedrag2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btwBedrag2.Size = New System.Drawing.Size(83, 19)
        Me.btwBedrag2.TabIndex = 31
        Me.btwBedrag2.Text = " "
        Me.btwBedrag2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btwBedrag3
        '
        Me.btwBedrag3.BackColor = System.Drawing.SystemColors.Info
        Me.btwBedrag3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btwBedrag3.Cursor = System.Windows.Forms.Cursors.Default
        Me.btwBedrag3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btwBedrag3.Location = New System.Drawing.Point(177, 449)
        Me.btwBedrag3.Name = "btwBedrag3"
        Me.btwBedrag3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btwBedrag3.Size = New System.Drawing.Size(83, 19)
        Me.btwBedrag3.TabIndex = 32
        Me.btwBedrag3.Text = " "
        Me.btwBedrag3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_3
        '
        Me._Label1_3.AutoSize = True
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(105, 9)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(92, 15)
        Me._Label1_3.TabIndex = 33
        Me._Label1_3.Text = "Datum Dokument"
        '
        '_Label1_20
        '
        Me._Label1_20.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_20.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_20.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_20.Location = New System.Drawing.Point(261, 429)
        Me._Label1_20.Name = "_Label1_20"
        Me._Label1_20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_20.Size = New System.Drawing.Size(99, 19)
        Me._Label1_20.TabIndex = 34
        Me._Label1_20.Text = "BEF incl./excl. Btw"
        '
        '_Label1_12
        '
        Me._Label1_12.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_12.Location = New System.Drawing.Point(261, 449)
        Me._Label1_12.Name = "_Label1_12"
        Me._Label1_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_12.Size = New System.Drawing.Size(99, 19)
        Me._Label1_12.TabIndex = 35
        Me._Label1_12.Text = "EUR incl./excl. Btw"
        '
        'LblInBtw
        '
        Me.LblInBtw.BackColor = System.Drawing.SystemColors.Info
        Me.LblInBtw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblInBtw.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblInBtw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblInBtw.Location = New System.Drawing.Point(361, 429)
        Me.LblInBtw.Name = "LblInBtw"
        Me.LblInBtw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblInBtw.Size = New System.Drawing.Size(91, 19)
        Me.LblInBtw.TabIndex = 36
        Me.LblInBtw.Text = " "
        Me.LblInBtw.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblExBtw
        '
        Me.LblExBtw.BackColor = System.Drawing.SystemColors.Info
        Me.LblExBtw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblExBtw.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblExBtw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblExBtw.Location = New System.Drawing.Point(453, 429)
        Me.LblExBtw.Name = "LblExBtw"
        Me.LblExBtw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblExBtw.Size = New System.Drawing.Size(91, 19)
        Me.LblExBtw.TabIndex = 37
        Me.LblExBtw.Text = " "
        Me.LblExBtw.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblIn2Btw
        '
        Me.LblIn2Btw.BackColor = System.Drawing.SystemColors.Info
        Me.LblIn2Btw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblIn2Btw.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblIn2Btw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblIn2Btw.Location = New System.Drawing.Point(361, 449)
        Me.LblIn2Btw.Name = "LblIn2Btw"
        Me.LblIn2Btw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblIn2Btw.Size = New System.Drawing.Size(91, 19)
        Me.LblIn2Btw.TabIndex = 38
        Me.LblIn2Btw.Text = " "
        Me.LblIn2Btw.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblEx2Btw
        '
        Me.LblEx2Btw.BackColor = System.Drawing.SystemColors.Info
        Me.LblEx2Btw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblEx2Btw.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblEx2Btw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblEx2Btw.Location = New System.Drawing.Point(453, 449)
        Me.LblEx2Btw.Name = "LblEx2Btw"
        Me.LblEx2Btw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblEx2Btw.Size = New System.Drawing.Size(91, 19)
        Me.LblEx2Btw.TabIndex = 39
        Me.LblEx2Btw.Text = " "
        Me.LblEx2Btw.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(9, 145)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(101, 17)
        Me._Label1_1.TabIndex = 40
        Me._Label1_1.Text = "&Verkoopdetail lijnen"
        '
        '_Label1_5
        '
        Me._Label1_5.AutoSize = True
        Me._Label1_5.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_5.Location = New System.Drawing.Point(205, 9)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_5.Size = New System.Drawing.Size(57, 15)
        Me._Label1_5.TabIndex = 41
        Me._Label1_5.Text = "Vervaldag"
        '
        '_Label1_7
        '
        Me._Label1_7.AutoSize = True
        Me._Label1_7.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_7.Location = New System.Drawing.Point(305, 9)
        Me._Label1_7.Name = "_Label1_7"
        Me._Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_7.Size = New System.Drawing.Size(67, 15)
        Me._Label1_7.TabIndex = 42
        Me._Label1_7.Text = "40Rekening"
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(457, 145)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(74, 17)
        Me._Label1_2.TabIndex = 43
        Me._Label1_2.Text = "LijnTotaal"
        Me._Label1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_4
        '
        Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_4.Location = New System.Drawing.Point(389, 145)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_4.Size = New System.Drawing.Size(42, 17)
        Me._Label1_4.TabIndex = 44
        Me._Label1_4.Text = "Aantal"
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(341, 145)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(31, 17)
        Me._Label1_0.TabIndex = 45
        Me._Label1_0.Text = "Prijs"
        '
        'KlantInfo
        '
        Me.KlantInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.KlantInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KlantInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.KlantInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.KlantInfo.Location = New System.Drawing.Point(9, 49)
        Me.KlantInfo.Name = "KlantInfo"
        Me.KlantInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.KlantInfo.Size = New System.Drawing.Size(251, 69)
        Me.KlantInfo.TabIndex = 46
        '
        'DagKoers
        '
        Me.DagKoers.AutoSize = True
        Me.DagKoers.BackColor = System.Drawing.SystemColors.Control
        Me.DagKoers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DagKoers.Cursor = System.Windows.Forms.Cursors.Default
        Me.DagKoers.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DagKoers.Location = New System.Drawing.Point(47, 9)
        Me.DagKoers.Name = "DagKoers"
        Me.DagKoers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DagKoers.Size = New System.Drawing.Size(55, 15)
        Me.DagKoers.TabIndex = 47
        Me.DagKoers.Text = "Dagkoers"
        '
        'TekstInfo3
        '
        Me.TekstInfo3.AllowPromptAsInput = False
        Me.TekstInfo3.BackColor = System.Drawing.Color.Yellow
        Me.TekstInfo3.Location = New System.Drawing.Point(385, 6)
        Me.TekstInfo3.Name = "TekstInfo3"
        Me.TekstInfo3.Size = New System.Drawing.Size(89, 20)
        Me.TekstInfo3.TabIndex = 26
        Me.TekstInfo3.TabStop = False
        Me.TekstInfo3.Visible = False
        '
        'datumdocMTextbox
        '
        Me.datumdocMTextbox.AllowPromptAsInput = False
        Me.datumdocMTextbox.BackColor = System.Drawing.Color.Yellow
        Me.datumdocMTextbox.Location = New System.Drawing.Point(105, 29)
        Me.datumdocMTextbox.Mask = "##/##/####"
        Me.datumdocMTextbox.Name = "datumdocMTextbox"
        Me.datumdocMTextbox.Size = New System.Drawing.Size(93, 20)
        Me.datumdocMTextbox.TabIndex = 25
        '
        'mgrklantenrekMTextBox
        '
        Me.mgrklantenrekMTextBox.AllowPromptAsInput = False
        Me.mgrklantenrekMTextBox.BackColor = System.Drawing.Color.Yellow
        Me.mgrklantenrekMTextBox.Location = New System.Drawing.Point(301, 29)
        Me.mgrklantenrekMTextBox.Name = "mgrklantenrekMTextBox"
        Me.mgrklantenrekMTextBox.Size = New System.Drawing.Size(89, 20)
        Me.mgrklantenrekMTextBox.TabIndex = 24
        '
        'vervaldagMTextBox
        '
        Me.vervaldagMTextBox.AllowPromptAsInput = False
        Me.vervaldagMTextBox.BackColor = System.Drawing.Color.Yellow
        Me.vervaldagMTextBox.Location = New System.Drawing.Point(205, 29)
        Me.vervaldagMTextBox.Mask = "##/##/####"
        Me.vervaldagMTextBox.Name = "vervaldagMTextBox"
        Me.vervaldagMTextBox.Size = New System.Drawing.Size(93, 20)
        Me.vervaldagMTextBox.TabIndex = 23
        '
        'muntMTextBox
        '
        Me.muntMTextBox.AllowPromptAsInput = False
        Me.muntMTextBox.BackColor = System.Drawing.Color.Yellow
        Me.muntMTextBox.Enabled = False
        Me.muntMTextBox.Location = New System.Drawing.Point(9, 29)
        Me.muntMTextBox.Name = "muntMTextBox"
        Me.muntMTextBox.Size = New System.Drawing.Size(93, 20)
        Me.muntMTextBox.TabIndex = 22
        '
        'BtnSwitchMoney
        '
        Me.BtnSwitchMoney.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSwitchMoney.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnSwitchMoney.Enabled = False
        Me.BtnSwitchMoney.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSwitchMoney.Location = New System.Drawing.Point(545, 285)
        Me.BtnSwitchMoney.Name = "BtnSwitchMoney"
        Me.BtnSwitchMoney.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSwitchMoney.Size = New System.Drawing.Size(67, 37)
        Me.BtnSwitchMoney.TabIndex = 1
        Me.BtnSwitchMoney.TabStop = False
        Me.BtnSwitchMoney.Text = "Ingave in BEF"
        Me.BtnSwitchMoney.UseVisualStyleBackColor = False
        '
        'ckEURINFO
        '
        Me.ckEURINFO.BackColor = System.Drawing.SystemColors.Control
        Me.ckEURINFO.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckEURINFO.Checked = True
        Me.ckEURINFO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckEURINFO.Cursor = System.Windows.Forms.Cursors.Default
        Me.ckEURINFO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ckEURINFO.Location = New System.Drawing.Point(237, 145)
        Me.ckEURINFO.Name = "ckEURINFO"
        Me.ckEURINFO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ckEURINFO.Size = New System.Drawing.Size(97, 17)
        Me.ckEURINFO.TabIndex = 2
        Me.ckEURINFO.Text = "&EURO && Bef Info"
        Me.ckEURINFO.UseVisualStyleBackColor = False
        '
        'CbBTWBouw
        '
        Me.CbBTWBouw.BackColor = System.Drawing.SystemColors.Control
        Me.CbBTWBouw.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CbBTWBouw.Cursor = System.Windows.Forms.Cursors.Default
        Me.CbBTWBouw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CbBTWBouw.Location = New System.Drawing.Point(469, 117)
        Me.CbBTWBouw.Name = "CbBTWBouw"
        Me.CbBTWBouw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CbBTWBouw.Size = New System.Drawing.Size(139, 16)
        Me.CbBTWBouw.TabIndex = 3
        Me.CbBTWBouw.Text = "Btw Tarief Bouw + 5 jaar"
        Me.CbBTWBouw.UseVisualStyleBackColor = False
        '
        'chkZonderRelatie
        '
        Me.chkZonderRelatie.BackColor = System.Drawing.SystemColors.Control
        Me.chkZonderRelatie.Checked = True
        Me.chkZonderRelatie.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkZonderRelatie.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkZonderRelatie.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkZonderRelatie.Location = New System.Drawing.Point(393, 77)
        Me.chkZonderRelatie.Name = "chkZonderRelatie"
        Me.chkZonderRelatie.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkZonderRelatie.Size = New System.Drawing.Size(116, 23)
        Me.chkZonderRelatie.TabIndex = 4
        Me.chkZonderRelatie.Text = "&Nog te factureren"
        Me.chkZonderRelatie.UseVisualStyleBackColor = False
        '
        'cmdLijst
        '
        Me.cmdLijst.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLijst.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLijst.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLijst.Location = New System.Drawing.Point(393, 53)
        Me.cmdLijst.Name = "cmdLijst"
        Me.cmdLijst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLijst.Size = New System.Drawing.Size(71, 23)
        Me.cmdLijst.TabIndex = 5
        Me.cmdLijst.Text = "Totaal &Lijst"
        Me.cmdLijst.UseVisualStyleBackColor = False
        '
        'cmdSQLInfo
        '
        Me.cmdSQLInfo.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSQLInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSQLInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSQLInfo.Location = New System.Drawing.Point(345, 81)
        Me.cmdSQLInfo.Name = "cmdSQLInfo"
        Me.cmdSQLInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSQLInfo.Size = New System.Drawing.Size(43, 35)
        Me.cmdSQLInfo.TabIndex = 6
        Me.cmdSQLInfo.TabStop = False
        Me.cmdSQLInfo.Text = "SQL &Info"
        Me.cmdSQLInfo.UseVisualStyleBackColor = False
        Me.cmdSQLInfo.Visible = False
        '
        'BtnGenerateCopy
        '
        Me.BtnGenerateCopy.BackColor = System.Drawing.SystemColors.Control
        Me.BtnGenerateCopy.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnGenerateCopy.Enabled = False
        Me.BtnGenerateCopy.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnGenerateCopy.Location = New System.Drawing.Point(545, 165)
        Me.BtnGenerateCopy.Name = "BtnGenerateCopy"
        Me.BtnGenerateCopy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGenerateCopy.Size = New System.Drawing.Size(63, 35)
        Me.BtnGenerateCopy.TabIndex = 7
        Me.BtnGenerateCopy.Text = "(Extra) Afdruk"
        Me.BtnGenerateCopy.UseVisualStyleBackColor = False
        '
        'BtnPutTextLine
        '
        Me.BtnPutTextLine.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPutTextLine.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnPutTextLine.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnPutTextLine.Location = New System.Drawing.Point(261, 121)
        Me.BtnPutTextLine.Name = "BtnPutTextLine"
        Me.BtnPutTextLine.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPutTextLine.Size = New System.Drawing.Size(87, 22)
        Me.BtnPutTextLine.TabIndex = 8
        Me.BtnPutTextLine.TabStop = False
        Me.BtnPutTextLine.Text = "Vrije &Tekst"
        Me.BtnPutTextLine.UseVisualStyleBackColor = False
        '
        'BtnFromDescription
        '
        Me.BtnFromDescription.BackColor = System.Drawing.SystemColors.Control
        Me.BtnFromDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnFromDescription.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnFromDescription.Location = New System.Drawing.Point(97, 121)
        Me.BtnFromDescription.Name = "BtnFromDescription"
        Me.BtnFromDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnFromDescription.Size = New System.Drawing.Size(163, 22)
        Me.BtnFromDescription.TabIndex = 9
        Me.BtnFromDescription.TabStop = False
        Me.BtnFromDescription.Text = "Bedrag via &Omschrijving"
        Me.BtnFromDescription.UseVisualStyleBackColor = False
        '
        'BtnFromStock
        '
        Me.BtnFromStock.BackColor = System.Drawing.SystemColors.Control
        Me.BtnFromStock.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnFromStock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnFromStock.Location = New System.Drawing.Point(9, 121)
        Me.BtnFromStock.Name = "BtnFromStock"
        Me.BtnFromStock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnFromStock.Size = New System.Drawing.Size(87, 22)
        Me.BtnFromStock.TabIndex = 10
        Me.BtnFromStock.TabStop = False
        Me.BtnFromStock.Text = "&Stock artikel"
        Me.BtnFromStock.UseVisualStyleBackColor = False
        '
        'Optimaliseer
        '
        Me.Optimaliseer.BackColor = System.Drawing.SystemColors.Control
        Me.Optimaliseer.Cursor = System.Windows.Forms.Cursors.Default
        Me.Optimaliseer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Optimaliseer.Location = New System.Drawing.Point(537, 141)
        Me.Optimaliseer.Name = "Optimaliseer"
        Me.Optimaliseer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Optimaliseer.Size = New System.Drawing.Size(71, 22)
        Me.Optimaliseer.TabIndex = 11
        Me.Optimaliseer.TabStop = False
        Me.Optimaliseer.Text = "O&ptimaliseer"
        Me.Optimaliseer.UseVisualStyleBackColor = False
        '
        'Overschrijvingsstrook
        '
        Me.Overschrijvingsstrook.BackColor = System.Drawing.SystemColors.Control
        Me.Overschrijvingsstrook.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Overschrijvingsstrook.Checked = True
        Me.Overschrijvingsstrook.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Overschrijvingsstrook.Cursor = System.Windows.Forms.Cursors.Default
        Me.Overschrijvingsstrook.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Overschrijvingsstrook.Location = New System.Drawing.Point(545, 205)
        Me.Overschrijvingsstrook.Name = "Overschrijvingsstrook"
        Me.Overschrijvingsstrook.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Overschrijvingsstrook.Size = New System.Drawing.Size(65, 31)
        Me.Overschrijvingsstrook.TabIndex = 12
        Me.Overschrijvingsstrook.Text = "&Met OVS Strook"
        Me.Overschrijvingsstrook.UseVisualStyleBackColor = False
        '
        'BtnDocumentHistory
        '
        Me.BtnDocumentHistory.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDocumentHistory.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnDocumentHistory.Enabled = False
        Me.BtnDocumentHistory.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnDocumentHistory.Location = New System.Drawing.Point(265, 53)
        Me.BtnDocumentHistory.Name = "BtnDocumentHistory"
        Me.BtnDocumentHistory.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnDocumentHistory.Size = New System.Drawing.Size(75, 37)
        Me.BtnDocumentHistory.TabIndex = 13
        Me.BtnDocumentHistory.TabStop = False
        Me.BtnDocumentHistory.Text = "&Haal uit klassement"
        Me.BtnDocumentHistory.UseVisualStyleBackColor = False
        '
        'BtnGenerateAndSave
        '
        Me.BtnGenerateAndSave.BackColor = System.Drawing.SystemColors.Control
        Me.BtnGenerateAndSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnGenerateAndSave.Enabled = False
        Me.BtnGenerateAndSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnGenerateAndSave.Location = New System.Drawing.Point(349, 121)
        Me.BtnGenerateAndSave.Name = "BtnGenerateAndSave"
        Me.BtnGenerateAndSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGenerateAndSave.Size = New System.Drawing.Size(75, 22)
        Me.BtnGenerateAndSave.TabIndex = 14
        Me.BtnGenerateAndSave.Text = "&Verwerken"
        Me.BtnGenerateAndSave.UseVisualStyleBackColor = False
        '
        'CbMedekontraktant
        '
        Me.CbMedekontraktant.BackColor = System.Drawing.SystemColors.Control
        Me.CbMedekontraktant.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CbMedekontraktant.Cursor = System.Windows.Forms.Cursors.Default
        Me.CbMedekontraktant.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CbMedekontraktant.Location = New System.Drawing.Point(472, 94)
        Me.CbMedekontraktant.Name = "CbMedekontraktant"
        Me.CbMedekontraktant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CbMedekontraktant.Size = New System.Drawing.Size(136, 24)
        Me.CbMedekontraktant.TabIndex = 15
        Me.CbMedekontraktant.Text = "Bt&w Medekontractant"
        Me.CbMedekontraktant.UseVisualStyleBackColor = False
        '
        'CbCreditNota
        '
        Me.CbCreditNota.BackColor = System.Drawing.SystemColors.Control
        Me.CbCreditNota.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CbCreditNota.Cursor = System.Windows.Forms.Cursors.Default
        Me.CbCreditNota.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CbCreditNota.Location = New System.Drawing.Point(515, 82)
        Me.CbCreditNota.Name = "CbCreditNota"
        Me.CbCreditNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CbCreditNota.Size = New System.Drawing.Size(93, 16)
        Me.CbCreditNota.TabIndex = 16
        Me.CbCreditNota.TabStop = False
        Me.CbCreditNota.Text = "&CreditNota"
        Me.CbCreditNota.UseVisualStyleBackColor = False
        '
        'BtnGetClient
        '
        Me.BtnGetClient.BackColor = System.Drawing.SystemColors.Control
        Me.BtnGetClient.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnGetClient.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnGetClient.Location = New System.Drawing.Point(265, 93)
        Me.BtnGetClient.Name = "BtnGetClient"
        Me.BtnGetClient.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGetClient.Size = New System.Drawing.Size(75, 23)
        Me.BtnGetClient.TabIndex = 0
        Me.BtnGetClient.Text = "&Klant"
        Me.BtnGetClient.UseVisualStyleBackColor = False
        '
        'VerkoopDetail
        '
        Me.VerkoopDetail.BackColor = System.Drawing.Color.White
        Me.VerkoopDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.VerkoopDetail.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerkoopDetail.ForeColor = System.Drawing.Color.Black
        Me.VerkoopDetail.ItemHeight = 14
        Me.VerkoopDetail.Location = New System.Drawing.Point(9, 165)
        Me.VerkoopDetail.Name = "VerkoopDetail"
        Me.VerkoopDetail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VerkoopDetail.Size = New System.Drawing.Size(533, 256)
        Me.VerkoopDetail.TabIndex = 17
        '
        'Sjabloon
        '
        Me.Sjabloon.BackColor = System.Drawing.SystemColors.Control
        Me.Sjabloon.Cursor = System.Windows.Forms.Cursors.Default
        Me.Sjabloon.Enabled = False
        Me.Sjabloon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Sjabloon.Location = New System.Drawing.Point(393, 29)
        Me.Sjabloon.Name = "Sjabloon"
        Me.Sjabloon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Sjabloon.Size = New System.Drawing.Size(71, 23)
        Me.Sjabloon.TabIndex = 18
        Me.Sjabloon.TabStop = False
        Me.Sjabloon.Text = "Sja&bloon"
        Me.Sjabloon.UseVisualStyleBackColor = False
        '
        'RbDirekteVerkoop
        '
        Me.RbDirekteVerkoop.BackColor = System.Drawing.SystemColors.Control
        Me.RbDirekteVerkoop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RbDirekteVerkoop.Cursor = System.Windows.Forms.Cursors.Default
        Me.RbDirekteVerkoop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RbDirekteVerkoop.Location = New System.Drawing.Point(10, 16)
        Me.RbDirekteVerkoop.Name = "RbDirekteVerkoop"
        Me.RbDirekteVerkoop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RbDirekteVerkoop.Size = New System.Drawing.Size(115, 16)
        Me.RbDirekteVerkoop.TabIndex = 19
        Me.RbDirekteVerkoop.Text = "&Direkte Verkoop"
        Me.RbDirekteVerkoop.UseVisualStyleBackColor = False
        '
        'RbBestelbon
        '
        Me.RbBestelbon.BackColor = System.Drawing.SystemColors.Control
        Me.RbBestelbon.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RbBestelbon.Cursor = System.Windows.Forms.Cursors.Default
        Me.RbBestelbon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RbBestelbon.Location = New System.Drawing.Point(42, 33)
        Me.RbBestelbon.Name = "RbBestelbon"
        Me.RbBestelbon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RbBestelbon.Size = New System.Drawing.Size(83, 16)
        Me.RbBestelbon.TabIndex = 20
        Me.RbBestelbon.Text = "Bestelbon"
        Me.RbBestelbon.UseVisualStyleBackColor = False
        '
        'RbOfferte
        '
        Me.RbOfferte.BackColor = System.Drawing.SystemColors.Control
        Me.RbOfferte.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RbOfferte.Cursor = System.Windows.Forms.Cursors.Default
        Me.RbOfferte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RbOfferte.Location = New System.Drawing.Point(58, 49)
        Me.RbOfferte.Name = "RbOfferte"
        Me.RbOfferte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RbOfferte.Size = New System.Drawing.Size(67, 16)
        Me.RbOfferte.TabIndex = 21
        Me.RbOfferte.Text = "Offerte"
        Me.RbOfferte.UseVisualStyleBackColor = False
        '
        'lstKopiePlak
        '
        Me.lstKopiePlak.BackColor = System.Drawing.SystemColors.Window
        Me.lstKopiePlak.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstKopiePlak.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstKopiePlak.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstKopiePlak.ItemHeight = 14
        Me.lstKopiePlak.Location = New System.Drawing.Point(58, 171)
        Me.lstKopiePlak.Name = "lstKopiePlak"
        Me.lstKopiePlak.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstKopiePlak.Size = New System.Drawing.Size(473, 242)
        Me.lstKopiePlak.TabIndex = 68
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbOfferte)
        Me.GroupBox1.Controls.Add(Me.RbDirekteVerkoop)
        Me.GroupBox1.Controls.Add(Me.RbBestelbon)
        Me.GroupBox1.Location = New System.Drawing.Point(480, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 67)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type Document"
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = True
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(176, 230)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(270, 42)
        Me.lblInOntwikkeling.TabIndex = 88
        Me.lblInOntwikkeling.Text = "In Ontwikkeling"
        '
        'FomSalesTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(622, 502)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblInOntwikkeling)
        Me.Controls.Add(Me.VerkoopDetail)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstKopiePlak)
        Me.Controls.Add(Me._Label1_9)
        Me.Controls.Add(Me._Label1_8)
        Me.Controls.Add(Me.cbPDF)
        Me.Controls.Add(Me._Label1_6)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.btwBedrag1)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.btwBedrag2)
        Me.Controls.Add(Me.btwBedrag3)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me.cbLayOudPDF)
        Me.Controls.Add(Me._Label1_20)
        Me.Controls.Add(Me._Label1_12)
        Me.Controls.Add(Me.LblInBtw)
        Me.Controls.Add(Me.LblExBtw)
        Me.Controls.Add(Me.LblIn2Btw)
        Me.Controls.Add(Me.LblEx2Btw)
        Me.Controls.Add(Me.Sjabloon)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me.BtnGetClient)
        Me.Controls.Add(Me._Label1_5)
        Me.Controls.Add(Me.CbCreditNota)
        Me.Controls.Add(Me._Label1_7)
        Me.Controls.Add(Me.CbMedekontraktant)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me.BtnGenerateAndSave)
        Me.Controls.Add(Me._Label1_4)
        Me.Controls.Add(Me.BtnDocumentHistory)
        Me.Controls.Add(Me._Label1_0)
        Me.Controls.Add(Me.Overschrijvingsstrook)
        Me.Controls.Add(Me.KlantInfo)
        Me.Controls.Add(Me.Optimaliseer)
        Me.Controls.Add(Me.DagKoers)
        Me.Controls.Add(Me.BtnFromStock)
        Me.Controls.Add(Me.TekstInfo3)
        Me.Controls.Add(Me.BtnFromDescription)
        Me.Controls.Add(Me.datumdocMTextbox)
        Me.Controls.Add(Me.BtnPutTextLine)
        Me.Controls.Add(Me.mgrklantenrekMTextBox)
        Me.Controls.Add(Me.BtnGenerateCopy)
        Me.Controls.Add(Me.vervaldagMTextBox)
        Me.Controls.Add(Me.cmdSQLInfo)
        Me.Controls.Add(Me.muntMTextBox)
        Me.Controls.Add(Me.cmdLijst)
        Me.Controls.Add(Me.BtnSwitchMoney)
        Me.Controls.Add(Me.chkZonderRelatie)
        Me.Controls.Add(Me.ckEURINFO)
        Me.Controls.Add(Me.CbBTWBouw)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FomSalesTransactions"
        Me.Text = "Verkoopverrichtingen"
        Me.GroupBox1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Public WithEvents cbPDF As CheckBox
    Public WithEvents BtnCancel As Button
    Public WithEvents BtnClear As Button
    Public WithEvents cbLayOudPDF As Button
    Public WithEvents _Label1_9 As Label
    Public WithEvents _Label1_8 As Label
    Public WithEvents _Label1_6 As Label
    Public WithEvents btwBedrag1 As Label
    Public WithEvents btwBedrag2 As Label
    Public WithEvents btwBedrag3 As Label
    Public WithEvents _Label1_3 As Label
    Public WithEvents _Label1_20 As Label
    Public WithEvents _Label1_12 As Label
    Public WithEvents LblInBtw As Label
    Public WithEvents LblExBtw As Label
    Public WithEvents LblIn2Btw As Label
    Public WithEvents LblEx2Btw As Label
    Public WithEvents _Label1_1 As Label
    Public WithEvents _Label1_5 As Label
    Public WithEvents _Label1_7 As Label
    Public WithEvents _Label1_2 As Label
    Public WithEvents _Label1_4 As Label
    Public WithEvents _Label1_0 As Label
    Public WithEvents KlantInfo As Label
    Public WithEvents DagKoers As Label
    Public WithEvents TekstInfo3 As MaskedTextBox
    Public WithEvents datumdocMTextbox As MaskedTextBox
    Public WithEvents mgrklantenrekMTextBox As MaskedTextBox
    Public WithEvents vervaldagMTextBox As MaskedTextBox
    Public WithEvents muntMTextBox As MaskedTextBox
    Public WithEvents BtnSwitchMoney As Button
    Public WithEvents ckEURINFO As CheckBox
    Public WithEvents CbBTWBouw As CheckBox
    Public WithEvents chkZonderRelatie As CheckBox
    Public WithEvents cmdLijst As Button
    Public WithEvents cmdSQLInfo As Button
    Public WithEvents BtnGenerateCopy As Button
    Public WithEvents BtnPutTextLine As Button
    Public WithEvents BtnFromDescription As Button
    Public WithEvents BtnFromStock As Button
    Public WithEvents Optimaliseer As Button
    Public WithEvents Overschrijvingsstrook As CheckBox
    Public WithEvents BtnDocumentHistory As Button
    Public WithEvents BtnGenerateAndSave As Button
    Public WithEvents CbMedekontraktant As CheckBox
    Public WithEvents CbCreditNota As CheckBox
    Public WithEvents BtnGetClient As Button
    Public WithEvents VerkoopDetail As ListBox
    Public WithEvents Sjabloon As Button
    Public WithEvents RbDirekteVerkoop As RadioButton
    Public WithEvents RbBestelbon As RadioButton
    Public WithEvents RbOfferte As RadioButton
    Public WithEvents lstKopiePlak As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblInOntwikkeling As Label
End Class
