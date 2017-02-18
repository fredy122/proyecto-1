namespace comensando_proyecto
{
    partial class frmBuscarClientes
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lstvDatos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.rbApellido = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(420, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(155, 20);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lstvDatos
            // 
            this.lstvDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader5});
            this.lstvDatos.FullRowSelect = true;
            this.lstvDatos.GridLines = true;
            this.lstvDatos.Location = new System.Drawing.Point(12, 90);
            this.lstvDatos.MultiSelect = false;
            this.lstvDatos.Name = "lstvDatos";
            this.lstvDatos.Size = new System.Drawing.Size(742, 322);
            this.lstvDatos.TabIndex = 6;
            this.lstvDatos.UseCompatibleStateImageBehavior = false;
            this.lstvDatos.View = System.Windows.Forms.View.Details;
            this.lstvDatos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvDatos_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N°";
            this.columnHeader1.Width = 29;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombres";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellidos";
            this.columnHeader3.Width = 202;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Edad";
            this.columnHeader4.Width = 62;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Correo Electronico";
            this.columnHeader6.Width = 181;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DNI";
            this.columnHeader5.Width = 90;
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.Image = global::comensando_proyecto.Properties.Resources.kscreensaver;
            this.btnListarTodos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListarTodos.Location = new System.Drawing.Point(257, 14);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(75, 53);
            this.btnListarTodos.TabIndex = 7;
            this.btnListarTodos.Text = "Listar Todos";
            this.btnListarTodos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // button5
            // 
            this.button5.Image = global::comensando_proyecto.Properties.Resources.xmag;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.Location = new System.Drawing.Point(338, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 53);
            this.button5.TabIndex = 5;
            this.button5.Text = "Buscar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = global::comensando_proyecto.Properties.Resources.synaptic;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(679, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "Salir";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::comensando_proyecto.Properties.Resources.klipper;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.Location = new System.Drawing.Point(176, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "Historial";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::comensando_proyecto.Properties.Resources.kfloppy;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(95, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modificar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(645, 418);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Image = global::comensando_proyecto.Properties.Resources.kedit;
            this.btnNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoCliente.Location = new System.Drawing.Point(14, 13);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(75, 54);
            this.btnNuevoCliente.TabIndex = 9;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Location = new System.Drawing.Point(506, 46);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(44, 17);
            this.rbDNI.TabIndex = 10;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            // 
            // rbApellido
            // 
            this.rbApellido.AutoSize = true;
            this.rbApellido.Checked = true;
            this.rbApellido.Location = new System.Drawing.Point(420, 46);
            this.rbApellido.Name = "rbApellido";
            this.rbApellido.Size = new System.Drawing.Size(62, 17);
            this.rbApellido.TabIndex = 11;
            this.rbApellido.TabStop = true;
            this.rbApellido.Text = "Apellido";
            this.rbApellido.UseVisualStyleBackColor = true;
            // 
            // frmBuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::comensando_proyecto.Properties.Resources.LOGO1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 446);
            this.Controls.Add(this.rbApellido);
            this.Controls.Add(this.rbDNI);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.lstvDatos);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmBuscarClientes";
            this.Text = "frmBuscarClientes";
            this.Load += new System.EventHandler(this.frmBuscarClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView lstvDatos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.RadioButton rbApellido;
    }
}