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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CmdJournaalManueel = New System.Windows.Forms.Button()
        Me.LbUittrekselsLijst = New System.Windows.Forms.ListBox()
        Me.CbFinancialChoosen = New System.Windows.Forms.ComboBox()
        Me.TbTekstLijn = New System.Windows.Forms.TextBox()
        Me.BtnGenerateReport = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me.DateTimePickerProcessingDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
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
        'LbUittrekselsLijst
        '
        Me.LbUittrekselsLijst.BackColor = System.Drawing.SystemColors.Window
        Me.LbUittrekselsLijst.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUittrekselsLijst.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LbUittrekselsLijst.ItemHeight = 16
        Me.LbUittrekselsLijst.Location = New System.Drawing.Point(1, 96)
        Me.LbUittrekselsLijst.Name = "LbUittrekselsLijst"
        Me.LbUittrekselsLijst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LbUittrekselsLijst.Size = New System.Drawing.Size(457, 212)
        Me.LbUittrekselsLijst.Sorted = True
        Me.LbUittrekselsLijst.TabIndex = 15
        '
        'CbFinancialChoosen
        '
        Me.CbFinancialChoosen.BackColor = System.Drawing.Color.White
        Me.CbFinancialChoosen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbFinancialChoosen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CbFinancialChoosen.Location = New System.Drawing.Point(93, 72)
        Me.CbFinancialChoosen.Name = "CbFinancialChoosen"
        Me.CbFinancialChoosen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CbFinancialChoosen.Size = New System.Drawing.Size(259, 21)
        Me.CbFinancialChoosen.TabIndex = 14
        '
        'TbTekstLijn
        '
        Me.TbTekstLijn.AcceptsReturn = True
        Me.TbTekstLijn.BackColor = System.Drawing.Color.White
        Me.TbTekstLijn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbTekstLijn.ForeColor = System.Drawing.Color.Black
        Me.TbTekstLijn.Location = New System.Drawing.Point(1, 32)
        Me.TbTekstLijn.MaxLength = 0
        Me.TbTekstLijn.Name = "TbTekstLijn"
        Me.TbTekstLijn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TbTekstLijn.Size = New System.Drawing.Size(169, 20)
        Me.TbTekstLijn.TabIndex = 2
        '
        'BtnGenerateReport
        '
        Me.BtnGenerateReport.BackColor = System.Drawing.SystemColors.Control
        Me.BtnGenerateReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnGenerateReport.Location = New System.Drawing.Point(363, 12)
        Me.BtnGenerateReport.Name = "BtnGenerateReport"
        Me.BtnGenerateReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGenerateReport.Size = New System.Drawing.Size(96, 29)
        Me.BtnGenerateReport.TabIndex = 16
        Me.BtnGenerateReport.Text = "Genereren"
        Me.BtnGenerateReport.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnClose.Location = New System.Drawing.Point(359, 310)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnClose.Size = New System.Drawing.Size(96, 25)
        Me.BtnClose.TabIndex = 21
        Me.BtnClose.TabStop = False
        Me.BtnClose.Text = "Sluiten"
        Me.BtnClose.UseVisualStyleBackColor = False
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
        Me._Label1_0.Size = New System.Drawing.Size(135, 18)
        Me._Label1_0.TabIndex = 1
        Me._Label1_0.Text = "Afdrukperiode Van - &Tot"
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(176, 12)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(93, 18)
        Me._Label1_1.TabIndex = 19
        Me._Label1_1.Text = "Datu&m Drukken"
        '
        'DateTimePickerProcessingDate
        '
        Me.DateTimePickerProcessingDate.Location = New System.Drawing.Point(176, 33)
        Me.DateTimePickerProcessingDate.MaxDate = New Date(2061, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerProcessingDate.MinDate = New Date(1985, 12, 1, 0, 0, 0, 0)
        Me.DateTimePickerProcessingDate.Name = "DateTimePickerProcessingDate"
        Me.DateTimePickerProcessingDate.Size = New System.Drawing.Size(176, 20)
        Me.DateTimePickerProcessingDate.TabIndex = 89
        '
        'FormFinancialBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(468, 339)
        Me.Controls.Add(Me.DateTimePickerProcessingDate)
        Me.Controls.Add(Me.CmdJournaalManueel)
        Me.Controls.Add(Me.LbUittrekselsLijst)
        Me.Controls.Add(Me.CbFinancialChoosen)
        Me.Controls.Add(Me.TbTekstLijn)
        Me.Controls.Add(Me.BtnGenerateReport)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_0)
        Me.Controls.Add(Me._Label1_1)
        Me.Name = "FormFinancialBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FinancialBook"
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Public WithEvents ToolTip1 As ToolTip
    Public WithEvents CmdJournaalManueel As Button
    Public WithEvents LbUittrekselsLijst As ListBox
    Public WithEvents CbFinancialChoosen As ComboBox
    Public WithEvents TbTekstLijn As TextBox
    Public WithEvents BtnGenerateReport As Button
    Public WithEvents BtnClose As Button
    Public WithEvents _Label1_2 As Label
    Public WithEvents _Label1_0 As Label
    Public WithEvents _Label1_1 As Label
    Friend WithEvents DateTimePickerProcessingDate As DateTimePicker
End Class
