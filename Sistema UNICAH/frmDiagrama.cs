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
        string sql;
        Clases.Conectar conn2 = new Clases.Conectar();
        
        private readonly MaterialSkinManager materialSkinManager;
        List<string> Botones = new List<string>();
        Clases.Conectar conn = new Clases.Conectar();
        SqlCommand myCommand = new SqlCommand();
        public frmDiagrama()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.Grey400, Primary.Grey400, Accent.Yellow700, TextShade.WHITE);

            
        }

        private void frmDiagrama_Load(object sender, EventArgs e)
        {
// --------------------------  BLOQUE DE CODIGO UTILIZADO PARA MODIFICAR EL PERIODO DE LA CLASE GENERAL DE UNA CARRERA ESPECIFICA   --------------------------
//            List<string> ListadoClasesGenerales = new List<string>();

//            // Crear el query
//            string sql = @"select c.Clases_Id from Clases c where c.Carrera_Id = '0'";

//            // Crear el comando
//            SqlCommand myCommand = conn.Comando(sql);
//            //txtReader.AppendText("Comando creado.\n\n");

//            try
//            {
//                // Establecer la conexión
//                conn.DbOpen();

//                // Ejecutar el query via un ExecuteReader
//                SqlDataReader rdr = myCommand.ExecuteReader();

//                while (rdr.Read())
//                {
//                    ListadoClasesGenerales.Add(rdr.GetString(0));
//                }
//            }
//            catch (SqlException ex)
//            {
//                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
//            }
//            finally
//            {
//                // Cerrar la conexión
//                conn.DbClose();
//            }

            
//            foreach (var clase in ListadoClasesGenerales)
//            {

//                sql = string.Format(@"select * from Generales_Clases where Carrera_Carrera_ID = '{0}' and Clases_Id ='{1}'", "IG03002", clase);

//                // Crear el comando
//                myCommand = conn.Comando(sql);
//                conn.DbOpen();
//                SqlDataReader dtr = myCommand.ExecuteReader(); ;
//                if (dtr.Read())
//                {
//                    sql = string.Format(@"update Clases
//                    set Clases_Periodo = (select gc.Periodo from Generales_Clases gc where gc.Carrera_Carrera_ID ='{0}' and gc.Clases_Id = '{1}') 
//                    where Carrera_Id='0' and Clases_Id = '{1}'", "IG03002", clase);

//                    // Crear el comando
//                    myCommand = conn.Comando(sql);
//                }
//                conn.DbClose(); ;
			   

//                try
//                {
//                    // Establecer la conexión
//                    conn.DbOpen();

//                    // Ejecutar el query via un ExecuteNonQuery
//                    myCommand.ExecuteNonQuery();
//                }
//                catch (SqlException ex)
//                {
//                    MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
//                }
//                finally
//                {
//                    // Cerrar la conexión
//                    conn.DbClose();
//                }
//            }
//************************************** FIN DEL BLOQUE **************************************



//----------------- INICIO DEL BLOQUE QUE GENERARA LAS CLASES DE LA CARRERA ESPECIFICA  -----------------

            sql = string.Format(@"select distinct(select distinct(c.Clases_Nombre) from Clases) Nombre_Clases,c.Clases_Periodo , c.Clases_Id
                                    from Clases c join Generales_Clases gc 
                                    on c.Carrera_Id = '{0}'or c.Carrera_Id='0' and c.Clases_Id =gc.Clases_Id and c.Clases_Id in (select gc.Clases_Id from Generales_Clases where gc.Carrera_Carrera_ID = '{0}') order by c.Clases_Periodo asc;", "IG03002");
            conn.DbOpen();
            myCommand = conn.Comando(sql);
            SqlDataReader reader = myCommand.ExecuteReader();
            int totalClases = 0;
            while (reader.Read())
            {
                totalClases++;
                CreateDynamicButton(reader.GetString(0), reader.GetString(2));
            }
            
            conn.DbClose();
            Console.WriteLine("El total de clases a cargar es de:{0}",totalClases);

//************************************** FIN DEL BLOQUE **************************************
        }
        private void CreateDynamicButton(string Nombre, string id)
        {
            
            string esp;
            esp = "   ";
            // crea un objeto de tipo boton
            Button dynamicButton = new Button();

            // configurando propiedades del boton
            dynamicButton.Height = 50;
            dynamicButton.Width = 100;
            dynamicButton.BackColor = Color.White;
            dynamicButton.BackgroundImage =  Properties.Resources.icono;
            dynamicButton.ForeColor = Color.SteelBlue;
            dynamicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            dynamicButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            dynamicButton.Font = new Font("Georgia", 6);
            dynamicButton.FlatStyle = FlatStyle.Popup;
            dynamicButton.Text = esp+Nombre+"\n"+id;
            dynamicButton.Name = id;
               
            dynamicButton.Visible = true;

            // añade un manejador de evento click para el boton
            //dynamicButton.Click += new EventHandler(DynamicButton_Click);
            //dynamicButton.Enter += new EventHandler(DynamicButton_Enter);
            dynamicButton.MouseMove += new MouseEventHandler(DynamicButton_MouseMove);
            dynamicButton.Enter += new EventHandler(DynamicButton_Enter);

            // Añade el boton al flowlayoutpanel
            flowLayoutPanel1.Controls.Add(dynamicButton);
            Botones.Add(dynamicButton.Name);
             
            
        }

        private void DynamicButton_MouseMove(object sender, MouseEventArgs e)
        {
            ColorPorDefecto();
            Button dynamicButton = sender as Button;
            sql = String.Format("select r.Requisitos_CodigoClaseReq from Requisitos r where r.Requisitos_CodigoClase = '{0}'", dynamicButton.Name);
            List<string> listaRequisitos = new List<string>();
            myCommand = conn.Comando(sql);
            conn.DbOpen();
            SqlDataReader rdr = myCommand.ExecuteReader();
            while (rdr.Read())
            {
                listaRequisitos.Add(rdr.GetString(0));
            }
            foreach (var requisito in listaRequisitos)
            {
                foreach (Control c in flowLayoutPanel1.Controls)
                {
                    if (c.Name == requisito)
                    {
                        c.BackgroundImage = Properties.Resources.iconomorado;
                    }
                }
            }
            conn.DbClose();



            sql = String.Format("select r.Requisitos_CodigoClase from Requisitos r where r.Requisitos_CodigoClaseReq = '{0}'", dynamicButton.Name);
            List<string> listaClave = new List<string>();
            myCommand = conn.Comando(sql);
            conn.DbOpen();
            SqlDataReader rdr2 = myCommand.ExecuteReader();
            while (rdr2.Read())
            {
                listaClave.Add(rdr2.GetString(0));
            }
            foreach (var requisito in listaClave)
            {
                foreach (Control c in flowLayoutPanel1.Controls)
                {
                    if (c.Name == requisito)
                    {
                        c.BackgroundImage = Properties.Resources.iconoverde;
                    }
                }
            }
            conn.DbClose();
        }

        private void DynamicButton_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void DynamicButton_Enter(object sender, EventArgs e)
        {
            if (!conn.IsDiagrama)
            {
                MessageBox.Show("Hola Click");
            }
            else
            {
                
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

        private void ColorPorDefecto()
        {
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                item.BackgroundImage=Properties.Resources.icono;
            }
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
