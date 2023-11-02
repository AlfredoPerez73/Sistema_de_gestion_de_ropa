using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace Sistema_de_Gestion_GUI.Modales
{
    public partial class FrmDgtvRoles : Form
    { 
        RolService rolService = new RolService();
        public Rol roles { get; set; }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FrmDgtvRoles()
        {
            InitializeComponent();
        }

        private void FrmDgtvRoles_Load(object sender, EventArgs e)
        {
            CargarRegistros();
        }

        public void CargarRegistros()
        {
            RolService rolService = new RolService();
            tblRegistro.DataSource = rolService.CargarRegistros();
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

        private void tblRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblRegistro.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    roles = new Rol()
                    {
                        IdRol = tblRegistro.Rows[index].Cells["IdRol"].Value.ToString(),
                        NRol = tblRegistro.Rows[index].Cells["Rol"].Value.ToString()
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void tblRegistro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
            if (txtBuscarRoles.Texts == "Buscar:")
            {
                txtBuscarRoles.Texts = "";
                txtBuscarRoles.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBuscarProveedor_Leave(object sender, EventArgs e)
        {
            if (txtBuscarRoles.Texts == "")
            {
                txtBuscarRoles.Texts = "Buscar:";
                txtBuscarRoles.ForeColor = Color.Gainsboro;
            }
        }
    }
}
