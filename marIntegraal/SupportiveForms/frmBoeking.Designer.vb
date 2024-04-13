<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boeking
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
        Me.cmdNegeren = New System.Windows.Forms.Button()
        Me.cmdBoeken = New System.Windows.Forms.Button()
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
        Me.boekListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me._SSTab1_TabPage0.SuspendLayout()
        Me.SSTab1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdNegeren
        '
        Me.cmdNegeren.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNegeren.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNegeren.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdNegeren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNegeren.Location = New System.Drawing.Point(430, 4)
        Me.cmdNegeren.Name = "cmdNegeren"
        Me.cmdNegeren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNegeren.Size = New System.Drawing.Size(127, 25)
        Me.cmdNegeren.TabIndex = 6
        Me.cmdNegeren.TabStop = False
        Me.cmdNegeren.Text = "Boeking Terugzetten"
        Me.cmdNegeren.UseVisualStyleBackColor = False
        '
        'cmdBoeken
        '
        Me.cmdBoeken.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBoeken.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBoeken.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBoeken.Location = New System.Drawing.Point(295, 4)
        Me.cmdBoeken.Name = "cmdBoeken"
        Me.cmdBoeken.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBoeken.Size = New System.Drawing.Size(129, 25)
        Me.cmdBoeken.TabIndex = 5
        Me.cmdBoeken.TabStop = False
        Me.cmdBoeken.Text = "&Boeking laten doorgaan"
        Me.cmdBoeken.UseVisualStyleBackColor = False
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.boekListView)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(575, 183)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Journaal"
        '
        'boekListView
        '
        Me.boekListView.BackColor = System.Drawing.SystemColors.Window
        Me.boekListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.boekListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.boekListView.ForeColor = System.Drawing.SystemColors.WindowText
        Me.boekListView.FullRowSelect = True
        Me.boekListView.HideSelection = False
        Me.boekListView.Location = New System.Drawing.Point(0, 0)
        Me.boekListView.Name = "boekListView"
        Me.boekListView.Size = New System.Drawing.Size(575, 183)
        Me.boekListView.TabIndex = 0
        Me.boekListView.UseCompatibleStateImageBehavior = False
        Me.boekListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Rekening"
        Me.ColumnHeader1.Width = 71
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Boekingsomschrijving"
        Me.ColumnHeader2.Width = 187
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "EUR Debet"
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "EUR Credit"
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "BEF Debet"
        Me.ColumnHeader5.Width = 74
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "BEF Credit"
        Me.ColumnHeader6.Width = 71
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(575, 183)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Document"
        '
        'SSTab1
        '
        Me.SSTab1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTab1.Location = New System.Drawing.Point(10, 35)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 0
        Me.SSTab1.Size = New System.Drawing.Size(583, 209)
        Me.SSTab1.TabIndex = 4
        '
        'Boeking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdNegeren
        Me.ClientSize = New System.Drawing.Size(595, 248)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdNegeren)
        Me.Controls.Add(Me.cmdBoeken)
        Me.Controls.Add(Me.SSTab1)
        Me.Name = "Boeking"
        Me.Text = "frmBoeking"
        Me._SSTab1_TabPage0.ResumeLayout(False)
        Me.SSTab1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents cmdNegeren As Button
    Public WithEvents cmdBoeken As Button
    Public WithEvents _SSTab1_TabPage0 As TabPage
    Public WithEvents _SSTab1_TabPage1 As TabPage
    Public WithEvents SSTab1 As TabControl
    Public WithEvents boekListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
End Class
