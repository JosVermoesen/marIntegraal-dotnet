<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLedgerAccountHistory
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBoxPeriodTotals = New System.Windows.Forms.CheckBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonGenerateReport = New System.Windows.Forms.Button()
        Me.TextBoxLedgerAccountTo = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxLedgerAccountFrom = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxProcessingDate = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxPeriodFromTo = New System.Windows.Forms.MaskedTextBox()
        Me.LabelPeriodFromTo = New System.Windows.Forms.Label()
        Me.LabelLedgerAccountTo = New System.Windows.Forms.Label()
        Me.LabelLedgerAccountFrom = New System.Windows.Forms.Label()
        Me.LabelProcessingDate = New System.Windows.Forms.Label()
        Me.LabelRecordLines = New System.Windows.Forms.Label()
        Me.TextBoxRecordLines = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CheckBoxPeriodTotals
        '
        Me.CheckBoxPeriodTotals.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBoxPeriodTotals.CheckAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CheckBoxPeriodTotals.Checked = True
        Me.CheckBoxPeriodTotals.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxPeriodTotals.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxPeriodTotals.Location = New System.Drawing.Point(97, 56)
        Me.CheckBoxPeriodTotals.Name = "CheckBoxPeriodTotals"
        Me.CheckBoxPeriodTotals.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxPeriodTotals.Size = New System.Drawing.Size(179, 16)
        Me.CheckBoxPeriodTotals.TabIndex = 2
        Me.CheckBoxPeriodTotals.Text = "&Periodieke totalen per maand"
        Me.CheckBoxPeriodTotals.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonClose.Location = New System.Drawing.Point(279, 111)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonClose.Size = New System.Drawing.Size(84, 23)
        Me.ButtonClose.TabIndex = 22
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Text = "&Sluiten"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'ButtonGenerateReport
        '
        Me.ButtonGenerateReport.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonGenerateReport.Enabled = False
        Me.ButtonGenerateReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonGenerateReport.Location = New System.Drawing.Point(282, 56)
        Me.ButtonGenerateReport.Name = "ButtonGenerateReport"
        Me.ButtonGenerateReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonGenerateReport.Size = New System.Drawing.Size(84, 45)
        Me.ButtonGenerateReport.TabIndex = 3
        Me.ButtonGenerateReport.Text = "Genereer Rapport"
        Me.ButtonGenerateReport.UseVisualStyleBackColor = False
        '
        'TextBoxLedgerAccountTo
        '
        Me.TextBoxLedgerAccountTo.AllowPromptAsInput = False
        Me.TextBoxLedgerAccountTo.BackColor = System.Drawing.Color.White
        Me.TextBoxLedgerAccountTo.Location = New System.Drawing.Point(126, 106)
        Me.TextBoxLedgerAccountTo.Name = "TextBoxLedgerAccountTo"
        Me.TextBoxLedgerAccountTo.Size = New System.Drawing.Size(105, 20)
        Me.TextBoxLedgerAccountTo.TabIndex = 5
        Me.TextBoxLedgerAccountTo.TabStop = False
        '
        'TextBoxLedgerAccountFrom
        '
        Me.TextBoxLedgerAccountFrom.AllowPromptAsInput = False
        Me.TextBoxLedgerAccountFrom.BackColor = System.Drawing.Color.White
        Me.TextBoxLedgerAccountFrom.Location = New System.Drawing.Point(6, 106)
        Me.TextBoxLedgerAccountFrom.Name = "TextBoxLedgerAccountFrom"
        Me.TextBoxLedgerAccountFrom.Size = New System.Drawing.Size(113, 20)
        Me.TextBoxLedgerAccountFrom.TabIndex = 3
        Me.TextBoxLedgerAccountFrom.TabStop = False
        '
        'TextBoxProcessingDate
        '
        Me.TextBoxProcessingDate.AllowPromptAsInput = False
        Me.TextBoxProcessingDate.BackColor = System.Drawing.Color.White
        Me.TextBoxProcessingDate.Location = New System.Drawing.Point(6, 30)
        Me.TextBoxProcessingDate.Mask = "##/##/####"
        Me.TextBoxProcessingDate.Name = "TextBoxProcessingDate"
        Me.TextBoxProcessingDate.Size = New System.Drawing.Size(85, 20)
        Me.TextBoxProcessingDate.TabIndex = 8
        '
        'TextBoxPeriodFromTo
        '
        Me.TextBoxPeriodFromTo.AllowPromptAsInput = False
        Me.TextBoxPeriodFromTo.BackColor = System.Drawing.Color.White
        Me.TextBoxPeriodFromTo.Location = New System.Drawing.Point(97, 30)
        Me.TextBoxPeriodFromTo.Mask = "##/##/#### - ##/##/####"
        Me.TextBoxPeriodFromTo.Name = "TextBoxPeriodFromTo"
        Me.TextBoxPeriodFromTo.Size = New System.Drawing.Size(179, 20)
        Me.TextBoxPeriodFromTo.TabIndex = 1
        '
        'LabelPeriodFromTo
        '
        Me.LabelPeriodFromTo.AutoSize = True
        Me.LabelPeriodFromTo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelPeriodFromTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelPeriodFromTo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelPeriodFromTo.Location = New System.Drawing.Point(97, 10)
        Me.LabelPeriodFromTo.Name = "LabelPeriodFromTo"
        Me.LabelPeriodFromTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelPeriodFromTo.Size = New System.Drawing.Size(92, 15)
        Me.LabelPeriodFromTo.TabIndex = 0
        Me.LabelPeriodFromTo.Text = "Periode Van - &Tot"
        '
        'LabelLedgerAccountTo
        '
        Me.LabelLedgerAccountTo.AutoSize = True
        Me.LabelLedgerAccountTo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelLedgerAccountTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelLedgerAccountTo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelLedgerAccountTo.Location = New System.Drawing.Point(126, 86)
        Me.LabelLedgerAccountTo.Name = "LabelLedgerAccountTo"
        Me.LabelLedgerAccountTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelLedgerAccountTo.Size = New System.Drawing.Size(25, 15)
        Me.LabelLedgerAccountTo.TabIndex = 4
        Me.LabelLedgerAccountTo.Text = "&Tot"
        '
        'LabelLedgerAccountFrom
        '
        Me.LabelLedgerAccountFrom.AutoSize = True
        Me.LabelLedgerAccountFrom.BackColor = System.Drawing.SystemColors.Control
        Me.LabelLedgerAccountFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelLedgerAccountFrom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelLedgerAccountFrom.Location = New System.Drawing.Point(6, 86)
        Me.LabelLedgerAccountFrom.Name = "LabelLedgerAccountFrom"
        Me.LabelLedgerAccountFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelLedgerAccountFrom.Size = New System.Drawing.Size(77, 15)
        Me.LabelLedgerAccountFrom.TabIndex = 2
        Me.LabelLedgerAccountFrom.Text = "&Van Rekening"
        '
        'LabelProcessingDate
        '
        Me.LabelProcessingDate.AutoSize = True
        Me.LabelProcessingDate.BackColor = System.Drawing.SystemColors.Control
        Me.LabelProcessingDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelProcessingDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelProcessingDate.Location = New System.Drawing.Point(6, 10)
        Me.LabelProcessingDate.Name = "LabelProcessingDate"
        Me.LabelProcessingDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelProcessingDate.Size = New System.Drawing.Size(40, 15)
        Me.LabelProcessingDate.TabIndex = 7
        Me.LabelProcessingDate.Text = "Datu&m"
        '
        'LabelRecordLines
        '
        Me.LabelRecordLines.AutoSize = True
        Me.LabelRecordLines.Location = New System.Drawing.Point(298, 10)
        Me.LabelRecordLines.Name = "LabelRecordLines"
        Me.LabelRecordLines.Size = New System.Drawing.Size(68, 13)
        Me.LabelRecordLines.TabIndex = 103
        Me.LabelRecordLines.Text = "Aantal Lijnen"
        '
        'TextBoxRecordLines
        '
        Me.TextBoxRecordLines.Location = New System.Drawing.Point(288, 30)
        Me.TextBoxRecordLines.Name = "TextBoxRecordLines"
        Me.TextBoxRecordLines.ReadOnly = True
        Me.TextBoxRecordLines.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxRecordLines.TabIndex = 106
        Me.TextBoxRecordLines.TabStop = False
        Me.TextBoxRecordLines.Text = "0"
        Me.TextBoxRecordLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormLedgerAccountHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 139)
        Me.Controls.Add(Me.TextBoxRecordLines)
        Me.Controls.Add(Me.LabelRecordLines)
        Me.Controls.Add(Me.CheckBoxPeriodTotals)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonGenerateReport)
        Me.Controls.Add(Me.TextBoxLedgerAccountTo)
        Me.Controls.Add(Me.TextBoxLedgerAccountFrom)
        Me.Controls.Add(Me.TextBoxProcessingDate)
        Me.Controls.Add(Me.TextBoxPeriodFromTo)
        Me.Controls.Add(Me.LabelPeriodFromTo)
        Me.Controls.Add(Me.LabelLedgerAccountTo)
        Me.Controls.Add(Me.LabelLedgerAccountFrom)
        Me.Controls.Add(Me.LabelProcessingDate)
        Me.Name = "FormLedgerAccountHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Historiek Rekeningen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents CheckBoxPeriodTotals As CheckBox
    Public WithEvents ButtonClose As Button
    Public WithEvents ButtonGenerateReport As Button
    Public WithEvents TextBoxLedgerAccountTo As MaskedTextBox
    Public WithEvents TextBoxLedgerAccountFrom As MaskedTextBox
    Public WithEvents TextBoxProcessingDate As MaskedTextBox
    Public WithEvents TextBoxPeriodFromTo As MaskedTextBox
    Public WithEvents LabelPeriodFromTo As Label
    Public WithEvents LabelLedgerAccountTo As Label
    Public WithEvents LabelLedgerAccountFrom As Label
    Public WithEvents LabelProcessingDate As Label
    Friend WithEvents LabelRecordLines As Label
    Friend WithEvents TextBoxRecordLines As TextBox
End Class
