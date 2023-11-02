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

namespace Sistema_de_Gestion_GUI
{
    public partial class FrmMenuPrincipal : Form
    {
        private Usuario oUsuario;
        private Permiso oPermiso;
        private static Button MenuActivo = null;
        private static Form FormularioActivo = null;
        bool SliderExpand;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FrmMenuPrincipal(Usuario oUsuario, Permiso oPermiso)
        {
            InitializeComponent();
            this.oUsuario = oUsuario;
            this.oPermiso = oPermiso;
        }

        

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            ContenedorPrincipal();
            CargarDatosUsuario();
            Permisos();
        }

        private void Permisos()
        {
            if (oUsuario.Rol.NRol != oPermiso.Rol.NRol)
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
        }

        private void CargarDatosUsuario()
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
            Inicio(new FrmDgtvUsuario());
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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            Inicio(new FrmPrincipal());
        }

        private void ContenedorPrincipal()
        {
            Inicio(new FrmPrincipal());
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
            AbrirFrmGestionProductos((Button)sender, new FrmGestionCompra());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFrmGestionProductos((Button)sender, new FrmGestionCliente());
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            AbrirFrmGestionProductos((Button)sender, new FrmGestionVenta());
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
    }
}
