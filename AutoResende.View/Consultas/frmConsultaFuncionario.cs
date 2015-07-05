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
    public partial class frmConsultaFuncionario : Form
    {
        public frmConsultaFuncionario()
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

        private void frmConsultaFuncionario_Load(object sender, EventArgs e)
        {
 
        }

        private void btnPesquisaFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                string var = txtNomeFuncionario.Text;
                dtgFuncionarios.DataSource = CAutoResende.SelecionaFuncionario(txtNomeFuncionario.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Carregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
