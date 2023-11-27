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
    public class UsuarioService
    {
        private UsuarioRepository usuarioRepository = new UsuarioRepository();

        public bool BuscarID(string id)
        {
            return CargarRegistro().Any(u => u.Documento == id);
        }

        public string Guardar(Usuario usuario)
        {
            var msg = usuarioRepository.GuardarRegistros(usuario);
            return msg;
        }

        public List<Usuario> LoginUser(string user, string password)
        {
            return CargarRegistro().Where(u => u.User == user && u.Password == password).ToList();
        }

        public List<Usuario> CargarRegistro()
        {
            var msg = usuarioRepository.CargarRegistro();
            return msg;
        }

        public List<Usuario> BuscarX(string x)
        {
            int idUsuario;
            List<Usuario> usuarios = CargarRegistro();
            if (int.TryParse(x, out idUsuario))
            {
                usuarios = usuarios
                    .Where(item => item.IdUser == idUsuario).ToList();
            }
            else
            {
                usuarios = usuarios
                    .Where(item => item.Documento.Contains(x.ToUpper()) || item.User.Contains(x.ToUpper())
                    || item.Rol.NRol.Contains(x.ToUpper())).ToList();
            }
            return usuarios;
        }

        public string EliminarRegistros(Usuario usuario)
        {
            var msg = usuarioRepository.EliminarRegistros(usuario);
            return msg;
        }
    }
}
