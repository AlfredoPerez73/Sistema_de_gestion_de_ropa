﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Venta
    {
        public string IdVenta { get; set; }
        public Usuario Usuario { get; set; }
        public string Documento { get; set; }
        public string NombreCliente { get; set; }
        public decimal MontoPago { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public List<Detalle_Venta> DetalleVentaList { get; set; }
    }
}