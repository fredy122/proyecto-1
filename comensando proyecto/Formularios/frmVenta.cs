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
    public partial class frmVenta : Form
    {
        private List<clsArticuloDeVenta> _ArticuloSeleccionadoVenta = new List<clsArticuloDeVenta>();

        public List<clsArticuloDeVenta> ArticuloSeleccionadoVentas
        {
            get { return _ArticuloSeleccionadoVenta; }
            set { _ArticuloSeleccionadoVenta = value; }
        }


        private List<clsArticulo> _LosArticulos = new List<clsArticulo>();

        public List<clsArticulo> LosArticulos
        {
            get { return _LosArticulos; }
            set { _LosArticulos = value; }
        }

        private List<clsEmpleado> _Losbarberos = new List<clsEmpleado>();

        public List<clsEmpleado> Losbarberos
        {
            get { return _Losbarberos; }
            set { _Losbarberos = value; }
        }

        private List<clsCliente> _LosClientes = new List<clsCliente>();

        public List<clsCliente> LosClientes
        {
            get { return _LosClientes; }
            set { _LosClientes = value; }
        }

        


        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            cmbBarbero.Items.Clear();
            Losbarberos.Clear();
            foreach (clsEmpleado ELEMENTO in clsEmpleado.Listar_Todos_Empleados())
            {
                Losbarberos.Add(ELEMENTO);
                cmbBarbero.Items.Add(ELEMENTO.Nombre);
            }
        }

        private void btnBuscarCliene_Click(object sender, EventArgs e)
        {
            frmBuscarClientes x;
            x = new frmBuscarClientes();
            x.btnAceptar.Visible = true;
            x.ShowDialog();

           
            if (x.ClienteSeleccionado == null)
	        {
		        MessageBox.Show("La busqueda fue cancelada.");
	        }
            else
	        {
               

                txtNombreCliente.Text = x.ClienteSeleccionado.Nombre;
                txtApellidoCliente.Text = x.ClienteSeleccionado.Apellido;
                txtCorreoCliente.Text = x.ClienteSeleccionado.Correo;
                txtDNI.Text = x.ClienteSeleccionado.DNI;
                
	        }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBuscar_Articulo x;
            x = new frmBuscar_Articulo();
            x.btnAceptarArticulo.Visible = true;
            x.label1.Visible = true;
            x.nudCantidad.Visible = true;
            x.ShowDialog();

            int sumarPuntos = 0;
            if (x.SeleccionarArticulo == null)
            {
                MessageBox.Show("La busqueda fue cancelada. ");
            }
            else
            {
                frmBuscar_Articulo i = new frmBuscar_Articulo();

                clsArticuloDeVenta aux;
                aux = new clsArticuloDeVenta(x.SeleccionarArticulo);
                ArticuloSeleccionadoVentas.Add(aux); 
		            int y = lstvDatosVenta.Items.Count;
                    lstvDatosVenta.Items.Add(i.nudCantidad.Value.ToString());                
                    lstvDatosVenta.Items[y].SubItems.Add(x.SeleccionarArticulo.Nombre);
                    lstvDatosVenta.Items[y].SubItems.Add(x.SeleccionarArticulo.PrecioVenta.ToString());
                    sumarPuntos = +Convert.ToInt32(x.SeleccionarArticulo.PrecioVenta);	                                                     
            }
            txtPrecioTotal.Text = sumarPuntos.ToString();            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            clsVenta nuevaVenta;
            nuevaVenta = new clsVenta(Convert.ToString(cmbTipoComprobante.SelectedItem),Losbarberos[cmbBarbero.SelectedIndex]);
            nuevaVenta.Guardar(ArticuloSeleccionadoVentas);
            MessageBox.Show("venta agregada satisfactoriamente.", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnBuscarCorte_Click(object sender, EventArgs e)
        {
            frmBuscar_Corte i;
            i = new frmBuscar_Corte();
            i.btnAceptar.Visible = true;
            i.ShowDialog();

            if (i.CorteSeleccionado == null)
            {
                MessageBox.Show("La busqueda fue cancelada. ");
            }
            else
            {
                clsArticuloDeVenta auxiliar;
                auxiliar = new clsArticuloDeVenta(i.CorteSeleccionado);
                ArticuloSeleccionadoVentas.Add(auxiliar);
                int y = lstvDatosVenta.Items.Count;
                lstvDatosVenta.Items.Add("1");
                lstvDatosVenta.Items[y].SubItems.Add(i.CorteSeleccionado.Nombre);
                lstvDatosVenta.Items[y].SubItems.Add(i.CorteSeleccionado.Precio.ToString());
            }
        }
    }
}
