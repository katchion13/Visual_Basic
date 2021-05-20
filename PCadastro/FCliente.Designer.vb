<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCliente
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
        Me.dgvCliente = New System.Windows.Forms.DataGridView
        Me.txtConsulta = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.RbCodigo = New System.Windows.Forms.RadioButton
        Me.RbNome = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.btnIncluir = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.cmbCidade = New System.Windows.Forms.ComboBox
        Me.txtDtNas = New System.Windows.Forms.MaskedTextBox
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCliente
        '
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Location = New System.Drawing.Point(14, 102)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.Size = New System.Drawing.Size(455, 178)
        Me.dgvCliente.TabIndex = 0
        '
        'txtConsulta
        '
        Me.txtConsulta.Location = New System.Drawing.Point(74, 39)
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.Size = New System.Drawing.Size(146, 20)
        Me.txtConsulta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Consulta"
        '
        'RbCodigo
        '
        Me.RbCodigo.AutoSize = True
        Me.RbCodigo.Location = New System.Drawing.Point(286, 42)
        Me.RbCodigo.Name = "RbCodigo"
        Me.RbCodigo.Size = New System.Drawing.Size(58, 17)
        Me.RbCodigo.TabIndex = 2
        Me.RbCodigo.TabStop = True
        Me.RbCodigo.Text = "Código"
        Me.RbCodigo.UseVisualStyleBackColor = True
        '
        'RbNome
        '
        Me.RbNome.AutoSize = True
        Me.RbNome.Location = New System.Drawing.Point(372, 42)
        Me.RbNome.Name = "RbNome"
        Me.RbNome.Size = New System.Drawing.Size(53, 17)
        Me.RbNome.TabIndex = 3
        Me.RbNome.TabStop = True
        Me.RbNome.Text = "Nome"
        Me.RbNome.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbNome)
        Me.GroupBox1.Controls.Add(Me.RbCodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtConsulta)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 84)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 357)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nome"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(78, 306)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(104, 20)
        Me.txtCodigo.TabIndex = 5
        Me.txtCodigo.Text = "Automático..."
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(78, 352)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(138, 20)
        Me.txtNome.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(254, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Data de Nascimento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(261, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cidade"
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(340, 401)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(60, 35)
        Me.btnLimpar.TabIndex = 10
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(14, 401)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(81, 35)
        Me.btnIncluir.TabIndex = 7
        Me.btnIncluir.Text = "Incluir Cliente"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(101, 401)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(81, 35)
        Me.btnAlterar.TabIndex = 8
        Me.btnAlterar.Text = "Alterar Dados"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(188, 401)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(81, 35)
        Me.btnExcluir.TabIndex = 9
        Me.btnExcluir.Text = "Excluir Cliente"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(406, 401)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(63, 35)
        Me.btnSair.TabIndex = 11
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'cmbCidade
        '
        Me.cmbCidade.FormattingEnabled = True
        Me.cmbCidade.Items.AddRange(New Object() {"Iguape", "Ilha Comprida", "Icapara ", "Registro ", "São Paulo ", "Miracatu", "Curitiba ", "Londrina ", "Maringá", "Iguape", "Ilha Comprida", "Icapara ", "Registro ", "São Paulo ", "Miracatu", "Curitiba ", "Londrina ", "Maringá"})
        Me.cmbCidade.Location = New System.Drawing.Point(322, 349)
        Me.cmbCidade.Name = "cmbCidade"
        Me.cmbCidade.Size = New System.Drawing.Size(123, 21)
        Me.cmbCidade.TabIndex = 6
        '
        'txtDtNas
        '
        Me.txtDtNas.Location = New System.Drawing.Point(376, 306)
        Me.txtDtNas.Mask = "00/00/0000"
        Me.txtDtNas.Name = "txtDtNas"
        Me.txtDtNas.Size = New System.Drawing.Size(70, 20)
        Me.txtDtNas.TabIndex = 4
        Me.txtDtNas.ValidatingType = GetType(Date)
        '
        'FCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(481, 451)
        Me.Controls.Add(Me.txtDtNas)
        Me.Controls.Add(Me.cmbCidade)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvCliente)
        Me.Name = "FCliente"
        Me.Text = "Cadastro de Clientes"
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents txtConsulta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents RbNome As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents cmbCidade As System.Windows.Forms.ComboBox
    Friend WithEvents txtDtNas As System.Windows.Forms.MaskedTextBox

End Class
