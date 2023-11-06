using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Globalization;

namespace Logica
{
    public class ClienteService : ICrudService<Cliente>
    {
        private ClienteRepository clienteRepository = new ClienteRepository();

        public string Guardar(Cliente cliente)
        {
            var msg = clienteRepository.GuardarRegistros(cliente);
            return msg;
        }

        public List<Cliente> CargarRegistro()
        {
            var msg = clienteRepository.CargarRegistro();
            return msg;
        }

        public bool BuscarID(string id)
        {
            return CargarRegistro().Any(cl => cl.IdCliente == id);
        }

        public List<Cliente> BuscarX(string x)
        {
            return CargarRegistro()
                .Where(item => item.IdCliente == x || item.Documento == x || item.NombreCliente.Contains(x.ToUpper()) 
                || item.Telefono.Contains(x)).ToList();
        }

        public string ModificarRegistros(Cliente cliente)
        {
            var msg = clienteRepository.ModificarRegistros(cliente);
            return msg;
        }

        public string EliminarRegistros(Cliente cliente)
        {
            var msg = clienteRepository.EliminarRegistros(cliente);
            return msg;
        }
    }
}
