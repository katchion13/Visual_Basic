Public Class Venda

    Public codVenda As Integer
    Public codigo As Integer
    Public valor As Double
    Public dtnVenda As Date
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao
    Public Sub incluir()
        Try
            sql = "Insert Into Venda(CodVenda, Codigo, DtVenda,Valor)values(" & codVenda & "," & codigo & ",'" & dtnVenda & "', " & valor & ")"
            con.operar(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub excluir()
        Try
            sql = "Delete from Venda where CodVenda =" & codVenda & ""
            con.operar(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub alterar()
        Try
            sql = "UPDATE Venda set Codigo =" & codigo & ", Valor =" & valor & ", DtVenda =" & dtnVenda & "'where CodVenda= " & codVenda & ""
            con.operar(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function consultar(ByVal tipo As Integer)
        If tipo = 1 Then
            sql = "select * from Venda"
            ds = con.Listar(sql, "Venda")
        End If
        If tipo = 2 Then
            sql = "select * from Venda where CodVenda like '" & codVenda & "%'"
            ds = con.Listar(sql, "Venda")
        End If
        If tipo = 3 Then
            sql = "select * from Venda where CodVenda like'" & codVenda & "%'"
            ds = con.Listar(sql, "Venda")
        End If
        Return ds
    End Function
End Class
