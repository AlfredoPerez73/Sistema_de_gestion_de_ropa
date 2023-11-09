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
using Entidad;
using Sistema_de_Gestion_GUI.Modales;

namespace Sistema_de_Gestion_GUI
{
    public partial class FrmGestionCompra : Form
    {
        private Usuario oUsuario;
        private bool allowEdit = false;
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

        private void CargarUsuario()
        {
            txtFechaCompra.Texts = DateTime.Now.ToString("d");
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
                    txtIdProducto.Texts = modal.producto.IdProducto.ToString();
                    txtNombreProducto.Texts = modal.producto.NombreProducto.ToString();
                }
                else
                {
                    txtDocumento.Select();
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
                    txtDocumento.Texts = modal.proveedor.Documento.ToString();
                    txtProveedor.Texts = modal.proveedor.RazonSocial.ToString();
                }
                else
                {
                    txtDocumento.Select();
                }
            }
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

        private void tblRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
