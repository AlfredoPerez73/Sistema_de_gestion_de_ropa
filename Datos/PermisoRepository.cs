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
    public class PermisoRepository : ConexionRepository
    {
        RolRepository rolRepository = new RolRepository();

        public PermisoRepository() : base()
        {

        }

        public List<Permiso> CargarRegistro(string IdUsuario)
        {
            List<Permiso> permisoList = new List<Permiso>();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("select p.IdRol,p.Permiso from PERMISO p");
            stringBuilder.AppendLine("inner join ROL r on r.IdRol = p.IdRol");
            stringBuilder.AppendLine("inner join USUARIO u on u.IdRol = r.IdRol");
            stringBuilder.AppendLine("where u.IdUsuario = @IdUsuario");
            //string Consulta = "select p.IdRol,p.Permiso from PERMISO p" +
            //                  "inner join ROL r on r.IdRol = p.IdRol" +
            //                  "inner join USUARIO u on u.IdRol = r.IdRol" +
            //                  "where u.IdUsuario = @IdUsuario";
            try
            {
                SqlCommand command = new SqlCommand(stringBuilder.ToString(), Connection);
                command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                command.CommandType = CommandType.Text;
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    permisoList.Add(Map(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return permisoList;
        }

        private Permiso Map(SqlDataReader reader)
        {
            Permiso permiso = new Permiso
            {
                NPermiso = Convert.ToString(reader["Permiso"]),
            };
            string IdRol = Convert.ToString(reader["IdRol"]);
            permiso.Rol = ObtenerRol(IdRol);

            return permiso;
        }

        private Rol ObtenerRol(string IdRol)
        {
            return rolRepository.CargarRegistro().Find(c => c.IdRol == IdRol);
        }
    }
}
