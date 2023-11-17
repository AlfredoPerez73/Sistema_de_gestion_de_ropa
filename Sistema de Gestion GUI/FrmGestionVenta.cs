using Entidad;
using Logica;
using Sistema_de_Gestion_GUI.Modales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestion_GUI
{
    public partial class FrmGestionVenta : Form
    {
        private Usuario oUsuario;
        private bool allowEdit = false;
        decimal Precio = 0;

        public FrmGestionVenta(Usuario oUsuario)
        {
            InitializeComponent();
            this.oUsuario = oUsuario;
        }

        private void FrmGestionVenta_Load(object sender, EventArgs e)
        {
            CargarUsuario();
            BorderRadiusPanel(panel3, 25);
            BorderRadiusPanel(panel2, 20);
        }

        private void AgregarVenta()
        {
            bool ProductoExiste = false;

            if (txtIdProducto.Text == "")
            {
                MessageBox.Show($"Ingrese un producto", "Gestion de venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!decimal.TryParse(txtPrecioVenta.Texts, out Precio))
            {
                MessageBox.Show("Precio Venta - Formato de moneda incorrecto", "Gestion de venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtCantidad.Texts == "")
            {
                MessageBox.Show("Stock - Formato de moneda incorrecto", "Gestion de venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToInt32(txtStock.Texts) < Convert.ToInt32(txtCantidad.Texts.ToString()))
            {
                MessageBox.Show("Stock - No se puede vender mas de lo que hay" +
                    "almacen", "Gestion de venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow Fils in tblRegistro.Rows)
            {
                if (Fils.Cells["IdProducto"].Value.ToString() == txtIdProducto.Text)
                {
                    ProductoExiste = true;
                    break;
                }
            }
            if (!ProductoExiste)
            {
                tblRegistro.Rows.Add(new object[]
                {
                    textBox1.Text,
                    txtNombreProducto.Texts,
                    Precio.ToString("0.00"),
                    txtCantidad.Texts.ToString(),
                    (Convert.ToDecimal(txtCantidad.Texts) * Precio).ToString("0.00")
                });
            }
            CalcularPagoTotal();
            Limpiar();
            txtCodigo.Select();
        }

        private void RegistrarVenta()
        {
            if (txtIdCliente.Text == "")
            {
                MessageBox.Show($"Ingrese el documento del cliente", "Gestion de venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtCliente.Texts == "")
            {
                MessageBox.Show($"Ingrese el nombre del cliente", "Gestion de venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tblRegistro.Rows.Count < 1)
            {
                MessageBox.Show($"Debe ingresar un producto a la venta", "Gestion de venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable DetalleVenta = DetalleVentaTable();
            int IdCorrelativo = new VentaService().ObtenerCorrelativo();
            string NumDoc = string.Format("{0:00000}", IdCorrelativo);
            CalcularCambio();

            Venta venta = new Venta()
            {
                Usuario = new Usuario() { IdUser = oUsuario.IdUser },
                DocumentoVenta = NumDoc,
                DocumentoCliente = textBox2.Text,
                NombreCliente = txtCliente.Texts,
                MontoPago = Convert.ToDecimal(textBox3.Text),
                MontoCambio = Convert.ToDecimal(txtCambioVenta.Texts),
                MontoTotal = Convert.ToDecimal(txtTotalPagar.Texts),
                
            };

            bool Respuesta = new VentaService().RegistrarVenta(venta, DetalleVenta);
            if (Respuesta)
            {
                var result = MessageBox.Show($"Venta generada N° {NumDoc}", "Gestion de venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevo();
            }
            else
            {
                MessageBox.Show($"No se puedo generar la venta N° {NumDoc}", "Gestion de venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DataTable DetalleVentaTable()
        {
            DataTable DetalleCompra = new DataTable();
            DetalleCompra.Columns.Add("IdPorducto", typeof(int));
            DetalleCompra.Columns.Add("PrecioVenta", typeof(decimal));
            DetalleCompra.Columns.Add("Cantidad", typeof(int));
            DetalleCompra.Columns.Add("SubTotal", typeof(decimal));

            foreach (DataGridViewRow Rows in tblRegistro.Rows)
            {
                DetalleCompra.Rows.Add(new object[]
                {
                    Convert.ToInt32(Rows.Cells["IdProducto"].Value.ToString()),
                    Rows.Cells["PrecioVenta"].Value.ToString(),
                    Rows.Cells["Cantidad"].Value.ToString(),
                    Rows.Cells["SubTotal"].Value.ToString(),
                });
            }
            return DetalleCompra;
        }

        private void Limpiar()
        {
            txtCodigo.BackColor = Color.White;
            textBox1.BackColor = Color.White;

            txtIdProducto.Text = "";
            textBox1.Text = "";
            txtNombreProducto.Texts = "";
            txtStock.Texts = "";
            txtPrecioVenta.Texts = "";
            txtCantidad.Texts = "";
        }

        private void Nuevo()
        {
            Limpiar();

            txtDocumento.BackColor = Color.White;
            textBox2.BackColor = Color.White;

            txtIdCliente.Text = "";
            textBox2.Text = "";
            txtCliente.Texts = "";
            txtPagoVenta.Texts = "";
            txtCambioVenta.Texts = "";
            tblRegistro.Rows.Clear();
            CalcularPagoTotal();
        }

        private void CalcularPagoTotal()
        {
            decimal Total = 0;
            if (tblRegistro.Rows.Count > 0)
            {
                foreach (DataGridViewRow Rows in tblRegistro.Rows)
                {
                    Total += Convert.ToDecimal(Rows.Cells["SubTotal"].Value.ToString());
                }
            }
            txtTotalPagar.Texts = Total.ToString("0.00");
        }

        private void CalcularCambio()
        {
            decimal Pagacon;
            decimal Total = Convert.ToDecimal(txtTotalPagar.Texts);

            if (txtTotalPagar.Texts == "")
            {
                MessageBox.Show("Venta - No exiten los productos", "Gestion de venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox3.Text.Trim() == "")
            {
                textBox3.Text = "";
            }
            if (decimal.TryParse(textBox3.Text.Trim(), out Pagacon))
            {
                if (Pagacon < Total)
                {
                    txtCambioVenta.Texts = "0.00";
                }
                else
                {
                    decimal Cambio = Pagacon - Total;
                    txtCambioVenta.Texts = Cambio.ToString("0.00");
                }
            }
        }

        private void CargarUsuario()
        {
            txtFechaCompra.Texts = DateTime.Now.ToString("d");
        }

        private void mdProducto()
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtIdProducto.Text = modal.producto.IdProducto.ToString();
                    textBox1.Text = modal.producto.Codigo.ToString();
                    txtNombreProducto.Texts = modal.producto.NombreProducto.ToString();
                    txtPrecioVenta.Texts = modal.producto.PrecioVenta.ToString();
                    txtStock.Texts = modal.producto.Stock.ToString();
                }
                else
                {
                    txtDocumento.Select();
                }
            }
        }

        private void mdCliente()
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtIdCliente.Text = modal.clientes.IdCliente.ToString();
                    textBox2.Text = modal.clientes.Documento.ToString();
                    txtCliente.Texts = modal.clientes.NombreCliente.ToString();
                }
                else
                {
                    txtDocumento.Select();
                }
            }
        }

        private void BorderRadiusPanel(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90);
            path.AddLine(radio, 0, panel.Width - radio, 0);
            path.AddArc(panel.Width - radio * 2, 0, radio * 2, radio * 2, 270, 90);
            path.AddLine(panel.Width, radio, panel.Width, panel.Height - radio);
            path.AddArc(panel.Width - radio * 2, panel.Height - radio * 2, radio * 2, radio * 2, 0, 90);
            path.AddLine(panel.Width - radio, panel.Height, radio, panel.Height);
            path.AddArc(0, panel.Height - radio * 2, radio * 2, radio * 2, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.cross_circle.Width;
                var h = Properties.Resources.cross_circle.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.cross_circle, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblRegistro.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    tblRegistro.Rows.RemoveAt(index);
                    CalcularPagoTotal();
                    CalcularCambio();
                }
            }
        }

        private void FrmGestionVenta_Resize(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel3, 25);
            BorderRadiusPanel(panel2, 20);
        }

        private void txtPagoVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CalcularCambio();
            }
        }

        private void tblRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellContentClick(sender, e);
        }

        private void tblRegistro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            CellPainting(sender, e);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            mdCliente();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            mdProducto();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            AgregarVenta();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            RegistrarVenta();
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void rjTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPagoVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Cliente oCliente = new ClienteService().CargarRegistro().Where(c => c.Documento == textBox2.Text).FirstOrDefault();

                if (oCliente != null)
                {
                    txtDocumento.BackColor = Color.Honeydew;
                    textBox2.BackColor = Color.Honeydew;
                    txtIdCliente.Text = oCliente.IdCliente.ToString();
                    txtCliente.Texts = oCliente.NombreCliente;
                }
                else
                {
                    txtDocumento.BackColor = Color.MistyRose;
                    textBox2.BackColor = Color.MistyRose;
                    txtIdCliente.Text = "";
                    txtCliente.Texts = "";
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new ProductoService().CargarRegistro().Where(p => p.IdProducto == Convert.ToInt32(textBox1.Text)).FirstOrDefault();

                if (oProducto != null)
                {
                    txtCodigo.BackColor = Color.Honeydew;
                    textBox1.BackColor = Color.Honeydew;
                    txtIdProducto.Text = oProducto.IdProducto.ToString();
                    txtCodigo.Texts = oProducto.Codigo.ToString();
                    txtNombreProducto.Texts = oProducto.NombreProducto;
                    txtPrecioVenta.Texts = oProducto.PrecioVenta.ToString();
                    txtStock.Texts = oProducto.Stock.ToString();
                    txtCantidad.Select();
                }
                else
                {
                    txtCodigo.BackColor = Color.MistyRose;
                    textBox1.BackColor = Color.MistyRose;
                    txtIdProducto.Text = "";
                    txtCodigo.Texts = "";
                    txtNombreProducto.Texts = "";
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CalcularCambio();
            }
        }
    }
}
