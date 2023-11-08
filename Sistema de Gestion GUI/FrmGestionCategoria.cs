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
using System.IO;

namespace Sistema_de_Gestion_GUI
{
    public partial class FrmGestionCategoria : Form
    {
        private CategoriaService categoriaService = new CategoriaService();

        public FrmGestionCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            RecargarRegistros(categoriaService.CargarRegistro());
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void GuardarRegistro()
        {
            try
            {
                if ((txtIdCategoria.Texts != "") || (txtTipoCategoria.Texts != ""))
                {
                    Categoria categoria = new Categoria
                    {
                        IdCategoria = txtIdCategoria.Texts,
                        TipoCategoria = txtTipoCategoria.Texts.ToUpper()
                    };
                    var ID = categoriaService.BuscarID(txtIdCategoria.Text);
                    if (ID != true)
                    {
                        var msg = categoriaService.Guardar(categoria);
                        MessageBox.Show(msg, "Gestion de categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Registro almacenado con exito!", "Gestion de categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RecargarRegistros(categoriaService.CargarRegistro());
                        Nuevo();
                    }
                    else
                    {
                        MessageBox.Show($"Categoria con la ID {categoria.IdCategoria} ya existe!", "Gestion de categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Faltan datos por ingresar!", "Gestion de categoria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se insertaron correctamente", "Gestion de categorias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RecargarRegistros(List<Categoria> categorias)
        {
            tblRegistro.Rows.Clear();

            foreach (var categoria in categorias)
            {
                int index = tblRegistro.Rows.Add();
                DataGridViewRow row = tblRegistro.Rows[index];
                row.Cells["IdCategoria"].Value = categoria.IdCategoria;
                row.Cells["TipoCategoria"].Value = categoria.TipoCategoria;
                row.Cells["FechaRegistro"].Value = categoria.FechaRegistro.ToString("d");
            }
        }

        private void ModificarCategoria()
        {
            try
            {
                if ((txtIdCategoria.Texts != "") || (txtIdCategoria.Texts != ""))
                {
                    Categoria categoria = new Categoria
                    {
                        TipoCategoria = txtTipoCategoria.Texts.ToUpper(),
                        IdCategoria = txtIdCategoria.Texts
                    };
                    var msg = categoriaService.ModificarRegistros(categoria);
                    MessageBox.Show(msg, "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Actualizacion con exito!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarRegistros(categoriaService.CargarRegistro());
                    Nuevo();
                    EnabledUpdate();
                }
                else
                {
                    MessageBox.Show("Faltan datos por ingresar!", "Gestion de categorias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se insertaron correctamente", "Gestion de categorias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarCategoria()
        {
            try
            {
                if ((txtIdCategoria.Texts != "") || (txtIdCategoria.Texts != ""))
                {
                    if (Convert.ToInt32(txtIdCategoria.Texts) != 0)
                    {
                        if (MessageBox.Show("¿Desea eliminar este producto?", "Gestion de categorias", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Categoria categoria = new Categoria
                            {
                                IdCategoria = txtIdCategoria.Texts
                            };
                            var msg = categoriaService.EliminarRegistros(categoria);
                            MessageBox.Show(msg, "Gestion de categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show("Eliminacion con exito!", "Gestion de categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RecargarRegistros(categoriaService.CargarRegistro());
                            EnabledDelete();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Faltan datos por ingresar!", "Gestion de categorias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se eliminaron correctamente", "Gestion de categorias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
        }

        private void btnModificarModificar_Click(object sender, EventArgs e)
        {
            ModificarCategoria();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarCategoria();
        }

        private void btnLimpiarCategoria_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void CargarCategoriasFiltrado()
        {
            var filtro = txtBuscarCategoria.Texts;
            var list = categoriaService.BuscarX(filtro);
            RecargarRegistros(list);
        }

        private void EnabledUpdate()
        {
            txtIdCategoria.Enabled = true;
            btnGuardarCategoria.Enabled = true;
            btnEliminarCategoria.Enabled = true;
            txtIdCategoria.Text = "";
            txtIdCategoria.Text = "";
            txtIdCategoria.Focus();
        }

        private void EnabledDelete()
        {
            txtIdCategoria.Enabled = true;
            btnGuardarCategoria.Enabled = true;
            btnModificarCategoria.Enabled = true;
            txtIdCategoria.Text = "";
            txtIdCategoria.Text = "";
            txtIdCategoria.Focus();
        }

        private void EnabledDgtv()
        {
            txtIdCategoria.Enabled = false;
            btnGuardarCategoria.Enabled = false;
            btnModificarCategoria.Enabled = true;
        }

        private void Nuevo()
        {
            txtIdCategoria.Enabled = true;
            txtIdCategoria.Texts = "";
            txtTipoCategoria.Texts = "";
            txtIdCategoria.Focus();
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

        private void tblRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblRegistro.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    txtIdCategoria.Enabled = false;
                    txtIdCategoria.Texts = tblRegistro.Rows[index].Cells["IdCategoria"].Value.ToString();
                    txtTipoCategoria.Texts = tblRegistro.Rows[index].Cells["TipoCategoria"].Value.ToString();
                }
            }
        }

        private void txtIdCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTipoCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscarProducto_Enter(object sender, EventArgs e)
        {
            if (txtBuscarCategoria.Texts == "Buscar:")
            {
                txtBuscarCategoria.Texts = "";
                txtBuscarCategoria.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBuscarProducto_Leave(object sender, EventArgs e)
        {
            if (txtBuscarCategoria.Texts == "")
            {
                txtBuscarCategoria.Texts = "Buscar:";
                txtBuscarCategoria.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBuscarCategoria__TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCategoria.Texts == "Buscar:")
            {
                RecargarRegistros(categoriaService.CargarRegistro());
            }
            else
            {
                CargarCategoriasFiltrado();
            }
        }
    }
}
