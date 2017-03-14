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
    public partial class frmEmpleado_Registrar : Form
    {
        public frmEmpleado_Registrar()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsEmpleado x;
            if (rbM.Checked == true)
            {
                x = new clsEmpleado(txtDNI.Text, txtNombre.Text, txtApellidos.Text, txtTelefono.Text, txtDireccion.Text, 'M', Convert.ToDateTime(dtpFechaNac.Value), txtCorreo.Text);
            }
            else
            {
                x = new clsEmpleado(txtDNI.Text, txtNombre.Text, txtApellidos.Text, txtTelefono.Text, txtDireccion.Text, 'F', Convert.ToDateTime(dtpFechaNac.Value), txtCorreo.Text);
            }
            x.Usuario = txtUsuario.Text;
            x.TipoUsuario = cmbTipoUsuario.SelectedIndex.ToString();
            x.Contrasena = txtContrasena.Text;
            x.Insertar_Empleado();
            MessageBox.Show("Cliente Ingresado", "Aqui que ira", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
