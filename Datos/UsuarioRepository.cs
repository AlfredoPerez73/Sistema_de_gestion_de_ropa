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
    public class UsuarioRepository : ConexionRepository
    {
        public UsuarioRepository() : base()
        {

        }

        public string GuardarRegistros(Usuario usuario)
        {
            try
            {
                string Registro = "INSERT INTO USUARIO(IdUsuario,Documento,Usuario,Contraseña,Correo,IdRol,Rol) VALUES ('" + usuario.IdUser + "','" + usuario.Documento + "','" + usuario.User + "','" + usuario.Password + "','" + usuario.Correo + "','" + usuario.Rol.IdRol + "','" + usuario.Rol.NRol + "');";
                SqlCommand command = new SqlCommand(Registro, Connection);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al registrar el usuario";
            }

            return $"Se ha registrado el producto {usuario.User}" +
                $"con la ID {usuario.IdUser}";
        }

        public List<Usuario> CargarRegistro()
        {
            List<Usuario> usuarioList = new List<Usuario>();
            string Consulta = "SELECT * FROM USUARIO";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    usuarioList.Add(Map(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return usuarioList;
        }

        public string ModificarRegistros(Usuario usuario)
        {
            try
            {
                string Actualizar = "ModificarUsuario";
                SqlCommand command = new SqlCommand(Actualizar, Connection);
                command.Parameters.AddWithValue("@Usuario", usuario.User);
                command.Parameters.AddWithValue("@Contraseña", usuario.Password);
                command.Parameters.AddWithValue("@Correo", usuario.Correo);
                command.Parameters.AddWithValue("@IdRol", usuario.Rol.NRol);
                command.Parameters.AddWithValue("@Rol", usuario.Rol.NRol);
                command.Parameters.AddWithValue("@IdUsuario", usuario.IdUser);
                command.CommandType = CommandType.StoredProcedure;
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al modificar el usuario";
            }

            return $"Se ha modificar el usuario {usuario.User}" +
                $"con la ID {usuario.IdUser}";
        }

        public string EliminarRegistros(Usuario usuario)
        {
            try
            {
                string Eliminar = "EliminarUsuario";
                SqlCommand command = new SqlCommand(Eliminar, Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdUsuario", usuario.IdUser);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al modificar el usuario";
            }

            return $"Se ha modificar el usuario {usuario.User}" +
                $"con la ID {usuario.IdUser}";
        }

        public bool Login(Usuario usuario)
        {
            try
            {
                string Login = "select * from USUARIO where Usuario=@Usuario and Contraseña=@Contraseña";
                SqlCommand command = new SqlCommand(Login, Connection);
                command.Parameters.AddWithValue("@Usuario", usuario.User);
                command.Parameters.AddWithValue("@Contraseña", usuario.Password);
                command.CommandType = CommandType.Text;
                AbrirConnection();
                var reader = command.ExecuteReader();
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
            catch (Exception)
            {
                return false;
            }
        }

        private Usuario Map(SqlDataReader reader)
        {
            Usuario usuario = new Usuario
            {
                IdUser = Convert.ToString(reader["IdUsuario"]),
                Rol = new Rol
                {
                    IdRol = Convert.ToString(reader["IdRol"]),
                    NRol = Convert.ToString(reader["Rol"])
                },
                Documento = Convert.ToString(reader["Documento"]),
                User = Convert.ToString(reader["Usuario"]),
                Password = Convert.ToString(reader["Contraseña"]),
                Correo = Convert.ToString(reader["Correo"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
            };

            return usuario;
        }
    }
}
