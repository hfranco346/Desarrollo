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

using System.Data;
using System.Data.SqlClient;

namespace Sistema_UNICAH
{
    public partial class frmDiagrama : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        List<string> Botones = new List<string>();
        Clases.Conectar conn = new Clases.Conectar();
        public frmDiagrama()
        {
            InitializeComponent();
            CreateDynamicButton("Boton", 43);
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.Grey400, Primary.Grey400, Accent.Yellow700, TextShade.WHITE);

            
        }

        private void frmDiagrama_Load(object sender, EventArgs e)
        {
            

            // Crear el query
            string sql = @"select Name, ProductNumber from Production.Product";

            // Crear el comando
            SqlCommand myCommand = conn.Comando(sql);
            //txtReader.AppendText("Comando creado.\n\n");

            try
            {
                // Establecer la conexión
                conn.DbOpen();

                // Ejecutar el query via un ExecuteReader
                SqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    //txtReader.AppendText("\nProducto: ");
                    //txtReader.AppendText(rdr.GetValue(1) + "\t\t" + rdr.GetValue(0));
                    //txtReader.AppendText("\n");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
            }
            finally
            {
                // Cerrar la conexión
                conn.DbClose();
            }
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
                dynamicButton.BackgroundImage =  Properties.Resources.icono;
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
                dynamicButton.Enter += new EventHandler(DynamicButton_Enter);

                // Add Button to the Form. Placement of the Button
                // will be based on the Location and Size of button
                flowLayoutPanel1.Controls.Add(dynamicButton);
                Botones.Add(dynamicButton.Name);
                Cantidad--;
            }
            
        }

        private void DynamicButton_Enter(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c.Name == "Boton40")
                {
                    c.BackgroundImage = Properties.Resources.iconomorado;
                }
            }
        }

        

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            //Button dynamicButton = sender as Button;
            //string nameButton;
            //nameButton = dynamicButton.Name;
            //foreach (Control c in flowLayoutPanel1.Controls)
            //{
            //    if (c.Name == "Boton1")
            //    {
            //        c.BackgroundImage =Properties.Resources.iconomorado;
            //    }
            //}
            
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
