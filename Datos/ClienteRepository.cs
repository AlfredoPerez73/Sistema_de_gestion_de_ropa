using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class ClienteRepository : ConexionRepository
    {
        public ClienteRepository() : base()
        {

        }

        public List<Cliente> CargarRegistro()
        {
            List<Cliente> clienteList = new List<Cliente>();
            string Consulta = "SELECT * FROM CLIENTE";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    clienteList.Add(Map(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return clienteList;
        }

        public string GuardarRegistros(Cliente cliente)
        {
            try
            {
                string Registro = "INSERT INTO CLIENTE(IdCliente,Documento,NombreCliente,Correo,Telefono) VALUES" +
                    "('" + cliente.IdCliente + "','" + cliente.Documento + "','" + cliente.NombreCliente + "','" + cliente.Correo + "','" + cliente.Telefono + "')";
                SqlCommand command = new SqlCommand(Registro, Connection);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al registrar el cliente...";
            }

            return $"Se ha registrado el cliente {cliente.NombreCliente}" +
                $"con la ID {cliente.IdCliente}";
        }

        public string ModificarRegistros(Cliente cliente)
        {
            try
            {
                string Actualizar = "ModificarCliente";
                SqlCommand command = new SqlCommand(Actualizar, Connection);
                command.Parameters.AddWithValue("@Documento", cliente.Documento);
                command.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);
                command.Parameters.AddWithValue("@Correo", cliente.Correo);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                command.CommandType = CommandType.StoredProcedure;
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al modificar el cliente";
            }

            return $"Se ha modificar el cliente {cliente.NombreCliente}" +
                $"con la ID {cliente.IdCliente}";
        }

        public string EliminarRegistros(Cliente cliente)
        {
            try
            {
                string Eliminar = "EliminarCliente";

                SqlCommand command = new SqlCommand(Eliminar, Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdProveedor", cliente.IdCliente);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al eliminar el cliente";
            }
            return $"Se ha eliminar el cliente {cliente.NombreCliente}" +
                $"con la ID {cliente.IdCliente}";
        }

        private Cliente Map(SqlDataReader reader)
        {
            Cliente proveedor = new Cliente
            {
                IdCliente = Convert.ToInt32(reader["IdCliente"]),
                Documento = Convert.ToString(reader["Documento"]),
                NombreCliente = Convert.ToString(reader["NombreCliente"]),
                Correo = Convert.ToString(reader["Correo"]),
                Telefono = Convert.ToString(reader["Telefono"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
            };

            return proveedor;
        }
    }
}
