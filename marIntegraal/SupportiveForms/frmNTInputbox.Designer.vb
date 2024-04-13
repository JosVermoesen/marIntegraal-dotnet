<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ntInputbox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ntInputbox))
        Me.cmdVooruit = New System.Windows.Forms.Button()
        Me.Hernieuw = New System.Windows.Forms.Button()
        Me.cmdAchteruit = New System.Windows.Forms.Button()
        Me.Sluiten = New System.Windows.Forms.Button()
        Me.Ok = New System.Windows.Forms.Button()
        Me.TekstInfo = New System.Windows.Forms.MaskedTextBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdVooruit
        '
        Me.cmdVooruit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdVooruit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdVooruit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdVooruit.Location = New System.Drawing.Point(236, 76)
        Me.cmdVooruit.Name = "cmdVooruit"
        Me.cmdVooruit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdVooruit.Size = New System.Drawing.Size(33, 25)
        Me.cmdVooruit.TabIndex = 12
        Me.cmdVooruit.Text = ">"
        Me.cmdVooruit.UseVisualStyleBackColor = False
        '
        'Hernieuw
        '
        Me.Hernieuw.BackColor = System.Drawing.SystemColors.Control
        Me.Hernieuw.Cursor = System.Windows.Forms.Cursors.Default
        Me.Hernieuw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Hernieuw.Location = New System.Drawing.Point(276, 76)
        Me.Hernieuw.Name = "Hernieuw"
        Me.Hernieuw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Hernieuw.Size = New System.Drawing.Size(97, 25)
        Me.Hernieuw.TabIndex = 13
        Me.Hernieuw.TabStop = False
        Me.Hernieuw.Text = "&Hernieuw"
        Me.Hernieuw.UseVisualStyleBackColor = False
        Me.Hernieuw.Visible = False
        '
        'cmdAchteruit
        '
        Me.cmdAchteruit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAchteruit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAchteruit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAchteruit.Location = New System.Drawing.Point(12, 76)
        Me.cmdAchteruit.Name = "cmdAchteruit"
        Me.cmdAchteruit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAchteruit.Size = New System.Drawing.Size(33, 25)
        Me.cmdAchteruit.TabIndex = 11
        Me.cmdAchteruit.Text = "<"
        Me.cmdAchteruit.UseVisualStyleBackColor = False
        '
        'Sluiten
        '
        Me.Sluiten.BackColor = System.Drawing.SystemColors.Control
        Me.Sluiten.Cursor = System.Windows.Forms.Cursors.Default
        Me.Sluiten.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Sluiten.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Sluiten.Location = New System.Drawing.Point(376, 45)
        Me.Sluiten.Name = "Sluiten"
        Me.Sluiten.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Sluiten.Size = New System.Drawing.Size(81, 25)
        Me.Sluiten.TabIndex = 10
        Me.Sluiten.TabStop = False
        Me.Sluiten.Text = "Negeren"
        Me.Sluiten.UseVisualStyleBackColor = False
        '
        'Ok
        '
        Me.Ok.BackColor = System.Drawing.SystemColors.Control
        Me.Ok.Cursor = System.Windows.Forms.Cursors.Default
        Me.Ok.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Ok.Location = New System.Drawing.Point(380, 44)
        Me.Ok.Name = "Ok"
        Me.Ok.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Ok.Size = New System.Drawing.Size(81, 25)
        Me.Ok.TabIndex = 9
        Me.Ok.TabStop = False
        Me.Ok.Text = "&Ok"
        Me.Ok.UseVisualStyleBackColor = False
        '
        'TekstInfo
        '
        Me.TekstInfo.AllowPromptAsInput = False
        Me.TekstInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TekstInfo.Location = New System.Drawing.Point(12, 44)
        Me.TekstInfo.Name = "TekstInfo"
        Me.TekstInfo.Size = New System.Drawing.Size(361, 20)
        Me.TekstInfo.TabIndex = 8
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.SystemColors.Control
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInfo.Location = New System.Drawing.Point(50, 76)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInfo.Size = New System.Drawing.Size(177, 25)
        Me.lblInfo.TabIndex = 15
        '
        'ntInputbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Sluiten
        Me.ClientSize = New System.Drawing.Size(469, 133)
        Me.Controls.Add(Me.cmdVooruit)
        Me.Controls.Add(Me.Hernieuw)
        Me.Controls.Add(Me.cmdAchteruit)
        Me.Controls.Add(Me.Ok)
        Me.Controls.Add(Me.TekstInfo)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.Sluiten)
        Me.Name = "ntInputbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmNTInputbox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents cmdVooruit As Button
    Public WithEvents Hernieuw As Button
    Public WithEvents cmdAchteruit As Button
    Public WithEvents Sluiten As Button
    Public WithEvents Ok As Button
    Public WithEvents TekstInfo As MaskedTextBox
    Public WithEvents lblInfo As Label

End Class
