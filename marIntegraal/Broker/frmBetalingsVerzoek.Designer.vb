<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BetalingsVerzoek
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbTB2Info = New System.Windows.Forms.CheckBox()
        Me.ckMetDatum = New System.Windows.Forms.CheckBox()
        Me.cbListCompanies = New System.Windows.Forms.ComboBox()
        Me.Post = New System.Windows.Forms.CheckBox()
        Me.TekstBewaren = New System.Windows.Forms.Button()
        Me._TekstInfo_3 = New System.Windows.Forms.TextBox()
        Me._TekstInfo_2 = New System.Windows.Forms.TextBox()
        Me.tbInfoTekst = New System.Windows.Forms.TextBox()
        Me.cbLanguage = New System.Windows.Forms.ComboBox()
        Me.cbPaymentType = New System.Windows.Forms.ComboBox()
        Me.btPrintOut = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.bClear = New System.Windows.Forms.Button()
        Me._LabelInfo_0 = New System.Windows.Forms.Label()
        Me.CRLFCaption = New System.Windows.Forms.Label()
        Me._LabelInfo_4 = New System.Windows.Forms.Label()
        Me._LabelInfo_3 = New System.Windows.Forms.Label()
        Me._LabelInfo_2 = New System.Windows.Forms.Label()
        Me.lblInOntwikkeling = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ListViewPostDetail = New System.Windows.Forms.ListView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.MetOverschrijving = New System.Windows.Forms.CheckBox()
        Me.TabControlPremium = New System.Windows.Forms.TabControl()
        Me.TabPagePost = New System.Windows.Forms.TabPage()
        Me.TabPageEmail = New System.Windows.Forms.TabPage()
        Me.ListViewMailDetail = New System.Windows.Forms.ListView()
        Me.TabControlPremium.SuspendLayout()
        Me.TabPagePost.SuspendLayout()
        Me.TabPageEmail.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbTB2Info
        '
        Me.cbTB2Info.BackColor = System.Drawing.SystemColors.Control
        Me.cbTB2Info.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbTB2Info.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbTB2Info.Location = New System.Drawing.Point(410, 35)
        Me.cbTB2Info.Name = "cbTB2Info"
        Me.cbTB2Info.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbTB2Info.Size = New System.Drawing.Size(144, 21)
        Me.cbTB2Info.TabIndex = 60
        Me.cbTB2Info.Text = "TB2 Detail op blad 2"
        Me.cbTB2Info.UseVisualStyleBackColor = False
        '
        'ckMetDatum
        '
        Me.ckMetDatum.BackColor = System.Drawing.SystemColors.Control
        Me.ckMetDatum.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ckMetDatum.Checked = True
        Me.ckMetDatum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckMetDatum.Cursor = System.Windows.Forms.Cursors.Default
        Me.ckMetDatum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ckMetDatum.Location = New System.Drawing.Point(7, 65)
        Me.ckMetDatum.Name = "ckMetDatum"
        Me.ckMetDatum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ckMetDatum.Size = New System.Drawing.Size(83, 20)
        Me.ckMetDatum.TabIndex = 56
        Me.ckMetDatum.Text = "Met datum"
        Me.ckMetDatum.UseVisualStyleBackColor = False
        '
        'cbListCompanies
        '
        Me.cbListCompanies.BackColor = System.Drawing.Color.White
        Me.cbListCompanies.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbListCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbListCompanies.ForeColor = System.Drawing.Color.Black
        Me.cbListCompanies.Location = New System.Drawing.Point(7, 38)
        Me.cbListCompanies.Name = "cbListCompanies"
        Me.cbListCompanies.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbListCompanies.Size = New System.Drawing.Size(265, 21)
        Me.cbListCompanies.TabIndex = 1
        Me.cbListCompanies.Visible = False
        '
        'Post
        '
        Me.Post.BackColor = System.Drawing.SystemColors.Control
        Me.Post.Checked = True
        Me.Post.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Post.Cursor = System.Windows.Forms.Cursors.Default
        Me.Post.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Post.Location = New System.Drawing.Point(301, 38)
        Me.Post.Name = "Post"
        Me.Post.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Post.Size = New System.Drawing.Size(64, 21)
        Me.Post.TabIndex = 44
        Me.Post.Text = "P&ost"
        Me.Post.UseVisualStyleBackColor = False
        '
        'TekstBewaren
        '
        Me.TekstBewaren.BackColor = System.Drawing.SystemColors.Control
        Me.TekstBewaren.Cursor = System.Windows.Forms.Cursors.Default
        Me.TekstBewaren.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TekstBewaren.Location = New System.Drawing.Point(285, 257)
        Me.TekstBewaren.Name = "TekstBewaren"
        Me.TekstBewaren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TekstBewaren.Size = New System.Drawing.Size(89, 22)
        Me.TekstBewaren.TabIndex = 41
        Me.TekstBewaren.Text = "Opslaan"
        Me.TekstBewaren.UseVisualStyleBackColor = False
        '
        '_TekstInfo_3
        '
        Me._TekstInfo_3.AcceptsReturn = True
        Me._TekstInfo_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._TekstInfo_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._TekstInfo_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstInfo_3.ForeColor = System.Drawing.Color.Black
        Me._TekstInfo_3.Location = New System.Drawing.Point(642, 290)
        Me._TekstInfo_3.MaxLength = 0
        Me._TekstInfo_3.Name = "_TekstInfo_3"
        Me._TekstInfo_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstInfo_3.Size = New System.Drawing.Size(72, 20)
        Me._TekstInfo_3.TabIndex = 46
        Me._TekstInfo_3.Text = "471.00"
        Me._TekstInfo_3.Visible = False
        '
        '_TekstInfo_2
        '
        Me._TekstInfo_2.AcceptsReturn = True
        Me._TekstInfo_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._TekstInfo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._TekstInfo_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._TekstInfo_2.ForeColor = System.Drawing.Color.Black
        Me._TekstInfo_2.Location = New System.Drawing.Point(642, 316)
        Me._TekstInfo_2.MaxLength = 0
        Me._TekstInfo_2.Name = "_TekstInfo_2"
        Me._TekstInfo_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._TekstInfo_2.Size = New System.Drawing.Size(72, 20)
        Me._TekstInfo_2.TabIndex = 45
        Me._TekstInfo_2.Text = "145.56"
        Me._TekstInfo_2.Visible = False
        '
        'tbInfoTekst
        '
        Me.tbInfoTekst.AcceptsReturn = True
        Me.tbInfoTekst.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbInfoTekst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbInfoTekst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbInfoTekst.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInfoTekst.ForeColor = System.Drawing.Color.Black
        Me.tbInfoTekst.Location = New System.Drawing.Point(14, 288)
        Me.tbInfoTekst.MaxLength = 0
        Me.tbInfoTekst.Multiline = True
        Me.tbInfoTekst.Name = "tbInfoTekst"
        Me.tbInfoTekst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbInfoTekst.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbInfoTekst.Size = New System.Drawing.Size(624, 85)
        Me.tbInfoTekst.TabIndex = 40
        Me.tbInfoTekst.WordWrap = False
        '
        'cbLanguage
        '
        Me.cbLanguage.BackColor = System.Drawing.Color.White
        Me.cbLanguage.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLanguage.ForeColor = System.Drawing.Color.Black
        Me.cbLanguage.Location = New System.Drawing.Point(9, 257)
        Me.cbLanguage.Name = "cbLanguage"
        Me.cbLanguage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbLanguage.Size = New System.Drawing.Size(272, 21)
        Me.cbLanguage.TabIndex = 39
        '
        'cbPaymentType
        '
        Me.cbPaymentType.BackColor = System.Drawing.Color.White
        Me.cbPaymentType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPaymentType.ForeColor = System.Drawing.Color.Black
        Me.cbPaymentType.Location = New System.Drawing.Point(7, 11)
        Me.cbPaymentType.Name = "cbPaymentType"
        Me.cbPaymentType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbPaymentType.Size = New System.Drawing.Size(265, 21)
        Me.cbPaymentType.TabIndex = 0
        '
        'btPrintOut
        '
        Me.btPrintOut.BackColor = System.Drawing.SystemColors.Control
        Me.btPrintOut.Cursor = System.Windows.Forms.Cursors.Default
        Me.btPrintOut.Enabled = False
        Me.btPrintOut.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btPrintOut.Location = New System.Drawing.Point(637, 130)
        Me.btPrintOut.Name = "btPrintOut"
        Me.btPrintOut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btPrintOut.Size = New System.Drawing.Size(82, 25)
        Me.btPrintOut.TabIndex = 38
        Me.btPrintOut.Text = "&Drukaf"
        Me.btPrintOut.UseVisualStyleBackColor = False
        '
        'btClose
        '
        Me.btClose.BackColor = System.Drawing.SystemColors.Control
        Me.btClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btClose.Location = New System.Drawing.Point(636, 192)
        Me.btClose.Name = "btClose"
        Me.btClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btClose.Size = New System.Drawing.Size(83, 25)
        Me.btClose.TabIndex = 48
        Me.btClose.TabStop = False
        Me.btClose.Text = "Sluiten"
        Me.btClose.UseVisualStyleBackColor = False
        '
        'bClear
        '
        Me.bClear.BackColor = System.Drawing.SystemColors.Control
        Me.bClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.bClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bClear.Location = New System.Drawing.Point(636, 223)
        Me.bClear.Name = "bClear"
        Me.bClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bClear.Size = New System.Drawing.Size(83, 25)
        Me.bClear.TabIndex = 47
        Me.bClear.Text = "Schoon"
        Me.bClear.UseVisualStyleBackColor = False
        '
        '_LabelInfo_0
        '
        Me._LabelInfo_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._LabelInfo_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._LabelInfo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LabelInfo_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._LabelInfo_0.Location = New System.Drawing.Point(560, 70)
        Me._LabelInfo_0.Name = "_LabelInfo_0"
        Me._LabelInfo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LabelInfo_0.Size = New System.Drawing.Size(69, 16)
        Me._LabelInfo_0.TabIndex = 37
        Me._LabelInfo_0.Text = "&Polisdetail"
        '
        'CRLFCaption
        '
        Me.CRLFCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CRLFCaption.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRLFCaption.ForeColor = System.Drawing.Color.Black
        Me.CRLFCaption.Location = New System.Drawing.Point(567, 263)
        Me.CRLFCaption.Name = "CRLFCaption"
        Me.CRLFCaption.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CRLFCaption.Size = New System.Drawing.Size(48, 16)
        Me.CRLFCaption.TabIndex = 52
        Me.CRLFCaption.Text = "0"
        Me.CRLFCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        '_LabelInfo_4
        '
        Me._LabelInfo_4.BackColor = System.Drawing.SystemColors.Control
        Me._LabelInfo_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._LabelInfo_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._LabelInfo_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LabelInfo_4.Location = New System.Drawing.Point(515, 263)
        Me._LabelInfo_4.Name = "_LabelInfo_4"
        Me._LabelInfo_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LabelInfo_4.Size = New System.Drawing.Size(48, 16)
        Me._LabelInfo_4.TabIndex = 51
        Me._LabelInfo_4.Text = "Lijnen"
        '
        '_LabelInfo_3
        '
        Me._LabelInfo_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._LabelInfo_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LabelInfo_3.ForeColor = System.Drawing.Color.Black
        Me._LabelInfo_3.Location = New System.Drawing.Point(435, 335)
        Me._LabelInfo_3.Name = "_LabelInfo_3"
        Me._LabelInfo_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LabelInfo_3.Size = New System.Drawing.Size(96, 16)
        Me._LabelInfo_3.TabIndex = 50
        Me._LabelInfo_3.Text = "BRAND ER IDX"
        Me._LabelInfo_3.Visible = False
        '
        '_LabelInfo_2
        '
        Me._LabelInfo_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._LabelInfo_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LabelInfo_2.ForeColor = System.Drawing.Color.Black
        Me._LabelInfo_2.Location = New System.Drawing.Point(251, 335)
        Me._LabelInfo_2.Name = "_LabelInfo_2"
        Me._LabelInfo_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LabelInfo_2.Size = New System.Drawing.Size(96, 16)
        Me._LabelInfo_2.TabIndex = 49
        Me._LabelInfo_2.Text = "BA Priv‚ IDX"
        Me._LabelInfo_2.Visible = False
        '
        'lblInOntwikkeling
        '
        Me.lblInOntwikkeling.AutoSize = True
        Me.lblInOntwikkeling.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInOntwikkeling.Location = New System.Drawing.Point(204, 290)
        Me.lblInOntwikkeling.Name = "lblInOntwikkeling"
        Me.lblInOntwikkeling.Size = New System.Drawing.Size(189, 42)
        Me.lblInOntwikkeling.TabIndex = 87
        Me.lblInOntwikkeling.Text = "Bezig Aan"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(96, 65)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(176, 20)
        Me.DateTimePicker.TabIndex = 88
        '
        'ListViewPostDetail
        '
        Me.ListViewPostDetail.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewPostDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewPostDetail.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ListViewPostDetail.FullRowSelect = True
        Me.ListViewPostDetail.HideSelection = False
        Me.ListViewPostDetail.Location = New System.Drawing.Point(3, 3)
        Me.ListViewPostDetail.Name = "ListViewPostDetail"
        Me.ListViewPostDetail.Size = New System.Drawing.Size(617, 157)
        Me.ListViewPostDetail.TabIndex = 89
        Me.ListViewPostDetail.UseCompatibleStateImageBehavior = False
        Me.ListViewPostDetail.View = System.Windows.Forms.View.List
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAdd.Enabled = False
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdd.Location = New System.Drawing.Point(471, 62)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAdd.Size = New System.Drawing.Size(83, 25)
        Me.btnAdd.TabIndex = 90
        Me.btnAdd.TabStop = False
        Me.btnAdd.Text = "Toevoegen"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'MetOverschrijving
        '
        Me.MetOverschrijving.BackColor = System.Drawing.SystemColors.Control
        Me.MetOverschrijving.Checked = True
        Me.MetOverschrijving.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MetOverschrijving.Cursor = System.Windows.Forms.Cursors.Default
        Me.MetOverschrijving.Enabled = False
        Me.MetOverschrijving.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MetOverschrijving.Location = New System.Drawing.Point(412, 12)
        Me.MetOverschrijving.Name = "MetOverschrijving"
        Me.MetOverschrijving.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MetOverschrijving.Size = New System.Drawing.Size(151, 21)
        Me.MetOverschrijving.TabIndex = 43
        Me.MetOverschrijving.Text = "Overschrijvingsstrook"
        Me.MetOverschrijving.UseVisualStyleBackColor = False
        '
        'TabControlPremium
        '
        Me.TabControlPremium.Controls.Add(Me.TabPagePost)
        Me.TabControlPremium.Controls.Add(Me.TabPageEmail)
        Me.TabControlPremium.Location = New System.Drawing.Point(7, 93)
        Me.TabControlPremium.Name = "TabControlPremium"
        Me.TabControlPremium.SelectedIndex = 0
        Me.TabControlPremium.Size = New System.Drawing.Size(631, 189)
        Me.TabControlPremium.TabIndex = 91
        '
        'TabPagePost
        '
        Me.TabPagePost.Controls.Add(Me.ListViewPostDetail)
        Me.TabPagePost.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePost.Name = "TabPagePost"
        Me.TabPagePost.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePost.Size = New System.Drawing.Size(623, 163)
        Me.TabPagePost.TabIndex = 0
        Me.TabPagePost.Text = "Post"
        Me.TabPagePost.UseVisualStyleBackColor = True
        '
        'TabPageEmail
        '
        Me.TabPageEmail.Controls.Add(Me.ListViewMailDetail)
        Me.TabPageEmail.Location = New System.Drawing.Point(4, 22)
        Me.TabPageEmail.Name = "TabPageEmail"
        Me.TabPageEmail.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEmail.Size = New System.Drawing.Size(623, 163)
        Me.TabPageEmail.TabIndex = 1
        Me.TabPageEmail.Text = "Mail"
        Me.TabPageEmail.UseVisualStyleBackColor = True
        '
        'ListViewMailDetail
        '
        Me.ListViewMailDetail.BackColor = System.Drawing.SystemColors.Window
        Me.ListViewMailDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewMailDetail.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ListViewMailDetail.FullRowSelect = True
        Me.ListViewMailDetail.HideSelection = False
        Me.ListViewMailDetail.Location = New System.Drawing.Point(3, 3)
        Me.ListViewMailDetail.Name = "ListViewMailDetail"
        Me.ListViewMailDetail.Size = New System.Drawing.Size(617, 157)
        Me.ListViewMailDetail.TabIndex = 90
        Me.ListViewMailDetail.UseCompatibleStateImageBehavior = False
        Me.ListViewMailDetail.View = System.Windows.Forms.View.List
        '
        'BetalingsVerzoek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btClose
        Me.ClientSize = New System.Drawing.Size(728, 379)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControlPremium)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.lblInOntwikkeling)
        Me.Controls.Add(Me.cbTB2Info)
        Me.Controls.Add(Me.ckMetDatum)
        Me.Controls.Add(Me.cbListCompanies)
        Me.Controls.Add(Me.Post)
        Me.Controls.Add(Me.TekstBewaren)
        Me.Controls.Add(Me.MetOverschrijving)
        Me.Controls.Add(Me._TekstInfo_3)
        Me.Controls.Add(Me._TekstInfo_2)
        Me.Controls.Add(Me.tbInfoTekst)
        Me.Controls.Add(Me.cbLanguage)
        Me.Controls.Add(Me.cbPaymentType)
        Me.Controls.Add(Me.btPrintOut)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.bClear)
        Me.Controls.Add(Me._LabelInfo_0)
        Me.Controls.Add(Me.CRLFCaption)
        Me.Controls.Add(Me._LabelInfo_4)
        Me.Controls.Add(Me._LabelInfo_3)
        Me.Controls.Add(Me._LabelInfo_2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BetalingsVerzoek"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBetalingsVerzoek"
        Me.TabControlPremium.ResumeLayout(False)
        Me.TabPagePost.ResumeLayout(False)
        Me.TabPageEmail.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents cbTB2Info As CheckBox
    Public WithEvents ckMetDatum As CheckBox
    Public WithEvents cbListCompanies As ComboBox
    Public WithEvents Post As CheckBox
    Public WithEvents TekstBewaren As Button
    Public WithEvents _TekstInfo_3 As TextBox
    Public WithEvents _TekstInfo_2 As TextBox
    Public WithEvents tbInfoTekst As TextBox
    Public WithEvents cbLanguage As ComboBox
    Public WithEvents cbPaymentType As ComboBox
    Public WithEvents btPrintOut As Button
    Public WithEvents btClose As Button
    Public WithEvents bClear As Button
    Public WithEvents _LabelInfo_0 As Label
    Public WithEvents CRLFCaption As Label
    Public WithEvents _LabelInfo_4 As Label
    Public WithEvents _LabelInfo_3 As Label
    Public WithEvents _LabelInfo_2 As Label
    Friend WithEvents lblInOntwikkeling As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Public WithEvents ListViewPostDetail As ListView
    Public WithEvents btnAdd As Button
    Public WithEvents MetOverschrijving As CheckBox
    Friend WithEvents TabControlPremium As TabControl
    Friend WithEvents TabPagePost As TabPage
    Friend WithEvents TabPageEmail As TabPage
    Public WithEvents ListViewMailDetail As ListView
End Class
