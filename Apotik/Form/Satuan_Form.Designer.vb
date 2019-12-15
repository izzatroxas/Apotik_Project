<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Satuan_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Satuan_Form))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nm_satuan_box = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.kode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_satuan = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.reset_btn = New System.Windows.Forms.Button()
        Me.edit_btn = New System.Windows.Forms.Button()
        Me.del_btn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cari_box = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_satuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.nm_satuan_box)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.kode)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 42)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'nm_satuan_box
        '
        Me.nm_satuan_box.Location = New System.Drawing.Point(146, 15)
        Me.nm_satuan_box.Name = "nm_satuan_box"
        Me.nm_satuan_box.Size = New System.Drawing.Size(139, 20)
        Me.nm_satuan_box.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(105, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Nama"
        '
        'kode
        '
        Me.kode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.kode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.kode.Location = New System.Drawing.Point(39, 15)
        Me.kode.Name = "kode"
        Me.kode.Size = New System.Drawing.Size(39, 20)
        Me.kode.TabIndex = 63
        Me.kode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Kode"
        '
        'dgv_satuan
        '
        Me.dgv_satuan.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.dgv_satuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_satuan.Location = New System.Drawing.Point(9, 57)
        Me.dgv_satuan.Name = "dgv_satuan"
        Me.dgv_satuan.Size = New System.Drawing.Size(215, 173)
        Me.dgv_satuan.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.add_btn)
        Me.GroupBox1.Controls.Add(Me.exit_btn)
        Me.GroupBox1.Controls.Add(Me.save_btn)
        Me.GroupBox1.Controls.Add(Me.reset_btn)
        Me.GroupBox1.Controls.Add(Me.edit_btn)
        Me.GroupBox1.Controls.Add(Me.del_btn)
        Me.GroupBox1.Location = New System.Drawing.Point(228, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(86, 183)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'add_btn
        '
        Me.add_btn.BackgroundImage = CType(resources.GetObject("add_btn.BackgroundImage"), System.Drawing.Image)
        Me.add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.add_btn.Location = New System.Drawing.Point(6, 10)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(75, 23)
        Me.add_btn.TabIndex = 4
        Me.add_btn.Text = "Add"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'exit_btn
        '
        Me.exit_btn.BackgroundImage = CType(resources.GetObject("exit_btn.BackgroundImage"), System.Drawing.Image)
        Me.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.exit_btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.exit_btn.Location = New System.Drawing.Point(6, 154)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(75, 23)
        Me.exit_btn.TabIndex = 5
        Me.exit_btn.Text = "Clean"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.BackgroundImage = CType(resources.GetObject("save_btn.BackgroundImage"), System.Drawing.Image)
        Me.save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.save_btn.Location = New System.Drawing.Point(6, 39)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(75, 23)
        Me.save_btn.TabIndex = 9
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'reset_btn
        '
        Me.reset_btn.BackgroundImage = CType(resources.GetObject("reset_btn.BackgroundImage"), System.Drawing.Image)
        Me.reset_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.reset_btn.Location = New System.Drawing.Point(5, 126)
        Me.reset_btn.Name = "reset_btn"
        Me.reset_btn.Size = New System.Drawing.Size(75, 23)
        Me.reset_btn.TabIndex = 6
        Me.reset_btn.Text = "Reset"
        Me.reset_btn.UseVisualStyleBackColor = True
        '
        'edit_btn
        '
        Me.edit_btn.BackgroundImage = CType(resources.GetObject("edit_btn.BackgroundImage"), System.Drawing.Image)
        Me.edit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.edit_btn.Location = New System.Drawing.Point(6, 68)
        Me.edit_btn.Name = "edit_btn"
        Me.edit_btn.Size = New System.Drawing.Size(75, 23)
        Me.edit_btn.TabIndex = 8
        Me.edit_btn.Text = "Edit"
        Me.edit_btn.UseVisualStyleBackColor = True
        '
        'del_btn
        '
        Me.del_btn.BackgroundImage = CType(resources.GetObject("del_btn.BackgroundImage"), System.Drawing.Image)
        Me.del_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.del_btn.Location = New System.Drawing.Point(5, 97)
        Me.del_btn.Name = "del_btn"
        Me.del_btn.Size = New System.Drawing.Size(75, 23)
        Me.del_btn.TabIndex = 7
        Me.del_btn.Text = "Delete"
        Me.del_btn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Chocolate
        Me.GroupBox3.Controls.Add(Me.cari_box)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(215, 40)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'cari_box
        '
        Me.cari_box.Location = New System.Drawing.Point(64, 13)
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
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Cari Data"
        '
        'Satuan_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(323, 286)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgv_satuan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Satuan_Form"
        Me.Text = "Satuan_Form"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_satuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents nm_satuan_box As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents kode As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_satuan As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents add_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents save_btn As Button
    Friend WithEvents reset_btn As Button
    Friend WithEvents edit_btn As Button
    Friend WithEvents del_btn As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cari_box As TextBox
    Friend WithEvents Label11 As Label
End Class
