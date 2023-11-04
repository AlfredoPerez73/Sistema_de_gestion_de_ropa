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
    public class UsuarioService : ICrudService<Usuario>
    {
        private UsuarioRepository usuarioRepository = new UsuarioRepository();

        public bool LoginUser(Usuario usuario)
        {
            return usuarioRepository.Login(usuario);
        }

        public bool BuscarID(Usuario usuario)
        {
            return usuarioRepository.BuscarID(usuario);
        }

        public string Guardar(Usuario usuario)
        {
            var msg = usuarioRepository.GuardarRegistros(usuario);
            return msg;
        }

        public List<Usuario> CargarRegistro()
        {
            var msg = usuarioRepository.CargarRegistro();
            return msg;
        }

        public string ModificarRegistros(Usuario usuario)
        {
            var msg = usuarioRepository.ModificarRegistros(usuario);
            return msg;
        }

        public string EliminarRegistros(Usuario usuario)
        {
            var msg = usuarioRepository.EliminarRegistros(usuario);
            return msg;
        }
    }
}
