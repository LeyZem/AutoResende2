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
    public partial class frmConsultaFornecedor : Form
    {
        public frmConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void btnFechar_MouseClick_1(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void frmConsultaFornecedor_Load(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Fornecedor oFornecedor= new Fornecedor();
            oFornecedor = dtgFornecedores.Rows[e.RowIndex].DataBoundItem as Fornecedor;
            frmCadastroFornecedor frm = new frmCadastroFornecedor(oFornecedor);
            frm.Show();
            this.Close();
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string var = txtCNPJ.Text;
                dtgFornecedores.DataSource = CAutoResende.SelecionaFornecedor(txtCNPJ.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Carregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string CNPJ = dtgFornecedores.CurrentRow.Cells[3].Value.ToString();

                try
                {
                    CAutoResende.DeletaFornecedor(CNPJ);
                    MessageBox.Show("Fornecedor deletado com sucesso!", "CONFIRMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgFornecedores.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
