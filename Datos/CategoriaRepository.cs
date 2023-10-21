using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class CategoriaRepository
    {
        private ConexionRepository connection = new ConexionRepository();
        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand command = new SqlCommand();

        public DataTable CargarRegistros()
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "CargarCategoria";
            command.CommandType = CommandType.StoredProcedure;
            reader = command.ExecuteReader();
            table.Load(reader);
            connection.CerrarConnection();
            return table;
        }

        public void GuardarRegistros(string IdCategoria, string TipoCategoria)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "INSERT INTO CATEGORIA(IdCategoria,TipoCategoria) VALUES('" + IdCategoria + "', '" + TipoCategoria + "');";
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void ModificarRegistros(string TipoCategoria, string IdCategoria)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "ModificarCategoria";
            command.Parameters.AddWithValue("@TipoCategoria", TipoCategoria);
            command.Parameters.AddWithValue("@IdCategoria", IdCategoria);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void EliminarRegistros(string IdCategoria)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "EliminarCategoria";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdCategoria", IdCategoria);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }
    }
}
