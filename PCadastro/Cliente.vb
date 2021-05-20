
Public Class Cliente
    Public nome As String
    Public codigo As Integer
    Public cidade As String
    Public dtn As Date

    Dim sql As String

    Dim ds As New DataSet
    Dim con As New Conexao
    Public Sub incluir()
        Try
            sql = "Insert Into Clientes(Nome, Cidade, DtNas)values('" & nome & "','" & cidade & "','" & dtn & "')"
            con.operar(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub excluir()
        Try
            sql = "Delete from Clientes where Codigo =" & codigo & ""
            con.operar(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub alterar()
        Try
            sql = "UPDATE Clientes set Nome= '" & nome & "', Cidade ='" & cidade & "'where Codigo = " & codigo & ""
            con.operar(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function consultar(ByVal tipo As Integer)
        If tipo = 1 Then
            sql = "select * from Clientes"
            ds = con.Listar(sql, "Clientes")
        End If
        If tipo = 2 Then
            sql = "select * from Clientes where Codigo like'" & codigo & "%'"
            ds = con.Listar(sql, "Clientes")
        End If
        If tipo = 3 Then
            sql = "select * from CLientes where Nome like'" & nome & "%'"
            ds = con.Listar(sql, "Clientes")
        End If
        Return ds
    End Function
End Class
