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

        public void GuardarRegistros(string IdUsuario, string Documento, string Usuario, string Contraseña, string Correo, string IdRol, string Rol)
        {
            connection.AbrirConnection();
            command.Connection = connection.AbrirConnection();
            command.CommandText = "INSERT INTO USUARIO(IdUsuario,Documento,Usuario,Contraseña,Correo,IdRol,Rol) VALUES ('" + IdUsuario + "','" + Documento + "','" + Usuario + "','" + Contraseña + "','" + Correo + "','" + IdRol + "','" + Rol + "');";
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

        public void ModificarRegistros(string Usuario, string Contraseña, string Correo, string IdRol, string Rol, string IdUsuario)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "ModificarUsuario";
            command.Parameters.AddWithValue("@Usuario", Usuario);
            command.Parameters.AddWithValue("@Contraseña", Contraseña);
            command.Parameters.AddWithValue("@Correo", Correo);
            command.Parameters.AddWithValue("@IdRol", IdRol);
            command.Parameters.AddWithValue("@Rol", Rol);
            command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void EliminarRegistros(string IdUsuario)
        {
            command.Connection = connection.AbrirConnection();
            command.CommandText = "EliminarUsuario";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public bool Login(string usuario, string contraseña)
        {
            var connections = connection.AbrirConnection();
            command.Connection = connections;
            command.CommandText = "select * from USUARIO where Usuario=@Usuario and Contraseña=@Contraseña";
            command.Parameters.AddWithValue("@Usuario", usuario);
            command.Parameters.AddWithValue("@Contraseña", contraseña);
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuario.IdUser = reader.GetString(0);
                    Usuario.User = reader.GetString(2);
                    Usuario.Correo = reader.GetString(4);
                    Usuario.Rol = reader.GetString(7);
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
