using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoResende.Controller;
using AutoResende.Model;

namespace AutoResende.View
{
    public partial class frmConsultaFuncionario : Form
    {
        public frmConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void btnFechar_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void frmConsultaFuncionario_Load(object sender, EventArgs e)
        {
 
        }

        private void btnPesquisaFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                dtgFuncionarios.DataSource = CAutoResende.SelecionaFuncionario(txtCpfFuncionario.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Carregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgFuncionarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Funcionario oFuncionario = new Funcionario();
            oFuncionario = dtgFuncionarios.Rows[e.RowIndex].DataBoundItem as Funcionario;
            frmCadastroFuncionario frm = new frmCadastroFuncionario(oFuncionario);
            frm.Show();
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string CPF = dtgFuncionarios.CurrentRow.Cells[2].Value.ToString();

                try
                {
                    CAutoResende.DeletaFuncionario(CPF);
                    MessageBox.Show("Funcionário deletado com sucesso!", "CONFIRMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgFuncionarios.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
