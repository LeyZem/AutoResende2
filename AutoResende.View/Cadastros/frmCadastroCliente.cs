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
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnFechar_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        

        private void Btn_Apagar_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            txtNome.Text = "";
            txtRG.Text = "";
            txtCPF.Text = "";
            txtDataNasc.Text = "";
            txtOrgaoExpedidor.Text = "";
            txtLogradouro.Text = "";
            txtBairro.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
            cmbEstado.SelectedItem = null;
            txtEmail.Text = "";
            cmbPais.SelectedItem = null;
            txtTelRes.Text = "";
            txtCel.Text = "";
            txtComentario.Text = "";

        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
           if(ValidaCampos()==true)
            {
                Cliente oCliente = new Cliente();
                oCliente.Nome = txtNome.Text;
                oCliente.RG = txtRG.Text;
                oCliente.CPF = txtCPF.Text;
                oCliente.DataNascimento = Convert.ToDateTime(txtDataNasc.Text);
                oCliente.OrgaoExpedidor = txtOrgaoExpedidor.Text;
                oCliente.Logradouro = txtLogradouro.Text;
                oCliente.Bairro = txtBairro.Text;
                oCliente.CEP = txtCep.Text;
                oCliente.Cidade = txtCidade.Text;
                oCliente.email = txtEmail.Text;
                oCliente.Pais = cmbPais.Text;
                oCliente.UF = cmbEstado.Text;
                oCliente.TelRes = txtTelRes.Text;
                oCliente.TelCel = txtCel.Text;
                oCliente.Comentario = txtComentario.Text;

                try
                {
                    CAutoResende.Insere(oCliente);
                    MessageBox.Show("Cadastro realizado com sucesso!", "CONFIRMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LimpaCampos();
            }
        }

        private bool ValidaCampos()
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Nome de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
                return false;
            }
            else if (txtRG.Text.Trim() == "")
            {
                MessageBox.Show("RG de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRG.Focus();
                return false;
            }
            else if (txtCPF.Text.Trim() == "")
            {
                MessageBox.Show("CPF de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCPF.Focus();
                return false;
            }
            else if (txtDataNasc.Text.Trim() == "")
            {
                MessageBox.Show("Data de Nascimento de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDataNasc.Focus();
                return false;
            }
            else if (txtOrgaoExpedidor.Text.Trim() == "")
            {
                MessageBox.Show("Órgão Expedidor de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOrgaoExpedidor.Focus();
                return false;
            }
            else if (txtLogradouro.Text.Trim() == "")
            {
                MessageBox.Show("Logradouro de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLogradouro.Focus();
                return false;
            }
            else if (txtBairro.Text.Trim() == "")
            {
                MessageBox.Show("Bairro de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBairro.Focus();
                return false;
            }
            else if (txtCep.Text.Trim() == "")
            {
                MessageBox.Show("CEP de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCep.Focus();
                return false;
            }
            else if (txtCidade.Text.Trim() == "")
            {
                MessageBox.Show("Cidade de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCidade.Focus();
                return false;
            }
            else if (cmbEstado.Text.Trim() == "")
            {
                MessageBox.Show("Estado de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbEstado.Focus();
                return false;
            }
            else if (cmbPais.Text.Trim() == "")
            {
                MessageBox.Show("País de preenchimento obrigatório!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbPais.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
