<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTopDown
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
        Me.components = New System.ComponentModel.Container()
        Me._TekstLijn_4 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._obBoekjaar_3 = New System.Windows.Forms.RadioButton()
        Me._obBoekjaar_2 = New System.Windows.Forms.RadioButton()
        Me._obBoekjaar_1 = New System.Windows.Forms.RadioButton()
        Me._obBoekjaar_0 = New System.Windows.Forms.RadioButton()
        Me._chkSelektie_0 = New System.Windows.Forms.CheckBox()
        Me._chkSelektie_1 = New System.Windows.Forms.CheckBox()
        Me._chkSelektie_2 = New System.Windows.Forms.CheckBox()
        Me.chkAfdrukLiggend = New System.Windows.Forms.CheckBox()
        Me.chkAfdrukInVenster = New System.Windows.Forms.CheckBox()
        Me.ChkAfpunten = New System.Windows.Forms.CheckBox()
        Me._TekstLijn_0 = New System.Windows.Forms.TextBox()
        Me._TekstLijn_1 = New System.Windows.Forms.TextBox()
        Me._TekstLijn_2 = New System.Windows.Forms.TextBox()
        Me._TekstLijn_3 = New System.Windows.Forms.TextBox()
        Me.Drukken = New System.Windows.Forms.Button()
        Me.Annuleren = New System.Windows.Forms.Button()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._Label1_3 = New System.Windows.Forms.Label()
        Me.lblInOntwikkeling = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        '_TekstLijn_4
        '
        Me._TekstLijn_4.AcceptsReturn = true
        Me._TekstLijn_4.BackColor = System.Drawing.Color.White
        Me._TekstLijn_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstLijn_4.Enabled = false
        Me._TekstLijn_4.ForeColor = System.Drawing.Color.Black
        Me._TekstLijn_4.Location = New System.Drawing.Point(136, 169)
        Me._TekstLijn_4.MaxLength = 0
        Me._TekstLijn_4.Name = "_TekstLijn_4"
        Me._TekstLijn_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstLijn_4.Size = New System.Drawing.Size(288, 20)
        Me._TekstLijn_4.TabIndex = 41
        '
        '_obBoekjaar_3
        '
        Me._obBoekjaar_3.BackColor = System.Drawing.SystemColors.Control
        Me._obBoekjaar_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._obBoekjaar_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obBoekjaar_3.Location = New System.Drawing.Point(12, 177)
        Me._obBoekjaar_3.Name = "_obBoekjaar_3"
        Me._obBoekjaar_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obBoekjaar_3.Size = New System.Drawing.Size(113, 13)
        Me._obBoekjaar_3.TabIndex = 40
        Me._obBoekjaar_3.TabStop = true
        Me._obBoekjaar_3.Text = "Actieve periode"
        Me._obBoekjaar_3.UseVisualStyleBackColor = false
        '
        '_obBoekjaar_2
        '
        Me._obBoekjaar_2.BackColor = System.Drawing.SystemColors.Control
        Me._obBoekjaar_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._obBoekjaar_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obBoekjaar_2.Location = New System.Drawing.Point(12, 145)
        Me._obBoekjaar_2.Name = "_obBoekjaar_2"
        Me._obBoekjaar_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obBoekjaar_2.Size = New System.Drawing.Size(161, 13)
        Me._obBoekjaar_2.TabIndex = 39
        Me._obBoekjaar_2.TabStop = true
        Me._obBoekjaar_2.Text = "2 hoogste boekjaren"
        Me._obBoekjaar_2.UseVisualStyleBackColor = false
        '
        '_obBoekjaar_1
        '
        Me._obBoekjaar_1.BackColor = System.Drawing.SystemColors.Control
        Me._obBoekjaar_1.Checked = true
        Me._obBoekjaar_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._obBoekjaar_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obBoekjaar_1.Location = New System.Drawing.Point(12, 129)
        Me._obBoekjaar_1.Name = "_obBoekjaar_1"
        Me._obBoekjaar_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obBoekjaar_1.Size = New System.Drawing.Size(117, 13)
        Me._obBoekjaar_1.TabIndex = 38
        Me._obBoekjaar_1.TabStop = true
        Me._obBoekjaar_1.Text = "Huidig Boekjaar"
        Me._obBoekjaar_1.UseVisualStyleBackColor = false
        '
        '_obBoekjaar_0
        '
        Me._obBoekjaar_0.BackColor = System.Drawing.SystemColors.Control
        Me._obBoekjaar_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._obBoekjaar_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obBoekjaar_0.Location = New System.Drawing.Point(12, 113)
        Me._obBoekjaar_0.Name = "_obBoekjaar_0"
        Me._obBoekjaar_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obBoekjaar_0.Size = New System.Drawing.Size(81, 13)
        Me._obBoekjaar_0.TabIndex = 37
        Me._obBoekjaar_0.TabStop = true
        Me._obBoekjaar_0.Text = "Alle jaren"
        Me._obBoekjaar_0.UseVisualStyleBackColor = false
        '
        '_chkSelektie_0
        '
        Me._chkSelektie_0.BackColor = System.Drawing.SystemColors.Control
        Me._chkSelektie_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkSelektie_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkSelektie_0.Location = New System.Drawing.Point(14, 55)
        Me._chkSelektie_0.Name = "_chkSelektie_0"
        Me._chkSelektie_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkSelektie_0.Size = New System.Drawing.Size(195, 16)
        Me._chkSelektie_0.TabIndex = 36
        Me._chkSelektie_0.Text = "&TableDefOnt met scheidingstekens"
        Me._chkSelektie_0.UseVisualStyleBackColor = false
        '
        '_chkSelektie_1
        '
        Me._chkSelektie_1.BackColor = System.Drawing.SystemColors.Control
        Me._chkSelektie_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkSelektie_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkSelektie_1.Location = New System.Drawing.Point(14, 73)
        Me._chkSelektie_1.Name = "_chkSelektie_1"
        Me._chkSelektie_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkSelektie_1.Size = New System.Drawing.Size(155, 16)
        Me._chkSelektie_1.TabIndex = 35
        Me._chkSelektie_1.Text = "&Topdown"
        Me._chkSelektie_1.UseVisualStyleBackColor = false
        '
        '_chkSelektie_2
        '
        Me._chkSelektie_2.BackColor = System.Drawing.SystemColors.Control
        Me._chkSelektie_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkSelektie_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkSelektie_2.Location = New System.Drawing.Point(14, 91)
        Me._chkSelektie_2.Name = "_chkSelektie_2"
        Me._chkSelektie_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkSelektie_2.Size = New System.Drawing.Size(155, 16)
        Me._chkSelektie_2.TabIndex = 34
        Me._chkSelektie_2.Text = "&Commissie i.p.v. omzet"
        Me._chkSelektie_2.UseVisualStyleBackColor = false
        Me._chkSelektie_2.Visible = false
        '
        'chkAfdrukLiggend
        '
        Me.chkAfdrukLiggend.BackColor = System.Drawing.SystemColors.Control
        Me.chkAfdrukLiggend.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAfdrukLiggend.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAfdrukLiggend.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAfdrukLiggend.Location = New System.Drawing.Point(272, 147)
        Me.chkAfdrukLiggend.Name = "chkAfdrukLiggend"
        Me.chkAfdrukLiggend.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAfdrukLiggend.Size = New System.Drawing.Size(154, 17)
        Me.chkAfdrukLiggend.TabIndex = 33
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
        Me.chkAfdrukInVenster.Location = New System.Drawing.Point(304, 129)
        Me.chkAfdrukInVenster.Name = "chkAfdrukInVenster"
        Me.chkAfdrukInVenster.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAfdrukInVenster.Size = New System.Drawing.Size(122, 17)
        Me.chkAfdrukInVenster.TabIndex = 32
        Me.chkAfdrukInVenster.Text = "Afdruk in venster"
        Me.chkAfdrukInVenster.UseVisualStyleBackColor = false
        '
        'ChkAfpunten
        '
        Me.ChkAfpunten.BackColor = System.Drawing.SystemColors.Control
        Me.ChkAfpunten.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkAfpunten.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkAfpunten.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkAfpunten.Location = New System.Drawing.Point(344, 113)
        Me.ChkAfpunten.Name = "ChkAfpunten"
        Me.ChkAfpunten.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkAfpunten.Size = New System.Drawing.Size(81, 17)
        Me.ChkAfpunten.TabIndex = 31
        Me.ChkAfpunten.Text = "&Afpunten"
        Me.ChkAfpunten.UseVisualStyleBackColor = false
        '
        '_TekstLijn_0
        '
        Me._TekstLijn_0.AcceptsReturn = true
        Me._TekstLijn_0.BackColor = System.Drawing.Color.White
        Me._TekstLijn_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstLijn_0.ForeColor = System.Drawing.Color.Black
        Me._TekstLijn_0.Location = New System.Drawing.Point(12, 25)
        Me._TekstLijn_0.MaxLength = 0
        Me._TekstLijn_0.Name = "_TekstLijn_0"
        Me._TekstLijn_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstLijn_0.Size = New System.Drawing.Size(288, 20)
        Me._TekstLijn_0.TabIndex = 21
        '
        '_TekstLijn_1
        '
        Me._TekstLijn_1.AcceptsReturn = true
        Me._TekstLijn_1.BackColor = System.Drawing.Color.White
        Me._TekstLijn_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstLijn_1.ForeColor = System.Drawing.Color.Black
        Me._TekstLijn_1.Location = New System.Drawing.Point(336, 25)
        Me._TekstLijn_1.MaxLength = 0
        Me._TekstLijn_1.Name = "_TekstLijn_1"
        Me._TekstLijn_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstLijn_1.Size = New System.Drawing.Size(84, 20)
        Me._TekstLijn_1.TabIndex = 22
        '
        '_TekstLijn_2
        '
        Me._TekstLijn_2.AcceptsReturn = true
        Me._TekstLijn_2.BackColor = System.Drawing.Color.White
        Me._TekstLijn_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstLijn_2.ForeColor = System.Drawing.Color.Black
        Me._TekstLijn_2.Location = New System.Drawing.Point(224, 77)
        Me._TekstLijn_2.MaxLength = 0
        Me._TekstLijn_2.Name = "_TekstLijn_2"
        Me._TekstLijn_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstLijn_2.Size = New System.Drawing.Size(107, 20)
        Me._TekstLijn_2.TabIndex = 23
        '
        '_TekstLijn_3
        '
        Me._TekstLijn_3.AcceptsReturn = true
        Me._TekstLijn_3.BackColor = System.Drawing.Color.White
        Me._TekstLijn_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstLijn_3.ForeColor = System.Drawing.Color.Black
        Me._TekstLijn_3.Location = New System.Drawing.Point(224, 97)
        Me._TekstLijn_3.MaxLength = 0
        Me._TekstLijn_3.Name = "_TekstLijn_3"
        Me._TekstLijn_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstLijn_3.Size = New System.Drawing.Size(107, 20)
        Me._TekstLijn_3.TabIndex = 24
        '
        'Drukken
        '
        Me.Drukken.BackColor = System.Drawing.SystemColors.Control
        Me.Drukken.Cursor = System.Windows.Forms.Cursors.Default
        Me.Drukken.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Drukken.Location = New System.Drawing.Point(340, 57)
        Me.Drukken.Name = "Drukken"
        Me.Drukken.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Drukken.Size = New System.Drawing.Size(85, 25)
        Me.Drukken.TabIndex = 25
        Me.Drukken.Text = "Af&drukken"
        Me.Drukken.UseVisualStyleBackColor = false
        '
        'Annuleren
        '
        Me.Annuleren.BackColor = System.Drawing.SystemColors.Control
        Me.Annuleren.Cursor = System.Windows.Forms.Cursors.Default
        Me.Annuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Annuleren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Annuleren.Location = New System.Drawing.Point(340, 85)
        Me.Annuleren.Name = "Annuleren"
        Me.Annuleren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Annuleren.Size = New System.Drawing.Size(85, 25)
        Me.Annuleren.TabIndex = 26
        Me.Annuleren.TabStop = false
        Me.Annuleren.Text = "&Sluiten"
        Me.Annuleren.UseVisualStyleBackColor = false
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(16, 11)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(64, 14)
        Me._Label1_0.TabIndex = 27
        Me._Label1_0.Text = "&SubTitel"
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(336, 11)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(85, 14)
        Me._Label1_1.TabIndex = 28
        Me._Label1_1.Text = "D&atum"
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(226, 59)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(32, 16)
        Me._Label1_2.TabIndex = 29
        Me._Label1_2.Text = "Van"
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(262, 59)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(32, 16)
        Me._Label1_3.TabIndex = 30
        Me._Label1_3.Text = "Tot"
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = true
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(84, 81)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(270, 42)
        Me.lblInOntwikkeling.TabIndex = 88
        Me.lblInOntwikkeling.Text = "In Ontwikkeling"
        '
        'frmTopDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 205)
        Me.Controls.Add(Me.lblInOntwikkeling)
        Me.Controls.Add(Me._TekstLijn_4)
        Me.Controls.Add(Me._obBoekjaar_3)
        Me.Controls.Add(Me._obBoekjaar_2)
        Me.Controls.Add(Me._obBoekjaar_1)
        Me.Controls.Add(Me._obBoekjaar_0)
        Me.Controls.Add(Me._chkSelektie_0)
        Me.Controls.Add(Me._chkSelektie_1)
        Me.Controls.Add(Me._chkSelektie_2)
        Me.Controls.Add(Me.chkAfdrukLiggend)
        Me.Controls.Add(Me.chkAfdrukInVenster)
        Me.Controls.Add(Me.ChkAfpunten)
        Me.Controls.Add(Me._TekstLijn_0)
        Me.Controls.Add(Me._TekstLijn_1)
        Me.Controls.Add(Me._TekstLijn_2)
        Me.Controls.Add(Me._TekstLijn_3)
        Me.Controls.Add(Me.Drukken)
        Me.Controls.Add(Me.Annuleren)
        Me.Controls.Add(Me._Label1_0)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_3)
        Me.Name = "frmTopDown"
        Me.Text = "frmTopDown"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Public WithEvents _TekstLijn_4 As TextBox
    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents _obBoekjaar_3 As RadioButton
    Public WithEvents _obBoekjaar_2 As RadioButton
    Public WithEvents _obBoekjaar_1 As RadioButton
    Public WithEvents _obBoekjaar_0 As RadioButton
    Public WithEvents _chkSelektie_0 As CheckBox
    Public WithEvents _chkSelektie_1 As CheckBox
    Public WithEvents _chkSelektie_2 As CheckBox
    Public WithEvents chkAfdrukLiggend As CheckBox
    Public WithEvents chkAfdrukInVenster As CheckBox
    Public WithEvents ChkAfpunten As CheckBox
    Public WithEvents _TekstLijn_0 As TextBox
    Public WithEvents _TekstLijn_1 As TextBox
    Public WithEvents _TekstLijn_2 As TextBox
    Public WithEvents _TekstLijn_3 As TextBox
    Public WithEvents Drukken As Button
    Public WithEvents Annuleren As Button
    Public WithEvents _Label1_0 As Label
    Public WithEvents _Label1_1 As Label
    Public WithEvents _Label1_2 As Label
    Public WithEvents _Label1_3 As Label
    Friend WithEvents lblInOntwikkeling As Label
End Class
