Imports System.Data.OleDb

Public Class Login
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Call Masuk()
    End Sub
    Sub Masuk()
        Call Kon()
        If Tnama.Text = "" Or Tpassword.Text = "" Then
            MsgBox("Masukkan username/password terlebih dahulu", MsgBoxStyle.Information, "Warning")
            Exit Sub
        End If
        Call Kon()
        cmd = New OleDbCommand("select * from tbl_user where user_name ='" & Tnama.Text & "' and password ='" & Tpassword.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Me.Visible = False
            Main_Menu_Form.Show()
            Main_Menu_Form.idm.Text = dr.Item(0)
            Main_Menu_Form.nmm.Text = UCase(dr.Item(1))
            ''Main_Menu.Status_Type.Text = UCase(dr.Item(3))
        Else
            MsgBox("Login gagal")
        End If
    End Sub


    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub Tnama_KeyDown(sender As Object, e As KeyEventArgs) Handles Tnama.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tpassword.Select()
        End If
    End Sub

    Private Sub Tpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles Tpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK.Select()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Tnama.Clear()
        Tpassword.Clear()
        Tnama.Select()
        If Check() = True Then
            Label1.Text = String.Format("Beta {0} Version", My.Application.Info.Version.ToString)
            MessageBox.Show("Terkoneksi ke Server")
        Else
            Application.Exit()
        End If
    End Sub

End Class
