using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Compra
    {
        public string IdCompra { get; set; }
        public Usuario Usuario { get; set; }
        public Proveedor Proveedor { get; set; }
        public string Documento { get; set; }
        public decimal MontoTotal { get; set; }
    }
}
