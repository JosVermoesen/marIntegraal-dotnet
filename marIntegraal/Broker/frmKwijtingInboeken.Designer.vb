<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KwijtingInboeken
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
        Me.Annuleren = New System.Windows.Forms.Button()
        Me.Schoonvegen = New System.Windows.Forms.Button()
        Me.Afsluiten = New System.Windows.Forms.Button()
        Me._KeuzeInfo_0 = New System.Windows.Forms.ComboBox()
        Me.cbBoekDatum = New System.Windows.Forms.CheckBox()
        Me._KeuzeInfo_1 = New System.Windows.Forms.ComboBox()
        Me.mebBoekDatum = New System.Windows.Forms.MaskedTextBox()
        Me._TekstInfo_0 = New System.Windows.Forms.MaskedTextBox()
        Me._LabelInfo_2 = New System.Windows.Forms.Label()
        Me._Label1_16 = New System.Windows.Forms.Label()
        Me._Label1_15 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblInOntwikkeling = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.rtbIndentTB2 = New System.Windows.Forms.RichTextBox()
        Me.cbPolisHistoriek = New System.Windows.Forms.ComboBox()
        Me.cbTB2ktrl = New System.Windows.Forms.CheckBox()
        Me.cbHerboeking = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.TabPage2.SuspendLayout
        Me.SuspendLayout
        '
        'Annuleren
        '
        Me.Annuleren.BackColor = System.Drawing.SystemColors.Control
        Me.Annuleren.Cursor = System.Windows.Forms.Cursors.Default
        Me.Annuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Annuleren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Annuleren.Location = New System.Drawing.Point(548, 55)
        Me.Annuleren.Name = "Annuleren"
        Me.Annuleren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Annuleren.Size = New System.Drawing.Size(88, 22)
        Me.Annuleren.TabIndex = 45
        Me.Annuleren.Text = "Sluiten"
        Me.Annuleren.UseVisualStyleBackColor = false
        '
        'Schoonvegen
        '
        Me.Schoonvegen.BackColor = System.Drawing.SystemColors.Control
        Me.Schoonvegen.Cursor = System.Windows.Forms.Cursors.Default
        Me.Schoonvegen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Schoonvegen.Location = New System.Drawing.Point(548, 31)
        Me.Schoonvegen.Name = "Schoonvegen"
        Me.Schoonvegen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Schoonvegen.Size = New System.Drawing.Size(88, 22)
        Me.Schoonvegen.TabIndex = 44
        Me.Schoonvegen.Text = "Schoo&n"
        Me.Schoonvegen.UseVisualStyleBackColor = false
        '
        'Afsluiten
        '
        Me.Afsluiten.BackColor = System.Drawing.SystemColors.Control
        Me.Afsluiten.Cursor = System.Windows.Forms.Cursors.Default
        Me.Afsluiten.Enabled = false
        Me.Afsluiten.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Afsluiten.Location = New System.Drawing.Point(548, 7)
        Me.Afsluiten.Name = "Afsluiten"
        Me.Afsluiten.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Afsluiten.Size = New System.Drawing.Size(88, 22)
        Me.Afsluiten.TabIndex = 43
        Me.Afsluiten.Text = "&Boeken"
        Me.Afsluiten.UseVisualStyleBackColor = false
        '
        '_KeuzeInfo_0
        '
        Me._KeuzeInfo_0.BackColor = System.Drawing.SystemColors.Window
        Me._KeuzeInfo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._KeuzeInfo_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._KeuzeInfo_0.ForeColor = System.Drawing.Color.Black
        Me._KeuzeInfo_0.Location = New System.Drawing.Point(12, 31)
        Me._KeuzeInfo_0.Name = "_KeuzeInfo_0"
        Me._KeuzeInfo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._KeuzeInfo_0.Size = New System.Drawing.Size(343, 21)
        Me._KeuzeInfo_0.TabIndex = 42
        '
        'cbBoekDatum
        '
        Me.cbBoekDatum.BackColor = System.Drawing.SystemColors.Control
        Me.cbBoekDatum.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbBoekDatum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbBoekDatum.Location = New System.Drawing.Point(420, 63)
        Me.cbBoekDatum.Name = "cbBoekDatum"
        Me.cbBoekDatum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbBoekDatum.Size = New System.Drawing.Size(113, 17)
        Me.cbBoekDatum.TabIndex = 37
        Me.cbBoekDatum.Text = "Met Boekdatum"
        Me.cbBoekDatum.UseVisualStyleBackColor = false
        Me.cbBoekDatum.Visible = false
        '
        '_KeuzeInfo_1
        '
        Me._KeuzeInfo_1.BackColor = System.Drawing.SystemColors.Window
        Me._KeuzeInfo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._KeuzeInfo_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._KeuzeInfo_1.ForeColor = System.Drawing.Color.Black
        Me._KeuzeInfo_1.Location = New System.Drawing.Point(12, 87)
        Me._KeuzeInfo_1.Name = "_KeuzeInfo_1"
        Me._KeuzeInfo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._KeuzeInfo_1.Size = New System.Drawing.Size(345, 21)
        Me._KeuzeInfo_1.TabIndex = 35
        '
        'mebBoekDatum
        '
        Me.mebBoekDatum.AllowPromptAsInput = false
        Me.mebBoekDatum.Location = New System.Drawing.Point(460, 87)
        Me.mebBoekDatum.Mask = "##/####"
        Me.mebBoekDatum.Name = "mebBoekDatum"
        Me.mebBoekDatum.Size = New System.Drawing.Size(73, 20)
        Me.mebBoekDatum.TabIndex = 36
        Me.mebBoekDatum.Visible = false
        '
        '_TekstInfo_0
        '
        Me._TekstInfo_0.AllowPromptAsInput = false
        Me._TekstInfo_0.BackColor = System.Drawing.Color.White
        Me._TekstInfo_0.Location = New System.Drawing.Point(92, 63)
        Me._TekstInfo_0.Mask = "##/##/####"
        Me._TekstInfo_0.Name = "_TekstInfo_0"
        Me._TekstInfo_0.Size = New System.Drawing.Size(85, 20)
        Me._TekstInfo_0.TabIndex = 39
        '
        '_LabelInfo_2
        '
        Me._LabelInfo_2.BackColor = System.Drawing.Color.White
        Me._LabelInfo_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._LabelInfo_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LabelInfo_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LabelInfo_2.Location = New System.Drawing.Point(260, 63)
        Me._LabelInfo_2.Name = "_LabelInfo_2"
        Me._LabelInfo_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LabelInfo_2.Size = New System.Drawing.Size(104, 18)
        Me._LabelInfo_2.TabIndex = 41
        '
        '_Label1_16
        '
        Me._Label1_16.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_16.Location = New System.Drawing.Point(188, 63)
        Me._Label1_16.Name = "_Label1_16"
        Me._Label1_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_16.Size = New System.Drawing.Size(66, 18)
        Me._Label1_16.TabIndex = 40
        Me._Label1_16.Text = "Boek.Rek."
        '
        '_Label1_15
        '
        Me._Label1_15.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_15.Location = New System.Drawing.Point(12, 63)
        Me._Label1_15.Name = "_Label1_15"
        Me._Label1_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_15.Size = New System.Drawing.Size(72, 19)
        Me._Label1_15.TabIndex = 38
        Me._Label1_15.Text = "Boek&datum"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(687, 313)
        Me.TabControl1.TabIndex = 51
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblInOntwikkeling)
        Me.TabPage1.Controls.Add(Me.Annuleren)
        Me.TabPage1.Controls.Add(Me._Label1_15)
        Me.TabPage1.Controls.Add(Me.Schoonvegen)
        Me.TabPage1.Controls.Add(Me._Label1_16)
        Me.TabPage1.Controls.Add(Me.Afsluiten)
        Me.TabPage1.Controls.Add(Me._LabelInfo_2)
        Me.TabPage1.Controls.Add(Me._KeuzeInfo_0)
        Me.TabPage1.Controls.Add(Me._TekstInfo_0)
        Me.TabPage1.Controls.Add(Me.cbBoekDatum)
        Me.TabPage1.Controls.Add(Me.mebBoekDatum)
        Me.TabPage1.Controls.Add(Me._KeuzeInfo_1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(679, 287)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = true
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(199, 149)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(270, 42)
        Me.lblInOntwikkeling.TabIndex = 87
        Me.lblInOntwikkeling.Text = "In Ontwikkeling"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.rtbIndentTB2)
        Me.TabPage2.Controls.Add(Me.cbPolisHistoriek)
        Me.TabPage2.Controls.Add(Me.cbTB2ktrl)
        Me.TabPage2.Controls.Add(Me.cbHerboeking)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(679, 287)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = true
        '
        'rtbIndentTB2
        '
        Me.rtbIndentTB2.Location = New System.Drawing.Point(6, 37)
        Me.rtbIndentTB2.Name = "rtbIndentTB2"
        Me.rtbIndentTB2.Size = New System.Drawing.Size(561, 234)
        Me.rtbIndentTB2.TabIndex = 47
        Me.rtbIndentTB2.Text = "RichTextBox1"
        '
        'cbPolisHistoriek
        '
        Me.cbPolisHistoriek.BackColor = System.Drawing.SystemColors.Window
        Me.cbPolisHistoriek.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbPolisHistoriek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPolisHistoriek.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbPolisHistoriek.Location = New System.Drawing.Point(6, 6)
        Me.cbPolisHistoriek.Name = "cbPolisHistoriek"
        Me.cbPolisHistoriek.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbPolisHistoriek.Size = New System.Drawing.Size(321, 21)
        Me.cbPolisHistoriek.TabIndex = 50
        Me.cbPolisHistoriek.TabStop = false
        '
        'cbTB2ktrl
        '
        Me.cbTB2ktrl.BackColor = System.Drawing.SystemColors.Control
        Me.cbTB2ktrl.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbTB2ktrl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbTB2ktrl.Location = New System.Drawing.Point(340, 6)
        Me.cbTB2ktrl.Name = "cbTB2ktrl"
        Me.cbTB2ktrl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbTB2ktrl.Size = New System.Drawing.Size(97, 25)
        Me.cbTB2ktrl.TabIndex = 48
        Me.cbTB2ktrl.Text = "TB2 controle"
        Me.cbTB2ktrl.UseVisualStyleBackColor = false
        '
        'cbHerboeking
        '
        Me.cbHerboeking.BackColor = System.Drawing.SystemColors.Control
        Me.cbHerboeking.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbHerboeking.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbHerboeking.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbHerboeking.Location = New System.Drawing.Point(443, 6)
        Me.cbHerboeking.Name = "cbHerboeking"
        Me.cbHerboeking.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbHerboeking.Size = New System.Drawing.Size(121, 25)
        Me.cbHerboeking.TabIndex = 49
        Me.cbHerboeking.Text = "Voor Herboeking"
        Me.cbHerboeking.UseVisualStyleBackColor = false
        '
        'KwijtingInboeken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "KwijtingInboeken"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmKwijtingInboeken"
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage1.PerformLayout
        Me.TabPage2.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Public WithEvents Annuleren As Button
    Public WithEvents Schoonvegen As Button
    Public WithEvents Afsluiten As Button
    Public WithEvents _KeuzeInfo_0 As ComboBox
    Public WithEvents cbBoekDatum As CheckBox
    Public WithEvents _KeuzeInfo_1 As ComboBox
    Public WithEvents mebBoekDatum As MaskedTextBox
    Public WithEvents _TekstInfo_0 As MaskedTextBox
    Public WithEvents _LabelInfo_2 As Label
    Public WithEvents _Label1_16 As Label
    Public WithEvents _Label1_15 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Public WithEvents rtbIndentTB2 As RichTextBox
    Public WithEvents cbPolisHistoriek As ComboBox
    Public WithEvents cbTB2ktrl As CheckBox
    Public WithEvents cbHerboeking As CheckBox
    Friend WithEvents lblInOntwikkeling As Label
End Class
