﻿using System;
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
    }
}