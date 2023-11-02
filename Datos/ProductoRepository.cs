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
        SqlDataReader reader;
        DataTable table = new DataTable();
        SqlCommand command = new SqlCommand();

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
                Abrir();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    productoList.Add(Map(reader));
                }
                reader.Close();
                Cerrar();
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
                Abrir();
                var index = command.ExecuteNonQuery();
                Cerrar();
            }
            catch (Exception)
            {
                return "Error al registrar el producto";
            }

            return $"Se ha registrado el producto {producto.NombreProducto} " +
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
                Abrir();
                var index = command.ExecuteNonQuery();
                Cerrar();
            }
            catch (Exception)
            {
                return "Error al modificar el producto";
            }

            return $"Se ha modificar el producto {producto.NombreProducto} " +
                $"con la ID {producto.IdProducto}";
            //command.Connection = AbrirConnection();
            //command.CommandText = "ModificarProductos";
            //command.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
            //command.Parameters.AddWithValue("@Marca", producto.Marca);
            //command.Parameters.AddWithValue("@Stock", producto.Stock);
            //command.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
            //command.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
            //command.Parameters.AddWithValue("@IdCategoria", producto.Categoria.IdCategoria);
            //command.Parameters.AddWithValue("@TipoCategoria", producto.Categoria.TipoCategoria);
            //command.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
            //command.CommandType = CommandType.StoredProcedure;
            //command.ExecuteNonQuery();
            //command.Parameters.Clear();
        }

        public string EliminarRegistros(Producto producto)
        {
            try
            {
                string Registro = "EliminarProductos";

                SqlCommand command = new SqlCommand(Registro, Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
                Abrir();
                var index = command.ExecuteNonQuery();
                Cerrar();
            }
            catch (Exception)
            {
                return "Error al eliminar el producto";
            }

            return $"Se ha eliminar el producto {producto.NombreProducto} " +
                $"con la ID {producto.IdProducto}";
            //command.Connection = AbrirConnection();
            //command.CommandText = "EliminarProductos";
            //command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
            //command.ExecuteNonQuery();
            //command.Parameters.Clear();
        }

        private Producto Map(SqlDataReader reader)
        {
            Producto producto = new Producto
            {
                IdProducto = Convert.ToString(reader["IdProducto"]),
                Categoria = new Categoria
                {
                    IdCategoria = Convert.ToString(reader["IdCategoria"]),
                    TipoCategoria = Convert.ToString(reader["TipoCategoria"])
                },
                NombreProducto = Convert.ToString(reader["NombreProducto"]),
                Marca = Convert.ToString(reader["Marca"]),
                Stock = Convert.ToInt32(reader["Stock"]),
                PrecioVenta = Convert.ToDecimal(reader["PrecioCompra"]),
                PrecioCompra = Convert.ToDecimal(reader["PrecioVenta"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
            };
           
            return producto;
        }
    }
}
