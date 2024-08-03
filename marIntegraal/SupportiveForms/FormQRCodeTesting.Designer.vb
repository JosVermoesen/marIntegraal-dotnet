<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQRCodeTesting
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
        Me.lblTextContent = New System.Windows.Forms.Label()
        Me.lblQRImageContent = New System.Windows.Forms.Label()
        Me.TbQRCode = New System.Windows.Forms.TextBox()
        Me.BtnDemoText = New System.Windows.Forms.Button()
        Me.BtnQRGenerate = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Pic = New System.Windows.Forms.PictureBox()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTextContent
        '
        Me.lblTextContent.AutoSize = True
        Me.lblTextContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextContent.Location = New System.Drawing.Point(21, 19)
        Me.lblTextContent.Name = "lblTextContent"
        Me.lblTextContent.Size = New System.Drawing.Size(149, 29)
        Me.lblTextContent.TabIndex = 0
        Me.lblTextContent.Text = "Text Content"
        '
        'lblQRImageContent
        '
        Me.lblQRImageContent.AutoSize = True
        Me.lblQRImageContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQRImageContent.Location = New System.Drawing.Point(354, 19)
        Me.lblQRImageContent.Name = "lblQRImageContent"
        Me.lblQRImageContent.Size = New System.Drawing.Size(187, 29)
        Me.lblQRImageContent.TabIndex = 1
        Me.lblQRImageContent.Text = "QR Code Image"
        '
        'TbQRCode
        '
        Me.TbQRCode.Location = New System.Drawing.Point(21, 61)
        Me.TbQRCode.Multiline = True
        Me.TbQRCode.Name = "TbQRCode"
        Me.TbQRCode.Size = New System.Drawing.Size(307, 314)
        Me.TbQRCode.TabIndex = 2
        '
        'BtnDemoText
        '
        Me.BtnDemoText.Location = New System.Drawing.Point(21, 381)
        Me.BtnDemoText.Name = "BtnDemoText"
        Me.BtnDemoText.Size = New System.Drawing.Size(106, 23)
        Me.BtnDemoText.TabIndex = 3
        Me.BtnDemoText.Text = "Demo Text"
        Me.BtnDemoText.UseVisualStyleBackColor = True
        '
        'BtnQRGenerate
        '
        Me.BtnQRGenerate.Location = New System.Drawing.Point(133, 381)
        Me.BtnQRGenerate.Name = "BtnQRGenerate"
        Me.BtnQRGenerate.Size = New System.Drawing.Size(106, 23)
        Me.BtnQRGenerate.TabIndex = 4
        Me.BtnQRGenerate.Text = "Generate QR Code"
        Me.BtnQRGenerate.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(253, 381)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Pic
        '
        Me.Pic.Location = New System.Drawing.Point(349, 61)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(343, 314)
        Me.Pic.TabIndex = 6
        Me.Pic.TabStop = False
        '
        'FormQRCodeTesting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(711, 412)
        Me.Controls.Add(Me.Pic)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnQRGenerate)
        Me.Controls.Add(Me.BtnDemoText)
        Me.Controls.Add(Me.TbQRCode)
        Me.Controls.Add(Me.lblQRImageContent)
        Me.Controls.Add(Me.lblTextContent)
        Me.Name = "FormQRCodeTesting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormQRCodeTesting"
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTextContent As Label
    Friend WithEvents lblQRImageContent As Label
    Friend WithEvents TbQRCode As TextBox
    Friend WithEvents BtnDemoText As Button
    Friend WithEvents BtnQRGenerate As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Pic As PictureBox
End Class
