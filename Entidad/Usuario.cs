using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario
    {
        public string IdUser { get; set; }
        public string Documento { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public Rol Rol { get; set; }
        public string Correo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
