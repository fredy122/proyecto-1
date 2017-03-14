namespace comensando_proyecto
{
    partial class frmventana_Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmventana_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosDeMercaderiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaDiariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDelDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barberosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarModificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoComisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeComisionesPagadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estilistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarFondoDePantallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBarbero = new System.Windows.Forms.Button();
            this.btnCortes = new System.Windows.Forms.Button();
            this.btnCierreTurno = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblMostrarUsuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.cajasToolStripMenuItem,
            this.barberosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.administracionToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosDeMercaderiasToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // ingresosDeMercaderiasToolStripMenuItem
            // 
            this.ingresosDeMercaderiasToolStripMenuItem.Name = "ingresosDeMercaderiasToolStripMenuItem";
            this.ingresosDeMercaderiasToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.ingresosDeMercaderiasToolStripMenuItem.Text = "Ingresos De Mercaderias";
            this.ingresosDeMercaderiasToolStripMenuItem.Click += new System.EventHandler(this.ingresosDeMercaderiasToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // cajasToolStripMenuItem
            // 
            this.cajasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajaDiariaToolStripMenuItem,
            this.reporteDelDiaToolStripMenuItem});
            this.cajasToolStripMenuItem.Name = "cajasToolStripMenuItem";
            this.cajasToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.cajasToolStripMenuItem.Text = "Cajas";
            // 
            // cajaDiariaToolStripMenuItem
            // 
            this.cajaDiariaToolStripMenuItem.Name = "cajaDiariaToolStripMenuItem";
            this.cajaDiariaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cajaDiariaToolStripMenuItem.Text = "Caja Diaria";
            this.cajaDiariaToolStripMenuItem.Click += new System.EventHandler(this.cajaDiariaToolStripMenuItem_Click);
            // 
            // reporteDelDiaToolStripMenuItem
            // 
            this.reporteDelDiaToolStripMenuItem.Name = "reporteDelDiaToolStripMenuItem";
            this.reporteDelDiaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.reporteDelDiaToolStripMenuItem.Text = "Reporte Del Dia";
            // 
            // barberosToolStripMenuItem
            // 
            this.barberosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarModificarToolStripMenuItem1,
            this.pagoComisionesToolStripMenuItem,
            this.consultaDeComisionesPagadasToolStripMenuItem});
            this.barberosToolStripMenuItem.Name = "barberosToolStripMenuItem";
            this.barberosToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.barberosToolStripMenuItem.Text = "Barberos";
            // 
            // agregarModificarToolStripMenuItem1
            // 
            this.agregarModificarToolStripMenuItem1.Name = "agregarModificarToolStripMenuItem1";
            this.agregarModificarToolStripMenuItem1.Size = new System.Drawing.Size(276, 22);
            this.agregarModificarToolStripMenuItem1.Text = "Agregar / Modificar";
            // 
            // pagoComisionesToolStripMenuItem
            // 
            this.pagoComisionesToolStripMenuItem.Name = "pagoComisionesToolStripMenuItem";
            this.pagoComisionesToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.pagoComisionesToolStripMenuItem.Text = "Pago de Comisiones";
            this.pagoComisionesToolStripMenuItem.Click += new System.EventHandler(this.pagoComisionesToolStripMenuItem_Click);
            // 
            // consultaDeComisionesPagadasToolStripMenuItem
            // 
            this.consultaDeComisionesPagadasToolStripMenuItem.Name = "consultaDeComisionesPagadasToolStripMenuItem";
            this.consultaDeComisionesPagadasToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.consultaDeComisionesPagadasToolStripMenuItem.Text = "Consulta de Comisiones Pagadas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem1,
            this.comprasToolStripMenuItem1,
            this.articulosToolStripMenuItem,
            this.cajaToolStripMenuItem,
            this.clientesToolStripMenuItem1,
            this.estilistasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // comprasToolStripMenuItem1
            // 
            this.comprasToolStripMenuItem1.Name = "comprasToolStripMenuItem1";
            this.comprasToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.comprasToolStripMenuItem1.Text = "Compras";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            // 
            // cajaToolStripMenuItem
            // 
            this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            this.cajaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.cajaToolStripMenuItem.Text = "Caja";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // estilistasToolStripMenuItem
            // 
            this.estilistasToolStripMenuItem.Name = "estilistasToolStripMenuItem";
            this.estilistasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.estilistasToolStripMenuItem.Text = "Estilistas";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(111, 21);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarFondoDePantallaToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // cambiarFondoDePantallaToolStripMenuItem
            // 
            this.cambiarFondoDePantallaToolStripMenuItem.Name = "cambiarFondoDePantallaToolStripMenuItem";
            this.cambiarFondoDePantallaToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.cambiarFondoDePantallaToolStripMenuItem.Text = "Cambiar Fondo de Pantalla";
            this.cambiarFondoDePantallaToolStripMenuItem.Click += new System.EventHandler(this.cambiarFondoDePantallaToolStripMenuItem_Click);
            // 
            // btnBarbero
            // 
            this.btnBarbero.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarbero.Image = global::comensando_proyecto.Properties.Resources.user_offline;
            this.btnBarbero.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBarbero.Location = new System.Drawing.Point(26, 397);
            this.btnBarbero.Name = "btnBarbero";
            this.btnBarbero.Size = new System.Drawing.Size(104, 77);
            this.btnBarbero.TabIndex = 7;
            this.btnBarbero.Text = "&Barbero";
            this.btnBarbero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBarbero.UseVisualStyleBackColor = true;
            this.btnBarbero.Click += new System.EventHandler(this.btnBarbero_Click);
            this.btnBarbero.MouseLeave += new System.EventHandler(this.btnBarbero_MouseLeave);
            this.btnBarbero.MouseHover += new System.EventHandler(this.btnBarbero_MouseHover);
            // 
            // btnCortes
            // 
            this.btnCortes.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCortes.Image = ((System.Drawing.Image)(resources.GetObject("btnCortes.Image")));
            this.btnCortes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCortes.Location = new System.Drawing.Point(26, 314);
            this.btnCortes.Name = "btnCortes";
            this.btnCortes.Size = new System.Drawing.Size(104, 77);
            this.btnCortes.TabIndex = 6;
            this.btnCortes.Text = "&Cortes";
            this.btnCortes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCortes.UseVisualStyleBackColor = true;
            this.btnCortes.Click += new System.EventHandler(this.btnCortes_Click);
            this.btnCortes.MouseLeave += new System.EventHandler(this.btnCortes_MouseLeave);
            this.btnCortes.MouseHover += new System.EventHandler(this.btnCortes_MouseHover);
            // 
            // btnCierreTurno
            // 
            this.btnCierreTurno.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierreTurno.Image = ((System.Drawing.Image)(resources.GetObject("btnCierreTurno.Image")));
            this.btnCierreTurno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCierreTurno.Location = new System.Drawing.Point(26, 568);
            this.btnCierreTurno.Name = "btnCierreTurno";
            this.btnCierreTurno.Size = new System.Drawing.Size(104, 77);
            this.btnCierreTurno.TabIndex = 5;
            this.btnCierreTurno.Text = "&Cierre Turno";
            this.btnCierreTurno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCierreTurno.UseVisualStyleBackColor = true;
            this.btnCierreTurno.Click += new System.EventHandler(this.btnCierreTurno_Click);
            this.btnCierreTurno.MouseLeave += new System.EventHandler(this.btnCierreTurno_MouseLeave);
            this.btnCierreTurno.MouseHover += new System.EventHandler(this.btnCierreTurno_MouseHover);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientes.Location = new System.Drawing.Point(26, 148);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(104, 77);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "&Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            this.btnClientes.MouseLeave += new System.EventHandler(this.btnClientes_MouseLeave);
            this.btnClientes.MouseHover += new System.EventHandler(this.btnClientes_MouseHover);
            // 
            // btnReservas
            // 
            this.btnReservas.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.Image = ((System.Drawing.Image)(resources.GetObject("btnReservas.Image")));
            this.btnReservas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReservas.Location = new System.Drawing.Point(26, 480);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(104, 77);
            this.btnReservas.TabIndex = 3;
            this.btnReservas.Text = "&Reservas";
            this.btnReservas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.button3_Click);
            this.btnReservas.MouseLeave += new System.EventHandler(this.btnReservas_MouseLeave);
            this.btnReservas.MouseHover += new System.EventHandler(this.btnReservas_MouseHover);
            // 
            // btnVentas
            // 
            this.btnVentas.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVentas.Location = new System.Drawing.Point(26, 231);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(104, 77);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "&Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.button2_Click);
            this.btnVentas.MouseLeave += new System.EventHandler(this.btnVentas_MouseLeave);
            this.btnVentas.MouseHover += new System.EventHandler(this.btnVentas_MouseHover);
            // 
            // btnArticulos
            // 
            this.btnArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnArticulos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnArticulos.FlatAppearance.BorderSize = 5;
            this.btnArticulos.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.Image = ((System.Drawing.Image)(resources.GetObject("btnArticulos.Image")));
            this.btnArticulos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnArticulos.Location = new System.Drawing.Point(26, 65);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(104, 77);
            this.btnArticulos.TabIndex = 1;
            this.btnArticulos.Text = "&Articulos";
            this.btnArticulos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            this.btnArticulos.MouseLeave += new System.EventHandler(this.btnArticulos_MouseLeave);
            this.btnArticulos.MouseHover += new System.EventHandler(this.btnArticulos_MouseHover);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUsuario.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(527, 65);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(164, 38);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario :";
            // 
            // lblMostrarUsuario
            // 
            this.lblMostrarUsuario.AutoSize = true;
            this.lblMostrarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblMostrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMostrarUsuario.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarUsuario.Location = new System.Drawing.Point(691, 65);
            this.lblMostrarUsuario.Name = "lblMostrarUsuario";
            this.lblMostrarUsuario.Size = new System.Drawing.Size(0, 38);
            this.lblMostrarUsuario.TabIndex = 9;
            // 
            // frmventana_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::comensando_proyecto.Properties.Resources.LOGO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 695);
            this.Controls.Add(this.lblMostrarUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnBarbero);
            this.Controls.Add(this.btnCortes);
            this.Controls.Add(this.btnCierreTurno);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnReservas);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmventana_Principal";
            this.Text = "BarberShop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosDeMercaderiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barberosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCierreTurno;
        private System.Windows.Forms.Button btnCortes;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarModificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pagoComisionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeComisionesPagadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estilistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaDiariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDelDiaToolStripMenuItem;
        private System.Windows.Forms.Button btnBarbero;
        private System.Windows.Forms.ToolStripMenuItem cambiarFondoDePantallaToolStripMenuItem;
        private System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Label lblMostrarUsuario;
    }
}

