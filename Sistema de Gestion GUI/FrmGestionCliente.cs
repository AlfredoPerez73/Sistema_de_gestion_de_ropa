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
using Logica;

namespace Sistema_de_Gestion_GUI
{
    public partial class FrmGestionCliente : Form
    {
        private ClienteService clienteService = new ClienteService();

        public FrmGestionCliente()
        {
            InitializeComponent();
        }

        private void FrmGestionCliente_Load(object sender, EventArgs e)
        {
            BorderRadius();
            RecargarRegistros(clienteService.CargarRegistro());
        }

        public void GuardarRegistro()
        {
            if ((txtDocumento.Texts != "") || (txtNombreCliente.Texts != "") || (txtCorreo.Texts != "")
                || (txtTelefono.Texts != ""))
            {

                Cliente cliente = new Cliente
                {
                    Documento = txtDocumento.Texts,
                    NombreCliente = txtNombreCliente.Texts.ToUpper(),
                    Correo = txtCorreo.Texts.ToLower(),
                    Telefono = txtTelefono.Texts
                };

                var ID = clienteService.BuscarID(txtDocumento.Texts);
                if (ID != true)
                {
                    var msg = clienteService.Guardar(cliente);
                    MessageBox.Show(msg, "Gestion de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Registro almacenado con exito!", "Gestion de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarRegistros(clienteService.CargarRegistro());
                    Nuevo();
                }
                else
                {
                    MessageBox.Show($"El registro con la ID {cliente.IdCliente} y/o " +
                        $"DOCUMENTO {cliente.Documento} ya existe!", "Gestion de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Gestion de cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RecargarRegistros(List<Cliente> clientes)
        {
            tblRegistro.Rows.Clear();
            if (clientes != null)
            {
                foreach (var cliente in clientes)
                {
                    int index = tblRegistro.Rows.Add();
                    DataGridViewRow row = tblRegistro.Rows[index];
                    row.Cells["IdCliente"].Value = cliente.IdCliente;
                    row.Cells["Documento"].Value = cliente.Documento;
                    row.Cells["NombreCliente"].Value = cliente.NombreCliente;
                    row.Cells["Correo"].Value = cliente.Correo;
                    row.Cells["Telefono"].Value = cliente.Telefono;
                    row.Cells["FechaRegistro"].Value = cliente.FechaRegistro.ToString("d");
                }
            }
        }

        public void ModificarRegistro()
        {
            if ((txtIdCliente.Texts != "") || (txtDocumento.Texts != "") || (txtNombreCliente.Texts != "") || (txtCorreo.Texts != "")
                || (txtTelefono.Texts != ""))
            {
                Cliente cliente = new Cliente
                {
                    IdCliente = Convert.ToInt32(txtIdCliente.Texts),
                    Documento = txtDocumento.Texts,
                    NombreCliente = txtNombreCliente.Texts.ToUpper(),
                    Correo = txtCorreo.Texts.ToLower(),
                    Telefono = txtTelefono.Texts
                };
                if (cliente == null)
                {
                    var msg = clienteService.ModificarRegistros(cliente);
                    MessageBox.Show(msg, "Gestion de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarRegistros(clienteService.CargarRegistro());
                    Nuevo();
                    EnabledUpdate();
                }
                else
                {
                    var msg = clienteService.ModificarRegistros(cliente);
                    MessageBox.Show(msg, "Gestion de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nuevo();
                    EnabledUpdate();
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Gestion de cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void EliminarRegistro()
        {
            if ((txtIdCliente.Texts != "") || (txtDocumento.Texts != "") || (txtNombreCliente.Texts != "") || (txtCorreo.Texts != "")
                || (txtTelefono.Texts != ""))
            {
                if (Convert.ToInt32(txtIdCliente.Texts) != 0)
                {
                    if (MessageBox.Show("¿Desea eliminar este producto?", "Gestion de proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Cliente cliente = new Cliente
                        {
                            IdCliente = Convert.ToInt32(txtIdCliente.Texts),
                        };
                        if (cliente == null)
                        {
                            var msg = clienteService.EliminarRegistros(cliente);
                            MessageBox.Show(msg, "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RecargarRegistros(clienteService.CargarRegistro());
                            Nuevo();
                            EnabledDelete();
                        }
                        else
                        {
                            var msg = clienteService.EliminarRegistros(cliente);
                            MessageBox.Show(msg, "Gestion de categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Nuevo();
                            EnabledDelete();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Gestion de cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void CargarClientesFiltrado()
        {
            var filtro = txtBuscarCliente.Texts;
            var list = clienteService.BuscarX(filtro);
            RecargarRegistros(list);
        }
        private void EnabledUpdate()
        {
            txtIdCliente.Enabled = true;
            btnGuardarCliente.Enabled = true;
            btnEliminarCliente.Enabled = true;
            txtDocumento.Enabled = true;
            txtIdCliente.Texts = "";
            txtDocumento.Texts = "";
            txtNombreCliente.Texts = "";
            txtCorreo.Texts = "";
            txtTelefono.Texts = "";
            txtIdCliente.Focus();
        }

        private void EnabledDelete()
        {
            txtIdCliente.Enabled = true;
            btnGuardarCliente.Enabled = true;
            btnEliminarCliente.Enabled = true;
            txtDocumento.Enabled = true;
            txtIdCliente.Texts = "";
            txtDocumento.Texts = "";
            txtNombreCliente.Texts = "";
            txtCorreo.Texts = "";
            txtTelefono.Texts = "";
            txtIdCliente.Focus();
        }

        private void EnabledDgtv()
        {
            txtIdCliente.Enabled = false;
            btnGuardarCliente.Enabled = false;
            btnModificarCliente.Enabled = true;
        }

        private void Nuevo()
        {
            txtIdCliente.Enabled = true;
            txtDocumento.Enabled = true;
            txtIdCliente.Texts = "";
            txtDocumento.Texts = "";
            txtNombreCliente.Texts = "";
            txtCorreo.Texts = "";
            txtTelefono.Texts = "";
            txtIdCliente.Focus();
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
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90);
            path.AddLine(radio, 0, panel1.Width - radio, 0);
            path.AddArc(panel1.Width - radio * 2, 0, radio * 2, radio * 2, 270, 90);
            path.AddLine(panel1.Width, radio, panel1.Width, panel1.Height - radio);
            path.AddArc(panel1.Width - radio * 2, panel1.Height - radio * 2, radio * 2, radio * 2, 0, 90);
            path.AddLine(panel1.Width - radio, panel1.Height, radio, panel1.Height);
            path.AddArc(0, panel1.Height - radio * 2, radio * 2, radio * 2, 90, 90);
            path.CloseFigure();

            panel1.Region = new Region(path);

        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblRegistro.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    txtIdCliente.Enabled = false;
                    txtDocumento.Enabled = false;
                    txtIdCliente.Texts = tblRegistro.Rows[index].Cells["IdCliente"].Value.ToString();
                    txtDocumento.Texts = tblRegistro.Rows[index].Cells["Documento"].Value.ToString();
                    txtNombreCliente.Texts = tblRegistro.Rows[index].Cells["NombreCliente"].Value.ToString();
                    txtCorreo.Texts = tblRegistro.Rows[index].Cells["Correo"].Value.ToString();
                    txtTelefono.Texts = tblRegistro.Rows[index].Cells["Telefono"].Value.ToString();
                }
            }
        }

        private void tblRegistro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            CellPainting(sender, e);
        }

        private void tblRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellContentClick(sender, e);
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBuscarCliente_Enter(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Texts == "Buscar:")
            {
                txtBuscarCliente.Texts = "";
                txtBuscarCliente.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBuscarCliente_Leave(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Texts == "")
            {
                txtBuscarCliente.Texts = "Buscar:";
                txtBuscarCliente.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBuscarCliente__TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Texts == "Buscar:")
            {
                RecargarRegistros(clienteService.CargarRegistro());
            }
            else
            {
                CargarClientesFiltrado();
            }
        }

        private void FrmGestionCliente_Resize(object sender, EventArgs e)
        {
            BorderRadius();
        }
    }
}
