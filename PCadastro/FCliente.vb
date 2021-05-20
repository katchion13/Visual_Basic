Public Class FCliente
    Dim cli As New Cliente
    Dim tipo As String
    Dim con As New Conexao
    Dim sql As String
    Dim ds As String
    Public Sub preenchegrid(ByVal tipo As String)
        Try
            dgvCliente.DataSource = cli.consultar(tipo)
            dgvCliente.DataMember = "Clientes"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tipo = 1
        preenchegrid(tipo)
    End Sub
    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        txtNome.Text = ""
        txtCodigo.Text = "Automático..."
        txtConsulta.Text = ""
        cmbCidade.Text = "Selecione..."
        txtDtNas.Text = "  /  / "

    End Sub
    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        cli.nome = txtNome.Text
        cli.cidade = cmbCidade.Text
        cli.dtn = txtDtNas.Text
        cli.incluir()
        tipo = 1
        preenchegrid(tipo)
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        cli.codigo = txtCodigo.Text
        cli.nome = txtNome.Text
        cli.cidade = cmbCidade.Text
        cli.dtn = txtDtNas.Text
        cli.alterar()
        tipo = 1
        preenchegrid(tipo)
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        cli.codigo = txtCodigo.Text
        cli.excluir()
        tipo = 1
        preenchegrid(tipo)
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub
    Private Sub dgvCliente_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCliente.CellClick
        cmbCidade.Text = ""
        Dim i As Integer
        i = dgvCliente.CurrentRow.Index
        exibeRegistro(i)
    End Sub
    Private Sub txtConsulta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConsulta.TextChanged
        If (RbCodigo.Checked = False) And (RbNome.Checked = False) Then
            MsgBox("Escolha um opção no filtro ", MsgBoxStyle.Critical, "Atenção")
        Else
            If (txtConsulta.Text <> "") Then
                If RbCodigo.Checked = True Then
                    cli.codigo = txtConsulta.Text
                    tipo = 2
                    preenchegrid(tipo)
                End If
                If RbNome.Checked = True Then
                    cli.nome = txtConsulta.Text
                    tipo = 3
                    preenchegrid(tipo)
                End If
            Else
                tipo = 1
                preenchegrid(tipo)
            End If
        End If
    End Sub
    Private Sub RbCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbCodigo.CheckedChanged
        txtConsulta.Focus()
    End Sub

    Private Sub RbNome_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbNome.CheckedChanged
        txtConsulta.Focus()
    End Sub

    Public Sub exibeRegistro(ByVal i As Integer)
        Try
            txtCodigo.Text = CStr(Me.dgvCliente.Item(0, i).Value)
            txtNome.Text = CStr(Me.dgvCliente.Item(1, i).Value)
            cmbCidade.Text = CStr(Me.dgvCliente.Item(2, i).Value)
            txtDtNas.Text = CStr(Me.dgvCliente.Item(3, i).Value)
        Catch ex As Exception
            MsgBox("Fim dos Registros ", MsgBoxStyle.Exclamation, "Atenção")
        End Try
    End Sub

End Class
