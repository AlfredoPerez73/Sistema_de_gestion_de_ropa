namespace Sistema_de_Gestion_GUI
{
    partial class FrmGestionVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtFechaCompra = new CustomControls.RJControls.RJTextBox();
            this.txtBuscarProducto = new CustomControls.RJControls.RJTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCambioVenta = new CustomControls.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtPagoVenta = new CustomControls.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.Label();
            this.txtStock = new CustomControls.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblRegistro = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTotalPagar = new CustomControls.RJControls.RJTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCantidad = new CustomControls.RJControls.RJTextBox();
            this.txtCliente = new CustomControls.RJControls.RJTextBox();
            this.btnBuscarCliente = new CustomControls.RJControls.RJButton();
            this.txtDocumento = new CustomControls.RJControls.RJTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegistrarVenta = new CustomControls.RJControls.RJButton();
            this.txtPrecioVenta = new CustomControls.RJControls.RJTextBox();
            this.txtNombreProducto = new CustomControls.RJControls.RJTextBox();
            this.btnBuscarProducto = new CustomControls.RJControls.RJButton();
            this.txtCodigo = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarProducto = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtFechaCompra);
            this.panel1.Controls.Add(this.txtBuscarProducto);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rjTextBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 578);
            this.panel1.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(532, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(485, 27);
            this.panel4.TabIndex = 55;
            // 
            // txtFechaCompra
            // 
            this.txtFechaCompra.BackColor = System.Drawing.Color.White;
            this.txtFechaCompra.BorderColor = System.Drawing.Color.White;
            this.txtFechaCompra.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtFechaCompra.BorderRadius = 15;
            this.txtFechaCompra.BorderSize = 1;
            this.txtFechaCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCompra.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtFechaCompra.Location = new System.Drawing.Point(196, 63);
            this.txtFechaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaCompra.Multiline = false;
            this.txtFechaCompra.Name = "txtFechaCompra";
            this.txtFechaCompra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFechaCompra.PasswordChar = false;
            this.txtFechaCompra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFechaCompra.PlaceholderText = "";
            this.txtFechaCompra.Size = new System.Drawing.Size(317, 32);
            this.txtFechaCompra.TabIndex = 53;
            this.txtFechaCompra.Texts = "Fecha";
            this.txtFechaCompra.UnderlinedStyle = false;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarProducto.BackColor = System.Drawing.Color.White;
            this.txtBuscarProducto.BorderColor = System.Drawing.Color.White;
            this.txtBuscarProducto.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtBuscarProducto.BorderRadius = 15;
            this.txtBuscarProducto.BorderSize = 1;
            this.txtBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBuscarProducto.Location = new System.Drawing.Point(521, 63);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarProducto.Multiline = false;
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscarProducto.PasswordChar = false;
            this.txtBuscarProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarProducto.PlaceholderText = "";
            this.txtBuscarProducto.Size = new System.Drawing.Size(521, 32);
            this.txtBuscarProducto.TabIndex = 20;
            this.txtBuscarProducto.Texts = "Buscar:";
            this.txtBuscarProducto.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(207, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Registrar venta";
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.White;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.White;
            this.rjTextBox1.BorderRadius = 15;
            this.rjTextBox1.BorderSize = 3;
            this.rjTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(196, 20);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(846, 34);
            this.rjTextBox1.TabIndex = 22;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtIdProducto);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.txtCambioVenta);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtIdCliente);
            this.panel3.Controls.Add(this.txtPagoVenta);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Stock);
            this.panel3.Controls.Add(this.txtStock);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.txtTotalPagar);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.txtCliente);
            this.panel3.Controls.Add(this.btnBuscarCliente);
            this.panel3.Controls.Add(this.txtDocumento);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnRegistrarVenta);
            this.panel3.Controls.Add(this.txtPrecioVenta);
            this.panel3.Controls.Add(this.txtNombreProducto);
            this.panel3.Controls.Add(this.btnBuscarProducto);
            this.panel3.Controls.Add(this.txtCodigo);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnGuardarProducto);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Location = new System.Drawing.Point(196, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 454);
            this.panel3.TabIndex = 52;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(743, 251);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(87, 15);
            this.textBox3.TabIndex = 63;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(29, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 15);
            this.textBox1.TabIndex = 62;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(29, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 15);
            this.textBox2.TabIndex = 62;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // txtCambioVenta
            // 
            this.txtCambioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCambioVenta.BackColor = System.Drawing.SystemColors.Window;
            this.txtCambioVenta.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtCambioVenta.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtCambioVenta.BorderRadius = 15;
            this.txtCambioVenta.BorderSize = 2;
            this.txtCambioVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCambioVenta.Location = new System.Drawing.Point(734, 299);
            this.txtCambioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtCambioVenta.Multiline = false;
            this.txtCambioVenta.Name = "txtCambioVenta";
            this.txtCambioVenta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCambioVenta.PasswordChar = false;
            this.txtCambioVenta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCambioVenta.PlaceholderText = "";
            this.txtCambioVenta.Size = new System.Drawing.Size(101, 32);
            this.txtCambioVenta.TabIndex = 61;
            this.txtCambioVenta.Texts = "";
            this.txtCambioVenta.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(738, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "Cambio";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(147, 46);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 59;
            this.txtIdCliente.Visible = false;
            // 
            // txtPagoVenta
            // 
            this.txtPagoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPagoVenta.BackColor = System.Drawing.Color.White;
            this.txtPagoVenta.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPagoVenta.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtPagoVenta.BorderRadius = 15;
            this.txtPagoVenta.BorderSize = 2;
            this.txtPagoVenta.Enabled = false;
            this.txtPagoVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPagoVenta.Location = new System.Drawing.Point(734, 242);
            this.txtPagoVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPagoVenta.Multiline = false;
            this.txtPagoVenta.Name = "txtPagoVenta";
            this.txtPagoVenta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPagoVenta.PasswordChar = false;
            this.txtPagoVenta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPagoVenta.PlaceholderText = "";
            this.txtPagoVenta.Size = new System.Drawing.Size(101, 32);
            this.txtPagoVenta.TabIndex = 58;
            this.txtPagoVenta.Texts = "";
            this.txtPagoVenta.UnderlinedStyle = false;
            this.txtPagoVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPagoVenta_KeyDown);
            this.txtPagoVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagoVenta_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(738, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Pago";
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Stock.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock.Location = new System.Drawing.Point(501, 161);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(42, 17);
            this.Stock.TabIndex = 56;
            this.Stock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.Window;
            this.txtStock.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtStock.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtStock.BorderRadius = 15;
            this.txtStock.BorderSize = 2;
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStock.Location = new System.Drawing.Point(497, 181);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Multiline = false;
            this.txtStock.Name = "txtStock";
            this.txtStock.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStock.PasswordChar = false;
            this.txtStock.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtStock.PlaceholderText = "";
            this.txtStock.Size = new System.Drawing.Size(96, 32);
            this.txtStock.TabIndex = 55;
            this.txtStock.Texts = "";
            this.txtStock.UnderlinedStyle = false;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tblRegistro);
            this.panel2.Location = new System.Drawing.Point(29, 235);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 197);
            this.panel2.TabIndex = 54;
            // 
            // tblRegistro
            // 
            this.tblRegistro.AllowUserToAddRows = false;
            this.tblRegistro.AllowUserToDeleteRows = false;
            this.tblRegistro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.tblRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblRegistro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblRegistro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblRegistro.ColumnHeadersHeight = 30;
            this.tblRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.NombreProducto,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.btnSeleccionar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblRegistro.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRegistro.EnableHeadersVisualStyles = false;
            this.tblRegistro.Location = new System.Drawing.Point(0, 0);
            this.tblRegistro.MultiSelect = false;
            this.tblRegistro.Name = "tblRegistro";
            this.tblRegistro.ReadOnly = true;
            this.tblRegistro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblRegistro.RowHeadersVisible = false;
            this.tblRegistro.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.tblRegistro.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tblRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblRegistro.Size = new System.Drawing.Size(698, 197);
            this.tblRegistro.TabIndex = 17;
            this.tblRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblRegistro_CellContentClick);
            this.tblRegistro.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tblRegistro_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Id del producto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 150;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio de venta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 210;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 150;
            // 
            // btnSeleccionar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnSeleccionar.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 3;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Text = "Id de producto";
            this.btnSeleccionar.Width = 30;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPagar.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalPagar.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtTotalPagar.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtTotalPagar.BorderRadius = 15;
            this.txtTotalPagar.BorderSize = 2;
            this.txtTotalPagar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalPagar.Location = new System.Drawing.Point(732, 355);
            this.txtTotalPagar.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalPagar.Multiline = false;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotalPagar.PasswordChar = false;
            this.txtTotalPagar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalPagar.PlaceholderText = "";
            this.txtTotalPagar.Size = new System.Drawing.Size(101, 32);
            this.txtTotalPagar.TabIndex = 43;
            this.txtTotalPagar.Texts = "";
            this.txtTotalPagar.UnderlinedStyle = false;
            this.txtTotalPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBox5_KeyPress);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(736, 335);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 17);
            this.label15.TabIndex = 42;
            this.label15.Text = "Total a pagar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(632, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtCantidad.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtCantidad.BorderRadius = 15;
            this.txtCantidad.BorderSize = 2;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCantidad.Location = new System.Drawing.Point(628, 180);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCantidad.PasswordChar = false;
            this.txtCantidad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCantidad.PlaceholderText = "";
            this.txtCantidad.Size = new System.Drawing.Size(96, 32);
            this.txtCantidad.TabIndex = 40;
            this.txtCantidad.Texts = "";
            this.txtCantidad.UnderlinedStyle = false;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtCliente.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtCliente.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtCliente.BorderRadius = 15;
            this.txtCliente.BorderSize = 2;
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCliente.Location = new System.Drawing.Point(208, 95);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Multiline = false;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCliente.PasswordChar = false;
            this.txtCliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCliente.PlaceholderText = "";
            this.txtCliente.Size = new System.Drawing.Size(158, 32);
            this.txtCliente.TabIndex = 39;
            this.txtCliente.Texts = "";
            this.txtCliente.UnderlinedStyle = false;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarCliente.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarCliente.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarCliente.BorderRadius = 15;
            this.btnBuscarCliente.BorderSize = 0;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.busqueda;
            this.btnBuscarCliente.Location = new System.Drawing.Point(160, 98);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(40, 29);
            this.btnBuscarCliente.TabIndex = 38;
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliente.TextColor = System.Drawing.Color.White;
            this.btnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.White;
            this.txtDocumento.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtDocumento.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtDocumento.BorderRadius = 15;
            this.txtDocumento.BorderSize = 2;
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDocumento.Location = new System.Drawing.Point(21, 95);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumento.Multiline = false;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDocumento.PasswordChar = false;
            this.txtDocumento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDocumento.PlaceholderText = "";
            this.txtDocumento.Size = new System.Drawing.Size(138, 32);
            this.txtDocumento.TabIndex = 37;
            this.txtDocumento.Texts = "";
            this.txtDocumento.UnderlinedStyle = false;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCliente_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(210, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Cliente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Documento del cliente";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label11.Location = new System.Drawing.Point(22, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 19);
            this.label11.TabIndex = 34;
            this.label11.Text = "Detalle cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(369, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Precio de venta";
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrarVenta.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrarVenta.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrarVenta.BorderRadius = 15;
            this.btnRegistrarVenta.BorderSize = 0;
            this.btnRegistrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            this.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.etiquetas1;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(732, 394);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(101, 38);
            this.btnRegistrarVenta.TabIndex = 24;
            this.btnRegistrarVenta.Text = "  Registrar";
            this.btnRegistrarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarVenta.TextColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecioVenta.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPrecioVenta.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtPrecioVenta.BorderRadius = 15;
            this.txtPrecioVenta.BorderSize = 2;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioVenta.Location = new System.Drawing.Point(369, 180);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioVenta.Multiline = false;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrecioVenta.PasswordChar = false;
            this.txtPrecioVenta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecioVenta.PlaceholderText = "";
            this.txtPrecioVenta.Size = new System.Drawing.Size(120, 32);
            this.txtPrecioVenta.TabIndex = 32;
            this.txtPrecioVenta.Texts = "";
            this.txtPrecioVenta.UnderlinedStyle = false;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreProducto.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtNombreProducto.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtNombreProducto.BorderRadius = 15;
            this.txtNombreProducto.BorderSize = 2;
            this.txtNombreProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreProducto.Location = new System.Drawing.Point(209, 180);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Multiline = false;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreProducto.PasswordChar = false;
            this.txtNombreProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreProducto.PlaceholderText = "";
            this.txtNombreProducto.Size = new System.Drawing.Size(156, 32);
            this.txtNombreProducto.TabIndex = 28;
            this.txtNombreProducto.Texts = "";
            this.txtNombreProducto.UnderlinedStyle = false;
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducto_KeyPress);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarProducto.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarProducto.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarProducto.BorderRadius = 15;
            this.btnBuscarProducto.BorderSize = 0;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.busqueda;
            this.btnBuscarProducto.Location = new System.Drawing.Point(160, 181);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(40, 29);
            this.btnBuscarProducto.TabIndex = 27;
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.TextColor = System.Drawing.Color.White;
            this.btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtCodigo.BorderRadius = 15;
            this.txtCodigo.BorderSize = 2;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigo.Location = new System.Drawing.Point(21, 178);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.Size = new System.Drawing.Size(138, 32);
            this.txtCodigo.TabIndex = 22;
            this.txtCodigo.Texts = "";
            this.txtCodigo.UnderlinedStyle = false;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProducto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre del producto";
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarProducto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardarProducto.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardarProducto.BorderColor = System.Drawing.Color.Transparent;
            this.btnGuardarProducto.BorderRadius = 15;
            this.btnGuardarProducto.BorderSize = 0;
            this.btnGuardarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarProducto.FlatAppearance.BorderSize = 0;
            this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.ForeColor = System.Drawing.Color.White;
            this.btnGuardarProducto.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.agregar__2_;
            this.btnGuardarProducto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarProducto.Location = new System.Drawing.Point(741, 98);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(92, 93);
            this.btnGuardarProducto.TabIndex = 23;
            this.btnGuardarProducto.Text = "Agregar";
            this.btnGuardarProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardarProducto.TextColor = System.Drawing.Color.White;
            this.btnGuardarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardarProducto.UseCompatibleTextRendering = true;
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(22, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(166, 135);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProducto.TabIndex = 64;
            this.txtIdProducto.Visible = false;
            // 
            // FrmGestionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 578);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGestionVenta";
            this.Text = "FrmGestionVenta";
            this.Load += new System.EventHandler(this.FrmGestionVenta_Load);
            this.Resize += new System.EventHandler(this.FrmGestionVenta_Resize);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJTextBox txtFechaCompra;
        private CustomControls.RJControls.RJTextBox txtBuscarProducto;
        private System.Windows.Forms.Label label9;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.RJControls.RJTextBox txtTotalPagar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private CustomControls.RJControls.RJTextBox txtCantidad;
        private CustomControls.RJControls.RJTextBox txtCliente;
        private CustomControls.RJControls.RJButton btnBuscarCliente;
        private CustomControls.RJControls.RJTextBox txtDocumento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private CustomControls.RJControls.RJButton btnRegistrarVenta;
        private CustomControls.RJControls.RJTextBox txtPrecioVenta;
        private CustomControls.RJControls.RJTextBox txtNombreProducto;
        private CustomControls.RJControls.RJButton btnBuscarProducto;
        private CustomControls.RJControls.RJTextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJButton btnGuardarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Stock;
        private CustomControls.RJControls.RJTextBox txtStock;
        private CustomControls.RJControls.RJTextBox txtPagoVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tblRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.TextBox txtIdCliente;
        private CustomControls.RJControls.RJTextBox txtCambioVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtIdProducto;
    }
}