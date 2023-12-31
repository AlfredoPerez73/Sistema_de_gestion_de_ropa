﻿using System;
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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Logica;

namespace Sistema_de_Gestion_GUI
{
    public partial class FrmGestionDetalleVenta : Form
    {
        public FrmGestionDetalleVenta()
        {
            InitializeComponent();
        }

        private void FrmGestionDetalleVenta_Load(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel3, 20);
            BorderRadiusPanel(panel2, 25);
            Limpiar();
        }

        private void FrmGestionDetalleVenta_Resize(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel3, 20);
            BorderRadiusPanel(panel2, 25);
        }

        private void BuscarVenta()
        {
            Venta venta = new VentaService().CargarRegistroVenta(txtBuscarVenta.Texts);
            if (venta.IdVenta != 0)
            {
                txtNumDoc.Texts = venta.DocumentoVenta;
                txtFechaVenta.Texts = Convert.ToString(venta.FechaRegistro.ToString("d"));
                txtUsuario.Texts = venta.Usuario.User;
                txtDocumento.Texts = venta.DocumentoCliente;
                txtCliente.Texts = venta.NombreCliente;

                CargarRegistroVenta();
            }
        }

        private void CargarRegistroVenta()
        {
            Venta venta = new VentaService().CargarRegistroVenta(txtBuscarVenta.Texts);
            tblRegistro.Rows.Clear();

            foreach (Detalle_Venta DetalleVenta in venta.DetalleVentaList)
            {
                tblRegistro.Rows.Add(new object[] { DetalleVenta.Producto.NombreProducto, DetalleVenta.PrecioVenta, DetalleVenta.Cantidad,
                    DetalleVenta.SubTotal
                });
            }
            txtMontoTotal.Texts = venta.MontoTotal.ToString("0.00");
            txtMontoPago.Texts = venta.MontoPago.ToString("0.00");
            txtMontoCambio.Texts = venta.MontoCambio.ToString("0.00");

        }

        public string GenerarContenidoHTML()
        {
            string read_Html = Properties.Resources.PlantillaVenta.ToString();
            string NombreNegocio = "FITCONTOL";
            string NitNegocio = "35342-212";
            string CorreoNegocio = "alfredojoseperez@unicesar.edu.co";
            string Venta = "VENTA";

            read_Html = read_Html.Replace("@nombrenegocio", NombreNegocio);
            read_Html = read_Html.Replace("@docnegocio", NitNegocio);
            read_Html = read_Html.Replace("@direcnegocio", CorreoNegocio.ToLower());

            read_Html = read_Html.Replace("@tipodocumento", Venta.ToUpper());
            read_Html = read_Html.Replace("@numerodocumento", txtNumDoc.Texts);

            read_Html = read_Html.Replace("@doccliente", txtDocumento.Texts);
            read_Html = read_Html.Replace("@nombrecliente", txtCliente.Texts.ToUpper());
            read_Html = read_Html.Replace("@fecharegistro", txtFechaVenta.Texts);
            read_Html = read_Html.Replace("@usuarioregistro", txtUsuario.Texts.ToUpper());

            string fils = string.Empty;
            foreach (DataGridViewRow row in tblRegistro.Rows)
            {
                fils += "<tr>";
                fils += "<td>" + row.Cells["NombreProducto"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["PrecioVenta"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                fils += "</tr>";
            }

            read_Html = read_Html.Replace("@filas", fils);
            read_Html = read_Html.Replace("@montototal", txtMontoTotal.Texts);
            read_Html = read_Html.Replace("@pagocon", txtMontoPago.Texts);
            read_Html = read_Html.Replace("@cambio", txtMontoCambio.Texts);

            return read_Html;
        }

        public string GuardarPDF(string contenidoHtml)
        {
            SaveFileDialog guardarPDF = new SaveFileDialog();
            guardarPDF.FileName = string.Format("ReporteVenta_{0}.pdf", txtNumDoc.Texts);
            guardarPDF.Filter = "Pdf Files|*.pdf";

            if (guardarPDF.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardarPDF.FileName, FileMode.Create))
                {
                    Document PDFdoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(PDFdoc, stream);
                    PDFdoc.Open();

                    Bitmap bitmap = Properties.Resources.logo_pdf;
                    ImageConverter converter = new ImageConverter();
                    byte[] imageBytes = (byte[])converter.ConvertTo(bitmap, typeof(byte[]));

                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imageBytes);
                    image.ScaleToFit(140, 140);
                    image.Alignment = iTextSharp.text.Image.UNDERLYING;
                    image.SetAbsolutePosition(PDFdoc.Left, PDFdoc.GetTop(80));
                    PDFdoc.Add(image);

                    using (StringReader reader = new StringReader(contenidoHtml))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, PDFdoc, reader);
                    }

                    PDFdoc.Close();
                    stream.Close();
                    DialogResult result = MessageBox.Show("Informe generado con éxito! ¿Deseas abrir la factura?", "Gestión de venta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(guardarPDF.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se pudo abrir el archivo. Error: " + ex.Message, "Error al abrir archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            return guardarPDF.FileName;
        }

        private void ReportePDF()
        {
            if (txtFechaVenta.Texts == "")
            {
                MessageBox.Show("Faltan datos por ingresar!", "Gestión de venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string contenidoHtml = GenerarContenidoHTML();
            GuardarPDF(contenidoHtml);
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

        private void Limpiar()
        {
            txtFechaVenta.Texts = "";
            txtNumDoc.Texts = "";
            tblRegistro.Rows.Clear();
            txtUsuario.Texts = "";
            txtDocumento.Texts = "";
            txtCliente.Texts = "";
            txtMontoTotal.Texts = "0.00";
            txtMontoPago.Texts = "0.00";
            txtMontoCambio.Texts = "0.00";
        }

        private void txtBuscarVenta_Enter(object sender, EventArgs e)
        {
            if (txtBuscarVenta.Texts == "Buscar:")
            {
                txtBuscarVenta.Texts = "";
                txtBuscarVenta.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtBuscarVenta_Leave(object sender, EventArgs e)
        {
            if (txtBuscarVenta.Texts == "")
            {
                txtBuscarVenta.Texts = "Buscar:";
                txtBuscarVenta.ForeColor = Color.WhiteSmoke;
            }
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            BuscarVenta();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            ReportePDF();
        }
    }
}
