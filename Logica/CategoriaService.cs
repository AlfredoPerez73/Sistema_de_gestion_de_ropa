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
    public class CategoriaService : ICrudService<Categoria>
    {
        private CategoriaRepository categoriaRepository = new CategoriaRepository();

        public string Guardar(Categoria categoria)
        {
            var msg = categoriaRepository.GuardarRegistros(categoria);
            return msg;
        }

        public bool BuscarID(Categoria categoria)
        {
            return categoriaRepository.BuscarCategoria(categoria);
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
