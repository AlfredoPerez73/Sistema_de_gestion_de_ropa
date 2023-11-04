using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Logica
{
    public class ProveedorService : ICrudService<Proveedor>
    {
        private ProveedorRepository proveedorRepository = new ProveedorRepository();

        public string Guardar(Proveedor proveedor)
        {
            var msg = proveedorRepository.GuardarRegistros(proveedor);
            return msg;
        }

        public bool BuscarID(Proveedor proveedor)
        {
            var msg = proveedorRepository.BuscarProducto(proveedor);
            return msg;
        }

        public List<Proveedor> CargarRegistro()
        {
            var msg = proveedorRepository.CargarRegistro();
            return msg;
        }

        public string ModificarRegistros(Proveedor proveedor)
        {
            var msg = proveedorRepository.ModificarRegistros(proveedor);
            return msg;
        }

        public string EliminarRegistros(Proveedor proveedor)
        {
            var msg = proveedorRepository.EliminarRegistros(proveedor);
            return msg;
        }
    }
}
