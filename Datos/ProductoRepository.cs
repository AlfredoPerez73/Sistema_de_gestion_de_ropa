﻿using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class ProductoRepository : ConexionRepository
    {
        private CategoriaRepository categoriaRepository = new CategoriaRepository();

        public ProductoRepository() : base()
        {

        }

        public List<Producto> CargarRegistro()
        {
            List<Producto> productoList = new List<Producto>();
            string Consulta = "SELECT * FROM PRODUCTO";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    productoList.Add(Map(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return productoList;
        }

        public string GuardarRegistros(Producto producto)
        {
            try
            {
                string Registro = "INSERT INTO PRODUCTO(Codigo,NombreProducto,Marca,IdCategoria,TipoCategoria) VALUES" +
                    "('" + producto.Codigo + "','" + producto.NombreProducto + "', '" + producto.Marca + "', '" + producto.Categoria.IdCategoria + "', '" + producto.Categoria.TipoCategoria + "');";
                SqlCommand command = new SqlCommand(Registro, Connection);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return $"Se ha registrado el producto {producto.NombreProducto}";
        }

        public string ModificarRegistros(Producto producto)
        {
            //try
            //{
                string Actualizar = "ModificarProductos";
                SqlCommand command = new SqlCommand(Actualizar, Connection);
                command.Parameters.AddWithValue("@Codigo", producto.Codigo);
                command.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
                command.Parameters.AddWithValue("@Marca", producto.Marca);
                command.Parameters.AddWithValue("@IdCategoria", producto.Categoria.IdCategoria);
                command.Parameters.AddWithValue("@TipoCategoria", producto.Categoria.TipoCategoria);
                command.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
                command.CommandType = CommandType.StoredProcedure;
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            //}
            //catch (Exception)
            //{
            //    return "Error al modificar el producto, " +
            //        "el producto se encuentra relacionada con una compra o venta";
            //}

            return $"Se ha modificado el producto {producto.NombreProducto} " +
                $"con la ID {producto.IdProducto}";
        }

        public string EliminarRegistros(Producto producto)
        {
            try
            {
                string Eliminar = "EliminarProductos";

                SqlCommand command = new SqlCommand(Eliminar, Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al eliminar el producto, " +
                    "el producto se encuentra relacionada con una compra o venta";
            }
            return $"Se ha eliminado el producto {producto.NombreProducto} " +
                $"con la ID {producto.IdProducto}";
        }

        private Producto Map(SqlDataReader reader)
        {
            Producto producto = new Producto
            {
                IdProducto = Convert.ToInt32(reader["IdProducto"]),
                Codigo = Convert.ToString(reader["Codigo"]),
                NombreProducto = Convert.ToString(reader["NombreProducto"]),
                Marca = Convert.ToString(reader["Marca"]),
                Stock = Convert.ToInt32(reader["Stock"]),
                PrecioVenta = Convert.ToDecimal(reader["PrecioCompra"]),
                PrecioCompra = Convert.ToDecimal(reader["PrecioVenta"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
            };
            int IdCategoria = Convert.ToInt16(reader["IdCategoria"]);
            string TipoCategoria = Convert.ToString(reader["TipoCategoria"]);
            producto.Categoria = ObtenerCategoria(IdCategoria, TipoCategoria);

            return producto;
        }

        private Categoria ObtenerCategoria(int IdCategoria, string TipoCategoria)
        {
            return categoriaRepository.CargarRegistro().Find(c => c.IdCategoria == IdCategoria && c.TipoCategoria == TipoCategoria);
        }
    }
}
