﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Logica
{
    public class PermisoService
    {
        PermisoRepository permisoRepository = new PermisoRepository();

        public List<Permiso> CargarRegistro(string IdUsuario)
        {
            return permisoRepository.CargarRegistro(IdUsuario);
        }
    }
}
