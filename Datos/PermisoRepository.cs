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
        public PermisoRepository() : base()
        {

        }

        public Permiso BuscarPermiso(Permiso permiso)
        {
            try
            {
                string ID = "select * from PERMISO where Rol=@Rol";
                SqlCommand command = new SqlCommand(ID, Connection);
                command.Parameters.AddWithValue("@Rol", permiso.Rol.NRol);
                command.CommandType = CommandType.Text;
                AbrirConnection();
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Permiso oPermiso = new Permiso
                        {
                            IdPermiso = reader.GetString(0),
                            NPermiso = reader.GetString(1),
                            Rol = new Rol
                            {
                                IdRol = reader.GetString(3),
                                NRol = reader.GetString(4)
                            }
                        };
                        return oPermiso;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
