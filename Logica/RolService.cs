using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Logica
{
    public class RolService
    {
        RolRepository rolRepository = new RolRepository();

        public List<Rol> CargarRegistro()
        {
            return rolRepository.CargarRegistro();
        }
    }
}
