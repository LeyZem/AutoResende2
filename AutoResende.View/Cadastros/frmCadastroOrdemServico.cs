using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoResende.Model;
using AutoResende.Controller;

namespace AutoResende.View
{
    public partial class frmCadastroOrdemServico : Form
    {
        public frmCadastroOrdemServico()
        {
            InitializeComponent();
        }

        private void btnFechar_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblNomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarVeiculo_Click(object sender, EventArgs e)
        {
            string strPlaca = txtPlaca.Text;
            Veiculo oVeiculo = new Veiculo();

            try
            {
                oVeiculo = CAutoResende.Seleciona(strPlaca);

                txtMarca.Text = oVeiculo.Marca;
                txtModelo.Text = oVeiculo.Modelo;
                txtCor.Text = oVeiculo.Cor;
                txtCombustivel.Text = oVeiculo.Combustivel;
            }

            catch (Exception)
            {
                MessageBox.Show("Veículo não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
