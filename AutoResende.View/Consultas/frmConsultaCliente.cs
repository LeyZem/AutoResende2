using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoResende.View
{
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnFechar_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_MouseClick_1(object sender, MouseEventArgs e)
        {
            
        }

        private void btnFechar_MouseClick_2(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_AutoResende_DataBaseDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this._AutoResende_DataBaseDataSet.Cliente);

        }

        private void pesquisarClienteToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.PesquisarCliente(this._AutoResende_DataBaseDataSet.Cliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pesquisarClienteToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.PesquisarCliente(this._AutoResende_DataBaseDataSet.Cliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pesquisarClienteToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.PesquisarCliente(this._AutoResende_DataBaseDataSet.Cliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
