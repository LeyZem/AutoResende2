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
    public partial class frmCadastroTipoServico : Form
    {
        public frmCadastroTipoServico()
        {
            InitializeComponent();
        }

        private void btnFechar_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void Fechar_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private bool ValidaCampos()
        {
            if (txtNomeServico.Text.Trim() == "")
            {
                MessageBox.Show("Nome de preenchimento obrigatório", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomeServico.Focus();
                return false;
            } else if (txtDescricao.Text.Trim() == "")
            {
                MessageBox.Show("Descrição de preenchimento obrigatório", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescricao.Focus();
                return false;
            } else
            {
                return true;
            }
        }

        private void Btn_Gravar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos()==true)
            {
                TipoServico oTipoServico = new TipoServico();
                oTipoServico.NomeServiço = txtNomeServico.Text;
                oTipoServico.Descricao = txtDescricao.Text;

                try
                {
                    CAutoResende.Insere(oTipoServico);
                    MessageBox.Show("Cadastro realizado com sucesso!", "CONFIRMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
