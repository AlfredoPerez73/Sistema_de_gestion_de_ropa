using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Permiso
    {
        public string IdPermiso { get; set; }
        public Rol Rol { get; set; }
        public string NPermiso { get; set; }
    }
}
