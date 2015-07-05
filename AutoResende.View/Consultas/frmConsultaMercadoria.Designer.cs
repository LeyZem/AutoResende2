namespace AutoResende.View
{
    partial class frmConsultaMercadoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaMercadoria));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picimg_cliente = new System.Windows.Forms.PictureBox();
            this.lblConsultaMercadoria = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idMercadoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblValorCusto = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimg_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Purple;
            this.pictureBox1.Location = new System.Drawing.Point(141, 127);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(713, 6);
            this.pictureBox1.TabIndex = 218;
            this.pictureBox1.TabStop = false;
            // 
            // picimg_cliente
            // 
            this.picimg_cliente.BackColor = System.Drawing.Color.Transparent;
            this.picimg_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picimg_cliente.Image = ((System.Drawing.Image)(resources.GetObject("picimg_cliente.Image")));
            this.picimg_cliente.Location = new System.Drawing.Point(26, 16);
            this.picimg_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.picimg_cliente.Name = "picimg_cliente";
            this.picimg_cliente.Size = new System.Drawing.Size(87, 85);
            this.picimg_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picimg_cliente.TabIndex = 215;
            this.picimg_cliente.TabStop = false;
            // 
            // lblConsultaMercadoria
            // 
            this.lblConsultaMercadoria.AutoSize = true;
            this.lblConsultaMercadoria.BackColor = System.Drawing.Color.Purple;
            this.lblConsultaMercadoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaMercadoria.ForeColor = System.Drawing.Color.White;
            this.lblConsultaMercadoria.Location = new System.Drawing.Point(142, 16);
            this.lblConsultaMercadoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsultaMercadoria.Name = "lblConsultaMercadoria";
            this.lblConsultaMercadoria.Size = new System.Drawing.Size(230, 25);
            this.lblConsultaMercadoria.TabIndex = 214;
            this.lblConsultaMercadoria.Text = "Consultar Mercadorias";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.Transparent;
            this.btnFechar.Location = new System.Drawing.Point(829, 11);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(26, 24);
            this.btnFechar.TabIndex = 213;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFechar_MouseClick_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Purple;
            this.pictureBox2.Location = new System.Drawing.Point(1, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(866, 45);
            this.pictureBox2.TabIndex = 216;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMercadoria,
            this.Descricao,
            this.ValorCusto,
            this.ValorVenda,
            this.Marca,
            this.Estoque});
            this.dataGridView1.Location = new System.Drawing.Point(141, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(713, 314);
            this.dataGridView1.TabIndex = 219;
            // 
            // idMercadoria
            // 
            this.idMercadoria.HeaderText = "Código";
            this.idMercadoria.Name = "idMercadoria";
            this.idMercadoria.ReadOnly = true;
            this.idMercadoria.Width = 70;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 200;
            // 
            // ValorCusto
            // 
            this.ValorCusto.HeaderText = "Preço de Custo";
            this.ValorCusto.Name = "ValorCusto";
            this.ValorCusto.ReadOnly = true;
            this.ValorCusto.Width = 70;
            // 
            // ValorVenda
            // 
            this.ValorVenda.HeaderText = "Preço de Venda";
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.ReadOnly = true;
            this.ValorVenda.Width = 70;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 200;
            // 
            // Estoque
            // 
            this.Estoque.HeaderText = "Qtd Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            this.Estoque.Width = 50;
            // 
            // lblValorCusto
            // 
            this.lblValorCusto.AutoSize = true;
            this.lblValorCusto.BackColor = System.Drawing.Color.Transparent;
            this.lblValorCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCusto.Location = new System.Drawing.Point(601, 84);
            this.lblValorCusto.Name = "lblValorCusto";
            this.lblValorCusto.Size = new System.Drawing.Size(46, 13);
            this.lblValorCusto.TabIndex = 225;
            this.lblValorCusto.Text = "Código";
            this.lblValorCusto.Click += new System.EventHandler(this.lblValorCusto_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(653, 81);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(114, 20);
            this.txtCodigo.TabIndex = 224;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtValorCusto_TextChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(366, 84);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(42, 13);
            this.lblMarca.TabIndex = 223;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(414, 81);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(181, 20);
            this.txtMarca.TabIndex = 222;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(140, 84);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(64, 13);
            this.lblDescricao.TabIndex = 221;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(210, 81);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(150, 20);
            this.txtDescricao.TabIndex = 220;
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisaCliente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPesquisaCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisaCliente.BackgroundImage")));
            this.btnPesquisaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisaCliente.Location = new System.Drawing.Point(798, 67);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(59, 51);
            this.btnPesquisaCliente.TabIndex = 278;
            this.btnPesquisaCliente.UseVisualStyleBackColor = false;
            // 
            // frmConsultaMercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(867, 507);
            this.Controls.Add(this.btnPesquisaCliente);
            this.Controls.Add(this.lblValorCusto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picimg_cliente);
            this.Controls.Add(this.lblConsultaMercadoria);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaMercadoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaMercadoria";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimg_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picimg_cliente;
        private System.Windows.Forms.Label lblConsultaMercadoria;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMercadoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.Label lblValorCusto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnPesquisaCliente;
    }
}