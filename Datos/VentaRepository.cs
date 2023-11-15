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
        private ClienteRepository clienteRepository = new ClienteRepository();
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
    }
}
