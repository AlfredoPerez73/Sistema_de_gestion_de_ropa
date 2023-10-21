﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            RecargarRegistros();
        }

        public void GuardarRegistro()
        {
            try
            {
                if ((txtIdProducto.Texts != "") || (txtIdCategoria.Text != "") || (txtNombreProducto.Texts != "") || (txtMarcaProducto.Texts != "")
                    || (txtTipoProducto.Texts != "") || (txtStock.Texts != "") || (txtPrecioProducto.Texts != "") || (txtProveedor.Texts != ""))
                {

                    productoService.Guardar(txtIdProducto.Texts, txtNombreProducto.Texts.ToUpper(),
                        txtMarcaProducto.Texts.ToUpperInvariant(), txtStock.Texts,
                        txtPrecioProducto.Texts, txtIdCategoria.Text, txtProveedor.Texts.ToUpper(), txtTipoProducto.Texts.ToUpper());
                    
                    MessageBox.Show("Registro almacenado con exito!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarRegistros();
                    Nuevo();
                }
                else
                {
                    MessageBox.Show("Faltan datos por ingresar!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ID de producto ya ingresado!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RecargarRegistros()
        {
            ProductoService Service = new ProductoService();
            tblRegistro.DataSource = Service.CargarRegistros();
        }

        private void ModificarProducto()
        {
            try
            {
                if ((txtIdProducto.Texts != "") || (txtIdCategoria.Text != "") || (txtNombreProducto.Texts != "") || (txtMarcaProducto.Texts != "")
                    || (txtTipoProducto.Texts != "") || (txtStock.Texts != "") || (txtPrecioProducto.Texts != "") || (txtProveedor.Texts != ""))
                {
                    productoService.ModificarRegistros(txtNombreProducto.Texts.ToUpper(),
                         txtMarcaProducto.Texts.ToUpperInvariant(), txtStock.Texts,
                         txtPrecioProducto.Texts, txtIdCategoria.Text, txtProveedor.Texts.ToUpper(), txtTipoProducto.Texts.ToUpper(), txtIdProducto.Texts);
                    MessageBox.Show("Actualizacion con exito!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarRegistros();
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
            string idProducto = txtIdProducto.Texts;

            try
            {
                if ((txtIdProducto.Texts != "") || (txtIdCategoria.Text != "") || (txtNombreProducto.Texts != "") || (txtMarcaProducto.Texts != "")
                    || (txtTipoProducto.Texts != "") || (txtStock.Texts != "") || (txtPrecioProducto.Texts != "") || (txtProveedor.Texts != ""))
                {
                    if (Convert.ToInt32(txtIdProducto.Texts) != 0)
                    {
                        if (MessageBox.Show("¿Desea eliminar este producto?", "Gestion de producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            productoService.EliminarRegistros(idProducto);
                            MessageBox.Show("Eliminacion con exito!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RecargarRegistros();
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

        private void CargarEstablecimientosFiltrado(string filtro)
        {

            //tblRegistro.DataSource = productoService.ConsultarFiltrado(filtro);
        }

        private void EnabledUpdate()
        {
            txtIdProducto.Enabled = true;
            btnGuardarProducto.Enabled = true;
            btnEliminarProducto.Enabled = true;
            txtIdProducto.Texts = "";
            txtIdCategoria.Text = "";
            txtTipoProducto.Texts = "";
            txtNombreProducto.Texts = "";
            txtMarcaProducto.Texts = "";
            txtStock.Texts = "";
            txtPrecioProducto.Texts = "";
            txtProveedor.Texts = "";
            txtIdProducto.Focus();
        }

        private void EnabledDelete()
        {
            txtIdProducto.Enabled = true;
            btnGuardarProducto.Enabled = true;
            btnModificarProducto.Enabled = true;
            txtIdProducto.Texts = "";
            txtIdCategoria.Text = "";
            txtTipoProducto.Texts = "";
            txtNombreProducto.Texts = "";
            txtMarcaProducto.Texts = "";
            txtStock.Texts = "";
            txtPrecioProducto.Texts = "";
            txtProveedor.Texts = "";
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
            txtIdCategoria.Text = "";
            txtTipoProducto.Texts = "";
            txtNombreProducto.Texts = "";
            txtMarcaProducto.Texts = "";
            txtStock.Texts = "";
            txtPrecioProducto.Texts = "";
            txtProveedor.Texts = "";
            txtIdProducto.Focus();
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
                    EnabledDgtv();
                    txtIdProducto.Texts = tblRegistro.Rows[index].Cells["IdProducto"].Value.ToString();
                    txtNombreProducto.Texts = tblRegistro.Rows[index].Cells["NombreProducto"].Value.ToString();
                    txtMarcaProducto.Texts = tblRegistro.Rows[index].Cells["Marca"].Value.ToString();
                    txtStock.Texts = tblRegistro.Rows[index].Cells["Stock"].Value.ToString();
                    txtPrecioProducto.Texts = tblRegistro.Rows[index].Cells["PrecioUnitario"].Value.ToString();
                    txtIdCategoria.Text = tblRegistro.Rows[index].Cells["IdCategoria"].Value.ToString();
                    txtProveedor.Texts = tblRegistro.Rows[index].Cells["IdProveedor"].Value.ToString();
                    txtTipoProducto.Texts = tblRegistro.Rows[index].Cells["TipoCategoria"].Value.ToString();
                }
            }
        }

        private void txtBuscarProducto__TextsChanged(object sender, EventArgs e)
        {
            CargarEstablecimientosFiltrado(txtBuscarProducto.Texts);
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

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            using (var modal = new FrmDgtvCategorias())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtIdCategoria.Text = modal.categoria.IdCategoria.ToString();
                    txtTipoProducto.Texts = modal.categoria.TipoCategoria.ToString();
                }
            }
        }

        private void btnBuscarProveedor_Click_1(object sender, EventArgs e)
        {
            using (var modal = new FrmDgtvProveedores())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtProveedor.Texts = modal.proveedor.IdProveedor.ToString();
                }
            }
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
    }
}