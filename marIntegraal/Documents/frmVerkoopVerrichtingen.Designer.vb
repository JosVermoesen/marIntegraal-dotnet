<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerkoopVerrichtingen
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
        Me.Annuleren = New System.Windows.Forms.Button()
        Me.Schoonvegen = New System.Windows.Forms.Button()
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
        Me.cmdSwitch = New System.Windows.Forms.Button()
        Me.ckEURINFO = New System.Windows.Forms.CheckBox()
        Me.chkBTWBouw = New System.Windows.Forms.CheckBox()
        Me.chkZonderRelatie = New System.Windows.Forms.CheckBox()
        Me.cmdLijst = New System.Windows.Forms.Button()
        Me.cmdSQLInfo = New System.Windows.Forms.Button()
        Me.CmbAfdruk = New System.Windows.Forms.Button()
        Me.CmdTekst = New System.Windows.Forms.Button()
        Me.CmdOmschrijving = New System.Windows.Forms.Button()
        Me.CmdStock = New System.Windows.Forms.Button()
        Me.Optimaliseer = New System.Windows.Forms.Button()
        Me.Overschrijvingsstrook = New System.Windows.Forms.CheckBox()
        Me.Klassement = New System.Windows.Forms.Button()
        Me.Afsluiten = New System.Windows.Forms.Button()
        Me.Medekontraktant = New System.Windows.Forms.CheckBox()
        Me.CreditNota = New System.Windows.Forms.CheckBox()
        Me.KlantAktiveren = New System.Windows.Forms.Button()
        Me.VerkoopDetail = New System.Windows.Forms.ListBox()
        Me.Sjabloon = New System.Windows.Forms.Button()
        Me.DirekteVerkoop = New System.Windows.Forms.RadioButton()
        Me.Bestelbon = New System.Windows.Forms.RadioButton()
        Me.Offerte = New System.Windows.Forms.RadioButton()
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
        Me.cbPDF.UseVisualStyleBackColor = false
        '
        'Annuleren
        '
        Me.Annuleren.BackColor = System.Drawing.SystemColors.Control
        Me.Annuleren.Cursor = System.Windows.Forms.Cursors.Default
        Me.Annuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Annuleren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Annuleren.Location = New System.Drawing.Point(480, 475)
        Me.Annuleren.Name = "Annuleren"
        Me.Annuleren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Annuleren.Size = New System.Drawing.Size(59, 21)
        Me.Annuleren.TabIndex = 65
        Me.Annuleren.TabStop = false
        Me.Annuleren.Text = "Sluiten"
        Me.Annuleren.UseVisualStyleBackColor = false
        '
        'Schoonvegen
        '
        Me.Schoonvegen.BackColor = System.Drawing.SystemColors.Control
        Me.Schoonvegen.Cursor = System.Windows.Forms.Cursors.Default
        Me.Schoonvegen.Enabled = false
        Me.Schoonvegen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Schoonvegen.Location = New System.Drawing.Point(544, 475)
        Me.Schoonvegen.Name = "Schoonvegen"
        Me.Schoonvegen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Schoonvegen.Size = New System.Drawing.Size(59, 19)
        Me.Schoonvegen.TabIndex = 64
        Me.Schoonvegen.TabStop = false
        Me.Schoonvegen.Text = "Schoo&n"
        Me.Schoonvegen.UseVisualStyleBackColor = false
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
        Me.cbLayOudPDF.TabStop = false
        Me.cbLayOudPDF.Text = "Beheer van VPE PFD Lay-Out"
        Me.cbLayOudPDF.UseVisualStyleBackColor = false
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
        Me._Label1_3.AutoSize = true
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
        Me._Label1_5.AutoSize = true
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
        Me._Label1_7.AutoSize = true
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
        Me.KlantInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
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
        Me.DagKoers.AutoSize = true
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
        Me.TekstInfo3.AllowPromptAsInput = false
        Me.TekstInfo3.BackColor = System.Drawing.Color.Yellow
        Me.TekstInfo3.Location = New System.Drawing.Point(385, 6)
        Me.TekstInfo3.Name = "TekstInfo3"
        Me.TekstInfo3.Size = New System.Drawing.Size(89, 20)
        Me.TekstInfo3.TabIndex = 26
        Me.TekstInfo3.TabStop = false
        Me.TekstInfo3.Visible = false
        '
        'datumdocMTextbox
        '
        Me.datumdocMTextbox.AllowPromptAsInput = false
        Me.datumdocMTextbox.BackColor = System.Drawing.Color.Yellow
        Me.datumdocMTextbox.Location = New System.Drawing.Point(105, 29)
        Me.datumdocMTextbox.Mask = "##/##/####"
        Me.datumdocMTextbox.Name = "datumdocMTextbox"
        Me.datumdocMTextbox.Size = New System.Drawing.Size(93, 20)
        Me.datumdocMTextbox.TabIndex = 25
        '
        'mgrklantenrekMTextBox
        '
        Me.mgrklantenrekMTextBox.AllowPromptAsInput = false
        Me.mgrklantenrekMTextBox.BackColor = System.Drawing.Color.Yellow
        Me.mgrklantenrekMTextBox.Location = New System.Drawing.Point(301, 29)
        Me.mgrklantenrekMTextBox.Name = "mgrklantenrekMTextBox"
        Me.mgrklantenrekMTextBox.Size = New System.Drawing.Size(89, 20)
        Me.mgrklantenrekMTextBox.TabIndex = 24
        '
        'vervaldagMTextBox
        '
        Me.vervaldagMTextBox.AllowPromptAsInput = false
        Me.vervaldagMTextBox.BackColor = System.Drawing.Color.Yellow
        Me.vervaldagMTextBox.Location = New System.Drawing.Point(205, 29)
        Me.vervaldagMTextBox.Mask = "##/##/####"
        Me.vervaldagMTextBox.Name = "vervaldagMTextBox"
        Me.vervaldagMTextBox.Size = New System.Drawing.Size(93, 20)
        Me.vervaldagMTextBox.TabIndex = 23
        '
        'muntMTextBox
        '
        Me.muntMTextBox.AllowPromptAsInput = false
        Me.muntMTextBox.BackColor = System.Drawing.Color.Yellow
        Me.muntMTextBox.Enabled = false
        Me.muntMTextBox.Location = New System.Drawing.Point(9, 29)
        Me.muntMTextBox.Name = "muntMTextBox"
        Me.muntMTextBox.Size = New System.Drawing.Size(93, 20)
        Me.muntMTextBox.TabIndex = 22
        '
        'cmdSwitch
        '
        Me.cmdSwitch.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSwitch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSwitch.Enabled = false
        Me.cmdSwitch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSwitch.Location = New System.Drawing.Point(545, 285)
        Me.cmdSwitch.Name = "cmdSwitch"
        Me.cmdSwitch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSwitch.Size = New System.Drawing.Size(67, 37)
        Me.cmdSwitch.TabIndex = 1
        Me.cmdSwitch.TabStop = false
        Me.cmdSwitch.Text = "Ingave in BEF"
        Me.cmdSwitch.UseVisualStyleBackColor = false
        '
        'ckEURINFO
        '
        Me.ckEURINFO.BackColor = System.Drawing.SystemColors.Control
        Me.ckEURINFO.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckEURINFO.Checked = true
        Me.ckEURINFO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckEURINFO.Cursor = System.Windows.Forms.Cursors.Default
        Me.ckEURINFO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ckEURINFO.Location = New System.Drawing.Point(237, 145)
        Me.ckEURINFO.Name = "ckEURINFO"
        Me.ckEURINFO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ckEURINFO.Size = New System.Drawing.Size(97, 17)
        Me.ckEURINFO.TabIndex = 2
        Me.ckEURINFO.Text = "&Euro && Bef Info"
        Me.ckEURINFO.UseVisualStyleBackColor = false
        '
        'chkBTWBouw
        '
        Me.chkBTWBouw.BackColor = System.Drawing.SystemColors.Control
        Me.chkBTWBouw.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkBTWBouw.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkBTWBouw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkBTWBouw.Location = New System.Drawing.Point(469, 117)
        Me.chkBTWBouw.Name = "chkBTWBouw"
        Me.chkBTWBouw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkBTWBouw.Size = New System.Drawing.Size(139, 16)
        Me.chkBTWBouw.TabIndex = 3
        Me.chkBTWBouw.Text = "Btw Tarief Bouw + 5 jaar"
        Me.chkBTWBouw.UseVisualStyleBackColor = false
        '
        'chkZonderRelatie
        '
        Me.chkZonderRelatie.BackColor = System.Drawing.SystemColors.Control
        Me.chkZonderRelatie.Checked = true
        Me.chkZonderRelatie.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkZonderRelatie.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkZonderRelatie.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkZonderRelatie.Location = New System.Drawing.Point(393, 77)
        Me.chkZonderRelatie.Name = "chkZonderRelatie"
        Me.chkZonderRelatie.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkZonderRelatie.Size = New System.Drawing.Size(116, 23)
        Me.chkZonderRelatie.TabIndex = 4
        Me.chkZonderRelatie.Text = "&Nog te factureren"
        Me.chkZonderRelatie.UseVisualStyleBackColor = false
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
        Me.cmdLijst.UseVisualStyleBackColor = false
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
        Me.cmdSQLInfo.TabStop = false
        Me.cmdSQLInfo.Text = "SQL &Info"
        Me.cmdSQLInfo.UseVisualStyleBackColor = false
        Me.cmdSQLInfo.Visible = false
        '
        'CmbAfdruk
        '
        Me.CmbAfdruk.BackColor = System.Drawing.SystemColors.Control
        Me.CmbAfdruk.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbAfdruk.Enabled = false
        Me.CmbAfdruk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmbAfdruk.Location = New System.Drawing.Point(545, 165)
        Me.CmbAfdruk.Name = "CmbAfdruk"
        Me.CmbAfdruk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbAfdruk.Size = New System.Drawing.Size(63, 35)
        Me.CmbAfdruk.TabIndex = 7
        Me.CmbAfdruk.Text = "(Extra) Afdruk"
        Me.CmbAfdruk.UseVisualStyleBackColor = false
        '
        'CmdTekst
        '
        Me.CmdTekst.BackColor = System.Drawing.SystemColors.Control
        Me.CmdTekst.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdTekst.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdTekst.Location = New System.Drawing.Point(261, 121)
        Me.CmdTekst.Name = "CmdTekst"
        Me.CmdTekst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdTekst.Size = New System.Drawing.Size(87, 22)
        Me.CmdTekst.TabIndex = 8
        Me.CmdTekst.TabStop = false
        Me.CmdTekst.Text = "Vrije &Tekst"
        Me.CmdTekst.UseVisualStyleBackColor = false
        '
        'CmdOmschrijving
        '
        Me.CmdOmschrijving.BackColor = System.Drawing.SystemColors.Control
        Me.CmdOmschrijving.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdOmschrijving.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdOmschrijving.Location = New System.Drawing.Point(97, 121)
        Me.CmdOmschrijving.Name = "CmdOmschrijving"
        Me.CmdOmschrijving.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdOmschrijving.Size = New System.Drawing.Size(163, 22)
        Me.CmdOmschrijving.TabIndex = 9
        Me.CmdOmschrijving.TabStop = false
        Me.CmdOmschrijving.Text = "Bedrag via &Omschrijving"
        Me.CmdOmschrijving.UseVisualStyleBackColor = false
        '
        'CmdStock
        '
        Me.CmdStock.BackColor = System.Drawing.SystemColors.Control
        Me.CmdStock.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdStock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdStock.Location = New System.Drawing.Point(9, 121)
        Me.CmdStock.Name = "CmdStock"
        Me.CmdStock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdStock.Size = New System.Drawing.Size(87, 22)
        Me.CmdStock.TabIndex = 10
        Me.CmdStock.TabStop = false
        Me.CmdStock.Text = "&Stock artikel"
        Me.CmdStock.UseVisualStyleBackColor = false
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
        Me.Optimaliseer.TabStop = false
        Me.Optimaliseer.Text = "O&ptimaliseer"
        Me.Optimaliseer.UseVisualStyleBackColor = false
        '
        'Overschrijvingsstrook
        '
        Me.Overschrijvingsstrook.BackColor = System.Drawing.SystemColors.Control
        Me.Overschrijvingsstrook.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Overschrijvingsstrook.Checked = true
        Me.Overschrijvingsstrook.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Overschrijvingsstrook.Cursor = System.Windows.Forms.Cursors.Default
        Me.Overschrijvingsstrook.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Overschrijvingsstrook.Location = New System.Drawing.Point(545, 205)
        Me.Overschrijvingsstrook.Name = "Overschrijvingsstrook"
        Me.Overschrijvingsstrook.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Overschrijvingsstrook.Size = New System.Drawing.Size(65, 31)
        Me.Overschrijvingsstrook.TabIndex = 12
        Me.Overschrijvingsstrook.Text = "&Met OVS Strook"
        Me.Overschrijvingsstrook.UseVisualStyleBackColor = false
        '
        'Klassement
        '
        Me.Klassement.BackColor = System.Drawing.SystemColors.Control
        Me.Klassement.Cursor = System.Windows.Forms.Cursors.Default
        Me.Klassement.Enabled = false
        Me.Klassement.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Klassement.Location = New System.Drawing.Point(265, 53)
        Me.Klassement.Name = "Klassement"
        Me.Klassement.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Klassement.Size = New System.Drawing.Size(75, 37)
        Me.Klassement.TabIndex = 13
        Me.Klassement.TabStop = false
        Me.Klassement.Text = "&Haal uit klassement"
        Me.Klassement.UseVisualStyleBackColor = false
        '
        'Afsluiten
        '
        Me.Afsluiten.BackColor = System.Drawing.SystemColors.Control
        Me.Afsluiten.Cursor = System.Windows.Forms.Cursors.Default
        Me.Afsluiten.Enabled = false
        Me.Afsluiten.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Afsluiten.Location = New System.Drawing.Point(349, 121)
        Me.Afsluiten.Name = "Afsluiten"
        Me.Afsluiten.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Afsluiten.Size = New System.Drawing.Size(75, 22)
        Me.Afsluiten.TabIndex = 14
        Me.Afsluiten.Text = "&Verwerken"
        Me.Afsluiten.UseVisualStyleBackColor = false
        '
        'Medekontraktant
        '
        Me.Medekontraktant.BackColor = System.Drawing.SystemColors.Control
        Me.Medekontraktant.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Medekontraktant.Cursor = System.Windows.Forms.Cursors.Default
        Me.Medekontraktant.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Medekontraktant.Location = New System.Drawing.Point(472, 94)
        Me.Medekontraktant.Name = "Medekontraktant"
        Me.Medekontraktant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Medekontraktant.Size = New System.Drawing.Size(136, 24)
        Me.Medekontraktant.TabIndex = 15
        Me.Medekontraktant.Text = "Bt&w Medekontractant"
        Me.Medekontraktant.UseVisualStyleBackColor = false
        '
        'CreditNota
        '
        Me.CreditNota.BackColor = System.Drawing.SystemColors.Control
        Me.CreditNota.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CreditNota.Cursor = System.Windows.Forms.Cursors.Default
        Me.CreditNota.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CreditNota.Location = New System.Drawing.Point(515, 82)
        Me.CreditNota.Name = "CreditNota"
        Me.CreditNota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CreditNota.Size = New System.Drawing.Size(93, 16)
        Me.CreditNota.TabIndex = 16
        Me.CreditNota.TabStop = false
        Me.CreditNota.Text = "&CreditNota"
        Me.CreditNota.UseVisualStyleBackColor = false
        '
        'KlantAktiveren
        '
        Me.KlantAktiveren.BackColor = System.Drawing.SystemColors.Control
        Me.KlantAktiveren.Cursor = System.Windows.Forms.Cursors.Default
        Me.KlantAktiveren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.KlantAktiveren.Location = New System.Drawing.Point(265, 93)
        Me.KlantAktiveren.Name = "KlantAktiveren"
        Me.KlantAktiveren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.KlantAktiveren.Size = New System.Drawing.Size(75, 23)
        Me.KlantAktiveren.TabIndex = 0
        Me.KlantAktiveren.Text = "&Klant"
        Me.KlantAktiveren.UseVisualStyleBackColor = false
        '
        'VerkoopDetail
        '
        Me.VerkoopDetail.BackColor = System.Drawing.Color.White
        Me.VerkoopDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.VerkoopDetail.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
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
        Me.Sjabloon.Enabled = false
        Me.Sjabloon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Sjabloon.Location = New System.Drawing.Point(393, 29)
        Me.Sjabloon.Name = "Sjabloon"
        Me.Sjabloon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Sjabloon.Size = New System.Drawing.Size(71, 23)
        Me.Sjabloon.TabIndex = 18
        Me.Sjabloon.TabStop = false
        Me.Sjabloon.Text = "Sja&bloon"
        Me.Sjabloon.UseVisualStyleBackColor = false
        '
        'DirekteVerkoop
        '
        Me.DirekteVerkoop.BackColor = System.Drawing.SystemColors.Control
        Me.DirekteVerkoop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DirekteVerkoop.Cursor = System.Windows.Forms.Cursors.Default
        Me.DirekteVerkoop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DirekteVerkoop.Location = New System.Drawing.Point(10, 16)
        Me.DirekteVerkoop.Name = "DirekteVerkoop"
        Me.DirekteVerkoop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DirekteVerkoop.Size = New System.Drawing.Size(115, 16)
        Me.DirekteVerkoop.TabIndex = 19
        Me.DirekteVerkoop.Text = "&Direkte Verkoop"
        Me.DirekteVerkoop.UseVisualStyleBackColor = false
        '
        'Bestelbon
        '
        Me.Bestelbon.BackColor = System.Drawing.SystemColors.Control
        Me.Bestelbon.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bestelbon.Cursor = System.Windows.Forms.Cursors.Default
        Me.Bestelbon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Bestelbon.Location = New System.Drawing.Point(42, 33)
        Me.Bestelbon.Name = "Bestelbon"
        Me.Bestelbon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Bestelbon.Size = New System.Drawing.Size(83, 16)
        Me.Bestelbon.TabIndex = 20
        Me.Bestelbon.Text = "Bestelbon"
        Me.Bestelbon.UseVisualStyleBackColor = false
        '
        'Offerte
        '
        Me.Offerte.BackColor = System.Drawing.SystemColors.Control
        Me.Offerte.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Offerte.Cursor = System.Windows.Forms.Cursors.Default
        Me.Offerte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Offerte.Location = New System.Drawing.Point(58, 49)
        Me.Offerte.Name = "Offerte"
        Me.Offerte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Offerte.Size = New System.Drawing.Size(67, 16)
        Me.Offerte.TabIndex = 21
        Me.Offerte.Text = "Offerte"
        Me.Offerte.UseVisualStyleBackColor = false
        '
        'lstKopiePlak
        '
        Me.lstKopiePlak.BackColor = System.Drawing.SystemColors.Window
        Me.lstKopiePlak.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstKopiePlak.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
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
        Me.GroupBox1.Controls.Add(Me.Offerte)
        Me.GroupBox1.Controls.Add(Me.DirekteVerkoop)
        Me.GroupBox1.Controls.Add(Me.Bestelbon)
        Me.GroupBox1.Location = New System.Drawing.Point(480, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 67)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Type Document"
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = true
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(176, 230)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(270, 42)
        Me.lblInOntwikkeling.TabIndex = 88
        Me.lblInOntwikkeling.Text = "In Ontwikkeling"
        '
        'frmVerkoopVerrichtingen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Annuleren
        Me.ClientSize = New System.Drawing.Size(622, 502)
        Me.ControlBox = false
        Me.Controls.Add(Me.lblInOntwikkeling)
        Me.Controls.Add(Me.VerkoopDetail)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstKopiePlak)
        Me.Controls.Add(Me._Label1_9)
        Me.Controls.Add(Me._Label1_8)
        Me.Controls.Add(Me.cbPDF)
        Me.Controls.Add(Me._Label1_6)
        Me.Controls.Add(Me.Annuleren)
        Me.Controls.Add(Me.btwBedrag1)
        Me.Controls.Add(Me.Schoonvegen)
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
        Me.Controls.Add(Me.KlantAktiveren)
        Me.Controls.Add(Me._Label1_5)
        Me.Controls.Add(Me.CreditNota)
        Me.Controls.Add(Me._Label1_7)
        Me.Controls.Add(Me.Medekontraktant)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me.Afsluiten)
        Me.Controls.Add(Me._Label1_4)
        Me.Controls.Add(Me.Klassement)
        Me.Controls.Add(Me._Label1_0)
        Me.Controls.Add(Me.Overschrijvingsstrook)
        Me.Controls.Add(Me.KlantInfo)
        Me.Controls.Add(Me.Optimaliseer)
        Me.Controls.Add(Me.DagKoers)
        Me.Controls.Add(Me.CmdStock)
        Me.Controls.Add(Me.TekstInfo3)
        Me.Controls.Add(Me.CmdOmschrijving)
        Me.Controls.Add(Me.datumdocMTextbox)
        Me.Controls.Add(Me.CmdTekst)
        Me.Controls.Add(Me.mgrklantenrekMTextBox)
        Me.Controls.Add(Me.CmbAfdruk)
        Me.Controls.Add(Me.vervaldagMTextBox)
        Me.Controls.Add(Me.cmdSQLInfo)
        Me.Controls.Add(Me.muntMTextBox)
        Me.Controls.Add(Me.cmdLijst)
        Me.Controls.Add(Me.cmdSwitch)
        Me.Controls.Add(Me.chkZonderRelatie)
        Me.Controls.Add(Me.ckEURINFO)
        Me.Controls.Add(Me.chkBTWBouw)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmVerkoopVerrichtingen"
        Me.Text = "Verkoopverrichtingen"
        Me.GroupBox1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Public WithEvents cbPDF As CheckBox
    Public WithEvents Annuleren As Button
    Public WithEvents Schoonvegen As Button
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
    Public WithEvents cmdSwitch As Button
    Public WithEvents ckEURINFO As CheckBox
    Public WithEvents chkBTWBouw As CheckBox
    Public WithEvents chkZonderRelatie As CheckBox
    Public WithEvents cmdLijst As Button
    Public WithEvents cmdSQLInfo As Button
    Public WithEvents CmbAfdruk As Button
    Public WithEvents CmdTekst As Button
    Public WithEvents CmdOmschrijving As Button
    Public WithEvents CmdStock As Button
    Public WithEvents Optimaliseer As Button
    Public WithEvents Overschrijvingsstrook As CheckBox
    Public WithEvents Klassement As Button
    Public WithEvents Afsluiten As Button
    Public WithEvents Medekontraktant As CheckBox
    Public WithEvents CreditNota As CheckBox
    Public WithEvents KlantAktiveren As Button
    Public WithEvents VerkoopDetail As ListBox
    Public WithEvents Sjabloon As Button
    Public WithEvents DirekteVerkoop As RadioButton
    Public WithEvents Bestelbon As RadioButton
    Public WithEvents Offerte As RadioButton
    Public WithEvents lstKopiePlak As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblInOntwikkeling As Label
End Class
