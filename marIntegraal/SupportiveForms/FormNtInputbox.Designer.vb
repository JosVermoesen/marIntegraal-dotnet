<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNtInputBox
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
        Me.BtnForward = New System.Windows.Forms.Button()
        Me.BtnReNew = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnAccept = New System.Windows.Forms.Button()
        Me.TbTextLine = New System.Windows.Forms.MaskedTextBox()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.LabelToolStrip = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnForward
        '
        Me.BtnForward.BackColor = System.Drawing.SystemColors.Control
        Me.BtnForward.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnForward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnForward.Location = New System.Drawing.Point(236, 44)
        Me.BtnForward.Name = "BtnForward"
        Me.BtnForward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnForward.Size = New System.Drawing.Size(33, 25)
        Me.BtnForward.TabIndex = 12
        Me.BtnForward.Text = ">"
        Me.BtnForward.UseVisualStyleBackColor = False
        '
        'BtnReNew
        '
        Me.BtnReNew.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReNew.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnReNew.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnReNew.Location = New System.Drawing.Point(276, 44)
        Me.BtnReNew.Name = "BtnReNew"
        Me.BtnReNew.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnReNew.Size = New System.Drawing.Size(97, 25)
        Me.BtnReNew.TabIndex = 13
        Me.BtnReNew.TabStop = False
        Me.BtnReNew.Text = "&Hernieuw"
        Me.BtnReNew.UseVisualStyleBackColor = False
        Me.BtnReNew.Visible = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnBack.Location = New System.Drawing.Point(12, 44)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnBack.Size = New System.Drawing.Size(33, 25)
        Me.BtnBack.TabIndex = 11
        Me.BtnBack.Text = "<"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCancel.Location = New System.Drawing.Point(377, 13)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCancel.Size = New System.Drawing.Size(81, 26)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.TabStop = False
        Me.BtnCancel.Text = "Negeren"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnAccept
        '
        Me.BtnAccept.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAccept.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnAccept.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnAccept.Location = New System.Drawing.Point(377, 12)
        Me.BtnAccept.Name = "BtnAccept"
        Me.BtnAccept.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAccept.Size = New System.Drawing.Size(81, 26)
        Me.BtnAccept.TabIndex = 9
        Me.BtnAccept.TabStop = False
        Me.BtnAccept.Text = "&Ok"
        Me.BtnAccept.UseVisualStyleBackColor = False
        '
        'TbTextLine
        '
        Me.TbTextLine.AllowPromptAsInput = False
        Me.TbTextLine.BackColor = System.Drawing.Color.White
        Me.TbTextLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTextLine.Location = New System.Drawing.Point(12, 12)
        Me.TbTextLine.Name = "TbTextLine"
        Me.TbTextLine.Size = New System.Drawing.Size(361, 26)
        Me.TbTextLine.TabIndex = 8
        '
        'LabelInfo
        '
        Me.LabelInfo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelInfo.Location = New System.Drawing.Point(50, 44)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelInfo.Size = New System.Drawing.Size(177, 25)
        Me.LabelInfo.TabIndex = 15
        '
        'LabelToolStrip
        '
        Me.LabelToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelToolStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelToolStrip.Location = New System.Drawing.Point(0, 84)
        Me.LabelToolStrip.Name = "LabelToolStrip"
        Me.LabelToolStrip.Size = New System.Drawing.Size(470, 20)
        Me.LabelToolStrip.TabIndex = 16
        Me.LabelToolStrip.Text = "Label1"
        '
        'FormNtInputBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(470, 104)
        Me.Controls.Add(Me.LabelToolStrip)
        Me.Controls.Add(Me.BtnForward)
        Me.Controls.Add(Me.BtnReNew)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnAccept)
        Me.Controls.Add(Me.TbTextLine)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.BtnCancel)
        Me.Name = "FormNtInputBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmntInputbox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents BtnForward As Button
    Public WithEvents BtnReNew As Button
    Public WithEvents BtnBack As Button
    Public WithEvents BtnCancel As Button
    Public WithEvents BtnAccept As Button
    Public WithEvents TbTextLine As MaskedTextBox
    Public WithEvents LabelInfo As Label
    Friend WithEvents LabelToolStrip As Label
End Class
