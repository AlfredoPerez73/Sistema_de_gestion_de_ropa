using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;
using Sistema_de_Gestion_GUI.Modales;

namespace Sistema_de_Gestion_GUI
{
    public partial class FrmGestionProducto : Form
    {
        private ProductoService productoService = new ProductoService();

        public FrmGestionProducto()
        {
            InitializeComponent();
        }

        private void FrmRopa_Load(object sender, EventArgs e)
        {
            BorderRadius();
            RecargarRegistros(productoService.CargarRegistro());
            ListarTiposCategorias();
        }

        public void GuardarRegistro()
        {
            try
            {
                if ((txtIdProducto.Texts != "") || (txtNombreProducto.Texts != "") || (txtMarcaProducto.Texts != "")
                || (cboTipoCategoria.Texts != "") || (txtStock.Texts != "") || (txtPrecioCompra.Texts != "") || (txtPrecioVenta.Texts != ""))
                {
                    Categoria CategoriaIndex = (Categoria)cboTipoCategoria.SelectedItem;
                    Producto producto = new Producto
                    {
                        IdProducto = Convert.ToInt32(txtIdProducto.Texts),
                        NombreProducto = txtNombreProducto.Texts.ToUpper(),
                        Marca = txtMarcaProducto.Texts.ToUpper(),
                        Stock = Convert.ToInt32(txtStock.Texts),
                        PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Texts),
                        PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Texts),

                        Categoria = CategoriaIndex
                    };
                    var Id = productoService.BuscarID(Convert.ToInt32(txtIdProducto.Texts));
                    if (Id != true)
                    {
                        var msg = productoService.Guardar(producto);
                        MessageBox.Show(msg, "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Registro almacenado con exito!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RecargarRegistros(productoService.CargarRegistro());
                        Nuevo();
                    }
                    else
                    {
                        MessageBox.Show($"El registro con la ID {producto.IdProducto} ya existe!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Faltan datos por ingresar!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar el producto!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}

        private void RecargarRegistros(List<Producto> productos)
        {
            tblRegistro.Rows.Clear();
            tblRegistro.Columns[1].Visible = false;

            foreach (var producto in productos)
            {
                int index = tblRegistro.Rows.Add();
                DataGridViewRow row = tblRegistro.Rows[index];
                row.Cells["IdProducto"].Value = producto.IdProducto;
                row.Cells["IdCategoria"].Value = producto.Categoria.IdCategoria;
                row.Cells["TipoCategoria"].Value = producto.Categoria.TipoCategoria;
                row.Cells["NombreProducto"].Value = producto.NombreProducto;
                row.Cells["Marca"].Value = producto.Marca;
                row.Cells["Stock"].Value = producto.Stock;
                row.Cells["PrecioVenta"].Value = producto.PrecioVenta;
                row.Cells["PrecioCompra"].Value = producto.PrecioCompra;
                row.Cells["FechaRegistro"].Value = producto.FechaRegistro.ToString("d");
            }
        }

        private void ListarTiposCategorias()
        {
            CategoriaService categoriaService = new CategoriaService();
            cboTipoCategoria.DataSource = categoriaService.CargarRegistro();
            cboTipoCategoria.DisplayMember = "TipoCategoria";
            cboTipoCategoria.ValueMember = "IdCategoria";
            cboTipoCategoria.SelectedIndex = -1;
            cboTipoCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ModificarProducto()
        {
            try
            {
                if ((txtIdProducto.Texts != "") || (txtNombreProducto.Texts != "") || (txtMarcaProducto.Texts != "")
                    || (cboTipoCategoria.Texts != "") || (txtStock.Texts != "") || (txtPrecioCompra.Texts != "") || (txtPrecioVenta.Texts != ""))
                {

                    Categoria CategoriaIndex = (Categoria)cboTipoCategoria.SelectedItem;
                    Producto producto = new Producto
                    {
                        NombreProducto = txtNombreProducto.Texts.ToUpper(),
                        Marca = txtMarcaProducto.Texts.ToUpper(),
                        Stock = Convert.ToInt32(txtStock.Texts),
                        PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Texts),
                        PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Texts),
                        Categoria = CategoriaIndex,
                        IdProducto = Convert.ToInt32(txtIdProducto.Texts),
                    };
                    var msg = productoService.ModificarRegistros(producto);
                    MessageBox.Show(msg, "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Actualizacion con exito!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarRegistros(productoService.CargarRegistro());
                    Nuevo();
                    EnabledUpdate();
                }
                else
                {
                    MessageBox.Show("Faltan datos por ingresar!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se insertaron correctamente", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarProducto()
        {
            try
            {
                if ((txtIdProducto.Texts != "") || (txtNombreProducto.Texts != "") || (txtMarcaProducto.Texts != "")
                    || (cboTipoCategoria.Texts != "") || (txtStock.Texts != "") || (txtPrecioCompra.Texts != "") || (txtPrecioVenta.Texts != ""))
                {
                    if (Convert.ToInt32(txtIdProducto.Texts) != 0)
                    {
                        if (MessageBox.Show("¿Desea eliminar este producto?", "Gestion de producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Producto producto = new Producto
                            {
                                IdProducto = Convert.ToInt32(txtIdProducto.Texts)
                            };
                            var msg = productoService.EliminarRegistros(producto);
                            MessageBox.Show(msg, "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show("Eliminacion con exito!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RecargarRegistros(productoService.CargarRegistro());
                            EnabledDelete();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Faltan datos por ingresar!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se eliminaron correctamente", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarProductosFiltrado()
        {
            var filtro = txtBuscarProducto.Texts;
            var list = productoService.BuscarX(filtro);
            RecargarRegistros(list);
        }

        private void EnabledUpdate()
        {
            txtIdProducto.Enabled = true;
            btnGuardarProducto.Enabled = true;
            btnEliminarProducto.Enabled = true;
            txtIdProducto.Texts = "";
            cboTipoCategoria.SelectedIndex = -1;
            txtNombreProducto.Texts = "";
            txtMarcaProducto.Texts = "";
            txtStock.Texts = "";
            txtPrecioCompra.Texts = "";
            txtPrecioVenta.Texts = "";
            txtIdProducto.Focus();
        }

        private void EnabledDelete()
        {
            txtIdProducto.Enabled = true;
            btnGuardarProducto.Enabled = true;
            btnModificarProducto.Enabled = true;
            txtIdProducto.Texts = "";
            cboTipoCategoria.SelectedIndex = -1;
            txtNombreProducto.Texts = "";
            txtMarcaProducto.Texts = "";
            txtStock.Texts = "";
            txtPrecioCompra.Texts = "";
            txtPrecioVenta.Texts = "";
            txtIdProducto.Focus();
        }

        private void EnabledDgtv()
        {
            txtIdProducto.Enabled = false;
            btnGuardarProducto.Enabled = false;
            btnModificarProducto.Enabled = true;
        }

        private void Nuevo()
        {
            txtIdProducto.Enabled = true;
            btnGuardarProducto.Enabled = true;
            btnEliminarProducto.Enabled = true;
            txtIdProducto.Texts = "";
            cboTipoCategoria.SelectedIndex = 0;
            txtNombreProducto.Texts = "";
            txtMarcaProducto.Texts = "";
            txtStock.Texts = "";
            txtPrecioCompra.Texts = "";
            txtPrecioVenta.Texts = "";
            txtIdProducto.Focus();
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
                    txtIdProducto.Texts = tblRegistro.Rows[index].Cells["IdProducto"].Value.ToString();
                    txtNombreProducto.Texts = tblRegistro.Rows[index].Cells["NombreProducto"].Value.ToString();
                    txtMarcaProducto.Texts = tblRegistro.Rows[index].Cells["Marca"].Value.ToString();
                    txtStock.Texts = tblRegistro.Rows[index].Cells["Stock"].Value.ToString();
                    txtPrecioCompra.Texts = tblRegistro.Rows[index].Cells["PrecioCompra"].Value.ToString();
                    txtPrecioVenta.Texts = tblRegistro.Rows[index].Cells["PrecioVenta"].Value.ToString();
                    cboTipoCategoria.Texts = tblRegistro.Rows[index].Cells["TipoCategoria"].Value.ToString();
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

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            GuardarRegistro();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            ModificarProducto();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTipoProducto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreProducto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMarcaProducto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioProducto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProveedor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscarProducto_Enter(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Texts == "Buscar:")
            {
                txtBuscarProducto.Texts = "";
                txtBuscarProducto.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBuscarProducto_Leave(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Texts == "")
            {
                txtBuscarProducto.Texts = "Buscar:";
                txtBuscarProducto.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBuscarProducto__TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Texts == "Buscar:")
            {
                RecargarRegistros(productoService.CargarRegistro());
            }
            else
            {
                CargarProductosFiltrado();
            }
        }
    }
}
