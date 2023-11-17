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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new CustomControls.RJControls.RJTextBox();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrarCompra = new CustomControls.RJControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblRegistro = new System.Windows.Forms.DataGridView();
            this.btnAgregarCompra = new CustomControls.RJControls.RJButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new CustomControls.RJControls.RJTextBox();
            this.txtNombreProducto = new CustomControls.RJControls.RJTextBox();
            this.txtPrecioVenta = new CustomControls.RJControls.RJTextBox();
            this.btnBuscarProveedor = new CustomControls.RJControls.RJButton();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCodigo = new CustomControls.RJControls.RJTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProveedor = new CustomControls.RJControls.RJTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new CustomControls.RJControls.RJButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumento = new CustomControls.RJControls.RJTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtFechaCompra = new CustomControls.RJControls.RJTextBox();
            this.fthfthfth = new CustomControls.RJControls.RJTextBox();
            this.txtBuscarProducto = new CustomControls.RJControls.RJTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.btnGuardarProducto = new CustomControls.RJControls.RJButton();
            this.awdawdawd = new CustomControls.RJControls.RJButton();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtFechaCompra);
            this.panel1.Controls.Add(this.fthfthfth);
            this.panel1.Controls.Add(this.txtBuscarProducto);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rjTextBox1);
            this.panel1.Controls.Add(this.btnGuardarProducto);
            this.panel1.Controls.Add(this.awdawdawd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 578);
            this.panel1.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtIdProducto);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.txtTotalPagar);
            this.panel3.Controls.Add(this.txtIdProveedor);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnRegistrarCompra);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnAgregarCompra);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtPrecioCompra);
            this.panel3.Controls.Add(this.txtNombreProducto);
            this.panel3.Controls.Add(this.txtPrecioVenta);
            this.panel3.Controls.Add(this.btnBuscarProveedor);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtCodigo);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtProveedor);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnBuscarProducto);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtDocumento);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Location = new System.Drawing.Point(196, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 454);
            this.panel3.TabIndex = 55;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(157, 123);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProducto.TabIndex = 48;
            this.txtIdProducto.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(26, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 15);
            this.textBox2.TabIndex = 47;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(26, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 15);
            this.textBox1.TabIndex = 46;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
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
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(167, 36);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtIdProveedor.TabIndex = 45;
            this.txtIdProveedor.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(736, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Total a pagar";
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarCompra.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrarCompra.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrarCompra.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrarCompra.BorderRadius = 15;
            this.btnRegistrarCompra.BorderSize = 0;
            this.btnRegistrarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarCompra.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCompra.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCompra.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.etiquetas1;
            this.btnRegistrarCompra.Location = new System.Drawing.Point(732, 394);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(101, 38);
            this.btnRegistrarCompra.TabIndex = 24;
            this.btnRegistrarCompra.Text = "  Registrar";
            this.btnRegistrarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarCompra.TextColor = System.Drawing.Color.White;
            this.btnRegistrarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarCompra.UseVisualStyleBackColor = false;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tblRegistro);
            this.panel2.Location = new System.Drawing.Point(23, 230);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 202);
            this.panel2.TabIndex = 44;
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
            this.PrecioCompra2,
            this.PrecioVenta2,
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
            this.tblRegistro.Size = new System.Drawing.Size(700, 202);
            this.tblRegistro.TabIndex = 17;
            this.tblRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblRegistro_CellContentClick);
            this.tblRegistro.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tblRegistro_CellPainting);
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCompra.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarCompra.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarCompra.BorderColor = System.Drawing.Color.Transparent;
            this.btnAgregarCompra.BorderRadius = 15;
            this.btnAgregarCompra.BorderSize = 0;
            this.btnAgregarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCompra.FlatAppearance.BorderSize = 0;
            this.btnAgregarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCompra.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCompra.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.agregar__2_;
            this.btnAgregarCompra.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarCompra.Location = new System.Drawing.Point(741, 134);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Size = new System.Drawing.Size(92, 93);
            this.btnAgregarCompra.TabIndex = 23;
            this.btnAgregarCompra.Text = "Agregar";
            this.btnAgregarCompra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarCompra.TextColor = System.Drawing.Color.White;
            this.btnAgregarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarCompra.UseCompatibleTextRendering = true;
            this.btnAgregarCompra.UseVisualStyleBackColor = false;
            this.btnAgregarCompra.Click += new System.EventHandler(this.btnAgregarCompra_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label11.Location = new System.Drawing.Point(13, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 19);
            this.label11.TabIndex = 34;
            this.label11.Text = "Detalle proveedor";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecioCompra.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPrecioCompra.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtPrecioCompra.BorderRadius = 15;
            this.txtPrecioCompra.BorderSize = 2;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioCompra.Location = new System.Drawing.Point(367, 169);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioCompra.Multiline = false;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrecioCompra.PasswordChar = false;
            this.txtPrecioCompra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecioCompra.PlaceholderText = "";
            this.txtPrecioCompra.Size = new System.Drawing.Size(120, 32);
            this.txtPrecioCompra.TabIndex = 31;
            this.txtPrecioCompra.Texts = "";
            this.txtPrecioCompra.UnderlinedStyle = false;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
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
            this.txtNombreProducto.Location = new System.Drawing.Point(207, 169);
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
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecioVenta.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPrecioVenta.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtPrecioVenta.BorderRadius = 15;
            this.txtPrecioVenta.BorderSize = 2;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioVenta.Location = new System.Drawing.Point(492, 169);
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
            this.btnBuscarProveedor.Location = new System.Drawing.Point(158, 87);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(40, 29);
            this.btnBuscarProveedor.TabIndex = 27;
            this.btnBuscarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProveedor.TextColor = System.Drawing.Color.White;
            this.btnBuscarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(624, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "Cantidad";
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
            this.txtCodigo.Location = new System.Drawing.Point(18, 169);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.Size = new System.Drawing.Size(138, 32);
            this.txtCodigo.TabIndex = 22;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Texts = "";
            this.txtCodigo.UnderlinedStyle = false;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProducto_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(494, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Precio de venta";
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
            this.txtCantidad.Location = new System.Drawing.Point(622, 169);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre del producto";
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
            this.txtProveedor.Location = new System.Drawing.Point(205, 84);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedor.Multiline = false;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProveedor.PasswordChar = false;
            this.txtProveedor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProveedor.PlaceholderText = "";
            this.txtProveedor.Size = new System.Drawing.Size(158, 32);
            this.txtProveedor.TabIndex = 39;
            this.txtProveedor.Texts = "";
            this.txtProveedor.UnderlinedStyle = false;
            this.txtProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProveedor_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Documento del proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(13, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle producto";
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
            this.btnBuscarProducto.Location = new System.Drawing.Point(158, 171);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(40, 29);
            this.btnBuscarProducto.TabIndex = 38;
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.TextColor = System.Drawing.Color.White;
            this.btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(206, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Proveedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(368, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Precio de compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
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
            this.txtDocumento.Location = new System.Drawing.Point(18, 84);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumento.Multiline = false;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDocumento.PasswordChar = false;
            this.txtDocumento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDocumento.PlaceholderText = "";
            this.txtDocumento.Size = new System.Drawing.Size(138, 32);
            this.txtDocumento.TabIndex = 37;
            this.txtDocumento.TabStop = false;
            this.txtDocumento.Texts = "";
            this.txtDocumento.UnderlinedStyle = false;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProveedor_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(531, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(485, 27);
            this.panel4.TabIndex = 54;
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
            this.txtFechaCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFechaCompra_KeyPress);
            // 
            // fthfthfth
            // 
            this.fthfthfth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fthfthfth.BackColor = System.Drawing.SystemColors.Window;
            this.fthfthfth.BorderColor = System.Drawing.Color.SteelBlue;
            this.fthfthfth.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.fthfthfth.BorderRadius = 15;
            this.fthfthfth.BorderSize = 2;
            this.fthfthfth.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fthfthfth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fthfthfth.Location = new System.Drawing.Point(1759, 470);
            this.fthfthfth.Margin = new System.Windows.Forms.Padding(4);
            this.fthfthfth.Multiline = false;
            this.fthfthfth.Name = "fthfthfth";
            this.fthfthfth.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.fthfthfth.PasswordChar = false;
            this.fthfthfth.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.fthfthfth.PlaceholderText = "";
            this.fthfthfth.Size = new System.Drawing.Size(101, 32);
            this.fthfthfth.TabIndex = 43;
            this.fthfthfth.Texts = "";
            this.fthfthfth.UnderlinedStyle = false;
            this.fthfthfth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjTextBox5_KeyPress);
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
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1763, 450);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 17);
            this.label15.TabIndex = 42;
            this.label15.Text = "Total a pagar";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(207, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 19);
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
            this.btnGuardarProducto.Location = new System.Drawing.Point(1767, 238);
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
            // awdawdawd
            // 
            this.awdawdawd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.awdawdawd.BackColor = System.Drawing.Color.RoyalBlue;
            this.awdawdawd.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.awdawdawd.BorderColor = System.Drawing.Color.RoyalBlue;
            this.awdawdawd.BorderRadius = 15;
            this.awdawdawd.BorderSize = 0;
            this.awdawdawd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.awdawdawd.FlatAppearance.BorderSize = 0;
            this.awdawdawd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.awdawdawd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awdawdawd.ForeColor = System.Drawing.Color.White;
            this.awdawdawd.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.etiquetas1;
            this.awdawdawd.Location = new System.Drawing.Point(1759, 509);
            this.awdawdawd.Name = "awdawdawd";
            this.awdawdawd.Size = new System.Drawing.Size(101, 38);
            this.awdawdawd.TabIndex = 24;
            this.awdawdawd.Text = "  Registrar";
            this.awdawdawd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.awdawdawd.TextColor = System.Drawing.Color.White;
            this.awdawdawd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.awdawdawd.UseVisualStyleBackColor = false;
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
            // PrecioCompra2
            // 
            this.PrecioCompra2.HeaderText = "Precio de compra";
            this.PrecioCompra2.Name = "PrecioCompra2";
            this.PrecioCompra2.ReadOnly = true;
            this.PrecioCompra2.Width = 140;
            // 
            // PrecioVenta2
            // 
            this.PrecioVenta2.HeaderText = "Precio de venta";
            this.PrecioVenta2.Name = "PrecioVenta2";
            this.PrecioVenta2.ReadOnly = true;
            this.PrecioVenta2.Visible = false;
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
            // FrmGestionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 578);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGestionCompra";
            this.Text = "FrmGestionCompra";
            this.Load += new System.EventHandler(this.FrmGestionCompra_Load);
            this.Resize += new System.EventHandler(this.FrmGestionCompra_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJTextBox txtPrecioVenta;
        private CustomControls.RJControls.RJTextBox txtPrecioCompra;
        private CustomControls.RJControls.RJTextBox txtNombreProducto;
        private CustomControls.RJControls.RJButton btnBuscarProveedor;
        private CustomControls.RJControls.RJTextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJButton awdawdawd;
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
        private CustomControls.RJControls.RJTextBox txtCantidad;
        private CustomControls.RJControls.RJTextBox fthfthfth;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Panel panel4;
        private CustomControls.RJControls.RJTextBox txtBuscarProducto;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.RJControls.RJTextBox txtTotalPagar;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJButton btnRegistrarCompra;
        private CustomControls.RJControls.RJButton btnAgregarCompra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.DataGridView tblRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
    }
}