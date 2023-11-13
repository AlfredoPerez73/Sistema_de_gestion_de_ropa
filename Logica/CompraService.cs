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
    public class CompraService
    {
        private CompraRepository compraRepository = new CompraRepository();

        public int ObtenerCorrelativo()
        {
            return compraRepository.ObtenerCorrelativo();
        }

        public bool RegistrarCompra(Compra compra, DataTable DetalleCompra)
        {
            return compraRepository.RegistrarCompra(compra, DetalleCompra);
        }

        public Compra CargarRegistroCompra(string NumDoc)
        {
            var oCompra = compraRepository.CargarRegistroCompra(NumDoc);
            if (oCompra.IdCompra != 0)
            {
                List<Detalle_Compra> oDetalleCompra = compraRepository.CargarRegistroDetalleCompra(oCompra.IdCompra);
                oCompra.DetalleCompra = oDetalleCompra;
            }
            return oCompra;
        }
    }
}
