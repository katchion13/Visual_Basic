<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProduto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbNome = New System.Windows.Forms.RadioButton
        Me.rbCodigo = New System.Windows.Forms.RadioButton
        Me.Consulta = New System.Windows.Forms.Label
        Me.txtConsulta = New System.Windows.Forms.TextBox
        Me.dgvProduto = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCodPro = New System.Windows.Forms.TextBox
        Me.txtDescricao = New System.Windows.Forms.TextBox
        Me.txtValor = New System.Windows.Forms.TextBox
        Me.txtEstoque = New System.Windows.Forms.TextBox
        Me.cbLancar = New System.Windows.Forms.CheckBox
        Me.GBLancar = New System.Windows.Forms.GroupBox
        Me.btnLancar = New System.Windows.Forms.Button
        Me.txtQuantidade = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnIncluir = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBLancar.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNome)
        Me.GroupBox1.Controls.Add(Me.rbCodigo)
        Me.GroupBox1.Controls.Add(Me.Consulta)
        Me.GroupBox1.Controls.Add(Me.txtConsulta)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 61)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta"
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.Location = New System.Drawing.Point(393, 25)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(108, 17)
        Me.rbNome.TabIndex = 3
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome do Produto"
        Me.rbNome.UseVisualStyleBackColor = True
        '
        'rbCodigo
        '
        Me.rbCodigo.AutoSize = True
        Me.rbCodigo.Location = New System.Drawing.Point(274, 27)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(113, 17)
        Me.rbCodigo.TabIndex = 2
        Me.rbCodigo.TabStop = True
        Me.rbCodigo.Text = "Código do Produto"
        Me.rbCodigo.UseVisualStyleBackColor = True
        '
        'Consulta
        '
        Me.Consulta.AutoSize = True
        Me.Consulta.Location = New System.Drawing.Point(16, 27)
        Me.Consulta.Name = "Consulta"
        Me.Consulta.Size = New System.Drawing.Size(48, 13)
        Me.Consulta.TabIndex = 1
        Me.Consulta.Text = "Consulta"
        '
        'txtConsulta
        '
        Me.txtConsulta.Location = New System.Drawing.Point(77, 24)
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.Size = New System.Drawing.Size(157, 20)
        Me.txtConsulta.TabIndex = 1
        '
        'dgvProduto
        '
        Me.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduto.Location = New System.Drawing.Point(38, 90)
        Me.dgvProduto.Name = "dgvProduto"
        Me.dgvProduto.Size = New System.Drawing.Size(465, 197)
        Me.dgvProduto.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código do Produto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Descrição"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(312, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Valor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(312, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Estoque"
        '
        'txtCodPro
        '
        Me.txtCodPro.Enabled = False
        Me.txtCodPro.Location = New System.Drawing.Point(115, 305)
        Me.txtCodPro.Name = "txtCodPro"
        Me.txtCodPro.Size = New System.Drawing.Size(165, 20)
        Me.txtCodPro.TabIndex = 6
        Me.txtCodPro.Text = "Automático..."
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(115, 345)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(165, 20)
        Me.txtDescricao.TabIndex = 6
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(374, 302)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(129, 20)
        Me.txtValor.TabIndex = 5
        '
        'txtEstoque
        '
        Me.txtEstoque.Location = New System.Drawing.Point(374, 342)
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.Size = New System.Drawing.Size(129, 20)
        Me.txtEstoque.TabIndex = 9
        '
        'cbLancar
        '
        Me.cbLancar.AutoSize = True
        Me.cbLancar.Location = New System.Drawing.Point(52, 418)
        Me.cbLancar.Name = "cbLancar"
        Me.cbLancar.Size = New System.Drawing.Size(101, 17)
        Me.cbLancar.TabIndex = 10
        Me.cbLancar.Text = "Lançar Estoque"
        Me.cbLancar.UseVisualStyleBackColor = True
        '
        'GBLancar
        '
        Me.GBLancar.Controls.Add(Me.btnLancar)
        Me.GBLancar.Controls.Add(Me.txtQuantidade)
        Me.GBLancar.Controls.Add(Me.Label6)
        Me.GBLancar.Location = New System.Drawing.Point(183, 382)
        Me.GBLancar.Name = "GBLancar"
        Me.GBLancar.Size = New System.Drawing.Size(335, 76)
        Me.GBLancar.TabIndex = 11
        Me.GBLancar.TabStop = False
        Me.GBLancar.Text = "Lançar Estoque"
        Me.GBLancar.Visible = False
        '
        'btnLancar
        '
        Me.btnLancar.Location = New System.Drawing.Point(227, 19)
        Me.btnLancar.Name = "btnLancar"
        Me.btnLancar.Size = New System.Drawing.Size(98, 34)
        Me.btnLancar.TabIndex = 13
        Me.btnLancar.Text = "Lançar Produto"
        Me.btnLancar.UseVisualStyleBackColor = True
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(92, 26)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(101, 20)
        Me.txtQuantidade.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Quantidade"
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(16, 473)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(88, 34)
        Me.btnIncluir.TabIndex = 14
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(115, 473)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(88, 34)
        Me.btnAlterar.TabIndex = 15
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(219, 473)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(86, 34)
        Me.btnExcluir.TabIndex = 16
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(358, 473)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(81, 34)
        Me.btnLimpar.TabIndex = 18
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(445, 473)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(83, 34)
        Me.btnSair.TabIndex = 20
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'FProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(537, 524)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.cbLancar)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.GBLancar)
        Me.Controls.Add(Me.txtEstoque)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtCodPro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvProduto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FProduto"
        Me.Text = "FProduto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBLancar.ResumeLayout(False)
        Me.GBLancar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtConsulta As System.Windows.Forms.TextBox
    Friend WithEvents rbNome As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents Consulta As System.Windows.Forms.Label
    Friend WithEvents dgvProduto As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodPro As System.Windows.Forms.TextBox
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents txtEstoque As System.Windows.Forms.TextBox
    Friend WithEvents cbLancar As System.Windows.Forms.CheckBox
    Friend WithEvents GBLancar As System.Windows.Forms.GroupBox
    Friend WithEvents btnLancar As System.Windows.Forms.Button
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
End Class
