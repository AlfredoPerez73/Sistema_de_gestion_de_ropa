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
    public class VentaRepository : ConexionRepository
    {
        private UsuarioRepository usuarioRepository = new UsuarioRepository();
        private ProductoRepository productoRepository = new ProductoRepository();

        public VentaRepository() : base()
        {

        }

        public int ObtenerCorrelativo()
        {
            int IdCorrelativo = 0;
            string Consulta = "SELECT COUNT(*) + 1 FROM VENTA";
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

        public bool ModificarStock(int IdProducto, int Cantidad, bool Estado)
        {
            bool Respuesta = false;
            StringBuilder stringBuilder = new StringBuilder();

            if (Estado)
            {
                stringBuilder.AppendLine("UPDATE PRODUCTO SET Stock = Stock + @Cantidad WHERE IdProducto = @IdProducto");
            }
            else
            {
                stringBuilder.AppendLine("UPDATE PRODUCTO SET Stock = Stock - @Cantidad WHERE IdProducto = @IdProducto");
            }

            try
            {
                SqlCommand command = new SqlCommand(stringBuilder.ToString(), Connection);
                command.Parameters.AddWithValue("@Cantidad", Cantidad);
                command.Parameters.AddWithValue("@IdProducto", IdProducto);
                command.CommandType = CommandType.Text;

                AbrirConnection();
                Respuesta = command.ExecuteNonQuery() > 0 ? true : false;
                CerrarConnection();
            }
            catch (Exception)
            {
                Respuesta = false;
            }
            return Respuesta;
        }

        public bool RegistrarVenta(Venta venta, DataTable DetalleVenta)
        {
            bool Respuesta = false;
            string Consulta = "RegistroVenta";
            try
            {
                SqlCommand command = new SqlCommand(Consulta, Connection);
                command.Parameters.AddWithValue("@IdUsuario", venta.Usuario.IdUser);
                command.Parameters.AddWithValue("@DocumentoVenta", venta.DocumentoVenta);
                command.Parameters.AddWithValue("@DocumentoCliente", venta.DocumentoCliente);
                command.Parameters.AddWithValue("@NombreCliente", venta.NombreCliente);
                command.Parameters.AddWithValue("@MontoPago", venta.MontoPago);
                command.Parameters.AddWithValue("@MontoCambio", venta.MontoCambio);
                command.Parameters.AddWithValue("@MontoTotal", venta.MontoTotal);
                command.Parameters.AddWithValue("@EDetalleVenta", DetalleVenta);
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

        public Venta CargarRegistroVenta(string NumDoc)
        {
            Venta venta = new Venta();
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("SELECT v.IdVenta, u.Usuario, v.DocumentoCliente,");
            stringBuilder.AppendLine("v.NombreCliente, v.DocumentoVenta, v.MontoPago, v.MontoCambio,");
            stringBuilder.AppendLine("v.MontoTotal, v.FechaRegistro FROM VENTA v");
            stringBuilder.AppendLine("inner join USUARIO u ON u.IdUsuario = v.IdUsuario");
            stringBuilder.AppendLine("WHERE v.DocumentoVenta = @NumDoc");
            try
            {
                SqlCommand command = new SqlCommand(stringBuilder.ToString(), Connection);
                command.Parameters.AddWithValue("@NumDoc", NumDoc);
                command.CommandType = CommandType.Text;
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    venta = MapVenta(reader);
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return venta;
        }

        public List<Detalle_Venta> CargarRegistroDetalleVenta(int IdVenta)
        {
            List<Detalle_Venta> detalleVentaList = new List<Detalle_Venta>();
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("SELECT p.NombreProducto, dv.PrecioVenta, dv.Cantidad,");
            stringBuilder.AppendLine("dv.SubTotal FROM DETALLE_VENTA dv");
            stringBuilder.AppendLine("inner join PRODUCTO p ON p.IdProducto = dv.IdProducto");
            stringBuilder.AppendLine("WHERE dv.IdVenta = @IdVenta");
            try
            {
                SqlCommand command = new SqlCommand(stringBuilder.ToString(), Connection);
                command.Parameters.AddWithValue("@IdVenta", IdVenta);
                command.CommandType = CommandType.Text;
                AbrirConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    detalleVentaList.Add(MapDetalleVenta(reader));
                }
                reader.Close();
                CerrarConnection();
            }
            catch (Exception)
            {
                return null;
            }
            return detalleVentaList;
        }

        public Venta MapVenta(SqlDataReader reader)
        {
            Venta venta = new Venta
            {
                IdVenta = Convert.ToInt32(reader["IdVenta"]),
                DocumentoVenta = Convert.ToString(reader["DocumentoVenta"]),
                DocumentoCliente = Convert.ToString(reader["DocumentoCliente"]),
                NombreCliente = Convert.ToString(reader["NombreCliente"]),
                MontoPago = Convert.ToDecimal(reader["MontoPago"]),
                MontoCambio = Convert.ToDecimal(reader["MontoCambio"]),
                MontoTotal = Convert.ToDecimal(reader["MontoTotal"]),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]),
            };
            string Usuario = Convert.ToString(reader["Usuario"]);
            venta.Usuario = ObtenerUsuario(Usuario);

            return venta;
        }

        public Detalle_Venta MapDetalleVenta(SqlDataReader reader)
        {
            Detalle_Venta DetalleVenta = new Detalle_Venta
            {
                PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]),
                Cantidad = Convert.ToInt32(reader["Cantidad"]),
                SubTotal = Convert.ToDecimal(reader["SubTotal"]),
            };
            string NombreProducto = Convert.ToString(reader["NombreProducto"]);
            DetalleVenta.Producto = ObtenerProducto(NombreProducto);

            return DetalleVenta;
        }

        private Usuario ObtenerUsuario(string NombreUsuario)
        {
            return usuarioRepository.CargarRegistro().Find(u => u.User == NombreUsuario);
        }

        private Producto ObtenerProducto(string NombreProducto)
        {
            return productoRepository.CargarRegistro().Find(pr => pr.NombreProducto == NombreProducto);
        }
    }
}
