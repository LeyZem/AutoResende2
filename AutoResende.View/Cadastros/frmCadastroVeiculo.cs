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
    public partial class frmCadastroVeiculo : Form
    {
        public frmCadastroVeiculo()
        {
            InitializeComponent();
        }

        private void btnFechar_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void LimpaCampos()
        {
            txtCor.Text = "";
            txtDescricao.Text = "";
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtOdometro.Text = "";
            txtPlaca.Text = "";
            cmbCombustivel.SelectedItem = null;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private bool ValidaCampos()
        {
            if (txtCor.Text.Trim() == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtMarca.Text.Trim() == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtModelo.Text.Trim() == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtOdometro.Text.Trim() == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtPlaca.Text.Trim() == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (cmbCombustivel.Text.Trim() == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos()==true)
            {
                Veiculo oVeiculo = new Veiculo();
                oVeiculo.Marca = txtMarca.Text;
                oVeiculo.Modelo = txtModelo.Text;
                oVeiculo.Descricao = txtCor.Text;
                oVeiculo.Placa = txtPlaca.Text;
                oVeiculo.Odometro = Convert.ToInt32(txtOdometro.Text);
                oVeiculo.Cor = txtCor.Text;
                oVeiculo.Combustivel = cmbCombustivel.Text;

                try
                {
                    CAutoResende.Insere(oVeiculo);
                    MessageBox.Show("Cadastro realizado com sucesso!", "CONFIRMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LimpaCampos();

            }
        }

        private void txtOdometro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
