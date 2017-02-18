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
    public partial class frmEditar_Cliente : Form
    {

        private clsCliente _clienteselecionado;

        public clsCliente clienteselecionado
        {
            get { return _clienteselecionado; }
            set { _clienteselecionado = value; }
        }
        
        public frmEditar_Cliente()
        {
            InitializeComponent();
        }

        private void frmEditar_Cliente_Load(object sender, EventArgs e)
        {
            txtID_Cliente.Text = clienteselecionado.ID_Cliente.ToString();
            txtNombre.Text = clienteselecionado.Nombre;
            txtApellidos.Text = clienteselecionado.Apellido;
            txtDNI.Text = clienteselecionado.DNI;
            txtCorreo.Text = clienteselecionado.Correo;
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsCliente actualizar;
            actualizar = new clsCliente(txtNombre.Text, txtApellidos.Text, txtCorreo.Text, txtDNI.Text);

            clienteselecionado.Actualizar_cliente(actualizar);
            
            MessageBox.Show("cliente actualizado");
        }
    }
}
