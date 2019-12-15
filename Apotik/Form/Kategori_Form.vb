Imports System.Data.OleDb
Imports Apotik.Sql_func
Public Class Kategori_Form
    Private Sub Kategori_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call Clean()
    End Sub
    Sub Otomatis()
        Call Kon()
        cmd = New OleDbCommand("SELECT * FROM tbl_kategori ORDER BY kode_kategori desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            kode.Text = "K-01"
        Else
            kode.Text = "K-" + Format(Microsoft.VisualBasic.Right(dr.Item("kode_kategori"), 2) + 1, "00")
        End If
    End Sub
    Sub Clean()
        nm_kategori_box.Clear()
        nm_kategori_box.Select()
        nm_kategori_box.Enabled = False
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
        nm_kategori_box.Clear()
        nm_kategori_box.Select()
    End Sub
    Sub Found()
        Call Kon()
        nm_kategori_box.Text = dr.Item("kategori")
        nm_kategori_box.Select()
    End Sub
    Sub Dgv()
        Call Kon()
        sql = "SELECT * FROM tbl_kategori"
        ds = Sql_dataset(sql)
        dgv_kategori.DataSource = ds.Tables(0)
        dgv_kategori.ReadOnly = True
    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Call Baru()
    End Sub

    Private Sub Reset_btn_Click(sender As Object, e As EventArgs) Handles reset_btn.Click
        Call Clean()
    End Sub

    Private Sub Add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        kode.Enabled = True
        nm_kategori_box.Enabled = True
        add_btn.Enabled = False
        save_btn.Enabled = True
        reset_btn.Enabled = True
        exit_btn.Enabled = True
    End Sub

    Private Sub Cari_box_TextChanged(sender As Object, e As EventArgs) Handles cari_box.TextChanged
        Call Kon()
        sql = "SELECT * FROM tbl_kategori WHERE kode_kategori like '%" & cari_box.Text & "%' or kategori like '%" & cari_box.Text & "%'"
        da = New OleDbDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds)
        dgv_kategori.DataSource = ds.Tables(0)
        dgv_kategori.ReadOnly = True
    End Sub

    Private Sub Del_btn_Click(sender As Object, e As EventArgs) Handles del_btn.Click
        Call Kon()
        cmd = New OleDbCommand("SELECT * FROM tbl_kategori WHERE kode_kategori = '" & kode.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            MsgBox("Data Kategori Tidak Ada")
            Exit Sub
        End If
        If MessageBox.Show("Yakin mau dihapus ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Call Kon()
            Dim del As String
            del = "DELETE FROM tbl_kategori WHERE kode_kategori = '" & kode.Text & "'"
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
                add = "INSERT INTO tbl_kategori (kode_kategori, kategori) VALUES (@kd, @ktg)"
                cmd = New OleDbCommand(add, conn)
                cmd.Parameters.AddWithValue("@kd", kode.Text)
                cmd.Parameters.AddWithValue("@ktg", nm_kategori_box.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Disimpan")
            Else
                Call Kon()
                Dim edit As String
                edit = "UPDATE tbl_kategori SET kategori = @ktg WHERE kode_kategori = @kd"
                cmd = New OleDbCommand(edit, conn)
                cmd.Parameters.AddWithValue("@kd", kode.Text)
                cmd.Parameters.AddWithValue("@ktg", nm_kategori_box.Text)
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
        sql = "SELECT * FROM tbl_kategori WHERE kode_kategori ='" & kode.Text & "'"
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
        nm_kategori_box.Enabled = True
        add_btn.Enabled = False
        save_btn.Enabled = True
        edit_btn.Enabled = False
        del_btn.Enabled = False
        reset_btn.Enabled = True
        exit_btn.Enabled = True
    End Sub
    Private Sub Dgv_kategori_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_kategori.CellMouseClick
        On Error Resume Next
        kode.Text = dgv_kategori.Rows(e.RowIndex).Cells(0).Value
        nm_kategori_box.Text = dgv_kategori.Rows(e.RowIndex).Cells(1).Value
        edit_btn.Enabled = True
        del_btn.Enabled = True
        exit_btn.Enabled = True
        add_btn.Enabled = False
        reset_btn.Enabled = True
    End Sub
End Class