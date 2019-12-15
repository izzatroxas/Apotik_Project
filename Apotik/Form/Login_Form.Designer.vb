<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.Tpassword = New System.Windows.Forms.TextBox()
        Me.Tnama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(165, 130)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(49, 23)
        Me.Cancel.TabIndex = 16
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(114, 130)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(49, 23)
        Me.OK.TabIndex = 15
        Me.OK.Text = "Login"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Tpassword
        '
        Me.Tpassword.AllowDrop = True
        Me.Tpassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Tpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tpassword.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Tpassword.Location = New System.Drawing.Point(45, 58)
        Me.Tpassword.Multiline = True
        Me.Tpassword.Name = "Tpassword"
        Me.Tpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tpassword.Size = New System.Drawing.Size(139, 26)
        Me.Tpassword.TabIndex = 14
        Me.Tpassword.Text = "aaaaa"
        '
        'Tnama
        '
        Me.Tnama.AllowDrop = True
        Me.Tnama.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Tnama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tnama.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Tnama.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Tnama.Location = New System.Drawing.Point(45, 27)
        Me.Tnama.Multiline = True
        Me.Tnama.Name = "Tnama"
        Me.Tnama.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Tnama.Size = New System.Drawing.Size(138, 26)
        Me.Tnama.TabIndex = 12
        Me.Tnama.Text = "username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Beta"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(10, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arabic Typesetting", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(55, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 37)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "SIGN IN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tpassword)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Tnama)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 98)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(224, 159)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents Tpassword As TextBox
    Friend WithEvents Tnama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
