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
    public class ProveedorService
    {
        private ProveedorRepository proveedorRepository = new ProveedorRepository();

        public void Guardar(Proveedor proveedor)
        {
            proveedorRepository.GuardarRegistros(proveedor);
        }

        public DataTable CargarRegistros()
        {
            DataTable table = new DataTable();
            table = proveedorRepository.CargarRegistros();
            return table;
        }

        public void ModificarRegistros(Proveedor proveedor)
        {
            proveedorRepository.ModificarRegistros(proveedor);
        }

        public void EliminarRegistros(Proveedor proveedor)
        {
            proveedorRepository.EliminarRegistros(proveedor);
        }
    }
}
