namespace comensando_proyecto
{
    partial class frmBuscar_Empleado
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
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtListarTodos = new System.Windows.Forms.Button();
            this.btnNuevoEmpledo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstvDatos
            // 
            this.lstvDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstvDatos.FullRowSelect = true;
            this.lstvDatos.GridLines = true;
            this.lstvDatos.Location = new System.Drawing.Point(12, 86);
            this.lstvDatos.MultiSelect = false;
            this.lstvDatos.Name = "lstvDatos";
            this.lstvDatos.Size = new System.Drawing.Size(670, 346);
            this.lstvDatos.TabIndex = 13;
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
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellidos";
            this.columnHeader3.Width = 197;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DNI";
            this.columnHeader4.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Tag = "";
            this.columnHeader5.Text = "Edad";
            this.columnHeader5.Width = 67;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Correo Electronico";
            this.columnHeader6.Width = 142;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(440, 28);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(143, 20);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // button4
            // 
            this.button4.Image = global::comensando_proyecto.Properties.Resources.synaptic;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(607, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 53);
            this.button4.TabIndex = 10;
            this.button4.Text = "Salir";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::comensando_proyecto.Properties.Resources.klipper;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(265, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 53);
            this.button3.TabIndex = 9;
            this.button3.Text = "Historial";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::comensando_proyecto.Properties.Resources.error;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(183, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 8;
            this.button2.Text = "Borrar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::comensando_proyecto.Properties.Resources.kfloppy;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(102, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modificar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtListarTodos
            // 
            this.txtListarTodos.Image = global::comensando_proyecto.Properties.Resources.kscreensaver;
            this.txtListarTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtListarTodos.Location = new System.Drawing.Point(346, 13);
            this.txtListarTodos.Name = "txtListarTodos";
            this.txtListarTodos.Size = new System.Drawing.Size(75, 54);
            this.txtListarTodos.TabIndex = 14;
            this.txtListarTodos.Text = "Listar Todos";
            this.txtListarTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtListarTodos.UseVisualStyleBackColor = true;
            this.txtListarTodos.Click += new System.EventHandler(this.txtListarTodos_Click);
            // 
            // btnNuevoEmpledo
            // 
            this.btnNuevoEmpledo.Image = global::comensando_proyecto.Properties.Resources.kedit;
            this.btnNuevoEmpledo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoEmpledo.Location = new System.Drawing.Point(21, 13);
            this.btnNuevoEmpledo.Name = "btnNuevoEmpledo";
            this.btnNuevoEmpledo.Size = new System.Drawing.Size(75, 52);
            this.btnNuevoEmpledo.TabIndex = 15;
            this.btnNuevoEmpledo.Text = "Nuevo";
            this.btnNuevoEmpledo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoEmpledo.UseVisualStyleBackColor = true;
            this.btnNuevoEmpledo.Click += new System.EventHandler(this.btnNuevoEmpledo_Click);
            // 
            // frmBuscar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::comensando_proyecto.Properties.Resources.LOGO1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 448);
            this.Controls.Add(this.btnNuevoEmpledo);
            this.Controls.Add(this.txtListarTodos);
            this.Controls.Add(this.lstvDatos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmBuscar_Empleado";
            this.Text = "frmBuscar_Barbero";
            this.Load += new System.EventHandler(this.frmBuscar_Empleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvDatos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtListarTodos;
        private System.Windows.Forms.Button btnNuevoEmpledo;
    }
}