﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class ProductoService : ICrudService<Producto>
    {
        private ProductoRepository productoRepository = new ProductoRepository();

        public string Guardar(Producto producto)
        {
            var msg = productoRepository.GuardarRegistros(producto);
            return msg;
        }

        public bool ValidarRegistrosDuplicados(string id)
        {
            return CargarRegistro().Any(p => p.IdProducto == id); 
        }

        public List<Producto> CargarRegistro()
        {
            var msg = productoRepository.CargarRegistro();
            return msg;
        }

        public string ModificarRegistros(Producto producto)
        {
            var msg = productoRepository.ModificarRegistros(producto);
            return msg;
        }

        public string EliminarRegistros(Producto producto)
        {
            var msg = productoRepository.EliminarRegistros(producto);
            return msg;
        }
    }
}
