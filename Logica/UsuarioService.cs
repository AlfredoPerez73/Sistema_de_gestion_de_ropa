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

        public bool LoginUser(Usuario usuario)
        {
            return usuarioRepository.Login(usuario);
        }

        public void GuardarRegistros(Usuario usuario)
        {
            usuarioRepository.GuardarRegistros(usuario);
        }

        public DataTable CargarRegistros()
        {
            DataTable table = new DataTable();
            table = usuarioRepository.CargarRegistros();
            return table;
        }

        public void ModificarRegistros(Usuario usuario)
        {
            usuarioRepository.ModificarRegistros(usuario);
        }

        public void EliminarRegistros(Usuario usuario)
        {
            usuarioRepository.EliminarRegistros(usuario);
        }
    }
}
