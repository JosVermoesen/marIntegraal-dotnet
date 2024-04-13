<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJaarlistingBtw
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJaarlistingBtw))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkAfdrukInVenster = New System.Windows.Forms.CheckBox()
        Me.CmdEmailNBB = New System.Windows.Forms.Button()
        Me.frmMunt = New System.Windows.Forms.GroupBox()
        Me._obMunt_1 = New System.Windows.Forms.RadioButton()
        Me._obMunt_0 = New System.Windows.Forms.RadioButton()
        Me.Annuleren = New System.Windows.Forms.Button()
        Me._TekstLijn_0 = New System.Windows.Forms.TextBox()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me.lblInOntwikkeling = New System.Windows.Forms.Label()
        Me.frmMunt.SuspendLayout
        Me.SuspendLayout
        '
        'chkAfdrukInVenster
        '
        Me.chkAfdrukInVenster.BackColor = System.Drawing.SystemColors.Control
        Me.chkAfdrukInVenster.Checked = true
        Me.chkAfdrukInVenster.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAfdrukInVenster.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAfdrukInVenster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAfdrukInVenster.Location = New System.Drawing.Point(9, 60)
        Me.chkAfdrukInVenster.Name = "chkAfdrukInVenster"
        Me.chkAfdrukInVenster.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAfdrukInVenster.Size = New System.Drawing.Size(97, 17)
        Me.chkAfdrukInVenster.TabIndex = 10
        Me.chkAfdrukInVenster.Text = "Lijst in &Venster"
        Me.chkAfdrukInVenster.UseVisualStyleBackColor = false
        '
        'CmdEmailNBB
        '
        Me.CmdEmailNBB.BackColor = System.Drawing.SystemColors.Control
        Me.CmdEmailNBB.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdEmailNBB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdEmailNBB.Image = CType(resources.GetObject("CmdEmailNBB.Image"),System.Drawing.Image)
        Me.CmdEmailNBB.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdEmailNBB.Location = New System.Drawing.Point(289, 12)
        Me.CmdEmailNBB.Name = "CmdEmailNBB"
        Me.CmdEmailNBB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdEmailNBB.Size = New System.Drawing.Size(82, 65)
        Me.CmdEmailNBB.TabIndex = 12
        Me.CmdEmailNBB.TabStop = false
        Me.CmdEmailNBB.Text = "Afdruken en Verzenden"
        Me.CmdEmailNBB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdEmailNBB.UseVisualStyleBackColor = false
        '
        'frmMunt
        '
        Me.frmMunt.BackColor = System.Drawing.SystemColors.Control
        Me.frmMunt.Controls.Add(Me._obMunt_1)
        Me.frmMunt.Controls.Add(Me._obMunt_0)
        Me.frmMunt.Enabled = false
        Me.frmMunt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmMunt.Location = New System.Drawing.Point(169, 36)
        Me.frmMunt.Name = "frmMunt"
        Me.frmMunt.Padding = New System.Windows.Forms.Padding(0)
        Me.frmMunt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmMunt.Size = New System.Drawing.Size(113, 41)
        Me.frmMunt.TabIndex = 13
        Me.frmMunt.TabStop = false
        Me.frmMunt.Text = "&Munt"
        '
        '_obMunt_1
        '
        Me._obMunt_1.BackColor = System.Drawing.SystemColors.Control
        Me._obMunt_1.Checked = true
        Me._obMunt_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._obMunt_1.Enabled = false
        Me._obMunt_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obMunt_1.Location = New System.Drawing.Point(56, 16)
        Me._obMunt_1.Name = "_obMunt_1"
        Me._obMunt_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obMunt_1.Size = New System.Drawing.Size(49, 17)
        Me._obMunt_1.TabIndex = 9
        Me._obMunt_1.TabStop = true
        Me._obMunt_1.Text = "EUR"
        Me._obMunt_1.UseVisualStyleBackColor = false
        '
        '_obMunt_0
        '
        Me._obMunt_0.BackColor = System.Drawing.SystemColors.Control
        Me._obMunt_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._obMunt_0.Enabled = false
        Me._obMunt_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._obMunt_0.Location = New System.Drawing.Point(8, 16)
        Me._obMunt_0.Name = "_obMunt_0"
        Me._obMunt_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._obMunt_0.Size = New System.Drawing.Size(49, 17)
        Me._obMunt_0.TabIndex = 7
        Me._obMunt_0.Text = "BEF"
        Me._obMunt_0.UseVisualStyleBackColor = false
        '
        'Annuleren
        '
        Me.Annuleren.BackColor = System.Drawing.SystemColors.Control
        Me.Annuleren.Cursor = System.Windows.Forms.Cursors.Default
        Me.Annuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Annuleren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Annuleren.Location = New System.Drawing.Point(377, 52)
        Me.Annuleren.Name = "Annuleren"
        Me.Annuleren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Annuleren.Size = New System.Drawing.Size(74, 25)
        Me.Annuleren.TabIndex = 11
        Me.Annuleren.TabStop = false
        Me.Annuleren.Text = "Sluiten"
        Me.Annuleren.UseVisualStyleBackColor = false
        '
        '_TekstLijn_0
        '
        Me._TekstLijn_0.AcceptsReturn = true
        Me._TekstLijn_0.BackColor = System.Drawing.Color.White
        Me._TekstLijn_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstLijn_0.ForeColor = System.Drawing.Color.Black
        Me._TekstLijn_0.Location = New System.Drawing.Point(57, 12)
        Me._TekstLijn_0.MaxLength = 0
        Me._TekstLijn_0.Name = "_TekstLijn_0"
        Me._TekstLijn_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstLijn_0.Size = New System.Drawing.Size(215, 20)
        Me._TekstLijn_0.TabIndex = 8
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(9, 12)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(53, 18)
        Me._Label1_0.TabIndex = 7
        Me._Label1_0.Text = "&SubTitel"
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(9, 36)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(53, 17)
        Me._Label1_1.TabIndex = 9
        Me._Label1_1.Text = "Datu&m"
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = true
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(95, 22)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(270, 42)
        Me.lblInOntwikkeling.TabIndex = 88
        Me.lblInOntwikkeling.Text = "In Ontwikkeling"
        '
        'frmJaarlistingBtw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 87)
        Me.Controls.Add(Me.lblInOntwikkeling)
        Me.Controls.Add(Me.chkAfdrukInVenster)
        Me.Controls.Add(Me.CmdEmailNBB)
        Me.Controls.Add(Me.frmMunt)
        Me.Controls.Add(Me.Annuleren)
        Me.Controls.Add(Me._TekstLijn_0)
        Me.Controls.Add(Me._Label1_0)
        Me.Controls.Add(Me._Label1_1)
        Me.Name = "frmJaarlistingBtw"
        Me.Text = "frmJaarlistingBtw"
        Me.frmMunt.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents chkAfdrukInVenster As CheckBox
    Public WithEvents CmdEmailNBB As Button
    Public WithEvents frmMunt As GroupBox
    Public WithEvents _obMunt_1 As RadioButton
    Public WithEvents _obMunt_0 As RadioButton
    Public WithEvents Annuleren As Button
    Public WithEvents _TekstLijn_0 As TextBox
    Public WithEvents _Label1_0 As Label
    Public WithEvents _Label1_1 As Label
    Friend WithEvents lblInOntwikkeling As Label
End Class
