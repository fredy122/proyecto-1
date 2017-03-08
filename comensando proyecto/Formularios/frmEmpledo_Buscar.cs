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
    public partial class frmBuscar_Empleado : Form
    {

        private clsEmpleado _empleadoseleccionado;

        public clsEmpleado Empleadoseleccionado
        {
            get { return _empleadoseleccionado; }
            set { _empleadoseleccionado = value; }
        }

        

        private List<clsEmpleado> _EmpleadoEncontrado = new List<clsEmpleado>();

        public List<clsEmpleado> EmpleadoEncontrado
        {
            get { return _EmpleadoEncontrado; }
            set { _EmpleadoEncontrado = value; }
        }




        public frmBuscar_Empleado()
        {
            InitializeComponent();
        }

        

        private void txtListarTodos_Click(object sender, EventArgs e)
        {


                EmpleadoEncontrado.Clear();
                lstvDatos.Items.Clear();
                int contador = 1;
                foreach (clsEmpleado ELEMENTO in clsEmpleado.Listar_Todos_Empleados())
                {
                    EmpleadoEncontrado.Add(ELEMENTO);
                    lstvDatos.Items.Add(contador.ToString());
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Nombre);
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Apellido);
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.DNI);
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Edad.ToString());
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Correo);
                    if (contador % 2 == 0)
                    {
                        lstvDatos.Items[contador - 1].BackColor = Color.Khaki;
                    }
                    contador = contador + 1;

                }
            
            
        }

        private void frmBuscar_Empleado_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevoEmpledo_Click(object sender, EventArgs e)
        {
            frmEmpleado_Registrar x;
            x = new frmEmpleado_Registrar();
            x.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEmpleado_Editar x;
            x = new frmEmpleado_Editar();
            x.EmpleadoSeleccionado = EmpleadoEncontrado[lstvDatos.SelectedItems[0].Index];
            x.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            if (txtBuscar.TextLength < 1)
            {
                lstvDatos.Items.Clear();
            }
            else
            {
                EmpleadoEncontrado.Clear();
                lstvDatos.Items.Clear();
                int contador = 1;
                foreach (clsEmpleado ELEMENTO in clsEmpleado.Buscar_Empleado_PorApellido(txtBuscar.Text))
                {
                    EmpleadoEncontrado.Add(ELEMENTO);
                    lstvDatos.Items.Add(contador.ToString());
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Nombre);
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Apellido);
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.DNI);
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Edad.ToString());
                    lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Correo);


                    if (contador % 2 == 0)
                    {
                        lstvDatos.Items[contador - 1].BackColor = Color.Khaki;
                    }
                    contador = contador + 1;
                }
            }
            
        }
    }

    }
