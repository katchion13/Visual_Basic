Public Class FVenda
    Dim ven As New Venda
    Dim tipo As String
    Dim con As New Conexao
    Dim sql As String
    Dim ds As String
    Public Sub preenchegrid(ByVal tipo As String)
        Try
            dgvVenda.DataSource = ven.consultar(tipo)
            dgvVenda.DataMember = "Venda"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tipo = 1
        preenchegrid(tipo)
    End Sub
    Private Sub dgvCliente_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvVenda.CellClick
        Dim i As Integer
        i = dgvVenda.CurrentRow.Index
        exibeRegistro(i)
    End Sub
    Public Sub exibeRegistro(ByVal i As Integer)
        Try
            txtConsulta.Text = CStr(Me.dgvVenda.Item(0, 1).Value)
        Catch ex As Exception
            MsgBox("Fim dos Registros ", MsgBoxStyle.Exclamation, "Atenção")
        End Try
    End Sub
End Class

