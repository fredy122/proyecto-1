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
    public partial class frmEmpleado_Editar : Form
    {
        private clsEmpleado _EmpleadoSeleccionado;

        public clsEmpleado EmpleadoSeleccionado
        {
            get { return _EmpleadoSeleccionado; }
            set { _EmpleadoSeleccionado = value; }
        }



        public frmEmpleado_Editar()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmEmpleado_Editar_Load(object sender, EventArgs e)
        {
            txtNombre.Text = EmpleadoSeleccionado.Nombre;
            txtApellidos.Text = EmpleadoSeleccionado.Apellido;
            txtCorreo.Text = EmpleadoSeleccionado.Correo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsEmpleado actualizar;
            actualizar = new clsEmpleado(txtNombre.Text, txtApellidos.Text, txtCorreo.Text);

            EmpleadoSeleccionado.Actualizar_empleado(actualizar);

            MessageBox.Show("cliente actualizado");
        }
    }
}
