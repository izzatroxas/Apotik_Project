Imports System.Data.OleDb

Module hub

    Public str As String
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public sql As String

    Sub Kon()
        'str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\project.accdb;Persist Security Info=True;Jet OLEDB:Database Password=1234"
        str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\project.accdb;Persist Security Info=True;Jet OLEDB:Database Password=1234"
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        Else
            MsgBox("Connection Failed")
        End If

    End Sub

    Function Check() As Boolean
        Try
            'str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\project.accdb;Persist Security Info=True;Jet OLEDB:Database Password=1234"
            str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\project.accdb;Persist Security Info=True;Jet OLEDB:Database Password=1234"
            conn = New OleDbConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Return True
            End If
            Return False

        Catch ex As Exception
            Return False
        End Try
    End Function


End Module
