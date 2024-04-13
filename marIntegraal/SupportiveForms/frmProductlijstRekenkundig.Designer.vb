<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductlijstRekenkundig
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
        Me.cbNulWaarden = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkAfdrukLiggend = New System.Windows.Forms.CheckBox()
        Me.chkAfdrukInVenster = New System.Windows.Forms.CheckBox()
        Me.Sortering = New System.Windows.Forms.ComboBox()
        Me._TekstInfo_1 = New System.Windows.Forms.TextBox()
        Me._TekstInfo_0 = New System.Windows.Forms.TextBox()
        Me.CmbLijstType = New System.Windows.Forms.ComboBox()
        Me._TekstLijn_0 = New System.Windows.Forms.TextBox()
        Me._TekstLijn_1 = New System.Windows.Forms.TextBox()
        Me.Drukken = New System.Windows.Forms.Button()
        Me.Annuleren = New System.Windows.Forms.Button()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me.lblInOntwikkeling = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'cbNulWaarden
        '
        Me.cbNulWaarden.BackColor = System.Drawing.SystemColors.Control
        Me.cbNulWaarden.Checked = true
        Me.cbNulWaarden.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbNulWaarden.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbNulWaarden.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbNulWaarden.Location = New System.Drawing.Point(67, 120)
        Me.cbNulWaarden.Name = "cbNulWaarden"
        Me.cbNulWaarden.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbNulWaarden.Size = New System.Drawing.Size(233, 17)
        Me.cbNulWaarden.TabIndex = 27
        Me.cbNulWaarden.TabStop = false
        Me.cbNulWaarden.Text = "Stockwaarden cijfers <= 0 uitsluiten"
        Me.cbNulWaarden.UseVisualStyleBackColor = false
        Me.cbNulWaarden.Visible = false
        '
        'chkAfdrukLiggend
        '
        Me.chkAfdrukLiggend.BackColor = System.Drawing.SystemColors.Control
        Me.chkAfdrukLiggend.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAfdrukLiggend.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAfdrukLiggend.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAfdrukLiggend.Location = New System.Drawing.Point(243, 144)
        Me.chkAfdrukLiggend.Name = "chkAfdrukLiggend"
        Me.chkAfdrukLiggend.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAfdrukLiggend.Size = New System.Drawing.Size(154, 17)
        Me.chkAfdrukLiggend.TabIndex = 26
        Me.chkAfdrukLiggend.TabStop = false
        Me.chkAfdrukLiggend.Text = "L&iggende Printerafdruk"
        Me.chkAfdrukLiggend.UseVisualStyleBackColor = false
        '
        'chkAfdrukInVenster
        '
        Me.chkAfdrukInVenster.BackColor = System.Drawing.SystemColors.Control
        Me.chkAfdrukInVenster.Checked = true
        Me.chkAfdrukInVenster.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAfdrukInVenster.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAfdrukInVenster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAfdrukInVenster.Location = New System.Drawing.Point(11, 144)
        Me.chkAfdrukInVenster.Name = "chkAfdrukInVenster"
        Me.chkAfdrukInVenster.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAfdrukInVenster.Size = New System.Drawing.Size(122, 17)
        Me.chkAfdrukInVenster.TabIndex = 25
        Me.chkAfdrukInVenster.TabStop = false
        Me.chkAfdrukInVenster.Text = "Afdruk in v&enster"
        Me.chkAfdrukInVenster.UseVisualStyleBackColor = false
        '
        'Sortering
        '
        Me.Sortering.BackColor = System.Drawing.SystemColors.Window
        Me.Sortering.Cursor = System.Windows.Forms.Cursors.Default
        Me.Sortering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sortering.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Sortering.Location = New System.Drawing.Point(63, 72)
        Me.Sortering.Name = "Sortering"
        Me.Sortering.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Sortering.Size = New System.Drawing.Size(237, 21)
        Me.Sortering.TabIndex = 19
        '
        '_TekstInfo_1
        '
        Me._TekstInfo_1.AcceptsReturn = true
        Me._TekstInfo_1.BackColor = System.Drawing.SystemColors.Window
        Me._TekstInfo_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstInfo_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TekstInfo_1.Location = New System.Drawing.Point(175, 94)
        Me._TekstInfo_1.MaxLength = 0
        Me._TekstInfo_1.Name = "_TekstInfo_1"
        Me._TekstInfo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstInfo_1.Size = New System.Drawing.Size(125, 20)
        Me._TekstInfo_1.TabIndex = 22
        Me._TekstInfo_1.Text = "zzzzzzzzzzzzzzzzzzzz"
        '
        '_TekstInfo_0
        '
        Me._TekstInfo_0.AcceptsReturn = true
        Me._TekstInfo_0.BackColor = System.Drawing.SystemColors.Window
        Me._TekstInfo_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstInfo_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._TekstInfo_0.Location = New System.Drawing.Point(63, 94)
        Me._TekstInfo_0.MaxLength = 0
        Me._TekstInfo_0.Name = "_TekstInfo_0"
        Me._TekstInfo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstInfo_0.Size = New System.Drawing.Size(109, 20)
        Me._TekstInfo_0.TabIndex = 21
        '
        'CmbLijstType
        '
        Me.CmbLijstType.BackColor = System.Drawing.SystemColors.Window
        Me.CmbLijstType.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbLijstType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLijstType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbLijstType.Location = New System.Drawing.Point(63, 50)
        Me.CmbLijstType.Name = "CmbLijstType"
        Me.CmbLijstType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmbLijstType.Size = New System.Drawing.Size(237, 21)
        Me.CmbLijstType.TabIndex = 18
        '
        '_TekstLijn_0
        '
        Me._TekstLijn_0.AcceptsReturn = true
        Me._TekstLijn_0.BackColor = System.Drawing.Color.White
        Me._TekstLijn_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstLijn_0.ForeColor = System.Drawing.Color.Black
        Me._TekstLijn_0.Location = New System.Drawing.Point(11, 28)
        Me._TekstLijn_0.MaxLength = 0
        Me._TekstLijn_0.Name = "_TekstLijn_0"
        Me._TekstLijn_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstLijn_0.Size = New System.Drawing.Size(288, 20)
        Me._TekstLijn_0.TabIndex = 17
        '
        '_TekstLijn_1
        '
        Me._TekstLijn_1.AcceptsReturn = true
        Me._TekstLijn_1.BackColor = System.Drawing.Color.White
        Me._TekstLijn_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstLijn_1.ForeColor = System.Drawing.Color.Black
        Me._TekstLijn_1.Location = New System.Drawing.Point(195, 8)
        Me._TekstLijn_1.MaxLength = 0
        Me._TekstLijn_1.Name = "_TekstLijn_1"
        Me._TekstLijn_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstLijn_1.Size = New System.Drawing.Size(104, 20)
        Me._TekstLijn_1.TabIndex = 15
        '
        'Drukken
        '
        Me.Drukken.BackColor = System.Drawing.SystemColors.Control
        Me.Drukken.Cursor = System.Windows.Forms.Cursors.Default
        Me.Drukken.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Drukken.Location = New System.Drawing.Point(305, 10)
        Me.Drukken.Name = "Drukken"
        Me.Drukken.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Drukken.Size = New System.Drawing.Size(96, 25)
        Me.Drukken.TabIndex = 23
        Me.Drukken.Text = "Af&drukken"
        Me.Drukken.UseVisualStyleBackColor = false
        '
        'Annuleren
        '
        Me.Annuleren.BackColor = System.Drawing.SystemColors.Control
        Me.Annuleren.Cursor = System.Windows.Forms.Cursors.Default
        Me.Annuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Annuleren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Annuleren.Location = New System.Drawing.Point(305, 36)
        Me.Annuleren.Name = "Annuleren"
        Me.Annuleren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Annuleren.Size = New System.Drawing.Size(96, 23)
        Me.Annuleren.TabIndex = 24
        Me.Annuleren.TabStop = false
        Me.Annuleren.Text = "&Sluiten"
        Me.Annuleren.UseVisualStyleBackColor = false
        '
        '_Label1_2
        '
        Me._Label1_2.AutoSize = true
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(11, 100)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(47, 13)
        Me._Label1_2.TabIndex = 20
        Me._Label1_2.Text = "&Van - tot"
        '
        '_Label1_0
        '
        Me._Label1_0.AutoSize = true
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(21, 12)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(46, 13)
        Me._Label1_0.TabIndex = 16
        Me._Label1_0.Text = "Sub&Titel"
        '
        '_Label1_1
        '
        Me._Label1_1.AutoSize = true
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(101, 12)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(82, 13)
        Me._Label1_1.TabIndex = 14
        Me._Label1_1.Text = "Datu&m Drukken"
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = true
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(75, 65)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(270, 42)
        Me.lblInOntwikkeling.TabIndex = 88
        Me.lblInOntwikkeling.Text = "In Ontwikkeling"
        '
        'frmProductlijstRekenkundig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 172)
        Me.Controls.Add(Me.lblInOntwikkeling)
        Me.Controls.Add(Me.cbNulWaarden)
        Me.Controls.Add(Me.chkAfdrukLiggend)
        Me.Controls.Add(Me.chkAfdrukInVenster)
        Me.Controls.Add(Me.Sortering)
        Me.Controls.Add(Me._TekstInfo_1)
        Me.Controls.Add(Me._TekstInfo_0)
        Me.Controls.Add(Me.CmbLijstType)
        Me.Controls.Add(Me._TekstLijn_0)
        Me.Controls.Add(Me._TekstLijn_1)
        Me.Controls.Add(Me.Drukken)
        Me.Controls.Add(Me.Annuleren)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_0)
        Me.Controls.Add(Me._Label1_1)
        Me.Name = "frmProductlijstRekenkundig"
        Me.Text = "frmProductlijstRekenkundig"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Public WithEvents cbNulWaarden As CheckBox
    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents chkAfdrukLiggend As CheckBox
    Public WithEvents chkAfdrukInVenster As CheckBox
    Public WithEvents Sortering As ComboBox
    Public WithEvents _TekstInfo_1 As TextBox
    Public WithEvents _TekstInfo_0 As TextBox
    Public WithEvents CmbLijstType As ComboBox
    Public WithEvents _TekstLijn_0 As TextBox
    Public WithEvents _TekstLijn_1 As TextBox
    Public WithEvents Drukken As Button
    Public WithEvents Annuleren As Button
    Public WithEvents _Label1_2 As Label
    Public WithEvents _Label1_0 As Label
    Public WithEvents _Label1_1 As Label
    Friend WithEvents lblInOntwikkeling As Label
End Class
