<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penjualan_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Penjualan_Form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kode_dokter_lbl = New System.Windows.Forms.Label()
        Me.nm_dokter_box = New System.Windows.Forms.TextBox()
        Me.kode_obat_lbl = New System.Windows.Forms.Label()
        Me.nm_obat_box = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jmlh_box = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.hrg_jual_box = New System.Windows.Forms.TextBox()
        Me.potongan_box = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.A1 = New System.Windows.Forms.Label()
        Me.A2 = New System.Windows.Forms.Label()
        Me.A5 = New System.Windows.Forms.Label()
        Me.A7 = New System.Windows.Forms.Label()
        Me.A12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tot_lbl = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(11, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dokter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(11, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Obat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(10, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah"
        '
        'kode_dokter_lbl
        '
        Me.kode_dokter_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.kode_dokter_lbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.kode_dokter_lbl.Location = New System.Drawing.Point(87, 13)
        Me.kode_dokter_lbl.Name = "kode_dokter_lbl"
        Me.kode_dokter_lbl.Size = New System.Drawing.Size(47, 21)
        Me.kode_dokter_lbl.TabIndex = 62
        Me.kode_dokter_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nm_dokter_box
        '
        Me.nm_dokter_box.Location = New System.Drawing.Point(140, 14)
        Me.nm_dokter_box.Name = "nm_dokter_box"
        Me.nm_dokter_box.Size = New System.Drawing.Size(100, 20)
        Me.nm_dokter_box.TabIndex = 63
        '
        'kode_obat_lbl
        '
        Me.kode_obat_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.kode_obat_lbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.kode_obat_lbl.Location = New System.Drawing.Point(87, 47)
        Me.kode_obat_lbl.Name = "kode_obat_lbl"
        Me.kode_obat_lbl.Size = New System.Drawing.Size(47, 21)
        Me.kode_obat_lbl.TabIndex = 64
        Me.kode_obat_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nm_obat_box
        '
        Me.nm_obat_box.Location = New System.Drawing.Point(140, 48)
        Me.nm_obat_box.Name = "nm_obat_box"
        Me.nm_obat_box.Size = New System.Drawing.Size(100, 20)
        Me.nm_obat_box.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(259, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Harga Jual"
        '
        'jmlh_box
        '
        Me.jmlh_box.Location = New System.Drawing.Point(87, 86)
        Me.jmlh_box.Name = "jmlh_box"
        Me.jmlh_box.Size = New System.Drawing.Size(47, 20)
        Me.jmlh_box.TabIndex = 67
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(259, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Potongan"
        '
        'hrg_jual_box
        '
        Me.hrg_jual_box.Location = New System.Drawing.Point(326, 13)
        Me.hrg_jual_box.Name = "hrg_jual_box"
        Me.hrg_jual_box.Size = New System.Drawing.Size(100, 20)
        Me.hrg_jual_box.TabIndex = 69
        '
        'potongan_box
        '
        Me.potongan_box.Location = New System.Drawing.Point(326, 47)
        Me.potongan_box.Name = "potongan_box"
        Me.potongan_box.Size = New System.Drawing.Size(100, 20)
        Me.potongan_box.TabIndex = 70
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(177, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Total Harga"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(262, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(164, 20)
        Me.TextBox1.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(544, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 24)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "No. Nota"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(634, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 26)
        Me.Label8.TabIndex = 74
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 126)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(716, 285)
        Me.DataGridView1.TabIndex = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(4, -4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(716, 124)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label9.Location = New System.Drawing.Point(14, 422)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "NOTE"
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.A1.Location = New System.Drawing.Point(14, 450)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(81, 13)
        Me.A1.TabIndex = 78
        Me.A1.Text = "F1 - Cari Dokter"
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.A2.Location = New System.Drawing.Point(101, 450)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(72, 13)
        Me.A2.TabIndex = 79
        Me.A2.Text = "F2 - Cari Obat"
        '
        'A5
        '
        Me.A5.AutoSize = True
        Me.A5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.A5.Location = New System.Drawing.Point(179, 450)
        Me.A5.Name = "A5"
        Me.A5.Size = New System.Drawing.Size(55, 13)
        Me.A5.TabIndex = 80
        Me.A5.Text = "F5 - Bayar"
        '
        'A7
        '
        Me.A7.AutoSize = True
        Me.A7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.A7.Location = New System.Drawing.Point(240, 450)
        Me.A7.Name = "A7"
        Me.A7.Size = New System.Drawing.Size(56, 13)
        Me.A7.TabIndex = 81
        Me.A7.Text = "F7 - Reset"
        '
        'A12
        '
        Me.A12.AutoSize = True
        Me.A12.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.A12.Location = New System.Drawing.Point(302, 450)
        Me.A12.Name = "A12"
        Me.A12.Size = New System.Drawing.Size(65, 13)
        Me.A12.TabIndex = 82
        Me.A12.Text = "F12 - Delete"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox2.Location = New System.Drawing.Point(4, 410)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 64)
        Me.GroupBox2.TabIndex = 83
        Me.GroupBox2.TabStop = False
        '
        'tot_lbl
        '
        Me.tot_lbl.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.tot_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tot_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tot_lbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tot_lbl.Location = New System.Drawing.Point(537, 422)
        Me.tot_lbl.Name = "tot_lbl"
        Me.tot_lbl.Size = New System.Drawing.Size(183, 52)
        Me.tot_lbl.TabIndex = 75
        Me.tot_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Penjualan_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(728, 477)
        Me.Controls.Add(Me.tot_lbl)
        Me.Controls.Add(Me.A12)
        Me.Controls.Add(Me.A7)
        Me.Controls.Add(Me.A5)
        Me.Controls.Add(Me.A2)
        Me.Controls.Add(Me.A1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.potongan_box)
        Me.Controls.Add(Me.hrg_jual_box)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.jmlh_box)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nm_obat_box)
        Me.Controls.Add(Me.kode_obat_lbl)
        Me.Controls.Add(Me.nm_dokter_box)
        Me.Controls.Add(Me.kode_dokter_lbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Penjualan_Form"
        Me.Text = "Transaksi Penjualan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents kode_dokter_lbl As Label
    Friend WithEvents nm_dokter_box As TextBox
    Friend WithEvents kode_obat_lbl As Label
    Friend WithEvents nm_obat_box As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents jmlh_box As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents hrg_jual_box As TextBox
    Friend WithEvents potongan_box As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents A1 As Label
    Friend WithEvents A2 As Label
    Friend WithEvents A5 As Label
    Friend WithEvents A7 As Label
    Friend WithEvents A12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tot_lbl As Label
End Class
