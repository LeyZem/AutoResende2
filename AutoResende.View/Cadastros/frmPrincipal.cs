using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoResende.View.Cadastros;
using AutoResende.Controller;
using AutoResende.Model;

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
            OrdemServico OS = new OrdemServico();
            frmCadastroOrdemServico frm = new frmCadastroOrdemServico (OS);
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

        private void ptpConsultaFuncionario_MouseClick(object sender, MouseEventArgs e)
        {
            frmConsultaFuncionario frm = new frmConsultaFuncionario();
            frm.Show();
        }

        private void ptpConsultaMercadoria_MouseClick(object sender, MouseEventArgs e)
        {
            frmConsultaMercadoria frm = new frmConsultaMercadoria();
            frm.Show();
        }

        private void ptpConsultaOrdemServico_MouseClick(object sender, MouseEventArgs e)
        {
            frmConsultaOrdemServico frm = new frmConsultaOrdemServico();
            frm.Show();
        }

        private void ptpConsultaVeiculo_MouseClick(object sender, MouseEventArgs e)
        {
            frmConsultaVeiculo frm = new frmConsultaVeiculo();
            frm.Show();
        }

        private void ptpConsultaTipoServico_MouseClick(object sender, MouseEventArgs e)
        {
            frmConsultaTipoServico frm = new frmConsultaTipoServico();
            frm.Show();
        }

        private void ptpConsultaCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmConsultaCliente frm = new frmConsultaCliente();
            frm.Show();
        }

        private void ptpConsultaFornecedor_MouseClick(object sender, MouseEventArgs e)
        {
            frmConsultaFornecedor frm = new frmConsultaFornecedor();
            frm.Show();
        }

        private void ptbCompra_MouseClick(object sender, MouseEventArgs e)
        {
            frmMovimentoCompra frm = new frmMovimentoCompra();
            frm.Show();
        }

        private void ptbVenda_MouseClick(object sender, MouseEventArgs e)
        {
            FrmMovimentoVenda frm = new FrmMovimentoVenda();
            frm.Show();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
