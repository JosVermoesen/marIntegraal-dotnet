<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormExternalSettings
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
        Me.TextBoxMarntCloud = New System.Windows.Forms.TextBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.TextBoxMarioCloud = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TextBoxUrlCompany = New System.Windows.Forms.TextBox()
        Me.TextBoxArchiveCloud = New System.Windows.Forms.TextBox()
        Me.LabelMarntCloud = New System.Windows.Forms.Label()
        Me.LabelMarioCloud = New System.Windows.Forms.Label()
        Me.LabelUrl = New System.Windows.Forms.Label()
        Me.LabelArchiveCloud = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxMarntCloud
        '
        Me.TextBoxMarntCloud.AcceptsReturn = True
        Me.TextBoxMarntCloud.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxMarntCloud.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxMarntCloud.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxMarntCloud.Location = New System.Drawing.Point(129, 36)
        Me.TextBoxMarntCloud.MaxLength = 0
        Me.TextBoxMarntCloud.Name = "TextBoxMarntCloud"
        Me.TextBoxMarntCloud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxMarntCloud.Size = New System.Drawing.Size(497, 20)
        Me.TextBoxMarntCloud.TabIndex = 19
        Me.TextBoxMarntCloud.Text = "Text1"
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonClose.Location = New System.Drawing.Point(545, 108)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonClose.Size = New System.Drawing.Size(81, 25)
        Me.ButtonClose.TabIndex = 17
        Me.ButtonClose.Text = "Sluiten"
        Me.ButtonClose.UseVisualStyleBackColor = False
        AddHandler Me.ButtonClose.Click, AddressOf Me.ButtonClose_Click
        '
        'TextBoxMarioCloud
        '
        Me.TextBoxMarioCloud.AcceptsReturn = True
        Me.TextBoxMarioCloud.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxMarioCloud.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxMarioCloud.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxMarioCloud.Location = New System.Drawing.Point(129, 60)
        Me.TextBoxMarioCloud.MaxLength = 0
        Me.TextBoxMarioCloud.Name = "TextBoxMarioCloud"
        Me.TextBoxMarioCloud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxMarioCloud.Size = New System.Drawing.Size(497, 20)
        Me.TextBoxMarioCloud.TabIndex = 15
        Me.TextBoxMarioCloud.Text = "Text1"
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonSave.Location = New System.Drawing.Point(361, 108)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonSave.Size = New System.Drawing.Size(181, 25)
        Me.ButtonSave.TabIndex = 16
        Me.ButtonSave.TabStop = False
        Me.ButtonSave.Text = "Instellingen &bewaren en sluiten"
        Me.ButtonSave.UseVisualStyleBackColor = False
        AddHandler Me.ButtonSave.Click, AddressOf Me.ButtonSave_Click
        '
        'TextBoxUrlCompany
        '
        Me.TextBoxUrlCompany.AcceptsReturn = True
        Me.TextBoxUrlCompany.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxUrlCompany.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxUrlCompany.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxUrlCompany.Location = New System.Drawing.Point(129, 12)
        Me.TextBoxUrlCompany.MaxLength = 0
        Me.TextBoxUrlCompany.Name = "TextBoxUrlCompany"
        Me.TextBoxUrlCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxUrlCompany.Size = New System.Drawing.Size(497, 20)
        Me.TextBoxUrlCompany.TabIndex = 13
        Me.TextBoxUrlCompany.Text = "Text1"
        '
        'TextBoxArchiveCloud
        '
        Me.TextBoxArchiveCloud.AcceptsReturn = True
        Me.TextBoxArchiveCloud.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxArchiveCloud.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxArchiveCloud.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBoxArchiveCloud.Location = New System.Drawing.Point(129, 84)
        Me.TextBoxArchiveCloud.MaxLength = 0
        Me.TextBoxArchiveCloud.Name = "TextBoxArchiveCloud"
        Me.TextBoxArchiveCloud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxArchiveCloud.Size = New System.Drawing.Size(497, 20)
        Me.TextBoxArchiveCloud.TabIndex = 11
        Me.TextBoxArchiveCloud.Text = "Text1"
        '
        'LabelMarntCloud
        '
        Me.LabelMarntCloud.BackColor = System.Drawing.SystemColors.Control
        Me.LabelMarntCloud.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelMarntCloud.Location = New System.Drawing.Point(9, 36)
        Me.LabelMarntCloud.Name = "LabelMarntCloud"
        Me.LabelMarntCloud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelMarntCloud.Size = New System.Drawing.Size(113, 17)
        Me.LabelMarntCloud.TabIndex = 18
        Me.LabelMarntCloud.Text = "MARNT CLOUD"
        '
        'LabelMarioCloud
        '
        Me.LabelMarioCloud.BackColor = System.Drawing.SystemColors.Control
        Me.LabelMarioCloud.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelMarioCloud.Location = New System.Drawing.Point(9, 60)
        Me.LabelMarioCloud.Name = "LabelMarioCloud"
        Me.LabelMarioCloud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelMarioCloud.Size = New System.Drawing.Size(113, 17)
        Me.LabelMarioCloud.TabIndex = 14
        Me.LabelMarioCloud.Text = "MARIO CLOUD"
        '
        'LabelUrl
        '
        Me.LabelUrl.BackColor = System.Drawing.SystemColors.Control
        Me.LabelUrl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelUrl.Location = New System.Drawing.Point(9, 12)
        Me.LabelUrl.Name = "LabelUrl"
        Me.LabelUrl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelUrl.Size = New System.Drawing.Size(113, 17)
        Me.LabelUrl.TabIndex = 12
        Me.LabelUrl.Text = "URL COMPANY"
        '
        'LabelArchiveCloud
        '
        Me.LabelArchiveCloud.BackColor = System.Drawing.SystemColors.Control
        Me.LabelArchiveCloud.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelArchiveCloud.Location = New System.Drawing.Point(9, 84)
        Me.LabelArchiveCloud.Name = "LabelArchiveCloud"
        Me.LabelArchiveCloud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelArchiveCloud.Size = New System.Drawing.Size(113, 17)
        Me.LabelArchiveCloud.TabIndex = 10
        Me.LabelArchiveCloud.Text = "ARCHIVE CLOUD"
        '
        'FormExternalSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonClose
        Me.ClientSize = New System.Drawing.Size(643, 145)
        Me.Controls.Add(Me.TextBoxMarntCloud)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.TextBoxMarioCloud)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.TextBoxUrlCompany)
        Me.Controls.Add(Me.TextBoxArchiveCloud)
        Me.Controls.Add(Me.LabelMarntCloud)
        Me.Controls.Add(Me.LabelMarioCloud)
        Me.Controls.Add(Me.LabelUrl)
        Me.Controls.Add(Me.LabelArchiveCloud)
        Me.Name = "FormExternalSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "IO Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents TextBoxMarntCloud As TextBox
    Public WithEvents ButtonClose As Button
    Public WithEvents TextBoxMarioCloud As TextBox
    Public WithEvents ButtonSave As Button
    Public WithEvents TextBoxUrlCompany As TextBox
    Public WithEvents TextBoxArchiveCloud As TextBox
    Public WithEvents LabelMarntCloud As Label
    Public WithEvents LabelMarioCloud As Label
    Public WithEvents LabelUrl As Label
    Public WithEvents LabelArchiveCloud As Label
End Class
