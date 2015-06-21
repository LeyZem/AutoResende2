namespace AutoResende.View
{
    partial class frmCadastroTipoServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroTipoServico));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.btnFechar.Location = new System.Drawing.Point(1402, 18);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(39, 37);
            this.btnFechar.TabIndex = 36;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFechar_MouseClick);
            // 
            // btnBusca
            // 
            this.btnBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBusca.BackColor = System.Drawing.Color.Orange;
            this.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBusca.Location = new System.Drawing.Point(176, 670);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(2);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(115, 37);
            this.btnBusca.TabIndex = 282;
            this.btnBusca.Text = "Busca";
            this.btnBusca.UseVisualStyleBackColor = false;
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackColor = System.Drawing.Color.Salmon;
            this.btnLimpa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpa.Location = new System.Drawing.Point(331, 670);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(115, 37);
            this.btnLimpa.TabIndex = 281;
            this.btnLimpa.Text = "Limpa";
            this.btnLimpa.UseVisualStyleBackColor = false;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sair.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Sair.Location = new System.Drawing.Point(483, 670);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(115, 37);
            this.btn_Sair.TabIndex = 280;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            // 
            // frmCadastroTipoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1460, 795);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadastroTipoServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroServico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btn_Sair;
    }
}