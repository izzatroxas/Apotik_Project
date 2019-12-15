Imports System.Data.OleDb
Imports Apotik.Sql_func
Public Class Obat_Form
    Sub Otomatis()
        Call Kon()
        cmd = New OleDbCommand("SELECT * FROM tbl_obat ORDER BY kode_obat desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            kode.Text = "A-01"
        Else
            kode.Text = "A-" + Format(Microsoft.VisualBasic.Right(dr.Item("kode_obat"), 2) + 1, "00")
        End If
    End Sub
    Sub Bersih()
        nm_obat.Clear()
        stok_obat.Clear()
        satu_an.ResetText()
        kategori_obat.ResetText()
        hrg_beli.Clear()
        hrg_jual.Clear()
        laba_box.Clear()
        nm_obat.Select()
        Call Dgv()
        Call Otomatis()
        Call Kategori_com()
        Call Satuan_com()
        add_btn.Enabled = True
        kode.Enabled = False
        nm_obat.Enabled = False
        kategori_obat.Enabled = False
        satu_an.Enabled = False
        stok_obat.Enabled = False
        hrg_beli.Enabled = False
        hrg_jual.Enabled = False
        laba_box.Enabled = False
        save_btn.Enabled = False
        edit_btn.Enabled = False
        del_btn.Enabled = False
        reset_btn.Enabled = False
        exit_btn.Enabled = False
    End Sub
    Sub Baru()
        kode.ResetText()
        nm_obat.Clear()
        stok_obat.Clear()
        satu_an.ResetText()
        kategori_obat.ResetText()
        hrg_beli.Clear()
        hrg_jual.Clear()
        laba_box.Clear()
        nm_obat.Select()
    End Sub
    Sub Found()
        Call Kon()
        nm_obat.Text = dr.Item("nama_obat")
        kategori_obat.Text = dr.Item("kategori")
        satu_an.Text = dr.Item("satu_an")
        stok_obat.Text = dr.Item("stok_obat")
        hrg_beli.Text = dr.Item("harga_beli")
        hrg_jual.Text = dr.Item("harga_jual")
        laba_box.Text = dr.Item("laba")
        nm_obat.Select()
    End Sub
    Sub Dgv()
        Call Kon()
        sql = "SELECT * FROM tbl_obat"
        ds = Sql_dataset(sql)
        dgv_obat.DataSource = ds.Tables(0)
        dgv_obat.ReadOnly = True
    End Sub
    Sub Kategori_com()
        Call Kon()
        sql = "SELECT * FROM tbl_kategori"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                kategori_obat.Items.Add(dr("kategori"))
            Loop
        End If
    End Sub
    Sub Satuan_com()
        Call Kon()
        sql = "SELECT * FROM tbl_satuan"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                satu_an.Items.Add(dr("satuan"))
            Loop
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Call Baru()
    End Sub
    Private Sub Obat_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call Bersih()
    End Sub
    Private Sub Dgv_obat_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_obat.CellMouseClick
        On Error Resume Next
        kode.Text = dgv_obat.Rows(e.RowIndex).Cells(0).Value
        nm_obat.Text = dgv_obat.Rows(e.RowIndex).Cells(1).Value
        kategori_obat.Text = dgv_obat.Rows(e.RowIndex).Cells(2).Value
        satu_an.Text = dgv_obat.Rows(e.RowIndex).Cells(3).Value
        stok_obat.Text = dgv_obat.Rows(e.RowIndex).Cells(4).Value
        hrg_beli.Text = dgv_obat.Rows(e.RowIndex).Cells(5).Value
        hrg_jual.Text = dgv_obat.Rows(e.RowIndex).Cells(6).Value
        laba_box.Text = dgv_obat.Rows(e.RowIndex).Cells(7).Value
        edit_btn.Enabled = True
        del_btn.Enabled = True
        exit_btn.Enabled = True
        add_btn.Enabled = False
        reset_btn.Enabled = True
    End Sub

    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        add_btn.Enabled = False
        kode.Enabled = True
        nm_obat.Enabled = True
        kategori_obat.Enabled = True
        satu_an.Enabled = True
        stok_obat.Enabled = True
        hrg_beli.Enabled = True
        hrg_jual.Enabled = True
        laba_box.Enabled = True
        save_btn.Enabled = True
        reset_btn.Enabled = True
        exit_btn.Enabled = True
    End Sub

    Private Sub Cari_box_TextChanged(sender As Object, e As EventArgs) Handles cari_box.TextChanged
        Call Kon()
        sql = "SELECT * FROM tbl_obat WHERE kode_obat like '%" & cari_box.Text & "%' or nama_obat like '%" & cari_box.Text & "%'"
                da = New OleDbDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds)
        dgv_obat.DataSource = ds.Tables(0)
        dgv_obat.ReadOnly = True
    End Sub

    Private Sub Reset_btn_Click(sender As Object, e As EventArgs) Handles reset_btn.Click
        Call Bersih()
    End Sub

    Private Sub Del_btn_Click(sender As Object, e As EventArgs) Handles del_btn.Click
        Call Kon()
        cmd = New OleDbCommand("SELECT * FROM tbl_obat WHERE kode_obat = '" & kode.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            MsgBox("Data Obat Tidak Ada")
            Exit Sub
        End If
        If MessageBox.Show("Yakin mau dihapus ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call Kon()
            Dim del As String
            del = "DELETE FROM tbl_obat WHERE kode_obat = '" & kode.Text & "'"
            cmd = New OleDbCommand(del, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus")
            Call Bersih()
        Else
            Call Bersih()
        End If
    End Sub

    Private Sub Kode_LostFocus(sender As Object, e As EventArgs) Handles kode.LostFocus
        Call Kon()
        sql = "SELECT * FROM tbl_obat WHERE kode_obat ='" & kode.Text & "'"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            Call Baru()
        Else
            Call Found()
        End If
    End Sub

    Private Sub Save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Call Kon()
        sql = "SELECT * FROM tbl_obat WHERE kode_obat='" & kode.Text & "'"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        Try
            If Not dr.HasRows Then
                Call Kon()
                Dim add As String
                add = "INSERT INTO tbl_obat (kode_obat, nama_obat, kategori, satuan, stok, harga_beli, harga_jual, laba) VALUES (@kd, @nm, @ktg, @stn, @stk, @hrgb, @hrgj, @l)"
                cmd = New OleDbCommand(add, conn)
                cmd.Parameters.AddWithValue("@kd", kode.Text)
                cmd.Parameters.AddWithValue("@nm", nm_obat.Text)
                cmd.Parameters.AddWithValue("@ktg", kategori_obat.Text)
                cmd.Parameters.AddWithValue("@stn", satu_an.Text)
                cmd.Parameters.AddWithValue("@stk", stok_obat.Text)
                cmd.Parameters.AddWithValue("@hrgb", hrg_beli.Text)
                cmd.Parameters.AddWithValue("@hrgj", hrg_jual.Text)
                cmd.Parameters.AddWithValue("@l", laba_box.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Disimpan")
            Else
                Call Kon()
                Dim edit As String
                edit = "UPDATE tbl_obat SET nama_obat = @nm, kategori = @ktg, satuan = @stn, stok = @stk, harga_beli = @hrgb, harga_jual = @hrgj, laba = @l WHERE kode_obat = @kd"
                cmd = New OleDbCommand(edit, conn)
                cmd.Parameters.AddWithValue("@kd", kode.Text)
                cmd.Parameters.AddWithValue("@nm", nm_obat.Text)
                cmd.Parameters.AddWithValue("@ktg", kategori_obat.Text)
                cmd.Parameters.AddWithValue("@stn", satu_an.Text)
                cmd.Parameters.AddWithValue("@stk", stok_obat.Text)
                cmd.Parameters.AddWithValue("@hrgb", hrg_beli.Text)
                cmd.Parameters.AddWithValue("@hrgj", hrg_jual.Text)
                cmd.Parameters.AddWithValue("@l", laba_box.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Diupdate")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call Bersih()
    End Sub

    Private Sub Edit_btn_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        add_btn.Enabled = False
        kode.Enabled = True
        nm_obat.Enabled = True
        kategori_obat.Enabled = True
        satu_an.Enabled = True
        stok_obat.Enabled = True
        hrg_beli.Enabled = True
        hrg_jual.Enabled = True
        laba_box.Enabled = True
        save_btn.Enabled = True
        edit_btn.Enabled = False
        del_btn.Enabled = False
        reset_btn.Enabled = True
        exit_btn.Enabled = True
    End Sub

    Private Sub Hrg_beli_TextChanged(sender As Object, e As EventArgs) Handles hrg_beli.TextChanged, hrg_jual.TextChanged
        If String.IsNullOrEmpty(hrg_beli.Text) OrElse String.IsNullOrEmpty(hrg_jual.Text) Then
            Exit Sub
        End If
        If Not IsNumeric(hrg_beli.Text) OrElse Not IsNumeric(hrg_jual.Text) Then
            Exit Sub
        End If
        laba_box.Text = CDbl(hrg_jual.Text) - CDbl(hrg_beli.Text)
    End Sub
End Class