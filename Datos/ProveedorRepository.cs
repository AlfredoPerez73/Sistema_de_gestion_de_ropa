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
    public class ProveedorRepository : ConexionRepository
    {
        public ProveedorRepository() : base()
        {

        }

        public List<Proveedor> CargarRegistro()
        {
            List<Proveedor> proveedorList = new List<Proveedor>();
            string Consulta = "SELECT * FROM PROVEEDOR";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    proveedorList.Add(Map(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return proveedorList;
        }

        public string GuardarRegistros(Proveedor proveedor)
        {
            try
            {
                string Registro = "INSERT INTO PROVEEDOR(IdProveedor,Documento,RazonSocial,Correo,Telefono) VALUES" +
                    "('" + proveedor.IdProveedor + "','" + proveedor.Documento + "','" + proveedor.RazonSocial + "','" + proveedor.Correo + "','" + proveedor.Telefono + "')";
                SqlCommand command = new SqlCommand(Registro, Connection);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al registrar el proveedor...";
            }

            return $"Se ha registrado el producto {proveedor.RazonSocial}" +
                $"con la ID {proveedor.IdProveedor}";
        }

        public string ModificarRegistros(Proveedor proveedor)
        {
            try
            {
                string Actualizar = "ModificarProveedor";
                SqlCommand command = new SqlCommand(Actualizar, Connection);
                command.Parameters.AddWithValue("@Documento", proveedor.Documento);
                command.Parameters.AddWithValue("@RazonSocial", proveedor.RazonSocial);
                command.Parameters.AddWithValue("@Correo", proveedor.Correo);
                command.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                command.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor);
                command.CommandType = CommandType.StoredProcedure;
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al modificar el proveedor";
            }

            return $"Se ha modificar el proveedor {proveedor.RazonSocial}" +
                $"con la ID {proveedor.IdProveedor}";
        }

        public string EliminarRegistros(Proveedor proveedor)
        {
            try
            {
                string Eliminar = "EliminarProveedor";

                SqlCommand command = new SqlCommand(Eliminar, Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al eliminar el producto";
            }
            return $"Se ha eliminar el producto {proveedor.RazonSocial}" +
                $"con la ID {proveedor.IdProveedor}";
        }

        private Proveedor Map(SqlDataReader reader)
        {
            Proveedor proveedor = new Proveedor
            {
                IdProveedor = Convert.ToString(reader["IdProveedor"]),
                Documento = Convert.ToString(reader["Documento"]),
                RazonSocial = Convert.ToString(reader["RazonSocial"]),
                Correo = Convert.ToString(reader["Correo"]),
                Telefono = Convert.ToString(reader["Telefono"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
            };

            return proveedor;
        }
    }
}
