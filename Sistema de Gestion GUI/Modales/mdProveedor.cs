using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidad;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace Sistema_de_Gestion_GUI.Modales
{
    public partial class mdProveedor : Form
    {
        private ProveedorService proveedorService = new ProveedorService();
        public Proveedor proveedor { get; set; }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public mdProveedor()
        {
            InitializeComponent();
        }

        private void RecargarRegistros(List<Proveedor> proveedores)
        {
            tblRegistroProveedores.Rows.Clear();

            foreach (var proveedor in proveedores)
            {
                int index = tblRegistroProveedores.Rows.Add();
                DataGridViewRow row = tblRegistroProveedores.Rows[index];
                row.Cells["Documento"].Value = proveedor.Documento;
                row.Cells["RazonSocial"].Value = proveedor.RazonSocial;
                row.Cells["FechaRegistro"].Value = proveedor.FechaRegistro.ToString("d");
            }
        }

        private void CargarProveedoresFiltrado()
        {
            var filtro = txtBuscarProveedor.Texts;
            var list = proveedorService.BuscarX(filtro);
            RecargarRegistros(list);
        }

        private void FrmDgtvProveedores_Load(object sender, EventArgs e)
        {
            RecargarRegistros(proveedorService.CargarRegistro());
            BorderRadius();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tblRegistroProveedores_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (tblRegistroProveedores.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    proveedor = new Proveedor()
                    {
                        Documento = tblRegistroProveedores.Rows[index].Cells["Documento"].Value.ToString(),
                        RazonSocial = tblRegistroProveedores.Rows[index].Cells["RazonSocial"].Value.ToString(),
                        FechaRegistro = Convert.ToDateTime(tblRegistroProveedores.Rows[index].Cells["FechaRegistro"].Value.ToString())
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void tblRegistroProveedores_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void txtBuscarProveedor_Enter(object sender, EventArgs e)
        {
            if (txtBuscarProveedor.Texts == "Buscar:")
            {
                txtBuscarProveedor.Texts = "";
                txtBuscarProveedor.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBuscarProveedor_Leave(object sender, EventArgs e)
        {
            if (txtBuscarProveedor.Texts == "Buscar:")
            {
                txtBuscarProveedor.Texts = "";
                txtBuscarProveedor.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBuscarProveedor__TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarProveedor.Texts == "Buscar:")
            {
                RecargarRegistros(proveedorService.CargarRegistro());
            }
            else
            {
                CargarProveedoresFiltrado();
            }
        }
    }
}
