Imports System.Data.OleDb
Imports Apotik.Sql_func
Public Class Dokter_Form
    Private Sub Dokter_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call Clean()
    End Sub

    Sub Otomatis()
        Call Kon()
        cmd = New OleDbCommand("SELECT * FROM tbl_dokter ORDER BY kode_dokter desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            kode.Text = "D-01"
        Else
            kode.Text = "D-" + Format(Microsoft.VisualBasic.Right(dr.Item("kode_dokter"), 2) + 1, "00")
        End If
    End Sub

    Sub Clean()
        nm_dokter_box.Clear()
        alamat_box.Clear()
        telepon_box.Clear()
        nm_dokter_box.Select()
        kode.Enabled = False
        nm_dokter_box.Enabled = False
        alamat_box.Enabled = False
        telepon_box.Enabled = False
        add_btn.Enabled = True
        save_btn.Enabled = False
        edit_btn.Enabled = False
        del_btn.Enabled = False
        reset_btn.Enabled = False
        exit_btn.Enabled = False
        Call DGV()
        Call Otomatis()

    End Sub
    Sub Baru()
        nm_dokter_box.Clear()
        alamat_box.Clear()
        telepon_box.Clear()
        nm_dokter_box.Select()
    End Sub
    Sub Found()
        Call Kon()
        nm_dokter_box.Text = dr.Item("nama_dokter")
        alamat_box.Text = dr.Item("alamat")
        telepon_box.Text = dr.Item("nomor_telepon")
        nm_dokter_box.Select()
    End Sub
    Sub DGV()
        Call Kon()
        sql = "SELECT * FROM tbl_dokter"
        ds = Sql_dataset(sql)
        dgv_dokter.DataSource = ds.Tables(0)
        dgv_dokter.ReadOnly = True
    End Sub

    Private Sub Dgv_dokter_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_dokter.CellMouseClick
        kode.Text = dgv_dokter.Rows(e.RowIndex).Cells(0).Value
        nm_dokter_box.Text = dgv_dokter.Rows(e.RowIndex).Cells(1).Value
        alamat_box.Text = dgv_dokter.Rows(e.RowIndex).Cells(2).Value
        telepon_box.Text = dgv_dokter.Rows(e.RowIndex).Cells(3).Value
        edit_btn.Enabled = True
        del_btn.Enabled = True
        exit_btn.Enabled = True
    End Sub

    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        kode.Enabled = True
        nm_dokter_box.Enabled = True
        alamat_box.Enabled = True
        telepon_box.Enabled = True
        add_btn.Enabled = False
        save_btn.Enabled = True
        reset_btn.Enabled = True
        exit_btn.Enabled = True
        add_btn.Enabled = False
        reset_btn.Enabled = True
    End Sub

    Private Sub Cari_box_TextChanged(sender As Object, e As EventArgs) Handles cari_box.TextChanged
        Call Kon()
        sql = "SELECT * FROM tbl_dokter WHERE kode_dokter like '%" & cari_box.Text & "%' or nama_dokter like '%" & cari_box.Text & "%'"
        da = New OleDbDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds)
        dgv_dokter.DataSource = ds.Tables(0)
        dgv_dokter.ReadOnly = True
    End Sub

    Private Sub Reset_btn_Click(sender As Object, e As EventArgs) Handles reset_btn.Click
        Call Clean()
    End Sub

    Private Sub Del_btn_Click(sender As Object, e As EventArgs) Handles del_btn.Click
        Call Kon()
        cmd = New OleDbCommand("SELECT * FROM tbl_dokter WHERE kode_obat = '" & kode.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            MsgBox("Data Dokter Tidak Ada")
            Exit Sub
        End If
        If MessageBox.Show("Yakin mau dihapus ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call Kon()
            Dim del As String
            del = "DELETE FROM tbl_dokter WHERE kode_dokter = '" & kode.Text & "'"
            cmd = New OleDbCommand(del, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus")
            Call Clean()
        Else
            Call Clean()
        End If
    End Sub

    Private Sub Kode_LostFocus(sender As Object, e As EventArgs) Handles kode.LostFocus
        Call Kon()
        sql = "SELECT * FROM tbl_dokter WHERE kode_obat ='" & kode.Text & "'"
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
        sql = "SELECT * FROM tbl_dokter WHERE kode_dokter='" & kode.Text & "'"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        Try
            If Not dr.HasRows Then
                Call Kon()
                Dim add As String
                add = "INSERT INTO tbl_dokter (kode_dokter, nama_dokter, alamat, nomor_telepon) VALUES (@kd, @nm, @almt, @telf)"
                cmd = New OleDbCommand(add, conn)
                cmd.Parameters.AddWithValue("@kd", kode.Text)
                cmd.Parameters.AddWithValue("@nm", nm_dokter_box.Text)
                cmd.Parameters.AddWithValue("@almt", alamat_box.Text)
                cmd.Parameters.AddWithValue("@telf", telepon_box.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Disimpan")
            Else
                Call Kon()
                Dim edit As String
                edit = "UPDATE tbl_dokter SET nama_dokter = @nm, alamat = @almt, nomor_telepon = @telf WHERE kode_dokter = @kd"
                cmd = New OleDbCommand(edit, conn)
                cmd.Parameters.AddWithValue("@kd", kode.Text)
                cmd.Parameters.AddWithValue("@nm", nm_dokter_box.Text)
                cmd.Parameters.AddWithValue("@almt", alamat_box.Text)
                cmd.Parameters.AddWithValue("@telf", telepon_box.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Diupdate")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call Clean()
    End Sub

    Private Sub Edit_btn_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        kode.Enabled = True
        nm_dokter_box.Enabled = True
        alamat_box.Enabled = True
        telepon_box.Enabled = True
        add_btn.Enabled = False
        save_btn.Enabled = True
        edit_btn.Enabled = False
        del_btn.Enabled = False
        reset_btn.Enabled = True
        exit_btn.Enabled = True
    End Sub
End Class