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
        RolRepository rolRepository = new RolRepository();

        public UsuarioRepository() : base()
        {

        }

        public string GuardarRegistros(Usuario usuario)
        {
            try
            {
                string Registro = "INSERT INTO USUARIO(Documento,Usuario,Contraseña,Correo,IdRol,Rol) VALUES ('" + usuario.Documento + "','" + usuario.User + "','" + usuario.Password + "','" + usuario.Correo + "','" + usuario.Rol.IdRol + "','" + usuario.Rol.NRol + "');";
                SqlCommand command = new SqlCommand(Registro, Connection);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }

            return $"Se ha registrado el producto {usuario.User}";
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
                return "Error al eliminar el usuario, " +
                    "el usuario se encuentra relacionada con una compra";
            }

            return $"Se ha eliminado el usuario {usuario.User}" +
                $"con la ID {usuario.IdUser}";
        }

        private Usuario Map(SqlDataReader reader)
        {
            Usuario usuario = new Usuario
            {
                IdUser = Convert.ToInt32(reader["IdUsuario"]),
                Documento = Convert.ToString(reader["Documento"]),
                User = Convert.ToString(reader["Usuario"]),
                Password = Convert.ToString(reader["Contraseña"]),
                Correo = Convert.ToString(reader["Correo"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
            };
            int IdRol = Convert.ToInt32(reader["IdRol"]);
            string Rol = Convert.ToString(reader["Rol"]);
            usuario.Rol = ObtenerRol(IdRol, Rol);

            return usuario;
        }

        private Rol ObtenerRol(int IdRol, string Rol)
        {
            return rolRepository.CargarRegistro().Find(c => c.IdRol == IdRol && c.NRol == Rol);
        }
    }
}
