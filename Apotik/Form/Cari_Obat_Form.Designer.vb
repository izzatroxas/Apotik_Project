<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cari_Obat_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cari_Obat_Form))
        Me.dgv_obat = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cari_box = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgv_obat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_obat
        '
        Me.dgv_obat.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.dgv_obat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_obat.Location = New System.Drawing.Point(4, 51)
        Me.dgv_obat.Name = "dgv_obat"
        Me.dgv_obat.Size = New System.Drawing.Size(524, 316)
        Me.dgv_obat.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Chocolate
        Me.GroupBox3.Controls.Add(Me.cari_box)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(319, 40)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'cari_box
        '
        Me.cari_box.Location = New System.Drawing.Point(172, 12)
        Me.cari_box.Name = "cari_box"
        Me.cari_box.Size = New System.Drawing.Size(139, 20)
        Me.cari_box.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label11.Location = New System.Drawing.Point(5, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Pencarian (Kode/Dokter)"
        '
        'Cari_Obat_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(534, 373)
        Me.Controls.Add(Me.dgv_obat)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cari_Obat_Form"
        Me.Text = "Cari Obat"
        CType(Me.dgv_obat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_obat As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cari_box As TextBox
    Friend WithEvents Label11 As Label
End Class
