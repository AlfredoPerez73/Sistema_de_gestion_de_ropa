using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class ProductoRepository
    {
        private ConexionRepository connection = new ConexionRepository();
        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand command = new SqlCommand();

        public DataTable CargarRegistros()
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "CargarProductos";
            command.CommandType = CommandType.StoredProcedure;
            reader = command.ExecuteReader();
            table.Load(reader);
            connection.CerrarConnection();
            return table;
        }

        public void GuardarRegistros(string IdProducto, string NombreProducto, string Marca, int Stock, double PrecioUnitario, string IdCategoria
            , string IdProveedor, string TipoCategoria)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "INSERT INTO PRODUCTO(IdProducto,NombreProducto,Marca,Stock,PrecioUnitario,IdCategoria,IdProveedor,TipoCategoria) VALUES('" + IdProducto + "', '" + NombreProducto + "', '" + Marca + "', " + Stock + ", " + PrecioUnitario + ", '" + IdCategoria + "', '" + IdProveedor + "', '" + TipoCategoria + "');";
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void ModificarRegistros(string NombreProducto, string Marca, int Stock, double PrecioUnitario, string IdCategoria
            , string IdProveedor, string TipoCategoria, string IdProducto)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "ModificarProductos";
            command.Parameters.AddWithValue("@NombreProducto", NombreProducto);
            command.Parameters.AddWithValue("@Marca", Marca);
            command.Parameters.AddWithValue("@Stock", Stock);
            command.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario);
            command.Parameters.AddWithValue("@IdCategoria", IdCategoria);
            command.Parameters.AddWithValue("@IdProveedor", IdProveedor);
            command.Parameters.AddWithValue("@TipoCategoria", TipoCategoria);
            command.Parameters.AddWithValue("@IdProducto", IdProducto);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void EliminarRegistros(string IdProducto)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "EliminarProductos";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdProducto", IdProducto);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }
    }
}
