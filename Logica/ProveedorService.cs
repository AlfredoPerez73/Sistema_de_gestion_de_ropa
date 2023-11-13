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
            return CargarRegistro().Any(pr => pr.Documento == id);
        }

        public List<Proveedor> CargarRegistro()
        {
            var msg = proveedorRepository.CargarRegistro();
            return msg;
        }

        public List<Proveedor> BuscarX(string x)
        {
            int idProveedor;
            List<Proveedor> proveedores = CargarRegistro();
            if (int.TryParse(x, out idProveedor))
            {
                proveedores = proveedores
                    .Where(item => item.IdProveedor == idProveedor).ToList();
            }
            else
            {
                proveedores = proveedores
                    .Where(item => item.Documento.Contains(x.ToUpper()) || item.RazonSocial.Contains(x.ToUpper())
                    || item.Telefono.Contains(x.ToUpper())).ToList();
            }
            return proveedores;
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
