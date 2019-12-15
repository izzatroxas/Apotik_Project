<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu_Form))
        Me.a = New System.Windows.Forms.Label()
        Me.idm = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nmm = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.B_Obat = New System.Windows.Forms.ToolStripButton()
        Me.B_Dokter = New System.Windows.Forms.ToolStripLabel()
        Me.B_Pemasok = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.B_Penjualan = New System.Windows.Forms.ToolStripButton()
        Me.B_Nota = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Menu_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Obat = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Dokter = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Pemasok = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Menu_KObat = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_SObat = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Penjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Nota = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.clock = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.Location = New System.Drawing.Point(12, 428)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(27, 13)
        Me.a.TabIndex = 0
        Me.a.Text = "ID : "
        '
        'idm
        '
        Me.idm.AutoSize = True
        Me.idm.Location = New System.Drawing.Point(49, 428)
        Me.idm.Name = "idm"
        Me.idm.Size = New System.Drawing.Size(23, 13)
        Me.idm.TabIndex = 1
        Me.idm.Text = "****"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 428)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nama :"
        '
        'nmm
        '
        Me.nmm.AutoSize = True
        Me.nmm.Location = New System.Drawing.Point(208, 428)
        Me.nmm.Name = "nmm"
        Me.nmm.Size = New System.Drawing.Size(0, 13)
        Me.nmm.TabIndex = 3
        '
        'time
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.B_Obat, Me.B_Dokter, Me.B_Pemasok, Me.ToolStripSeparator3, Me.B_Penjualan, Me.B_Nota})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(803, 40)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'B_Obat
        '
        Me.B_Obat.Image = CType(resources.GetObject("B_Obat.Image"), System.Drawing.Image)
        Me.B_Obat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.B_Obat.Name = "B_Obat"
        Me.B_Obat.Size = New System.Drawing.Size(72, 37)
        Me.B_Obat.Text = "Data Obat"
        Me.B_Obat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'B_Dokter
        '
        Me.B_Dokter.Image = CType(resources.GetObject("B_Dokter.Image"), System.Drawing.Image)
        Me.B_Dokter.Name = "B_Dokter"
        Me.B_Dokter.Size = New System.Drawing.Size(79, 37)
        Me.B_Dokter.Text = "Data Dokter"
        Me.B_Dokter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'B_Pemasok
        '
        Me.B_Pemasok.Image = CType(resources.GetObject("B_Pemasok.Image"), System.Drawing.Image)
        Me.B_Pemasok.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.B_Pemasok.Name = "B_Pemasok"
        Me.B_Pemasok.Size = New System.Drawing.Size(96, 37)
        Me.B_Pemasok.Text = "Data Pemasok"
        Me.B_Pemasok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 40)
        '
        'B_Penjualan
        '
        Me.B_Penjualan.Image = CType(resources.GetObject("B_Penjualan.Image"), System.Drawing.Image)
        Me.B_Penjualan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.B_Penjualan.Name = "B_Penjualan"
        Me.B_Penjualan.Size = New System.Drawing.Size(67, 37)
        Me.B_Penjualan.Text = "Penjualan"
        Me.B_Penjualan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'B_Nota
        '
        Me.B_Nota.Image = CType(resources.GetObject("B_Nota.Image"), System.Drawing.Image)
        Me.B_Nota.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.B_Nota.Name = "B_Nota"
        Me.B_Nota.Size = New System.Drawing.Size(80, 37)
        Me.B_Nota.Text = "Check Nota"
        Me.B_Nota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(803, 25)
        Me.MenuStrip2.TabIndex = 4
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Logout, Me.ToolStripSeparator2, Me.Menu_Exit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'Menu_Logout
        '
        Me.Menu_Logout.Image = CType(resources.GetObject("Menu_Logout.Image"), System.Drawing.Image)
        Me.Menu_Logout.Name = "Menu_Logout"
        Me.Menu_Logout.Size = New System.Drawing.Size(123, 22)
        Me.Menu_Logout.Text = "Log Out"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(120, 6)
        '
        'Menu_Exit
        '
        Me.Menu_Exit.Image = CType(resources.GetObject("Menu_Exit.Image"), System.Drawing.Image)
        Me.Menu_Exit.Name = "Menu_Exit"
        Me.Menu_Exit.Size = New System.Drawing.Size(123, 22)
        Me.Menu_Exit.Text = "Exit"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Obat, Me.Menu_Dokter, Me.Menu_Pemasok, Me.ToolStripSeparator1, Me.Menu_KObat, Me.Menu_SObat})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(92, 21)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'Menu_Obat
        '
        Me.Menu_Obat.Image = CType(resources.GetObject("Menu_Obat.Image"), System.Drawing.Image)
        Me.Menu_Obat.Name = "Menu_Obat"
        Me.Menu_Obat.Size = New System.Drawing.Size(180, 22)
        Me.Menu_Obat.Text = "Data Obat"
        '
        'Menu_Dokter
        '
        Me.Menu_Dokter.Image = CType(resources.GetObject("Menu_Dokter.Image"), System.Drawing.Image)
        Me.Menu_Dokter.Name = "Menu_Dokter"
        Me.Menu_Dokter.Size = New System.Drawing.Size(180, 22)
        Me.Menu_Dokter.Text = "Data Dokter"
        '
        'Menu_Pemasok
        '
        Me.Menu_Pemasok.Image = CType(resources.GetObject("Menu_Pemasok.Image"), System.Drawing.Image)
        Me.Menu_Pemasok.Name = "Menu_Pemasok"
        Me.Menu_Pemasok.Size = New System.Drawing.Size(180, 22)
        Me.Menu_Pemasok.Text = "Data Pemasok"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'Menu_KObat
        '
        Me.Menu_KObat.Image = CType(resources.GetObject("Menu_KObat.Image"), System.Drawing.Image)
        Me.Menu_KObat.Name = "Menu_KObat"
        Me.Menu_KObat.Size = New System.Drawing.Size(180, 22)
        Me.Menu_KObat.Text = "Kategori Obat"
        '
        'Menu_SObat
        '
        Me.Menu_SObat.Image = CType(resources.GetObject("Menu_SObat.Image"), System.Drawing.Image)
        Me.Menu_SObat.Name = "Menu_SObat"
        Me.Menu_SObat.Size = New System.Drawing.Size(180, 22)
        Me.Menu_SObat.Text = "Satuan Obat"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Penjualan, Me.Menu_Nota})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(75, 21)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'Menu_Penjualan
        '
        Me.Menu_Penjualan.Image = CType(resources.GetObject("Menu_Penjualan.Image"), System.Drawing.Image)
        Me.Menu_Penjualan.Name = "Menu_Penjualan"
        Me.Menu_Penjualan.Size = New System.Drawing.Size(144, 22)
        Me.Menu_Penjualan.Text = "Penjualan"
        '
        'Menu_Nota
        '
        Me.Menu_Nota.Image = CType(resources.GetObject("Menu_Nota.Image"), System.Drawing.Image)
        Me.Menu_Nota.Name = "Menu_Nota"
        Me.Menu_Nota.Size = New System.Drawing.Size(144, 22)
        Me.Menu_Nota.Text = "Check Nota"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(5, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(795, 357)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'clock
        '
        Me.clock.AutoSize = True
        Me.clock.Location = New System.Drawing.Point(690, 428)
        Me.clock.Name = "clock"
        Me.clock.Size = New System.Drawing.Size(110, 13)
        Me.clock.TabIndex = 7
        Me.clock.Text = "00/00/0000 00:00:00"
        '
        'Main_Menu_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 449)
        Me.Controls.Add(Me.clock)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.nmm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.idm)
        Me.Controls.Add(Me.a)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main_Menu_Form"
        Me.Text = "Main Menu"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents a As Label
    Friend WithEvents idm As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nmm As Label
    Friend WithEvents time As Timer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents B_Obat As ToolStripButton
    Friend WithEvents B_Dokter As ToolStripLabel
    Friend WithEvents B_Pemasok As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents B_Penjualan As ToolStripButton
    Friend WithEvents B_Nota As ToolStripButton
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_Logout As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Menu_Exit As ToolStripMenuItem
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_Obat As ToolStripMenuItem
    Friend WithEvents Menu_Dokter As ToolStripMenuItem
    Friend WithEvents Menu_Pemasok As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Menu_KObat As ToolStripMenuItem
    Friend WithEvents Menu_SObat As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_Penjualan As ToolStripMenuItem
    Friend WithEvents Menu_Nota As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents clock As Label
End Class
