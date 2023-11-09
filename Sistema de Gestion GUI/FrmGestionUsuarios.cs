using Sistema_de_Gestion_GUI.Modales;
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
using System.Drawing.Drawing2D;

namespace Sistema_de_Gestion_GUI
{
    public partial class FrmGestionUsuarios : Form
    {
        private UsuarioService usuarioService = new UsuarioService();

        public FrmGestionUsuarios()
        {
            InitializeComponent();
        }

        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            BorderRadius();
            RecargarRegistros(usuarioService.CargarRegistro());
            ListarRoles();
        }

        public void GuardarRegistro()
        {
            try
            {
                if ((txtIdUsuario.Texts != "") || (txtDocumento.Texts != "") || (txtNombreUsuario.Texts != "")
                    || (txtContraseña.Texts != "") || (cboRoles.Texts != "") || (txtCorreo.Texts != ""))
                {

                    Rol RolIndex = (Rol)cboRoles.SelectedItem;
                    Usuario usuario = new Usuario
                    {
                        IdUser = txtIdUsuario.Texts,
                        Documento = txtDocumento.Texts,
                        User = txtIdUsuario.Texts,
                        Password = txtContraseña.Texts,
                        Rol = RolIndex,
                        Correo = txtCorreo.Texts.ToLower()
                    };
                    var ID = usuarioService.BuscarID(txtIdUsuario.Texts);
                    if (ID != true)
                    {
                        var msg = usuarioService.Guardar(usuario);
                        MessageBox.Show(msg, "Gestion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Registro almacenado con exito!", "Gestion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RecargarRegistros(usuarioService.CargarRegistro());
                        Nuevo();
                    }
                    else
                    {
                        MessageBox.Show($"El usuario con la ID {usuario.IdUser} y/o" +
                            $"DOCUMENTO {usuario.Documento} ya existe!", "Gestion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Faltan datos por ingresar!", "Gestion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ID de producto ya ingresado!", "Gestion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void RecargarRegistros(List<Usuario> usuarios)
        {
            tblRegistro.Rows.Clear();
            tblRegistro.Columns[3].Visible = false;

            foreach (var usuario in usuarios)
            {
                int index = tblRegistro.Rows.Add();
                DataGridViewRow row = tblRegistro.Rows[index];
                row.Cells["IdUsuario"].Value = usuario.IdUser;
                row.Cells["Documento"].Value = usuario.Documento;
                row.Cells["IdRol"].Value = usuario.Rol.IdRol;
                row.Cells["Rol"].Value = usuario.Rol.NRol;
                row.Cells["Usuario"].Value = usuario.User;
                row.Cells["Contraseña"].Value = usuario.Password;
                row.Cells["Correo"].Value = usuario.Correo;
                row.Cells["FechaRegistro"].Value = usuario.FechaRegistro.ToString("d");
            }
        }

        private void ListarRoles()
        {
            RolService rolService = new RolService();
            cboRoles.DataSource = rolService.CargarRegistro();
            cboRoles.DisplayMember = "NRol";
            cboRoles.ValueMember = "IdRol";
            cboRoles.SelectedIndex = -1;
            cboRoles.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void EliminarRegistro()
        {
            string idUsuario = txtIdUsuario.Texts;

            try
            {
                if ((txtIdUsuario.Texts != "") || (txtDocumento.Texts != "") || (txtNombreUsuario.Texts != "")
                    || (txtContraseña.Texts != "") || (cboRoles.Texts != "") || (txtCorreo.Texts != ""))
                {
                    if (Convert.ToInt32(txtIdUsuario.Texts) != 0)
                    {
                        if (MessageBox.Show("¿Desea eliminar este producto?", "Gestion de usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Usuario usuario = new Usuario
                            {
                                IdUser = txtIdUsuario.Texts
                            };
                            var msg = usuarioService.EliminarRegistros(usuario);
                            MessageBox.Show(msg, "Gestion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show("Eliminacion con exito!", "Gestion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RecargarRegistros(usuarioService.CargarRegistro());
                            EnabledDelete();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Faltan datos por ingresar!", "Gestion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se eliminaron correctamente", "Gestion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void CargarUsuarioFiltrado()
        {
            var filtro = txtBuscarUsuario.Texts;
            var list = usuarioService.BuscarX(filtro);
            RecargarRegistros(list);
        }

        private void EnabledUpdate()
        {
            txtIdUsuario.Enabled = true;
            cboRoles.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            txtIdUsuario.Texts = "";
            cboRoles.SelectedIndex = -1;
            txtNombreUsuario.Texts = "";
            txtDocumento.Texts = "";
            txtContraseña.Texts = "";
            txtCorreo.Texts = "";
            txtIdUsuario.Focus();
        }

        private void EnabledDelete()
        {
            txtIdUsuario.Enabled = true;
            cboRoles.Enabled = false;
            btnGuardar.Enabled = true;
            txtIdUsuario.Texts = "";
            cboRoles.SelectedIndex = -1;
            txtNombreUsuario.Texts = "";
            txtDocumento.Texts = "";
            txtContraseña.Texts = "";
            txtCorreo.Texts = "";
            txtIdUsuario.Focus();
        }

        private void EnabledDgtv()
        {
            txtIdUsuario.Enabled = false;
            cboRoles.Enabled = false;
            btnGuardar.Enabled = false;

            txtIdUsuario.Focus();
        }

        private void Nuevo()
        {
            txtIdUsuario.Enabled = true;
            cboRoles.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            txtIdUsuario.Texts = "";
            cboRoles.SelectedIndex = -1;
            txtNombreUsuario.Texts = "";
            txtDocumento.Texts = "";
            txtContraseña.Texts = "";
            txtCorreo.Texts = "";
            txtIdUsuario.Focus();
        }

        private void CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check_circle.Width;
                var h = Properties.Resources.cross_circle.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check_circle, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void BorderRadius()
        {
            int radio = 20;
            var tamañoOriginal = panel2.Size;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90);
            path.AddLine(radio, 0, panel2.Width - radio, 0);
            path.AddArc(panel2.Width - radio * 2, 0, radio * 2, radio * 2, 270, 90);
            path.AddLine(panel2.Width, radio, panel2.Width, panel2.Height - radio);
            path.AddArc(panel2.Width - radio * 2, panel2.Height - radio * 2, radio * 2, radio * 2, 0, 90);
            path.AddLine(panel2.Width - radio, panel2.Height, radio, panel2.Height);
            path.AddArc(0, panel2.Height - radio * 2, radio * 2, radio * 2, 90, 90);
            path.CloseFigure();

            panel2.Region = new Region(path);
            panel2.Size = tamañoOriginal;

        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblRegistro.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    EnabledDgtv();
                    txtIdUsuario.Texts = tblRegistro.Rows[index].Cells["IdUsuario"].Value.ToString();
                    txtDocumento.Texts = tblRegistro.Rows[index].Cells["Documento"].Value.ToString();
                    txtNombreUsuario.Texts = tblRegistro.Rows[index].Cells["Usuario"].Value.ToString();
                    txtCorreo.Texts = tblRegistro.Rows[index].Cells["Correo"].Value.ToString();
                    cboRoles.Texts = tblRegistro.Rows[index].Cells["Rol"].Value.ToString();
                    txtContraseña.Texts = tblRegistro.Rows[index].Cells["Contraseña"].Value.ToString();
                }
            }
        }

        private void tblRegistro_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            CellPainting(sender, e);
        }

        private void tblRegistro_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CellContentClick(sender, e);
        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void txtBuscarProducto_Enter(object sender, EventArgs e)
        {
            if (txtBuscarUsuario.Texts == "Buscar:")
            {
                txtBuscarUsuario.Texts = "";
                txtBuscarUsuario.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBuscarProducto_Leave(object sender, EventArgs e)
        {
            if (txtBuscarUsuario.Texts == "")
            {
                txtBuscarUsuario.Texts = "Buscar:";
                txtBuscarUsuario.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBuscarUsuario__TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarUsuario.Texts == "Buscar:")
            {
                RecargarRegistros(usuarioService.CargarRegistro());
            }
            else
            {
                CargarUsuarioFiltrado();
            }
        }
    }
}
