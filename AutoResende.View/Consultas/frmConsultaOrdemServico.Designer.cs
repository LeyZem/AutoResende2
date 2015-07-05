namespace AutoResende.View
{
    partial class frmConsultaOrdemServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaOrdemServico));
            this.picimg_cliente = new System.Windows.Forms.PictureBox();
            this.lblConsultaOrdemServico = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblOrdemServico = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnPesquisarOS = new System.Windows.Forms.Button();
            this.dtgOS = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.DataInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picimg_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOS)).BeginInit();
            this.SuspendLayout();
            // 
            // picimg_cliente
            // 
            this.picimg_cliente.BackColor = System.Drawing.Color.Transparent;
            this.picimg_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picimg_cliente.Image = ((System.Drawing.Image)(resources.GetObject("picimg_cliente.Image")));
            this.picimg_cliente.Location = new System.Drawing.Point(26, 15);
            this.picimg_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.picimg_cliente.Name = "picimg_cliente";
            this.picimg_cliente.Size = new System.Drawing.Size(87, 85);
            this.picimg_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picimg_cliente.TabIndex = 280;
            this.picimg_cliente.TabStop = false;
            // 
            // lblConsultaOrdemServico
            // 
            this.lblConsultaOrdemServico.AutoSize = true;
            this.lblConsultaOrdemServico.BackColor = System.Drawing.Color.Coral;
            this.lblConsultaOrdemServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaOrdemServico.ForeColor = System.Drawing.Color.White;
            this.lblConsultaOrdemServico.Location = new System.Drawing.Point(142, 15);
            this.lblConsultaOrdemServico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsultaOrdemServico.Name = "lblConsultaOrdemServico";
            this.lblConsultaOrdemServico.Size = new System.Drawing.Size(308, 25);
            this.lblConsultaOrdemServico.TabIndex = 278;
            this.lblConsultaOrdemServico.Text = "Consulta de Ordem de Serviço";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(829, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 24);
            this.button1.TabIndex = 277;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Coral;
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(866, 45);
            this.pictureBox2.TabIndex = 281;
            this.pictureBox2.TabStop = false;
            // 
            // lblOrdemServico
            // 
            this.lblOrdemServico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrdemServico.AutoSize = true;
            this.lblOrdemServico.BackColor = System.Drawing.Color.Transparent;
            this.lblOrdemServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdemServico.Location = new System.Drawing.Point(141, 87);
            this.lblOrdemServico.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOrdemServico.Name = "lblOrdemServico";
            this.lblOrdemServico.Size = new System.Drawing.Size(50, 13);
            this.lblOrdemServico.TabIndex = 284;
            this.lblOrdemServico.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.Location = new System.Drawing.Point(193, 84);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(1);
            this.txtNumero.MaxLength = 40;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(127, 20);
            this.txtNumero.TabIndex = 283;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 290;
            this.label1.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCPF.Location = new System.Drawing.Point(389, 84);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(1);
            this.txtCPF.MaxLength = 40;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(127, 20);
            this.txtCPF.TabIndex = 289;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 292;
            this.label2.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlaca.Location = new System.Drawing.Point(599, 84);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(1);
            this.txtPlaca.MaxLength = 40;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(127, 20);
            this.txtPlaca.TabIndex = 291;
            // 
            // btnPesquisarOS
            // 
            this.btnPesquisarOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarOS.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPesquisarOS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisarOS.BackgroundImage")));
            this.btnPesquisarOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisarOS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarOS.Location = new System.Drawing.Point(775, 68);
            this.btnPesquisarOS.Name = "btnPesquisarOS";
            this.btnPesquisarOS.Size = new System.Drawing.Size(57, 51);
            this.btnPesquisarOS.TabIndex = 293;
            this.btnPesquisarOS.UseVisualStyleBackColor = false;
            // 
            // dtgOS
            // 
            this.dtgOS.AllowUserToAddRows = false;
            this.dtgOS.AllowUserToDeleteRows = false;
            this.dtgOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataInicial,
            this.DataEntrega,
            this.Nome,
            this.CPF,
            this.Veiculo,
            this.Placa});
            this.dtgOS.Location = new System.Drawing.Point(23, 142);
            this.dtgOS.MultiSelect = false;
            this.dtgOS.Name = "dtgOS";
            this.dtgOS.ReadOnly = true;
            this.dtgOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgOS.Size = new System.Drawing.Size(821, 325);
            this.dtgOS.TabIndex = 298;
            this.dtgOS.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgServicosCadastrados_RowHeaderMouseDoubleClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Salmon;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(767, 474);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(77, 24);
            this.btnLimpar.TabIndex = 275;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // DataInicial
            // 
            this.DataInicial.HeaderText = "Data Inicial";
            this.DataInicial.Name = "DataInicial";
            this.DataInicial.ReadOnly = true;
            this.DataInicial.Width = 70;
            // 
            // DataEntrega
            // 
            this.DataEntrega.HeaderText = "Data Entr.";
            this.DataEntrega.Name = "DataEntrega";
            this.DataEntrega.ReadOnly = true;
            this.DataEntrega.Width = 70;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 300;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Veiculo
            // 
            this.Veiculo.HeaderText = "Veiculo";
            this.Veiculo.Name = "Veiculo";
            this.Veiculo.ReadOnly = true;
            this.Veiculo.Width = 200;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(23, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 13);
            this.label3.TabIndex = 299;
            this.label3.Text = "*clique duas vezes na nota para mais detalhes.";
            // 
            // frmConsultaOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(867, 507);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgOS);
            this.Controls.Add(this.btnPesquisarOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblOrdemServico);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.picimg_cliente);
            this.Controls.Add(this.lblConsultaOrdemServico);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLimpar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaOrdemServico";
            ((System.ComponentModel.ISupportInitialize)(this.picimg_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picimg_cliente;
        private System.Windows.Forms.Label lblConsultaOrdemServico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblOrdemServico;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnPesquisarOS;
        private System.Windows.Forms.DataGridView dtgOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Veiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
    }
}