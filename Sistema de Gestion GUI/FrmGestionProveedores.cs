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
    public partial class FrmGestionProveedores : Form
    {
        private ProveedorService productoService = new ProveedorService();

        public FrmGestionProveedores()
        {
            InitializeComponent();
        }

        public void GuardarRegistro()
        {
            try
            {
                if ((txtIdProveedor.Texts != "") || (txtDocumento.Texts != "") || (txtRazonSocial.Texts != "") || (txtCorreo.Texts != "") 
                    || (txtTelefono.Texts != ""))
                {
                    ProveedorService oProductoService = new ProveedorService();
                    Proveedor proveedor = new Proveedor
                    {
                        IdProveedor = txtIdProveedor.Texts,
                        Documento = txtDocumento.Texts,
                        RazonSocial = txtRazonSocial.Texts.ToUpper(),
                        Correo = txtCorreo.Texts.ToLower(),
                        Telefono = txtTelefono.Texts
                    };

                    var ID = oProductoService.BuscarID(proveedor);
                    if (ID == false)
                    {
                        var msg = productoService.Guardar(proveedor);
                        MessageBox.Show(msg, "Gestion de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Registro almacenado con exito!", "Gestion de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RecargarRegistros();
                        Nuevo();
                    }
                    else
                    {
                        MessageBox.Show($"El registro con la ID {proveedor.IdProveedor} y/o" +
                            $"DOCUMENTO {proveedor.Documento} ya existe!", "Gestion de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Faltan datos por ingresar!", "Gestion de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar el proveedor!", "Gestion de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RecargarRegistros()
        {
            var proveedores = new ProveedorService().CargarRegistro();
            tblRegistro.Rows.Clear();
            tblRegistro.Rows.Add();
            DataGridViewRow row = tblRegistro.Rows[tblRegistro.Rows.Count - 1];

            foreach (var proveedor in proveedores)
            {
                row.Cells["IdProveedor"].Value = proveedor.IdProveedor;
                row.Cells["Documento"].Value = proveedor.Documento;
                row.Cells["RazonSocial"].Value = proveedor.RazonSocial;
                row.Cells["Correo"].Value = proveedor.Correo;
                row.Cells["Telefono"].Value = proveedor.Telefono;
                row.Cells["FechaRegistro"].Value = proveedor.FechaRegistro.ToString("d");

                tblRegistro.Rows.Add();
                row = tblRegistro.Rows[tblRegistro.Rows.Count - 1];
            }
            tblRegistro.Rows.RemoveAt(tblRegistro.Rows.Count - 1);
        }

        public void ModificarRegistro()
        {
            try
            {
                if ((txtIdProveedor.Texts != "") || (txtDocumento.Texts != "") || (txtRazonSocial.Texts != "") || (txtCorreo.Texts != "")
                    || (txtTelefono.Texts != ""))
                {
                    Proveedor proveedor = new Proveedor
                    {
                        Documento = txtDocumento.Texts,
                        RazonSocial = txtRazonSocial.Texts.ToUpper(),
                        Correo = txtCorreo.Texts.ToLower(),
                        Telefono = txtCorreo.Texts,
                        IdProveedor = txtIdProveedor.Texts
                    };
                    var msg = productoService.ModificarRegistros(proveedor);
                    MessageBox.Show(msg, "Gestion de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Actualizacion con exito!", "Gestion de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarRegistros();
                    Nuevo();
                    EnabledUpdate();
                }
                else
                {
                    MessageBox.Show("Faltan datos por ingresar!", "Gestion de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se insertaron correctamente", "Gestion de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void EliminarRegistro()
        {
            try
            {
                if ((txtIdProveedor.Texts != "") || (txtDocumento.Texts != "") || (txtRazonSocial.Texts != "") || (txtCorreo.Texts != "")
                    || (txtTelefono.Texts != ""))
                {
                    if (Convert.ToInt32(txtIdProveedor.Texts) != 0)
                    {
                        if (MessageBox.Show("¿Desea eliminar este producto?", "Gestion de proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Proveedor proveedor = new Proveedor
                            {
                                IdProveedor = txtIdProveedor.Texts
                            };
                            var msg = productoService.EliminarRegistros(proveedor);
                            MessageBox.Show(msg, "Gestion de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show("Eliminacion con exito!", "Gestion de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RecargarRegistros();
                            EnabledDelete();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Faltan datos por ingresar!", "Gestion de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se eliminaron correctamente", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
        }

        private void btnLimpiarProveedor_Click(object sender, EventArgs e)
        {
            Nuevo();    
        }

        private void CargarProveedoresFiltrado(string filtro)
        {
            //tblRegistroProveedores.DataSource = productoService.ConsultarFiltrado(filtro);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //CargarClientesFiltrado(txtBuscar.Text);
        }

        private void EnabledUpdate()
        {
            txtIdProveedor.Enabled = true;
            btnGuardarProveedor.Enabled = true;
            btnEliminarProveedor.Enabled = true;
            txtDocumento.Enabled = true;
            txtIdProveedor.Texts = "";
            txtDocumento.Texts = "";
            txtRazonSocial.Texts = "";
            txtCorreo.Texts = "";
            txtTelefono.Texts = "";
            txtIdProveedor.Focus();
        }

        private void EnabledDelete()
        {
            txtIdProveedor.Enabled = true;
            btnGuardarProveedor.Enabled = true;
            btnModificarProveedor.Enabled = true;
            txtDocumento.Enabled = true;
            txtIdProveedor.Texts = "";
            txtDocumento.Texts = "";
            txtRazonSocial.Texts = "";
            txtCorreo.Texts = "";
            txtTelefono.Texts = "";
            txtIdProveedor.Focus();
        }

        private void EnabledDgtv()
        {
            txtIdProveedor.Enabled = false;
            btnGuardarProveedor.Enabled = false;
            btnModificarProveedor.Enabled = true;
        }

        private void Nuevo()
        {
            txtIdProveedor.Enabled = true;
            txtDocumento.Enabled = true;
            txtIdProveedor.Texts = "";
            txtDocumento.Texts = "";
            txtRazonSocial.Texts = "";
            txtCorreo.Texts = "";
            txtTelefono.Texts = "";
            txtIdProveedor.Focus();
        }

        private void FrmGestionProveedores_Load(object sender, EventArgs e)
        {
            RecargarRegistros();
        }

        private void txtIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tblRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblRegistro.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    txtIdProveedor.Enabled = false;
                    txtDocumento.Enabled = false;
                    txtIdProveedor.Texts = tblRegistro.Rows[index].Cells["IdProveedor"].Value.ToString();
                    txtDocumento.Texts = tblRegistro.Rows[index].Cells["Documento"].Value.ToString();
                    txtRazonSocial.Texts = tblRegistro.Rows[index].Cells["RazonSocial"].Value.ToString();
                    txtCorreo.Texts = tblRegistro.Rows[index].Cells["Correo"].Value.ToString();
                    txtTelefono.Texts = tblRegistro.Rows[index].Cells["Telefono"].Value.ToString();
                }
            }
        }

        private void tblRegistro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void txtBuscarProducto_Enter(object sender, EventArgs e)
        {
            if (txtBuscarProveedor.Texts == "Buscar:")
            {
                txtBuscarProveedor.Texts = "";
                txtBuscarProveedor.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBuscarProducto_Leave(object sender, EventArgs e)
        {
            if (txtBuscarProveedor.Texts == "")
            {
                txtBuscarProveedor.Texts = "Buscar:";
                txtBuscarProveedor.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBuscarProveedor__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
