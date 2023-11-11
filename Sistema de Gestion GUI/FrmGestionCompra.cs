﻿using System;
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
using Sistema_de_Gestion_GUI.Modales;

namespace Sistema_de_Gestion_GUI
{
    public partial class FrmGestionCompra : Form
    {
        private Usuario oUsuario;
        private bool allowEdit = false;
        public FrmGestionCompra(Usuario oUsuario)
        {
            InitializeComponent();
            this.oUsuario = oUsuario;
        }

        private void FrmGestionCompra_Load(object sender, EventArgs e)
        {
            CargarUsuario();
            BorderRadiusPanel(panel3, 25);
            BorderRadiusPanel(panel2, 20);
        }

        private void AgregarProducto()
        {
            decimal PrecioCompra = 0;
            decimal PrecioVenta = 0;
            bool ProductoExiste = false;

            if (int.Parse(txtIdProducto.Texts) == 0)
            {
                MessageBox.Show($"Ingrese un producto", "Gestion de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!decimal.TryParse(txtPrecioCompra.Texts, out PrecioCompra))
            {
                MessageBox.Show("Precio Compra - Formato de moneda incorrecto", "Gestion de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!decimal.TryParse(txtPrecioVenta.Texts, out PrecioVenta))
            {
                MessageBox.Show("Precio Venta - Formato de moneda incorrecto", "Gestion de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (DataGridViewRow Fils in tblRegistro.Rows)
            {
                if (Fils.Cells["IdProducto"].Value.ToString() == txtIdProducto.Texts)
                {
                    ProductoExiste = true;
                    break;
                }
            }
            if (!ProductoExiste)
            {
                tblRegistro.Rows.Add(new object[]
                {
                    txtIdProducto.Texts,
                    txtNombreProducto.Texts,
                    PrecioCompra.ToString("0.00"),
                    PrecioVenta.ToString("0.00"),
                    txtCantidad.Texts.ToString(),
                    (Convert.ToDecimal(txtCantidad.Texts) * PrecioCompra).ToString("0.00")
                });
            }
            CalcularPagoTotal();
            Limpiar();
            txtIdProducto.Select();

        }

        private void Limpiar()
        {
            txtIdProducto.Texts = "";
            txtNombreProducto.Texts = "";
            txtPrecioCompra.Texts = "";
            txtPrecioVenta.Texts = "";
            txtCantidad.Texts = "";
        }

        private void CalcularPagoTotal()
        {
            decimal Total = 0;
            if (tblRegistro.Rows.Count > 0)
            {
                foreach (DataGridViewRow Rows in tblRegistro.Rows)
                {
                    Total += Convert.ToDecimal(Rows.Cells["SubTotal"].Value.ToString());
                }
            }
            txtTotalPagar.Texts = Total.ToString("0.00");
        }

        private void CargarUsuario()
        {
            txtFechaCompra.Texts = DateTime.Now.ToString("d");
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.cross_circle.Width;
                var h = Properties.Resources.cross_circle.Width;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.cross_circle, new Rectangle(x, y, w, h));
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
                    tblRegistro.Rows.RemoveAt(index);
                    CalcularPagoTotal();
                }
            }
        }

        private void BorderRadiusPanel(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radio * 2, radio * 2, 180, 90);
            path.AddLine(radio, 0, panel.Width - radio, 0);
            path.AddArc(panel.Width - radio * 2, 0, radio * 2, radio * 2, 270, 90);
            path.AddLine(panel.Width, radio, panel.Width, panel.Height - radio);
            path.AddArc(panel.Width - radio * 2, panel.Height - radio * 2, radio * 2, radio * 2, 0, 90);
            path.AddLine(panel.Width - radio, panel.Height, radio, panel.Height);
            path.AddArc(0, panel.Height - radio * 2, radio * 2, radio * 2, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void mdProducto()
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtIdProducto.Texts = modal.producto.IdProducto.ToString();
                    txtNombreProducto.Texts = modal.producto.NombreProducto.ToString();
                }
                else
                {
                    txtDocumento.Select();
                }
            }
        }

        private void mdProveedor()
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtDocumento.Texts = modal.proveedor.Documento.ToString();
                    txtProveedor.Texts = modal.proveedor.RazonSocial.ToString();
                }
                else
                {
                    txtDocumento.Select();
                }
            }
        }

        private void tblRegistro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            CellPainting(sender, e);
        }

        private void tblRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            mdProducto();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            mdProveedor();
        }

        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void rjTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtFechaCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !allowEdit;
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
