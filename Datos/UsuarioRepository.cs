using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class UsuarioRepository
    {
        private ConexionRepository connection = new ConexionRepository();
        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand command = new SqlCommand();

        public void GuardarRegistros(Usuario usuario)
        {
            connection.AbrirConnection();
            command.Connection = connection.AbrirConnection();
            command.CommandText = "INSERT INTO USUARIO(IdUsuario,Documento,Usuario,Contraseña,Correo,IdRol,Rol) VALUES ('" + usuario.IdUser+ "','" + usuario.Documento + "','" + usuario.User + "','" + usuario.Password + "','" + usuario.Correo + "','" + usuario.Rol.IdRol + "','" + usuario.Rol.NRol + "');";
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.ExecuteNonQuery();
        }

        public DataTable CargarRegistros()
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "CargarUsuario";
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            table.Load(reader);
            connection.CerrarConnection();
            return table;
        }

        public void ModificarRegistros(Usuario usuario)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "ModificarUsuario";
            command.Parameters.AddWithValue("@Usuario", usuario.User);
            command.Parameters.AddWithValue("@Contraseña", usuario.Password);
            command.Parameters.AddWithValue("@Correo", usuario.Correo);
            command.Parameters.AddWithValue("@IdRol", usuario.Rol.NRol);
            command.Parameters.AddWithValue("@Rol", usuario.Rol.NRol);
            command.Parameters.AddWithValue("@IdUsuario", usuario.IdUser);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void EliminarRegistros(Usuario usuario)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "EliminarUsuario";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdUsuario", usuario.IdUser);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public bool Login(Usuario usuario)
        {
            var connections = connection.AbrirConnection();
            command.Connection = connections;
            command.CommandText = "select * from USUARIO where Usuario=@Usuario and Contraseña=@Contraseña";
            command.Parameters.AddWithValue("@Usuario", usuario.User);
            command.Parameters.AddWithValue("@Contraseña", usuario.Password);
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    usuario.IdUser = reader.GetString(0);
                    usuario.Documento = reader.GetString(1);
                    usuario.User = reader.GetString(2);
                    usuario.Password = reader.GetString(3);
                    usuario.Correo = reader.GetString(4);
                    usuario.Rol = new Rol { NRol = reader.GetString(7) };
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
