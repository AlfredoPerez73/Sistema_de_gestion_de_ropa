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
            RecargarRegistros();
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
                    categoriaService.Guardar(txtIdCategoria.Texts, txtTipoCategoria.Texts.ToUpper());
                    MessageBox.Show("Registro almacenado con exito!", "Gestion de categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarRegistros();
                    Nuevo();
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

        private void RecargarRegistros()
        {
            CategoriaService categoriaService = new CategoriaService();
            tblRegistro.DataSource = categoriaService.CargarRegistros();
        }

        private void ModificarCategoria()
        {
            try
            {
                if ((txtIdCategoria.Texts != "") || (txtIdCategoria.Texts != ""))
                {
                    categoriaService.ModificarRegistros(txtTipoCategoria.Texts.ToUpper(), txtIdCategoria.Texts);
                    MessageBox.Show("Actualizacion con exito!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarRegistros();
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
            string idCategoria = txtIdCategoria.Texts;

            try
            {
                if ((txtIdCategoria.Texts != "") || (txtIdCategoria.Texts != ""))
                {
                    if (Convert.ToInt32(txtIdCategoria.Texts) != 0)
                    {
                        if (MessageBox.Show("¿Desea eliminar este producto?", "Gestion de categorias", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            categoriaService.EliminarRegistros(txtIdCategoria.Texts);
                            MessageBox.Show("Eliminacion con exito!", "Gestion de categorias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RecargarRegistros();
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //CargarEstablecimientosFiltrado(txtBuscar.Text);
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

        private void CargarEstablecimientosFiltrado(string filtro)
        {
            //tblRegistroCategoria.DataSource = categoriaService.ConsultarFiltrado(filtro);
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
    }
}
