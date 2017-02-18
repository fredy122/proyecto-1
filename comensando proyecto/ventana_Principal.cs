using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comensando_proyecto
{
    public partial class ventana_Principal : Form
    {
        public ventana_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pagoComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            frmBuscar_Articulo x;
            x = new frmBuscar_Articulo();
            x.Show();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVenta x;
            x = new frmVenta();
            x.Show();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmBuscarClientes x;
            x = new frmBuscarClientes();
            x.Show();
        }

        private void cambiarFondoDePantallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Filter = "Archivos JPEG(*.Jpg) |*.jpg";
            Abrir.InitialDirectory = "F:";

            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                string Dir = Abrir.FileName;
                Bitmap Pinture = new Bitmap(Dir);

                BackgroundImage = (Image)Pinture;

            }
        }

        private void btnArticulos_MouseHover(object sender, EventArgs e)
        {
            btnArticulos.Size = new Size(107, 80);
            btnArticulos.ForeColor = Color.Red;
        }

        private void btnArticulos_MouseLeave(object sender, EventArgs e)
        {
            btnArticulos.Size = new Size(104, 77);
            btnArticulos.ForeColor = Color.Black;
        }

        private void btnClientes_MouseHover(object sender, EventArgs e)
        {
            btnClientes.Size = new Size(107, 80);
            btnClientes.ForeColor = Color.Red;
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            btnClientes.Size = new Size(104, 77);
            btnClientes.ForeColor = Color.Black;
        }

        private void btnVentas_MouseHover(object sender, EventArgs e)
        {
            btnVentas.Size = new Size(107, 80);
            btnVentas.ForeColor = Color.Red;
        }

        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
            btnVentas.Size = new Size(104, 77);
            btnVentas.ForeColor = Color.Black;
        }

        private void btnCortes_MouseHover(object sender, EventArgs e)
        {
            btnCortes.Size = new Size(107, 80);
            btnCortes.ForeColor = Color.Red;
        }

        private void btnCortes_MouseLeave(object sender, EventArgs e)
        {
            btnCortes.Size = new Size(104, 77);
            btnCortes.ForeColor = Color.Black;
        }

        private void btnBarbero_MouseHover(object sender, EventArgs e)
        {
            btnBarbero.Size = new Size(107, 80);
            btnBarbero.ForeColor = Color.Red;
        }

        private void btnBarbero_MouseLeave(object sender, EventArgs e)
        {
            btnBarbero.Size = new Size(104, 77);
            btnBarbero.ForeColor = Color.Black;
        }

        private void btnReservas_MouseHover(object sender, EventArgs e)
        {
            btnReservas.Size = new Size(107, 80);
            btnReservas.ForeColor = Color.Red;
        }

        private void btnReservas_MouseLeave(object sender, EventArgs e)
        {
            btnReservas.Size = new Size(104, 77);
            btnReservas.ForeColor = Color.Black;
        }

        private void btnCierreTurno_Click(object sender, EventArgs e)
        {

        }

        private void btnCierreTurno_MouseHover(object sender, EventArgs e)
        {
            btnCierreTurno.Size = new Size(107, 80);
            btnCierreTurno.ForeColor = Color.Red;
        }

        private void btnCierreTurno_MouseLeave(object sender, EventArgs e)
        {
            btnCierreTurno.Size = new Size(104, 77);
            btnCierreTurno.ForeColor = Color.Black
                ;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmBuscarClientes x;
            x = new frmBuscarClientes();
            x.ShowDialog();
            
        }

        private void btnCortes_Click(object sender, EventArgs e)
        {
            frmBuscar_Corte x;
            x = new frmBuscar_Corte();
            x.ShowDialog();
        }

        private void btnBarbero_Click(object sender, EventArgs e)
        {
            frmBuscar_Empleado x;
            x = new frmBuscar_Empleado();
            x.ShowDialog();
        }

        

        

        
    }
}
