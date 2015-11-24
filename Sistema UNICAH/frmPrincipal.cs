using System;
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

        private void btnmatricula_Click(object sender, EventArgs e)
        {
            frmMatricula frmmatricula = new frmMatricula();
            frmmatricula.ShowDialog(this);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
