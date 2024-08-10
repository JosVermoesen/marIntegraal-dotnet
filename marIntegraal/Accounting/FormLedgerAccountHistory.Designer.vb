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
        Me.chkAfdrukLiggend = New System.Windows.Forms.CheckBox()
        Me.chkAfdrukInVenster = New System.Windows.Forms.CheckBox()
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
        Me.SuspendLayout()
        '
        'CheckBoxPeriodTotals
        '
        Me.CheckBoxPeriodTotals.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBoxPeriodTotals.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBoxPeriodTotals.Checked = True
        Me.CheckBoxPeriodTotals.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxPeriodTotals.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxPeriodTotals.Location = New System.Drawing.Point(231, 118)
        Me.CheckBoxPeriodTotals.Name = "CheckBoxPeriodTotals"
        Me.CheckBoxPeriodTotals.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxPeriodTotals.Size = New System.Drawing.Size(134, 17)
        Me.CheckBoxPeriodTotals.TabIndex = 25
        Me.CheckBoxPeriodTotals.TabStop = False
        Me.CheckBoxPeriodTotals.Text = "&Periodieke Totalen"
        Me.CheckBoxPeriodTotals.UseVisualStyleBackColor = False
        '
        'chkAfdrukLiggend
        '
        Me.chkAfdrukLiggend.BackColor = System.Drawing.SystemColors.Control
        Me.chkAfdrukLiggend.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAfdrukLiggend.Location = New System.Drawing.Point(11, 118)
        Me.chkAfdrukLiggend.Name = "chkAfdrukLiggend"
        Me.chkAfdrukLiggend.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAfdrukLiggend.Size = New System.Drawing.Size(154, 17)
        Me.chkAfdrukLiggend.TabIndex = 24
        Me.chkAfdrukLiggend.TabStop = False
        Me.chkAfdrukLiggend.Text = "&Liggende Printerafdruk"
        Me.chkAfdrukLiggend.UseVisualStyleBackColor = False
        '
        'chkAfdrukInVenster
        '
        Me.chkAfdrukInVenster.BackColor = System.Drawing.SystemColors.Control
        Me.chkAfdrukInVenster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAfdrukInVenster.Location = New System.Drawing.Point(11, 98)
        Me.chkAfdrukInVenster.Name = "chkAfdrukInVenster"
        Me.chkAfdrukInVenster.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAfdrukInVenster.Size = New System.Drawing.Size(122, 17)
        Me.chkAfdrukInVenster.TabIndex = 23
        Me.chkAfdrukInVenster.Text = "Afdruk in venster"
        Me.chkAfdrukInVenster.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonClose.Location = New System.Drawing.Point(275, 32)
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
        Me.ButtonGenerateReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonGenerateReport.Location = New System.Drawing.Point(275, 6)
        Me.ButtonGenerateReport.Name = "ButtonGenerateReport"
        Me.ButtonGenerateReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonGenerateReport.Size = New System.Drawing.Size(84, 23)
        Me.ButtonGenerateReport.TabIndex = 17
        Me.ButtonGenerateReport.Text = "Generate"
        Me.ButtonGenerateReport.UseVisualStyleBackColor = False
        '
        'TextBoxLedgerAccountTo
        '
        Me.TextBoxLedgerAccountTo.AllowPromptAsInput = False
        Me.TextBoxLedgerAccountTo.BackColor = System.Drawing.Color.White
        Me.TextBoxLedgerAccountTo.Location = New System.Drawing.Point(127, 30)
        Me.TextBoxLedgerAccountTo.Name = "TextBoxLedgerAccountTo"
        Me.TextBoxLedgerAccountTo.Size = New System.Drawing.Size(105, 20)
        Me.TextBoxLedgerAccountTo.TabIndex = 16
        '
        'TextBoxLedgerAccountFrom
        '
        Me.TextBoxLedgerAccountFrom.AllowPromptAsInput = False
        Me.TextBoxLedgerAccountFrom.BackColor = System.Drawing.Color.White
        Me.TextBoxLedgerAccountFrom.Location = New System.Drawing.Point(7, 30)
        Me.TextBoxLedgerAccountFrom.Name = "TextBoxLedgerAccountFrom"
        Me.TextBoxLedgerAccountFrom.Size = New System.Drawing.Size(113, 20)
        Me.TextBoxLedgerAccountFrom.TabIndex = 14
        '
        'TextBoxProcessingDate
        '
        Me.TextBoxProcessingDate.AllowPromptAsInput = False
        Me.TextBoxProcessingDate.BackColor = System.Drawing.Color.White
        Me.TextBoxProcessingDate.Location = New System.Drawing.Point(197, 78)
        Me.TextBoxProcessingDate.Mask = "##/##/####"
        Me.TextBoxProcessingDate.Name = "TextBoxProcessingDate"
        Me.TextBoxProcessingDate.Size = New System.Drawing.Size(85, 20)
        Me.TextBoxProcessingDate.TabIndex = 21
        '
        'TextBoxPeriodFromTo
        '
        Me.TextBoxPeriodFromTo.AllowPromptAsInput = False
        Me.TextBoxPeriodFromTo.BackColor = System.Drawing.Color.White
        Me.TextBoxPeriodFromTo.Location = New System.Drawing.Point(11, 78)
        Me.TextBoxPeriodFromTo.Mask = "##/##/#### - ##/##/####"
        Me.TextBoxPeriodFromTo.Name = "TextBoxPeriodFromTo"
        Me.TextBoxPeriodFromTo.Size = New System.Drawing.Size(180, 20)
        Me.TextBoxPeriodFromTo.TabIndex = 19
        '
        'LabelPeriodFromTo
        '
        Me.LabelPeriodFromTo.AutoSize = True
        Me.LabelPeriodFromTo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelPeriodFromTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelPeriodFromTo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelPeriodFromTo.Location = New System.Drawing.Point(11, 58)
        Me.LabelPeriodFromTo.Name = "LabelPeriodFromTo"
        Me.LabelPeriodFromTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelPeriodFromTo.Size = New System.Drawing.Size(92, 15)
        Me.LabelPeriodFromTo.TabIndex = 18
        Me.LabelPeriodFromTo.Text = "Periode Van - &Tot"
        '
        'LabelLedgerAccountTo
        '
        Me.LabelLedgerAccountTo.AutoSize = True
        Me.LabelLedgerAccountTo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelLedgerAccountTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelLedgerAccountTo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelLedgerAccountTo.Location = New System.Drawing.Point(135, 10)
        Me.LabelLedgerAccountTo.Name = "LabelLedgerAccountTo"
        Me.LabelLedgerAccountTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelLedgerAccountTo.Size = New System.Drawing.Size(25, 15)
        Me.LabelLedgerAccountTo.TabIndex = 15
        Me.LabelLedgerAccountTo.Text = "&Tot"
        '
        'LabelLedgerAccountFrom
        '
        Me.LabelLedgerAccountFrom.AutoSize = True
        Me.LabelLedgerAccountFrom.BackColor = System.Drawing.SystemColors.Control
        Me.LabelLedgerAccountFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelLedgerAccountFrom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelLedgerAccountFrom.Location = New System.Drawing.Point(11, 10)
        Me.LabelLedgerAccountFrom.Name = "LabelLedgerAccountFrom"
        Me.LabelLedgerAccountFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelLedgerAccountFrom.Size = New System.Drawing.Size(86, 15)
        Me.LabelLedgerAccountFrom.TabIndex = 13
        Me.LabelLedgerAccountFrom.Text = "&Vanaf Rekening"
        '
        'LabelProcessingDate
        '
        Me.LabelProcessingDate.AutoSize = True
        Me.LabelProcessingDate.BackColor = System.Drawing.SystemColors.Control
        Me.LabelProcessingDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelProcessingDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelProcessingDate.Location = New System.Drawing.Point(197, 58)
        Me.LabelProcessingDate.Name = "LabelProcessingDate"
        Me.LabelProcessingDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelProcessingDate.Size = New System.Drawing.Size(56, 15)
        Me.LabelProcessingDate.TabIndex = 20
        Me.LabelProcessingDate.Text = "Lijstdatu&m"
        '
        'FormLedgerAccountHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 160)
        Me.Controls.Add(Me.CheckBoxPeriodTotals)
        Me.Controls.Add(Me.chkAfdrukLiggend)
        Me.Controls.Add(Me.chkAfdrukInVenster)
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
        Me.Text = "frmHistoriekRekeningen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents CheckBoxPeriodTotals As CheckBox
    Public WithEvents chkAfdrukLiggend As CheckBox
    Public WithEvents chkAfdrukInVenster As CheckBox
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
End Class
