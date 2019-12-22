Imports System.Data.OleDb
Imports Apotik.Sql_func
Public Class Cari_Obat_Form
    Private Sub Cari_Obat_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call DGV()
    End Sub
    Sub Dgv()
        Call Kon()
        sql = "SELECT * FROM tbl_obat"
        ds = Sql_dataset(sql)
        dgv_obat.DataSource = ds.Tables(0)
        dgv_obat.ReadOnly = True
        dgv_obat.DataSource = ds.Tables(0)
        dgv_obat.ReadOnly = True
        dgv_obat.Columns(0).HeaderText = "Kode Obat"
        dgv_obat.Columns(1).HeaderText = "Nama Obat"
        dgv_obat.Columns(2).HeaderText = "Kategori"
        dgv_obat.Columns(3).HeaderText = "Satuan"
        dgv_obat.Columns(4).HeaderText = "Stok"
        dgv_obat.Columns(5).HeaderText = "Harga Beli"
        dgv_obat.Columns(6).HeaderText = "Harga Jual"
        dgv_obat.Columns(7).HeaderText = "Laba"
        dgv_obat.Columns(8).HeaderText = "Kode Pemasok"
        dgv_obat.Columns(0).Width = 50
        dgv_obat.Columns(1).Width = 110
        dgv_obat.Columns(2).Width = 60
        dgv_obat.Columns(3).Width = 60
        dgv_obat.Columns(4).Width = 40
        dgv_obat.Columns(5).Width = 75
        dgv_obat.Columns(6).Width = 75
        dgv_obat.Columns(7).Width = 75
        dgv_obat.Columns(8).Width = 50
        dgv_obat.RowsDefaultCellStyle.BackColor = Color.LightBlue
        dgv_obat.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
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

    Private Sub Dgv_obat_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_obat.CellMouseDoubleClick
        On Error Resume Next
        Penjualan_Form.kode_obat_lbl.Text = dgv_obat.Rows(e.RowIndex).Cells(0).Value
        Penjualan_Form.nm_obat_box.Text = dgv_obat.Rows(e.RowIndex).Cells(1).Value
        Penjualan_Form.hrg_jual_box.Text = dgv_obat.Rows(e.RowIndex).Cells(6).Value
        Me.Close()
    End Sub
End Class