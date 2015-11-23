using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


using MaterialSkin;
using MaterialSkin.Controls;

namespace Sistema_UNICAH
{
    public partial class frmDiagrama : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public frmDiagrama()
        {
            InitializeComponent();
            CreateDynamicButton("Boton ", 43);
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.Grey400, Primary.Grey400, Accent.Yellow700, TextShade.WHITE);

            
        }

        private void frmDiagrama_Load(object sender, EventArgs e)
        {
            
        }
        private void CreateDynamicButton(string Nombre,int Cantidad)
        {
            while (Cantidad>0)
            {
                string esp;
                esp = "   ";
                // Create a Button object 
                Button dynamicButton = new Button();

                // Set Button properties
                dynamicButton.Height = 50;
                dynamicButton.Width = 100;
                dynamicButton.BackColor = Color.Black;
                dynamicButton.BackgroundImage = Image.FromFile("C:/Users/RioPc/Pictures/icono.Png");
                dynamicButton.ForeColor = Color.LightSlateGray;
                dynamicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                dynamicButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                dynamicButton.Font = new Font("Georgia", 10);
                dynamicButton.FlatStyle = FlatStyle.Popup;
                dynamicButton.Text = esp + Nombre + Cantidad.ToString();
                dynamicButton.Name =  Nombre + Cantidad.ToString();
                

                dynamicButton.Visible = true;

                // Add a Button Click Event handler
                dynamicButton.Click += new EventHandler(DynamicButton_Click);

                // Add Button to the Form. Placement of the Button
                // will be based on the Location and Size of button
                flowLayoutPanel1.Controls.Add(dynamicButton);
                Cantidad--;
            }
            
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            Button dynamicButton = sender as Button;
            string nameButton;
            nameButton = dynamicButton.Name;
            MessageBox.Show(nameButton);
            
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
        
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
    }
}
