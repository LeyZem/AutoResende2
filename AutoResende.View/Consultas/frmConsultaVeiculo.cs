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

        private void btnPesquisaVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                string var = txtPlaca.Text;
                dtgVeiculos.DataSource = CAutoResende.SelecionaVeiculo(txtPlaca.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Carregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
