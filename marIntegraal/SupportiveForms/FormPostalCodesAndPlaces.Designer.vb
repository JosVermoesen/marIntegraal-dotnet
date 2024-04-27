<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPostalCodesAndPlaces
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
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.CbOrderBy = New System.Windows.Forms.ComboBox()
        Me.BtnForward = New System.Windows.Forms.Button()
        Me.BtnRenew = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnAccept = New System.Windows.Forms.Button()
        Me.MtbSearch = New System.Windows.Forms.MaskedTextBox()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(90, 121)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(466, 243)
        Me.DataGridView.TabIndex = 0
        Me.DataGridView.Visible = False
        '
        'CbOrderBy
        '
        Me.CbOrderBy.FormattingEnabled = True
        Me.CbOrderBy.Location = New System.Drawing.Point(12, 75)
        Me.CbOrderBy.Name = "CbOrderBy"
        Me.CbOrderBy.Size = New System.Drawing.Size(358, 21)
        Me.CbOrderBy.TabIndex = 1
        '
        'BtnForward
        '
        Me.BtnForward.BackColor = System.Drawing.SystemColors.Control
        Me.BtnForward.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnForward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnForward.Location = New System.Drawing.Point(298, 44)
        Me.BtnForward.Name = "BtnForward"
        Me.BtnForward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnForward.Size = New System.Drawing.Size(33, 25)
        Me.BtnForward.TabIndex = 20
        Me.BtnForward.Text = ">"
        Me.BtnForward.UseVisualStyleBackColor = False
        '
        'BtnRenew
        '
        Me.BtnRenew.BackColor = System.Drawing.SystemColors.Control
        Me.BtnRenew.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnRenew.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnRenew.Location = New System.Drawing.Point(376, 44)
        Me.BtnRenew.Name = "BtnRenew"
        Me.BtnRenew.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnRenew.Size = New System.Drawing.Size(84, 25)
        Me.BtnRenew.TabIndex = 21
        Me.BtnRenew.TabStop = False
        Me.BtnRenew.Text = "&Hernieuw"
        Me.BtnRenew.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnBack.Location = New System.Drawing.Point(51, 44)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnBack.Size = New System.Drawing.Size(33, 25)
        Me.BtnBack.TabIndex = 19
        Me.BtnBack.Text = "<"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'BtnAccept
        '
        Me.BtnAccept.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAccept.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnAccept.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnAccept.Location = New System.Drawing.Point(379, 13)
        Me.BtnAccept.Name = "BtnAccept"
        Me.BtnAccept.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnAccept.Size = New System.Drawing.Size(81, 26)
        Me.BtnAccept.TabIndex = 17
        Me.BtnAccept.TabStop = False
        Me.BtnAccept.Text = "&Ok"
        Me.BtnAccept.UseVisualStyleBackColor = False
        '
        'MtbSearch
        '
        Me.MtbSearch.AllowPromptAsInput = False
        Me.MtbSearch.BackColor = System.Drawing.Color.White
        Me.MtbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MtbSearch.Location = New System.Drawing.Point(12, 12)
        Me.MtbSearch.Name = "MtbSearch"
        Me.MtbSearch.Size = New System.Drawing.Size(361, 26)
        Me.MtbSearch.TabIndex = 16
        '
        'LabelInfo
        '
        Me.LabelInfo.BackColor = System.Drawing.SystemColors.Control
        Me.LabelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelInfo.Location = New System.Drawing.Point(90, 44)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelInfo.Size = New System.Drawing.Size(202, 25)
        Me.LabelInfo.TabIndex = 22
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCancel.Location = New System.Drawing.Point(376, 12)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCancel.Size = New System.Drawing.Size(81, 26)
        Me.BtnCancel.TabIndex = 18
        Me.BtnCancel.TabStop = False
        Me.BtnCancel.Text = "Negeren"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnLast
        '
        Me.BtnLast.BackColor = System.Drawing.SystemColors.Control
        Me.BtnLast.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnLast.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnLast.Location = New System.Drawing.Point(337, 44)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnLast.Size = New System.Drawing.Size(33, 25)
        Me.BtnLast.TabIndex = 23
        Me.BtnLast.Text = "> |"
        Me.BtnLast.UseVisualStyleBackColor = False
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.SystemColors.Control
        Me.BtnFirst.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnFirst.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnFirst.Location = New System.Drawing.Point(12, 44)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnFirst.Size = New System.Drawing.Size(33, 25)
        Me.BtnFirst.TabIndex = 24
        Me.BtnFirst.Text = "| <"
        Me.BtnFirst.UseVisualStyleBackColor = False
        '
        'FormPostalCodesAndPlaces
        '
        Me.AcceptButton = Me.BtnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(475, 105)
        Me.Controls.Add(Me.BtnFirst)
        Me.Controls.Add(Me.BtnLast)
        Me.Controls.Add(Me.BtnForward)
        Me.Controls.Add(Me.BtnRenew)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnAccept)
        Me.Controls.Add(Me.MtbSearch)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.CbOrderBy)
        Me.Controls.Add(Me.DataGridView)
        Me.Name = "FormPostalCodesAndPlaces"
        Me.Text = "FormPostalCodesAndPlaces"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents CbOrderBy As ComboBox
    Public WithEvents BtnForward As Button
    Public WithEvents BtnRenew As Button
    Public WithEvents BtnBack As Button
    Public WithEvents BtnAccept As Button
    Public WithEvents MtbSearch As MaskedTextBox
    Public WithEvents LabelInfo As Label
    Public WithEvents BtnCancel As Button
    Public WithEvents BtnLast As Button
    Public WithEvents BtnFirst As Button
End Class
