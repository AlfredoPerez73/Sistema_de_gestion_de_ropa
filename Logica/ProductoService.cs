using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class ProductoService
    {
        private ProductoRepository productoRepository = new ProductoRepository();

        public void Guardar(string IdProducto, string NombreProducto, string Marca, string Stock, string PrecioUnitario, string IdCategoria
            , string IdProveedor, string TipoCategoria)
        {
            productoRepository.GuardarRegistros(IdProducto, NombreProducto, Marca, Convert.ToInt32(Stock), Convert.ToDouble(PrecioUnitario), IdCategoria,
                IdProveedor, TipoCategoria);
        }

        public DataTable CargarRegistros()
        {
            DataTable table = new DataTable();
            table = productoRepository.CargarRegistros();
            return table;
        }

        public void ModificarRegistros(string NombreProducto, string Marca, string Stock, string PrecioUnitario, string IdCategoria
            , string IdProveedor, string TipoCategoria, string IdProducto)
        {
            productoRepository.ModificarRegistros(NombreProducto, Marca, Convert.ToInt32(Stock), Convert.ToDouble(PrecioUnitario), IdCategoria,
                IdProveedor, TipoCategoria, IdProducto);
        }

        public void EliminarRegistros(string IdProducto)
        {
            productoRepository.EliminarRegistros(IdProducto);
        }
    }
}
