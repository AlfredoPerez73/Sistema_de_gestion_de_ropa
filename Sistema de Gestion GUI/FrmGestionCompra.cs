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
            BorderRadius();
        }

        private void CargarUsuario()
        {
            txtFechaCompra.Texts = DateTime.Now.ToString("d");
        }

        private void BorderRadius()
        {
            int radio = 25;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90);
            path.AddLine(radio, 0, panel3.Width - radio, 0);
            path.AddArc(panel3.Width - radio * 2, 0, radio * 2, radio * 2, 270, 90);
            path.AddLine(panel3.Width, radio, panel3.Width, panel3.Height - radio);
            path.AddArc(panel3.Width - radio * 2, panel3.Height - radio * 2, radio * 2, radio * 2, 0, 90);
            path.AddLine(panel3.Width - radio, panel3.Height, radio, panel3.Height);
            path.AddArc(0, panel3.Height - radio * 2, radio * 2, radio * 2, 90, 90);
            path.CloseFigure();
            panel3.Region = new Region(path);
        }

        private void mdProducto()
        {

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
    }
}
