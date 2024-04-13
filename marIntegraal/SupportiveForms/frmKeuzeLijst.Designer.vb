<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KeuzeVSF
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
        Me.NTBoxLijst = New System.Windows.Forms.ListBox()
        Me.okButton = New System.Windows.Forms.Button()
        Me.negerenButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NTBoxLijst
        '
        Me.NTBoxLijst.BackColor = System.Drawing.SystemColors.Window
        Me.NTBoxLijst.Cursor = System.Windows.Forms.Cursors.Default
        Me.NTBoxLijst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NTBoxLijst.ForeColor = System.Drawing.SystemColors.WindowText
        Me.NTBoxLijst.Location = New System.Drawing.Point(0, 0)
        Me.NTBoxLijst.Name = "NTBoxLijst"
        Me.NTBoxLijst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NTBoxLijst.Size = New System.Drawing.Size(262, 174)
        Me.NTBoxLijst.TabIndex = 1
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(97, 12)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 23)
        Me.okButton.TabIndex = 2
        Me.okButton.Text = "Ok"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'negerenButton
        '
        Me.negerenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.negerenButton.Location = New System.Drawing.Point(97, 55)
        Me.negerenButton.Name = "negerenButton"
        Me.negerenButton.Size = New System.Drawing.Size(75, 23)
        Me.negerenButton.TabIndex = 3
        Me.negerenButton.Text = "Negeren"
        Me.negerenButton.UseVisualStyleBackColor = True
        '
        'KeuzeVSF
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 174)
        Me.Controls.Add(Me.NTBoxLijst)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.negerenButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "KeuzeVSF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmKeuzeLijst"
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents NTBoxLijst As ListBox
    Friend WithEvents okButton As Button
    Friend WithEvents negerenButton As Button
End Class
