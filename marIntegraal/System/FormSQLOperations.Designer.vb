<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SqlOperations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SqlOperations))
        Me.BtnBackup = New System.Windows.Forms.Button()
        Me.BtnNet = New System.Windows.Forms.Button()
        Me.TbPlus = New System.Windows.Forms.TextBox()
        Me.TbValue = New System.Windows.Forms.TextBox()
        Me.CbOperator = New System.Windows.Forms.ComboBox()
        Me.CbFields = New System.Windows.Forms.ComboBox()
        Me.CbSQLCommand = New System.Windows.Forms.ComboBox()
        Me.BtnOpenXML = New System.Windows.Forms.Button()
        Me.BtnSaveDefinition = New System.Windows.Forms.Button()
        Me.CbAvailableSqlDef = New System.Windows.Forms.ComboBox()
        Me.TbSql = New System.Windows.Forms.TextBox()
        Me.BtnExecute = New System.Windows.Forms.Button()
        Me.BtnCopy = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.BtnVersion = New System.Windows.Forms.Button()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.DgvSQL = New System.Windows.Forms.DataGridView()
        Me.LbDatabase = New System.Windows.Forms.ListBox()
        CType(Me.DgvSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBackup
        '
        Me.BtnBackup.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBackup.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnBackup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnBackup.Location = New System.Drawing.Point(562, 170)
        Me.BtnBackup.Name = "BtnBackup"
        Me.BtnBackup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnBackup.Size = New System.Drawing.Size(45, 25)
        Me.BtnBackup.TabIndex = 36
        Me.BtnBackup.Text = "Backup"
        Me.BtnBackup.UseVisualStyleBackColor = False
        '
        'BtnNet
        '
        Me.BtnNet.BackColor = System.Drawing.SystemColors.Control
        Me.BtnNet.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnNet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnNet.Location = New System.Drawing.Point(526, 170)
        Me.BtnNet.Name = "BtnNet"
        Me.BtnNet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnNet.Size = New System.Drawing.Size(33, 25)
        Me.BtnNet.TabIndex = 35
        Me.BtnNet.Text = "Net1"
        Me.BtnNet.UseVisualStyleBackColor = False
        '
        'TbPlus
        '
        Me.TbPlus.AcceptsReturn = True
        Me.TbPlus.BackColor = System.Drawing.SystemColors.Window
        Me.TbPlus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbPlus.Enabled = False
        Me.TbPlus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TbPlus.Location = New System.Drawing.Point(95, 432)
        Me.TbPlus.MaxLength = 0
        Me.TbPlus.Name = "TbPlus"
        Me.TbPlus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TbPlus.Size = New System.Drawing.Size(201, 20)
        Me.TbPlus.TabIndex = 34
        '
        'TbValue
        '
        Me.TbValue.AcceptsReturn = True
        Me.TbValue.BackColor = System.Drawing.SystemColors.Window
        Me.TbValue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbValue.Enabled = False
        Me.TbValue.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TbValue.Location = New System.Drawing.Point(504, 433)
        Me.TbValue.MaxLength = 0
        Me.TbValue.Name = "TbValue"
        Me.TbValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TbValue.Size = New System.Drawing.Size(101, 20)
        Me.TbValue.TabIndex = 33
        '
        'CbOperator
        '
        Me.CbOperator.BackColor = System.Drawing.SystemColors.Window
        Me.CbOperator.Cursor = System.Windows.Forms.Cursors.Default
        Me.CbOperator.Enabled = False
        Me.CbOperator.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CbOperator.Items.AddRange(New Object() {"Like", "=", "<>", "<=", ">=", ">", "<"})
        Me.CbOperator.Location = New System.Drawing.Point(395, 432)
        Me.CbOperator.Name = "CbOperator"
        Me.CbOperator.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CbOperator.Size = New System.Drawing.Size(105, 21)
        Me.CbOperator.TabIndex = 32
        '
        'CbFields
        '
        Me.CbFields.BackColor = System.Drawing.SystemColors.Window
        Me.CbFields.Cursor = System.Windows.Forms.Cursors.Default
        Me.CbFields.Enabled = False
        Me.CbFields.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CbFields.Location = New System.Drawing.Point(299, 432)
        Me.CbFields.Name = "CbFields"
        Me.CbFields.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CbFields.Size = New System.Drawing.Size(93, 21)
        Me.CbFields.TabIndex = 31
        '
        'CbSQLCommand
        '
        Me.CbSQLCommand.BackColor = System.Drawing.SystemColors.Window
        Me.CbSQLCommand.Cursor = System.Windows.Forms.Cursors.Default
        Me.CbSQLCommand.Enabled = False
        Me.CbSQLCommand.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CbSQLCommand.Items.AddRange(New Object() {"SELECT", "DELETE", "UPDATE", "INSERT", "PROCEDURE"})
        Me.CbSQLCommand.Location = New System.Drawing.Point(3, 432)
        Me.CbSQLCommand.Name = "CbSQLCommand"
        Me.CbSQLCommand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CbSQLCommand.Size = New System.Drawing.Size(89, 21)
        Me.CbSQLCommand.TabIndex = 30
        '
        'BtnOpenXML
        '
        Me.BtnOpenXML.BackColor = System.Drawing.SystemColors.Control
        Me.BtnOpenXML.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnOpenXML.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnOpenXML.Image = CType(resources.GetObject("BtnOpenXML.Image"), System.Drawing.Image)
        Me.BtnOpenXML.Location = New System.Drawing.Point(526, 87)
        Me.BtnOpenXML.Name = "BtnOpenXML"
        Me.BtnOpenXML.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnOpenXML.Size = New System.Drawing.Size(80, 67)
        Me.BtnOpenXML.TabIndex = 29
        Me.BtnOpenXML.Text = "XML &Openen"
        Me.BtnOpenXML.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnOpenXML.UseVisualStyleBackColor = False
        '
        'BtnSaveDefinition
        '
        Me.BtnSaveDefinition.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSaveDefinition.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnSaveDefinition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSaveDefinition.Image = CType(resources.GetObject("BtnSaveDefinition.Image"), System.Drawing.Image)
        Me.BtnSaveDefinition.Location = New System.Drawing.Point(475, 287)
        Me.BtnSaveDefinition.Name = "BtnSaveDefinition"
        Me.BtnSaveDefinition.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSaveDefinition.Size = New System.Drawing.Size(25, 20)
        Me.BtnSaveDefinition.TabIndex = 27
        Me.BtnSaveDefinition.TabStop = False
        Me.BtnSaveDefinition.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSaveDefinition.UseVisualStyleBackColor = False
        '
        'CbAvailableSqlDef
        '
        Me.CbAvailableSqlDef.BackColor = System.Drawing.SystemColors.Window
        Me.CbAvailableSqlDef.Cursor = System.Windows.Forms.Cursors.Default
        Me.CbAvailableSqlDef.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CbAvailableSqlDef.Location = New System.Drawing.Point(95, 286)
        Me.CbAvailableSqlDef.Name = "CbAvailableSqlDef"
        Me.CbAvailableSqlDef.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CbAvailableSqlDef.Size = New System.Drawing.Size(374, 21)
        Me.CbAvailableSqlDef.Sorted = True
        Me.CbAvailableSqlDef.TabIndex = 20
        '
        'TbSql
        '
        Me.TbSql.AcceptsReturn = True
        Me.TbSql.BackColor = System.Drawing.SystemColors.Window
        Me.TbSql.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbSql.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TbSql.Location = New System.Drawing.Point(3, 308)
        Me.TbSql.MaxLength = 0
        Me.TbSql.Multiline = True
        Me.TbSql.Name = "TbSql"
        Me.TbSql.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TbSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TbSql.Size = New System.Drawing.Size(602, 117)
        Me.TbSql.TabIndex = 19
        '
        'BtnExecute
        '
        Me.BtnExecute.BackColor = System.Drawing.SystemColors.Control
        Me.BtnExecute.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnExecute.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnExecute.Location = New System.Drawing.Point(526, 263)
        Me.BtnExecute.Name = "BtnExecute"
        Me.BtnExecute.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnExecute.Size = New System.Drawing.Size(79, 44)
        Me.BtnExecute.TabIndex = 24
        Me.BtnExecute.TabStop = False
        Me.BtnExecute.Text = "SQL &EXECUTE"
        Me.BtnExecute.UseVisualStyleBackColor = False
        '
        'BtnCopy
        '
        Me.BtnCopy.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCopy.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnCopy.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCopy.Image = CType(resources.GetObject("BtnCopy.Image"), System.Drawing.Image)
        Me.BtnCopy.Location = New System.Drawing.Point(527, 23)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCopy.Size = New System.Drawing.Size(80, 58)
        Me.BtnCopy.TabIndex = 21
        Me.BtnCopy.Text = "XML &Kopie"
        Me.BtnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCopy.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnClose.Location = New System.Drawing.Point(526, 225)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnClose.Size = New System.Drawing.Size(79, 20)
        Me.BtnClose.TabIndex = 22
        Me.BtnClose.TabStop = False
        Me.BtnClose.Text = "Sluiten"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSelect
        '
        Me.BtnSelect.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSelect.Location = New System.Drawing.Point(3, 286)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSelect.Size = New System.Drawing.Size(82, 20)
        Me.BtnSelect.TabIndex = 26
        Me.BtnSelect.TabStop = False
        Me.BtnSelect.Text = "SQL &SELECT"
        Me.BtnSelect.UseVisualStyleBackColor = False
        '
        'BtnVersion
        '
        Me.BtnVersion.BackColor = System.Drawing.SystemColors.Control
        Me.BtnVersion.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnVersion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnVersion.Location = New System.Drawing.Point(526, 198)
        Me.BtnVersion.Name = "BtnVersion"
        Me.BtnVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnVersion.Size = New System.Drawing.Size(80, 20)
        Me.BtnVersion.TabIndex = 23
        Me.BtnVersion.TabStop = False
        Me.BtnVersion.Text = "&Versie"
        Me.BtnVersion.UseVisualStyleBackColor = False
        '
        'lblRecordCount
        '
        Me.lblRecordCount.BackColor = System.Drawing.SystemColors.Control
        Me.lblRecordCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecordCount.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRecordCount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRecordCount.Location = New System.Drawing.Point(527, 3)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRecordCount.Size = New System.Drawing.Size(79, 19)
        Me.lblRecordCount.TabIndex = 28
        Me.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DgvSQL
        '
        Me.DgvSQL.AllowUserToAddRows = False
        Me.DgvSQL.AllowUserToDeleteRows = False
        Me.DgvSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSQL.Location = New System.Drawing.Point(3, 4)
        Me.DgvSQL.Name = "DgvSQL"
        Me.DgvSQL.ReadOnly = True
        Me.DgvSQL.Size = New System.Drawing.Size(518, 276)
        Me.DgvSQL.TabIndex = 88
        '
        'LbDatabase
        '
        Me.LbDatabase.Dock = System.Windows.Forms.DockStyle.Right
        Me.LbDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDatabase.FormattingEnabled = True
        Me.LbDatabase.ItemHeight = 20
        Me.LbDatabase.Location = New System.Drawing.Point(613, 0)
        Me.LbDatabase.Name = "LbDatabase"
        Me.LbDatabase.Size = New System.Drawing.Size(196, 458)
        Me.LbDatabase.TabIndex = 89
        '
        'SqlOperations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 458)
        Me.Controls.Add(Me.LbDatabase)
        Me.Controls.Add(Me.DgvSQL)
        Me.Controls.Add(Me.BtnBackup)
        Me.Controls.Add(Me.BtnNet)
        Me.Controls.Add(Me.TbPlus)
        Me.Controls.Add(Me.TbValue)
        Me.Controls.Add(Me.CbOperator)
        Me.Controls.Add(Me.CbFields)
        Me.Controls.Add(Me.CbSQLCommand)
        Me.Controls.Add(Me.BtnOpenXML)
        Me.Controls.Add(Me.BtnSaveDefinition)
        Me.Controls.Add(Me.CbAvailableSqlDef)
        Me.Controls.Add(Me.TbSql)
        Me.Controls.Add(Me.BtnExecute)
        Me.Controls.Add(Me.BtnCopy)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnVersion)
        Me.Controls.Add(Me.lblRecordCount)
        Me.Name = "SqlOperations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SqlOperations"
        CType(Me.DgvSQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Public WithEvents BtnBackup As Button
    Public WithEvents BtnNet As Button
    Public WithEvents TbPlus As TextBox
    Public WithEvents TbValue As TextBox
    Public WithEvents CbOperator As ComboBox
    Public WithEvents CbFields As ComboBox
    Public WithEvents CbSQLCommand As ComboBox
    Public WithEvents BtnOpenXML As Button
    Public WithEvents BtnSaveDefinition As Button
    Public WithEvents CbAvailableSqlDef As ComboBox
    Public WithEvents TbSql As TextBox
    Public WithEvents BtnExecute As Button
    Public WithEvents BtnCopy As Button
    Public WithEvents BtnClose As Button
    Public WithEvents BtnSelect As Button
    Public WithEvents BtnVersion As Button
    Public WithEvents lblRecordCount As Label
    Friend WithEvents DgvSQL As DataGridView
    Friend WithEvents LbDatabase As ListBox
End Class
