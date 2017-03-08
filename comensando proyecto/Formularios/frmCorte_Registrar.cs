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
    public partial class frmCorte_Registrar : Form
    {
        public frmCorte_Registrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsCorte nuevo;
            nuevo = new clsCorte(txtNombre.Text, Convert.ToSingle(txtprecio.Text));
            nuevo.insertar();
            MessageBox.Show("Corte ingresado. ");

        }

       
    }
}
