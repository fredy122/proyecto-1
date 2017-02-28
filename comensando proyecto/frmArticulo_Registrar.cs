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
    public partial class frmArticulo_Registrar : Form
    {
        public frmArticulo_Registrar()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsArticulo x;

            x = new clsArticulo(txtNombre.Text, txtlote.Text, txtmarca.Text, Convert.ToInt32(nudcantidad.Value), txttipoarticulo.Text, Convert.ToByte(nudpreciocompra.Value),
                                Convert.ToByte(nudprecioventa.Value), Convert.ToByte(nudstock.Value));
            x.Descripcion = txtdescripcion.Text;

            x.Insertar_Articulo();
            MessageBox.Show("Articulo ingresado.");
        }
    }
}
