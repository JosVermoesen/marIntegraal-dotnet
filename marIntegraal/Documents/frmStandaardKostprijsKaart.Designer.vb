<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStandaardKostprijsKaart
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
        Me.Command1 = New System.Windows.Forms.Button()
        Me.cmdVerbruik = New System.Windows.Forms.Button()
        Me.txtVerbruik = New System.Windows.Forms.TextBox()
        Me.cbPrijswijziging = New System.Windows.Forms.CheckBox()
        Me.CmdProduktieFiche = New System.Windows.Forms.Button()
        Me.cmdLijst = New System.Windows.Forms.Button()
        Me.CmdSchoon = New System.Windows.Forms.Button()
        Me.CmdWegschrijven = New System.Windows.Forms.Button()
        Me.CmdSProdukt = New System.Windows.Forms.Button()
        Me.CmdAnnuleren = New System.Windows.Forms.Button()
        Me._Label1_4 = New System.Windows.Forms.Label()
        Me.LblProduktInfo = New System.Windows.Forms.Label()
        Me._Label1_3 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LblVerkoopNieuw = New System.Windows.Forms.Label()
        Me.LblAankoopNieuw = New System.Windows.Forms.Label()
        Me.LblAankoop = New System.Windows.Forms.Label()
        Me.LblVerkoop = New System.Windows.Forms.Label()
        Me.lblInOntwikkeling = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(565, 327)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(149, 21)
        Me.Command1.TabIndex = 39
        Me.Command1.TabStop = false
        Me.Command1.Text = "&Lijst alle kaarten"
        Me.Command1.UseVisualStyleBackColor = false
        '
        'cmdVerbruik
        '
        Me.cmdVerbruik.BackColor = System.Drawing.SystemColors.Control
        Me.cmdVerbruik.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdVerbruik.Enabled = false
        Me.cmdVerbruik.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdVerbruik.Location = New System.Drawing.Point(233, 323)
        Me.cmdVerbruik.Name = "cmdVerbruik"
        Me.cmdVerbruik.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdVerbruik.Size = New System.Drawing.Size(113, 33)
        Me.cmdVerbruik.TabIndex = 38
        Me.cmdVerbruik.Text = "Totaal Productie Herrekenen"
        Me.cmdVerbruik.UseVisualStyleBackColor = false
        '
        'txtVerbruik
        '
        Me.txtVerbruik.AcceptsReturn = true
        Me.txtVerbruik.BackColor = System.Drawing.SystemColors.Window
        Me.txtVerbruik.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerbruik.Enabled = false
        Me.txtVerbruik.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVerbruik.Location = New System.Drawing.Point(177, 323)
        Me.txtVerbruik.MaxLength = 0
        Me.txtVerbruik.Name = "txtVerbruik"
        Me.txtVerbruik.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVerbruik.Size = New System.Drawing.Size(49, 20)
        Me.txtVerbruik.TabIndex = 37
        Me.txtVerbruik.Text = "1"
        Me.txtVerbruik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbPrijswijziging
        '
        Me.cbPrijswijziging.BackColor = System.Drawing.SystemColors.Control
        Me.cbPrijswijziging.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbPrijswijziging.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbPrijswijziging.Location = New System.Drawing.Point(9, 347)
        Me.cbPrijswijziging.Name = "cbPrijswijziging"
        Me.cbPrijswijziging.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbPrijswijziging.Size = New System.Drawing.Size(145, 17)
        Me.cbPrijswijziging.TabIndex = 36
        Me.cbPrijswijziging.Text = "Enkel voor prijswijzigingen"
        Me.cbPrijswijziging.UseVisualStyleBackColor = false
        '
        'CmdProduktieFiche
        '
        Me.CmdProduktieFiche.BackColor = System.Drawing.SystemColors.Control
        Me.CmdProduktieFiche.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdProduktieFiche.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdProduktieFiche.Location = New System.Drawing.Point(365, 323)
        Me.CmdProduktieFiche.Name = "CmdProduktieFiche"
        Me.CmdProduktieFiche.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdProduktieFiche.Size = New System.Drawing.Size(105, 21)
        Me.CmdProduktieFiche.TabIndex = 35
        Me.CmdProduktieFiche.TabStop = false
        Me.CmdProduktieFiche.Text = "&Produktiefiche"
        Me.CmdProduktieFiche.UseVisualStyleBackColor = false
        '
        'cmdLijst
        '
        Me.cmdLijst.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLijst.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLijst.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLijst.Location = New System.Drawing.Point(9, 323)
        Me.cmdLijst.Name = "cmdLijst"
        Me.cmdLijst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLijst.Size = New System.Drawing.Size(149, 21)
        Me.cmdLijst.TabIndex = 34
        Me.cmdLijst.TabStop = false
        Me.cmdLijst.Text = "&Lijst alle kaarten"
        Me.cmdLijst.UseVisualStyleBackColor = false
        '
        'CmdSchoon
        '
        Me.CmdSchoon.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSchoon.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdSchoon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSchoon.Location = New System.Drawing.Point(473, 323)
        Me.CmdSchoon.Name = "CmdSchoon"
        Me.CmdSchoon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdSchoon.Size = New System.Drawing.Size(69, 21)
        Me.CmdSchoon.TabIndex = 23
        Me.CmdSchoon.TabStop = false
        Me.CmdSchoon.Text = "Schoo&n"
        Me.CmdSchoon.UseVisualStyleBackColor = false
        '
        'CmdWegschrijven
        '
        Me.CmdWegschrijven.BackColor = System.Drawing.SystemColors.Control
        Me.CmdWegschrijven.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdWegschrijven.Enabled = false
        Me.CmdWegschrijven.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdWegschrijven.Location = New System.Drawing.Point(365, 347)
        Me.CmdWegschrijven.Name = "CmdWegschrijven"
        Me.CmdWegschrijven.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdWegschrijven.Size = New System.Drawing.Size(105, 21)
        Me.CmdWegschrijven.TabIndex = 22
        Me.CmdWegschrijven.TabStop = false
        Me.CmdWegschrijven.Text = "&Wegschrijven"
        Me.CmdWegschrijven.UseVisualStyleBackColor = false
        '
        'CmdSProdukt
        '
        Me.CmdSProdukt.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSProdukt.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdSProdukt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdSProdukt.Location = New System.Drawing.Point(95, 51)
        Me.CmdSProdukt.Name = "CmdSProdukt"
        Me.CmdSProdukt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdSProdukt.Size = New System.Drawing.Size(187, 23)
        Me.CmdSProdukt.TabIndex = 20
        Me.CmdSProdukt.Text = "Samengesteld produkt &Zoeken"
        Me.CmdSProdukt.UseVisualStyleBackColor = false
        '
        'CmdAnnuleren
        '
        Me.CmdAnnuleren.BackColor = System.Drawing.SystemColors.Control
        Me.CmdAnnuleren.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdAnnuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdAnnuleren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAnnuleren.Location = New System.Drawing.Point(473, 347)
        Me.CmdAnnuleren.Name = "CmdAnnuleren"
        Me.CmdAnnuleren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdAnnuleren.Size = New System.Drawing.Size(69, 21)
        Me.CmdAnnuleren.TabIndex = 24
        Me.CmdAnnuleren.TabStop = false
        Me.CmdAnnuleren.Text = "Sluiten"
        Me.CmdAnnuleren.UseVisualStyleBackColor = false
        '
        '_Label1_4
        '
        Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_4.Location = New System.Drawing.Point(11, 61)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_4.Size = New System.Drawing.Size(73, 17)
        Me._Label1_4.TabIndex = 21
        Me._Label1_4.Text = "&Detaillijnen"
        '
        'LblProduktInfo
        '
        Me.LblProduktInfo.BackColor = System.Drawing.SystemColors.Control
        Me.LblProduktInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblProduktInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblProduktInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblProduktInfo.Location = New System.Drawing.Point(9, 9)
        Me.LblProduktInfo.Name = "LblProduktInfo"
        Me.LblProduktInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblProduktInfo.Size = New System.Drawing.Size(271, 39)
        Me.LblProduktInfo.TabIndex = 33
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_3.Location = New System.Drawing.Point(389, 55)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(55, 19)
        Me._Label1_3.TabIndex = 32
        Me._Label1_3.Text = "Verkoop"
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(389, 33)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(55, 19)
        Me._Label1_2.TabIndex = 31
        Me._Label1_2.Text = "Aankoop"
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(411, 13)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(135, 17)
        Me._Label1_0.TabIndex = 29
        Me._Label1_0.Text = "Per eenh. huidige prijs"
        Me._Label1_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(589, 13)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(75, 17)
        Me._Label1_1.TabIndex = 30
        Me._Label1_1.Text = "Nieuwe prijs"
        Me._Label1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblVerkoopNieuw
        '
        Me.LblVerkoopNieuw.BackColor = System.Drawing.SystemColors.Info
        Me.LblVerkoopNieuw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblVerkoopNieuw.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblVerkoopNieuw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblVerkoopNieuw.Location = New System.Drawing.Point(547, 53)
        Me.LblVerkoopNieuw.Name = "LblVerkoopNieuw"
        Me.LblVerkoopNieuw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblVerkoopNieuw.Size = New System.Drawing.Size(117, 21)
        Me.LblVerkoopNieuw.TabIndex = 28
        Me.LblVerkoopNieuw.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblAankoopNieuw
        '
        Me.LblAankoopNieuw.BackColor = System.Drawing.SystemColors.Info
        Me.LblAankoopNieuw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAankoopNieuw.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblAankoopNieuw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblAankoopNieuw.Location = New System.Drawing.Point(547, 31)
        Me.LblAankoopNieuw.Name = "LblAankoopNieuw"
        Me.LblAankoopNieuw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblAankoopNieuw.Size = New System.Drawing.Size(117, 21)
        Me.LblAankoopNieuw.TabIndex = 27
        Me.LblAankoopNieuw.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblAankoop
        '
        Me.LblAankoop.BackColor = System.Drawing.SystemColors.Info
        Me.LblAankoop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAankoop.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblAankoop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblAankoop.Location = New System.Drawing.Point(445, 31)
        Me.LblAankoop.Name = "LblAankoop"
        Me.LblAankoop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblAankoop.Size = New System.Drawing.Size(101, 21)
        Me.LblAankoop.TabIndex = 25
        Me.LblAankoop.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblVerkoop
        '
        Me.LblVerkoop.BackColor = System.Drawing.SystemColors.Info
        Me.LblVerkoop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblVerkoop.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblVerkoop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblVerkoop.Location = New System.Drawing.Point(445, 53)
        Me.LblVerkoop.Name = "LblVerkoop"
        Me.LblVerkoop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblVerkoop.Size = New System.Drawing.Size(101, 21)
        Me.LblVerkoop.TabIndex = 26
        Me.LblVerkoop.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = true
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(228, 171)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(270, 42)
        Me.lblInOntwikkeling.TabIndex = 88
        Me.lblInOntwikkeling.Text = "In Ontwikkeling"
        '
        'frmStandaardKostprijsKaart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 385)
        Me.Controls.Add(Me.lblInOntwikkeling)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.cmdVerbruik)
        Me.Controls.Add(Me.txtVerbruik)
        Me.Controls.Add(Me.cbPrijswijziging)
        Me.Controls.Add(Me.CmdProduktieFiche)
        Me.Controls.Add(Me.cmdLijst)
        Me.Controls.Add(Me.CmdSchoon)
        Me.Controls.Add(Me.CmdWegschrijven)
        Me.Controls.Add(Me.CmdSProdukt)
        Me.Controls.Add(Me.CmdAnnuleren)
        Me.Controls.Add(Me._Label1_4)
        Me.Controls.Add(Me.LblProduktInfo)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_0)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me.LblVerkoopNieuw)
        Me.Controls.Add(Me.LblAankoopNieuw)
        Me.Controls.Add(Me.LblAankoop)
        Me.Controls.Add(Me.LblVerkoop)
        Me.Name = "frmStandaardKostprijsKaart"
        Me.Text = "frmStandaardKostprijsKaart"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Public WithEvents Command1 As Button
    Public WithEvents cmdVerbruik As Button
    Public WithEvents txtVerbruik As TextBox
    Public WithEvents cbPrijswijziging As CheckBox
    Public WithEvents CmdProduktieFiche As Button
    Public WithEvents cmdLijst As Button
    Public WithEvents CmdSchoon As Button
    Public WithEvents CmdWegschrijven As Button
    Public WithEvents CmdSProdukt As Button
    Public WithEvents CmdAnnuleren As Button
    Public WithEvents _Label1_4 As Label
    Public WithEvents LblProduktInfo As Label
    Public WithEvents _Label1_3 As Label
    Public WithEvents _Label1_2 As Label
    Public WithEvents _Label1_0 As Label
    Public WithEvents _Label1_1 As Label
    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents LblVerkoopNieuw As Label
    Public WithEvents LblAankoopNieuw As Label
    Public WithEvents LblAankoop As Label
    Public WithEvents LblVerkoop As Label
    Friend WithEvents lblInOntwikkeling As Label
End Class
