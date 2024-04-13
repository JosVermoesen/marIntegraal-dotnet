<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBasicSheetTemplate
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
        Me.bewerkenButton = New System.Windows.Forms.Button()
        Me.verwijderenButton = New System.Windows.Forms.Button()
        Me.zoekenOpButton = New System.Windows.Forms.Button()
        Me.topButton = New System.Windows.Forms.Button()
        Me.lagerButton = New System.Windows.Forms.Button()
        Me.bodemButton = New System.Windows.Forms.Button()
        Me.hogerButton = New System.Windows.Forms.Button()
        Me.relatiesButton = New System.Windows.Forms.Button()
        Me.minimaliseerButton = New System.Windows.Forms.Button()
        Me.codeTextBox = New System.Windows.Forms.TextBox()
        Me.sorteringComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'bewerkenButton
        '
        Me.bewerkenButton.Enabled = False
        Me.bewerkenButton.Location = New System.Drawing.Point(12, 12)
        Me.bewerkenButton.Name = "bewerkenButton"
        Me.bewerkenButton.Size = New System.Drawing.Size(75, 23)
        Me.bewerkenButton.TabIndex = 0
        Me.bewerkenButton.TabStop = False
        Me.bewerkenButton.Text = "B&ewerken"
        Me.bewerkenButton.UseVisualStyleBackColor = True
        '
        'verwijderenButton
        '
        Me.verwijderenButton.Location = New System.Drawing.Point(12, 66)
        Me.verwijderenButton.Name = "verwijderenButton"
        Me.verwijderenButton.Size = New System.Drawing.Size(75, 23)
        Me.verwijderenButton.TabIndex = 1
        Me.verwijderenButton.TabStop = False
        Me.verwijderenButton.Text = "&Verwijderen"
        Me.verwijderenButton.UseVisualStyleBackColor = True
        '
        'zoekenOpButton
        '
        Me.zoekenOpButton.Location = New System.Drawing.Point(12, 95)
        Me.zoekenOpButton.Name = "zoekenOpButton"
        Me.zoekenOpButton.Size = New System.Drawing.Size(75, 23)
        Me.zoekenOpButton.TabIndex = 2
        Me.zoekenOpButton.TabStop = False
        Me.zoekenOpButton.Text = "&Zoeken op"
        Me.zoekenOpButton.UseVisualStyleBackColor = True
        '
        'topButton
        '
        Me.topButton.Location = New System.Drawing.Point(93, 37)
        Me.topButton.Name = "topButton"
        Me.topButton.Size = New System.Drawing.Size(75, 23)
        Me.topButton.TabIndex = 3
        Me.topButton.TabStop = False
        Me.topButton.Text = "&Eerste"
        Me.topButton.UseVisualStyleBackColor = True
        '
        'lagerButton
        '
        Me.lagerButton.Location = New System.Drawing.Point(174, 66)
        Me.lagerButton.Name = "lagerButton"
        Me.lagerButton.Size = New System.Drawing.Size(75, 23)
        Me.lagerButton.TabIndex = 4
        Me.lagerButton.TabStop = False
        Me.lagerButton.Text = "L&ager"
        Me.lagerButton.UseVisualStyleBackColor = True
        Me.lagerButton.Visible = False
        '
        'bodemButton
        '
        Me.bodemButton.Location = New System.Drawing.Point(93, 66)
        Me.bodemButton.Name = "bodemButton"
        Me.bodemButton.Size = New System.Drawing.Size(75, 23)
        Me.bodemButton.TabIndex = 5
        Me.bodemButton.TabStop = False
        Me.bodemButton.Text = "&Laatste"
        Me.bodemButton.UseVisualStyleBackColor = True
        '
        'hogerButton
        '
        Me.hogerButton.Location = New System.Drawing.Point(174, 37)
        Me.hogerButton.Name = "hogerButton"
        Me.hogerButton.Size = New System.Drawing.Size(75, 23)
        Me.hogerButton.TabIndex = 6
        Me.hogerButton.TabStop = False
        Me.hogerButton.Text = "&Hoger"
        Me.hogerButton.UseVisualStyleBackColor = True
        Me.hogerButton.Visible = False
        '
        'relatiesButton
        '
        Me.relatiesButton.Location = New System.Drawing.Point(280, 37)
        Me.relatiesButton.Name = "relatiesButton"
        Me.relatiesButton.Size = New System.Drawing.Size(75, 23)
        Me.relatiesButton.TabIndex = 7
        Me.relatiesButton.TabStop = False
        Me.relatiesButton.Text = "&Relaties"
        Me.relatiesButton.UseVisualStyleBackColor = True
        '
        'minimaliseerButton
        '
        Me.minimaliseerButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.minimaliseerButton.Location = New System.Drawing.Point(263, 66)
        Me.minimaliseerButton.Name = "minimaliseerButton"
        Me.minimaliseerButton.Size = New System.Drawing.Size(92, 23)
        Me.minimaliseerButton.TabIndex = 8
        Me.minimaliseerButton.TabStop = False
        Me.minimaliseerButton.Text = "Minimaliseren"
        Me.minimaliseerButton.UseVisualStyleBackColor = True
        '
        'codeTextBox
        '
        Me.codeTextBox.Location = New System.Drawing.Point(93, 14)
        Me.codeTextBox.Name = "codeTextBox"
        Me.codeTextBox.Size = New System.Drawing.Size(262, 20)
        Me.codeTextBox.TabIndex = 1
        '
        'sorteringComboBox
        '
        Me.sorteringComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sorteringComboBox.FormattingEnabled = True
        Me.sorteringComboBox.Location = New System.Drawing.Point(93, 95)
        Me.sorteringComboBox.Name = "sorteringComboBox"
        Me.sorteringComboBox.Size = New System.Drawing.Size(262, 21)
        Me.sorteringComboBox.TabIndex = 3
        '
        'frmBasisFiche
        '
        Me.AcceptButton = Me.zoekenOpButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.minimaliseerButton
        Me.ClientSize = New System.Drawing.Size(367, 126)
        Me.ControlBox = False
        Me.Controls.Add(Me.sorteringComboBox)
        Me.Controls.Add(Me.codeTextBox)
        Me.Controls.Add(Me.minimaliseerButton)
        Me.Controls.Add(Me.relatiesButton)
        Me.Controls.Add(Me.hogerButton)
        Me.Controls.Add(Me.bodemButton)
        Me.Controls.Add(Me.lagerButton)
        Me.Controls.Add(Me.topButton)
        Me.Controls.Add(Me.zoekenOpButton)
        Me.Controls.Add(Me.verwijderenButton)
        Me.Controls.Add(Me.bewerkenButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBasisFiche"
        Me.Text = "BasisFiche"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bewerkenButton As Button
    Friend WithEvents verwijderenButton As Button
    Friend WithEvents zoekenOpButton As Button
    Friend WithEvents topButton As Button
    Friend WithEvents lagerButton As Button
    Friend WithEvents bodemButton As Button
    Friend WithEvents hogerButton As Button
    Friend WithEvents relatiesButton As Button
    Friend WithEvents minimaliseerButton As Button
    Friend WithEvents codeTextBox As TextBox
    Friend WithEvents sorteringComboBox As ComboBox
End Class
