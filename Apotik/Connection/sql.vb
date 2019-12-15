Imports System.Data.OleDb
Public Class Sql_func

    Public Shared Function Sql_dataset(sql_com As String) As DataSet
        Call Kon()
        Dim ds As New DataSet
        Sql = sql_com
        da = New OleDbDataAdapter(Sql, conn)
        da.Fill(ds)
        Return ds
    End Function

    Public Shared Function Sql_datatable(sql_com As String) As DataTable
        Call Kon()
        Dim dt As New DataTable
        Sql = sql_com
        da = New OleDbDataAdapter(Sql, conn)
        da.Fill(dt)
        Return dt
    End Function

End Class
