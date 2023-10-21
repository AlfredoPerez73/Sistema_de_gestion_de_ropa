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

        public void Guardar(string IdProveedor, string Documento, string RazonSocial, string Correo, string Telefono)
        {
            proveedorRepository.GuardarRegistros(IdProveedor, Documento, RazonSocial, Correo, Telefono);
        }

        public DataTable CargarRegistros()
        {
            DataTable table = new DataTable();
            table = proveedorRepository.CargarRegistros();
            return table;
        }

        public void ModificarRegistros(string Documento, string RazonSocial, string Correo, string Telefono, string IdProveedor)
        {
            proveedorRepository.ModificarRegistros(Documento, RazonSocial, Correo, Telefono, IdProveedor);
        }

        public void EliminarRegistros(string IdProveedo)
        {
            proveedorRepository.EliminarRegistros(IdProveedo);
        }
    }
}
