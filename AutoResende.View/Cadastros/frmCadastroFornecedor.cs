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

        private void LimpaCampos()
        {
            txtCel.Text = "";
            txtcep.Text = "";
            txtfantasia.Text = "";
            txtRazaoSocial.Text = "";
            cmbestado.SelectedItem = null;
            cmbpais.SelectedItem = null;
            txttel1.Text = "";
            txt_bairro.Text = "";
            txtemail.Text = "";
            txt_inscEstadual.Text = "";
            txtLogradouro.Text = "";
            txtCNPJ.Text = "";
            txtComentarios.Text = "";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Fornecedor oFornecedor = new Fornecedor();
            oFornecedor.TelCel = txtCel.Text;
            oFornecedor.CEP = txtcep.Text;
            oFornecedor.NomeFantasia = txtfantasia.Text;
            oFornecedor.RazaoSocial = txtRazaoSocial.Text;
            oFornecedor.UF = cmbestado.Text;
            
        }
    }
}
