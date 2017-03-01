﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace comensando_proyecto
{
    public class clsVenta
    {
        private int _Id_Venta;

        
        private clsCliente _Cliente;
        private clsEmpleado _Empleado;                
        private string _TipoComprobnte;
        
        public clsVenta(clsCliente parCliente, clsEmpleado parEmpleado, string parTipoComprobante
                          )
        {
            Cliente = parCliente;
            Empleado = parEmpleado;
            TipoComprobante = parTipoComprobante;
            
                        
        }
        public clsVenta(string parTipoComprobante,clsEmpleado parEmpleado)
        { 
        TipoComprobante = parTipoComprobante;
        Empleado = parEmpleado;
        }
        public int Id_Venta
        {
            get { return _Id_Venta; }
            set { _Id_Venta = value; }
        }

        public clsCliente Cliente
        {
            get
            {
                return _Cliente;
            }
            set
            {
                _Cliente = value;
            }
        }

        public clsEmpleado Empleado
        {
            get
            {
                return _Empleado;
            }
            set
            {
                _Empleado = value;
            }
        }
        
        public string TipoComprobante
        {
            get
            {
                return _TipoComprobnte;
            }
            set
            {
                _TipoComprobnte = value;
            }
        }


        public void Guardar(List<clsClientesDeVenta> ClienteSeleccionados)
        {
            SqlConnection cn = new SqlConnection(mdlVariables.CadenaConexion);
            SqlCommand cmd = new SqlCommand("usp_Registrar_Venta", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@parTipoComprobante",TipoComprobante);
            cmd.Parameters.AddWithValue("@parId_Barbero", Empleado.IDEmpleado);

            cn.Open();
            Id_Venta= Convert.ToInt32(cmd.ExecuteScalar());

            foreach (clsClientesDeVenta item in ClienteSeleccionados)
            {
                cmd = new SqlCommand("usp_Cliente_venta", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@parId_Venta", Id_Venta);
                cmd.Parameters.AddWithValue("@parId_Cliente", item.Cliente.ID_Cliente);

                cmd.ExecuteNonQuery();
            }
            cn.Close();
        }


    }
}
