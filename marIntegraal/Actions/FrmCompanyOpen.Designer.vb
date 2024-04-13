<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompanyOpen
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
        Me.onedriveButton = New System.Windows.Forms.Button()
        Me.serverdataRadioButton = New System.Windows.Forms.RadioButton()
        Me.localdataRadioButton = New System.Windows.Forms.RadioButton()
        Me.verwijderenButton = New System.Windows.Forms.Button()
        Me.locatieTextBox = New System.Windows.Forms.TextBox()
        Me.locatieButton = New System.Windows.Forms.Button()
        Me.bedrijvenListView = New System.Windows.Forms.ListView()
        Me.compactdatabaseButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sluitenButton = New System.Windows.Forms.Button()
        Me.datalocatieGroupBox = New System.Windows.Forms.GroupBox()
        Me.datalocatieGroupBox.SuspendLayout
        Me.SuspendLayout
        '
        'onedriveButton
        '
        Me.onedriveButton.BackColor = System.Drawing.SystemColors.Control
        Me.onedriveButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.onedriveButton.Location = New System.Drawing.Point(134, 207)
        Me.onedriveButton.Name = "onedriveButton"
        Me.onedriveButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.onedriveButton.Size = New System.Drawing.Size(105, 22)
        Me.onedriveButton.TabIndex = 20
        Me.onedriveButton.Text = "OneDrive BackUp"
        Me.onedriveButton.UseVisualStyleBackColor = False
        '
        'serverdataRadioButton
        '
        Me.serverdataRadioButton.BackColor = System.Drawing.SystemColors.Control
        Me.serverdataRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.serverdataRadioButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.serverdataRadioButton.Location = New System.Drawing.Point(410, 17)
        Me.serverdataRadioButton.Name = "serverdataRadioButton"
        Me.serverdataRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.serverdataRadioButton.Size = New System.Drawing.Size(69, 22)
        Me.serverdataRadioButton.TabIndex = 19
        Me.serverdataRadioButton.Text = "Server"
        Me.serverdataRadioButton.UseVisualStyleBackColor = False
        '
        'localdataRadioButton
        '
        Me.localdataRadioButton.BackColor = System.Drawing.SystemColors.Control
        Me.localdataRadioButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.localdataRadioButton.Location = New System.Drawing.Point(6, 17)
        Me.localdataRadioButton.Name = "localdataRadioButton"
        Me.localdataRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.localdataRadioButton.Size = New System.Drawing.Size(89, 22)
        Me.localdataRadioButton.TabIndex = 18
        Me.localdataRadioButton.Text = "Lokaal"
        Me.localdataRadioButton.UseVisualStyleBackColor = False
        '
        'verwijderenButton
        '
        Me.verwijderenButton.BackColor = System.Drawing.SystemColors.Control
        Me.verwijderenButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.verwijderenButton.Location = New System.Drawing.Point(244, 207)
        Me.verwijderenButton.Name = "verwijderenButton"
        Me.verwijderenButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.verwijderenButton.Size = New System.Drawing.Size(156, 22)
        Me.verwijderenButton.TabIndex = 17
        Me.verwijderenButton.TabStop = False
        Me.verwijderenButton.Text = "Verwijderen Mogelijk Maken.."
        Me.verwijderenButton.UseVisualStyleBackColor = False
        '
        'locatieTextBox
        '
        Me.locatieTextBox.AcceptsReturn = True
        Me.locatieTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.locatieTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.locatieTextBox.Enabled = False
        Me.locatieTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.locatieTextBox.Location = New System.Drawing.Point(8, 180)
        Me.locatieTextBox.MaxLength = 0
        Me.locatieTextBox.Name = "locatieTextBox"
        Me.locatieTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.locatieTextBox.Size = New System.Drawing.Size(449, 20)
        Me.locatieTextBox.TabIndex = 12
        '
        'locatieButton
        '
        Me.locatieButton.BackColor = System.Drawing.SystemColors.Control
        Me.locatieButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.locatieButton.Location = New System.Drawing.Point(464, 180)
        Me.locatieButton.Name = "locatieButton"
        Me.locatieButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.locatieButton.Size = New System.Drawing.Size(29, 21)
        Me.locatieButton.TabIndex = 13
        Me.locatieButton.TabStop = False
        Me.locatieButton.Text = "..."
        Me.locatieButton.UseVisualStyleBackColor = False
        '
        'bedrijvenListView
        '
        Me.bedrijvenListView.BackColor = System.Drawing.SystemColors.Window
        Me.bedrijvenListView.ForeColor = System.Drawing.SystemColors.WindowText
        Me.bedrijvenListView.FullRowSelect = True
        Me.bedrijvenListView.HideSelection = False
        Me.bedrijvenListView.Location = New System.Drawing.Point(8, 63)
        Me.bedrijvenListView.Name = "bedrijvenListView"
        Me.bedrijvenListView.Size = New System.Drawing.Size(485, 113)
        Me.bedrijvenListView.TabIndex = 11
        Me.bedrijvenListView.UseCompatibleStateImageBehavior = False
        Me.bedrijvenListView.View = System.Windows.Forms.View.Details
        '
        'compactdatabaseButton
        '
        Me.compactdatabaseButton.BackColor = System.Drawing.SystemColors.Control
        Me.compactdatabaseButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.compactdatabaseButton.Location = New System.Drawing.Point(8, 206)
        Me.compactdatabaseButton.Name = "compactdatabaseButton"
        Me.compactdatabaseButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.compactdatabaseButton.Size = New System.Drawing.Size(116, 22)
        Me.compactdatabaseButton.TabIndex = 14
        Me.compactdatabaseButton.TabStop = False
        Me.compactdatabaseButton.Text = "Database &Vernieuwen"
        Me.compactdatabaseButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(241, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 21
        '
        'sluitenButton
        '
        Me.sluitenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.sluitenButton.Location = New System.Drawing.Point(418, 207)
        Me.sluitenButton.Name = "sluitenButton"
        Me.sluitenButton.Size = New System.Drawing.Size(75, 23)
        Me.sluitenButton.TabIndex = 22
        Me.sluitenButton.TabStop = False
        Me.sluitenButton.Text = "Sluiten"
        Me.sluitenButton.UseVisualStyleBackColor = True
        '
        'datalocatieGroupBox
        '
        Me.datalocatieGroupBox.Controls.Add(Me.localdataRadioButton)
        Me.datalocatieGroupBox.Controls.Add(Me.serverdataRadioButton)
        Me.datalocatieGroupBox.Location = New System.Drawing.Point(8, 12)
        Me.datalocatieGroupBox.Name = "datalocatieGroupBox"
        Me.datalocatieGroupBox.Size = New System.Drawing.Size(485, 45)
        Me.datalocatieGroupBox.TabIndex = 23
        Me.datalocatieGroupBox.TabStop = False
        Me.datalocatieGroupBox.Text = "Database"
        '
        'frmBedrijfOpenen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.sluitenButton
        Me.ClientSize = New System.Drawing.Size(506, 239)
        Me.ControlBox = false
        Me.Controls.Add(Me.datalocatieGroupBox)
        Me.Controls.Add(Me.sluitenButton)
        Me.Controls.Add(Me.onedriveButton)
        Me.Controls.Add(Me.verwijderenButton)
        Me.Controls.Add(Me.locatieTextBox)
        Me.Controls.Add(Me.locatieButton)
        Me.Controls.Add(Me.bedrijvenListView)
        Me.Controls.Add(Me.compactdatabaseButton)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmBedrijfOpenen"
        Me.Text = "Bedrijf Openen"
        Me.datalocatieGroupBox.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Public WithEvents onedriveButton As Button
    Public WithEvents serverdataRadioButton As RadioButton
    Public WithEvents localdataRadioButton As RadioButton
    Public WithEvents verwijderenButton As Button
    Public WithEvents locatieTextBox As TextBox
    Public WithEvents locatieButton As Button
    Public WithEvents bedrijvenListView As ListView
    Public WithEvents compactdatabaseButton As Button
    Public WithEvents Label1 As Label
    Friend WithEvents sluitenButton As Button
    Friend WithEvents datalocatieGroupBox As GroupBox
End Class
