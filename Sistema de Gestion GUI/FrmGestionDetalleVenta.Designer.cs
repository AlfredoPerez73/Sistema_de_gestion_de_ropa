namespace Sistema_de_Gestion_GUI
{
    partial class FrmGestionDetalleVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.txtNumDoc = new CustomControls.RJControls.RJTextBox();
            this.txtMontoTotal = new CustomControls.RJControls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDescargarPDF = new CustomControls.RJControls.RJButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tblRegistro = new System.Windows.Forms.DataGridView();
            this.btnBuscarVenta = new CustomControls.RJControls.RJButton();
            this.txtBuscarVenta = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaVenta = new CustomControls.RJControls.RJTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCliente = new CustomControls.RJControls.RJTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDocumento = new CustomControls.RJControls.RJTextBox();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMontoPago = new CustomControls.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMontoCambio = new CustomControls.RJControls.RJTextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtMontoCambio);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtMontoPago);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.txtNumDoc);
            this.panel2.Controls.Add(this.txtMontoTotal);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnDescargarPDF);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnBuscarVenta);
            this.panel2.Controls.Add(this.txtBuscarVenta);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtFechaVenta);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtCliente);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtDocumento);
            this.panel2.Location = new System.Drawing.Point(251, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 551);
            this.panel2.TabIndex = 0;
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
            this.txtNumDoc.Visible = false;
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
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Documento de la venta:";
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.tblRegistro.ColumnHeadersHeight = 30;
            this.tblRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblRegistro.DefaultCellStyle = dataGridViewCellStyle14;
            this.tblRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRegistro.EnableHeadersVisualStyles = false;
            this.tblRegistro.Location = new System.Drawing.Point(0, 0);
            this.tblRegistro.MultiSelect = false;
            this.tblRegistro.Name = "tblRegistro";
            this.tblRegistro.ReadOnly = true;
            this.tblRegistro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblRegistro.RowHeadersVisible = false;
            this.tblRegistro.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.tblRegistro.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.tblRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblRegistro.Size = new System.Drawing.Size(694, 173);
            this.tblRegistro.TabIndex = 17;
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarVenta.BackColor = System.Drawing.Color.LightGray;
            this.btnBuscarVenta.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnBuscarVenta.BorderColor = System.Drawing.Color.LightGray;
            this.btnBuscarVenta.BorderRadius = 15;
            this.btnBuscarVenta.BorderSize = 0;
            this.btnBuscarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarVenta.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnBuscarVenta.FlatAppearance.BorderSize = 0;
            this.btnBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVenta.ForeColor = System.Drawing.Color.White;
            this.btnBuscarVenta.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.busqueda;
            this.btnBuscarVenta.Location = new System.Drawing.Point(643, 62);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(39, 32);
            this.btnBuscarVenta.TabIndex = 54;
            this.btnBuscarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarVenta.TextColor = System.Drawing.Color.White;
            this.btnBuscarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarVenta.UseVisualStyleBackColor = false;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // txtBuscarVenta
            // 
            this.txtBuscarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarVenta.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBuscarVenta.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtBuscarVenta.BorderFocusColor = System.Drawing.Color.Gainsboro;
            this.txtBuscarVenta.BorderRadius = 15;
            this.txtBuscarVenta.BorderSize = 2;
            this.txtBuscarVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarVenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarVenta.Location = new System.Drawing.Point(435, 62);
            this.txtBuscarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarVenta.Multiline = false;
            this.txtBuscarVenta.Name = "txtBuscarVenta";
            this.txtBuscarVenta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscarVenta.PasswordChar = false;
            this.txtBuscarVenta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarVenta.PlaceholderText = "";
            this.txtBuscarVenta.Size = new System.Drawing.Size(201, 32);
            this.txtBuscarVenta.TabIndex = 53;
            this.txtBuscarVenta.Texts = "Buscar:";
            this.txtBuscarVenta.UnderlinedStyle = false;
            this.txtBuscarVenta.Enter += new System.EventHandler(this.txtBuscarVenta_Enter);
            this.txtBuscarVenta.Leave += new System.EventHandler(this.txtBuscarVenta_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(31, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 52;
            this.label4.Text = "Detalle venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Detalle Venta";
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
            // txtFechaVenta
            // 
            this.txtFechaVenta.BackColor = System.Drawing.SystemColors.Window;
            this.txtFechaVenta.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtFechaVenta.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtFechaVenta.BorderRadius = 15;
            this.txtFechaVenta.BorderSize = 2;
            this.txtFechaVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFechaVenta.Location = new System.Drawing.Point(35, 158);
            this.txtFechaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaVenta.Multiline = false;
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFechaVenta.PasswordChar = false;
            this.txtFechaVenta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFechaVenta.PlaceholderText = "";
            this.txtFechaVenta.Size = new System.Drawing.Size(138, 32);
            this.txtFechaVenta.TabIndex = 50;
            this.txtFechaVenta.Texts = "";
            this.txtFechaVenta.UnderlinedStyle = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label11.Location = new System.Drawing.Point(31, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 19);
            this.label11.TabIndex = 41;
            this.label11.Text = "Detalle cliente";
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
            this.txtCliente.Location = new System.Drawing.Point(223, 253);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Multiline = false;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCliente.PasswordChar = false;
            this.txtCliente.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCliente.PlaceholderText = "";
            this.txtCliente.Size = new System.Drawing.Size(158, 32);
            this.txtCliente.TabIndex = 45;
            this.txtCliente.Texts = "";
            this.txtCliente.UnderlinedStyle = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 17);
            this.label13.TabIndex = 42;
            this.label13.Text = "Documento del cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(224, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Cliente";
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
            this.SubTotal.Width = 180;
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMontoPago.BackColor = System.Drawing.SystemColors.Window;
            this.txtMontoPago.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtMontoPago.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtMontoPago.BorderRadius = 15;
            this.txtMontoPago.BorderSize = 2;
            this.txtMontoPago.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMontoPago.Location = new System.Drawing.Point(181, 510);
            this.txtMontoPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoPago.Multiline = false;
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMontoPago.PasswordChar = false;
            this.txtMontoPago.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMontoPago.PlaceholderText = "";
            this.txtMontoPago.Size = new System.Drawing.Size(134, 32);
            this.txtMontoPago.TabIndex = 62;
            this.txtMontoPago.Texts = "";
            this.txtMontoPago.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(185, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "Monto del pago";
            // 
            // txtMontoCambio
            // 
            this.txtMontoCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMontoCambio.BackColor = System.Drawing.SystemColors.Window;
            this.txtMontoCambio.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtMontoCambio.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtMontoCambio.BorderRadius = 15;
            this.txtMontoCambio.BorderSize = 2;
            this.txtMontoCambio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMontoCambio.Location = new System.Drawing.Point(337, 510);
            this.txtMontoCambio.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoCambio.Multiline = false;
            this.txtMontoCambio.Name = "txtMontoCambio";
            this.txtMontoCambio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMontoCambio.PasswordChar = false;
            this.txtMontoCambio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMontoCambio.PlaceholderText = "";
            this.txtMontoCambio.Size = new System.Drawing.Size(134, 32);
            this.txtMontoCambio.TabIndex = 64;
            this.txtMontoCambio.Texts = "";
            this.txtMontoCambio.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(341, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 63;
            this.label8.Text = "Monto del cambio";
            // 
            // FrmGestionDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 578);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGestionDetalleVenta";
            this.Text = "FrmGestionDetalleVenta";
            this.Load += new System.EventHandler(this.FrmGestionDetalleVenta_Load);
            this.Resize += new System.EventHandler(this.FrmGestionDetalleVenta_Resize);
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
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJTextBox txtNumDoc;
        private CustomControls.RJControls.RJTextBox txtMontoTotal;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.RJButton btnDescargarPDF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tblRegistro;
        private CustomControls.RJControls.RJButton btnBuscarVenta;
        private CustomControls.RJControls.RJTextBox txtBuscarVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox txtFechaVenta;
        private System.Windows.Forms.Label label11;
        private CustomControls.RJControls.RJTextBox txtCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private CustomControls.RJControls.RJTextBox txtDocumento;
        private CustomControls.RJControls.RJTextBox txtMontoCambio;
        private System.Windows.Forms.Label label8;
        private CustomControls.RJControls.RJTextBox txtMontoPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}