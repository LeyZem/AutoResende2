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
            else if (txtCor.Text.Trim() == "")
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
                oVeiculo.Modelo = txtModelo.Text;
                oVeiculo.Descricao = txtCor.Text;
                oVeiculo.Placa = txtPlaca.Text;
                oVeiculo.Odometro = Convert.ToInt32(txtOdometro.Text);
                oVeiculo.Cor = txtCor.Text;
                oVeiculo.Combustivel = cmbCombustivel.Text;
                MessageBox.Show("Cadastro realizado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
