Imports System.Data.OleDb
Imports Apotik.Sql_func
Public Class Penjualan_Form
    Private Sub Penjualan_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nm_dokter_box.Enabled = False
        nm_obat_box.Enabled = False
        hrg_jual_box.Enabled = False
        tot_bay_box.Enabled = False
        Call Otomatis()
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
                e.SuppressKeyPress = True
            Case Keys.F7
                e.SuppressKeyPress = True
            Case Keys.F12
                e.SuppressKeyPress = True
        End Select
    End Sub
    Sub Otomatis()
        Call Kon()
        cmd = New OleDbCommand("SELECT * FROM tbl_penjualan ORDER BY nota desc", conn)
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
End Class