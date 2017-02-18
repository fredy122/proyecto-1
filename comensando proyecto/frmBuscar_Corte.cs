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
    public partial class frmBuscar_Corte : Form
    {

        private clsCliente _corteSeleccionado;

        public clsCliente CorteSeleccionado
        {
            get { return _corteSeleccionado; }
            set { _corteSeleccionado = value; }
        }

        private List<clsCliente> _CorteEncontrado = new List<clsCliente>();

        public List<clsCliente> CorteEncontrado
        {
            get { return _CorteEncontrado; }
            set { _CorteEncontrado = value; }
        }


        public frmBuscar_Corte()
        {
            InitializeComponent();
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            lstvDatos.Items.Clear();
            //CorteEncontrado.Clear();
            int contador = 1;
            foreach (clsCorte ELEMENTO in clsCorte.Listar_Corte())
            {
               

                lstvDatos.Items.Add(contador.ToString());
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Nombre);
                lstvDatos.Items[contador - 1].SubItems.Add(ELEMENTO.Precio.ToString());
                

                if (contador % 2 == 0)
                {
                    lstvDatos.Items[contador - 1].BackColor = Color.Blue;
                }
                contador = contador + 1;

            }
        }

        private void btnNuevoCorte_Click(object sender, EventArgs e)
        {
            frmCorte_Registrar x;
            x = new frmCorte_Registrar();
            x.ShowDialog();
        }
    }
}
