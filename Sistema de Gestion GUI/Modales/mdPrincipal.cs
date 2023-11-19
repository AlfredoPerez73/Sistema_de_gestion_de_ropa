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
        }

        private void FechaActual()
        {
            DateTime fechaActual = DateTime.Now;
            lblFecha.Text = "\n" + "\n" + "\n" + "\n" + "\n" + "\n" + "\n" + "\n" + fechaActual.ToString("hh:mm:ss") + "." + "\n" +
                "Hoy es " + fechaActual.ToString("MMMM dd, yyyy");
        }

        private void slideBar_Tick(object sender, EventArgs e)
        {
            FechaActual();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
