<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class xLog
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
        Me.Annuleren = New System.Windows.Forms.Button()
        Me.Afsluiten = New System.Windows.Forms.Button()
        Me.WijzigenLijn = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.defaultTabPage = New System.Windows.Forms.TabPage()
        Me.X = New System.Windows.Forms.ListView()
        Me.bijlageTabPage = New System.Windows.Forms.TabPage()
        Me.selectonlyButton = New System.Windows.Forms.Button()
        Me.TabControl.SuspendLayout()
        Me.defaultTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'Annuleren
        '
        Me.Annuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Annuleren.Location = New System.Drawing.Point(104, 354)
        Me.Annuleren.Name = "Annuleren"
        Me.Annuleren.Size = New System.Drawing.Size(75, 23)
        Me.Annuleren.TabIndex = 0
        Me.Annuleren.TabStop = False
        Me.Annuleren.Text = "Annuleren"
        Me.Annuleren.UseVisualStyleBackColor = True
        '
        'Afsluiten
        '
        Me.Afsluiten.BackColor = System.Drawing.SystemColors.Control
        Me.Afsluiten.Cursor = System.Windows.Forms.Cursors.Default
        Me.Afsluiten.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Afsluiten.Location = New System.Drawing.Point(5, 354)
        Me.Afsluiten.Name = "Afsluiten"
        Me.Afsluiten.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Afsluiten.Size = New System.Drawing.Size(94, 22)
        Me.Afsluiten.TabIndex = 1
        Me.Afsluiten.Text = "Ok"
        Me.Afsluiten.UseVisualStyleBackColor = False
        '
        'WijzigenLijn
        '
        Me.WijzigenLijn.BackColor = System.Drawing.SystemColors.Control
        Me.WijzigenLijn.Cursor = System.Windows.Forms.Cursors.Default
        Me.WijzigenLijn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WijzigenLijn.Location = New System.Drawing.Point(185, 354)
        Me.WijzigenLijn.Name = "WijzigenLijn"
        Me.WijzigenLijn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WijzigenLijn.Size = New System.Drawing.Size(94, 22)
        Me.WijzigenLijn.TabIndex = 1
        Me.WijzigenLijn.TabStop = False
        Me.WijzigenLijn.Text = "Wijzigen"
        Me.WijzigenLijn.UseVisualStyleBackColor = False
        '
        'TabControl
        '
        Me.TabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl.Controls.Add(Me.defaultTabPage)
        Me.TabControl.Controls.Add(Me.bijlageTabPage)
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(487, 343)
        Me.TabControl.TabIndex = 0
        Me.TabControl.TabStop = False
        '
        'defaultTabPage
        '
        Me.defaultTabPage.Controls.Add(Me.X)
        Me.defaultTabPage.Location = New System.Drawing.Point(4, 4)
        Me.defaultTabPage.Name = "defaultTabPage"
        Me.defaultTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.defaultTabPage.Size = New System.Drawing.Size(479, 317)
        Me.defaultTabPage.TabIndex = 0
        Me.defaultTabPage.Text = "Default"
        Me.defaultTabPage.UseVisualStyleBackColor = True
        '
        'X
        '
        Me.X.BackColor = System.Drawing.Color.Honeydew
        Me.X.Dock = System.Windows.Forms.DockStyle.Fill
        Me.X.ForeColor = System.Drawing.SystemColors.WindowText
        Me.X.FullRowSelect = True
        Me.X.HideSelection = False
        Me.X.Location = New System.Drawing.Point(3, 3)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(473, 311)
        Me.X.TabIndex = 0
        Me.X.UseCompatibleStateImageBehavior = False
        Me.X.View = System.Windows.Forms.View.Details
        '
        'bijlageTabPage
        '
        Me.bijlageTabPage.Location = New System.Drawing.Point(4, 4)
        Me.bijlageTabPage.Name = "bijlageTabPage"
        Me.bijlageTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.bijlageTabPage.Size = New System.Drawing.Size(479, 317)
        Me.bijlageTabPage.TabIndex = 1
        Me.bijlageTabPage.Text = "Bijlage"
        Me.bijlageTabPage.UseVisualStyleBackColor = True
        '
        'selectonlyButton
        '
        Me.selectonlyButton.BackColor = System.Drawing.SystemColors.Control
        Me.selectonlyButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.selectonlyButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.selectonlyButton.Location = New System.Drawing.Point(5, 354)
        Me.selectonlyButton.Name = "selectonlyButton"
        Me.selectonlyButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.selectonlyButton.Size = New System.Drawing.Size(94, 22)
        Me.selectonlyButton.TabIndex = 2
        Me.selectonlyButton.Text = "Ok"
        Me.selectonlyButton.UseVisualStyleBackColor = False
        Me.selectonlyButton.Visible = False
        '
        'xLog
        '
        Me.AcceptButton = Me.WijzigenLijn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Annuleren
        Me.ClientSize = New System.Drawing.Size(490, 382)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.Afsluiten)
        Me.Controls.Add(Me.WijzigenLijn)
        Me.Controls.Add(Me.Annuleren)
        Me.Controls.Add(Me.selectonlyButton)
        Me.Name = "xLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Log"
        Me.TabControl.ResumeLayout(False)
        Me.defaultTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Annuleren As Button
    Public WithEvents Afsluiten As Button
    Public WithEvents WijzigenLijn As Button
    Friend WithEvents TabControl As TabControl
    Friend WithEvents defaultTabPage As TabPage
    Public WithEvents X As ListView
    Friend WithEvents bijlageTabPage As TabPage
    Public WithEvents selectonlyButton As Button
End Class
