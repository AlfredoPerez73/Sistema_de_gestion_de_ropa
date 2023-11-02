using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionRepository
    {
        protected SqlConnection Connection;
        protected string StringConnection = "Server=.\\SQLEXPRESS;DataBase=BDSISTEMA_INVENTARIO2;Integrated Security=true";

        public ConexionRepository()
        {
            Connection = new SqlConnection(StringConnection);
        }
        public SqlConnection AbrirConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            return Connection;
        }

        public string Abrir()
        {
            Connection.Open();
            return Connection.State.ToString();
        }

        public string Cerrar()
        {
            Connection.Close();
            return Connection.State.ToString();
        }

        public SqlConnection CerrarConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
            return Connection;
        }
    }
}
