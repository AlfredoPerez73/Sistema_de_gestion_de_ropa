using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using Entidad;
namespace Datos
{
    public class ProveedorRepository
    {
        private ConexionRepository connection = new ConexionRepository();
        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand command = new SqlCommand();

        public DataTable CargarRegistros()
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "CargarProveedores";
            command.CommandType = CommandType.StoredProcedure;
            reader = command.ExecuteReader();
            table.Load(reader);
            connection.CerrarConnection();
            return table;
        }

        public string GuardarRegistros(Proveedor proveedor)
        {
            connection.AbrirConnection();
            command.CommandText = "insert into PROVEEDOR values('" + proveedor.IdProveedor + "','" + proveedor.Documento + "','" + proveedor.RazonSocial + "','" + proveedor.Correo + "','" + proveedor.Telefono + "')";
            command.ExecuteNonQuery();
            return $"Producto almacenado";
        }

        public void ModificarRegistros(Proveedor proveedor)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "ModificarProveedor";
            command.Parameters.AddWithValue("@Documento", proveedor.Documento);
            command.Parameters.AddWithValue("@RazonSocial", proveedor.RazonSocial);
            command.Parameters.AddWithValue("@Correo", proveedor.Correo);
            command.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
            command.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void EliminarRegistros(Proveedor proveedor)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "EliminarProveedor";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }
    }
}
