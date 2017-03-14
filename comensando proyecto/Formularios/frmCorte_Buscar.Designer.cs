namespace comensando_proyecto
{
    partial class frmBuscar_Corte
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
            this.btnNuevoCorte = new System.Windows.Forms.Button();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.lstvDatos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevoCorte
            // 
            this.btnNuevoCorte.Image = global::comensando_proyecto.Properties.Resources.kedit;
            this.btnNuevoCorte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoCorte.Location = new System.Drawing.Point(14, 11);
            this.btnNuevoCorte.Name = "btnNuevoCorte";
            this.btnNuevoCorte.Size = new System.Drawing.Size(75, 54);
            this.btnNuevoCorte.TabIndex = 19;
            this.btnNuevoCorte.Text = "Nuevo";
            this.btnNuevoCorte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoCorte.UseVisualStyleBackColor = true;
            this.btnNuevoCorte.Click += new System.EventHandler(this.btnNuevoCorte_Click);
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.Image = global::comensando_proyecto.Properties.Resources.kscreensaver;
            this.btnListarTodos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListarTodos.Location = new System.Drawing.Point(176, 12);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(75, 53);
            this.btnListarTodos.TabIndex = 18;
            this.btnListarTodos.Text = "Listar Todos";
            this.btnListarTodos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // lstvDatos
            // 
            this.lstvDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstvDatos.FullRowSelect = true;
            this.lstvDatos.GridLines = true;
            this.lstvDatos.Location = new System.Drawing.Point(27, 83);
            this.lstvDatos.MultiSelect = false;
            this.lstvDatos.Name = "lstvDatos";
            this.lstvDatos.Size = new System.Drawing.Size(366, 325);
            this.lstvDatos.TabIndex = 17;
            this.lstvDatos.UseCompatibleStateImageBehavior = false;
            this.lstvDatos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N°";
            this.columnHeader1.Width = 29;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombres";
            this.columnHeader2.Width = 189;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precios";
            this.columnHeader3.Width = 112;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::comensando_proyecto.Properties.Resources.synaptic;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(318, 11);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 53);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::comensando_proyecto.Properties.Resources.kfloppy;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.Location = new System.Drawing.Point(95, 11);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 54);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(294, 415);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 20;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmBuscar_Corte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::comensando_proyecto.Properties.Resources.LOGO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(420, 453);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnNuevoCorte);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.lstvDatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmBuscar_Corte";
            this.Text = "frmBuscar_Corte";
            this.Load += new System.EventHandler(this.frmBuscar_Corte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoCorte;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.ListView lstvDatos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnAceptar;
    }
}