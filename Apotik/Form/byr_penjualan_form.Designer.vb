<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi_Penjualan_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi_Penjualan_Form))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.byr_txt = New System.Windows.Forms.TextBox()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.kmbl_txt = New System.Windows.Forms.Label()
        Me.tot_txt = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.byr_txt)
        Me.GroupBox1.Controls.Add(Me.save_btn)
        Me.GroupBox1.Controls.Add(Me.kmbl_txt)
        Me.GroupBox1.Controls.Add(Me.tot_txt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkOrange
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaksi Penjualan"
        '
        'byr_txt
        '
        Me.byr_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.byr_txt.ForeColor = System.Drawing.Color.Green
        Me.byr_txt.Location = New System.Drawing.Point(95, 48)
        Me.byr_txt.Name = "byr_txt"
        Me.byr_txt.Size = New System.Drawing.Size(216, 35)
        Me.byr_txt.TabIndex = 67
        Me.byr_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'save_btn
        '
        Me.save_btn.BackgroundImage = Global.Apotik.My.Resources.Resources.cash_in_hand_32px
        Me.save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.save_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.save_btn.Location = New System.Drawing.Point(239, 87)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(72, 35)
        Me.save_btn.TabIndex = 66
        Me.save_btn.Text = "Bayar"
        Me.save_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'kmbl_txt
        '
        Me.kmbl_txt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.kmbl_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kmbl_txt.ForeColor = System.Drawing.Color.Green
        Me.kmbl_txt.Location = New System.Drawing.Point(11, 125)
        Me.kmbl_txt.Name = "kmbl_txt"
        Me.kmbl_txt.Size = New System.Drawing.Size(300, 29)
        Me.kmbl_txt.TabIndex = 65
        Me.kmbl_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tot_txt
        '
        Me.tot_txt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tot_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tot_txt.ForeColor = System.Drawing.Color.Green
        Me.tot_txt.Location = New System.Drawing.Point(95, 16)
        Me.tot_txt.Name = "tot_txt"
        Me.tot_txt.Size = New System.Drawing.Size(216, 29)
        Me.tot_txt.TabIndex = 63
        Me.tot_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(7, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kembali"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bayar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total"
        '
        'Transaksi_Penjualan_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(344, 198)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Transaksi_Penjualan_Form"
        Me.Text = "Transaksi Penjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents kmbl_txt As Label
    Friend WithEvents tot_txt As Label
    Friend WithEvents save_btn As Button
    Friend WithEvents byr_txt As TextBox
End Class
