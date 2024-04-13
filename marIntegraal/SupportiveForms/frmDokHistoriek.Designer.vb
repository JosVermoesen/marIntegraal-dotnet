<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDokHistoriek
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
        Me.lstDokHistoriek = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lstDokHistoriek
        '
        Me.lstDokHistoriek.BackColor = System.Drawing.SystemColors.Window
        Me.lstDokHistoriek.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstDokHistoriek.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstDokHistoriek.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDokHistoriek.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstDokHistoriek.ItemHeight = 14
        Me.lstDokHistoriek.Location = New System.Drawing.Point(0, 0)
        Me.lstDokHistoriek.Name = "lstDokHistoriek"
        Me.lstDokHistoriek.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstDokHistoriek.Size = New System.Drawing.Size(283, 166)
        Me.lstDokHistoriek.TabIndex = 1
        '
        'frmDokHistoriek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 166)
        Me.Controls.Add(Me.lstDokHistoriek)
        Me.Name = "frmDokHistoriek"
        Me.Text = "frmDokHistoriek"
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents lstDokHistoriek As ListBox
    Public WithEvents ToolTip1 As ToolTip
End Class
