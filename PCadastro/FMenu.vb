Public Class FMenu
    Private Sub ClienteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem1.Click
        FCliente.MdiParent = Me
        FCliente.Show()
    End Sub
    Private Sub ProdutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutoToolStripMenuItem.Click
        FProduto.MdiParent = Me
        FProduto.Show()
    End Sub
    Private Sub VendasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendasToolStripMenuItem.Click
        FVenda.MdiParent = Me
        FVenda.Show()
    End Sub
End Class