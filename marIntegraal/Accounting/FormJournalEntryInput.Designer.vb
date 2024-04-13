<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJournalEntryInput
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
        Me.ComboBoxBookType = New System.Windows.Forms.ComboBox()
        Me.ButtonAddLine = New System.Windows.Forms.Button()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.DebitChoosen = New System.Windows.Forms.RadioButton()
        Me.CreditChoosen = New System.Windows.Forms.RadioButton()
        Me.CheckBoxDCFlag = New System.Windows.Forms.CheckBox()
        Me.TextBoxLedgerAccount = New System.Windows.Forms.TextBox()
        Me.TextBoxOffsetAccount = New System.Windows.Forms.TextBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonEraseAll = New System.Windows.Forms.Button()
        Me.TextBoxAmount = New System.Windows.Forms.TextBox()
        Me.ButtonBookEntries = New System.Windows.Forms.Button()
        Me.ListBoxJournalEntries = New System.Windows.Forms.ListBox()
        Me.LabelOffsetAccountName = New System.Windows.Forms.Label()
        Me.LabelLedgerAccountName = New System.Windows.Forms.Label()
        Me.LabelBookingDate = New System.Windows.Forms.Label()
        Me.LabelAmount = New System.Windows.Forms.Label()
        Me.LabelAccount = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.LabelSolde = New System.Windows.Forms.Label()
        Me._Label1_8 = New System.Windows.Forms.Label()
        Me._Label1_7 = New System.Windows.Forms.Label()
        Me._Label1_6 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me.LabelSoldeAmount = New System.Windows.Forms.Label()
        Me.DateTimePickerBookingDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBoxDCChoise = New System.Windows.Forms.GroupBox()
        Me.GroupBoxDCChoise.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxBookType
        '
        Me.ComboBoxBookType.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBoxBookType.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboBoxBookType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBookType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboBoxBookType.Location = New System.Drawing.Point(16, 20)
        Me.ComboBoxBookType.Name = "ComboBoxBookType"
        Me.ComboBoxBookType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBoxBookType.Size = New System.Drawing.Size(174, 21)
        Me.ComboBoxBookType.TabIndex = 0
        '
        'ButtonAddLine
        '
        Me.ButtonAddLine.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonAddLine.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonAddLine.Enabled = False
        Me.ButtonAddLine.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonAddLine.Location = New System.Drawing.Point(322, 77)
        Me.ButtonAddLine.Name = "ButtonAddLine"
        Me.ButtonAddLine.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonAddLine.Size = New System.Drawing.Size(73, 21)
        Me.ButtonAddLine.TabIndex = 37
        Me.ButtonAddLine.TabStop = False
        Me.ButtonAddLine.Text = "Bij&voegen"
        Me.ButtonAddLine.UseVisualStyleBackColor = False
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.AcceptsReturn = True
        Me.TextBoxDescription.BackColor = System.Drawing.Color.White
        Me.TextBoxDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxDescription.ForeColor = System.Drawing.Color.Black
        Me.TextBoxDescription.Location = New System.Drawing.Point(196, 20)
        Me.TextBoxDescription.MaxLength = 0
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxDescription.Size = New System.Drawing.Size(209, 20)
        Me.TextBoxDescription.TabIndex = 2
        '
        'DebitChoosen
        '
        Me.DebitChoosen.BackColor = System.Drawing.SystemColors.Control
        Me.DebitChoosen.Checked = True
        Me.DebitChoosen.Cursor = System.Windows.Forms.Cursors.Default
        Me.DebitChoosen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DebitChoosen.Location = New System.Drawing.Point(6, 19)
        Me.DebitChoosen.Name = "DebitChoosen"
        Me.DebitChoosen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DebitChoosen.Size = New System.Drawing.Size(88, 16)
        Me.DebitChoosen.TabIndex = 4
        Me.DebitChoosen.TabStop = True
        Me.DebitChoosen.Text = "&Debiteren (+)"
        Me.DebitChoosen.UseVisualStyleBackColor = False
        '
        'CreditChoosen
        '
        Me.CreditChoosen.BackColor = System.Drawing.SystemColors.Control
        Me.CreditChoosen.Cursor = System.Windows.Forms.Cursors.Default
        Me.CreditChoosen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CreditChoosen.Location = New System.Drawing.Point(6, 36)
        Me.CreditChoosen.Name = "CreditChoosen"
        Me.CreditChoosen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CreditChoosen.Size = New System.Drawing.Size(85, 16)
        Me.CreditChoosen.TabIndex = 5
        Me.CreditChoosen.Text = "&Crediteren (-)"
        Me.CreditChoosen.UseVisualStyleBackColor = False
        '
        'CheckBoxDCFlag
        '
        Me.CheckBoxDCFlag.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBoxDCFlag.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBoxDCFlag.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CheckBoxDCFlag.Location = New System.Drawing.Point(6, 57)
        Me.CheckBoxDCFlag.Name = "CheckBoxDCFlag"
        Me.CheckBoxDCFlag.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxDCFlag.Size = New System.Drawing.Size(99, 21)
        Me.CheckBoxDCFlag.TabIndex = 6
        Me.CheckBoxDCFlag.TabStop = False
        Me.CheckBoxDCFlag.Text = "&Tegenrekening (/)"
        Me.CheckBoxDCFlag.UseVisualStyleBackColor = False
        '
        'TextBoxLedgerAccount
        '
        Me.TextBoxLedgerAccount.AcceptsReturn = True
        Me.TextBoxLedgerAccount.BackColor = System.Drawing.Color.White
        Me.TextBoxLedgerAccount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxLedgerAccount.ForeColor = System.Drawing.Color.Black
        Me.TextBoxLedgerAccount.Location = New System.Drawing.Point(12, 133)
        Me.TextBoxLedgerAccount.MaxLength = 0
        Me.TextBoxLedgerAccount.Name = "TextBoxLedgerAccount"
        Me.TextBoxLedgerAccount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxLedgerAccount.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxLedgerAccount.TabIndex = 8
        '
        'TextBoxOffsetAccount
        '
        Me.TextBoxOffsetAccount.AcceptsReturn = True
        Me.TextBoxOffsetAccount.BackColor = System.Drawing.Color.White
        Me.TextBoxOffsetAccount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxOffsetAccount.ForeColor = System.Drawing.Color.Black
        Me.TextBoxOffsetAccount.Location = New System.Drawing.Point(12, 159)
        Me.TextBoxOffsetAccount.MaxLength = 0
        Me.TextBoxOffsetAccount.Name = "TextBoxOffsetAccount"
        Me.TextBoxOffsetAccount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxOffsetAccount.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxOffsetAccount.TabIndex = 9
        Me.TextBoxOffsetAccount.Visible = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonClose.Location = New System.Drawing.Point(322, 158)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonClose.Size = New System.Drawing.Size(73, 21)
        Me.ButtonClose.TabIndex = 40
        Me.ButtonClose.TabStop = False
        Me.ButtonClose.Text = "Sluiten"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'ButtonEraseAll
        '
        Me.ButtonEraseAll.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonEraseAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonEraseAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonEraseAll.Location = New System.Drawing.Point(322, 131)
        Me.ButtonEraseAll.Name = "ButtonEraseAll"
        Me.ButtonEraseAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonEraseAll.Size = New System.Drawing.Size(73, 21)
        Me.ButtonEraseAll.TabIndex = 42
        Me.ButtonEraseAll.TabStop = False
        Me.ButtonEraseAll.Text = "Schoo&n"
        Me.ButtonEraseAll.UseVisualStyleBackColor = False
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.AcceptsReturn = True
        Me.TextBoxAmount.BackColor = System.Drawing.Color.White
        Me.TextBoxAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxAmount.ForeColor = System.Drawing.Color.Black
        Me.TextBoxAmount.Location = New System.Drawing.Point(102, 100)
        Me.TextBoxAmount.MaxLength = 0
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxAmount.Size = New System.Drawing.Size(88, 20)
        Me.TextBoxAmount.TabIndex = 11
        '
        'ButtonBookEntries
        '
        Me.ButtonBookEntries.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonBookEntries.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonBookEntries.Enabled = False
        Me.ButtonBookEntries.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonBookEntries.Location = New System.Drawing.Point(322, 104)
        Me.ButtonBookEntries.Name = "ButtonBookEntries"
        Me.ButtonBookEntries.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonBookEntries.Size = New System.Drawing.Size(73, 21)
        Me.ButtonBookEntries.TabIndex = 38
        Me.ButtonBookEntries.Text = "Boeken"
        Me.ButtonBookEntries.UseVisualStyleBackColor = False
        '
        'ListBoxJournalEntries
        '
        Me.ListBoxJournalEntries.BackColor = System.Drawing.Color.White
        Me.ListBoxJournalEntries.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListBoxJournalEntries.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxJournalEntries.ForeColor = System.Drawing.Color.Black
        Me.ListBoxJournalEntries.ItemHeight = 15
        Me.ListBoxJournalEntries.Location = New System.Drawing.Point(12, 197)
        Me.ListBoxJournalEntries.Name = "ListBoxJournalEntries"
        Me.ListBoxJournalEntries.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListBoxJournalEntries.Size = New System.Drawing.Size(497, 229)
        Me.ListBoxJournalEntries.TabIndex = 41
        '
        'LabelOffsetAccountName
        '
        Me.LabelOffsetAccountName.BackColor = System.Drawing.SystemColors.Control
        Me.LabelOffsetAccountName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelOffsetAccountName.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelOffsetAccountName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelOffsetAccountName.Location = New System.Drawing.Point(96, 157)
        Me.LabelOffsetAccountName.Name = "LabelOffsetAccountName"
        Me.LabelOffsetAccountName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelOffsetAccountName.Size = New System.Drawing.Size(217, 21)
        Me.LabelOffsetAccountName.TabIndex = 49
        Me.LabelOffsetAccountName.Visible = False
        '
        'LabelLedgerAccountName
        '
        Me.LabelLedgerAccountName.BackColor = System.Drawing.SystemColors.Control
        Me.LabelLedgerAccountName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelLedgerAccountName.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelLedgerAccountName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelLedgerAccountName.Location = New System.Drawing.Point(96, 133)
        Me.LabelLedgerAccountName.Name = "LabelLedgerAccountName"
        Me.LabelLedgerAccountName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelLedgerAccountName.Size = New System.Drawing.Size(217, 21)
        Me.LabelLedgerAccountName.TabIndex = 50
        '
        'LabelBookingDate
        '
        Me.LabelBookingDate.BackColor = System.Drawing.SystemColors.Control
        Me.LabelBookingDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelBookingDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelBookingDate.Location = New System.Drawing.Point(20, 67)
        Me.LabelBookingDate.Name = "LabelBookingDate"
        Me.LabelBookingDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelBookingDate.Size = New System.Drawing.Size(72, 16)
        Me.LabelBookingDate.TabIndex = 99
        Me.LabelBookingDate.Text = "Datu&m"
        '
        'LabelAmount
        '
        Me.LabelAmount.BackColor = System.Drawing.SystemColors.Control
        Me.LabelAmount.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelAmount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelAmount.Location = New System.Drawing.Point(145, 81)
        Me.LabelAmount.Name = "LabelAmount"
        Me.LabelAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelAmount.Size = New System.Drawing.Size(45, 16)
        Me.LabelAmount.TabIndex = 10
        Me.LabelAmount.Text = "&Bedrag"
        '
        'LabelAccount
        '
        Me.LabelAccount.BackColor = System.Drawing.SystemColors.Control
        Me.LabelAccount.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelAccount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelAccount.Location = New System.Drawing.Point(12, 116)
        Me.LabelAccount.Name = "LabelAccount"
        Me.LabelAccount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelAccount.Size = New System.Drawing.Size(64, 14)
        Me.LabelAccount.TabIndex = 7
        Me.LabelAccount.Text = "&Rekening"
        '
        'LabelDescription
        '
        Me.LabelDescription.BackColor = System.Drawing.SystemColors.Control
        Me.LabelDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelDescription.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelDescription.Location = New System.Drawing.Point(202, 4)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelDescription.Size = New System.Drawing.Size(112, 16)
        Me.LabelDescription.TabIndex = 1
        Me.LabelDescription.Text = "&Omschrijving"
        '
        'LabelSolde
        '
        Me.LabelSolde.BackColor = System.Drawing.SystemColors.Control
        Me.LabelSolde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSolde.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelSolde.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSolde.Location = New System.Drawing.Point(426, 24)
        Me.LabelSolde.Name = "LabelSolde"
        Me.LabelSolde.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelSolde.Size = New System.Drawing.Size(84, 33)
        Me.LabelSolde.TabIndex = 44
        Me.LabelSolde.Text = "Saldo nog toe te wijzen"
        Me.LabelSolde.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_8
        '
        Me._Label1_8.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_8.Location = New System.Drawing.Point(436, 182)
        Me._Label1_8.Name = "_Label1_8"
        Me._Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_8.Size = New System.Drawing.Size(56, 16)
        Me._Label1_8.TabIndex = 48
        Me._Label1_8.Text = "TegenR."
        '
        '_Label1_7
        '
        Me._Label1_7.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_7.Location = New System.Drawing.Point(382, 182)
        Me._Label1_7.Name = "_Label1_7"
        Me._Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_7.Size = New System.Drawing.Size(48, 16)
        Me._Label1_7.TabIndex = 47
        Me._Label1_7.Text = "Bedrag"
        Me._Label1_7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_6
        '
        Me._Label1_6.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_6.Location = New System.Drawing.Point(93, 182)
        Me._Label1_6.Name = "_Label1_6"
        Me._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_6.Size = New System.Drawing.Size(80, 16)
        Me._Label1_6.TabIndex = 46
        Me._Label1_6.Text = "Naam"
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(17, 182)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(56, 16)
        Me._Label1_2.TabIndex = 45
        Me._Label1_2.Text = "Nummer"
        '
        'LabelSoldeAmount
        '
        Me.LabelSoldeAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelSoldeAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSoldeAmount.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelSoldeAmount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSoldeAmount.Location = New System.Drawing.Point(426, 60)
        Me.LabelSoldeAmount.Name = "LabelSoldeAmount"
        Me.LabelSoldeAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelSoldeAmount.Size = New System.Drawing.Size(83, 21)
        Me.LabelSoldeAmount.TabIndex = 43
        Me.LabelSoldeAmount.Text = "0"
        Me.LabelSoldeAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DateTimePickerBookingDate
        '
        Me.DateTimePickerBookingDate.Location = New System.Drawing.Point(16, 47)
        Me.DateTimePickerBookingDate.Name = "DateTimePickerBookingDate"
        Me.DateTimePickerBookingDate.Size = New System.Drawing.Size(176, 20)
        Me.DateTimePickerBookingDate.TabIndex = 100
        '
        'GroupBoxDCChoise
        '
        Me.GroupBoxDCChoise.Controls.Add(Me.CheckBoxDCFlag)
        Me.GroupBoxDCChoise.Controls.Add(Me.CreditChoosen)
        Me.GroupBoxDCChoise.Controls.Add(Me.DebitChoosen)
        Me.GroupBoxDCChoise.Location = New System.Drawing.Point(196, 46)
        Me.GroupBoxDCChoise.Name = "GroupBoxDCChoise"
        Me.GroupBoxDCChoise.Size = New System.Drawing.Size(111, 78)
        Me.GroupBoxDCChoise.TabIndex = 3
        Me.GroupBoxDCChoise.TabStop = False
        Me.GroupBoxDCChoise.Text = "D/C Keuze"
        '
        'FrmJournalEntryInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonClose
        Me.ClientSize = New System.Drawing.Size(519, 434)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBoxDCChoise)
        Me.Controls.Add(Me.DateTimePickerBookingDate)
        Me.Controls.Add(Me.ComboBoxBookType)
        Me.Controls.Add(Me.ButtonAddLine)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.TextBoxLedgerAccount)
        Me.Controls.Add(Me.TextBoxOffsetAccount)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonEraseAll)
        Me.Controls.Add(Me.TextBoxAmount)
        Me.Controls.Add(Me.ButtonBookEntries)
        Me.Controls.Add(Me.ListBoxJournalEntries)
        Me.Controls.Add(Me.LabelOffsetAccountName)
        Me.Controls.Add(Me.LabelLedgerAccountName)
        Me.Controls.Add(Me.LabelBookingDate)
        Me.Controls.Add(Me.LabelAmount)
        Me.Controls.Add(Me.LabelAccount)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelSolde)
        Me.Controls.Add(Me._Label1_8)
        Me.Controls.Add(Me._Label1_7)
        Me.Controls.Add(Me._Label1_6)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me.LabelSoldeAmount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmJournalEntryInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ctrl+Shift+F5 Diverse Posten"
        Me.GroupBoxDCChoise.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents ComboBoxBookType As ComboBox
    Public WithEvents ButtonAddLine As Button
    Public WithEvents TextBoxDescription As TextBox
    Public WithEvents DebitChoosen As RadioButton
    Public WithEvents CreditChoosen As RadioButton
    Public WithEvents CheckBoxDCFlag As CheckBox
    Public WithEvents TextBoxLedgerAccount As TextBox
    Public WithEvents TextBoxOffsetAccount As TextBox
    Public WithEvents ButtonClose As Button
    Public WithEvents ButtonEraseAll As Button
    Public WithEvents TextBoxAmount As TextBox
    Public WithEvents ButtonBookEntries As Button
    Public WithEvents ListBoxJournalEntries As ListBox
    Public WithEvents LabelOffsetAccountName As Label
    Public WithEvents LabelLedgerAccountName As Label
    Public WithEvents LabelBookingDate As Label
    Public WithEvents LabelAmount As Label
    Public WithEvents LabelAccount As Label
    Public WithEvents LabelDescription As Label
    Public WithEvents LabelSolde As Label
    Public WithEvents _Label1_8 As Label
    Public WithEvents _Label1_7 As Label
    Public WithEvents _Label1_6 As Label
    Public WithEvents _Label1_2 As Label
    Public WithEvents LabelSoldeAmount As Label
    Friend WithEvents DateTimePickerBookingDate As DateTimePicker
    Friend WithEvents GroupBoxDCChoise As GroupBox
End Class
