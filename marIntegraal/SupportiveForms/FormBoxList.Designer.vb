<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBoxList
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
        Me.LbBoxList = New System.Windows.Forms.ListBox()
        Me.BtnAccept = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LbBoxList
        '
        Me.LbBoxList.BackColor = System.Drawing.SystemColors.Window
        Me.LbBoxList.Cursor = System.Windows.Forms.Cursors.Default
        Me.LbBoxList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LbBoxList.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LbBoxList.Location = New System.Drawing.Point(0, 0)
        Me.LbBoxList.Name = "LbBoxList"
        Me.LbBoxList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LbBoxList.Size = New System.Drawing.Size(262, 174)
        Me.LbBoxList.TabIndex = 1
        '
        'BtnAccept
        '
        Me.BtnAccept.Location = New System.Drawing.Point(97, 12)
        Me.BtnAccept.Name = "BtnAccept"
        Me.BtnAccept.Size = New System.Drawing.Size(75, 23)
        Me.BtnAccept.TabIndex = 2
        Me.BtnAccept.Text = "Ok"
        Me.BtnAccept.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(97, 55)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "Negeren"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FormChooseList
        '
        Me.AcceptButton = Me.BtnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 174)
        Me.Controls.Add(Me.LbBoxList)
        Me.Controls.Add(Me.BtnAccept)
        Me.Controls.Add(Me.BtnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FormChooseList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Choose List"
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents LbBoxList As ListBox
    Friend WithEvents BtnAccept As Button
    Friend WithEvents BtnCancel As Button
End Class
