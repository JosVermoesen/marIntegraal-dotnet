<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFinancialBook
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnManualSearch = New System.Windows.Forms.Button()
        Me.LbStatementsList = New System.Windows.Forms.ListBox()
        Me.CbBankList = New System.Windows.Forms.ComboBox()
        Me.TbFromTo = New System.Windows.Forms.TextBox()
        Me.BtnGenerateReport = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LabelBancList = New System.Windows.Forms.Label()
        Me.LabelFromTo = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.DateTimePickerProcessingDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'BtnManualSearch
        '
        Me.BtnManualSearch.BackColor = System.Drawing.SystemColors.Control
        Me.BtnManualSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnManualSearch.Location = New System.Drawing.Point(363, 44)
        Me.BtnManualSearch.Name = "BtnManualSearch"
        Me.BtnManualSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnManualSearch.Size = New System.Drawing.Size(96, 47)
        Me.BtnManualSearch.TabIndex = 22
        Me.BtnManualSearch.Text = "Manueel &Zoeken"
        Me.BtnManualSearch.UseVisualStyleBackColor = False
        '
        'LbStatementsList
        '
        Me.LbStatementsList.BackColor = System.Drawing.SystemColors.Window
        Me.LbStatementsList.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbStatementsList.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LbStatementsList.ItemHeight = 16
        Me.LbStatementsList.Location = New System.Drawing.Point(1, 96)
        Me.LbStatementsList.Name = "LbStatementsList"
        Me.LbStatementsList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LbStatementsList.Size = New System.Drawing.Size(457, 212)
        Me.LbStatementsList.Sorted = True
        Me.LbStatementsList.TabIndex = 15
        '
        'CbBankList
        '
        Me.CbBankList.BackColor = System.Drawing.Color.White
        Me.CbBankList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbBankList.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CbBankList.Location = New System.Drawing.Point(93, 72)
        Me.CbBankList.Name = "CbBankList"
        Me.CbBankList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CbBankList.Size = New System.Drawing.Size(259, 21)
        Me.CbBankList.TabIndex = 14
        '
        'TbFromTo
        '
        Me.TbFromTo.AcceptsReturn = True
        Me.TbFromTo.BackColor = System.Drawing.Color.White
        Me.TbFromTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbFromTo.ForeColor = System.Drawing.Color.Black
        Me.TbFromTo.Location = New System.Drawing.Point(1, 32)
        Me.TbFromTo.MaxLength = 0
        Me.TbFromTo.Name = "TbFromTo"
        Me.TbFromTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TbFromTo.Size = New System.Drawing.Size(169, 20)
        Me.TbFromTo.TabIndex = 2
        '
        'BtnGenerateReport
        '
        Me.BtnGenerateReport.BackColor = System.Drawing.SystemColors.Control
        Me.BtnGenerateReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnGenerateReport.Location = New System.Drawing.Point(363, 12)
        Me.BtnGenerateReport.Name = "BtnGenerateReport"
        Me.BtnGenerateReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGenerateReport.Size = New System.Drawing.Size(96, 29)
        Me.BtnGenerateReport.TabIndex = 16
        Me.BtnGenerateReport.Text = "Genereren"
        Me.BtnGenerateReport.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnClose.Location = New System.Drawing.Point(359, 310)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnClose.Size = New System.Drawing.Size(96, 25)
        Me.BtnClose.TabIndex = 21
        Me.BtnClose.TabStop = False
        Me.BtnClose.Text = "Sluiten"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'LabelBancList
        '
        Me.LabelBancList.BackColor = System.Drawing.SystemColors.Control
        Me.LabelBancList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelBancList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelBancList.Location = New System.Drawing.Point(3, 64)
        Me.LabelBancList.Name = "LabelBancList"
        Me.LabelBancList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelBancList.Size = New System.Drawing.Size(71, 29)
        Me.LabelBancList.TabIndex = 13
        Me.LabelBancList.Text = "&Uittreksels periode"
        '
        'LabelFromTo
        '
        Me.LabelFromTo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelFromTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelFromTo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelFromTo.Location = New System.Drawing.Point(3, 12)
        Me.LabelFromTo.Name = "LabelFromTo"
        Me.LabelFromTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelFromTo.Size = New System.Drawing.Size(135, 18)
        Me.LabelFromTo.TabIndex = 1
        Me.LabelFromTo.Text = "Afdrukperiode Van - &Tot"
        '
        'LabelDate
        '
        Me.LabelDate.BackColor = System.Drawing.SystemColors.Control
        Me.LabelDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelDate.Location = New System.Drawing.Point(176, 12)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelDate.Size = New System.Drawing.Size(93, 18)
        Me.LabelDate.TabIndex = 19
        Me.LabelDate.Text = "Datu&m Drukken"
        '
        'DateTimePickerProcessingDate
        '
        Me.DateTimePickerProcessingDate.Location = New System.Drawing.Point(176, 33)
        Me.DateTimePickerProcessingDate.MaxDate = New Date(2061, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerProcessingDate.MinDate = New Date(1985, 12, 1, 0, 0, 0, 0)
        Me.DateTimePickerProcessingDate.Name = "DateTimePickerProcessingDate"
        Me.DateTimePickerProcessingDate.Size = New System.Drawing.Size(176, 20)
        Me.DateTimePickerProcessingDate.TabIndex = 89
        '
        'FormFinancialBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(468, 339)
        Me.Controls.Add(Me.DateTimePickerProcessingDate)
        Me.Controls.Add(Me.BtnManualSearch)
        Me.Controls.Add(Me.LbStatementsList)
        Me.Controls.Add(Me.CbBankList)
        Me.Controls.Add(Me.TbFromTo)
        Me.Controls.Add(Me.BtnGenerateReport)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LabelBancList)
        Me.Controls.Add(Me.LabelFromTo)
        Me.Controls.Add(Me.LabelDate)
        Me.Name = "FormFinancialBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FinancialBook"
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents BtnManualSearch As Button
    Public WithEvents LbStatementsList As ListBox
    Public WithEvents CbBankList As ComboBox
    Public WithEvents TbFromTo As TextBox
    Public WithEvents BtnGenerateReport As Button
    Public WithEvents BtnClose As Button
    Public WithEvents LabelBancList As Label
    Public WithEvents LabelFromTo As Label
    Public WithEvents LabelDate As Label
    Friend WithEvents DateTimePickerProcessingDate As DateTimePicker
End Class
