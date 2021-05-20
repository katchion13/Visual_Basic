Public Class Produto

    Public codPro As Integer
    Public descricao As String
    Public valor As Double
    Public estoque As String

    Dim sql As String

    Dim ds As New DataSet
    Dim con As New Conexao

    Public Sub incluir()
        Try
            sql = "Insert Into Produto(descricao, valor, estoque)values('" & descricao & "','" & valor & "','" & estoque & "')"
            con.operar(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub alterar()
        Try
            sql = "UPDATE Produto set Descricao ='" & descricao & "', Valor =" & valor & ", Estoque=" & estoque & " where CodProd =" & codPro & ""
            con.operar(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub excluir()
        Try
            sql = "Delete from Produto where codProd =" & codPro & ""
            con.operar(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function consultar(ByVal tipo As Integer)
        If tipo = 1 Then
            sql = "select * from Produto"
            ds = con.Listar(sql, "Produto")
        End If
        If tipo = 2 Then
            sql = "select * from Produto where CodProd like'" & codPro & "%'"
            ds = con.Listar(sql, "Produto")
        End If
        If tipo = 3 Then
            sql = "select * from Produto where Descricao like'" & descricao & "%'"
            ds = con.Listar(sql, "Produto")
        End If
        Return ds
    End Function
End Class
