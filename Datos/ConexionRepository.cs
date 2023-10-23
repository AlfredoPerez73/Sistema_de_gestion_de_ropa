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
        private SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS;DataBase=BDSISTEMA_INVENTARIO2;Integrated Security=true");
        
        public SqlConnection AbrirConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
        public SqlConnection CerrarConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }
}
