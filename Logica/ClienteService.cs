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
            return CargarRegistro().Any(cl => cl.Documento == id);
        }

        public List<Cliente> BuscarX(string x)
        {
            int idCliente;
            List<Cliente> clientes = CargarRegistro();
            if (int.TryParse(x, out idCliente))
            {
                clientes = clientes
                    .Where(item => item.IdCliente == idCliente).ToList();
            }
            else
            {
                clientes = clientes
                    .Where(item => item.NombreCliente.Contains(x.ToUpper()) || item.Documento.Contains(x.ToUpper())
                    || item.Telefono.Contains(x.ToUpper())).ToList();
            }
            return clientes;
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
