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
using FontAwesome.Sharp;
using Sistema_de_Gestion_GUI.Modales;
using System.Drawing.Drawing2D;

namespace Sistema_de_Gestion_GUI
{
    public partial class FrmMenuPrincipal : Form
    {
        private Usuario oUsuario;
        // ---------------------------------
        private static Button MenuActivo = null;
        private static Form FormularioActivo = null;
        // --------------------------------
        bool SliderExpand;
        bool BorderRadiusEvent = true;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FrmMenuPrincipal(Usuario oUsuario)
        {
            InitializeComponent();
            this.oUsuario = oUsuario;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            ContenedorPrincipal();
            BorderRadius(BorderRadiusEvent);
            CargarUsuario();
            Permisos();
        }

        private void Permisos()
        {
            List<Permiso> permisoList = new PermisoService().CargarRegistro(oUsuario.IdUser);

            bool index = permisoList.Any(m => m.NPermiso == btnGestionCategorias.Name);
            if (index == false)
            {
                ButtonBlock();
            }
        }

        private void ButtonBlock()
        {
            btnGestionCategorias.Visible = false;
            btnGestionUsuarios.Visible = false;
            btnVenta.Visible = false;
            btnClientes.Visible = false;
            //-----------------------------
            Point nuevaUbicacionBtnProveedores = new Point(3, 225);
            panel5.Location = nuevaUbicacionBtnProveedores;
            Point nuevaUbicacionBtnCompras = new Point(3, 283);
            panel7.Location = nuevaUbicacionBtnCompras;
        }

        private void CargarUsuario()
        {
            btnPerfil.Text = "            " + oUsuario.Rol.NRol;

        }

        private void Inicio(Form Formulario)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = Formulario;
            Formulario.TopLevel = false;
            Formulario.Dock = DockStyle.Fill;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.BackColor = Color.SteelBlue;

            Contenedor.Controls.Add(Formulario);
            Formulario.Show();
        }

        private void AbrirFrmGestionProductos(Button Menu, Form Formulario)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = Formulario;
            Formulario.TopLevel = false;
            Formulario.Dock = DockStyle.Fill;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.BackColor = Color.SteelBlue;

            Contenedor.Controls.Add(Formulario);
            Formulario.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Inicio(new mdUsuario());
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
                MenuActivo.BackColor = Color.White;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Maximizar()
        {
            if (WindowState == FormWindowState.Normal)
            {
                BorderRadiusEvent = true;
                BorderRadius(false);
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                BorderRadius(BorderRadiusEvent);
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Minimizar()
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            Maximizar();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            Minimizar();
        }

        private void BorderRadius(bool BorderRadius)
        {
            this.FormBorderStyle = FormBorderStyle.None;

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

            this.Region = BorderRadius ? new Region(path) : null;
        }

        public void SliderBar2()
        {
            if (SliderExpand)
            {
                SlideContenedor2.Width += 10;
                if (SlideContenedor2.Width == SlideContenedor2.MaximumSize.Width)
                {
                    SliderExpand = false;
                    slideBar2.Stop();

                }
            }
            else
            {
                SlideContenedor2.Width -= 10;
                if (SlideContenedor2.Width == SlideContenedor2.MinimumSize.Width)
                {
                    SliderExpand = true;
                    slideBar2.Stop();

                }
            }
        }

        private void slideBar2_Tick(object sender, EventArgs e)
        {
            SliderBar2();
        }

        private void MenuDesplegable_Click(object sender, EventArgs e)
        {
            slideBar2.Start();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Inicio(new mdPrincipal());
        }

        private void ContenedorPrincipal()
        {
            Inicio(new mdPrincipal());
        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            AbrirFrmGestionProductos((Button)sender, new FrmGestionProducto());
        }

        private void btnGestionCategorias_Click(object sender, EventArgs e)
        {
            AbrirFrmGestionProductos((Button)sender, new FrmGestionCategoria());
        }

        private void btnGestionProveedores_Click(object sender, EventArgs e)
        {
            AbrirFrmGestionProductos((Button)sender, new FrmGestionProveedores());
        }

        private void GestionUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFrmGestionProductos((Button)sender, new FrmGestionUsuarios());
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            AbrirFrmGestionProductos((Button)sender, new FrmGestionCompra(oUsuario));
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFrmGestionProductos((Button)sender, new FrmGestionCliente());
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            AbrirFrmGestionProductos((Button)sender, new FrmGestionVenta(oUsuario));
        }

        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel10_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SlideContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
