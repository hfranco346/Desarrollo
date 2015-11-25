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
    public partial class frmRegistro : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public frmRegistro()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.Grey400, Primary.Grey400, Accent.Yellow700, TextShade.WHITE);
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
