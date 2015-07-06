namespace AutoResende.View
{
    partial class frmConsultaTipoServico
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaTipoServico));
            this.button1 = new System.Windows.Forms.Button();
            this.picimg_cliente = new System.Windows.Forms.PictureBox();
            this.lblTipoServico = new System.Windows.Forms.Label();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.txtNomeServico = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPesquisaTipoServico = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dtgTipoServico = new System.Windows.Forms.DataGridView();
            this.tipoServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._AutoResende_DataBaseDataSet_TipoServico = new AutoResende.View._AutoResende_DataBaseDataSet_TipoServico();
            this.tipoServicoTableAdapter = new AutoResende.View._AutoResende_DataBaseDataSet_TipoServicoTableAdapters.TipoServicoTableAdapter();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.idTipoServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeServiçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picimg_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AutoResende_DataBaseDataSet_TipoServico)).BeginInit();
            this.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(826, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 24);
            this.button1.TabIndex = 280;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
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
            this.picimg_cliente.TabIndex = 284;
            this.picimg_cliente.TabStop = false;
            // 
            // lblTipoServico
            // 
            this.lblTipoServico.AutoSize = true;
            this.lblTipoServico.BackColor = System.Drawing.Color.Plum;
            this.lblTipoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServico.ForeColor = System.Drawing.Color.White;
            this.lblTipoServico.Location = new System.Drawing.Point(139, 12);
            this.lblTipoServico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoServico.Name = "lblTipoServico";
            this.lblTipoServico.Size = new System.Drawing.Size(263, 25);
            this.lblTipoServico.TabIndex = 282;
            this.lblTipoServico.Text = "Consultar Tipo de Serviço";
            // 
            // lblCódigo
            // 
            this.lblCódigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.Location = new System.Drawing.Point(134, 75);
            this.lblCódigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(104, 13);
            this.lblCódigo.TabIndex = 281;
            this.lblCódigo.Text = "Nome do Serviço";
            // 
            // txtNomeServico
            // 
            this.txtNomeServico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeServico.Location = new System.Drawing.Point(256, 72);
            this.txtNomeServico.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeServico.Name = "txtNomeServico";
            this.txtNomeServico.Size = new System.Drawing.Size(412, 20);
            this.txtNomeServico.TabIndex = 283;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Plum;
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(866, 45);
            this.pictureBox2.TabIndex = 285;
            this.pictureBox2.TabStop = false;
            // 
            // btnPesquisaTipoServico
            // 
            this.btnPesquisaTipoServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisaTipoServico.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPesquisaTipoServico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisaTipoServico.BackgroundImage")));
            this.btnPesquisaTipoServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisaTipoServico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisaTipoServico.Location = new System.Drawing.Point(734, 56);
            this.btnPesquisaTipoServico.Name = "btnPesquisaTipoServico";
            this.btnPesquisaTipoServico.Size = new System.Drawing.Size(59, 51);
            this.btnPesquisaTipoServico.TabIndex = 286;
            this.btnPesquisaTipoServico.UseVisualStyleBackColor = false;
            this.btnPesquisaTipoServico.Click += new System.EventHandler(this.btnPesquisaTipoServico_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Plum;
            this.pictureBox3.Location = new System.Drawing.Point(137, 124);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(681, 6);
            this.pictureBox3.TabIndex = 287;
            this.pictureBox3.TabStop = false;
            // 
            // dtgTipoServico
            // 
            this.dtgTipoServico.AllowUserToAddRows = false;
            this.dtgTipoServico.AllowUserToDeleteRows = false;
            this.dtgTipoServico.AutoGenerateColumns = false;
            this.dtgTipoServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipoServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoServicoDataGridViewTextBoxColumn,
            this.nomeServiçoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.Preco});
            this.dtgTipoServico.DataSource = this.tipoServicoBindingSource;
            this.dtgTipoServico.Location = new System.Drawing.Point(137, 169);
            this.dtgTipoServico.Name = "dtgTipoServico";
            this.dtgTipoServico.ReadOnly = true;
            this.dtgTipoServico.Size = new System.Drawing.Size(681, 304);
            this.dtgTipoServico.TabIndex = 288;
            this.dtgTipoServico.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgTipoServico_CellMouseDoubleClick);
            // 
            // tipoServicoBindingSource
            // 
            this.tipoServicoBindingSource.DataMember = "TipoServico";
            this.tipoServicoBindingSource.DataSource = this._AutoResende_DataBaseDataSet_TipoServico;
            // 
            // _AutoResende_DataBaseDataSet_TipoServico
            // 
            this._AutoResende_DataBaseDataSet_TipoServico.DataSetName = "_AutoResende_DataBaseDataSet_TipoServico";
            this._AutoResende_DataBaseDataSet_TipoServico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoServicoTableAdapter
            // 
            this.tipoServicoTableAdapter.ClearBeforeFill = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Salmon;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Location = new System.Drawing.Point(741, 478);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(77, 24);
            this.btnDeletar.TabIndex = 302;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // idTipoServicoDataGridViewTextBoxColumn
            // 
            this.idTipoServicoDataGridViewTextBoxColumn.DataPropertyName = "idTipoServico";
            this.idTipoServicoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idTipoServicoDataGridViewTextBoxColumn.Name = "idTipoServicoDataGridViewTextBoxColumn";
            this.idTipoServicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeServiçoDataGridViewTextBoxColumn
            // 
            this.nomeServiçoDataGridViewTextBoxColumn.DataPropertyName = "NomeServiço";
            this.nomeServiçoDataGridViewTextBoxColumn.HeaderText = "Nome do Serviço";
            this.nomeServiçoDataGridViewTextBoxColumn.Name = "nomeServiçoDataGridViewTextBoxColumn";
            this.nomeServiçoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeServiçoDataGridViewTextBoxColumn.Width = 300;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 500;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "idTipoServico";
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // frmConsultaTipoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(867, 507);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.dtgTipoServico);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnPesquisaTipoServico);
            this.Controls.Add(this.picimg_cliente);
            this.Controls.Add(this.lblTipoServico);
            this.Controls.Add(this.lblCódigo);
            this.Controls.Add(this.txtNomeServico);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaTipoServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaTipoServico";
            this.Load += new System.EventHandler(this.frmConsultaTipoServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picimg_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AutoResende_DataBaseDataSet_TipoServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picimg_cliente;
        private System.Windows.Forms.Label lblTipoServico;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.TextBox txtNomeServico;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPesquisaTipoServico;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dtgTipoServico;
        private _AutoResende_DataBaseDataSet_TipoServico _AutoResende_DataBaseDataSet_TipoServico;
        private System.Windows.Forms.BindingSource tipoServicoBindingSource;
        private _AutoResende_DataBaseDataSet_TipoServicoTableAdapters.TipoServicoTableAdapter tipoServicoTableAdapter;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeServiçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
    }
}