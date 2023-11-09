namespace Sistema_de_Gestion_GUI
{
    partial class FrmGestionCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFechaCompra = new CustomControls.RJControls.RJTextBox();
            this.txtBuscarProducto = new CustomControls.RJControls.RJTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rjTextBox5 = new CustomControls.RJControls.RJTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tblRegistro = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rjTextBox4 = new CustomControls.RJControls.RJTextBox();
            this.txtProveedor = new CustomControls.RJControls.RJTextBox();
            this.btnBuscarProducto = new CustomControls.RJControls.RJButton();
            this.txtDocumento = new CustomControls.RJControls.RJTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnModificarProducto = new CustomControls.RJControls.RJButton();
            this.txtPrecioVenta = new CustomControls.RJControls.RJTextBox();
            this.txtPrecioCompra = new CustomControls.RJControls.RJTextBox();
            this.txtNombreProducto = new CustomControls.RJControls.RJTextBox();
            this.btnBuscarProveedor = new CustomControls.RJControls.RJButton();
            this.txtIdProducto = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarProducto = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.txtFechaCompra);
            this.panel1.Controls.Add(this.txtBuscarProducto);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rjTextBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1617, 711);
            this.panel1.TabIndex = 45;
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
            this.txtFechaCompra.Location = new System.Drawing.Point(261, 78);
            this.txtFechaCompra.Margin = new System.Windows.Forms.Padding(5);
            this.txtFechaCompra.Multiline = false;
            this.txtFechaCompra.Name = "txtFechaCompra";
            this.txtFechaCompra.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtFechaCompra.PasswordChar = false;
            this.txtFechaCompra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFechaCompra.PlaceholderText = "";
            this.txtFechaCompra.Size = new System.Drawing.Size(423, 39);
            this.txtFechaCompra.TabIndex = 53;
            this.txtFechaCompra.Texts = "Fecha";
            this.txtFechaCompra.UnderlinedStyle = false;
            this.txtFechaCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFechaCompra_KeyPress);
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
            this.txtBuscarProducto.Location = new System.Drawing.Point(695, 78);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(5);
            this.txtBuscarProducto.Multiline = false;
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtBuscarProducto.PasswordChar = false;
            this.txtBuscarProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarProducto.PlaceholderText = "";
            this.txtBuscarProducto.Size = new System.Drawing.Size(695, 39);
            this.txtBuscarProducto.TabIndex = 20;
            this.txtBuscarProducto.Texts = "Buscar:";
            this.txtBuscarProducto.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Registrar Compra";
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
            this.rjTextBox1.Location = new System.Drawing.Point(261, 25);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(1128, 43);
            this.rjTextBox1.TabIndex = 22;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.rjTextBox5);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.rjTextBox4);
            this.panel3.Controls.Add(this.txtProveedor);
            this.panel3.Controls.Add(this.btnBuscarProducto);
            this.panel3.Controls.Add(this.txtDocumento);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnModificarProducto);
            this.panel3.Controls.Add(this.txtPrecioVenta);
            this.panel3.Controls.Add(this.txtPrecioCompra);
            this.panel3.Controls.Add(this.txtNombreProducto);
            this.panel3.Controls.Add(this.btnBuscarProveedor);
            this.panel3.Controls.Add(this.txtIdProducto);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnGuardarProducto);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Location = new System.Drawing.Point(262, 138);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.MaximumSize = new System.Drawing.Size(1128, 547);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 547);
            this.panel3.TabIndex = 52;
            // 
            // rjTextBox5
            // 
            this.rjTextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox5.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox5.BorderColor = System.Drawing.Color.SteelBlue;
            this.rjTextBox5.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.rjTextBox5.BorderRadius = 15;
            this.rjTextBox5.BorderSize = 2;
            this.rjTextBox5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox5.Location = new System.Drawing.Point(976, 402);
            this.rjTextBox5.Margin = new System.Windows.Forms.Padding(5);
            this.rjTextBox5.Multiline = false;
            this.rjTextBox5.Name = "rjTextBox5";
            this.rjTextBox5.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.rjTextBox5.PasswordChar = false;
            this.rjTextBox5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox5.PlaceholderText = "";
            this.rjTextBox5.Size = new System.Drawing.Size(135, 39);
            this.rjTextBox5.TabIndex = 43;
            this.rjTextBox5.Texts = "";
            this.rjTextBox5.UnderlinedStyle = false;
            this.rjTextBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBox5_KeyPress);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(981, 378);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 20);
            this.label15.TabIndex = 42;
            this.label15.Text = "Total a pagar";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(844, 170);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 41;
            this.label14.Text = "Cantidad";
            // 
            // tblRegistro
            // 
            this.tblRegistro.AllowUserToAddRows = false;
            this.tblRegistro.AllowUserToDeleteRows = false;
            this.tblRegistro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.tblRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblRegistro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblRegistro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tblRegistro.ColumnHeadersHeight = 30;
            this.tblRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.NombreProducto,
            this.PrecioCompra,
            this.SubTotal,
            this.FechaRegistro});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblRegistro.DefaultCellStyle = dataGridViewCellStyle7;
            this.tblRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRegistro.EnableHeadersVisualStyles = false;
            this.tblRegistro.Location = new System.Drawing.Point(0, 0);
            this.tblRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.tblRegistro.MultiSelect = false;
            this.tblRegistro.Name = "tblRegistro";
            this.tblRegistro.ReadOnly = true;
            this.tblRegistro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblRegistro.RowHeadersVisible = false;
            this.tblRegistro.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.tblRegistro.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.tblRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblRegistro.Size = new System.Drawing.Size(933, 248);
            this.tblRegistro.TabIndex = 17;
            this.tblRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblRegistro_CellContentClick);
            // 
            // btnSeleccionar
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnSeleccionar.DefaultCellStyle = dataGridViewCellStyle6;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 3;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Text = "Id de producto";
            this.btnSeleccionar.Width = 30;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 210;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio de compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 210;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 220;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha de compra";
            this.FechaRegistro.MinimumWidth = 6;
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 260;
            // 
            // rjTextBox4
            // 
            this.rjTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox4.BorderColor = System.Drawing.Color.SteelBlue;
            this.rjTextBox4.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.rjTextBox4.BorderRadius = 15;
            this.rjTextBox4.BorderSize = 2;
            this.rjTextBox4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox4.Location = new System.Drawing.Point(841, 194);
            this.rjTextBox4.Margin = new System.Windows.Forms.Padding(5);
            this.rjTextBox4.Multiline = false;
            this.rjTextBox4.Name = "rjTextBox4";
            this.rjTextBox4.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.rjTextBox4.PasswordChar = false;
            this.rjTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox4.PlaceholderText = "";
            this.rjTextBox4.Size = new System.Drawing.Size(128, 39);
            this.rjTextBox4.TabIndex = 40;
            this.rjTextBox4.Texts = "";
            this.rjTextBox4.UnderlinedStyle = false;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProveedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtProveedor.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtProveedor.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtProveedor.BorderRadius = 15;
            this.txtProveedor.BorderSize = 2;
            this.txtProveedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProveedor.Location = new System.Drawing.Point(285, 90);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(5);
            this.txtProveedor.Multiline = false;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtProveedor.PasswordChar = false;
            this.txtProveedor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProveedor.PlaceholderText = "";
            this.txtProveedor.Size = new System.Drawing.Size(211, 39);
            this.txtProveedor.TabIndex = 39;
            this.txtProveedor.Texts = "";
            this.txtProveedor.UnderlinedStyle = false;
            this.txtProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProveedor_KeyPress);
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
            this.btnBuscarProducto.Location = new System.Drawing.Point(223, 197);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(53, 36);
            this.btnBuscarProducto.TabIndex = 38;
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.TextColor = System.Drawing.Color.White;
            this.btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocumento.BackColor = System.Drawing.SystemColors.Window;
            this.txtDocumento.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtDocumento.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtDocumento.BorderRadius = 15;
            this.txtDocumento.BorderSize = 2;
            this.txtDocumento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDocumento.Location = new System.Drawing.Point(36, 90);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(5);
            this.txtDocumento.Multiline = false;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtDocumento.PasswordChar = false;
            this.txtDocumento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDocumento.PlaceholderText = "";
            this.txtDocumento.Size = new System.Drawing.Size(184, 39);
            this.txtDocumento.TabIndex = 37;
            this.txtDocumento.Texts = "";
            this.txtDocumento.UnderlinedStyle = false;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProveedor_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(287, 65);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 36;
            this.label12.Text = "Proveedor";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 65);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 20);
            this.label13.TabIndex = 35;
            this.label13.Text = "Documento del proveedor";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label11.Location = new System.Drawing.Point(29, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 23);
            this.label11.TabIndex = 34;
            this.label11.Text = "Detalle proveedor";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(671, 170);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Precio de venta";
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificarProducto.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnModificarProducto.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnModificarProducto.BorderRadius = 15;
            this.btnModificarProducto.BorderSize = 0;
            this.btnModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProducto.FlatAppearance.BorderSize = 0;
            this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.ForeColor = System.Drawing.Color.White;
            this.btnModificarProducto.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.etiquetas1;
            this.btnModificarProducto.Location = new System.Drawing.Point(976, 450);
            this.btnModificarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(135, 47);
            this.btnModificarProducto.TabIndex = 24;
            this.btnModificarProducto.Text = "  Registrar";
            this.btnModificarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarProducto.TextColor = System.Drawing.Color.White;
            this.btnModificarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioVenta.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecioVenta.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPrecioVenta.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtPrecioVenta.BorderRadius = 15;
            this.txtPrecioVenta.BorderSize = 2;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioVenta.Location = new System.Drawing.Point(668, 194);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrecioVenta.Multiline = false;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtPrecioVenta.PasswordChar = false;
            this.txtPrecioVenta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecioVenta.PlaceholderText = "";
            this.txtPrecioVenta.Size = new System.Drawing.Size(160, 39);
            this.txtPrecioVenta.TabIndex = 32;
            this.txtPrecioVenta.Texts = "";
            this.txtPrecioVenta.UnderlinedStyle = false;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioCompra.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecioCompra.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPrecioCompra.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtPrecioCompra.BorderRadius = 15;
            this.txtPrecioCompra.BorderSize = 2;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioCompra.Location = new System.Drawing.Point(501, 194);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrecioCompra.Multiline = false;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtPrecioCompra.PasswordChar = false;
            this.txtPrecioCompra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecioCompra.PlaceholderText = "";
            this.txtPrecioCompra.Size = new System.Drawing.Size(160, 39);
            this.txtPrecioCompra.TabIndex = 31;
            this.txtPrecioCompra.Texts = "";
            this.txtPrecioCompra.UnderlinedStyle = false;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreProducto.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtNombreProducto.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtNombreProducto.BorderRadius = 15;
            this.txtNombreProducto.BorderSize = 2;
            this.txtNombreProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreProducto.Location = new System.Drawing.Point(288, 194);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombreProducto.Multiline = false;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtNombreProducto.PasswordChar = false;
            this.txtNombreProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreProducto.PlaceholderText = "";
            this.txtNombreProducto.Size = new System.Drawing.Size(208, 39);
            this.txtNombreProducto.TabIndex = 28;
            this.txtNombreProducto.Texts = "";
            this.txtNombreProducto.UnderlinedStyle = false;
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducto_KeyPress);
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarProveedor.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarProveedor.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarProveedor.BorderRadius = 15;
            this.btnBuscarProveedor.BorderSize = 0;
            this.btnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProveedor.FlatAppearance.BorderSize = 0;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProveedor.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.busqueda;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(223, 93);
            this.btnBuscarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(53, 36);
            this.btnBuscarProveedor.TabIndex = 27;
            this.btnBuscarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProveedor.TextColor = System.Drawing.Color.White;
            this.btnBuscarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdProducto.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtIdProducto.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtIdProducto.BorderRadius = 15;
            this.txtIdProducto.BorderSize = 2;
            this.txtIdProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdProducto.Location = new System.Drawing.Point(36, 194);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdProducto.Multiline = false;
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtIdProducto.PasswordChar = false;
            this.txtIdProducto.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdProducto.PlaceholderText = "";
            this.txtIdProducto.Size = new System.Drawing.Size(184, 39);
            this.txtIdProducto.TabIndex = 22;
            this.txtIdProducto.Texts = "";
            this.txtIdProducto.UnderlinedStyle = false;
            this.txtIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProducto_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre del producto";
            // 
            // btnGuardarProducto
            // 
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
            this.btnGuardarProducto.Location = new System.Drawing.Point(988, 138);
            this.btnGuardarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(123, 114);
            this.btnGuardarProducto.TabIndex = 23;
            this.btnGuardarProducto.Text = "Agregar";
            this.btnGuardarProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardarProducto.TextColor = System.Drawing.Color.White;
            this.btnGuardarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardarProducto.UseCompatibleTextRendering = true;
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(29, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle producto";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id del Producto";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(503, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Precio de compra";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tblRegistro);
            this.panel2.Location = new System.Drawing.Point(36, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 248);
            this.panel2.TabIndex = 44;
            // 
            // FrmGestionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 711);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestionCompra";
            this.Text = "FrmGestionCompra";
            this.Load += new System.EventHandler(this.FrmGestionCompra_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tblRegistro;
        private CustomControls.RJControls.RJTextBox txtBuscarProducto;
        private System.Windows.Forms.Label label9;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.RJControls.RJTextBox txtPrecioVenta;
        private CustomControls.RJControls.RJTextBox txtPrecioCompra;
        private CustomControls.RJControls.RJTextBox txtNombreProducto;
        private CustomControls.RJControls.RJButton btnBuscarProveedor;
        private CustomControls.RJControls.RJTextBox txtIdProducto;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJButton btnModificarProducto;
        private CustomControls.RJControls.RJButton btnGuardarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private CustomControls.RJControls.RJTextBox txtFechaCompra;
        private System.Windows.Forms.Label label10;
        private CustomControls.RJControls.RJTextBox txtProveedor;
        private CustomControls.RJControls.RJButton btnBuscarProducto;
        private CustomControls.RJControls.RJTextBox txtDocumento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private CustomControls.RJControls.RJTextBox rjTextBox4;
        private CustomControls.RJControls.RJTextBox rjTextBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.Panel panel2;
    }
}