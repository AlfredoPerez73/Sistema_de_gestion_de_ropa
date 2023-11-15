using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class VentaService
    {
        VentaRepository ventaRepository = new VentaRepository();

        public int ObtenerCorrelativo()
        {
            return ventaRepository.ObtenerCorrelativo();
        }

        public bool RegistrarVenta(Venta venta, DataTable DetalleCompra)
        {
            return ventaRepository.RegistrarVenta(venta, DetalleCompra);
        }

        public bool ModificarStock(int IdProducto, int Cantidad, bool Estado)
        {
            return ventaRepository.ModificarStock(IdProducto, Cantidad, Estado);
        }
    }
}
