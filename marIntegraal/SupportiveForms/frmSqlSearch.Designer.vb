<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SqlSearch
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
        Me.rtbSQLTekst = New System.Windows.Forms.RichTextBox()
        Me.zoekenButton = New System.Windows.Forms.Button()
        Me.txtTeZoeken = New System.Windows.Forms.TextBox()
        Me.recordsLabel = New System.Windows.Forms.Label()
        Me.zoekLabel = New System.Windows.Forms.Label()
        Me.sorteringComboBox = New System.Windows.Forms.ComboBox()
        Me.sluitenButton = New System.Windows.Forms.Button()
        Me.sqlresultListView = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'rtbSQLTekst
        '
        Me.rtbSQLTekst.BackColor = System.Drawing.Color.White
        Me.rtbSQLTekst.Location = New System.Drawing.Point(12, 253)
        Me.rtbSQLTekst.Name = "rtbSQLTekst"
        Me.rtbSQLTekst.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtbSQLTekst.Size = New System.Drawing.Size(425, 78)
        Me.rtbSQLTekst.TabIndex = 5
        Me.rtbSQLTekst.TabStop = false
        Me.rtbSQLTekst.Text = ""
        '
        'zoekenButton
        '
        Me.zoekenButton.BackColor = System.Drawing.SystemColors.Control
        Me.zoekenButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.zoekenButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.zoekenButton.Location = New System.Drawing.Point(353, 5)
        Me.zoekenButton.Name = "zoekenButton"
        Me.zoekenButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.zoekenButton.Size = New System.Drawing.Size(81, 25)
        Me.zoekenButton.TabIndex = 18
        Me.zoekenButton.TabStop = false
        Me.zoekenButton.Text = "Zoeken"
        Me.zoekenButton.UseVisualStyleBackColor = false
        '
        'txtTeZoeken
        '
        Me.txtTeZoeken.AcceptsReturn = true
        Me.txtTeZoeken.BackColor = System.Drawing.Color.White
        Me.txtTeZoeken.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTeZoeken.ForeColor = System.Drawing.Color.Black
        Me.txtTeZoeken.Location = New System.Drawing.Point(94, 10)
        Me.txtTeZoeken.MaxLength = 0
        Me.txtTeZoeken.Name = "txtTeZoeken"
        Me.txtTeZoeken.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTeZoeken.Size = New System.Drawing.Size(253, 20)
        Me.txtTeZoeken.TabIndex = 1
        '
        'recordsLabel
        '
        Me.recordsLabel.BackColor = System.Drawing.SystemColors.Control
        Me.recordsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.recordsLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.recordsLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.recordsLabel.Location = New System.Drawing.Point(443, 5)
        Me.recordsLabel.Name = "recordsLabel"
        Me.recordsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.recordsLabel.Size = New System.Drawing.Size(81, 21)
        Me.recordsLabel.TabIndex = 20
        Me.recordsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'zoekLabel
        '
        Me.zoekLabel.BackColor = System.Drawing.SystemColors.Control
        Me.zoekLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.zoekLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.zoekLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.zoekLabel.Location = New System.Drawing.Point(12, 9)
        Me.zoekLabel.Name = "zoekLabel"
        Me.zoekLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.zoekLabel.Size = New System.Drawing.Size(65, 21)
        Me.zoekLabel.TabIndex = 0
        Me.zoekLabel.Text = " &Zoek zoals"
        '
        'sorteringComboBox
        '
        Me.sorteringComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sorteringComboBox.FormattingEnabled = true
        Me.sorteringComboBox.Location = New System.Drawing.Point(94, 38)
        Me.sorteringComboBox.Name = "sorteringComboBox"
        Me.sorteringComboBox.Size = New System.Drawing.Size(428, 21)
        Me.sorteringComboBox.TabIndex = 4
        '
        'sluitenButton
        '
        Me.sluitenButton.BackColor = System.Drawing.SystemColors.Control
        Me.sluitenButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.sluitenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.sluitenButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.sluitenButton.Location = New System.Drawing.Point(443, 306)
        Me.sluitenButton.Name = "sluitenButton"
        Me.sluitenButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.sluitenButton.Size = New System.Drawing.Size(81, 25)
        Me.sluitenButton.TabIndex = 17
        Me.sluitenButton.TabStop = false
        Me.sluitenButton.Text = "Sluiten"
        Me.sluitenButton.UseVisualStyleBackColor = false
        '
        'sqlresultListView
        '
        Me.sqlresultListView.BackColor = System.Drawing.SystemColors.Window
        Me.sqlresultListView.ForeColor = System.Drawing.SystemColors.WindowText
        Me.sqlresultListView.FullRowSelect = true
        Me.sqlresultListView.HideSelection = false
        Me.sqlresultListView.Location = New System.Drawing.Point(12, 65)
        Me.sqlresultListView.Name = "sqlresultListView"
        Me.sqlresultListView.Size = New System.Drawing.Size(512, 182)
        Me.sqlresultListView.TabIndex = 2
        Me.sqlresultListView.UseCompatibleStateImageBehavior = false
        Me.sqlresultListView.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = " &Sorteren"
        '
        'SqlSearch
        '
        Me.AcceptButton = Me.zoekenButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.sluitenButton
        Me.ClientSize = New System.Drawing.Size(534, 343)
        Me.ControlBox = false
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sqlresultListView)
        Me.Controls.Add(Me.sorteringComboBox)
        Me.Controls.Add(Me.rtbSQLTekst)
        Me.Controls.Add(Me.zoekenButton)
        Me.Controls.Add(Me.sluitenButton)
        Me.Controls.Add(Me.txtTeZoeken)
        Me.Controls.Add(Me.recordsLabel)
        Me.Controls.Add(Me.zoekLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SqlSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ANSI-92 SQL GeSELECTeerd zoeken"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Public WithEvents rtbSQLTekst As RichTextBox
    Public WithEvents zoekenButton As Button
    Public WithEvents txtTeZoeken As TextBox
    Public WithEvents recordsLabel As Label
    Public WithEvents zoekLabel As Label
    Friend WithEvents sorteringComboBox As ComboBox
    Public WithEvents sluitenButton As Button
    Public WithEvents sqlresultListView As ListView
    Public WithEvents Label1 As Label
End Class
