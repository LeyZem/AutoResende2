using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoResende.Controller;

namespace AutoResende.View
{
    public partial class frmConsultaTipoServico : Form
    {
        public frmConsultaTipoServico()
        {
            InitializeComponent();
        }

        private void btnFechar_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void btnPesquisaTipoServico_Click(object sender, EventArgs e)
        {
            try
            {
                string var = txtNomeServico.Text;
                dtgTipoServico.DataSource = CAutoResende.SelecionaTipoServico(txtNomeServico.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Carregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
