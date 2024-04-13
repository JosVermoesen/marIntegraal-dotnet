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
        Me.cmdBackup = New System.Windows.Forms.Button()
        Me.cmdNet1 = New System.Windows.Forms.Button()
        Me.txtPLUS = New System.Windows.Forms.TextBox()
        Me.txtWaarde = New System.Windows.Forms.TextBox()
        Me.cbOperatie = New System.Windows.Forms.ComboBox()
        Me.cbVelden = New System.Windows.Forms.ComboBox()
        Me.cbSQLBevel = New System.Windows.Forms.ComboBox()
        Me.cmdOpenXML = New System.Windows.Forms.Button()
        Me.cmdSelectWegschrijven = New System.Windows.Forms.Button()
        Me.cmbSelect = New System.Windows.Forms.ComboBox()
        Me.txtSQL = New System.Windows.Forms.TextBox()
        Me.cmdExecute = New System.Windows.Forms.Button()
        Me.cmdKopij = New System.Windows.Forms.Button()
        Me.cmdSluiten = New System.Windows.Forms.Button()
        Me.cmdSQL = New System.Windows.Forms.Button()
        Me.cmbVersie = New System.Windows.Forms.Button()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.msfSQL = New System.Windows.Forms.DataGridView()
        Me.LBDatabase = New System.Windows.Forms.ListBox()
        CType(Me.msfSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdBackup
        '
        Me.cmdBackup.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBackup.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBackup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBackup.Location = New System.Drawing.Point(562, 183)
        Me.cmdBackup.Name = "cmdBackup"
        Me.cmdBackup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBackup.Size = New System.Drawing.Size(45, 25)
        Me.cmdBackup.TabIndex = 36
        Me.cmdBackup.Text = "Backup"
        Me.cmdBackup.UseVisualStyleBackColor = False
        '
        'cmdNet1
        '
        Me.cmdNet1.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNet1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNet1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNet1.Location = New System.Drawing.Point(526, 183)
        Me.cmdNet1.Name = "cmdNet1"
        Me.cmdNet1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNet1.Size = New System.Drawing.Size(33, 25)
        Me.cmdNet1.TabIndex = 35
        Me.cmdNet1.Text = "Net1"
        Me.cmdNet1.UseVisualStyleBackColor = False
        '
        'txtPLUS
        '
        Me.txtPLUS.AcceptsReturn = True
        Me.txtPLUS.BackColor = System.Drawing.SystemColors.Window
        Me.txtPLUS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPLUS.Enabled = False
        Me.txtPLUS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPLUS.Location = New System.Drawing.Point(95, 306)
        Me.txtPLUS.MaxLength = 0
        Me.txtPLUS.Name = "txtPLUS"
        Me.txtPLUS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPLUS.Size = New System.Drawing.Size(201, 20)
        Me.txtPLUS.TabIndex = 34
        '
        'txtWaarde
        '
        Me.txtWaarde.AcceptsReturn = True
        Me.txtWaarde.BackColor = System.Drawing.SystemColors.Window
        Me.txtWaarde.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWaarde.Enabled = False
        Me.txtWaarde.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWaarde.Location = New System.Drawing.Point(504, 307)
        Me.txtWaarde.MaxLength = 0
        Me.txtWaarde.Name = "txtWaarde"
        Me.txtWaarde.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWaarde.Size = New System.Drawing.Size(101, 20)
        Me.txtWaarde.TabIndex = 33
        '
        'cbOperatie
        '
        Me.cbOperatie.BackColor = System.Drawing.SystemColors.Window
        Me.cbOperatie.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbOperatie.Enabled = False
        Me.cbOperatie.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbOperatie.Items.AddRange(New Object() {"Like", "=", "<>", "<=", ">=", ">", "<"})
        Me.cbOperatie.Location = New System.Drawing.Point(395, 306)
        Me.cbOperatie.Name = "cbOperatie"
        Me.cbOperatie.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbOperatie.Size = New System.Drawing.Size(105, 21)
        Me.cbOperatie.TabIndex = 32
        '
        'cbVelden
        '
        Me.cbVelden.BackColor = System.Drawing.SystemColors.Window
        Me.cbVelden.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbVelden.Enabled = False
        Me.cbVelden.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbVelden.Location = New System.Drawing.Point(299, 306)
        Me.cbVelden.Name = "cbVelden"
        Me.cbVelden.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbVelden.Size = New System.Drawing.Size(93, 21)
        Me.cbVelden.TabIndex = 31
        '
        'cbSQLBevel
        '
        Me.cbSQLBevel.BackColor = System.Drawing.SystemColors.Window
        Me.cbSQLBevel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbSQLBevel.Enabled = False
        Me.cbSQLBevel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbSQLBevel.Items.AddRange(New Object() {"SELECT", "DELETE", "UPDATE", "INSERT", "PROCEDURE"})
        Me.cbSQLBevel.Location = New System.Drawing.Point(3, 306)
        Me.cbSQLBevel.Name = "cbSQLBevel"
        Me.cbSQLBevel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbSQLBevel.Size = New System.Drawing.Size(89, 21)
        Me.cbSQLBevel.TabIndex = 30
        '
        'cmdOpenXML
        '
        Me.cmdOpenXML.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOpenXML.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOpenXML.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOpenXML.Image = CType(resources.GetObject("cmdOpenXML.Image"), System.Drawing.Image)
        Me.cmdOpenXML.Location = New System.Drawing.Point(526, 87)
        Me.cmdOpenXML.Name = "cmdOpenXML"
        Me.cmdOpenXML.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOpenXML.Size = New System.Drawing.Size(80, 67)
        Me.cmdOpenXML.TabIndex = 29
        Me.cmdOpenXML.Text = "XML &Openen"
        Me.cmdOpenXML.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdOpenXML.UseVisualStyleBackColor = False
        '
        'cmdSelectWegschrijven
        '
        Me.cmdSelectWegschrijven.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSelectWegschrijven.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSelectWegschrijven.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSelectWegschrijven.Image = CType(resources.GetObject("cmdSelectWegschrijven.Image"), System.Drawing.Image)
        Me.cmdSelectWegschrijven.Location = New System.Drawing.Point(349, 161)
        Me.cmdSelectWegschrijven.Name = "cmdSelectWegschrijven"
        Me.cmdSelectWegschrijven.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSelectWegschrijven.Size = New System.Drawing.Size(25, 20)
        Me.cmdSelectWegschrijven.TabIndex = 27
        Me.cmdSelectWegschrijven.TabStop = False
        Me.cmdSelectWegschrijven.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSelectWegschrijven.UseVisualStyleBackColor = False
        '
        'cmbSelect
        '
        Me.cmbSelect.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSelect.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSelect.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSelect.Location = New System.Drawing.Point(95, 160)
        Me.cmbSelect.Name = "cmbSelect"
        Me.cmbSelect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSelect.Size = New System.Drawing.Size(248, 21)
        Me.cmbSelect.TabIndex = 20
        Me.cmbSelect.Text = "Combo1"
        '
        'txtSQL
        '
        Me.txtSQL.AcceptsReturn = True
        Me.txtSQL.BackColor = System.Drawing.SystemColors.Window
        Me.txtSQL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSQL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSQL.Location = New System.Drawing.Point(3, 182)
        Me.txtSQL.MaxLength = 0
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSQL.Size = New System.Drawing.Size(518, 117)
        Me.txtSQL.TabIndex = 19
        '
        'cmdExecute
        '
        Me.cmdExecute.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExecute.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExecute.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExecute.Location = New System.Drawing.Point(380, 161)
        Me.cmdExecute.Name = "cmdExecute"
        Me.cmdExecute.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExecute.Size = New System.Drawing.Size(110, 20)
        Me.cmdExecute.TabIndex = 24
        Me.cmdExecute.TabStop = False
        Me.cmdExecute.Text = "SQL &EXECUTE"
        Me.cmdExecute.UseVisualStyleBackColor = False
        '
        'cmdKopij
        '
        Me.cmdKopij.BackColor = System.Drawing.SystemColors.Control
        Me.cmdKopij.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdKopij.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdKopij.Image = CType(resources.GetObject("cmdKopij.Image"), System.Drawing.Image)
        Me.cmdKopij.Location = New System.Drawing.Point(527, 23)
        Me.cmdKopij.Name = "cmdKopij"
        Me.cmdKopij.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdKopij.Size = New System.Drawing.Size(80, 58)
        Me.cmdKopij.TabIndex = 21
        Me.cmdKopij.Text = "XML &Kopie"
        Me.cmdKopij.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdKopij.UseVisualStyleBackColor = False
        '
        'cmdSluiten
        '
        Me.cmdSluiten.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSluiten.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSluiten.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSluiten.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSluiten.Location = New System.Drawing.Point(526, 238)
        Me.cmdSluiten.Name = "cmdSluiten"
        Me.cmdSluiten.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSluiten.Size = New System.Drawing.Size(79, 20)
        Me.cmdSluiten.TabIndex = 22
        Me.cmdSluiten.TabStop = False
        Me.cmdSluiten.Text = "Sluiten"
        Me.cmdSluiten.UseVisualStyleBackColor = False
        '
        'cmdSQL
        '
        Me.cmdSQL.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSQL.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSQL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSQL.Location = New System.Drawing.Point(3, 160)
        Me.cmdSQL.Name = "cmdSQL"
        Me.cmdSQL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSQL.Size = New System.Drawing.Size(82, 20)
        Me.cmdSQL.TabIndex = 26
        Me.cmdSQL.TabStop = False
        Me.cmdSQL.Text = "SQL &SELECT"
        Me.cmdSQL.UseVisualStyleBackColor = False
        '
        'cmbVersie
        '
        Me.cmbVersie.BackColor = System.Drawing.SystemColors.Control
        Me.cmbVersie.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbVersie.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbVersie.Location = New System.Drawing.Point(526, 211)
        Me.cmbVersie.Name = "cmbVersie"
        Me.cmbVersie.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbVersie.Size = New System.Drawing.Size(80, 20)
        Me.cmbVersie.TabIndex = 23
        Me.cmbVersie.TabStop = False
        Me.cmbVersie.Text = "&Versie"
        Me.cmbVersie.UseVisualStyleBackColor = False
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
        'msfSQL
        '
        Me.msfSQL.AllowUserToAddRows = False
        Me.msfSQL.AllowUserToDeleteRows = False
        Me.msfSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.msfSQL.Location = New System.Drawing.Point(3, 4)
        Me.msfSQL.Name = "msfSQL"
        Me.msfSQL.ReadOnly = True
        Me.msfSQL.Size = New System.Drawing.Size(518, 150)
        Me.msfSQL.TabIndex = 88
        '
        'LBDatabase
        '
        Me.LBDatabase.Dock = System.Windows.Forms.DockStyle.Right
        Me.LBDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBDatabase.FormattingEnabled = True
        Me.LBDatabase.ItemHeight = 20
        Me.LBDatabase.Location = New System.Drawing.Point(613, 0)
        Me.LBDatabase.Name = "LBDatabase"
        Me.LBDatabase.Size = New System.Drawing.Size(196, 338)
        Me.LBDatabase.TabIndex = 89
        '
        'SqlOperations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 338)
        Me.Controls.Add(Me.LBDatabase)
        Me.Controls.Add(Me.msfSQL)
        Me.Controls.Add(Me.cmdBackup)
        Me.Controls.Add(Me.cmdNet1)
        Me.Controls.Add(Me.txtPLUS)
        Me.Controls.Add(Me.txtWaarde)
        Me.Controls.Add(Me.cbOperatie)
        Me.Controls.Add(Me.cbVelden)
        Me.Controls.Add(Me.cbSQLBevel)
        Me.Controls.Add(Me.cmdOpenXML)
        Me.Controls.Add(Me.cmdSelectWegschrijven)
        Me.Controls.Add(Me.cmbSelect)
        Me.Controls.Add(Me.txtSQL)
        Me.Controls.Add(Me.cmdExecute)
        Me.Controls.Add(Me.cmdKopij)
        Me.Controls.Add(Me.cmdSluiten)
        Me.Controls.Add(Me.cmdSQL)
        Me.Controls.Add(Me.cmbVersie)
        Me.Controls.Add(Me.lblRecordCount)
        Me.Name = "SqlOperations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSQLBewerkingen"
        CType(Me.msfSQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Public WithEvents cmdBackup As Button
    Public WithEvents cmdNet1 As Button
    Public WithEvents txtPLUS As TextBox
    Public WithEvents txtWaarde As TextBox
    Public WithEvents cbOperatie As ComboBox
    Public WithEvents cbVelden As ComboBox
    Public WithEvents cbSQLBevel As ComboBox
    Public WithEvents cmdOpenXML As Button
    Public WithEvents cmdSelectWegschrijven As Button
    Public WithEvents cmbSelect As ComboBox
    Public WithEvents txtSQL As TextBox
    Public WithEvents cmdExecute As Button
    Public WithEvents cmdKopij As Button
    Public WithEvents cmdSluiten As Button
    Public WithEvents cmdSQL As Button
    Public WithEvents cmbVersie As Button
    Public WithEvents lblRecordCount As Label
    Friend WithEvents msfSQL As DataGridView
    Friend WithEvents LBDatabase As ListBox
End Class
