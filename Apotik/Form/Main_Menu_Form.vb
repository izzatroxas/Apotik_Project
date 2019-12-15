Public Class Main_Menu_Form

    Private Sub Time_tick_Tick(sender As Object, e As EventArgs) Handles time.Tick
        clock.Text = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub B_Obat_Click(sender As Object, e As EventArgs) Handles B_Obat.Click
        Obat_Form.Show()
    End Sub

    Private Sub Menu_Obat_Click(sender As Object, e As EventArgs) Handles Menu_Obat.Click
        Obat_Form.Show()
    End Sub

    Private Sub Menu_Logout_Click_1(sender As Object, e As EventArgs) Handles Menu_Logout.Click
        If MsgBox("Yakin ingin logout?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Login.Tnama.Clear()
            Login.Tpassword.Clear()
            Login.Visible = True
            Me.Close()
        End If
    End Sub

    Private Sub Menu_Exit_Click_1(sender As Object, e As EventArgs) Handles Menu_Exit.Click
        Application.Exit()
    End Sub

    Private Sub Main_Menu_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        time.Enabled = True
    End Sub

    Private Sub B_Dokter_Click(sender As Object, e As EventArgs) Handles B_Dokter.Click
        Dokter_Form.Show()
    End Sub

    Private Sub Menu_Dokter_Click(sender As Object, e As EventArgs) Handles Menu_Dokter.Click
        Dokter_Form.Show()
    End Sub

    Private Sub Menu_KObat_Click(sender As Object, e As EventArgs) Handles Menu_KObat.Click
        Kategori_Form.Show()
    End Sub

    Private Sub Menu_SObat_Click(sender As Object, e As EventArgs) Handles Menu_SObat.Click
        Satuan_Form.Show()
    End Sub
End Class