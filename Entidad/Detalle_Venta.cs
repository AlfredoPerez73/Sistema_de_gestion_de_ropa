﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Detalle_Venta
    {
        public string IdDetalleCompra { get; set; }
        public Venta Venta { get; set; }
        public Producto Producto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
    }
}
