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
    public partial class frmConsultaMercadoria : Form
    {
        public frmConsultaMercadoria()
        {
            InitializeComponent();
        }

        private void btnFechar_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void btnFechar_MouseClick_1(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void lblValorCusto_Click(object sender, EventArgs e)
        {

        }

        private void txtValorCusto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgMercadorias_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Mercadoria oMercadoria = new Mercadoria();
            oMercadoria = dtgMercadorias.Rows[e.RowIndex].DataBoundItem as Mercadoria;
            frmCadastroMercadoria frm = new frmCadastroMercadoria(oMercadoria);
            frm.Show();
            this.Close();
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            string pCNPJ;
            try
            {

                dtgMercadorias.DataSource = CAutoResende.SelecionaMercadoria(Convert.ToInt32(txtCodigo.Text));
                //pCNPJ = dtgMercadorias.CurrentRow.Cells[6].Value.ToString();
               // dtgMercadorias.DataSource =  (CAutoResende.SelecionaFornecedor(pCNPJ));


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Carregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmConsultaMercadoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AutoResende_DataBaseDataSet_Mercadoria.Mercadoria' table. You can move, or remove it, as needed.
            //this.mercadoriaTableAdapter.Fill(this._AutoResende_DataBaseDataSet_Mercadoria.Mercadoria);

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int Codigo = Convert.ToInt32(dtgMercadorias.CurrentRow.Cells[0].Value);

                try
                {
                    CAutoResende.DeletaMercadoria(Codigo);
                    MessageBox.Show("Mercadoria deletada com sucesso!", "CONFIRMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgMercadorias.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dtgMercadorias.DataSource = CAutoResende.ListaMercadorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
