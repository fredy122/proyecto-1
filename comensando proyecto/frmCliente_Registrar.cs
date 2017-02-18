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
    public partial class frmCliente_Registrar : Form
    {
        public frmCliente_Registrar()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            clsCliente x;

            try
            {
                if (rbM.Checked == true)
                {
                    x = new clsCliente(txtNombre.Text, txtApellidos.Text,
                                   txtCorreo.Text, 'M', Convert.ToDateTime(dtpFechaNac.Value));
                }
                else
                {
                    x = new clsCliente(txtNombre.Text, txtApellidos.Text,
                                   txtCorreo.Text, 'F', Convert.ToDateTime(dtpFechaNac.Value));
                }

                x.DNI = txtDNI.Text;
                x.Telefono = txtTelefono.Text;
                x.Ocupacion = txtOcupacion.Text;
                x.Insertar_Cliente();
                MessageBox.Show("Cliente ingresado.");
            }
            catch (Exception miError)
            {
                MessageBox.Show(miError.Message);
                
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clsEmpleado x;
            //if (rbM.Checked == true)
            //{
            //    x = new clsEmpleado(txtDNI.Text, txtNombre.Text, txtApellidos.Text, txtTelefono.Text, txtOcupacion.Text, true, Convert.ToByte(nudEdad.Value), txtCorreo.Text);

            //}
            //else
            //{
            //    x = new clsEmpleado(txtDNI.Text, txtNombre.Text, txtApellidos.Text, txtTelefono.Text, txtOcupacion.Text, false, Convert.ToByte(nudEdad.Value), txtCorreo.Text);
            //}

            //x.Insertar_Empleado();
            //MessageBox.Show("Cliente Ingresado", "Aqui que ira", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
