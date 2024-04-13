<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoriekRekeningen
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbPeriodiekeTotalen = New System.Windows.Forms.CheckBox()
        Me.chkAfdrukLiggend = New System.Windows.Forms.CheckBox()
        Me.chkAfdrukInVenster = New System.Windows.Forms.CheckBox()
        Me.Annuleren = New System.Windows.Forms.Button()
        Me.Drukken = New System.Windows.Forms.Button()
        Me._TekstLijn_3 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstLijn_2 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstLijn_1 = New System.Windows.Forms.MaskedTextBox()
        Me.TxtPeriodeVanTot = New System.Windows.Forms.MaskedTextBox()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me._Label1_3 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me.lblInOntwikkeling = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'cbPeriodiekeTotalen
        '
        Me.cbPeriodiekeTotalen.BackColor = System.Drawing.SystemColors.Control
        Me.cbPeriodiekeTotalen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbPeriodiekeTotalen.Checked = true
        Me.cbPeriodiekeTotalen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPeriodiekeTotalen.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbPeriodiekeTotalen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbPeriodiekeTotalen.Location = New System.Drawing.Point(231, 118)
        Me.cbPeriodiekeTotalen.Name = "cbPeriodiekeTotalen"
        Me.cbPeriodiekeTotalen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbPeriodiekeTotalen.Size = New System.Drawing.Size(134, 17)
        Me.cbPeriodiekeTotalen.TabIndex = 25
        Me.cbPeriodiekeTotalen.TabStop = false
        Me.cbPeriodiekeTotalen.Text = "&Periodieke Totalen"
        Me.cbPeriodiekeTotalen.UseVisualStyleBackColor = false
        '
        'chkAfdrukLiggend
        '
        Me.chkAfdrukLiggend.BackColor = System.Drawing.SystemColors.Control
        Me.chkAfdrukLiggend.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAfdrukLiggend.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAfdrukLiggend.Location = New System.Drawing.Point(11, 118)
        Me.chkAfdrukLiggend.Name = "chkAfdrukLiggend"
        Me.chkAfdrukLiggend.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAfdrukLiggend.Size = New System.Drawing.Size(154, 17)
        Me.chkAfdrukLiggend.TabIndex = 24
        Me.chkAfdrukLiggend.TabStop = false
        Me.chkAfdrukLiggend.Text = "&Liggende Printerafdruk"
        Me.chkAfdrukLiggend.UseVisualStyleBackColor = false
        '
        'chkAfdrukInVenster
        '
        Me.chkAfdrukInVenster.BackColor = System.Drawing.SystemColors.Control
        Me.chkAfdrukInVenster.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAfdrukInVenster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAfdrukInVenster.Location = New System.Drawing.Point(11, 98)
        Me.chkAfdrukInVenster.Name = "chkAfdrukInVenster"
        Me.chkAfdrukInVenster.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAfdrukInVenster.Size = New System.Drawing.Size(122, 17)
        Me.chkAfdrukInVenster.TabIndex = 23
        Me.chkAfdrukInVenster.Text = "Afdruk in venster"
        Me.chkAfdrukInVenster.UseVisualStyleBackColor = false
        '
        'Annuleren
        '
        Me.Annuleren.BackColor = System.Drawing.SystemColors.Control
        Me.Annuleren.Cursor = System.Windows.Forms.Cursors.Default
        Me.Annuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Annuleren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Annuleren.Location = New System.Drawing.Point(275, 32)
        Me.Annuleren.Name = "Annuleren"
        Me.Annuleren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Annuleren.Size = New System.Drawing.Size(84, 23)
        Me.Annuleren.TabIndex = 22
        Me.Annuleren.TabStop = false
        Me.Annuleren.Text = "&Sluiten"
        Me.Annuleren.UseVisualStyleBackColor = false
        '
        'Drukken
        '
        Me.Drukken.BackColor = System.Drawing.SystemColors.Control
        Me.Drukken.Cursor = System.Windows.Forms.Cursors.Default
        Me.Drukken.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Drukken.Location = New System.Drawing.Point(275, 6)
        Me.Drukken.Name = "Drukken"
        Me.Drukken.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Drukken.Size = New System.Drawing.Size(84, 23)
        Me.Drukken.TabIndex = 17
        Me.Drukken.Text = "Af&drukken"
        Me.Drukken.UseVisualStyleBackColor = false
        '
        '_TekstLijn_3
        '
        Me._TekstLijn_3.AllowPromptAsInput = false
        Me._TekstLijn_3.BackColor = System.Drawing.Color.White
        Me._TekstLijn_3.Location = New System.Drawing.Point(127, 30)
        Me._TekstLijn_3.Name = "_TekstLijn_3"
        Me._TekstLijn_3.Size = New System.Drawing.Size(105, 20)
        Me._TekstLijn_3.TabIndex = 16
        '
        '_TekstLijn_2
        '
        Me._TekstLijn_2.AllowPromptAsInput = false
        Me._TekstLijn_2.BackColor = System.Drawing.Color.White
        Me._TekstLijn_2.Location = New System.Drawing.Point(7, 30)
        Me._TekstLijn_2.Name = "_TekstLijn_2"
        Me._TekstLijn_2.Size = New System.Drawing.Size(113, 20)
        Me._TekstLijn_2.TabIndex = 14
        '
        '_TekstLijn_1
        '
        Me._TekstLijn_1.AllowPromptAsInput = false
        Me._TekstLijn_1.BackColor = System.Drawing.Color.White
        Me._TekstLijn_1.Location = New System.Drawing.Point(197, 78)
        Me._TekstLijn_1.Mask = "##/##/####"
        Me._TekstLijn_1.Name = "_TekstLijn_1"
        Me._TekstLijn_1.Size = New System.Drawing.Size(85, 20)
        Me._TekstLijn_1.TabIndex = 21
        '
        'TxtPeriodeVanTot
        '
        Me.TxtPeriodeVanTot.AllowPromptAsInput = false
        Me.TxtPeriodeVanTot.BackColor = System.Drawing.Color.White
        Me.TxtPeriodeVanTot.Location = New System.Drawing.Point(11, 78)
        Me.TxtPeriodeVanTot.Mask = "##/##/#### - ##/##/####"
        Me.TxtPeriodeVanTot.Name = "TxtPeriodeVanTot"
        Me.TxtPeriodeVanTot.Size = New System.Drawing.Size(185, 20)
        Me.TxtPeriodeVanTot.TabIndex = 19
        '
        '_Label1_0
        '
        Me._Label1_0.AutoSize = true
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(11, 58)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(92, 15)
        Me._Label1_0.TabIndex = 18
        Me._Label1_0.Text = "Periode Van - &Tot"
        '
        '_Label1_3
        '
        Me._Label1_3.AutoSize = true
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(135, 10)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(25, 15)
        Me._Label1_3.TabIndex = 15
        Me._Label1_3.Text = "&Tot"
        '
        '_Label1_2
        '
        Me._Label1_2.AutoSize = true
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(11, 10)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(86, 15)
        Me._Label1_2.TabIndex = 13
        Me._Label1_2.Text = "&Vanaf Rekening"
        '
        '_Label1_1
        '
        Me._Label1_1.AutoSize = true
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(197, 58)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(56, 15)
        Me._Label1_1.TabIndex = 20
        Me._Label1_1.Text = "Lijstdatu&m"
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = true
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(61, 59)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(270, 42)
        Me.lblInOntwikkeling.TabIndex = 88
        Me.lblInOntwikkeling.Text = "In Ontwikkeling"
        '
        'frmHistoriekRekeningen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 160)
        Me.Controls.Add(Me.lblInOntwikkeling)
        Me.Controls.Add(Me.cbPeriodiekeTotalen)
        Me.Controls.Add(Me.chkAfdrukLiggend)
        Me.Controls.Add(Me.chkAfdrukInVenster)
        Me.Controls.Add(Me.Annuleren)
        Me.Controls.Add(Me.Drukken)
        Me.Controls.Add(Me._TekstLijn_3)
        Me.Controls.Add(Me._TekstLijn_2)
        Me.Controls.Add(Me._TekstLijn_1)
        Me.Controls.Add(Me.TxtPeriodeVanTot)
        Me.Controls.Add(Me._Label1_0)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_1)
        Me.Name = "frmHistoriekRekeningen"
        Me.Text = "frmHistoriekRekeningen"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents cbPeriodiekeTotalen As CheckBox
    Public WithEvents chkAfdrukLiggend As CheckBox
    Public WithEvents chkAfdrukInVenster As CheckBox
    Public WithEvents Annuleren As Button
    Public WithEvents Drukken As Button
    Public WithEvents _TekstLijn_3 As MaskedTextBox
    Public WithEvents _TekstLijn_2 As MaskedTextBox
    Public WithEvents _TekstLijn_1 As MaskedTextBox
    Public WithEvents TxtPeriodeVanTot As MaskedTextBox
    Public WithEvents _Label1_0 As Label
    Public WithEvents _Label1_3 As Label
    Public WithEvents _Label1_2 As Label
    Public WithEvents _Label1_1 As Label
    Friend WithEvents lblInOntwikkeling As Label
End Class
