<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJournalEntriesBook
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
        Me.AutoPageBreak = New IDEALSoftware.VpeStandard.VpeControl()
        Me.TextBoxPeriodFromTo = New System.Windows.Forms.TextBox()
        Me.LabelPeriodFromTo = New System.Windows.Forms.Label()
        Me.LabelProcessingDate = New System.Windows.Forms.Label()
        Me.LabelRecordLines = New System.Windows.Forms.Label()
        Me.ButtonGenerateReport = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.TextBoxRecordLines = New System.Windows.Forms.TextBox()
        Me.TextBoxMailToOption = New System.Windows.Forms.TextBox()
        Me.LabelMailToOption = New System.Windows.Forms.Label()
        Me.DateTimePickerProcessingDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'AutoPageBreak
        '
        Me.AutoPageBreak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AutoPageBreak.DocFileReadOnly = False
        Me.AutoPageBreak.EnableHelpRouting = False
        Me.AutoPageBreak.EnablePrintSetupDialog = True
        Me.AutoPageBreak.ExternalWindow = True
        Me.AutoPageBreak.GridMode = IDEALSoftware.VpeStandard.GridMode.InForeground
        Me.AutoPageBreak.GridVisible = False
        Me.AutoPageBreak.Location = New System.Drawing.Point(13, 188)
        Me.AutoPageBreak.Name = "AutoPageBreak"
        Me.AutoPageBreak.PageFormat = IDEALSoftware.VpeStandard.PageFormat.A4
        Me.AutoPageBreak.PageHeight = 29.7R
        Me.AutoPageBreak.PageOrientation = IDEALSoftware.VpeStandard.PageOrientation.Portrait
        Me.AutoPageBreak.PageScroller = True
        Me.AutoPageBreak.PageScrollerTracking = True
        Me.AutoPageBreak.PageWidth = 21.0R
        Me.AutoPageBreak.PaperView = True
        Me.AutoPageBreak.PreviewCtrl = IDEALSoftware.VpeStandard.PreviewCtrl.JumpTop
        Me.AutoPageBreak.Rulers = True
        Me.AutoPageBreak.RulersMeasure = IDEALSoftware.VpeStandard.RulersMeasure.Centimeter
        Me.AutoPageBreak.Size = New System.Drawing.Size(96, 80)
        Me.AutoPageBreak.StatusBar = True
        Me.AutoPageBreak.StatusSegment = True
        Me.AutoPageBreak.SwapFileName = Nothing
        Me.AutoPageBreak.TabIndex = 6
        Me.AutoPageBreak.TabStop = False
        Me.AutoPageBreak.tbAbout = True
        Me.AutoPageBreak.tbClose = True
        Me.AutoPageBreak.tbGrid = False
        Me.AutoPageBreak.tbHelp = True
        Me.AutoPageBreak.tbMail = True
        Me.AutoPageBreak.tbNavigate = True
        Me.AutoPageBreak.tbOpen = True
        Me.AutoPageBreak.tbPrint = True
        Me.AutoPageBreak.tbSave = True
        Me.AutoPageBreak.tbScale = True
        Me.AutoPageBreak.Text = "Automatic Page Break Demo"
        Me.AutoPageBreak.ToolBar = True
        '
        'TextBoxPeriodFromTo
        '
        Me.TextBoxPeriodFromTo.AcceptsReturn = True
        Me.TextBoxPeriodFromTo.BackColor = System.Drawing.Color.White
        Me.TextBoxPeriodFromTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxPeriodFromTo.ForeColor = System.Drawing.Color.Black
        Me.TextBoxPeriodFromTo.Location = New System.Drawing.Point(11, 32)
        Me.TextBoxPeriodFromTo.MaxLength = 0
        Me.TextBoxPeriodFromTo.Name = "TextBoxPeriodFromTo"
        Me.TextBoxPeriodFromTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxPeriodFromTo.Size = New System.Drawing.Size(257, 20)
        Me.TextBoxPeriodFromTo.TabIndex = 1
        AddHandler Me.TextBoxPeriodFromTo.Leave, AddressOf Me.TextBoxPeriodFromTo_Leave
        '
        'LabelPeriodFromTo
        '
        Me.LabelPeriodFromTo.AutoSize = True
        Me.LabelPeriodFromTo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelPeriodFromTo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelPeriodFromTo.Location = New System.Drawing.Point(8, 16)
        Me.LabelPeriodFromTo.Name = "LabelPeriodFromTo"
        Me.LabelPeriodFromTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelPeriodFromTo.Size = New System.Drawing.Size(84, 13)
        Me.LabelPeriodFromTo.TabIndex = 0
        Me.LabelPeriodFromTo.Text = "Selectie &Periode"
        '
        'LabelProcessingDate
        '
        Me.LabelProcessingDate.AutoSize = True
        Me.LabelProcessingDate.BackColor = System.Drawing.SystemColors.Control
        Me.LabelProcessingDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelProcessingDate.Location = New System.Drawing.Point(11, 61)
        Me.LabelProcessingDate.Name = "LabelProcessingDate"
        Me.LabelProcessingDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelProcessingDate.Size = New System.Drawing.Size(38, 13)
        Me.LabelProcessingDate.TabIndex = 2
        Me.LabelProcessingDate.Text = "Datu&m"
        '
        'LabelRecordLines
        '
        Me.LabelRecordLines.AutoSize = True
        Me.LabelRecordLines.Location = New System.Drawing.Point(295, 16)
        Me.LabelRecordLines.Name = "LabelRecordLines"
        Me.LabelRecordLines.Size = New System.Drawing.Size(68, 13)
        Me.LabelRecordLines.TabIndex = 102
        Me.LabelRecordLines.Text = "Aantal Lijnen"
        '
        'ButtonGenerateReport
        '
        Me.ButtonGenerateReport.Enabled = False
        Me.ButtonGenerateReport.Location = New System.Drawing.Point(288, 61)
        Me.ButtonGenerateReport.Name = "ButtonGenerateReport"
        Me.ButtonGenerateReport.Size = New System.Drawing.Size(75, 46)
        Me.ButtonGenerateReport.TabIndex = 4
        Me.ButtonGenerateReport.Text = "Genereer Rapport"
        Me.ButtonGenerateReport.UseVisualStyleBackColor = True
        AddHandler Me.ButtonGenerateReport.Click, AddressOf Me.ButtonGenerateReport_Click
        '
        'ButtonClose
        '
        Me.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonClose.Location = New System.Drawing.Point(288, 122)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 104
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Text = "Sluiten"
        Me.ButtonClose.UseVisualStyleBackColor = True
        AddHandler Me.ButtonClose.Click, AddressOf Me.ButtonClose_Click
        '
        'TextBoxRecordLines
        '
        Me.TextBoxRecordLines.Location = New System.Drawing.Point(288, 35)
        Me.TextBoxRecordLines.Name = "TextBoxRecordLines"
        Me.TextBoxRecordLines.ReadOnly = True
        Me.TextBoxRecordLines.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxRecordLines.TabIndex = 105
        Me.TextBoxRecordLines.TabStop = False
        Me.TextBoxRecordLines.Text = "0"
        Me.TextBoxRecordLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxMailToOption
        '
        Me.TextBoxMailToOption.AcceptsReturn = True
        Me.TextBoxMailToOption.BackColor = System.Drawing.Color.White
        Me.TextBoxMailToOption.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxMailToOption.ForeColor = System.Drawing.Color.Black
        Me.TextBoxMailToOption.Location = New System.Drawing.Point(8, 122)
        Me.TextBoxMailToOption.MaxLength = 0
        Me.TextBoxMailToOption.Name = "TextBoxMailToOption"
        Me.TextBoxMailToOption.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxMailToOption.Size = New System.Drawing.Size(260, 20)
        Me.TextBoxMailToOption.TabIndex = 108
        Me.TextBoxMailToOption.TabStop = False
        Me.TextBoxMailToOption.Text = "josvermoesen@outlook.be"
        '
        'LabelMailToOption
        '
        Me.LabelMailToOption.AutoSize = True
        Me.LabelMailToOption.Location = New System.Drawing.Point(8, 106)
        Me.LabelMailToOption.Name = "LabelMailToOption"
        Me.LabelMailToOption.Size = New System.Drawing.Size(91, 13)
        Me.LabelMailToOption.TabIndex = 107
        Me.LabelMailToOption.Text = "Default &mailadres:"
        '
        'DateTimePickerProcessingDate
        '
        Me.DateTimePickerProcessingDate.Location = New System.Drawing.Point(92, 61)
        Me.DateTimePickerProcessingDate.MaxDate = New Date(2061, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerProcessingDate.MinDate = New Date(1985, 12, 1, 0, 0, 0, 0)
        Me.DateTimePickerProcessingDate.Name = "DateTimePickerProcessingDate"
        Me.DateTimePickerProcessingDate.Size = New System.Drawing.Size(176, 20)
        Me.DateTimePickerProcessingDate.TabIndex = 3
        Me.DateTimePickerProcessingDate.TabStop = False
        '
        'FrmJournalEntriesBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonClose
        Me.ClientSize = New System.Drawing.Size(380, 152)
        Me.ControlBox = False
        Me.Controls.Add(Me.DateTimePickerProcessingDate)
        Me.Controls.Add(Me.LabelMailToOption)
        Me.Controls.Add(Me.TextBoxMailToOption)
        Me.Controls.Add(Me.TextBoxRecordLines)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonGenerateReport)
        Me.Controls.Add(Me.LabelRecordLines)
        Me.Controls.Add(Me.TextBoxPeriodFromTo)
        Me.Controls.Add(Me.LabelPeriodFromTo)
        Me.Controls.Add(Me.LabelProcessingDate)
        Me.Controls.Add(Me.AutoPageBreak)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmJournalEntriesBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Diverse Postenboek"
        Me.TopMost = True
        AddHandler FormClosing, AddressOf Me.FrmJournalEntriesBook_FormClosing
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents AutoPageBreak As IDEALSoftware.VpeStandard.VpeControl
    Public WithEvents TextBoxPeriodFromTo As TextBox
    Public WithEvents LabelPeriodFromTo As Label
    Public WithEvents LabelProcessingDate As Label
    Friend WithEvents LabelRecordLines As Label
    Friend WithEvents ButtonGenerateReport As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents TextBoxRecordLines As TextBox
    Public WithEvents TextBoxMailToOption As TextBox
    Friend WithEvents LabelMailToOption As Label
    Friend WithEvents DateTimePickerProcessingDate As DateTimePicker
End Class
