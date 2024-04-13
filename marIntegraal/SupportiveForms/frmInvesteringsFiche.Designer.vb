<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvesteringsFiche
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
        Me.Ok = New System.Windows.Forms.Button()
        Me.Annuleren = New System.Windows.Forms.Button()
        Me.Versneld = New System.Windows.Forms.CheckBox()
        Me._TekstInfo_6 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstInfo_7 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstInfo_8 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstInfo_5 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstInfo_4 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstInfo_3 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstInfo_2 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstInfo_1 = New System.Windows.Forms.MaskedTextBox()
        Me._TekstInfo_0 = New System.Windows.Forms.MaskedTextBox()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._Label1_4 = New System.Windows.Forms.Label()
        Me._Label1_3 = New System.Windows.Forms.Label()
        Me._Label1_5 = New System.Windows.Forms.Label()
        Me._Label1_6 = New System.Windows.Forms.Label()
        Me._Label1_8 = New System.Windows.Forms.Label()
        Me._Label1_7 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._Label1_10 = New System.Windows.Forms.Label()
        Me.lblInOntwikkeling = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'Ok
        '
        Me.Ok.BackColor = System.Drawing.SystemColors.Control
        Me.Ok.Cursor = System.Windows.Forms.Cursors.Default
        Me.Ok.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Ok.Location = New System.Drawing.Point(298, 95)
        Me.Ok.Name = "Ok"
        Me.Ok.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Ok.Size = New System.Drawing.Size(104, 27)
        Me.Ok.TabIndex = 46
        Me.Ok.TabStop = false
        Me.Ok.Text = "Ok"
        Me.Ok.UseVisualStyleBackColor = false
        '
        'Annuleren
        '
        Me.Annuleren.BackColor = System.Drawing.SystemColors.Control
        Me.Annuleren.Cursor = System.Windows.Forms.Cursors.Default
        Me.Annuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Annuleren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Annuleren.Location = New System.Drawing.Point(298, 127)
        Me.Annuleren.Name = "Annuleren"
        Me.Annuleren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Annuleren.Size = New System.Drawing.Size(104, 28)
        Me.Annuleren.TabIndex = 45
        Me.Annuleren.TabStop = false
        Me.Annuleren.Text = "Sluiten"
        Me.Annuleren.UseVisualStyleBackColor = false
        '
        'Versneld
        '
        Me.Versneld.BackColor = System.Drawing.SystemColors.Control
        Me.Versneld.Cursor = System.Windows.Forms.Cursors.Default
        Me.Versneld.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Versneld.Location = New System.Drawing.Point(10, 167)
        Me.Versneld.Name = "Versneld"
        Me.Versneld.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Versneld.Size = New System.Drawing.Size(141, 16)
        Me.Versneld.TabIndex = 44
        Me.Versneld.Text = "Versneld Afschrijven"
        Me.Versneld.UseVisualStyleBackColor = false
        '
        '_TekstInfo_6
        '
        Me._TekstInfo_6.AllowPromptAsInput = false
        Me._TekstInfo_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me._TekstInfo_6.Enabled = false
        Me._TekstInfo_6.Location = New System.Drawing.Point(254, 25)
        Me._TekstInfo_6.Mask = "##/##/####"
        Me._TekstInfo_6.Name = "_TekstInfo_6"
        Me._TekstInfo_6.Size = New System.Drawing.Size(87, 20)
        Me._TekstInfo_6.TabIndex = 65
        Me._TekstInfo_6.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        '_TekstInfo_7
        '
        Me._TekstInfo_7.AllowPromptAsInput = false
        Me._TekstInfo_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me._TekstInfo_7.Enabled = false
        Me._TekstInfo_7.Location = New System.Drawing.Point(254, 43)
        Me._TekstInfo_7.Name = "_TekstInfo_7"
        Me._TekstInfo_7.Size = New System.Drawing.Size(81, 20)
        Me._TekstInfo_7.TabIndex = 64
        '
        '_TekstInfo_8
        '
        Me._TekstInfo_8.AllowPromptAsInput = false
        Me._TekstInfo_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me._TekstInfo_8.Enabled = false
        Me._TekstInfo_8.Location = New System.Drawing.Point(142, 61)
        Me._TekstInfo_8.Name = "_TekstInfo_8"
        Me._TekstInfo_8.Size = New System.Drawing.Size(81, 20)
        Me._TekstInfo_8.TabIndex = 63
        '
        '_TekstInfo_5
        '
        Me._TekstInfo_5.AllowPromptAsInput = false
        Me._TekstInfo_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me._TekstInfo_5.Location = New System.Drawing.Point(142, 141)
        Me._TekstInfo_5.Name = "_TekstInfo_5"
        Me._TekstInfo_5.Size = New System.Drawing.Size(93, 20)
        Me._TekstInfo_5.TabIndex = 62
        '
        '_TekstInfo_4
        '
        Me._TekstInfo_4.AllowPromptAsInput = false
        Me._TekstInfo_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me._TekstInfo_4.Location = New System.Drawing.Point(142, 123)
        Me._TekstInfo_4.Name = "_TekstInfo_4"
        Me._TekstInfo_4.Size = New System.Drawing.Size(93, 20)
        Me._TekstInfo_4.TabIndex = 61
        '
        '_TekstInfo_3
        '
        Me._TekstInfo_3.AllowPromptAsInput = false
        Me._TekstInfo_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me._TekstInfo_3.Location = New System.Drawing.Point(142, 105)
        Me._TekstInfo_3.Name = "_TekstInfo_3"
        Me._TekstInfo_3.Size = New System.Drawing.Size(93, 20)
        Me._TekstInfo_3.TabIndex = 60
        '
        '_TekstInfo_2
        '
        Me._TekstInfo_2.AllowPromptAsInput = false
        Me._TekstInfo_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me._TekstInfo_2.Enabled = false
        Me._TekstInfo_2.Location = New System.Drawing.Point(142, 79)
        Me._TekstInfo_2.Name = "_TekstInfo_2"
        Me._TekstInfo_2.Size = New System.Drawing.Size(47, 20)
        Me._TekstInfo_2.TabIndex = 59
        '
        '_TekstInfo_1
        '
        Me._TekstInfo_1.AllowPromptAsInput = false
        Me._TekstInfo_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me._TekstInfo_1.Location = New System.Drawing.Point(142, 43)
        Me._TekstInfo_1.Name = "_TekstInfo_1"
        Me._TekstInfo_1.Size = New System.Drawing.Size(81, 20)
        Me._TekstInfo_1.TabIndex = 58
        '
        '_TekstInfo_0
        '
        Me._TekstInfo_0.AllowPromptAsInput = false
        Me._TekstInfo_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me._TekstInfo_0.Location = New System.Drawing.Point(142, 25)
        Me._TekstInfo_0.Mask = "##/##/####"
        Me._TekstInfo_0.Name = "_TekstInfo_0"
        Me._TekstInfo_0.Size = New System.Drawing.Size(87, 20)
        Me._TekstInfo_0.TabIndex = 57
        Me._TekstInfo_0.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(126, 11)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(109, 16)
        Me._Label1_0.TabIndex = 54
        Me._Label1_0.Text = "Huidige bewerking"
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(46, 63)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(96, 16)
        Me._Label1_1.TabIndex = 47
        Me._Label1_1.Text = "Reeds afgeschr."
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(62, 81)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(78, 16)
        Me._Label1_2.TabIndex = 48
        Me._Label1_2.Text = "Lineair n-jaar"
        '
        '_Label1_4
        '
        Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_4.Location = New System.Drawing.Point(102, 27)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_4.Size = New System.Drawing.Size(40, 16)
        Me._Label1_4.TabIndex = 49
        Me._Label1_4.Text = "Datum"
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(258, 11)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(120, 14)
        Me._Label1_3.TabIndex = 55
        Me._Label1_3.Text = "Cumul bewerkingen"
        '
        '_Label1_5
        '
        Me._Label1_5.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_5.Location = New System.Drawing.Point(70, 45)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_5.Size = New System.Drawing.Size(71, 16)
        Me._Label1_5.TabIndex = 50
        Me._Label1_5.Text = "Tot. bedrag"
        '
        '_Label1_6
        '
        Me._Label1_6.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_6.Location = New System.Drawing.Point(10, 107)
        Me._Label1_6.Name = "_Label1_6"
        Me._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_6.Size = New System.Drawing.Size(132, 16)
        Me._Label1_6.TabIndex = 51
        Me._Label1_6.Text = "InvesteringsRekening"
        '
        '_Label1_8
        '
        Me._Label1_8.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_8.Location = New System.Drawing.Point(10, 125)
        Me._Label1_8.Name = "_Label1_8"
        Me._Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_8.Size = New System.Drawing.Size(132, 16)
        Me._Label1_8.TabIndex = 52
        Me._Label1_8.Text = "AfschrijvingsRekening"
        '
        '_Label1_7
        '
        Me._Label1_7.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_7.Location = New System.Drawing.Point(198, 81)
        Me._Label1_7.Name = "_Label1_7"
        Me._Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_7.Size = New System.Drawing.Size(32, 16)
        Me._Label1_7.TabIndex = 56
        Me._Label1_7.Text = "jaar"
        '
        '_Label1_10
        '
        Me._Label1_10.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_10.Location = New System.Drawing.Point(10, 143)
        Me._Label1_10.Name = "_Label1_10"
        Me._Label1_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_10.Size = New System.Drawing.Size(132, 16)
        Me._Label1_10.TabIndex = 53
        Me._Label1_10.Text = "AfschrijfKostRekening"
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = true
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(74, 76)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(270, 42)
        Me.lblInOntwikkeling.TabIndex = 88
        Me.lblInOntwikkeling.Text = "In Ontwikkeling"
        '
        'frmInvesteringsFiche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 194)
        Me.Controls.Add(Me.lblInOntwikkeling)
        Me.Controls.Add(Me.Ok)
        Me.Controls.Add(Me.Annuleren)
        Me.Controls.Add(Me.Versneld)
        Me.Controls.Add(Me._TekstInfo_6)
        Me.Controls.Add(Me._TekstInfo_7)
        Me.Controls.Add(Me._TekstInfo_8)
        Me.Controls.Add(Me._TekstInfo_5)
        Me.Controls.Add(Me._TekstInfo_4)
        Me.Controls.Add(Me._TekstInfo_3)
        Me.Controls.Add(Me._TekstInfo_2)
        Me.Controls.Add(Me._TekstInfo_1)
        Me.Controls.Add(Me._TekstInfo_0)
        Me.Controls.Add(Me._Label1_0)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_4)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me._Label1_5)
        Me.Controls.Add(Me._Label1_6)
        Me.Controls.Add(Me._Label1_8)
        Me.Controls.Add(Me._Label1_7)
        Me.Controls.Add(Me._Label1_10)
        Me.Name = "frmInvesteringsFiche"
        Me.Text = "frmInvesteringsFiche"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Public WithEvents Ok As Button
    Public WithEvents Annuleren As Button
    Public WithEvents Versneld As CheckBox
    Public WithEvents _TekstInfo_6 As MaskedTextBox
    Public WithEvents _TekstInfo_7 As MaskedTextBox
    Public WithEvents _TekstInfo_8 As MaskedTextBox
    Public WithEvents _TekstInfo_5 As MaskedTextBox
    Public WithEvents _TekstInfo_4 As MaskedTextBox
    Public WithEvents _TekstInfo_3 As MaskedTextBox
    Public WithEvents _TekstInfo_2 As MaskedTextBox
    Public WithEvents _TekstInfo_1 As MaskedTextBox
    Public WithEvents _TekstInfo_0 As MaskedTextBox
    Public WithEvents _Label1_0 As Label
    Public WithEvents _Label1_1 As Label
    Public WithEvents _Label1_2 As Label
    Public WithEvents _Label1_4 As Label
    Public WithEvents _Label1_3 As Label
    Public WithEvents _Label1_5 As Label
    Public WithEvents _Label1_6 As Label
    Public WithEvents _Label1_8 As Label
    Public WithEvents _Label1_7 As Label
    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents _Label1_10 As Label
    Friend WithEvents lblInOntwikkeling As Label
End Class
