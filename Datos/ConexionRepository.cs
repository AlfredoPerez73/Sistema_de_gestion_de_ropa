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
        protected string StringConnection = "Server=.\\SQLEXPRESS;DataBase=BDSISTEMA_INVENTARIO2;Integrated Security=True";

        public ConexionRepository()
        {
            Connection = new SqlConnection(StringConnection);
        }

        public string AbrirConnection()
        {
            Connection.Open();
            return Connection.State.ToString();
        }

        public string CerrarConnection()
        {
            Connection.Close();
            return Connection.State.ToString();
        }
    }
}
