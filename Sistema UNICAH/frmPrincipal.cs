﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_UNICAH
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnDiagrama_Click(object sender, EventArgs e)
        {
            frmDiagrama frmdiagrama = new frmDiagrama();
            frmdiagrama.ShowDialog(this);
        }
    }
}
