namespace comensando_proyecto
{
    partial class frmBuscar_Articulo
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
            this.lstvDatos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNuevoArticulo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnListarTods = new System.Windows.Forms.Button();
            this.btnAceptarArticulo = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvDatos
            // 
            this.lstvDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader3});
            this.lstvDatos.FullRowSelect = true;
            this.lstvDatos.Location = new System.Drawing.Point(13, 86);
            this.lstvDatos.MultiSelect = false;
            this.lstvDatos.Name = "lstvDatos";
            this.lstvDatos.Size = new System.Drawing.Size(828, 298);
            this.lstvDatos.TabIndex = 0;
            this.lstvDatos.UseCompatibleStateImageBehavior = false;
            this.lstvDatos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N°";
            this.columnHeader1.Width = 39;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nombre ";
            this.columnHeader4.Width = 128;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Marca";
            this.columnHeader5.Width = 116;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Rubro";
            this.columnHeader6.Width = 93;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "stock";
            this.columnHeader8.Width = 50;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Precio Compra";
            this.columnHeader9.Width = 93;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Precio Venta";
            this.columnHeader10.Width = 86;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Fecha Compra ";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Descripcion";
            this.columnHeader3.Width = 109;
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.Image = global::comensando_proyecto.Properties.Resources.kedit;
            this.btnNuevoArticulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoArticulo.Location = new System.Drawing.Point(13, 13);
            this.btnNuevoArticulo.Name = "btnNuevoArticulo";
            this.btnNuevoArticulo.Size = new System.Drawing.Size(75, 57);
            this.btnNuevoArticulo.TabIndex = 1;
            this.btnNuevoArticulo.Text = "Nuevo";
            this.btnNuevoArticulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnNuevoArticulo.Click += new System.EventHandler(this.btnNuevoArticulo_Click);
            // 
            // button2
            // 
            this.button2.Image = global::comensando_proyecto.Properties.Resources.kfloppy;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(95, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modificar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::comensando_proyecto.Properties.Resources.error;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrar.Location = new System.Drawing.Point(177, 13);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 57);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::comensando_proyecto.Properties.Resources.filefind;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(528, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 56);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button5
            // 
            this.button5.Image = global::comensando_proyecto.Properties.Resources.synaptic;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(765, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 57);
            this.button5.TabIndex = 5;
            this.button5.Text = "Salir";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(609, 31);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(150, 20);
            this.txtBuscar.TabIndex = 6;
            // 
            // btnListarTods
            // 
            this.btnListarTods.Image = global::comensando_proyecto.Properties.Resources.kscreensaver;
            this.btnListarTods.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListarTods.Location = new System.Drawing.Point(259, 14);
            this.btnListarTods.Name = "btnListarTods";
            this.btnListarTods.Size = new System.Drawing.Size(75, 55);
            this.btnListarTods.TabIndex = 7;
            this.btnListarTods.Text = "Listar Todos";
            this.btnListarTods.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListarTods.UseVisualStyleBackColor = true;
            this.btnListarTods.Click += new System.EventHandler(this.btnListarTods_Click);
            // 
            // btnAceptarArticulo
            // 
            this.btnAceptarArticulo.Location = new System.Drawing.Point(708, 397);
            this.btnAceptarArticulo.Name = "btnAceptarArticulo";
            this.btnAceptarArticulo.Size = new System.Drawing.Size(127, 23);
            this.btnAceptarArticulo.TabIndex = 8;
            this.btnAceptarArticulo.Text = "Aceptar";
            this.btnAceptarArticulo.UseVisualStyleBackColor = true;
            this.btnAceptarArticulo.Click += new System.EventHandler(this.btnAceptarArticulo_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(451, 31);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(60, 20);
            this.nudCantidad.TabIndex = 9;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cantidad :";
            // 
            // frmBuscar_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::comensando_proyecto.Properties.Resources.LOGO1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.btnAceptarArticulo);
            this.Controls.Add(this.btnListarTods);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNuevoArticulo);
            this.Controls.Add(this.lstvDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmBuscar_Articulo";
            this.Text = "frmArticulos";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvDatos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnNuevoArticulo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnListarTods;
        public System.Windows.Forms.NumericUpDown nudCantidad;
        public System.Windows.Forms.Button btnAceptarArticulo;
        public System.Windows.Forms.Label label1;
    }
}