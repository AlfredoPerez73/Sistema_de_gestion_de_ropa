using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class CompraRepository : ConexionRepository
    {
        private UsuarioRepository usuarioRepository = new UsuarioRepository();
        private ProveedorRepository proveedorRepository = new ProveedorRepository();
        private ProductoRepository productoRepository = new ProductoRepository();

        public CompraRepository() : base()
        {

        }

        public int ObtenerCorrelativo()
        {
            int IdCorrelativo = 0;
            string Consulta = "SELECT COUNT(*) + 1 FROM COMPRA";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                AbrirConnection();

                IdCorrelativo = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception)
            {
                IdCorrelativo = 0;
            }
            return IdCorrelativo;
        }

        public Compra CargarRegistroCompra(string NumDoc)
        {
            Compra compra = new Compra();
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("SELECT c.IdCompra, u.Usuario, p.Documento, p.RazonSocial,");
            stringBuilder.AppendLine("c.DocumentoCompra, c.MontoTotal, c.FechaRegistro FROM COMPRA c");
            stringBuilder.AppendLine("inner join USUARIO u ON u.IdUsuario = c.IdUsuario");
            stringBuilder.AppendLine("inner join PROVEEDOR p ON p.IdProveedor = c.IdProveedor");
            stringBuilder.AppendLine("WHERE c.DocumentoCompra = @NumDoc");
            try
            {
                SqlCommand command = new SqlCommand(stringBuilder.ToString(), Connection);
                command.Parameters.AddWithValue("@NumDoc", NumDoc);
                command.CommandType = CommandType.Text;
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    compra = MapCompra(reader);
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return compra;
        }

        public List<Detalle_Compra> CargarRegistroDetalleCompra (int IdCompra)
        {
            List<Detalle_Compra> detalleCompraList = new List<Detalle_Compra>();
            StringBuilder stringBuilder = new StringBuilder();
            
            stringBuilder.AppendLine("SELECT p.NombreProducto,dc.PrecioCompra,dc.Cantidad,dc.MontoTotal");
            stringBuilder.AppendLine("FROM DETALLE_COMPRA dc");
            stringBuilder.AppendLine("inner join PRODUCTO p ON p.IdProducto = dc.IdProducto");
            stringBuilder.AppendLine("WHERE dc.IdCompra = @IdCompra");
            try
            {
                SqlCommand command = new SqlCommand(stringBuilder.ToString(), Connection);
                command.Parameters.AddWithValue("@IdCompra", IdCompra);
                command.CommandType = CommandType.Text;
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    detalleCompraList.Add(MapDetalleCompra(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return detalleCompraList;
        }

        public bool RegistrarCompra(Compra compra, DataTable DetalleCompra)
        {
            bool Respuesta = false;
            string Consulta = "RegistroCompra";
            try
            {
               SqlCommand command = new SqlCommand(Consulta, Connection);
                command.Parameters.AddWithValue("@IdUsuario", compra.Usuario.IdUser);
                command.Parameters.AddWithValue("@IdProveedor", compra.Proveedor.IdProveedor);
                command.Parameters.AddWithValue("@DocumentoCompra", compra.Documento);
                command.Parameters.AddWithValue("@MontoTotal", compra.MontoTotal);
                command.Parameters.AddWithValue("@EDetalleCompra", DetalleCompra);
                command.CommandType = CommandType.StoredProcedure;

                Respuesta = true;
                AbrirConnection();
                var index = command.ExecuteNonQuery();
                CerrarConnection();
            }
            catch (Exception)
            {
                Respuesta = false;
            }
            return Respuesta;
        }

        public Compra MapCompra(SqlDataReader reader)
        {
            Compra compra = new Compra
            {
                IdCompra = Convert.ToInt32(reader["IdCompra"]),
                Documento = Convert.ToString(reader["DocumentoCompra"]),
                MontoTotal = Convert.ToDecimal(reader["MontoTotal"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
            };
            string Usuario = Convert.ToString(reader["Usuario"]);
            compra.Usuario = ObtenerUsuario(Usuario);

            string Documento = Convert.ToString(reader["Documento"]);
            string RazonSocial = Convert.ToString(reader["RazonSocial"]);
            compra.Proveedor = ObtenerProveedor(Documento, RazonSocial);

            return compra;
        }

        public Detalle_Compra MapDetalleCompra(SqlDataReader reader)
        {
            Detalle_Compra DetalleCompra = new Detalle_Compra
            {
                PrecioCompra = Convert.ToDecimal(reader["PrecioCompra"]),
                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                MontoTotal = Convert.ToDecimal(reader["MontoTotal"])
            };
            string NombreProducto = Convert.ToString(reader["NombreProducto"]);
            DetalleCompra.Producto = ObtenerProducto(NombreProducto);

            return DetalleCompra;
        }

        private Usuario ObtenerUsuario(string NombreUsuario)
        {
            return usuarioRepository.CargarRegistro().Find(u => u.User == NombreUsuario);
        }

        private Proveedor ObtenerProveedor(string Documento, string RazonSocial)
        {
            return proveedorRepository.CargarRegistro().Find(p => p.Documento == Documento && p.RazonSocial == RazonSocial);
        }

        private Producto ObtenerProducto(string NombreProducto)
        {
            return productoRepository.CargarRegistro().Find(pr => pr.NombreProducto == NombreProducto);
        }
    }
}
