﻿using Sistema_de_Gestion_GUI.Modales;
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

namespace Sistema_de_Gestion_GUI
{
    public partial class FrmGestionUsuarios : Form
    {
        private UsuarioService usuarioService = new UsuarioService();

        public FrmGestionUsuarios()
        {
            InitializeComponent();
        }

        private void txtBuscarCategoria_Click(object sender, EventArgs e)
        {
            using (var modal = new FrmDgtvRoles())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtIdRol.Text = modal.roles.IdRol.ToString();
                    txtRol.Text = modal.roles.NRol.ToString();
                }
            }
        }

        public void GuardarRegistro()
        {
            try
            {
                if ((txtIdUsuario.Texts != "") || (txtIdRol.Text != "") || (txtDocumento.Texts != "") || (txtNombreUsuario.Texts != "")
                    || (txtContraseña.Texts != "") || (txtRol.Texts != "") || (txtCorreo.Texts != ""))
                {
                    usuarioService.GuardarRegistros(txtIdUsuario.Texts, txtIdRol.Text, txtDocumento.Texts, txtNombreUsuario.Texts.ToUpper(),
                        txtContraseña.Texts.ToLower(), txtRol.Text, txtCorreo.Texts.ToLower());

                    MessageBox.Show("Registro almacenado con exito!", "Gestion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarRegistros();
                    Nuevo();
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

        public void RecargarRegistros()
        {
            UsuarioService Service = new UsuarioService();
            tblRegistro.DataSource = Service.CargarRegistros();
        }

        public void EliminarRegistro()
        {
            string idUsuario = txtIdUsuario.Texts;

            try
            {
                if ((txtIdUsuario.Texts != "") || (txtIdRol.Text != "") || (txtDocumento.Texts != "") || (txtNombreUsuario.Texts != "")
                    || (txtContraseña.Texts != "") || (txtRol.Texts != "") || (txtCorreo.Texts != ""))
                {
                    if (Convert.ToInt32(txtIdUsuario.Texts) != 0)
                    {
                        if (MessageBox.Show("¿Desea eliminar este producto?", "Gestion de usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            usuarioService.EliminarRegistros(idUsuario);
                            MessageBox.Show("Eliminacion con exito!", "Gestion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RecargarRegistros();
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

        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            RecargarRegistros();
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

        private void EnabledUpdate()
        {
            txtIdUsuario.Enabled = true;
            txtIdRol.Enabled = false;
            txtRol.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            txtIdUsuario.Texts = "";
            txtIdRol.Clear();
            txtRol.Texts = "";
            txtNombreUsuario.Texts = "";
            txtDocumento.Texts = "";
            txtContraseña.Texts = "";
            txtCorreo.Texts = "";
            txtIdUsuario.Focus();
        }

        private void EnabledDelete()
        {
            txtIdUsuario.Enabled = true;
            txtIdRol.Enabled = true;
            btnGuardar.Enabled = true;
            txtIdUsuario.Texts = "";
            txtIdRol.Clear();
            txtRol.Texts = "";
            txtNombreUsuario.Texts = "";
            txtDocumento.Texts = "";
            txtContraseña.Texts = "";
            txtCorreo.Texts = "";
            txtIdUsuario.Focus();
        }

        private void EnabledDgtv()
        {
            txtIdUsuario.Enabled = false;
            txtIdRol.Enabled = false;
            txtRol.Enabled = false;
            btnGuardar.Enabled = false;

            txtIdUsuario.Focus();
        }

        private void Nuevo()
        {
            txtIdUsuario.Enabled = true;
            txtIdRol.Enabled = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            txtIdUsuario.Texts = "";
            txtIdRol.Clear();
            txtRol.Texts = "";
            txtNombreUsuario.Texts = "";
            txtDocumento.Texts = "";
            txtContraseña.Texts = "";
            txtCorreo.Texts = "";
            txtIdUsuario.Focus();
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

        private void tblRegistro_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (tblRegistro.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    EnabledDgtv();
                    txtIdUsuario.Text = tblRegistro.Rows[index].Cells["IdUsuario"].Value.ToString();
                    txtIdRol.Text = tblRegistro.Rows[index].Cells["IdRol"].Value.ToString();
                    txtDocumento.Text = tblRegistro.Rows[index].Cells["Documento"].Value.ToString();
                    txtNombreUsuario.Text = tblRegistro.Rows[index].Cells["Usuario"].Value.ToString();
                    txtCorreo.Text = tblRegistro.Rows[index].Cells["Correo"].Value.ToString();
                    txtRol.Text = tblRegistro.Rows[index].Cells["Rol"].Value.ToString();
                    txtContraseña.Text = tblRegistro.Rows[index].Cells["Contraseña"].Value.ToString();
                }
            }
        }

        private void tblRegistro_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            using (var modal = new FrmDgtvRoles())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtIdRol.Text = modal.roles.IdRol.ToString();
                    txtRol.Texts = modal.roles.NRol.ToString();
                }
            }
        }
    }
}