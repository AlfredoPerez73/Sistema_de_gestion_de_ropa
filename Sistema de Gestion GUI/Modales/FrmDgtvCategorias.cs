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

namespace Sistema_de_Gestion_GUI
{
    public partial class FrmDgtvCategorias : Form
    {
        private CategoriaService categoriaService = new CategoriaService();
        public Categoria categoria { get; set; }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FrmDgtvCategorias()
        {
            InitializeComponent();
        }

        private void FrmDgtvCategorias_Load(object sender, EventArgs e)
        {
            RecargarRegistros();
        }

        private void RecargarRegistros()
        {
            CategoriaService categoriaService = new CategoriaService();
            tblRegistroCategoria.DataSource = categoriaService.CargarRegistros();
        }

        private void CargarEstablecimientosFiltrado(string filtro)
        { 
            //tblRegistroCategoria.DataSource = categoriaService.ConsultarFiltrado(filtro);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //CargarEstablecimientosFiltrado(txtBuscar.Text);
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
            if (tblRegistroCategoria.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    categoria = new Categoria()
                    {
                        IdCategoria = tblRegistroCategoria.Rows[index].Cells["IdCategoria"].Value.ToString(),
                        TipoCategoria = tblRegistroCategoria.Rows[index].Cells["TipoCategoria"].Value.ToString()
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
    }
}
