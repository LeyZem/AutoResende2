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
    public partial class frmConsultaOrdemServico : Form
    {
        public frmConsultaOrdemServico()
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

        private void dtgServicosCadastrados_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dtgOS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OrdemServico OS = new OrdemServico();
            OS.Equals(dtgOS.CurrentRow);
            frmCadastroOrdemServico frm = new frmCadastroOrdemServico(OS);
            frm.Show();
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int Codigo = Convert.ToInt32(dtgOS.CurrentRow.Cells[0].Value);

                try
                {
                    CAutoResende.DeletaOrdemServico(Codigo);
                    MessageBox.Show("Ordem de Serviço deletada com sucesso!", "CONFIRMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgOS.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
