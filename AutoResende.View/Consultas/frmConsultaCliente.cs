﻿using System;
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

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {

            try
            {
                dtgClientes.DataSource = CAutoResende.SelecionaCliente(txtCPFCliente.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Carregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cliente oCliente = new Cliente();
            oCliente = dtgClientes.Rows[e.RowIndex].DataBoundItem as Cliente;
            frmCadastroCliente frm = new frmCadastroCliente(oCliente);
            frm.Show();
            this.Close();
        }
    }
}
