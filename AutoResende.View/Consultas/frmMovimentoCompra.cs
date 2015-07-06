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

namespace AutoResende.View.Cadastros
{
    public partial class frmMovimentoCompra : Form
    {
        public frmMovimentoCompra()
        {
            InitializeComponent();
        }

        private void FrmMovimentoCompra_Load(object sender, EventArgs e)
        {
            List<TipoServico> oTipoServicos = CAutoResende.ListaTiposServico();

            for (int i = 0; i < oTipoServicos.Count; i++)
            {
                cmbTipoServico.Items.Add(oTipoServicos[i].NomeServiço);
            }

            List<Mercadoria> oMercadoria = CAutoResende.ListaMercadorias();

            for (int i = 0; i < oMercadoria.Count; i++)
            {
                cmbMercadoria.Items.Add(oMercadoria[i].Descricao);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void cmbTipoServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<TipoServico> oTipoServicos = CAutoResende.ListaTiposServico();


            int index = cmbTipoServico.SelectedIndex;

            for (int i = 0; i < oTipoServicos.Count; i++)
            {
                if (i == index)
                {
                    txtPrecoTipoServico.Text = Convert.ToString(oTipoServicos[i].Preco);
                    break;
                }
            }
        }

        private void cmbMercadoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Mercadoria> oMercadoria = CAutoResende.ListaMercadorias();


            int index = cmbMercadoria.SelectedIndex;

            for (int i = 0; i < oMercadoria.Count; i++)
            {
                if (i == index)
                {
                    txtPrecoMercadoria.Text = Convert.ToString(oMercadoria[i].ValorVenda);
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal var = ((Convert.ToDecimal(txtQuantidadeTipoServico.Text)) * (Convert.ToDecimal(txtPrecoTipoServico.Text)));
            dtgOrcamento.Rows.Add(txtQuantidadeTipoServico.Text, "Serviço", cmbTipoServico.Text, txtPrecoTipoServico.Text, var);
            txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + var);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal var = ((Convert.ToDecimal(txtQuantidadeMercadoria.Text)) * (Convert.ToDecimal(txtPrecoMercadoria.Text)));
            dtgOrcamento.Rows.Add(txtQuantidadeMercadoria.Text, "Mercadoria", cmbMercadoria.Text, txtPrecoMercadoria.Text, var);
            txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + var);
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            string CPF = txtCPFCliente.Text.Trim();
            string Nome = txtNomeCliente.Text.Trim();

            if (!(CPF == ""))
            {
                try
                {
                    Cliente oCliente = CAutoResende.SelecionaCPFCliente(CPF);

                    txtNomeCliente.Text = oCliente.Nome;
                    txtCPFCliente.Text = oCliente.CPF;
                }
                catch (Exception)
                {
                    MessageBox.Show("Cliente não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (!(Nome == ""))
            {
                try
                {
                    Cliente oCliente = CAutoResende.SelecionaNomeCliente(Nome);

                    txtNomeCliente.Text = oCliente.Nome;
                    txtCPFCliente.Text = oCliente.CPF;
                }
                catch (Exception)
                {
                    MessageBox.Show("Cliente não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Digite um Nome ou um CPF para a pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strPlaca = txtPlaca.Text;
            Veiculo oVeiculo = new Veiculo();

            try
            {
                oVeiculo = CAutoResende.SelecionaPlacaVeiculo(strPlaca);

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
