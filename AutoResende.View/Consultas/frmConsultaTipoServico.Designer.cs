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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaTipoServico));
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBusca
            // 
            this.btnBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBusca.BackColor = System.Drawing.Color.Orange;
            this.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBusca.Location = new System.Drawing.Point(176, 701);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(2);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(115, 37);
            this.btnBusca.TabIndex = 279;
            this.btnBusca.Text = "Busca";
            this.btnBusca.UseVisualStyleBackColor = false;
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackColor = System.Drawing.Color.Salmon;
            this.btnLimpa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpa.Location = new System.Drawing.Point(331, 701);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(115, 37);
            this.btnLimpa.TabIndex = 278;
            this.btnLimpa.Text = "Limpa";
            this.btnLimpa.UseVisualStyleBackColor = false;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sair.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Sair.Location = new System.Drawing.Point(483, 701);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(115, 37);
            this.btn_Sair.TabIndex = 277;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            // 
            // frmConsultaTipoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1300, 780);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btn_Sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultaTipoServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaTipoServico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btn_Sair;
    }
}