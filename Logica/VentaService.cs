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

        public Venta CargarRegistroVenta(string NumDoc)
        {
            var oVenta = ventaRepository.CargarRegistroVenta(NumDoc);
            if (oVenta.IdVenta != 0)
            {
                List<Detalle_Venta> oDetalleVenta = ventaRepository.CargarRegistroDetalleVenta(oVenta.IdVenta);
                oVenta.DetalleVentaList = oDetalleVenta;
            }
            return oVenta;
        }
    }
}
