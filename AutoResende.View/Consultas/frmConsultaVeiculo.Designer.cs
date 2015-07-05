namespace AutoResende.View
{
    partial class frmConsultaVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaVeiculo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.picimg_cliente = new System.Windows.Forms.PictureBox();
            this.lblfuncionários = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPesquisaVeiculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.cmbCombustivel = new System.Windows.Forms.ComboBox();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.dtgVeiculos = new System.Windows.Forms.DataGridView();
            this.idVeiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odometroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._AutoResende_DataBaseDataSet_Veiculo = new AutoResende.View._AutoResende_DataBaseDataSet_Veiculo();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimg_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AutoResende_DataBaseDataSet_Veiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox1.Location = new System.Drawing.Point(139, 156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 6);
            this.pictureBox1.TabIndex = 197;
            this.pictureBox1.TabStop = false;
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
            this.btnFechar.Location = new System.Drawing.Point(827, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(26, 24);
            this.btnFechar.TabIndex = 192;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFechar_MouseClick_1);
            // 
            // picimg_cliente
            // 
            this.picimg_cliente.BackColor = System.Drawing.Color.Transparent;
            this.picimg_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picimg_cliente.Image = ((System.Drawing.Image)(resources.GetObject("picimg_cliente.Image")));
            this.picimg_cliente.Location = new System.Drawing.Point(25, 16);
            this.picimg_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.picimg_cliente.Name = "picimg_cliente";
            this.picimg_cliente.Size = new System.Drawing.Size(87, 85);
            this.picimg_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picimg_cliente.TabIndex = 194;
            this.picimg_cliente.TabStop = false;
            // 
            // lblfuncionários
            // 
            this.lblfuncionários.AutoSize = true;
            this.lblfuncionários.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblfuncionários.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfuncionários.ForeColor = System.Drawing.Color.White;
            this.lblfuncionários.Location = new System.Drawing.Point(141, 16);
            this.lblfuncionários.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfuncionários.Name = "lblfuncionários";
            this.lblfuncionários.Size = new System.Drawing.Size(194, 25);
            this.lblfuncionários.TabIndex = 193;
            this.lblfuncionários.Text = "Consultar Veículos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(866, 45);
            this.pictureBox2.TabIndex = 195;
            this.pictureBox2.TabStop = false;
            // 
            // btnPesquisaVeiculo
            // 
            this.btnPesquisaVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisaVeiculo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPesquisaVeiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisaVeiculo.BackgroundImage")));
            this.btnPesquisaVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisaVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisaVeiculo.Location = new System.Drawing.Point(751, 56);
            this.btnPesquisaVeiculo.Name = "btnPesquisaVeiculo";
            this.btnPesquisaVeiculo.Size = new System.Drawing.Size(59, 51);
            this.btnPesquisaVeiculo.TabIndex = 287;
            this.btnPesquisaVeiculo.UseVisualStyleBackColor = false;
            this.btnPesquisaVeiculo.Click += new System.EventHandler(this.btnPesquisaVeiculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 291;
            this.label1.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(214, 72);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(208, 20);
            this.txtMarca.TabIndex = 290;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(141, 106);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(39, 13);
            this.lblPlaca.TabIndex = 289;
            this.lblPlaca.Text = "Placa";
            // 
            // cmbCombustivel
            // 
            this.cmbCombustivel.FormattingEnabled = true;
            this.cmbCombustivel.Items.AddRange(new object[] {
            "Gasolina",
            "Etanol",
            "Flex",
            "Gás",
            "Diesel"});
            this.cmbCombustivel.Location = new System.Drawing.Point(515, 106);
            this.cmbCombustivel.Name = "cmbCombustivel";
            this.cmbCombustivel.Size = new System.Drawing.Size(114, 21);
            this.cmbCombustivel.TabIndex = 295;
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.BackColor = System.Drawing.Color.Transparent;
            this.lblCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustivel.Location = new System.Drawing.Point(418, 109);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(77, 13);
            this.lblCombustivel.TabIndex = 294;
            this.lblCombustivel.Text = "Combustível";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(447, 75);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 13);
            this.lblModelo.TabIndex = 293;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(515, 72);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(218, 20);
            this.txtModelo.TabIndex = 292;
            // 
            // dtgVeiculos
            // 
            this.dtgVeiculos.AllowUserToAddRows = false;
            this.dtgVeiculos.AllowUserToDeleteRows = false;
            this.dtgVeiculos.AutoGenerateColumns = false;
            this.dtgVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVeiculoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.combustivelDataGridViewTextBoxColumn,
            this.odometroDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dtgVeiculos.DataSource = this.veiculoBindingSource;
            this.dtgVeiculos.Location = new System.Drawing.Point(139, 205);
            this.dtgVeiculos.Name = "dtgVeiculos";
            this.dtgVeiculos.ReadOnly = true;
            this.dtgVeiculos.Size = new System.Drawing.Size(685, 268);
            this.dtgVeiculos.TabIndex = 296;
            // 
            // idVeiculoDataGridViewTextBoxColumn
            // 
            this.idVeiculoDataGridViewTextBoxColumn.DataPropertyName = "idVeiculo";
            this.idVeiculoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idVeiculoDataGridViewTextBoxColumn.Name = "idVeiculoDataGridViewTextBoxColumn";
            this.idVeiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "Cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "Cor";
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            this.corDataGridViewTextBoxColumn.ReadOnly = true;
            this.corDataGridViewTextBoxColumn.Width = 70;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            this.placaDataGridViewTextBoxColumn.Width = 50;
            // 
            // combustivelDataGridViewTextBoxColumn
            // 
            this.combustivelDataGridViewTextBoxColumn.DataPropertyName = "Combustivel";
            this.combustivelDataGridViewTextBoxColumn.HeaderText = "Combustível";
            this.combustivelDataGridViewTextBoxColumn.Name = "combustivelDataGridViewTextBoxColumn";
            this.combustivelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odometroDataGridViewTextBoxColumn
            // 
            this.odometroDataGridViewTextBoxColumn.DataPropertyName = "Odometro";
            this.odometroDataGridViewTextBoxColumn.HeaderText = "Odômetro";
            this.odometroDataGridViewTextBoxColumn.Name = "odometroDataGridViewTextBoxColumn";
            this.odometroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 300;
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "Veiculo";
            this.veiculoBindingSource.DataSource = this._AutoResende_DataBaseDataSet_Veiculo;
            // 
            // _AutoResende_DataBaseDataSet_Veiculo
            // 
            this._AutoResende_DataBaseDataSet_Veiculo.DataSetName = "_AutoResende_DataBaseDataSet_Veiculo";
            this._AutoResende_DataBaseDataSet_Veiculo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(214, 103);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(114, 20);
            this.txtPlaca.TabIndex = 288;
            // 
            // frmConsultaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(867, 507);
            this.Controls.Add(this.dtgVeiculos);
            this.Controls.Add(this.cmbCombustivel);
            this.Controls.Add(this.lblCombustivel);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.btnPesquisaVeiculo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.picimg_cliente);
            this.Controls.Add(this.lblfuncionários);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaVeiculo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picimg_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AutoResende_DataBaseDataSet_Veiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox picimg_cliente;
        private System.Windows.Forms.Label lblfuncionários;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPesquisaVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.ComboBox cmbCombustivel;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.DataGridView dtgVeiculos;
        private _AutoResende_DataBaseDataSet_Veiculo _AutoResende_DataBaseDataSet_Veiculo;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVeiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odometroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPlaca;
    }
}