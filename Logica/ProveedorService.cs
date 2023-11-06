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

        public bool BuscarID(string id)
        {
            return CargarRegistro().Any(pr => pr.IdProveedor == id);
        }

        public List<Proveedor> CargarRegistro()
        {
            var msg = proveedorRepository.CargarRegistro();
            return msg;
        }

        public List<Proveedor> BuscarX(string x)
        {
            return CargarRegistro()
                .Where(item => item.IdProveedor == x || item.Documento == x || item.RazonSocial.Contains(x.ToUpper())).ToList();
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
