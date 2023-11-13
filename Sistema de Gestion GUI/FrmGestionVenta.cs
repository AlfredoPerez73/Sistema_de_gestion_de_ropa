using Entidad;
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

        private void FrmGestionVenta_Resize(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel3, 25);
            BorderRadiusPanel(panel2, 20);
        }
    }
}
