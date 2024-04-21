<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BSBook
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
        Me.cbJournalDetail = New System.Windows.Forms.CheckBox()
        Me.tbUntil = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.RbCreditNotes = New System.Windows.Forms.RadioButton()
        Me.RbInvoices = New System.Windows.Forms.RadioButton()
        Me.BtnGenerateReport = New System.Windows.Forms.Button()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.FromLabel = New System.Windows.Forms.Label()
        Me.UntilLabel = New System.Windows.Forms.Label()
        Me.DateTimePickerProcessingDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'cbJournalDetail
        '
        Me.cbJournalDetail.BackColor = System.Drawing.SystemColors.Control
        Me.cbJournalDetail.Checked = True
        Me.cbJournalDetail.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbJournalDetail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbJournalDetail.Location = New System.Drawing.Point(125, 92)
        Me.cbJournalDetail.Name = "cbJournalDetail"
        Me.cbJournalDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbJournalDetail.Size = New System.Drawing.Size(119, 15)
        Me.cbJournalDetail.TabIndex = 8
        Me.cbJournalDetail.Text = "Detail Journaal"
        Me.cbJournalDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbJournalDetail.UseVisualStyleBackColor = False
        '
        'tbUntil
        '
        Me.tbUntil.AcceptsReturn = True
        Me.tbUntil.BackColor = System.Drawing.Color.White
        Me.tbUntil.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbUntil.ForeColor = System.Drawing.Color.Black
        Me.tbUntil.Location = New System.Drawing.Point(189, 66)
        Me.tbUntil.MaxLength = 0
        Me.tbUntil.Name = "tbUntil"
        Me.tbUntil.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbUntil.Size = New System.Drawing.Size(57, 20)
        Me.tbUntil.TabIndex = 7
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnClose.Location = New System.Drawing.Point(259, 87)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnClose.Size = New System.Drawing.Size(80, 23)
        Me.BtnClose.TabIndex = 21
        Me.BtnClose.TabStop = False
        Me.BtnClose.Text = "Sluiten"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'RbCreditNotes
        '
        Me.RbCreditNotes.BackColor = System.Drawing.SystemColors.Control
        Me.RbCreditNotes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RbCreditNotes.Location = New System.Drawing.Point(12, 90)
        Me.RbCreditNotes.Name = "RbCreditNotes"
        Me.RbCreditNotes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RbCreditNotes.Size = New System.Drawing.Size(83, 16)
        Me.RbCreditNotes.TabIndex = 5
        Me.RbCreditNotes.Text = "Creditnota's"
        Me.RbCreditNotes.UseVisualStyleBackColor = False
        '
        'RbInvoices
        '
        Me.RbInvoices.BackColor = System.Drawing.SystemColors.Control
        Me.RbInvoices.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RbInvoices.Location = New System.Drawing.Point(12, 68)
        Me.RbInvoices.Name = "RbInvoices"
        Me.RbInvoices.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RbInvoices.Size = New System.Drawing.Size(72, 16)
        Me.RbInvoices.TabIndex = 4
        Me.RbInvoices.Text = "Facturen"
        Me.RbInvoices.UseVisualStyleBackColor = False
        '
        'BtnGenerateReport
        '
        Me.BtnGenerateReport.BackColor = System.Drawing.SystemColors.Control
        Me.BtnGenerateReport.Enabled = False
        Me.BtnGenerateReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnGenerateReport.Location = New System.Drawing.Point(259, 9)
        Me.BtnGenerateReport.Name = "BtnGenerateReport"
        Me.BtnGenerateReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGenerateReport.Size = New System.Drawing.Size(80, 49)
        Me.BtnGenerateReport.TabIndex = 9
        Me.BtnGenerateReport.Text = "Genereer Rapport"
        Me.BtnGenerateReport.UseVisualStyleBackColor = False
        '
        'lblFrom
        '
        Me.lblFrom.BackColor = System.Drawing.SystemColors.Control
        Me.lblFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFrom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFrom.Location = New System.Drawing.Point(188, 43)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFrom.Size = New System.Drawing.Size(57, 20)
        Me.lblFrom.TabIndex = 26
        '
        'DateLabel
        '
        Me.DateLabel.BackColor = System.Drawing.SystemColors.Control
        Me.DateLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DateLabel.Location = New System.Drawing.Point(9, 12)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateLabel.Size = New System.Drawing.Size(53, 20)
        Me.DateLabel.TabIndex = 0
        Me.DateLabel.Text = "Datu&m"
        '
        'FromLabel
        '
        Me.FromLabel.BackColor = System.Drawing.SystemColors.Control
        Me.FromLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FromLabel.Location = New System.Drawing.Point(152, 45)
        Me.FromLabel.Name = "FromLabel"
        Me.FromLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FromLabel.Size = New System.Drawing.Size(32, 13)
        Me.FromLabel.TabIndex = 24
        Me.FromLabel.Text = "Van"
        '
        'UntilLabel
        '
        Me.UntilLabel.BackColor = System.Drawing.SystemColors.Control
        Me.UntilLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UntilLabel.Location = New System.Drawing.Point(153, 68)
        Me.UntilLabel.Name = "UntilLabel"
        Me.UntilLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UntilLabel.Size = New System.Drawing.Size(32, 13)
        Me.UntilLabel.TabIndex = 6
        Me.UntilLabel.Text = "Tot"
        '
        'DateTimePickerProcessingDate
        '
        Me.DateTimePickerProcessingDate.Location = New System.Drawing.Point(68, 12)
        Me.DateTimePickerProcessingDate.MaxDate = New Date(2061, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerProcessingDate.MinDate = New Date(1985, 12, 1, 0, 0, 0, 0)
        Me.DateTimePickerProcessingDate.Name = "DateTimePickerProcessingDate"
        Me.DateTimePickerProcessingDate.Size = New System.Drawing.Size(176, 20)
        Me.DateTimePickerProcessingDate.TabIndex = 1
        '
        'BSBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(354, 120)
        Me.Controls.Add(Me.DateTimePickerProcessingDate)
        Me.Controls.Add(Me.cbJournalDetail)
        Me.Controls.Add(Me.tbUntil)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.RbCreditNotes)
        Me.Controls.Add(Me.RbInvoices)
        Me.Controls.Add(Me.BtnGenerateReport)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.FromLabel)
        Me.Controls.Add(Me.UntilLabel)
        Me.Name = "BSBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormBSBook"
        AddHandler FormClosing, AddressOf Me.BSBook_FormClosing
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cbJournalDetail As CheckBox
    Public WithEvents tbUntil As TextBox
    Public WithEvents BtnClose As Button
    Public WithEvents RbCreditNotes As RadioButton
    Public WithEvents RbInvoices As RadioButton
    Public WithEvents BtnGenerateReport As Button
    Public WithEvents lblFrom As Label
    Public WithEvents DateLabel As Label
    Public WithEvents FromLabel As Label
    Public WithEvents UntilLabel As Label
    Friend WithEvents DateTimePickerProcessingDate As DateTimePicker
End Class
