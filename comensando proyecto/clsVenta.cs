using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace comensando_proyecto
{
    public class clsVenta
    {
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


        public void insertar_venta()
        {
            SqlConnection conexion;

            conexion = new
            SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");


            SqlCommand comando;

            comando = new SqlCommand("usp_venta_insertar", conexion);

            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@parTipoComprobamte", TipoComprobante);
            comando.Parameters.AddWithValue("@parDNIEmpleado" );
            
                      
            
            

            
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close(); 
 
        }


    }
}
