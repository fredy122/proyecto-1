﻿using System;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                mdliImgresar_Usuario.UsuarioConectado = clsEmpleado.Validar_Credenciales(txtUsuario.Text,
                                        txtContraseña.Text);

                if (mdliImgresar_Usuario.UsuarioConectado == null)
                {
                    MessageBox.Show("Usuario y/o clave incorrecto.");
                }
                else
                {
                    MessageBox.Show("Bienvenido a HUANCAYORK.");
                    login i;
                    i = new login();
                    i.Close();
                    
                    ventana_Principal x;
                    x = new ventana_Principal();
                    x.ShowDialog();
                }
            }
            catch (Exception mierror)
            {
                MessageBox.Show(mierror.Message);

            }
        }
    }
}
