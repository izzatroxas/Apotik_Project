Imports System.Data.OleDb
Imports Apotik.Sql_func
Public Class Penjualan_Form
    Private Sub Penjualan_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub A1_KeyDown(sender As Object, e As KeyEventArgs) Handles A1.KeyDown
        If e.KeyCode = Keys.F1 Then
            Cari_Dokter_Form.Show()
        End If
    End Sub
End Class