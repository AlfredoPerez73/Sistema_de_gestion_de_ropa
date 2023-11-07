using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace Sistema_de_Gestion_GUI.Modales
{
    public partial class mdUsuario : Form
    {
        public mdUsuario()
        {
            InitializeComponent();
        }

        private void FrmDgtvEditarUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuario();
        }

        public void CargarUsuario()
        {
            //IdUsuario.Text = Usuario.IdUser;
            //Documento.Text = Usuario.Documento;
            //NombreUsuario.Text = Usuario.User;
            //Correo.Text = Usuario.Correo;
            //Rol.Text = Usuario.Rol;
        }

        private void lblEditPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //panel3.Visible = true;
            //txtIdUsuario.Text = Usuario.IdUser;
            //txtDocumento.Text = Usuario.Documento;
            //txtNombreUsuario.Text = Usuario.User;
            //txtCorreo.Text = Usuario.Correo;
            //txtRol.Text = Usuario.Rol;
            //txtContraseña.Text = Usuario.Password;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }
    }
}
