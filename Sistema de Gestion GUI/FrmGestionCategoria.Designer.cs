namespace Sistema_de_Gestion_GUI
{
    partial class FrmGestionCategoria
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
            this.txtBuscarCategoria = new CustomControls.RJControls.RJTextBox();
            this.btnExcel = new CustomControls.RJControls.RJButton();
            this.label9 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTipoCategoria = new CustomControls.RJControls.RJTextBox();
            this.txtIdCategoria = new CustomControls.RJControls.RJTextBox();
            this.btnLimpiarCategoria = new CustomControls.RJControls.RJButton();
            this.btnEliminarCategoria = new CustomControls.RJControls.RJButton();
            this.btnModificarCategoria = new CustomControls.RJControls.RJButton();
            this.btnGuardarCategoria = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tblRegistro = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.txtBuscarCategoria);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rjTextBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tblRegistro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 578);
            this.panel1.TabIndex = 44;
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarCategoria.BackColor = System.Drawing.Color.White;
            this.txtBuscarCategoria.BorderColor = System.Drawing.Color.White;
            this.txtBuscarCategoria.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtBuscarCategoria.BorderRadius = 15;
            this.txtBuscarCategoria.BorderSize = 1;
            this.txtBuscarCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCategoria.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBuscarCategoria.Location = new System.Drawing.Point(278, 79);
            this.txtBuscarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarCategoria.Multiline = false;
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBuscarCategoria.PasswordChar = false;
            this.txtBuscarCategoria.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBuscarCategoria.PlaceholderText = "";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(625, 32);
            this.txtBuscarCategoria.TabIndex = 20;
            this.txtBuscarCategoria.Texts = "Buscar:";
            this.txtBuscarCategoria.UnderlinedStyle = false;
            this.txtBuscarCategoria.Enter += new System.EventHandler(this.txtBuscarProducto_Enter);
            this.txtBuscarCategoria.Leave += new System.EventHandler(this.txtBuscarProducto_Leave);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExcel.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnExcel.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcel.BorderRadius = 15;
            this.btnExcel.BorderSize = 0;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.file_excel;
            this.btnExcel.Location = new System.Drawing.Point(142, 81);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(129, 30);
            this.btnExcel.TabIndex = 21;
            this.btnExcel.Text = "Exportar a excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.TextColor = System.Drawing.Color.White;
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(154, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Lista de categorias:";
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
            this.rjTextBox1.Location = new System.Drawing.Point(142, 40);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(761, 34);
            this.rjTextBox1.TabIndex = 22;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtTipoCategoria);
            this.panel3.Controls.Add(this.txtIdCategoria);
            this.panel3.Controls.Add(this.btnLimpiarCategoria);
            this.panel3.Controls.Add(this.btnEliminarCategoria);
            this.panel3.Controls.Add(this.btnModificarCategoria);
            this.panel3.Controls.Add(this.btnGuardarCategoria);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Location = new System.Drawing.Point(946, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 579);
            this.panel3.TabIndex = 52;
            // 
            // txtTipoCategoria
            // 
            this.txtTipoCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipoCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipoCategoria.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtTipoCategoria.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtTipoCategoria.BorderRadius = 15;
            this.txtTipoCategoria.BorderSize = 2;
            this.txtTipoCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipoCategoria.Location = new System.Drawing.Point(28, 125);
            this.txtTipoCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoCategoria.Multiline = false;
            this.txtTipoCategoria.Name = "txtTipoCategoria";
            this.txtTipoCategoria.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTipoCategoria.PasswordChar = false;
            this.txtTipoCategoria.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTipoCategoria.PlaceholderText = "";
            this.txtTipoCategoria.Size = new System.Drawing.Size(192, 32);
            this.txtTipoCategoria.TabIndex = 23;
            this.txtTipoCategoria.Texts = "";
            this.txtTipoCategoria.UnderlinedStyle = false;
            this.txtTipoCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoCategoria_KeyPress);
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdCategoria.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtIdCategoria.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.txtIdCategoria.BorderRadius = 15;
            this.txtIdCategoria.BorderSize = 2;
            this.txtIdCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdCategoria.Location = new System.Drawing.Point(27, 73);
            this.txtIdCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCategoria.Multiline = false;
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIdCategoria.PasswordChar = false;
            this.txtIdCategoria.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdCategoria.PlaceholderText = "";
            this.txtIdCategoria.Size = new System.Drawing.Size(193, 32);
            this.txtIdCategoria.TabIndex = 22;
            this.txtIdCategoria.Texts = "";
            this.txtIdCategoria.UnderlinedStyle = false;
            this.txtIdCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCategoria_KeyPress);
            // 
            // btnLimpiarCategoria
            // 
            this.btnLimpiarCategoria.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLimpiarCategoria.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnLimpiarCategoria.BorderColor = System.Drawing.Color.Transparent;
            this.btnLimpiarCategoria.BorderRadius = 15;
            this.btnLimpiarCategoria.BorderSize = 2;
            this.btnLimpiarCategoria.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCategoria.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.escoba;
            this.btnLimpiarCategoria.Location = new System.Drawing.Point(27, 263);
            this.btnLimpiarCategoria.Name = "btnLimpiarCategoria";
            this.btnLimpiarCategoria.Size = new System.Drawing.Size(203, 32);
            this.btnLimpiarCategoria.TabIndex = 26;
            this.btnLimpiarCategoria.Text = "Limpiar";
            this.btnLimpiarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarCategoria.TextColor = System.Drawing.Color.White;
            this.btnLimpiarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarCategoria.UseVisualStyleBackColor = false;
            this.btnLimpiarCategoria.Click += new System.EventHandler(this.btnLimpiarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.Brown;
            this.btnEliminarCategoria.BackgroundColor = System.Drawing.Color.Brown;
            this.btnEliminarCategoria.BorderColor = System.Drawing.Color.Transparent;
            this.btnEliminarCategoria.BorderRadius = 15;
            this.btnEliminarCategoria.BorderSize = 2;
            this.btnEliminarCategoria.FlatAppearance.BorderSize = 0;
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCategoria.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.basura1;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(26, 229);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(203, 32);
            this.btnEliminarCategoria.TabIndex = 25;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarCategoria.TextColor = System.Drawing.Color.White;
            this.btnEliminarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificarCategoria.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnModificarCategoria.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnModificarCategoria.BorderRadius = 15;
            this.btnModificarCategoria.BorderSize = 0;
            this.btnModificarCategoria.FlatAppearance.BorderSize = 0;
            this.btnModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnModificarCategoria.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.cuadrado_de_la_pluma;
            this.btnModificarCategoria.Location = new System.Drawing.Point(26, 195);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(203, 32);
            this.btnModificarCategoria.TabIndex = 24;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarCategoria.TextColor = System.Drawing.Color.White;
            this.btnModificarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarCategoria.UseVisualStyleBackColor = false;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarModificar_Click);
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarCategoria.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarCategoria.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarCategoria.BorderRadius = 15;
            this.btnGuardarCategoria.BorderSize = 0;
            this.btnGuardarCategoria.FlatAppearance.BorderSize = 0;
            this.btnGuardarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCategoria.Image = global::Sistema_de_Gestion_GUI.Properties.Resources.disco;
            this.btnGuardarCategoria.Location = new System.Drawing.Point(26, 162);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(203, 32);
            this.btnGuardarCategoria.TabIndex = 23;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCategoria.TextColor = System.Drawing.Color.White;
            this.btnGuardarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCategoria.UseVisualStyleBackColor = false;
            this.btnGuardarCategoria.Click += new System.EventHandler(this.btnGuardarCategoria_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle cliente";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id de la Categoria";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de categoria";
            // 
            // tblRegistro
            // 
            this.tblRegistro.AllowUserToAddRows = false;
            this.tblRegistro.AllowUserToDeleteRows = false;
            this.tblRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnSeleccionar,
            this.IdCategoria,
            this.TipoCategoria,
            this.FechaRegistro});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblRegistro.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblRegistro.EnableHeadersVisualStyles = false;
            this.tblRegistro.Location = new System.Drawing.Point(142, 143);
            this.tblRegistro.MultiSelect = false;
            this.tblRegistro.Name = "tblRegistro";
            this.tblRegistro.ReadOnly = true;
            this.tblRegistro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblRegistro.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.tblRegistro.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tblRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblRegistro.Size = new System.Drawing.Size(761, 387);
            this.tblRegistro.TabIndex = 17;
            this.tblRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblRegistro_CellContentClick);
            this.tblRegistro.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tblRegistro_CellPainting);
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
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "Id de categoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Width = 120;
            // 
            // TipoCategoria
            // 
            this.TipoCategoria.HeaderText = "Categoria";
            this.TipoCategoria.Name = "TipoCategoria";
            this.TipoCategoria.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha de registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 150;
            // 
            // FrmGestionCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 578);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGestionCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJTextBox txtBuscarCategoria;
        private CustomControls.RJControls.RJButton btnExcel;
        private System.Windows.Forms.Label label9;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.RJControls.RJTextBox txtTipoCategoria;
        private CustomControls.RJControls.RJTextBox txtIdCategoria;
        private CustomControls.RJControls.RJButton btnLimpiarCategoria;
        private CustomControls.RJControls.RJButton btnEliminarCategoria;
        private CustomControls.RJControls.RJButton btnModificarCategoria;
        private CustomControls.RJControls.RJButton btnGuardarCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tblRegistro;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
    }
}