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
using System.Web;

namespace AutoResende.View
{
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
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

        private void lblCódigo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos()==true)
            {
                Funcionario oFuncionario = new Funcionario();
                oFuncionario.Nome = txtNome.Text;
                oFuncionario.RG = txtRG.Text;
                oFuncionario.CPF = txtCPF.Text;
                oFuncionario.DataNascimento = Convert.ToDateTime(txtDataNasc.Text);
                oFuncionario.OrgaoExpedidor = txtOrgaoExpedidor.Text;
                oFuncionario.Logradouro = txtLogradouro.Text;
                oFuncionario.Bairro = txtBairro.Text;
                oFuncionario.CEP = txtCep.Text;
                oFuncionario.Cidade = txtCidade.Text;
                oFuncionario.email = cmbEstado.Text;
                oFuncionario.Pais = cmbPais.Text;
                oFuncionario.email = txtEmail.Text;
                oFuncionario.TelRes = txtTelRes.Text;
                oFuncionario.TelCel = txtCel.Text;
                oFuncionario.Comentario = txtComentario.Text;

                
                try
                {
                    CAutoResende.Insere(oFuncionario);
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
            cmbPais.SelectedItem = null;
            txtEmail.Text = "";
            txtTelRes.Text = "";
            txtCel.Text = "";
            txtComentario.Text = "";
        }
    }
}
