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
            // TODO: This line of code loads data into the '_AutoResende_DataBaseDataSet_Veiculo.Veiculo' table. You can move, or remove it, as needed.
            this.veiculoTableAdapter.Fill(this._AutoResende_DataBaseDataSet_Veiculo.Veiculo);

        }
    }
}
