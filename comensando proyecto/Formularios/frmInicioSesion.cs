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
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                mdlVariables.UsuarioConectado = clsEmpleado.Validar_Credenciales(txtUsuario.Text,
                                        txtContraseña.Text);

                if (mdlVariables.UsuarioConectado == null)
                {
                    MessageBox.Show("Usuario y/o clave incorrecto.");
                }
                else
                {
                    MessageBox.Show("Bienvenido a HUANCAYORK.");

                    this.Hide();
                    frmventana_Principal x =new frmventana_Principal();
                    x.lblMostrarUsuario.Text = txtUsuario.Text;
                    x.ShowDialog();

                }
            }
            catch (Exception mierror)
            {
                MessageBox.Show(mierror.Message);

            }
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.Size = new Size(92, 35);
            btnLogin.ForeColor = Color.Red;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.Size = new Size(89, 32);
            btnLogin.ForeColor = Color.Black;
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            
        }

        private void chbMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMostrarContraseña.Checked == true)
            {
                if (txtContraseña.PasswordChar == '*')
                {
                    txtContraseña.PasswordChar = '\0';
                }
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
            
        }
    }
}
