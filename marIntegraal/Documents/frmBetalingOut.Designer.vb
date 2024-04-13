<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBetalingOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBetalingOut))
        Me._Selektie_1 = New System.Windows.Forms.CheckBox()
        Me.cbLeveranciers = New System.Windows.Forms.CheckBox()
        Me.chkAfdrukInVenster = New System.Windows.Forms.CheckBox()
        Me.cbBank = New System.Windows.Forms.ComboBox()
        Me.tbBedrag = New System.Windows.Forms.TextBox()
        Me.mebRekening = New System.Windows.Forms.MaskedTextBox()
        Me.CmdEmailNBB = New System.Windows.Forms.Button()
        Me.Samenstellen = New System.Windows.Forms.Button()
        Me._TekstLijn_2 = New System.Windows.Forms.TextBox()
        Me._TekstLijn_3 = New System.Windows.Forms.TextBox()
        Me._Selektie_0 = New System.Windows.Forms.CheckBox()
        Me._Selektie_2 = New System.Windows.Forms.CheckBox()
        Me.Drukken = New System.Windows.Forms.Button()
        Me.cmdSluiten = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEUR = New System.Windows.Forms.Label()
        Me.lblBEF = New System.Windows.Forms.Label()
        Me._lbBank_0 = New System.Windows.Forms.Label()
        Me.lbBedrag = New System.Windows.Forms.Label()
        Me.lbReferte = New System.Windows.Forms.Label()
        Me.lbMemoDatum = New System.Windows.Forms.Label()
        Me.lbDatumKontrole = New System.Windows.Forms.Label()
        Me.lbVanTot = New System.Windows.Forms.Label()
        Me.lblInOntwikkeling = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        '_Selektie_1
        '
        Me._Selektie_1.BackColor = System.Drawing.SystemColors.Control
        Me._Selektie_1.Checked = true
        Me._Selektie_1.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Selektie_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Selektie_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Selektie_1.Location = New System.Drawing.Point(12, 89)
        Me._Selektie_1.Name = "_Selektie_1"
        Me._Selektie_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Selektie_1.Size = New System.Drawing.Size(205, 16)
        Me._Selektie_1.TabIndex = 50
        Me._Selektie_1.TabStop = false
        Me._Selektie_1.Text = "&Verrichtingen in afwachting uitsluiten"
        Me._Selektie_1.UseVisualStyleBackColor = false
        '
        'cbLeveranciers
        '
        Me.cbLeveranciers.BackColor = System.Drawing.SystemColors.Control
        Me.cbLeveranciers.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbLeveranciers.Checked = true
        Me.cbLeveranciers.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbLeveranciers.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbLeveranciers.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbLeveranciers.Location = New System.Drawing.Point(344, 49)
        Me.cbLeveranciers.Name = "cbLeveranciers"
        Me.cbLeveranciers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbLeveranciers.Size = New System.Drawing.Size(114, 17)
        Me.cbLeveranciers.TabIndex = 49
        Me.cbLeveranciers.Text = "Enkel Leveranciers"
        Me.cbLeveranciers.UseVisualStyleBackColor = false
        '
        'chkAfdrukInVenster
        '
        Me.chkAfdrukInVenster.BackColor = System.Drawing.SystemColors.Control
        Me.chkAfdrukInVenster.Checked = true
        Me.chkAfdrukInVenster.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAfdrukInVenster.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAfdrukInVenster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAfdrukInVenster.Location = New System.Drawing.Point(532, 37)
        Me.chkAfdrukInVenster.Name = "chkAfdrukInVenster"
        Me.chkAfdrukInVenster.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAfdrukInVenster.Size = New System.Drawing.Size(70, 17)
        Me.chkAfdrukInVenster.TabIndex = 48
        Me.chkAfdrukInVenster.Text = "In venster"
        Me.chkAfdrukInVenster.UseVisualStyleBackColor = false
        '
        'cbBank
        '
        Me.cbBank.BackColor = System.Drawing.SystemColors.Window
        Me.cbBank.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBank.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbBank.Location = New System.Drawing.Point(244, 89)
        Me.cbBank.Name = "cbBank"
        Me.cbBank.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbBank.Size = New System.Drawing.Size(221, 21)
        Me.cbBank.TabIndex = 43
        '
        'tbBedrag
        '
        Me.tbBedrag.AcceptsReturn = true
        Me.tbBedrag.BackColor = System.Drawing.Color.White
        Me.tbBedrag.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbBedrag.Enabled = false
        Me.tbBedrag.ForeColor = System.Drawing.Color.Black
        Me.tbBedrag.Location = New System.Drawing.Point(280, 325)
        Me.tbBedrag.MaxLength = 0
        Me.tbBedrag.Name = "tbBedrag"
        Me.tbBedrag.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbBedrag.Size = New System.Drawing.Size(101, 20)
        Me.tbBedrag.TabIndex = 34
        Me.tbBedrag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mebRekening
        '
        Me.mebRekening.AllowPromptAsInput = false
        Me.mebRekening.Enabled = false
        Me.mebRekening.Location = New System.Drawing.Point(8, 325)
        Me.mebRekening.Name = "mebRekening"
        Me.mebRekening.Size = New System.Drawing.Size(177, 20)
        Me.mebRekening.TabIndex = 31
        '
        'CmdEmailNBB
        '
        Me.CmdEmailNBB.BackColor = System.Drawing.SystemColors.Control
        Me.CmdEmailNBB.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdEmailNBB.Enabled = false
        Me.CmdEmailNBB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdEmailNBB.Image = CType(resources.GetObject("CmdEmailNBB.Image"),System.Drawing.Image)
        Me.CmdEmailNBB.Location = New System.Drawing.Point(616, 13)
        Me.CmdEmailNBB.Name = "CmdEmailNBB"
        Me.CmdEmailNBB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdEmailNBB.Size = New System.Drawing.Size(69, 69)
        Me.CmdEmailNBB.TabIndex = 40
        Me.CmdEmailNBB.Text = "&Versturen"
        Me.CmdEmailNBB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdEmailNBB.UseVisualStyleBackColor = false
        '
        'Samenstellen
        '
        Me.Samenstellen.BackColor = System.Drawing.SystemColors.Control
        Me.Samenstellen.Cursor = System.Windows.Forms.Cursors.Default
        Me.Samenstellen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Samenstellen.Location = New System.Drawing.Point(240, 49)
        Me.Samenstellen.Name = "Samenstellen"
        Me.Samenstellen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Samenstellen.Size = New System.Drawing.Size(75, 20)
        Me.Samenstellen.TabIndex = 38
        Me.Samenstellen.TabStop = false
        Me.Samenstellen.Text = "Samenstellen"
        Me.Samenstellen.UseVisualStyleBackColor = false
        '
        '_TekstLijn_2
        '
        Me._TekstLijn_2.AcceptsReturn = true
        Me._TekstLijn_2.BackColor = System.Drawing.Color.White
        Me._TekstLijn_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstLijn_2.ForeColor = System.Drawing.Color.Black
        Me._TekstLijn_2.Location = New System.Drawing.Point(240, 25)
        Me._TekstLijn_2.MaxLength = 0
        Me._TekstLijn_2.Name = "_TekstLijn_2"
        Me._TekstLijn_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstLijn_2.Size = New System.Drawing.Size(109, 20)
        Me._TekstLijn_2.TabIndex = 28
        '
        '_TekstLijn_3
        '
        Me._TekstLijn_3.AcceptsReturn = true
        Me._TekstLijn_3.BackColor = System.Drawing.Color.White
        Me._TekstLijn_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstLijn_3.ForeColor = System.Drawing.Color.Black
        Me._TekstLijn_3.Location = New System.Drawing.Point(352, 25)
        Me._TekstLijn_3.MaxLength = 0
        Me._TekstLijn_3.Name = "_TekstLijn_3"
        Me._TekstLijn_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstLijn_3.Size = New System.Drawing.Size(109, 20)
        Me._TekstLijn_3.TabIndex = 29
        '
        '_Selektie_0
        '
        Me._Selektie_0.BackColor = System.Drawing.SystemColors.Control
        Me._Selektie_0.Checked = true
        Me._Selektie_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Selektie_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Selektie_0.Enabled = false
        Me._Selektie_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Selektie_0.Location = New System.Drawing.Point(12, 57)
        Me._Selektie_0.Name = "_Selektie_0"
        Me._Selektie_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Selektie_0.Size = New System.Drawing.Size(117, 15)
        Me._Selektie_0.TabIndex = 36
        Me._Selektie_0.TabStop = false
        Me._Selektie_0.Text = "K&ontrole Vervaldag"
        Me._Selektie_0.UseVisualStyleBackColor = false
        '
        '_Selektie_2
        '
        Me._Selektie_2.BackColor = System.Drawing.SystemColors.Control
        Me._Selektie_2.Checked = true
        Me._Selektie_2.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Selektie_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Selektie_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Selektie_2.Location = New System.Drawing.Point(12, 73)
        Me._Selektie_2.Name = "_Selektie_2"
        Me._Selektie_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Selektie_2.Size = New System.Drawing.Size(109, 16)
        Me._Selektie_2.TabIndex = 37
        Me._Selektie_2.TabStop = false
        Me._Selektie_2.Text = "&Enkel dit boekjaar"
        Me._Selektie_2.UseVisualStyleBackColor = false
        '
        'Drukken
        '
        Me.Drukken.BackColor = System.Drawing.SystemColors.Control
        Me.Drukken.Cursor = System.Windows.Forms.Cursors.Default
        Me.Drukken.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Drukken.Location = New System.Drawing.Point(532, 13)
        Me.Drukken.Name = "Drukken"
        Me.Drukken.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Drukken.Size = New System.Drawing.Size(75, 20)
        Me.Drukken.TabIndex = 39
        Me.Drukken.TabStop = false
        Me.Drukken.Text = "Af&drukken"
        Me.Drukken.UseVisualStyleBackColor = false
        '
        'cmdSluiten
        '
        Me.cmdSluiten.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSluiten.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSluiten.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSluiten.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSluiten.Location = New System.Drawing.Point(532, 61)
        Me.cmdSluiten.Name = "cmdSluiten"
        Me.cmdSluiten.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSluiten.Size = New System.Drawing.Size(75, 20)
        Me.cmdSluiten.TabIndex = 41
        Me.cmdSluiten.TabStop = false
        Me.cmdSluiten.Text = "Sluiten"
        Me.cmdSluiten.UseVisualStyleBackColor = false
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(552, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(33, 21)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "EUR"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(552, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(33, 21)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "BEF"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEUR
        '
        Me.lblEUR.BackColor = System.Drawing.SystemColors.Info
        Me.lblEUR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEUR.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEUR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEUR.Location = New System.Drawing.Point(588, 305)
        Me.lblEUR.Name = "lblEUR"
        Me.lblEUR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEUR.Size = New System.Drawing.Size(93, 21)
        Me.lblEUR.TabIndex = 45
        Me.lblEUR.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBEF
        '
        Me.lblBEF.BackColor = System.Drawing.SystemColors.Info
        Me.lblBEF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBEF.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblBEF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblBEF.Location = New System.Drawing.Point(588, 329)
        Me.lblBEF.Name = "lblBEF"
        Me.lblBEF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBEF.Size = New System.Drawing.Size(93, 21)
        Me.lblBEF.TabIndex = 44
        Me.lblBEF.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_lbBank_0
        '
        Me._lbBank_0.BackColor = System.Drawing.SystemColors.Control
        Me._lbBank_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lbBank_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lbBank_0.Location = New System.Drawing.Point(244, 73)
        Me._lbBank_0.Name = "_lbBank_0"
        Me._lbBank_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lbBank_0.Size = New System.Drawing.Size(40, 16)
        Me._lbBank_0.TabIndex = 42
        Me._lbBank_0.Text = "Ban&k"
        '
        'lbBedrag
        '
        Me.lbBedrag.BackColor = System.Drawing.SystemColors.Control
        Me.lbBedrag.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbBedrag.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbBedrag.Location = New System.Drawing.Point(324, 309)
        Me.lbBedrag.Name = "lbBedrag"
        Me.lbBedrag.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbBedrag.Size = New System.Drawing.Size(53, 13)
        Me.lbBedrag.TabIndex = 33
        Me.lbBedrag.Text = "&Bedrag"
        Me.lbBedrag.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbReferte
        '
        Me.lbReferte.BackColor = System.Drawing.SystemColors.Control
        Me.lbReferte.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbReferte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbReferte.Location = New System.Drawing.Point(12, 309)
        Me.lbReferte.Name = "lbReferte"
        Me.lbReferte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbReferte.Size = New System.Drawing.Size(57, 13)
        Me.lbReferte.TabIndex = 30
        Me.lbReferte.Text = "&Referte"
        '
        'lbMemoDatum
        '
        Me.lbMemoDatum.BackColor = System.Drawing.SystemColors.Control
        Me.lbMemoDatum.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbMemoDatum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbMemoDatum.Location = New System.Drawing.Point(192, 309)
        Me.lbMemoDatum.Name = "lbMemoDatum"
        Me.lbMemoDatum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbMemoDatum.Size = New System.Drawing.Size(77, 13)
        Me.lbMemoDatum.TabIndex = 32
        Me.lbMemoDatum.Text = "&Memodatum"
        '
        'lbDatumKontrole
        '
        Me.lbDatumKontrole.BackColor = System.Drawing.SystemColors.Control
        Me.lbDatumKontrole.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbDatumKontrole.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbDatumKontrole.Location = New System.Drawing.Point(12, 9)
        Me.lbDatumKontrole.Name = "lbDatumKontrole"
        Me.lbDatumKontrole.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbDatumKontrole.Size = New System.Drawing.Size(89, 16)
        Me.lbDatumKontrole.TabIndex = 35
        Me.lbDatumKontrole.Text = "Datu&m kontrole"
        '
        'lbVanTot
        '
        Me.lbVanTot.BackColor = System.Drawing.SystemColors.Control
        Me.lbVanTot.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbVanTot.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbVanTot.Location = New System.Drawing.Point(244, 9)
        Me.lbVanTot.Name = "lbVanTot"
        Me.lbVanTot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbVanTot.Size = New System.Drawing.Size(56, 16)
        Me.lbVanTot.TabIndex = 27
        Me.lbVanTot.Text = "&Van - Tot"
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = true
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(211, 162)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(270, 42)
        Me.lblInOntwikkeling.TabIndex = 88
        Me.lblInOntwikkeling.Text = "In Ontwikkeling"
        '
        'frmBetalingOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 366)
        Me.Controls.Add(Me.lblInOntwikkeling)
        Me.Controls.Add(Me._Selektie_1)
        Me.Controls.Add(Me.cbLeveranciers)
        Me.Controls.Add(Me.chkAfdrukInVenster)
        Me.Controls.Add(Me.cbBank)
        Me.Controls.Add(Me.tbBedrag)
        Me.Controls.Add(Me.mebRekening)
        Me.Controls.Add(Me.CmdEmailNBB)
        Me.Controls.Add(Me.Samenstellen)
        Me.Controls.Add(Me._TekstLijn_2)
        Me.Controls.Add(Me._TekstLijn_3)
        Me.Controls.Add(Me._Selektie_0)
        Me.Controls.Add(Me._Selektie_2)
        Me.Controls.Add(Me.Drukken)
        Me.Controls.Add(Me.cmdSluiten)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblEUR)
        Me.Controls.Add(Me.lblBEF)
        Me.Controls.Add(Me._lbBank_0)
        Me.Controls.Add(Me.lbBedrag)
        Me.Controls.Add(Me.lbReferte)
        Me.Controls.Add(Me.lbMemoDatum)
        Me.Controls.Add(Me.lbDatumKontrole)
        Me.Controls.Add(Me.lbVanTot)
        Me.Name = "frmBetalingOut"
        Me.Text = "frmBetalingOut"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Public WithEvents _Selektie_1 As CheckBox
    Public WithEvents cbLeveranciers As CheckBox
    Public WithEvents chkAfdrukInVenster As CheckBox
    Public WithEvents cbBank As ComboBox
    Public WithEvents tbBedrag As TextBox
    Public WithEvents mebRekening As MaskedTextBox
    Public WithEvents CmdEmailNBB As Button
    Public WithEvents Samenstellen As Button
    Public WithEvents _TekstLijn_2 As TextBox
    Public WithEvents _TekstLijn_3 As TextBox
    Public WithEvents _Selektie_0 As CheckBox
    Public WithEvents _Selektie_2 As CheckBox
    Public WithEvents Drukken As Button
    Public WithEvents cmdSluiten As Button
    Public WithEvents Label3 As Label
    Public WithEvents Label2 As Label
    Public WithEvents lblEUR As Label
    Public WithEvents lblBEF As Label
    Public WithEvents _lbBank_0 As Label
    Public WithEvents lbBedrag As Label
    Public WithEvents lbReferte As Label
    Public WithEvents lbMemoDatum As Label
    Public WithEvents lbDatumKontrole As Label
    Public WithEvents lbVanTot As Label
    Friend WithEvents lblInOntwikkeling As Label
End Class
