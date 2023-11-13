namespace Sistema_de_Gestion_GUI
{
    partial class FrmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.slideBar2 = new System.Windows.Forms.Timer(this.components);
            this.Contenedor = new System.Windows.Forms.Panel();
            this.SlideContenedor2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGestionProductos = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnGestionProveedores = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.btnMenuDesplegable = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SlideFinanciera = new System.Windows.Forms.Panel();
            this.btnDetalleVenta = new System.Windows.Forms.Button();
            this.btnDetalleCompra = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnDesplegarCompra = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.ContenedorProducto = new System.Windows.Forms.Panel();
            this.btnGestionCategorias = new System.Windows.Forms.Button();
            this.slideButton = new System.Windows.Forms.Timer(this.components);
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.Contenedor.SuspendLayout();
            this.SlideContenedor2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SlideFinanciera.SuspendLayout();
            this.ContenedorProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SteelBlue;
            this.panel10.Controls.Add(this.btnMaximizar);
            this.panel10.Controls.Add(this.btnMinimizar);
            this.panel10.Controls.Add(this.btnCerrar);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1388, 44);
            this.panel10.TabIndex = 47;
            this.panel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel10_MouseDown);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.bala2;
            this.btnMaximizar.Location = new System.Drawing.Point(1346, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(18, 18);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximizar.TabIndex = 49;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.bala3;
            this.btnMinimizar.Location = new System.Drawing.Point(1323, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 18);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimizar.TabIndex = 49;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.bala;
            this.btnCerrar.Location = new System.Drawing.Point(1366, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 18);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrar.TabIndex = 48;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // slideBar2
            // 
            this.slideBar2.Interval = 10;
            this.slideBar2.Tick += new System.EventHandler(this.slideBar2_Tick);
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.White;
            this.Contenedor.Controls.Add(this.SlideContenedor2);
            this.Contenedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 44);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1388, 790);
            this.Contenedor.TabIndex = 46;
            // 
            // SlideContenedor2
            // 
            this.SlideContenedor2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SlideContenedor2.BackColor = System.Drawing.Color.SteelBlue;
            this.SlideContenedor2.Controls.Add(this.panel1);
            this.SlideContenedor2.Controls.Add(this.panel5);
            this.SlideContenedor2.Controls.Add(this.panel8);
            this.SlideContenedor2.Controls.Add(this.panel6);
            this.SlideContenedor2.Controls.Add(this.btnMenuDesplegable);
            this.SlideContenedor2.Controls.Add(this.pictureBox1);
            this.SlideContenedor2.Controls.Add(this.panel12);
            this.SlideContenedor2.Controls.Add(this.panel2);
            this.SlideContenedor2.Controls.Add(this.SlideFinanciera);
            this.SlideContenedor2.Controls.Add(this.ContenedorProducto);
            this.SlideContenedor2.Location = new System.Drawing.Point(0, 0);
            this.SlideContenedor2.MaximumSize = new System.Drawing.Size(214, 0);
            this.SlideContenedor2.MinimumSize = new System.Drawing.Size(66, 928);
            this.SlideContenedor2.Name = "SlideContenedor2";
            this.SlideContenedor2.Size = new System.Drawing.Size(66, 928);
            this.SlideContenedor2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGestionProductos);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(3, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 52);
            this.panel1.TabIndex = 50;
            // 
            // btnGestionProductos
            // 
            this.btnGestionProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionProductos.FlatAppearance.BorderSize = 0;
            this.btnGestionProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionProductos.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.caja_abierta_llena__1_;
            this.btnGestionProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionProductos.Location = new System.Drawing.Point(13, 0);
            this.btnGestionProductos.Name = "btnGestionProductos";
            this.btnGestionProductos.Size = new System.Drawing.Size(196, 62);
            this.btnGestionProductos.TabIndex = 47;
            this.btnGestionProductos.Text = "           Productos";
            this.btnGestionProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionProductos.UseVisualStyleBackColor = true;
            this.btnGestionProductos.Click += new System.EventHandler(this.btnGestionProductos_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnGestionProveedores);
            this.panel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(3, 265);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(208, 52);
            this.panel5.TabIndex = 47;
            // 
            // btnGestionProveedores
            // 
            this.btnGestionProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionProveedores.FlatAppearance.BorderSize = 0;
            this.btnGestionProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionProveedores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionProveedores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionProveedores.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.id_insignia;
            this.btnGestionProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionProveedores.Location = new System.Drawing.Point(13, -2);
            this.btnGestionProveedores.Name = "btnGestionProveedores";
            this.btnGestionProveedores.Size = new System.Drawing.Size(195, 62);
            this.btnGestionProveedores.TabIndex = 47;
            this.btnGestionProveedores.Text = "           Proveedores";
            this.btnGestionProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionProveedores.UseVisualStyleBackColor = true;
            this.btnGestionProveedores.Click += new System.EventHandler(this.btnGestionProveedores_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel8.Controls.Add(this.btnPerfil);
            this.panel8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel8.Location = new System.Drawing.Point(3, 733);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(211, 52);
            this.panel8.TabIndex = 47;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerfil.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(8, 7);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(196, 38);
            this.btnPerfil.TabIndex = 45;
            this.btnPerfil.Text = "            ADMINISTRADOR";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnGestionUsuarios);
            this.panel6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Location = new System.Drawing.Point(3, 323);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(204, 52);
            this.panel6.TabIndex = 47;
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionUsuarios.FlatAppearance.BorderSize = 0;
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionUsuarios.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.equipo_de_usuarios;
            this.btnGestionUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(14, 0);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(192, 62);
            this.btnGestionUsuarios.TabIndex = 47;
            this.btnGestionUsuarios.Text = "           Usuarios";
            this.btnGestionUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.GestionUsuarios_Click);
            // 
            // btnMenuDesplegable
            // 
            this.btnMenuDesplegable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuDesplegable.FlatAppearance.BorderSize = 0;
            this.btnMenuDesplegable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDesplegable.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.barras_escalonadas__1_;
            this.btnMenuDesplegable.Location = new System.Drawing.Point(11, 18);
            this.btnMenuDesplegable.Name = "btnMenuDesplegable";
            this.btnMenuDesplegable.Size = new System.Drawing.Size(46, 44);
            this.btnMenuDesplegable.TabIndex = 48;
            this.btnMenuDesplegable.TabStop = false;
            this.btnMenuDesplegable.UseVisualStyleBackColor = true;
            this.btnMenuDesplegable.Click += new System.EventHandler(this.btnMenuDesplegable_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.Fit__3___3_;
            this.pictureBox1.Location = new System.Drawing.Point(50, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnClientes);
            this.panel12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel12.Location = new System.Drawing.Point(3, 381);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(208, 50);
            this.panel12.TabIndex = 49;
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClientes.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.etiqueta_de_usuario__1_;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(13, 3);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(195, 62);
            this.btnClientes.TabIndex = 47;
            this.btnClientes.Text = "           Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 52);
            this.panel2.TabIndex = 46;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenu.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.house_chimney__1_;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(14, -5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(197, 62);
            this.btnMenu.TabIndex = 47;
            this.btnMenu.Text = "            Menu Principal";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // SlideFinanciera
            // 
            this.SlideFinanciera.Controls.Add(this.btnDetalleVenta);
            this.SlideFinanciera.Controls.Add(this.btnDetalleCompra);
            this.SlideFinanciera.Controls.Add(this.btnVenta);
            this.SlideFinanciera.Controls.Add(this.btnDesplegarCompra);
            this.SlideFinanciera.Controls.Add(this.btnCompra);
            this.SlideFinanciera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlideFinanciera.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SlideFinanciera.Location = new System.Drawing.Point(3, 440);
            this.SlideFinanciera.MaximumSize = new System.Drawing.Size(208, 287);
            this.SlideFinanciera.MinimumSize = new System.Drawing.Size(208, 62);
            this.SlideFinanciera.Name = "SlideFinanciera";
            this.SlideFinanciera.Size = new System.Drawing.Size(208, 62);
            this.SlideFinanciera.TabIndex = 47;
            // 
            // btnDetalleVenta
            // 
            this.btnDetalleVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalleVenta.FlatAppearance.BorderSize = 0;
            this.btnDetalleVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleVenta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDetalleVenta.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.bolsa;
            this.btnDetalleVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalleVenta.Location = new System.Drawing.Point(20, 212);
            this.btnDetalleVenta.Name = "btnDetalleVenta";
            this.btnDetalleVenta.Size = new System.Drawing.Size(166, 62);
            this.btnDetalleVenta.TabIndex = 49;
            this.btnDetalleVenta.Text = "           Detalle ventas";
            this.btnDetalleVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalleVenta.UseVisualStyleBackColor = true;
            this.btnDetalleVenta.Click += new System.EventHandler(this.btnDetalleVenta_Click);
            // 
            // btnDetalleCompra
            // 
            this.btnDetalleCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalleCompra.FlatAppearance.BorderSize = 0;
            this.btnDetalleCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleCompra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDetalleCompra.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.archivo_factura_dolar;
            this.btnDetalleCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalleCompra.Location = new System.Drawing.Point(20, 111);
            this.btnDetalleCompra.Name = "btnDetalleCompra";
            this.btnDetalleCompra.Size = new System.Drawing.Size(184, 62);
            this.btnDetalleCompra.TabIndex = 49;
            this.btnDetalleCompra.Text = "           Detalle compras";
            this.btnDetalleCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalleCompra.UseVisualStyleBackColor = true;
            this.btnDetalleCompra.Click += new System.EventHandler(this.btnDetalleCompra_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVenta.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.recibo1;
            this.btnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenta.Location = new System.Drawing.Point(20, 161);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(155, 62);
            this.btnVenta.TabIndex = 47;
            this.btnVenta.Text = "           Ventas";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnDesplegarCompra
            // 
            this.btnDesplegarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesplegarCompra.FlatAppearance.BorderSize = 0;
            this.btnDesplegarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesplegarCompra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesplegarCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesplegarCompra.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.carro_de_compras_rapido;
            this.btnDesplegarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesplegarCompra.Location = new System.Drawing.Point(13, 5);
            this.btnDesplegarCompra.Name = "btnDesplegarCompra";
            this.btnDesplegarCompra.Size = new System.Drawing.Size(197, 62);
            this.btnDesplegarCompra.TabIndex = 48;
            this.btnDesplegarCompra.Text = "           Financiera";
            this.btnDesplegarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesplegarCompra.UseVisualStyleBackColor = true;
            this.btnDesplegarCompra.Click += new System.EventHandler(this.btnDesplegarCompra_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCompra.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.etiquetas__1_;
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.Location = new System.Drawing.Point(20, 60);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(155, 62);
            this.btnCompra.TabIndex = 47;
            this.btnCompra.Text = "           Compra";
            this.btnCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // ContenedorProducto
            // 
            this.ContenedorProducto.Controls.Add(this.btnGestionCategorias);
            this.ContenedorProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContenedorProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ContenedorProducto.Location = new System.Drawing.Point(3, 144);
            this.ContenedorProducto.Name = "ContenedorProducto";
            this.ContenedorProducto.Size = new System.Drawing.Size(208, 52);
            this.ContenedorProducto.TabIndex = 47;
            // 
            // btnGestionCategorias
            // 
            this.btnGestionCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionCategorias.FlatAppearance.BorderSize = 0;
            this.btnGestionCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionCategorias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionCategorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionCategorias.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.libro_marcador;
            this.btnGestionCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionCategorias.Location = new System.Drawing.Point(14, -5);
            this.btnGestionCategorias.Name = "btnGestionCategorias";
            this.btnGestionCategorias.Size = new System.Drawing.Size(196, 62);
            this.btnGestionCategorias.TabIndex = 47;
            this.btnGestionCategorias.Text = "           Categorias";
            this.btnGestionCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionCategorias.UseVisualStyleBackColor = true;
            this.btnGestionCategorias.Click += new System.EventHandler(this.btnGestionCategorias_Click);
            // 
            // slideButton
            // 
            this.slideButton.Interval = 10;
            this.slideButton.Tick += new System.EventHandler(this.slideButton_Tick);
            // 
            // FrmMenuPrincipal
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1388, 834);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.panel10);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.Contenedor.ResumeLayout(false);
            this.SlideContenedor2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.SlideFinanciera.ResumeLayout(false);
            this.ContenedorProducto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Timer slideBar2;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Panel SlideContenedor2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGestionProductos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnGestionProveedores;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Button btnMenuDesplegable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel SlideFinanciera;
        private System.Windows.Forms.Button btnDetalleCompra;
        private System.Windows.Forms.Button btnDesplegarCompra;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Panel ContenedorProducto;
        private System.Windows.Forms.Button btnGestionCategorias;
        private System.Windows.Forms.Button btnDetalleVenta;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Timer slideButton;
    }
}