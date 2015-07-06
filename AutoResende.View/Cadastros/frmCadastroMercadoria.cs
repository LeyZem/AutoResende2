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
    public partial class frmCadastroMercadoria : Form
    {
        public frmCadastroMercadoria(Mercadoria oMercadoria)
        {
            InitializeComponent();

            txtValorVenda.Text = Convert.ToString(oMercadoria.ValorVenda);
            txtValorCusto.Text = Convert.ToString(oMercadoria.ValorCusto);
            txtQdeEstoque.Text = Convert.ToString(oMercadoria.QuantidadeEstoque);
            txtMarca.Text = oMercadoria.Marca;
            txtDescricaoDetalhada.Text = oMercadoria.DescricaoDetalhada;
            txtDescricao.Text = oMercadoria.Descricao;

        }

        private void btnFechar_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                Mercadoria oMercadoria = new Mercadoria();
                oMercadoria.Descricao = txtDescricao.Text;
                oMercadoria.DescricaoDetalhada = txtDescricaoDetalhada.Text;
                oMercadoria.Marca = txtMarca.Text;
                oMercadoria.QuantidadeEstoque = Convert.ToInt32(txtQdeEstoque.Text);
                oMercadoria.ValorCusto = Convert.ToDecimal(txtValorCusto.Text);
                oMercadoria.ValorVenda = Convert.ToDecimal(txtValorVenda.Text);

                try
                {
                    CAutoResende.Insere(oMercadoria);
                    MessageBox.Show("Cadastro realizado com sucesso!", "CONFIRMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LimpaCampos();
            }
        }

        public bool ValidaCampos()
        {
            if (txtDescricao.Text.Trim() == "")
            {
                MessageBox.Show("Descrição de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescricao.Focus();
                return false;
            }
            else if (txtMarca.Text.Trim() == "")
            {
                MessageBox.Show("Marca de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMarca.Focus();
                return false;
            }
            else if (txtQdeEstoque.Text.Trim() == "")
            {
                MessageBox.Show("Quantidade no Estoque de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQdeEstoque.Focus();
                return false;
            }
            else if (txtValorCusto.Text.Trim() == "")
            {
                MessageBox.Show("Valor de Custo de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValorCusto.Focus();
                return false;
            }
            else if (txtValorVenda.Text.Trim() == "")
            {
                MessageBox.Show("Valor de Venda de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValorVenda.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public void LimpaCampos()
        {
            txtValorVenda.Text = "";
            txtValorCusto.Text = "";
            txtQdeEstoque.Text = "";
            txtMarca.Text = "";
            txtDescricaoDetalhada.Text = "";
            txtDescricao.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }
    
}
