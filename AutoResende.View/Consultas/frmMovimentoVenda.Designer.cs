namespace AutoResende.View.Cadastros
{
    partial class FrmMovimentoVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovimentoVenda));
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxTabela = new System.Windows.Forms.ComboBox();
            this.lblTabela = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSeqGeral = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbxOperação = new System.Windows.Forms.ComboBox();
            this.pbCliente = new System.Windows.Forms.ProgressBar();
            this.lblOperação = new System.Windows.Forms.Label();
            this.txtSeqGeral = new System.Windows.Forms.TextBox();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReceber = new System.Windows.Forms.Button();
            this.lblObservação = new System.Windows.Forms.Label();
            this.txtObservação = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblIPI = new System.Windows.Forms.Label();
            this.txtIPI = new System.Windows.Forms.TextBox();
            this.lblDescReal = new System.Windows.Forms.Label();
            this.txtDescReal = new System.Windows.Forms.TextBox();
            this.lblPreçoUnit = new System.Windows.Forms.Label();
            this.lblDescPorc = new System.Windows.Forms.Label();
            this.txtDescPorc = new System.Windows.Forms.TextBox();
            this.lblPreçoFinal = new System.Windows.Forms.Label();
            this.TxtPreçoFinal = new System.Windows.Forms.TextBox();
            this.lblPreçoTotal = new System.Windows.Forms.Label();
            this.txtPreçoTotal = new System.Windows.Forms.TextBox();
            this.txtPreço = new System.Windows.Forms.TextBox();
            this.lblqde = new System.Windows.Forms.Label();
            this.txtqtde = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Desc ($)";
            this.Column6.Name = "Column6";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(559, 676);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(172, 38);
            this.btnLimpar.TabIndex = 302;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // lblVendedor
            // 
            this.lblVendedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.BackColor = System.Drawing.Color.Transparent;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(889, 56);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(87, 20);
            this.lblVendedor.TabIndex = 301;
            this.lblVendedor.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVendedor.Location = new System.Drawing.Point(982, 53);
            this.txtVendedor.MaxLength = 40;
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(156, 26);
            this.txtVendedor.TabIndex = 300;
            // 
            // cbxModelo
            // 
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Items.AddRange(new object[] {
            "1",
            "1A",
            "1B",
            "04",
            "55"});
            this.cbxModelo.Location = new System.Drawing.Point(114, 49);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(148, 28);
            this.cbxModelo.TabIndex = 297;
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(15, 52);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(96, 20);
            this.lblModelo.TabIndex = 296;
            this.lblModelo.Text = "Mod. Nota:";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Preço Unit";
            this.Column4.Name = "Column4";
            // 
            // cbxTabela
            // 
            this.cbxTabela.FormattingEnabled = true;
            this.cbxTabela.Items.AddRange(new object[] {
            "Custo",
            "Venda",
            "Custo Médio"});
            this.cbxTabela.Location = new System.Drawing.Point(605, 50);
            this.cbxTabela.Name = "cbxTabela";
            this.cbxTabela.Size = new System.Drawing.Size(155, 28);
            this.cbxTabela.TabIndex = 289;
            // 
            // lblTabela
            // 
            this.lblTabela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTabela.AutoSize = true;
            this.lblTabela.BackColor = System.Drawing.Color.Transparent;
            this.lblTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabela.Location = new System.Drawing.Point(519, 53);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(68, 20);
            this.lblTabela.TabIndex = 288;
            this.lblTabela.Text = "Tabela:";
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(968, 19);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(48, 20);
            this.lblData.TabIndex = 286;
            this.lblData.Text = "Data";
            // 
            // lblSeqGeral
            // 
            this.lblSeqGeral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeqGeral.AutoSize = true;
            this.lblSeqGeral.BackColor = System.Drawing.Color.Transparent;
            this.lblSeqGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeqGeral.Location = new System.Drawing.Point(766, 19);
            this.lblSeqGeral.Name = "lblSeqGeral";
            this.lblSeqGeral.Size = new System.Drawing.Size(95, 20);
            this.lblSeqGeral.TabIndex = 283;
            this.lblSeqGeral.Text = "Seq. Geral";
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(284, 19);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(70, 20);
            this.lblCliente.TabIndex = 282;
            this.lblCliente.Text = "Cliente:";
            // 
            // cbxOperação
            // 
            this.cbxOperação.FormattingEnabled = true;
            this.cbxOperação.Items.AddRange(new object[] {
            "Ajuste de Saída",
            "Devolução Fornecedor",
            "Grátis Saída",
            "Pré Venda"});
            this.cbxOperação.Location = new System.Drawing.Point(114, 15);
            this.cbxOperação.Name = "cbxOperação";
            this.cbxOperação.Size = new System.Drawing.Size(148, 28);
            this.cbxOperação.TabIndex = 281;
            // 
            // pbCliente
            // 
            this.pbCliente.Location = new System.Drawing.Point(360, 15);
            this.pbCliente.Name = "pbCliente";
            this.pbCliente.Size = new System.Drawing.Size(400, 29);
            this.pbCliente.TabIndex = 280;
            // 
            // lblOperação
            // 
            this.lblOperação.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOperação.AutoSize = true;
            this.lblOperação.BackColor = System.Drawing.Color.Transparent;
            this.lblOperação.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperação.Location = new System.Drawing.Point(16, 19);
            this.lblOperação.Name = "lblOperação";
            this.lblOperação.Size = new System.Drawing.Size(92, 20);
            this.lblOperação.TabIndex = 279;
            this.lblOperação.Text = "Operação:";
            // 
            // txtSeqGeral
            // 
            this.txtSeqGeral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSeqGeral.Location = new System.Drawing.Point(867, 16);
            this.txtSeqGeral.MaxLength = 40;
            this.txtSeqGeral.Name = "txtSeqGeral";
            this.txtSeqGeral.Size = new System.Drawing.Size(95, 26);
            this.txtSeqGeral.TabIndex = 278;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Preço IPI";
            this.Column5.Name = "Column5";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(1022, 16);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 26);
            this.dtpData.TabIndex = 287;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(379, 676);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(172, 38);
            this.btnBuscar.TabIndex = 274;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Preço Final";
            this.Column8.Name = "Column8";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qtde";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Preço Total";
            this.Column7.Name = "Column7";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.Width = 450;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1273, 410);
            this.dataGridView1.TabIndex = 277;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Width = 200;
            // 
            // btnReceber
            // 
            this.btnReceber.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReceber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceber.Location = new System.Drawing.Point(199, 674);
            this.btnReceber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(172, 38);
            this.btnReceber.TabIndex = 273;
            this.btnReceber.Text = "Receber";
            this.btnReceber.UseVisualStyleBackColor = false;
            // 
            // lblObservação
            // 
            this.lblObservação.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObservação.AutoSize = true;
            this.lblObservação.BackColor = System.Drawing.Color.Transparent;
            this.lblObservação.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservação.Location = new System.Drawing.Point(14, 88);
            this.lblObservação.Name = "lblObservação";
            this.lblObservação.Size = new System.Drawing.Size(118, 20);
            this.lblObservação.TabIndex = 272;
            this.lblObservação.Text = "Observações:";
            // 
            // txtObservação
            // 
            this.txtObservação.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservação.Location = new System.Drawing.Point(138, 85);
            this.txtObservação.MaxLength = 40;
            this.txtObservação.Name = "txtObservação";
            this.txtObservação.Size = new System.Drawing.Size(917, 26);
            this.txtObservação.TabIndex = 271;
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGravar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGravar.Location = new System.Drawing.Point(20, 674);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(172, 38);
            this.btnGravar.TabIndex = 269;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // lblIPI
            // 
            this.lblIPI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIPI.AutoSize = true;
            this.lblIPI.BackColor = System.Drawing.Color.Transparent;
            this.lblIPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPI.Location = new System.Drawing.Point(843, 164);
            this.lblIPI.Name = "lblIPI";
            this.lblIPI.Size = new System.Drawing.Size(64, 20);
            this.lblIPI.TabIndex = 267;
            this.lblIPI.Text = "IPI (%)";
            // 
            // txtIPI
            // 
            this.txtIPI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIPI.Location = new System.Drawing.Point(847, 187);
            this.txtIPI.MaxLength = 40;
            this.txtIPI.Name = "txtIPI";
            this.txtIPI.Size = new System.Drawing.Size(113, 26);
            this.txtIPI.TabIndex = 266;
            // 
            // lblDescReal
            // 
            this.lblDescReal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescReal.AutoSize = true;
            this.lblDescReal.BackColor = System.Drawing.Color.Transparent;
            this.lblDescReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescReal.Location = new System.Drawing.Point(739, 164);
            this.lblDescReal.Name = "lblDescReal";
            this.lblDescReal.Size = new System.Drawing.Size(77, 20);
            this.lblDescReal.TabIndex = 265;
            this.lblDescReal.Text = "Desc ($)";
            // 
            // txtDescReal
            // 
            this.txtDescReal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescReal.Location = new System.Drawing.Point(743, 187);
            this.txtDescReal.MaxLength = 40;
            this.txtDescReal.Name = "txtDescReal";
            this.txtDescReal.Size = new System.Drawing.Size(98, 26);
            this.txtDescReal.TabIndex = 264;
            // 
            // lblPreçoUnit
            // 
            this.lblPreçoUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPreçoUnit.AutoSize = true;
            this.lblPreçoUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblPreçoUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreçoUnit.Location = new System.Drawing.Point(276, 164);
            this.lblPreçoUnit.Name = "lblPreçoUnit";
            this.lblPreçoUnit.Size = new System.Drawing.Size(123, 20);
            this.lblPreçoUnit.TabIndex = 263;
            this.lblPreçoUnit.Text = "Preço Unitário";
            // 
            // lblDescPorc
            // 
            this.lblDescPorc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescPorc.AutoSize = true;
            this.lblDescPorc.BackColor = System.Drawing.Color.Transparent;
            this.lblDescPorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescPorc.Location = new System.Drawing.Point(635, 164);
            this.lblDescPorc.Name = "lblDescPorc";
            this.lblDescPorc.Size = new System.Drawing.Size(82, 20);
            this.lblDescPorc.TabIndex = 261;
            this.lblDescPorc.Text = "Desc (%)";
            // 
            // txtDescPorc
            // 
            this.txtDescPorc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescPorc.Location = new System.Drawing.Point(639, 187);
            this.txtDescPorc.MaxLength = 40;
            this.txtDescPorc.Name = "txtDescPorc";
            this.txtDescPorc.Size = new System.Drawing.Size(98, 26);
            this.txtDescPorc.TabIndex = 260;
            // 
            // lblPreçoFinal
            // 
            this.lblPreçoFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPreçoFinal.AutoSize = true;
            this.lblPreçoFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblPreçoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreçoFinal.Location = new System.Drawing.Point(962, 165);
            this.lblPreçoFinal.Name = "lblPreçoFinal";
            this.lblPreçoFinal.Size = new System.Drawing.Size(99, 20);
            this.lblPreçoFinal.TabIndex = 259;
            this.lblPreçoFinal.Text = "Preço Final";
            // 
            // TxtPreçoFinal
            // 
            this.TxtPreçoFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPreçoFinal.Location = new System.Drawing.Point(966, 188);
            this.TxtPreçoFinal.MaxLength = 40;
            this.TxtPreçoFinal.Name = "TxtPreçoFinal";
            this.TxtPreçoFinal.Size = new System.Drawing.Size(193, 26);
            this.TxtPreçoFinal.TabIndex = 258;
            // 
            // lblPreçoTotal
            // 
            this.lblPreçoTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPreçoTotal.AutoSize = true;
            this.lblPreçoTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPreçoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreçoTotal.Location = new System.Drawing.Point(447, 164);
            this.lblPreçoTotal.Name = "lblPreçoTotal";
            this.lblPreçoTotal.Size = new System.Drawing.Size(100, 20);
            this.lblPreçoTotal.TabIndex = 257;
            this.lblPreçoTotal.Text = "Preço Total";
            // 
            // txtPreçoTotal
            // 
            this.txtPreçoTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPreçoTotal.Location = new System.Drawing.Point(447, 187);
            this.txtPreçoTotal.MaxLength = 40;
            this.txtPreçoTotal.Name = "txtPreçoTotal";
            this.txtPreçoTotal.Size = new System.Drawing.Size(186, 26);
            this.txtPreçoTotal.TabIndex = 256;
            // 
            // txtPreço
            // 
            this.txtPreço.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPreço.Location = new System.Drawing.Point(280, 188);
            this.txtPreço.MaxLength = 40;
            this.txtPreço.Name = "txtPreço";
            this.txtPreço.Size = new System.Drawing.Size(161, 26);
            this.txtPreço.TabIndex = 254;
            // 
            // lblqde
            // 
            this.lblqde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblqde.AutoSize = true;
            this.lblqde.BackColor = System.Drawing.Color.Transparent;
            this.lblqde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqde.Location = new System.Drawing.Point(204, 164);
            this.lblqde.Name = "lblqde";
            this.lblqde.Size = new System.Drawing.Size(48, 20);
            this.lblqde.TabIndex = 249;
            this.lblqde.Text = "Qtde";
            // 
            // txtqtde
            // 
            this.txtqtde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtqtde.Location = new System.Drawing.Point(204, 187);
            this.txtqtde.MaxLength = 40;
            this.txtqtde.Name = "txtqtde";
            this.txtqtde.Size = new System.Drawing.Size(70, 26);
            this.txtqtde.TabIndex = 248;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(12, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1273, 10);
            this.pictureBox1.TabIndex = 247;
            this.pictureBox1.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(16, 164);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 20);
            this.lblCodigo.TabIndex = 246;
            this.lblCodigo.Text = "Código";
            // 
            // txtproduto
            // 
            this.txtproduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtproduto.Location = new System.Drawing.Point(12, 187);
            this.txtproduto.MaxLength = 40;
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(186, 26);
            this.txtproduto.TabIndex = 245;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1244, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 37);
            this.button1.TabIndex = 244;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmMovimentoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1300, 724);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.cbxModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.cbxTabela);
            this.Controls.Add(this.lblTabela);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSeqGeral);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbxOperação);
            this.Controls.Add(this.pbCliente);
            this.Controls.Add(this.lblOperação);
            this.Controls.Add(this.txtSeqGeral);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.lblObservação);
            this.Controls.Add(this.txtObservação);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblIPI);
            this.Controls.Add(this.txtIPI);
            this.Controls.Add(this.lblDescReal);
            this.Controls.Add(this.txtDescReal);
            this.Controls.Add(this.lblPreçoUnit);
            this.Controls.Add(this.lblDescPorc);
            this.Controls.Add(this.txtDescPorc);
            this.Controls.Add(this.lblPreçoFinal);
            this.Controls.Add(this.TxtPreçoFinal);
            this.Controls.Add(this.lblPreçoTotal);
            this.Controls.Add(this.txtPreçoTotal);
            this.Controls.Add(this.txtPreço);
            this.Controls.Add(this.lblqde);
            this.Controls.Add(this.txtqtde);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMovimentoVenda";
            this.Text = "FrmMovimentoVenda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.ComboBox cbxModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cbxTabela;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSeqGeral;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbxOperação;
        private System.Windows.Forms.ProgressBar pbCliente;
        private System.Windows.Forms.Label lblOperação;
        private System.Windows.Forms.TextBox txtSeqGeral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.Label lblObservação;
        private System.Windows.Forms.TextBox txtObservação;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label lblIPI;
        private System.Windows.Forms.TextBox txtIPI;
        private System.Windows.Forms.Label lblDescReal;
        private System.Windows.Forms.TextBox txtDescReal;
        private System.Windows.Forms.Label lblPreçoUnit;
        private System.Windows.Forms.Label lblDescPorc;
        private System.Windows.Forms.TextBox txtDescPorc;
        private System.Windows.Forms.Label lblPreçoFinal;
        private System.Windows.Forms.TextBox TxtPreçoFinal;
        private System.Windows.Forms.Label lblPreçoTotal;
        private System.Windows.Forms.TextBox txtPreçoTotal;
        private System.Windows.Forms.TextBox txtPreço;
        private System.Windows.Forms.Label lblqde;
        private System.Windows.Forms.TextBox txtqtde;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.Button button1;
    }
}