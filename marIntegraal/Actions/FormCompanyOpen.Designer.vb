<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompanyOpen
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
        Me.BtnOneDriveBackup = New System.Windows.Forms.Button()
        Me.RbServerData = New System.Windows.Forms.RadioButton()
        Me.RbLocalData = New System.Windows.Forms.RadioButton()
        Me.BtnMakeDeletePossible = New System.Windows.Forms.Button()
        Me.TbDataLocation = New System.Windows.Forms.TextBox()
        Me.BtnToggle = New System.Windows.Forms.Button()
        Me.LvCompanies = New System.Windows.Forms.ListView()
        Me.BtnCompactDatabase = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.datalocatieGroupBox = New System.Windows.Forms.GroupBox()
        Me.datalocatieGroupBox.SuspendLayout
        Me.SuspendLayout
        '
        'BtnOneDriveBackup
        '
        Me.BtnOneDriveBackup.BackColor = System.Drawing.SystemColors.Control
        Me.BtnOneDriveBackup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnOneDriveBackup.Location = New System.Drawing.Point(134, 207)
        Me.BtnOneDriveBackup.Name = "BtnOneDriveBackup"
        Me.BtnOneDriveBackup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnOneDriveBackup.Size = New System.Drawing.Size(105, 22)
        Me.BtnOneDriveBackup.TabIndex = 20
        Me.BtnOneDriveBackup.Text = "OneDrive BackUp"
        Me.BtnOneDriveBackup.UseVisualStyleBackColor = False
        '
        'RbServerData
        '
        Me.RbServerData.BackColor = System.Drawing.SystemColors.Control
        Me.RbServerData.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RbServerData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RbServerData.Location = New System.Drawing.Point(410, 17)
        Me.RbServerData.Name = "RbServerData"
        Me.RbServerData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RbServerData.Size = New System.Drawing.Size(69, 22)
        Me.RbServerData.TabIndex = 19
        Me.RbServerData.Text = "Server"
        Me.RbServerData.UseVisualStyleBackColor = False
        '
        'RbLocalData
        '
        Me.RbLocalData.BackColor = System.Drawing.SystemColors.Control
        Me.RbLocalData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RbLocalData.Location = New System.Drawing.Point(6, 17)
        Me.RbLocalData.Name = "RbLocalData"
        Me.RbLocalData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RbLocalData.Size = New System.Drawing.Size(89, 22)
        Me.RbLocalData.TabIndex = 18
        Me.RbLocalData.Text = "Lokaal"
        Me.RbLocalData.UseVisualStyleBackColor = False
        '
        'BtnMakeDeletePossible
        '
        Me.BtnMakeDeletePossible.BackColor = System.Drawing.SystemColors.Control
        Me.BtnMakeDeletePossible.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnMakeDeletePossible.Location = New System.Drawing.Point(244, 207)
        Me.BtnMakeDeletePossible.Name = "BtnMakeDeletePossible"
        Me.BtnMakeDeletePossible.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnMakeDeletePossible.Size = New System.Drawing.Size(156, 22)
        Me.BtnMakeDeletePossible.TabIndex = 17
        Me.BtnMakeDeletePossible.TabStop = False
        Me.BtnMakeDeletePossible.Text = "Verwijderen Mogelijk Maken.."
        Me.BtnMakeDeletePossible.UseVisualStyleBackColor = False
        '
        'TbDataLocation
        '
        Me.TbDataLocation.AcceptsReturn = True
        Me.TbDataLocation.BackColor = System.Drawing.SystemColors.Window
        Me.TbDataLocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbDataLocation.Enabled = False
        Me.TbDataLocation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TbDataLocation.Location = New System.Drawing.Point(8, 180)
        Me.TbDataLocation.MaxLength = 0
        Me.TbDataLocation.Name = "TbDataLocation"
        Me.TbDataLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TbDataLocation.Size = New System.Drawing.Size(449, 20)
        Me.TbDataLocation.TabIndex = 12
        '
        'BtnToggle
        '
        Me.BtnToggle.BackColor = System.Drawing.SystemColors.Control
        Me.BtnToggle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnToggle.Location = New System.Drawing.Point(464, 180)
        Me.BtnToggle.Name = "BtnToggle"
        Me.BtnToggle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnToggle.Size = New System.Drawing.Size(29, 21)
        Me.BtnToggle.TabIndex = 13
        Me.BtnToggle.TabStop = False
        Me.BtnToggle.Text = "..."
        Me.BtnToggle.UseVisualStyleBackColor = False
        '
        'LvCompanies
        '
        Me.LvCompanies.BackColor = System.Drawing.SystemColors.Window
        Me.LvCompanies.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LvCompanies.FullRowSelect = True
        Me.LvCompanies.HideSelection = False
        Me.LvCompanies.Location = New System.Drawing.Point(8, 63)
        Me.LvCompanies.Name = "LvCompanies"
        Me.LvCompanies.Size = New System.Drawing.Size(485, 113)
        Me.LvCompanies.TabIndex = 11
        Me.LvCompanies.UseCompatibleStateImageBehavior = False
        Me.LvCompanies.View = System.Windows.Forms.View.Details
        '
        'BtnCompactDatabase
        '
        Me.BtnCompactDatabase.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCompactDatabase.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCompactDatabase.Location = New System.Drawing.Point(8, 206)
        Me.BtnCompactDatabase.Name = "BtnCompactDatabase"
        Me.BtnCompactDatabase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCompactDatabase.Size = New System.Drawing.Size(116, 22)
        Me.BtnCompactDatabase.TabIndex = 14
        Me.BtnCompactDatabase.TabStop = False
        Me.BtnCompactDatabase.Text = "Database &Vernieuwen"
        Me.BtnCompactDatabase.UseVisualStyleBackColor = False
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
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(418, 207)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 22
        Me.BtnCancel.TabStop = False
        Me.BtnCancel.Text = "Sluiten"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'datalocatieGroupBox
        '
        Me.datalocatieGroupBox.Controls.Add(Me.RbLocalData)
        Me.datalocatieGroupBox.Controls.Add(Me.RbServerData)
        Me.datalocatieGroupBox.Location = New System.Drawing.Point(8, 12)
        Me.datalocatieGroupBox.Name = "datalocatieGroupBox"
        Me.datalocatieGroupBox.Size = New System.Drawing.Size(485, 45)
        Me.datalocatieGroupBox.TabIndex = 23
        Me.datalocatieGroupBox.TabStop = False
        Me.datalocatieGroupBox.Text = "Database"
        '
        'FormCompanyOpen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(506, 239)
        Me.ControlBox = False
        Me.Controls.Add(Me.datalocatieGroupBox)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOneDriveBackup)
        Me.Controls.Add(Me.BtnMakeDeletePossible)
        Me.Controls.Add(Me.TbDataLocation)
        Me.Controls.Add(Me.BtnToggle)
        Me.Controls.Add(Me.LvCompanies)
        Me.Controls.Add(Me.BtnCompactDatabase)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCompanyOpen"
        Me.Text = "Bedrijf Openen"
        Me.datalocatieGroupBox.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Public WithEvents BtnOneDriveBackup As Button
    Public WithEvents RbServerData As RadioButton
    Public WithEvents RbLocalData As RadioButton
    Public WithEvents BtnMakeDeletePossible As Button
    Public WithEvents TbDataLocation As TextBox
    Public WithEvents BtnToggle As Button
    Public WithEvents LvCompanies As ListView
    Public WithEvents BtnCompactDatabase As Button
    Public WithEvents Label1 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents datalocatieGroupBox As GroupBox
End Class
