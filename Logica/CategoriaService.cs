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

        public void Guardar(Categoria categoria)
        {
            categoriaRepository.GuardarRegistros(categoria);
        }

        public DataTable CargarRegistros()
        {
            DataTable table = new DataTable();
            table = categoriaRepository.CargarRegistros();
            return table;
        }

        public void ModificarRegistros(Categoria categoria)
        {
            categoriaRepository.ModificarRegistros(categoria);
        }

        public void EliminarRegistros(Categoria categoria)
        {
            categoriaRepository.EliminarRegistros(categoria);
        }
    }
}
