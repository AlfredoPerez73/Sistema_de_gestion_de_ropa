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
        // ---------------------------------
        bool SliderExpand;
        bool SliderExpandButtonProducts;
        // ---------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FrmMenuPrincipal(Usuario oUsuario)
        {
            InitializeComponent();
            this.oUsuario = oUsuario;

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            ContenedorPrincipal();
            CargarUsuario();
            Permisos();

        }

        private void Permisos()
        {
            List<Permiso> permisoList = new PermisoService().CargarRegistro(Convert.ToString(oUsuario.IdUser));

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
            SlideFinanciera.MaximumSize = new Size(208, 268);

        }

        private void CargarUsuario()
        {
            lblPerfil.Text = "              " + oUsuario.User.ToUpper();

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
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
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

        public void SliderButton()
        {
            if (SliderExpandButtonProducts)
            {
                SlideFinanciera.Height += 10;
                if (SlideFinanciera.Height == SlideFinanciera.MaximumSize.Height)
                {
                    SliderExpandButtonProducts = false;
                    slideButton.Stop();

                }
            }
            else
            {
                SlideFinanciera.Height -= 10;
                if (SlideFinanciera.Height == SlideFinanciera.MinimumSize.Height)
                {
                    SliderExpandButtonProducts = true;
                    slideButton.Stop();

                }
            }
        }

        private void slideBar2_Tick(object sender, EventArgs e)
        {
            SliderBar2();
        }

        private void btnMenuDesplegable_Click(object sender, EventArgs e)
        {
            slideBar2.Start();
        }

        private void btnDesplegarCompra_Click(object sender, EventArgs e)
        {
            slideButton.Start();
        }

        private void slideButton_Tick(object sender, EventArgs e)
        {
            SliderButton();
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

        private void btnDetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFrmGestionProductos((Button)sender, new FrmGestionDetalleCompra());
        }

        private void btnDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFrmGestionProductos((Button)sender, new FrmGestionDetalleVenta());
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
