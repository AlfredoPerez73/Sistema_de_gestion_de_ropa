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
using System.Drawing.Drawing2D;

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
            BorderRadius();
            RecargarRegistros(categoriaService.CargarRegistro());

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void GuardarRegistro()
        {
            if ((txtTipoCategoria.Texts != ""))
            {
                Categoria categoria = new Categoria
                {
                    TipoCategoria = txtTipoCategoria.Texts.ToUpper()
                };
                var ID = categoriaService.BuscarID(txtTipoCategoria.Texts);
                if (ID != true)
                {
                    var msg = categoriaService.Guardar(categoria);
                    MessageBox.Show(msg, "Gestion de categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarRegistros(categoriaService.CargarRegistro());
                    Nuevo();
                }
                else
                {
                    MessageBox.Show($"Categoria {txtTipoCategoria.Texts} ya existe!", "Gestion de categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Gestion de categoria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RecargarRegistros(List<Categoria> categorias)
        {
            tblRegistro.Rows.Clear();
            if (categorias != null)
            {
                foreach (var categoria in categorias)
                {
                    int index = tblRegistro.Rows.Add();
                    DataGridViewRow row = tblRegistro.Rows[index];
                    row.Cells["IdCategoria"].Value = categoria.IdCategoria;
                    row.Cells["TipoCategoria"].Value = categoria.TipoCategoria;
                    row.Cells["FechaRegistro"].Value = categoria.FechaRegistro.ToString("d");
                }
            }

        }

        private void ModificarCategoria()
        {

            if ((txtIdCategoria.Texts != "") || (txtIdCategoria.Texts != ""))
            {
                Categoria categoria = new Categoria
                {
                    TipoCategoria = txtTipoCategoria.Texts.ToUpper(),
                    IdCategoria = Convert.ToInt32(txtIdCategoria.Texts)
                };
                if (categoria != null)
                {
                    var msg = categoriaService.ModificarRegistros(categoria);
                    MessageBox.Show(msg, "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarRegistros(categoriaService.CargarRegistro());
                    Nuevo();
                    EnabledUpdate();
                }
                else
                {
                    var msg = categoriaService.ModificarRegistros(categoria);
                    MessageBox.Show(msg, "Gestion de categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nuevo();
                    EnabledUpdate();
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Gestion de categorias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarCategoria()
        {
            if ((txtIdCategoria.Texts != "") || (txtIdCategoria.Texts != ""))
            {
                if (Convert.ToInt32(txtIdCategoria.Texts) != 0)
                {
                    if (MessageBox.Show("¿Desea eliminar este producto?", "Gestion de categorias", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Categoria categoria = new Categoria
                        {
                            IdCategoria = Convert.ToInt32(txtIdCategoria.Texts)
                        };
                        if (categoria != null)
                        {
                            var msg = categoriaService.EliminarRegistros(categoria);
                            MessageBox.Show(msg, "Gestion de categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RecargarRegistros(categoriaService.CargarRegistro());
                            EnabledDelete();
                        }
                        else
                        {
                            var msg = categoriaService.EliminarRegistros(categoria);
                            MessageBox.Show(msg, "Gestion de categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EnabledDelete();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Gestion de categorias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void BorderRadius()
        {
            int radio = 20;
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
        }

        private void tblRegistro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            CellPainting(sender, e);
        }

        private void tblRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellContentClick(sender, e);
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

        private void FrmGestionCategoria_Resize(object sender, EventArgs e)
        {
            BorderRadius();
        }
    }
}
