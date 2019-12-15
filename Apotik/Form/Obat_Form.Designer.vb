<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Obat_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Obat_Form))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.kode = New System.Windows.Forms.Label()
        Me.laba_box = New System.Windows.Forms.TextBox()
        Me.hrg_jual = New System.Windows.Forms.TextBox()
        Me.satu_an = New System.Windows.Forms.ComboBox()
        Me.hrg_beli = New System.Windows.Forms.TextBox()
        Me.stok_obat = New System.Windows.Forms.TextBox()
        Me.kategori_obat = New System.Windows.Forms.ComboBox()
        Me.nm_obat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.reset_btn = New System.Windows.Forms.Button()
        Me.del_btn = New System.Windows.Forms.Button()
        Me.edit_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cari_box = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ProjectDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet = New Apotik.projectDataSet()
        Me.dgv_obat = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ProjectDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_obat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Chocolate
        Me.GroupBox1.Controls.Add(Me.kode)
        Me.GroupBox1.Controls.Add(Me.laba_box)
        Me.GroupBox1.Controls.Add(Me.hrg_jual)
        Me.GroupBox1.Controls.Add(Me.satu_an)
        Me.GroupBox1.Controls.Add(Me.hrg_beli)
        Me.GroupBox1.Controls.Add(Me.stok_obat)
        Me.GroupBox1.Controls.Add(Me.kategori_obat)
        Me.GroupBox1.Controls.Add(Me.nm_obat)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 365)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'kode
        '
        Me.kode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.kode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.kode.Location = New System.Drawing.Point(96, 23)
        Me.kode.Name = "kode"
        Me.kode.Size = New System.Drawing.Size(136, 21)
        Me.kode.TabIndex = 61
        Me.kode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'laba_box
        '
        Me.laba_box.Location = New System.Drawing.Point(96, 208)
        Me.laba_box.Name = "laba_box"
        Me.laba_box.ReadOnly = True
        Me.laba_box.Size = New System.Drawing.Size(136, 20)
        Me.laba_box.TabIndex = 9
        '
        'hrg_jual
        '
        Me.hrg_jual.Location = New System.Drawing.Point(96, 181)
        Me.hrg_jual.Name = "hrg_jual"
        Me.hrg_jual.Size = New System.Drawing.Size(136, 20)
        Me.hrg_jual.TabIndex = 9
        '
        'satu_an
        '
        Me.satu_an.AutoCompleteCustomSource.AddRange(New String() {"Pilih", "Tablet", "Strip", "Pak", "Pieces", "Botol", "Sachet", "Ampul"})
        Me.satu_an.FormattingEnabled = True
        Me.satu_an.Location = New System.Drawing.Point(96, 73)
        Me.satu_an.Name = "satu_an"
        Me.satu_an.Size = New System.Drawing.Size(136, 21)
        Me.satu_an.TabIndex = 10
        Me.satu_an.Text = "Pilih"
        '
        'hrg_beli
        '
        Me.hrg_beli.Location = New System.Drawing.Point(96, 155)
        Me.hrg_beli.Name = "hrg_beli"
        Me.hrg_beli.Size = New System.Drawing.Size(136, 20)
        Me.hrg_beli.TabIndex = 9
        '
        'stok_obat
        '
        Me.stok_obat.Location = New System.Drawing.Point(96, 129)
        Me.stok_obat.Name = "stok_obat"
        Me.stok_obat.Size = New System.Drawing.Size(136, 20)
        Me.stok_obat.TabIndex = 9
        '
        'kategori_obat
        '
        Me.kategori_obat.AutoCompleteCustomSource.AddRange(New String() {"Pilih", "Generik", "Paten", "Tes"})
        Me.kategori_obat.FormattingEnabled = True
        Me.kategori_obat.Location = New System.Drawing.Point(96, 102)
        Me.kategori_obat.Name = "kategori_obat"
        Me.kategori_obat.Size = New System.Drawing.Size(136, 21)
        Me.kategori_obat.TabIndex = 11
        Me.kategori_obat.Text = "Pilih"
        '
        'nm_obat
        '
        Me.nm_obat.Location = New System.Drawing.Point(96, 47)
        Me.nm_obat.Name = "nm_obat"
        Me.nm_obat.Size = New System.Drawing.Size(136, 20)
        Me.nm_obat.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label8.Location = New System.Drawing.Point(11, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Laba"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label7.Location = New System.Drawing.Point(10, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Harga Jual"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label6.Location = New System.Drawing.Point(11, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Harga Beli"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Location = New System.Drawing.Point(10, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stok Obat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(10, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kategori"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(11, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Satuan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(10, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Obat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(10, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Obat"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.exit_btn)
        Me.GroupBox2.Controls.Add(Me.reset_btn)
        Me.GroupBox2.Controls.Add(Me.del_btn)
        Me.GroupBox2.Controls.Add(Me.edit_btn)
        Me.GroupBox2.Controls.Add(Me.save_btn)
        Me.GroupBox2.Controls.Add(Me.add_btn)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 116)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(6, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "* Tidak Boleh Kosong"
        '
        'exit_btn
        '
        Me.exit_btn.BackgroundImage = CType(resources.GetObject("exit_btn.BackgroundImage"), System.Drawing.Image)
        Me.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.exit_btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.exit_btn.Location = New System.Drawing.Point(170, 48)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(75, 23)
        Me.exit_btn.TabIndex = 1
        Me.exit_btn.Text = "Clean"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'reset_btn
        '
        Me.reset_btn.BackgroundImage = CType(resources.GetObject("reset_btn.BackgroundImage"), System.Drawing.Image)
        Me.reset_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.reset_btn.Location = New System.Drawing.Point(87, 48)
        Me.reset_btn.Name = "reset_btn"
        Me.reset_btn.Size = New System.Drawing.Size(75, 23)
        Me.reset_btn.TabIndex = 1
        Me.reset_btn.Text = "Reset"
        Me.reset_btn.UseVisualStyleBackColor = True
        '
        'del_btn
        '
        Me.del_btn.BackgroundImage = CType(resources.GetObject("del_btn.BackgroundImage"), System.Drawing.Image)
        Me.del_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.del_btn.Location = New System.Drawing.Point(6, 48)
        Me.del_btn.Name = "del_btn"
        Me.del_btn.Size = New System.Drawing.Size(75, 23)
        Me.del_btn.TabIndex = 1
        Me.del_btn.Text = "Delete"
        Me.del_btn.UseVisualStyleBackColor = True
        '
        'edit_btn
        '
        Me.edit_btn.BackgroundImage = CType(resources.GetObject("edit_btn.BackgroundImage"), System.Drawing.Image)
        Me.edit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.edit_btn.Location = New System.Drawing.Point(168, 19)
        Me.edit_btn.Name = "edit_btn"
        Me.edit_btn.Size = New System.Drawing.Size(75, 23)
        Me.edit_btn.TabIndex = 1
        Me.edit_btn.Text = "Edit"
        Me.edit_btn.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.BackgroundImage = CType(resources.GetObject("save_btn.BackgroundImage"), System.Drawing.Image)
        Me.save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.save_btn.Location = New System.Drawing.Point(87, 19)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(75, 23)
        Me.save_btn.TabIndex = 1
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'add_btn
        '
        Me.add_btn.BackgroundImage = CType(resources.GetObject("add_btn.BackgroundImage"), System.Drawing.Image)
        Me.add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.add_btn.Location = New System.Drawing.Point(6, 19)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(75, 23)
        Me.add_btn.TabIndex = 0
        Me.add_btn.Text = "Add"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label10.Location = New System.Drawing.Point(381, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 31)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Data Obat"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Chocolate
        Me.GroupBox3.Controls.Add(Me.cari_box)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(257, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(319, 40)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'cari_box
        '
        Me.cari_box.Location = New System.Drawing.Point(174, 13)
        Me.cari_box.Name = "cari_box"
        Me.cari_box.Size = New System.Drawing.Size(139, 20)
        Me.cari_box.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label11.Location = New System.Drawing.Point(7, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Pencarian (Kode/Obat/Kategori)"
        '
        'ProjectDataSetBindingSource
        '
        Me.ProjectDataSetBindingSource.DataSource = Me.ProjectDataSet
        Me.ProjectDataSetBindingSource.Position = 0
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "projectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgv_obat
        '
        Me.dgv_obat.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.dgv_obat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_obat.Location = New System.Drawing.Point(257, 103)
        Me.dgv_obat.Name = "dgv_obat"
        Me.dgv_obat.Size = New System.Drawing.Size(637, 316)
        Me.dgv_obat.TabIndex = 3
        '
        'Obat_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(906, 431)
        Me.Controls.Add(Me.dgv_obat)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Obat_Form"
        Me.Text = "Data Obat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ProjectDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_obat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents laba_box As TextBox
    Friend WithEvents hrg_jual As TextBox
    Friend WithEvents satu_an As ComboBox
    Friend WithEvents hrg_beli As TextBox
    Friend WithEvents stok_obat As TextBox
    Friend WithEvents kategori_obat As ComboBox
    Friend WithEvents nm_obat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents exit_btn As Button
    Friend WithEvents reset_btn As Button
    Friend WithEvents del_btn As Button
    Friend WithEvents edit_btn As Button
    Friend WithEvents save_btn As Button
    Friend WithEvents add_btn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cari_box As TextBox
    Friend WithEvents ProjectDataSetBindingSource As BindingSource
    Friend WithEvents ProjectDataSet As projectDataSet
    Friend WithEvents kode As Label
    Friend WithEvents dgv_obat As DataGridView
End Class
