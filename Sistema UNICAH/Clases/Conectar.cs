using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Sistema_UNICAH.Clases
{
    class Conectar
    {
        public static bool isDiagrama = false; // Se utiliza para activar o desactivar la matricula
        public bool IsDiagrama
        {
            get
            {
                return isDiagrama;
            }
            set
            {
                isDiagrama = value;
            }
        }

        public SqlConnection conn = new SqlConnection(@"server = .\sqlexpress;
                    integrated security = true; database = UNICAH");
        public SqlConnection DbOpen()
        {
            conn.Open();
            return conn;
        }

        public SqlConnection DbClose()
        {
            conn.Close();
            return conn;
        }

        public SqlCommand Comando(string sql)
        {
            SqlCommand MyCommand = new SqlCommand(sql,conn);
            return MyCommand;
        }
    }
}
