using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;
using Sistema_de_Gestion_GUI.Modales;

namespace Sistema_de_Gestion_GUI
{
    public partial class FrmGestionCompra : Form
    {
        private Usuario oUsuario;

        private bool allowEdit = false;
        decimal precioCompra = 0;
        decimal precioVenta = 0;

        public FrmGestionCompra(Usuario oUsuario)
        {
            InitializeComponent();
            this.oUsuario = oUsuario;
        }

        private void FrmGestionCompra_Load(object sender, EventArgs e)
        {
            CargarUsuario();
            BorderRadiusPanel(panel3, 25);
            BorderRadiusPanel(panel2, 20);
        }

        private void AgregarProducto()
        {
            bool ProductoExiste = false;

            if (txtIdProducto.Text == "")
            {
                MessageBox.Show($"Ingrese un producto", "Gestion de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!decimal.TryParse(txtPrecioCompra.Texts, out precioCompra))
            {
                MessageBox.Show("Precio Compra - Formato de moneda incorrecto", "Gestion de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!decimal.TryParse(txtPrecioVenta.Texts, out precioVenta))
            {
                MessageBox.Show("Precio Venta - Formato de moneda incorrecto", "Gestion de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtIdProducto.Text,
                    txtNombreProducto.Texts,
                    precioCompra.ToString("0.00"),
                    precioVenta.ToString("0.00"),
                    txtCantidad.Texts.ToString(),
                    (Convert.ToDecimal(txtCantidad.Texts) * precioCompra).ToString("0.00")
                });
            }
            CalcularPagoTotal();
            Limpiar();
            txtCodigo.Select();

        }

        private void RegistrarCompra()
        {
            if (txtIdProveedor.Text == "")
            {
                MessageBox.Show($"Ingrese un proveedor", "Gestion de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tblRegistro.Rows.Count < 1)
            {
                MessageBox.Show($"Debe ingresar un producto a la compra", "Gestion de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable DetalleCompra = DetalleCompraTable();
            int IdCorrelativo = new CompraService().ObtenerCorrelativo();
            string NumDoc = string.Format("{0:00000}", IdCorrelativo);

            Compra compra = new Compra()
            {
                Usuario = new Usuario() { IdUser = oUsuario.IdUser },
                Proveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtIdProveedor.Text) },
                Documento = NumDoc,
                MontoTotal = Convert.ToDecimal(txtTotalPagar.Texts)
            };

            bool Respuesta = new CompraService().RegistrarCompra(compra, DetalleCompra);
            if (Respuesta)
            {
                MessageBox.Show($"Compra generada N° {NumDoc}. ¿Deseas ver la factura de la compra?", "Gestion de compra", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Nuevo();
            }
            else
            {
                MessageBox.Show($"No se puedo generar la compra N° {NumDoc}", "Gestion de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Limpiar()
        {
            txtDocumento.BackColor = Color.White;
            textBox2.BackColor = Color.White;

            textBox1.Text = "";
            txtNombreProducto.Texts = "";
            txtPrecioCompra.Texts = "";
            txtPrecioVenta.Texts = "";
            txtCantidad.Texts = "";
        }

        private void Nuevo()
        {
            Limpiar();

            txtDocumento.BackColor = Color.White;
            textBox2.BackColor = Color.White;

            txtIdProveedor.Text = "";
            textBox2.Text = "";
            txtProveedor.Texts = "";
            tblRegistro.Rows.Clear();
            CalcularPagoTotal();
        }

        private DataTable DetalleCompraTable()
        {
            DataTable DetalleCompra = new DataTable();
            DetalleCompra.Columns.Add("IdProducto", typeof(int));
            DetalleCompra.Columns.Add("PrecioCompra", typeof(decimal));
            DetalleCompra.Columns.Add("PrecioVenta", typeof(decimal));
            DetalleCompra.Columns.Add("Cantidad", typeof(int));
            DetalleCompra.Columns.Add("MontoTotal", typeof(decimal));

            foreach (DataGridViewRow Rows in tblRegistro.Rows)
            {
                DetalleCompra.Rows.Add(new object[]
                {
                    Convert.ToInt32(Rows.Cells["IdProducto"].Value.ToString()),
                    Rows.Cells["PrecioCompra2"].Value.ToString(),
                    Rows.Cells["PrecioVenta2"].Value.ToString(),
                    Rows.Cells["Cantidad"].Value.ToString(),
                    Rows.Cells["SubTotal"].Value.ToString(),
                });
            }
            return DetalleCompra;
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

        private void CargarUsuario()
        {
            txtFechaCompra.Texts = DateTime.Now.ToString("d");
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 6)
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
                }
                else
                {
                    textBox1.Select();
                }
            }
        }

        private void mdProveedor()
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtIdProveedor.Text = modal.proveedor.IdProveedor.ToString();
                    textBox2.Text = modal.proveedor.Documento.ToString();
                    txtProveedor.Texts = modal.proveedor.RazonSocial.ToString();
                }
                else
                {
                    textBox2.Select();
                }
            }
        }

        private void tblRegistro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            CellPainting(sender, e);
        }

        private void tblRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellContentClick(sender, e);
        }

        private void btnRegistrarCompra_Click_1(object sender, EventArgs e)
        {
            RegistrarCompra();
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            mdProducto();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            mdProveedor();
        }

        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void rjTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtFechaCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmGestionCompra_Resize(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel3, 25);
            BorderRadiusPanel(panel2, 20);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new ProductoService().CargarRegistro().Where(p => p.Codigo == textBox1.Text).FirstOrDefault();

                if (oProducto != null)
                {
                    txtCodigo.BackColor = Color.Honeydew;
                    textBox1.BackColor = Color.Honeydew;
                    txtIdProducto.Text = oProducto.IdProducto.ToString();
                    txtCodigo.Texts = oProducto.Codigo.ToString();
                    txtNombreProducto.Texts = oProducto.NombreProducto;
                    txtPrecioCompra.Select();
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Proveedor oProveedor = new ProveedorService().CargarRegistro().Where(p => p.Documento == textBox2.Text).FirstOrDefault();

                if (oProveedor != null)
                {
                    txtDocumento.BackColor = Color.Honeydew;
                    textBox2.BackColor = Color.Honeydew;
                    txtIdProveedor.Text = oProveedor.IdProveedor.ToString();
                    txtDocumento.Texts = oProveedor.Documento;
                    txtProveedor.Texts = oProveedor.RazonSocial;
                    txtPrecioCompra.Select();
                }
                else
                {
                    txtDocumento.BackColor = Color.MistyRose;
                    textBox2.BackColor = Color.MistyRose;
                    txtIdProveedor.Text = "";
                    txtDocumento.Texts = "";
                    txtProveedor.Texts = "";
                }
            }
        }
    }
}
