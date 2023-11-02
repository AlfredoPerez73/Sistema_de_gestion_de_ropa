using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public interface ICrudService
    {
        string Guardar(Producto producto);
        List<Producto> CargarRegistro();
        string ModificarRegistros(Producto producto);
        string EliminarRegistros(Producto producto);
    }
}
