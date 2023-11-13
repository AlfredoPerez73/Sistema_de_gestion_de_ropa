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

        public bool BuscarID(string id)
        {
            return CargarRegistro().Any(c => c.TipoCategoria == id.ToUpper());
        }

        public List<Categoria> BuscarX(string x)
        {
            int idCategoria;
            List<Categoria> categorias = CargarRegistro();
            if (int.TryParse(x, out idCategoria))
            {
                categorias = categorias
                    .Where(item => item.IdCategoria == idCategoria).ToList();
            }
            else
            {
                categorias = categorias
                    .Where(item => item.TipoCategoria.Contains(x.ToUpper())).ToList();
            }
            return categorias;
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
