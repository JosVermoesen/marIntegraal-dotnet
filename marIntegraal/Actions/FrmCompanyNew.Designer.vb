<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompanyNew
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
        Me.components = New System.ComponentModel.Container()
        Me.txtStartMaand = New System.Windows.Forms.TextBox()
        Me._TypeBoekjaar_3 = New System.Windows.Forms.RadioButton()
        Me.Maanden = New System.Windows.Forms.TextBox()
        Me.CmbBedrijfsType = New System.Windows.Forms.ComboBox()
        Me.BedrijfsNaam = New System.Windows.Forms.TextBox()
        Me.Installeren = New System.Windows.Forms.Button()
        Me.Negeren = New System.Windows.Forms.Button()
        Me.Makelaar = New System.Windows.Forms.CheckBox()
        Me.Boekjaar = New System.Windows.Forms.TextBox()
        Me._TypeBoekjaar_1 = New System.Windows.Forms.RadioButton()
        Me._TypeBoekjaar_2 = New System.Windows.Forms.RadioButton()
        Me._TypeBoekjaar_0 = New System.Windows.Forms.RadioButton()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me._Label1_6 = New System.Windows.Forms.Label()
        Me._Label1_5 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblInOntwikkeling = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'txtStartMaand
        '
        Me.txtStartMaand.AcceptsReturn = true
        Me.txtStartMaand.BackColor = System.Drawing.Color.White
        Me.txtStartMaand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStartMaand.Enabled = false
        Me.txtStartMaand.ForeColor = System.Drawing.Color.Black
        Me.txtStartMaand.Location = New System.Drawing.Point(133, 110)
        Me.txtStartMaand.MaxLength = 0
        Me.txtStartMaand.Name = "txtStartMaand"
        Me.txtStartMaand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStartMaand.Size = New System.Drawing.Size(56, 20)
        Me.txtStartMaand.TabIndex = 51
        Me.txtStartMaand.Text = "01/01"
        '
        '_TypeBoekjaar_3
        '
        Me._TypeBoekjaar_3.BackColor = System.Drawing.SystemColors.Control
        Me._TypeBoekjaar_3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._TypeBoekjaar_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._TypeBoekjaar_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._TypeBoekjaar_3.Location = New System.Drawing.Point(61, 110)
        Me._TypeBoekjaar_3.Name = "_TypeBoekjaar_3"
        Me._TypeBoekjaar_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TypeBoekjaar_3.Size = New System.Drawing.Size(61, 17)
        Me._TypeBoekjaar_3.TabIndex = 50
        Me._TypeBoekjaar_3.Text = "Andere"
        Me._TypeBoekjaar_3.UseVisualStyleBackColor = false
        '
        'Maanden
        '
        Me.Maanden.AcceptsReturn = true
        Me.Maanden.BackColor = System.Drawing.Color.White
        Me.Maanden.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Maanden.ForeColor = System.Drawing.Color.Black
        Me.Maanden.Location = New System.Drawing.Point(193, 68)
        Me.Maanden.MaxLength = 0
        Me.Maanden.Name = "Maanden"
        Me.Maanden.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Maanden.Size = New System.Drawing.Size(31, 20)
        Me.Maanden.TabIndex = 49
        Me.Maanden.Text = "12"
        '
        'CmbBedrijfsType
        '
        Me.CmbBedrijfsType.BackColor = System.Drawing.Color.White
        Me.CmbBedrijfsType.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbBedrijfsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBedrijfsType.ForeColor = System.Drawing.Color.Black
        Me.CmbBedrijfsType.Location = New System.Drawing.Point(261, 88)
        Me.CmbBedrijfsType.Name = "CmbBedrijfsType"
        Me.CmbBedrijfsType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbBedrijfsType.Size = New System.Drawing.Size(185, 21)
        Me.CmbBedrijfsType.TabIndex = 47
        Me.CmbBedrijfsType.TabStop = false
        '
        'BedrijfsNaam
        '
        Me.BedrijfsNaam.AcceptsReturn = true
        Me.BedrijfsNaam.BackColor = System.Drawing.Color.White
        Me.BedrijfsNaam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BedrijfsNaam.ForeColor = System.Drawing.Color.Black
        Me.BedrijfsNaam.Location = New System.Drawing.Point(13, 26)
        Me.BedrijfsNaam.MaxLength = 0
        Me.BedrijfsNaam.Name = "BedrijfsNaam"
        Me.BedrijfsNaam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BedrijfsNaam.Size = New System.Drawing.Size(333, 20)
        Me.BedrijfsNaam.TabIndex = 35
        '
        'Installeren
        '
        Me.Installeren.BackColor = System.Drawing.SystemColors.Control
        Me.Installeren.Cursor = System.Windows.Forms.Cursors.Default
        Me.Installeren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Installeren.Location = New System.Drawing.Point(353, 8)
        Me.Installeren.Name = "Installeren"
        Me.Installeren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Installeren.Size = New System.Drawing.Size(93, 24)
        Me.Installeren.TabIndex = 38
        Me.Installeren.Text = "&Installeren"
        Me.Installeren.UseVisualStyleBackColor = false
        '
        'Negeren
        '
        Me.Negeren.BackColor = System.Drawing.SystemColors.Control
        Me.Negeren.Cursor = System.Windows.Forms.Cursors.Default
        Me.Negeren.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Negeren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Negeren.Location = New System.Drawing.Point(353, 36)
        Me.Negeren.Name = "Negeren"
        Me.Negeren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Negeren.Size = New System.Drawing.Size(92, 24)
        Me.Negeren.TabIndex = 42
        Me.Negeren.TabStop = false
        Me.Negeren.Text = "Sluiten"
        Me.Negeren.UseVisualStyleBackColor = false
        '
        'Makelaar
        '
        Me.Makelaar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Makelaar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Makelaar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Makelaar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.Makelaar.Location = New System.Drawing.Point(279, 70)
        Me.Makelaar.Name = "Makelaar"
        Me.Makelaar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Makelaar.Size = New System.Drawing.Size(167, 16)
        Me.Makelaar.TabIndex = 39
        Me.Makelaar.Text = "&Verzekeringsbemiddelaar"
        Me.Makelaar.UseVisualStyleBackColor = false
        '
        'Boekjaar
        '
        Me.Boekjaar.AcceptsReturn = true
        Me.Boekjaar.BackColor = System.Drawing.Color.White
        Me.Boekjaar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Boekjaar.ForeColor = System.Drawing.Color.Black
        Me.Boekjaar.Location = New System.Drawing.Point(133, 68)
        Me.Boekjaar.MaxLength = 0
        Me.Boekjaar.Name = "Boekjaar"
        Me.Boekjaar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Boekjaar.Size = New System.Drawing.Size(56, 20)
        Me.Boekjaar.TabIndex = 37
        '
        '_TypeBoekjaar_1
        '
        Me._TypeBoekjaar_1.BackColor = System.Drawing.SystemColors.Control
        Me._TypeBoekjaar_1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._TypeBoekjaar_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._TypeBoekjaar_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._TypeBoekjaar_1.Location = New System.Drawing.Point(69, 74)
        Me._TypeBoekjaar_1.Name = "_TypeBoekjaar_1"
        Me._TypeBoekjaar_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TypeBoekjaar_1.Size = New System.Drawing.Size(53, 17)
        Me._TypeBoekjaar_1.TabIndex = 40
        Me._TypeBoekjaar_1.Text = "01/0&7"
        Me._TypeBoekjaar_1.UseVisualStyleBackColor = false
        '
        '_TypeBoekjaar_2
        '
        Me._TypeBoekjaar_2.BackColor = System.Drawing.SystemColors.Control
        Me._TypeBoekjaar_2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._TypeBoekjaar_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._TypeBoekjaar_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._TypeBoekjaar_2.Location = New System.Drawing.Point(69, 94)
        Me._TypeBoekjaar_2.Name = "_TypeBoekjaar_2"
        Me._TypeBoekjaar_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TypeBoekjaar_2.Size = New System.Drawing.Size(53, 17)
        Me._TypeBoekjaar_2.TabIndex = 41
        Me._TypeBoekjaar_2.Text = "01/1&0"
        Me._TypeBoekjaar_2.UseVisualStyleBackColor = false
        '
        '_TypeBoekjaar_0
        '
        Me._TypeBoekjaar_0.BackColor = System.Drawing.SystemColors.Control
        Me._TypeBoekjaar_0.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me._TypeBoekjaar_0.Checked = true
        Me._TypeBoekjaar_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._TypeBoekjaar_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._TypeBoekjaar_0.Location = New System.Drawing.Point(9, 54)
        Me._TypeBoekjaar_0.Name = "_TypeBoekjaar_0"
        Me._TypeBoekjaar_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TypeBoekjaar_0.Size = New System.Drawing.Size(113, 17)
        Me._TypeBoekjaar_0.TabIndex = 36
        Me._TypeBoekjaar_0.TabStop = true
        Me._TypeBoekjaar_0.Text = "01/0&1 aanvangend"
        Me._TypeBoekjaar_0.UseVisualStyleBackColor = false
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(217, 88)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(39, 19)
        Me._Label1_1.TabIndex = 48
        Me._Label1_1.Text = "&Type"
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me._Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(15, 8)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(39, 17)
        Me._Label1_0.TabIndex = 43
        Me._Label1_0.Text = "&Naam Bedrijf"
        '
        '_Label1_6
        '
        Me._Label1_6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me._Label1_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_6.Location = New System.Drawing.Point(69, 8)
        Me._Label1_6.Name = "_Label1_6"
        Me._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_6.Size = New System.Drawing.Size(85, 17)
        Me._Label1_6.TabIndex = 46
        Me._Label1_6.Text = "&DATA Location"
        '
        '_Label1_5
        '
        Me._Label1_5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me._Label1_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_5.Location = New System.Drawing.Point(133, 46)
        Me._Label1_5.Name = "_Label1_5"
        Me._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_5.Size = New System.Drawing.Size(57, 17)
        Me._Label1_5.TabIndex = 45
        Me._Label1_5.Text = "&Boekjaar"
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me._Label1_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(193, 46)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(99, 17)
        Me._Label1_2.TabIndex = 44
        Me._Label1_2.Text = "Aantal &maanden"
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = true
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(76, 49)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(270, 42)
        Me.lblInOntwikkeling.TabIndex = 52
        Me.lblInOntwikkeling.Text = "In Ontwikkeling"
        '
        'frmNieuwBedrijf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Negeren
        Me.ClientSize = New System.Drawing.Size(453, 134)
        Me.ControlBox = false
        Me.Controls.Add(Me.lblInOntwikkeling)
        Me.Controls.Add(Me.txtStartMaand)
        Me.Controls.Add(Me._TypeBoekjaar_3)
        Me.Controls.Add(Me.Maanden)
        Me.Controls.Add(Me.CmbBedrijfsType)
        Me.Controls.Add(Me.BedrijfsNaam)
        Me.Controls.Add(Me.Installeren)
        Me.Controls.Add(Me.Negeren)
        Me.Controls.Add(Me.Makelaar)
        Me.Controls.Add(Me.Boekjaar)
        Me.Controls.Add(Me._TypeBoekjaar_1)
        Me.Controls.Add(Me._TypeBoekjaar_2)
        Me.Controls.Add(Me._TypeBoekjaar_0)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me._Label1_0)
        Me.Controls.Add(Me._Label1_6)
        Me.Controls.Add(Me._Label1_5)
        Me.Controls.Add(Me._Label1_2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmNieuwBedrijf"
        Me.Text = "frmNieuwBedrijf"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Public WithEvents txtStartMaand As TextBox
    Public WithEvents _TypeBoekjaar_3 As RadioButton
    Public WithEvents Maanden As TextBox
    Public WithEvents CmbBedrijfsType As ComboBox
    Public WithEvents BedrijfsNaam As TextBox
    Public WithEvents Installeren As Button
    Public WithEvents Negeren As Button
    Public WithEvents Makelaar As CheckBox
    Public WithEvents Boekjaar As TextBox
    Public WithEvents _TypeBoekjaar_1 As RadioButton
    Public WithEvents _TypeBoekjaar_2 As RadioButton
    Public WithEvents _TypeBoekjaar_0 As RadioButton
    Public WithEvents _Label1_1 As Label
    Public WithEvents _Label1_0 As Label
    Public WithEvents _Label1_6 As Label
    Public WithEvents _Label1_5 As Label
    Public WithEvents _Label1_2 As Label
    Public WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblInOntwikkeling As Label
End Class
