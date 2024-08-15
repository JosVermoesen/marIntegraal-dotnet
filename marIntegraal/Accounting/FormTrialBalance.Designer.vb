<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTrialBalance
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
        Me.TextBoxLedgerAccountTo = New System.Windows.Forms.TextBox()
        Me.TextBoxLedgerAccountFrom = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBoxDetailLedger = New System.Windows.Forms.CheckBox()
        Me.TextBoxPeriodFromTo = New System.Windows.Forms.TextBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.TextBoxProcessingDate = New System.Windows.Forms.TextBox()
        Me.ButtonGenerateReport = New System.Windows.Forms.Button()
        Me.LabelLedgerAccountFromTo = New System.Windows.Forms.Label()
        Me.LabelPeriodFromTo = New System.Windows.Forms.Label()
        Me.LabelProcessingDate = New System.Windows.Forms.Label()
        Me.ButtonXMLExport = New System.Windows.Forms.Button()
        Me.TextBoxRecordLines = New System.Windows.Forms.TextBox()
        Me.LabelRecordLines = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxLedgerAccountTo
        '
        Me.TextBoxLedgerAccountTo.AcceptsReturn = True
        Me.TextBoxLedgerAccountTo.BackColor = System.Drawing.Color.White
        Me.TextBoxLedgerAccountTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxLedgerAccountTo.Enabled = False
        Me.TextBoxLedgerAccountTo.ForeColor = System.Drawing.Color.Black
        Me.TextBoxLedgerAccountTo.Location = New System.Drawing.Point(99, 54)
        Me.TextBoxLedgerAccountTo.MaxLength = 0
        Me.TextBoxLedgerAccountTo.Name = "TextBoxLedgerAccountTo"
        Me.TextBoxLedgerAccountTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxLedgerAccountTo.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxLedgerAccountTo.TabIndex = 21
        Me.TextBoxLedgerAccountTo.Text = "7999999"
        '
        'TextBoxLedgerAccountFrom
        '
        Me.TextBoxLedgerAccountFrom.AcceptsReturn = True
        Me.TextBoxLedgerAccountFrom.BackColor = System.Drawing.Color.White
        Me.TextBoxLedgerAccountFrom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxLedgerAccountFrom.Enabled = False
        Me.TextBoxLedgerAccountFrom.ForeColor = System.Drawing.Color.Black
        Me.TextBoxLedgerAccountFrom.Location = New System.Drawing.Point(11, 54)
        Me.TextBoxLedgerAccountFrom.MaxLength = 0
        Me.TextBoxLedgerAccountFrom.Name = "TextBoxLedgerAccountFrom"
        Me.TextBoxLedgerAccountFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxLedgerAccountFrom.Size = New System.Drawing.Size(73, 20)
        Me.TextBoxLedgerAccountFrom.TabIndex = 20
        Me.TextBoxLedgerAccountFrom.Text = "1"
        '
        'CheckBoxDetailLedger
        '
        Me.CheckBoxDetailLedger.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBoxDetailLedger.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBoxDetailLedger.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBoxDetailLedger.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxDetailLedger.Location = New System.Drawing.Point(166, 9)
        Me.CheckBoxDetailLedger.Name = "CheckBoxDetailLedger"
        Me.CheckBoxDetailLedger.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxDetailLedger.Size = New System.Drawing.Size(96, 17)
        Me.CheckBoxDetailLedger.TabIndex = 25
        Me.CheckBoxDetailLedger.Text = "Detail Journaal"
        Me.CheckBoxDetailLedger.UseVisualStyleBackColor = False
        '
        'TextBoxPeriodFromTo
        '
        Me.TextBoxPeriodFromTo.AcceptsReturn = True
        Me.TextBoxPeriodFromTo.BackColor = System.Drawing.Color.White
        Me.TextBoxPeriodFromTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxPeriodFromTo.ForeColor = System.Drawing.Color.Black
        Me.TextBoxPeriodFromTo.Location = New System.Drawing.Point(99, 77)
        Me.TextBoxPeriodFromTo.MaxLength = 0
        Me.TextBoxPeriodFromTo.Name = "TextBoxPeriodFromTo"
        Me.TextBoxPeriodFromTo.ReadOnly = True
        Me.TextBoxPeriodFromTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxPeriodFromTo.Size = New System.Drawing.Size(189, 20)
        Me.TextBoxPeriodFromTo.TabIndex = 23
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonClose.Location = New System.Drawing.Point(293, 120)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonClose.Size = New System.Drawing.Size(75, 20)
        Me.ButtonClose.TabIndex = 28
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Text = "&Sluiten"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'TextBoxProcessingDate
        '
        Me.TextBoxProcessingDate.AcceptsReturn = True
        Me.TextBoxProcessingDate.BackColor = System.Drawing.Color.White
        Me.TextBoxProcessingDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxProcessingDate.ForeColor = System.Drawing.Color.Black
        Me.TextBoxProcessingDate.Location = New System.Drawing.Point(57, 6)
        Me.TextBoxProcessingDate.MaxLength = 0
        Me.TextBoxProcessingDate.Name = "TextBoxProcessingDate"
        Me.TextBoxProcessingDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxProcessingDate.Size = New System.Drawing.Size(103, 20)
        Me.TextBoxProcessingDate.TabIndex = 17
        '
        'ButtonGenerateReport
        '
        Me.ButtonGenerateReport.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonGenerateReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonGenerateReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonGenerateReport.Location = New System.Drawing.Point(94, 104)
        Me.ButtonGenerateReport.Name = "ButtonGenerateReport"
        Me.ButtonGenerateReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonGenerateReport.Size = New System.Drawing.Size(75, 41)
        Me.ButtonGenerateReport.TabIndex = 18
        Me.ButtonGenerateReport.Text = "Genereer Rapport"
        Me.ButtonGenerateReport.UseVisualStyleBackColor = False
        '
        'LabelLedgerAccountFromTo
        '
        Me.LabelLedgerAccountFromTo.AutoSize = True
        Me.LabelLedgerAccountFromTo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelLedgerAccountFromTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelLedgerAccountFromTo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelLedgerAccountFromTo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelLedgerAccountFromTo.Location = New System.Drawing.Point(11, 34)
        Me.LabelLedgerAccountFromTo.Name = "LabelLedgerAccountFromTo"
        Me.LabelLedgerAccountFromTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelLedgerAccountFromTo.Size = New System.Drawing.Size(96, 15)
        Me.LabelLedgerAccountFromTo.TabIndex = 19
        Me.LabelLedgerAccountFromTo.Text = "&Rekening Van-Tot"
        '
        'LabelPeriodFromTo
        '
        Me.LabelPeriodFromTo.AutoSize = True
        Me.LabelPeriodFromTo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelPeriodFromTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelPeriodFromTo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelPeriodFromTo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelPeriodFromTo.Location = New System.Drawing.Point(7, 80)
        Me.LabelPeriodFromTo.Name = "LabelPeriodFromTo"
        Me.LabelPeriodFromTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelPeriodFromTo.Size = New System.Drawing.Size(86, 15)
        Me.LabelPeriodFromTo.TabIndex = 22
        Me.LabelPeriodFromTo.Text = "&Periode Van-Tot"
        '
        'LabelProcessingDate
        '
        Me.LabelProcessingDate.AutoSize = True
        Me.LabelProcessingDate.BackColor = System.Drawing.SystemColors.Control
        Me.LabelProcessingDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelProcessingDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelProcessingDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelProcessingDate.Location = New System.Drawing.Point(11, 9)
        Me.LabelProcessingDate.Name = "LabelProcessingDate"
        Me.LabelProcessingDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelProcessingDate.Size = New System.Drawing.Size(40, 15)
        Me.LabelProcessingDate.TabIndex = 16
        Me.LabelProcessingDate.Text = "Datu&m"
        '
        'ButtonXMLExport
        '
        Me.ButtonXMLExport.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonXMLExport.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonXMLExport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonXMLExport.Location = New System.Drawing.Point(7, 108)
        Me.ButtonXMLExport.Name = "ButtonXMLExport"
        Me.ButtonXMLExport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonXMLExport.Size = New System.Drawing.Size(80, 32)
        Me.ButtonXMLExport.TabIndex = 29
        Me.ButtonXMLExport.Text = "XML Export"
        Me.ButtonXMLExport.UseVisualStyleBackColor = False
        '
        'TextBoxRecordLines
        '
        Me.TextBoxRecordLines.Location = New System.Drawing.Point(293, 29)
        Me.TextBoxRecordLines.Name = "TextBoxRecordLines"
        Me.TextBoxRecordLines.ReadOnly = True
        Me.TextBoxRecordLines.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxRecordLines.TabIndex = 108
        Me.TextBoxRecordLines.TabStop = False
        Me.TextBoxRecordLines.Text = "0"
        Me.TextBoxRecordLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelRecordLines
        '
        Me.LabelRecordLines.AutoSize = True
        Me.LabelRecordLines.Location = New System.Drawing.Point(303, 9)
        Me.LabelRecordLines.Name = "LabelRecordLines"
        Me.LabelRecordLines.Size = New System.Drawing.Size(68, 13)
        Me.LabelRecordLines.TabIndex = 107
        Me.LabelRecordLines.Text = "Aantal Lijnen"
        '
        'FormTrialBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonClose
        Me.ClientSize = New System.Drawing.Size(383, 153)
        Me.Controls.Add(Me.TextBoxRecordLines)
        Me.Controls.Add(Me.LabelRecordLines)
        Me.Controls.Add(Me.ButtonXMLExport)
        Me.Controls.Add(Me.TextBoxLedgerAccountTo)
        Me.Controls.Add(Me.TextBoxLedgerAccountFrom)
        Me.Controls.Add(Me.CheckBoxDetailLedger)
        Me.Controls.Add(Me.TextBoxPeriodFromTo)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.TextBoxProcessingDate)
        Me.Controls.Add(Me.ButtonGenerateReport)
        Me.Controls.Add(Me.LabelLedgerAccountFromTo)
        Me.Controls.Add(Me.LabelPeriodFromTo)
        Me.Controls.Add(Me.LabelProcessingDate)
        Me.Name = "FormTrialBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Proef- en Saldi balans"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents TextBoxLedgerAccountTo As TextBox
    Public WithEvents TextBoxLedgerAccountFrom As TextBox
    Public WithEvents CheckBoxDetailLedger As CheckBox
    Public WithEvents TextBoxPeriodFromTo As TextBox
    Public WithEvents ButtonClose As Button
    Public WithEvents TextBoxProcessingDate As TextBox
    Public WithEvents ButtonGenerateReport As Button
    Public WithEvents LabelLedgerAccountFromTo As Label
    Public WithEvents LabelPeriodFromTo As Label
    Public WithEvents LabelProcessingDate As Label
    Public WithEvents ButtonXMLExport As Button
    Friend WithEvents TextBoxRecordLines As TextBox
    Friend WithEvents LabelRecordLines As Label
End Class
