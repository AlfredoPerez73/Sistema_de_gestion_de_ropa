using System;
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
                string Registro = "INSERT INTO PRODUCTO(IdProducto,NombreProducto,Marca,Stock,PrecioCompra,PrecioVenta,IdCategoria,TipoCategoria) VALUES" +
                    "('" + producto.IdProducto + "', '" + producto.NombreProducto + "', '" + producto.Marca + "', " + producto.Stock + ", " + producto.PrecioCompra + ", '" + producto.PrecioVenta + "', '" + producto.Categoria.IdCategoria + "', '" + producto.Categoria.TipoCategoria + "');";
                SqlCommand command = new SqlCommand(Registro, Connection);
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al registrar el producto...";
            }
            return $"Se ha registrado el producto {producto.NombreProducto}" +
                $"con la ID {producto.IdProducto}";
        }

        public string ModificarRegistros(Producto producto)
        {
            try
            {
                string Actualizar = "ModificarProductos";
                SqlCommand command = new SqlCommand(Actualizar, Connection);
                command.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
                command.Parameters.AddWithValue("@Marca", producto.Marca);
                command.Parameters.AddWithValue("@Stock", producto.Stock);
                command.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                command.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("@IdCategoria", producto.Categoria.IdCategoria);
                command.Parameters.AddWithValue("@TipoCategoria", producto.Categoria.TipoCategoria);
                command.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
                command.CommandType = CommandType.StoredProcedure;
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                return "Error al modificar el producto";
            }

            return $"Se ha modificar el producto {producto.NombreProducto}" +
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
                return "Error al eliminar el producto";
            }
            return $"Se ha eliminar el producto {producto.NombreProducto}" +
                $"con la ID {producto.IdProducto}";
        }

        private Producto Map(SqlDataReader reader)
        {
            Producto producto = new Producto
            {
                IdProducto = Convert.ToString(reader["IdProducto"]),
                NombreProducto = Convert.ToString(reader["NombreProducto"]),
                Marca = Convert.ToString(reader["Marca"]),
                Stock = Convert.ToInt32(reader["Stock"]),
                PrecioVenta = Convert.ToDecimal(reader["PrecioCompra"]),
                PrecioCompra = Convert.ToDecimal(reader["PrecioVenta"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
            };
            string IdCategoria = Convert.ToString(reader["IdCategoria"]);
            string TipoCategoria = Convert.ToString(reader["TipoCategoria"]);
            producto.Categoria = ObtenerCategoria(IdCategoria, TipoCategoria);

            return producto;
        }

        private Categoria ObtenerCategoria(string IdCategoria, string TipoCategoria)
        {
            return categoriaRepository.CargarRegistro().Find(c => c.IdCategoria == IdCategoria && c.TipoCategoria == TipoCategoria);
        }
    }
}
