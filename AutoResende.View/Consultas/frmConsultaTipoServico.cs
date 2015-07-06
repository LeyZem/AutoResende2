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
    public partial class frmConsultaTipoServico : Form
    {
        public frmConsultaTipoServico()
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

        private void frmConsultaTipoServico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AutoResende_DataBaseDataSet_TipoServico.TipoServico' table. You can move, or remove it, as needed.
            //this.tipoServicoTableAdapter.Fill(this._AutoResende_DataBaseDataSet_TipoServico.TipoServico);

        }

        private void btnPesquisaTipoServico_Click(object sender, EventArgs e)
        {
            try
            {
                string var = txtNomeServico.Text;
                dtgTipoServico.DataSource = CAutoResende.SelecionaTipoServico(txtNomeServico.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Carregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgTipoServico_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TipoServico oTipoServico = new TipoServico();
            oTipoServico = dtgTipoServico.Rows[e.RowIndex].DataBoundItem as TipoServico;
            frmCadastroTipoServico frm = new frmCadastroTipoServico(oTipoServico);
            frm.Show();
            this.Close();
        }
    }
}
