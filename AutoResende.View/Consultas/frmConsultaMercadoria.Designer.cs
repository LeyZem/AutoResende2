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
            this.lblValorCusto = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this._AutoResende_DataBaseDataSet_Mercadoria = new AutoResende.View._AutoResende_DataBaseDataSet_Mercadoria();
            this.dtgMercadorias = new System.Windows.Forms.DataGridView();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimg_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AutoResende_DataBaseDataSet_Mercadoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMercadorias)).BeginInit();
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
            this.btnPesquisaCliente.Click += new System.EventHandler(this.btnPesquisaCliente_Click);
            // 
            // _AutoResende_DataBaseDataSet_Mercadoria
            // 
            this._AutoResende_DataBaseDataSet_Mercadoria.DataSetName = "_AutoResende_DataBaseDataSet_Mercadoria";
            this._AutoResende_DataBaseDataSet_Mercadoria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtgMercadorias
            // 
            this.dtgMercadorias.AllowUserToAddRows = false;
            this.dtgMercadorias.AllowUserToDeleteRows = false;
            this.dtgMercadorias.AllowUserToOrderColumns = true;
            this.dtgMercadorias.AllowUserToResizeColumns = false;
            this.dtgMercadorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgMercadorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMercadorias.Location = new System.Drawing.Point(141, 169);
            this.dtgMercadorias.Name = "dtgMercadorias";
            this.dtgMercadorias.ReadOnly = true;
            this.dtgMercadorias.Size = new System.Drawing.Size(713, 276);
            this.dtgMercadorias.TabIndex = 279;
            this.dtgMercadorias.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgMercadorias_CellMouseDoubleClick);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Salmon;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Location = new System.Drawing.Point(777, 472);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(77, 24);
            this.btnDeletar.TabIndex = 302;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(141, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 51);
            this.button1.TabIndex = 303;
            this.button1.Text = "Listar Todas as Mercadorias";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmConsultaMercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(867, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.dtgMercadorias);
            this.Controls.Add(this.btnPesquisaCliente);
            this.Controls.Add(this.lblValorCusto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picimg_cliente);
            this.Controls.Add(this.lblConsultaMercadoria);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaMercadoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaMercadoria";
            this.Load += new System.EventHandler(this.frmConsultaMercadoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimg_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AutoResende_DataBaseDataSet_Mercadoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMercadorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picimg_cliente;
        private System.Windows.Forms.Label lblConsultaMercadoria;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblValorCusto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnPesquisaCliente;
        private _AutoResende_DataBaseDataSet_Mercadoria _AutoResende_DataBaseDataSet_Mercadoria;
        private System.Windows.Forms.DataGridView dtgMercadorias;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button button1;
    }
}