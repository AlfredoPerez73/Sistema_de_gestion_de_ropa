using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Producto
    {
        public string IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Marca { get; set; }
        public int Stock { get; set; }
        public double PrecioUnitario { get; set; }
        public double PrecioTotal { get; set; }
        public Categoria IdCategoria { get; set; }
        public Categoria TipoCategoria { get; set; }
        public Proveedor IdProveedor { get; set; }
        
    }
}
