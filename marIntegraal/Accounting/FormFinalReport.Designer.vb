<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFinalReport
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
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ComboBoxReportType = New System.Windows.Forms.ComboBox()
        Me.ButtonGenerate = New System.Windows.Forms.Button()
        Me.TextBoxProcessingDate = New System.Windows.Forms.TextBox()
        Me.LabelMemo = New System.Windows.Forms.Label()
        Me.LabelProcessingDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonClose.Location = New System.Drawing.Point(340, 12)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonClose.Size = New System.Drawing.Size(74, 20)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Text = "Sluiten"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'ComboBoxReportType
        '
        Me.ComboBoxReportType.BackColor = System.Drawing.Color.White
        Me.ComboBoxReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxReportType.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxReportType.Location = New System.Drawing.Point(16, 40)
        Me.ComboBoxReportType.Name = "ComboBoxReportType"
        Me.ComboBoxReportType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBoxReportType.Size = New System.Drawing.Size(397, 21)
        Me.ComboBoxReportType.TabIndex = 7
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonGenerate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonGenerate.Location = New System.Drawing.Point(224, 12)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonGenerate.Size = New System.Drawing.Size(110, 20)
        Me.ButtonGenerate.TabIndex = 8
        Me.ButtonGenerate.Text = "Genereer Rapport"
        Me.ButtonGenerate.UseVisualStyleBackColor = False
        '
        'TextBoxProcessingDate
        '
        Me.TextBoxProcessingDate.AcceptsReturn = True
        Me.TextBoxProcessingDate.BackColor = System.Drawing.Color.White
        Me.TextBoxProcessingDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxProcessingDate.ForeColor = System.Drawing.Color.Black
        Me.TextBoxProcessingDate.Location = New System.Drawing.Point(76, 12)
        Me.TextBoxProcessingDate.MaxLength = 0
        Me.TextBoxProcessingDate.Name = "TextBoxProcessingDate"
        Me.TextBoxProcessingDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxProcessingDate.Size = New System.Drawing.Size(105, 20)
        Me.TextBoxProcessingDate.TabIndex = 6
        '
        'LabelMemo
        '
        Me.LabelMemo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelMemo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelMemo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelMemo.Location = New System.Drawing.Point(12, 72)
        Me.LabelMemo.Name = "LabelMemo"
        Me.LabelMemo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelMemo.Size = New System.Drawing.Size(401, 141)
        Me.LabelMemo.TabIndex = 11
        '
        'LabelProcessingDate
        '
        Me.LabelProcessingDate.BackColor = System.Drawing.SystemColors.Control
        Me.LabelProcessingDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelProcessingDate.Location = New System.Drawing.Point(22, 12)
        Me.LabelProcessingDate.Name = "LabelProcessingDate"
        Me.LabelProcessingDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelProcessingDate.Size = New System.Drawing.Size(48, 20)
        Me.LabelProcessingDate.TabIndex = 10
        Me.LabelProcessingDate.Text = "Datum Drukken"
        '
        'FormFinalReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonClose
        Me.ClientSize = New System.Drawing.Size(432, 224)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ComboBoxReportType)
        Me.Controls.Add(Me.ButtonGenerate)
        Me.Controls.Add(Me.TextBoxProcessingDate)
        Me.Controls.Add(Me.LabelMemo)
        Me.Controls.Add(Me.LabelProcessingDate)
        Me.Name = "FormFinalReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmBoekhoudRapportage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents ButtonClose As Button
    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents ComboBoxReportType As ComboBox
    Public WithEvents ButtonGenerate As Button
    Public WithEvents TextBoxProcessingDate As TextBox
    Public WithEvents LabelMemo As Label
    Public WithEvents LabelProcessingDate As Label
End Class
