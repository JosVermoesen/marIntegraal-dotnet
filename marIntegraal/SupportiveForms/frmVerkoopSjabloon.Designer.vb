<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerkoopSjabloon
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
        Me._SoortSjabloon_1 = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._SoortSjabloon_0 = New System.Windows.Forms.RadioButton()
        Me.SjabloonLijst = New System.Windows.Forms.ListBox()
        Me.Invoegen = New System.Windows.Forms.Button()
        Me.Wegschrijven = New System.Windows.Forms.Button()
        Me._TekstInfo_0 = New System.Windows.Forms.TextBox()
        Me.Annuleren = New System.Windows.Forms.Button()
        Me.lblInOntwikkeling = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        '_SoortSjabloon_1
        '
        Me._SoortSjabloon_1.BackColor = System.Drawing.SystemColors.Control
        Me._SoortSjabloon_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._SoortSjabloon_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SoortSjabloon_1.Location = New System.Drawing.Point(26, 33)
        Me._SoortSjabloon_1.Name = "_SoortSjabloon_1"
        Me._SoortSjabloon_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._SoortSjabloon_1.Size = New System.Drawing.Size(97, 16)
        Me._SoortSjabloon_1.TabIndex = 13
        Me._SoortSjabloon_1.TabStop = true
        Me._SoortSjabloon_1.Text = "&Klantgericht"
        Me._SoortSjabloon_1.UseVisualStyleBackColor = false
        '
        '_SoortSjabloon_0
        '
        Me._SoortSjabloon_0.BackColor = System.Drawing.SystemColors.Control
        Me._SoortSjabloon_0.Checked = true
        Me._SoortSjabloon_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._SoortSjabloon_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._SoortSjabloon_0.Location = New System.Drawing.Point(26, 13)
        Me._SoortSjabloon_0.Name = "_SoortSjabloon_0"
        Me._SoortSjabloon_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._SoortSjabloon_0.Size = New System.Drawing.Size(85, 16)
        Me._SoortSjabloon_0.TabIndex = 7
        Me._SoortSjabloon_0.TabStop = true
        Me._SoortSjabloon_0.Text = "&Algemeen"
        Me._SoortSjabloon_0.UseVisualStyleBackColor = false
        '
        'SjabloonLijst
        '
        Me.SjabloonLijst.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.SjabloonLijst.Cursor = System.Windows.Forms.Cursors.Default
        Me.SjabloonLijst.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SjabloonLijst.ForeColor = System.Drawing.Color.Black
        Me.SjabloonLijst.ItemHeight = 16
        Me.SjabloonLijst.Location = New System.Drawing.Point(12, 65)
        Me.SjabloonLijst.Name = "SjabloonLijst"
        Me.SjabloonLijst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SjabloonLijst.Size = New System.Drawing.Size(370, 84)
        Me.SjabloonLijst.Sorted = true
        Me.SjabloonLijst.TabIndex = 8
        '
        'Invoegen
        '
        Me.Invoegen.BackColor = System.Drawing.SystemColors.Control
        Me.Invoegen.Cursor = System.Windows.Forms.Cursors.Default
        Me.Invoegen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Invoegen.Location = New System.Drawing.Point(206, 7)
        Me.Invoegen.Name = "Invoegen"
        Me.Invoegen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Invoegen.Size = New System.Drawing.Size(72, 50)
        Me.Invoegen.TabIndex = 10
        Me.Invoegen.Text = "&Invoegen"
        Me.Invoegen.UseVisualStyleBackColor = false
        '
        'Wegschrijven
        '
        Me.Wegschrijven.BackColor = System.Drawing.SystemColors.Control
        Me.Wegschrijven.Cursor = System.Windows.Forms.Cursors.Default
        Me.Wegschrijven.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Wegschrijven.Location = New System.Drawing.Point(282, 9)
        Me.Wegschrijven.Name = "Wegschrijven"
        Me.Wegschrijven.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Wegschrijven.Size = New System.Drawing.Size(94, 24)
        Me.Wegschrijven.TabIndex = 11
        Me.Wegschrijven.Text = "&Wegschrijven"
        Me.Wegschrijven.UseVisualStyleBackColor = false
        '
        '_TekstInfo_0
        '
        Me._TekstInfo_0.AcceptsReturn = true
        Me._TekstInfo_0.BackColor = System.Drawing.Color.White
        Me._TekstInfo_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._TekstInfo_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstInfo_0.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me._TekstInfo_0.ForeColor = System.Drawing.Color.Black
        Me._TekstInfo_0.Location = New System.Drawing.Point(12, 153)
        Me._TekstInfo_0.MaxLength = 0
        Me._TekstInfo_0.Name = "_TekstInfo_0"
        Me._TekstInfo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstInfo_0.Size = New System.Drawing.Size(367, 20)
        Me._TekstInfo_0.TabIndex = 9
        '
        'Annuleren
        '
        Me.Annuleren.BackColor = System.Drawing.SystemColors.Control
        Me.Annuleren.Cursor = System.Windows.Forms.Cursors.Default
        Me.Annuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Annuleren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Annuleren.Location = New System.Drawing.Point(282, 35)
        Me.Annuleren.Name = "Annuleren"
        Me.Annuleren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Annuleren.Size = New System.Drawing.Size(94, 23)
        Me.Annuleren.TabIndex = 12
        Me.Annuleren.TabStop = false
        Me.Annuleren.Text = "&Sluiten"
        Me.Annuleren.UseVisualStyleBackColor = false
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = true
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(63, 63)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(270, 42)
        Me.lblInOntwikkeling.TabIndex = 88
        Me.lblInOntwikkeling.Text = "In Ontwikkeling"
        '
        'frmVerkoopSjabloon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 168)
        Me.Controls.Add(Me.lblInOntwikkeling)
        Me.Controls.Add(Me._SoortSjabloon_1)
        Me.Controls.Add(Me._SoortSjabloon_0)
        Me.Controls.Add(Me.SjabloonLijst)
        Me.Controls.Add(Me.Invoegen)
        Me.Controls.Add(Me.Wegschrijven)
        Me.Controls.Add(Me._TekstInfo_0)
        Me.Controls.Add(Me.Annuleren)
        Me.Name = "frmVerkoopSjabloon"
        Me.Text = "frmVerkoopSjabloon"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Public WithEvents _SoortSjabloon_1 As RadioButton
    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents _SoortSjabloon_0 As RadioButton
    Public WithEvents SjabloonLijst As ListBox
    Public WithEvents Invoegen As Button
    Public WithEvents Wegschrijven As Button
    Public WithEvents _TekstInfo_0 As TextBox
    Public WithEvents Annuleren As Button
    Friend WithEvents lblInOntwikkeling As Label
End Class
