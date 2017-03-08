using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comensando_proyecto.Formularios
{
    public partial class frmReporte_Clientes : Form
    {
        public frmReporte_Clientes()
        {
            InitializeComponent();
        }

        private void frmReporte_Clientes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

    }
}
