<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoriekRekeningScherm
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
        Me.GansePeriode = New System.Windows.Forms.CheckBox()
        Me.TxtLijnen = New System.Windows.Forms.TextBox()
        Me.tbRekening = New System.Windows.Forms.TextBox()
        Me.tbVanTot = New System.Windows.Forms.TextBox()
        Me.btnLager = New System.Windows.Forms.Button()
        Me.btnHoger = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblLijnen = New System.Windows.Forms.Label()
        Me.lblTussenmelding = New System.Windows.Forms.Label()
        Me.lblPeriodeVanTot = New System.Windows.Forms.Label()
        Me.lblRekening = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblCSInfo = New System.Windows.Forms.Label()
        Me.LblSaldo = New System.Windows.Forms.Label()
        Me.lvJournaalDetail = New System.Windows.Forms.ListView()
        Me.lblSelectie = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'GansePeriode
        '
        Me.GansePeriode.BackColor = System.Drawing.SystemColors.Control
        Me.GansePeriode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GansePeriode.Checked = true
        Me.GansePeriode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GansePeriode.Enabled = False
        Me.GansePeriode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GansePeriode.Location = New System.Drawing.Point(609, 403)
        Me.GansePeriode.Name = "GansePeriode"
        Me.GansePeriode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GansePeriode.Size = New System.Drawing.Size(97, 22)
        Me.GansePeriode.TabIndex = 32
        Me.GansePeriode.Text = "&Boekjaar"
        Me.GansePeriode.UseVisualStyleBackColor = False
        '
        'TxtLijnen
        '
        Me.TxtLijnen.AcceptsReturn = True
        Me.TxtLijnen.BackColor = System.Drawing.Color.White
        Me.TxtLijnen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtLijnen.ForeColor = System.Drawing.Color.Black
        Me.TxtLijnen.Location = New System.Drawing.Point(607, 374)
        Me.TxtLijnen.MaxLength = 4
        Me.TxtLijnen.Name = "TxtLijnen"
        Me.TxtLijnen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtLijnen.Size = New System.Drawing.Size(56, 20)
        Me.TxtLijnen.TabIndex = 27
        '
        'tbRekening
        '
        Me.tbRekening.AcceptsReturn = True
        Me.tbRekening.BackColor = System.Drawing.Color.White
        Me.tbRekening.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbRekening.ForeColor = System.Drawing.Color.Black
        Me.tbRekening.Location = New System.Drawing.Point(430, 443)
        Me.tbRekening.MaxLength = 0
        Me.tbRekening.Name = "tbRekening"
        Me.tbRekening.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbRekening.Size = New System.Drawing.Size(96, 20)
        Me.tbRekening.TabIndex = 19
        '
        'tbVanTot
        '
        Me.tbVanTot.AcceptsReturn = True
        Me.tbVanTot.BackColor = System.Drawing.Color.White
        Me.tbVanTot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbVanTot.ForeColor = System.Drawing.Color.Black
        Me.tbVanTot.Location = New System.Drawing.Point(110, 443)
        Me.tbVanTot.MaxLength = 0
        Me.tbVanTot.Name = "tbVanTot"
        Me.tbVanTot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbVanTot.Size = New System.Drawing.Size(178, 20)
        Me.tbVanTot.TabIndex = 21
        '
        'btnLager
        '
        Me.btnLager.BackColor = System.Drawing.SystemColors.Control
        Me.btnLager.Enabled = False
        Me.btnLager.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLager.Location = New System.Drawing.Point(594, 124)
        Me.btnLager.Name = "btnLager"
        Me.btnLager.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnLager.Size = New System.Drawing.Size(112, 25)
        Me.btnLager.TabIndex = 25
        Me.btnLager.TabStop = False
        Me.btnLager.Text = "&Lager"
        Me.btnLager.UseVisualStyleBackColor = False
        '
        'btnHoger
        '
        Me.btnHoger.BackColor = System.Drawing.SystemColors.Control
        Me.btnHoger.Enabled = False
        Me.btnHoger.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnHoger.Location = New System.Drawing.Point(593, 97)
        Me.btnHoger.Name = "btnHoger"
        Me.btnHoger.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnHoger.Size = New System.Drawing.Size(113, 25)
        Me.btnHoger.TabIndex = 24
        Me.btnHoger.TabStop = False
        Me.btnHoger.Text = "&Hoger"
        Me.btnHoger.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearch.Location = New System.Drawing.Point(532, 442)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSearch.Size = New System.Drawing.Size(53, 25)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.TabStop = False
        Me.btnSearch.Text = "&Zoek"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblLijnen
        '
        Me.lblLijnen.AutoSize = True
        Me.lblLijnen.BackColor = System.Drawing.SystemColors.Control
        Me.lblLijnen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLijnen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLijnen.Location = New System.Drawing.Point(669, 374)
        Me.lblLijnen.Name = "lblLijnen"
        Me.lblLijnen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLijnen.Size = New System.Drawing.Size(37, 15)
        Me.lblLijnen.TabIndex = 28
        Me.lblLijnen.Text = "Lijnen"
        '
        'lblTussenmelding
        '
        Me.lblTussenmelding.BackColor = System.Drawing.SystemColors.Control
        Me.lblTussenmelding.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTussenmelding.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTussenmelding.Location = New System.Drawing.Point(607, 332)
        Me.lblTussenmelding.Name = "lblTussenmelding"
        Me.lblTussenmelding.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTussenmelding.Size = New System.Drawing.Size(99, 31)
        Me.lblTussenmelding.TabIndex = 26
        Me.lblTussenmelding.Text = "Tussenstop &Melden na:"
        '
        'lblPeriodeVanTot
        '
        Me.lblPeriodeVanTot.BackColor = System.Drawing.SystemColors.Control
        Me.lblPeriodeVanTot.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPeriodeVanTot.Location = New System.Drawing.Point(12, 446)
        Me.lblPeriodeVanTot.Name = "lblPeriodeVanTot"
        Me.lblPeriodeVanTot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPeriodeVanTot.Size = New System.Drawing.Size(101, 14)
        Me.lblPeriodeVanTot.TabIndex = 20
        Me.lblPeriodeVanTot.Text = "&Periode Van - Tot"
        '
        'lblRekening
        '
        Me.lblRekening.BackColor = System.Drawing.SystemColors.Control
        Me.lblRekening.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRekening.Location = New System.Drawing.Point(377, 446)
        Me.lblRekening.Name = "lblRekening"
        Me.lblRekening.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRekening.Size = New System.Drawing.Size(58, 17)
        Me.lblRekening.TabIndex = 18
        Me.lblRekening.Text = "&Rekening"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(595, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClose.Size = New System.Drawing.Size(111, 25)
        Me.btnClose.TabIndex = 23
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Sluiten"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblCSInfo
        '
        Me.lblCSInfo.BackColor = System.Drawing.SystemColors.Control
        Me.lblCSInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCSInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCSInfo.Location = New System.Drawing.Point(592, 291)
        Me.lblCSInfo.Name = "lblCSInfo"
        Me.lblCSInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCSInfo.Size = New System.Drawing.Size(114, 28)
        Me.lblCSInfo.TabIndex = 31
        Me.lblCSInfo.Text = "Creditsaldo = bedrag in min !"
        Me.lblCSInfo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblSaldo
        '
        Me.LblSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSaldo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblSaldo.Location = New System.Drawing.Point(592, 262)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblSaldo.Size = New System.Drawing.Size(114, 20)
        Me.LblSaldo.TabIndex = 30
        Me.LblSaldo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lvJournaalDetail
        '
        Me.lvJournaalDetail.BackColor = System.Drawing.SystemColors.Window
        Me.lvJournaalDetail.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvJournaalDetail.FullRowSelect = True
        Me.lvJournaalDetail.HideSelection = False
        Me.lvJournaalDetail.Location = New System.Drawing.Point(15, 19)
        Me.lvJournaalDetail.Name = "lvJournaalDetail"
        Me.lvJournaalDetail.Size = New System.Drawing.Size(571, 418)
        Me.lvJournaalDetail.TabIndex = 90
        Me.lvJournaalDetail.UseCompatibleStateImageBehavior = False
        Me.lvJournaalDetail.View = System.Windows.Forms.View.List
        '
        'lblSelectie
        '
        Me.lblSelectie.AutoSize = True
        Me.lblSelectie.Location = New System.Drawing.Point(592, 249)
        Me.lblSelectie.Name = "lblSelectie"
        Me.lblSelectie.Size = New System.Drawing.Size(114, 13)
        Me.lblSelectie.TabIndex = 91
        Me.lblSelectie.Text = "Saldo Huidige Selectie"
        '
        'HistoriekRekeningScherm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(718, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSelectie)
        Me.Controls.Add(Me.GansePeriode)
        Me.Controls.Add(Me.TxtLijnen)
        Me.Controls.Add(Me.tbVanTot)
        Me.Controls.Add(Me.btnLager)
        Me.Controls.Add(Me.btnHoger)
        Me.Controls.Add(Me.tbRekening)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblLijnen)
        Me.Controls.Add(Me.lblTussenmelding)
        Me.Controls.Add(Me.lblPeriodeVanTot)
        Me.Controls.Add(Me.lblRekening)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblCSInfo)
        Me.Controls.Add(Me.LblSaldo)
        Me.Controls.Add(Me.lvJournaalDetail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "HistoriekRekeningScherm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Historiek Grootboek Rekening"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Public WithEvents GansePeriode As CheckBox
    Public WithEvents TxtLijnen As TextBox
    Public WithEvents tbRekening As TextBox
    Public WithEvents tbVanTot As TextBox
    Public WithEvents btnLager As Button
    Public WithEvents btnHoger As Button
    Public WithEvents btnSearch As Button
    Public WithEvents lblLijnen As Label
    Public WithEvents lblTussenmelding As Label
    Public WithEvents lblPeriodeVanTot As Label
    Public WithEvents lblRekening As Label
    Public WithEvents btnClose As Button
    Public WithEvents lblCSInfo As Label
    Public WithEvents LblSaldo As Label
    Public WithEvents lvJournaalDetail As ListView
    Friend WithEvents lblSelectie As Label
End Class
