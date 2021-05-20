Imports System.Data.OleDb

Public Class Conexao
    Public con As New OleDbConnection
    Public cmd As OleDbCommand = con.CreateCommand
    Public ds As New DataSet
    Public da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
    Public Sub conectar()
        Try
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\PCadastro\Cadastro.mdb"
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub operar(ByVal sql As String)
        conectar()
        Try
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            MsgBox("Operação realizada com sucesso!", MsgBoxStyle.Information)
        Catch erro As Exception
            MsgBox("Erro " & vbCrLf & ErrorToString(), MsgBoxStyle.Critical, "Erro")
        Finally
            con.Close()
        End Try
    End Sub

    Public Function Listar(ByVal sql As String, ByVal tab As String)
        conectar()
        Try
            ds.Clear()
            cmd.CommandText = sql
            'preenche o dataset
            da.Fill(ds, tab)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Return ds
    End Function
End Class
