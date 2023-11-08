using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sistema_de_Gestion_GUI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void Ingresar()
        {
            if (txtUsuario.Texts != "") 
            {
                if (txtContraseña.Texts != "")
                {
                    List<Usuario> TEST = new UsuarioService().CargarRegistro();
                    Usuario oUsuario = new UsuarioService().CargarRegistro().Where(u => u.User == txtUsuario.Texts && u.Password == txtContraseña.Texts).FirstOrDefault();
                    if (oUsuario != null)
                    {
                        FrmMenuPrincipal menu = new FrmMenuPrincipal(oUsuario);
                        menu.Show();
                        this.Hide();
                        menu.FormClosing += frm_Closing;
                    }
                    else
                    {
                        msgError("Usuario u contraseña incorrectos. \n      verfique los datos.");
                    }
                }
                else
                {
                    msgError("Por favor ingrese la contraseña.");
                }
            }
            else
            {
                msgError("Por favor ingrese el usuario.");
            }
        }

        private void msgError(string message)
        {
            lbError.Text = "      " + message;
            lbError.Visible = true;
        }

        private void frm_Closing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Texts = "";
            txtContraseña.Texts = "";
            this.Show();
        }

        private void BorderRadius()
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

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            BorderRadius();
        }
    }
}
