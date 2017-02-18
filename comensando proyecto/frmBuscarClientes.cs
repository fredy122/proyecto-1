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
    public partial class frmBuscarClientes : Form
    {

        private clsCliente _clienteSeleccionado;

        public clsCliente ClienteSeleccionado
        {
            get { return _clienteSeleccionado; }
            set { _clienteSeleccionado = value; }
        }

        private List<clsCliente> _ClienteEncontrado = new List<clsCliente>();

        public List<clsCliente> ClienteEncontrado
        {
            get { return _ClienteEncontrado; }
            set { _ClienteEncontrado = value; }
        }


         

        public frmBuscarClientes()
        {
            InitializeComponent();
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            lstvDatos.Items.Clear();
            ClienteEncontrado.Clear();
            int contador = 1;
            foreach (clsCliente ELEMENTO in clsCliente.Listar())
            {
                ClienteEncontrado.Add(ELEMENTO);

                

                lstvDatos.Items.Add(contador.ToString());               
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Nombre);
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Apellido);
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaNacimiento.ToString());
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Correo);
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.DNI);
                

                if (contador % 2 == 0)
                {
                    lstvDatos.Items[contador - 1].BackColor = Color.Blue;
                }
                contador = contador + 1;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (rbApellido.Checked)
            {
                
                if (txtBuscar.TextLength < 1)
                {
                    MessageBox.Show("Debe introducir algun caracter para realizar la busqueda.");
                }
                else
                {
                    
                    lstvDatos.Items.Clear();

                    ClienteEncontrado.Clear();

                    int contador = 1;
                    foreach (clsCliente ELEMENTO in clsCliente.Buscar_PorApellido(txtBuscar.Text))
                    {
                        ClienteEncontrado.Add(ELEMENTO);

                        lstvDatos.Items.Add(contador.ToString());
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Nombre);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Apellido);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaNacimiento.ToString());
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Correo);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.DNI);

                        if (contador % 2 == 0)
                        {
                            lstvDatos.Items[contador - 1].BackColor = Color.Purple;
                        }
                        contador = contador + 1;

                    }
                }

            
            }
            
            else if (rbDNI.Checked)
            {
                
                if (txtBuscar.TextLength < 1)
                {
                    MessageBox.Show("Debe introducir algun caracter para realizar la busqueda.");
                }
                else
                {
                    
                    lstvDatos.Items.Clear();

                    ClienteEncontrado.Clear();

                    int contador = 1;
                    foreach (clsCliente ELEMENTO in clsCliente.Buscar_PorDNI(txtBuscar.Text))
                    {
                        ClienteEncontrado.Add(ELEMENTO);

                        lstvDatos.Items.Add(contador.ToString());
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Nombre);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Apellido);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.FechaNacimiento.ToString());
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Correo);
                        lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.DNI);

                        if (contador % 2 == 0)
                        {
                            lstvDatos.Items[contador - 1].BackColor = Color.Purple;
                        }
                        contador = contador + 1;

                    }
                }
            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //button salir
            ClienteSeleccionado = null;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ClienteSeleccionado = ClienteEncontrado[lstvDatos.SelectedItems[0].Index];
            Close();
        }

        private void lstvDatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnAceptar_Click(sender, e);
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmCliente_Registrar x;
            x = new frmCliente_Registrar();
            x.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmEditar_Cliente i;
            i = new frmEditar_Cliente();
            i.clienteselecionado = ClienteEncontrado[lstvDatos.SelectedItems[0].Index];
            i.ShowDialog();
           

            
        }

        private void frmBuscarClientes_Load(object sender, EventArgs e)
        {

        }

        

        

        

       

    }
} 
