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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Logica;

namespace Sistema_de_Gestion_GUI
{
    public partial class FrmGestionDetalleCompra : Form
    {
        public FrmGestionDetalleCompra()
        {
            InitializeComponent();
        }

        private void FrmGestionDetalleCompra_Load(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel3, 20);
            BorderRadiusPanel(panel2, 25);
        }

        private void FrmGestionDetalleCompra_Resize(object sender, EventArgs e)
        {
            BorderRadiusPanel(panel3, 20);
            BorderRadiusPanel(panel2, 25);
        }

        private void BuscarCompra()
        {
            Compra compra = new CompraService().CargarRegistroCompra(txtBuscarCompra.Texts);
            if (compra.IdCompra != 0)
            {
                txtNumDoc.Texts = compra.Documento;
                txtFechaCompra.Texts = Convert.ToString(compra.FechaRegistro.ToString("d"));
                txtUsuario.Texts = compra.Usuario.User;
                txtDocumento.Texts = compra.Proveedor.Documento;
                txtProveedor.Texts = compra.Proveedor.RazonSocial;

                CargarRegistroCompra();
            }
        }

        private void CargarRegistroCompra()
        {
            Compra compra = new CompraService().CargarRegistroCompra(txtBuscarCompra.Texts);
            tblRegistro.Rows.Clear();

            foreach (Detalle_Compra DetalleCompra in compra.DetalleCompra)
            {
                tblRegistro.Rows.Add(new object[] { DetalleCompra.Producto.NombreProducto, DetalleCompra.PrecioCompra, DetalleCompra.Cantidad,
                    DetalleCompra.MontoTotal
                });
            }
            txtMontoTotal.Texts = compra.MontoTotal.ToString("0.00");
        }

        private string GenerarContenidoHTML()
        {
            string read_Html = Properties.Resources.PlantillaCompra.ToString();
            string NombreNegocio = "FITCONTOL";
            string NitNegocio = "35342-212";
            string CorreoNegocio = "alfredojoseperez@unicesar.edu.co";
            string Compra = "Compra";

            read_Html = read_Html.Replace("@nombrenegocio", NombreNegocio);
            read_Html = read_Html.Replace("@docnegocio", NitNegocio);
            read_Html = read_Html.Replace("@direcnegocio", CorreoNegocio.ToLower());

            read_Html = read_Html.Replace("@tipodocumento", Compra.ToUpper());
            read_Html = read_Html.Replace("@numerodocumento", txtNumDoc.Texts);

            read_Html = read_Html.Replace("@docproveedor", txtDocumento.Texts);
            read_Html = read_Html.Replace("@nombreproveedor", txtProveedor.Texts.ToUpper());
            read_Html = read_Html.Replace("@fecharegistro", txtFechaCompra.Texts);
            read_Html = read_Html.Replace("@usuarioregistro", txtUsuario.Texts.ToUpper());

            string fils = string.Empty;
            foreach (DataGridViewRow row in tblRegistro.Rows)
            {
                fils += "<tr>";
                fils += "<td>" + row.Cells["NombreProducto"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                fils += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                fils += "</tr>";
            }

            read_Html = read_Html.Replace("@filas", fils);
            read_Html = read_Html.Replace("@montototal", txtMontoTotal.Texts);

            return read_Html;
        }

        private void GuardarPDF(string contenidoHtml)
        {
            SaveFileDialog guardarPDF = new SaveFileDialog();
            guardarPDF.FileName = string.Format("ReporteCompra_{0}.pdf", txtNumDoc.Texts);
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
                    MessageBox.Show("Informe generado con éxito!", "Gestión de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ReportePDF()
        {
            if (txtFechaCompra.Texts == "")
            {
                MessageBox.Show("Faltan datos por ingresar!", "Gestión de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string contenidoHtml = GenerarContenidoHTML();
            GuardarPDF(contenidoHtml);
        }

        private void Limpiar()
        {
            txtFechaCompra.Texts = "";
            txtNumDoc.Texts = "";
            tblRegistro.Rows.Clear();
            txtUsuario.Texts = "";
            txtDocumento.Texts = "";
            txtProveedor.Texts = "";
            txtMontoTotal.Texts = "0.00";
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

        private void txtBuscarCompra_Enter(object sender, EventArgs e)
        {
            if (txtBuscarCompra.Texts == "Buscar:")
            {
                txtBuscarCompra.Texts = "";
                txtBuscarCompra.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtBuscarCompra_Leave(object sender, EventArgs e)
        {
            if (txtBuscarCompra.Texts == "")
            {
                txtBuscarCompra.Texts = "Buscar:";
                txtBuscarCompra.ForeColor = Color.WhiteSmoke;
            }
        }

        private void btnBuscarCompra_Click(object sender, EventArgs e)
        {
            BuscarCompra();
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
