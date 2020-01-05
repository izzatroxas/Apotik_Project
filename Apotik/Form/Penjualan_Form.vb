Imports System.Data.OleDb
Imports Apotik.Sql_func
Public Class Penjualan_Form
    Private Sub Penjualan_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nm_dokter_box.Enabled = False
        nm_obat_box.Enabled = False
        hrg_jual_box.Enabled = False
        tot_bay_box.Enabled = False
        Call Clean()
    End Sub
    Public Sub Clean()
        kode_dokter_lbl.ResetText()
        kode_dokter_lbl.ResetText()
        nm_dokter_box.Clear()
        nm_obat_box.Clear()
        jmlh_box.Clear()
        hrg_jual_box.Clear()
        potongan_box.Clear()
        tot_bay_box.Clear()
        tot_lbl.Text = ""
        jmlh_box.Select()
        Call DGV()
        Call Otomatis()
    End Sub
    Sub Found()
        Call Kon()
        nota_lbl.Text = dr.Item("nota")
        nm_dokter_box.Text = dr.Item("nm_dokter")
        nm_obat_box.Text = dr.Item("nm_obat")
        jmlh_box.Text = dr.Item("qty")
        hrg_jual_box.Text = dr.Item("harga_jual")
        potongan_box.Text = dr.Item("pot")
        tot_bay_box.Text = dr.Item("total")
        Transaksi_Penjualan_Form.kmbl_txt = dr.Item("sisa")
        jmlh_box.Select()
    End Sub
    Sub DGV()
        Call Kon()
        sql = "SELECT * FROM tbl_penjualan"
        ds = Sql_dataset(sql)
        dgv_penjualan.DataSource = ds.Tables(0)
        dgv_penjualan.ReadOnly = True
        dgv_penjualan.Columns(0).HeaderText = "Nota"
        dgv_penjualan.Columns(1).HeaderText = "Nama Dokter"
        dgv_penjualan.Columns(2).HeaderText = "Nama Obat"
        dgv_penjualan.Columns(3).HeaderText = "QTY"
        dgv_penjualan.Columns(4).HeaderText = "Harga Jual"
        dgv_penjualan.Columns(5).HeaderText = "Potongan"
        dgv_penjualan.Columns(6).HeaderText = "Total Bayar"
        dgv_penjualan.Columns(7).HeaderText = "Sisa"
        dgv_penjualan.Columns(0).Width = 50
        dgv_penjualan.Columns(1).Width = 100
        dgv_penjualan.Columns(2).Width = 100
        dgv_penjualan.Columns(3).Width = 50
        dgv_penjualan.Columns(4).Width = 100
        dgv_penjualan.Columns(5).Width = 100
        dgv_penjualan.Columns(6).Width = 100
        dgv_penjualan.Columns(7).Width = 100
        dgv_penjualan.RowsDefaultCellStyle.BackColor = Color.LightBlue
        dgv_penjualan.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub Penjualan_Form_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                Cari_Dokter_Form.Show()
                e.SuppressKeyPress = True
            Case Keys.F2
                Cari_Obat_Form.Show()
                e.SuppressKeyPress = True
            Case Keys.F5
                Transaksi_Penjualan_Form.Show()
                e.SuppressKeyPress = True
            Case Keys.F7
                Call Clean()
                e.SuppressKeyPress = True
            Case Keys.F12
                Call Kon()
                cmd = New OleDbCommand("SELECT * FROM tbl_penjualan WHERE nota = '" & nota_lbl.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If Not dr.HasRows Then
                    MsgBox("Data Transaksi Tidak Ada !")
                    Exit Sub
                End If
                If MessageBox.Show("Yakin mau dihapus ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Call Kon()
                    Dim del As String
                    del = "DELETE FROM tbl_penjualan WHERE nota = '" & nota_lbl.Text & "'"
                    cmd = New OleDbCommand(del, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil dihapus")
                    Call Clean()
                Else
                    Call Clean()
                End If
                e.SuppressKeyPress = True
        End Select
    End Sub
    Sub Otomatis()
        Call Kon()
        cmd = New OleDbCommand("SELECT * FROM tbl_penjualan ORDER BY nota DESC", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            nota_lbl.Text = "N-0001"
        Else
            nota_lbl.Text = "N-" + Format(Microsoft.VisualBasic.Right(dr.Item("nota"), 4) + 1, "0000")
        End If
    End Sub
    Private Sub Total_Harga_Berubah(sender As Object, e As EventArgs) Handles hrg_jual_box.TextChanged, jmlh_box.TextChanged, potongan_box.TextChanged
        If String.IsNullOrEmpty(potongan_box.Text) OrElse String.IsNullOrEmpty(hrg_jual_box.Text) OrElse String.IsNullOrEmpty(jmlh_box.Text) Then
            Exit Sub
        End If
        If Not IsNumeric(jmlh_box.Text) OrElse Not IsNumeric(hrg_jual_box.Text) OrElse Not IsNumeric(potongan_box.Text) Then
            Exit Sub
        End If
        tot_bay_box.Text = CDbl(hrg_jual_box.Text) * CDbl(jmlh_box.Text) - CDbl(potongan_box.Text)
    End Sub

    Private Sub Dgv_penjualan_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_penjualan.CellMouseClick
        On Error Resume Next
        nota_lbl.Text = dgv_penjualan.Rows(e.RowIndex).Cells(0).Value
        nm_dokter_box.Text = dgv_penjualan.Rows(e.RowIndex).Cells(1).Value
        nm_obat_box.Text = dgv_penjualan.Rows(e.RowIndex).Cells(2).Value
        jmlh_box.Text = dgv_penjualan.Rows(e.RowIndex).Cells(3).Value
        hrg_jual_box.Text = dgv_penjualan.Rows(e.RowIndex).Cells(4).Value
        potongan_box.Text = dgv_penjualan.Rows(e.RowIndex).Cells(5).Value
        tot_bay_box.Text = dgv_penjualan.Rows(e.RowIndex).Cells(6).Value
        Transaksi_Penjualan_Form.kmbl_txt = dgv_penjualan.Rows(e.RowIndex).Cells(7).Value
    End Sub

    Private Sub Nota_lbl_LostFocus(sender As Object, e As EventArgs) Handles nota_lbl.LostFocus
        Call Kon()
        sql = "SELECT * FROM tbl_penjualan WHERE nota ='" & nota_lbl.Text & "'"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            Call Clean()
        Else
            Call Found()
        End If
    End Sub
End Class