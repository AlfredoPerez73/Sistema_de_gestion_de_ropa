using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace Sistema_de_Gestion_GUI
{
    public partial class mdProducto : Form
    {
        private ProductoService productoService = new ProductoService();
        public Producto producto { get; set; }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public mdProducto()
        {
            InitializeComponent();
        }

        private void FrmDgtvCategorias_Load(object sender, EventArgs e)
        {
            RecargarRegistros(productoService.CargarRegistro());
            BorderRadius();
        }

        private void RecargarRegistros(List<Producto> productos)
        {
            tblRegistro.Rows.Clear();
            tblRegistro.Columns[1].Visible = false;

            foreach (var producto in productos)
            {
                int index = tblRegistro.Rows.Add();
                DataGridViewRow row = tblRegistro.Rows[index];
                row.Cells["IdProducto"].Value = producto.IdProducto;
                row.Cells["NombreProducto"].Value = producto.NombreProducto;
                row.Cells["Marca"].Value = producto.Marca;
                row.Cells["Stock"].Value = producto.Stock;
                row.Cells["PrecioVenta"].Value = producto.PrecioVenta;
                row.Cells["PrecioCompra"].Value = producto.PrecioCompra;
                row.Cells["FechaRegistro"].Value = producto.FechaRegistro.ToString("d");
            }
        }

        private void CargarProductosFiltrado()
        {
            var filtro = txtBuscarProducto.Texts;
            var list = productoService.BuscarX(filtro);
            RecargarRegistros(list);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tblRegistroCategoria_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (tblRegistro.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    producto = new Producto()
                    {
                        IdProducto = tblRegistro.Rows[index].Cells["IdProducto"].Value.ToString(),
                        NombreProducto = tblRegistro.Rows[index].Cells["NombreProducto"].Value.ToString()
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void tblRegistroCategoria_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check_circle.Width;
                var h = Properties.Resources.cross_circle.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check_circle, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void BorderRadius()
        {
            int radio = 20;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90);
            path.AddLine(radio, 0, this.Width - radio, 0);
            path.AddArc(this.Width - radio * 2, 0, radio * 2, radio * 2, 270, 90);
            path.AddLine(this.Width, radio, this.Width, this.Height - radio);
            path.AddArc(this.Width - radio * 2, this.Height - radio * 2, radio * 2, radio * 2, 0, 90);
            path.AddLine(this.Width - radio, this.Height, radio, this.Height);
            path.AddArc(0, this.Height - radio * 2, radio * 2, radio * 2, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void txtBuscarProducto_Enter(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Texts == "Buscar:")
            {
                txtBuscarProducto.Texts = "";
                txtBuscarProducto.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBuscarProducto_Leave(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Texts == "")
            {
                txtBuscarProducto.Texts = "Buscar:";
                txtBuscarProducto.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBuscarCategoria__TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Texts == "Buscar:")
            {
                RecargarRegistros(productoService.CargarRegistro());
            }
            else
            {
                CargarProductosFiltrado();
            }
        }
    }
}
