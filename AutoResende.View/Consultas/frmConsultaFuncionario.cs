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
            // TODO: This line of code loads data into the '_AutoResende_DataBaseDataSet1.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this._AutoResende_DataBaseDataSet1.Funcionario);

        }
    }
}
