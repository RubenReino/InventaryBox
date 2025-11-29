namespace Presentacion
{
    partial class VentanaPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboFiltrarPor = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.lblFiltrorapido = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.menuArticulo = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proximamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblObligatorio1 = new System.Windows.Forms.Label();
            this.lblObligatorio2 = new System.Windows.Forms.Label();
            this.lblObligatorio3 = new System.Windows.Forms.Label();
            this.pboUrlImagen = new System.Windows.Forms.PictureBox();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelDetalle = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.menuArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboUrlImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.dgvArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvArticulos.Location = new System.Drawing.Point(84, 91);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(643, 450);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvArticulos_DataBindingComplete);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(129, 628);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnModificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(350, 628);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 34);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(571, 628);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 34);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(880, 628);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 34);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboFiltrarPor
            // 
            this.cboFiltrarPor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboFiltrarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltrarPor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltrarPor.FormattingEnabled = true;
            this.cboFiltrarPor.Location = new System.Drawing.Point(863, 503);
            this.cboFiltrarPor.Name = "cboFiltrarPor";
            this.cboFiltrarPor.Size = new System.Drawing.Size(109, 28);
            this.cboFiltrarPor.TabIndex = 6;
            this.cboFiltrarPor.SelectedIndexChanged += new System.EventHandler(this.cboFiltrarPor_SelectedIndexChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCampo.Location = new System.Drawing.Point(760, 506);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(82, 20);
            this.lblCampo.TabIndex = 8;
            this.lblCampo.Text = "Filtrar Por:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCriterio.Location = new System.Drawing.Point(1010, 506);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(64, 20);
            this.lblCriterio.TabIndex = 9;
            this.lblCriterio.Text = "Criterio:";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFiltroAvanzado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(1080, 541);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(109, 27);
            this.txtFiltroAvanzado.TabIndex = 10;
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFiltroRapido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroRapido.Location = new System.Drawing.Point(185, 562);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(171, 27);
            this.txtFiltroRapido.TabIndex = 11;
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.txtFiltroRapido_TextChanged);
            // 
            // lblFiltrorapido
            // 
            this.lblFiltrorapido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFiltrorapido.AutoSize = true;
            this.lblFiltrorapido.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrorapido.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblFiltrorapido.Location = new System.Drawing.Point(82, 565);
            this.lblFiltrorapido.Name = "lblFiltrorapido";
            this.lblFiltrorapido.Size = new System.Drawing.Size(101, 20);
            this.lblFiltrorapido.TabIndex = 12;
            this.lblFiltrorapido.Text = "Filtro Rapido:";
            // 
            // cboCriterio
            // 
            this.cboCriterio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(1080, 503);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(109, 28);
            this.cboCriterio.TabIndex = 13;
            this.cboCriterio.SelectedIndexChanged += new System.EventHandler(this.cboCriterio_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(1087, 628);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 34);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.BackColor = System.Drawing.Color.CadetBlue;
            this.panelPrincipal.Controls.Add(this.lblCatalogo);
            this.panelPrincipal.Controls.Add(this.menuArticulo);
            this.panelPrincipal.Location = new System.Drawing.Point(-1, -1);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1275, 56);
            this.panelPrincipal.TabIndex = 0;
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogo.ForeColor = System.Drawing.Color.White;
            this.lblCatalogo.Location = new System.Drawing.Point(512, 10);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(252, 32);
            this.lblCatalogo.TabIndex = 18;
            this.lblCatalogo.Text = "Catalogo De Articulos";
            // 
            // menuArticulo
            // 
            this.menuArticulo.BackColor = System.Drawing.Color.CadetBlue;
            this.menuArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuArticulo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuArticulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuArticulo.Location = new System.Drawing.Point(0, 0);
            this.menuArticulo.Name = "menuArticulo";
            this.menuArticulo.Size = new System.Drawing.Size(1275, 25);
            this.menuArticulo.TabIndex = 19;
            this.menuArticulo.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem,
            this.proximamenteToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.marcaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem1});
            this.marcaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.marcaToolStripMenuItem.Text = "Agregar";
            // 
            // marcaToolStripMenuItem1
            // 
            this.marcaToolStripMenuItem1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.marcaToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.marcaToolStripMenuItem1.Name = "marcaToolStripMenuItem1";
            this.marcaToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.marcaToolStripMenuItem1.Text = "Marca";
            this.marcaToolStripMenuItem1.Click += new System.EventHandler(this.marcaToolStripMenuItem1_Click);
            // 
            // proximamenteToolStripMenuItem
            // 
            this.proximamenteToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.proximamenteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.proximamenteToolStripMenuItem.Name = "proximamenteToolStripMenuItem";
            this.proximamenteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.proximamenteToolStripMenuItem.Text = "Proximamente...";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // lblObligatorio1
            // 
            this.lblObligatorio1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblObligatorio1.AutoSize = true;
            this.lblObligatorio1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorio1.ForeColor = System.Drawing.Color.Red;
            this.lblObligatorio1.Location = new System.Drawing.Point(988, 507);
            this.lblObligatorio1.Name = "lblObligatorio1";
            this.lblObligatorio1.Size = new System.Drawing.Size(21, 25);
            this.lblObligatorio1.TabIndex = 15;
            this.lblObligatorio1.Text = "*";
            this.lblObligatorio1.Visible = false;
            // 
            // lblObligatorio2
            // 
            this.lblObligatorio2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblObligatorio2.AutoSize = true;
            this.lblObligatorio2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorio2.ForeColor = System.Drawing.Color.Red;
            this.lblObligatorio2.Location = new System.Drawing.Point(1195, 503);
            this.lblObligatorio2.Name = "lblObligatorio2";
            this.lblObligatorio2.Size = new System.Drawing.Size(21, 25);
            this.lblObligatorio2.TabIndex = 16;
            this.lblObligatorio2.Text = "*";
            this.lblObligatorio2.Visible = false;
            // 
            // lblObligatorio3
            // 
            this.lblObligatorio3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblObligatorio3.AutoSize = true;
            this.lblObligatorio3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorio3.ForeColor = System.Drawing.Color.Red;
            this.lblObligatorio3.Location = new System.Drawing.Point(1195, 543);
            this.lblObligatorio3.Name = "lblObligatorio3";
            this.lblObligatorio3.Size = new System.Drawing.Size(21, 25);
            this.lblObligatorio3.TabIndex = 17;
            this.lblObligatorio3.Text = "*";
            this.lblObligatorio3.Visible = false;
            // 
            // pboUrlImagen
            // 
            this.pboUrlImagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pboUrlImagen.Location = new System.Drawing.Point(871, 91);
            this.pboUrlImagen.Name = "pboUrlImagen";
            this.pboUrlImagen.Size = new System.Drawing.Size(308, 289);
            this.pboUrlImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboUrlImagen.TabIndex = 1;
            this.pboUrlImagen.TabStop = false;
            // 
            // btnDetalles
            // 
            this.btnDetalles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDetalles.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDetalles.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnDetalles.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDetalles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDetalles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalles.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDetalles.Location = new System.Drawing.Point(975, 406);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(118, 34);
            this.btnDetalles.TabIndex = 19;
            this.btnDetalles.Text = "Ver Detalles";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(1153, 432);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(26, 34);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelDetalle
            // 
            this.panelDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelDetalle.Location = new System.Drawing.Point(860, 91);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(329, 375);
            this.panelDetalle.TabIndex = 24;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 692);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.lblObligatorio3);
            this.Controls.Add(this.lblObligatorio2);
            this.Controls.Add(this.lblObligatorio1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.lblFiltrorapido);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.cboFiltrarPor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pboUrlImagen);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.panelDetalle);
            this.MainMenuStrip = this.menuArticulo;
            this.MinimumSize = new System.Drawing.Size(1289, 726);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.menuArticulo.ResumeLayout(false);
            this.menuArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboUrlImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboFiltrarPor;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Label lblFiltrorapido;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label lblObligatorio1;
        private System.Windows.Forms.Label lblObligatorio2;
        private System.Windows.Forms.Label lblObligatorio3;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.PictureBox pboUrlImagen;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.MenuStrip menuArticulo;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proximamenteToolStripMenuItem;
    }
}

