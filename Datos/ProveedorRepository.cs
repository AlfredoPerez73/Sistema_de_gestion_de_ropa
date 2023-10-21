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

        public string GuardarRegistros(string IdProveedor, string Documento, string RazonSocial, string Correo, string Telefono)
        {
            connection.AbrirConnection();
            command.CommandText = "insert into PROVEEDOR values('" + IdProveedor + "','" + Documento + "','" + RazonSocial + "','" + Correo + "','" + Telefono + "')";
            command.ExecuteNonQuery();
            return $"Producto almacenado";
        }

        public void ModificarRegistros(string Documento, string RazonSocial, string Correo, string Telefono, string IdProveedor)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "ModificarProveedor";
            command.Parameters.AddWithValue("@Documento", Documento);
            command.Parameters.AddWithValue("@RazonSocial", RazonSocial);
            command.Parameters.AddWithValue("@Correo", Correo);
            command.Parameters.AddWithValue("@Telefono", Telefono);
            command.Parameters.AddWithValue("@IdProveedor", IdProveedor);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void EliminarRegistros(string IdProveedor)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "EliminarProveedor";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdProveedor", IdProveedor);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }
    }
}
