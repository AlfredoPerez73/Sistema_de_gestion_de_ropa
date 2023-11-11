using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Permiso
    {
        public int IdPermiso { get; set; }
        public string NPermiso { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Rol Rol { get; set; }
    }
}
