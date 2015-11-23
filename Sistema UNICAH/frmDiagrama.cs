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
    public partial class frmDiagrama : Form
    {
        public frmDiagrama()
        {
            InitializeComponent();
            CreateDynamicButton("Boton ", 60);
            
        }

        private void frmDiagrama_Load(object sender, EventArgs e)
        {
            
        }
        private void CreateDynamicButton(string Nombre,int Cantidad)
        {
            while (Cantidad>0)
            {
                // Create a Button object 
                Button dynamicButton = new Button();

                // Set Button properties
                dynamicButton.Height = 60;
                dynamicButton.Width = 100;
                dynamicButton.BackColor = Color.SteelBlue;
                dynamicButton.ForeColor = Color.White;
                dynamicButton.Text = Nombre+Cantidad.ToString();
                dynamicButton.Name = Nombre + Cantidad.ToString();
                dynamicButton.Font = new Font("Georgia", 8);
                dynamicButton.FlatStyle = 0;

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

        
    }
}
