<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBookingControl
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
        Me.BtnCancelTransaction = New System.Windows.Forms.Button()
        Me.BtnCommitTransaction = New System.Windows.Forms.Button()
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
        Me.LvReadyToBook = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TcSquareControle = New System.Windows.Forms.TabControl()
        Me._SSTab1_TabPage0.SuspendLayout()
        Me.TcSquareControle.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCancelTransaction
        '
        Me.BtnCancelTransaction.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCancelTransaction.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnCancelTransaction.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelTransaction.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCancelTransaction.Location = New System.Drawing.Point(430, 4)
        Me.BtnCancelTransaction.Name = "BtnCancelTransaction"
        Me.BtnCancelTransaction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCancelTransaction.Size = New System.Drawing.Size(127, 25)
        Me.BtnCancelTransaction.TabIndex = 6
        Me.BtnCancelTransaction.TabStop = False
        Me.BtnCancelTransaction.Text = "Boeking Terugzetten"
        Me.BtnCancelTransaction.UseVisualStyleBackColor = False
        '
        'BtnCommitTransaction
        '
        Me.BtnCommitTransaction.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCommitTransaction.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnCommitTransaction.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCommitTransaction.Location = New System.Drawing.Point(295, 4)
        Me.BtnCommitTransaction.Name = "BtnCommitTransaction"
        Me.BtnCommitTransaction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCommitTransaction.Size = New System.Drawing.Size(129, 25)
        Me.BtnCommitTransaction.TabIndex = 5
        Me.BtnCommitTransaction.TabStop = False
        Me.BtnCommitTransaction.Text = "&Boeking laten doorgaan"
        Me.BtnCommitTransaction.UseVisualStyleBackColor = False
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.LvReadyToBook)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(575, 183)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Journaal"
        '
        'LvReadyToBook
        '
        Me.LvReadyToBook.BackColor = System.Drawing.SystemColors.Window
        Me.LvReadyToBook.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.LvReadyToBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvReadyToBook.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LvReadyToBook.FullRowSelect = True
        Me.LvReadyToBook.HideSelection = False
        Me.LvReadyToBook.Location = New System.Drawing.Point(0, 0)
        Me.LvReadyToBook.Name = "LvReadyToBook"
        Me.LvReadyToBook.Size = New System.Drawing.Size(575, 183)
        Me.LvReadyToBook.TabIndex = 0
        Me.LvReadyToBook.UseCompatibleStateImageBehavior = False
        Me.LvReadyToBook.View = System.Windows.Forms.View.Details
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
        'TcSquareControle
        '
        Me.TcSquareControle.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TcSquareControle.Controls.Add(Me._SSTab1_TabPage0)
        Me.TcSquareControle.ItemSize = New System.Drawing.Size(42, 18)
        Me.TcSquareControle.Location = New System.Drawing.Point(12, 35)
        Me.TcSquareControle.Name = "TcSquareControle"
        Me.TcSquareControle.SelectedIndex = 0
        Me.TcSquareControle.Size = New System.Drawing.Size(583, 209)
        Me.TcSquareControle.TabIndex = 4
        '
        'FormBookingControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancelTransaction
        Me.ClientSize = New System.Drawing.Size(595, 248)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCancelTransaction)
        Me.Controls.Add(Me.BtnCommitTransaction)
        Me.Controls.Add(Me.TcSquareControle)
        Me.Name = "FormBookingControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Booking Square Control"
        Me._SSTab1_TabPage0.ResumeLayout(False)
        Me.TcSquareControle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents BtnCancelTransaction As Button
    Public WithEvents BtnCommitTransaction As Button
    Public WithEvents _SSTab1_TabPage0 As TabPage
    Public WithEvents TcSquareControle As TabControl
    Public WithEvents LvReadyToBook As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
End Class
