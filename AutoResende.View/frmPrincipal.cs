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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptbCadastroServico_Click(object sender, EventArgs e)
        {

        }

        private void ptbCadastroServico_MouseClick(object sender, MouseEventArgs e)
        {
            frmCadastroTipoServico frm = new frmCadastroTipoServico();
            frm.Show();
        }

        private void ptbConsultaServicos_Click(object sender, EventArgs e)
        {

        }
    }
}
