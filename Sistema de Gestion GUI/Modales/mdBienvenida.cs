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

namespace Sistema_de_Gestion_GUI.Modales
{
    public partial class mdBienvenida : Form
    {
        Usuario usuario;
        public mdBienvenida(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void mdBienvenida_Load(object sender, EventArgs e)
        {
            BorderRadiusPanel();
            this.Opacity = 0.0;
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            timer1.Start();
            lblUsuario.Text = usuario.User.ToUpper();
        }

        private void BorderRadiusPanel()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            progressBar1.Text = progressBar1.Value.ToString();
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
