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
    public class RolRepository : ConexionRepository
    {
        SqlDataReader reader;
        SqlCommand command = new SqlCommand();

        public RolRepository() : base()
        {

        }

        public List<Rol> CargarRegistro()
        {
            List<Rol> rolList = new List<Rol>();
            string Consulta = "SELECT * FROM ROL";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    rolList.Add(Map(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return rolList;
        }

        private Rol Map(SqlDataReader reader)
        {
            Rol rol = new Rol
            {
                IdRol = Convert.ToString(reader["IdRol"]),
                NRol = Convert.ToString(reader["Rol"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
            };

            return rol;
        }
    }
}
