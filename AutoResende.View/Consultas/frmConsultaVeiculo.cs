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
    public partial class frmConsultaVeiculo : Form
    {
        public frmConsultaVeiculo()
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

        private void frmConsultaVeiculo_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPesquisaVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                string var = txtPlaca.Text;
                dtgConsultaVeiculo.DataSource = CAutoResende.SelecionaVeiculo(txtPlaca.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Carregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgConsultaVeiculo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Veiculo oVeiculo = new Veiculo();
            oVeiculo = dtgConsultaVeiculo.Rows[e.RowIndex].DataBoundItem as Veiculo;
            frmCadastroVeiculo frm = new frmCadastroVeiculo(oVeiculo);
            frm.Show();
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Placa = dtgConsultaVeiculo.CurrentRow.Cells[1].Value.ToString();

                try
                {
                    CAutoResende.DeletaVeiculo(Placa);
                    MessageBox.Show("Veículo deletado com sucesso!", "CONFIRMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgConsultaVeiculo.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
