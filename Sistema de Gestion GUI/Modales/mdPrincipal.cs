using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestion_GUI.Modales
{
    public partial class mdPrincipal : Form
    {
        public mdPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            slideBar.Start();
            UbicacionReloj();
        }

        private void UbicacionReloj()
        {
            Point nuevaUbicacionFecha1 = new Point(585, 320);
            lblFecha.Location = nuevaUbicacionFecha1;
            Point nuevaUbicacionFecha2 = new Point(530, 370);
            lblFechaActual.Location = nuevaUbicacionFecha2;
        }

        private void FechaActual()
        {
            DateTime fechaActual = DateTime.Now;
            lblFechaActual.Text = "Hoy es " + fechaActual.ToString("MMMM dd, yyyy") + ".";
        }

        private void FechaInicio()
        {
            DateTime horaActual = DateTime.Now;
            lblFecha.Text = horaActual.ToString("hh:mm:ss");
        }

        private void slideBar_Tick(object sender, EventArgs e)
        {
            FechaInicio();
            FechaActual();
        }
    }
}
