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
    public partial class frmBuscar_Articulo : Form
    {
        

        private clsArticulo _SeleccionarArticulo;

        public clsArticulo SeleccionarArticulo
        {
            get { return _SeleccionarArticulo; }
            set { _SeleccionarArticulo = value; }
        }

        private List<clsArticulo> _ArticuloEncontrado = new List<clsArticulo>();

        public List<clsArticulo> ArticuloEncontrado
        {
            get { return _ArticuloEncontrado; }
            set { _ArticuloEncontrado = value; }
        }

        public frmBuscar_Articulo()
        {
            InitializeComponent();
        }

        private void btnListarTods_Click(object sender, EventArgs e)
        {
            lstvDatos.Items.Clear();

            ArticuloEncontrado.Clear();
            int contador = 1;
            foreach (clsArticulo ELEMENTO in clsArticulo.Listar_Articulo())
            {

                ArticuloEncontrado.Add(ELEMENTO);

                lstvDatos.Items.Add(contador.ToString());
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Nombre.ToString());
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Marca.ToString());
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Tipo.ToString());
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Stock.ToString());
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.PrecioCompra.ToString());
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.PrecioVenta.ToString());
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaCompra.ToString());
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Descripcion.ToString());
                
                if (contador % 2 == 0)
                {
                    lstvDatos.Items[contador - 1].BackColor = Color.Khaki;
                }
                contador = contador + 1;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SeleccionarArticulo = null;
            Close();
        }

        private void btnAceptarArticulo_Click(object sender, EventArgs e)
        {
            
            SeleccionarArticulo = ArticuloEncontrado[lstvDatos.SelectedItems[0].Index];
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtBuscar.TextLength < 1)
            {
                MessageBox.Show("Inserte algun caracter para realizar la busqueda.");
            }
            else
            {
                lstvDatos.Items.Clear();

                ArticuloEncontrado.Clear();
                int contador = 1;
                //int SumaTotal = 0;
                foreach (clsArticulo ELEMENTO in clsArticulo.Listar_Articulo_Nombre(txtBuscar.Text))
                {

                    ArticuloEncontrado.Add(ELEMENTO);

                    lstvDatos.Items.Add(contador.ToString());
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Nombre.ToString());
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Marca.ToString());
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Tipo.ToString());
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Stock.ToString());
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.PrecioCompra.ToString());
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.PrecioVenta.ToString());
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaCompra.ToString());
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Descripcion.ToString());
                    //SumaTotal += ELEMENTO.PrecioVenta;

                    if (contador % 2 == 0)
                    {
                        lstvDatos.Items[contador - 1].BackColor = Color.Khaki;
                    }
                    contador = contador + 1;
                    
                }
                
            }
        }

        private void btnNuevoArticulo_Click(object sender, EventArgs e)
        {
            frmArticulo_Registrar x;
            x = new frmArticulo_Registrar();
            x.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                frmArticulo_Registrar NuevoDatos;
                NuevoDatos = new frmArticulo_Registrar();
                NuevoDatos.ArticuloSeleccionado = ArticuloEncontrado[lstvDatos.SelectedItems[0].Index];
                NuevoDatos.ShowDialog();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
               

            }
        }

        
    }
}
