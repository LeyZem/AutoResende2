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
        int Cont = 0;

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

        private void frmCadastroOrdemServico_Load(object sender, EventArgs e)
        {
            List<TipoServico> oTipoServicos = CAutoResende.ListaTiposServico();

            for (int i = 0; i < oTipoServicos.Count; i++)
            {
                cmbTipoServico.Items.Add(oTipoServicos[i].NomeServiço);
            }

        }

        private void cmbTipoServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<TipoServico> oTipoServicos = CAutoResende.ListaTiposServico();


            int index = cmbTipoServico.SelectedIndex;

            for (int i = 0; i < oTipoServicos.Count; i++)
            {
                if (i == index)
                {
                    rtbDescricao.Text = oTipoServicos[i].Descricao;
                    break;
                }
            }

        }

        private void btnIncluirServico_Click(object sender, EventArgs e)
        {
            dtgServicosCadastrados.Rows.Add(cmbTipoServico.Text, txtDescricaoComplementar.Text);
            dtgServicosCadastrados.Refresh();
            Cont = 0;
        }

        private void txtDescricaoComplementar_Click(object sender, EventArgs e)
        { 
            if (Cont==0)
            {
                txtDescricaoComplementar.Text = "";
                Cont++;
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
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

            }else
            {
                MessageBox.Show("Digite um Nome ou um CPF para a pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dtgServicosCadastrados.SelectedRows != null)
            {
                dtgServicosCadastrados.Rows.Remove(dtgServicosCadastrados.CurrentRow);
            }
            
        }
    }
}
