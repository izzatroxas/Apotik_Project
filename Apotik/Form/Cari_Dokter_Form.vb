Imports System.Data.OleDb
Imports Apotik.Sql_func
Public Class Cari_Dokter_Form
    Private Sub Cari_Dokter_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call DGV()
    End Sub
    Sub DGV()
        Call Kon()
        sql = "SELECT * FROM tbl_dokter"
        ds = Sql_dataset(sql)
        dgv_dokter.DataSource = ds.Tables(0)
        dgv_dokter.ReadOnly = True
        dgv_dokter.Columns(0).HeaderText = "Kode Dokter"
        dgv_dokter.Columns(1).HeaderText = "Nama Dokter"
        dgv_dokter.Columns(2).HeaderText = "Alamat"
        dgv_dokter.Columns(3).HeaderText = "Nomor Telepon"
        dgv_dokter.Columns(0).Width = 60
        dgv_dokter.Columns(1).Width = 130
        dgv_dokter.Columns(2).Width = 200
        dgv_dokter.Columns(3).Width = 90
        dgv_dokter.RowsDefaultCellStyle.BackColor = Color.LightBlue
        dgv_dokter.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
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

    Private Sub Dgv_dokter_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dokter.CellDoubleClick
        On Error Resume Next
        Penjualan_Form.kode_dokter_lbl.Text = dgv_dokter.Rows(e.RowIndex).Cells(0).Value
        Penjualan_Form.nm_dokter_box.Text = dgv_dokter.Rows(e.RowIndex).Cells(1).Value
        Me.Close()
    End Sub
End Class