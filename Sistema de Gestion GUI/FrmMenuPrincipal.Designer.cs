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
            this.Contenedor = new System.Windows.Forms.Panel();
            this.SlideContenedor2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuDesplegable = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGestionProductos = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGestionCategorias = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnGestionProveedores = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.slideBar2 = new System.Windows.Forms.Timer(this.components);
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.Contenedor.SuspendLayout();
            this.SlideContenedor2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDesplegable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.White;
            this.Contenedor.Controls.Add(this.SlideContenedor2);
            this.Contenedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 69);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1270, 619);
            this.Contenedor.TabIndex = 46;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // SlideContenedor2
            // 
            this.SlideContenedor2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SlideContenedor2.BackColor = System.Drawing.Color.SteelBlue;
            this.SlideContenedor2.Controls.Add(this.panel1);
            this.SlideContenedor2.Controls.Add(this.panel2);
            this.SlideContenedor2.Controls.Add(this.panel3);
            this.SlideContenedor2.Controls.Add(this.panel7);
            this.SlideContenedor2.Controls.Add(this.panel4);
            this.SlideContenedor2.Controls.Add(this.panel6);
            this.SlideContenedor2.Controls.Add(this.panel5);
            this.SlideContenedor2.Controls.Add(this.panel8);
            this.SlideContenedor2.Location = new System.Drawing.Point(0, 0);
            this.SlideContenedor2.MaximumSize = new System.Drawing.Size(255, 0);
            this.SlideContenedor2.MinimumSize = new System.Drawing.Size(66, 619);
            this.SlideContenedor2.Name = "SlideContenedor2";
            this.SlideContenedor2.Size = new System.Drawing.Size(66, 619);
            this.SlideContenedor2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MenuDesplegable);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 100);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // MenuDesplegable
            // 
            this.MenuDesplegable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuDesplegable.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.barras_escalonadas__1_;
            this.MenuDesplegable.Location = new System.Drawing.Point(9, 21);
            this.MenuDesplegable.Name = "MenuDesplegable";
            this.MenuDesplegable.Size = new System.Drawing.Size(35, 32);
            this.MenuDesplegable.TabIndex = 0;
            this.MenuDesplegable.TabStop = false;
            this.MenuDesplegable.Click += new System.EventHandler(this.MenuDesplegable_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.Fit__3___3_;
            this.pictureBox1.Location = new System.Drawing.Point(36, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(3, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 52);
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
            this.btnMenu.Location = new System.Drawing.Point(12, -4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(255, 62);
            this.btnMenu.TabIndex = 47;
            this.btnMenu.Text = "            Menu Principal";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGestionProductos);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(3, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 52);
            this.panel3.TabIndex = 47;
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
            this.btnGestionProductos.Location = new System.Drawing.Point(12, -4);
            this.btnGestionProductos.Name = "btnGestionProductos";
            this.btnGestionProductos.Size = new System.Drawing.Size(255, 62);
            this.btnGestionProductos.TabIndex = 47;
            this.btnGestionProductos.Text = "           Productos";
            this.btnGestionProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionProductos.UseVisualStyleBackColor = true;
            this.btnGestionProductos.Click += new System.EventHandler(this.btnGestionProductos_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnAnalisis);
            this.panel7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Location = new System.Drawing.Point(3, 399);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(262, 52);
            this.panel7.TabIndex = 47;
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalisis.FlatAppearance.BorderSize = 0;
            this.btnAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalisis.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnalisis.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.estadisticas;
            this.btnAnalisis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalisis.Location = new System.Drawing.Point(12, -4);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(255, 62);
            this.btnAnalisis.TabIndex = 47;
            this.btnAnalisis.Text = "           Analisis";
            this.btnAnalisis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalisis.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnGestionCategorias);
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(3, 225);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 52);
            this.panel4.TabIndex = 47;
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
            this.btnGestionCategorias.Location = new System.Drawing.Point(12, -4);
            this.btnGestionCategorias.Name = "btnGestionCategorias";
            this.btnGestionCategorias.Size = new System.Drawing.Size(255, 62);
            this.btnGestionCategorias.TabIndex = 47;
            this.btnGestionCategorias.Text = "           Categorias";
            this.btnGestionCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionCategorias.UseVisualStyleBackColor = true;
            this.btnGestionCategorias.Click += new System.EventHandler(this.btnGestionCategorias_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnGestionUsuarios);
            this.panel6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Location = new System.Drawing.Point(3, 341);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 52);
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
            this.btnGestionUsuarios.Location = new System.Drawing.Point(12, -4);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(255, 62);
            this.btnGestionUsuarios.TabIndex = 47;
            this.btnGestionUsuarios.Text = "           Usuarios";
            this.btnGestionUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.GestionUsuarios_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnGestionProveedores);
            this.panel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(3, 283);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 52);
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
            this.btnGestionProveedores.Location = new System.Drawing.Point(12, -4);
            this.btnGestionProveedores.Name = "btnGestionProveedores";
            this.btnGestionProveedores.Size = new System.Drawing.Size(255, 62);
            this.btnGestionProveedores.TabIndex = 47;
            this.btnGestionProveedores.Text = "           Proveedores";
            this.btnGestionProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionProveedores.UseVisualStyleBackColor = true;
            this.btnGestionProveedores.Click += new System.EventHandler(this.btnGestionProveedores_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnPerfil);
            this.panel8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel8.Location = new System.Drawing.Point(3, 526);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(262, 52);
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
            this.btnPerfil.Location = new System.Drawing.Point(12, 7);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(213, 38);
            this.btnPerfil.TabIndex = 45;
            this.btnPerfil.Text = "            ADMINISTRADOR";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightGray;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1270, 25);
            this.panel9.TabIndex = 46;
            this.panel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel9_MouseDown);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SteelBlue;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 25);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1270, 44);
            this.panel10.TabIndex = 47;
            this.panel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel10_MouseDown);
            // 
            // slideBar2
            // 
            this.slideBar2.Interval = 10;
            this.slideBar2.Tick += new System.EventHandler(this.slideBar2_Tick);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.LightGray;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.cuadrado__1_;
            this.btnMaximizar.Location = new System.Drawing.Point(1228, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(18, 18);
            this.btnMaximizar.TabIndex = 49;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.LightGray;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.menos_pequeno;
            this.btnMinimizar.Location = new System.Drawing.Point(1202, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 18);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 49;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.cruz_pequena;
            this.btnCerrar.Location = new System.Drawing.Point(1250, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 18);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 48;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1270, 688);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.Contenedor.ResumeLayout(false);
            this.SlideContenedor2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuDesplegable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGestionProductos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnGestionCategorias;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnGestionProveedores;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox MenuDesplegable;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel SlideContenedor2;
        private System.Windows.Forms.Timer slideBar2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}