﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Detalle_Compra
    {
        public int IdDetalleCompra { get; set; }
        public Compra Compra { get; set; }
        public Producto Producto { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoTotal { get; set; }
    }
}
