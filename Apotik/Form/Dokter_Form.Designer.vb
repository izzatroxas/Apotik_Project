<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dokter_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dokter_Form))
        Me.save_btn = New System.Windows.Forms.Button()
        Me.kode = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cari_box = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProjectDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet = New Apotik.projectDataSet()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.dgv_dokter = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.reset_btn = New System.Windows.Forms.Button()
        Me.del_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.edit_btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.telepon_box = New System.Windows.Forms.TextBox()
        Me.alamat_box = New System.Windows.Forms.RichTextBox()
        Me.nm_dokter_box = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ProjectDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_dokter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'save_btn
        '
        Me.save_btn.BackgroundImage = CType(resources.GetObject("save_btn.BackgroundImage"), System.Drawing.Image)
        Me.save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.save_btn.Location = New System.Drawing.Point(85, 12)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(75, 23)
        Me.save_btn.TabIndex = 1
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'kode
        '
        Me.kode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.kode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.kode.Location = New System.Drawing.Point(94, 16)
        Me.kode.Name = "kode"
        Me.kode.Size = New System.Drawing.Size(136, 21)
        Me.kode.TabIndex = 61
        Me.kode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Chocolate
        Me.GroupBox3.Controls.Add(Me.cari_box)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(257, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(319, 40)
        Me.GroupBox3.TabIndex = 6
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label10.Location = New System.Drawing.Point(381, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 31)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Data Dokter"
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
        'add_btn
        '
        Me.add_btn.BackgroundImage = CType(resources.GetObject("add_btn.BackgroundImage"), System.Drawing.Image)
        Me.add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.add_btn.Location = New System.Drawing.Point(4, 12)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(75, 23)
        Me.add_btn.TabIndex = 0
        Me.add_btn.Text = "Add"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'dgv_dokter
        '
        Me.dgv_dokter.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.dgv_dokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dokter.Location = New System.Drawing.Point(257, 101)
        Me.dgv_dokter.Name = "dgv_dokter"
        Me.dgv_dokter.Size = New System.Drawing.Size(524, 316)
        Me.dgv_dokter.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(4, 78)
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
        Me.exit_btn.Location = New System.Drawing.Point(168, 41)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(75, 23)
        Me.exit_btn.TabIndex = 1
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'reset_btn
        '
        Me.reset_btn.BackgroundImage = CType(resources.GetObject("reset_btn.BackgroundImage"), System.Drawing.Image)
        Me.reset_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.reset_btn.Location = New System.Drawing.Point(85, 41)
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
        Me.del_btn.Location = New System.Drawing.Point(4, 41)
        Me.del_btn.Name = "del_btn"
        Me.del_btn.Size = New System.Drawing.Size(75, 23)
        Me.del_btn.TabIndex = 1
        Me.del_btn.Text = "Delete"
        Me.del_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
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
        Me.GroupBox2.Location = New System.Drawing.Point(1, 248)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 116)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'edit_btn
        '
        Me.edit_btn.BackgroundImage = CType(resources.GetObject("edit_btn.BackgroundImage"), System.Drawing.Image)
        Me.edit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.edit_btn.Location = New System.Drawing.Point(166, 12)
        Me.edit_btn.Name = "edit_btn"
        Me.edit_btn.Size = New System.Drawing.Size(75, 23)
        Me.edit_btn.TabIndex = 1
        Me.edit_btn.Text = "Edit"
        Me.edit_btn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Chocolate
        Me.GroupBox1.Controls.Add(Me.telepon_box)
        Me.GroupBox1.Controls.Add(Me.alamat_box)
        Me.GroupBox1.Controls.Add(Me.nm_dokter_box)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.kode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 365)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'telepon_box
        '
        Me.telepon_box.Location = New System.Drawing.Point(94, 200)
        Me.telepon_box.Name = "telepon_box"
        Me.telepon_box.Size = New System.Drawing.Size(136, 20)
        Me.telepon_box.TabIndex = 67
        '
        'alamat_box
        '
        Me.alamat_box.Location = New System.Drawing.Point(94, 73)
        Me.alamat_box.Name = "alamat_box"
        Me.alamat_box.Size = New System.Drawing.Size(136, 121)
        Me.alamat_box.TabIndex = 66
        Me.alamat_box.Text = ""
        '
        'nm_dokter_box
        '
        Me.nm_dokter_box.Location = New System.Drawing.Point(94, 47)
        Me.nm_dokter_box.Name = "nm_dokter_box"
        Me.nm_dokter_box.Size = New System.Drawing.Size(136, 20)
        Me.nm_dokter_box.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(8, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Nomor Telepon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(8, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(8, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Nama Dokter"
        '
        'Dokter_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(787, 431)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dgv_dokter)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dokter_Form"
        Me.Text = "Dokter_Form"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ProjectDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_dokter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents save_btn As Button
    Friend WithEvents kode As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cari_box As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ProjectDataSetBindingSource As BindingSource
    Friend WithEvents ProjectDataSet As projectDataSet
    Friend WithEvents add_btn As Button
    Friend WithEvents dgv_dokter As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents exit_btn As Button
    Friend WithEvents reset_btn As Button
    Friend WithEvents del_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents edit_btn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents telepon_box As TextBox
    Friend WithEvents alamat_box As RichTextBox
    Friend WithEvents nm_dokter_box As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
