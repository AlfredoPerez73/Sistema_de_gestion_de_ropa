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

        public bool LoginUser(string usuario, string contraseña)
        {
            return usuarioRepository.Login(usuario, contraseña);
        }

        public void GuardarRegistros(string IdUsuario, string Documento, string Usuario, string Contraseña, string Correo, string IdRol, string Rol)
        {
            usuarioRepository.GuardarRegistros(IdUsuario, Documento, Usuario, Contraseña, Correo, IdRol, Rol);
        }

        public DataTable CargarRegistros()
        {
            DataTable table = new DataTable();
            table = usuarioRepository.CargarRegistros();
            return table;
        }

        public void ModificarRegistros(string Usuario, string Contraseña, string Correo, string IdRol, string Rol, string IdUsuario)
        {
            usuarioRepository.ModificarRegistros(Usuario, Contraseña, Correo, IdRol, Rol, IdUsuario);
        }

        public void EliminarRegistros(string IdUsuario)
        {
            usuarioRepository.EliminarRegistros(IdUsuario);
        }
    }
}
