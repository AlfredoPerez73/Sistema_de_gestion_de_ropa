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

namespace Sistema_de_Gestion_GUI.Modales
{
    public partial class FrmDgtvProveedores : Form
    {
        private ProveedorService proveedorService = new ProveedorService();
        public Proveedor proveedor { get; set; }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FrmDgtvProveedores()
        {
            InitializeComponent();
        }

        private void RecargarRegistros()
        {
            var proveedores = new ProveedorService().CargarRegistro();
            tblRegistroProveedores.Rows.Clear();
            tblRegistroProveedores.Rows.Add();
            DataGridViewRow row = tblRegistroProveedores.Rows[tblRegistroProveedores.Rows.Count - 1];

            foreach (var proveedor in proveedores)
            {
                row.Cells["IdProveedor"].Value = proveedor.IdProveedor;
                row.Cells["Documento"].Value = proveedor.Documento;
                row.Cells["RazonSocial"].Value = proveedor.RazonSocial;
                row.Cells["Correo"].Value = proveedor.Correo;
                row.Cells["Telefono"].Value = proveedor.Telefono;
                row.Cells["FechaRegistro"].Value = proveedor.FechaRegistro.ToString("d");

                tblRegistroProveedores.Rows.Add();
                row = tblRegistroProveedores.Rows[tblRegistroProveedores.Rows.Count - 1];
            }
            tblRegistroProveedores.Rows.RemoveAt(tblRegistroProveedores.Rows.Count - 1);

        }

        private void CargarEstablecimientosFiltrado(string filtro)
        {
            //tblRegistroProveedores.DataSource = proveedorService.ConsultarFiltrado(filtro);
        }

        private void FrmDgtvProveedores_Load(object sender, EventArgs e)
        {
            RecargarRegistros();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //CargarEstablecimientosFiltrado(txtBuscar.Text);
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
                        IdProveedor = tblRegistroProveedores.Rows[index].Cells["IdProveedor"].Value.ToString()
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
    }
}
