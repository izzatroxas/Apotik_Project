Imports System.Data.OleDb
Imports Apotik.Sql_func
Public Class Satuan_Form
    Private Sub Satuan_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call Clean()
    End Sub
    Sub Otomatis()
        Call Kon()
        cmd = New OleDbCommand("SELECT * FROM tbl_satuan ORDER BY kode_satuan desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            kode.Text = "S-01"
        Else
            kode.Text = "S-" + Format(Microsoft.VisualBasic.Right(dr.Item("kode_satuan"), 2) + 1, "00")
        End If
    End Sub
    Sub Clean()
        nm_satuan_box.Clear()
        nm_satuan_box.Select()
        nm_satuan_box.Enabled = False
        kode.Enabled = False
        add_btn.Enabled = True
        save_btn.Enabled = False
        edit_btn.Enabled = False
        del_btn.Enabled = False
        reset_btn.Enabled = False
        exit_btn.Enabled = False
        Call Dgv()
        Call Otomatis()
    End Sub
    Sub Baru()
        nm_satuan_box.Clear()
        nm_satuan_box.Select()
    End Sub
    Sub Found()
        Call Kon()
        nm_satuan_box.Text = dr.Item("satuan")
        nm_satuan_box.Select()
    End Sub
    Sub Dgv()
        Call Kon()
        sql = "SELECT * FROM tbl_satuan"
        ds = Sql_dataset(sql)
        dgv_satuan.DataSource = ds.Tables(0)
        dgv_satuan.ReadOnly = True
    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Call Baru()
    End Sub

    Private Sub Reset_btn_Click(sender As Object, e As EventArgs) Handles reset_btn.Click
        Call Clean()
    End Sub

    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        kode.Enabled = True
        nm_satuan_box.Enabled = True
        add_btn.Enabled = False
        save_btn.Enabled = True
        reset_btn.Enabled = True
        exit_btn.Enabled = True
    End Sub

    Private Sub Cari_box_TextChanged(sender As Object, e As EventArgs) Handles cari_box.TextChanged
        Call Kon()
        sql = "SELECT * FROM tbl_satuan WHERE kode_satuan like '%" & cari_box.Text & "%' or satuan like '%" & cari_box.Text & "%'"
        da = New OleDbDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds)
        dgv_satuan.DataSource = ds.Tables(0)
        dgv_satuan.ReadOnly = True
    End Sub

    Private Sub Del_btn_Click(sender As Object, e As EventArgs) Handles del_btn.Click
        Call Kon()
        cmd = New OleDbCommand("SELECT * FROM tbl_satuan WHERE kode_satuan = '" & kode.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            MsgBox("Data Satuan Tidak Ada")
            Exit Sub
        End If
        If MessageBox.Show("Yakin mau dihapus ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call Kon()
            Dim del As String
            del = "DELETE FROM tbl_satuan WHERE kode_satuan = '" & kode.Text & "'"
            cmd = New OleDbCommand(del, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil dihapus")
            Call Clean()
        Else
            Call Clean()
        End If
    End Sub
    Private Sub Save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Call Kon()
        sql = "SELECT * FROM tbl_kategori WHERE kode_kategori ='" & kode.Text & "'"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        Try
            If Not dr.HasRows Then
                Call Kon()
                Dim add As String
                add = "INSERT INTO tbl_satuan (kode_satuan, satuan) VALUES (@kd, @stn)"
                cmd = New OleDbCommand(add, conn)
                cmd.Parameters.AddWithValue("@kd", kode.Text)
                cmd.Parameters.AddWithValue("@stn", nm_satuan_box.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Disimpan")
            Else
                Call Kon()
                Dim edit As String
                edit = "UPDATE tbl_satuan SET satuan = @stn WHERE kode_satuan = @kd"
                cmd = New OleDbCommand(edit, conn)
                cmd.Parameters.AddWithValue("@kd", kode.Text)
                cmd.Parameters.AddWithValue("@stn", nm_satuan_box.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Diupdate")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call Clean()
    End Sub
    Private Sub Kode_LostFocus(sender As Object, e As EventArgs) Handles kode.LostFocus
        Call Kon()
        sql = "SELECT * FROM tbl_satuan WHERE kode_satuan ='" & kode.Text & "'"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            Call Baru()
        Else
            Call Found()
        End If
    End Sub

    Private Sub Edit_btn_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        kode.Enabled = True
        nm_satuan_box.Enabled = True
        add_btn.Enabled = False
        save_btn.Enabled = True
        edit_btn.Enabled = False
        del_btn.Enabled = False
        reset_btn.Enabled = True
        exit_btn.Enabled = True
    End Sub
    Private Sub Dgv_kategori_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_satuan.CellMouseClick
        On Error Resume Next
        kode.Text = dgv_satuan.Rows(e.RowIndex).Cells(0).Value
        nm_satuan_box.Text = dgv_satuan.Rows(e.RowIndex).Cells(1).Value
        edit_btn.Enabled = True
        del_btn.Enabled = True
        exit_btn.Enabled = True
        add_btn.Enabled = False
        reset_btn.Enabled = True
    End Sub
End Class