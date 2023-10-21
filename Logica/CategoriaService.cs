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
    public class CategoriaService
    {
        private CategoriaRepository categoriaRepository = new CategoriaRepository();

        public void Guardar(string IdCategoria, string TipoCategoria)
        {
            categoriaRepository.GuardarRegistros(IdCategoria, TipoCategoria);
        }

        public DataTable CargarRegistros()
        {
            DataTable table = new DataTable();
            table = categoriaRepository.CargarRegistros();
            return table;
        }

        public void ModificarRegistros(string TipoCategoria, string IdCategoria)
        {
            categoriaRepository.ModificarRegistros(TipoCategoria, IdCategoria);
        }

        public void EliminarRegistros(string IdCategoria)
        {
            categoriaRepository.EliminarRegistros(IdCategoria);
        }
    }
}
