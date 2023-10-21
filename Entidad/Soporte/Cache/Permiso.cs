using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public struct Permiso
    {
        public string IdPermiso { get; set; }
        public const string Administrador = "ADMINISTRADOR";
        public const string Empleado = "EMPLEADO";
    }
}
