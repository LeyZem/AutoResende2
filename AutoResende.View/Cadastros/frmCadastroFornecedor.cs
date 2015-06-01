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
    public partial class frmCadastroFornecedor : Form
    {
        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnFechar_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void lblcidade_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_MouseClick_1(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private bool ValidaCampos()
        {
            if (txtCNPJ.Text.Trim() == "")
            {
                MessageBox.Show("CNPJ de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCNPJ.Focus();
                return false;
            }
            else if (txtinscEstadual.Text.Trim() == "")
            {
                MessageBox.Show(" Inscrição Estadual de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtinscEstadual.Focus();
                return false;
            }
            else if (txtRazaoSocial.Text.Trim() == "")
            {
                MessageBox.Show("Razão Social de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRazaoSocial.Focus();
                return false;
            }
            else if (txtfantasia.Text.Trim() == "")
            {
                MessageBox.Show("Nome Fantasia de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtfantasia.Focus();
                return false;
            }
            
            else
            {
                return true;
            }
        }

        private void LimpaCampos()
        {
            txtCel.Text = "";
            txtcep.Text = "";
            txtfantasia.Text = "";
            txtRazaoSocial.Text = "";
            cmbestado.SelectedItem = null;
            cmbpais.SelectedItem = null;
            txttel1.Text = "";
            txtbairro.Text = "";
            txtemail.Text = "";
            txtinscEstadual.Text = "";
            txtLogradouro.Text = "";
            txtCNPJ.Text = "";
            txtComentarios.Text = "";
            txtCidade.Text = "";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos() == true)
            {
                Fornecedor oFornecedor = new Fornecedor();
                oFornecedor.CNPJ = txtCNPJ.Text;
                oFornecedor.RazaoSocial = txtRazaoSocial.Text;
                oFornecedor.InscricaoEstadual = txtinscEstadual.Text;
                oFornecedor.NomeFantasia = txtfantasia.Text;
                oFornecedor.CEP = txtcep.Text;
                oFornecedor.Logradouro = txtLogradouro.Text;
                oFornecedor.Bairro = txtbairro.Text;
                oFornecedor.Cidade = txtCidade.Text;
                oFornecedor.UF = cmbestado.Text;
                oFornecedor.Pais = cmbpais.Text;
                oFornecedor.TelRes = txttel1.Text;
                oFornecedor.TelCel = txtCel.Text;
                oFornecedor.email = txtemail.Text;
                oFornecedor.Comentario = txtComentarios.Text;
                MessageBox.Show("Cadastro realizado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaCampos();
            }
        }

        private void txt_inscEstadual_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
