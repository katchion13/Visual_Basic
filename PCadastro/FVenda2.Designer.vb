<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FVenda2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FVenda2))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCodVenda = New System.Windows.Forms.TextBox
        Me.txtData = New System.Windows.Forms.TextBox
        Me.txtValorTotal = New System.Windows.Forms.TextBox
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnDescricao = New System.Windows.Forms.Button
        Me.txtQtd = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtEstoque = New System.Windows.Forms.TextBox
        Me.txtValor = New System.Windows.Forms.TextBox
        Me.txtDescricao = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnCalcular = New System.Windows.Forms.Button
        Me.btnCliente = New System.Windows.Forms.Button
        Me.btnIncluir = New System.Windows.Forms.Button
        Me.btnAdicionaLista = New System.Windows.Forms.Button
        Me.btnExcluirLista = New System.Windows.Forms.Button
        Me.btnFinalizar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod. Venda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(371, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Valor"
        '
        'txtCodVenda
        '
        Me.txtCodVenda.Location = New System.Drawing.Point(85, 26)
        Me.txtCodVenda.Name = "txtCodVenda"
        Me.txtCodVenda.Size = New System.Drawing.Size(88, 20)
        Me.txtCodVenda.TabIndex = 4
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(247, 26)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(105, 20)
        Me.txtData.TabIndex = 5
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Location = New System.Drawing.Point(416, 26)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(73, 20)
        Me.txtValorTotal.TabIndex = 6
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(85, 91)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(131, 20)
        Me.txtCliente.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDescricao)
        Me.GroupBox1.Controls.Add(Me.txtQtd)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.txtEstoque)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.txtDescricao)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 145)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Produto"
        '
        'btnDescricao
        '
        Me.btnDescricao.Image = CType(resources.GetObject("btnDescricao.Image"), System.Drawing.Image)
        Me.btnDescricao.Location = New System.Drawing.Point(232, 26)
        Me.btnDescricao.Name = "btnDescricao"
        Me.btnDescricao.Size = New System.Drawing.Size(68, 24)
        Me.btnDescricao.TabIndex = 15
        Me.btnDescricao.UseVisualStyleBackColor = True
        '
        'txtQtd
        '
        Me.txtQtd.Location = New System.Drawing.Point(314, 104)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(131, 20)
        Me.txtQtd.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(229, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Quantidade"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(79, 68)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(131, 20)
        Me.txtCodigo.TabIndex = 15
        '
        'txtEstoque
        '
        Me.txtEstoque.Location = New System.Drawing.Point(314, 68)
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.Size = New System.Drawing.Size(131, 20)
        Me.txtEstoque.TabIndex = 14
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(79, 104)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(131, 20)
        Me.txtValor.TabIndex = 13
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(77, 30)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(131, 20)
        Me.txtDescricao.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(245, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Estoque"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Código"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Valor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Descrição"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(510, 20)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(66, 30)
        Me.btnCalcular.TabIndex = 9
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Image = CType(resources.GetObject("btnCliente.Image"), System.Drawing.Image)
        Me.btnCliente.Location = New System.Drawing.Point(247, 88)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(68, 25)
        Me.btnCliente.TabIndex = 10
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(488, 138)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(97, 35)
        Me.btnIncluir.TabIndex = 11
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'btnAdicionaLista
        '
        Me.btnAdicionaLista.Location = New System.Drawing.Point(488, 179)
        Me.btnAdicionaLista.Name = "btnAdicionaLista"
        Me.btnAdicionaLista.Size = New System.Drawing.Size(97, 35)
        Me.btnAdicionaLista.TabIndex = 12
        Me.btnAdicionaLista.Text = "Adiconar Lista"
        Me.btnAdicionaLista.UseVisualStyleBackColor = True
        '
        'btnExcluirLista
        '
        Me.btnExcluirLista.Location = New System.Drawing.Point(488, 220)
        Me.btnExcluirLista.Name = "btnExcluirLista"
        Me.btnExcluirLista.Size = New System.Drawing.Size(97, 35)
        Me.btnExcluirLista.TabIndex = 13
        Me.btnExcluirLista.Text = "Excluir Lista"
        Me.btnExcluirLista.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(488, 261)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(97, 35)
        Me.btnFinalizar.TabIndex = 14
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'FVenda2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(597, 428)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnExcluirLista)
        Me.Controls.Add(Me.btnAdicionaLista)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.txtValorTotal)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtCodVenda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FVenda2"
        Me.Text = "FVenda2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodVenda As System.Windows.Forms.TextBox
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents txtValorTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtQtd As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtEstoque As System.Windows.Forms.TextBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents btnCliente As System.Windows.Forms.Button
    Private WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents btnDescricao As System.Windows.Forms.Button
    Private WithEvents btnAdicionaLista As System.Windows.Forms.Button
    Private WithEvents btnExcluirLista As System.Windows.Forms.Button
    Private WithEvents btnFinalizar As System.Windows.Forms.Button
End Class
