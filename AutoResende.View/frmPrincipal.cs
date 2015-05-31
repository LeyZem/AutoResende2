using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoResende.View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptbCadastroTipoServico_Click(object sender, EventArgs e)
        {
            
        }

        private void ptbCadastroTipoServico_MouseClick(object sender, MouseEventArgs e)
        {
            frmCadastroTipoServico frm = new frmCadastroTipoServico();
            frm.Show();
        }

        private void ptbConsultaServicos_Click(object sender, EventArgs e)
        {

        }

        private void ptbCadastroFuncionario_Click(object sender, EventArgs e)
        {
            
        }

        private void ptbCadastroFuncionario_MouseClick(object sender, MouseEventArgs e)
        {
            frmCadastroFuncionario frm = new frmCadastroFuncionario();
            frm.Show();
        }

        private void ptbCadastroMercadoria_Click(object sender, EventArgs e)
        {
            
        }

        private void ptbCadastroMercadoria_MouseClick(object sender, MouseEventArgs e)
        {
            frmCadastroMercadoria frm = new frmCadastroMercadoria();
            frm.Show();
        }

        private void ptbOrdemServico_Click(object sender, EventArgs e)
        {
            
        }

        private void ptbOrdemServico_MouseClick(object sender, MouseEventArgs e)
        {
            frmCadastroOrdemServico frm = new frmCadastroOrdemServico();
            frm.Show();
        }

        private void ptbCadastroVeiculo_Click(object sender, EventArgs e)
        {
            
        }

        private void ptbCadastroVeiculo_MouseClick(object sender, MouseEventArgs e)
        {
            frmCadastroVeiculo frm = new frmCadastroVeiculo();
            frm.Show();
        }

        private void ptbCadastroCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void ptbCadastroCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmCadastroCliente frm = new frmCadastroCliente();
            frm.Show();
        }

        private void ptbCadastroFornecedor_Click(object sender, EventArgs e)
        {
            
        }

        private void ptbCadastroFornecedor_MouseClick(object sender, MouseEventArgs e)
        {
            frmCadastroFornecedor frm = new frmCadastroFornecedor();
            frm.Show();
        }
    }
}
