namespace Sistema_de_Gestion_GUI
{
    partial class FrmGestionDetalleCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNumDoc = new CustomControls.RJControls.RJTextBox();
            this.txtMontoTotal = new CustomControls.RJControls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tblRegistro = new System.Windows.Forms.DataGridView();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarCompra = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaCompra = new CustomControls.RJControls.RJTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProveedor = new CustomControls.RJControls.RJTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDocumento = new CustomControls.RJControls.RJTextBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.btnDescargarPDF = new CustomControls.RJControls.RJButton();
            this.btnBuscarCompra = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 578);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.txtNumDoc);
            this.panel2.Controls.Add(this.txtMontoTotal);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnDescargarPDF);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnBuscarCompra);
            this.panel2.Controls.Add(this.txtBuscarCompra);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtFechaCompra);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtProveedor);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtDocumento);
            this.panel2.Location = new System.Drawing.Point(251, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 551);
            this.panel2.TabIndex = 0;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumDoc.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtNumDoc.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtNumDoc.BorderRadius = 15;
            this.txtNumDoc.BorderSize = 2;
            this.txtNumDoc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumDoc.Location = new System.Drawing.Point(347, 158);
            this.txtNumDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumDoc.Multiline = false;
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumDoc.PasswordChar = false;
            this.txtNumDoc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumDoc.PlaceholderText = "";
            this.txtNumDoc.Size = new System.Drawing.Size(158, 32);
            this.txtNumDoc.TabIndex = 59;
            this.txtNumDoc.Texts = "";
            this.txtNumDoc.UnderlinedStyle = false;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMontoTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtMontoTotal.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtMontoTotal.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtMontoTotal.BorderRadius = 15;
            this.txtMontoTotal.BorderSize = 2;
            this.txtMontoTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMontoTotal.Location = new System.Drawing.Point(24, 510);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoTotal.Multiline = false;
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMontoTotal.PasswordChar = false;
            this.txtMontoTotal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMontoTotal.PlaceholderText = "";
            this.txtMontoTotal.Size = new System.Drawing.Size(134, 32);
            this.txtMontoTotal.TabIndex = 58;
            this.txtMontoTotal.Texts = "";
            this.txtMontoTotal.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Monto de la compra";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Documento de la compra:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.tblRegistro);
            this.panel3.Location = new System.Drawing.Point(24, 312);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(694, 173);
            this.panel3.TabIndex = 45;
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
            this.NombreProducto,
            this.PrecioCompra,
            this.Cantidad,
            this.SubTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblRegistro.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRegistro.EnableHeadersVisualStyles = false;
            this.tblRegistro.Location = new System.Drawing.Point(0, 0);
            this.tblRegistro.MultiSelect = false;
            this.tblRegistro.Name = "tblRegistro";
            this.tblRegistro.ReadOnly = true;
            this.tblRegistro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblRegistro.RowHeadersVisible = false;
            this.tblRegistro.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.tblRegistro.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tblRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblRegistro.Size = new System.Drawing.Size(694, 173);
            this.tblRegistro.TabIndex = 17;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 150;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio de compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 210;
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
            this.SubTotal.Width = 180;
            // 
            // txtBuscarCompra
            // 
            this.txtBuscarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarCompra.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBuscarCompra.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtBuscarCompra.BorderFocusColor = System.Drawing.Color.Gainsboro;
            this.txtBuscarCompra.BorderRadius = 15;
            this.txtBuscarCompra.BorderSize = 2;
            this.txtBuscarCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCompra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarCompra.Location = new System.Drawing.Point(435, 62);
            this.txtBuscarCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarCompra.Multiline = false;
            this.txtBuscarCompra.Name = "txtBuscarCompra";
            this.txtBuscarCompra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscarCompra.PasswordChar = false;
            this.txtBuscarCompra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarCompra.PlaceholderText = "";
            this.txtBuscarCompra.Size = new System.Drawing.Size(201, 32);
            this.txtBuscarCompra.TabIndex = 53;
            this.txtBuscarCompra.Texts = "Buscar:";
            this.txtBuscarCompra.UnderlinedStyle = false;
            this.txtBuscarCompra.Enter += new System.EventHandler(this.txtBuscarCompra_Enter);
            this.txtBuscarCompra.Leave += new System.EventHandler(this.txtBuscarCompra_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(31, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 52;
            this.label4.Text = "Detalle compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Detalle Compra";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtUsuario.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtUsuario.BorderRadius = 15;
            this.txtUsuario.BorderSize = 2;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.Location = new System.Drawing.Point(181, 158);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.Size = new System.Drawing.Size(158, 32);
            this.txtUsuario.TabIndex = 51;
            this.txtUsuario.Texts = "";
            this.txtUsuario.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Fecha de la compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Usuario";
            // 
            // txtFechaCompra
            // 
            this.txtFechaCompra.BackColor = System.Drawing.SystemColors.Window;
            this.txtFechaCompra.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtFechaCompra.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtFechaCompra.BorderRadius = 15;
            this.txtFechaCompra.BorderSize = 2;
            this.txtFechaCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFechaCompra.Location = new System.Drawing.Point(35, 158);
            this.txtFechaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaCompra.Multiline = false;
            this.txtFechaCompra.Name = "txtFechaCompra";
            this.txtFechaCompra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFechaCompra.PasswordChar = false;
            this.txtFechaCompra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFechaCompra.PlaceholderText = "";
            this.txtFechaCompra.Size = new System.Drawing.Size(138, 32);
            this.txtFechaCompra.TabIndex = 50;
            this.txtFechaCompra.Texts = "";
            this.txtFechaCompra.UnderlinedStyle = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label11.Location = new System.Drawing.Point(31, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 19);
            this.label11.TabIndex = 41;
            this.label11.Text = "Detalle proveedor";
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtProveedor.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtProveedor.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtProveedor.BorderRadius = 15;
            this.txtProveedor.BorderSize = 2;
            this.txtProveedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProveedor.Location = new System.Drawing.Point(223, 253);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedor.Multiline = false;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProveedor.PasswordChar = false;
            this.txtProveedor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProveedor.PlaceholderText = "";
            this.txtProveedor.Size = new System.Drawing.Size(158, 32);
            this.txtProveedor.TabIndex = 45;
            this.txtProveedor.Texts = "";
            this.txtProveedor.UnderlinedStyle = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 17);
            this.label13.TabIndex = 42;
            this.label13.Text = "Documento del proveedor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(224, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Proveedor";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDocumento.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtDocumento.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtDocumento.BorderRadius = 15;
            this.txtDocumento.BorderSize = 2;
            this.txtDocumento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDocumento.Location = new System.Drawing.Point(36, 253);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumento.Multiline = false;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDocumento.PasswordChar = false;
            this.txtDocumento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDocumento.PlaceholderText = "";
            this.txtDocumento.Size = new System.Drawing.Size(138, 32);
            this.txtDocumento.TabIndex = 44;
            this.txtDocumento.Texts = "";
            this.txtDocumento.UnderlinedStyle = false;
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.LightGray;
            this.rjButton1.BackgroundColor = System.Drawing.Color.LightGray;
            this.rjButton1.BorderColor = System.Drawing.Color.LightGray;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjButton1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.escoba1;
            this.rjButton1.Location = new System.Drawing.Point(687, 62);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(39, 32);
            this.rjButton1.TabIndex = 60;
            this.rjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnDescargarPDF
            // 
            this.btnDescargarPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescargarPDF.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDescargarPDF.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnDescargarPDF.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnDescargarPDF.BorderRadius = 15;
            this.btnDescargarPDF.BorderSize = 0;
            this.btnDescargarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescargarPDF.FlatAppearance.BorderSize = 0;
            this.btnDescargarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargarPDF.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarPDF.ForeColor = System.Drawing.Color.White;
            this.btnDescargarPDF.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.etiquetas1;
            this.btnDescargarPDF.Location = new System.Drawing.Point(617, 502);
            this.btnDescargarPDF.Name = "btnDescargarPDF";
            this.btnDescargarPDF.Size = new System.Drawing.Size(101, 32);
            this.btnDescargarPDF.TabIndex = 56;
            this.btnDescargarPDF.Text = "Descargar";
            this.btnDescargarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescargarPDF.TextColor = System.Drawing.Color.White;
            this.btnDescargarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargarPDF.UseVisualStyleBackColor = false;
            this.btnDescargarPDF.Click += new System.EventHandler(this.btnDescargarPDF_Click);
            // 
            // btnBuscarCompra
            // 
            this.btnBuscarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCompra.BackColor = System.Drawing.Color.LightGray;
            this.btnBuscarCompra.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnBuscarCompra.BorderColor = System.Drawing.Color.LightGray;
            this.btnBuscarCompra.BorderRadius = 15;
            this.btnBuscarCompra.BorderSize = 0;
            this.btnBuscarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCompra.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnBuscarCompra.FlatAppearance.BorderSize = 0;
            this.btnBuscarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCompra.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCompra.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.busqueda;
            this.btnBuscarCompra.Location = new System.Drawing.Point(643, 62);
            this.btnBuscarCompra.Name = "btnBuscarCompra";
            this.btnBuscarCompra.Size = new System.Drawing.Size(39, 32);
            this.btnBuscarCompra.TabIndex = 54;
            this.btnBuscarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCompra.TextColor = System.Drawing.Color.White;
            this.btnBuscarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarCompra.UseVisualStyleBackColor = false;
            this.btnBuscarCompra.Click += new System.EventHandler(this.btnBuscarCompra_Click);
            // 
            // FrmGestionDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 578);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGestionDetalleCompra";
            this.Text = "FrmGestionDetalleCompra";
            this.Load += new System.EventHandler(this.FrmGestionDetalleCompra_Load);
            this.Resize += new System.EventHandler(this.FrmGestionDetalleCompra_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox txtFechaCompra;
        private System.Windows.Forms.Label label11;
        private CustomControls.RJControls.RJTextBox txtProveedor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private CustomControls.RJControls.RJTextBox txtDocumento;
        private CustomControls.RJControls.RJTextBox txtBuscarCompra;
        private CustomControls.RJControls.RJButton btnBuscarCompra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tblRegistro;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJTextBox txtMontoTotal;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.RJButton btnDescargarPDF;
        private CustomControls.RJControls.RJTextBox txtNumDoc;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}