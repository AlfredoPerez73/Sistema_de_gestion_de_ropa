using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Logica
{
    public class CategoriaService : ICrudService<Categoria>
    {
        private CategoriaRepository categoriaRepository = new CategoriaRepository();

        public string Guardar(Categoria categoria)
        {
            var msg = categoriaRepository.GuardarRegistros(categoria);
            return msg;
        }

        public bool BuscarID(int id)
        {
            return CargarRegistro().Any(c => c.IdCategoria == id);
        }

        public List<Categoria> BuscarX(string x)
        {
            return CargarRegistro()
                .Where(item => item.IdCategoria == Convert.ToInt32(x) || item.TipoCategoria.Contains(x.ToUpper())).ToList();
        }

        public List<Categoria> CargarRegistro()
        {
            var msg = categoriaRepository.CargarRegistro();
            return msg;
        }

        public string ModificarRegistros(Categoria categoria)
        {
            var msg = categoriaRepository.ModificarRegistros(categoria);
            return msg;
        }

        public string EliminarRegistros(Categoria categoria)
        {
            var msg = categoriaRepository.EliminarRegistros(categoria);
            return msg;
        }
    }
}
