<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFinancialBook
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
        Me.cmdCKTRL = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkAfdrukLiggend = New System.Windows.Forms.CheckBox()
        Me.chkAfdrukInVenster = New System.Windows.Forms.CheckBox()
        Me.CmdJournaalManueel = New System.Windows.Forms.Button()
        Me.UittrekselsLijst = New System.Windows.Forms.ListBox()
        Me._KeuzeInfo_0 = New System.Windows.Forms.ComboBox()
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
        'cmdCKTRL
        '
        Me.cmdCKTRL.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCKTRL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCKTRL.Location = New System.Drawing.Point(291, 312)
        Me.cmdCKTRL.Name = "cmdCKTRL"
        Me.cmdCKTRL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCKTRL.Size = New System.Drawing.Size(61, 21)
        Me.cmdCKTRL.TabIndex = 25
        Me.cmdCKTRL.TabStop = False
        Me.cmdCKTRL.Text = "cKTRL"
        Me.cmdCKTRL.UseVisualStyleBackColor = False
        '
        'chkAfdrukLiggend
        '
        Me.chkAfdrukLiggend.BackColor = System.Drawing.SystemColors.Control
        Me.chkAfdrukLiggend.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAfdrukLiggend.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAfdrukLiggend.Location = New System.Drawing.Point(125, 316)
        Me.chkAfdrukLiggend.Name = "chkAfdrukLiggend"
        Me.chkAfdrukLiggend.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAfdrukLiggend.Size = New System.Drawing.Size(154, 17)
        Me.chkAfdrukLiggend.TabIndex = 24
        Me.chkAfdrukLiggend.Text = "Liggende Printerafdruk"
        Me.chkAfdrukLiggend.UseVisualStyleBackColor = False
        '
        'chkAfdrukInVenster
        '
        Me.chkAfdrukInVenster.BackColor = System.Drawing.SystemColors.Control
        Me.chkAfdrukInVenster.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAfdrukInVenster.Location = New System.Drawing.Point(1, 316)
        Me.chkAfdrukInVenster.Name = "chkAfdrukInVenster"
        Me.chkAfdrukInVenster.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAfdrukInVenster.Size = New System.Drawing.Size(122, 17)
        Me.chkAfdrukInVenster.TabIndex = 23
        Me.chkAfdrukInVenster.Text = "Afdruk in venster"
        Me.chkAfdrukInVenster.UseVisualStyleBackColor = False
        Me.chkAfdrukInVenster.Visible = False
        '
        'CmdJournaalManueel
        '
        Me.CmdJournaalManueel.BackColor = System.Drawing.SystemColors.Control
        Me.CmdJournaalManueel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdJournaalManueel.Location = New System.Drawing.Point(363, 44)
        Me.CmdJournaalManueel.Name = "CmdJournaalManueel"
        Me.CmdJournaalManueel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdJournaalManueel.Size = New System.Drawing.Size(96, 47)
        Me.CmdJournaalManueel.TabIndex = 22
        Me.CmdJournaalManueel.Text = "&Journalen Manueel Zoeken"
        Me.CmdJournaalManueel.UseVisualStyleBackColor = False
        '
        'UittrekselsLijst
        '
        Me.UittrekselsLijst.BackColor = System.Drawing.SystemColors.Window
        Me.UittrekselsLijst.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UittrekselsLijst.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UittrekselsLijst.ItemHeight = 16
        Me.UittrekselsLijst.Location = New System.Drawing.Point(1, 96)
        Me.UittrekselsLijst.Name = "UittrekselsLijst"
        Me.UittrekselsLijst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UittrekselsLijst.Size = New System.Drawing.Size(457, 212)
        Me.UittrekselsLijst.Sorted = True
        Me.UittrekselsLijst.TabIndex = 15
        '
        '_KeuzeInfo_0
        '
        Me._KeuzeInfo_0.BackColor = System.Drawing.Color.White
        Me._KeuzeInfo_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._KeuzeInfo_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._KeuzeInfo_0.Location = New System.Drawing.Point(81, 72)
        Me._KeuzeInfo_0.Name = "_KeuzeInfo_0"
        Me._KeuzeInfo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._KeuzeInfo_0.Size = New System.Drawing.Size(259, 21)
        Me._KeuzeInfo_0.TabIndex = 14
        '
        '_TekstLijn_0
        '
        Me._TekstLijn_0.AcceptsReturn = True
        Me._TekstLijn_0.BackColor = System.Drawing.Color.White
        Me._TekstLijn_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstLijn_0.ForeColor = System.Drawing.Color.Black
        Me._TekstLijn_0.Location = New System.Drawing.Point(1, 32)
        Me._TekstLijn_0.MaxLength = 0
        Me._TekstLijn_0.Name = "_TekstLijn_0"
        Me._TekstLijn_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstLijn_0.Size = New System.Drawing.Size(237, 20)
        Me._TekstLijn_0.TabIndex = 18
        '
        '_TekstLijn_1
        '
        Me._TekstLijn_1.AcceptsReturn = True
        Me._TekstLijn_1.BackColor = System.Drawing.Color.White
        Me._TekstLijn_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstLijn_1.ForeColor = System.Drawing.Color.Black
        Me._TekstLijn_1.Location = New System.Drawing.Point(239, 32)
        Me._TekstLijn_1.MaxLength = 0
        Me._TekstLijn_1.Name = "_TekstLijn_1"
        Me._TekstLijn_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstLijn_1.Size = New System.Drawing.Size(104, 20)
        Me._TekstLijn_1.TabIndex = 20
        '
        'Drukken
        '
        Me.Drukken.BackColor = System.Drawing.SystemColors.Control
        Me.Drukken.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Drukken.Location = New System.Drawing.Point(363, 12)
        Me.Drukken.Name = "Drukken"
        Me.Drukken.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Drukken.Size = New System.Drawing.Size(96, 29)
        Me.Drukken.TabIndex = 16
        Me.Drukken.Text = "Af&drukken"
        Me.Drukken.UseVisualStyleBackColor = False
        '
        'Annuleren
        '
        Me.Annuleren.BackColor = System.Drawing.SystemColors.Control
        Me.Annuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Annuleren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Annuleren.Location = New System.Drawing.Point(359, 310)
        Me.Annuleren.Name = "Annuleren"
        Me.Annuleren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Annuleren.Size = New System.Drawing.Size(96, 25)
        Me.Annuleren.TabIndex = 21
        Me.Annuleren.TabStop = False
        Me.Annuleren.Text = "Sluiten"
        Me.Annuleren.UseVisualStyleBackColor = False
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(-1, 64)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(71, 29)
        Me._Label1_2.TabIndex = 13
        Me._Label1_2.Text = "&Uittreksels periode"
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(3, 12)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(146, 18)
        Me._Label1_0.TabIndex = 17
        Me._Label1_0.Text = "Afdrukperiode Van - &Tot"
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(241, 12)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(93, 18)
        Me._Label1_1.TabIndex = 19
        Me._Label1_1.Text = "Datu&m Drukken"
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = True
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(99, 148)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(270, 42)
        Me.lblInOntwikkeling.TabIndex = 88
        Me.lblInOntwikkeling.Text = "In Ontwikkeling"
        '
        'FormFinancialBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 339)
        Me.Controls.Add(Me.lblInOntwikkeling)
        Me.Controls.Add(Me.cmdCKTRL)
        Me.Controls.Add(Me.chkAfdrukLiggend)
        Me.Controls.Add(Me.chkAfdrukInVenster)
        Me.Controls.Add(Me.CmdJournaalManueel)
        Me.Controls.Add(Me.UittrekselsLijst)
        Me.Controls.Add(Me._KeuzeInfo_0)
        Me.Controls.Add(Me._TekstLijn_0)
        Me.Controls.Add(Me._TekstLijn_1)
        Me.Controls.Add(Me.Drukken)
        Me.Controls.Add(Me.Annuleren)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_0)
        Me.Controls.Add(Me._Label1_1)
        Me.Name = "FormFinancialBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FinancialBook"
        AddHandler Load, AddressOf Me.FormFinancialBook_Load
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Public WithEvents cmdCKTRL As Button
    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents chkAfdrukLiggend As CheckBox
    Public WithEvents chkAfdrukInVenster As CheckBox
    Public WithEvents CmdJournaalManueel As Button
    Public WithEvents UittrekselsLijst As ListBox
    Public WithEvents _KeuzeInfo_0 As ComboBox
    Public WithEvents _TekstLijn_0 As TextBox
    Public WithEvents _TekstLijn_1 As TextBox
    Public WithEvents Drukken As Button
    Public WithEvents Annuleren As Button
    Public WithEvents _Label1_2 As Label
    Public WithEvents _Label1_0 As Label
    Public WithEvents _Label1_1 As Label
    Friend WithEvents lblInOntwikkeling As Label
End Class
