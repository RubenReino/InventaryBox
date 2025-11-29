namespace Presentacion
{
    partial class VentanaAgregar
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
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pboUrlImagen2 = new System.Windows.Forms.PictureBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.lblAgregarA = new System.Windows.Forms.Label();
            this.lblOblig1 = new System.Windows.Forms.Label();
            this.lblOblig2 = new System.Windows.Forms.Label();
            this.lblOblig3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboUrlImagen2)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArticulo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCodigoArticulo.Location = new System.Drawing.Point(21, 68);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(105, 17);
            this.lblCodigoArticulo.TabIndex = 0;
            this.lblCodigoArticulo.Text = "Codigo Articulo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNombre.Location = new System.Drawing.Point(65, 96);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImagen.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUrlImagen.Location = new System.Drawing.Point(38, 210);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(88, 17);
            this.lblUrlImagen.TabIndex = 3;
            this.lblUrlImagen.Text = "Imagen(URL):";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDescripcion.Location = new System.Drawing.Point(46, 124);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 17);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoArticulo.Location = new System.Drawing.Point(132, 67);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(97, 23);
            this.txtCodigoArticulo.TabIndex = 4;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrlImagen.Location = new System.Drawing.Point(132, 209);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(97, 23);
            this.txtUrlImagen.TabIndex = 5;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(132, 123);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(97, 23);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(132, 95);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(97, 23);
            this.txtNombre.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(132, 237);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(97, 23);
            this.txtPrecio.TabIndex = 9;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPrecio.Location = new System.Drawing.Point(78, 238);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(45, 311);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 26);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(233, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 26);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pboUrlImagen2
            // 
            this.pboUrlImagen2.Location = new System.Drawing.Point(344, 81);
            this.pboUrlImagen2.Name = "pboUrlImagen2";
            this.pboUrlImagen2.Size = new System.Drawing.Size(242, 212);
            this.pboUrlImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboUrlImagen2.TabIndex = 12;
            this.pboUrlImagen2.TabStop = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMarca.Location = new System.Drawing.Point(78, 152);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 17);
            this.lblMarca.TabIndex = 13;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCategoria.Location = new System.Drawing.Point(57, 181);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 17);
            this.lblCategoria.TabIndex = 14;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cboMarca
            // 
            this.cboMarca.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarca.ForeColor = System.Drawing.Color.White;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(132, 151);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(97, 23);
            this.cboMarca.TabIndex = 15;
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.ForeColor = System.Drawing.Color.White;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(132, 180);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(97, 23);
            this.cboCategoria.TabIndex = 16;
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExaminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnExaminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.ForeColor = System.Drawing.Color.White;
            this.btnExaminar.Location = new System.Drawing.Point(235, 206);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(79, 25);
            this.btnExaminar.TabIndex = 17;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.BackColor = System.Drawing.Color.CadetBlue;
            this.panelPrincipal.Controls.Add(this.lblAgregarA);
            this.panelPrincipal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPrincipal.Location = new System.Drawing.Point(0, -30);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(618, 77);
            this.panelPrincipal.TabIndex = 19;
            // 
            // lblAgregarA
            // 
            this.lblAgregarA.AutoSize = true;
            this.lblAgregarA.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarA.ForeColor = System.Drawing.Color.White;
            this.lblAgregarA.Location = new System.Drawing.Point(219, 39);
            this.lblAgregarA.Name = "lblAgregarA";
            this.lblAgregarA.Size = new System.Drawing.Size(162, 25);
            this.lblAgregarA.TabIndex = 20;
            this.lblAgregarA.Text = "Agregar Articulo";
            // 
            // lblOblig1
            // 
            this.lblOblig1.AutoSize = true;
            this.lblOblig1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOblig1.ForeColor = System.Drawing.Color.Red;
            this.lblOblig1.Location = new System.Drawing.Point(235, 67);
            this.lblOblig1.Name = "lblOblig1";
            this.lblOblig1.Size = new System.Drawing.Size(16, 20);
            this.lblOblig1.TabIndex = 20;
            this.lblOblig1.Text = "*";
            this.lblOblig1.Visible = false;
            // 
            // lblOblig2
            // 
            this.lblOblig2.AutoSize = true;
            this.lblOblig2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOblig2.ForeColor = System.Drawing.Color.Red;
            this.lblOblig2.Location = new System.Drawing.Point(235, 96);
            this.lblOblig2.Name = "lblOblig2";
            this.lblOblig2.Size = new System.Drawing.Size(16, 20);
            this.lblOblig2.TabIndex = 21;
            this.lblOblig2.Text = "*";
            this.lblOblig2.Visible = false;
            // 
            // lblOblig3
            // 
            this.lblOblig3.AutoSize = true;
            this.lblOblig3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOblig3.ForeColor = System.Drawing.Color.Red;
            this.lblOblig3.Location = new System.Drawing.Point(235, 238);
            this.lblOblig3.Name = "lblOblig3";
            this.lblOblig3.Size = new System.Drawing.Size(16, 20);
            this.lblOblig3.TabIndex = 22;
            this.lblOblig3.Text = "*";
            this.lblOblig3.Visible = false;
            // 
            // VentanaAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 376);
            this.Controls.Add(this.lblOblig3);
            this.Controls.Add(this.lblOblig2);
            this.Controls.Add(this.lblOblig1);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.pboUrlImagen2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.txtCodigoArticulo);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigoArticulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(626, 415);
            this.MinimumSize = new System.Drawing.Size(626, 415);
            this.Name = "VentanaAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VentanaAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboUrlImagen2)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pboUrlImagen2;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label lblAgregarA;
        private System.Windows.Forms.Label lblOblig1;
        private System.Windows.Forms.Label lblOblig2;
        private System.Windows.Forms.Label lblOblig3;
    }
}