Public Class FProduto
    Dim pro As New Produto
    Dim tipo As String
    Dim con As New Conexao
    Dim sql As String
    Dim ds As String

    Public Sub preenchegrid(ByVal tipo As String)
        Try
            dgvProduto.DataSource = pro.consultar(tipo)
            dgvProduto.DataMember = "Produto"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tipo = 1
        preenchegrid(tipo)
    End Sub
    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        txtCodPro.Text = "Automático..."
        txtConsulta.Text = ""
        txtDescricao.Text = ""
        txtEstoque.Text = ""
        txtQuantidade.Text = ""
        txtValor.Text = ""
    End Sub
 
    Private Sub btnLancar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLancar.Click
        Dim estoque, qtd As Integer
        estoque = txtEstoque.Text
        qtd = txtQuantidade.Text
        estoque = (estoque + qtd)
        pro.estoque = estoque
        pro.codPro = txtCodPro.Text
        pro.valor = txtValor.Text
        pro.descricao = txtDescricao.Text
        pro.alterar()
        tipo = 1
        preenchegrid(tipo)
    End Sub
    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        pro.descricao = txtDescricao.Text
        pro.estoque = txtEstoque.Text
        pro.valor = txtValor.Text
        pro.alterar()
        pro.incluir()
        tipo = 1
        preenchegrid(tipo)
    End Sub
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Try
            pro.codPro = txtCodPro.Text
            pro.estoque = txtEstoque.Text
            pro.valor = txtValor.Text
            pro.descricao = txtDescricao.Text
            pro.alterar()
            tipo = 1
            preenchegrid(tipo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub rbNome_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNome.CheckedChanged
        txtConsulta.Focus()
    End Sub
    Private Sub rbCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCodigo.CheckedChanged
        txtConsulta.Focus()
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Try
            pro.codPro = txtCodPro.Text
            pro.excluir()
            tipo = 1
            preenchegrid(tipo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtConsulta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConsulta.TextChanged
        If (rbCodigo.Checked = False) And (rbNome.Checked = False) Then
            MsgBox("Escolha um opção no filtro ", MsgBoxStyle.Critical, "Atenção")
        Else
            If (txtConsulta.Text <> "") Then
                If rbCodigo.Checked = True Then
                    pro.codPro = txtConsulta.Text()
                    tipo = 2
                    preenchegrid(tipo)
                End If
                If rbNome.Checked = True Then
                    pro.descricao = txtConsulta.Text()
                    tipo = 3
                    preenchegrid(tipo)
                End If
            Else
                tipo = 1
                preenchegrid(tipo)
            End If
        End If
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Public Sub exibeRegistro(ByVal i As Integer)
        Try
            txtValor.Text = CStr(Me.dgvProduto.Item(2, i).Value)
            txtCodPro.Text = CStr(Me.dgvProduto.Item(0, i).Value)
            txtDescricao.Text = CStr(Me.dgvProduto.Item(1, i).Value)
            txtEstoque.Text = CStr(Me.dgvProduto.Item(3, i).Value)
            txtQuantidade.Text = CStr(Me.dgvProduto.Item(4, i).Value)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbLancar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLancar.CheckedChanged
        If (GbLancar.Visible = False) Then
            GbLancar.Visible = True
        Else
            GBLancar.Visible = False
        End If
    End Sub

    Private Sub dgvProduto_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProduto.CellClick
        Dim i As Integer
        i = dgvProduto.CurrentRow.Index
        exibeRegistro(i)
    End Sub
End Class

