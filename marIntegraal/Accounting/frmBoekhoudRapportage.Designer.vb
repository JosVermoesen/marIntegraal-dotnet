<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoekhoudRapportage
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
        Me.Annuleren = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Keuzelijst = New System.Windows.Forms.ComboBox()
        Me.Drukken = New System.Windows.Forms.Button()
        Me._TekstLijn_1 = New System.Windows.Forms.TextBox()
        Me.LabelMemo = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me.lblInOntwikkeling = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'Annuleren
        '
        Me.Annuleren.BackColor = System.Drawing.SystemColors.Control
        Me.Annuleren.Cursor = System.Windows.Forms.Cursors.Default
        Me.Annuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Annuleren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Annuleren.Location = New System.Drawing.Point(320, 12)
        Me.Annuleren.Name = "Annuleren"
        Me.Annuleren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Annuleren.Size = New System.Drawing.Size(94, 20)
        Me.Annuleren.TabIndex = 9
        Me.Annuleren.TabStop = false
        Me.Annuleren.Text = "Sluiten"
        Me.Annuleren.UseVisualStyleBackColor = false
        '
        'Keuzelijst
        '
        Me.Keuzelijst.BackColor = System.Drawing.Color.White
        Me.Keuzelijst.Cursor = System.Windows.Forms.Cursors.Default
        Me.Keuzelijst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Keuzelijst.ForeColor = System.Drawing.Color.Black
        Me.Keuzelijst.Location = New System.Drawing.Point(16, 40)
        Me.Keuzelijst.Name = "Keuzelijst"
        Me.Keuzelijst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Keuzelijst.Size = New System.Drawing.Size(397, 21)
        Me.Keuzelijst.TabIndex = 7
        '
        'Drukken
        '
        Me.Drukken.BackColor = System.Drawing.SystemColors.Control
        Me.Drukken.Cursor = System.Windows.Forms.Cursors.Default
        Me.Drukken.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Drukken.Location = New System.Drawing.Point(224, 12)
        Me.Drukken.Name = "Drukken"
        Me.Drukken.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Drukken.Size = New System.Drawing.Size(94, 20)
        Me.Drukken.TabIndex = 8
        Me.Drukken.Text = "Af&drukken"
        Me.Drukken.UseVisualStyleBackColor = false
        '
        '_TekstLijn_1
        '
        Me._TekstLijn_1.AcceptsReturn = true
        Me._TekstLijn_1.BackColor = System.Drawing.Color.White
        Me._TekstLijn_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstLijn_1.ForeColor = System.Drawing.Color.Black
        Me._TekstLijn_1.Location = New System.Drawing.Point(76, 12)
        Me._TekstLijn_1.MaxLength = 0
        Me._TekstLijn_1.Name = "_TekstLijn_1"
        Me._TekstLijn_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstLijn_1.Size = New System.Drawing.Size(120, 20)
        Me._TekstLijn_1.TabIndex = 6
        '
        'LabelMemo
        '
        Me.LabelMemo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelMemo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelMemo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelMemo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelMemo.Location = New System.Drawing.Point(12, 72)
        Me.LabelMemo.Name = "LabelMemo"
        Me.LabelMemo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelMemo.Size = New System.Drawing.Size(401, 141)
        Me.LabelMemo.TabIndex = 11
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(20, 16)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(48, 25)
        Me._Label1_1.TabIndex = 10
        Me._Label1_1.Text = "Datum Drukken"
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = true
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(81, 91)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(270, 42)
        Me.lblInOntwikkeling.TabIndex = 88
        Me.lblInOntwikkeling.Text = "In Ontwikkeling"
        '
        'frmBoekhoudRapportage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 224)
        Me.Controls.Add(Me.lblInOntwikkeling)
        Me.Controls.Add(Me.Annuleren)
        Me.Controls.Add(Me.Keuzelijst)
        Me.Controls.Add(Me.Drukken)
        Me.Controls.Add(Me._TekstLijn_1)
        Me.Controls.Add(Me.LabelMemo)
        Me.Controls.Add(Me._Label1_1)
        Me.Name = "frmBoekhoudRapportage"
        Me.Text = "frmBoekhoudRapportage"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Public WithEvents Annuleren As Button
    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents Keuzelijst As ComboBox
    Public WithEvents Drukken As Button
    Public WithEvents _TekstLijn_1 As TextBox
    Public WithEvents LabelMemo As Label
    Public WithEvents _Label1_1 As Label
    Friend WithEvents lblInOntwikkeling As Label
End Class
