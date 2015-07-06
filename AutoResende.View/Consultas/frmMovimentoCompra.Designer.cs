namespace AutoResende.View.Cadastros
{
    partial class frmMovimentoCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimentoCompra));
            this.button1 = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.picimg_cliente = new System.Windows.Forms.PictureBox();
            this.lblfuncionários = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbTipoServico = new System.Windows.Forms.ComboBox();
            this.txtQuantidadeTipoServico = new System.Windows.Forms.TextBox();
            this.lblQdeEstoque = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecoTipoServico = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPrecoMercadoria = new System.Windows.Forms.TextBox();
            this.txtQuantidadeMercadoria = new System.Windows.Forms.TextBox();
            this.cmbMercadoria = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.dtgOrcamento = new System.Windows.Forms.DataGridView();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCPFCliente = new System.Windows.Forms.TextBox();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picimg_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrcamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(829, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 24);
            this.button1.TabIndex = 184;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGravar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGravar.Location = new System.Drawing.Point(727, 435);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(115, 25);
            this.btnGravar.TabIndex = 209;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // picimg_cliente
            // 
            this.picimg_cliente.BackColor = System.Drawing.Color.Transparent;
            this.picimg_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picimg_cliente.Image = ((System.Drawing.Image)(resources.GetObject("picimg_cliente.Image")));
            this.picimg_cliente.Location = new System.Drawing.Point(26, 14);
            this.picimg_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.picimg_cliente.Name = "picimg_cliente";
            this.picimg_cliente.Size = new System.Drawing.Size(87, 85);
            this.picimg_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picimg_cliente.TabIndex = 211;
            this.picimg_cliente.TabStop = false;
            // 
            // lblfuncionários
            // 
            this.lblfuncionários.AutoSize = true;
            this.lblfuncionários.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lblfuncionários.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfuncionários.ForeColor = System.Drawing.Color.White;
            this.lblfuncionários.Location = new System.Drawing.Point(142, 14);
            this.lblfuncionários.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfuncionários.Name = "lblfuncionários";
            this.lblfuncionários.Size = new System.Drawing.Size(118, 25);
            this.lblfuncionários.TabIndex = 210;
            this.lblfuncionários.Text = "Orçamento";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pictureBox2.Location = new System.Drawing.Point(1, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(866, 45);
            this.pictureBox2.TabIndex = 212;
            this.pictureBox2.TabStop = false;
            // 
            // cmbTipoServico
            // 
            this.cmbTipoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoServico.FormattingEnabled = true;
            this.cmbTipoServico.Location = new System.Drawing.Point(147, 138);
            this.cmbTipoServico.Name = "cmbTipoServico";
            this.cmbTipoServico.Size = new System.Drawing.Size(263, 21);
            this.cmbTipoServico.TabIndex = 295;
            this.cmbTipoServico.Text = "Tipo de Serviço";
            this.cmbTipoServico.SelectedIndexChanged += new System.EventHandler(this.cmbTipoServico_SelectedIndexChanged);
            // 
            // txtQuantidadeTipoServico
            // 
            this.txtQuantidadeTipoServico.Location = new System.Drawing.Point(636, 138);
            this.txtQuantidadeTipoServico.Name = "txtQuantidadeTipoServico";
            this.txtQuantidadeTipoServico.Size = new System.Drawing.Size(114, 20);
            this.txtQuantidadeTipoServico.TabIndex = 297;
            // 
            // lblQdeEstoque
            // 
            this.lblQdeEstoque.AutoSize = true;
            this.lblQdeEstoque.BackColor = System.Drawing.Color.Transparent;
            this.lblQdeEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQdeEstoque.Location = new System.Drawing.Point(600, 141);
            this.lblQdeEstoque.Name = "lblQdeEstoque";
            this.lblQdeEstoque.Size = new System.Drawing.Size(30, 13);
            this.lblQdeEstoque.TabIndex = 296;
            this.lblQdeEstoque.Text = "Qde";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 298;
            this.label1.Text = "Preço";
            // 
            // txtPrecoTipoServico
            // 
            this.txtPrecoTipoServico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecoTipoServico.Enabled = false;
            this.txtPrecoTipoServico.Location = new System.Drawing.Point(476, 139);
            this.txtPrecoTipoServico.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecoTipoServico.Name = "txtPrecoTipoServico";
            this.txtPrecoTipoServico.Size = new System.Drawing.Size(111, 20);
            this.txtPrecoTipoServico.TabIndex = 299;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(770, 135);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 25);
            this.button2.TabIndex = 300;
            this.button2.Text = "Incluir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPrecoMercadoria
            // 
            this.txtPrecoMercadoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecoMercadoria.Enabled = false;
            this.txtPrecoMercadoria.Location = new System.Drawing.Point(476, 168);
            this.txtPrecoMercadoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecoMercadoria.Name = "txtPrecoMercadoria";
            this.txtPrecoMercadoria.Size = new System.Drawing.Size(111, 20);
            this.txtPrecoMercadoria.TabIndex = 303;
            // 
            // txtQuantidadeMercadoria
            // 
            this.txtQuantidadeMercadoria.Location = new System.Drawing.Point(636, 168);
            this.txtQuantidadeMercadoria.Name = "txtQuantidadeMercadoria";
            this.txtQuantidadeMercadoria.Size = new System.Drawing.Size(114, 20);
            this.txtQuantidadeMercadoria.TabIndex = 302;
            // 
            // cmbMercadoria
            // 
            this.cmbMercadoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMercadoria.FormattingEnabled = true;
            this.cmbMercadoria.Location = new System.Drawing.Point(147, 167);
            this.cmbMercadoria.Name = "cmbMercadoria";
            this.cmbMercadoria.Size = new System.Drawing.Size(263, 21);
            this.cmbMercadoria.TabIndex = 301;
            this.cmbMercadoria.Text = "Mercadoria";
            this.cmbMercadoria.SelectedIndexChanged += new System.EventHandler(this.cmbMercadoria_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(770, 165);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 25);
            this.button3.TabIndex = 304;
            this.button3.Text = "Incluir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 306;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 305;
            this.label3.Text = "Qde";
            // 
            // dtpValidade
            // 
            this.dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidade.Location = new System.Drawing.Point(209, 53);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(91, 20);
            this.dtpValidade.TabIndex = 307;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 308;
            this.label4.Text = "Validade";
            // 
            // lblnome
            // 
            this.lblnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.Transparent;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(314, 56);
            this.lblnome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(39, 13);
            this.lblnome.TabIndex = 310;
            this.lblnome.Text = "Nome";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeCliente.Location = new System.Drawing.Point(357, 52);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeCliente.MaxLength = 40;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(230, 20);
            this.txtNomeCliente.TabIndex = 309;
            // 
            // dtgOrcamento
            // 
            this.dtgOrcamento.AllowUserToAddRows = false;
            this.dtgOrcamento.AllowUserToOrderColumns = true;
            this.dtgOrcamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgOrcamento.BackgroundColor = System.Drawing.Color.Beige;
            this.dtgOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrcamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantidade,
            this.Tipo,
            this.Descricao,
            this.PrecoUnit,
            this.ValorTotal});
            this.dtgOrcamento.Location = new System.Drawing.Point(147, 195);
            this.dtgOrcamento.Name = "dtgOrcamento";
            this.dtgOrcamento.Size = new System.Drawing.Size(695, 220);
            this.dtgOrcamento.TabIndex = 311;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            // 
            // PrecoUnit
            // 
            this.PrecoUnit.HeaderText = "PreçoUnit";
            this.PrecoUnit.Name = "PrecoUnit";
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "ValorTotal";
            this.ValorTotal.Name = "ValorTotal";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(143, 438);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 313;
            this.label5.Text = "TOTAL    R$";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(222, 431);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(111, 26);
            this.txtTotal.TabIndex = 312;
            this.txtTotal.Text = "00,00";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(600, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 315;
            this.label6.Text = "CPF";
            // 
            // txtCPFCliente
            // 
            this.txtCPFCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCPFCliente.BackColor = System.Drawing.Color.Beige;
            this.txtCPFCliente.Location = new System.Drawing.Point(636, 52);
            this.txtCPFCliente.Margin = new System.Windows.Forms.Padding(1);
            this.txtCPFCliente.MaxLength = 40;
            this.txtCPFCliente.Name = "txtCPFCliente";
            this.txtCPFCliente.Size = new System.Drawing.Size(114, 20);
            this.txtCPFCliente.TabIndex = 314;
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisaCliente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPesquisaCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisaCliente.BackgroundImage")));
            this.btnPesquisaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisaCliente.Location = new System.Drawing.Point(792, 49);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(22, 23);
            this.btnPesquisaCliente.TabIndex = 316;
            this.btnPesquisaCliente.UseVisualStyleBackColor = false;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.btnPesquisaCliente_Click);
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Location = new System.Drawing.Point(419, 105);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(168, 20);
            this.txtCombustivel.TabIndex = 327;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 325;
            this.label7.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(209, 79);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(150, 20);
            this.txtMarca.TabIndex = 324;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.BackColor = System.Drawing.Color.Transparent;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(144, 108);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(26, 13);
            this.lblCor.TabIndex = 323;
            this.lblCor.Text = "Cor";
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.BackColor = System.Drawing.Color.Transparent;
            this.lblCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustivel.Location = new System.Drawing.Point(371, 107);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(42, 13);
            this.lblCombustivel.TabIndex = 322;
            this.lblCombustivel.Text = "Comb.";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(209, 104);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(150, 20);
            this.txtCor.TabIndex = 321;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(596, 94);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(39, 13);
            this.lblPlaca.TabIndex = 320;
            this.lblPlaca.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.Beige;
            this.txtPlaca.Location = new System.Drawing.Point(636, 91);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(115, 20);
            this.txtPlaca.TabIndex = 319;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(365, 83);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 13);
            this.lblModelo.TabIndex = 318;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(419, 79);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(168, 20);
            this.txtModelo.TabIndex = 317;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(793, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(22, 23);
            this.button4.TabIndex = 328;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pictureBox1.Location = new System.Drawing.Point(145, 129);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(695, 4);
            this.pictureBox1.TabIndex = 329;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.Azure;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(599, 435);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 25);
            this.button5.TabIndex = 330;
            this.button5.Text = "Imprimir";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // frmMovimentoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(867, 471);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtCombustivel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblCombustivel);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.btnPesquisaCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCPFCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dtgOrcamento);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpValidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtPrecoMercadoria);
            this.Controls.Add(this.txtQuantidadeMercadoria);
            this.Controls.Add(this.cmbMercadoria);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecoTipoServico);
            this.Controls.Add(this.txtQuantidadeTipoServico);
            this.Controls.Add(this.lblQdeEstoque);
            this.Controls.Add(this.cmbTipoServico);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picimg_cliente);
            this.Controls.Add(this.lblfuncionários);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMovimentoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMovimentoCompra";
            this.Load += new System.EventHandler(this.FrmMovimentoCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picimg_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrcamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.PictureBox picimg_cliente;
        private System.Windows.Forms.Label lblfuncionários;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbTipoServico;
        private System.Windows.Forms.TextBox txtQuantidadeTipoServico;
        private System.Windows.Forms.Label lblQdeEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecoTipoServico;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPrecoMercadoria;
        private System.Windows.Forms.TextBox txtQuantidadeMercadoria;
        private System.Windows.Forms.ComboBox cmbMercadoria;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.DataGridView dtgOrcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCPFCliente;
        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.TextBox txtCombustivel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
    }
}