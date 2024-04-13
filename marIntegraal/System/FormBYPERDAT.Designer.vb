<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBYPERDAT
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
        Me.PeriodeBoekjaar = New System.Windows.Forms.ComboBox()
        Me.Boekjaar = New System.Windows.Forms.ComboBox()
        Me.Verkleinen = New System.Windows.Forms.Button()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me.DatumVerwerking = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout
        '
        'PeriodeBoekjaar
        '
        Me.PeriodeBoekjaar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.PeriodeBoekjaar.Cursor = System.Windows.Forms.Cursors.Default
        Me.PeriodeBoekjaar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PeriodeBoekjaar.ForeColor = System.Drawing.Color.Black
        Me.PeriodeBoekjaar.Location = New System.Drawing.Point(100, 30)
        Me.PeriodeBoekjaar.Name = "PeriodeBoekjaar"
        Me.PeriodeBoekjaar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PeriodeBoekjaar.Size = New System.Drawing.Size(200, 21)
        Me.PeriodeBoekjaar.TabIndex = 1
        '
        'Boekjaar
        '
        Me.Boekjaar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.Boekjaar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Boekjaar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Boekjaar.ForeColor = System.Drawing.Color.Black
        Me.Boekjaar.Location = New System.Drawing.Point(229, 57)
        Me.Boekjaar.Name = "Boekjaar"
        Me.Boekjaar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Boekjaar.Size = New System.Drawing.Size(71, 21)
        Me.Boekjaar.TabIndex = 3
        '
        'Verkleinen
        '
        Me.Verkleinen.BackColor = System.Drawing.SystemColors.Control
        Me.Verkleinen.Cursor = System.Windows.Forms.Cursors.Default
        Me.Verkleinen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Verkleinen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Verkleinen.Location = New System.Drawing.Point(6, 57)
        Me.Verkleinen.Name = "Verkleinen"
        Me.Verkleinen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Verkleinen.Size = New System.Drawing.Size(83, 24)
        Me.Verkleinen.TabIndex = 12
        Me.Verkleinen.TabStop = false
        Me.Verkleinen.Text = "Minimaliseren"
        Me.Verkleinen.UseVisualStyleBackColor = false
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_0.Location = New System.Drawing.Point(4, 6)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(93, 17)
        Me._Label1_0.TabIndex = 4
        Me._Label1_0.Text = "&Datum vandaag"
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_2.Location = New System.Drawing.Point(3, 36)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(91, 15)
        Me._Label1_2.TabIndex = 0
        Me._Label1_2.Text = "Aktieve &Periode"
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label1_1.Location = New System.Drawing.Point(131, 60)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(92, 16)
        Me._Label1_1.TabIndex = 2
        Me._Label1_1.Text = "Aktief &Boekjaar"
        '
        'DatumVerwerking
        '
        Me.DatumVerwerking.Location = New System.Drawing.Point(100, 4)
        Me.DatumVerwerking.Name = "DatumVerwerking"
        Me.DatumVerwerking.Size = New System.Drawing.Size(200, 20)
        Me.DatumVerwerking.TabIndex = 5
        '
        'frmBYPERDAT
        '
        Me.AcceptButton = Me.Verkleinen
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Verkleinen
        Me.ClientSize = New System.Drawing.Size(314, 86)
        Me.ControlBox = false
        Me.Controls.Add(Me.DatumVerwerking)
        Me.Controls.Add(Me.PeriodeBoekjaar)
        Me.Controls.Add(Me.Boekjaar)
        Me.Controls.Add(Me.Verkleinen)
        Me.Controls.Add(Me._Label1_0)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.Name = "frmBYPERDAT"
        Me.Text = "frmBYPERDAT"
        Me.ResumeLayout(false)

End Sub
    Public WithEvents PeriodeBoekjaar As ComboBox
    Public WithEvents Boekjaar As ComboBox
    Public WithEvents Verkleinen As Button
    Public WithEvents _Label1_0 As Label
    Public WithEvents _Label1_2 As Label
    Public WithEvents _Label1_1 As Label
    Friend WithEvents DatumVerwerking As DateTimePicker
End Class
