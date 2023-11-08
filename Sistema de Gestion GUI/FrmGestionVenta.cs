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
    }
}
