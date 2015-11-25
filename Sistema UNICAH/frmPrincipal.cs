using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace Sistema_UNICAH
{
    public partial class frmPrincipal : MaterialForm
    {

        private readonly MaterialSkinManager materialSkinManager;
        public frmPrincipal()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.Grey400, Primary.Grey400, Accent.Yellow700, TextShade.WHITE);
        
        }

        private void btnDiagrama_Click(object sender, EventArgs e)
        {
            frmDiagrama frmdiagrama = new frmDiagrama();
            frmdiagrama.ShowDialog(this);
        }

        private void btnmatricula_Click(object sender, EventArgs e)
        {
            frmDiagrama frmdiagrama = new frmDiagrama();
            frmdiagrama.Width = 881;
            frmdiagrama.Text = "Diagrama                                                                                                                Universidad Católica de Honduras";
            frmdiagrama.ShowDialog(this);
            

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLoginInicial frmlogin = new frmLoginInicial();
            frmlogin.ShowDialog(this);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro frmregistro = new frmRegistro();
            frmregistro.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
