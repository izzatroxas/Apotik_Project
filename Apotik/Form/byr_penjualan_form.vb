Public Class Transaksi_Penjualan_Form
    Private Sub Transaksi_Penjualan_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tot_txt.Text = Penjualan_Form.tot_bay_box.Text
        tot_txt.Enabled = False
    End Sub

    Private Sub Penjumlahan_Kembali(sender As Object, e As EventArgs) Handles tot_txt.TextChanged, byr_txt.TextChanged
        If String.IsNullOrEmpty(tot_txt.Text) OrElse String.IsNullOrEmpty(byr_txt.Text) Then
            Exit Sub
        End If
        If Not IsNumeric(tot_txt.Text) OrElse Not IsNumeric(byr_txt.Text) Then
            Exit Sub
        End If
        kmbl_txt.Text = CDbl(byr_txt.Text) - CDbl(tot_txt.Text)
        Penjualan_Form.tot_lbl.Text = kmbl_txt.Text
    End Sub

    Private Sub Save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Call Kon()
        sql = "SELECT * FROM tbl_penjualan WHERE NOTA ='" & Penjualan_Form.nota_lbl.Text & "'"
        cmd = New OleDb.OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        Try
            If Not dr.HasRows Then
                Call Kon()
                Dim add As String
                add = "INSERT INTO tbl_penjualan (nota, nm_dokter, nm_obat, qty, harga_jual, pot, total, sisa) VALUES(@n, @nmd, @nmo, @qty, @hrg, @p, @t, @s)"
                cmd = New OleDb.OleDbCommand(add, conn)
                cmd.Parameters.AddWithValue("n", Penjualan_Form.nota_lbl.Text)
                cmd.Parameters.AddWithValue("nmd", Penjualan_Form.nm_dokter_box.Text)
                cmd.Parameters.AddWithValue("nmo", Penjualan_Form.nm_obat_box.Text)
                cmd.Parameters.AddWithValue("qty", Penjualan_Form.jmlh_box.Text)
                cmd.Parameters.AddWithValue("hrg", Penjualan_Form.hrg_jual_box.Text)
                cmd.Parameters.AddWithValue("p", Penjualan_Form.potongan_box.Text)
                cmd.Parameters.AddWithValue("t", Penjualan_Form.tot_bay_box.Text)
                cmd.Parameters.AddWithValue("s", kmbl_txt.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Disimpan")
            Else
                MessageBox.Show("Nothing !")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call Penjualan_Form.Clean()
        Me.Close()
    End Sub
End Class