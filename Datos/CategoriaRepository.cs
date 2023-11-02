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
            command.CommandText = "CargarCategorias";
            command.CommandType = CommandType.StoredProcedure;
            reader = command.ExecuteReader();
            table.Load(reader);
            connection.CerrarConnection();
            return table;
        }

        public void GuardarRegistros(Categoria categoria)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "INSERT INTO CATEGORIA(IdCategoria,TipoCategoria) VALUES('" + categoria.IdCategoria + "', '" + categoria.TipoCategoria + "');";
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void ModificarRegistros(Categoria categoria)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "ModificarCategoria";
            command.Parameters.AddWithValue("@TipoCategoria", categoria.TipoCategoria);
            command.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void EliminarRegistros(Categoria categoria)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "EliminarCategoria";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }
    }
}
