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

namespace Sistema_de_Gestion_GUI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
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
                    UsuarioService usuario = new UsuarioService();
                    var validacionLogin = usuario.LoginUser(txtUsuario.Texts, txtContraseña.Texts);
                    if (validacionLogin == true)
                    {
                        FrmMenuPrincipal menu = new FrmMenuPrincipal();
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

        private void Salir()
        {
            Close();
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
    }
}
