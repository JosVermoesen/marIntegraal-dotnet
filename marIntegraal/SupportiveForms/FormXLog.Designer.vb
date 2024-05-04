<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormXlog
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
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnHideAndGoBack = New System.Windows.Forms.Button()
        Me.BtnEditLine = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.defaultTabPage = New System.Windows.Forms.TabPage()
        Me.X = New System.Windows.Forms.ListView()
        Me.bijlageTabPage = New System.Windows.Forms.TabPage()
        Me.BtnSelectOnly = New System.Windows.Forms.Button()
        Me.TabControl.SuspendLayout()
        Me.defaultTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(104, 353)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 0
        Me.BtnCancel.TabStop = False
        Me.BtnCancel.Text = "Annuleren"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnHideAndGoBack
        '
        Me.BtnHideAndGoBack.BackColor = System.Drawing.SystemColors.Control
        Me.BtnHideAndGoBack.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnHideAndGoBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnHideAndGoBack.Location = New System.Drawing.Point(4, 353)
        Me.BtnHideAndGoBack.Name = "BtnHideAndGoBack"
        Me.BtnHideAndGoBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnHideAndGoBack.Size = New System.Drawing.Size(94, 22)
        Me.BtnHideAndGoBack.TabIndex = 1
        Me.BtnHideAndGoBack.Text = "Ok"
        Me.BtnHideAndGoBack.UseVisualStyleBackColor = False
        '
        'BtnEditLine
        '
        Me.BtnEditLine.BackColor = System.Drawing.SystemColors.Control
        Me.BtnEditLine.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnEditLine.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnEditLine.Location = New System.Drawing.Point(185, 354)
        Me.BtnEditLine.Name = "BtnEditLine"
        Me.BtnEditLine.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEditLine.Size = New System.Drawing.Size(94, 22)
        Me.BtnEditLine.TabIndex = 1
        Me.BtnEditLine.TabStop = False
        Me.BtnEditLine.Text = "Wijzigen"
        Me.BtnEditLine.UseVisualStyleBackColor = False
        '
        'TabControl
        '
        Me.TabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl.Controls.Add(Me.defaultTabPage)
        Me.TabControl.Controls.Add(Me.bijlageTabPage)
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(487, 343)
        Me.TabControl.TabIndex = 0
        Me.TabControl.TabStop = False
        '
        'defaultTabPage
        '
        Me.defaultTabPage.Controls.Add(Me.X)
        Me.defaultTabPage.Location = New System.Drawing.Point(4, 4)
        Me.defaultTabPage.Name = "defaultTabPage"
        Me.defaultTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.defaultTabPage.Size = New System.Drawing.Size(479, 317)
        Me.defaultTabPage.TabIndex = 0
        Me.defaultTabPage.Text = "Default"
        Me.defaultTabPage.UseVisualStyleBackColor = True
        '
        'X
        '
        Me.X.BackColor = System.Drawing.Color.Gainsboro
        Me.X.Dock = System.Windows.Forms.DockStyle.Fill
        Me.X.ForeColor = System.Drawing.SystemColors.WindowText
        Me.X.FullRowSelect = True
        Me.X.GridLines = True
        Me.X.HideSelection = False
        Me.X.Location = New System.Drawing.Point(3, 3)
        Me.X.MultiSelect = False
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(473, 311)
        Me.X.TabIndex = 0
        Me.X.UseCompatibleStateImageBehavior = False
        Me.X.View = System.Windows.Forms.View.Details
        '
        'bijlageTabPage
        '
        Me.bijlageTabPage.Location = New System.Drawing.Point(4, 4)
        Me.bijlageTabPage.Name = "bijlageTabPage"
        Me.bijlageTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.bijlageTabPage.Size = New System.Drawing.Size(479, 317)
        Me.bijlageTabPage.TabIndex = 1
        Me.bijlageTabPage.Text = "Bijlage"
        Me.bijlageTabPage.UseVisualStyleBackColor = True
        '
        'BtnSelectOnly
        '
        Me.BtnSelectOnly.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSelectOnly.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnSelectOnly.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSelectOnly.Location = New System.Drawing.Point(384, 353)
        Me.BtnSelectOnly.Name = "BtnSelectOnly"
        Me.BtnSelectOnly.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSelectOnly.Size = New System.Drawing.Size(94, 22)
        Me.BtnSelectOnly.TabIndex = 2
        Me.BtnSelectOnly.Text = "Select Only"
        Me.BtnSelectOnly.UseVisualStyleBackColor = False
        Me.BtnSelectOnly.Visible = False
        '
        'FormXlog
        '
        Me.AcceptButton = Me.BtnEditLine
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(490, 385)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.BtnHideAndGoBack)
        Me.Controls.Add(Me.BtnEditLine)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSelectOnly)
        Me.Name = "FormXlog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Log"
        Me.TabControl.ResumeLayout(False)
        Me.defaultTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCancel As Button
    Public WithEvents BtnHideAndGoBack As Button
    Public WithEvents BtnEditLine As Button
    Friend WithEvents TabControl As TabControl
    Friend WithEvents defaultTabPage As TabPage
    Public WithEvents X As ListView
    Friend WithEvents bijlageTabPage As TabPage
    Public WithEvents BtnSelectOnly As Button
End Class
